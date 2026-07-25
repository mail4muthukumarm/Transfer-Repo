// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.dsCopyRaterCond
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
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCopyRaterCond")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCopyRaterCond : DataSet
{
  private dsCopyRaterCond.tblRaterFormSetupsDataTable tabletblRaterFormSetups;
  private dsCopyRaterCond.tblCompanyRatersDataTable tabletblCompanyRaters;
  private dsCopyRaterCond.tblPolicyFormsDataTable tabletblPolicyForms;
  private dsCopyRaterCond.lstStatesDataTable tablelstStates;
  private dsCopyRaterCond.OperatorsDataTable tableOperators;
  private dsCopyRaterCond.tblConditionsDataTable tabletblConditions;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsCopyRaterCond()
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
  protected dsCopyRaterCond(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblRaterFormSetups)] != null)
          base.Tables.Add((DataTable) new dsCopyRaterCond.tblRaterFormSetupsDataTable(dataSet.Tables[nameof (tblRaterFormSetups)]));
        if (dataSet.Tables[nameof (tblCompanyRaters)] != null)
          base.Tables.Add((DataTable) new dsCopyRaterCond.tblCompanyRatersDataTable(dataSet.Tables[nameof (tblCompanyRaters)]));
        if (dataSet.Tables[nameof (tblPolicyForms)] != null)
          base.Tables.Add((DataTable) new dsCopyRaterCond.tblPolicyFormsDataTable(dataSet.Tables[nameof (tblPolicyForms)]));
        if (dataSet.Tables[nameof (lstStates)] != null)
          base.Tables.Add((DataTable) new dsCopyRaterCond.lstStatesDataTable(dataSet.Tables[nameof (lstStates)]));
        if (dataSet.Tables[nameof (Operators)] != null)
          base.Tables.Add((DataTable) new dsCopyRaterCond.OperatorsDataTable(dataSet.Tables[nameof (Operators)]));
        if (dataSet.Tables[nameof (tblConditions)] != null)
          base.Tables.Add((DataTable) new dsCopyRaterCond.tblConditionsDataTable(dataSet.Tables[nameof (tblConditions)]));
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
  public dsCopyRaterCond.tblRaterFormSetupsDataTable tblRaterFormSetups
  {
    get => this.tabletblRaterFormSetups;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCopyRaterCond.tblCompanyRatersDataTable tblCompanyRaters => this.tabletblCompanyRaters;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCopyRaterCond.tblPolicyFormsDataTable tblPolicyForms => this.tabletblPolicyForms;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCopyRaterCond.lstStatesDataTable lstStates => this.tablelstStates;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCopyRaterCond.OperatorsDataTable Operators => this.tableOperators;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCopyRaterCond.tblConditionsDataTable tblConditions => this.tabletblConditions;

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
    dsCopyRaterCond dsCopyRaterCond = (dsCopyRaterCond) base.Clone();
    dsCopyRaterCond.InitVars();
    dsCopyRaterCond.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsCopyRaterCond;
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
      if (dataSet.Tables["tblRaterFormSetups"] != null)
        base.Tables.Add((DataTable) new dsCopyRaterCond.tblRaterFormSetupsDataTable(dataSet.Tables["tblRaterFormSetups"]));
      if (dataSet.Tables["tblCompanyRaters"] != null)
        base.Tables.Add((DataTable) new dsCopyRaterCond.tblCompanyRatersDataTable(dataSet.Tables["tblCompanyRaters"]));
      if (dataSet.Tables["tblPolicyForms"] != null)
        base.Tables.Add((DataTable) new dsCopyRaterCond.tblPolicyFormsDataTable(dataSet.Tables["tblPolicyForms"]));
      if (dataSet.Tables["lstStates"] != null)
        base.Tables.Add((DataTable) new dsCopyRaterCond.lstStatesDataTable(dataSet.Tables["lstStates"]));
      if (dataSet.Tables["Operators"] != null)
        base.Tables.Add((DataTable) new dsCopyRaterCond.OperatorsDataTable(dataSet.Tables["Operators"]));
      if (dataSet.Tables["tblConditions"] != null)
        base.Tables.Add((DataTable) new dsCopyRaterCond.tblConditionsDataTable(dataSet.Tables["tblConditions"]));
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
    this.tabletblRaterFormSetups = (dsCopyRaterCond.tblRaterFormSetupsDataTable) base.Tables["tblRaterFormSetups"];
    if (initTable && this.tabletblRaterFormSetups != null)
      this.tabletblRaterFormSetups.InitVars();
    this.tabletblCompanyRaters = (dsCopyRaterCond.tblCompanyRatersDataTable) base.Tables["tblCompanyRaters"];
    if (initTable && this.tabletblCompanyRaters != null)
      this.tabletblCompanyRaters.InitVars();
    this.tabletblPolicyForms = (dsCopyRaterCond.tblPolicyFormsDataTable) base.Tables["tblPolicyForms"];
    if (initTable && this.tabletblPolicyForms != null)
      this.tabletblPolicyForms.InitVars();
    this.tablelstStates = (dsCopyRaterCond.lstStatesDataTable) base.Tables["lstStates"];
    if (initTable && this.tablelstStates != null)
      this.tablelstStates.InitVars();
    this.tableOperators = (dsCopyRaterCond.OperatorsDataTable) base.Tables["Operators"];
    if (initTable && this.tableOperators != null)
      this.tableOperators.InitVars();
    this.tabletblConditions = (dsCopyRaterCond.tblConditionsDataTable) base.Tables["tblConditions"];
    if (!initTable || this.tabletblConditions == null)
      return;
    this.tabletblConditions.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCopyRaterCond);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsCopyRaterCond.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblRaterFormSetups = new dsCopyRaterCond.tblRaterFormSetupsDataTable();
    base.Tables.Add((DataTable) this.tabletblRaterFormSetups);
    this.tabletblCompanyRaters = new dsCopyRaterCond.tblCompanyRatersDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyRaters);
    this.tabletblPolicyForms = new dsCopyRaterCond.tblPolicyFormsDataTable();
    base.Tables.Add((DataTable) this.tabletblPolicyForms);
    this.tablelstStates = new dsCopyRaterCond.lstStatesDataTable();
    base.Tables.Add((DataTable) this.tablelstStates);
    this.tableOperators = new dsCopyRaterCond.OperatorsDataTable();
    base.Tables.Add((DataTable) this.tableOperators);
    this.tabletblConditions = new dsCopyRaterCond.tblConditionsDataTable();
    base.Tables.Add((DataTable) this.tabletblConditions);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblRaterFormSetups() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyRaters() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblPolicyForms() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstStates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeOperators() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblConditions() => false;

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
    dsCopyRaterCond dsCopyRaterCond = new dsCopyRaterCond();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsCopyRaterCond.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsCopyRaterCond.GetSchemaSerializable();
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
  public delegate void tblRaterFormSetupsRowChangeEventHandler(
    object sender,
    dsCopyRaterCond.tblRaterFormSetupsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblCompanyRatersRowChangeEventHandler(
    object sender,
    dsCopyRaterCond.tblCompanyRatersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblPolicyFormsRowChangeEventHandler(
    object sender,
    dsCopyRaterCond.tblPolicyFormsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstStatesRowChangeEventHandler(
    object sender,
    dsCopyRaterCond.lstStatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void OperatorsRowChangeEventHandler(
    object sender,
    dsCopyRaterCond.OperatorsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblConditionsRowChangeEventHandler(
    object sender,
    dsCopyRaterCond.tblConditionsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblRaterFormSetupsDataTable : TypedTableBase<dsCopyRaterCond.tblRaterFormSetupsRow>
  {
    private DataColumn columnSetupID;
    private DataColumn columnPolicyFormID;
    private DataColumn columnRaterID;
    private DataColumn columnCondition;
    private DataColumn columnConditionalID;
    private DataColumn columnAmount;
    private DataColumn columnOperator;
    private DataColumn columnCompanyLineConditionID;
    private DataColumn columnSelect;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblRaterFormSetupsDataTable()
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.tblRaterFormSetupsDataTable_ColumnChanging);
      this.TableName = "tblRaterFormSetups";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblRaterFormSetupsDataTable(DataTable table)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.tblRaterFormSetupsDataTable_ColumnChanging);
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
    protected tblRaterFormSetupsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.tblRaterFormSetupsDataTable_ColumnChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SetupIDColumn => this.columnSetupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PolicyFormIDColumn => this.columnPolicyFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RaterIDColumn => this.columnRaterID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ConditionColumn => this.columnCondition;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ConditionalIDColumn => this.columnConditionalID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AmountColumn => this.columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OperatorColumn => this.columnOperator;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineConditionIDColumn => this.columnCompanyLineConditionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SelectColumn => this.columnSelect;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblRaterFormSetupsRow this[int index]
    {
      get => (dsCopyRaterCond.tblRaterFormSetupsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblRaterFormSetupsRowChangeEventHandler tblRaterFormSetupsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblRaterFormSetupsRowChangeEventHandler tblRaterFormSetupsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblRaterFormSetupsRowChangeEventHandler tblRaterFormSetupsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblRaterFormSetupsRowChangeEventHandler tblRaterFormSetupsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblRaterFormSetupsRow(dsCopyRaterCond.tblRaterFormSetupsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblRaterFormSetupsRow AddtblRaterFormSetupsRow(
      int PolicyFormID,
      int RaterID,
      string Condition,
      int ConditionalID,
      string Amount,
      string _Operator,
      int CompanyLineConditionID,
      bool _Select)
    {
      dsCopyRaterCond.tblRaterFormSetupsRow row = (dsCopyRaterCond.tblRaterFormSetupsRow) this.NewRow();
      object[] objArray = new object[9]
      {
        null,
        (object) PolicyFormID,
        (object) RaterID,
        (object) Condition,
        (object) ConditionalID,
        (object) Amount,
        (object) _Operator,
        (object) CompanyLineConditionID,
        (object) _Select
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCopyRaterCond.tblRaterFormSetupsDataTable formSetupsDataTable = (dsCopyRaterCond.tblRaterFormSetupsDataTable) base.Clone();
      formSetupsDataTable.InitVars();
      return (DataTable) formSetupsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCopyRaterCond.tblRaterFormSetupsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnSetupID = this.Columns["SetupID"];
      this.columnPolicyFormID = this.Columns["PolicyFormID"];
      this.columnRaterID = this.Columns["RaterID"];
      this.columnCondition = this.Columns["Condition"];
      this.columnConditionalID = this.Columns["ConditionalID"];
      this.columnAmount = this.Columns["Amount"];
      this.columnOperator = this.Columns["Operator"];
      this.columnCompanyLineConditionID = this.Columns["CompanyLineConditionID"];
      this.columnSelect = this.Columns["Select"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnSetupID = new DataColumn("SetupID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSetupID);
      this.columnPolicyFormID = new DataColumn("PolicyFormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyFormID);
      this.columnRaterID = new DataColumn("RaterID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRaterID);
      this.columnCondition = new DataColumn("Condition", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCondition);
      this.columnConditionalID = new DataColumn("ConditionalID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConditionalID);
      this.columnAmount = new DataColumn("Amount", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnOperator = new DataColumn("Operator", typeof (string), (string) null, MappingType.Element);
      this.columnOperator.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "OperatorColumn");
      this.columnOperator.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnOperator");
      this.columnOperator.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Operator");
      this.Columns.Add(this.columnOperator);
      this.columnCompanyLineConditionID = new DataColumn("CompanyLineConditionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineConditionID);
      this.columnSelect = new DataColumn("Select", typeof (bool), (string) null, MappingType.Element);
      this.columnSelect.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "SelectColumn");
      this.columnSelect.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnSelect");
      this.columnSelect.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Select");
      this.Columns.Add(this.columnSelect);
      this.columnSetupID.AutoIncrement = true;
      this.columnSetupID.AutoIncrementSeed = -1L;
      this.columnSetupID.AutoIncrementStep = -1L;
      this.columnSetupID.AllowDBNull = false;
      this.columnSetupID.ReadOnly = true;
      this.columnRaterID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblRaterFormSetupsRow NewtblRaterFormSetupsRow()
    {
      return (dsCopyRaterCond.tblRaterFormSetupsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCopyRaterCond.tblRaterFormSetupsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCopyRaterCond.tblRaterFormSetupsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblRaterFormSetupsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblRaterFormSetupsRowChangeEventHandler setupsRowChangedEvent = this.tblRaterFormSetupsRowChangedEvent;
      if (setupsRowChangedEvent == null)
        return;
      setupsRowChangedEvent((object) this, new dsCopyRaterCond.tblRaterFormSetupsRowChangeEvent((dsCopyRaterCond.tblRaterFormSetupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblRaterFormSetupsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblRaterFormSetupsRowChangeEventHandler rowChangingEvent = this.tblRaterFormSetupsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCopyRaterCond.tblRaterFormSetupsRowChangeEvent((dsCopyRaterCond.tblRaterFormSetupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblRaterFormSetupsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblRaterFormSetupsRowChangeEventHandler setupsRowDeletedEvent = this.tblRaterFormSetupsRowDeletedEvent;
      if (setupsRowDeletedEvent == null)
        return;
      setupsRowDeletedEvent((object) this, new dsCopyRaterCond.tblRaterFormSetupsRowChangeEvent((dsCopyRaterCond.tblRaterFormSetupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblRaterFormSetupsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblRaterFormSetupsRowChangeEventHandler rowDeletingEvent = this.tblRaterFormSetupsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCopyRaterCond.tblRaterFormSetupsRowChangeEvent((dsCopyRaterCond.tblRaterFormSetupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblRaterFormSetupsRow(dsCopyRaterCond.tblRaterFormSetupsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCopyRaterCond dsCopyRaterCond = new dsCopyRaterCond();
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
        FixedValue = dsCopyRaterCond.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblRaterFormSetupsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCopyRaterCond.GetSchemaSerializable();
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

    private void tblRaterFormSetupsDataTable_ColumnChanging(
      object sender,
      DataColumnChangeEventArgs e)
    {
      Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Column.ColumnName, this.PolicyFormIDColumn.ColumnName, false);
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyRatersDataTable : TypedTableBase<dsCopyRaterCond.tblCompanyRatersRow>
  {
    private DataColumn columnRatingTypeID;
    private DataColumn columnRatingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyRatersDataTable()
    {
      this.TableName = "tblCompanyRaters";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblCompanyRatersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RatingTypeIDColumn => this.columnRatingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RatingTypeColumn => this.columnRatingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblCompanyRatersRow this[int index]
    {
      get => (dsCopyRaterCond.tblCompanyRatersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblCompanyRatersRowChangeEventHandler tblCompanyRatersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblCompanyRatersRowChangeEventHandler tblCompanyRatersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblCompanyRatersRowChangeEventHandler tblCompanyRatersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblCompanyRatersRowChangeEventHandler tblCompanyRatersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyRatersRow(dsCopyRaterCond.tblCompanyRatersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblCompanyRatersRow AddtblCompanyRatersRow(
      int RatingTypeID,
      string RatingType)
    {
      dsCopyRaterCond.tblCompanyRatersRow row = (dsCopyRaterCond.tblCompanyRatersRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblCompanyRatersRow FindByRatingTypeID(int RatingTypeID)
    {
      return (dsCopyRaterCond.tblCompanyRatersRow) this.Rows.Find(new object[1]
      {
        (object) RatingTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCopyRaterCond.tblCompanyRatersDataTable companyRatersDataTable = (dsCopyRaterCond.tblCompanyRatersDataTable) base.Clone();
      companyRatersDataTable.InitVars();
      return (DataTable) companyRatersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCopyRaterCond.tblCompanyRatersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnRatingTypeID = this.Columns["RatingTypeID"];
      this.columnRatingType = this.Columns["RatingType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblCompanyRatersRow NewtblCompanyRatersRow()
    {
      return (dsCopyRaterCond.tblCompanyRatersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCopyRaterCond.tblCompanyRatersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCopyRaterCond.tblCompanyRatersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyRatersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblCompanyRatersRowChangeEventHandler ratersRowChangedEvent = this.tblCompanyRatersRowChangedEvent;
      if (ratersRowChangedEvent == null)
        return;
      ratersRowChangedEvent((object) this, new dsCopyRaterCond.tblCompanyRatersRowChangeEvent((dsCopyRaterCond.tblCompanyRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyRatersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblCompanyRatersRowChangeEventHandler rowChangingEvent = this.tblCompanyRatersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCopyRaterCond.tblCompanyRatersRowChangeEvent((dsCopyRaterCond.tblCompanyRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyRatersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblCompanyRatersRowChangeEventHandler ratersRowDeletedEvent = this.tblCompanyRatersRowDeletedEvent;
      if (ratersRowDeletedEvent == null)
        return;
      ratersRowDeletedEvent((object) this, new dsCopyRaterCond.tblCompanyRatersRowChangeEvent((dsCopyRaterCond.tblCompanyRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyRatersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblCompanyRatersRowChangeEventHandler rowDeletingEvent = this.tblCompanyRatersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCopyRaterCond.tblCompanyRatersRowChangeEvent((dsCopyRaterCond.tblCompanyRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyRatersRow(dsCopyRaterCond.tblCompanyRatersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCopyRaterCond dsCopyRaterCond = new dsCopyRaterCond();
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
        FixedValue = dsCopyRaterCond.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyRatersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCopyRaterCond.GetSchemaSerializable();
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
  public class tblPolicyFormsDataTable : TypedTableBase<dsCopyRaterCond.tblPolicyFormsRow>
  {
    private DataColumn columnFormID;
    private DataColumn columnFormName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblPolicyFormsDataTable()
    {
      this.TableName = "tblPolicyForms";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblPolicyFormsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FormIDColumn => this.columnFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FormNameColumn => this.columnFormName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblPolicyFormsRow this[int index]
    {
      get => (dsCopyRaterCond.tblPolicyFormsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblPolicyFormsRow(dsCopyRaterCond.tblPolicyFormsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblPolicyFormsRow AddtblPolicyFormsRow(int FormID, string FormName)
    {
      dsCopyRaterCond.tblPolicyFormsRow row = (dsCopyRaterCond.tblPolicyFormsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) FormID,
        (object) FormName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblPolicyFormsRow FindByFormID(int FormID)
    {
      return (dsCopyRaterCond.tblPolicyFormsRow) this.Rows.Find(new object[1]
      {
        (object) FormID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCopyRaterCond.tblPolicyFormsDataTable policyFormsDataTable = (dsCopyRaterCond.tblPolicyFormsDataTable) base.Clone();
      policyFormsDataTable.InitVars();
      return (DataTable) policyFormsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCopyRaterCond.tblPolicyFormsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnFormID = this.Columns["FormID"];
      this.columnFormName = this.Columns["FormName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnFormID = new DataColumn("FormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormID);
      this.columnFormName = new DataColumn("FormName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormName);
      this.Constraints.Add((Constraint) new UniqueConstraint("tblPolicyFormsKey1", new DataColumn[1]
      {
        this.columnFormID
      }, true));
      this.columnFormID.AllowDBNull = false;
      this.columnFormID.Unique = true;
      this.columnFormName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblPolicyFormsRow NewtblPolicyFormsRow()
    {
      return (dsCopyRaterCond.tblPolicyFormsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCopyRaterCond.tblPolicyFormsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCopyRaterCond.tblPolicyFormsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFormsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblPolicyFormsRowChangeEventHandler formsRowChangedEvent = this.tblPolicyFormsRowChangedEvent;
      if (formsRowChangedEvent == null)
        return;
      formsRowChangedEvent((object) this, new dsCopyRaterCond.tblPolicyFormsRowChangeEvent((dsCopyRaterCond.tblPolicyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFormsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblPolicyFormsRowChangeEventHandler rowChangingEvent = this.tblPolicyFormsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCopyRaterCond.tblPolicyFormsRowChangeEvent((dsCopyRaterCond.tblPolicyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFormsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblPolicyFormsRowChangeEventHandler formsRowDeletedEvent = this.tblPolicyFormsRowDeletedEvent;
      if (formsRowDeletedEvent == null)
        return;
      formsRowDeletedEvent((object) this, new dsCopyRaterCond.tblPolicyFormsRowChangeEvent((dsCopyRaterCond.tblPolicyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFormsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblPolicyFormsRowChangeEventHandler rowDeletingEvent = this.tblPolicyFormsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCopyRaterCond.tblPolicyFormsRowChangeEvent((dsCopyRaterCond.tblPolicyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblPolicyFormsRow(dsCopyRaterCond.tblPolicyFormsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCopyRaterCond dsCopyRaterCond = new dsCopyRaterCond();
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
        FixedValue = dsCopyRaterCond.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblPolicyFormsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCopyRaterCond.GetSchemaSerializable();
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
  public class lstStatesDataTable : TypedTableBase<dsCopyRaterCond.lstStatesRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnState;
    private DataColumn columnSelect;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstStatesDataTable()
    {
      this.TableName = "lstStates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected lstStatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SelectColumn => this.columnSelect;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.lstStatesRow this[int index]
    {
      get => (dsCopyRaterCond.lstStatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.lstStatesRowChangeEventHandler lstStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.lstStatesRowChangeEventHandler lstStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.lstStatesRowChangeEventHandler lstStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.lstStatesRowChangeEventHandler lstStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstStatesRow(dsCopyRaterCond.lstStatesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.lstStatesRow AddlstStatesRow(string StateID, string State, bool _Select)
    {
      dsCopyRaterCond.lstStatesRow row = (dsCopyRaterCond.lstStatesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) StateID,
        (object) State,
        (object) _Select
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.lstStatesRow FindByStateID(string StateID)
    {
      return (dsCopyRaterCond.lstStatesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCopyRaterCond.lstStatesDataTable lstStatesDataTable = (dsCopyRaterCond.lstStatesDataTable) base.Clone();
      lstStatesDataTable.InitVars();
      return (DataTable) lstStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCopyRaterCond.lstStatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnState = this.Columns["State"];
      this.columnSelect = this.Columns["Select"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnSelect = new DataColumn("Select", typeof (bool), (string) null, MappingType.Element);
      this.columnSelect.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "SelectColumn");
      this.columnSelect.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnSelect");
      this.columnSelect.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Select");
      this.Columns.Add(this.columnSelect);
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.lstStatesRow NewlstStatesRow()
    {
      return (dsCopyRaterCond.lstStatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCopyRaterCond.lstStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCopyRaterCond.lstStatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.lstStatesRowChangeEventHandler statesRowChangedEvent = this.lstStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsCopyRaterCond.lstStatesRowChangeEvent((dsCopyRaterCond.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.lstStatesRowChangeEventHandler rowChangingEvent = this.lstStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCopyRaterCond.lstStatesRowChangeEvent((dsCopyRaterCond.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.lstStatesRowChangeEventHandler statesRowDeletedEvent = this.lstStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsCopyRaterCond.lstStatesRowChangeEvent((dsCopyRaterCond.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.lstStatesRowChangeEventHandler rowDeletingEvent = this.lstStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCopyRaterCond.lstStatesRowChangeEvent((dsCopyRaterCond.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstStatesRow(dsCopyRaterCond.lstStatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCopyRaterCond dsCopyRaterCond = new dsCopyRaterCond();
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
        FixedValue = dsCopyRaterCond.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCopyRaterCond.GetSchemaSerializable();
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
  public class OperatorsDataTable : TypedTableBase<dsCopyRaterCond.OperatorsRow>
  {
    private DataColumn columnOperator;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public OperatorsDataTable()
    {
      this.TableName = "Operators";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected OperatorsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OperatorColumn => this.columnOperator;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.OperatorsRow this[int index]
    {
      get => (dsCopyRaterCond.OperatorsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.OperatorsRowChangeEventHandler OperatorsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.OperatorsRowChangeEventHandler OperatorsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.OperatorsRowChangeEventHandler OperatorsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.OperatorsRowChangeEventHandler OperatorsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddOperatorsRow(dsCopyRaterCond.OperatorsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.OperatorsRow AddOperatorsRow(string _Operator, string Description)
    {
      dsCopyRaterCond.OperatorsRow row = (dsCopyRaterCond.OperatorsRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.OperatorsRow FindBy_Operator(string _Operator)
    {
      return (dsCopyRaterCond.OperatorsRow) this.Rows.Find(new object[1]
      {
        (object) _Operator
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCopyRaterCond.OperatorsDataTable operatorsDataTable = (dsCopyRaterCond.OperatorsDataTable) base.Clone();
      operatorsDataTable.InitVars();
      return (DataTable) operatorsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCopyRaterCond.OperatorsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnOperator = this.Columns["Operator"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.OperatorsRow NewOperatorsRow()
    {
      return (dsCopyRaterCond.OperatorsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCopyRaterCond.OperatorsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCopyRaterCond.OperatorsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OperatorsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.OperatorsRowChangeEventHandler operatorsRowChangedEvent = this.OperatorsRowChangedEvent;
      if (operatorsRowChangedEvent == null)
        return;
      operatorsRowChangedEvent((object) this, new dsCopyRaterCond.OperatorsRowChangeEvent((dsCopyRaterCond.OperatorsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OperatorsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.OperatorsRowChangeEventHandler rowChangingEvent = this.OperatorsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCopyRaterCond.OperatorsRowChangeEvent((dsCopyRaterCond.OperatorsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OperatorsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.OperatorsRowChangeEventHandler operatorsRowDeletedEvent = this.OperatorsRowDeletedEvent;
      if (operatorsRowDeletedEvent == null)
        return;
      operatorsRowDeletedEvent((object) this, new dsCopyRaterCond.OperatorsRowChangeEvent((dsCopyRaterCond.OperatorsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OperatorsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.OperatorsRowChangeEventHandler rowDeletingEvent = this.OperatorsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCopyRaterCond.OperatorsRowChangeEvent((dsCopyRaterCond.OperatorsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveOperatorsRow(dsCopyRaterCond.OperatorsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCopyRaterCond dsCopyRaterCond = new dsCopyRaterCond();
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
        FixedValue = dsCopyRaterCond.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (OperatorsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCopyRaterCond.GetSchemaSerializable();
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
  public class tblConditionsDataTable : TypedTableBase<dsCopyRaterCond.tblConditionsRow>
  {
    private DataColumn columnConditionID;
    private DataColumn columnCondition;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblConditionsDataTable()
    {
      this.TableName = "tblConditions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblConditionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ConditionIDColumn => this.columnConditionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ConditionColumn => this.columnCondition;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblConditionsRow this[int index]
    {
      get => (dsCopyRaterCond.tblConditionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblConditionsRowChangeEventHandler tblConditionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblConditionsRowChangeEventHandler tblConditionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblConditionsRowChangeEventHandler tblConditionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCopyRaterCond.tblConditionsRowChangeEventHandler tblConditionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblConditionsRow(dsCopyRaterCond.tblConditionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblConditionsRow AddtblConditionsRow(string Condition)
    {
      dsCopyRaterCond.tblConditionsRow row = (dsCopyRaterCond.tblConditionsRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblConditionsRow FindByConditionID(int ConditionID)
    {
      return (dsCopyRaterCond.tblConditionsRow) this.Rows.Find(new object[1]
      {
        (object) ConditionID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCopyRaterCond.tblConditionsDataTable conditionsDataTable = (dsCopyRaterCond.tblConditionsDataTable) base.Clone();
      conditionsDataTable.InitVars();
      return (DataTable) conditionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCopyRaterCond.tblConditionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnConditionID = this.Columns["ConditionID"];
      this.columnCondition = this.Columns["Condition"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblConditionsRow NewtblConditionsRow()
    {
      return (dsCopyRaterCond.tblConditionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCopyRaterCond.tblConditionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCopyRaterCond.tblConditionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblConditionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblConditionsRowChangeEventHandler conditionsRowChangedEvent = this.tblConditionsRowChangedEvent;
      if (conditionsRowChangedEvent == null)
        return;
      conditionsRowChangedEvent((object) this, new dsCopyRaterCond.tblConditionsRowChangeEvent((dsCopyRaterCond.tblConditionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblConditionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblConditionsRowChangeEventHandler rowChangingEvent = this.tblConditionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCopyRaterCond.tblConditionsRowChangeEvent((dsCopyRaterCond.tblConditionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblConditionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblConditionsRowChangeEventHandler conditionsRowDeletedEvent = this.tblConditionsRowDeletedEvent;
      if (conditionsRowDeletedEvent == null)
        return;
      conditionsRowDeletedEvent((object) this, new dsCopyRaterCond.tblConditionsRowChangeEvent((dsCopyRaterCond.tblConditionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblConditionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCopyRaterCond.tblConditionsRowChangeEventHandler rowDeletingEvent = this.tblConditionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCopyRaterCond.tblConditionsRowChangeEvent((dsCopyRaterCond.tblConditionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblConditionsRow(dsCopyRaterCond.tblConditionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCopyRaterCond dsCopyRaterCond = new dsCopyRaterCond();
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
        FixedValue = dsCopyRaterCond.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblConditionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCopyRaterCond.GetSchemaSerializable();
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

  public class tblRaterFormSetupsRow : DataRow
  {
    private dsCopyRaterCond.tblRaterFormSetupsDataTable tabletblRaterFormSetups;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblRaterFormSetupsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblRaterFormSetups = (dsCopyRaterCond.tblRaterFormSetupsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int SetupID
    {
      get => Conversions.ToInteger(this[this.tabletblRaterFormSetups.SetupIDColumn]);
      set => this[this.tabletblRaterFormSetups.SetupIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int RaterID
    {
      get => Conversions.ToInteger(this[this.tabletblRaterFormSetups.RaterIDColumn]);
      set => this[this.tabletblRaterFormSetups.RaterIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Condition
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblRaterFormSetups.ConditionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Condition' in table 'tblRaterFormSetups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormSetups.ConditionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ConditionalID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblRaterFormSetups.ConditionalIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConditionalID' in table 'tblRaterFormSetups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormSetups.ConditionalIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Amount
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblRaterFormSetups.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Amount' in table 'tblRaterFormSetups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormSetups.AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string _Operator
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblRaterFormSetups.OperatorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Operator' in table 'tblRaterFormSetups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormSetups.OperatorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool _Select
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblRaterFormSetups.SelectColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Select' in table 'tblRaterFormSetups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRaterFormSetups.SelectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicyFormIDNull()
    {
      return this.IsNull(this.tabletblRaterFormSetups.PolicyFormIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicyFormIDNull()
    {
      this[this.tabletblRaterFormSetups.PolicyFormIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsConditionNull() => this.IsNull(this.tabletblRaterFormSetups.ConditionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetConditionNull()
    {
      this[this.tabletblRaterFormSetups.ConditionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsConditionalIDNull()
    {
      return this.IsNull(this.tabletblRaterFormSetups.ConditionalIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetConditionalIDNull()
    {
      this[this.tabletblRaterFormSetups.ConditionalIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAmountNull() => this.IsNull(this.tabletblRaterFormSetups.AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAmountNull()
    {
      this[this.tabletblRaterFormSetups.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Is_OperatorNull() => this.IsNull(this.tabletblRaterFormSetups.OperatorColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Set_OperatorNull()
    {
      this[this.tabletblRaterFormSetups.OperatorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompanyLineConditionIDNull()
    {
      return this.IsNull(this.tabletblRaterFormSetups.CompanyLineConditionIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompanyLineConditionIDNull()
    {
      this[this.tabletblRaterFormSetups.CompanyLineConditionIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Is_SelectNull() => this.IsNull(this.tabletblRaterFormSetups.SelectColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Set_SelectNull()
    {
      this[this.tabletblRaterFormSetups.SelectColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblCompanyRatersRow : DataRow
  {
    private dsCopyRaterCond.tblCompanyRatersDataTable tabletblCompanyRaters;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyRatersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyRaters = (dsCopyRaterCond.tblCompanyRatersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int RatingTypeID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyRaters.RatingTypeIDColumn]);
      set => this[this.tabletblCompanyRaters.RatingTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRatingTypeNull() => this.IsNull(this.tabletblCompanyRaters.RatingTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRatingTypeNull()
    {
      this[this.tabletblCompanyRaters.RatingTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblPolicyFormsRow : DataRow
  {
    private dsCopyRaterCond.tblPolicyFormsDataTable tabletblPolicyForms;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblPolicyFormsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblPolicyForms = (dsCopyRaterCond.tblPolicyFormsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int FormID
    {
      get => Conversions.ToInteger(this[this.tabletblPolicyForms.FormIDColumn]);
      set => this[this.tabletblPolicyForms.FormIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FormName
    {
      get => Conversions.ToString(this[this.tabletblPolicyForms.FormNameColumn]);
      set => this[this.tabletblPolicyForms.FormNameColumn] = (object) value;
    }
  }

  public class lstStatesRow : DataRow
  {
    private dsCopyRaterCond.lstStatesDataTable tablelstStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStates = (dsCopyRaterCond.lstStatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tablelstStates.StateIDColumn]);
      set => this[this.tablelstStates.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tablelstStates.StateColumn]);
      set => this[this.tablelstStates.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool _Select
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstStates.SelectColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Select' in table 'lstStates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstStates.SelectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Is_SelectNull() => this.IsNull(this.tablelstStates.SelectColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Set_SelectNull()
    {
      this[this.tablelstStates.SelectColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class OperatorsRow : DataRow
  {
    private dsCopyRaterCond.OperatorsDataTable tableOperators;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal OperatorsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOperators = (dsCopyRaterCond.OperatorsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string _Operator
    {
      get => Conversions.ToString(this[this.tableOperators.OperatorColumn]);
      set => this[this.tableOperators.OperatorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tableOperators.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tableOperators.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblConditionsRow : DataRow
  {
    private dsCopyRaterCond.tblConditionsDataTable tabletblConditions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblConditionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblConditions = (dsCopyRaterCond.tblConditionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ConditionID
    {
      get => Conversions.ToInteger(this[this.tabletblConditions.ConditionIDColumn]);
      set => this[this.tabletblConditions.ConditionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Condition
    {
      get => Conversions.ToString(this[this.tabletblConditions.ConditionColumn]);
      set => this[this.tabletblConditions.ConditionColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblRaterFormSetupsRowChangeEvent : EventArgs
  {
    private dsCopyRaterCond.tblRaterFormSetupsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblRaterFormSetupsRowChangeEvent(
      dsCopyRaterCond.tblRaterFormSetupsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblRaterFormSetupsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyRatersRowChangeEvent : EventArgs
  {
    private dsCopyRaterCond.tblCompanyRatersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyRatersRowChangeEvent(
      dsCopyRaterCond.tblCompanyRatersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblCompanyRatersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblPolicyFormsRowChangeEvent : EventArgs
  {
    private dsCopyRaterCond.tblPolicyFormsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblPolicyFormsRowChangeEvent(dsCopyRaterCond.tblPolicyFormsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblPolicyFormsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstStatesRowChangeEvent : EventArgs
  {
    private dsCopyRaterCond.lstStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstStatesRowChangeEvent(dsCopyRaterCond.lstStatesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.lstStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class OperatorsRowChangeEvent : EventArgs
  {
    private dsCopyRaterCond.OperatorsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public OperatorsRowChangeEvent(dsCopyRaterCond.OperatorsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.OperatorsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblConditionsRowChangeEvent : EventArgs
  {
    private dsCopyRaterCond.tblConditionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblConditionsRowChangeEvent(dsCopyRaterCond.tblConditionsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCopyRaterCond.tblConditionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
