// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.dsCompanyContacts
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
[XmlRoot("dsCompanyContacts")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyContacts : DataSet
{
  private dsCompanyContacts.tblCompanyContactsDataTable tabletblCompanyContacts;
  private dsCompanyContacts.tblCompanySpecialContactsDataTable tabletblCompanySpecialContacts;
  private dsCompanyContacts.lstCompanySpecialContactTypesDataTable tablelstCompanySpecialContactTypes;
  private dsCompanyContacts.lstDeliveryMethodDataTable tablelstDeliveryMethod;
  private dsCompanyContacts.tblCompaniesDataTable tabletblCompanies;
  private dsCompanyContacts.lstStatusDataTable tablelstStatus;
  private dsCompanyContacts.tblCompanyLocationsDataTable tabletblCompanyLocations;
  private dsCompanyContacts.lstSalutationsDataTable tablelstSalutations;
  private DataRelation relationlstDeliveryMethodtblCompanyContacts;
  private DataRelation relationlstStatustblCompanyContacts;
  private DataRelation relationtblCompanyLocationstblCompanyContacts;
  private DataRelation relationlstSalutationstblCompanyContacts;
  private DataRelation relationtblCompanyContactstblCompanySpecialContacts;
  private DataRelation relationlstCompanySpecialContactTypestblCompanySpecialContacts;
  private DataRelation relationtblCompaniestblCompanyLocations;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsCompanyContacts()
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
  protected dsCompanyContacts(SerializationInfo info, StreamingContext context)
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
          base.Tables.Add((DataTable) new dsCompanyContacts.tblCompanyContactsDataTable(dataSet.Tables[nameof (tblCompanyContacts)]));
        if (dataSet.Tables[nameof (tblCompanySpecialContacts)] != null)
          base.Tables.Add((DataTable) new dsCompanyContacts.tblCompanySpecialContactsDataTable(dataSet.Tables[nameof (tblCompanySpecialContacts)]));
        if (dataSet.Tables[nameof (lstCompanySpecialContactTypes)] != null)
          base.Tables.Add((DataTable) new dsCompanyContacts.lstCompanySpecialContactTypesDataTable(dataSet.Tables[nameof (lstCompanySpecialContactTypes)]));
        if (dataSet.Tables[nameof (lstDeliveryMethod)] != null)
          base.Tables.Add((DataTable) new dsCompanyContacts.lstDeliveryMethodDataTable(dataSet.Tables[nameof (lstDeliveryMethod)]));
        if (dataSet.Tables[nameof (tblCompanies)] != null)
          base.Tables.Add((DataTable) new dsCompanyContacts.tblCompaniesDataTable(dataSet.Tables[nameof (tblCompanies)]));
        if (dataSet.Tables[nameof (lstStatus)] != null)
          base.Tables.Add((DataTable) new dsCompanyContacts.lstStatusDataTable(dataSet.Tables[nameof (lstStatus)]));
        if (dataSet.Tables[nameof (tblCompanyLocations)] != null)
          base.Tables.Add((DataTable) new dsCompanyContacts.tblCompanyLocationsDataTable(dataSet.Tables[nameof (tblCompanyLocations)]));
        if (dataSet.Tables[nameof (lstSalutations)] != null)
          base.Tables.Add((DataTable) new dsCompanyContacts.lstSalutationsDataTable(dataSet.Tables[nameof (lstSalutations)]));
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
  public dsCompanyContacts.tblCompanyContactsDataTable tblCompanyContacts
  {
    get => this.tabletblCompanyContacts;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyContacts.tblCompanySpecialContactsDataTable tblCompanySpecialContacts
  {
    get => this.tabletblCompanySpecialContacts;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyContacts.lstCompanySpecialContactTypesDataTable lstCompanySpecialContactTypes
  {
    get => this.tablelstCompanySpecialContactTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyContacts.lstDeliveryMethodDataTable lstDeliveryMethod
  {
    get => this.tablelstDeliveryMethod;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyContacts.tblCompaniesDataTable tblCompanies => this.tabletblCompanies;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyContacts.lstStatusDataTable lstStatus => this.tablelstStatus;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyContacts.tblCompanyLocationsDataTable tblCompanyLocations
  {
    get => this.tabletblCompanyLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyContacts.lstSalutationsDataTable lstSalutations => this.tablelstSalutations;

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
    dsCompanyContacts dsCompanyContacts = (dsCompanyContacts) base.Clone();
    dsCompanyContacts.InitVars();
    dsCompanyContacts.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsCompanyContacts;
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
      if (dataSet.Tables["tblCompanyContacts"] != null)
        base.Tables.Add((DataTable) new dsCompanyContacts.tblCompanyContactsDataTable(dataSet.Tables["tblCompanyContacts"]));
      if (dataSet.Tables["tblCompanySpecialContacts"] != null)
        base.Tables.Add((DataTable) new dsCompanyContacts.tblCompanySpecialContactsDataTable(dataSet.Tables["tblCompanySpecialContacts"]));
      if (dataSet.Tables["lstCompanySpecialContactTypes"] != null)
        base.Tables.Add((DataTable) new dsCompanyContacts.lstCompanySpecialContactTypesDataTable(dataSet.Tables["lstCompanySpecialContactTypes"]));
      if (dataSet.Tables["lstDeliveryMethod"] != null)
        base.Tables.Add((DataTable) new dsCompanyContacts.lstDeliveryMethodDataTable(dataSet.Tables["lstDeliveryMethod"]));
      if (dataSet.Tables["tblCompanies"] != null)
        base.Tables.Add((DataTable) new dsCompanyContacts.tblCompaniesDataTable(dataSet.Tables["tblCompanies"]));
      if (dataSet.Tables["lstStatus"] != null)
        base.Tables.Add((DataTable) new dsCompanyContacts.lstStatusDataTable(dataSet.Tables["lstStatus"]));
      if (dataSet.Tables["tblCompanyLocations"] != null)
        base.Tables.Add((DataTable) new dsCompanyContacts.tblCompanyLocationsDataTable(dataSet.Tables["tblCompanyLocations"]));
      if (dataSet.Tables["lstSalutations"] != null)
        base.Tables.Add((DataTable) new dsCompanyContacts.lstSalutationsDataTable(dataSet.Tables["lstSalutations"]));
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
    this.tabletblCompanyContacts = (dsCompanyContacts.tblCompanyContactsDataTable) base.Tables["tblCompanyContacts"];
    if (initTable && this.tabletblCompanyContacts != null)
      this.tabletblCompanyContacts.InitVars();
    this.tabletblCompanySpecialContacts = (dsCompanyContacts.tblCompanySpecialContactsDataTable) base.Tables["tblCompanySpecialContacts"];
    if (initTable && this.tabletblCompanySpecialContacts != null)
      this.tabletblCompanySpecialContacts.InitVars();
    this.tablelstCompanySpecialContactTypes = (dsCompanyContacts.lstCompanySpecialContactTypesDataTable) base.Tables["lstCompanySpecialContactTypes"];
    if (initTable && this.tablelstCompanySpecialContactTypes != null)
      this.tablelstCompanySpecialContactTypes.InitVars();
    this.tablelstDeliveryMethod = (dsCompanyContacts.lstDeliveryMethodDataTable) base.Tables["lstDeliveryMethod"];
    if (initTable && this.tablelstDeliveryMethod != null)
      this.tablelstDeliveryMethod.InitVars();
    this.tabletblCompanies = (dsCompanyContacts.tblCompaniesDataTable) base.Tables["tblCompanies"];
    if (initTable && this.tabletblCompanies != null)
      this.tabletblCompanies.InitVars();
    this.tablelstStatus = (dsCompanyContacts.lstStatusDataTable) base.Tables["lstStatus"];
    if (initTable && this.tablelstStatus != null)
      this.tablelstStatus.InitVars();
    this.tabletblCompanyLocations = (dsCompanyContacts.tblCompanyLocationsDataTable) base.Tables["tblCompanyLocations"];
    if (initTable && this.tabletblCompanyLocations != null)
      this.tabletblCompanyLocations.InitVars();
    this.tablelstSalutations = (dsCompanyContacts.lstSalutationsDataTable) base.Tables["lstSalutations"];
    if (initTable && this.tablelstSalutations != null)
      this.tablelstSalutations.InitVars();
    this.relationlstDeliveryMethodtblCompanyContacts = this.Relations["lstDeliveryMethodtblCompanyContacts"];
    this.relationlstStatustblCompanyContacts = this.Relations["lstStatustblCompanyContacts"];
    this.relationtblCompanyLocationstblCompanyContacts = this.Relations["tblCompanyLocationstblCompanyContacts"];
    this.relationlstSalutationstblCompanyContacts = this.Relations["lstSalutationstblCompanyContacts"];
    this.relationtblCompanyContactstblCompanySpecialContacts = this.Relations["tblCompanyContactstblCompanySpecialContacts"];
    this.relationlstCompanySpecialContactTypestblCompanySpecialContacts = this.Relations["lstCompanySpecialContactTypestblCompanySpecialContacts"];
    this.relationtblCompaniestblCompanyLocations = this.Relations["tblCompaniestblCompanyLocations"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyContacts);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsCompanyContacts.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyContacts = new dsCompanyContacts.tblCompanyContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyContacts);
    this.tabletblCompanySpecialContacts = new dsCompanyContacts.tblCompanySpecialContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanySpecialContacts);
    this.tablelstCompanySpecialContactTypes = new dsCompanyContacts.lstCompanySpecialContactTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstCompanySpecialContactTypes);
    this.tablelstDeliveryMethod = new dsCompanyContacts.lstDeliveryMethodDataTable();
    base.Tables.Add((DataTable) this.tablelstDeliveryMethod);
    this.tabletblCompanies = new dsCompanyContacts.tblCompaniesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanies);
    this.tablelstStatus = new dsCompanyContacts.lstStatusDataTable();
    base.Tables.Add((DataTable) this.tablelstStatus);
    this.tabletblCompanyLocations = new dsCompanyContacts.tblCompanyLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLocations);
    this.tablelstSalutations = new dsCompanyContacts.lstSalutationsDataTable();
    base.Tables.Add((DataTable) this.tablelstSalutations);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("lstDeliveryMethodtblCompanyContacts", new DataColumn[1]
    {
      this.tablelstDeliveryMethod.DeliveryMethodIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyContacts.DeliveryMethodIDColumn
    });
    this.tabletblCompanyContacts.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstStatustblCompanyContacts", new DataColumn[1]
    {
      this.tablelstStatus.StatusIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyContacts.StatusIDColumn
    });
    this.tabletblCompanyContacts.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("tblCompanyLocationstblCompanyContacts", new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyLocationGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyContacts.CompanyLocationGuidColumn
    });
    this.tabletblCompanyContacts.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("lstSalutationstblCompanyContacts", new DataColumn[1]
    {
      this.tablelstSalutations.SalutationColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyContacts.SalutationColumn
    });
    this.tabletblCompanyContacts.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint5 = new ForeignKeyConstraint("tblCompanyContactstblCompanySpecialContacts", new DataColumn[1]
    {
      this.tabletblCompanyContacts.CompanyContactGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanySpecialContacts.CompanyContactGuidColumn
    });
    this.tabletblCompanySpecialContacts.Constraints.Add((Constraint) foreignKeyConstraint5);
    foreignKeyConstraint5.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint5.DeleteRule = Rule.Cascade;
    foreignKeyConstraint5.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint6 = new ForeignKeyConstraint("lstCompanySpecialContactTypestblCompanySpecialContacts", new DataColumn[1]
    {
      this.tablelstCompanySpecialContactTypes.SpecialContactTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanySpecialContacts.SpecialContactTypeIDColumn
    });
    this.tabletblCompanySpecialContacts.Constraints.Add((Constraint) foreignKeyConstraint6);
    foreignKeyConstraint6.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint6.DeleteRule = Rule.Cascade;
    foreignKeyConstraint6.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint7 = new ForeignKeyConstraint("tblCompaniestblCompanyLocations", new DataColumn[1]
    {
      this.tabletblCompanies.CompanyGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyGuidColumn
    });
    this.tabletblCompanyLocations.Constraints.Add((Constraint) foreignKeyConstraint7);
    foreignKeyConstraint7.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint7.DeleteRule = Rule.Cascade;
    foreignKeyConstraint7.UpdateRule = Rule.Cascade;
    this.relationlstDeliveryMethodtblCompanyContacts = new DataRelation("lstDeliveryMethodtblCompanyContacts", new DataColumn[1]
    {
      this.tablelstDeliveryMethod.DeliveryMethodIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyContacts.DeliveryMethodIDColumn
    }, false);
    this.Relations.Add(this.relationlstDeliveryMethodtblCompanyContacts);
    this.relationlstStatustblCompanyContacts = new DataRelation("lstStatustblCompanyContacts", new DataColumn[1]
    {
      this.tablelstStatus.StatusIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyContacts.StatusIDColumn
    }, false);
    this.Relations.Add(this.relationlstStatustblCompanyContacts);
    this.relationtblCompanyLocationstblCompanyContacts = new DataRelation("tblCompanyLocationstblCompanyContacts", new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyLocationGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyContacts.CompanyLocationGuidColumn
    }, false);
    this.Relations.Add(this.relationtblCompanyLocationstblCompanyContacts);
    this.relationlstSalutationstblCompanyContacts = new DataRelation("lstSalutationstblCompanyContacts", new DataColumn[1]
    {
      this.tablelstSalutations.SalutationColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyContacts.SalutationColumn
    }, false);
    this.Relations.Add(this.relationlstSalutationstblCompanyContacts);
    this.relationtblCompanyContactstblCompanySpecialContacts = new DataRelation("tblCompanyContactstblCompanySpecialContacts", new DataColumn[1]
    {
      this.tabletblCompanyContacts.CompanyContactGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanySpecialContacts.CompanyContactGuidColumn
    }, false);
    this.Relations.Add(this.relationtblCompanyContactstblCompanySpecialContacts);
    this.relationlstCompanySpecialContactTypestblCompanySpecialContacts = new DataRelation("lstCompanySpecialContactTypestblCompanySpecialContacts", new DataColumn[1]
    {
      this.tablelstCompanySpecialContactTypes.SpecialContactTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanySpecialContacts.SpecialContactTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstCompanySpecialContactTypestblCompanySpecialContacts);
    this.relationtblCompaniestblCompanyLocations = new DataRelation("tblCompaniestblCompanyLocations", new DataColumn[1]
    {
      this.tabletblCompanies.CompanyGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyGuidColumn
    }, false);
    this.Relations.Add(this.relationtblCompaniestblCompanyLocations);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanySpecialContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstCompanySpecialContactTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstDeliveryMethod() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanies() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstStatus() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstSalutations() => false;

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
    dsCompanyContacts dsCompanyContacts = new dsCompanyContacts();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsCompanyContacts.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsCompanyContacts.GetSchemaSerializable();
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
  public delegate void tblCompanyContactsRowChangeEventHandler(
    object sender,
    dsCompanyContacts.tblCompanyContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblCompanySpecialContactsRowChangeEventHandler(
    object sender,
    dsCompanyContacts.tblCompanySpecialContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstCompanySpecialContactTypesRowChangeEventHandler(
    object sender,
    dsCompanyContacts.lstCompanySpecialContactTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstDeliveryMethodRowChangeEventHandler(
    object sender,
    dsCompanyContacts.lstDeliveryMethodRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblCompaniesRowChangeEventHandler(
    object sender,
    dsCompanyContacts.tblCompaniesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstStatusRowChangeEventHandler(
    object sender,
    dsCompanyContacts.lstStatusRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblCompanyLocationsRowChangeEventHandler(
    object sender,
    dsCompanyContacts.tblCompanyLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstSalutationsRowChangeEventHandler(
    object sender,
    dsCompanyContacts.lstSalutationsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyContactsDataTable : TypedTableBase<dsCompanyContacts.tblCompanyContactsRow>
  {
    private DataColumn columnCompanyContactGuid;
    private DataColumn columnCompanyLocationGuid;
    private DataColumn columnSalutation;
    private DataColumn columnFName;
    private DataColumn columnLName;
    private DataColumn columnTitle;
    private DataColumn columnPhone;
    private DataColumn columnExtension;
    private DataColumn columnCell;
    private DataColumn columnEmail;
    private DataColumn columnStatusID;
    private DataColumn columnDeliveryMethodID;
    private DataColumn columnName;
    private DataColumn columnFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyContactsDataTable()
    {
      this.TableName = "tblCompanyContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblCompanyContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyContactGuidColumn => this.columnCompanyContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SalutationColumn => this.columnSalutation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FNameColumn => this.columnFName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LNameColumn => this.columnLName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TitleColumn => this.columnTitle;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PhoneColumn => this.columnPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExtensionColumn => this.columnExtension;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CellColumn => this.columnCell;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeliveryMethodIDColumn => this.columnDeliveryMethodID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FaxColumn => this.columnFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyContactsRow this[int index]
    {
      get => (dsCompanyContacts.tblCompanyContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompanyContactsRowChangeEventHandler tblCompanyContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompanyContactsRowChangeEventHandler tblCompanyContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompanyContactsRowChangeEventHandler tblCompanyContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompanyContactsRowChangeEventHandler tblCompanyContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyContactsRow(dsCompanyContacts.tblCompanyContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyContactsRow AddtblCompanyContactsRow(
      Guid CompanyContactGuid,
      dsCompanyContacts.tblCompanyLocationsRow parenttblCompanyLocationsRowBytblCompanyLocationstblCompanyContacts,
      dsCompanyContacts.lstSalutationsRow parentlstSalutationsRowBylstSalutationstblCompanyContacts,
      string FName,
      string LName,
      string Title,
      string Phone,
      string Extension,
      string Cell,
      string Email,
      dsCompanyContacts.lstStatusRow parentlstStatusRowBylstStatustblCompanyContacts,
      dsCompanyContacts.lstDeliveryMethodRow parentlstDeliveryMethodRowBylstDeliveryMethodtblCompanyContacts,
      string Name,
      string Fax)
    {
      dsCompanyContacts.tblCompanyContactsRow row = (dsCompanyContacts.tblCompanyContactsRow) this.NewRow();
      object[] objArray = new object[14]
      {
        (object) CompanyContactGuid,
        null,
        null,
        (object) FName,
        (object) LName,
        (object) Title,
        (object) Phone,
        (object) Extension,
        (object) Cell,
        (object) Email,
        null,
        null,
        (object) Name,
        (object) Fax
      };
      if (parenttblCompanyLocationsRowBytblCompanyLocationstblCompanyContacts != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblCompanyLocationsRowBytblCompanyLocationstblCompanyContacts[0]);
      if (parentlstSalutationsRowBylstSalutationstblCompanyContacts != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parentlstSalutationsRowBylstSalutationstblCompanyContacts[0]);
      if (parentlstStatusRowBylstStatustblCompanyContacts != null)
        objArray[10] = RuntimeHelpers.GetObjectValue(parentlstStatusRowBylstStatustblCompanyContacts[0]);
      if (parentlstDeliveryMethodRowBylstDeliveryMethodtblCompanyContacts != null)
        objArray[11] = RuntimeHelpers.GetObjectValue(parentlstDeliveryMethodRowBylstDeliveryMethodtblCompanyContacts[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyContactsRow FindByCompanyContactGuid(Guid CompanyContactGuid)
    {
      return (dsCompanyContacts.tblCompanyContactsRow) this.Rows.Find(new object[1]
      {
        (object) CompanyContactGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyContacts.tblCompanyContactsDataTable contactsDataTable = (dsCompanyContacts.tblCompanyContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyContacts.tblCompanyContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyContactGuid = this.Columns["CompanyContactGuid"];
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
      this.columnSalutation = this.Columns["Salutation"];
      this.columnFName = this.Columns["FName"];
      this.columnLName = this.Columns["LName"];
      this.columnTitle = this.Columns["Title"];
      this.columnPhone = this.Columns["Phone"];
      this.columnExtension = this.Columns["Extension"];
      this.columnCell = this.Columns["Cell"];
      this.columnEmail = this.Columns["Email"];
      this.columnStatusID = this.Columns["StatusID"];
      this.columnDeliveryMethodID = this.Columns["DeliveryMethodID"];
      this.columnName = this.Columns["Name"];
      this.columnFax = this.Columns["Fax"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyContactGuid = new DataColumn("CompanyContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyContactGuid);
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.columnSalutation = new DataColumn("Salutation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSalutation);
      this.columnFName = new DataColumn("FName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFName);
      this.columnLName = new DataColumn("LName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLName);
      this.columnTitle = new DataColumn("Title", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTitle);
      this.columnPhone = new DataColumn("Phone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhone);
      this.columnExtension = new DataColumn("Extension", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExtension);
      this.columnCell = new DataColumn("Cell", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCell);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnDeliveryMethodID = new DataColumn("DeliveryMethodID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryMethodID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnFax = new DataColumn("Fax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFax);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyContactsKey2", new DataColumn[1]
      {
        this.columnCompanyContactGuid
      }, true));
      this.columnCompanyContactGuid.AllowDBNull = false;
      this.columnCompanyContactGuid.Unique = true;
      this.columnCompanyLocationGuid.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyContactsRow NewtblCompanyContactsRow()
    {
      return (dsCompanyContacts.tblCompanyContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyContacts.tblCompanyContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyContacts.tblCompanyContactsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompanyContactsRowChangeEventHandler contactsRowChangedEvent = this.tblCompanyContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsCompanyContacts.tblCompanyContactsRowChangeEvent((dsCompanyContacts.tblCompanyContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompanyContactsRowChangeEventHandler rowChangingEvent = this.tblCompanyContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyContacts.tblCompanyContactsRowChangeEvent((dsCompanyContacts.tblCompanyContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompanyContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblCompanyContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsCompanyContacts.tblCompanyContactsRowChangeEvent((dsCompanyContacts.tblCompanyContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompanyContactsRowChangeEventHandler rowDeletingEvent = this.tblCompanyContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyContacts.tblCompanyContactsRowChangeEvent((dsCompanyContacts.tblCompanyContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyContactsRow(dsCompanyContacts.tblCompanyContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyContacts dsCompanyContacts = new dsCompanyContacts();
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
        FixedValue = dsCompanyContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanyContacts.GetSchemaSerializable();
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
  public class tblCompanySpecialContactsDataTable : 
    TypedTableBase<dsCompanyContacts.tblCompanySpecialContactsRow>
  {
    private DataColumn columnCompanyContactGuid;
    private DataColumn columnSpecialContactTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanySpecialContactsDataTable()
    {
      this.TableName = "tblCompanySpecialContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanySpecialContactsDataTable(DataTable table)
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
    protected tblCompanySpecialContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyContactGuidColumn => this.columnCompanyContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SpecialContactTypeIDColumn => this.columnSpecialContactTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanySpecialContactsRow this[int index]
    {
      get => (dsCompanyContacts.tblCompanySpecialContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompanySpecialContactsRowChangeEventHandler tblCompanySpecialContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompanySpecialContactsRowChangeEventHandler tblCompanySpecialContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompanySpecialContactsRowChangeEventHandler tblCompanySpecialContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompanySpecialContactsRowChangeEventHandler tblCompanySpecialContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanySpecialContactsRow(dsCompanyContacts.tblCompanySpecialContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanySpecialContactsRow AddtblCompanySpecialContactsRow(
      dsCompanyContacts.tblCompanyContactsRow parenttblCompanyContactsRowBytblCompanyContactstblCompanySpecialContacts,
      dsCompanyContacts.lstCompanySpecialContactTypesRow parentlstCompanySpecialContactTypesRowBylstCompanySpecialContactTypestblCompanySpecialContacts)
    {
      dsCompanyContacts.tblCompanySpecialContactsRow row = (dsCompanyContacts.tblCompanySpecialContactsRow) this.NewRow();
      object[] objArray = new object[2];
      if (parenttblCompanyContactsRowBytblCompanyContactstblCompanySpecialContacts != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblCompanyContactsRowBytblCompanyContactstblCompanySpecialContacts[0]);
      if (parentlstCompanySpecialContactTypesRowBylstCompanySpecialContactTypestblCompanySpecialContacts != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstCompanySpecialContactTypesRowBylstCompanySpecialContactTypestblCompanySpecialContacts[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanySpecialContactsRow FindByCompanyContactGuidSpecialContactTypeID(
      Guid CompanyContactGuid,
      int SpecialContactTypeID)
    {
      return (dsCompanyContacts.tblCompanySpecialContactsRow) this.Rows.Find(new object[2]
      {
        (object) CompanyContactGuid,
        (object) SpecialContactTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyContacts.tblCompanySpecialContactsDataTable contactsDataTable = (dsCompanyContacts.tblCompanySpecialContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyContacts.tblCompanySpecialContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyContactGuid = this.Columns["CompanyContactGuid"];
      this.columnSpecialContactTypeID = this.Columns["SpecialContactTypeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyContactGuid = new DataColumn("CompanyContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyContactGuid);
      this.columnSpecialContactTypeID = new DataColumn("SpecialContactTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecialContactTypeID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyContactsKey3", new DataColumn[2]
      {
        this.columnCompanyContactGuid,
        this.columnSpecialContactTypeID
      }, true));
      this.columnCompanyContactGuid.AllowDBNull = false;
      this.columnSpecialContactTypeID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanySpecialContactsRow NewtblCompanySpecialContactsRow()
    {
      return (dsCompanyContacts.tblCompanySpecialContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyContacts.tblCompanySpecialContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyContacts.tblCompanySpecialContactsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanySpecialContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompanySpecialContactsRowChangeEventHandler contactsRowChangedEvent = this.tblCompanySpecialContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsCompanyContacts.tblCompanySpecialContactsRowChangeEvent((dsCompanyContacts.tblCompanySpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanySpecialContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompanySpecialContactsRowChangeEventHandler rowChangingEvent = this.tblCompanySpecialContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyContacts.tblCompanySpecialContactsRowChangeEvent((dsCompanyContacts.tblCompanySpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanySpecialContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompanySpecialContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblCompanySpecialContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsCompanyContacts.tblCompanySpecialContactsRowChangeEvent((dsCompanyContacts.tblCompanySpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanySpecialContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompanySpecialContactsRowChangeEventHandler rowDeletingEvent = this.tblCompanySpecialContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyContacts.tblCompanySpecialContactsRowChangeEvent((dsCompanyContacts.tblCompanySpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanySpecialContactsRow(
      dsCompanyContacts.tblCompanySpecialContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyContacts dsCompanyContacts = new dsCompanyContacts();
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
        FixedValue = dsCompanyContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanySpecialContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanyContacts.GetSchemaSerializable();
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
  public class lstCompanySpecialContactTypesDataTable : 
    TypedTableBase<dsCompanyContacts.lstCompanySpecialContactTypesRow>
  {
    private DataColumn columnSpecialContactTypeID;
    private DataColumn columnSpecialContactType;
    private DataColumn columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstCompanySpecialContactTypesDataTable()
    {
      this.TableName = "lstCompanySpecialContactTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstCompanySpecialContactTypesDataTable(DataTable table)
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
    protected lstCompanySpecialContactTypesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SpecialContactTypeIDColumn => this.columnSpecialContactTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SpecialContactTypeColumn => this.columnSpecialContactType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstCompanySpecialContactTypesRow this[int index]
    {
      get => (dsCompanyContacts.lstCompanySpecialContactTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstCompanySpecialContactTypesRowChangeEventHandler lstCompanySpecialContactTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstCompanySpecialContactTypesRowChangeEventHandler lstCompanySpecialContactTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstCompanySpecialContactTypesRowChangeEventHandler lstCompanySpecialContactTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstCompanySpecialContactTypesRowChangeEventHandler lstCompanySpecialContactTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstCompanySpecialContactTypesRow(
      dsCompanyContacts.lstCompanySpecialContactTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstCompanySpecialContactTypesRow AddlstCompanySpecialContactTypesRow(
      string SpecialContactType,
      bool Hidden)
    {
      dsCompanyContacts.lstCompanySpecialContactTypesRow row = (dsCompanyContacts.lstCompanySpecialContactTypesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) SpecialContactType,
        (object) Hidden
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstCompanySpecialContactTypesRow FindBySpecialContactTypeID(
      int SpecialContactTypeID)
    {
      return (dsCompanyContacts.lstCompanySpecialContactTypesRow) this.Rows.Find(new object[1]
      {
        (object) SpecialContactTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyContacts.lstCompanySpecialContactTypesDataTable contactTypesDataTable = (dsCompanyContacts.lstCompanySpecialContactTypesDataTable) base.Clone();
      contactTypesDataTable.InitVars();
      return (DataTable) contactTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyContacts.lstCompanySpecialContactTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnSpecialContactTypeID = this.Columns["SpecialContactTypeID"];
      this.columnSpecialContactType = this.Columns["SpecialContactType"];
      this.columnHidden = this.Columns["Hidden"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnSpecialContactTypeID = new DataColumn("SpecialContactTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecialContactTypeID);
      this.columnSpecialContactType = new DataColumn("SpecialContactType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecialContactType);
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyContactsKey4", new DataColumn[1]
      {
        this.columnSpecialContactTypeID
      }, true));
      this.columnSpecialContactTypeID.AutoIncrement = true;
      this.columnSpecialContactTypeID.AllowDBNull = false;
      this.columnSpecialContactTypeID.ReadOnly = true;
      this.columnSpecialContactTypeID.Unique = true;
      this.columnSpecialContactType.AllowDBNull = false;
      this.columnHidden.AllowDBNull = false;
      this.columnHidden.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstCompanySpecialContactTypesRow NewlstCompanySpecialContactTypesRow()
    {
      return (dsCompanyContacts.lstCompanySpecialContactTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyContacts.lstCompanySpecialContactTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyContacts.lstCompanySpecialContactTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCompanySpecialContactTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstCompanySpecialContactTypesRowChangeEventHandler typesRowChangedEvent = this.lstCompanySpecialContactTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompanyContacts.lstCompanySpecialContactTypesRowChangeEvent((dsCompanyContacts.lstCompanySpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCompanySpecialContactTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstCompanySpecialContactTypesRowChangeEventHandler rowChangingEvent = this.lstCompanySpecialContactTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyContacts.lstCompanySpecialContactTypesRowChangeEvent((dsCompanyContacts.lstCompanySpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCompanySpecialContactTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstCompanySpecialContactTypesRowChangeEventHandler typesRowDeletedEvent = this.lstCompanySpecialContactTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompanyContacts.lstCompanySpecialContactTypesRowChangeEvent((dsCompanyContacts.lstCompanySpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCompanySpecialContactTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstCompanySpecialContactTypesRowChangeEventHandler rowDeletingEvent = this.lstCompanySpecialContactTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyContacts.lstCompanySpecialContactTypesRowChangeEvent((dsCompanyContacts.lstCompanySpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstCompanySpecialContactTypesRow(
      dsCompanyContacts.lstCompanySpecialContactTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyContacts dsCompanyContacts = new dsCompanyContacts();
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
        FixedValue = dsCompanyContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstCompanySpecialContactTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanyContacts.GetSchemaSerializable();
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
  public class lstDeliveryMethodDataTable : TypedTableBase<dsCompanyContacts.lstDeliveryMethodRow>
  {
    private DataColumn columnDeliveryMethodID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstDeliveryMethodDataTable()
    {
      this.TableName = "lstDeliveryMethod";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected lstDeliveryMethodDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeliveryMethodIDColumn => this.columnDeliveryMethodID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstDeliveryMethodRow this[int index]
    {
      get => (dsCompanyContacts.lstDeliveryMethodRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstDeliveryMethodRow(dsCompanyContacts.lstDeliveryMethodRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstDeliveryMethodRow AddlstDeliveryMethodRow(string Description)
    {
      dsCompanyContacts.lstDeliveryMethodRow row = (dsCompanyContacts.lstDeliveryMethodRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstDeliveryMethodRow FindByDeliveryMethodID(int DeliveryMethodID)
    {
      return (dsCompanyContacts.lstDeliveryMethodRow) this.Rows.Find(new object[1]
      {
        (object) DeliveryMethodID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyContacts.lstDeliveryMethodDataTable deliveryMethodDataTable = (dsCompanyContacts.lstDeliveryMethodDataTable) base.Clone();
      deliveryMethodDataTable.InitVars();
      return (DataTable) deliveryMethodDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyContacts.lstDeliveryMethodDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnDeliveryMethodID = this.Columns["DeliveryMethodID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnDeliveryMethodID = new DataColumn("DeliveryMethodID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryMethodID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyContactsKey5", new DataColumn[1]
      {
        this.columnDeliveryMethodID
      }, true));
      this.columnDeliveryMethodID.AutoIncrement = true;
      this.columnDeliveryMethodID.AllowDBNull = false;
      this.columnDeliveryMethodID.ReadOnly = true;
      this.columnDeliveryMethodID.Unique = true;
      this.columnDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstDeliveryMethodRow NewlstDeliveryMethodRow()
    {
      return (dsCompanyContacts.lstDeliveryMethodRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyContacts.lstDeliveryMethodRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyContacts.lstDeliveryMethodRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstDeliveryMethodRowChangeEventHandler methodRowChangedEvent = this.lstDeliveryMethodRowChangedEvent;
      if (methodRowChangedEvent == null)
        return;
      methodRowChangedEvent((object) this, new dsCompanyContacts.lstDeliveryMethodRowChangeEvent((dsCompanyContacts.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstDeliveryMethodRowChangeEventHandler rowChangingEvent = this.lstDeliveryMethodRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyContacts.lstDeliveryMethodRowChangeEvent((dsCompanyContacts.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstDeliveryMethodRowChangeEventHandler methodRowDeletedEvent = this.lstDeliveryMethodRowDeletedEvent;
      if (methodRowDeletedEvent == null)
        return;
      methodRowDeletedEvent((object) this, new dsCompanyContacts.lstDeliveryMethodRowChangeEvent((dsCompanyContacts.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstDeliveryMethodRowChangeEventHandler rowDeletingEvent = this.lstDeliveryMethodRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyContacts.lstDeliveryMethodRowChangeEvent((dsCompanyContacts.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstDeliveryMethodRow(dsCompanyContacts.lstDeliveryMethodRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyContacts dsCompanyContacts = new dsCompanyContacts();
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
        FixedValue = dsCompanyContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstDeliveryMethodDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanyContacts.GetSchemaSerializable();
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
  public class tblCompaniesDataTable : TypedTableBase<dsCompanyContacts.tblCompaniesRow>
  {
    private DataColumn columnCompanyGuid;
    private DataColumn columnCompanyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompaniesDataTable()
    {
      this.TableName = "tblCompanies";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblCompaniesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyGuidColumn => this.columnCompanyGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyNameColumn => this.columnCompanyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompaniesRow this[int index]
    {
      get => (dsCompanyContacts.tblCompaniesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompaniesRowChangeEventHandler tblCompaniesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompaniesRowChangeEventHandler tblCompaniesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompaniesRowChangeEventHandler tblCompaniesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompaniesRowChangeEventHandler tblCompaniesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompaniesRow(dsCompanyContacts.tblCompaniesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompaniesRow AddtblCompaniesRow(
      Guid CompanyGuid,
      string CompanyName)
    {
      dsCompanyContacts.tblCompaniesRow row = (dsCompanyContacts.tblCompaniesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyGuid,
        (object) CompanyName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompaniesRow FindByCompanyGuid(Guid CompanyGuid)
    {
      return (dsCompanyContacts.tblCompaniesRow) this.Rows.Find(new object[1]
      {
        (object) CompanyGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyContacts.tblCompaniesDataTable companiesDataTable = (dsCompanyContacts.tblCompaniesDataTable) base.Clone();
      companiesDataTable.InitVars();
      return (DataTable) companiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyContacts.tblCompaniesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyGuid = this.Columns["CompanyGuid"];
      this.columnCompanyName = this.Columns["CompanyName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyGuid = new DataColumn("CompanyGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGuid);
      this.columnCompanyName = new DataColumn("CompanyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyContactsKey6", new DataColumn[1]
      {
        this.columnCompanyGuid
      }, true));
      this.columnCompanyGuid.AllowDBNull = false;
      this.columnCompanyGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompaniesRow NewtblCompaniesRow()
    {
      return (dsCompanyContacts.tblCompaniesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyContacts.tblCompaniesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyContacts.tblCompaniesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompaniesRowChangeEventHandler companiesRowChangedEvent = this.tblCompaniesRowChangedEvent;
      if (companiesRowChangedEvent == null)
        return;
      companiesRowChangedEvent((object) this, new dsCompanyContacts.tblCompaniesRowChangeEvent((dsCompanyContacts.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompaniesRowChangeEventHandler rowChangingEvent = this.tblCompaniesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyContacts.tblCompaniesRowChangeEvent((dsCompanyContacts.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompaniesRowChangeEventHandler companiesRowDeletedEvent = this.tblCompaniesRowDeletedEvent;
      if (companiesRowDeletedEvent == null)
        return;
      companiesRowDeletedEvent((object) this, new dsCompanyContacts.tblCompaniesRowChangeEvent((dsCompanyContacts.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompaniesRowChangeEventHandler rowDeletingEvent = this.tblCompaniesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyContacts.tblCompaniesRowChangeEvent((dsCompanyContacts.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompaniesRow(dsCompanyContacts.tblCompaniesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyContacts dsCompanyContacts = new dsCompanyContacts();
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
        FixedValue = dsCompanyContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompaniesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanyContacts.GetSchemaSerializable();
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
  public class lstStatusDataTable : TypedTableBase<dsCompanyContacts.lstStatusRow>
  {
    private DataColumn columnStatusID;
    private DataColumn columnStatusCode;
    private DataColumn columnStatus;
    private DataColumn columnDisable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstStatusDataTable()
    {
      this.TableName = "lstStatus";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected lstStatusDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StatusCodeColumn => this.columnStatusCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DisableColumn => this.columnDisable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstStatusRow this[int index]
    {
      get => (dsCompanyContacts.lstStatusRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstStatusRowChangeEventHandler lstStatusRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstStatusRowChangeEventHandler lstStatusRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstStatusRowChangeEventHandler lstStatusRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstStatusRowChangeEventHandler lstStatusRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstStatusRow(dsCompanyContacts.lstStatusRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstStatusRow AddlstStatusRow(
      int StatusID,
      string StatusCode,
      string Status,
      bool Disable)
    {
      dsCompanyContacts.lstStatusRow row = (dsCompanyContacts.lstStatusRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstStatusRow FindByStatusID(int StatusID)
    {
      return (dsCompanyContacts.lstStatusRow) this.Rows.Find(new object[1]
      {
        (object) StatusID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyContacts.lstStatusDataTable lstStatusDataTable = (dsCompanyContacts.lstStatusDataTable) base.Clone();
      lstStatusDataTable.InitVars();
      return (DataTable) lstStatusDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyContacts.lstStatusDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnStatusID = this.Columns["StatusID"];
      this.columnStatusCode = this.Columns["StatusCode"];
      this.columnStatus = this.Columns["Status"];
      this.columnDisable = this.Columns["Disable"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyContactsKey7", new DataColumn[1]
      {
        this.columnStatusID
      }, true));
      this.columnStatusID.AllowDBNull = false;
      this.columnStatusID.Unique = true;
      this.columnDisable.AllowDBNull = false;
      this.columnDisable.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstStatusRow NewlstStatusRow()
    {
      return (dsCompanyContacts.lstStatusRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyContacts.lstStatusRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyContacts.lstStatusRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstStatusRowChangeEventHandler statusRowChangedEvent = this.lstStatusRowChangedEvent;
      if (statusRowChangedEvent == null)
        return;
      statusRowChangedEvent((object) this, new dsCompanyContacts.lstStatusRowChangeEvent((dsCompanyContacts.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstStatusRowChangeEventHandler rowChangingEvent = this.lstStatusRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyContacts.lstStatusRowChangeEvent((dsCompanyContacts.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstStatusRowChangeEventHandler statusRowDeletedEvent = this.lstStatusRowDeletedEvent;
      if (statusRowDeletedEvent == null)
        return;
      statusRowDeletedEvent((object) this, new dsCompanyContacts.lstStatusRowChangeEvent((dsCompanyContacts.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstStatusRowChangeEventHandler rowDeletingEvent = this.lstStatusRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyContacts.lstStatusRowChangeEvent((dsCompanyContacts.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstStatusRow(dsCompanyContacts.lstStatusRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyContacts dsCompanyContacts = new dsCompanyContacts();
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
        FixedValue = dsCompanyContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatusDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanyContacts.GetSchemaSerializable();
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
    TypedTableBase<dsCompanyContacts.tblCompanyLocationsRow>
  {
    private DataColumn columnCompanyLocationGuid;
    private DataColumn columnCompanyGuid;
    private DataColumn columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLocationsDataTable()
    {
      this.TableName = "tblCompanyLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblCompanyLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyGuidColumn => this.columnCompanyGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyLocationsRow this[int index]
    {
      get => (dsCompanyContacts.tblCompanyLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyLocationsRow(dsCompanyContacts.tblCompanyLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyLocationsRow AddtblCompanyLocationsRow(
      Guid CompanyLocationGuid,
      dsCompanyContacts.tblCompaniesRow parenttblCompaniesRowBytblCompaniestblCompanyLocations,
      string Name)
    {
      dsCompanyContacts.tblCompanyLocationsRow row = (dsCompanyContacts.tblCompanyLocationsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) CompanyLocationGuid,
        null,
        (object) Name
      };
      if (parenttblCompaniesRowBytblCompaniestblCompanyLocations != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblCompaniesRowBytblCompaniestblCompanyLocations[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyLocationsRow FindByCompanyLocationGuid(
      Guid CompanyLocationGuid)
    {
      return (dsCompanyContacts.tblCompanyLocationsRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLocationGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyContacts.tblCompanyLocationsDataTable locationsDataTable = (dsCompanyContacts.tblCompanyLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyContacts.tblCompanyLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
      this.columnCompanyGuid = this.Columns["CompanyGuid"];
      this.columnName = this.Columns["Name"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.columnCompanyGuid = new DataColumn("CompanyGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGuid);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyContactsKey1", new DataColumn[1]
      {
        this.columnCompanyLocationGuid
      }, true));
      this.columnCompanyLocationGuid.AllowDBNull = false;
      this.columnCompanyLocationGuid.Unique = true;
      this.columnCompanyGuid.AllowDBNull = false;
      this.columnName.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyLocationsRow NewtblCompanyLocationsRow()
    {
      return (dsCompanyContacts.tblCompanyLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyContacts.tblCompanyLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyContacts.tblCompanyLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompanyLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblCompanyLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsCompanyContacts.tblCompanyLocationsRowChangeEvent((dsCompanyContacts.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompanyLocationsRowChangeEventHandler rowChangingEvent = this.tblCompanyLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyContacts.tblCompanyLocationsRowChangeEvent((dsCompanyContacts.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompanyLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblCompanyLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsCompanyContacts.tblCompanyLocationsRowChangeEvent((dsCompanyContacts.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.tblCompanyLocationsRowChangeEventHandler rowDeletingEvent = this.tblCompanyLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyContacts.tblCompanyLocationsRowChangeEvent((dsCompanyContacts.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyLocationsRow(dsCompanyContacts.tblCompanyLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyContacts dsCompanyContacts = new dsCompanyContacts();
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
        FixedValue = dsCompanyContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanyContacts.GetSchemaSerializable();
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
  public class lstSalutationsDataTable : TypedTableBase<dsCompanyContacts.lstSalutationsRow>
  {
    private DataColumn columnSalutation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstSalutationsDataTable()
    {
      this.TableName = "lstSalutations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected lstSalutationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SalutationColumn => this.columnSalutation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstSalutationsRow this[int index]
    {
      get => (dsCompanyContacts.lstSalutationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstSalutationsRowChangeEventHandler lstSalutationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstSalutationsRowChangeEventHandler lstSalutationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstSalutationsRowChangeEventHandler lstSalutationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContacts.lstSalutationsRowChangeEventHandler lstSalutationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstSalutationsRow(dsCompanyContacts.lstSalutationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstSalutationsRow AddlstSalutationsRow(string Salutation)
    {
      dsCompanyContacts.lstSalutationsRow row = (dsCompanyContacts.lstSalutationsRow) this.NewRow();
      object[] objArray = new object[1]
      {
        (object) Salutation
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstSalutationsRow FindBySalutation(string Salutation)
    {
      return (dsCompanyContacts.lstSalutationsRow) this.Rows.Find(new object[1]
      {
        (object) Salutation
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyContacts.lstSalutationsDataTable salutationsDataTable = (dsCompanyContacts.lstSalutationsDataTable) base.Clone();
      salutationsDataTable.InitVars();
      return (DataTable) salutationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyContacts.lstSalutationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars() => this.columnSalutation = this.Columns["Salutation"];

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnSalutation = new DataColumn("Salutation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSalutation);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyContactsKey8", new DataColumn[1]
      {
        this.columnSalutation
      }, true));
      this.columnSalutation.AllowDBNull = false;
      this.columnSalutation.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstSalutationsRow NewlstSalutationsRow()
    {
      return (dsCompanyContacts.lstSalutationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyContacts.lstSalutationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyContacts.lstSalutationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstSalutationsRowChangeEventHandler salutationsRowChangedEvent = this.lstSalutationsRowChangedEvent;
      if (salutationsRowChangedEvent == null)
        return;
      salutationsRowChangedEvent((object) this, new dsCompanyContacts.lstSalutationsRowChangeEvent((dsCompanyContacts.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstSalutationsRowChangeEventHandler rowChangingEvent = this.lstSalutationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyContacts.lstSalutationsRowChangeEvent((dsCompanyContacts.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstSalutationsRowChangeEventHandler salutationsRowDeletedEvent = this.lstSalutationsRowDeletedEvent;
      if (salutationsRowDeletedEvent == null)
        return;
      salutationsRowDeletedEvent((object) this, new dsCompanyContacts.lstSalutationsRowChangeEvent((dsCompanyContacts.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyContacts.lstSalutationsRowChangeEventHandler rowDeletingEvent = this.lstSalutationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyContacts.lstSalutationsRowChangeEvent((dsCompanyContacts.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstSalutationsRow(dsCompanyContacts.lstSalutationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyContacts dsCompanyContacts = new dsCompanyContacts();
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
        FixedValue = dsCompanyContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstSalutationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanyContacts.GetSchemaSerializable();
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
    private dsCompanyContacts.tblCompanyContactsDataTable tabletblCompanyContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyContacts = (dsCompanyContacts.tblCompanyContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Salutation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyContacts.SalutationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Salutation' in table 'tblCompanyContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyContacts.SalutationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyContacts.FNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FName' in table 'tblCompanyContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyContacts.FNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyContacts.LNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LName' in table 'tblCompanyContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyContacts.LNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Title
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyContacts.TitleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Title' in table 'tblCompanyContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyContacts.TitleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Phone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyContacts.PhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Phone' in table 'tblCompanyContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyContacts.PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Extension
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyContacts.ExtensionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Extension' in table 'tblCompanyContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyContacts.ExtensionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Cell
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyContacts.CellColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Cell' in table 'tblCompanyContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyContacts.CellColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyContacts.EmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Email' in table 'tblCompanyContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyContacts.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int StatusID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyContacts.StatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusID' in table 'tblCompanyContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyContacts.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int DeliveryMethodID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyContacts.DeliveryMethodIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeliveryMethodID' in table 'tblCompanyContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyContacts.DeliveryMethodIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Fax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyContacts.FaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fax' in table 'tblCompanyContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyContacts.FaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstDeliveryMethodRow lstDeliveryMethodRow
    {
      get
      {
        return (dsCompanyContacts.lstDeliveryMethodRow) this.GetParentRow(this.Table.ParentRelations["lstDeliveryMethodtblCompanyContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstDeliveryMethodtblCompanyContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstStatusRow lstStatusRow
    {
      get
      {
        return (dsCompanyContacts.lstStatusRow) this.GetParentRow(this.Table.ParentRelations["lstStatustblCompanyContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstStatustblCompanyContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyLocationsRow tblCompanyLocationsRow
    {
      get
      {
        return (dsCompanyContacts.tblCompanyLocationsRow) this.GetParentRow(this.Table.ParentRelations["tblCompanyLocationstblCompanyContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompanyLocationstblCompanyContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstSalutationsRow lstSalutationsRow
    {
      get
      {
        return (dsCompanyContacts.lstSalutationsRow) this.GetParentRow(this.Table.ParentRelations["lstSalutationstblCompanyContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstSalutationstblCompanyContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSalutationNull() => this.IsNull(this.tabletblCompanyContacts.SalutationColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSalutationNull()
    {
      this[this.tabletblCompanyContacts.SalutationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFNameNull() => this.IsNull(this.tabletblCompanyContacts.FNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFNameNull()
    {
      this[this.tabletblCompanyContacts.FNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLNameNull() => this.IsNull(this.tabletblCompanyContacts.LNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLNameNull()
    {
      this[this.tabletblCompanyContacts.LNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTitleNull() => this.IsNull(this.tabletblCompanyContacts.TitleColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTitleNull()
    {
      this[this.tabletblCompanyContacts.TitleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPhoneNull() => this.IsNull(this.tabletblCompanyContacts.PhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPhoneNull()
    {
      this[this.tabletblCompanyContacts.PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExtensionNull() => this.IsNull(this.tabletblCompanyContacts.ExtensionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExtensionNull()
    {
      this[this.tabletblCompanyContacts.ExtensionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCellNull() => this.IsNull(this.tabletblCompanyContacts.CellColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCellNull()
    {
      this[this.tabletblCompanyContacts.CellColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tabletblCompanyContacts.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEmailNull()
    {
      this[this.tabletblCompanyContacts.EmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStatusIDNull() => this.IsNull(this.tabletblCompanyContacts.StatusIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStatusIDNull()
    {
      this[this.tabletblCompanyContacts.StatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDeliveryMethodIDNull()
    {
      return this.IsNull(this.tabletblCompanyContacts.DeliveryMethodIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDeliveryMethodIDNull()
    {
      this[this.tabletblCompanyContacts.DeliveryMethodIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabletblCompanyContacts.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabletblCompanyContacts.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFaxNull() => this.IsNull(this.tabletblCompanyContacts.FaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFaxNull()
    {
      this[this.tabletblCompanyContacts.FaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanySpecialContactsRow[] GettblCompanySpecialContactsRows()
    {
      return this.Table.ChildRelations["tblCompanyContactstblCompanySpecialContacts"] != null ? (dsCompanyContacts.tblCompanySpecialContactsRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompanyContactstblCompanySpecialContacts"]) : new dsCompanyContacts.tblCompanySpecialContactsRow[0];
    }
  }

  public class tblCompanySpecialContactsRow : DataRow
  {
    private dsCompanyContacts.tblCompanySpecialContactsDataTable tabletblCompanySpecialContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanySpecialContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanySpecialContacts = (dsCompanyContacts.tblCompanySpecialContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyContactGuid
    {
      get
      {
        object obj = this[this.tabletblCompanySpecialContacts.CompanyContactGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanySpecialContacts.CompanyContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int SpecialContactTypeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanySpecialContacts.SpecialContactTypeIDColumn]);
      }
      set => this[this.tabletblCompanySpecialContacts.SpecialContactTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyContactsRow tblCompanyContactsRow
    {
      get
      {
        return (dsCompanyContacts.tblCompanyContactsRow) this.GetParentRow(this.Table.ParentRelations["tblCompanyContactstblCompanySpecialContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompanyContactstblCompanySpecialContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstCompanySpecialContactTypesRow lstCompanySpecialContactTypesRow
    {
      get
      {
        return (dsCompanyContacts.lstCompanySpecialContactTypesRow) this.GetParentRow(this.Table.ParentRelations["lstCompanySpecialContactTypestblCompanySpecialContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstCompanySpecialContactTypestblCompanySpecialContacts"]);
      }
    }
  }

  public class lstCompanySpecialContactTypesRow : DataRow
  {
    private dsCompanyContacts.lstCompanySpecialContactTypesDataTable tablelstCompanySpecialContactTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstCompanySpecialContactTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstCompanySpecialContactTypes = (dsCompanyContacts.lstCompanySpecialContactTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int SpecialContactTypeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tablelstCompanySpecialContactTypes.SpecialContactTypeIDColumn]);
      }
      set
      {
        this[this.tablelstCompanySpecialContactTypes.SpecialContactTypeIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SpecialContactType
    {
      get
      {
        return Conversions.ToString(this[this.tablelstCompanySpecialContactTypes.SpecialContactTypeColumn]);
      }
      set
      {
        this[this.tablelstCompanySpecialContactTypes.SpecialContactTypeColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Hidden
    {
      get => Conversions.ToBoolean(this[this.tablelstCompanySpecialContactTypes.HiddenColumn]);
      set => this[this.tablelstCompanySpecialContactTypes.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanySpecialContactsRow[] GettblCompanySpecialContactsRows()
    {
      return this.Table.ChildRelations["lstCompanySpecialContactTypestblCompanySpecialContacts"] != null ? (dsCompanyContacts.tblCompanySpecialContactsRow[]) this.GetChildRows(this.Table.ChildRelations["lstCompanySpecialContactTypestblCompanySpecialContacts"]) : new dsCompanyContacts.tblCompanySpecialContactsRow[0];
    }
  }

  public class lstDeliveryMethodRow : DataRow
  {
    private dsCompanyContacts.lstDeliveryMethodDataTable tablelstDeliveryMethod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstDeliveryMethodRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstDeliveryMethod = (dsCompanyContacts.lstDeliveryMethodDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int DeliveryMethodID
    {
      get => Conversions.ToInteger(this[this.tablelstDeliveryMethod.DeliveryMethodIDColumn]);
      set => this[this.tablelstDeliveryMethod.DeliveryMethodIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstDeliveryMethod.DescriptionColumn]);
      set => this[this.tablelstDeliveryMethod.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyContactsRow[] GettblCompanyContactsRows()
    {
      return this.Table.ChildRelations["lstDeliveryMethodtblCompanyContacts"] != null ? (dsCompanyContacts.tblCompanyContactsRow[]) this.GetChildRows(this.Table.ChildRelations["lstDeliveryMethodtblCompanyContacts"]) : new dsCompanyContacts.tblCompanyContactsRow[0];
    }
  }

  public class tblCompaniesRow : DataRow
  {
    private dsCompanyContacts.tblCompaniesDataTable tabletblCompanies;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompaniesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanies = (dsCompanyContacts.tblCompaniesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompanyNameNull() => this.IsNull(this.tabletblCompanies.CompanyNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompanyNameNull()
    {
      this[this.tabletblCompanies.CompanyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyLocationsRow[] GettblCompanyLocationsRows()
    {
      return this.Table.ChildRelations["tblCompaniestblCompanyLocations"] != null ? (dsCompanyContacts.tblCompanyLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompaniestblCompanyLocations"]) : new dsCompanyContacts.tblCompanyLocationsRow[0];
    }
  }

  public class lstStatusRow : DataRow
  {
    private dsCompanyContacts.lstStatusDataTable tablelstStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstStatusRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStatus = (dsCompanyContacts.lstStatusDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int StatusID
    {
      get => Conversions.ToInteger(this[this.tablelstStatus.StatusIDColumn]);
      set => this[this.tablelstStatus.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Disable
    {
      get => Conversions.ToBoolean(this[this.tablelstStatus.DisableColumn]);
      set => this[this.tablelstStatus.DisableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStatusCodeNull() => this.IsNull(this.tablelstStatus.StatusCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStatusCodeNull()
    {
      this[this.tablelstStatus.StatusCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStatusNull() => this.IsNull(this.tablelstStatus.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStatusNull()
    {
      this[this.tablelstStatus.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyContactsRow[] GettblCompanyContactsRows()
    {
      return this.Table.ChildRelations["lstStatustblCompanyContacts"] != null ? (dsCompanyContacts.tblCompanyContactsRow[]) this.GetChildRows(this.Table.ChildRelations["lstStatustblCompanyContacts"]) : new dsCompanyContacts.tblCompanyContactsRow[0];
    }
  }

  public class tblCompanyLocationsRow : DataRow
  {
    private dsCompanyContacts.tblCompanyLocationsDataTable tabletblCompanyLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLocations = (dsCompanyContacts.tblCompanyLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompaniesRow tblCompaniesRow
    {
      get
      {
        return (dsCompanyContacts.tblCompaniesRow) this.GetParentRow(this.Table.ParentRelations["tblCompaniestblCompanyLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompaniestblCompanyLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabletblCompanyLocations.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabletblCompanyLocations.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyContactsRow[] GettblCompanyContactsRows()
    {
      return this.Table.ChildRelations["tblCompanyLocationstblCompanyContacts"] != null ? (dsCompanyContacts.tblCompanyContactsRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompanyLocationstblCompanyContacts"]) : new dsCompanyContacts.tblCompanyContactsRow[0];
    }
  }

  public class lstSalutationsRow : DataRow
  {
    private dsCompanyContacts.lstSalutationsDataTable tablelstSalutations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstSalutationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstSalutations = (dsCompanyContacts.lstSalutationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Salutation
    {
      get => Conversions.ToString(this[this.tablelstSalutations.SalutationColumn]);
      set => this[this.tablelstSalutations.SalutationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyContactsRow[] GettblCompanyContactsRows()
    {
      return this.Table.ChildRelations["lstSalutationstblCompanyContacts"] != null ? (dsCompanyContacts.tblCompanyContactsRow[]) this.GetChildRows(this.Table.ChildRelations["lstSalutationstblCompanyContacts"]) : new dsCompanyContacts.tblCompanyContactsRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyContactsRowChangeEvent : EventArgs
  {
    private dsCompanyContacts.tblCompanyContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyContactsRowChangeEvent(
      dsCompanyContacts.tblCompanyContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanySpecialContactsRowChangeEvent : EventArgs
  {
    private dsCompanyContacts.tblCompanySpecialContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanySpecialContactsRowChangeEvent(
      dsCompanyContacts.tblCompanySpecialContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanySpecialContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstCompanySpecialContactTypesRowChangeEvent : EventArgs
  {
    private dsCompanyContacts.lstCompanySpecialContactTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstCompanySpecialContactTypesRowChangeEvent(
      dsCompanyContacts.lstCompanySpecialContactTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstCompanySpecialContactTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstDeliveryMethodRowChangeEvent : EventArgs
  {
    private dsCompanyContacts.lstDeliveryMethodRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstDeliveryMethodRowChangeEvent(
      dsCompanyContacts.lstDeliveryMethodRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstDeliveryMethodRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompaniesRowChangeEvent : EventArgs
  {
    private dsCompanyContacts.tblCompaniesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompaniesRowChangeEvent(dsCompanyContacts.tblCompaniesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompaniesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstStatusRowChangeEvent : EventArgs
  {
    private dsCompanyContacts.lstStatusRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstStatusRowChangeEvent(dsCompanyContacts.lstStatusRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstStatusRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyLocationsRowChangeEvent : EventArgs
  {
    private dsCompanyContacts.tblCompanyLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLocationsRowChangeEvent(
      dsCompanyContacts.tblCompanyLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.tblCompanyLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstSalutationsRowChangeEvent : EventArgs
  {
    private dsCompanyContacts.lstSalutationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstSalutationsRowChangeEvent(
      dsCompanyContacts.lstSalutationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContacts.lstSalutationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
