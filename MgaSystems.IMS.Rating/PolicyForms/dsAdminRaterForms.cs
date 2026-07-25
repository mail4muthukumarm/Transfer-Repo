// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.PolicyForms.dsAdminRaterForms
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

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
namespace MGASystems.IMS.Policies.Rating.PolicyForms;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsAdminRaterForms")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsAdminRaterForms : DataSet
{
  private dsAdminRaterForms.ConditionsDataTable tableConditions;
  private dsAdminRaterForms.OperatorsDataTable tableOperators;
  private dsAdminRaterForms.tblRaterFormAutomationDataTable tabletblRaterFormAutomation;
  private dsAdminRaterForms.tblPolicyFormsDataTable tabletblPolicyForms;
  private dsAdminRaterForms.tblRaterFormSetupsDataTable tabletblRaterFormSetups;
  private dsAdminRaterForms.tblCompanyRatersDataTable tabletblCompanyRaters;
  private dsAdminRaterForms.tblConditionsDataTable tabletblConditions;
  private DataRelation relationtblRaterFormSetups_tblRaterFormAutomation;
  private DataRelation relationOperators_tblRaterFormAutomation;
  private DataRelation relationConditions_tblRaterFormAutomation;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsAdminRaterForms()
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
  protected dsAdminRaterForms(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (Conditions)] != null)
          base.Tables.Add((DataTable) new dsAdminRaterForms.ConditionsDataTable(dataSet.Tables[nameof (Conditions)]));
        if (dataSet.Tables[nameof (Operators)] != null)
          base.Tables.Add((DataTable) new dsAdminRaterForms.OperatorsDataTable(dataSet.Tables[nameof (Operators)]));
        if (dataSet.Tables[nameof (tblRaterFormAutomation)] != null)
          base.Tables.Add((DataTable) new dsAdminRaterForms.tblRaterFormAutomationDataTable(dataSet.Tables[nameof (tblRaterFormAutomation)]));
        if (dataSet.Tables[nameof (tblPolicyForms)] != null)
          base.Tables.Add((DataTable) new dsAdminRaterForms.tblPolicyFormsDataTable(dataSet.Tables[nameof (tblPolicyForms)]));
        if (dataSet.Tables[nameof (tblRaterFormSetups)] != null)
          base.Tables.Add((DataTable) new dsAdminRaterForms.tblRaterFormSetupsDataTable(dataSet.Tables[nameof (tblRaterFormSetups)]));
        if (dataSet.Tables[nameof (tblCompanyRaters)] != null)
          base.Tables.Add((DataTable) new dsAdminRaterForms.tblCompanyRatersDataTable(dataSet.Tables[nameof (tblCompanyRaters)]));
        if (dataSet.Tables[nameof (tblConditions)] != null)
          base.Tables.Add((DataTable) new dsAdminRaterForms.tblConditionsDataTable(dataSet.Tables[nameof (tblConditions)]));
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
  public dsAdminRaterForms.ConditionsDataTable Conditions => this.tableConditions;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminRaterForms.OperatorsDataTable Operators => this.tableOperators;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminRaterForms.tblRaterFormAutomationDataTable tblRaterFormAutomation
  {
    get => this.tabletblRaterFormAutomation;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminRaterForms.tblPolicyFormsDataTable tblPolicyForms => this.tabletblPolicyForms;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminRaterForms.tblRaterFormSetupsDataTable tblRaterFormSetups
  {
    get => this.tabletblRaterFormSetups;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminRaterForms.tblCompanyRatersDataTable tblCompanyRaters => this.tabletblCompanyRaters;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminRaterForms.tblConditionsDataTable tblConditions => this.tabletblConditions;

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
    dsAdminRaterForms dsAdminRaterForms = (dsAdminRaterForms) base.Clone();
    dsAdminRaterForms.InitVars();
    dsAdminRaterForms.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsAdminRaterForms;
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
      if (dataSet.Tables["Conditions"] != null)
        base.Tables.Add((DataTable) new dsAdminRaterForms.ConditionsDataTable(dataSet.Tables["Conditions"]));
      if (dataSet.Tables["Operators"] != null)
        base.Tables.Add((DataTable) new dsAdminRaterForms.OperatorsDataTable(dataSet.Tables["Operators"]));
      if (dataSet.Tables["tblRaterFormAutomation"] != null)
        base.Tables.Add((DataTable) new dsAdminRaterForms.tblRaterFormAutomationDataTable(dataSet.Tables["tblRaterFormAutomation"]));
      if (dataSet.Tables["tblPolicyForms"] != null)
        base.Tables.Add((DataTable) new dsAdminRaterForms.tblPolicyFormsDataTable(dataSet.Tables["tblPolicyForms"]));
      if (dataSet.Tables["tblRaterFormSetups"] != null)
        base.Tables.Add((DataTable) new dsAdminRaterForms.tblRaterFormSetupsDataTable(dataSet.Tables["tblRaterFormSetups"]));
      if (dataSet.Tables["tblCompanyRaters"] != null)
        base.Tables.Add((DataTable) new dsAdminRaterForms.tblCompanyRatersDataTable(dataSet.Tables["tblCompanyRaters"]));
      if (dataSet.Tables["tblConditions"] != null)
        base.Tables.Add((DataTable) new dsAdminRaterForms.tblConditionsDataTable(dataSet.Tables["tblConditions"]));
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
    this.tableConditions = (dsAdminRaterForms.ConditionsDataTable) base.Tables["Conditions"];
    if (initTable && this.tableConditions != null)
      this.tableConditions.InitVars();
    this.tableOperators = (dsAdminRaterForms.OperatorsDataTable) base.Tables["Operators"];
    if (initTable && this.tableOperators != null)
      this.tableOperators.InitVars();
    this.tabletblRaterFormAutomation = (dsAdminRaterForms.tblRaterFormAutomationDataTable) base.Tables["tblRaterFormAutomation"];
    if (initTable && this.tabletblRaterFormAutomation != null)
      this.tabletblRaterFormAutomation.InitVars();
    this.tabletblPolicyForms = (dsAdminRaterForms.tblPolicyFormsDataTable) base.Tables["tblPolicyForms"];
    if (initTable && this.tabletblPolicyForms != null)
      this.tabletblPolicyForms.InitVars();
    this.tabletblRaterFormSetups = (dsAdminRaterForms.tblRaterFormSetupsDataTable) base.Tables["tblRaterFormSetups"];
    if (initTable && this.tabletblRaterFormSetups != null)
      this.tabletblRaterFormSetups.InitVars();
    this.tabletblCompanyRaters = (dsAdminRaterForms.tblCompanyRatersDataTable) base.Tables["tblCompanyRaters"];
    if (initTable && this.tabletblCompanyRaters != null)
      this.tabletblCompanyRaters.InitVars();
    this.tabletblConditions = (dsAdminRaterForms.tblConditionsDataTable) base.Tables["tblConditions"];
    if (initTable && this.tabletblConditions != null)
      this.tabletblConditions.InitVars();
    this.relationtblRaterFormSetups_tblRaterFormAutomation = this.Relations["tblRaterFormSetups_tblRaterFormAutomation"];
    this.relationOperators_tblRaterFormAutomation = this.Relations["Operators_tblRaterFormAutomation"];
    this.relationConditions_tblRaterFormAutomation = this.Relations["Conditions_tblRaterFormAutomation"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsAdminRaterForms);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsAdminRaterForms.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableConditions = new dsAdminRaterForms.ConditionsDataTable();
    base.Tables.Add((DataTable) this.tableConditions);
    this.tableOperators = new dsAdminRaterForms.OperatorsDataTable();
    base.Tables.Add((DataTable) this.tableOperators);
    this.tabletblRaterFormAutomation = new dsAdminRaterForms.tblRaterFormAutomationDataTable();
    base.Tables.Add((DataTable) this.tabletblRaterFormAutomation);
    this.tabletblPolicyForms = new dsAdminRaterForms.tblPolicyFormsDataTable();
    base.Tables.Add((DataTable) this.tabletblPolicyForms);
    this.tabletblRaterFormSetups = new dsAdminRaterForms.tblRaterFormSetupsDataTable();
    base.Tables.Add((DataTable) this.tabletblRaterFormSetups);
    this.tabletblCompanyRaters = new dsAdminRaterForms.tblCompanyRatersDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyRaters);
    this.tabletblConditions = new dsAdminRaterForms.tblConditionsDataTable();
    base.Tables.Add((DataTable) this.tabletblConditions);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("tblRaterFormSetups_tblRaterFormAutomation", new DataColumn[1]
    {
      this.tabletblRaterFormSetups.SetupIDColumn
    }, new DataColumn[1]
    {
      this.tabletblRaterFormAutomation.SetupIDColumn
    });
    this.tabletblRaterFormAutomation.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationtblRaterFormSetups_tblRaterFormAutomation = new DataRelation("tblRaterFormSetups_tblRaterFormAutomation", new DataColumn[1]
    {
      this.tabletblRaterFormSetups.SetupIDColumn
    }, new DataColumn[1]
    {
      this.tabletblRaterFormAutomation.SetupIDColumn
    }, false);
    this.Relations.Add(this.relationtblRaterFormSetups_tblRaterFormAutomation);
    this.relationOperators_tblRaterFormAutomation = new DataRelation("Operators_tblRaterFormAutomation", new DataColumn[1]
    {
      this.tableOperators.OperatorColumn
    }, new DataColumn[1]
    {
      this.tabletblRaterFormAutomation.OperatorColumn
    }, false);
    this.Relations.Add(this.relationOperators_tblRaterFormAutomation);
    this.relationConditions_tblRaterFormAutomation = new DataRelation("Conditions_tblRaterFormAutomation", new DataColumn[2]
    {
      this.tableConditions.ConditionalIDColumn,
      this.tableConditions.RaterIDColumn
    }, new DataColumn[2]
    {
      this.tabletblRaterFormAutomation.ConditionIDColumn,
      this.tabletblRaterFormAutomation.RaterIDColumn
    }, false);
    this.Relations.Add(this.relationConditions_tblRaterFormAutomation);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeConditions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeOperators() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblRaterFormAutomation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblPolicyForms() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblRaterFormSetups() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyRaters() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblConditions() => false;

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
    dsAdminRaterForms dsAdminRaterForms = new dsAdminRaterForms();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsAdminRaterForms.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsAdminRaterForms.GetSchemaSerializable();
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
  public delegate void ConditionsRowChangeEventHandler(
    object sender,
    dsAdminRaterForms.ConditionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void OperatorsRowChangeEventHandler(
    object sender,
    dsAdminRaterForms.OperatorsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblRaterFormAutomationRowChangeEventHandler(
    object sender,
    dsAdminRaterForms.tblRaterFormAutomationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblPolicyFormsRowChangeEventHandler(
    object sender,
    dsAdminRaterForms.tblPolicyFormsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblRaterFormSetupsRowChangeEventHandler(
    object sender,
    dsAdminRaterForms.tblRaterFormSetupsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyRatersRowChangeEventHandler(
    object sender,
    dsAdminRaterForms.tblCompanyRatersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblConditionsRowChangeEventHandler(
    object sender,
    dsAdminRaterForms.tblConditionsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class ConditionsDataTable : TypedTableBase<dsAdminRaterForms.ConditionsRow>
  {
    private DataColumn columnCondition;
    private DataColumn columnRaterID;
    private DataColumn columnConditionalID;
    private DataColumn columnConditionalType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public ConditionsDataTable()
    {
      this.TableName = "Conditions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal ConditionsDataTable(DataTable table)
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
    protected ConditionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ConditionColumn => this.columnCondition;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RaterIDColumn => this.columnRaterID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ConditionalIDColumn => this.columnConditionalID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ConditionalTypeColumn => this.columnConditionalType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.ConditionsRow this[int index]
    {
      get => (dsAdminRaterForms.ConditionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.ConditionsRowChangeEventHandler ConditionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.ConditionsRowChangeEventHandler ConditionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.ConditionsRowChangeEventHandler ConditionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.ConditionsRowChangeEventHandler ConditionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddConditionsRow(dsAdminRaterForms.ConditionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.ConditionsRow AddConditionsRow(
      string Condition,
      int RaterID,
      int ConditionalID,
      string ConditionalType)
    {
      dsAdminRaterForms.ConditionsRow row = (dsAdminRaterForms.ConditionsRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) Condition,
        (object) RaterID,
        (object) ConditionalID,
        (object) ConditionalType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.ConditionsRow FindByRaterIDConditionalID(
      int RaterID,
      int ConditionalID)
    {
      return (dsAdminRaterForms.ConditionsRow) this.Rows.Find(new object[2]
      {
        (object) RaterID,
        (object) ConditionalID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminRaterForms.ConditionsDataTable conditionsDataTable = (dsAdminRaterForms.ConditionsDataTable) base.Clone();
      conditionsDataTable.InitVars();
      return (DataTable) conditionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminRaterForms.ConditionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCondition = this.Columns["Condition"];
      this.columnRaterID = this.Columns["RaterID"];
      this.columnConditionalID = this.Columns["ConditionalID"];
      this.columnConditionalType = this.Columns["ConditionalType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCondition = new DataColumn("Condition", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCondition);
      this.columnRaterID = new DataColumn("RaterID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRaterID);
      this.columnConditionalID = new DataColumn("ConditionalID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConditionalID);
      this.columnConditionalType = new DataColumn("ConditionalType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConditionalType);
      this.Constraints.Add((Constraint) new UniqueConstraint("ConditionsKey1", new DataColumn[2]
      {
        this.columnRaterID,
        this.columnConditionalID
      }, true));
      this.columnCondition.AllowDBNull = false;
      this.columnRaterID.AllowDBNull = false;
      this.columnConditionalID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.ConditionsRow NewConditionsRow()
    {
      return (dsAdminRaterForms.ConditionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminRaterForms.ConditionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminRaterForms.ConditionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ConditionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.ConditionsRowChangeEventHandler conditionsRowChangedEvent = this.ConditionsRowChangedEvent;
      if (conditionsRowChangedEvent == null)
        return;
      conditionsRowChangedEvent((object) this, new dsAdminRaterForms.ConditionsRowChangeEvent((dsAdminRaterForms.ConditionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ConditionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.ConditionsRowChangeEventHandler rowChangingEvent = this.ConditionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminRaterForms.ConditionsRowChangeEvent((dsAdminRaterForms.ConditionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ConditionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.ConditionsRowChangeEventHandler conditionsRowDeletedEvent = this.ConditionsRowDeletedEvent;
      if (conditionsRowDeletedEvent == null)
        return;
      conditionsRowDeletedEvent((object) this, new dsAdminRaterForms.ConditionsRowChangeEvent((dsAdminRaterForms.ConditionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ConditionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.ConditionsRowChangeEventHandler rowDeletingEvent = this.ConditionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminRaterForms.ConditionsRowChangeEvent((dsAdminRaterForms.ConditionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveConditionsRow(dsAdminRaterForms.ConditionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminRaterForms dsAdminRaterForms = new dsAdminRaterForms();
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
        FixedValue = dsAdminRaterForms.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ConditionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminRaterForms.GetSchemaSerializable();
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
  public class OperatorsDataTable : TypedTableBase<dsAdminRaterForms.OperatorsRow>
  {
    private DataColumn columnOperator;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public OperatorsDataTable()
    {
      this.TableName = "Operators";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal OperatorsDataTable(DataTable table)
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
    protected OperatorsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OperatorColumn => this.columnOperator;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.OperatorsRow this[int index]
    {
      get => (dsAdminRaterForms.OperatorsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.OperatorsRowChangeEventHandler OperatorsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.OperatorsRowChangeEventHandler OperatorsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.OperatorsRowChangeEventHandler OperatorsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.OperatorsRowChangeEventHandler OperatorsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddOperatorsRow(dsAdminRaterForms.OperatorsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.OperatorsRow AddOperatorsRow(string _Operator, string Description)
    {
      dsAdminRaterForms.OperatorsRow row = (dsAdminRaterForms.OperatorsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) _Operator,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.OperatorsRow FindBy_Operator(string _Operator)
    {
      return (dsAdminRaterForms.OperatorsRow) this.Rows.Find(new object[1]
      {
        (object) _Operator
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminRaterForms.OperatorsDataTable operatorsDataTable = (dsAdminRaterForms.OperatorsDataTable) base.Clone();
      operatorsDataTable.InitVars();
      return (DataTable) operatorsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminRaterForms.OperatorsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnOperator = this.Columns["Operator"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnOperator = new DataColumn("Operator", typeof (string), (string) null, MappingType.Element);
      this.columnOperator.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "OperatorColumn");
      this.columnOperator.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnOperator");
      this.columnOperator.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Operator");
      this.Columns.Add(this.columnOperator);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("OperatorsKey1", new DataColumn[1]
      {
        this.columnOperator
      }, true));
      this.columnOperator.AllowDBNull = false;
      this.columnOperator.Unique = true;
      this.columnOperator.Caption = "Operators";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.OperatorsRow NewOperatorsRow()
    {
      return (dsAdminRaterForms.OperatorsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminRaterForms.OperatorsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminRaterForms.OperatorsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OperatorsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.OperatorsRowChangeEventHandler operatorsRowChangedEvent = this.OperatorsRowChangedEvent;
      if (operatorsRowChangedEvent == null)
        return;
      operatorsRowChangedEvent((object) this, new dsAdminRaterForms.OperatorsRowChangeEvent((dsAdminRaterForms.OperatorsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OperatorsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.OperatorsRowChangeEventHandler rowChangingEvent = this.OperatorsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminRaterForms.OperatorsRowChangeEvent((dsAdminRaterForms.OperatorsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OperatorsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.OperatorsRowChangeEventHandler operatorsRowDeletedEvent = this.OperatorsRowDeletedEvent;
      if (operatorsRowDeletedEvent == null)
        return;
      operatorsRowDeletedEvent((object) this, new dsAdminRaterForms.OperatorsRowChangeEvent((dsAdminRaterForms.OperatorsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OperatorsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.OperatorsRowChangeEventHandler rowDeletingEvent = this.OperatorsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminRaterForms.OperatorsRowChangeEvent((dsAdminRaterForms.OperatorsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveOperatorsRow(dsAdminRaterForms.OperatorsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminRaterForms dsAdminRaterForms = new dsAdminRaterForms();
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
        FixedValue = dsAdminRaterForms.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (OperatorsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminRaterForms.GetSchemaSerializable();
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
  public class tblRaterFormAutomationDataTable : 
    TypedTableBase<dsAdminRaterForms.tblRaterFormAutomationRow>
  {
    private DataColumn columnConditionalID;
    private DataColumn columnOperator;
    private DataColumn columnAmount;
    private DataColumn columnSetupID;
    private DataColumn columnConditionID;
    private DataColumn columnRaterID;
    private DataColumn columnFormVisibility;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblRaterFormAutomationDataTable()
    {
      this.TableName = "tblRaterFormAutomation";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblRaterFormAutomationDataTable(DataTable table)
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
    protected tblRaterFormAutomationDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ConditionalIDColumn => this.columnConditionalID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OperatorColumn => this.columnOperator;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AmountColumn => this.columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SetupIDColumn => this.columnSetupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ConditionIDColumn => this.columnConditionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RaterIDColumn => this.columnRaterID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormVisibilityColumn => this.columnFormVisibility;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblRaterFormAutomationRow this[int index]
    {
      get => (dsAdminRaterForms.tblRaterFormAutomationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblRaterFormAutomationRowChangeEventHandler tblRaterFormAutomationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblRaterFormAutomationRowChangeEventHandler tblRaterFormAutomationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblRaterFormAutomationRowChangeEventHandler tblRaterFormAutomationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblRaterFormAutomationRowChangeEventHandler tblRaterFormAutomationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblRaterFormAutomationRow(dsAdminRaterForms.tblRaterFormAutomationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblRaterFormAutomationRow AddtblRaterFormAutomationRow(
      int ConditionalID,
      dsAdminRaterForms.OperatorsRow parentOperatorsRowByOperators_tblRaterFormAutomation,
      string Amount,
      int RaterID,
      bool FormVisibility)
    {
      dsAdminRaterForms.tblRaterFormAutomationRow row = (dsAdminRaterForms.tblRaterFormAutomationRow) this.NewRow();
      object[] objArray = new object[7]
      {
        (object) ConditionalID,
        null,
        (object) Amount,
        null,
        null,
        (object) RaterID,
        (object) FormVisibility
      };
      if (parentOperatorsRowByOperators_tblRaterFormAutomation != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentOperatorsRowByOperators_tblRaterFormAutomation[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblRaterFormAutomationRow FindByConditionID(int ConditionID)
    {
      return (dsAdminRaterForms.tblRaterFormAutomationRow) this.Rows.Find(new object[1]
      {
        (object) ConditionID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminRaterForms.tblRaterFormAutomationDataTable automationDataTable = (dsAdminRaterForms.tblRaterFormAutomationDataTable) base.Clone();
      automationDataTable.InitVars();
      return (DataTable) automationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminRaterForms.tblRaterFormAutomationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnConditionalID = this.Columns["ConditionalID"];
      this.columnOperator = this.Columns["Operator"];
      this.columnAmount = this.Columns["Amount"];
      this.columnSetupID = this.Columns["SetupID"];
      this.columnConditionID = this.Columns["ConditionID"];
      this.columnRaterID = this.Columns["RaterID"];
      this.columnFormVisibility = this.Columns["FormVisibility"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnConditionalID = new DataColumn("ConditionalID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConditionalID);
      this.columnOperator = new DataColumn("Operator", typeof (string), (string) null, MappingType.Element);
      this.columnOperator.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "OperatorColumn");
      this.columnOperator.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnOperator");
      this.columnOperator.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Operator");
      this.Columns.Add(this.columnOperator);
      this.columnAmount = new DataColumn("Amount", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnSetupID = new DataColumn("SetupID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSetupID);
      this.columnConditionID = new DataColumn("ConditionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConditionID);
      this.columnRaterID = new DataColumn("RaterID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRaterID);
      this.columnFormVisibility = new DataColumn("FormVisibility", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormVisibility);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnConditionID
      }, true));
      this.columnSetupID.AutoIncrement = true;
      this.columnSetupID.AllowDBNull = false;
      this.columnConditionID.AutoIncrement = true;
      this.columnConditionID.AutoIncrementSeed = -1L;
      this.columnConditionID.AutoIncrementStep = -1L;
      this.columnConditionID.AllowDBNull = false;
      this.columnConditionID.Unique = true;
      this.columnFormVisibility.AllowDBNull = false;
      this.columnFormVisibility.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblRaterFormAutomationRow NewtblRaterFormAutomationRow()
    {
      return (dsAdminRaterForms.tblRaterFormAutomationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminRaterForms.tblRaterFormAutomationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminRaterForms.tblRaterFormAutomationRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblRaterFormAutomationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.tblRaterFormAutomationRowChangeEventHandler automationRowChangedEvent = this.tblRaterFormAutomationRowChangedEvent;
      if (automationRowChangedEvent == null)
        return;
      automationRowChangedEvent((object) this, new dsAdminRaterForms.tblRaterFormAutomationRowChangeEvent((dsAdminRaterForms.tblRaterFormAutomationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblRaterFormAutomationRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.tblRaterFormAutomationRowChangeEventHandler rowChangingEvent = this.tblRaterFormAutomationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminRaterForms.tblRaterFormAutomationRowChangeEvent((dsAdminRaterForms.tblRaterFormAutomationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblRaterFormAutomationRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.tblRaterFormAutomationRowChangeEventHandler automationRowDeletedEvent = this.tblRaterFormAutomationRowDeletedEvent;
      if (automationRowDeletedEvent == null)
        return;
      automationRowDeletedEvent((object) this, new dsAdminRaterForms.tblRaterFormAutomationRowChangeEvent((dsAdminRaterForms.tblRaterFormAutomationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblRaterFormAutomationRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.tblRaterFormAutomationRowChangeEventHandler rowDeletingEvent = this.tblRaterFormAutomationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminRaterForms.tblRaterFormAutomationRowChangeEvent((dsAdminRaterForms.tblRaterFormAutomationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblRaterFormAutomationRow(dsAdminRaterForms.tblRaterFormAutomationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminRaterForms dsAdminRaterForms = new dsAdminRaterForms();
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
        FixedValue = dsAdminRaterForms.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblRaterFormAutomationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminRaterForms.GetSchemaSerializable();
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
  public class tblPolicyFormsDataTable : TypedTableBase<dsAdminRaterForms.tblPolicyFormsRow>
  {
    private DataColumn columnFormID;
    private DataColumn columnFormName;
    private DataColumn columnDisabled;

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
    public DataColumn DisabledColumn => this.columnDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblPolicyFormsRow this[int index]
    {
      get => (dsAdminRaterForms.tblPolicyFormsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblPolicyFormsRow(dsAdminRaterForms.tblPolicyFormsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblPolicyFormsRow AddtblPolicyFormsRow(
      int FormID,
      string FormName,
      bool Disabled)
    {
      dsAdminRaterForms.tblPolicyFormsRow row = (dsAdminRaterForms.tblPolicyFormsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) FormID,
        (object) FormName,
        (object) Disabled
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblPolicyFormsRow FindByFormID(int FormID)
    {
      return (dsAdminRaterForms.tblPolicyFormsRow) this.Rows.Find(new object[1]
      {
        (object) FormID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminRaterForms.tblPolicyFormsDataTable policyFormsDataTable = (dsAdminRaterForms.tblPolicyFormsDataTable) base.Clone();
      policyFormsDataTable.InitVars();
      return (DataTable) policyFormsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminRaterForms.tblPolicyFormsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnFormID = this.Columns["FormID"];
      this.columnFormName = this.Columns["FormName"];
      this.columnDisabled = this.Columns["Disabled"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnFormID = new DataColumn("FormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormID);
      this.columnFormName = new DataColumn("FormName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormName);
      this.columnDisabled = new DataColumn("Disabled", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisabled);
      this.Constraints.Add((Constraint) new UniqueConstraint("tblPolicyFormsKey1", new DataColumn[1]
      {
        this.columnFormID
      }, true));
      this.columnFormID.AllowDBNull = false;
      this.columnFormID.Unique = true;
      this.columnFormName.AllowDBNull = false;
      this.columnDisabled.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblPolicyFormsRow NewtblPolicyFormsRow()
    {
      return (dsAdminRaterForms.tblPolicyFormsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminRaterForms.tblPolicyFormsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminRaterForms.tblPolicyFormsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFormsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.tblPolicyFormsRowChangeEventHandler formsRowChangedEvent = this.tblPolicyFormsRowChangedEvent;
      if (formsRowChangedEvent == null)
        return;
      formsRowChangedEvent((object) this, new dsAdminRaterForms.tblPolicyFormsRowChangeEvent((dsAdminRaterForms.tblPolicyFormsRow) e.Row, e.Action));
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
      dsAdminRaterForms.tblPolicyFormsRowChangeEventHandler rowChangingEvent = this.tblPolicyFormsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminRaterForms.tblPolicyFormsRowChangeEvent((dsAdminRaterForms.tblPolicyFormsRow) e.Row, e.Action));
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
      dsAdminRaterForms.tblPolicyFormsRowChangeEventHandler formsRowDeletedEvent = this.tblPolicyFormsRowDeletedEvent;
      if (formsRowDeletedEvent == null)
        return;
      formsRowDeletedEvent((object) this, new dsAdminRaterForms.tblPolicyFormsRowChangeEvent((dsAdminRaterForms.tblPolicyFormsRow) e.Row, e.Action));
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
      dsAdminRaterForms.tblPolicyFormsRowChangeEventHandler rowDeletingEvent = this.tblPolicyFormsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminRaterForms.tblPolicyFormsRowChangeEvent((dsAdminRaterForms.tblPolicyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblPolicyFormsRow(dsAdminRaterForms.tblPolicyFormsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminRaterForms dsAdminRaterForms = new dsAdminRaterForms();
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
        FixedValue = dsAdminRaterForms.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblPolicyFormsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminRaterForms.GetSchemaSerializable();
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
  public class tblRaterFormSetupsDataTable : TypedTableBase<dsAdminRaterForms.tblRaterFormSetupsRow>
  {
    private DataColumn columnSetupID;
    private DataColumn columnPolicyFormID;
    private DataColumn columnCompanyLineID;
    private DataColumn columnRaterID;
    private DataColumn columnCompanyLineConditionID;
    private DataColumn columnformDescription;
    private DataColumn columnSingleTransaction;
    private DataColumn columnFormNumber;
    private DataColumn columnFormName;
    private DataColumn columnDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblRaterFormSetupsDataTable()
    {
      this.TableName = "tblRaterFormSetups";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblRaterFormSetupsDataTable(DataTable table)
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
    protected tblRaterFormSetupsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SetupIDColumn => this.columnSetupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyFormIDColumn => this.columnPolicyFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineIDColumn => this.columnCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RaterIDColumn => this.columnRaterID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineConditionIDColumn => this.columnCompanyLineConditionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn formDescriptionColumn => this.columnformDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SingleTransactionColumn => this.columnSingleTransaction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormNumberColumn => this.columnFormNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormNameColumn => this.columnFormName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DisabledColumn => this.columnDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblRaterFormSetupsRow this[int index]
    {
      get => (dsAdminRaterForms.tblRaterFormSetupsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblRaterFormSetupsRowChangeEventHandler tblRaterFormSetupsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblRaterFormSetupsRowChangeEventHandler tblRaterFormSetupsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblRaterFormSetupsRowChangeEventHandler tblRaterFormSetupsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblRaterFormSetupsRowChangeEventHandler tblRaterFormSetupsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblRaterFormSetupsRow(dsAdminRaterForms.tblRaterFormSetupsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblRaterFormSetupsRow AddtblRaterFormSetupsRow(
      int PolicyFormID,
      int CompanyLineID,
      int RaterID,
      int CompanyLineConditionID,
      string formDescription,
      bool SingleTransaction,
      string FormNumber,
      string FormName,
      string Disabled)
    {
      dsAdminRaterForms.tblRaterFormSetupsRow row = (dsAdminRaterForms.tblRaterFormSetupsRow) this.NewRow();
      object[] objArray = new object[10]
      {
        null,
        (object) PolicyFormID,
        (object) CompanyLineID,
        (object) RaterID,
        (object) CompanyLineConditionID,
        (object) formDescription,
        (object) SingleTransaction,
        (object) FormNumber,
        (object) FormName,
        (object) Disabled
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblRaterFormSetupsRow FindBySetupID(int SetupID)
    {
      return (dsAdminRaterForms.tblRaterFormSetupsRow) this.Rows.Find(new object[1]
      {
        (object) SetupID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminRaterForms.tblRaterFormSetupsDataTable formSetupsDataTable = (dsAdminRaterForms.tblRaterFormSetupsDataTable) base.Clone();
      formSetupsDataTable.InitVars();
      return (DataTable) formSetupsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminRaterForms.tblRaterFormSetupsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnSetupID = this.Columns["SetupID"];
      this.columnPolicyFormID = this.Columns["PolicyFormID"];
      this.columnCompanyLineID = this.Columns["CompanyLineID"];
      this.columnRaterID = this.Columns["RaterID"];
      this.columnCompanyLineConditionID = this.Columns["CompanyLineConditionID"];
      this.columnformDescription = this.Columns["formDescription"];
      this.columnSingleTransaction = this.Columns["SingleTransaction"];
      this.columnFormNumber = this.Columns["FormNumber"];
      this.columnFormName = this.Columns["FormName"];
      this.columnDisabled = this.Columns["Disabled"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnSetupID = new DataColumn("SetupID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSetupID);
      this.columnPolicyFormID = new DataColumn("PolicyFormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyFormID);
      this.columnCompanyLineID = new DataColumn("CompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineID);
      this.columnRaterID = new DataColumn("RaterID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRaterID);
      this.columnCompanyLineConditionID = new DataColumn("CompanyLineConditionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineConditionID);
      this.columnformDescription = new DataColumn("formDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnformDescription);
      this.columnSingleTransaction = new DataColumn("SingleTransaction", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSingleTransaction);
      this.columnFormNumber = new DataColumn("FormNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormNumber);
      this.columnFormName = new DataColumn("FormName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormName);
      this.columnDisabled = new DataColumn("Disabled", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisabled);
      this.Constraints.Add((Constraint) new UniqueConstraint("tblRaterFormSetupsKey1", new DataColumn[1]
      {
        this.columnSetupID
      }, true));
      this.columnSetupID.AutoIncrement = true;
      this.columnSetupID.AutoIncrementSeed = -1L;
      this.columnSetupID.AutoIncrementStep = -1L;
      this.columnSetupID.AllowDBNull = false;
      this.columnSetupID.Unique = true;
      this.columnCompanyLineID.AllowDBNull = false;
      this.columnSingleTransaction.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblRaterFormSetupsRow NewtblRaterFormSetupsRow()
    {
      return (dsAdminRaterForms.tblRaterFormSetupsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminRaterForms.tblRaterFormSetupsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminRaterForms.tblRaterFormSetupsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblRaterFormSetupsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.tblRaterFormSetupsRowChangeEventHandler setupsRowChangedEvent = this.tblRaterFormSetupsRowChangedEvent;
      if (setupsRowChangedEvent == null)
        return;
      setupsRowChangedEvent((object) this, new dsAdminRaterForms.tblRaterFormSetupsRowChangeEvent((dsAdminRaterForms.tblRaterFormSetupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblRaterFormSetupsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.tblRaterFormSetupsRowChangeEventHandler rowChangingEvent = this.tblRaterFormSetupsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminRaterForms.tblRaterFormSetupsRowChangeEvent((dsAdminRaterForms.tblRaterFormSetupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblRaterFormSetupsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.tblRaterFormSetupsRowChangeEventHandler setupsRowDeletedEvent = this.tblRaterFormSetupsRowDeletedEvent;
      if (setupsRowDeletedEvent == null)
        return;
      setupsRowDeletedEvent((object) this, new dsAdminRaterForms.tblRaterFormSetupsRowChangeEvent((dsAdminRaterForms.tblRaterFormSetupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblRaterFormSetupsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.tblRaterFormSetupsRowChangeEventHandler rowDeletingEvent = this.tblRaterFormSetupsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminRaterForms.tblRaterFormSetupsRowChangeEvent((dsAdminRaterForms.tblRaterFormSetupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblRaterFormSetupsRow(dsAdminRaterForms.tblRaterFormSetupsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminRaterForms dsAdminRaterForms = new dsAdminRaterForms();
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
        FixedValue = dsAdminRaterForms.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblRaterFormSetupsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminRaterForms.GetSchemaSerializable();
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
  public class tblCompanyRatersDataTable : TypedTableBase<dsAdminRaterForms.tblCompanyRatersRow>
  {
    private DataColumn columnRatingTypeID;
    private DataColumn columnRatingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyRatersDataTable()
    {
      this.TableName = "tblCompanyRaters";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyRatersDataTable(DataTable table)
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
    protected tblCompanyRatersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RatingTypeIDColumn => this.columnRatingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RatingTypeColumn => this.columnRatingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblCompanyRatersRow this[int index]
    {
      get => (dsAdminRaterForms.tblCompanyRatersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblCompanyRatersRowChangeEventHandler tblCompanyRatersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblCompanyRatersRowChangeEventHandler tblCompanyRatersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblCompanyRatersRowChangeEventHandler tblCompanyRatersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblCompanyRatersRowChangeEventHandler tblCompanyRatersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyRatersRow(dsAdminRaterForms.tblCompanyRatersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblCompanyRatersRow AddtblCompanyRatersRow(
      int RatingTypeID,
      string RatingType)
    {
      dsAdminRaterForms.tblCompanyRatersRow row = (dsAdminRaterForms.tblCompanyRatersRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) RatingTypeID,
        (object) RatingType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblCompanyRatersRow FindByRatingTypeID(int RatingTypeID)
    {
      return (dsAdminRaterForms.tblCompanyRatersRow) this.Rows.Find(new object[1]
      {
        (object) RatingTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminRaterForms.tblCompanyRatersDataTable companyRatersDataTable = (dsAdminRaterForms.tblCompanyRatersDataTable) base.Clone();
      companyRatersDataTable.InitVars();
      return (DataTable) companyRatersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminRaterForms.tblCompanyRatersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnRatingTypeID = this.Columns["RatingTypeID"];
      this.columnRatingType = this.Columns["RatingType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnRatingTypeID = new DataColumn("RatingTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRatingTypeID);
      this.columnRatingType = new DataColumn("RatingType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRatingType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnRatingTypeID
      }, true));
      this.columnRatingTypeID.AllowDBNull = false;
      this.columnRatingTypeID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblCompanyRatersRow NewtblCompanyRatersRow()
    {
      return (dsAdminRaterForms.tblCompanyRatersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminRaterForms.tblCompanyRatersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminRaterForms.tblCompanyRatersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyRatersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.tblCompanyRatersRowChangeEventHandler ratersRowChangedEvent = this.tblCompanyRatersRowChangedEvent;
      if (ratersRowChangedEvent == null)
        return;
      ratersRowChangedEvent((object) this, new dsAdminRaterForms.tblCompanyRatersRowChangeEvent((dsAdminRaterForms.tblCompanyRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyRatersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.tblCompanyRatersRowChangeEventHandler rowChangingEvent = this.tblCompanyRatersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminRaterForms.tblCompanyRatersRowChangeEvent((dsAdminRaterForms.tblCompanyRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyRatersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.tblCompanyRatersRowChangeEventHandler ratersRowDeletedEvent = this.tblCompanyRatersRowDeletedEvent;
      if (ratersRowDeletedEvent == null)
        return;
      ratersRowDeletedEvent((object) this, new dsAdminRaterForms.tblCompanyRatersRowChangeEvent((dsAdminRaterForms.tblCompanyRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyRatersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.tblCompanyRatersRowChangeEventHandler rowDeletingEvent = this.tblCompanyRatersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminRaterForms.tblCompanyRatersRowChangeEvent((dsAdminRaterForms.tblCompanyRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyRatersRow(dsAdminRaterForms.tblCompanyRatersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminRaterForms dsAdminRaterForms = new dsAdminRaterForms();
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
        FixedValue = dsAdminRaterForms.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyRatersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminRaterForms.GetSchemaSerializable();
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
  public class tblConditionsDataTable : TypedTableBase<dsAdminRaterForms.tblConditionsRow>
  {
    private DataColumn columnConditionID;
    private DataColumn columnCondition;

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
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblConditionsRow this[int index]
    {
      get => (dsAdminRaterForms.tblConditionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblConditionsRowChangeEventHandler tblConditionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblConditionsRowChangeEventHandler tblConditionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblConditionsRowChangeEventHandler tblConditionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAdminRaterForms.tblConditionsRowChangeEventHandler tblConditionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblConditionsRow(dsAdminRaterForms.tblConditionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblConditionsRow AddtblConditionsRow(string Condition)
    {
      dsAdminRaterForms.tblConditionsRow row = (dsAdminRaterForms.tblConditionsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) Condition
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblConditionsRow FindByConditionID(int ConditionID)
    {
      return (dsAdminRaterForms.tblConditionsRow) this.Rows.Find(new object[1]
      {
        (object) ConditionID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminRaterForms.tblConditionsDataTable conditionsDataTable = (dsAdminRaterForms.tblConditionsDataTable) base.Clone();
      conditionsDataTable.InitVars();
      return (DataTable) conditionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminRaterForms.tblConditionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnConditionID = this.Columns["ConditionID"];
      this.columnCondition = this.Columns["Condition"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnConditionID = new DataColumn("ConditionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConditionID);
      this.columnCondition = new DataColumn("Condition", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCondition);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnConditionID
      }, true));
      this.columnConditionID.AutoIncrement = true;
      this.columnConditionID.AutoIncrementSeed = -1L;
      this.columnConditionID.AutoIncrementStep = -1L;
      this.columnConditionID.AllowDBNull = false;
      this.columnConditionID.ReadOnly = true;
      this.columnConditionID.Unique = true;
      this.columnCondition.AllowDBNull = false;
      this.columnCondition.MaxLength = 1000;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblConditionsRow NewtblConditionsRow()
    {
      return (dsAdminRaterForms.tblConditionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminRaterForms.tblConditionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminRaterForms.tblConditionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblConditionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRaterForms.tblConditionsRowChangeEventHandler conditionsRowChangedEvent = this.tblConditionsRowChangedEvent;
      if (conditionsRowChangedEvent == null)
        return;
      conditionsRowChangedEvent((object) this, new dsAdminRaterForms.tblConditionsRowChangeEvent((dsAdminRaterForms.tblConditionsRow) e.Row, e.Action));
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
      dsAdminRaterForms.tblConditionsRowChangeEventHandler rowChangingEvent = this.tblConditionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminRaterForms.tblConditionsRowChangeEvent((dsAdminRaterForms.tblConditionsRow) e.Row, e.Action));
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
      dsAdminRaterForms.tblConditionsRowChangeEventHandler conditionsRowDeletedEvent = this.tblConditionsRowDeletedEvent;
      if (conditionsRowDeletedEvent == null)
        return;
      conditionsRowDeletedEvent((object) this, new dsAdminRaterForms.tblConditionsRowChangeEvent((dsAdminRaterForms.tblConditionsRow) e.Row, e.Action));
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
      dsAdminRaterForms.tblConditionsRowChangeEventHandler rowDeletingEvent = this.tblConditionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminRaterForms.tblConditionsRowChangeEvent((dsAdminRaterForms.tblConditionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblConditionsRow(dsAdminRaterForms.tblConditionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminRaterForms dsAdminRaterForms = new dsAdminRaterForms();
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
        FixedValue = dsAdminRaterForms.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblConditionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAdminRaterForms.GetSchemaSerializable();
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

  public class ConditionsRow : DataRow
  {
    private dsAdminRaterForms.ConditionsDataTable tableConditions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal ConditionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableConditions = (dsAdminRaterForms.ConditionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Condition
    {
      get => Conversions.ToString(this[this.tableConditions.ConditionColumn]);
      set => this[this.tableConditions.ConditionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RaterID
    {
      get => Conversions.ToInteger(this[this.tableConditions.RaterIDColumn]);
      set => this[this.tableConditions.RaterIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ConditionalID
    {
      get => Conversions.ToInteger(this[this.tableConditions.ConditionalIDColumn]);
      set => this[this.tableConditions.ConditionalIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ConditionalType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableConditions.ConditionalTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConditionalType' in table 'Conditions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableConditions.ConditionalTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsConditionalTypeNull() => this.IsNull(this.tableConditions.ConditionalTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetConditionalTypeNull()
    {
      this[this.tableConditions.ConditionalTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblRaterFormAutomationRow[] GettblRaterFormAutomationRows()
    {
      return this.Table.ChildRelations["Conditions_tblRaterFormAutomation"] != null ? (dsAdminRaterForms.tblRaterFormAutomationRow[]) this.GetChildRows(this.Table.ChildRelations["Conditions_tblRaterFormAutomation"]) : new dsAdminRaterForms.tblRaterFormAutomationRow[0];
    }
  }

  public class OperatorsRow : DataRow
  {
    private dsAdminRaterForms.OperatorsDataTable tableOperators;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal OperatorsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOperators = (dsAdminRaterForms.OperatorsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string _Operator
    {
      get => Conversions.ToString(this[this.tableOperators.OperatorColumn]);
      set => this[this.tableOperators.OperatorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOperators.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'Operators' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOperators.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tableOperators.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tableOperators.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblRaterFormAutomationRow[] GettblRaterFormAutomationRows()
    {
      return this.Table.ChildRelations["Operators_tblRaterFormAutomation"] != null ? (dsAdminRaterForms.tblRaterFormAutomationRow[]) this.GetChildRows(this.Table.ChildRelations["Operators_tblRaterFormAutomation"]) : new dsAdminRaterForms.tblRaterFormAutomationRow[0];
    }
  }

  public class tblRaterFormAutomationRow : DataRow
  {
    private dsAdminRaterForms.tblRaterFormAutomationDataTable tabletblRaterFormAutomation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblRaterFormAutomationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblRaterFormAutomation = (dsAdminRaterForms.tblRaterFormAutomationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ConditionalID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblRaterFormAutomation.ConditionalIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConditionalID' in table 'tblRaterFormAutomation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormAutomation.ConditionalIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string _Operator
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblRaterFormAutomation.OperatorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Operator' in table 'tblRaterFormAutomation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormAutomation.OperatorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Amount
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblRaterFormAutomation.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Amount' in table 'tblRaterFormAutomation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormAutomation.AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int SetupID
    {
      get => Conversions.ToInteger(this[this.tabletblRaterFormAutomation.SetupIDColumn]);
      set => this[this.tabletblRaterFormAutomation.SetupIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ConditionID
    {
      get => Conversions.ToInteger(this[this.tabletblRaterFormAutomation.ConditionIDColumn]);
      set => this[this.tabletblRaterFormAutomation.ConditionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RaterID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblRaterFormAutomation.RaterIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RaterID' in table 'tblRaterFormAutomation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormAutomation.RaterIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool FormVisibility
    {
      get => Conversions.ToBoolean(this[this.tabletblRaterFormAutomation.FormVisibilityColumn]);
      set => this[this.tabletblRaterFormAutomation.FormVisibilityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblRaterFormSetupsRow tblRaterFormSetupsRow
    {
      get
      {
        return (dsAdminRaterForms.tblRaterFormSetupsRow) this.GetParentRow(this.Table.ParentRelations["tblRaterFormSetups_tblRaterFormAutomation"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblRaterFormSetups_tblRaterFormAutomation"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.OperatorsRow OperatorsRow
    {
      get
      {
        return (dsAdminRaterForms.OperatorsRow) this.GetParentRow(this.Table.ParentRelations["Operators_tblRaterFormAutomation"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["Operators_tblRaterFormAutomation"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.ConditionsRow ConditionsRowParent
    {
      get
      {
        return (dsAdminRaterForms.ConditionsRow) this.GetParentRow(this.Table.ParentRelations["Conditions_tblRaterFormAutomation"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["Conditions_tblRaterFormAutomation"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsConditionalIDNull()
    {
      return this.IsNull(this.tabletblRaterFormAutomation.ConditionalIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetConditionalIDNull()
    {
      this[this.tabletblRaterFormAutomation.ConditionalIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Is_OperatorNull() => this.IsNull(this.tabletblRaterFormAutomation.OperatorColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void Set_OperatorNull()
    {
      this[this.tabletblRaterFormAutomation.OperatorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAmountNull() => this.IsNull(this.tabletblRaterFormAutomation.AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAmountNull()
    {
      this[this.tabletblRaterFormAutomation.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRaterIDNull() => this.IsNull(this.tabletblRaterFormAutomation.RaterIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRaterIDNull()
    {
      this[this.tabletblRaterFormAutomation.RaterIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblPolicyFormsRow : DataRow
  {
    private dsAdminRaterForms.tblPolicyFormsDataTable tabletblPolicyForms;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblPolicyFormsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblPolicyForms = (dsAdminRaterForms.tblPolicyFormsDataTable) this.Table;
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
    public bool Disabled
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyForms.DisabledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Disabled' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.DisabledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDisabledNull() => this.IsNull(this.tabletblPolicyForms.DisabledColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDisabledNull()
    {
      this[this.tabletblPolicyForms.DisabledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblRaterFormSetupsRow : DataRow
  {
    private dsAdminRaterForms.tblRaterFormSetupsDataTable tabletblRaterFormSetups;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblRaterFormSetupsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblRaterFormSetups = (dsAdminRaterForms.tblRaterFormSetupsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int SetupID
    {
      get => Conversions.ToInteger(this[this.tabletblRaterFormSetups.SetupIDColumn]);
      set => this[this.tabletblRaterFormSetups.SetupIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyFormID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblRaterFormSetups.PolicyFormIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyFormID' in table 'tblRaterFormSetups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormSetups.PolicyFormIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CompanyLineID
    {
      get => Conversions.ToInteger(this[this.tabletblRaterFormSetups.CompanyLineIDColumn]);
      set => this[this.tabletblRaterFormSetups.CompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RaterID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblRaterFormSetups.RaterIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RaterID' in table 'tblRaterFormSetups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormSetups.RaterIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CompanyLineConditionID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblRaterFormSetups.CompanyLineConditionIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLineConditionID' in table 'tblRaterFormSetups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormSetups.CompanyLineConditionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string formDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblRaterFormSetups.formDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'formDescription' in table 'tblRaterFormSetups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormSetups.formDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool SingleTransaction
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblRaterFormSetups.SingleTransactionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SingleTransaction' in table 'tblRaterFormSetups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormSetups.SingleTransactionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FormNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblRaterFormSetups.FormNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FormNumber' in table 'tblRaterFormSetups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormSetups.FormNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FormName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblRaterFormSetups.FormNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FormName' in table 'tblRaterFormSetups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormSetups.FormNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Disabled
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblRaterFormSetups.DisabledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Disabled' in table 'tblRaterFormSetups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormSetups.DisabledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyFormIDNull()
    {
      return this.IsNull(this.tabletblRaterFormSetups.PolicyFormIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyFormIDNull()
    {
      this[this.tabletblRaterFormSetups.PolicyFormIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRaterIDNull() => this.IsNull(this.tabletblRaterFormSetups.RaterIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRaterIDNull()
    {
      this[this.tabletblRaterFormSetups.RaterIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyLineConditionIDNull()
    {
      return this.IsNull(this.tabletblRaterFormSetups.CompanyLineConditionIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyLineConditionIDNull()
    {
      this[this.tabletblRaterFormSetups.CompanyLineConditionIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsformDescriptionNull()
    {
      return this.IsNull(this.tabletblRaterFormSetups.formDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetformDescriptionNull()
    {
      this[this.tabletblRaterFormSetups.formDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSingleTransactionNull()
    {
      return this.IsNull(this.tabletblRaterFormSetups.SingleTransactionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSingleTransactionNull()
    {
      this[this.tabletblRaterFormSetups.SingleTransactionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFormNumberNull() => this.IsNull(this.tabletblRaterFormSetups.FormNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFormNumberNull()
    {
      this[this.tabletblRaterFormSetups.FormNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFormNameNull() => this.IsNull(this.tabletblRaterFormSetups.FormNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFormNameNull()
    {
      this[this.tabletblRaterFormSetups.FormNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDisabledNull() => this.IsNull(this.tabletblRaterFormSetups.DisabledColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDisabledNull()
    {
      this[this.tabletblRaterFormSetups.DisabledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblRaterFormAutomationRow[] GettblRaterFormAutomationRows()
    {
      return this.Table.ChildRelations["tblRaterFormSetups_tblRaterFormAutomation"] != null ? (dsAdminRaterForms.tblRaterFormAutomationRow[]) this.GetChildRows(this.Table.ChildRelations["tblRaterFormSetups_tblRaterFormAutomation"]) : new dsAdminRaterForms.tblRaterFormAutomationRow[0];
    }
  }

  public class tblCompanyRatersRow : DataRow
  {
    private dsAdminRaterForms.tblCompanyRatersDataTable tabletblCompanyRaters;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyRatersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyRaters = (dsAdminRaterForms.tblCompanyRatersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RatingTypeID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyRaters.RatingTypeIDColumn]);
      set => this[this.tabletblCompanyRaters.RatingTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string RatingType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyRaters.RatingTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RatingType' in table 'tblCompanyRaters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyRaters.RatingTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRatingTypeNull() => this.IsNull(this.tabletblCompanyRaters.RatingTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRatingTypeNull()
    {
      this[this.tabletblCompanyRaters.RatingTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblConditionsRow : DataRow
  {
    private dsAdminRaterForms.tblConditionsDataTable tabletblConditions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblConditionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblConditions = (dsAdminRaterForms.tblConditionsDataTable) this.Table;
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
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class ConditionsRowChangeEvent : EventArgs
  {
    private dsAdminRaterForms.ConditionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public ConditionsRowChangeEvent(dsAdminRaterForms.ConditionsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.ConditionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class OperatorsRowChangeEvent : EventArgs
  {
    private dsAdminRaterForms.OperatorsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public OperatorsRowChangeEvent(dsAdminRaterForms.OperatorsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.OperatorsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblRaterFormAutomationRowChangeEvent : EventArgs
  {
    private dsAdminRaterForms.tblRaterFormAutomationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblRaterFormAutomationRowChangeEvent(
      dsAdminRaterForms.tblRaterFormAutomationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblRaterFormAutomationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblPolicyFormsRowChangeEvent : EventArgs
  {
    private dsAdminRaterForms.tblPolicyFormsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblPolicyFormsRowChangeEvent(
      dsAdminRaterForms.tblPolicyFormsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblPolicyFormsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblRaterFormSetupsRowChangeEvent : EventArgs
  {
    private dsAdminRaterForms.tblRaterFormSetupsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblRaterFormSetupsRowChangeEvent(
      dsAdminRaterForms.tblRaterFormSetupsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblRaterFormSetupsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyRatersRowChangeEvent : EventArgs
  {
    private dsAdminRaterForms.tblCompanyRatersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyRatersRowChangeEvent(
      dsAdminRaterForms.tblCompanyRatersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblCompanyRatersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblConditionsRowChangeEvent : EventArgs
  {
    private dsAdminRaterForms.tblConditionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblConditionsRowChangeEvent(dsAdminRaterForms.tblConditionsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAdminRaterForms.tblConditionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
