// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.EntityView.dsEntityView
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

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
namespace MGASystems.IMS.Accounting.GeneralLedger.EntityView;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsEntityView")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsEntityView : DataSet
{
  private dsEntityView.EntityViewDataTable tableEntityView;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsEntityView()
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
  protected dsEntityView(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (EntityView)] != null)
          base.Tables.Add((DataTable) new dsEntityView.EntityViewDataTable(dataSet.Tables[nameof (EntityView)]));
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
  public dsEntityView.EntityViewDataTable EntityView => this.tableEntityView;

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
    dsEntityView dsEntityView = (dsEntityView) base.Clone();
    dsEntityView.InitVars();
    dsEntityView.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsEntityView;
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
      if (dataSet.Tables["EntityView"] != null)
        base.Tables.Add((DataTable) new dsEntityView.EntityViewDataTable(dataSet.Tables["EntityView"]));
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
    this.tableEntityView = (dsEntityView.EntityViewDataTable) base.Tables["EntityView"];
    if (!initTable || this.tableEntityView == null)
      return;
    this.tableEntityView.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsEntityView);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsEntityView.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableEntityView = new dsEntityView.EntityViewDataTable();
    base.Tables.Add((DataTable) this.tableEntityView);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeEntityView() => false;

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
    dsEntityView dsEntityView = new dsEntityView();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = dsEntityView.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = dsEntityView.GetSchemaSerializable();
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
          current.Write((Stream) memoryStream2);
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void EntityViewRowChangeEventHandler(
    object sender,
    dsEntityView.EntityViewRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class EntityViewDataTable : TypedTableBase<dsEntityView.EntityViewRow>
  {
    private DataColumn columnTransactNum;
    private DataColumn columnPostDate;
    private DataColumn columnPayee_Remiter;
    private DataColumn columnControl_Number;
    private DataColumn columnPolicy_Number;
    private DataColumn columnInsured_Name;
    private DataColumn columnEffectiveDate;
    private DataColumn columnExpirationDate;
    private DataColumn columnLOB;
    private DataColumn columnCompany;
    private DataColumn columnProducer;
    private DataColumn columnCheck_Number;
    private DataColumn columnAR_Amount;
    private DataColumn columnAP_Amount;
    private DataColumn columnExchange_Amount;
    private DataColumn _columnUn_Accounted_Amount;
    private DataColumn columnARRem;
    private DataColumn columnAPRem;
    private DataColumn columnExchRem;
    private DataColumn columnUnacctRem;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public EntityViewDataTable()
    {
      this.TableName = "EntityView";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal EntityViewDataTable(DataTable table)
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
    protected EntityViewDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TransactNumColumn => this.columnTransactNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PostDateColumn => this.columnPostDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Payee_RemiterColumn => this.columnPayee_Remiter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Control_NumberColumn => this.columnControl_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Policy_NumberColumn => this.columnPolicy_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Insured_NameColumn => this.columnInsured_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LOBColumn => this.columnLOB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyColumn => this.columnCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerColumn => this.columnProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Check_NumberColumn => this.columnCheck_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AR_AmountColumn => this.columnAR_Amount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AP_AmountColumn => this.columnAP_Amount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Exchange_AmountColumn => this.columnExchange_Amount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn _Un_Accounted_AmountColumn => this._columnUn_Accounted_Amount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ARRemColumn => this.columnARRem;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn APRemColumn => this.columnAPRem;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExchRemColumn => this.columnExchRem;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UnacctRemColumn => this.columnUnacctRem;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEntityView.EntityViewRow this[int index]
    {
      get => (dsEntityView.EntityViewRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEntityView.EntityViewRowChangeEventHandler EntityViewRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEntityView.EntityViewRowChangeEventHandler EntityViewRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEntityView.EntityViewRowChangeEventHandler EntityViewRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEntityView.EntityViewRowChangeEventHandler EntityViewRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddEntityViewRow(dsEntityView.EntityViewRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEntityView.EntityViewRow AddEntityViewRow(
      int TransactNum,
      DateTime PostDate,
      string Payee_Remiter,
      int Control_Number,
      string Policy_Number,
      string Insured_Name,
      DateTime EffectiveDate,
      DateTime ExpirationDate,
      string LOB,
      string Company,
      string Producer,
      string Check_Number,
      Decimal AR_Amount,
      Decimal AP_Amount,
      Decimal Exchange_Amount,
      Decimal _Un_Accounted_Amount,
      Decimal ARRem,
      Decimal APRem,
      Decimal ExchRem,
      Decimal UnacctRem)
    {
      dsEntityView.EntityViewRow row = (dsEntityView.EntityViewRow) this.NewRow();
      object[] objArray = new object[20]
      {
        (object) TransactNum,
        (object) PostDate,
        (object) Payee_Remiter,
        (object) Control_Number,
        (object) Policy_Number,
        (object) Insured_Name,
        (object) EffectiveDate,
        (object) ExpirationDate,
        (object) LOB,
        (object) Company,
        (object) Producer,
        (object) Check_Number,
        (object) AR_Amount,
        (object) AP_Amount,
        (object) Exchange_Amount,
        (object) _Un_Accounted_Amount,
        (object) ARRem,
        (object) APRem,
        (object) ExchRem,
        (object) UnacctRem
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsEntityView.EntityViewDataTable entityViewDataTable = (dsEntityView.EntityViewDataTable) base.Clone();
      entityViewDataTable.InitVars();
      return (DataTable) entityViewDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsEntityView.EntityViewDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnTransactNum = this.Columns["TransactNum"];
      this.columnPostDate = this.Columns["PostDate"];
      this.columnPayee_Remiter = this.Columns["Payee_Remiter"];
      this.columnControl_Number = this.Columns["Control Number"];
      this.columnPolicy_Number = this.Columns["Policy Number"];
      this.columnInsured_Name = this.Columns["Insured Name"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnLOB = this.Columns["LOB"];
      this.columnCompany = this.Columns["Company"];
      this.columnProducer = this.Columns["Producer"];
      this.columnCheck_Number = this.Columns["Check Number"];
      this.columnAR_Amount = this.Columns["AR Amount"];
      this.columnAP_Amount = this.Columns["AP Amount"];
      this.columnExchange_Amount = this.Columns["Exchange Amount"];
      this._columnUn_Accounted_Amount = this.Columns["Un-Accounted Amount"];
      this.columnARRem = this.Columns["ARRem"];
      this.columnAPRem = this.Columns["APRem"];
      this.columnExchRem = this.Columns["ExchRem"];
      this.columnUnacctRem = this.Columns["UnacctRem"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnTransactNum = new DataColumn("TransactNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransactNum);
      this.columnPostDate = new DataColumn("PostDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPostDate);
      this.columnPayee_Remiter = new DataColumn("Payee_Remiter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayee_Remiter);
      this.columnControl_Number = new DataColumn("Control Number", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControl_Number);
      this.columnPolicy_Number = new DataColumn("Policy Number", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicy_Number);
      this.columnInsured_Name = new DataColumn("Insured Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured_Name);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnLOB = new DataColumn("LOB", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLOB);
      this.columnCompany = new DataColumn("Company", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany);
      this.columnProducer = new DataColumn("Producer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducer);
      this.columnCheck_Number = new DataColumn("Check Number", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheck_Number);
      this.columnAR_Amount = new DataColumn("AR Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAR_Amount);
      this.columnAP_Amount = new DataColumn("AP Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAP_Amount);
      this.columnExchange_Amount = new DataColumn("Exchange Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExchange_Amount);
      this._columnUn_Accounted_Amount = new DataColumn("Un-Accounted Amount", typeof (Decimal), (string) null, MappingType.Element);
      this._columnUn_Accounted_Amount.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnUn_Accounted_Amount");
      this._columnUn_Accounted_Amount.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Un-Accounted Amount");
      this.Columns.Add(this._columnUn_Accounted_Amount);
      this.columnARRem = new DataColumn("ARRem", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnARRem);
      this.columnAPRem = new DataColumn("APRem", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAPRem);
      this.columnExchRem = new DataColumn("ExchRem", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExchRem);
      this.columnUnacctRem = new DataColumn("UnacctRem", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnacctRem);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEntityView.EntityViewRow NewEntityViewRow()
    {
      return (dsEntityView.EntityViewRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsEntityView.EntityViewRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsEntityView.EntityViewRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.EntityViewRowChanged == null)
        return;
      this.EntityViewRowChanged((object) this, new dsEntityView.EntityViewRowChangeEvent((dsEntityView.EntityViewRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.EntityViewRowChanging == null)
        return;
      this.EntityViewRowChanging((object) this, new dsEntityView.EntityViewRowChangeEvent((dsEntityView.EntityViewRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.EntityViewRowDeleted == null)
        return;
      this.EntityViewRowDeleted((object) this, new dsEntityView.EntityViewRowChangeEvent((dsEntityView.EntityViewRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.EntityViewRowDeleting == null)
        return;
      this.EntityViewRowDeleting((object) this, new dsEntityView.EntityViewRowChangeEvent((dsEntityView.EntityViewRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveEntityViewRow(dsEntityView.EntityViewRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsEntityView dsEntityView = new dsEntityView();
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
        FixedValue = dsEntityView.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (EntityViewDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsEntityView.GetSchemaSerializable();
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
            current.Write((Stream) memoryStream2);
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

  public class EntityViewRow : DataRow
  {
    private dsEntityView.EntityViewDataTable tableEntityView;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal EntityViewRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableEntityView = (dsEntityView.EntityViewDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int TransactNum
    {
      get
      {
        try
        {
          return (int) this[this.tableEntityView.TransactNumColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'TransactNum' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.TransactNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime PostDate
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableEntityView.PostDateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PostDate' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.PostDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Payee_Remiter
    {
      get
      {
        try
        {
          return (string) this[this.tableEntityView.Payee_RemiterColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Payee_Remiter' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.Payee_RemiterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Control_Number
    {
      get
      {
        try
        {
          return (int) this[this.tableEntityView.Control_NumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Control Number' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.Control_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Policy_Number
    {
      get
      {
        try
        {
          return (string) this[this.tableEntityView.Policy_NumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Policy Number' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.Policy_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured_Name
    {
      get
      {
        try
        {
          return (string) this[this.tableEntityView.Insured_NameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Insured Name' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.Insured_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableEntityView.EffectiveDateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime ExpirationDate
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableEntityView.ExpirationDateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ExpirationDate' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LOB
    {
      get
      {
        try
        {
          return (string) this[this.tableEntityView.LOBColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'LOB' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.LOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Company
    {
      get
      {
        try
        {
          return (string) this[this.tableEntityView.CompanyColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Company' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.CompanyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Producer
    {
      get
      {
        try
        {
          return (string) this[this.tableEntityView.ProducerColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Producer' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.ProducerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Check_Number
    {
      get
      {
        try
        {
          return (string) this[this.tableEntityView.Check_NumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Check Number' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.Check_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AR_Amount
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableEntityView.AR_AmountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AR Amount' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.AR_AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AP_Amount
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableEntityView.AP_AmountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AP Amount' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.AP_AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Exchange_Amount
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableEntityView.Exchange_AmountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Exchange Amount' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.Exchange_AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal _Un_Accounted_Amount
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableEntityView._Un_Accounted_AmountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Un-Accounted Amount' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView._Un_Accounted_AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ARRem
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableEntityView.ARRemColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ARRem' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.ARRemColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal APRem
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableEntityView.APRemColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'APRem' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.APRemColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ExchRem
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableEntityView.ExchRemColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ExchRem' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.ExchRemColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal UnacctRem
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableEntityView.UnacctRemColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'UnacctRem' in table 'EntityView' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityView.UnacctRemColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTransactNumNull() => this.IsNull(this.tableEntityView.TransactNumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTransactNumNull()
    {
      this[this.tableEntityView.TransactNumColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPostDateNull() => this.IsNull(this.tableEntityView.PostDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPostDateNull() => this[this.tableEntityView.PostDateColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPayee_RemiterNull() => this.IsNull(this.tableEntityView.Payee_RemiterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPayee_RemiterNull()
    {
      this[this.tableEntityView.Payee_RemiterColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsControl_NumberNull() => this.IsNull(this.tableEntityView.Control_NumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetControl_NumberNull()
    {
      this[this.tableEntityView.Control_NumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicy_NumberNull() => this.IsNull(this.tableEntityView.Policy_NumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicy_NumberNull()
    {
      this[this.tableEntityView.Policy_NumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsured_NameNull() => this.IsNull(this.tableEntityView.Insured_NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsured_NameNull()
    {
      this[this.tableEntityView.Insured_NameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEffectiveDateNull() => this.IsNull(this.tableEntityView.EffectiveDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tableEntityView.EffectiveDateColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExpirationDateNull() => this.IsNull(this.tableEntityView.ExpirationDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExpirationDateNull()
    {
      this[this.tableEntityView.ExpirationDateColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLOBNull() => this.IsNull(this.tableEntityView.LOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLOBNull() => this[this.tableEntityView.LOBColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompanyNull() => this.IsNull(this.tableEntityView.CompanyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompanyNull() => this[this.tableEntityView.CompanyColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerNull() => this.IsNull(this.tableEntityView.ProducerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerNull() => this[this.tableEntityView.ProducerColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCheck_NumberNull() => this.IsNull(this.tableEntityView.Check_NumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCheck_NumberNull()
    {
      this[this.tableEntityView.Check_NumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAR_AmountNull() => this.IsNull(this.tableEntityView.AR_AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAR_AmountNull() => this[this.tableEntityView.AR_AmountColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAP_AmountNull() => this.IsNull(this.tableEntityView.AP_AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAP_AmountNull() => this[this.tableEntityView.AP_AmountColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExchange_AmountNull() => this.IsNull(this.tableEntityView.Exchange_AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExchange_AmountNull()
    {
      this[this.tableEntityView.Exchange_AmountColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Is_Un_Accounted_AmountNull()
    {
      return this.IsNull(this.tableEntityView._Un_Accounted_AmountColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Set_Un_Accounted_AmountNull()
    {
      this[this.tableEntityView._Un_Accounted_AmountColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsARRemNull() => this.IsNull(this.tableEntityView.ARRemColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetARRemNull() => this[this.tableEntityView.ARRemColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAPRemNull() => this.IsNull(this.tableEntityView.APRemColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAPRemNull() => this[this.tableEntityView.APRemColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExchRemNull() => this.IsNull(this.tableEntityView.ExchRemColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExchRemNull() => this[this.tableEntityView.ExchRemColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnacctRemNull() => this.IsNull(this.tableEntityView.UnacctRemColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnacctRemNull() => this[this.tableEntityView.UnacctRemColumn] = Convert.DBNull;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class EntityViewRowChangeEvent : EventArgs
  {
    private dsEntityView.EntityViewRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public EntityViewRowChangeEvent(dsEntityView.EntityViewRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEntityView.EntityViewRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
