// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormsConditionsWarranties.dsPolicyFCW
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
namespace MGASystems.IMS.Policies.FormsConditionsWarranties;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPolicyFCW")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPolicyFCW : DataSet
{
  private dsPolicyFCW.tblQuoteFormsConditionsWarrantiesDataTable tabletblQuoteFormsConditionsWarranties;
  private dsPolicyFCW.tblConditionsDataTable tabletblConditions;
  private dsPolicyFCW.tblPolicyFormsDataTable tabletblPolicyForms;
  private dsPolicyFCW.tblWarrantiesDataTable tabletblWarranties;
  private dsPolicyFCW.tblWarrantyFormsDataTable tabletblWarrantyForms;
  private dsPolicyFCW.tblNetRateAdditionalDataDataTable tabletblNetRateAdditionalData;
  private dsPolicyFCW.tblUsersDataTable tabletblUsers;
  private dsPolicyFCW.tblWarrantiesAssociatedFormsDataTable tabletblWarrantiesAssociatedForms;
  private DataRelation relationtblWarrantiestblQuoteFormsConditionsWarranties;
  private DataRelation relationtblPolicyFormstblQuoteFormsConditionsWarranties;
  private DataRelation relationtblConditionstblQuoteFormsConditionsWarranties;
  private DataRelation relationtblPolicyFormstblWarrantyForms;
  private DataRelation relationtblWarrantiestblWarrantyForms;
  private DataRelation relationtblUsers_tblQuoteFormsConditionsWarranties;
  private DataRelation relationtblUsers_tblQuoteFormsConditionsWarranties1;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsPolicyFCW()
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
  protected dsPolicyFCW(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblQuoteFormsConditionsWarranties)] != null)
          base.Tables.Add((DataTable) new dsPolicyFCW.tblQuoteFormsConditionsWarrantiesDataTable(dataSet.Tables[nameof (tblQuoteFormsConditionsWarranties)]));
        if (dataSet.Tables[nameof (tblConditions)] != null)
          base.Tables.Add((DataTable) new dsPolicyFCW.tblConditionsDataTable(dataSet.Tables[nameof (tblConditions)]));
        if (dataSet.Tables[nameof (tblPolicyForms)] != null)
          base.Tables.Add((DataTable) new dsPolicyFCW.tblPolicyFormsDataTable(dataSet.Tables[nameof (tblPolicyForms)]));
        if (dataSet.Tables[nameof (tblWarranties)] != null)
          base.Tables.Add((DataTable) new dsPolicyFCW.tblWarrantiesDataTable(dataSet.Tables[nameof (tblWarranties)]));
        if (dataSet.Tables[nameof (tblWarrantyForms)] != null)
          base.Tables.Add((DataTable) new dsPolicyFCW.tblWarrantyFormsDataTable(dataSet.Tables[nameof (tblWarrantyForms)]));
        if (dataSet.Tables[nameof (tblNetRateAdditionalData)] != null)
          base.Tables.Add((DataTable) new dsPolicyFCW.tblNetRateAdditionalDataDataTable(dataSet.Tables[nameof (tblNetRateAdditionalData)]));
        if (dataSet.Tables[nameof (tblUsers)] != null)
          base.Tables.Add((DataTable) new dsPolicyFCW.tblUsersDataTable(dataSet.Tables[nameof (tblUsers)]));
        if (dataSet.Tables[nameof (tblWarrantiesAssociatedForms)] != null)
          base.Tables.Add((DataTable) new dsPolicyFCW.tblWarrantiesAssociatedFormsDataTable(dataSet.Tables[nameof (tblWarrantiesAssociatedForms)]));
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
  public dsPolicyFCW.tblQuoteFormsConditionsWarrantiesDataTable tblQuoteFormsConditionsWarranties
  {
    get => this.tabletblQuoteFormsConditionsWarranties;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyFCW.tblConditionsDataTable tblConditions => this.tabletblConditions;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyFCW.tblPolicyFormsDataTable tblPolicyForms => this.tabletblPolicyForms;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyFCW.tblWarrantiesDataTable tblWarranties => this.tabletblWarranties;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyFCW.tblWarrantyFormsDataTable tblWarrantyForms => this.tabletblWarrantyForms;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyFCW.tblNetRateAdditionalDataDataTable tblNetRateAdditionalData
  {
    get => this.tabletblNetRateAdditionalData;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyFCW.tblUsersDataTable tblUsers => this.tabletblUsers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyFCW.tblWarrantiesAssociatedFormsDataTable tblWarrantiesAssociatedForms
  {
    get => this.tabletblWarrantiesAssociatedForms;
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
    dsPolicyFCW dsPolicyFcw = (dsPolicyFCW) base.Clone();
    dsPolicyFcw.InitVars();
    dsPolicyFcw.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsPolicyFcw;
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
      if (dataSet.Tables["tblQuoteFormsConditionsWarranties"] != null)
        base.Tables.Add((DataTable) new dsPolicyFCW.tblQuoteFormsConditionsWarrantiesDataTable(dataSet.Tables["tblQuoteFormsConditionsWarranties"]));
      if (dataSet.Tables["tblConditions"] != null)
        base.Tables.Add((DataTable) new dsPolicyFCW.tblConditionsDataTable(dataSet.Tables["tblConditions"]));
      if (dataSet.Tables["tblPolicyForms"] != null)
        base.Tables.Add((DataTable) new dsPolicyFCW.tblPolicyFormsDataTable(dataSet.Tables["tblPolicyForms"]));
      if (dataSet.Tables["tblWarranties"] != null)
        base.Tables.Add((DataTable) new dsPolicyFCW.tblWarrantiesDataTable(dataSet.Tables["tblWarranties"]));
      if (dataSet.Tables["tblWarrantyForms"] != null)
        base.Tables.Add((DataTable) new dsPolicyFCW.tblWarrantyFormsDataTable(dataSet.Tables["tblWarrantyForms"]));
      if (dataSet.Tables["tblNetRateAdditionalData"] != null)
        base.Tables.Add((DataTable) new dsPolicyFCW.tblNetRateAdditionalDataDataTable(dataSet.Tables["tblNetRateAdditionalData"]));
      if (dataSet.Tables["tblUsers"] != null)
        base.Tables.Add((DataTable) new dsPolicyFCW.tblUsersDataTable(dataSet.Tables["tblUsers"]));
      if (dataSet.Tables["tblWarrantiesAssociatedForms"] != null)
        base.Tables.Add((DataTable) new dsPolicyFCW.tblWarrantiesAssociatedFormsDataTable(dataSet.Tables["tblWarrantiesAssociatedForms"]));
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
    this.tabletblQuoteFormsConditionsWarranties = (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesDataTable) base.Tables["tblQuoteFormsConditionsWarranties"];
    if (initTable && this.tabletblQuoteFormsConditionsWarranties != null)
      this.tabletblQuoteFormsConditionsWarranties.InitVars();
    this.tabletblConditions = (dsPolicyFCW.tblConditionsDataTable) base.Tables["tblConditions"];
    if (initTable && this.tabletblConditions != null)
      this.tabletblConditions.InitVars();
    this.tabletblPolicyForms = (dsPolicyFCW.tblPolicyFormsDataTable) base.Tables["tblPolicyForms"];
    if (initTable && this.tabletblPolicyForms != null)
      this.tabletblPolicyForms.InitVars();
    this.tabletblWarranties = (dsPolicyFCW.tblWarrantiesDataTable) base.Tables["tblWarranties"];
    if (initTable && this.tabletblWarranties != null)
      this.tabletblWarranties.InitVars();
    this.tabletblWarrantyForms = (dsPolicyFCW.tblWarrantyFormsDataTable) base.Tables["tblWarrantyForms"];
    if (initTable && this.tabletblWarrantyForms != null)
      this.tabletblWarrantyForms.InitVars();
    this.tabletblNetRateAdditionalData = (dsPolicyFCW.tblNetRateAdditionalDataDataTable) base.Tables["tblNetRateAdditionalData"];
    if (initTable && this.tabletblNetRateAdditionalData != null)
      this.tabletblNetRateAdditionalData.InitVars();
    this.tabletblUsers = (dsPolicyFCW.tblUsersDataTable) base.Tables["tblUsers"];
    if (initTable && this.tabletblUsers != null)
      this.tabletblUsers.InitVars();
    this.tabletblWarrantiesAssociatedForms = (dsPolicyFCW.tblWarrantiesAssociatedFormsDataTable) base.Tables["tblWarrantiesAssociatedForms"];
    if (initTable && this.tabletblWarrantiesAssociatedForms != null)
      this.tabletblWarrantiesAssociatedForms.InitVars();
    this.relationtblWarrantiestblQuoteFormsConditionsWarranties = this.Relations["tblWarrantiestblQuoteFormsConditionsWarranties"];
    this.relationtblPolicyFormstblQuoteFormsConditionsWarranties = this.Relations["tblPolicyFormstblQuoteFormsConditionsWarranties"];
    this.relationtblConditionstblQuoteFormsConditionsWarranties = this.Relations["tblConditionstblQuoteFormsConditionsWarranties"];
    this.relationtblPolicyFormstblWarrantyForms = this.Relations["tblPolicyFormstblWarrantyForms"];
    this.relationtblWarrantiestblWarrantyForms = this.Relations["tblWarrantiestblWarrantyForms"];
    this.relationtblUsers_tblQuoteFormsConditionsWarranties = this.Relations["tblUsers_tblQuoteFormsConditionsWarranties"];
    this.relationtblUsers_tblQuoteFormsConditionsWarranties1 = this.Relations["tblUsers_tblQuoteFormsConditionsWarranties1"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPolicyFCW);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsPolicyFCW.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblQuoteFormsConditionsWarranties = new dsPolicyFCW.tblQuoteFormsConditionsWarrantiesDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteFormsConditionsWarranties);
    this.tabletblConditions = new dsPolicyFCW.tblConditionsDataTable();
    base.Tables.Add((DataTable) this.tabletblConditions);
    this.tabletblPolicyForms = new dsPolicyFCW.tblPolicyFormsDataTable();
    base.Tables.Add((DataTable) this.tabletblPolicyForms);
    this.tabletblWarranties = new dsPolicyFCW.tblWarrantiesDataTable();
    base.Tables.Add((DataTable) this.tabletblWarranties);
    this.tabletblWarrantyForms = new dsPolicyFCW.tblWarrantyFormsDataTable();
    base.Tables.Add((DataTable) this.tabletblWarrantyForms);
    this.tabletblNetRateAdditionalData = new dsPolicyFCW.tblNetRateAdditionalDataDataTable();
    base.Tables.Add((DataTable) this.tabletblNetRateAdditionalData);
    this.tabletblUsers = new dsPolicyFCW.tblUsersDataTable();
    base.Tables.Add((DataTable) this.tabletblUsers);
    this.tabletblWarrantiesAssociatedForms = new dsPolicyFCW.tblWarrantiesAssociatedFormsDataTable();
    base.Tables.Add((DataTable) this.tabletblWarrantiesAssociatedForms);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("tblWarrantiestblQuoteFormsConditionsWarranties", new DataColumn[1]
    {
      this.tabletblWarranties.WarrantyIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteFormsConditionsWarranties.WarrantyIDColumn
    });
    this.tabletblQuoteFormsConditionsWarranties.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("tblPolicyFormstblQuoteFormsConditionsWarranties", new DataColumn[1]
    {
      this.tabletblPolicyForms.FormIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteFormsConditionsWarranties.PolicyFormIDColumn
    });
    this.tabletblQuoteFormsConditionsWarranties.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("tblConditionstblQuoteFormsConditionsWarranties", new DataColumn[1]
    {
      this.tabletblConditions.ConditionIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteFormsConditionsWarranties.ConditionIDColumn
    });
    this.tabletblQuoteFormsConditionsWarranties.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("tblPolicyFormstblWarrantyForms", new DataColumn[1]
    {
      this.tabletblPolicyForms.FormIDColumn
    }, new DataColumn[1]
    {
      this.tabletblWarrantyForms.PolicyFormIDColumn
    });
    this.tabletblWarrantyForms.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint5 = new ForeignKeyConstraint("tblWarrantiestblWarrantyForms", new DataColumn[1]
    {
      this.tabletblWarranties.WarrantyIDColumn
    }, new DataColumn[1]
    {
      this.tabletblWarrantyForms.WarrantyIDColumn
    });
    this.tabletblWarrantyForms.Constraints.Add((Constraint) foreignKeyConstraint5);
    foreignKeyConstraint5.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint5.DeleteRule = Rule.Cascade;
    foreignKeyConstraint5.UpdateRule = Rule.Cascade;
    this.relationtblWarrantiestblQuoteFormsConditionsWarranties = new DataRelation("tblWarrantiestblQuoteFormsConditionsWarranties", new DataColumn[1]
    {
      this.tabletblWarranties.WarrantyIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteFormsConditionsWarranties.WarrantyIDColumn
    }, false);
    this.Relations.Add(this.relationtblWarrantiestblQuoteFormsConditionsWarranties);
    this.relationtblPolicyFormstblQuoteFormsConditionsWarranties = new DataRelation("tblPolicyFormstblQuoteFormsConditionsWarranties", new DataColumn[1]
    {
      this.tabletblPolicyForms.FormIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteFormsConditionsWarranties.PolicyFormIDColumn
    }, false);
    this.Relations.Add(this.relationtblPolicyFormstblQuoteFormsConditionsWarranties);
    this.relationtblConditionstblQuoteFormsConditionsWarranties = new DataRelation("tblConditionstblQuoteFormsConditionsWarranties", new DataColumn[1]
    {
      this.tabletblConditions.ConditionIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteFormsConditionsWarranties.ConditionIDColumn
    }, false);
    this.Relations.Add(this.relationtblConditionstblQuoteFormsConditionsWarranties);
    this.relationtblPolicyFormstblWarrantyForms = new DataRelation("tblPolicyFormstblWarrantyForms", new DataColumn[1]
    {
      this.tabletblPolicyForms.FormIDColumn
    }, new DataColumn[1]
    {
      this.tabletblWarrantyForms.PolicyFormIDColumn
    }, false);
    this.Relations.Add(this.relationtblPolicyFormstblWarrantyForms);
    this.relationtblWarrantiestblWarrantyForms = new DataRelation("tblWarrantiestblWarrantyForms", new DataColumn[1]
    {
      this.tabletblWarranties.WarrantyIDColumn
    }, new DataColumn[1]
    {
      this.tabletblWarrantyForms.WarrantyIDColumn
    }, false);
    this.Relations.Add(this.relationtblWarrantiestblWarrantyForms);
    this.relationtblUsers_tblQuoteFormsConditionsWarranties = new DataRelation("tblUsers_tblQuoteFormsConditionsWarranties", new DataColumn[1]
    {
      this.tabletblUsers.UserGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteFormsConditionsWarranties.WaivedByUserGuidColumn
    }, false);
    this.Relations.Add(this.relationtblUsers_tblQuoteFormsConditionsWarranties);
    this.relationtblUsers_tblQuoteFormsConditionsWarranties1 = new DataRelation("tblUsers_tblQuoteFormsConditionsWarranties1", new DataColumn[1]
    {
      this.tabletblUsers.UserGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteFormsConditionsWarranties.AddedByUserGuidColumn
    }, false);
    this.Relations.Add(this.relationtblUsers_tblQuoteFormsConditionsWarranties1);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblQuoteFormsConditionsWarranties() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblConditions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblPolicyForms() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblWarranties() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblWarrantyForms() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblNetRateAdditionalData() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblUsers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblWarrantiesAssociatedForms() => false;

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
    dsPolicyFCW dsPolicyFcw = new dsPolicyFCW();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsPolicyFcw.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsPolicyFcw.GetSchemaSerializable();
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
  public delegate void tblQuoteFormsConditionsWarrantiesRowChangeEventHandler(
    object sender,
    dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblConditionsRowChangeEventHandler(
    object sender,
    dsPolicyFCW.tblConditionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblPolicyFormsRowChangeEventHandler(
    object sender,
    dsPolicyFCW.tblPolicyFormsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblWarrantiesRowChangeEventHandler(
    object sender,
    dsPolicyFCW.tblWarrantiesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblWarrantyFormsRowChangeEventHandler(
    object sender,
    dsPolicyFCW.tblWarrantyFormsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblNetRateAdditionalDataRowChangeEventHandler(
    object sender,
    dsPolicyFCW.tblNetRateAdditionalDataRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblUsersRowChangeEventHandler(
    object sender,
    dsPolicyFCW.tblUsersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblWarrantiesAssociatedFormsRowChangeEventHandler(
    object sender,
    dsPolicyFCW.tblWarrantiesAssociatedFormsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblQuoteFormsConditionsWarrantiesDataTable : 
    TypedTableBase<dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow>
  {
    private DataColumn columnQuote_FCW_ID;
    private DataColumn columnQuoteID;
    private DataColumn columnPolicyFormID;
    private DataColumn columnConditionID;
    private DataColumn columnWarrantyID;
    private DataColumn columnEndorsementNum;
    private DataColumn columnDeleted;
    private DataColumn columnOriginalID;
    private DataColumn columnWaivedByUserGuid;
    private DataColumn columnAllowDuplicates;
    private DataColumn columnAddedByUserGuid;
    private DataColumn columnMandatory;
    private DataColumn columnCompany_FCW_ID;
    private DataColumn columnAdded;
    private DataColumn columnPolicyFormComments;
    private DataColumn columnCompanyLineID;
    private DataColumn columnRaterID;
    private DataColumn columnRaterConditionalID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuoteFormsConditionsWarrantiesDataTable()
    {
      this.TableName = "tblQuoteFormsConditionsWarranties";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuoteFormsConditionsWarrantiesDataTable(DataTable table)
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
    protected tblQuoteFormsConditionsWarrantiesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Quote_FCW_IDColumn => this.columnQuote_FCW_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyFormIDColumn => this.columnPolicyFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ConditionIDColumn => this.columnConditionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WarrantyIDColumn => this.columnWarrantyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EndorsementNumColumn => this.columnEndorsementNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DeletedColumn => this.columnDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OriginalIDColumn => this.columnOriginalID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WaivedByUserGuidColumn => this.columnWaivedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AllowDuplicatesColumn => this.columnAllowDuplicates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AddedByUserGuidColumn => this.columnAddedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MandatoryColumn => this.columnMandatory;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Company_FCW_IDColumn => this.columnCompany_FCW_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AddedColumn => this.columnAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyFormCommentsColumn => this.columnPolicyFormComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineIDColumn => this.columnCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RaterIDColumn => this.columnRaterID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RaterConditionalIDColumn => this.columnRaterConditionalID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow this[int index]
    {
      get => (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRowChangeEventHandler tblQuoteFormsConditionsWarrantiesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRowChangeEventHandler tblQuoteFormsConditionsWarrantiesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRowChangeEventHandler tblQuoteFormsConditionsWarrantiesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRowChangeEventHandler tblQuoteFormsConditionsWarrantiesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblQuoteFormsConditionsWarrantiesRow(
      dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow AddtblQuoteFormsConditionsWarrantiesRow(
      int QuoteID,
      dsPolicyFCW.tblPolicyFormsRow parenttblPolicyFormsRowBytblPolicyFormstblQuoteFormsConditionsWarranties,
      dsPolicyFCW.tblConditionsRow parenttblConditionsRowBytblConditionstblQuoteFormsConditionsWarranties,
      dsPolicyFCW.tblWarrantiesRow parenttblWarrantiesRowBytblWarrantiestblQuoteFormsConditionsWarranties,
      string EndorsementNum,
      bool Deleted,
      int OriginalID,
      dsPolicyFCW.tblUsersRow parenttblUsersRowBytblUsers_tblQuoteFormsConditionsWarranties,
      bool AllowDuplicates,
      dsPolicyFCW.tblUsersRow parenttblUsersRowBytblUsers_tblQuoteFormsConditionsWarranties1,
      bool Mandatory,
      int Company_FCW_ID,
      DateTime Added,
      string PolicyFormComments,
      int CompanyLineID,
      int RaterID,
      int RaterConditionalID)
    {
      dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow row = (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow) this.NewRow();
      object[] objArray = new object[18]
      {
        null,
        (object) QuoteID,
        null,
        null,
        null,
        (object) EndorsementNum,
        (object) Deleted,
        (object) OriginalID,
        null,
        (object) AllowDuplicates,
        null,
        (object) Mandatory,
        (object) Company_FCW_ID,
        (object) Added,
        (object) PolicyFormComments,
        (object) CompanyLineID,
        (object) RaterID,
        (object) RaterConditionalID
      };
      if (parenttblPolicyFormsRowBytblPolicyFormstblQuoteFormsConditionsWarranties != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parenttblPolicyFormsRowBytblPolicyFormstblQuoteFormsConditionsWarranties[0]);
      if (parenttblConditionsRowBytblConditionstblQuoteFormsConditionsWarranties != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parenttblConditionsRowBytblConditionstblQuoteFormsConditionsWarranties[0]);
      if (parenttblWarrantiesRowBytblWarrantiestblQuoteFormsConditionsWarranties != null)
        objArray[4] = RuntimeHelpers.GetObjectValue(parenttblWarrantiesRowBytblWarrantiestblQuoteFormsConditionsWarranties[0]);
      if (parenttblUsersRowBytblUsers_tblQuoteFormsConditionsWarranties != null)
        objArray[8] = RuntimeHelpers.GetObjectValue(parenttblUsersRowBytblUsers_tblQuoteFormsConditionsWarranties[0]);
      if (parenttblUsersRowBytblUsers_tblQuoteFormsConditionsWarranties1 != null)
        objArray[10] = RuntimeHelpers.GetObjectValue(parenttblUsersRowBytblUsers_tblQuoteFormsConditionsWarranties1[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow FindByQuote_FCW_ID(int Quote_FCW_ID)
    {
      return (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow) this.Rows.Find(new object[1]
      {
        (object) Quote_FCW_ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyFCW.tblQuoteFormsConditionsWarrantiesDataTable warrantiesDataTable = (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesDataTable) base.Clone();
      warrantiesDataTable.InitVars();
      return (DataTable) warrantiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyFCW.tblQuoteFormsConditionsWarrantiesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnQuote_FCW_ID = this.Columns["Quote_FCW_ID"];
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnPolicyFormID = this.Columns["PolicyFormID"];
      this.columnConditionID = this.Columns["ConditionID"];
      this.columnWarrantyID = this.Columns["WarrantyID"];
      this.columnEndorsementNum = this.Columns["EndorsementNum"];
      this.columnDeleted = this.Columns["Deleted"];
      this.columnOriginalID = this.Columns["OriginalID"];
      this.columnWaivedByUserGuid = this.Columns["WaivedByUserGuid"];
      this.columnAllowDuplicates = this.Columns["AllowDuplicates"];
      this.columnAddedByUserGuid = this.Columns["AddedByUserGuid"];
      this.columnMandatory = this.Columns["Mandatory"];
      this.columnCompany_FCW_ID = this.Columns["Company_FCW_ID"];
      this.columnAdded = this.Columns["Added"];
      this.columnPolicyFormComments = this.Columns["PolicyFormComments"];
      this.columnCompanyLineID = this.Columns["CompanyLineID"];
      this.columnRaterID = this.Columns["RaterID"];
      this.columnRaterConditionalID = this.Columns["RaterConditionalID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnQuote_FCW_ID = new DataColumn("Quote_FCW_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuote_FCW_ID);
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnPolicyFormID = new DataColumn("PolicyFormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyFormID);
      this.columnConditionID = new DataColumn("ConditionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConditionID);
      this.columnWarrantyID = new DataColumn("WarrantyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWarrantyID);
      this.columnEndorsementNum = new DataColumn("EndorsementNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementNum);
      this.columnDeleted = new DataColumn("Deleted", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeleted);
      this.columnOriginalID = new DataColumn("OriginalID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOriginalID);
      this.columnWaivedByUserGuid = new DataColumn("WaivedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWaivedByUserGuid);
      this.columnAllowDuplicates = new DataColumn("AllowDuplicates", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAllowDuplicates);
      this.columnAddedByUserGuid = new DataColumn("AddedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddedByUserGuid);
      this.columnMandatory = new DataColumn("Mandatory", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMandatory);
      this.columnCompany_FCW_ID = new DataColumn("Company_FCW_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany_FCW_ID);
      this.columnAdded = new DataColumn("Added", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdded);
      this.columnPolicyFormComments = new DataColumn("PolicyFormComments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyFormComments);
      this.columnCompanyLineID = new DataColumn("CompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineID);
      this.columnRaterID = new DataColumn("RaterID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRaterID);
      this.columnRaterConditionalID = new DataColumn("RaterConditionalID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRaterConditionalID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnQuote_FCW_ID
      }, true));
      this.columnQuote_FCW_ID.AutoIncrement = true;
      this.columnQuote_FCW_ID.AutoIncrementSeed = -1L;
      this.columnQuote_FCW_ID.AutoIncrementStep = -1L;
      this.columnQuote_FCW_ID.AllowDBNull = false;
      this.columnQuote_FCW_ID.ReadOnly = true;
      this.columnQuote_FCW_ID.Unique = true;
      this.columnQuoteID.AllowDBNull = false;
      this.columnDeleted.AllowDBNull = false;
      this.columnDeleted.DefaultValue = (object) false;
      this.columnAllowDuplicates.AllowDBNull = false;
      this.columnAllowDuplicates.DefaultValue = (object) false;
      this.columnMandatory.AllowDBNull = false;
      this.columnMandatory.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow NewtblQuoteFormsConditionsWarrantiesRow()
    {
      return (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteFormsConditionsWarrantiesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRowChangeEventHandler warrantiesRowChangedEvent = this.tblQuoteFormsConditionsWarrantiesRowChangedEvent;
      if (warrantiesRowChangedEvent == null)
        return;
      warrantiesRowChangedEvent((object) this, new dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRowChangeEvent((dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteFormsConditionsWarrantiesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRowChangeEventHandler rowChangingEvent = this.tblQuoteFormsConditionsWarrantiesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRowChangeEvent((dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteFormsConditionsWarrantiesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRowChangeEventHandler warrantiesRowDeletedEvent = this.tblQuoteFormsConditionsWarrantiesRowDeletedEvent;
      if (warrantiesRowDeletedEvent == null)
        return;
      warrantiesRowDeletedEvent((object) this, new dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRowChangeEvent((dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteFormsConditionsWarrantiesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRowChangeEventHandler rowDeletingEvent = this.tblQuoteFormsConditionsWarrantiesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRowChangeEvent((dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblQuoteFormsConditionsWarrantiesRow(
      dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyFCW dsPolicyFcw = new dsPolicyFCW();
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
        FixedValue = dsPolicyFcw.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteFormsConditionsWarrantiesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyFcw.GetSchemaSerializable();
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
  public class tblConditionsDataTable : TypedTableBase<dsPolicyFCW.tblConditionsRow>
  {
    private DataColumn columnConditionID;
    private DataColumn columnCondition;
    private DataColumn columnApplied;
    private DataColumn columnMandatory;
    private DataColumn columnCompany_FCW_ID;
    private DataColumn columnWaivedByUserGuid;
    private DataColumn columnAddedByUserGuid;
    private DataColumn columnPlacedByCompanyLineID;
    private DataColumn columnRaterID;
    private DataColumn columnHidden;
    private DataColumn columnRaterConditionalID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblConditionsDataTable()
    {
      this.TableName = "tblConditions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblConditionsDataTable(DataTable table)
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
    protected tblConditionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ConditionIDColumn => this.columnConditionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ConditionColumn => this.columnCondition;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AppliedColumn => this.columnApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MandatoryColumn => this.columnMandatory;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Company_FCW_IDColumn => this.columnCompany_FCW_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WaivedByUserGuidColumn => this.columnWaivedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AddedByUserGuidColumn => this.columnAddedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PlacedByCompanyLineIDColumn => this.columnPlacedByCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RaterIDColumn => this.columnRaterID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RaterConditionalIDColumn => this.columnRaterConditionalID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblConditionsRow this[int index]
    {
      get => (dsPolicyFCW.tblConditionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblConditionsRowChangeEventHandler tblConditionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblConditionsRowChangeEventHandler tblConditionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblConditionsRowChangeEventHandler tblConditionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblConditionsRowChangeEventHandler tblConditionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblConditionsRow(dsPolicyFCW.tblConditionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblConditionsRow AddtblConditionsRow(
      string Condition,
      bool Applied,
      bool Mandatory,
      int Company_FCW_ID,
      Guid WaivedByUserGuid,
      Guid AddedByUserGuid,
      int PlacedByCompanyLineID,
      int RaterID,
      bool Hidden,
      int RaterConditionalID)
    {
      dsPolicyFCW.tblConditionsRow row = (dsPolicyFCW.tblConditionsRow) this.NewRow();
      object[] objArray = new object[11]
      {
        null,
        (object) Condition,
        (object) Applied,
        (object) Mandatory,
        (object) Company_FCW_ID,
        (object) WaivedByUserGuid,
        (object) AddedByUserGuid,
        (object) PlacedByCompanyLineID,
        (object) RaterID,
        (object) Hidden,
        (object) RaterConditionalID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblConditionsRow FindByConditionID(int ConditionID)
    {
      return (dsPolicyFCW.tblConditionsRow) this.Rows.Find(new object[1]
      {
        (object) ConditionID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyFCW.tblConditionsDataTable conditionsDataTable = (dsPolicyFCW.tblConditionsDataTable) base.Clone();
      conditionsDataTable.InitVars();
      return (DataTable) conditionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyFCW.tblConditionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnConditionID = this.Columns["ConditionID"];
      this.columnCondition = this.Columns["Condition"];
      this.columnApplied = this.Columns["Applied"];
      this.columnMandatory = this.Columns["Mandatory"];
      this.columnCompany_FCW_ID = this.Columns["Company_FCW_ID"];
      this.columnWaivedByUserGuid = this.Columns["WaivedByUserGuid"];
      this.columnAddedByUserGuid = this.Columns["AddedByUserGuid"];
      this.columnPlacedByCompanyLineID = this.Columns["PlacedByCompanyLineID"];
      this.columnRaterID = this.Columns["RaterID"];
      this.columnHidden = this.Columns["Hidden"];
      this.columnRaterConditionalID = this.Columns["RaterConditionalID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnConditionID = new DataColumn("ConditionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConditionID);
      this.columnCondition = new DataColumn("Condition", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCondition);
      this.columnApplied = new DataColumn("Applied", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnApplied);
      this.columnMandatory = new DataColumn("Mandatory", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMandatory);
      this.columnCompany_FCW_ID = new DataColumn("Company_FCW_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany_FCW_ID);
      this.columnWaivedByUserGuid = new DataColumn("WaivedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWaivedByUserGuid);
      this.columnAddedByUserGuid = new DataColumn("AddedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddedByUserGuid);
      this.columnPlacedByCompanyLineID = new DataColumn("PlacedByCompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPlacedByCompanyLineID);
      this.columnRaterID = new DataColumn("RaterID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRaterID);
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.columnRaterConditionalID = new DataColumn("RaterConditionalID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRaterConditionalID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyFCWKey1", new DataColumn[1]
      {
        this.columnConditionID
      }, true));
      this.columnConditionID.AutoIncrement = true;
      this.columnConditionID.AllowDBNull = false;
      this.columnConditionID.ReadOnly = true;
      this.columnConditionID.Unique = true;
      this.columnCondition.AllowDBNull = false;
      this.columnApplied.AllowDBNull = false;
      this.columnApplied.DefaultValue = (object) false;
      this.columnMandatory.AllowDBNull = false;
      this.columnMandatory.DefaultValue = (object) false;
      this.columnHidden.AllowDBNull = false;
      this.columnHidden.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblConditionsRow NewtblConditionsRow()
    {
      return (dsPolicyFCW.tblConditionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyFCW.tblConditionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyFCW.tblConditionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblConditionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblConditionsRowChangeEventHandler conditionsRowChangedEvent = this.tblConditionsRowChangedEvent;
      if (conditionsRowChangedEvent == null)
        return;
      conditionsRowChangedEvent((object) this, new dsPolicyFCW.tblConditionsRowChangeEvent((dsPolicyFCW.tblConditionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblConditionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblConditionsRowChangeEventHandler rowChangingEvent = this.tblConditionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyFCW.tblConditionsRowChangeEvent((dsPolicyFCW.tblConditionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblConditionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblConditionsRowChangeEventHandler conditionsRowDeletedEvent = this.tblConditionsRowDeletedEvent;
      if (conditionsRowDeletedEvent == null)
        return;
      conditionsRowDeletedEvent((object) this, new dsPolicyFCW.tblConditionsRowChangeEvent((dsPolicyFCW.tblConditionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblConditionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblConditionsRowChangeEventHandler rowDeletingEvent = this.tblConditionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyFCW.tblConditionsRowChangeEvent((dsPolicyFCW.tblConditionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblConditionsRow(dsPolicyFCW.tblConditionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyFCW dsPolicyFcw = new dsPolicyFCW();
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
        FixedValue = dsPolicyFcw.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblConditionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyFcw.GetSchemaSerializable();
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
  public class tblPolicyFormsDataTable : TypedTableBase<dsPolicyFCW.tblPolicyFormsRow>
  {
    private DataColumn columnFormID;
    private DataColumn columnFormName;
    private DataColumn columnDescription;
    private DataColumn columnEndorsementNum;
    private DataColumn columnApplied;
    private DataColumn columnRequiresEndorsementNumber;
    private DataColumn columnFormNumber;
    private DataColumn columnParentFormID;
    private DataColumn columnWaivedByUserGuid;
    private DataColumn columnAllowDuplicates;
    private DataColumn columnPlacedByCompanyLineID;
    private DataColumn columnLineName;
    private DataColumn columnAddedByUserGuid;
    private DataColumn columnFormCompanyLineGuid;
    private DataColumn columnMandatory;
    private DataColumn columnCompany_FCW_ID;
    private DataColumn columnAssociatedWarrantyID;
    private DataColumn columnAssociatedFormID;
    private DataColumn columnFormType;
    private DataColumn columnEditionDate;
    private DataColumn columnComments;
    private DataColumn columnPolicyFormComments;
    private DataColumn columnRaterID;
    private DataColumn columnHidden;
    private DataColumn columnRaterConditionalID;
    private DataColumn columnOncePer;
    private DataColumn columnRequiresEdit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblPolicyFormsDataTable()
    {
      this.TableName = "tblPolicyForms";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblPolicyFormsDataTable(DataTable table)
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
    protected tblPolicyFormsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormIDColumn => this.columnFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormNameColumn => this.columnFormName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EndorsementNumColumn => this.columnEndorsementNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AppliedColumn => this.columnApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RequiresEndorsementNumberColumn => this.columnRequiresEndorsementNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormNumberColumn => this.columnFormNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ParentFormIDColumn => this.columnParentFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WaivedByUserGuidColumn => this.columnWaivedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AllowDuplicatesColumn => this.columnAllowDuplicates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PlacedByCompanyLineIDColumn => this.columnPlacedByCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AddedByUserGuidColumn => this.columnAddedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormCompanyLineGuidColumn => this.columnFormCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MandatoryColumn => this.columnMandatory;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Company_FCW_IDColumn => this.columnCompany_FCW_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AssociatedWarrantyIDColumn => this.columnAssociatedWarrantyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AssociatedFormIDColumn => this.columnAssociatedFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormTypeColumn => this.columnFormType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EditionDateColumn => this.columnEditionDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CommentsColumn => this.columnComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyFormCommentsColumn => this.columnPolicyFormComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RaterIDColumn => this.columnRaterID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RaterConditionalIDColumn => this.columnRaterConditionalID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OncePerColumn => this.columnOncePer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RequiresEditColumn => this.columnRequiresEdit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblPolicyFormsRow this[int index]
    {
      get => (dsPolicyFCW.tblPolicyFormsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblPolicyFormsRow(dsPolicyFCW.tblPolicyFormsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblPolicyFormsRow AddtblPolicyFormsRow(
      string FormName,
      string Description,
      string EndorsementNum,
      bool Applied,
      bool RequiresEndorsementNumber,
      string FormNumber,
      int ParentFormID,
      Guid WaivedByUserGuid,
      bool AllowDuplicates,
      int PlacedByCompanyLineID,
      string LineName,
      Guid AddedByUserGuid,
      Guid FormCompanyLineGuid,
      bool Mandatory,
      int Company_FCW_ID,
      int AssociatedWarrantyID,
      int AssociatedFormID,
      string FormType,
      string EditionDate,
      string Comments,
      string PolicyFormComments,
      int RaterID,
      bool Hidden,
      int RaterConditionalID,
      string OncePer,
      bool RequiresEdit)
    {
      dsPolicyFCW.tblPolicyFormsRow row = (dsPolicyFCW.tblPolicyFormsRow) this.NewRow();
      object[] objArray = new object[27]
      {
        null,
        (object) FormName,
        (object) Description,
        (object) EndorsementNum,
        (object) Applied,
        (object) RequiresEndorsementNumber,
        (object) FormNumber,
        (object) ParentFormID,
        (object) WaivedByUserGuid,
        (object) AllowDuplicates,
        (object) PlacedByCompanyLineID,
        (object) LineName,
        (object) AddedByUserGuid,
        (object) FormCompanyLineGuid,
        (object) Mandatory,
        (object) Company_FCW_ID,
        (object) AssociatedWarrantyID,
        (object) AssociatedFormID,
        (object) FormType,
        (object) EditionDate,
        (object) Comments,
        (object) PolicyFormComments,
        (object) RaterID,
        (object) Hidden,
        (object) RaterConditionalID,
        (object) OncePer,
        (object) RequiresEdit
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblPolicyFormsRow FindByFormID(int FormID)
    {
      return (dsPolicyFCW.tblPolicyFormsRow) this.Rows.Find(new object[1]
      {
        (object) FormID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyFCW.tblPolicyFormsDataTable policyFormsDataTable = (dsPolicyFCW.tblPolicyFormsDataTable) base.Clone();
      policyFormsDataTable.InitVars();
      return (DataTable) policyFormsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyFCW.tblPolicyFormsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnFormID = this.Columns["FormID"];
      this.columnFormName = this.Columns["FormName"];
      this.columnDescription = this.Columns["Description"];
      this.columnEndorsementNum = this.Columns["EndorsementNum"];
      this.columnApplied = this.Columns["Applied"];
      this.columnRequiresEndorsementNumber = this.Columns["RequiresEndorsementNumber"];
      this.columnFormNumber = this.Columns["FormNumber"];
      this.columnParentFormID = this.Columns["ParentFormID"];
      this.columnWaivedByUserGuid = this.Columns["WaivedByUserGuid"];
      this.columnAllowDuplicates = this.Columns["AllowDuplicates"];
      this.columnPlacedByCompanyLineID = this.Columns["PlacedByCompanyLineID"];
      this.columnLineName = this.Columns["LineName"];
      this.columnAddedByUserGuid = this.Columns["AddedByUserGuid"];
      this.columnFormCompanyLineGuid = this.Columns["FormCompanyLineGuid"];
      this.columnMandatory = this.Columns["Mandatory"];
      this.columnCompany_FCW_ID = this.Columns["Company_FCW_ID"];
      this.columnAssociatedWarrantyID = this.Columns["AssociatedWarrantyID"];
      this.columnAssociatedFormID = this.Columns["AssociatedFormID"];
      this.columnFormType = this.Columns["FormType"];
      this.columnEditionDate = this.Columns["EditionDate"];
      this.columnComments = this.Columns["Comments"];
      this.columnPolicyFormComments = this.Columns["PolicyFormComments"];
      this.columnRaterID = this.Columns["RaterID"];
      this.columnHidden = this.Columns["Hidden"];
      this.columnRaterConditionalID = this.Columns["RaterConditionalID"];
      this.columnOncePer = this.Columns["OncePer"];
      this.columnRequiresEdit = this.Columns["RequiresEdit"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnFormID = new DataColumn("FormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormID);
      this.columnFormName = new DataColumn("FormName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormName);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnEndorsementNum = new DataColumn("EndorsementNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementNum);
      this.columnApplied = new DataColumn("Applied", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnApplied);
      this.columnRequiresEndorsementNumber = new DataColumn("RequiresEndorsementNumber", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiresEndorsementNumber);
      this.columnFormNumber = new DataColumn("FormNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormNumber);
      this.columnParentFormID = new DataColumn("ParentFormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParentFormID);
      this.columnWaivedByUserGuid = new DataColumn("WaivedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWaivedByUserGuid);
      this.columnAllowDuplicates = new DataColumn("AllowDuplicates", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAllowDuplicates);
      this.columnPlacedByCompanyLineID = new DataColumn("PlacedByCompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPlacedByCompanyLineID);
      this.columnLineName = new DataColumn("LineName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineName);
      this.columnAddedByUserGuid = new DataColumn("AddedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddedByUserGuid);
      this.columnFormCompanyLineGuid = new DataColumn("FormCompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormCompanyLineGuid);
      this.columnMandatory = new DataColumn("Mandatory", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMandatory);
      this.columnCompany_FCW_ID = new DataColumn("Company_FCW_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany_FCW_ID);
      this.columnAssociatedWarrantyID = new DataColumn("AssociatedWarrantyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAssociatedWarrantyID);
      this.columnAssociatedFormID = new DataColumn("AssociatedFormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAssociatedFormID);
      this.columnFormType = new DataColumn("FormType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormType);
      this.columnEditionDate = new DataColumn("EditionDate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEditionDate);
      this.columnComments = new DataColumn("Comments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComments);
      this.columnPolicyFormComments = new DataColumn("PolicyFormComments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyFormComments);
      this.columnRaterID = new DataColumn("RaterID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRaterID);
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.columnRaterConditionalID = new DataColumn("RaterConditionalID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRaterConditionalID);
      this.columnOncePer = new DataColumn("OncePer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOncePer);
      this.columnRequiresEdit = new DataColumn("RequiresEdit", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiresEdit);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyFCWKey2", new DataColumn[1]
      {
        this.columnFormID
      }, true));
      this.columnFormID.AutoIncrement = true;
      this.columnFormID.AllowDBNull = false;
      this.columnFormID.ReadOnly = true;
      this.columnFormID.Unique = true;
      this.columnFormName.AllowDBNull = false;
      this.columnApplied.AllowDBNull = false;
      this.columnApplied.DefaultValue = (object) false;
      this.columnRequiresEndorsementNumber.AllowDBNull = false;
      this.columnRequiresEndorsementNumber.DefaultValue = (object) false;
      this.columnMandatory.AllowDBNull = false;
      this.columnMandatory.DefaultValue = (object) false;
      this.columnHidden.AllowDBNull = false;
      this.columnHidden.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblPolicyFormsRow NewtblPolicyFormsRow()
    {
      return (dsPolicyFCW.tblPolicyFormsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyFCW.tblPolicyFormsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyFCW.tblPolicyFormsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFormsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblPolicyFormsRowChangeEventHandler formsRowChangedEvent = this.tblPolicyFormsRowChangedEvent;
      if (formsRowChangedEvent == null)
        return;
      formsRowChangedEvent((object) this, new dsPolicyFCW.tblPolicyFormsRowChangeEvent((dsPolicyFCW.tblPolicyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFormsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblPolicyFormsRowChangeEventHandler rowChangingEvent = this.tblPolicyFormsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyFCW.tblPolicyFormsRowChangeEvent((dsPolicyFCW.tblPolicyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFormsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblPolicyFormsRowChangeEventHandler formsRowDeletedEvent = this.tblPolicyFormsRowDeletedEvent;
      if (formsRowDeletedEvent == null)
        return;
      formsRowDeletedEvent((object) this, new dsPolicyFCW.tblPolicyFormsRowChangeEvent((dsPolicyFCW.tblPolicyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFormsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblPolicyFormsRowChangeEventHandler rowDeletingEvent = this.tblPolicyFormsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyFCW.tblPolicyFormsRowChangeEvent((dsPolicyFCW.tblPolicyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblPolicyFormsRow(dsPolicyFCW.tblPolicyFormsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyFCW dsPolicyFcw = new dsPolicyFCW();
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
        FixedValue = dsPolicyFcw.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblPolicyFormsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyFcw.GetSchemaSerializable();
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
  public class tblWarrantiesDataTable : TypedTableBase<dsPolicyFCW.tblWarrantiesRow>
  {
    private DataColumn columnWarrantyID;
    private DataColumn columnWarrantyName;
    private DataColumn columnApplied;
    private DataColumn columnMandatory;
    private DataColumn columnCompany_FCW_ID;
    private DataColumn columnWaivedByUserGuid;
    private DataColumn columnAddedByUserGuid;
    private DataColumn columnPlacedByCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblWarrantiesDataTable()
    {
      this.TableName = "tblWarranties";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblWarrantiesDataTable(DataTable table)
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
    protected tblWarrantiesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WarrantyIDColumn => this.columnWarrantyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WarrantyNameColumn => this.columnWarrantyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AppliedColumn => this.columnApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MandatoryColumn => this.columnMandatory;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Company_FCW_IDColumn => this.columnCompany_FCW_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WaivedByUserGuidColumn => this.columnWaivedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AddedByUserGuidColumn => this.columnAddedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PlacedByCompanyLineIDColumn => this.columnPlacedByCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantiesRow this[int index]
    {
      get => (dsPolicyFCW.tblWarrantiesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblWarrantiesRowChangeEventHandler tblWarrantiesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblWarrantiesRowChangeEventHandler tblWarrantiesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblWarrantiesRowChangeEventHandler tblWarrantiesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblWarrantiesRowChangeEventHandler tblWarrantiesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblWarrantiesRow(dsPolicyFCW.tblWarrantiesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantiesRow AddtblWarrantiesRow(
      string WarrantyName,
      bool Applied,
      bool Mandatory,
      int Company_FCW_ID,
      Guid WaivedByUserGuid,
      Guid AddedByUserGuid,
      int PlacedByCompanyLineID)
    {
      dsPolicyFCW.tblWarrantiesRow row = (dsPolicyFCW.tblWarrantiesRow) this.NewRow();
      object[] objArray = new object[8]
      {
        null,
        (object) WarrantyName,
        (object) Applied,
        (object) Mandatory,
        (object) Company_FCW_ID,
        (object) WaivedByUserGuid,
        (object) AddedByUserGuid,
        (object) PlacedByCompanyLineID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantiesRow FindByWarrantyID(int WarrantyID)
    {
      return (dsPolicyFCW.tblWarrantiesRow) this.Rows.Find(new object[1]
      {
        (object) WarrantyID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyFCW.tblWarrantiesDataTable warrantiesDataTable = (dsPolicyFCW.tblWarrantiesDataTable) base.Clone();
      warrantiesDataTable.InitVars();
      return (DataTable) warrantiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyFCW.tblWarrantiesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnWarrantyID = this.Columns["WarrantyID"];
      this.columnWarrantyName = this.Columns["WarrantyName"];
      this.columnApplied = this.Columns["Applied"];
      this.columnMandatory = this.Columns["Mandatory"];
      this.columnCompany_FCW_ID = this.Columns["Company_FCW_ID"];
      this.columnWaivedByUserGuid = this.Columns["WaivedByUserGuid"];
      this.columnAddedByUserGuid = this.Columns["AddedByUserGuid"];
      this.columnPlacedByCompanyLineID = this.Columns["PlacedByCompanyLineID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnWarrantyID = new DataColumn("WarrantyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWarrantyID);
      this.columnWarrantyName = new DataColumn("WarrantyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWarrantyName);
      this.columnApplied = new DataColumn("Applied", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnApplied);
      this.columnMandatory = new DataColumn("Mandatory", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMandatory);
      this.columnCompany_FCW_ID = new DataColumn("Company_FCW_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany_FCW_ID);
      this.columnWaivedByUserGuid = new DataColumn("WaivedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWaivedByUserGuid);
      this.columnAddedByUserGuid = new DataColumn("AddedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddedByUserGuid);
      this.columnPlacedByCompanyLineID = new DataColumn("PlacedByCompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPlacedByCompanyLineID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyFCWKey3", new DataColumn[1]
      {
        this.columnWarrantyID
      }, true));
      this.columnWarrantyID.AutoIncrement = true;
      this.columnWarrantyID.AllowDBNull = false;
      this.columnWarrantyID.ReadOnly = true;
      this.columnWarrantyID.Unique = true;
      this.columnWarrantyName.AllowDBNull = false;
      this.columnApplied.AllowDBNull = false;
      this.columnApplied.DefaultValue = (object) false;
      this.columnMandatory.AllowDBNull = false;
      this.columnMandatory.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantiesRow NewtblWarrantiesRow()
    {
      return (dsPolicyFCW.tblWarrantiesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyFCW.tblWarrantiesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyFCW.tblWarrantiesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWarrantiesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblWarrantiesRowChangeEventHandler warrantiesRowChangedEvent = this.tblWarrantiesRowChangedEvent;
      if (warrantiesRowChangedEvent == null)
        return;
      warrantiesRowChangedEvent((object) this, new dsPolicyFCW.tblWarrantiesRowChangeEvent((dsPolicyFCW.tblWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWarrantiesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblWarrantiesRowChangeEventHandler rowChangingEvent = this.tblWarrantiesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyFCW.tblWarrantiesRowChangeEvent((dsPolicyFCW.tblWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWarrantiesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblWarrantiesRowChangeEventHandler warrantiesRowDeletedEvent = this.tblWarrantiesRowDeletedEvent;
      if (warrantiesRowDeletedEvent == null)
        return;
      warrantiesRowDeletedEvent((object) this, new dsPolicyFCW.tblWarrantiesRowChangeEvent((dsPolicyFCW.tblWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWarrantiesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblWarrantiesRowChangeEventHandler rowDeletingEvent = this.tblWarrantiesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyFCW.tblWarrantiesRowChangeEvent((dsPolicyFCW.tblWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblWarrantiesRow(dsPolicyFCW.tblWarrantiesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyFCW dsPolicyFcw = new dsPolicyFCW();
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
        FixedValue = dsPolicyFcw.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblWarrantiesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyFcw.GetSchemaSerializable();
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
  public class tblWarrantyFormsDataTable : TypedTableBase<dsPolicyFCW.tblWarrantyFormsRow>
  {
    private DataColumn columnWarrantyID;
    private DataColumn columnPolicyFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblWarrantyFormsDataTable()
    {
      this.TableName = "tblWarrantyForms";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblWarrantyFormsDataTable(DataTable table)
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
    protected tblWarrantyFormsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WarrantyIDColumn => this.columnWarrantyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyFormIDColumn => this.columnPolicyFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantyFormsRow this[int index]
    {
      get => (dsPolicyFCW.tblWarrantyFormsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblWarrantyFormsRowChangeEventHandler tblWarrantyFormsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblWarrantyFormsRowChangeEventHandler tblWarrantyFormsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblWarrantyFormsRowChangeEventHandler tblWarrantyFormsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblWarrantyFormsRowChangeEventHandler tblWarrantyFormsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblWarrantyFormsRow(dsPolicyFCW.tblWarrantyFormsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantyFormsRow AddtblWarrantyFormsRow(
      dsPolicyFCW.tblWarrantiesRow parenttblWarrantiesRowBytblWarrantiestblWarrantyForms,
      dsPolicyFCW.tblPolicyFormsRow parenttblPolicyFormsRowBytblPolicyFormstblWarrantyForms)
    {
      dsPolicyFCW.tblWarrantyFormsRow row = (dsPolicyFCW.tblWarrantyFormsRow) this.NewRow();
      object[] objArray = new object[2];
      if (parenttblWarrantiesRowBytblWarrantiestblWarrantyForms != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblWarrantiesRowBytblWarrantiestblWarrantyForms[0]);
      if (parenttblPolicyFormsRowBytblPolicyFormstblWarrantyForms != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblPolicyFormsRowBytblPolicyFormstblWarrantyForms[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantyFormsRow FindByWarrantyIDPolicyFormID(
      int WarrantyID,
      int PolicyFormID)
    {
      return (dsPolicyFCW.tblWarrantyFormsRow) this.Rows.Find(new object[2]
      {
        (object) WarrantyID,
        (object) PolicyFormID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyFCW.tblWarrantyFormsDataTable warrantyFormsDataTable = (dsPolicyFCW.tblWarrantyFormsDataTable) base.Clone();
      warrantyFormsDataTable.InitVars();
      return (DataTable) warrantyFormsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyFCW.tblWarrantyFormsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnWarrantyID = this.Columns["WarrantyID"];
      this.columnPolicyFormID = this.Columns["PolicyFormID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnWarrantyID = new DataColumn("WarrantyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWarrantyID);
      this.columnPolicyFormID = new DataColumn("PolicyFormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyFormID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyFCWKey4", new DataColumn[2]
      {
        this.columnWarrantyID,
        this.columnPolicyFormID
      }, true));
      this.columnWarrantyID.AllowDBNull = false;
      this.columnPolicyFormID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantyFormsRow NewtblWarrantyFormsRow()
    {
      return (dsPolicyFCW.tblWarrantyFormsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyFCW.tblWarrantyFormsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyFCW.tblWarrantyFormsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWarrantyFormsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblWarrantyFormsRowChangeEventHandler formsRowChangedEvent = this.tblWarrantyFormsRowChangedEvent;
      if (formsRowChangedEvent == null)
        return;
      formsRowChangedEvent((object) this, new dsPolicyFCW.tblWarrantyFormsRowChangeEvent((dsPolicyFCW.tblWarrantyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWarrantyFormsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblWarrantyFormsRowChangeEventHandler rowChangingEvent = this.tblWarrantyFormsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyFCW.tblWarrantyFormsRowChangeEvent((dsPolicyFCW.tblWarrantyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWarrantyFormsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblWarrantyFormsRowChangeEventHandler formsRowDeletedEvent = this.tblWarrantyFormsRowDeletedEvent;
      if (formsRowDeletedEvent == null)
        return;
      formsRowDeletedEvent((object) this, new dsPolicyFCW.tblWarrantyFormsRowChangeEvent((dsPolicyFCW.tblWarrantyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWarrantyFormsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblWarrantyFormsRowChangeEventHandler rowDeletingEvent = this.tblWarrantyFormsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyFCW.tblWarrantyFormsRowChangeEvent((dsPolicyFCW.tblWarrantyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblWarrantyFormsRow(dsPolicyFCW.tblWarrantyFormsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyFCW dsPolicyFcw = new dsPolicyFCW();
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
        FixedValue = dsPolicyFcw.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblWarrantyFormsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyFcw.GetSchemaSerializable();
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
  public class tblNetRateAdditionalDataDataTable : 
    TypedTableBase<dsPolicyFCW.tblNetRateAdditionalDataRow>
  {
    private DataColumn columnID;
    private DataColumn columnQuoteGuid;
    private DataColumn columnAdditionalComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblNetRateAdditionalDataDataTable()
    {
      this.TableName = "tblNetRateAdditionalData";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblNetRateAdditionalDataDataTable(DataTable table)
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
    protected tblNetRateAdditionalDataDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AdditionalCommentsColumn => this.columnAdditionalComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblNetRateAdditionalDataRow this[int index]
    {
      get => (dsPolicyFCW.tblNetRateAdditionalDataRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblNetRateAdditionalDataRowChangeEventHandler tblNetRateAdditionalDataRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblNetRateAdditionalDataRowChangeEventHandler tblNetRateAdditionalDataRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblNetRateAdditionalDataRowChangeEventHandler tblNetRateAdditionalDataRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblNetRateAdditionalDataRowChangeEventHandler tblNetRateAdditionalDataRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblNetRateAdditionalDataRow(dsPolicyFCW.tblNetRateAdditionalDataRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblNetRateAdditionalDataRow AddtblNetRateAdditionalDataRow(
      Guid QuoteGuid,
      string AdditionalComments)
    {
      dsPolicyFCW.tblNetRateAdditionalDataRow row = (dsPolicyFCW.tblNetRateAdditionalDataRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) QuoteGuid,
        (object) AdditionalComments
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblNetRateAdditionalDataRow FindByID(int ID)
    {
      return (dsPolicyFCW.tblNetRateAdditionalDataRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyFCW.tblNetRateAdditionalDataDataTable additionalDataDataTable = (dsPolicyFCW.tblNetRateAdditionalDataDataTable) base.Clone();
      additionalDataDataTable.InitVars();
      return (DataTable) additionalDataDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyFCW.tblNetRateAdditionalDataDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnAdditionalComments = this.Columns["AdditionalComments"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnAdditionalComments = new DataColumn("AdditionalComments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalComments);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnQuoteGuid.AllowDBNull = false;
      this.columnAdditionalComments.MaxLength = 8000;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblNetRateAdditionalDataRow NewtblNetRateAdditionalDataRow()
    {
      return (dsPolicyFCW.tblNetRateAdditionalDataRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyFCW.tblNetRateAdditionalDataRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyFCW.tblNetRateAdditionalDataRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateAdditionalDataRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblNetRateAdditionalDataRowChangeEventHandler dataRowChangedEvent = this.tblNetRateAdditionalDataRowChangedEvent;
      if (dataRowChangedEvent == null)
        return;
      dataRowChangedEvent((object) this, new dsPolicyFCW.tblNetRateAdditionalDataRowChangeEvent((dsPolicyFCW.tblNetRateAdditionalDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateAdditionalDataRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblNetRateAdditionalDataRowChangeEventHandler rowChangingEvent = this.tblNetRateAdditionalDataRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyFCW.tblNetRateAdditionalDataRowChangeEvent((dsPolicyFCW.tblNetRateAdditionalDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateAdditionalDataRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblNetRateAdditionalDataRowChangeEventHandler dataRowDeletedEvent = this.tblNetRateAdditionalDataRowDeletedEvent;
      if (dataRowDeletedEvent == null)
        return;
      dataRowDeletedEvent((object) this, new dsPolicyFCW.tblNetRateAdditionalDataRowChangeEvent((dsPolicyFCW.tblNetRateAdditionalDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateAdditionalDataRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblNetRateAdditionalDataRowChangeEventHandler rowDeletingEvent = this.tblNetRateAdditionalDataRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyFCW.tblNetRateAdditionalDataRowChangeEvent((dsPolicyFCW.tblNetRateAdditionalDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblNetRateAdditionalDataRow(dsPolicyFCW.tblNetRateAdditionalDataRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyFCW dsPolicyFcw = new dsPolicyFCW();
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
        FixedValue = dsPolicyFcw.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblNetRateAdditionalDataDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyFcw.GetSchemaSerializable();
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
  public class tblUsersDataTable : TypedTableBase<dsPolicyFCW.tblUsersRow>
  {
    private DataColumn columnUserGUID;
    private DataColumn columnUser;

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
    public DataColumn UserColumn => this.columnUser;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblUsersRow this[int index] => (dsPolicyFCW.tblUsersRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblUsersRowChangeEventHandler tblUsersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblUsersRowChangeEventHandler tblUsersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblUsersRowChangeEventHandler tblUsersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblUsersRowChangeEventHandler tblUsersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblUsersRow(dsPolicyFCW.tblUsersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblUsersRow AddtblUsersRow(Guid UserGUID, string User)
    {
      dsPolicyFCW.tblUsersRow row = (dsPolicyFCW.tblUsersRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) UserGUID,
        (object) User
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblUsersRow FindByUserGUID(Guid UserGUID)
    {
      return (dsPolicyFCW.tblUsersRow) this.Rows.Find(new object[1]
      {
        (object) UserGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyFCW.tblUsersDataTable tblUsersDataTable = (dsPolicyFCW.tblUsersDataTable) base.Clone();
      tblUsersDataTable.InitVars();
      return (DataTable) tblUsersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyFCW.tblUsersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnUserGUID = this.Columns["UserGUID"];
      this.columnUser = this.Columns["User"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnUserGUID = new DataColumn("UserGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUID);
      this.columnUser = new DataColumn("User", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUser);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnUserGUID
      }, true));
      this.columnUserGUID.AllowDBNull = false;
      this.columnUserGUID.Unique = true;
      this.columnUser.ReadOnly = true;
      this.columnUser.Caption = "Name_FirstLast";
      this.columnUser.MaxLength = 101;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblUsersRow NewtblUsersRow() => (dsPolicyFCW.tblUsersRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyFCW.tblUsersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyFCW.tblUsersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblUsersRowChangeEventHandler usersRowChangedEvent = this.tblUsersRowChangedEvent;
      if (usersRowChangedEvent == null)
        return;
      usersRowChangedEvent((object) this, new dsPolicyFCW.tblUsersRowChangeEvent((dsPolicyFCW.tblUsersRow) e.Row, e.Action));
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
      dsPolicyFCW.tblUsersRowChangeEventHandler rowChangingEvent = this.tblUsersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyFCW.tblUsersRowChangeEvent((dsPolicyFCW.tblUsersRow) e.Row, e.Action));
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
      dsPolicyFCW.tblUsersRowChangeEventHandler usersRowDeletedEvent = this.tblUsersRowDeletedEvent;
      if (usersRowDeletedEvent == null)
        return;
      usersRowDeletedEvent((object) this, new dsPolicyFCW.tblUsersRowChangeEvent((dsPolicyFCW.tblUsersRow) e.Row, e.Action));
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
      dsPolicyFCW.tblUsersRowChangeEventHandler rowDeletingEvent = this.tblUsersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyFCW.tblUsersRowChangeEvent((dsPolicyFCW.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblUsersRow(dsPolicyFCW.tblUsersRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyFCW dsPolicyFcw = new dsPolicyFCW();
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
        FixedValue = dsPolicyFcw.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUsersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyFcw.GetSchemaSerializable();
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
  public class tblWarrantiesAssociatedFormsDataTable : 
    TypedTableBase<dsPolicyFCW.tblWarrantiesAssociatedFormsRow>
  {
    private DataColumn columnWarrantyID;
    private DataColumn columnPolicyFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblWarrantiesAssociatedFormsDataTable()
    {
      this.TableName = "tblWarrantiesAssociatedForms";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblWarrantiesAssociatedFormsDataTable(DataTable table)
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
    protected tblWarrantiesAssociatedFormsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WarrantyIDColumn => this.columnWarrantyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyFormIDColumn => this.columnPolicyFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantiesAssociatedFormsRow this[int index]
    {
      get => (dsPolicyFCW.tblWarrantiesAssociatedFormsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblWarrantiesAssociatedFormsRowChangeEventHandler tblWarrantiesAssociatedFormsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblWarrantiesAssociatedFormsRowChangeEventHandler tblWarrantiesAssociatedFormsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblWarrantiesAssociatedFormsRowChangeEventHandler tblWarrantiesAssociatedFormsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyFCW.tblWarrantiesAssociatedFormsRowChangeEventHandler tblWarrantiesAssociatedFormsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblWarrantiesAssociatedFormsRow(dsPolicyFCW.tblWarrantiesAssociatedFormsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantiesAssociatedFormsRow AddtblWarrantiesAssociatedFormsRow(
      int WarrantyID,
      int PolicyFormID)
    {
      dsPolicyFCW.tblWarrantiesAssociatedFormsRow row = (dsPolicyFCW.tblWarrantiesAssociatedFormsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) WarrantyID,
        (object) PolicyFormID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantiesAssociatedFormsRow FindByWarrantyIDPolicyFormID(
      int WarrantyID,
      int PolicyFormID)
    {
      return (dsPolicyFCW.tblWarrantiesAssociatedFormsRow) this.Rows.Find(new object[2]
      {
        (object) WarrantyID,
        (object) PolicyFormID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyFCW.tblWarrantiesAssociatedFormsDataTable associatedFormsDataTable = (dsPolicyFCW.tblWarrantiesAssociatedFormsDataTable) base.Clone();
      associatedFormsDataTable.InitVars();
      return (DataTable) associatedFormsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyFCW.tblWarrantiesAssociatedFormsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnWarrantyID = this.Columns["WarrantyID"];
      this.columnPolicyFormID = this.Columns["PolicyFormID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnWarrantyID = new DataColumn("WarrantyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWarrantyID);
      this.columnPolicyFormID = new DataColumn("PolicyFormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyFormID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnWarrantyID,
        this.columnPolicyFormID
      }, true));
      this.columnWarrantyID.AllowDBNull = false;
      this.columnPolicyFormID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantiesAssociatedFormsRow NewtblWarrantiesAssociatedFormsRow()
    {
      return (dsPolicyFCW.tblWarrantiesAssociatedFormsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyFCW.tblWarrantiesAssociatedFormsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyFCW.tblWarrantiesAssociatedFormsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWarrantiesAssociatedFormsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblWarrantiesAssociatedFormsRowChangeEventHandler formsRowChangedEvent = this.tblWarrantiesAssociatedFormsRowChangedEvent;
      if (formsRowChangedEvent == null)
        return;
      formsRowChangedEvent((object) this, new dsPolicyFCW.tblWarrantiesAssociatedFormsRowChangeEvent((dsPolicyFCW.tblWarrantiesAssociatedFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWarrantiesAssociatedFormsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblWarrantiesAssociatedFormsRowChangeEventHandler rowChangingEvent = this.tblWarrantiesAssociatedFormsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyFCW.tblWarrantiesAssociatedFormsRowChangeEvent((dsPolicyFCW.tblWarrantiesAssociatedFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWarrantiesAssociatedFormsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblWarrantiesAssociatedFormsRowChangeEventHandler formsRowDeletedEvent = this.tblWarrantiesAssociatedFormsRowDeletedEvent;
      if (formsRowDeletedEvent == null)
        return;
      formsRowDeletedEvent((object) this, new dsPolicyFCW.tblWarrantiesAssociatedFormsRowChangeEvent((dsPolicyFCW.tblWarrantiesAssociatedFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWarrantiesAssociatedFormsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyFCW.tblWarrantiesAssociatedFormsRowChangeEventHandler rowDeletingEvent = this.tblWarrantiesAssociatedFormsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyFCW.tblWarrantiesAssociatedFormsRowChangeEvent((dsPolicyFCW.tblWarrantiesAssociatedFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblWarrantiesAssociatedFormsRow(
      dsPolicyFCW.tblWarrantiesAssociatedFormsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyFCW dsPolicyFcw = new dsPolicyFCW();
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
        FixedValue = dsPolicyFcw.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblWarrantiesAssociatedFormsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyFcw.GetSchemaSerializable();
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

  public class tblQuoteFormsConditionsWarrantiesRow : DataRow
  {
    private dsPolicyFCW.tblQuoteFormsConditionsWarrantiesDataTable tabletblQuoteFormsConditionsWarranties;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuoteFormsConditionsWarrantiesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteFormsConditionsWarranties = (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Quote_FCW_ID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteFormsConditionsWarranties.Quote_FCW_IDColumn]);
      }
      set => this[this.tabletblQuoteFormsConditionsWarranties.Quote_FCW_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteFormsConditionsWarranties.QuoteIDColumn]);
      set => this[this.tabletblQuoteFormsConditionsWarranties.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyFormID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteFormsConditionsWarranties.PolicyFormIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyFormID' in table 'tblQuoteFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteFormsConditionsWarranties.PolicyFormIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ConditionID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteFormsConditionsWarranties.ConditionIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConditionID' in table 'tblQuoteFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteFormsConditionsWarranties.ConditionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int WarrantyID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteFormsConditionsWarranties.WarrantyIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WarrantyID' in table 'tblQuoteFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteFormsConditionsWarranties.WarrantyIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EndorsementNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteFormsConditionsWarranties.EndorsementNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementNum' in table 'tblQuoteFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblQuoteFormsConditionsWarranties.EndorsementNumColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Deleted
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteFormsConditionsWarranties.DeletedColumn]);
      set => this[this.tabletblQuoteFormsConditionsWarranties.DeletedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int OriginalID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteFormsConditionsWarranties.OriginalIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OriginalID' in table 'tblQuoteFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteFormsConditionsWarranties.OriginalIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid WaivedByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuoteFormsConditionsWarranties.WaivedByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WaivedByUserGuid' in table 'tblQuoteFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblQuoteFormsConditionsWarranties.WaivedByUserGuidColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool AllowDuplicates
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblQuoteFormsConditionsWarranties.AllowDuplicatesColumn]);
      }
      set
      {
        this[this.tabletblQuoteFormsConditionsWarranties.AllowDuplicatesColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid AddedByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuoteFormsConditionsWarranties.AddedByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddedByUserGuid' in table 'tblQuoteFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblQuoteFormsConditionsWarranties.AddedByUserGuidColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Mandatory
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblQuoteFormsConditionsWarranties.MandatoryColumn]);
      }
      set => this[this.tabletblQuoteFormsConditionsWarranties.MandatoryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Company_FCW_ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteFormsConditionsWarranties.Company_FCW_IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Company_FCW_ID' in table 'tblQuoteFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblQuoteFormsConditionsWarranties.Company_FCW_IDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime Added
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblQuoteFormsConditionsWarranties.AddedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Added' in table 'tblQuoteFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteFormsConditionsWarranties.AddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyFormComments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteFormsConditionsWarranties.PolicyFormCommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyFormComments' in table 'tblQuoteFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblQuoteFormsConditionsWarranties.PolicyFormCommentsColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CompanyLineID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteFormsConditionsWarranties.CompanyLineIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLineID' in table 'tblQuoteFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteFormsConditionsWarranties.CompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RaterID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteFormsConditionsWarranties.RaterIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RaterID' in table 'tblQuoteFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteFormsConditionsWarranties.RaterIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RaterConditionalID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteFormsConditionsWarranties.RaterConditionalIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RaterConditionalID' in table 'tblQuoteFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblQuoteFormsConditionsWarranties.RaterConditionalIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantiesRow tblWarrantiesRow
    {
      get
      {
        return (dsPolicyFCW.tblWarrantiesRow) this.GetParentRow(this.Table.ParentRelations["tblWarrantiestblQuoteFormsConditionsWarranties"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblWarrantiestblQuoteFormsConditionsWarranties"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblPolicyFormsRow tblPolicyFormsRow
    {
      get
      {
        return (dsPolicyFCW.tblPolicyFormsRow) this.GetParentRow(this.Table.ParentRelations["tblPolicyFormstblQuoteFormsConditionsWarranties"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblPolicyFormstblQuoteFormsConditionsWarranties"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblConditionsRow tblConditionsRow
    {
      get
      {
        return (dsPolicyFCW.tblConditionsRow) this.GetParentRow(this.Table.ParentRelations["tblConditionstblQuoteFormsConditionsWarranties"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblConditionstblQuoteFormsConditionsWarranties"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblUsersRow tblUsersRowBytblUsers_tblQuoteFormsConditionsWarranties
    {
      get
      {
        return (dsPolicyFCW.tblUsersRow) this.GetParentRow(this.Table.ParentRelations["tblUsers_tblQuoteFormsConditionsWarranties"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblUsers_tblQuoteFormsConditionsWarranties"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblUsersRow tblUsersRowBytblUsers_tblQuoteFormsConditionsWarranties1
    {
      get
      {
        return (dsPolicyFCW.tblUsersRow) this.GetParentRow(this.Table.ParentRelations["tblUsers_tblQuoteFormsConditionsWarranties1"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblUsers_tblQuoteFormsConditionsWarranties1"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyFormIDNull()
    {
      return this.IsNull(this.tabletblQuoteFormsConditionsWarranties.PolicyFormIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyFormIDNull()
    {
      this[this.tabletblQuoteFormsConditionsWarranties.PolicyFormIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsConditionIDNull()
    {
      return this.IsNull(this.tabletblQuoteFormsConditionsWarranties.ConditionIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetConditionIDNull()
    {
      this[this.tabletblQuoteFormsConditionsWarranties.ConditionIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsWarrantyIDNull()
    {
      return this.IsNull(this.tabletblQuoteFormsConditionsWarranties.WarrantyIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetWarrantyIDNull()
    {
      this[this.tabletblQuoteFormsConditionsWarranties.WarrantyIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEndorsementNumNull()
    {
      return this.IsNull(this.tabletblQuoteFormsConditionsWarranties.EndorsementNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEndorsementNumNull()
    {
      this[this.tabletblQuoteFormsConditionsWarranties.EndorsementNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOriginalIDNull()
    {
      return this.IsNull(this.tabletblQuoteFormsConditionsWarranties.OriginalIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOriginalIDNull()
    {
      this[this.tabletblQuoteFormsConditionsWarranties.OriginalIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsWaivedByUserGuidNull()
    {
      return this.IsNull(this.tabletblQuoteFormsConditionsWarranties.WaivedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetWaivedByUserGuidNull()
    {
      this[this.tabletblQuoteFormsConditionsWarranties.WaivedByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddedByUserGuidNull()
    {
      return this.IsNull(this.tabletblQuoteFormsConditionsWarranties.AddedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddedByUserGuidNull()
    {
      this[this.tabletblQuoteFormsConditionsWarranties.AddedByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompany_FCW_IDNull()
    {
      return this.IsNull(this.tabletblQuoteFormsConditionsWarranties.Company_FCW_IDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompany_FCW_IDNull()
    {
      this[this.tabletblQuoteFormsConditionsWarranties.Company_FCW_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddedNull()
    {
      return this.IsNull(this.tabletblQuoteFormsConditionsWarranties.AddedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddedNull()
    {
      this[this.tabletblQuoteFormsConditionsWarranties.AddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyFormCommentsNull()
    {
      return this.IsNull(this.tabletblQuoteFormsConditionsWarranties.PolicyFormCommentsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyFormCommentsNull()
    {
      this[this.tabletblQuoteFormsConditionsWarranties.PolicyFormCommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyLineIDNull()
    {
      return this.IsNull(this.tabletblQuoteFormsConditionsWarranties.CompanyLineIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyLineIDNull()
    {
      this[this.tabletblQuoteFormsConditionsWarranties.CompanyLineIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRaterIDNull()
    {
      return this.IsNull(this.tabletblQuoteFormsConditionsWarranties.RaterIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRaterIDNull()
    {
      this[this.tabletblQuoteFormsConditionsWarranties.RaterIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRaterConditionalIDNull()
    {
      return this.IsNull(this.tabletblQuoteFormsConditionsWarranties.RaterConditionalIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRaterConditionalIDNull()
    {
      this[this.tabletblQuoteFormsConditionsWarranties.RaterConditionalIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblConditionsRow : DataRow
  {
    private dsPolicyFCW.tblConditionsDataTable tabletblConditions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblConditionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblConditions = (dsPolicyFCW.tblConditionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ConditionID
    {
      get => Conversions.ToInteger(this[this.tabletblConditions.ConditionIDColumn]);
      set => this[this.tabletblConditions.ConditionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Condition
    {
      get => Conversions.ToString(this[this.tabletblConditions.ConditionColumn]);
      set => this[this.tabletblConditions.ConditionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Applied
    {
      get => Conversions.ToBoolean(this[this.tabletblConditions.AppliedColumn]);
      set => this[this.tabletblConditions.AppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Mandatory
    {
      get => Conversions.ToBoolean(this[this.tabletblConditions.MandatoryColumn]);
      set => this[this.tabletblConditions.MandatoryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Company_FCW_ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblConditions.Company_FCW_IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Company_FCW_ID' in table 'tblConditions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblConditions.Company_FCW_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid WaivedByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblConditions.WaivedByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WaivedByUserGuid' in table 'tblConditions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblConditions.WaivedByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid AddedByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblConditions.AddedByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddedByUserGuid' in table 'tblConditions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblConditions.AddedByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PlacedByCompanyLineID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblConditions.PlacedByCompanyLineIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PlacedByCompanyLineID' in table 'tblConditions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblConditions.PlacedByCompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RaterID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblConditions.RaterIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RaterID' in table 'tblConditions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblConditions.RaterIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Hidden
    {
      get => Conversions.ToBoolean(this[this.tabletblConditions.HiddenColumn]);
      set => this[this.tabletblConditions.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RaterConditionalID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblConditions.RaterConditionalIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RaterConditionalID' in table 'tblConditions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblConditions.RaterConditionalIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompany_FCW_IDNull() => this.IsNull(this.tabletblConditions.Company_FCW_IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompany_FCW_IDNull()
    {
      this[this.tabletblConditions.Company_FCW_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsWaivedByUserGuidNull()
    {
      return this.IsNull(this.tabletblConditions.WaivedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetWaivedByUserGuidNull()
    {
      this[this.tabletblConditions.WaivedByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddedByUserGuidNull()
    {
      return this.IsNull(this.tabletblConditions.AddedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddedByUserGuidNull()
    {
      this[this.tabletblConditions.AddedByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPlacedByCompanyLineIDNull()
    {
      return this.IsNull(this.tabletblConditions.PlacedByCompanyLineIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPlacedByCompanyLineIDNull()
    {
      this[this.tabletblConditions.PlacedByCompanyLineIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRaterIDNull() => this.IsNull(this.tabletblConditions.RaterIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRaterIDNull()
    {
      this[this.tabletblConditions.RaterIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRaterConditionalIDNull()
    {
      return this.IsNull(this.tabletblConditions.RaterConditionalIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRaterConditionalIDNull()
    {
      this[this.tabletblConditions.RaterConditionalIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow[] GettblQuoteFormsConditionsWarrantiesRows()
    {
      return this.Table.ChildRelations["tblConditionstblQuoteFormsConditionsWarranties"] != null ? (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow[]) this.GetChildRows(this.Table.ChildRelations["tblConditionstblQuoteFormsConditionsWarranties"]) : new dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow[0];
    }
  }

  public class tblPolicyFormsRow : DataRow
  {
    private dsPolicyFCW.tblPolicyFormsDataTable tabletblPolicyForms;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblPolicyFormsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblPolicyForms = (dsPolicyFCW.tblPolicyFormsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int FormID
    {
      get => Conversions.ToInteger(this[this.tabletblPolicyForms.FormIDColumn]);
      set => this[this.tabletblPolicyForms.FormIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FormName
    {
      get => Conversions.ToString(this[this.tabletblPolicyForms.FormNameColumn]);
      set => this[this.tabletblPolicyForms.FormNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EndorsementNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.EndorsementNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementNum' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.EndorsementNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Applied
    {
      get => Conversions.ToBoolean(this[this.tabletblPolicyForms.AppliedColumn]);
      set => this[this.tabletblPolicyForms.AppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool RequiresEndorsementNumber
    {
      get => Conversions.ToBoolean(this[this.tabletblPolicyForms.RequiresEndorsementNumberColumn]);
      set => this[this.tabletblPolicyForms.RequiresEndorsementNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FormNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.FormNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FormNumber' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.FormNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ParentFormID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyForms.ParentFormIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ParentFormID' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.ParentFormIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid WaivedByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblPolicyForms.WaivedByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WaivedByUserGuid' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.WaivedByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool AllowDuplicates
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyForms.AllowDuplicatesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AllowDuplicates' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.AllowDuplicatesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PlacedByCompanyLineID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyForms.PlacedByCompanyLineIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PlacedByCompanyLineID' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.PlacedByCompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LineName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.LineNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LineName' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.LineNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid AddedByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblPolicyForms.AddedByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddedByUserGuid' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.AddedByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid FormCompanyLineGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblPolicyForms.FormCompanyLineGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FormCompanyLineGuid' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.FormCompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Mandatory
    {
      get => Conversions.ToBoolean(this[this.tabletblPolicyForms.MandatoryColumn]);
      set => this[this.tabletblPolicyForms.MandatoryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Company_FCW_ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyForms.Company_FCW_IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Company_FCW_ID' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.Company_FCW_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int AssociatedWarrantyID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyForms.AssociatedWarrantyIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AssociatedWarrantyID' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.AssociatedWarrantyIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int AssociatedFormID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyForms.AssociatedFormIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AssociatedFormID' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.AssociatedFormIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FormType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.FormTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FormType' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.FormTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EditionDate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.EditionDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EditionDate' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.EditionDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Comments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.CommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Comments' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.CommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyFormComments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.PolicyFormCommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyFormComments' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.PolicyFormCommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RaterID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyForms.RaterIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RaterID' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.RaterIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Hidden
    {
      get => Conversions.ToBoolean(this[this.tabletblPolicyForms.HiddenColumn]);
      set => this[this.tabletblPolicyForms.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RaterConditionalID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyForms.RaterConditionalIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RaterConditionalID' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.RaterConditionalIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string OncePer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.OncePerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OncePer' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.OncePerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool RequiresEdit
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyForms.RequiresEditColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RequiresEdit' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.RequiresEditColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tabletblPolicyForms.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tabletblPolicyForms.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEndorsementNumNull()
    {
      return this.IsNull(this.tabletblPolicyForms.EndorsementNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEndorsementNumNull()
    {
      this[this.tabletblPolicyForms.EndorsementNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFormNumberNull() => this.IsNull(this.tabletblPolicyForms.FormNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFormNumberNull()
    {
      this[this.tabletblPolicyForms.FormNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsParentFormIDNull() => this.IsNull(this.tabletblPolicyForms.ParentFormIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetParentFormIDNull()
    {
      this[this.tabletblPolicyForms.ParentFormIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsWaivedByUserGuidNull()
    {
      return this.IsNull(this.tabletblPolicyForms.WaivedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetWaivedByUserGuidNull()
    {
      this[this.tabletblPolicyForms.WaivedByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAllowDuplicatesNull()
    {
      return this.IsNull(this.tabletblPolicyForms.AllowDuplicatesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAllowDuplicatesNull()
    {
      this[this.tabletblPolicyForms.AllowDuplicatesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPlacedByCompanyLineIDNull()
    {
      return this.IsNull(this.tabletblPolicyForms.PlacedByCompanyLineIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPlacedByCompanyLineIDNull()
    {
      this[this.tabletblPolicyForms.PlacedByCompanyLineIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLineNameNull() => this.IsNull(this.tabletblPolicyForms.LineNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLineNameNull()
    {
      this[this.tabletblPolicyForms.LineNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddedByUserGuidNull()
    {
      return this.IsNull(this.tabletblPolicyForms.AddedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddedByUserGuidNull()
    {
      this[this.tabletblPolicyForms.AddedByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFormCompanyLineGuidNull()
    {
      return this.IsNull(this.tabletblPolicyForms.FormCompanyLineGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFormCompanyLineGuidNull()
    {
      this[this.tabletblPolicyForms.FormCompanyLineGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompany_FCW_IDNull()
    {
      return this.IsNull(this.tabletblPolicyForms.Company_FCW_IDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompany_FCW_IDNull()
    {
      this[this.tabletblPolicyForms.Company_FCW_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAssociatedWarrantyIDNull()
    {
      return this.IsNull(this.tabletblPolicyForms.AssociatedWarrantyIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAssociatedWarrantyIDNull()
    {
      this[this.tabletblPolicyForms.AssociatedWarrantyIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAssociatedFormIDNull()
    {
      return this.IsNull(this.tabletblPolicyForms.AssociatedFormIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAssociatedFormIDNull()
    {
      this[this.tabletblPolicyForms.AssociatedFormIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFormTypeNull() => this.IsNull(this.tabletblPolicyForms.FormTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFormTypeNull()
    {
      this[this.tabletblPolicyForms.FormTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEditionDateNull() => this.IsNull(this.tabletblPolicyForms.EditionDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEditionDateNull()
    {
      this[this.tabletblPolicyForms.EditionDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCommentsNull() => this.IsNull(this.tabletblPolicyForms.CommentsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCommentsNull()
    {
      this[this.tabletblPolicyForms.CommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyFormCommentsNull()
    {
      return this.IsNull(this.tabletblPolicyForms.PolicyFormCommentsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyFormCommentsNull()
    {
      this[this.tabletblPolicyForms.PolicyFormCommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRaterIDNull() => this.IsNull(this.tabletblPolicyForms.RaterIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRaterIDNull()
    {
      this[this.tabletblPolicyForms.RaterIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRaterConditionalIDNull()
    {
      return this.IsNull(this.tabletblPolicyForms.RaterConditionalIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRaterConditionalIDNull()
    {
      this[this.tabletblPolicyForms.RaterConditionalIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOncePerNull() => this.IsNull(this.tabletblPolicyForms.OncePerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOncePerNull()
    {
      this[this.tabletblPolicyForms.OncePerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRequiresEditNull() => this.IsNull(this.tabletblPolicyForms.RequiresEditColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRequiresEditNull()
    {
      this[this.tabletblPolicyForms.RequiresEditColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantyFormsRow[] GettblWarrantyFormsRows()
    {
      return this.Table.ChildRelations["tblPolicyFormstblWarrantyForms"] != null ? (dsPolicyFCW.tblWarrantyFormsRow[]) this.GetChildRows(this.Table.ChildRelations["tblPolicyFormstblWarrantyForms"]) : new dsPolicyFCW.tblWarrantyFormsRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow[] GettblQuoteFormsConditionsWarrantiesRows()
    {
      return this.Table.ChildRelations["tblPolicyFormstblQuoteFormsConditionsWarranties"] != null ? (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow[]) this.GetChildRows(this.Table.ChildRelations["tblPolicyFormstblQuoteFormsConditionsWarranties"]) : new dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow[0];
    }
  }

  public class tblWarrantiesRow : DataRow
  {
    private dsPolicyFCW.tblWarrantiesDataTable tabletblWarranties;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblWarrantiesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblWarranties = (dsPolicyFCW.tblWarrantiesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int WarrantyID
    {
      get => Conversions.ToInteger(this[this.tabletblWarranties.WarrantyIDColumn]);
      set => this[this.tabletblWarranties.WarrantyIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string WarrantyName
    {
      get => Conversions.ToString(this[this.tabletblWarranties.WarrantyNameColumn]);
      set => this[this.tabletblWarranties.WarrantyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Applied
    {
      get => Conversions.ToBoolean(this[this.tabletblWarranties.AppliedColumn]);
      set => this[this.tabletblWarranties.AppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Mandatory
    {
      get => Conversions.ToBoolean(this[this.tabletblWarranties.MandatoryColumn]);
      set => this[this.tabletblWarranties.MandatoryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Company_FCW_ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblWarranties.Company_FCW_IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Company_FCW_ID' in table 'tblWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblWarranties.Company_FCW_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid WaivedByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblWarranties.WaivedByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WaivedByUserGuid' in table 'tblWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblWarranties.WaivedByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid AddedByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblWarranties.AddedByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddedByUserGuid' in table 'tblWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblWarranties.AddedByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PlacedByCompanyLineID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblWarranties.PlacedByCompanyLineIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PlacedByCompanyLineID' in table 'tblWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblWarranties.PlacedByCompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompany_FCW_IDNull() => this.IsNull(this.tabletblWarranties.Company_FCW_IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompany_FCW_IDNull()
    {
      this[this.tabletblWarranties.Company_FCW_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsWaivedByUserGuidNull()
    {
      return this.IsNull(this.tabletblWarranties.WaivedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetWaivedByUserGuidNull()
    {
      this[this.tabletblWarranties.WaivedByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddedByUserGuidNull()
    {
      return this.IsNull(this.tabletblWarranties.AddedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddedByUserGuidNull()
    {
      this[this.tabletblWarranties.AddedByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPlacedByCompanyLineIDNull()
    {
      return this.IsNull(this.tabletblWarranties.PlacedByCompanyLineIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPlacedByCompanyLineIDNull()
    {
      this[this.tabletblWarranties.PlacedByCompanyLineIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantyFormsRow[] GettblWarrantyFormsRows()
    {
      return this.Table.ChildRelations["tblWarrantiestblWarrantyForms"] != null ? (dsPolicyFCW.tblWarrantyFormsRow[]) this.GetChildRows(this.Table.ChildRelations["tblWarrantiestblWarrantyForms"]) : new dsPolicyFCW.tblWarrantyFormsRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow[] GettblQuoteFormsConditionsWarrantiesRows()
    {
      return this.Table.ChildRelations["tblWarrantiestblQuoteFormsConditionsWarranties"] != null ? (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow[]) this.GetChildRows(this.Table.ChildRelations["tblWarrantiestblQuoteFormsConditionsWarranties"]) : new dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow[0];
    }
  }

  public class tblWarrantyFormsRow : DataRow
  {
    private dsPolicyFCW.tblWarrantyFormsDataTable tabletblWarrantyForms;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblWarrantyFormsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblWarrantyForms = (dsPolicyFCW.tblWarrantyFormsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int WarrantyID
    {
      get => Conversions.ToInteger(this[this.tabletblWarrantyForms.WarrantyIDColumn]);
      set => this[this.tabletblWarrantyForms.WarrantyIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyFormID
    {
      get => Conversions.ToInteger(this[this.tabletblWarrantyForms.PolicyFormIDColumn]);
      set => this[this.tabletblWarrantyForms.PolicyFormIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblPolicyFormsRow tblPolicyFormsRow
    {
      get
      {
        return (dsPolicyFCW.tblPolicyFormsRow) this.GetParentRow(this.Table.ParentRelations["tblPolicyFormstblWarrantyForms"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblPolicyFormstblWarrantyForms"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantiesRow tblWarrantiesRow
    {
      get
      {
        return (dsPolicyFCW.tblWarrantiesRow) this.GetParentRow(this.Table.ParentRelations["tblWarrantiestblWarrantyForms"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblWarrantiestblWarrantyForms"]);
      }
    }
  }

  public class tblNetRateAdditionalDataRow : DataRow
  {
    private dsPolicyFCW.tblNetRateAdditionalDataDataTable tabletblNetRateAdditionalData;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblNetRateAdditionalDataRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblNetRateAdditionalData = (dsPolicyFCW.tblNetRateAdditionalDataDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblNetRateAdditionalData.IDColumn]);
      set => this[this.tabletblNetRateAdditionalData.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        object obj = this[this.tabletblNetRateAdditionalData.QuoteGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblNetRateAdditionalData.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AdditionalComments
    {
      get
      {
        return !this.IsAdditionalCommentsNull() ? Conversions.ToString(this[this.tabletblNetRateAdditionalData.AdditionalCommentsColumn]) : string.Empty;
      }
      set => this[this.tabletblNetRateAdditionalData.AdditionalCommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAdditionalCommentsNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.AdditionalCommentsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAdditionalCommentsNull()
    {
      this[this.tabletblNetRateAdditionalData.AdditionalCommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblUsersRow : DataRow
  {
    private dsPolicyFCW.tblUsersDataTable tabletblUsers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblUsersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUsers = (dsPolicyFCW.tblUsersDataTable) this.Table;
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
    public string User
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUsers.UserColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'User' in table 'tblUsers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUsers.UserColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUserNull() => this.IsNull(this.tabletblUsers.UserColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUserNull()
    {
      this[this.tabletblUsers.UserColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow[] GettblQuoteFormsConditionsWarrantiesRowsBytblUsers_tblQuoteFormsConditionsWarranties()
    {
      return this.Table.ChildRelations["tblUsers_tblQuoteFormsConditionsWarranties"] != null ? (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow[]) this.GetChildRows(this.Table.ChildRelations["tblUsers_tblQuoteFormsConditionsWarranties"]) : new dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow[] GettblQuoteFormsConditionsWarrantiesRowsBytblUsers_tblQuoteFormsConditionsWarranties1()
    {
      return this.Table.ChildRelations["tblUsers_tblQuoteFormsConditionsWarranties1"] != null ? (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow[]) this.GetChildRows(this.Table.ChildRelations["tblUsers_tblQuoteFormsConditionsWarranties1"]) : new dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow[0];
    }
  }

  public class tblWarrantiesAssociatedFormsRow : DataRow
  {
    private dsPolicyFCW.tblWarrantiesAssociatedFormsDataTable tabletblWarrantiesAssociatedForms;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblWarrantiesAssociatedFormsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblWarrantiesAssociatedForms = (dsPolicyFCW.tblWarrantiesAssociatedFormsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int WarrantyID
    {
      get => Conversions.ToInteger(this[this.tabletblWarrantiesAssociatedForms.WarrantyIDColumn]);
      set => this[this.tabletblWarrantiesAssociatedForms.WarrantyIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyFormID
    {
      get => Conversions.ToInteger(this[this.tabletblWarrantiesAssociatedForms.PolicyFormIDColumn]);
      set => this[this.tabletblWarrantiesAssociatedForms.PolicyFormIDColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblQuoteFormsConditionsWarrantiesRowChangeEvent : EventArgs
  {
    private dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuoteFormsConditionsWarrantiesRowChangeEvent(
      dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblConditionsRowChangeEvent : EventArgs
  {
    private dsPolicyFCW.tblConditionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblConditionsRowChangeEvent(dsPolicyFCW.tblConditionsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblConditionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblPolicyFormsRowChangeEvent : EventArgs
  {
    private dsPolicyFCW.tblPolicyFormsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblPolicyFormsRowChangeEvent(dsPolicyFCW.tblPolicyFormsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblPolicyFormsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblWarrantiesRowChangeEvent : EventArgs
  {
    private dsPolicyFCW.tblWarrantiesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblWarrantiesRowChangeEvent(dsPolicyFCW.tblWarrantiesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantiesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblWarrantyFormsRowChangeEvent : EventArgs
  {
    private dsPolicyFCW.tblWarrantyFormsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblWarrantyFormsRowChangeEvent(dsPolicyFCW.tblWarrantyFormsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantyFormsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblNetRateAdditionalDataRowChangeEvent : EventArgs
  {
    private dsPolicyFCW.tblNetRateAdditionalDataRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblNetRateAdditionalDataRowChangeEvent(
      dsPolicyFCW.tblNetRateAdditionalDataRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblNetRateAdditionalDataRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblUsersRowChangeEvent : EventArgs
  {
    private dsPolicyFCW.tblUsersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblUsersRowChangeEvent(dsPolicyFCW.tblUsersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblUsersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblWarrantiesAssociatedFormsRowChangeEvent : EventArgs
  {
    private dsPolicyFCW.tblWarrantiesAssociatedFormsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblWarrantiesAssociatedFormsRowChangeEvent(
      dsPolicyFCW.tblWarrantiesAssociatedFormsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyFCW.tblWarrantiesAssociatedFormsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
