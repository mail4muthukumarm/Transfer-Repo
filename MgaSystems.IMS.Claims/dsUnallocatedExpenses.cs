// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.dsUnallocatedExpenses
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
[XmlRoot("dsUnallocatedExpenses")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsUnallocatedExpenses : DataSet
{
  private dsUnallocatedExpenses.ExpenseListDataTable tableExpenseList;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsUnallocatedExpenses()
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
  protected dsUnallocatedExpenses(SerializationInfo info, StreamingContext context)
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
          base.Tables.Add((DataTable) new dsUnallocatedExpenses.ExpenseListDataTable(dataSet.Tables[nameof (ExpenseList)]));
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
  public dsUnallocatedExpenses.ExpenseListDataTable ExpenseList => this.tableExpenseList;

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
    dsUnallocatedExpenses unallocatedExpenses = (dsUnallocatedExpenses) base.Clone();
    unallocatedExpenses.InitVars();
    unallocatedExpenses.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) unallocatedExpenses;
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
        base.Tables.Add((DataTable) new dsUnallocatedExpenses.ExpenseListDataTable(dataSet.Tables["ExpenseList"]));
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
    this.tableExpenseList = (dsUnallocatedExpenses.ExpenseListDataTable) base.Tables["ExpenseList"];
    if (!initTable || this.tableExpenseList == null)
      return;
    this.tableExpenseList.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsUnallocatedExpenses);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsUnallocatedExpenses.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableExpenseList = new dsUnallocatedExpenses.ExpenseListDataTable();
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
    dsUnallocatedExpenses unallocatedExpenses = new dsUnallocatedExpenses();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = unallocatedExpenses.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = unallocatedExpenses.GetSchemaSerializable();
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
  public class ExpenseListDataTable : TypedTableBase<dsUnallocatedExpenses.ExpenseListRow>
  {
    private DataColumn columnUAExpenseId;
    private DataColumn columnClaimId;
    private DataColumn columnClaimantGuid;
    private DataColumn columnDateEntered;
    private DataColumn columnExpenseDescription;
    private DataColumn columnAutomationCode;
    private DataColumn columnAutomated;
    private DataColumn columnExpenseId;
    private DataColumn columnUserGuid;
    private DataColumn columnEnteredBy;
    private DataColumn columnARCreated;
    private DataColumn columnDateARCreated;
    private DataColumn columnARCreatedBy;
    private DataColumn columnWaived;
    private DataColumn columnWaivedBy;
    private DataColumn columnDateWaived;
    private DataColumn columnComments;
    private DataColumn columnHours;
    private DataColumn columnHourlyRate;
    private DataColumn columnHourlyAmount;
    private DataColumn columnEquipmentRate;
    private DataColumn columnEquipmentAmount;
    private DataColumn columnOtherCost;
    private DataColumn columnOtherCount;
    private DataColumn columnOtherAmount;
    private DataColumn columnTotalAmount;

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
    public DataColumn UAExpenseIdColumn => this.columnUAExpenseId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClaimIdColumn => this.columnClaimId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClaimantGuidColumn => this.columnClaimantGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateEnteredColumn => this.columnDateEntered;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExpenseDescriptionColumn => this.columnExpenseDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AutomationCodeColumn => this.columnAutomationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AutomatedColumn => this.columnAutomated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExpenseIdColumn => this.columnExpenseId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserGuidColumn => this.columnUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EnteredByColumn => this.columnEnteredBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ARCreatedColumn => this.columnARCreated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateARCreatedColumn => this.columnDateARCreated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ARCreatedByColumn => this.columnARCreatedBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn WaivedColumn => this.columnWaived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn WaivedByColumn => this.columnWaivedBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateWaivedColumn => this.columnDateWaived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CommentsColumn => this.columnComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn HoursColumn => this.columnHours;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn HourlyRateColumn => this.columnHourlyRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn HourlyAmountColumn => this.columnHourlyAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EquipmentRateColumn => this.columnEquipmentRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EquipmentAmountColumn => this.columnEquipmentAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OtherCostColumn => this.columnOtherCost;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OtherCountColumn => this.columnOtherCount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OtherAmountColumn => this.columnOtherAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TotalAmountColumn => this.columnTotalAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsUnallocatedExpenses.ExpenseListRow this[int index]
    {
      get => (dsUnallocatedExpenses.ExpenseListRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsUnallocatedExpenses.ExpenseListRowChangeEventHandler ExpenseListRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsUnallocatedExpenses.ExpenseListRowChangeEventHandler ExpenseListRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsUnallocatedExpenses.ExpenseListRowChangeEventHandler ExpenseListRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsUnallocatedExpenses.ExpenseListRowChangeEventHandler ExpenseListRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddExpenseListRow(dsUnallocatedExpenses.ExpenseListRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsUnallocatedExpenses.ExpenseListRow AddExpenseListRow(
      int UAExpenseId,
      int ClaimId,
      Guid ClaimantGuid,
      DateTime DateEntered,
      string ExpenseDescription,
      string AutomationCode,
      bool Automated,
      int ExpenseId,
      Guid UserGuid,
      string EnteredBy,
      bool ARCreated,
      DateTime DateARCreated,
      string ARCreatedBy,
      bool Waived,
      string WaivedBy,
      DateTime DateWaived,
      string Comments,
      Decimal Hours,
      Decimal HourlyRate,
      Decimal HourlyAmount,
      Decimal EquipmentRate,
      Decimal EquipmentAmount,
      Decimal OtherCost,
      Decimal OtherCount,
      Decimal OtherAmount,
      Decimal TotalAmount)
    {
      dsUnallocatedExpenses.ExpenseListRow row = (dsUnallocatedExpenses.ExpenseListRow) this.NewRow();
      object[] objArray = new object[26]
      {
        (object) UAExpenseId,
        (object) ClaimId,
        (object) ClaimantGuid,
        (object) DateEntered,
        (object) ExpenseDescription,
        (object) AutomationCode,
        (object) Automated,
        (object) ExpenseId,
        (object) UserGuid,
        (object) EnteredBy,
        (object) ARCreated,
        (object) DateARCreated,
        (object) ARCreatedBy,
        (object) Waived,
        (object) WaivedBy,
        (object) DateWaived,
        (object) Comments,
        (object) Hours,
        (object) HourlyRate,
        (object) HourlyAmount,
        (object) EquipmentRate,
        (object) EquipmentAmount,
        (object) OtherCost,
        (object) OtherCount,
        (object) OtherAmount,
        (object) TotalAmount
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsUnallocatedExpenses.ExpenseListDataTable expenseListDataTable = (dsUnallocatedExpenses.ExpenseListDataTable) base.Clone();
      expenseListDataTable.InitVars();
      return (DataTable) expenseListDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsUnallocatedExpenses.ExpenseListDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnUAExpenseId = this.Columns["UAExpenseId"];
      this.columnClaimId = this.Columns["ClaimId"];
      this.columnClaimantGuid = this.Columns["ClaimantGuid"];
      this.columnDateEntered = this.Columns["DateEntered"];
      this.columnExpenseDescription = this.Columns["ExpenseDescription"];
      this.columnAutomationCode = this.Columns["AutomationCode"];
      this.columnAutomated = this.Columns["Automated"];
      this.columnExpenseId = this.Columns["ExpenseId"];
      this.columnUserGuid = this.Columns["UserGuid"];
      this.columnEnteredBy = this.Columns["EnteredBy"];
      this.columnARCreated = this.Columns["ARCreated"];
      this.columnDateARCreated = this.Columns["DateARCreated"];
      this.columnARCreatedBy = this.Columns["ARCreatedBy"];
      this.columnWaived = this.Columns["Waived"];
      this.columnWaivedBy = this.Columns["WaivedBy"];
      this.columnDateWaived = this.Columns["DateWaived"];
      this.columnComments = this.Columns["Comments"];
      this.columnHours = this.Columns["Hours"];
      this.columnHourlyRate = this.Columns["HourlyRate"];
      this.columnHourlyAmount = this.Columns["HourlyAmount"];
      this.columnEquipmentRate = this.Columns["EquipmentRate"];
      this.columnEquipmentAmount = this.Columns["EquipmentAmount"];
      this.columnOtherCost = this.Columns["OtherCost"];
      this.columnOtherCount = this.Columns["OtherCount"];
      this.columnOtherAmount = this.Columns["OtherAmount"];
      this.columnTotalAmount = this.Columns["TotalAmount"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnUAExpenseId = new DataColumn("UAExpenseId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUAExpenseId);
      this.columnClaimId = new DataColumn("ClaimId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimId);
      this.columnClaimantGuid = new DataColumn("ClaimantGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimantGuid);
      this.columnDateEntered = new DataColumn("DateEntered", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateEntered);
      this.columnExpenseDescription = new DataColumn("ExpenseDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpenseDescription);
      this.columnAutomationCode = new DataColumn("AutomationCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationCode);
      this.columnAutomated = new DataColumn("Automated", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomated);
      this.columnExpenseId = new DataColumn("ExpenseId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpenseId);
      this.columnUserGuid = new DataColumn("UserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGuid);
      this.columnEnteredBy = new DataColumn("EnteredBy", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEnteredBy);
      this.columnARCreated = new DataColumn("ARCreated", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnARCreated);
      this.columnDateARCreated = new DataColumn("DateARCreated", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateARCreated);
      this.columnARCreatedBy = new DataColumn("ARCreatedBy", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnARCreatedBy);
      this.columnWaived = new DataColumn("Waived", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWaived);
      this.columnWaivedBy = new DataColumn("WaivedBy", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWaivedBy);
      this.columnDateWaived = new DataColumn("DateWaived", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateWaived);
      this.columnComments = new DataColumn("Comments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComments);
      this.columnHours = new DataColumn("Hours", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHours);
      this.columnHourlyRate = new DataColumn("HourlyRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHourlyRate);
      this.columnHourlyAmount = new DataColumn("HourlyAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHourlyAmount);
      this.columnEquipmentRate = new DataColumn("EquipmentRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEquipmentRate);
      this.columnEquipmentAmount = new DataColumn("EquipmentAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEquipmentAmount);
      this.columnOtherCost = new DataColumn("OtherCost", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOtherCost);
      this.columnOtherCount = new DataColumn("OtherCount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOtherCount);
      this.columnOtherAmount = new DataColumn("OtherAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOtherAmount);
      this.columnTotalAmount = new DataColumn("TotalAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalAmount);
      this.columnUAExpenseId.DefaultValue = (object) -1;
      this.columnExpenseId.DefaultValue = (object) -1;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsUnallocatedExpenses.ExpenseListRow NewExpenseListRow()
    {
      return (dsUnallocatedExpenses.ExpenseListRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsUnallocatedExpenses.ExpenseListRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsUnallocatedExpenses.ExpenseListRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.ExpenseListRowChanged == null)
        return;
      this.ExpenseListRowChanged((object) this, new dsUnallocatedExpenses.ExpenseListRowChangeEvent((dsUnallocatedExpenses.ExpenseListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.ExpenseListRowChanging == null)
        return;
      this.ExpenseListRowChanging((object) this, new dsUnallocatedExpenses.ExpenseListRowChangeEvent((dsUnallocatedExpenses.ExpenseListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.ExpenseListRowDeleted == null)
        return;
      this.ExpenseListRowDeleted((object) this, new dsUnallocatedExpenses.ExpenseListRowChangeEvent((dsUnallocatedExpenses.ExpenseListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.ExpenseListRowDeleting == null)
        return;
      this.ExpenseListRowDeleting((object) this, new dsUnallocatedExpenses.ExpenseListRowChangeEvent((dsUnallocatedExpenses.ExpenseListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveExpenseListRow(dsUnallocatedExpenses.ExpenseListRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsUnallocatedExpenses unallocatedExpenses = new dsUnallocatedExpenses();
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
        FixedValue = unallocatedExpenses.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ExpenseListDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = unallocatedExpenses.GetSchemaSerializable();
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
    dsUnallocatedExpenses.ExpenseListRowChangeEvent e);

  public class ExpenseListRow : DataRow
  {
    private dsUnallocatedExpenses.ExpenseListDataTable tableExpenseList;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ExpenseListRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableExpenseList = (dsUnallocatedExpenses.ExpenseListDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int UAExpenseId
    {
      get
      {
        try
        {
          return (int) this[this.tableExpenseList.UAExpenseIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'UAExpenseId' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.UAExpenseIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ClaimId
    {
      get
      {
        try
        {
          return (int) this[this.tableExpenseList.ClaimIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ClaimId' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.ClaimIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ClaimantGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tableExpenseList.ClaimantGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ClaimantGuid' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.ClaimantGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateEntered
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableExpenseList.DateEnteredColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'DateEntered' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.DateEnteredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ExpenseDescription
    {
      get
      {
        try
        {
          return (string) this[this.tableExpenseList.ExpenseDescriptionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ExpenseDescription' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.ExpenseDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AutomationCode
    {
      get
      {
        return this.IsAutomationCodeNull() ? string.Empty : (string) this[this.tableExpenseList.AutomationCodeColumn];
      }
      set => this[this.tableExpenseList.AutomationCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Automated
    {
      get
      {
        try
        {
          return (bool) this[this.tableExpenseList.AutomatedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Automated' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.AutomatedColumn] = (object) value;
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
    public Guid UserGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tableExpenseList.UserGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'UserGuid' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.UserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string EnteredBy
    {
      get
      {
        try
        {
          return (string) this[this.tableExpenseList.EnteredByColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EnteredBy' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.EnteredByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool ARCreated
    {
      get
      {
        try
        {
          return (bool) this[this.tableExpenseList.ARCreatedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ARCreated' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.ARCreatedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateARCreated
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableExpenseList.DateARCreatedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'DateARCreated' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.DateARCreatedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ARCreatedBy
    {
      get
      {
        try
        {
          return (string) this[this.tableExpenseList.ARCreatedByColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ARCreatedBy' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.ARCreatedByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Waived
    {
      get
      {
        try
        {
          return (bool) this[this.tableExpenseList.WaivedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Waived' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.WaivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string WaivedBy
    {
      get
      {
        try
        {
          return (string) this[this.tableExpenseList.WaivedByColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'WaivedBy' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.WaivedByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateWaived
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableExpenseList.DateWaivedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'DateWaived' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.DateWaivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Comments
    {
      get
      {
        return this.IsCommentsNull() ? string.Empty : (string) this[this.tableExpenseList.CommentsColumn];
      }
      set => this[this.tableExpenseList.CommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Hours
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableExpenseList.HoursColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Hours' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.HoursColumn] = (object) value;
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
    public Decimal HourlyAmount
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableExpenseList.HourlyAmountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'HourlyAmount' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.HourlyAmountColumn] = (object) value;
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
    public Decimal EquipmentAmount
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableExpenseList.EquipmentAmountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EquipmentAmount' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.EquipmentAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal OtherCost
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableExpenseList.OtherCostColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'OtherCost' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.OtherCostColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal OtherCount
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableExpenseList.OtherCountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'OtherCount' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.OtherCountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal OtherAmount
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableExpenseList.OtherAmountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'OtherAmount' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.OtherAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TotalAmount
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableExpenseList.TotalAmountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'TotalAmount' in table 'ExpenseList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseList.TotalAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUAExpenseIdNull() => this.IsNull(this.tableExpenseList.UAExpenseIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUAExpenseIdNull()
    {
      this[this.tableExpenseList.UAExpenseIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsClaimIdNull() => this.IsNull(this.tableExpenseList.ClaimIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetClaimIdNull() => this[this.tableExpenseList.ClaimIdColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsClaimantGuidNull() => this.IsNull(this.tableExpenseList.ClaimantGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetClaimantGuidNull()
    {
      this[this.tableExpenseList.ClaimantGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDateEnteredNull() => this.IsNull(this.tableExpenseList.DateEnteredColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDateEnteredNull()
    {
      this[this.tableExpenseList.DateEnteredColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExpenseDescriptionNull()
    {
      return this.IsNull(this.tableExpenseList.ExpenseDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExpenseDescriptionNull()
    {
      this[this.tableExpenseList.ExpenseDescriptionColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAutomationCodeNull() => this.IsNull(this.tableExpenseList.AutomationCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAutomationCodeNull()
    {
      this[this.tableExpenseList.AutomationCodeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAutomatedNull() => this.IsNull(this.tableExpenseList.AutomatedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAutomatedNull() => this[this.tableExpenseList.AutomatedColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExpenseIdNull() => this.IsNull(this.tableExpenseList.ExpenseIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExpenseIdNull() => this[this.tableExpenseList.ExpenseIdColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUserGuidNull() => this.IsNull(this.tableExpenseList.UserGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUserGuidNull() => this[this.tableExpenseList.UserGuidColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEnteredByNull() => this.IsNull(this.tableExpenseList.EnteredByColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEnteredByNull() => this[this.tableExpenseList.EnteredByColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsARCreatedNull() => this.IsNull(this.tableExpenseList.ARCreatedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetARCreatedNull() => this[this.tableExpenseList.ARCreatedColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDateARCreatedNull() => this.IsNull(this.tableExpenseList.DateARCreatedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDateARCreatedNull()
    {
      this[this.tableExpenseList.DateARCreatedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsARCreatedByNull() => this.IsNull(this.tableExpenseList.ARCreatedByColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetARCreatedByNull()
    {
      this[this.tableExpenseList.ARCreatedByColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsWaivedNull() => this.IsNull(this.tableExpenseList.WaivedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetWaivedNull() => this[this.tableExpenseList.WaivedColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsWaivedByNull() => this.IsNull(this.tableExpenseList.WaivedByColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetWaivedByNull() => this[this.tableExpenseList.WaivedByColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDateWaivedNull() => this.IsNull(this.tableExpenseList.DateWaivedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDateWaivedNull()
    {
      this[this.tableExpenseList.DateWaivedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCommentsNull() => this.IsNull(this.tableExpenseList.CommentsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCommentsNull() => this[this.tableExpenseList.CommentsColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsHoursNull() => this.IsNull(this.tableExpenseList.HoursColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetHoursNull() => this[this.tableExpenseList.HoursColumn] = Convert.DBNull;

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
    public bool IsHourlyAmountNull() => this.IsNull(this.tableExpenseList.HourlyAmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetHourlyAmountNull()
    {
      this[this.tableExpenseList.HourlyAmountColumn] = Convert.DBNull;
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
    public bool IsEquipmentAmountNull() => this.IsNull(this.tableExpenseList.EquipmentAmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEquipmentAmountNull()
    {
      this[this.tableExpenseList.EquipmentAmountColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOtherCostNull() => this.IsNull(this.tableExpenseList.OtherCostColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOtherCostNull() => this[this.tableExpenseList.OtherCostColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOtherCountNull() => this.IsNull(this.tableExpenseList.OtherCountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOtherCountNull()
    {
      this[this.tableExpenseList.OtherCountColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOtherAmountNull() => this.IsNull(this.tableExpenseList.OtherAmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOtherAmountNull()
    {
      this[this.tableExpenseList.OtherAmountColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTotalAmountNull() => this.IsNull(this.tableExpenseList.TotalAmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTotalAmountNull()
    {
      this[this.tableExpenseList.TotalAmountColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class ExpenseListRowChangeEvent : EventArgs
  {
    private dsUnallocatedExpenses.ExpenseListRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ExpenseListRowChangeEvent(dsUnallocatedExpenses.ExpenseListRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsUnallocatedExpenses.ExpenseListRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
