// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.dsClaimExpenses
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
[XmlRoot("dsClaimExpenses")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsClaimExpenses : DataSet
{
  private dsClaimExpenses.ExpenseListDataTable tableExpenseList;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsClaimExpenses()
  {
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected dsClaimExpenses(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (ExpenseList)] != null)
          base.Tables.Add((DataTable) new dsClaimExpenses.ExpenseListDataTable(dataSet.Tables[nameof (ExpenseList)]));
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
  public dsClaimExpenses.ExpenseListDataTable ExpenseList => this.tableExpenseList;

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
    dsClaimExpenses dsClaimExpenses = (dsClaimExpenses) base.Clone();
    dsClaimExpenses.InitVars();
    dsClaimExpenses.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsClaimExpenses;
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
      if (dataSet.Tables["ExpenseList"] != null)
        base.Tables.Add((DataTable) new dsClaimExpenses.ExpenseListDataTable(dataSet.Tables["ExpenseList"]));
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
    this.tableExpenseList = (dsClaimExpenses.ExpenseListDataTable) base.Tables["ExpenseList"];
    if (!initTable || this.tableExpenseList == null)
      return;
    this.tableExpenseList.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsClaimExpenses);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsClaimExpenses.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableExpenseList = new dsClaimExpenses.ExpenseListDataTable();
    base.Tables.Add((DataTable) this.tableExpenseList);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeExpenseList() => false;

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
    dsClaimExpenses dsClaimExpenses = new dsClaimExpenses();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = dsClaimExpenses.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = dsClaimExpenses.GetSchemaSerializable();
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
  public class ExpenseListDataTable : TypedTableBase<dsClaimExpenses.ExpenseListRow>
  {
    private DataColumn columnExpenseId;
    private DataColumn columnExpense;
    private DataColumn columnHourlyCharged;
    private DataColumn columnHourlyRate;
    private DataColumn columnAllowHourlyRateEdit;
    private DataColumn columnAutomatedHours;
    private DataColumn columnMaximumHours;
    private DataColumn columnEquipmentCharged;
    private DataColumn columnEquipmentRate;
    private DataColumn columnAllowEquipmentRateEdit;
    private DataColumn columnUnitAmountCharged;
    private DataColumn columnUnitCost;
    private DataColumn columnAllowUnitCostEdit;
    private DataColumn columnAutomatedUnitCost;
    private DataColumn columnUnitCostPrompt;
    private DataColumn columnIsTax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ExpenseListDataTable()
    {
      this.TableName = "ExpenseList";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ExpenseListDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected ExpenseListDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExpenseIdColumn => this.columnExpenseId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExpenseColumn => this.columnExpense;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn HourlyChargedColumn => this.columnHourlyCharged;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn HourlyRateColumn => this.columnHourlyRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AllowHourlyRateEditColumn => this.columnAllowHourlyRateEdit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AutomatedHoursColumn => this.columnAutomatedHours;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MaximumHoursColumn => this.columnMaximumHours;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EquipmentChargedColumn => this.columnEquipmentCharged;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EquipmentRateColumn => this.columnEquipmentRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AllowEquipmentRateEditColumn => this.columnAllowEquipmentRateEdit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UnitAmountChargedColumn => this.columnUnitAmountCharged;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UnitCostColumn => this.columnUnitCost;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AllowUnitCostEditColumn => this.columnAllowUnitCostEdit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AutomatedUnitCostColumn => this.columnAutomatedUnitCost;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UnitCostPromptColumn => this.columnUnitCostPrompt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IsTaxColumn => this.columnIsTax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimExpenses.ExpenseListRow this[int index]
    {
      get => (dsClaimExpenses.ExpenseListRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsClaimExpenses.ExpenseListRowChangeEventHandler ExpenseListRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsClaimExpenses.ExpenseListRowChangeEventHandler ExpenseListRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsClaimExpenses.ExpenseListRowChangeEventHandler ExpenseListRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsClaimExpenses.ExpenseListRowChangeEventHandler ExpenseListRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddExpenseListRow(dsClaimExpenses.ExpenseListRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimExpenses.ExpenseListRow AddExpenseListRow(
      int ExpenseId,
      string Expense,
      bool HourlyCharged,
      Decimal HourlyRate,
      bool AllowHourlyRateEdit,
      Decimal AutomatedHours,
      Decimal MaximumHours,
      bool EquipmentCharged,
      Decimal EquipmentRate,
      bool AllowEquipmentRateEdit,
      bool UnitAmountCharged,
      Decimal UnitCost,
      bool AllowUnitCostEdit,
      Decimal AutomatedUnitCost,
      string UnitCostPrompt,
      bool IsTax)
    {
      dsClaimExpenses.ExpenseListRow row = (dsClaimExpenses.ExpenseListRow) this.NewRow();
      object[] objArray = new object[16 /*0x10*/]
      {
        (object) ExpenseId,
        (object) Expense,
        (object) HourlyCharged,
        (object) HourlyRate,
        (object) AllowHourlyRateEdit,
        (object) AutomatedHours,
        (object) MaximumHours,
        (object) EquipmentCharged,
        (object) EquipmentRate,
        (object) AllowEquipmentRateEdit,
        (object) UnitAmountCharged,
        (object) UnitCost,
        (object) AllowUnitCostEdit,
        (object) AutomatedUnitCost,
        (object) UnitCostPrompt,
        (object) IsTax
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimExpenses.ExpenseListDataTable expenseListDataTable = (dsClaimExpenses.ExpenseListDataTable) base.Clone();
      expenseListDataTable.InitVars();
      return (DataTable) expenseListDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimExpenses.ExpenseListDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnExpenseId = this.Columns["ExpenseId"];
      this.columnExpense = this.Columns["Expense"];
      this.columnHourlyCharged = this.Columns["HourlyCharged"];
      this.columnHourlyRate = this.Columns["HourlyRate"];
      this.columnAllowHourlyRateEdit = this.Columns["AllowHourlyRateEdit"];
      this.columnAutomatedHours = this.Columns["AutomatedHours"];
      this.columnMaximumHours = this.Columns["MaximumHours"];
      this.columnEquipmentCharged = this.Columns["EquipmentCharged"];
      this.columnEquipmentRate = this.Columns["EquipmentRate"];
      this.columnAllowEquipmentRateEdit = this.Columns["AllowEquipmentRateEdit"];
      this.columnUnitAmountCharged = this.Columns["UnitAmountCharged"];
      this.columnUnitCost = this.Columns["UnitCost"];
      this.columnAllowUnitCostEdit = this.Columns["AllowUnitCostEdit"];
      this.columnAutomatedUnitCost = this.Columns["AutomatedUnitCost"];
      this.columnUnitCostPrompt = this.Columns["UnitCostPrompt"];
      this.columnIsTax = this.Columns["IsTax"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnExpenseId = new DataColumn("ExpenseId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpenseId);
      this.columnExpense = new DataColumn("Expense", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpense);
      this.columnHourlyCharged = new DataColumn("HourlyCharged", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHourlyCharged);
      this.columnHourlyRate = new DataColumn("HourlyRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHourlyRate);
      this.columnAllowHourlyRateEdit = new DataColumn("AllowHourlyRateEdit", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAllowHourlyRateEdit);
      this.columnAutomatedHours = new DataColumn("AutomatedHours", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomatedHours);
      this.columnMaximumHours = new DataColumn("MaximumHours", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMaximumHours);
      this.columnEquipmentCharged = new DataColumn("EquipmentCharged", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEquipmentCharged);
      this.columnEquipmentRate = new DataColumn("EquipmentRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEquipmentRate);
      this.columnAllowEquipmentRateEdit = new DataColumn("AllowEquipmentRateEdit", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAllowEquipmentRateEdit);
      this.columnUnitAmountCharged = new DataColumn("UnitAmountCharged", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnitAmountCharged);
      this.columnUnitCost = new DataColumn("UnitCost", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnitCost);
      this.columnAllowUnitCostEdit = new DataColumn("AllowUnitCostEdit", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAllowUnitCostEdit);
      this.columnAutomatedUnitCost = new DataColumn("AutomatedUnitCost", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomatedUnitCost);
      this.columnUnitCostPrompt = new DataColumn("UnitCostPrompt", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnitCostPrompt);
      this.columnIsTax = new DataColumn("IsTax", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsTax);
      this.columnHourlyCharged.DefaultValue = (object) false;
      this.columnHourlyRate.DefaultValue = (object) 0M;
      this.columnAllowHourlyRateEdit.DefaultValue = (object) false;
      this.columnAutomatedHours.DefaultValue = (object) 0M;
      this.columnMaximumHours.DefaultValue = (object) 0M;
      this.columnEquipmentCharged.DefaultValue = (object) false;
      this.columnEquipmentRate.DefaultValue = (object) 0M;
      this.columnAllowEquipmentRateEdit.DefaultValue = (object) false;
      this.columnUnitAmountCharged.DefaultValue = (object) false;
      this.columnUnitCost.DefaultValue = (object) 0M;
      this.columnAllowUnitCostEdit.DefaultValue = (object) false;
      this.columnAutomatedUnitCost.DefaultValue = (object) 0M;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimExpenses.ExpenseListRow NewExpenseListRow()
    {
      return (dsClaimExpenses.ExpenseListRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimExpenses.ExpenseListRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsClaimExpenses.ExpenseListRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.ExpenseListRowChanged == null)
        return;
      this.ExpenseListRowChanged((object) this, new dsClaimExpenses.ExpenseListRowChangeEvent((dsClaimExpenses.ExpenseListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.ExpenseListRowChanging == null)
        return;
      this.ExpenseListRowChanging((object) this, new dsClaimExpenses.ExpenseListRowChangeEvent((dsClaimExpenses.ExpenseListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.ExpenseListRowDeleted == null)
        return;
      this.ExpenseListRowDeleted((object) this, new dsClaimExpenses.ExpenseListRowChangeEvent((dsClaimExpenses.ExpenseListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.ExpenseListRowDeleting == null)
        return;
      this.ExpenseListRowDeleting((object) this, new dsClaimExpenses.ExpenseListRowChangeEvent((dsClaimExpenses.ExpenseListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveExpenseListRow(dsClaimExpenses.ExpenseListRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimExpenses dsClaimExpenses = new dsClaimExpenses();
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
        FixedValue = dsClaimExpenses.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ExpenseListDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsClaimExpenses.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void ExpenseListRowChangeEventHandler(
    object sender,
    dsClaimExpenses.ExpenseListRowChangeEvent e);

  public class ExpenseListRow : DataRow
  {
    private dsClaimExpenses.ExpenseListDataTable tableExpenseList;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ExpenseListRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableExpenseList = (dsClaimExpenses.ExpenseListDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ExpenseId
    {
      get
      {
        try
        {
          return (int) this[this.tableExpenseList.ExpenseIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ExpenseId' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.ExpenseIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Expense
    {
      get
      {
        try
        {
          return (string) this[this.tableExpenseList.ExpenseColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Expense' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.ExpenseColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool HourlyCharged
    {
      get
      {
        try
        {
          return (bool) this[this.tableExpenseList.HourlyChargedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'HourlyCharged' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.HourlyChargedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal HourlyRate
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableExpenseList.HourlyRateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'HourlyRate' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.HourlyRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool AllowHourlyRateEdit
    {
      get
      {
        try
        {
          return (bool) this[this.tableExpenseList.AllowHourlyRateEditColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AllowHourlyRateEdit' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.AllowHourlyRateEditColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AutomatedHours
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableExpenseList.AutomatedHoursColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AutomatedHours' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.AutomatedHoursColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal MaximumHours
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableExpenseList.MaximumHoursColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'MaximumHours' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.MaximumHoursColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool EquipmentCharged
    {
      get
      {
        try
        {
          return (bool) this[this.tableExpenseList.EquipmentChargedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EquipmentCharged' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.EquipmentChargedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal EquipmentRate
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableExpenseList.EquipmentRateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EquipmentRate' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.EquipmentRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool AllowEquipmentRateEdit
    {
      get
      {
        try
        {
          return (bool) this[this.tableExpenseList.AllowEquipmentRateEditColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AllowEquipmentRateEdit' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.AllowEquipmentRateEditColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool UnitAmountCharged
    {
      get
      {
        try
        {
          return (bool) this[this.tableExpenseList.UnitAmountChargedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'UnitAmountCharged' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.UnitAmountChargedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal UnitCost
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableExpenseList.UnitCostColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'UnitCost' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.UnitCostColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool AllowUnitCostEdit
    {
      get
      {
        try
        {
          return (bool) this[this.tableExpenseList.AllowUnitCostEditColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AllowUnitCostEdit' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.AllowUnitCostEditColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AutomatedUnitCost
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableExpenseList.AutomatedUnitCostColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AutomatedUnitCost' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.AutomatedUnitCostColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string UnitCostPrompt
    {
      get
      {
        try
        {
          return (string) this[this.tableExpenseList.UnitCostPromptColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'UnitCostPrompt' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.UnitCostPromptColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTax
    {
      get
      {
        try
        {
          return (bool) this[this.tableExpenseList.IsTaxColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'IsTax' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.IsTaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExpenseIdNull() => this.IsNull(this.tableExpenseList.ExpenseIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExpenseIdNull() => this[this.tableExpenseList.ExpenseIdColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExpenseNull() => this.IsNull(this.tableExpenseList.ExpenseColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExpenseNull() => this[this.tableExpenseList.ExpenseColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsHourlyChargedNull() => this.IsNull(this.tableExpenseList.HourlyChargedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetHourlyChargedNull()
    {
      this[this.tableExpenseList.HourlyChargedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsHourlyRateNull() => this.IsNull(this.tableExpenseList.HourlyRateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetHourlyRateNull()
    {
      this[this.tableExpenseList.HourlyRateColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAllowHourlyRateEditNull()
    {
      return this.IsNull(this.tableExpenseList.AllowHourlyRateEditColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAllowHourlyRateEditNull()
    {
      this[this.tableExpenseList.AllowHourlyRateEditColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAutomatedHoursNull() => this.IsNull(this.tableExpenseList.AutomatedHoursColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAutomatedHoursNull()
    {
      this[this.tableExpenseList.AutomatedHoursColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMaximumHoursNull() => this.IsNull(this.tableExpenseList.MaximumHoursColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMaximumHoursNull()
    {
      this[this.tableExpenseList.MaximumHoursColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEquipmentChargedNull()
    {
      return this.IsNull(this.tableExpenseList.EquipmentChargedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEquipmentChargedNull()
    {
      this[this.tableExpenseList.EquipmentChargedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEquipmentRateNull() => this.IsNull(this.tableExpenseList.EquipmentRateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEquipmentRateNull()
    {
      this[this.tableExpenseList.EquipmentRateColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAllowEquipmentRateEditNull()
    {
      return this.IsNull(this.tableExpenseList.AllowEquipmentRateEditColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAllowEquipmentRateEditNull()
    {
      this[this.tableExpenseList.AllowEquipmentRateEditColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnitAmountChargedNull()
    {
      return this.IsNull(this.tableExpenseList.UnitAmountChargedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnitAmountChargedNull()
    {
      this[this.tableExpenseList.UnitAmountChargedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnitCostNull() => this.IsNull(this.tableExpenseList.UnitCostColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnitCostNull() => this[this.tableExpenseList.UnitCostColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAllowUnitCostEditNull()
    {
      return this.IsNull(this.tableExpenseList.AllowUnitCostEditColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAllowUnitCostEditNull()
    {
      this[this.tableExpenseList.AllowUnitCostEditColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAutomatedUnitCostNull()
    {
      return this.IsNull(this.tableExpenseList.AutomatedUnitCostColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAutomatedUnitCostNull()
    {
      this[this.tableExpenseList.AutomatedUnitCostColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnitCostPromptNull() => this.IsNull(this.tableExpenseList.UnitCostPromptColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnitCostPromptNull()
    {
      this[this.tableExpenseList.UnitCostPromptColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsIsTaxNull() => this.IsNull(this.tableExpenseList.IsTaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetIsTaxNull() => this[this.tableExpenseList.IsTaxColumn] = Convert.DBNull;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class ExpenseListRowChangeEvent : EventArgs
  {
    private dsClaimExpenses.ExpenseListRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ExpenseListRowChangeEvent(dsClaimExpenses.ExpenseListRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimExpenses.ExpenseListRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
