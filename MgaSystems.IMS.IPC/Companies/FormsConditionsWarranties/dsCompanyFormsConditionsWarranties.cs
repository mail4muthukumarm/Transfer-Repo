// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.FormsConditionsWarranties.dsCompanyFormsConditionsWarranties
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies.FormsConditionsWarranties;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCompanyFormsConditionsWarranties")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyFormsConditionsWarranties : DataSet
{
  private dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable tabletblCompanyFormsConditionsWarranties;
  private dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesDataTable tabletblCompanyFormsConditionsWarranties_PrintTypes;
  private dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesDataTable tablelstPolicyPrintTypes;
  private dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesDataTable tablelstAdditionalInterestTypes;
  private dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsDataTable tabletblCompanyInterestForms;
  private dsCompanyFormsConditionsWarranties.lstNoteTypesDataTable tablelstNoteTypes;
  private dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsDataTable tabletblWarrantiesAssociatedForms;
  private dsCompanyFormsConditionsWarranties.lstFCWConditionTypeDataTable tablelstFCWConditionType;
  private DataRelation relationtblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes;
  private DataRelation relationlstPolicyPrintTypestblCompanyFormsConditionsWarranties_PrintTypes;
  private DataRelation relationFK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms;
  private DataRelation relationFK_lstAdditionalInterestTypes_tblCompanyInterestForms;
  private DataRelation relationtblCompanyFormsConditionsWarranties_tblWarrantiesAssociatedForms;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsCompanyFormsConditionsWarranties()
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
  protected dsCompanyFormsConditionsWarranties(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyFormsConditionsWarranties)] != null)
          base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable(dataSet.Tables[nameof (tblCompanyFormsConditionsWarranties)]));
        if (dataSet.Tables[nameof (tblCompanyFormsConditionsWarranties_PrintTypes)] != null)
          base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesDataTable(dataSet.Tables[nameof (tblCompanyFormsConditionsWarranties_PrintTypes)]));
        if (dataSet.Tables[nameof (lstPolicyPrintTypes)] != null)
          base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesDataTable(dataSet.Tables[nameof (lstPolicyPrintTypes)]));
        if (dataSet.Tables[nameof (lstAdditionalInterestTypes)] != null)
          base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesDataTable(dataSet.Tables[nameof (lstAdditionalInterestTypes)]));
        if (dataSet.Tables[nameof (tblCompanyInterestForms)] != null)
          base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsDataTable(dataSet.Tables[nameof (tblCompanyInterestForms)]));
        if (dataSet.Tables[nameof (lstNoteTypes)] != null)
          base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.lstNoteTypesDataTable(dataSet.Tables[nameof (lstNoteTypes)]));
        if (dataSet.Tables[nameof (tblWarrantiesAssociatedForms)] != null)
          base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsDataTable(dataSet.Tables[nameof (tblWarrantiesAssociatedForms)]));
        if (dataSet.Tables[nameof (lstFCWConditionType)] != null)
          base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.lstFCWConditionTypeDataTable(dataSet.Tables[nameof (lstFCWConditionType)]));
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
  public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable tblCompanyFormsConditionsWarranties
  {
    get => this.tabletblCompanyFormsConditionsWarranties;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesDataTable tblCompanyFormsConditionsWarranties_PrintTypes
  {
    get => this.tabletblCompanyFormsConditionsWarranties_PrintTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesDataTable lstPolicyPrintTypes
  {
    get => this.tablelstPolicyPrintTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesDataTable lstAdditionalInterestTypes
  {
    get => this.tablelstAdditionalInterestTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsDataTable tblCompanyInterestForms
  {
    get => this.tabletblCompanyInterestForms;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyFormsConditionsWarranties.lstNoteTypesDataTable lstNoteTypes
  {
    get => this.tablelstNoteTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsDataTable tblWarrantiesAssociatedForms
  {
    get => this.tabletblWarrantiesAssociatedForms;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyFormsConditionsWarranties.lstFCWConditionTypeDataTable lstFCWConditionType
  {
    get => this.tablelstFCWConditionType;
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
    dsCompanyFormsConditionsWarranties conditionsWarranties = (dsCompanyFormsConditionsWarranties) base.Clone();
    conditionsWarranties.InitVars();
    conditionsWarranties.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) conditionsWarranties;
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
      if (dataSet.Tables["tblCompanyFormsConditionsWarranties"] != null)
        base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable(dataSet.Tables["tblCompanyFormsConditionsWarranties"]));
      if (dataSet.Tables["tblCompanyFormsConditionsWarranties_PrintTypes"] != null)
        base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesDataTable(dataSet.Tables["tblCompanyFormsConditionsWarranties_PrintTypes"]));
      if (dataSet.Tables["lstPolicyPrintTypes"] != null)
        base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesDataTable(dataSet.Tables["lstPolicyPrintTypes"]));
      if (dataSet.Tables["lstAdditionalInterestTypes"] != null)
        base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesDataTable(dataSet.Tables["lstAdditionalInterestTypes"]));
      if (dataSet.Tables["tblCompanyInterestForms"] != null)
        base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsDataTable(dataSet.Tables["tblCompanyInterestForms"]));
      if (dataSet.Tables["lstNoteTypes"] != null)
        base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.lstNoteTypesDataTable(dataSet.Tables["lstNoteTypes"]));
      if (dataSet.Tables["tblWarrantiesAssociatedForms"] != null)
        base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsDataTable(dataSet.Tables["tblWarrantiesAssociatedForms"]));
      if (dataSet.Tables["lstFCWConditionType"] != null)
        base.Tables.Add((DataTable) new dsCompanyFormsConditionsWarranties.lstFCWConditionTypeDataTable(dataSet.Tables["lstFCWConditionType"]));
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
    this.tabletblCompanyFormsConditionsWarranties = (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable) base.Tables["tblCompanyFormsConditionsWarranties"];
    if (initTable && this.tabletblCompanyFormsConditionsWarranties != null)
      this.tabletblCompanyFormsConditionsWarranties.InitVars();
    this.tabletblCompanyFormsConditionsWarranties_PrintTypes = (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesDataTable) base.Tables["tblCompanyFormsConditionsWarranties_PrintTypes"];
    if (initTable && this.tabletblCompanyFormsConditionsWarranties_PrintTypes != null)
      this.tabletblCompanyFormsConditionsWarranties_PrintTypes.InitVars();
    this.tablelstPolicyPrintTypes = (dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesDataTable) base.Tables["lstPolicyPrintTypes"];
    if (initTable && this.tablelstPolicyPrintTypes != null)
      this.tablelstPolicyPrintTypes.InitVars();
    this.tablelstAdditionalInterestTypes = (dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesDataTable) base.Tables["lstAdditionalInterestTypes"];
    if (initTable && this.tablelstAdditionalInterestTypes != null)
      this.tablelstAdditionalInterestTypes.InitVars();
    this.tabletblCompanyInterestForms = (dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsDataTable) base.Tables["tblCompanyInterestForms"];
    if (initTable && this.tabletblCompanyInterestForms != null)
      this.tabletblCompanyInterestForms.InitVars();
    this.tablelstNoteTypes = (dsCompanyFormsConditionsWarranties.lstNoteTypesDataTable) base.Tables["lstNoteTypes"];
    if (initTable && this.tablelstNoteTypes != null)
      this.tablelstNoteTypes.InitVars();
    this.tabletblWarrantiesAssociatedForms = (dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsDataTable) base.Tables["tblWarrantiesAssociatedForms"];
    if (initTable && this.tabletblWarrantiesAssociatedForms != null)
      this.tabletblWarrantiesAssociatedForms.InitVars();
    this.tablelstFCWConditionType = (dsCompanyFormsConditionsWarranties.lstFCWConditionTypeDataTable) base.Tables["lstFCWConditionType"];
    if (initTable && this.tablelstFCWConditionType != null)
      this.tablelstFCWConditionType.InitVars();
    this.relationtblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes = this.Relations["tblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes"];
    this.relationlstPolicyPrintTypestblCompanyFormsConditionsWarranties_PrintTypes = this.Relations["lstPolicyPrintTypestblCompanyFormsConditionsWarranties_PrintTypes"];
    this.relationFK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms = this.Relations["FK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms"];
    this.relationFK_lstAdditionalInterestTypes_tblCompanyInterestForms = this.Relations["FK_lstAdditionalInterestTypes_tblCompanyInterestForms"];
    this.relationtblCompanyFormsConditionsWarranties_tblWarrantiesAssociatedForms = this.Relations["tblCompanyFormsConditionsWarranties_tblWarrantiesAssociatedForms"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyFormsConditionsWarranties);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCompanyFormsConditionsWarranties.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyFormsConditionsWarranties = new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyFormsConditionsWarranties);
    this.tabletblCompanyFormsConditionsWarranties_PrintTypes = new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyFormsConditionsWarranties_PrintTypes);
    this.tablelstPolicyPrintTypes = new dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstPolicyPrintTypes);
    this.tablelstAdditionalInterestTypes = new dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstAdditionalInterestTypes);
    this.tabletblCompanyInterestForms = new dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyInterestForms);
    this.tablelstNoteTypes = new dsCompanyFormsConditionsWarranties.lstNoteTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstNoteTypes);
    this.tabletblWarrantiesAssociatedForms = new dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsDataTable();
    base.Tables.Add((DataTable) this.tabletblWarrantiesAssociatedForms);
    this.tablelstFCWConditionType = new dsCompanyFormsConditionsWarranties.lstFCWConditionTypeDataTable();
    base.Tables.Add((DataTable) this.tablelstFCWConditionType);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("tblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes", new DataColumn[1]
    {
      this.tabletblCompanyFormsConditionsWarranties.Company_FCW_IDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyFormsConditionsWarranties_PrintTypes.Company_FCW_IDColumn
    });
    this.tabletblCompanyFormsConditionsWarranties_PrintTypes.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstPolicyPrintTypestblCompanyFormsConditionsWarranties_PrintTypes", new DataColumn[1]
    {
      this.tablelstPolicyPrintTypes.PrintTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyFormsConditionsWarranties_PrintTypes.PrintTypeIDColumn
    });
    this.tabletblCompanyFormsConditionsWarranties_PrintTypes.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("FK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms", new DataColumn[1]
    {
      this.tabletblCompanyFormsConditionsWarranties.Company_FCW_IDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyInterestForms.Company_FCW_IDColumn
    });
    this.tabletblCompanyInterestForms.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("FK_lstAdditionalInterestTypes_tblCompanyInterestForms", new DataColumn[1]
    {
      this.tablelstAdditionalInterestTypes.InterestTypeColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyInterestForms.InterestTypeColumn
    });
    this.tabletblCompanyInterestForms.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    this.relationtblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes = new DataRelation("tblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes", new DataColumn[1]
    {
      this.tabletblCompanyFormsConditionsWarranties.Company_FCW_IDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyFormsConditionsWarranties_PrintTypes.Company_FCW_IDColumn
    }, false);
    this.Relations.Add(this.relationtblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes);
    this.relationlstPolicyPrintTypestblCompanyFormsConditionsWarranties_PrintTypes = new DataRelation("lstPolicyPrintTypestblCompanyFormsConditionsWarranties_PrintTypes", new DataColumn[1]
    {
      this.tablelstPolicyPrintTypes.PrintTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyFormsConditionsWarranties_PrintTypes.PrintTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstPolicyPrintTypestblCompanyFormsConditionsWarranties_PrintTypes);
    this.relationFK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms = new DataRelation("FK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms", new DataColumn[1]
    {
      this.tabletblCompanyFormsConditionsWarranties.Company_FCW_IDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyInterestForms.Company_FCW_IDColumn
    }, false);
    this.Relations.Add(this.relationFK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms);
    this.relationFK_lstAdditionalInterestTypes_tblCompanyInterestForms = new DataRelation("FK_lstAdditionalInterestTypes_tblCompanyInterestForms", new DataColumn[1]
    {
      this.tablelstAdditionalInterestTypes.InterestTypeColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyInterestForms.InterestTypeColumn
    }, false);
    this.Relations.Add(this.relationFK_lstAdditionalInterestTypes_tblCompanyInterestForms);
    this.relationtblCompanyFormsConditionsWarranties_tblWarrantiesAssociatedForms = new DataRelation("tblCompanyFormsConditionsWarranties_tblWarrantiesAssociatedForms", new DataColumn[1]
    {
      this.tabletblCompanyFormsConditionsWarranties.Company_FCW_IDColumn
    }, new DataColumn[1]
    {
      this.tabletblWarrantiesAssociatedForms.Company_FCW_IDColumn
    }, false);
    this.Relations.Add(this.relationtblCompanyFormsConditionsWarranties_tblWarrantiesAssociatedForms);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyFormsConditionsWarranties() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyFormsConditionsWarranties_PrintTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstPolicyPrintTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstAdditionalInterestTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyInterestForms() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstNoteTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblWarrantiesAssociatedForms() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstFCWConditionType() => false;

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
    dsCompanyFormsConditionsWarranties conditionsWarranties = new dsCompanyFormsConditionsWarranties();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = conditionsWarranties.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = conditionsWarranties.GetSchemaSerializable();
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
  public delegate void tblCompanyFormsConditionsWarrantiesRowChangeEventHandler(
    object sender,
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEventHandler(
    object sender,
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstPolicyPrintTypesRowChangeEventHandler(
    object sender,
    dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstAdditionalInterestTypesRowChangeEventHandler(
    object sender,
    dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyInterestFormsRowChangeEventHandler(
    object sender,
    dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstNoteTypesRowChangeEventHandler(
    object sender,
    dsCompanyFormsConditionsWarranties.lstNoteTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblWarrantiesAssociatedFormsRowChangeEventHandler(
    object sender,
    dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstFCWConditionTypeRowChangeEventHandler(
    object sender,
    dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyFormsConditionsWarrantiesDataTable : 
    TypedTableBase<dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow>
  {
    private DataColumn columnCompany_FCW_ID;
    private DataColumn columnCompanyLineID;
    private DataColumn columnPolicyFormID;
    private DataColumn columnConditionID;
    private DataColumn columnWarrantyID;
    private DataColumn columnCheckedByDefault;
    private DataColumn columnShowOnQuote;
    private DataColumn columnFormName;
    private DataColumn columnCondition;
    private DataColumn columnWarrantyName;
    private DataColumn columnFormNumber;
    private DataColumn columnEffective;
    private DataColumn columnDisabled;
    private DataColumn columnGenerateDiary;
    private DataColumn columnOncePer;
    private DataColumn columnNoteTypeID;
    private DataColumn columnIncludeWithQuotation;
    private DataColumn columnSelectPolicyForm;
    private DataColumn columnGenerateQuoteDiary;
    private DataColumn columnAddedDate;
    private DataColumn columnIncludeWithBinder;
    private DataColumn columnSelectCondition;
    private DataColumn columnCommonToPackage;
    private DataColumn columnMandatory;
    private DataColumn columnSelectWarranty;
    private DataColumn columnEditionDate;
    private DataColumn columnDescription;
    private DataColumn columnUserName;
    private DataColumn columnUserGUID;
    private DataColumn columnHasRaterConditional;
    private DataColumn columnConditionTypeNameID;
    private DataColumn columnBinderWatermark;
    private DataColumn columnIncludeWithIndication;
    private DataColumn columnAppliedToQuotes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyFormsConditionsWarrantiesDataTable()
    {
      this.TableName = "tblCompanyFormsConditionsWarranties";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyFormsConditionsWarrantiesDataTable(DataTable table)
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
    protected tblCompanyFormsConditionsWarrantiesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Company_FCW_IDColumn => this.columnCompany_FCW_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineIDColumn => this.columnCompanyLineID;

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
    public DataColumn CheckedByDefaultColumn => this.columnCheckedByDefault;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ShowOnQuoteColumn => this.columnShowOnQuote;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormNameColumn => this.columnFormName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ConditionColumn => this.columnCondition;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WarrantyNameColumn => this.columnWarrantyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormNumberColumn => this.columnFormNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EffectiveColumn => this.columnEffective;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DisabledColumn => this.columnDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GenerateDiaryColumn => this.columnGenerateDiary;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OncePerColumn => this.columnOncePer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NoteTypeIDColumn => this.columnNoteTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IncludeWithQuotationColumn => this.columnIncludeWithQuotation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SelectPolicyFormColumn => this.columnSelectPolicyForm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GenerateQuoteDiaryColumn => this.columnGenerateQuoteDiary;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AddedDateColumn => this.columnAddedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IncludeWithBinderColumn => this.columnIncludeWithBinder;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SelectConditionColumn => this.columnSelectCondition;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CommonToPackageColumn => this.columnCommonToPackage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MandatoryColumn => this.columnMandatory;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SelectWarrantyColumn => this.columnSelectWarranty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EditionDateColumn => this.columnEditionDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UserGUIDColumn => this.columnUserGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn HasRaterConditionalColumn => this.columnHasRaterConditional;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ConditionTypeNameIDColumn => this.columnConditionTypeNameID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BinderWatermarkColumn => this.columnBinderWatermark;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IncludeWithIndicationColumn => this.columnIncludeWithIndication;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AppliedToQuotesColumn => this.columnAppliedToQuotes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow this[int index]
    {
      get
      {
        return (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow) this.Rows[index];
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler tblCompanyFormsConditionsWarrantiesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler tblCompanyFormsConditionsWarrantiesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler tblCompanyFormsConditionsWarrantiesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler tblCompanyFormsConditionsWarrantiesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyFormsConditionsWarrantiesRow(
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow AddtblCompanyFormsConditionsWarrantiesRow(
      int CompanyLineID,
      int PolicyFormID,
      int ConditionID,
      int WarrantyID,
      bool CheckedByDefault,
      bool ShowOnQuote,
      string FormName,
      string Condition,
      string WarrantyName,
      string FormNumber,
      DateTime Effective,
      DateTime Disabled,
      bool GenerateDiary,
      string OncePer,
      int NoteTypeID,
      bool IncludeWithQuotation,
      bool SelectPolicyForm,
      bool GenerateQuoteDiary,
      DateTime AddedDate,
      string IncludeWithBinder,
      bool SelectCondition,
      bool CommonToPackage,
      bool Mandatory,
      bool SelectWarranty,
      string EditionDate,
      string Description,
      string UserName,
      Guid UserGUID,
      bool HasRaterConditional,
      int ConditionTypeNameID,
      bool BinderWatermark,
      bool IncludeWithIndication,
      bool AppliedToQuotes)
    {
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row = (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow) this.NewRow();
      object[] objArray = new object[34]
      {
        null,
        (object) CompanyLineID,
        (object) PolicyFormID,
        (object) ConditionID,
        (object) WarrantyID,
        (object) CheckedByDefault,
        (object) ShowOnQuote,
        (object) FormName,
        (object) Condition,
        (object) WarrantyName,
        (object) FormNumber,
        (object) Effective,
        (object) Disabled,
        (object) GenerateDiary,
        (object) OncePer,
        (object) NoteTypeID,
        (object) IncludeWithQuotation,
        (object) SelectPolicyForm,
        (object) GenerateQuoteDiary,
        (object) AddedDate,
        (object) IncludeWithBinder,
        (object) SelectCondition,
        (object) CommonToPackage,
        (object) Mandatory,
        (object) SelectWarranty,
        (object) EditionDate,
        (object) Description,
        (object) UserName,
        (object) UserGUID,
        (object) HasRaterConditional,
        (object) ConditionTypeNameID,
        (object) BinderWatermark,
        (object) IncludeWithIndication,
        (object) AppliedToQuotes
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow FindByCompany_FCW_ID(
      int Company_FCW_ID)
    {
      return (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow) this.Rows.Find(new object[1]
      {
        (object) Company_FCW_ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable warrantiesDataTable = (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable) base.Clone();
      warrantiesDataTable.InitVars();
      return (DataTable) warrantiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompany_FCW_ID = this.Columns["Company_FCW_ID"];
      this.columnCompanyLineID = this.Columns["CompanyLineID"];
      this.columnPolicyFormID = this.Columns["PolicyFormID"];
      this.columnConditionID = this.Columns["ConditionID"];
      this.columnWarrantyID = this.Columns["WarrantyID"];
      this.columnCheckedByDefault = this.Columns["CheckedByDefault"];
      this.columnShowOnQuote = this.Columns["ShowOnQuote"];
      this.columnFormName = this.Columns["FormName"];
      this.columnCondition = this.Columns["Condition"];
      this.columnWarrantyName = this.Columns["WarrantyName"];
      this.columnFormNumber = this.Columns["FormNumber"];
      this.columnEffective = this.Columns["Effective"];
      this.columnDisabled = this.Columns["Disabled"];
      this.columnGenerateDiary = this.Columns["GenerateDiary"];
      this.columnOncePer = this.Columns["OncePer"];
      this.columnNoteTypeID = this.Columns["NoteTypeID"];
      this.columnIncludeWithQuotation = this.Columns["IncludeWithQuotation"];
      this.columnSelectPolicyForm = this.Columns["SelectPolicyForm"];
      this.columnGenerateQuoteDiary = this.Columns["GenerateQuoteDiary"];
      this.columnAddedDate = this.Columns["AddedDate"];
      this.columnIncludeWithBinder = this.Columns["IncludeWithBinder"];
      this.columnSelectCondition = this.Columns["SelectCondition"];
      this.columnCommonToPackage = this.Columns["CommonToPackage"];
      this.columnMandatory = this.Columns["Mandatory"];
      this.columnSelectWarranty = this.Columns["SelectWarranty"];
      this.columnEditionDate = this.Columns["EditionDate"];
      this.columnDescription = this.Columns["Description"];
      this.columnUserName = this.Columns["UserName"];
      this.columnUserGUID = this.Columns["UserGUID"];
      this.columnHasRaterConditional = this.Columns["HasRaterConditional"];
      this.columnConditionTypeNameID = this.Columns["ConditionTypeNameID"];
      this.columnBinderWatermark = this.Columns["BinderWatermark"];
      this.columnIncludeWithIndication = this.Columns["IncludeWithIndication"];
      this.columnAppliedToQuotes = this.Columns["AppliedToQuotes"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompany_FCW_ID = new DataColumn("Company_FCW_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany_FCW_ID);
      this.columnCompanyLineID = new DataColumn("CompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineID);
      this.columnPolicyFormID = new DataColumn("PolicyFormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyFormID);
      this.columnConditionID = new DataColumn("ConditionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConditionID);
      this.columnWarrantyID = new DataColumn("WarrantyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWarrantyID);
      this.columnCheckedByDefault = new DataColumn("CheckedByDefault", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheckedByDefault);
      this.columnShowOnQuote = new DataColumn("ShowOnQuote", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnShowOnQuote);
      this.columnFormName = new DataColumn("FormName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormName);
      this.columnCondition = new DataColumn("Condition", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCondition);
      this.columnWarrantyName = new DataColumn("WarrantyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWarrantyName);
      this.columnFormNumber = new DataColumn("FormNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormNumber);
      this.columnEffective = new DataColumn("Effective", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffective);
      this.columnDisabled = new DataColumn("Disabled", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisabled);
      this.columnGenerateDiary = new DataColumn("GenerateDiary", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGenerateDiary);
      this.columnOncePer = new DataColumn("OncePer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOncePer);
      this.columnNoteTypeID = new DataColumn("NoteTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteTypeID);
      this.columnIncludeWithQuotation = new DataColumn("IncludeWithQuotation", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIncludeWithQuotation);
      this.columnSelectPolicyForm = new DataColumn("SelectPolicyForm", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSelectPolicyForm);
      this.columnGenerateQuoteDiary = new DataColumn("GenerateQuoteDiary", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGenerateQuoteDiary);
      this.columnAddedDate = new DataColumn("AddedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddedDate);
      this.columnIncludeWithBinder = new DataColumn("IncludeWithBinder", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIncludeWithBinder);
      this.columnSelectCondition = new DataColumn("SelectCondition", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSelectCondition);
      this.columnCommonToPackage = new DataColumn("CommonToPackage", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommonToPackage);
      this.columnMandatory = new DataColumn("Mandatory", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMandatory);
      this.columnSelectWarranty = new DataColumn("SelectWarranty", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSelectWarranty);
      this.columnEditionDate = new DataColumn("EditionDate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEditionDate);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.columnUserGUID = new DataColumn("UserGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUID);
      this.columnHasRaterConditional = new DataColumn("HasRaterConditional", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHasRaterConditional);
      this.columnConditionTypeNameID = new DataColumn("ConditionTypeNameID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConditionTypeNameID);
      this.columnBinderWatermark = new DataColumn("BinderWatermark", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBinderWatermark);
      this.columnIncludeWithIndication = new DataColumn("IncludeWithIndication", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIncludeWithIndication);
      this.columnAppliedToQuotes = new DataColumn("AppliedToQuotes", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAppliedToQuotes);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCompany_FCW_ID
      }, true));
      this.columnCompany_FCW_ID.AutoIncrement = true;
      this.columnCompany_FCW_ID.AutoIncrementSeed = -1L;
      this.columnCompany_FCW_ID.AutoIncrementStep = -1L;
      this.columnCompany_FCW_ID.AllowDBNull = false;
      this.columnCompany_FCW_ID.ReadOnly = true;
      this.columnCompany_FCW_ID.Unique = true;
      this.columnCompanyLineID.AllowDBNull = false;
      this.columnCheckedByDefault.AllowDBNull = false;
      this.columnCheckedByDefault.DefaultValue = (object) false;
      this.columnShowOnQuote.AllowDBNull = false;
      this.columnShowOnQuote.DefaultValue = (object) false;
      this.columnGenerateDiary.DefaultValue = (object) false;
      this.columnIncludeWithQuotation.AllowDBNull = false;
      this.columnIncludeWithQuotation.DefaultValue = (object) false;
      this.columnSelectPolicyForm.DefaultValue = (object) false;
      this.columnGenerateQuoteDiary.DefaultValue = (object) false;
      this.columnIncludeWithBinder.AllowDBNull = false;
      this.columnIncludeWithBinder.DefaultValue = (object) "False";
      this.columnSelectCondition.DefaultValue = (object) false;
      this.columnCommonToPackage.AllowDBNull = false;
      this.columnCommonToPackage.DefaultValue = (object) false;
      this.columnMandatory.AllowDBNull = false;
      this.columnMandatory.DefaultValue = (object) false;
      this.columnSelectWarranty.DefaultValue = (object) false;
      this.columnHasRaterConditional.AllowDBNull = false;
      this.columnHasRaterConditional.DefaultValue = (object) false;
      this.columnBinderWatermark.AllowDBNull = false;
      this.columnBinderWatermark.DefaultValue = (object) false;
      this.columnIncludeWithIndication.DefaultValue = (object) false;
      this.columnAppliedToQuotes.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow NewtblCompanyFormsConditionsWarrantiesRow()
    {
      return (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyFormsConditionsWarrantiesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler warrantiesRowChangedEvent = this.tblCompanyFormsConditionsWarrantiesRowChangedEvent;
      if (warrantiesRowChangedEvent == null)
        return;
      warrantiesRowChangedEvent((object) this, new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRowChangeEvent((dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyFormsConditionsWarrantiesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler rowChangingEvent = this.tblCompanyFormsConditionsWarrantiesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRowChangeEvent((dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyFormsConditionsWarrantiesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler warrantiesRowDeletedEvent = this.tblCompanyFormsConditionsWarrantiesRowDeletedEvent;
      if (warrantiesRowDeletedEvent == null)
        return;
      warrantiesRowDeletedEvent((object) this, new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRowChangeEvent((dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyFormsConditionsWarrantiesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler rowDeletingEvent = this.tblCompanyFormsConditionsWarrantiesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRowChangeEvent((dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyFormsConditionsWarrantiesRow(
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyFormsConditionsWarranties conditionsWarranties = new dsCompanyFormsConditionsWarranties();
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
        FixedValue = conditionsWarranties.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyFormsConditionsWarrantiesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = conditionsWarranties.GetSchemaSerializable();
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
  public class tblCompanyFormsConditionsWarranties_PrintTypesDataTable : 
    TypedTableBase<dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow>
  {
    private DataColumn columnCompany_FCW_ID;
    private DataColumn columnPrintTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyFormsConditionsWarranties_PrintTypesDataTable()
    {
      this.TableName = "tblCompanyFormsConditionsWarranties_PrintTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyFormsConditionsWarranties_PrintTypesDataTable(DataTable table)
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
    protected tblCompanyFormsConditionsWarranties_PrintTypesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Company_FCW_IDColumn => this.columnCompany_FCW_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PrintTypeIDColumn => this.columnPrintTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow this[
      int index]
    {
      get
      {
        return (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow) this.Rows[index];
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEventHandler tblCompanyFormsConditionsWarranties_PrintTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEventHandler tblCompanyFormsConditionsWarranties_PrintTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEventHandler tblCompanyFormsConditionsWarranties_PrintTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEventHandler tblCompanyFormsConditionsWarranties_PrintTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyFormsConditionsWarranties_PrintTypesRow(
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow AddtblCompanyFormsConditionsWarranties_PrintTypesRow(
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow parenttblCompanyFormsConditionsWarrantiesRowBytblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes,
      dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow parentlstPolicyPrintTypesRowBylstPolicyPrintTypestblCompanyFormsConditionsWarranties_PrintTypes)
    {
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow row = (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow) this.NewRow();
      object[] objArray = new object[2];
      if (parenttblCompanyFormsConditionsWarrantiesRowBytblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblCompanyFormsConditionsWarrantiesRowBytblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes[0]);
      if (parentlstPolicyPrintTypesRowBylstPolicyPrintTypestblCompanyFormsConditionsWarranties_PrintTypes != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstPolicyPrintTypesRowBylstPolicyPrintTypestblCompanyFormsConditionsWarranties_PrintTypes[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow FindByCompany_FCW_IDPrintTypeID(
      int Company_FCW_ID,
      int PrintTypeID)
    {
      return (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow) this.Rows.Find(new object[2]
      {
        (object) Company_FCW_ID,
        (object) PrintTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesDataTable printTypesDataTable = (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesDataTable) base.Clone();
      printTypesDataTable.InitVars();
      return (DataTable) printTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompany_FCW_ID = this.Columns["Company_FCW_ID"];
      this.columnPrintTypeID = this.Columns["PrintTypeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompany_FCW_ID = new DataColumn("Company_FCW_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany_FCW_ID);
      this.columnPrintTypeID = new DataColumn("PrintTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPrintTypeID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnCompany_FCW_ID,
        this.columnPrintTypeID
      }, true));
      this.columnCompany_FCW_ID.AllowDBNull = false;
      this.columnPrintTypeID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow NewtblCompanyFormsConditionsWarranties_PrintTypesRow()
    {
      return (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyFormsConditionsWarranties_PrintTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEventHandler typesRowChangedEvent = this.tblCompanyFormsConditionsWarranties_PrintTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyFormsConditionsWarranties_PrintTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEventHandler rowChangingEvent = this.tblCompanyFormsConditionsWarranties_PrintTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyFormsConditionsWarranties_PrintTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEventHandler typesRowDeletedEvent = this.tblCompanyFormsConditionsWarranties_PrintTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyFormsConditionsWarranties_PrintTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEventHandler rowDeletingEvent = this.tblCompanyFormsConditionsWarranties_PrintTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyFormsConditionsWarranties_PrintTypesRow(
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyFormsConditionsWarranties conditionsWarranties = new dsCompanyFormsConditionsWarranties();
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
        FixedValue = conditionsWarranties.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyFormsConditionsWarranties_PrintTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = conditionsWarranties.GetSchemaSerializable();
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
  public class lstPolicyPrintTypesDataTable : 
    TypedTableBase<dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow>
  {
    private DataColumn columnPrintTypeID;
    private DataColumn columnPrintType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstPolicyPrintTypesDataTable()
    {
      this.TableName = "lstPolicyPrintTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstPolicyPrintTypesDataTable(DataTable table)
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
    protected lstPolicyPrintTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PrintTypeIDColumn => this.columnPrintTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PrintTypeColumn => this.columnPrintType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow this[int index]
    {
      get => (dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRowChangeEventHandler lstPolicyPrintTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRowChangeEventHandler lstPolicyPrintTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRowChangeEventHandler lstPolicyPrintTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRowChangeEventHandler lstPolicyPrintTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstPolicyPrintTypesRow(
      dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow AddlstPolicyPrintTypesRow(
      int PrintTypeID,
      string PrintType)
    {
      dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow row = (dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) PrintTypeID,
        (object) PrintType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow FindByPrintTypeID(
      int PrintTypeID)
    {
      return (dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow) this.Rows.Find(new object[1]
      {
        (object) PrintTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesDataTable printTypesDataTable = (dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesDataTable) base.Clone();
      printTypesDataTable.InitVars();
      return (DataTable) printTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnPrintTypeID = this.Columns["PrintTypeID"];
      this.columnPrintType = this.Columns["PrintType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnPrintTypeID = new DataColumn("PrintTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPrintTypeID);
      this.columnPrintType = new DataColumn("PrintType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPrintType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyFormsConditionsWarrantiesKey1", new DataColumn[1]
      {
        this.columnPrintTypeID
      }, true));
      this.columnPrintTypeID.AllowDBNull = false;
      this.columnPrintTypeID.ReadOnly = true;
      this.columnPrintTypeID.Unique = true;
      this.columnPrintType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow NewlstPolicyPrintTypesRow()
    {
      return (dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyPrintTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRowChangeEventHandler typesRowChangedEvent = this.lstPolicyPrintTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyPrintTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRowChangeEventHandler rowChangingEvent = this.lstPolicyPrintTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyPrintTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRowChangeEventHandler typesRowDeletedEvent = this.lstPolicyPrintTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyPrintTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRowChangeEventHandler rowDeletingEvent = this.lstPolicyPrintTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstPolicyPrintTypesRow(
      dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyFormsConditionsWarranties conditionsWarranties = new dsCompanyFormsConditionsWarranties();
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
        FixedValue = conditionsWarranties.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPolicyPrintTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = conditionsWarranties.GetSchemaSerializable();
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
  public class lstAdditionalInterestTypesDataTable : 
    TypedTableBase<dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow>
  {
    private DataColumn columnInterestType;
    private DataColumn columnAdditionalInterest;
    private DataColumn columnisDisabled;
    private DataColumn columnIsNetrate;
    private DataColumn columnisSelected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstAdditionalInterestTypesDataTable()
    {
      this.TableName = "lstAdditionalInterestTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstAdditionalInterestTypesDataTable(DataTable table)
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
    protected lstAdditionalInterestTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InterestTypeColumn => this.columnInterestType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AdditionalInterestColumn => this.columnAdditionalInterest;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn isDisabledColumn => this.columnisDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IsNetrateColumn => this.columnIsNetrate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn isSelectedColumn => this.columnisSelected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow this[int index]
    {
      get => (dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRowChangeEventHandler lstAdditionalInterestTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRowChangeEventHandler lstAdditionalInterestTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRowChangeEventHandler lstAdditionalInterestTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRowChangeEventHandler lstAdditionalInterestTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstAdditionalInterestTypesRow(
      dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow AddlstAdditionalInterestTypesRow(
      string InterestType,
      string AdditionalInterest,
      bool isDisabled,
      bool IsNetrate,
      bool isSelected)
    {
      dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow row = (dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) InterestType,
        (object) AdditionalInterest,
        (object) isDisabled,
        (object) IsNetrate,
        (object) isSelected
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow FindByInterestType(
      string InterestType)
    {
      return (dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow) this.Rows.Find(new object[1]
      {
        (object) InterestType
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesDataTable interestTypesDataTable = (dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesDataTable) base.Clone();
      interestTypesDataTable.InitVars();
      return (DataTable) interestTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnInterestType = this.Columns["InterestType"];
      this.columnAdditionalInterest = this.Columns["AdditionalInterest"];
      this.columnisDisabled = this.Columns["isDisabled"];
      this.columnIsNetrate = this.Columns["IsNetrate"];
      this.columnisSelected = this.Columns["isSelected"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnInterestType = new DataColumn("InterestType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInterestType);
      this.columnAdditionalInterest = new DataColumn("AdditionalInterest", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalInterest);
      this.columnisDisabled = new DataColumn("isDisabled", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnisDisabled);
      this.columnIsNetrate = new DataColumn("IsNetrate", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsNetrate);
      this.columnisSelected = new DataColumn("isSelected", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnisSelected);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnInterestType
      }, true));
      this.columnInterestType.AllowDBNull = false;
      this.columnInterestType.Unique = true;
      this.columnAdditionalInterest.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow NewlstAdditionalInterestTypesRow()
    {
      return (dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdditionalInterestTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRowChangeEventHandler typesRowChangedEvent = this.lstAdditionalInterestTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdditionalInterestTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRowChangeEventHandler rowChangingEvent = this.lstAdditionalInterestTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdditionalInterestTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRowChangeEventHandler typesRowDeletedEvent = this.lstAdditionalInterestTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdditionalInterestTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRowChangeEventHandler rowDeletingEvent = this.lstAdditionalInterestTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstAdditionalInterestTypesRow(
      dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyFormsConditionsWarranties conditionsWarranties = new dsCompanyFormsConditionsWarranties();
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
        FixedValue = conditionsWarranties.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstAdditionalInterestTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = conditionsWarranties.GetSchemaSerializable();
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
  public class tblCompanyInterestFormsDataTable : 
    TypedTableBase<dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow>
  {
    private DataColumn columnCompany_FCW_ID;
    private DataColumn columnInterestType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyInterestFormsDataTable()
    {
      this.TableName = "tblCompanyInterestForms";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyInterestFormsDataTable(DataTable table)
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
    protected tblCompanyInterestFormsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Company_FCW_IDColumn => this.columnCompany_FCW_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InterestTypeColumn => this.columnInterestType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow this[int index]
    {
      get => (dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRowChangeEventHandler tblCompanyInterestFormsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRowChangeEventHandler tblCompanyInterestFormsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRowChangeEventHandler tblCompanyInterestFormsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRowChangeEventHandler tblCompanyInterestFormsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyInterestFormsRow(
      dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow AddtblCompanyInterestFormsRow(
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow parenttblCompanyFormsConditionsWarrantiesRowByFK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms,
      dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow parentlstAdditionalInterestTypesRowByFK_lstAdditionalInterestTypes_tblCompanyInterestForms)
    {
      dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow row = (dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow) this.NewRow();
      object[] objArray = new object[2];
      if (parenttblCompanyFormsConditionsWarrantiesRowByFK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblCompanyFormsConditionsWarrantiesRowByFK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms[0]);
      if (parentlstAdditionalInterestTypesRowByFK_lstAdditionalInterestTypes_tblCompanyInterestForms != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstAdditionalInterestTypesRowByFK_lstAdditionalInterestTypes_tblCompanyInterestForms[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow FindByCompany_FCW_IDInterestType(
      int Company_FCW_ID,
      string InterestType)
    {
      return (dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow) this.Rows.Find(new object[2]
      {
        (object) Company_FCW_ID,
        (object) InterestType
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsDataTable interestFormsDataTable = (dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsDataTable) base.Clone();
      interestFormsDataTable.InitVars();
      return (DataTable) interestFormsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompany_FCW_ID = this.Columns["Company_FCW_ID"];
      this.columnInterestType = this.Columns["InterestType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompany_FCW_ID = new DataColumn("Company_FCW_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany_FCW_ID);
      this.columnInterestType = new DataColumn("InterestType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInterestType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnCompany_FCW_ID,
        this.columnInterestType
      }, true));
      this.columnCompany_FCW_ID.AllowDBNull = false;
      this.columnInterestType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow NewtblCompanyInterestFormsRow()
    {
      return (dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyInterestFormsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRowChangeEventHandler formsRowChangedEvent = this.tblCompanyInterestFormsRowChangedEvent;
      if (formsRowChangedEvent == null)
        return;
      formsRowChangedEvent((object) this, new dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRowChangeEvent((dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyInterestFormsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRowChangeEventHandler rowChangingEvent = this.tblCompanyInterestFormsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRowChangeEvent((dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyInterestFormsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRowChangeEventHandler formsRowDeletedEvent = this.tblCompanyInterestFormsRowDeletedEvent;
      if (formsRowDeletedEvent == null)
        return;
      formsRowDeletedEvent((object) this, new dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRowChangeEvent((dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyInterestFormsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRowChangeEventHandler rowDeletingEvent = this.tblCompanyInterestFormsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRowChangeEvent((dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyInterestFormsRow(
      dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyFormsConditionsWarranties conditionsWarranties = new dsCompanyFormsConditionsWarranties();
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
        FixedValue = conditionsWarranties.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyInterestFormsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = conditionsWarranties.GetSchemaSerializable();
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
  public class lstNoteTypesDataTable : 
    TypedTableBase<dsCompanyFormsConditionsWarranties.lstNoteTypesRow>
  {
    private DataColumn columnNoteTypeID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstNoteTypesDataTable()
    {
      this.TableName = "lstNoteTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstNoteTypesDataTable(DataTable table)
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
    protected lstNoteTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NoteTypeIDColumn => this.columnNoteTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstNoteTypesRow this[int index]
    {
      get => (dsCompanyFormsConditionsWarranties.lstNoteTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstNoteTypesRowChangeEventHandler lstNoteTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstNoteTypesRowChangeEventHandler lstNoteTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstNoteTypesRowChangeEventHandler lstNoteTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstNoteTypesRowChangeEventHandler lstNoteTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstNoteTypesRow(
      dsCompanyFormsConditionsWarranties.lstNoteTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstNoteTypesRow AddlstNoteTypesRow(string Description)
    {
      dsCompanyFormsConditionsWarranties.lstNoteTypesRow row = (dsCompanyFormsConditionsWarranties.lstNoteTypesRow) this.NewRow();
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
    public dsCompanyFormsConditionsWarranties.lstNoteTypesRow FindByNoteTypeID(int NoteTypeID)
    {
      return (dsCompanyFormsConditionsWarranties.lstNoteTypesRow) this.Rows.Find(new object[1]
      {
        (object) NoteTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyFormsConditionsWarranties.lstNoteTypesDataTable noteTypesDataTable = (dsCompanyFormsConditionsWarranties.lstNoteTypesDataTable) base.Clone();
      noteTypesDataTable.InitVars();
      return (DataTable) noteTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyFormsConditionsWarranties.lstNoteTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnNoteTypeID = this.Columns["NoteTypeID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnNoteTypeID = new DataColumn("NoteTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteTypeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnNoteTypeID
      }, true));
      this.columnNoteTypeID.AutoIncrement = true;
      this.columnNoteTypeID.AllowDBNull = false;
      this.columnNoteTypeID.ReadOnly = true;
      this.columnNoteTypeID.Unique = true;
      this.columnDescription.AllowDBNull = false;
      this.columnDescription.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstNoteTypesRow NewlstNoteTypesRow()
    {
      return (dsCompanyFormsConditionsWarranties.lstNoteTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyFormsConditionsWarranties.lstNoteTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyFormsConditionsWarranties.lstNoteTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstNoteTypesRowChangeEventHandler typesRowChangedEvent = this.lstNoteTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompanyFormsConditionsWarranties.lstNoteTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.lstNoteTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstNoteTypesRowChangeEventHandler rowChangingEvent = this.lstNoteTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyFormsConditionsWarranties.lstNoteTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.lstNoteTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstNoteTypesRowChangeEventHandler typesRowDeletedEvent = this.lstNoteTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompanyFormsConditionsWarranties.lstNoteTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.lstNoteTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstNoteTypesRowChangeEventHandler rowDeletingEvent = this.lstNoteTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyFormsConditionsWarranties.lstNoteTypesRowChangeEvent((dsCompanyFormsConditionsWarranties.lstNoteTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstNoteTypesRow(
      dsCompanyFormsConditionsWarranties.lstNoteTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyFormsConditionsWarranties conditionsWarranties = new dsCompanyFormsConditionsWarranties();
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
        FixedValue = conditionsWarranties.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstNoteTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = conditionsWarranties.GetSchemaSerializable();
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
    TypedTableBase<dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow>
  {
    private DataColumn columnWarrantyID;
    private DataColumn columnCompany_FCW_ID;

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
    public DataColumn Company_FCW_IDColumn => this.columnCompany_FCW_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow this[int index]
    {
      get => (dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRowChangeEventHandler tblWarrantiesAssociatedFormsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRowChangeEventHandler tblWarrantiesAssociatedFormsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRowChangeEventHandler tblWarrantiesAssociatedFormsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRowChangeEventHandler tblWarrantiesAssociatedFormsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblWarrantiesAssociatedFormsRow(
      dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow AddtblWarrantiesAssociatedFormsRow(
      int WarrantyID,
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow parenttblCompanyFormsConditionsWarrantiesRowBytblCompanyFormsConditionsWarranties_tblWarrantiesAssociatedForms)
    {
      dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow row = (dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) WarrantyID,
        null
      };
      if (parenttblCompanyFormsConditionsWarrantiesRowBytblCompanyFormsConditionsWarranties_tblWarrantiesAssociatedForms != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblCompanyFormsConditionsWarrantiesRowBytblCompanyFormsConditionsWarranties_tblWarrantiesAssociatedForms[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow FindByWarrantyIDCompany_FCW_ID(
      int WarrantyID,
      int Company_FCW_ID)
    {
      return (dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow) this.Rows.Find(new object[2]
      {
        (object) WarrantyID,
        (object) Company_FCW_ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsDataTable associatedFormsDataTable = (dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsDataTable) base.Clone();
      associatedFormsDataTable.InitVars();
      return (DataTable) associatedFormsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnWarrantyID = this.Columns["WarrantyID"];
      this.columnCompany_FCW_ID = this.Columns["Company_FCW_ID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnWarrantyID = new DataColumn("WarrantyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWarrantyID);
      this.columnCompany_FCW_ID = new DataColumn("Company_FCW_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany_FCW_ID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnWarrantyID,
        this.columnCompany_FCW_ID
      }, true));
      this.columnWarrantyID.AllowDBNull = false;
      this.columnCompany_FCW_ID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow NewtblWarrantiesAssociatedFormsRow()
    {
      return (dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblWarrantiesAssociatedFormsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRowChangeEventHandler formsRowChangedEvent = this.tblWarrantiesAssociatedFormsRowChangedEvent;
      if (formsRowChangedEvent == null)
        return;
      formsRowChangedEvent((object) this, new dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRowChangeEvent((dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow) e.Row, e.Action));
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
      dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRowChangeEventHandler rowChangingEvent = this.tblWarrantiesAssociatedFormsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRowChangeEvent((dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow) e.Row, e.Action));
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
      dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRowChangeEventHandler formsRowDeletedEvent = this.tblWarrantiesAssociatedFormsRowDeletedEvent;
      if (formsRowDeletedEvent == null)
        return;
      formsRowDeletedEvent((object) this, new dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRowChangeEvent((dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow) e.Row, e.Action));
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
      dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRowChangeEventHandler rowDeletingEvent = this.tblWarrantiesAssociatedFormsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRowChangeEvent((dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblWarrantiesAssociatedFormsRow(
      dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyFormsConditionsWarranties conditionsWarranties = new dsCompanyFormsConditionsWarranties();
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
        FixedValue = conditionsWarranties.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblWarrantiesAssociatedFormsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = conditionsWarranties.GetSchemaSerializable();
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
  public class lstFCWConditionTypeDataTable : 
    TypedTableBase<dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow>
  {
    private DataColumn columnID;
    private DataColumn columnConditionTypeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstFCWConditionTypeDataTable()
    {
      this.TableName = "lstFCWConditionType";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstFCWConditionTypeDataTable(DataTable table)
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
    protected lstFCWConditionTypeDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ConditionTypeNameColumn => this.columnConditionTypeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow this[int index]
    {
      get => (dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRowChangeEventHandler lstFCWConditionTypeRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRowChangeEventHandler lstFCWConditionTypeRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRowChangeEventHandler lstFCWConditionTypeRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRowChangeEventHandler lstFCWConditionTypeRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstFCWConditionTypeRow(
      dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow AddlstFCWConditionTypeRow(
      string ConditionTypeName)
    {
      dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow row = (dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) ConditionTypeName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow FindByID(int ID)
    {
      return (dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyFormsConditionsWarranties.lstFCWConditionTypeDataTable conditionTypeDataTable = (dsCompanyFormsConditionsWarranties.lstFCWConditionTypeDataTable) base.Clone();
      conditionTypeDataTable.InitVars();
      return (DataTable) conditionTypeDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyFormsConditionsWarranties.lstFCWConditionTypeDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnConditionTypeName = this.Columns["ConditionTypeName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnConditionTypeName = new DataColumn("ConditionTypeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConditionTypeName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AutoIncrementSeed = -1L;
      this.columnID.AutoIncrementStep = -1L;
      this.columnID.AllowDBNull = false;
      this.columnID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow NewlstFCWConditionTypeRow()
    {
      return (dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFCWConditionTypeRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRowChangeEventHandler typeRowChangedEvent = this.lstFCWConditionTypeRowChangedEvent;
      if (typeRowChangedEvent == null)
        return;
      typeRowChangedEvent((object) this, new dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRowChangeEvent((dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFCWConditionTypeRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRowChangeEventHandler rowChangingEvent = this.lstFCWConditionTypeRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRowChangeEvent((dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFCWConditionTypeRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRowChangeEventHandler typeRowDeletedEvent = this.lstFCWConditionTypeRowDeletedEvent;
      if (typeRowDeletedEvent == null)
        return;
      typeRowDeletedEvent((object) this, new dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRowChangeEvent((dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFCWConditionTypeRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRowChangeEventHandler rowDeletingEvent = this.lstFCWConditionTypeRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRowChangeEvent((dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstFCWConditionTypeRow(
      dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyFormsConditionsWarranties conditionsWarranties = new dsCompanyFormsConditionsWarranties();
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
        FixedValue = conditionsWarranties.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstFCWConditionTypeDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = conditionsWarranties.GetSchemaSerializable();
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

  public class tblCompanyFormsConditionsWarrantiesRow : DataRow
  {
    private dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable tabletblCompanyFormsConditionsWarranties;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyFormsConditionsWarrantiesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyFormsConditionsWarranties = (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Company_FCW_ID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyFormsConditionsWarranties.Company_FCW_IDColumn]);
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.Company_FCW_IDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CompanyLineID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyFormsConditionsWarranties.CompanyLineIDColumn]);
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.CompanyLineIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyFormID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyFormsConditionsWarranties.PolicyFormIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyFormID' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.PolicyFormIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ConditionID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyFormsConditionsWarranties.ConditionIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConditionID' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.ConditionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int WarrantyID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyFormsConditionsWarranties.WarrantyIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WarrantyID' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.WarrantyIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool CheckedByDefault
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyFormsConditionsWarranties.CheckedByDefaultColumn]);
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.CheckedByDefaultColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ShowOnQuote
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyFormsConditionsWarranties.ShowOnQuoteColumn]);
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.ShowOnQuoteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FormName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyFormsConditionsWarranties.FormNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FormName' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.FormNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Condition
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyFormsConditionsWarranties.ConditionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Condition' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.ConditionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string WarrantyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyFormsConditionsWarranties.WarrantyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WarrantyName' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.WarrantyNameColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FormNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyFormsConditionsWarranties.FormNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FormNumber' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.FormNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime Effective
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblCompanyFormsConditionsWarranties.EffectiveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Effective' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.EffectiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime Disabled
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblCompanyFormsConditionsWarranties.DisabledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Disabled' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.DisabledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool GenerateDiary
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyFormsConditionsWarranties.GenerateDiaryColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GenerateDiary' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.GenerateDiaryColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string OncePer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyFormsConditionsWarranties.OncePerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OncePer' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.OncePerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int NoteTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyFormsConditionsWarranties.NoteTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoteTypeID' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.NoteTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IncludeWithQuotation
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyFormsConditionsWarranties.IncludeWithQuotationColumn]);
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.IncludeWithQuotationColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool SelectPolicyForm
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyFormsConditionsWarranties.SelectPolicyFormColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SelectPolicyForm' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.SelectPolicyFormColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool GenerateQuoteDiary
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyFormsConditionsWarranties.GenerateQuoteDiaryColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GenerateQuoteDiary' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.GenerateQuoteDiaryColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime AddedDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblCompanyFormsConditionsWarranties.AddedDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddedDate' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.AddedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string IncludeWithBinder
    {
      get
      {
        return Conversions.ToString(this[this.tabletblCompanyFormsConditionsWarranties.IncludeWithBinderColumn]);
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.IncludeWithBinderColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool SelectCondition
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyFormsConditionsWarranties.SelectConditionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SelectCondition' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.SelectConditionColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool CommonToPackage
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyFormsConditionsWarranties.CommonToPackageColumn]);
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.CommonToPackageColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Mandatory
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyFormsConditionsWarranties.MandatoryColumn]);
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.MandatoryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool SelectWarranty
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyFormsConditionsWarranties.SelectWarrantyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SelectWarranty' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.SelectWarrantyColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EditionDate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyFormsConditionsWarranties.EditionDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EditionDate' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.EditionDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyFormsConditionsWarranties.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string UserName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyFormsConditionsWarranties.UserNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserName' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.UserNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid UserGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyFormsConditionsWarranties.UserGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserGUID' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.UserGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool HasRaterConditional
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyFormsConditionsWarranties.HasRaterConditionalColumn]);
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.HasRaterConditionalColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ConditionTypeNameID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyFormsConditionsWarranties.ConditionTypeNameIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConditionTypeNameID' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.ConditionTypeNameIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool BinderWatermark
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyFormsConditionsWarranties.BinderWatermarkColumn]);
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.BinderWatermarkColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IncludeWithIndication
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyFormsConditionsWarranties.IncludeWithIndicationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IncludeWithIndication' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.IncludeWithIndicationColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool AppliedToQuotes
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyFormsConditionsWarranties.AppliedToQuotesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AppliedToQuotes' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.AppliedToQuotesColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyFormIDNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.PolicyFormIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyFormIDNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.PolicyFormIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsConditionIDNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.ConditionIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetConditionIDNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.ConditionIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsWarrantyIDNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.WarrantyIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetWarrantyIDNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.WarrantyIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFormNameNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.FormNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFormNameNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.FormNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsConditionNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.ConditionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetConditionNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.ConditionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsWarrantyNameNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.WarrantyNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetWarrantyNameNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.WarrantyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFormNumberNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.FormNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFormNumberNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.FormNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEffectiveNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.EffectiveColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEffectiveNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.EffectiveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDisabledNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.DisabledColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDisabledNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.DisabledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGenerateDiaryNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.GenerateDiaryColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGenerateDiaryNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.GenerateDiaryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOncePerNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.OncePerColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOncePerNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.OncePerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNoteTypeIDNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.NoteTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNoteTypeIDNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.NoteTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSelectPolicyFormNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.SelectPolicyFormColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSelectPolicyFormNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.SelectPolicyFormColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGenerateQuoteDiaryNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.GenerateQuoteDiaryColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGenerateQuoteDiaryNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.GenerateQuoteDiaryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddedDateNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.AddedDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddedDateNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.AddedDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSelectConditionNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.SelectConditionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSelectConditionNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.SelectConditionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSelectWarrantyNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.SelectWarrantyColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSelectWarrantyNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.SelectWarrantyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEditionDateNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.EditionDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEditionDateNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.EditionDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDescriptionNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.DescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUserNameNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.UserNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUserNameNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUserGUIDNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.UserGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUserGUIDNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.UserGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsConditionTypeNameIDNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.ConditionTypeNameIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetConditionTypeNameIDNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.ConditionTypeNameIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsIncludeWithIndicationNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.IncludeWithIndicationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetIncludeWithIndicationNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.IncludeWithIndicationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAppliedToQuotesNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.AppliedToQuotesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAppliedToQuotesNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.AppliedToQuotesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow[] GettblCompanyInterestFormsRows()
    {
      return this.Table.ChildRelations["FK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms"] != null ? (dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow[]) this.GetChildRows(this.Table.ChildRelations["FK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms"]) : new dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow[] GettblCompanyFormsConditionsWarranties_PrintTypesRows()
    {
      return this.Table.ChildRelations["tblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes"] != null ? (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes"]) : new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow[] GettblWarrantiesAssociatedFormsRows()
    {
      return this.Table.ChildRelations["tblCompanyFormsConditionsWarranties_tblWarrantiesAssociatedForms"] != null ? (dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompanyFormsConditionsWarranties_tblWarrantiesAssociatedForms"]) : new dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow[0];
    }
  }

  public class tblCompanyFormsConditionsWarranties_PrintTypesRow : DataRow
  {
    private dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesDataTable tabletblCompanyFormsConditionsWarranties_PrintTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyFormsConditionsWarranties_PrintTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyFormsConditionsWarranties_PrintTypes = (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Company_FCW_ID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyFormsConditionsWarranties_PrintTypes.Company_FCW_IDColumn]);
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties_PrintTypes.Company_FCW_IDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PrintTypeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyFormsConditionsWarranties_PrintTypes.PrintTypeIDColumn]);
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties_PrintTypes.PrintTypeIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow tblCompanyFormsConditionsWarrantiesRow
    {
      get
      {
        return (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow) this.GetParentRow(this.Table.ParentRelations["tblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompanyFormsConditionsWarrantiestblCompanyFormsConditionsWarranties_PrintTypes"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow lstPolicyPrintTypesRow
    {
      get
      {
        return (dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow) this.GetParentRow(this.Table.ParentRelations["lstPolicyPrintTypestblCompanyFormsConditionsWarranties_PrintTypes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstPolicyPrintTypestblCompanyFormsConditionsWarranties_PrintTypes"]);
      }
    }
  }

  public class lstPolicyPrintTypesRow : DataRow
  {
    private dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesDataTable tablelstPolicyPrintTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstPolicyPrintTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPolicyPrintTypes = (dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PrintTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstPolicyPrintTypes.PrintTypeIDColumn]);
      set => this[this.tablelstPolicyPrintTypes.PrintTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PrintType
    {
      get => Conversions.ToString(this[this.tablelstPolicyPrintTypes.PrintTypeColumn]);
      set => this[this.tablelstPolicyPrintTypes.PrintTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow[] GettblCompanyFormsConditionsWarranties_PrintTypesRows()
    {
      return this.Table.ChildRelations["lstPolicyPrintTypestblCompanyFormsConditionsWarranties_PrintTypes"] != null ? (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow[]) this.GetChildRows(this.Table.ChildRelations["lstPolicyPrintTypestblCompanyFormsConditionsWarranties_PrintTypes"]) : new dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow[0];
    }
  }

  public class lstAdditionalInterestTypesRow : DataRow
  {
    private dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesDataTable tablelstAdditionalInterestTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstAdditionalInterestTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstAdditionalInterestTypes = (dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InterestType
    {
      get => Conversions.ToString(this[this.tablelstAdditionalInterestTypes.InterestTypeColumn]);
      set => this[this.tablelstAdditionalInterestTypes.InterestTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AdditionalInterest
    {
      get
      {
        return Conversions.ToString(this[this.tablelstAdditionalInterestTypes.AdditionalInterestColumn]);
      }
      set => this[this.tablelstAdditionalInterestTypes.AdditionalInterestColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool isDisabled
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstAdditionalInterestTypes.isDisabledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'isDisabled' in table 'lstAdditionalInterestTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstAdditionalInterestTypes.isDisabledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNetrate
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstAdditionalInterestTypes.IsNetrateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IsNetrate' in table 'lstAdditionalInterestTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstAdditionalInterestTypes.IsNetrateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool isSelected
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstAdditionalInterestTypes.isSelectedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'isSelected' in table 'lstAdditionalInterestTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstAdditionalInterestTypes.isSelectedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsisDisabledNull()
    {
      return this.IsNull(this.tablelstAdditionalInterestTypes.isDisabledColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetisDisabledNull()
    {
      this[this.tablelstAdditionalInterestTypes.isDisabledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsIsNetrateNull()
    {
      return this.IsNull(this.tablelstAdditionalInterestTypes.IsNetrateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetIsNetrateNull()
    {
      this[this.tablelstAdditionalInterestTypes.IsNetrateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsisSelectedNull()
    {
      return this.IsNull(this.tablelstAdditionalInterestTypes.isSelectedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetisSelectedNull()
    {
      this[this.tablelstAdditionalInterestTypes.isSelectedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow[] GettblCompanyInterestFormsRows()
    {
      return this.Table.ChildRelations["FK_lstAdditionalInterestTypes_tblCompanyInterestForms"] != null ? (dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow[]) this.GetChildRows(this.Table.ChildRelations["FK_lstAdditionalInterestTypes_tblCompanyInterestForms"]) : new dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow[0];
    }
  }

  public class tblCompanyInterestFormsRow : DataRow
  {
    private dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsDataTable tabletblCompanyInterestForms;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyInterestFormsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyInterestForms = (dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Company_FCW_ID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyInterestForms.Company_FCW_IDColumn]);
      set => this[this.tabletblCompanyInterestForms.Company_FCW_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InterestType
    {
      get => Conversions.ToString(this[this.tabletblCompanyInterestForms.InterestTypeColumn]);
      set => this[this.tabletblCompanyInterestForms.InterestTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow tblCompanyFormsConditionsWarrantiesRow
    {
      get
      {
        return (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow) this.GetParentRow(this.Table.ParentRelations["FK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["FK_tblCompanyFormsConditionsWarranties_tblCompanyInterestForms"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow lstAdditionalInterestTypesRow
    {
      get
      {
        return (dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow) this.GetParentRow(this.Table.ParentRelations["FK_lstAdditionalInterestTypes_tblCompanyInterestForms"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["FK_lstAdditionalInterestTypes_tblCompanyInterestForms"]);
      }
    }
  }

  public class lstNoteTypesRow : DataRow
  {
    private dsCompanyFormsConditionsWarranties.lstNoteTypesDataTable tablelstNoteTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstNoteTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstNoteTypes = (dsCompanyFormsConditionsWarranties.lstNoteTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int NoteTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstNoteTypes.NoteTypeIDColumn]);
      set => this[this.tablelstNoteTypes.NoteTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstNoteTypes.DescriptionColumn]);
      set => this[this.tablelstNoteTypes.DescriptionColumn] = (object) value;
    }
  }

  public class tblWarrantiesAssociatedFormsRow : DataRow
  {
    private dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsDataTable tabletblWarrantiesAssociatedForms;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblWarrantiesAssociatedFormsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblWarrantiesAssociatedForms = (dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsDataTable) this.Table;
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
    public int Company_FCW_ID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblWarrantiesAssociatedForms.Company_FCW_IDColumn]);
      }
      set => this[this.tabletblWarrantiesAssociatedForms.Company_FCW_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow tblCompanyFormsConditionsWarrantiesRow
    {
      get
      {
        return (dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow) this.GetParentRow(this.Table.ParentRelations["tblCompanyFormsConditionsWarranties_tblWarrantiesAssociatedForms"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompanyFormsConditionsWarranties_tblWarrantiesAssociatedForms"]);
      }
    }
  }

  public class lstFCWConditionTypeRow : DataRow
  {
    private dsCompanyFormsConditionsWarranties.lstFCWConditionTypeDataTable tablelstFCWConditionType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstFCWConditionTypeRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstFCWConditionType = (dsCompanyFormsConditionsWarranties.lstFCWConditionTypeDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstFCWConditionType.IDColumn]);
      set => this[this.tablelstFCWConditionType.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ConditionTypeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstFCWConditionType.ConditionTypeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConditionTypeName' in table 'lstFCWConditionType' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstFCWConditionType.ConditionTypeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsConditionTypeNameNull()
    {
      return this.IsNull(this.tablelstFCWConditionType.ConditionTypeNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetConditionTypeNameNull()
    {
      this[this.tablelstFCWConditionType.ConditionTypeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyFormsConditionsWarrantiesRowChangeEvent : EventArgs
  {
    private dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyFormsConditionsWarrantiesRowChangeEvent(
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow Row
    {
      get => this.eventRow;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEvent : EventArgs
  {
    private dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyFormsConditionsWarranties_PrintTypesRowChangeEvent(
      dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarranties_PrintTypesRow Row
    {
      get => this.eventRow;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstPolicyPrintTypesRowChangeEvent : EventArgs
  {
    private dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstPolicyPrintTypesRowChangeEvent(
      dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstPolicyPrintTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstAdditionalInterestTypesRowChangeEvent : EventArgs
  {
    private dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstAdditionalInterestTypesRowChangeEvent(
      dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstAdditionalInterestTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyInterestFormsRowChangeEvent : EventArgs
  {
    private dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyInterestFormsRowChangeEvent(
      dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblCompanyInterestFormsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstNoteTypesRowChangeEvent : EventArgs
  {
    private dsCompanyFormsConditionsWarranties.lstNoteTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstNoteTypesRowChangeEvent(
      dsCompanyFormsConditionsWarranties.lstNoteTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstNoteTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblWarrantiesAssociatedFormsRowChangeEvent : EventArgs
  {
    private dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblWarrantiesAssociatedFormsRowChangeEvent(
      dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.tblWarrantiesAssociatedFormsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstFCWConditionTypeRowChangeEvent : EventArgs
  {
    private dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstFCWConditionTypeRowChangeEvent(
      dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsConditionsWarranties.lstFCWConditionTypeRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
