// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyNumbering.dsPolicyNumberAdmin
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
namespace MGASystems.IMS.Policies.PolicyNumbering;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPolicyNumberAdmin")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPolicyNumberAdmin : DataSet
{
  private dsPolicyNumberAdmin.tblPolicyNumberRulesDataTable tabletblPolicyNumberRules;
  private dsPolicyNumberAdmin.tblUsersDataTable tabletblUsers;
  private dsPolicyNumberAdmin.tblCompanyProgramCodesDataTable tabletblCompanyProgramCodes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsPolicyNumberAdmin()
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
  protected dsPolicyNumberAdmin(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblPolicyNumberRules)] != null)
          base.Tables.Add((DataTable) new dsPolicyNumberAdmin.tblPolicyNumberRulesDataTable(dataSet.Tables[nameof (tblPolicyNumberRules)]));
        if (dataSet.Tables[nameof (tblUsers)] != null)
          base.Tables.Add((DataTable) new dsPolicyNumberAdmin.tblUsersDataTable(dataSet.Tables[nameof (tblUsers)]));
        if (dataSet.Tables[nameof (tblCompanyProgramCodes)] != null)
          base.Tables.Add((DataTable) new dsPolicyNumberAdmin.tblCompanyProgramCodesDataTable(dataSet.Tables[nameof (tblCompanyProgramCodes)]));
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
  public dsPolicyNumberAdmin.tblPolicyNumberRulesDataTable tblPolicyNumberRules
  {
    get => this.tabletblPolicyNumberRules;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyNumberAdmin.tblUsersDataTable tblUsers => this.tabletblUsers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyNumberAdmin.tblCompanyProgramCodesDataTable tblCompanyProgramCodes
  {
    get => this.tabletblCompanyProgramCodes;
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
    dsPolicyNumberAdmin policyNumberAdmin = (dsPolicyNumberAdmin) base.Clone();
    policyNumberAdmin.InitVars();
    policyNumberAdmin.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) policyNumberAdmin;
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
      if (dataSet.Tables["tblPolicyNumberRules"] != null)
        base.Tables.Add((DataTable) new dsPolicyNumberAdmin.tblPolicyNumberRulesDataTable(dataSet.Tables["tblPolicyNumberRules"]));
      if (dataSet.Tables["tblUsers"] != null)
        base.Tables.Add((DataTable) new dsPolicyNumberAdmin.tblUsersDataTable(dataSet.Tables["tblUsers"]));
      if (dataSet.Tables["tblCompanyProgramCodes"] != null)
        base.Tables.Add((DataTable) new dsPolicyNumberAdmin.tblCompanyProgramCodesDataTable(dataSet.Tables["tblCompanyProgramCodes"]));
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
    this.tabletblPolicyNumberRules = (dsPolicyNumberAdmin.tblPolicyNumberRulesDataTable) base.Tables["tblPolicyNumberRules"];
    if (initTable && this.tabletblPolicyNumberRules != null)
      this.tabletblPolicyNumberRules.InitVars();
    this.tabletblUsers = (dsPolicyNumberAdmin.tblUsersDataTable) base.Tables["tblUsers"];
    if (initTable && this.tabletblUsers != null)
      this.tabletblUsers.InitVars();
    this.tabletblCompanyProgramCodes = (dsPolicyNumberAdmin.tblCompanyProgramCodesDataTable) base.Tables["tblCompanyProgramCodes"];
    if (!initTable || this.tabletblCompanyProgramCodes == null)
      return;
    this.tabletblCompanyProgramCodes.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPolicyNumberAdmin);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsPolicyNumberAdmin.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblPolicyNumberRules = new dsPolicyNumberAdmin.tblPolicyNumberRulesDataTable();
    base.Tables.Add((DataTable) this.tabletblPolicyNumberRules);
    this.tabletblUsers = new dsPolicyNumberAdmin.tblUsersDataTable();
    base.Tables.Add((DataTable) this.tabletblUsers);
    this.tabletblCompanyProgramCodes = new dsPolicyNumberAdmin.tblCompanyProgramCodesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyProgramCodes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblPolicyNumberRules() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblUsers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyProgramCodes() => false;

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
    dsPolicyNumberAdmin policyNumberAdmin = new dsPolicyNumberAdmin();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = policyNumberAdmin.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = policyNumberAdmin.GetSchemaSerializable();
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
  public delegate void tblPolicyNumberRulesRowChangeEventHandler(
    object sender,
    dsPolicyNumberAdmin.tblPolicyNumberRulesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblUsersRowChangeEventHandler(
    object sender,
    dsPolicyNumberAdmin.tblUsersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyProgramCodesRowChangeEventHandler(
    object sender,
    dsPolicyNumberAdmin.tblCompanyProgramCodesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblPolicyNumberRulesDataTable : 
    TypedTableBase<dsPolicyNumberAdmin.tblPolicyNumberRulesRow>
  {
    private DataColumn columnRuleID;
    private DataColumn columnRuleName;
    private DataColumn columnPrefix;
    private DataColumn columnBlockStart;
    private DataColumn columnBlockEnd;
    private DataColumn columnTotalBlockDigits;
    private DataColumn columnWarnLowBlockCount;
    private DataColumn columnWarnUser;
    private DataColumn columnNewNumberOnRenewal;
    private DataColumn columnSequentialStart;
    private DataColumn columnSequentialTotalDigits;
    private DataColumn columnYearSuffix;
    private DataColumn columnFixedvalue;
    private DataColumn columnSuffixDash;
    private DataColumn columnManual;
    private DataColumn columnSuffixSeparateSpace;
    private DataColumn columnNetrateSunset1Prefix;
    private DataColumn columnNetrateSunset2Prefix;
    private DataColumn columnNetrateSunset3Prefix;
    private DataColumn columnNetrateClaimsMadePrefix;
    private DataColumn columnRunoff;
    private DataColumn columnAlphaSuffix;
    private DataColumn columnAlphaSuffixRenewalOnly;
    private DataColumn columnBasedOnEffectiveDate;
    private DataColumn columnManualNumberOnPurchasedBook;
    private DataColumn columnManualNumberOnRenewal;
    private DataColumn columnUseTableBasedNumbering;
    private DataColumn columnUsePolicyNumberingFromRuleId;
    private DataColumn columnForceCheckOnRenewal;
    private DataColumn columnNextNumber;
    private DataColumn columnUseSubmissionGroupNumbering;
    private DataColumn columnPromptForManualOverride;
    private DataColumn columnFourYearSuffix;
    private DataColumn columnPolicyNumberSuffix;
    private DataColumn columnAppendTwoDigitYear;
    private DataColumn columnAppendFourDigitYear;
    private DataColumn columnAppendPrefix;
    private DataColumn columnProgCode;
    private DataColumn columnTwoYearSuffixSeq;
    private DataColumn columnFourYearSuffixSeq;
    private DataColumn columnYearSuffixSequentialStart;
    private DataColumn columnYearSuffixSequentialTotalDigits;
    private DataColumn columnUseRenewalDigitYear;
    private DataColumn columnUseInsuredNumber;
    private DataColumn columnManualMask;
    private DataColumn columnUseStoredProc;
    private DataColumn columnNumericalSuffixRenewalOnly;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblPolicyNumberRulesDataTable()
    {
      this.TableName = "tblPolicyNumberRules";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblPolicyNumberRulesDataTable(DataTable table)
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
    protected tblPolicyNumberRulesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RuleIDColumn => this.columnRuleID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RuleNameColumn => this.columnRuleName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PrefixColumn => this.columnPrefix;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BlockStartColumn => this.columnBlockStart;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BlockEndColumn => this.columnBlockEnd;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TotalBlockDigitsColumn => this.columnTotalBlockDigits;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WarnLowBlockCountColumn => this.columnWarnLowBlockCount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WarnUserColumn => this.columnWarnUser;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NewNumberOnRenewalColumn => this.columnNewNumberOnRenewal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SequentialStartColumn => this.columnSequentialStart;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SequentialTotalDigitsColumn => this.columnSequentialTotalDigits;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn YearSuffixColumn => this.columnYearSuffix;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FixedvalueColumn => this.columnFixedvalue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SuffixDashColumn => this.columnSuffixDash;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ManualColumn => this.columnManual;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SuffixSeparateSpaceColumn => this.columnSuffixSeparateSpace;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NetrateSunset1PrefixColumn => this.columnNetrateSunset1Prefix;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NetrateSunset2PrefixColumn => this.columnNetrateSunset2Prefix;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NetrateSunset3PrefixColumn => this.columnNetrateSunset3Prefix;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NetrateClaimsMadePrefixColumn => this.columnNetrateClaimsMadePrefix;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RunoffColumn => this.columnRunoff;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AlphaSuffixColumn => this.columnAlphaSuffix;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AlphaSuffixRenewalOnlyColumn => this.columnAlphaSuffixRenewalOnly;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BasedOnEffectiveDateColumn => this.columnBasedOnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ManualNumberOnPurchasedBookColumn => this.columnManualNumberOnPurchasedBook;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ManualNumberOnRenewalColumn => this.columnManualNumberOnRenewal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UseTableBasedNumberingColumn => this.columnUseTableBasedNumbering;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UsePolicyNumberingFromRuleIdColumn => this.columnUsePolicyNumberingFromRuleId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ForceCheckOnRenewalColumn => this.columnForceCheckOnRenewal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NextNumberColumn => this.columnNextNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UseSubmissionGroupNumberingColumn => this.columnUseSubmissionGroupNumbering;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PromptForManualOverrideColumn => this.columnPromptForManualOverride;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FourYearSuffixColumn => this.columnFourYearSuffix;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyNumberSuffixColumn => this.columnPolicyNumberSuffix;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AppendTwoDigitYearColumn => this.columnAppendTwoDigitYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AppendFourDigitYearColumn => this.columnAppendFourDigitYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AppendPrefixColumn => this.columnAppendPrefix;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProgCodeColumn => this.columnProgCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TwoYearSuffixSeqColumn => this.columnTwoYearSuffixSeq;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FourYearSuffixSeqColumn => this.columnFourYearSuffixSeq;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn YearSuffixSequentialStartColumn => this.columnYearSuffixSequentialStart;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn YearSuffixSequentialTotalDigitsColumn
    {
      get => this.columnYearSuffixSequentialTotalDigits;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UseRenewalDigitYearColumn => this.columnUseRenewalDigitYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UseInsuredNumberColumn => this.columnUseInsuredNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ManualMaskColumn => this.columnManualMask;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UseStoredProcColumn => this.columnUseStoredProc;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NumericalSuffixRenewalOnlyColumn => this.columnNumericalSuffixRenewalOnly;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyNumberAdmin.tblPolicyNumberRulesRow this[int index]
    {
      get => (dsPolicyNumberAdmin.tblPolicyNumberRulesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyNumberAdmin.tblPolicyNumberRulesRowChangeEventHandler tblPolicyNumberRulesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyNumberAdmin.tblPolicyNumberRulesRowChangeEventHandler tblPolicyNumberRulesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyNumberAdmin.tblPolicyNumberRulesRowChangeEventHandler tblPolicyNumberRulesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyNumberAdmin.tblPolicyNumberRulesRowChangeEventHandler tblPolicyNumberRulesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblPolicyNumberRulesRow(dsPolicyNumberAdmin.tblPolicyNumberRulesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyNumberAdmin.tblPolicyNumberRulesRow AddtblPolicyNumberRulesRow(
      string RuleName,
      string Prefix,
      int BlockStart,
      int BlockEnd,
      int TotalBlockDigits,
      int WarnLowBlockCount,
      Guid WarnUser,
      bool NewNumberOnRenewal,
      int SequentialStart,
      int SequentialTotalDigits,
      bool YearSuffix,
      string Fixedvalue,
      bool SuffixDash,
      bool Manual,
      bool SuffixSeparateSpace,
      string NetrateSunset1Prefix,
      string NetrateSunset2Prefix,
      string NetrateSunset3Prefix,
      string NetrateClaimsMadePrefix,
      bool Runoff,
      bool AlphaSuffix,
      bool AlphaSuffixRenewalOnly,
      bool BasedOnEffectiveDate,
      bool ManualNumberOnPurchasedBook,
      bool ManualNumberOnRenewal,
      bool UseTableBasedNumbering,
      int UsePolicyNumberingFromRuleId,
      bool ForceCheckOnRenewal,
      string NextNumber,
      bool UseSubmissionGroupNumbering,
      bool PromptForManualOverride,
      bool FourYearSuffix,
      string PolicyNumberSuffix,
      bool AppendTwoDigitYear,
      bool AppendFourDigitYear,
      string AppendPrefix,
      string ProgCode,
      bool TwoYearSuffixSeq,
      bool FourYearSuffixSeq,
      int YearSuffixSequentialStart,
      int YearSuffixSequentialTotalDigits,
      bool UseRenewalDigitYear,
      bool UseInsuredNumber,
      string ManualMask,
      bool UseStoredProc,
      bool NumericalSuffixRenewalOnly)
    {
      dsPolicyNumberAdmin.tblPolicyNumberRulesRow row = (dsPolicyNumberAdmin.tblPolicyNumberRulesRow) this.NewRow();
      object[] objArray = new object[47]
      {
        null,
        (object) RuleName,
        (object) Prefix,
        (object) BlockStart,
        (object) BlockEnd,
        (object) TotalBlockDigits,
        (object) WarnLowBlockCount,
        (object) WarnUser,
        (object) NewNumberOnRenewal,
        (object) SequentialStart,
        (object) SequentialTotalDigits,
        (object) YearSuffix,
        (object) Fixedvalue,
        (object) SuffixDash,
        (object) Manual,
        (object) SuffixSeparateSpace,
        (object) NetrateSunset1Prefix,
        (object) NetrateSunset2Prefix,
        (object) NetrateSunset3Prefix,
        (object) NetrateClaimsMadePrefix,
        (object) Runoff,
        (object) AlphaSuffix,
        (object) AlphaSuffixRenewalOnly,
        (object) BasedOnEffectiveDate,
        (object) ManualNumberOnPurchasedBook,
        (object) ManualNumberOnRenewal,
        (object) UseTableBasedNumbering,
        (object) UsePolicyNumberingFromRuleId,
        (object) ForceCheckOnRenewal,
        (object) NextNumber,
        (object) UseSubmissionGroupNumbering,
        (object) PromptForManualOverride,
        (object) FourYearSuffix,
        (object) PolicyNumberSuffix,
        (object) AppendTwoDigitYear,
        (object) AppendFourDigitYear,
        (object) AppendPrefix,
        (object) ProgCode,
        (object) TwoYearSuffixSeq,
        (object) FourYearSuffixSeq,
        (object) YearSuffixSequentialStart,
        (object) YearSuffixSequentialTotalDigits,
        (object) UseRenewalDigitYear,
        (object) UseInsuredNumber,
        (object) ManualMask,
        (object) UseStoredProc,
        (object) NumericalSuffixRenewalOnly
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyNumberAdmin.tblPolicyNumberRulesRow FindByRuleID(int RuleID)
    {
      return (dsPolicyNumberAdmin.tblPolicyNumberRulesRow) this.Rows.Find(new object[1]
      {
        (object) RuleID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyNumberAdmin.tblPolicyNumberRulesDataTable numberRulesDataTable = (dsPolicyNumberAdmin.tblPolicyNumberRulesDataTable) base.Clone();
      numberRulesDataTable.InitVars();
      return (DataTable) numberRulesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyNumberAdmin.tblPolicyNumberRulesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnRuleID = this.Columns["RuleID"];
      this.columnRuleName = this.Columns["RuleName"];
      this.columnPrefix = this.Columns["Prefix"];
      this.columnBlockStart = this.Columns["BlockStart"];
      this.columnBlockEnd = this.Columns["BlockEnd"];
      this.columnTotalBlockDigits = this.Columns["TotalBlockDigits"];
      this.columnWarnLowBlockCount = this.Columns["WarnLowBlockCount"];
      this.columnWarnUser = this.Columns["WarnUser"];
      this.columnNewNumberOnRenewal = this.Columns["NewNumberOnRenewal"];
      this.columnSequentialStart = this.Columns["SequentialStart"];
      this.columnSequentialTotalDigits = this.Columns["SequentialTotalDigits"];
      this.columnYearSuffix = this.Columns["YearSuffix"];
      this.columnFixedvalue = this.Columns["Fixedvalue"];
      this.columnSuffixDash = this.Columns["SuffixDash"];
      this.columnManual = this.Columns["Manual"];
      this.columnSuffixSeparateSpace = this.Columns["SuffixSeparateSpace"];
      this.columnNetrateSunset1Prefix = this.Columns["NetrateSunset1Prefix"];
      this.columnNetrateSunset2Prefix = this.Columns["NetrateSunset2Prefix"];
      this.columnNetrateSunset3Prefix = this.Columns["NetrateSunset3Prefix"];
      this.columnNetrateClaimsMadePrefix = this.Columns["NetrateClaimsMadePrefix"];
      this.columnRunoff = this.Columns["Runoff"];
      this.columnAlphaSuffix = this.Columns["AlphaSuffix"];
      this.columnAlphaSuffixRenewalOnly = this.Columns["AlphaSuffixRenewalOnly"];
      this.columnBasedOnEffectiveDate = this.Columns["BasedOnEffectiveDate"];
      this.columnManualNumberOnPurchasedBook = this.Columns["ManualNumberOnPurchasedBook"];
      this.columnManualNumberOnRenewal = this.Columns["ManualNumberOnRenewal"];
      this.columnUseTableBasedNumbering = this.Columns["UseTableBasedNumbering"];
      this.columnUsePolicyNumberingFromRuleId = this.Columns["UsePolicyNumberingFromRuleId"];
      this.columnForceCheckOnRenewal = this.Columns["ForceCheckOnRenewal"];
      this.columnNextNumber = this.Columns["NextNumber"];
      this.columnUseSubmissionGroupNumbering = this.Columns["UseSubmissionGroupNumbering"];
      this.columnPromptForManualOverride = this.Columns["PromptForManualOverride"];
      this.columnFourYearSuffix = this.Columns["FourYearSuffix"];
      this.columnPolicyNumberSuffix = this.Columns["PolicyNumberSuffix"];
      this.columnAppendTwoDigitYear = this.Columns["AppendTwoDigitYear"];
      this.columnAppendFourDigitYear = this.Columns["AppendFourDigitYear"];
      this.columnAppendPrefix = this.Columns["AppendPrefix"];
      this.columnProgCode = this.Columns["ProgCode"];
      this.columnTwoYearSuffixSeq = this.Columns["TwoYearSuffixSeq"];
      this.columnFourYearSuffixSeq = this.Columns["FourYearSuffixSeq"];
      this.columnYearSuffixSequentialStart = this.Columns["YearSuffixSequentialStart"];
      this.columnYearSuffixSequentialTotalDigits = this.Columns["YearSuffixSequentialTotalDigits"];
      this.columnUseRenewalDigitYear = this.Columns["UseRenewalDigitYear"];
      this.columnUseInsuredNumber = this.Columns["UseInsuredNumber"];
      this.columnManualMask = this.Columns["ManualMask"];
      this.columnUseStoredProc = this.Columns["UseStoredProc"];
      this.columnNumericalSuffixRenewalOnly = this.Columns["NumericalSuffixRenewalOnly"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnRuleID = new DataColumn("RuleID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRuleID);
      this.columnRuleName = new DataColumn("RuleName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRuleName);
      this.columnPrefix = new DataColumn("Prefix", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPrefix);
      this.columnBlockStart = new DataColumn("BlockStart", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBlockStart);
      this.columnBlockEnd = new DataColumn("BlockEnd", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBlockEnd);
      this.columnTotalBlockDigits = new DataColumn("TotalBlockDigits", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalBlockDigits);
      this.columnWarnLowBlockCount = new DataColumn("WarnLowBlockCount", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWarnLowBlockCount);
      this.columnWarnUser = new DataColumn("WarnUser", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWarnUser);
      this.columnNewNumberOnRenewal = new DataColumn("NewNumberOnRenewal", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNewNumberOnRenewal);
      this.columnSequentialStart = new DataColumn("SequentialStart", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSequentialStart);
      this.columnSequentialTotalDigits = new DataColumn("SequentialTotalDigits", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSequentialTotalDigits);
      this.columnYearSuffix = new DataColumn("YearSuffix", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYearSuffix);
      this.columnFixedvalue = new DataColumn("Fixedvalue", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFixedvalue);
      this.columnSuffixDash = new DataColumn("SuffixDash", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSuffixDash);
      this.columnManual = new DataColumn("Manual", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnManual);
      this.columnSuffixSeparateSpace = new DataColumn("SuffixSeparateSpace", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSuffixSeparateSpace);
      this.columnNetrateSunset1Prefix = new DataColumn("NetrateSunset1Prefix", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetrateSunset1Prefix);
      this.columnNetrateSunset2Prefix = new DataColumn("NetrateSunset2Prefix", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetrateSunset2Prefix);
      this.columnNetrateSunset3Prefix = new DataColumn("NetrateSunset3Prefix", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetrateSunset3Prefix);
      this.columnNetrateClaimsMadePrefix = new DataColumn("NetrateClaimsMadePrefix", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetrateClaimsMadePrefix);
      this.columnRunoff = new DataColumn("Runoff", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRunoff);
      this.columnAlphaSuffix = new DataColumn("AlphaSuffix", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAlphaSuffix);
      this.columnAlphaSuffixRenewalOnly = new DataColumn("AlphaSuffixRenewalOnly", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAlphaSuffixRenewalOnly);
      this.columnBasedOnEffectiveDate = new DataColumn("BasedOnEffectiveDate", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBasedOnEffectiveDate);
      this.columnManualNumberOnPurchasedBook = new DataColumn("ManualNumberOnPurchasedBook", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnManualNumberOnPurchasedBook);
      this.columnManualNumberOnRenewal = new DataColumn("ManualNumberOnRenewal", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnManualNumberOnRenewal);
      this.columnUseTableBasedNumbering = new DataColumn("UseTableBasedNumbering", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUseTableBasedNumbering);
      this.columnUsePolicyNumberingFromRuleId = new DataColumn("UsePolicyNumberingFromRuleId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUsePolicyNumberingFromRuleId);
      this.columnForceCheckOnRenewal = new DataColumn("ForceCheckOnRenewal", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnForceCheckOnRenewal);
      this.columnNextNumber = new DataColumn("NextNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNextNumber);
      this.columnUseSubmissionGroupNumbering = new DataColumn("UseSubmissionGroupNumbering", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUseSubmissionGroupNumbering);
      this.columnPromptForManualOverride = new DataColumn("PromptForManualOverride", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPromptForManualOverride);
      this.columnFourYearSuffix = new DataColumn("FourYearSuffix", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFourYearSuffix);
      this.columnPolicyNumberSuffix = new DataColumn("PolicyNumberSuffix", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumberSuffix);
      this.columnAppendTwoDigitYear = new DataColumn("AppendTwoDigitYear", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAppendTwoDigitYear);
      this.columnAppendFourDigitYear = new DataColumn("AppendFourDigitYear", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAppendFourDigitYear);
      this.columnAppendPrefix = new DataColumn("AppendPrefix", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAppendPrefix);
      this.columnProgCode = new DataColumn("ProgCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgCode);
      this.columnTwoYearSuffixSeq = new DataColumn("TwoYearSuffixSeq", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTwoYearSuffixSeq);
      this.columnFourYearSuffixSeq = new DataColumn("FourYearSuffixSeq", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFourYearSuffixSeq);
      this.columnYearSuffixSequentialStart = new DataColumn("YearSuffixSequentialStart", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYearSuffixSequentialStart);
      this.columnYearSuffixSequentialTotalDigits = new DataColumn("YearSuffixSequentialTotalDigits", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYearSuffixSequentialTotalDigits);
      this.columnUseRenewalDigitYear = new DataColumn("UseRenewalDigitYear", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUseRenewalDigitYear);
      this.columnUseInsuredNumber = new DataColumn("UseInsuredNumber", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUseInsuredNumber);
      this.columnManualMask = new DataColumn("ManualMask", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnManualMask);
      this.columnUseStoredProc = new DataColumn("UseStoredProc", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUseStoredProc);
      this.columnNumericalSuffixRenewalOnly = new DataColumn("NumericalSuffixRenewalOnly", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumericalSuffixRenewalOnly);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyNumberAdminKey1", new DataColumn[1]
      {
        this.columnRuleID
      }, true));
      this.columnRuleID.AutoIncrement = true;
      this.columnRuleID.AllowDBNull = false;
      this.columnRuleID.ReadOnly = true;
      this.columnRuleID.Unique = true;
      this.columnRuleName.MaxLength = 1000;
      this.columnNewNumberOnRenewal.AllowDBNull = false;
      this.columnNewNumberOnRenewal.DefaultValue = (object) false;
      this.columnYearSuffix.DefaultValue = (object) false;
      this.columnSuffixDash.DefaultValue = (object) false;
      this.columnManual.AllowDBNull = false;
      this.columnManual.DefaultValue = (object) false;
      this.columnSuffixSeparateSpace.DefaultValue = (object) false;
      this.columnRunoff.AllowDBNull = false;
      this.columnRunoff.DefaultValue = (object) false;
      this.columnAlphaSuffix.DefaultValue = (object) false;
      this.columnBasedOnEffectiveDate.DefaultValue = (object) false;
      this.columnManualNumberOnPurchasedBook.AllowDBNull = false;
      this.columnManualNumberOnPurchasedBook.DefaultValue = (object) false;
      this.columnManualNumberOnRenewal.AllowDBNull = false;
      this.columnManualNumberOnRenewal.DefaultValue = (object) false;
      this.columnUseTableBasedNumbering.AllowDBNull = false;
      this.columnUseTableBasedNumbering.DefaultValue = (object) false;
      this.columnUseSubmissionGroupNumbering.DefaultValue = (object) false;
      this.columnFourYearSuffix.DefaultValue = (object) false;
      this.columnAppendTwoDigitYear.DefaultValue = (object) false;
      this.columnAppendFourDigitYear.DefaultValue = (object) false;
      this.columnTwoYearSuffixSeq.DefaultValue = (object) false;
      this.columnFourYearSuffixSeq.DefaultValue = (object) false;
      this.columnUseRenewalDigitYear.DefaultValue = (object) false;
      this.columnUseStoredProc.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyNumberAdmin.tblPolicyNumberRulesRow NewtblPolicyNumberRulesRow()
    {
      return (dsPolicyNumberAdmin.tblPolicyNumberRulesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyNumberAdmin.tblPolicyNumberRulesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyNumberAdmin.tblPolicyNumberRulesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyNumberRulesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyNumberAdmin.tblPolicyNumberRulesRowChangeEventHandler rulesRowChangedEvent = this.tblPolicyNumberRulesRowChangedEvent;
      if (rulesRowChangedEvent == null)
        return;
      rulesRowChangedEvent((object) this, new dsPolicyNumberAdmin.tblPolicyNumberRulesRowChangeEvent((dsPolicyNumberAdmin.tblPolicyNumberRulesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyNumberRulesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyNumberAdmin.tblPolicyNumberRulesRowChangeEventHandler rowChangingEvent = this.tblPolicyNumberRulesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyNumberAdmin.tblPolicyNumberRulesRowChangeEvent((dsPolicyNumberAdmin.tblPolicyNumberRulesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyNumberRulesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyNumberAdmin.tblPolicyNumberRulesRowChangeEventHandler rulesRowDeletedEvent = this.tblPolicyNumberRulesRowDeletedEvent;
      if (rulesRowDeletedEvent == null)
        return;
      rulesRowDeletedEvent((object) this, new dsPolicyNumberAdmin.tblPolicyNumberRulesRowChangeEvent((dsPolicyNumberAdmin.tblPolicyNumberRulesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyNumberRulesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyNumberAdmin.tblPolicyNumberRulesRowChangeEventHandler rowDeletingEvent = this.tblPolicyNumberRulesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyNumberAdmin.tblPolicyNumberRulesRowChangeEvent((dsPolicyNumberAdmin.tblPolicyNumberRulesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblPolicyNumberRulesRow(dsPolicyNumberAdmin.tblPolicyNumberRulesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyNumberAdmin policyNumberAdmin = new dsPolicyNumberAdmin();
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
        FixedValue = policyNumberAdmin.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblPolicyNumberRulesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyNumberAdmin.GetSchemaSerializable();
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
  public class tblUsersDataTable : TypedTableBase<dsPolicyNumberAdmin.tblUsersRow>
  {
    private DataColumn columnUserGUID;
    private DataColumn columnUserName;

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
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyNumberAdmin.tblUsersRow this[int index]
    {
      get => (dsPolicyNumberAdmin.tblUsersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyNumberAdmin.tblUsersRowChangeEventHandler tblUsersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyNumberAdmin.tblUsersRowChangeEventHandler tblUsersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyNumberAdmin.tblUsersRowChangeEventHandler tblUsersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyNumberAdmin.tblUsersRowChangeEventHandler tblUsersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblUsersRow(dsPolicyNumberAdmin.tblUsersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyNumberAdmin.tblUsersRow AddtblUsersRow(Guid UserGUID, string UserName)
    {
      dsPolicyNumberAdmin.tblUsersRow row = (dsPolicyNumberAdmin.tblUsersRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) UserGUID,
        (object) UserName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyNumberAdmin.tblUsersRow FindByUserGUID(Guid UserGUID)
    {
      return (dsPolicyNumberAdmin.tblUsersRow) this.Rows.Find(new object[1]
      {
        (object) UserGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyNumberAdmin.tblUsersDataTable tblUsersDataTable = (dsPolicyNumberAdmin.tblUsersDataTable) base.Clone();
      tblUsersDataTable.InitVars();
      return (DataTable) tblUsersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyNumberAdmin.tblUsersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnUserGUID = this.Columns["UserGUID"];
      this.columnUserName = this.Columns["UserName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnUserGUID = new DataColumn("UserGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUID);
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyNumberAdminKey2", new DataColumn[1]
      {
        this.columnUserGUID
      }, true));
      this.columnUserGUID.AllowDBNull = false;
      this.columnUserGUID.Unique = true;
      this.columnUserName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyNumberAdmin.tblUsersRow NewtblUsersRow()
    {
      return (dsPolicyNumberAdmin.tblUsersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyNumberAdmin.tblUsersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyNumberAdmin.tblUsersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyNumberAdmin.tblUsersRowChangeEventHandler usersRowChangedEvent = this.tblUsersRowChangedEvent;
      if (usersRowChangedEvent == null)
        return;
      usersRowChangedEvent((object) this, new dsPolicyNumberAdmin.tblUsersRowChangeEvent((dsPolicyNumberAdmin.tblUsersRow) e.Row, e.Action));
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
      dsPolicyNumberAdmin.tblUsersRowChangeEventHandler rowChangingEvent = this.tblUsersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyNumberAdmin.tblUsersRowChangeEvent((dsPolicyNumberAdmin.tblUsersRow) e.Row, e.Action));
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
      dsPolicyNumberAdmin.tblUsersRowChangeEventHandler usersRowDeletedEvent = this.tblUsersRowDeletedEvent;
      if (usersRowDeletedEvent == null)
        return;
      usersRowDeletedEvent((object) this, new dsPolicyNumberAdmin.tblUsersRowChangeEvent((dsPolicyNumberAdmin.tblUsersRow) e.Row, e.Action));
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
      dsPolicyNumberAdmin.tblUsersRowChangeEventHandler rowDeletingEvent = this.tblUsersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyNumberAdmin.tblUsersRowChangeEvent((dsPolicyNumberAdmin.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblUsersRow(dsPolicyNumberAdmin.tblUsersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyNumberAdmin policyNumberAdmin = new dsPolicyNumberAdmin();
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
        FixedValue = policyNumberAdmin.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUsersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyNumberAdmin.GetSchemaSerializable();
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
    TypedTableBase<dsPolicyNumberAdmin.tblCompanyProgramCodesRow>
  {
    private DataColumn columnProgCode;

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
    public DataColumn ProgCodeColumn => this.columnProgCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyNumberAdmin.tblCompanyProgramCodesRow this[int index]
    {
      get => (dsPolicyNumberAdmin.tblCompanyProgramCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyNumberAdmin.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyNumberAdmin.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyNumberAdmin.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyNumberAdmin.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyProgramCodesRow(dsPolicyNumberAdmin.tblCompanyProgramCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyNumberAdmin.tblCompanyProgramCodesRow AddtblCompanyProgramCodesRow(
      string ProgCode)
    {
      dsPolicyNumberAdmin.tblCompanyProgramCodesRow row = (dsPolicyNumberAdmin.tblCompanyProgramCodesRow) this.NewRow();
      object[] objArray = new object[1]{ (object) ProgCode };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyNumberAdmin.tblCompanyProgramCodesDataTable programCodesDataTable = (dsPolicyNumberAdmin.tblCompanyProgramCodesDataTable) base.Clone();
      programCodesDataTable.InitVars();
      return (DataTable) programCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyNumberAdmin.tblCompanyProgramCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars() => this.columnProgCode = this.Columns["ProgCode"];

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnProgCode = new DataColumn("ProgCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgCode);
      this.columnProgCode.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyNumberAdmin.tblCompanyProgramCodesRow NewtblCompanyProgramCodesRow()
    {
      return (dsPolicyNumberAdmin.tblCompanyProgramCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyNumberAdmin.tblCompanyProgramCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyNumberAdmin.tblCompanyProgramCodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyNumberAdmin.tblCompanyProgramCodesRowChangeEventHandler codesRowChangedEvent = this.tblCompanyProgramCodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsPolicyNumberAdmin.tblCompanyProgramCodesRowChangeEvent((dsPolicyNumberAdmin.tblCompanyProgramCodesRow) e.Row, e.Action));
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
      dsPolicyNumberAdmin.tblCompanyProgramCodesRowChangeEventHandler rowChangingEvent = this.tblCompanyProgramCodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyNumberAdmin.tblCompanyProgramCodesRowChangeEvent((dsPolicyNumberAdmin.tblCompanyProgramCodesRow) e.Row, e.Action));
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
      dsPolicyNumberAdmin.tblCompanyProgramCodesRowChangeEventHandler codesRowDeletedEvent = this.tblCompanyProgramCodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsPolicyNumberAdmin.tblCompanyProgramCodesRowChangeEvent((dsPolicyNumberAdmin.tblCompanyProgramCodesRow) e.Row, e.Action));
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
      dsPolicyNumberAdmin.tblCompanyProgramCodesRowChangeEventHandler rowDeletingEvent = this.tblCompanyProgramCodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyNumberAdmin.tblCompanyProgramCodesRowChangeEvent((dsPolicyNumberAdmin.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyProgramCodesRow(dsPolicyNumberAdmin.tblCompanyProgramCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyNumberAdmin policyNumberAdmin = new dsPolicyNumberAdmin();
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
        FixedValue = policyNumberAdmin.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyProgramCodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyNumberAdmin.GetSchemaSerializable();
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

  public class tblPolicyNumberRulesRow : DataRow
  {
    private dsPolicyNumberAdmin.tblPolicyNumberRulesDataTable tabletblPolicyNumberRules;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblPolicyNumberRulesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblPolicyNumberRules = (dsPolicyNumberAdmin.tblPolicyNumberRulesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RuleID
    {
      get => Conversions.ToInteger(this[this.tabletblPolicyNumberRules.RuleIDColumn]);
      set => this[this.tabletblPolicyNumberRules.RuleIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string RuleName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyNumberRules.RuleNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RuleName' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.RuleNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Prefix
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyNumberRules.PrefixColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Prefix' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.PrefixColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int BlockStart
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyNumberRules.BlockStartColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BlockStart' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.BlockStartColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int BlockEnd
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyNumberRules.BlockEndColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BlockEnd' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.BlockEndColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int TotalBlockDigits
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyNumberRules.TotalBlockDigitsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TotalBlockDigits' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.TotalBlockDigitsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int WarnLowBlockCount
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyNumberRules.WarnLowBlockCountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WarnLowBlockCount' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.WarnLowBlockCountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid WarnUser
    {
      get
      {
        try
        {
          object obj = this[this.tabletblPolicyNumberRules.WarnUserColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WarnUser' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.WarnUserColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool NewNumberOnRenewal
    {
      get => Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.NewNumberOnRenewalColumn]);
      set => this[this.tabletblPolicyNumberRules.NewNumberOnRenewalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int SequentialStart
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyNumberRules.SequentialStartColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SequentialStart' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.SequentialStartColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int SequentialTotalDigits
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyNumberRules.SequentialTotalDigitsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SequentialTotalDigits' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.SequentialTotalDigitsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool YearSuffix
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.YearSuffixColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'YearSuffix' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.YearSuffixColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Fixedvalue
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyNumberRules.FixedvalueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fixedvalue' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.FixedvalueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool SuffixDash
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.SuffixDashColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SuffixDash' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.SuffixDashColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Manual
    {
      get => Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.ManualColumn]);
      set => this[this.tabletblPolicyNumberRules.ManualColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool SuffixSeparateSpace
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.SuffixSeparateSpaceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SuffixSeparateSpace' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.SuffixSeparateSpaceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NetrateSunset1Prefix
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyNumberRules.NetrateSunset1PrefixColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NetrateSunset1Prefix' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.NetrateSunset1PrefixColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NetrateSunset2Prefix
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyNumberRules.NetrateSunset2PrefixColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NetrateSunset2Prefix' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.NetrateSunset2PrefixColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NetrateSunset3Prefix
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyNumberRules.NetrateSunset3PrefixColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NetrateSunset3Prefix' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.NetrateSunset3PrefixColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NetrateClaimsMadePrefix
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyNumberRules.NetrateClaimsMadePrefixColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NetrateClaimsMadePrefix' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.NetrateClaimsMadePrefixColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Runoff
    {
      get => Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.RunoffColumn]);
      set => this[this.tabletblPolicyNumberRules.RunoffColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool AlphaSuffix
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.AlphaSuffixColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AlphaSuffix' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.AlphaSuffixColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool AlphaSuffixRenewalOnly
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.AlphaSuffixRenewalOnlyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AlphaSuffixRenewalOnly' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.AlphaSuffixRenewalOnlyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool BasedOnEffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.BasedOnEffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BasedOnEffectiveDate' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.BasedOnEffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ManualNumberOnPurchasedBook
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.ManualNumberOnPurchasedBookColumn]);
      }
      set
      {
        this[this.tabletblPolicyNumberRules.ManualNumberOnPurchasedBookColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ManualNumberOnRenewal
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.ManualNumberOnRenewalColumn]);
      }
      set => this[this.tabletblPolicyNumberRules.ManualNumberOnRenewalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool UseTableBasedNumbering
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.UseTableBasedNumberingColumn]);
      }
      set => this[this.tabletblPolicyNumberRules.UseTableBasedNumberingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int UsePolicyNumberingFromRuleId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyNumberRules.UsePolicyNumberingFromRuleIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UsePolicyNumberingFromRuleId' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblPolicyNumberRules.UsePolicyNumberingFromRuleIdColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool ForceCheckOnRenewal
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.ForceCheckOnRenewalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ForceCheckOnRenewal' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.ForceCheckOnRenewalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NextNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyNumberRules.NextNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NextNumber' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.NextNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool UseSubmissionGroupNumbering
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.UseSubmissionGroupNumberingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UseSubmissionGroupNumbering' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblPolicyNumberRules.UseSubmissionGroupNumberingColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool PromptForManualOverride
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.PromptForManualOverrideColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PromptForManualOverride' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.PromptForManualOverrideColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool FourYearSuffix
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.FourYearSuffixColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FourYearSuffix' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.FourYearSuffixColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyNumberSuffix
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyNumberRules.PolicyNumberSuffixColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumberSuffix' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.PolicyNumberSuffixColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool AppendTwoDigitYear
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.AppendTwoDigitYearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AppendTwoDigitYear' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.AppendTwoDigitYearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool AppendFourDigitYear
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.AppendFourDigitYearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AppendFourDigitYear' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.AppendFourDigitYearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AppendPrefix
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyNumberRules.AppendPrefixColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AppendPrefix' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.AppendPrefixColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProgCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyNumberRules.ProgCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProgCode' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.ProgCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool TwoYearSuffixSeq
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.TwoYearSuffixSeqColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TwoYearSuffixSeq' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.TwoYearSuffixSeqColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool FourYearSuffixSeq
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.FourYearSuffixSeqColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FourYearSuffixSeq' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.FourYearSuffixSeqColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int YearSuffixSequentialStart
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyNumberRules.YearSuffixSequentialStartColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'YearSuffixSequentialStart' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.YearSuffixSequentialStartColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int YearSuffixSequentialTotalDigits
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyNumberRules.YearSuffixSequentialTotalDigitsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'YearSuffixSequentialTotalDigits' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblPolicyNumberRules.YearSuffixSequentialTotalDigitsColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool UseRenewalDigitYear
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.UseRenewalDigitYearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UseRenewalDigitYear' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.UseRenewalDigitYearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool UseInsuredNumber
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.UseInsuredNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UseInsuredNumber' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.UseInsuredNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ManualMask
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyNumberRules.ManualMaskColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ManualMask' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.ManualMaskColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool UseStoredProc
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.UseStoredProcColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UseStoredProc' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.UseStoredProcColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool NumericalSuffixRenewalOnly
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyNumberRules.NumericalSuffixRenewalOnlyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumericalSuffixRenewalOnly' in table 'tblPolicyNumberRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyNumberRules.NumericalSuffixRenewalOnlyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRuleNameNull() => this.IsNull(this.tabletblPolicyNumberRules.RuleNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRuleNameNull()
    {
      this[this.tabletblPolicyNumberRules.RuleNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPrefixNull() => this.IsNull(this.tabletblPolicyNumberRules.PrefixColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPrefixNull()
    {
      this[this.tabletblPolicyNumberRules.PrefixColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBlockStartNull() => this.IsNull(this.tabletblPolicyNumberRules.BlockStartColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBlockStartNull()
    {
      this[this.tabletblPolicyNumberRules.BlockStartColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBlockEndNull() => this.IsNull(this.tabletblPolicyNumberRules.BlockEndColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBlockEndNull()
    {
      this[this.tabletblPolicyNumberRules.BlockEndColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTotalBlockDigitsNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.TotalBlockDigitsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTotalBlockDigitsNull()
    {
      this[this.tabletblPolicyNumberRules.TotalBlockDigitsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsWarnLowBlockCountNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.WarnLowBlockCountColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetWarnLowBlockCountNull()
    {
      this[this.tabletblPolicyNumberRules.WarnLowBlockCountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsWarnUserNull() => this.IsNull(this.tabletblPolicyNumberRules.WarnUserColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetWarnUserNull()
    {
      this[this.tabletblPolicyNumberRules.WarnUserColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSequentialStartNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.SequentialStartColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSequentialStartNull()
    {
      this[this.tabletblPolicyNumberRules.SequentialStartColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSequentialTotalDigitsNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.SequentialTotalDigitsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSequentialTotalDigitsNull()
    {
      this[this.tabletblPolicyNumberRules.SequentialTotalDigitsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsYearSuffixNull() => this.IsNull(this.tabletblPolicyNumberRules.YearSuffixColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetYearSuffixNull()
    {
      this[this.tabletblPolicyNumberRules.YearSuffixColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFixedvalueNull() => this.IsNull(this.tabletblPolicyNumberRules.FixedvalueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFixedvalueNull()
    {
      this[this.tabletblPolicyNumberRules.FixedvalueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSuffixDashNull() => this.IsNull(this.tabletblPolicyNumberRules.SuffixDashColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSuffixDashNull()
    {
      this[this.tabletblPolicyNumberRules.SuffixDashColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSuffixSeparateSpaceNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.SuffixSeparateSpaceColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSuffixSeparateSpaceNull()
    {
      this[this.tabletblPolicyNumberRules.SuffixSeparateSpaceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNetrateSunset1PrefixNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.NetrateSunset1PrefixColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNetrateSunset1PrefixNull()
    {
      this[this.tabletblPolicyNumberRules.NetrateSunset1PrefixColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNetrateSunset2PrefixNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.NetrateSunset2PrefixColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNetrateSunset2PrefixNull()
    {
      this[this.tabletblPolicyNumberRules.NetrateSunset2PrefixColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNetrateSunset3PrefixNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.NetrateSunset3PrefixColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNetrateSunset3PrefixNull()
    {
      this[this.tabletblPolicyNumberRules.NetrateSunset3PrefixColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNetrateClaimsMadePrefixNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.NetrateClaimsMadePrefixColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNetrateClaimsMadePrefixNull()
    {
      this[this.tabletblPolicyNumberRules.NetrateClaimsMadePrefixColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAlphaSuffixNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.AlphaSuffixColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAlphaSuffixNull()
    {
      this[this.tabletblPolicyNumberRules.AlphaSuffixColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAlphaSuffixRenewalOnlyNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.AlphaSuffixRenewalOnlyColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAlphaSuffixRenewalOnlyNull()
    {
      this[this.tabletblPolicyNumberRules.AlphaSuffixRenewalOnlyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBasedOnEffectiveDateNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.BasedOnEffectiveDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBasedOnEffectiveDateNull()
    {
      this[this.tabletblPolicyNumberRules.BasedOnEffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUsePolicyNumberingFromRuleIdNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.UsePolicyNumberingFromRuleIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUsePolicyNumberingFromRuleIdNull()
    {
      this[this.tabletblPolicyNumberRules.UsePolicyNumberingFromRuleIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsForceCheckOnRenewalNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.ForceCheckOnRenewalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetForceCheckOnRenewalNull()
    {
      this[this.tabletblPolicyNumberRules.ForceCheckOnRenewalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNextNumberNull() => this.IsNull(this.tabletblPolicyNumberRules.NextNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNextNumberNull()
    {
      this[this.tabletblPolicyNumberRules.NextNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUseSubmissionGroupNumberingNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.UseSubmissionGroupNumberingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUseSubmissionGroupNumberingNull()
    {
      this[this.tabletblPolicyNumberRules.UseSubmissionGroupNumberingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPromptForManualOverrideNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.PromptForManualOverrideColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPromptForManualOverrideNull()
    {
      this[this.tabletblPolicyNumberRules.PromptForManualOverrideColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFourYearSuffixNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.FourYearSuffixColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFourYearSuffixNull()
    {
      this[this.tabletblPolicyNumberRules.FourYearSuffixColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyNumberSuffixNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.PolicyNumberSuffixColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyNumberSuffixNull()
    {
      this[this.tabletblPolicyNumberRules.PolicyNumberSuffixColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAppendTwoDigitYearNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.AppendTwoDigitYearColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAppendTwoDigitYearNull()
    {
      this[this.tabletblPolicyNumberRules.AppendTwoDigitYearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAppendFourDigitYearNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.AppendFourDigitYearColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAppendFourDigitYearNull()
    {
      this[this.tabletblPolicyNumberRules.AppendFourDigitYearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAppendPrefixNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.AppendPrefixColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAppendPrefixNull()
    {
      this[this.tabletblPolicyNumberRules.AppendPrefixColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProgCodeNull() => this.IsNull(this.tabletblPolicyNumberRules.ProgCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProgCodeNull()
    {
      this[this.tabletblPolicyNumberRules.ProgCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTwoYearSuffixSeqNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.TwoYearSuffixSeqColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTwoYearSuffixSeqNull()
    {
      this[this.tabletblPolicyNumberRules.TwoYearSuffixSeqColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFourYearSuffixSeqNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.FourYearSuffixSeqColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFourYearSuffixSeqNull()
    {
      this[this.tabletblPolicyNumberRules.FourYearSuffixSeqColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsYearSuffixSequentialStartNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.YearSuffixSequentialStartColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetYearSuffixSequentialStartNull()
    {
      this[this.tabletblPolicyNumberRules.YearSuffixSequentialStartColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsYearSuffixSequentialTotalDigitsNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.YearSuffixSequentialTotalDigitsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetYearSuffixSequentialTotalDigitsNull()
    {
      this[this.tabletblPolicyNumberRules.YearSuffixSequentialTotalDigitsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUseRenewalDigitYearNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.UseRenewalDigitYearColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUseRenewalDigitYearNull()
    {
      this[this.tabletblPolicyNumberRules.UseRenewalDigitYearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUseInsuredNumberNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.UseInsuredNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUseInsuredNumberNull()
    {
      this[this.tabletblPolicyNumberRules.UseInsuredNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsManualMaskNull() => this.IsNull(this.tabletblPolicyNumberRules.ManualMaskColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetManualMaskNull()
    {
      this[this.tabletblPolicyNumberRules.ManualMaskColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUseStoredProcNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.UseStoredProcColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUseStoredProcNull()
    {
      this[this.tabletblPolicyNumberRules.UseStoredProcColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNumericalSuffixRenewalOnlyNull()
    {
      return this.IsNull(this.tabletblPolicyNumberRules.NumericalSuffixRenewalOnlyColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNumericalSuffixRenewalOnlyNull()
    {
      this[this.tabletblPolicyNumberRules.NumericalSuffixRenewalOnlyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblUsersRow : DataRow
  {
    private dsPolicyNumberAdmin.tblUsersDataTable tabletblUsers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblUsersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUsers = (dsPolicyNumberAdmin.tblUsersDataTable) this.Table;
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
    public string UserName
    {
      get => Conversions.ToString(this[this.tabletblUsers.UserNameColumn]);
      set => this[this.tabletblUsers.UserNameColumn] = (object) value;
    }
  }

  public class tblCompanyProgramCodesRow : DataRow
  {
    private dsPolicyNumberAdmin.tblCompanyProgramCodesDataTable tabletblCompanyProgramCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyProgramCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyProgramCodes = (dsPolicyNumberAdmin.tblCompanyProgramCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProgCode
    {
      get => Conversions.ToString(this[this.tabletblCompanyProgramCodes.ProgCodeColumn]);
      set => this[this.tabletblCompanyProgramCodes.ProgCodeColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblPolicyNumberRulesRowChangeEvent : EventArgs
  {
    private dsPolicyNumberAdmin.tblPolicyNumberRulesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblPolicyNumberRulesRowChangeEvent(
      dsPolicyNumberAdmin.tblPolicyNumberRulesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyNumberAdmin.tblPolicyNumberRulesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblUsersRowChangeEvent : EventArgs
  {
    private dsPolicyNumberAdmin.tblUsersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblUsersRowChangeEvent(dsPolicyNumberAdmin.tblUsersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyNumberAdmin.tblUsersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyProgramCodesRowChangeEvent : EventArgs
  {
    private dsPolicyNumberAdmin.tblCompanyProgramCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyProgramCodesRowChangeEvent(
      dsPolicyNumberAdmin.tblCompanyProgramCodesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyNumberAdmin.tblCompanyProgramCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
