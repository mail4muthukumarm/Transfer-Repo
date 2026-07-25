// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.dsProducers
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

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
namespace MGASystems.IMS.InsuredsProducersCompanies.Producers;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsProducers")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsProducers : DataSet
{
  private dsProducers.lstProducerTypesDataTable tablelstProducerTypes;
  private dsProducers.lstDeliveryMethodDataTable tablelstDeliveryMethod;
  private dsProducers.tblProducerContactsDataTable tabletblProducerContacts;
  private dsProducers.tblProducerLocationsDataTable tabletblProducerLocations;
  private dsProducers.lstStatusDataTable tablelstStatus;
  private dsProducers.lstLocationTypeDataTable tablelstLocationType;
  private dsProducers.lstProducerBusinessTypesDataTable tablelstProducerBusinessTypes;
  private dsProducers.tblProducersDataTable tabletblProducers;
  private dsProducers.CompanyLinesDataTable tableCompanyLines;
  private dsProducers.lstProducerLocationRegionsDataTable tablelstProducerLocationRegions;
  private dsProducers.lstProducerLocationSourceDataTable tablelstProducerLocationSource;
  private dsProducers.lstProductionPotentialDataTable tablelstProductionPotential;
  private dsProducers.tblUsersDataTable tabletblUsers;
  private dsProducers.tblProducerCallReportDataTable tabletblProducerCallReport;
  private dsProducers.lstProducerRankingsDataTable tablelstProducerRankings;
  private dsProducers.lstPaymentMethodsDataTable tablelstPaymentMethods;
  private dsProducers.lstProducersDataTable tablelstProducers;
  private dsProducers.lstProducerStatusReasonsDataTable tablelstProducerStatusReasons;
  private DataRelation relationtblProducerLocationstblProducerContacts;
  private DataRelation relationlstDeliveryMethodtblProducerLocations;
  private DataRelation relationlstProducerTypestblProducerLocations;
  private DataRelation relationlstStatustblProducerLocations;
  private DataRelation relationlstLocationTypetblProducerLocations;
  private DataRelation relationtblProducerstblProducerLocations;
  private DataRelation relationlstProducerLocationRegionstblProducerLocations;
  private DataRelation relationlstProducerBusinessTypestblProducers;
  private DataRelation relationlstProducers_tblProducerLocations;
  private DataRelation relationlstProducerStatusReasons_tblProducerLocations;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsProducers()
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
  protected dsProducers(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstProducerTypes)] != null)
          base.Tables.Add((DataTable) new dsProducers.lstProducerTypesDataTable(dataSet.Tables[nameof (lstProducerTypes)]));
        if (dataSet.Tables[nameof (lstDeliveryMethod)] != null)
          base.Tables.Add((DataTable) new dsProducers.lstDeliveryMethodDataTable(dataSet.Tables[nameof (lstDeliveryMethod)]));
        if (dataSet.Tables[nameof (tblProducerContacts)] != null)
          base.Tables.Add((DataTable) new dsProducers.tblProducerContactsDataTable(dataSet.Tables[nameof (tblProducerContacts)]));
        if (dataSet.Tables[nameof (tblProducerLocations)] != null)
          base.Tables.Add((DataTable) new dsProducers.tblProducerLocationsDataTable(dataSet.Tables[nameof (tblProducerLocations)]));
        if (dataSet.Tables[nameof (lstStatus)] != null)
          base.Tables.Add((DataTable) new dsProducers.lstStatusDataTable(dataSet.Tables[nameof (lstStatus)]));
        if (dataSet.Tables[nameof (lstLocationType)] != null)
          base.Tables.Add((DataTable) new dsProducers.lstLocationTypeDataTable(dataSet.Tables[nameof (lstLocationType)]));
        if (dataSet.Tables[nameof (lstProducerBusinessTypes)] != null)
          base.Tables.Add((DataTable) new dsProducers.lstProducerBusinessTypesDataTable(dataSet.Tables[nameof (lstProducerBusinessTypes)]));
        if (dataSet.Tables[nameof (tblProducers)] != null)
          base.Tables.Add((DataTable) new dsProducers.tblProducersDataTable(dataSet.Tables[nameof (tblProducers)]));
        if (dataSet.Tables[nameof (CompanyLines)] != null)
          base.Tables.Add((DataTable) new dsProducers.CompanyLinesDataTable(dataSet.Tables[nameof (CompanyLines)]));
        if (dataSet.Tables[nameof (lstProducerLocationRegions)] != null)
          base.Tables.Add((DataTable) new dsProducers.lstProducerLocationRegionsDataTable(dataSet.Tables[nameof (lstProducerLocationRegions)]));
        if (dataSet.Tables[nameof (lstProducerLocationSource)] != null)
          base.Tables.Add((DataTable) new dsProducers.lstProducerLocationSourceDataTable(dataSet.Tables[nameof (lstProducerLocationSource)]));
        if (dataSet.Tables[nameof (lstProductionPotential)] != null)
          base.Tables.Add((DataTable) new dsProducers.lstProductionPotentialDataTable(dataSet.Tables[nameof (lstProductionPotential)]));
        if (dataSet.Tables[nameof (tblUsers)] != null)
          base.Tables.Add((DataTable) new dsProducers.tblUsersDataTable(dataSet.Tables[nameof (tblUsers)]));
        if (dataSet.Tables[nameof (tblProducerCallReport)] != null)
          base.Tables.Add((DataTable) new dsProducers.tblProducerCallReportDataTable(dataSet.Tables[nameof (tblProducerCallReport)]));
        if (dataSet.Tables[nameof (lstProducerRankings)] != null)
          base.Tables.Add((DataTable) new dsProducers.lstProducerRankingsDataTable(dataSet.Tables[nameof (lstProducerRankings)]));
        if (dataSet.Tables[nameof (lstPaymentMethods)] != null)
          base.Tables.Add((DataTable) new dsProducers.lstPaymentMethodsDataTable(dataSet.Tables[nameof (lstPaymentMethods)]));
        if (dataSet.Tables[nameof (lstProducers)] != null)
          base.Tables.Add((DataTable) new dsProducers.lstProducersDataTable(dataSet.Tables[nameof (lstProducers)]));
        if (dataSet.Tables[nameof (lstProducerStatusReasons)] != null)
          base.Tables.Add((DataTable) new dsProducers.lstProducerStatusReasonsDataTable(dataSet.Tables[nameof (lstProducerStatusReasons)]));
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
  public dsProducers.lstProducerTypesDataTable lstProducerTypes => this.tablelstProducerTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.lstDeliveryMethodDataTable lstDeliveryMethod => this.tablelstDeliveryMethod;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.tblProducerContactsDataTable tblProducerContacts
  {
    get => this.tabletblProducerContacts;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.tblProducerLocationsDataTable tblProducerLocations
  {
    get => this.tabletblProducerLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.lstStatusDataTable lstStatus => this.tablelstStatus;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.lstLocationTypeDataTable lstLocationType => this.tablelstLocationType;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.lstProducerBusinessTypesDataTable lstProducerBusinessTypes
  {
    get => this.tablelstProducerBusinessTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.tblProducersDataTable tblProducers => this.tabletblProducers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.CompanyLinesDataTable CompanyLines => this.tableCompanyLines;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.lstProducerLocationRegionsDataTable lstProducerLocationRegions
  {
    get => this.tablelstProducerLocationRegions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.lstProducerLocationSourceDataTable lstProducerLocationSource
  {
    get => this.tablelstProducerLocationSource;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.lstProductionPotentialDataTable lstProductionPotential
  {
    get => this.tablelstProductionPotential;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.tblUsersDataTable tblUsers => this.tabletblUsers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.tblProducerCallReportDataTable tblProducerCallReport
  {
    get => this.tabletblProducerCallReport;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.lstProducerRankingsDataTable lstProducerRankings
  {
    get => this.tablelstProducerRankings;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.lstPaymentMethodsDataTable lstPaymentMethods => this.tablelstPaymentMethods;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.lstProducersDataTable lstProducers => this.tablelstProducers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducers.lstProducerStatusReasonsDataTable lstProducerStatusReasons
  {
    get => this.tablelstProducerStatusReasons;
  }

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
    dsProducers dsProducers = (dsProducers) base.Clone();
    dsProducers.InitVars();
    dsProducers.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsProducers;
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
      if (dataSet.Tables["lstProducerTypes"] != null)
        base.Tables.Add((DataTable) new dsProducers.lstProducerTypesDataTable(dataSet.Tables["lstProducerTypes"]));
      if (dataSet.Tables["lstDeliveryMethod"] != null)
        base.Tables.Add((DataTable) new dsProducers.lstDeliveryMethodDataTable(dataSet.Tables["lstDeliveryMethod"]));
      if (dataSet.Tables["tblProducerContacts"] != null)
        base.Tables.Add((DataTable) new dsProducers.tblProducerContactsDataTable(dataSet.Tables["tblProducerContacts"]));
      if (dataSet.Tables["tblProducerLocations"] != null)
        base.Tables.Add((DataTable) new dsProducers.tblProducerLocationsDataTable(dataSet.Tables["tblProducerLocations"]));
      if (dataSet.Tables["lstStatus"] != null)
        base.Tables.Add((DataTable) new dsProducers.lstStatusDataTable(dataSet.Tables["lstStatus"]));
      if (dataSet.Tables["lstLocationType"] != null)
        base.Tables.Add((DataTable) new dsProducers.lstLocationTypeDataTable(dataSet.Tables["lstLocationType"]));
      if (dataSet.Tables["lstProducerBusinessTypes"] != null)
        base.Tables.Add((DataTable) new dsProducers.lstProducerBusinessTypesDataTable(dataSet.Tables["lstProducerBusinessTypes"]));
      if (dataSet.Tables["tblProducers"] != null)
        base.Tables.Add((DataTable) new dsProducers.tblProducersDataTable(dataSet.Tables["tblProducers"]));
      if (dataSet.Tables["CompanyLines"] != null)
        base.Tables.Add((DataTable) new dsProducers.CompanyLinesDataTable(dataSet.Tables["CompanyLines"]));
      if (dataSet.Tables["lstProducerLocationRegions"] != null)
        base.Tables.Add((DataTable) new dsProducers.lstProducerLocationRegionsDataTable(dataSet.Tables["lstProducerLocationRegions"]));
      if (dataSet.Tables["lstProducerLocationSource"] != null)
        base.Tables.Add((DataTable) new dsProducers.lstProducerLocationSourceDataTable(dataSet.Tables["lstProducerLocationSource"]));
      if (dataSet.Tables["lstProductionPotential"] != null)
        base.Tables.Add((DataTable) new dsProducers.lstProductionPotentialDataTable(dataSet.Tables["lstProductionPotential"]));
      if (dataSet.Tables["tblUsers"] != null)
        base.Tables.Add((DataTable) new dsProducers.tblUsersDataTable(dataSet.Tables["tblUsers"]));
      if (dataSet.Tables["tblProducerCallReport"] != null)
        base.Tables.Add((DataTable) new dsProducers.tblProducerCallReportDataTable(dataSet.Tables["tblProducerCallReport"]));
      if (dataSet.Tables["lstProducerRankings"] != null)
        base.Tables.Add((DataTable) new dsProducers.lstProducerRankingsDataTable(dataSet.Tables["lstProducerRankings"]));
      if (dataSet.Tables["lstPaymentMethods"] != null)
        base.Tables.Add((DataTable) new dsProducers.lstPaymentMethodsDataTable(dataSet.Tables["lstPaymentMethods"]));
      if (dataSet.Tables["lstProducers"] != null)
        base.Tables.Add((DataTable) new dsProducers.lstProducersDataTable(dataSet.Tables["lstProducers"]));
      if (dataSet.Tables["lstProducerStatusReasons"] != null)
        base.Tables.Add((DataTable) new dsProducers.lstProducerStatusReasonsDataTable(dataSet.Tables["lstProducerStatusReasons"]));
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
    this.tablelstProducerTypes = (dsProducers.lstProducerTypesDataTable) base.Tables["lstProducerTypes"];
    if (initTable && this.tablelstProducerTypes != null)
      this.tablelstProducerTypes.InitVars();
    this.tablelstDeliveryMethod = (dsProducers.lstDeliveryMethodDataTable) base.Tables["lstDeliveryMethod"];
    if (initTable && this.tablelstDeliveryMethod != null)
      this.tablelstDeliveryMethod.InitVars();
    this.tabletblProducerContacts = (dsProducers.tblProducerContactsDataTable) base.Tables["tblProducerContacts"];
    if (initTable && this.tabletblProducerContacts != null)
      this.tabletblProducerContacts.InitVars();
    this.tabletblProducerLocations = (dsProducers.tblProducerLocationsDataTable) base.Tables["tblProducerLocations"];
    if (initTable && this.tabletblProducerLocations != null)
      this.tabletblProducerLocations.InitVars();
    this.tablelstStatus = (dsProducers.lstStatusDataTable) base.Tables["lstStatus"];
    if (initTable && this.tablelstStatus != null)
      this.tablelstStatus.InitVars();
    this.tablelstLocationType = (dsProducers.lstLocationTypeDataTable) base.Tables["lstLocationType"];
    if (initTable && this.tablelstLocationType != null)
      this.tablelstLocationType.InitVars();
    this.tablelstProducerBusinessTypes = (dsProducers.lstProducerBusinessTypesDataTable) base.Tables["lstProducerBusinessTypes"];
    if (initTable && this.tablelstProducerBusinessTypes != null)
      this.tablelstProducerBusinessTypes.InitVars();
    this.tabletblProducers = (dsProducers.tblProducersDataTable) base.Tables["tblProducers"];
    if (initTable && this.tabletblProducers != null)
      this.tabletblProducers.InitVars();
    this.tableCompanyLines = (dsProducers.CompanyLinesDataTable) base.Tables["CompanyLines"];
    if (initTable && this.tableCompanyLines != null)
      this.tableCompanyLines.InitVars();
    this.tablelstProducerLocationRegions = (dsProducers.lstProducerLocationRegionsDataTable) base.Tables["lstProducerLocationRegions"];
    if (initTable && this.tablelstProducerLocationRegions != null)
      this.tablelstProducerLocationRegions.InitVars();
    this.tablelstProducerLocationSource = (dsProducers.lstProducerLocationSourceDataTable) base.Tables["lstProducerLocationSource"];
    if (initTable && this.tablelstProducerLocationSource != null)
      this.tablelstProducerLocationSource.InitVars();
    this.tablelstProductionPotential = (dsProducers.lstProductionPotentialDataTable) base.Tables["lstProductionPotential"];
    if (initTable && this.tablelstProductionPotential != null)
      this.tablelstProductionPotential.InitVars();
    this.tabletblUsers = (dsProducers.tblUsersDataTable) base.Tables["tblUsers"];
    if (initTable && this.tabletblUsers != null)
      this.tabletblUsers.InitVars();
    this.tabletblProducerCallReport = (dsProducers.tblProducerCallReportDataTable) base.Tables["tblProducerCallReport"];
    if (initTable && this.tabletblProducerCallReport != null)
      this.tabletblProducerCallReport.InitVars();
    this.tablelstProducerRankings = (dsProducers.lstProducerRankingsDataTable) base.Tables["lstProducerRankings"];
    if (initTable && this.tablelstProducerRankings != null)
      this.tablelstProducerRankings.InitVars();
    this.tablelstPaymentMethods = (dsProducers.lstPaymentMethodsDataTable) base.Tables["lstPaymentMethods"];
    if (initTable && this.tablelstPaymentMethods != null)
      this.tablelstPaymentMethods.InitVars();
    this.tablelstProducers = (dsProducers.lstProducersDataTable) base.Tables["lstProducers"];
    if (initTable && this.tablelstProducers != null)
      this.tablelstProducers.InitVars();
    this.tablelstProducerStatusReasons = (dsProducers.lstProducerStatusReasonsDataTable) base.Tables["lstProducerStatusReasons"];
    if (initTable && this.tablelstProducerStatusReasons != null)
      this.tablelstProducerStatusReasons.InitVars();
    this.relationtblProducerLocationstblProducerContacts = this.Relations["tblProducerLocationstblProducerContacts"];
    this.relationlstDeliveryMethodtblProducerLocations = this.Relations["lstDeliveryMethodtblProducerLocations"];
    this.relationlstProducerTypestblProducerLocations = this.Relations["lstProducerTypestblProducerLocations"];
    this.relationlstStatustblProducerLocations = this.Relations["lstStatustblProducerLocations"];
    this.relationlstLocationTypetblProducerLocations = this.Relations["lstLocationTypetblProducerLocations"];
    this.relationtblProducerstblProducerLocations = this.Relations["tblProducerstblProducerLocations"];
    this.relationlstProducerLocationRegionstblProducerLocations = this.Relations["lstProducerLocationRegionstblProducerLocations"];
    this.relationlstProducerBusinessTypestblProducers = this.Relations["lstProducerBusinessTypestblProducers"];
    this.relationlstProducers_tblProducerLocations = this.Relations["lstProducers_tblProducerLocations"];
    this.relationlstProducerStatusReasons_tblProducerLocations = this.Relations["lstProducerStatusReasons_tblProducerLocations"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsProducers);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsProducers.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstProducerTypes = new dsProducers.lstProducerTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstProducerTypes);
    this.tablelstDeliveryMethod = new dsProducers.lstDeliveryMethodDataTable();
    base.Tables.Add((DataTable) this.tablelstDeliveryMethod);
    this.tabletblProducerContacts = new dsProducers.tblProducerContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerContacts);
    this.tabletblProducerLocations = new dsProducers.tblProducerLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerLocations);
    this.tablelstStatus = new dsProducers.lstStatusDataTable();
    base.Tables.Add((DataTable) this.tablelstStatus);
    this.tablelstLocationType = new dsProducers.lstLocationTypeDataTable();
    base.Tables.Add((DataTable) this.tablelstLocationType);
    this.tablelstProducerBusinessTypes = new dsProducers.lstProducerBusinessTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstProducerBusinessTypes);
    this.tabletblProducers = new dsProducers.tblProducersDataTable();
    base.Tables.Add((DataTable) this.tabletblProducers);
    this.tableCompanyLines = new dsProducers.CompanyLinesDataTable();
    base.Tables.Add((DataTable) this.tableCompanyLines);
    this.tablelstProducerLocationRegions = new dsProducers.lstProducerLocationRegionsDataTable();
    base.Tables.Add((DataTable) this.tablelstProducerLocationRegions);
    this.tablelstProducerLocationSource = new dsProducers.lstProducerLocationSourceDataTable();
    base.Tables.Add((DataTable) this.tablelstProducerLocationSource);
    this.tablelstProductionPotential = new dsProducers.lstProductionPotentialDataTable();
    base.Tables.Add((DataTable) this.tablelstProductionPotential);
    this.tabletblUsers = new dsProducers.tblUsersDataTable();
    base.Tables.Add((DataTable) this.tabletblUsers);
    this.tabletblProducerCallReport = new dsProducers.tblProducerCallReportDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerCallReport);
    this.tablelstProducerRankings = new dsProducers.lstProducerRankingsDataTable();
    base.Tables.Add((DataTable) this.tablelstProducerRankings);
    this.tablelstPaymentMethods = new dsProducers.lstPaymentMethodsDataTable();
    base.Tables.Add((DataTable) this.tablelstPaymentMethods);
    this.tablelstProducers = new dsProducers.lstProducersDataTable();
    base.Tables.Add((DataTable) this.tablelstProducers);
    this.tablelstProducerStatusReasons = new dsProducers.lstProducerStatusReasonsDataTable();
    base.Tables.Add((DataTable) this.tablelstProducerStatusReasons);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("tblProducerLocationstblProducerContacts", new DataColumn[1]
    {
      this.tabletblProducerLocations.ProducerLocationGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerContacts.ProducerLocationGUIDColumn
    });
    this.tabletblProducerContacts.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstDeliveryMethodtblProducerLocations", new DataColumn[1]
    {
      this.tablelstDeliveryMethod.DeliveryMethodIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerLocations.DeliveryMethodIDColumn
    });
    this.tabletblProducerLocations.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("lstProducerTypestblProducerLocations", new DataColumn[1]
    {
      this.tablelstProducerTypes.ProducerTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerLocations.ProducerTypeIDColumn
    });
    this.tabletblProducerLocations.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("lstStatustblProducerLocations", new DataColumn[1]
    {
      this.tablelstStatus.StatusIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerLocations.StatusIDColumn
    });
    this.tabletblProducerLocations.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint5 = new ForeignKeyConstraint("lstLocationTypetblProducerLocations", new DataColumn[1]
    {
      this.tablelstLocationType.LocationTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerLocations.LocationTypeIDColumn
    });
    this.tabletblProducerLocations.Constraints.Add((Constraint) foreignKeyConstraint5);
    foreignKeyConstraint5.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint5.DeleteRule = Rule.Cascade;
    foreignKeyConstraint5.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint6 = new ForeignKeyConstraint("tblProducerstblProducerLocations", new DataColumn[1]
    {
      this.tabletblProducers.ProducerGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerLocations.ProducerGUIDColumn
    });
    this.tabletblProducerLocations.Constraints.Add((Constraint) foreignKeyConstraint6);
    foreignKeyConstraint6.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint6.DeleteRule = Rule.Cascade;
    foreignKeyConstraint6.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint7 = new ForeignKeyConstraint("lstProducerLocationRegionstblProducerLocations", new DataColumn[1]
    {
      this.tablelstProducerLocationRegions.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerLocations.ProducerLocationRegionColumn
    });
    this.tabletblProducerLocations.Constraints.Add((Constraint) foreignKeyConstraint7);
    foreignKeyConstraint7.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint7.DeleteRule = Rule.Cascade;
    foreignKeyConstraint7.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint8 = new ForeignKeyConstraint("lstProducerBusinessTypestblProducers", new DataColumn[1]
    {
      this.tablelstProducerBusinessTypes.BusinessTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducers.ProducerBusinessTypeIDColumn
    });
    this.tabletblProducers.Constraints.Add((Constraint) foreignKeyConstraint8);
    foreignKeyConstraint8.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint8.DeleteRule = Rule.Cascade;
    foreignKeyConstraint8.UpdateRule = Rule.Cascade;
    this.relationtblProducerLocationstblProducerContacts = new DataRelation("tblProducerLocationstblProducerContacts", new DataColumn[1]
    {
      this.tabletblProducerLocations.ProducerLocationGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerContacts.ProducerLocationGUIDColumn
    }, false);
    this.Relations.Add(this.relationtblProducerLocationstblProducerContacts);
    this.relationlstDeliveryMethodtblProducerLocations = new DataRelation("lstDeliveryMethodtblProducerLocations", new DataColumn[1]
    {
      this.tablelstDeliveryMethod.DeliveryMethodIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerLocations.DeliveryMethodIDColumn
    }, false);
    this.Relations.Add(this.relationlstDeliveryMethodtblProducerLocations);
    this.relationlstProducerTypestblProducerLocations = new DataRelation("lstProducerTypestblProducerLocations", new DataColumn[1]
    {
      this.tablelstProducerTypes.ProducerTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerLocations.ProducerTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstProducerTypestblProducerLocations);
    this.relationlstStatustblProducerLocations = new DataRelation("lstStatustblProducerLocations", new DataColumn[1]
    {
      this.tablelstStatus.StatusIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerLocations.StatusIDColumn
    }, false);
    this.Relations.Add(this.relationlstStatustblProducerLocations);
    this.relationlstLocationTypetblProducerLocations = new DataRelation("lstLocationTypetblProducerLocations", new DataColumn[1]
    {
      this.tablelstLocationType.LocationTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerLocations.LocationTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstLocationTypetblProducerLocations);
    this.relationtblProducerstblProducerLocations = new DataRelation("tblProducerstblProducerLocations", new DataColumn[1]
    {
      this.tabletblProducers.ProducerGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerLocations.ProducerGUIDColumn
    }, false);
    this.Relations.Add(this.relationtblProducerstblProducerLocations);
    this.relationlstProducerLocationRegionstblProducerLocations = new DataRelation("lstProducerLocationRegionstblProducerLocations", new DataColumn[1]
    {
      this.tablelstProducerLocationRegions.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerLocations.ProducerLocationRegionColumn
    }, false);
    this.Relations.Add(this.relationlstProducerLocationRegionstblProducerLocations);
    this.relationlstProducerBusinessTypestblProducers = new DataRelation("lstProducerBusinessTypestblProducers", new DataColumn[1]
    {
      this.tablelstProducerBusinessTypes.BusinessTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducers.ProducerBusinessTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstProducerBusinessTypestblProducers);
    this.relationlstProducers_tblProducerLocations = new DataRelation("lstProducers_tblProducerLocations", new DataColumn[1]
    {
      this.tablelstProducers.ProducerGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerLocations.ReferredBYProdLocationColumn
    }, false);
    this.Relations.Add(this.relationlstProducers_tblProducerLocations);
    this.relationlstProducerStatusReasons_tblProducerLocations = new DataRelation("lstProducerStatusReasons_tblProducerLocations", new DataColumn[1]
    {
      this.tablelstProducerStatusReasons.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerLocations.StatusChangeReasonIDColumn
    }, false);
    this.Relations.Add(this.relationlstProducerStatusReasons_tblProducerLocations);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstProducerTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstDeliveryMethod() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblProducerContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblProducerLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstStatus() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstLocationType() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstProducerBusinessTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblProducers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeCompanyLines() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstProducerLocationRegions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstProducerLocationSource() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstProductionPotential() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblUsers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblProducerCallReport() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstProducerRankings() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstPaymentMethods() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstProducers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstProducerStatusReasons() => false;

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
    dsProducers dsProducers = new dsProducers();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsProducers.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblProducerLocationsDataTable : TypedTableBase<dsProducers.tblProducerLocationsRow>
  {
    private DataColumn columnProducerLocationGUID;
    private DataColumn columnProducerGUID;
    private DataColumn columnProducerTypeID;
    private DataColumn columnName;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnCounty;
    private DataColumn columnZipPlus;
    private DataColumn columnPhone;
    private DataColumn columnFax;
    private DataColumn columnFEIN;
    private DataColumn columnClosed;
    private DataColumn columnWebSite;
    private DataColumn columnPrimaryLocation;
    private DataColumn columnDeliveryMethodID;
    private DataColumn columnDateAdded;
    private DataColumn columnLocationTypeID;
    private DataColumn columnStatusID;
    private DataColumn columnHidden;
    private DataColumn columnState;
    private DataColumn columnZipCode;
    private DataColumn columnLocationCode;
    private DataColumn columnEmail;
    private DataColumn columnAllowAutomaticNOC;
    private DataColumn columnISOCountryCode;
    private DataColumn columnRegion;
    private DataColumn columnEmailReminders;
    private DataColumn columnBillToProducerLocationGuid;
    private DataColumn columnMailToProducerLocationGuid;
    private DataColumn columnProducerLocationRegion;
    private DataColumn columnProducerLocationID;
    private DataColumn columnNumEmployees;
    private DataColumn columnGrossWrittenPremium;
    private DataColumn columnOptOut;
    private DataColumn columnProductionPotential;
    private DataColumn columnLocationSource;
    private DataColumn columnOwner;
    private DataColumn columnNumWholesaleRelationship;
    private DataColumn columnWholesaleRelationships;
    private DataColumn columnExpertise;
    private DataColumn columnSetProcedureToEnage;
    private DataColumn columnApproveWholesalersList;
    private DataColumn columnSpecFocusDept;
    private DataColumn columnAgreementEffectiveDate;
    private DataColumn columnProducerRankingID;
    private DataColumn columnPaymentMethodID;
    private DataColumn columnOnStatement;
    private DataColumn columnNPN;
    private DataColumn columnReferredBYProdLocation;
    private DataColumn columnStatusChangeReasonID;
    private DataColumn columnStatusChangeReasonComment;
    private DataColumn columnAddedBy;
    private DataColumn columnDateModified;
    private DataColumn columnModifiedBy;
    private DataColumn columnNameonCheck;
    private DataColumn columnCountryCodeforPhone;
    private DataColumn columnCountryCodeforFax;
    private DataColumn columnInHouseProducer;

    private void tblProducerLocationsDataTable_tblProducerLocationsRowChanging(
      object sender,
      dsProducers.tblProducerLocationsRowChangeEvent e)
    {
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblProducerLocationsDataTable()
    {
      this.tblProducerLocationsRowChanging += new dsProducers.tblProducerLocationsRowChangeEventHandler(this.tblProducerLocationsDataTable_tblProducerLocationsRowChanging);
      this.TableName = "tblProducerLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblProducerLocationsDataTable(DataTable table)
    {
      this.tblProducerLocationsRowChanging += new dsProducers.tblProducerLocationsRowChangeEventHandler(this.tblProducerLocationsDataTable_tblProducerLocationsRowChanging);
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
    protected tblProducerLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.tblProducerLocationsRowChanging += new dsProducers.tblProducerLocationsRowChangeEventHandler(this.tblProducerLocationsDataTable_tblProducerLocationsRowChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerLocationGUIDColumn => this.columnProducerLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerGUIDColumn => this.columnProducerGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerTypeIDColumn => this.columnProducerTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NameColumn => this.columnName;

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
    public DataColumn CountyColumn => this.columnCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ZipPlusColumn => this.columnZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PhoneColumn => this.columnPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FaxColumn => this.columnFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FEINColumn => this.columnFEIN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClosedColumn => this.columnClosed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WebSiteColumn => this.columnWebSite;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PrimaryLocationColumn => this.columnPrimaryLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DeliveryMethodIDColumn => this.columnDeliveryMethodID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateAddedColumn => this.columnDateAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationTypeIDColumn => this.columnLocationTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationCodeColumn => this.columnLocationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AllowAutomaticNOCColumn => this.columnAllowAutomaticNOC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ISOCountryCodeColumn => this.columnISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RegionColumn => this.columnRegion;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EmailRemindersColumn => this.columnEmailReminders;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BillToProducerLocationGuidColumn => this.columnBillToProducerLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MailToProducerLocationGuidColumn => this.columnMailToProducerLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerLocationRegionColumn => this.columnProducerLocationRegion;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerLocationIDColumn => this.columnProducerLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NumEmployeesColumn => this.columnNumEmployees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GrossWrittenPremiumColumn => this.columnGrossWrittenPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OptOutColumn => this.columnOptOut;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProductionPotentialColumn => this.columnProductionPotential;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationSourceColumn => this.columnLocationSource;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OwnerColumn => this.columnOwner;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NumWholesaleRelationshipColumn => this.columnNumWholesaleRelationship;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WholesaleRelationshipsColumn => this.columnWholesaleRelationships;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExpertiseColumn => this.columnExpertise;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SetProcedureToEnageColumn => this.columnSetProcedureToEnage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ApproveWholesalersListColumn => this.columnApproveWholesalersList;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SpecFocusDeptColumn => this.columnSpecFocusDept;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AgreementEffectiveDateColumn => this.columnAgreementEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerRankingIDColumn => this.columnProducerRankingID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PaymentMethodIDColumn => this.columnPaymentMethodID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OnStatementColumn => this.columnOnStatement;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NPNColumn => this.columnNPN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ReferredBYProdLocationColumn => this.columnReferredBYProdLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StatusChangeReasonIDColumn => this.columnStatusChangeReasonID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StatusChangeReasonCommentColumn => this.columnStatusChangeReasonComment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AddedByColumn => this.columnAddedBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateModifiedColumn => this.columnDateModified;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ModifiedByColumn => this.columnModifiedBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NameonCheckColumn => this.columnNameonCheck;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CountryCodeforPhoneColumn => this.columnCountryCodeforPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CountryCodeforFaxColumn => this.columnCountryCodeforFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InHouseProducerColumn => this.columnInHouseProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerLocationsRow this[int index]
    {
      get => (dsProducers.tblProducerLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblProducerLocationsRow(dsProducers.tblProducerLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerLocationsRow AddtblProducerLocationsRow(
      Guid ProducerLocationGUID,
      dsProducers.tblProducersRow parenttblProducersRowBytblProducerstblProducerLocations,
      dsProducers.lstProducerTypesRow parentlstProducerTypesRowBylstProducerTypestblProducerLocations,
      string Name,
      string Address1,
      string Address2,
      string City,
      string County,
      string ZipPlus,
      string Phone,
      string Fax,
      string FEIN,
      bool Closed,
      string WebSite,
      bool PrimaryLocation,
      dsProducers.lstDeliveryMethodRow parentlstDeliveryMethodRowBylstDeliveryMethodtblProducerLocations,
      DateTime DateAdded,
      dsProducers.lstLocationTypeRow parentlstLocationTypeRowBylstLocationTypetblProducerLocations,
      dsProducers.lstStatusRow parentlstStatusRowBylstStatustblProducerLocations,
      bool Hidden,
      string State,
      string ZipCode,
      string LocationCode,
      string Email,
      bool AllowAutomaticNOC,
      string ISOCountryCode,
      string _Region,
      bool EmailReminders,
      Guid BillToProducerLocationGuid,
      Guid MailToProducerLocationGuid,
      dsProducers.lstProducerLocationRegionsRow parentlstProducerLocationRegionsRowBylstProducerLocationRegionstblProducerLocations,
      string ProducerLocationID,
      int NumEmployees,
      Decimal GrossWrittenPremium,
      bool OptOut,
      string ProductionPotential,
      byte LocationSource,
      Guid Owner,
      int NumWholesaleRelationship,
      string WholesaleRelationships,
      string Expertise,
      bool SetProcedureToEnage,
      bool ApproveWholesalersList,
      string SpecFocusDept,
      DateTime AgreementEffectiveDate,
      int ProducerRankingID,
      short PaymentMethodID,
      bool OnStatement,
      string NPN,
      dsProducers.lstProducersRow parentlstProducersRowBylstProducers_tblProducerLocations,
      dsProducers.lstProducerStatusReasonsRow parentlstProducerStatusReasonsRowBylstProducerStatusReasons_tblProducerLocations,
      string StatusChangeReasonComment,
      int AddedBy,
      DateTime DateModified,
      int ModifiedBy,
      string NameonCheck,
      string CountryCodeforPhone,
      string CountryCodeforFax,
      string InHouseProducer)
    {
      dsProducers.tblProducerLocationsRow row = (dsProducers.tblProducerLocationsRow) this.NewRow();
      object[] objArray = new object[59]
      {
        (object) ProducerLocationGUID,
        null,
        null,
        (object) Name,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) County,
        (object) ZipPlus,
        (object) Phone,
        (object) Fax,
        (object) FEIN,
        (object) Closed,
        (object) WebSite,
        (object) PrimaryLocation,
        null,
        (object) DateAdded,
        null,
        null,
        (object) Hidden,
        (object) State,
        (object) ZipCode,
        (object) LocationCode,
        (object) Email,
        (object) AllowAutomaticNOC,
        (object) ISOCountryCode,
        (object) _Region,
        (object) EmailReminders,
        (object) BillToProducerLocationGuid,
        (object) MailToProducerLocationGuid,
        null,
        (object) ProducerLocationID,
        (object) NumEmployees,
        (object) GrossWrittenPremium,
        (object) OptOut,
        (object) ProductionPotential,
        (object) LocationSource,
        (object) Owner,
        (object) NumWholesaleRelationship,
        (object) WholesaleRelationships,
        (object) Expertise,
        (object) SetProcedureToEnage,
        (object) ApproveWholesalersList,
        (object) SpecFocusDept,
        (object) AgreementEffectiveDate,
        (object) ProducerRankingID,
        (object) PaymentMethodID,
        (object) OnStatement,
        (object) NPN,
        null,
        null,
        (object) StatusChangeReasonComment,
        (object) AddedBy,
        (object) DateModified,
        (object) ModifiedBy,
        (object) NameonCheck,
        (object) CountryCodeforPhone,
        (object) CountryCodeforFax,
        (object) InHouseProducer
      };
      if (parenttblProducersRowBytblProducerstblProducerLocations != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblProducersRowBytblProducerstblProducerLocations[0]);
      if (parentlstProducerTypesRowBylstProducerTypestblProducerLocations != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parentlstProducerTypesRowBylstProducerTypestblProducerLocations[0]);
      if (parentlstDeliveryMethodRowBylstDeliveryMethodtblProducerLocations != null)
        objArray[15] = RuntimeHelpers.GetObjectValue(parentlstDeliveryMethodRowBylstDeliveryMethodtblProducerLocations[0]);
      if (parentlstLocationTypeRowBylstLocationTypetblProducerLocations != null)
        objArray[17] = RuntimeHelpers.GetObjectValue(parentlstLocationTypeRowBylstLocationTypetblProducerLocations[0]);
      if (parentlstStatusRowBylstStatustblProducerLocations != null)
        objArray[18] = RuntimeHelpers.GetObjectValue(parentlstStatusRowBylstStatustblProducerLocations[0]);
      if (parentlstProducerLocationRegionsRowBylstProducerLocationRegionstblProducerLocations != null)
        objArray[30] = RuntimeHelpers.GetObjectValue(parentlstProducerLocationRegionsRowBylstProducerLocationRegionstblProducerLocations[0]);
      if (parentlstProducersRowBylstProducers_tblProducerLocations != null)
        objArray[49] = RuntimeHelpers.GetObjectValue(parentlstProducersRowBylstProducers_tblProducerLocations[0]);
      if (parentlstProducerStatusReasonsRowBylstProducerStatusReasons_tblProducerLocations != null)
        objArray[50] = RuntimeHelpers.GetObjectValue(parentlstProducerStatusReasonsRowBylstProducerStatusReasons_tblProducerLocations[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerLocationsRow FindByProducerLocationGUID(Guid ProducerLocationGUID)
    {
      return (dsProducers.tblProducerLocationsRow) this.Rows.Find(new object[1]
      {
        (object) ProducerLocationGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.tblProducerLocationsDataTable locationsDataTable = (dsProducers.tblProducerLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.tblProducerLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerLocationGUID = this.Columns["ProducerLocationGUID"];
      this.columnProducerGUID = this.Columns["ProducerGUID"];
      this.columnProducerTypeID = this.Columns["ProducerTypeID"];
      this.columnName = this.Columns["Name"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnCounty = this.Columns["County"];
      this.columnZipPlus = this.Columns["ZipPlus"];
      this.columnPhone = this.Columns["Phone"];
      this.columnFax = this.Columns["Fax"];
      this.columnFEIN = this.Columns["FEIN"];
      this.columnClosed = this.Columns["Closed"];
      this.columnWebSite = this.Columns["WebSite"];
      this.columnPrimaryLocation = this.Columns["PrimaryLocation"];
      this.columnDeliveryMethodID = this.Columns["DeliveryMethodID"];
      this.columnDateAdded = this.Columns["DateAdded"];
      this.columnLocationTypeID = this.Columns["LocationTypeID"];
      this.columnStatusID = this.Columns["StatusID"];
      this.columnHidden = this.Columns["Hidden"];
      this.columnState = this.Columns["State"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnLocationCode = this.Columns["LocationCode"];
      this.columnEmail = this.Columns["Email"];
      this.columnAllowAutomaticNOC = this.Columns["AllowAutomaticNOC"];
      this.columnISOCountryCode = this.Columns["ISOCountryCode"];
      this.columnRegion = this.Columns["Region"];
      this.columnEmailReminders = this.Columns["EmailReminders"];
      this.columnBillToProducerLocationGuid = this.Columns["BillToProducerLocationGuid"];
      this.columnMailToProducerLocationGuid = this.Columns["MailToProducerLocationGuid"];
      this.columnProducerLocationRegion = this.Columns["ProducerLocationRegion"];
      this.columnProducerLocationID = this.Columns["ProducerLocationID"];
      this.columnNumEmployees = this.Columns["NumEmployees"];
      this.columnGrossWrittenPremium = this.Columns["GrossWrittenPremium"];
      this.columnOptOut = this.Columns["OptOut"];
      this.columnProductionPotential = this.Columns["ProductionPotential"];
      this.columnLocationSource = this.Columns["LocationSource"];
      this.columnOwner = this.Columns["Owner"];
      this.columnNumWholesaleRelationship = this.Columns["NumWholesaleRelationship"];
      this.columnWholesaleRelationships = this.Columns["WholesaleRelationships"];
      this.columnExpertise = this.Columns["Expertise"];
      this.columnSetProcedureToEnage = this.Columns["SetProcedureToEnage"];
      this.columnApproveWholesalersList = this.Columns["ApproveWholesalersList"];
      this.columnSpecFocusDept = this.Columns["SpecFocusDept"];
      this.columnAgreementEffectiveDate = this.Columns["AgreementEffectiveDate"];
      this.columnProducerRankingID = this.Columns["ProducerRankingID"];
      this.columnPaymentMethodID = this.Columns["PaymentMethodID"];
      this.columnOnStatement = this.Columns["OnStatement"];
      this.columnNPN = this.Columns["NPN"];
      this.columnReferredBYProdLocation = this.Columns["ReferredBYProdLocation"];
      this.columnStatusChangeReasonID = this.Columns["StatusChangeReasonID"];
      this.columnStatusChangeReasonComment = this.Columns["StatusChangeReasonComment"];
      this.columnAddedBy = this.Columns["AddedBy"];
      this.columnDateModified = this.Columns["DateModified"];
      this.columnModifiedBy = this.Columns["ModifiedBy"];
      this.columnNameonCheck = this.Columns["NameonCheck"];
      this.columnCountryCodeforPhone = this.Columns["CountryCodeforPhone"];
      this.columnCountryCodeforFax = this.Columns["CountryCodeforFax"];
      this.columnInHouseProducer = this.Columns["InHouseProducer"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnProducerLocationGUID = new DataColumn("ProducerLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGUID);
      this.columnProducerGUID = new DataColumn("ProducerGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerGUID);
      this.columnProducerTypeID = new DataColumn("ProducerTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerTypeID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnAddress2 = new DataColumn("Address2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnCounty = new DataColumn("County", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCounty);
      this.columnZipPlus = new DataColumn("ZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipPlus);
      this.columnPhone = new DataColumn("Phone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhone);
      this.columnFax = new DataColumn("Fax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFax);
      this.columnFEIN = new DataColumn("FEIN", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFEIN);
      this.columnClosed = new DataColumn("Closed", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClosed);
      this.columnWebSite = new DataColumn("WebSite", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWebSite);
      this.columnPrimaryLocation = new DataColumn("PrimaryLocation", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPrimaryLocation);
      this.columnDeliveryMethodID = new DataColumn("DeliveryMethodID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryMethodID);
      this.columnDateAdded = new DataColumn("DateAdded", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateAdded);
      this.columnLocationTypeID = new DataColumn("LocationTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationTypeID);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnLocationCode = new DataColumn("LocationCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationCode);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.columnAllowAutomaticNOC = new DataColumn("AllowAutomaticNOC", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAllowAutomaticNOC);
      this.columnISOCountryCode = new DataColumn("ISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnISOCountryCode);
      this.columnRegion = new DataColumn("Region", typeof (string), (string) null, MappingType.Element);
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "RegionColumn");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnRegion");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Region");
      this.Columns.Add(this.columnRegion);
      this.columnEmailReminders = new DataColumn("EmailReminders", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmailReminders);
      this.columnBillToProducerLocationGuid = new DataColumn("BillToProducerLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillToProducerLocationGuid);
      this.columnMailToProducerLocationGuid = new DataColumn("MailToProducerLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMailToProducerLocationGuid);
      this.columnProducerLocationRegion = new DataColumn("ProducerLocationRegion", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationRegion);
      this.columnProducerLocationID = new DataColumn("ProducerLocationID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationID);
      this.columnNumEmployees = new DataColumn("NumEmployees", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumEmployees);
      this.columnGrossWrittenPremium = new DataColumn("GrossWrittenPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGrossWrittenPremium);
      this.columnOptOut = new DataColumn("OptOut", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptOut);
      this.columnProductionPotential = new DataColumn("ProductionPotential", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProductionPotential);
      this.columnLocationSource = new DataColumn("LocationSource", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationSource);
      this.columnOwner = new DataColumn("Owner", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOwner);
      this.columnNumWholesaleRelationship = new DataColumn("NumWholesaleRelationship", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumWholesaleRelationship);
      this.columnWholesaleRelationships = new DataColumn("WholesaleRelationships", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWholesaleRelationships);
      this.columnExpertise = new DataColumn("Expertise", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpertise);
      this.columnSetProcedureToEnage = new DataColumn("SetProcedureToEnage", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSetProcedureToEnage);
      this.columnApproveWholesalersList = new DataColumn("ApproveWholesalersList", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnApproveWholesalersList);
      this.columnSpecFocusDept = new DataColumn("SpecFocusDept", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecFocusDept);
      this.columnAgreementEffectiveDate = new DataColumn("AgreementEffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAgreementEffectiveDate);
      this.columnProducerRankingID = new DataColumn("ProducerRankingID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerRankingID);
      this.columnPaymentMethodID = new DataColumn("PaymentMethodID", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPaymentMethodID);
      this.columnOnStatement = new DataColumn("OnStatement", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOnStatement);
      this.columnNPN = new DataColumn("NPN", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNPN);
      this.columnReferredBYProdLocation = new DataColumn("ReferredBYProdLocation", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReferredBYProdLocation);
      this.columnStatusChangeReasonID = new DataColumn("StatusChangeReasonID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusChangeReasonID);
      this.columnStatusChangeReasonComment = new DataColumn("StatusChangeReasonComment", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusChangeReasonComment);
      this.columnAddedBy = new DataColumn("AddedBy", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddedBy);
      this.columnDateModified = new DataColumn("DateModified", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateModified);
      this.columnModifiedBy = new DataColumn("ModifiedBy", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModifiedBy);
      this.columnNameonCheck = new DataColumn("NameonCheck", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNameonCheck);
      this.columnCountryCodeforPhone = new DataColumn("CountryCodeforPhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCountryCodeforPhone);
      this.columnCountryCodeforFax = new DataColumn("CountryCodeforFax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCountryCodeforFax);
      this.columnInHouseProducer = new DataColumn("InHouseProducer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInHouseProducer);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducersKey6", new DataColumn[1]
      {
        this.columnProducerLocationGUID
      }, true));
      this.columnProducerLocationGUID.AllowDBNull = false;
      this.columnProducerLocationGUID.Unique = true;
      this.columnProducerGUID.AllowDBNull = false;
      this.columnClosed.AllowDBNull = false;
      this.columnClosed.DefaultValue = (object) false;
      this.columnPrimaryLocation.AllowDBNull = false;
      this.columnPrimaryLocation.DefaultValue = (object) false;
      this.columnDateAdded.AllowDBNull = false;
      this.columnHidden.AllowDBNull = false;
      this.columnHidden.DefaultValue = (object) false;
      this.columnAllowAutomaticNOC.AllowDBNull = false;
      this.columnAllowAutomaticNOC.DefaultValue = (object) false;
      this.columnISOCountryCode.AllowDBNull = false;
      this.columnISOCountryCode.DefaultValue = (object) "USA";
      this.columnEmailReminders.AllowDBNull = false;
      this.columnEmailReminders.DefaultValue = (object) false;
      this.columnOptOut.DefaultValue = (object) false;
      this.columnStatusChangeReasonComment.MaxLength = 250;
      this.columnNameonCheck.MaxLength = 250;
      this.columnCountryCodeforPhone.MaxLength = 5;
      this.columnCountryCodeforFax.MaxLength = 5;
      this.columnInHouseProducer.MaxLength = 75;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerLocationsRow NewtblProducerLocationsRow()
    {
      return (dsProducers.tblProducerLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.tblProducerLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.tblProducerLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducerLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblProducerLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsProducers.tblProducerLocationsRowChangeEvent((dsProducers.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducerLocationsRowChangeEventHandler rowChangingEvent = this.tblProducerLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.tblProducerLocationsRowChangeEvent((dsProducers.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducerLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblProducerLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsProducers.tblProducerLocationsRowChangeEvent((dsProducers.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducerLocationsRowChangeEventHandler rowDeletingEvent = this.tblProducerLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.tblProducerLocationsRowChangeEvent((dsProducers.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblProducerLocationsRow(dsProducers.tblProducerLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class tblProducerCallReportDataTable : TypedTableBase<dsProducers.tblProducerCallReportRow>
  {
    private DataColumn columnCallReportID;
    private DataColumn columnDateOfVisit;
    private DataColumn columnCallType;
    private DataColumn columnLeadContact;
    private DataColumn columnProducerLocationID;
    private DataColumn columnProducerLocationGuid;

    private void tblProducerCallReportDataTable_ColumnChanging(
      object sender,
      DataColumnChangeEventArgs e)
    {
      Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Column.ColumnName, this.CallReportIDColumn.ColumnName, false);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblProducerCallReportDataTable()
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.tblProducerCallReportDataTable_ColumnChanging);
      this.TableName = "tblProducerCallReport";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblProducerCallReportDataTable(DataTable table)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.tblProducerCallReportDataTable_ColumnChanging);
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
    protected tblProducerCallReportDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.tblProducerCallReportDataTable_ColumnChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CallReportIDColumn => this.columnCallReportID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateOfVisitColumn => this.columnDateOfVisit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CallTypeColumn => this.columnCallType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LeadContactColumn => this.columnLeadContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerLocationIDColumn => this.columnProducerLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerLocationGuidColumn => this.columnProducerLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerCallReportRow this[int index]
    {
      get => (dsProducers.tblProducerCallReportRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducerCallReportRowChangeEventHandler tblProducerCallReportRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducerCallReportRowChangeEventHandler tblProducerCallReportRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducerCallReportRowChangeEventHandler tblProducerCallReportRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducerCallReportRowChangeEventHandler tblProducerCallReportRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblProducerCallReportRow(dsProducers.tblProducerCallReportRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerCallReportRow AddtblProducerCallReportRow(
      DateTime DateOfVisit,
      string CallType,
      string LeadContact,
      int ProducerLocationID,
      Guid ProducerLocationGuid)
    {
      dsProducers.tblProducerCallReportRow row = (dsProducers.tblProducerCallReportRow) this.NewRow();
      object[] objArray = new object[6]
      {
        null,
        (object) DateOfVisit,
        (object) CallType,
        (object) LeadContact,
        (object) ProducerLocationID,
        (object) ProducerLocationGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerCallReportRow FindByCallReportID(int CallReportID)
    {
      return (dsProducers.tblProducerCallReportRow) this.Rows.Find(new object[1]
      {
        (object) CallReportID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.tblProducerCallReportDataTable callReportDataTable = (dsProducers.tblProducerCallReportDataTable) base.Clone();
      callReportDataTable.InitVars();
      return (DataTable) callReportDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.tblProducerCallReportDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCallReportID = this.Columns["CallReportID"];
      this.columnDateOfVisit = this.Columns["DateOfVisit"];
      this.columnCallType = this.Columns["CallType"];
      this.columnLeadContact = this.Columns["LeadContact"];
      this.columnProducerLocationID = this.Columns["ProducerLocationID"];
      this.columnProducerLocationGuid = this.Columns["ProducerLocationGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCallReportID = new DataColumn("CallReportID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCallReportID);
      this.columnDateOfVisit = new DataColumn("DateOfVisit", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateOfVisit);
      this.columnCallType = new DataColumn("CallType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCallType);
      this.columnLeadContact = new DataColumn("LeadContact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLeadContact);
      this.columnProducerLocationID = new DataColumn("ProducerLocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationID);
      this.columnProducerLocationGuid = new DataColumn("ProducerLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCallReportID
      }, true));
      this.columnCallReportID.AutoIncrement = true;
      this.columnCallReportID.AutoIncrementSeed = -1L;
      this.columnCallReportID.AutoIncrementStep = -1L;
      this.columnCallReportID.AllowDBNull = false;
      this.columnCallReportID.ReadOnly = true;
      this.columnCallReportID.Unique = true;
      this.columnLeadContact.Caption = "LeadContactID";
      this.columnProducerLocationID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerCallReportRow NewtblProducerCallReportRow()
    {
      return (dsProducers.tblProducerCallReportRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.tblProducerCallReportRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.tblProducerCallReportRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerCallReportRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducerCallReportRowChangeEventHandler reportRowChangedEvent = this.tblProducerCallReportRowChangedEvent;
      if (reportRowChangedEvent == null)
        return;
      reportRowChangedEvent((object) this, new dsProducers.tblProducerCallReportRowChangeEvent((dsProducers.tblProducerCallReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerCallReportRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducerCallReportRowChangeEventHandler rowChangingEvent = this.tblProducerCallReportRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.tblProducerCallReportRowChangeEvent((dsProducers.tblProducerCallReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerCallReportRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducerCallReportRowChangeEventHandler reportRowDeletedEvent = this.tblProducerCallReportRowDeletedEvent;
      if (reportRowDeletedEvent == null)
        return;
      reportRowDeletedEvent((object) this, new dsProducers.tblProducerCallReportRowChangeEvent((dsProducers.tblProducerCallReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerCallReportRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducerCallReportRowChangeEventHandler rowDeletingEvent = this.tblProducerCallReportRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.tblProducerCallReportRowChangeEvent((dsProducers.tblProducerCallReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblProducerCallReportRow(dsProducers.tblProducerCallReportRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerCallReportDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstProducerTypesRowChangeEventHandler(
    object sender,
    dsProducers.lstProducerTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstDeliveryMethodRowChangeEventHandler(
    object sender,
    dsProducers.lstDeliveryMethodRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblProducerContactsRowChangeEventHandler(
    object sender,
    dsProducers.tblProducerContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblProducerLocationsRowChangeEventHandler(
    object sender,
    dsProducers.tblProducerLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstStatusRowChangeEventHandler(
    object sender,
    dsProducers.lstStatusRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstLocationTypeRowChangeEventHandler(
    object sender,
    dsProducers.lstLocationTypeRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstProducerBusinessTypesRowChangeEventHandler(
    object sender,
    dsProducers.lstProducerBusinessTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblProducersRowChangeEventHandler(
    object sender,
    dsProducers.tblProducersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void CompanyLinesRowChangeEventHandler(
    object sender,
    dsProducers.CompanyLinesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstProducerLocationRegionsRowChangeEventHandler(
    object sender,
    dsProducers.lstProducerLocationRegionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstProducerLocationSourceRowChangeEventHandler(
    object sender,
    dsProducers.lstProducerLocationSourceRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstProductionPotentialRowChangeEventHandler(
    object sender,
    dsProducers.lstProductionPotentialRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblUsersRowChangeEventHandler(
    object sender,
    dsProducers.tblUsersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblProducerCallReportRowChangeEventHandler(
    object sender,
    dsProducers.tblProducerCallReportRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstProducerRankingsRowChangeEventHandler(
    object sender,
    dsProducers.lstProducerRankingsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstPaymentMethodsRowChangeEventHandler(
    object sender,
    dsProducers.lstPaymentMethodsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstProducersRowChangeEventHandler(
    object sender,
    dsProducers.lstProducersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstProducerStatusReasonsRowChangeEventHandler(
    object sender,
    dsProducers.lstProducerStatusReasonsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstProducerTypesDataTable : TypedTableBase<dsProducers.lstProducerTypesRow>
  {
    private DataColumn columnProducerTypeID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProducerTypesDataTable()
    {
      this.TableName = "lstProducerTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProducerTypesDataTable(DataTable table)
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
    protected lstProducerTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerTypeIDColumn => this.columnProducerTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerTypesRow this[int index]
    {
      get => (dsProducers.lstProducerTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerTypesRowChangeEventHandler lstProducerTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerTypesRowChangeEventHandler lstProducerTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerTypesRowChangeEventHandler lstProducerTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerTypesRowChangeEventHandler lstProducerTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstProducerTypesRow(dsProducers.lstProducerTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerTypesRow AddlstProducerTypesRow(string Description)
    {
      dsProducers.lstProducerTypesRow row = (dsProducers.lstProducerTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerTypesRow FindByProducerTypeID(int ProducerTypeID)
    {
      return (dsProducers.lstProducerTypesRow) this.Rows.Find(new object[1]
      {
        (object) ProducerTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.lstProducerTypesDataTable producerTypesDataTable = (dsProducers.lstProducerTypesDataTable) base.Clone();
      producerTypesDataTable.InitVars();
      return (DataTable) producerTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.lstProducerTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerTypeID = this.Columns["ProducerTypeID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnProducerTypeID = new DataColumn("ProducerTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerTypeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducersKey2", new DataColumn[1]
      {
        this.columnProducerTypeID
      }, true));
      this.columnProducerTypeID.AutoIncrement = true;
      this.columnProducerTypeID.AllowDBNull = false;
      this.columnProducerTypeID.ReadOnly = true;
      this.columnProducerTypeID.Unique = true;
      this.columnDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerTypesRow NewlstProducerTypesRow()
    {
      return (dsProducers.lstProducerTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.lstProducerTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.lstProducerTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerTypesRowChangeEventHandler typesRowChangedEvent = this.lstProducerTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsProducers.lstProducerTypesRowChangeEvent((dsProducers.lstProducerTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerTypesRowChangeEventHandler rowChangingEvent = this.lstProducerTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.lstProducerTypesRowChangeEvent((dsProducers.lstProducerTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerTypesRowChangeEventHandler typesRowDeletedEvent = this.lstProducerTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsProducers.lstProducerTypesRowChangeEvent((dsProducers.lstProducerTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerTypesRowChangeEventHandler rowDeletingEvent = this.lstProducerTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.lstProducerTypesRowChangeEvent((dsProducers.lstProducerTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstProducerTypesRow(dsProducers.lstProducerTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstProducerTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class lstDeliveryMethodDataTable : TypedTableBase<dsProducers.lstDeliveryMethodRow>
  {
    private DataColumn columnDeliveryMethodID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstDeliveryMethodDataTable()
    {
      this.TableName = "lstDeliveryMethod";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstDeliveryMethodDataTable(DataTable table)
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
    protected lstDeliveryMethodDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DeliveryMethodIDColumn => this.columnDeliveryMethodID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstDeliveryMethodRow this[int index]
    {
      get => (dsProducers.lstDeliveryMethodRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstDeliveryMethodRow(dsProducers.lstDeliveryMethodRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstDeliveryMethodRow AddlstDeliveryMethodRow(string Description)
    {
      dsProducers.lstDeliveryMethodRow row = (dsProducers.lstDeliveryMethodRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstDeliveryMethodRow FindByDeliveryMethodID(int DeliveryMethodID)
    {
      return (dsProducers.lstDeliveryMethodRow) this.Rows.Find(new object[1]
      {
        (object) DeliveryMethodID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.lstDeliveryMethodDataTable deliveryMethodDataTable = (dsProducers.lstDeliveryMethodDataTable) base.Clone();
      deliveryMethodDataTable.InitVars();
      return (DataTable) deliveryMethodDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.lstDeliveryMethodDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnDeliveryMethodID = this.Columns["DeliveryMethodID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnDeliveryMethodID = new DataColumn("DeliveryMethodID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryMethodID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducersKey1", new DataColumn[1]
      {
        this.columnDeliveryMethodID
      }, true));
      this.columnDeliveryMethodID.AutoIncrement = true;
      this.columnDeliveryMethodID.AllowDBNull = false;
      this.columnDeliveryMethodID.ReadOnly = true;
      this.columnDeliveryMethodID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstDeliveryMethodRow NewlstDeliveryMethodRow()
    {
      return (dsProducers.lstDeliveryMethodRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.lstDeliveryMethodRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.lstDeliveryMethodRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstDeliveryMethodRowChangeEventHandler methodRowChangedEvent = this.lstDeliveryMethodRowChangedEvent;
      if (methodRowChangedEvent == null)
        return;
      methodRowChangedEvent((object) this, new dsProducers.lstDeliveryMethodRowChangeEvent((dsProducers.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstDeliveryMethodRowChangeEventHandler rowChangingEvent = this.lstDeliveryMethodRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.lstDeliveryMethodRowChangeEvent((dsProducers.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstDeliveryMethodRowChangeEventHandler methodRowDeletedEvent = this.lstDeliveryMethodRowDeletedEvent;
      if (methodRowDeletedEvent == null)
        return;
      methodRowDeletedEvent((object) this, new dsProducers.lstDeliveryMethodRowChangeEvent((dsProducers.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstDeliveryMethodRowChangeEventHandler rowDeletingEvent = this.lstDeliveryMethodRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.lstDeliveryMethodRowChangeEvent((dsProducers.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstDeliveryMethodRow(dsProducers.lstDeliveryMethodRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstDeliveryMethodDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class tblProducerContactsDataTable : TypedTableBase<dsProducers.tblProducerContactsRow>
  {
    private DataColumn columnProducerContactGUID;
    private DataColumn columnProducerLocationGUID;
    private DataColumn columnName;
    private DataColumn columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblProducerContactsDataTable()
    {
      this.TableName = "tblProducerContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblProducerContactsDataTable(DataTable table)
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
    protected tblProducerContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerContactGUIDColumn => this.columnProducerContactGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerLocationGUIDColumn => this.columnProducerLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerContactsRow this[int index]
    {
      get => (dsProducers.tblProducerContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducerContactsRowChangeEventHandler tblProducerContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducerContactsRowChangeEventHandler tblProducerContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducerContactsRowChangeEventHandler tblProducerContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducerContactsRowChangeEventHandler tblProducerContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblProducerContactsRow(dsProducers.tblProducerContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerContactsRow AddtblProducerContactsRow(
      Guid ProducerContactGUID,
      dsProducers.tblProducerLocationsRow parenttblProducerLocationsRowBytblProducerLocationstblProducerContacts,
      string Name,
      int StatusID)
    {
      dsProducers.tblProducerContactsRow row = (dsProducers.tblProducerContactsRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) ProducerContactGUID,
        null,
        (object) Name,
        (object) StatusID
      };
      if (parenttblProducerLocationsRowBytblProducerLocationstblProducerContacts != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblProducerLocationsRowBytblProducerLocationstblProducerContacts[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerContactsRow FindByProducerContactGUID(Guid ProducerContactGUID)
    {
      return (dsProducers.tblProducerContactsRow) this.Rows.Find(new object[1]
      {
        (object) ProducerContactGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.tblProducerContactsDataTable contactsDataTable = (dsProducers.tblProducerContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.tblProducerContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerContactGUID = this.Columns["ProducerContactGUID"];
      this.columnProducerLocationGUID = this.Columns["ProducerLocationGUID"];
      this.columnName = this.Columns["Name"];
      this.columnStatusID = this.Columns["StatusID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnProducerContactGUID = new DataColumn("ProducerContactGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContactGUID);
      this.columnProducerLocationGUID = new DataColumn("ProducerLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGUID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducersKey3", new DataColumn[1]
      {
        this.columnProducerContactGUID
      }, true));
      this.columnProducerContactGUID.AllowDBNull = false;
      this.columnProducerContactGUID.Unique = true;
      this.columnStatusID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerContactsRow NewtblProducerContactsRow()
    {
      return (dsProducers.tblProducerContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.tblProducerContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.tblProducerContactsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducerContactsRowChangeEventHandler contactsRowChangedEvent = this.tblProducerContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsProducers.tblProducerContactsRowChangeEvent((dsProducers.tblProducerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducerContactsRowChangeEventHandler rowChangingEvent = this.tblProducerContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.tblProducerContactsRowChangeEvent((dsProducers.tblProducerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducerContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblProducerContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsProducers.tblProducerContactsRowChangeEvent((dsProducers.tblProducerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducerContactsRowChangeEventHandler rowDeletingEvent = this.tblProducerContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.tblProducerContactsRowChangeEvent((dsProducers.tblProducerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblProducerContactsRow(dsProducers.tblProducerContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class lstStatusDataTable : TypedTableBase<dsProducers.lstStatusRow>
  {
    private DataColumn columnStatusID;
    private DataColumn columnStatus;
    private DataColumn columnDisable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstStatusDataTable()
    {
      this.TableName = "lstStatus";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstStatusDataTable(DataTable table)
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
    protected lstStatusDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DisableColumn => this.columnDisable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstStatusRow this[int index] => (dsProducers.lstStatusRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstStatusRowChangeEventHandler lstStatusRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstStatusRowChangeEventHandler lstStatusRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstStatusRowChangeEventHandler lstStatusRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstStatusRowChangeEventHandler lstStatusRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstStatusRow(dsProducers.lstStatusRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstStatusRow AddlstStatusRow(string Status, bool Disable)
    {
      dsProducers.lstStatusRow row = (dsProducers.lstStatusRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) Status,
        (object) Disable
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstStatusRow FindByStatusID(int StatusID)
    {
      return (dsProducers.lstStatusRow) this.Rows.Find(new object[1]
      {
        (object) StatusID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.lstStatusDataTable lstStatusDataTable = (dsProducers.lstStatusDataTable) base.Clone();
      lstStatusDataTable.InitVars();
      return (DataTable) lstStatusDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.lstStatusDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnStatusID = this.Columns["StatusID"];
      this.columnStatus = this.Columns["Status"];
      this.columnDisable = this.Columns["Disable"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnDisable = new DataColumn("Disable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisable);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducersKey9", new DataColumn[1]
      {
        this.columnStatusID
      }, true));
      this.columnStatusID.AutoIncrement = true;
      this.columnStatusID.AllowDBNull = false;
      this.columnStatusID.ReadOnly = true;
      this.columnStatusID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstStatusRow NewlstStatusRow() => (dsProducers.lstStatusRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.lstStatusRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.lstStatusRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstStatusRowChangeEventHandler statusRowChangedEvent = this.lstStatusRowChangedEvent;
      if (statusRowChangedEvent == null)
        return;
      statusRowChangedEvent((object) this, new dsProducers.lstStatusRowChangeEvent((dsProducers.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstStatusRowChangeEventHandler rowChangingEvent = this.lstStatusRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.lstStatusRowChangeEvent((dsProducers.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstStatusRowChangeEventHandler statusRowDeletedEvent = this.lstStatusRowDeletedEvent;
      if (statusRowDeletedEvent == null)
        return;
      statusRowDeletedEvent((object) this, new dsProducers.lstStatusRowChangeEvent((dsProducers.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstStatusRowChangeEventHandler rowDeletingEvent = this.lstStatusRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.lstStatusRowChangeEvent((dsProducers.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstStatusRow(dsProducers.lstStatusRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatusDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class lstLocationTypeDataTable : TypedTableBase<dsProducers.lstLocationTypeRow>
  {
    private DataColumn columnLocationTypeID;
    private DataColumn columnLocationType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstLocationTypeDataTable()
    {
      this.TableName = "lstLocationType";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstLocationTypeDataTable(DataTable table)
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
    protected lstLocationTypeDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationTypeIDColumn => this.columnLocationTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationTypeColumn => this.columnLocationType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstLocationTypeRow this[int index]
    {
      get => (dsProducers.lstLocationTypeRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstLocationTypeRowChangeEventHandler lstLocationTypeRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstLocationTypeRowChangeEventHandler lstLocationTypeRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstLocationTypeRowChangeEventHandler lstLocationTypeRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstLocationTypeRowChangeEventHandler lstLocationTypeRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstLocationTypeRow(dsProducers.lstLocationTypeRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstLocationTypeRow AddlstLocationTypeRow(string LocationType)
    {
      dsProducers.lstLocationTypeRow row = (dsProducers.lstLocationTypeRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) LocationType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstLocationTypeRow FindByLocationTypeID(int LocationTypeID)
    {
      return (dsProducers.lstLocationTypeRow) this.Rows.Find(new object[1]
      {
        (object) LocationTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.lstLocationTypeDataTable locationTypeDataTable = (dsProducers.lstLocationTypeDataTable) base.Clone();
      locationTypeDataTable.InitVars();
      return (DataTable) locationTypeDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.lstLocationTypeDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnLocationTypeID = this.Columns["LocationTypeID"];
      this.columnLocationType = this.Columns["LocationType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnLocationTypeID = new DataColumn("LocationTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationTypeID);
      this.columnLocationType = new DataColumn("LocationType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducersKey10", new DataColumn[1]
      {
        this.columnLocationTypeID
      }, true));
      this.columnLocationTypeID.AutoIncrement = true;
      this.columnLocationTypeID.AllowDBNull = false;
      this.columnLocationTypeID.ReadOnly = true;
      this.columnLocationTypeID.Unique = true;
      this.columnLocationType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstLocationTypeRow NewlstLocationTypeRow()
    {
      return (dsProducers.lstLocationTypeRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.lstLocationTypeRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.lstLocationTypeRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLocationTypeRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstLocationTypeRowChangeEventHandler typeRowChangedEvent = this.lstLocationTypeRowChangedEvent;
      if (typeRowChangedEvent == null)
        return;
      typeRowChangedEvent((object) this, new dsProducers.lstLocationTypeRowChangeEvent((dsProducers.lstLocationTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLocationTypeRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstLocationTypeRowChangeEventHandler rowChangingEvent = this.lstLocationTypeRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.lstLocationTypeRowChangeEvent((dsProducers.lstLocationTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLocationTypeRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstLocationTypeRowChangeEventHandler typeRowDeletedEvent = this.lstLocationTypeRowDeletedEvent;
      if (typeRowDeletedEvent == null)
        return;
      typeRowDeletedEvent((object) this, new dsProducers.lstLocationTypeRowChangeEvent((dsProducers.lstLocationTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLocationTypeRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstLocationTypeRowChangeEventHandler rowDeletingEvent = this.lstLocationTypeRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.lstLocationTypeRowChangeEvent((dsProducers.lstLocationTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstLocationTypeRow(dsProducers.lstLocationTypeRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstLocationTypeDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class lstProducerBusinessTypesDataTable : 
    TypedTableBase<dsProducers.lstProducerBusinessTypesRow>
  {
    private DataColumn columnBusinessTypeID;
    private DataColumn columnBusinessType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProducerBusinessTypesDataTable()
    {
      this.TableName = "lstProducerBusinessTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProducerBusinessTypesDataTable(DataTable table)
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
    protected lstProducerBusinessTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BusinessTypeIDColumn => this.columnBusinessTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BusinessTypeColumn => this.columnBusinessType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerBusinessTypesRow this[int index]
    {
      get => (dsProducers.lstProducerBusinessTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerBusinessTypesRowChangeEventHandler lstProducerBusinessTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerBusinessTypesRowChangeEventHandler lstProducerBusinessTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerBusinessTypesRowChangeEventHandler lstProducerBusinessTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerBusinessTypesRowChangeEventHandler lstProducerBusinessTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstProducerBusinessTypesRow(dsProducers.lstProducerBusinessTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerBusinessTypesRow AddlstProducerBusinessTypesRow(
      string BusinessType)
    {
      dsProducers.lstProducerBusinessTypesRow row = (dsProducers.lstProducerBusinessTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) BusinessType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerBusinessTypesRow FindByBusinessTypeID(int BusinessTypeID)
    {
      return (dsProducers.lstProducerBusinessTypesRow) this.Rows.Find(new object[1]
      {
        (object) BusinessTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.lstProducerBusinessTypesDataTable businessTypesDataTable = (dsProducers.lstProducerBusinessTypesDataTable) base.Clone();
      businessTypesDataTable.InitVars();
      return (DataTable) businessTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.lstProducerBusinessTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnBusinessTypeID = this.Columns["BusinessTypeID"];
      this.columnBusinessType = this.Columns["BusinessType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnBusinessTypeID = new DataColumn("BusinessTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBusinessTypeID);
      this.columnBusinessType = new DataColumn("BusinessType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBusinessType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducersKey8", new DataColumn[1]
      {
        this.columnBusinessTypeID
      }, true));
      this.columnBusinessTypeID.AutoIncrement = true;
      this.columnBusinessTypeID.AllowDBNull = false;
      this.columnBusinessTypeID.ReadOnly = true;
      this.columnBusinessTypeID.Unique = true;
      this.columnBusinessType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerBusinessTypesRow NewlstProducerBusinessTypesRow()
    {
      return (dsProducers.lstProducerBusinessTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.lstProducerBusinessTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.lstProducerBusinessTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerBusinessTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerBusinessTypesRowChangeEventHandler typesRowChangedEvent = this.lstProducerBusinessTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsProducers.lstProducerBusinessTypesRowChangeEvent((dsProducers.lstProducerBusinessTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerBusinessTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerBusinessTypesRowChangeEventHandler rowChangingEvent = this.lstProducerBusinessTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.lstProducerBusinessTypesRowChangeEvent((dsProducers.lstProducerBusinessTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerBusinessTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerBusinessTypesRowChangeEventHandler typesRowDeletedEvent = this.lstProducerBusinessTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsProducers.lstProducerBusinessTypesRowChangeEvent((dsProducers.lstProducerBusinessTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerBusinessTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerBusinessTypesRowChangeEventHandler rowDeletingEvent = this.lstProducerBusinessTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.lstProducerBusinessTypesRowChangeEvent((dsProducers.lstProducerBusinessTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstProducerBusinessTypesRow(dsProducers.lstProducerBusinessTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstProducerBusinessTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class tblProducersDataTable : TypedTableBase<dsProducers.tblProducersRow>
  {
    private DataColumn columnProducerGUID;
    private DataColumn columnProducerCode;
    private DataColumn columnProducerName;
    private DataColumn columnClosed;
    private DataColumn columnProducerBusinessTypeID;
    private DataColumn columnLogo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblProducersDataTable()
    {
      this.TableName = "tblProducers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblProducersDataTable(DataTable table)
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
    protected tblProducersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerGUIDColumn => this.columnProducerGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerCodeColumn => this.columnProducerCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerNameColumn => this.columnProducerName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClosedColumn => this.columnClosed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerBusinessTypeIDColumn => this.columnProducerBusinessTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LogoColumn => this.columnLogo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducersRow this[int index]
    {
      get => (dsProducers.tblProducersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducersRowChangeEventHandler tblProducersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducersRowChangeEventHandler tblProducersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducersRowChangeEventHandler tblProducersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblProducersRowChangeEventHandler tblProducersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblProducersRow(dsProducers.tblProducersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducersRow AddtblProducersRow(
      Guid ProducerGUID,
      int ProducerCode,
      string ProducerName,
      bool Closed,
      dsProducers.lstProducerBusinessTypesRow parentlstProducerBusinessTypesRowBylstProducerBusinessTypestblProducers,
      byte[] Logo)
    {
      dsProducers.tblProducersRow row = (dsProducers.tblProducersRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) ProducerGUID,
        (object) ProducerCode,
        (object) ProducerName,
        (object) Closed,
        null,
        (object) Logo
      };
      if (parentlstProducerBusinessTypesRowBylstProducerBusinessTypestblProducers != null)
        objArray[4] = RuntimeHelpers.GetObjectValue(parentlstProducerBusinessTypesRowBylstProducerBusinessTypestblProducers[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducersRow FindByProducerGUID(Guid ProducerGUID)
    {
      return (dsProducers.tblProducersRow) this.Rows.Find(new object[1]
      {
        (object) ProducerGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.tblProducersDataTable producersDataTable = (dsProducers.tblProducersDataTable) base.Clone();
      producersDataTable.InitVars();
      return (DataTable) producersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.tblProducersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerGUID = this.Columns["ProducerGUID"];
      this.columnProducerCode = this.Columns["ProducerCode"];
      this.columnProducerName = this.Columns["ProducerName"];
      this.columnClosed = this.Columns["Closed"];
      this.columnProducerBusinessTypeID = this.Columns["ProducerBusinessTypeID"];
      this.columnLogo = this.Columns["Logo"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnProducerGUID = new DataColumn("ProducerGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerGUID);
      this.columnProducerCode = new DataColumn("ProducerCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerCode);
      this.columnProducerName = new DataColumn("ProducerName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerName);
      this.columnClosed = new DataColumn("Closed", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClosed);
      this.columnProducerBusinessTypeID = new DataColumn("ProducerBusinessTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerBusinessTypeID);
      this.columnLogo = new DataColumn("Logo", typeof (byte[]), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLogo);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducersKey4", new DataColumn[1]
      {
        this.columnProducerGUID
      }, true));
      this.columnProducerGUID.AllowDBNull = false;
      this.columnProducerGUID.Unique = true;
      this.columnProducerCode.AllowDBNull = false;
      this.columnProducerCode.ReadOnly = true;
      this.columnClosed.AllowDBNull = false;
      this.columnClosed.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducersRow NewtblProducersRow()
    {
      return (dsProducers.tblProducersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.tblProducersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.tblProducersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducersRowChangeEventHandler producersRowChangedEvent = this.tblProducersRowChangedEvent;
      if (producersRowChangedEvent == null)
        return;
      producersRowChangedEvent((object) this, new dsProducers.tblProducersRowChangeEvent((dsProducers.tblProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducersRowChangeEventHandler rowChangingEvent = this.tblProducersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.tblProducersRowChangeEvent((dsProducers.tblProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducersRowChangeEventHandler producersRowDeletedEvent = this.tblProducersRowDeletedEvent;
      if (producersRowDeletedEvent == null)
        return;
      producersRowDeletedEvent((object) this, new dsProducers.tblProducersRowChangeEvent((dsProducers.tblProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblProducersRowChangeEventHandler rowDeletingEvent = this.tblProducersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.tblProducersRowChangeEvent((dsProducers.tblProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblProducersRow(dsProducers.tblProducersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class CompanyLinesDataTable : TypedTableBase<dsProducers.CompanyLinesRow>
  {
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnCompanyLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public CompanyLinesDataTable()
    {
      this.TableName = "CompanyLines";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal CompanyLinesDataTable(DataTable table)
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
    protected CompanyLinesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineColumn => this.columnCompanyLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.CompanyLinesRow this[int index]
    {
      get => (dsProducers.CompanyLinesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.CompanyLinesRowChangeEventHandler CompanyLinesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.CompanyLinesRowChangeEventHandler CompanyLinesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.CompanyLinesRowChangeEventHandler CompanyLinesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.CompanyLinesRowChangeEventHandler CompanyLinesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddCompanyLinesRow(dsProducers.CompanyLinesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.CompanyLinesRow AddCompanyLinesRow(Guid CompanyLineGuid, string CompanyLine)
    {
      dsProducers.CompanyLinesRow row = (dsProducers.CompanyLinesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyLineGuid,
        (object) CompanyLine
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.CompanyLinesRow FindByCompanyLineGuid(Guid CompanyLineGuid)
    {
      return (dsProducers.CompanyLinesRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLineGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.CompanyLinesDataTable companyLinesDataTable = (dsProducers.CompanyLinesDataTable) base.Clone();
      companyLinesDataTable.InitVars();
      return (DataTable) companyLinesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.CompanyLinesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnCompanyLine = this.Columns["CompanyLine"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnCompanyLine = new DataColumn("CompanyLine", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLine);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducersKey11", new DataColumn[1]
      {
        this.columnCompanyLineGuid
      }, true));
      this.columnCompanyLineGuid.AllowDBNull = false;
      this.columnCompanyLineGuid.Unique = true;
      this.columnCompanyLine.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.CompanyLinesRow NewCompanyLinesRow()
    {
      return (dsProducers.CompanyLinesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.CompanyLinesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.CompanyLinesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CompanyLinesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.CompanyLinesRowChangeEventHandler linesRowChangedEvent = this.CompanyLinesRowChangedEvent;
      if (linesRowChangedEvent == null)
        return;
      linesRowChangedEvent((object) this, new dsProducers.CompanyLinesRowChangeEvent((dsProducers.CompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CompanyLinesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.CompanyLinesRowChangeEventHandler rowChangingEvent = this.CompanyLinesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.CompanyLinesRowChangeEvent((dsProducers.CompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CompanyLinesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.CompanyLinesRowChangeEventHandler linesRowDeletedEvent = this.CompanyLinesRowDeletedEvent;
      if (linesRowDeletedEvent == null)
        return;
      linesRowDeletedEvent((object) this, new dsProducers.CompanyLinesRowChangeEvent((dsProducers.CompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CompanyLinesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.CompanyLinesRowChangeEventHandler rowDeletingEvent = this.CompanyLinesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.CompanyLinesRowChangeEvent((dsProducers.CompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveCompanyLinesRow(dsProducers.CompanyLinesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CompanyLinesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class lstProducerLocationRegionsDataTable : 
    TypedTableBase<dsProducers.lstProducerLocationRegionsRow>
  {
    private DataColumn columnID;
    private DataColumn columnProducerRegion;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProducerLocationRegionsDataTable()
    {
      this.TableName = "lstProducerLocationRegions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProducerLocationRegionsDataTable(DataTable table)
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
    protected lstProducerLocationRegionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerRegionColumn => this.columnProducerRegion;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerLocationRegionsRow this[int index]
    {
      get => (dsProducers.lstProducerLocationRegionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerLocationRegionsRowChangeEventHandler lstProducerLocationRegionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerLocationRegionsRowChangeEventHandler lstProducerLocationRegionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerLocationRegionsRowChangeEventHandler lstProducerLocationRegionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerLocationRegionsRowChangeEventHandler lstProducerLocationRegionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstProducerLocationRegionsRow(dsProducers.lstProducerLocationRegionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerLocationRegionsRow AddlstProducerLocationRegionsRow(
      string ProducerRegion)
    {
      dsProducers.lstProducerLocationRegionsRow row = (dsProducers.lstProducerLocationRegionsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) ProducerRegion
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerLocationRegionsRow FindByID(Decimal ID)
    {
      return (dsProducers.lstProducerLocationRegionsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.lstProducerLocationRegionsDataTable regionsDataTable = (dsProducers.lstProducerLocationRegionsDataTable) base.Clone();
      regionsDataTable.InitVars();
      return (DataTable) regionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.lstProducerLocationRegionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnProducerRegion = this.Columns["ProducerRegion"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnProducerRegion = new DataColumn("ProducerRegion", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerRegion);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducersKey12", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnProducerRegion.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerLocationRegionsRow NewlstProducerLocationRegionsRow()
    {
      return (dsProducers.lstProducerLocationRegionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.lstProducerLocationRegionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.lstProducerLocationRegionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerLocationRegionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerLocationRegionsRowChangeEventHandler regionsRowChangedEvent = this.lstProducerLocationRegionsRowChangedEvent;
      if (regionsRowChangedEvent == null)
        return;
      regionsRowChangedEvent((object) this, new dsProducers.lstProducerLocationRegionsRowChangeEvent((dsProducers.lstProducerLocationRegionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerLocationRegionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerLocationRegionsRowChangeEventHandler rowChangingEvent = this.lstProducerLocationRegionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.lstProducerLocationRegionsRowChangeEvent((dsProducers.lstProducerLocationRegionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerLocationRegionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerLocationRegionsRowChangeEventHandler regionsRowDeletedEvent = this.lstProducerLocationRegionsRowDeletedEvent;
      if (regionsRowDeletedEvent == null)
        return;
      regionsRowDeletedEvent((object) this, new dsProducers.lstProducerLocationRegionsRowChangeEvent((dsProducers.lstProducerLocationRegionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerLocationRegionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerLocationRegionsRowChangeEventHandler rowDeletingEvent = this.lstProducerLocationRegionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.lstProducerLocationRegionsRowChangeEvent((dsProducers.lstProducerLocationRegionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstProducerLocationRegionsRow(dsProducers.lstProducerLocationRegionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstProducerLocationRegionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class lstProducerLocationSourceDataTable : 
    TypedTableBase<dsProducers.lstProducerLocationSourceRow>
  {
    private DataColumn columnID;
    private DataColumn columnSource;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProducerLocationSourceDataTable()
    {
      this.TableName = "lstProducerLocationSource";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProducerLocationSourceDataTable(DataTable table)
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
    protected lstProducerLocationSourceDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SourceColumn => this.columnSource;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerLocationSourceRow this[int index]
    {
      get => (dsProducers.lstProducerLocationSourceRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerLocationSourceRowChangeEventHandler lstProducerLocationSourceRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerLocationSourceRowChangeEventHandler lstProducerLocationSourceRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerLocationSourceRowChangeEventHandler lstProducerLocationSourceRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerLocationSourceRowChangeEventHandler lstProducerLocationSourceRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstProducerLocationSourceRow(dsProducers.lstProducerLocationSourceRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerLocationSourceRow AddlstProducerLocationSourceRow(
      byte ID,
      string Source)
    {
      dsProducers.lstProducerLocationSourceRow row = (dsProducers.lstProducerLocationSourceRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) Source
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerLocationSourceRow FindByID(byte ID)
    {
      return (dsProducers.lstProducerLocationSourceRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.lstProducerLocationSourceDataTable locationSourceDataTable = (dsProducers.lstProducerLocationSourceDataTable) base.Clone();
      locationSourceDataTable.InitVars();
      return (DataTable) locationSourceDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.lstProducerLocationSourceDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnSource = this.Columns["Source"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnSource = new DataColumn("Source", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSource);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.Unique = true;
      this.columnSource.AllowDBNull = false;
      this.columnSource.MaxLength = 100;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerLocationSourceRow NewlstProducerLocationSourceRow()
    {
      return (dsProducers.lstProducerLocationSourceRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.lstProducerLocationSourceRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.lstProducerLocationSourceRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerLocationSourceRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerLocationSourceRowChangeEventHandler sourceRowChangedEvent = this.lstProducerLocationSourceRowChangedEvent;
      if (sourceRowChangedEvent == null)
        return;
      sourceRowChangedEvent((object) this, new dsProducers.lstProducerLocationSourceRowChangeEvent((dsProducers.lstProducerLocationSourceRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerLocationSourceRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerLocationSourceRowChangeEventHandler rowChangingEvent = this.lstProducerLocationSourceRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.lstProducerLocationSourceRowChangeEvent((dsProducers.lstProducerLocationSourceRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerLocationSourceRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerLocationSourceRowChangeEventHandler sourceRowDeletedEvent = this.lstProducerLocationSourceRowDeletedEvent;
      if (sourceRowDeletedEvent == null)
        return;
      sourceRowDeletedEvent((object) this, new dsProducers.lstProducerLocationSourceRowChangeEvent((dsProducers.lstProducerLocationSourceRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerLocationSourceRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerLocationSourceRowChangeEventHandler rowDeletingEvent = this.lstProducerLocationSourceRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.lstProducerLocationSourceRowChangeEvent((dsProducers.lstProducerLocationSourceRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstProducerLocationSourceRow(dsProducers.lstProducerLocationSourceRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstProducerLocationSourceDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class lstProductionPotentialDataTable : 
    TypedTableBase<dsProducers.lstProductionPotentialRow>
  {
    private DataColumn columnID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProductionPotentialDataTable()
    {
      this.TableName = "lstProductionPotential";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProductionPotentialDataTable(DataTable table)
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
    protected lstProductionPotentialDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProductionPotentialRow this[int index]
    {
      get => (dsProducers.lstProductionPotentialRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProductionPotentialRowChangeEventHandler lstProductionPotentialRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProductionPotentialRowChangeEventHandler lstProductionPotentialRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProductionPotentialRowChangeEventHandler lstProductionPotentialRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProductionPotentialRowChangeEventHandler lstProductionPotentialRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstProductionPotentialRow(dsProducers.lstProductionPotentialRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProductionPotentialRow AddlstProductionPotentialRow(
      string ID,
      string Description)
    {
      dsProducers.lstProductionPotentialRow row = (dsProducers.lstProductionPotentialRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProductionPotentialRow FindByID(string ID)
    {
      return (dsProducers.lstProductionPotentialRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.lstProductionPotentialDataTable potentialDataTable = (dsProducers.lstProductionPotentialDataTable) base.Clone();
      potentialDataTable.InitVars();
      return (DataTable) potentialDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.lstProductionPotentialDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.Unique = true;
      this.columnID.MaxLength = 1;
      this.columnDescription.AllowDBNull = false;
      this.columnDescription.MaxLength = 100;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProductionPotentialRow NewlstProductionPotentialRow()
    {
      return (dsProducers.lstProductionPotentialRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.lstProductionPotentialRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.lstProductionPotentialRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProductionPotentialRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProductionPotentialRowChangeEventHandler potentialRowChangedEvent = this.lstProductionPotentialRowChangedEvent;
      if (potentialRowChangedEvent == null)
        return;
      potentialRowChangedEvent((object) this, new dsProducers.lstProductionPotentialRowChangeEvent((dsProducers.lstProductionPotentialRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProductionPotentialRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProductionPotentialRowChangeEventHandler rowChangingEvent = this.lstProductionPotentialRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.lstProductionPotentialRowChangeEvent((dsProducers.lstProductionPotentialRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProductionPotentialRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProductionPotentialRowChangeEventHandler potentialRowDeletedEvent = this.lstProductionPotentialRowDeletedEvent;
      if (potentialRowDeletedEvent == null)
        return;
      potentialRowDeletedEvent((object) this, new dsProducers.lstProductionPotentialRowChangeEvent((dsProducers.lstProductionPotentialRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProductionPotentialRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProductionPotentialRowChangeEventHandler rowDeletingEvent = this.lstProductionPotentialRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.lstProductionPotentialRowChangeEvent((dsProducers.lstProductionPotentialRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstProductionPotentialRow(dsProducers.lstProductionPotentialRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstProductionPotentialDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class tblUsersDataTable : TypedTableBase<dsProducers.tblUsersRow>
  {
    private DataColumn columnUserGUID;
    private DataColumn columnName_LastFirst;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblUsersDataTable()
    {
      this.TableName = "tblUsers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblUsersDataTable(DataTable table)
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
    protected tblUsersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UserGUIDColumn => this.columnUserGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Name_LastFirstColumn => this.columnName_LastFirst;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblUsersRow this[int index] => (dsProducers.tblUsersRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblUsersRowChangeEventHandler tblUsersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblUsersRowChangeEventHandler tblUsersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblUsersRowChangeEventHandler tblUsersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.tblUsersRowChangeEventHandler tblUsersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblUsersRow(dsProducers.tblUsersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblUsersRow AddtblUsersRow(Guid UserGUID, string Name_LastFirst)
    {
      dsProducers.tblUsersRow row = (dsProducers.tblUsersRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) UserGUID,
        (object) Name_LastFirst
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblUsersRow FindByUserGUID(Guid UserGUID)
    {
      return (dsProducers.tblUsersRow) this.Rows.Find(new object[1]
      {
        (object) UserGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.tblUsersDataTable tblUsersDataTable = (dsProducers.tblUsersDataTable) base.Clone();
      tblUsersDataTable.InitVars();
      return (DataTable) tblUsersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.tblUsersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnUserGUID = this.Columns["UserGUID"];
      this.columnName_LastFirst = this.Columns["Name_LastFirst"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnUserGUID = new DataColumn("UserGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUID);
      this.columnName_LastFirst = new DataColumn("Name_LastFirst", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName_LastFirst);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnUserGUID
      }, true));
      this.columnUserGUID.AllowDBNull = false;
      this.columnUserGUID.Unique = true;
      this.columnName_LastFirst.ReadOnly = true;
      this.columnName_LastFirst.MaxLength = 270;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblUsersRow NewtblUsersRow() => (dsProducers.tblUsersRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.tblUsersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.tblUsersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblUsersRowChangeEventHandler usersRowChangedEvent = this.tblUsersRowChangedEvent;
      if (usersRowChangedEvent == null)
        return;
      usersRowChangedEvent((object) this, new dsProducers.tblUsersRowChangeEvent((dsProducers.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblUsersRowChangeEventHandler rowChangingEvent = this.tblUsersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.tblUsersRowChangeEvent((dsProducers.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblUsersRowChangeEventHandler usersRowDeletedEvent = this.tblUsersRowDeletedEvent;
      if (usersRowDeletedEvent == null)
        return;
      usersRowDeletedEvent((object) this, new dsProducers.tblUsersRowChangeEvent((dsProducers.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.tblUsersRowChangeEventHandler rowDeletingEvent = this.tblUsersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.tblUsersRowChangeEvent((dsProducers.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblUsersRow(dsProducers.tblUsersRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUsersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class lstProducerRankingsDataTable : TypedTableBase<dsProducers.lstProducerRankingsRow>
  {
    private DataColumn columnID;
    private DataColumn columnProducerRanking;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProducerRankingsDataTable()
    {
      this.TableName = "lstProducerRankings";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProducerRankingsDataTable(DataTable table)
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
    protected lstProducerRankingsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerRankingColumn => this.columnProducerRanking;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerRankingsRow this[int index]
    {
      get => (dsProducers.lstProducerRankingsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerRankingsRowChangeEventHandler lstProducerRankingsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerRankingsRowChangeEventHandler lstProducerRankingsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerRankingsRowChangeEventHandler lstProducerRankingsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerRankingsRowChangeEventHandler lstProducerRankingsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstProducerRankingsRow(dsProducers.lstProducerRankingsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerRankingsRow AddlstProducerRankingsRow(string ProducerRanking)
    {
      dsProducers.lstProducerRankingsRow row = (dsProducers.lstProducerRankingsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) ProducerRanking
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerRankingsRow FindByID(int ID)
    {
      return (dsProducers.lstProducerRankingsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.lstProducerRankingsDataTable rankingsDataTable = (dsProducers.lstProducerRankingsDataTable) base.Clone();
      rankingsDataTable.InitVars();
      return (DataTable) rankingsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.lstProducerRankingsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnProducerRanking = this.Columns["ProducerRanking"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnProducerRanking = new DataColumn("ProducerRanking", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerRanking);
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
      this.columnProducerRanking.AllowDBNull = false;
      this.columnProducerRanking.MaxLength = 75;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerRankingsRow NewlstProducerRankingsRow()
    {
      return (dsProducers.lstProducerRankingsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.lstProducerRankingsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.lstProducerRankingsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerRankingsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerRankingsRowChangeEventHandler rankingsRowChangedEvent = this.lstProducerRankingsRowChangedEvent;
      if (rankingsRowChangedEvent == null)
        return;
      rankingsRowChangedEvent((object) this, new dsProducers.lstProducerRankingsRowChangeEvent((dsProducers.lstProducerRankingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerRankingsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerRankingsRowChangeEventHandler rowChangingEvent = this.lstProducerRankingsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.lstProducerRankingsRowChangeEvent((dsProducers.lstProducerRankingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerRankingsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerRankingsRowChangeEventHandler rankingsRowDeletedEvent = this.lstProducerRankingsRowDeletedEvent;
      if (rankingsRowDeletedEvent == null)
        return;
      rankingsRowDeletedEvent((object) this, new dsProducers.lstProducerRankingsRowChangeEvent((dsProducers.lstProducerRankingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerRankingsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerRankingsRowChangeEventHandler rowDeletingEvent = this.lstProducerRankingsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.lstProducerRankingsRowChangeEvent((dsProducers.lstProducerRankingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstProducerRankingsRow(dsProducers.lstProducerRankingsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstProducerRankingsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class lstPaymentMethodsDataTable : TypedTableBase<dsProducers.lstPaymentMethodsRow>
  {
    private DataColumn columnID;
    private DataColumn columnPaymentMethod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstPaymentMethodsDataTable()
    {
      this.TableName = "lstPaymentMethods";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstPaymentMethodsDataTable(DataTable table)
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
    protected lstPaymentMethodsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PaymentMethodColumn => this.columnPaymentMethod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstPaymentMethodsRow this[int index]
    {
      get => (dsProducers.lstPaymentMethodsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstPaymentMethodsRowChangeEventHandler lstPaymentMethodsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstPaymentMethodsRowChangeEventHandler lstPaymentMethodsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstPaymentMethodsRowChangeEventHandler lstPaymentMethodsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstPaymentMethodsRowChangeEventHandler lstPaymentMethodsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstPaymentMethodsRow(dsProducers.lstPaymentMethodsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstPaymentMethodsRow AddlstPaymentMethodsRow(byte ID, string PaymentMethod)
    {
      dsProducers.lstPaymentMethodsRow row = (dsProducers.lstPaymentMethodsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) PaymentMethod
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstPaymentMethodsRow FindByID(byte ID)
    {
      return (dsProducers.lstPaymentMethodsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.lstPaymentMethodsDataTable methodsDataTable = (dsProducers.lstPaymentMethodsDataTable) base.Clone();
      methodsDataTable.InitVars();
      return (DataTable) methodsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.lstPaymentMethodsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnPaymentMethod = this.Columns["PaymentMethod"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnPaymentMethod = new DataColumn("PaymentMethod", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPaymentMethod);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnPaymentMethod.AllowDBNull = false;
      this.columnPaymentMethod.MaxLength = 20;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstPaymentMethodsRow NewlstPaymentMethodsRow()
    {
      return (dsProducers.lstPaymentMethodsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.lstPaymentMethodsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.lstPaymentMethodsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPaymentMethodsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstPaymentMethodsRowChangeEventHandler methodsRowChangedEvent = this.lstPaymentMethodsRowChangedEvent;
      if (methodsRowChangedEvent == null)
        return;
      methodsRowChangedEvent((object) this, new dsProducers.lstPaymentMethodsRowChangeEvent((dsProducers.lstPaymentMethodsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPaymentMethodsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstPaymentMethodsRowChangeEventHandler rowChangingEvent = this.lstPaymentMethodsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.lstPaymentMethodsRowChangeEvent((dsProducers.lstPaymentMethodsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPaymentMethodsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstPaymentMethodsRowChangeEventHandler methodsRowDeletedEvent = this.lstPaymentMethodsRowDeletedEvent;
      if (methodsRowDeletedEvent == null)
        return;
      methodsRowDeletedEvent((object) this, new dsProducers.lstPaymentMethodsRowChangeEvent((dsProducers.lstPaymentMethodsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPaymentMethodsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstPaymentMethodsRowChangeEventHandler rowDeletingEvent = this.lstPaymentMethodsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.lstPaymentMethodsRowChangeEvent((dsProducers.lstPaymentMethodsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstPaymentMethodsRow(dsProducers.lstPaymentMethodsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPaymentMethodsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class lstProducersDataTable : TypedTableBase<dsProducers.lstProducersRow>
  {
    private DataColumn columnProducerGUID;
    private DataColumn columnProducerName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProducersDataTable()
    {
      this.TableName = "lstProducers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProducersDataTable(DataTable table)
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
    protected lstProducersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerGUIDColumn => this.columnProducerGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerNameColumn => this.columnProducerName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducersRow this[int index]
    {
      get => (dsProducers.lstProducersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducersRowChangeEventHandler lstProducersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducersRowChangeEventHandler lstProducersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducersRowChangeEventHandler lstProducersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducersRowChangeEventHandler lstProducersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstProducersRow(dsProducers.lstProducersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducersRow AddlstProducersRow(Guid ProducerGUID, string ProducerName)
    {
      dsProducers.lstProducersRow row = (dsProducers.lstProducersRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ProducerGUID,
        (object) ProducerName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.lstProducersDataTable producersDataTable = (dsProducers.lstProducersDataTable) base.Clone();
      producersDataTable.InitVars();
      return (DataTable) producersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.lstProducersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerGUID = this.Columns["ProducerGUID"];
      this.columnProducerName = this.Columns["ProducerName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnProducerGUID = new DataColumn("ProducerGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerGUID);
      this.columnProducerName = new DataColumn("ProducerName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnProducerGUID
      }, false));
      this.columnProducerGUID.AllowDBNull = false;
      this.columnProducerGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducersRow NewlstProducersRow()
    {
      return (dsProducers.lstProducersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.lstProducersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.lstProducersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducersRowChangeEventHandler producersRowChangedEvent = this.lstProducersRowChangedEvent;
      if (producersRowChangedEvent == null)
        return;
      producersRowChangedEvent((object) this, new dsProducers.lstProducersRowChangeEvent((dsProducers.lstProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducersRowChangeEventHandler rowChangingEvent = this.lstProducersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.lstProducersRowChangeEvent((dsProducers.lstProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducersRowChangeEventHandler producersRowDeletedEvent = this.lstProducersRowDeletedEvent;
      if (producersRowDeletedEvent == null)
        return;
      producersRowDeletedEvent((object) this, new dsProducers.lstProducersRowChangeEvent((dsProducers.lstProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducersRowChangeEventHandler rowDeletingEvent = this.lstProducersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.lstProducersRowChangeEvent((dsProducers.lstProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstProducersRow(dsProducers.lstProducersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstProducersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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
  public class lstProducerStatusReasonsDataTable : 
    TypedTableBase<dsProducers.lstProducerStatusReasonsRow>
  {
    private DataColumn columnID;
    private DataColumn columnReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProducerStatusReasonsDataTable()
    {
      this.TableName = "lstProducerStatusReasons";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProducerStatusReasonsDataTable(DataTable table)
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
    protected lstProducerStatusReasonsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ReasonColumn => this.columnReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerStatusReasonsRow this[int index]
    {
      get => (dsProducers.lstProducerStatusReasonsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerStatusReasonsRowChangeEventHandler lstProducerStatusReasonsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerStatusReasonsRowChangeEventHandler lstProducerStatusReasonsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerStatusReasonsRowChangeEventHandler lstProducerStatusReasonsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProducers.lstProducerStatusReasonsRowChangeEventHandler lstProducerStatusReasonsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstProducerStatusReasonsRow(dsProducers.lstProducerStatusReasonsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerStatusReasonsRow AddlstProducerStatusReasonsRow(
      int ID,
      string Reason)
    {
      dsProducers.lstProducerStatusReasonsRow row = (dsProducers.lstProducerStatusReasonsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) Reason
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerStatusReasonsRow FindByID(int ID)
    {
      return (dsProducers.lstProducerStatusReasonsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProducers.lstProducerStatusReasonsDataTable reasonsDataTable = (dsProducers.lstProducerStatusReasonsDataTable) base.Clone();
      reasonsDataTable.InitVars();
      return (DataTable) reasonsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducers.lstProducerStatusReasonsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnReason = this.Columns["Reason"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnReason = new DataColumn("Reason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReason);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.Unique = true;
      this.columnReason.MaxLength = 250;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerStatusReasonsRow NewlstProducerStatusReasonsRow()
    {
      return (dsProducers.lstProducerStatusReasonsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducers.lstProducerStatusReasonsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducers.lstProducerStatusReasonsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerStatusReasonsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerStatusReasonsRowChangeEventHandler reasonsRowChangedEvent = this.lstProducerStatusReasonsRowChangedEvent;
      if (reasonsRowChangedEvent == null)
        return;
      reasonsRowChangedEvent((object) this, new dsProducers.lstProducerStatusReasonsRowChangeEvent((dsProducers.lstProducerStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerStatusReasonsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerStatusReasonsRowChangeEventHandler rowChangingEvent = this.lstProducerStatusReasonsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducers.lstProducerStatusReasonsRowChangeEvent((dsProducers.lstProducerStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerStatusReasonsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerStatusReasonsRowChangeEventHandler reasonsRowDeletedEvent = this.lstProducerStatusReasonsRowDeletedEvent;
      if (reasonsRowDeletedEvent == null)
        return;
      reasonsRowDeletedEvent((object) this, new dsProducers.lstProducerStatusReasonsRowChangeEvent((dsProducers.lstProducerStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerStatusReasonsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducers.lstProducerStatusReasonsRowChangeEventHandler rowDeletingEvent = this.lstProducerStatusReasonsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducers.lstProducerStatusReasonsRowChangeEvent((dsProducers.lstProducerStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstProducerStatusReasonsRow(dsProducers.lstProducerStatusReasonsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducers dsProducers = new dsProducers();
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
        FixedValue = dsProducers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstProducerStatusReasonsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProducers.GetSchemaSerializable();
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

  public class lstProducerTypesRow : DataRow
  {
    private dsProducers.lstProducerTypesDataTable tablelstProducerTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProducerTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstProducerTypes = (dsProducers.lstProducerTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ProducerTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstProducerTypes.ProducerTypeIDColumn]);
      set => this[this.tablelstProducerTypes.ProducerTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstProducerTypes.DescriptionColumn]);
      set => this[this.tablelstProducerTypes.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerLocationsRow[] GettblProducerLocationsRows()
    {
      return this.Table.ChildRelations["lstProducerTypestblProducerLocations"] != null ? (dsProducers.tblProducerLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstProducerTypestblProducerLocations"]) : new dsProducers.tblProducerLocationsRow[0];
    }
  }

  public class lstDeliveryMethodRow : DataRow
  {
    private dsProducers.lstDeliveryMethodDataTable tablelstDeliveryMethod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstDeliveryMethodRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstDeliveryMethod = (dsProducers.lstDeliveryMethodDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DeliveryMethodID
    {
      get => Conversions.ToInteger(this[this.tablelstDeliveryMethod.DeliveryMethodIDColumn]);
      set => this[this.tablelstDeliveryMethod.DeliveryMethodIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstDeliveryMethod.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'lstDeliveryMethod' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstDeliveryMethod.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tablelstDeliveryMethod.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tablelstDeliveryMethod.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerLocationsRow[] GettblProducerLocationsRows()
    {
      return this.Table.ChildRelations["lstDeliveryMethodtblProducerLocations"] != null ? (dsProducers.tblProducerLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstDeliveryMethodtblProducerLocations"]) : new dsProducers.tblProducerLocationsRow[0];
    }
  }

  public class tblProducerContactsRow : DataRow
  {
    private dsProducers.tblProducerContactsDataTable tabletblProducerContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblProducerContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerContacts = (dsProducers.tblProducerContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ProducerContactGUID
    {
      get
      {
        object obj = this[this.tabletblProducerContacts.ProducerContactGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducerContacts.ProducerContactGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ProducerLocationGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducerContacts.ProducerLocationGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationGUID' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.ProducerLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int StatusID
    {
      get => Conversions.ToInteger(this[this.tabletblProducerContacts.StatusIDColumn]);
      set => this[this.tabletblProducerContacts.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerLocationsRow tblProducerLocationsRow
    {
      get
      {
        return (dsProducers.tblProducerLocationsRow) this.GetParentRow(this.Table.ParentRelations["tblProducerLocationstblProducerContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblProducerLocationstblProducerContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerLocationGUIDNull()
    {
      return this.IsNull(this.tabletblProducerContacts.ProducerLocationGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerLocationGUIDNull()
    {
      this[this.tabletblProducerContacts.ProducerLocationGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabletblProducerContacts.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabletblProducerContacts.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblProducerLocationsRow : DataRow
  {
    private dsProducers.tblProducerLocationsDataTable tabletblProducerLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblProducerLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerLocations = (dsProducers.tblProducerLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ProducerLocationGUID
    {
      get
      {
        object obj = this[this.tabletblProducerLocations.ProducerLocationGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducerLocations.ProducerLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ProducerGUID
    {
      get
      {
        object obj = this[this.tabletblProducerLocations.ProducerGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducerLocations.ProducerGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ProducerTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerLocations.ProducerTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerTypeID' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.ProducerTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address1' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address2' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string County
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.CountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'County' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.CountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.ZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipPlus' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.ZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Phone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.PhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Phone' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Fax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.FaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fax' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.FaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FEIN
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.FEINColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FEIN' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.FEINColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Closed
    {
      get => Conversions.ToBoolean(this[this.tabletblProducerLocations.ClosedColumn]);
      set => this[this.tabletblProducerLocations.ClosedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string WebSite
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.WebSiteColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WebSite' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.WebSiteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool PrimaryLocation
    {
      get => Conversions.ToBoolean(this[this.tabletblProducerLocations.PrimaryLocationColumn]);
      set => this[this.tabletblProducerLocations.PrimaryLocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DeliveryMethodID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerLocations.DeliveryMethodIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeliveryMethodID' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.DeliveryMethodIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateAdded
    {
      get => Conversions.ToDate(this[this.tabletblProducerLocations.DateAddedColumn]);
      set => this[this.tabletblProducerLocations.DateAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int LocationTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerLocations.LocationTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationTypeID' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.LocationTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int StatusID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerLocations.StatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusID' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Hidden
    {
      get => Conversions.ToBoolean(this[this.tabletblProducerLocations.HiddenColumn]);
      set => this[this.tabletblProducerLocations.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LocationCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.LocationCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationCode' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.LocationCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.EmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Email' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool AllowAutomaticNOC
    {
      get => Conversions.ToBoolean(this[this.tabletblProducerLocations.AllowAutomaticNOCColumn]);
      set => this[this.tabletblProducerLocations.AllowAutomaticNOCColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ISOCountryCode
    {
      get => Conversions.ToString(this[this.tabletblProducerLocations.ISOCountryCodeColumn]);
      set => this[this.tabletblProducerLocations.ISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string _Region
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.RegionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Region' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.RegionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool EmailReminders
    {
      get => Conversions.ToBoolean(this[this.tabletblProducerLocations.EmailRemindersColumn]);
      set => this[this.tabletblProducerLocations.EmailRemindersColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid BillToProducerLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducerLocations.BillToProducerLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillToProducerLocationGuid' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.BillToProducerLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid MailToProducerLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducerLocations.MailToProducerLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MailToProducerLocationGuid' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.MailToProducerLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal ProducerLocationRegion
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblProducerLocations.ProducerLocationRegionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationRegion' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.ProducerLocationRegionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProducerLocationID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.ProducerLocationIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationID' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.ProducerLocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int NumEmployees
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerLocations.NumEmployeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumEmployees' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.NumEmployeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal GrossWrittenPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblProducerLocations.GrossWrittenPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GrossWrittenPremium' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.GrossWrittenPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool OptOut
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblProducerLocations.OptOutColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OptOut' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.OptOutColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProductionPotential
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.ProductionPotentialColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProductionPotential' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.ProductionPotentialColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public byte LocationSource
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabletblProducerLocations.LocationSourceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationSource' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.LocationSourceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid Owner
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducerLocations.OwnerColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Owner' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.OwnerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int NumWholesaleRelationship
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerLocations.NumWholesaleRelationshipColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumWholesaleRelationship' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.NumWholesaleRelationshipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string WholesaleRelationships
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.WholesaleRelationshipsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WholesaleRelationships' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.WholesaleRelationshipsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Expertise
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.ExpertiseColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Expertise' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.ExpertiseColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool SetProcedureToEnage
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblProducerLocations.SetProcedureToEnageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SetProcedureToEnage' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.SetProcedureToEnageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ApproveWholesalersList
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblProducerLocations.ApproveWholesalersListColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ApproveWholesalersList' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.ApproveWholesalersListColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SpecFocusDept
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.SpecFocusDeptColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SpecFocusDept' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.SpecFocusDeptColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime AgreementEffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblProducerLocations.AgreementEffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AgreementEffectiveDate' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.AgreementEffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ProducerRankingID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerLocations.ProducerRankingIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerRankingID' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.ProducerRankingIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public short PaymentMethodID
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblProducerLocations.PaymentMethodIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PaymentMethodID' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.PaymentMethodIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool OnStatement
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblProducerLocations.OnStatementColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OnStatement' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.OnStatementColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NPN
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.NPNColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NPN' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.NPNColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ReferredBYProdLocation
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducerLocations.ReferredBYProdLocationColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ReferredBYProdLocation' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.ReferredBYProdLocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int StatusChangeReasonID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerLocations.StatusChangeReasonIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusChangeReasonID' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.StatusChangeReasonIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StatusChangeReasonComment
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.StatusChangeReasonCommentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusChangeReasonComment' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.StatusChangeReasonCommentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int AddedBy
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerLocations.AddedByColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddedBy' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.AddedByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateModified
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblProducerLocations.DateModifiedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateModified' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.DateModifiedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ModifiedBy
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerLocations.ModifiedByColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ModifiedBy' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.ModifiedByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NameonCheck
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.NameonCheckColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NameonCheck' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.NameonCheckColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CountryCodeforPhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.CountryCodeforPhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CountryCodeforPhone' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.CountryCodeforPhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CountryCodeforFax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.CountryCodeforFaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CountryCodeforFax' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.CountryCodeforFaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InHouseProducer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.InHouseProducerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InHouseProducer' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.InHouseProducerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstDeliveryMethodRow lstDeliveryMethodRow
    {
      get
      {
        return (dsProducers.lstDeliveryMethodRow) this.GetParentRow(this.Table.ParentRelations["lstDeliveryMethodtblProducerLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstDeliveryMethodtblProducerLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerTypesRow lstProducerTypesRow
    {
      get
      {
        return (dsProducers.lstProducerTypesRow) this.GetParentRow(this.Table.ParentRelations["lstProducerTypestblProducerLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstProducerTypestblProducerLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstStatusRow lstStatusRow
    {
      get
      {
        return (dsProducers.lstStatusRow) this.GetParentRow(this.Table.ParentRelations["lstStatustblProducerLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstStatustblProducerLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstLocationTypeRow lstLocationTypeRow
    {
      get
      {
        return (dsProducers.lstLocationTypeRow) this.GetParentRow(this.Table.ParentRelations["lstLocationTypetblProducerLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstLocationTypetblProducerLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducersRow tblProducersRow
    {
      get
      {
        return (dsProducers.tblProducersRow) this.GetParentRow(this.Table.ParentRelations["tblProducerstblProducerLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblProducerstblProducerLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerLocationRegionsRow lstProducerLocationRegionsRow
    {
      get
      {
        return (dsProducers.lstProducerLocationRegionsRow) this.GetParentRow(this.Table.ParentRelations["lstProducerLocationRegionstblProducerLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstProducerLocationRegionstblProducerLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducersRow lstProducersRow
    {
      get
      {
        return (dsProducers.lstProducersRow) this.GetParentRow(this.Table.ParentRelations["lstProducers_tblProducerLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstProducers_tblProducerLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerStatusReasonsRow lstProducerStatusReasonsRow
    {
      get
      {
        return (dsProducers.lstProducerStatusReasonsRow) this.GetParentRow(this.Table.ParentRelations["lstProducerStatusReasons_tblProducerLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstProducerStatusReasons_tblProducerLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerTypeIDNull()
    {
      return this.IsNull(this.tabletblProducerLocations.ProducerTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerTypeIDNull()
    {
      this[this.tabletblProducerLocations.ProducerTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabletblProducerLocations.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabletblProducerLocations.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddress1Null() => this.IsNull(this.tabletblProducerLocations.Address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabletblProducerLocations.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddress2Null() => this.IsNull(this.tabletblProducerLocations.Address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabletblProducerLocations.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabletblProducerLocations.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabletblProducerLocations.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCountyNull() => this.IsNull(this.tabletblProducerLocations.CountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCountyNull()
    {
      this[this.tabletblProducerLocations.CountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipPlusNull() => this.IsNull(this.tabletblProducerLocations.ZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipPlusNull()
    {
      this[this.tabletblProducerLocations.ZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPhoneNull() => this.IsNull(this.tabletblProducerLocations.PhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPhoneNull()
    {
      this[this.tabletblProducerLocations.PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFaxNull() => this.IsNull(this.tabletblProducerLocations.FaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFaxNull()
    {
      this[this.tabletblProducerLocations.FaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFEINNull() => this.IsNull(this.tabletblProducerLocations.FEINColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFEINNull()
    {
      this[this.tabletblProducerLocations.FEINColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsWebSiteNull() => this.IsNull(this.tabletblProducerLocations.WebSiteColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetWebSiteNull()
    {
      this[this.tabletblProducerLocations.WebSiteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDeliveryMethodIDNull()
    {
      return this.IsNull(this.tabletblProducerLocations.DeliveryMethodIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDeliveryMethodIDNull()
    {
      this[this.tabletblProducerLocations.DeliveryMethodIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationTypeIDNull()
    {
      return this.IsNull(this.tabletblProducerLocations.LocationTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationTypeIDNull()
    {
      this[this.tabletblProducerLocations.LocationTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStatusIDNull() => this.IsNull(this.tabletblProducerLocations.StatusIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStatusIDNull()
    {
      this[this.tabletblProducerLocations.StatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabletblProducerLocations.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabletblProducerLocations.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tabletblProducerLocations.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tabletblProducerLocations.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationCodeNull()
    {
      return this.IsNull(this.tabletblProducerLocations.LocationCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationCodeNull()
    {
      this[this.tabletblProducerLocations.LocationCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tabletblProducerLocations.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEmailNull()
    {
      this[this.tabletblProducerLocations.EmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Is_RegionNull() => this.IsNull(this.tabletblProducerLocations.RegionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void Set_RegionNull()
    {
      this[this.tabletblProducerLocations.RegionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBillToProducerLocationGuidNull()
    {
      return this.IsNull(this.tabletblProducerLocations.BillToProducerLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBillToProducerLocationGuidNull()
    {
      this[this.tabletblProducerLocations.BillToProducerLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMailToProducerLocationGuidNull()
    {
      return this.IsNull(this.tabletblProducerLocations.MailToProducerLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMailToProducerLocationGuidNull()
    {
      this[this.tabletblProducerLocations.MailToProducerLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerLocationRegionNull()
    {
      return this.IsNull(this.tabletblProducerLocations.ProducerLocationRegionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerLocationRegionNull()
    {
      this[this.tabletblProducerLocations.ProducerLocationRegionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerLocationIDNull()
    {
      return this.IsNull(this.tabletblProducerLocations.ProducerLocationIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerLocationIDNull()
    {
      this[this.tabletblProducerLocations.ProducerLocationIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNumEmployeesNull()
    {
      return this.IsNull(this.tabletblProducerLocations.NumEmployeesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNumEmployeesNull()
    {
      this[this.tabletblProducerLocations.NumEmployeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGrossWrittenPremiumNull()
    {
      return this.IsNull(this.tabletblProducerLocations.GrossWrittenPremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGrossWrittenPremiumNull()
    {
      this[this.tabletblProducerLocations.GrossWrittenPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOptOutNull() => this.IsNull(this.tabletblProducerLocations.OptOutColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOptOutNull()
    {
      this[this.tabletblProducerLocations.OptOutColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProductionPotentialNull()
    {
      return this.IsNull(this.tabletblProducerLocations.ProductionPotentialColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProductionPotentialNull()
    {
      this[this.tabletblProducerLocations.ProductionPotentialColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationSourceNull()
    {
      return this.IsNull(this.tabletblProducerLocations.LocationSourceColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationSourceNull()
    {
      this[this.tabletblProducerLocations.LocationSourceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOwnerNull() => this.IsNull(this.tabletblProducerLocations.OwnerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOwnerNull()
    {
      this[this.tabletblProducerLocations.OwnerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNumWholesaleRelationshipNull()
    {
      return this.IsNull(this.tabletblProducerLocations.NumWholesaleRelationshipColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNumWholesaleRelationshipNull()
    {
      this[this.tabletblProducerLocations.NumWholesaleRelationshipColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsWholesaleRelationshipsNull()
    {
      return this.IsNull(this.tabletblProducerLocations.WholesaleRelationshipsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetWholesaleRelationshipsNull()
    {
      this[this.tabletblProducerLocations.WholesaleRelationshipsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsExpertiseNull() => this.IsNull(this.tabletblProducerLocations.ExpertiseColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetExpertiseNull()
    {
      this[this.tabletblProducerLocations.ExpertiseColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSetProcedureToEnageNull()
    {
      return this.IsNull(this.tabletblProducerLocations.SetProcedureToEnageColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSetProcedureToEnageNull()
    {
      this[this.tabletblProducerLocations.SetProcedureToEnageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsApproveWholesalersListNull()
    {
      return this.IsNull(this.tabletblProducerLocations.ApproveWholesalersListColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetApproveWholesalersListNull()
    {
      this[this.tabletblProducerLocations.ApproveWholesalersListColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSpecFocusDeptNull()
    {
      return this.IsNull(this.tabletblProducerLocations.SpecFocusDeptColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSpecFocusDeptNull()
    {
      this[this.tabletblProducerLocations.SpecFocusDeptColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAgreementEffectiveDateNull()
    {
      return this.IsNull(this.tabletblProducerLocations.AgreementEffectiveDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAgreementEffectiveDateNull()
    {
      this[this.tabletblProducerLocations.AgreementEffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerRankingIDNull()
    {
      return this.IsNull(this.tabletblProducerLocations.ProducerRankingIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerRankingIDNull()
    {
      this[this.tabletblProducerLocations.ProducerRankingIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPaymentMethodIDNull()
    {
      return this.IsNull(this.tabletblProducerLocations.PaymentMethodIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPaymentMethodIDNull()
    {
      this[this.tabletblProducerLocations.PaymentMethodIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOnStatementNull()
    {
      return this.IsNull(this.tabletblProducerLocations.OnStatementColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOnStatementNull()
    {
      this[this.tabletblProducerLocations.OnStatementColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNPNNull() => this.IsNull(this.tabletblProducerLocations.NPNColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNPNNull()
    {
      this[this.tabletblProducerLocations.NPNColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsReferredBYProdLocationNull()
    {
      return this.IsNull(this.tabletblProducerLocations.ReferredBYProdLocationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetReferredBYProdLocationNull()
    {
      this[this.tabletblProducerLocations.ReferredBYProdLocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStatusChangeReasonIDNull()
    {
      return this.IsNull(this.tabletblProducerLocations.StatusChangeReasonIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStatusChangeReasonIDNull()
    {
      this[this.tabletblProducerLocations.StatusChangeReasonIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStatusChangeReasonCommentNull()
    {
      return this.IsNull(this.tabletblProducerLocations.StatusChangeReasonCommentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStatusChangeReasonCommentNull()
    {
      this[this.tabletblProducerLocations.StatusChangeReasonCommentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddedByNull() => this.IsNull(this.tabletblProducerLocations.AddedByColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddedByNull()
    {
      this[this.tabletblProducerLocations.AddedByColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDateModifiedNull()
    {
      return this.IsNull(this.tabletblProducerLocations.DateModifiedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDateModifiedNull()
    {
      this[this.tabletblProducerLocations.DateModifiedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsModifiedByNull() => this.IsNull(this.tabletblProducerLocations.ModifiedByColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetModifiedByNull()
    {
      this[this.tabletblProducerLocations.ModifiedByColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNameonCheckNull()
    {
      return this.IsNull(this.tabletblProducerLocations.NameonCheckColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNameonCheckNull()
    {
      this[this.tabletblProducerLocations.NameonCheckColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCountryCodeforPhoneNull()
    {
      return this.IsNull(this.tabletblProducerLocations.CountryCodeforPhoneColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCountryCodeforPhoneNull()
    {
      this[this.tabletblProducerLocations.CountryCodeforPhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCountryCodeforFaxNull()
    {
      return this.IsNull(this.tabletblProducerLocations.CountryCodeforFaxColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCountryCodeforFaxNull()
    {
      this[this.tabletblProducerLocations.CountryCodeforFaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInHouseProducerNull()
    {
      return this.IsNull(this.tabletblProducerLocations.InHouseProducerColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInHouseProducerNull()
    {
      this[this.tabletblProducerLocations.InHouseProducerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerContactsRow[] GettblProducerContactsRows()
    {
      return this.Table.ChildRelations["tblProducerLocationstblProducerContacts"] != null ? (dsProducers.tblProducerContactsRow[]) this.GetChildRows(this.Table.ChildRelations["tblProducerLocationstblProducerContacts"]) : new dsProducers.tblProducerContactsRow[0];
    }
  }

  public class lstStatusRow : DataRow
  {
    private dsProducers.lstStatusDataTable tablelstStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstStatusRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStatus = (dsProducers.lstStatusDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int StatusID
    {
      get => Conversions.ToInteger(this[this.tablelstStatus.StatusIDColumn]);
      set => this[this.tablelstStatus.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Status
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstStatus.StatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Status' in table 'lstStatus' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstStatus.StatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Disable
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstStatus.DisableColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Disable' in table 'lstStatus' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstStatus.DisableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStatusNull() => this.IsNull(this.tablelstStatus.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStatusNull()
    {
      this[this.tablelstStatus.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDisableNull() => this.IsNull(this.tablelstStatus.DisableColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDisableNull()
    {
      this[this.tablelstStatus.DisableColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerLocationsRow[] GettblProducerLocationsRows()
    {
      return this.Table.ChildRelations["lstStatustblProducerLocations"] != null ? (dsProducers.tblProducerLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstStatustblProducerLocations"]) : new dsProducers.tblProducerLocationsRow[0];
    }
  }

  public class lstLocationTypeRow : DataRow
  {
    private dsProducers.lstLocationTypeDataTable tablelstLocationType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstLocationTypeRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstLocationType = (dsProducers.lstLocationTypeDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int LocationTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstLocationType.LocationTypeIDColumn]);
      set => this[this.tablelstLocationType.LocationTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LocationType
    {
      get => Conversions.ToString(this[this.tablelstLocationType.LocationTypeColumn]);
      set => this[this.tablelstLocationType.LocationTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerLocationsRow[] GettblProducerLocationsRows()
    {
      return this.Table.ChildRelations["lstLocationTypetblProducerLocations"] != null ? (dsProducers.tblProducerLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstLocationTypetblProducerLocations"]) : new dsProducers.tblProducerLocationsRow[0];
    }
  }

  public class lstProducerBusinessTypesRow : DataRow
  {
    private dsProducers.lstProducerBusinessTypesDataTable tablelstProducerBusinessTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProducerBusinessTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstProducerBusinessTypes = (dsProducers.lstProducerBusinessTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int BusinessTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstProducerBusinessTypes.BusinessTypeIDColumn]);
      set => this[this.tablelstProducerBusinessTypes.BusinessTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string BusinessType
    {
      get => Conversions.ToString(this[this.tablelstProducerBusinessTypes.BusinessTypeColumn]);
      set => this[this.tablelstProducerBusinessTypes.BusinessTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducersRow[] GettblProducersRows()
    {
      return this.Table.ChildRelations["lstProducerBusinessTypestblProducers"] != null ? (dsProducers.tblProducersRow[]) this.GetChildRows(this.Table.ChildRelations["lstProducerBusinessTypestblProducers"]) : new dsProducers.tblProducersRow[0];
    }
  }

  public class tblProducersRow : DataRow
  {
    private dsProducers.tblProducersDataTable tabletblProducers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblProducersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducers = (dsProducers.tblProducersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ProducerGUID
    {
      get
      {
        object obj = this[this.tabletblProducers.ProducerGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducers.ProducerGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ProducerCode
    {
      get => Conversions.ToInteger(this[this.tabletblProducers.ProducerCodeColumn]);
      set => this[this.tabletblProducers.ProducerCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProducerName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducers.ProducerNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerName' in table 'tblProducers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducers.ProducerNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Closed
    {
      get => Conversions.ToBoolean(this[this.tabletblProducers.ClosedColumn]);
      set => this[this.tabletblProducers.ClosedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ProducerBusinessTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducers.ProducerBusinessTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerBusinessTypeID' in table 'tblProducers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducers.ProducerBusinessTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public byte[] Logo
    {
      get
      {
        try
        {
          return (byte[]) this[this.tabletblProducers.LogoColumn];
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Logo' in table 'tblProducers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducers.LogoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerBusinessTypesRow lstProducerBusinessTypesRow
    {
      get
      {
        return (dsProducers.lstProducerBusinessTypesRow) this.GetParentRow(this.Table.ParentRelations["lstProducerBusinessTypestblProducers"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstProducerBusinessTypestblProducers"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerNameNull() => this.IsNull(this.tabletblProducers.ProducerNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerNameNull()
    {
      this[this.tabletblProducers.ProducerNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerBusinessTypeIDNull()
    {
      return this.IsNull(this.tabletblProducers.ProducerBusinessTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerBusinessTypeIDNull()
    {
      this[this.tabletblProducers.ProducerBusinessTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLogoNull() => this.IsNull(this.tabletblProducers.LogoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLogoNull()
    {
      this[this.tabletblProducers.LogoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerLocationsRow[] GettblProducerLocationsRows()
    {
      return this.Table.ChildRelations["tblProducerstblProducerLocations"] != null ? (dsProducers.tblProducerLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["tblProducerstblProducerLocations"]) : new dsProducers.tblProducerLocationsRow[0];
    }
  }

  public class CompanyLinesRow : DataRow
  {
    private dsProducers.CompanyLinesDataTable tableCompanyLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal CompanyLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCompanyLines = (dsProducers.CompanyLinesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        object obj = this[this.tableCompanyLines.CompanyLineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableCompanyLines.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CompanyLine
    {
      get => Conversions.ToString(this[this.tableCompanyLines.CompanyLineColumn]);
      set => this[this.tableCompanyLines.CompanyLineColumn] = (object) value;
    }
  }

  public class lstProducerLocationRegionsRow : DataRow
  {
    private dsProducers.lstProducerLocationRegionsDataTable tablelstProducerLocationRegions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProducerLocationRegionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstProducerLocationRegions = (dsProducers.lstProducerLocationRegionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal ID
    {
      get => Conversions.ToDecimal(this[this.tablelstProducerLocationRegions.IDColumn]);
      set => this[this.tablelstProducerLocationRegions.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProducerRegion
    {
      get => Conversions.ToString(this[this.tablelstProducerLocationRegions.ProducerRegionColumn]);
      set => this[this.tablelstProducerLocationRegions.ProducerRegionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerLocationsRow[] GettblProducerLocationsRows()
    {
      return this.Table.ChildRelations["lstProducerLocationRegionstblProducerLocations"] != null ? (dsProducers.tblProducerLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstProducerLocationRegionstblProducerLocations"]) : new dsProducers.tblProducerLocationsRow[0];
    }
  }

  public class lstProducerLocationSourceRow : DataRow
  {
    private dsProducers.lstProducerLocationSourceDataTable tablelstProducerLocationSource;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProducerLocationSourceRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstProducerLocationSource = (dsProducers.lstProducerLocationSourceDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public byte ID
    {
      get => Conversions.ToByte(this[this.tablelstProducerLocationSource.IDColumn]);
      set => this[this.tablelstProducerLocationSource.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Source
    {
      get => Conversions.ToString(this[this.tablelstProducerLocationSource.SourceColumn]);
      set => this[this.tablelstProducerLocationSource.SourceColumn] = (object) value;
    }
  }

  public class lstProductionPotentialRow : DataRow
  {
    private dsProducers.lstProductionPotentialDataTable tablelstProductionPotential;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProductionPotentialRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstProductionPotential = (dsProducers.lstProductionPotentialDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ID
    {
      get => Conversions.ToString(this[this.tablelstProductionPotential.IDColumn]);
      set => this[this.tablelstProductionPotential.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstProductionPotential.DescriptionColumn]);
      set => this[this.tablelstProductionPotential.DescriptionColumn] = (object) value;
    }
  }

  public class tblUsersRow : DataRow
  {
    private dsProducers.tblUsersDataTable tabletblUsers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblUsersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUsers = (dsProducers.tblUsersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid UserGUID
    {
      get
      {
        object obj = this[this.tabletblUsers.UserGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblUsers.UserGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Name_LastFirst
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUsers.Name_LastFirstColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name_LastFirst' in table 'tblUsers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUsers.Name_LastFirstColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsName_LastFirstNull() => this.IsNull(this.tabletblUsers.Name_LastFirstColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetName_LastFirstNull()
    {
      this[this.tabletblUsers.Name_LastFirstColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblProducerCallReportRow : DataRow
  {
    private dsProducers.tblProducerCallReportDataTable tabletblProducerCallReport;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblProducerCallReportRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerCallReport = (dsProducers.tblProducerCallReportDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CallReportID
    {
      get => Conversions.ToInteger(this[this.tabletblProducerCallReport.CallReportIDColumn]);
      set => this[this.tabletblProducerCallReport.CallReportIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateOfVisit
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblProducerCallReport.DateOfVisitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateOfVisit' in table 'tblProducerCallReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerCallReport.DateOfVisitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CallType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerCallReport.CallTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CallType' in table 'tblProducerCallReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerCallReport.CallTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LeadContact
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerCallReport.LeadContactColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LeadContact' in table 'tblProducerCallReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerCallReport.LeadContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ProducerLocationID
    {
      get => Conversions.ToInteger(this[this.tabletblProducerCallReport.ProducerLocationIDColumn]);
      set => this[this.tabletblProducerCallReport.ProducerLocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ProducerLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducerCallReport.ProducerLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationGuid' in table 'tblProducerCallReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerCallReport.ProducerLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDateOfVisitNull()
    {
      return this.IsNull(this.tabletblProducerCallReport.DateOfVisitColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDateOfVisitNull()
    {
      this[this.tabletblProducerCallReport.DateOfVisitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCallTypeNull() => this.IsNull(this.tabletblProducerCallReport.CallTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCallTypeNull()
    {
      this[this.tabletblProducerCallReport.CallTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLeadContactNull()
    {
      return this.IsNull(this.tabletblProducerCallReport.LeadContactColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLeadContactNull()
    {
      this[this.tabletblProducerCallReport.LeadContactColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerLocationGuidNull()
    {
      return this.IsNull(this.tabletblProducerCallReport.ProducerLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerLocationGuidNull()
    {
      this[this.tabletblProducerCallReport.ProducerLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstProducerRankingsRow : DataRow
  {
    private dsProducers.lstProducerRankingsDataTable tablelstProducerRankings;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProducerRankingsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstProducerRankings = (dsProducers.lstProducerRankingsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstProducerRankings.IDColumn]);
      set => this[this.tablelstProducerRankings.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProducerRanking
    {
      get => Conversions.ToString(this[this.tablelstProducerRankings.ProducerRankingColumn]);
      set => this[this.tablelstProducerRankings.ProducerRankingColumn] = (object) value;
    }
  }

  public class lstPaymentMethodsRow : DataRow
  {
    private dsProducers.lstPaymentMethodsDataTable tablelstPaymentMethods;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstPaymentMethodsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPaymentMethods = (dsProducers.lstPaymentMethodsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public byte ID
    {
      get => Conversions.ToByte(this[this.tablelstPaymentMethods.IDColumn]);
      set => this[this.tablelstPaymentMethods.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PaymentMethod
    {
      get => Conversions.ToString(this[this.tablelstPaymentMethods.PaymentMethodColumn]);
      set => this[this.tablelstPaymentMethods.PaymentMethodColumn] = (object) value;
    }
  }

  public class lstProducersRow : DataRow
  {
    private dsProducers.lstProducersDataTable tablelstProducers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProducersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstProducers = (dsProducers.lstProducersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ProducerGUID
    {
      get
      {
        object obj = this[this.tablelstProducers.ProducerGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tablelstProducers.ProducerGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProducerName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstProducers.ProducerNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerName' in table 'lstProducers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstProducers.ProducerNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerNameNull() => this.IsNull(this.tablelstProducers.ProducerNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerNameNull()
    {
      this[this.tablelstProducers.ProducerNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerLocationsRow[] GettblProducerLocationsRows()
    {
      return this.Table.ChildRelations["lstProducers_tblProducerLocations"] != null ? (dsProducers.tblProducerLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstProducers_tblProducerLocations"]) : new dsProducers.tblProducerLocationsRow[0];
    }
  }

  public class lstProducerStatusReasonsRow : DataRow
  {
    private dsProducers.lstProducerStatusReasonsDataTable tablelstProducerStatusReasons;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstProducerStatusReasonsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstProducerStatusReasons = (dsProducers.lstProducerStatusReasonsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstProducerStatusReasons.IDColumn]);
      set => this[this.tablelstProducerStatusReasons.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Reason
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstProducerStatusReasons.ReasonColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Reason' in table 'lstProducerStatusReasons' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstProducerStatusReasons.ReasonColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsReasonNull() => this.IsNull(this.tablelstProducerStatusReasons.ReasonColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetReasonNull()
    {
      this[this.tablelstProducerStatusReasons.ReasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerLocationsRow[] GettblProducerLocationsRows()
    {
      return this.Table.ChildRelations["lstProducerStatusReasons_tblProducerLocations"] != null ? (dsProducers.tblProducerLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstProducerStatusReasons_tblProducerLocations"]) : new dsProducers.tblProducerLocationsRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstProducerTypesRowChangeEvent : EventArgs
  {
    private dsProducers.lstProducerTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProducerTypesRowChangeEvent(dsProducers.lstProducerTypesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstDeliveryMethodRowChangeEvent : EventArgs
  {
    private dsProducers.lstDeliveryMethodRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstDeliveryMethodRowChangeEvent(
      dsProducers.lstDeliveryMethodRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstDeliveryMethodRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblProducerContactsRowChangeEvent : EventArgs
  {
    private dsProducers.tblProducerContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblProducerContactsRowChangeEvent(
      dsProducers.tblProducerContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblProducerLocationsRowChangeEvent : EventArgs
  {
    private dsProducers.tblProducerLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblProducerLocationsRowChangeEvent(
      dsProducers.tblProducerLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstStatusRowChangeEvent : EventArgs
  {
    private dsProducers.lstStatusRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstStatusRowChangeEvent(dsProducers.lstStatusRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstStatusRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstLocationTypeRowChangeEvent : EventArgs
  {
    private dsProducers.lstLocationTypeRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstLocationTypeRowChangeEvent(dsProducers.lstLocationTypeRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstLocationTypeRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstProducerBusinessTypesRowChangeEvent : EventArgs
  {
    private dsProducers.lstProducerBusinessTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProducerBusinessTypesRowChangeEvent(
      dsProducers.lstProducerBusinessTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerBusinessTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblProducersRowChangeEvent : EventArgs
  {
    private dsProducers.tblProducersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblProducersRowChangeEvent(dsProducers.tblProducersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class CompanyLinesRowChangeEvent : EventArgs
  {
    private dsProducers.CompanyLinesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public CompanyLinesRowChangeEvent(dsProducers.CompanyLinesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.CompanyLinesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstProducerLocationRegionsRowChangeEvent : EventArgs
  {
    private dsProducers.lstProducerLocationRegionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProducerLocationRegionsRowChangeEvent(
      dsProducers.lstProducerLocationRegionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerLocationRegionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstProducerLocationSourceRowChangeEvent : EventArgs
  {
    private dsProducers.lstProducerLocationSourceRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProducerLocationSourceRowChangeEvent(
      dsProducers.lstProducerLocationSourceRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerLocationSourceRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstProductionPotentialRowChangeEvent : EventArgs
  {
    private dsProducers.lstProductionPotentialRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProductionPotentialRowChangeEvent(
      dsProducers.lstProductionPotentialRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProductionPotentialRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblUsersRowChangeEvent : EventArgs
  {
    private dsProducers.tblUsersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblUsersRowChangeEvent(dsProducers.tblUsersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblUsersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblProducerCallReportRowChangeEvent : EventArgs
  {
    private dsProducers.tblProducerCallReportRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblProducerCallReportRowChangeEvent(
      dsProducers.tblProducerCallReportRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.tblProducerCallReportRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstProducerRankingsRowChangeEvent : EventArgs
  {
    private dsProducers.lstProducerRankingsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProducerRankingsRowChangeEvent(
      dsProducers.lstProducerRankingsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerRankingsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstPaymentMethodsRowChangeEvent : EventArgs
  {
    private dsProducers.lstPaymentMethodsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstPaymentMethodsRowChangeEvent(
      dsProducers.lstPaymentMethodsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstPaymentMethodsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstProducersRowChangeEvent : EventArgs
  {
    private dsProducers.lstProducersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProducersRowChangeEvent(dsProducers.lstProducersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstProducerStatusReasonsRowChangeEvent : EventArgs
  {
    private dsProducers.lstProducerStatusReasonsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstProducerStatusReasonsRowChangeEvent(
      dsProducers.lstProducerStatusReasonsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProducers.lstProducerStatusReasonsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
