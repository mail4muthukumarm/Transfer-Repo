// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Budget.Datasets.dsGLAccountBudgets
// Assembly: MgaSystems.IMS.Accounting.Budget, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6BC25DF1-D5D5-4DAC-8821-336F88BA639E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Budget.dll

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
namespace MGASystems.IMS.Accounting.Budget.Datasets;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsGLAccountBudgets")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsGLAccountBudgets : DataSet
{
  private dsGLAccountBudgets.BudgetDataTable tableBudget;
  private dsGLAccountBudgets.BudgetDetailRevisionDataTable tableBudgetDetailRevision;
  private dsGLAccountBudgets.FiscalPeriodsDataTable tableFiscalPeriods;
  private dsGLAccountBudgets.BudgetDetailDataTable tableBudgetDetail;
  private DataRelation relationBudget_BudgetDetail;
  private DataRelation relationBudgetDetail_BudgetDetailRevision;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public dsGLAccountBudgets()
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
  protected dsGLAccountBudgets(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (Budget)] != null)
          base.Tables.Add((DataTable) new dsGLAccountBudgets.BudgetDataTable(dataSet.Tables[nameof (Budget)]));
        if (dataSet.Tables[nameof (BudgetDetailRevision)] != null)
          base.Tables.Add((DataTable) new dsGLAccountBudgets.BudgetDetailRevisionDataTable(dataSet.Tables[nameof (BudgetDetailRevision)]));
        if (dataSet.Tables[nameof (FiscalPeriods)] != null)
          base.Tables.Add((DataTable) new dsGLAccountBudgets.FiscalPeriodsDataTable(dataSet.Tables[nameof (FiscalPeriods)]));
        if (dataSet.Tables[nameof (BudgetDetail)] != null)
          base.Tables.Add((DataTable) new dsGLAccountBudgets.BudgetDetailDataTable(dataSet.Tables[nameof (BudgetDetail)]));
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
  public dsGLAccountBudgets.BudgetDataTable Budget => this.tableBudget;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGLAccountBudgets.BudgetDetailRevisionDataTable BudgetDetailRevision
  {
    get => this.tableBudgetDetailRevision;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGLAccountBudgets.FiscalPeriodsDataTable FiscalPeriods => this.tableFiscalPeriods;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGLAccountBudgets.BudgetDetailDataTable BudgetDetail => this.tableBudgetDetail;

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
    dsGLAccountBudgets glAccountBudgets = (dsGLAccountBudgets) base.Clone();
    glAccountBudgets.InitVars();
    glAccountBudgets.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) glAccountBudgets;
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
      if (dataSet.Tables["Budget"] != null)
        base.Tables.Add((DataTable) new dsGLAccountBudgets.BudgetDataTable(dataSet.Tables["Budget"]));
      if (dataSet.Tables["BudgetDetailRevision"] != null)
        base.Tables.Add((DataTable) new dsGLAccountBudgets.BudgetDetailRevisionDataTable(dataSet.Tables["BudgetDetailRevision"]));
      if (dataSet.Tables["FiscalPeriods"] != null)
        base.Tables.Add((DataTable) new dsGLAccountBudgets.FiscalPeriodsDataTable(dataSet.Tables["FiscalPeriods"]));
      if (dataSet.Tables["BudgetDetail"] != null)
        base.Tables.Add((DataTable) new dsGLAccountBudgets.BudgetDetailDataTable(dataSet.Tables["BudgetDetail"]));
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
    this.tableBudget = (dsGLAccountBudgets.BudgetDataTable) base.Tables["Budget"];
    if (initTable && this.tableBudget != null)
      this.tableBudget.InitVars();
    this.tableBudgetDetailRevision = (dsGLAccountBudgets.BudgetDetailRevisionDataTable) base.Tables["BudgetDetailRevision"];
    if (initTable && this.tableBudgetDetailRevision != null)
      this.tableBudgetDetailRevision.InitVars();
    this.tableFiscalPeriods = (dsGLAccountBudgets.FiscalPeriodsDataTable) base.Tables["FiscalPeriods"];
    if (initTable && this.tableFiscalPeriods != null)
      this.tableFiscalPeriods.InitVars();
    this.tableBudgetDetail = (dsGLAccountBudgets.BudgetDetailDataTable) base.Tables["BudgetDetail"];
    if (initTable && this.tableBudgetDetail != null)
      this.tableBudgetDetail.InitVars();
    this.relationBudget_BudgetDetail = this.Relations["Budget_BudgetDetail"];
    this.relationBudgetDetail_BudgetDetailRevision = this.Relations["BudgetDetail_BudgetDetailRevision"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsGLAccountBudgets);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsGLAccountBudgets.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableBudget = new dsGLAccountBudgets.BudgetDataTable();
    base.Tables.Add((DataTable) this.tableBudget);
    this.tableBudgetDetailRevision = new dsGLAccountBudgets.BudgetDetailRevisionDataTable();
    base.Tables.Add((DataTable) this.tableBudgetDetailRevision);
    this.tableFiscalPeriods = new dsGLAccountBudgets.FiscalPeriodsDataTable();
    base.Tables.Add((DataTable) this.tableFiscalPeriods);
    this.tableBudgetDetail = new dsGLAccountBudgets.BudgetDetailDataTable();
    base.Tables.Add((DataTable) this.tableBudgetDetail);
    this.relationBudget_BudgetDetail = new DataRelation("Budget_BudgetDetail", new DataColumn[1]
    {
      this.tableBudget.GlAcctIDColumn
    }, new DataColumn[1]
    {
      this.tableBudgetDetail.GLAcctIdColumn
    }, false);
    this.Relations.Add(this.relationBudget_BudgetDetail);
    this.relationBudgetDetail_BudgetDetailRevision = new DataRelation("BudgetDetail_BudgetDetailRevision", new DataColumn[2]
    {
      this.tableBudgetDetail.GLAcctIdColumn,
      this.tableBudgetDetail.CostCenterIdColumn
    }, new DataColumn[2]
    {
      this.tableBudgetDetailRevision.GLAcctIdColumn,
      this.tableBudgetDetailRevision.CostCenterIdColumn
    }, false);
    this.Relations.Add(this.relationBudgetDetail_BudgetDetailRevision);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeBudget() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeBudgetDetailRevision() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeFiscalPeriods() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeBudgetDetail() => false;

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
    dsGLAccountBudgets glAccountBudgets = new dsGLAccountBudgets();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = glAccountBudgets.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = glAccountBudgets.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void BudgetRowChangeEventHandler(
    object sender,
    dsGLAccountBudgets.BudgetRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void BudgetDetailRevisionRowChangeEventHandler(
    object sender,
    dsGLAccountBudgets.BudgetDetailRevisionRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void FiscalPeriodsRowChangeEventHandler(
    object sender,
    dsGLAccountBudgets.FiscalPeriodsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void BudgetDetailRowChangeEventHandler(
    object sender,
    dsGLAccountBudgets.BudgetDetailRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class BudgetDataTable : TypedTableBase<dsGLAccountBudgets.BudgetRow>
  {
    private DataColumn columnGlAcctID;
    private DataColumn columnFiscal_Year;
    private DataColumn columnFullName;
    private DataColumn columnF1;
    private DataColumn columnF2;
    private DataColumn columnF3;
    private DataColumn columnF4;
    private DataColumn columnF5;
    private DataColumn columnF6;
    private DataColumn columnF7;
    private DataColumn columnF8;
    private DataColumn columnF9;
    private DataColumn columnF10;
    private DataColumn columnF11;
    private DataColumn columnF12;
    private DataColumn columnGLAccountTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public BudgetDataTable()
    {
      this.TableName = "Budget";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal BudgetDataTable(DataTable table)
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
    protected BudgetDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn GlAcctIDColumn => this.columnGlAcctID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Fiscal_YearColumn => this.columnFiscal_Year;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FullNameColumn => this.columnFullName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F1Column => this.columnF1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F2Column => this.columnF2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F3Column => this.columnF3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F4Column => this.columnF4;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F5Column => this.columnF5;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F6Column => this.columnF6;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F7Column => this.columnF7;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F8Column => this.columnF8;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F9Column => this.columnF9;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F10Column => this.columnF10;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F11Column => this.columnF11;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F12Column => this.columnF12;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn GLAccountTypeIdColumn => this.columnGLAccountTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetRow this[int index]
    {
      get => (dsGLAccountBudgets.BudgetRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.BudgetRowChangeEventHandler BudgetRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.BudgetRowChangeEventHandler BudgetRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.BudgetRowChangeEventHandler BudgetRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.BudgetRowChangeEventHandler BudgetRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddBudgetRow(dsGLAccountBudgets.BudgetRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetRow AddBudgetRow(
      int GlAcctID,
      string Fiscal_Year,
      string FullName,
      Decimal F1,
      Decimal F2,
      Decimal F3,
      Decimal F4,
      Decimal F5,
      Decimal F6,
      Decimal F7,
      Decimal F8,
      Decimal F9,
      Decimal F10,
      Decimal F11,
      Decimal F12,
      string GLAccountTypeId)
    {
      dsGLAccountBudgets.BudgetRow row = (dsGLAccountBudgets.BudgetRow) this.NewRow();
      object[] objArray = new object[16 /*0x10*/]
      {
        (object) GlAcctID,
        (object) Fiscal_Year,
        (object) FullName,
        (object) F1,
        (object) F2,
        (object) F3,
        (object) F4,
        (object) F5,
        (object) F6,
        (object) F7,
        (object) F8,
        (object) F9,
        (object) F10,
        (object) F11,
        (object) F12,
        (object) GLAccountTypeId
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetRow FindByGlAcctID(int GlAcctID)
    {
      return (dsGLAccountBudgets.BudgetRow) this.Rows.Find(new object[1]
      {
        (object) GlAcctID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsGLAccountBudgets.BudgetDataTable budgetDataTable = (dsGLAccountBudgets.BudgetDataTable) base.Clone();
      budgetDataTable.InitVars();
      return (DataTable) budgetDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLAccountBudgets.BudgetDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnGlAcctID = this.Columns["GlAcctID"];
      this.columnFiscal_Year = this.Columns["Fiscal Year"];
      this.columnFullName = this.Columns["FullName"];
      this.columnF1 = this.Columns["F1"];
      this.columnF2 = this.Columns["F2"];
      this.columnF3 = this.Columns["F3"];
      this.columnF4 = this.Columns["F4"];
      this.columnF5 = this.Columns["F5"];
      this.columnF6 = this.Columns["F6"];
      this.columnF7 = this.Columns["F7"];
      this.columnF8 = this.Columns["F8"];
      this.columnF9 = this.Columns["F9"];
      this.columnF10 = this.Columns["F10"];
      this.columnF11 = this.Columns["F11"];
      this.columnF12 = this.Columns["F12"];
      this.columnGLAccountTypeId = this.Columns["GLAccountTypeId"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnGlAcctID = new DataColumn("GlAcctID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGlAcctID);
      this.columnFiscal_Year = new DataColumn("Fiscal Year", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFiscal_Year);
      this.columnFullName = new DataColumn("FullName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullName);
      this.columnF1 = new DataColumn("F1", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF1);
      this.columnF2 = new DataColumn("F2", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF2);
      this.columnF3 = new DataColumn("F3", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF3);
      this.columnF4 = new DataColumn("F4", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF4);
      this.columnF5 = new DataColumn("F5", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF5);
      this.columnF6 = new DataColumn("F6", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF6);
      this.columnF7 = new DataColumn("F7", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF7);
      this.columnF8 = new DataColumn("F8", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF8);
      this.columnF9 = new DataColumn("F9", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF9);
      this.columnF10 = new DataColumn("F10", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF10);
      this.columnF11 = new DataColumn("F11", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF11);
      this.columnF12 = new DataColumn("F12", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF12);
      this.columnGLAccountTypeId = new DataColumn("GLAccountTypeId", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAccountTypeId);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnGlAcctID
      }, true));
      this.columnGlAcctID.AllowDBNull = false;
      this.columnGlAcctID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetRow NewBudgetRow()
    {
      return (dsGLAccountBudgets.BudgetRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLAccountBudgets.BudgetRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLAccountBudgets.BudgetRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.BudgetRowChanged == null)
        return;
      this.BudgetRowChanged((object) this, new dsGLAccountBudgets.BudgetRowChangeEvent((dsGLAccountBudgets.BudgetRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.BudgetRowChanging == null)
        return;
      this.BudgetRowChanging((object) this, new dsGLAccountBudgets.BudgetRowChangeEvent((dsGLAccountBudgets.BudgetRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.BudgetRowDeleted == null)
        return;
      this.BudgetRowDeleted((object) this, new dsGLAccountBudgets.BudgetRowChangeEvent((dsGLAccountBudgets.BudgetRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.BudgetRowDeleting == null)
        return;
      this.BudgetRowDeleting((object) this, new dsGLAccountBudgets.BudgetRowChangeEvent((dsGLAccountBudgets.BudgetRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveBudgetRow(dsGLAccountBudgets.BudgetRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLAccountBudgets glAccountBudgets = new dsGLAccountBudgets();
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
        FixedValue = glAccountBudgets.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (BudgetDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = glAccountBudgets.GetSchemaSerializable();
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
  public class BudgetDetailRevisionDataTable : 
    TypedTableBase<dsGLAccountBudgets.BudgetDetailRevisionRow>
  {
    private DataColumn columnFiscalPeriod;
    private DataColumn columnOriginal;
    private DataColumn columnActual;
    private DataColumn columnActualVBudget;
    private DataColumn columnActualVBudgetPCT;
    private DataColumn columnQ1;
    private DataColumn columnQ1PercentageFromOriginal;
    private DataColumn columnQ1Actual;
    private DataColumn columnQ1ActualVBudget;
    private DataColumn columnQ1ActualVBudgetPCT;
    private DataColumn columnQ2;
    private DataColumn columnQ2PercentageFromPriorQtr;
    private DataColumn columnQ2PercentageFromOriginal;
    private DataColumn columnQ2Actual;
    private DataColumn columnQ2ActualVBudget;
    private DataColumn columnQ2ActualVBudgetPCT;
    private DataColumn columnQ3;
    private DataColumn columnQ3PercentageFromPriorQtr1;
    private DataColumn columnQ3PercentageFromPriorQtr2;
    private DataColumn columnQ3PercentageFromOriginal;
    private DataColumn columnQ3Actual;
    private DataColumn columnQ3ActualVBudget;
    private DataColumn columnQ3ActualVBudgetPCT;
    private DataColumn columnQ4;
    private DataColumn columnQ4PercentageFromPriorQtr1;
    private DataColumn columnQ4PercentageFromPriorQtr2;
    private DataColumn columnQ4PercentageFromPriorQtr3;
    private DataColumn columnQ4PercentageFromOriginal;
    private DataColumn columnQ4Actual;
    private DataColumn columnQ4ActualVBudget;
    private DataColumn columnQ4ActualVBudgetPCT;
    private DataColumn columnGLAcctId;
    private DataColumn columnCostCenter;
    private DataColumn columnCostCenterId;
    private DataColumn columnSystemDefined;
    private DataColumn columnBudgetMonth;
    private DataColumn columnFiscalKey;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public BudgetDetailRevisionDataTable()
    {
      this.TableName = "BudgetDetailRevision";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal BudgetDetailRevisionDataTable(DataTable table)
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
    protected BudgetDetailRevisionDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FiscalPeriodColumn => this.columnFiscalPeriod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn OriginalColumn => this.columnOriginal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ActualColumn => this.columnActual;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ActualVBudgetColumn => this.columnActualVBudget;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ActualVBudgetPCTColumn => this.columnActualVBudgetPCT;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q1Column => this.columnQ1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q1PercentageFromOriginalColumn => this.columnQ1PercentageFromOriginal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q1ActualColumn => this.columnQ1Actual;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q1ActualVBudgetColumn => this.columnQ1ActualVBudget;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q1ActualVBudgetPCTColumn => this.columnQ1ActualVBudgetPCT;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q2Column => this.columnQ2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q2PercentageFromPriorQtrColumn => this.columnQ2PercentageFromPriorQtr;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q2PercentageFromOriginalColumn => this.columnQ2PercentageFromOriginal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q2ActualColumn => this.columnQ2Actual;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q2ActualVBudgetColumn => this.columnQ2ActualVBudget;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q2ActualVBudgetPCTColumn => this.columnQ2ActualVBudgetPCT;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q3Column => this.columnQ3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q3PercentageFromPriorQtr1Column => this.columnQ3PercentageFromPriorQtr1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q3PercentageFromPriorQtr2Column => this.columnQ3PercentageFromPriorQtr2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q3PercentageFromOriginalColumn => this.columnQ3PercentageFromOriginal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q3ActualColumn => this.columnQ3Actual;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q3ActualVBudgetColumn => this.columnQ3ActualVBudget;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q3ActualVBudgetPCTColumn => this.columnQ3ActualVBudgetPCT;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q4Column => this.columnQ4;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q4PercentageFromPriorQtr1Column => this.columnQ4PercentageFromPriorQtr1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q4PercentageFromPriorQtr2Column => this.columnQ4PercentageFromPriorQtr2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q4PercentageFromPriorQtr3Column => this.columnQ4PercentageFromPriorQtr3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q4PercentageFromOriginalColumn => this.columnQ4PercentageFromOriginal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q4ActualColumn => this.columnQ4Actual;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q4ActualVBudgetColumn => this.columnQ4ActualVBudget;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Q4ActualVBudgetPCTColumn => this.columnQ4ActualVBudgetPCT;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn GLAcctIdColumn => this.columnGLAcctId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CostCenterColumn => this.columnCostCenter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CostCenterIdColumn => this.columnCostCenterId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn SystemDefinedColumn => this.columnSystemDefined;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn BudgetMonthColumn => this.columnBudgetMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FiscalKeyColumn => this.columnFiscalKey;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetDetailRevisionRow this[int index]
    {
      get => (dsGLAccountBudgets.BudgetDetailRevisionRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.BudgetDetailRevisionRowChangeEventHandler BudgetDetailRevisionRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.BudgetDetailRevisionRowChangeEventHandler BudgetDetailRevisionRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.BudgetDetailRevisionRowChangeEventHandler BudgetDetailRevisionRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.BudgetDetailRevisionRowChangeEventHandler BudgetDetailRevisionRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddBudgetDetailRevisionRow(dsGLAccountBudgets.BudgetDetailRevisionRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetDetailRevisionRow AddBudgetDetailRevisionRow(
      string FiscalPeriod,
      Decimal Original,
      Decimal Actual,
      Decimal ActualVBudget,
      Decimal ActualVBudgetPCT,
      Decimal Q1,
      Decimal Q1PercentageFromOriginal,
      Decimal Q1Actual,
      Decimal Q1ActualVBudget,
      Decimal Q1ActualVBudgetPCT,
      Decimal Q2,
      Decimal Q2PercentageFromPriorQtr,
      Decimal Q2PercentageFromOriginal,
      Decimal Q2Actual,
      Decimal Q2ActualVBudget,
      Decimal Q2ActualVBudgetPCT,
      Decimal Q3,
      Decimal Q3PercentageFromPriorQtr1,
      Decimal Q3PercentageFromPriorQtr2,
      Decimal Q3PercentageFromOriginal,
      Decimal Q3Actual,
      Decimal Q3ActualVBudget,
      Decimal Q3ActualVBudgetPCT,
      Decimal Q4,
      Decimal Q4PercentageFromPriorQtr1,
      Decimal Q4PercentageFromPriorQtr2,
      Decimal Q4PercentageFromPriorQtr3,
      Decimal Q4PercentageFromOriginal,
      Decimal Q4Actual,
      Decimal Q4ActualVBudget,
      Decimal Q4ActualVBudgetPCT,
      int GLAcctId,
      string CostCenter,
      int CostCenterId,
      bool SystemDefined,
      string BudgetMonth,
      string FiscalKey)
    {
      dsGLAccountBudgets.BudgetDetailRevisionRow row = (dsGLAccountBudgets.BudgetDetailRevisionRow) this.NewRow();
      object[] objArray = new object[37]
      {
        (object) FiscalPeriod,
        (object) Original,
        (object) Actual,
        (object) ActualVBudget,
        (object) ActualVBudgetPCT,
        (object) Q1,
        (object) Q1PercentageFromOriginal,
        (object) Q1Actual,
        (object) Q1ActualVBudget,
        (object) Q1ActualVBudgetPCT,
        (object) Q2,
        (object) Q2PercentageFromPriorQtr,
        (object) Q2PercentageFromOriginal,
        (object) Q2Actual,
        (object) Q2ActualVBudget,
        (object) Q2ActualVBudgetPCT,
        (object) Q3,
        (object) Q3PercentageFromPriorQtr1,
        (object) Q3PercentageFromPriorQtr2,
        (object) Q3PercentageFromOriginal,
        (object) Q3Actual,
        (object) Q3ActualVBudget,
        (object) Q3ActualVBudgetPCT,
        (object) Q4,
        (object) Q4PercentageFromPriorQtr1,
        (object) Q4PercentageFromPriorQtr2,
        (object) Q4PercentageFromPriorQtr3,
        (object) Q4PercentageFromOriginal,
        (object) Q4Actual,
        (object) Q4ActualVBudget,
        (object) Q4ActualVBudgetPCT,
        (object) GLAcctId,
        (object) CostCenter,
        (object) CostCenterId,
        (object) SystemDefined,
        (object) BudgetMonth,
        (object) FiscalKey
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsGLAccountBudgets.BudgetDetailRevisionDataTable revisionDataTable = (dsGLAccountBudgets.BudgetDetailRevisionDataTable) base.Clone();
      revisionDataTable.InitVars();
      return (DataTable) revisionDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLAccountBudgets.BudgetDetailRevisionDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnFiscalPeriod = this.Columns["FiscalPeriod"];
      this.columnOriginal = this.Columns["Original"];
      this.columnActual = this.Columns["Actual"];
      this.columnActualVBudget = this.Columns["ActualVBudget"];
      this.columnActualVBudgetPCT = this.Columns["ActualVBudgetPCT"];
      this.columnQ1 = this.Columns["Q1"];
      this.columnQ1PercentageFromOriginal = this.Columns["Q1PercentageFromOriginal"];
      this.columnQ1Actual = this.Columns["Q1Actual"];
      this.columnQ1ActualVBudget = this.Columns["Q1ActualVBudget"];
      this.columnQ1ActualVBudgetPCT = this.Columns["Q1ActualVBudgetPCT"];
      this.columnQ2 = this.Columns["Q2"];
      this.columnQ2PercentageFromPriorQtr = this.Columns["Q2PercentageFromPriorQtr"];
      this.columnQ2PercentageFromOriginal = this.Columns["Q2PercentageFromOriginal"];
      this.columnQ2Actual = this.Columns["Q2Actual"];
      this.columnQ2ActualVBudget = this.Columns["Q2ActualVBudget"];
      this.columnQ2ActualVBudgetPCT = this.Columns["Q2ActualVBudgetPCT"];
      this.columnQ3 = this.Columns["Q3"];
      this.columnQ3PercentageFromPriorQtr1 = this.Columns["Q3PercentageFromPriorQtr1"];
      this.columnQ3PercentageFromPriorQtr2 = this.Columns["Q3PercentageFromPriorQtr2"];
      this.columnQ3PercentageFromOriginal = this.Columns["Q3PercentageFromOriginal"];
      this.columnQ3Actual = this.Columns["Q3Actual"];
      this.columnQ3ActualVBudget = this.Columns["Q3ActualVBudget"];
      this.columnQ3ActualVBudgetPCT = this.Columns["Q3ActualVBudgetPCT"];
      this.columnQ4 = this.Columns["Q4"];
      this.columnQ4PercentageFromPriorQtr1 = this.Columns["Q4PercentageFromPriorQtr1"];
      this.columnQ4PercentageFromPriorQtr2 = this.Columns["Q4PercentageFromPriorQtr2"];
      this.columnQ4PercentageFromPriorQtr3 = this.Columns["Q4PercentageFromPriorQtr3"];
      this.columnQ4PercentageFromOriginal = this.Columns["Q4PercentageFromOriginal"];
      this.columnQ4Actual = this.Columns["Q4Actual"];
      this.columnQ4ActualVBudget = this.Columns["Q4ActualVBudget"];
      this.columnQ4ActualVBudgetPCT = this.Columns["Q4ActualVBudgetPCT"];
      this.columnGLAcctId = this.Columns["GLAcctId"];
      this.columnCostCenter = this.Columns["CostCenter"];
      this.columnCostCenterId = this.Columns["CostCenterId"];
      this.columnSystemDefined = this.Columns["SystemDefined"];
      this.columnBudgetMonth = this.Columns["BudgetMonth"];
      this.columnFiscalKey = this.Columns["FiscalKey"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnFiscalPeriod = new DataColumn("FiscalPeriod", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFiscalPeriod);
      this.columnOriginal = new DataColumn("Original", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOriginal);
      this.columnActual = new DataColumn("Actual", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnActual);
      this.columnActualVBudget = new DataColumn("ActualVBudget", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnActualVBudget);
      this.columnActualVBudgetPCT = new DataColumn("ActualVBudgetPCT", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnActualVBudgetPCT);
      this.columnQ1 = new DataColumn("Q1", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ1);
      this.columnQ1PercentageFromOriginal = new DataColumn("Q1PercentageFromOriginal", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ1PercentageFromOriginal);
      this.columnQ1Actual = new DataColumn("Q1Actual", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ1Actual);
      this.columnQ1ActualVBudget = new DataColumn("Q1ActualVBudget", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ1ActualVBudget);
      this.columnQ1ActualVBudgetPCT = new DataColumn("Q1ActualVBudgetPCT", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ1ActualVBudgetPCT);
      this.columnQ2 = new DataColumn("Q2", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ2);
      this.columnQ2PercentageFromPriorQtr = new DataColumn("Q2PercentageFromPriorQtr", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ2PercentageFromPriorQtr);
      this.columnQ2PercentageFromOriginal = new DataColumn("Q2PercentageFromOriginal", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ2PercentageFromOriginal);
      this.columnQ2Actual = new DataColumn("Q2Actual", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ2Actual);
      this.columnQ2ActualVBudget = new DataColumn("Q2ActualVBudget", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ2ActualVBudget);
      this.columnQ2ActualVBudgetPCT = new DataColumn("Q2ActualVBudgetPCT", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ2ActualVBudgetPCT);
      this.columnQ3 = new DataColumn("Q3", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ3);
      this.columnQ3PercentageFromPriorQtr1 = new DataColumn("Q3PercentageFromPriorQtr1", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ3PercentageFromPriorQtr1);
      this.columnQ3PercentageFromPriorQtr2 = new DataColumn("Q3PercentageFromPriorQtr2", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ3PercentageFromPriorQtr2);
      this.columnQ3PercentageFromOriginal = new DataColumn("Q3PercentageFromOriginal", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ3PercentageFromOriginal);
      this.columnQ3Actual = new DataColumn("Q3Actual", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ3Actual);
      this.columnQ3ActualVBudget = new DataColumn("Q3ActualVBudget", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ3ActualVBudget);
      this.columnQ3ActualVBudgetPCT = new DataColumn("Q3ActualVBudgetPCT", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ3ActualVBudgetPCT);
      this.columnQ4 = new DataColumn("Q4", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ4);
      this.columnQ4PercentageFromPriorQtr1 = new DataColumn("Q4PercentageFromPriorQtr1", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ4PercentageFromPriorQtr1);
      this.columnQ4PercentageFromPriorQtr2 = new DataColumn("Q4PercentageFromPriorQtr2", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ4PercentageFromPriorQtr2);
      this.columnQ4PercentageFromPriorQtr3 = new DataColumn("Q4PercentageFromPriorQtr3", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ4PercentageFromPriorQtr3);
      this.columnQ4PercentageFromOriginal = new DataColumn("Q4PercentageFromOriginal", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ4PercentageFromOriginal);
      this.columnQ4Actual = new DataColumn("Q4Actual", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ4Actual);
      this.columnQ4ActualVBudget = new DataColumn("Q4ActualVBudget", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ4ActualVBudget);
      this.columnQ4ActualVBudgetPCT = new DataColumn("Q4ActualVBudgetPCT", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQ4ActualVBudgetPCT);
      this.columnGLAcctId = new DataColumn("GLAcctId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAcctId);
      this.columnCostCenter = new DataColumn("CostCenter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenter);
      this.columnCostCenterId = new DataColumn("CostCenterId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenterId);
      this.columnSystemDefined = new DataColumn("SystemDefined", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSystemDefined);
      this.columnBudgetMonth = new DataColumn("BudgetMonth", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBudgetMonth);
      this.columnFiscalKey = new DataColumn("FiscalKey", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFiscalKey);
      this.columnGLAcctId.AllowDBNull = false;
      this.columnCostCenterId.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetDetailRevisionRow NewBudgetDetailRevisionRow()
    {
      return (dsGLAccountBudgets.BudgetDetailRevisionRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLAccountBudgets.BudgetDetailRevisionRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLAccountBudgets.BudgetDetailRevisionRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.BudgetDetailRevisionRowChanged == null)
        return;
      this.BudgetDetailRevisionRowChanged((object) this, new dsGLAccountBudgets.BudgetDetailRevisionRowChangeEvent((dsGLAccountBudgets.BudgetDetailRevisionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.BudgetDetailRevisionRowChanging == null)
        return;
      this.BudgetDetailRevisionRowChanging((object) this, new dsGLAccountBudgets.BudgetDetailRevisionRowChangeEvent((dsGLAccountBudgets.BudgetDetailRevisionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.BudgetDetailRevisionRowDeleted == null)
        return;
      this.BudgetDetailRevisionRowDeleted((object) this, new dsGLAccountBudgets.BudgetDetailRevisionRowChangeEvent((dsGLAccountBudgets.BudgetDetailRevisionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.BudgetDetailRevisionRowDeleting == null)
        return;
      this.BudgetDetailRevisionRowDeleting((object) this, new dsGLAccountBudgets.BudgetDetailRevisionRowChangeEvent((dsGLAccountBudgets.BudgetDetailRevisionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveBudgetDetailRevisionRow(dsGLAccountBudgets.BudgetDetailRevisionRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLAccountBudgets glAccountBudgets = new dsGLAccountBudgets();
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
        FixedValue = glAccountBudgets.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (BudgetDetailRevisionDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = glAccountBudgets.GetSchemaSerializable();
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
  public class FiscalPeriodsDataTable : TypedTableBase<dsGLAccountBudgets.FiscalPeriodsRow>
  {
    private DataColumn columnGLAcctId;
    private DataColumn columnFiscalPeriod;
    private DataColumn columnFiscalKey;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public FiscalPeriodsDataTable()
    {
      this.TableName = "FiscalPeriods";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal FiscalPeriodsDataTable(DataTable table)
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
    protected FiscalPeriodsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn GLAcctIdColumn => this.columnGLAcctId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FiscalPeriodColumn => this.columnFiscalPeriod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FiscalKeyColumn => this.columnFiscalKey;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.FiscalPeriodsRow this[int index]
    {
      get => (dsGLAccountBudgets.FiscalPeriodsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.FiscalPeriodsRowChangeEventHandler FiscalPeriodsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.FiscalPeriodsRowChangeEventHandler FiscalPeriodsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.FiscalPeriodsRowChangeEventHandler FiscalPeriodsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.FiscalPeriodsRowChangeEventHandler FiscalPeriodsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddFiscalPeriodsRow(dsGLAccountBudgets.FiscalPeriodsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.FiscalPeriodsRow AddFiscalPeriodsRow(
      int GLAcctId,
      string FiscalPeriod,
      string FiscalKey)
    {
      dsGLAccountBudgets.FiscalPeriodsRow row = (dsGLAccountBudgets.FiscalPeriodsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) GLAcctId,
        (object) FiscalPeriod,
        (object) FiscalKey
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsGLAccountBudgets.FiscalPeriodsDataTable periodsDataTable = (dsGLAccountBudgets.FiscalPeriodsDataTable) base.Clone();
      periodsDataTable.InitVars();
      return (DataTable) periodsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLAccountBudgets.FiscalPeriodsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnGLAcctId = this.Columns["GLAcctId"];
      this.columnFiscalPeriod = this.Columns["FiscalPeriod"];
      this.columnFiscalKey = this.Columns["FiscalKey"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnGLAcctId = new DataColumn("GLAcctId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAcctId);
      this.columnFiscalPeriod = new DataColumn("FiscalPeriod", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFiscalPeriod);
      this.columnFiscalKey = new DataColumn("FiscalKey", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFiscalKey);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.FiscalPeriodsRow NewFiscalPeriodsRow()
    {
      return (dsGLAccountBudgets.FiscalPeriodsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLAccountBudgets.FiscalPeriodsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLAccountBudgets.FiscalPeriodsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.FiscalPeriodsRowChanged == null)
        return;
      this.FiscalPeriodsRowChanged((object) this, new dsGLAccountBudgets.FiscalPeriodsRowChangeEvent((dsGLAccountBudgets.FiscalPeriodsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.FiscalPeriodsRowChanging == null)
        return;
      this.FiscalPeriodsRowChanging((object) this, new dsGLAccountBudgets.FiscalPeriodsRowChangeEvent((dsGLAccountBudgets.FiscalPeriodsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.FiscalPeriodsRowDeleted == null)
        return;
      this.FiscalPeriodsRowDeleted((object) this, new dsGLAccountBudgets.FiscalPeriodsRowChangeEvent((dsGLAccountBudgets.FiscalPeriodsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.FiscalPeriodsRowDeleting == null)
        return;
      this.FiscalPeriodsRowDeleting((object) this, new dsGLAccountBudgets.FiscalPeriodsRowChangeEvent((dsGLAccountBudgets.FiscalPeriodsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveFiscalPeriodsRow(dsGLAccountBudgets.FiscalPeriodsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLAccountBudgets glAccountBudgets = new dsGLAccountBudgets();
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
        FixedValue = glAccountBudgets.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (FiscalPeriodsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = glAccountBudgets.GetSchemaSerializable();
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
  public class BudgetDetailDataTable : TypedTableBase<dsGLAccountBudgets.BudgetDetailRow>
  {
    private DataColumn columnGLAcctId;
    private DataColumn columnCostCenterId;
    private DataColumn columnCostCenter;
    private DataColumn columnF1;
    private DataColumn columnF2;
    private DataColumn columnF3;
    private DataColumn columnF4;
    private DataColumn columnF5;
    private DataColumn columnF6;
    private DataColumn columnF7;
    private DataColumn columnF8;
    private DataColumn columnF9;
    private DataColumn columnF10;
    private DataColumn columnF11;
    private DataColumn columnF12;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public BudgetDetailDataTable()
    {
      this.TableName = "BudgetDetail";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal BudgetDetailDataTable(DataTable table)
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
    protected BudgetDetailDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn GLAcctIdColumn => this.columnGLAcctId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CostCenterIdColumn => this.columnCostCenterId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CostCenterColumn => this.columnCostCenter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F1Column => this.columnF1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F2Column => this.columnF2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F3Column => this.columnF3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F4Column => this.columnF4;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F5Column => this.columnF5;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F6Column => this.columnF6;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F7Column => this.columnF7;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F8Column => this.columnF8;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F9Column => this.columnF9;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F10Column => this.columnF10;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F11Column => this.columnF11;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn F12Column => this.columnF12;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetDetailRow this[int index]
    {
      get => (dsGLAccountBudgets.BudgetDetailRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.BudgetDetailRowChangeEventHandler BudgetDetailRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.BudgetDetailRowChangeEventHandler BudgetDetailRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.BudgetDetailRowChangeEventHandler BudgetDetailRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsGLAccountBudgets.BudgetDetailRowChangeEventHandler BudgetDetailRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddBudgetDetailRow(dsGLAccountBudgets.BudgetDetailRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetDetailRow AddBudgetDetailRow(
      dsGLAccountBudgets.BudgetRow parentBudgetRowByBudget_BudgetDetail,
      int CostCenterId,
      string CostCenter,
      Decimal F1,
      Decimal F2,
      Decimal F3,
      Decimal F4,
      Decimal F5,
      Decimal F6,
      Decimal F7,
      Decimal F8,
      Decimal F9,
      Decimal F10,
      Decimal F11,
      Decimal F12)
    {
      dsGLAccountBudgets.BudgetDetailRow row = (dsGLAccountBudgets.BudgetDetailRow) this.NewRow();
      object[] objArray = new object[15]
      {
        null,
        (object) CostCenterId,
        (object) CostCenter,
        (object) F1,
        (object) F2,
        (object) F3,
        (object) F4,
        (object) F5,
        (object) F6,
        (object) F7,
        (object) F8,
        (object) F9,
        (object) F10,
        (object) F11,
        (object) F12
      };
      if (parentBudgetRowByBudget_BudgetDetail != null)
        objArray[0] = parentBudgetRowByBudget_BudgetDetail[0];
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsGLAccountBudgets.BudgetDetailDataTable budgetDetailDataTable = (dsGLAccountBudgets.BudgetDetailDataTable) base.Clone();
      budgetDetailDataTable.InitVars();
      return (DataTable) budgetDetailDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLAccountBudgets.BudgetDetailDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnGLAcctId = this.Columns["GLAcctId"];
      this.columnCostCenterId = this.Columns["CostCenterId"];
      this.columnCostCenter = this.Columns["CostCenter"];
      this.columnF1 = this.Columns["F1"];
      this.columnF2 = this.Columns["F2"];
      this.columnF3 = this.Columns["F3"];
      this.columnF4 = this.Columns["F4"];
      this.columnF5 = this.Columns["F5"];
      this.columnF6 = this.Columns["F6"];
      this.columnF7 = this.Columns["F7"];
      this.columnF8 = this.Columns["F8"];
      this.columnF9 = this.Columns["F9"];
      this.columnF10 = this.Columns["F10"];
      this.columnF11 = this.Columns["F11"];
      this.columnF12 = this.Columns["F12"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnGLAcctId = new DataColumn("GLAcctId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAcctId);
      this.columnCostCenterId = new DataColumn("CostCenterId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenterId);
      this.columnCostCenter = new DataColumn("CostCenter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenter);
      this.columnF1 = new DataColumn("F1", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF1);
      this.columnF2 = new DataColumn("F2", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF2);
      this.columnF3 = new DataColumn("F3", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF3);
      this.columnF4 = new DataColumn("F4", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF4);
      this.columnF5 = new DataColumn("F5", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF5);
      this.columnF6 = new DataColumn("F6", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF6);
      this.columnF7 = new DataColumn("F7", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF7);
      this.columnF8 = new DataColumn("F8", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF8);
      this.columnF9 = new DataColumn("F9", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF9);
      this.columnF10 = new DataColumn("F10", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF10);
      this.columnF11 = new DataColumn("F11", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF11);
      this.columnF12 = new DataColumn("F12", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF12);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetDetailRow NewBudgetDetailRow()
    {
      return (dsGLAccountBudgets.BudgetDetailRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLAccountBudgets.BudgetDetailRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLAccountBudgets.BudgetDetailRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.BudgetDetailRowChanged == null)
        return;
      this.BudgetDetailRowChanged((object) this, new dsGLAccountBudgets.BudgetDetailRowChangeEvent((dsGLAccountBudgets.BudgetDetailRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.BudgetDetailRowChanging == null)
        return;
      this.BudgetDetailRowChanging((object) this, new dsGLAccountBudgets.BudgetDetailRowChangeEvent((dsGLAccountBudgets.BudgetDetailRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.BudgetDetailRowDeleted == null)
        return;
      this.BudgetDetailRowDeleted((object) this, new dsGLAccountBudgets.BudgetDetailRowChangeEvent((dsGLAccountBudgets.BudgetDetailRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.BudgetDetailRowDeleting == null)
        return;
      this.BudgetDetailRowDeleting((object) this, new dsGLAccountBudgets.BudgetDetailRowChangeEvent((dsGLAccountBudgets.BudgetDetailRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveBudgetDetailRow(dsGLAccountBudgets.BudgetDetailRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLAccountBudgets glAccountBudgets = new dsGLAccountBudgets();
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
        FixedValue = glAccountBudgets.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (BudgetDetailDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = glAccountBudgets.GetSchemaSerializable();
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

  public class BudgetRow : DataRow
  {
    private dsGLAccountBudgets.BudgetDataTable tableBudget;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal BudgetRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableBudget = (dsGLAccountBudgets.BudgetDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int GlAcctID
    {
      get => (int) this[this.tableBudget.GlAcctIDColumn];
      set => this[this.tableBudget.GlAcctIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Fiscal_Year
    {
      get
      {
        try
        {
          return (string) this[this.tableBudget.Fiscal_YearColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Fiscal Year' in table 'Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudget.Fiscal_YearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string FullName
    {
      get
      {
        try
        {
          return (string) this[this.tableBudget.FullNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'FullName' in table 'Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudget.FullNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F1
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudget.F1Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F1' in table 'Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudget.F1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F2
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudget.F2Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F2' in table 'Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudget.F2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F3
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudget.F3Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F3' in table 'Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudget.F3Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F4
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudget.F4Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F4' in table 'Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudget.F4Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F5
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudget.F5Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F5' in table 'Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudget.F5Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F6
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudget.F6Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F6' in table 'Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudget.F6Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F7
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudget.F7Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F7' in table 'Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudget.F7Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F8
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudget.F8Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F8' in table 'Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudget.F8Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F9
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudget.F9Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F9' in table 'Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudget.F9Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F10
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudget.F10Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F10' in table 'Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudget.F10Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F11
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudget.F11Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F11' in table 'Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudget.F11Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F12
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudget.F12Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F12' in table 'Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudget.F12Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string GLAccountTypeId
    {
      get
      {
        try
        {
          return (string) this[this.tableBudget.GLAccountTypeIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GLAccountTypeId' in table 'Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudget.GLAccountTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFiscal_YearNull() => this.IsNull(this.tableBudget.Fiscal_YearColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFiscal_YearNull() => this[this.tableBudget.Fiscal_YearColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFullNameNull() => this.IsNull(this.tableBudget.FullNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFullNameNull() => this[this.tableBudget.FullNameColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF1Null() => this.IsNull(this.tableBudget.F1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF1Null() => this[this.tableBudget.F1Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF2Null() => this.IsNull(this.tableBudget.F2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF2Null() => this[this.tableBudget.F2Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF3Null() => this.IsNull(this.tableBudget.F3Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF3Null() => this[this.tableBudget.F3Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF4Null() => this.IsNull(this.tableBudget.F4Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF4Null() => this[this.tableBudget.F4Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF5Null() => this.IsNull(this.tableBudget.F5Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF5Null() => this[this.tableBudget.F5Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF6Null() => this.IsNull(this.tableBudget.F6Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF6Null() => this[this.tableBudget.F6Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF7Null() => this.IsNull(this.tableBudget.F7Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF7Null() => this[this.tableBudget.F7Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF8Null() => this.IsNull(this.tableBudget.F8Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF8Null() => this[this.tableBudget.F8Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF9Null() => this.IsNull(this.tableBudget.F9Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF9Null() => this[this.tableBudget.F9Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF10Null() => this.IsNull(this.tableBudget.F10Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF10Null() => this[this.tableBudget.F10Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF11Null() => this.IsNull(this.tableBudget.F11Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF11Null() => this[this.tableBudget.F11Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF12Null() => this.IsNull(this.tableBudget.F12Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF12Null() => this[this.tableBudget.F12Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsGLAccountTypeIdNull() => this.IsNull(this.tableBudget.GLAccountTypeIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetGLAccountTypeIdNull()
    {
      this[this.tableBudget.GLAccountTypeIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetDetailRow[] GetBudgetDetailRows()
    {
      return this.Table.ChildRelations["Budget_BudgetDetail"] == null ? new dsGLAccountBudgets.BudgetDetailRow[0] : (dsGLAccountBudgets.BudgetDetailRow[]) this.GetChildRows(this.Table.ChildRelations["Budget_BudgetDetail"]);
    }
  }

  public class BudgetDetailRevisionRow : DataRow
  {
    private dsGLAccountBudgets.BudgetDetailRevisionDataTable tableBudgetDetailRevision;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal BudgetDetailRevisionRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableBudgetDetailRevision = (dsGLAccountBudgets.BudgetDetailRevisionDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string FiscalPeriod
    {
      get
      {
        try
        {
          return (string) this[this.tableBudgetDetailRevision.FiscalPeriodColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'FiscalPeriod' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.FiscalPeriodColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Original
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.OriginalColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Original' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.OriginalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Actual
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.ActualColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Actual' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.ActualColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal ActualVBudget
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.ActualVBudgetColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ActualVBudget' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.ActualVBudgetColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal ActualVBudgetPCT
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.ActualVBudgetPCTColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ActualVBudgetPCT' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.ActualVBudgetPCTColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q1
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q1Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q1' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q1PercentageFromOriginal
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q1PercentageFromOriginalColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q1PercentageFromOriginal' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q1PercentageFromOriginalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q1Actual
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q1ActualColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q1Actual' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q1ActualColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q1ActualVBudget
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q1ActualVBudgetColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q1ActualVBudget' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q1ActualVBudgetColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q1ActualVBudgetPCT
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q1ActualVBudgetPCTColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q1ActualVBudgetPCT' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q1ActualVBudgetPCTColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q2
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q2Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q2' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q2PercentageFromPriorQtr
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q2PercentageFromPriorQtrColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q2PercentageFromPriorQtr' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q2PercentageFromPriorQtrColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q2PercentageFromOriginal
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q2PercentageFromOriginalColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q2PercentageFromOriginal' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q2PercentageFromOriginalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q2Actual
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q2ActualColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q2Actual' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q2ActualColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q2ActualVBudget
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q2ActualVBudgetColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q2ActualVBudget' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q2ActualVBudgetColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q2ActualVBudgetPCT
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q2ActualVBudgetPCTColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q2ActualVBudgetPCT' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q2ActualVBudgetPCTColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q3
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q3Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q3' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q3Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q3PercentageFromPriorQtr1
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q3PercentageFromPriorQtr1Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q3PercentageFromPriorQtr1' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q3PercentageFromPriorQtr1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q3PercentageFromPriorQtr2
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q3PercentageFromPriorQtr2Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q3PercentageFromPriorQtr2' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q3PercentageFromPriorQtr2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q3PercentageFromOriginal
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q3PercentageFromOriginalColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q3PercentageFromOriginal' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q3PercentageFromOriginalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q3Actual
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q3ActualColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q3Actual' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q3ActualColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q3ActualVBudget
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q3ActualVBudgetColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q3ActualVBudget' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q3ActualVBudgetColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q3ActualVBudgetPCT
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q3ActualVBudgetPCTColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q3ActualVBudgetPCT' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q3ActualVBudgetPCTColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q4
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q4Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q4' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q4Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q4PercentageFromPriorQtr1
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q4PercentageFromPriorQtr1Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q4PercentageFromPriorQtr1' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q4PercentageFromPriorQtr1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q4PercentageFromPriorQtr2
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q4PercentageFromPriorQtr2Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q4PercentageFromPriorQtr2' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q4PercentageFromPriorQtr2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q4PercentageFromPriorQtr3
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q4PercentageFromPriorQtr3Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q4PercentageFromPriorQtr3' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q4PercentageFromPriorQtr3Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q4PercentageFromOriginal
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q4PercentageFromOriginalColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q4PercentageFromOriginal' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q4PercentageFromOriginalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q4Actual
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q4ActualColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q4Actual' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q4ActualColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q4ActualVBudget
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q4ActualVBudgetColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q4ActualVBudget' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q4ActualVBudgetColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Q4ActualVBudgetPCT
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetailRevision.Q4ActualVBudgetPCTColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Q4ActualVBudgetPCT' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.Q4ActualVBudgetPCTColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int GLAcctId
    {
      get => (int) this[this.tableBudgetDetailRevision.GLAcctIdColumn];
      set => this[this.tableBudgetDetailRevision.GLAcctIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string CostCenter
    {
      get
      {
        try
        {
          return (string) this[this.tableBudgetDetailRevision.CostCenterColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CostCenter' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.CostCenterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int CostCenterId
    {
      get => (int) this[this.tableBudgetDetailRevision.CostCenterIdColumn];
      set => this[this.tableBudgetDetailRevision.CostCenterIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool SystemDefined
    {
      get
      {
        try
        {
          return (bool) this[this.tableBudgetDetailRevision.SystemDefinedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'SystemDefined' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.SystemDefinedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string BudgetMonth
    {
      get
      {
        try
        {
          return (string) this[this.tableBudgetDetailRevision.BudgetMonthColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'BudgetMonth' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.BudgetMonthColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string FiscalKey
    {
      get
      {
        try
        {
          return (string) this[this.tableBudgetDetailRevision.FiscalKeyColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'FiscalKey' in table 'BudgetDetailRevision' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetailRevision.FiscalKeyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetDetailRow BudgetDetailRowParent
    {
      get
      {
        return (dsGLAccountBudgets.BudgetDetailRow) this.GetParentRow(this.Table.ParentRelations["BudgetDetail_BudgetDetailRevision"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["BudgetDetail_BudgetDetailRevision"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFiscalPeriodNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.FiscalPeriodColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFiscalPeriodNull()
    {
      this[this.tableBudgetDetailRevision.FiscalPeriodColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsOriginalNull() => this.IsNull(this.tableBudgetDetailRevision.OriginalColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetOriginalNull()
    {
      this[this.tableBudgetDetailRevision.OriginalColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsActualNull() => this.IsNull(this.tableBudgetDetailRevision.ActualColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetActualNull()
    {
      this[this.tableBudgetDetailRevision.ActualColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsActualVBudgetNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.ActualVBudgetColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetActualVBudgetNull()
    {
      this[this.tableBudgetDetailRevision.ActualVBudgetColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsActualVBudgetPCTNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.ActualVBudgetPCTColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetActualVBudgetPCTNull()
    {
      this[this.tableBudgetDetailRevision.ActualVBudgetPCTColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ1Null() => this.IsNull(this.tableBudgetDetailRevision.Q1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ1Null() => this[this.tableBudgetDetailRevision.Q1Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ1PercentageFromOriginalNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q1PercentageFromOriginalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ1PercentageFromOriginalNull()
    {
      this[this.tableBudgetDetailRevision.Q1PercentageFromOriginalColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ1ActualNull() => this.IsNull(this.tableBudgetDetailRevision.Q1ActualColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ1ActualNull()
    {
      this[this.tableBudgetDetailRevision.Q1ActualColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ1ActualVBudgetNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q1ActualVBudgetColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ1ActualVBudgetNull()
    {
      this[this.tableBudgetDetailRevision.Q1ActualVBudgetColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ1ActualVBudgetPCTNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q1ActualVBudgetPCTColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ1ActualVBudgetPCTNull()
    {
      this[this.tableBudgetDetailRevision.Q1ActualVBudgetPCTColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ2Null() => this.IsNull(this.tableBudgetDetailRevision.Q2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ2Null() => this[this.tableBudgetDetailRevision.Q2Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ2PercentageFromPriorQtrNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q2PercentageFromPriorQtrColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ2PercentageFromPriorQtrNull()
    {
      this[this.tableBudgetDetailRevision.Q2PercentageFromPriorQtrColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ2PercentageFromOriginalNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q2PercentageFromOriginalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ2PercentageFromOriginalNull()
    {
      this[this.tableBudgetDetailRevision.Q2PercentageFromOriginalColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ2ActualNull() => this.IsNull(this.tableBudgetDetailRevision.Q2ActualColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ2ActualNull()
    {
      this[this.tableBudgetDetailRevision.Q2ActualColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ2ActualVBudgetNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q2ActualVBudgetColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ2ActualVBudgetNull()
    {
      this[this.tableBudgetDetailRevision.Q2ActualVBudgetColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ2ActualVBudgetPCTNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q2ActualVBudgetPCTColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ2ActualVBudgetPCTNull()
    {
      this[this.tableBudgetDetailRevision.Q2ActualVBudgetPCTColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ3Null() => this.IsNull(this.tableBudgetDetailRevision.Q3Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ3Null() => this[this.tableBudgetDetailRevision.Q3Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ3PercentageFromPriorQtr1Null()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q3PercentageFromPriorQtr1Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ3PercentageFromPriorQtr1Null()
    {
      this[this.tableBudgetDetailRevision.Q3PercentageFromPriorQtr1Column] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ3PercentageFromPriorQtr2Null()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q3PercentageFromPriorQtr2Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ3PercentageFromPriorQtr2Null()
    {
      this[this.tableBudgetDetailRevision.Q3PercentageFromPriorQtr2Column] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ3PercentageFromOriginalNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q3PercentageFromOriginalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ3PercentageFromOriginalNull()
    {
      this[this.tableBudgetDetailRevision.Q3PercentageFromOriginalColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ3ActualNull() => this.IsNull(this.tableBudgetDetailRevision.Q3ActualColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ3ActualNull()
    {
      this[this.tableBudgetDetailRevision.Q3ActualColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ3ActualVBudgetNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q3ActualVBudgetColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ3ActualVBudgetNull()
    {
      this[this.tableBudgetDetailRevision.Q3ActualVBudgetColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ3ActualVBudgetPCTNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q3ActualVBudgetPCTColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ3ActualVBudgetPCTNull()
    {
      this[this.tableBudgetDetailRevision.Q3ActualVBudgetPCTColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ4Null() => this.IsNull(this.tableBudgetDetailRevision.Q4Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ4Null() => this[this.tableBudgetDetailRevision.Q4Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ4PercentageFromPriorQtr1Null()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q4PercentageFromPriorQtr1Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ4PercentageFromPriorQtr1Null()
    {
      this[this.tableBudgetDetailRevision.Q4PercentageFromPriorQtr1Column] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ4PercentageFromPriorQtr2Null()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q4PercentageFromPriorQtr2Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ4PercentageFromPriorQtr2Null()
    {
      this[this.tableBudgetDetailRevision.Q4PercentageFromPriorQtr2Column] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ4PercentageFromPriorQtr3Null()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q4PercentageFromPriorQtr3Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ4PercentageFromPriorQtr3Null()
    {
      this[this.tableBudgetDetailRevision.Q4PercentageFromPriorQtr3Column] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ4PercentageFromOriginalNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q4PercentageFromOriginalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ4PercentageFromOriginalNull()
    {
      this[this.tableBudgetDetailRevision.Q4PercentageFromOriginalColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ4ActualNull() => this.IsNull(this.tableBudgetDetailRevision.Q4ActualColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ4ActualNull()
    {
      this[this.tableBudgetDetailRevision.Q4ActualColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ4ActualVBudgetNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q4ActualVBudgetColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ4ActualVBudgetNull()
    {
      this[this.tableBudgetDetailRevision.Q4ActualVBudgetColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQ4ActualVBudgetPCTNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.Q4ActualVBudgetPCTColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQ4ActualVBudgetPCTNull()
    {
      this[this.tableBudgetDetailRevision.Q4ActualVBudgetPCTColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCostCenterNull() => this.IsNull(this.tableBudgetDetailRevision.CostCenterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCostCenterNull()
    {
      this[this.tableBudgetDetailRevision.CostCenterColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsSystemDefinedNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.SystemDefinedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetSystemDefinedNull()
    {
      this[this.tableBudgetDetailRevision.SystemDefinedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsBudgetMonthNull()
    {
      return this.IsNull(this.tableBudgetDetailRevision.BudgetMonthColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetBudgetMonthNull()
    {
      this[this.tableBudgetDetailRevision.BudgetMonthColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFiscalKeyNull() => this.IsNull(this.tableBudgetDetailRevision.FiscalKeyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFiscalKeyNull()
    {
      this[this.tableBudgetDetailRevision.FiscalKeyColumn] = Convert.DBNull;
    }
  }

  public class FiscalPeriodsRow : DataRow
  {
    private dsGLAccountBudgets.FiscalPeriodsDataTable tableFiscalPeriods;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal FiscalPeriodsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableFiscalPeriods = (dsGLAccountBudgets.FiscalPeriodsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int GLAcctId
    {
      get
      {
        try
        {
          return (int) this[this.tableFiscalPeriods.GLAcctIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GLAcctId' in table 'FiscalPeriods' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFiscalPeriods.GLAcctIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string FiscalPeriod
    {
      get
      {
        try
        {
          return (string) this[this.tableFiscalPeriods.FiscalPeriodColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'FiscalPeriod' in table 'FiscalPeriods' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFiscalPeriods.FiscalPeriodColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string FiscalKey
    {
      get
      {
        try
        {
          return (string) this[this.tableFiscalPeriods.FiscalKeyColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'FiscalKey' in table 'FiscalPeriods' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFiscalPeriods.FiscalKeyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsGLAcctIdNull() => this.IsNull(this.tableFiscalPeriods.GLAcctIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetGLAcctIdNull() => this[this.tableFiscalPeriods.GLAcctIdColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFiscalPeriodNull() => this.IsNull(this.tableFiscalPeriods.FiscalPeriodColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFiscalPeriodNull()
    {
      this[this.tableFiscalPeriods.FiscalPeriodColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFiscalKeyNull() => this.IsNull(this.tableFiscalPeriods.FiscalKeyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFiscalKeyNull()
    {
      this[this.tableFiscalPeriods.FiscalKeyColumn] = Convert.DBNull;
    }
  }

  public class BudgetDetailRow : DataRow
  {
    private dsGLAccountBudgets.BudgetDetailDataTable tableBudgetDetail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal BudgetDetailRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableBudgetDetail = (dsGLAccountBudgets.BudgetDetailDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int GLAcctId
    {
      get
      {
        try
        {
          return (int) this[this.tableBudgetDetail.GLAcctIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GLAcctId' in table 'BudgetDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetail.GLAcctIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int CostCenterId
    {
      get
      {
        try
        {
          return (int) this[this.tableBudgetDetail.CostCenterIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CostCenterId' in table 'BudgetDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetail.CostCenterIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string CostCenter
    {
      get
      {
        try
        {
          return (string) this[this.tableBudgetDetail.CostCenterColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CostCenter' in table 'BudgetDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetail.CostCenterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F1
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetail.F1Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F1' in table 'BudgetDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetail.F1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F2
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetail.F2Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F2' in table 'BudgetDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetail.F2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F3
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetail.F3Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F3' in table 'BudgetDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetail.F3Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F4
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetail.F4Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F4' in table 'BudgetDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetail.F4Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F5
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetail.F5Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F5' in table 'BudgetDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetail.F5Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F6
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetail.F6Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F6' in table 'BudgetDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetail.F6Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F7
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetail.F7Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F7' in table 'BudgetDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetail.F7Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F8
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetail.F8Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F8' in table 'BudgetDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetail.F8Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F9
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetail.F9Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F9' in table 'BudgetDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetail.F9Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F10
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetail.F10Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F10' in table 'BudgetDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetail.F10Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F11
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetail.F11Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F11' in table 'BudgetDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetail.F11Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal F12
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableBudgetDetail.F12Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F12' in table 'BudgetDetail' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBudgetDetail.F12Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetRow BudgetRow
    {
      get
      {
        return (dsGLAccountBudgets.BudgetRow) this.GetParentRow(this.Table.ParentRelations["Budget_BudgetDetail"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["Budget_BudgetDetail"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsGLAcctIdNull() => this.IsNull(this.tableBudgetDetail.GLAcctIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetGLAcctIdNull() => this[this.tableBudgetDetail.GLAcctIdColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCostCenterIdNull() => this.IsNull(this.tableBudgetDetail.CostCenterIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCostCenterIdNull()
    {
      this[this.tableBudgetDetail.CostCenterIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCostCenterNull() => this.IsNull(this.tableBudgetDetail.CostCenterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCostCenterNull()
    {
      this[this.tableBudgetDetail.CostCenterColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF1Null() => this.IsNull(this.tableBudgetDetail.F1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF1Null() => this[this.tableBudgetDetail.F1Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF2Null() => this.IsNull(this.tableBudgetDetail.F2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF2Null() => this[this.tableBudgetDetail.F2Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF3Null() => this.IsNull(this.tableBudgetDetail.F3Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF3Null() => this[this.tableBudgetDetail.F3Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF4Null() => this.IsNull(this.tableBudgetDetail.F4Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF4Null() => this[this.tableBudgetDetail.F4Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF5Null() => this.IsNull(this.tableBudgetDetail.F5Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF5Null() => this[this.tableBudgetDetail.F5Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF6Null() => this.IsNull(this.tableBudgetDetail.F6Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF6Null() => this[this.tableBudgetDetail.F6Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF7Null() => this.IsNull(this.tableBudgetDetail.F7Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF7Null() => this[this.tableBudgetDetail.F7Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF8Null() => this.IsNull(this.tableBudgetDetail.F8Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF8Null() => this[this.tableBudgetDetail.F8Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF9Null() => this.IsNull(this.tableBudgetDetail.F9Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF9Null() => this[this.tableBudgetDetail.F9Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF10Null() => this.IsNull(this.tableBudgetDetail.F10Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF10Null() => this[this.tableBudgetDetail.F10Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF11Null() => this.IsNull(this.tableBudgetDetail.F11Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF11Null() => this[this.tableBudgetDetail.F11Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsF12Null() => this.IsNull(this.tableBudgetDetail.F12Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetF12Null() => this[this.tableBudgetDetail.F12Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetDetailRevisionRow[] GetBudgetDetailRevisionRows()
    {
      return this.Table.ChildRelations["BudgetDetail_BudgetDetailRevision"] == null ? new dsGLAccountBudgets.BudgetDetailRevisionRow[0] : (dsGLAccountBudgets.BudgetDetailRevisionRow[]) this.GetChildRows(this.Table.ChildRelations["BudgetDetail_BudgetDetailRevision"]);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class BudgetRowChangeEvent : EventArgs
  {
    private dsGLAccountBudgets.BudgetRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public BudgetRowChangeEvent(dsGLAccountBudgets.BudgetRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class BudgetDetailRevisionRowChangeEvent : EventArgs
  {
    private dsGLAccountBudgets.BudgetDetailRevisionRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public BudgetDetailRevisionRowChangeEvent(
      dsGLAccountBudgets.BudgetDetailRevisionRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetDetailRevisionRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class FiscalPeriodsRowChangeEvent : EventArgs
  {
    private dsGLAccountBudgets.FiscalPeriodsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public FiscalPeriodsRowChangeEvent(
      dsGLAccountBudgets.FiscalPeriodsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.FiscalPeriodsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class BudgetDetailRowChangeEvent : EventArgs
  {
    private dsGLAccountBudgets.BudgetDetailRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public BudgetDetailRowChangeEvent(dsGLAccountBudgets.BudgetDetailRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsGLAccountBudgets.BudgetDetailRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
