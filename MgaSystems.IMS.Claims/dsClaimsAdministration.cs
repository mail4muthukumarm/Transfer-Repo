// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.dsClaimsAdministration
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Claims;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsClaimsAdministration")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsClaimsAdministration : DataSet
{
  private dsClaimsAdministration.AccidentTypesDataTable tableAccidentTypes;
  private dsClaimsAdministration.CoverageTypesDataTable tableCoverageTypes;
  private dsClaimsAdministration.CatastropheCodesDataTable tableCatastropheCodes;
  private dsClaimsAdministration.LossTypesDataTable tableLossTypes;
  private dsClaimsAdministration.ManagedCareFacilitiesDataTable tableManagedCareFacilities;
  private dsClaimsAdministration.ManagedCareAddressesDataTable tableManagedCareAddresses;
  private dsClaimsAdministration.ManagedCareAddressPhoneNumbersDataTable tableManagedCareAddressPhoneNumbers;
  private dsClaimsAdministration.ReservePaymentSubTypesDataTable tableReservePaymentSubTypes;
  private dsClaimsAdministration.ReservePaymentTypesDataTable tableReservePaymentTypes;
  private dsClaimsAdministration.SettlementTypesDataTable tableSettlementTypes;
  private dsClaimsAdministration.CoverageTypeDescriptionsDataTable tableCoverageTypeDescriptions;
  private dsClaimsAdministration.OutsideAdjustersDataTable tableOutsideAdjusters;
  private dsClaimsAdministration.OutsideAdjusterAddressesDataTable tableOutsideAdjusterAddresses;
  private dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersDataTable tableOutsideAdjusterAddressPhoneNumbers;
  private DataRelation relationManagedCareAddresses_ManagedCareFacilities;
  private DataRelation relationManagedCareAddresses_ManagedCareAddressPhoneNumbers;
  private DataRelation relationOutsideAdjusterAddresses_OutsideAdjusters;
  private DataRelation relationOutsideAdjusterAddresses_OutsideAdjusterAddressPhoneNumbers;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public dsClaimsAdministration()
  {
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected dsClaimsAdministration(SerializationInfo info, StreamingContext context)
    : base(info, context, false)
  {
    if (this.IsBinarySerialized(info, context))
    {
      this.InitVars(false);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      this.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }
    else
    {
      string s = (string) info.GetValue("XmlSchema", typeof (string));
      if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
      {
        DataSet dataSet = new DataSet();
        dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        if (dataSet.Tables[nameof (AccidentTypes)] != null)
          base.Tables.Add((DataTable) new dsClaimsAdministration.AccidentTypesDataTable(dataSet.Tables[nameof (AccidentTypes)]));
        if (dataSet.Tables[nameof (CoverageTypes)] != null)
          base.Tables.Add((DataTable) new dsClaimsAdministration.CoverageTypesDataTable(dataSet.Tables[nameof (CoverageTypes)]));
        if (dataSet.Tables[nameof (CatastropheCodes)] != null)
          base.Tables.Add((DataTable) new dsClaimsAdministration.CatastropheCodesDataTable(dataSet.Tables[nameof (CatastropheCodes)]));
        if (dataSet.Tables[nameof (LossTypes)] != null)
          base.Tables.Add((DataTable) new dsClaimsAdministration.LossTypesDataTable(dataSet.Tables[nameof (LossTypes)]));
        if (dataSet.Tables[nameof (ManagedCareFacilities)] != null)
          base.Tables.Add((DataTable) new dsClaimsAdministration.ManagedCareFacilitiesDataTable(dataSet.Tables[nameof (ManagedCareFacilities)]));
        if (dataSet.Tables[nameof (ManagedCareAddresses)] != null)
          base.Tables.Add((DataTable) new dsClaimsAdministration.ManagedCareAddressesDataTable(dataSet.Tables[nameof (ManagedCareAddresses)]));
        if (dataSet.Tables[nameof (ManagedCareAddressPhoneNumbers)] != null)
          base.Tables.Add((DataTable) new dsClaimsAdministration.ManagedCareAddressPhoneNumbersDataTable(dataSet.Tables[nameof (ManagedCareAddressPhoneNumbers)]));
        if (dataSet.Tables[nameof (ReservePaymentSubTypes)] != null)
          base.Tables.Add((DataTable) new dsClaimsAdministration.ReservePaymentSubTypesDataTable(dataSet.Tables[nameof (ReservePaymentSubTypes)]));
        if (dataSet.Tables[nameof (ReservePaymentTypes)] != null)
          base.Tables.Add((DataTable) new dsClaimsAdministration.ReservePaymentTypesDataTable(dataSet.Tables[nameof (ReservePaymentTypes)]));
        if (dataSet.Tables[nameof (SettlementTypes)] != null)
          base.Tables.Add((DataTable) new dsClaimsAdministration.SettlementTypesDataTable(dataSet.Tables[nameof (SettlementTypes)]));
        if (dataSet.Tables[nameof (CoverageTypeDescriptions)] != null)
          base.Tables.Add((DataTable) new dsClaimsAdministration.CoverageTypeDescriptionsDataTable(dataSet.Tables[nameof (CoverageTypeDescriptions)]));
        if (dataSet.Tables[nameof (OutsideAdjusters)] != null)
          base.Tables.Add((DataTable) new dsClaimsAdministration.OutsideAdjustersDataTable(dataSet.Tables[nameof (OutsideAdjusters)]));
        if (dataSet.Tables[nameof (OutsideAdjusterAddresses)] != null)
          base.Tables.Add((DataTable) new dsClaimsAdministration.OutsideAdjusterAddressesDataTable(dataSet.Tables[nameof (OutsideAdjusterAddresses)]));
        if (dataSet.Tables[nameof (OutsideAdjusterAddressPhoneNumbers)] != null)
          base.Tables.Add((DataTable) new dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersDataTable(dataSet.Tables[nameof (OutsideAdjusterAddressPhoneNumbers)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsAdministration.AccidentTypesDataTable AccidentTypes => this.tableAccidentTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsAdministration.CoverageTypesDataTable CoverageTypes => this.tableCoverageTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsAdministration.CatastropheCodesDataTable CatastropheCodes
  {
    get => this.tableCatastropheCodes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsAdministration.LossTypesDataTable LossTypes => this.tableLossTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsAdministration.ManagedCareFacilitiesDataTable ManagedCareFacilities
  {
    get => this.tableManagedCareFacilities;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsAdministration.ManagedCareAddressesDataTable ManagedCareAddresses
  {
    get => this.tableManagedCareAddresses;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsAdministration.ManagedCareAddressPhoneNumbersDataTable ManagedCareAddressPhoneNumbers
  {
    get => this.tableManagedCareAddressPhoneNumbers;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsAdministration.ReservePaymentSubTypesDataTable ReservePaymentSubTypes
  {
    get => this.tableReservePaymentSubTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsAdministration.ReservePaymentTypesDataTable ReservePaymentTypes
  {
    get => this.tableReservePaymentTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsAdministration.SettlementTypesDataTable SettlementTypes
  {
    get => this.tableSettlementTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsAdministration.CoverageTypeDescriptionsDataTable CoverageTypeDescriptions
  {
    get => this.tableCoverageTypeDescriptions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsAdministration.OutsideAdjustersDataTable OutsideAdjusters
  {
    get => this.tableOutsideAdjusters;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsAdministration.OutsideAdjusterAddressesDataTable OutsideAdjusterAddresses
  {
    get => this.tableOutsideAdjusterAddresses;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersDataTable OutsideAdjusterAddressPhoneNumbers
  {
    get => this.tableOutsideAdjusterAddressPhoneNumbers;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public override DataSet Clone()
  {
    dsClaimsAdministration claimsAdministration = (dsClaimsAdministration) base.Clone();
    claimsAdministration.InitVars();
    claimsAdministration.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) claimsAdministration;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["AccidentTypes"] != null)
        base.Tables.Add((DataTable) new dsClaimsAdministration.AccidentTypesDataTable(dataSet.Tables["AccidentTypes"]));
      if (dataSet.Tables["CoverageTypes"] != null)
        base.Tables.Add((DataTable) new dsClaimsAdministration.CoverageTypesDataTable(dataSet.Tables["CoverageTypes"]));
      if (dataSet.Tables["CatastropheCodes"] != null)
        base.Tables.Add((DataTable) new dsClaimsAdministration.CatastropheCodesDataTable(dataSet.Tables["CatastropheCodes"]));
      if (dataSet.Tables["LossTypes"] != null)
        base.Tables.Add((DataTable) new dsClaimsAdministration.LossTypesDataTable(dataSet.Tables["LossTypes"]));
      if (dataSet.Tables["ManagedCareFacilities"] != null)
        base.Tables.Add((DataTable) new dsClaimsAdministration.ManagedCareFacilitiesDataTable(dataSet.Tables["ManagedCareFacilities"]));
      if (dataSet.Tables["ManagedCareAddresses"] != null)
        base.Tables.Add((DataTable) new dsClaimsAdministration.ManagedCareAddressesDataTable(dataSet.Tables["ManagedCareAddresses"]));
      if (dataSet.Tables["ManagedCareAddressPhoneNumbers"] != null)
        base.Tables.Add((DataTable) new dsClaimsAdministration.ManagedCareAddressPhoneNumbersDataTable(dataSet.Tables["ManagedCareAddressPhoneNumbers"]));
      if (dataSet.Tables["ReservePaymentSubTypes"] != null)
        base.Tables.Add((DataTable) new dsClaimsAdministration.ReservePaymentSubTypesDataTable(dataSet.Tables["ReservePaymentSubTypes"]));
      if (dataSet.Tables["ReservePaymentTypes"] != null)
        base.Tables.Add((DataTable) new dsClaimsAdministration.ReservePaymentTypesDataTable(dataSet.Tables["ReservePaymentTypes"]));
      if (dataSet.Tables["SettlementTypes"] != null)
        base.Tables.Add((DataTable) new dsClaimsAdministration.SettlementTypesDataTable(dataSet.Tables["SettlementTypes"]));
      if (dataSet.Tables["CoverageTypeDescriptions"] != null)
        base.Tables.Add((DataTable) new dsClaimsAdministration.CoverageTypeDescriptionsDataTable(dataSet.Tables["CoverageTypeDescriptions"]));
      if (dataSet.Tables["OutsideAdjusters"] != null)
        base.Tables.Add((DataTable) new dsClaimsAdministration.OutsideAdjustersDataTable(dataSet.Tables["OutsideAdjusters"]));
      if (dataSet.Tables["OutsideAdjusterAddresses"] != null)
        base.Tables.Add((DataTable) new dsClaimsAdministration.OutsideAdjusterAddressesDataTable(dataSet.Tables["OutsideAdjusterAddresses"]));
      if (dataSet.Tables["OutsideAdjusterAddressPhoneNumbers"] != null)
        base.Tables.Add((DataTable) new dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersDataTable(dataSet.Tables["OutsideAdjusterAddressPhoneNumbers"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tableAccidentTypes = (dsClaimsAdministration.AccidentTypesDataTable) base.Tables["AccidentTypes"];
    if (initTable && this.tableAccidentTypes != null)
      this.tableAccidentTypes.InitVars();
    this.tableCoverageTypes = (dsClaimsAdministration.CoverageTypesDataTable) base.Tables["CoverageTypes"];
    if (initTable && this.tableCoverageTypes != null)
      this.tableCoverageTypes.InitVars();
    this.tableCatastropheCodes = (dsClaimsAdministration.CatastropheCodesDataTable) base.Tables["CatastropheCodes"];
    if (initTable && this.tableCatastropheCodes != null)
      this.tableCatastropheCodes.InitVars();
    this.tableLossTypes = (dsClaimsAdministration.LossTypesDataTable) base.Tables["LossTypes"];
    if (initTable && this.tableLossTypes != null)
      this.tableLossTypes.InitVars();
    this.tableManagedCareFacilities = (dsClaimsAdministration.ManagedCareFacilitiesDataTable) base.Tables["ManagedCareFacilities"];
    if (initTable && this.tableManagedCareFacilities != null)
      this.tableManagedCareFacilities.InitVars();
    this.tableManagedCareAddresses = (dsClaimsAdministration.ManagedCareAddressesDataTable) base.Tables["ManagedCareAddresses"];
    if (initTable && this.tableManagedCareAddresses != null)
      this.tableManagedCareAddresses.InitVars();
    this.tableManagedCareAddressPhoneNumbers = (dsClaimsAdministration.ManagedCareAddressPhoneNumbersDataTable) base.Tables["ManagedCareAddressPhoneNumbers"];
    if (initTable && this.tableManagedCareAddressPhoneNumbers != null)
      this.tableManagedCareAddressPhoneNumbers.InitVars();
    this.tableReservePaymentSubTypes = (dsClaimsAdministration.ReservePaymentSubTypesDataTable) base.Tables["ReservePaymentSubTypes"];
    if (initTable && this.tableReservePaymentSubTypes != null)
      this.tableReservePaymentSubTypes.InitVars();
    this.tableReservePaymentTypes = (dsClaimsAdministration.ReservePaymentTypesDataTable) base.Tables["ReservePaymentTypes"];
    if (initTable && this.tableReservePaymentTypes != null)
      this.tableReservePaymentTypes.InitVars();
    this.tableSettlementTypes = (dsClaimsAdministration.SettlementTypesDataTable) base.Tables["SettlementTypes"];
    if (initTable && this.tableSettlementTypes != null)
      this.tableSettlementTypes.InitVars();
    this.tableCoverageTypeDescriptions = (dsClaimsAdministration.CoverageTypeDescriptionsDataTable) base.Tables["CoverageTypeDescriptions"];
    if (initTable && this.tableCoverageTypeDescriptions != null)
      this.tableCoverageTypeDescriptions.InitVars();
    this.tableOutsideAdjusters = (dsClaimsAdministration.OutsideAdjustersDataTable) base.Tables["OutsideAdjusters"];
    if (initTable && this.tableOutsideAdjusters != null)
      this.tableOutsideAdjusters.InitVars();
    this.tableOutsideAdjusterAddresses = (dsClaimsAdministration.OutsideAdjusterAddressesDataTable) base.Tables["OutsideAdjusterAddresses"];
    if (initTable && this.tableOutsideAdjusterAddresses != null)
      this.tableOutsideAdjusterAddresses.InitVars();
    this.tableOutsideAdjusterAddressPhoneNumbers = (dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersDataTable) base.Tables["OutsideAdjusterAddressPhoneNumbers"];
    if (initTable && this.tableOutsideAdjusterAddressPhoneNumbers != null)
      this.tableOutsideAdjusterAddressPhoneNumbers.InitVars();
    this.relationManagedCareAddresses_ManagedCareFacilities = this.Relations["ManagedCareAddresses_ManagedCareFacilities"];
    this.relationManagedCareAddresses_ManagedCareAddressPhoneNumbers = this.Relations["ManagedCareAddresses_ManagedCareAddressPhoneNumbers"];
    this.relationOutsideAdjusterAddresses_OutsideAdjusters = this.Relations["OutsideAdjusterAddresses_OutsideAdjusters"];
    this.relationOutsideAdjusterAddresses_OutsideAdjusterAddressPhoneNumbers = this.Relations["OutsideAdjusterAddresses_OutsideAdjusterAddressPhoneNumbers"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsClaimsAdministration);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsClaimsAdministration.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableAccidentTypes = new dsClaimsAdministration.AccidentTypesDataTable();
    base.Tables.Add((DataTable) this.tableAccidentTypes);
    this.tableCoverageTypes = new dsClaimsAdministration.CoverageTypesDataTable();
    base.Tables.Add((DataTable) this.tableCoverageTypes);
    this.tableCatastropheCodes = new dsClaimsAdministration.CatastropheCodesDataTable();
    base.Tables.Add((DataTable) this.tableCatastropheCodes);
    this.tableLossTypes = new dsClaimsAdministration.LossTypesDataTable();
    base.Tables.Add((DataTable) this.tableLossTypes);
    this.tableManagedCareFacilities = new dsClaimsAdministration.ManagedCareFacilitiesDataTable();
    base.Tables.Add((DataTable) this.tableManagedCareFacilities);
    this.tableManagedCareAddresses = new dsClaimsAdministration.ManagedCareAddressesDataTable();
    base.Tables.Add((DataTable) this.tableManagedCareAddresses);
    this.tableManagedCareAddressPhoneNumbers = new dsClaimsAdministration.ManagedCareAddressPhoneNumbersDataTable();
    base.Tables.Add((DataTable) this.tableManagedCareAddressPhoneNumbers);
    this.tableReservePaymentSubTypes = new dsClaimsAdministration.ReservePaymentSubTypesDataTable();
    base.Tables.Add((DataTable) this.tableReservePaymentSubTypes);
    this.tableReservePaymentTypes = new dsClaimsAdministration.ReservePaymentTypesDataTable();
    base.Tables.Add((DataTable) this.tableReservePaymentTypes);
    this.tableSettlementTypes = new dsClaimsAdministration.SettlementTypesDataTable();
    base.Tables.Add((DataTable) this.tableSettlementTypes);
    this.tableCoverageTypeDescriptions = new dsClaimsAdministration.CoverageTypeDescriptionsDataTable();
    base.Tables.Add((DataTable) this.tableCoverageTypeDescriptions);
    this.tableOutsideAdjusters = new dsClaimsAdministration.OutsideAdjustersDataTable();
    base.Tables.Add((DataTable) this.tableOutsideAdjusters);
    this.tableOutsideAdjusterAddresses = new dsClaimsAdministration.OutsideAdjusterAddressesDataTable();
    base.Tables.Add((DataTable) this.tableOutsideAdjusterAddresses);
    this.tableOutsideAdjusterAddressPhoneNumbers = new dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersDataTable();
    base.Tables.Add((DataTable) this.tableOutsideAdjusterAddressPhoneNumbers);
    this.relationManagedCareAddresses_ManagedCareFacilities = new DataRelation("ManagedCareAddresses_ManagedCareFacilities", new DataColumn[1]
    {
      this.tableManagedCareAddresses.AddressIdColumn
    }, new DataColumn[1]
    {
      this.tableManagedCareFacilities.ManagedCareIdColumn
    }, false);
    this.Relations.Add(this.relationManagedCareAddresses_ManagedCareFacilities);
    this.relationManagedCareAddresses_ManagedCareAddressPhoneNumbers = new DataRelation("ManagedCareAddresses_ManagedCareAddressPhoneNumbers", new DataColumn[1]
    {
      this.tableManagedCareAddresses.AddressIdColumn
    }, new DataColumn[1]
    {
      this.tableManagedCareAddressPhoneNumbers.PhoneNumberIdColumn
    }, false);
    this.Relations.Add(this.relationManagedCareAddresses_ManagedCareAddressPhoneNumbers);
    this.relationOutsideAdjusterAddresses_OutsideAdjusters = new DataRelation("OutsideAdjusterAddresses_OutsideAdjusters", new DataColumn[1]
    {
      this.tableOutsideAdjusterAddresses.AddressIdColumn
    }, new DataColumn[1]
    {
      this.tableOutsideAdjusters.AddressIdColumn
    }, false);
    this.Relations.Add(this.relationOutsideAdjusterAddresses_OutsideAdjusters);
    this.relationOutsideAdjusterAddresses_OutsideAdjusterAddressPhoneNumbers = new DataRelation("OutsideAdjusterAddresses_OutsideAdjusterAddressPhoneNumbers", new DataColumn[1]
    {
      this.tableOutsideAdjusterAddresses.AddressIdColumn
    }, new DataColumn[1]
    {
      this.tableOutsideAdjusterAddressPhoneNumbers.AddressIdColumn
    }, false);
    this.Relations.Add(this.relationOutsideAdjusterAddresses_OutsideAdjusterAddressPhoneNumbers);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeAccidentTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeCoverageTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeCatastropheCodes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeLossTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeManagedCareFacilities() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeManagedCareAddresses() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeManagedCareAddressPhoneNumbers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeReservePaymentSubTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeReservePaymentTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeSettlementTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeCoverageTypeDescriptions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeOutsideAdjusters() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeOutsideAdjusterAddresses() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeOutsideAdjusterAddressPhoneNumbers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsClaimsAdministration claimsAdministration = new dsClaimsAdministration();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = claimsAdministration.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = claimsAdministration.GetSchemaSerializable();
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
              return typedDataSetSchema;
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
    return typedDataSetSchema;
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class OutsideAdjustersDataTable : TypedTableBase<dsClaimsAdministration.OutsideAdjustersRow>
  {
    private DataColumn columnAdjusterGuid;
    private DataColumn columnOutsideAdjuster;
    private DataColumn columnCompany;
    private DataColumn columnFirstName;
    private DataColumn columnMiddleName;
    private DataColumn columnLastName;
    private DataColumn columnAddressId;
    private DataColumn columnEmailAddress;
    private DataColumn columnSSNFEIN;
    private DataColumn columnEntityType;
    private DataColumn columnEnteredByUserGuid;
    private DataColumn columnEnteredOn;
    private DataColumn columnModifiedByUserGuid;
    private DataColumn columnModifiedOn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public OutsideAdjustersDataTable()
    {
      this.TableName = "OutsideAdjusters";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal OutsideAdjustersDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected OutsideAdjustersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AdjusterGuidColumn => this.columnAdjusterGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn OutsideAdjusterColumn => this.columnOutsideAdjuster;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CompanyColumn => this.columnCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FirstNameColumn => this.columnFirstName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn MiddleNameColumn => this.columnMiddleName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn LastNameColumn => this.columnLastName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AddressIdColumn => this.columnAddressId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EmailAddressColumn => this.columnEmailAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn SSNFEINColumn => this.columnSSNFEIN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EntityTypeColumn => this.columnEntityType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EnteredByUserGuidColumn => this.columnEnteredByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EnteredOnColumn => this.columnEnteredOn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ModifiedByUserGuidColumn => this.columnModifiedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ModifiedOnColumn => this.columnModifiedOn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjustersRow this[int index]
    {
      get => (dsClaimsAdministration.OutsideAdjustersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.OutsideAdjustersRowChangeEventHandler OutsideAdjustersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.OutsideAdjustersRowChangeEventHandler OutsideAdjustersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.OutsideAdjustersRowChangeEventHandler OutsideAdjustersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.OutsideAdjustersRowChangeEventHandler OutsideAdjustersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddOutsideAdjustersRow(dsClaimsAdministration.OutsideAdjustersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjustersRow AddOutsideAdjustersRow(
      Guid AdjusterGuid,
      string OutsideAdjuster,
      string Company,
      string FirstName,
      string MiddleName,
      string LastName,
      dsClaimsAdministration.OutsideAdjusterAddressesRow parentOutsideAdjusterAddressesRowByOutsideAdjusterAddresses_OutsideAdjusters,
      string EmailAddress,
      string SSNFEIN,
      string EntityType,
      Guid EnteredByUserGuid,
      DateTime EnteredOn,
      Guid ModifiedByUserGuid,
      DateTime ModifiedOn)
    {
      dsClaimsAdministration.OutsideAdjustersRow row = (dsClaimsAdministration.OutsideAdjustersRow) this.NewRow();
      object[] objArray = new object[14]
      {
        (object) AdjusterGuid,
        (object) OutsideAdjuster,
        (object) Company,
        (object) FirstName,
        (object) MiddleName,
        (object) LastName,
        null,
        (object) EmailAddress,
        (object) SSNFEIN,
        (object) EntityType,
        (object) EnteredByUserGuid,
        (object) EnteredOn,
        (object) ModifiedByUserGuid,
        (object) ModifiedOn
      };
      if (parentOutsideAdjusterAddressesRowByOutsideAdjusterAddresses_OutsideAdjusters != null)
        objArray[6] = parentOutsideAdjusterAddressesRowByOutsideAdjusterAddresses_OutsideAdjusters[0];
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjustersRow FindByAdjusterGuid(Guid AdjusterGuid)
    {
      return (dsClaimsAdministration.OutsideAdjustersRow) this.Rows.Find(new object[1]
      {
        (object) AdjusterGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsAdministration.OutsideAdjustersDataTable adjustersDataTable = (dsClaimsAdministration.OutsideAdjustersDataTable) base.Clone();
      adjustersDataTable.InitVars();
      return (DataTable) adjustersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsAdministration.OutsideAdjustersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnAdjusterGuid = this.Columns["AdjusterGuid"];
      this.columnOutsideAdjuster = this.Columns["OutsideAdjuster"];
      this.columnCompany = this.Columns["Company"];
      this.columnFirstName = this.Columns["FirstName"];
      this.columnMiddleName = this.Columns["MiddleName"];
      this.columnLastName = this.Columns["LastName"];
      this.columnAddressId = this.Columns["AddressId"];
      this.columnEmailAddress = this.Columns["EmailAddress"];
      this.columnSSNFEIN = this.Columns["SSNFEIN"];
      this.columnEntityType = this.Columns["EntityType"];
      this.columnEnteredByUserGuid = this.Columns["EnteredByUserGuid"];
      this.columnEnteredOn = this.Columns["EnteredOn"];
      this.columnModifiedByUserGuid = this.Columns["ModifiedByUserGuid"];
      this.columnModifiedOn = this.Columns["ModifiedOn"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnAdjusterGuid = new DataColumn("AdjusterGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdjusterGuid);
      this.columnOutsideAdjuster = new DataColumn("OutsideAdjuster", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOutsideAdjuster);
      this.columnCompany = new DataColumn("Company", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany);
      this.columnFirstName = new DataColumn("FirstName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirstName);
      this.columnMiddleName = new DataColumn("MiddleName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMiddleName);
      this.columnLastName = new DataColumn("LastName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLastName);
      this.columnAddressId = new DataColumn("AddressId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddressId);
      this.columnEmailAddress = new DataColumn("EmailAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmailAddress);
      this.columnSSNFEIN = new DataColumn("SSNFEIN", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSSNFEIN);
      this.columnEntityType = new DataColumn("EntityType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityType);
      this.columnEnteredByUserGuid = new DataColumn("EnteredByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEnteredByUserGuid);
      this.columnEnteredOn = new DataColumn("EnteredOn", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEnteredOn);
      this.columnModifiedByUserGuid = new DataColumn("ModifiedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModifiedByUserGuid);
      this.columnModifiedOn = new DataColumn("ModifiedOn", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModifiedOn);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnAdjusterGuid
      }, true));
      this.columnAdjusterGuid.AllowDBNull = false;
      this.columnAdjusterGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjustersRow NewOutsideAdjustersRow()
    {
      return (dsClaimsAdministration.OutsideAdjustersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsAdministration.OutsideAdjustersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsClaimsAdministration.OutsideAdjustersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.OutsideAdjustersRowChanged == null)
        return;
      this.OutsideAdjustersRowChanged((object) this, new dsClaimsAdministration.OutsideAdjustersRowChangeEvent((dsClaimsAdministration.OutsideAdjustersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.OutsideAdjustersRowChanging == null)
        return;
      this.OutsideAdjustersRowChanging((object) this, new dsClaimsAdministration.OutsideAdjustersRowChangeEvent((dsClaimsAdministration.OutsideAdjustersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.OutsideAdjustersRowDeleted == null)
        return;
      this.OutsideAdjustersRowDeleted((object) this, new dsClaimsAdministration.OutsideAdjustersRowChangeEvent((dsClaimsAdministration.OutsideAdjustersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.OutsideAdjustersRowDeleting == null)
        return;
      this.OutsideAdjustersRowDeleting((object) this, new dsClaimsAdministration.OutsideAdjustersRowChangeEvent((dsClaimsAdministration.OutsideAdjustersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveOutsideAdjustersRow(dsClaimsAdministration.OutsideAdjustersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsAdministration claimsAdministration = new dsClaimsAdministration();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = claimsAdministration.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (OutsideAdjustersDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = claimsAdministration.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void AccidentTypesRowChangeEventHandler(
    object sender,
    dsClaimsAdministration.AccidentTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void CoverageTypesRowChangeEventHandler(
    object sender,
    dsClaimsAdministration.CoverageTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void CatastropheCodesRowChangeEventHandler(
    object sender,
    dsClaimsAdministration.CatastropheCodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void LossTypesRowChangeEventHandler(
    object sender,
    dsClaimsAdministration.LossTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void ManagedCareFacilitiesRowChangeEventHandler(
    object sender,
    dsClaimsAdministration.ManagedCareFacilitiesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void ManagedCareAddressesRowChangeEventHandler(
    object sender,
    dsClaimsAdministration.ManagedCareAddressesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void ManagedCareAddressPhoneNumbersRowChangeEventHandler(
    object sender,
    dsClaimsAdministration.ManagedCareAddressPhoneNumbersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void ReservePaymentSubTypesRowChangeEventHandler(
    object sender,
    dsClaimsAdministration.ReservePaymentSubTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void ReservePaymentTypesRowChangeEventHandler(
    object sender,
    dsClaimsAdministration.ReservePaymentTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void SettlementTypesRowChangeEventHandler(
    object sender,
    dsClaimsAdministration.SettlementTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void CoverageTypeDescriptionsRowChangeEventHandler(
    object sender,
    dsClaimsAdministration.CoverageTypeDescriptionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void OutsideAdjustersRowChangeEventHandler(
    object sender,
    dsClaimsAdministration.OutsideAdjustersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void OutsideAdjusterAddressesRowChangeEventHandler(
    object sender,
    dsClaimsAdministration.OutsideAdjusterAddressesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void OutsideAdjusterAddressPhoneNumbersRowChangeEventHandler(
    object sender,
    dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class AccidentTypesDataTable : TypedTableBase<dsClaimsAdministration.AccidentTypesRow>
  {
    private DataColumn columnAccidentTypeId;
    private DataColumn columnAccidentType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public AccidentTypesDataTable()
    {
      this.TableName = "AccidentTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal AccidentTypesDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected AccidentTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AccidentTypeIdColumn => this.columnAccidentTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AccidentTypeColumn => this.columnAccidentType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.AccidentTypesRow this[int index]
    {
      get => (dsClaimsAdministration.AccidentTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.AccidentTypesRowChangeEventHandler AccidentTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.AccidentTypesRowChangeEventHandler AccidentTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.AccidentTypesRowChangeEventHandler AccidentTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.AccidentTypesRowChangeEventHandler AccidentTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddAccidentTypesRow(dsClaimsAdministration.AccidentTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.AccidentTypesRow AddAccidentTypesRow(string AccidentType)
    {
      dsClaimsAdministration.AccidentTypesRow row = (dsClaimsAdministration.AccidentTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) AccidentType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.AccidentTypesRow FindByAccidentTypeId(int AccidentTypeId)
    {
      return (dsClaimsAdministration.AccidentTypesRow) this.Rows.Find(new object[1]
      {
        (object) AccidentTypeId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsAdministration.AccidentTypesDataTable accidentTypesDataTable = (dsClaimsAdministration.AccidentTypesDataTable) base.Clone();
      accidentTypesDataTable.InitVars();
      return (DataTable) accidentTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsAdministration.AccidentTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnAccidentTypeId = this.Columns["AccidentTypeId"];
      this.columnAccidentType = this.Columns["AccidentType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnAccidentTypeId = new DataColumn("AccidentTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccidentTypeId);
      this.columnAccidentType = new DataColumn("AccidentType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccidentType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnAccidentTypeId
      }, true));
      this.columnAccidentTypeId.AutoIncrement = true;
      this.columnAccidentTypeId.AllowDBNull = false;
      this.columnAccidentTypeId.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.AccidentTypesRow NewAccidentTypesRow()
    {
      return (dsClaimsAdministration.AccidentTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsAdministration.AccidentTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsClaimsAdministration.AccidentTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.AccidentTypesRowChanged == null)
        return;
      this.AccidentTypesRowChanged((object) this, new dsClaimsAdministration.AccidentTypesRowChangeEvent((dsClaimsAdministration.AccidentTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.AccidentTypesRowChanging == null)
        return;
      this.AccidentTypesRowChanging((object) this, new dsClaimsAdministration.AccidentTypesRowChangeEvent((dsClaimsAdministration.AccidentTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.AccidentTypesRowDeleted == null)
        return;
      this.AccidentTypesRowDeleted((object) this, new dsClaimsAdministration.AccidentTypesRowChangeEvent((dsClaimsAdministration.AccidentTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.AccidentTypesRowDeleting == null)
        return;
      this.AccidentTypesRowDeleting((object) this, new dsClaimsAdministration.AccidentTypesRowChangeEvent((dsClaimsAdministration.AccidentTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveAccidentTypesRow(dsClaimsAdministration.AccidentTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsAdministration claimsAdministration = new dsClaimsAdministration();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = claimsAdministration.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (AccidentTypesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = claimsAdministration.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class CoverageTypesDataTable : TypedTableBase<dsClaimsAdministration.CoverageTypesRow>
  {
    private DataColumn columnCoverageTypeId;
    private DataColumn columnCoverageType;
    private DataColumn columnCoverageTypeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public CoverageTypesDataTable()
    {
      this.TableName = "CoverageTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal CoverageTypesDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected CoverageTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CoverageTypeIdColumn => this.columnCoverageTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CoverageTypeColumn => this.columnCoverageType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CoverageTypeDescriptionColumn => this.columnCoverageTypeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.CoverageTypesRow this[int index]
    {
      get => (dsClaimsAdministration.CoverageTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.CoverageTypesRowChangeEventHandler CoverageTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.CoverageTypesRowChangeEventHandler CoverageTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.CoverageTypesRowChangeEventHandler CoverageTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.CoverageTypesRowChangeEventHandler CoverageTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddCoverageTypesRow(dsClaimsAdministration.CoverageTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.CoverageTypesRow AddCoverageTypesRow(
      string CoverageType,
      string CoverageTypeDescription)
    {
      dsClaimsAdministration.CoverageTypesRow row = (dsClaimsAdministration.CoverageTypesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) CoverageType,
        (object) CoverageTypeDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.CoverageTypesRow FindByCoverageTypeId(int CoverageTypeId)
    {
      return (dsClaimsAdministration.CoverageTypesRow) this.Rows.Find(new object[1]
      {
        (object) CoverageTypeId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsAdministration.CoverageTypesDataTable coverageTypesDataTable = (dsClaimsAdministration.CoverageTypesDataTable) base.Clone();
      coverageTypesDataTable.InitVars();
      return (DataTable) coverageTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsAdministration.CoverageTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnCoverageTypeId = this.Columns["CoverageTypeId"];
      this.columnCoverageType = this.Columns["CoverageType"];
      this.columnCoverageTypeDescription = this.Columns["CoverageTypeDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnCoverageTypeId = new DataColumn("CoverageTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageTypeId);
      this.columnCoverageType = new DataColumn("CoverageType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageType);
      this.columnCoverageTypeDescription = new DataColumn("CoverageTypeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageTypeDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCoverageTypeId
      }, true));
      this.columnCoverageTypeId.AutoIncrement = true;
      this.columnCoverageTypeId.AllowDBNull = false;
      this.columnCoverageTypeId.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.CoverageTypesRow NewCoverageTypesRow()
    {
      return (dsClaimsAdministration.CoverageTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsAdministration.CoverageTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsClaimsAdministration.CoverageTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.CoverageTypesRowChanged == null)
        return;
      this.CoverageTypesRowChanged((object) this, new dsClaimsAdministration.CoverageTypesRowChangeEvent((dsClaimsAdministration.CoverageTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.CoverageTypesRowChanging == null)
        return;
      this.CoverageTypesRowChanging((object) this, new dsClaimsAdministration.CoverageTypesRowChangeEvent((dsClaimsAdministration.CoverageTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.CoverageTypesRowDeleted == null)
        return;
      this.CoverageTypesRowDeleted((object) this, new dsClaimsAdministration.CoverageTypesRowChangeEvent((dsClaimsAdministration.CoverageTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.CoverageTypesRowDeleting == null)
        return;
      this.CoverageTypesRowDeleting((object) this, new dsClaimsAdministration.CoverageTypesRowChangeEvent((dsClaimsAdministration.CoverageTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveCoverageTypesRow(dsClaimsAdministration.CoverageTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsAdministration claimsAdministration = new dsClaimsAdministration();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = claimsAdministration.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CoverageTypesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = claimsAdministration.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class CatastropheCodesDataTable : TypedTableBase<dsClaimsAdministration.CatastropheCodesRow>
  {
    private DataColumn columnCatastropheCodeId;
    private DataColumn columnCatastropheCode;
    private DataColumn columnCatastropheCodeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public CatastropheCodesDataTable()
    {
      this.TableName = "CatastropheCodes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal CatastropheCodesDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected CatastropheCodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CatastropheCodeIdColumn => this.columnCatastropheCodeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CatastropheCodeColumn => this.columnCatastropheCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CatastropheCodeDescriptionColumn => this.columnCatastropheCodeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.CatastropheCodesRow this[int index]
    {
      get => (dsClaimsAdministration.CatastropheCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.CatastropheCodesRowChangeEventHandler CatastropheCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.CatastropheCodesRowChangeEventHandler CatastropheCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.CatastropheCodesRowChangeEventHandler CatastropheCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.CatastropheCodesRowChangeEventHandler CatastropheCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddCatastropheCodesRow(dsClaimsAdministration.CatastropheCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.CatastropheCodesRow AddCatastropheCodesRow(
      string CatastropheCode,
      string CatastropheCodeDescription)
    {
      dsClaimsAdministration.CatastropheCodesRow row = (dsClaimsAdministration.CatastropheCodesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) CatastropheCode,
        (object) CatastropheCodeDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.CatastropheCodesRow FindByCatastropheCodeId(int CatastropheCodeId)
    {
      return (dsClaimsAdministration.CatastropheCodesRow) this.Rows.Find(new object[1]
      {
        (object) CatastropheCodeId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsAdministration.CatastropheCodesDataTable catastropheCodesDataTable = (dsClaimsAdministration.CatastropheCodesDataTable) base.Clone();
      catastropheCodesDataTable.InitVars();
      return (DataTable) catastropheCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsAdministration.CatastropheCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnCatastropheCodeId = this.Columns["CatastropheCodeId"];
      this.columnCatastropheCode = this.Columns["CatastropheCode"];
      this.columnCatastropheCodeDescription = this.Columns["CatastropheCodeDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnCatastropheCodeId = new DataColumn("CatastropheCodeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCatastropheCodeId);
      this.columnCatastropheCode = new DataColumn("CatastropheCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCatastropheCode);
      this.columnCatastropheCodeDescription = new DataColumn("CatastropheCodeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCatastropheCodeDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCatastropheCodeId
      }, true));
      this.columnCatastropheCodeId.AutoIncrement = true;
      this.columnCatastropheCodeId.AllowDBNull = false;
      this.columnCatastropheCodeId.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.CatastropheCodesRow NewCatastropheCodesRow()
    {
      return (dsClaimsAdministration.CatastropheCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsAdministration.CatastropheCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsClaimsAdministration.CatastropheCodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.CatastropheCodesRowChanged == null)
        return;
      this.CatastropheCodesRowChanged((object) this, new dsClaimsAdministration.CatastropheCodesRowChangeEvent((dsClaimsAdministration.CatastropheCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.CatastropheCodesRowChanging == null)
        return;
      this.CatastropheCodesRowChanging((object) this, new dsClaimsAdministration.CatastropheCodesRowChangeEvent((dsClaimsAdministration.CatastropheCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.CatastropheCodesRowDeleted == null)
        return;
      this.CatastropheCodesRowDeleted((object) this, new dsClaimsAdministration.CatastropheCodesRowChangeEvent((dsClaimsAdministration.CatastropheCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.CatastropheCodesRowDeleting == null)
        return;
      this.CatastropheCodesRowDeleting((object) this, new dsClaimsAdministration.CatastropheCodesRowChangeEvent((dsClaimsAdministration.CatastropheCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveCatastropheCodesRow(dsClaimsAdministration.CatastropheCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsAdministration claimsAdministration = new dsClaimsAdministration();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = claimsAdministration.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CatastropheCodesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = claimsAdministration.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class LossTypesDataTable : TypedTableBase<dsClaimsAdministration.LossTypesRow>
  {
    private DataColumn columnLossTypeId;
    private DataColumn columnLossType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public LossTypesDataTable()
    {
      this.TableName = "LossTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal LossTypesDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected LossTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn LossTypeIdColumn => this.columnLossTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn LossTypeColumn => this.columnLossType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.LossTypesRow this[int index]
    {
      get => (dsClaimsAdministration.LossTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.LossTypesRowChangeEventHandler LossTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.LossTypesRowChangeEventHandler LossTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.LossTypesRowChangeEventHandler LossTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.LossTypesRowChangeEventHandler LossTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddLossTypesRow(dsClaimsAdministration.LossTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.LossTypesRow AddLossTypesRow(string LossType)
    {
      dsClaimsAdministration.LossTypesRow row = (dsClaimsAdministration.LossTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) LossType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.LossTypesRow FindByLossTypeId(int LossTypeId)
    {
      return (dsClaimsAdministration.LossTypesRow) this.Rows.Find(new object[1]
      {
        (object) LossTypeId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsAdministration.LossTypesDataTable lossTypesDataTable = (dsClaimsAdministration.LossTypesDataTable) base.Clone();
      lossTypesDataTable.InitVars();
      return (DataTable) lossTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsAdministration.LossTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnLossTypeId = this.Columns["LossTypeId"];
      this.columnLossType = this.Columns["LossType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnLossTypeId = new DataColumn("LossTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLossTypeId);
      this.columnLossType = new DataColumn("LossType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLossType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnLossTypeId
      }, true));
      this.columnLossTypeId.AutoIncrement = true;
      this.columnLossTypeId.AllowDBNull = false;
      this.columnLossTypeId.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.LossTypesRow NewLossTypesRow()
    {
      return (dsClaimsAdministration.LossTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsAdministration.LossTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsClaimsAdministration.LossTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.LossTypesRowChanged == null)
        return;
      this.LossTypesRowChanged((object) this, new dsClaimsAdministration.LossTypesRowChangeEvent((dsClaimsAdministration.LossTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.LossTypesRowChanging == null)
        return;
      this.LossTypesRowChanging((object) this, new dsClaimsAdministration.LossTypesRowChangeEvent((dsClaimsAdministration.LossTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.LossTypesRowDeleted == null)
        return;
      this.LossTypesRowDeleted((object) this, new dsClaimsAdministration.LossTypesRowChangeEvent((dsClaimsAdministration.LossTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.LossTypesRowDeleting == null)
        return;
      this.LossTypesRowDeleting((object) this, new dsClaimsAdministration.LossTypesRowChangeEvent((dsClaimsAdministration.LossTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveLossTypesRow(dsClaimsAdministration.LossTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsAdministration claimsAdministration = new dsClaimsAdministration();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = claimsAdministration.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (LossTypesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = claimsAdministration.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class ManagedCareFacilitiesDataTable : 
    TypedTableBase<dsClaimsAdministration.ManagedCareFacilitiesRow>
  {
    private DataColumn columnManagedCareId;
    private DataColumn columnFacilityName;
    private DataColumn columnAddressId;
    private DataColumn columnWebAddress;
    private DataColumn columnEntityType;
    private DataColumn columnFEIN;
    private DataColumn columnDateIncorporated;
    private DataColumn columnEmailAddress;
    private DataColumn columnDateEntered;
    private DataColumn columnEnteredByUserGuid;
    private DataColumn columnDateModified;
    private DataColumn columnModifiedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public ManagedCareFacilitiesDataTable()
    {
      this.TableName = "ManagedCareFacilities";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal ManagedCareFacilitiesDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected ManagedCareFacilitiesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ManagedCareIdColumn => this.columnManagedCareId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FacilityNameColumn => this.columnFacilityName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AddressIdColumn => this.columnAddressId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn WebAddressColumn => this.columnWebAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EntityTypeColumn => this.columnEntityType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FEINColumn => this.columnFEIN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DateIncorporatedColumn => this.columnDateIncorporated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EmailAddressColumn => this.columnEmailAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DateEnteredColumn => this.columnDateEntered;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EnteredByUserGuidColumn => this.columnEnteredByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DateModifiedColumn => this.columnDateModified;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ModifiedByUserGuidColumn => this.columnModifiedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareFacilitiesRow this[int index]
    {
      get => (dsClaimsAdministration.ManagedCareFacilitiesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ManagedCareFacilitiesRowChangeEventHandler ManagedCareFacilitiesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ManagedCareFacilitiesRowChangeEventHandler ManagedCareFacilitiesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ManagedCareFacilitiesRowChangeEventHandler ManagedCareFacilitiesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ManagedCareFacilitiesRowChangeEventHandler ManagedCareFacilitiesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddManagedCareFacilitiesRow(
      dsClaimsAdministration.ManagedCareFacilitiesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareFacilitiesRow AddManagedCareFacilitiesRow(
      string FacilityName,
      int AddressId,
      string WebAddress,
      string EntityType,
      string FEIN,
      DateTime DateIncorporated,
      string EmailAddress,
      DateTime DateEntered,
      Guid EnteredByUserGuid,
      DateTime DateModified,
      Guid ModifiedByUserGuid)
    {
      dsClaimsAdministration.ManagedCareFacilitiesRow row = (dsClaimsAdministration.ManagedCareFacilitiesRow) this.NewRow();
      object[] objArray = new object[12]
      {
        null,
        (object) FacilityName,
        (object) AddressId,
        (object) WebAddress,
        (object) EntityType,
        (object) FEIN,
        (object) DateIncorporated,
        (object) EmailAddress,
        (object) DateEntered,
        (object) EnteredByUserGuid,
        (object) DateModified,
        (object) ModifiedByUserGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareFacilitiesRow FindByManagedCareId(int ManagedCareId)
    {
      return (dsClaimsAdministration.ManagedCareFacilitiesRow) this.Rows.Find(new object[1]
      {
        (object) ManagedCareId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsAdministration.ManagedCareFacilitiesDataTable facilitiesDataTable = (dsClaimsAdministration.ManagedCareFacilitiesDataTable) base.Clone();
      facilitiesDataTable.InitVars();
      return (DataTable) facilitiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsAdministration.ManagedCareFacilitiesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnManagedCareId = this.Columns["ManagedCareId"];
      this.columnFacilityName = this.Columns["FacilityName"];
      this.columnAddressId = this.Columns["AddressId"];
      this.columnWebAddress = this.Columns["WebAddress"];
      this.columnEntityType = this.Columns["EntityType"];
      this.columnFEIN = this.Columns["FEIN"];
      this.columnDateIncorporated = this.Columns["DateIncorporated"];
      this.columnEmailAddress = this.Columns["EmailAddress"];
      this.columnDateEntered = this.Columns["DateEntered"];
      this.columnEnteredByUserGuid = this.Columns["EnteredByUserGuid"];
      this.columnDateModified = this.Columns["DateModified"];
      this.columnModifiedByUserGuid = this.Columns["ModifiedByUserGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnManagedCareId = new DataColumn("ManagedCareId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnManagedCareId);
      this.columnFacilityName = new DataColumn("FacilityName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFacilityName);
      this.columnAddressId = new DataColumn("AddressId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddressId);
      this.columnWebAddress = new DataColumn("WebAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWebAddress);
      this.columnEntityType = new DataColumn("EntityType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityType);
      this.columnFEIN = new DataColumn("FEIN", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFEIN);
      this.columnDateIncorporated = new DataColumn("DateIncorporated", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateIncorporated);
      this.columnEmailAddress = new DataColumn("EmailAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmailAddress);
      this.columnDateEntered = new DataColumn("DateEntered", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateEntered);
      this.columnEnteredByUserGuid = new DataColumn("EnteredByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEnteredByUserGuid);
      this.columnDateModified = new DataColumn("DateModified", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateModified);
      this.columnModifiedByUserGuid = new DataColumn("ModifiedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModifiedByUserGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnManagedCareId
      }, true));
      this.columnManagedCareId.AutoIncrement = true;
      this.columnManagedCareId.AllowDBNull = false;
      this.columnManagedCareId.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareFacilitiesRow NewManagedCareFacilitiesRow()
    {
      return (dsClaimsAdministration.ManagedCareFacilitiesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsAdministration.ManagedCareFacilitiesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsClaimsAdministration.ManagedCareFacilitiesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.ManagedCareFacilitiesRowChanged == null)
        return;
      this.ManagedCareFacilitiesRowChanged((object) this, new dsClaimsAdministration.ManagedCareFacilitiesRowChangeEvent((dsClaimsAdministration.ManagedCareFacilitiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.ManagedCareFacilitiesRowChanging == null)
        return;
      this.ManagedCareFacilitiesRowChanging((object) this, new dsClaimsAdministration.ManagedCareFacilitiesRowChangeEvent((dsClaimsAdministration.ManagedCareFacilitiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.ManagedCareFacilitiesRowDeleted == null)
        return;
      this.ManagedCareFacilitiesRowDeleted((object) this, new dsClaimsAdministration.ManagedCareFacilitiesRowChangeEvent((dsClaimsAdministration.ManagedCareFacilitiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.ManagedCareFacilitiesRowDeleting == null)
        return;
      this.ManagedCareFacilitiesRowDeleting((object) this, new dsClaimsAdministration.ManagedCareFacilitiesRowChangeEvent((dsClaimsAdministration.ManagedCareFacilitiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveManagedCareFacilitiesRow(
      dsClaimsAdministration.ManagedCareFacilitiesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsAdministration claimsAdministration = new dsClaimsAdministration();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = claimsAdministration.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ManagedCareFacilitiesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = claimsAdministration.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class ManagedCareAddressesDataTable : 
    TypedTableBase<dsClaimsAdministration.ManagedCareAddressesRow>
  {
    private DataColumn columnAddressId;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnCounty;
    private DataColumn columnZipCode;
    private DataColumn columnZipCodeExtension;
    private DataColumn columnIsInternational;
    private DataColumn columnInternationalZipCode;
    private DataColumn columnISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public ManagedCareAddressesDataTable()
    {
      this.TableName = "ManagedCareAddresses";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal ManagedCareAddressesDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected ManagedCareAddressesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AddressIdColumn => this.columnAddressId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Address1Column => this.columnAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Address2Column => this.columnAddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CountyColumn => this.columnCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ZipCodeExtensionColumn => this.columnZipCodeExtension;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn IsInternationalColumn => this.columnIsInternational;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn InternationalZipCodeColumn => this.columnInternationalZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ISOCountryCodeColumn => this.columnISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareAddressesRow this[int index]
    {
      get => (dsClaimsAdministration.ManagedCareAddressesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ManagedCareAddressesRowChangeEventHandler ManagedCareAddressesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ManagedCareAddressesRowChangeEventHandler ManagedCareAddressesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ManagedCareAddressesRowChangeEventHandler ManagedCareAddressesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ManagedCareAddressesRowChangeEventHandler ManagedCareAddressesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddManagedCareAddressesRow(dsClaimsAdministration.ManagedCareAddressesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareAddressesRow AddManagedCareAddressesRow(
      string Address1,
      string Address2,
      string City,
      string State,
      string County,
      string ZipCode,
      string ZipCodeExtension,
      bool IsInternational,
      string InternationalZipCode,
      string ISOCountryCode)
    {
      dsClaimsAdministration.ManagedCareAddressesRow row = (dsClaimsAdministration.ManagedCareAddressesRow) this.NewRow();
      object[] objArray = new object[11]
      {
        null,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) State,
        (object) County,
        (object) ZipCode,
        (object) ZipCodeExtension,
        (object) IsInternational,
        (object) InternationalZipCode,
        (object) ISOCountryCode
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareAddressesRow FindByAddressId(int AddressId)
    {
      return (dsClaimsAdministration.ManagedCareAddressesRow) this.Rows.Find(new object[1]
      {
        (object) AddressId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsAdministration.ManagedCareAddressesDataTable addressesDataTable = (dsClaimsAdministration.ManagedCareAddressesDataTable) base.Clone();
      addressesDataTable.InitVars();
      return (DataTable) addressesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsAdministration.ManagedCareAddressesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnAddressId = this.Columns["AddressId"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnCounty = this.Columns["County"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnZipCodeExtension = this.Columns["ZipCodeExtension"];
      this.columnIsInternational = this.Columns["IsInternational"];
      this.columnInternationalZipCode = this.Columns["InternationalZipCode"];
      this.columnISOCountryCode = this.Columns["ISOCountryCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnAddressId = new DataColumn("AddressId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddressId);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnAddress2 = new DataColumn("Address2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnCounty = new DataColumn("County", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCounty);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnZipCodeExtension = new DataColumn("ZipCodeExtension", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCodeExtension);
      this.columnIsInternational = new DataColumn("IsInternational", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsInternational);
      this.columnInternationalZipCode = new DataColumn("InternationalZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInternationalZipCode);
      this.columnISOCountryCode = new DataColumn("ISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnISOCountryCode);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnAddressId
      }, true));
      this.columnAddressId.AutoIncrement = true;
      this.columnAddressId.AllowDBNull = false;
      this.columnAddressId.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareAddressesRow NewManagedCareAddressesRow()
    {
      return (dsClaimsAdministration.ManagedCareAddressesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsAdministration.ManagedCareAddressesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsClaimsAdministration.ManagedCareAddressesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.ManagedCareAddressesRowChanged == null)
        return;
      this.ManagedCareAddressesRowChanged((object) this, new dsClaimsAdministration.ManagedCareAddressesRowChangeEvent((dsClaimsAdministration.ManagedCareAddressesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.ManagedCareAddressesRowChanging == null)
        return;
      this.ManagedCareAddressesRowChanging((object) this, new dsClaimsAdministration.ManagedCareAddressesRowChangeEvent((dsClaimsAdministration.ManagedCareAddressesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.ManagedCareAddressesRowDeleted == null)
        return;
      this.ManagedCareAddressesRowDeleted((object) this, new dsClaimsAdministration.ManagedCareAddressesRowChangeEvent((dsClaimsAdministration.ManagedCareAddressesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.ManagedCareAddressesRowDeleting == null)
        return;
      this.ManagedCareAddressesRowDeleting((object) this, new dsClaimsAdministration.ManagedCareAddressesRowChangeEvent((dsClaimsAdministration.ManagedCareAddressesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveManagedCareAddressesRow(dsClaimsAdministration.ManagedCareAddressesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsAdministration claimsAdministration = new dsClaimsAdministration();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = claimsAdministration.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ManagedCareAddressesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = claimsAdministration.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class ManagedCareAddressPhoneNumbersDataTable : 
    TypedTableBase<dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow>
  {
    private DataColumn columnAddressId;
    private DataColumn columnPhoneNumberId;
    private DataColumn columnPhoneNumber;
    private DataColumn columnPhoneTypeId;
    private DataColumn columnPhoneType;
    private DataColumn columnCountryCode;
    private DataColumn columnInputMask;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public ManagedCareAddressPhoneNumbersDataTable()
    {
      this.TableName = "ManagedCareAddressPhoneNumbers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal ManagedCareAddressPhoneNumbersDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected ManagedCareAddressPhoneNumbersDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AddressIdColumn => this.columnAddressId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PhoneNumberIdColumn => this.columnPhoneNumberId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PhoneNumberColumn => this.columnPhoneNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PhoneTypeIdColumn => this.columnPhoneTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PhoneTypeColumn => this.columnPhoneType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CountryCodeColumn => this.columnCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn InputMaskColumn => this.columnInputMask;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow this[int index]
    {
      get => (dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ManagedCareAddressPhoneNumbersRowChangeEventHandler ManagedCareAddressPhoneNumbersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ManagedCareAddressPhoneNumbersRowChangeEventHandler ManagedCareAddressPhoneNumbersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ManagedCareAddressPhoneNumbersRowChangeEventHandler ManagedCareAddressPhoneNumbersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ManagedCareAddressPhoneNumbersRowChangeEventHandler ManagedCareAddressPhoneNumbersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddManagedCareAddressPhoneNumbersRow(
      dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow AddManagedCareAddressPhoneNumbersRow(
      int AddressId,
      string PhoneNumber,
      int PhoneTypeId,
      string PhoneType,
      string CountryCode,
      string InputMask)
    {
      dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow row = (dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow) this.NewRow();
      object[] objArray = new object[7]
      {
        (object) AddressId,
        null,
        (object) PhoneNumber,
        (object) PhoneTypeId,
        (object) PhoneType,
        (object) CountryCode,
        (object) InputMask
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow FindByAddressIdPhoneNumberId(
      int AddressId,
      int PhoneNumberId)
    {
      return (dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow) this.Rows.Find(new object[2]
      {
        (object) AddressId,
        (object) PhoneNumberId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsAdministration.ManagedCareAddressPhoneNumbersDataTable numbersDataTable = (dsClaimsAdministration.ManagedCareAddressPhoneNumbersDataTable) base.Clone();
      numbersDataTable.InitVars();
      return (DataTable) numbersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsAdministration.ManagedCareAddressPhoneNumbersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnAddressId = this.Columns["AddressId"];
      this.columnPhoneNumberId = this.Columns["PhoneNumberId"];
      this.columnPhoneNumber = this.Columns["PhoneNumber"];
      this.columnPhoneTypeId = this.Columns["PhoneTypeId"];
      this.columnPhoneType = this.Columns["PhoneType"];
      this.columnCountryCode = this.Columns["CountryCode"];
      this.columnInputMask = this.Columns["InputMask"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnAddressId = new DataColumn("AddressId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddressId);
      this.columnPhoneNumberId = new DataColumn("PhoneNumberId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhoneNumberId);
      this.columnPhoneNumber = new DataColumn("PhoneNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhoneNumber);
      this.columnPhoneTypeId = new DataColumn("PhoneTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhoneTypeId);
      this.columnPhoneType = new DataColumn("PhoneType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhoneType);
      this.columnCountryCode = new DataColumn("CountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCountryCode);
      this.columnInputMask = new DataColumn("InputMask", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInputMask);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnAddressId,
        this.columnPhoneNumberId
      }, true));
      this.columnAddressId.AllowDBNull = false;
      this.columnPhoneNumberId.AutoIncrement = true;
      this.columnPhoneNumberId.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow NewManagedCareAddressPhoneNumbersRow()
    {
      return (dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.ManagedCareAddressPhoneNumbersRowChanged == null)
        return;
      this.ManagedCareAddressPhoneNumbersRowChanged((object) this, new dsClaimsAdministration.ManagedCareAddressPhoneNumbersRowChangeEvent((dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.ManagedCareAddressPhoneNumbersRowChanging == null)
        return;
      this.ManagedCareAddressPhoneNumbersRowChanging((object) this, new dsClaimsAdministration.ManagedCareAddressPhoneNumbersRowChangeEvent((dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.ManagedCareAddressPhoneNumbersRowDeleted == null)
        return;
      this.ManagedCareAddressPhoneNumbersRowDeleted((object) this, new dsClaimsAdministration.ManagedCareAddressPhoneNumbersRowChangeEvent((dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.ManagedCareAddressPhoneNumbersRowDeleting == null)
        return;
      this.ManagedCareAddressPhoneNumbersRowDeleting((object) this, new dsClaimsAdministration.ManagedCareAddressPhoneNumbersRowChangeEvent((dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveManagedCareAddressPhoneNumbersRow(
      dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsAdministration claimsAdministration = new dsClaimsAdministration();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = claimsAdministration.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ManagedCareAddressPhoneNumbersDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = claimsAdministration.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class ReservePaymentSubTypesDataTable : 
    TypedTableBase<dsClaimsAdministration.ReservePaymentSubTypesRow>
  {
    private DataColumn columnResPaySubTypeId;
    private DataColumn columnResPayTypeId;
    private DataColumn columnResPaySubTypeDescription;
    private DataColumn columnAllocated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public ReservePaymentSubTypesDataTable()
    {
      this.TableName = "ReservePaymentSubTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal ReservePaymentSubTypesDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected ReservePaymentSubTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ResPaySubTypeIdColumn => this.columnResPaySubTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ResPayTypeIdColumn => this.columnResPayTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ResPaySubTypeDescriptionColumn => this.columnResPaySubTypeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AllocatedColumn => this.columnAllocated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ReservePaymentSubTypesRow this[int index]
    {
      get => (dsClaimsAdministration.ReservePaymentSubTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ReservePaymentSubTypesRowChangeEventHandler ReservePaymentSubTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ReservePaymentSubTypesRowChangeEventHandler ReservePaymentSubTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ReservePaymentSubTypesRowChangeEventHandler ReservePaymentSubTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ReservePaymentSubTypesRowChangeEventHandler ReservePaymentSubTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddReservePaymentSubTypesRow(
      dsClaimsAdministration.ReservePaymentSubTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ReservePaymentSubTypesRow AddReservePaymentSubTypesRow(
      int ResPayTypeId,
      string ResPaySubTypeDescription,
      bool Allocated)
    {
      dsClaimsAdministration.ReservePaymentSubTypesRow row = (dsClaimsAdministration.ReservePaymentSubTypesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        null,
        (object) ResPayTypeId,
        (object) ResPaySubTypeDescription,
        (object) Allocated
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ReservePaymentSubTypesRow FindByResPaySubTypeId(
      int ResPaySubTypeId)
    {
      return (dsClaimsAdministration.ReservePaymentSubTypesRow) this.Rows.Find(new object[1]
      {
        (object) ResPaySubTypeId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsAdministration.ReservePaymentSubTypesDataTable subTypesDataTable = (dsClaimsAdministration.ReservePaymentSubTypesDataTable) base.Clone();
      subTypesDataTable.InitVars();
      return (DataTable) subTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsAdministration.ReservePaymentSubTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnResPaySubTypeId = this.Columns["ResPaySubTypeId"];
      this.columnResPayTypeId = this.Columns["ResPayTypeId"];
      this.columnResPaySubTypeDescription = this.Columns["ResPaySubTypeDescription"];
      this.columnAllocated = this.Columns["Allocated"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnResPaySubTypeId = new DataColumn("ResPaySubTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResPaySubTypeId);
      this.columnResPayTypeId = new DataColumn("ResPayTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResPayTypeId);
      this.columnResPaySubTypeDescription = new DataColumn("ResPaySubTypeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResPaySubTypeDescription);
      this.columnAllocated = new DataColumn("Allocated", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAllocated);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnResPaySubTypeId
      }, true));
      this.columnResPaySubTypeId.AutoIncrement = true;
      this.columnResPaySubTypeId.AllowDBNull = false;
      this.columnResPaySubTypeId.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ReservePaymentSubTypesRow NewReservePaymentSubTypesRow()
    {
      return (dsClaimsAdministration.ReservePaymentSubTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsAdministration.ReservePaymentSubTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsClaimsAdministration.ReservePaymentSubTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.ReservePaymentSubTypesRowChanged == null)
        return;
      this.ReservePaymentSubTypesRowChanged((object) this, new dsClaimsAdministration.ReservePaymentSubTypesRowChangeEvent((dsClaimsAdministration.ReservePaymentSubTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.ReservePaymentSubTypesRowChanging == null)
        return;
      this.ReservePaymentSubTypesRowChanging((object) this, new dsClaimsAdministration.ReservePaymentSubTypesRowChangeEvent((dsClaimsAdministration.ReservePaymentSubTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.ReservePaymentSubTypesRowDeleted == null)
        return;
      this.ReservePaymentSubTypesRowDeleted((object) this, new dsClaimsAdministration.ReservePaymentSubTypesRowChangeEvent((dsClaimsAdministration.ReservePaymentSubTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.ReservePaymentSubTypesRowDeleting == null)
        return;
      this.ReservePaymentSubTypesRowDeleting((object) this, new dsClaimsAdministration.ReservePaymentSubTypesRowChangeEvent((dsClaimsAdministration.ReservePaymentSubTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveReservePaymentSubTypesRow(
      dsClaimsAdministration.ReservePaymentSubTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsAdministration claimsAdministration = new dsClaimsAdministration();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = claimsAdministration.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ReservePaymentSubTypesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = claimsAdministration.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class ReservePaymentTypesDataTable : 
    TypedTableBase<dsClaimsAdministration.ReservePaymentTypesRow>
  {
    private DataColumn columnResPayTypeId;
    private DataColumn columnResPayTypeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public ReservePaymentTypesDataTable()
    {
      this.TableName = "ReservePaymentTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal ReservePaymentTypesDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected ReservePaymentTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ResPayTypeIdColumn => this.columnResPayTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ResPayTypeDescriptionColumn => this.columnResPayTypeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ReservePaymentTypesRow this[int index]
    {
      get => (dsClaimsAdministration.ReservePaymentTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ReservePaymentTypesRowChangeEventHandler ReservePaymentTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ReservePaymentTypesRowChangeEventHandler ReservePaymentTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ReservePaymentTypesRowChangeEventHandler ReservePaymentTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.ReservePaymentTypesRowChangeEventHandler ReservePaymentTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddReservePaymentTypesRow(dsClaimsAdministration.ReservePaymentTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ReservePaymentTypesRow AddReservePaymentTypesRow(
      string ResPayTypeDescription)
    {
      dsClaimsAdministration.ReservePaymentTypesRow row = (dsClaimsAdministration.ReservePaymentTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) ResPayTypeDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ReservePaymentTypesRow FindByResPayTypeId(int ResPayTypeId)
    {
      return (dsClaimsAdministration.ReservePaymentTypesRow) this.Rows.Find(new object[1]
      {
        (object) ResPayTypeId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsAdministration.ReservePaymentTypesDataTable paymentTypesDataTable = (dsClaimsAdministration.ReservePaymentTypesDataTable) base.Clone();
      paymentTypesDataTable.InitVars();
      return (DataTable) paymentTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsAdministration.ReservePaymentTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnResPayTypeId = this.Columns["ResPayTypeId"];
      this.columnResPayTypeDescription = this.Columns["ResPayTypeDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnResPayTypeId = new DataColumn("ResPayTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResPayTypeId);
      this.columnResPayTypeDescription = new DataColumn("ResPayTypeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResPayTypeDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnResPayTypeId
      }, true));
      this.columnResPayTypeId.AutoIncrement = true;
      this.columnResPayTypeId.AllowDBNull = false;
      this.columnResPayTypeId.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ReservePaymentTypesRow NewReservePaymentTypesRow()
    {
      return (dsClaimsAdministration.ReservePaymentTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsAdministration.ReservePaymentTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsClaimsAdministration.ReservePaymentTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.ReservePaymentTypesRowChanged == null)
        return;
      this.ReservePaymentTypesRowChanged((object) this, new dsClaimsAdministration.ReservePaymentTypesRowChangeEvent((dsClaimsAdministration.ReservePaymentTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.ReservePaymentTypesRowChanging == null)
        return;
      this.ReservePaymentTypesRowChanging((object) this, new dsClaimsAdministration.ReservePaymentTypesRowChangeEvent((dsClaimsAdministration.ReservePaymentTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.ReservePaymentTypesRowDeleted == null)
        return;
      this.ReservePaymentTypesRowDeleted((object) this, new dsClaimsAdministration.ReservePaymentTypesRowChangeEvent((dsClaimsAdministration.ReservePaymentTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.ReservePaymentTypesRowDeleting == null)
        return;
      this.ReservePaymentTypesRowDeleting((object) this, new dsClaimsAdministration.ReservePaymentTypesRowChangeEvent((dsClaimsAdministration.ReservePaymentTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveReservePaymentTypesRow(dsClaimsAdministration.ReservePaymentTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsAdministration claimsAdministration = new dsClaimsAdministration();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = claimsAdministration.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ReservePaymentTypesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = claimsAdministration.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class SettlementTypesDataTable : TypedTableBase<dsClaimsAdministration.SettlementTypesRow>
  {
    private DataColumn columnSettlementTypeId;
    private DataColumn columnSettlementType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public SettlementTypesDataTable()
    {
      this.TableName = "SettlementTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal SettlementTypesDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected SettlementTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn SettlementTypeIdColumn => this.columnSettlementTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn SettlementTypeColumn => this.columnSettlementType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.SettlementTypesRow this[int index]
    {
      get => (dsClaimsAdministration.SettlementTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.SettlementTypesRowChangeEventHandler SettlementTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.SettlementTypesRowChangeEventHandler SettlementTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.SettlementTypesRowChangeEventHandler SettlementTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.SettlementTypesRowChangeEventHandler SettlementTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddSettlementTypesRow(dsClaimsAdministration.SettlementTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.SettlementTypesRow AddSettlementTypesRow(string SettlementType)
    {
      dsClaimsAdministration.SettlementTypesRow row = (dsClaimsAdministration.SettlementTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) SettlementType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.SettlementTypesRow FindBySettlementTypeId(int SettlementTypeId)
    {
      return (dsClaimsAdministration.SettlementTypesRow) this.Rows.Find(new object[1]
      {
        (object) SettlementTypeId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsAdministration.SettlementTypesDataTable settlementTypesDataTable = (dsClaimsAdministration.SettlementTypesDataTable) base.Clone();
      settlementTypesDataTable.InitVars();
      return (DataTable) settlementTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsAdministration.SettlementTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnSettlementTypeId = this.Columns["SettlementTypeId"];
      this.columnSettlementType = this.Columns["SettlementType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnSettlementTypeId = new DataColumn("SettlementTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSettlementTypeId);
      this.columnSettlementType = new DataColumn("SettlementType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSettlementType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnSettlementTypeId
      }, true));
      this.columnSettlementTypeId.AutoIncrement = true;
      this.columnSettlementTypeId.AllowDBNull = false;
      this.columnSettlementTypeId.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.SettlementTypesRow NewSettlementTypesRow()
    {
      return (dsClaimsAdministration.SettlementTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsAdministration.SettlementTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsClaimsAdministration.SettlementTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.SettlementTypesRowChanged == null)
        return;
      this.SettlementTypesRowChanged((object) this, new dsClaimsAdministration.SettlementTypesRowChangeEvent((dsClaimsAdministration.SettlementTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.SettlementTypesRowChanging == null)
        return;
      this.SettlementTypesRowChanging((object) this, new dsClaimsAdministration.SettlementTypesRowChangeEvent((dsClaimsAdministration.SettlementTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.SettlementTypesRowDeleted == null)
        return;
      this.SettlementTypesRowDeleted((object) this, new dsClaimsAdministration.SettlementTypesRowChangeEvent((dsClaimsAdministration.SettlementTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.SettlementTypesRowDeleting == null)
        return;
      this.SettlementTypesRowDeleting((object) this, new dsClaimsAdministration.SettlementTypesRowChangeEvent((dsClaimsAdministration.SettlementTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveSettlementTypesRow(dsClaimsAdministration.SettlementTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsAdministration claimsAdministration = new dsClaimsAdministration();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = claimsAdministration.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (SettlementTypesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = claimsAdministration.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class CoverageTypeDescriptionsDataTable : 
    TypedTableBase<dsClaimsAdministration.CoverageTypeDescriptionsRow>
  {
    private DataColumn columnCoverageTypeDescriptionId;
    private DataColumn columnCoverageTypeId;
    private DataColumn columnCoverageTypeDescription;
    private DataColumn columnSublineCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public CoverageTypeDescriptionsDataTable()
    {
      this.TableName = "CoverageTypeDescriptions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal CoverageTypeDescriptionsDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected CoverageTypeDescriptionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CoverageTypeDescriptionIdColumn => this.columnCoverageTypeDescriptionId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CoverageTypeIdColumn => this.columnCoverageTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CoverageTypeDescriptionColumn => this.columnCoverageTypeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn SublineCodeColumn => this.columnSublineCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.CoverageTypeDescriptionsRow this[int index]
    {
      get => (dsClaimsAdministration.CoverageTypeDescriptionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.CoverageTypeDescriptionsRowChangeEventHandler CoverageTypeDescriptionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.CoverageTypeDescriptionsRowChangeEventHandler CoverageTypeDescriptionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.CoverageTypeDescriptionsRowChangeEventHandler CoverageTypeDescriptionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.CoverageTypeDescriptionsRowChangeEventHandler CoverageTypeDescriptionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddCoverageTypeDescriptionsRow(
      dsClaimsAdministration.CoverageTypeDescriptionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.CoverageTypeDescriptionsRow AddCoverageTypeDescriptionsRow(
      int CoverageTypeId,
      string CoverageTypeDescription,
      string SublineCode)
    {
      dsClaimsAdministration.CoverageTypeDescriptionsRow row = (dsClaimsAdministration.CoverageTypeDescriptionsRow) this.NewRow();
      object[] objArray = new object[4]
      {
        null,
        (object) CoverageTypeId,
        (object) CoverageTypeDescription,
        (object) SublineCode
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.CoverageTypeDescriptionsRow FindByCoverageTypeDescriptionId(
      int CoverageTypeDescriptionId)
    {
      return (dsClaimsAdministration.CoverageTypeDescriptionsRow) this.Rows.Find(new object[1]
      {
        (object) CoverageTypeDescriptionId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsAdministration.CoverageTypeDescriptionsDataTable descriptionsDataTable = (dsClaimsAdministration.CoverageTypeDescriptionsDataTable) base.Clone();
      descriptionsDataTable.InitVars();
      return (DataTable) descriptionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsAdministration.CoverageTypeDescriptionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnCoverageTypeDescriptionId = this.Columns["CoverageTypeDescriptionId"];
      this.columnCoverageTypeId = this.Columns["CoverageTypeId"];
      this.columnCoverageTypeDescription = this.Columns["CoverageTypeDescription"];
      this.columnSublineCode = this.Columns["SublineCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnCoverageTypeDescriptionId = new DataColumn("CoverageTypeDescriptionId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageTypeDescriptionId);
      this.columnCoverageTypeId = new DataColumn("CoverageTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageTypeId);
      this.columnCoverageTypeDescription = new DataColumn("CoverageTypeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageTypeDescription);
      this.columnSublineCode = new DataColumn("SublineCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSublineCode);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCoverageTypeDescriptionId
      }, true));
      this.columnCoverageTypeDescriptionId.AutoIncrement = true;
      this.columnCoverageTypeDescriptionId.AllowDBNull = false;
      this.columnCoverageTypeDescriptionId.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.CoverageTypeDescriptionsRow NewCoverageTypeDescriptionsRow()
    {
      return (dsClaimsAdministration.CoverageTypeDescriptionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsAdministration.CoverageTypeDescriptionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsClaimsAdministration.CoverageTypeDescriptionsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.CoverageTypeDescriptionsRowChanged == null)
        return;
      this.CoverageTypeDescriptionsRowChanged((object) this, new dsClaimsAdministration.CoverageTypeDescriptionsRowChangeEvent((dsClaimsAdministration.CoverageTypeDescriptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.CoverageTypeDescriptionsRowChanging == null)
        return;
      this.CoverageTypeDescriptionsRowChanging((object) this, new dsClaimsAdministration.CoverageTypeDescriptionsRowChangeEvent((dsClaimsAdministration.CoverageTypeDescriptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.CoverageTypeDescriptionsRowDeleted == null)
        return;
      this.CoverageTypeDescriptionsRowDeleted((object) this, new dsClaimsAdministration.CoverageTypeDescriptionsRowChangeEvent((dsClaimsAdministration.CoverageTypeDescriptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.CoverageTypeDescriptionsRowDeleting == null)
        return;
      this.CoverageTypeDescriptionsRowDeleting((object) this, new dsClaimsAdministration.CoverageTypeDescriptionsRowChangeEvent((dsClaimsAdministration.CoverageTypeDescriptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveCoverageTypeDescriptionsRow(
      dsClaimsAdministration.CoverageTypeDescriptionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsAdministration claimsAdministration = new dsClaimsAdministration();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = claimsAdministration.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CoverageTypeDescriptionsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = claimsAdministration.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class OutsideAdjusterAddressesDataTable : 
    TypedTableBase<dsClaimsAdministration.OutsideAdjusterAddressesRow>
  {
    private DataColumn columnAddressId;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnCounty;
    private DataColumn columnZipCode;
    private DataColumn columnZipCodeExtension;
    private DataColumn columnIsInternational;
    private DataColumn columnInternationalZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public OutsideAdjusterAddressesDataTable()
    {
      this.TableName = "OutsideAdjusterAddresses";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal OutsideAdjusterAddressesDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected OutsideAdjusterAddressesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AddressIdColumn => this.columnAddressId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Address1Column => this.columnAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Address2Column => this.columnAddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CountyColumn => this.columnCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ZipCodeExtensionColumn => this.columnZipCodeExtension;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn IsInternationalColumn => this.columnIsInternational;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn InternationalZipCodeColumn => this.columnInternationalZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjusterAddressesRow this[int index]
    {
      get => (dsClaimsAdministration.OutsideAdjusterAddressesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.OutsideAdjusterAddressesRowChangeEventHandler OutsideAdjusterAddressesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.OutsideAdjusterAddressesRowChangeEventHandler OutsideAdjusterAddressesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.OutsideAdjusterAddressesRowChangeEventHandler OutsideAdjusterAddressesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.OutsideAdjusterAddressesRowChangeEventHandler OutsideAdjusterAddressesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddOutsideAdjusterAddressesRow(
      dsClaimsAdministration.OutsideAdjusterAddressesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjusterAddressesRow AddOutsideAdjusterAddressesRow(
      int AddressId,
      string Address1,
      string Address2,
      string City,
      string State,
      string County,
      string ZipCode,
      string ZipCodeExtension,
      bool IsInternational,
      string InternationalZipCode)
    {
      dsClaimsAdministration.OutsideAdjusterAddressesRow row = (dsClaimsAdministration.OutsideAdjusterAddressesRow) this.NewRow();
      object[] objArray = new object[10]
      {
        (object) AddressId,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) State,
        (object) County,
        (object) ZipCode,
        (object) ZipCodeExtension,
        (object) IsInternational,
        (object) InternationalZipCode
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjusterAddressesRow FindByAddressId(int AddressId)
    {
      return (dsClaimsAdministration.OutsideAdjusterAddressesRow) this.Rows.Find(new object[1]
      {
        (object) AddressId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsAdministration.OutsideAdjusterAddressesDataTable addressesDataTable = (dsClaimsAdministration.OutsideAdjusterAddressesDataTable) base.Clone();
      addressesDataTable.InitVars();
      return (DataTable) addressesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsAdministration.OutsideAdjusterAddressesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnAddressId = this.Columns["AddressId"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnCounty = this.Columns["County"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnZipCodeExtension = this.Columns["ZipCodeExtension"];
      this.columnIsInternational = this.Columns["IsInternational"];
      this.columnInternationalZipCode = this.Columns["InternationalZipCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnAddressId = new DataColumn("AddressId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddressId);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnAddress2 = new DataColumn("Address2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnCounty = new DataColumn("County", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCounty);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnZipCodeExtension = new DataColumn("ZipCodeExtension", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCodeExtension);
      this.columnIsInternational = new DataColumn("IsInternational", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsInternational);
      this.columnInternationalZipCode = new DataColumn("InternationalZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInternationalZipCode);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnAddressId
      }, true));
      this.columnAddressId.AllowDBNull = false;
      this.columnAddressId.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjusterAddressesRow NewOutsideAdjusterAddressesRow()
    {
      return (dsClaimsAdministration.OutsideAdjusterAddressesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsAdministration.OutsideAdjusterAddressesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsClaimsAdministration.OutsideAdjusterAddressesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.OutsideAdjusterAddressesRowChanged == null)
        return;
      this.OutsideAdjusterAddressesRowChanged((object) this, new dsClaimsAdministration.OutsideAdjusterAddressesRowChangeEvent((dsClaimsAdministration.OutsideAdjusterAddressesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.OutsideAdjusterAddressesRowChanging == null)
        return;
      this.OutsideAdjusterAddressesRowChanging((object) this, new dsClaimsAdministration.OutsideAdjusterAddressesRowChangeEvent((dsClaimsAdministration.OutsideAdjusterAddressesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.OutsideAdjusterAddressesRowDeleted == null)
        return;
      this.OutsideAdjusterAddressesRowDeleted((object) this, new dsClaimsAdministration.OutsideAdjusterAddressesRowChangeEvent((dsClaimsAdministration.OutsideAdjusterAddressesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.OutsideAdjusterAddressesRowDeleting == null)
        return;
      this.OutsideAdjusterAddressesRowDeleting((object) this, new dsClaimsAdministration.OutsideAdjusterAddressesRowChangeEvent((dsClaimsAdministration.OutsideAdjusterAddressesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveOutsideAdjusterAddressesRow(
      dsClaimsAdministration.OutsideAdjusterAddressesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsAdministration claimsAdministration = new dsClaimsAdministration();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = claimsAdministration.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (OutsideAdjusterAddressesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = claimsAdministration.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class OutsideAdjusterAddressPhoneNumbersDataTable : 
    TypedTableBase<dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow>
  {
    private DataColumn columnAddressId;
    private DataColumn columnPhoneNumberId;
    private DataColumn columnPhoneNumber;
    private DataColumn columnPhoneTypeId;
    private DataColumn columnPhoneType;
    private DataColumn columnCountryCode;
    private DataColumn columnInputMask;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public OutsideAdjusterAddressPhoneNumbersDataTable()
    {
      this.TableName = "OutsideAdjusterAddressPhoneNumbers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal OutsideAdjusterAddressPhoneNumbersDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected OutsideAdjusterAddressPhoneNumbersDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AddressIdColumn => this.columnAddressId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PhoneNumberIdColumn => this.columnPhoneNumberId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PhoneNumberColumn => this.columnPhoneNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PhoneTypeIdColumn => this.columnPhoneTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PhoneTypeColumn => this.columnPhoneType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CountryCodeColumn => this.columnCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn InputMaskColumn => this.columnInputMask;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow this[int index]
    {
      get => (dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRowChangeEventHandler OutsideAdjusterAddressPhoneNumbersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRowChangeEventHandler OutsideAdjusterAddressPhoneNumbersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRowChangeEventHandler OutsideAdjusterAddressPhoneNumbersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRowChangeEventHandler OutsideAdjusterAddressPhoneNumbersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddOutsideAdjusterAddressPhoneNumbersRow(
      dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow AddOutsideAdjusterAddressPhoneNumbersRow(
      dsClaimsAdministration.OutsideAdjusterAddressesRow parentOutsideAdjusterAddressesRowByOutsideAdjusterAddresses_OutsideAdjusterAddressPhoneNumbers,
      string PhoneNumber,
      int PhoneTypeId,
      string PhoneType,
      string CountryCode,
      string InputMask)
    {
      dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow row = (dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        null,
        (object) PhoneNumber,
        (object) PhoneTypeId,
        (object) PhoneType,
        (object) CountryCode,
        (object) InputMask
      };
      if (parentOutsideAdjusterAddressesRowByOutsideAdjusterAddresses_OutsideAdjusterAddressPhoneNumbers != null)
        objArray[0] = parentOutsideAdjusterAddressesRowByOutsideAdjusterAddresses_OutsideAdjusterAddressPhoneNumbers[0];
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow FindByAddressIdPhoneNumberId(
      int AddressId,
      int PhoneNumberId)
    {
      return (dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow) this.Rows.Find(new object[2]
      {
        (object) AddressId,
        (object) PhoneNumberId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersDataTable numbersDataTable = (dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersDataTable) base.Clone();
      numbersDataTable.InitVars();
      return (DataTable) numbersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnAddressId = this.Columns["AddressId"];
      this.columnPhoneNumberId = this.Columns["PhoneNumberId"];
      this.columnPhoneNumber = this.Columns["PhoneNumber"];
      this.columnPhoneTypeId = this.Columns["PhoneTypeId"];
      this.columnPhoneType = this.Columns["PhoneType"];
      this.columnCountryCode = this.Columns["CountryCode"];
      this.columnInputMask = this.Columns["InputMask"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnAddressId = new DataColumn("AddressId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddressId);
      this.columnPhoneNumberId = new DataColumn("PhoneNumberId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhoneNumberId);
      this.columnPhoneNumber = new DataColumn("PhoneNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhoneNumber);
      this.columnPhoneTypeId = new DataColumn("PhoneTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhoneTypeId);
      this.columnPhoneType = new DataColumn("PhoneType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhoneType);
      this.columnCountryCode = new DataColumn("CountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCountryCode);
      this.columnInputMask = new DataColumn("InputMask", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInputMask);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnAddressId,
        this.columnPhoneNumberId
      }, true));
      this.columnAddressId.AllowDBNull = false;
      this.columnPhoneNumberId.AutoIncrement = true;
      this.columnPhoneNumberId.AutoIncrementSeed = -1L;
      this.columnPhoneNumberId.AutoIncrementStep = -1L;
      this.columnPhoneNumberId.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow NewOutsideAdjusterAddressPhoneNumbersRow()
    {
      return (dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.OutsideAdjusterAddressPhoneNumbersRowChanged == null)
        return;
      this.OutsideAdjusterAddressPhoneNumbersRowChanged((object) this, new dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRowChangeEvent((dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.OutsideAdjusterAddressPhoneNumbersRowChanging == null)
        return;
      this.OutsideAdjusterAddressPhoneNumbersRowChanging((object) this, new dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRowChangeEvent((dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.OutsideAdjusterAddressPhoneNumbersRowDeleted == null)
        return;
      this.OutsideAdjusterAddressPhoneNumbersRowDeleted((object) this, new dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRowChangeEvent((dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.OutsideAdjusterAddressPhoneNumbersRowDeleting == null)
        return;
      this.OutsideAdjusterAddressPhoneNumbersRowDeleting((object) this, new dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRowChangeEvent((dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveOutsideAdjusterAddressPhoneNumbersRow(
      dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsAdministration claimsAdministration = new dsClaimsAdministration();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = claimsAdministration.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (OutsideAdjusterAddressPhoneNumbersDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = claimsAdministration.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  public class AccidentTypesRow : DataRow
  {
    private dsClaimsAdministration.AccidentTypesDataTable tableAccidentTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal AccidentTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAccidentTypes = (dsClaimsAdministration.AccidentTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int AccidentTypeId
    {
      get => (int) this[this.tableAccidentTypes.AccidentTypeIdColumn];
      set => this[this.tableAccidentTypes.AccidentTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string AccidentType
    {
      get
      {
        try
        {
          return (string) this[this.tableAccidentTypes.AccidentTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AccidentType' in table 'AccidentTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccidentTypes.AccidentTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAccidentTypeNull() => this.IsNull(this.tableAccidentTypes.AccidentTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAccidentTypeNull()
    {
      this[this.tableAccidentTypes.AccidentTypeColumn] = Convert.DBNull;
    }
  }

  public class CoverageTypesRow : DataRow
  {
    private dsClaimsAdministration.CoverageTypesDataTable tableCoverageTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal CoverageTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCoverageTypes = (dsClaimsAdministration.CoverageTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int CoverageTypeId
    {
      get => (int) this[this.tableCoverageTypes.CoverageTypeIdColumn];
      set => this[this.tableCoverageTypes.CoverageTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string CoverageType
    {
      get
      {
        try
        {
          return (string) this[this.tableCoverageTypes.CoverageTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CoverageType' in table 'CoverageTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCoverageTypes.CoverageTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string CoverageTypeDescription
    {
      get
      {
        try
        {
          return (string) this[this.tableCoverageTypes.CoverageTypeDescriptionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CoverageTypeDescription' in table 'CoverageTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCoverageTypes.CoverageTypeDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCoverageTypeNull() => this.IsNull(this.tableCoverageTypes.CoverageTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCoverageTypeNull()
    {
      this[this.tableCoverageTypes.CoverageTypeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCoverageTypeDescriptionNull()
    {
      return this.IsNull(this.tableCoverageTypes.CoverageTypeDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCoverageTypeDescriptionNull()
    {
      this[this.tableCoverageTypes.CoverageTypeDescriptionColumn] = Convert.DBNull;
    }
  }

  public class CatastropheCodesRow : DataRow
  {
    private dsClaimsAdministration.CatastropheCodesDataTable tableCatastropheCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal CatastropheCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCatastropheCodes = (dsClaimsAdministration.CatastropheCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int CatastropheCodeId
    {
      get => (int) this[this.tableCatastropheCodes.CatastropheCodeIdColumn];
      set => this[this.tableCatastropheCodes.CatastropheCodeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string CatastropheCode
    {
      get
      {
        try
        {
          return (string) this[this.tableCatastropheCodes.CatastropheCodeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CatastropheCode' in table 'CatastropheCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCatastropheCodes.CatastropheCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string CatastropheCodeDescription
    {
      get
      {
        try
        {
          return (string) this[this.tableCatastropheCodes.CatastropheCodeDescriptionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CatastropheCodeDescription' in table 'CatastropheCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCatastropheCodes.CatastropheCodeDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCatastropheCodeNull()
    {
      return this.IsNull(this.tableCatastropheCodes.CatastropheCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCatastropheCodeNull()
    {
      this[this.tableCatastropheCodes.CatastropheCodeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCatastropheCodeDescriptionNull()
    {
      return this.IsNull(this.tableCatastropheCodes.CatastropheCodeDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCatastropheCodeDescriptionNull()
    {
      this[this.tableCatastropheCodes.CatastropheCodeDescriptionColumn] = Convert.DBNull;
    }
  }

  public class LossTypesRow : DataRow
  {
    private dsClaimsAdministration.LossTypesDataTable tableLossTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal LossTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableLossTypes = (dsClaimsAdministration.LossTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int LossTypeId
    {
      get => (int) this[this.tableLossTypes.LossTypeIdColumn];
      set => this[this.tableLossTypes.LossTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string LossType
    {
      get
      {
        try
        {
          return (string) this[this.tableLossTypes.LossTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'LossType' in table 'LossTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLossTypes.LossTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsLossTypeNull() => this.IsNull(this.tableLossTypes.LossTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetLossTypeNull() => this[this.tableLossTypes.LossTypeColumn] = Convert.DBNull;
  }

  public class ManagedCareFacilitiesRow : DataRow
  {
    private dsClaimsAdministration.ManagedCareFacilitiesDataTable tableManagedCareFacilities;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal ManagedCareFacilitiesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableManagedCareFacilities = (dsClaimsAdministration.ManagedCareFacilitiesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ManagedCareId
    {
      get => (int) this[this.tableManagedCareFacilities.ManagedCareIdColumn];
      set => this[this.tableManagedCareFacilities.ManagedCareIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string FacilityName
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareFacilities.FacilityNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'FacilityName' in table 'ManagedCareFacilities' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareFacilities.FacilityNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int AddressId
    {
      get
      {
        try
        {
          return (int) this[this.tableManagedCareFacilities.AddressIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AddressId' in table 'ManagedCareFacilities' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareFacilities.AddressIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string WebAddress
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareFacilities.WebAddressColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'WebAddress' in table 'ManagedCareFacilities' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareFacilities.WebAddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string EntityType
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareFacilities.EntityTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EntityType' in table 'ManagedCareFacilities' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareFacilities.EntityTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string FEIN
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareFacilities.FEINColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'FEIN' in table 'ManagedCareFacilities' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareFacilities.FEINColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime DateIncorporated
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableManagedCareFacilities.DateIncorporatedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'DateIncorporated' in table 'ManagedCareFacilities' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareFacilities.DateIncorporatedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string EmailAddress
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareFacilities.EmailAddressColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EmailAddress' in table 'ManagedCareFacilities' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareFacilities.EmailAddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime DateEntered
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableManagedCareFacilities.DateEnteredColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'DateEntered' in table 'ManagedCareFacilities' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareFacilities.DateEnteredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid EnteredByUserGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tableManagedCareFacilities.EnteredByUserGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EnteredByUserGuid' in table 'ManagedCareFacilities' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareFacilities.EnteredByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime DateModified
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableManagedCareFacilities.DateModifiedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'DateModified' in table 'ManagedCareFacilities' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareFacilities.DateModifiedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid ModifiedByUserGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tableManagedCareFacilities.ModifiedByUserGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ModifiedByUserGuid' in table 'ManagedCareFacilities' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareFacilities.ModifiedByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareAddressesRow ManagedCareAddressesRow
    {
      get
      {
        return (dsClaimsAdministration.ManagedCareAddressesRow) this.GetParentRow(this.Table.ParentRelations["ManagedCareAddresses_ManagedCareFacilities"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["ManagedCareAddresses_ManagedCareFacilities"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFacilityNameNull()
    {
      return this.IsNull(this.tableManagedCareFacilities.FacilityNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFacilityNameNull()
    {
      this[this.tableManagedCareFacilities.FacilityNameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAddressIdNull() => this.IsNull(this.tableManagedCareFacilities.AddressIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAddressIdNull()
    {
      this[this.tableManagedCareFacilities.AddressIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsWebAddressNull() => this.IsNull(this.tableManagedCareFacilities.WebAddressColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetWebAddressNull()
    {
      this[this.tableManagedCareFacilities.WebAddressColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEntityTypeNull() => this.IsNull(this.tableManagedCareFacilities.EntityTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEntityTypeNull()
    {
      this[this.tableManagedCareFacilities.EntityTypeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFEINNull() => this.IsNull(this.tableManagedCareFacilities.FEINColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFEINNull() => this[this.tableManagedCareFacilities.FEINColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDateIncorporatedNull()
    {
      return this.IsNull(this.tableManagedCareFacilities.DateIncorporatedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDateIncorporatedNull()
    {
      this[this.tableManagedCareFacilities.DateIncorporatedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEmailAddressNull()
    {
      return this.IsNull(this.tableManagedCareFacilities.EmailAddressColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEmailAddressNull()
    {
      this[this.tableManagedCareFacilities.EmailAddressColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDateEnteredNull()
    {
      return this.IsNull(this.tableManagedCareFacilities.DateEnteredColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDateEnteredNull()
    {
      this[this.tableManagedCareFacilities.DateEnteredColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEnteredByUserGuidNull()
    {
      return this.IsNull(this.tableManagedCareFacilities.EnteredByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEnteredByUserGuidNull()
    {
      this[this.tableManagedCareFacilities.EnteredByUserGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDateModifiedNull()
    {
      return this.IsNull(this.tableManagedCareFacilities.DateModifiedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDateModifiedNull()
    {
      this[this.tableManagedCareFacilities.DateModifiedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsModifiedByUserGuidNull()
    {
      return this.IsNull(this.tableManagedCareFacilities.ModifiedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetModifiedByUserGuidNull()
    {
      this[this.tableManagedCareFacilities.ModifiedByUserGuidColumn] = Convert.DBNull;
    }
  }

  public class ManagedCareAddressesRow : DataRow
  {
    private dsClaimsAdministration.ManagedCareAddressesDataTable tableManagedCareAddresses;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal ManagedCareAddressesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableManagedCareAddresses = (dsClaimsAdministration.ManagedCareAddressesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int AddressId
    {
      get => (int) this[this.tableManagedCareAddresses.AddressIdColumn];
      set => this[this.tableManagedCareAddresses.AddressIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareAddresses.Address1Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Address1' in table 'ManagedCareAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareAddresses.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareAddresses.Address2Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Address2' in table 'ManagedCareAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareAddresses.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareAddresses.CityColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'City' in table 'ManagedCareAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareAddresses.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareAddresses.StateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'State' in table 'ManagedCareAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareAddresses.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string County
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareAddresses.CountyColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'County' in table 'ManagedCareAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareAddresses.CountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareAddresses.ZipCodeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ZipCode' in table 'ManagedCareAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareAddresses.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ZipCodeExtension
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareAddresses.ZipCodeExtensionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ZipCodeExtension' in table 'ManagedCareAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareAddresses.ZipCodeExtensionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsInternational
    {
      get
      {
        try
        {
          return (bool) this[this.tableManagedCareAddresses.IsInternationalColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'IsInternational' in table 'ManagedCareAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareAddresses.IsInternationalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string InternationalZipCode
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareAddresses.InternationalZipCodeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'InternationalZipCode' in table 'ManagedCareAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareAddresses.InternationalZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ISOCountryCode
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareAddresses.ISOCountryCodeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ISOCountryCode' in table 'ManagedCareAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareAddresses.ISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAddress1Null() => this.IsNull(this.tableManagedCareAddresses.Address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tableManagedCareAddresses.Address1Column] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAddress2Null() => this.IsNull(this.tableManagedCareAddresses.Address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tableManagedCareAddresses.Address2Column] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tableManagedCareAddresses.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCityNull() => this[this.tableManagedCareAddresses.CityColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tableManagedCareAddresses.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetStateNull() => this[this.tableManagedCareAddresses.StateColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCountyNull() => this.IsNull(this.tableManagedCareAddresses.CountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCountyNull()
    {
      this[this.tableManagedCareAddresses.CountyColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tableManagedCareAddresses.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tableManagedCareAddresses.ZipCodeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsZipCodeExtensionNull()
    {
      return this.IsNull(this.tableManagedCareAddresses.ZipCodeExtensionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetZipCodeExtensionNull()
    {
      this[this.tableManagedCareAddresses.ZipCodeExtensionColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsIsInternationalNull()
    {
      return this.IsNull(this.tableManagedCareAddresses.IsInternationalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetIsInternationalNull()
    {
      this[this.tableManagedCareAddresses.IsInternationalColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsInternationalZipCodeNull()
    {
      return this.IsNull(this.tableManagedCareAddresses.InternationalZipCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetInternationalZipCodeNull()
    {
      this[this.tableManagedCareAddresses.InternationalZipCodeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsISOCountryCodeNull()
    {
      return this.IsNull(this.tableManagedCareAddresses.ISOCountryCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetISOCountryCodeNull()
    {
      this[this.tableManagedCareAddresses.ISOCountryCodeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareFacilitiesRow[] GetManagedCareFacilitiesRows()
    {
      return this.Table.ChildRelations["ManagedCareAddresses_ManagedCareFacilities"] == null ? new dsClaimsAdministration.ManagedCareFacilitiesRow[0] : (dsClaimsAdministration.ManagedCareFacilitiesRow[]) this.GetChildRows(this.Table.ChildRelations["ManagedCareAddresses_ManagedCareFacilities"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow[] GetManagedCareAddressPhoneNumbersRows()
    {
      return this.Table.ChildRelations["ManagedCareAddresses_ManagedCareAddressPhoneNumbers"] == null ? new dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow[0] : (dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow[]) this.GetChildRows(this.Table.ChildRelations["ManagedCareAddresses_ManagedCareAddressPhoneNumbers"]);
    }
  }

  public class ManagedCareAddressPhoneNumbersRow : DataRow
  {
    private dsClaimsAdministration.ManagedCareAddressPhoneNumbersDataTable tableManagedCareAddressPhoneNumbers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal ManagedCareAddressPhoneNumbersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableManagedCareAddressPhoneNumbers = (dsClaimsAdministration.ManagedCareAddressPhoneNumbersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int AddressId
    {
      get => (int) this[this.tableManagedCareAddressPhoneNumbers.AddressIdColumn];
      set => this[this.tableManagedCareAddressPhoneNumbers.AddressIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int PhoneNumberId
    {
      get => (int) this[this.tableManagedCareAddressPhoneNumbers.PhoneNumberIdColumn];
      set => this[this.tableManagedCareAddressPhoneNumbers.PhoneNumberIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PhoneNumber
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareAddressPhoneNumbers.PhoneNumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PhoneNumber' in table 'ManagedCareAddressPhoneNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareAddressPhoneNumbers.PhoneNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int PhoneTypeId
    {
      get
      {
        try
        {
          return (int) this[this.tableManagedCareAddressPhoneNumbers.PhoneTypeIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PhoneTypeId' in table 'ManagedCareAddressPhoneNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareAddressPhoneNumbers.PhoneTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PhoneType
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareAddressPhoneNumbers.PhoneTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PhoneType' in table 'ManagedCareAddressPhoneNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareAddressPhoneNumbers.PhoneTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string CountryCode
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareAddressPhoneNumbers.CountryCodeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CountryCode' in table 'ManagedCareAddressPhoneNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareAddressPhoneNumbers.CountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string InputMask
    {
      get
      {
        try
        {
          return (string) this[this.tableManagedCareAddressPhoneNumbers.InputMaskColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'InputMask' in table 'ManagedCareAddressPhoneNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableManagedCareAddressPhoneNumbers.InputMaskColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareAddressesRow ManagedCareAddressesRow
    {
      get
      {
        return (dsClaimsAdministration.ManagedCareAddressesRow) this.GetParentRow(this.Table.ParentRelations["ManagedCareAddresses_ManagedCareAddressPhoneNumbers"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["ManagedCareAddresses_ManagedCareAddressPhoneNumbers"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPhoneNumberNull()
    {
      return this.IsNull(this.tableManagedCareAddressPhoneNumbers.PhoneNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPhoneNumberNull()
    {
      this[this.tableManagedCareAddressPhoneNumbers.PhoneNumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPhoneTypeIdNull()
    {
      return this.IsNull(this.tableManagedCareAddressPhoneNumbers.PhoneTypeIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPhoneTypeIdNull()
    {
      this[this.tableManagedCareAddressPhoneNumbers.PhoneTypeIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPhoneTypeNull()
    {
      return this.IsNull(this.tableManagedCareAddressPhoneNumbers.PhoneTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPhoneTypeNull()
    {
      this[this.tableManagedCareAddressPhoneNumbers.PhoneTypeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCountryCodeNull()
    {
      return this.IsNull(this.tableManagedCareAddressPhoneNumbers.CountryCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCountryCodeNull()
    {
      this[this.tableManagedCareAddressPhoneNumbers.CountryCodeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsInputMaskNull()
    {
      return this.IsNull(this.tableManagedCareAddressPhoneNumbers.InputMaskColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetInputMaskNull()
    {
      this[this.tableManagedCareAddressPhoneNumbers.InputMaskColumn] = Convert.DBNull;
    }
  }

  public class ReservePaymentSubTypesRow : DataRow
  {
    private dsClaimsAdministration.ReservePaymentSubTypesDataTable tableReservePaymentSubTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal ReservePaymentSubTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableReservePaymentSubTypes = (dsClaimsAdministration.ReservePaymentSubTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ResPaySubTypeId
    {
      get => (int) this[this.tableReservePaymentSubTypes.ResPaySubTypeIdColumn];
      set => this[this.tableReservePaymentSubTypes.ResPaySubTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ResPayTypeId
    {
      get
      {
        try
        {
          return (int) this[this.tableReservePaymentSubTypes.ResPayTypeIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ResPayTypeId' in table 'ReservePaymentSubTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservePaymentSubTypes.ResPayTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ResPaySubTypeDescription
    {
      get
      {
        try
        {
          return (string) this[this.tableReservePaymentSubTypes.ResPaySubTypeDescriptionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ResPaySubTypeDescription' in table 'ReservePaymentSubTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservePaymentSubTypes.ResPaySubTypeDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Allocated
    {
      get
      {
        try
        {
          return (bool) this[this.tableReservePaymentSubTypes.AllocatedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Allocated' in table 'ReservePaymentSubTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservePaymentSubTypes.AllocatedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsResPayTypeIdNull()
    {
      return this.IsNull(this.tableReservePaymentSubTypes.ResPayTypeIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetResPayTypeIdNull()
    {
      this[this.tableReservePaymentSubTypes.ResPayTypeIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsResPaySubTypeDescriptionNull()
    {
      return this.IsNull(this.tableReservePaymentSubTypes.ResPaySubTypeDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetResPaySubTypeDescriptionNull()
    {
      this[this.tableReservePaymentSubTypes.ResPaySubTypeDescriptionColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAllocatedNull() => this.IsNull(this.tableReservePaymentSubTypes.AllocatedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAllocatedNull()
    {
      this[this.tableReservePaymentSubTypes.AllocatedColumn] = Convert.DBNull;
    }
  }

  public class ReservePaymentTypesRow : DataRow
  {
    private dsClaimsAdministration.ReservePaymentTypesDataTable tableReservePaymentTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal ReservePaymentTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableReservePaymentTypes = (dsClaimsAdministration.ReservePaymentTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ResPayTypeId
    {
      get => (int) this[this.tableReservePaymentTypes.ResPayTypeIdColumn];
      set => this[this.tableReservePaymentTypes.ResPayTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ResPayTypeDescription
    {
      get
      {
        try
        {
          return (string) this[this.tableReservePaymentTypes.ResPayTypeDescriptionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ResPayTypeDescription' in table 'ReservePaymentTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservePaymentTypes.ResPayTypeDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsResPayTypeDescriptionNull()
    {
      return this.IsNull(this.tableReservePaymentTypes.ResPayTypeDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetResPayTypeDescriptionNull()
    {
      this[this.tableReservePaymentTypes.ResPayTypeDescriptionColumn] = Convert.DBNull;
    }
  }

  public class SettlementTypesRow : DataRow
  {
    private dsClaimsAdministration.SettlementTypesDataTable tableSettlementTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal SettlementTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableSettlementTypes = (dsClaimsAdministration.SettlementTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int SettlementTypeId
    {
      get => (int) this[this.tableSettlementTypes.SettlementTypeIdColumn];
      set => this[this.tableSettlementTypes.SettlementTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string SettlementType
    {
      get
      {
        try
        {
          return (string) this[this.tableSettlementTypes.SettlementTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'SettlementType' in table 'SettlementTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettlementTypes.SettlementTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsSettlementTypeNull()
    {
      return this.IsNull(this.tableSettlementTypes.SettlementTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetSettlementTypeNull()
    {
      this[this.tableSettlementTypes.SettlementTypeColumn] = Convert.DBNull;
    }
  }

  public class CoverageTypeDescriptionsRow : DataRow
  {
    private dsClaimsAdministration.CoverageTypeDescriptionsDataTable tableCoverageTypeDescriptions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal CoverageTypeDescriptionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCoverageTypeDescriptions = (dsClaimsAdministration.CoverageTypeDescriptionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int CoverageTypeDescriptionId
    {
      get => (int) this[this.tableCoverageTypeDescriptions.CoverageTypeDescriptionIdColumn];
      set
      {
        this[this.tableCoverageTypeDescriptions.CoverageTypeDescriptionIdColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int CoverageTypeId
    {
      get
      {
        try
        {
          return (int) this[this.tableCoverageTypeDescriptions.CoverageTypeIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CoverageTypeId' in table 'CoverageTypeDescriptions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCoverageTypeDescriptions.CoverageTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string CoverageTypeDescription
    {
      get
      {
        try
        {
          return (string) this[this.tableCoverageTypeDescriptions.CoverageTypeDescriptionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CoverageTypeDescription' in table 'CoverageTypeDescriptions' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tableCoverageTypeDescriptions.CoverageTypeDescriptionColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string SublineCode
    {
      get
      {
        return this.IsSublineCodeNull() ? string.Empty : (string) this[this.tableCoverageTypeDescriptions.SublineCodeColumn];
      }
      set => this[this.tableCoverageTypeDescriptions.SublineCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCoverageTypeIdNull()
    {
      return this.IsNull(this.tableCoverageTypeDescriptions.CoverageTypeIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCoverageTypeIdNull()
    {
      this[this.tableCoverageTypeDescriptions.CoverageTypeIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCoverageTypeDescriptionNull()
    {
      return this.IsNull(this.tableCoverageTypeDescriptions.CoverageTypeDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCoverageTypeDescriptionNull()
    {
      this[this.tableCoverageTypeDescriptions.CoverageTypeDescriptionColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsSublineCodeNull()
    {
      return this.IsNull(this.tableCoverageTypeDescriptions.SublineCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetSublineCodeNull()
    {
      this[this.tableCoverageTypeDescriptions.SublineCodeColumn] = Convert.DBNull;
    }
  }

  public class OutsideAdjustersRow : DataRow
  {
    private dsClaimsAdministration.OutsideAdjustersDataTable tableOutsideAdjusters;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal OutsideAdjustersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOutsideAdjusters = (dsClaimsAdministration.OutsideAdjustersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid AdjusterGuid
    {
      get => (Guid) this[this.tableOutsideAdjusters.AdjusterGuidColumn];
      set => this[this.tableOutsideAdjusters.AdjusterGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string OutsideAdjuster
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusters.OutsideAdjusterColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'OutsideAdjuster' in table 'OutsideAdjusters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusters.OutsideAdjusterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Company
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusters.CompanyColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Company' in table 'OutsideAdjusters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusters.CompanyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string FirstName
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusters.FirstNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'FirstName' in table 'OutsideAdjusters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusters.FirstNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string MiddleName
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusters.MiddleNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'MiddleName' in table 'OutsideAdjusters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusters.MiddleNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string LastName
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusters.LastNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'LastName' in table 'OutsideAdjusters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusters.LastNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int AddressId
    {
      get
      {
        try
        {
          return (int) this[this.tableOutsideAdjusters.AddressIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AddressId' in table 'OutsideAdjusters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusters.AddressIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string EmailAddress
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusters.EmailAddressColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EmailAddress' in table 'OutsideAdjusters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusters.EmailAddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string SSNFEIN
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusters.SSNFEINColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'SSNFEIN' in table 'OutsideAdjusters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusters.SSNFEINColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string EntityType
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusters.EntityTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EntityType' in table 'OutsideAdjusters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusters.EntityTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid EnteredByUserGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tableOutsideAdjusters.EnteredByUserGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EnteredByUserGuid' in table 'OutsideAdjusters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusters.EnteredByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime EnteredOn
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableOutsideAdjusters.EnteredOnColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EnteredOn' in table 'OutsideAdjusters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusters.EnteredOnColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid ModifiedByUserGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tableOutsideAdjusters.ModifiedByUserGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ModifiedByUserGuid' in table 'OutsideAdjusters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusters.ModifiedByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime ModifiedOn
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableOutsideAdjusters.ModifiedOnColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ModifiedOn' in table 'OutsideAdjusters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusters.ModifiedOnColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjusterAddressesRow OutsideAdjusterAddressesRow
    {
      get
      {
        return (dsClaimsAdministration.OutsideAdjusterAddressesRow) this.GetParentRow(this.Table.ParentRelations["OutsideAdjusterAddresses_OutsideAdjusters"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["OutsideAdjusterAddresses_OutsideAdjusters"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsOutsideAdjusterNull()
    {
      return this.IsNull(this.tableOutsideAdjusters.OutsideAdjusterColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetOutsideAdjusterNull()
    {
      this[this.tableOutsideAdjusters.OutsideAdjusterColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCompanyNull() => this.IsNull(this.tableOutsideAdjusters.CompanyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCompanyNull() => this[this.tableOutsideAdjusters.CompanyColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFirstNameNull() => this.IsNull(this.tableOutsideAdjusters.FirstNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFirstNameNull()
    {
      this[this.tableOutsideAdjusters.FirstNameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsMiddleNameNull() => this.IsNull(this.tableOutsideAdjusters.MiddleNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetMiddleNameNull()
    {
      this[this.tableOutsideAdjusters.MiddleNameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsLastNameNull() => this.IsNull(this.tableOutsideAdjusters.LastNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetLastNameNull()
    {
      this[this.tableOutsideAdjusters.LastNameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAddressIdNull() => this.IsNull(this.tableOutsideAdjusters.AddressIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAddressIdNull()
    {
      this[this.tableOutsideAdjusters.AddressIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEmailAddressNull() => this.IsNull(this.tableOutsideAdjusters.EmailAddressColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEmailAddressNull()
    {
      this[this.tableOutsideAdjusters.EmailAddressColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsSSNFEINNull() => this.IsNull(this.tableOutsideAdjusters.SSNFEINColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetSSNFEINNull() => this[this.tableOutsideAdjusters.SSNFEINColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEntityTypeNull() => this.IsNull(this.tableOutsideAdjusters.EntityTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEntityTypeNull()
    {
      this[this.tableOutsideAdjusters.EntityTypeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEnteredByUserGuidNull()
    {
      return this.IsNull(this.tableOutsideAdjusters.EnteredByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEnteredByUserGuidNull()
    {
      this[this.tableOutsideAdjusters.EnteredByUserGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEnteredOnNull() => this.IsNull(this.tableOutsideAdjusters.EnteredOnColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEnteredOnNull()
    {
      this[this.tableOutsideAdjusters.EnteredOnColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsModifiedByUserGuidNull()
    {
      return this.IsNull(this.tableOutsideAdjusters.ModifiedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetModifiedByUserGuidNull()
    {
      this[this.tableOutsideAdjusters.ModifiedByUserGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsModifiedOnNull() => this.IsNull(this.tableOutsideAdjusters.ModifiedOnColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetModifiedOnNull()
    {
      this[this.tableOutsideAdjusters.ModifiedOnColumn] = Convert.DBNull;
    }
  }

  public class OutsideAdjusterAddressesRow : DataRow
  {
    private dsClaimsAdministration.OutsideAdjusterAddressesDataTable tableOutsideAdjusterAddresses;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal OutsideAdjusterAddressesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOutsideAdjusterAddresses = (dsClaimsAdministration.OutsideAdjusterAddressesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int AddressId
    {
      get => (int) this[this.tableOutsideAdjusterAddresses.AddressIdColumn];
      set => this[this.tableOutsideAdjusterAddresses.AddressIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusterAddresses.Address1Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Address1' in table 'OutsideAdjusterAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusterAddresses.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusterAddresses.Address2Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Address2' in table 'OutsideAdjusterAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusterAddresses.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusterAddresses.CityColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'City' in table 'OutsideAdjusterAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusterAddresses.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusterAddresses.StateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'State' in table 'OutsideAdjusterAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusterAddresses.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string County
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusterAddresses.CountyColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'County' in table 'OutsideAdjusterAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusterAddresses.CountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusterAddresses.ZipCodeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ZipCode' in table 'OutsideAdjusterAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusterAddresses.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ZipCodeExtension
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusterAddresses.ZipCodeExtensionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ZipCodeExtension' in table 'OutsideAdjusterAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusterAddresses.ZipCodeExtensionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsInternational
    {
      get
      {
        try
        {
          return (bool) this[this.tableOutsideAdjusterAddresses.IsInternationalColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'IsInternational' in table 'OutsideAdjusterAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusterAddresses.IsInternationalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string InternationalZipCode
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusterAddresses.InternationalZipCodeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'InternationalZipCode' in table 'OutsideAdjusterAddresses' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusterAddresses.InternationalZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAddress1Null() => this.IsNull(this.tableOutsideAdjusterAddresses.Address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tableOutsideAdjusterAddresses.Address1Column] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAddress2Null() => this.IsNull(this.tableOutsideAdjusterAddresses.Address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tableOutsideAdjusterAddresses.Address2Column] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tableOutsideAdjusterAddresses.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCityNull()
    {
      this[this.tableOutsideAdjusterAddresses.CityColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tableOutsideAdjusterAddresses.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetStateNull()
    {
      this[this.tableOutsideAdjusterAddresses.StateColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCountyNull() => this.IsNull(this.tableOutsideAdjusterAddresses.CountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCountyNull()
    {
      this[this.tableOutsideAdjusterAddresses.CountyColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tableOutsideAdjusterAddresses.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tableOutsideAdjusterAddresses.ZipCodeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsZipCodeExtensionNull()
    {
      return this.IsNull(this.tableOutsideAdjusterAddresses.ZipCodeExtensionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetZipCodeExtensionNull()
    {
      this[this.tableOutsideAdjusterAddresses.ZipCodeExtensionColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsIsInternationalNull()
    {
      return this.IsNull(this.tableOutsideAdjusterAddresses.IsInternationalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetIsInternationalNull()
    {
      this[this.tableOutsideAdjusterAddresses.IsInternationalColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsInternationalZipCodeNull()
    {
      return this.IsNull(this.tableOutsideAdjusterAddresses.InternationalZipCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetInternationalZipCodeNull()
    {
      this[this.tableOutsideAdjusterAddresses.InternationalZipCodeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjustersRow[] GetOutsideAdjustersRows()
    {
      return this.Table.ChildRelations["OutsideAdjusterAddresses_OutsideAdjusters"] == null ? new dsClaimsAdministration.OutsideAdjustersRow[0] : (dsClaimsAdministration.OutsideAdjustersRow[]) this.GetChildRows(this.Table.ChildRelations["OutsideAdjusterAddresses_OutsideAdjusters"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow[] GetOutsideAdjusterAddressPhoneNumbersRows()
    {
      return this.Table.ChildRelations["OutsideAdjusterAddresses_OutsideAdjusterAddressPhoneNumbers"] == null ? new dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow[0] : (dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow[]) this.GetChildRows(this.Table.ChildRelations["OutsideAdjusterAddresses_OutsideAdjusterAddressPhoneNumbers"]);
    }
  }

  public class OutsideAdjusterAddressPhoneNumbersRow : DataRow
  {
    private dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersDataTable tableOutsideAdjusterAddressPhoneNumbers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal OutsideAdjusterAddressPhoneNumbersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOutsideAdjusterAddressPhoneNumbers = (dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int AddressId
    {
      get => (int) this[this.tableOutsideAdjusterAddressPhoneNumbers.AddressIdColumn];
      set => this[this.tableOutsideAdjusterAddressPhoneNumbers.AddressIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int PhoneNumberId
    {
      get => (int) this[this.tableOutsideAdjusterAddressPhoneNumbers.PhoneNumberIdColumn];
      set
      {
        this[this.tableOutsideAdjusterAddressPhoneNumbers.PhoneNumberIdColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PhoneNumber
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusterAddressPhoneNumbers.PhoneNumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PhoneNumber' in table 'OutsideAdjusterAddressPhoneNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusterAddressPhoneNumbers.PhoneNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int PhoneTypeId
    {
      get
      {
        try
        {
          return (int) this[this.tableOutsideAdjusterAddressPhoneNumbers.PhoneTypeIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PhoneTypeId' in table 'OutsideAdjusterAddressPhoneNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusterAddressPhoneNumbers.PhoneTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PhoneType
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusterAddressPhoneNumbers.PhoneTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PhoneType' in table 'OutsideAdjusterAddressPhoneNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusterAddressPhoneNumbers.PhoneTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string CountryCode
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusterAddressPhoneNumbers.CountryCodeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CountryCode' in table 'OutsideAdjusterAddressPhoneNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusterAddressPhoneNumbers.CountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string InputMask
    {
      get
      {
        try
        {
          return (string) this[this.tableOutsideAdjusterAddressPhoneNumbers.InputMaskColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'InputMask' in table 'OutsideAdjusterAddressPhoneNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutsideAdjusterAddressPhoneNumbers.InputMaskColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjusterAddressesRow OutsideAdjusterAddressesRow
    {
      get
      {
        return (dsClaimsAdministration.OutsideAdjusterAddressesRow) this.GetParentRow(this.Table.ParentRelations["OutsideAdjusterAddresses_OutsideAdjusterAddressPhoneNumbers"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["OutsideAdjusterAddresses_OutsideAdjusterAddressPhoneNumbers"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPhoneNumberNull()
    {
      return this.IsNull(this.tableOutsideAdjusterAddressPhoneNumbers.PhoneNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPhoneNumberNull()
    {
      this[this.tableOutsideAdjusterAddressPhoneNumbers.PhoneNumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPhoneTypeIdNull()
    {
      return this.IsNull(this.tableOutsideAdjusterAddressPhoneNumbers.PhoneTypeIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPhoneTypeIdNull()
    {
      this[this.tableOutsideAdjusterAddressPhoneNumbers.PhoneTypeIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPhoneTypeNull()
    {
      return this.IsNull(this.tableOutsideAdjusterAddressPhoneNumbers.PhoneTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPhoneTypeNull()
    {
      this[this.tableOutsideAdjusterAddressPhoneNumbers.PhoneTypeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCountryCodeNull()
    {
      return this.IsNull(this.tableOutsideAdjusterAddressPhoneNumbers.CountryCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCountryCodeNull()
    {
      this[this.tableOutsideAdjusterAddressPhoneNumbers.CountryCodeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsInputMaskNull()
    {
      return this.IsNull(this.tableOutsideAdjusterAddressPhoneNumbers.InputMaskColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetInputMaskNull()
    {
      this[this.tableOutsideAdjusterAddressPhoneNumbers.InputMaskColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class AccidentTypesRowChangeEvent : EventArgs
  {
    private dsClaimsAdministration.AccidentTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public AccidentTypesRowChangeEvent(
      dsClaimsAdministration.AccidentTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.AccidentTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class CoverageTypesRowChangeEvent : EventArgs
  {
    private dsClaimsAdministration.CoverageTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public CoverageTypesRowChangeEvent(
      dsClaimsAdministration.CoverageTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.CoverageTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class CatastropheCodesRowChangeEvent : EventArgs
  {
    private dsClaimsAdministration.CatastropheCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public CatastropheCodesRowChangeEvent(
      dsClaimsAdministration.CatastropheCodesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.CatastropheCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class LossTypesRowChangeEvent : EventArgs
  {
    private dsClaimsAdministration.LossTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public LossTypesRowChangeEvent(dsClaimsAdministration.LossTypesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.LossTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class ManagedCareFacilitiesRowChangeEvent : EventArgs
  {
    private dsClaimsAdministration.ManagedCareFacilitiesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public ManagedCareFacilitiesRowChangeEvent(
      dsClaimsAdministration.ManagedCareFacilitiesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareFacilitiesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class ManagedCareAddressesRowChangeEvent : EventArgs
  {
    private dsClaimsAdministration.ManagedCareAddressesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public ManagedCareAddressesRowChangeEvent(
      dsClaimsAdministration.ManagedCareAddressesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareAddressesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class ManagedCareAddressPhoneNumbersRowChangeEvent : EventArgs
  {
    private dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public ManagedCareAddressPhoneNumbersRowChangeEvent(
      dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ManagedCareAddressPhoneNumbersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class ReservePaymentSubTypesRowChangeEvent : EventArgs
  {
    private dsClaimsAdministration.ReservePaymentSubTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public ReservePaymentSubTypesRowChangeEvent(
      dsClaimsAdministration.ReservePaymentSubTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ReservePaymentSubTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class ReservePaymentTypesRowChangeEvent : EventArgs
  {
    private dsClaimsAdministration.ReservePaymentTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public ReservePaymentTypesRowChangeEvent(
      dsClaimsAdministration.ReservePaymentTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.ReservePaymentTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class SettlementTypesRowChangeEvent : EventArgs
  {
    private dsClaimsAdministration.SettlementTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public SettlementTypesRowChangeEvent(
      dsClaimsAdministration.SettlementTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.SettlementTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class CoverageTypeDescriptionsRowChangeEvent : EventArgs
  {
    private dsClaimsAdministration.CoverageTypeDescriptionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public CoverageTypeDescriptionsRowChangeEvent(
      dsClaimsAdministration.CoverageTypeDescriptionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.CoverageTypeDescriptionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class OutsideAdjustersRowChangeEvent : EventArgs
  {
    private dsClaimsAdministration.OutsideAdjustersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public OutsideAdjustersRowChangeEvent(
      dsClaimsAdministration.OutsideAdjustersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjustersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class OutsideAdjusterAddressesRowChangeEvent : EventArgs
  {
    private dsClaimsAdministration.OutsideAdjusterAddressesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public OutsideAdjusterAddressesRowChangeEvent(
      dsClaimsAdministration.OutsideAdjusterAddressesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjusterAddressesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class OutsideAdjusterAddressPhoneNumbersRowChangeEvent : EventArgs
  {
    private dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public OutsideAdjusterAddressPhoneNumbersRowChangeEvent(
      dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsClaimsAdministration.OutsideAdjusterAddressPhoneNumbersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
