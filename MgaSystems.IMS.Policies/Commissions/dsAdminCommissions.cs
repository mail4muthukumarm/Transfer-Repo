// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Commissions.dsAdminCommissions
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
namespace MGASystems.IMS.Policies.Commissions;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsAdminCommissions")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsAdminCommissions : DataSet
{
  private dsAdminCommissions.tblAdminCommissionsDataTable tabletblAdminCommissions;
  private dsAdminCommissions.viewAdminCommissionsDataTable tableviewAdminCommissions;
  private dsAdminCommissions.tblCompanyLocationsDataTable tabletblCompanyLocations;
  private dsAdminCommissions.tblProducerLocationsDataTable tabletblProducerLocations;
  private dsAdminCommissions.lstStatesDataTable tablelstStates;
  private dsAdminCommissions.lstLinesDataTable tablelstLines;
  private dsAdminCommissions.tblClientOfficesDataTable tabletblClientOffices;
  private dsAdminCommissions.tblUsersDataTable tabletblUsers;
  private dsAdminCommissions.lstPolicyTypesDataTable tablelstPolicyTypes;
  private dsAdminCommissions.tblProducersDataTable tabletblProducers;
  private DataRelation relationtblProducers_tblAdminCommissions;
  private DataRelation relationlstPolicyTypestblAdminCommissions;
  private DataRelation relationtblCompanyLocationstblAdminCommissions;
  private DataRelation relationtblUserstblAdminCommissions;
  private DataRelation relationtblProducerLocationstblAdminCommissions;
  private DataRelation relationlstLinestblAdminCommissions;
  private DataRelation relationlstStatestblAdminCommissions;
  private DataRelation relationtblClientOfficestblAdminCommissions;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsAdminCommissions()
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
  protected dsAdminCommissions(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblAdminCommissions)] != null)
          base.Tables.Add((DataTable) new dsAdminCommissions.tblAdminCommissionsDataTable(dataSet.Tables[nameof (tblAdminCommissions)]));
        if (dataSet.Tables[nameof (viewAdminCommissions)] != null)
          base.Tables.Add((DataTable) new dsAdminCommissions.viewAdminCommissionsDataTable(dataSet.Tables[nameof (viewAdminCommissions)]));
        if (dataSet.Tables[nameof (tblCompanyLocations)] != null)
          base.Tables.Add((DataTable) new dsAdminCommissions.tblCompanyLocationsDataTable(dataSet.Tables[nameof (tblCompanyLocations)]));
        if (dataSet.Tables[nameof (tblProducerLocations)] != null)
          base.Tables.Add((DataTable) new dsAdminCommissions.tblProducerLocationsDataTable(dataSet.Tables[nameof (tblProducerLocations)]));
        if (dataSet.Tables[nameof (lstStates)] != null)
          base.Tables.Add((DataTable) new dsAdminCommissions.lstStatesDataTable(dataSet.Tables[nameof (lstStates)]));
        if (dataSet.Tables[nameof (lstLines)] != null)
          base.Tables.Add((DataTable) new dsAdminCommissions.lstLinesDataTable(dataSet.Tables[nameof (lstLines)]));
        if (dataSet.Tables[nameof (tblClientOffices)] != null)
          base.Tables.Add((DataTable) new dsAdminCommissions.tblClientOfficesDataTable(dataSet.Tables[nameof (tblClientOffices)]));
        if (dataSet.Tables[nameof (tblUsers)] != null)
          base.Tables.Add((DataTable) new dsAdminCommissions.tblUsersDataTable(dataSet.Tables[nameof (tblUsers)]));
        if (dataSet.Tables[nameof (lstPolicyTypes)] != null)
          base.Tables.Add((DataTable) new dsAdminCommissions.lstPolicyTypesDataTable(dataSet.Tables[nameof (lstPolicyTypes)]));
        if (dataSet.Tables[nameof (tblProducers)] != null)
          base.Tables.Add((DataTable) new dsAdminCommissions.tblProducersDataTable(dataSet.Tables[nameof (tblProducers)]));
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
  public dsAdminCommissions.tblAdminCommissionsDataTable tblAdminCommissions
  {
    get => this.tabletblAdminCommissions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminCommissions.viewAdminCommissionsDataTable viewAdminCommissions
  {
    get => this.tableviewAdminCommissions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminCommissions.tblCompanyLocationsDataTable tblCompanyLocations
  {
    get => this.tabletblCompanyLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminCommissions.tblProducerLocationsDataTable tblProducerLocations
  {
    get => this.tabletblProducerLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminCommissions.lstStatesDataTable lstStates => this.tablelstStates;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminCommissions.lstLinesDataTable lstLines => this.tablelstLines;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminCommissions.tblClientOfficesDataTable tblClientOffices
  {
    get => this.tabletblClientOffices;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminCommissions.tblUsersDataTable tblUsers => this.tabletblUsers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminCommissions.lstPolicyTypesDataTable lstPolicyTypes => this.tablelstPolicyTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminCommissions.tblProducersDataTable tblProducers => this.tabletblProducers;

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
    dsAdminCommissions adminCommissions = (dsAdminCommissions) base.Clone();
    adminCommissions.InitVars();
    adminCommissions.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) adminCommissions;
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
      if (dataSet.Tables["tblAdminCommissions"] != null)
        base.Tables.Add((DataTable) new dsAdminCommissions.tblAdminCommissionsDataTable(dataSet.Tables["tblAdminCommissions"]));
      if (dataSet.Tables["viewAdminCommissions"] != null)
        base.Tables.Add((DataTable) new dsAdminCommissions.viewAdminCommissionsDataTable(dataSet.Tables["viewAdminCommissions"]));
      if (dataSet.Tables["tblCompanyLocations"] != null)
        base.Tables.Add((DataTable) new dsAdminCommissions.tblCompanyLocationsDataTable(dataSet.Tables["tblCompanyLocations"]));
      if (dataSet.Tables["tblProducerLocations"] != null)
        base.Tables.Add((DataTable) new dsAdminCommissions.tblProducerLocationsDataTable(dataSet.Tables["tblProducerLocations"]));
      if (dataSet.Tables["lstStates"] != null)
        base.Tables.Add((DataTable) new dsAdminCommissions.lstStatesDataTable(dataSet.Tables["lstStates"]));
      if (dataSet.Tables["lstLines"] != null)
        base.Tables.Add((DataTable) new dsAdminCommissions.lstLinesDataTable(dataSet.Tables["lstLines"]));
      if (dataSet.Tables["tblClientOffices"] != null)
        base.Tables.Add((DataTable) new dsAdminCommissions.tblClientOfficesDataTable(dataSet.Tables["tblClientOffices"]));
      if (dataSet.Tables["tblUsers"] != null)
        base.Tables.Add((DataTable) new dsAdminCommissions.tblUsersDataTable(dataSet.Tables["tblUsers"]));
      if (dataSet.Tables["lstPolicyTypes"] != null)
        base.Tables.Add((DataTable) new dsAdminCommissions.lstPolicyTypesDataTable(dataSet.Tables["lstPolicyTypes"]));
      if (dataSet.Tables["tblProducers"] != null)
        base.Tables.Add((DataTable) new dsAdminCommissions.tblProducersDataTable(dataSet.Tables["tblProducers"]));
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
    this.tabletblAdminCommissions = (dsAdminCommissions.tblAdminCommissionsDataTable) base.Tables["tblAdminCommissions"];
    if (initTable && this.tabletblAdminCommissions != null)
      this.tabletblAdminCommissions.InitVars();
    this.tableviewAdminCommissions = (dsAdminCommissions.viewAdminCommissionsDataTable) base.Tables["viewAdminCommissions"];
    if (initTable && this.tableviewAdminCommissions != null)
      this.tableviewAdminCommissions.InitVars();
    this.tabletblCompanyLocations = (dsAdminCommissions.tblCompanyLocationsDataTable) base.Tables["tblCompanyLocations"];
    if (initTable && this.tabletblCompanyLocations != null)
      this.tabletblCompanyLocations.InitVars();
    this.tabletblProducerLocations = (dsAdminCommissions.tblProducerLocationsDataTable) base.Tables["tblProducerLocations"];
    if (initTable && this.tabletblProducerLocations != null)
      this.tabletblProducerLocations.InitVars();
    this.tablelstStates = (dsAdminCommissions.lstStatesDataTable) base.Tables["lstStates"];
    if (initTable && this.tablelstStates != null)
      this.tablelstStates.InitVars();
    this.tablelstLines = (dsAdminCommissions.lstLinesDataTable) base.Tables["lstLines"];
    if (initTable && this.tablelstLines != null)
      this.tablelstLines.InitVars();
    this.tabletblClientOffices = (dsAdminCommissions.tblClientOfficesDataTable) base.Tables["tblClientOffices"];
    if (initTable && this.tabletblClientOffices != null)
      this.tabletblClientOffices.InitVars();
    this.tabletblUsers = (dsAdminCommissions.tblUsersDataTable) base.Tables["tblUsers"];
    if (initTable && this.tabletblUsers != null)
      this.tabletblUsers.InitVars();
    this.tablelstPolicyTypes = (dsAdminCommissions.lstPolicyTypesDataTable) base.Tables["lstPolicyTypes"];
    if (initTable && this.tablelstPolicyTypes != null)
      this.tablelstPolicyTypes.InitVars();
    this.tabletblProducers = (dsAdminCommissions.tblProducersDataTable) base.Tables["tblProducers"];
    if (initTable && this.tabletblProducers != null)
      this.tabletblProducers.InitVars();
    this.relationtblProducers_tblAdminCommissions = this.Relations["tblProducers_tblAdminCommissions"];
    this.relationlstPolicyTypestblAdminCommissions = this.Relations["lstPolicyTypestblAdminCommissions"];
    this.relationtblCompanyLocationstblAdminCommissions = this.Relations["tblCompanyLocationstblAdminCommissions"];
    this.relationtblUserstblAdminCommissions = this.Relations["tblUserstblAdminCommissions"];
    this.relationtblProducerLocationstblAdminCommissions = this.Relations["tblProducerLocationstblAdminCommissions"];
    this.relationlstLinestblAdminCommissions = this.Relations["lstLinestblAdminCommissions"];
    this.relationlstStatestblAdminCommissions = this.Relations["lstStatestblAdminCommissions"];
    this.relationtblClientOfficestblAdminCommissions = this.Relations["tblClientOfficestblAdminCommissions"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsAdminCommissions);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsAdminCommissions.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblAdminCommissions = new dsAdminCommissions.tblAdminCommissionsDataTable();
    base.Tables.Add((DataTable) this.tabletblAdminCommissions);
    this.tableviewAdminCommissions = new dsAdminCommissions.viewAdminCommissionsDataTable();
    base.Tables.Add((DataTable) this.tableviewAdminCommissions);
    this.tabletblCompanyLocations = new dsAdminCommissions.tblCompanyLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLocations);
    this.tabletblProducerLocations = new dsAdminCommissions.tblProducerLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerLocations);
    this.tablelstStates = new dsAdminCommissions.lstStatesDataTable();
    base.Tables.Add((DataTable) this.tablelstStates);
    this.tablelstLines = new dsAdminCommissions.lstLinesDataTable();
    base.Tables.Add((DataTable) this.tablelstLines);
    this.tabletblClientOffices = new dsAdminCommissions.tblClientOfficesDataTable();
    base.Tables.Add((DataTable) this.tabletblClientOffices);
    this.tabletblUsers = new dsAdminCommissions.tblUsersDataTable();
    base.Tables.Add((DataTable) this.tabletblUsers);
    this.tablelstPolicyTypes = new dsAdminCommissions.lstPolicyTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstPolicyTypes);
    this.tabletblProducers = new dsAdminCommissions.tblProducersDataTable();
    base.Tables.Add((DataTable) this.tabletblProducers);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("tblProducers_tblAdminCommissions", new DataColumn[1]
    {
      this.tabletblProducers.ProducerGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.ProducerGUIDColumn
    });
    this.tabletblAdminCommissions.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.None;
    foreignKeyConstraint1.UpdateRule = Rule.None;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstPolicyTypestblAdminCommissions", new DataColumn[1]
    {
      this.tablelstPolicyTypes.PolicyTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.PolicyTypeIDColumn
    });
    this.tabletblAdminCommissions.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("tblCompanyLocationstblAdminCommissions", new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyLocationGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.CompanyLocationGuidColumn
    });
    this.tabletblAdminCommissions.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("tblUserstblAdminCommissions", new DataColumn[1]
    {
      this.tabletblUsers.UserGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.InHouseProducerGuidColumn
    });
    this.tabletblAdminCommissions.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint5 = new ForeignKeyConstraint("tblProducerLocationstblAdminCommissions", new DataColumn[1]
    {
      this.tabletblProducerLocations.ProducerLocationGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.ProducerLocationGuidColumn
    });
    this.tabletblAdminCommissions.Constraints.Add((Constraint) foreignKeyConstraint5);
    foreignKeyConstraint5.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint5.DeleteRule = Rule.Cascade;
    foreignKeyConstraint5.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint6 = new ForeignKeyConstraint("lstLinestblAdminCommissions", new DataColumn[1]
    {
      this.tablelstLines.LineGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.LineGuidColumn
    });
    this.tabletblAdminCommissions.Constraints.Add((Constraint) foreignKeyConstraint6);
    foreignKeyConstraint6.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint6.DeleteRule = Rule.Cascade;
    foreignKeyConstraint6.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint7 = new ForeignKeyConstraint("lstStatestblAdminCommissions", new DataColumn[1]
    {
      this.tablelstStates.StateIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.StateIDColumn
    });
    this.tabletblAdminCommissions.Constraints.Add((Constraint) foreignKeyConstraint7);
    foreignKeyConstraint7.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint7.DeleteRule = Rule.Cascade;
    foreignKeyConstraint7.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint8 = new ForeignKeyConstraint("tblClientOfficestblAdminCommissions", new DataColumn[1]
    {
      this.tabletblClientOffices.OfficeGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.OfficeLocationGuidColumn
    });
    this.tabletblAdminCommissions.Constraints.Add((Constraint) foreignKeyConstraint8);
    foreignKeyConstraint8.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint8.DeleteRule = Rule.Cascade;
    foreignKeyConstraint8.UpdateRule = Rule.Cascade;
    this.relationtblProducers_tblAdminCommissions = new DataRelation("tblProducers_tblAdminCommissions", new DataColumn[1]
    {
      this.tabletblProducers.ProducerGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.ProducerGUIDColumn
    }, false);
    this.Relations.Add(this.relationtblProducers_tblAdminCommissions);
    this.relationlstPolicyTypestblAdminCommissions = new DataRelation("lstPolicyTypestblAdminCommissions", new DataColumn[1]
    {
      this.tablelstPolicyTypes.PolicyTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.PolicyTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstPolicyTypestblAdminCommissions);
    this.relationtblCompanyLocationstblAdminCommissions = new DataRelation("tblCompanyLocationstblAdminCommissions", new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyLocationGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.CompanyLocationGuidColumn
    }, false);
    this.Relations.Add(this.relationtblCompanyLocationstblAdminCommissions);
    this.relationtblUserstblAdminCommissions = new DataRelation("tblUserstblAdminCommissions", new DataColumn[1]
    {
      this.tabletblUsers.UserGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.InHouseProducerGuidColumn
    }, false);
    this.Relations.Add(this.relationtblUserstblAdminCommissions);
    this.relationtblProducerLocationstblAdminCommissions = new DataRelation("tblProducerLocationstblAdminCommissions", new DataColumn[1]
    {
      this.tabletblProducerLocations.ProducerLocationGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.ProducerLocationGuidColumn
    }, false);
    this.Relations.Add(this.relationtblProducerLocationstblAdminCommissions);
    this.relationlstLinestblAdminCommissions = new DataRelation("lstLinestblAdminCommissions", new DataColumn[1]
    {
      this.tablelstLines.LineGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.LineGuidColumn
    }, false);
    this.Relations.Add(this.relationlstLinestblAdminCommissions);
    this.relationlstStatestblAdminCommissions = new DataRelation("lstStatestblAdminCommissions", new DataColumn[1]
    {
      this.tablelstStates.StateIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.StateIDColumn
    }, false);
    this.Relations.Add(this.relationlstStatestblAdminCommissions);
    this.relationtblClientOfficestblAdminCommissions = new DataRelation("tblClientOfficestblAdminCommissions", new DataColumn[1]
    {
      this.tabletblClientOffices.OfficeGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdminCommissions.OfficeLocationGuidColumn
    }, false);
    this.Relations.Add(this.relationtblClientOfficestblAdminCommissions);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblAdminCommissions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeviewAdminCommissions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanyLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblProducerLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstStates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstLines() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblClientOffices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblUsers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstPolicyTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblProducers() => false;

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
    dsAdminCommissions adminCommissions = new dsAdminCommissions();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = adminCommissions.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = adminCommissions.GetSchemaSerializable();
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
  public delegate void tblAdminCommissionsRowChangeEventHandler(
    object sender,
    dsAdminCommissions.tblAdminCommissionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void viewAdminCommissionsRowChangeEventHandler(
    object sender,
    dsAdminCommissions.viewAdminCommissionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblCompanyLocationsRowChangeEventHandler(
    object sender,
    dsAdminCommissions.tblCompanyLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblProducerLocationsRowChangeEventHandler(
    object sender,
    dsAdminCommissions.tblProducerLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstStatesRowChangeEventHandler(
    object sender,
    dsAdminCommissions.lstStatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstLinesRowChangeEventHandler(
    object sender,
    dsAdminCommissions.lstLinesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblClientOfficesRowChangeEventHandler(
    object sender,
    dsAdminCommissions.tblClientOfficesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblUsersRowChangeEventHandler(
    object sender,
    dsAdminCommissions.tblUsersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstPolicyTypesRowChangeEventHandler(
    object sender,
    dsAdminCommissions.lstPolicyTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblProducersRowChangeEventHandler(
    object sender,
    dsAdminCommissions.tblProducersRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblAdminCommissionsDataTable : 
    TypedTableBase<dsAdminCommissions.tblAdminCommissionsRow>
  {
    private DataColumn columnID;
    private DataColumn columnStateID;
    private DataColumn columnLineGuid;
    private DataColumn columnProducerLocationGuid;
    private DataColumn columnCompanyLocationGuid;
    private DataColumn columnInHouseProducerGuid;
    private DataColumn columnOfficeLocationGuid;
    private DataColumn columnEntityGuid;
    private DataColumn columnChargeCode;
    private DataColumn columnEntityTypeID;
    private DataColumn columnCommissionTypeID;
    private DataColumn columnPercentage;
    private DataColumn columnFlatAmount;
    private DataColumn columnCommissionsFromOperatingAccount;
    private DataColumn columnAddedByUserID;
    private DataColumn columnCommissionOnTotalPremium;
    private DataColumn columnMinimumFirmIncome;
    private DataColumn columnIncomeBetweenStartMonth;
    private DataColumn columnIncomeBetweenStartDay;
    private DataColumn columnIncomeBetweenEndMonth;
    private DataColumn columnIncomeBetweenEndDay;
    private DataColumn columnHierarchy;
    private DataColumn columnUnderwriterGuid;
    private DataColumn columnIssuingOfficeGuid;
    private DataColumn columnPolicyTypeID;
    private DataColumn columnEffective;
    private DataColumn columnRenewalOnlyIfPreviouslyCommissioned;
    private DataColumn columnDisabledDate;
    private DataColumn columnProducerGUID;
    private DataColumn columnApplyPremiumEqualOrOver;
    private DataColumn columnApplyPremiumEqualOrLess;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblAdminCommissionsDataTable()
    {
      this.TableName = "tblAdminCommissions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblAdminCommissionsDataTable(DataTable table)
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
    protected tblAdminCommissionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LineGuidColumn => this.columnLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerLocationGuidColumn => this.columnProducerLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InHouseProducerGuidColumn => this.columnInHouseProducerGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfficeLocationGuidColumn => this.columnOfficeLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EntityGuidColumn => this.columnEntityGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EntityTypeIDColumn => this.columnEntityTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CommissionTypeIDColumn => this.columnCommissionTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PercentageColumn => this.columnPercentage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FlatAmountColumn => this.columnFlatAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CommissionsFromOperatingAccountColumn
    {
      get => this.columnCommissionsFromOperatingAccount;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AddedByUserIDColumn => this.columnAddedByUserID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CommissionOnTotalPremiumColumn => this.columnCommissionOnTotalPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MinimumFirmIncomeColumn => this.columnMinimumFirmIncome;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IncomeBetweenStartMonthColumn => this.columnIncomeBetweenStartMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IncomeBetweenStartDayColumn => this.columnIncomeBetweenStartDay;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IncomeBetweenEndMonthColumn => this.columnIncomeBetweenEndMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IncomeBetweenEndDayColumn => this.columnIncomeBetweenEndDay;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn HierarchyColumn => this.columnHierarchy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UnderwriterGuidColumn => this.columnUnderwriterGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IssuingOfficeGuidColumn => this.columnIssuingOfficeGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyTypeIDColumn => this.columnPolicyTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EffectiveColumn => this.columnEffective;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RenewalOnlyIfPreviouslyCommissionedColumn
    {
      get => this.columnRenewalOnlyIfPreviouslyCommissioned;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisabledDateColumn => this.columnDisabledDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerGUIDColumn => this.columnProducerGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ApplyPremiumEqualOrOverColumn => this.columnApplyPremiumEqualOrOver;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ApplyPremiumEqualOrLessColumn => this.columnApplyPremiumEqualOrLess;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblAdminCommissionsRow this[int index]
    {
      get => (dsAdminCommissions.tblAdminCommissionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblAdminCommissionsRowChangeEventHandler tblAdminCommissionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblAdminCommissionsRowChangeEventHandler tblAdminCommissionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblAdminCommissionsRowChangeEventHandler tblAdminCommissionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblAdminCommissionsRowChangeEventHandler tblAdminCommissionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblAdminCommissionsRow(dsAdminCommissions.tblAdminCommissionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblAdminCommissionsRow AddtblAdminCommissionsRow(
      dsAdminCommissions.lstStatesRow parentlstStatesRowBylstStatestblAdminCommissions,
      dsAdminCommissions.lstLinesRow parentlstLinesRowBylstLinestblAdminCommissions,
      dsAdminCommissions.tblProducerLocationsRow parenttblProducerLocationsRowBytblProducerLocationstblAdminCommissions,
      dsAdminCommissions.tblCompanyLocationsRow parenttblCompanyLocationsRowBytblCompanyLocationstblAdminCommissions,
      dsAdminCommissions.tblUsersRow parenttblUsersRowBytblUserstblAdminCommissions,
      dsAdminCommissions.tblClientOfficesRow parenttblClientOfficesRowBytblClientOfficestblAdminCommissions,
      Guid EntityGuid,
      int ChargeCode,
      string EntityTypeID,
      string CommissionTypeID,
      Decimal Percentage,
      Decimal FlatAmount,
      bool CommissionsFromOperatingAccount,
      int AddedByUserID,
      bool CommissionOnTotalPremium,
      int MinimumFirmIncome,
      int IncomeBetweenStartMonth,
      int IncomeBetweenStartDay,
      int IncomeBetweenEndMonth,
      int IncomeBetweenEndDay,
      int Hierarchy,
      Guid UnderwriterGuid,
      Guid IssuingOfficeGuid,
      dsAdminCommissions.lstPolicyTypesRow parentlstPolicyTypesRowBylstPolicyTypestblAdminCommissions,
      DateTime Effective,
      bool RenewalOnlyIfPreviouslyCommissioned,
      DateTime DisabledDate,
      dsAdminCommissions.tblProducersRow parenttblProducersRowBytblProducers_tblAdminCommissions,
      Decimal ApplyPremiumEqualOrOver,
      Decimal ApplyPremiumEqualOrLess)
    {
      dsAdminCommissions.tblAdminCommissionsRow row = (dsAdminCommissions.tblAdminCommissionsRow) this.NewRow();
      object[] objArray = new object[31 /*0x1F*/]
      {
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        (object) EntityGuid,
        (object) ChargeCode,
        (object) EntityTypeID,
        (object) CommissionTypeID,
        (object) Percentage,
        (object) FlatAmount,
        (object) CommissionsFromOperatingAccount,
        (object) AddedByUserID,
        (object) CommissionOnTotalPremium,
        (object) MinimumFirmIncome,
        (object) IncomeBetweenStartMonth,
        (object) IncomeBetweenStartDay,
        (object) IncomeBetweenEndMonth,
        (object) IncomeBetweenEndDay,
        (object) Hierarchy,
        (object) UnderwriterGuid,
        (object) IssuingOfficeGuid,
        null,
        (object) Effective,
        (object) RenewalOnlyIfPreviouslyCommissioned,
        (object) DisabledDate,
        null,
        (object) ApplyPremiumEqualOrOver,
        (object) ApplyPremiumEqualOrLess
      };
      if (parentlstStatesRowBylstStatestblAdminCommissions != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstStatesRowBylstStatestblAdminCommissions[0]);
      if (parentlstLinesRowBylstLinestblAdminCommissions != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parentlstLinesRowBylstLinestblAdminCommissions[0]);
      if (parenttblProducerLocationsRowBytblProducerLocationstblAdminCommissions != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parenttblProducerLocationsRowBytblProducerLocationstblAdminCommissions[0]);
      if (parenttblCompanyLocationsRowBytblCompanyLocationstblAdminCommissions != null)
        objArray[4] = RuntimeHelpers.GetObjectValue(parenttblCompanyLocationsRowBytblCompanyLocationstblAdminCommissions[0]);
      if (parenttblUsersRowBytblUserstblAdminCommissions != null)
        objArray[5] = RuntimeHelpers.GetObjectValue(parenttblUsersRowBytblUserstblAdminCommissions[0]);
      if (parenttblClientOfficesRowBytblClientOfficestblAdminCommissions != null)
        objArray[6] = RuntimeHelpers.GetObjectValue(parenttblClientOfficesRowBytblClientOfficestblAdminCommissions[0]);
      if (parentlstPolicyTypesRowBylstPolicyTypestblAdminCommissions != null)
        objArray[24] = RuntimeHelpers.GetObjectValue(parentlstPolicyTypesRowBylstPolicyTypestblAdminCommissions[0]);
      if (parenttblProducersRowBytblProducers_tblAdminCommissions != null)
        objArray[28] = RuntimeHelpers.GetObjectValue(parenttblProducersRowBytblProducers_tblAdminCommissions[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblAdminCommissionsRow FindByID(int ID)
    {
      return (dsAdminCommissions.tblAdminCommissionsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminCommissions.tblAdminCommissionsDataTable commissionsDataTable = (dsAdminCommissions.tblAdminCommissionsDataTable) base.Clone();
      commissionsDataTable.InitVars();
      return (DataTable) commissionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminCommissions.tblAdminCommissionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnStateID = this.Columns["StateID"];
      this.columnLineGuid = this.Columns["LineGuid"];
      this.columnProducerLocationGuid = this.Columns["ProducerLocationGuid"];
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
      this.columnInHouseProducerGuid = this.Columns["InHouseProducerGuid"];
      this.columnOfficeLocationGuid = this.Columns["OfficeLocationGuid"];
      this.columnEntityGuid = this.Columns["EntityGuid"];
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnEntityTypeID = this.Columns["EntityTypeID"];
      this.columnCommissionTypeID = this.Columns["CommissionTypeID"];
      this.columnPercentage = this.Columns["Percentage"];
      this.columnFlatAmount = this.Columns["FlatAmount"];
      this.columnCommissionsFromOperatingAccount = this.Columns["CommissionsFromOperatingAccount"];
      this.columnAddedByUserID = this.Columns["AddedByUserID"];
      this.columnCommissionOnTotalPremium = this.Columns["CommissionOnTotalPremium"];
      this.columnMinimumFirmIncome = this.Columns["MinimumFirmIncome"];
      this.columnIncomeBetweenStartMonth = this.Columns["IncomeBetweenStartMonth"];
      this.columnIncomeBetweenStartDay = this.Columns["IncomeBetweenStartDay"];
      this.columnIncomeBetweenEndMonth = this.Columns["IncomeBetweenEndMonth"];
      this.columnIncomeBetweenEndDay = this.Columns["IncomeBetweenEndDay"];
      this.columnHierarchy = this.Columns["Hierarchy"];
      this.columnUnderwriterGuid = this.Columns["UnderwriterGuid"];
      this.columnIssuingOfficeGuid = this.Columns["IssuingOfficeGuid"];
      this.columnPolicyTypeID = this.Columns["PolicyTypeID"];
      this.columnEffective = this.Columns["Effective"];
      this.columnRenewalOnlyIfPreviouslyCommissioned = this.Columns["RenewalOnlyIfPreviouslyCommissioned"];
      this.columnDisabledDate = this.Columns["DisabledDate"];
      this.columnProducerGUID = this.Columns["ProducerGUID"];
      this.columnApplyPremiumEqualOrOver = this.Columns["ApplyPremiumEqualOrOver"];
      this.columnApplyPremiumEqualOrLess = this.Columns["ApplyPremiumEqualOrLess"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnLineGuid = new DataColumn("LineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGuid);
      this.columnProducerLocationGuid = new DataColumn("ProducerLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGuid);
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.columnInHouseProducerGuid = new DataColumn("InHouseProducerGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInHouseProducerGuid);
      this.columnOfficeLocationGuid = new DataColumn("OfficeLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeLocationGuid);
      this.columnEntityGuid = new DataColumn("EntityGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGuid);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnEntityTypeID = new DataColumn("EntityTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityTypeID);
      this.columnCommissionTypeID = new DataColumn("CommissionTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionTypeID);
      this.columnPercentage = new DataColumn("Percentage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentage);
      this.columnFlatAmount = new DataColumn("FlatAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFlatAmount);
      this.columnCommissionsFromOperatingAccount = new DataColumn("CommissionsFromOperatingAccount", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionsFromOperatingAccount);
      this.columnAddedByUserID = new DataColumn("AddedByUserID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddedByUserID);
      this.columnCommissionOnTotalPremium = new DataColumn("CommissionOnTotalPremium", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionOnTotalPremium);
      this.columnMinimumFirmIncome = new DataColumn("MinimumFirmIncome", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMinimumFirmIncome);
      this.columnIncomeBetweenStartMonth = new DataColumn("IncomeBetweenStartMonth", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIncomeBetweenStartMonth);
      this.columnIncomeBetweenStartDay = new DataColumn("IncomeBetweenStartDay", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIncomeBetweenStartDay);
      this.columnIncomeBetweenEndMonth = new DataColumn("IncomeBetweenEndMonth", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIncomeBetweenEndMonth);
      this.columnIncomeBetweenEndDay = new DataColumn("IncomeBetweenEndDay", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIncomeBetweenEndDay);
      this.columnHierarchy = new DataColumn("Hierarchy", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHierarchy);
      this.columnUnderwriterGuid = new DataColumn("UnderwriterGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriterGuid);
      this.columnIssuingOfficeGuid = new DataColumn("IssuingOfficeGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIssuingOfficeGuid);
      this.columnPolicyTypeID = new DataColumn("PolicyTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyTypeID);
      this.columnEffective = new DataColumn("Effective", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffective);
      this.columnRenewalOnlyIfPreviouslyCommissioned = new DataColumn("RenewalOnlyIfPreviouslyCommissioned", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRenewalOnlyIfPreviouslyCommissioned);
      this.columnDisabledDate = new DataColumn("DisabledDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisabledDate);
      this.columnProducerGUID = new DataColumn("ProducerGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerGUID);
      this.columnApplyPremiumEqualOrOver = new DataColumn("ApplyPremiumEqualOrOver", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnApplyPremiumEqualOrOver);
      this.columnApplyPremiumEqualOrLess = new DataColumn("ApplyPremiumEqualOrLess", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnApplyPremiumEqualOrLess);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdminCommissionsKey1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnCommissionsFromOperatingAccount.AllowDBNull = false;
      this.columnCommissionsFromOperatingAccount.DefaultValue = (object) false;
      this.columnCommissionOnTotalPremium.AllowDBNull = false;
      this.columnCommissionOnTotalPremium.DefaultValue = (object) false;
      this.columnHierarchy.AllowDBNull = false;
      this.columnRenewalOnlyIfPreviouslyCommissioned.AllowDBNull = false;
      this.columnRenewalOnlyIfPreviouslyCommissioned.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblAdminCommissionsRow NewtblAdminCommissionsRow()
    {
      return (dsAdminCommissions.tblAdminCommissionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminCommissions.tblAdminCommissionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminCommissions.tblAdminCommissionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdminCommissionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.tblAdminCommissionsRowChangeEventHandler commissionsRowChangedEvent = this.tblAdminCommissionsRowChangedEvent;
      if (commissionsRowChangedEvent == null)
        return;
      commissionsRowChangedEvent((object) this, new dsAdminCommissions.tblAdminCommissionsRowChangeEvent((dsAdminCommissions.tblAdminCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdminCommissionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.tblAdminCommissionsRowChangeEventHandler rowChangingEvent = this.tblAdminCommissionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminCommissions.tblAdminCommissionsRowChangeEvent((dsAdminCommissions.tblAdminCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdminCommissionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.tblAdminCommissionsRowChangeEventHandler commissionsRowDeletedEvent = this.tblAdminCommissionsRowDeletedEvent;
      if (commissionsRowDeletedEvent == null)
        return;
      commissionsRowDeletedEvent((object) this, new dsAdminCommissions.tblAdminCommissionsRowChangeEvent((dsAdminCommissions.tblAdminCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdminCommissionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.tblAdminCommissionsRowChangeEventHandler rowDeletingEvent = this.tblAdminCommissionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminCommissions.tblAdminCommissionsRowChangeEvent((dsAdminCommissions.tblAdminCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblAdminCommissionsRow(dsAdminCommissions.tblAdminCommissionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminCommissions adminCommissions = new dsAdminCommissions();
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
        FixedValue = adminCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblAdminCommissionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = adminCommissions.GetSchemaSerializable();
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
  public class viewAdminCommissionsDataTable : 
    TypedTableBase<dsAdminCommissions.viewAdminCommissionsRow>
  {
    private DataColumn columnProducer;
    private DataColumn columnLine;
    private DataColumn columnState;
    private DataColumn columnCompany;
    private DataColumn columnEntity;
    private DataColumn columnEntityType;
    private DataColumn columnCommissionType;
    private DataColumn columnPercentage;
    private DataColumn columnFlatAmount;
    private DataColumn columnID;
    private DataColumn columnChargeName;
    private DataColumn columnCommissionsFromOperatingAccount;
    private DataColumn columnHierarchy;
    private DataColumn columnEffective;
    private DataColumn columnDisabledDate;
    private DataColumn columnEntityGuid;
    private DataColumn columnProducerGUID;
    private DataColumn columnCompanyGUID;
    private DataColumn columnLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public viewAdminCommissionsDataTable()
    {
      this.TableName = "viewAdminCommissions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal viewAdminCommissionsDataTable(DataTable table)
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
    protected viewAdminCommissionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerColumn => this.columnProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LineColumn => this.columnLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyColumn => this.columnCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EntityColumn => this.columnEntity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EntityTypeColumn => this.columnEntityType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CommissionTypeColumn => this.columnCommissionType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PercentageColumn => this.columnPercentage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FlatAmountColumn => this.columnFlatAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CommissionsFromOperatingAccountColumn
    {
      get => this.columnCommissionsFromOperatingAccount;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn HierarchyColumn => this.columnHierarchy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EffectiveColumn => this.columnEffective;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisabledDateColumn => this.columnDisabledDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EntityGuidColumn => this.columnEntityGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerGUIDColumn => this.columnProducerGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyGUIDColumn => this.columnCompanyGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LineGUIDColumn => this.columnLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.viewAdminCommissionsRow this[int index]
    {
      get => (dsAdminCommissions.viewAdminCommissionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.viewAdminCommissionsRowChangeEventHandler viewAdminCommissionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.viewAdminCommissionsRowChangeEventHandler viewAdminCommissionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.viewAdminCommissionsRowChangeEventHandler viewAdminCommissionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.viewAdminCommissionsRowChangeEventHandler viewAdminCommissionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddviewAdminCommissionsRow(dsAdminCommissions.viewAdminCommissionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.viewAdminCommissionsRow AddviewAdminCommissionsRow(
      string Producer,
      string Line,
      string State,
      string Company,
      string Entity,
      string EntityType,
      string CommissionType,
      Decimal Percentage,
      Decimal FlatAmount,
      string ChargeName,
      bool CommissionsFromOperatingAccount,
      int Hierarchy,
      DateTime Effective,
      DateTime DisabledDate,
      Guid EntityGuid,
      Guid ProducerGUID,
      Guid CompanyGUID,
      Guid LineGUID)
    {
      dsAdminCommissions.viewAdminCommissionsRow row = (dsAdminCommissions.viewAdminCommissionsRow) this.NewRow();
      object[] objArray = new object[19]
      {
        (object) Producer,
        (object) Line,
        (object) State,
        (object) Company,
        (object) Entity,
        (object) EntityType,
        (object) CommissionType,
        (object) Percentage,
        (object) FlatAmount,
        null,
        (object) ChargeName,
        (object) CommissionsFromOperatingAccount,
        (object) Hierarchy,
        (object) Effective,
        (object) DisabledDate,
        (object) EntityGuid,
        (object) ProducerGUID,
        (object) CompanyGUID,
        (object) LineGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.viewAdminCommissionsRow FindByID(int ID)
    {
      return (dsAdminCommissions.viewAdminCommissionsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminCommissions.viewAdminCommissionsDataTable commissionsDataTable = (dsAdminCommissions.viewAdminCommissionsDataTable) base.Clone();
      commissionsDataTable.InitVars();
      return (DataTable) commissionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminCommissions.viewAdminCommissionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnProducer = this.Columns["Producer"];
      this.columnLine = this.Columns["Line"];
      this.columnState = this.Columns["State"];
      this.columnCompany = this.Columns["Company"];
      this.columnEntity = this.Columns["Entity"];
      this.columnEntityType = this.Columns["EntityType"];
      this.columnCommissionType = this.Columns["CommissionType"];
      this.columnPercentage = this.Columns["Percentage"];
      this.columnFlatAmount = this.Columns["FlatAmount"];
      this.columnID = this.Columns["ID"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnCommissionsFromOperatingAccount = this.Columns["CommissionsFromOperatingAccount"];
      this.columnHierarchy = this.Columns["Hierarchy"];
      this.columnEffective = this.Columns["Effective"];
      this.columnDisabledDate = this.Columns["DisabledDate"];
      this.columnEntityGuid = this.Columns["EntityGuid"];
      this.columnProducerGUID = this.Columns["ProducerGUID"];
      this.columnCompanyGUID = this.Columns["CompanyGUID"];
      this.columnLineGUID = this.Columns["LineGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnProducer = new DataColumn("Producer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducer);
      this.columnLine = new DataColumn("Line", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLine);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnCompany = new DataColumn("Company", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany);
      this.columnEntity = new DataColumn("Entity", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity);
      this.columnEntityType = new DataColumn("EntityType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityType);
      this.columnCommissionType = new DataColumn("CommissionType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionType);
      this.columnPercentage = new DataColumn("Percentage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentage);
      this.columnFlatAmount = new DataColumn("FlatAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFlatAmount);
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnCommissionsFromOperatingAccount = new DataColumn("CommissionsFromOperatingAccount", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionsFromOperatingAccount);
      this.columnHierarchy = new DataColumn("Hierarchy", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHierarchy);
      this.columnEffective = new DataColumn("Effective", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffective);
      this.columnDisabledDate = new DataColumn("DisabledDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisabledDate);
      this.columnEntityGuid = new DataColumn("EntityGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGuid);
      this.columnProducerGUID = new DataColumn("ProducerGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerGUID);
      this.columnCompanyGUID = new DataColumn("CompanyGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGUID);
      this.columnLineGUID = new DataColumn("LineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdminCommissionsKey2", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnCompany.ReadOnly = true;
      this.columnEntity.AllowDBNull = false;
      this.columnEntity.ReadOnly = true;
      this.columnEntityType.AllowDBNull = false;
      this.columnCommissionType.AllowDBNull = false;
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnCommissionsFromOperatingAccount.AllowDBNull = false;
      this.columnCommissionsFromOperatingAccount.DefaultValue = (object) false;
      this.columnHierarchy.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.viewAdminCommissionsRow NewviewAdminCommissionsRow()
    {
      return (dsAdminCommissions.viewAdminCommissionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminCommissions.viewAdminCommissionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminCommissions.viewAdminCommissionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.viewAdminCommissionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.viewAdminCommissionsRowChangeEventHandler commissionsRowChangedEvent = this.viewAdminCommissionsRowChangedEvent;
      if (commissionsRowChangedEvent == null)
        return;
      commissionsRowChangedEvent((object) this, new dsAdminCommissions.viewAdminCommissionsRowChangeEvent((dsAdminCommissions.viewAdminCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.viewAdminCommissionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.viewAdminCommissionsRowChangeEventHandler rowChangingEvent = this.viewAdminCommissionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminCommissions.viewAdminCommissionsRowChangeEvent((dsAdminCommissions.viewAdminCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.viewAdminCommissionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.viewAdminCommissionsRowChangeEventHandler commissionsRowDeletedEvent = this.viewAdminCommissionsRowDeletedEvent;
      if (commissionsRowDeletedEvent == null)
        return;
      commissionsRowDeletedEvent((object) this, new dsAdminCommissions.viewAdminCommissionsRowChangeEvent((dsAdminCommissions.viewAdminCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.viewAdminCommissionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.viewAdminCommissionsRowChangeEventHandler rowDeletingEvent = this.viewAdminCommissionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminCommissions.viewAdminCommissionsRowChangeEvent((dsAdminCommissions.viewAdminCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveviewAdminCommissionsRow(dsAdminCommissions.viewAdminCommissionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminCommissions adminCommissions = new dsAdminCommissions();
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
        FixedValue = adminCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (viewAdminCommissionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = adminCommissions.GetSchemaSerializable();
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
    TypedTableBase<dsAdminCommissions.tblCompanyLocationsRow>
  {
    private DataColumn columnCompanyLocationGUID;
    private DataColumn columnName;

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
    public DataColumn CompanyLocationGUIDColumn => this.columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblCompanyLocationsRow this[int index]
    {
      get => (dsAdminCommissions.tblCompanyLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompanyLocationsRow(dsAdminCommissions.tblCompanyLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblCompanyLocationsRow AddtblCompanyLocationsRow(
      Guid CompanyLocationGUID,
      string Name)
    {
      dsAdminCommissions.tblCompanyLocationsRow row = (dsAdminCommissions.tblCompanyLocationsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyLocationGUID,
        (object) Name
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblCompanyLocationsRow FindByCompanyLocationGUID(
      Guid CompanyLocationGUID)
    {
      return (dsAdminCommissions.tblCompanyLocationsRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLocationGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminCommissions.tblCompanyLocationsDataTable locationsDataTable = (dsAdminCommissions.tblCompanyLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminCommissions.tblCompanyLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLocationGUID = this.Columns["CompanyLocationGUID"];
      this.columnName = this.Columns["Name"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLocationGUID = new DataColumn("CompanyLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGUID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdminCommissionsKey3", new DataColumn[1]
      {
        this.columnCompanyLocationGUID
      }, true));
      this.columnCompanyLocationGUID.AllowDBNull = false;
      this.columnCompanyLocationGUID.Unique = true;
      this.columnName.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblCompanyLocationsRow NewtblCompanyLocationsRow()
    {
      return (dsAdminCommissions.tblCompanyLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminCommissions.tblCompanyLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminCommissions.tblCompanyLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.tblCompanyLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblCompanyLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsAdminCommissions.tblCompanyLocationsRowChangeEvent((dsAdminCommissions.tblCompanyLocationsRow) e.Row, e.Action));
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
      dsAdminCommissions.tblCompanyLocationsRowChangeEventHandler rowChangingEvent = this.tblCompanyLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminCommissions.tblCompanyLocationsRowChangeEvent((dsAdminCommissions.tblCompanyLocationsRow) e.Row, e.Action));
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
      dsAdminCommissions.tblCompanyLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblCompanyLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsAdminCommissions.tblCompanyLocationsRowChangeEvent((dsAdminCommissions.tblCompanyLocationsRow) e.Row, e.Action));
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
      dsAdminCommissions.tblCompanyLocationsRowChangeEventHandler rowDeletingEvent = this.tblCompanyLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminCommissions.tblCompanyLocationsRowChangeEvent((dsAdminCommissions.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompanyLocationsRow(dsAdminCommissions.tblCompanyLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminCommissions adminCommissions = new dsAdminCommissions();
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
        FixedValue = adminCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = adminCommissions.GetSchemaSerializable();
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
  public class tblProducerLocationsDataTable : 
    TypedTableBase<dsAdminCommissions.tblProducerLocationsRow>
  {
    private DataColumn columnProducerLocationGUID;
    private DataColumn columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerLocationsDataTable()
    {
      this.TableName = "tblProducerLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducerLocationsDataTable(DataTable table)
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
    protected tblProducerLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerLocationGUIDColumn => this.columnProducerLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblProducerLocationsRow this[int index]
    {
      get => (dsAdminCommissions.tblProducerLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblProducerLocationsRow(dsAdminCommissions.tblProducerLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblProducerLocationsRow AddtblProducerLocationsRow(
      Guid ProducerLocationGUID,
      string Name)
    {
      dsAdminCommissions.tblProducerLocationsRow row = (dsAdminCommissions.tblProducerLocationsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ProducerLocationGUID,
        (object) Name
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblProducerLocationsRow FindByProducerLocationGUID(
      Guid ProducerLocationGUID)
    {
      return (dsAdminCommissions.tblProducerLocationsRow) this.Rows.Find(new object[1]
      {
        (object) ProducerLocationGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminCommissions.tblProducerLocationsDataTable locationsDataTable = (dsAdminCommissions.tblProducerLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminCommissions.tblProducerLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerLocationGUID = this.Columns["ProducerLocationGUID"];
      this.columnName = this.Columns["Name"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnProducerLocationGUID = new DataColumn("ProducerLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGUID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdminCommissionsKey4", new DataColumn[1]
      {
        this.columnProducerLocationGUID
      }, true));
      this.columnProducerLocationGUID.AllowDBNull = false;
      this.columnProducerLocationGUID.Unique = true;
      this.columnName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblProducerLocationsRow NewtblProducerLocationsRow()
    {
      return (dsAdminCommissions.tblProducerLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminCommissions.tblProducerLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminCommissions.tblProducerLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.tblProducerLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblProducerLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsAdminCommissions.tblProducerLocationsRowChangeEvent((dsAdminCommissions.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.tblProducerLocationsRowChangeEventHandler rowChangingEvent = this.tblProducerLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminCommissions.tblProducerLocationsRowChangeEvent((dsAdminCommissions.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.tblProducerLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblProducerLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsAdminCommissions.tblProducerLocationsRowChangeEvent((dsAdminCommissions.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.tblProducerLocationsRowChangeEventHandler rowDeletingEvent = this.tblProducerLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminCommissions.tblProducerLocationsRowChangeEvent((dsAdminCommissions.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblProducerLocationsRow(dsAdminCommissions.tblProducerLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminCommissions adminCommissions = new dsAdminCommissions();
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
        FixedValue = adminCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = adminCommissions.GetSchemaSerializable();
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
  public class lstStatesDataTable : TypedTableBase<dsAdminCommissions.lstStatesRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstStatesDataTable()
    {
      this.TableName = "lstStates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected lstStatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstStatesRow this[int index]
    {
      get => (dsAdminCommissions.lstStatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.lstStatesRowChangeEventHandler lstStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.lstStatesRowChangeEventHandler lstStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.lstStatesRowChangeEventHandler lstStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.lstStatesRowChangeEventHandler lstStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstStatesRow(dsAdminCommissions.lstStatesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstStatesRow AddlstStatesRow(string StateID, string State)
    {
      dsAdminCommissions.lstStatesRow row = (dsAdminCommissions.lstStatesRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstStatesRow FindByStateID(string StateID)
    {
      return (dsAdminCommissions.lstStatesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminCommissions.lstStatesDataTable lstStatesDataTable = (dsAdminCommissions.lstStatesDataTable) base.Clone();
      lstStatesDataTable.InitVars();
      return (DataTable) lstStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminCommissions.lstStatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnState = this.Columns["State"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdminCommissionsKey5", new DataColumn[1]
      {
        this.columnStateID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.Unique = true;
      this.columnState.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstStatesRow NewlstStatesRow()
    {
      return (dsAdminCommissions.lstStatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminCommissions.lstStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminCommissions.lstStatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.lstStatesRowChangeEventHandler statesRowChangedEvent = this.lstStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsAdminCommissions.lstStatesRowChangeEvent((dsAdminCommissions.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.lstStatesRowChangeEventHandler rowChangingEvent = this.lstStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminCommissions.lstStatesRowChangeEvent((dsAdminCommissions.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.lstStatesRowChangeEventHandler statesRowDeletedEvent = this.lstStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsAdminCommissions.lstStatesRowChangeEvent((dsAdminCommissions.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.lstStatesRowChangeEventHandler rowDeletingEvent = this.lstStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminCommissions.lstStatesRowChangeEvent((dsAdminCommissions.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstStatesRow(dsAdminCommissions.lstStatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminCommissions adminCommissions = new dsAdminCommissions();
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
        FixedValue = adminCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = adminCommissions.GetSchemaSerializable();
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
  public class lstLinesDataTable : TypedTableBase<dsAdminCommissions.lstLinesRow>
  {
    private DataColumn columnLineGUID;
    private DataColumn columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstLinesDataTable()
    {
      this.TableName = "lstLines";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected lstLinesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LineGUIDColumn => this.columnLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstLinesRow this[int index]
    {
      get => (dsAdminCommissions.lstLinesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.lstLinesRowChangeEventHandler lstLinesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.lstLinesRowChangeEventHandler lstLinesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.lstLinesRowChangeEventHandler lstLinesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.lstLinesRowChangeEventHandler lstLinesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstLinesRow(dsAdminCommissions.lstLinesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstLinesRow AddlstLinesRow(Guid LineGUID, string LineName)
    {
      dsAdminCommissions.lstLinesRow row = (dsAdminCommissions.lstLinesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) LineGUID,
        (object) LineName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstLinesRow FindByLineGUID(Guid LineGUID)
    {
      return (dsAdminCommissions.lstLinesRow) this.Rows.Find(new object[1]
      {
        (object) LineGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminCommissions.lstLinesDataTable lstLinesDataTable = (dsAdminCommissions.lstLinesDataTable) base.Clone();
      lstLinesDataTable.InitVars();
      return (DataTable) lstLinesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminCommissions.lstLinesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnLineGUID = this.Columns["LineGUID"];
      this.columnLineName = this.Columns["LineName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnLineGUID = new DataColumn("LineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGUID);
      this.columnLineName = new DataColumn("LineName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdminCommissionsKey6", new DataColumn[1]
      {
        this.columnLineGUID
      }, true));
      this.columnLineGUID.AllowDBNull = false;
      this.columnLineGUID.Unique = true;
      this.columnLineName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstLinesRow NewlstLinesRow()
    {
      return (dsAdminCommissions.lstLinesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminCommissions.lstLinesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminCommissions.lstLinesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.lstLinesRowChangeEventHandler linesRowChangedEvent = this.lstLinesRowChangedEvent;
      if (linesRowChangedEvent == null)
        return;
      linesRowChangedEvent((object) this, new dsAdminCommissions.lstLinesRowChangeEvent((dsAdminCommissions.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.lstLinesRowChangeEventHandler rowChangingEvent = this.lstLinesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminCommissions.lstLinesRowChangeEvent((dsAdminCommissions.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.lstLinesRowChangeEventHandler linesRowDeletedEvent = this.lstLinesRowDeletedEvent;
      if (linesRowDeletedEvent == null)
        return;
      linesRowDeletedEvent((object) this, new dsAdminCommissions.lstLinesRowChangeEvent((dsAdminCommissions.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.lstLinesRowChangeEventHandler rowDeletingEvent = this.lstLinesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminCommissions.lstLinesRowChangeEvent((dsAdminCommissions.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstLinesRow(dsAdminCommissions.lstLinesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminCommissions adminCommissions = new dsAdminCommissions();
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
        FixedValue = adminCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstLinesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = adminCommissions.GetSchemaSerializable();
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
  public class tblClientOfficesDataTable : TypedTableBase<dsAdminCommissions.tblClientOfficesRow>
  {
    private DataColumn columnOfficeGUID;
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
    public DataColumn OfficeGUIDColumn => this.columnOfficeGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblClientOfficesRow this[int index]
    {
      get => (dsAdminCommissions.tblClientOfficesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblClientOfficesRow(dsAdminCommissions.tblClientOfficesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblClientOfficesRow AddtblClientOfficesRow(
      Guid OfficeGUID,
      string Location)
    {
      dsAdminCommissions.tblClientOfficesRow row = (dsAdminCommissions.tblClientOfficesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) OfficeGUID,
        (object) Location
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblClientOfficesRow FindByOfficeGUID(Guid OfficeGUID)
    {
      return (dsAdminCommissions.tblClientOfficesRow) this.Rows.Find(new object[1]
      {
        (object) OfficeGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminCommissions.tblClientOfficesDataTable officesDataTable = (dsAdminCommissions.tblClientOfficesDataTable) base.Clone();
      officesDataTable.InitVars();
      return (DataTable) officesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminCommissions.tblClientOfficesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnOfficeGUID = this.Columns["OfficeGUID"];
      this.columnLocation = this.Columns["Location"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnOfficeGUID = new DataColumn("OfficeGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeGUID);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdminCommissionsKey7", new DataColumn[1]
      {
        this.columnOfficeGUID
      }, true));
      this.columnOfficeGUID.AllowDBNull = false;
      this.columnOfficeGUID.Unique = true;
      this.columnLocation.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblClientOfficesRow NewtblClientOfficesRow()
    {
      return (dsAdminCommissions.tblClientOfficesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminCommissions.tblClientOfficesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminCommissions.tblClientOfficesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.tblClientOfficesRowChangeEventHandler officesRowChangedEvent = this.tblClientOfficesRowChangedEvent;
      if (officesRowChangedEvent == null)
        return;
      officesRowChangedEvent((object) this, new dsAdminCommissions.tblClientOfficesRowChangeEvent((dsAdminCommissions.tblClientOfficesRow) e.Row, e.Action));
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
      dsAdminCommissions.tblClientOfficesRowChangeEventHandler rowChangingEvent = this.tblClientOfficesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminCommissions.tblClientOfficesRowChangeEvent((dsAdminCommissions.tblClientOfficesRow) e.Row, e.Action));
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
      dsAdminCommissions.tblClientOfficesRowChangeEventHandler officesRowDeletedEvent = this.tblClientOfficesRowDeletedEvent;
      if (officesRowDeletedEvent == null)
        return;
      officesRowDeletedEvent((object) this, new dsAdminCommissions.tblClientOfficesRowChangeEvent((dsAdminCommissions.tblClientOfficesRow) e.Row, e.Action));
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
      dsAdminCommissions.tblClientOfficesRowChangeEventHandler rowDeletingEvent = this.tblClientOfficesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminCommissions.tblClientOfficesRowChangeEvent((dsAdminCommissions.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblClientOfficesRow(dsAdminCommissions.tblClientOfficesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminCommissions adminCommissions = new dsAdminCommissions();
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
        FixedValue = adminCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClientOfficesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = adminCommissions.GetSchemaSerializable();
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
  public class tblUsersDataTable : TypedTableBase<dsAdminCommissions.tblUsersRow>
  {
    private DataColumn columnUserGUID;
    private DataColumn columnUserName;
    private DataColumn columnIsUnderwriter;

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
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IsUnderwriterColumn => this.columnIsUnderwriter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblUsersRow this[int index]
    {
      get => (dsAdminCommissions.tblUsersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblUsersRowChangeEventHandler tblUsersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblUsersRowChangeEventHandler tblUsersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblUsersRowChangeEventHandler tblUsersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblUsersRowChangeEventHandler tblUsersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblUsersRow(dsAdminCommissions.tblUsersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblUsersRow AddtblUsersRow(
      Guid UserGUID,
      string UserName,
      bool IsUnderwriter)
    {
      dsAdminCommissions.tblUsersRow row = (dsAdminCommissions.tblUsersRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) UserGUID,
        (object) UserName,
        (object) IsUnderwriter
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblUsersRow FindByUserGUID(Guid UserGUID)
    {
      return (dsAdminCommissions.tblUsersRow) this.Rows.Find(new object[1]
      {
        (object) UserGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminCommissions.tblUsersDataTable tblUsersDataTable = (dsAdminCommissions.tblUsersDataTable) base.Clone();
      tblUsersDataTable.InitVars();
      return (DataTable) tblUsersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminCommissions.tblUsersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnUserGUID = this.Columns["UserGUID"];
      this.columnUserName = this.Columns["UserName"];
      this.columnIsUnderwriter = this.Columns["IsUnderwriter"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnUserGUID = new DataColumn("UserGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUID);
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.columnIsUnderwriter = new DataColumn("IsUnderwriter", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsUnderwriter);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdminCommissionsKey8", new DataColumn[1]
      {
        this.columnUserGUID
      }, true));
      this.columnUserGUID.AllowDBNull = false;
      this.columnUserGUID.Unique = true;
      this.columnUserName.AllowDBNull = false;
      this.columnIsUnderwriter.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblUsersRow NewtblUsersRow()
    {
      return (dsAdminCommissions.tblUsersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminCommissions.tblUsersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminCommissions.tblUsersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.tblUsersRowChangeEventHandler usersRowChangedEvent = this.tblUsersRowChangedEvent;
      if (usersRowChangedEvent == null)
        return;
      usersRowChangedEvent((object) this, new dsAdminCommissions.tblUsersRowChangeEvent((dsAdminCommissions.tblUsersRow) e.Row, e.Action));
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
      dsAdminCommissions.tblUsersRowChangeEventHandler rowChangingEvent = this.tblUsersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminCommissions.tblUsersRowChangeEvent((dsAdminCommissions.tblUsersRow) e.Row, e.Action));
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
      dsAdminCommissions.tblUsersRowChangeEventHandler usersRowDeletedEvent = this.tblUsersRowDeletedEvent;
      if (usersRowDeletedEvent == null)
        return;
      usersRowDeletedEvent((object) this, new dsAdminCommissions.tblUsersRowChangeEvent((dsAdminCommissions.tblUsersRow) e.Row, e.Action));
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
      dsAdminCommissions.tblUsersRowChangeEventHandler rowDeletingEvent = this.tblUsersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminCommissions.tblUsersRowChangeEvent((dsAdminCommissions.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblUsersRow(dsAdminCommissions.tblUsersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminCommissions adminCommissions = new dsAdminCommissions();
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
        FixedValue = adminCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUsersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = adminCommissions.GetSchemaSerializable();
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
  public class lstPolicyTypesDataTable : TypedTableBase<dsAdminCommissions.lstPolicyTypesRow>
  {
    private DataColumn columnPolicyTypeID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPolicyTypesDataTable()
    {
      this.TableName = "lstPolicyTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected lstPolicyTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyTypeIDColumn => this.columnPolicyTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstPolicyTypesRow this[int index]
    {
      get => (dsAdminCommissions.lstPolicyTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstPolicyTypesRow(dsAdminCommissions.lstPolicyTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstPolicyTypesRow AddlstPolicyTypesRow(
      int PolicyTypeID,
      string Description)
    {
      dsAdminCommissions.lstPolicyTypesRow row = (dsAdminCommissions.lstPolicyTypesRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstPolicyTypesRow FindByPolicyTypeID(int PolicyTypeID)
    {
      return (dsAdminCommissions.lstPolicyTypesRow) this.Rows.Find(new object[1]
      {
        (object) PolicyTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminCommissions.lstPolicyTypesDataTable policyTypesDataTable = (dsAdminCommissions.lstPolicyTypesDataTable) base.Clone();
      policyTypesDataTable.InitVars();
      return (DataTable) policyTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminCommissions.lstPolicyTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnPolicyTypeID = this.Columns["PolicyTypeID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnPolicyTypeID = new DataColumn("PolicyTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyTypeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdminCommissionsKey9", new DataColumn[1]
      {
        this.columnPolicyTypeID
      }, true));
      this.columnPolicyTypeID.AllowDBNull = false;
      this.columnPolicyTypeID.Unique = true;
      this.columnDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstPolicyTypesRow NewlstPolicyTypesRow()
    {
      return (dsAdminCommissions.lstPolicyTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminCommissions.lstPolicyTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminCommissions.lstPolicyTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.lstPolicyTypesRowChangeEventHandler typesRowChangedEvent = this.lstPolicyTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsAdminCommissions.lstPolicyTypesRowChangeEvent((dsAdminCommissions.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.lstPolicyTypesRowChangeEventHandler rowChangingEvent = this.lstPolicyTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminCommissions.lstPolicyTypesRowChangeEvent((dsAdminCommissions.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.lstPolicyTypesRowChangeEventHandler typesRowDeletedEvent = this.lstPolicyTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsAdminCommissions.lstPolicyTypesRowChangeEvent((dsAdminCommissions.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.lstPolicyTypesRowChangeEventHandler rowDeletingEvent = this.lstPolicyTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminCommissions.lstPolicyTypesRowChangeEvent((dsAdminCommissions.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstPolicyTypesRow(dsAdminCommissions.lstPolicyTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminCommissions adminCommissions = new dsAdminCommissions();
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
        FixedValue = adminCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPolicyTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = adminCommissions.GetSchemaSerializable();
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
  public class tblProducersDataTable : TypedTableBase<dsAdminCommissions.tblProducersRow>
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
    public dsAdminCommissions.tblProducersRow this[int index]
    {
      get => (dsAdminCommissions.tblProducersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblProducersRowChangeEventHandler tblProducersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblProducersRowChangeEventHandler tblProducersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblProducersRowChangeEventHandler tblProducersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminCommissions.tblProducersRowChangeEventHandler tblProducersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblProducersRow(dsAdminCommissions.tblProducersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblProducersRow AddtblProducersRow(
      Guid ProducerGUID,
      string ProducerName)
    {
      dsAdminCommissions.tblProducersRow row = (dsAdminCommissions.tblProducersRow) this.NewRow();
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
    public override DataTable Clone()
    {
      dsAdminCommissions.tblProducersDataTable producersDataTable = (dsAdminCommissions.tblProducersDataTable) base.Clone();
      producersDataTable.InitVars();
      return (DataTable) producersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminCommissions.tblProducersDataTable();
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
      }, false));
      this.columnProducerGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblProducersRow NewtblProducersRow()
    {
      return (dsAdminCommissions.tblProducersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminCommissions.tblProducersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminCommissions.tblProducersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminCommissions.tblProducersRowChangeEventHandler producersRowChangedEvent = this.tblProducersRowChangedEvent;
      if (producersRowChangedEvent == null)
        return;
      producersRowChangedEvent((object) this, new dsAdminCommissions.tblProducersRowChangeEvent((dsAdminCommissions.tblProducersRow) e.Row, e.Action));
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
      dsAdminCommissions.tblProducersRowChangeEventHandler rowChangingEvent = this.tblProducersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminCommissions.tblProducersRowChangeEvent((dsAdminCommissions.tblProducersRow) e.Row, e.Action));
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
      dsAdminCommissions.tblProducersRowChangeEventHandler producersRowDeletedEvent = this.tblProducersRowDeletedEvent;
      if (producersRowDeletedEvent == null)
        return;
      producersRowDeletedEvent((object) this, new dsAdminCommissions.tblProducersRowChangeEvent((dsAdminCommissions.tblProducersRow) e.Row, e.Action));
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
      dsAdminCommissions.tblProducersRowChangeEventHandler rowDeletingEvent = this.tblProducersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminCommissions.tblProducersRowChangeEvent((dsAdminCommissions.tblProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblProducersRow(dsAdminCommissions.tblProducersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminCommissions adminCommissions = new dsAdminCommissions();
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
        FixedValue = adminCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = adminCommissions.GetSchemaSerializable();
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

  public class tblAdminCommissionsRow : DataRow
  {
    private dsAdminCommissions.tblAdminCommissionsDataTable tabletblAdminCommissions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblAdminCommissionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblAdminCommissions = (dsAdminCommissions.tblAdminCommissionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblAdminCommissions.IDColumn]);
      set => this[this.tabletblAdminCommissions.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminCommissions.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid LineGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblAdminCommissions.LineGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LineGuid' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.LineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ProducerLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblAdminCommissions.ProducerLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationGuid' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.ProducerLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblAdminCommissions.CompanyLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLocationGuid' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.CompanyLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid InHouseProducerGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblAdminCommissions.InHouseProducerGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InHouseProducerGuid' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.InHouseProducerGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid OfficeLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblAdminCommissions.OfficeLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfficeLocationGuid' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.OfficeLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid EntityGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblAdminCommissions.EntityGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EntityGuid' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.EntityGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ChargeCode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblAdminCommissions.ChargeCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeCode' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EntityTypeID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminCommissions.EntityTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EntityTypeID' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.EntityTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CommissionTypeID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminCommissions.CommissionTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CommissionTypeID' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.CommissionTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Percentage
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblAdminCommissions.PercentageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Percentage' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.PercentageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal FlatAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblAdminCommissions.FlatAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FlatAmount' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.FlatAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool CommissionsFromOperatingAccount
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblAdminCommissions.CommissionsFromOperatingAccountColumn]);
      }
      set
      {
        this[this.tabletblAdminCommissions.CommissionsFromOperatingAccountColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int AddedByUserID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblAdminCommissions.AddedByUserIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddedByUserID' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.AddedByUserIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool CommissionOnTotalPremium
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblAdminCommissions.CommissionOnTotalPremiumColumn]);
      }
      set => this[this.tabletblAdminCommissions.CommissionOnTotalPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int MinimumFirmIncome
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblAdminCommissions.MinimumFirmIncomeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MinimumFirmIncome' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.MinimumFirmIncomeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int IncomeBetweenStartMonth
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblAdminCommissions.IncomeBetweenStartMonthColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IncomeBetweenStartMonth' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.IncomeBetweenStartMonthColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int IncomeBetweenStartDay
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblAdminCommissions.IncomeBetweenStartDayColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IncomeBetweenStartDay' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.IncomeBetweenStartDayColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int IncomeBetweenEndMonth
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblAdminCommissions.IncomeBetweenEndMonthColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IncomeBetweenEndMonth' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.IncomeBetweenEndMonthColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int IncomeBetweenEndDay
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblAdminCommissions.IncomeBetweenEndDayColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IncomeBetweenEndDay' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.IncomeBetweenEndDayColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int Hierarchy
    {
      get => Conversions.ToInteger(this[this.tabletblAdminCommissions.HierarchyColumn]);
      set => this[this.tabletblAdminCommissions.HierarchyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid UnderwriterGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblAdminCommissions.UnderwriterGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnderwriterGuid' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.UnderwriterGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid IssuingOfficeGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblAdminCommissions.IssuingOfficeGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IssuingOfficeGuid' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.IssuingOfficeGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int PolicyTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblAdminCommissions.PolicyTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyTypeID' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.PolicyTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime Effective
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminCommissions.EffectiveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Effective' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.EffectiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool RenewalOnlyIfPreviouslyCommissioned
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblAdminCommissions.RenewalOnlyIfPreviouslyCommissionedColumn]);
      }
      set
      {
        this[this.tabletblAdminCommissions.RenewalOnlyIfPreviouslyCommissionedColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DisabledDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminCommissions.DisabledDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DisabledDate' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.DisabledDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ProducerGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblAdminCommissions.ProducerGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerGUID' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.ProducerGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal ApplyPremiumEqualOrOver
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblAdminCommissions.ApplyPremiumEqualOrOverColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ApplyPremiumEqualOrOver' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.ApplyPremiumEqualOrOverColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal ApplyPremiumEqualOrLess
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblAdminCommissions.ApplyPremiumEqualOrLessColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ApplyPremiumEqualOrLess' in table 'tblAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminCommissions.ApplyPremiumEqualOrLessColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblProducersRow tblProducersRow
    {
      get
      {
        return (dsAdminCommissions.tblProducersRow) this.GetParentRow(this.Table.ParentRelations["tblProducers_tblAdminCommissions"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblProducers_tblAdminCommissions"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstPolicyTypesRow lstPolicyTypesRow
    {
      get
      {
        return (dsAdminCommissions.lstPolicyTypesRow) this.GetParentRow(this.Table.ParentRelations["lstPolicyTypestblAdminCommissions"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstPolicyTypestblAdminCommissions"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblCompanyLocationsRow tblCompanyLocationsRow
    {
      get
      {
        return (dsAdminCommissions.tblCompanyLocationsRow) this.GetParentRow(this.Table.ParentRelations["tblCompanyLocationstblAdminCommissions"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompanyLocationstblAdminCommissions"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblUsersRow tblUsersRow
    {
      get
      {
        return (dsAdminCommissions.tblUsersRow) this.GetParentRow(this.Table.ParentRelations["tblUserstblAdminCommissions"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblUserstblAdminCommissions"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblProducerLocationsRow tblProducerLocationsRow
    {
      get
      {
        return (dsAdminCommissions.tblProducerLocationsRow) this.GetParentRow(this.Table.ParentRelations["tblProducerLocationstblAdminCommissions"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblProducerLocationstblAdminCommissions"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstLinesRow lstLinesRow
    {
      get
      {
        return (dsAdminCommissions.lstLinesRow) this.GetParentRow(this.Table.ParentRelations["lstLinestblAdminCommissions"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstLinestblAdminCommissions"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstStatesRow lstStatesRow
    {
      get
      {
        return (dsAdminCommissions.lstStatesRow) this.GetParentRow(this.Table.ParentRelations["lstStatestblAdminCommissions"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstStatestblAdminCommissions"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblClientOfficesRow tblClientOfficesRow
    {
      get
      {
        return (dsAdminCommissions.tblClientOfficesRow) this.GetParentRow(this.Table.ParentRelations["tblClientOfficestblAdminCommissions"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblClientOfficestblAdminCommissions"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabletblAdminCommissions.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblAdminCommissions.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLineGuidNull() => this.IsNull(this.tabletblAdminCommissions.LineGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLineGuidNull()
    {
      this[this.tabletblAdminCommissions.LineGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerLocationGuidNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.ProducerLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerLocationGuidNull()
    {
      this[this.tabletblAdminCommissions.ProducerLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyLocationGuidNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.CompanyLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyLocationGuidNull()
    {
      this[this.tabletblAdminCommissions.CompanyLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInHouseProducerGuidNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.InHouseProducerGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInHouseProducerGuidNull()
    {
      this[this.tabletblAdminCommissions.InHouseProducerGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOfficeLocationGuidNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.OfficeLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOfficeLocationGuidNull()
    {
      this[this.tabletblAdminCommissions.OfficeLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEntityGuidNull() => this.IsNull(this.tabletblAdminCommissions.EntityGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEntityGuidNull()
    {
      this[this.tabletblAdminCommissions.EntityGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsChargeCodeNull() => this.IsNull(this.tabletblAdminCommissions.ChargeCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetChargeCodeNull()
    {
      this[this.tabletblAdminCommissions.ChargeCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEntityTypeIDNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.EntityTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEntityTypeIDNull()
    {
      this[this.tabletblAdminCommissions.EntityTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCommissionTypeIDNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.CommissionTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCommissionTypeIDNull()
    {
      this[this.tabletblAdminCommissions.CommissionTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPercentageNull() => this.IsNull(this.tabletblAdminCommissions.PercentageColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPercentageNull()
    {
      this[this.tabletblAdminCommissions.PercentageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFlatAmountNull() => this.IsNull(this.tabletblAdminCommissions.FlatAmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFlatAmountNull()
    {
      this[this.tabletblAdminCommissions.FlatAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddedByUserIDNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.AddedByUserIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddedByUserIDNull()
    {
      this[this.tabletblAdminCommissions.AddedByUserIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMinimumFirmIncomeNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.MinimumFirmIncomeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMinimumFirmIncomeNull()
    {
      this[this.tabletblAdminCommissions.MinimumFirmIncomeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIncomeBetweenStartMonthNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.IncomeBetweenStartMonthColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIncomeBetweenStartMonthNull()
    {
      this[this.tabletblAdminCommissions.IncomeBetweenStartMonthColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIncomeBetweenStartDayNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.IncomeBetweenStartDayColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIncomeBetweenStartDayNull()
    {
      this[this.tabletblAdminCommissions.IncomeBetweenStartDayColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIncomeBetweenEndMonthNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.IncomeBetweenEndMonthColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIncomeBetweenEndMonthNull()
    {
      this[this.tabletblAdminCommissions.IncomeBetweenEndMonthColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIncomeBetweenEndDayNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.IncomeBetweenEndDayColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIncomeBetweenEndDayNull()
    {
      this[this.tabletblAdminCommissions.IncomeBetweenEndDayColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUnderwriterGuidNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.UnderwriterGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUnderwriterGuidNull()
    {
      this[this.tabletblAdminCommissions.UnderwriterGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIssuingOfficeGuidNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.IssuingOfficeGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIssuingOfficeGuidNull()
    {
      this[this.tabletblAdminCommissions.IssuingOfficeGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyTypeIDNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.PolicyTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyTypeIDNull()
    {
      this[this.tabletblAdminCommissions.PolicyTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEffectiveNull() => this.IsNull(this.tabletblAdminCommissions.EffectiveColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEffectiveNull()
    {
      this[this.tabletblAdminCommissions.EffectiveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDisabledDateNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.DisabledDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDisabledDateNull()
    {
      this[this.tabletblAdminCommissions.DisabledDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerGUIDNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.ProducerGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerGUIDNull()
    {
      this[this.tabletblAdminCommissions.ProducerGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsApplyPremiumEqualOrOverNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.ApplyPremiumEqualOrOverColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetApplyPremiumEqualOrOverNull()
    {
      this[this.tabletblAdminCommissions.ApplyPremiumEqualOrOverColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsApplyPremiumEqualOrLessNull()
    {
      return this.IsNull(this.tabletblAdminCommissions.ApplyPremiumEqualOrLessColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetApplyPremiumEqualOrLessNull()
    {
      this[this.tabletblAdminCommissions.ApplyPremiumEqualOrLessColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class viewAdminCommissionsRow : DataRow
  {
    private dsAdminCommissions.viewAdminCommissionsDataTable tableviewAdminCommissions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal viewAdminCommissionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableviewAdminCommissions = (dsAdminCommissions.viewAdminCommissionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Producer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableviewAdminCommissions.ProducerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Producer' in table 'viewAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewAdminCommissions.ProducerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Line
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableviewAdminCommissions.LineColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Line' in table 'viewAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewAdminCommissions.LineColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableviewAdminCommissions.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'viewAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewAdminCommissions.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Company
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableviewAdminCommissions.CompanyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Company' in table 'viewAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewAdminCommissions.CompanyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Entity
    {
      get => Conversions.ToString(this[this.tableviewAdminCommissions.EntityColumn]);
      set => this[this.tableviewAdminCommissions.EntityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EntityType
    {
      get => Conversions.ToString(this[this.tableviewAdminCommissions.EntityTypeColumn]);
      set => this[this.tableviewAdminCommissions.EntityTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CommissionType
    {
      get => Conversions.ToString(this[this.tableviewAdminCommissions.CommissionTypeColumn]);
      set => this[this.tableviewAdminCommissions.CommissionTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Percentage
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableviewAdminCommissions.PercentageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Percentage' in table 'viewAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewAdminCommissions.PercentageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal FlatAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableviewAdminCommissions.FlatAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FlatAmount' in table 'viewAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewAdminCommissions.FlatAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tableviewAdminCommissions.IDColumn]);
      set => this[this.tableviewAdminCommissions.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ChargeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableviewAdminCommissions.ChargeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeName' in table 'viewAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewAdminCommissions.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool CommissionsFromOperatingAccount
    {
      get
      {
        return Conversions.ToBoolean(this[this.tableviewAdminCommissions.CommissionsFromOperatingAccountColumn]);
      }
      set
      {
        this[this.tableviewAdminCommissions.CommissionsFromOperatingAccountColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int Hierarchy
    {
      get => Conversions.ToInteger(this[this.tableviewAdminCommissions.HierarchyColumn]);
      set => this[this.tableviewAdminCommissions.HierarchyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime Effective
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableviewAdminCommissions.EffectiveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Effective' in table 'viewAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewAdminCommissions.EffectiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DisabledDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableviewAdminCommissions.DisabledDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DisabledDate' in table 'viewAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewAdminCommissions.DisabledDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid EntityGuid
    {
      get
      {
        try
        {
          object obj = this[this.tableviewAdminCommissions.EntityGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EntityGuid' in table 'viewAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewAdminCommissions.EntityGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ProducerGUID
    {
      get
      {
        try
        {
          object obj = this[this.tableviewAdminCommissions.ProducerGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerGUID' in table 'viewAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewAdminCommissions.ProducerGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyGUID
    {
      get
      {
        try
        {
          object obj = this[this.tableviewAdminCommissions.CompanyGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyGUID' in table 'viewAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewAdminCommissions.CompanyGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid LineGUID
    {
      get
      {
        try
        {
          object obj = this[this.tableviewAdminCommissions.LineGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LineGUID' in table 'viewAdminCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewAdminCommissions.LineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerNull() => this.IsNull(this.tableviewAdminCommissions.ProducerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerNull()
    {
      this[this.tableviewAdminCommissions.ProducerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLineNull() => this.IsNull(this.tableviewAdminCommissions.LineColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLineNull()
    {
      this[this.tableviewAdminCommissions.LineColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tableviewAdminCommissions.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateNull()
    {
      this[this.tableviewAdminCommissions.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyNull() => this.IsNull(this.tableviewAdminCommissions.CompanyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyNull()
    {
      this[this.tableviewAdminCommissions.CompanyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPercentageNull() => this.IsNull(this.tableviewAdminCommissions.PercentageColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPercentageNull()
    {
      this[this.tableviewAdminCommissions.PercentageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFlatAmountNull() => this.IsNull(this.tableviewAdminCommissions.FlatAmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFlatAmountNull()
    {
      this[this.tableviewAdminCommissions.FlatAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsChargeNameNull() => this.IsNull(this.tableviewAdminCommissions.ChargeNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetChargeNameNull()
    {
      this[this.tableviewAdminCommissions.ChargeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEffectiveNull() => this.IsNull(this.tableviewAdminCommissions.EffectiveColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEffectiveNull()
    {
      this[this.tableviewAdminCommissions.EffectiveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDisabledDateNull()
    {
      return this.IsNull(this.tableviewAdminCommissions.DisabledDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDisabledDateNull()
    {
      this[this.tableviewAdminCommissions.DisabledDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEntityGuidNull() => this.IsNull(this.tableviewAdminCommissions.EntityGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEntityGuidNull()
    {
      this[this.tableviewAdminCommissions.EntityGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerGUIDNull()
    {
      return this.IsNull(this.tableviewAdminCommissions.ProducerGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerGUIDNull()
    {
      this[this.tableviewAdminCommissions.ProducerGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyGUIDNull()
    {
      return this.IsNull(this.tableviewAdminCommissions.CompanyGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyGUIDNull()
    {
      this[this.tableviewAdminCommissions.CompanyGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLineGUIDNull() => this.IsNull(this.tableviewAdminCommissions.LineGUIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLineGUIDNull()
    {
      this[this.tableviewAdminCommissions.LineGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblCompanyLocationsRow : DataRow
  {
    private dsAdminCommissions.tblCompanyLocationsDataTable tabletblCompanyLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLocations = (dsAdminCommissions.tblCompanyLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyLocationGUID
    {
      get
      {
        object obj = this[this.tabletblCompanyLocations.CompanyLocationGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyLocations.CompanyLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabletblCompanyLocations.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabletblCompanyLocations.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblAdminCommissionsRow[] GettblAdminCommissionsRows()
    {
      return this.Table.ChildRelations["tblCompanyLocationstblAdminCommissions"] != null ? (dsAdminCommissions.tblAdminCommissionsRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompanyLocationstblAdminCommissions"]) : new dsAdminCommissions.tblAdminCommissionsRow[0];
    }
  }

  public class tblProducerLocationsRow : DataRow
  {
    private dsAdminCommissions.tblProducerLocationsDataTable tabletblProducerLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducerLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerLocations = (dsAdminCommissions.tblProducerLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Name
    {
      get => Conversions.ToString(this[this.tabletblProducerLocations.NameColumn]);
      set => this[this.tabletblProducerLocations.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblAdminCommissionsRow[] GettblAdminCommissionsRows()
    {
      return this.Table.ChildRelations["tblProducerLocationstblAdminCommissions"] != null ? (dsAdminCommissions.tblAdminCommissionsRow[]) this.GetChildRows(this.Table.ChildRelations["tblProducerLocationstblAdminCommissions"]) : new dsAdminCommissions.tblAdminCommissionsRow[0];
    }
  }

  public class lstStatesRow : DataRow
  {
    private dsAdminCommissions.lstStatesDataTable tablelstStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStates = (dsAdminCommissions.lstStatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tablelstStates.StateIDColumn]);
      set => this[this.tablelstStates.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tablelstStates.StateColumn]);
      set => this[this.tablelstStates.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblAdminCommissionsRow[] GettblAdminCommissionsRows()
    {
      return this.Table.ChildRelations["lstStatestblAdminCommissions"] != null ? (dsAdminCommissions.tblAdminCommissionsRow[]) this.GetChildRows(this.Table.ChildRelations["lstStatestblAdminCommissions"]) : new dsAdminCommissions.tblAdminCommissionsRow[0];
    }
  }

  public class lstLinesRow : DataRow
  {
    private dsAdminCommissions.lstLinesDataTable tablelstLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstLines = (dsAdminCommissions.lstLinesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid LineGUID
    {
      get
      {
        object obj = this[this.tablelstLines.LineGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tablelstLines.LineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LineName
    {
      get => Conversions.ToString(this[this.tablelstLines.LineNameColumn]);
      set => this[this.tablelstLines.LineNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblAdminCommissionsRow[] GettblAdminCommissionsRows()
    {
      return this.Table.ChildRelations["lstLinestblAdminCommissions"] != null ? (dsAdminCommissions.tblAdminCommissionsRow[]) this.GetChildRows(this.Table.ChildRelations["lstLinestblAdminCommissions"]) : new dsAdminCommissions.tblAdminCommissionsRow[0];
    }
  }

  public class tblClientOfficesRow : DataRow
  {
    private dsAdminCommissions.tblClientOfficesDataTable tabletblClientOffices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblClientOfficesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClientOffices = (dsAdminCommissions.tblClientOfficesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid OfficeGUID
    {
      get
      {
        object obj = this[this.tabletblClientOffices.OfficeGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblClientOffices.OfficeGUIDColumn] = (object) value;
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
    public dsAdminCommissions.tblAdminCommissionsRow[] GettblAdminCommissionsRows()
    {
      return this.Table.ChildRelations["tblClientOfficestblAdminCommissions"] != null ? (dsAdminCommissions.tblAdminCommissionsRow[]) this.GetChildRows(this.Table.ChildRelations["tblClientOfficestblAdminCommissions"]) : new dsAdminCommissions.tblAdminCommissionsRow[0];
    }
  }

  public class tblUsersRow : DataRow
  {
    private dsAdminCommissions.tblUsersDataTable tabletblUsers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblUsersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUsers = (dsAdminCommissions.tblUsersDataTable) this.Table;
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
    public string UserName
    {
      get => Conversions.ToString(this[this.tabletblUsers.UserNameColumn]);
      set => this[this.tabletblUsers.UserNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUnderwriter
    {
      get => Conversions.ToBoolean(this[this.tabletblUsers.IsUnderwriterColumn]);
      set => this[this.tabletblUsers.IsUnderwriterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblAdminCommissionsRow[] GettblAdminCommissionsRows()
    {
      return this.Table.ChildRelations["tblUserstblAdminCommissions"] != null ? (dsAdminCommissions.tblAdminCommissionsRow[]) this.GetChildRows(this.Table.ChildRelations["tblUserstblAdminCommissions"]) : new dsAdminCommissions.tblAdminCommissionsRow[0];
    }
  }

  public class lstPolicyTypesRow : DataRow
  {
    private dsAdminCommissions.lstPolicyTypesDataTable tablelstPolicyTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPolicyTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPolicyTypes = (dsAdminCommissions.lstPolicyTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int PolicyTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstPolicyTypes.PolicyTypeIDColumn]);
      set => this[this.tablelstPolicyTypes.PolicyTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstPolicyTypes.DescriptionColumn]);
      set => this[this.tablelstPolicyTypes.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblAdminCommissionsRow[] GettblAdminCommissionsRows()
    {
      return this.Table.ChildRelations["lstPolicyTypestblAdminCommissions"] != null ? (dsAdminCommissions.tblAdminCommissionsRow[]) this.GetChildRows(this.Table.ChildRelations["lstPolicyTypestblAdminCommissions"]) : new dsAdminCommissions.tblAdminCommissionsRow[0];
    }
  }

  public class tblProducersRow : DataRow
  {
    private dsAdminCommissions.tblProducersDataTable tabletblProducers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducers = (dsAdminCommissions.tblProducersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ProducerGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducers.ProducerGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerGUID' in table 'tblProducers' is DBNull.", (Exception) ex);
        }
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
    public bool IsProducerGUIDNull() => this.IsNull(this.tabletblProducers.ProducerGUIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerGUIDNull()
    {
      this[this.tabletblProducers.ProducerGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblAdminCommissionsRow[] GettblAdminCommissionsRows()
    {
      return this.Table.ChildRelations["tblProducers_tblAdminCommissions"] != null ? (dsAdminCommissions.tblAdminCommissionsRow[]) this.GetChildRows(this.Table.ChildRelations["tblProducers_tblAdminCommissions"]) : new dsAdminCommissions.tblAdminCommissionsRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblAdminCommissionsRowChangeEvent : EventArgs
  {
    private dsAdminCommissions.tblAdminCommissionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblAdminCommissionsRowChangeEvent(
      dsAdminCommissions.tblAdminCommissionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblAdminCommissionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class viewAdminCommissionsRowChangeEvent : EventArgs
  {
    private dsAdminCommissions.viewAdminCommissionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public viewAdminCommissionsRowChangeEvent(
      dsAdminCommissions.viewAdminCommissionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.viewAdminCommissionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompanyLocationsRowChangeEvent : EventArgs
  {
    private dsAdminCommissions.tblCompanyLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyLocationsRowChangeEvent(
      dsAdminCommissions.tblCompanyLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblCompanyLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblProducerLocationsRowChangeEvent : EventArgs
  {
    private dsAdminCommissions.tblProducerLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerLocationsRowChangeEvent(
      dsAdminCommissions.tblProducerLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblProducerLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstStatesRowChangeEvent : EventArgs
  {
    private dsAdminCommissions.lstStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstStatesRowChangeEvent(dsAdminCommissions.lstStatesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstLinesRowChangeEvent : EventArgs
  {
    private dsAdminCommissions.lstLinesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstLinesRowChangeEvent(dsAdminCommissions.lstLinesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstLinesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblClientOfficesRowChangeEvent : EventArgs
  {
    private dsAdminCommissions.tblClientOfficesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblClientOfficesRowChangeEvent(
      dsAdminCommissions.tblClientOfficesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblClientOfficesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblUsersRowChangeEvent : EventArgs
  {
    private dsAdminCommissions.tblUsersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblUsersRowChangeEvent(dsAdminCommissions.tblUsersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblUsersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstPolicyTypesRowChangeEvent : EventArgs
  {
    private dsAdminCommissions.lstPolicyTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPolicyTypesRowChangeEvent(
      dsAdminCommissions.lstPolicyTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.lstPolicyTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblProducersRowChangeEvent : EventArgs
  {
    private dsAdminCommissions.tblProducersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducersRowChangeEvent(dsAdminCommissions.tblProducersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminCommissions.tblProducersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
