// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsPurchaseOrderCostCenterSplit
// Assembly: MgaSystems.IMS.Accounting.Datasets, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8706ECE1-02EE-4588-9B9D-A81462107C6A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Datasets.dll

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
namespace MGASystems.IMS.Accounting.AccountingDatasets;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPurchaseOrderCostCenterSplit")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPurchaseOrderCostCenterSplit : DataSet
{
  private dsPurchaseOrderCostCenterSplit.PoCostCenterSplitDataTable tablePoCostCenterSplit;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsPurchaseOrderCostCenterSplit()
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
  protected dsPurchaseOrderCostCenterSplit(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (PoCostCenterSplit)] != null)
          base.Tables.Add((DataTable) new dsPurchaseOrderCostCenterSplit.PoCostCenterSplitDataTable(dataSet.Tables[nameof (PoCostCenterSplit)]));
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
  public dsPurchaseOrderCostCenterSplit.PoCostCenterSplitDataTable PoCostCenterSplit
  {
    get => this.tablePoCostCenterSplit;
  }

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
    dsPurchaseOrderCostCenterSplit orderCostCenterSplit = (dsPurchaseOrderCostCenterSplit) base.Clone();
    orderCostCenterSplit.InitVars();
    orderCostCenterSplit.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) orderCostCenterSplit;
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
      if (dataSet.Tables["PoCostCenterSplit"] != null)
        base.Tables.Add((DataTable) new dsPurchaseOrderCostCenterSplit.PoCostCenterSplitDataTable(dataSet.Tables["PoCostCenterSplit"]));
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
    this.tablePoCostCenterSplit = (dsPurchaseOrderCostCenterSplit.PoCostCenterSplitDataTable) base.Tables["PoCostCenterSplit"];
    if (!initTable || this.tablePoCostCenterSplit == null)
      return;
    this.tablePoCostCenterSplit.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPurchaseOrderCostCenterSplit);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPurchaseOrderCostCenterSplit.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablePoCostCenterSplit = new dsPurchaseOrderCostCenterSplit.PoCostCenterSplitDataTable();
    base.Tables.Add((DataTable) this.tablePoCostCenterSplit);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializePoCostCenterSplit() => false;

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
    dsPurchaseOrderCostCenterSplit orderCostCenterSplit = new dsPurchaseOrderCostCenterSplit();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = orderCostCenterSplit.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = orderCostCenterSplit.GetSchemaSerializable();
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
  public delegate void PoCostCenterSplitRowChangeEventHandler(
    object sender,
    dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class PoCostCenterSplitDataTable : 
    TypedTableBase<dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow>
  {
    private DataColumn columnPoNum;
    private DataColumn columnexpensecode;
    private DataColumn columnExpenseName;
    private DataColumn columncostCenterID;
    private DataColumn columnCostCenterName;
    private DataColumn columnAmount;
    private DataColumn columnoldcostcenterid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public PoCostCenterSplitDataTable()
    {
      this.TableName = "PoCostCenterSplit";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal PoCostCenterSplitDataTable(DataTable table)
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
    protected PoCostCenterSplitDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PoNumColumn => this.columnPoNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn expensecodeColumn => this.columnexpensecode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExpenseNameColumn => this.columnExpenseName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn costCenterIDColumn => this.columncostCenterID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CostCenterNameColumn => this.columnCostCenterName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AmountColumn => this.columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn oldcostcenteridColumn => this.columnoldcostcenterid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow this[int index]
    {
      get => (dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRowChangeEventHandler PoCostCenterSplitRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRowChangeEventHandler PoCostCenterSplitRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRowChangeEventHandler PoCostCenterSplitRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRowChangeEventHandler PoCostCenterSplitRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddPoCostCenterSplitRow(
      dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow AddPoCostCenterSplitRow(
      int PoNum,
      int expensecode,
      string ExpenseName,
      int costCenterID,
      string CostCenterName,
      Decimal Amount,
      int oldcostcenterid)
    {
      dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow row = (dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow) this.NewRow();
      object[] objArray = new object[7]
      {
        (object) PoNum,
        (object) expensecode,
        (object) ExpenseName,
        (object) costCenterID,
        (object) CostCenterName,
        (object) Amount,
        (object) oldcostcenterid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPurchaseOrderCostCenterSplit.PoCostCenterSplitDataTable centerSplitDataTable = (dsPurchaseOrderCostCenterSplit.PoCostCenterSplitDataTable) base.Clone();
      centerSplitDataTable.InitVars();
      return (DataTable) centerSplitDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPurchaseOrderCostCenterSplit.PoCostCenterSplitDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnPoNum = this.Columns["PoNum"];
      this.columnexpensecode = this.Columns["expensecode"];
      this.columnExpenseName = this.Columns["ExpenseName"];
      this.columncostCenterID = this.Columns["costCenterID"];
      this.columnCostCenterName = this.Columns["CostCenterName"];
      this.columnAmount = this.Columns["Amount"];
      this.columnoldcostcenterid = this.Columns["oldcostcenterid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnPoNum = new DataColumn("PoNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPoNum);
      this.columnexpensecode = new DataColumn("expensecode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnexpensecode);
      this.columnExpenseName = new DataColumn("ExpenseName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpenseName);
      this.columncostCenterID = new DataColumn("costCenterID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columncostCenterID);
      this.columnCostCenterName = new DataColumn("CostCenterName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenterName);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnoldcostcenterid = new DataColumn("oldcostcenterid", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnoldcostcenterid);
      this.columnPoNum.AllowDBNull = false;
      this.columnexpensecode.AllowDBNull = false;
      this.columnExpenseName.AllowDBNull = false;
      this.columncostCenterID.AllowDBNull = false;
      this.columnCostCenterName.AllowDBNull = false;
      this.columnAmount.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow NewPoCostCenterSplitRow()
    {
      return (dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PoCostCenterSplitRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRowChangeEventHandler splitRowChangedEvent = this.PoCostCenterSplitRowChangedEvent;
      if (splitRowChangedEvent == null)
        return;
      splitRowChangedEvent((object) this, new dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRowChangeEvent((dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PoCostCenterSplitRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRowChangeEventHandler rowChangingEvent = this.PoCostCenterSplitRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRowChangeEvent((dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PoCostCenterSplitRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRowChangeEventHandler splitRowDeletedEvent = this.PoCostCenterSplitRowDeletedEvent;
      if (splitRowDeletedEvent == null)
        return;
      splitRowDeletedEvent((object) this, new dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRowChangeEvent((dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PoCostCenterSplitRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRowChangeEventHandler rowDeletingEvent = this.PoCostCenterSplitRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRowChangeEvent((dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovePoCostCenterSplitRow(
      dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPurchaseOrderCostCenterSplit orderCostCenterSplit = new dsPurchaseOrderCostCenterSplit();
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
        FixedValue = orderCostCenterSplit.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PoCostCenterSplitDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = orderCostCenterSplit.GetSchemaSerializable();
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

  public class PoCostCenterSplitRow : DataRow
  {
    private dsPurchaseOrderCostCenterSplit.PoCostCenterSplitDataTable tablePoCostCenterSplit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal PoCostCenterSplitRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePoCostCenterSplit = (dsPurchaseOrderCostCenterSplit.PoCostCenterSplitDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int PoNum
    {
      get => Conversions.ToInteger(this[this.tablePoCostCenterSplit.PoNumColumn]);
      set => this[this.tablePoCostCenterSplit.PoNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int expensecode
    {
      get => Conversions.ToInteger(this[this.tablePoCostCenterSplit.expensecodeColumn]);
      set => this[this.tablePoCostCenterSplit.expensecodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ExpenseName
    {
      get => Conversions.ToString(this[this.tablePoCostCenterSplit.ExpenseNameColumn]);
      set => this[this.tablePoCostCenterSplit.ExpenseNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int costCenterID
    {
      get => Conversions.ToInteger(this[this.tablePoCostCenterSplit.costCenterIDColumn]);
      set => this[this.tablePoCostCenterSplit.costCenterIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CostCenterName
    {
      get => Conversions.ToString(this[this.tablePoCostCenterSplit.CostCenterNameColumn]);
      set => this[this.tablePoCostCenterSplit.CostCenterNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Amount
    {
      get => Conversions.ToDecimal(this[this.tablePoCostCenterSplit.AmountColumn]);
      set => this[this.tablePoCostCenterSplit.AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int oldcostcenterid
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePoCostCenterSplit.oldcostcenteridColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'oldcostcenterid' in table 'PoCostCenterSplit' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePoCostCenterSplit.oldcostcenteridColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsoldcostcenteridNull()
    {
      return this.IsNull(this.tablePoCostCenterSplit.oldcostcenteridColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetoldcostcenteridNull()
    {
      this[this.tablePoCostCenterSplit.oldcostcenteridColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class PoCostCenterSplitRowChangeEvent : EventArgs
  {
    private dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public PoCostCenterSplitRowChangeEvent(
      dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPurchaseOrderCostCenterSplit.PoCostCenterSplitRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
