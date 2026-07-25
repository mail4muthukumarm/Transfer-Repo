// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsFilingPolicyInfo
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
[XmlRoot("dsFilingPolicyInfo")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsFilingPolicyInfo : DataSet
{
  private dsFilingPolicyInfo.PolicyFilingInformationDataTable tablePolicyFilingInformation;
  private dsFilingPolicyInfo.lstStatesDataTable tablelstStates;
  private dsFilingPolicyInfo.tblFin_PolicyChargesDataTable tabletblFin_PolicyCharges;
  private dsFilingPolicyInfo.tblQuoteOptionChargesDataTable tabletblQuoteOptionCharges;
  private dsFilingPolicyInfo.tblPolicyFilingManagementInfoDataTable tabletblPolicyFilingManagementInfo;
  private dsFilingPolicyInfo.tblStatesSLRequiredDataDataTable tabletblStatesSLRequiredData;
  private dsFilingPolicyInfo.tblStatesSLRequiredData_InfoDataTable tabletblStatesSLRequiredData_Info;
  private dsFilingPolicyInfo.tblClientOfficesDataTable tabletblClientOffices;
  private dsFilingPolicyInfo.tblStateSLRulesDataTable tabletblStateSLRules;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsFilingPolicyInfo()
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
  protected dsFilingPolicyInfo(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (PolicyFilingInformation)] != null)
          base.Tables.Add((DataTable) new dsFilingPolicyInfo.PolicyFilingInformationDataTable(dataSet.Tables[nameof (PolicyFilingInformation)]));
        if (dataSet.Tables[nameof (lstStates)] != null)
          base.Tables.Add((DataTable) new dsFilingPolicyInfo.lstStatesDataTable(dataSet.Tables[nameof (lstStates)]));
        if (dataSet.Tables[nameof (tblFin_PolicyCharges)] != null)
          base.Tables.Add((DataTable) new dsFilingPolicyInfo.tblFin_PolicyChargesDataTable(dataSet.Tables[nameof (tblFin_PolicyCharges)]));
        if (dataSet.Tables[nameof (tblQuoteOptionCharges)] != null)
          base.Tables.Add((DataTable) new dsFilingPolicyInfo.tblQuoteOptionChargesDataTable(dataSet.Tables[nameof (tblQuoteOptionCharges)]));
        if (dataSet.Tables[nameof (tblPolicyFilingManagementInfo)] != null)
          base.Tables.Add((DataTable) new dsFilingPolicyInfo.tblPolicyFilingManagementInfoDataTable(dataSet.Tables[nameof (tblPolicyFilingManagementInfo)]));
        if (dataSet.Tables[nameof (tblStatesSLRequiredData)] != null)
          base.Tables.Add((DataTable) new dsFilingPolicyInfo.tblStatesSLRequiredDataDataTable(dataSet.Tables[nameof (tblStatesSLRequiredData)]));
        if (dataSet.Tables[nameof (tblStatesSLRequiredData_Info)] != null)
          base.Tables.Add((DataTable) new dsFilingPolicyInfo.tblStatesSLRequiredData_InfoDataTable(dataSet.Tables[nameof (tblStatesSLRequiredData_Info)]));
        if (dataSet.Tables[nameof (tblClientOffices)] != null)
          base.Tables.Add((DataTable) new dsFilingPolicyInfo.tblClientOfficesDataTable(dataSet.Tables[nameof (tblClientOffices)]));
        if (dataSet.Tables[nameof (tblStateSLRules)] != null)
          base.Tables.Add((DataTable) new dsFilingPolicyInfo.tblStateSLRulesDataTable(dataSet.Tables[nameof (tblStateSLRules)]));
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
  public dsFilingPolicyInfo.PolicyFilingInformationDataTable PolicyFilingInformation
  {
    get => this.tablePolicyFilingInformation;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsFilingPolicyInfo.lstStatesDataTable lstStates => this.tablelstStates;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsFilingPolicyInfo.tblFin_PolicyChargesDataTable tblFin_PolicyCharges
  {
    get => this.tabletblFin_PolicyCharges;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsFilingPolicyInfo.tblQuoteOptionChargesDataTable tblQuoteOptionCharges
  {
    get => this.tabletblQuoteOptionCharges;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsFilingPolicyInfo.tblPolicyFilingManagementInfoDataTable tblPolicyFilingManagementInfo
  {
    get => this.tabletblPolicyFilingManagementInfo;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsFilingPolicyInfo.tblStatesSLRequiredDataDataTable tblStatesSLRequiredData
  {
    get => this.tabletblStatesSLRequiredData;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsFilingPolicyInfo.tblStatesSLRequiredData_InfoDataTable tblStatesSLRequiredData_Info
  {
    get => this.tabletblStatesSLRequiredData_Info;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsFilingPolicyInfo.tblClientOfficesDataTable tblClientOffices
  {
    get => this.tabletblClientOffices;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsFilingPolicyInfo.tblStateSLRulesDataTable tblStateSLRules => this.tabletblStateSLRules;

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
    dsFilingPolicyInfo filingPolicyInfo = (dsFilingPolicyInfo) base.Clone();
    filingPolicyInfo.InitVars();
    filingPolicyInfo.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) filingPolicyInfo;
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
      if (dataSet.Tables["PolicyFilingInformation"] != null)
        base.Tables.Add((DataTable) new dsFilingPolicyInfo.PolicyFilingInformationDataTable(dataSet.Tables["PolicyFilingInformation"]));
      if (dataSet.Tables["lstStates"] != null)
        base.Tables.Add((DataTable) new dsFilingPolicyInfo.lstStatesDataTable(dataSet.Tables["lstStates"]));
      if (dataSet.Tables["tblFin_PolicyCharges"] != null)
        base.Tables.Add((DataTable) new dsFilingPolicyInfo.tblFin_PolicyChargesDataTable(dataSet.Tables["tblFin_PolicyCharges"]));
      if (dataSet.Tables["tblQuoteOptionCharges"] != null)
        base.Tables.Add((DataTable) new dsFilingPolicyInfo.tblQuoteOptionChargesDataTable(dataSet.Tables["tblQuoteOptionCharges"]));
      if (dataSet.Tables["tblPolicyFilingManagementInfo"] != null)
        base.Tables.Add((DataTable) new dsFilingPolicyInfo.tblPolicyFilingManagementInfoDataTable(dataSet.Tables["tblPolicyFilingManagementInfo"]));
      if (dataSet.Tables["tblStatesSLRequiredData"] != null)
        base.Tables.Add((DataTable) new dsFilingPolicyInfo.tblStatesSLRequiredDataDataTable(dataSet.Tables["tblStatesSLRequiredData"]));
      if (dataSet.Tables["tblStatesSLRequiredData_Info"] != null)
        base.Tables.Add((DataTable) new dsFilingPolicyInfo.tblStatesSLRequiredData_InfoDataTable(dataSet.Tables["tblStatesSLRequiredData_Info"]));
      if (dataSet.Tables["tblClientOffices"] != null)
        base.Tables.Add((DataTable) new dsFilingPolicyInfo.tblClientOfficesDataTable(dataSet.Tables["tblClientOffices"]));
      if (dataSet.Tables["tblStateSLRules"] != null)
        base.Tables.Add((DataTable) new dsFilingPolicyInfo.tblStateSLRulesDataTable(dataSet.Tables["tblStateSLRules"]));
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
    this.tablePolicyFilingInformation = (dsFilingPolicyInfo.PolicyFilingInformationDataTable) base.Tables["PolicyFilingInformation"];
    if (initTable && this.tablePolicyFilingInformation != null)
      this.tablePolicyFilingInformation.InitVars();
    this.tablelstStates = (dsFilingPolicyInfo.lstStatesDataTable) base.Tables["lstStates"];
    if (initTable && this.tablelstStates != null)
      this.tablelstStates.InitVars();
    this.tabletblFin_PolicyCharges = (dsFilingPolicyInfo.tblFin_PolicyChargesDataTable) base.Tables["tblFin_PolicyCharges"];
    if (initTable && this.tabletblFin_PolicyCharges != null)
      this.tabletblFin_PolicyCharges.InitVars();
    this.tabletblQuoteOptionCharges = (dsFilingPolicyInfo.tblQuoteOptionChargesDataTable) base.Tables["tblQuoteOptionCharges"];
    if (initTable && this.tabletblQuoteOptionCharges != null)
      this.tabletblQuoteOptionCharges.InitVars();
    this.tabletblPolicyFilingManagementInfo = (dsFilingPolicyInfo.tblPolicyFilingManagementInfoDataTable) base.Tables["tblPolicyFilingManagementInfo"];
    if (initTable && this.tabletblPolicyFilingManagementInfo != null)
      this.tabletblPolicyFilingManagementInfo.InitVars();
    this.tabletblStatesSLRequiredData = (dsFilingPolicyInfo.tblStatesSLRequiredDataDataTable) base.Tables["tblStatesSLRequiredData"];
    if (initTable && this.tabletblStatesSLRequiredData != null)
      this.tabletblStatesSLRequiredData.InitVars();
    this.tabletblStatesSLRequiredData_Info = (dsFilingPolicyInfo.tblStatesSLRequiredData_InfoDataTable) base.Tables["tblStatesSLRequiredData_Info"];
    if (initTable && this.tabletblStatesSLRequiredData_Info != null)
      this.tabletblStatesSLRequiredData_Info.InitVars();
    this.tabletblClientOffices = (dsFilingPolicyInfo.tblClientOfficesDataTable) base.Tables["tblClientOffices"];
    if (initTable && this.tabletblClientOffices != null)
      this.tabletblClientOffices.InitVars();
    this.tabletblStateSLRules = (dsFilingPolicyInfo.tblStateSLRulesDataTable) base.Tables["tblStateSLRules"];
    if (!initTable || this.tabletblStateSLRules == null)
      return;
    this.tabletblStateSLRules.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsFilingPolicyInfo);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsFilingPolicyInfo.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablePolicyFilingInformation = new dsFilingPolicyInfo.PolicyFilingInformationDataTable();
    base.Tables.Add((DataTable) this.tablePolicyFilingInformation);
    this.tablelstStates = new dsFilingPolicyInfo.lstStatesDataTable();
    base.Tables.Add((DataTable) this.tablelstStates);
    this.tabletblFin_PolicyCharges = new dsFilingPolicyInfo.tblFin_PolicyChargesDataTable();
    base.Tables.Add((DataTable) this.tabletblFin_PolicyCharges);
    this.tabletblQuoteOptionCharges = new dsFilingPolicyInfo.tblQuoteOptionChargesDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptionCharges);
    this.tabletblPolicyFilingManagementInfo = new dsFilingPolicyInfo.tblPolicyFilingManagementInfoDataTable();
    base.Tables.Add((DataTable) this.tabletblPolicyFilingManagementInfo);
    this.tabletblStatesSLRequiredData = new dsFilingPolicyInfo.tblStatesSLRequiredDataDataTable();
    base.Tables.Add((DataTable) this.tabletblStatesSLRequiredData);
    this.tabletblStatesSLRequiredData_Info = new dsFilingPolicyInfo.tblStatesSLRequiredData_InfoDataTable();
    base.Tables.Add((DataTable) this.tabletblStatesSLRequiredData_Info);
    this.tabletblClientOffices = new dsFilingPolicyInfo.tblClientOfficesDataTable();
    base.Tables.Add((DataTable) this.tabletblClientOffices);
    this.tabletblStateSLRules = new dsFilingPolicyInfo.tblStateSLRulesDataTable();
    base.Tables.Add((DataTable) this.tabletblStateSLRules);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializePolicyFilingInformation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstStates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblFin_PolicyCharges() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblQuoteOptionCharges() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblPolicyFilingManagementInfo() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblStatesSLRequiredData() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblStatesSLRequiredData_Info() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblClientOffices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblStateSLRules() => false;

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
    dsFilingPolicyInfo filingPolicyInfo = new dsFilingPolicyInfo();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = filingPolicyInfo.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = filingPolicyInfo.GetSchemaSerializable();
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
  public delegate void PolicyFilingInformationRowChangeEventHandler(
    object sender,
    dsFilingPolicyInfo.PolicyFilingInformationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstStatesRowChangeEventHandler(
    object sender,
    dsFilingPolicyInfo.lstStatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblFin_PolicyChargesRowChangeEventHandler(
    object sender,
    dsFilingPolicyInfo.tblFin_PolicyChargesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblQuoteOptionChargesRowChangeEventHandler(
    object sender,
    dsFilingPolicyInfo.tblQuoteOptionChargesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblPolicyFilingManagementInfoRowChangeEventHandler(
    object sender,
    dsFilingPolicyInfo.tblPolicyFilingManagementInfoRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblStatesSLRequiredDataRowChangeEventHandler(
    object sender,
    dsFilingPolicyInfo.tblStatesSLRequiredDataRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblStatesSLRequiredData_InfoRowChangeEventHandler(
    object sender,
    dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblClientOfficesRowChangeEventHandler(
    object sender,
    dsFilingPolicyInfo.tblClientOfficesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblStateSLRulesRowChangeEventHandler(
    object sender,
    dsFilingPolicyInfo.tblStateSLRulesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class PolicyFilingInformationDataTable : 
    TypedTableBase<dsFilingPolicyInfo.PolicyFilingInformationRow>
  {
    private DataColumn columnInsuredPolicyName;
    private DataColumn columnAffidavitNumber;
    private DataColumn columnLicenseNumber;
    private DataColumn columnFilingProducer;
    private DataColumn columnPremium;
    private DataColumn columnDateAmountDue;
    private DataColumn columnDateFilingDue;
    private DataColumn columnStateID;
    private DataColumn columnControlNo;
    private DataColumn columnPolicyNumber;
    private DataColumn columnOptionFeeID;
    private DataColumn columnTaxDue;
    private DataColumn columnFeesDue;
    private DataColumn columnTransactionType;
    private DataColumn columnTransactionEffective;
    private DataColumn columnRate;
    private DataColumn columnPayeeName;
    private DataColumn columnIsCheckRequestDate;
    private DataColumn columnTransactionDate;
    private DataColumn columnPaid;
    private DataColumn columnChargeName;
    private DataColumn columnStatePremium;
    private DataColumn columnLOB;
    private DataColumn columnCarrier;
    private DataColumn columnInvoiceNum;
    private DataColumn columnPolicyTIV;
    private DataColumn columnStateTIV;
    private DataColumn columnFiled;
    private DataColumn columnDecPageFiledDate;
    private DataColumn columnDSFFillDate;
    private DataColumn columnControlsFiledDate;
    private DataColumn columnMonthlyReportDue;
    private DataColumn columnQuarterlyReportDue;
    private DataColumn columnSemiAnnualReportDue;
    private DataColumn columnAnnualReportDue;
    private DataColumn columnFilingDone;
    private DataColumn columnFireTaxDue;
    private DataColumn columnMunicipalFilingDue;
    private DataColumn columnRevenueSurchargeDue;
    private DataColumn columnDatePaid;
    private DataColumn columnUnderwriter;
    private DataColumn columnDateFiled;
    private DataColumn columnTaxableFee;
    private DataColumn columnOffSet;
    private DataColumn columnTaxableFeesAmount;
    private DataColumn columnInvoiceDate;
    private DataColumn columnTotalPremium;
    private DataColumn columnPolicyStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public PolicyFilingInformationDataTable()
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.PolicyFilingInformationDataTable_ColumnChanging);
      this.TableName = "PolicyFilingInformation";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal PolicyFilingInformationDataTable(DataTable table)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.PolicyFilingInformationDataTable_ColumnChanging);
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
    protected PolicyFilingInformationDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.PolicyFilingInformationDataTable_ColumnChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredPolicyNameColumn => this.columnInsuredPolicyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AffidavitNumberColumn => this.columnAffidavitNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LicenseNumberColumn => this.columnLicenseNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FilingProducerColumn => this.columnFilingProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateAmountDueColumn => this.columnDateAmountDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateFilingDueColumn => this.columnDateFilingDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OptionFeeIDColumn => this.columnOptionFeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TaxDueColumn => this.columnTaxDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FeesDueColumn => this.columnFeesDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TransactionTypeColumn => this.columnTransactionType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TransactionEffectiveColumn => this.columnTransactionEffective;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RateColumn => this.columnRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayeeNameColumn => this.columnPayeeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IsCheckRequestDateColumn => this.columnIsCheckRequestDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TransactionDateColumn => this.columnTransactionDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PaidColumn => this.columnPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatePremiumColumn => this.columnStatePremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LOBColumn => this.columnLOB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CarrierColumn => this.columnCarrier;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyTIVColumn => this.columnPolicyTIV;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateTIVColumn => this.columnStateTIV;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FiledColumn => this.columnFiled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DecPageFiledDateColumn => this.columnDecPageFiledDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DSFFillDateColumn => this.columnDSFFillDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ControlsFiledDateColumn => this.columnControlsFiledDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MonthlyReportDueColumn => this.columnMonthlyReportDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuarterlyReportDueColumn => this.columnQuarterlyReportDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SemiAnnualReportDueColumn => this.columnSemiAnnualReportDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AnnualReportDueColumn => this.columnAnnualReportDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FilingDoneColumn => this.columnFilingDone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FireTaxDueColumn => this.columnFireTaxDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MunicipalFilingDueColumn => this.columnMunicipalFilingDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RevenueSurchargeDueColumn => this.columnRevenueSurchargeDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DatePaidColumn => this.columnDatePaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UnderwriterColumn => this.columnUnderwriter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateFiledColumn => this.columnDateFiled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TaxableFeeColumn => this.columnTaxableFee;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OffSetColumn => this.columnOffSet;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TaxableFeesAmountColumn => this.columnTaxableFeesAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InvoiceDateColumn => this.columnInvoiceDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TotalPremiumColumn => this.columnTotalPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyStatusColumn => this.columnPolicyStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.PolicyFilingInformationRow this[int index]
    {
      get => (dsFilingPolicyInfo.PolicyFilingInformationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.PolicyFilingInformationRowChangeEventHandler PolicyFilingInformationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.PolicyFilingInformationRowChangeEventHandler PolicyFilingInformationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.PolicyFilingInformationRowChangeEventHandler PolicyFilingInformationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.PolicyFilingInformationRowChangeEventHandler PolicyFilingInformationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddPolicyFilingInformationRow(dsFilingPolicyInfo.PolicyFilingInformationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.PolicyFilingInformationRow AddPolicyFilingInformationRow(
      string InsuredPolicyName,
      string AffidavitNumber,
      string LicenseNumber,
      string FilingProducer,
      double Premium,
      DateTime DateAmountDue,
      DateTime DateFilingDue,
      string StateID,
      int ControlNo,
      string PolicyNumber,
      int OptionFeeID,
      Decimal TaxDue,
      Decimal FeesDue,
      string TransactionType,
      DateTime TransactionEffective,
      string Rate,
      string PayeeName,
      bool IsCheckRequestDate,
      DateTime TransactionDate,
      bool Paid,
      string ChargeName,
      double StatePremium,
      string LOB,
      string Carrier,
      int InvoiceNum,
      double PolicyTIV,
      double StateTIV,
      bool Filed,
      DateTime DecPageFiledDate,
      DateTime DSFFillDate,
      DateTime ControlsFiledDate,
      DateTime MonthlyReportDue,
      DateTime QuarterlyReportDue,
      DateTime SemiAnnualReportDue,
      DateTime AnnualReportDue,
      DateTime FilingDone,
      DateTime FireTaxDue,
      DateTime MunicipalFilingDue,
      DateTime RevenueSurchargeDue,
      DateTime DatePaid,
      string Underwriter,
      DateTime DateFiled,
      bool TaxableFee,
      bool OffSet,
      Decimal TaxableFeesAmount,
      DateTime InvoiceDate,
      Decimal TotalPremium,
      string PolicyStatus)
    {
      dsFilingPolicyInfo.PolicyFilingInformationRow row = (dsFilingPolicyInfo.PolicyFilingInformationRow) this.NewRow();
      object[] objArray = new object[48 /*0x30*/]
      {
        (object) InsuredPolicyName,
        (object) AffidavitNumber,
        (object) LicenseNumber,
        (object) FilingProducer,
        (object) Premium,
        (object) DateAmountDue,
        (object) DateFilingDue,
        (object) StateID,
        (object) ControlNo,
        (object) PolicyNumber,
        (object) OptionFeeID,
        (object) TaxDue,
        (object) FeesDue,
        (object) TransactionType,
        (object) TransactionEffective,
        (object) Rate,
        (object) PayeeName,
        (object) IsCheckRequestDate,
        (object) TransactionDate,
        (object) Paid,
        (object) ChargeName,
        (object) StatePremium,
        (object) LOB,
        (object) Carrier,
        (object) InvoiceNum,
        (object) PolicyTIV,
        (object) StateTIV,
        (object) Filed,
        (object) DecPageFiledDate,
        (object) DSFFillDate,
        (object) ControlsFiledDate,
        (object) MonthlyReportDue,
        (object) QuarterlyReportDue,
        (object) SemiAnnualReportDue,
        (object) AnnualReportDue,
        (object) FilingDone,
        (object) FireTaxDue,
        (object) MunicipalFilingDue,
        (object) RevenueSurchargeDue,
        (object) DatePaid,
        (object) Underwriter,
        (object) DateFiled,
        (object) TaxableFee,
        (object) OffSet,
        (object) TaxableFeesAmount,
        (object) InvoiceDate,
        (object) TotalPremium,
        (object) PolicyStatus
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsFilingPolicyInfo.PolicyFilingInformationDataTable informationDataTable = (dsFilingPolicyInfo.PolicyFilingInformationDataTable) base.Clone();
      informationDataTable.InitVars();
      return (DataTable) informationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsFilingPolicyInfo.PolicyFilingInformationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnInsuredPolicyName = this.Columns["InsuredPolicyName"];
      this.columnAffidavitNumber = this.Columns["AffidavitNumber"];
      this.columnLicenseNumber = this.Columns["LicenseNumber"];
      this.columnFilingProducer = this.Columns["FilingProducer"];
      this.columnPremium = this.Columns["Premium"];
      this.columnDateAmountDue = this.Columns["DateAmountDue"];
      this.columnDateFilingDue = this.Columns["DateFilingDue"];
      this.columnStateID = this.Columns["StateID"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnOptionFeeID = this.Columns["OptionFeeID"];
      this.columnTaxDue = this.Columns["TaxDue"];
      this.columnFeesDue = this.Columns["FeesDue"];
      this.columnTransactionType = this.Columns["TransactionType"];
      this.columnTransactionEffective = this.Columns["TransactionEffective"];
      this.columnRate = this.Columns["Rate"];
      this.columnPayeeName = this.Columns["PayeeName"];
      this.columnIsCheckRequestDate = this.Columns["IsCheckRequestDate"];
      this.columnTransactionDate = this.Columns["TransactionDate"];
      this.columnPaid = this.Columns["Paid"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnStatePremium = this.Columns["StatePremium"];
      this.columnLOB = this.Columns["LOB"];
      this.columnCarrier = this.Columns["Carrier"];
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnPolicyTIV = this.Columns["PolicyTIV"];
      this.columnStateTIV = this.Columns["StateTIV"];
      this.columnFiled = this.Columns["Filed"];
      this.columnDecPageFiledDate = this.Columns["DecPageFiledDate"];
      this.columnDSFFillDate = this.Columns["DSFFillDate"];
      this.columnControlsFiledDate = this.Columns["ControlsFiledDate"];
      this.columnMonthlyReportDue = this.Columns["MonthlyReportDue"];
      this.columnQuarterlyReportDue = this.Columns["QuarterlyReportDue"];
      this.columnSemiAnnualReportDue = this.Columns["SemiAnnualReportDue"];
      this.columnAnnualReportDue = this.Columns["AnnualReportDue"];
      this.columnFilingDone = this.Columns["FilingDone"];
      this.columnFireTaxDue = this.Columns["FireTaxDue"];
      this.columnMunicipalFilingDue = this.Columns["MunicipalFilingDue"];
      this.columnRevenueSurchargeDue = this.Columns["RevenueSurchargeDue"];
      this.columnDatePaid = this.Columns["DatePaid"];
      this.columnUnderwriter = this.Columns["Underwriter"];
      this.columnDateFiled = this.Columns["DateFiled"];
      this.columnTaxableFee = this.Columns["TaxableFee"];
      this.columnOffSet = this.Columns["OffSet"];
      this.columnTaxableFeesAmount = this.Columns["TaxableFeesAmount"];
      this.columnInvoiceDate = this.Columns["InvoiceDate"];
      this.columnTotalPremium = this.Columns["TotalPremium"];
      this.columnPolicyStatus = this.Columns["PolicyStatus"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnInsuredPolicyName = new DataColumn("InsuredPolicyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredPolicyName);
      this.columnAffidavitNumber = new DataColumn("AffidavitNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAffidavitNumber);
      this.columnLicenseNumber = new DataColumn("LicenseNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLicenseNumber);
      this.columnFilingProducer = new DataColumn("FilingProducer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFilingProducer);
      this.columnPremium = new DataColumn("Premium", typeof (double), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnDateAmountDue = new DataColumn("DateAmountDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateAmountDue);
      this.columnDateFilingDue = new DataColumn("DateFilingDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateFilingDue);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnOptionFeeID = new DataColumn("OptionFeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptionFeeID);
      this.columnTaxDue = new DataColumn("TaxDue", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxDue);
      this.columnFeesDue = new DataColumn("FeesDue", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFeesDue);
      this.columnTransactionType = new DataColumn("TransactionType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransactionType);
      this.columnTransactionEffective = new DataColumn("TransactionEffective", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransactionEffective);
      this.columnRate = new DataColumn("Rate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRate);
      this.columnPayeeName = new DataColumn("PayeeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeName);
      this.columnIsCheckRequestDate = new DataColumn("IsCheckRequestDate", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsCheckRequestDate);
      this.columnTransactionDate = new DataColumn("TransactionDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransactionDate);
      this.columnPaid = new DataColumn("Paid", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPaid);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnStatePremium = new DataColumn("StatePremium", typeof (double), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatePremium);
      this.columnLOB = new DataColumn("LOB", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLOB);
      this.columnCarrier = new DataColumn("Carrier", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCarrier);
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnPolicyTIV = new DataColumn("PolicyTIV", typeof (double), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyTIV);
      this.columnStateTIV = new DataColumn("StateTIV", typeof (double), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateTIV);
      this.columnFiled = new DataColumn("Filed", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFiled);
      this.columnDecPageFiledDate = new DataColumn("DecPageFiledDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDecPageFiledDate);
      this.columnDSFFillDate = new DataColumn("DSFFillDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDSFFillDate);
      this.columnControlsFiledDate = new DataColumn("ControlsFiledDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlsFiledDate);
      this.columnMonthlyReportDue = new DataColumn("MonthlyReportDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMonthlyReportDue);
      this.columnQuarterlyReportDue = new DataColumn("QuarterlyReportDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuarterlyReportDue);
      this.columnSemiAnnualReportDue = new DataColumn("SemiAnnualReportDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSemiAnnualReportDue);
      this.columnAnnualReportDue = new DataColumn("AnnualReportDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAnnualReportDue);
      this.columnFilingDone = new DataColumn("FilingDone", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFilingDone);
      this.columnFireTaxDue = new DataColumn("FireTaxDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFireTaxDue);
      this.columnMunicipalFilingDue = new DataColumn("MunicipalFilingDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMunicipalFilingDue);
      this.columnRevenueSurchargeDue = new DataColumn("RevenueSurchargeDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRevenueSurchargeDue);
      this.columnDatePaid = new DataColumn("DatePaid", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDatePaid);
      this.columnUnderwriter = new DataColumn("Underwriter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriter);
      this.columnDateFiled = new DataColumn("DateFiled", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateFiled);
      this.columnTaxableFee = new DataColumn("TaxableFee", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxableFee);
      this.columnOffSet = new DataColumn("OffSet", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOffSet);
      this.columnTaxableFeesAmount = new DataColumn("TaxableFeesAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxableFeesAmount);
      this.columnInvoiceDate = new DataColumn("InvoiceDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceDate);
      this.columnTotalPremium = new DataColumn("TotalPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalPremium);
      this.columnPolicyStatus = new DataColumn("PolicyStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyStatus);
      this.columnOptionFeeID.AllowDBNull = false;
      this.columnPayeeName.MaxLength = 100;
      this.columnPaid.AllowDBNull = false;
      this.columnPaid.DefaultValue = (object) false;
      this.columnOffSet.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.PolicyFilingInformationRow NewPolicyFilingInformationRow()
    {
      return (dsFilingPolicyInfo.PolicyFilingInformationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsFilingPolicyInfo.PolicyFilingInformationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsFilingPolicyInfo.PolicyFilingInformationRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyFilingInformationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.PolicyFilingInformationRowChangeEventHandler informationRowChangedEvent = this.PolicyFilingInformationRowChangedEvent;
      if (informationRowChangedEvent == null)
        return;
      informationRowChangedEvent((object) this, new dsFilingPolicyInfo.PolicyFilingInformationRowChangeEvent((dsFilingPolicyInfo.PolicyFilingInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyFilingInformationRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.PolicyFilingInformationRowChangeEventHandler rowChangingEvent = this.PolicyFilingInformationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsFilingPolicyInfo.PolicyFilingInformationRowChangeEvent((dsFilingPolicyInfo.PolicyFilingInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyFilingInformationRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.PolicyFilingInformationRowChangeEventHandler informationRowDeletedEvent = this.PolicyFilingInformationRowDeletedEvent;
      if (informationRowDeletedEvent == null)
        return;
      informationRowDeletedEvent((object) this, new dsFilingPolicyInfo.PolicyFilingInformationRowChangeEvent((dsFilingPolicyInfo.PolicyFilingInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PolicyFilingInformationRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.PolicyFilingInformationRowChangeEventHandler rowDeletingEvent = this.PolicyFilingInformationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsFilingPolicyInfo.PolicyFilingInformationRowChangeEvent((dsFilingPolicyInfo.PolicyFilingInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovePolicyFilingInformationRow(dsFilingPolicyInfo.PolicyFilingInformationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsFilingPolicyInfo filingPolicyInfo = new dsFilingPolicyInfo();
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
        FixedValue = filingPolicyInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PolicyFilingInformationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = filingPolicyInfo.GetSchemaSerializable();
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

    private void PolicyFilingInformationDataTable_ColumnChanging(
      object sender,
      DataColumnChangeEventArgs e)
    {
      Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Column.ColumnName, this.LicenseNumberColumn.ColumnName, false);
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstStatesDataTable : TypedTableBase<dsFilingPolicyInfo.lstStatesRow>
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
    public dsFilingPolicyInfo.lstStatesRow this[int index]
    {
      get => (dsFilingPolicyInfo.lstStatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.lstStatesRowChangeEventHandler lstStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.lstStatesRowChangeEventHandler lstStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.lstStatesRowChangeEventHandler lstStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.lstStatesRowChangeEventHandler lstStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstStatesRow(dsFilingPolicyInfo.lstStatesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.lstStatesRow AddlstStatesRow(string StateID, string State)
    {
      dsFilingPolicyInfo.lstStatesRow row = (dsFilingPolicyInfo.lstStatesRow) this.NewRow();
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
    public dsFilingPolicyInfo.lstStatesRow FindByStateID(string StateID)
    {
      return (dsFilingPolicyInfo.lstStatesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsFilingPolicyInfo.lstStatesDataTable lstStatesDataTable = (dsFilingPolicyInfo.lstStatesDataTable) base.Clone();
      lstStatesDataTable.InitVars();
      return (DataTable) lstStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsFilingPolicyInfo.lstStatesDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnStateID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.Unique = true;
      this.columnStateID.MaxLength = 2;
      this.columnState.AllowDBNull = false;
      this.columnState.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.lstStatesRow NewlstStatesRow()
    {
      return (dsFilingPolicyInfo.lstStatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsFilingPolicyInfo.lstStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsFilingPolicyInfo.lstStatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.lstStatesRowChangeEventHandler statesRowChangedEvent = this.lstStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsFilingPolicyInfo.lstStatesRowChangeEvent((dsFilingPolicyInfo.lstStatesRow) e.Row, e.Action));
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
      dsFilingPolicyInfo.lstStatesRowChangeEventHandler rowChangingEvent = this.lstStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsFilingPolicyInfo.lstStatesRowChangeEvent((dsFilingPolicyInfo.lstStatesRow) e.Row, e.Action));
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
      dsFilingPolicyInfo.lstStatesRowChangeEventHandler statesRowDeletedEvent = this.lstStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsFilingPolicyInfo.lstStatesRowChangeEvent((dsFilingPolicyInfo.lstStatesRow) e.Row, e.Action));
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
      dsFilingPolicyInfo.lstStatesRowChangeEventHandler rowDeletingEvent = this.lstStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsFilingPolicyInfo.lstStatesRowChangeEvent((dsFilingPolicyInfo.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstStatesRow(dsFilingPolicyInfo.lstStatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsFilingPolicyInfo filingPolicyInfo = new dsFilingPolicyInfo();
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
        FixedValue = filingPolicyInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = filingPolicyInfo.GetSchemaSerializable();
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
    TypedTableBase<dsFilingPolicyInfo.tblFin_PolicyChargesRow>
  {
    private DataColumn columnChargeCode;
    private DataColumn columnChargeName;
    private DataColumn columnDescription;
    private DataColumn columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblFin_PolicyChargesDataTable()
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.tblFin_PolicyChargesDataTable_ColumnChanging);
      this.TableName = "tblFin_PolicyCharges";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblFin_PolicyChargesDataTable(DataTable table)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.tblFin_PolicyChargesDataTable_ColumnChanging);
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
    protected tblFin_PolicyChargesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.tblFin_PolicyChargesDataTable_ColumnChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblFin_PolicyChargesRow this[int index]
    {
      get => (dsFilingPolicyInfo.tblFin_PolicyChargesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblFin_PolicyChargesRow(dsFilingPolicyInfo.tblFin_PolicyChargesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblFin_PolicyChargesRow AddtblFin_PolicyChargesRow(
      string ChargeName,
      string Description,
      string StateID)
    {
      dsFilingPolicyInfo.tblFin_PolicyChargesRow row = (dsFilingPolicyInfo.tblFin_PolicyChargesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        null,
        (object) ChargeName,
        (object) Description,
        (object) StateID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblFin_PolicyChargesRow FindByChargeCode(int ChargeCode)
    {
      return (dsFilingPolicyInfo.tblFin_PolicyChargesRow) this.Rows.Find(new object[1]
      {
        (object) ChargeCode
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsFilingPolicyInfo.tblFin_PolicyChargesDataTable chargesDataTable = (dsFilingPolicyInfo.tblFin_PolicyChargesDataTable) base.Clone();
      chargesDataTable.InitVars();
      return (DataTable) chargesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsFilingPolicyInfo.tblFin_PolicyChargesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnDescription = this.Columns["Description"];
      this.columnStateID = this.Columns["StateID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnChargeCode
      }, true));
      this.columnChargeCode.AutoIncrement = true;
      this.columnChargeCode.AllowDBNull = false;
      this.columnChargeCode.ReadOnly = true;
      this.columnChargeCode.Unique = true;
      this.columnChargeName.AllowDBNull = false;
      this.columnStateID.MaxLength = 2;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblFin_PolicyChargesRow NewtblFin_PolicyChargesRow()
    {
      return (dsFilingPolicyInfo.tblFin_PolicyChargesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsFilingPolicyInfo.tblFin_PolicyChargesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsFilingPolicyInfo.tblFin_PolicyChargesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblFin_PolicyChargesRowChangeEventHandler chargesRowChangedEvent = this.tblFin_PolicyChargesRowChangedEvent;
      if (chargesRowChangedEvent == null)
        return;
      chargesRowChangedEvent((object) this, new dsFilingPolicyInfo.tblFin_PolicyChargesRowChangeEvent((dsFilingPolicyInfo.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblFin_PolicyChargesRowChangeEventHandler rowChangingEvent = this.tblFin_PolicyChargesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsFilingPolicyInfo.tblFin_PolicyChargesRowChangeEvent((dsFilingPolicyInfo.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblFin_PolicyChargesRowChangeEventHandler chargesRowDeletedEvent = this.tblFin_PolicyChargesRowDeletedEvent;
      if (chargesRowDeletedEvent == null)
        return;
      chargesRowDeletedEvent((object) this, new dsFilingPolicyInfo.tblFin_PolicyChargesRowChangeEvent((dsFilingPolicyInfo.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblFin_PolicyChargesRowChangeEventHandler rowDeletingEvent = this.tblFin_PolicyChargesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsFilingPolicyInfo.tblFin_PolicyChargesRowChangeEvent((dsFilingPolicyInfo.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblFin_PolicyChargesRow(dsFilingPolicyInfo.tblFin_PolicyChargesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsFilingPolicyInfo filingPolicyInfo = new dsFilingPolicyInfo();
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
        FixedValue = filingPolicyInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblFin_PolicyChargesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = filingPolicyInfo.GetSchemaSerializable();
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

    private void tblFin_PolicyChargesDataTable_ColumnChanging(
      object sender,
      DataColumnChangeEventArgs e)
    {
      Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Column.ColumnName, this.ChargeNameColumn.ColumnName, false);
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblQuoteOptionChargesDataTable : 
    TypedTableBase<dsFilingPolicyInfo.tblQuoteOptionChargesRow>
  {
    private DataColumn columnOptionFeeID;
    private DataColumn columnQuoteOptionGuid;
    private DataColumn columnCompanyFeeID;
    private DataColumn columnChargeCode;
    private DataColumn columnOfficeID;
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnOriginalQuoteOptionGuid;
    private DataColumn columnFeeTypeID;
    private DataColumn columnPayable;
    private DataColumn columnRate;
    private DataColumn columnPercentageRate;
    private DataColumn columnPercentageMinimum;
    private DataColumn columnPercentOfChargeCode;
    private DataColumn columnSplittable;
    private DataColumn columnAutoApplied;
    private DataColumn columnAppliesToPaymentID;
    private DataColumn columnAdded;
    private DataColumn columnTaxable;
    private DataColumn columnRoundToDollar;
    private DataColumn columnWaivedByUserGuid;
    private DataColumn columnConvertedToManualUserGuid;
    private DataColumn columnAmountWithInstallments;
    private DataColumn columnFullyEarned;
    private DataColumn columnAmount;
    private DataColumn columnDateAmountDue;
    private DataColumn columnDateFilingDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuoteOptionChargesDataTable()
    {
      this.TableName = "tblQuoteOptionCharges";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuoteOptionChargesDataTable(DataTable table)
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
    protected tblQuoteOptionChargesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OptionFeeIDColumn => this.columnOptionFeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteOptionGuidColumn => this.columnQuoteOptionGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyFeeIDColumn => this.columnCompanyFeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OriginalQuoteOptionGuidColumn => this.columnOriginalQuoteOptionGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FeeTypeIDColumn => this.columnFeeTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayableColumn => this.columnPayable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RateColumn => this.columnRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PercentageRateColumn => this.columnPercentageRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PercentageMinimumColumn => this.columnPercentageMinimum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PercentOfChargeCodeColumn => this.columnPercentOfChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SplittableColumn => this.columnSplittable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoAppliedColumn => this.columnAutoApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AppliesToPaymentIDColumn => this.columnAppliesToPaymentID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AddedColumn => this.columnAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TaxableColumn => this.columnTaxable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RoundToDollarColumn => this.columnRoundToDollar;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WaivedByUserGuidColumn => this.columnWaivedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ConvertedToManualUserGuidColumn => this.columnConvertedToManualUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AmountWithInstallmentsColumn => this.columnAmountWithInstallments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FullyEarnedColumn => this.columnFullyEarned;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AmountColumn => this.columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateAmountDueColumn => this.columnDateAmountDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateFilingDueColumn => this.columnDateFilingDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblQuoteOptionChargesRow this[int index]
    {
      get => (dsFilingPolicyInfo.tblQuoteOptionChargesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblQuoteOptionChargesRowChangeEventHandler tblQuoteOptionChargesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblQuoteOptionChargesRowChangeEventHandler tblQuoteOptionChargesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblQuoteOptionChargesRowChangeEventHandler tblQuoteOptionChargesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblQuoteOptionChargesRowChangeEventHandler tblQuoteOptionChargesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblQuoteOptionChargesRow(dsFilingPolicyInfo.tblQuoteOptionChargesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblQuoteOptionChargesRow AddtblQuoteOptionChargesRow(
      Guid QuoteOptionGuid,
      int CompanyFeeID,
      int ChargeCode,
      int OfficeID,
      Guid CompanyLineGuid,
      Guid OriginalQuoteOptionGuid,
      byte FeeTypeID,
      bool Payable,
      Decimal Rate,
      Decimal PercentageRate,
      Decimal PercentageMinimum,
      int PercentOfChargeCode,
      bool Splittable,
      bool AutoApplied,
      string AppliesToPaymentID,
      DateTime Added,
      bool Taxable,
      bool RoundToDollar,
      Guid WaivedByUserGuid,
      Guid ConvertedToManualUserGuid,
      Decimal AmountWithInstallments,
      bool FullyEarned,
      Decimal Amount,
      DateTime DateAmountDue,
      DateTime DateFilingDue)
    {
      dsFilingPolicyInfo.tblQuoteOptionChargesRow row = (dsFilingPolicyInfo.tblQuoteOptionChargesRow) this.NewRow();
      object[] objArray = new object[26]
      {
        null,
        (object) QuoteOptionGuid,
        (object) CompanyFeeID,
        (object) ChargeCode,
        (object) OfficeID,
        (object) CompanyLineGuid,
        (object) OriginalQuoteOptionGuid,
        (object) FeeTypeID,
        (object) Payable,
        (object) Rate,
        (object) PercentageRate,
        (object) PercentageMinimum,
        (object) PercentOfChargeCode,
        (object) Splittable,
        (object) AutoApplied,
        (object) AppliesToPaymentID,
        (object) Added,
        (object) Taxable,
        (object) RoundToDollar,
        (object) WaivedByUserGuid,
        (object) ConvertedToManualUserGuid,
        (object) AmountWithInstallments,
        (object) FullyEarned,
        (object) Amount,
        (object) DateAmountDue,
        (object) DateFilingDue
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblQuoteOptionChargesRow FindByOptionFeeID(int OptionFeeID)
    {
      return (dsFilingPolicyInfo.tblQuoteOptionChargesRow) this.Rows.Find(new object[1]
      {
        (object) OptionFeeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsFilingPolicyInfo.tblQuoteOptionChargesDataTable chargesDataTable = (dsFilingPolicyInfo.tblQuoteOptionChargesDataTable) base.Clone();
      chargesDataTable.InitVars();
      return (DataTable) chargesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsFilingPolicyInfo.tblQuoteOptionChargesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnOptionFeeID = this.Columns["OptionFeeID"];
      this.columnQuoteOptionGuid = this.Columns["QuoteOptionGuid"];
      this.columnCompanyFeeID = this.Columns["CompanyFeeID"];
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnOriginalQuoteOptionGuid = this.Columns["OriginalQuoteOptionGuid"];
      this.columnFeeTypeID = this.Columns["FeeTypeID"];
      this.columnPayable = this.Columns["Payable"];
      this.columnRate = this.Columns["Rate"];
      this.columnPercentageRate = this.Columns["PercentageRate"];
      this.columnPercentageMinimum = this.Columns["PercentageMinimum"];
      this.columnPercentOfChargeCode = this.Columns["PercentOfChargeCode"];
      this.columnSplittable = this.Columns["Splittable"];
      this.columnAutoApplied = this.Columns["AutoApplied"];
      this.columnAppliesToPaymentID = this.Columns["AppliesToPaymentID"];
      this.columnAdded = this.Columns["Added"];
      this.columnTaxable = this.Columns["Taxable"];
      this.columnRoundToDollar = this.Columns["RoundToDollar"];
      this.columnWaivedByUserGuid = this.Columns["WaivedByUserGuid"];
      this.columnConvertedToManualUserGuid = this.Columns["ConvertedToManualUserGuid"];
      this.columnAmountWithInstallments = this.Columns["AmountWithInstallments"];
      this.columnFullyEarned = this.Columns["FullyEarned"];
      this.columnAmount = this.Columns["Amount"];
      this.columnDateAmountDue = this.Columns["DateAmountDue"];
      this.columnDateFilingDue = this.Columns["DateFilingDue"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnOptionFeeID = new DataColumn("OptionFeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptionFeeID);
      this.columnQuoteOptionGuid = new DataColumn("QuoteOptionGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionGuid);
      this.columnCompanyFeeID = new DataColumn("CompanyFeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyFeeID);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnOriginalQuoteOptionGuid = new DataColumn("OriginalQuoteOptionGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOriginalQuoteOptionGuid);
      this.columnFeeTypeID = new DataColumn("FeeTypeID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFeeTypeID);
      this.columnPayable = new DataColumn("Payable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayable);
      this.columnRate = new DataColumn("Rate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRate);
      this.columnPercentageRate = new DataColumn("PercentageRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentageRate);
      this.columnPercentageMinimum = new DataColumn("PercentageMinimum", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentageMinimum);
      this.columnPercentOfChargeCode = new DataColumn("PercentOfChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentOfChargeCode);
      this.columnSplittable = new DataColumn("Splittable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSplittable);
      this.columnAutoApplied = new DataColumn("AutoApplied", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoApplied);
      this.columnAppliesToPaymentID = new DataColumn("AppliesToPaymentID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAppliesToPaymentID);
      this.columnAdded = new DataColumn("Added", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdded);
      this.columnTaxable = new DataColumn("Taxable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxable);
      this.columnRoundToDollar = new DataColumn("RoundToDollar", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoundToDollar);
      this.columnWaivedByUserGuid = new DataColumn("WaivedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWaivedByUserGuid);
      this.columnConvertedToManualUserGuid = new DataColumn("ConvertedToManualUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConvertedToManualUserGuid);
      this.columnAmountWithInstallments = new DataColumn("AmountWithInstallments", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmountWithInstallments);
      this.columnFullyEarned = new DataColumn("FullyEarned", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullyEarned);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnDateAmountDue = new DataColumn("DateAmountDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateAmountDue);
      this.columnDateFilingDue = new DataColumn("DateFilingDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateFilingDue);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnOptionFeeID
      }, true));
      this.columnOptionFeeID.AutoIncrement = true;
      this.columnOptionFeeID.AllowDBNull = false;
      this.columnOptionFeeID.ReadOnly = true;
      this.columnOptionFeeID.Unique = true;
      this.columnQuoteOptionGuid.AllowDBNull = false;
      this.columnCompanyFeeID.AllowDBNull = false;
      this.columnChargeCode.AllowDBNull = false;
      this.columnOfficeID.AllowDBNull = false;
      this.columnCompanyLineGuid.AllowDBNull = false;
      this.columnFeeTypeID.AllowDBNull = false;
      this.columnPayable.AllowDBNull = false;
      this.columnRate.Caption = "FlatRate";
      this.columnSplittable.AllowDBNull = false;
      this.columnAutoApplied.AllowDBNull = false;
      this.columnAppliesToPaymentID.AllowDBNull = false;
      this.columnAppliesToPaymentID.MaxLength = 1;
      this.columnAdded.AllowDBNull = false;
      this.columnTaxable.AllowDBNull = false;
      this.columnRoundToDollar.AllowDBNull = false;
      this.columnAmountWithInstallments.ReadOnly = true;
      this.columnFullyEarned.AllowDBNull = false;
      this.columnAmount.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblQuoteOptionChargesRow NewtblQuoteOptionChargesRow()
    {
      return (dsFilingPolicyInfo.tblQuoteOptionChargesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsFilingPolicyInfo.tblQuoteOptionChargesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsFilingPolicyInfo.tblQuoteOptionChargesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionChargesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblQuoteOptionChargesRowChangeEventHandler chargesRowChangedEvent = this.tblQuoteOptionChargesRowChangedEvent;
      if (chargesRowChangedEvent == null)
        return;
      chargesRowChangedEvent((object) this, new dsFilingPolicyInfo.tblQuoteOptionChargesRowChangeEvent((dsFilingPolicyInfo.tblQuoteOptionChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionChargesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblQuoteOptionChargesRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionChargesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsFilingPolicyInfo.tblQuoteOptionChargesRowChangeEvent((dsFilingPolicyInfo.tblQuoteOptionChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionChargesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblQuoteOptionChargesRowChangeEventHandler chargesRowDeletedEvent = this.tblQuoteOptionChargesRowDeletedEvent;
      if (chargesRowDeletedEvent == null)
        return;
      chargesRowDeletedEvent((object) this, new dsFilingPolicyInfo.tblQuoteOptionChargesRowChangeEvent((dsFilingPolicyInfo.tblQuoteOptionChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionChargesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblQuoteOptionChargesRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionChargesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsFilingPolicyInfo.tblQuoteOptionChargesRowChangeEvent((dsFilingPolicyInfo.tblQuoteOptionChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblQuoteOptionChargesRow(dsFilingPolicyInfo.tblQuoteOptionChargesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsFilingPolicyInfo filingPolicyInfo = new dsFilingPolicyInfo();
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
        FixedValue = filingPolicyInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionChargesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = filingPolicyInfo.GetSchemaSerializable();
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
  public class tblPolicyFilingManagementInfoDataTable : 
    TypedTableBase<dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow>
  {
    private DataColumn columnID;
    private DataColumn columnOptionFeeID;
    private DataColumn columnDSFFillDate;
    private DataColumn columnDecPageFiledDate;
    private DataColumn columnExemptionResearch;
    private DataColumn columnNotes;
    private DataColumn columnCheckRequestDate;
    private DataColumn columnMonthlyReportDue;
    private DataColumn columnQuarterlyReportDue;
    private DataColumn columnSemiAnnualReportDue;
    private DataColumn columnAnnualReportDue;
    private DataColumn columnFilingDone;
    private DataColumn columnFireTaxDue;
    private DataColumn columnRevenueSurchargeDue;
    private DataColumn columnControlsFiledDate;
    private DataColumn columnMunicipalFilingDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblPolicyFilingManagementInfoDataTable()
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.tblPolicyFilingManagementInfoDataTable_ColumnChanging);
      this.TableName = "tblPolicyFilingManagementInfo";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblPolicyFilingManagementInfoDataTable(DataTable table)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.tblPolicyFilingManagementInfoDataTable_ColumnChanging);
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
    protected tblPolicyFilingManagementInfoDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.tblPolicyFilingManagementInfoDataTable_ColumnChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OptionFeeIDColumn => this.columnOptionFeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DSFFillDateColumn => this.columnDSFFillDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DecPageFiledDateColumn => this.columnDecPageFiledDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExemptionResearchColumn => this.columnExemptionResearch;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NotesColumn => this.columnNotes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CheckRequestDateColumn => this.columnCheckRequestDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MonthlyReportDueColumn => this.columnMonthlyReportDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuarterlyReportDueColumn => this.columnQuarterlyReportDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SemiAnnualReportDueColumn => this.columnSemiAnnualReportDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AnnualReportDueColumn => this.columnAnnualReportDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FilingDoneColumn => this.columnFilingDone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FireTaxDueColumn => this.columnFireTaxDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RevenueSurchargeDueColumn => this.columnRevenueSurchargeDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ControlsFiledDateColumn => this.columnControlsFiledDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MunicipalFilingDueColumn => this.columnMunicipalFilingDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow this[int index]
    {
      get => (dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblPolicyFilingManagementInfoRowChangeEventHandler tblPolicyFilingManagementInfoRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblPolicyFilingManagementInfoRowChangeEventHandler tblPolicyFilingManagementInfoRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblPolicyFilingManagementInfoRowChangeEventHandler tblPolicyFilingManagementInfoRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblPolicyFilingManagementInfoRowChangeEventHandler tblPolicyFilingManagementInfoRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblPolicyFilingManagementInfoRow(
      dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow AddtblPolicyFilingManagementInfoRow(
      int OptionFeeID,
      DateTime DSFFillDate,
      DateTime DecPageFiledDate,
      string ExemptionResearch,
      string Notes,
      DateTime CheckRequestDate,
      DateTime MonthlyReportDue,
      DateTime QuarterlyReportDue,
      DateTime SemiAnnualReportDue,
      DateTime AnnualReportDue,
      DateTime FilingDone,
      DateTime FireTaxDue,
      DateTime RevenueSurchargeDue,
      DateTime ControlsFiledDate,
      DateTime MunicipalFilingDue)
    {
      dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow row = (dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow) this.NewRow();
      object[] objArray = new object[16 /*0x10*/]
      {
        null,
        (object) OptionFeeID,
        (object) DSFFillDate,
        (object) DecPageFiledDate,
        (object) ExemptionResearch,
        (object) Notes,
        (object) CheckRequestDate,
        (object) MonthlyReportDue,
        (object) QuarterlyReportDue,
        (object) SemiAnnualReportDue,
        (object) AnnualReportDue,
        (object) FilingDone,
        (object) FireTaxDue,
        (object) RevenueSurchargeDue,
        (object) ControlsFiledDate,
        (object) MunicipalFilingDue
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow FindByID(int ID)
    {
      return (dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsFilingPolicyInfo.tblPolicyFilingManagementInfoDataTable managementInfoDataTable = (dsFilingPolicyInfo.tblPolicyFilingManagementInfoDataTable) base.Clone();
      managementInfoDataTable.InitVars();
      return (DataTable) managementInfoDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsFilingPolicyInfo.tblPolicyFilingManagementInfoDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnOptionFeeID = this.Columns["OptionFeeID"];
      this.columnDSFFillDate = this.Columns["DSFFillDate"];
      this.columnDecPageFiledDate = this.Columns["DecPageFiledDate"];
      this.columnExemptionResearch = this.Columns["ExemptionResearch"];
      this.columnNotes = this.Columns["Notes"];
      this.columnCheckRequestDate = this.Columns["CheckRequestDate"];
      this.columnMonthlyReportDue = this.Columns["MonthlyReportDue"];
      this.columnQuarterlyReportDue = this.Columns["QuarterlyReportDue"];
      this.columnSemiAnnualReportDue = this.Columns["SemiAnnualReportDue"];
      this.columnAnnualReportDue = this.Columns["AnnualReportDue"];
      this.columnFilingDone = this.Columns["FilingDone"];
      this.columnFireTaxDue = this.Columns["FireTaxDue"];
      this.columnRevenueSurchargeDue = this.Columns["RevenueSurchargeDue"];
      this.columnControlsFiledDate = this.Columns["ControlsFiledDate"];
      this.columnMunicipalFilingDue = this.Columns["MunicipalFilingDue"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnOptionFeeID = new DataColumn("OptionFeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptionFeeID);
      this.columnDSFFillDate = new DataColumn("DSFFillDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDSFFillDate);
      this.columnDecPageFiledDate = new DataColumn("DecPageFiledDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDecPageFiledDate);
      this.columnExemptionResearch = new DataColumn("ExemptionResearch", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExemptionResearch);
      this.columnNotes = new DataColumn("Notes", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNotes);
      this.columnCheckRequestDate = new DataColumn("CheckRequestDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheckRequestDate);
      this.columnMonthlyReportDue = new DataColumn("MonthlyReportDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMonthlyReportDue);
      this.columnQuarterlyReportDue = new DataColumn("QuarterlyReportDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuarterlyReportDue);
      this.columnSemiAnnualReportDue = new DataColumn("SemiAnnualReportDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSemiAnnualReportDue);
      this.columnAnnualReportDue = new DataColumn("AnnualReportDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAnnualReportDue);
      this.columnFilingDone = new DataColumn("FilingDone", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFilingDone);
      this.columnFireTaxDue = new DataColumn("FireTaxDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFireTaxDue);
      this.columnRevenueSurchargeDue = new DataColumn("RevenueSurchargeDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRevenueSurchargeDue);
      this.columnControlsFiledDate = new DataColumn("ControlsFiledDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlsFiledDate);
      this.columnMunicipalFilingDue = new DataColumn("MunicipalFilingDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMunicipalFilingDue);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnOptionFeeID.AllowDBNull = false;
      this.columnExemptionResearch.MaxLength = 3500;
      this.columnNotes.MaxLength = 3500;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow NewtblPolicyFilingManagementInfoRow()
    {
      return (dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFilingManagementInfoRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblPolicyFilingManagementInfoRowChangeEventHandler infoRowChangedEvent = this.tblPolicyFilingManagementInfoRowChangedEvent;
      if (infoRowChangedEvent == null)
        return;
      infoRowChangedEvent((object) this, new dsFilingPolicyInfo.tblPolicyFilingManagementInfoRowChangeEvent((dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFilingManagementInfoRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblPolicyFilingManagementInfoRowChangeEventHandler rowChangingEvent = this.tblPolicyFilingManagementInfoRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsFilingPolicyInfo.tblPolicyFilingManagementInfoRowChangeEvent((dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFilingManagementInfoRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblPolicyFilingManagementInfoRowChangeEventHandler infoRowDeletedEvent = this.tblPolicyFilingManagementInfoRowDeletedEvent;
      if (infoRowDeletedEvent == null)
        return;
      infoRowDeletedEvent((object) this, new dsFilingPolicyInfo.tblPolicyFilingManagementInfoRowChangeEvent((dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFilingManagementInfoRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblPolicyFilingManagementInfoRowChangeEventHandler rowDeletingEvent = this.tblPolicyFilingManagementInfoRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsFilingPolicyInfo.tblPolicyFilingManagementInfoRowChangeEvent((dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblPolicyFilingManagementInfoRow(
      dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsFilingPolicyInfo filingPolicyInfo = new dsFilingPolicyInfo();
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
        FixedValue = filingPolicyInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblPolicyFilingManagementInfoDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = filingPolicyInfo.GetSchemaSerializable();
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

    private void tblPolicyFilingManagementInfoDataTable_ColumnChanging(
      object sender,
      DataColumnChangeEventArgs e)
    {
      Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Column.ColumnName, this.NotesColumn.ColumnName, false);
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblStatesSLRequiredDataDataTable : 
    TypedTableBase<dsFilingPolicyInfo.tblStatesSLRequiredDataRow>
  {
    private DataColumn columnRequiredDataID;
    private DataColumn columnRequiredData;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblStatesSLRequiredDataDataTable()
    {
      this.TableName = "tblStatesSLRequiredData";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblStatesSLRequiredDataDataTable(DataTable table)
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
    protected tblStatesSLRequiredDataDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RequiredDataIDColumn => this.columnRequiredDataID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RequiredDataColumn => this.columnRequiredData;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblStatesSLRequiredDataRow this[int index]
    {
      get => (dsFilingPolicyInfo.tblStatesSLRequiredDataRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblStatesSLRequiredDataRowChangeEventHandler tblStatesSLRequiredDataRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblStatesSLRequiredDataRowChangeEventHandler tblStatesSLRequiredDataRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblStatesSLRequiredDataRowChangeEventHandler tblStatesSLRequiredDataRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblStatesSLRequiredDataRowChangeEventHandler tblStatesSLRequiredDataRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblStatesSLRequiredDataRow(dsFilingPolicyInfo.tblStatesSLRequiredDataRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblStatesSLRequiredDataRow AddtblStatesSLRequiredDataRow(
      int RequiredDataID,
      string RequiredData)
    {
      dsFilingPolicyInfo.tblStatesSLRequiredDataRow row = (dsFilingPolicyInfo.tblStatesSLRequiredDataRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) RequiredDataID,
        (object) RequiredData
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsFilingPolicyInfo.tblStatesSLRequiredDataDataTable requiredDataDataTable = (dsFilingPolicyInfo.tblStatesSLRequiredDataDataTable) base.Clone();
      requiredDataDataTable.InitVars();
      return (DataTable) requiredDataDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsFilingPolicyInfo.tblStatesSLRequiredDataDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnRequiredDataID = this.Columns["RequiredDataID"];
      this.columnRequiredData = this.Columns["RequiredData"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnRequiredDataID = new DataColumn("RequiredDataID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiredDataID);
      this.columnRequiredData = new DataColumn("RequiredData", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiredData);
      this.columnRequiredDataID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblStatesSLRequiredDataRow NewtblStatesSLRequiredDataRow()
    {
      return (dsFilingPolicyInfo.tblStatesSLRequiredDataRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsFilingPolicyInfo.tblStatesSLRequiredDataRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsFilingPolicyInfo.tblStatesSLRequiredDataRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStatesSLRequiredDataRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblStatesSLRequiredDataRowChangeEventHandler dataRowChangedEvent = this.tblStatesSLRequiredDataRowChangedEvent;
      if (dataRowChangedEvent == null)
        return;
      dataRowChangedEvent((object) this, new dsFilingPolicyInfo.tblStatesSLRequiredDataRowChangeEvent((dsFilingPolicyInfo.tblStatesSLRequiredDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStatesSLRequiredDataRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblStatesSLRequiredDataRowChangeEventHandler rowChangingEvent = this.tblStatesSLRequiredDataRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsFilingPolicyInfo.tblStatesSLRequiredDataRowChangeEvent((dsFilingPolicyInfo.tblStatesSLRequiredDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStatesSLRequiredDataRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblStatesSLRequiredDataRowChangeEventHandler dataRowDeletedEvent = this.tblStatesSLRequiredDataRowDeletedEvent;
      if (dataRowDeletedEvent == null)
        return;
      dataRowDeletedEvent((object) this, new dsFilingPolicyInfo.tblStatesSLRequiredDataRowChangeEvent((dsFilingPolicyInfo.tblStatesSLRequiredDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStatesSLRequiredDataRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblStatesSLRequiredDataRowChangeEventHandler rowDeletingEvent = this.tblStatesSLRequiredDataRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsFilingPolicyInfo.tblStatesSLRequiredDataRowChangeEvent((dsFilingPolicyInfo.tblStatesSLRequiredDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblStatesSLRequiredDataRow(dsFilingPolicyInfo.tblStatesSLRequiredDataRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsFilingPolicyInfo filingPolicyInfo = new dsFilingPolicyInfo();
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
        FixedValue = filingPolicyInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblStatesSLRequiredDataDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = filingPolicyInfo.GetSchemaSerializable();
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
  public class tblStatesSLRequiredData_InfoDataTable : 
    TypedTableBase<dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnRequiredDataID;
    private DataColumn columnUseForFiling;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblStatesSLRequiredData_InfoDataTable()
    {
      this.TableName = "tblStatesSLRequiredData_Info";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblStatesSLRequiredData_InfoDataTable(DataTable table)
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
    protected tblStatesSLRequiredData_InfoDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RequiredDataIDColumn => this.columnRequiredDataID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UseForFilingColumn => this.columnUseForFiling;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow this[int index]
    {
      get => (dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRowChangeEventHandler tblStatesSLRequiredData_InfoRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRowChangeEventHandler tblStatesSLRequiredData_InfoRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRowChangeEventHandler tblStatesSLRequiredData_InfoRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRowChangeEventHandler tblStatesSLRequiredData_InfoRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblStatesSLRequiredData_InfoRow(
      dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow AddtblStatesSLRequiredData_InfoRow(
      string StateID,
      int RequiredDataID,
      bool UseForFiling)
    {
      dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow row = (dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) StateID,
        (object) RequiredDataID,
        (object) UseForFiling
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow FindByStateIDRequiredDataID(
      string StateID,
      int RequiredDataID)
    {
      return (dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow) this.Rows.Find(new object[2]
      {
        (object) StateID,
        (object) RequiredDataID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsFilingPolicyInfo.tblStatesSLRequiredData_InfoDataTable dataInfoDataTable = (dsFilingPolicyInfo.tblStatesSLRequiredData_InfoDataTable) base.Clone();
      dataInfoDataTable.InitVars();
      return (DataTable) dataInfoDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsFilingPolicyInfo.tblStatesSLRequiredData_InfoDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnRequiredDataID = this.Columns["RequiredDataID"];
      this.columnUseForFiling = this.Columns["UseForFiling"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnRequiredDataID = new DataColumn("RequiredDataID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiredDataID);
      this.columnUseForFiling = new DataColumn("UseForFiling", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUseForFiling);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnStateID,
        this.columnRequiredDataID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.MaxLength = 2;
      this.columnRequiredDataID.AllowDBNull = false;
      this.columnUseForFiling.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow NewtblStatesSLRequiredData_InfoRow()
    {
      return (dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStatesSLRequiredData_InfoRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRowChangeEventHandler infoRowChangedEvent = this.tblStatesSLRequiredData_InfoRowChangedEvent;
      if (infoRowChangedEvent == null)
        return;
      infoRowChangedEvent((object) this, new dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRowChangeEvent((dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStatesSLRequiredData_InfoRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRowChangeEventHandler rowChangingEvent = this.tblStatesSLRequiredData_InfoRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRowChangeEvent((dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStatesSLRequiredData_InfoRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRowChangeEventHandler infoRowDeletedEvent = this.tblStatesSLRequiredData_InfoRowDeletedEvent;
      if (infoRowDeletedEvent == null)
        return;
      infoRowDeletedEvent((object) this, new dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRowChangeEvent((dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStatesSLRequiredData_InfoRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRowChangeEventHandler rowDeletingEvent = this.tblStatesSLRequiredData_InfoRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRowChangeEvent((dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblStatesSLRequiredData_InfoRow(
      dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsFilingPolicyInfo filingPolicyInfo = new dsFilingPolicyInfo();
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
        FixedValue = filingPolicyInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblStatesSLRequiredData_InfoDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = filingPolicyInfo.GetSchemaSerializable();
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
  public class tblClientOfficesDataTable : TypedTableBase<dsFilingPolicyInfo.tblClientOfficesRow>
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
    public dsFilingPolicyInfo.tblClientOfficesRow this[int index]
    {
      get => (dsFilingPolicyInfo.tblClientOfficesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblClientOfficesRow(dsFilingPolicyInfo.tblClientOfficesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblClientOfficesRow AddtblClientOfficesRow(
      Guid OfficeGUID,
      string Location)
    {
      dsFilingPolicyInfo.tblClientOfficesRow row = (dsFilingPolicyInfo.tblClientOfficesRow) this.NewRow();
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
    public dsFilingPolicyInfo.tblClientOfficesRow FindByOfficeGUID(Guid OfficeGUID)
    {
      return (dsFilingPolicyInfo.tblClientOfficesRow) this.Rows.Find(new object[1]
      {
        (object) OfficeGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsFilingPolicyInfo.tblClientOfficesDataTable officesDataTable = (dsFilingPolicyInfo.tblClientOfficesDataTable) base.Clone();
      officesDataTable.InitVars();
      return (DataTable) officesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsFilingPolicyInfo.tblClientOfficesDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnOfficeGUID
      }, true));
      this.columnOfficeGUID.AllowDBNull = false;
      this.columnOfficeGUID.Unique = true;
      this.columnLocation.AllowDBNull = false;
      this.columnLocation.MaxLength = 250;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblClientOfficesRow NewtblClientOfficesRow()
    {
      return (dsFilingPolicyInfo.tblClientOfficesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsFilingPolicyInfo.tblClientOfficesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsFilingPolicyInfo.tblClientOfficesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblClientOfficesRowChangeEventHandler officesRowChangedEvent = this.tblClientOfficesRowChangedEvent;
      if (officesRowChangedEvent == null)
        return;
      officesRowChangedEvent((object) this, new dsFilingPolicyInfo.tblClientOfficesRowChangeEvent((dsFilingPolicyInfo.tblClientOfficesRow) e.Row, e.Action));
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
      dsFilingPolicyInfo.tblClientOfficesRowChangeEventHandler rowChangingEvent = this.tblClientOfficesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsFilingPolicyInfo.tblClientOfficesRowChangeEvent((dsFilingPolicyInfo.tblClientOfficesRow) e.Row, e.Action));
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
      dsFilingPolicyInfo.tblClientOfficesRowChangeEventHandler officesRowDeletedEvent = this.tblClientOfficesRowDeletedEvent;
      if (officesRowDeletedEvent == null)
        return;
      officesRowDeletedEvent((object) this, new dsFilingPolicyInfo.tblClientOfficesRowChangeEvent((dsFilingPolicyInfo.tblClientOfficesRow) e.Row, e.Action));
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
      dsFilingPolicyInfo.tblClientOfficesRowChangeEventHandler rowDeletingEvent = this.tblClientOfficesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsFilingPolicyInfo.tblClientOfficesRowChangeEvent((dsFilingPolicyInfo.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblClientOfficesRow(dsFilingPolicyInfo.tblClientOfficesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsFilingPolicyInfo filingPolicyInfo = new dsFilingPolicyInfo();
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
        FixedValue = filingPolicyInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClientOfficesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = filingPolicyInfo.GetSchemaSerializable();
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
  public class tblStateSLRulesDataTable : TypedTableBase<dsFilingPolicyInfo.tblStateSLRulesRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnOtherInfo;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblStateSLRulesDataTable()
    {
      this.TableName = "tblStateSLRules";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblStateSLRulesDataTable(DataTable table)
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
    protected tblStateSLRulesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OtherInfoColumn => this.columnOtherInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblStateSLRulesRow this[int index]
    {
      get => (dsFilingPolicyInfo.tblStateSLRulesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblStateSLRulesRowChangeEventHandler tblStateSLRulesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblStateSLRulesRowChangeEventHandler tblStateSLRulesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblStateSLRulesRowChangeEventHandler tblStateSLRulesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsFilingPolicyInfo.tblStateSLRulesRowChangeEventHandler tblStateSLRulesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblStateSLRulesRow(dsFilingPolicyInfo.tblStateSLRulesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblStateSLRulesRow AddtblStateSLRulesRow(
      string StateID,
      string OtherInfo,
      string Description)
    {
      dsFilingPolicyInfo.tblStateSLRulesRow row = (dsFilingPolicyInfo.tblStateSLRulesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) StateID,
        (object) OtherInfo,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblStateSLRulesRow FindByStateID(string StateID)
    {
      return (dsFilingPolicyInfo.tblStateSLRulesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsFilingPolicyInfo.tblStateSLRulesDataTable slRulesDataTable = (dsFilingPolicyInfo.tblStateSLRulesDataTable) base.Clone();
      slRulesDataTable.InitVars();
      return (DataTable) slRulesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsFilingPolicyInfo.tblStateSLRulesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnOtherInfo = this.Columns["OtherInfo"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnOtherInfo = new DataColumn("OtherInfo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOtherInfo);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnStateID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.Unique = true;
      this.columnStateID.MaxLength = 2;
      this.columnOtherInfo.MaxLength = 2000;
      this.columnDescription.MaxLength = 2000;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblStateSLRulesRow NewtblStateSLRulesRow()
    {
      return (dsFilingPolicyInfo.tblStateSLRulesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsFilingPolicyInfo.tblStateSLRulesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsFilingPolicyInfo.tblStateSLRulesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStateSLRulesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblStateSLRulesRowChangeEventHandler rulesRowChangedEvent = this.tblStateSLRulesRowChangedEvent;
      if (rulesRowChangedEvent == null)
        return;
      rulesRowChangedEvent((object) this, new dsFilingPolicyInfo.tblStateSLRulesRowChangeEvent((dsFilingPolicyInfo.tblStateSLRulesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStateSLRulesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblStateSLRulesRowChangeEventHandler rowChangingEvent = this.tblStateSLRulesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsFilingPolicyInfo.tblStateSLRulesRowChangeEvent((dsFilingPolicyInfo.tblStateSLRulesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStateSLRulesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblStateSLRulesRowChangeEventHandler rulesRowDeletedEvent = this.tblStateSLRulesRowDeletedEvent;
      if (rulesRowDeletedEvent == null)
        return;
      rulesRowDeletedEvent((object) this, new dsFilingPolicyInfo.tblStateSLRulesRowChangeEvent((dsFilingPolicyInfo.tblStateSLRulesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStateSLRulesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFilingPolicyInfo.tblStateSLRulesRowChangeEventHandler rowDeletingEvent = this.tblStateSLRulesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsFilingPolicyInfo.tblStateSLRulesRowChangeEvent((dsFilingPolicyInfo.tblStateSLRulesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblStateSLRulesRow(dsFilingPolicyInfo.tblStateSLRulesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsFilingPolicyInfo filingPolicyInfo = new dsFilingPolicyInfo();
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
        FixedValue = filingPolicyInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblStateSLRulesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = filingPolicyInfo.GetSchemaSerializable();
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

  public class PolicyFilingInformationRow : DataRow
  {
    private dsFilingPolicyInfo.PolicyFilingInformationDataTable tablePolicyFilingInformation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal PolicyFilingInformationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePolicyFilingInformation = (dsFilingPolicyInfo.PolicyFilingInformationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredPolicyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyFilingInformation.InsuredPolicyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredPolicyName' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.InsuredPolicyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AffidavitNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyFilingInformation.AffidavitNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AffidavitNumber' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.AffidavitNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LicenseNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyFilingInformation.LicenseNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LicenseNumber' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.LicenseNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string FilingProducer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyFilingInformation.FilingProducerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FilingProducer' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.FilingProducerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public double Premium
    {
      get
      {
        try
        {
          return Conversions.ToDouble(this[this.tablePolicyFilingInformation.PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Premium' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateAmountDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.DateAmountDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateAmountDue' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.DateAmountDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateFilingDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.DateFilingDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateFilingDue' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.DateFilingDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyFilingInformation.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ControlNo
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePolicyFilingInformation.ControlNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ControlNo' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyFilingInformation.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OptionFeeID
    {
      get => Conversions.ToInteger(this[this.tablePolicyFilingInformation.OptionFeeIDColumn]);
      set => this[this.tablePolicyFilingInformation.OptionFeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal TaxDue
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePolicyFilingInformation.TaxDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TaxDue' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.TaxDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal FeesDue
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePolicyFilingInformation.FeesDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FeesDue' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.FeesDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string TransactionType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyFilingInformation.TransactionTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TransactionType' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.TransactionTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime TransactionEffective
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.TransactionEffectiveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TransactionEffective' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.TransactionEffectiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Rate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyFilingInformation.RateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Rate' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.RateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PayeeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyFilingInformation.PayeeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PayeeName' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.PayeeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCheckRequestDate
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablePolicyFilingInformation.IsCheckRequestDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IsCheckRequestDate' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.IsCheckRequestDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime TransactionDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.TransactionDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TransactionDate' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.TransactionDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Paid
    {
      get => Conversions.ToBoolean(this[this.tablePolicyFilingInformation.PaidColumn]);
      set => this[this.tablePolicyFilingInformation.PaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ChargeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyFilingInformation.ChargeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeName' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public double StatePremium
    {
      get
      {
        try
        {
          return Conversions.ToDouble(this[this.tablePolicyFilingInformation.StatePremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatePremium' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.StatePremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LOB
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyFilingInformation.LOBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LOB' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.LOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Carrier
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyFilingInformation.CarrierColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Carrier' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.CarrierColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int InvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePolicyFilingInformation.InvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InvoiceNum' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public double PolicyTIV
    {
      get
      {
        try
        {
          return Conversions.ToDouble(this[this.tablePolicyFilingInformation.PolicyTIVColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyTIV' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.PolicyTIVColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public double StateTIV
    {
      get
      {
        try
        {
          return Conversions.ToDouble(this[this.tablePolicyFilingInformation.StateTIVColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateTIV' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.StateTIVColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Filed
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablePolicyFilingInformation.FiledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Filed' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.FiledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DecPageFiledDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.DecPageFiledDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DecPageFiledDate' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.DecPageFiledDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DSFFillDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.DSFFillDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DSFFillDate' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.DSFFillDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime ControlsFiledDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.ControlsFiledDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ControlsFiledDate' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.ControlsFiledDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime MonthlyReportDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.MonthlyReportDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MonthlyReportDue' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.MonthlyReportDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime QuarterlyReportDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.QuarterlyReportDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuarterlyReportDue' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.QuarterlyReportDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime SemiAnnualReportDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.SemiAnnualReportDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SemiAnnualReportDue' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.SemiAnnualReportDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime AnnualReportDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.AnnualReportDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AnnualReportDue' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.AnnualReportDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime FilingDone
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.FilingDoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FilingDone' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.FilingDoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime FireTaxDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.FireTaxDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FireTaxDue' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.FireTaxDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime MunicipalFilingDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.MunicipalFilingDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MunicipalFilingDue' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.MunicipalFilingDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime RevenueSurchargeDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.RevenueSurchargeDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RevenueSurchargeDue' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.RevenueSurchargeDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DatePaid
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.DatePaidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DatePaid' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.DatePaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Underwriter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyFilingInformation.UnderwriterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Underwriter' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.UnderwriterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateFiled
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.DateFiledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateFiled' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.DateFiledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool TaxableFee
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablePolicyFilingInformation.TaxableFeeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TaxableFee' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.TaxableFeeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool OffSet
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablePolicyFilingInformation.OffSetColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OffSet' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.OffSetColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal TaxableFeesAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePolicyFilingInformation.TaxableFeesAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TaxableFeesAmount' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.TaxableFeesAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime InvoiceDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicyFilingInformation.InvoiceDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InvoiceDate' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.InvoiceDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal TotalPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePolicyFilingInformation.TotalPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TotalPremium' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.TotalPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicyFilingInformation.PolicyStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyStatus' in table 'PolicyFilingInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyFilingInformation.PolicyStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredPolicyNameNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.InsuredPolicyNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredPolicyNameNull()
    {
      this[this.tablePolicyFilingInformation.InsuredPolicyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAffidavitNumberNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.AffidavitNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAffidavitNumberNull()
    {
      this[this.tablePolicyFilingInformation.AffidavitNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLicenseNumberNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.LicenseNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLicenseNumberNull()
    {
      this[this.tablePolicyFilingInformation.LicenseNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFilingProducerNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.FilingProducerColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFilingProducerNull()
    {
      this[this.tablePolicyFilingInformation.FilingProducerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tablePolicyFilingInformation.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tablePolicyFilingInformation.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateAmountDueNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.DateAmountDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateAmountDueNull()
    {
      this[this.tablePolicyFilingInformation.DateAmountDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateFilingDueNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.DateFilingDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateFilingDueNull()
    {
      this[this.tablePolicyFilingInformation.DateFilingDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tablePolicyFilingInformation.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tablePolicyFilingInformation.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsControlNoNull() => this.IsNull(this.tablePolicyFilingInformation.ControlNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetControlNoNull()
    {
      this[this.tablePolicyFilingInformation.ControlNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyNumberNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.PolicyNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tablePolicyFilingInformation.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTaxDueNull() => this.IsNull(this.tablePolicyFilingInformation.TaxDueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTaxDueNull()
    {
      this[this.tablePolicyFilingInformation.TaxDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFeesDueNull() => this.IsNull(this.tablePolicyFilingInformation.FeesDueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFeesDueNull()
    {
      this[this.tablePolicyFilingInformation.FeesDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTransactionTypeNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.TransactionTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTransactionTypeNull()
    {
      this[this.tablePolicyFilingInformation.TransactionTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTransactionEffectiveNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.TransactionEffectiveColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTransactionEffectiveNull()
    {
      this[this.tablePolicyFilingInformation.TransactionEffectiveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRateNull() => this.IsNull(this.tablePolicyFilingInformation.RateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRateNull()
    {
      this[this.tablePolicyFilingInformation.RateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPayeeNameNull() => this.IsNull(this.tablePolicyFilingInformation.PayeeNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPayeeNameNull()
    {
      this[this.tablePolicyFilingInformation.PayeeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIsCheckRequestDateNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.IsCheckRequestDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIsCheckRequestDateNull()
    {
      this[this.tablePolicyFilingInformation.IsCheckRequestDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTransactionDateNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.TransactionDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTransactionDateNull()
    {
      this[this.tablePolicyFilingInformation.TransactionDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsChargeNameNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.ChargeNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetChargeNameNull()
    {
      this[this.tablePolicyFilingInformation.ChargeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStatePremiumNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.StatePremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatePremiumNull()
    {
      this[this.tablePolicyFilingInformation.StatePremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLOBNull() => this.IsNull(this.tablePolicyFilingInformation.LOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLOBNull()
    {
      this[this.tablePolicyFilingInformation.LOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCarrierNull() => this.IsNull(this.tablePolicyFilingInformation.CarrierColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCarrierNull()
    {
      this[this.tablePolicyFilingInformation.CarrierColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInvoiceNumNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.InvoiceNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInvoiceNumNull()
    {
      this[this.tablePolicyFilingInformation.InvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyTIVNull() => this.IsNull(this.tablePolicyFilingInformation.PolicyTIVColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyTIVNull()
    {
      this[this.tablePolicyFilingInformation.PolicyTIVColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateTIVNull() => this.IsNull(this.tablePolicyFilingInformation.StateTIVColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateTIVNull()
    {
      this[this.tablePolicyFilingInformation.StateTIVColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFiledNull() => this.IsNull(this.tablePolicyFilingInformation.FiledColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFiledNull()
    {
      this[this.tablePolicyFilingInformation.FiledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDecPageFiledDateNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.DecPageFiledDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDecPageFiledDateNull()
    {
      this[this.tablePolicyFilingInformation.DecPageFiledDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDSFFillDateNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.DSFFillDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDSFFillDateNull()
    {
      this[this.tablePolicyFilingInformation.DSFFillDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsControlsFiledDateNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.ControlsFiledDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetControlsFiledDateNull()
    {
      this[this.tablePolicyFilingInformation.ControlsFiledDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMonthlyReportDueNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.MonthlyReportDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMonthlyReportDueNull()
    {
      this[this.tablePolicyFilingInformation.MonthlyReportDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsQuarterlyReportDueNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.QuarterlyReportDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetQuarterlyReportDueNull()
    {
      this[this.tablePolicyFilingInformation.QuarterlyReportDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSemiAnnualReportDueNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.SemiAnnualReportDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSemiAnnualReportDueNull()
    {
      this[this.tablePolicyFilingInformation.SemiAnnualReportDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAnnualReportDueNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.AnnualReportDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAnnualReportDueNull()
    {
      this[this.tablePolicyFilingInformation.AnnualReportDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFilingDoneNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.FilingDoneColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFilingDoneNull()
    {
      this[this.tablePolicyFilingInformation.FilingDoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFireTaxDueNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.FireTaxDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFireTaxDueNull()
    {
      this[this.tablePolicyFilingInformation.FireTaxDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMunicipalFilingDueNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.MunicipalFilingDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMunicipalFilingDueNull()
    {
      this[this.tablePolicyFilingInformation.MunicipalFilingDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRevenueSurchargeDueNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.RevenueSurchargeDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRevenueSurchargeDueNull()
    {
      this[this.tablePolicyFilingInformation.RevenueSurchargeDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDatePaidNull() => this.IsNull(this.tablePolicyFilingInformation.DatePaidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDatePaidNull()
    {
      this[this.tablePolicyFilingInformation.DatePaidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUnderwriterNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.UnderwriterColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUnderwriterNull()
    {
      this[this.tablePolicyFilingInformation.UnderwriterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateFiledNull() => this.IsNull(this.tablePolicyFilingInformation.DateFiledColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateFiledNull()
    {
      this[this.tablePolicyFilingInformation.DateFiledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTaxableFeeNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.TaxableFeeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTaxableFeeNull()
    {
      this[this.tablePolicyFilingInformation.TaxableFeeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOffSetNull() => this.IsNull(this.tablePolicyFilingInformation.OffSetColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOffSetNull()
    {
      this[this.tablePolicyFilingInformation.OffSetColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTaxableFeesAmountNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.TaxableFeesAmountColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTaxableFeesAmountNull()
    {
      this[this.tablePolicyFilingInformation.TaxableFeesAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInvoiceDateNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.InvoiceDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInvoiceDateNull()
    {
      this[this.tablePolicyFilingInformation.InvoiceDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTotalPremiumNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.TotalPremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTotalPremiumNull()
    {
      this[this.tablePolicyFilingInformation.TotalPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyStatusNull()
    {
      return this.IsNull(this.tablePolicyFilingInformation.PolicyStatusColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyStatusNull()
    {
      this[this.tablePolicyFilingInformation.PolicyStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstStatesRow : DataRow
  {
    private dsFilingPolicyInfo.lstStatesDataTable tablelstStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStates = (dsFilingPolicyInfo.lstStatesDataTable) this.Table;
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
  }

  public class tblFin_PolicyChargesRow : DataRow
  {
    private dsFilingPolicyInfo.tblFin_PolicyChargesDataTable tabletblFin_PolicyCharges;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblFin_PolicyChargesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblFin_PolicyCharges = (dsFilingPolicyInfo.tblFin_PolicyChargesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tabletblFin_PolicyCharges.ChargeCodeColumn]);
      set => this[this.tabletblFin_PolicyCharges.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ChargeName
    {
      get => Conversions.ToString(this[this.tabletblFin_PolicyCharges.ChargeNameColumn]);
      set => this[this.tabletblFin_PolicyCharges.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDescriptionNull()
    {
      return this.IsNull(this.tabletblFin_PolicyCharges.DescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tabletblFin_PolicyCharges.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabletblFin_PolicyCharges.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblFin_PolicyCharges.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblQuoteOptionChargesRow : DataRow
  {
    private dsFilingPolicyInfo.tblQuoteOptionChargesDataTable tabletblQuoteOptionCharges;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuoteOptionChargesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptionCharges = (dsFilingPolicyInfo.tblQuoteOptionChargesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OptionFeeID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionCharges.OptionFeeIDColumn]);
      set => this[this.tabletblQuoteOptionCharges.OptionFeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid QuoteOptionGuid
    {
      get
      {
        object obj = this[this.tabletblQuoteOptionCharges.QuoteOptionGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptionCharges.QuoteOptionGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CompanyFeeID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionCharges.CompanyFeeIDColumn]);
      set => this[this.tabletblQuoteOptionCharges.CompanyFeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionCharges.ChargeCodeColumn]);
      set => this[this.tabletblQuoteOptionCharges.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OfficeID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionCharges.OfficeIDColumn]);
      set => this[this.tabletblQuoteOptionCharges.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        object obj = this[this.tabletblQuoteOptionCharges.CompanyLineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptionCharges.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid OriginalQuoteOptionGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuoteOptionCharges.OriginalQuoteOptionGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OriginalQuoteOptionGuid' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.OriginalQuoteOptionGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public byte FeeTypeID
    {
      get => Conversions.ToByte(this[this.tabletblQuoteOptionCharges.FeeTypeIDColumn]);
      set => this[this.tabletblQuoteOptionCharges.FeeTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Payable
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionCharges.PayableColumn]);
      set => this[this.tabletblQuoteOptionCharges.PayableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Rate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionCharges.RateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Rate' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.RateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal PercentageRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionCharges.PercentageRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PercentageRate' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.PercentageRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal PercentageMinimum
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionCharges.PercentageMinimumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PercentageMinimum' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.PercentageMinimumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int PercentOfChargeCode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionCharges.PercentOfChargeCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PercentOfChargeCode' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.PercentOfChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Splittable
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionCharges.SplittableColumn]);
      set => this[this.tabletblQuoteOptionCharges.SplittableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoApplied
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionCharges.AutoAppliedColumn]);
      set => this[this.tabletblQuoteOptionCharges.AutoAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AppliesToPaymentID
    {
      get => Conversions.ToString(this[this.tabletblQuoteOptionCharges.AppliesToPaymentIDColumn]);
      set => this[this.tabletblQuoteOptionCharges.AppliesToPaymentIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime Added
    {
      get => Conversions.ToDate(this[this.tabletblQuoteOptionCharges.AddedColumn]);
      set => this[this.tabletblQuoteOptionCharges.AddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Taxable
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionCharges.TaxableColumn]);
      set => this[this.tabletblQuoteOptionCharges.TaxableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool RoundToDollar
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionCharges.RoundToDollarColumn]);
      set => this[this.tabletblQuoteOptionCharges.RoundToDollarColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid WaivedByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuoteOptionCharges.WaivedByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WaivedByUserGuid' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.WaivedByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ConvertedToManualUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblQuoteOptionCharges.ConvertedToManualUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConvertedToManualUserGuid' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.ConvertedToManualUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal AmountWithInstallments
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionCharges.AmountWithInstallmentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AmountWithInstallments' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.AmountWithInstallmentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool FullyEarned
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionCharges.FullyEarnedColumn]);
      set => this[this.tabletblQuoteOptionCharges.FullyEarnedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Amount
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionCharges.AmountColumn]);
      set => this[this.tabletblQuoteOptionCharges.AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateAmountDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblQuoteOptionCharges.DateAmountDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateAmountDue' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.DateAmountDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateFilingDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblQuoteOptionCharges.DateFilingDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateFilingDue' in table 'tblQuoteOptionCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionCharges.DateFilingDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOriginalQuoteOptionGuidNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.OriginalQuoteOptionGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOriginalQuoteOptionGuidNull()
    {
      this[this.tabletblQuoteOptionCharges.OriginalQuoteOptionGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRateNull() => this.IsNull(this.tabletblQuoteOptionCharges.RateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRateNull()
    {
      this[this.tabletblQuoteOptionCharges.RateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPercentageRateNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.PercentageRateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPercentageRateNull()
    {
      this[this.tabletblQuoteOptionCharges.PercentageRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPercentageMinimumNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.PercentageMinimumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPercentageMinimumNull()
    {
      this[this.tabletblQuoteOptionCharges.PercentageMinimumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPercentOfChargeCodeNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.PercentOfChargeCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPercentOfChargeCodeNull()
    {
      this[this.tabletblQuoteOptionCharges.PercentOfChargeCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsWaivedByUserGuidNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.WaivedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetWaivedByUserGuidNull()
    {
      this[this.tabletblQuoteOptionCharges.WaivedByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsConvertedToManualUserGuidNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.ConvertedToManualUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetConvertedToManualUserGuidNull()
    {
      this[this.tabletblQuoteOptionCharges.ConvertedToManualUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAmountWithInstallmentsNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.AmountWithInstallmentsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAmountWithInstallmentsNull()
    {
      this[this.tabletblQuoteOptionCharges.AmountWithInstallmentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateAmountDueNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.DateAmountDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateAmountDueNull()
    {
      this[this.tabletblQuoteOptionCharges.DateAmountDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateFilingDueNull()
    {
      return this.IsNull(this.tabletblQuoteOptionCharges.DateFilingDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateFilingDueNull()
    {
      this[this.tabletblQuoteOptionCharges.DateFilingDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblPolicyFilingManagementInfoRow : DataRow
  {
    private dsFilingPolicyInfo.tblPolicyFilingManagementInfoDataTable tabletblPolicyFilingManagementInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblPolicyFilingManagementInfoRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblPolicyFilingManagementInfo = (dsFilingPolicyInfo.tblPolicyFilingManagementInfoDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblPolicyFilingManagementInfo.IDColumn]);
      set => this[this.tabletblPolicyFilingManagementInfo.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OptionFeeID
    {
      get => Conversions.ToInteger(this[this.tabletblPolicyFilingManagementInfo.OptionFeeIDColumn]);
      set => this[this.tabletblPolicyFilingManagementInfo.OptionFeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DSFFillDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblPolicyFilingManagementInfo.DSFFillDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DSFFillDate' in table 'tblPolicyFilingManagementInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyFilingManagementInfo.DSFFillDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DecPageFiledDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblPolicyFilingManagementInfo.DecPageFiledDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DecPageFiledDate' in table 'tblPolicyFilingManagementInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyFilingManagementInfo.DecPageFiledDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ExemptionResearch
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyFilingManagementInfo.ExemptionResearchColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExemptionResearch' in table 'tblPolicyFilingManagementInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyFilingManagementInfo.ExemptionResearchColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Notes
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyFilingManagementInfo.NotesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Notes' in table 'tblPolicyFilingManagementInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyFilingManagementInfo.NotesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime CheckRequestDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblPolicyFilingManagementInfo.CheckRequestDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CheckRequestDate' in table 'tblPolicyFilingManagementInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyFilingManagementInfo.CheckRequestDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime MonthlyReportDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblPolicyFilingManagementInfo.MonthlyReportDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MonthlyReportDue' in table 'tblPolicyFilingManagementInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyFilingManagementInfo.MonthlyReportDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime QuarterlyReportDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblPolicyFilingManagementInfo.QuarterlyReportDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuarterlyReportDue' in table 'tblPolicyFilingManagementInfo' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblPolicyFilingManagementInfo.QuarterlyReportDueColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime SemiAnnualReportDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblPolicyFilingManagementInfo.SemiAnnualReportDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SemiAnnualReportDue' in table 'tblPolicyFilingManagementInfo' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblPolicyFilingManagementInfo.SemiAnnualReportDueColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime AnnualReportDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblPolicyFilingManagementInfo.AnnualReportDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AnnualReportDue' in table 'tblPolicyFilingManagementInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyFilingManagementInfo.AnnualReportDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime FilingDone
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblPolicyFilingManagementInfo.FilingDoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FilingDone' in table 'tblPolicyFilingManagementInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyFilingManagementInfo.FilingDoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime FireTaxDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblPolicyFilingManagementInfo.FireTaxDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FireTaxDue' in table 'tblPolicyFilingManagementInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyFilingManagementInfo.FireTaxDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime RevenueSurchargeDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblPolicyFilingManagementInfo.RevenueSurchargeDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RevenueSurchargeDue' in table 'tblPolicyFilingManagementInfo' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblPolicyFilingManagementInfo.RevenueSurchargeDueColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime ControlsFiledDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblPolicyFilingManagementInfo.ControlsFiledDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ControlsFiledDate' in table 'tblPolicyFilingManagementInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyFilingManagementInfo.ControlsFiledDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime MunicipalFilingDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblPolicyFilingManagementInfo.MunicipalFilingDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MunicipalFilingDue' in table 'tblPolicyFilingManagementInfo' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblPolicyFilingManagementInfo.MunicipalFilingDueColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDSFFillDateNull()
    {
      return this.IsNull(this.tabletblPolicyFilingManagementInfo.DSFFillDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDSFFillDateNull()
    {
      this[this.tabletblPolicyFilingManagementInfo.DSFFillDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDecPageFiledDateNull()
    {
      return this.IsNull(this.tabletblPolicyFilingManagementInfo.DecPageFiledDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDecPageFiledDateNull()
    {
      this[this.tabletblPolicyFilingManagementInfo.DecPageFiledDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsExemptionResearchNull()
    {
      return this.IsNull(this.tabletblPolicyFilingManagementInfo.ExemptionResearchColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetExemptionResearchNull()
    {
      this[this.tabletblPolicyFilingManagementInfo.ExemptionResearchColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNotesNull() => this.IsNull(this.tabletblPolicyFilingManagementInfo.NotesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNotesNull()
    {
      this[this.tabletblPolicyFilingManagementInfo.NotesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCheckRequestDateNull()
    {
      return this.IsNull(this.tabletblPolicyFilingManagementInfo.CheckRequestDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCheckRequestDateNull()
    {
      this[this.tabletblPolicyFilingManagementInfo.CheckRequestDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMonthlyReportDueNull()
    {
      return this.IsNull(this.tabletblPolicyFilingManagementInfo.MonthlyReportDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMonthlyReportDueNull()
    {
      this[this.tabletblPolicyFilingManagementInfo.MonthlyReportDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsQuarterlyReportDueNull()
    {
      return this.IsNull(this.tabletblPolicyFilingManagementInfo.QuarterlyReportDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetQuarterlyReportDueNull()
    {
      this[this.tabletblPolicyFilingManagementInfo.QuarterlyReportDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSemiAnnualReportDueNull()
    {
      return this.IsNull(this.tabletblPolicyFilingManagementInfo.SemiAnnualReportDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSemiAnnualReportDueNull()
    {
      this[this.tabletblPolicyFilingManagementInfo.SemiAnnualReportDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAnnualReportDueNull()
    {
      return this.IsNull(this.tabletblPolicyFilingManagementInfo.AnnualReportDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAnnualReportDueNull()
    {
      this[this.tabletblPolicyFilingManagementInfo.AnnualReportDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFilingDoneNull()
    {
      return this.IsNull(this.tabletblPolicyFilingManagementInfo.FilingDoneColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFilingDoneNull()
    {
      this[this.tabletblPolicyFilingManagementInfo.FilingDoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFireTaxDueNull()
    {
      return this.IsNull(this.tabletblPolicyFilingManagementInfo.FireTaxDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFireTaxDueNull()
    {
      this[this.tabletblPolicyFilingManagementInfo.FireTaxDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRevenueSurchargeDueNull()
    {
      return this.IsNull(this.tabletblPolicyFilingManagementInfo.RevenueSurchargeDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRevenueSurchargeDueNull()
    {
      this[this.tabletblPolicyFilingManagementInfo.RevenueSurchargeDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsControlsFiledDateNull()
    {
      return this.IsNull(this.tabletblPolicyFilingManagementInfo.ControlsFiledDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetControlsFiledDateNull()
    {
      this[this.tabletblPolicyFilingManagementInfo.ControlsFiledDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMunicipalFilingDueNull()
    {
      return this.IsNull(this.tabletblPolicyFilingManagementInfo.MunicipalFilingDueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMunicipalFilingDueNull()
    {
      this[this.tabletblPolicyFilingManagementInfo.MunicipalFilingDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblStatesSLRequiredDataRow : DataRow
  {
    private dsFilingPolicyInfo.tblStatesSLRequiredDataDataTable tabletblStatesSLRequiredData;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblStatesSLRequiredDataRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblStatesSLRequiredData = (dsFilingPolicyInfo.tblStatesSLRequiredDataDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int RequiredDataID
    {
      get => Conversions.ToInteger(this[this.tabletblStatesSLRequiredData.RequiredDataIDColumn]);
      set => this[this.tabletblStatesSLRequiredData.RequiredDataIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string RequiredData
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblStatesSLRequiredData.RequiredDataColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RequiredData' in table 'tblStatesSLRequiredData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblStatesSLRequiredData.RequiredDataColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRequiredDataNull()
    {
      return this.IsNull(this.tabletblStatesSLRequiredData.RequiredDataColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRequiredDataNull()
    {
      this[this.tabletblStatesSLRequiredData.RequiredDataColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblStatesSLRequiredData_InfoRow : DataRow
  {
    private dsFilingPolicyInfo.tblStatesSLRequiredData_InfoDataTable tabletblStatesSLRequiredData_Info;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblStatesSLRequiredData_InfoRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblStatesSLRequiredData_Info = (dsFilingPolicyInfo.tblStatesSLRequiredData_InfoDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tabletblStatesSLRequiredData_Info.StateIDColumn]);
      set => this[this.tabletblStatesSLRequiredData_Info.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int RequiredDataID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblStatesSLRequiredData_Info.RequiredDataIDColumn]);
      }
      set => this[this.tabletblStatesSLRequiredData_Info.RequiredDataIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool UseForFiling
    {
      get => Conversions.ToBoolean(this[this.tabletblStatesSLRequiredData_Info.UseForFilingColumn]);
      set => this[this.tabletblStatesSLRequiredData_Info.UseForFilingColumn] = (object) value;
    }
  }

  public class tblClientOfficesRow : DataRow
  {
    private dsFilingPolicyInfo.tblClientOfficesDataTable tabletblClientOffices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblClientOfficesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClientOffices = (dsFilingPolicyInfo.tblClientOfficesDataTable) this.Table;
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
  }

  public class tblStateSLRulesRow : DataRow
  {
    private dsFilingPolicyInfo.tblStateSLRulesDataTable tabletblStateSLRules;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblStateSLRulesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblStateSLRules = (dsFilingPolicyInfo.tblStateSLRulesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tabletblStateSLRules.StateIDColumn]);
      set => this[this.tabletblStateSLRules.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string OtherInfo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblStateSLRules.OtherInfoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OtherInfo' in table 'tblStateSLRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblStateSLRules.OtherInfoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblStateSLRules.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'tblStateSLRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblStateSLRules.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOtherInfoNull() => this.IsNull(this.tabletblStateSLRules.OtherInfoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOtherInfoNull()
    {
      this[this.tabletblStateSLRules.OtherInfoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tabletblStateSLRules.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tabletblStateSLRules.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class PolicyFilingInformationRowChangeEvent : EventArgs
  {
    private dsFilingPolicyInfo.PolicyFilingInformationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public PolicyFilingInformationRowChangeEvent(
      dsFilingPolicyInfo.PolicyFilingInformationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.PolicyFilingInformationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstStatesRowChangeEvent : EventArgs
  {
    private dsFilingPolicyInfo.lstStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstStatesRowChangeEvent(dsFilingPolicyInfo.lstStatesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.lstStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblFin_PolicyChargesRowChangeEvent : EventArgs
  {
    private dsFilingPolicyInfo.tblFin_PolicyChargesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblFin_PolicyChargesRowChangeEvent(
      dsFilingPolicyInfo.tblFin_PolicyChargesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblFin_PolicyChargesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblQuoteOptionChargesRowChangeEvent : EventArgs
  {
    private dsFilingPolicyInfo.tblQuoteOptionChargesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuoteOptionChargesRowChangeEvent(
      dsFilingPolicyInfo.tblQuoteOptionChargesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblQuoteOptionChargesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblPolicyFilingManagementInfoRowChangeEvent : EventArgs
  {
    private dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblPolicyFilingManagementInfoRowChangeEvent(
      dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblStatesSLRequiredDataRowChangeEvent : EventArgs
  {
    private dsFilingPolicyInfo.tblStatesSLRequiredDataRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblStatesSLRequiredDataRowChangeEvent(
      dsFilingPolicyInfo.tblStatesSLRequiredDataRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblStatesSLRequiredDataRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblStatesSLRequiredData_InfoRowChangeEvent : EventArgs
  {
    private dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblStatesSLRequiredData_InfoRowChangeEvent(
      dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblClientOfficesRowChangeEvent : EventArgs
  {
    private dsFilingPolicyInfo.tblClientOfficesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblClientOfficesRowChangeEvent(
      dsFilingPolicyInfo.tblClientOfficesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblClientOfficesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblStateSLRulesRowChangeEvent : EventArgs
  {
    private dsFilingPolicyInfo.tblStateSLRulesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblStateSLRulesRowChangeEvent(
      dsFilingPolicyInfo.tblStateSLRulesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsFilingPolicyInfo.tblStateSLRulesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
