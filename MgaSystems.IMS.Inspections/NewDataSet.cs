// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.NewDataSet
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("NewDataSet")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class NewDataSet : DataSet
{
  private NewDataSet.ImportInspectionsRequestDataTable tableImportInspectionsRequest;
  private NewDataSet.InspectionsDataTable tableInspections;
  private NewDataSet.InspectionDataTable tableInspection;
  private NewDataSet.AgentDataTable tableAgent;
  private NewDataSet.AddressDataTable tableAddress;
  private NewDataSet.AttributesDataTable tableAttributes;
  private NewDataSet.LocationDataTable tableLocation;
  private NewDataSet.MailingDataTable tableMailing;
  private NewDataSet.PolicyHolderDataTable tablePolicyHolder;
  private NewDataSet.UnderwriterDataTable tableUnderwriter;
  private NewDataSet.CredentialsDataTable tableCredentials;
  private NewDataSet.ArrayOfInspectionDataTable tableArrayOfInspection;
  private DataRelation relationImportInspectionsRequest_Inspections;
  private DataRelation relationInspections_Inspection;
  private DataRelation relationArrayOfInspection_Inspection;
  private DataRelation relationInspection_Agent;
  private DataRelation relationAgent_Address;
  private DataRelation relationInspection_Attributes;
  private DataRelation relationInspection_Location;
  private DataRelation relationInspection_Mailing;
  private DataRelation relationInspection_PolicyHolder;
  private DataRelation relationInspection_Underwriter;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public NewDataSet()
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
  protected NewDataSet(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (ImportInspectionsRequest)] != null)
          base.Tables.Add((DataTable) new NewDataSet.ImportInspectionsRequestDataTable(dataSet.Tables[nameof (ImportInspectionsRequest)]));
        if (dataSet.Tables[nameof (Inspections)] != null)
          base.Tables.Add((DataTable) new NewDataSet.InspectionsDataTable(dataSet.Tables[nameof (Inspections)]));
        if (dataSet.Tables[nameof (Inspection)] != null)
          base.Tables.Add((DataTable) new NewDataSet.InspectionDataTable(dataSet.Tables[nameof (Inspection)]));
        if (dataSet.Tables[nameof (Agent)] != null)
          base.Tables.Add((DataTable) new NewDataSet.AgentDataTable(dataSet.Tables[nameof (Agent)]));
        if (dataSet.Tables[nameof (Address)] != null)
          base.Tables.Add((DataTable) new NewDataSet.AddressDataTable(dataSet.Tables[nameof (Address)]));
        if (dataSet.Tables[nameof (Attributes)] != null)
          base.Tables.Add((DataTable) new NewDataSet.AttributesDataTable(dataSet.Tables[nameof (Attributes)]));
        if (dataSet.Tables[nameof (Location)] != null)
          base.Tables.Add((DataTable) new NewDataSet.LocationDataTable(dataSet.Tables[nameof (Location)]));
        if (dataSet.Tables[nameof (Mailing)] != null)
          base.Tables.Add((DataTable) new NewDataSet.MailingDataTable(dataSet.Tables[nameof (Mailing)]));
        if (dataSet.Tables[nameof (PolicyHolder)] != null)
          base.Tables.Add((DataTable) new NewDataSet.PolicyHolderDataTable(dataSet.Tables[nameof (PolicyHolder)]));
        if (dataSet.Tables[nameof (Underwriter)] != null)
          base.Tables.Add((DataTable) new NewDataSet.UnderwriterDataTable(dataSet.Tables[nameof (Underwriter)]));
        if (dataSet.Tables[nameof (Credentials)] != null)
          base.Tables.Add((DataTable) new NewDataSet.CredentialsDataTable(dataSet.Tables[nameof (Credentials)]));
        if (dataSet.Tables[nameof (ArrayOfInspection)] != null)
          base.Tables.Add((DataTable) new NewDataSet.ArrayOfInspectionDataTable(dataSet.Tables[nameof (ArrayOfInspection)]));
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
  public NewDataSet.ImportInspectionsRequestDataTable ImportInspectionsRequest
  {
    get => this.tableImportInspectionsRequest;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public NewDataSet.InspectionsDataTable Inspections => this.tableInspections;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public NewDataSet.InspectionDataTable Inspection => this.tableInspection;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public NewDataSet.AgentDataTable Agent => this.tableAgent;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public NewDataSet.AddressDataTable Address => this.tableAddress;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public NewDataSet.AttributesDataTable Attributes => this.tableAttributes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public NewDataSet.LocationDataTable Location => this.tableLocation;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public NewDataSet.MailingDataTable Mailing => this.tableMailing;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public NewDataSet.PolicyHolderDataTable PolicyHolder => this.tablePolicyHolder;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public NewDataSet.UnderwriterDataTable Underwriter => this.tableUnderwriter;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public NewDataSet.CredentialsDataTable Credentials => this.tableCredentials;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public NewDataSet.ArrayOfInspectionDataTable ArrayOfInspection => this.tableArrayOfInspection;

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
    NewDataSet newDataSet = (NewDataSet) base.Clone();
    newDataSet.InitVars();
    newDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) newDataSet;
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
      if (dataSet.Tables["ImportInspectionsRequest"] != null)
        base.Tables.Add((DataTable) new NewDataSet.ImportInspectionsRequestDataTable(dataSet.Tables["ImportInspectionsRequest"]));
      if (dataSet.Tables["Inspections"] != null)
        base.Tables.Add((DataTable) new NewDataSet.InspectionsDataTable(dataSet.Tables["Inspections"]));
      if (dataSet.Tables["Inspection"] != null)
        base.Tables.Add((DataTable) new NewDataSet.InspectionDataTable(dataSet.Tables["Inspection"]));
      if (dataSet.Tables["Agent"] != null)
        base.Tables.Add((DataTable) new NewDataSet.AgentDataTable(dataSet.Tables["Agent"]));
      if (dataSet.Tables["Address"] != null)
        base.Tables.Add((DataTable) new NewDataSet.AddressDataTable(dataSet.Tables["Address"]));
      if (dataSet.Tables["Attributes"] != null)
        base.Tables.Add((DataTable) new NewDataSet.AttributesDataTable(dataSet.Tables["Attributes"]));
      if (dataSet.Tables["Location"] != null)
        base.Tables.Add((DataTable) new NewDataSet.LocationDataTable(dataSet.Tables["Location"]));
      if (dataSet.Tables["Mailing"] != null)
        base.Tables.Add((DataTable) new NewDataSet.MailingDataTable(dataSet.Tables["Mailing"]));
      if (dataSet.Tables["PolicyHolder"] != null)
        base.Tables.Add((DataTable) new NewDataSet.PolicyHolderDataTable(dataSet.Tables["PolicyHolder"]));
      if (dataSet.Tables["Underwriter"] != null)
        base.Tables.Add((DataTable) new NewDataSet.UnderwriterDataTable(dataSet.Tables["Underwriter"]));
      if (dataSet.Tables["Credentials"] != null)
        base.Tables.Add((DataTable) new NewDataSet.CredentialsDataTable(dataSet.Tables["Credentials"]));
      if (dataSet.Tables["ArrayOfInspection"] != null)
        base.Tables.Add((DataTable) new NewDataSet.ArrayOfInspectionDataTable(dataSet.Tables["ArrayOfInspection"]));
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
    this.tableImportInspectionsRequest = (NewDataSet.ImportInspectionsRequestDataTable) base.Tables["ImportInspectionsRequest"];
    if (initTable && this.tableImportInspectionsRequest != null)
      this.tableImportInspectionsRequest.InitVars();
    this.tableInspections = (NewDataSet.InspectionsDataTable) base.Tables["Inspections"];
    if (initTable && this.tableInspections != null)
      this.tableInspections.InitVars();
    this.tableInspection = (NewDataSet.InspectionDataTable) base.Tables["Inspection"];
    if (initTable && this.tableInspection != null)
      this.tableInspection.InitVars();
    this.tableAgent = (NewDataSet.AgentDataTable) base.Tables["Agent"];
    if (initTable && this.tableAgent != null)
      this.tableAgent.InitVars();
    this.tableAddress = (NewDataSet.AddressDataTable) base.Tables["Address"];
    if (initTable && this.tableAddress != null)
      this.tableAddress.InitVars();
    this.tableAttributes = (NewDataSet.AttributesDataTable) base.Tables["Attributes"];
    if (initTable && this.tableAttributes != null)
      this.tableAttributes.InitVars();
    this.tableLocation = (NewDataSet.LocationDataTable) base.Tables["Location"];
    if (initTable && this.tableLocation != null)
      this.tableLocation.InitVars();
    this.tableMailing = (NewDataSet.MailingDataTable) base.Tables["Mailing"];
    if (initTable && this.tableMailing != null)
      this.tableMailing.InitVars();
    this.tablePolicyHolder = (NewDataSet.PolicyHolderDataTable) base.Tables["PolicyHolder"];
    if (initTable && this.tablePolicyHolder != null)
      this.tablePolicyHolder.InitVars();
    this.tableUnderwriter = (NewDataSet.UnderwriterDataTable) base.Tables["Underwriter"];
    if (initTable && this.tableUnderwriter != null)
      this.tableUnderwriter.InitVars();
    this.tableCredentials = (NewDataSet.CredentialsDataTable) base.Tables["Credentials"];
    if (initTable && this.tableCredentials != null)
      this.tableCredentials.InitVars();
    this.tableArrayOfInspection = (NewDataSet.ArrayOfInspectionDataTable) base.Tables["ArrayOfInspection"];
    if (initTable && this.tableArrayOfInspection != null)
      this.tableArrayOfInspection.InitVars();
    this.relationImportInspectionsRequest_Inspections = this.Relations["ImportInspectionsRequest_Inspections"];
    this.relationInspections_Inspection = this.Relations["Inspections_Inspection"];
    this.relationArrayOfInspection_Inspection = this.Relations["ArrayOfInspection_Inspection"];
    this.relationInspection_Agent = this.Relations["Inspection_Agent"];
    this.relationAgent_Address = this.Relations["Agent_Address"];
    this.relationInspection_Attributes = this.Relations["Inspection_Attributes"];
    this.relationInspection_Location = this.Relations["Inspection_Location"];
    this.relationInspection_Mailing = this.Relations["Inspection_Mailing"];
    this.relationInspection_PolicyHolder = this.Relations["Inspection_PolicyHolder"];
    this.relationInspection_Underwriter = this.Relations["Inspection_Underwriter"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (NewDataSet);
    this.Prefix = "";
    this.Namespace = "http://schemas.datacontract.org/2004/07/LC360API.Carrier_V1";
    this.Locale = new CultureInfo("");
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableImportInspectionsRequest = new NewDataSet.ImportInspectionsRequestDataTable();
    base.Tables.Add((DataTable) this.tableImportInspectionsRequest);
    this.tableInspections = new NewDataSet.InspectionsDataTable();
    base.Tables.Add((DataTable) this.tableInspections);
    this.tableInspection = new NewDataSet.InspectionDataTable();
    base.Tables.Add((DataTable) this.tableInspection);
    this.tableAgent = new NewDataSet.AgentDataTable();
    base.Tables.Add((DataTable) this.tableAgent);
    this.tableAddress = new NewDataSet.AddressDataTable();
    base.Tables.Add((DataTable) this.tableAddress);
    this.tableAttributes = new NewDataSet.AttributesDataTable();
    base.Tables.Add((DataTable) this.tableAttributes);
    this.tableLocation = new NewDataSet.LocationDataTable();
    base.Tables.Add((DataTable) this.tableLocation);
    this.tableMailing = new NewDataSet.MailingDataTable();
    base.Tables.Add((DataTable) this.tableMailing);
    this.tablePolicyHolder = new NewDataSet.PolicyHolderDataTable();
    base.Tables.Add((DataTable) this.tablePolicyHolder);
    this.tableUnderwriter = new NewDataSet.UnderwriterDataTable();
    base.Tables.Add((DataTable) this.tableUnderwriter);
    this.tableCredentials = new NewDataSet.CredentialsDataTable();
    base.Tables.Add((DataTable) this.tableCredentials);
    this.tableArrayOfInspection = new NewDataSet.ArrayOfInspectionDataTable();
    base.Tables.Add((DataTable) this.tableArrayOfInspection);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("ImportInspectionsRequest_Inspections", new DataColumn[1]
    {
      this.tableImportInspectionsRequest.ImportInspectionsRequest_IdColumn
    }, new DataColumn[1]
    {
      this.tableInspections.ImportInspectionsRequest_IdColumn
    });
    this.tableInspections.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("Inspections_Inspection", new DataColumn[1]
    {
      this.tableInspections.Inspections_IdColumn
    }, new DataColumn[1]
    {
      this.tableInspection.Inspections_IdColumn
    });
    this.tableInspection.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("ArrayOfInspection_Inspection", new DataColumn[1]
    {
      this.tableArrayOfInspection.ArrayOfInspection_IdColumn
    }, new DataColumn[1]
    {
      this.tableInspection.ArrayOfInspection_IdColumn
    });
    this.tableInspection.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("Inspection_Agent", new DataColumn[1]
    {
      this.tableInspection.Inspection_IdColumn
    }, new DataColumn[1]
    {
      this.tableAgent.Inspection_IdColumn
    });
    this.tableAgent.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint5 = new ForeignKeyConstraint("Agent_Address", new DataColumn[1]
    {
      this.tableAgent.Agent_IdColumn
    }, new DataColumn[1]{ this.tableAddress.Agent_IdColumn });
    this.tableAddress.Constraints.Add((Constraint) foreignKeyConstraint5);
    foreignKeyConstraint5.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint5.DeleteRule = Rule.Cascade;
    foreignKeyConstraint5.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint6 = new ForeignKeyConstraint("Inspection_Attributes", new DataColumn[1]
    {
      this.tableInspection.Inspection_IdColumn
    }, new DataColumn[1]
    {
      this.tableAttributes.Inspection_IdColumn
    });
    this.tableAttributes.Constraints.Add((Constraint) foreignKeyConstraint6);
    foreignKeyConstraint6.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint6.DeleteRule = Rule.Cascade;
    foreignKeyConstraint6.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint7 = new ForeignKeyConstraint("Inspection_Location", new DataColumn[1]
    {
      this.tableInspection.Inspection_IdColumn
    }, new DataColumn[1]
    {
      this.tableLocation.Inspection_IdColumn
    });
    this.tableLocation.Constraints.Add((Constraint) foreignKeyConstraint7);
    foreignKeyConstraint7.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint7.DeleteRule = Rule.Cascade;
    foreignKeyConstraint7.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint8 = new ForeignKeyConstraint("Inspection_Mailing", new DataColumn[1]
    {
      this.tableInspection.Inspection_IdColumn
    }, new DataColumn[1]
    {
      this.tableMailing.Inspection_IdColumn
    });
    this.tableMailing.Constraints.Add((Constraint) foreignKeyConstraint8);
    foreignKeyConstraint8.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint8.DeleteRule = Rule.Cascade;
    foreignKeyConstraint8.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint9 = new ForeignKeyConstraint("Inspection_PolicyHolder", new DataColumn[1]
    {
      this.tableInspection.Inspection_IdColumn
    }, new DataColumn[1]
    {
      this.tablePolicyHolder.Inspection_IdColumn
    });
    this.tablePolicyHolder.Constraints.Add((Constraint) foreignKeyConstraint9);
    foreignKeyConstraint9.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint9.DeleteRule = Rule.Cascade;
    foreignKeyConstraint9.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint10 = new ForeignKeyConstraint("Inspection_Underwriter", new DataColumn[1]
    {
      this.tableInspection.Inspection_IdColumn
    }, new DataColumn[1]
    {
      this.tableUnderwriter.Inspection_IdColumn
    });
    this.tableUnderwriter.Constraints.Add((Constraint) foreignKeyConstraint10);
    foreignKeyConstraint10.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint10.DeleteRule = Rule.Cascade;
    foreignKeyConstraint10.UpdateRule = Rule.Cascade;
    this.relationImportInspectionsRequest_Inspections = new DataRelation("ImportInspectionsRequest_Inspections", new DataColumn[1]
    {
      this.tableImportInspectionsRequest.ImportInspectionsRequest_IdColumn
    }, new DataColumn[1]
    {
      this.tableInspections.ImportInspectionsRequest_IdColumn
    }, false);
    this.relationImportInspectionsRequest_Inspections.Nested = true;
    this.Relations.Add(this.relationImportInspectionsRequest_Inspections);
    this.relationInspections_Inspection = new DataRelation("Inspections_Inspection", new DataColumn[1]
    {
      this.tableInspections.Inspections_IdColumn
    }, new DataColumn[1]
    {
      this.tableInspection.Inspections_IdColumn
    }, false);
    this.relationInspections_Inspection.Nested = true;
    this.Relations.Add(this.relationInspections_Inspection);
    this.relationArrayOfInspection_Inspection = new DataRelation("ArrayOfInspection_Inspection", new DataColumn[1]
    {
      this.tableArrayOfInspection.ArrayOfInspection_IdColumn
    }, new DataColumn[1]
    {
      this.tableInspection.ArrayOfInspection_IdColumn
    }, false);
    this.relationArrayOfInspection_Inspection.Nested = true;
    this.Relations.Add(this.relationArrayOfInspection_Inspection);
    this.relationInspection_Agent = new DataRelation("Inspection_Agent", new DataColumn[1]
    {
      this.tableInspection.Inspection_IdColumn
    }, new DataColumn[1]
    {
      this.tableAgent.Inspection_IdColumn
    }, false);
    this.relationInspection_Agent.Nested = true;
    this.Relations.Add(this.relationInspection_Agent);
    this.relationAgent_Address = new DataRelation("Agent_Address", new DataColumn[1]
    {
      this.tableAgent.Agent_IdColumn
    }, new DataColumn[1]{ this.tableAddress.Agent_IdColumn }, false);
    this.relationAgent_Address.Nested = true;
    this.Relations.Add(this.relationAgent_Address);
    this.relationInspection_Attributes = new DataRelation("Inspection_Attributes", new DataColumn[1]
    {
      this.tableInspection.Inspection_IdColumn
    }, new DataColumn[1]
    {
      this.tableAttributes.Inspection_IdColumn
    }, false);
    this.relationInspection_Attributes.Nested = true;
    this.Relations.Add(this.relationInspection_Attributes);
    this.relationInspection_Location = new DataRelation("Inspection_Location", new DataColumn[1]
    {
      this.tableInspection.Inspection_IdColumn
    }, new DataColumn[1]
    {
      this.tableLocation.Inspection_IdColumn
    }, false);
    this.relationInspection_Location.Nested = true;
    this.Relations.Add(this.relationInspection_Location);
    this.relationInspection_Mailing = new DataRelation("Inspection_Mailing", new DataColumn[1]
    {
      this.tableInspection.Inspection_IdColumn
    }, new DataColumn[1]
    {
      this.tableMailing.Inspection_IdColumn
    }, false);
    this.relationInspection_Mailing.Nested = true;
    this.Relations.Add(this.relationInspection_Mailing);
    this.relationInspection_PolicyHolder = new DataRelation("Inspection_PolicyHolder", new DataColumn[1]
    {
      this.tableInspection.Inspection_IdColumn
    }, new DataColumn[1]
    {
      this.tablePolicyHolder.Inspection_IdColumn
    }, false);
    this.relationInspection_PolicyHolder.Nested = true;
    this.Relations.Add(this.relationInspection_PolicyHolder);
    this.relationInspection_Underwriter = new DataRelation("Inspection_Underwriter", new DataColumn[1]
    {
      this.tableInspection.Inspection_IdColumn
    }, new DataColumn[1]
    {
      this.tableUnderwriter.Inspection_IdColumn
    }, false);
    this.relationInspection_Underwriter.Nested = true;
    this.Relations.Add(this.relationInspection_Underwriter);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeImportInspectionsRequest() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeInspections() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeInspection() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeAgent() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeAddress() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeAttributes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeLocation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeMailing() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializePolicyHolder() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeUnderwriter() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeCredentials() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeArrayOfInspection() => false;

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
    NewDataSet newDataSet = new NewDataSet();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = newDataSet.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = newDataSet.GetSchemaSerializable();
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
  public delegate void ImportInspectionsRequestRowChangeEventHandler(
    object sender,
    NewDataSet.ImportInspectionsRequestRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void InspectionsRowChangeEventHandler(
    object sender,
    NewDataSet.InspectionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void InspectionRowChangeEventHandler(
    object sender,
    NewDataSet.InspectionRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void AgentRowChangeEventHandler(object sender, NewDataSet.AgentRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void AddressRowChangeEventHandler(
    object sender,
    NewDataSet.AddressRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void AttributesRowChangeEventHandler(
    object sender,
    NewDataSet.AttributesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void LocationRowChangeEventHandler(
    object sender,
    NewDataSet.LocationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void MailingRowChangeEventHandler(
    object sender,
    NewDataSet.MailingRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void PolicyHolderRowChangeEventHandler(
    object sender,
    NewDataSet.PolicyHolderRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void UnderwriterRowChangeEventHandler(
    object sender,
    NewDataSet.UnderwriterRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void CredentialsRowChangeEventHandler(
    object sender,
    NewDataSet.CredentialsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void ArrayOfInspectionRowChangeEventHandler(
    object sender,
    NewDataSet.ArrayOfInspectionRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class ImportInspectionsRequestDataTable : 
    TypedTableBase<NewDataSet.ImportInspectionsRequestRow>
  {
    private DataColumn columnPassword;
    private DataColumn columnUserName;
    private DataColumn columnImportInspectionsRequest_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ImportInspectionsRequestDataTable()
    {
      this.TableName = "ImportInspectionsRequest";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ImportInspectionsRequestDataTable(DataTable table)
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
    protected ImportInspectionsRequestDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PasswordColumn => this.columnPassword;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ImportInspectionsRequest_IdColumn => this.columnImportInspectionsRequest_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.ImportInspectionsRequestRow this[int index]
    {
      get => (NewDataSet.ImportInspectionsRequestRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.ImportInspectionsRequestRowChangeEventHandler ImportInspectionsRequestRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.ImportInspectionsRequestRowChangeEventHandler ImportInspectionsRequestRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.ImportInspectionsRequestRowChangeEventHandler ImportInspectionsRequestRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.ImportInspectionsRequestRowChangeEventHandler ImportInspectionsRequestRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddImportInspectionsRequestRow(NewDataSet.ImportInspectionsRequestRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.ImportInspectionsRequestRow AddImportInspectionsRequestRow(
      string Password,
      string UserName)
    {
      NewDataSet.ImportInspectionsRequestRow row = (NewDataSet.ImportInspectionsRequestRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) Password,
        (object) UserName,
        null
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      NewDataSet.ImportInspectionsRequestDataTable requestDataTable = (NewDataSet.ImportInspectionsRequestDataTable) base.Clone();
      requestDataTable.InitVars();
      return (DataTable) requestDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new NewDataSet.ImportInspectionsRequestDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnPassword = this.Columns["Password"];
      this.columnUserName = this.Columns["UserName"];
      this.columnImportInspectionsRequest_Id = this.Columns["ImportInspectionsRequest_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnPassword = new DataColumn("Password", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPassword);
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.columnImportInspectionsRequest_Id = new DataColumn("ImportInspectionsRequest_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnImportInspectionsRequest_Id);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnImportInspectionsRequest_Id
      }, true));
      this.columnImportInspectionsRequest_Id.AutoIncrement = true;
      this.columnImportInspectionsRequest_Id.AllowDBNull = false;
      this.columnImportInspectionsRequest_Id.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.ImportInspectionsRequestRow NewImportInspectionsRequestRow()
    {
      return (NewDataSet.ImportInspectionsRequestRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new NewDataSet.ImportInspectionsRequestRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (NewDataSet.ImportInspectionsRequestRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ImportInspectionsRequestRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.ImportInspectionsRequestRowChangeEventHandler requestRowChangedEvent = this.ImportInspectionsRequestRowChangedEvent;
      if (requestRowChangedEvent == null)
        return;
      requestRowChangedEvent((object) this, new NewDataSet.ImportInspectionsRequestRowChangeEvent((NewDataSet.ImportInspectionsRequestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ImportInspectionsRequestRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.ImportInspectionsRequestRowChangeEventHandler rowChangingEvent = this.ImportInspectionsRequestRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new NewDataSet.ImportInspectionsRequestRowChangeEvent((NewDataSet.ImportInspectionsRequestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ImportInspectionsRequestRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.ImportInspectionsRequestRowChangeEventHandler requestRowDeletedEvent = this.ImportInspectionsRequestRowDeletedEvent;
      if (requestRowDeletedEvent == null)
        return;
      requestRowDeletedEvent((object) this, new NewDataSet.ImportInspectionsRequestRowChangeEvent((NewDataSet.ImportInspectionsRequestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ImportInspectionsRequestRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.ImportInspectionsRequestRowChangeEventHandler rowDeletingEvent = this.ImportInspectionsRequestRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new NewDataSet.ImportInspectionsRequestRowChangeEvent((NewDataSet.ImportInspectionsRequestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveImportInspectionsRequestRow(NewDataSet.ImportInspectionsRequestRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      NewDataSet newDataSet = new NewDataSet();
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
        FixedValue = newDataSet.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ImportInspectionsRequestDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newDataSet.GetSchemaSerializable();
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
  public class InspectionsDataTable : TypedTableBase<NewDataSet.InspectionsRow>
  {
    private DataColumn columnInspections_Id;
    private DataColumn columnImportInspectionsRequest_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InspectionsDataTable()
    {
      this.TableName = "Inspections";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal InspectionsDataTable(DataTable table)
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
    protected InspectionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Inspections_IdColumn => this.columnInspections_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ImportInspectionsRequest_IdColumn => this.columnImportInspectionsRequest_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionsRow this[int index]
    {
      get => (NewDataSet.InspectionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.InspectionsRowChangeEventHandler InspectionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.InspectionsRowChangeEventHandler InspectionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.InspectionsRowChangeEventHandler InspectionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.InspectionsRowChangeEventHandler InspectionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddInspectionsRow(NewDataSet.InspectionsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionsRow AddInspectionsRow(
      NewDataSet.ImportInspectionsRequestRow parentImportInspectionsRequestRowByImportInspectionsRequest_Inspections)
    {
      NewDataSet.InspectionsRow row = (NewDataSet.InspectionsRow) this.NewRow();
      object[] objArray = new object[2];
      if (parentImportInspectionsRequestRowByImportInspectionsRequest_Inspections != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentImportInspectionsRequestRowByImportInspectionsRequest_Inspections[2]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      NewDataSet.InspectionsDataTable inspectionsDataTable = (NewDataSet.InspectionsDataTable) base.Clone();
      inspectionsDataTable.InitVars();
      return (DataTable) inspectionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new NewDataSet.InspectionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnInspections_Id = this.Columns["Inspections_Id"];
      this.columnImportInspectionsRequest_Id = this.Columns["ImportInspectionsRequest_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnInspections_Id = new DataColumn("Inspections_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnInspections_Id);
      this.columnImportInspectionsRequest_Id = new DataColumn("ImportInspectionsRequest_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnImportInspectionsRequest_Id);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnInspections_Id
      }, true));
      this.columnInspections_Id.AutoIncrement = true;
      this.columnInspections_Id.AllowDBNull = false;
      this.columnInspections_Id.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionsRow NewInspectionsRow()
    {
      return (NewDataSet.InspectionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new NewDataSet.InspectionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (NewDataSet.InspectionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InspectionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.InspectionsRowChangeEventHandler inspectionsRowChangedEvent = this.InspectionsRowChangedEvent;
      if (inspectionsRowChangedEvent == null)
        return;
      inspectionsRowChangedEvent((object) this, new NewDataSet.InspectionsRowChangeEvent((NewDataSet.InspectionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InspectionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.InspectionsRowChangeEventHandler rowChangingEvent = this.InspectionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new NewDataSet.InspectionsRowChangeEvent((NewDataSet.InspectionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InspectionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.InspectionsRowChangeEventHandler inspectionsRowDeletedEvent = this.InspectionsRowDeletedEvent;
      if (inspectionsRowDeletedEvent == null)
        return;
      inspectionsRowDeletedEvent((object) this, new NewDataSet.InspectionsRowChangeEvent((NewDataSet.InspectionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InspectionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.InspectionsRowChangeEventHandler rowDeletingEvent = this.InspectionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new NewDataSet.InspectionsRowChangeEvent((NewDataSet.InspectionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveInspectionsRow(NewDataSet.InspectionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      NewDataSet newDataSet = new NewDataSet();
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
        FixedValue = newDataSet.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InspectionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newDataSet.GetSchemaSerializable();
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
  public class InspectionDataTable : TypedTableBase<NewDataSet.InspectionRow>
  {
    private DataColumn columnCustomerKey;
    private DataColumn columnEffectiveDate;
    private DataColumn columnIgnoreDuplicates;
    private DataColumn columnInspectionType;
    private DataColumn columnIsRush;
    private DataColumn columnNotes;
    private DataColumn columnPolicyNumber;
    private DataColumn columnInspection_Id;
    private DataColumn columnInspections_Id;
    private DataColumn columnArrayOfInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InspectionDataTable()
    {
      this.TableName = "Inspection";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal InspectionDataTable(DataTable table)
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
    protected InspectionDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CustomerKeyColumn => this.columnCustomerKey;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IgnoreDuplicatesColumn => this.columnIgnoreDuplicates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InspectionTypeColumn => this.columnInspectionType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IsRushColumn => this.columnIsRush;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NotesColumn => this.columnNotes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Inspection_IdColumn => this.columnInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Inspections_IdColumn => this.columnInspections_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ArrayOfInspection_IdColumn => this.columnArrayOfInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionRow this[int index] => (NewDataSet.InspectionRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.InspectionRowChangeEventHandler InspectionRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.InspectionRowChangeEventHandler InspectionRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.InspectionRowChangeEventHandler InspectionRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.InspectionRowChangeEventHandler InspectionRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddInspectionRow(NewDataSet.InspectionRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionRow AddInspectionRow(
      string CustomerKey,
      DateTime EffectiveDate,
      bool IgnoreDuplicates,
      string InspectionType,
      bool IsRush,
      string Notes,
      string PolicyNumber,
      NewDataSet.InspectionsRow parentInspectionsRowByInspections_Inspection,
      NewDataSet.ArrayOfInspectionRow parentArrayOfInspectionRowByArrayOfInspection_Inspection)
    {
      NewDataSet.InspectionRow row = (NewDataSet.InspectionRow) this.NewRow();
      object[] objArray = new object[10]
      {
        (object) CustomerKey,
        (object) EffectiveDate,
        (object) IgnoreDuplicates,
        (object) InspectionType,
        (object) IsRush,
        (object) Notes,
        (object) PolicyNumber,
        null,
        null,
        null
      };
      if (parentInspectionsRowByInspections_Inspection != null)
        objArray[8] = RuntimeHelpers.GetObjectValue(parentInspectionsRowByInspections_Inspection[0]);
      if (parentArrayOfInspectionRowByArrayOfInspection_Inspection != null)
        objArray[9] = RuntimeHelpers.GetObjectValue(parentArrayOfInspectionRowByArrayOfInspection_Inspection[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      NewDataSet.InspectionDataTable inspectionDataTable = (NewDataSet.InspectionDataTable) base.Clone();
      inspectionDataTable.InitVars();
      return (DataTable) inspectionDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new NewDataSet.InspectionDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCustomerKey = this.Columns["CustomerKey"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnIgnoreDuplicates = this.Columns["IgnoreDuplicates"];
      this.columnInspectionType = this.Columns["InspectionType"];
      this.columnIsRush = this.Columns["IsRush"];
      this.columnNotes = this.Columns["Notes"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInspection_Id = this.Columns["Inspection_Id"];
      this.columnInspections_Id = this.Columns["Inspections_Id"];
      this.columnArrayOfInspection_Id = this.Columns["ArrayOfInspection_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCustomerKey = new DataColumn("CustomerKey", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCustomerKey);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnIgnoreDuplicates = new DataColumn("IgnoreDuplicates", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIgnoreDuplicates);
      this.columnInspectionType = new DataColumn("InspectionType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionType);
      this.columnIsRush = new DataColumn("IsRush", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsRush);
      this.columnNotes = new DataColumn("Notes", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNotes);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInspection_Id = new DataColumn("Inspection_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnInspection_Id);
      this.columnInspections_Id = new DataColumn("Inspections_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnInspections_Id);
      this.columnArrayOfInspection_Id = new DataColumn("ArrayOfInspection_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnArrayOfInspection_Id);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnInspection_Id
      }, true));
      this.columnInspection_Id.AutoIncrement = true;
      this.columnInspection_Id.AllowDBNull = false;
      this.columnInspection_Id.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionRow NewInspectionRow() => (NewDataSet.InspectionRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new NewDataSet.InspectionRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (NewDataSet.InspectionRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InspectionRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.InspectionRowChangeEventHandler inspectionRowChangedEvent = this.InspectionRowChangedEvent;
      if (inspectionRowChangedEvent == null)
        return;
      inspectionRowChangedEvent((object) this, new NewDataSet.InspectionRowChangeEvent((NewDataSet.InspectionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InspectionRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.InspectionRowChangeEventHandler rowChangingEvent = this.InspectionRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new NewDataSet.InspectionRowChangeEvent((NewDataSet.InspectionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InspectionRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.InspectionRowChangeEventHandler inspectionRowDeletedEvent = this.InspectionRowDeletedEvent;
      if (inspectionRowDeletedEvent == null)
        return;
      inspectionRowDeletedEvent((object) this, new NewDataSet.InspectionRowChangeEvent((NewDataSet.InspectionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InspectionRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.InspectionRowChangeEventHandler rowDeletingEvent = this.InspectionRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new NewDataSet.InspectionRowChangeEvent((NewDataSet.InspectionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveInspectionRow(NewDataSet.InspectionRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      NewDataSet newDataSet = new NewDataSet();
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
        FixedValue = newDataSet.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InspectionDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newDataSet.GetSchemaSerializable();
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
  public class AgentDataTable : TypedTableBase<NewDataSet.AgentRow>
  {
    private DataColumn columnAgencyName;
    private DataColumn columnAgentCode;
    private DataColumn columnContactEmail;
    private DataColumn columnContactName;
    private DataColumn columnFax;
    private DataColumn columnPhone;
    private DataColumn columnAgent_Id;
    private DataColumn columnInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AgentDataTable()
    {
      this.TableName = "Agent";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AgentDataTable(DataTable table)
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
    protected AgentDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AgencyNameColumn => this.columnAgencyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AgentCodeColumn => this.columnAgentCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContactEmailColumn => this.columnContactEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContactNameColumn => this.columnContactName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FaxColumn => this.columnFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PhoneColumn => this.columnPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Agent_IdColumn => this.columnAgent_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Inspection_IdColumn => this.columnInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AgentRow this[int index] => (NewDataSet.AgentRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.AgentRowChangeEventHandler AgentRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.AgentRowChangeEventHandler AgentRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.AgentRowChangeEventHandler AgentRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.AgentRowChangeEventHandler AgentRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddAgentRow(NewDataSet.AgentRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AgentRow AddAgentRow(
      string AgencyName,
      string AgentCode,
      string ContactEmail,
      string ContactName,
      string Fax,
      string Phone,
      NewDataSet.InspectionRow parentInspectionRowByInspection_Agent)
    {
      NewDataSet.AgentRow row = (NewDataSet.AgentRow) this.NewRow();
      object[] objArray = new object[8]
      {
        (object) AgencyName,
        (object) AgentCode,
        (object) ContactEmail,
        (object) ContactName,
        (object) Fax,
        (object) Phone,
        null,
        null
      };
      if (parentInspectionRowByInspection_Agent != null)
        objArray[7] = RuntimeHelpers.GetObjectValue(parentInspectionRowByInspection_Agent[7]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      NewDataSet.AgentDataTable agentDataTable = (NewDataSet.AgentDataTable) base.Clone();
      agentDataTable.InitVars();
      return (DataTable) agentDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new NewDataSet.AgentDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnAgencyName = this.Columns["AgencyName"];
      this.columnAgentCode = this.Columns["AgentCode"];
      this.columnContactEmail = this.Columns["ContactEmail"];
      this.columnContactName = this.Columns["ContactName"];
      this.columnFax = this.Columns["Fax"];
      this.columnPhone = this.Columns["Phone"];
      this.columnAgent_Id = this.Columns["Agent_Id"];
      this.columnInspection_Id = this.Columns["Inspection_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnAgencyName = new DataColumn("AgencyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAgencyName);
      this.columnAgentCode = new DataColumn("AgentCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAgentCode);
      this.columnContactEmail = new DataColumn("ContactEmail", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactEmail);
      this.columnContactName = new DataColumn("ContactName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactName);
      this.columnFax = new DataColumn("Fax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFax);
      this.columnPhone = new DataColumn("Phone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhone);
      this.columnAgent_Id = new DataColumn("Agent_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnAgent_Id);
      this.columnInspection_Id = new DataColumn("Inspection_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnInspection_Id);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnAgent_Id
      }, true));
      this.columnAgent_Id.AutoIncrement = true;
      this.columnAgent_Id.AllowDBNull = false;
      this.columnAgent_Id.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AgentRow NewAgentRow() => (NewDataSet.AgentRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new NewDataSet.AgentRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (NewDataSet.AgentRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AgentRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.AgentRowChangeEventHandler agentRowChangedEvent = this.AgentRowChangedEvent;
      if (agentRowChangedEvent == null)
        return;
      agentRowChangedEvent((object) this, new NewDataSet.AgentRowChangeEvent((NewDataSet.AgentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AgentRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.AgentRowChangeEventHandler rowChangingEvent = this.AgentRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new NewDataSet.AgentRowChangeEvent((NewDataSet.AgentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AgentRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.AgentRowChangeEventHandler agentRowDeletedEvent = this.AgentRowDeletedEvent;
      if (agentRowDeletedEvent == null)
        return;
      agentRowDeletedEvent((object) this, new NewDataSet.AgentRowChangeEvent((NewDataSet.AgentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AgentRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.AgentRowChangeEventHandler rowDeletingEvent = this.AgentRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new NewDataSet.AgentRowChangeEvent((NewDataSet.AgentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveAgentRow(NewDataSet.AgentRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      NewDataSet newDataSet = new NewDataSet();
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
        FixedValue = newDataSet.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (AgentDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newDataSet.GetSchemaSerializable();
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
  public class AddressDataTable : TypedTableBase<NewDataSet.AddressRow>
  {
    private DataColumn columnCity;
    private DataColumn columnStateOrProvince;
    private DataColumn columnStreet1;
    private DataColumn columnStreet2;
    private DataColumn columnZipCode;
    private DataColumn columnAgent_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AddressDataTable()
    {
      this.TableName = "Address";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AddressDataTable(DataTable table)
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
    protected AddressDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateOrProvinceColumn => this.columnStateOrProvince;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Street1Column => this.columnStreet1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Street2Column => this.columnStreet2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Agent_IdColumn => this.columnAgent_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AddressRow this[int index] => (NewDataSet.AddressRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.AddressRowChangeEventHandler AddressRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.AddressRowChangeEventHandler AddressRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.AddressRowChangeEventHandler AddressRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.AddressRowChangeEventHandler AddressRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddAddressRow(NewDataSet.AddressRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AddressRow AddAddressRow(
      string City,
      string StateOrProvince,
      string Street1,
      string Street2,
      string ZipCode,
      NewDataSet.AgentRow parentAgentRowByAgent_Address)
    {
      NewDataSet.AddressRow row = (NewDataSet.AddressRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) City,
        (object) StateOrProvince,
        (object) Street1,
        (object) Street2,
        (object) ZipCode,
        null
      };
      if (parentAgentRowByAgent_Address != null)
        objArray[5] = RuntimeHelpers.GetObjectValue(parentAgentRowByAgent_Address[6]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      NewDataSet.AddressDataTable addressDataTable = (NewDataSet.AddressDataTable) base.Clone();
      addressDataTable.InitVars();
      return (DataTable) addressDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new NewDataSet.AddressDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCity = this.Columns["City"];
      this.columnStateOrProvince = this.Columns["StateOrProvince"];
      this.columnStreet1 = this.Columns["Street1"];
      this.columnStreet2 = this.Columns["Street2"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnAgent_Id = this.Columns["Agent_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnStateOrProvince = new DataColumn("StateOrProvince", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateOrProvince);
      this.columnStreet1 = new DataColumn("Street1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStreet1);
      this.columnStreet2 = new DataColumn("Street2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStreet2);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnAgent_Id = new DataColumn("Agent_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnAgent_Id);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AddressRow NewAddressRow() => (NewDataSet.AddressRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new NewDataSet.AddressRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (NewDataSet.AddressRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AddressRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.AddressRowChangeEventHandler addressRowChangedEvent = this.AddressRowChangedEvent;
      if (addressRowChangedEvent == null)
        return;
      addressRowChangedEvent((object) this, new NewDataSet.AddressRowChangeEvent((NewDataSet.AddressRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AddressRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.AddressRowChangeEventHandler rowChangingEvent = this.AddressRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new NewDataSet.AddressRowChangeEvent((NewDataSet.AddressRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AddressRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.AddressRowChangeEventHandler addressRowDeletedEvent = this.AddressRowDeletedEvent;
      if (addressRowDeletedEvent == null)
        return;
      addressRowDeletedEvent((object) this, new NewDataSet.AddressRowChangeEvent((NewDataSet.AddressRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AddressRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.AddressRowChangeEventHandler rowDeletingEvent = this.AddressRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new NewDataSet.AddressRowChangeEvent((NewDataSet.AddressRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveAddressRow(NewDataSet.AddressRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      NewDataSet newDataSet = new NewDataSet();
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
        FixedValue = newDataSet.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (AddressDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newDataSet.GetSchemaSerializable();
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
  public class AttributesDataTable : TypedTableBase<NewDataSet.AttributesRow>
  {
    private DataColumn columnBuildingCost;
    private DataColumn columnBusinessTotalRevenue;
    private DataColumn columnBusinessType;
    private DataColumn columnContentsCost;
    private DataColumn columnCoverageAIn;
    private DataColumn columnIsoClass;
    private DataColumn columnOccupancy;
    private DataColumn columnYearBuilt;
    private DataColumn columnInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AttributesDataTable()
    {
      this.TableName = "Attributes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AttributesDataTable(DataTable table)
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
    protected AttributesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BuildingCostColumn => this.columnBuildingCost;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BusinessTotalRevenueColumn => this.columnBusinessTotalRevenue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BusinessTypeColumn => this.columnBusinessType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContentsCostColumn => this.columnContentsCost;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CoverageAInColumn => this.columnCoverageAIn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IsoClassColumn => this.columnIsoClass;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OccupancyColumn => this.columnOccupancy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn YearBuiltColumn => this.columnYearBuilt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Inspection_IdColumn => this.columnInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AttributesRow this[int index] => (NewDataSet.AttributesRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.AttributesRowChangeEventHandler AttributesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.AttributesRowChangeEventHandler AttributesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.AttributesRowChangeEventHandler AttributesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.AttributesRowChangeEventHandler AttributesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddAttributesRow(NewDataSet.AttributesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AttributesRow AddAttributesRow(
      Decimal BuildingCost,
      Decimal BusinessTotalRevenue,
      string BusinessType,
      Decimal ContentsCost,
      Decimal CoverageAIn,
      string IsoClass,
      string Occupancy,
      int YearBuilt,
      NewDataSet.InspectionRow parentInspectionRowByInspection_Attributes)
    {
      NewDataSet.AttributesRow row = (NewDataSet.AttributesRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) BuildingCost,
        (object) BusinessTotalRevenue,
        (object) BusinessType,
        (object) ContentsCost,
        (object) CoverageAIn,
        (object) IsoClass,
        (object) Occupancy,
        (object) YearBuilt,
        null
      };
      if (parentInspectionRowByInspection_Attributes != null)
        objArray[8] = RuntimeHelpers.GetObjectValue(parentInspectionRowByInspection_Attributes[7]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      NewDataSet.AttributesDataTable attributesDataTable = (NewDataSet.AttributesDataTable) base.Clone();
      attributesDataTable.InitVars();
      return (DataTable) attributesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new NewDataSet.AttributesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnBuildingCost = this.Columns["BuildingCost"];
      this.columnBusinessTotalRevenue = this.Columns["BusinessTotalRevenue"];
      this.columnBusinessType = this.Columns["BusinessType"];
      this.columnContentsCost = this.Columns["ContentsCost"];
      this.columnCoverageAIn = this.Columns["CoverageAIn"];
      this.columnIsoClass = this.Columns["IsoClass"];
      this.columnOccupancy = this.Columns["Occupancy"];
      this.columnYearBuilt = this.Columns["YearBuilt"];
      this.columnInspection_Id = this.Columns["Inspection_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnBuildingCost = new DataColumn("BuildingCost", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBuildingCost);
      this.columnBusinessTotalRevenue = new DataColumn("BusinessTotalRevenue", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBusinessTotalRevenue);
      this.columnBusinessType = new DataColumn("BusinessType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBusinessType);
      this.columnContentsCost = new DataColumn("ContentsCost", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContentsCost);
      this.columnCoverageAIn = new DataColumn("CoverageAIn", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageAIn);
      this.columnIsoClass = new DataColumn("IsoClass", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsoClass);
      this.columnOccupancy = new DataColumn("Occupancy", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOccupancy);
      this.columnYearBuilt = new DataColumn("YearBuilt", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYearBuilt);
      this.columnInspection_Id = new DataColumn("Inspection_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnInspection_Id);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AttributesRow NewAttributesRow() => (NewDataSet.AttributesRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new NewDataSet.AttributesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (NewDataSet.AttributesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AttributesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.AttributesRowChangeEventHandler attributesRowChangedEvent = this.AttributesRowChangedEvent;
      if (attributesRowChangedEvent == null)
        return;
      attributesRowChangedEvent((object) this, new NewDataSet.AttributesRowChangeEvent((NewDataSet.AttributesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AttributesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.AttributesRowChangeEventHandler rowChangingEvent = this.AttributesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new NewDataSet.AttributesRowChangeEvent((NewDataSet.AttributesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AttributesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.AttributesRowChangeEventHandler attributesRowDeletedEvent = this.AttributesRowDeletedEvent;
      if (attributesRowDeletedEvent == null)
        return;
      attributesRowDeletedEvent((object) this, new NewDataSet.AttributesRowChangeEvent((NewDataSet.AttributesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AttributesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.AttributesRowChangeEventHandler rowDeletingEvent = this.AttributesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new NewDataSet.AttributesRowChangeEvent((NewDataSet.AttributesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveAttributesRow(NewDataSet.AttributesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      NewDataSet newDataSet = new NewDataSet();
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
        FixedValue = newDataSet.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (AttributesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newDataSet.GetSchemaSerializable();
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
  public class LocationDataTable : TypedTableBase<NewDataSet.LocationRow>
  {
    private DataColumn columnCity;
    private DataColumn columnStateOrProvince;
    private DataColumn columnStreet1;
    private DataColumn columnStreet2;
    private DataColumn columnZipCode;
    private DataColumn columnInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public LocationDataTable()
    {
      this.TableName = "Location";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal LocationDataTable(DataTable table)
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
    protected LocationDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateOrProvinceColumn => this.columnStateOrProvince;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Street1Column => this.columnStreet1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Street2Column => this.columnStreet2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Inspection_IdColumn => this.columnInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.LocationRow this[int index] => (NewDataSet.LocationRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.LocationRowChangeEventHandler LocationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.LocationRowChangeEventHandler LocationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.LocationRowChangeEventHandler LocationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.LocationRowChangeEventHandler LocationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddLocationRow(NewDataSet.LocationRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.LocationRow AddLocationRow(
      string City,
      string StateOrProvince,
      string Street1,
      string Street2,
      string ZipCode,
      NewDataSet.InspectionRow parentInspectionRowByInspection_Location)
    {
      NewDataSet.LocationRow row = (NewDataSet.LocationRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) City,
        (object) StateOrProvince,
        (object) Street1,
        (object) Street2,
        (object) ZipCode,
        null
      };
      if (parentInspectionRowByInspection_Location != null)
        objArray[5] = RuntimeHelpers.GetObjectValue(parentInspectionRowByInspection_Location[7]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      NewDataSet.LocationDataTable locationDataTable = (NewDataSet.LocationDataTable) base.Clone();
      locationDataTable.InitVars();
      return (DataTable) locationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new NewDataSet.LocationDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCity = this.Columns["City"];
      this.columnStateOrProvince = this.Columns["StateOrProvince"];
      this.columnStreet1 = this.Columns["Street1"];
      this.columnStreet2 = this.Columns["Street2"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnInspection_Id = this.Columns["Inspection_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnStateOrProvince = new DataColumn("StateOrProvince", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateOrProvince);
      this.columnStreet1 = new DataColumn("Street1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStreet1);
      this.columnStreet2 = new DataColumn("Street2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStreet2);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnInspection_Id = new DataColumn("Inspection_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnInspection_Id);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.LocationRow NewLocationRow() => (NewDataSet.LocationRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new NewDataSet.LocationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (NewDataSet.LocationRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LocationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.LocationRowChangeEventHandler locationRowChangedEvent = this.LocationRowChangedEvent;
      if (locationRowChangedEvent == null)
        return;
      locationRowChangedEvent((object) this, new NewDataSet.LocationRowChangeEvent((NewDataSet.LocationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LocationRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.LocationRowChangeEventHandler rowChangingEvent = this.LocationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new NewDataSet.LocationRowChangeEvent((NewDataSet.LocationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LocationRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.LocationRowChangeEventHandler locationRowDeletedEvent = this.LocationRowDeletedEvent;
      if (locationRowDeletedEvent == null)
        return;
      locationRowDeletedEvent((object) this, new NewDataSet.LocationRowChangeEvent((NewDataSet.LocationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LocationRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.LocationRowChangeEventHandler rowDeletingEvent = this.LocationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new NewDataSet.LocationRowChangeEvent((NewDataSet.LocationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveLocationRow(NewDataSet.LocationRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      NewDataSet newDataSet = new NewDataSet();
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
        FixedValue = newDataSet.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (LocationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newDataSet.GetSchemaSerializable();
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
  public class MailingDataTable : TypedTableBase<NewDataSet.MailingRow>
  {
    private DataColumn columnCity;
    private DataColumn columnStateOrProvince;
    private DataColumn columnStreet1;
    private DataColumn columnStreet2;
    private DataColumn columnZipCode;
    private DataColumn columnInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public MailingDataTable()
    {
      this.TableName = "Mailing";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal MailingDataTable(DataTable table)
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
    protected MailingDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateOrProvinceColumn => this.columnStateOrProvince;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Street1Column => this.columnStreet1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Street2Column => this.columnStreet2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Inspection_IdColumn => this.columnInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.MailingRow this[int index] => (NewDataSet.MailingRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.MailingRowChangeEventHandler MailingRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.MailingRowChangeEventHandler MailingRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.MailingRowChangeEventHandler MailingRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.MailingRowChangeEventHandler MailingRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddMailingRow(NewDataSet.MailingRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.MailingRow AddMailingRow(
      string City,
      string StateOrProvince,
      string Street1,
      string Street2,
      string ZipCode,
      NewDataSet.InspectionRow parentInspectionRowByInspection_Mailing)
    {
      NewDataSet.MailingRow row = (NewDataSet.MailingRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) City,
        (object) StateOrProvince,
        (object) Street1,
        (object) Street2,
        (object) ZipCode,
        null
      };
      if (parentInspectionRowByInspection_Mailing != null)
        objArray[5] = RuntimeHelpers.GetObjectValue(parentInspectionRowByInspection_Mailing[7]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      NewDataSet.MailingDataTable mailingDataTable = (NewDataSet.MailingDataTable) base.Clone();
      mailingDataTable.InitVars();
      return (DataTable) mailingDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new NewDataSet.MailingDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCity = this.Columns["City"];
      this.columnStateOrProvince = this.Columns["StateOrProvince"];
      this.columnStreet1 = this.Columns["Street1"];
      this.columnStreet2 = this.Columns["Street2"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnInspection_Id = this.Columns["Inspection_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnStateOrProvince = new DataColumn("StateOrProvince", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateOrProvince);
      this.columnStreet1 = new DataColumn("Street1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStreet1);
      this.columnStreet2 = new DataColumn("Street2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStreet2);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnInspection_Id = new DataColumn("Inspection_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnInspection_Id);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.MailingRow NewMailingRow() => (NewDataSet.MailingRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new NewDataSet.MailingRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (NewDataSet.MailingRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.MailingRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.MailingRowChangeEventHandler mailingRowChangedEvent = this.MailingRowChangedEvent;
      if (mailingRowChangedEvent == null)
        return;
      mailingRowChangedEvent((object) this, new NewDataSet.MailingRowChangeEvent((NewDataSet.MailingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.MailingRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.MailingRowChangeEventHandler rowChangingEvent = this.MailingRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new NewDataSet.MailingRowChangeEvent((NewDataSet.MailingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.MailingRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.MailingRowChangeEventHandler mailingRowDeletedEvent = this.MailingRowDeletedEvent;
      if (mailingRowDeletedEvent == null)
        return;
      mailingRowDeletedEvent((object) this, new NewDataSet.MailingRowChangeEvent((NewDataSet.MailingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.MailingRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.MailingRowChangeEventHandler rowDeletingEvent = this.MailingRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new NewDataSet.MailingRowChangeEvent((NewDataSet.MailingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveMailingRow(NewDataSet.MailingRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      NewDataSet newDataSet = new NewDataSet();
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
        FixedValue = newDataSet.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (MailingDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newDataSet.GetSchemaSerializable();
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
  public class PolicyHolderDataTable : TypedTableBase<NewDataSet.PolicyHolderRow>
  {
    private DataColumn columnCellPhone;
    private DataColumn columnHomePhone;
    private DataColumn columnPolicyHolderContact;
    private DataColumn columnPolicyHolderName;
    private DataColumn columnWorkPhone;
    private DataColumn columnInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public PolicyHolderDataTable()
    {
      this.TableName = "PolicyHolder";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal PolicyHolderDataTable(DataTable table)
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
    protected PolicyHolderDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CellPhoneColumn => this.columnCellPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn HomePhoneColumn => this.columnHomePhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PolicyHolderContactColumn => this.columnPolicyHolderContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PolicyHolderNameColumn => this.columnPolicyHolderName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn WorkPhoneColumn => this.columnWorkPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Inspection_IdColumn => this.columnInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.PolicyHolderRow this[int index]
    {
      get => (NewDataSet.PolicyHolderRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.PolicyHolderRowChangeEventHandler PolicyHolderRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.PolicyHolderRowChangeEventHandler PolicyHolderRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.PolicyHolderRowChangeEventHandler PolicyHolderRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.PolicyHolderRowChangeEventHandler PolicyHolderRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddPolicyHolderRow(NewDataSet.PolicyHolderRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.PolicyHolderRow AddPolicyHolderRow(
      string CellPhone,
      string HomePhone,
      string PolicyHolderContact,
      string PolicyHolderName,
      string WorkPhone,
      NewDataSet.InspectionRow parentInspectionRowByInspection_PolicyHolder)
    {
      NewDataSet.PolicyHolderRow row = (NewDataSet.PolicyHolderRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) CellPhone,
        (object) HomePhone,
        (object) PolicyHolderContact,
        (object) PolicyHolderName,
        (object) WorkPhone,
        null
      };
      if (parentInspectionRowByInspection_PolicyHolder != null)
        objArray[5] = RuntimeHelpers.GetObjectValue(parentInspectionRowByInspection_PolicyHolder[7]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      NewDataSet.PolicyHolderDataTable policyHolderDataTable = (NewDataSet.PolicyHolderDataTable) base.Clone();
      policyHolderDataTable.InitVars();
      return (DataTable) policyHolderDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new NewDataSet.PolicyHolderDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCellPhone = this.Columns["CellPhone"];
      this.columnHomePhone = this.Columns["HomePhone"];
      this.columnPolicyHolderContact = this.Columns["PolicyHolderContact"];
      this.columnPolicyHolderName = this.Columns["PolicyHolderName"];
      this.columnWorkPhone = this.Columns["WorkPhone"];
      this.columnInspection_Id = this.Columns["Inspection_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCellPhone = new DataColumn("CellPhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCellPhone);
      this.columnHomePhone = new DataColumn("HomePhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHomePhone);
      this.columnPolicyHolderContact = new DataColumn("PolicyHolderContact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyHolderContact);
      this.columnPolicyHolderName = new DataColumn("PolicyHolderName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyHolderName);
      this.columnWorkPhone = new DataColumn("WorkPhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWorkPhone);
      this.columnInspection_Id = new DataColumn("Inspection_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnInspection_Id);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.PolicyHolderRow NewPolicyHolderRow()
    {
      return (NewDataSet.PolicyHolderRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new NewDataSet.PolicyHolderRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (NewDataSet.PolicyHolderRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyHolderRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.PolicyHolderRowChangeEventHandler holderRowChangedEvent = this.PolicyHolderRowChangedEvent;
      if (holderRowChangedEvent == null)
        return;
      holderRowChangedEvent((object) this, new NewDataSet.PolicyHolderRowChangeEvent((NewDataSet.PolicyHolderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyHolderRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.PolicyHolderRowChangeEventHandler rowChangingEvent = this.PolicyHolderRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new NewDataSet.PolicyHolderRowChangeEvent((NewDataSet.PolicyHolderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyHolderRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.PolicyHolderRowChangeEventHandler holderRowDeletedEvent = this.PolicyHolderRowDeletedEvent;
      if (holderRowDeletedEvent == null)
        return;
      holderRowDeletedEvent((object) this, new NewDataSet.PolicyHolderRowChangeEvent((NewDataSet.PolicyHolderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyHolderRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.PolicyHolderRowChangeEventHandler rowDeletingEvent = this.PolicyHolderRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new NewDataSet.PolicyHolderRowChangeEvent((NewDataSet.PolicyHolderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovePolicyHolderRow(NewDataSet.PolicyHolderRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      NewDataSet newDataSet = new NewDataSet();
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
        FixedValue = newDataSet.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PolicyHolderDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newDataSet.GetSchemaSerializable();
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
  public class UnderwriterDataTable : TypedTableBase<NewDataSet.UnderwriterRow>
  {
    private DataColumn columnCorrespondanceEmail;
    private DataColumn columnFirstName;
    private DataColumn columnIgnoreDuplicate;
    private DataColumn columnLastName;
    private DataColumn columnPhone;
    private DataColumn columnReportEmail;
    private DataColumn columnUnderwriterCode;
    private DataColumn columnInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public UnderwriterDataTable()
    {
      this.TableName = "Underwriter";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal UnderwriterDataTable(DataTable table)
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
    protected UnderwriterDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CorrespondanceEmailColumn => this.columnCorrespondanceEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FirstNameColumn => this.columnFirstName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IgnoreDuplicateColumn => this.columnIgnoreDuplicate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LastNameColumn => this.columnLastName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PhoneColumn => this.columnPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ReportEmailColumn => this.columnReportEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UnderwriterCodeColumn => this.columnUnderwriterCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Inspection_IdColumn => this.columnInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.UnderwriterRow this[int index]
    {
      get => (NewDataSet.UnderwriterRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.UnderwriterRowChangeEventHandler UnderwriterRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.UnderwriterRowChangeEventHandler UnderwriterRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.UnderwriterRowChangeEventHandler UnderwriterRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.UnderwriterRowChangeEventHandler UnderwriterRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddUnderwriterRow(NewDataSet.UnderwriterRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.UnderwriterRow AddUnderwriterRow(
      string CorrespondanceEmail,
      string FirstName,
      bool IgnoreDuplicate,
      string LastName,
      string Phone,
      string ReportEmail,
      string UnderwriterCode,
      NewDataSet.InspectionRow parentInspectionRowByInspection_Underwriter)
    {
      NewDataSet.UnderwriterRow row = (NewDataSet.UnderwriterRow) this.NewRow();
      object[] objArray = new object[8]
      {
        (object) CorrespondanceEmail,
        (object) FirstName,
        (object) IgnoreDuplicate,
        (object) LastName,
        (object) Phone,
        (object) ReportEmail,
        (object) UnderwriterCode,
        null
      };
      if (parentInspectionRowByInspection_Underwriter != null)
        objArray[7] = RuntimeHelpers.GetObjectValue(parentInspectionRowByInspection_Underwriter[7]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      NewDataSet.UnderwriterDataTable underwriterDataTable = (NewDataSet.UnderwriterDataTable) base.Clone();
      underwriterDataTable.InitVars();
      return (DataTable) underwriterDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new NewDataSet.UnderwriterDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCorrespondanceEmail = this.Columns["CorrespondanceEmail"];
      this.columnFirstName = this.Columns["FirstName"];
      this.columnIgnoreDuplicate = this.Columns["IgnoreDuplicate"];
      this.columnLastName = this.Columns["LastName"];
      this.columnPhone = this.Columns["Phone"];
      this.columnReportEmail = this.Columns["ReportEmail"];
      this.columnUnderwriterCode = this.Columns["UnderwriterCode"];
      this.columnInspection_Id = this.Columns["Inspection_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCorrespondanceEmail = new DataColumn("CorrespondanceEmail", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCorrespondanceEmail);
      this.columnFirstName = new DataColumn("FirstName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirstName);
      this.columnIgnoreDuplicate = new DataColumn("IgnoreDuplicate", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIgnoreDuplicate);
      this.columnLastName = new DataColumn("LastName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLastName);
      this.columnPhone = new DataColumn("Phone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhone);
      this.columnReportEmail = new DataColumn("ReportEmail", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReportEmail);
      this.columnUnderwriterCode = new DataColumn("UnderwriterCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriterCode);
      this.columnInspection_Id = new DataColumn("Inspection_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnInspection_Id);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.UnderwriterRow NewUnderwriterRow()
    {
      return (NewDataSet.UnderwriterRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new NewDataSet.UnderwriterRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (NewDataSet.UnderwriterRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UnderwriterRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.UnderwriterRowChangeEventHandler underwriterRowChangedEvent = this.UnderwriterRowChangedEvent;
      if (underwriterRowChangedEvent == null)
        return;
      underwriterRowChangedEvent((object) this, new NewDataSet.UnderwriterRowChangeEvent((NewDataSet.UnderwriterRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UnderwriterRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.UnderwriterRowChangeEventHandler rowChangingEvent = this.UnderwriterRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new NewDataSet.UnderwriterRowChangeEvent((NewDataSet.UnderwriterRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UnderwriterRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.UnderwriterRowChangeEventHandler underwriterRowDeletedEvent = this.UnderwriterRowDeletedEvent;
      if (underwriterRowDeletedEvent == null)
        return;
      underwriterRowDeletedEvent((object) this, new NewDataSet.UnderwriterRowChangeEvent((NewDataSet.UnderwriterRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UnderwriterRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.UnderwriterRowChangeEventHandler rowDeletingEvent = this.UnderwriterRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new NewDataSet.UnderwriterRowChangeEvent((NewDataSet.UnderwriterRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveUnderwriterRow(NewDataSet.UnderwriterRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      NewDataSet newDataSet = new NewDataSet();
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
        FixedValue = newDataSet.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (UnderwriterDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newDataSet.GetSchemaSerializable();
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
  public class CredentialsDataTable : TypedTableBase<NewDataSet.CredentialsRow>
  {
    private DataColumn columnPassword;
    private DataColumn columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public CredentialsDataTable()
    {
      this.TableName = "Credentials";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal CredentialsDataTable(DataTable table)
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
    protected CredentialsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PasswordColumn => this.columnPassword;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.CredentialsRow this[int index]
    {
      get => (NewDataSet.CredentialsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.CredentialsRowChangeEventHandler CredentialsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.CredentialsRowChangeEventHandler CredentialsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.CredentialsRowChangeEventHandler CredentialsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.CredentialsRowChangeEventHandler CredentialsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddCredentialsRow(NewDataSet.CredentialsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.CredentialsRow AddCredentialsRow(string Password, string UserName)
    {
      NewDataSet.CredentialsRow row = (NewDataSet.CredentialsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Password,
        (object) UserName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      NewDataSet.CredentialsDataTable credentialsDataTable = (NewDataSet.CredentialsDataTable) base.Clone();
      credentialsDataTable.InitVars();
      return (DataTable) credentialsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new NewDataSet.CredentialsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnPassword = this.Columns["Password"];
      this.columnUserName = this.Columns["UserName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnPassword = new DataColumn("Password", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPassword);
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.CredentialsRow NewCredentialsRow()
    {
      return (NewDataSet.CredentialsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new NewDataSet.CredentialsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (NewDataSet.CredentialsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CredentialsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.CredentialsRowChangeEventHandler credentialsRowChangedEvent = this.CredentialsRowChangedEvent;
      if (credentialsRowChangedEvent == null)
        return;
      credentialsRowChangedEvent((object) this, new NewDataSet.CredentialsRowChangeEvent((NewDataSet.CredentialsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CredentialsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.CredentialsRowChangeEventHandler rowChangingEvent = this.CredentialsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new NewDataSet.CredentialsRowChangeEvent((NewDataSet.CredentialsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CredentialsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.CredentialsRowChangeEventHandler credentialsRowDeletedEvent = this.CredentialsRowDeletedEvent;
      if (credentialsRowDeletedEvent == null)
        return;
      credentialsRowDeletedEvent((object) this, new NewDataSet.CredentialsRowChangeEvent((NewDataSet.CredentialsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CredentialsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.CredentialsRowChangeEventHandler rowDeletingEvent = this.CredentialsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new NewDataSet.CredentialsRowChangeEvent((NewDataSet.CredentialsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveCredentialsRow(NewDataSet.CredentialsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      NewDataSet newDataSet = new NewDataSet();
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
        FixedValue = newDataSet.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CredentialsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newDataSet.GetSchemaSerializable();
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
  public class ArrayOfInspectionDataTable : TypedTableBase<NewDataSet.ArrayOfInspectionRow>
  {
    private DataColumn columnArrayOfInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ArrayOfInspectionDataTable()
    {
      this.TableName = "ArrayOfInspection";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ArrayOfInspectionDataTable(DataTable table)
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
    protected ArrayOfInspectionDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ArrayOfInspection_IdColumn => this.columnArrayOfInspection_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.ArrayOfInspectionRow this[int index]
    {
      get => (NewDataSet.ArrayOfInspectionRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.ArrayOfInspectionRowChangeEventHandler ArrayOfInspectionRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.ArrayOfInspectionRowChangeEventHandler ArrayOfInspectionRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.ArrayOfInspectionRowChangeEventHandler ArrayOfInspectionRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event NewDataSet.ArrayOfInspectionRowChangeEventHandler ArrayOfInspectionRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddArrayOfInspectionRow(NewDataSet.ArrayOfInspectionRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.ArrayOfInspectionRow AddArrayOfInspectionRow()
    {
      NewDataSet.ArrayOfInspectionRow row = (NewDataSet.ArrayOfInspectionRow) this.NewRow();
      object[] objArray = new object[1];
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      NewDataSet.ArrayOfInspectionDataTable inspectionDataTable = (NewDataSet.ArrayOfInspectionDataTable) base.Clone();
      inspectionDataTable.InitVars();
      return (DataTable) inspectionDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new NewDataSet.ArrayOfInspectionDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnArrayOfInspection_Id = this.Columns["ArrayOfInspection_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnArrayOfInspection_Id = new DataColumn("ArrayOfInspection_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnArrayOfInspection_Id);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnArrayOfInspection_Id
      }, true));
      this.columnArrayOfInspection_Id.AutoIncrement = true;
      this.columnArrayOfInspection_Id.AllowDBNull = false;
      this.columnArrayOfInspection_Id.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.ArrayOfInspectionRow NewArrayOfInspectionRow()
    {
      return (NewDataSet.ArrayOfInspectionRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new NewDataSet.ArrayOfInspectionRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (NewDataSet.ArrayOfInspectionRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ArrayOfInspectionRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.ArrayOfInspectionRowChangeEventHandler inspectionRowChangedEvent = this.ArrayOfInspectionRowChangedEvent;
      if (inspectionRowChangedEvent == null)
        return;
      inspectionRowChangedEvent((object) this, new NewDataSet.ArrayOfInspectionRowChangeEvent((NewDataSet.ArrayOfInspectionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ArrayOfInspectionRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.ArrayOfInspectionRowChangeEventHandler rowChangingEvent = this.ArrayOfInspectionRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new NewDataSet.ArrayOfInspectionRowChangeEvent((NewDataSet.ArrayOfInspectionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ArrayOfInspectionRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.ArrayOfInspectionRowChangeEventHandler inspectionRowDeletedEvent = this.ArrayOfInspectionRowDeletedEvent;
      if (inspectionRowDeletedEvent == null)
        return;
      inspectionRowDeletedEvent((object) this, new NewDataSet.ArrayOfInspectionRowChangeEvent((NewDataSet.ArrayOfInspectionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ArrayOfInspectionRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      NewDataSet.ArrayOfInspectionRowChangeEventHandler rowDeletingEvent = this.ArrayOfInspectionRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new NewDataSet.ArrayOfInspectionRowChangeEvent((NewDataSet.ArrayOfInspectionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveArrayOfInspectionRow(NewDataSet.ArrayOfInspectionRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      NewDataSet newDataSet = new NewDataSet();
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
        FixedValue = newDataSet.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ArrayOfInspectionDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newDataSet.GetSchemaSerializable();
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

  public class ImportInspectionsRequestRow : DataRow
  {
    private NewDataSet.ImportInspectionsRequestDataTable tableImportInspectionsRequest;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ImportInspectionsRequestRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableImportInspectionsRequest = (NewDataSet.ImportInspectionsRequestDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Password
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableImportInspectionsRequest.PasswordColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Password' in table 'ImportInspectionsRequest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableImportInspectionsRequest.PasswordColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string UserName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableImportInspectionsRequest.UserNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserName' in table 'ImportInspectionsRequest' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableImportInspectionsRequest.UserNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ImportInspectionsRequest_Id
    {
      get
      {
        return Conversions.ToInteger(this[this.tableImportInspectionsRequest.ImportInspectionsRequest_IdColumn]);
      }
      set
      {
        this[this.tableImportInspectionsRequest.ImportInspectionsRequest_IdColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPasswordNull() => this.IsNull(this.tableImportInspectionsRequest.PasswordColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPasswordNull()
    {
      this[this.tableImportInspectionsRequest.PasswordColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUserNameNull() => this.IsNull(this.tableImportInspectionsRequest.UserNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUserNameNull()
    {
      this[this.tableImportInspectionsRequest.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionsRow[] GetInspectionsRows()
    {
      return this.Table.ChildRelations["ImportInspectionsRequest_Inspections"] != null ? (NewDataSet.InspectionsRow[]) this.GetChildRows(this.Table.ChildRelations["ImportInspectionsRequest_Inspections"]) : new NewDataSet.InspectionsRow[0];
    }
  }

  public class InspectionsRow : DataRow
  {
    private NewDataSet.InspectionsDataTable tableInspections;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal InspectionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInspections = (NewDataSet.InspectionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Inspections_Id
    {
      get => Conversions.ToInteger(this[this.tableInspections.Inspections_IdColumn]);
      set => this[this.tableInspections.Inspections_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ImportInspectionsRequest_Id
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInspections.ImportInspectionsRequest_IdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ImportInspectionsRequest_Id' in table 'Inspections' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInspections.ImportInspectionsRequest_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.ImportInspectionsRequestRow ImportInspectionsRequestRow
    {
      get
      {
        return (NewDataSet.ImportInspectionsRequestRow) this.GetParentRow(this.Table.ParentRelations["ImportInspectionsRequest_Inspections"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["ImportInspectionsRequest_Inspections"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsImportInspectionsRequest_IdNull()
    {
      return this.IsNull(this.tableInspections.ImportInspectionsRequest_IdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetImportInspectionsRequest_IdNull()
    {
      this[this.tableInspections.ImportInspectionsRequest_IdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionRow[] GetInspectionRows()
    {
      return this.Table.ChildRelations["Inspections_Inspection"] != null ? (NewDataSet.InspectionRow[]) this.GetChildRows(this.Table.ChildRelations["Inspections_Inspection"]) : new NewDataSet.InspectionRow[0];
    }
  }

  public class InspectionRow : DataRow
  {
    private NewDataSet.InspectionDataTable tableInspection;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal InspectionRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInspection = (NewDataSet.InspectionDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CustomerKey
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInspection.CustomerKeyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CustomerKey' in table 'Inspection' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInspection.CustomerKeyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInspection.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'Inspection' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInspection.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IgnoreDuplicates
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableInspection.IgnoreDuplicatesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IgnoreDuplicates' in table 'Inspection' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInspection.IgnoreDuplicatesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string InspectionType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInspection.InspectionTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionType' in table 'Inspection' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInspection.InspectionTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRush
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableInspection.IsRushColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IsRush' in table 'Inspection' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInspection.IsRushColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Notes
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInspection.NotesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Notes' in table 'Inspection' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInspection.NotesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInspection.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'Inspection' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInspection.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Inspection_Id
    {
      get => Conversions.ToInteger(this[this.tableInspection.Inspection_IdColumn]);
      set => this[this.tableInspection.Inspection_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Inspections_Id
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInspection.Inspections_IdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Inspections_Id' in table 'Inspection' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInspection.Inspections_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ArrayOfInspection_Id
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInspection.ArrayOfInspection_IdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ArrayOfInspection_Id' in table 'Inspection' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInspection.ArrayOfInspection_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionsRow InspectionsRow
    {
      get
      {
        return (NewDataSet.InspectionsRow) this.GetParentRow(this.Table.ParentRelations["Inspections_Inspection"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["Inspections_Inspection"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.ArrayOfInspectionRow ArrayOfInspectionRow
    {
      get
      {
        return (NewDataSet.ArrayOfInspectionRow) this.GetParentRow(this.Table.ParentRelations["ArrayOfInspection_Inspection"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["ArrayOfInspection_Inspection"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCustomerKeyNull() => this.IsNull(this.tableInspection.CustomerKeyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCustomerKeyNull()
    {
      this[this.tableInspection.CustomerKeyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEffectiveDateNull() => this.IsNull(this.tableInspection.EffectiveDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tableInspection.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsIgnoreDuplicatesNull()
    {
      return this.IsNull(this.tableInspection.IgnoreDuplicatesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetIgnoreDuplicatesNull()
    {
      this[this.tableInspection.IgnoreDuplicatesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInspectionTypeNull() => this.IsNull(this.tableInspection.InspectionTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInspectionTypeNull()
    {
      this[this.tableInspection.InspectionTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsIsRushNull() => this.IsNull(this.tableInspection.IsRushColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetIsRushNull()
    {
      this[this.tableInspection.IsRushColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNotesNull() => this.IsNull(this.tableInspection.NotesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNotesNull()
    {
      this[this.tableInspection.NotesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tableInspection.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tableInspection.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInspections_IdNull() => this.IsNull(this.tableInspection.Inspections_IdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInspections_IdNull()
    {
      this[this.tableInspection.Inspections_IdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsArrayOfInspection_IdNull()
    {
      return this.IsNull(this.tableInspection.ArrayOfInspection_IdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetArrayOfInspection_IdNull()
    {
      this[this.tableInspection.ArrayOfInspection_IdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AgentRow[] GetAgentRows()
    {
      return this.Table.ChildRelations["Inspection_Agent"] != null ? (NewDataSet.AgentRow[]) this.GetChildRows(this.Table.ChildRelations["Inspection_Agent"]) : new NewDataSet.AgentRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AttributesRow[] GetAttributesRows()
    {
      return this.Table.ChildRelations["Inspection_Attributes"] != null ? (NewDataSet.AttributesRow[]) this.GetChildRows(this.Table.ChildRelations["Inspection_Attributes"]) : new NewDataSet.AttributesRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.LocationRow[] GetLocationRows()
    {
      return this.Table.ChildRelations["Inspection_Location"] != null ? (NewDataSet.LocationRow[]) this.GetChildRows(this.Table.ChildRelations["Inspection_Location"]) : new NewDataSet.LocationRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.MailingRow[] GetMailingRows()
    {
      return this.Table.ChildRelations["Inspection_Mailing"] != null ? (NewDataSet.MailingRow[]) this.GetChildRows(this.Table.ChildRelations["Inspection_Mailing"]) : new NewDataSet.MailingRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.PolicyHolderRow[] GetPolicyHolderRows()
    {
      return this.Table.ChildRelations["Inspection_PolicyHolder"] != null ? (NewDataSet.PolicyHolderRow[]) this.GetChildRows(this.Table.ChildRelations["Inspection_PolicyHolder"]) : new NewDataSet.PolicyHolderRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.UnderwriterRow[] GetUnderwriterRows()
    {
      return this.Table.ChildRelations["Inspection_Underwriter"] != null ? (NewDataSet.UnderwriterRow[]) this.GetChildRows(this.Table.ChildRelations["Inspection_Underwriter"]) : new NewDataSet.UnderwriterRow[0];
    }
  }

  public class AgentRow : DataRow
  {
    private NewDataSet.AgentDataTable tableAgent;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AgentRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAgent = (NewDataSet.AgentDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AgencyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAgent.AgencyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AgencyName' in table 'Agent' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAgent.AgencyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AgentCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAgent.AgentCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AgentCode' in table 'Agent' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAgent.AgentCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ContactEmail
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAgent.ContactEmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ContactEmail' in table 'Agent' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAgent.ContactEmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ContactName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAgent.ContactNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ContactName' in table 'Agent' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAgent.ContactNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Fax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAgent.FaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fax' in table 'Agent' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAgent.FaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Phone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAgent.PhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Phone' in table 'Agent' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAgent.PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Agent_Id
    {
      get => Conversions.ToInteger(this[this.tableAgent.Agent_IdColumn]);
      set => this[this.tableAgent.Agent_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Inspection_Id
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAgent.Inspection_IdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Inspection_Id' in table 'Agent' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAgent.Inspection_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionRow InspectionRow
    {
      get
      {
        return (NewDataSet.InspectionRow) this.GetParentRow(this.Table.ParentRelations["Inspection_Agent"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["Inspection_Agent"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAgencyNameNull() => this.IsNull(this.tableAgent.AgencyNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAgencyNameNull()
    {
      this[this.tableAgent.AgencyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAgentCodeNull() => this.IsNull(this.tableAgent.AgentCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAgentCodeNull()
    {
      this[this.tableAgent.AgentCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsContactEmailNull() => this.IsNull(this.tableAgent.ContactEmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetContactEmailNull()
    {
      this[this.tableAgent.ContactEmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsContactNameNull() => this.IsNull(this.tableAgent.ContactNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetContactNameNull()
    {
      this[this.tableAgent.ContactNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFaxNull() => this.IsNull(this.tableAgent.FaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFaxNull()
    {
      this[this.tableAgent.FaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPhoneNull() => this.IsNull(this.tableAgent.PhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPhoneNull()
    {
      this[this.tableAgent.PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInspection_IdNull() => this.IsNull(this.tableAgent.Inspection_IdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInspection_IdNull()
    {
      this[this.tableAgent.Inspection_IdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AddressRow[] GetAddressRows()
    {
      return this.Table.ChildRelations["Agent_Address"] != null ? (NewDataSet.AddressRow[]) this.GetChildRows(this.Table.ChildRelations["Agent_Address"]) : new NewDataSet.AddressRow[0];
    }
  }

  public class AddressRow : DataRow
  {
    private NewDataSet.AddressDataTable tableAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AddressRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAddress = (NewDataSet.AddressDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAddress.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'Address' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAddress.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateOrProvince
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAddress.StateOrProvinceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateOrProvince' in table 'Address' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAddress.StateOrProvinceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Street1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAddress.Street1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Street1' in table 'Address' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAddress.Street1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Street2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAddress.Street2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Street2' in table 'Address' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAddress.Street2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAddress.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'Address' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAddress.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Agent_Id
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAddress.Agent_IdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Agent_Id' in table 'Address' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAddress.Agent_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AgentRow AgentRow
    {
      get => (NewDataSet.AgentRow) this.GetParentRow(this.Table.ParentRelations["Agent_Address"]);
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["Agent_Address"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tableAddress.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCityNull()
    {
      this[this.tableAddress.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateOrProvinceNull() => this.IsNull(this.tableAddress.StateOrProvinceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateOrProvinceNull()
    {
      this[this.tableAddress.StateOrProvinceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStreet1Null() => this.IsNull(this.tableAddress.Street1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStreet1Null()
    {
      this[this.tableAddress.Street1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStreet2Null() => this.IsNull(this.tableAddress.Street2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStreet2Null()
    {
      this[this.tableAddress.Street2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tableAddress.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tableAddress.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAgent_IdNull() => this.IsNull(this.tableAddress.Agent_IdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAgent_IdNull()
    {
      this[this.tableAddress.Agent_IdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class AttributesRow : DataRow
  {
    private NewDataSet.AttributesDataTable tableAttributes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AttributesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAttributes = (NewDataSet.AttributesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal BuildingCost
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAttributes.BuildingCostColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BuildingCost' in table 'Attributes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAttributes.BuildingCostColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal BusinessTotalRevenue
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAttributes.BusinessTotalRevenueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BusinessTotalRevenue' in table 'Attributes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAttributes.BusinessTotalRevenueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BusinessType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAttributes.BusinessTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BusinessType' in table 'Attributes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAttributes.BusinessTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ContentsCost
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAttributes.ContentsCostColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ContentsCost' in table 'Attributes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAttributes.ContentsCostColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal CoverageAIn
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAttributes.CoverageAInColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CoverageAIn' in table 'Attributes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAttributes.CoverageAInColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string IsoClass
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAttributes.IsoClassColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IsoClass' in table 'Attributes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAttributes.IsoClassColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Occupancy
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAttributes.OccupancyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Occupancy' in table 'Attributes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAttributes.OccupancyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int YearBuilt
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAttributes.YearBuiltColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'YearBuilt' in table 'Attributes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAttributes.YearBuiltColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Inspection_Id
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAttributes.Inspection_IdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Inspection_Id' in table 'Attributes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAttributes.Inspection_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionRow InspectionRow
    {
      get
      {
        return (NewDataSet.InspectionRow) this.GetParentRow(this.Table.ParentRelations["Inspection_Attributes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["Inspection_Attributes"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBuildingCostNull() => this.IsNull(this.tableAttributes.BuildingCostColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBuildingCostNull()
    {
      this[this.tableAttributes.BuildingCostColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBusinessTotalRevenueNull()
    {
      return this.IsNull(this.tableAttributes.BusinessTotalRevenueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBusinessTotalRevenueNull()
    {
      this[this.tableAttributes.BusinessTotalRevenueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBusinessTypeNull() => this.IsNull(this.tableAttributes.BusinessTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBusinessTypeNull()
    {
      this[this.tableAttributes.BusinessTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsContentsCostNull() => this.IsNull(this.tableAttributes.ContentsCostColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetContentsCostNull()
    {
      this[this.tableAttributes.ContentsCostColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCoverageAInNull() => this.IsNull(this.tableAttributes.CoverageAInColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCoverageAInNull()
    {
      this[this.tableAttributes.CoverageAInColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsIsoClassNull() => this.IsNull(this.tableAttributes.IsoClassColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetIsoClassNull()
    {
      this[this.tableAttributes.IsoClassColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOccupancyNull() => this.IsNull(this.tableAttributes.OccupancyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOccupancyNull()
    {
      this[this.tableAttributes.OccupancyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsYearBuiltNull() => this.IsNull(this.tableAttributes.YearBuiltColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetYearBuiltNull()
    {
      this[this.tableAttributes.YearBuiltColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInspection_IdNull() => this.IsNull(this.tableAttributes.Inspection_IdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInspection_IdNull()
    {
      this[this.tableAttributes.Inspection_IdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class LocationRow : DataRow
  {
    private NewDataSet.LocationDataTable tableLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal LocationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableLocation = (NewDataSet.LocationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableLocation.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'Location' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLocation.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateOrProvince
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableLocation.StateOrProvinceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateOrProvince' in table 'Location' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLocation.StateOrProvinceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Street1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableLocation.Street1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Street1' in table 'Location' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLocation.Street1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Street2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableLocation.Street2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Street2' in table 'Location' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLocation.Street2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableLocation.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'Location' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLocation.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Inspection_Id
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableLocation.Inspection_IdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Inspection_Id' in table 'Location' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLocation.Inspection_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionRow InspectionRow
    {
      get
      {
        return (NewDataSet.InspectionRow) this.GetParentRow(this.Table.ParentRelations["Inspection_Location"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["Inspection_Location"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tableLocation.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCityNull()
    {
      this[this.tableLocation.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateOrProvinceNull() => this.IsNull(this.tableLocation.StateOrProvinceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateOrProvinceNull()
    {
      this[this.tableLocation.StateOrProvinceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStreet1Null() => this.IsNull(this.tableLocation.Street1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStreet1Null()
    {
      this[this.tableLocation.Street1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStreet2Null() => this.IsNull(this.tableLocation.Street2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStreet2Null()
    {
      this[this.tableLocation.Street2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tableLocation.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tableLocation.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInspection_IdNull() => this.IsNull(this.tableLocation.Inspection_IdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInspection_IdNull()
    {
      this[this.tableLocation.Inspection_IdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class MailingRow : DataRow
  {
    private NewDataSet.MailingDataTable tableMailing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal MailingRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableMailing = (NewDataSet.MailingDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableMailing.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'Mailing' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMailing.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateOrProvince
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableMailing.StateOrProvinceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateOrProvince' in table 'Mailing' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMailing.StateOrProvinceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Street1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableMailing.Street1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Street1' in table 'Mailing' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMailing.Street1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Street2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableMailing.Street2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Street2' in table 'Mailing' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMailing.Street2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableMailing.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'Mailing' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMailing.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Inspection_Id
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableMailing.Inspection_IdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Inspection_Id' in table 'Mailing' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMailing.Inspection_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionRow InspectionRow
    {
      get
      {
        return (NewDataSet.InspectionRow) this.GetParentRow(this.Table.ParentRelations["Inspection_Mailing"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["Inspection_Mailing"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tableMailing.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCityNull()
    {
      this[this.tableMailing.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateOrProvinceNull() => this.IsNull(this.tableMailing.StateOrProvinceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateOrProvinceNull()
    {
      this[this.tableMailing.StateOrProvinceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStreet1Null() => this.IsNull(this.tableMailing.Street1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStreet1Null()
    {
      this[this.tableMailing.Street1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStreet2Null() => this.IsNull(this.tableMailing.Street2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStreet2Null()
    {
      this[this.tableMailing.Street2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tableMailing.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tableMailing.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInspection_IdNull() => this.IsNull(this.tableMailing.Inspection_IdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInspection_IdNull()
    {
      this[this.tableMailing.Inspection_IdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class PolicyHolderRow : DataRow
  {
    private NewDataSet.PolicyHolderDataTable tablePolicyHolder;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal PolicyHolderRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePolicyHolder = (NewDataSet.PolicyHolderDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CellPhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyHolder.CellPhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CellPhone' in table 'PolicyHolder' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHolder.CellPhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string HomePhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyHolder.HomePhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'HomePhone' in table 'PolicyHolder' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHolder.HomePhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PolicyHolderContact
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyHolder.PolicyHolderContactColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyHolderContact' in table 'PolicyHolder' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHolder.PolicyHolderContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PolicyHolderName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyHolder.PolicyHolderNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyHolderName' in table 'PolicyHolder' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHolder.PolicyHolderNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string WorkPhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyHolder.WorkPhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WorkPhone' in table 'PolicyHolder' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHolder.WorkPhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Inspection_Id
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePolicyHolder.Inspection_IdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Inspection_Id' in table 'PolicyHolder' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHolder.Inspection_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionRow InspectionRow
    {
      get
      {
        return (NewDataSet.InspectionRow) this.GetParentRow(this.Table.ParentRelations["Inspection_PolicyHolder"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["Inspection_PolicyHolder"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCellPhoneNull() => this.IsNull(this.tablePolicyHolder.CellPhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCellPhoneNull()
    {
      this[this.tablePolicyHolder.CellPhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsHomePhoneNull() => this.IsNull(this.tablePolicyHolder.HomePhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetHomePhoneNull()
    {
      this[this.tablePolicyHolder.HomePhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicyHolderContactNull()
    {
      return this.IsNull(this.tablePolicyHolder.PolicyHolderContactColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicyHolderContactNull()
    {
      this[this.tablePolicyHolder.PolicyHolderContactColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicyHolderNameNull()
    {
      return this.IsNull(this.tablePolicyHolder.PolicyHolderNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicyHolderNameNull()
    {
      this[this.tablePolicyHolder.PolicyHolderNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsWorkPhoneNull() => this.IsNull(this.tablePolicyHolder.WorkPhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetWorkPhoneNull()
    {
      this[this.tablePolicyHolder.WorkPhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInspection_IdNull() => this.IsNull(this.tablePolicyHolder.Inspection_IdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInspection_IdNull()
    {
      this[this.tablePolicyHolder.Inspection_IdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class UnderwriterRow : DataRow
  {
    private NewDataSet.UnderwriterDataTable tableUnderwriter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal UnderwriterRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableUnderwriter = (NewDataSet.UnderwriterDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CorrespondanceEmail
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUnderwriter.CorrespondanceEmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CorrespondanceEmail' in table 'Underwriter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUnderwriter.CorrespondanceEmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FirstName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUnderwriter.FirstNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FirstName' in table 'Underwriter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUnderwriter.FirstNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IgnoreDuplicate
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableUnderwriter.IgnoreDuplicateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IgnoreDuplicate' in table 'Underwriter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUnderwriter.IgnoreDuplicateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LastName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUnderwriter.LastNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LastName' in table 'Underwriter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUnderwriter.LastNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Phone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUnderwriter.PhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Phone' in table 'Underwriter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUnderwriter.PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ReportEmail
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUnderwriter.ReportEmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ReportEmail' in table 'Underwriter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUnderwriter.ReportEmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string UnderwriterCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUnderwriter.UnderwriterCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnderwriterCode' in table 'Underwriter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUnderwriter.UnderwriterCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Inspection_Id
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableUnderwriter.Inspection_IdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Inspection_Id' in table 'Underwriter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUnderwriter.Inspection_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionRow InspectionRow
    {
      get
      {
        return (NewDataSet.InspectionRow) this.GetParentRow(this.Table.ParentRelations["Inspection_Underwriter"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["Inspection_Underwriter"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCorrespondanceEmailNull()
    {
      return this.IsNull(this.tableUnderwriter.CorrespondanceEmailColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCorrespondanceEmailNull()
    {
      this[this.tableUnderwriter.CorrespondanceEmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFirstNameNull() => this.IsNull(this.tableUnderwriter.FirstNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFirstNameNull()
    {
      this[this.tableUnderwriter.FirstNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsIgnoreDuplicateNull() => this.IsNull(this.tableUnderwriter.IgnoreDuplicateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetIgnoreDuplicateNull()
    {
      this[this.tableUnderwriter.IgnoreDuplicateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLastNameNull() => this.IsNull(this.tableUnderwriter.LastNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLastNameNull()
    {
      this[this.tableUnderwriter.LastNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPhoneNull() => this.IsNull(this.tableUnderwriter.PhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPhoneNull()
    {
      this[this.tableUnderwriter.PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsReportEmailNull() => this.IsNull(this.tableUnderwriter.ReportEmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetReportEmailNull()
    {
      this[this.tableUnderwriter.ReportEmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnderwriterCodeNull() => this.IsNull(this.tableUnderwriter.UnderwriterCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnderwriterCodeNull()
    {
      this[this.tableUnderwriter.UnderwriterCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInspection_IdNull() => this.IsNull(this.tableUnderwriter.Inspection_IdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInspection_IdNull()
    {
      this[this.tableUnderwriter.Inspection_IdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class CredentialsRow : DataRow
  {
    private NewDataSet.CredentialsDataTable tableCredentials;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal CredentialsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCredentials = (NewDataSet.CredentialsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Password
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCredentials.PasswordColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Password' in table 'Credentials' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCredentials.PasswordColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string UserName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCredentials.UserNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserName' in table 'Credentials' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCredentials.UserNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPasswordNull() => this.IsNull(this.tableCredentials.PasswordColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPasswordNull()
    {
      this[this.tableCredentials.PasswordColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUserNameNull() => this.IsNull(this.tableCredentials.UserNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUserNameNull()
    {
      this[this.tableCredentials.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class ArrayOfInspectionRow : DataRow
  {
    private NewDataSet.ArrayOfInspectionDataTable tableArrayOfInspection;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ArrayOfInspectionRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableArrayOfInspection = (NewDataSet.ArrayOfInspectionDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ArrayOfInspection_Id
    {
      get => Conversions.ToInteger(this[this.tableArrayOfInspection.ArrayOfInspection_IdColumn]);
      set => this[this.tableArrayOfInspection.ArrayOfInspection_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionRow[] GetInspectionRows()
    {
      return this.Table.ChildRelations["ArrayOfInspection_Inspection"] != null ? (NewDataSet.InspectionRow[]) this.GetChildRows(this.Table.ChildRelations["ArrayOfInspection_Inspection"]) : new NewDataSet.InspectionRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class ImportInspectionsRequestRowChangeEvent : EventArgs
  {
    private NewDataSet.ImportInspectionsRequestRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ImportInspectionsRequestRowChangeEvent(
      NewDataSet.ImportInspectionsRequestRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.ImportInspectionsRequestRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class InspectionsRowChangeEvent : EventArgs
  {
    private NewDataSet.InspectionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InspectionsRowChangeEvent(NewDataSet.InspectionsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class InspectionRowChangeEvent : EventArgs
  {
    private NewDataSet.InspectionRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InspectionRowChangeEvent(NewDataSet.InspectionRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.InspectionRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class AgentRowChangeEvent : EventArgs
  {
    private NewDataSet.AgentRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AgentRowChangeEvent(NewDataSet.AgentRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AgentRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class AddressRowChangeEvent : EventArgs
  {
    private NewDataSet.AddressRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AddressRowChangeEvent(NewDataSet.AddressRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AddressRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class AttributesRowChangeEvent : EventArgs
  {
    private NewDataSet.AttributesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AttributesRowChangeEvent(NewDataSet.AttributesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.AttributesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class LocationRowChangeEvent : EventArgs
  {
    private NewDataSet.LocationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public LocationRowChangeEvent(NewDataSet.LocationRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.LocationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class MailingRowChangeEvent : EventArgs
  {
    private NewDataSet.MailingRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public MailingRowChangeEvent(NewDataSet.MailingRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.MailingRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class PolicyHolderRowChangeEvent : EventArgs
  {
    private NewDataSet.PolicyHolderRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public PolicyHolderRowChangeEvent(NewDataSet.PolicyHolderRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.PolicyHolderRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class UnderwriterRowChangeEvent : EventArgs
  {
    private NewDataSet.UnderwriterRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public UnderwriterRowChangeEvent(NewDataSet.UnderwriterRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.UnderwriterRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class CredentialsRowChangeEvent : EventArgs
  {
    private NewDataSet.CredentialsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public CredentialsRowChangeEvent(NewDataSet.CredentialsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.CredentialsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class ArrayOfInspectionRowChangeEvent : EventArgs
  {
    private NewDataSet.ArrayOfInspectionRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ArrayOfInspectionRowChangeEvent(
      NewDataSet.ArrayOfInspectionRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NewDataSet.ArrayOfInspectionRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
