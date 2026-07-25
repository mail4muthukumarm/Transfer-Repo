// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.dsCompanyPolicyFees
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCompanyPolicyFees")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyPolicyFees : DataSet
{
  private dsCompanyPolicyFees.lstFeeTypesDataTable tablelstFeeTypes;
  private dsCompanyPolicyFees.tblClientOfficesDataTable tabletblClientOffices;
  private dsCompanyPolicyFees.tblCompanyPolicyChargesDataTable tabletblCompanyPolicyCharges;
  private dsCompanyPolicyFees.tblFin_PolicyChargesDataTable tabletblFin_PolicyCharges;
  private dsCompanyPolicyFees.lstFeeAppliesToPaymentDataTable tablelstFeeAppliesToPayment;
  private dsCompanyPolicyFees.tblCompanyLocationsDataTable tabletblCompanyLocations;
  private dsCompanyPolicyFees.lstStatesDataTable tablelstStates;
  private dsCompanyPolicyFees.lstLinesDataTable tablelstLines;
  private dsCompanyPolicyFees.lstCompanyLicenseTypesDataTable tablelstCompanyLicenseTypes;
  private dsCompanyPolicyFees.tblKentuckyCitiesDataTable tabletblKentuckyCities;
  private dsCompanyPolicyFees.tblUsersDataTable tabletblUsers;
  private dsCompanyPolicyFees.lstPolicyTypesDataTable tablelstPolicyTypes;
  private dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesDataTable tabletblCompanyPolicyChargesPolicyTypes;
  private DataRelation relationlstCompanyLicenseTypestblCompanyPolicyCharges;
  private DataRelation relationlstStatestblCompanyPolicyCharges;
  private DataRelation relationtblCompanyLocationstblCompanyPolicyCharges;
  private DataRelation relationlstLinestblCompanyPolicyCharges;
  private DataRelation relationlstFeeAppliesToPaymenttblCompanyPolicyCharges;
  private DataRelation relationlstFeeTypestblCompanyPolicyCharges;
  private DataRelation relationtblKentuckyCities_tblCompanyPolicyCharges;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsCompanyPolicyFees()
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
  protected dsCompanyPolicyFees(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstFeeTypes)] != null)
          base.Tables.Add((DataTable) new dsCompanyPolicyFees.lstFeeTypesDataTable(dataSet.Tables[nameof (lstFeeTypes)]));
        if (dataSet.Tables[nameof (tblClientOffices)] != null)
          base.Tables.Add((DataTable) new dsCompanyPolicyFees.tblClientOfficesDataTable(dataSet.Tables[nameof (tblClientOffices)]));
        if (dataSet.Tables[nameof (tblCompanyPolicyCharges)] != null)
          base.Tables.Add((DataTable) new dsCompanyPolicyFees.tblCompanyPolicyChargesDataTable(dataSet.Tables[nameof (tblCompanyPolicyCharges)]));
        if (dataSet.Tables[nameof (tblFin_PolicyCharges)] != null)
          base.Tables.Add((DataTable) new dsCompanyPolicyFees.tblFin_PolicyChargesDataTable(dataSet.Tables[nameof (tblFin_PolicyCharges)]));
        if (dataSet.Tables[nameof (lstFeeAppliesToPayment)] != null)
          base.Tables.Add((DataTable) new dsCompanyPolicyFees.lstFeeAppliesToPaymentDataTable(dataSet.Tables[nameof (lstFeeAppliesToPayment)]));
        if (dataSet.Tables[nameof (tblCompanyLocations)] != null)
          base.Tables.Add((DataTable) new dsCompanyPolicyFees.tblCompanyLocationsDataTable(dataSet.Tables[nameof (tblCompanyLocations)]));
        if (dataSet.Tables[nameof (lstStates)] != null)
          base.Tables.Add((DataTable) new dsCompanyPolicyFees.lstStatesDataTable(dataSet.Tables[nameof (lstStates)]));
        if (dataSet.Tables[nameof (lstLines)] != null)
          base.Tables.Add((DataTable) new dsCompanyPolicyFees.lstLinesDataTable(dataSet.Tables[nameof (lstLines)]));
        if (dataSet.Tables[nameof (lstCompanyLicenseTypes)] != null)
          base.Tables.Add((DataTable) new dsCompanyPolicyFees.lstCompanyLicenseTypesDataTable(dataSet.Tables[nameof (lstCompanyLicenseTypes)]));
        if (dataSet.Tables[nameof (tblKentuckyCities)] != null)
          base.Tables.Add((DataTable) new dsCompanyPolicyFees.tblKentuckyCitiesDataTable(dataSet.Tables[nameof (tblKentuckyCities)]));
        if (dataSet.Tables[nameof (tblUsers)] != null)
          base.Tables.Add((DataTable) new dsCompanyPolicyFees.tblUsersDataTable(dataSet.Tables[nameof (tblUsers)]));
        if (dataSet.Tables[nameof (lstPolicyTypes)] != null)
          base.Tables.Add((DataTable) new dsCompanyPolicyFees.lstPolicyTypesDataTable(dataSet.Tables[nameof (lstPolicyTypes)]));
        if (dataSet.Tables[nameof (tblCompanyPolicyChargesPolicyTypes)] != null)
          base.Tables.Add((DataTable) new dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesDataTable(dataSet.Tables[nameof (tblCompanyPolicyChargesPolicyTypes)]));
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
  public dsCompanyPolicyFees.lstFeeTypesDataTable lstFeeTypes => this.tablelstFeeTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyPolicyFees.tblClientOfficesDataTable tblClientOffices
  {
    get => this.tabletblClientOffices;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyPolicyFees.tblCompanyPolicyChargesDataTable tblCompanyPolicyCharges
  {
    get => this.tabletblCompanyPolicyCharges;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyPolicyFees.tblFin_PolicyChargesDataTable tblFin_PolicyCharges
  {
    get => this.tabletblFin_PolicyCharges;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyPolicyFees.lstFeeAppliesToPaymentDataTable lstFeeAppliesToPayment
  {
    get => this.tablelstFeeAppliesToPayment;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyPolicyFees.tblCompanyLocationsDataTable tblCompanyLocations
  {
    get => this.tabletblCompanyLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyPolicyFees.lstStatesDataTable lstStates => this.tablelstStates;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyPolicyFees.lstLinesDataTable lstLines => this.tablelstLines;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyPolicyFees.lstCompanyLicenseTypesDataTable lstCompanyLicenseTypes
  {
    get => this.tablelstCompanyLicenseTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyPolicyFees.tblKentuckyCitiesDataTable tblKentuckyCities
  {
    get => this.tabletblKentuckyCities;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyPolicyFees.tblUsersDataTable tblUsers => this.tabletblUsers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyPolicyFees.lstPolicyTypesDataTable lstPolicyTypes => this.tablelstPolicyTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesDataTable tblCompanyPolicyChargesPolicyTypes
  {
    get => this.tabletblCompanyPolicyChargesPolicyTypes;
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
    dsCompanyPolicyFees companyPolicyFees = (dsCompanyPolicyFees) base.Clone();
    companyPolicyFees.InitVars();
    companyPolicyFees.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) companyPolicyFees;
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
      if (dataSet.Tables["lstFeeTypes"] != null)
        base.Tables.Add((DataTable) new dsCompanyPolicyFees.lstFeeTypesDataTable(dataSet.Tables["lstFeeTypes"]));
      if (dataSet.Tables["tblClientOffices"] != null)
        base.Tables.Add((DataTable) new dsCompanyPolicyFees.tblClientOfficesDataTable(dataSet.Tables["tblClientOffices"]));
      if (dataSet.Tables["tblCompanyPolicyCharges"] != null)
        base.Tables.Add((DataTable) new dsCompanyPolicyFees.tblCompanyPolicyChargesDataTable(dataSet.Tables["tblCompanyPolicyCharges"]));
      if (dataSet.Tables["tblFin_PolicyCharges"] != null)
        base.Tables.Add((DataTable) new dsCompanyPolicyFees.tblFin_PolicyChargesDataTable(dataSet.Tables["tblFin_PolicyCharges"]));
      if (dataSet.Tables["lstFeeAppliesToPayment"] != null)
        base.Tables.Add((DataTable) new dsCompanyPolicyFees.lstFeeAppliesToPaymentDataTable(dataSet.Tables["lstFeeAppliesToPayment"]));
      if (dataSet.Tables["tblCompanyLocations"] != null)
        base.Tables.Add((DataTable) new dsCompanyPolicyFees.tblCompanyLocationsDataTable(dataSet.Tables["tblCompanyLocations"]));
      if (dataSet.Tables["lstStates"] != null)
        base.Tables.Add((DataTable) new dsCompanyPolicyFees.lstStatesDataTable(dataSet.Tables["lstStates"]));
      if (dataSet.Tables["lstLines"] != null)
        base.Tables.Add((DataTable) new dsCompanyPolicyFees.lstLinesDataTable(dataSet.Tables["lstLines"]));
      if (dataSet.Tables["lstCompanyLicenseTypes"] != null)
        base.Tables.Add((DataTable) new dsCompanyPolicyFees.lstCompanyLicenseTypesDataTable(dataSet.Tables["lstCompanyLicenseTypes"]));
      if (dataSet.Tables["tblKentuckyCities"] != null)
        base.Tables.Add((DataTable) new dsCompanyPolicyFees.tblKentuckyCitiesDataTable(dataSet.Tables["tblKentuckyCities"]));
      if (dataSet.Tables["tblUsers"] != null)
        base.Tables.Add((DataTable) new dsCompanyPolicyFees.tblUsersDataTable(dataSet.Tables["tblUsers"]));
      if (dataSet.Tables["lstPolicyTypes"] != null)
        base.Tables.Add((DataTable) new dsCompanyPolicyFees.lstPolicyTypesDataTable(dataSet.Tables["lstPolicyTypes"]));
      if (dataSet.Tables["tblCompanyPolicyChargesPolicyTypes"] != null)
        base.Tables.Add((DataTable) new dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesDataTable(dataSet.Tables["tblCompanyPolicyChargesPolicyTypes"]));
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
    this.tablelstFeeTypes = (dsCompanyPolicyFees.lstFeeTypesDataTable) base.Tables["lstFeeTypes"];
    if (initTable && this.tablelstFeeTypes != null)
      this.tablelstFeeTypes.InitVars();
    this.tabletblClientOffices = (dsCompanyPolicyFees.tblClientOfficesDataTable) base.Tables["tblClientOffices"];
    if (initTable && this.tabletblClientOffices != null)
      this.tabletblClientOffices.InitVars();
    this.tabletblCompanyPolicyCharges = (dsCompanyPolicyFees.tblCompanyPolicyChargesDataTable) base.Tables["tblCompanyPolicyCharges"];
    if (initTable && this.tabletblCompanyPolicyCharges != null)
      this.tabletblCompanyPolicyCharges.InitVars();
    this.tabletblFin_PolicyCharges = (dsCompanyPolicyFees.tblFin_PolicyChargesDataTable) base.Tables["tblFin_PolicyCharges"];
    if (initTable && this.tabletblFin_PolicyCharges != null)
      this.tabletblFin_PolicyCharges.InitVars();
    this.tablelstFeeAppliesToPayment = (dsCompanyPolicyFees.lstFeeAppliesToPaymentDataTable) base.Tables["lstFeeAppliesToPayment"];
    if (initTable && this.tablelstFeeAppliesToPayment != null)
      this.tablelstFeeAppliesToPayment.InitVars();
    this.tabletblCompanyLocations = (dsCompanyPolicyFees.tblCompanyLocationsDataTable) base.Tables["tblCompanyLocations"];
    if (initTable && this.tabletblCompanyLocations != null)
      this.tabletblCompanyLocations.InitVars();
    this.tablelstStates = (dsCompanyPolicyFees.lstStatesDataTable) base.Tables["lstStates"];
    if (initTable && this.tablelstStates != null)
      this.tablelstStates.InitVars();
    this.tablelstLines = (dsCompanyPolicyFees.lstLinesDataTable) base.Tables["lstLines"];
    if (initTable && this.tablelstLines != null)
      this.tablelstLines.InitVars();
    this.tablelstCompanyLicenseTypes = (dsCompanyPolicyFees.lstCompanyLicenseTypesDataTable) base.Tables["lstCompanyLicenseTypes"];
    if (initTable && this.tablelstCompanyLicenseTypes != null)
      this.tablelstCompanyLicenseTypes.InitVars();
    this.tabletblKentuckyCities = (dsCompanyPolicyFees.tblKentuckyCitiesDataTable) base.Tables["tblKentuckyCities"];
    if (initTable && this.tabletblKentuckyCities != null)
      this.tabletblKentuckyCities.InitVars();
    this.tabletblUsers = (dsCompanyPolicyFees.tblUsersDataTable) base.Tables["tblUsers"];
    if (initTable && this.tabletblUsers != null)
      this.tabletblUsers.InitVars();
    this.tablelstPolicyTypes = (dsCompanyPolicyFees.lstPolicyTypesDataTable) base.Tables["lstPolicyTypes"];
    if (initTable && this.tablelstPolicyTypes != null)
      this.tablelstPolicyTypes.InitVars();
    this.tabletblCompanyPolicyChargesPolicyTypes = (dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesDataTable) base.Tables["tblCompanyPolicyChargesPolicyTypes"];
    if (initTable && this.tabletblCompanyPolicyChargesPolicyTypes != null)
      this.tabletblCompanyPolicyChargesPolicyTypes.InitVars();
    this.relationlstCompanyLicenseTypestblCompanyPolicyCharges = this.Relations["lstCompanyLicenseTypestblCompanyPolicyCharges"];
    this.relationlstStatestblCompanyPolicyCharges = this.Relations["lstStatestblCompanyPolicyCharges"];
    this.relationtblCompanyLocationstblCompanyPolicyCharges = this.Relations["tblCompanyLocationstblCompanyPolicyCharges"];
    this.relationlstLinestblCompanyPolicyCharges = this.Relations["lstLinestblCompanyPolicyCharges"];
    this.relationlstFeeAppliesToPaymenttblCompanyPolicyCharges = this.Relations["lstFeeAppliesToPaymenttblCompanyPolicyCharges"];
    this.relationlstFeeTypestblCompanyPolicyCharges = this.Relations["lstFeeTypestblCompanyPolicyCharges"];
    this.relationtblKentuckyCities_tblCompanyPolicyCharges = this.Relations["tblKentuckyCities_tblCompanyPolicyCharges"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyPolicyFees);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCompanyPolicyFees.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstFeeTypes = new dsCompanyPolicyFees.lstFeeTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstFeeTypes);
    this.tabletblClientOffices = new dsCompanyPolicyFees.tblClientOfficesDataTable();
    base.Tables.Add((DataTable) this.tabletblClientOffices);
    this.tabletblCompanyPolicyCharges = new dsCompanyPolicyFees.tblCompanyPolicyChargesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyPolicyCharges);
    this.tabletblFin_PolicyCharges = new dsCompanyPolicyFees.tblFin_PolicyChargesDataTable();
    base.Tables.Add((DataTable) this.tabletblFin_PolicyCharges);
    this.tablelstFeeAppliesToPayment = new dsCompanyPolicyFees.lstFeeAppliesToPaymentDataTable();
    base.Tables.Add((DataTable) this.tablelstFeeAppliesToPayment);
    this.tabletblCompanyLocations = new dsCompanyPolicyFees.tblCompanyLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLocations);
    this.tablelstStates = new dsCompanyPolicyFees.lstStatesDataTable();
    base.Tables.Add((DataTable) this.tablelstStates);
    this.tablelstLines = new dsCompanyPolicyFees.lstLinesDataTable();
    base.Tables.Add((DataTable) this.tablelstLines);
    this.tablelstCompanyLicenseTypes = new dsCompanyPolicyFees.lstCompanyLicenseTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstCompanyLicenseTypes);
    this.tabletblKentuckyCities = new dsCompanyPolicyFees.tblKentuckyCitiesDataTable();
    base.Tables.Add((DataTable) this.tabletblKentuckyCities);
    this.tabletblUsers = new dsCompanyPolicyFees.tblUsersDataTable();
    base.Tables.Add((DataTable) this.tabletblUsers);
    this.tablelstPolicyTypes = new dsCompanyPolicyFees.lstPolicyTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstPolicyTypes);
    this.tabletblCompanyPolicyChargesPolicyTypes = new dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyPolicyChargesPolicyTypes);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("lstCompanyLicenseTypestblCompanyPolicyCharges", new DataColumn[1]
    {
      this.tablelstCompanyLicenseTypes.CompanyLicenceTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyPolicyCharges.CompanyLicenceTypeIDColumn
    });
    this.tabletblCompanyPolicyCharges.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstStatestblCompanyPolicyCharges", new DataColumn[1]
    {
      this.tablelstStates.StateIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyPolicyCharges.StateIDColumn
    });
    this.tabletblCompanyPolicyCharges.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("tblCompanyLocationstblCompanyPolicyCharges", new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyLocationGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyPolicyCharges.CompanyLocationGuidColumn
    });
    this.tabletblCompanyPolicyCharges.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("lstLinestblCompanyPolicyCharges", new DataColumn[1]
    {
      this.tablelstLines.LineGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyPolicyCharges.LineGuidColumn
    });
    this.tabletblCompanyPolicyCharges.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint5 = new ForeignKeyConstraint("lstFeeAppliesToPaymenttblCompanyPolicyCharges", new DataColumn[1]
    {
      this.tablelstFeeAppliesToPayment.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyPolicyCharges.AppliesToPaymentIDColumn
    });
    this.tabletblCompanyPolicyCharges.Constraints.Add((Constraint) foreignKeyConstraint5);
    foreignKeyConstraint5.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint5.DeleteRule = Rule.Cascade;
    foreignKeyConstraint5.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint6 = new ForeignKeyConstraint("lstFeeTypestblCompanyPolicyCharges", new DataColumn[1]
    {
      this.tablelstFeeTypes.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyPolicyCharges.FeeTypeIDColumn
    });
    this.tabletblCompanyPolicyCharges.Constraints.Add((Constraint) foreignKeyConstraint6);
    foreignKeyConstraint6.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint6.DeleteRule = Rule.Cascade;
    foreignKeyConstraint6.UpdateRule = Rule.Cascade;
    this.relationlstCompanyLicenseTypestblCompanyPolicyCharges = new DataRelation("lstCompanyLicenseTypestblCompanyPolicyCharges", new DataColumn[1]
    {
      this.tablelstCompanyLicenseTypes.CompanyLicenceTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyPolicyCharges.CompanyLicenceTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstCompanyLicenseTypestblCompanyPolicyCharges);
    this.relationlstStatestblCompanyPolicyCharges = new DataRelation("lstStatestblCompanyPolicyCharges", new DataColumn[1]
    {
      this.tablelstStates.StateIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyPolicyCharges.StateIDColumn
    }, false);
    this.Relations.Add(this.relationlstStatestblCompanyPolicyCharges);
    this.relationtblCompanyLocationstblCompanyPolicyCharges = new DataRelation("tblCompanyLocationstblCompanyPolicyCharges", new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyLocationGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyPolicyCharges.CompanyLocationGuidColumn
    }, false);
    this.Relations.Add(this.relationtblCompanyLocationstblCompanyPolicyCharges);
    this.relationlstLinestblCompanyPolicyCharges = new DataRelation("lstLinestblCompanyPolicyCharges", new DataColumn[1]
    {
      this.tablelstLines.LineGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyPolicyCharges.LineGuidColumn
    }, false);
    this.Relations.Add(this.relationlstLinestblCompanyPolicyCharges);
    this.relationlstFeeAppliesToPaymenttblCompanyPolicyCharges = new DataRelation("lstFeeAppliesToPaymenttblCompanyPolicyCharges", new DataColumn[1]
    {
      this.tablelstFeeAppliesToPayment.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyPolicyCharges.AppliesToPaymentIDColumn
    }, false);
    this.Relations.Add(this.relationlstFeeAppliesToPaymenttblCompanyPolicyCharges);
    this.relationlstFeeTypestblCompanyPolicyCharges = new DataRelation("lstFeeTypestblCompanyPolicyCharges", new DataColumn[1]
    {
      this.tablelstFeeTypes.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyPolicyCharges.FeeTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstFeeTypestblCompanyPolicyCharges);
    this.relationtblKentuckyCities_tblCompanyPolicyCharges = new DataRelation("tblKentuckyCities_tblCompanyPolicyCharges", new DataColumn[1]
    {
      this.tabletblKentuckyCities.CityIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyPolicyCharges.KentuckyCityIDColumn
    }, false);
    this.Relations.Add(this.relationtblKentuckyCities_tblCompanyPolicyCharges);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstFeeTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblClientOffices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyPolicyCharges() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblFin_PolicyCharges() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstFeeAppliesToPayment() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstStates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstLines() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstCompanyLicenseTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblKentuckyCities() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblUsers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstPolicyTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyPolicyChargesPolicyTypes() => false;

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
    dsCompanyPolicyFees companyPolicyFees = new dsCompanyPolicyFees();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = companyPolicyFees.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = companyPolicyFees.GetSchemaSerializable();
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
  public delegate void lstFeeTypesRowChangeEventHandler(
    object sender,
    dsCompanyPolicyFees.lstFeeTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblClientOfficesRowChangeEventHandler(
    object sender,
    dsCompanyPolicyFees.tblClientOfficesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyPolicyChargesRowChangeEventHandler(
    object sender,
    dsCompanyPolicyFees.tblCompanyPolicyChargesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblFin_PolicyChargesRowChangeEventHandler(
    object sender,
    dsCompanyPolicyFees.tblFin_PolicyChargesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstFeeAppliesToPaymentRowChangeEventHandler(
    object sender,
    dsCompanyPolicyFees.lstFeeAppliesToPaymentRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyLocationsRowChangeEventHandler(
    object sender,
    dsCompanyPolicyFees.tblCompanyLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstStatesRowChangeEventHandler(
    object sender,
    dsCompanyPolicyFees.lstStatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstLinesRowChangeEventHandler(
    object sender,
    dsCompanyPolicyFees.lstLinesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstCompanyLicenseTypesRowChangeEventHandler(
    object sender,
    dsCompanyPolicyFees.lstCompanyLicenseTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblKentuckyCitiesRowChangeEventHandler(
    object sender,
    dsCompanyPolicyFees.tblKentuckyCitiesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblUsersRowChangeEventHandler(
    object sender,
    dsCompanyPolicyFees.tblUsersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstPolicyTypesRowChangeEventHandler(
    object sender,
    dsCompanyPolicyFees.lstPolicyTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyPolicyChargesPolicyTypesRowChangeEventHandler(
    object sender,
    dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstFeeTypesDataTable : TypedTableBase<dsCompanyPolicyFees.lstFeeTypesRow>
  {
    private DataColumn columnID;
    private DataColumn columnFeeType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstFeeTypesDataTable()
    {
      this.TableName = "lstFeeTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstFeeTypesDataTable(DataTable table)
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
    protected lstFeeTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FeeTypeColumn => this.columnFeeType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstFeeTypesRow this[int index]
    {
      get => (dsCompanyPolicyFees.lstFeeTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstFeeTypesRowChangeEventHandler lstFeeTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstFeeTypesRowChangeEventHandler lstFeeTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstFeeTypesRowChangeEventHandler lstFeeTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstFeeTypesRowChangeEventHandler lstFeeTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstFeeTypesRow(dsCompanyPolicyFees.lstFeeTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstFeeTypesRow AddlstFeeTypesRow(int ID, string FeeType)
    {
      dsCompanyPolicyFees.lstFeeTypesRow row = (dsCompanyPolicyFees.lstFeeTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) FeeType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstFeeTypesRow FindByID(int ID)
    {
      return (dsCompanyPolicyFees.lstFeeTypesRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyPolicyFees.lstFeeTypesDataTable feeTypesDataTable = (dsCompanyPolicyFees.lstFeeTypesDataTable) base.Clone();
      feeTypesDataTable.InitVars();
      return (DataTable) feeTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyPolicyFees.lstFeeTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnFeeType = this.Columns["FeeType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnFeeType = new DataColumn("FeeType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFeeType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyPolicyFeesKey3", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnFeeType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstFeeTypesRow NewlstFeeTypesRow()
    {
      return (dsCompanyPolicyFees.lstFeeTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyPolicyFees.lstFeeTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyPolicyFees.lstFeeTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstFeeTypesRowChangeEventHandler typesRowChangedEvent = this.lstFeeTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompanyPolicyFees.lstFeeTypesRowChangeEvent((dsCompanyPolicyFees.lstFeeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstFeeTypesRowChangeEventHandler rowChangingEvent = this.lstFeeTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyPolicyFees.lstFeeTypesRowChangeEvent((dsCompanyPolicyFees.lstFeeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstFeeTypesRowChangeEventHandler typesRowDeletedEvent = this.lstFeeTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompanyPolicyFees.lstFeeTypesRowChangeEvent((dsCompanyPolicyFees.lstFeeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstFeeTypesRowChangeEventHandler rowDeletingEvent = this.lstFeeTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyPolicyFees.lstFeeTypesRowChangeEvent((dsCompanyPolicyFees.lstFeeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstFeeTypesRow(dsCompanyPolicyFees.lstFeeTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyPolicyFees companyPolicyFees = new dsCompanyPolicyFees();
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
        FixedValue = companyPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstFeeTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyPolicyFees.GetSchemaSerializable();
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
  public class tblClientOfficesDataTable : TypedTableBase<dsCompanyPolicyFees.tblClientOfficesRow>
  {
    private DataColumn columnOfficeGuid;
    private DataColumn columnLocation;
    private DataColumn columnOfficeID;
    private DataColumn columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblClientOfficesDataTable()
    {
      this.TableName = "tblClientOffices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblClientOfficesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OfficeGuidColumn => this.columnOfficeGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblClientOfficesRow this[int index]
    {
      get => (dsCompanyPolicyFees.tblClientOfficesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblClientOfficesRow(dsCompanyPolicyFees.tblClientOfficesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblClientOfficesRow AddtblClientOfficesRow(
      Guid OfficeGuid,
      string Location,
      int OfficeID,
      int StatusID)
    {
      dsCompanyPolicyFees.tblClientOfficesRow row = (dsCompanyPolicyFees.tblClientOfficesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) OfficeGuid,
        (object) Location,
        (object) OfficeID,
        (object) StatusID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblClientOfficesRow FindByOfficeGuid(Guid OfficeGuid)
    {
      return (dsCompanyPolicyFees.tblClientOfficesRow) this.Rows.Find(new object[1]
      {
        (object) OfficeGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyPolicyFees.tblClientOfficesDataTable officesDataTable = (dsCompanyPolicyFees.tblClientOfficesDataTable) base.Clone();
      officesDataTable.InitVars();
      return (DataTable) officesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyPolicyFees.tblClientOfficesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnOfficeGuid = this.Columns["OfficeGuid"];
      this.columnLocation = this.Columns["Location"];
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnStatusID = this.Columns["StatusID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnOfficeGuid = new DataColumn("OfficeGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeGuid);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyPolicyFeesKey1", new DataColumn[1]
      {
        this.columnOfficeGuid
      }, true));
      this.columnOfficeGuid.AllowDBNull = false;
      this.columnOfficeGuid.Unique = true;
      this.columnLocation.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblClientOfficesRow NewtblClientOfficesRow()
    {
      return (dsCompanyPolicyFees.tblClientOfficesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyPolicyFees.tblClientOfficesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyPolicyFees.tblClientOfficesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblClientOfficesRowChangeEventHandler officesRowChangedEvent = this.tblClientOfficesRowChangedEvent;
      if (officesRowChangedEvent == null)
        return;
      officesRowChangedEvent((object) this, new dsCompanyPolicyFees.tblClientOfficesRowChangeEvent((dsCompanyPolicyFees.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblClientOfficesRowChangeEventHandler rowChangingEvent = this.tblClientOfficesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyPolicyFees.tblClientOfficesRowChangeEvent((dsCompanyPolicyFees.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblClientOfficesRowChangeEventHandler officesRowDeletedEvent = this.tblClientOfficesRowDeletedEvent;
      if (officesRowDeletedEvent == null)
        return;
      officesRowDeletedEvent((object) this, new dsCompanyPolicyFees.tblClientOfficesRowChangeEvent((dsCompanyPolicyFees.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblClientOfficesRowChangeEventHandler rowDeletingEvent = this.tblClientOfficesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyPolicyFees.tblClientOfficesRowChangeEvent((dsCompanyPolicyFees.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblClientOfficesRow(dsCompanyPolicyFees.tblClientOfficesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyPolicyFees companyPolicyFees = new dsCompanyPolicyFees();
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
        FixedValue = companyPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClientOfficesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyPolicyFees.GetSchemaSerializable();
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
  public class tblCompanyPolicyChargesDataTable : 
    TypedTableBase<dsCompanyPolicyFees.tblCompanyPolicyChargesRow>
  {
    private DataColumn columnCompanyFeeID;
    private DataColumn columnChargeCode;
    private DataColumn columnCompanyLocationGuid;
    private DataColumn columnLineGuid;
    private DataColumn columnStateID;
    private DataColumn columnFeeTypeID;
    private DataColumn columnCompanyLicenceTypeID;
    private DataColumn columnPayable;
    private DataColumn columnPayableEntityGuid;
    private DataColumn columnPayableEntityType;
    private DataColumn columnFlatRate;
    private DataColumn columnPercentageRate;
    private DataColumn columnApplyPremiumEqualOrLess;
    private DataColumn columnApplyPremiumEqualOrOver;
    private DataColumn columnAutoApply;
    private DataColumn columnEffective;
    private DataColumn columnSplittable;
    private DataColumn columnOfficeID;
    private DataColumn columnPayableEntity;
    private DataColumn columnDescription;
    private DataColumn columnMinimum;
    private DataColumn columnExcludeWhenNotFiling;
    private DataColumn columnExcludeOnEndorsements;
    private DataColumn columnExcludeOnRenewal;
    private DataColumn columnAppliesToPaymentID;
    private DataColumn columnFullyEarned;
    private DataColumn columnRoundToDollar;
    private DataColumn columnMaxPercentage;
    private DataColumn columnMaxDollars;
    private DataColumn columnDisabled;
    private DataColumn columnPercentageNet;
    private DataColumn columnTerrorismExcluded;
    private DataColumn columnFeeBasedOnNumberOfLocations;
    private DataColumn columnStateOfIssuanceOnly;
    private DataColumn columnMinStrat;
    private DataColumn columnMaxStrat;
    private DataColumn columnFullyEarnedNumDays;
    private DataColumn columnSendToAccounting;
    private DataColumn columnRoundDown;
    private DataColumn columnRoundUp;
    private DataColumn columnNoRounding;
    private DataColumn columnKentuckyCityID;
    private DataColumn columnApplyPackagePolicyOnly;
    private DataColumn columnDoNotApplyPackagePolicyOnly;
    private DataColumn columnPremiumAllocationType;
    private DataColumn columnFeeBasedOnNumberOfVehicles;
    private DataColumn columnAppliesToAllStates;
    private DataColumn columnMasterPayee;
    private DataColumn columnPayHomeState;
    private DataColumn columnInternationalStratification;
    private DataColumn columnExcludeInternationalPremiums;
    private DataColumn columnApplyToChildLines;
    private DataColumn columnLineName;
    private DataColumn columnRoundToCent;
    private DataColumn columnRoundUpToCent;
    private DataColumn columnExcludeMultiCarrier;
    private DataColumn columnApplytoFlatCanc;
    private DataColumn columnExcludeOriginalBinder;
    private DataColumn columnAddedBy;
    private DataColumn columnEditedBy;
    private DataColumn columnAddedDate;
    private DataColumn columnEditedDate;
    private DataColumn columnNotes;
    private DataColumn columnCountyTaxIncludedInRate;
    private DataColumn columnMandatoryCharge;
    private DataColumn columnApplyOnce;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyPolicyChargesDataTable()
    {
      this.TableName = "tblCompanyPolicyCharges";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyPolicyChargesDataTable(DataTable table)
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
    protected tblCompanyPolicyChargesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyFeeIDColumn => this.columnCompanyFeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineGuidColumn => this.columnLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FeeTypeIDColumn => this.columnFeeTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLicenceTypeIDColumn => this.columnCompanyLicenceTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PayableColumn => this.columnPayable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PayableEntityGuidColumn => this.columnPayableEntityGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PayableEntityTypeColumn => this.columnPayableEntityType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FlatRateColumn => this.columnFlatRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PercentageRateColumn => this.columnPercentageRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ApplyPremiumEqualOrLessColumn => this.columnApplyPremiumEqualOrLess;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ApplyPremiumEqualOrOverColumn => this.columnApplyPremiumEqualOrOver;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AutoApplyColumn => this.columnAutoApply;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EffectiveColumn => this.columnEffective;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SplittableColumn => this.columnSplittable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PayableEntityColumn => this.columnPayableEntity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MinimumColumn => this.columnMinimum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExcludeWhenNotFilingColumn => this.columnExcludeWhenNotFiling;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExcludeOnEndorsementsColumn => this.columnExcludeOnEndorsements;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExcludeOnRenewalColumn => this.columnExcludeOnRenewal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AppliesToPaymentIDColumn => this.columnAppliesToPaymentID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FullyEarnedColumn => this.columnFullyEarned;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RoundToDollarColumn => this.columnRoundToDollar;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MaxPercentageColumn => this.columnMaxPercentage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MaxDollarsColumn => this.columnMaxDollars;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DisabledColumn => this.columnDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PercentageNetColumn => this.columnPercentageNet;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TerrorismExcludedColumn => this.columnTerrorismExcluded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FeeBasedOnNumberOfLocationsColumn => this.columnFeeBasedOnNumberOfLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateOfIssuanceOnlyColumn => this.columnStateOfIssuanceOnly;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MinStratColumn => this.columnMinStrat;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MaxStratColumn => this.columnMaxStrat;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FullyEarnedNumDaysColumn => this.columnFullyEarnedNumDays;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SendToAccountingColumn => this.columnSendToAccounting;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RoundDownColumn => this.columnRoundDown;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RoundUpColumn => this.columnRoundUp;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NoRoundingColumn => this.columnNoRounding;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn KentuckyCityIDColumn => this.columnKentuckyCityID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ApplyPackagePolicyOnlyColumn => this.columnApplyPackagePolicyOnly;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DoNotApplyPackagePolicyOnlyColumn => this.columnDoNotApplyPackagePolicyOnly;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PremiumAllocationTypeColumn => this.columnPremiumAllocationType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FeeBasedOnNumberOfVehiclesColumn => this.columnFeeBasedOnNumberOfVehicles;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AppliesToAllStatesColumn => this.columnAppliesToAllStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MasterPayeeColumn => this.columnMasterPayee;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PayHomeStateColumn => this.columnPayHomeState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InternationalStratificationColumn => this.columnInternationalStratification;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExcludeInternationalPremiumsColumn => this.columnExcludeInternationalPremiums;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ApplyToChildLinesColumn => this.columnApplyToChildLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RoundToCentColumn => this.columnRoundToCent;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RoundUpToCentColumn => this.columnRoundUpToCent;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExcludeMultiCarrierColumn => this.columnExcludeMultiCarrier;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ApplytoFlatCancColumn => this.columnApplytoFlatCanc;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExcludeOriginalBinderColumn => this.columnExcludeOriginalBinder;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AddedByColumn => this.columnAddedBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EditedByColumn => this.columnEditedBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AddedDateColumn => this.columnAddedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EditedDateColumn => this.columnEditedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NotesColumn => this.columnNotes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CountyTaxIncludedInRateColumn => this.columnCountyTaxIncludedInRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MandatoryChargeColumn => this.columnMandatoryCharge;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ApplyOnceColumn => this.columnApplyOnce;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesRow this[int index]
    {
      get => (dsCompanyPolicyFees.tblCompanyPolicyChargesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler tblCompanyPolicyChargesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler tblCompanyPolicyChargesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler tblCompanyPolicyChargesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler tblCompanyPolicyChargesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyPolicyChargesRow(dsCompanyPolicyFees.tblCompanyPolicyChargesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesRow AddtblCompanyPolicyChargesRow(
      int ChargeCode,
      dsCompanyPolicyFees.tblCompanyLocationsRow parenttblCompanyLocationsRowBytblCompanyLocationstblCompanyPolicyCharges,
      dsCompanyPolicyFees.lstLinesRow parentlstLinesRowBylstLinestblCompanyPolicyCharges,
      dsCompanyPolicyFees.lstStatesRow parentlstStatesRowBylstStatestblCompanyPolicyCharges,
      dsCompanyPolicyFees.lstFeeTypesRow parentlstFeeTypesRowBylstFeeTypestblCompanyPolicyCharges,
      dsCompanyPolicyFees.lstCompanyLicenseTypesRow parentlstCompanyLicenseTypesRowBylstCompanyLicenseTypestblCompanyPolicyCharges,
      bool Payable,
      Guid PayableEntityGuid,
      string PayableEntityType,
      Decimal FlatRate,
      Decimal PercentageRate,
      Decimal ApplyPremiumEqualOrLess,
      Decimal ApplyPremiumEqualOrOver,
      bool AutoApply,
      DateTime Effective,
      bool Splittable,
      int OfficeID,
      string PayableEntity,
      string Description,
      int Minimum,
      bool ExcludeWhenNotFiling,
      bool ExcludeOnEndorsements,
      bool ExcludeOnRenewal,
      dsCompanyPolicyFees.lstFeeAppliesToPaymentRow parentlstFeeAppliesToPaymentRowBylstFeeAppliesToPaymenttblCompanyPolicyCharges,
      bool FullyEarned,
      bool RoundToDollar,
      Decimal MaxPercentage,
      int MaxDollars,
      DateTime Disabled,
      bool PercentageNet,
      bool TerrorismExcluded,
      bool FeeBasedOnNumberOfLocations,
      bool StateOfIssuanceOnly,
      int MinStrat,
      int MaxStrat,
      short FullyEarnedNumDays,
      bool SendToAccounting,
      bool RoundDown,
      bool RoundUp,
      bool NoRounding,
      dsCompanyPolicyFees.tblKentuckyCitiesRow parenttblKentuckyCitiesRowBytblKentuckyCities_tblCompanyPolicyCharges,
      bool ApplyPackagePolicyOnly,
      bool DoNotApplyPackagePolicyOnly,
      string PremiumAllocationType,
      bool FeeBasedOnNumberOfVehicles,
      bool AppliesToAllStates,
      bool MasterPayee,
      bool PayHomeState,
      bool InternationalStratification,
      bool ExcludeInternationalPremiums,
      bool ApplyToChildLines,
      string LineName,
      bool RoundToCent,
      bool RoundUpToCent,
      bool ExcludeMultiCarrier,
      bool ApplytoFlatCanc,
      bool ExcludeOriginalBinder,
      Guid AddedBy,
      Guid EditedBy,
      DateTime AddedDate,
      DateTime EditedDate,
      string Notes,
      bool CountyTaxIncludedInRate,
      bool MandatoryCharge,
      bool ApplyOnce)
    {
      dsCompanyPolicyFees.tblCompanyPolicyChargesRow row = (dsCompanyPolicyFees.tblCompanyPolicyChargesRow) this.NewRow();
      object[] objArray = new object[66]
      {
        null,
        (object) ChargeCode,
        null,
        null,
        null,
        null,
        null,
        (object) Payable,
        (object) PayableEntityGuid,
        (object) PayableEntityType,
        (object) FlatRate,
        (object) PercentageRate,
        (object) ApplyPremiumEqualOrLess,
        (object) ApplyPremiumEqualOrOver,
        (object) AutoApply,
        (object) Effective,
        (object) Splittable,
        (object) OfficeID,
        (object) PayableEntity,
        (object) Description,
        (object) Minimum,
        (object) ExcludeWhenNotFiling,
        (object) ExcludeOnEndorsements,
        (object) ExcludeOnRenewal,
        null,
        (object) FullyEarned,
        (object) RoundToDollar,
        (object) MaxPercentage,
        (object) MaxDollars,
        (object) Disabled,
        (object) PercentageNet,
        (object) TerrorismExcluded,
        (object) FeeBasedOnNumberOfLocations,
        (object) StateOfIssuanceOnly,
        (object) MinStrat,
        (object) MaxStrat,
        (object) FullyEarnedNumDays,
        (object) SendToAccounting,
        (object) RoundDown,
        (object) RoundUp,
        (object) NoRounding,
        null,
        (object) ApplyPackagePolicyOnly,
        (object) DoNotApplyPackagePolicyOnly,
        (object) PremiumAllocationType,
        (object) FeeBasedOnNumberOfVehicles,
        (object) AppliesToAllStates,
        (object) MasterPayee,
        (object) PayHomeState,
        (object) InternationalStratification,
        (object) ExcludeInternationalPremiums,
        (object) ApplyToChildLines,
        (object) LineName,
        (object) RoundToCent,
        (object) RoundUpToCent,
        (object) ExcludeMultiCarrier,
        (object) ApplytoFlatCanc,
        (object) ExcludeOriginalBinder,
        (object) AddedBy,
        (object) EditedBy,
        (object) AddedDate,
        (object) EditedDate,
        (object) Notes,
        (object) CountyTaxIncludedInRate,
        (object) MandatoryCharge,
        (object) ApplyOnce
      };
      if (parenttblCompanyLocationsRowBytblCompanyLocationstblCompanyPolicyCharges != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parenttblCompanyLocationsRowBytblCompanyLocationstblCompanyPolicyCharges[0]);
      if (parentlstLinesRowBylstLinestblCompanyPolicyCharges != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parentlstLinesRowBylstLinestblCompanyPolicyCharges[0]);
      if (parentlstStatesRowBylstStatestblCompanyPolicyCharges != null)
        objArray[4] = RuntimeHelpers.GetObjectValue(parentlstStatesRowBylstStatestblCompanyPolicyCharges[0]);
      if (parentlstFeeTypesRowBylstFeeTypestblCompanyPolicyCharges != null)
        objArray[5] = RuntimeHelpers.GetObjectValue(parentlstFeeTypesRowBylstFeeTypestblCompanyPolicyCharges[0]);
      if (parentlstCompanyLicenseTypesRowBylstCompanyLicenseTypestblCompanyPolicyCharges != null)
        objArray[6] = RuntimeHelpers.GetObjectValue(parentlstCompanyLicenseTypesRowBylstCompanyLicenseTypestblCompanyPolicyCharges[0]);
      if (parentlstFeeAppliesToPaymentRowBylstFeeAppliesToPaymenttblCompanyPolicyCharges != null)
        objArray[24] = RuntimeHelpers.GetObjectValue(parentlstFeeAppliesToPaymentRowBylstFeeAppliesToPaymenttblCompanyPolicyCharges[0]);
      if (parenttblKentuckyCitiesRowBytblKentuckyCities_tblCompanyPolicyCharges != null)
        objArray[41] = RuntimeHelpers.GetObjectValue(parenttblKentuckyCitiesRowBytblKentuckyCities_tblCompanyPolicyCharges[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesRow FindByCompanyFeeID(int CompanyFeeID)
    {
      return (dsCompanyPolicyFees.tblCompanyPolicyChargesRow) this.Rows.Find(new object[1]
      {
        (object) CompanyFeeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyPolicyFees.tblCompanyPolicyChargesDataTable chargesDataTable = (dsCompanyPolicyFees.tblCompanyPolicyChargesDataTable) base.Clone();
      chargesDataTable.InitVars();
      return (DataTable) chargesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyPolicyFees.tblCompanyPolicyChargesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyFeeID = this.Columns["CompanyFeeID"];
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
      this.columnLineGuid = this.Columns["LineGuid"];
      this.columnStateID = this.Columns["StateID"];
      this.columnFeeTypeID = this.Columns["FeeTypeID"];
      this.columnCompanyLicenceTypeID = this.Columns["CompanyLicenceTypeID"];
      this.columnPayable = this.Columns["Payable"];
      this.columnPayableEntityGuid = this.Columns["PayableEntityGuid"];
      this.columnPayableEntityType = this.Columns["PayableEntityType"];
      this.columnFlatRate = this.Columns["FlatRate"];
      this.columnPercentageRate = this.Columns["PercentageRate"];
      this.columnApplyPremiumEqualOrLess = this.Columns["ApplyPremiumEqualOrLess"];
      this.columnApplyPremiumEqualOrOver = this.Columns["ApplyPremiumEqualOrOver"];
      this.columnAutoApply = this.Columns["AutoApply"];
      this.columnEffective = this.Columns["Effective"];
      this.columnSplittable = this.Columns["Splittable"];
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnPayableEntity = this.Columns["PayableEntity"];
      this.columnDescription = this.Columns["Description"];
      this.columnMinimum = this.Columns["Minimum"];
      this.columnExcludeWhenNotFiling = this.Columns["ExcludeWhenNotFiling"];
      this.columnExcludeOnEndorsements = this.Columns["ExcludeOnEndorsements"];
      this.columnExcludeOnRenewal = this.Columns["ExcludeOnRenewal"];
      this.columnAppliesToPaymentID = this.Columns["AppliesToPaymentID"];
      this.columnFullyEarned = this.Columns["FullyEarned"];
      this.columnRoundToDollar = this.Columns["RoundToDollar"];
      this.columnMaxPercentage = this.Columns["MaxPercentage"];
      this.columnMaxDollars = this.Columns["MaxDollars"];
      this.columnDisabled = this.Columns["Disabled"];
      this.columnPercentageNet = this.Columns["PercentageNet"];
      this.columnTerrorismExcluded = this.Columns["TerrorismExcluded"];
      this.columnFeeBasedOnNumberOfLocations = this.Columns["FeeBasedOnNumberOfLocations"];
      this.columnStateOfIssuanceOnly = this.Columns["StateOfIssuanceOnly"];
      this.columnMinStrat = this.Columns["MinStrat"];
      this.columnMaxStrat = this.Columns["MaxStrat"];
      this.columnFullyEarnedNumDays = this.Columns["FullyEarnedNumDays"];
      this.columnSendToAccounting = this.Columns["SendToAccounting"];
      this.columnRoundDown = this.Columns["RoundDown"];
      this.columnRoundUp = this.Columns["RoundUp"];
      this.columnNoRounding = this.Columns["NoRounding"];
      this.columnKentuckyCityID = this.Columns["KentuckyCityID"];
      this.columnApplyPackagePolicyOnly = this.Columns["ApplyPackagePolicyOnly"];
      this.columnDoNotApplyPackagePolicyOnly = this.Columns["DoNotApplyPackagePolicyOnly"];
      this.columnPremiumAllocationType = this.Columns["PremiumAllocationType"];
      this.columnFeeBasedOnNumberOfVehicles = this.Columns["FeeBasedOnNumberOfVehicles"];
      this.columnAppliesToAllStates = this.Columns["AppliesToAllStates"];
      this.columnMasterPayee = this.Columns["MasterPayee"];
      this.columnPayHomeState = this.Columns["PayHomeState"];
      this.columnInternationalStratification = this.Columns["InternationalStratification"];
      this.columnExcludeInternationalPremiums = this.Columns["ExcludeInternationalPremiums"];
      this.columnApplyToChildLines = this.Columns["ApplyToChildLines"];
      this.columnLineName = this.Columns["LineName"];
      this.columnRoundToCent = this.Columns["RoundToCent"];
      this.columnRoundUpToCent = this.Columns["RoundUpToCent"];
      this.columnExcludeMultiCarrier = this.Columns["ExcludeMultiCarrier"];
      this.columnApplytoFlatCanc = this.Columns["ApplytoFlatCanc"];
      this.columnExcludeOriginalBinder = this.Columns["ExcludeOriginalBinder"];
      this.columnAddedBy = this.Columns["AddedBy"];
      this.columnEditedBy = this.Columns["EditedBy"];
      this.columnAddedDate = this.Columns["AddedDate"];
      this.columnEditedDate = this.Columns["EditedDate"];
      this.columnNotes = this.Columns["Notes"];
      this.columnCountyTaxIncludedInRate = this.Columns["CountyTaxIncludedInRate"];
      this.columnMandatoryCharge = this.Columns["MandatoryCharge"];
      this.columnApplyOnce = this.Columns["ApplyOnce"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyFeeID = new DataColumn("CompanyFeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyFeeID);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.columnLineGuid = new DataColumn("LineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGuid);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnFeeTypeID = new DataColumn("FeeTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFeeTypeID);
      this.columnCompanyLicenceTypeID = new DataColumn("CompanyLicenceTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLicenceTypeID);
      this.columnPayable = new DataColumn("Payable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayable);
      this.columnPayableEntityGuid = new DataColumn("PayableEntityGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayableEntityGuid);
      this.columnPayableEntityType = new DataColumn("PayableEntityType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayableEntityType);
      this.columnFlatRate = new DataColumn("FlatRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFlatRate);
      this.columnPercentageRate = new DataColumn("PercentageRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentageRate);
      this.columnApplyPremiumEqualOrLess = new DataColumn("ApplyPremiumEqualOrLess", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnApplyPremiumEqualOrLess);
      this.columnApplyPremiumEqualOrOver = new DataColumn("ApplyPremiumEqualOrOver", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnApplyPremiumEqualOrOver);
      this.columnAutoApply = new DataColumn("AutoApply", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoApply);
      this.columnEffective = new DataColumn("Effective", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffective);
      this.columnSplittable = new DataColumn("Splittable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSplittable);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnPayableEntity = new DataColumn("PayableEntity", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayableEntity);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnMinimum = new DataColumn("Minimum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMinimum);
      this.columnExcludeWhenNotFiling = new DataColumn("ExcludeWhenNotFiling", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExcludeWhenNotFiling);
      this.columnExcludeOnEndorsements = new DataColumn("ExcludeOnEndorsements", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExcludeOnEndorsements);
      this.columnExcludeOnRenewal = new DataColumn("ExcludeOnRenewal", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExcludeOnRenewal);
      this.columnAppliesToPaymentID = new DataColumn("AppliesToPaymentID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAppliesToPaymentID);
      this.columnFullyEarned = new DataColumn("FullyEarned", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullyEarned);
      this.columnRoundToDollar = new DataColumn("RoundToDollar", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoundToDollar);
      this.columnMaxPercentage = new DataColumn("MaxPercentage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMaxPercentage);
      this.columnMaxDollars = new DataColumn("MaxDollars", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMaxDollars);
      this.columnDisabled = new DataColumn("Disabled", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisabled);
      this.columnPercentageNet = new DataColumn("PercentageNet", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentageNet);
      this.columnTerrorismExcluded = new DataColumn("TerrorismExcluded", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrorismExcluded);
      this.columnFeeBasedOnNumberOfLocations = new DataColumn("FeeBasedOnNumberOfLocations", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFeeBasedOnNumberOfLocations);
      this.columnStateOfIssuanceOnly = new DataColumn("StateOfIssuanceOnly", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateOfIssuanceOnly);
      this.columnMinStrat = new DataColumn("MinStrat", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMinStrat);
      this.columnMaxStrat = new DataColumn("MaxStrat", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMaxStrat);
      this.columnFullyEarnedNumDays = new DataColumn("FullyEarnedNumDays", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullyEarnedNumDays);
      this.columnSendToAccounting = new DataColumn("SendToAccounting", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSendToAccounting);
      this.columnRoundDown = new DataColumn("RoundDown", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoundDown);
      this.columnRoundUp = new DataColumn("RoundUp", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoundUp);
      this.columnNoRounding = new DataColumn("NoRounding", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoRounding);
      this.columnKentuckyCityID = new DataColumn("KentuckyCityID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnKentuckyCityID);
      this.columnApplyPackagePolicyOnly = new DataColumn("ApplyPackagePolicyOnly", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnApplyPackagePolicyOnly);
      this.columnDoNotApplyPackagePolicyOnly = new DataColumn("DoNotApplyPackagePolicyOnly", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDoNotApplyPackagePolicyOnly);
      this.columnPremiumAllocationType = new DataColumn("PremiumAllocationType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremiumAllocationType);
      this.columnFeeBasedOnNumberOfVehicles = new DataColumn("FeeBasedOnNumberOfVehicles", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFeeBasedOnNumberOfVehicles);
      this.columnAppliesToAllStates = new DataColumn("AppliesToAllStates", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAppliesToAllStates);
      this.columnMasterPayee = new DataColumn("MasterPayee", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMasterPayee);
      this.columnPayHomeState = new DataColumn("PayHomeState", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayHomeState);
      this.columnInternationalStratification = new DataColumn("InternationalStratification", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInternationalStratification);
      this.columnExcludeInternationalPremiums = new DataColumn("ExcludeInternationalPremiums", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExcludeInternationalPremiums);
      this.columnApplyToChildLines = new DataColumn("ApplyToChildLines", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnApplyToChildLines);
      this.columnLineName = new DataColumn("LineName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineName);
      this.columnRoundToCent = new DataColumn("RoundToCent", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoundToCent);
      this.columnRoundUpToCent = new DataColumn("RoundUpToCent", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoundUpToCent);
      this.columnExcludeMultiCarrier = new DataColumn("ExcludeMultiCarrier", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExcludeMultiCarrier);
      this.columnApplytoFlatCanc = new DataColumn("ApplytoFlatCanc", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnApplytoFlatCanc);
      this.columnExcludeOriginalBinder = new DataColumn("ExcludeOriginalBinder", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExcludeOriginalBinder);
      this.columnAddedBy = new DataColumn("AddedBy", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddedBy);
      this.columnEditedBy = new DataColumn("EditedBy", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEditedBy);
      this.columnAddedDate = new DataColumn("AddedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddedDate);
      this.columnEditedDate = new DataColumn("EditedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEditedDate);
      this.columnNotes = new DataColumn("Notes", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNotes);
      this.columnCountyTaxIncludedInRate = new DataColumn("CountyTaxIncludedInRate", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCountyTaxIncludedInRate);
      this.columnMandatoryCharge = new DataColumn("MandatoryCharge", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMandatoryCharge);
      this.columnApplyOnce = new DataColumn("ApplyOnce", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnApplyOnce);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyPolicyFeesKey4", new DataColumn[1]
      {
        this.columnCompanyFeeID
      }, true));
      this.columnCompanyFeeID.AutoIncrement = true;
      this.columnCompanyFeeID.AllowDBNull = false;
      this.columnCompanyFeeID.ReadOnly = true;
      this.columnCompanyFeeID.Unique = true;
      this.columnPayable.AllowDBNull = false;
      this.columnPayable.DefaultValue = (object) false;
      this.columnAutoApply.AllowDBNull = false;
      this.columnAutoApply.DefaultValue = (object) false;
      this.columnEffective.AllowDBNull = false;
      this.columnSplittable.AllowDBNull = false;
      this.columnSplittable.DefaultValue = (object) false;
      this.columnExcludeWhenNotFiling.AllowDBNull = false;
      this.columnExcludeWhenNotFiling.DefaultValue = (object) false;
      this.columnExcludeOnEndorsements.AllowDBNull = false;
      this.columnExcludeOnEndorsements.DefaultValue = (object) false;
      this.columnExcludeOnRenewal.AllowDBNull = false;
      this.columnExcludeOnRenewal.DefaultValue = (object) false;
      this.columnAppliesToPaymentID.AllowDBNull = false;
      this.columnAppliesToPaymentID.DefaultValue = (object) "D";
      this.columnFullyEarned.AllowDBNull = false;
      this.columnFullyEarned.DefaultValue = (object) false;
      this.columnRoundToDollar.AllowDBNull = false;
      this.columnRoundToDollar.DefaultValue = (object) false;
      this.columnPercentageNet.AllowDBNull = false;
      this.columnPercentageNet.DefaultValue = (object) false;
      this.columnTerrorismExcluded.AllowDBNull = false;
      this.columnTerrorismExcluded.DefaultValue = (object) false;
      this.columnFeeBasedOnNumberOfLocations.AllowDBNull = false;
      this.columnFeeBasedOnNumberOfLocations.DefaultValue = (object) false;
      this.columnStateOfIssuanceOnly.AllowDBNull = false;
      this.columnStateOfIssuanceOnly.DefaultValue = (object) false;
      this.columnSendToAccounting.DefaultValue = (object) true;
      this.columnRoundDown.DefaultValue = (object) false;
      this.columnRoundUp.DefaultValue = (object) false;
      this.columnNoRounding.AllowDBNull = false;
      this.columnNoRounding.DefaultValue = (object) false;
      this.columnApplyPackagePolicyOnly.DefaultValue = (object) false;
      this.columnDoNotApplyPackagePolicyOnly.DefaultValue = (object) false;
      this.columnFeeBasedOnNumberOfVehicles.AllowDBNull = false;
      this.columnFeeBasedOnNumberOfVehicles.DefaultValue = (object) false;
      this.columnAppliesToAllStates.AllowDBNull = false;
      this.columnAppliesToAllStates.Caption = "PayHomeState";
      this.columnAppliesToAllStates.DefaultValue = (object) false;
      this.columnMasterPayee.AllowDBNull = false;
      this.columnMasterPayee.Caption = "PayHomeState";
      this.columnMasterPayee.DefaultValue = (object) false;
      this.columnPayHomeState.AllowDBNull = false;
      this.columnPayHomeState.DefaultValue = (object) false;
      this.columnInternationalStratification.AllowDBNull = false;
      this.columnInternationalStratification.DefaultValue = (object) false;
      this.columnExcludeInternationalPremiums.AllowDBNull = false;
      this.columnExcludeInternationalPremiums.DefaultValue = (object) false;
      this.columnApplyToChildLines.AllowDBNull = false;
      this.columnApplyToChildLines.DefaultValue = (object) false;
      this.columnRoundToCent.DefaultValue = (object) false;
      this.columnRoundUpToCent.DefaultValue = (object) false;
      this.columnExcludeMultiCarrier.DefaultValue = (object) false;
      this.columnApplytoFlatCanc.DefaultValue = (object) false;
      this.columnExcludeOriginalBinder.DefaultValue = (object) false;
      this.columnCountyTaxIncludedInRate.AllowDBNull = false;
      this.columnCountyTaxIncludedInRate.DefaultValue = (object) false;
      this.columnMandatoryCharge.DefaultValue = (object) false;
      this.columnApplyOnce.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesRow NewtblCompanyPolicyChargesRow()
    {
      return (dsCompanyPolicyFees.tblCompanyPolicyChargesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyPolicyFees.tblCompanyPolicyChargesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyPolicyFees.tblCompanyPolicyChargesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyPolicyChargesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler chargesRowChangedEvent = this.tblCompanyPolicyChargesRowChangedEvent;
      if (chargesRowChangedEvent == null)
        return;
      chargesRowChangedEvent((object) this, new dsCompanyPolicyFees.tblCompanyPolicyChargesRowChangeEvent((dsCompanyPolicyFees.tblCompanyPolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyPolicyChargesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler rowChangingEvent = this.tblCompanyPolicyChargesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyPolicyFees.tblCompanyPolicyChargesRowChangeEvent((dsCompanyPolicyFees.tblCompanyPolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyPolicyChargesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler chargesRowDeletedEvent = this.tblCompanyPolicyChargesRowDeletedEvent;
      if (chargesRowDeletedEvent == null)
        return;
      chargesRowDeletedEvent((object) this, new dsCompanyPolicyFees.tblCompanyPolicyChargesRowChangeEvent((dsCompanyPolicyFees.tblCompanyPolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyPolicyChargesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblCompanyPolicyChargesRowChangeEventHandler rowDeletingEvent = this.tblCompanyPolicyChargesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyPolicyFees.tblCompanyPolicyChargesRowChangeEvent((dsCompanyPolicyFees.tblCompanyPolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyPolicyChargesRow(dsCompanyPolicyFees.tblCompanyPolicyChargesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyPolicyFees companyPolicyFees = new dsCompanyPolicyFees();
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
        FixedValue = companyPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyPolicyChargesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyPolicyFees.GetSchemaSerializable();
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
    TypedTableBase<dsCompanyPolicyFees.tblFin_PolicyChargesRow>
  {
    private DataColumn columnChargeCode;
    private DataColumn columnDescription;
    private DataColumn columnStateID;
    private DataColumn columnSurplusLinesTax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblFin_PolicyChargesDataTable()
    {
      this.TableName = "tblFin_PolicyCharges";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblFin_PolicyChargesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SurplusLinesTaxColumn => this.columnSurplusLinesTax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblFin_PolicyChargesRow this[int index]
    {
      get => (dsCompanyPolicyFees.tblFin_PolicyChargesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblFin_PolicyChargesRow(dsCompanyPolicyFees.tblFin_PolicyChargesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblFin_PolicyChargesRow AddtblFin_PolicyChargesRow(
      string Description,
      string StateID,
      bool SurplusLinesTax)
    {
      dsCompanyPolicyFees.tblFin_PolicyChargesRow row = (dsCompanyPolicyFees.tblFin_PolicyChargesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        null,
        (object) Description,
        (object) StateID,
        (object) SurplusLinesTax
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblFin_PolicyChargesRow FindByChargeCode(int ChargeCode)
    {
      return (dsCompanyPolicyFees.tblFin_PolicyChargesRow) this.Rows.Find(new object[1]
      {
        (object) ChargeCode
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyPolicyFees.tblFin_PolicyChargesDataTable chargesDataTable = (dsCompanyPolicyFees.tblFin_PolicyChargesDataTable) base.Clone();
      chargesDataTable.InitVars();
      return (DataTable) chargesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyPolicyFees.tblFin_PolicyChargesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnDescription = this.Columns["Description"];
      this.columnStateID = this.Columns["StateID"];
      this.columnSurplusLinesTax = this.Columns["SurplusLinesTax"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnSurplusLinesTax = new DataColumn("SurplusLinesTax", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSurplusLinesTax);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyPolicyFeesKey5", new DataColumn[1]
      {
        this.columnChargeCode
      }, true));
      this.columnChargeCode.AutoIncrement = true;
      this.columnChargeCode.AllowDBNull = false;
      this.columnChargeCode.ReadOnly = true;
      this.columnChargeCode.Unique = true;
      this.columnSurplusLinesTax.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblFin_PolicyChargesRow NewtblFin_PolicyChargesRow()
    {
      return (dsCompanyPolicyFees.tblFin_PolicyChargesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyPolicyFees.tblFin_PolicyChargesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyPolicyFees.tblFin_PolicyChargesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblFin_PolicyChargesRowChangeEventHandler chargesRowChangedEvent = this.tblFin_PolicyChargesRowChangedEvent;
      if (chargesRowChangedEvent == null)
        return;
      chargesRowChangedEvent((object) this, new dsCompanyPolicyFees.tblFin_PolicyChargesRowChangeEvent((dsCompanyPolicyFees.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblFin_PolicyChargesRowChangeEventHandler rowChangingEvent = this.tblFin_PolicyChargesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyPolicyFees.tblFin_PolicyChargesRowChangeEvent((dsCompanyPolicyFees.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblFin_PolicyChargesRowChangeEventHandler chargesRowDeletedEvent = this.tblFin_PolicyChargesRowDeletedEvent;
      if (chargesRowDeletedEvent == null)
        return;
      chargesRowDeletedEvent((object) this, new dsCompanyPolicyFees.tblFin_PolicyChargesRowChangeEvent((dsCompanyPolicyFees.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblFin_PolicyChargesRowChangeEventHandler rowDeletingEvent = this.tblFin_PolicyChargesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyPolicyFees.tblFin_PolicyChargesRowChangeEvent((dsCompanyPolicyFees.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblFin_PolicyChargesRow(dsCompanyPolicyFees.tblFin_PolicyChargesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyPolicyFees companyPolicyFees = new dsCompanyPolicyFees();
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
        FixedValue = companyPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblFin_PolicyChargesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyPolicyFees.GetSchemaSerializable();
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
  public class lstFeeAppliesToPaymentDataTable : 
    TypedTableBase<dsCompanyPolicyFees.lstFeeAppliesToPaymentRow>
  {
    private DataColumn columnID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstFeeAppliesToPaymentDataTable()
    {
      this.TableName = "lstFeeAppliesToPayment";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstFeeAppliesToPaymentDataTable(DataTable table)
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
    protected lstFeeAppliesToPaymentDataTable(SerializationInfo info, StreamingContext context)
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
    public dsCompanyPolicyFees.lstFeeAppliesToPaymentRow this[int index]
    {
      get => (dsCompanyPolicyFees.lstFeeAppliesToPaymentRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstFeeAppliesToPaymentRowChangeEventHandler lstFeeAppliesToPaymentRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstFeeAppliesToPaymentRowChangeEventHandler lstFeeAppliesToPaymentRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstFeeAppliesToPaymentRowChangeEventHandler lstFeeAppliesToPaymentRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstFeeAppliesToPaymentRowChangeEventHandler lstFeeAppliesToPaymentRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstFeeAppliesToPaymentRow(dsCompanyPolicyFees.lstFeeAppliesToPaymentRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstFeeAppliesToPaymentRow AddlstFeeAppliesToPaymentRow(
      string ID,
      string Description)
    {
      dsCompanyPolicyFees.lstFeeAppliesToPaymentRow row = (dsCompanyPolicyFees.lstFeeAppliesToPaymentRow) this.NewRow();
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
    public dsCompanyPolicyFees.lstFeeAppliesToPaymentRow FindByID(string ID)
    {
      return (dsCompanyPolicyFees.lstFeeAppliesToPaymentRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyPolicyFees.lstFeeAppliesToPaymentDataTable paymentDataTable = (dsCompanyPolicyFees.lstFeeAppliesToPaymentDataTable) base.Clone();
      paymentDataTable.InitVars();
      return (DataTable) paymentDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyPolicyFees.lstFeeAppliesToPaymentDataTable();
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
      this.columnDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstFeeAppliesToPaymentRow NewlstFeeAppliesToPaymentRow()
    {
      return (dsCompanyPolicyFees.lstFeeAppliesToPaymentRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyPolicyFees.lstFeeAppliesToPaymentRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyPolicyFees.lstFeeAppliesToPaymentRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeAppliesToPaymentRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstFeeAppliesToPaymentRowChangeEventHandler paymentRowChangedEvent = this.lstFeeAppliesToPaymentRowChangedEvent;
      if (paymentRowChangedEvent == null)
        return;
      paymentRowChangedEvent((object) this, new dsCompanyPolicyFees.lstFeeAppliesToPaymentRowChangeEvent((dsCompanyPolicyFees.lstFeeAppliesToPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeAppliesToPaymentRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstFeeAppliesToPaymentRowChangeEventHandler rowChangingEvent = this.lstFeeAppliesToPaymentRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyPolicyFees.lstFeeAppliesToPaymentRowChangeEvent((dsCompanyPolicyFees.lstFeeAppliesToPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeAppliesToPaymentRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstFeeAppliesToPaymentRowChangeEventHandler paymentRowDeletedEvent = this.lstFeeAppliesToPaymentRowDeletedEvent;
      if (paymentRowDeletedEvent == null)
        return;
      paymentRowDeletedEvent((object) this, new dsCompanyPolicyFees.lstFeeAppliesToPaymentRowChangeEvent((dsCompanyPolicyFees.lstFeeAppliesToPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeAppliesToPaymentRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstFeeAppliesToPaymentRowChangeEventHandler rowDeletingEvent = this.lstFeeAppliesToPaymentRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyPolicyFees.lstFeeAppliesToPaymentRowChangeEvent((dsCompanyPolicyFees.lstFeeAppliesToPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstFeeAppliesToPaymentRow(dsCompanyPolicyFees.lstFeeAppliesToPaymentRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyPolicyFees companyPolicyFees = new dsCompanyPolicyFees();
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
        FixedValue = companyPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstFeeAppliesToPaymentDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyPolicyFees.GetSchemaSerializable();
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
  public class tblCompanyLocationsDataTable : 
    TypedTableBase<dsCompanyPolicyFees.tblCompanyLocationsRow>
  {
    private DataColumn columnCompanyLocationGuid;
    private DataColumn columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyLocationsDataTable()
    {
      this.TableName = "tblCompanyLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyLocationsDataTable(DataTable table)
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
    protected tblCompanyLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationNameColumn => this.columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyLocationsRow this[int index]
    {
      get => (dsCompanyPolicyFees.tblCompanyLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyLocationsRow(dsCompanyPolicyFees.tblCompanyLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyLocationsRow AddtblCompanyLocationsRow(
      Guid CompanyLocationGuid,
      string LocationName)
    {
      dsCompanyPolicyFees.tblCompanyLocationsRow row = (dsCompanyPolicyFees.tblCompanyLocationsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyLocationGuid,
        (object) LocationName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyLocationsRow FindByCompanyLocationGuid(
      Guid CompanyLocationGuid)
    {
      return (dsCompanyPolicyFees.tblCompanyLocationsRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLocationGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyPolicyFees.tblCompanyLocationsDataTable locationsDataTable = (dsCompanyPolicyFees.tblCompanyLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyPolicyFees.tblCompanyLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
      this.columnLocationName = this.Columns["LocationName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.columnLocationName = new DataColumn("LocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyPolicyFeesKey2", new DataColumn[1]
      {
        this.columnCompanyLocationGuid
      }, true));
      this.columnCompanyLocationGuid.AllowDBNull = false;
      this.columnCompanyLocationGuid.Unique = true;
      this.columnLocationName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyLocationsRow NewtblCompanyLocationsRow()
    {
      return (dsCompanyPolicyFees.tblCompanyLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyPolicyFees.tblCompanyLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyPolicyFees.tblCompanyLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblCompanyLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblCompanyLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsCompanyPolicyFees.tblCompanyLocationsRowChangeEvent((dsCompanyPolicyFees.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblCompanyLocationsRowChangeEventHandler rowChangingEvent = this.tblCompanyLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyPolicyFees.tblCompanyLocationsRowChangeEvent((dsCompanyPolicyFees.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblCompanyLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblCompanyLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsCompanyPolicyFees.tblCompanyLocationsRowChangeEvent((dsCompanyPolicyFees.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblCompanyLocationsRowChangeEventHandler rowDeletingEvent = this.tblCompanyLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyPolicyFees.tblCompanyLocationsRowChangeEvent((dsCompanyPolicyFees.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyLocationsRow(dsCompanyPolicyFees.tblCompanyLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyPolicyFees companyPolicyFees = new dsCompanyPolicyFees();
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
        FixedValue = companyPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyPolicyFees.GetSchemaSerializable();
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
  public class lstStatesDataTable : TypedTableBase<dsCompanyPolicyFees.lstStatesRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstStatesDataTable()
    {
      this.TableName = "lstStates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstStatesDataTable(DataTable table)
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
    protected lstStatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstStatesRow this[int index]
    {
      get => (dsCompanyPolicyFees.lstStatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstStatesRowChangeEventHandler lstStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstStatesRowChangeEventHandler lstStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstStatesRowChangeEventHandler lstStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstStatesRowChangeEventHandler lstStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstStatesRow(dsCompanyPolicyFees.lstStatesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstStatesRow AddlstStatesRow(string StateID, string State)
    {
      dsCompanyPolicyFees.lstStatesRow row = (dsCompanyPolicyFees.lstStatesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) StateID,
        (object) State
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstStatesRow FindByStateID(string StateID)
    {
      return (dsCompanyPolicyFees.lstStatesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyPolicyFees.lstStatesDataTable lstStatesDataTable = (dsCompanyPolicyFees.lstStatesDataTable) base.Clone();
      lstStatesDataTable.InitVars();
      return (DataTable) lstStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyPolicyFees.lstStatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnState = this.Columns["State"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyPolicyFeesKey6", new DataColumn[1]
      {
        this.columnStateID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.Unique = true;
      this.columnState.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstStatesRow NewlstStatesRow()
    {
      return (dsCompanyPolicyFees.lstStatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyPolicyFees.lstStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyPolicyFees.lstStatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstStatesRowChangeEventHandler statesRowChangedEvent = this.lstStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsCompanyPolicyFees.lstStatesRowChangeEvent((dsCompanyPolicyFees.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstStatesRowChangeEventHandler rowChangingEvent = this.lstStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyPolicyFees.lstStatesRowChangeEvent((dsCompanyPolicyFees.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstStatesRowChangeEventHandler statesRowDeletedEvent = this.lstStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsCompanyPolicyFees.lstStatesRowChangeEvent((dsCompanyPolicyFees.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstStatesRowChangeEventHandler rowDeletingEvent = this.lstStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyPolicyFees.lstStatesRowChangeEvent((dsCompanyPolicyFees.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstStatesRow(dsCompanyPolicyFees.lstStatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyPolicyFees companyPolicyFees = new dsCompanyPolicyFees();
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
        FixedValue = companyPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyPolicyFees.GetSchemaSerializable();
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
  public class lstLinesDataTable : TypedTableBase<dsCompanyPolicyFees.lstLinesRow>
  {
    private DataColumn columnLineGuid;
    private DataColumn columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstLinesDataTable()
    {
      this.TableName = "lstLines";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstLinesDataTable(DataTable table)
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
    protected lstLinesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineGuidColumn => this.columnLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstLinesRow this[int index]
    {
      get => (dsCompanyPolicyFees.lstLinesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstLinesRowChangeEventHandler lstLinesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstLinesRowChangeEventHandler lstLinesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstLinesRowChangeEventHandler lstLinesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstLinesRowChangeEventHandler lstLinesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstLinesRow(dsCompanyPolicyFees.lstLinesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstLinesRow AddlstLinesRow(Guid LineGuid, string LineName)
    {
      dsCompanyPolicyFees.lstLinesRow row = (dsCompanyPolicyFees.lstLinesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) LineGuid,
        (object) LineName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstLinesRow FindByLineGuid(Guid LineGuid)
    {
      return (dsCompanyPolicyFees.lstLinesRow) this.Rows.Find(new object[1]
      {
        (object) LineGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyPolicyFees.lstLinesDataTable lstLinesDataTable = (dsCompanyPolicyFees.lstLinesDataTable) base.Clone();
      lstLinesDataTable.InitVars();
      return (DataTable) lstLinesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyPolicyFees.lstLinesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnLineGuid = this.Columns["LineGuid"];
      this.columnLineName = this.Columns["LineName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnLineGuid = new DataColumn("LineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGuid);
      this.columnLineName = new DataColumn("LineName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyPolicyFeesKey7", new DataColumn[1]
      {
        this.columnLineGuid
      }, true));
      this.columnLineGuid.AllowDBNull = false;
      this.columnLineGuid.Unique = true;
      this.columnLineName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstLinesRow NewlstLinesRow()
    {
      return (dsCompanyPolicyFees.lstLinesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyPolicyFees.lstLinesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyPolicyFees.lstLinesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstLinesRowChangeEventHandler linesRowChangedEvent = this.lstLinesRowChangedEvent;
      if (linesRowChangedEvent == null)
        return;
      linesRowChangedEvent((object) this, new dsCompanyPolicyFees.lstLinesRowChangeEvent((dsCompanyPolicyFees.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstLinesRowChangeEventHandler rowChangingEvent = this.lstLinesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyPolicyFees.lstLinesRowChangeEvent((dsCompanyPolicyFees.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstLinesRowChangeEventHandler linesRowDeletedEvent = this.lstLinesRowDeletedEvent;
      if (linesRowDeletedEvent == null)
        return;
      linesRowDeletedEvent((object) this, new dsCompanyPolicyFees.lstLinesRowChangeEvent((dsCompanyPolicyFees.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstLinesRowChangeEventHandler rowDeletingEvent = this.lstLinesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyPolicyFees.lstLinesRowChangeEvent((dsCompanyPolicyFees.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstLinesRow(dsCompanyPolicyFees.lstLinesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyPolicyFees companyPolicyFees = new dsCompanyPolicyFees();
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
        FixedValue = companyPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstLinesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyPolicyFees.GetSchemaSerializable();
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
  public class lstCompanyLicenseTypesDataTable : 
    TypedTableBase<dsCompanyPolicyFees.lstCompanyLicenseTypesRow>
  {
    private DataColumn columnCompanyLicenceTypeID;
    private DataColumn columnCompanyLicenceType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstCompanyLicenseTypesDataTable()
    {
      this.TableName = "lstCompanyLicenseTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstCompanyLicenseTypesDataTable(DataTable table)
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
    protected lstCompanyLicenseTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLicenceTypeIDColumn => this.columnCompanyLicenceTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLicenceTypeColumn => this.columnCompanyLicenceType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstCompanyLicenseTypesRow this[int index]
    {
      get => (dsCompanyPolicyFees.lstCompanyLicenseTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstCompanyLicenseTypesRowChangeEventHandler lstCompanyLicenseTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstCompanyLicenseTypesRowChangeEventHandler lstCompanyLicenseTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstCompanyLicenseTypesRowChangeEventHandler lstCompanyLicenseTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstCompanyLicenseTypesRowChangeEventHandler lstCompanyLicenseTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstCompanyLicenseTypesRow(dsCompanyPolicyFees.lstCompanyLicenseTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstCompanyLicenseTypesRow AddlstCompanyLicenseTypesRow(
      int CompanyLicenceTypeID,
      string CompanyLicenceType)
    {
      dsCompanyPolicyFees.lstCompanyLicenseTypesRow row = (dsCompanyPolicyFees.lstCompanyLicenseTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyLicenceTypeID,
        (object) CompanyLicenceType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstCompanyLicenseTypesRow FindByCompanyLicenceTypeID(
      int CompanyLicenceTypeID)
    {
      return (dsCompanyPolicyFees.lstCompanyLicenseTypesRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLicenceTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyPolicyFees.lstCompanyLicenseTypesDataTable licenseTypesDataTable = (dsCompanyPolicyFees.lstCompanyLicenseTypesDataTable) base.Clone();
      licenseTypesDataTable.InitVars();
      return (DataTable) licenseTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyPolicyFees.lstCompanyLicenseTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLicenceTypeID = this.Columns["CompanyLicenceTypeID"];
      this.columnCompanyLicenceType = this.Columns["CompanyLicenceType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLicenceTypeID = new DataColumn("CompanyLicenceTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLicenceTypeID);
      this.columnCompanyLicenceType = new DataColumn("CompanyLicenceType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLicenceType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyPolicyFeesKey8", new DataColumn[1]
      {
        this.columnCompanyLicenceTypeID
      }, true));
      this.columnCompanyLicenceTypeID.AllowDBNull = false;
      this.columnCompanyLicenceTypeID.Unique = true;
      this.columnCompanyLicenceType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstCompanyLicenseTypesRow NewlstCompanyLicenseTypesRow()
    {
      return (dsCompanyPolicyFees.lstCompanyLicenseTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyPolicyFees.lstCompanyLicenseTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyPolicyFees.lstCompanyLicenseTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCompanyLicenseTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstCompanyLicenseTypesRowChangeEventHandler typesRowChangedEvent = this.lstCompanyLicenseTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompanyPolicyFees.lstCompanyLicenseTypesRowChangeEvent((dsCompanyPolicyFees.lstCompanyLicenseTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCompanyLicenseTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstCompanyLicenseTypesRowChangeEventHandler rowChangingEvent = this.lstCompanyLicenseTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyPolicyFees.lstCompanyLicenseTypesRowChangeEvent((dsCompanyPolicyFees.lstCompanyLicenseTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCompanyLicenseTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstCompanyLicenseTypesRowChangeEventHandler typesRowDeletedEvent = this.lstCompanyLicenseTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompanyPolicyFees.lstCompanyLicenseTypesRowChangeEvent((dsCompanyPolicyFees.lstCompanyLicenseTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCompanyLicenseTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstCompanyLicenseTypesRowChangeEventHandler rowDeletingEvent = this.lstCompanyLicenseTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyPolicyFees.lstCompanyLicenseTypesRowChangeEvent((dsCompanyPolicyFees.lstCompanyLicenseTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstCompanyLicenseTypesRow(dsCompanyPolicyFees.lstCompanyLicenseTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyPolicyFees companyPolicyFees = new dsCompanyPolicyFees();
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
        FixedValue = companyPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstCompanyLicenseTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyPolicyFees.GetSchemaSerializable();
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
  public class tblKentuckyCitiesDataTable : TypedTableBase<dsCompanyPolicyFees.tblKentuckyCitiesRow>
  {
    private DataColumn columnCityID;
    private DataColumn columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblKentuckyCitiesDataTable()
    {
      this.TableName = "tblKentuckyCities";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblKentuckyCitiesDataTable(DataTable table)
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
    protected tblKentuckyCitiesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CityIDColumn => this.columnCityID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblKentuckyCitiesRow this[int index]
    {
      get => (dsCompanyPolicyFees.tblKentuckyCitiesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblKentuckyCitiesRowChangeEventHandler tblKentuckyCitiesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblKentuckyCitiesRowChangeEventHandler tblKentuckyCitiesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblKentuckyCitiesRowChangeEventHandler tblKentuckyCitiesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblKentuckyCitiesRowChangeEventHandler tblKentuckyCitiesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblKentuckyCitiesRow(dsCompanyPolicyFees.tblKentuckyCitiesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblKentuckyCitiesRow AddtblKentuckyCitiesRow(string City)
    {
      dsCompanyPolicyFees.tblKentuckyCitiesRow row = (dsCompanyPolicyFees.tblKentuckyCitiesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) City
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblKentuckyCitiesRow FindByCityID(int CityID)
    {
      return (dsCompanyPolicyFees.tblKentuckyCitiesRow) this.Rows.Find(new object[1]
      {
        (object) CityID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyPolicyFees.tblKentuckyCitiesDataTable kentuckyCitiesDataTable = (dsCompanyPolicyFees.tblKentuckyCitiesDataTable) base.Clone();
      kentuckyCitiesDataTable.InitVars();
      return (DataTable) kentuckyCitiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyPolicyFees.tblKentuckyCitiesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCityID = this.Columns["CityID"];
      this.columnCity = this.Columns["City"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCityID = new DataColumn("CityID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCityID);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCityID
      }, true));
      this.columnCityID.AutoIncrement = true;
      this.columnCityID.AutoIncrementSeed = -1L;
      this.columnCityID.AutoIncrementStep = -1L;
      this.columnCityID.AllowDBNull = false;
      this.columnCityID.ReadOnly = true;
      this.columnCityID.Unique = true;
      this.columnCity.AllowDBNull = false;
      this.columnCity.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblKentuckyCitiesRow NewtblKentuckyCitiesRow()
    {
      return (dsCompanyPolicyFees.tblKentuckyCitiesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyPolicyFees.tblKentuckyCitiesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyPolicyFees.tblKentuckyCitiesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblKentuckyCitiesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblKentuckyCitiesRowChangeEventHandler citiesRowChangedEvent = this.tblKentuckyCitiesRowChangedEvent;
      if (citiesRowChangedEvent == null)
        return;
      citiesRowChangedEvent((object) this, new dsCompanyPolicyFees.tblKentuckyCitiesRowChangeEvent((dsCompanyPolicyFees.tblKentuckyCitiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblKentuckyCitiesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblKentuckyCitiesRowChangeEventHandler rowChangingEvent = this.tblKentuckyCitiesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyPolicyFees.tblKentuckyCitiesRowChangeEvent((dsCompanyPolicyFees.tblKentuckyCitiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblKentuckyCitiesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblKentuckyCitiesRowChangeEventHandler citiesRowDeletedEvent = this.tblKentuckyCitiesRowDeletedEvent;
      if (citiesRowDeletedEvent == null)
        return;
      citiesRowDeletedEvent((object) this, new dsCompanyPolicyFees.tblKentuckyCitiesRowChangeEvent((dsCompanyPolicyFees.tblKentuckyCitiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblKentuckyCitiesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblKentuckyCitiesRowChangeEventHandler rowDeletingEvent = this.tblKentuckyCitiesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyPolicyFees.tblKentuckyCitiesRowChangeEvent((dsCompanyPolicyFees.tblKentuckyCitiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblKentuckyCitiesRow(dsCompanyPolicyFees.tblKentuckyCitiesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyPolicyFees companyPolicyFees = new dsCompanyPolicyFees();
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
        FixedValue = companyPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblKentuckyCitiesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyPolicyFees.GetSchemaSerializable();
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
  public class tblUsersDataTable : TypedTableBase<dsCompanyPolicyFees.tblUsersRow>
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
    public dsCompanyPolicyFees.tblUsersRow this[int index]
    {
      get => (dsCompanyPolicyFees.tblUsersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblUsersRowChangeEventHandler tblUsersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblUsersRowChangeEventHandler tblUsersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblUsersRowChangeEventHandler tblUsersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblUsersRowChangeEventHandler tblUsersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblUsersRow(dsCompanyPolicyFees.tblUsersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblUsersRow AddtblUsersRow(string UserGUID, string Name_LastFirst)
    {
      dsCompanyPolicyFees.tblUsersRow row = (dsCompanyPolicyFees.tblUsersRow) this.NewRow();
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
    public dsCompanyPolicyFees.tblUsersRow FindByUserGUID(string UserGUID)
    {
      return (dsCompanyPolicyFees.tblUsersRow) this.Rows.Find(new object[1]
      {
        (object) UserGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyPolicyFees.tblUsersDataTable tblUsersDataTable = (dsCompanyPolicyFees.tblUsersDataTable) base.Clone();
      tblUsersDataTable.InitVars();
      return (DataTable) tblUsersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyPolicyFees.tblUsersDataTable();
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
      this.columnUserGUID = new DataColumn("UserGUID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUID);
      this.columnName_LastFirst = new DataColumn("Name_LastFirst", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName_LastFirst);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnUserGUID
      }, true));
      this.columnUserGUID.AllowDBNull = false;
      this.columnUserGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblUsersRow NewtblUsersRow()
    {
      return (dsCompanyPolicyFees.tblUsersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyPolicyFees.tblUsersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyPolicyFees.tblUsersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblUsersRowChangeEventHandler usersRowChangedEvent = this.tblUsersRowChangedEvent;
      if (usersRowChangedEvent == null)
        return;
      usersRowChangedEvent((object) this, new dsCompanyPolicyFees.tblUsersRowChangeEvent((dsCompanyPolicyFees.tblUsersRow) e.Row, e.Action));
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
      dsCompanyPolicyFees.tblUsersRowChangeEventHandler rowChangingEvent = this.tblUsersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyPolicyFees.tblUsersRowChangeEvent((dsCompanyPolicyFees.tblUsersRow) e.Row, e.Action));
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
      dsCompanyPolicyFees.tblUsersRowChangeEventHandler usersRowDeletedEvent = this.tblUsersRowDeletedEvent;
      if (usersRowDeletedEvent == null)
        return;
      usersRowDeletedEvent((object) this, new dsCompanyPolicyFees.tblUsersRowChangeEvent((dsCompanyPolicyFees.tblUsersRow) e.Row, e.Action));
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
      dsCompanyPolicyFees.tblUsersRowChangeEventHandler rowDeletingEvent = this.tblUsersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyPolicyFees.tblUsersRowChangeEvent((dsCompanyPolicyFees.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblUsersRow(dsCompanyPolicyFees.tblUsersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyPolicyFees companyPolicyFees = new dsCompanyPolicyFees();
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
        FixedValue = companyPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUsersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyPolicyFees.GetSchemaSerializable();
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
  public class lstPolicyTypesDataTable : TypedTableBase<dsCompanyPolicyFees.lstPolicyTypesRow>
  {
    private DataColumn columnPolicyTypeID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstPolicyTypesDataTable()
    {
      this.TableName = "lstPolicyTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstPolicyTypesDataTable(DataTable table)
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
    protected lstPolicyTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyTypeIDColumn => this.columnPolicyTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstPolicyTypesRow this[int index]
    {
      get => (dsCompanyPolicyFees.lstPolicyTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstPolicyTypesRow(dsCompanyPolicyFees.lstPolicyTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstPolicyTypesRow AddlstPolicyTypesRow(
      int PolicyTypeID,
      string Description)
    {
      dsCompanyPolicyFees.lstPolicyTypesRow row = (dsCompanyPolicyFees.lstPolicyTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) PolicyTypeID,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyPolicyFees.lstPolicyTypesDataTable policyTypesDataTable = (dsCompanyPolicyFees.lstPolicyTypesDataTable) base.Clone();
      policyTypesDataTable.InitVars();
      return (DataTable) policyTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyPolicyFees.lstPolicyTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnPolicyTypeID = this.Columns["PolicyTypeID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnPolicyTypeID = new DataColumn("PolicyTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyTypeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstPolicyTypesRow NewlstPolicyTypesRow()
    {
      return (dsCompanyPolicyFees.lstPolicyTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyPolicyFees.lstPolicyTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyPolicyFees.lstPolicyTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstPolicyTypesRowChangeEventHandler typesRowChangedEvent = this.lstPolicyTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompanyPolicyFees.lstPolicyTypesRowChangeEvent((dsCompanyPolicyFees.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstPolicyTypesRowChangeEventHandler rowChangingEvent = this.lstPolicyTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyPolicyFees.lstPolicyTypesRowChangeEvent((dsCompanyPolicyFees.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstPolicyTypesRowChangeEventHandler typesRowDeletedEvent = this.lstPolicyTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompanyPolicyFees.lstPolicyTypesRowChangeEvent((dsCompanyPolicyFees.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.lstPolicyTypesRowChangeEventHandler rowDeletingEvent = this.lstPolicyTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyPolicyFees.lstPolicyTypesRowChangeEvent((dsCompanyPolicyFees.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstPolicyTypesRow(dsCompanyPolicyFees.lstPolicyTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyPolicyFees companyPolicyFees = new dsCompanyPolicyFees();
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
        FixedValue = companyPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPolicyTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyPolicyFees.GetSchemaSerializable();
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
  public class tblCompanyPolicyChargesPolicyTypesDataTable : 
    TypedTableBase<dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow>
  {
    private DataColumn columnCompanyFeeID;
    private DataColumn columnPolicyTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyPolicyChargesPolicyTypesDataTable()
    {
      this.TableName = "tblCompanyPolicyChargesPolicyTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyPolicyChargesPolicyTypesDataTable(DataTable table)
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
    protected tblCompanyPolicyChargesPolicyTypesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyFeeIDColumn => this.columnCompanyFeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyTypeIDColumn => this.columnPolicyTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow this[int index]
    {
      get => (dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRowChangeEventHandler tblCompanyPolicyChargesPolicyTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRowChangeEventHandler tblCompanyPolicyChargesPolicyTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRowChangeEventHandler tblCompanyPolicyChargesPolicyTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRowChangeEventHandler tblCompanyPolicyChargesPolicyTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyPolicyChargesPolicyTypesRow(
      dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow AddtblCompanyPolicyChargesPolicyTypesRow(
      int CompanyFeeID,
      int PolicyTypeID)
    {
      dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow row = (dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyFeeID,
        (object) PolicyTypeID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow FindByCompanyFeeIDPolicyTypeID(
      int CompanyFeeID,
      int PolicyTypeID)
    {
      return (dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow) this.Rows.Find(new object[2]
      {
        (object) CompanyFeeID,
        (object) PolicyTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesDataTable policyTypesDataTable = (dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesDataTable) base.Clone();
      policyTypesDataTable.InitVars();
      return (DataTable) policyTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyFeeID = this.Columns["CompanyFeeID"];
      this.columnPolicyTypeID = this.Columns["PolicyTypeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyFeeID = new DataColumn("CompanyFeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyFeeID);
      this.columnPolicyTypeID = new DataColumn("PolicyTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyTypeID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnCompanyFeeID,
        this.columnPolicyTypeID
      }, true));
      this.columnCompanyFeeID.AllowDBNull = false;
      this.columnPolicyTypeID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow NewtblCompanyPolicyChargesPolicyTypesRow()
    {
      return (dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyPolicyChargesPolicyTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRowChangeEventHandler typesRowChangedEvent = this.tblCompanyPolicyChargesPolicyTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRowChangeEvent((dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyPolicyChargesPolicyTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRowChangeEventHandler rowChangingEvent = this.tblCompanyPolicyChargesPolicyTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRowChangeEvent((dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyPolicyChargesPolicyTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRowChangeEventHandler typesRowDeletedEvent = this.tblCompanyPolicyChargesPolicyTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRowChangeEvent((dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyPolicyChargesPolicyTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRowChangeEventHandler rowDeletingEvent = this.tblCompanyPolicyChargesPolicyTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRowChangeEvent((dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyPolicyChargesPolicyTypesRow(
      dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyPolicyFees companyPolicyFees = new dsCompanyPolicyFees();
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
        FixedValue = companyPolicyFees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyPolicyChargesPolicyTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyPolicyFees.GetSchemaSerializable();
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

  public class lstFeeTypesRow : DataRow
  {
    private dsCompanyPolicyFees.lstFeeTypesDataTable tablelstFeeTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstFeeTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstFeeTypes = (dsCompanyPolicyFees.lstFeeTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstFeeTypes.IDColumn]);
      set => this[this.tablelstFeeTypes.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FeeType
    {
      get => Conversions.ToString(this[this.tablelstFeeTypes.FeeTypeColumn]);
      set => this[this.tablelstFeeTypes.FeeTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesRow[] GettblCompanyPolicyChargesRows()
    {
      return this.Table.ChildRelations["lstFeeTypestblCompanyPolicyCharges"] != null ? (dsCompanyPolicyFees.tblCompanyPolicyChargesRow[]) this.GetChildRows(this.Table.ChildRelations["lstFeeTypestblCompanyPolicyCharges"]) : new dsCompanyPolicyFees.tblCompanyPolicyChargesRow[0];
    }
  }

  public class tblClientOfficesRow : DataRow
  {
    private dsCompanyPolicyFees.tblClientOfficesDataTable tabletblClientOffices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblClientOfficesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClientOffices = (dsCompanyPolicyFees.tblClientOfficesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid OfficeGuid
    {
      get
      {
        object obj = this[this.tabletblClientOffices.OfficeGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblClientOffices.OfficeGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Location
    {
      get => Conversions.ToString(this[this.tabletblClientOffices.LocationColumn]);
      set => this[this.tabletblClientOffices.LocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int OfficeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblClientOffices.OfficeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfficeID' in table 'tblClientOffices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClientOffices.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int StatusID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblClientOffices.StatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusID' in table 'tblClientOffices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClientOffices.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOfficeIDNull() => this.IsNull(this.tabletblClientOffices.OfficeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOfficeIDNull()
    {
      this[this.tabletblClientOffices.OfficeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStatusIDNull() => this.IsNull(this.tabletblClientOffices.StatusIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStatusIDNull()
    {
      this[this.tabletblClientOffices.StatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblCompanyPolicyChargesRow : DataRow
  {
    private dsCompanyPolicyFees.tblCompanyPolicyChargesDataTable tabletblCompanyPolicyCharges;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyPolicyChargesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyPolicyCharges = (dsCompanyPolicyFees.tblCompanyPolicyChargesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CompanyFeeID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyPolicyCharges.CompanyFeeIDColumn]);
      set => this[this.tabletblCompanyPolicyCharges.CompanyFeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ChargeCode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyPolicyCharges.ChargeCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeCode' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyPolicyCharges.CompanyLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLocationGuid' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.CompanyLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid LineGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyPolicyCharges.LineGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LineGuid' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.LineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyPolicyCharges.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int FeeTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyPolicyCharges.FeeTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FeeTypeID' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.FeeTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CompanyLicenceTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyPolicyCharges.CompanyLicenceTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLicenceTypeID' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.CompanyLicenceTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Payable
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.PayableColumn]);
      set => this[this.tabletblCompanyPolicyCharges.PayableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid PayableEntityGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyPolicyCharges.PayableEntityGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PayableEntityGuid' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.PayableEntityGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PayableEntityType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyPolicyCharges.PayableEntityTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PayableEntityType' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.PayableEntityTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal FlatRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyPolicyCharges.FlatRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FlatRate' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.FlatRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal PercentageRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyPolicyCharges.PercentageRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PercentageRate' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.PercentageRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal ApplyPremiumEqualOrLess
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyPolicyCharges.ApplyPremiumEqualOrLessColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ApplyPremiumEqualOrLess' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.ApplyPremiumEqualOrLessColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal ApplyPremiumEqualOrOver
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyPolicyCharges.ApplyPremiumEqualOrOverColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ApplyPremiumEqualOrOver' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.ApplyPremiumEqualOrOverColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool AutoApply
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.AutoApplyColumn]);
      set => this[this.tabletblCompanyPolicyCharges.AutoApplyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime Effective
    {
      get => Conversions.ToDate(this[this.tabletblCompanyPolicyCharges.EffectiveColumn]);
      set => this[this.tabletblCompanyPolicyCharges.EffectiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Splittable
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.SplittableColumn]);
      set => this[this.tabletblCompanyPolicyCharges.SplittableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int OfficeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyPolicyCharges.OfficeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfficeID' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PayableEntity
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyPolicyCharges.PayableEntityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PayableEntity' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.PayableEntityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyPolicyCharges.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Minimum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyPolicyCharges.MinimumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Minimum' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.MinimumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ExcludeWhenNotFiling
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.ExcludeWhenNotFilingColumn]);
      }
      set => this[this.tabletblCompanyPolicyCharges.ExcludeWhenNotFilingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ExcludeOnEndorsements
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.ExcludeOnEndorsementsColumn]);
      }
      set => this[this.tabletblCompanyPolicyCharges.ExcludeOnEndorsementsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ExcludeOnRenewal
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.ExcludeOnRenewalColumn]);
      set => this[this.tabletblCompanyPolicyCharges.ExcludeOnRenewalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AppliesToPaymentID
    {
      get => Conversions.ToString(this[this.tabletblCompanyPolicyCharges.AppliesToPaymentIDColumn]);
      set => this[this.tabletblCompanyPolicyCharges.AppliesToPaymentIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool FullyEarned
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.FullyEarnedColumn]);
      set => this[this.tabletblCompanyPolicyCharges.FullyEarnedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool RoundToDollar
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.RoundToDollarColumn]);
      set => this[this.tabletblCompanyPolicyCharges.RoundToDollarColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal MaxPercentage
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyPolicyCharges.MaxPercentageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MaxPercentage' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.MaxPercentageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int MaxDollars
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyPolicyCharges.MaxDollarsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MaxDollars' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.MaxDollarsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime Disabled
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblCompanyPolicyCharges.DisabledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Disabled' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.DisabledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool PercentageNet
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.PercentageNetColumn]);
      set => this[this.tabletblCompanyPolicyCharges.PercentageNetColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool TerrorismExcluded
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.TerrorismExcludedColumn]);
      set => this[this.tabletblCompanyPolicyCharges.TerrorismExcludedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool FeeBasedOnNumberOfLocations
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.FeeBasedOnNumberOfLocationsColumn]);
      }
      set
      {
        this[this.tabletblCompanyPolicyCharges.FeeBasedOnNumberOfLocationsColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool StateOfIssuanceOnly
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.StateOfIssuanceOnlyColumn]);
      }
      set => this[this.tabletblCompanyPolicyCharges.StateOfIssuanceOnlyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int MinStrat
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyPolicyCharges.MinStratColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MinStrat' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.MinStratColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int MaxStrat
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyPolicyCharges.MaxStratColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MaxStrat' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.MaxStratColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public short FullyEarnedNumDays
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblCompanyPolicyCharges.FullyEarnedNumDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FullyEarnedNumDays' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.FullyEarnedNumDaysColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool SendToAccounting
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.SendToAccountingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SendToAccounting' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.SendToAccountingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool RoundDown
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.RoundDownColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RoundDown' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.RoundDownColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool RoundUp
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.RoundUpColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RoundUp' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.RoundUpColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool NoRounding
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.NoRoundingColumn]);
      set => this[this.tabletblCompanyPolicyCharges.NoRoundingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int KentuckyCityID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyPolicyCharges.KentuckyCityIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'KentuckyCityID' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.KentuckyCityIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ApplyPackagePolicyOnly
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.ApplyPackagePolicyOnlyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ApplyPackagePolicyOnly' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.ApplyPackagePolicyOnlyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool DoNotApplyPackagePolicyOnly
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.DoNotApplyPackagePolicyOnlyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DoNotApplyPackagePolicyOnly' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyPolicyCharges.DoNotApplyPackagePolicyOnlyColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PremiumAllocationType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyPolicyCharges.PremiumAllocationTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PremiumAllocationType' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.PremiumAllocationTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool FeeBasedOnNumberOfVehicles
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.FeeBasedOnNumberOfVehiclesColumn]);
      }
      set
      {
        this[this.tabletblCompanyPolicyCharges.FeeBasedOnNumberOfVehiclesColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool AppliesToAllStates
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.AppliesToAllStatesColumn]);
      }
      set => this[this.tabletblCompanyPolicyCharges.AppliesToAllStatesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool MasterPayee
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.MasterPayeeColumn]);
      set => this[this.tabletblCompanyPolicyCharges.MasterPayeeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool PayHomeState
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.PayHomeStateColumn]);
      set => this[this.tabletblCompanyPolicyCharges.PayHomeStateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool InternationalStratification
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.InternationalStratificationColumn]);
      }
      set
      {
        this[this.tabletblCompanyPolicyCharges.InternationalStratificationColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ExcludeInternationalPremiums
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.ExcludeInternationalPremiumsColumn]);
      }
      set
      {
        this[this.tabletblCompanyPolicyCharges.ExcludeInternationalPremiumsColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ApplyToChildLines
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.ApplyToChildLinesColumn]);
      set => this[this.tabletblCompanyPolicyCharges.ApplyToChildLinesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LineName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyPolicyCharges.LineNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LineName' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.LineNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool RoundToCent
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.RoundToCentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RoundToCent' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.RoundToCentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool RoundUpToCent
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.RoundUpToCentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RoundUpToCent' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.RoundUpToCentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ExcludeMultiCarrier
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.ExcludeMultiCarrierColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExcludeMultiCarrier' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.ExcludeMultiCarrierColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ApplytoFlatCanc
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.ApplytoFlatCancColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ApplytoFlatCanc' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.ApplytoFlatCancColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ExcludeOriginalBinder
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.ExcludeOriginalBinderColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExcludeOriginalBinder' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.ExcludeOriginalBinderColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid AddedBy
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyPolicyCharges.AddedByColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddedBy' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.AddedByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid EditedBy
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyPolicyCharges.EditedByColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EditedBy' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.EditedByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime AddedDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblCompanyPolicyCharges.AddedDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddedDate' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.AddedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime EditedDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblCompanyPolicyCharges.EditedDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EditedDate' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.EditedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Notes
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyPolicyCharges.NotesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Notes' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.NotesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool CountyTaxIncludedInRate
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.CountyTaxIncludedInRateColumn]);
      }
      set => this[this.tabletblCompanyPolicyCharges.CountyTaxIncludedInRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool MandatoryCharge
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.MandatoryChargeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MandatoryCharge' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.MandatoryChargeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ApplyOnce
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyPolicyCharges.ApplyOnceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ApplyOnce' in table 'tblCompanyPolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyPolicyCharges.ApplyOnceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstCompanyLicenseTypesRow lstCompanyLicenseTypesRow
    {
      get
      {
        return (dsCompanyPolicyFees.lstCompanyLicenseTypesRow) this.GetParentRow(this.Table.ParentRelations["lstCompanyLicenseTypestblCompanyPolicyCharges"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstCompanyLicenseTypestblCompanyPolicyCharges"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstStatesRow lstStatesRow
    {
      get
      {
        return (dsCompanyPolicyFees.lstStatesRow) this.GetParentRow(this.Table.ParentRelations["lstStatestblCompanyPolicyCharges"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstStatestblCompanyPolicyCharges"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyLocationsRow tblCompanyLocationsRow
    {
      get
      {
        return (dsCompanyPolicyFees.tblCompanyLocationsRow) this.GetParentRow(this.Table.ParentRelations["tblCompanyLocationstblCompanyPolicyCharges"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompanyLocationstblCompanyPolicyCharges"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstLinesRow lstLinesRow
    {
      get
      {
        return (dsCompanyPolicyFees.lstLinesRow) this.GetParentRow(this.Table.ParentRelations["lstLinestblCompanyPolicyCharges"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstLinestblCompanyPolicyCharges"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstFeeAppliesToPaymentRow lstFeeAppliesToPaymentRow
    {
      get
      {
        return (dsCompanyPolicyFees.lstFeeAppliesToPaymentRow) this.GetParentRow(this.Table.ParentRelations["lstFeeAppliesToPaymenttblCompanyPolicyCharges"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstFeeAppliesToPaymenttblCompanyPolicyCharges"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstFeeTypesRow lstFeeTypesRow
    {
      get
      {
        return (dsCompanyPolicyFees.lstFeeTypesRow) this.GetParentRow(this.Table.ParentRelations["lstFeeTypestblCompanyPolicyCharges"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstFeeTypestblCompanyPolicyCharges"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblKentuckyCitiesRow tblKentuckyCitiesRow
    {
      get
      {
        return (dsCompanyPolicyFees.tblKentuckyCitiesRow) this.GetParentRow(this.Table.ParentRelations["tblKentuckyCities_tblCompanyPolicyCharges"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblKentuckyCities_tblCompanyPolicyCharges"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsChargeCodeNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.ChargeCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetChargeCodeNull()
    {
      this[this.tabletblCompanyPolicyCharges.ChargeCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyLocationGuidNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.CompanyLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyLocationGuidNull()
    {
      this[this.tabletblCompanyPolicyCharges.CompanyLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLineGuidNull() => this.IsNull(this.tabletblCompanyPolicyCharges.LineGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLineGuidNull()
    {
      this[this.tabletblCompanyPolicyCharges.LineGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabletblCompanyPolicyCharges.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblCompanyPolicyCharges.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFeeTypeIDNull() => this.IsNull(this.tabletblCompanyPolicyCharges.FeeTypeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFeeTypeIDNull()
    {
      this[this.tabletblCompanyPolicyCharges.FeeTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyLicenceTypeIDNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.CompanyLicenceTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyLicenceTypeIDNull()
    {
      this[this.tabletblCompanyPolicyCharges.CompanyLicenceTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPayableEntityGuidNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.PayableEntityGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPayableEntityGuidNull()
    {
      this[this.tabletblCompanyPolicyCharges.PayableEntityGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPayableEntityTypeNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.PayableEntityTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPayableEntityTypeNull()
    {
      this[this.tabletblCompanyPolicyCharges.PayableEntityTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFlatRateNull() => this.IsNull(this.tabletblCompanyPolicyCharges.FlatRateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFlatRateNull()
    {
      this[this.tabletblCompanyPolicyCharges.FlatRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPercentageRateNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.PercentageRateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPercentageRateNull()
    {
      this[this.tabletblCompanyPolicyCharges.PercentageRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsApplyPremiumEqualOrLessNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.ApplyPremiumEqualOrLessColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetApplyPremiumEqualOrLessNull()
    {
      this[this.tabletblCompanyPolicyCharges.ApplyPremiumEqualOrLessColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsApplyPremiumEqualOrOverNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.ApplyPremiumEqualOrOverColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetApplyPremiumEqualOrOverNull()
    {
      this[this.tabletblCompanyPolicyCharges.ApplyPremiumEqualOrOverColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOfficeIDNull() => this.IsNull(this.tabletblCompanyPolicyCharges.OfficeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOfficeIDNull()
    {
      this[this.tabletblCompanyPolicyCharges.OfficeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPayableEntityNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.PayableEntityColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPayableEntityNull()
    {
      this[this.tabletblCompanyPolicyCharges.PayableEntityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDescriptionNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.DescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tabletblCompanyPolicyCharges.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMinimumNull() => this.IsNull(this.tabletblCompanyPolicyCharges.MinimumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMinimumNull()
    {
      this[this.tabletblCompanyPolicyCharges.MinimumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMaxPercentageNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.MaxPercentageColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMaxPercentageNull()
    {
      this[this.tabletblCompanyPolicyCharges.MaxPercentageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMaxDollarsNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.MaxDollarsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMaxDollarsNull()
    {
      this[this.tabletblCompanyPolicyCharges.MaxDollarsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDisabledNull() => this.IsNull(this.tabletblCompanyPolicyCharges.DisabledColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDisabledNull()
    {
      this[this.tabletblCompanyPolicyCharges.DisabledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMinStratNull() => this.IsNull(this.tabletblCompanyPolicyCharges.MinStratColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMinStratNull()
    {
      this[this.tabletblCompanyPolicyCharges.MinStratColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMaxStratNull() => this.IsNull(this.tabletblCompanyPolicyCharges.MaxStratColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMaxStratNull()
    {
      this[this.tabletblCompanyPolicyCharges.MaxStratColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFullyEarnedNumDaysNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.FullyEarnedNumDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFullyEarnedNumDaysNull()
    {
      this[this.tabletblCompanyPolicyCharges.FullyEarnedNumDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSendToAccountingNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.SendToAccountingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSendToAccountingNull()
    {
      this[this.tabletblCompanyPolicyCharges.SendToAccountingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRoundDownNull() => this.IsNull(this.tabletblCompanyPolicyCharges.RoundDownColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRoundDownNull()
    {
      this[this.tabletblCompanyPolicyCharges.RoundDownColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRoundUpNull() => this.IsNull(this.tabletblCompanyPolicyCharges.RoundUpColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRoundUpNull()
    {
      this[this.tabletblCompanyPolicyCharges.RoundUpColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsKentuckyCityIDNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.KentuckyCityIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetKentuckyCityIDNull()
    {
      this[this.tabletblCompanyPolicyCharges.KentuckyCityIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsApplyPackagePolicyOnlyNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.ApplyPackagePolicyOnlyColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetApplyPackagePolicyOnlyNull()
    {
      this[this.tabletblCompanyPolicyCharges.ApplyPackagePolicyOnlyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDoNotApplyPackagePolicyOnlyNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.DoNotApplyPackagePolicyOnlyColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDoNotApplyPackagePolicyOnlyNull()
    {
      this[this.tabletblCompanyPolicyCharges.DoNotApplyPackagePolicyOnlyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPremiumAllocationTypeNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.PremiumAllocationTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPremiumAllocationTypeNull()
    {
      this[this.tabletblCompanyPolicyCharges.PremiumAllocationTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLineNameNull() => this.IsNull(this.tabletblCompanyPolicyCharges.LineNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLineNameNull()
    {
      this[this.tabletblCompanyPolicyCharges.LineNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRoundToCentNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.RoundToCentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRoundToCentNull()
    {
      this[this.tabletblCompanyPolicyCharges.RoundToCentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRoundUpToCentNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.RoundUpToCentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRoundUpToCentNull()
    {
      this[this.tabletblCompanyPolicyCharges.RoundUpToCentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsExcludeMultiCarrierNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.ExcludeMultiCarrierColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetExcludeMultiCarrierNull()
    {
      this[this.tabletblCompanyPolicyCharges.ExcludeMultiCarrierColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsApplytoFlatCancNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.ApplytoFlatCancColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetApplytoFlatCancNull()
    {
      this[this.tabletblCompanyPolicyCharges.ApplytoFlatCancColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsExcludeOriginalBinderNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.ExcludeOriginalBinderColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetExcludeOriginalBinderNull()
    {
      this[this.tabletblCompanyPolicyCharges.ExcludeOriginalBinderColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddedByNull() => this.IsNull(this.tabletblCompanyPolicyCharges.AddedByColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddedByNull()
    {
      this[this.tabletblCompanyPolicyCharges.AddedByColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEditedByNull() => this.IsNull(this.tabletblCompanyPolicyCharges.EditedByColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEditedByNull()
    {
      this[this.tabletblCompanyPolicyCharges.EditedByColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddedDateNull() => this.IsNull(this.tabletblCompanyPolicyCharges.AddedDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddedDateNull()
    {
      this[this.tabletblCompanyPolicyCharges.AddedDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEditedDateNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.EditedDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEditedDateNull()
    {
      this[this.tabletblCompanyPolicyCharges.EditedDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNotesNull() => this.IsNull(this.tabletblCompanyPolicyCharges.NotesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNotesNull()
    {
      this[this.tabletblCompanyPolicyCharges.NotesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMandatoryChargeNull()
    {
      return this.IsNull(this.tabletblCompanyPolicyCharges.MandatoryChargeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMandatoryChargeNull()
    {
      this[this.tabletblCompanyPolicyCharges.MandatoryChargeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsApplyOnceNull() => this.IsNull(this.tabletblCompanyPolicyCharges.ApplyOnceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetApplyOnceNull()
    {
      this[this.tabletblCompanyPolicyCharges.ApplyOnceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblFin_PolicyChargesRow : DataRow
  {
    private dsCompanyPolicyFees.tblFin_PolicyChargesDataTable tabletblFin_PolicyCharges;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblFin_PolicyChargesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblFin_PolicyCharges = (dsCompanyPolicyFees.tblFin_PolicyChargesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tabletblFin_PolicyCharges.ChargeCodeColumn]);
      set => this[this.tabletblFin_PolicyCharges.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_PolicyCharges.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'tblFin_PolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_PolicyCharges.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_PolicyCharges.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'tblFin_PolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_PolicyCharges.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool SurplusLinesTax
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblFin_PolicyCharges.SurplusLinesTaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SurplusLinesTax' in table 'tblFin_PolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_PolicyCharges.SurplusLinesTaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDescriptionNull()
    {
      return this.IsNull(this.tabletblFin_PolicyCharges.DescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tabletblFin_PolicyCharges.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabletblFin_PolicyCharges.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblFin_PolicyCharges.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSurplusLinesTaxNull()
    {
      return this.IsNull(this.tabletblFin_PolicyCharges.SurplusLinesTaxColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSurplusLinesTaxNull()
    {
      this[this.tabletblFin_PolicyCharges.SurplusLinesTaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstFeeAppliesToPaymentRow : DataRow
  {
    private dsCompanyPolicyFees.lstFeeAppliesToPaymentDataTable tablelstFeeAppliesToPayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstFeeAppliesToPaymentRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstFeeAppliesToPayment = (dsCompanyPolicyFees.lstFeeAppliesToPaymentDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ID
    {
      get => Conversions.ToString(this[this.tablelstFeeAppliesToPayment.IDColumn]);
      set => this[this.tablelstFeeAppliesToPayment.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstFeeAppliesToPayment.DescriptionColumn]);
      set => this[this.tablelstFeeAppliesToPayment.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesRow[] GettblCompanyPolicyChargesRows()
    {
      return this.Table.ChildRelations["lstFeeAppliesToPaymenttblCompanyPolicyCharges"] != null ? (dsCompanyPolicyFees.tblCompanyPolicyChargesRow[]) this.GetChildRows(this.Table.ChildRelations["lstFeeAppliesToPaymenttblCompanyPolicyCharges"]) : new dsCompanyPolicyFees.tblCompanyPolicyChargesRow[0];
    }
  }

  public class tblCompanyLocationsRow : DataRow
  {
    private dsCompanyPolicyFees.tblCompanyLocationsDataTable tabletblCompanyLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLocations = (dsCompanyPolicyFees.tblCompanyLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLocationGuid
    {
      get
      {
        object obj = this[this.tabletblCompanyLocations.CompanyLocationGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyLocations.CompanyLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LocationName
    {
      get => Conversions.ToString(this[this.tabletblCompanyLocations.LocationNameColumn]);
      set => this[this.tabletblCompanyLocations.LocationNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesRow[] GettblCompanyPolicyChargesRows()
    {
      return this.Table.ChildRelations["tblCompanyLocationstblCompanyPolicyCharges"] != null ? (dsCompanyPolicyFees.tblCompanyPolicyChargesRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompanyLocationstblCompanyPolicyCharges"]) : new dsCompanyPolicyFees.tblCompanyPolicyChargesRow[0];
    }
  }

  public class lstStatesRow : DataRow
  {
    private dsCompanyPolicyFees.lstStatesDataTable tablelstStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStates = (dsCompanyPolicyFees.lstStatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tablelstStates.StateIDColumn]);
      set => this[this.tablelstStates.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tablelstStates.StateColumn]);
      set => this[this.tablelstStates.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesRow[] GettblCompanyPolicyChargesRows()
    {
      return this.Table.ChildRelations["lstStatestblCompanyPolicyCharges"] != null ? (dsCompanyPolicyFees.tblCompanyPolicyChargesRow[]) this.GetChildRows(this.Table.ChildRelations["lstStatestblCompanyPolicyCharges"]) : new dsCompanyPolicyFees.tblCompanyPolicyChargesRow[0];
    }
  }

  public class lstLinesRow : DataRow
  {
    private dsCompanyPolicyFees.lstLinesDataTable tablelstLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstLines = (dsCompanyPolicyFees.lstLinesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid LineGuid
    {
      get
      {
        object obj = this[this.tablelstLines.LineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tablelstLines.LineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LineName
    {
      get => Conversions.ToString(this[this.tablelstLines.LineNameColumn]);
      set => this[this.tablelstLines.LineNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesRow[] GettblCompanyPolicyChargesRows()
    {
      return this.Table.ChildRelations["lstLinestblCompanyPolicyCharges"] != null ? (dsCompanyPolicyFees.tblCompanyPolicyChargesRow[]) this.GetChildRows(this.Table.ChildRelations["lstLinestblCompanyPolicyCharges"]) : new dsCompanyPolicyFees.tblCompanyPolicyChargesRow[0];
    }
  }

  public class lstCompanyLicenseTypesRow : DataRow
  {
    private dsCompanyPolicyFees.lstCompanyLicenseTypesDataTable tablelstCompanyLicenseTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstCompanyLicenseTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstCompanyLicenseTypes = (dsCompanyPolicyFees.lstCompanyLicenseTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CompanyLicenceTypeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tablelstCompanyLicenseTypes.CompanyLicenceTypeIDColumn]);
      }
      set => this[this.tablelstCompanyLicenseTypes.CompanyLicenceTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CompanyLicenceType
    {
      get => Conversions.ToString(this[this.tablelstCompanyLicenseTypes.CompanyLicenceTypeColumn]);
      set => this[this.tablelstCompanyLicenseTypes.CompanyLicenceTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesRow[] GettblCompanyPolicyChargesRows()
    {
      return this.Table.ChildRelations["lstCompanyLicenseTypestblCompanyPolicyCharges"] != null ? (dsCompanyPolicyFees.tblCompanyPolicyChargesRow[]) this.GetChildRows(this.Table.ChildRelations["lstCompanyLicenseTypestblCompanyPolicyCharges"]) : new dsCompanyPolicyFees.tblCompanyPolicyChargesRow[0];
    }
  }

  public class tblKentuckyCitiesRow : DataRow
  {
    private dsCompanyPolicyFees.tblKentuckyCitiesDataTable tabletblKentuckyCities;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblKentuckyCitiesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblKentuckyCities = (dsCompanyPolicyFees.tblKentuckyCitiesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CityID
    {
      get => Conversions.ToInteger(this[this.tabletblKentuckyCities.CityIDColumn]);
      set => this[this.tabletblKentuckyCities.CityIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get => Conversions.ToString(this[this.tabletblKentuckyCities.CityColumn]);
      set => this[this.tabletblKentuckyCities.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesRow[] GettblCompanyPolicyChargesRows()
    {
      return this.Table.ChildRelations["tblKentuckyCities_tblCompanyPolicyCharges"] != null ? (dsCompanyPolicyFees.tblCompanyPolicyChargesRow[]) this.GetChildRows(this.Table.ChildRelations["tblKentuckyCities_tblCompanyPolicyCharges"]) : new dsCompanyPolicyFees.tblCompanyPolicyChargesRow[0];
    }
  }

  public class tblUsersRow : DataRow
  {
    private dsCompanyPolicyFees.tblUsersDataTable tabletblUsers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblUsersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUsers = (dsCompanyPolicyFees.tblUsersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string UserGUID
    {
      get => Conversions.ToString(this[this.tabletblUsers.UserGUIDColumn]);
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

  public class lstPolicyTypesRow : DataRow
  {
    private dsCompanyPolicyFees.lstPolicyTypesDataTable tablelstPolicyTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstPolicyTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPolicyTypes = (dsCompanyPolicyFees.lstPolicyTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablelstPolicyTypes.PolicyTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyTypeID' in table 'lstPolicyTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstPolicyTypes.PolicyTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstPolicyTypes.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'lstPolicyTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstPolicyTypes.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyTypeIDNull() => this.IsNull(this.tablelstPolicyTypes.PolicyTypeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyTypeIDNull()
    {
      this[this.tablelstPolicyTypes.PolicyTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tablelstPolicyTypes.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tablelstPolicyTypes.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblCompanyPolicyChargesPolicyTypesRow : DataRow
  {
    private dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesDataTable tabletblCompanyPolicyChargesPolicyTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyPolicyChargesPolicyTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyPolicyChargesPolicyTypes = (dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CompanyFeeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyPolicyChargesPolicyTypes.CompanyFeeIDColumn]);
      }
      set => this[this.tabletblCompanyPolicyChargesPolicyTypes.CompanyFeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyTypeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyPolicyChargesPolicyTypes.PolicyTypeIDColumn]);
      }
      set => this[this.tabletblCompanyPolicyChargesPolicyTypes.PolicyTypeIDColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstFeeTypesRowChangeEvent : EventArgs
  {
    private dsCompanyPolicyFees.lstFeeTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstFeeTypesRowChangeEvent(dsCompanyPolicyFees.lstFeeTypesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstFeeTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblClientOfficesRowChangeEvent : EventArgs
  {
    private dsCompanyPolicyFees.tblClientOfficesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblClientOfficesRowChangeEvent(
      dsCompanyPolicyFees.tblClientOfficesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblClientOfficesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyPolicyChargesRowChangeEvent : EventArgs
  {
    private dsCompanyPolicyFees.tblCompanyPolicyChargesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyPolicyChargesRowChangeEvent(
      dsCompanyPolicyFees.tblCompanyPolicyChargesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblFin_PolicyChargesRowChangeEvent : EventArgs
  {
    private dsCompanyPolicyFees.tblFin_PolicyChargesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblFin_PolicyChargesRowChangeEvent(
      dsCompanyPolicyFees.tblFin_PolicyChargesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblFin_PolicyChargesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstFeeAppliesToPaymentRowChangeEvent : EventArgs
  {
    private dsCompanyPolicyFees.lstFeeAppliesToPaymentRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstFeeAppliesToPaymentRowChangeEvent(
      dsCompanyPolicyFees.lstFeeAppliesToPaymentRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstFeeAppliesToPaymentRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyLocationsRowChangeEvent : EventArgs
  {
    private dsCompanyPolicyFees.tblCompanyLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyLocationsRowChangeEvent(
      dsCompanyPolicyFees.tblCompanyLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstStatesRowChangeEvent : EventArgs
  {
    private dsCompanyPolicyFees.lstStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstStatesRowChangeEvent(dsCompanyPolicyFees.lstStatesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstLinesRowChangeEvent : EventArgs
  {
    private dsCompanyPolicyFees.lstLinesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstLinesRowChangeEvent(dsCompanyPolicyFees.lstLinesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstLinesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstCompanyLicenseTypesRowChangeEvent : EventArgs
  {
    private dsCompanyPolicyFees.lstCompanyLicenseTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstCompanyLicenseTypesRowChangeEvent(
      dsCompanyPolicyFees.lstCompanyLicenseTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstCompanyLicenseTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblKentuckyCitiesRowChangeEvent : EventArgs
  {
    private dsCompanyPolicyFees.tblKentuckyCitiesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblKentuckyCitiesRowChangeEvent(
      dsCompanyPolicyFees.tblKentuckyCitiesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblKentuckyCitiesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblUsersRowChangeEvent : EventArgs
  {
    private dsCompanyPolicyFees.tblUsersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblUsersRowChangeEvent(dsCompanyPolicyFees.tblUsersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblUsersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstPolicyTypesRowChangeEvent : EventArgs
  {
    private dsCompanyPolicyFees.lstPolicyTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstPolicyTypesRowChangeEvent(
      dsCompanyPolicyFees.lstPolicyTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.lstPolicyTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyPolicyChargesPolicyTypesRowChangeEvent : EventArgs
  {
    private dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyPolicyChargesPolicyTypesRowChangeEvent(
      dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyPolicyFees.tblCompanyPolicyChargesPolicyTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
