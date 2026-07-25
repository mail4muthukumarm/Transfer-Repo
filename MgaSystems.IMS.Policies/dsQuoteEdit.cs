// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsQuoteEdit
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
namespace MGASystems.IMS.Policies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsQuoteEdit")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsQuoteEdit : DataSet
{
  private dsQuoteEdit.lstLinesDataTable tablelstLines;
  private dsQuoteEdit.lstPolicyTypesDataTable tablelstPolicyTypes;
  private dsQuoteEdit.tblClientOfficesDataTable tabletblClientOffices;
  private dsQuoteEdit.tblCompanyContactsDataTable tabletblCompanyContacts;
  private dsQuoteEdit.tblProducerContactsDataTable tabletblProducerContacts;
  private dsQuoteEdit.tblQuotesDataTable tabletblQuotes;
  private dsQuoteEdit.lstStatesDataTable tablelstStates;
  private dsQuoteEdit.tblUsersDataTable tabletblUsers;
  private dsQuoteEdit.tblCompanyLocationsDataTable tabletblCompanyLocations;
  private dsQuoteEdit.tblCompanyLinesDataTable tabletblCompanyLines;
  private dsQuoteEdit.tblQuoteDetailsDataTable tabletblQuoteDetails;
  private dsQuoteEdit.lstBillingTypesDataTable tablelstBillingTypes;
  private dsQuoteEdit.tblFactorSetsDataTable tabletblFactorSets;
  private dsQuoteEdit.TAsDataTable tableTAs;
  private dsQuoteEdit.FinanceCompaniesDataTable tableFinanceCompanies;
  private dsQuoteEdit.tblIntermediaryContactsDataTable tabletblIntermediaryContacts;
  private dsQuoteEdit.tblFin_ExpensePayeesDataTable tabletblFin_ExpensePayees;
  private dsQuoteEdit.lstSIC_CodesDataTable tablelstSIC_Codes;
  private dsQuoteEdit.lstEarnedPremiumTypeDataTable tablelstEarnedPremiumType;
  private dsQuoteEdit.ExpiringCarriersDataTable tableExpiringCarriers;
  private dsQuoteEdit.tblQuotes2DataTable tabletblQuotes2;
  private dsQuoteEdit.AssistantsDataTable tableAssistants;
  private dsQuoteEdit.tblCompanyProgramCodesDataTable tabletblCompanyProgramCodes;
  private dsQuoteEdit.lstNAICSCodesDataTable tablelstNAICSCodes;
  private dsQuoteEdit.dtIssuingOfficeDataTable tabledtIssuingOffice;
  private dsQuoteEdit.dtRetailerContactsDataTable tabledtRetailerContacts;
  private DataRelation relationlstSIC_CodestblQuotes;
  private DataRelation relationtblInspectionCompaniestblQuotes;
  private DataRelation relationFinanceCompaniestblQuotes;
  private DataRelation relationtblQuotestblQuoteDetails;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsQuoteEdit()
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
  protected dsQuoteEdit(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstLines)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.lstLinesDataTable(dataSet.Tables[nameof (lstLines)]));
        if (dataSet.Tables[nameof (lstPolicyTypes)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.lstPolicyTypesDataTable(dataSet.Tables[nameof (lstPolicyTypes)]));
        if (dataSet.Tables[nameof (tblClientOffices)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.tblClientOfficesDataTable(dataSet.Tables[nameof (tblClientOffices)]));
        if (dataSet.Tables[nameof (tblCompanyContacts)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.tblCompanyContactsDataTable(dataSet.Tables[nameof (tblCompanyContacts)]));
        if (dataSet.Tables[nameof (tblProducerContacts)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.tblProducerContactsDataTable(dataSet.Tables[nameof (tblProducerContacts)]));
        if (dataSet.Tables[nameof (tblQuotes)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.tblQuotesDataTable(dataSet.Tables[nameof (tblQuotes)]));
        if (dataSet.Tables[nameof (lstStates)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.lstStatesDataTable(dataSet.Tables[nameof (lstStates)]));
        if (dataSet.Tables[nameof (tblUsers)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.tblUsersDataTable(dataSet.Tables[nameof (tblUsers)]));
        if (dataSet.Tables[nameof (tblCompanyLocations)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.tblCompanyLocationsDataTable(dataSet.Tables[nameof (tblCompanyLocations)]));
        if (dataSet.Tables[nameof (tblCompanyLines)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.tblCompanyLinesDataTable(dataSet.Tables[nameof (tblCompanyLines)]));
        if (dataSet.Tables[nameof (tblQuoteDetails)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.tblQuoteDetailsDataTable(dataSet.Tables[nameof (tblQuoteDetails)]));
        if (dataSet.Tables[nameof (lstBillingTypes)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.lstBillingTypesDataTable(dataSet.Tables[nameof (lstBillingTypes)]));
        if (dataSet.Tables[nameof (tblFactorSets)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.tblFactorSetsDataTable(dataSet.Tables[nameof (tblFactorSets)]));
        if (dataSet.Tables[nameof (TAs)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.TAsDataTable(dataSet.Tables[nameof (TAs)]));
        if (dataSet.Tables[nameof (FinanceCompanies)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.FinanceCompaniesDataTable(dataSet.Tables[nameof (FinanceCompanies)]));
        if (dataSet.Tables[nameof (tblIntermediaryContacts)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.tblIntermediaryContactsDataTable(dataSet.Tables[nameof (tblIntermediaryContacts)]));
        if (dataSet.Tables[nameof (tblFin_ExpensePayees)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.tblFin_ExpensePayeesDataTable(dataSet.Tables[nameof (tblFin_ExpensePayees)]));
        if (dataSet.Tables[nameof (lstSIC_Codes)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.lstSIC_CodesDataTable(dataSet.Tables[nameof (lstSIC_Codes)]));
        if (dataSet.Tables[nameof (lstEarnedPremiumType)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.lstEarnedPremiumTypeDataTable(dataSet.Tables[nameof (lstEarnedPremiumType)]));
        if (dataSet.Tables[nameof (ExpiringCarriers)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.ExpiringCarriersDataTable(dataSet.Tables[nameof (ExpiringCarriers)]));
        if (dataSet.Tables[nameof (tblQuotes2)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.tblQuotes2DataTable(dataSet.Tables[nameof (tblQuotes2)]));
        if (dataSet.Tables[nameof (Assistants)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.AssistantsDataTable(dataSet.Tables[nameof (Assistants)]));
        if (dataSet.Tables[nameof (tblCompanyProgramCodes)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.tblCompanyProgramCodesDataTable(dataSet.Tables[nameof (tblCompanyProgramCodes)]));
        if (dataSet.Tables[nameof (lstNAICSCodes)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.lstNAICSCodesDataTable(dataSet.Tables[nameof (lstNAICSCodes)]));
        if (dataSet.Tables[nameof (dtIssuingOffice)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.dtIssuingOfficeDataTable(dataSet.Tables[nameof (dtIssuingOffice)]));
        if (dataSet.Tables[nameof (dtRetailerContacts)] != null)
          base.Tables.Add((DataTable) new dsQuoteEdit.dtRetailerContactsDataTable(dataSet.Tables[nameof (dtRetailerContacts)]));
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
  public dsQuoteEdit.lstLinesDataTable lstLines => this.tablelstLines;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.lstPolicyTypesDataTable lstPolicyTypes => this.tablelstPolicyTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.tblClientOfficesDataTable tblClientOffices => this.tabletblClientOffices;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.tblCompanyContactsDataTable tblCompanyContacts => this.tabletblCompanyContacts;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.tblProducerContactsDataTable tblProducerContacts
  {
    get => this.tabletblProducerContacts;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.tblQuotesDataTable tblQuotes => this.tabletblQuotes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.lstStatesDataTable lstStates => this.tablelstStates;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.tblUsersDataTable tblUsers => this.tabletblUsers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.tblCompanyLocationsDataTable tblCompanyLocations
  {
    get => this.tabletblCompanyLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.tblCompanyLinesDataTable tblCompanyLines => this.tabletblCompanyLines;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.tblQuoteDetailsDataTable tblQuoteDetails => this.tabletblQuoteDetails;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.lstBillingTypesDataTable lstBillingTypes => this.tablelstBillingTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.tblFactorSetsDataTable tblFactorSets => this.tabletblFactorSets;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.TAsDataTable TAs => this.tableTAs;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.FinanceCompaniesDataTable FinanceCompanies => this.tableFinanceCompanies;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.tblIntermediaryContactsDataTable tblIntermediaryContacts
  {
    get => this.tabletblIntermediaryContacts;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.tblFin_ExpensePayeesDataTable tblFin_ExpensePayees
  {
    get => this.tabletblFin_ExpensePayees;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.lstSIC_CodesDataTable lstSIC_Codes => this.tablelstSIC_Codes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.lstEarnedPremiumTypeDataTable lstEarnedPremiumType
  {
    get => this.tablelstEarnedPremiumType;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.ExpiringCarriersDataTable ExpiringCarriers => this.tableExpiringCarriers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.tblQuotes2DataTable tblQuotes2 => this.tabletblQuotes2;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.AssistantsDataTable Assistants => this.tableAssistants;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.tblCompanyProgramCodesDataTable tblCompanyProgramCodes
  {
    get => this.tabletblCompanyProgramCodes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.lstNAICSCodesDataTable lstNAICSCodes => this.tablelstNAICSCodes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.dtIssuingOfficeDataTable dtIssuingOffice => this.tabledtIssuingOffice;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteEdit.dtRetailerContactsDataTable dtRetailerContacts => this.tabledtRetailerContacts;

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
    dsQuoteEdit dsQuoteEdit = (dsQuoteEdit) base.Clone();
    dsQuoteEdit.InitVars();
    dsQuoteEdit.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsQuoteEdit;
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
      if (dataSet.Tables["lstLines"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.lstLinesDataTable(dataSet.Tables["lstLines"]));
      if (dataSet.Tables["lstPolicyTypes"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.lstPolicyTypesDataTable(dataSet.Tables["lstPolicyTypes"]));
      if (dataSet.Tables["tblClientOffices"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.tblClientOfficesDataTable(dataSet.Tables["tblClientOffices"]));
      if (dataSet.Tables["tblCompanyContacts"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.tblCompanyContactsDataTable(dataSet.Tables["tblCompanyContacts"]));
      if (dataSet.Tables["tblProducerContacts"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.tblProducerContactsDataTable(dataSet.Tables["tblProducerContacts"]));
      if (dataSet.Tables["tblQuotes"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.tblQuotesDataTable(dataSet.Tables["tblQuotes"]));
      if (dataSet.Tables["lstStates"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.lstStatesDataTable(dataSet.Tables["lstStates"]));
      if (dataSet.Tables["tblUsers"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.tblUsersDataTable(dataSet.Tables["tblUsers"]));
      if (dataSet.Tables["tblCompanyLocations"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.tblCompanyLocationsDataTable(dataSet.Tables["tblCompanyLocations"]));
      if (dataSet.Tables["tblCompanyLines"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.tblCompanyLinesDataTable(dataSet.Tables["tblCompanyLines"]));
      if (dataSet.Tables["tblQuoteDetails"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.tblQuoteDetailsDataTable(dataSet.Tables["tblQuoteDetails"]));
      if (dataSet.Tables["lstBillingTypes"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.lstBillingTypesDataTable(dataSet.Tables["lstBillingTypes"]));
      if (dataSet.Tables["tblFactorSets"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.tblFactorSetsDataTable(dataSet.Tables["tblFactorSets"]));
      if (dataSet.Tables["TAs"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.TAsDataTable(dataSet.Tables["TAs"]));
      if (dataSet.Tables["FinanceCompanies"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.FinanceCompaniesDataTable(dataSet.Tables["FinanceCompanies"]));
      if (dataSet.Tables["tblIntermediaryContacts"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.tblIntermediaryContactsDataTable(dataSet.Tables["tblIntermediaryContacts"]));
      if (dataSet.Tables["tblFin_ExpensePayees"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.tblFin_ExpensePayeesDataTable(dataSet.Tables["tblFin_ExpensePayees"]));
      if (dataSet.Tables["lstSIC_Codes"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.lstSIC_CodesDataTable(dataSet.Tables["lstSIC_Codes"]));
      if (dataSet.Tables["lstEarnedPremiumType"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.lstEarnedPremiumTypeDataTable(dataSet.Tables["lstEarnedPremiumType"]));
      if (dataSet.Tables["ExpiringCarriers"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.ExpiringCarriersDataTable(dataSet.Tables["ExpiringCarriers"]));
      if (dataSet.Tables["tblQuotes2"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.tblQuotes2DataTable(dataSet.Tables["tblQuotes2"]));
      if (dataSet.Tables["Assistants"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.AssistantsDataTable(dataSet.Tables["Assistants"]));
      if (dataSet.Tables["tblCompanyProgramCodes"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.tblCompanyProgramCodesDataTable(dataSet.Tables["tblCompanyProgramCodes"]));
      if (dataSet.Tables["lstNAICSCodes"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.lstNAICSCodesDataTable(dataSet.Tables["lstNAICSCodes"]));
      if (dataSet.Tables["dtIssuingOffice"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.dtIssuingOfficeDataTable(dataSet.Tables["dtIssuingOffice"]));
      if (dataSet.Tables["dtRetailerContacts"] != null)
        base.Tables.Add((DataTable) new dsQuoteEdit.dtRetailerContactsDataTable(dataSet.Tables["dtRetailerContacts"]));
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
    this.tablelstLines = (dsQuoteEdit.lstLinesDataTable) base.Tables["lstLines"];
    if (initTable && this.tablelstLines != null)
      this.tablelstLines.InitVars();
    this.tablelstPolicyTypes = (dsQuoteEdit.lstPolicyTypesDataTable) base.Tables["lstPolicyTypes"];
    if (initTable && this.tablelstPolicyTypes != null)
      this.tablelstPolicyTypes.InitVars();
    this.tabletblClientOffices = (dsQuoteEdit.tblClientOfficesDataTable) base.Tables["tblClientOffices"];
    if (initTable && this.tabletblClientOffices != null)
      this.tabletblClientOffices.InitVars();
    this.tabletblCompanyContacts = (dsQuoteEdit.tblCompanyContactsDataTable) base.Tables["tblCompanyContacts"];
    if (initTable && this.tabletblCompanyContacts != null)
      this.tabletblCompanyContacts.InitVars();
    this.tabletblProducerContacts = (dsQuoteEdit.tblProducerContactsDataTable) base.Tables["tblProducerContacts"];
    if (initTable && this.tabletblProducerContacts != null)
      this.tabletblProducerContacts.InitVars();
    this.tabletblQuotes = (dsQuoteEdit.tblQuotesDataTable) base.Tables["tblQuotes"];
    if (initTable && this.tabletblQuotes != null)
      this.tabletblQuotes.InitVars();
    this.tablelstStates = (dsQuoteEdit.lstStatesDataTable) base.Tables["lstStates"];
    if (initTable && this.tablelstStates != null)
      this.tablelstStates.InitVars();
    this.tabletblUsers = (dsQuoteEdit.tblUsersDataTable) base.Tables["tblUsers"];
    if (initTable && this.tabletblUsers != null)
      this.tabletblUsers.InitVars();
    this.tabletblCompanyLocations = (dsQuoteEdit.tblCompanyLocationsDataTable) base.Tables["tblCompanyLocations"];
    if (initTable && this.tabletblCompanyLocations != null)
      this.tabletblCompanyLocations.InitVars();
    this.tabletblCompanyLines = (dsQuoteEdit.tblCompanyLinesDataTable) base.Tables["tblCompanyLines"];
    if (initTable && this.tabletblCompanyLines != null)
      this.tabletblCompanyLines.InitVars();
    this.tabletblQuoteDetails = (dsQuoteEdit.tblQuoteDetailsDataTable) base.Tables["tblQuoteDetails"];
    if (initTable && this.tabletblQuoteDetails != null)
      this.tabletblQuoteDetails.InitVars();
    this.tablelstBillingTypes = (dsQuoteEdit.lstBillingTypesDataTable) base.Tables["lstBillingTypes"];
    if (initTable && this.tablelstBillingTypes != null)
      this.tablelstBillingTypes.InitVars();
    this.tabletblFactorSets = (dsQuoteEdit.tblFactorSetsDataTable) base.Tables["tblFactorSets"];
    if (initTable && this.tabletblFactorSets != null)
      this.tabletblFactorSets.InitVars();
    this.tableTAs = (dsQuoteEdit.TAsDataTable) base.Tables["TAs"];
    if (initTable && this.tableTAs != null)
      this.tableTAs.InitVars();
    this.tableFinanceCompanies = (dsQuoteEdit.FinanceCompaniesDataTable) base.Tables["FinanceCompanies"];
    if (initTable && this.tableFinanceCompanies != null)
      this.tableFinanceCompanies.InitVars();
    this.tabletblIntermediaryContacts = (dsQuoteEdit.tblIntermediaryContactsDataTable) base.Tables["tblIntermediaryContacts"];
    if (initTable && this.tabletblIntermediaryContacts != null)
      this.tabletblIntermediaryContacts.InitVars();
    this.tabletblFin_ExpensePayees = (dsQuoteEdit.tblFin_ExpensePayeesDataTable) base.Tables["tblFin_ExpensePayees"];
    if (initTable && this.tabletblFin_ExpensePayees != null)
      this.tabletblFin_ExpensePayees.InitVars();
    this.tablelstSIC_Codes = (dsQuoteEdit.lstSIC_CodesDataTable) base.Tables["lstSIC_Codes"];
    if (initTable && this.tablelstSIC_Codes != null)
      this.tablelstSIC_Codes.InitVars();
    this.tablelstEarnedPremiumType = (dsQuoteEdit.lstEarnedPremiumTypeDataTable) base.Tables["lstEarnedPremiumType"];
    if (initTable && this.tablelstEarnedPremiumType != null)
      this.tablelstEarnedPremiumType.InitVars();
    this.tableExpiringCarriers = (dsQuoteEdit.ExpiringCarriersDataTable) base.Tables["ExpiringCarriers"];
    if (initTable && this.tableExpiringCarriers != null)
      this.tableExpiringCarriers.InitVars();
    this.tabletblQuotes2 = (dsQuoteEdit.tblQuotes2DataTable) base.Tables["tblQuotes2"];
    if (initTable && this.tabletblQuotes2 != null)
      this.tabletblQuotes2.InitVars();
    this.tableAssistants = (dsQuoteEdit.AssistantsDataTable) base.Tables["Assistants"];
    if (initTable && this.tableAssistants != null)
      this.tableAssistants.InitVars();
    this.tabletblCompanyProgramCodes = (dsQuoteEdit.tblCompanyProgramCodesDataTable) base.Tables["tblCompanyProgramCodes"];
    if (initTable && this.tabletblCompanyProgramCodes != null)
      this.tabletblCompanyProgramCodes.InitVars();
    this.tablelstNAICSCodes = (dsQuoteEdit.lstNAICSCodesDataTable) base.Tables["lstNAICSCodes"];
    if (initTable && this.tablelstNAICSCodes != null)
      this.tablelstNAICSCodes.InitVars();
    this.tabledtIssuingOffice = (dsQuoteEdit.dtIssuingOfficeDataTable) base.Tables["dtIssuingOffice"];
    if (initTable && this.tabledtIssuingOffice != null)
      this.tabledtIssuingOffice.InitVars();
    this.tabledtRetailerContacts = (dsQuoteEdit.dtRetailerContactsDataTable) base.Tables["dtRetailerContacts"];
    if (initTable && this.tabledtRetailerContacts != null)
      this.tabledtRetailerContacts.InitVars();
    this.relationlstSIC_CodestblQuotes = this.Relations["lstSIC_CodestblQuotes"];
    this.relationtblInspectionCompaniestblQuotes = this.Relations["tblInspectionCompaniestblQuotes"];
    this.relationFinanceCompaniestblQuotes = this.Relations["FinanceCompaniestblQuotes"];
    this.relationtblQuotestblQuoteDetails = this.Relations["tblQuotestblQuoteDetails"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsQuoteEdit);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsQuoteEdit.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstLines = new dsQuoteEdit.lstLinesDataTable();
    base.Tables.Add((DataTable) this.tablelstLines);
    this.tablelstPolicyTypes = new dsQuoteEdit.lstPolicyTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstPolicyTypes);
    this.tabletblClientOffices = new dsQuoteEdit.tblClientOfficesDataTable();
    base.Tables.Add((DataTable) this.tabletblClientOffices);
    this.tabletblCompanyContacts = new dsQuoteEdit.tblCompanyContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyContacts);
    this.tabletblProducerContacts = new dsQuoteEdit.tblProducerContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerContacts);
    this.tabletblQuotes = new dsQuoteEdit.tblQuotesDataTable();
    base.Tables.Add((DataTable) this.tabletblQuotes);
    this.tablelstStates = new dsQuoteEdit.lstStatesDataTable();
    base.Tables.Add((DataTable) this.tablelstStates);
    this.tabletblUsers = new dsQuoteEdit.tblUsersDataTable();
    base.Tables.Add((DataTable) this.tabletblUsers);
    this.tabletblCompanyLocations = new dsQuoteEdit.tblCompanyLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLocations);
    this.tabletblCompanyLines = new dsQuoteEdit.tblCompanyLinesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLines);
    this.tabletblQuoteDetails = new dsQuoteEdit.tblQuoteDetailsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteDetails);
    this.tablelstBillingTypes = new dsQuoteEdit.lstBillingTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstBillingTypes);
    this.tabletblFactorSets = new dsQuoteEdit.tblFactorSetsDataTable();
    base.Tables.Add((DataTable) this.tabletblFactorSets);
    this.tableTAs = new dsQuoteEdit.TAsDataTable();
    base.Tables.Add((DataTable) this.tableTAs);
    this.tableFinanceCompanies = new dsQuoteEdit.FinanceCompaniesDataTable();
    base.Tables.Add((DataTable) this.tableFinanceCompanies);
    this.tabletblIntermediaryContacts = new dsQuoteEdit.tblIntermediaryContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblIntermediaryContacts);
    this.tabletblFin_ExpensePayees = new dsQuoteEdit.tblFin_ExpensePayeesDataTable();
    base.Tables.Add((DataTable) this.tabletblFin_ExpensePayees);
    this.tablelstSIC_Codes = new dsQuoteEdit.lstSIC_CodesDataTable();
    base.Tables.Add((DataTable) this.tablelstSIC_Codes);
    this.tablelstEarnedPremiumType = new dsQuoteEdit.lstEarnedPremiumTypeDataTable();
    base.Tables.Add((DataTable) this.tablelstEarnedPremiumType);
    this.tableExpiringCarriers = new dsQuoteEdit.ExpiringCarriersDataTable();
    base.Tables.Add((DataTable) this.tableExpiringCarriers);
    this.tabletblQuotes2 = new dsQuoteEdit.tblQuotes2DataTable();
    base.Tables.Add((DataTable) this.tabletblQuotes2);
    this.tableAssistants = new dsQuoteEdit.AssistantsDataTable();
    base.Tables.Add((DataTable) this.tableAssistants);
    this.tabletblCompanyProgramCodes = new dsQuoteEdit.tblCompanyProgramCodesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyProgramCodes);
    this.tablelstNAICSCodes = new dsQuoteEdit.lstNAICSCodesDataTable();
    base.Tables.Add((DataTable) this.tablelstNAICSCodes);
    this.tabledtIssuingOffice = new dsQuoteEdit.dtIssuingOfficeDataTable();
    base.Tables.Add((DataTable) this.tabledtIssuingOffice);
    this.tabledtRetailerContacts = new dsQuoteEdit.dtRetailerContactsDataTable();
    base.Tables.Add((DataTable) this.tabledtRetailerContacts);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("lstSIC_CodestblQuotes", new DataColumn[1]
    {
      this.tablelstSIC_Codes.SIC_CodeColumn
    }, new DataColumn[1]
    {
      this.tabletblQuotes.SIC_CodeColumn
    });
    this.tabletblQuotes.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("tblInspectionCompaniestblQuotes", new DataColumn[1]
    {
      this.tabletblFin_ExpensePayees.PayeeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuotes.InspectionCompanyIDColumn
    });
    this.tabletblQuotes.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("FinanceCompaniestblQuotes", new DataColumn[1]
    {
      this.tableFinanceCompanies.PayeeGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblQuotes.FinanceCompanyGuidColumn
    });
    this.tabletblQuotes.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("tblQuotestblQuoteDetails", new DataColumn[1]
    {
      this.tabletblQuotes.QuoteGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteDetails.QuoteGuidColumn
    });
    this.tabletblQuoteDetails.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    this.relationlstSIC_CodestblQuotes = new DataRelation("lstSIC_CodestblQuotes", new DataColumn[1]
    {
      this.tablelstSIC_Codes.SIC_CodeColumn
    }, new DataColumn[1]
    {
      this.tabletblQuotes.SIC_CodeColumn
    }, false);
    this.Relations.Add(this.relationlstSIC_CodestblQuotes);
    this.relationtblInspectionCompaniestblQuotes = new DataRelation("tblInspectionCompaniestblQuotes", new DataColumn[1]
    {
      this.tabletblFin_ExpensePayees.PayeeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuotes.InspectionCompanyIDColumn
    }, false);
    this.Relations.Add(this.relationtblInspectionCompaniestblQuotes);
    this.relationFinanceCompaniestblQuotes = new DataRelation("FinanceCompaniestblQuotes", new DataColumn[1]
    {
      this.tableFinanceCompanies.PayeeGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblQuotes.FinanceCompanyGuidColumn
    }, false);
    this.Relations.Add(this.relationFinanceCompaniestblQuotes);
    this.relationtblQuotestblQuoteDetails = new DataRelation("tblQuotestblQuoteDetails", new DataColumn[1]
    {
      this.tabletblQuotes.QuoteGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteDetails.QuoteGuidColumn
    }, false);
    this.Relations.Add(this.relationtblQuotestblQuoteDetails);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstLines() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstPolicyTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblClientOffices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblProducerContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblQuotes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstStates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblUsers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyLines() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblQuoteDetails() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstBillingTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblFactorSets() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeTAs() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeFinanceCompanies() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblIntermediaryContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblFin_ExpensePayees() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstSIC_Codes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstEarnedPremiumType() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeExpiringCarriers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblQuotes2() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeAssistants() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyProgramCodes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstNAICSCodes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtIssuingOffice() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtRetailerContacts() => false;

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
    dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsQuoteEdit.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public delegate void lstLinesRowChangeEventHandler(
    object sender,
    dsQuoteEdit.lstLinesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstPolicyTypesRowChangeEventHandler(
    object sender,
    dsQuoteEdit.lstPolicyTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblClientOfficesRowChangeEventHandler(
    object sender,
    dsQuoteEdit.tblClientOfficesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyContactsRowChangeEventHandler(
    object sender,
    dsQuoteEdit.tblCompanyContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblProducerContactsRowChangeEventHandler(
    object sender,
    dsQuoteEdit.tblProducerContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblQuotesRowChangeEventHandler(
    object sender,
    dsQuoteEdit.tblQuotesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstStatesRowChangeEventHandler(
    object sender,
    dsQuoteEdit.lstStatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblUsersRowChangeEventHandler(
    object sender,
    dsQuoteEdit.tblUsersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyLocationsRowChangeEventHandler(
    object sender,
    dsQuoteEdit.tblCompanyLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyLinesRowChangeEventHandler(
    object sender,
    dsQuoteEdit.tblCompanyLinesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblQuoteDetailsRowChangeEventHandler(
    object sender,
    dsQuoteEdit.tblQuoteDetailsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstBillingTypesRowChangeEventHandler(
    object sender,
    dsQuoteEdit.lstBillingTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblFactorSetsRowChangeEventHandler(
    object sender,
    dsQuoteEdit.tblFactorSetsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void TAsRowChangeEventHandler(object sender, dsQuoteEdit.TAsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void FinanceCompaniesRowChangeEventHandler(
    object sender,
    dsQuoteEdit.FinanceCompaniesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblIntermediaryContactsRowChangeEventHandler(
    object sender,
    dsQuoteEdit.tblIntermediaryContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblFin_ExpensePayeesRowChangeEventHandler(
    object sender,
    dsQuoteEdit.tblFin_ExpensePayeesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstSIC_CodesRowChangeEventHandler(
    object sender,
    dsQuoteEdit.lstSIC_CodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstEarnedPremiumTypeRowChangeEventHandler(
    object sender,
    dsQuoteEdit.lstEarnedPremiumTypeRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void ExpiringCarriersRowChangeEventHandler(
    object sender,
    dsQuoteEdit.ExpiringCarriersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblQuotes2RowChangeEventHandler(
    object sender,
    dsQuoteEdit.tblQuotes2RowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void AssistantsRowChangeEventHandler(
    object sender,
    dsQuoteEdit.AssistantsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyProgramCodesRowChangeEventHandler(
    object sender,
    dsQuoteEdit.tblCompanyProgramCodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstNAICSCodesRowChangeEventHandler(
    object sender,
    dsQuoteEdit.lstNAICSCodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtIssuingOfficeRowChangeEventHandler(
    object sender,
    dsQuoteEdit.dtIssuingOfficeRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtRetailerContactsRowChangeEventHandler(
    object sender,
    dsQuoteEdit.dtRetailerContactsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstLinesDataTable : TypedTableBase<dsQuoteEdit.lstLinesRow>
  {
    private DataColumn columnLineGuid;
    private DataColumn columnOfficeGuid;
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
    public DataColumn OfficeGuidColumn => this.columnOfficeGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstLinesRow this[int index] => (dsQuoteEdit.lstLinesRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstLinesRowChangeEventHandler lstLinesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstLinesRowChangeEventHandler lstLinesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstLinesRowChangeEventHandler lstLinesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstLinesRowChangeEventHandler lstLinesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstLinesRow(dsQuoteEdit.lstLinesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstLinesRow AddlstLinesRow(Guid LineGuid, Guid OfficeGuid, string LineName)
    {
      dsQuoteEdit.lstLinesRow row = (dsQuoteEdit.lstLinesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) LineGuid,
        (object) OfficeGuid,
        (object) LineName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstLinesRow FindByLineGuidOfficeGuid(Guid LineGuid, Guid OfficeGuid)
    {
      return (dsQuoteEdit.lstLinesRow) this.Rows.Find(new object[2]
      {
        (object) LineGuid,
        (object) OfficeGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.lstLinesDataTable lstLinesDataTable = (dsQuoteEdit.lstLinesDataTable) base.Clone();
      lstLinesDataTable.InitVars();
      return (DataTable) lstLinesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.lstLinesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnLineGuid = this.Columns["LineGuid"];
      this.columnOfficeGuid = this.Columns["OfficeGuid"];
      this.columnLineName = this.Columns["LineName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnLineGuid = new DataColumn("LineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGuid);
      this.columnOfficeGuid = new DataColumn("OfficeGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeGuid);
      this.columnLineName = new DataColumn("LineName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEditKey10", new DataColumn[2]
      {
        this.columnLineGuid,
        this.columnOfficeGuid
      }, true));
      this.columnLineGuid.AllowDBNull = false;
      this.columnOfficeGuid.AllowDBNull = false;
      this.columnLineName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstLinesRow NewlstLinesRow() => (dsQuoteEdit.lstLinesRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.lstLinesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.lstLinesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstLinesRowChangeEventHandler linesRowChangedEvent = this.lstLinesRowChangedEvent;
      if (linesRowChangedEvent == null)
        return;
      linesRowChangedEvent((object) this, new dsQuoteEdit.lstLinesRowChangeEvent((dsQuoteEdit.lstLinesRow) e.Row, e.Action));
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
      dsQuoteEdit.lstLinesRowChangeEventHandler rowChangingEvent = this.lstLinesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.lstLinesRowChangeEvent((dsQuoteEdit.lstLinesRow) e.Row, e.Action));
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
      dsQuoteEdit.lstLinesRowChangeEventHandler linesRowDeletedEvent = this.lstLinesRowDeletedEvent;
      if (linesRowDeletedEvent == null)
        return;
      linesRowDeletedEvent((object) this, new dsQuoteEdit.lstLinesRowChangeEvent((dsQuoteEdit.lstLinesRow) e.Row, e.Action));
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
      dsQuoteEdit.lstLinesRowChangeEventHandler rowDeletingEvent = this.lstLinesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.lstLinesRowChangeEvent((dsQuoteEdit.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstLinesRow(dsQuoteEdit.lstLinesRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstLinesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class lstPolicyTypesDataTable : TypedTableBase<dsQuoteEdit.lstPolicyTypesRow>
  {
    private DataColumn columnPolicyTypeID;
    private DataColumn columnDescription;
    private DataColumn columnHidden;

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
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstPolicyTypesRow this[int index]
    {
      get => (dsQuoteEdit.lstPolicyTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstPolicyTypesRow(dsQuoteEdit.lstPolicyTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstPolicyTypesRow AddlstPolicyTypesRow(string Description, bool Hidden)
    {
      dsQuoteEdit.lstPolicyTypesRow row = (dsQuoteEdit.lstPolicyTypesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) Description,
        (object) Hidden
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstPolicyTypesRow FindByPolicyTypeID(int PolicyTypeID)
    {
      return (dsQuoteEdit.lstPolicyTypesRow) this.Rows.Find(new object[1]
      {
        (object) PolicyTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.lstPolicyTypesDataTable policyTypesDataTable = (dsQuoteEdit.lstPolicyTypesDataTable) base.Clone();
      policyTypesDataTable.InitVars();
      return (DataTable) policyTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.lstPolicyTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnPolicyTypeID = this.Columns["PolicyTypeID"];
      this.columnDescription = this.Columns["Description"];
      this.columnHidden = this.Columns["Hidden"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnPolicyTypeID = new DataColumn("PolicyTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyTypeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnPolicyTypeID
      }, true));
      this.columnPolicyTypeID.AutoIncrement = true;
      this.columnPolicyTypeID.AllowDBNull = false;
      this.columnPolicyTypeID.ReadOnly = true;
      this.columnPolicyTypeID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstPolicyTypesRow NewlstPolicyTypesRow()
    {
      return (dsQuoteEdit.lstPolicyTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.lstPolicyTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.lstPolicyTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstPolicyTypesRowChangeEventHandler typesRowChangedEvent = this.lstPolicyTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsQuoteEdit.lstPolicyTypesRowChangeEvent((dsQuoteEdit.lstPolicyTypesRow) e.Row, e.Action));
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
      dsQuoteEdit.lstPolicyTypesRowChangeEventHandler rowChangingEvent = this.lstPolicyTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.lstPolicyTypesRowChangeEvent((dsQuoteEdit.lstPolicyTypesRow) e.Row, e.Action));
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
      dsQuoteEdit.lstPolicyTypesRowChangeEventHandler typesRowDeletedEvent = this.lstPolicyTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsQuoteEdit.lstPolicyTypesRowChangeEvent((dsQuoteEdit.lstPolicyTypesRow) e.Row, e.Action));
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
      dsQuoteEdit.lstPolicyTypesRowChangeEventHandler rowDeletingEvent = this.lstPolicyTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.lstPolicyTypesRowChangeEvent((dsQuoteEdit.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstPolicyTypesRow(dsQuoteEdit.lstPolicyTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPolicyTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class tblClientOfficesDataTable : TypedTableBase<dsQuoteEdit.tblClientOfficesRow>
  {
    private DataColumn columnLocation;
    private DataColumn columnOfficeGuid;
    private DataColumn columnHasChartOfAccounts;

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
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OfficeGuidColumn => this.columnOfficeGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn HasChartOfAccountsColumn => this.columnHasChartOfAccounts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblClientOfficesRow this[int index]
    {
      get => (dsQuoteEdit.tblClientOfficesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblClientOfficesRow(dsQuoteEdit.tblClientOfficesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblClientOfficesRow AddtblClientOfficesRow(
      string Location,
      Guid OfficeGuid,
      bool HasChartOfAccounts)
    {
      dsQuoteEdit.tblClientOfficesRow row = (dsQuoteEdit.tblClientOfficesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) Location,
        (object) OfficeGuid,
        (object) HasChartOfAccounts
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblClientOfficesRow FindByOfficeGuid(Guid OfficeGuid)
    {
      return (dsQuoteEdit.tblClientOfficesRow) this.Rows.Find(new object[1]
      {
        (object) OfficeGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.tblClientOfficesDataTable officesDataTable = (dsQuoteEdit.tblClientOfficesDataTable) base.Clone();
      officesDataTable.InitVars();
      return (DataTable) officesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.tblClientOfficesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnLocation = this.Columns["Location"];
      this.columnOfficeGuid = this.Columns["OfficeGuid"];
      this.columnHasChartOfAccounts = this.Columns["HasChartOfAccounts"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.columnOfficeGuid = new DataColumn("OfficeGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeGuid);
      this.columnHasChartOfAccounts = new DataColumn("HasChartOfAccounts", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHasChartOfAccounts);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnOfficeGuid
      }, true));
      this.columnLocation.AllowDBNull = false;
      this.columnOfficeGuid.AllowDBNull = false;
      this.columnOfficeGuid.Unique = true;
      this.columnHasChartOfAccounts.AllowDBNull = false;
      this.columnHasChartOfAccounts.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblClientOfficesRow NewtblClientOfficesRow()
    {
      return (dsQuoteEdit.tblClientOfficesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.tblClientOfficesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.tblClientOfficesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblClientOfficesRowChangeEventHandler officesRowChangedEvent = this.tblClientOfficesRowChangedEvent;
      if (officesRowChangedEvent == null)
        return;
      officesRowChangedEvent((object) this, new dsQuoteEdit.tblClientOfficesRowChangeEvent((dsQuoteEdit.tblClientOfficesRow) e.Row, e.Action));
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
      dsQuoteEdit.tblClientOfficesRowChangeEventHandler rowChangingEvent = this.tblClientOfficesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.tblClientOfficesRowChangeEvent((dsQuoteEdit.tblClientOfficesRow) e.Row, e.Action));
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
      dsQuoteEdit.tblClientOfficesRowChangeEventHandler officesRowDeletedEvent = this.tblClientOfficesRowDeletedEvent;
      if (officesRowDeletedEvent == null)
        return;
      officesRowDeletedEvent((object) this, new dsQuoteEdit.tblClientOfficesRowChangeEvent((dsQuoteEdit.tblClientOfficesRow) e.Row, e.Action));
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
      dsQuoteEdit.tblClientOfficesRowChangeEventHandler rowDeletingEvent = this.tblClientOfficesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.tblClientOfficesRowChangeEvent((dsQuoteEdit.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblClientOfficesRow(dsQuoteEdit.tblClientOfficesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClientOfficesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class tblCompanyContactsDataTable : TypedTableBase<dsQuoteEdit.tblCompanyContactsRow>
  {
    private DataColumn columnCompanyContactGuid;
    private DataColumn columnName;
    private DataColumn columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyContactsDataTable()
    {
      this.TableName = "tblCompanyContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblCompanyContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyContactGuidColumn => this.columnCompanyContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyContactsRow this[int index]
    {
      get => (dsQuoteEdit.tblCompanyContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyContactsRowChangeEventHandler tblCompanyContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyContactsRowChangeEventHandler tblCompanyContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyContactsRowChangeEventHandler tblCompanyContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyContactsRowChangeEventHandler tblCompanyContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyContactsRow(dsQuoteEdit.tblCompanyContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyContactsRow AddtblCompanyContactsRow(
      Guid CompanyContactGuid,
      string Name,
      Guid CompanyLocationGuid)
    {
      dsQuoteEdit.tblCompanyContactsRow row = (dsQuoteEdit.tblCompanyContactsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) CompanyContactGuid,
        (object) Name,
        (object) CompanyLocationGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyContactsRow FindByCompanyContactGuid(Guid CompanyContactGuid)
    {
      return (dsQuoteEdit.tblCompanyContactsRow) this.Rows.Find(new object[1]
      {
        (object) CompanyContactGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.tblCompanyContactsDataTable contactsDataTable = (dsQuoteEdit.tblCompanyContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.tblCompanyContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyContactGuid = this.Columns["CompanyContactGuid"];
      this.columnName = this.Columns["Name"];
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyContactGuid = new DataColumn("CompanyContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyContactGuid);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCompanyContactGuid
      }, true));
      this.columnCompanyContactGuid.AllowDBNull = false;
      this.columnCompanyContactGuid.Unique = true;
      this.columnName.AllowDBNull = false;
      this.columnName.ReadOnly = true;
      this.columnCompanyLocationGuid.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyContactsRow NewtblCompanyContactsRow()
    {
      return (dsQuoteEdit.tblCompanyContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.tblCompanyContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.tblCompanyContactsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblCompanyContactsRowChangeEventHandler contactsRowChangedEvent = this.tblCompanyContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsQuoteEdit.tblCompanyContactsRowChangeEvent((dsQuoteEdit.tblCompanyContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblCompanyContactsRowChangeEventHandler rowChangingEvent = this.tblCompanyContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.tblCompanyContactsRowChangeEvent((dsQuoteEdit.tblCompanyContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblCompanyContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblCompanyContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsQuoteEdit.tblCompanyContactsRowChangeEvent((dsQuoteEdit.tblCompanyContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblCompanyContactsRowChangeEventHandler rowDeletingEvent = this.tblCompanyContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.tblCompanyContactsRowChangeEvent((dsQuoteEdit.tblCompanyContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyContactsRow(dsQuoteEdit.tblCompanyContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class tblProducerContactsDataTable : TypedTableBase<dsQuoteEdit.tblProducerContactsRow>
  {
    private DataColumn columnFullName;
    private DataColumn columnProducerContactGuid;

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
    public DataColumn FullNameColumn => this.columnFullName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerContactGuidColumn => this.columnProducerContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblProducerContactsRow this[int index]
    {
      get => (dsQuoteEdit.tblProducerContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblProducerContactsRowChangeEventHandler tblProducerContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblProducerContactsRowChangeEventHandler tblProducerContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblProducerContactsRowChangeEventHandler tblProducerContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblProducerContactsRowChangeEventHandler tblProducerContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblProducerContactsRow(dsQuoteEdit.tblProducerContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblProducerContactsRow AddtblProducerContactsRow(
      string FullName,
      Guid ProducerContactGuid)
    {
      dsQuoteEdit.tblProducerContactsRow row = (dsQuoteEdit.tblProducerContactsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) FullName,
        (object) ProducerContactGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblProducerContactsRow FindByProducerContactGuid(Guid ProducerContactGuid)
    {
      return (dsQuoteEdit.tblProducerContactsRow) this.Rows.Find(new object[1]
      {
        (object) ProducerContactGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.tblProducerContactsDataTable contactsDataTable = (dsQuoteEdit.tblProducerContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.tblProducerContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnFullName = this.Columns["FullName"];
      this.columnProducerContactGuid = this.Columns["ProducerContactGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnFullName = new DataColumn("FullName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullName);
      this.columnProducerContactGuid = new DataColumn("ProducerContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContactGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnProducerContactGuid
      }, true));
      this.columnFullName.ReadOnly = true;
      this.columnProducerContactGuid.AllowDBNull = false;
      this.columnProducerContactGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblProducerContactsRow NewtblProducerContactsRow()
    {
      return (dsQuoteEdit.tblProducerContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.tblProducerContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.tblProducerContactsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblProducerContactsRowChangeEventHandler contactsRowChangedEvent = this.tblProducerContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsQuoteEdit.tblProducerContactsRowChangeEvent((dsQuoteEdit.tblProducerContactsRow) e.Row, e.Action));
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
      dsQuoteEdit.tblProducerContactsRowChangeEventHandler rowChangingEvent = this.tblProducerContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.tblProducerContactsRowChangeEvent((dsQuoteEdit.tblProducerContactsRow) e.Row, e.Action));
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
      dsQuoteEdit.tblProducerContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblProducerContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsQuoteEdit.tblProducerContactsRowChangeEvent((dsQuoteEdit.tblProducerContactsRow) e.Row, e.Action));
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
      dsQuoteEdit.tblProducerContactsRowChangeEventHandler rowDeletingEvent = this.tblProducerContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.tblProducerContactsRowChangeEvent((dsQuoteEdit.tblProducerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblProducerContactsRow(dsQuoteEdit.tblProducerContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class tblQuotesDataTable : TypedTableBase<dsQuoteEdit.tblQuotesRow>
  {
    private DataColumn columnQuoteGuid;
    private DataColumn columnControlNo;
    private DataColumn columnControlGuid;
    private DataColumn columnStateID;
    private DataColumn columnUnderwriterUserGuid;
    private DataColumn columnEffectiveDate;
    private DataColumn columnExpirationDate;
    private DataColumn columnQuotingLocationGuid;
    private DataColumn columnIssuingLocationGuid;
    private DataColumn columnProducerContactGuid;
    private DataColumn columnPolicyTypeID;
    private DataColumn columnDateCreated;
    private DataColumn columnSubmissionGroupGuid;
    private DataColumn columnLineGuid;
    private DataColumn columnSIC_Code;
    private DataColumn columnCompanyLocationGuid;
    private DataColumn columnBillingTypeID;
    private DataColumn columnTermsOfPayment;
    private DataColumn columnTACSRUserGuid;
    private DataColumn columnEndorsementEffective;
    private DataColumn columnEndorsementComment;
    private DataColumn columnFinanceCompanyGuid;
    private DataColumn columnRetailer;
    private DataColumn columnRetailerGuid;
    private DataColumn columnMinimumEarnedPercentage;
    private DataColumn columnAccountNumber;
    private DataColumn columnCostCenterID;
    private DataColumn columnInspectionCompanyID;
    private DataColumn columnQuickQuote;
    private DataColumn columnPreviousPremium;
    private DataColumn columnTargetPremium;
    private DataColumn columnExpiringPolicyNumber;
    private DataColumn columnRiskDescription;
    private DataColumn columnUnderwritingAssistantGuid;
    private DataColumn columnProducerLocationID;
    private DataColumn columnSecProducerContactGuid;
    private DataColumn columnEarnedPremiumTypeID;
    private DataColumn columnAuditable;
    private DataColumn columnNAICSCode;
    private DataColumn columnRenewalofControlNum;
    private DataColumn columnRenewalofQuoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuotesDataTable()
    {
      this.TableName = "tblQuotes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuotesDataTable(DataTable table)
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
    protected tblQuotesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ControlGuidColumn => this.columnControlGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UnderwriterUserGuidColumn => this.columnUnderwriterUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuotingLocationGuidColumn => this.columnQuotingLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IssuingLocationGuidColumn => this.columnIssuingLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerContactGuidColumn => this.columnProducerContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyTypeIDColumn => this.columnPolicyTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateCreatedColumn => this.columnDateCreated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SubmissionGroupGuidColumn => this.columnSubmissionGroupGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineGuidColumn => this.columnLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SIC_CodeColumn => this.columnSIC_Code;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BillingTypeIDColumn => this.columnBillingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TermsOfPaymentColumn => this.columnTermsOfPayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TACSRUserGuidColumn => this.columnTACSRUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EndorsementEffectiveColumn => this.columnEndorsementEffective;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EndorsementCommentColumn => this.columnEndorsementComment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FinanceCompanyGuidColumn => this.columnFinanceCompanyGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RetailerColumn => this.columnRetailer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RetailerGuidColumn => this.columnRetailerGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MinimumEarnedPercentageColumn => this.columnMinimumEarnedPercentage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AccountNumberColumn => this.columnAccountNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CostCenterIDColumn => this.columnCostCenterID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InspectionCompanyIDColumn => this.columnInspectionCompanyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuickQuoteColumn => this.columnQuickQuote;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PreviousPremiumColumn => this.columnPreviousPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TargetPremiumColumn => this.columnTargetPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExpiringPolicyNumberColumn => this.columnExpiringPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RiskDescriptionColumn => this.columnRiskDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UnderwritingAssistantGuidColumn => this.columnUnderwritingAssistantGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerLocationIDColumn => this.columnProducerLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SecProducerContactGuidColumn => this.columnSecProducerContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EarnedPremiumTypeIDColumn => this.columnEarnedPremiumTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AuditableColumn => this.columnAuditable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NAICSCodeColumn => this.columnNAICSCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RenewalofControlNumColumn => this.columnRenewalofControlNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RenewalofQuoteGUIDColumn => this.columnRenewalofQuoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuotesRow this[int index] => (dsQuoteEdit.tblQuotesRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblQuotesRowChangeEventHandler tblQuotesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblQuotesRowChangeEventHandler tblQuotesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblQuotesRowChangeEventHandler tblQuotesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblQuotesRowChangeEventHandler tblQuotesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblQuotesRow(dsQuoteEdit.tblQuotesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuotesRow AddtblQuotesRow(
      Guid QuoteGuid,
      int ControlNo,
      Guid ControlGuid,
      string StateID,
      Guid UnderwriterUserGuid,
      DateTime EffectiveDate,
      DateTime ExpirationDate,
      Guid QuotingLocationGuid,
      Guid IssuingLocationGuid,
      Guid ProducerContactGuid,
      int PolicyTypeID,
      DateTime DateCreated,
      Guid SubmissionGroupGuid,
      Guid LineGuid,
      dsQuoteEdit.lstSIC_CodesRow parentlstSIC_CodesRowBylstSIC_CodestblQuotes,
      Guid CompanyLocationGuid,
      int BillingTypeID,
      int TermsOfPayment,
      Guid TACSRUserGuid,
      DateTime EndorsementEffective,
      string EndorsementComment,
      dsQuoteEdit.FinanceCompaniesRow parentFinanceCompaniesRowByFinanceCompaniestblQuotes,
      string Retailer,
      Guid RetailerGuid,
      Decimal MinimumEarnedPercentage,
      string AccountNumber,
      int CostCenterID,
      dsQuoteEdit.tblFin_ExpensePayeesRow parenttblFin_ExpensePayeesRowBytblInspectionCompaniestblQuotes,
      bool QuickQuote,
      double PreviousPremium,
      double TargetPremium,
      string ExpiringPolicyNumber,
      string RiskDescription,
      Guid UnderwritingAssistantGuid,
      int ProducerLocationID,
      Guid SecProducerContactGuid,
      byte EarnedPremiumTypeID,
      bool Auditable,
      string NAICSCode,
      int RenewalofControlNum,
      Guid RenewalofQuoteGUID)
    {
      dsQuoteEdit.tblQuotesRow row = (dsQuoteEdit.tblQuotesRow) this.NewRow();
      object[] objArray = new object[41]
      {
        (object) QuoteGuid,
        (object) ControlNo,
        (object) ControlGuid,
        (object) StateID,
        (object) UnderwriterUserGuid,
        (object) EffectiveDate,
        (object) ExpirationDate,
        (object) QuotingLocationGuid,
        (object) IssuingLocationGuid,
        (object) ProducerContactGuid,
        (object) PolicyTypeID,
        (object) DateCreated,
        (object) SubmissionGroupGuid,
        (object) LineGuid,
        null,
        (object) CompanyLocationGuid,
        (object) BillingTypeID,
        (object) TermsOfPayment,
        (object) TACSRUserGuid,
        (object) EndorsementEffective,
        (object) EndorsementComment,
        null,
        (object) Retailer,
        (object) RetailerGuid,
        (object) MinimumEarnedPercentage,
        (object) AccountNumber,
        (object) CostCenterID,
        null,
        (object) QuickQuote,
        (object) PreviousPremium,
        (object) TargetPremium,
        (object) ExpiringPolicyNumber,
        (object) RiskDescription,
        (object) UnderwritingAssistantGuid,
        (object) ProducerLocationID,
        (object) SecProducerContactGuid,
        (object) EarnedPremiumTypeID,
        (object) Auditable,
        (object) NAICSCode,
        (object) RenewalofControlNum,
        (object) RenewalofQuoteGUID
      };
      if (parentlstSIC_CodesRowBylstSIC_CodestblQuotes != null)
        objArray[14] = RuntimeHelpers.GetObjectValue(parentlstSIC_CodesRowBylstSIC_CodestblQuotes[0]);
      if (parentFinanceCompaniesRowByFinanceCompaniestblQuotes != null)
        objArray[21] = RuntimeHelpers.GetObjectValue(parentFinanceCompaniesRowByFinanceCompaniestblQuotes[0]);
      if (parenttblFin_ExpensePayeesRowBytblInspectionCompaniestblQuotes != null)
        objArray[27] = RuntimeHelpers.GetObjectValue(parenttblFin_ExpensePayeesRowBytblInspectionCompaniestblQuotes[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuotesRow FindByQuoteGuid(Guid QuoteGuid)
    {
      return (dsQuoteEdit.tblQuotesRow) this.Rows.Find(new object[1]
      {
        (object) QuoteGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.tblQuotesDataTable tblQuotesDataTable = (dsQuoteEdit.tblQuotesDataTable) base.Clone();
      tblQuotesDataTable.InitVars();
      return (DataTable) tblQuotesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.tblQuotesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnControlGuid = this.Columns["ControlGuid"];
      this.columnStateID = this.Columns["StateID"];
      this.columnUnderwriterUserGuid = this.Columns["UnderwriterUserGuid"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnQuotingLocationGuid = this.Columns["QuotingLocationGuid"];
      this.columnIssuingLocationGuid = this.Columns["IssuingLocationGuid"];
      this.columnProducerContactGuid = this.Columns["ProducerContactGuid"];
      this.columnPolicyTypeID = this.Columns["PolicyTypeID"];
      this.columnDateCreated = this.Columns["DateCreated"];
      this.columnSubmissionGroupGuid = this.Columns["SubmissionGroupGuid"];
      this.columnLineGuid = this.Columns["LineGuid"];
      this.columnSIC_Code = this.Columns["SIC_Code"];
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
      this.columnBillingTypeID = this.Columns["BillingTypeID"];
      this.columnTermsOfPayment = this.Columns["TermsOfPayment"];
      this.columnTACSRUserGuid = this.Columns["TACSRUserGuid"];
      this.columnEndorsementEffective = this.Columns["EndorsementEffective"];
      this.columnEndorsementComment = this.Columns["EndorsementComment"];
      this.columnFinanceCompanyGuid = this.Columns["FinanceCompanyGuid"];
      this.columnRetailer = this.Columns["Retailer"];
      this.columnRetailerGuid = this.Columns["RetailerGuid"];
      this.columnMinimumEarnedPercentage = this.Columns["MinimumEarnedPercentage"];
      this.columnAccountNumber = this.Columns["AccountNumber"];
      this.columnCostCenterID = this.Columns["CostCenterID"];
      this.columnInspectionCompanyID = this.Columns["InspectionCompanyID"];
      this.columnQuickQuote = this.Columns["QuickQuote"];
      this.columnPreviousPremium = this.Columns["PreviousPremium"];
      this.columnTargetPremium = this.Columns["TargetPremium"];
      this.columnExpiringPolicyNumber = this.Columns["ExpiringPolicyNumber"];
      this.columnRiskDescription = this.Columns["RiskDescription"];
      this.columnUnderwritingAssistantGuid = this.Columns["UnderwritingAssistantGuid"];
      this.columnProducerLocationID = this.Columns["ProducerLocationID"];
      this.columnSecProducerContactGuid = this.Columns["SecProducerContactGuid"];
      this.columnEarnedPremiumTypeID = this.Columns["EarnedPremiumTypeID"];
      this.columnAuditable = this.Columns["Auditable"];
      this.columnNAICSCode = this.Columns["NAICSCode"];
      this.columnRenewalofControlNum = this.Columns["RenewalofControlNum"];
      this.columnRenewalofQuoteGUID = this.Columns["RenewalofQuoteGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnControlGuid = new DataColumn("ControlGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlGuid);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnUnderwriterUserGuid = new DataColumn("UnderwriterUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriterUserGuid);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnQuotingLocationGuid = new DataColumn("QuotingLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuotingLocationGuid);
      this.columnIssuingLocationGuid = new DataColumn("IssuingLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIssuingLocationGuid);
      this.columnProducerContactGuid = new DataColumn("ProducerContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContactGuid);
      this.columnPolicyTypeID = new DataColumn("PolicyTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyTypeID);
      this.columnDateCreated = new DataColumn("DateCreated", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateCreated);
      this.columnSubmissionGroupGuid = new DataColumn("SubmissionGroupGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubmissionGroupGuid);
      this.columnLineGuid = new DataColumn("LineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGuid);
      this.columnSIC_Code = new DataColumn("SIC_Code", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIC_Code);
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.columnBillingTypeID = new DataColumn("BillingTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingTypeID);
      this.columnTermsOfPayment = new DataColumn("TermsOfPayment", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTermsOfPayment);
      this.columnTACSRUserGuid = new DataColumn("TACSRUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTACSRUserGuid);
      this.columnEndorsementEffective = new DataColumn("EndorsementEffective", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementEffective);
      this.columnEndorsementComment = new DataColumn("EndorsementComment", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementComment);
      this.columnFinanceCompanyGuid = new DataColumn("FinanceCompanyGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFinanceCompanyGuid);
      this.columnRetailer = new DataColumn("Retailer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRetailer);
      this.columnRetailerGuid = new DataColumn("RetailerGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRetailerGuid);
      this.columnMinimumEarnedPercentage = new DataColumn("MinimumEarnedPercentage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMinimumEarnedPercentage);
      this.columnAccountNumber = new DataColumn("AccountNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccountNumber);
      this.columnCostCenterID = new DataColumn("CostCenterID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenterID);
      this.columnInspectionCompanyID = new DataColumn("InspectionCompanyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionCompanyID);
      this.columnQuickQuote = new DataColumn("QuickQuote", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuickQuote);
      this.columnPreviousPremium = new DataColumn("PreviousPremium", typeof (double), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPreviousPremium);
      this.columnTargetPremium = new DataColumn("TargetPremium", typeof (double), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTargetPremium);
      this.columnExpiringPolicyNumber = new DataColumn("ExpiringPolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpiringPolicyNumber);
      this.columnRiskDescription = new DataColumn("RiskDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRiskDescription);
      this.columnUnderwritingAssistantGuid = new DataColumn("UnderwritingAssistantGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwritingAssistantGuid);
      this.columnProducerLocationID = new DataColumn("ProducerLocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationID);
      this.columnSecProducerContactGuid = new DataColumn("SecProducerContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSecProducerContactGuid);
      this.columnEarnedPremiumTypeID = new DataColumn("EarnedPremiumTypeID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEarnedPremiumTypeID);
      this.columnAuditable = new DataColumn("Auditable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAuditable);
      this.columnNAICSCode = new DataColumn("NAICSCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNAICSCode);
      this.columnRenewalofControlNum = new DataColumn("RenewalofControlNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRenewalofControlNum);
      this.columnRenewalofQuoteGUID = new DataColumn("RenewalofQuoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRenewalofQuoteGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEditKey4", new DataColumn[1]
      {
        this.columnQuoteGuid
      }, true));
      this.columnQuoteGuid.AllowDBNull = false;
      this.columnQuoteGuid.Unique = true;
      this.columnControlGuid.AllowDBNull = false;
      this.columnEffectiveDate.AllowDBNull = false;
      this.columnExpirationDate.AllowDBNull = false;
      this.columnPolicyTypeID.AllowDBNull = false;
      this.columnPolicyTypeID.DefaultValue = (object) 1;
      this.columnDateCreated.AllowDBNull = false;
      this.columnQuickQuote.AllowDBNull = false;
      this.columnQuickQuote.DefaultValue = (object) false;
      this.columnProducerLocationID.AllowDBNull = false;
      this.columnAuditable.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuotesRow NewtblQuotesRow() => (dsQuoteEdit.tblQuotesRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.tblQuotesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.tblQuotesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuotesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblQuotesRowChangeEventHandler quotesRowChangedEvent = this.tblQuotesRowChangedEvent;
      if (quotesRowChangedEvent == null)
        return;
      quotesRowChangedEvent((object) this, new dsQuoteEdit.tblQuotesRowChangeEvent((dsQuoteEdit.tblQuotesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuotesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblQuotesRowChangeEventHandler rowChangingEvent = this.tblQuotesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.tblQuotesRowChangeEvent((dsQuoteEdit.tblQuotesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuotesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblQuotesRowChangeEventHandler quotesRowDeletedEvent = this.tblQuotesRowDeletedEvent;
      if (quotesRowDeletedEvent == null)
        return;
      quotesRowDeletedEvent((object) this, new dsQuoteEdit.tblQuotesRowChangeEvent((dsQuoteEdit.tblQuotesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuotesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblQuotesRowChangeEventHandler rowDeletingEvent = this.tblQuotesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.tblQuotesRowChangeEvent((dsQuoteEdit.tblQuotesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblQuotesRow(dsQuoteEdit.tblQuotesRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuotesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class lstStatesDataTable : TypedTableBase<dsQuoteEdit.lstStatesRow>
  {
    private DataColumn columnState;
    private DataColumn columnStateID;

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
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstStatesRow this[int index] => (dsQuoteEdit.lstStatesRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstStatesRowChangeEventHandler lstStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstStatesRowChangeEventHandler lstStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstStatesRowChangeEventHandler lstStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstStatesRowChangeEventHandler lstStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstStatesRow(dsQuoteEdit.lstStatesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstStatesRow AddlstStatesRow(string State, string StateID)
    {
      dsQuoteEdit.lstStatesRow row = (dsQuoteEdit.lstStatesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) State,
        (object) StateID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstStatesRow FindByStateID(string StateID)
    {
      return (dsQuoteEdit.lstStatesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.lstStatesDataTable lstStatesDataTable = (dsQuoteEdit.lstStatesDataTable) base.Clone();
      lstStatesDataTable.InitVars();
      return (DataTable) lstStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.lstStatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnState = this.Columns["State"];
      this.columnStateID = this.Columns["StateID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEditKey8", new DataColumn[1]
      {
        this.columnStateID
      }, true));
      this.columnState.AllowDBNull = false;
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstStatesRow NewlstStatesRow() => (dsQuoteEdit.lstStatesRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.lstStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.lstStatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstStatesRowChangeEventHandler statesRowChangedEvent = this.lstStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsQuoteEdit.lstStatesRowChangeEvent((dsQuoteEdit.lstStatesRow) e.Row, e.Action));
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
      dsQuoteEdit.lstStatesRowChangeEventHandler rowChangingEvent = this.lstStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.lstStatesRowChangeEvent((dsQuoteEdit.lstStatesRow) e.Row, e.Action));
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
      dsQuoteEdit.lstStatesRowChangeEventHandler statesRowDeletedEvent = this.lstStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsQuoteEdit.lstStatesRowChangeEvent((dsQuoteEdit.lstStatesRow) e.Row, e.Action));
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
      dsQuoteEdit.lstStatesRowChangeEventHandler rowDeletingEvent = this.lstStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.lstStatesRowChangeEvent((dsQuoteEdit.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstStatesRow(dsQuoteEdit.lstStatesRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class tblUsersDataTable : TypedTableBase<dsQuoteEdit.tblUsersRow>
  {
    private DataColumn columnFullName;
    private DataColumn columnUserGuid;

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
    public DataColumn FullNameColumn => this.columnFullName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UserGuidColumn => this.columnUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblUsersRow this[int index] => (dsQuoteEdit.tblUsersRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblUsersRowChangeEventHandler tblUsersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblUsersRowChangeEventHandler tblUsersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblUsersRowChangeEventHandler tblUsersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblUsersRowChangeEventHandler tblUsersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblUsersRow(dsQuoteEdit.tblUsersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblUsersRow AddtblUsersRow(string FullName, Guid UserGuid)
    {
      dsQuoteEdit.tblUsersRow row = (dsQuoteEdit.tblUsersRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) FullName,
        (object) UserGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblUsersRow FindByUserGuid(Guid UserGuid)
    {
      return (dsQuoteEdit.tblUsersRow) this.Rows.Find(new object[1]
      {
        (object) UserGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.tblUsersDataTable tblUsersDataTable = (dsQuoteEdit.tblUsersDataTable) base.Clone();
      tblUsersDataTable.InitVars();
      return (DataTable) tblUsersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.tblUsersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnFullName = this.Columns["FullName"];
      this.columnUserGuid = this.Columns["UserGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnFullName = new DataColumn("FullName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullName);
      this.columnUserGuid = new DataColumn("UserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEditKey9", new DataColumn[1]
      {
        this.columnUserGuid
      }, true));
      this.columnFullName.ReadOnly = true;
      this.columnUserGuid.AllowDBNull = false;
      this.columnUserGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblUsersRow NewtblUsersRow() => (dsQuoteEdit.tblUsersRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.tblUsersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.tblUsersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblUsersRowChangeEventHandler usersRowChangedEvent = this.tblUsersRowChangedEvent;
      if (usersRowChangedEvent == null)
        return;
      usersRowChangedEvent((object) this, new dsQuoteEdit.tblUsersRowChangeEvent((dsQuoteEdit.tblUsersRow) e.Row, e.Action));
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
      dsQuoteEdit.tblUsersRowChangeEventHandler rowChangingEvent = this.tblUsersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.tblUsersRowChangeEvent((dsQuoteEdit.tblUsersRow) e.Row, e.Action));
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
      dsQuoteEdit.tblUsersRowChangeEventHandler usersRowDeletedEvent = this.tblUsersRowDeletedEvent;
      if (usersRowDeletedEvent == null)
        return;
      usersRowDeletedEvent((object) this, new dsQuoteEdit.tblUsersRowChangeEvent((dsQuoteEdit.tblUsersRow) e.Row, e.Action));
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
      dsQuoteEdit.tblUsersRowChangeEventHandler rowDeletingEvent = this.tblUsersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.tblUsersRowChangeEvent((dsQuoteEdit.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblUsersRow(dsQuoteEdit.tblUsersRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUsersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class tblCompanyLocationsDataTable : TypedTableBase<dsQuoteEdit.tblCompanyLocationsRow>
  {
    private DataColumn columnName;
    private DataColumn columnCompanyLocationGuid;

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
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyLocationsRow this[int index]
    {
      get => (dsQuoteEdit.tblCompanyLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyLocationsRow(dsQuoteEdit.tblCompanyLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyLocationsRow AddtblCompanyLocationsRow(
      string Name,
      Guid CompanyLocationGuid)
    {
      dsQuoteEdit.tblCompanyLocationsRow row = (dsQuoteEdit.tblCompanyLocationsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Name,
        (object) CompanyLocationGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.tblCompanyLocationsDataTable locationsDataTable = (dsQuoteEdit.tblCompanyLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.tblCompanyLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnName = this.Columns["Name"];
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEditKey1", new DataColumn[1]
      {
        this.columnCompanyLocationGuid
      }, false));
      this.columnCompanyLocationGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyLocationsRow NewtblCompanyLocationsRow()
    {
      return (dsQuoteEdit.tblCompanyLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.tblCompanyLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.tblCompanyLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblCompanyLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblCompanyLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsQuoteEdit.tblCompanyLocationsRowChangeEvent((dsQuoteEdit.tblCompanyLocationsRow) e.Row, e.Action));
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
      dsQuoteEdit.tblCompanyLocationsRowChangeEventHandler rowChangingEvent = this.tblCompanyLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.tblCompanyLocationsRowChangeEvent((dsQuoteEdit.tblCompanyLocationsRow) e.Row, e.Action));
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
      dsQuoteEdit.tblCompanyLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblCompanyLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsQuoteEdit.tblCompanyLocationsRowChangeEvent((dsQuoteEdit.tblCompanyLocationsRow) e.Row, e.Action));
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
      dsQuoteEdit.tblCompanyLocationsRowChangeEventHandler rowDeletingEvent = this.tblCompanyLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.tblCompanyLocationsRowChangeEvent((dsQuoteEdit.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyLocationsRow(dsQuoteEdit.tblCompanyLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class tblCompanyLinesDataTable : TypedTableBase<dsQuoteEdit.tblCompanyLinesRow>
  {
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyLinesDataTable()
    {
      this.TableName = "tblCompanyLines";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyLinesDataTable(DataTable table)
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
    protected tblCompanyLinesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyLinesRow this[int index]
    {
      get => (dsQuoteEdit.tblCompanyLinesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyLinesRow(dsQuoteEdit.tblCompanyLinesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyLinesRow AddtblCompanyLinesRow(Guid CompanyLineGuid, string Name)
    {
      dsQuoteEdit.tblCompanyLinesRow row = (dsQuoteEdit.tblCompanyLinesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyLineGuid,
        (object) Name
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyLinesRow FindByCompanyLineGuid(Guid CompanyLineGuid)
    {
      return (dsQuoteEdit.tblCompanyLinesRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLineGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.tblCompanyLinesDataTable companyLinesDataTable = (dsQuoteEdit.tblCompanyLinesDataTable) base.Clone();
      companyLinesDataTable.InitVars();
      return (DataTable) companyLinesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.tblCompanyLinesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnName = this.Columns["Name"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEditKey5", new DataColumn[1]
      {
        this.columnCompanyLineGuid
      }, true));
      this.columnCompanyLineGuid.AllowDBNull = false;
      this.columnCompanyLineGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyLinesRow NewtblCompanyLinesRow()
    {
      return (dsQuoteEdit.tblCompanyLinesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.tblCompanyLinesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.tblCompanyLinesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblCompanyLinesRowChangeEventHandler linesRowChangedEvent = this.tblCompanyLinesRowChangedEvent;
      if (linesRowChangedEvent == null)
        return;
      linesRowChangedEvent((object) this, new dsQuoteEdit.tblCompanyLinesRowChangeEvent((dsQuoteEdit.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblCompanyLinesRowChangeEventHandler rowChangingEvent = this.tblCompanyLinesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.tblCompanyLinesRowChangeEvent((dsQuoteEdit.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblCompanyLinesRowChangeEventHandler linesRowDeletedEvent = this.tblCompanyLinesRowDeletedEvent;
      if (linesRowDeletedEvent == null)
        return;
      linesRowDeletedEvent((object) this, new dsQuoteEdit.tblCompanyLinesRowChangeEvent((dsQuoteEdit.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblCompanyLinesRowChangeEventHandler rowDeletingEvent = this.tblCompanyLinesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.tblCompanyLinesRowChangeEvent((dsQuoteEdit.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyLinesRow(dsQuoteEdit.tblCompanyLinesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLinesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class tblQuoteDetailsDataTable : TypedTableBase<dsQuoteEdit.tblQuoteDetailsRow>
  {
    private DataColumn columnQuoteGuid;
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnCompanyContactGuid;
    private DataColumn columnIntermediaryContactGuid;
    private DataColumn columnCompanyCommission;
    private DataColumn columnProducerCommission;
    private DataColumn columnParticipation;
    private DataColumn columnTermsOfPayment;
    private DataColumn columnUsingAdditiveCommission;
    private DataColumn columnCompanyLine;
    private DataColumn columnProgramID;
    private DataColumn columnSLA_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuoteDetailsDataTable()
    {
      this.TableName = "tblQuoteDetails";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuoteDetailsDataTable(DataTable table)
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
    protected tblQuoteDetailsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyContactGuidColumn => this.columnCompanyContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IntermediaryContactGuidColumn => this.columnIntermediaryContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyCommissionColumn => this.columnCompanyCommission;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerCommissionColumn => this.columnProducerCommission;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ParticipationColumn => this.columnParticipation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TermsOfPaymentColumn => this.columnTermsOfPayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UsingAdditiveCommissionColumn => this.columnUsingAdditiveCommission;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineColumn => this.columnCompanyLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProgramIDColumn => this.columnProgramID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SLA_NumberColumn => this.columnSLA_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuoteDetailsRow this[int index]
    {
      get => (dsQuoteEdit.tblQuoteDetailsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblQuoteDetailsRowChangeEventHandler tblQuoteDetailsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblQuoteDetailsRowChangeEventHandler tblQuoteDetailsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblQuoteDetailsRowChangeEventHandler tblQuoteDetailsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblQuoteDetailsRowChangeEventHandler tblQuoteDetailsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblQuoteDetailsRow(dsQuoteEdit.tblQuoteDetailsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuoteDetailsRow AddtblQuoteDetailsRow(
      dsQuoteEdit.tblQuotesRow parenttblQuotesRowBytblQuotestblQuoteDetails,
      Guid CompanyLineGuid,
      Guid CompanyContactGuid,
      Guid IntermediaryContactGuid,
      Decimal CompanyCommission,
      Decimal ProducerCommission,
      Decimal Participation,
      int TermsOfPayment,
      bool UsingAdditiveCommission,
      string CompanyLine,
      int ProgramID,
      string SLA_Number)
    {
      dsQuoteEdit.tblQuoteDetailsRow row = (dsQuoteEdit.tblQuoteDetailsRow) this.NewRow();
      object[] objArray = new object[12]
      {
        null,
        (object) CompanyLineGuid,
        (object) CompanyContactGuid,
        (object) IntermediaryContactGuid,
        (object) CompanyCommission,
        (object) ProducerCommission,
        (object) Participation,
        (object) TermsOfPayment,
        (object) UsingAdditiveCommission,
        (object) CompanyLine,
        (object) ProgramID,
        (object) SLA_Number
      };
      if (parenttblQuotesRowBytblQuotestblQuoteDetails != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblQuotesRowBytblQuotestblQuoteDetails[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuoteDetailsRow FindByQuoteGuidCompanyLineGuid(
      Guid QuoteGuid,
      Guid CompanyLineGuid)
    {
      return (dsQuoteEdit.tblQuoteDetailsRow) this.Rows.Find(new object[2]
      {
        (object) QuoteGuid,
        (object) CompanyLineGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.tblQuoteDetailsDataTable detailsDataTable = (dsQuoteEdit.tblQuoteDetailsDataTable) base.Clone();
      detailsDataTable.InitVars();
      return (DataTable) detailsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.tblQuoteDetailsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnCompanyContactGuid = this.Columns["CompanyContactGuid"];
      this.columnIntermediaryContactGuid = this.Columns["IntermediaryContactGuid"];
      this.columnCompanyCommission = this.Columns["CompanyCommission"];
      this.columnProducerCommission = this.Columns["ProducerCommission"];
      this.columnParticipation = this.Columns["Participation"];
      this.columnTermsOfPayment = this.Columns["TermsOfPayment"];
      this.columnUsingAdditiveCommission = this.Columns["UsingAdditiveCommission"];
      this.columnCompanyLine = this.Columns["CompanyLine"];
      this.columnProgramID = this.Columns["ProgramID"];
      this.columnSLA_Number = this.Columns["SLA_Number"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnCompanyContactGuid = new DataColumn("CompanyContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyContactGuid);
      this.columnIntermediaryContactGuid = new DataColumn("IntermediaryContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntermediaryContactGuid);
      this.columnCompanyCommission = new DataColumn("CompanyCommission", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyCommission);
      this.columnProducerCommission = new DataColumn("ProducerCommission", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerCommission);
      this.columnParticipation = new DataColumn("Participation", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParticipation);
      this.columnTermsOfPayment = new DataColumn("TermsOfPayment", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTermsOfPayment);
      this.columnUsingAdditiveCommission = new DataColumn("UsingAdditiveCommission", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUsingAdditiveCommission);
      this.columnCompanyLine = new DataColumn("CompanyLine", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLine);
      this.columnProgramID = new DataColumn("ProgramID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgramID);
      this.columnSLA_Number = new DataColumn("SLA_Number", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSLA_Number);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEditKey3", new DataColumn[2]
      {
        this.columnQuoteGuid,
        this.columnCompanyLineGuid
      }, true));
      this.columnQuoteGuid.AllowDBNull = false;
      this.columnCompanyLineGuid.AllowDBNull = false;
      this.columnTermsOfPayment.AllowDBNull = false;
      this.columnUsingAdditiveCommission.AllowDBNull = false;
      this.columnUsingAdditiveCommission.DefaultValue = (object) false;
      this.columnCompanyLine.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuoteDetailsRow NewtblQuoteDetailsRow()
    {
      return (dsQuoteEdit.tblQuoteDetailsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.tblQuoteDetailsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.tblQuoteDetailsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteDetailsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblQuoteDetailsRowChangeEventHandler detailsRowChangedEvent = this.tblQuoteDetailsRowChangedEvent;
      if (detailsRowChangedEvent == null)
        return;
      detailsRowChangedEvent((object) this, new dsQuoteEdit.tblQuoteDetailsRowChangeEvent((dsQuoteEdit.tblQuoteDetailsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteDetailsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblQuoteDetailsRowChangeEventHandler rowChangingEvent = this.tblQuoteDetailsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.tblQuoteDetailsRowChangeEvent((dsQuoteEdit.tblQuoteDetailsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteDetailsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblQuoteDetailsRowChangeEventHandler detailsRowDeletedEvent = this.tblQuoteDetailsRowDeletedEvent;
      if (detailsRowDeletedEvent == null)
        return;
      detailsRowDeletedEvent((object) this, new dsQuoteEdit.tblQuoteDetailsRowChangeEvent((dsQuoteEdit.tblQuoteDetailsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteDetailsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblQuoteDetailsRowChangeEventHandler rowDeletingEvent = this.tblQuoteDetailsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.tblQuoteDetailsRowChangeEvent((dsQuoteEdit.tblQuoteDetailsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblQuoteDetailsRow(dsQuoteEdit.tblQuoteDetailsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteDetailsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class lstBillingTypesDataTable : TypedTableBase<dsQuoteEdit.lstBillingTypesRow>
  {
    private DataColumn columnBillingTypeID;
    private DataColumn columnBillingType;
    private DataColumn columnBillingCode;
    private DataColumn columnOnCompanyLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstBillingTypesDataTable()
    {
      this.TableName = "lstBillingTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstBillingTypesDataTable(DataTable table)
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
    protected lstBillingTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BillingTypeIDColumn => this.columnBillingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BillingTypeColumn => this.columnBillingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BillingCodeColumn => this.columnBillingCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OnCompanyLineColumn => this.columnOnCompanyLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstBillingTypesRow this[int index]
    {
      get => (dsQuoteEdit.lstBillingTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstBillingTypesRowChangeEventHandler lstBillingTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstBillingTypesRowChangeEventHandler lstBillingTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstBillingTypesRowChangeEventHandler lstBillingTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstBillingTypesRowChangeEventHandler lstBillingTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstBillingTypesRow(dsQuoteEdit.lstBillingTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstBillingTypesRow AddlstBillingTypesRow(
      int BillingTypeID,
      string BillingType,
      string BillingCode,
      bool OnCompanyLine)
    {
      dsQuoteEdit.lstBillingTypesRow row = (dsQuoteEdit.lstBillingTypesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) BillingTypeID,
        (object) BillingType,
        (object) BillingCode,
        (object) OnCompanyLine
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstBillingTypesRow FindByBillingTypeID(int BillingTypeID)
    {
      return (dsQuoteEdit.lstBillingTypesRow) this.Rows.Find(new object[1]
      {
        (object) BillingTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.lstBillingTypesDataTable billingTypesDataTable = (dsQuoteEdit.lstBillingTypesDataTable) base.Clone();
      billingTypesDataTable.InitVars();
      return (DataTable) billingTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.lstBillingTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnBillingTypeID = this.Columns["BillingTypeID"];
      this.columnBillingType = this.Columns["BillingType"];
      this.columnBillingCode = this.Columns["BillingCode"];
      this.columnOnCompanyLine = this.Columns["OnCompanyLine"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnBillingTypeID = new DataColumn("BillingTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingTypeID);
      this.columnBillingType = new DataColumn("BillingType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingType);
      this.columnBillingCode = new DataColumn("BillingCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingCode);
      this.columnOnCompanyLine = new DataColumn("OnCompanyLine", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOnCompanyLine);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEditKey7", new DataColumn[1]
      {
        this.columnBillingTypeID
      }, true));
      this.columnBillingTypeID.AllowDBNull = false;
      this.columnBillingTypeID.Unique = true;
      this.columnBillingType.AllowDBNull = false;
      this.columnBillingCode.AllowDBNull = false;
      this.columnOnCompanyLine.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstBillingTypesRow NewlstBillingTypesRow()
    {
      return (dsQuoteEdit.lstBillingTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.lstBillingTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.lstBillingTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBillingTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstBillingTypesRowChangeEventHandler typesRowChangedEvent = this.lstBillingTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsQuoteEdit.lstBillingTypesRowChangeEvent((dsQuoteEdit.lstBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBillingTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstBillingTypesRowChangeEventHandler rowChangingEvent = this.lstBillingTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.lstBillingTypesRowChangeEvent((dsQuoteEdit.lstBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBillingTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstBillingTypesRowChangeEventHandler typesRowDeletedEvent = this.lstBillingTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsQuoteEdit.lstBillingTypesRowChangeEvent((dsQuoteEdit.lstBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBillingTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstBillingTypesRowChangeEventHandler rowDeletingEvent = this.lstBillingTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.lstBillingTypesRowChangeEvent((dsQuoteEdit.lstBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstBillingTypesRow(dsQuoteEdit.lstBillingTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstBillingTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class tblFactorSetsDataTable : TypedTableBase<dsQuoteEdit.tblFactorSetsRow>
  {
    private DataColumn columnHidden;
    private DataColumn columnEffectiveDate;
    private DataColumn columnFactorSetGuid;
    private DataColumn columnTitle;
    private DataColumn columnMemo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblFactorSetsDataTable()
    {
      this.TableName = "tblFactorSets";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblFactorSetsDataTable(DataTable table)
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
    protected tblFactorSetsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FactorSetGuidColumn => this.columnFactorSetGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TitleColumn => this.columnTitle;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MemoColumn => this.columnMemo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblFactorSetsRow this[int index]
    {
      get => (dsQuoteEdit.tblFactorSetsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblFactorSetsRowChangeEventHandler tblFactorSetsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblFactorSetsRowChangeEventHandler tblFactorSetsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblFactorSetsRowChangeEventHandler tblFactorSetsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblFactorSetsRowChangeEventHandler tblFactorSetsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblFactorSetsRow(dsQuoteEdit.tblFactorSetsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblFactorSetsRow AddtblFactorSetsRow(
      bool Hidden,
      string EffectiveDate,
      Guid FactorSetGuid,
      string Title,
      string Memo)
    {
      dsQuoteEdit.tblFactorSetsRow row = (dsQuoteEdit.tblFactorSetsRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) Hidden,
        (object) EffectiveDate,
        (object) FactorSetGuid,
        (object) Title,
        (object) Memo
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblFactorSetsRow FindByFactorSetGuid(Guid FactorSetGuid)
    {
      return (dsQuoteEdit.tblFactorSetsRow) this.Rows.Find(new object[1]
      {
        (object) FactorSetGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.tblFactorSetsDataTable factorSetsDataTable = (dsQuoteEdit.tblFactorSetsDataTable) base.Clone();
      factorSetsDataTable.InitVars();
      return (DataTable) factorSetsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.tblFactorSetsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnHidden = this.Columns["Hidden"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnFactorSetGuid = this.Columns["FactorSetGuid"];
      this.columnTitle = this.Columns["Title"];
      this.columnMemo = this.Columns["Memo"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnFactorSetGuid = new DataColumn("FactorSetGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFactorSetGuid);
      this.columnTitle = new DataColumn("Title", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTitle);
      this.columnMemo = new DataColumn("Memo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemo);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnFactorSetGuid
      }, true));
      this.columnHidden.AllowDBNull = false;
      this.columnEffectiveDate.ReadOnly = true;
      this.columnFactorSetGuid.AllowDBNull = false;
      this.columnFactorSetGuid.Unique = true;
      this.columnTitle.AllowDBNull = false;
      this.columnMemo.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblFactorSetsRow NewtblFactorSetsRow()
    {
      return (dsQuoteEdit.tblFactorSetsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.tblFactorSetsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.tblFactorSetsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblFactorSetsRowChangeEventHandler setsRowChangedEvent = this.tblFactorSetsRowChangedEvent;
      if (setsRowChangedEvent == null)
        return;
      setsRowChangedEvent((object) this, new dsQuoteEdit.tblFactorSetsRowChangeEvent((dsQuoteEdit.tblFactorSetsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblFactorSetsRowChangeEventHandler rowChangingEvent = this.tblFactorSetsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.tblFactorSetsRowChangeEvent((dsQuoteEdit.tblFactorSetsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblFactorSetsRowChangeEventHandler setsRowDeletedEvent = this.tblFactorSetsRowDeletedEvent;
      if (setsRowDeletedEvent == null)
        return;
      setsRowDeletedEvent((object) this, new dsQuoteEdit.tblFactorSetsRowChangeEvent((dsQuoteEdit.tblFactorSetsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblFactorSetsRowChangeEventHandler rowDeletingEvent = this.tblFactorSetsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.tblFactorSetsRowChangeEvent((dsQuoteEdit.tblFactorSetsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblFactorSetsRow(dsQuoteEdit.tblFactorSetsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblFactorSetsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class TAsDataTable : TypedTableBase<dsQuoteEdit.TAsRow>
  {
    private DataColumn columnUserGuid;
    private DataColumn columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public TAsDataTable()
    {
      this.TableName = "TAs";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal TAsDataTable(DataTable table)
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
    protected TAsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UserGuidColumn => this.columnUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.TAsRow this[int index] => (dsQuoteEdit.TAsRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.TAsRowChangeEventHandler TAsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.TAsRowChangeEventHandler TAsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.TAsRowChangeEventHandler TAsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.TAsRowChangeEventHandler TAsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddTAsRow(dsQuoteEdit.TAsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.TAsRow AddTAsRow(Guid UserGuid, string Name)
    {
      dsQuoteEdit.TAsRow row = (dsQuoteEdit.TAsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) UserGuid,
        (object) Name
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.TAsRow FindByUserGuid(Guid UserGuid)
    {
      return (dsQuoteEdit.TAsRow) this.Rows.Find(new object[1]
      {
        (object) UserGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.TAsDataTable tasDataTable = (dsQuoteEdit.TAsDataTable) base.Clone();
      tasDataTable.InitVars();
      return (DataTable) tasDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsQuoteEdit.TAsDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnUserGuid = this.Columns["UserGuid"];
      this.columnName = this.Columns["Name"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnUserGuid = new DataColumn("UserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGuid);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEditKey11", new DataColumn[1]
      {
        this.columnUserGuid
      }, true));
      this.columnUserGuid.AllowDBNull = false;
      this.columnUserGuid.Unique = true;
      this.columnName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.TAsRow NewTAsRow() => (dsQuoteEdit.TAsRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.TAsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.TAsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TAsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.TAsRowChangeEventHandler tasRowChangedEvent = this.TAsRowChangedEvent;
      if (tasRowChangedEvent == null)
        return;
      tasRowChangedEvent((object) this, new dsQuoteEdit.TAsRowChangeEvent((dsQuoteEdit.TAsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TAsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.TAsRowChangeEventHandler rowChangingEvent = this.TAsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.TAsRowChangeEvent((dsQuoteEdit.TAsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TAsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.TAsRowChangeEventHandler tasRowDeletedEvent = this.TAsRowDeletedEvent;
      if (tasRowDeletedEvent == null)
        return;
      tasRowDeletedEvent((object) this, new dsQuoteEdit.TAsRowChangeEvent((dsQuoteEdit.TAsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TAsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.TAsRowChangeEventHandler rowDeletingEvent = this.TAsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.TAsRowChangeEvent((dsQuoteEdit.TAsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveTAsRow(dsQuoteEdit.TAsRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (TAsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class FinanceCompaniesDataTable : TypedTableBase<dsQuoteEdit.FinanceCompaniesRow>
  {
    private DataColumn columnPayeeGuid;
    private DataColumn columnPayeeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public FinanceCompaniesDataTable()
    {
      this.TableName = "FinanceCompanies";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal FinanceCompaniesDataTable(DataTable table)
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
    protected FinanceCompaniesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PayeeGuidColumn => this.columnPayeeGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PayeeNameColumn => this.columnPayeeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.FinanceCompaniesRow this[int index]
    {
      get => (dsQuoteEdit.FinanceCompaniesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.FinanceCompaniesRowChangeEventHandler FinanceCompaniesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.FinanceCompaniesRowChangeEventHandler FinanceCompaniesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.FinanceCompaniesRowChangeEventHandler FinanceCompaniesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.FinanceCompaniesRowChangeEventHandler FinanceCompaniesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddFinanceCompaniesRow(dsQuoteEdit.FinanceCompaniesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.FinanceCompaniesRow AddFinanceCompaniesRow(Guid PayeeGuid, string PayeeName)
    {
      dsQuoteEdit.FinanceCompaniesRow row = (dsQuoteEdit.FinanceCompaniesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) PayeeGuid,
        (object) PayeeName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.FinanceCompaniesRow FindByPayeeGuid(Guid PayeeGuid)
    {
      return (dsQuoteEdit.FinanceCompaniesRow) this.Rows.Find(new object[1]
      {
        (object) PayeeGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.FinanceCompaniesDataTable companiesDataTable = (dsQuoteEdit.FinanceCompaniesDataTable) base.Clone();
      companiesDataTable.InitVars();
      return (DataTable) companiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.FinanceCompaniesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnPayeeGuid = this.Columns["PayeeGuid"];
      this.columnPayeeName = this.Columns["PayeeName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnPayeeGuid = new DataColumn("PayeeGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeGuid);
      this.columnPayeeName = new DataColumn("PayeeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEditKey6", new DataColumn[1]
      {
        this.columnPayeeGuid
      }, true));
      this.columnPayeeGuid.AllowDBNull = false;
      this.columnPayeeGuid.Unique = true;
      this.columnPayeeName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.FinanceCompaniesRow NewFinanceCompaniesRow()
    {
      return (dsQuoteEdit.FinanceCompaniesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.FinanceCompaniesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.FinanceCompaniesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FinanceCompaniesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.FinanceCompaniesRowChangeEventHandler companiesRowChangedEvent = this.FinanceCompaniesRowChangedEvent;
      if (companiesRowChangedEvent == null)
        return;
      companiesRowChangedEvent((object) this, new dsQuoteEdit.FinanceCompaniesRowChangeEvent((dsQuoteEdit.FinanceCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FinanceCompaniesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.FinanceCompaniesRowChangeEventHandler rowChangingEvent = this.FinanceCompaniesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.FinanceCompaniesRowChangeEvent((dsQuoteEdit.FinanceCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FinanceCompaniesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.FinanceCompaniesRowChangeEventHandler companiesRowDeletedEvent = this.FinanceCompaniesRowDeletedEvent;
      if (companiesRowDeletedEvent == null)
        return;
      companiesRowDeletedEvent((object) this, new dsQuoteEdit.FinanceCompaniesRowChangeEvent((dsQuoteEdit.FinanceCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FinanceCompaniesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.FinanceCompaniesRowChangeEventHandler rowDeletingEvent = this.FinanceCompaniesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.FinanceCompaniesRowChangeEvent((dsQuoteEdit.FinanceCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveFinanceCompaniesRow(dsQuoteEdit.FinanceCompaniesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (FinanceCompaniesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class tblIntermediaryContactsDataTable : 
    TypedTableBase<dsQuoteEdit.tblIntermediaryContactsRow>
  {
    private DataColumn columnIntermediaryContactGuid;
    private DataColumn columnName;
    private DataColumn columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblIntermediaryContactsDataTable()
    {
      this.TableName = "tblIntermediaryContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblIntermediaryContactsDataTable(DataTable table)
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
    protected tblIntermediaryContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IntermediaryContactGuidColumn => this.columnIntermediaryContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblIntermediaryContactsRow this[int index]
    {
      get => (dsQuoteEdit.tblIntermediaryContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblIntermediaryContactsRowChangeEventHandler tblIntermediaryContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblIntermediaryContactsRowChangeEventHandler tblIntermediaryContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblIntermediaryContactsRowChangeEventHandler tblIntermediaryContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblIntermediaryContactsRowChangeEventHandler tblIntermediaryContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblIntermediaryContactsRow(dsQuoteEdit.tblIntermediaryContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblIntermediaryContactsRow AddtblIntermediaryContactsRow(
      Guid IntermediaryContactGuid,
      string Name,
      Guid CompanyLocationGuid)
    {
      dsQuoteEdit.tblIntermediaryContactsRow row = (dsQuoteEdit.tblIntermediaryContactsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) IntermediaryContactGuid,
        (object) Name,
        (object) CompanyLocationGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblIntermediaryContactsRow FindByIntermediaryContactGuid(
      Guid IntermediaryContactGuid)
    {
      return (dsQuoteEdit.tblIntermediaryContactsRow) this.Rows.Find(new object[1]
      {
        (object) IntermediaryContactGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.tblIntermediaryContactsDataTable contactsDataTable = (dsQuoteEdit.tblIntermediaryContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.tblIntermediaryContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnIntermediaryContactGuid = this.Columns["IntermediaryContactGuid"];
      this.columnName = this.Columns["Name"];
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnIntermediaryContactGuid = new DataColumn("IntermediaryContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntermediaryContactGuid);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEditKey12", new DataColumn[1]
      {
        this.columnIntermediaryContactGuid
      }, true));
      this.columnIntermediaryContactGuid.AllowDBNull = false;
      this.columnIntermediaryContactGuid.Unique = true;
      this.columnName.AllowDBNull = false;
      this.columnName.ReadOnly = true;
      this.columnCompanyLocationGuid.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblIntermediaryContactsRow NewtblIntermediaryContactsRow()
    {
      return (dsQuoteEdit.tblIntermediaryContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.tblIntermediaryContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.tblIntermediaryContactsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediaryContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblIntermediaryContactsRowChangeEventHandler contactsRowChangedEvent = this.tblIntermediaryContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsQuoteEdit.tblIntermediaryContactsRowChangeEvent((dsQuoteEdit.tblIntermediaryContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediaryContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblIntermediaryContactsRowChangeEventHandler rowChangingEvent = this.tblIntermediaryContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.tblIntermediaryContactsRowChangeEvent((dsQuoteEdit.tblIntermediaryContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediaryContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblIntermediaryContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblIntermediaryContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsQuoteEdit.tblIntermediaryContactsRowChangeEvent((dsQuoteEdit.tblIntermediaryContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediaryContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblIntermediaryContactsRowChangeEventHandler rowDeletingEvent = this.tblIntermediaryContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.tblIntermediaryContactsRowChangeEvent((dsQuoteEdit.tblIntermediaryContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblIntermediaryContactsRow(dsQuoteEdit.tblIntermediaryContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblIntermediaryContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class tblFin_ExpensePayeesDataTable : TypedTableBase<dsQuoteEdit.tblFin_ExpensePayeesRow>
  {
    private DataColumn columnPayeeID;
    private DataColumn columnPayeeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblFin_ExpensePayeesDataTable()
    {
      this.TableName = "tblFin_ExpensePayees";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblFin_ExpensePayeesDataTable(DataTable table)
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
    protected tblFin_ExpensePayeesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PayeeIDColumn => this.columnPayeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PayeeNameColumn => this.columnPayeeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblFin_ExpensePayeesRow this[int index]
    {
      get => (dsQuoteEdit.tblFin_ExpensePayeesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblFin_ExpensePayeesRow(dsQuoteEdit.tblFin_ExpensePayeesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblFin_ExpensePayeesRow AddtblFin_ExpensePayeesRow(
      int PayeeID,
      string PayeeName)
    {
      dsQuoteEdit.tblFin_ExpensePayeesRow row = (dsQuoteEdit.tblFin_ExpensePayeesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) PayeeID,
        (object) PayeeName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblFin_ExpensePayeesRow FindByPayeeID(int PayeeID)
    {
      return (dsQuoteEdit.tblFin_ExpensePayeesRow) this.Rows.Find(new object[1]
      {
        (object) PayeeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.tblFin_ExpensePayeesDataTable expensePayeesDataTable = (dsQuoteEdit.tblFin_ExpensePayeesDataTable) base.Clone();
      expensePayeesDataTable.InitVars();
      return (DataTable) expensePayeesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.tblFin_ExpensePayeesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnPayeeID = this.Columns["PayeeID"];
      this.columnPayeeName = this.Columns["PayeeName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnPayeeID = new DataColumn("PayeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeID);
      this.columnPayeeName = new DataColumn("PayeeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEditKey13", new DataColumn[1]
      {
        this.columnPayeeID
      }, true));
      this.columnPayeeID.AllowDBNull = false;
      this.columnPayeeID.Unique = true;
      this.columnPayeeName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblFin_ExpensePayeesRow NewtblFin_ExpensePayeesRow()
    {
      return (dsQuoteEdit.tblFin_ExpensePayeesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.tblFin_ExpensePayeesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.tblFin_ExpensePayeesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblFin_ExpensePayeesRowChangeEventHandler payeesRowChangedEvent = this.tblFin_ExpensePayeesRowChangedEvent;
      if (payeesRowChangedEvent == null)
        return;
      payeesRowChangedEvent((object) this, new dsQuoteEdit.tblFin_ExpensePayeesRowChangeEvent((dsQuoteEdit.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblFin_ExpensePayeesRowChangeEventHandler rowChangingEvent = this.tblFin_ExpensePayeesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.tblFin_ExpensePayeesRowChangeEvent((dsQuoteEdit.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblFin_ExpensePayeesRowChangeEventHandler payeesRowDeletedEvent = this.tblFin_ExpensePayeesRowDeletedEvent;
      if (payeesRowDeletedEvent == null)
        return;
      payeesRowDeletedEvent((object) this, new dsQuoteEdit.tblFin_ExpensePayeesRowChangeEvent((dsQuoteEdit.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblFin_ExpensePayeesRowChangeEventHandler rowDeletingEvent = this.tblFin_ExpensePayeesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.tblFin_ExpensePayeesRowChangeEvent((dsQuoteEdit.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblFin_ExpensePayeesRow(dsQuoteEdit.tblFin_ExpensePayeesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblFin_ExpensePayeesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class lstSIC_CodesDataTable : TypedTableBase<dsQuoteEdit.lstSIC_CodesRow>
  {
    private DataColumn columnSIC_Code;
    private DataColumn columnSIC_Description;
    private DataColumn columnSIC_Family_Description;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstSIC_CodesDataTable()
    {
      this.TableName = "lstSIC_Codes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstSIC_CodesDataTable(DataTable table)
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
    protected lstSIC_CodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SIC_CodeColumn => this.columnSIC_Code;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SIC_DescriptionColumn => this.columnSIC_Description;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SIC_Family_DescriptionColumn => this.columnSIC_Family_Description;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstSIC_CodesRow this[int index]
    {
      get => (dsQuoteEdit.lstSIC_CodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstSIC_CodesRowChangeEventHandler lstSIC_CodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstSIC_CodesRowChangeEventHandler lstSIC_CodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstSIC_CodesRowChangeEventHandler lstSIC_CodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstSIC_CodesRowChangeEventHandler lstSIC_CodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstSIC_CodesRow(dsQuoteEdit.lstSIC_CodesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstSIC_CodesRow AddlstSIC_CodesRow(
      string SIC_Code,
      string SIC_Description,
      string SIC_Family_Description)
    {
      dsQuoteEdit.lstSIC_CodesRow row = (dsQuoteEdit.lstSIC_CodesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) SIC_Code,
        (object) SIC_Description,
        (object) SIC_Family_Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstSIC_CodesRow FindBySIC_Code(string SIC_Code)
    {
      return (dsQuoteEdit.lstSIC_CodesRow) this.Rows.Find(new object[1]
      {
        (object) SIC_Code
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.lstSIC_CodesDataTable sicCodesDataTable = (dsQuoteEdit.lstSIC_CodesDataTable) base.Clone();
      sicCodesDataTable.InitVars();
      return (DataTable) sicCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.lstSIC_CodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnSIC_Code = this.Columns["SIC_Code"];
      this.columnSIC_Description = this.Columns["SIC_Description"];
      this.columnSIC_Family_Description = this.Columns["SIC_Family_Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnSIC_Code = new DataColumn("SIC_Code", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIC_Code);
      this.columnSIC_Description = new DataColumn("SIC_Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIC_Description);
      this.columnSIC_Family_Description = new DataColumn("SIC_Family_Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIC_Family_Description);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEditKey2", new DataColumn[1]
      {
        this.columnSIC_Code
      }, true));
      this.columnSIC_Code.AllowDBNull = false;
      this.columnSIC_Code.Unique = true;
      this.columnSIC_Description.AllowDBNull = false;
      this.columnSIC_Family_Description.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstSIC_CodesRow NewlstSIC_CodesRow()
    {
      return (dsQuoteEdit.lstSIC_CodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.lstSIC_CodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.lstSIC_CodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSIC_CodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstSIC_CodesRowChangeEventHandler codesRowChangedEvent = this.lstSIC_CodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsQuoteEdit.lstSIC_CodesRowChangeEvent((dsQuoteEdit.lstSIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSIC_CodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstSIC_CodesRowChangeEventHandler rowChangingEvent = this.lstSIC_CodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.lstSIC_CodesRowChangeEvent((dsQuoteEdit.lstSIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSIC_CodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstSIC_CodesRowChangeEventHandler codesRowDeletedEvent = this.lstSIC_CodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsQuoteEdit.lstSIC_CodesRowChangeEvent((dsQuoteEdit.lstSIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSIC_CodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstSIC_CodesRowChangeEventHandler rowDeletingEvent = this.lstSIC_CodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.lstSIC_CodesRowChangeEvent((dsQuoteEdit.lstSIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstSIC_CodesRow(dsQuoteEdit.lstSIC_CodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstSIC_CodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class lstEarnedPremiumTypeDataTable : TypedTableBase<dsQuoteEdit.lstEarnedPremiumTypeRow>
  {
    private DataColumn columnID;
    private DataColumn columnEarnedPremiumType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstEarnedPremiumTypeDataTable()
    {
      this.TableName = "lstEarnedPremiumType";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstEarnedPremiumTypeDataTable(DataTable table)
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
    protected lstEarnedPremiumTypeDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EarnedPremiumTypeColumn => this.columnEarnedPremiumType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstEarnedPremiumTypeRow this[int index]
    {
      get => (dsQuoteEdit.lstEarnedPremiumTypeRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstEarnedPremiumTypeRowChangeEventHandler lstEarnedPremiumTypeRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstEarnedPremiumTypeRowChangeEventHandler lstEarnedPremiumTypeRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstEarnedPremiumTypeRowChangeEventHandler lstEarnedPremiumTypeRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstEarnedPremiumTypeRowChangeEventHandler lstEarnedPremiumTypeRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstEarnedPremiumTypeRow(dsQuoteEdit.lstEarnedPremiumTypeRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstEarnedPremiumTypeRow AddlstEarnedPremiumTypeRow(
      byte ID,
      string EarnedPremiumType)
    {
      dsQuoteEdit.lstEarnedPremiumTypeRow row = (dsQuoteEdit.lstEarnedPremiumTypeRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) EarnedPremiumType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstEarnedPremiumTypeRow FindByID(byte ID)
    {
      return (dsQuoteEdit.lstEarnedPremiumTypeRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.lstEarnedPremiumTypeDataTable premiumTypeDataTable = (dsQuoteEdit.lstEarnedPremiumTypeDataTable) base.Clone();
      premiumTypeDataTable.InitVars();
      return (DataTable) premiumTypeDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.lstEarnedPremiumTypeDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnEarnedPremiumType = this.Columns["EarnedPremiumType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnEarnedPremiumType = new DataColumn("EarnedPremiumType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEarnedPremiumType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnEarnedPremiumType.AllowDBNull = false;
      this.columnEarnedPremiumType.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstEarnedPremiumTypeRow NewlstEarnedPremiumTypeRow()
    {
      return (dsQuoteEdit.lstEarnedPremiumTypeRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.lstEarnedPremiumTypeRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.lstEarnedPremiumTypeRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEarnedPremiumTypeRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstEarnedPremiumTypeRowChangeEventHandler typeRowChangedEvent = this.lstEarnedPremiumTypeRowChangedEvent;
      if (typeRowChangedEvent == null)
        return;
      typeRowChangedEvent((object) this, new dsQuoteEdit.lstEarnedPremiumTypeRowChangeEvent((dsQuoteEdit.lstEarnedPremiumTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEarnedPremiumTypeRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstEarnedPremiumTypeRowChangeEventHandler rowChangingEvent = this.lstEarnedPremiumTypeRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.lstEarnedPremiumTypeRowChangeEvent((dsQuoteEdit.lstEarnedPremiumTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEarnedPremiumTypeRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstEarnedPremiumTypeRowChangeEventHandler typeRowDeletedEvent = this.lstEarnedPremiumTypeRowDeletedEvent;
      if (typeRowDeletedEvent == null)
        return;
      typeRowDeletedEvent((object) this, new dsQuoteEdit.lstEarnedPremiumTypeRowChangeEvent((dsQuoteEdit.lstEarnedPremiumTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEarnedPremiumTypeRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstEarnedPremiumTypeRowChangeEventHandler rowDeletingEvent = this.lstEarnedPremiumTypeRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.lstEarnedPremiumTypeRowChangeEvent((dsQuoteEdit.lstEarnedPremiumTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstEarnedPremiumTypeRow(dsQuoteEdit.lstEarnedPremiumTypeRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstEarnedPremiumTypeDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class ExpiringCarriersDataTable : TypedTableBase<dsQuoteEdit.ExpiringCarriersRow>
  {
    private DataColumn columnCompanyLocationGuid;
    private DataColumn columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public ExpiringCarriersDataTable()
    {
      this.TableName = "ExpiringCarriers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal ExpiringCarriersDataTable(DataTable table)
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
    protected ExpiringCarriersDataTable(SerializationInfo info, StreamingContext context)
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
    public dsQuoteEdit.ExpiringCarriersRow this[int index]
    {
      get => (dsQuoteEdit.ExpiringCarriersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.ExpiringCarriersRowChangeEventHandler ExpiringCarriersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.ExpiringCarriersRowChangeEventHandler ExpiringCarriersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.ExpiringCarriersRowChangeEventHandler ExpiringCarriersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.ExpiringCarriersRowChangeEventHandler ExpiringCarriersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddExpiringCarriersRow(dsQuoteEdit.ExpiringCarriersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.ExpiringCarriersRow AddExpiringCarriersRow(
      Guid CompanyLocationGuid,
      string LocationName)
    {
      dsQuoteEdit.ExpiringCarriersRow row = (dsQuoteEdit.ExpiringCarriersRow) this.NewRow();
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
    public dsQuoteEdit.ExpiringCarriersRow FindByCompanyLocationGuid(Guid CompanyLocationGuid)
    {
      return (dsQuoteEdit.ExpiringCarriersRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLocationGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.ExpiringCarriersDataTable carriersDataTable = (dsQuoteEdit.ExpiringCarriersDataTable) base.Clone();
      carriersDataTable.InitVars();
      return (DataTable) carriersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.ExpiringCarriersDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("ExpiringCarriersKey1", new DataColumn[1]
      {
        this.columnCompanyLocationGuid
      }, true));
      this.columnCompanyLocationGuid.AllowDBNull = false;
      this.columnCompanyLocationGuid.Unique = true;
      this.columnLocationName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.ExpiringCarriersRow NewExpiringCarriersRow()
    {
      return (dsQuoteEdit.ExpiringCarriersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.ExpiringCarriersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.ExpiringCarriersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ExpiringCarriersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.ExpiringCarriersRowChangeEventHandler carriersRowChangedEvent = this.ExpiringCarriersRowChangedEvent;
      if (carriersRowChangedEvent == null)
        return;
      carriersRowChangedEvent((object) this, new dsQuoteEdit.ExpiringCarriersRowChangeEvent((dsQuoteEdit.ExpiringCarriersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ExpiringCarriersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.ExpiringCarriersRowChangeEventHandler rowChangingEvent = this.ExpiringCarriersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.ExpiringCarriersRowChangeEvent((dsQuoteEdit.ExpiringCarriersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ExpiringCarriersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.ExpiringCarriersRowChangeEventHandler carriersRowDeletedEvent = this.ExpiringCarriersRowDeletedEvent;
      if (carriersRowDeletedEvent == null)
        return;
      carriersRowDeletedEvent((object) this, new dsQuoteEdit.ExpiringCarriersRowChangeEvent((dsQuoteEdit.ExpiringCarriersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ExpiringCarriersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.ExpiringCarriersRowChangeEventHandler rowDeletingEvent = this.ExpiringCarriersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.ExpiringCarriersRowChangeEvent((dsQuoteEdit.ExpiringCarriersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveExpiringCarriersRow(dsQuoteEdit.ExpiringCarriersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ExpiringCarriersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class tblQuotes2DataTable : TypedTableBase<dsQuoteEdit.tblQuotes2Row>
  {
    private DataColumn columnQuoteID;
    private DataColumn columnExpiringCompanyLocationGuid;
    private DataColumn columnNonRenewed;
    private DataColumn columnMinimumCancellationDays;
    private DataColumn columnFacultative;
    private DataColumn columnExchangeRate;
    private DataColumn columnNeededByDate;
    private DataColumn columnMinimumEarnedAmount;
    private DataColumn columnFacultativePercentage;
    private DataColumn columnTaxAddress1;
    private DataColumn columnTaxAddress2;
    private DataColumn columnTaxCity;
    private DataColumn columnTaxState;
    private DataColumn columnTaxZip;
    private DataColumn columnTaxCounty;
    private DataColumn columnSettlementCurrencyCode;
    private DataColumn columnRetailerContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuotes2DataTable()
    {
      this.TableName = "tblQuotes2";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuotes2DataTable(DataTable table)
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
    protected tblQuotes2DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExpiringCompanyLocationGuidColumn => this.columnExpiringCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NonRenewedColumn => this.columnNonRenewed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MinimumCancellationDaysColumn => this.columnMinimumCancellationDays;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FacultativeColumn => this.columnFacultative;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExchangeRateColumn => this.columnExchangeRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NeededByDateColumn => this.columnNeededByDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MinimumEarnedAmountColumn => this.columnMinimumEarnedAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FacultativePercentageColumn => this.columnFacultativePercentage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TaxAddress1Column => this.columnTaxAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TaxAddress2Column => this.columnTaxAddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TaxCityColumn => this.columnTaxCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TaxStateColumn => this.columnTaxState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TaxZipColumn => this.columnTaxZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TaxCountyColumn => this.columnTaxCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SettlementCurrencyCodeColumn => this.columnSettlementCurrencyCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RetailerContactGuidColumn => this.columnRetailerContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuotes2Row this[int index]
    {
      get => (dsQuoteEdit.tblQuotes2Row) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblQuotes2RowChangeEventHandler tblQuotes2RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblQuotes2RowChangeEventHandler tblQuotes2RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblQuotes2RowChangeEventHandler tblQuotes2RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblQuotes2RowChangeEventHandler tblQuotes2RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblQuotes2Row(dsQuoteEdit.tblQuotes2Row row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuotes2Row AddtblQuotes2Row(
      int QuoteID,
      Guid ExpiringCompanyLocationGuid,
      bool NonRenewed,
      int MinimumCancellationDays,
      bool Facultative,
      Decimal ExchangeRate,
      DateTime NeededByDate,
      Decimal MinimumEarnedAmount,
      Decimal FacultativePercentage,
      string TaxAddress1,
      string TaxAddress2,
      string TaxCity,
      string TaxState,
      string TaxZip,
      string TaxCounty,
      string SettlementCurrencyCode,
      Guid RetailerContactGuid)
    {
      dsQuoteEdit.tblQuotes2Row row = (dsQuoteEdit.tblQuotes2Row) this.NewRow();
      object[] objArray = new object[17]
      {
        (object) QuoteID,
        (object) ExpiringCompanyLocationGuid,
        (object) NonRenewed,
        (object) MinimumCancellationDays,
        (object) Facultative,
        (object) ExchangeRate,
        (object) NeededByDate,
        (object) MinimumEarnedAmount,
        (object) FacultativePercentage,
        (object) TaxAddress1,
        (object) TaxAddress2,
        (object) TaxCity,
        (object) TaxState,
        (object) TaxZip,
        (object) TaxCounty,
        (object) SettlementCurrencyCode,
        (object) RetailerContactGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuotes2Row FindByQuoteID(int QuoteID)
    {
      return (dsQuoteEdit.tblQuotes2Row) this.Rows.Find(new object[1]
      {
        (object) QuoteID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.tblQuotes2DataTable quotes2DataTable = (dsQuoteEdit.tblQuotes2DataTable) base.Clone();
      quotes2DataTable.InitVars();
      return (DataTable) quotes2DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.tblQuotes2DataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnExpiringCompanyLocationGuid = this.Columns["ExpiringCompanyLocationGuid"];
      this.columnNonRenewed = this.Columns["NonRenewed"];
      this.columnMinimumCancellationDays = this.Columns["MinimumCancellationDays"];
      this.columnFacultative = this.Columns["Facultative"];
      this.columnExchangeRate = this.Columns["ExchangeRate"];
      this.columnNeededByDate = this.Columns["NeededByDate"];
      this.columnMinimumEarnedAmount = this.Columns["MinimumEarnedAmount"];
      this.columnFacultativePercentage = this.Columns["FacultativePercentage"];
      this.columnTaxAddress1 = this.Columns["TaxAddress1"];
      this.columnTaxAddress2 = this.Columns["TaxAddress2"];
      this.columnTaxCity = this.Columns["TaxCity"];
      this.columnTaxState = this.Columns["TaxState"];
      this.columnTaxZip = this.Columns["TaxZip"];
      this.columnTaxCounty = this.Columns["TaxCounty"];
      this.columnSettlementCurrencyCode = this.Columns["SettlementCurrencyCode"];
      this.columnRetailerContactGuid = this.Columns["RetailerContactGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnExpiringCompanyLocationGuid = new DataColumn("ExpiringCompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpiringCompanyLocationGuid);
      this.columnNonRenewed = new DataColumn("NonRenewed", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNonRenewed);
      this.columnMinimumCancellationDays = new DataColumn("MinimumCancellationDays", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMinimumCancellationDays);
      this.columnFacultative = new DataColumn("Facultative", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFacultative);
      this.columnExchangeRate = new DataColumn("ExchangeRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExchangeRate);
      this.columnNeededByDate = new DataColumn("NeededByDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNeededByDate);
      this.columnMinimumEarnedAmount = new DataColumn("MinimumEarnedAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMinimumEarnedAmount);
      this.columnFacultativePercentage = new DataColumn("FacultativePercentage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFacultativePercentage);
      this.columnTaxAddress1 = new DataColumn("TaxAddress1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxAddress1);
      this.columnTaxAddress2 = new DataColumn("TaxAddress2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxAddress2);
      this.columnTaxCity = new DataColumn("TaxCity", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxCity);
      this.columnTaxState = new DataColumn("TaxState", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxState);
      this.columnTaxZip = new DataColumn("TaxZip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxZip);
      this.columnTaxCounty = new DataColumn("TaxCounty", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxCounty);
      this.columnSettlementCurrencyCode = new DataColumn("SettlementCurrencyCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSettlementCurrencyCode);
      this.columnRetailerContactGuid = new DataColumn("RetailerContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRetailerContactGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnQuoteID
      }, true));
      this.columnQuoteID.AllowDBNull = false;
      this.columnQuoteID.Unique = true;
      this.columnFacultative.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuotes2Row NewtblQuotes2Row()
    {
      return (dsQuoteEdit.tblQuotes2Row) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.tblQuotes2Row(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.tblQuotes2Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuotes2RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblQuotes2RowChangeEventHandler quotes2RowChangedEvent = this.tblQuotes2RowChangedEvent;
      if (quotes2RowChangedEvent == null)
        return;
      quotes2RowChangedEvent((object) this, new dsQuoteEdit.tblQuotes2RowChangeEvent((dsQuoteEdit.tblQuotes2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuotes2RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblQuotes2RowChangeEventHandler rowChangingEvent = this.tblQuotes2RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.tblQuotes2RowChangeEvent((dsQuoteEdit.tblQuotes2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuotes2RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblQuotes2RowChangeEventHandler quotes2RowDeletedEvent = this.tblQuotes2RowDeletedEvent;
      if (quotes2RowDeletedEvent == null)
        return;
      quotes2RowDeletedEvent((object) this, new dsQuoteEdit.tblQuotes2RowChangeEvent((dsQuoteEdit.tblQuotes2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuotes2RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblQuotes2RowChangeEventHandler rowDeletingEvent = this.tblQuotes2RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.tblQuotes2RowChangeEvent((dsQuoteEdit.tblQuotes2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblQuotes2Row(dsQuoteEdit.tblQuotes2Row row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuotes2DataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class AssistantsDataTable : TypedTableBase<dsQuoteEdit.AssistantsRow>
  {
    private DataColumn columnFullName;
    private DataColumn columnUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public AssistantsDataTable()
    {
      this.TableName = "Assistants";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal AssistantsDataTable(DataTable table)
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
    protected AssistantsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FullNameColumn => this.columnFullName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UserGuidColumn => this.columnUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.AssistantsRow this[int index]
    {
      get => (dsQuoteEdit.AssistantsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.AssistantsRowChangeEventHandler AssistantsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.AssistantsRowChangeEventHandler AssistantsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.AssistantsRowChangeEventHandler AssistantsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.AssistantsRowChangeEventHandler AssistantsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddAssistantsRow(dsQuoteEdit.AssistantsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.AssistantsRow AddAssistantsRow(string FullName, Guid UserGuid)
    {
      dsQuoteEdit.AssistantsRow row = (dsQuoteEdit.AssistantsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) FullName,
        (object) UserGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.AssistantsRow FindByUserGuid(Guid UserGuid)
    {
      return (dsQuoteEdit.AssistantsRow) this.Rows.Find(new object[1]
      {
        (object) UserGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.AssistantsDataTable assistantsDataTable = (dsQuoteEdit.AssistantsDataTable) base.Clone();
      assistantsDataTable.InitVars();
      return (DataTable) assistantsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.AssistantsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnFullName = this.Columns["FullName"];
      this.columnUserGuid = this.Columns["UserGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnFullName = new DataColumn("FullName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullName);
      this.columnUserGuid = new DataColumn("UserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEditKey9", new DataColumn[1]
      {
        this.columnUserGuid
      }, true));
      this.columnFullName.ReadOnly = true;
      this.columnUserGuid.AllowDBNull = false;
      this.columnUserGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.AssistantsRow NewAssistantsRow()
    {
      return (dsQuoteEdit.AssistantsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.AssistantsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.AssistantsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AssistantsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.AssistantsRowChangeEventHandler assistantsRowChangedEvent = this.AssistantsRowChangedEvent;
      if (assistantsRowChangedEvent == null)
        return;
      assistantsRowChangedEvent((object) this, new dsQuoteEdit.AssistantsRowChangeEvent((dsQuoteEdit.AssistantsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AssistantsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.AssistantsRowChangeEventHandler rowChangingEvent = this.AssistantsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.AssistantsRowChangeEvent((dsQuoteEdit.AssistantsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AssistantsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.AssistantsRowChangeEventHandler assistantsRowDeletedEvent = this.AssistantsRowDeletedEvent;
      if (assistantsRowDeletedEvent == null)
        return;
      assistantsRowDeletedEvent((object) this, new dsQuoteEdit.AssistantsRowChangeEvent((dsQuoteEdit.AssistantsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AssistantsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.AssistantsRowChangeEventHandler rowDeletingEvent = this.AssistantsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.AssistantsRowChangeEvent((dsQuoteEdit.AssistantsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveAssistantsRow(dsQuoteEdit.AssistantsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (AssistantsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class tblCompanyProgramCodesDataTable : 
    TypedTableBase<dsQuoteEdit.tblCompanyProgramCodesRow>
  {
    private DataColumn columnCompanyLocationGUID;
    private DataColumn columnStateID;
    private DataColumn columnContractEffective;
    private DataColumn columnContractExpiration;
    private DataColumn columnLineGUID;
    private DataColumn columnIssuingOfficeGUID;
    private DataColumn columnProgCode;
    private DataColumn columnProgramID;
    private DataColumn columnGroupCode;
    private DataColumn columnParentLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyProgramCodesDataTable()
    {
      this.TableName = "tblCompanyProgramCodes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyProgramCodesDataTable(DataTable table)
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
    protected tblCompanyProgramCodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLocationGUIDColumn => this.columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ContractEffectiveColumn => this.columnContractEffective;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ContractExpirationColumn => this.columnContractExpiration;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineGUIDColumn => this.columnLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IssuingOfficeGUIDColumn => this.columnIssuingOfficeGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProgCodeColumn => this.columnProgCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProgramIDColumn => this.columnProgramID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GroupCodeColumn => this.columnGroupCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ParentLineGUIDColumn => this.columnParentLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyProgramCodesRow this[int index]
    {
      get => (dsQuoteEdit.tblCompanyProgramCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyProgramCodesRow(dsQuoteEdit.tblCompanyProgramCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyProgramCodesRow AddtblCompanyProgramCodesRow(
      Guid CompanyLocationGUID,
      string StateID,
      DateTime ContractEffective,
      DateTime ContractExpiration,
      Guid LineGUID,
      Guid IssuingOfficeGUID,
      string ProgCode,
      int ProgramID,
      string GroupCode,
      Guid ParentLineGUID)
    {
      dsQuoteEdit.tblCompanyProgramCodesRow row = (dsQuoteEdit.tblCompanyProgramCodesRow) this.NewRow();
      object[] objArray = new object[10]
      {
        (object) CompanyLocationGUID,
        (object) StateID,
        (object) ContractEffective,
        (object) ContractExpiration,
        (object) LineGUID,
        (object) IssuingOfficeGUID,
        (object) ProgCode,
        (object) ProgramID,
        (object) GroupCode,
        (object) ParentLineGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyProgramCodesRow FindByProgramIDProgCodeIssuingOfficeGUIDLineGUIDContractEffectiveStateIDCompanyLocationGUID(
      int ProgramID,
      string ProgCode,
      Guid IssuingOfficeGUID,
      Guid LineGUID,
      DateTime ContractEffective,
      string StateID,
      Guid CompanyLocationGUID)
    {
      return (dsQuoteEdit.tblCompanyProgramCodesRow) this.Rows.Find(new object[7]
      {
        (object) ProgramID,
        (object) ProgCode,
        (object) IssuingOfficeGUID,
        (object) LineGUID,
        (object) ContractEffective,
        (object) StateID,
        (object) CompanyLocationGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.tblCompanyProgramCodesDataTable programCodesDataTable = (dsQuoteEdit.tblCompanyProgramCodesDataTable) base.Clone();
      programCodesDataTable.InitVars();
      return (DataTable) programCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.tblCompanyProgramCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLocationGUID = this.Columns["CompanyLocationGUID"];
      this.columnStateID = this.Columns["StateID"];
      this.columnContractEffective = this.Columns["ContractEffective"];
      this.columnContractExpiration = this.Columns["ContractExpiration"];
      this.columnLineGUID = this.Columns["LineGUID"];
      this.columnIssuingOfficeGUID = this.Columns["IssuingOfficeGUID"];
      this.columnProgCode = this.Columns["ProgCode"];
      this.columnProgramID = this.Columns["ProgramID"];
      this.columnGroupCode = this.Columns["GroupCode"];
      this.columnParentLineGUID = this.Columns["ParentLineGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLocationGUID = new DataColumn("CompanyLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGUID);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnContractEffective = new DataColumn("ContractEffective", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContractEffective);
      this.columnContractExpiration = new DataColumn("ContractExpiration", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContractExpiration);
      this.columnLineGUID = new DataColumn("LineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGUID);
      this.columnIssuingOfficeGUID = new DataColumn("IssuingOfficeGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIssuingOfficeGUID);
      this.columnProgCode = new DataColumn("ProgCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgCode);
      this.columnProgramID = new DataColumn("ProgramID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgramID);
      this.columnGroupCode = new DataColumn("GroupCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGroupCode);
      this.columnParentLineGUID = new DataColumn("ParentLineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParentLineGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[7]
      {
        this.columnProgramID,
        this.columnProgCode,
        this.columnIssuingOfficeGUID,
        this.columnLineGUID,
        this.columnContractEffective,
        this.columnStateID,
        this.columnCompanyLocationGUID
      }, true));
      this.columnCompanyLocationGUID.AllowDBNull = false;
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.MaxLength = 2;
      this.columnContractEffective.AllowDBNull = false;
      this.columnContractExpiration.AllowDBNull = false;
      this.columnLineGUID.AllowDBNull = false;
      this.columnIssuingOfficeGUID.AllowDBNull = false;
      this.columnProgCode.AllowDBNull = false;
      this.columnProgramID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyProgramCodesRow NewtblCompanyProgramCodesRow()
    {
      return (dsQuoteEdit.tblCompanyProgramCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.tblCompanyProgramCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.tblCompanyProgramCodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblCompanyProgramCodesRowChangeEventHandler codesRowChangedEvent = this.tblCompanyProgramCodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsQuoteEdit.tblCompanyProgramCodesRowChangeEvent((dsQuoteEdit.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblCompanyProgramCodesRowChangeEventHandler rowChangingEvent = this.tblCompanyProgramCodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.tblCompanyProgramCodesRowChangeEvent((dsQuoteEdit.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblCompanyProgramCodesRowChangeEventHandler codesRowDeletedEvent = this.tblCompanyProgramCodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsQuoteEdit.tblCompanyProgramCodesRowChangeEvent((dsQuoteEdit.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.tblCompanyProgramCodesRowChangeEventHandler rowDeletingEvent = this.tblCompanyProgramCodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.tblCompanyProgramCodesRowChangeEvent((dsQuoteEdit.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyProgramCodesRow(dsQuoteEdit.tblCompanyProgramCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyProgramCodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class lstNAICSCodesDataTable : TypedTableBase<dsQuoteEdit.lstNAICSCodesRow>
  {
    private DataColumn columnNAICSCode;
    private DataColumn columnNAICSDescription;
    private DataColumn columnSICCode;
    private DataColumn columnSICDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstNAICSCodesDataTable()
    {
      this.TableName = "lstNAICSCodes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstNAICSCodesDataTable(DataTable table)
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
    protected lstNAICSCodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NAICSCodeColumn => this.columnNAICSCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NAICSDescriptionColumn => this.columnNAICSDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SICCodeColumn => this.columnSICCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SICDescriptionColumn => this.columnSICDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstNAICSCodesRow this[int index]
    {
      get => (dsQuoteEdit.lstNAICSCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstNAICSCodesRowChangeEventHandler lstNAICSCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstNAICSCodesRowChangeEventHandler lstNAICSCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstNAICSCodesRowChangeEventHandler lstNAICSCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.lstNAICSCodesRowChangeEventHandler lstNAICSCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstNAICSCodesRow(dsQuoteEdit.lstNAICSCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstNAICSCodesRow AddlstNAICSCodesRow(
      string NAICSCode,
      string NAICSDescription,
      string SICCode,
      string SICDescription)
    {
      dsQuoteEdit.lstNAICSCodesRow row = (dsQuoteEdit.lstNAICSCodesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) NAICSCode,
        (object) NAICSDescription,
        (object) SICCode,
        (object) SICDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstNAICSCodesRow FindByNAICSCodeSICCode(string NAICSCode, string SICCode)
    {
      return (dsQuoteEdit.lstNAICSCodesRow) this.Rows.Find(new object[2]
      {
        (object) NAICSCode,
        (object) SICCode
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.lstNAICSCodesDataTable naicsCodesDataTable = (dsQuoteEdit.lstNAICSCodesDataTable) base.Clone();
      naicsCodesDataTable.InitVars();
      return (DataTable) naicsCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.lstNAICSCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnNAICSCode = this.Columns["NAICSCode"];
      this.columnNAICSDescription = this.Columns["NAICSDescription"];
      this.columnSICCode = this.Columns["SICCode"];
      this.columnSICDescription = this.Columns["SICDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnNAICSCode = new DataColumn("NAICSCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNAICSCode);
      this.columnNAICSDescription = new DataColumn("NAICSDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNAICSDescription);
      this.columnSICCode = new DataColumn("SICCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSICCode);
      this.columnSICDescription = new DataColumn("SICDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSICDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnNAICSCode,
        this.columnSICCode
      }, true));
      this.columnNAICSCode.AllowDBNull = false;
      this.columnNAICSCode.MaxLength = 10;
      this.columnNAICSDescription.AllowDBNull = false;
      this.columnNAICSDescription.Caption = "NAICSDescriptiom";
      this.columnNAICSDescription.MaxLength = 150;
      this.columnSICCode.AllowDBNull = false;
      this.columnSICCode.MaxLength = 4;
      this.columnSICDescription.AllowDBNull = false;
      this.columnSICDescription.MaxLength = 150;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstNAICSCodesRow NewlstNAICSCodesRow()
    {
      return (dsQuoteEdit.lstNAICSCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.lstNAICSCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.lstNAICSCodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNAICSCodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstNAICSCodesRowChangeEventHandler codesRowChangedEvent = this.lstNAICSCodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsQuoteEdit.lstNAICSCodesRowChangeEvent((dsQuoteEdit.lstNAICSCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNAICSCodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstNAICSCodesRowChangeEventHandler rowChangingEvent = this.lstNAICSCodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.lstNAICSCodesRowChangeEvent((dsQuoteEdit.lstNAICSCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNAICSCodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstNAICSCodesRowChangeEventHandler codesRowDeletedEvent = this.lstNAICSCodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsQuoteEdit.lstNAICSCodesRowChangeEvent((dsQuoteEdit.lstNAICSCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNAICSCodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.lstNAICSCodesRowChangeEventHandler rowDeletingEvent = this.lstNAICSCodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.lstNAICSCodesRowChangeEvent((dsQuoteEdit.lstNAICSCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstNAICSCodesRow(dsQuoteEdit.lstNAICSCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstNAICSCodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class dtIssuingOfficeDataTable : TypedTableBase<dsQuoteEdit.dtIssuingOfficeRow>
  {
    private DataColumn columnLocation;
    private DataColumn columnOfficeGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtIssuingOfficeDataTable()
    {
      this.TableName = "dtIssuingOffice";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtIssuingOfficeDataTable(DataTable table)
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
    protected dtIssuingOfficeDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OfficeGuidColumn => this.columnOfficeGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.dtIssuingOfficeRow this[int index]
    {
      get => (dsQuoteEdit.dtIssuingOfficeRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.dtIssuingOfficeRowChangeEventHandler dtIssuingOfficeRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.dtIssuingOfficeRowChangeEventHandler dtIssuingOfficeRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.dtIssuingOfficeRowChangeEventHandler dtIssuingOfficeRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.dtIssuingOfficeRowChangeEventHandler dtIssuingOfficeRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtIssuingOfficeRow(dsQuoteEdit.dtIssuingOfficeRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.dtIssuingOfficeRow AdddtIssuingOfficeRow(string Location, Guid OfficeGuid)
    {
      dsQuoteEdit.dtIssuingOfficeRow row = (dsQuoteEdit.dtIssuingOfficeRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Location,
        (object) OfficeGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.dtIssuingOfficeRow FindByOfficeGuid(Guid OfficeGuid)
    {
      return (dsQuoteEdit.dtIssuingOfficeRow) this.Rows.Find(new object[1]
      {
        (object) OfficeGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.dtIssuingOfficeDataTable issuingOfficeDataTable = (dsQuoteEdit.dtIssuingOfficeDataTable) base.Clone();
      issuingOfficeDataTable.InitVars();
      return (DataTable) issuingOfficeDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.dtIssuingOfficeDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnLocation = this.Columns["Location"];
      this.columnOfficeGuid = this.Columns["OfficeGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.columnOfficeGuid = new DataColumn("OfficeGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnOfficeGuid
      }, true));
      this.columnLocation.AllowDBNull = false;
      this.columnOfficeGuid.AllowDBNull = false;
      this.columnOfficeGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.dtIssuingOfficeRow NewdtIssuingOfficeRow()
    {
      return (dsQuoteEdit.dtIssuingOfficeRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.dtIssuingOfficeRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.dtIssuingOfficeRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtIssuingOfficeRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.dtIssuingOfficeRowChangeEventHandler officeRowChangedEvent = this.dtIssuingOfficeRowChangedEvent;
      if (officeRowChangedEvent == null)
        return;
      officeRowChangedEvent((object) this, new dsQuoteEdit.dtIssuingOfficeRowChangeEvent((dsQuoteEdit.dtIssuingOfficeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtIssuingOfficeRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.dtIssuingOfficeRowChangeEventHandler rowChangingEvent = this.dtIssuingOfficeRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.dtIssuingOfficeRowChangeEvent((dsQuoteEdit.dtIssuingOfficeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtIssuingOfficeRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.dtIssuingOfficeRowChangeEventHandler officeRowDeletedEvent = this.dtIssuingOfficeRowDeletedEvent;
      if (officeRowDeletedEvent == null)
        return;
      officeRowDeletedEvent((object) this, new dsQuoteEdit.dtIssuingOfficeRowChangeEvent((dsQuoteEdit.dtIssuingOfficeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtIssuingOfficeRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.dtIssuingOfficeRowChangeEventHandler rowDeletingEvent = this.dtIssuingOfficeRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.dtIssuingOfficeRowChangeEvent((dsQuoteEdit.dtIssuingOfficeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtIssuingOfficeRow(dsQuoteEdit.dtIssuingOfficeRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtIssuingOfficeDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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
  public class dtRetailerContactsDataTable : TypedTableBase<dsQuoteEdit.dtRetailerContactsRow>
  {
    private DataColumn columnFullName;
    private DataColumn columnProducerContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtRetailerContactsDataTable()
    {
      this.TableName = "dtRetailerContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtRetailerContactsDataTable(DataTable table)
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
    protected dtRetailerContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FullNameColumn => this.columnFullName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerContactGuidColumn => this.columnProducerContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.dtRetailerContactsRow this[int index]
    {
      get => (dsQuoteEdit.dtRetailerContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.dtRetailerContactsRowChangeEventHandler dtRetailerContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.dtRetailerContactsRowChangeEventHandler dtRetailerContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.dtRetailerContactsRowChangeEventHandler dtRetailerContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteEdit.dtRetailerContactsRowChangeEventHandler dtRetailerContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtRetailerContactsRow(dsQuoteEdit.dtRetailerContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.dtRetailerContactsRow AdddtRetailerContactsRow(
      string FullName,
      Guid ProducerContactGuid)
    {
      dsQuoteEdit.dtRetailerContactsRow row = (dsQuoteEdit.dtRetailerContactsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) FullName,
        (object) ProducerContactGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.dtRetailerContactsRow FindByProducerContactGuid(Guid ProducerContactGuid)
    {
      return (dsQuoteEdit.dtRetailerContactsRow) this.Rows.Find(new object[1]
      {
        (object) ProducerContactGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteEdit.dtRetailerContactsDataTable contactsDataTable = (dsQuoteEdit.dtRetailerContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteEdit.dtRetailerContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnFullName = this.Columns["FullName"];
      this.columnProducerContactGuid = this.Columns["ProducerContactGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnFullName = new DataColumn("FullName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullName);
      this.columnProducerContactGuid = new DataColumn("ProducerContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContactGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnProducerContactGuid
      }, true));
      this.columnFullName.ReadOnly = true;
      this.columnProducerContactGuid.AllowDBNull = false;
      this.columnProducerContactGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.dtRetailerContactsRow NewdtRetailerContactsRow()
    {
      return (dsQuoteEdit.dtRetailerContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteEdit.dtRetailerContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteEdit.dtRetailerContactsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRetailerContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.dtRetailerContactsRowChangeEventHandler contactsRowChangedEvent = this.dtRetailerContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsQuoteEdit.dtRetailerContactsRowChangeEvent((dsQuoteEdit.dtRetailerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRetailerContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.dtRetailerContactsRowChangeEventHandler rowChangingEvent = this.dtRetailerContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteEdit.dtRetailerContactsRowChangeEvent((dsQuoteEdit.dtRetailerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRetailerContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.dtRetailerContactsRowChangeEventHandler contactsRowDeletedEvent = this.dtRetailerContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsQuoteEdit.dtRetailerContactsRowChangeEvent((dsQuoteEdit.dtRetailerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRetailerContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteEdit.dtRetailerContactsRowChangeEventHandler rowDeletingEvent = this.dtRetailerContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteEdit.dtRetailerContactsRowChangeEvent((dsQuoteEdit.dtRetailerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtRetailerContactsRow(dsQuoteEdit.dtRetailerContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteEdit dsQuoteEdit = new dsQuoteEdit();
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
        FixedValue = dsQuoteEdit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtRetailerContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsQuoteEdit.GetSchemaSerializable();
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

  public class lstLinesRow : DataRow
  {
    private dsQuoteEdit.lstLinesDataTable tablelstLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstLines = (dsQuoteEdit.lstLinesDataTable) this.Table;
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
    public Guid OfficeGuid
    {
      get
      {
        object obj = this[this.tablelstLines.OfficeGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tablelstLines.OfficeGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LineName
    {
      get => Conversions.ToString(this[this.tablelstLines.LineNameColumn]);
      set => this[this.tablelstLines.LineNameColumn] = (object) value;
    }
  }

  public class lstPolicyTypesRow : DataRow
  {
    private dsQuoteEdit.lstPolicyTypesDataTable tablelstPolicyTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstPolicyTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPolicyTypes = (dsQuoteEdit.lstPolicyTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstPolicyTypes.PolicyTypeIDColumn]);
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
    public bool Hidden
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstPolicyTypes.HiddenColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Hidden' in table 'lstPolicyTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstPolicyTypes.HiddenColumn] = (object) value;
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsHiddenNull() => this.IsNull(this.tablelstPolicyTypes.HiddenColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetHiddenNull()
    {
      this[this.tablelstPolicyTypes.HiddenColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblClientOfficesRow : DataRow
  {
    private dsQuoteEdit.tblClientOfficesDataTable tabletblClientOffices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblClientOfficesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClientOffices = (dsQuoteEdit.tblClientOfficesDataTable) this.Table;
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
    public bool HasChartOfAccounts
    {
      get => Conversions.ToBoolean(this[this.tabletblClientOffices.HasChartOfAccountsColumn]);
      set => this[this.tabletblClientOffices.HasChartOfAccountsColumn] = (object) value;
    }
  }

  public class tblCompanyContactsRow : DataRow
  {
    private dsQuoteEdit.tblCompanyContactsDataTable tabletblCompanyContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyContacts = (dsQuoteEdit.tblCompanyContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Name
    {
      get => Conversions.ToString(this[this.tabletblCompanyContacts.NameColumn]);
      set => this[this.tabletblCompanyContacts.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLocationGuid
    {
      get
      {
        object obj = this[this.tabletblCompanyContacts.CompanyLocationGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyContacts.CompanyLocationGuidColumn] = (object) value;
    }
  }

  public class tblProducerContactsRow : DataRow
  {
    private dsQuoteEdit.tblProducerContactsDataTable tabletblProducerContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblProducerContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerContacts = (dsQuoteEdit.tblProducerContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FullName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerContacts.FullNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FullName' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.FullNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ProducerContactGuid
    {
      get
      {
        object obj = this[this.tabletblProducerContacts.ProducerContactGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducerContacts.ProducerContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFullNameNull() => this.IsNull(this.tabletblProducerContacts.FullNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFullNameNull()
    {
      this[this.tabletblProducerContacts.FullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblQuotesRow : DataRow
  {
    private dsQuoteEdit.tblQuotesDataTable tabletblQuotes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuotesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuotes = (dsQuoteEdit.tblQuotesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        object obj = this[this.tabletblQuotes.QuoteGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuotes.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ControlNo
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuotes.ControlNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ControlNo' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ControlGuid
    {
      get
      {
        object obj = this[this.tabletblQuotes.ControlGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuotes.ControlGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid UnderwriterUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuotes.UnderwriterUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnderwriterUserGuid' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.UnderwriterUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime EffectiveDate
    {
      get => Conversions.ToDate(this[this.tabletblQuotes.EffectiveDateColumn]);
      set => this[this.tabletblQuotes.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime ExpirationDate
    {
      get => Conversions.ToDate(this[this.tabletblQuotes.ExpirationDateColumn]);
      set => this[this.tabletblQuotes.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid QuotingLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuotes.QuotingLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuotingLocationGuid' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.QuotingLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid IssuingLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuotes.IssuingLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IssuingLocationGuid' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.IssuingLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ProducerContactGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuotes.ProducerContactGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerContactGuid' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ProducerContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyTypeID
    {
      get => Conversions.ToInteger(this[this.tabletblQuotes.PolicyTypeIDColumn]);
      set => this[this.tabletblQuotes.PolicyTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateCreated
    {
      get => Conversions.ToDate(this[this.tabletblQuotes.DateCreatedColumn]);
      set => this[this.tabletblQuotes.DateCreatedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid SubmissionGroupGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuotes.SubmissionGroupGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SubmissionGroupGuid' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.SubmissionGroupGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid LineGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuotes.LineGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LineGuid' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.LineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SIC_Code
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.SIC_CodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SIC_Code' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.SIC_CodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuotes.CompanyLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLocationGuid' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.CompanyLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int BillingTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuotes.BillingTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillingTypeID' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.BillingTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int TermsOfPayment
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuotes.TermsOfPaymentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TermsOfPayment' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.TermsOfPaymentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid TACSRUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuotes.TACSRUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TACSRUserGuid' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.TACSRUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime EndorsementEffective
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblQuotes.EndorsementEffectiveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementEffective' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.EndorsementEffectiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EndorsementComment
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.EndorsementCommentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementComment' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.EndorsementCommentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid FinanceCompanyGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuotes.FinanceCompanyGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FinanceCompanyGuid' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.FinanceCompanyGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Retailer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.RetailerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Retailer' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.RetailerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid RetailerGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuotes.RetailerGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RetailerGuid' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.RetailerGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal MinimumEarnedPercentage
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuotes.MinimumEarnedPercentageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MinimumEarnedPercentage' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.MinimumEarnedPercentageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AccountNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.AccountNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AccountNumber' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.AccountNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CostCenterID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuotes.CostCenterIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CostCenterID' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.CostCenterIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int InspectionCompanyID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuotes.InspectionCompanyIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionCompanyID' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.InspectionCompanyIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool QuickQuote
    {
      get => Conversions.ToBoolean(this[this.tabletblQuotes.QuickQuoteColumn]);
      set => this[this.tabletblQuotes.QuickQuoteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public double PreviousPremium
    {
      get
      {
        try
        {
          return Conversions.ToDouble(this[this.tabletblQuotes.PreviousPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PreviousPremium' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.PreviousPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public double TargetPremium
    {
      get
      {
        try
        {
          return Conversions.ToDouble(this[this.tabletblQuotes.TargetPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TargetPremium' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.TargetPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ExpiringPolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.ExpiringPolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpiringPolicyNumber' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.ExpiringPolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string RiskDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.RiskDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RiskDescription' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.RiskDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid UnderwritingAssistantGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuotes.UnderwritingAssistantGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnderwritingAssistantGuid' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.UnderwritingAssistantGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ProducerLocationID
    {
      get => Conversions.ToInteger(this[this.tabletblQuotes.ProducerLocationIDColumn]);
      set => this[this.tabletblQuotes.ProducerLocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid SecProducerContactGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuotes.SecProducerContactGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SecProducerContactGuid' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.SecProducerContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public byte EarnedPremiumTypeID
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabletblQuotes.EarnedPremiumTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EarnedPremiumTypeID' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.EarnedPremiumTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Auditable
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblQuotes.AuditableColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Auditable' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.AuditableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NAICSCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes.NAICSCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NAICSCode' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.NAICSCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RenewalofControlNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuotes.RenewalofControlNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RenewalofControlNum' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.RenewalofControlNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid RenewalofQuoteGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuotes.RenewalofQuoteGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RenewalofQuoteGUID' in table 'tblQuotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes.RenewalofQuoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstSIC_CodesRow lstSIC_CodesRow
    {
      get
      {
        return (dsQuoteEdit.lstSIC_CodesRow) this.GetParentRow(this.Table.ParentRelations["lstSIC_CodestblQuotes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstSIC_CodestblQuotes"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblFin_ExpensePayeesRow tblFin_ExpensePayeesRow
    {
      get
      {
        return (dsQuoteEdit.tblFin_ExpensePayeesRow) this.GetParentRow(this.Table.ParentRelations["tblInspectionCompaniestblQuotes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblInspectionCompaniestblQuotes"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.FinanceCompaniesRow FinanceCompaniesRow
    {
      get
      {
        return (dsQuoteEdit.FinanceCompaniesRow) this.GetParentRow(this.Table.ParentRelations["FinanceCompaniestblQuotes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["FinanceCompaniestblQuotes"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsControlNoNull() => this.IsNull(this.tabletblQuotes.ControlNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetControlNoNull()
    {
      this[this.tabletblQuotes.ControlNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabletblQuotes.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblQuotes.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUnderwriterUserGuidNull()
    {
      return this.IsNull(this.tabletblQuotes.UnderwriterUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUnderwriterUserGuidNull()
    {
      this[this.tabletblQuotes.UnderwriterUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsQuotingLocationGuidNull()
    {
      return this.IsNull(this.tabletblQuotes.QuotingLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetQuotingLocationGuidNull()
    {
      this[this.tabletblQuotes.QuotingLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsIssuingLocationGuidNull()
    {
      return this.IsNull(this.tabletblQuotes.IssuingLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetIssuingLocationGuidNull()
    {
      this[this.tabletblQuotes.IssuingLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerContactGuidNull()
    {
      return this.IsNull(this.tabletblQuotes.ProducerContactGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerContactGuidNull()
    {
      this[this.tabletblQuotes.ProducerContactGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSubmissionGroupGuidNull()
    {
      return this.IsNull(this.tabletblQuotes.SubmissionGroupGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSubmissionGroupGuidNull()
    {
      this[this.tabletblQuotes.SubmissionGroupGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLineGuidNull() => this.IsNull(this.tabletblQuotes.LineGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLineGuidNull()
    {
      this[this.tabletblQuotes.LineGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSIC_CodeNull() => this.IsNull(this.tabletblQuotes.SIC_CodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSIC_CodeNull()
    {
      this[this.tabletblQuotes.SIC_CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyLocationGuidNull()
    {
      return this.IsNull(this.tabletblQuotes.CompanyLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyLocationGuidNull()
    {
      this[this.tabletblQuotes.CompanyLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBillingTypeIDNull() => this.IsNull(this.tabletblQuotes.BillingTypeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBillingTypeIDNull()
    {
      this[this.tabletblQuotes.BillingTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTermsOfPaymentNull() => this.IsNull(this.tabletblQuotes.TermsOfPaymentColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTermsOfPaymentNull()
    {
      this[this.tabletblQuotes.TermsOfPaymentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTACSRUserGuidNull() => this.IsNull(this.tabletblQuotes.TACSRUserGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTACSRUserGuidNull()
    {
      this[this.tabletblQuotes.TACSRUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEndorsementEffectiveNull()
    {
      return this.IsNull(this.tabletblQuotes.EndorsementEffectiveColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEndorsementEffectiveNull()
    {
      this[this.tabletblQuotes.EndorsementEffectiveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEndorsementCommentNull()
    {
      return this.IsNull(this.tabletblQuotes.EndorsementCommentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEndorsementCommentNull()
    {
      this[this.tabletblQuotes.EndorsementCommentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFinanceCompanyGuidNull()
    {
      return this.IsNull(this.tabletblQuotes.FinanceCompanyGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFinanceCompanyGuidNull()
    {
      this[this.tabletblQuotes.FinanceCompanyGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRetailerNull() => this.IsNull(this.tabletblQuotes.RetailerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRetailerNull()
    {
      this[this.tabletblQuotes.RetailerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRetailerGuidNull() => this.IsNull(this.tabletblQuotes.RetailerGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRetailerGuidNull()
    {
      this[this.tabletblQuotes.RetailerGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMinimumEarnedPercentageNull()
    {
      return this.IsNull(this.tabletblQuotes.MinimumEarnedPercentageColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMinimumEarnedPercentageNull()
    {
      this[this.tabletblQuotes.MinimumEarnedPercentageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAccountNumberNull() => this.IsNull(this.tabletblQuotes.AccountNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAccountNumberNull()
    {
      this[this.tabletblQuotes.AccountNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCostCenterIDNull() => this.IsNull(this.tabletblQuotes.CostCenterIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCostCenterIDNull()
    {
      this[this.tabletblQuotes.CostCenterIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInspectionCompanyIDNull()
    {
      return this.IsNull(this.tabletblQuotes.InspectionCompanyIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInspectionCompanyIDNull()
    {
      this[this.tabletblQuotes.InspectionCompanyIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPreviousPremiumNull() => this.IsNull(this.tabletblQuotes.PreviousPremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPreviousPremiumNull()
    {
      this[this.tabletblQuotes.PreviousPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTargetPremiumNull() => this.IsNull(this.tabletblQuotes.TargetPremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTargetPremiumNull()
    {
      this[this.tabletblQuotes.TargetPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsExpiringPolicyNumberNull()
    {
      return this.IsNull(this.tabletblQuotes.ExpiringPolicyNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetExpiringPolicyNumberNull()
    {
      this[this.tabletblQuotes.ExpiringPolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRiskDescriptionNull() => this.IsNull(this.tabletblQuotes.RiskDescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRiskDescriptionNull()
    {
      this[this.tabletblQuotes.RiskDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUnderwritingAssistantGuidNull()
    {
      return this.IsNull(this.tabletblQuotes.UnderwritingAssistantGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUnderwritingAssistantGuidNull()
    {
      this[this.tabletblQuotes.UnderwritingAssistantGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSecProducerContactGuidNull()
    {
      return this.IsNull(this.tabletblQuotes.SecProducerContactGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSecProducerContactGuidNull()
    {
      this[this.tabletblQuotes.SecProducerContactGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEarnedPremiumTypeIDNull()
    {
      return this.IsNull(this.tabletblQuotes.EarnedPremiumTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEarnedPremiumTypeIDNull()
    {
      this[this.tabletblQuotes.EarnedPremiumTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAuditableNull() => this.IsNull(this.tabletblQuotes.AuditableColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAuditableNull()
    {
      this[this.tabletblQuotes.AuditableColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNAICSCodeNull() => this.IsNull(this.tabletblQuotes.NAICSCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNAICSCodeNull()
    {
      this[this.tabletblQuotes.NAICSCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRenewalofControlNumNull()
    {
      return this.IsNull(this.tabletblQuotes.RenewalofControlNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRenewalofControlNumNull()
    {
      this[this.tabletblQuotes.RenewalofControlNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRenewalofQuoteGUIDNull()
    {
      return this.IsNull(this.tabletblQuotes.RenewalofQuoteGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRenewalofQuoteGUIDNull()
    {
      this[this.tabletblQuotes.RenewalofQuoteGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuoteDetailsRow[] GettblQuoteDetailsRows()
    {
      return this.Table.ChildRelations["tblQuotestblQuoteDetails"] != null ? (dsQuoteEdit.tblQuoteDetailsRow[]) this.GetChildRows(this.Table.ChildRelations["tblQuotestblQuoteDetails"]) : new dsQuoteEdit.tblQuoteDetailsRow[0];
    }
  }

  public class lstStatesRow : DataRow
  {
    private dsQuoteEdit.lstStatesDataTable tablelstStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStates = (dsQuoteEdit.lstStatesDataTable) this.Table;
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
    public string StateID
    {
      get => Conversions.ToString(this[this.tablelstStates.StateIDColumn]);
      set => this[this.tablelstStates.StateIDColumn] = (object) value;
    }
  }

  public class tblUsersRow : DataRow
  {
    private dsQuoteEdit.tblUsersDataTable tabletblUsers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblUsersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUsers = (dsQuoteEdit.tblUsersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FullName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUsers.FullNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FullName' in table 'tblUsers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUsers.FullNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid UserGuid
    {
      get
      {
        object obj = this[this.tabletblUsers.UserGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblUsers.UserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFullNameNull() => this.IsNull(this.tabletblUsers.FullNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFullNameNull()
    {
      this[this.tabletblUsers.FullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblCompanyLocationsRow : DataRow
  {
    private dsQuoteEdit.tblCompanyLocationsDataTable tabletblCompanyLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLocations = (dsQuoteEdit.tblCompanyLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyLocations.CompanyLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLocationGuid' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.CompanyLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabletblCompanyLocations.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabletblCompanyLocations.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyLocationGuidNull()
    {
      return this.IsNull(this.tabletblCompanyLocations.CompanyLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyLocationGuidNull()
    {
      this[this.tabletblCompanyLocations.CompanyLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblCompanyLinesRow : DataRow
  {
    private dsQuoteEdit.tblCompanyLinesDataTable tabletblCompanyLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLines = (dsQuoteEdit.tblCompanyLinesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        object obj = this[this.tabletblCompanyLines.CompanyLineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyLines.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLines.NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name' in table 'tblCompanyLines' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLines.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabletblCompanyLines.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabletblCompanyLines.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblQuoteDetailsRow : DataRow
  {
    private dsQuoteEdit.tblQuoteDetailsDataTable tabletblQuoteDetails;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuoteDetailsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteDetails = (dsQuoteEdit.tblQuoteDetailsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        object obj = this[this.tabletblQuoteDetails.QuoteGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteDetails.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        object obj = this[this.tabletblQuoteDetails.CompanyLineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteDetails.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyContactGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuoteDetails.CompanyContactGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyContactGuid' in table 'tblQuoteDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteDetails.CompanyContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid IntermediaryContactGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuoteDetails.IntermediaryContactGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IntermediaryContactGuid' in table 'tblQuoteDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteDetails.IntermediaryContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal CompanyCommission
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteDetails.CompanyCommissionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyCommission' in table 'tblQuoteDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteDetails.CompanyCommissionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal ProducerCommission
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteDetails.ProducerCommissionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerCommission' in table 'tblQuoteDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteDetails.ProducerCommissionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Participation
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteDetails.ParticipationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Participation' in table 'tblQuoteDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteDetails.ParticipationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int TermsOfPayment
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteDetails.TermsOfPaymentColumn]);
      set => this[this.tabletblQuoteDetails.TermsOfPaymentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool UsingAdditiveCommission
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteDetails.UsingAdditiveCommissionColumn]);
      set => this[this.tabletblQuoteDetails.UsingAdditiveCommissionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CompanyLine
    {
      get => Conversions.ToString(this[this.tabletblQuoteDetails.CompanyLineColumn]);
      set => this[this.tabletblQuoteDetails.CompanyLineColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ProgramID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteDetails.ProgramIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProgramID' in table 'tblQuoteDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteDetails.ProgramIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SLA_Number
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteDetails.SLA_NumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SLA_Number' in table 'tblQuoteDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteDetails.SLA_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuotesRow tblQuotesRow
    {
      get
      {
        return (dsQuoteEdit.tblQuotesRow) this.GetParentRow(this.Table.ParentRelations["tblQuotestblQuoteDetails"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblQuotestblQuoteDetails"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyContactGuidNull()
    {
      return this.IsNull(this.tabletblQuoteDetails.CompanyContactGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyContactGuidNull()
    {
      this[this.tabletblQuoteDetails.CompanyContactGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsIntermediaryContactGuidNull()
    {
      return this.IsNull(this.tabletblQuoteDetails.IntermediaryContactGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetIntermediaryContactGuidNull()
    {
      this[this.tabletblQuoteDetails.IntermediaryContactGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyCommissionNull()
    {
      return this.IsNull(this.tabletblQuoteDetails.CompanyCommissionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyCommissionNull()
    {
      this[this.tabletblQuoteDetails.CompanyCommissionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerCommissionNull()
    {
      return this.IsNull(this.tabletblQuoteDetails.ProducerCommissionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerCommissionNull()
    {
      this[this.tabletblQuoteDetails.ProducerCommissionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsParticipationNull() => this.IsNull(this.tabletblQuoteDetails.ParticipationColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetParticipationNull()
    {
      this[this.tabletblQuoteDetails.ParticipationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProgramIDNull() => this.IsNull(this.tabletblQuoteDetails.ProgramIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProgramIDNull()
    {
      this[this.tabletblQuoteDetails.ProgramIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSLA_NumberNull() => this.IsNull(this.tabletblQuoteDetails.SLA_NumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSLA_NumberNull()
    {
      this[this.tabletblQuoteDetails.SLA_NumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstBillingTypesRow : DataRow
  {
    private dsQuoteEdit.lstBillingTypesDataTable tablelstBillingTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstBillingTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstBillingTypes = (dsQuoteEdit.lstBillingTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int BillingTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstBillingTypes.BillingTypeIDColumn]);
      set => this[this.tablelstBillingTypes.BillingTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string BillingType
    {
      get => Conversions.ToString(this[this.tablelstBillingTypes.BillingTypeColumn]);
      set => this[this.tablelstBillingTypes.BillingTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string BillingCode
    {
      get => Conversions.ToString(this[this.tablelstBillingTypes.BillingCodeColumn]);
      set => this[this.tablelstBillingTypes.BillingCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool OnCompanyLine
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstBillingTypes.OnCompanyLineColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OnCompanyLine' in table 'lstBillingTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstBillingTypes.OnCompanyLineColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOnCompanyLineNull() => this.IsNull(this.tablelstBillingTypes.OnCompanyLineColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOnCompanyLineNull()
    {
      this[this.tablelstBillingTypes.OnCompanyLineColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblFactorSetsRow : DataRow
  {
    private dsQuoteEdit.tblFactorSetsDataTable tabletblFactorSets;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblFactorSetsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblFactorSets = (dsQuoteEdit.tblFactorSetsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Hidden
    {
      get => Conversions.ToBoolean(this[this.tabletblFactorSets.HiddenColumn]);
      set => this[this.tabletblFactorSets.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFactorSets.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'tblFactorSets' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFactorSets.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid FactorSetGuid
    {
      get
      {
        object obj = this[this.tabletblFactorSets.FactorSetGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblFactorSets.FactorSetGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Title
    {
      get => Conversions.ToString(this[this.tabletblFactorSets.TitleColumn]);
      set => this[this.tabletblFactorSets.TitleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Memo
    {
      get => Conversions.ToString(this[this.tabletblFactorSets.MemoColumn]);
      set => this[this.tabletblFactorSets.MemoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEffectiveDateNull() => this.IsNull(this.tabletblFactorSets.EffectiveDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tabletblFactorSets.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class TAsRow : DataRow
  {
    private dsQuoteEdit.TAsDataTable tableTAs;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal TAsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTAs = (dsQuoteEdit.TAsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid UserGuid
    {
      get
      {
        object obj = this[this.tableTAs.UserGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTAs.UserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Name
    {
      get => Conversions.ToString(this[this.tableTAs.NameColumn]);
      set => this[this.tableTAs.NameColumn] = (object) value;
    }
  }

  public class FinanceCompaniesRow : DataRow
  {
    private dsQuoteEdit.FinanceCompaniesDataTable tableFinanceCompanies;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal FinanceCompaniesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableFinanceCompanies = (dsQuoteEdit.FinanceCompaniesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid PayeeGuid
    {
      get
      {
        object obj = this[this.tableFinanceCompanies.PayeeGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableFinanceCompanies.PayeeGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PayeeName
    {
      get => Conversions.ToString(this[this.tableFinanceCompanies.PayeeNameColumn]);
      set => this[this.tableFinanceCompanies.PayeeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuotesRow[] GettblQuotesRows()
    {
      return this.Table.ChildRelations["FinanceCompaniestblQuotes"] != null ? (dsQuoteEdit.tblQuotesRow[]) this.GetChildRows(this.Table.ChildRelations["FinanceCompaniestblQuotes"]) : new dsQuoteEdit.tblQuotesRow[0];
    }
  }

  public class tblIntermediaryContactsRow : DataRow
  {
    private dsQuoteEdit.tblIntermediaryContactsDataTable tabletblIntermediaryContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblIntermediaryContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblIntermediaryContacts = (dsQuoteEdit.tblIntermediaryContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid IntermediaryContactGuid
    {
      get
      {
        object obj = this[this.tabletblIntermediaryContacts.IntermediaryContactGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblIntermediaryContacts.IntermediaryContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Name
    {
      get => Conversions.ToString(this[this.tabletblIntermediaryContacts.NameColumn]);
      set => this[this.tabletblIntermediaryContacts.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLocationGuid
    {
      get
      {
        object obj = this[this.tabletblIntermediaryContacts.CompanyLocationGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblIntermediaryContacts.CompanyLocationGuidColumn] = (object) value;
    }
  }

  public class tblFin_ExpensePayeesRow : DataRow
  {
    private dsQuoteEdit.tblFin_ExpensePayeesDataTable tabletblFin_ExpensePayees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblFin_ExpensePayeesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblFin_ExpensePayees = (dsQuoteEdit.tblFin_ExpensePayeesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PayeeID
    {
      get => Conversions.ToInteger(this[this.tabletblFin_ExpensePayees.PayeeIDColumn]);
      set => this[this.tabletblFin_ExpensePayees.PayeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PayeeName
    {
      get => Conversions.ToString(this[this.tabletblFin_ExpensePayees.PayeeNameColumn]);
      set => this[this.tabletblFin_ExpensePayees.PayeeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuotesRow[] GettblQuotesRows()
    {
      return this.Table.ChildRelations["tblInspectionCompaniestblQuotes"] != null ? (dsQuoteEdit.tblQuotesRow[]) this.GetChildRows(this.Table.ChildRelations["tblInspectionCompaniestblQuotes"]) : new dsQuoteEdit.tblQuotesRow[0];
    }
  }

  public class lstSIC_CodesRow : DataRow
  {
    private dsQuoteEdit.lstSIC_CodesDataTable tablelstSIC_Codes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstSIC_CodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstSIC_Codes = (dsQuoteEdit.lstSIC_CodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SIC_Code
    {
      get => Conversions.ToString(this[this.tablelstSIC_Codes.SIC_CodeColumn]);
      set => this[this.tablelstSIC_Codes.SIC_CodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SIC_Description
    {
      get => Conversions.ToString(this[this.tablelstSIC_Codes.SIC_DescriptionColumn]);
      set => this[this.tablelstSIC_Codes.SIC_DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SIC_Family_Description
    {
      get => Conversions.ToString(this[this.tablelstSIC_Codes.SIC_Family_DescriptionColumn]);
      set => this[this.tablelstSIC_Codes.SIC_Family_DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuotesRow[] GettblQuotesRows()
    {
      return this.Table.ChildRelations["lstSIC_CodestblQuotes"] != null ? (dsQuoteEdit.tblQuotesRow[]) this.GetChildRows(this.Table.ChildRelations["lstSIC_CodestblQuotes"]) : new dsQuoteEdit.tblQuotesRow[0];
    }
  }

  public class lstEarnedPremiumTypeRow : DataRow
  {
    private dsQuoteEdit.lstEarnedPremiumTypeDataTable tablelstEarnedPremiumType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstEarnedPremiumTypeRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstEarnedPremiumType = (dsQuoteEdit.lstEarnedPremiumTypeDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public byte ID
    {
      get => Conversions.ToByte(this[this.tablelstEarnedPremiumType.IDColumn]);
      set => this[this.tablelstEarnedPremiumType.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EarnedPremiumType
    {
      get => Conversions.ToString(this[this.tablelstEarnedPremiumType.EarnedPremiumTypeColumn]);
      set => this[this.tablelstEarnedPremiumType.EarnedPremiumTypeColumn] = (object) value;
    }
  }

  public class ExpiringCarriersRow : DataRow
  {
    private dsQuoteEdit.ExpiringCarriersDataTable tableExpiringCarriers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal ExpiringCarriersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableExpiringCarriers = (dsQuoteEdit.ExpiringCarriersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLocationGuid
    {
      get
      {
        object obj = this[this.tableExpiringCarriers.CompanyLocationGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableExpiringCarriers.CompanyLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LocationName
    {
      get => Conversions.ToString(this[this.tableExpiringCarriers.LocationNameColumn]);
      set => this[this.tableExpiringCarriers.LocationNameColumn] = (object) value;
    }
  }

  public class tblQuotes2Row : DataRow
  {
    private dsQuoteEdit.tblQuotes2DataTable tabletblQuotes2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblQuotes2Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuotes2 = (dsQuoteEdit.tblQuotes2DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tabletblQuotes2.QuoteIDColumn]);
      set => this[this.tabletblQuotes2.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ExpiringCompanyLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuotes2.ExpiringCompanyLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpiringCompanyLocationGuid' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.ExpiringCompanyLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool NonRenewed
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblQuotes2.NonRenewedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NonRenewed' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.NonRenewedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int MinimumCancellationDays
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuotes2.MinimumCancellationDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MinimumCancellationDays' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.MinimumCancellationDaysColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Facultative
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblQuotes2.FacultativeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Facultative' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.FacultativeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal ExchangeRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuotes2.ExchangeRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExchangeRate' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.ExchangeRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime NeededByDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblQuotes2.NeededByDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NeededByDate' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.NeededByDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal MinimumEarnedAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuotes2.MinimumEarnedAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MinimumEarnedAmount' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.MinimumEarnedAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal FacultativePercentage
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuotes2.FacultativePercentageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FacultativePercentage' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.FacultativePercentageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string TaxAddress1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes2.TaxAddress1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TaxAddress1' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.TaxAddress1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string TaxAddress2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes2.TaxAddress2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TaxAddress2' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.TaxAddress2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string TaxCity
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes2.TaxCityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TaxCity' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.TaxCityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string TaxState
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes2.TaxStateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TaxState' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.TaxStateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string TaxZip
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes2.TaxZipColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TaxZip' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.TaxZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string TaxCounty
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes2.TaxCountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TaxCounty' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.TaxCountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SettlementCurrencyCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuotes2.SettlementCurrencyCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SettlementCurrencyCode' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.SettlementCurrencyCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid RetailerContactGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuotes2.RetailerContactGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RetailerContactGuid' in table 'tblQuotes2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuotes2.RetailerContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsExpiringCompanyLocationGuidNull()
    {
      return this.IsNull(this.tabletblQuotes2.ExpiringCompanyLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetExpiringCompanyLocationGuidNull()
    {
      this[this.tabletblQuotes2.ExpiringCompanyLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNonRenewedNull() => this.IsNull(this.tabletblQuotes2.NonRenewedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNonRenewedNull()
    {
      this[this.tabletblQuotes2.NonRenewedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMinimumCancellationDaysNull()
    {
      return this.IsNull(this.tabletblQuotes2.MinimumCancellationDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMinimumCancellationDaysNull()
    {
      this[this.tabletblQuotes2.MinimumCancellationDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFacultativeNull() => this.IsNull(this.tabletblQuotes2.FacultativeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFacultativeNull()
    {
      this[this.tabletblQuotes2.FacultativeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsExchangeRateNull() => this.IsNull(this.tabletblQuotes2.ExchangeRateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetExchangeRateNull()
    {
      this[this.tabletblQuotes2.ExchangeRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNeededByDateNull() => this.IsNull(this.tabletblQuotes2.NeededByDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNeededByDateNull()
    {
      this[this.tabletblQuotes2.NeededByDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMinimumEarnedAmountNull()
    {
      return this.IsNull(this.tabletblQuotes2.MinimumEarnedAmountColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMinimumEarnedAmountNull()
    {
      this[this.tabletblQuotes2.MinimumEarnedAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFacultativePercentageNull()
    {
      return this.IsNull(this.tabletblQuotes2.FacultativePercentageColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFacultativePercentageNull()
    {
      this[this.tabletblQuotes2.FacultativePercentageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTaxAddress1Null() => this.IsNull(this.tabletblQuotes2.TaxAddress1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTaxAddress1Null()
    {
      this[this.tabletblQuotes2.TaxAddress1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTaxAddress2Null() => this.IsNull(this.tabletblQuotes2.TaxAddress2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTaxAddress2Null()
    {
      this[this.tabletblQuotes2.TaxAddress2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTaxCityNull() => this.IsNull(this.tabletblQuotes2.TaxCityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTaxCityNull()
    {
      this[this.tabletblQuotes2.TaxCityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTaxStateNull() => this.IsNull(this.tabletblQuotes2.TaxStateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTaxStateNull()
    {
      this[this.tabletblQuotes2.TaxStateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTaxZipNull() => this.IsNull(this.tabletblQuotes2.TaxZipColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTaxZipNull()
    {
      this[this.tabletblQuotes2.TaxZipColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTaxCountyNull() => this.IsNull(this.tabletblQuotes2.TaxCountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTaxCountyNull()
    {
      this[this.tabletblQuotes2.TaxCountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSettlementCurrencyCodeNull()
    {
      return this.IsNull(this.tabletblQuotes2.SettlementCurrencyCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSettlementCurrencyCodeNull()
    {
      this[this.tabletblQuotes2.SettlementCurrencyCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRetailerContactGuidNull()
    {
      return this.IsNull(this.tabletblQuotes2.RetailerContactGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRetailerContactGuidNull()
    {
      this[this.tabletblQuotes2.RetailerContactGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class AssistantsRow : DataRow
  {
    private dsQuoteEdit.AssistantsDataTable tableAssistants;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal AssistantsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAssistants = (dsQuoteEdit.AssistantsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FullName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAssistants.FullNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FullName' in table 'Assistants' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAssistants.FullNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid UserGuid
    {
      get
      {
        object obj = this[this.tableAssistants.UserGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableAssistants.UserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFullNameNull() => this.IsNull(this.tableAssistants.FullNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFullNameNull()
    {
      this[this.tableAssistants.FullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblCompanyProgramCodesRow : DataRow
  {
    private dsQuoteEdit.tblCompanyProgramCodesDataTable tabletblCompanyProgramCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyProgramCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyProgramCodes = (dsQuoteEdit.tblCompanyProgramCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLocationGUID
    {
      get
      {
        object obj = this[this.tabletblCompanyProgramCodes.CompanyLocationGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyProgramCodes.CompanyLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tabletblCompanyProgramCodes.StateIDColumn]);
      set => this[this.tabletblCompanyProgramCodes.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime ContractEffective
    {
      get => Conversions.ToDate(this[this.tabletblCompanyProgramCodes.ContractEffectiveColumn]);
      set => this[this.tabletblCompanyProgramCodes.ContractEffectiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime ContractExpiration
    {
      get => Conversions.ToDate(this[this.tabletblCompanyProgramCodes.ContractExpirationColumn]);
      set => this[this.tabletblCompanyProgramCodes.ContractExpirationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid LineGUID
    {
      get
      {
        object obj = this[this.tabletblCompanyProgramCodes.LineGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyProgramCodes.LineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid IssuingOfficeGUID
    {
      get
      {
        object obj = this[this.tabletblCompanyProgramCodes.IssuingOfficeGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyProgramCodes.IssuingOfficeGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProgCode
    {
      get => Conversions.ToString(this[this.tabletblCompanyProgramCodes.ProgCodeColumn]);
      set => this[this.tabletblCompanyProgramCodes.ProgCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ProgramID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyProgramCodes.ProgramIDColumn]);
      set => this[this.tabletblCompanyProgramCodes.ProgramIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string GroupCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyProgramCodes.GroupCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GroupCode' in table 'tblCompanyProgramCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyProgramCodes.GroupCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ParentLineGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyProgramCodes.ParentLineGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ParentLineGUID' in table 'tblCompanyProgramCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyProgramCodes.ParentLineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGroupCodeNull() => this.IsNull(this.tabletblCompanyProgramCodes.GroupCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGroupCodeNull()
    {
      this[this.tabletblCompanyProgramCodes.GroupCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsParentLineGUIDNull()
    {
      return this.IsNull(this.tabletblCompanyProgramCodes.ParentLineGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetParentLineGUIDNull()
    {
      this[this.tabletblCompanyProgramCodes.ParentLineGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstNAICSCodesRow : DataRow
  {
    private dsQuoteEdit.lstNAICSCodesDataTable tablelstNAICSCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstNAICSCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstNAICSCodes = (dsQuoteEdit.lstNAICSCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NAICSCode
    {
      get => Conversions.ToString(this[this.tablelstNAICSCodes.NAICSCodeColumn]);
      set => this[this.tablelstNAICSCodes.NAICSCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NAICSDescription
    {
      get => Conversions.ToString(this[this.tablelstNAICSCodes.NAICSDescriptionColumn]);
      set => this[this.tablelstNAICSCodes.NAICSDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SICCode
    {
      get => Conversions.ToString(this[this.tablelstNAICSCodes.SICCodeColumn]);
      set => this[this.tablelstNAICSCodes.SICCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SICDescription
    {
      get => Conversions.ToString(this[this.tablelstNAICSCodes.SICDescriptionColumn]);
      set => this[this.tablelstNAICSCodes.SICDescriptionColumn] = (object) value;
    }
  }

  public class dtIssuingOfficeRow : DataRow
  {
    private dsQuoteEdit.dtIssuingOfficeDataTable tabledtIssuingOffice;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtIssuingOfficeRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtIssuingOffice = (dsQuoteEdit.dtIssuingOfficeDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Location
    {
      get => Conversions.ToString(this[this.tabledtIssuingOffice.LocationColumn]);
      set => this[this.tabledtIssuingOffice.LocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid OfficeGuid
    {
      get
      {
        object obj = this[this.tabledtIssuingOffice.OfficeGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabledtIssuingOffice.OfficeGuidColumn] = (object) value;
    }
  }

  public class dtRetailerContactsRow : DataRow
  {
    private dsQuoteEdit.dtRetailerContactsDataTable tabledtRetailerContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtRetailerContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtRetailerContacts = (dsQuoteEdit.dtRetailerContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FullName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtRetailerContacts.FullNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FullName' in table 'dtRetailerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtRetailerContacts.FullNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ProducerContactGuid
    {
      get
      {
        object obj = this[this.tabledtRetailerContacts.ProducerContactGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabledtRetailerContacts.ProducerContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFullNameNull() => this.IsNull(this.tabledtRetailerContacts.FullNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFullNameNull()
    {
      this[this.tabledtRetailerContacts.FullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstLinesRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.lstLinesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstLinesRowChangeEvent(dsQuoteEdit.lstLinesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstLinesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstPolicyTypesRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.lstPolicyTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstPolicyTypesRowChangeEvent(dsQuoteEdit.lstPolicyTypesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstPolicyTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblClientOfficesRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.tblClientOfficesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblClientOfficesRowChangeEvent(dsQuoteEdit.tblClientOfficesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblClientOfficesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyContactsRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.tblCompanyContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyContactsRowChangeEvent(
      dsQuoteEdit.tblCompanyContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblProducerContactsRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.tblProducerContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblProducerContactsRowChangeEvent(
      dsQuoteEdit.tblProducerContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblProducerContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblQuotesRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.tblQuotesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuotesRowChangeEvent(dsQuoteEdit.tblQuotesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuotesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstStatesRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.lstStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstStatesRowChangeEvent(dsQuoteEdit.lstStatesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblUsersRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.tblUsersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblUsersRowChangeEvent(dsQuoteEdit.tblUsersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblUsersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyLocationsRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.tblCompanyLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyLocationsRowChangeEvent(
      dsQuoteEdit.tblCompanyLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyLinesRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.tblCompanyLinesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyLinesRowChangeEvent(dsQuoteEdit.tblCompanyLinesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyLinesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblQuoteDetailsRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.tblQuoteDetailsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuoteDetailsRowChangeEvent(dsQuoteEdit.tblQuoteDetailsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuoteDetailsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstBillingTypesRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.lstBillingTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstBillingTypesRowChangeEvent(dsQuoteEdit.lstBillingTypesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstBillingTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblFactorSetsRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.tblFactorSetsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblFactorSetsRowChangeEvent(dsQuoteEdit.tblFactorSetsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblFactorSetsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class TAsRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.TAsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public TAsRowChangeEvent(dsQuoteEdit.TAsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.TAsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class FinanceCompaniesRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.FinanceCompaniesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public FinanceCompaniesRowChangeEvent(dsQuoteEdit.FinanceCompaniesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.FinanceCompaniesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblIntermediaryContactsRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.tblIntermediaryContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblIntermediaryContactsRowChangeEvent(
      dsQuoteEdit.tblIntermediaryContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblIntermediaryContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblFin_ExpensePayeesRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.tblFin_ExpensePayeesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblFin_ExpensePayeesRowChangeEvent(
      dsQuoteEdit.tblFin_ExpensePayeesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblFin_ExpensePayeesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstSIC_CodesRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.lstSIC_CodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstSIC_CodesRowChangeEvent(dsQuoteEdit.lstSIC_CodesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstSIC_CodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstEarnedPremiumTypeRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.lstEarnedPremiumTypeRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstEarnedPremiumTypeRowChangeEvent(
      dsQuoteEdit.lstEarnedPremiumTypeRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstEarnedPremiumTypeRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class ExpiringCarriersRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.ExpiringCarriersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public ExpiringCarriersRowChangeEvent(dsQuoteEdit.ExpiringCarriersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.ExpiringCarriersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblQuotes2RowChangeEvent : EventArgs
  {
    private dsQuoteEdit.tblQuotes2Row eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblQuotes2RowChangeEvent(dsQuoteEdit.tblQuotes2Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblQuotes2Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class AssistantsRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.AssistantsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public AssistantsRowChangeEvent(dsQuoteEdit.AssistantsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.AssistantsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyProgramCodesRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.tblCompanyProgramCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyProgramCodesRowChangeEvent(
      dsQuoteEdit.tblCompanyProgramCodesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.tblCompanyProgramCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstNAICSCodesRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.lstNAICSCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstNAICSCodesRowChangeEvent(dsQuoteEdit.lstNAICSCodesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.lstNAICSCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtIssuingOfficeRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.dtIssuingOfficeRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtIssuingOfficeRowChangeEvent(dsQuoteEdit.dtIssuingOfficeRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.dtIssuingOfficeRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtRetailerContactsRowChangeEvent : EventArgs
  {
    private dsQuoteEdit.dtRetailerContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtRetailerContactsRowChangeEvent(
      dsQuoteEdit.dtRetailerContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteEdit.dtRetailerContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
