// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Insureds.dsInsured
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Insureds;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsInsured")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsInsured : DataSet
{
  private dsInsured.lstDeliveryMethodDataTable tablelstDeliveryMethod;
  private dsInsured.tblInsuredsDataTable tabletblInsureds;
  private dsInsured.tblInsuredLocationsDataTable tabletblInsuredLocations;
  private dsInsured.tblInsuredContactsDataTable tabletblInsuredContacts;
  private dsInsured.lstBusinessTypesDataTable tablelstBusinessTypes;
  private dsInsured.lstLocationTypeDataTable tablelstLocationType;
  private dsInsured.lstStatusDataTable tablelstStatus;
  private dsInsured.lstSalutationsDataTable tablelstSalutations;
  private dsInsured.InvoicesDataTable tableInvoices;
  private dsInsured.lstClaims_GenderDataTable tablelstClaims_Gender;
  private dsInsured.CompanyLinesDataTable tableCompanyLines;
  private dsInsured.tblInsuredCallReportDataTable tabletblInsuredCallReport;
  private dsInsured.tblProducersDataTable tabletblProducers;
  private dsInsured.lstInsuredLocationSourceDataTable tablelstInsuredLocationSource;
  private dsInsured.tblUsersDataTable tabletblUsers;
  private dsInsured.lstProductionPotentialDataTable tablelstProductionPotential;
  private dsInsured.lstInsuredRankingsDataTable tablelstInsuredRankings;
  private DataRelation relationlstBusinessTypestblInsureds;
  private DataRelation relationlstStatustblInsureds;
  private DataRelation relationlstSalutationstblInsureds;
  private DataRelation relationtblInsuredstblInsuredLocations;
  private DataRelation relationlstDeliveryMethodtblInsuredLocations;
  private DataRelation relationlstLocationTypetblInsuredLocations;
  private DataRelation relationtblInsuredLocationstblInsuredContacts;
  private DataRelation relationtblInsuredsInvoices;
  private DataRelation relationlstClaims_Gender_tblInsureds;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsInsured()
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
  protected dsInsured(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstDeliveryMethod)] != null)
          base.Tables.Add((DataTable) new dsInsured.lstDeliveryMethodDataTable(dataSet.Tables[nameof (lstDeliveryMethod)]));
        if (dataSet.Tables[nameof (tblInsureds)] != null)
          base.Tables.Add((DataTable) new dsInsured.tblInsuredsDataTable(dataSet.Tables[nameof (tblInsureds)]));
        if (dataSet.Tables[nameof (tblInsuredLocations)] != null)
          base.Tables.Add((DataTable) new dsInsured.tblInsuredLocationsDataTable(dataSet.Tables[nameof (tblInsuredLocations)]));
        if (dataSet.Tables[nameof (tblInsuredContacts)] != null)
          base.Tables.Add((DataTable) new dsInsured.tblInsuredContactsDataTable(dataSet.Tables[nameof (tblInsuredContacts)]));
        if (dataSet.Tables[nameof (lstBusinessTypes)] != null)
          base.Tables.Add((DataTable) new dsInsured.lstBusinessTypesDataTable(dataSet.Tables[nameof (lstBusinessTypes)]));
        if (dataSet.Tables[nameof (lstLocationType)] != null)
          base.Tables.Add((DataTable) new dsInsured.lstLocationTypeDataTable(dataSet.Tables[nameof (lstLocationType)]));
        if (dataSet.Tables[nameof (lstStatus)] != null)
          base.Tables.Add((DataTable) new dsInsured.lstStatusDataTable(dataSet.Tables[nameof (lstStatus)]));
        if (dataSet.Tables[nameof (lstSalutations)] != null)
          base.Tables.Add((DataTable) new dsInsured.lstSalutationsDataTable(dataSet.Tables[nameof (lstSalutations)]));
        if (dataSet.Tables[nameof (Invoices)] != null)
          base.Tables.Add((DataTable) new dsInsured.InvoicesDataTable(dataSet.Tables[nameof (Invoices)]));
        if (dataSet.Tables[nameof (lstClaims_Gender)] != null)
          base.Tables.Add((DataTable) new dsInsured.lstClaims_GenderDataTable(dataSet.Tables[nameof (lstClaims_Gender)]));
        if (dataSet.Tables[nameof (CompanyLines)] != null)
          base.Tables.Add((DataTable) new dsInsured.CompanyLinesDataTable(dataSet.Tables[nameof (CompanyLines)]));
        if (dataSet.Tables[nameof (tblInsuredCallReport)] != null)
          base.Tables.Add((DataTable) new dsInsured.tblInsuredCallReportDataTable(dataSet.Tables[nameof (tblInsuredCallReport)]));
        if (dataSet.Tables[nameof (tblProducers)] != null)
          base.Tables.Add((DataTable) new dsInsured.tblProducersDataTable(dataSet.Tables[nameof (tblProducers)]));
        if (dataSet.Tables[nameof (lstInsuredLocationSource)] != null)
          base.Tables.Add((DataTable) new dsInsured.lstInsuredLocationSourceDataTable(dataSet.Tables[nameof (lstInsuredLocationSource)]));
        if (dataSet.Tables[nameof (tblUsers)] != null)
          base.Tables.Add((DataTable) new dsInsured.tblUsersDataTable(dataSet.Tables[nameof (tblUsers)]));
        if (dataSet.Tables[nameof (lstProductionPotential)] != null)
          base.Tables.Add((DataTable) new dsInsured.lstProductionPotentialDataTable(dataSet.Tables[nameof (lstProductionPotential)]));
        if (dataSet.Tables[nameof (lstInsuredRankings)] != null)
          base.Tables.Add((DataTable) new dsInsured.lstInsuredRankingsDataTable(dataSet.Tables[nameof (lstInsuredRankings)]));
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
  public dsInsured.lstDeliveryMethodDataTable lstDeliveryMethod => this.tablelstDeliveryMethod;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.tblInsuredsDataTable tblInsureds => this.tabletblInsureds;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.tblInsuredLocationsDataTable tblInsuredLocations
  {
    get => this.tabletblInsuredLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.tblInsuredContactsDataTable tblInsuredContacts => this.tabletblInsuredContacts;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.lstBusinessTypesDataTable lstBusinessTypes => this.tablelstBusinessTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.lstLocationTypeDataTable lstLocationType => this.tablelstLocationType;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.lstStatusDataTable lstStatus => this.tablelstStatus;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.lstSalutationsDataTable lstSalutations => this.tablelstSalutations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.InvoicesDataTable Invoices => this.tableInvoices;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.lstClaims_GenderDataTable lstClaims_Gender => this.tablelstClaims_Gender;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.CompanyLinesDataTable CompanyLines => this.tableCompanyLines;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.tblInsuredCallReportDataTable tblInsuredCallReport
  {
    get => this.tabletblInsuredCallReport;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.tblProducersDataTable tblProducers => this.tabletblProducers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.lstInsuredLocationSourceDataTable lstInsuredLocationSource
  {
    get => this.tablelstInsuredLocationSource;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.tblUsersDataTable tblUsers => this.tabletblUsers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.lstProductionPotentialDataTable lstProductionPotential
  {
    get => this.tablelstProductionPotential;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsured.lstInsuredRankingsDataTable lstInsuredRankings => this.tablelstInsuredRankings;

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
    dsInsured dsInsured = (dsInsured) base.Clone();
    dsInsured.InitVars();
    dsInsured.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsInsured;
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
      if (dataSet.Tables["lstDeliveryMethod"] != null)
        base.Tables.Add((DataTable) new dsInsured.lstDeliveryMethodDataTable(dataSet.Tables["lstDeliveryMethod"]));
      if (dataSet.Tables["tblInsureds"] != null)
        base.Tables.Add((DataTable) new dsInsured.tblInsuredsDataTable(dataSet.Tables["tblInsureds"]));
      if (dataSet.Tables["tblInsuredLocations"] != null)
        base.Tables.Add((DataTable) new dsInsured.tblInsuredLocationsDataTable(dataSet.Tables["tblInsuredLocations"]));
      if (dataSet.Tables["tblInsuredContacts"] != null)
        base.Tables.Add((DataTable) new dsInsured.tblInsuredContactsDataTable(dataSet.Tables["tblInsuredContacts"]));
      if (dataSet.Tables["lstBusinessTypes"] != null)
        base.Tables.Add((DataTable) new dsInsured.lstBusinessTypesDataTable(dataSet.Tables["lstBusinessTypes"]));
      if (dataSet.Tables["lstLocationType"] != null)
        base.Tables.Add((DataTable) new dsInsured.lstLocationTypeDataTable(dataSet.Tables["lstLocationType"]));
      if (dataSet.Tables["lstStatus"] != null)
        base.Tables.Add((DataTable) new dsInsured.lstStatusDataTable(dataSet.Tables["lstStatus"]));
      if (dataSet.Tables["lstSalutations"] != null)
        base.Tables.Add((DataTable) new dsInsured.lstSalutationsDataTable(dataSet.Tables["lstSalutations"]));
      if (dataSet.Tables["Invoices"] != null)
        base.Tables.Add((DataTable) new dsInsured.InvoicesDataTable(dataSet.Tables["Invoices"]));
      if (dataSet.Tables["lstClaims_Gender"] != null)
        base.Tables.Add((DataTable) new dsInsured.lstClaims_GenderDataTable(dataSet.Tables["lstClaims_Gender"]));
      if (dataSet.Tables["CompanyLines"] != null)
        base.Tables.Add((DataTable) new dsInsured.CompanyLinesDataTable(dataSet.Tables["CompanyLines"]));
      if (dataSet.Tables["tblInsuredCallReport"] != null)
        base.Tables.Add((DataTable) new dsInsured.tblInsuredCallReportDataTable(dataSet.Tables["tblInsuredCallReport"]));
      if (dataSet.Tables["tblProducers"] != null)
        base.Tables.Add((DataTable) new dsInsured.tblProducersDataTable(dataSet.Tables["tblProducers"]));
      if (dataSet.Tables["lstInsuredLocationSource"] != null)
        base.Tables.Add((DataTable) new dsInsured.lstInsuredLocationSourceDataTable(dataSet.Tables["lstInsuredLocationSource"]));
      if (dataSet.Tables["tblUsers"] != null)
        base.Tables.Add((DataTable) new dsInsured.tblUsersDataTable(dataSet.Tables["tblUsers"]));
      if (dataSet.Tables["lstProductionPotential"] != null)
        base.Tables.Add((DataTable) new dsInsured.lstProductionPotentialDataTable(dataSet.Tables["lstProductionPotential"]));
      if (dataSet.Tables["lstInsuredRankings"] != null)
        base.Tables.Add((DataTable) new dsInsured.lstInsuredRankingsDataTable(dataSet.Tables["lstInsuredRankings"]));
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
    this.tablelstDeliveryMethod = (dsInsured.lstDeliveryMethodDataTable) base.Tables["lstDeliveryMethod"];
    if (initTable && this.tablelstDeliveryMethod != null)
      this.tablelstDeliveryMethod.InitVars();
    this.tabletblInsureds = (dsInsured.tblInsuredsDataTable) base.Tables["tblInsureds"];
    if (initTable && this.tabletblInsureds != null)
      this.tabletblInsureds.InitVars();
    this.tabletblInsuredLocations = (dsInsured.tblInsuredLocationsDataTable) base.Tables["tblInsuredLocations"];
    if (initTable && this.tabletblInsuredLocations != null)
      this.tabletblInsuredLocations.InitVars();
    this.tabletblInsuredContacts = (dsInsured.tblInsuredContactsDataTable) base.Tables["tblInsuredContacts"];
    if (initTable && this.tabletblInsuredContacts != null)
      this.tabletblInsuredContacts.InitVars();
    this.tablelstBusinessTypes = (dsInsured.lstBusinessTypesDataTable) base.Tables["lstBusinessTypes"];
    if (initTable && this.tablelstBusinessTypes != null)
      this.tablelstBusinessTypes.InitVars();
    this.tablelstLocationType = (dsInsured.lstLocationTypeDataTable) base.Tables["lstLocationType"];
    if (initTable && this.tablelstLocationType != null)
      this.tablelstLocationType.InitVars();
    this.tablelstStatus = (dsInsured.lstStatusDataTable) base.Tables["lstStatus"];
    if (initTable && this.tablelstStatus != null)
      this.tablelstStatus.InitVars();
    this.tablelstSalutations = (dsInsured.lstSalutationsDataTable) base.Tables["lstSalutations"];
    if (initTable && this.tablelstSalutations != null)
      this.tablelstSalutations.InitVars();
    this.tableInvoices = (dsInsured.InvoicesDataTable) base.Tables["Invoices"];
    if (initTable && this.tableInvoices != null)
      this.tableInvoices.InitVars();
    this.tablelstClaims_Gender = (dsInsured.lstClaims_GenderDataTable) base.Tables["lstClaims_Gender"];
    if (initTable && this.tablelstClaims_Gender != null)
      this.tablelstClaims_Gender.InitVars();
    this.tableCompanyLines = (dsInsured.CompanyLinesDataTable) base.Tables["CompanyLines"];
    if (initTable && this.tableCompanyLines != null)
      this.tableCompanyLines.InitVars();
    this.tabletblInsuredCallReport = (dsInsured.tblInsuredCallReportDataTable) base.Tables["tblInsuredCallReport"];
    if (initTable && this.tabletblInsuredCallReport != null)
      this.tabletblInsuredCallReport.InitVars();
    this.tabletblProducers = (dsInsured.tblProducersDataTable) base.Tables["tblProducers"];
    if (initTable && this.tabletblProducers != null)
      this.tabletblProducers.InitVars();
    this.tablelstInsuredLocationSource = (dsInsured.lstInsuredLocationSourceDataTable) base.Tables["lstInsuredLocationSource"];
    if (initTable && this.tablelstInsuredLocationSource != null)
      this.tablelstInsuredLocationSource.InitVars();
    this.tabletblUsers = (dsInsured.tblUsersDataTable) base.Tables["tblUsers"];
    if (initTable && this.tabletblUsers != null)
      this.tabletblUsers.InitVars();
    this.tablelstProductionPotential = (dsInsured.lstProductionPotentialDataTable) base.Tables["lstProductionPotential"];
    if (initTable && this.tablelstProductionPotential != null)
      this.tablelstProductionPotential.InitVars();
    this.tablelstInsuredRankings = (dsInsured.lstInsuredRankingsDataTable) base.Tables["lstInsuredRankings"];
    if (initTable && this.tablelstInsuredRankings != null)
      this.tablelstInsuredRankings.InitVars();
    this.relationlstBusinessTypestblInsureds = this.Relations["lstBusinessTypestblInsureds"];
    this.relationlstStatustblInsureds = this.Relations["lstStatustblInsureds"];
    this.relationlstSalutationstblInsureds = this.Relations["lstSalutationstblInsureds"];
    this.relationtblInsuredstblInsuredLocations = this.Relations["tblInsuredstblInsuredLocations"];
    this.relationlstDeliveryMethodtblInsuredLocations = this.Relations["lstDeliveryMethodtblInsuredLocations"];
    this.relationlstLocationTypetblInsuredLocations = this.Relations["lstLocationTypetblInsuredLocations"];
    this.relationtblInsuredLocationstblInsuredContacts = this.Relations["tblInsuredLocationstblInsuredContacts"];
    this.relationtblInsuredsInvoices = this.Relations["tblInsuredsInvoices"];
    this.relationlstClaims_Gender_tblInsureds = this.Relations["lstClaims_Gender_tblInsureds"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsInsured);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsInsured.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstDeliveryMethod = new dsInsured.lstDeliveryMethodDataTable();
    base.Tables.Add((DataTable) this.tablelstDeliveryMethod);
    this.tabletblInsureds = new dsInsured.tblInsuredsDataTable();
    base.Tables.Add((DataTable) this.tabletblInsureds);
    this.tabletblInsuredLocations = new dsInsured.tblInsuredLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblInsuredLocations);
    this.tabletblInsuredContacts = new dsInsured.tblInsuredContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblInsuredContacts);
    this.tablelstBusinessTypes = new dsInsured.lstBusinessTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstBusinessTypes);
    this.tablelstLocationType = new dsInsured.lstLocationTypeDataTable();
    base.Tables.Add((DataTable) this.tablelstLocationType);
    this.tablelstStatus = new dsInsured.lstStatusDataTable();
    base.Tables.Add((DataTable) this.tablelstStatus);
    this.tablelstSalutations = new dsInsured.lstSalutationsDataTable();
    base.Tables.Add((DataTable) this.tablelstSalutations);
    this.tableInvoices = new dsInsured.InvoicesDataTable();
    base.Tables.Add((DataTable) this.tableInvoices);
    this.tablelstClaims_Gender = new dsInsured.lstClaims_GenderDataTable();
    base.Tables.Add((DataTable) this.tablelstClaims_Gender);
    this.tableCompanyLines = new dsInsured.CompanyLinesDataTable();
    base.Tables.Add((DataTable) this.tableCompanyLines);
    this.tabletblInsuredCallReport = new dsInsured.tblInsuredCallReportDataTable();
    base.Tables.Add((DataTable) this.tabletblInsuredCallReport);
    this.tabletblProducers = new dsInsured.tblProducersDataTable();
    base.Tables.Add((DataTable) this.tabletblProducers);
    this.tablelstInsuredLocationSource = new dsInsured.lstInsuredLocationSourceDataTable();
    base.Tables.Add((DataTable) this.tablelstInsuredLocationSource);
    this.tabletblUsers = new dsInsured.tblUsersDataTable();
    base.Tables.Add((DataTable) this.tabletblUsers);
    this.tablelstProductionPotential = new dsInsured.lstProductionPotentialDataTable();
    base.Tables.Add((DataTable) this.tablelstProductionPotential);
    this.tablelstInsuredRankings = new dsInsured.lstInsuredRankingsDataTable();
    base.Tables.Add((DataTable) this.tablelstInsuredRankings);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("lstBusinessTypestblInsureds", new DataColumn[1]
    {
      this.tablelstBusinessTypes.BusinessTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInsureds.BusinessTypeIDColumn
    });
    this.tabletblInsureds.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstStatustblInsureds", new DataColumn[1]
    {
      this.tablelstStatus.StatusIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInsureds.StatusIDColumn
    });
    this.tabletblInsureds.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("lstSalutationstblInsureds", new DataColumn[1]
    {
      this.tablelstSalutations.SalutationColumn
    }, new DataColumn[1]
    {
      this.tabletblInsureds.SalutationColumn
    });
    this.tabletblInsureds.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("tblInsuredstblInsuredLocations", new DataColumn[1]
    {
      this.tabletblInsureds.InsuredGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredLocations.InsuredGuidColumn
    });
    this.tabletblInsuredLocations.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint5 = new ForeignKeyConstraint("lstDeliveryMethodtblInsuredLocations", new DataColumn[1]
    {
      this.tablelstDeliveryMethod.DeliveryMethodIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredLocations.DeliveryMethodIDColumn
    });
    this.tabletblInsuredLocations.Constraints.Add((Constraint) foreignKeyConstraint5);
    foreignKeyConstraint5.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint5.DeleteRule = Rule.Cascade;
    foreignKeyConstraint5.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint6 = new ForeignKeyConstraint("lstLocationTypetblInsuredLocations", new DataColumn[1]
    {
      this.tablelstLocationType.LocationTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredLocations.LocationTypeIDColumn
    });
    this.tabletblInsuredLocations.Constraints.Add((Constraint) foreignKeyConstraint6);
    foreignKeyConstraint6.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint6.DeleteRule = Rule.Cascade;
    foreignKeyConstraint6.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint7 = new ForeignKeyConstraint("tblInsuredLocationstblInsuredContacts", new DataColumn[1]
    {
      this.tabletblInsuredLocations.InsuredLocationGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredContacts.InsuredLocationGuidColumn
    });
    this.tabletblInsuredContacts.Constraints.Add((Constraint) foreignKeyConstraint7);
    foreignKeyConstraint7.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint7.DeleteRule = Rule.Cascade;
    foreignKeyConstraint7.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint8 = new ForeignKeyConstraint("tblInsuredsInvoices", new DataColumn[1]
    {
      this.tabletblInsureds.InsuredGuidColumn
    }, new DataColumn[1]
    {
      this.tableInvoices.InsuredGuidColumn
    });
    this.tableInvoices.Constraints.Add((Constraint) foreignKeyConstraint8);
    foreignKeyConstraint8.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint8.DeleteRule = Rule.Cascade;
    foreignKeyConstraint8.UpdateRule = Rule.Cascade;
    this.relationlstBusinessTypestblInsureds = new DataRelation("lstBusinessTypestblInsureds", new DataColumn[1]
    {
      this.tablelstBusinessTypes.BusinessTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInsureds.BusinessTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstBusinessTypestblInsureds);
    this.relationlstStatustblInsureds = new DataRelation("lstStatustblInsureds", new DataColumn[1]
    {
      this.tablelstStatus.StatusIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInsureds.StatusIDColumn
    }, false);
    this.Relations.Add(this.relationlstStatustblInsureds);
    this.relationlstSalutationstblInsureds = new DataRelation("lstSalutationstblInsureds", new DataColumn[1]
    {
      this.tablelstSalutations.SalutationColumn
    }, new DataColumn[1]
    {
      this.tabletblInsureds.SalutationColumn
    }, false);
    this.Relations.Add(this.relationlstSalutationstblInsureds);
    this.relationtblInsuredstblInsuredLocations = new DataRelation("tblInsuredstblInsuredLocations", new DataColumn[1]
    {
      this.tabletblInsureds.InsuredGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredLocations.InsuredGuidColumn
    }, false);
    this.Relations.Add(this.relationtblInsuredstblInsuredLocations);
    this.relationlstDeliveryMethodtblInsuredLocations = new DataRelation("lstDeliveryMethodtblInsuredLocations", new DataColumn[1]
    {
      this.tablelstDeliveryMethod.DeliveryMethodIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredLocations.DeliveryMethodIDColumn
    }, false);
    this.Relations.Add(this.relationlstDeliveryMethodtblInsuredLocations);
    this.relationlstLocationTypetblInsuredLocations = new DataRelation("lstLocationTypetblInsuredLocations", new DataColumn[1]
    {
      this.tablelstLocationType.LocationTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredLocations.LocationTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstLocationTypetblInsuredLocations);
    this.relationtblInsuredLocationstblInsuredContacts = new DataRelation("tblInsuredLocationstblInsuredContacts", new DataColumn[1]
    {
      this.tabletblInsuredLocations.InsuredLocationGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblInsuredContacts.InsuredLocationGuidColumn
    }, false);
    this.Relations.Add(this.relationtblInsuredLocationstblInsuredContacts);
    this.relationtblInsuredsInvoices = new DataRelation("tblInsuredsInvoices", new DataColumn[1]
    {
      this.tabletblInsureds.InsuredGuidColumn
    }, new DataColumn[1]
    {
      this.tableInvoices.InsuredGuidColumn
    }, false);
    this.Relations.Add(this.relationtblInsuredsInvoices);
    this.relationlstClaims_Gender_tblInsureds = new DataRelation("lstClaims_Gender_tblInsureds", new DataColumn[1]
    {
      this.tablelstClaims_Gender.GenderIdColumn
    }, new DataColumn[1]
    {
      this.tabletblInsureds.GenderIdColumn
    }, false);
    this.Relations.Add(this.relationlstClaims_Gender_tblInsureds);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstDeliveryMethod() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblInsureds() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblInsuredLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblInsuredContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstBusinessTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstLocationType() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstStatus() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstSalutations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeInvoices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstClaims_Gender() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeCompanyLines() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblInsuredCallReport() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblProducers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstInsuredLocationSource() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblUsers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstProductionPotential() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstInsuredRankings() => false;

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
    dsInsured dsInsured = new dsInsured();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsInsured.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public delegate void lstDeliveryMethodRowChangeEventHandler(
    object sender,
    dsInsured.lstDeliveryMethodRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblInsuredsRowChangeEventHandler(
    object sender,
    dsInsured.tblInsuredsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblInsuredLocationsRowChangeEventHandler(
    object sender,
    dsInsured.tblInsuredLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblInsuredContactsRowChangeEventHandler(
    object sender,
    dsInsured.tblInsuredContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstBusinessTypesRowChangeEventHandler(
    object sender,
    dsInsured.lstBusinessTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstLocationTypeRowChangeEventHandler(
    object sender,
    dsInsured.lstLocationTypeRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstStatusRowChangeEventHandler(
    object sender,
    dsInsured.lstStatusRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstSalutationsRowChangeEventHandler(
    object sender,
    dsInsured.lstSalutationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void InvoicesRowChangeEventHandler(
    object sender,
    dsInsured.InvoicesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstClaims_GenderRowChangeEventHandler(
    object sender,
    dsInsured.lstClaims_GenderRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void CompanyLinesRowChangeEventHandler(
    object sender,
    dsInsured.CompanyLinesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblInsuredCallReportRowChangeEventHandler(
    object sender,
    dsInsured.tblInsuredCallReportRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblProducersRowChangeEventHandler(
    object sender,
    dsInsured.tblProducersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstInsuredLocationSourceRowChangeEventHandler(
    object sender,
    dsInsured.lstInsuredLocationSourceRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblUsersRowChangeEventHandler(
    object sender,
    dsInsured.tblUsersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstProductionPotentialRowChangeEventHandler(
    object sender,
    dsInsured.lstProductionPotentialRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstInsuredRankingsRowChangeEventHandler(
    object sender,
    dsInsured.lstInsuredRankingsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstDeliveryMethodDataTable : TypedTableBase<dsInsured.lstDeliveryMethodRow>
  {
    private DataColumn columnDeliveryMethodID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstDeliveryMethodDataTable()
    {
      this.TableName = "lstDeliveryMethod";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected lstDeliveryMethodDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DeliveryMethodIDColumn => this.columnDeliveryMethodID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstDeliveryMethodRow this[int index]
    {
      get => (dsInsured.lstDeliveryMethodRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstDeliveryMethodRow(dsInsured.lstDeliveryMethodRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstDeliveryMethodRow AddlstDeliveryMethodRow(string Description)
    {
      dsInsured.lstDeliveryMethodRow row = (dsInsured.lstDeliveryMethodRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstDeliveryMethodRow FindByDeliveryMethodID(int DeliveryMethodID)
    {
      return (dsInsured.lstDeliveryMethodRow) this.Rows.Find(new object[1]
      {
        (object) DeliveryMethodID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.lstDeliveryMethodDataTable deliveryMethodDataTable = (dsInsured.lstDeliveryMethodDataTable) base.Clone();
      deliveryMethodDataTable.InitVars();
      return (DataTable) deliveryMethodDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsured.lstDeliveryMethodDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnDeliveryMethodID = this.Columns["DeliveryMethodID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnDeliveryMethodID = new DataColumn("DeliveryMethodID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryMethodID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnDeliveryMethodID
      }, true));
      this.columnDeliveryMethodID.AutoIncrement = true;
      this.columnDeliveryMethodID.AllowDBNull = false;
      this.columnDeliveryMethodID.ReadOnly = true;
      this.columnDeliveryMethodID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstDeliveryMethodRow NewlstDeliveryMethodRow()
    {
      return (dsInsured.lstDeliveryMethodRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.lstDeliveryMethodRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.lstDeliveryMethodRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstDeliveryMethodRowChangeEventHandler methodRowChangedEvent = this.lstDeliveryMethodRowChangedEvent;
      if (methodRowChangedEvent == null)
        return;
      methodRowChangedEvent((object) this, new dsInsured.lstDeliveryMethodRowChangeEvent((dsInsured.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstDeliveryMethodRowChangeEventHandler rowChangingEvent = this.lstDeliveryMethodRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.lstDeliveryMethodRowChangeEvent((dsInsured.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstDeliveryMethodRowChangeEventHandler methodRowDeletedEvent = this.lstDeliveryMethodRowDeletedEvent;
      if (methodRowDeletedEvent == null)
        return;
      methodRowDeletedEvent((object) this, new dsInsured.lstDeliveryMethodRowChangeEvent((dsInsured.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstDeliveryMethodRowChangeEventHandler rowDeletingEvent = this.lstDeliveryMethodRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.lstDeliveryMethodRowChangeEvent((dsInsured.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstDeliveryMethodRow(dsInsured.lstDeliveryMethodRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstDeliveryMethodDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class tblInsuredsDataTable : TypedTableBase<dsInsured.tblInsuredsRow>
  {
    private DataColumn columnInsuredGuid;
    private DataColumn columnBusinessTypeID;
    private DataColumn columnCorporationName;
    private DataColumn columnInsuredID;
    private DataColumn columnFEIN;
    private DataColumn columnStatusID;
    private DataColumn columnDBA;
    private DataColumn columnSSN;
    private DataColumn columnSalutation;
    private DataColumn columnFirstName;
    private DataColumn columnMiddleName;
    private DataColumn columnLastName;
    private DataColumn columnSoundex;
    private DataColumn columnPolicyName;
    private DataColumn columnDOB;
    private DataColumn columnRiskID;
    private DataColumn columnCarrierId;
    private DataColumn columnTaxID;
    private DataColumn columnDNBNumber;
    private DataColumn columnOFACCleared;
    private DataColumn columnGenderId;
    private DataColumn columnStatusChangeReasonComment;
    private DataColumn columnOfacClearedDate;
    private DataColumn columnOptOut;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblInsuredsDataTable()
    {
      this.TableName = "tblInsureds";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblInsuredsDataTable(DataTable table)
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
    protected tblInsuredsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredGuidColumn => this.columnInsuredGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BusinessTypeIDColumn => this.columnBusinessTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CorporationNameColumn => this.columnCorporationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredIDColumn => this.columnInsuredID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FEINColumn => this.columnFEIN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DBAColumn => this.columnDBA;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SSNColumn => this.columnSSN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SalutationColumn => this.columnSalutation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FirstNameColumn => this.columnFirstName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MiddleNameColumn => this.columnMiddleName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LastNameColumn => this.columnLastName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SoundexColumn => this.columnSoundex;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyNameColumn => this.columnPolicyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DOBColumn => this.columnDOB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RiskIDColumn => this.columnRiskID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CarrierIdColumn => this.columnCarrierId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TaxIDColumn => this.columnTaxID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DNBNumberColumn => this.columnDNBNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OFACClearedColumn => this.columnOFACCleared;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GenderIdColumn => this.columnGenderId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusChangeReasonCommentColumn => this.columnStatusChangeReasonComment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfacClearedDateColumn => this.columnOfacClearedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OptOutColumn => this.columnOptOut;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredsRow this[int index] => (dsInsured.tblInsuredsRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredsRowChangeEventHandler tblInsuredsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredsRowChangeEventHandler tblInsuredsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredsRowChangeEventHandler tblInsuredsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredsRowChangeEventHandler tblInsuredsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblInsuredsRow(dsInsured.tblInsuredsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredsRow AddtblInsuredsRow(
      Guid InsuredGuid,
      dsInsured.lstBusinessTypesRow parentlstBusinessTypesRowBylstBusinessTypestblInsureds,
      string CorporationName,
      string FEIN,
      dsInsured.lstStatusRow parentlstStatusRowBylstStatustblInsureds,
      string DBA,
      string SSN,
      dsInsured.lstSalutationsRow parentlstSalutationsRowBylstSalutationstblInsureds,
      string FirstName,
      string MiddleName,
      string LastName,
      string Soundex,
      string PolicyName,
      DateTime DOB,
      string RiskID,
      string CarrierId,
      string TaxID,
      string DNBNumber,
      bool OFACCleared,
      dsInsured.lstClaims_GenderRow parentlstClaims_GenderRowBylstClaims_Gender_tblInsureds,
      string StatusChangeReasonComment,
      DateTime OfacClearedDate,
      bool OptOut)
    {
      dsInsured.tblInsuredsRow row = (dsInsured.tblInsuredsRow) this.NewRow();
      object[] objArray = new object[24]
      {
        (object) InsuredGuid,
        null,
        (object) CorporationName,
        null,
        (object) FEIN,
        null,
        (object) DBA,
        (object) SSN,
        null,
        (object) FirstName,
        (object) MiddleName,
        (object) LastName,
        (object) Soundex,
        (object) PolicyName,
        (object) DOB,
        (object) RiskID,
        (object) CarrierId,
        (object) TaxID,
        (object) DNBNumber,
        (object) OFACCleared,
        null,
        (object) StatusChangeReasonComment,
        (object) OfacClearedDate,
        (object) OptOut
      };
      if (parentlstBusinessTypesRowBylstBusinessTypestblInsureds != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstBusinessTypesRowBylstBusinessTypestblInsureds[0]);
      if (parentlstStatusRowBylstStatustblInsureds != null)
        objArray[5] = RuntimeHelpers.GetObjectValue(parentlstStatusRowBylstStatustblInsureds[0]);
      if (parentlstSalutationsRowBylstSalutationstblInsureds != null)
        objArray[8] = RuntimeHelpers.GetObjectValue(parentlstSalutationsRowBylstSalutationstblInsureds[0]);
      if (parentlstClaims_GenderRowBylstClaims_Gender_tblInsureds != null)
        objArray[20] = RuntimeHelpers.GetObjectValue(parentlstClaims_GenderRowBylstClaims_Gender_tblInsureds[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredsRow FindByInsuredGuid(Guid InsuredGuid)
    {
      return (dsInsured.tblInsuredsRow) this.Rows.Find(new object[1]
      {
        (object) InsuredGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.tblInsuredsDataTable insuredsDataTable = (dsInsured.tblInsuredsDataTable) base.Clone();
      insuredsDataTable.InitVars();
      return (DataTable) insuredsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsured.tblInsuredsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnInsuredGuid = this.Columns["InsuredGuid"];
      this.columnBusinessTypeID = this.Columns["BusinessTypeID"];
      this.columnCorporationName = this.Columns["CorporationName"];
      this.columnInsuredID = this.Columns["InsuredID"];
      this.columnFEIN = this.Columns["FEIN"];
      this.columnStatusID = this.Columns["StatusID"];
      this.columnDBA = this.Columns["DBA"];
      this.columnSSN = this.Columns["SSN"];
      this.columnSalutation = this.Columns["Salutation"];
      this.columnFirstName = this.Columns["FirstName"];
      this.columnMiddleName = this.Columns["MiddleName"];
      this.columnLastName = this.Columns["LastName"];
      this.columnSoundex = this.Columns["Soundex"];
      this.columnPolicyName = this.Columns["PolicyName"];
      this.columnDOB = this.Columns["DOB"];
      this.columnRiskID = this.Columns["RiskID"];
      this.columnCarrierId = this.Columns["CarrierId"];
      this.columnTaxID = this.Columns["TaxID"];
      this.columnDNBNumber = this.Columns["DNBNumber"];
      this.columnOFACCleared = this.Columns["OFACCleared"];
      this.columnGenderId = this.Columns["GenderId"];
      this.columnStatusChangeReasonComment = this.Columns["StatusChangeReasonComment"];
      this.columnOfacClearedDate = this.Columns["OfacClearedDate"];
      this.columnOptOut = this.Columns["OptOut"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnInsuredGuid = new DataColumn("InsuredGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredGuid);
      this.columnBusinessTypeID = new DataColumn("BusinessTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBusinessTypeID);
      this.columnCorporationName = new DataColumn("CorporationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCorporationName);
      this.columnInsuredID = new DataColumn("InsuredID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredID);
      this.columnFEIN = new DataColumn("FEIN", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFEIN);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnDBA = new DataColumn("DBA", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDBA);
      this.columnSSN = new DataColumn("SSN", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSSN);
      this.columnSalutation = new DataColumn("Salutation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSalutation);
      this.columnFirstName = new DataColumn("FirstName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirstName);
      this.columnMiddleName = new DataColumn("MiddleName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMiddleName);
      this.columnLastName = new DataColumn("LastName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLastName);
      this.columnSoundex = new DataColumn("Soundex", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSoundex);
      this.columnPolicyName = new DataColumn("PolicyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyName);
      this.columnDOB = new DataColumn("DOB", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDOB);
      this.columnRiskID = new DataColumn("RiskID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRiskID);
      this.columnCarrierId = new DataColumn("CarrierId", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCarrierId);
      this.columnTaxID = new DataColumn("TaxID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxID);
      this.columnDNBNumber = new DataColumn("DNBNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDNBNumber);
      this.columnOFACCleared = new DataColumn("OFACCleared", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOFACCleared);
      this.columnGenderId = new DataColumn("GenderId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGenderId);
      this.columnStatusChangeReasonComment = new DataColumn("StatusChangeReasonComment", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusChangeReasonComment);
      this.columnOfacClearedDate = new DataColumn("OfacClearedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfacClearedDate);
      this.columnOptOut = new DataColumn("OptOut", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptOut);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInsuredKey4", new DataColumn[1]
      {
        this.columnInsuredGuid
      }, true));
      this.columnInsuredGuid.AllowDBNull = false;
      this.columnInsuredGuid.Unique = true;
      this.columnInsuredID.AutoIncrement = true;
      this.columnInsuredID.AllowDBNull = false;
      this.columnInsuredID.ReadOnly = true;
      this.columnStatusChangeReasonComment.MaxLength = 250;
      this.columnOptOut.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredsRow NewtblInsuredsRow() => (dsInsured.tblInsuredsRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.tblInsuredsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.tblInsuredsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredsRowChangeEventHandler insuredsRowChangedEvent = this.tblInsuredsRowChangedEvent;
      if (insuredsRowChangedEvent == null)
        return;
      insuredsRowChangedEvent((object) this, new dsInsured.tblInsuredsRowChangeEvent((dsInsured.tblInsuredsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredsRowChangeEventHandler rowChangingEvent = this.tblInsuredsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.tblInsuredsRowChangeEvent((dsInsured.tblInsuredsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredsRowChangeEventHandler insuredsRowDeletedEvent = this.tblInsuredsRowDeletedEvent;
      if (insuredsRowDeletedEvent == null)
        return;
      insuredsRowDeletedEvent((object) this, new dsInsured.tblInsuredsRowChangeEvent((dsInsured.tblInsuredsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredsRowChangeEventHandler rowDeletingEvent = this.tblInsuredsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.tblInsuredsRowChangeEvent((dsInsured.tblInsuredsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblInsuredsRow(dsInsured.tblInsuredsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblInsuredsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class tblInsuredLocationsDataTable : TypedTableBase<dsInsured.tblInsuredLocationsRow>
  {
    private DataColumn columnInsuredLocationGuid;
    private DataColumn columnInsuredGuid;
    private DataColumn columnName;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnCounty;
    private DataColumn columnZipPlus;
    private DataColumn columnPhone;
    private DataColumn columnFax;
    private DataColumn columnWebSite;
    private DataColumn columnLocationTypeID;
    private DataColumn columnDeliveryMethodID;
    private DataColumn columnDateAdded;
    private DataColumn columnInsuredID;
    private DataColumn columnHidden;
    private DataColumn columnState;
    private DataColumn columnZipCode;
    private DataColumn columnEmail;
    private DataColumn columnRegion;
    private DataColumn columnISOCountryCode;
    private DataColumn columnAddedBy;
    private DataColumn columnName_LastFirst;
    private DataColumn columnMobileNumber;
    private DataColumn columnNumEmployees;
    private DataColumn columnGrossWrittenPremium;
    private DataColumn columnLocationSource;
    private DataColumn columnOwner;
    private DataColumn columnProductionPotential;
    private DataColumn columnProducerRankingID;
    private DataColumn columnNumWholesaleRelationship;
    private DataColumn columnAgreementEffectiveDate;
    private DataColumn columnSetProcedureToEnage;
    private DataColumn columnApproveWholesalersList;
    private DataColumn columnReferredBYProdLocation;
    private DataColumn columnSpecFocusDept;
    private DataColumn columnExpertise;
    private DataColumn columnWholesaleRelationships;
    private DataColumn columnOptOut;
    private DataColumn columnCountryCodeforPhone;
    private DataColumn columnCountryCodeforFax;
    private DataColumn columnCountryCodeforMobile;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblInsuredLocationsDataTable()
    {
      this.TableName = "tblInsuredLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblInsuredLocationsDataTable(DataTable table)
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
    protected tblInsuredLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredLocationGuidColumn => this.columnInsuredLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredGuidColumn => this.columnInsuredGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Address1Column => this.columnAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Address2Column => this.columnAddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CountyColumn => this.columnCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ZipPlusColumn => this.columnZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PhoneColumn => this.columnPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FaxColumn => this.columnFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WebSiteColumn => this.columnWebSite;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationTypeIDColumn => this.columnLocationTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DeliveryMethodIDColumn => this.columnDeliveryMethodID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateAddedColumn => this.columnDateAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredIDColumn => this.columnInsuredID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RegionColumn => this.columnRegion;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ISOCountryCodeColumn => this.columnISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AddedByColumn => this.columnAddedBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Name_LastFirstColumn => this.columnName_LastFirst;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MobileNumberColumn => this.columnMobileNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NumEmployeesColumn => this.columnNumEmployees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GrossWrittenPremiumColumn => this.columnGrossWrittenPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationSourceColumn => this.columnLocationSource;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OwnerColumn => this.columnOwner;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProductionPotentialColumn => this.columnProductionPotential;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerRankingIDColumn => this.columnProducerRankingID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NumWholesaleRelationshipColumn => this.columnNumWholesaleRelationship;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AgreementEffectiveDateColumn => this.columnAgreementEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SetProcedureToEnageColumn => this.columnSetProcedureToEnage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ApproveWholesalersListColumn => this.columnApproveWholesalersList;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ReferredBYProdLocationColumn => this.columnReferredBYProdLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SpecFocusDeptColumn => this.columnSpecFocusDept;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExpertiseColumn => this.columnExpertise;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WholesaleRelationshipsColumn => this.columnWholesaleRelationships;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OptOutColumn => this.columnOptOut;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CountryCodeforPhoneColumn => this.columnCountryCodeforPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CountryCodeforFaxColumn => this.columnCountryCodeforFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CountryCodeforMobileColumn => this.columnCountryCodeforMobile;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredLocationsRow this[int index]
    {
      get => (dsInsured.tblInsuredLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredLocationsRowChangeEventHandler tblInsuredLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredLocationsRowChangeEventHandler tblInsuredLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredLocationsRowChangeEventHandler tblInsuredLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredLocationsRowChangeEventHandler tblInsuredLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblInsuredLocationsRow(dsInsured.tblInsuredLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredLocationsRow AddtblInsuredLocationsRow(
      Guid InsuredLocationGuid,
      dsInsured.tblInsuredsRow parenttblInsuredsRowBytblInsuredstblInsuredLocations,
      string Name,
      string Address1,
      string Address2,
      string City,
      string County,
      string ZipPlus,
      string Phone,
      string Fax,
      string WebSite,
      dsInsured.lstLocationTypeRow parentlstLocationTypeRowBylstLocationTypetblInsuredLocations,
      dsInsured.lstDeliveryMethodRow parentlstDeliveryMethodRowBylstDeliveryMethodtblInsuredLocations,
      DateTime DateAdded,
      int InsuredID,
      bool Hidden,
      string State,
      string ZipCode,
      string Email,
      string _Region,
      string ISOCountryCode,
      Guid AddedBy,
      string Name_LastFirst,
      string MobileNumber,
      int NumEmployees,
      Decimal GrossWrittenPremium,
      short LocationSource,
      Guid Owner,
      string ProductionPotential,
      int ProducerRankingID,
      int NumWholesaleRelationship,
      DateTime AgreementEffectiveDate,
      bool SetProcedureToEnage,
      bool ApproveWholesalersList,
      Guid ReferredBYProdLocation,
      string SpecFocusDept,
      string Expertise,
      string WholesaleRelationships,
      bool OptOut,
      string CountryCodeforPhone,
      string CountryCodeforFax,
      string CountryCodeforMobile)
    {
      dsInsured.tblInsuredLocationsRow row = (dsInsured.tblInsuredLocationsRow) this.NewRow();
      object[] objArray = new object[42]
      {
        (object) InsuredLocationGuid,
        null,
        (object) Name,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) County,
        (object) ZipPlus,
        (object) Phone,
        (object) Fax,
        (object) WebSite,
        null,
        null,
        (object) DateAdded,
        (object) InsuredID,
        (object) Hidden,
        (object) State,
        (object) ZipCode,
        (object) Email,
        (object) _Region,
        (object) ISOCountryCode,
        (object) AddedBy,
        (object) Name_LastFirst,
        (object) MobileNumber,
        (object) NumEmployees,
        (object) GrossWrittenPremium,
        (object) LocationSource,
        (object) Owner,
        (object) ProductionPotential,
        (object) ProducerRankingID,
        (object) NumWholesaleRelationship,
        (object) AgreementEffectiveDate,
        (object) SetProcedureToEnage,
        (object) ApproveWholesalersList,
        (object) ReferredBYProdLocation,
        (object) SpecFocusDept,
        (object) Expertise,
        (object) WholesaleRelationships,
        (object) OptOut,
        (object) CountryCodeforPhone,
        (object) CountryCodeforFax,
        (object) CountryCodeforMobile
      };
      if (parenttblInsuredsRowBytblInsuredstblInsuredLocations != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblInsuredsRowBytblInsuredstblInsuredLocations[0]);
      if (parentlstLocationTypeRowBylstLocationTypetblInsuredLocations != null)
        objArray[11] = RuntimeHelpers.GetObjectValue(parentlstLocationTypeRowBylstLocationTypetblInsuredLocations[0]);
      if (parentlstDeliveryMethodRowBylstDeliveryMethodtblInsuredLocations != null)
        objArray[12] = RuntimeHelpers.GetObjectValue(parentlstDeliveryMethodRowBylstDeliveryMethodtblInsuredLocations[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredLocationsRow FindByInsuredLocationGuid(Guid InsuredLocationGuid)
    {
      return (dsInsured.tblInsuredLocationsRow) this.Rows.Find(new object[1]
      {
        (object) InsuredLocationGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.tblInsuredLocationsDataTable locationsDataTable = (dsInsured.tblInsuredLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsured.tblInsuredLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnInsuredLocationGuid = this.Columns["InsuredLocationGuid"];
      this.columnInsuredGuid = this.Columns["InsuredGuid"];
      this.columnName = this.Columns["Name"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnCounty = this.Columns["County"];
      this.columnZipPlus = this.Columns["ZipPlus"];
      this.columnPhone = this.Columns["Phone"];
      this.columnFax = this.Columns["Fax"];
      this.columnWebSite = this.Columns["WebSite"];
      this.columnLocationTypeID = this.Columns["LocationTypeID"];
      this.columnDeliveryMethodID = this.Columns["DeliveryMethodID"];
      this.columnDateAdded = this.Columns["DateAdded"];
      this.columnInsuredID = this.Columns["InsuredID"];
      this.columnHidden = this.Columns["Hidden"];
      this.columnState = this.Columns["State"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnEmail = this.Columns["Email"];
      this.columnRegion = this.Columns["Region"];
      this.columnISOCountryCode = this.Columns["ISOCountryCode"];
      this.columnAddedBy = this.Columns["AddedBy"];
      this.columnName_LastFirst = this.Columns["Name_LastFirst"];
      this.columnMobileNumber = this.Columns["MobileNumber"];
      this.columnNumEmployees = this.Columns["NumEmployees"];
      this.columnGrossWrittenPremium = this.Columns["GrossWrittenPremium"];
      this.columnLocationSource = this.Columns["LocationSource"];
      this.columnOwner = this.Columns["Owner"];
      this.columnProductionPotential = this.Columns["ProductionPotential"];
      this.columnProducerRankingID = this.Columns["ProducerRankingID"];
      this.columnNumWholesaleRelationship = this.Columns["NumWholesaleRelationship"];
      this.columnAgreementEffectiveDate = this.Columns["AgreementEffectiveDate"];
      this.columnSetProcedureToEnage = this.Columns["SetProcedureToEnage"];
      this.columnApproveWholesalersList = this.Columns["ApproveWholesalersList"];
      this.columnReferredBYProdLocation = this.Columns["ReferredBYProdLocation"];
      this.columnSpecFocusDept = this.Columns["SpecFocusDept"];
      this.columnExpertise = this.Columns["Expertise"];
      this.columnWholesaleRelationships = this.Columns["WholesaleRelationships"];
      this.columnOptOut = this.Columns["OptOut"];
      this.columnCountryCodeforPhone = this.Columns["CountryCodeforPhone"];
      this.columnCountryCodeforFax = this.Columns["CountryCodeforFax"];
      this.columnCountryCodeforMobile = this.Columns["CountryCodeforMobile"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnInsuredLocationGuid = new DataColumn("InsuredLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredLocationGuid);
      this.columnInsuredGuid = new DataColumn("InsuredGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredGuid);
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
      this.columnWebSite = new DataColumn("WebSite", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWebSite);
      this.columnLocationTypeID = new DataColumn("LocationTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationTypeID);
      this.columnDeliveryMethodID = new DataColumn("DeliveryMethodID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryMethodID);
      this.columnDateAdded = new DataColumn("DateAdded", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateAdded);
      this.columnInsuredID = new DataColumn("InsuredID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredID);
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.columnRegion = new DataColumn("Region", typeof (string), (string) null, MappingType.Element);
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "RegionColumn");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnRegion");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Region");
      this.Columns.Add(this.columnRegion);
      this.columnISOCountryCode = new DataColumn("ISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnISOCountryCode);
      this.columnAddedBy = new DataColumn("AddedBy", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddedBy);
      this.columnName_LastFirst = new DataColumn("Name_LastFirst", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName_LastFirst);
      this.columnMobileNumber = new DataColumn("MobileNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMobileNumber);
      this.columnNumEmployees = new DataColumn("NumEmployees", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumEmployees);
      this.columnGrossWrittenPremium = new DataColumn("GrossWrittenPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGrossWrittenPremium);
      this.columnLocationSource = new DataColumn("LocationSource", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationSource);
      this.columnOwner = new DataColumn("Owner", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOwner);
      this.columnProductionPotential = new DataColumn("ProductionPotential", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProductionPotential);
      this.columnProducerRankingID = new DataColumn("ProducerRankingID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerRankingID);
      this.columnNumWholesaleRelationship = new DataColumn("NumWholesaleRelationship", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumWholesaleRelationship);
      this.columnAgreementEffectiveDate = new DataColumn("AgreementEffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAgreementEffectiveDate);
      this.columnSetProcedureToEnage = new DataColumn("SetProcedureToEnage", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSetProcedureToEnage);
      this.columnApproveWholesalersList = new DataColumn("ApproveWholesalersList", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnApproveWholesalersList);
      this.columnReferredBYProdLocation = new DataColumn("ReferredBYProdLocation", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReferredBYProdLocation);
      this.columnSpecFocusDept = new DataColumn("SpecFocusDept", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecFocusDept);
      this.columnExpertise = new DataColumn("Expertise", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpertise);
      this.columnWholesaleRelationships = new DataColumn("WholesaleRelationships", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWholesaleRelationships);
      this.columnOptOut = new DataColumn("OptOut", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptOut);
      this.columnCountryCodeforPhone = new DataColumn("CountryCodeforPhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCountryCodeforPhone);
      this.columnCountryCodeforFax = new DataColumn("CountryCodeforFax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCountryCodeforFax);
      this.columnCountryCodeforMobile = new DataColumn("CountryCodeforMobile", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCountryCodeforMobile);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInsuredKey1", new DataColumn[1]
      {
        this.columnInsuredLocationGuid
      }, true));
      this.columnInsuredLocationGuid.AllowDBNull = false;
      this.columnInsuredLocationGuid.Unique = true;
      this.columnInsuredGuid.AllowDBNull = false;
      this.columnHidden.AllowDBNull = false;
      this.columnHidden.DefaultValue = (object) false;
      this.columnISOCountryCode.AllowDBNull = false;
      this.columnISOCountryCode.DefaultValue = (object) "USA";
      this.columnOptOut.DefaultValue = (object) false;
      this.columnCountryCodeforPhone.MaxLength = 5;
      this.columnCountryCodeforFax.MaxLength = 5;
      this.columnCountryCodeforMobile.MaxLength = 5;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredLocationsRow NewtblInsuredLocationsRow()
    {
      return (dsInsured.tblInsuredLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.tblInsuredLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.tblInsuredLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblInsuredLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsInsured.tblInsuredLocationsRowChangeEvent((dsInsured.tblInsuredLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredLocationsRowChangeEventHandler rowChangingEvent = this.tblInsuredLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.tblInsuredLocationsRowChangeEvent((dsInsured.tblInsuredLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblInsuredLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsInsured.tblInsuredLocationsRowChangeEvent((dsInsured.tblInsuredLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredLocationsRowChangeEventHandler rowDeletingEvent = this.tblInsuredLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.tblInsuredLocationsRowChangeEvent((dsInsured.tblInsuredLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblInsuredLocationsRow(dsInsured.tblInsuredLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblInsuredLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class tblInsuredContactsDataTable : TypedTableBase<dsInsured.tblInsuredContactsRow>
  {
    private DataColumn columnInsuredContactGuid;
    private DataColumn columnInsuredLocationGuid;
    private DataColumn columnName;
    private DataColumn columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblInsuredContactsDataTable()
    {
      this.TableName = "tblInsuredContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblInsuredContactsDataTable(DataTable table)
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
    protected tblInsuredContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredContactGuidColumn => this.columnInsuredContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredLocationGuidColumn => this.columnInsuredLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredContactsRow this[int index]
    {
      get => (dsInsured.tblInsuredContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredContactsRowChangeEventHandler tblInsuredContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredContactsRowChangeEventHandler tblInsuredContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredContactsRowChangeEventHandler tblInsuredContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredContactsRowChangeEventHandler tblInsuredContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblInsuredContactsRow(dsInsured.tblInsuredContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredContactsRow AddtblInsuredContactsRow(
      Guid InsuredContactGuid,
      dsInsured.tblInsuredLocationsRow parenttblInsuredLocationsRowBytblInsuredLocationstblInsuredContacts,
      string Name,
      int StatusID)
    {
      dsInsured.tblInsuredContactsRow row = (dsInsured.tblInsuredContactsRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) InsuredContactGuid,
        null,
        (object) Name,
        (object) StatusID
      };
      if (parenttblInsuredLocationsRowBytblInsuredLocationstblInsuredContacts != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblInsuredLocationsRowBytblInsuredLocationstblInsuredContacts[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredContactsRow FindByInsuredContactGuid(Guid InsuredContactGuid)
    {
      return (dsInsured.tblInsuredContactsRow) this.Rows.Find(new object[1]
      {
        (object) InsuredContactGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.tblInsuredContactsDataTable contactsDataTable = (dsInsured.tblInsuredContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsured.tblInsuredContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnInsuredContactGuid = this.Columns["InsuredContactGuid"];
      this.columnInsuredLocationGuid = this.Columns["InsuredLocationGuid"];
      this.columnName = this.Columns["Name"];
      this.columnStatusID = this.Columns["StatusID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnInsuredContactGuid = new DataColumn("InsuredContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredContactGuid);
      this.columnInsuredLocationGuid = new DataColumn("InsuredLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredLocationGuid);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInsuredKey2", new DataColumn[1]
      {
        this.columnInsuredContactGuid
      }, true));
      this.columnInsuredContactGuid.AllowDBNull = false;
      this.columnInsuredContactGuid.Unique = true;
      this.columnInsuredLocationGuid.AllowDBNull = false;
      this.columnStatusID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredContactsRow NewtblInsuredContactsRow()
    {
      return (dsInsured.tblInsuredContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.tblInsuredContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.tblInsuredContactsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredContactsRowChangeEventHandler contactsRowChangedEvent = this.tblInsuredContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsInsured.tblInsuredContactsRowChangeEvent((dsInsured.tblInsuredContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredContactsRowChangeEventHandler rowChangingEvent = this.tblInsuredContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.tblInsuredContactsRowChangeEvent((dsInsured.tblInsuredContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblInsuredContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsInsured.tblInsuredContactsRowChangeEvent((dsInsured.tblInsuredContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredContactsRowChangeEventHandler rowDeletingEvent = this.tblInsuredContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.tblInsuredContactsRowChangeEvent((dsInsured.tblInsuredContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblInsuredContactsRow(dsInsured.tblInsuredContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblInsuredContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class lstBusinessTypesDataTable : TypedTableBase<dsInsured.lstBusinessTypesRow>
  {
    private DataColumn columnBusinessTypeID;
    private DataColumn columnBusinessType;
    private DataColumn columnIndividual;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstBusinessTypesDataTable()
    {
      this.TableName = "lstBusinessTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstBusinessTypesDataTable(DataTable table)
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
    protected lstBusinessTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BusinessTypeIDColumn => this.columnBusinessTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BusinessTypeColumn => this.columnBusinessType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IndividualColumn => this.columnIndividual;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstBusinessTypesRow this[int index]
    {
      get => (dsInsured.lstBusinessTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstBusinessTypesRowChangeEventHandler lstBusinessTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstBusinessTypesRowChangeEventHandler lstBusinessTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstBusinessTypesRowChangeEventHandler lstBusinessTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstBusinessTypesRowChangeEventHandler lstBusinessTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstBusinessTypesRow(dsInsured.lstBusinessTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstBusinessTypesRow AddlstBusinessTypesRow(
      string BusinessType,
      bool Individual)
    {
      dsInsured.lstBusinessTypesRow row = (dsInsured.lstBusinessTypesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) BusinessType,
        (object) Individual
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstBusinessTypesRow FindByBusinessTypeID(int BusinessTypeID)
    {
      return (dsInsured.lstBusinessTypesRow) this.Rows.Find(new object[1]
      {
        (object) BusinessTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.lstBusinessTypesDataTable businessTypesDataTable = (dsInsured.lstBusinessTypesDataTable) base.Clone();
      businessTypesDataTable.InitVars();
      return (DataTable) businessTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsured.lstBusinessTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnBusinessTypeID = this.Columns["BusinessTypeID"];
      this.columnBusinessType = this.Columns["BusinessType"];
      this.columnIndividual = this.Columns["Individual"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnBusinessTypeID = new DataColumn("BusinessTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBusinessTypeID);
      this.columnBusinessType = new DataColumn("BusinessType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBusinessType);
      this.columnIndividual = new DataColumn("Individual", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIndividual);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInsuredKey6", new DataColumn[1]
      {
        this.columnBusinessTypeID
      }, true));
      this.columnBusinessTypeID.AutoIncrement = true;
      this.columnBusinessTypeID.AllowDBNull = false;
      this.columnBusinessTypeID.ReadOnly = true;
      this.columnBusinessTypeID.Unique = true;
      this.columnIndividual.AllowDBNull = false;
      this.columnIndividual.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstBusinessTypesRow NewlstBusinessTypesRow()
    {
      return (dsInsured.lstBusinessTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.lstBusinessTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.lstBusinessTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBusinessTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstBusinessTypesRowChangeEventHandler typesRowChangedEvent = this.lstBusinessTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsInsured.lstBusinessTypesRowChangeEvent((dsInsured.lstBusinessTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBusinessTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstBusinessTypesRowChangeEventHandler rowChangingEvent = this.lstBusinessTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.lstBusinessTypesRowChangeEvent((dsInsured.lstBusinessTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBusinessTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstBusinessTypesRowChangeEventHandler typesRowDeletedEvent = this.lstBusinessTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsInsured.lstBusinessTypesRowChangeEvent((dsInsured.lstBusinessTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBusinessTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstBusinessTypesRowChangeEventHandler rowDeletingEvent = this.lstBusinessTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.lstBusinessTypesRowChangeEvent((dsInsured.lstBusinessTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstBusinessTypesRow(dsInsured.lstBusinessTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstBusinessTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class lstLocationTypeDataTable : TypedTableBase<dsInsured.lstLocationTypeRow>
  {
    private DataColumn columnLocationTypeID;
    private DataColumn columnLocationType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstLocationTypeDataTable()
    {
      this.TableName = "lstLocationType";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected lstLocationTypeDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationTypeIDColumn => this.columnLocationTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationTypeColumn => this.columnLocationType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstLocationTypeRow this[int index]
    {
      get => (dsInsured.lstLocationTypeRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstLocationTypeRowChangeEventHandler lstLocationTypeRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstLocationTypeRowChangeEventHandler lstLocationTypeRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstLocationTypeRowChangeEventHandler lstLocationTypeRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstLocationTypeRowChangeEventHandler lstLocationTypeRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstLocationTypeRow(dsInsured.lstLocationTypeRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstLocationTypeRow AddlstLocationTypeRow(string LocationType)
    {
      dsInsured.lstLocationTypeRow row = (dsInsured.lstLocationTypeRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstLocationTypeRow FindByLocationTypeID(int LocationTypeID)
    {
      return (dsInsured.lstLocationTypeRow) this.Rows.Find(new object[1]
      {
        (object) LocationTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.lstLocationTypeDataTable locationTypeDataTable = (dsInsured.lstLocationTypeDataTable) base.Clone();
      locationTypeDataTable.InitVars();
      return (DataTable) locationTypeDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsured.lstLocationTypeDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnLocationTypeID = this.Columns["LocationTypeID"];
      this.columnLocationType = this.Columns["LocationType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnLocationTypeID = new DataColumn("LocationTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationTypeID);
      this.columnLocationType = new DataColumn("LocationType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInsuredKey3", new DataColumn[1]
      {
        this.columnLocationTypeID
      }, true));
      this.columnLocationTypeID.AutoIncrement = true;
      this.columnLocationTypeID.AllowDBNull = false;
      this.columnLocationTypeID.ReadOnly = true;
      this.columnLocationTypeID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstLocationTypeRow NewlstLocationTypeRow()
    {
      return (dsInsured.lstLocationTypeRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.lstLocationTypeRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.lstLocationTypeRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLocationTypeRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstLocationTypeRowChangeEventHandler typeRowChangedEvent = this.lstLocationTypeRowChangedEvent;
      if (typeRowChangedEvent == null)
        return;
      typeRowChangedEvent((object) this, new dsInsured.lstLocationTypeRowChangeEvent((dsInsured.lstLocationTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLocationTypeRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstLocationTypeRowChangeEventHandler rowChangingEvent = this.lstLocationTypeRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.lstLocationTypeRowChangeEvent((dsInsured.lstLocationTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLocationTypeRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstLocationTypeRowChangeEventHandler typeRowDeletedEvent = this.lstLocationTypeRowDeletedEvent;
      if (typeRowDeletedEvent == null)
        return;
      typeRowDeletedEvent((object) this, new dsInsured.lstLocationTypeRowChangeEvent((dsInsured.lstLocationTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLocationTypeRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstLocationTypeRowChangeEventHandler rowDeletingEvent = this.lstLocationTypeRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.lstLocationTypeRowChangeEvent((dsInsured.lstLocationTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstLocationTypeRow(dsInsured.lstLocationTypeRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstLocationTypeDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class lstStatusDataTable : TypedTableBase<dsInsured.lstStatusRow>
  {
    private DataColumn columnStatusID;
    private DataColumn columnStatusCode;
    private DataColumn columnStatus;
    private DataColumn columnDisable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstStatusDataTable()
    {
      this.TableName = "lstStatus";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected lstStatusDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusCodeColumn => this.columnStatusCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisableColumn => this.columnDisable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstStatusRow this[int index] => (dsInsured.lstStatusRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstStatusRowChangeEventHandler lstStatusRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstStatusRowChangeEventHandler lstStatusRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstStatusRowChangeEventHandler lstStatusRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstStatusRowChangeEventHandler lstStatusRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstStatusRow(dsInsured.lstStatusRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstStatusRow AddlstStatusRow(
      int StatusID,
      string StatusCode,
      string Status,
      bool Disable)
    {
      dsInsured.lstStatusRow row = (dsInsured.lstStatusRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) StatusID,
        (object) StatusCode,
        (object) Status,
        (object) Disable
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstStatusRow FindByStatusID(int StatusID)
    {
      return (dsInsured.lstStatusRow) this.Rows.Find(new object[1]
      {
        (object) StatusID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.lstStatusDataTable lstStatusDataTable = (dsInsured.lstStatusDataTable) base.Clone();
      lstStatusDataTable.InitVars();
      return (DataTable) lstStatusDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsInsured.lstStatusDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnStatusID = this.Columns["StatusID"];
      this.columnStatusCode = this.Columns["StatusCode"];
      this.columnStatus = this.Columns["Status"];
      this.columnDisable = this.Columns["Disable"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnStatusCode = new DataColumn("StatusCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusCode);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnDisable = new DataColumn("Disable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisable);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInsuredKey7", new DataColumn[1]
      {
        this.columnStatusID
      }, true));
      this.columnStatusID.AllowDBNull = false;
      this.columnStatusID.Unique = true;
      this.columnDisable.AllowDBNull = false;
      this.columnDisable.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstStatusRow NewlstStatusRow() => (dsInsured.lstStatusRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.lstStatusRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.lstStatusRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstStatusRowChangeEventHandler statusRowChangedEvent = this.lstStatusRowChangedEvent;
      if (statusRowChangedEvent == null)
        return;
      statusRowChangedEvent((object) this, new dsInsured.lstStatusRowChangeEvent((dsInsured.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstStatusRowChangeEventHandler rowChangingEvent = this.lstStatusRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.lstStatusRowChangeEvent((dsInsured.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstStatusRowChangeEventHandler statusRowDeletedEvent = this.lstStatusRowDeletedEvent;
      if (statusRowDeletedEvent == null)
        return;
      statusRowDeletedEvent((object) this, new dsInsured.lstStatusRowChangeEvent((dsInsured.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstStatusRowChangeEventHandler rowDeletingEvent = this.lstStatusRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.lstStatusRowChangeEvent((dsInsured.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstStatusRow(dsInsured.lstStatusRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatusDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class lstSalutationsDataTable : TypedTableBase<dsInsured.lstSalutationsRow>
  {
    private DataColumn columnSalutation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstSalutationsDataTable()
    {
      this.TableName = "lstSalutations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstSalutationsDataTable(DataTable table)
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
    protected lstSalutationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SalutationColumn => this.columnSalutation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstSalutationsRow this[int index]
    {
      get => (dsInsured.lstSalutationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstSalutationsRowChangeEventHandler lstSalutationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstSalutationsRowChangeEventHandler lstSalutationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstSalutationsRowChangeEventHandler lstSalutationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstSalutationsRowChangeEventHandler lstSalutationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstSalutationsRow(dsInsured.lstSalutationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstSalutationsRow AddlstSalutationsRow(string Salutation)
    {
      dsInsured.lstSalutationsRow row = (dsInsured.lstSalutationsRow) this.NewRow();
      object[] objArray = new object[1]
      {
        (object) Salutation
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstSalutationsRow FindBySalutation(string Salutation)
    {
      return (dsInsured.lstSalutationsRow) this.Rows.Find(new object[1]
      {
        (object) Salutation
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.lstSalutationsDataTable salutationsDataTable = (dsInsured.lstSalutationsDataTable) base.Clone();
      salutationsDataTable.InitVars();
      return (DataTable) salutationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsured.lstSalutationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars() => this.columnSalutation = this.Columns["Salutation"];

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnSalutation = new DataColumn("Salutation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSalutation);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInsuredKey5", new DataColumn[1]
      {
        this.columnSalutation
      }, true));
      this.columnSalutation.AllowDBNull = false;
      this.columnSalutation.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstSalutationsRow NewlstSalutationsRow()
    {
      return (dsInsured.lstSalutationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.lstSalutationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.lstSalutationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstSalutationsRowChangeEventHandler salutationsRowChangedEvent = this.lstSalutationsRowChangedEvent;
      if (salutationsRowChangedEvent == null)
        return;
      salutationsRowChangedEvent((object) this, new dsInsured.lstSalutationsRowChangeEvent((dsInsured.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstSalutationsRowChangeEventHandler rowChangingEvent = this.lstSalutationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.lstSalutationsRowChangeEvent((dsInsured.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstSalutationsRowChangeEventHandler salutationsRowDeletedEvent = this.lstSalutationsRowDeletedEvent;
      if (salutationsRowDeletedEvent == null)
        return;
      salutationsRowDeletedEvent((object) this, new dsInsured.lstSalutationsRowChangeEvent((dsInsured.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstSalutationsRowChangeEventHandler rowDeletingEvent = this.lstSalutationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.lstSalutationsRowChangeEvent((dsInsured.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstSalutationsRow(dsInsured.lstSalutationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstSalutationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class InvoicesDataTable : TypedTableBase<dsInsured.InvoicesRow>
  {
    private DataColumn columnAmtBilled;
    private DataColumn columnDueDate;
    private DataColumn columnOfficeInvoiceNum;
    private DataColumn columnInsuredGuid;
    private DataColumn columnView;
    private DataColumn columnInvoiceDate;
    private DataColumn columnPolicyNumber;
    private DataColumn columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public InvoicesDataTable()
    {
      this.TableName = "Invoices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal InvoicesDataTable(DataTable table)
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
    protected InvoicesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AmtBilledColumn => this.columnAmtBilled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfficeInvoiceNumColumn => this.columnOfficeInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredGuidColumn => this.columnInsuredGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ViewColumn => this.columnView;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InvoiceDateColumn => this.columnInvoiceDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.InvoicesRow this[int index] => (dsInsured.InvoicesRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.InvoicesRowChangeEventHandler InvoicesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.InvoicesRowChangeEventHandler InvoicesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.InvoicesRowChangeEventHandler InvoicesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.InvoicesRowChangeEventHandler InvoicesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddInvoicesRow(dsInsured.InvoicesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.InvoicesRow AddInvoicesRow(
      double AmtBilled,
      DateTime DueDate,
      int OfficeInvoiceNum,
      dsInsured.tblInsuredsRow parenttblInsuredsRowBytblInsuredsInvoices,
      string View,
      DateTime InvoiceDate,
      string PolicyNumber,
      int InvoiceNum)
    {
      dsInsured.InvoicesRow row = (dsInsured.InvoicesRow) this.NewRow();
      object[] objArray = new object[8]
      {
        (object) AmtBilled,
        (object) DueDate,
        (object) OfficeInvoiceNum,
        null,
        (object) View,
        (object) InvoiceDate,
        (object) PolicyNumber,
        (object) InvoiceNum
      };
      if (parenttblInsuredsRowBytblInsuredsInvoices != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parenttblInsuredsRowBytblInsuredsInvoices[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.InvoicesDataTable invoicesDataTable = (dsInsured.InvoicesDataTable) base.Clone();
      invoicesDataTable.InitVars();
      return (DataTable) invoicesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsInsured.InvoicesDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnAmtBilled = this.Columns["AmtBilled"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnOfficeInvoiceNum = this.Columns["OfficeInvoiceNum"];
      this.columnInsuredGuid = this.Columns["InsuredGuid"];
      this.columnView = this.Columns["View"];
      this.columnInvoiceDate = this.Columns["InvoiceDate"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnAmtBilled = new DataColumn("AmtBilled", typeof (double), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmtBilled);
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnOfficeInvoiceNum = new DataColumn("OfficeInvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeInvoiceNum);
      this.columnInsuredGuid = new DataColumn("InsuredGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredGuid);
      this.columnView = new DataColumn("View", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnView);
      this.columnInvoiceDate = new DataColumn("InvoiceDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceDate);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnAmtBilled.AllowDBNull = false;
      this.columnAmtBilled.ReadOnly = true;
      this.columnDueDate.AllowDBNull = false;
      this.columnOfficeInvoiceNum.AllowDBNull = false;
      this.columnInsuredGuid.AllowDBNull = false;
      this.columnInvoiceDate.AllowDBNull = false;
      this.columnInvoiceNum.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.InvoicesRow NewInvoicesRow() => (dsInsured.InvoicesRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.InvoicesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.InvoicesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.InvoicesRowChangeEventHandler invoicesRowChangedEvent = this.InvoicesRowChangedEvent;
      if (invoicesRowChangedEvent == null)
        return;
      invoicesRowChangedEvent((object) this, new dsInsured.InvoicesRowChangeEvent((dsInsured.InvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.InvoicesRowChangeEventHandler rowChangingEvent = this.InvoicesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.InvoicesRowChangeEvent((dsInsured.InvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.InvoicesRowChangeEventHandler invoicesRowDeletedEvent = this.InvoicesRowDeletedEvent;
      if (invoicesRowDeletedEvent == null)
        return;
      invoicesRowDeletedEvent((object) this, new dsInsured.InvoicesRowChangeEvent((dsInsured.InvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.InvoicesRowChangeEventHandler rowDeletingEvent = this.InvoicesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.InvoicesRowChangeEvent((dsInsured.InvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveInvoicesRow(dsInsured.InvoicesRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvoicesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class lstClaims_GenderDataTable : TypedTableBase<dsInsured.lstClaims_GenderRow>
  {
    private DataColumn columnGenderId;
    private DataColumn columnGender;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstClaims_GenderDataTable()
    {
      this.TableName = "lstClaims_Gender";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstClaims_GenderDataTable(DataTable table)
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
    protected lstClaims_GenderDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GenderIdColumn => this.columnGenderId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GenderColumn => this.columnGender;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstClaims_GenderRow this[int index]
    {
      get => (dsInsured.lstClaims_GenderRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstClaims_GenderRowChangeEventHandler lstClaims_GenderRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstClaims_GenderRowChangeEventHandler lstClaims_GenderRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstClaims_GenderRowChangeEventHandler lstClaims_GenderRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstClaims_GenderRowChangeEventHandler lstClaims_GenderRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstClaims_GenderRow(dsInsured.lstClaims_GenderRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstClaims_GenderRow AddlstClaims_GenderRow(int GenderId, string Gender)
    {
      dsInsured.lstClaims_GenderRow row = (dsInsured.lstClaims_GenderRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) GenderId,
        (object) Gender
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstClaims_GenderRow FindByGenderId(int GenderId)
    {
      return (dsInsured.lstClaims_GenderRow) this.Rows.Find(new object[1]
      {
        (object) GenderId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.lstClaims_GenderDataTable claimsGenderDataTable = (dsInsured.lstClaims_GenderDataTable) base.Clone();
      claimsGenderDataTable.InitVars();
      return (DataTable) claimsGenderDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsured.lstClaims_GenderDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnGenderId = this.Columns["GenderId"];
      this.columnGender = this.Columns["Gender"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnGenderId = new DataColumn("GenderId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGenderId);
      this.columnGender = new DataColumn("Gender", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGender);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnGenderId
      }, true));
      this.columnGenderId.AllowDBNull = false;
      this.columnGenderId.Unique = true;
      this.columnGender.MaxLength = 6;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstClaims_GenderRow NewlstClaims_GenderRow()
    {
      return (dsInsured.lstClaims_GenderRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.lstClaims_GenderRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.lstClaims_GenderRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClaims_GenderRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstClaims_GenderRowChangeEventHandler genderRowChangedEvent = this.lstClaims_GenderRowChangedEvent;
      if (genderRowChangedEvent == null)
        return;
      genderRowChangedEvent((object) this, new dsInsured.lstClaims_GenderRowChangeEvent((dsInsured.lstClaims_GenderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClaims_GenderRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstClaims_GenderRowChangeEventHandler rowChangingEvent = this.lstClaims_GenderRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.lstClaims_GenderRowChangeEvent((dsInsured.lstClaims_GenderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClaims_GenderRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstClaims_GenderRowChangeEventHandler genderRowDeletedEvent = this.lstClaims_GenderRowDeletedEvent;
      if (genderRowDeletedEvent == null)
        return;
      genderRowDeletedEvent((object) this, new dsInsured.lstClaims_GenderRowChangeEvent((dsInsured.lstClaims_GenderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClaims_GenderRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstClaims_GenderRowChangeEventHandler rowDeletingEvent = this.lstClaims_GenderRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.lstClaims_GenderRowChangeEvent((dsInsured.lstClaims_GenderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstClaims_GenderRow(dsInsured.lstClaims_GenderRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstClaims_GenderDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class CompanyLinesDataTable : TypedTableBase<dsInsured.CompanyLinesRow>
  {
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnCompanyLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public CompanyLinesDataTable()
    {
      this.TableName = "CompanyLines";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected CompanyLinesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLineColumn => this.columnCompanyLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.CompanyLinesRow this[int index]
    {
      get => (dsInsured.CompanyLinesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.CompanyLinesRowChangeEventHandler CompanyLinesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.CompanyLinesRowChangeEventHandler CompanyLinesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.CompanyLinesRowChangeEventHandler CompanyLinesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.CompanyLinesRowChangeEventHandler CompanyLinesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddCompanyLinesRow(dsInsured.CompanyLinesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.CompanyLinesRow AddCompanyLinesRow(Guid CompanyLineGuid, string CompanyLine)
    {
      dsInsured.CompanyLinesRow row = (dsInsured.CompanyLinesRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.CompanyLinesDataTable companyLinesDataTable = (dsInsured.CompanyLinesDataTable) base.Clone();
      companyLinesDataTable.InitVars();
      return (DataTable) companyLinesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsured.CompanyLinesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnCompanyLine = this.Columns["CompanyLine"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnCompanyLine = new DataColumn("CompanyLine", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLine);
      this.columnCompanyLine.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.CompanyLinesRow NewCompanyLinesRow()
    {
      return (dsInsured.CompanyLinesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.CompanyLinesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.CompanyLinesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CompanyLinesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.CompanyLinesRowChangeEventHandler linesRowChangedEvent = this.CompanyLinesRowChangedEvent;
      if (linesRowChangedEvent == null)
        return;
      linesRowChangedEvent((object) this, new dsInsured.CompanyLinesRowChangeEvent((dsInsured.CompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CompanyLinesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.CompanyLinesRowChangeEventHandler rowChangingEvent = this.CompanyLinesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.CompanyLinesRowChangeEvent((dsInsured.CompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CompanyLinesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.CompanyLinesRowChangeEventHandler linesRowDeletedEvent = this.CompanyLinesRowDeletedEvent;
      if (linesRowDeletedEvent == null)
        return;
      linesRowDeletedEvent((object) this, new dsInsured.CompanyLinesRowChangeEvent((dsInsured.CompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CompanyLinesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.CompanyLinesRowChangeEventHandler rowDeletingEvent = this.CompanyLinesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.CompanyLinesRowChangeEvent((dsInsured.CompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveCompanyLinesRow(dsInsured.CompanyLinesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CompanyLinesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class tblInsuredCallReportDataTable : TypedTableBase<dsInsured.tblInsuredCallReportRow>
  {
    private DataColumn columnCallReportID;
    private DataColumn columnDateOfVisit;
    private DataColumn columnCallType;
    private DataColumn columnLeadContact;
    private DataColumn columnInsuredLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblInsuredCallReportDataTable()
    {
      this.TableName = "tblInsuredCallReport";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblInsuredCallReportDataTable(DataTable table)
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
    protected tblInsuredCallReportDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CallReportIDColumn => this.columnCallReportID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateOfVisitColumn => this.columnDateOfVisit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CallTypeColumn => this.columnCallType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LeadContactColumn => this.columnLeadContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredLocationGuidColumn => this.columnInsuredLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredCallReportRow this[int index]
    {
      get => (dsInsured.tblInsuredCallReportRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredCallReportRowChangeEventHandler tblInsuredCallReportRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredCallReportRowChangeEventHandler tblInsuredCallReportRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredCallReportRowChangeEventHandler tblInsuredCallReportRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblInsuredCallReportRowChangeEventHandler tblInsuredCallReportRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblInsuredCallReportRow(dsInsured.tblInsuredCallReportRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredCallReportRow AddtblInsuredCallReportRow(
      DateTime DateOfVisit,
      string CallType,
      string LeadContact,
      Guid InsuredLocationGuid)
    {
      dsInsured.tblInsuredCallReportRow row = (dsInsured.tblInsuredCallReportRow) this.NewRow();
      object[] objArray = new object[5]
      {
        null,
        (object) DateOfVisit,
        (object) CallType,
        (object) LeadContact,
        (object) InsuredLocationGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredCallReportRow FindByCallReportID(int CallReportID)
    {
      return (dsInsured.tblInsuredCallReportRow) this.Rows.Find(new object[1]
      {
        (object) CallReportID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.tblInsuredCallReportDataTable callReportDataTable = (dsInsured.tblInsuredCallReportDataTable) base.Clone();
      callReportDataTable.InitVars();
      return (DataTable) callReportDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsured.tblInsuredCallReportDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnCallReportID = this.Columns["CallReportID"];
      this.columnDateOfVisit = this.Columns["DateOfVisit"];
      this.columnCallType = this.Columns["CallType"];
      this.columnLeadContact = this.Columns["LeadContact"];
      this.columnInsuredLocationGuid = this.Columns["InsuredLocationGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
      this.columnInsuredLocationGuid = new DataColumn("InsuredLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredLocationGuid);
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
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredCallReportRow NewtblInsuredCallReportRow()
    {
      return (dsInsured.tblInsuredCallReportRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.tblInsuredCallReportRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.tblInsuredCallReportRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredCallReportRowChangeEventHandler reportRowChangedEvent = this.tblInsuredCallReportRowChangedEvent;
      if (reportRowChangedEvent == null)
        return;
      reportRowChangedEvent((object) this, new dsInsured.tblInsuredCallReportRowChangeEvent((dsInsured.tblInsuredCallReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredCallReportRowChangeEventHandler rowChangingEvent = this.tblInsuredCallReportRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.tblInsuredCallReportRowChangeEvent((dsInsured.tblInsuredCallReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredCallReportRowChangeEventHandler reportRowDeletedEvent = this.tblInsuredCallReportRowDeletedEvent;
      if (reportRowDeletedEvent == null)
        return;
      reportRowDeletedEvent((object) this, new dsInsured.tblInsuredCallReportRowChangeEvent((dsInsured.tblInsuredCallReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblInsuredCallReportRowChangeEventHandler rowDeletingEvent = this.tblInsuredCallReportRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.tblInsuredCallReportRowChangeEvent((dsInsured.tblInsuredCallReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblInsuredCallReportRow(dsInsured.tblInsuredCallReportRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblInsuredCallReportDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class tblProducersDataTable : TypedTableBase<dsInsured.tblProducersRow>
  {
    private DataColumn columnProducerGUID;
    private DataColumn columnProducerName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducersDataTable()
    {
      this.TableName = "tblProducers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected tblProducersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerGUIDColumn => this.columnProducerGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerNameColumn => this.columnProducerName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblProducersRow this[int index]
    {
      get => (dsInsured.tblProducersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblProducersRowChangeEventHandler tblProducersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblProducersRowChangeEventHandler tblProducersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblProducersRowChangeEventHandler tblProducersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblProducersRowChangeEventHandler tblProducersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblProducersRow(dsInsured.tblProducersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblProducersRow AddtblProducersRow(Guid ProducerGUID, string ProducerName)
    {
      dsInsured.tblProducersRow row = (dsInsured.tblProducersRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblProducersRow FindByProducerGUID(Guid ProducerGUID)
    {
      return (dsInsured.tblProducersRow) this.Rows.Find(new object[1]
      {
        (object) ProducerGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.tblProducersDataTable producersDataTable = (dsInsured.tblProducersDataTable) base.Clone();
      producersDataTable.InitVars();
      return (DataTable) producersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsured.tblProducersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerGUID = this.Columns["ProducerGUID"];
      this.columnProducerName = this.Columns["ProducerName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnProducerGUID = new DataColumn("ProducerGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerGUID);
      this.columnProducerName = new DataColumn("ProducerName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnProducerGUID
      }, true));
      this.columnProducerGUID.AllowDBNull = false;
      this.columnProducerGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblProducersRow NewtblProducersRow()
    {
      return (dsInsured.tblProducersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.tblProducersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.tblProducersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblProducersRowChangeEventHandler producersRowChangedEvent = this.tblProducersRowChangedEvent;
      if (producersRowChangedEvent == null)
        return;
      producersRowChangedEvent((object) this, new dsInsured.tblProducersRowChangeEvent((dsInsured.tblProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblProducersRowChangeEventHandler rowChangingEvent = this.tblProducersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.tblProducersRowChangeEvent((dsInsured.tblProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblProducersRowChangeEventHandler producersRowDeletedEvent = this.tblProducersRowDeletedEvent;
      if (producersRowDeletedEvent == null)
        return;
      producersRowDeletedEvent((object) this, new dsInsured.tblProducersRowChangeEvent((dsInsured.tblProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblProducersRowChangeEventHandler rowDeletingEvent = this.tblProducersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.tblProducersRowChangeEvent((dsInsured.tblProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblProducersRow(dsInsured.tblProducersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class lstInsuredLocationSourceDataTable : 
    TypedTableBase<dsInsured.lstInsuredLocationSourceRow>
  {
    private DataColumn columnID;
    private DataColumn columnSource;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstInsuredLocationSourceDataTable()
    {
      this.TableName = "lstInsuredLocationSource";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstInsuredLocationSourceDataTable(DataTable table)
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
    protected lstInsuredLocationSourceDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SourceColumn => this.columnSource;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstInsuredLocationSourceRow this[int index]
    {
      get => (dsInsured.lstInsuredLocationSourceRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstInsuredLocationSourceRowChangeEventHandler lstInsuredLocationSourceRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstInsuredLocationSourceRowChangeEventHandler lstInsuredLocationSourceRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstInsuredLocationSourceRowChangeEventHandler lstInsuredLocationSourceRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstInsuredLocationSourceRowChangeEventHandler lstInsuredLocationSourceRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstInsuredLocationSourceRow(dsInsured.lstInsuredLocationSourceRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstInsuredLocationSourceRow AddlstInsuredLocationSourceRow(
      byte ID,
      string Source)
    {
      dsInsured.lstInsuredLocationSourceRow row = (dsInsured.lstInsuredLocationSourceRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstInsuredLocationSourceRow FindByID(byte ID)
    {
      return (dsInsured.lstInsuredLocationSourceRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.lstInsuredLocationSourceDataTable locationSourceDataTable = (dsInsured.lstInsuredLocationSourceDataTable) base.Clone();
      locationSourceDataTable.InitVars();
      return (DataTable) locationSourceDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsured.lstInsuredLocationSourceDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnSource = this.Columns["Source"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstInsuredLocationSourceRow NewlstInsuredLocationSourceRow()
    {
      return (dsInsured.lstInsuredLocationSourceRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.lstInsuredLocationSourceRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.lstInsuredLocationSourceRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredLocationSourceRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstInsuredLocationSourceRowChangeEventHandler sourceRowChangedEvent = this.lstInsuredLocationSourceRowChangedEvent;
      if (sourceRowChangedEvent == null)
        return;
      sourceRowChangedEvent((object) this, new dsInsured.lstInsuredLocationSourceRowChangeEvent((dsInsured.lstInsuredLocationSourceRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredLocationSourceRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstInsuredLocationSourceRowChangeEventHandler rowChangingEvent = this.lstInsuredLocationSourceRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.lstInsuredLocationSourceRowChangeEvent((dsInsured.lstInsuredLocationSourceRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredLocationSourceRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstInsuredLocationSourceRowChangeEventHandler sourceRowDeletedEvent = this.lstInsuredLocationSourceRowDeletedEvent;
      if (sourceRowDeletedEvent == null)
        return;
      sourceRowDeletedEvent((object) this, new dsInsured.lstInsuredLocationSourceRowChangeEvent((dsInsured.lstInsuredLocationSourceRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredLocationSourceRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstInsuredLocationSourceRowChangeEventHandler rowDeletingEvent = this.lstInsuredLocationSourceRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.lstInsuredLocationSourceRowChangeEvent((dsInsured.lstInsuredLocationSourceRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstInsuredLocationSourceRow(dsInsured.lstInsuredLocationSourceRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstInsuredLocationSourceDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class tblUsersDataTable : TypedTableBase<dsInsured.tblUsersRow>
  {
    private DataColumn columnUserGUID;
    private DataColumn columnName_LastFirst;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblUsersDataTable()
    {
      this.TableName = "tblUsers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected tblUsersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UserGUIDColumn => this.columnUserGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Name_LastFirstColumn => this.columnName_LastFirst;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblUsersRow this[int index] => (dsInsured.tblUsersRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblUsersRowChangeEventHandler tblUsersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblUsersRowChangeEventHandler tblUsersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblUsersRowChangeEventHandler tblUsersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.tblUsersRowChangeEventHandler tblUsersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblUsersRow(dsInsured.tblUsersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblUsersRow AddtblUsersRow(Guid UserGUID, string Name_LastFirst)
    {
      dsInsured.tblUsersRow row = (dsInsured.tblUsersRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblUsersRow FindByUserGUID(Guid UserGUID)
    {
      return (dsInsured.tblUsersRow) this.Rows.Find(new object[1]
      {
        (object) UserGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.tblUsersDataTable tblUsersDataTable = (dsInsured.tblUsersDataTable) base.Clone();
      tblUsersDataTable.InitVars();
      return (DataTable) tblUsersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsInsured.tblUsersDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnUserGUID = this.Columns["UserGUID"];
      this.columnName_LastFirst = this.Columns["Name_LastFirst"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
      this.columnName_LastFirst.MaxLength = 102;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblUsersRow NewtblUsersRow() => (dsInsured.tblUsersRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.tblUsersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.tblUsersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblUsersRowChangeEventHandler usersRowChangedEvent = this.tblUsersRowChangedEvent;
      if (usersRowChangedEvent == null)
        return;
      usersRowChangedEvent((object) this, new dsInsured.tblUsersRowChangeEvent((dsInsured.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblUsersRowChangeEventHandler rowChangingEvent = this.tblUsersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.tblUsersRowChangeEvent((dsInsured.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblUsersRowChangeEventHandler usersRowDeletedEvent = this.tblUsersRowDeletedEvent;
      if (usersRowDeletedEvent == null)
        return;
      usersRowDeletedEvent((object) this, new dsInsured.tblUsersRowChangeEvent((dsInsured.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.tblUsersRowChangeEventHandler rowDeletingEvent = this.tblUsersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.tblUsersRowChangeEvent((dsInsured.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblUsersRow(dsInsured.tblUsersRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUsersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class lstProductionPotentialDataTable : TypedTableBase<dsInsured.lstProductionPotentialRow>
  {
    private DataColumn columnID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstProductionPotentialDataTable()
    {
      this.TableName = "lstProductionPotential";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected lstProductionPotentialDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstProductionPotentialRow this[int index]
    {
      get => (dsInsured.lstProductionPotentialRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstProductionPotentialRowChangeEventHandler lstProductionPotentialRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstProductionPotentialRowChangeEventHandler lstProductionPotentialRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstProductionPotentialRowChangeEventHandler lstProductionPotentialRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstProductionPotentialRowChangeEventHandler lstProductionPotentialRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstProductionPotentialRow(dsInsured.lstProductionPotentialRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstProductionPotentialRow AddlstProductionPotentialRow(
      string ID,
      string Description)
    {
      dsInsured.lstProductionPotentialRow row = (dsInsured.lstProductionPotentialRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstProductionPotentialRow FindByID(string ID)
    {
      return (dsInsured.lstProductionPotentialRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.lstProductionPotentialDataTable potentialDataTable = (dsInsured.lstProductionPotentialDataTable) base.Clone();
      potentialDataTable.InitVars();
      return (DataTable) potentialDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsured.lstProductionPotentialDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstProductionPotentialRow NewlstProductionPotentialRow()
    {
      return (dsInsured.lstProductionPotentialRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.lstProductionPotentialRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.lstProductionPotentialRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProductionPotentialRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstProductionPotentialRowChangeEventHandler potentialRowChangedEvent = this.lstProductionPotentialRowChangedEvent;
      if (potentialRowChangedEvent == null)
        return;
      potentialRowChangedEvent((object) this, new dsInsured.lstProductionPotentialRowChangeEvent((dsInsured.lstProductionPotentialRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProductionPotentialRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstProductionPotentialRowChangeEventHandler rowChangingEvent = this.lstProductionPotentialRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.lstProductionPotentialRowChangeEvent((dsInsured.lstProductionPotentialRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProductionPotentialRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstProductionPotentialRowChangeEventHandler potentialRowDeletedEvent = this.lstProductionPotentialRowDeletedEvent;
      if (potentialRowDeletedEvent == null)
        return;
      potentialRowDeletedEvent((object) this, new dsInsured.lstProductionPotentialRowChangeEvent((dsInsured.lstProductionPotentialRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProductionPotentialRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstProductionPotentialRowChangeEventHandler rowDeletingEvent = this.lstProductionPotentialRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.lstProductionPotentialRowChangeEvent((dsInsured.lstProductionPotentialRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstProductionPotentialRow(dsInsured.lstProductionPotentialRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstProductionPotentialDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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
  public class lstInsuredRankingsDataTable : TypedTableBase<dsInsured.lstInsuredRankingsRow>
  {
    private DataColumn columnID;
    private DataColumn columnInsuredRanking;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstInsuredRankingsDataTable()
    {
      this.TableName = "lstInsuredRankings";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstInsuredRankingsDataTable(DataTable table)
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
    protected lstInsuredRankingsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredRankingColumn => this.columnInsuredRanking;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstInsuredRankingsRow this[int index]
    {
      get => (dsInsured.lstInsuredRankingsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstInsuredRankingsRowChangeEventHandler lstInsuredRankingsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstInsuredRankingsRowChangeEventHandler lstInsuredRankingsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstInsuredRankingsRowChangeEventHandler lstInsuredRankingsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInsured.lstInsuredRankingsRowChangeEventHandler lstInsuredRankingsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstInsuredRankingsRow(dsInsured.lstInsuredRankingsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstInsuredRankingsRow AddlstInsuredRankingsRow(string InsuredRanking)
    {
      dsInsured.lstInsuredRankingsRow row = (dsInsured.lstInsuredRankingsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) InsuredRanking
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstInsuredRankingsRow FindByID(int ID)
    {
      return (dsInsured.lstInsuredRankingsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInsured.lstInsuredRankingsDataTable rankingsDataTable = (dsInsured.lstInsuredRankingsDataTable) base.Clone();
      rankingsDataTable.InitVars();
      return (DataTable) rankingsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsured.lstInsuredRankingsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnInsuredRanking = this.Columns["InsuredRanking"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnInsuredRanking = new DataColumn("InsuredRanking", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredRanking);
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
      this.columnInsuredRanking.AllowDBNull = false;
      this.columnInsuredRanking.Caption = "ProducerRanking";
      this.columnInsuredRanking.MaxLength = 75;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstInsuredRankingsRow NewlstInsuredRankingsRow()
    {
      return (dsInsured.lstInsuredRankingsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsured.lstInsuredRankingsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsured.lstInsuredRankingsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredRankingsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstInsuredRankingsRowChangeEventHandler rankingsRowChangedEvent = this.lstInsuredRankingsRowChangedEvent;
      if (rankingsRowChangedEvent == null)
        return;
      rankingsRowChangedEvent((object) this, new dsInsured.lstInsuredRankingsRowChangeEvent((dsInsured.lstInsuredRankingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredRankingsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstInsuredRankingsRowChangeEventHandler rowChangingEvent = this.lstInsuredRankingsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsured.lstInsuredRankingsRowChangeEvent((dsInsured.lstInsuredRankingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredRankingsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstInsuredRankingsRowChangeEventHandler rankingsRowDeletedEvent = this.lstInsuredRankingsRowDeletedEvent;
      if (rankingsRowDeletedEvent == null)
        return;
      rankingsRowDeletedEvent((object) this, new dsInsured.lstInsuredRankingsRowChangeEvent((dsInsured.lstInsuredRankingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredRankingsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsured.lstInsuredRankingsRowChangeEventHandler rowDeletingEvent = this.lstInsuredRankingsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsured.lstInsuredRankingsRowChangeEvent((dsInsured.lstInsuredRankingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstInsuredRankingsRow(dsInsured.lstInsuredRankingsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsured dsInsured = new dsInsured();
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
        FixedValue = dsInsured.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstInsuredRankingsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsured.GetSchemaSerializable();
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

  public class lstDeliveryMethodRow : DataRow
  {
    private dsInsured.lstDeliveryMethodDataTable tablelstDeliveryMethod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstDeliveryMethodRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstDeliveryMethod = (dsInsured.lstDeliveryMethodDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DeliveryMethodID
    {
      get => Conversions.ToInteger(this[this.tablelstDeliveryMethod.DeliveryMethodIDColumn]);
      set => this[this.tablelstDeliveryMethod.DeliveryMethodIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tablelstDeliveryMethod.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tablelstDeliveryMethod.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredLocationsRow[] GettblInsuredLocationsRows()
    {
      return this.Table.ChildRelations["lstDeliveryMethodtblInsuredLocations"] != null ? (dsInsured.tblInsuredLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstDeliveryMethodtblInsuredLocations"]) : new dsInsured.tblInsuredLocationsRow[0];
    }
  }

  public class tblInsuredsRow : DataRow
  {
    private dsInsured.tblInsuredsDataTable tabletblInsureds;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblInsuredsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblInsureds = (dsInsured.tblInsuredsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid InsuredGuid
    {
      get
      {
        object obj = this[this.tabletblInsureds.InsuredGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblInsureds.InsuredGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int BusinessTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsureds.BusinessTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BusinessTypeID' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.BusinessTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CorporationName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.CorporationNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CorporationName' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.CorporationNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int InsuredID
    {
      get => Conversions.ToInteger(this[this.tabletblInsureds.InsuredIDColumn]);
      set => this[this.tabletblInsureds.InsuredIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string FEIN
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.FEINColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FEIN' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.FEINColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int StatusID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsureds.StatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusID' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DBA
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.DBAColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DBA' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.DBAColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string SSN
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.SSNColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SSN' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.SSNColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Salutation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.SalutationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Salutation' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.SalutationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string FirstName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.FirstNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FirstName' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.FirstNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string MiddleName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.MiddleNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MiddleName' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.MiddleNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LastName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.LastNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LastName' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.LastNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Soundex
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.SoundexColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Soundex' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.SoundexColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.PolicyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyName' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.PolicyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DOB
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblInsureds.DOBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DOB' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.DOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string RiskID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.RiskIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RiskID' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.RiskIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CarrierId
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.CarrierIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CarrierId' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.CarrierIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string TaxID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.TaxIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TaxID' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.TaxIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DNBNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.DNBNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DNBNumber' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.DNBNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool OFACCleared
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblInsureds.OFACClearedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OFACCleared' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.OFACClearedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int GenderId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsureds.GenderIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GenderId' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.GenderIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StatusChangeReasonComment
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.StatusChangeReasonCommentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusChangeReasonComment' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.StatusChangeReasonCommentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime OfacClearedDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblInsureds.OfacClearedDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfacClearedDate' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.OfacClearedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool OptOut
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblInsureds.OptOutColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OptOut' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.OptOutColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstBusinessTypesRow lstBusinessTypesRow
    {
      get
      {
        return (dsInsured.lstBusinessTypesRow) this.GetParentRow(this.Table.ParentRelations["lstBusinessTypestblInsureds"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstBusinessTypestblInsureds"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstStatusRow lstStatusRow
    {
      get
      {
        return (dsInsured.lstStatusRow) this.GetParentRow(this.Table.ParentRelations["lstStatustblInsureds"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstStatustblInsureds"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstSalutationsRow lstSalutationsRow
    {
      get
      {
        return (dsInsured.lstSalutationsRow) this.GetParentRow(this.Table.ParentRelations["lstSalutationstblInsureds"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstSalutationstblInsureds"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstClaims_GenderRow lstClaims_GenderRow
    {
      get
      {
        return (dsInsured.lstClaims_GenderRow) this.GetParentRow(this.Table.ParentRelations["lstClaims_Gender_tblInsureds"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstClaims_Gender_tblInsureds"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBusinessTypeIDNull() => this.IsNull(this.tabletblInsureds.BusinessTypeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBusinessTypeIDNull()
    {
      this[this.tabletblInsureds.BusinessTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCorporationNameNull() => this.IsNull(this.tabletblInsureds.CorporationNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCorporationNameNull()
    {
      this[this.tabletblInsureds.CorporationNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFEINNull() => this.IsNull(this.tabletblInsureds.FEINColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFEINNull()
    {
      this[this.tabletblInsureds.FEINColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStatusIDNull() => this.IsNull(this.tabletblInsureds.StatusIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatusIDNull()
    {
      this[this.tabletblInsureds.StatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDBANull() => this.IsNull(this.tabletblInsureds.DBAColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDBANull()
    {
      this[this.tabletblInsureds.DBAColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSSNNull() => this.IsNull(this.tabletblInsureds.SSNColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSSNNull()
    {
      this[this.tabletblInsureds.SSNColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSalutationNull() => this.IsNull(this.tabletblInsureds.SalutationColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSalutationNull()
    {
      this[this.tabletblInsureds.SalutationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFirstNameNull() => this.IsNull(this.tabletblInsureds.FirstNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFirstNameNull()
    {
      this[this.tabletblInsureds.FirstNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMiddleNameNull() => this.IsNull(this.tabletblInsureds.MiddleNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMiddleNameNull()
    {
      this[this.tabletblInsureds.MiddleNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLastNameNull() => this.IsNull(this.tabletblInsureds.LastNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLastNameNull()
    {
      this[this.tabletblInsureds.LastNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSoundexNull() => this.IsNull(this.tabletblInsureds.SoundexColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSoundexNull()
    {
      this[this.tabletblInsureds.SoundexColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyNameNull() => this.IsNull(this.tabletblInsureds.PolicyNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyNameNull()
    {
      this[this.tabletblInsureds.PolicyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDOBNull() => this.IsNull(this.tabletblInsureds.DOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDOBNull()
    {
      this[this.tabletblInsureds.DOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRiskIDNull() => this.IsNull(this.tabletblInsureds.RiskIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRiskIDNull()
    {
      this[this.tabletblInsureds.RiskIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCarrierIdNull() => this.IsNull(this.tabletblInsureds.CarrierIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCarrierIdNull()
    {
      this[this.tabletblInsureds.CarrierIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTaxIDNull() => this.IsNull(this.tabletblInsureds.TaxIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTaxIDNull()
    {
      this[this.tabletblInsureds.TaxIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDNBNumberNull() => this.IsNull(this.tabletblInsureds.DNBNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDNBNumberNull()
    {
      this[this.tabletblInsureds.DNBNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOFACClearedNull() => this.IsNull(this.tabletblInsureds.OFACClearedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOFACClearedNull()
    {
      this[this.tabletblInsureds.OFACClearedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsGenderIdNull() => this.IsNull(this.tabletblInsureds.GenderIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetGenderIdNull()
    {
      this[this.tabletblInsureds.GenderIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStatusChangeReasonCommentNull()
    {
      return this.IsNull(this.tabletblInsureds.StatusChangeReasonCommentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatusChangeReasonCommentNull()
    {
      this[this.tabletblInsureds.StatusChangeReasonCommentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOfacClearedDateNull() => this.IsNull(this.tabletblInsureds.OfacClearedDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOfacClearedDateNull()
    {
      this[this.tabletblInsureds.OfacClearedDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOptOutNull() => this.IsNull(this.tabletblInsureds.OptOutColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOptOutNull()
    {
      this[this.tabletblInsureds.OptOutColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.InvoicesRow[] GetInvoicesRows()
    {
      return this.Table.ChildRelations["tblInsuredsInvoices"] != null ? (dsInsured.InvoicesRow[]) this.GetChildRows(this.Table.ChildRelations["tblInsuredsInvoices"]) : new dsInsured.InvoicesRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredLocationsRow[] GettblInsuredLocationsRows()
    {
      return this.Table.ChildRelations["tblInsuredstblInsuredLocations"] != null ? (dsInsured.tblInsuredLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["tblInsuredstblInsuredLocations"]) : new dsInsured.tblInsuredLocationsRow[0];
    }
  }

  public class tblInsuredLocationsRow : DataRow
  {
    private dsInsured.tblInsuredLocationsDataTable tabletblInsuredLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblInsuredLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblInsuredLocations = (dsInsured.tblInsuredLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid InsuredLocationGuid
    {
      get
      {
        object obj = this[this.tabletblInsuredLocations.InsuredLocationGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblInsuredLocations.InsuredLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid InsuredGuid
    {
      get
      {
        object obj = this[this.tabletblInsuredLocations.InsuredGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblInsuredLocations.InsuredGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address1' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address2' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string County
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.CountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'County' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.CountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.ZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipPlus' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.ZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Phone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.PhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Phone' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Fax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.FaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fax' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.FaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string WebSite
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.WebSiteColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WebSite' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.WebSiteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int LocationTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsuredLocations.LocationTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationTypeID' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.LocationTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DeliveryMethodID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsuredLocations.DeliveryMethodIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeliveryMethodID' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.DeliveryMethodIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateAdded
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblInsuredLocations.DateAddedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateAdded' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.DateAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int InsuredID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsuredLocations.InsuredIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredID' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.InsuredIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Hidden
    {
      get => Conversions.ToBoolean(this[this.tabletblInsuredLocations.HiddenColumn]);
      set => this[this.tabletblInsuredLocations.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.EmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Email' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string _Region
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.RegionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Region' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.RegionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ISOCountryCode
    {
      get => Conversions.ToString(this[this.tabletblInsuredLocations.ISOCountryCodeColumn]);
      set => this[this.tabletblInsuredLocations.ISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid AddedBy
    {
      get
      {
        try
        {
          object obj = this[this.tabletblInsuredLocations.AddedByColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddedBy' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.AddedByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Name_LastFirst
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.Name_LastFirstColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name_LastFirst' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.Name_LastFirstColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string MobileNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.MobileNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MobileNumber' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.MobileNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int NumEmployees
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsuredLocations.NumEmployeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumEmployees' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.NumEmployeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal GrossWrittenPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblInsuredLocations.GrossWrittenPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GrossWrittenPremium' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.GrossWrittenPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public short LocationSource
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblInsuredLocations.LocationSourceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationSource' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.LocationSourceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid Owner
    {
      get
      {
        try
        {
          object obj = this[this.tabletblInsuredLocations.OwnerColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Owner' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.OwnerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProductionPotential
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.ProductionPotentialColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProductionPotential' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.ProductionPotentialColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ProducerRankingID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsuredLocations.ProducerRankingIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerRankingID' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.ProducerRankingIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int NumWholesaleRelationship
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsuredLocations.NumWholesaleRelationshipColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumWholesaleRelationship' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.NumWholesaleRelationshipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime AgreementEffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblInsuredLocations.AgreementEffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AgreementEffectiveDate' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.AgreementEffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool SetProcedureToEnage
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblInsuredLocations.SetProcedureToEnageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SetProcedureToEnage' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.SetProcedureToEnageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool ApproveWholesalersList
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblInsuredLocations.ApproveWholesalersListColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ApproveWholesalersList' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.ApproveWholesalersListColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ReferredBYProdLocation
    {
      get
      {
        try
        {
          object obj = this[this.tabletblInsuredLocations.ReferredBYProdLocationColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ReferredBYProdLocation' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.ReferredBYProdLocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string SpecFocusDept
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.SpecFocusDeptColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SpecFocusDept' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.SpecFocusDeptColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Expertise
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.ExpertiseColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Expertise' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.ExpertiseColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string WholesaleRelationships
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.WholesaleRelationshipsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WholesaleRelationships' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.WholesaleRelationshipsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool OptOut
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblInsuredLocations.OptOutColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OptOut' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.OptOutColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CountryCodeforPhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.CountryCodeforPhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CountryCodeforPhone' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.CountryCodeforPhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CountryCodeforFax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.CountryCodeforFaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CountryCodeforFax' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.CountryCodeforFaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CountryCodeforMobile
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredLocations.CountryCodeforMobileColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CountryCodeforMobile' in table 'tblInsuredLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredLocations.CountryCodeforMobileColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredsRow tblInsuredsRow
    {
      get
      {
        return (dsInsured.tblInsuredsRow) this.GetParentRow(this.Table.ParentRelations["tblInsuredstblInsuredLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblInsuredstblInsuredLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstDeliveryMethodRow lstDeliveryMethodRow
    {
      get
      {
        return (dsInsured.lstDeliveryMethodRow) this.GetParentRow(this.Table.ParentRelations["lstDeliveryMethodtblInsuredLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstDeliveryMethodtblInsuredLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstLocationTypeRow lstLocationTypeRow
    {
      get
      {
        return (dsInsured.lstLocationTypeRow) this.GetParentRow(this.Table.ParentRelations["lstLocationTypetblInsuredLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstLocationTypetblInsuredLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabletblInsuredLocations.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabletblInsuredLocations.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddress1Null() => this.IsNull(this.tabletblInsuredLocations.Address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabletblInsuredLocations.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddress2Null() => this.IsNull(this.tabletblInsuredLocations.Address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabletblInsuredLocations.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabletblInsuredLocations.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabletblInsuredLocations.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCountyNull() => this.IsNull(this.tabletblInsuredLocations.CountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCountyNull()
    {
      this[this.tabletblInsuredLocations.CountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsZipPlusNull() => this.IsNull(this.tabletblInsuredLocations.ZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetZipPlusNull()
    {
      this[this.tabletblInsuredLocations.ZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPhoneNull() => this.IsNull(this.tabletblInsuredLocations.PhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPhoneNull()
    {
      this[this.tabletblInsuredLocations.PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFaxNull() => this.IsNull(this.tabletblInsuredLocations.FaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFaxNull()
    {
      this[this.tabletblInsuredLocations.FaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsWebSiteNull() => this.IsNull(this.tabletblInsuredLocations.WebSiteColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetWebSiteNull()
    {
      this[this.tabletblInsuredLocations.WebSiteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLocationTypeIDNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.LocationTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLocationTypeIDNull()
    {
      this[this.tabletblInsuredLocations.LocationTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDeliveryMethodIDNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.DeliveryMethodIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDeliveryMethodIDNull()
    {
      this[this.tabletblInsuredLocations.DeliveryMethodIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateAddedNull() => this.IsNull(this.tabletblInsuredLocations.DateAddedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateAddedNull()
    {
      this[this.tabletblInsuredLocations.DateAddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredIDNull() => this.IsNull(this.tabletblInsuredLocations.InsuredIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredIDNull()
    {
      this[this.tabletblInsuredLocations.InsuredIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabletblInsuredLocations.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabletblInsuredLocations.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tabletblInsuredLocations.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tabletblInsuredLocations.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tabletblInsuredLocations.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEmailNull()
    {
      this[this.tabletblInsuredLocations.EmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Is_RegionNull() => this.IsNull(this.tabletblInsuredLocations.RegionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void Set_RegionNull()
    {
      this[this.tabletblInsuredLocations.RegionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddedByNull() => this.IsNull(this.tabletblInsuredLocations.AddedByColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddedByNull()
    {
      this[this.tabletblInsuredLocations.AddedByColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsName_LastFirstNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.Name_LastFirstColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetName_LastFirstNull()
    {
      this[this.tabletblInsuredLocations.Name_LastFirstColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMobileNumberNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.MobileNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMobileNumberNull()
    {
      this[this.tabletblInsuredLocations.MobileNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNumEmployeesNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.NumEmployeesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNumEmployeesNull()
    {
      this[this.tabletblInsuredLocations.NumEmployeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsGrossWrittenPremiumNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.GrossWrittenPremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetGrossWrittenPremiumNull()
    {
      this[this.tabletblInsuredLocations.GrossWrittenPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLocationSourceNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.LocationSourceColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLocationSourceNull()
    {
      this[this.tabletblInsuredLocations.LocationSourceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOwnerNull() => this.IsNull(this.tabletblInsuredLocations.OwnerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOwnerNull()
    {
      this[this.tabletblInsuredLocations.OwnerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProductionPotentialNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.ProductionPotentialColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProductionPotentialNull()
    {
      this[this.tabletblInsuredLocations.ProductionPotentialColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerRankingIDNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.ProducerRankingIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerRankingIDNull()
    {
      this[this.tabletblInsuredLocations.ProducerRankingIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNumWholesaleRelationshipNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.NumWholesaleRelationshipColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNumWholesaleRelationshipNull()
    {
      this[this.tabletblInsuredLocations.NumWholesaleRelationshipColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAgreementEffectiveDateNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.AgreementEffectiveDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAgreementEffectiveDateNull()
    {
      this[this.tabletblInsuredLocations.AgreementEffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSetProcedureToEnageNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.SetProcedureToEnageColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSetProcedureToEnageNull()
    {
      this[this.tabletblInsuredLocations.SetProcedureToEnageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsApproveWholesalersListNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.ApproveWholesalersListColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetApproveWholesalersListNull()
    {
      this[this.tabletblInsuredLocations.ApproveWholesalersListColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsReferredBYProdLocationNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.ReferredBYProdLocationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetReferredBYProdLocationNull()
    {
      this[this.tabletblInsuredLocations.ReferredBYProdLocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSpecFocusDeptNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.SpecFocusDeptColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSpecFocusDeptNull()
    {
      this[this.tabletblInsuredLocations.SpecFocusDeptColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsExpertiseNull() => this.IsNull(this.tabletblInsuredLocations.ExpertiseColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetExpertiseNull()
    {
      this[this.tabletblInsuredLocations.ExpertiseColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsWholesaleRelationshipsNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.WholesaleRelationshipsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetWholesaleRelationshipsNull()
    {
      this[this.tabletblInsuredLocations.WholesaleRelationshipsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOptOutNull() => this.IsNull(this.tabletblInsuredLocations.OptOutColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOptOutNull()
    {
      this[this.tabletblInsuredLocations.OptOutColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCountryCodeforPhoneNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.CountryCodeforPhoneColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCountryCodeforPhoneNull()
    {
      this[this.tabletblInsuredLocations.CountryCodeforPhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCountryCodeforFaxNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.CountryCodeforFaxColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCountryCodeforFaxNull()
    {
      this[this.tabletblInsuredLocations.CountryCodeforFaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCountryCodeforMobileNull()
    {
      return this.IsNull(this.tabletblInsuredLocations.CountryCodeforMobileColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCountryCodeforMobileNull()
    {
      this[this.tabletblInsuredLocations.CountryCodeforMobileColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredContactsRow[] GettblInsuredContactsRows()
    {
      return this.Table.ChildRelations["tblInsuredLocationstblInsuredContacts"] != null ? (dsInsured.tblInsuredContactsRow[]) this.GetChildRows(this.Table.ChildRelations["tblInsuredLocationstblInsuredContacts"]) : new dsInsured.tblInsuredContactsRow[0];
    }
  }

  public class tblInsuredContactsRow : DataRow
  {
    private dsInsured.tblInsuredContactsDataTable tabletblInsuredContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblInsuredContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblInsuredContacts = (dsInsured.tblInsuredContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid InsuredContactGuid
    {
      get
      {
        object obj = this[this.tabletblInsuredContacts.InsuredContactGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblInsuredContacts.InsuredContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid InsuredLocationGuid
    {
      get
      {
        object obj = this[this.tabletblInsuredContacts.InsuredLocationGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblInsuredContacts.InsuredLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredContacts.NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name' in table 'tblInsuredContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredContacts.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int StatusID
    {
      get => Conversions.ToInteger(this[this.tabletblInsuredContacts.StatusIDColumn]);
      set => this[this.tabletblInsuredContacts.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredLocationsRow tblInsuredLocationsRow
    {
      get
      {
        return (dsInsured.tblInsuredLocationsRow) this.GetParentRow(this.Table.ParentRelations["tblInsuredLocationstblInsuredContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblInsuredLocationstblInsuredContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabletblInsuredContacts.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabletblInsuredContacts.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstBusinessTypesRow : DataRow
  {
    private dsInsured.lstBusinessTypesDataTable tablelstBusinessTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstBusinessTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstBusinessTypes = (dsInsured.lstBusinessTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int BusinessTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstBusinessTypes.BusinessTypeIDColumn]);
      set => this[this.tablelstBusinessTypes.BusinessTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BusinessType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstBusinessTypes.BusinessTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BusinessType' in table 'lstBusinessTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstBusinessTypes.BusinessTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Individual
    {
      get => Conversions.ToBoolean(this[this.tablelstBusinessTypes.IndividualColumn]);
      set => this[this.tablelstBusinessTypes.IndividualColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBusinessTypeNull() => this.IsNull(this.tablelstBusinessTypes.BusinessTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBusinessTypeNull()
    {
      this[this.tablelstBusinessTypes.BusinessTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredsRow[] GettblInsuredsRows()
    {
      return this.Table.ChildRelations["lstBusinessTypestblInsureds"] != null ? (dsInsured.tblInsuredsRow[]) this.GetChildRows(this.Table.ChildRelations["lstBusinessTypestblInsureds"]) : new dsInsured.tblInsuredsRow[0];
    }
  }

  public class lstLocationTypeRow : DataRow
  {
    private dsInsured.lstLocationTypeDataTable tablelstLocationType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstLocationTypeRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstLocationType = (dsInsured.lstLocationTypeDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int LocationTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstLocationType.LocationTypeIDColumn]);
      set => this[this.tablelstLocationType.LocationTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LocationType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstLocationType.LocationTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationType' in table 'lstLocationType' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstLocationType.LocationTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLocationTypeNull() => this.IsNull(this.tablelstLocationType.LocationTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLocationTypeNull()
    {
      this[this.tablelstLocationType.LocationTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredLocationsRow[] GettblInsuredLocationsRows()
    {
      return this.Table.ChildRelations["lstLocationTypetblInsuredLocations"] != null ? (dsInsured.tblInsuredLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstLocationTypetblInsuredLocations"]) : new dsInsured.tblInsuredLocationsRow[0];
    }
  }

  public class lstStatusRow : DataRow
  {
    private dsInsured.lstStatusDataTable tablelstStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstStatusRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStatus = (dsInsured.lstStatusDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int StatusID
    {
      get => Conversions.ToInteger(this[this.tablelstStatus.StatusIDColumn]);
      set => this[this.tablelstStatus.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StatusCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstStatus.StatusCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusCode' in table 'lstStatus' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstStatus.StatusCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Disable
    {
      get => Conversions.ToBoolean(this[this.tablelstStatus.DisableColumn]);
      set => this[this.tablelstStatus.DisableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStatusCodeNull() => this.IsNull(this.tablelstStatus.StatusCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatusCodeNull()
    {
      this[this.tablelstStatus.StatusCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStatusNull() => this.IsNull(this.tablelstStatus.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatusNull()
    {
      this[this.tablelstStatus.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredsRow[] GettblInsuredsRows()
    {
      return this.Table.ChildRelations["lstStatustblInsureds"] != null ? (dsInsured.tblInsuredsRow[]) this.GetChildRows(this.Table.ChildRelations["lstStatustblInsureds"]) : new dsInsured.tblInsuredsRow[0];
    }
  }

  public class lstSalutationsRow : DataRow
  {
    private dsInsured.lstSalutationsDataTable tablelstSalutations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstSalutationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstSalutations = (dsInsured.lstSalutationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Salutation
    {
      get => Conversions.ToString(this[this.tablelstSalutations.SalutationColumn]);
      set => this[this.tablelstSalutations.SalutationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredsRow[] GettblInsuredsRows()
    {
      return this.Table.ChildRelations["lstSalutationstblInsureds"] != null ? (dsInsured.tblInsuredsRow[]) this.GetChildRows(this.Table.ChildRelations["lstSalutationstblInsureds"]) : new dsInsured.tblInsuredsRow[0];
    }
  }

  public class InvoicesRow : DataRow
  {
    private dsInsured.InvoicesDataTable tableInvoices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal InvoicesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoices = (dsInsured.InvoicesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public double AmtBilled
    {
      get => Conversions.ToDouble(this[this.tableInvoices.AmtBilledColumn]);
      set => this[this.tableInvoices.AmtBilledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DueDate
    {
      get => Conversions.ToDate(this[this.tableInvoices.DueDateColumn]);
      set => this[this.tableInvoices.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OfficeInvoiceNum
    {
      get => Conversions.ToInteger(this[this.tableInvoices.OfficeInvoiceNumColumn]);
      set => this[this.tableInvoices.OfficeInvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid InsuredGuid
    {
      get
      {
        object obj = this[this.tableInvoices.InsuredGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableInvoices.InsuredGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string View
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoices.ViewColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'View' in table 'Invoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoices.ViewColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime InvoiceDate
    {
      get => Conversions.ToDate(this[this.tableInvoices.InvoiceDateColumn]);
      set => this[this.tableInvoices.InvoiceDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoices.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'Invoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoices.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int InvoiceNum
    {
      get => Conversions.ToInteger(this[this.tableInvoices.InvoiceNumColumn]);
      set => this[this.tableInvoices.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredsRow tblInsuredsRow
    {
      get
      {
        return (dsInsured.tblInsuredsRow) this.GetParentRow(this.Table.ParentRelations["tblInsuredsInvoices"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblInsuredsInvoices"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsViewNull() => this.IsNull(this.tableInvoices.ViewColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetViewNull()
    {
      this[this.tableInvoices.ViewColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tableInvoices.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tableInvoices.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstClaims_GenderRow : DataRow
  {
    private dsInsured.lstClaims_GenderDataTable tablelstClaims_Gender;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstClaims_GenderRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstClaims_Gender = (dsInsured.lstClaims_GenderDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int GenderId
    {
      get => Conversions.ToInteger(this[this.tablelstClaims_Gender.GenderIdColumn]);
      set => this[this.tablelstClaims_Gender.GenderIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Gender
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstClaims_Gender.GenderColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Gender' in table 'lstClaims_Gender' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstClaims_Gender.GenderColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsGenderNull() => this.IsNull(this.tablelstClaims_Gender.GenderColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetGenderNull()
    {
      this[this.tablelstClaims_Gender.GenderColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredsRow[] GettblInsuredsRows()
    {
      return this.Table.ChildRelations["lstClaims_Gender_tblInsureds"] != null ? (dsInsured.tblInsuredsRow[]) this.GetChildRows(this.Table.ChildRelations["lstClaims_Gender_tblInsureds"]) : new dsInsured.tblInsuredsRow[0];
    }
  }

  public class CompanyLinesRow : DataRow
  {
    private dsInsured.CompanyLinesDataTable tableCompanyLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal CompanyLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCompanyLines = (dsInsured.CompanyLinesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        try
        {
          object obj = this[this.tableCompanyLines.CompanyLineGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLineGuid' in table 'CompanyLines' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyLines.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CompanyLine
    {
      get => Conversions.ToString(this[this.tableCompanyLines.CompanyLineColumn]);
      set => this[this.tableCompanyLines.CompanyLineColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyLineGuidNull()
    {
      return this.IsNull(this.tableCompanyLines.CompanyLineGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyLineGuidNull()
    {
      this[this.tableCompanyLines.CompanyLineGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblInsuredCallReportRow : DataRow
  {
    private dsInsured.tblInsuredCallReportDataTable tabletblInsuredCallReport;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblInsuredCallReportRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblInsuredCallReport = (dsInsured.tblInsuredCallReportDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CallReportID
    {
      get => Conversions.ToInteger(this[this.tabletblInsuredCallReport.CallReportIDColumn]);
      set => this[this.tabletblInsuredCallReport.CallReportIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateOfVisit
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblInsuredCallReport.DateOfVisitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateOfVisit' in table 'tblInsuredCallReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReport.DateOfVisitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CallType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredCallReport.CallTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CallType' in table 'tblInsuredCallReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReport.CallTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LeadContact
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredCallReport.LeadContactColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LeadContact' in table 'tblInsuredCallReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReport.LeadContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid InsuredLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblInsuredCallReport.InsuredLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredLocationGuid' in table 'tblInsuredCallReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReport.InsuredLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateOfVisitNull()
    {
      return this.IsNull(this.tabletblInsuredCallReport.DateOfVisitColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateOfVisitNull()
    {
      this[this.tabletblInsuredCallReport.DateOfVisitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCallTypeNull() => this.IsNull(this.tabletblInsuredCallReport.CallTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCallTypeNull()
    {
      this[this.tabletblInsuredCallReport.CallTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLeadContactNull()
    {
      return this.IsNull(this.tabletblInsuredCallReport.LeadContactColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLeadContactNull()
    {
      this[this.tabletblInsuredCallReport.LeadContactColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredLocationGuidNull()
    {
      return this.IsNull(this.tabletblInsuredCallReport.InsuredLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredLocationGuidNull()
    {
      this[this.tabletblInsuredCallReport.InsuredLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblProducersRow : DataRow
  {
    private dsInsured.tblProducersDataTable tabletblProducers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducers = (dsInsured.tblProducersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerNameNull() => this.IsNull(this.tabletblProducers.ProducerNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerNameNull()
    {
      this[this.tabletblProducers.ProducerNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstInsuredLocationSourceRow : DataRow
  {
    private dsInsured.lstInsuredLocationSourceDataTable tablelstInsuredLocationSource;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstInsuredLocationSourceRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstInsuredLocationSource = (dsInsured.lstInsuredLocationSourceDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public byte ID
    {
      get => Conversions.ToByte(this[this.tablelstInsuredLocationSource.IDColumn]);
      set => this[this.tablelstInsuredLocationSource.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Source
    {
      get => Conversions.ToString(this[this.tablelstInsuredLocationSource.SourceColumn]);
      set => this[this.tablelstInsuredLocationSource.SourceColumn] = (object) value;
    }
  }

  public class tblUsersRow : DataRow
  {
    private dsInsured.tblUsersDataTable tabletblUsers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblUsersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUsers = (dsInsured.tblUsersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsName_LastFirstNull() => this.IsNull(this.tabletblUsers.Name_LastFirstColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetName_LastFirstNull()
    {
      this[this.tabletblUsers.Name_LastFirstColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstProductionPotentialRow : DataRow
  {
    private dsInsured.lstProductionPotentialDataTable tablelstProductionPotential;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstProductionPotentialRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstProductionPotential = (dsInsured.lstProductionPotentialDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ID
    {
      get => Conversions.ToString(this[this.tablelstProductionPotential.IDColumn]);
      set => this[this.tablelstProductionPotential.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstProductionPotential.DescriptionColumn]);
      set => this[this.tablelstProductionPotential.DescriptionColumn] = (object) value;
    }
  }

  public class lstInsuredRankingsRow : DataRow
  {
    private dsInsured.lstInsuredRankingsDataTable tablelstInsuredRankings;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstInsuredRankingsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstInsuredRankings = (dsInsured.lstInsuredRankingsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstInsuredRankings.IDColumn]);
      set => this[this.tablelstInsuredRankings.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredRanking
    {
      get => Conversions.ToString(this[this.tablelstInsuredRankings.InsuredRankingColumn]);
      set => this[this.tablelstInsuredRankings.InsuredRankingColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstDeliveryMethodRowChangeEvent : EventArgs
  {
    private dsInsured.lstDeliveryMethodRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstDeliveryMethodRowChangeEvent(dsInsured.lstDeliveryMethodRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstDeliveryMethodRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblInsuredsRowChangeEvent : EventArgs
  {
    private dsInsured.tblInsuredsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblInsuredsRowChangeEvent(dsInsured.tblInsuredsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblInsuredLocationsRowChangeEvent : EventArgs
  {
    private dsInsured.tblInsuredLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblInsuredLocationsRowChangeEvent(
      dsInsured.tblInsuredLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblInsuredContactsRowChangeEvent : EventArgs
  {
    private dsInsured.tblInsuredContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblInsuredContactsRowChangeEvent(
      dsInsured.tblInsuredContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstBusinessTypesRowChangeEvent : EventArgs
  {
    private dsInsured.lstBusinessTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstBusinessTypesRowChangeEvent(dsInsured.lstBusinessTypesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstBusinessTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstLocationTypeRowChangeEvent : EventArgs
  {
    private dsInsured.lstLocationTypeRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstLocationTypeRowChangeEvent(dsInsured.lstLocationTypeRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstLocationTypeRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstStatusRowChangeEvent : EventArgs
  {
    private dsInsured.lstStatusRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstStatusRowChangeEvent(dsInsured.lstStatusRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstStatusRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstSalutationsRowChangeEvent : EventArgs
  {
    private dsInsured.lstSalutationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstSalutationsRowChangeEvent(dsInsured.lstSalutationsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstSalutationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class InvoicesRowChangeEvent : EventArgs
  {
    private dsInsured.InvoicesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public InvoicesRowChangeEvent(dsInsured.InvoicesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.InvoicesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstClaims_GenderRowChangeEvent : EventArgs
  {
    private dsInsured.lstClaims_GenderRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstClaims_GenderRowChangeEvent(dsInsured.lstClaims_GenderRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstClaims_GenderRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class CompanyLinesRowChangeEvent : EventArgs
  {
    private dsInsured.CompanyLinesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public CompanyLinesRowChangeEvent(dsInsured.CompanyLinesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.CompanyLinesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblInsuredCallReportRowChangeEvent : EventArgs
  {
    private dsInsured.tblInsuredCallReportRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblInsuredCallReportRowChangeEvent(
      dsInsured.tblInsuredCallReportRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblInsuredCallReportRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblProducersRowChangeEvent : EventArgs
  {
    private dsInsured.tblProducersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducersRowChangeEvent(dsInsured.tblProducersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblProducersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstInsuredLocationSourceRowChangeEvent : EventArgs
  {
    private dsInsured.lstInsuredLocationSourceRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstInsuredLocationSourceRowChangeEvent(
      dsInsured.lstInsuredLocationSourceRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstInsuredLocationSourceRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblUsersRowChangeEvent : EventArgs
  {
    private dsInsured.tblUsersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblUsersRowChangeEvent(dsInsured.tblUsersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.tblUsersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstProductionPotentialRowChangeEvent : EventArgs
  {
    private dsInsured.lstProductionPotentialRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstProductionPotentialRowChangeEvent(
      dsInsured.lstProductionPotentialRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstProductionPotentialRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstInsuredRankingsRowChangeEvent : EventArgs
  {
    private dsInsured.lstInsuredRankingsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstInsuredRankingsRowChangeEvent(
      dsInsured.lstInsuredRankingsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInsured.lstInsuredRankingsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
