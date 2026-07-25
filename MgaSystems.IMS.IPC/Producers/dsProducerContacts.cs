// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.dsProducerContacts
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
[XmlRoot("dsProducerContacts")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsProducerContacts : DataSet
{
  private dsProducerContacts.tblProducerContactsDataTable tabletblProducerContacts;
  private dsProducerContacts.lstProducerSpecialContactTypesDataTable tablelstProducerSpecialContactTypes;
  private dsProducerContacts.lstDeliveryMethodDataTable tablelstDeliveryMethod;
  private dsProducerContacts.lstStatusDataTable tablelstStatus;
  private dsProducerContacts.tblProducerSpecialContactsDataTable tabletblProducerSpecialContacts;
  private dsProducerContacts.lstSalutationsDataTable tablelstSalutations;
  private dsProducerContacts.lstProducerContactInterestsDataTable tablelstProducerContactInterests;
  private dsProducerContacts.lstProducerContactJobFunctionDataTable tablelstProducerContactJobFunction;
  private dsProducerContacts.tblProducerContactInterestsDataTable tabletblProducerContactInterests;
  private dsProducerContacts.tblProducerContactJobFunctionsDataTable tabletblProducerContactJobFunctions;
  private dsProducerContacts.tblProducerContactsCopyDataTable tabletblProducerContactsCopy;
  private DataRelation relationlstDeliveryMethodtblProducerContacts;
  private DataRelation relationlstStatustblProducerContacts;
  private DataRelation relationlstSalutationstblProducerContacts;
  private DataRelation relationlstProducerSpecialContactTypestblProducerSpecialContacts;
  private DataRelation relationtblProducerContactstblProducerSpecialContacts;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsProducerContacts()
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
  protected dsProducerContacts(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblProducerContacts)] != null)
          base.Tables.Add((DataTable) new dsProducerContacts.tblProducerContactsDataTable(dataSet.Tables[nameof (tblProducerContacts)]));
        if (dataSet.Tables[nameof (lstProducerSpecialContactTypes)] != null)
          base.Tables.Add((DataTable) new dsProducerContacts.lstProducerSpecialContactTypesDataTable(dataSet.Tables[nameof (lstProducerSpecialContactTypes)]));
        if (dataSet.Tables[nameof (lstDeliveryMethod)] != null)
          base.Tables.Add((DataTable) new dsProducerContacts.lstDeliveryMethodDataTable(dataSet.Tables[nameof (lstDeliveryMethod)]));
        if (dataSet.Tables[nameof (lstStatus)] != null)
          base.Tables.Add((DataTable) new dsProducerContacts.lstStatusDataTable(dataSet.Tables[nameof (lstStatus)]));
        if (dataSet.Tables[nameof (tblProducerSpecialContacts)] != null)
          base.Tables.Add((DataTable) new dsProducerContacts.tblProducerSpecialContactsDataTable(dataSet.Tables[nameof (tblProducerSpecialContacts)]));
        if (dataSet.Tables[nameof (lstSalutations)] != null)
          base.Tables.Add((DataTable) new dsProducerContacts.lstSalutationsDataTable(dataSet.Tables[nameof (lstSalutations)]));
        if (dataSet.Tables[nameof (lstProducerContactInterests)] != null)
          base.Tables.Add((DataTable) new dsProducerContacts.lstProducerContactInterestsDataTable(dataSet.Tables[nameof (lstProducerContactInterests)]));
        if (dataSet.Tables[nameof (lstProducerContactJobFunction)] != null)
          base.Tables.Add((DataTable) new dsProducerContacts.lstProducerContactJobFunctionDataTable(dataSet.Tables[nameof (lstProducerContactJobFunction)]));
        if (dataSet.Tables[nameof (tblProducerContactInterests)] != null)
          base.Tables.Add((DataTable) new dsProducerContacts.tblProducerContactInterestsDataTable(dataSet.Tables[nameof (tblProducerContactInterests)]));
        if (dataSet.Tables[nameof (tblProducerContactJobFunctions)] != null)
          base.Tables.Add((DataTable) new dsProducerContacts.tblProducerContactJobFunctionsDataTable(dataSet.Tables[nameof (tblProducerContactJobFunctions)]));
        if (dataSet.Tables[nameof (tblProducerContactsCopy)] != null)
          base.Tables.Add((DataTable) new dsProducerContacts.tblProducerContactsCopyDataTable(dataSet.Tables[nameof (tblProducerContactsCopy)]));
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
  public dsProducerContacts.tblProducerContactsDataTable tblProducerContacts
  {
    get => this.tabletblProducerContacts;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducerContacts.lstProducerSpecialContactTypesDataTable lstProducerSpecialContactTypes
  {
    get => this.tablelstProducerSpecialContactTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducerContacts.lstDeliveryMethodDataTable lstDeliveryMethod
  {
    get => this.tablelstDeliveryMethod;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducerContacts.lstStatusDataTable lstStatus => this.tablelstStatus;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducerContacts.tblProducerSpecialContactsDataTable tblProducerSpecialContacts
  {
    get => this.tabletblProducerSpecialContacts;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducerContacts.lstSalutationsDataTable lstSalutations => this.tablelstSalutations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducerContacts.lstProducerContactInterestsDataTable lstProducerContactInterests
  {
    get => this.tablelstProducerContactInterests;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducerContacts.lstProducerContactJobFunctionDataTable lstProducerContactJobFunction
  {
    get => this.tablelstProducerContactJobFunction;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducerContacts.tblProducerContactInterestsDataTable tblProducerContactInterests
  {
    get => this.tabletblProducerContactInterests;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducerContacts.tblProducerContactJobFunctionsDataTable tblProducerContactJobFunctions
  {
    get => this.tabletblProducerContactJobFunctions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducerContacts.tblProducerContactsCopyDataTable tblProducerContactsCopy
  {
    get => this.tabletblProducerContactsCopy;
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
    dsProducerContacts producerContacts = (dsProducerContacts) base.Clone();
    producerContacts.InitVars();
    producerContacts.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) producerContacts;
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
      if (dataSet.Tables["tblProducerContacts"] != null)
        base.Tables.Add((DataTable) new dsProducerContacts.tblProducerContactsDataTable(dataSet.Tables["tblProducerContacts"]));
      if (dataSet.Tables["lstProducerSpecialContactTypes"] != null)
        base.Tables.Add((DataTable) new dsProducerContacts.lstProducerSpecialContactTypesDataTable(dataSet.Tables["lstProducerSpecialContactTypes"]));
      if (dataSet.Tables["lstDeliveryMethod"] != null)
        base.Tables.Add((DataTable) new dsProducerContacts.lstDeliveryMethodDataTable(dataSet.Tables["lstDeliveryMethod"]));
      if (dataSet.Tables["lstStatus"] != null)
        base.Tables.Add((DataTable) new dsProducerContacts.lstStatusDataTable(dataSet.Tables["lstStatus"]));
      if (dataSet.Tables["tblProducerSpecialContacts"] != null)
        base.Tables.Add((DataTable) new dsProducerContacts.tblProducerSpecialContactsDataTable(dataSet.Tables["tblProducerSpecialContacts"]));
      if (dataSet.Tables["lstSalutations"] != null)
        base.Tables.Add((DataTable) new dsProducerContacts.lstSalutationsDataTable(dataSet.Tables["lstSalutations"]));
      if (dataSet.Tables["lstProducerContactInterests"] != null)
        base.Tables.Add((DataTable) new dsProducerContacts.lstProducerContactInterestsDataTable(dataSet.Tables["lstProducerContactInterests"]));
      if (dataSet.Tables["lstProducerContactJobFunction"] != null)
        base.Tables.Add((DataTable) new dsProducerContacts.lstProducerContactJobFunctionDataTable(dataSet.Tables["lstProducerContactJobFunction"]));
      if (dataSet.Tables["tblProducerContactInterests"] != null)
        base.Tables.Add((DataTable) new dsProducerContacts.tblProducerContactInterestsDataTable(dataSet.Tables["tblProducerContactInterests"]));
      if (dataSet.Tables["tblProducerContactJobFunctions"] != null)
        base.Tables.Add((DataTable) new dsProducerContacts.tblProducerContactJobFunctionsDataTable(dataSet.Tables["tblProducerContactJobFunctions"]));
      if (dataSet.Tables["tblProducerContactsCopy"] != null)
        base.Tables.Add((DataTable) new dsProducerContacts.tblProducerContactsCopyDataTable(dataSet.Tables["tblProducerContactsCopy"]));
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
    this.tabletblProducerContacts = (dsProducerContacts.tblProducerContactsDataTable) base.Tables["tblProducerContacts"];
    if (initTable && this.tabletblProducerContacts != null)
      this.tabletblProducerContacts.InitVars();
    this.tablelstProducerSpecialContactTypes = (dsProducerContacts.lstProducerSpecialContactTypesDataTable) base.Tables["lstProducerSpecialContactTypes"];
    if (initTable && this.tablelstProducerSpecialContactTypes != null)
      this.tablelstProducerSpecialContactTypes.InitVars();
    this.tablelstDeliveryMethod = (dsProducerContacts.lstDeliveryMethodDataTable) base.Tables["lstDeliveryMethod"];
    if (initTable && this.tablelstDeliveryMethod != null)
      this.tablelstDeliveryMethod.InitVars();
    this.tablelstStatus = (dsProducerContacts.lstStatusDataTable) base.Tables["lstStatus"];
    if (initTable && this.tablelstStatus != null)
      this.tablelstStatus.InitVars();
    this.tabletblProducerSpecialContacts = (dsProducerContacts.tblProducerSpecialContactsDataTable) base.Tables["tblProducerSpecialContacts"];
    if (initTable && this.tabletblProducerSpecialContacts != null)
      this.tabletblProducerSpecialContacts.InitVars();
    this.tablelstSalutations = (dsProducerContacts.lstSalutationsDataTable) base.Tables["lstSalutations"];
    if (initTable && this.tablelstSalutations != null)
      this.tablelstSalutations.InitVars();
    this.tablelstProducerContactInterests = (dsProducerContacts.lstProducerContactInterestsDataTable) base.Tables["lstProducerContactInterests"];
    if (initTable && this.tablelstProducerContactInterests != null)
      this.tablelstProducerContactInterests.InitVars();
    this.tablelstProducerContactJobFunction = (dsProducerContacts.lstProducerContactJobFunctionDataTable) base.Tables["lstProducerContactJobFunction"];
    if (initTable && this.tablelstProducerContactJobFunction != null)
      this.tablelstProducerContactJobFunction.InitVars();
    this.tabletblProducerContactInterests = (dsProducerContacts.tblProducerContactInterestsDataTable) base.Tables["tblProducerContactInterests"];
    if (initTable && this.tabletblProducerContactInterests != null)
      this.tabletblProducerContactInterests.InitVars();
    this.tabletblProducerContactJobFunctions = (dsProducerContacts.tblProducerContactJobFunctionsDataTable) base.Tables["tblProducerContactJobFunctions"];
    if (initTable && this.tabletblProducerContactJobFunctions != null)
      this.tabletblProducerContactJobFunctions.InitVars();
    this.tabletblProducerContactsCopy = (dsProducerContacts.tblProducerContactsCopyDataTable) base.Tables["tblProducerContactsCopy"];
    if (initTable && this.tabletblProducerContactsCopy != null)
      this.tabletblProducerContactsCopy.InitVars();
    this.relationlstDeliveryMethodtblProducerContacts = this.Relations["lstDeliveryMethodtblProducerContacts"];
    this.relationlstStatustblProducerContacts = this.Relations["lstStatustblProducerContacts"];
    this.relationlstSalutationstblProducerContacts = this.Relations["lstSalutationstblProducerContacts"];
    this.relationlstProducerSpecialContactTypestblProducerSpecialContacts = this.Relations["lstProducerSpecialContactTypestblProducerSpecialContacts"];
    this.relationtblProducerContactstblProducerSpecialContacts = this.Relations["tblProducerContactstblProducerSpecialContacts"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsProducerContacts);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsProducerContacts.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblProducerContacts = new dsProducerContacts.tblProducerContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerContacts);
    this.tablelstProducerSpecialContactTypes = new dsProducerContacts.lstProducerSpecialContactTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstProducerSpecialContactTypes);
    this.tablelstDeliveryMethod = new dsProducerContacts.lstDeliveryMethodDataTable();
    base.Tables.Add((DataTable) this.tablelstDeliveryMethod);
    this.tablelstStatus = new dsProducerContacts.lstStatusDataTable();
    base.Tables.Add((DataTable) this.tablelstStatus);
    this.tabletblProducerSpecialContacts = new dsProducerContacts.tblProducerSpecialContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerSpecialContacts);
    this.tablelstSalutations = new dsProducerContacts.lstSalutationsDataTable();
    base.Tables.Add((DataTable) this.tablelstSalutations);
    this.tablelstProducerContactInterests = new dsProducerContacts.lstProducerContactInterestsDataTable();
    base.Tables.Add((DataTable) this.tablelstProducerContactInterests);
    this.tablelstProducerContactJobFunction = new dsProducerContacts.lstProducerContactJobFunctionDataTable();
    base.Tables.Add((DataTable) this.tablelstProducerContactJobFunction);
    this.tabletblProducerContactInterests = new dsProducerContacts.tblProducerContactInterestsDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerContactInterests);
    this.tabletblProducerContactJobFunctions = new dsProducerContacts.tblProducerContactJobFunctionsDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerContactJobFunctions);
    this.tabletblProducerContactsCopy = new dsProducerContacts.tblProducerContactsCopyDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerContactsCopy);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("lstDeliveryMethodtblProducerContacts", new DataColumn[1]
    {
      this.tablelstDeliveryMethod.DeliveryMethodIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerContacts.DeliveryMethodIDColumn
    });
    this.tabletblProducerContacts.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstStatustblProducerContacts", new DataColumn[1]
    {
      this.tablelstStatus.StatusIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerContacts.StatusIDColumn
    });
    this.tabletblProducerContacts.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("lstSalutationstblProducerContacts", new DataColumn[1]
    {
      this.tablelstSalutations.SalutationColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerContacts.SalutationColumn
    });
    this.tabletblProducerContacts.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("lstProducerSpecialContactTypestblProducerSpecialContacts", new DataColumn[1]
    {
      this.tablelstProducerSpecialContactTypes.SpecialContactTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerSpecialContacts.SpecialContactTypeIDColumn
    });
    this.tabletblProducerSpecialContacts.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint5 = new ForeignKeyConstraint("tblProducerContactstblProducerSpecialContacts", new DataColumn[1]
    {
      this.tabletblProducerContacts.ProducerContactGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerSpecialContacts.ProducerContactGUIDColumn
    });
    this.tabletblProducerSpecialContacts.Constraints.Add((Constraint) foreignKeyConstraint5);
    foreignKeyConstraint5.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint5.DeleteRule = Rule.Cascade;
    foreignKeyConstraint5.UpdateRule = Rule.Cascade;
    this.relationlstDeliveryMethodtblProducerContacts = new DataRelation("lstDeliveryMethodtblProducerContacts", new DataColumn[1]
    {
      this.tablelstDeliveryMethod.DeliveryMethodIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerContacts.DeliveryMethodIDColumn
    }, false);
    this.Relations.Add(this.relationlstDeliveryMethodtblProducerContacts);
    this.relationlstStatustblProducerContacts = new DataRelation("lstStatustblProducerContacts", new DataColumn[1]
    {
      this.tablelstStatus.StatusIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerContacts.StatusIDColumn
    }, false);
    this.Relations.Add(this.relationlstStatustblProducerContacts);
    this.relationlstSalutationstblProducerContacts = new DataRelation("lstSalutationstblProducerContacts", new DataColumn[1]
    {
      this.tablelstSalutations.SalutationColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerContacts.SalutationColumn
    }, false);
    this.Relations.Add(this.relationlstSalutationstblProducerContacts);
    this.relationlstProducerSpecialContactTypestblProducerSpecialContacts = new DataRelation("lstProducerSpecialContactTypestblProducerSpecialContacts", new DataColumn[1]
    {
      this.tablelstProducerSpecialContactTypes.SpecialContactTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerSpecialContacts.SpecialContactTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstProducerSpecialContactTypestblProducerSpecialContacts);
    this.relationtblProducerContactstblProducerSpecialContacts = new DataRelation("tblProducerContactstblProducerSpecialContacts", new DataColumn[1]
    {
      this.tabletblProducerContacts.ProducerContactGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerSpecialContacts.ProducerContactGUIDColumn
    }, false);
    this.Relations.Add(this.relationtblProducerContactstblProducerSpecialContacts);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblProducerContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstProducerSpecialContactTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstDeliveryMethod() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstStatus() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblProducerSpecialContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstSalutations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstProducerContactInterests() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstProducerContactJobFunction() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblProducerContactInterests() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblProducerContactJobFunctions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblProducerContactsCopy() => false;

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
    dsProducerContacts producerContacts = new dsProducerContacts();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = producerContacts.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = producerContacts.GetSchemaSerializable();
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
  public delegate void tblProducerContactsRowChangeEventHandler(
    object sender,
    dsProducerContacts.tblProducerContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstProducerSpecialContactTypesRowChangeEventHandler(
    object sender,
    dsProducerContacts.lstProducerSpecialContactTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstDeliveryMethodRowChangeEventHandler(
    object sender,
    dsProducerContacts.lstDeliveryMethodRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstStatusRowChangeEventHandler(
    object sender,
    dsProducerContacts.lstStatusRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblProducerSpecialContactsRowChangeEventHandler(
    object sender,
    dsProducerContacts.tblProducerSpecialContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstSalutationsRowChangeEventHandler(
    object sender,
    dsProducerContacts.lstSalutationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstProducerContactInterestsRowChangeEventHandler(
    object sender,
    dsProducerContacts.lstProducerContactInterestsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstProducerContactJobFunctionRowChangeEventHandler(
    object sender,
    dsProducerContacts.lstProducerContactJobFunctionRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblProducerContactInterestsRowChangeEventHandler(
    object sender,
    dsProducerContacts.tblProducerContactInterestsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblProducerContactJobFunctionsRowChangeEventHandler(
    object sender,
    dsProducerContacts.tblProducerContactJobFunctionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblProducerContactsCopyRowChangeEventHandler(
    object sender,
    dsProducerContacts.tblProducerContactsCopyRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblProducerContactsDataTable : 
    TypedTableBase<dsProducerContacts.tblProducerContactsRow>
  {
    private DataColumn columnProducerContactID;
    private DataColumn columnProducerContactGUID;
    private DataColumn columnProducerLocationGUID;
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
    private DataColumn columnSSNo;
    private DataColumn columnReq1099;
    private DataColumn columnFax;
    private DataColumn columnOptOut;
    private DataColumn columnAddByUserID;
    private DataColumn columnDateAdded;
    private DataColumn columnDateModified;
    private DataColumn columnEmailEditedBy;
    private DataColumn columnDateEmailEdited;
    private DataColumn columnManagedBy;
    private DataColumn columnNPNNo;
    private DataColumn columnISOCountryCode;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnStateID;
    private DataColumn columnZipCode;
    private DataColumn columnZipPlus;
    private DataColumn columnCounty;
    private DataColumn columnDOB;
    private DataColumn columnCEWaived;
    private DataColumn columnComment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerContactsDataTable()
    {
      this.TableName = "tblProducerContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected tblProducerContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerContactIDColumn => this.columnProducerContactID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerContactGUIDColumn => this.columnProducerContactGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerLocationGUIDColumn => this.columnProducerLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SalutationColumn => this.columnSalutation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FNameColumn => this.columnFName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LNameColumn => this.columnLName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TitleColumn => this.columnTitle;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PhoneColumn => this.columnPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExtensionColumn => this.columnExtension;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CellColumn => this.columnCell;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DeliveryMethodIDColumn => this.columnDeliveryMethodID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SSNoColumn => this.columnSSNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Req1099Column => this.columnReq1099;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FaxColumn => this.columnFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OptOutColumn => this.columnOptOut;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AddByUserIDColumn => this.columnAddByUserID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateAddedColumn => this.columnDateAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateModifiedColumn => this.columnDateModified;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EmailEditedByColumn => this.columnEmailEditedBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateEmailEditedColumn => this.columnDateEmailEdited;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ManagedByColumn => this.columnManagedBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NPNNoColumn => this.columnNPNNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ISOCountryCodeColumn => this.columnISOCountryCode;

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
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ZipPlusColumn => this.columnZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CountyColumn => this.columnCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DOBColumn => this.columnDOB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CEWaivedColumn => this.columnCEWaived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CommentColumn => this.columnComment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactsRow this[int index]
    {
      get => (dsProducerContacts.tblProducerContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactsRowChangeEventHandler tblProducerContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactsRowChangeEventHandler tblProducerContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactsRowChangeEventHandler tblProducerContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactsRowChangeEventHandler tblProducerContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblProducerContactsRow(dsProducerContacts.tblProducerContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactsRow AddtblProducerContactsRow(
      Guid ProducerContactGUID,
      Guid ProducerLocationGUID,
      dsProducerContacts.lstSalutationsRow parentlstSalutationsRowBylstSalutationstblProducerContacts,
      string FName,
      string LName,
      string Title,
      string Phone,
      string Extension,
      string Cell,
      string Email,
      dsProducerContacts.lstStatusRow parentlstStatusRowBylstStatustblProducerContacts,
      dsProducerContacts.lstDeliveryMethodRow parentlstDeliveryMethodRowBylstDeliveryMethodtblProducerContacts,
      string Name,
      string SSNo,
      bool Req1099,
      string Fax,
      bool OptOut,
      int AddByUserID,
      DateTime DateAdded,
      DateTime DateModified,
      int EmailEditedBy,
      DateTime DateEmailEdited,
      Guid ManagedBy,
      string NPNNo,
      string ISOCountryCode,
      string Address1,
      string Address2,
      string City,
      string StateID,
      string ZipCode,
      string ZipPlus,
      string County,
      DateTime DOB,
      bool CEWaived,
      string Comment)
    {
      dsProducerContacts.tblProducerContactsRow row = (dsProducerContacts.tblProducerContactsRow) this.NewRow();
      object[] objArray = new object[36]
      {
        null,
        (object) ProducerContactGUID,
        (object) ProducerLocationGUID,
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
        (object) SSNo,
        (object) Req1099,
        (object) Fax,
        (object) OptOut,
        (object) AddByUserID,
        (object) DateAdded,
        (object) DateModified,
        (object) EmailEditedBy,
        (object) DateEmailEdited,
        (object) ManagedBy,
        (object) NPNNo,
        (object) ISOCountryCode,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) StateID,
        (object) ZipCode,
        (object) ZipPlus,
        (object) County,
        (object) DOB,
        (object) CEWaived,
        (object) Comment
      };
      if (parentlstSalutationsRowBylstSalutationstblProducerContacts != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parentlstSalutationsRowBylstSalutationstblProducerContacts[0]);
      if (parentlstStatusRowBylstStatustblProducerContacts != null)
        objArray[11] = RuntimeHelpers.GetObjectValue(parentlstStatusRowBylstStatustblProducerContacts[0]);
      if (parentlstDeliveryMethodRowBylstDeliveryMethodtblProducerContacts != null)
        objArray[12] = RuntimeHelpers.GetObjectValue(parentlstDeliveryMethodRowBylstDeliveryMethodtblProducerContacts[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactsRow FindByProducerContactGUID(
      Guid ProducerContactGUID)
    {
      return (dsProducerContacts.tblProducerContactsRow) this.Rows.Find(new object[1]
      {
        (object) ProducerContactGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerContacts.tblProducerContactsDataTable contactsDataTable = (dsProducerContacts.tblProducerContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerContacts.tblProducerContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerContactID = this.Columns["ProducerContactID"];
      this.columnProducerContactGUID = this.Columns["ProducerContactGUID"];
      this.columnProducerLocationGUID = this.Columns["ProducerLocationGUID"];
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
      this.columnSSNo = this.Columns["SSNo"];
      this.columnReq1099 = this.Columns["Req1099"];
      this.columnFax = this.Columns["Fax"];
      this.columnOptOut = this.Columns["OptOut"];
      this.columnAddByUserID = this.Columns["AddByUserID"];
      this.columnDateAdded = this.Columns["DateAdded"];
      this.columnDateModified = this.Columns["DateModified"];
      this.columnEmailEditedBy = this.Columns["EmailEditedBy"];
      this.columnDateEmailEdited = this.Columns["DateEmailEdited"];
      this.columnManagedBy = this.Columns["ManagedBy"];
      this.columnNPNNo = this.Columns["NPNNo"];
      this.columnISOCountryCode = this.Columns["ISOCountryCode"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnStateID = this.Columns["StateID"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnZipPlus = this.Columns["ZipPlus"];
      this.columnCounty = this.Columns["County"];
      this.columnDOB = this.Columns["DOB"];
      this.columnCEWaived = this.Columns["CEWaived"];
      this.columnComment = this.Columns["Comment"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnProducerContactID = new DataColumn("ProducerContactID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContactID);
      this.columnProducerContactGUID = new DataColumn("ProducerContactGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContactGUID);
      this.columnProducerLocationGUID = new DataColumn("ProducerLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGUID);
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
      this.columnSSNo = new DataColumn("SSNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSSNo);
      this.columnReq1099 = new DataColumn("Req1099", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReq1099);
      this.columnFax = new DataColumn("Fax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFax);
      this.columnOptOut = new DataColumn("OptOut", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptOut);
      this.columnAddByUserID = new DataColumn("AddByUserID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddByUserID);
      this.columnDateAdded = new DataColumn("DateAdded", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateAdded);
      this.columnDateModified = new DataColumn("DateModified", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateModified);
      this.columnEmailEditedBy = new DataColumn("EmailEditedBy", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmailEditedBy);
      this.columnDateEmailEdited = new DataColumn("DateEmailEdited", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateEmailEdited);
      this.columnManagedBy = new DataColumn("ManagedBy", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnManagedBy);
      this.columnNPNNo = new DataColumn("NPNNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNPNNo);
      this.columnISOCountryCode = new DataColumn("ISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnISOCountryCode);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnAddress2 = new DataColumn("Address2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnZipPlus = new DataColumn("ZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipPlus);
      this.columnCounty = new DataColumn("County", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCounty);
      this.columnDOB = new DataColumn("DOB", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDOB);
      this.columnCEWaived = new DataColumn("CEWaived", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCEWaived);
      this.columnComment = new DataColumn("Comment", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComment);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducerContactsKey3", new DataColumn[1]
      {
        this.columnProducerContactGUID
      }, true));
      this.columnProducerContactID.AutoIncrement = true;
      this.columnProducerContactID.AllowDBNull = false;
      this.columnProducerContactID.ReadOnly = true;
      this.columnProducerContactGUID.AllowDBNull = false;
      this.columnProducerContactGUID.Unique = true;
      this.columnReq1099.DefaultValue = (object) false;
      this.columnOptOut.DefaultValue = (object) false;
      this.columnNPNNo.MaxLength = 25;
      this.columnCEWaived.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactsRow NewtblProducerContactsRow()
    {
      return (dsProducerContacts.tblProducerContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerContacts.tblProducerContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducerContacts.tblProducerContactsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactsRowChangeEventHandler contactsRowChangedEvent = this.tblProducerContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsProducerContacts.tblProducerContactsRowChangeEvent((dsProducerContacts.tblProducerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactsRowChangeEventHandler rowChangingEvent = this.tblProducerContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerContacts.tblProducerContactsRowChangeEvent((dsProducerContacts.tblProducerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblProducerContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsProducerContacts.tblProducerContactsRowChangeEvent((dsProducerContacts.tblProducerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactsRowChangeEventHandler rowDeletingEvent = this.tblProducerContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerContacts.tblProducerContactsRowChangeEvent((dsProducerContacts.tblProducerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblProducerContactsRow(dsProducerContacts.tblProducerContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerContacts producerContacts = new dsProducerContacts();
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
        FixedValue = producerContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerContacts.GetSchemaSerializable();
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
  public class lstProducerSpecialContactTypesDataTable : 
    TypedTableBase<dsProducerContacts.lstProducerSpecialContactTypesRow>
  {
    private DataColumn columnSpecialContactTypeID;
    private DataColumn columnSpecialContactType;
    private DataColumn columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstProducerSpecialContactTypesDataTable()
    {
      this.TableName = "lstProducerSpecialContactTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstProducerSpecialContactTypesDataTable(DataTable table)
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
    protected lstProducerSpecialContactTypesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SpecialContactTypeIDColumn => this.columnSpecialContactTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SpecialContactTypeColumn => this.columnSpecialContactType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerSpecialContactTypesRow this[int index]
    {
      get => (dsProducerContacts.lstProducerSpecialContactTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstProducerSpecialContactTypesRowChangeEventHandler lstProducerSpecialContactTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstProducerSpecialContactTypesRowChangeEventHandler lstProducerSpecialContactTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstProducerSpecialContactTypesRowChangeEventHandler lstProducerSpecialContactTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstProducerSpecialContactTypesRowChangeEventHandler lstProducerSpecialContactTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstProducerSpecialContactTypesRow(
      dsProducerContacts.lstProducerSpecialContactTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerSpecialContactTypesRow AddlstProducerSpecialContactTypesRow(
      string SpecialContactType,
      bool Hidden)
    {
      dsProducerContacts.lstProducerSpecialContactTypesRow row = (dsProducerContacts.lstProducerSpecialContactTypesRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerSpecialContactTypesRow FindBySpecialContactTypeID(
      int SpecialContactTypeID)
    {
      return (dsProducerContacts.lstProducerSpecialContactTypesRow) this.Rows.Find(new object[1]
      {
        (object) SpecialContactTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerContacts.lstProducerSpecialContactTypesDataTable contactTypesDataTable = (dsProducerContacts.lstProducerSpecialContactTypesDataTable) base.Clone();
      contactTypesDataTable.InitVars();
      return (DataTable) contactTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerContacts.lstProducerSpecialContactTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnSpecialContactTypeID = this.Columns["SpecialContactTypeID"];
      this.columnSpecialContactType = this.Columns["SpecialContactType"];
      this.columnHidden = this.Columns["Hidden"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnSpecialContactTypeID = new DataColumn("SpecialContactTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecialContactTypeID);
      this.columnSpecialContactType = new DataColumn("SpecialContactType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecialContactType);
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducerContactsKey5", new DataColumn[1]
      {
        this.columnSpecialContactTypeID
      }, true));
      this.columnSpecialContactTypeID.AutoIncrement = true;
      this.columnSpecialContactTypeID.AllowDBNull = false;
      this.columnSpecialContactTypeID.ReadOnly = true;
      this.columnSpecialContactTypeID.Unique = true;
      this.columnHidden.AllowDBNull = false;
      this.columnHidden.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerSpecialContactTypesRow NewlstProducerSpecialContactTypesRow()
    {
      return (dsProducerContacts.lstProducerSpecialContactTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerContacts.lstProducerSpecialContactTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsProducerContacts.lstProducerSpecialContactTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerSpecialContactTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.lstProducerSpecialContactTypesRowChangeEventHandler typesRowChangedEvent = this.lstProducerSpecialContactTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsProducerContacts.lstProducerSpecialContactTypesRowChangeEvent((dsProducerContacts.lstProducerSpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerSpecialContactTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.lstProducerSpecialContactTypesRowChangeEventHandler rowChangingEvent = this.lstProducerSpecialContactTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerContacts.lstProducerSpecialContactTypesRowChangeEvent((dsProducerContacts.lstProducerSpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerSpecialContactTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.lstProducerSpecialContactTypesRowChangeEventHandler typesRowDeletedEvent = this.lstProducerSpecialContactTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsProducerContacts.lstProducerSpecialContactTypesRowChangeEvent((dsProducerContacts.lstProducerSpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerSpecialContactTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.lstProducerSpecialContactTypesRowChangeEventHandler rowDeletingEvent = this.lstProducerSpecialContactTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerContacts.lstProducerSpecialContactTypesRowChangeEvent((dsProducerContacts.lstProducerSpecialContactTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstProducerSpecialContactTypesRow(
      dsProducerContacts.lstProducerSpecialContactTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerContacts producerContacts = new dsProducerContacts();
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
        FixedValue = producerContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstProducerSpecialContactTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerContacts.GetSchemaSerializable();
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
  public class lstDeliveryMethodDataTable : TypedTableBase<dsProducerContacts.lstDeliveryMethodRow>
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
    public dsProducerContacts.lstDeliveryMethodRow this[int index]
    {
      get => (dsProducerContacts.lstDeliveryMethodRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstDeliveryMethodRowChangeEventHandler lstDeliveryMethodRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstDeliveryMethodRow(dsProducerContacts.lstDeliveryMethodRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstDeliveryMethodRow AddlstDeliveryMethodRow(string Description)
    {
      dsProducerContacts.lstDeliveryMethodRow row = (dsProducerContacts.lstDeliveryMethodRow) this.NewRow();
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
    public dsProducerContacts.lstDeliveryMethodRow FindByDeliveryMethodID(int DeliveryMethodID)
    {
      return (dsProducerContacts.lstDeliveryMethodRow) this.Rows.Find(new object[1]
      {
        (object) DeliveryMethodID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerContacts.lstDeliveryMethodDataTable deliveryMethodDataTable = (dsProducerContacts.lstDeliveryMethodDataTable) base.Clone();
      deliveryMethodDataTable.InitVars();
      return (DataTable) deliveryMethodDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerContacts.lstDeliveryMethodDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducerContactsKey6", new DataColumn[1]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstDeliveryMethodRow NewlstDeliveryMethodRow()
    {
      return (dsProducerContacts.lstDeliveryMethodRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerContacts.lstDeliveryMethodRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducerContacts.lstDeliveryMethodRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeliveryMethodRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.lstDeliveryMethodRowChangeEventHandler methodRowChangedEvent = this.lstDeliveryMethodRowChangedEvent;
      if (methodRowChangedEvent == null)
        return;
      methodRowChangedEvent((object) this, new dsProducerContacts.lstDeliveryMethodRowChangeEvent((dsProducerContacts.lstDeliveryMethodRow) e.Row, e.Action));
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
      dsProducerContacts.lstDeliveryMethodRowChangeEventHandler rowChangingEvent = this.lstDeliveryMethodRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerContacts.lstDeliveryMethodRowChangeEvent((dsProducerContacts.lstDeliveryMethodRow) e.Row, e.Action));
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
      dsProducerContacts.lstDeliveryMethodRowChangeEventHandler methodRowDeletedEvent = this.lstDeliveryMethodRowDeletedEvent;
      if (methodRowDeletedEvent == null)
        return;
      methodRowDeletedEvent((object) this, new dsProducerContacts.lstDeliveryMethodRowChangeEvent((dsProducerContacts.lstDeliveryMethodRow) e.Row, e.Action));
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
      dsProducerContacts.lstDeliveryMethodRowChangeEventHandler rowDeletingEvent = this.lstDeliveryMethodRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerContacts.lstDeliveryMethodRowChangeEvent((dsProducerContacts.lstDeliveryMethodRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstDeliveryMethodRow(dsProducerContacts.lstDeliveryMethodRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerContacts producerContacts = new dsProducerContacts();
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
        FixedValue = producerContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstDeliveryMethodDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerContacts.GetSchemaSerializable();
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
  public class lstStatusDataTable : TypedTableBase<dsProducerContacts.lstStatusRow>
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
    public dsProducerContacts.lstStatusRow this[int index]
    {
      get => (dsProducerContacts.lstStatusRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstStatusRowChangeEventHandler lstStatusRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstStatusRowChangeEventHandler lstStatusRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstStatusRowChangeEventHandler lstStatusRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstStatusRowChangeEventHandler lstStatusRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstStatusRow(dsProducerContacts.lstStatusRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstStatusRow AddlstStatusRow(
      int StatusID,
      string Status,
      bool Disable)
    {
      dsProducerContacts.lstStatusRow row = (dsProducerContacts.lstStatusRow) this.NewRow();
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
    public dsProducerContacts.lstStatusRow FindByStatusID(int StatusID)
    {
      return (dsProducerContacts.lstStatusRow) this.Rows.Find(new object[1]
      {
        (object) StatusID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerContacts.lstStatusDataTable lstStatusDataTable = (dsProducerContacts.lstStatusDataTable) base.Clone();
      lstStatusDataTable.InitVars();
      return (DataTable) lstStatusDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerContacts.lstStatusDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducerContactsKey7", new DataColumn[1]
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
    public dsProducerContacts.lstStatusRow NewlstStatusRow()
    {
      return (dsProducerContacts.lstStatusRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerContacts.lstStatusRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducerContacts.lstStatusRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.lstStatusRowChangeEventHandler statusRowChangedEvent = this.lstStatusRowChangedEvent;
      if (statusRowChangedEvent == null)
        return;
      statusRowChangedEvent((object) this, new dsProducerContacts.lstStatusRowChangeEvent((dsProducerContacts.lstStatusRow) e.Row, e.Action));
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
      dsProducerContacts.lstStatusRowChangeEventHandler rowChangingEvent = this.lstStatusRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerContacts.lstStatusRowChangeEvent((dsProducerContacts.lstStatusRow) e.Row, e.Action));
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
      dsProducerContacts.lstStatusRowChangeEventHandler statusRowDeletedEvent = this.lstStatusRowDeletedEvent;
      if (statusRowDeletedEvent == null)
        return;
      statusRowDeletedEvent((object) this, new dsProducerContacts.lstStatusRowChangeEvent((dsProducerContacts.lstStatusRow) e.Row, e.Action));
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
      dsProducerContacts.lstStatusRowChangeEventHandler rowDeletingEvent = this.lstStatusRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerContacts.lstStatusRowChangeEvent((dsProducerContacts.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstStatusRow(dsProducerContacts.lstStatusRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerContacts producerContacts = new dsProducerContacts();
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
        FixedValue = producerContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatusDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerContacts.GetSchemaSerializable();
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
  public class tblProducerSpecialContactsDataTable : 
    TypedTableBase<dsProducerContacts.tblProducerSpecialContactsRow>
  {
    private DataColumn columnProducerContactGUID;
    private DataColumn columnSpecialContactTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerSpecialContactsDataTable()
    {
      this.TableName = "tblProducerSpecialContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducerSpecialContactsDataTable(DataTable table)
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
    protected tblProducerSpecialContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerContactGUIDColumn => this.columnProducerContactGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SpecialContactTypeIDColumn => this.columnSpecialContactTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerSpecialContactsRow this[int index]
    {
      get => (dsProducerContacts.tblProducerSpecialContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerSpecialContactsRowChangeEventHandler tblProducerSpecialContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerSpecialContactsRowChangeEventHandler tblProducerSpecialContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerSpecialContactsRowChangeEventHandler tblProducerSpecialContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerSpecialContactsRowChangeEventHandler tblProducerSpecialContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblProducerSpecialContactsRow(
      dsProducerContacts.tblProducerSpecialContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerSpecialContactsRow AddtblProducerSpecialContactsRow(
      dsProducerContacts.tblProducerContactsRow parenttblProducerContactsRowBytblProducerContactstblProducerSpecialContacts,
      dsProducerContacts.lstProducerSpecialContactTypesRow parentlstProducerSpecialContactTypesRowBylstProducerSpecialContactTypestblProducerSpecialContacts)
    {
      dsProducerContacts.tblProducerSpecialContactsRow row = (dsProducerContacts.tblProducerSpecialContactsRow) this.NewRow();
      object[] objArray = new object[2];
      if (parenttblProducerContactsRowBytblProducerContactstblProducerSpecialContacts != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblProducerContactsRowBytblProducerContactstblProducerSpecialContacts[1]);
      if (parentlstProducerSpecialContactTypesRowBylstProducerSpecialContactTypestblProducerSpecialContacts != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstProducerSpecialContactTypesRowBylstProducerSpecialContactTypestblProducerSpecialContacts[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerSpecialContactsRow FindByProducerContactGUIDSpecialContactTypeID(
      Guid ProducerContactGUID,
      int SpecialContactTypeID)
    {
      return (dsProducerContacts.tblProducerSpecialContactsRow) this.Rows.Find(new object[2]
      {
        (object) ProducerContactGUID,
        (object) SpecialContactTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerContacts.tblProducerSpecialContactsDataTable contactsDataTable = (dsProducerContacts.tblProducerSpecialContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerContacts.tblProducerSpecialContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerContactGUID = this.Columns["ProducerContactGUID"];
      this.columnSpecialContactTypeID = this.Columns["SpecialContactTypeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnProducerContactGUID = new DataColumn("ProducerContactGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContactGUID);
      this.columnSpecialContactTypeID = new DataColumn("SpecialContactTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecialContactTypeID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducerContactsKey4", new DataColumn[2]
      {
        this.columnProducerContactGUID,
        this.columnSpecialContactTypeID
      }, true));
      this.columnProducerContactGUID.AllowDBNull = false;
      this.columnSpecialContactTypeID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerSpecialContactsRow NewtblProducerSpecialContactsRow()
    {
      return (dsProducerContacts.tblProducerSpecialContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerContacts.tblProducerSpecialContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsProducerContacts.tblProducerSpecialContactsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerSpecialContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerSpecialContactsRowChangeEventHandler contactsRowChangedEvent = this.tblProducerSpecialContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsProducerContacts.tblProducerSpecialContactsRowChangeEvent((dsProducerContacts.tblProducerSpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerSpecialContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerSpecialContactsRowChangeEventHandler rowChangingEvent = this.tblProducerSpecialContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerContacts.tblProducerSpecialContactsRowChangeEvent((dsProducerContacts.tblProducerSpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerSpecialContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerSpecialContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblProducerSpecialContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsProducerContacts.tblProducerSpecialContactsRowChangeEvent((dsProducerContacts.tblProducerSpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerSpecialContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerSpecialContactsRowChangeEventHandler rowDeletingEvent = this.tblProducerSpecialContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerContacts.tblProducerSpecialContactsRowChangeEvent((dsProducerContacts.tblProducerSpecialContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblProducerSpecialContactsRow(
      dsProducerContacts.tblProducerSpecialContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerContacts producerContacts = new dsProducerContacts();
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
        FixedValue = producerContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerSpecialContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerContacts.GetSchemaSerializable();
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
  public class lstSalutationsDataTable : TypedTableBase<dsProducerContacts.lstSalutationsRow>
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
    public dsProducerContacts.lstSalutationsRow this[int index]
    {
      get => (dsProducerContacts.lstSalutationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstSalutationsRowChangeEventHandler lstSalutationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstSalutationsRowChangeEventHandler lstSalutationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstSalutationsRowChangeEventHandler lstSalutationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstSalutationsRowChangeEventHandler lstSalutationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstSalutationsRow(dsProducerContacts.lstSalutationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstSalutationsRow AddlstSalutationsRow(string Salutation)
    {
      dsProducerContacts.lstSalutationsRow row = (dsProducerContacts.lstSalutationsRow) this.NewRow();
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
    public dsProducerContacts.lstSalutationsRow FindBySalutation(string Salutation)
    {
      return (dsProducerContacts.lstSalutationsRow) this.Rows.Find(new object[1]
      {
        (object) Salutation
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerContacts.lstSalutationsDataTable salutationsDataTable = (dsProducerContacts.lstSalutationsDataTable) base.Clone();
      salutationsDataTable.InitVars();
      return (DataTable) salutationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerContacts.lstSalutationsDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducerContactsKey1", new DataColumn[1]
      {
        this.columnSalutation
      }, true));
      this.columnSalutation.AllowDBNull = false;
      this.columnSalutation.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstSalutationsRow NewlstSalutationsRow()
    {
      return (dsProducerContacts.lstSalutationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerContacts.lstSalutationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducerContacts.lstSalutationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSalutationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.lstSalutationsRowChangeEventHandler salutationsRowChangedEvent = this.lstSalutationsRowChangedEvent;
      if (salutationsRowChangedEvent == null)
        return;
      salutationsRowChangedEvent((object) this, new dsProducerContacts.lstSalutationsRowChangeEvent((dsProducerContacts.lstSalutationsRow) e.Row, e.Action));
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
      dsProducerContacts.lstSalutationsRowChangeEventHandler rowChangingEvent = this.lstSalutationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerContacts.lstSalutationsRowChangeEvent((dsProducerContacts.lstSalutationsRow) e.Row, e.Action));
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
      dsProducerContacts.lstSalutationsRowChangeEventHandler salutationsRowDeletedEvent = this.lstSalutationsRowDeletedEvent;
      if (salutationsRowDeletedEvent == null)
        return;
      salutationsRowDeletedEvent((object) this, new dsProducerContacts.lstSalutationsRowChangeEvent((dsProducerContacts.lstSalutationsRow) e.Row, e.Action));
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
      dsProducerContacts.lstSalutationsRowChangeEventHandler rowDeletingEvent = this.lstSalutationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerContacts.lstSalutationsRowChangeEvent((dsProducerContacts.lstSalutationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstSalutationsRow(dsProducerContacts.lstSalutationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerContacts producerContacts = new dsProducerContacts();
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
        FixedValue = producerContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstSalutationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerContacts.GetSchemaSerializable();
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
  public class lstProducerContactInterestsDataTable : 
    TypedTableBase<dsProducerContacts.lstProducerContactInterestsRow>
  {
    private DataColumn columnIntID;
    private DataColumn columnContactInterest;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstProducerContactInterestsDataTable()
    {
      this.TableName = "lstProducerContactInterests";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstProducerContactInterestsDataTable(DataTable table)
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
    protected lstProducerContactInterestsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IntIDColumn => this.columnIntID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ContactInterestColumn => this.columnContactInterest;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerContactInterestsRow this[int index]
    {
      get => (dsProducerContacts.lstProducerContactInterestsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstProducerContactInterestsRowChangeEventHandler lstProducerContactInterestsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstProducerContactInterestsRowChangeEventHandler lstProducerContactInterestsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstProducerContactInterestsRowChangeEventHandler lstProducerContactInterestsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstProducerContactInterestsRowChangeEventHandler lstProducerContactInterestsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstProducerContactInterestsRow(
      dsProducerContacts.lstProducerContactInterestsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerContactInterestsRow AddlstProducerContactInterestsRow(
      string ContactInterest)
    {
      dsProducerContacts.lstProducerContactInterestsRow row = (dsProducerContacts.lstProducerContactInterestsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) ContactInterest
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerContactInterestsRow FindByIntID(int IntID)
    {
      return (dsProducerContacts.lstProducerContactInterestsRow) this.Rows.Find(new object[1]
      {
        (object) IntID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerContacts.lstProducerContactInterestsDataTable interestsDataTable = (dsProducerContacts.lstProducerContactInterestsDataTable) base.Clone();
      interestsDataTable.InitVars();
      return (DataTable) interestsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerContacts.lstProducerContactInterestsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnIntID = this.Columns["IntID"];
      this.columnContactInterest = this.Columns["ContactInterest"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnIntID = new DataColumn("IntID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntID);
      this.columnContactInterest = new DataColumn("ContactInterest", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactInterest);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnIntID
      }, true));
      this.columnIntID.AutoIncrement = true;
      this.columnIntID.AutoIncrementSeed = -1L;
      this.columnIntID.AutoIncrementStep = -1L;
      this.columnIntID.AllowDBNull = false;
      this.columnIntID.ReadOnly = true;
      this.columnIntID.Unique = true;
      this.columnContactInterest.AllowDBNull = false;
      this.columnContactInterest.MaxLength = 100;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerContactInterestsRow NewlstProducerContactInterestsRow()
    {
      return (dsProducerContacts.lstProducerContactInterestsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerContacts.lstProducerContactInterestsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsProducerContacts.lstProducerContactInterestsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerContactInterestsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.lstProducerContactInterestsRowChangeEventHandler interestsRowChangedEvent = this.lstProducerContactInterestsRowChangedEvent;
      if (interestsRowChangedEvent == null)
        return;
      interestsRowChangedEvent((object) this, new dsProducerContacts.lstProducerContactInterestsRowChangeEvent((dsProducerContacts.lstProducerContactInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerContactInterestsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.lstProducerContactInterestsRowChangeEventHandler rowChangingEvent = this.lstProducerContactInterestsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerContacts.lstProducerContactInterestsRowChangeEvent((dsProducerContacts.lstProducerContactInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerContactInterestsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.lstProducerContactInterestsRowChangeEventHandler interestsRowDeletedEvent = this.lstProducerContactInterestsRowDeletedEvent;
      if (interestsRowDeletedEvent == null)
        return;
      interestsRowDeletedEvent((object) this, new dsProducerContacts.lstProducerContactInterestsRowChangeEvent((dsProducerContacts.lstProducerContactInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerContactInterestsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.lstProducerContactInterestsRowChangeEventHandler rowDeletingEvent = this.lstProducerContactInterestsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerContacts.lstProducerContactInterestsRowChangeEvent((dsProducerContacts.lstProducerContactInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstProducerContactInterestsRow(
      dsProducerContacts.lstProducerContactInterestsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerContacts producerContacts = new dsProducerContacts();
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
        FixedValue = producerContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstProducerContactInterestsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerContacts.GetSchemaSerializable();
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
  public class lstProducerContactJobFunctionDataTable : 
    TypedTableBase<dsProducerContacts.lstProducerContactJobFunctionRow>
  {
    private DataColumn columnJobFunctionID;
    private DataColumn columnJobFunction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstProducerContactJobFunctionDataTable()
    {
      this.TableName = "lstProducerContactJobFunction";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstProducerContactJobFunctionDataTable(DataTable table)
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
    protected lstProducerContactJobFunctionDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn JobFunctionIDColumn => this.columnJobFunctionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn JobFunctionColumn => this.columnJobFunction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerContactJobFunctionRow this[int index]
    {
      get => (dsProducerContacts.lstProducerContactJobFunctionRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstProducerContactJobFunctionRowChangeEventHandler lstProducerContactJobFunctionRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstProducerContactJobFunctionRowChangeEventHandler lstProducerContactJobFunctionRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstProducerContactJobFunctionRowChangeEventHandler lstProducerContactJobFunctionRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.lstProducerContactJobFunctionRowChangeEventHandler lstProducerContactJobFunctionRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstProducerContactJobFunctionRow(
      dsProducerContacts.lstProducerContactJobFunctionRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerContactJobFunctionRow AddlstProducerContactJobFunctionRow(
      string JobFunction)
    {
      dsProducerContacts.lstProducerContactJobFunctionRow row = (dsProducerContacts.lstProducerContactJobFunctionRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) JobFunction
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerContactJobFunctionRow FindByJobFunctionID(int JobFunctionID)
    {
      return (dsProducerContacts.lstProducerContactJobFunctionRow) this.Rows.Find(new object[1]
      {
        (object) JobFunctionID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerContacts.lstProducerContactJobFunctionDataTable functionDataTable = (dsProducerContacts.lstProducerContactJobFunctionDataTable) base.Clone();
      functionDataTable.InitVars();
      return (DataTable) functionDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerContacts.lstProducerContactJobFunctionDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnJobFunctionID = this.Columns["JobFunctionID"];
      this.columnJobFunction = this.Columns["JobFunction"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnJobFunctionID = new DataColumn("JobFunctionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnJobFunctionID);
      this.columnJobFunction = new DataColumn("JobFunction", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnJobFunction);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnJobFunctionID
      }, true));
      this.columnJobFunctionID.AutoIncrement = true;
      this.columnJobFunctionID.AutoIncrementSeed = -1L;
      this.columnJobFunctionID.AutoIncrementStep = -1L;
      this.columnJobFunctionID.AllowDBNull = false;
      this.columnJobFunctionID.ReadOnly = true;
      this.columnJobFunctionID.Unique = true;
      this.columnJobFunction.AllowDBNull = false;
      this.columnJobFunction.MaxLength = 100;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerContactJobFunctionRow NewlstProducerContactJobFunctionRow()
    {
      return (dsProducerContacts.lstProducerContactJobFunctionRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerContacts.lstProducerContactJobFunctionRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsProducerContacts.lstProducerContactJobFunctionRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerContactJobFunctionRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.lstProducerContactJobFunctionRowChangeEventHandler functionRowChangedEvent = this.lstProducerContactJobFunctionRowChangedEvent;
      if (functionRowChangedEvent == null)
        return;
      functionRowChangedEvent((object) this, new dsProducerContacts.lstProducerContactJobFunctionRowChangeEvent((dsProducerContacts.lstProducerContactJobFunctionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerContactJobFunctionRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.lstProducerContactJobFunctionRowChangeEventHandler rowChangingEvent = this.lstProducerContactJobFunctionRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerContacts.lstProducerContactJobFunctionRowChangeEvent((dsProducerContacts.lstProducerContactJobFunctionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerContactJobFunctionRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.lstProducerContactJobFunctionRowChangeEventHandler functionRowDeletedEvent = this.lstProducerContactJobFunctionRowDeletedEvent;
      if (functionRowDeletedEvent == null)
        return;
      functionRowDeletedEvent((object) this, new dsProducerContacts.lstProducerContactJobFunctionRowChangeEvent((dsProducerContacts.lstProducerContactJobFunctionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerContactJobFunctionRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.lstProducerContactJobFunctionRowChangeEventHandler rowDeletingEvent = this.lstProducerContactJobFunctionRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerContacts.lstProducerContactJobFunctionRowChangeEvent((dsProducerContacts.lstProducerContactJobFunctionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstProducerContactJobFunctionRow(
      dsProducerContacts.lstProducerContactJobFunctionRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerContacts producerContacts = new dsProducerContacts();
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
        FixedValue = producerContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstProducerContactJobFunctionDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerContacts.GetSchemaSerializable();
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
  public class tblProducerContactInterestsDataTable : 
    TypedTableBase<dsProducerContacts.tblProducerContactInterestsRow>
  {
    private DataColumn columnProducerContactGuid;
    private DataColumn columnIntID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerContactInterestsDataTable()
    {
      this.TableName = "tblProducerContactInterests";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducerContactInterestsDataTable(DataTable table)
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
    protected tblProducerContactInterestsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerContactGuidColumn => this.columnProducerContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IntIDColumn => this.columnIntID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactInterestsRow this[int index]
    {
      get => (dsProducerContacts.tblProducerContactInterestsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactInterestsRowChangeEventHandler tblProducerContactInterestsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactInterestsRowChangeEventHandler tblProducerContactInterestsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactInterestsRowChangeEventHandler tblProducerContactInterestsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactInterestsRowChangeEventHandler tblProducerContactInterestsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblProducerContactInterestsRow(
      dsProducerContacts.tblProducerContactInterestsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactInterestsRow AddtblProducerContactInterestsRow(
      Guid ProducerContactGuid,
      int IntID)
    {
      dsProducerContacts.tblProducerContactInterestsRow row = (dsProducerContacts.tblProducerContactInterestsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ProducerContactGuid,
        (object) IntID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactInterestsRow FindByProducerContactGuidIntID(
      Guid ProducerContactGuid,
      int IntID)
    {
      return (dsProducerContacts.tblProducerContactInterestsRow) this.Rows.Find(new object[2]
      {
        (object) ProducerContactGuid,
        (object) IntID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerContacts.tblProducerContactInterestsDataTable interestsDataTable = (dsProducerContacts.tblProducerContactInterestsDataTable) base.Clone();
      interestsDataTable.InitVars();
      return (DataTable) interestsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerContacts.tblProducerContactInterestsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerContactGuid = this.Columns["ProducerContactGuid"];
      this.columnIntID = this.Columns["IntID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnProducerContactGuid = new DataColumn("ProducerContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContactGuid);
      this.columnIntID = new DataColumn("IntID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnProducerContactGuid,
        this.columnIntID
      }, true));
      this.columnProducerContactGuid.AllowDBNull = false;
      this.columnIntID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactInterestsRow NewtblProducerContactInterestsRow()
    {
      return (dsProducerContacts.tblProducerContactInterestsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerContacts.tblProducerContactInterestsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsProducerContacts.tblProducerContactInterestsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactInterestsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactInterestsRowChangeEventHandler interestsRowChangedEvent = this.tblProducerContactInterestsRowChangedEvent;
      if (interestsRowChangedEvent == null)
        return;
      interestsRowChangedEvent((object) this, new dsProducerContacts.tblProducerContactInterestsRowChangeEvent((dsProducerContacts.tblProducerContactInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactInterestsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactInterestsRowChangeEventHandler rowChangingEvent = this.tblProducerContactInterestsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerContacts.tblProducerContactInterestsRowChangeEvent((dsProducerContacts.tblProducerContactInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactInterestsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactInterestsRowChangeEventHandler interestsRowDeletedEvent = this.tblProducerContactInterestsRowDeletedEvent;
      if (interestsRowDeletedEvent == null)
        return;
      interestsRowDeletedEvent((object) this, new dsProducerContacts.tblProducerContactInterestsRowChangeEvent((dsProducerContacts.tblProducerContactInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactInterestsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactInterestsRowChangeEventHandler rowDeletingEvent = this.tblProducerContactInterestsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerContacts.tblProducerContactInterestsRowChangeEvent((dsProducerContacts.tblProducerContactInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblProducerContactInterestsRow(
      dsProducerContacts.tblProducerContactInterestsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerContacts producerContacts = new dsProducerContacts();
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
        FixedValue = producerContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerContactInterestsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerContacts.GetSchemaSerializable();
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
  public class tblProducerContactJobFunctionsDataTable : 
    TypedTableBase<dsProducerContacts.tblProducerContactJobFunctionsRow>
  {
    private DataColumn columnProducerContactGuid;
    private DataColumn columnJobFunctionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerContactJobFunctionsDataTable()
    {
      this.TableName = "tblProducerContactJobFunctions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducerContactJobFunctionsDataTable(DataTable table)
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
    protected tblProducerContactJobFunctionsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerContactGuidColumn => this.columnProducerContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn JobFunctionIDColumn => this.columnJobFunctionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactJobFunctionsRow this[int index]
    {
      get => (dsProducerContacts.tblProducerContactJobFunctionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactJobFunctionsRowChangeEventHandler tblProducerContactJobFunctionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactJobFunctionsRowChangeEventHandler tblProducerContactJobFunctionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactJobFunctionsRowChangeEventHandler tblProducerContactJobFunctionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactJobFunctionsRowChangeEventHandler tblProducerContactJobFunctionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblProducerContactJobFunctionsRow(
      dsProducerContacts.tblProducerContactJobFunctionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactJobFunctionsRow AddtblProducerContactJobFunctionsRow(
      Guid ProducerContactGuid,
      int JobFunctionID)
    {
      dsProducerContacts.tblProducerContactJobFunctionsRow row = (dsProducerContacts.tblProducerContactJobFunctionsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ProducerContactGuid,
        (object) JobFunctionID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactJobFunctionsRow FindByProducerContactGuidJobFunctionID(
      Guid ProducerContactGuid,
      int JobFunctionID)
    {
      return (dsProducerContacts.tblProducerContactJobFunctionsRow) this.Rows.Find(new object[2]
      {
        (object) ProducerContactGuid,
        (object) JobFunctionID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerContacts.tblProducerContactJobFunctionsDataTable functionsDataTable = (dsProducerContacts.tblProducerContactJobFunctionsDataTable) base.Clone();
      functionsDataTable.InitVars();
      return (DataTable) functionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerContacts.tblProducerContactJobFunctionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerContactGuid = this.Columns["ProducerContactGuid"];
      this.columnJobFunctionID = this.Columns["JobFunctionID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnProducerContactGuid = new DataColumn("ProducerContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContactGuid);
      this.columnJobFunctionID = new DataColumn("JobFunctionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnJobFunctionID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnProducerContactGuid,
        this.columnJobFunctionID
      }, true));
      this.columnProducerContactGuid.AllowDBNull = false;
      this.columnJobFunctionID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactJobFunctionsRow NewtblProducerContactJobFunctionsRow()
    {
      return (dsProducerContacts.tblProducerContactJobFunctionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerContacts.tblProducerContactJobFunctionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsProducerContacts.tblProducerContactJobFunctionsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactJobFunctionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactJobFunctionsRowChangeEventHandler functionsRowChangedEvent = this.tblProducerContactJobFunctionsRowChangedEvent;
      if (functionsRowChangedEvent == null)
        return;
      functionsRowChangedEvent((object) this, new dsProducerContacts.tblProducerContactJobFunctionsRowChangeEvent((dsProducerContacts.tblProducerContactJobFunctionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactJobFunctionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactJobFunctionsRowChangeEventHandler rowChangingEvent = this.tblProducerContactJobFunctionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerContacts.tblProducerContactJobFunctionsRowChangeEvent((dsProducerContacts.tblProducerContactJobFunctionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactJobFunctionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactJobFunctionsRowChangeEventHandler functionsRowDeletedEvent = this.tblProducerContactJobFunctionsRowDeletedEvent;
      if (functionsRowDeletedEvent == null)
        return;
      functionsRowDeletedEvent((object) this, new dsProducerContacts.tblProducerContactJobFunctionsRowChangeEvent((dsProducerContacts.tblProducerContactJobFunctionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactJobFunctionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactJobFunctionsRowChangeEventHandler rowDeletingEvent = this.tblProducerContactJobFunctionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerContacts.tblProducerContactJobFunctionsRowChangeEvent((dsProducerContacts.tblProducerContactJobFunctionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblProducerContactJobFunctionsRow(
      dsProducerContacts.tblProducerContactJobFunctionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerContacts producerContacts = new dsProducerContacts();
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
        FixedValue = producerContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerContactJobFunctionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerContacts.GetSchemaSerializable();
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
  public class tblProducerContactsCopyDataTable : 
    TypedTableBase<dsProducerContacts.tblProducerContactsCopyRow>
  {
    private DataColumn columnProducerContactGUID;
    private DataColumn columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerContactsCopyDataTable()
    {
      this.TableName = "tblProducerContactsCopy";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducerContactsCopyDataTable(DataTable table)
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
    protected tblProducerContactsCopyDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerContactGUIDColumn => this.columnProducerContactGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactsCopyRow this[int index]
    {
      get => (dsProducerContacts.tblProducerContactsCopyRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactsCopyRowChangeEventHandler tblProducerContactsCopyRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactsCopyRowChangeEventHandler tblProducerContactsCopyRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactsCopyRowChangeEventHandler tblProducerContactsCopyRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProducerContacts.tblProducerContactsCopyRowChangeEventHandler tblProducerContactsCopyRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblProducerContactsCopyRow(dsProducerContacts.tblProducerContactsCopyRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactsCopyRow AddtblProducerContactsCopyRow(
      Guid ProducerContactGUID,
      string Name)
    {
      dsProducerContacts.tblProducerContactsCopyRow row = (dsProducerContacts.tblProducerContactsCopyRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ProducerContactGUID,
        (object) Name
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerContacts.tblProducerContactsCopyDataTable contactsCopyDataTable = (dsProducerContacts.tblProducerContactsCopyDataTable) base.Clone();
      contactsCopyDataTable.InitVars();
      return (DataTable) contactsCopyDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerContacts.tblProducerContactsCopyDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerContactGUID = this.Columns["ProducerContactGUID"];
      this.columnName = this.Columns["Name"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnProducerContactGUID = new DataColumn("ProducerContactGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContactGUID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnProducerContactGUID
      }, false));
      this.columnProducerContactGUID.AllowDBNull = false;
      this.columnProducerContactGUID.Unique = true;
      this.columnName.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactsCopyRow NewtblProducerContactsCopyRow()
    {
      return (dsProducerContacts.tblProducerContactsCopyRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerContacts.tblProducerContactsCopyRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducerContacts.tblProducerContactsCopyRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsCopyRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactsCopyRowChangeEventHandler copyRowChangedEvent = this.tblProducerContactsCopyRowChangedEvent;
      if (copyRowChangedEvent == null)
        return;
      copyRowChangedEvent((object) this, new dsProducerContacts.tblProducerContactsCopyRowChangeEvent((dsProducerContacts.tblProducerContactsCopyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsCopyRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactsCopyRowChangeEventHandler rowChangingEvent = this.tblProducerContactsCopyRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerContacts.tblProducerContactsCopyRowChangeEvent((dsProducerContacts.tblProducerContactsCopyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsCopyRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactsCopyRowChangeEventHandler copyRowDeletedEvent = this.tblProducerContactsCopyRowDeletedEvent;
      if (copyRowDeletedEvent == null)
        return;
      copyRowDeletedEvent((object) this, new dsProducerContacts.tblProducerContactsCopyRowChangeEvent((dsProducerContacts.tblProducerContactsCopyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsCopyRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerContacts.tblProducerContactsCopyRowChangeEventHandler rowDeletingEvent = this.tblProducerContactsCopyRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerContacts.tblProducerContactsCopyRowChangeEvent((dsProducerContacts.tblProducerContactsCopyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblProducerContactsCopyRow(dsProducerContacts.tblProducerContactsCopyRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerContacts producerContacts = new dsProducerContacts();
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
        FixedValue = producerContacts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerContactsCopyDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerContacts.GetSchemaSerializable();
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

  public class tblProducerContactsRow : DataRow
  {
    private dsProducerContacts.tblProducerContactsDataTable tabletblProducerContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducerContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerContacts = (dsProducerContacts.tblProducerContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ProducerContactID
    {
      get => Conversions.ToInteger(this[this.tabletblProducerContacts.ProducerContactIDColumn]);
      set => this[this.tabletblProducerContacts.ProducerContactIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Salutation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.SalutationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Salutation' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.SalutationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string FName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.FNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FName' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.FNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.LNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LName' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.LNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Title
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.TitleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Title' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.TitleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Phone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.PhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Phone' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Extension
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.ExtensionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Extension' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.ExtensionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Cell
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.CellColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Cell' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.CellColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.EmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Email' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int StatusID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerContacts.StatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusID' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DeliveryMethodID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerContacts.DeliveryMethodIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeliveryMethodID' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.DeliveryMethodIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string SSNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.SSNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SSNo' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.SSNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Req1099
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblProducerContacts.Req1099Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Req1099' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.Req1099Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Fax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.FaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fax' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.FaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool OptOut
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblProducerContacts.OptOutColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OptOut' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.OptOutColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int AddByUserID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerContacts.AddByUserIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddByUserID' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.AddByUserIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateAdded
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblProducerContacts.DateAddedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateAdded' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.DateAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateModified
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblProducerContacts.DateModifiedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateModified' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.DateModifiedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int EmailEditedBy
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerContacts.EmailEditedByColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EmailEditedBy' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.EmailEditedByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateEmailEdited
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblProducerContacts.DateEmailEditedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateEmailEdited' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.DateEmailEditedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ManagedBy
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducerContacts.ManagedByColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ManagedBy' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.ManagedByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string NPNNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.NPNNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NPNNo' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.NPNNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ISOCountryCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.ISOCountryCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ISOCountryCode' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.ISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address1' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address2' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.ZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipPlus' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.ZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string County
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.CountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'County' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.CountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DOB
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblProducerContacts.DOBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DOB' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.DOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool CEWaived
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblProducerContacts.CEWaivedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CEWaived' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.CEWaivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Comment
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.CommentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Comment' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.CommentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstDeliveryMethodRow lstDeliveryMethodRow
    {
      get
      {
        return (dsProducerContacts.lstDeliveryMethodRow) this.GetParentRow(this.Table.ParentRelations["lstDeliveryMethodtblProducerContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstDeliveryMethodtblProducerContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstStatusRow lstStatusRow
    {
      get
      {
        return (dsProducerContacts.lstStatusRow) this.GetParentRow(this.Table.ParentRelations["lstStatustblProducerContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstStatustblProducerContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstSalutationsRow lstSalutationsRow
    {
      get
      {
        return (dsProducerContacts.lstSalutationsRow) this.GetParentRow(this.Table.ParentRelations["lstSalutationstblProducerContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstSalutationstblProducerContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerLocationGUIDNull()
    {
      return this.IsNull(this.tabletblProducerContacts.ProducerLocationGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerLocationGUIDNull()
    {
      this[this.tabletblProducerContacts.ProducerLocationGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSalutationNull() => this.IsNull(this.tabletblProducerContacts.SalutationColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSalutationNull()
    {
      this[this.tabletblProducerContacts.SalutationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFNameNull() => this.IsNull(this.tabletblProducerContacts.FNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFNameNull()
    {
      this[this.tabletblProducerContacts.FNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLNameNull() => this.IsNull(this.tabletblProducerContacts.LNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLNameNull()
    {
      this[this.tabletblProducerContacts.LNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTitleNull() => this.IsNull(this.tabletblProducerContacts.TitleColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTitleNull()
    {
      this[this.tabletblProducerContacts.TitleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPhoneNull() => this.IsNull(this.tabletblProducerContacts.PhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPhoneNull()
    {
      this[this.tabletblProducerContacts.PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsExtensionNull() => this.IsNull(this.tabletblProducerContacts.ExtensionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetExtensionNull()
    {
      this[this.tabletblProducerContacts.ExtensionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCellNull() => this.IsNull(this.tabletblProducerContacts.CellColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCellNull()
    {
      this[this.tabletblProducerContacts.CellColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tabletblProducerContacts.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEmailNull()
    {
      this[this.tabletblProducerContacts.EmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStatusIDNull() => this.IsNull(this.tabletblProducerContacts.StatusIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatusIDNull()
    {
      this[this.tabletblProducerContacts.StatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDeliveryMethodIDNull()
    {
      return this.IsNull(this.tabletblProducerContacts.DeliveryMethodIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDeliveryMethodIDNull()
    {
      this[this.tabletblProducerContacts.DeliveryMethodIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabletblProducerContacts.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabletblProducerContacts.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSSNoNull() => this.IsNull(this.tabletblProducerContacts.SSNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSSNoNull()
    {
      this[this.tabletblProducerContacts.SSNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsReq1099Null() => this.IsNull(this.tabletblProducerContacts.Req1099Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetReq1099Null()
    {
      this[this.tabletblProducerContacts.Req1099Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFaxNull() => this.IsNull(this.tabletblProducerContacts.FaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFaxNull()
    {
      this[this.tabletblProducerContacts.FaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOptOutNull() => this.IsNull(this.tabletblProducerContacts.OptOutColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOptOutNull()
    {
      this[this.tabletblProducerContacts.OptOutColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddByUserIDNull() => this.IsNull(this.tabletblProducerContacts.AddByUserIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddByUserIDNull()
    {
      this[this.tabletblProducerContacts.AddByUserIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateAddedNull() => this.IsNull(this.tabletblProducerContacts.DateAddedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateAddedNull()
    {
      this[this.tabletblProducerContacts.DateAddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateModifiedNull()
    {
      return this.IsNull(this.tabletblProducerContacts.DateModifiedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateModifiedNull()
    {
      this[this.tabletblProducerContacts.DateModifiedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEmailEditedByNull()
    {
      return this.IsNull(this.tabletblProducerContacts.EmailEditedByColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEmailEditedByNull()
    {
      this[this.tabletblProducerContacts.EmailEditedByColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateEmailEditedNull()
    {
      return this.IsNull(this.tabletblProducerContacts.DateEmailEditedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateEmailEditedNull()
    {
      this[this.tabletblProducerContacts.DateEmailEditedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsManagedByNull() => this.IsNull(this.tabletblProducerContacts.ManagedByColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetManagedByNull()
    {
      this[this.tabletblProducerContacts.ManagedByColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNPNNoNull() => this.IsNull(this.tabletblProducerContacts.NPNNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNPNNoNull()
    {
      this[this.tabletblProducerContacts.NPNNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsISOCountryCodeNull()
    {
      return this.IsNull(this.tabletblProducerContacts.ISOCountryCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetISOCountryCodeNull()
    {
      this[this.tabletblProducerContacts.ISOCountryCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddress1Null() => this.IsNull(this.tabletblProducerContacts.Address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabletblProducerContacts.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddress2Null() => this.IsNull(this.tabletblProducerContacts.Address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabletblProducerContacts.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabletblProducerContacts.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabletblProducerContacts.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabletblProducerContacts.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblProducerContacts.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tabletblProducerContacts.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tabletblProducerContacts.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsZipPlusNull() => this.IsNull(this.tabletblProducerContacts.ZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetZipPlusNull()
    {
      this[this.tabletblProducerContacts.ZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCountyNull() => this.IsNull(this.tabletblProducerContacts.CountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCountyNull()
    {
      this[this.tabletblProducerContacts.CountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDOBNull() => this.IsNull(this.tabletblProducerContacts.DOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDOBNull()
    {
      this[this.tabletblProducerContacts.DOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCEWaivedNull() => this.IsNull(this.tabletblProducerContacts.CEWaivedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCEWaivedNull()
    {
      this[this.tabletblProducerContacts.CEWaivedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCommentNull() => this.IsNull(this.tabletblProducerContacts.CommentColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCommentNull()
    {
      this[this.tabletblProducerContacts.CommentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerSpecialContactsRow[] GettblProducerSpecialContactsRows()
    {
      return this.Table.ChildRelations["tblProducerContactstblProducerSpecialContacts"] != null ? (dsProducerContacts.tblProducerSpecialContactsRow[]) this.GetChildRows(this.Table.ChildRelations["tblProducerContactstblProducerSpecialContacts"]) : new dsProducerContacts.tblProducerSpecialContactsRow[0];
    }
  }

  public class lstProducerSpecialContactTypesRow : DataRow
  {
    private dsProducerContacts.lstProducerSpecialContactTypesDataTable tablelstProducerSpecialContactTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstProducerSpecialContactTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstProducerSpecialContactTypes = (dsProducerContacts.lstProducerSpecialContactTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int SpecialContactTypeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tablelstProducerSpecialContactTypes.SpecialContactTypeIDColumn]);
      }
      set
      {
        this[this.tablelstProducerSpecialContactTypes.SpecialContactTypeIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string SpecialContactType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstProducerSpecialContactTypes.SpecialContactTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SpecialContactType' in table 'lstProducerSpecialContactTypes' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablelstProducerSpecialContactTypes.SpecialContactTypeColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Hidden
    {
      get => Conversions.ToBoolean(this[this.tablelstProducerSpecialContactTypes.HiddenColumn]);
      set => this[this.tablelstProducerSpecialContactTypes.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSpecialContactTypeNull()
    {
      return this.IsNull(this.tablelstProducerSpecialContactTypes.SpecialContactTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSpecialContactTypeNull()
    {
      this[this.tablelstProducerSpecialContactTypes.SpecialContactTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerSpecialContactsRow[] GettblProducerSpecialContactsRows()
    {
      return this.Table.ChildRelations["lstProducerSpecialContactTypestblProducerSpecialContacts"] != null ? (dsProducerContacts.tblProducerSpecialContactsRow[]) this.GetChildRows(this.Table.ChildRelations["lstProducerSpecialContactTypestblProducerSpecialContacts"]) : new dsProducerContacts.tblProducerSpecialContactsRow[0];
    }
  }

  public class lstDeliveryMethodRow : DataRow
  {
    private dsProducerContacts.lstDeliveryMethodDataTable tablelstDeliveryMethod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstDeliveryMethodRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstDeliveryMethod = (dsProducerContacts.lstDeliveryMethodDataTable) this.Table;
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
      get => Conversions.ToString(this[this.tablelstDeliveryMethod.DescriptionColumn]);
      set => this[this.tablelstDeliveryMethod.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactsRow[] GettblProducerContactsRows()
    {
      return this.Table.ChildRelations["lstDeliveryMethodtblProducerContacts"] != null ? (dsProducerContacts.tblProducerContactsRow[]) this.GetChildRows(this.Table.ChildRelations["lstDeliveryMethodtblProducerContacts"]) : new dsProducerContacts.tblProducerContactsRow[0];
    }
  }

  public class lstStatusRow : DataRow
  {
    private dsProducerContacts.lstStatusDataTable tablelstStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstStatusRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStatus = (dsProducerContacts.lstStatusDataTable) this.Table;
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
    public dsProducerContacts.tblProducerContactsRow[] GettblProducerContactsRows()
    {
      return this.Table.ChildRelations["lstStatustblProducerContacts"] != null ? (dsProducerContacts.tblProducerContactsRow[]) this.GetChildRows(this.Table.ChildRelations["lstStatustblProducerContacts"]) : new dsProducerContacts.tblProducerContactsRow[0];
    }
  }

  public class tblProducerSpecialContactsRow : DataRow
  {
    private dsProducerContacts.tblProducerSpecialContactsDataTable tabletblProducerSpecialContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducerSpecialContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerSpecialContacts = (dsProducerContacts.tblProducerSpecialContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ProducerContactGUID
    {
      get
      {
        object obj = this[this.tabletblProducerSpecialContacts.ProducerContactGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducerSpecialContacts.ProducerContactGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int SpecialContactTypeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblProducerSpecialContacts.SpecialContactTypeIDColumn]);
      }
      set => this[this.tabletblProducerSpecialContacts.SpecialContactTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerSpecialContactTypesRow lstProducerSpecialContactTypesRow
    {
      get
      {
        return (dsProducerContacts.lstProducerSpecialContactTypesRow) this.GetParentRow(this.Table.ParentRelations["lstProducerSpecialContactTypestblProducerSpecialContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstProducerSpecialContactTypestblProducerSpecialContacts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactsRow tblProducerContactsRow
    {
      get
      {
        return (dsProducerContacts.tblProducerContactsRow) this.GetParentRow(this.Table.ParentRelations["tblProducerContactstblProducerSpecialContacts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblProducerContactstblProducerSpecialContacts"]);
      }
    }
  }

  public class lstSalutationsRow : DataRow
  {
    private dsProducerContacts.lstSalutationsDataTable tablelstSalutations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstSalutationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstSalutations = (dsProducerContacts.lstSalutationsDataTable) this.Table;
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
    public dsProducerContacts.tblProducerContactsRow[] GettblProducerContactsRows()
    {
      return this.Table.ChildRelations["lstSalutationstblProducerContacts"] != null ? (dsProducerContacts.tblProducerContactsRow[]) this.GetChildRows(this.Table.ChildRelations["lstSalutationstblProducerContacts"]) : new dsProducerContacts.tblProducerContactsRow[0];
    }
  }

  public class lstProducerContactInterestsRow : DataRow
  {
    private dsProducerContacts.lstProducerContactInterestsDataTable tablelstProducerContactInterests;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstProducerContactInterestsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstProducerContactInterests = (dsProducerContacts.lstProducerContactInterestsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int IntID
    {
      get => Conversions.ToInteger(this[this.tablelstProducerContactInterests.IntIDColumn]);
      set => this[this.tablelstProducerContactInterests.IntIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ContactInterest
    {
      get
      {
        return Conversions.ToString(this[this.tablelstProducerContactInterests.ContactInterestColumn]);
      }
      set => this[this.tablelstProducerContactInterests.ContactInterestColumn] = (object) value;
    }
  }

  public class lstProducerContactJobFunctionRow : DataRow
  {
    private dsProducerContacts.lstProducerContactJobFunctionDataTable tablelstProducerContactJobFunction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstProducerContactJobFunctionRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstProducerContactJobFunction = (dsProducerContacts.lstProducerContactJobFunctionDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int JobFunctionID
    {
      get
      {
        return Conversions.ToInteger(this[this.tablelstProducerContactJobFunction.JobFunctionIDColumn]);
      }
      set => this[this.tablelstProducerContactJobFunction.JobFunctionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string JobFunction
    {
      get => Conversions.ToString(this[this.tablelstProducerContactJobFunction.JobFunctionColumn]);
      set => this[this.tablelstProducerContactJobFunction.JobFunctionColumn] = (object) value;
    }
  }

  public class tblProducerContactInterestsRow : DataRow
  {
    private dsProducerContacts.tblProducerContactInterestsDataTable tabletblProducerContactInterests;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducerContactInterestsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerContactInterests = (dsProducerContacts.tblProducerContactInterestsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ProducerContactGuid
    {
      get
      {
        object obj = this[this.tabletblProducerContactInterests.ProducerContactGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducerContactInterests.ProducerContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int IntID
    {
      get => Conversions.ToInteger(this[this.tabletblProducerContactInterests.IntIDColumn]);
      set => this[this.tabletblProducerContactInterests.IntIDColumn] = (object) value;
    }
  }

  public class tblProducerContactJobFunctionsRow : DataRow
  {
    private dsProducerContacts.tblProducerContactJobFunctionsDataTable tabletblProducerContactJobFunctions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducerContactJobFunctionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerContactJobFunctions = (dsProducerContacts.tblProducerContactJobFunctionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ProducerContactGuid
    {
      get
      {
        object obj = this[this.tabletblProducerContactJobFunctions.ProducerContactGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set
      {
        this[this.tabletblProducerContactJobFunctions.ProducerContactGuidColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int JobFunctionID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblProducerContactJobFunctions.JobFunctionIDColumn]);
      }
      set => this[this.tabletblProducerContactJobFunctions.JobFunctionIDColumn] = (object) value;
    }
  }

  public class tblProducerContactsCopyRow : DataRow
  {
    private dsProducerContacts.tblProducerContactsCopyDataTable tabletblProducerContactsCopy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducerContactsCopyRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerContactsCopy = (dsProducerContacts.tblProducerContactsCopyDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ProducerContactGUID
    {
      get
      {
        object obj = this[this.tabletblProducerContactsCopy.ProducerContactGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducerContactsCopy.ProducerContactGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContactsCopy.NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name' in table 'tblProducerContactsCopy' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContactsCopy.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabletblProducerContactsCopy.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabletblProducerContactsCopy.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblProducerContactsRowChangeEvent : EventArgs
  {
    private dsProducerContacts.tblProducerContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerContactsRowChangeEvent(
      dsProducerContacts.tblProducerContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstProducerSpecialContactTypesRowChangeEvent : EventArgs
  {
    private dsProducerContacts.lstProducerSpecialContactTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstProducerSpecialContactTypesRowChangeEvent(
      dsProducerContacts.lstProducerSpecialContactTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerSpecialContactTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstDeliveryMethodRowChangeEvent : EventArgs
  {
    private dsProducerContacts.lstDeliveryMethodRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstDeliveryMethodRowChangeEvent(
      dsProducerContacts.lstDeliveryMethodRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstDeliveryMethodRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstStatusRowChangeEvent : EventArgs
  {
    private dsProducerContacts.lstStatusRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstStatusRowChangeEvent(dsProducerContacts.lstStatusRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstStatusRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblProducerSpecialContactsRowChangeEvent : EventArgs
  {
    private dsProducerContacts.tblProducerSpecialContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerSpecialContactsRowChangeEvent(
      dsProducerContacts.tblProducerSpecialContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerSpecialContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstSalutationsRowChangeEvent : EventArgs
  {
    private dsProducerContacts.lstSalutationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstSalutationsRowChangeEvent(
      dsProducerContacts.lstSalutationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstSalutationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstProducerContactInterestsRowChangeEvent : EventArgs
  {
    private dsProducerContacts.lstProducerContactInterestsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstProducerContactInterestsRowChangeEvent(
      dsProducerContacts.lstProducerContactInterestsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerContactInterestsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstProducerContactJobFunctionRowChangeEvent : EventArgs
  {
    private dsProducerContacts.lstProducerContactJobFunctionRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstProducerContactJobFunctionRowChangeEvent(
      dsProducerContacts.lstProducerContactJobFunctionRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.lstProducerContactJobFunctionRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblProducerContactInterestsRowChangeEvent : EventArgs
  {
    private dsProducerContacts.tblProducerContactInterestsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerContactInterestsRowChangeEvent(
      dsProducerContacts.tblProducerContactInterestsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactInterestsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblProducerContactJobFunctionsRowChangeEvent : EventArgs
  {
    private dsProducerContacts.tblProducerContactJobFunctionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerContactJobFunctionsRowChangeEvent(
      dsProducerContacts.tblProducerContactJobFunctionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactJobFunctionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblProducerContactsCopyRowChangeEvent : EventArgs
  {
    private dsProducerContacts.tblProducerContactsCopyRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerContactsCopyRowChangeEvent(
      dsProducerContacts.tblProducerContactsCopyRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProducerContacts.tblProducerContactsCopyRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
