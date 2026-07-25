// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.dsCompanies
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
[XmlRoot("dsCompanies")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanies : DataSet
{
  private dsCompanies.tblCompanyContactsDataTable tabletblCompanyContacts;
  private dsCompanies.lstDeliveryMethodDataTable tablelstDeliveryMethod;
  private dsCompanies.tblCompanyLocationsDataTable tabletblCompanyLocations;
  private dsCompanies.lstStatusDataTable tablelstStatus;
  private dsCompanies.lstLocationTypeDataTable tablelstLocationType;
  private dsCompanies.tblCompanyGroupsDataTable tabletblCompanyGroups;
  private dsCompanies.tblCompaniesDataTable tabletblCompanies;
  private dsCompanies.tblIntermediariesDataTable tabletblIntermediaries;
  private dsCompanies.lstFSRDataTable tablelstFSR;
  private dsCompanies.lstFSCDataTable tablelstFSC;
  private dsCompanies.lstRatingBureauDataTable tablelstRatingBureau;
  private dsCompanies.tblUsersDataTable tabletblUsers;
  private DataRelation relationtblCompanyLocationstblCompanyContacts;
  private DataRelation relationtblIntermediariestblCompanyLocations;
  private DataRelation relationtblCompaniestblCompanyLocations;
  private DataRelation relationlstStatustblCompanyLocations;
  private DataRelation relationlstLocationTypetblCompanyLocations;
  private DataRelation relationlstDeliveryMethodtblCompanyLocations;
  private DataRelation relationtblCompanyGroupstblCompanies;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsCompanies()
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
  protected dsCompanies(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyContacts)] != null)
          base.Tables.Add((DataTable) new dsCompanies.tblCompanyContactsDataTable(dataSet.Tables[nameof (tblCompanyContacts)]));
        if (dataSet.Tables[nameof (lstDeliveryMethod)] != null)
          base.Tables.Add((DataTable) new dsCompanies.lstDeliveryMethodDataTable(dataSet.Tables[nameof (lstDeliveryMethod)]));
        if (dataSet.Tables[nameof (tblCompanyLocations)] != null)
          base.Tables.Add((DataTable) new dsCompanies.tblCompanyLocationsDataTable(dataSet.Tables[nameof (tblCompanyLocations)]));
        if (dataSet.Tables[nameof (lstStatus)] != null)
          base.Tables.Add((DataTable) new dsCompanies.lstStatusDataTable(dataSet.Tables[nameof (lstStatus)]));
        if (dataSet.Tables[nameof (lstLocationType)] != null)
          base.Tables.Add((DataTable) new dsCompanies.lstLocationTypeDataTable(dataSet.Tables[nameof (lstLocationType)]));
        if (dataSet.Tables[nameof (tblCompanyGroups)] != null)
          base.Tables.Add((DataTable) new dsCompanies.tblCompanyGroupsDataTable(dataSet.Tables[nameof (tblCompanyGroups)]));
        if (dataSet.Tables[nameof (tblCompanies)] != null)
          base.Tables.Add((DataTable) new dsCompanies.tblCompaniesDataTable(dataSet.Tables[nameof (tblCompanies)]));
        if (dataSet.Tables[nameof (tblIntermediaries)] != null)
          base.Tables.Add((DataTable) new dsCompanies.tblIntermediariesDataTable(dataSet.Tables[nameof (tblIntermediaries)]));
        if (dataSet.Tables[nameof (lstFSR)] != null)
          base.Tables.Add((DataTable) new dsCompanies.lstFSRDataTable(dataSet.Tables[nameof (lstFSR)]));
        if (dataSet.Tables[nameof (lstFSC)] != null)
          base.Tables.Add((DataTable) new dsCompanies.lstFSCDataTable(dataSet.Tables[nameof (lstFSC)]));
        if (dataSet.Tables[nameof (lstRatingBureau)] != null)
          base.Tables.Add((DataTable) new dsCompanies.lstRatingBureauDataTable(dataSet.Tables[nameof (lstRatingBureau)]));
        if (dataSet.Tables[nameof (tblUsers)] != null)
          base.Tables.Add((DataTable) new dsCompanies.tblUsersDataTable(dataSet.Tables[nameof (tblUsers)]));
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
  public dsCompanies.tblCompanyContactsDataTable tblCompanyContacts => this.tabletblCompanyContacts;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanies.lstDeliveryMethodDataTable lstDeliveryMethod => this.tablelstDeliveryMethod;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanies.tblCompanyLocationsDataTable tblCompanyLocations
  {
    get => this.tabletblCompanyLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanies.lstStatusDataTable lstStatus => this.tablelstStatus;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanies.lstLocationTypeDataTable lstLocationType => this.tablelstLocationType;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanies.tblCompanyGroupsDataTable tblCompanyGroups => this.tabletblCompanyGroups;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanies.tblCompaniesDataTable tblCompanies => this.tabletblCompanies;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanies.tblIntermediariesDataTable tblIntermediaries => this.tabletblIntermediaries;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanies.lstFSRDataTable lstFSR => this.tablelstFSR;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanies.lstFSCDataTable lstFSC => this.tablelstFSC;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanies.lstRatingBureauDataTable lstRatingBureau => this.tablelstRatingBureau;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanies.tblUsersDataTable tblUsers => this.tabletblUsers;

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
    dsCompanies dsCompanies = (dsCompanies) base.Clone();
    dsCompanies.InitVars();
    dsCompanies.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsCompanies;
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
      if (dataSet.Tables["tblCompanyContacts"] != null)
        base.Tables.Add((DataTable) new dsCompanies.tblCompanyContactsDataTable(dataSet.Tables["tblCompanyContacts"]));
      if (dataSet.Tables["lstDeliveryMethod"] != null)
        base.Tables.Add((DataTable) new dsCompanies.lstDeliveryMethodDataTable(dataSet.Tables["lstDeliveryMethod"]));
      if (dataSet.Tables["tblCompanyLocations"] != null)
        base.Tables.Add((DataTable) new dsCompanies.tblCompanyLocationsDataTable(dataSet.Tables["tblCompanyLocations"]));
      if (dataSet.Tables["lstStatus"] != null)
        base.Tables.Add((DataTable) new dsCompanies.lstStatusDataTable(dataSet.Tables["lstStatus"]));
      if (dataSet.Tables["lstLocationType"] != null)
        base.Tables.Add((DataTable) new dsCompanies.lstLocationTypeDataTable(dataSet.Tables["lstLocationType"]));
      if (dataSet.Tables["tblCompanyGroups"] != null)
        base.Tables.Add((DataTable) new dsCompanies.tblCompanyGroupsDataTable(dataSet.Tables["tblCompanyGroups"]));
      if (dataSet.Tables["tblCompanies"] != null)
        base.Tables.Add((DataTable) new dsCompanies.tblCompaniesDataTable(dataSet.Tables["tblCompanies"]));
      if (dataSet.Tables["tblIntermediaries"] != null)
        base.Tables.Add((DataTable) new dsCompanies.tblIntermediariesDataTable(dataSet.Tables["tblIntermediaries"]));
      if (dataSet.Tables["lstFSR"] != null)
        base.Tables.Add((DataTable) new dsCompanies.lstFSRDataTable(dataSet.Tables["lstFSR"]));
      if (dataSet.Tables["lstFSC"] != null)
        base.Tables.Add((DataTable) new dsCompanies.lstFSCDataTable(dataSet.Tables["lstFSC"]));
      if (dataSet.Tables["lstRatingBureau"] != null)
        base.Tables.Add((DataTable) new dsCompanies.lstRatingBureauDataTable(dataSet.Tables["lstRatingBureau"]));
      if (dataSet.Tables["tblUsers"] != null)
        base.Tables.Add((DataTable) new dsCompanies.tblUsersDataTable(dataSet.Tables["tblUsers"]));
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
    this.tabletblCompanyContacts = (dsCompanies.tblCompanyContactsDataTable) base.Tables["tblCompanyContacts"];
    if (initTable && this.tabletblCompanyContacts != null)
      this.tabletblCompanyContacts.InitVars();
    this.tablelstDeliveryMethod = (dsCompanies.lstDeliveryMethodDataTable) base.Tables["lstDeliveryMethod"];
    if (initTable && this.tablelstDeliveryMethod != null)
      this.tablelstDeliveryMethod.InitVars();
    this.tabletblCompanyLocations = (dsCompanies.tblCompanyLocationsDataTable) base.Tables["tblCompanyLocations"];
    if (initTable && this.tabletblCompanyLocations != null)
      this.tabletblCompanyLocations.InitVars();
    this.tablelstStatus = (dsCompanies.lstStatusDataTable) base.Tables["lstStatus"];
    if (initTable && this.tablelstStatus != null)
      this.tablelstStatus.InitVars();
    this.tablelstLocationType = (dsCompanies.lstLocationTypeDataTable) base.Tables["lstLocationType"];
    if (initTable && this.tablelstLocationType != null)
      this.tablelstLocationType.InitVars();
    this.tabletblCompanyGroups = (dsCompanies.tblCompanyGroupsDataTable) base.Tables["tblCompanyGroups"];
    if (initTable && this.tabletblCompanyGroups != null)
      this.tabletblCompanyGroups.InitVars();
    this.tabletblCompanies = (dsCompanies.tblCompaniesDataTable) base.Tables["tblCompanies"];
    if (initTable && this.tabletblCompanies != null)
      this.tabletblCompanies.InitVars();
    this.tabletblIntermediaries = (dsCompanies.tblIntermediariesDataTable) base.Tables["tblIntermediaries"];
    if (initTable && this.tabletblIntermediaries != null)
      this.tabletblIntermediaries.InitVars();
    this.tablelstFSR = (dsCompanies.lstFSRDataTable) base.Tables["lstFSR"];
    if (initTable && this.tablelstFSR != null)
      this.tablelstFSR.InitVars();
    this.tablelstFSC = (dsCompanies.lstFSCDataTable) base.Tables["lstFSC"];
    if (initTable && this.tablelstFSC != null)
      this.tablelstFSC.InitVars();
    this.tablelstRatingBureau = (dsCompanies.lstRatingBureauDataTable) base.Tables["lstRatingBureau"];
    if (initTable && this.tablelstRatingBureau != null)
      this.tablelstRatingBureau.InitVars();
    this.tabletblUsers = (dsCompanies.tblUsersDataTable) base.Tables["tblUsers"];
    if (initTable && this.tabletblUsers != null)
      this.tabletblUsers.InitVars();
    this.relationtblCompanyLocationstblCompanyContacts = this.Relations["tblCompanyLocationstblCompanyContacts"];
    this.relationtblIntermediariestblCompanyLocations = this.Relations["tblIntermediariestblCompanyLocations"];
    this.relationtblCompaniestblCompanyLocations = this.Relations["tblCompaniestblCompanyLocations"];
    this.relationlstStatustblCompanyLocations = this.Relations["lstStatustblCompanyLocations"];
    this.relationlstLocationTypetblCompanyLocations = this.Relations["lstLocationTypetblCompanyLocations"];
    this.relationlstDeliveryMethodtblCompanyLocations = this.Relations["lstDeliveryMethodtblCompanyLocations"];
    this.relationtblCompanyGroupstblCompanies = this.Relations["tblCompanyGroupstblCompanies"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanies);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsCompanies.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyContacts = new dsCompanies.tblCompanyContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyContacts);
    this.tablelstDeliveryMethod = new dsCompanies.lstDeliveryMethodDataTable();
    base.Tables.Add((DataTable) this.tablelstDeliveryMethod);
    this.tabletblCompanyLocations = new dsCompanies.tblCompanyLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLocations);
    this.tablelstStatus = new dsCompanies.lstStatusDataTable();
    base.Tables.Add((DataTable) this.tablelstStatus);
    this.tablelstLocationType = new dsCompanies.lstLocationTypeDataTable();
    base.Tables.Add((DataTable) this.tablelstLocationType);
    this.tabletblCompanyGroups = new dsCompanies.tblCompanyGroupsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyGroups);
    this.tabletblCompanies = new dsCompanies.tblCompaniesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanies);
    this.tabletblIntermediaries = new dsCompanies.tblIntermediariesDataTable();
    base.Tables.Add((DataTable) this.tabletblIntermediaries);
    this.tablelstFSR = new dsCompanies.lstFSRDataTable();
    base.Tables.Add((DataTable) this.tablelstFSR);
    this.tablelstFSC = new dsCompanies.lstFSCDataTable();
    base.Tables.Add((DataTable) this.tablelstFSC);
    this.tablelstRatingBureau = new dsCompanies.lstRatingBureauDataTable();
    base.Tables.Add((DataTable) this.tablelstRatingBureau);
    this.tabletblUsers = new dsCompanies.tblUsersDataTable();
    base.Tables.Add((DataTable) this.tabletblUsers);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("tblCompanyLocationstblCompanyContacts", new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyLocationGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyContacts.CompanyLocationGuidColumn
    });
    this.tabletblCompanyContacts.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("tblIntermediariestblCompanyLocations", new DataColumn[1]
    {
      this.tabletblIntermediaries.IntermediaryGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLocations.IntermediaryGuidColumn
    });
    this.tabletblCompanyLocations.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("tblCompaniestblCompanyLocations", new DataColumn[1]
    {
      this.tabletblCompanies.CompanyGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyGuidColumn
    });
    this.tabletblCompanyLocations.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("lstStatustblCompanyLocations", new DataColumn[1]
    {
      this.tablelstStatus.StatusIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLocations.StatusIDColumn
    });
    this.tabletblCompanyLocations.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint5 = new ForeignKeyConstraint("lstLocationTypetblCompanyLocations", new DataColumn[1]
    {
      this.tablelstLocationType.LocationTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLocations.LocationTypeIDColumn
    });
    this.tabletblCompanyLocations.Constraints.Add((Constraint) foreignKeyConstraint5);
    foreignKeyConstraint5.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint5.DeleteRule = Rule.Cascade;
    foreignKeyConstraint5.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint6 = new ForeignKeyConstraint("lstDeliveryMethodtblCompanyLocations", new DataColumn[1]
    {
      this.tablelstDeliveryMethod.DeliveryMethodIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLocations.DeliveryMethodIDColumn
    });
    this.tabletblCompanyLocations.Constraints.Add((Constraint) foreignKeyConstraint6);
    foreignKeyConstraint6.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint6.DeleteRule = Rule.Cascade;
    foreignKeyConstraint6.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint7 = new ForeignKeyConstraint("tblCompanyGroupstblCompanies", new DataColumn[1]
    {
      this.tabletblCompanyGroups.CompanyGroupGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanies.CompanyGroupGuidColumn
    });
    this.tabletblCompanies.Constraints.Add((Constraint) foreignKeyConstraint7);
    foreignKeyConstraint7.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint7.DeleteRule = Rule.Cascade;
    foreignKeyConstraint7.UpdateRule = Rule.Cascade;
    this.relationtblCompanyLocationstblCompanyContacts = new DataRelation("tblCompanyLocationstblCompanyContacts", new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyLocationGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyContacts.CompanyLocationGuidColumn
    }, false);
    this.Relations.Add(this.relationtblCompanyLocationstblCompanyContacts);
    this.relationtblIntermediariestblCompanyLocations = new DataRelation("tblIntermediariestblCompanyLocations", new DataColumn[1]
    {
      this.tabletblIntermediaries.IntermediaryGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLocations.IntermediaryGuidColumn
    }, false);
    this.Relations.Add(this.relationtblIntermediariestblCompanyLocations);
    this.relationtblCompaniestblCompanyLocations = new DataRelation("tblCompaniestblCompanyLocations", new DataColumn[1]
    {
      this.tabletblCompanies.CompanyGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyGuidColumn
    }, false);
    this.Relations.Add(this.relationtblCompaniestblCompanyLocations);
    this.relationlstStatustblCompanyLocations = new DataRelation("lstStatustblCompanyLocations", new DataColumn[1]
    {
      this.tablelstStatus.StatusIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLocations.StatusIDColumn
    }, false);
    this.Relations.Add(this.relationlstStatustblCompanyLocations);
    this.relationlstLocationTypetblCompanyLocations = new DataRelation("lstLocationTypetblCompanyLocations", new DataColumn[1]
    {
      this.tablelstLocationType.LocationTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLocations.LocationTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstLocationTypetblCompanyLocations);
    this.relationlstDeliveryMethodtblCompanyLocations = new DataRelation("lstDeliveryMethodtblCompanyLocations", new DataColumn[1]
    {
      this.tablelstDeliveryMethod.DeliveryMethodIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLocations.DeliveryMethodIDColumn
    }, false);
    this.Relations.Add(this.relationlstDeliveryMethodtblCompanyLocations);
    this.relationtblCompanyGroupstblCompanies = new DataRelation("tblCompanyGroupstblCompanies", new DataColumn[1]
    {
      this.tabletblCompanyGroups.CompanyGroupGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanies.CompanyGroupGuidColumn
    }, false);
    this.Relations.Add(this.relationtblCompanyGroupstblCompanies);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanyContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstDeliveryMethod() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanyLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstStatus() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstLocationType() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanyGroups() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanies() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblIntermediaries() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstFSR() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstFSC() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstRatingBureau() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblUsers() => false;

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
    dsCompanies dsCompanies = new dsCompanies();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsCompanies.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsCompanies.GetSchemaSerializable();
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
  public delegate void tblCompanyContactsRowChangeEventHandler(
    object sender,
    dsCompanies.tblCompanyContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstDeliveryMethodRowChangeEventHandler(
    object sender,
    dsCompanies.lstDeliveryMethodRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblCompanyLocationsRowChangeEventHandler(
    object sender,
    dsCompanies.tblCompanyLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstStatusRowChangeEventHandler(
    object sender,
    dsCompanies.lstStatusRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstLocationTypeRowChangeEventHandler(
    object sender,
    dsCompanies.lstLocationTypeRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblCompanyGroupsRowChangeEventHandler(
    object sender,
    dsCompanies.tblCompanyGroupsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblCompaniesRowChangeEventHandler(
    object sender,
    dsCompanies.tblCompaniesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblIntermediariesRowChangeEventHandler(
    object sender,
    dsCompanies.tblIntermediariesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstFSRRowChangeEventHandler(
    object sender,
    dsCompanies.lstFSRRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstFSCRowChangeEventHandler(
    object sender,
    dsCompanies.lstFSCRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstRatingBureauRowChangeEventHandler(
    object sender,
    dsCompanies.lstRatingBureauRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblUsersRowChangeEventHandler(
    object sender,
    dsCompanies.tblUsersRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyContactsDataTable : TypedTableBase<dsCompanies.tblCompanyContactsRow>
  {
    private DataColumn columnCompanyContactGuid;
    private DataColumn columnCompanyLocationGuid;
    private DataColumn columnName;
    private DataColumn columnStatusID;
    private DataColumn columnFromIntermediary;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyContactsDataTable()
    {
      this.TableName = "tblCompanyContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyContactsDataTable(DataTable table)
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
    protected tblCompanyContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyContactGuidColumn => this.columnCompanyContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FromIntermediaryColumn => this.columnFromIntermediary;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyContactsRow this[int index]
    {
      get => (dsCompanies.tblCompanyContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompanyContactsRowChangeEventHandler tblCompanyContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompanyContactsRowChangeEventHandler tblCompanyContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompanyContactsRowChangeEventHandler tblCompanyContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompanyContactsRowChangeEventHandler tblCompanyContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompanyContactsRow(dsCompanies.tblCompanyContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyContactsRow AddtblCompanyContactsRow(
      Guid CompanyContactGuid,
      dsCompanies.tblCompanyLocationsRow parenttblCompanyLocationsRowBytblCompanyLocationstblCompanyContacts,
      string Name,
      int StatusID,
      bool FromIntermediary)
    {
      dsCompanies.tblCompanyContactsRow row = (dsCompanies.tblCompanyContactsRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) CompanyContactGuid,
        null,
        (object) Name,
        (object) StatusID,
        (object) FromIntermediary
      };
      if (parenttblCompanyLocationsRowBytblCompanyLocationstblCompanyContacts != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblCompanyLocationsRowBytblCompanyLocationstblCompanyContacts[1]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyContactsRow FindByCompanyContactGuid(Guid CompanyContactGuid)
    {
      return (dsCompanies.tblCompanyContactsRow) this.Rows.Find(new object[1]
      {
        (object) CompanyContactGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanies.tblCompanyContactsDataTable contactsDataTable = (dsCompanies.tblCompanyContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanies.tblCompanyContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyContactGuid = this.Columns["CompanyContactGuid"];
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
      this.columnName = this.Columns["Name"];
      this.columnStatusID = this.Columns["StatusID"];
      this.columnFromIntermediary = this.Columns["FromIntermediary"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyContactGuid = new DataColumn("CompanyContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyContactGuid);
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnFromIntermediary = new DataColumn("FromIntermediary", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFromIntermediary);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompaniesKey4", new DataColumn[1]
      {
        this.columnCompanyContactGuid
      }, true));
      this.columnCompanyContactGuid.AllowDBNull = false;
      this.columnCompanyContactGuid.Unique = true;
      this.columnCompanyLocationGuid.AllowDBNull = false;
      this.columnStatusID.AllowDBNull = false;
      this.columnFromIntermediary.AllowDBNull = false;
      this.columnFromIntermediary.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyContactsRow NewtblCompanyContactsRow()
    {
      return (dsCompanies.tblCompanyContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanies.tblCompanyContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanies.tblCompanyContactsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompanyContactsRowChangeEventHandler contactsRowChangedEvent = this.tblCompanyContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsCompanies.tblCompanyContactsRowChangeEvent((dsCompanies.tblCompanyContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompanyContactsRowChangeEventHandler rowChangingEvent = this.tblCompanyContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanies.tblCompanyContactsRowChangeEvent((dsCompanies.tblCompanyContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompanyContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblCompanyContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsCompanies.tblCompanyContactsRowChangeEvent((dsCompanies.tblCompanyContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompanyContactsRowChangeEventHandler rowDeletingEvent = this.tblCompanyContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanies.tblCompanyContactsRowChangeEvent((dsCompanies.tblCompanyContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompanyContactsRow(dsCompanies.tblCompanyContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanies dsCompanies = new dsCompanies();
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
        FixedValue = dsCompanies.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanies.GetSchemaSerializable();
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
  public class lstDeliveryMethodDataTable : TypedTableBase<dsCompanies.lstDeliveryMethodRow>
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
    public dsCompanies.lstDeliveryMethodRow this[int index]
    {
      get => (dsCompanies.lstDeliveryMethodRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstDeliveryMethodRow(dsCompanies.lstDeliveryMethodRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstDeliveryMethodRow AddlstDeliveryMethodRow(string Description)
    {
      dsCompanies.lstDeliveryMethodRow row = (dsCompanies.lstDeliveryMethodRow) this.NewRow();
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
    public dsCompanies.lstDeliveryMethodRow FindByDeliveryMethodID(int DeliveryMethodID)
    {
      return (dsCompanies.lstDeliveryMethodRow) this.Rows.Find(new object[1]
      {
        (object) DeliveryMethodID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanies.lstDeliveryMethodDataTable deliveryMethodDataTable = (dsCompanies.lstDeliveryMethodDataTable) base.Clone();
      deliveryMethodDataTable.InitVars();
      return (DataTable) deliveryMethodDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanies.lstDeliveryMethodDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompaniesKey7", new DataColumn[1]
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
    public dsCompanies.lstDeliveryMethodRow NewlstDeliveryMethodRow()
    {
      return (dsCompanies.lstDeliveryMethodRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanies.lstDeliveryMethodRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanies.lstDeliveryMethodRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.lstDeliveryMethodRowChangeEventHandler methodRowChangedEvent = this.lstDeliveryMethodRowChangedEvent;
      if (methodRowChangedEvent == null)
        return;
      methodRowChangedEvent((object) this, new dsCompanies.lstDeliveryMethodRowChangeEvent((dsCompanies.lstDeliveryMethodRow) e.Row, e.Action));
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
      dsCompanies.lstDeliveryMethodRowChangeEventHandler rowChangingEvent = this.lstDeliveryMethodRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanies.lstDeliveryMethodRowChangeEvent((dsCompanies.lstDeliveryMethodRow) e.Row, e.Action));
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
      dsCompanies.lstDeliveryMethodRowChangeEventHandler methodRowDeletedEvent = this.lstDeliveryMethodRowDeletedEvent;
      if (methodRowDeletedEvent == null)
        return;
      methodRowDeletedEvent((object) this, new dsCompanies.lstDeliveryMethodRowChangeEvent((dsCompanies.lstDeliveryMethodRow) e.Row, e.Action));
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
      dsCompanies.lstDeliveryMethodRowChangeEventHandler rowDeletingEvent = this.lstDeliveryMethodRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanies.lstDeliveryMethodRowChangeEvent((dsCompanies.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstDeliveryMethodRow(dsCompanies.lstDeliveryMethodRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanies dsCompanies = new dsCompanies();
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
        FixedValue = dsCompanies.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstDeliveryMethodDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanies.GetSchemaSerializable();
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
  public class tblCompanyLocationsDataTable : TypedTableBase<dsCompanies.tblCompanyLocationsRow>
  {
    private DataColumn columnCompanyLocationCode;
    private DataColumn columnCompanyLocationGuid;
    private DataColumn columnCompanyGuid;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnCounty;
    private DataColumn columnZipPlus;
    private DataColumn columnPhone;
    private DataColumn columnFax;
    private DataColumn columnWebSite;
    private DataColumn columnDeliveryMethodID;
    private DataColumn columnDateAdded;
    private DataColumn columnLocationTypeID;
    private DataColumn columnStatusID;
    private DataColumn columnIntermediaryGuid;
    private DataColumn columnHidden;
    private DataColumn columnState;
    private DataColumn columnZipCode;
    private DataColumn columnClaimPhone;
    private DataColumn columnClaimFax;
    private DataColumn columnLocationName;
    private DataColumn columnISOCountryCode;
    private DataColumn columnRegion;
    private DataColumn columnEmail;
    private DataColumn columnLocationCode;
    private DataColumn columnDisallowBinding;
    private DataColumn columnAddedBy;
    private DataColumn columnNetRateCompanyName;
    private DataColumn columnNetRate_Code;
    private DataColumn columnFatcaNonCompliant;
    private DataColumn columnStatusChangeReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyLocationsDataTable()
    {
      this.TableName = "tblCompanyLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected tblCompanyLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLocationCodeColumn => this.columnCompanyLocationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyGuidColumn => this.columnCompanyGuid;

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
    public DataColumn DeliveryMethodIDColumn => this.columnDeliveryMethodID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateAddedColumn => this.columnDateAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationTypeIDColumn => this.columnLocationTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IntermediaryGuidColumn => this.columnIntermediaryGuid;

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
    public DataColumn ClaimPhoneColumn => this.columnClaimPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClaimFaxColumn => this.columnClaimFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationNameColumn => this.columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ISOCountryCodeColumn => this.columnISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RegionColumn => this.columnRegion;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationCodeColumn => this.columnLocationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisallowBindingColumn => this.columnDisallowBinding;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AddedByColumn => this.columnAddedBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NetRateCompanyNameColumn => this.columnNetRateCompanyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NetRate_CodeColumn => this.columnNetRate_Code;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FatcaNonCompliantColumn => this.columnFatcaNonCompliant;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusChangeReasonColumn => this.columnStatusChangeReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyLocationsRow this[int index]
    {
      get => (dsCompanies.tblCompanyLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompanyLocationsRow(dsCompanies.tblCompanyLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyLocationsRow AddtblCompanyLocationsRow(
      Guid CompanyLocationGuid,
      dsCompanies.tblCompaniesRow parenttblCompaniesRowBytblCompaniestblCompanyLocations,
      string Address1,
      string Address2,
      string City,
      string County,
      string ZipPlus,
      string Phone,
      string Fax,
      string WebSite,
      dsCompanies.lstDeliveryMethodRow parentlstDeliveryMethodRowBylstDeliveryMethodtblCompanyLocations,
      DateTime DateAdded,
      dsCompanies.lstLocationTypeRow parentlstLocationTypeRowBylstLocationTypetblCompanyLocations,
      dsCompanies.lstStatusRow parentlstStatusRowBylstStatustblCompanyLocations,
      dsCompanies.tblIntermediariesRow parenttblIntermediariesRowBytblIntermediariestblCompanyLocations,
      bool Hidden,
      string State,
      string ZipCode,
      string ClaimPhone,
      string ClaimFax,
      string LocationName,
      string ISOCountryCode,
      string _Region,
      string Email,
      string LocationCode,
      bool DisallowBinding,
      Guid AddedBy,
      string NetRateCompanyName,
      string NetRate_Code,
      bool FatcaNonCompliant,
      string StatusChangeReason)
    {
      dsCompanies.tblCompanyLocationsRow row = (dsCompanies.tblCompanyLocationsRow) this.NewRow();
      object[] objArray = new object[32 /*0x20*/]
      {
        null,
        (object) CompanyLocationGuid,
        null,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) County,
        (object) ZipPlus,
        (object) Phone,
        (object) Fax,
        (object) WebSite,
        null,
        (object) DateAdded,
        null,
        null,
        null,
        (object) Hidden,
        (object) State,
        (object) ZipCode,
        (object) ClaimPhone,
        (object) ClaimFax,
        (object) LocationName,
        (object) ISOCountryCode,
        (object) _Region,
        (object) Email,
        (object) LocationCode,
        (object) DisallowBinding,
        (object) AddedBy,
        (object) NetRateCompanyName,
        (object) NetRate_Code,
        (object) FatcaNonCompliant,
        (object) StatusChangeReason
      };
      if (parenttblCompaniesRowBytblCompaniestblCompanyLocations != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parenttblCompaniesRowBytblCompaniestblCompanyLocations[1]);
      if (parentlstDeliveryMethodRowBylstDeliveryMethodtblCompanyLocations != null)
        objArray[11] = RuntimeHelpers.GetObjectValue(parentlstDeliveryMethodRowBylstDeliveryMethodtblCompanyLocations[0]);
      if (parentlstLocationTypeRowBylstLocationTypetblCompanyLocations != null)
        objArray[13] = RuntimeHelpers.GetObjectValue(parentlstLocationTypeRowBylstLocationTypetblCompanyLocations[0]);
      if (parentlstStatusRowBylstStatustblCompanyLocations != null)
        objArray[14] = RuntimeHelpers.GetObjectValue(parentlstStatusRowBylstStatustblCompanyLocations[0]);
      if (parenttblIntermediariesRowBytblIntermediariestblCompanyLocations != null)
        objArray[15] = RuntimeHelpers.GetObjectValue(parenttblIntermediariesRowBytblIntermediariestblCompanyLocations[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyLocationsRow FindByCompanyLocationGuid(Guid CompanyLocationGuid)
    {
      return (dsCompanies.tblCompanyLocationsRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLocationGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanies.tblCompanyLocationsDataTable locationsDataTable = (dsCompanies.tblCompanyLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanies.tblCompanyLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLocationCode = this.Columns["CompanyLocationCode"];
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
      this.columnCompanyGuid = this.Columns["CompanyGuid"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnCounty = this.Columns["County"];
      this.columnZipPlus = this.Columns["ZipPlus"];
      this.columnPhone = this.Columns["Phone"];
      this.columnFax = this.Columns["Fax"];
      this.columnWebSite = this.Columns["WebSite"];
      this.columnDeliveryMethodID = this.Columns["DeliveryMethodID"];
      this.columnDateAdded = this.Columns["DateAdded"];
      this.columnLocationTypeID = this.Columns["LocationTypeID"];
      this.columnStatusID = this.Columns["StatusID"];
      this.columnIntermediaryGuid = this.Columns["IntermediaryGuid"];
      this.columnHidden = this.Columns["Hidden"];
      this.columnState = this.Columns["State"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnClaimPhone = this.Columns["ClaimPhone"];
      this.columnClaimFax = this.Columns["ClaimFax"];
      this.columnLocationName = this.Columns["LocationName"];
      this.columnISOCountryCode = this.Columns["ISOCountryCode"];
      this.columnRegion = this.Columns["Region"];
      this.columnEmail = this.Columns["Email"];
      this.columnLocationCode = this.Columns["LocationCode"];
      this.columnDisallowBinding = this.Columns["DisallowBinding"];
      this.columnAddedBy = this.Columns["AddedBy"];
      this.columnNetRateCompanyName = this.Columns["NetRateCompanyName"];
      this.columnNetRate_Code = this.Columns["NetRate_Code"];
      this.columnFatcaNonCompliant = this.Columns["FatcaNonCompliant"];
      this.columnStatusChangeReason = this.Columns["StatusChangeReason"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLocationCode = new DataColumn("CompanyLocationCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationCode);
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.columnCompanyGuid = new DataColumn("CompanyGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGuid);
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
      this.columnDeliveryMethodID = new DataColumn("DeliveryMethodID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryMethodID);
      this.columnDateAdded = new DataColumn("DateAdded", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateAdded);
      this.columnLocationTypeID = new DataColumn("LocationTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationTypeID);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnIntermediaryGuid = new DataColumn("IntermediaryGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntermediaryGuid);
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnClaimPhone = new DataColumn("ClaimPhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimPhone);
      this.columnClaimFax = new DataColumn("ClaimFax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimFax);
      this.columnLocationName = new DataColumn("LocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationName);
      this.columnISOCountryCode = new DataColumn("ISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnISOCountryCode);
      this.columnRegion = new DataColumn("Region", typeof (string), (string) null, MappingType.Element);
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "RegionColumn");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnRegion");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Region");
      this.Columns.Add(this.columnRegion);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.columnLocationCode = new DataColumn("LocationCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationCode);
      this.columnDisallowBinding = new DataColumn("DisallowBinding", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisallowBinding);
      this.columnAddedBy = new DataColumn("AddedBy", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddedBy);
      this.columnNetRateCompanyName = new DataColumn("NetRateCompanyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetRateCompanyName);
      this.columnNetRate_Code = new DataColumn("NetRate_Code", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetRate_Code);
      this.columnFatcaNonCompliant = new DataColumn("FatcaNonCompliant", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFatcaNonCompliant);
      this.columnStatusChangeReason = new DataColumn("StatusChangeReason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusChangeReason);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompaniesKey2", new DataColumn[1]
      {
        this.columnCompanyLocationGuid
      }, true));
      this.columnCompanyLocationCode.AutoIncrement = true;
      this.columnCompanyLocationCode.AllowDBNull = false;
      this.columnCompanyLocationCode.ReadOnly = true;
      this.columnCompanyLocationGuid.AllowDBNull = false;
      this.columnCompanyLocationGuid.Unique = true;
      this.columnCompanyGuid.AllowDBNull = false;
      this.columnHidden.AllowDBNull = false;
      this.columnHidden.DefaultValue = (object) false;
      this.columnISOCountryCode.AllowDBNull = false;
      this.columnISOCountryCode.DefaultValue = (object) "USA";
      this.columnDisallowBinding.AllowDBNull = false;
      this.columnDisallowBinding.DefaultValue = (object) false;
      this.columnFatcaNonCompliant.DefaultValue = (object) false;
      this.columnStatusChangeReason.MaxLength = 500;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyLocationsRow NewtblCompanyLocationsRow()
    {
      return (dsCompanies.tblCompanyLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanies.tblCompanyLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanies.tblCompanyLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompanyLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblCompanyLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsCompanies.tblCompanyLocationsRowChangeEvent((dsCompanies.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompanyLocationsRowChangeEventHandler rowChangingEvent = this.tblCompanyLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanies.tblCompanyLocationsRowChangeEvent((dsCompanies.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompanyLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblCompanyLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsCompanies.tblCompanyLocationsRowChangeEvent((dsCompanies.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompanyLocationsRowChangeEventHandler rowDeletingEvent = this.tblCompanyLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanies.tblCompanyLocationsRowChangeEvent((dsCompanies.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompanyLocationsRow(dsCompanies.tblCompanyLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanies dsCompanies = new dsCompanies();
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
        FixedValue = dsCompanies.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanies.GetSchemaSerializable();
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
  public class lstStatusDataTable : TypedTableBase<dsCompanies.lstStatusRow>
  {
    private DataColumn columnStatusID;
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
    public dsCompanies.lstStatusRow this[int index] => (dsCompanies.lstStatusRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstStatusRowChangeEventHandler lstStatusRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstStatusRowChangeEventHandler lstStatusRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstStatusRowChangeEventHandler lstStatusRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstStatusRowChangeEventHandler lstStatusRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstStatusRow(dsCompanies.lstStatusRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstStatusRow AddlstStatusRow(int StatusID, string Status, bool Disable)
    {
      dsCompanies.lstStatusRow row = (dsCompanies.lstStatusRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) StatusID,
        (object) Status,
        (object) Disable
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstStatusRow FindByStatusID(int StatusID)
    {
      return (dsCompanies.lstStatusRow) this.Rows.Find(new object[1]
      {
        (object) StatusID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanies.lstStatusDataTable lstStatusDataTable = (dsCompanies.lstStatusDataTable) base.Clone();
      lstStatusDataTable.InitVars();
      return (DataTable) lstStatusDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanies.lstStatusDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnStatusID = this.Columns["StatusID"];
      this.columnStatus = this.Columns["Status"];
      this.columnDisable = this.Columns["Disable"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnDisable = new DataColumn("Disable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisable);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompaniesKey6", new DataColumn[1]
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
    public dsCompanies.lstStatusRow NewlstStatusRow() => (dsCompanies.lstStatusRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanies.lstStatusRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanies.lstStatusRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.lstStatusRowChangeEventHandler statusRowChangedEvent = this.lstStatusRowChangedEvent;
      if (statusRowChangedEvent == null)
        return;
      statusRowChangedEvent((object) this, new dsCompanies.lstStatusRowChangeEvent((dsCompanies.lstStatusRow) e.Row, e.Action));
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
      dsCompanies.lstStatusRowChangeEventHandler rowChangingEvent = this.lstStatusRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanies.lstStatusRowChangeEvent((dsCompanies.lstStatusRow) e.Row, e.Action));
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
      dsCompanies.lstStatusRowChangeEventHandler statusRowDeletedEvent = this.lstStatusRowDeletedEvent;
      if (statusRowDeletedEvent == null)
        return;
      statusRowDeletedEvent((object) this, new dsCompanies.lstStatusRowChangeEvent((dsCompanies.lstStatusRow) e.Row, e.Action));
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
      dsCompanies.lstStatusRowChangeEventHandler rowDeletingEvent = this.lstStatusRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanies.lstStatusRowChangeEvent((dsCompanies.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstStatusRow(dsCompanies.lstStatusRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanies dsCompanies = new dsCompanies();
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
        FixedValue = dsCompanies.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatusDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanies.GetSchemaSerializable();
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
  public class lstLocationTypeDataTable : TypedTableBase<dsCompanies.lstLocationTypeRow>
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
    public dsCompanies.lstLocationTypeRow this[int index]
    {
      get => (dsCompanies.lstLocationTypeRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstLocationTypeRowChangeEventHandler lstLocationTypeRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstLocationTypeRowChangeEventHandler lstLocationTypeRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstLocationTypeRowChangeEventHandler lstLocationTypeRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstLocationTypeRowChangeEventHandler lstLocationTypeRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstLocationTypeRow(dsCompanies.lstLocationTypeRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstLocationTypeRow AddlstLocationTypeRow(string LocationType)
    {
      dsCompanies.lstLocationTypeRow row = (dsCompanies.lstLocationTypeRow) this.NewRow();
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
    public dsCompanies.lstLocationTypeRow FindByLocationTypeID(int LocationTypeID)
    {
      return (dsCompanies.lstLocationTypeRow) this.Rows.Find(new object[1]
      {
        (object) LocationTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanies.lstLocationTypeDataTable locationTypeDataTable = (dsCompanies.lstLocationTypeDataTable) base.Clone();
      locationTypeDataTable.InitVars();
      return (DataTable) locationTypeDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanies.lstLocationTypeDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompaniesKey8", new DataColumn[1]
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
    public dsCompanies.lstLocationTypeRow NewlstLocationTypeRow()
    {
      return (dsCompanies.lstLocationTypeRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanies.lstLocationTypeRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanies.lstLocationTypeRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLocationTypeRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.lstLocationTypeRowChangeEventHandler typeRowChangedEvent = this.lstLocationTypeRowChangedEvent;
      if (typeRowChangedEvent == null)
        return;
      typeRowChangedEvent((object) this, new dsCompanies.lstLocationTypeRowChangeEvent((dsCompanies.lstLocationTypeRow) e.Row, e.Action));
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
      dsCompanies.lstLocationTypeRowChangeEventHandler rowChangingEvent = this.lstLocationTypeRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanies.lstLocationTypeRowChangeEvent((dsCompanies.lstLocationTypeRow) e.Row, e.Action));
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
      dsCompanies.lstLocationTypeRowChangeEventHandler typeRowDeletedEvent = this.lstLocationTypeRowDeletedEvent;
      if (typeRowDeletedEvent == null)
        return;
      typeRowDeletedEvent((object) this, new dsCompanies.lstLocationTypeRowChangeEvent((dsCompanies.lstLocationTypeRow) e.Row, e.Action));
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
      dsCompanies.lstLocationTypeRowChangeEventHandler rowDeletingEvent = this.lstLocationTypeRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanies.lstLocationTypeRowChangeEvent((dsCompanies.lstLocationTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstLocationTypeRow(dsCompanies.lstLocationTypeRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanies dsCompanies = new dsCompanies();
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
        FixedValue = dsCompanies.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstLocationTypeDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanies.GetSchemaSerializable();
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
  public class tblCompanyGroupsDataTable : TypedTableBase<dsCompanies.tblCompanyGroupsRow>
  {
    private DataColumn columnCompanyGroupID;
    private DataColumn columnCompanyGroupGuid;
    private DataColumn columnCompanyGroupName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyGroupsDataTable()
    {
      this.TableName = "tblCompanyGroups";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyGroupsDataTable(DataTable table)
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
    protected tblCompanyGroupsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyGroupIDColumn => this.columnCompanyGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyGroupGuidColumn => this.columnCompanyGroupGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyGroupNameColumn => this.columnCompanyGroupName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyGroupsRow this[int index]
    {
      get => (dsCompanies.tblCompanyGroupsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompanyGroupsRowChangeEventHandler tblCompanyGroupsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompanyGroupsRowChangeEventHandler tblCompanyGroupsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompanyGroupsRowChangeEventHandler tblCompanyGroupsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompanyGroupsRowChangeEventHandler tblCompanyGroupsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompanyGroupsRow(dsCompanies.tblCompanyGroupsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyGroupsRow AddtblCompanyGroupsRow(
      Guid CompanyGroupGuid,
      string CompanyGroupName)
    {
      dsCompanies.tblCompanyGroupsRow row = (dsCompanies.tblCompanyGroupsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) CompanyGroupGuid,
        (object) CompanyGroupName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyGroupsRow FindByCompanyGroupGuid(Guid CompanyGroupGuid)
    {
      return (dsCompanies.tblCompanyGroupsRow) this.Rows.Find(new object[1]
      {
        (object) CompanyGroupGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanies.tblCompanyGroupsDataTable companyGroupsDataTable = (dsCompanies.tblCompanyGroupsDataTable) base.Clone();
      companyGroupsDataTable.InitVars();
      return (DataTable) companyGroupsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanies.tblCompanyGroupsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyGroupID = this.Columns["CompanyGroupID"];
      this.columnCompanyGroupGuid = this.Columns["CompanyGroupGuid"];
      this.columnCompanyGroupName = this.Columns["CompanyGroupName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyGroupID = new DataColumn("CompanyGroupID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGroupID);
      this.columnCompanyGroupGuid = new DataColumn("CompanyGroupGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGroupGuid);
      this.columnCompanyGroupName = new DataColumn("CompanyGroupName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGroupName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompaniesKey9", new DataColumn[1]
      {
        this.columnCompanyGroupGuid
      }, true));
      this.columnCompanyGroupID.AutoIncrement = true;
      this.columnCompanyGroupID.AllowDBNull = false;
      this.columnCompanyGroupID.ReadOnly = true;
      this.columnCompanyGroupGuid.AllowDBNull = false;
      this.columnCompanyGroupGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyGroupsRow NewtblCompanyGroupsRow()
    {
      return (dsCompanies.tblCompanyGroupsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanies.tblCompanyGroupsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanies.tblCompanyGroupsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyGroupsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompanyGroupsRowChangeEventHandler groupsRowChangedEvent = this.tblCompanyGroupsRowChangedEvent;
      if (groupsRowChangedEvent == null)
        return;
      groupsRowChangedEvent((object) this, new dsCompanies.tblCompanyGroupsRowChangeEvent((dsCompanies.tblCompanyGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyGroupsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompanyGroupsRowChangeEventHandler rowChangingEvent = this.tblCompanyGroupsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanies.tblCompanyGroupsRowChangeEvent((dsCompanies.tblCompanyGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyGroupsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompanyGroupsRowChangeEventHandler groupsRowDeletedEvent = this.tblCompanyGroupsRowDeletedEvent;
      if (groupsRowDeletedEvent == null)
        return;
      groupsRowDeletedEvent((object) this, new dsCompanies.tblCompanyGroupsRowChangeEvent((dsCompanies.tblCompanyGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyGroupsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompanyGroupsRowChangeEventHandler rowDeletingEvent = this.tblCompanyGroupsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanies.tblCompanyGroupsRowChangeEvent((dsCompanies.tblCompanyGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompanyGroupsRow(dsCompanies.tblCompanyGroupsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanies dsCompanies = new dsCompanies();
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
        FixedValue = dsCompanies.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyGroupsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanies.GetSchemaSerializable();
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
  public class tblCompaniesDataTable : TypedTableBase<dsCompanies.tblCompaniesRow>
  {
    private DataColumn columnCompanyID;
    private DataColumn columnCompanyGuid;
    private DataColumn columnCompanyName;
    private DataColumn columnCompanyGroupGuid;
    private DataColumn columnClosed;
    private DataColumn columnFSR;
    private DataColumn columnFSC;
    private DataColumn columnNAIC;
    private DataColumn columnRatingBureauID;
    private DataColumn columnFEIN;
    private DataColumn columnBureauNum;
    private DataColumn columnAMBestNum;
    private DataColumn columnNCCI;
    private DataColumn columnLogo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompaniesDataTable()
    {
      this.TableName = "tblCompanies";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompaniesDataTable(DataTable table)
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
    protected tblCompaniesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyIDColumn => this.columnCompanyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyGuidColumn => this.columnCompanyGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyNameColumn => this.columnCompanyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyGroupGuidColumn => this.columnCompanyGroupGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClosedColumn => this.columnClosed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FSRColumn => this.columnFSR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FSCColumn => this.columnFSC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NAICColumn => this.columnNAIC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RatingBureauIDColumn => this.columnRatingBureauID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FEINColumn => this.columnFEIN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BureauNumColumn => this.columnBureauNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AMBestNumColumn => this.columnAMBestNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NCCIColumn => this.columnNCCI;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LogoColumn => this.columnLogo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompaniesRow this[int index]
    {
      get => (dsCompanies.tblCompaniesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompaniesRowChangeEventHandler tblCompaniesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompaniesRowChangeEventHandler tblCompaniesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompaniesRowChangeEventHandler tblCompaniesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblCompaniesRowChangeEventHandler tblCompaniesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompaniesRow(dsCompanies.tblCompaniesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompaniesRow AddtblCompaniesRow(
      Guid CompanyGuid,
      string CompanyName,
      dsCompanies.tblCompanyGroupsRow parenttblCompanyGroupsRowBytblCompanyGroupstblCompanies,
      bool Closed,
      string FSR,
      string FSC,
      string NAIC,
      int RatingBureauID,
      string FEIN,
      string BureauNum,
      string AMBestNum,
      string NCCI,
      byte[] Logo)
    {
      dsCompanies.tblCompaniesRow row = (dsCompanies.tblCompaniesRow) this.NewRow();
      object[] objArray = new object[14]
      {
        null,
        (object) CompanyGuid,
        (object) CompanyName,
        null,
        (object) Closed,
        (object) FSR,
        (object) FSC,
        (object) NAIC,
        (object) RatingBureauID,
        (object) FEIN,
        (object) BureauNum,
        (object) AMBestNum,
        (object) NCCI,
        (object) Logo
      };
      if (parenttblCompanyGroupsRowBytblCompanyGroupstblCompanies != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parenttblCompanyGroupsRowBytblCompanyGroupstblCompanies[1]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompaniesRow FindByCompanyGuid(Guid CompanyGuid)
    {
      return (dsCompanies.tblCompaniesRow) this.Rows.Find(new object[1]
      {
        (object) CompanyGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanies.tblCompaniesDataTable companiesDataTable = (dsCompanies.tblCompaniesDataTable) base.Clone();
      companiesDataTable.InitVars();
      return (DataTable) companiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanies.tblCompaniesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyID = this.Columns["CompanyID"];
      this.columnCompanyGuid = this.Columns["CompanyGuid"];
      this.columnCompanyName = this.Columns["CompanyName"];
      this.columnCompanyGroupGuid = this.Columns["CompanyGroupGuid"];
      this.columnClosed = this.Columns["Closed"];
      this.columnFSR = this.Columns["FSR"];
      this.columnFSC = this.Columns["FSC"];
      this.columnNAIC = this.Columns["NAIC"];
      this.columnRatingBureauID = this.Columns["RatingBureauID"];
      this.columnFEIN = this.Columns["FEIN"];
      this.columnBureauNum = this.Columns["BureauNum"];
      this.columnAMBestNum = this.Columns["AMBestNum"];
      this.columnNCCI = this.Columns["NCCI"];
      this.columnLogo = this.Columns["Logo"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyID = new DataColumn("CompanyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyID);
      this.columnCompanyGuid = new DataColumn("CompanyGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGuid);
      this.columnCompanyName = new DataColumn("CompanyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyName);
      this.columnCompanyGroupGuid = new DataColumn("CompanyGroupGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGroupGuid);
      this.columnClosed = new DataColumn("Closed", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClosed);
      this.columnFSR = new DataColumn("FSR", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFSR);
      this.columnFSC = new DataColumn("FSC", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFSC);
      this.columnNAIC = new DataColumn("NAIC", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNAIC);
      this.columnRatingBureauID = new DataColumn("RatingBureauID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRatingBureauID);
      this.columnFEIN = new DataColumn("FEIN", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFEIN);
      this.columnBureauNum = new DataColumn("BureauNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBureauNum);
      this.columnAMBestNum = new DataColumn("AMBestNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAMBestNum);
      this.columnNCCI = new DataColumn("NCCI", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNCCI);
      this.columnLogo = new DataColumn("Logo", typeof (byte[]), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLogo);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompaniesKey1", new DataColumn[1]
      {
        this.columnCompanyGuid
      }, true));
      this.columnCompanyID.AutoIncrement = true;
      this.columnCompanyID.AllowDBNull = false;
      this.columnCompanyID.ReadOnly = true;
      this.columnCompanyGuid.AllowDBNull = false;
      this.columnCompanyGuid.Unique = true;
      this.columnClosed.AllowDBNull = false;
      this.columnClosed.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompaniesRow NewtblCompaniesRow()
    {
      return (dsCompanies.tblCompaniesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanies.tblCompaniesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanies.tblCompaniesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompaniesRowChangeEventHandler companiesRowChangedEvent = this.tblCompaniesRowChangedEvent;
      if (companiesRowChangedEvent == null)
        return;
      companiesRowChangedEvent((object) this, new dsCompanies.tblCompaniesRowChangeEvent((dsCompanies.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompaniesRowChangeEventHandler rowChangingEvent = this.tblCompaniesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanies.tblCompaniesRowChangeEvent((dsCompanies.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompaniesRowChangeEventHandler companiesRowDeletedEvent = this.tblCompaniesRowDeletedEvent;
      if (companiesRowDeletedEvent == null)
        return;
      companiesRowDeletedEvent((object) this, new dsCompanies.tblCompaniesRowChangeEvent((dsCompanies.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblCompaniesRowChangeEventHandler rowDeletingEvent = this.tblCompaniesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanies.tblCompaniesRowChangeEvent((dsCompanies.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompaniesRow(dsCompanies.tblCompaniesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanies dsCompanies = new dsCompanies();
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
        FixedValue = dsCompanies.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompaniesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanies.GetSchemaSerializable();
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
  public class tblIntermediariesDataTable : TypedTableBase<dsCompanies.tblIntermediariesRow>
  {
    private DataColumn columnIntermediaryGuid;
    private DataColumn columnIntermediaryName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblIntermediariesDataTable()
    {
      this.TableName = "tblIntermediaries";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblIntermediariesDataTable(DataTable table)
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
    protected tblIntermediariesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IntermediaryGuidColumn => this.columnIntermediaryGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IntermediaryNameColumn => this.columnIntermediaryName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblIntermediariesRow this[int index]
    {
      get => (dsCompanies.tblIntermediariesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblIntermediariesRowChangeEventHandler tblIntermediariesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblIntermediariesRowChangeEventHandler tblIntermediariesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblIntermediariesRowChangeEventHandler tblIntermediariesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblIntermediariesRowChangeEventHandler tblIntermediariesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblIntermediariesRow(dsCompanies.tblIntermediariesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblIntermediariesRow AddtblIntermediariesRow(
      Guid IntermediaryGuid,
      string IntermediaryName)
    {
      dsCompanies.tblIntermediariesRow row = (dsCompanies.tblIntermediariesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) IntermediaryGuid,
        (object) IntermediaryName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblIntermediariesRow FindByIntermediaryGuid(Guid IntermediaryGuid)
    {
      return (dsCompanies.tblIntermediariesRow) this.Rows.Find(new object[1]
      {
        (object) IntermediaryGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanies.tblIntermediariesDataTable intermediariesDataTable = (dsCompanies.tblIntermediariesDataTable) base.Clone();
      intermediariesDataTable.InitVars();
      return (DataTable) intermediariesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanies.tblIntermediariesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnIntermediaryGuid = this.Columns["IntermediaryGuid"];
      this.columnIntermediaryName = this.Columns["IntermediaryName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnIntermediaryGuid = new DataColumn("IntermediaryGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntermediaryGuid);
      this.columnIntermediaryName = new DataColumn("IntermediaryName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntermediaryName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompaniesKey10", new DataColumn[1]
      {
        this.columnIntermediaryGuid
      }, true));
      this.columnIntermediaryGuid.AllowDBNull = false;
      this.columnIntermediaryGuid.Unique = true;
      this.columnIntermediaryName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblIntermediariesRow NewtblIntermediariesRow()
    {
      return (dsCompanies.tblIntermediariesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanies.tblIntermediariesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanies.tblIntermediariesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediariesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblIntermediariesRowChangeEventHandler intermediariesRowChangedEvent = this.tblIntermediariesRowChangedEvent;
      if (intermediariesRowChangedEvent == null)
        return;
      intermediariesRowChangedEvent((object) this, new dsCompanies.tblIntermediariesRowChangeEvent((dsCompanies.tblIntermediariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediariesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblIntermediariesRowChangeEventHandler rowChangingEvent = this.tblIntermediariesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanies.tblIntermediariesRowChangeEvent((dsCompanies.tblIntermediariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediariesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblIntermediariesRowChangeEventHandler intermediariesRowDeletedEvent = this.tblIntermediariesRowDeletedEvent;
      if (intermediariesRowDeletedEvent == null)
        return;
      intermediariesRowDeletedEvent((object) this, new dsCompanies.tblIntermediariesRowChangeEvent((dsCompanies.tblIntermediariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediariesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblIntermediariesRowChangeEventHandler rowDeletingEvent = this.tblIntermediariesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanies.tblIntermediariesRowChangeEvent((dsCompanies.tblIntermediariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblIntermediariesRow(dsCompanies.tblIntermediariesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanies dsCompanies = new dsCompanies();
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
        FixedValue = dsCompanies.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblIntermediariesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanies.GetSchemaSerializable();
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
  public class lstFSRDataTable : TypedTableBase<dsCompanies.lstFSRRow>
  {
    private DataColumn columnFSR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstFSRDataTable()
    {
      this.TableName = "lstFSR";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstFSRDataTable(DataTable table)
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
    protected lstFSRDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FSRColumn => this.columnFSR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstFSRRow this[int index] => (dsCompanies.lstFSRRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstFSRRowChangeEventHandler lstFSRRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstFSRRowChangeEventHandler lstFSRRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstFSRRowChangeEventHandler lstFSRRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstFSRRowChangeEventHandler lstFSRRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstFSRRow(dsCompanies.lstFSRRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstFSRRow AddlstFSRRow(string FSR)
    {
      dsCompanies.lstFSRRow row = (dsCompanies.lstFSRRow) this.NewRow();
      object[] objArray = new object[1]{ (object) FSR };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanies.lstFSRDataTable lstFsrDataTable = (dsCompanies.lstFSRDataTable) base.Clone();
      lstFsrDataTable.InitVars();
      return (DataTable) lstFsrDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsCompanies.lstFSRDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars() => this.columnFSR = this.Columns["FSR"];

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnFSR = new DataColumn("FSR", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFSR);
      this.columnFSR.AllowDBNull = false;
      this.columnFSR.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstFSRRow NewlstFSRRow() => (dsCompanies.lstFSRRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanies.lstFSRRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanies.lstFSRRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFSRRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.lstFSRRowChangeEventHandler fsrRowChangedEvent = this.lstFSRRowChangedEvent;
      if (fsrRowChangedEvent == null)
        return;
      fsrRowChangedEvent((object) this, new dsCompanies.lstFSRRowChangeEvent((dsCompanies.lstFSRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFSRRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.lstFSRRowChangeEventHandler rowChangingEvent = this.lstFSRRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanies.lstFSRRowChangeEvent((dsCompanies.lstFSRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFSRRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.lstFSRRowChangeEventHandler fsrRowDeletedEvent = this.lstFSRRowDeletedEvent;
      if (fsrRowDeletedEvent == null)
        return;
      fsrRowDeletedEvent((object) this, new dsCompanies.lstFSRRowChangeEvent((dsCompanies.lstFSRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFSRRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.lstFSRRowChangeEventHandler rowDeletingEvent = this.lstFSRRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanies.lstFSRRowChangeEvent((dsCompanies.lstFSRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstFSRRow(dsCompanies.lstFSRRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanies dsCompanies = new dsCompanies();
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
        FixedValue = dsCompanies.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstFSRDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanies.GetSchemaSerializable();
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
  public class lstFSCDataTable : TypedTableBase<dsCompanies.lstFSCRow>
  {
    private DataColumn columnFSC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstFSCDataTable()
    {
      this.TableName = "lstFSC";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstFSCDataTable(DataTable table)
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
    protected lstFSCDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FSCColumn => this.columnFSC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstFSCRow this[int index] => (dsCompanies.lstFSCRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstFSCRowChangeEventHandler lstFSCRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstFSCRowChangeEventHandler lstFSCRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstFSCRowChangeEventHandler lstFSCRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstFSCRowChangeEventHandler lstFSCRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstFSCRow(dsCompanies.lstFSCRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstFSCRow AddlstFSCRow(string FSC)
    {
      dsCompanies.lstFSCRow row = (dsCompanies.lstFSCRow) this.NewRow();
      object[] objArray = new object[1]{ (object) FSC };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanies.lstFSCDataTable lstFscDataTable = (dsCompanies.lstFSCDataTable) base.Clone();
      lstFscDataTable.InitVars();
      return (DataTable) lstFscDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsCompanies.lstFSCDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars() => this.columnFSC = this.Columns["FSC"];

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnFSC = new DataColumn("FSC", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFSC);
      this.columnFSC.AllowDBNull = false;
      this.columnFSC.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstFSCRow NewlstFSCRow() => (dsCompanies.lstFSCRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanies.lstFSCRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanies.lstFSCRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFSCRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.lstFSCRowChangeEventHandler fscRowChangedEvent = this.lstFSCRowChangedEvent;
      if (fscRowChangedEvent == null)
        return;
      fscRowChangedEvent((object) this, new dsCompanies.lstFSCRowChangeEvent((dsCompanies.lstFSCRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFSCRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.lstFSCRowChangeEventHandler rowChangingEvent = this.lstFSCRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanies.lstFSCRowChangeEvent((dsCompanies.lstFSCRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFSCRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.lstFSCRowChangeEventHandler fscRowDeletedEvent = this.lstFSCRowDeletedEvent;
      if (fscRowDeletedEvent == null)
        return;
      fscRowDeletedEvent((object) this, new dsCompanies.lstFSCRowChangeEvent((dsCompanies.lstFSCRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFSCRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.lstFSCRowChangeEventHandler rowDeletingEvent = this.lstFSCRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanies.lstFSCRowChangeEvent((dsCompanies.lstFSCRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstFSCRow(dsCompanies.lstFSCRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanies dsCompanies = new dsCompanies();
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
        FixedValue = dsCompanies.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstFSCDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanies.GetSchemaSerializable();
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
  public class lstRatingBureauDataTable : TypedTableBase<dsCompanies.lstRatingBureauRow>
  {
    private DataColumn columnRatingBureauID;
    private DataColumn columnRatingBureau;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstRatingBureauDataTable()
    {
      this.TableName = "lstRatingBureau";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstRatingBureauDataTable(DataTable table)
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
    protected lstRatingBureauDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RatingBureauIDColumn => this.columnRatingBureauID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RatingBureauColumn => this.columnRatingBureau;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstRatingBureauRow this[int index]
    {
      get => (dsCompanies.lstRatingBureauRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstRatingBureauRowChangeEventHandler lstRatingBureauRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstRatingBureauRowChangeEventHandler lstRatingBureauRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstRatingBureauRowChangeEventHandler lstRatingBureauRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.lstRatingBureauRowChangeEventHandler lstRatingBureauRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstRatingBureauRow(dsCompanies.lstRatingBureauRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstRatingBureauRow AddlstRatingBureauRow(string RatingBureau)
    {
      dsCompanies.lstRatingBureauRow row = (dsCompanies.lstRatingBureauRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) RatingBureau
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstRatingBureauRow FindByRatingBureauID(int RatingBureauID)
    {
      return (dsCompanies.lstRatingBureauRow) this.Rows.Find(new object[1]
      {
        (object) RatingBureauID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanies.lstRatingBureauDataTable ratingBureauDataTable = (dsCompanies.lstRatingBureauDataTable) base.Clone();
      ratingBureauDataTable.InitVars();
      return (DataTable) ratingBureauDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanies.lstRatingBureauDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnRatingBureauID = this.Columns["RatingBureauID"];
      this.columnRatingBureau = this.Columns["RatingBureau"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnRatingBureauID = new DataColumn("RatingBureauID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRatingBureauID);
      this.columnRatingBureau = new DataColumn("RatingBureau", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRatingBureau);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnRatingBureauID
      }, true));
      this.columnRatingBureauID.AutoIncrement = true;
      this.columnRatingBureauID.AutoIncrementSeed = -1L;
      this.columnRatingBureauID.AutoIncrementStep = -1L;
      this.columnRatingBureauID.AllowDBNull = false;
      this.columnRatingBureauID.ReadOnly = true;
      this.columnRatingBureauID.Unique = true;
      this.columnRatingBureau.AllowDBNull = false;
      this.columnRatingBureau.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstRatingBureauRow NewlstRatingBureauRow()
    {
      return (dsCompanies.lstRatingBureauRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanies.lstRatingBureauRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanies.lstRatingBureauRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstRatingBureauRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.lstRatingBureauRowChangeEventHandler bureauRowChangedEvent = this.lstRatingBureauRowChangedEvent;
      if (bureauRowChangedEvent == null)
        return;
      bureauRowChangedEvent((object) this, new dsCompanies.lstRatingBureauRowChangeEvent((dsCompanies.lstRatingBureauRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstRatingBureauRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.lstRatingBureauRowChangeEventHandler rowChangingEvent = this.lstRatingBureauRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanies.lstRatingBureauRowChangeEvent((dsCompanies.lstRatingBureauRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstRatingBureauRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.lstRatingBureauRowChangeEventHandler bureauRowDeletedEvent = this.lstRatingBureauRowDeletedEvent;
      if (bureauRowDeletedEvent == null)
        return;
      bureauRowDeletedEvent((object) this, new dsCompanies.lstRatingBureauRowChangeEvent((dsCompanies.lstRatingBureauRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstRatingBureauRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.lstRatingBureauRowChangeEventHandler rowDeletingEvent = this.lstRatingBureauRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanies.lstRatingBureauRowChangeEvent((dsCompanies.lstRatingBureauRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstRatingBureauRow(dsCompanies.lstRatingBureauRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanies dsCompanies = new dsCompanies();
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
        FixedValue = dsCompanies.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstRatingBureauDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanies.GetSchemaSerializable();
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
  public class tblUsersDataTable : TypedTableBase<dsCompanies.tblUsersRow>
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
    public dsCompanies.tblUsersRow this[int index] => (dsCompanies.tblUsersRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblUsersRowChangeEventHandler tblUsersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblUsersRowChangeEventHandler tblUsersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblUsersRowChangeEventHandler tblUsersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanies.tblUsersRowChangeEventHandler tblUsersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblUsersRow(dsCompanies.tblUsersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblUsersRow AddtblUsersRow(Guid UserGUID, string Name_LastFirst)
    {
      dsCompanies.tblUsersRow row = (dsCompanies.tblUsersRow) this.NewRow();
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
    public dsCompanies.tblUsersRow FindByUserGUID(Guid UserGUID)
    {
      return (dsCompanies.tblUsersRow) this.Rows.Find(new object[1]
      {
        (object) UserGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanies.tblUsersDataTable tblUsersDataTable = (dsCompanies.tblUsersDataTable) base.Clone();
      tblUsersDataTable.InitVars();
      return (DataTable) tblUsersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanies.tblUsersDataTable();
    }

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
    public dsCompanies.tblUsersRow NewtblUsersRow() => (dsCompanies.tblUsersRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanies.tblUsersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanies.tblUsersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanies.tblUsersRowChangeEventHandler usersRowChangedEvent = this.tblUsersRowChangedEvent;
      if (usersRowChangedEvent == null)
        return;
      usersRowChangedEvent((object) this, new dsCompanies.tblUsersRowChangeEvent((dsCompanies.tblUsersRow) e.Row, e.Action));
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
      dsCompanies.tblUsersRowChangeEventHandler rowChangingEvent = this.tblUsersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanies.tblUsersRowChangeEvent((dsCompanies.tblUsersRow) e.Row, e.Action));
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
      dsCompanies.tblUsersRowChangeEventHandler usersRowDeletedEvent = this.tblUsersRowDeletedEvent;
      if (usersRowDeletedEvent == null)
        return;
      usersRowDeletedEvent((object) this, new dsCompanies.tblUsersRowChangeEvent((dsCompanies.tblUsersRow) e.Row, e.Action));
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
      dsCompanies.tblUsersRowChangeEventHandler rowDeletingEvent = this.tblUsersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanies.tblUsersRowChangeEvent((dsCompanies.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblUsersRow(dsCompanies.tblUsersRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanies dsCompanies = new dsCompanies();
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
        FixedValue = dsCompanies.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUsersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanies.GetSchemaSerializable();
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

  public class tblCompanyContactsRow : DataRow
  {
    private dsCompanies.tblCompanyContactsDataTable tabletblCompanyContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyContacts = (dsCompanies.tblCompanyContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyContactGuid
    {
      get
      {
        object obj = this[this.tabletblCompanyContacts.CompanyContactGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyContacts.CompanyContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyLocationGuid
    {
      get
      {
        object obj = this[this.tabletblCompanyContacts.CompanyLocationGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyContacts.CompanyLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyContacts.NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name' in table 'tblCompanyContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyContacts.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int StatusID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyContacts.StatusIDColumn]);
      set => this[this.tabletblCompanyContacts.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool FromIntermediary
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyContacts.FromIntermediaryColumn]);
      set => this[this.tabletblCompanyContacts.FromIntermediaryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyLocationsRow tblCompanyLocationsRow
    {
      get
      {
        return (dsCompanies.tblCompanyLocationsRow) this.GetParentRow(this.Table.ParentRelations["tblCompanyLocationstblCompanyContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompanyLocationstblCompanyContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabletblCompanyContacts.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabletblCompanyContacts.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstDeliveryMethodRow : DataRow
  {
    private dsCompanies.lstDeliveryMethodDataTable tablelstDeliveryMethod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstDeliveryMethodRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstDeliveryMethod = (dsCompanies.lstDeliveryMethodDataTable) this.Table;
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
    public dsCompanies.tblCompanyLocationsRow[] GettblCompanyLocationsRows()
    {
      return this.Table.ChildRelations["lstDeliveryMethodtblCompanyLocations"] != null ? (dsCompanies.tblCompanyLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstDeliveryMethodtblCompanyLocations"]) : new dsCompanies.tblCompanyLocationsRow[0];
    }
  }

  public class tblCompanyLocationsRow : DataRow
  {
    private dsCompanies.tblCompanyLocationsDataTable tabletblCompanyLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLocations = (dsCompanies.tblCompanyLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CompanyLocationCode
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyLocations.CompanyLocationCodeColumn]);
      set => this[this.tabletblCompanyLocations.CompanyLocationCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyGuid
    {
      get
      {
        object obj = this[this.tabletblCompanyLocations.CompanyGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyLocations.CompanyGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address1' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address2' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string County
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.CountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'County' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.CountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.ZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipPlus' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.ZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Phone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.PhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Phone' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Fax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.FaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fax' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.FaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string WebSite
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.WebSiteColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WebSite' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.WebSiteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DeliveryMethodID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLocations.DeliveryMethodIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeliveryMethodID' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.DeliveryMethodIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateAdded
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblCompanyLocations.DateAddedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateAdded' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.DateAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int LocationTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLocations.LocationTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationTypeID' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.LocationTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int StatusID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLocations.StatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusID' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid IntermediaryGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyLocations.IntermediaryGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IntermediaryGuid' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.IntermediaryGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Hidden
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyLocations.HiddenColumn]);
      set => this[this.tabletblCompanyLocations.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ClaimPhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.ClaimPhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClaimPhone' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.ClaimPhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ClaimFax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.ClaimFaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClaimFax' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.ClaimFaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LocationName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.LocationNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationName' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.LocationNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ISOCountryCode
    {
      get => Conversions.ToString(this[this.tabletblCompanyLocations.ISOCountryCodeColumn]);
      set => this[this.tabletblCompanyLocations.ISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string _Region
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.RegionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Region' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.RegionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.EmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Email' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LocationCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.LocationCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationCode' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.LocationCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool DisallowBinding
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyLocations.DisallowBindingColumn]);
      set => this[this.tabletblCompanyLocations.DisallowBindingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid AddedBy
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyLocations.AddedByColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddedBy' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.AddedByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string NetRateCompanyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.NetRateCompanyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NetRateCompanyName' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.NetRateCompanyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string NetRate_Code
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.NetRate_CodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NetRate_Code' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.NetRate_CodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool FatcaNonCompliant
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLocations.FatcaNonCompliantColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FatcaNonCompliant' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.FatcaNonCompliantColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StatusChangeReason
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.StatusChangeReasonColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusChangeReason' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.StatusChangeReasonColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblIntermediariesRow tblIntermediariesRow
    {
      get
      {
        return (dsCompanies.tblIntermediariesRow) this.GetParentRow(this.Table.ParentRelations["tblIntermediariestblCompanyLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblIntermediariestblCompanyLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompaniesRow tblCompaniesRow
    {
      get
      {
        return (dsCompanies.tblCompaniesRow) this.GetParentRow(this.Table.ParentRelations["tblCompaniestblCompanyLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompaniestblCompanyLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstStatusRow lstStatusRow
    {
      get
      {
        return (dsCompanies.lstStatusRow) this.GetParentRow(this.Table.ParentRelations["lstStatustblCompanyLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstStatustblCompanyLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstLocationTypeRow lstLocationTypeRow
    {
      get
      {
        return (dsCompanies.lstLocationTypeRow) this.GetParentRow(this.Table.ParentRelations["lstLocationTypetblCompanyLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstLocationTypetblCompanyLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstDeliveryMethodRow lstDeliveryMethodRow
    {
      get
      {
        return (dsCompanies.lstDeliveryMethodRow) this.GetParentRow(this.Table.ParentRelations["lstDeliveryMethodtblCompanyLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstDeliveryMethodtblCompanyLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddress1Null() => this.IsNull(this.tabletblCompanyLocations.Address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabletblCompanyLocations.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddress2Null() => this.IsNull(this.tabletblCompanyLocations.Address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabletblCompanyLocations.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabletblCompanyLocations.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabletblCompanyLocations.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCountyNull() => this.IsNull(this.tabletblCompanyLocations.CountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCountyNull()
    {
      this[this.tabletblCompanyLocations.CountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsZipPlusNull() => this.IsNull(this.tabletblCompanyLocations.ZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetZipPlusNull()
    {
      this[this.tabletblCompanyLocations.ZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPhoneNull() => this.IsNull(this.tabletblCompanyLocations.PhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPhoneNull()
    {
      this[this.tabletblCompanyLocations.PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFaxNull() => this.IsNull(this.tabletblCompanyLocations.FaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFaxNull()
    {
      this[this.tabletblCompanyLocations.FaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsWebSiteNull() => this.IsNull(this.tabletblCompanyLocations.WebSiteColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetWebSiteNull()
    {
      this[this.tabletblCompanyLocations.WebSiteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDeliveryMethodIDNull()
    {
      return this.IsNull(this.tabletblCompanyLocations.DeliveryMethodIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDeliveryMethodIDNull()
    {
      this[this.tabletblCompanyLocations.DeliveryMethodIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateAddedNull() => this.IsNull(this.tabletblCompanyLocations.DateAddedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateAddedNull()
    {
      this[this.tabletblCompanyLocations.DateAddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLocationTypeIDNull()
    {
      return this.IsNull(this.tabletblCompanyLocations.LocationTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLocationTypeIDNull()
    {
      this[this.tabletblCompanyLocations.LocationTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStatusIDNull() => this.IsNull(this.tabletblCompanyLocations.StatusIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatusIDNull()
    {
      this[this.tabletblCompanyLocations.StatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIntermediaryGuidNull()
    {
      return this.IsNull(this.tabletblCompanyLocations.IntermediaryGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIntermediaryGuidNull()
    {
      this[this.tabletblCompanyLocations.IntermediaryGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabletblCompanyLocations.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabletblCompanyLocations.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tabletblCompanyLocations.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tabletblCompanyLocations.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClaimPhoneNull() => this.IsNull(this.tabletblCompanyLocations.ClaimPhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClaimPhoneNull()
    {
      this[this.tabletblCompanyLocations.ClaimPhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClaimFaxNull() => this.IsNull(this.tabletblCompanyLocations.ClaimFaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClaimFaxNull()
    {
      this[this.tabletblCompanyLocations.ClaimFaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLocationNameNull()
    {
      return this.IsNull(this.tabletblCompanyLocations.LocationNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLocationNameNull()
    {
      this[this.tabletblCompanyLocations.LocationNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Is_RegionNull() => this.IsNull(this.tabletblCompanyLocations.RegionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void Set_RegionNull()
    {
      this[this.tabletblCompanyLocations.RegionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tabletblCompanyLocations.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEmailNull()
    {
      this[this.tabletblCompanyLocations.EmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLocationCodeNull()
    {
      return this.IsNull(this.tabletblCompanyLocations.LocationCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLocationCodeNull()
    {
      this[this.tabletblCompanyLocations.LocationCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddedByNull() => this.IsNull(this.tabletblCompanyLocations.AddedByColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddedByNull()
    {
      this[this.tabletblCompanyLocations.AddedByColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNetRateCompanyNameNull()
    {
      return this.IsNull(this.tabletblCompanyLocations.NetRateCompanyNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNetRateCompanyNameNull()
    {
      this[this.tabletblCompanyLocations.NetRateCompanyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNetRate_CodeNull()
    {
      return this.IsNull(this.tabletblCompanyLocations.NetRate_CodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNetRate_CodeNull()
    {
      this[this.tabletblCompanyLocations.NetRate_CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFatcaNonCompliantNull()
    {
      return this.IsNull(this.tabletblCompanyLocations.FatcaNonCompliantColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFatcaNonCompliantNull()
    {
      this[this.tabletblCompanyLocations.FatcaNonCompliantColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStatusChangeReasonNull()
    {
      return this.IsNull(this.tabletblCompanyLocations.StatusChangeReasonColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatusChangeReasonNull()
    {
      this[this.tabletblCompanyLocations.StatusChangeReasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyContactsRow[] GettblCompanyContactsRows()
    {
      return this.Table.ChildRelations["tblCompanyLocationstblCompanyContacts"] != null ? (dsCompanies.tblCompanyContactsRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompanyLocationstblCompanyContacts"]) : new dsCompanies.tblCompanyContactsRow[0];
    }
  }

  public class lstStatusRow : DataRow
  {
    private dsCompanies.lstStatusDataTable tablelstStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstStatusRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStatus = (dsCompanies.lstStatusDataTable) this.Table;
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
    public bool IsStatusNull() => this.IsNull(this.tablelstStatus.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatusNull()
    {
      this[this.tablelstStatus.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyLocationsRow[] GettblCompanyLocationsRows()
    {
      return this.Table.ChildRelations["lstStatustblCompanyLocations"] != null ? (dsCompanies.tblCompanyLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstStatustblCompanyLocations"]) : new dsCompanies.tblCompanyLocationsRow[0];
    }
  }

  public class lstLocationTypeRow : DataRow
  {
    private dsCompanies.lstLocationTypeDataTable tablelstLocationType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstLocationTypeRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstLocationType = (dsCompanies.lstLocationTypeDataTable) this.Table;
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
    public dsCompanies.tblCompanyLocationsRow[] GettblCompanyLocationsRows()
    {
      return this.Table.ChildRelations["lstLocationTypetblCompanyLocations"] != null ? (dsCompanies.tblCompanyLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["lstLocationTypetblCompanyLocations"]) : new dsCompanies.tblCompanyLocationsRow[0];
    }
  }

  public class tblCompanyGroupsRow : DataRow
  {
    private dsCompanies.tblCompanyGroupsDataTable tabletblCompanyGroups;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyGroupsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyGroups = (dsCompanies.tblCompanyGroupsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CompanyGroupID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyGroups.CompanyGroupIDColumn]);
      set => this[this.tabletblCompanyGroups.CompanyGroupIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyGroupGuid
    {
      get
      {
        object obj = this[this.tabletblCompanyGroups.CompanyGroupGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyGroups.CompanyGroupGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CompanyGroupName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyGroups.CompanyGroupNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyGroupName' in table 'tblCompanyGroups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyGroups.CompanyGroupNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyGroupNameNull()
    {
      return this.IsNull(this.tabletblCompanyGroups.CompanyGroupNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyGroupNameNull()
    {
      this[this.tabletblCompanyGroups.CompanyGroupNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompaniesRow[] GettblCompaniesRows()
    {
      return this.Table.ChildRelations["tblCompanyGroupstblCompanies"] != null ? (dsCompanies.tblCompaniesRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompanyGroupstblCompanies"]) : new dsCompanies.tblCompaniesRow[0];
    }
  }

  public class tblCompaniesRow : DataRow
  {
    private dsCompanies.tblCompaniesDataTable tabletblCompanies;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompaniesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanies = (dsCompanies.tblCompaniesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CompanyID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanies.CompanyIDColumn]);
      set => this[this.tabletblCompanies.CompanyIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyGuid
    {
      get
      {
        object obj = this[this.tabletblCompanies.CompanyGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanies.CompanyGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CompanyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanies.CompanyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyName' in table 'tblCompanies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanies.CompanyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyGroupGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanies.CompanyGroupGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyGroupGuid' in table 'tblCompanies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanies.CompanyGroupGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Closed
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanies.ClosedColumn]);
      set => this[this.tabletblCompanies.ClosedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string FSR
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanies.FSRColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FSR' in table 'tblCompanies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanies.FSRColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string FSC
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanies.FSCColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FSC' in table 'tblCompanies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanies.FSCColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string NAIC
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanies.NAICColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NAIC' in table 'tblCompanies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanies.NAICColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int RatingBureauID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanies.RatingBureauIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RatingBureauID' in table 'tblCompanies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanies.RatingBureauIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string FEIN
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanies.FEINColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FEIN' in table 'tblCompanies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanies.FEINColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BureauNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanies.BureauNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BureauNum' in table 'tblCompanies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanies.BureauNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AMBestNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanies.AMBestNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AMBestNum' in table 'tblCompanies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanies.AMBestNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string NCCI
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanies.NCCIColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NCCI' in table 'tblCompanies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanies.NCCIColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public byte[] Logo
    {
      get
      {
        try
        {
          return (byte[]) this[this.tabletblCompanies.LogoColumn];
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Logo' in table 'tblCompanies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanies.LogoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyGroupsRow tblCompanyGroupsRow
    {
      get
      {
        return (dsCompanies.tblCompanyGroupsRow) this.GetParentRow(this.Table.ParentRelations["tblCompanyGroupstblCompanies"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompanyGroupstblCompanies"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyNameNull() => this.IsNull(this.tabletblCompanies.CompanyNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyNameNull()
    {
      this[this.tabletblCompanies.CompanyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyGroupGuidNull()
    {
      return this.IsNull(this.tabletblCompanies.CompanyGroupGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyGroupGuidNull()
    {
      this[this.tabletblCompanies.CompanyGroupGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFSRNull() => this.IsNull(this.tabletblCompanies.FSRColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFSRNull()
    {
      this[this.tabletblCompanies.FSRColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFSCNull() => this.IsNull(this.tabletblCompanies.FSCColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFSCNull()
    {
      this[this.tabletblCompanies.FSCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNAICNull() => this.IsNull(this.tabletblCompanies.NAICColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNAICNull()
    {
      this[this.tabletblCompanies.NAICColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRatingBureauIDNull() => this.IsNull(this.tabletblCompanies.RatingBureauIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRatingBureauIDNull()
    {
      this[this.tabletblCompanies.RatingBureauIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFEINNull() => this.IsNull(this.tabletblCompanies.FEINColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFEINNull()
    {
      this[this.tabletblCompanies.FEINColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBureauNumNull() => this.IsNull(this.tabletblCompanies.BureauNumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBureauNumNull()
    {
      this[this.tabletblCompanies.BureauNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAMBestNumNull() => this.IsNull(this.tabletblCompanies.AMBestNumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAMBestNumNull()
    {
      this[this.tabletblCompanies.AMBestNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNCCINull() => this.IsNull(this.tabletblCompanies.NCCIColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNCCINull()
    {
      this[this.tabletblCompanies.NCCIColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLogoNull() => this.IsNull(this.tabletblCompanies.LogoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLogoNull()
    {
      this[this.tabletblCompanies.LogoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyLocationsRow[] GettblCompanyLocationsRows()
    {
      return this.Table.ChildRelations["tblCompaniestblCompanyLocations"] != null ? (dsCompanies.tblCompanyLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompaniestblCompanyLocations"]) : new dsCompanies.tblCompanyLocationsRow[0];
    }
  }

  public class tblIntermediariesRow : DataRow
  {
    private dsCompanies.tblIntermediariesDataTable tabletblIntermediaries;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblIntermediariesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblIntermediaries = (dsCompanies.tblIntermediariesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid IntermediaryGuid
    {
      get
      {
        object obj = this[this.tabletblIntermediaries.IntermediaryGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblIntermediaries.IntermediaryGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string IntermediaryName
    {
      get => Conversions.ToString(this[this.tabletblIntermediaries.IntermediaryNameColumn]);
      set => this[this.tabletblIntermediaries.IntermediaryNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyLocationsRow[] GettblCompanyLocationsRows()
    {
      return this.Table.ChildRelations["tblIntermediariestblCompanyLocations"] != null ? (dsCompanies.tblCompanyLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["tblIntermediariestblCompanyLocations"]) : new dsCompanies.tblCompanyLocationsRow[0];
    }
  }

  public class lstFSRRow : DataRow
  {
    private dsCompanies.lstFSRDataTable tablelstFSR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstFSRRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstFSR = (dsCompanies.lstFSRDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string FSR
    {
      get => Conversions.ToString(this[this.tablelstFSR.FSRColumn]);
      set => this[this.tablelstFSR.FSRColumn] = (object) value;
    }
  }

  public class lstFSCRow : DataRow
  {
    private dsCompanies.lstFSCDataTable tablelstFSC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstFSCRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstFSC = (dsCompanies.lstFSCDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string FSC
    {
      get => Conversions.ToString(this[this.tablelstFSC.FSCColumn]);
      set => this[this.tablelstFSC.FSCColumn] = (object) value;
    }
  }

  public class lstRatingBureauRow : DataRow
  {
    private dsCompanies.lstRatingBureauDataTable tablelstRatingBureau;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstRatingBureauRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstRatingBureau = (dsCompanies.lstRatingBureauDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int RatingBureauID
    {
      get => Conversions.ToInteger(this[this.tablelstRatingBureau.RatingBureauIDColumn]);
      set => this[this.tablelstRatingBureau.RatingBureauIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string RatingBureau
    {
      get => Conversions.ToString(this[this.tablelstRatingBureau.RatingBureauColumn]);
      set => this[this.tablelstRatingBureau.RatingBureauColumn] = (object) value;
    }
  }

  public class tblUsersRow : DataRow
  {
    private dsCompanies.tblUsersDataTable tabletblUsers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblUsersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUsers = (dsCompanies.tblUsersDataTable) this.Table;
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompanyContactsRowChangeEvent : EventArgs
  {
    private dsCompanies.tblCompanyContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyContactsRowChangeEvent(
      dsCompanies.tblCompanyContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstDeliveryMethodRowChangeEvent : EventArgs
  {
    private dsCompanies.lstDeliveryMethodRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstDeliveryMethodRowChangeEvent(
      dsCompanies.lstDeliveryMethodRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstDeliveryMethodRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompanyLocationsRowChangeEvent : EventArgs
  {
    private dsCompanies.tblCompanyLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyLocationsRowChangeEvent(
      dsCompanies.tblCompanyLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstStatusRowChangeEvent : EventArgs
  {
    private dsCompanies.lstStatusRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstStatusRowChangeEvent(dsCompanies.lstStatusRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstStatusRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstLocationTypeRowChangeEvent : EventArgs
  {
    private dsCompanies.lstLocationTypeRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstLocationTypeRowChangeEvent(dsCompanies.lstLocationTypeRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstLocationTypeRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompanyGroupsRowChangeEvent : EventArgs
  {
    private dsCompanies.tblCompanyGroupsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyGroupsRowChangeEvent(dsCompanies.tblCompanyGroupsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompanyGroupsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompaniesRowChangeEvent : EventArgs
  {
    private dsCompanies.tblCompaniesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompaniesRowChangeEvent(dsCompanies.tblCompaniesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblCompaniesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblIntermediariesRowChangeEvent : EventArgs
  {
    private dsCompanies.tblIntermediariesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblIntermediariesRowChangeEvent(
      dsCompanies.tblIntermediariesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblIntermediariesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstFSRRowChangeEvent : EventArgs
  {
    private dsCompanies.lstFSRRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstFSRRowChangeEvent(dsCompanies.lstFSRRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstFSRRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstFSCRowChangeEvent : EventArgs
  {
    private dsCompanies.lstFSCRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstFSCRowChangeEvent(dsCompanies.lstFSCRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstFSCRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstRatingBureauRowChangeEvent : EventArgs
  {
    private dsCompanies.lstRatingBureauRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstRatingBureauRowChangeEvent(dsCompanies.lstRatingBureauRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.lstRatingBureauRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblUsersRowChangeEvent : EventArgs
  {
    private dsCompanies.tblUsersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblUsersRowChangeEvent(dsCompanies.tblUsersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanies.tblUsersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
