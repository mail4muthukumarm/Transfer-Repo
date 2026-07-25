// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.Locations.dsUnderwritingLocations
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
namespace MGASystems.IMS.Policies.Rating.Locations;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsUnderwritingLocations")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsUnderwritingLocations : DataSet
{
  private dsUnderwritingLocations.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;
  private dsUnderwritingLocations.lstConstructionTypesDataTable tablelstConstructionTypes;
  private dsUnderwritingLocations.tblFin_ExpensePayeesDataTable tabletblFin_ExpensePayees;
  private dsUnderwritingLocations.lstClassCodesDataTable tablelstClassCodes;
  private dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesDataTable tablelstUnderwritingLocations_AlarmTypes;
  private dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesDataTable tablelstUnderwritingLocations_SprinklerTypes;
  private dsUnderwritingLocations.lstWindRestrictionsDataTable tablelstWindRestrictions;
  private dsUnderwritingLocations.dtLocationsDataTable tabledtLocations;
  private dsUnderwritingLocations.dtRoofInspectionCompaniesDataTable tabledtRoofInspectionCompanies;
  private dsUnderwritingLocations.lstFloodZonesDataTable tablelstFloodZones;
  private DataRelation relationlstConstructionTypestblUnderwritingLocations;
  private DataRelation relationlstPolicyClassestblUnderwritingLocations;
  private DataRelation relationtblInspectionCompaniestblUnderwritingLocations;
  private DataRelation relationlstUnderwritingLocations_AlarmTypestblUnderwritingLocations;
  private DataRelation relationlstUnderwritingLocations_AlarmTypestblUnderwritingLocations1;
  private DataRelation relationlstUnderwritingLocations_SprinklerTypestblUnderwritingLocations;
  private DataRelation relationlstWindRestrictionstblUnderwritingLocations;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsUnderwritingLocations()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected dsUnderwritingLocations(SerializationInfo info, StreamingContext context)
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
          base.Tables.Add((DataTable) new dsUnderwritingLocations.tblUnderwritingLocationsDataTable(dataSet.Tables[nameof (tblUnderwritingLocations)]));
        if (dataSet.Tables[nameof (lstConstructionTypes)] != null)
          base.Tables.Add((DataTable) new dsUnderwritingLocations.lstConstructionTypesDataTable(dataSet.Tables[nameof (lstConstructionTypes)]));
        if (dataSet.Tables[nameof (tblFin_ExpensePayees)] != null)
          base.Tables.Add((DataTable) new dsUnderwritingLocations.tblFin_ExpensePayeesDataTable(dataSet.Tables[nameof (tblFin_ExpensePayees)]));
        if (dataSet.Tables[nameof (lstClassCodes)] != null)
          base.Tables.Add((DataTable) new dsUnderwritingLocations.lstClassCodesDataTable(dataSet.Tables[nameof (lstClassCodes)]));
        if (dataSet.Tables[nameof (lstUnderwritingLocations_AlarmTypes)] != null)
          base.Tables.Add((DataTable) new dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesDataTable(dataSet.Tables[nameof (lstUnderwritingLocations_AlarmTypes)]));
        if (dataSet.Tables[nameof (lstUnderwritingLocations_SprinklerTypes)] != null)
          base.Tables.Add((DataTable) new dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesDataTable(dataSet.Tables[nameof (lstUnderwritingLocations_SprinklerTypes)]));
        if (dataSet.Tables[nameof (lstWindRestrictions)] != null)
          base.Tables.Add((DataTable) new dsUnderwritingLocations.lstWindRestrictionsDataTable(dataSet.Tables[nameof (lstWindRestrictions)]));
        if (dataSet.Tables[nameof (dtLocations)] != null)
          base.Tables.Add((DataTable) new dsUnderwritingLocations.dtLocationsDataTable(dataSet.Tables[nameof (dtLocations)]));
        if (dataSet.Tables[nameof (dtRoofInspectionCompanies)] != null)
          base.Tables.Add((DataTable) new dsUnderwritingLocations.dtRoofInspectionCompaniesDataTable(dataSet.Tables[nameof (dtRoofInspectionCompanies)]));
        if (dataSet.Tables[nameof (lstFloodZones)] != null)
          base.Tables.Add((DataTable) new dsUnderwritingLocations.lstFloodZonesDataTable(dataSet.Tables[nameof (lstFloodZones)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsUnderwritingLocations.tblUnderwritingLocationsDataTable tblUnderwritingLocations
  {
    get => this.tabletblUnderwritingLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsUnderwritingLocations.lstConstructionTypesDataTable lstConstructionTypes
  {
    get => this.tablelstConstructionTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsUnderwritingLocations.tblFin_ExpensePayeesDataTable tblFin_ExpensePayees
  {
    get => this.tabletblFin_ExpensePayees;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsUnderwritingLocations.lstClassCodesDataTable lstClassCodes => this.tablelstClassCodes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesDataTable lstUnderwritingLocations_AlarmTypes
  {
    get => this.tablelstUnderwritingLocations_AlarmTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesDataTable lstUnderwritingLocations_SprinklerTypes
  {
    get => this.tablelstUnderwritingLocations_SprinklerTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsUnderwritingLocations.lstWindRestrictionsDataTable lstWindRestrictions
  {
    get => this.tablelstWindRestrictions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsUnderwritingLocations.dtLocationsDataTable dtLocations => this.tabledtLocations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsUnderwritingLocations.dtRoofInspectionCompaniesDataTable dtRoofInspectionCompanies
  {
    get => this.tabledtRoofInspectionCompanies;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsUnderwritingLocations.lstFloodZonesDataTable lstFloodZones => this.tablelstFloodZones;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public override DataSet Clone()
  {
    dsUnderwritingLocations underwritingLocations = (dsUnderwritingLocations) base.Clone();
    underwritingLocations.InitVars();
    underwritingLocations.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) underwritingLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["tblUnderwritingLocations"] != null)
        base.Tables.Add((DataTable) new dsUnderwritingLocations.tblUnderwritingLocationsDataTable(dataSet.Tables["tblUnderwritingLocations"]));
      if (dataSet.Tables["lstConstructionTypes"] != null)
        base.Tables.Add((DataTable) new dsUnderwritingLocations.lstConstructionTypesDataTable(dataSet.Tables["lstConstructionTypes"]));
      if (dataSet.Tables["tblFin_ExpensePayees"] != null)
        base.Tables.Add((DataTable) new dsUnderwritingLocations.tblFin_ExpensePayeesDataTable(dataSet.Tables["tblFin_ExpensePayees"]));
      if (dataSet.Tables["lstClassCodes"] != null)
        base.Tables.Add((DataTable) new dsUnderwritingLocations.lstClassCodesDataTable(dataSet.Tables["lstClassCodes"]));
      if (dataSet.Tables["lstUnderwritingLocations_AlarmTypes"] != null)
        base.Tables.Add((DataTable) new dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesDataTable(dataSet.Tables["lstUnderwritingLocations_AlarmTypes"]));
      if (dataSet.Tables["lstUnderwritingLocations_SprinklerTypes"] != null)
        base.Tables.Add((DataTable) new dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesDataTable(dataSet.Tables["lstUnderwritingLocations_SprinklerTypes"]));
      if (dataSet.Tables["lstWindRestrictions"] != null)
        base.Tables.Add((DataTable) new dsUnderwritingLocations.lstWindRestrictionsDataTable(dataSet.Tables["lstWindRestrictions"]));
      if (dataSet.Tables["dtLocations"] != null)
        base.Tables.Add((DataTable) new dsUnderwritingLocations.dtLocationsDataTable(dataSet.Tables["dtLocations"]));
      if (dataSet.Tables["dtRoofInspectionCompanies"] != null)
        base.Tables.Add((DataTable) new dsUnderwritingLocations.dtRoofInspectionCompaniesDataTable(dataSet.Tables["dtRoofInspectionCompanies"]));
      if (dataSet.Tables["lstFloodZones"] != null)
        base.Tables.Add((DataTable) new dsUnderwritingLocations.lstFloodZonesDataTable(dataSet.Tables["lstFloodZones"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tabletblUnderwritingLocations = (dsUnderwritingLocations.tblUnderwritingLocationsDataTable) base.Tables["tblUnderwritingLocations"];
    if (initTable && this.tabletblUnderwritingLocations != null)
      this.tabletblUnderwritingLocations.InitVars();
    this.tablelstConstructionTypes = (dsUnderwritingLocations.lstConstructionTypesDataTable) base.Tables["lstConstructionTypes"];
    if (initTable && this.tablelstConstructionTypes != null)
      this.tablelstConstructionTypes.InitVars();
    this.tabletblFin_ExpensePayees = (dsUnderwritingLocations.tblFin_ExpensePayeesDataTable) base.Tables["tblFin_ExpensePayees"];
    if (initTable && this.tabletblFin_ExpensePayees != null)
      this.tabletblFin_ExpensePayees.InitVars();
    this.tablelstClassCodes = (dsUnderwritingLocations.lstClassCodesDataTable) base.Tables["lstClassCodes"];
    if (initTable && this.tablelstClassCodes != null)
      this.tablelstClassCodes.InitVars();
    this.tablelstUnderwritingLocations_AlarmTypes = (dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesDataTable) base.Tables["lstUnderwritingLocations_AlarmTypes"];
    if (initTable && this.tablelstUnderwritingLocations_AlarmTypes != null)
      this.tablelstUnderwritingLocations_AlarmTypes.InitVars();
    this.tablelstUnderwritingLocations_SprinklerTypes = (dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesDataTable) base.Tables["lstUnderwritingLocations_SprinklerTypes"];
    if (initTable && this.tablelstUnderwritingLocations_SprinklerTypes != null)
      this.tablelstUnderwritingLocations_SprinklerTypes.InitVars();
    this.tablelstWindRestrictions = (dsUnderwritingLocations.lstWindRestrictionsDataTable) base.Tables["lstWindRestrictions"];
    if (initTable && this.tablelstWindRestrictions != null)
      this.tablelstWindRestrictions.InitVars();
    this.tabledtLocations = (dsUnderwritingLocations.dtLocationsDataTable) base.Tables["dtLocations"];
    if (initTable && this.tabledtLocations != null)
      this.tabledtLocations.InitVars();
    this.tabledtRoofInspectionCompanies = (dsUnderwritingLocations.dtRoofInspectionCompaniesDataTable) base.Tables["dtRoofInspectionCompanies"];
    if (initTable && this.tabledtRoofInspectionCompanies != null)
      this.tabledtRoofInspectionCompanies.InitVars();
    this.tablelstFloodZones = (dsUnderwritingLocations.lstFloodZonesDataTable) base.Tables["lstFloodZones"];
    if (initTable && this.tablelstFloodZones != null)
      this.tablelstFloodZones.InitVars();
    this.relationlstConstructionTypestblUnderwritingLocations = this.Relations["lstConstructionTypestblUnderwritingLocations"];
    this.relationlstPolicyClassestblUnderwritingLocations = this.Relations["lstPolicyClassestblUnderwritingLocations"];
    this.relationtblInspectionCompaniestblUnderwritingLocations = this.Relations["tblInspectionCompaniestblUnderwritingLocations"];
    this.relationlstUnderwritingLocations_AlarmTypestblUnderwritingLocations = this.Relations["lstUnderwritingLocations_AlarmTypestblUnderwritingLocations"];
    this.relationlstUnderwritingLocations_AlarmTypestblUnderwritingLocations1 = this.Relations["lstUnderwritingLocations_AlarmTypestblUnderwritingLocations1"];
    this.relationlstUnderwritingLocations_SprinklerTypestblUnderwritingLocations = this.Relations["lstUnderwritingLocations_SprinklerTypestblUnderwritingLocations"];
    this.relationlstWindRestrictionstblUnderwritingLocations = this.Relations["lstWindRestrictionstblUnderwritingLocations"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsUnderwritingLocations);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsUnderwritingLocations.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblUnderwritingLocations = new dsUnderwritingLocations.tblUnderwritingLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblUnderwritingLocations);
    this.tablelstConstructionTypes = new dsUnderwritingLocations.lstConstructionTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstConstructionTypes);
    this.tabletblFin_ExpensePayees = new dsUnderwritingLocations.tblFin_ExpensePayeesDataTable();
    base.Tables.Add((DataTable) this.tabletblFin_ExpensePayees);
    this.tablelstClassCodes = new dsUnderwritingLocations.lstClassCodesDataTable();
    base.Tables.Add((DataTable) this.tablelstClassCodes);
    this.tablelstUnderwritingLocations_AlarmTypes = new dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstUnderwritingLocations_AlarmTypes);
    this.tablelstUnderwritingLocations_SprinklerTypes = new dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstUnderwritingLocations_SprinklerTypes);
    this.tablelstWindRestrictions = new dsUnderwritingLocations.lstWindRestrictionsDataTable();
    base.Tables.Add((DataTable) this.tablelstWindRestrictions);
    this.tabledtLocations = new dsUnderwritingLocations.dtLocationsDataTable();
    base.Tables.Add((DataTable) this.tabledtLocations);
    this.tabledtRoofInspectionCompanies = new dsUnderwritingLocations.dtRoofInspectionCompaniesDataTable();
    base.Tables.Add((DataTable) this.tabledtRoofInspectionCompanies);
    this.tablelstFloodZones = new dsUnderwritingLocations.lstFloodZonesDataTable();
    base.Tables.Add((DataTable) this.tablelstFloodZones);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("lstConstructionTypestblUnderwritingLocations", new DataColumn[1]
    {
      this.tablelstConstructionTypes.ConstructionTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.ConstructionIDColumn
    });
    this.tabletblUnderwritingLocations.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstPolicyClassestblUnderwritingLocations", new DataColumn[1]
    {
      this.tablelstClassCodes.ClassCodeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.ClassCodeIDColumn
    });
    this.tabletblUnderwritingLocations.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("tblInspectionCompaniestblUnderwritingLocations", new DataColumn[1]
    {
      this.tabletblFin_ExpensePayees.PayeeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.InspectionCompanyIDColumn
    });
    this.tabletblUnderwritingLocations.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("lstUnderwritingLocations_AlarmTypestblUnderwritingLocations", new DataColumn[1]
    {
      this.tablelstUnderwritingLocations_AlarmTypes.AlarmTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.FireAlarmTypeIDColumn
    });
    this.tabletblUnderwritingLocations.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint5 = new ForeignKeyConstraint("lstUnderwritingLocations_AlarmTypestblUnderwritingLocations1", new DataColumn[1]
    {
      this.tablelstUnderwritingLocations_AlarmTypes.AlarmTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.BurglarAlarmTypeIDColumn
    });
    this.tabletblUnderwritingLocations.Constraints.Add((Constraint) foreignKeyConstraint5);
    foreignKeyConstraint5.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint5.DeleteRule = Rule.Cascade;
    foreignKeyConstraint5.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint6 = new ForeignKeyConstraint("lstUnderwritingLocations_SprinklerTypestblUnderwritingLocations", new DataColumn[1]
    {
      this.tablelstUnderwritingLocations_SprinklerTypes.SprinklerTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.SprinklerTypeIDColumn
    });
    this.tabletblUnderwritingLocations.Constraints.Add((Constraint) foreignKeyConstraint6);
    foreignKeyConstraint6.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint6.DeleteRule = Rule.Cascade;
    foreignKeyConstraint6.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint7 = new ForeignKeyConstraint("lstWindRestrictionstblUnderwritingLocations", new DataColumn[1]
    {
      this.tablelstWindRestrictions.RestrictionIDColumn
    }, new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.WindRestrictionIDColumn
    });
    this.tabletblUnderwritingLocations.Constraints.Add((Constraint) foreignKeyConstraint7);
    foreignKeyConstraint7.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint7.DeleteRule = Rule.Cascade;
    foreignKeyConstraint7.UpdateRule = Rule.Cascade;
    this.relationlstConstructionTypestblUnderwritingLocations = new DataRelation("lstConstructionTypestblUnderwritingLocations", new DataColumn[1]
    {
      this.tablelstConstructionTypes.ConstructionTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.ConstructionIDColumn
    }, false);
    this.Relations.Add(this.relationlstConstructionTypestblUnderwritingLocations);
    this.relationlstPolicyClassestblUnderwritingLocations = new DataRelation("lstPolicyClassestblUnderwritingLocations", new DataColumn[1]
    {
      this.tablelstClassCodes.ClassCodeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.ClassCodeIDColumn
    }, false);
    this.Relations.Add(this.relationlstPolicyClassestblUnderwritingLocations);
    this.relationtblInspectionCompaniestblUnderwritingLocations = new DataRelation("tblInspectionCompaniestblUnderwritingLocations", new DataColumn[1]
    {
      this.tabletblFin_ExpensePayees.PayeeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.InspectionCompanyIDColumn
    }, false);
    this.Relations.Add(this.relationtblInspectionCompaniestblUnderwritingLocations);
    this.relationlstUnderwritingLocations_AlarmTypestblUnderwritingLocations = new DataRelation("lstUnderwritingLocations_AlarmTypestblUnderwritingLocations", new DataColumn[1]
    {
      this.tablelstUnderwritingLocations_AlarmTypes.AlarmTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.FireAlarmTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstUnderwritingLocations_AlarmTypestblUnderwritingLocations);
    this.relationlstUnderwritingLocations_AlarmTypestblUnderwritingLocations1 = new DataRelation("lstUnderwritingLocations_AlarmTypestblUnderwritingLocations1", new DataColumn[1]
    {
      this.tablelstUnderwritingLocations_AlarmTypes.AlarmTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.BurglarAlarmTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstUnderwritingLocations_AlarmTypestblUnderwritingLocations1);
    this.relationlstUnderwritingLocations_SprinklerTypestblUnderwritingLocations = new DataRelation("lstUnderwritingLocations_SprinklerTypestblUnderwritingLocations", new DataColumn[1]
    {
      this.tablelstUnderwritingLocations_SprinklerTypes.SprinklerTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.SprinklerTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstUnderwritingLocations_SprinklerTypestblUnderwritingLocations);
    this.relationlstWindRestrictionstblUnderwritingLocations = new DataRelation("lstWindRestrictionstblUnderwritingLocations", new DataColumn[1]
    {
      this.tablelstWindRestrictions.RestrictionIDColumn
    }, new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.WindRestrictionIDColumn
    }, false);
    this.Relations.Add(this.relationlstWindRestrictionstblUnderwritingLocations);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblUnderwritingLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstConstructionTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblFin_ExpensePayees() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstClassCodes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstUnderwritingLocations_AlarmTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstUnderwritingLocations_SprinklerTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstWindRestrictions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtRoofInspectionCompanies() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstFloodZones() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsUnderwritingLocations underwritingLocations = new dsUnderwritingLocations();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = underwritingLocations.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = underwritingLocations.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblUnderwritingLocationsRowChangeEventHandler(
    object sender,
    dsUnderwritingLocations.tblUnderwritingLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstConstructionTypesRowChangeEventHandler(
    object sender,
    dsUnderwritingLocations.lstConstructionTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblFin_ExpensePayeesRowChangeEventHandler(
    object sender,
    dsUnderwritingLocations.tblFin_ExpensePayeesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstClassCodesRowChangeEventHandler(
    object sender,
    dsUnderwritingLocations.lstClassCodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstUnderwritingLocations_AlarmTypesRowChangeEventHandler(
    object sender,
    dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstUnderwritingLocations_SprinklerTypesRowChangeEventHandler(
    object sender,
    dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstWindRestrictionsRowChangeEventHandler(
    object sender,
    dsUnderwritingLocations.lstWindRestrictionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtLocationsRowChangeEventHandler(
    object sender,
    dsUnderwritingLocations.dtLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtRoofInspectionCompaniesRowChangeEventHandler(
    object sender,
    dsUnderwritingLocations.dtRoofInspectionCompaniesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstFloodZonesRowChangeEventHandler(
    object sender,
    dsUnderwritingLocations.lstFloodZonesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblUnderwritingLocationsDataTable : 
    TypedTableBase<dsUnderwritingLocations.tblUnderwritingLocationsRow>
  {
    private DataColumn columnLocationID;
    private DataColumn columnLocationGUID;
    private DataColumn columnQuoteGUID;
    private DataColumn columnLocationNo;
    private DataColumn columnBuildingNo;
    private DataColumn columnPhysicalBuildingNo;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnCounty;
    private DataColumn columnZip;
    private DataColumn columnZipPlus;
    private DataColumn columnConstructionID;
    private DataColumn columnClassCodeID;
    private DataColumn columnProtectionCode;
    private DataColumn columnAddnInformation;
    private DataColumn columnSqFootage;
    private DataColumn columnEQZone;
    private DataColumn columnFloodZone;
    private DataColumn columnEQConstruction;
    private DataColumn columnWindCoverage;
    private DataColumn columnTerritory;
    private DataColumn columnTaxTerritory;
    private DataColumn columnInspect;
    private DataColumn columnPhoto;
    private DataColumn columnDiagram;
    private DataColumn columnCostEstimator;
    private DataColumn columnUserAdded;
    private DataColumn columnDateAdded;
    private DataColumn columnDistToFireHydrant;
    private DataColumn columnDistToFireStation;
    private DataColumn columnFireDistrict;
    private DataColumn columnStories;
    private DataColumn columnBasements;
    private DataColumn columnElevators;
    private DataColumn columnYearBuilt;
    private DataColumn columnWiringYear;
    private DataColumn columnRoofingYear;
    private DataColumn columnPlumbingYear;
    private DataColumn columnHeatingYear;
    private DataColumn columnModificationCode;
    private DataColumn columnInspectionCompanyID;
    private DataColumn columnInspectionContact;
    private DataColumn columnInspectionContactPhone;
    private DataColumn columnComments;
    private DataColumn columnFireAlarmTypeID;
    private DataColumn columnBurglarAlarmTypeID;
    private DataColumn columnSprinklerTypeID;
    private DataColumn columnLockedAndSecured;
    private DataColumn columnVacant;
    private DataColumn columnWindRestrictionID;
    private DataColumn columnGEOPhyBuildNum;
    private DataColumn columnGEOAddress1;
    private DataColumn columnGEOAddress2;
    private DataColumn columnGEOCity;
    private DataColumn columnGEOState;
    private DataColumn columnGEOCounty;
    private DataColumn columnGEOZip;
    private DataColumn columnGEOZipPlus;
    private DataColumn columnRecCheck;
    private DataColumn columnRush;
    private DataColumn columnDueDate;
    private DataColumn columnLatitude;
    private DataColumn columnLongitude;
    private DataColumn columnGeoStatus;
    private DataColumn columnGeoURL;
    private DataColumn columnLocationLookup;
    private DataColumn columnBaseLocationId;
    private DataColumn columnDeleteRecord;
    private DataColumn columnRoofInspectionCompanyID;
    private DataColumn columnContactEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblUnderwritingLocationsDataTable()
    {
      this.TableName = "tblUnderwritingLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblUnderwritingLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationGUIDColumn => this.columnLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteGUIDColumn => this.columnQuoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationNoColumn => this.columnLocationNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BuildingNoColumn => this.columnBuildingNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PhysicalBuildingNoColumn => this.columnPhysicalBuildingNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Address1Column => this.columnAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Address2Column => this.columnAddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CountyColumn => this.columnCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ZipColumn => this.columnZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ZipPlusColumn => this.columnZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ConstructionIDColumn => this.columnConstructionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClassCodeIDColumn => this.columnClassCodeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProtectionCodeColumn => this.columnProtectionCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AddnInformationColumn => this.columnAddnInformation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SqFootageColumn => this.columnSqFootage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EQZoneColumn => this.columnEQZone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FloodZoneColumn => this.columnFloodZone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EQConstructionColumn => this.columnEQConstruction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WindCoverageColumn => this.columnWindCoverage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TerritoryColumn => this.columnTerritory;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TaxTerritoryColumn => this.columnTaxTerritory;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectColumn => this.columnInspect;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PhotoColumn => this.columnPhoto;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DiagramColumn => this.columnDiagram;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CostEstimatorColumn => this.columnCostEstimator;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UserAddedColumn => this.columnUserAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateAddedColumn => this.columnDateAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DistToFireHydrantColumn => this.columnDistToFireHydrant;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DistToFireStationColumn => this.columnDistToFireStation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FireDistrictColumn => this.columnFireDistrict;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StoriesColumn => this.columnStories;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BasementsColumn => this.columnBasements;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ElevatorsColumn => this.columnElevators;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn YearBuiltColumn => this.columnYearBuilt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WiringYearColumn => this.columnWiringYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RoofingYearColumn => this.columnRoofingYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PlumbingYearColumn => this.columnPlumbingYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn HeatingYearColumn => this.columnHeatingYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ModificationCodeColumn => this.columnModificationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionCompanyIDColumn => this.columnInspectionCompanyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionContactColumn => this.columnInspectionContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionContactPhoneColumn => this.columnInspectionContactPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CommentsColumn => this.columnComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FireAlarmTypeIDColumn => this.columnFireAlarmTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BurglarAlarmTypeIDColumn => this.columnBurglarAlarmTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SprinklerTypeIDColumn => this.columnSprinklerTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LockedAndSecuredColumn => this.columnLockedAndSecured;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn VacantColumn => this.columnVacant;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WindRestrictionIDColumn => this.columnWindRestrictionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GEOPhyBuildNumColumn => this.columnGEOPhyBuildNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GEOAddress1Column => this.columnGEOAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GEOAddress2Column => this.columnGEOAddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GEOCityColumn => this.columnGEOCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GEOStateColumn => this.columnGEOState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GEOCountyColumn => this.columnGEOCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GEOZipColumn => this.columnGEOZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GEOZipPlusColumn => this.columnGEOZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RecCheckColumn => this.columnRecCheck;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RushColumn => this.columnRush;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LatitudeColumn => this.columnLatitude;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LongitudeColumn => this.columnLongitude;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GeoStatusColumn => this.columnGeoStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GeoURLColumn => this.columnGeoURL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationLookupColumn => this.columnLocationLookup;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BaseLocationIdColumn => this.columnBaseLocationId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DeleteRecordColumn => this.columnDeleteRecord;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RoofInspectionCompanyIDColumn => this.columnRoofInspectionCompanyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ContactEmailColumn => this.columnContactEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblUnderwritingLocationsRow this[int index]
    {
      get => (dsUnderwritingLocations.tblUnderwritingLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblUnderwritingLocationsRow(
      dsUnderwritingLocations.tblUnderwritingLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblUnderwritingLocationsRow AddtblUnderwritingLocationsRow(
      Guid LocationGUID,
      Guid QuoteGUID,
      int LocationNo,
      string BuildingNo,
      string PhysicalBuildingNo,
      string Address1,
      string Address2,
      string City,
      string State,
      string County,
      string Zip,
      string ZipPlus,
      dsUnderwritingLocations.lstConstructionTypesRow parentlstConstructionTypesRowBylstConstructionTypestblUnderwritingLocations,
      dsUnderwritingLocations.lstClassCodesRow parentlstClassCodesRowBylstPolicyClassestblUnderwritingLocations,
      string ProtectionCode,
      string AddnInformation,
      int SqFootage,
      string EQZone,
      string FloodZone,
      string EQConstruction,
      bool WindCoverage,
      string Territory,
      string TaxTerritory,
      bool Inspect,
      bool Photo,
      bool Diagram,
      bool CostEstimator,
      Guid UserAdded,
      DateTime DateAdded,
      int DistToFireHydrant,
      Decimal DistToFireStation,
      string FireDistrict,
      Decimal Stories,
      int Basements,
      int Elevators,
      short YearBuilt,
      short WiringYear,
      short RoofingYear,
      short PlumbingYear,
      short HeatingYear,
      string ModificationCode,
      dsUnderwritingLocations.tblFin_ExpensePayeesRow parenttblFin_ExpensePayeesRowBytblInspectionCompaniestblUnderwritingLocations,
      string InspectionContact,
      string InspectionContactPhone,
      string Comments,
      dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow parentlstUnderwritingLocations_AlarmTypesRowBylstUnderwritingLocations_AlarmTypestblUnderwritingLocations,
      dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow parentlstUnderwritingLocations_AlarmTypesRowBylstUnderwritingLocations_AlarmTypestblUnderwritingLocations1,
      dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow parentlstUnderwritingLocations_SprinklerTypesRowBylstUnderwritingLocations_SprinklerTypestblUnderwritingLocations,
      bool LockedAndSecured,
      bool Vacant,
      dsUnderwritingLocations.lstWindRestrictionsRow parentlstWindRestrictionsRowBylstWindRestrictionstblUnderwritingLocations,
      string GEOPhyBuildNum,
      string GEOAddress1,
      string GEOAddress2,
      string GEOCity,
      string GEOState,
      string GEOCounty,
      string GEOZip,
      string GEOZipPlus,
      bool RecCheck,
      bool Rush,
      DateTime DueDate,
      string Latitude,
      string Longitude,
      string GeoStatus,
      string GeoURL,
      bool LocationLookup,
      int BaseLocationId,
      bool DeleteRecord,
      int RoofInspectionCompanyID,
      string ContactEmail)
    {
      dsUnderwritingLocations.tblUnderwritingLocationsRow row = (dsUnderwritingLocations.tblUnderwritingLocationsRow) this.NewRow();
      object[] objArray = new object[72]
      {
        null,
        (object) LocationGUID,
        (object) QuoteGUID,
        (object) LocationNo,
        (object) BuildingNo,
        (object) PhysicalBuildingNo,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) State,
        (object) County,
        (object) Zip,
        (object) ZipPlus,
        null,
        null,
        (object) ProtectionCode,
        (object) AddnInformation,
        (object) SqFootage,
        (object) EQZone,
        (object) FloodZone,
        (object) EQConstruction,
        (object) WindCoverage,
        (object) Territory,
        (object) TaxTerritory,
        (object) Inspect,
        (object) Photo,
        (object) Diagram,
        (object) CostEstimator,
        (object) UserAdded,
        (object) DateAdded,
        (object) DistToFireHydrant,
        (object) DistToFireStation,
        (object) FireDistrict,
        (object) Stories,
        (object) Basements,
        (object) Elevators,
        (object) YearBuilt,
        (object) WiringYear,
        (object) RoofingYear,
        (object) PlumbingYear,
        (object) HeatingYear,
        (object) ModificationCode,
        null,
        (object) InspectionContact,
        (object) InspectionContactPhone,
        (object) Comments,
        null,
        null,
        null,
        (object) LockedAndSecured,
        (object) Vacant,
        null,
        (object) GEOPhyBuildNum,
        (object) GEOAddress1,
        (object) GEOAddress2,
        (object) GEOCity,
        (object) GEOState,
        (object) GEOCounty,
        (object) GEOZip,
        (object) GEOZipPlus,
        (object) RecCheck,
        (object) Rush,
        (object) DueDate,
        (object) Latitude,
        (object) Longitude,
        (object) GeoStatus,
        (object) GeoURL,
        (object) LocationLookup,
        (object) BaseLocationId,
        (object) DeleteRecord,
        (object) RoofInspectionCompanyID,
        (object) ContactEmail
      };
      if (parentlstConstructionTypesRowBylstConstructionTypestblUnderwritingLocations != null)
        objArray[13] = RuntimeHelpers.GetObjectValue(parentlstConstructionTypesRowBylstConstructionTypestblUnderwritingLocations[0]);
      if (parentlstClassCodesRowBylstPolicyClassestblUnderwritingLocations != null)
        objArray[14] = RuntimeHelpers.GetObjectValue(parentlstClassCodesRowBylstPolicyClassestblUnderwritingLocations[0]);
      if (parenttblFin_ExpensePayeesRowBytblInspectionCompaniestblUnderwritingLocations != null)
        objArray[42] = RuntimeHelpers.GetObjectValue(parenttblFin_ExpensePayeesRowBytblInspectionCompaniestblUnderwritingLocations[0]);
      if (parentlstUnderwritingLocations_AlarmTypesRowBylstUnderwritingLocations_AlarmTypestblUnderwritingLocations != null)
        objArray[46] = RuntimeHelpers.GetObjectValue(parentlstUnderwritingLocations_AlarmTypesRowBylstUnderwritingLocations_AlarmTypestblUnderwritingLocations[0]);
      if (parentlstUnderwritingLocations_AlarmTypesRowBylstUnderwritingLocations_AlarmTypestblUnderwritingLocations1 != null)
        objArray[47] = RuntimeHelpers.GetObjectValue(parentlstUnderwritingLocations_AlarmTypesRowBylstUnderwritingLocations_AlarmTypestblUnderwritingLocations1[0]);
      if (parentlstUnderwritingLocations_SprinklerTypesRowBylstUnderwritingLocations_SprinklerTypestblUnderwritingLocations != null)
        objArray[48 /*0x30*/] = RuntimeHelpers.GetObjectValue(parentlstUnderwritingLocations_SprinklerTypesRowBylstUnderwritingLocations_SprinklerTypestblUnderwritingLocations[0]);
      if (parentlstWindRestrictionsRowBylstWindRestrictionstblUnderwritingLocations != null)
        objArray[51] = RuntimeHelpers.GetObjectValue(parentlstWindRestrictionsRowBylstWindRestrictionstblUnderwritingLocations[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblUnderwritingLocationsRow FindByLocationID(int LocationID)
    {
      return (dsUnderwritingLocations.tblUnderwritingLocationsRow) this.Rows.Find(new object[1]
      {
        (object) LocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsUnderwritingLocations.tblUnderwritingLocationsDataTable locationsDataTable = (dsUnderwritingLocations.tblUnderwritingLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsUnderwritingLocations.tblUnderwritingLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnLocationID = this.Columns["LocationID"];
      this.columnLocationGUID = this.Columns["LocationGUID"];
      this.columnQuoteGUID = this.Columns["QuoteGUID"];
      this.columnLocationNo = this.Columns["LocationNo"];
      this.columnBuildingNo = this.Columns["BuildingNo"];
      this.columnPhysicalBuildingNo = this.Columns["PhysicalBuildingNo"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnCounty = this.Columns["County"];
      this.columnZip = this.Columns["Zip"];
      this.columnZipPlus = this.Columns["ZipPlus"];
      this.columnConstructionID = this.Columns["ConstructionID"];
      this.columnClassCodeID = this.Columns["ClassCodeID"];
      this.columnProtectionCode = this.Columns["ProtectionCode"];
      this.columnAddnInformation = this.Columns["AddnInformation"];
      this.columnSqFootage = this.Columns["SqFootage"];
      this.columnEQZone = this.Columns["EQZone"];
      this.columnFloodZone = this.Columns["FloodZone"];
      this.columnEQConstruction = this.Columns["EQConstruction"];
      this.columnWindCoverage = this.Columns["WindCoverage"];
      this.columnTerritory = this.Columns["Territory"];
      this.columnTaxTerritory = this.Columns["TaxTerritory"];
      this.columnInspect = this.Columns["Inspect"];
      this.columnPhoto = this.Columns["Photo"];
      this.columnDiagram = this.Columns["Diagram"];
      this.columnCostEstimator = this.Columns["CostEstimator"];
      this.columnUserAdded = this.Columns["UserAdded"];
      this.columnDateAdded = this.Columns["DateAdded"];
      this.columnDistToFireHydrant = this.Columns["DistToFireHydrant"];
      this.columnDistToFireStation = this.Columns["DistToFireStation"];
      this.columnFireDistrict = this.Columns["FireDistrict"];
      this.columnStories = this.Columns["Stories"];
      this.columnBasements = this.Columns["Basements"];
      this.columnElevators = this.Columns["Elevators"];
      this.columnYearBuilt = this.Columns["YearBuilt"];
      this.columnWiringYear = this.Columns["WiringYear"];
      this.columnRoofingYear = this.Columns["RoofingYear"];
      this.columnPlumbingYear = this.Columns["PlumbingYear"];
      this.columnHeatingYear = this.Columns["HeatingYear"];
      this.columnModificationCode = this.Columns["ModificationCode"];
      this.columnInspectionCompanyID = this.Columns["InspectionCompanyID"];
      this.columnInspectionContact = this.Columns["InspectionContact"];
      this.columnInspectionContactPhone = this.Columns["InspectionContactPhone"];
      this.columnComments = this.Columns["Comments"];
      this.columnFireAlarmTypeID = this.Columns["FireAlarmTypeID"];
      this.columnBurglarAlarmTypeID = this.Columns["BurglarAlarmTypeID"];
      this.columnSprinklerTypeID = this.Columns["SprinklerTypeID"];
      this.columnLockedAndSecured = this.Columns["LockedAndSecured"];
      this.columnVacant = this.Columns["Vacant"];
      this.columnWindRestrictionID = this.Columns["WindRestrictionID"];
      this.columnGEOPhyBuildNum = this.Columns["GEOPhyBuildNum"];
      this.columnGEOAddress1 = this.Columns["GEOAddress1"];
      this.columnGEOAddress2 = this.Columns["GEOAddress2"];
      this.columnGEOCity = this.Columns["GEOCity"];
      this.columnGEOState = this.Columns["GEOState"];
      this.columnGEOCounty = this.Columns["GEOCounty"];
      this.columnGEOZip = this.Columns["GEOZip"];
      this.columnGEOZipPlus = this.Columns["GEOZipPlus"];
      this.columnRecCheck = this.Columns["RecCheck"];
      this.columnRush = this.Columns["Rush"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnLatitude = this.Columns["Latitude"];
      this.columnLongitude = this.Columns["Longitude"];
      this.columnGeoStatus = this.Columns["GeoStatus"];
      this.columnGeoURL = this.Columns["GeoURL"];
      this.columnLocationLookup = this.Columns["LocationLookup"];
      this.columnBaseLocationId = this.Columns["BaseLocationId"];
      this.columnDeleteRecord = this.Columns["DeleteRecord"];
      this.columnRoofInspectionCompanyID = this.Columns["RoofInspectionCompanyID"];
      this.columnContactEmail = this.Columns["ContactEmail"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnLocationGUID = new DataColumn("LocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationGUID);
      this.columnQuoteGUID = new DataColumn("QuoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGUID);
      this.columnLocationNo = new DataColumn("LocationNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationNo);
      this.columnBuildingNo = new DataColumn("BuildingNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBuildingNo);
      this.columnPhysicalBuildingNo = new DataColumn("PhysicalBuildingNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhysicalBuildingNo);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnAddress2 = new DataColumn("Address2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnCounty = new DataColumn("County", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCounty);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.columnZipPlus = new DataColumn("ZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipPlus);
      this.columnConstructionID = new DataColumn("ConstructionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConstructionID);
      this.columnClassCodeID = new DataColumn("ClassCodeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeID);
      this.columnProtectionCode = new DataColumn("ProtectionCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProtectionCode);
      this.columnAddnInformation = new DataColumn("AddnInformation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddnInformation);
      this.columnSqFootage = new DataColumn("SqFootage", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSqFootage);
      this.columnEQZone = new DataColumn("EQZone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEQZone);
      this.columnFloodZone = new DataColumn("FloodZone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFloodZone);
      this.columnEQConstruction = new DataColumn("EQConstruction", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEQConstruction);
      this.columnWindCoverage = new DataColumn("WindCoverage", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWindCoverage);
      this.columnTerritory = new DataColumn("Territory", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerritory);
      this.columnTaxTerritory = new DataColumn("TaxTerritory", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxTerritory);
      this.columnInspect = new DataColumn("Inspect", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspect);
      this.columnPhoto = new DataColumn("Photo", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhoto);
      this.columnDiagram = new DataColumn("Diagram", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDiagram);
      this.columnCostEstimator = new DataColumn("CostEstimator", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostEstimator);
      this.columnUserAdded = new DataColumn("UserAdded", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserAdded);
      this.columnDateAdded = new DataColumn("DateAdded", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateAdded);
      this.columnDistToFireHydrant = new DataColumn("DistToFireHydrant", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDistToFireHydrant);
      this.columnDistToFireStation = new DataColumn("DistToFireStation", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDistToFireStation);
      this.columnFireDistrict = new DataColumn("FireDistrict", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFireDistrict);
      this.columnStories = new DataColumn("Stories", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStories);
      this.columnBasements = new DataColumn("Basements", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBasements);
      this.columnElevators = new DataColumn("Elevators", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnElevators);
      this.columnYearBuilt = new DataColumn("YearBuilt", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYearBuilt);
      this.columnWiringYear = new DataColumn("WiringYear", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWiringYear);
      this.columnRoofingYear = new DataColumn("RoofingYear", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoofingYear);
      this.columnPlumbingYear = new DataColumn("PlumbingYear", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPlumbingYear);
      this.columnHeatingYear = new DataColumn("HeatingYear", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHeatingYear);
      this.columnModificationCode = new DataColumn("ModificationCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModificationCode);
      this.columnInspectionCompanyID = new DataColumn("InspectionCompanyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionCompanyID);
      this.columnInspectionContact = new DataColumn("InspectionContact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionContact);
      this.columnInspectionContactPhone = new DataColumn("InspectionContactPhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionContactPhone);
      this.columnComments = new DataColumn("Comments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComments);
      this.columnFireAlarmTypeID = new DataColumn("FireAlarmTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFireAlarmTypeID);
      this.columnBurglarAlarmTypeID = new DataColumn("BurglarAlarmTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBurglarAlarmTypeID);
      this.columnSprinklerTypeID = new DataColumn("SprinklerTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSprinklerTypeID);
      this.columnLockedAndSecured = new DataColumn("LockedAndSecured", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLockedAndSecured);
      this.columnVacant = new DataColumn("Vacant", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVacant);
      this.columnWindRestrictionID = new DataColumn("WindRestrictionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWindRestrictionID);
      this.columnGEOPhyBuildNum = new DataColumn("GEOPhyBuildNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGEOPhyBuildNum);
      this.columnGEOAddress1 = new DataColumn("GEOAddress1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGEOAddress1);
      this.columnGEOAddress2 = new DataColumn("GEOAddress2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGEOAddress2);
      this.columnGEOCity = new DataColumn("GEOCity", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGEOCity);
      this.columnGEOState = new DataColumn("GEOState", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGEOState);
      this.columnGEOCounty = new DataColumn("GEOCounty", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGEOCounty);
      this.columnGEOZip = new DataColumn("GEOZip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGEOZip);
      this.columnGEOZipPlus = new DataColumn("GEOZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGEOZipPlus);
      this.columnRecCheck = new DataColumn("RecCheck", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecCheck);
      this.columnRush = new DataColumn("Rush", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRush);
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnLatitude = new DataColumn("Latitude", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLatitude);
      this.columnLongitude = new DataColumn("Longitude", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLongitude);
      this.columnGeoStatus = new DataColumn("GeoStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGeoStatus);
      this.columnGeoURL = new DataColumn("GeoURL", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGeoURL);
      this.columnLocationLookup = new DataColumn("LocationLookup", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationLookup);
      this.columnBaseLocationId = new DataColumn("BaseLocationId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBaseLocationId);
      this.columnDeleteRecord = new DataColumn("DeleteRecord", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeleteRecord);
      this.columnRoofInspectionCompanyID = new DataColumn("RoofInspectionCompanyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoofInspectionCompanyID);
      this.columnContactEmail = new DataColumn("ContactEmail", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactEmail);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnLocationID
      }, true));
      this.columnLocationID.AutoIncrement = true;
      this.columnLocationID.AllowDBNull = false;
      this.columnLocationID.ReadOnly = true;
      this.columnLocationID.Unique = true;
      this.columnLocationGUID.AllowDBNull = false;
      this.columnQuoteGUID.AllowDBNull = false;
      this.columnWindCoverage.AllowDBNull = false;
      this.columnWindCoverage.DefaultValue = (object) false;
      this.columnInspect.AllowDBNull = false;
      this.columnInspect.DefaultValue = (object) false;
      this.columnPhoto.AllowDBNull = false;
      this.columnPhoto.DefaultValue = (object) false;
      this.columnDiagram.AllowDBNull = false;
      this.columnDiagram.DefaultValue = (object) false;
      this.columnCostEstimator.AllowDBNull = false;
      this.columnCostEstimator.DefaultValue = (object) false;
      this.columnUserAdded.AllowDBNull = false;
      this.columnDateAdded.AllowDBNull = false;
      this.columnModificationCode.AllowDBNull = false;
      this.columnModificationCode.DefaultValue = (object) "N";
      this.columnLockedAndSecured.AllowDBNull = false;
      this.columnLockedAndSecured.DefaultValue = (object) false;
      this.columnVacant.AllowDBNull = false;
      this.columnVacant.DefaultValue = (object) false;
      this.columnGEOPhyBuildNum.MaxLength = 50;
      this.columnGEOAddress1.MaxLength = 200;
      this.columnGEOAddress2.MaxLength = 200;
      this.columnGEOCity.MaxLength = 50;
      this.columnGEOState.MaxLength = 2;
      this.columnGEOCounty.MaxLength = 20;
      this.columnGEOZip.MaxLength = 5;
      this.columnGEOZipPlus.MaxLength = 4;
      this.columnLocationLookup.DefaultValue = (object) false;
      this.columnDeleteRecord.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblUnderwritingLocationsRow NewtblUnderwritingLocationsRow()
    {
      return (dsUnderwritingLocations.tblUnderwritingLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsUnderwritingLocations.tblUnderwritingLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsUnderwritingLocations.tblUnderwritingLocationsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.tblUnderwritingLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblUnderwritingLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsUnderwritingLocations.tblUnderwritingLocationsRowChangeEvent((dsUnderwritingLocations.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.tblUnderwritingLocationsRowChangeEventHandler rowChangingEvent = this.tblUnderwritingLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsUnderwritingLocations.tblUnderwritingLocationsRowChangeEvent((dsUnderwritingLocations.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.tblUnderwritingLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblUnderwritingLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsUnderwritingLocations.tblUnderwritingLocationsRowChangeEvent((dsUnderwritingLocations.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.tblUnderwritingLocationsRowChangeEventHandler rowDeletingEvent = this.tblUnderwritingLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsUnderwritingLocations.tblUnderwritingLocationsRowChangeEvent((dsUnderwritingLocations.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblUnderwritingLocationsRow(
      dsUnderwritingLocations.tblUnderwritingLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsUnderwritingLocations underwritingLocations = new dsUnderwritingLocations();
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
        FixedValue = underwritingLocations.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUnderwritingLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = underwritingLocations.GetSchemaSerializable();
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
  public class lstConstructionTypesDataTable : 
    TypedTableBase<dsUnderwritingLocations.lstConstructionTypesRow>
  {
    private DataColumn columnConstructionTypeID;
    private DataColumn columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstConstructionTypesDataTable()
    {
      this.TableName = "lstConstructionTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstConstructionTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ConstructionTypeIDColumn => this.columnConstructionTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstConstructionTypesRow this[int index]
    {
      get => (dsUnderwritingLocations.lstConstructionTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstConstructionTypesRow(
      dsUnderwritingLocations.lstConstructionTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstConstructionTypesRow AddlstConstructionTypesRow(string Type)
    {
      dsUnderwritingLocations.lstConstructionTypesRow row = (dsUnderwritingLocations.lstConstructionTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) Type
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstConstructionTypesRow FindByConstructionTypeID(
      int ConstructionTypeID)
    {
      return (dsUnderwritingLocations.lstConstructionTypesRow) this.Rows.Find(new object[1]
      {
        (object) ConstructionTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsUnderwritingLocations.lstConstructionTypesDataTable constructionTypesDataTable = (dsUnderwritingLocations.lstConstructionTypesDataTable) base.Clone();
      constructionTypesDataTable.InitVars();
      return (DataTable) constructionTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsUnderwritingLocations.lstConstructionTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnConstructionTypeID = this.Columns["ConstructionTypeID"];
      this.columnType = this.Columns["Type"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnConstructionTypeID = new DataColumn("ConstructionTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConstructionTypeID);
      this.columnType = new DataColumn("Type", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsUnderwritingLocationsKey1", new DataColumn[1]
      {
        this.columnConstructionTypeID
      }, true));
      this.columnConstructionTypeID.AutoIncrement = true;
      this.columnConstructionTypeID.AllowDBNull = false;
      this.columnConstructionTypeID.ReadOnly = true;
      this.columnConstructionTypeID.Unique = true;
      this.columnType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstConstructionTypesRow NewlstConstructionTypesRow()
    {
      return (dsUnderwritingLocations.lstConstructionTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsUnderwritingLocations.lstConstructionTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsUnderwritingLocations.lstConstructionTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstConstructionTypesRowChangeEventHandler typesRowChangedEvent = this.lstConstructionTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsUnderwritingLocations.lstConstructionTypesRowChangeEvent((dsUnderwritingLocations.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstConstructionTypesRowChangeEventHandler rowChangingEvent = this.lstConstructionTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsUnderwritingLocations.lstConstructionTypesRowChangeEvent((dsUnderwritingLocations.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstConstructionTypesRowChangeEventHandler typesRowDeletedEvent = this.lstConstructionTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsUnderwritingLocations.lstConstructionTypesRowChangeEvent((dsUnderwritingLocations.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstConstructionTypesRowChangeEventHandler rowDeletingEvent = this.lstConstructionTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsUnderwritingLocations.lstConstructionTypesRowChangeEvent((dsUnderwritingLocations.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstConstructionTypesRow(
      dsUnderwritingLocations.lstConstructionTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsUnderwritingLocations underwritingLocations = new dsUnderwritingLocations();
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
        FixedValue = underwritingLocations.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstConstructionTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = underwritingLocations.GetSchemaSerializable();
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
  public class tblFin_ExpensePayeesDataTable : 
    TypedTableBase<dsUnderwritingLocations.tblFin_ExpensePayeesRow>
  {
    private DataColumn columnPayeeID;
    private DataColumn columnPayeeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblFin_ExpensePayeesDataTable()
    {
      this.TableName = "tblFin_ExpensePayees";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblFin_ExpensePayeesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblFin_ExpensePayeesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PayeeIDColumn => this.columnPayeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PayeeNameColumn => this.columnPayeeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblFin_ExpensePayeesRow this[int index]
    {
      get => (dsUnderwritingLocations.tblFin_ExpensePayeesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblFin_ExpensePayeesRow(
      dsUnderwritingLocations.tblFin_ExpensePayeesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblFin_ExpensePayeesRow AddtblFin_ExpensePayeesRow(
      string PayeeName)
    {
      dsUnderwritingLocations.tblFin_ExpensePayeesRow row = (dsUnderwritingLocations.tblFin_ExpensePayeesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) PayeeName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblFin_ExpensePayeesRow FindByPayeeID(int PayeeID)
    {
      return (dsUnderwritingLocations.tblFin_ExpensePayeesRow) this.Rows.Find(new object[1]
      {
        (object) PayeeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsUnderwritingLocations.tblFin_ExpensePayeesDataTable expensePayeesDataTable = (dsUnderwritingLocations.tblFin_ExpensePayeesDataTable) base.Clone();
      expensePayeesDataTable.InitVars();
      return (DataTable) expensePayeesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsUnderwritingLocations.tblFin_ExpensePayeesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnPayeeID = this.Columns["PayeeID"];
      this.columnPayeeName = this.Columns["PayeeName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnPayeeID = new DataColumn("PayeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeID);
      this.columnPayeeName = new DataColumn("PayeeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsUnderwritingLocationsKey3", new DataColumn[1]
      {
        this.columnPayeeID
      }, true));
      this.columnPayeeID.AutoIncrement = true;
      this.columnPayeeID.AllowDBNull = false;
      this.columnPayeeID.ReadOnly = true;
      this.columnPayeeID.Unique = true;
      this.columnPayeeName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblFin_ExpensePayeesRow NewtblFin_ExpensePayeesRow()
    {
      return (dsUnderwritingLocations.tblFin_ExpensePayeesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsUnderwritingLocations.tblFin_ExpensePayeesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsUnderwritingLocations.tblFin_ExpensePayeesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.tblFin_ExpensePayeesRowChangeEventHandler payeesRowChangedEvent = this.tblFin_ExpensePayeesRowChangedEvent;
      if (payeesRowChangedEvent == null)
        return;
      payeesRowChangedEvent((object) this, new dsUnderwritingLocations.tblFin_ExpensePayeesRowChangeEvent((dsUnderwritingLocations.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.tblFin_ExpensePayeesRowChangeEventHandler rowChangingEvent = this.tblFin_ExpensePayeesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsUnderwritingLocations.tblFin_ExpensePayeesRowChangeEvent((dsUnderwritingLocations.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.tblFin_ExpensePayeesRowChangeEventHandler payeesRowDeletedEvent = this.tblFin_ExpensePayeesRowDeletedEvent;
      if (payeesRowDeletedEvent == null)
        return;
      payeesRowDeletedEvent((object) this, new dsUnderwritingLocations.tblFin_ExpensePayeesRowChangeEvent((dsUnderwritingLocations.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.tblFin_ExpensePayeesRowChangeEventHandler rowDeletingEvent = this.tblFin_ExpensePayeesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsUnderwritingLocations.tblFin_ExpensePayeesRowChangeEvent((dsUnderwritingLocations.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblFin_ExpensePayeesRow(
      dsUnderwritingLocations.tblFin_ExpensePayeesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsUnderwritingLocations underwritingLocations = new dsUnderwritingLocations();
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
        FixedValue = underwritingLocations.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblFin_ExpensePayeesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = underwritingLocations.GetSchemaSerializable();
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
  public class lstClassCodesDataTable : TypedTableBase<dsUnderwritingLocations.lstClassCodesRow>
  {
    private DataColumn columnClassCodeID;
    private DataColumn columnClassCodeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstClassCodesDataTable()
    {
      this.TableName = "lstClassCodes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstClassCodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClassCodeIDColumn => this.columnClassCodeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClassCodeDescriptionColumn => this.columnClassCodeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstClassCodesRow this[int index]
    {
      get => (dsUnderwritingLocations.lstClassCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstClassCodesRowChangeEventHandler lstClassCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstClassCodesRowChangeEventHandler lstClassCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstClassCodesRowChangeEventHandler lstClassCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstClassCodesRowChangeEventHandler lstClassCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstClassCodesRow(dsUnderwritingLocations.lstClassCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstClassCodesRow AddlstClassCodesRow(
      int ClassCodeID,
      string ClassCodeDescription)
    {
      dsUnderwritingLocations.lstClassCodesRow row = (dsUnderwritingLocations.lstClassCodesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ClassCodeID,
        (object) ClassCodeDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstClassCodesRow FindByClassCodeID(int ClassCodeID)
    {
      return (dsUnderwritingLocations.lstClassCodesRow) this.Rows.Find(new object[1]
      {
        (object) ClassCodeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsUnderwritingLocations.lstClassCodesDataTable classCodesDataTable = (dsUnderwritingLocations.lstClassCodesDataTable) base.Clone();
      classCodesDataTable.InitVars();
      return (DataTable) classCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsUnderwritingLocations.lstClassCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnClassCodeID = this.Columns["ClassCodeID"];
      this.columnClassCodeDescription = this.Columns["ClassCodeDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnClassCodeID = new DataColumn("ClassCodeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeID);
      this.columnClassCodeDescription = new DataColumn("ClassCodeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsUnderwritingLocationsKey2", new DataColumn[1]
      {
        this.columnClassCodeID
      }, true));
      this.columnClassCodeID.AllowDBNull = false;
      this.columnClassCodeID.Unique = true;
      this.columnClassCodeDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstClassCodesRow NewlstClassCodesRow()
    {
      return (dsUnderwritingLocations.lstClassCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsUnderwritingLocations.lstClassCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsUnderwritingLocations.lstClassCodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstClassCodesRowChangeEventHandler codesRowChangedEvent = this.lstClassCodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsUnderwritingLocations.lstClassCodesRowChangeEvent((dsUnderwritingLocations.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstClassCodesRowChangeEventHandler rowChangingEvent = this.lstClassCodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsUnderwritingLocations.lstClassCodesRowChangeEvent((dsUnderwritingLocations.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstClassCodesRowChangeEventHandler codesRowDeletedEvent = this.lstClassCodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsUnderwritingLocations.lstClassCodesRowChangeEvent((dsUnderwritingLocations.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstClassCodesRowChangeEventHandler rowDeletingEvent = this.lstClassCodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsUnderwritingLocations.lstClassCodesRowChangeEvent((dsUnderwritingLocations.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstClassCodesRow(dsUnderwritingLocations.lstClassCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsUnderwritingLocations underwritingLocations = new dsUnderwritingLocations();
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
        FixedValue = underwritingLocations.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstClassCodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = underwritingLocations.GetSchemaSerializable();
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
  public class lstUnderwritingLocations_AlarmTypesDataTable : 
    TypedTableBase<dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow>
  {
    private DataColumn columnAlarmTypeID;
    private DataColumn columnAlarmType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstUnderwritingLocations_AlarmTypesDataTable()
    {
      this.TableName = "lstUnderwritingLocations_AlarmTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstUnderwritingLocations_AlarmTypesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstUnderwritingLocations_AlarmTypesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AlarmTypeIDColumn => this.columnAlarmTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AlarmTypeColumn => this.columnAlarmType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow this[int index]
    {
      get => (dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRowChangeEventHandler lstUnderwritingLocations_AlarmTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRowChangeEventHandler lstUnderwritingLocations_AlarmTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRowChangeEventHandler lstUnderwritingLocations_AlarmTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRowChangeEventHandler lstUnderwritingLocations_AlarmTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstUnderwritingLocations_AlarmTypesRow(
      dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow AddlstUnderwritingLocations_AlarmTypesRow(
      int AlarmTypeID,
      string AlarmType)
    {
      dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow row = (dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) AlarmTypeID,
        (object) AlarmType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow FindByAlarmTypeID(
      int AlarmTypeID)
    {
      return (dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow) this.Rows.Find(new object[1]
      {
        (object) AlarmTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesDataTable alarmTypesDataTable = (dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesDataTable) base.Clone();
      alarmTypesDataTable.InitVars();
      return (DataTable) alarmTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnAlarmTypeID = this.Columns["AlarmTypeID"];
      this.columnAlarmType = this.Columns["AlarmType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnAlarmTypeID = new DataColumn("AlarmTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAlarmTypeID);
      this.columnAlarmType = new DataColumn("AlarmType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAlarmType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsUnderwritingLocationsKey4", new DataColumn[1]
      {
        this.columnAlarmTypeID
      }, true));
      this.columnAlarmTypeID.AllowDBNull = false;
      this.columnAlarmTypeID.ReadOnly = true;
      this.columnAlarmTypeID.Unique = true;
      this.columnAlarmType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow NewlstUnderwritingLocations_AlarmTypesRow()
    {
      return (dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstUnderwritingLocations_AlarmTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRowChangeEventHandler typesRowChangedEvent = this.lstUnderwritingLocations_AlarmTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRowChangeEvent((dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstUnderwritingLocations_AlarmTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRowChangeEventHandler rowChangingEvent = this.lstUnderwritingLocations_AlarmTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRowChangeEvent((dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstUnderwritingLocations_AlarmTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRowChangeEventHandler typesRowDeletedEvent = this.lstUnderwritingLocations_AlarmTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRowChangeEvent((dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstUnderwritingLocations_AlarmTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRowChangeEventHandler rowDeletingEvent = this.lstUnderwritingLocations_AlarmTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRowChangeEvent((dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstUnderwritingLocations_AlarmTypesRow(
      dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsUnderwritingLocations underwritingLocations = new dsUnderwritingLocations();
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
        FixedValue = underwritingLocations.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstUnderwritingLocations_AlarmTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = underwritingLocations.GetSchemaSerializable();
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
  public class lstUnderwritingLocations_SprinklerTypesDataTable : 
    TypedTableBase<dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow>
  {
    private DataColumn columnSprinklerTypeID;
    private DataColumn columnWetDry;
    private DataColumn columnExtent;
    private DataColumn columnAlarm;
    private DataColumn columnDisplay;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstUnderwritingLocations_SprinklerTypesDataTable()
    {
      this.TableName = "lstUnderwritingLocations_SprinklerTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstUnderwritingLocations_SprinklerTypesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstUnderwritingLocations_SprinklerTypesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SprinklerTypeIDColumn => this.columnSprinklerTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WetDryColumn => this.columnWetDry;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExtentColumn => this.columnExtent;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AlarmColumn => this.columnAlarm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DisplayColumn => this.columnDisplay;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow this[int index]
    {
      get => (dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRowChangeEventHandler lstUnderwritingLocations_SprinklerTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRowChangeEventHandler lstUnderwritingLocations_SprinklerTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRowChangeEventHandler lstUnderwritingLocations_SprinklerTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRowChangeEventHandler lstUnderwritingLocations_SprinklerTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstUnderwritingLocations_SprinklerTypesRow(
      dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow AddlstUnderwritingLocations_SprinklerTypesRow(
      int SprinklerTypeID,
      string WetDry,
      string Extent,
      string Alarm,
      string Display)
    {
      dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow row = (dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) SprinklerTypeID,
        (object) WetDry,
        (object) Extent,
        (object) Alarm,
        (object) Display
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow FindBySprinklerTypeID(
      int SprinklerTypeID)
    {
      return (dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow) this.Rows.Find(new object[1]
      {
        (object) SprinklerTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesDataTable sprinklerTypesDataTable = (dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesDataTable) base.Clone();
      sprinklerTypesDataTable.InitVars();
      return (DataTable) sprinklerTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnSprinklerTypeID = this.Columns["SprinklerTypeID"];
      this.columnWetDry = this.Columns["WetDry"];
      this.columnExtent = this.Columns["Extent"];
      this.columnAlarm = this.Columns["Alarm"];
      this.columnDisplay = this.Columns["Display"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnSprinklerTypeID = new DataColumn("SprinklerTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSprinklerTypeID);
      this.columnWetDry = new DataColumn("WetDry", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWetDry);
      this.columnExtent = new DataColumn("Extent", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExtent);
      this.columnAlarm = new DataColumn("Alarm", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAlarm);
      this.columnDisplay = new DataColumn("Display", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisplay);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsUnderwritingLocationsKey5", new DataColumn[1]
      {
        this.columnSprinklerTypeID
      }, true));
      this.columnSprinklerTypeID.AllowDBNull = false;
      this.columnSprinklerTypeID.ReadOnly = true;
      this.columnSprinklerTypeID.Unique = true;
      this.columnWetDry.AllowDBNull = false;
      this.columnExtent.AllowDBNull = false;
      this.columnAlarm.AllowDBNull = false;
      this.columnDisplay.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow NewlstUnderwritingLocations_SprinklerTypesRow()
    {
      return (dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstUnderwritingLocations_SprinklerTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRowChangeEventHandler typesRowChangedEvent = this.lstUnderwritingLocations_SprinklerTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRowChangeEvent((dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstUnderwritingLocations_SprinklerTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRowChangeEventHandler rowChangingEvent = this.lstUnderwritingLocations_SprinklerTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRowChangeEvent((dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstUnderwritingLocations_SprinklerTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRowChangeEventHandler typesRowDeletedEvent = this.lstUnderwritingLocations_SprinklerTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRowChangeEvent((dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstUnderwritingLocations_SprinklerTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRowChangeEventHandler rowDeletingEvent = this.lstUnderwritingLocations_SprinklerTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRowChangeEvent((dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstUnderwritingLocations_SprinklerTypesRow(
      dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsUnderwritingLocations underwritingLocations = new dsUnderwritingLocations();
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
        FixedValue = underwritingLocations.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstUnderwritingLocations_SprinklerTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = underwritingLocations.GetSchemaSerializable();
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
  public class lstWindRestrictionsDataTable : 
    TypedTableBase<dsUnderwritingLocations.lstWindRestrictionsRow>
  {
    private DataColumn columnRestrictionID;
    private DataColumn columnRestriction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstWindRestrictionsDataTable()
    {
      this.TableName = "lstWindRestrictions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstWindRestrictionsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstWindRestrictionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RestrictionIDColumn => this.columnRestrictionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RestrictionColumn => this.columnRestriction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstWindRestrictionsRow this[int index]
    {
      get => (dsUnderwritingLocations.lstWindRestrictionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstWindRestrictionsRowChangeEventHandler lstWindRestrictionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstWindRestrictionsRowChangeEventHandler lstWindRestrictionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstWindRestrictionsRowChangeEventHandler lstWindRestrictionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstWindRestrictionsRowChangeEventHandler lstWindRestrictionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstWindRestrictionsRow(dsUnderwritingLocations.lstWindRestrictionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstWindRestrictionsRow AddlstWindRestrictionsRow(
      string Restriction)
    {
      dsUnderwritingLocations.lstWindRestrictionsRow row = (dsUnderwritingLocations.lstWindRestrictionsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) Restriction
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstWindRestrictionsRow FindByRestrictionID(int RestrictionID)
    {
      return (dsUnderwritingLocations.lstWindRestrictionsRow) this.Rows.Find(new object[1]
      {
        (object) RestrictionID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsUnderwritingLocations.lstWindRestrictionsDataTable restrictionsDataTable = (dsUnderwritingLocations.lstWindRestrictionsDataTable) base.Clone();
      restrictionsDataTable.InitVars();
      return (DataTable) restrictionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsUnderwritingLocations.lstWindRestrictionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnRestrictionID = this.Columns["RestrictionID"];
      this.columnRestriction = this.Columns["Restriction"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnRestrictionID = new DataColumn("RestrictionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRestrictionID);
      this.columnRestriction = new DataColumn("Restriction", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRestriction);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsUnderwritingLocationsKey6", new DataColumn[1]
      {
        this.columnRestrictionID
      }, true));
      this.columnRestrictionID.AutoIncrement = true;
      this.columnRestrictionID.AutoIncrementSeed = -1L;
      this.columnRestrictionID.AutoIncrementStep = -1L;
      this.columnRestrictionID.AllowDBNull = false;
      this.columnRestrictionID.ReadOnly = true;
      this.columnRestrictionID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstWindRestrictionsRow NewlstWindRestrictionsRow()
    {
      return (dsUnderwritingLocations.lstWindRestrictionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsUnderwritingLocations.lstWindRestrictionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsUnderwritingLocations.lstWindRestrictionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstWindRestrictionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstWindRestrictionsRowChangeEventHandler restrictionsRowChangedEvent = this.lstWindRestrictionsRowChangedEvent;
      if (restrictionsRowChangedEvent == null)
        return;
      restrictionsRowChangedEvent((object) this, new dsUnderwritingLocations.lstWindRestrictionsRowChangeEvent((dsUnderwritingLocations.lstWindRestrictionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstWindRestrictionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstWindRestrictionsRowChangeEventHandler rowChangingEvent = this.lstWindRestrictionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsUnderwritingLocations.lstWindRestrictionsRowChangeEvent((dsUnderwritingLocations.lstWindRestrictionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstWindRestrictionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstWindRestrictionsRowChangeEventHandler restrictionsRowDeletedEvent = this.lstWindRestrictionsRowDeletedEvent;
      if (restrictionsRowDeletedEvent == null)
        return;
      restrictionsRowDeletedEvent((object) this, new dsUnderwritingLocations.lstWindRestrictionsRowChangeEvent((dsUnderwritingLocations.lstWindRestrictionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstWindRestrictionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstWindRestrictionsRowChangeEventHandler rowDeletingEvent = this.lstWindRestrictionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsUnderwritingLocations.lstWindRestrictionsRowChangeEvent((dsUnderwritingLocations.lstWindRestrictionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstWindRestrictionsRow(dsUnderwritingLocations.lstWindRestrictionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsUnderwritingLocations underwritingLocations = new dsUnderwritingLocations();
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
        FixedValue = underwritingLocations.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstWindRestrictionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = underwritingLocations.GetSchemaSerializable();
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
  public class dtLocationsDataTable : TypedTableBase<dsUnderwritingLocations.dtLocationsRow>
  {
    private DataColumn columnLocationID;
    private DataColumn columnOriginalLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtLocationsDataTable()
    {
      this.TableName = "dtLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtLocationsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected dtLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OriginalLocationIDColumn => this.columnOriginalLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.dtLocationsRow this[int index]
    {
      get => (dsUnderwritingLocations.dtLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.dtLocationsRowChangeEventHandler dtLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.dtLocationsRowChangeEventHandler dtLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.dtLocationsRowChangeEventHandler dtLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.dtLocationsRowChangeEventHandler dtLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtLocationsRow(dsUnderwritingLocations.dtLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.dtLocationsRow AdddtLocationsRow(int OriginalLocationID)
    {
      dsUnderwritingLocations.dtLocationsRow row = (dsUnderwritingLocations.dtLocationsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) OriginalLocationID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.dtLocationsRow FindByLocationID(int LocationID)
    {
      return (dsUnderwritingLocations.dtLocationsRow) this.Rows.Find(new object[1]
      {
        (object) LocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsUnderwritingLocations.dtLocationsDataTable locationsDataTable = (dsUnderwritingLocations.dtLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsUnderwritingLocations.dtLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnLocationID = this.Columns["LocationID"];
      this.columnOriginalLocationID = this.Columns["OriginalLocationID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnOriginalLocationID = new DataColumn("OriginalLocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOriginalLocationID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnLocationID
      }, true));
      this.columnLocationID.AutoIncrement = true;
      this.columnLocationID.AutoIncrementSeed = -1L;
      this.columnLocationID.AutoIncrementStep = -1L;
      this.columnLocationID.AllowDBNull = false;
      this.columnLocationID.ReadOnly = true;
      this.columnLocationID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.dtLocationsRow NewdtLocationsRow()
    {
      return (dsUnderwritingLocations.dtLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsUnderwritingLocations.dtLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsUnderwritingLocations.dtLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.dtLocationsRowChangeEventHandler locationsRowChangedEvent = this.dtLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsUnderwritingLocations.dtLocationsRowChangeEvent((dsUnderwritingLocations.dtLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.dtLocationsRowChangeEventHandler rowChangingEvent = this.dtLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsUnderwritingLocations.dtLocationsRowChangeEvent((dsUnderwritingLocations.dtLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.dtLocationsRowChangeEventHandler locationsRowDeletedEvent = this.dtLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsUnderwritingLocations.dtLocationsRowChangeEvent((dsUnderwritingLocations.dtLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.dtLocationsRowChangeEventHandler rowDeletingEvent = this.dtLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsUnderwritingLocations.dtLocationsRowChangeEvent((dsUnderwritingLocations.dtLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtLocationsRow(dsUnderwritingLocations.dtLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsUnderwritingLocations underwritingLocations = new dsUnderwritingLocations();
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
        FixedValue = underwritingLocations.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = underwritingLocations.GetSchemaSerializable();
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
  public class dtRoofInspectionCompaniesDataTable : 
    TypedTableBase<dsUnderwritingLocations.dtRoofInspectionCompaniesRow>
  {
    private DataColumn columnPayeeID;
    private DataColumn columnPayeeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtRoofInspectionCompaniesDataTable()
    {
      this.TableName = "dtRoofInspectionCompanies";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtRoofInspectionCompaniesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected dtRoofInspectionCompaniesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PayeeIDColumn => this.columnPayeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PayeeNameColumn => this.columnPayeeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.dtRoofInspectionCompaniesRow this[int index]
    {
      get => (dsUnderwritingLocations.dtRoofInspectionCompaniesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.dtRoofInspectionCompaniesRowChangeEventHandler dtRoofInspectionCompaniesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.dtRoofInspectionCompaniesRowChangeEventHandler dtRoofInspectionCompaniesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.dtRoofInspectionCompaniesRowChangeEventHandler dtRoofInspectionCompaniesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.dtRoofInspectionCompaniesRowChangeEventHandler dtRoofInspectionCompaniesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtRoofInspectionCompaniesRow(
      dsUnderwritingLocations.dtRoofInspectionCompaniesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.dtRoofInspectionCompaniesRow AdddtRoofInspectionCompaniesRow(
      string PayeeName)
    {
      dsUnderwritingLocations.dtRoofInspectionCompaniesRow row = (dsUnderwritingLocations.dtRoofInspectionCompaniesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) PayeeName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.dtRoofInspectionCompaniesRow FindByPayeeID(int PayeeID)
    {
      return (dsUnderwritingLocations.dtRoofInspectionCompaniesRow) this.Rows.Find(new object[1]
      {
        (object) PayeeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsUnderwritingLocations.dtRoofInspectionCompaniesDataTable companiesDataTable = (dsUnderwritingLocations.dtRoofInspectionCompaniesDataTable) base.Clone();
      companiesDataTable.InitVars();
      return (DataTable) companiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsUnderwritingLocations.dtRoofInspectionCompaniesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnPayeeID = this.Columns["PayeeID"];
      this.columnPayeeName = this.Columns["PayeeName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnPayeeID = new DataColumn("PayeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeID);
      this.columnPayeeName = new DataColumn("PayeeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnPayeeID
      }, true));
      this.columnPayeeID.AutoIncrement = true;
      this.columnPayeeID.AutoIncrementSeed = -1L;
      this.columnPayeeID.AutoIncrementStep = -1L;
      this.columnPayeeID.AllowDBNull = false;
      this.columnPayeeID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.dtRoofInspectionCompaniesRow NewdtRoofInspectionCompaniesRow()
    {
      return (dsUnderwritingLocations.dtRoofInspectionCompaniesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsUnderwritingLocations.dtRoofInspectionCompaniesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsUnderwritingLocations.dtRoofInspectionCompaniesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRoofInspectionCompaniesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.dtRoofInspectionCompaniesRowChangeEventHandler companiesRowChangedEvent = this.dtRoofInspectionCompaniesRowChangedEvent;
      if (companiesRowChangedEvent == null)
        return;
      companiesRowChangedEvent((object) this, new dsUnderwritingLocations.dtRoofInspectionCompaniesRowChangeEvent((dsUnderwritingLocations.dtRoofInspectionCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRoofInspectionCompaniesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.dtRoofInspectionCompaniesRowChangeEventHandler rowChangingEvent = this.dtRoofInspectionCompaniesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsUnderwritingLocations.dtRoofInspectionCompaniesRowChangeEvent((dsUnderwritingLocations.dtRoofInspectionCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRoofInspectionCompaniesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.dtRoofInspectionCompaniesRowChangeEventHandler companiesRowDeletedEvent = this.dtRoofInspectionCompaniesRowDeletedEvent;
      if (companiesRowDeletedEvent == null)
        return;
      companiesRowDeletedEvent((object) this, new dsUnderwritingLocations.dtRoofInspectionCompaniesRowChangeEvent((dsUnderwritingLocations.dtRoofInspectionCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRoofInspectionCompaniesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.dtRoofInspectionCompaniesRowChangeEventHandler rowDeletingEvent = this.dtRoofInspectionCompaniesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsUnderwritingLocations.dtRoofInspectionCompaniesRowChangeEvent((dsUnderwritingLocations.dtRoofInspectionCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtRoofInspectionCompaniesRow(
      dsUnderwritingLocations.dtRoofInspectionCompaniesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsUnderwritingLocations underwritingLocations = new dsUnderwritingLocations();
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
        FixedValue = underwritingLocations.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtRoofInspectionCompaniesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = underwritingLocations.GetSchemaSerializable();
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
  public class lstFloodZonesDataTable : TypedTableBase<dsUnderwritingLocations.lstFloodZonesRow>
  {
    private DataColumn columnFloodZone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstFloodZonesDataTable()
    {
      this.TableName = "lstFloodZones";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstFloodZonesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstFloodZonesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FloodZoneColumn => this.columnFloodZone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstFloodZonesRow this[int index]
    {
      get => (dsUnderwritingLocations.lstFloodZonesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstFloodZonesRowChangeEventHandler lstFloodZonesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstFloodZonesRowChangeEventHandler lstFloodZonesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstFloodZonesRowChangeEventHandler lstFloodZonesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsUnderwritingLocations.lstFloodZonesRowChangeEventHandler lstFloodZonesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstFloodZonesRow(dsUnderwritingLocations.lstFloodZonesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstFloodZonesRow AddlstFloodZonesRow(string FloodZone)
    {
      dsUnderwritingLocations.lstFloodZonesRow row = (dsUnderwritingLocations.lstFloodZonesRow) this.NewRow();
      object[] objArray = new object[1]
      {
        (object) FloodZone
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsUnderwritingLocations.lstFloodZonesDataTable floodZonesDataTable = (dsUnderwritingLocations.lstFloodZonesDataTable) base.Clone();
      floodZonesDataTable.InitVars();
      return (DataTable) floodZonesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsUnderwritingLocations.lstFloodZonesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars() => this.columnFloodZone = this.Columns["FloodZone"];

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnFloodZone = new DataColumn("FloodZone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFloodZone);
      this.columnFloodZone.MaxLength = 25;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstFloodZonesRow NewlstFloodZonesRow()
    {
      return (dsUnderwritingLocations.lstFloodZonesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsUnderwritingLocations.lstFloodZonesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsUnderwritingLocations.lstFloodZonesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFloodZonesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstFloodZonesRowChangeEventHandler zonesRowChangedEvent = this.lstFloodZonesRowChangedEvent;
      if (zonesRowChangedEvent == null)
        return;
      zonesRowChangedEvent((object) this, new dsUnderwritingLocations.lstFloodZonesRowChangeEvent((dsUnderwritingLocations.lstFloodZonesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFloodZonesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstFloodZonesRowChangeEventHandler rowChangingEvent = this.lstFloodZonesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsUnderwritingLocations.lstFloodZonesRowChangeEvent((dsUnderwritingLocations.lstFloodZonesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFloodZonesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstFloodZonesRowChangeEventHandler zonesRowDeletedEvent = this.lstFloodZonesRowDeletedEvent;
      if (zonesRowDeletedEvent == null)
        return;
      zonesRowDeletedEvent((object) this, new dsUnderwritingLocations.lstFloodZonesRowChangeEvent((dsUnderwritingLocations.lstFloodZonesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFloodZonesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsUnderwritingLocations.lstFloodZonesRowChangeEventHandler rowDeletingEvent = this.lstFloodZonesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsUnderwritingLocations.lstFloodZonesRowChangeEvent((dsUnderwritingLocations.lstFloodZonesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstFloodZonesRow(dsUnderwritingLocations.lstFloodZonesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsUnderwritingLocations underwritingLocations = new dsUnderwritingLocations();
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
        FixedValue = underwritingLocations.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstFloodZonesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = underwritingLocations.GetSchemaSerializable();
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
    private dsUnderwritingLocations.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblUnderwritingLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUnderwritingLocations = (dsUnderwritingLocations.tblUnderwritingLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabletblUnderwritingLocations.LocationIDColumn]);
      set => this[this.tabletblUnderwritingLocations.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid LocationGUID
    {
      get
      {
        object obj = this[this.tabletblUnderwritingLocations.LocationGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblUnderwritingLocations.LocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid QuoteGUID
    {
      get
      {
        object obj = this[this.tabletblUnderwritingLocations.QuoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblUnderwritingLocations.QuoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int LocationNo
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUnderwritingLocations.LocationNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationNo' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.LocationNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string BuildingNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.BuildingNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BuildingNo' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.BuildingNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PhysicalBuildingNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.PhysicalBuildingNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PhysicalBuildingNo' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.PhysicalBuildingNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address1' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address2' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string County
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.CountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'County' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.CountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Zip
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.ZipColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Zip' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.ZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipPlus' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.ZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ConstructionID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUnderwritingLocations.ConstructionIDColumn]);
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ClassCodeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUnderwritingLocations.ClassCodeIDColumn]);
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProtectionCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.ProtectionCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProtectionCode' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.ProtectionCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AddnInformation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.AddnInformationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddnInformation' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.AddnInformationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EQZone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.EQZoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EQZone' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.EQZoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FloodZone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.FloodZoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FloodZone' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.FloodZoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EQConstruction
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.EQConstructionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EQConstruction' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.EQConstructionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool WindCoverage
    {
      get => Conversions.ToBoolean(this[this.tabletblUnderwritingLocations.WindCoverageColumn]);
      set => this[this.tabletblUnderwritingLocations.WindCoverageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Territory
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.TerritoryColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Territory' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.TerritoryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string TaxTerritory
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.TaxTerritoryColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TaxTerritory' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.TaxTerritoryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Inspect
    {
      get => Conversions.ToBoolean(this[this.tabletblUnderwritingLocations.InspectColumn]);
      set => this[this.tabletblUnderwritingLocations.InspectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Photo
    {
      get => Conversions.ToBoolean(this[this.tabletblUnderwritingLocations.PhotoColumn]);
      set => this[this.tabletblUnderwritingLocations.PhotoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Diagram
    {
      get => Conversions.ToBoolean(this[this.tabletblUnderwritingLocations.DiagramColumn]);
      set => this[this.tabletblUnderwritingLocations.DiagramColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool CostEstimator
    {
      get => Conversions.ToBoolean(this[this.tabletblUnderwritingLocations.CostEstimatorColumn]);
      set => this[this.tabletblUnderwritingLocations.CostEstimatorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid UserAdded
    {
      get
      {
        object obj = this[this.tabletblUnderwritingLocations.UserAddedColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblUnderwritingLocations.UserAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateAdded
    {
      get => Conversions.ToDate(this[this.tabletblUnderwritingLocations.DateAddedColumn]);
      set => this[this.tabletblUnderwritingLocations.DateAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DistToFireHydrant
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUnderwritingLocations.DistToFireHydrantColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DistToFireHydrant' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.DistToFireHydrantColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal DistToFireStation
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblUnderwritingLocations.DistToFireStationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DistToFireStation' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.DistToFireStationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FireDistrict
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.FireDistrictColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FireDistrict' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.FireDistrictColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Stories
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblUnderwritingLocations.StoriesColumn]);
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Basements
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUnderwritingLocations.BasementsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Basements' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.BasementsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Elevators
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUnderwritingLocations.ElevatorsColumn]);
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public short WiringYear
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblUnderwritingLocations.WiringYearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WiringYear' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.WiringYearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public short RoofingYear
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblUnderwritingLocations.RoofingYearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RoofingYear' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.RoofingYearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public short PlumbingYear
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblUnderwritingLocations.PlumbingYearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PlumbingYear' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.PlumbingYearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public short HeatingYear
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblUnderwritingLocations.HeatingYearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'HeatingYear' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.HeatingYearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ModificationCode
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.ModificationCodeColumn]);
      set => this[this.tabletblUnderwritingLocations.ModificationCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int InspectionCompanyID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUnderwritingLocations.InspectionCompanyIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionCompanyID' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.InspectionCompanyIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InspectionContact
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.InspectionContactColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionContact' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.InspectionContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InspectionContactPhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.InspectionContactPhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionContactPhone' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.InspectionContactPhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Comments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.CommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Comments' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.CommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int FireAlarmTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUnderwritingLocations.FireAlarmTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FireAlarmTypeID' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.FireAlarmTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int BurglarAlarmTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUnderwritingLocations.BurglarAlarmTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BurglarAlarmTypeID' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.BurglarAlarmTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int SprinklerTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUnderwritingLocations.SprinklerTypeIDColumn]);
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool LockedAndSecured
    {
      get => Conversions.ToBoolean(this[this.tabletblUnderwritingLocations.LockedAndSecuredColumn]);
      set => this[this.tabletblUnderwritingLocations.LockedAndSecuredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Vacant
    {
      get => Conversions.ToBoolean(this[this.tabletblUnderwritingLocations.VacantColumn]);
      set => this[this.tabletblUnderwritingLocations.VacantColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int WindRestrictionID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUnderwritingLocations.WindRestrictionIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WindRestrictionID' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.WindRestrictionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string GEOPhyBuildNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.GEOPhyBuildNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GEOPhyBuildNum' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.GEOPhyBuildNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string GEOAddress1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.GEOAddress1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GEOAddress1' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.GEOAddress1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string GEOAddress2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.GEOAddress2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GEOAddress2' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.GEOAddress2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string GEOCity
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.GEOCityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GEOCity' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.GEOCityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string GEOState
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.GEOStateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GEOState' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.GEOStateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string GEOCounty
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.GEOCountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GEOCounty' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.GEOCountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string GEOZip
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.GEOZipColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GEOZip' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.GEOZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string GEOZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.GEOZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GEOZipPlus' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.GEOZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool RecCheck
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblUnderwritingLocations.RecCheckColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RecCheck' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.RecCheckColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Rush
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblUnderwritingLocations.RushColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Rush' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.RushColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DueDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblUnderwritingLocations.DueDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DueDate' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Latitude
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.LatitudeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Latitude' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.LatitudeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Longitude
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.LongitudeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Longitude' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.LongitudeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string GeoStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.GeoStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GeoStatus' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.GeoStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string GeoURL
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.GeoURLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GeoURL' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.GeoURLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool LocationLookup
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblUnderwritingLocations.LocationLookupColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationLookup' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.LocationLookupColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int BaseLocationId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUnderwritingLocations.BaseLocationIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BaseLocationId' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.BaseLocationIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool DeleteRecord
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblUnderwritingLocations.DeleteRecordColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeleteRecord' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.DeleteRecordColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RoofInspectionCompanyID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUnderwritingLocations.RoofInspectionCompanyIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RoofInspectionCompanyID' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblUnderwritingLocations.RoofInspectionCompanyIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ContactEmail
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.ContactEmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ContactEmail' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.ContactEmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstConstructionTypesRow lstConstructionTypesRow
    {
      get
      {
        return (dsUnderwritingLocations.lstConstructionTypesRow) this.GetParentRow(this.Table.ParentRelations["lstConstructionTypestblUnderwritingLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstConstructionTypestblUnderwritingLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstClassCodesRow lstClassCodesRow
    {
      get
      {
        return (dsUnderwritingLocations.lstClassCodesRow) this.GetParentRow(this.Table.ParentRelations["lstPolicyClassestblUnderwritingLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstPolicyClassestblUnderwritingLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblFin_ExpensePayeesRow tblFin_ExpensePayeesRow
    {
      get
      {
        return (dsUnderwritingLocations.tblFin_ExpensePayeesRow) this.GetParentRow(this.Table.ParentRelations["tblInspectionCompaniestblUnderwritingLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblInspectionCompaniestblUnderwritingLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow lstUnderwritingLocations_AlarmTypesRowBylstUnderwritingLocations_AlarmTypestblUnderwritingLocations
    {
      get
      {
        return (dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow) this.GetParentRow(this.Table.ParentRelations["lstUnderwritingLocations_AlarmTypestblUnderwritingLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstUnderwritingLocations_AlarmTypestblUnderwritingLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow lstUnderwritingLocations_AlarmTypesRowBylstUnderwritingLocations_AlarmTypestblUnderwritingLocations1
    {
      get
      {
        return (dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow) this.GetParentRow(this.Table.ParentRelations["lstUnderwritingLocations_AlarmTypestblUnderwritingLocations1"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstUnderwritingLocations_AlarmTypestblUnderwritingLocations1"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow lstUnderwritingLocations_SprinklerTypesRow
    {
      get
      {
        return (dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow) this.GetParentRow(this.Table.ParentRelations["lstUnderwritingLocations_SprinklerTypestblUnderwritingLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstUnderwritingLocations_SprinklerTypestblUnderwritingLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstWindRestrictionsRow lstWindRestrictionsRow
    {
      get
      {
        return (dsUnderwritingLocations.lstWindRestrictionsRow) this.GetParentRow(this.Table.ParentRelations["lstWindRestrictionstblUnderwritingLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstWindRestrictionstblUnderwritingLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationNoNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.LocationNoColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationNoNull()
    {
      this[this.tabletblUnderwritingLocations.LocationNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBuildingNoNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.BuildingNoColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBuildingNoNull()
    {
      this[this.tabletblUnderwritingLocations.BuildingNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPhysicalBuildingNoNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.PhysicalBuildingNoColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPhysicalBuildingNoNull()
    {
      this[this.tabletblUnderwritingLocations.PhysicalBuildingNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddress1Null() => this.IsNull(this.tabletblUnderwritingLocations.Address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabletblUnderwritingLocations.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddress2Null() => this.IsNull(this.tabletblUnderwritingLocations.Address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabletblUnderwritingLocations.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabletblUnderwritingLocations.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabletblUnderwritingLocations.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabletblUnderwritingLocations.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabletblUnderwritingLocations.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCountyNull() => this.IsNull(this.tabletblUnderwritingLocations.CountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCountyNull()
    {
      this[this.tabletblUnderwritingLocations.CountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipNull() => this.IsNull(this.tabletblUnderwritingLocations.ZipColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipNull()
    {
      this[this.tabletblUnderwritingLocations.ZipColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipPlusNull() => this.IsNull(this.tabletblUnderwritingLocations.ZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipPlusNull()
    {
      this[this.tabletblUnderwritingLocations.ZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsConstructionIDNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.ConstructionIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetConstructionIDNull()
    {
      this[this.tabletblUnderwritingLocations.ConstructionIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClassCodeIDNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.ClassCodeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClassCodeIDNull()
    {
      this[this.tabletblUnderwritingLocations.ClassCodeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProtectionCodeNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.ProtectionCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProtectionCodeNull()
    {
      this[this.tabletblUnderwritingLocations.ProtectionCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddnInformationNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.AddnInformationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddnInformationNull()
    {
      this[this.tabletblUnderwritingLocations.AddnInformationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSqFootageNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.SqFootageColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSqFootageNull()
    {
      this[this.tabletblUnderwritingLocations.SqFootageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEQZoneNull() => this.IsNull(this.tabletblUnderwritingLocations.EQZoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEQZoneNull()
    {
      this[this.tabletblUnderwritingLocations.EQZoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFloodZoneNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.FloodZoneColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFloodZoneNull()
    {
      this[this.tabletblUnderwritingLocations.FloodZoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEQConstructionNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.EQConstructionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEQConstructionNull()
    {
      this[this.tabletblUnderwritingLocations.EQConstructionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTerritoryNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.TerritoryColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTerritoryNull()
    {
      this[this.tabletblUnderwritingLocations.TerritoryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTaxTerritoryNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.TaxTerritoryColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTaxTerritoryNull()
    {
      this[this.tabletblUnderwritingLocations.TaxTerritoryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDistToFireHydrantNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.DistToFireHydrantColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDistToFireHydrantNull()
    {
      this[this.tabletblUnderwritingLocations.DistToFireHydrantColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDistToFireStationNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.DistToFireStationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDistToFireStationNull()
    {
      this[this.tabletblUnderwritingLocations.DistToFireStationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFireDistrictNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.FireDistrictColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFireDistrictNull()
    {
      this[this.tabletblUnderwritingLocations.FireDistrictColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStoriesNull() => this.IsNull(this.tabletblUnderwritingLocations.StoriesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStoriesNull()
    {
      this[this.tabletblUnderwritingLocations.StoriesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBasementsNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.BasementsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBasementsNull()
    {
      this[this.tabletblUnderwritingLocations.BasementsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsElevatorsNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.ElevatorsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetElevatorsNull()
    {
      this[this.tabletblUnderwritingLocations.ElevatorsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsYearBuiltNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.YearBuiltColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetYearBuiltNull()
    {
      this[this.tabletblUnderwritingLocations.YearBuiltColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsWiringYearNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.WiringYearColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetWiringYearNull()
    {
      this[this.tabletblUnderwritingLocations.WiringYearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRoofingYearNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.RoofingYearColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRoofingYearNull()
    {
      this[this.tabletblUnderwritingLocations.RoofingYearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPlumbingYearNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.PlumbingYearColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPlumbingYearNull()
    {
      this[this.tabletblUnderwritingLocations.PlumbingYearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsHeatingYearNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.HeatingYearColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetHeatingYearNull()
    {
      this[this.tabletblUnderwritingLocations.HeatingYearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspectionCompanyIDNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.InspectionCompanyIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspectionCompanyIDNull()
    {
      this[this.tabletblUnderwritingLocations.InspectionCompanyIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspectionContactNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.InspectionContactColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspectionContactNull()
    {
      this[this.tabletblUnderwritingLocations.InspectionContactColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspectionContactPhoneNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.InspectionContactPhoneColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspectionContactPhoneNull()
    {
      this[this.tabletblUnderwritingLocations.InspectionContactPhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCommentsNull() => this.IsNull(this.tabletblUnderwritingLocations.CommentsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCommentsNull()
    {
      this[this.tabletblUnderwritingLocations.CommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFireAlarmTypeIDNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.FireAlarmTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFireAlarmTypeIDNull()
    {
      this[this.tabletblUnderwritingLocations.FireAlarmTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBurglarAlarmTypeIDNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.BurglarAlarmTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBurglarAlarmTypeIDNull()
    {
      this[this.tabletblUnderwritingLocations.BurglarAlarmTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSprinklerTypeIDNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.SprinklerTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSprinklerTypeIDNull()
    {
      this[this.tabletblUnderwritingLocations.SprinklerTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsWindRestrictionIDNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.WindRestrictionIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetWindRestrictionIDNull()
    {
      this[this.tabletblUnderwritingLocations.WindRestrictionIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGEOPhyBuildNumNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.GEOPhyBuildNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGEOPhyBuildNumNull()
    {
      this[this.tabletblUnderwritingLocations.GEOPhyBuildNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGEOAddress1Null()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.GEOAddress1Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGEOAddress1Null()
    {
      this[this.tabletblUnderwritingLocations.GEOAddress1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGEOAddress2Null()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.GEOAddress2Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGEOAddress2Null()
    {
      this[this.tabletblUnderwritingLocations.GEOAddress2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGEOCityNull() => this.IsNull(this.tabletblUnderwritingLocations.GEOCityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGEOCityNull()
    {
      this[this.tabletblUnderwritingLocations.GEOCityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGEOStateNull() => this.IsNull(this.tabletblUnderwritingLocations.GEOStateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGEOStateNull()
    {
      this[this.tabletblUnderwritingLocations.GEOStateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGEOCountyNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.GEOCountyColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGEOCountyNull()
    {
      this[this.tabletblUnderwritingLocations.GEOCountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGEOZipNull() => this.IsNull(this.tabletblUnderwritingLocations.GEOZipColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGEOZipNull()
    {
      this[this.tabletblUnderwritingLocations.GEOZipColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGEOZipPlusNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.GEOZipPlusColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGEOZipPlusNull()
    {
      this[this.tabletblUnderwritingLocations.GEOZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRecCheckNull() => this.IsNull(this.tabletblUnderwritingLocations.RecCheckColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRecCheckNull()
    {
      this[this.tabletblUnderwritingLocations.RecCheckColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRushNull() => this.IsNull(this.tabletblUnderwritingLocations.RushColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRushNull()
    {
      this[this.tabletblUnderwritingLocations.RushColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDueDateNull() => this.IsNull(this.tabletblUnderwritingLocations.DueDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDueDateNull()
    {
      this[this.tabletblUnderwritingLocations.DueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLatitudeNull() => this.IsNull(this.tabletblUnderwritingLocations.LatitudeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLatitudeNull()
    {
      this[this.tabletblUnderwritingLocations.LatitudeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLongitudeNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.LongitudeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLongitudeNull()
    {
      this[this.tabletblUnderwritingLocations.LongitudeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGeoStatusNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.GeoStatusColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGeoStatusNull()
    {
      this[this.tabletblUnderwritingLocations.GeoStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGeoURLNull() => this.IsNull(this.tabletblUnderwritingLocations.GeoURLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGeoURLNull()
    {
      this[this.tabletblUnderwritingLocations.GeoURLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationLookupNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.LocationLookupColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationLookupNull()
    {
      this[this.tabletblUnderwritingLocations.LocationLookupColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBaseLocationIdNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.BaseLocationIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBaseLocationIdNull()
    {
      this[this.tabletblUnderwritingLocations.BaseLocationIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDeleteRecordNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.DeleteRecordColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDeleteRecordNull()
    {
      this[this.tabletblUnderwritingLocations.DeleteRecordColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRoofInspectionCompanyIDNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.RoofInspectionCompanyIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRoofInspectionCompanyIDNull()
    {
      this[this.tabletblUnderwritingLocations.RoofInspectionCompanyIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsContactEmailNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.ContactEmailColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetContactEmailNull()
    {
      this[this.tabletblUnderwritingLocations.ContactEmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstConstructionTypesRow : DataRow
  {
    private dsUnderwritingLocations.lstConstructionTypesDataTable tablelstConstructionTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstConstructionTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstConstructionTypes = (dsUnderwritingLocations.lstConstructionTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ConstructionTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstConstructionTypes.ConstructionTypeIDColumn]);
      set => this[this.tablelstConstructionTypes.ConstructionTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Type
    {
      get => Conversions.ToString(this[this.tablelstConstructionTypes.TypeColumn]);
      set => this[this.tablelstConstructionTypes.TypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblUnderwritingLocationsRow[] GettblUnderwritingLocationsRows()
    {
      return this.Table.ChildRelations["lstConstructionTypestblUnderwritingLocations"] != null ? (dsUnderwritingLocations.tblUnderwritingLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstConstructionTypestblUnderwritingLocations"]) : new dsUnderwritingLocations.tblUnderwritingLocationsRow[0];
    }
  }

  public class tblFin_ExpensePayeesRow : DataRow
  {
    private dsUnderwritingLocations.tblFin_ExpensePayeesDataTable tabletblFin_ExpensePayees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblFin_ExpensePayeesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblFin_ExpensePayees = (dsUnderwritingLocations.tblFin_ExpensePayeesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PayeeID
    {
      get => Conversions.ToInteger(this[this.tabletblFin_ExpensePayees.PayeeIDColumn]);
      set => this[this.tabletblFin_ExpensePayees.PayeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PayeeName
    {
      get => Conversions.ToString(this[this.tabletblFin_ExpensePayees.PayeeNameColumn]);
      set => this[this.tabletblFin_ExpensePayees.PayeeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblUnderwritingLocationsRow[] GettblUnderwritingLocationsRows()
    {
      return this.Table.ChildRelations["tblInspectionCompaniestblUnderwritingLocations"] != null ? (dsUnderwritingLocations.tblUnderwritingLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["tblInspectionCompaniestblUnderwritingLocations"]) : new dsUnderwritingLocations.tblUnderwritingLocationsRow[0];
    }
  }

  public class lstClassCodesRow : DataRow
  {
    private dsUnderwritingLocations.lstClassCodesDataTable tablelstClassCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstClassCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstClassCodes = (dsUnderwritingLocations.lstClassCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ClassCodeID
    {
      get => Conversions.ToInteger(this[this.tablelstClassCodes.ClassCodeIDColumn]);
      set => this[this.tablelstClassCodes.ClassCodeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ClassCodeDescription
    {
      get => Conversions.ToString(this[this.tablelstClassCodes.ClassCodeDescriptionColumn]);
      set => this[this.tablelstClassCodes.ClassCodeDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblUnderwritingLocationsRow[] GettblUnderwritingLocationsRows()
    {
      return this.Table.ChildRelations["lstPolicyClassestblUnderwritingLocations"] != null ? (dsUnderwritingLocations.tblUnderwritingLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstPolicyClassestblUnderwritingLocations"]) : new dsUnderwritingLocations.tblUnderwritingLocationsRow[0];
    }
  }

  public class lstUnderwritingLocations_AlarmTypesRow : DataRow
  {
    private dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesDataTable tablelstUnderwritingLocations_AlarmTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstUnderwritingLocations_AlarmTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstUnderwritingLocations_AlarmTypes = (dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int AlarmTypeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tablelstUnderwritingLocations_AlarmTypes.AlarmTypeIDColumn]);
      }
      set => this[this.tablelstUnderwritingLocations_AlarmTypes.AlarmTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AlarmType
    {
      get
      {
        return Conversions.ToString(this[this.tablelstUnderwritingLocations_AlarmTypes.AlarmTypeColumn]);
      }
      set => this[this.tablelstUnderwritingLocations_AlarmTypes.AlarmTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblUnderwritingLocationsRow[] GettblUnderwritingLocationsRowsBylstUnderwritingLocations_AlarmTypestblUnderwritingLocations()
    {
      return this.Table.ChildRelations["lstUnderwritingLocations_AlarmTypestblUnderwritingLocations"] != null ? (dsUnderwritingLocations.tblUnderwritingLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstUnderwritingLocations_AlarmTypestblUnderwritingLocations"]) : new dsUnderwritingLocations.tblUnderwritingLocationsRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblUnderwritingLocationsRow[] GettblUnderwritingLocationsRowsBylstUnderwritingLocations_AlarmTypestblUnderwritingLocations1()
    {
      return this.Table.ChildRelations["lstUnderwritingLocations_AlarmTypestblUnderwritingLocations1"] != null ? (dsUnderwritingLocations.tblUnderwritingLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstUnderwritingLocations_AlarmTypestblUnderwritingLocations1"]) : new dsUnderwritingLocations.tblUnderwritingLocationsRow[0];
    }
  }

  public class lstUnderwritingLocations_SprinklerTypesRow : DataRow
  {
    private dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesDataTable tablelstUnderwritingLocations_SprinklerTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstUnderwritingLocations_SprinklerTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstUnderwritingLocations_SprinklerTypes = (dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int SprinklerTypeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tablelstUnderwritingLocations_SprinklerTypes.SprinklerTypeIDColumn]);
      }
      set
      {
        this[this.tablelstUnderwritingLocations_SprinklerTypes.SprinklerTypeIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string WetDry
    {
      get
      {
        return Conversions.ToString(this[this.tablelstUnderwritingLocations_SprinklerTypes.WetDryColumn]);
      }
      set => this[this.tablelstUnderwritingLocations_SprinklerTypes.WetDryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Extent
    {
      get
      {
        return Conversions.ToString(this[this.tablelstUnderwritingLocations_SprinklerTypes.ExtentColumn]);
      }
      set => this[this.tablelstUnderwritingLocations_SprinklerTypes.ExtentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Alarm
    {
      get
      {
        return Conversions.ToString(this[this.tablelstUnderwritingLocations_SprinklerTypes.AlarmColumn]);
      }
      set => this[this.tablelstUnderwritingLocations_SprinklerTypes.AlarmColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Display
    {
      get
      {
        return Conversions.ToString(this[this.tablelstUnderwritingLocations_SprinklerTypes.DisplayColumn]);
      }
      set => this[this.tablelstUnderwritingLocations_SprinklerTypes.DisplayColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblUnderwritingLocationsRow[] GettblUnderwritingLocationsRows()
    {
      return this.Table.ChildRelations["lstUnderwritingLocations_SprinklerTypestblUnderwritingLocations"] != null ? (dsUnderwritingLocations.tblUnderwritingLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstUnderwritingLocations_SprinklerTypestblUnderwritingLocations"]) : new dsUnderwritingLocations.tblUnderwritingLocationsRow[0];
    }
  }

  public class lstWindRestrictionsRow : DataRow
  {
    private dsUnderwritingLocations.lstWindRestrictionsDataTable tablelstWindRestrictions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstWindRestrictionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstWindRestrictions = (dsUnderwritingLocations.lstWindRestrictionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RestrictionID
    {
      get => Conversions.ToInteger(this[this.tablelstWindRestrictions.RestrictionIDColumn]);
      set => this[this.tablelstWindRestrictions.RestrictionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Restriction
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstWindRestrictions.RestrictionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Restriction' in table 'lstWindRestrictions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstWindRestrictions.RestrictionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRestrictionNull() => this.IsNull(this.tablelstWindRestrictions.RestrictionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRestrictionNull()
    {
      this[this.tablelstWindRestrictions.RestrictionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblUnderwritingLocationsRow[] GettblUnderwritingLocationsRows()
    {
      return this.Table.ChildRelations["lstWindRestrictionstblUnderwritingLocations"] != null ? (dsUnderwritingLocations.tblUnderwritingLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstWindRestrictionstblUnderwritingLocations"]) : new dsUnderwritingLocations.tblUnderwritingLocationsRow[0];
    }
  }

  public class dtLocationsRow : DataRow
  {
    private dsUnderwritingLocations.dtLocationsDataTable tabledtLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtLocations = (dsUnderwritingLocations.dtLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabledtLocations.LocationIDColumn]);
      set => this[this.tabledtLocations.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int OriginalLocationID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledtLocations.OriginalLocationIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OriginalLocationID' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.OriginalLocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOriginalLocationIDNull()
    {
      return this.IsNull(this.tabledtLocations.OriginalLocationIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOriginalLocationIDNull()
    {
      this[this.tabledtLocations.OriginalLocationIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtRoofInspectionCompaniesRow : DataRow
  {
    private dsUnderwritingLocations.dtRoofInspectionCompaniesDataTable tabledtRoofInspectionCompanies;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtRoofInspectionCompaniesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtRoofInspectionCompanies = (dsUnderwritingLocations.dtRoofInspectionCompaniesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PayeeID
    {
      get => Conversions.ToInteger(this[this.tabledtRoofInspectionCompanies.PayeeIDColumn]);
      set => this[this.tabledtRoofInspectionCompanies.PayeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PayeeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtRoofInspectionCompanies.PayeeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PayeeName' in table 'dtRoofInspectionCompanies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtRoofInspectionCompanies.PayeeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPayeeNameNull()
    {
      return this.IsNull(this.tabledtRoofInspectionCompanies.PayeeNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPayeeNameNull()
    {
      this[this.tabledtRoofInspectionCompanies.PayeeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstFloodZonesRow : DataRow
  {
    private dsUnderwritingLocations.lstFloodZonesDataTable tablelstFloodZones;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstFloodZonesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstFloodZones = (dsUnderwritingLocations.lstFloodZonesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FloodZone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstFloodZones.FloodZoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FloodZone' in table 'lstFloodZones' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstFloodZones.FloodZoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFloodZoneNull() => this.IsNull(this.tablelstFloodZones.FloodZoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFloodZoneNull()
    {
      this[this.tablelstFloodZones.FloodZoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblUnderwritingLocationsRowChangeEvent : EventArgs
  {
    private dsUnderwritingLocations.tblUnderwritingLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblUnderwritingLocationsRowChangeEvent(
      dsUnderwritingLocations.tblUnderwritingLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblUnderwritingLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstConstructionTypesRowChangeEvent : EventArgs
  {
    private dsUnderwritingLocations.lstConstructionTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstConstructionTypesRowChangeEvent(
      dsUnderwritingLocations.lstConstructionTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstConstructionTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblFin_ExpensePayeesRowChangeEvent : EventArgs
  {
    private dsUnderwritingLocations.tblFin_ExpensePayeesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblFin_ExpensePayeesRowChangeEvent(
      dsUnderwritingLocations.tblFin_ExpensePayeesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.tblFin_ExpensePayeesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstClassCodesRowChangeEvent : EventArgs
  {
    private dsUnderwritingLocations.lstClassCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstClassCodesRowChangeEvent(
      dsUnderwritingLocations.lstClassCodesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstClassCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstUnderwritingLocations_AlarmTypesRowChangeEvent : EventArgs
  {
    private dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstUnderwritingLocations_AlarmTypesRowChangeEvent(
      dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstUnderwritingLocations_AlarmTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstUnderwritingLocations_SprinklerTypesRowChangeEvent : EventArgs
  {
    private dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstUnderwritingLocations_SprinklerTypesRowChangeEvent(
      dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstUnderwritingLocations_SprinklerTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstWindRestrictionsRowChangeEvent : EventArgs
  {
    private dsUnderwritingLocations.lstWindRestrictionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstWindRestrictionsRowChangeEvent(
      dsUnderwritingLocations.lstWindRestrictionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstWindRestrictionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtLocationsRowChangeEvent : EventArgs
  {
    private dsUnderwritingLocations.dtLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtLocationsRowChangeEvent(
      dsUnderwritingLocations.dtLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.dtLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtRoofInspectionCompaniesRowChangeEvent : EventArgs
  {
    private dsUnderwritingLocations.dtRoofInspectionCompaniesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtRoofInspectionCompaniesRowChangeEvent(
      dsUnderwritingLocations.dtRoofInspectionCompaniesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.dtRoofInspectionCompaniesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstFloodZonesRowChangeEvent : EventArgs
  {
    private dsUnderwritingLocations.lstFloodZonesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstFloodZonesRowChangeEvent(
      dsUnderwritingLocations.lstFloodZonesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsUnderwritingLocations.lstFloodZonesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
