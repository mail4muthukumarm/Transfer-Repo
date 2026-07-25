// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.dsCompanyLinePolicyNumbers
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
[XmlRoot("dsCompanyLinePolicyNumbers")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyLinePolicyNumbers : DataSet
{
  private dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersDataTable tabletblCompanyLinePolicyNumbers;
  private dsCompanyLinePolicyNumbers.tblPolicyNumberRulesDataTable tabletblPolicyNumberRules;
  private DataRelation relationtblPolicyNumberRulestblCompanyLinePolicyNumbers;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsCompanyLinePolicyNumbers()
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
  protected dsCompanyLinePolicyNumbers(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyLinePolicyNumbers)] != null)
          base.Tables.Add((DataTable) new dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersDataTable(dataSet.Tables[nameof (tblCompanyLinePolicyNumbers)]));
        if (dataSet.Tables[nameof (tblPolicyNumberRules)] != null)
          base.Tables.Add((DataTable) new dsCompanyLinePolicyNumbers.tblPolicyNumberRulesDataTable(dataSet.Tables[nameof (tblPolicyNumberRules)]));
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
  public dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersDataTable tblCompanyLinePolicyNumbers
  {
    get => this.tabletblCompanyLinePolicyNumbers;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyLinePolicyNumbers.tblPolicyNumberRulesDataTable tblPolicyNumberRules
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
    dsCompanyLinePolicyNumbers linePolicyNumbers = (dsCompanyLinePolicyNumbers) base.Clone();
    linePolicyNumbers.InitVars();
    linePolicyNumbers.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) linePolicyNumbers;
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
      if (dataSet.Tables["tblCompanyLinePolicyNumbers"] != null)
        base.Tables.Add((DataTable) new dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersDataTable(dataSet.Tables["tblCompanyLinePolicyNumbers"]));
      if (dataSet.Tables["tblPolicyNumberRules"] != null)
        base.Tables.Add((DataTable) new dsCompanyLinePolicyNumbers.tblPolicyNumberRulesDataTable(dataSet.Tables["tblPolicyNumberRules"]));
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
    this.tabletblCompanyLinePolicyNumbers = (dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersDataTable) base.Tables["tblCompanyLinePolicyNumbers"];
    if (initTable && this.tabletblCompanyLinePolicyNumbers != null)
      this.tabletblCompanyLinePolicyNumbers.InitVars();
    this.tabletblPolicyNumberRules = (dsCompanyLinePolicyNumbers.tblPolicyNumberRulesDataTable) base.Tables["tblPolicyNumberRules"];
    if (initTable && this.tabletblPolicyNumberRules != null)
      this.tabletblPolicyNumberRules.InitVars();
    this.relationtblPolicyNumberRulestblCompanyLinePolicyNumbers = this.Relations["tblPolicyNumberRulestblCompanyLinePolicyNumbers"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyLinePolicyNumbers);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCompanyLinePolicyNumbers.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyLinePolicyNumbers = new dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLinePolicyNumbers);
    this.tabletblPolicyNumberRules = new dsCompanyLinePolicyNumbers.tblPolicyNumberRulesDataTable();
    base.Tables.Add((DataTable) this.tabletblPolicyNumberRules);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("tblPolicyNumberRulestblCompanyLinePolicyNumbers", new DataColumn[1]
    {
      this.tabletblPolicyNumberRules.RuleIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLinePolicyNumbers.PolicyNumberRuleIDColumn
    });
    this.tabletblCompanyLinePolicyNumbers.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationtblPolicyNumberRulestblCompanyLinePolicyNumbers = new DataRelation("tblPolicyNumberRulestblCompanyLinePolicyNumbers", new DataColumn[1]
    {
      this.tabletblPolicyNumberRules.RuleIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLinePolicyNumbers.PolicyNumberRuleIDColumn
    }, false);
    this.Relations.Add(this.relationtblPolicyNumberRulestblCompanyLinePolicyNumbers);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyLinePolicyNumbers() => false;

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
    dsCompanyLinePolicyNumbers linePolicyNumbers = new dsCompanyLinePolicyNumbers();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = linePolicyNumbers.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = linePolicyNumbers.GetSchemaSerializable();
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
  public delegate void tblCompanyLinePolicyNumbersRowChangeEventHandler(
    object sender,
    dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblPolicyNumberRulesRowChangeEventHandler(
    object sender,
    dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyLinePolicyNumbersDataTable : 
    TypedTableBase<dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow>
  {
    private DataColumn columnCompanyLineID;
    private DataColumn columnPolicyNumberRuleID;
    private DataColumn columnEffective;
    private DataColumn columnStoredProcedureName;
    private DataColumn columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyLinePolicyNumbersDataTable()
    {
      this.TableName = "tblCompanyLinePolicyNumbers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyLinePolicyNumbersDataTable(DataTable table)
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
    protected tblCompanyLinePolicyNumbersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineIDColumn => this.columnCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyNumberRuleIDColumn => this.columnPolicyNumberRuleID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EffectiveColumn => this.columnEffective;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StoredProcedureNameColumn => this.columnStoredProcedureName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow this[int index]
    {
      get => (dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRowChangeEventHandler tblCompanyLinePolicyNumbersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRowChangeEventHandler tblCompanyLinePolicyNumbersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRowChangeEventHandler tblCompanyLinePolicyNumbersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRowChangeEventHandler tblCompanyLinePolicyNumbersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyLinePolicyNumbersRow(
      dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow AddtblCompanyLinePolicyNumbersRow(
      int CompanyLineID,
      dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow parenttblPolicyNumberRulesRowBytblPolicyNumberRulestblCompanyLinePolicyNumbers,
      DateTime Effective,
      string StoredProcedureName)
    {
      dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow row = (dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) CompanyLineID,
        null,
        (object) Effective,
        (object) StoredProcedureName,
        null
      };
      if (parenttblPolicyNumberRulesRowBytblPolicyNumberRulestblCompanyLinePolicyNumbers != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblPolicyNumberRulesRowBytblPolicyNumberRulestblCompanyLinePolicyNumbers[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow FindByCompanyLineIDPolicyNumberRuleIDEffective(
      int CompanyLineID,
      short PolicyNumberRuleID,
      DateTime Effective)
    {
      return (dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow) this.Rows.Find(new object[3]
      {
        (object) CompanyLineID,
        (object) PolicyNumberRuleID,
        (object) Effective
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersDataTable numbersDataTable = (dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersDataTable) base.Clone();
      numbersDataTable.InitVars();
      return (DataTable) numbersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLineID = this.Columns["CompanyLineID"];
      this.columnPolicyNumberRuleID = this.Columns["PolicyNumberRuleID"];
      this.columnEffective = this.Columns["Effective"];
      this.columnStoredProcedureName = this.Columns["StoredProcedureName"];
      this.columnID = this.Columns["ID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLineID = new DataColumn("CompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineID);
      this.columnPolicyNumberRuleID = new DataColumn("PolicyNumberRuleID", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumberRuleID);
      this.columnEffective = new DataColumn("Effective", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffective);
      this.columnStoredProcedureName = new DataColumn("StoredProcedureName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStoredProcedureName);
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[3]
      {
        this.columnCompanyLineID,
        this.columnPolicyNumberRuleID,
        this.columnEffective
      }, true));
      this.columnCompanyLineID.AllowDBNull = false;
      this.columnPolicyNumberRuleID.AllowDBNull = false;
      this.columnEffective.AllowDBNull = false;
      this.columnID.AutoIncrement = true;
      this.columnID.AutoIncrementSeed = -1L;
      this.columnID.AutoIncrementStep = -1L;
      this.columnID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow NewtblCompanyLinePolicyNumbersRow()
    {
      return (dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinePolicyNumbersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRowChangeEventHandler numbersRowChangedEvent = this.tblCompanyLinePolicyNumbersRowChangedEvent;
      if (numbersRowChangedEvent == null)
        return;
      numbersRowChangedEvent((object) this, new dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRowChangeEvent((dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinePolicyNumbersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRowChangeEventHandler rowChangingEvent = this.tblCompanyLinePolicyNumbersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRowChangeEvent((dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinePolicyNumbersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRowChangeEventHandler numbersRowDeletedEvent = this.tblCompanyLinePolicyNumbersRowDeletedEvent;
      if (numbersRowDeletedEvent == null)
        return;
      numbersRowDeletedEvent((object) this, new dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRowChangeEvent((dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinePolicyNumbersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRowChangeEventHandler rowDeletingEvent = this.tblCompanyLinePolicyNumbersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRowChangeEvent((dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyLinePolicyNumbersRow(
      dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLinePolicyNumbers linePolicyNumbers = new dsCompanyLinePolicyNumbers();
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
        FixedValue = linePolicyNumbers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLinePolicyNumbersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = linePolicyNumbers.GetSchemaSerializable();
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
  public class tblPolicyNumberRulesDataTable : 
    TypedTableBase<dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow>
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
    public dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow this[int index]
    {
      get => (dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRowChangeEventHandler tblPolicyNumberRulesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRowChangeEventHandler tblPolicyNumberRulesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRowChangeEventHandler tblPolicyNumberRulesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRowChangeEventHandler tblPolicyNumberRulesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblPolicyNumberRulesRow(
      dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow AddtblPolicyNumberRulesRow(
      string RuleName)
    {
      dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow row = (dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) RuleName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow FindByRuleID(short RuleID)
    {
      return (dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow) this.Rows.Find(new object[1]
      {
        (object) RuleID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLinePolicyNumbers.tblPolicyNumberRulesDataTable numberRulesDataTable = (dsCompanyLinePolicyNumbers.tblPolicyNumberRulesDataTable) base.Clone();
      numberRulesDataTable.InitVars();
      return (DataTable) numberRulesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLinePolicyNumbers.tblPolicyNumberRulesDataTable();
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
      this.columnRuleID = new DataColumn("RuleID", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRuleID);
      this.columnRuleName = new DataColumn("RuleName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRuleName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnRuleID
      }, true));
      this.columnRuleID.AutoIncrement = true;
      this.columnRuleID.AllowDBNull = false;
      this.columnRuleID.ReadOnly = true;
      this.columnRuleID.Unique = true;
      this.columnRuleName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow NewtblPolicyNumberRulesRow()
    {
      return (dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyNumberRulesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRowChangeEventHandler rulesRowChangedEvent = this.tblPolicyNumberRulesRowChangedEvent;
      if (rulesRowChangedEvent == null)
        return;
      rulesRowChangedEvent((object) this, new dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRowChangeEvent((dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow) e.Row, e.Action));
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
      dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRowChangeEventHandler rowChangingEvent = this.tblPolicyNumberRulesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRowChangeEvent((dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow) e.Row, e.Action));
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
      dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRowChangeEventHandler rulesRowDeletedEvent = this.tblPolicyNumberRulesRowDeletedEvent;
      if (rulesRowDeletedEvent == null)
        return;
      rulesRowDeletedEvent((object) this, new dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRowChangeEvent((dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow) e.Row, e.Action));
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
      dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRowChangeEventHandler rowDeletingEvent = this.tblPolicyNumberRulesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRowChangeEvent((dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblPolicyNumberRulesRow(
      dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLinePolicyNumbers linePolicyNumbers = new dsCompanyLinePolicyNumbers();
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
        FixedValue = linePolicyNumbers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblPolicyNumberRulesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = linePolicyNumbers.GetSchemaSerializable();
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

  public class tblCompanyLinePolicyNumbersRow : DataRow
  {
    private dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersDataTable tabletblCompanyLinePolicyNumbers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyLinePolicyNumbersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLinePolicyNumbers = (dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CompanyLineID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyLinePolicyNumbers.CompanyLineIDColumn]);
      set => this[this.tabletblCompanyLinePolicyNumbers.CompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public short PolicyNumberRuleID
    {
      get
      {
        return Conversions.ToShort(this[this.tabletblCompanyLinePolicyNumbers.PolicyNumberRuleIDColumn]);
      }
      set => this[this.tabletblCompanyLinePolicyNumbers.PolicyNumberRuleIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime Effective
    {
      get => Conversions.ToDate(this[this.tabletblCompanyLinePolicyNumbers.EffectiveColumn]);
      set => this[this.tabletblCompanyLinePolicyNumbers.EffectiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StoredProcedureName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLinePolicyNumbers.StoredProcedureNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StoredProcedureName' in table 'tblCompanyLinePolicyNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLinePolicyNumbers.StoredProcedureNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyLinePolicyNumbers.IDColumn]);
      set => this[this.tabletblCompanyLinePolicyNumbers.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow tblPolicyNumberRulesRow
    {
      get
      {
        return (dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow) this.GetParentRow(this.Table.ParentRelations["tblPolicyNumberRulestblCompanyLinePolicyNumbers"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblPolicyNumberRulestblCompanyLinePolicyNumbers"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStoredProcedureNameNull()
    {
      return this.IsNull(this.tabletblCompanyLinePolicyNumbers.StoredProcedureNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStoredProcedureNameNull()
    {
      this[this.tabletblCompanyLinePolicyNumbers.StoredProcedureNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblPolicyNumberRulesRow : DataRow
  {
    private dsCompanyLinePolicyNumbers.tblPolicyNumberRulesDataTable tabletblPolicyNumberRules;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblPolicyNumberRulesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblPolicyNumberRules = (dsCompanyLinePolicyNumbers.tblPolicyNumberRulesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public short RuleID
    {
      get => Conversions.ToShort(this[this.tabletblPolicyNumberRules.RuleIDColumn]);
      set => this[this.tabletblPolicyNumberRules.RuleIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string RuleName
    {
      get => Conversions.ToString(this[this.tabletblPolicyNumberRules.RuleNameColumn]);
      set => this[this.tabletblPolicyNumberRules.RuleNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow[] GettblCompanyLinePolicyNumbersRows()
    {
      return this.Table.ChildRelations["tblPolicyNumberRulestblCompanyLinePolicyNumbers"] != null ? (dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow[]) this.GetChildRows(this.Table.ChildRelations["tblPolicyNumberRulestblCompanyLinePolicyNumbers"]) : new dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyLinePolicyNumbersRowChangeEvent : EventArgs
  {
    private dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyLinePolicyNumbersRowChangeEvent(
      dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyLinePolicyNumbers.tblCompanyLinePolicyNumbersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblPolicyNumberRulesRowChangeEvent : EventArgs
  {
    private dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblPolicyNumberRulesRowChangeEvent(
      dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
