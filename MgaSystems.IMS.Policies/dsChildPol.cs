// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsChildPol
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
[XmlRoot("dsChildPol")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsChildPol : DataSet
{
  private dsChildPol.dtDataTable tabledt;
  private dsChildPol.dtTransDataTable tabledtTrans;
  private dsChildPol.tblPolicyNumberRulesDataTable tabletblPolicyNumberRules;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsChildPol()
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
  protected dsChildPol(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (dt)] != null)
          base.Tables.Add((DataTable) new dsChildPol.dtDataTable(dataSet.Tables[nameof (dt)]));
        if (dataSet.Tables[nameof (dtTrans)] != null)
          base.Tables.Add((DataTable) new dsChildPol.dtTransDataTable(dataSet.Tables[nameof (dtTrans)]));
        if (dataSet.Tables[nameof (tblPolicyNumberRules)] != null)
          base.Tables.Add((DataTable) new dsChildPol.tblPolicyNumberRulesDataTable(dataSet.Tables[nameof (tblPolicyNumberRules)]));
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
  public dsChildPol.dtDataTable dt => this.tabledt;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsChildPol.dtTransDataTable dtTrans => this.tabledtTrans;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsChildPol.tblPolicyNumberRulesDataTable tblPolicyNumberRules
  {
    get => this.tabletblPolicyNumberRules;
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
    dsChildPol dsChildPol = (dsChildPol) base.Clone();
    dsChildPol.InitVars();
    dsChildPol.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsChildPol;
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
      if (dataSet.Tables["dt"] != null)
        base.Tables.Add((DataTable) new dsChildPol.dtDataTable(dataSet.Tables["dt"]));
      if (dataSet.Tables["dtTrans"] != null)
        base.Tables.Add((DataTable) new dsChildPol.dtTransDataTable(dataSet.Tables["dtTrans"]));
      if (dataSet.Tables["tblPolicyNumberRules"] != null)
        base.Tables.Add((DataTable) new dsChildPol.tblPolicyNumberRulesDataTable(dataSet.Tables["tblPolicyNumberRules"]));
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
    this.tabledt = (dsChildPol.dtDataTable) base.Tables["dt"];
    if (initTable && this.tabledt != null)
      this.tabledt.InitVars();
    this.tabledtTrans = (dsChildPol.dtTransDataTable) base.Tables["dtTrans"];
    if (initTable && this.tabledtTrans != null)
      this.tabledtTrans.InitVars();
    this.tabletblPolicyNumberRules = (dsChildPol.tblPolicyNumberRulesDataTable) base.Tables["tblPolicyNumberRules"];
    if (!initTable || this.tabletblPolicyNumberRules == null)
      return;
    this.tabletblPolicyNumberRules.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsChildPol);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsChildPol.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabledt = new dsChildPol.dtDataTable();
    base.Tables.Add((DataTable) this.tabledt);
    this.tabledtTrans = new dsChildPol.dtTransDataTable();
    base.Tables.Add((DataTable) this.tabledtTrans);
    this.tabletblPolicyNumberRules = new dsChildPol.tblPolicyNumberRulesDataTable();
    base.Tables.Add((DataTable) this.tabletblPolicyNumberRules);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedt() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializedtTrans() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblPolicyNumberRules() => false;

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
    dsChildPol dsChildPol = new dsChildPol();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsChildPol.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsChildPol.GetSchemaSerializable();
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
  public delegate void dtRowChangeEventHandler(object sender, dsChildPol.dtRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void dtTransRowChangeEventHandler(
    object sender,
    dsChildPol.dtTransRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblPolicyNumberRulesRowChangeEventHandler(
    object sender,
    dsChildPol.tblPolicyNumberRulesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class dtDataTable : TypedTableBase<dsChildPol.dtRow>
  {
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnLine;
    private DataColumn columnPolicyNumber;
    private DataColumn columnRule;
    private DataColumn columnRuleID;
    private DataColumn columnRuleIndex;
    private DataColumn columnNotes;
    private DataColumn columnGo;
    private DataColumn columnCurrentPolicyNumber;
    private DataColumn columnSelected;
    private DataColumn columnValid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtDataTable()
    {
      this.TableName = "dt";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtDataTable(DataTable table)
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
    protected dtDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineColumn => this.columnLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RuleColumn => this.columnRule;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RuleIDColumn => this.columnRuleID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RuleIndexColumn => this.columnRuleIndex;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NotesColumn => this.columnNotes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GoColumn => this.columnGo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CurrentPolicyNumberColumn => this.columnCurrentPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SelectedColumn => this.columnSelected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ValidColumn => this.columnValid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsChildPol.dtRow this[int index] => (dsChildPol.dtRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsChildPol.dtRowChangeEventHandler dtRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsChildPol.dtRowChangeEventHandler dtRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsChildPol.dtRowChangeEventHandler dtRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsChildPol.dtRowChangeEventHandler dtRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtRow(dsChildPol.dtRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsChildPol.dtRow AdddtRow(
      Guid CompanyLineGuid,
      string Line,
      string PolicyNumber,
      string Rule,
      int RuleID,
      int RuleIndex,
      string Notes,
      bool Go,
      string CurrentPolicyNumber,
      bool Selected,
      bool Valid)
    {
      dsChildPol.dtRow row = (dsChildPol.dtRow) this.NewRow();
      object[] objArray = new object[11]
      {
        (object) CompanyLineGuid,
        (object) Line,
        (object) PolicyNumber,
        (object) Rule,
        (object) RuleID,
        (object) RuleIndex,
        (object) Notes,
        (object) Go,
        (object) CurrentPolicyNumber,
        (object) Selected,
        (object) Valid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsChildPol.dtRow FindByCompanyLineGuid(Guid CompanyLineGuid)
    {
      return (dsChildPol.dtRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLineGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsChildPol.dtDataTable dtDataTable = (dsChildPol.dtDataTable) base.Clone();
      dtDataTable.InitVars();
      return (DataTable) dtDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsChildPol.dtDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnLine = this.Columns["Line"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnRule = this.Columns["Rule"];
      this.columnRuleID = this.Columns["RuleID"];
      this.columnRuleIndex = this.Columns["RuleIndex"];
      this.columnNotes = this.Columns["Notes"];
      this.columnGo = this.Columns["Go"];
      this.columnCurrentPolicyNumber = this.Columns["CurrentPolicyNumber"];
      this.columnSelected = this.Columns["Selected"];
      this.columnValid = this.Columns["Valid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnLine = new DataColumn("Line", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLine);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnRule = new DataColumn("Rule", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRule);
      this.columnRuleID = new DataColumn("RuleID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRuleID);
      this.columnRuleIndex = new DataColumn("RuleIndex", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRuleIndex);
      this.columnNotes = new DataColumn("Notes", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNotes);
      this.columnGo = new DataColumn("Go", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGo);
      this.columnCurrentPolicyNumber = new DataColumn("CurrentPolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCurrentPolicyNumber);
      this.columnSelected = new DataColumn("Selected", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSelected);
      this.columnValid = new DataColumn("Valid", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnValid);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCompanyLineGuid
      }, true));
      this.columnCompanyLineGuid.AllowDBNull = false;
      this.columnCompanyLineGuid.Unique = true;
      this.columnGo.DefaultValue = (object) true;
      this.columnSelected.DefaultValue = (object) false;
      this.columnValid.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsChildPol.dtRow NewdtRow() => (dsChildPol.dtRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsChildPol.dtRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsChildPol.dtRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChildPol.dtRowChangeEventHandler dtRowChangedEvent = this.dtRowChangedEvent;
      if (dtRowChangedEvent == null)
        return;
      dtRowChangedEvent((object) this, new dsChildPol.dtRowChangeEvent((dsChildPol.dtRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChildPol.dtRowChangeEventHandler rowChangingEvent = this.dtRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsChildPol.dtRowChangeEvent((dsChildPol.dtRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChildPol.dtRowChangeEventHandler dtRowDeletedEvent = this.dtRowDeletedEvent;
      if (dtRowDeletedEvent == null)
        return;
      dtRowDeletedEvent((object) this, new dsChildPol.dtRowChangeEvent((dsChildPol.dtRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChildPol.dtRowChangeEventHandler rowDeletingEvent = this.dtRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsChildPol.dtRowChangeEvent((dsChildPol.dtRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtRow(dsChildPol.dtRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsChildPol dsChildPol = new dsChildPol();
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
        FixedValue = dsChildPol.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsChildPol.GetSchemaSerializable();
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
  public class dtTransDataTable : TypedTableBase<dsChildPol.dtTransRow>
  {
    private DataColumn columnTransactionNum;
    private DataColumn columnQuoteID;
    private DataColumn columnQuoteGuid;
    private DataColumn columnDisplayStatus;
    private DataColumn columnPolicyNumber;
    private DataColumn columnPolicyNumberIndex;
    private DataColumn columnPolicyNumberRuleID;
    private DataColumn columnGo;
    private DataColumn columnNotes;
    private DataColumn columnCurrentPolicyNumber;
    private DataColumn columnCurrentIndex;
    private DataColumn columnCurrentRule;
    private DataColumn columnManual;
    private DataColumn columnTableBasedPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtTransDataTable()
    {
      this.TableName = "dtTrans";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtTransDataTable(DataTable table)
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
    protected dtTransDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TransactionNumColumn => this.columnTransactionNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DisplayStatusColumn => this.columnDisplayStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyNumberIndexColumn => this.columnPolicyNumberIndex;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyNumberRuleIDColumn => this.columnPolicyNumberRuleID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GoColumn => this.columnGo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NotesColumn => this.columnNotes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CurrentPolicyNumberColumn => this.columnCurrentPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CurrentIndexColumn => this.columnCurrentIndex;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CurrentRuleColumn => this.columnCurrentRule;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ManualColumn => this.columnManual;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TableBasedPolicyNumberColumn => this.columnTableBasedPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsChildPol.dtTransRow this[int index] => (dsChildPol.dtTransRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsChildPol.dtTransRowChangeEventHandler dtTransRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsChildPol.dtTransRowChangeEventHandler dtTransRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsChildPol.dtTransRowChangeEventHandler dtTransRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsChildPol.dtTransRowChangeEventHandler dtTransRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AdddtTransRow(dsChildPol.dtTransRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsChildPol.dtTransRow AdddtTransRow(
      int QuoteID,
      Guid QuoteGuid,
      string DisplayStatus,
      string PolicyNumber,
      int PolicyNumberIndex,
      int PolicyNumberRuleID,
      bool Go,
      string Notes,
      string CurrentPolicyNumber,
      int CurrentIndex,
      string CurrentRule,
      bool Manual,
      string TableBasedPolicyNumber)
    {
      dsChildPol.dtTransRow row = (dsChildPol.dtTransRow) this.NewRow();
      object[] objArray = new object[14]
      {
        null,
        (object) QuoteID,
        (object) QuoteGuid,
        (object) DisplayStatus,
        (object) PolicyNumber,
        (object) PolicyNumberIndex,
        (object) PolicyNumberRuleID,
        (object) Go,
        (object) Notes,
        (object) CurrentPolicyNumber,
        (object) CurrentIndex,
        (object) CurrentRule,
        (object) Manual,
        (object) TableBasedPolicyNumber
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsChildPol.dtTransDataTable dtTransDataTable = (dsChildPol.dtTransDataTable) base.Clone();
      dtTransDataTable.InitVars();
      return (DataTable) dtTransDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsChildPol.dtTransDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnTransactionNum = this.Columns["TransactionNum"];
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnDisplayStatus = this.Columns["DisplayStatus"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnPolicyNumberIndex = this.Columns["PolicyNumberIndex"];
      this.columnPolicyNumberRuleID = this.Columns["PolicyNumberRuleID"];
      this.columnGo = this.Columns["Go"];
      this.columnNotes = this.Columns["Notes"];
      this.columnCurrentPolicyNumber = this.Columns["CurrentPolicyNumber"];
      this.columnCurrentIndex = this.Columns["CurrentIndex"];
      this.columnCurrentRule = this.Columns["CurrentRule"];
      this.columnManual = this.Columns["Manual"];
      this.columnTableBasedPolicyNumber = this.Columns["TableBasedPolicyNumber"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnTransactionNum = new DataColumn("TransactionNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransactionNum);
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnDisplayStatus = new DataColumn("DisplayStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisplayStatus);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnPolicyNumberIndex = new DataColumn("PolicyNumberIndex", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumberIndex);
      this.columnPolicyNumberRuleID = new DataColumn("PolicyNumberRuleID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumberRuleID);
      this.columnGo = new DataColumn("Go", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGo);
      this.columnNotes = new DataColumn("Notes", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNotes);
      this.columnCurrentPolicyNumber = new DataColumn("CurrentPolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCurrentPolicyNumber);
      this.columnCurrentIndex = new DataColumn("CurrentIndex", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCurrentIndex);
      this.columnCurrentRule = new DataColumn("CurrentRule", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCurrentRule);
      this.columnManual = new DataColumn("Manual", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnManual);
      this.columnTableBasedPolicyNumber = new DataColumn("TableBasedPolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTableBasedPolicyNumber);
      this.columnTransactionNum.AutoIncrement = true;
      this.columnTransactionNum.AutoIncrementSeed = 1L;
      this.columnTransactionNum.AllowDBNull = false;
      this.columnQuoteID.AllowDBNull = false;
      this.columnQuoteGuid.AllowDBNull = false;
      this.columnGo.AllowDBNull = false;
      this.columnGo.DefaultValue = (object) false;
      this.columnManual.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsChildPol.dtTransRow NewdtTransRow() => (dsChildPol.dtTransRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsChildPol.dtTransRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsChildPol.dtTransRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtTransRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChildPol.dtTransRowChangeEventHandler transRowChangedEvent = this.dtTransRowChangedEvent;
      if (transRowChangedEvent == null)
        return;
      transRowChangedEvent((object) this, new dsChildPol.dtTransRowChangeEvent((dsChildPol.dtTransRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtTransRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChildPol.dtTransRowChangeEventHandler rowChangingEvent = this.dtTransRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsChildPol.dtTransRowChangeEvent((dsChildPol.dtTransRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtTransRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChildPol.dtTransRowChangeEventHandler transRowDeletedEvent = this.dtTransRowDeletedEvent;
      if (transRowDeletedEvent == null)
        return;
      transRowDeletedEvent((object) this, new dsChildPol.dtTransRowChangeEvent((dsChildPol.dtTransRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtTransRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChildPol.dtTransRowChangeEventHandler rowDeletingEvent = this.dtTransRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsChildPol.dtTransRowChangeEvent((dsChildPol.dtTransRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovedtTransRow(dsChildPol.dtTransRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsChildPol dsChildPol = new dsChildPol();
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
        FixedValue = dsChildPol.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtTransDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsChildPol.GetSchemaSerializable();
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
  public class tblPolicyNumberRulesDataTable : TypedTableBase<dsChildPol.tblPolicyNumberRulesRow>
  {
    private DataColumn columnRuleID;
    private DataColumn columnRuleName;

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
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsChildPol.tblPolicyNumberRulesRow this[int index]
    {
      get => (dsChildPol.tblPolicyNumberRulesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsChildPol.tblPolicyNumberRulesRowChangeEventHandler tblPolicyNumberRulesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsChildPol.tblPolicyNumberRulesRowChangeEventHandler tblPolicyNumberRulesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsChildPol.tblPolicyNumberRulesRowChangeEventHandler tblPolicyNumberRulesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsChildPol.tblPolicyNumberRulesRowChangeEventHandler tblPolicyNumberRulesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblPolicyNumberRulesRow(dsChildPol.tblPolicyNumberRulesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsChildPol.tblPolicyNumberRulesRow AddtblPolicyNumberRulesRow(
      int RuleID,
      string RuleName)
    {
      dsChildPol.tblPolicyNumberRulesRow row = (dsChildPol.tblPolicyNumberRulesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) RuleID,
        (object) RuleName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsChildPol.tblPolicyNumberRulesRow FindByRuleID(int RuleID)
    {
      return (dsChildPol.tblPolicyNumberRulesRow) this.Rows.Find(new object[1]
      {
        (object) RuleID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsChildPol.tblPolicyNumberRulesDataTable numberRulesDataTable = (dsChildPol.tblPolicyNumberRulesDataTable) base.Clone();
      numberRulesDataTable.InitVars();
      return (DataTable) numberRulesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsChildPol.tblPolicyNumberRulesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnRuleID = this.Columns["RuleID"];
      this.columnRuleName = this.Columns["RuleName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnRuleID = new DataColumn("RuleID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRuleID);
      this.columnRuleName = new DataColumn("RuleName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRuleName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnRuleID
      }, true));
      this.columnRuleID.AllowDBNull = false;
      this.columnRuleID.Unique = true;
      this.columnRuleName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsChildPol.tblPolicyNumberRulesRow NewtblPolicyNumberRulesRow()
    {
      return (dsChildPol.tblPolicyNumberRulesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsChildPol.tblPolicyNumberRulesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsChildPol.tblPolicyNumberRulesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyNumberRulesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChildPol.tblPolicyNumberRulesRowChangeEventHandler rulesRowChangedEvent = this.tblPolicyNumberRulesRowChangedEvent;
      if (rulesRowChangedEvent == null)
        return;
      rulesRowChangedEvent((object) this, new dsChildPol.tblPolicyNumberRulesRowChangeEvent((dsChildPol.tblPolicyNumberRulesRow) e.Row, e.Action));
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
      dsChildPol.tblPolicyNumberRulesRowChangeEventHandler rowChangingEvent = this.tblPolicyNumberRulesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsChildPol.tblPolicyNumberRulesRowChangeEvent((dsChildPol.tblPolicyNumberRulesRow) e.Row, e.Action));
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
      dsChildPol.tblPolicyNumberRulesRowChangeEventHandler rulesRowDeletedEvent = this.tblPolicyNumberRulesRowDeletedEvent;
      if (rulesRowDeletedEvent == null)
        return;
      rulesRowDeletedEvent((object) this, new dsChildPol.tblPolicyNumberRulesRowChangeEvent((dsChildPol.tblPolicyNumberRulesRow) e.Row, e.Action));
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
      dsChildPol.tblPolicyNumberRulesRowChangeEventHandler rowDeletingEvent = this.tblPolicyNumberRulesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsChildPol.tblPolicyNumberRulesRowChangeEvent((dsChildPol.tblPolicyNumberRulesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblPolicyNumberRulesRow(dsChildPol.tblPolicyNumberRulesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsChildPol dsChildPol = new dsChildPol();
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
        FixedValue = dsChildPol.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblPolicyNumberRulesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsChildPol.GetSchemaSerializable();
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

  public class dtRow : DataRow
  {
    private dsChildPol.dtDataTable tabledt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledt = (dsChildPol.dtDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        object obj = this[this.tabledt.CompanyLineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabledt.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Line
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledt.LineColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Line' in table 'dt' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledt.LineColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledt.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'dt' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledt.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Rule
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledt.RuleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Rule' in table 'dt' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledt.RuleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RuleID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledt.RuleIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RuleID' in table 'dt' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledt.RuleIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int RuleIndex
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledt.RuleIndexColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RuleIndex' in table 'dt' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledt.RuleIndexColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Notes
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledt.NotesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Notes' in table 'dt' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledt.NotesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Go
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledt.GoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Go' in table 'dt' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledt.GoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CurrentPolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledt.CurrentPolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CurrentPolicyNumber' in table 'dt' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledt.CurrentPolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Selected
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledt.SelectedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Selected' in table 'dt' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledt.SelectedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Valid
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledt.ValidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Valid' in table 'dt' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledt.ValidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLineNull() => this.IsNull(this.tabledt.LineColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLineNull()
    {
      this[this.tabledt.LineColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tabledt.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tabledt.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRuleNull() => this.IsNull(this.tabledt.RuleColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRuleNull()
    {
      this[this.tabledt.RuleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRuleIDNull() => this.IsNull(this.tabledt.RuleIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRuleIDNull()
    {
      this[this.tabledt.RuleIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRuleIndexNull() => this.IsNull(this.tabledt.RuleIndexColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRuleIndexNull()
    {
      this[this.tabledt.RuleIndexColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNotesNull() => this.IsNull(this.tabledt.NotesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNotesNull()
    {
      this[this.tabledt.NotesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGoNull() => this.IsNull(this.tabledt.GoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGoNull()
    {
      this[this.tabledt.GoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCurrentPolicyNumberNull() => this.IsNull(this.tabledt.CurrentPolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCurrentPolicyNumberNull()
    {
      this[this.tabledt.CurrentPolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSelectedNull() => this.IsNull(this.tabledt.SelectedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSelectedNull()
    {
      this[this.tabledt.SelectedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsValidNull() => this.IsNull(this.tabledt.ValidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetValidNull()
    {
      this[this.tabledt.ValidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtTransRow : DataRow
  {
    private dsChildPol.dtTransDataTable tabledtTrans;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal dtTransRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtTrans = (dsChildPol.dtTransDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int TransactionNum
    {
      get => Conversions.ToInteger(this[this.tabledtTrans.TransactionNumColumn]);
      set => this[this.tabledtTrans.TransactionNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tabledtTrans.QuoteIDColumn]);
      set => this[this.tabledtTrans.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        object obj = this[this.tabledtTrans.QuoteGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabledtTrans.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string DisplayStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtTrans.DisplayStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DisplayStatus' in table 'dtTrans' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTrans.DisplayStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtTrans.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'dtTrans' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTrans.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyNumberIndex
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledtTrans.PolicyNumberIndexColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumberIndex' in table 'dtTrans' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTrans.PolicyNumberIndexColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyNumberRuleID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledtTrans.PolicyNumberRuleIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumberRuleID' in table 'dtTrans' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTrans.PolicyNumberRuleIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Go
    {
      get => Conversions.ToBoolean(this[this.tabledtTrans.GoColumn]);
      set => this[this.tabledtTrans.GoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Notes
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtTrans.NotesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Notes' in table 'dtTrans' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTrans.NotesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CurrentPolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtTrans.CurrentPolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CurrentPolicyNumber' in table 'dtTrans' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTrans.CurrentPolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CurrentIndex
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledtTrans.CurrentIndexColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CurrentIndex' in table 'dtTrans' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTrans.CurrentIndexColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CurrentRule
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtTrans.CurrentRuleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CurrentRule' in table 'dtTrans' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTrans.CurrentRuleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Manual
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtTrans.ManualColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Manual' in table 'dtTrans' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTrans.ManualColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string TableBasedPolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtTrans.TableBasedPolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TableBasedPolicyNumber' in table 'dtTrans' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTrans.TableBasedPolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDisplayStatusNull() => this.IsNull(this.tabledtTrans.DisplayStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDisplayStatusNull()
    {
      this[this.tabledtTrans.DisplayStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tabledtTrans.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tabledtTrans.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyNumberIndexNull() => this.IsNull(this.tabledtTrans.PolicyNumberIndexColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyNumberIndexNull()
    {
      this[this.tabledtTrans.PolicyNumberIndexColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyNumberRuleIDNull()
    {
      return this.IsNull(this.tabledtTrans.PolicyNumberRuleIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyNumberRuleIDNull()
    {
      this[this.tabledtTrans.PolicyNumberRuleIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNotesNull() => this.IsNull(this.tabledtTrans.NotesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNotesNull()
    {
      this[this.tabledtTrans.NotesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCurrentPolicyNumberNull()
    {
      return this.IsNull(this.tabledtTrans.CurrentPolicyNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCurrentPolicyNumberNull()
    {
      this[this.tabledtTrans.CurrentPolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCurrentIndexNull() => this.IsNull(this.tabledtTrans.CurrentIndexColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCurrentIndexNull()
    {
      this[this.tabledtTrans.CurrentIndexColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCurrentRuleNull() => this.IsNull(this.tabledtTrans.CurrentRuleColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCurrentRuleNull()
    {
      this[this.tabledtTrans.CurrentRuleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsManualNull() => this.IsNull(this.tabledtTrans.ManualColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetManualNull()
    {
      this[this.tabledtTrans.ManualColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTableBasedPolicyNumberNull()
    {
      return this.IsNull(this.tabledtTrans.TableBasedPolicyNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTableBasedPolicyNumberNull()
    {
      this[this.tabledtTrans.TableBasedPolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblPolicyNumberRulesRow : DataRow
  {
    private dsChildPol.tblPolicyNumberRulesDataTable tabletblPolicyNumberRules;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblPolicyNumberRulesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblPolicyNumberRules = (dsChildPol.tblPolicyNumberRulesDataTable) this.Table;
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
      get => Conversions.ToString(this[this.tabletblPolicyNumberRules.RuleNameColumn]);
      set => this[this.tabletblPolicyNumberRules.RuleNameColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtRowChangeEvent : EventArgs
  {
    private dsChildPol.dtRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtRowChangeEvent(dsChildPol.dtRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsChildPol.dtRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class dtTransRowChangeEvent : EventArgs
  {
    private dsChildPol.dtTransRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dtTransRowChangeEvent(dsChildPol.dtTransRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsChildPol.dtTransRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblPolicyNumberRulesRowChangeEvent : EventArgs
  {
    private dsChildPol.tblPolicyNumberRulesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblPolicyNumberRulesRowChangeEvent(
      dsChildPol.tblPolicyNumberRulesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsChildPol.tblPolicyNumberRulesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
