// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsChangeCostCenter
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
[XmlRoot("dsChangeCostCenter")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsChangeCostCenter : DataSet
{
  private dsChangeCostCenter.SearchInvoiceDataDataTable tableSearchInvoiceData;
  private dsChangeCostCenter.CostCenterDataDataTable tableCostCenterData;
  private DataRelation relationSearchInvoiceDataCostCenterData;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsChangeCostCenter()
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
  protected dsChangeCostCenter(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (SearchInvoiceData)] != null)
          base.Tables.Add((DataTable) new dsChangeCostCenter.SearchInvoiceDataDataTable(dataSet.Tables[nameof (SearchInvoiceData)]));
        if (dataSet.Tables[nameof (CostCenterData)] != null)
          base.Tables.Add((DataTable) new dsChangeCostCenter.CostCenterDataDataTable(dataSet.Tables[nameof (CostCenterData)]));
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
  public dsChangeCostCenter.SearchInvoiceDataDataTable SearchInvoiceData
  {
    get => this.tableSearchInvoiceData;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsChangeCostCenter.CostCenterDataDataTable CostCenterData => this.tableCostCenterData;

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
    dsChangeCostCenter changeCostCenter = (dsChangeCostCenter) base.Clone();
    changeCostCenter.InitVars();
    changeCostCenter.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) changeCostCenter;
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
      if (dataSet.Tables["SearchInvoiceData"] != null)
        base.Tables.Add((DataTable) new dsChangeCostCenter.SearchInvoiceDataDataTable(dataSet.Tables["SearchInvoiceData"]));
      if (dataSet.Tables["CostCenterData"] != null)
        base.Tables.Add((DataTable) new dsChangeCostCenter.CostCenterDataDataTable(dataSet.Tables["CostCenterData"]));
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
    this.tableSearchInvoiceData = (dsChangeCostCenter.SearchInvoiceDataDataTable) base.Tables["SearchInvoiceData"];
    if (initTable && this.tableSearchInvoiceData != null)
      this.tableSearchInvoiceData.InitVars();
    this.tableCostCenterData = (dsChangeCostCenter.CostCenterDataDataTable) base.Tables["CostCenterData"];
    if (initTable && this.tableCostCenterData != null)
      this.tableCostCenterData.InitVars();
    this.relationSearchInvoiceDataCostCenterData = this.Relations["SearchInvoiceDataCostCenterData"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsChangeCostCenter);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsChangeCostCenter.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableSearchInvoiceData = new dsChangeCostCenter.SearchInvoiceDataDataTable();
    base.Tables.Add((DataTable) this.tableSearchInvoiceData);
    this.tableCostCenterData = new dsChangeCostCenter.CostCenterDataDataTable();
    base.Tables.Add((DataTable) this.tableCostCenterData);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("SearchInvoiceDataCostCenterData", new DataColumn[1]
    {
      this.tableSearchInvoiceData.transactnumColumn
    }, new DataColumn[1]
    {
      this.tableCostCenterData.transactnumColumn
    });
    this.tableCostCenterData.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationSearchInvoiceDataCostCenterData = new DataRelation("SearchInvoiceDataCostCenterData", new DataColumn[1]
    {
      this.tableSearchInvoiceData.transactnumColumn
    }, new DataColumn[1]
    {
      this.tableCostCenterData.transactnumColumn
    }, false);
    this.Relations.Add(this.relationSearchInvoiceDataCostCenterData);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeSearchInvoiceData() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeCostCenterData() => false;

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
    dsChangeCostCenter changeCostCenter = new dsChangeCostCenter();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = changeCostCenter.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = changeCostCenter.GetSchemaSerializable();
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
  public delegate void SearchInvoiceDataRowChangeEventHandler(
    object sender,
    dsChangeCostCenter.SearchInvoiceDataRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void CostCenterDataRowChangeEventHandler(
    object sender,
    dsChangeCostCenter.CostCenterDataRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class SearchInvoiceDataDataTable : TypedTableBase<dsChangeCostCenter.SearchInvoiceDataRow>
  {
    private DataColumn columntransactnum;
    private DataColumn columnpostdate;
    private DataColumn columnusername;
    private DataColumn columntransdescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public SearchInvoiceDataDataTable()
    {
      this.TableName = "SearchInvoiceData";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal SearchInvoiceDataDataTable(DataTable table)
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
    protected SearchInvoiceDataDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn transactnumColumn => this.columntransactnum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn postdateColumn => this.columnpostdate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn usernameColumn => this.columnusername;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn transdescriptionColumn => this.columntransdescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsChangeCostCenter.SearchInvoiceDataRow this[int index]
    {
      get => (dsChangeCostCenter.SearchInvoiceDataRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsChangeCostCenter.SearchInvoiceDataRowChangeEventHandler SearchInvoiceDataRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsChangeCostCenter.SearchInvoiceDataRowChangeEventHandler SearchInvoiceDataRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsChangeCostCenter.SearchInvoiceDataRowChangeEventHandler SearchInvoiceDataRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsChangeCostCenter.SearchInvoiceDataRowChangeEventHandler SearchInvoiceDataRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddSearchInvoiceDataRow(dsChangeCostCenter.SearchInvoiceDataRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsChangeCostCenter.SearchInvoiceDataRow AddSearchInvoiceDataRow(
      int transactnum,
      DateTime postdate,
      string username,
      string transdescription)
    {
      dsChangeCostCenter.SearchInvoiceDataRow row = (dsChangeCostCenter.SearchInvoiceDataRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) transactnum,
        (object) postdate,
        (object) username,
        (object) transdescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsChangeCostCenter.SearchInvoiceDataDataTable invoiceDataDataTable = (dsChangeCostCenter.SearchInvoiceDataDataTable) base.Clone();
      invoiceDataDataTable.InitVars();
      return (DataTable) invoiceDataDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsChangeCostCenter.SearchInvoiceDataDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columntransactnum = this.Columns["transactnum"];
      this.columnpostdate = this.Columns["postdate"];
      this.columnusername = this.Columns["username"];
      this.columntransdescription = this.Columns["transdescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columntransactnum = new DataColumn("transactnum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransactnum);
      this.columnpostdate = new DataColumn("postdate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpostdate);
      this.columnusername = new DataColumn("username", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnusername);
      this.columntransdescription = new DataColumn("transdescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransdescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsChangeCostCenterKey1", new DataColumn[1]
      {
        this.columntransactnum
      }, false));
      this.columntransactnum.AllowDBNull = false;
      this.columntransactnum.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsChangeCostCenter.SearchInvoiceDataRow NewSearchInvoiceDataRow()
    {
      return (dsChangeCostCenter.SearchInvoiceDataRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsChangeCostCenter.SearchInvoiceDataRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsChangeCostCenter.SearchInvoiceDataRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SearchInvoiceDataRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChangeCostCenter.SearchInvoiceDataRowChangeEventHandler dataRowChangedEvent = this.SearchInvoiceDataRowChangedEvent;
      if (dataRowChangedEvent == null)
        return;
      dataRowChangedEvent((object) this, new dsChangeCostCenter.SearchInvoiceDataRowChangeEvent((dsChangeCostCenter.SearchInvoiceDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SearchInvoiceDataRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChangeCostCenter.SearchInvoiceDataRowChangeEventHandler rowChangingEvent = this.SearchInvoiceDataRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsChangeCostCenter.SearchInvoiceDataRowChangeEvent((dsChangeCostCenter.SearchInvoiceDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SearchInvoiceDataRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChangeCostCenter.SearchInvoiceDataRowChangeEventHandler dataRowDeletedEvent = this.SearchInvoiceDataRowDeletedEvent;
      if (dataRowDeletedEvent == null)
        return;
      dataRowDeletedEvent((object) this, new dsChangeCostCenter.SearchInvoiceDataRowChangeEvent((dsChangeCostCenter.SearchInvoiceDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SearchInvoiceDataRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChangeCostCenter.SearchInvoiceDataRowChangeEventHandler rowDeletingEvent = this.SearchInvoiceDataRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsChangeCostCenter.SearchInvoiceDataRowChangeEvent((dsChangeCostCenter.SearchInvoiceDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveSearchInvoiceDataRow(dsChangeCostCenter.SearchInvoiceDataRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsChangeCostCenter changeCostCenter = new dsChangeCostCenter();
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
        FixedValue = changeCostCenter.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (SearchInvoiceDataDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = changeCostCenter.GetSchemaSerializable();
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
  public class CostCenterDataDataTable : TypedTableBase<dsChangeCostCenter.CostCenterDataRow>
  {
    private DataColumn columntransactnum;
    private DataColumn columncostCenter;
    private DataColumn columncostCenterName;
    private DataColumn columnpostingNum;
    private DataColumn columnglAccount;
    private DataColumn columnAmount;
    private DataColumn columninvoicedate;
    private DataColumn columninsured;
    private DataColumn columnpolicyNumber;
    private DataColumn columnexpenseCode;
    private DataColumn columnExpense;
    private DataColumn columnNewcostcenterID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public CostCenterDataDataTable()
    {
      this.TableName = "CostCenterData";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal CostCenterDataDataTable(DataTable table)
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
    protected CostCenterDataDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn transactnumColumn => this.columntransactnum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn costCenterColumn => this.columncostCenter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn costCenterNameColumn => this.columncostCenterName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn postingNumColumn => this.columnpostingNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn glAccountColumn => this.columnglAccount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AmountColumn => this.columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn invoicedateColumn => this.columninvoicedate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn insuredColumn => this.columninsured;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn policyNumberColumn => this.columnpolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn expenseCodeColumn => this.columnexpenseCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExpenseColumn => this.columnExpense;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NewcostcenterIDColumn => this.columnNewcostcenterID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsChangeCostCenter.CostCenterDataRow this[int index]
    {
      get => (dsChangeCostCenter.CostCenterDataRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsChangeCostCenter.CostCenterDataRowChangeEventHandler CostCenterDataRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsChangeCostCenter.CostCenterDataRowChangeEventHandler CostCenterDataRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsChangeCostCenter.CostCenterDataRowChangeEventHandler CostCenterDataRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsChangeCostCenter.CostCenterDataRowChangeEventHandler CostCenterDataRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddCostCenterDataRow(dsChangeCostCenter.CostCenterDataRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsChangeCostCenter.CostCenterDataRow AddCostCenterDataRow(
      dsChangeCostCenter.SearchInvoiceDataRow parentSearchInvoiceDataRowBySearchInvoiceDataCostCenterData,
      int costCenter,
      string costCenterName,
      int postingNum,
      string glAccount,
      Decimal Amount,
      DateTime invoicedate,
      string insured,
      string policyNumber,
      string expenseCode,
      string Expense,
      int NewcostcenterID)
    {
      dsChangeCostCenter.CostCenterDataRow row = (dsChangeCostCenter.CostCenterDataRow) this.NewRow();
      object[] objArray = new object[12]
      {
        null,
        (object) costCenter,
        (object) costCenterName,
        (object) postingNum,
        (object) glAccount,
        (object) Amount,
        (object) invoicedate,
        (object) insured,
        (object) policyNumber,
        (object) expenseCode,
        (object) Expense,
        (object) NewcostcenterID
      };
      if (parentSearchInvoiceDataRowBySearchInvoiceDataCostCenterData != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parentSearchInvoiceDataRowBySearchInvoiceDataCostCenterData[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsChangeCostCenter.CostCenterDataDataTable centerDataDataTable = (dsChangeCostCenter.CostCenterDataDataTable) base.Clone();
      centerDataDataTable.InitVars();
      return (DataTable) centerDataDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsChangeCostCenter.CostCenterDataDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columntransactnum = this.Columns["transactnum"];
      this.columncostCenter = this.Columns["costCenter"];
      this.columncostCenterName = this.Columns["costCenterName"];
      this.columnpostingNum = this.Columns["postingNum"];
      this.columnglAccount = this.Columns["glAccount"];
      this.columnAmount = this.Columns["Amount"];
      this.columninvoicedate = this.Columns["invoicedate"];
      this.columninsured = this.Columns["insured"];
      this.columnpolicyNumber = this.Columns["policyNumber"];
      this.columnexpenseCode = this.Columns["expenseCode"];
      this.columnExpense = this.Columns["Expense"];
      this.columnNewcostcenterID = this.Columns["NewcostcenterID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columntransactnum = new DataColumn("transactnum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransactnum);
      this.columncostCenter = new DataColumn("costCenter", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columncostCenter);
      this.columncostCenterName = new DataColumn("costCenterName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columncostCenterName);
      this.columnpostingNum = new DataColumn("postingNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpostingNum);
      this.columnglAccount = new DataColumn("glAccount", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnglAccount);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columninvoicedate = new DataColumn("invoicedate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columninvoicedate);
      this.columninsured = new DataColumn("insured", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columninsured);
      this.columnpolicyNumber = new DataColumn("policyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpolicyNumber);
      this.columnexpenseCode = new DataColumn("expenseCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnexpenseCode);
      this.columnExpense = new DataColumn("Expense", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpense);
      this.columnNewcostcenterID = new DataColumn("NewcostcenterID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNewcostcenterID);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsChangeCostCenter.CostCenterDataRow NewCostCenterDataRow()
    {
      return (dsChangeCostCenter.CostCenterDataRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsChangeCostCenter.CostCenterDataRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsChangeCostCenter.CostCenterDataRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CostCenterDataRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChangeCostCenter.CostCenterDataRowChangeEventHandler dataRowChangedEvent = this.CostCenterDataRowChangedEvent;
      if (dataRowChangedEvent == null)
        return;
      dataRowChangedEvent((object) this, new dsChangeCostCenter.CostCenterDataRowChangeEvent((dsChangeCostCenter.CostCenterDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CostCenterDataRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChangeCostCenter.CostCenterDataRowChangeEventHandler rowChangingEvent = this.CostCenterDataRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsChangeCostCenter.CostCenterDataRowChangeEvent((dsChangeCostCenter.CostCenterDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CostCenterDataRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChangeCostCenter.CostCenterDataRowChangeEventHandler dataRowDeletedEvent = this.CostCenterDataRowDeletedEvent;
      if (dataRowDeletedEvent == null)
        return;
      dataRowDeletedEvent((object) this, new dsChangeCostCenter.CostCenterDataRowChangeEvent((dsChangeCostCenter.CostCenterDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CostCenterDataRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsChangeCostCenter.CostCenterDataRowChangeEventHandler rowDeletingEvent = this.CostCenterDataRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsChangeCostCenter.CostCenterDataRowChangeEvent((dsChangeCostCenter.CostCenterDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveCostCenterDataRow(dsChangeCostCenter.CostCenterDataRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsChangeCostCenter changeCostCenter = new dsChangeCostCenter();
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
        FixedValue = changeCostCenter.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CostCenterDataDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = changeCostCenter.GetSchemaSerializable();
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

  public class SearchInvoiceDataRow : DataRow
  {
    private dsChangeCostCenter.SearchInvoiceDataDataTable tableSearchInvoiceData;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal SearchInvoiceDataRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableSearchInvoiceData = (dsChangeCostCenter.SearchInvoiceDataDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int transactnum
    {
      get => Conversions.ToInteger(this[this.tableSearchInvoiceData.transactnumColumn]);
      set => this[this.tableSearchInvoiceData.transactnumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime postdate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableSearchInvoiceData.postdateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'postdate' in table 'SearchInvoiceData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSearchInvoiceData.postdateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string username
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSearchInvoiceData.usernameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'username' in table 'SearchInvoiceData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSearchInvoiceData.usernameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string transdescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSearchInvoiceData.transdescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'transdescription' in table 'SearchInvoiceData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSearchInvoiceData.transdescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IspostdateNull() => this.IsNull(this.tableSearchInvoiceData.postdateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetpostdateNull()
    {
      this[this.tableSearchInvoiceData.postdateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsusernameNull() => this.IsNull(this.tableSearchInvoiceData.usernameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetusernameNull()
    {
      this[this.tableSearchInvoiceData.usernameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IstransdescriptionNull()
    {
      return this.IsNull(this.tableSearchInvoiceData.transdescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SettransdescriptionNull()
    {
      this[this.tableSearchInvoiceData.transdescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsChangeCostCenter.CostCenterDataRow[] GetCostCenterDataRows()
    {
      return this.Table.ChildRelations["SearchInvoiceDataCostCenterData"] != null ? (dsChangeCostCenter.CostCenterDataRow[]) this.GetChildRows(this.Table.ChildRelations["SearchInvoiceDataCostCenterData"]) : new dsChangeCostCenter.CostCenterDataRow[0];
    }
  }

  public class CostCenterDataRow : DataRow
  {
    private dsChangeCostCenter.CostCenterDataDataTable tableCostCenterData;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal CostCenterDataRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCostCenterData = (dsChangeCostCenter.CostCenterDataDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int transactnum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableCostCenterData.transactnumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'transactnum' in table 'CostCenterData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenterData.transactnumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int costCenter
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableCostCenterData.costCenterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'costCenter' in table 'CostCenterData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenterData.costCenterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string costCenterName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCostCenterData.costCenterNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'costCenterName' in table 'CostCenterData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenterData.costCenterNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int postingNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableCostCenterData.postingNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'postingNum' in table 'CostCenterData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenterData.postingNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string glAccount
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCostCenterData.glAccountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'glAccount' in table 'CostCenterData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenterData.glAccountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCostCenterData.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Amount' in table 'CostCenterData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenterData.AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime invoicedate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableCostCenterData.invoicedateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'invoicedate' in table 'CostCenterData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenterData.invoicedateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string insured
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCostCenterData.insuredColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'insured' in table 'CostCenterData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenterData.insuredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string policyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCostCenterData.policyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'policyNumber' in table 'CostCenterData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenterData.policyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string expenseCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCostCenterData.expenseCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'expenseCode' in table 'CostCenterData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenterData.expenseCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Expense
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCostCenterData.ExpenseColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Expense' in table 'CostCenterData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenterData.ExpenseColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int NewcostcenterID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableCostCenterData.NewcostcenterIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NewcostcenterID' in table 'CostCenterData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenterData.NewcostcenterIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsChangeCostCenter.SearchInvoiceDataRow SearchInvoiceDataRow
    {
      get
      {
        return (dsChangeCostCenter.SearchInvoiceDataRow) this.GetParentRow(this.Table.ParentRelations["SearchInvoiceDataCostCenterData"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["SearchInvoiceDataCostCenterData"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IstransactnumNull() => this.IsNull(this.tableCostCenterData.transactnumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SettransactnumNull()
    {
      this[this.tableCostCenterData.transactnumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IscostCenterNull() => this.IsNull(this.tableCostCenterData.costCenterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetcostCenterNull()
    {
      this[this.tableCostCenterData.costCenterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IscostCenterNameNull()
    {
      return this.IsNull(this.tableCostCenterData.costCenterNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetcostCenterNameNull()
    {
      this[this.tableCostCenterData.costCenterNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IspostingNumNull() => this.IsNull(this.tableCostCenterData.postingNumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetpostingNumNull()
    {
      this[this.tableCostCenterData.postingNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsglAccountNull() => this.IsNull(this.tableCostCenterData.glAccountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetglAccountNull()
    {
      this[this.tableCostCenterData.glAccountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAmountNull() => this.IsNull(this.tableCostCenterData.AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAmountNull()
    {
      this[this.tableCostCenterData.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsinvoicedateNull() => this.IsNull(this.tableCostCenterData.invoicedateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetinvoicedateNull()
    {
      this[this.tableCostCenterData.invoicedateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsinsuredNull() => this.IsNull(this.tableCostCenterData.insuredColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetinsuredNull()
    {
      this[this.tableCostCenterData.insuredColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IspolicyNumberNull() => this.IsNull(this.tableCostCenterData.policyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetpolicyNumberNull()
    {
      this[this.tableCostCenterData.policyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsexpenseCodeNull() => this.IsNull(this.tableCostCenterData.expenseCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetexpenseCodeNull()
    {
      this[this.tableCostCenterData.expenseCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExpenseNull() => this.IsNull(this.tableCostCenterData.ExpenseColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExpenseNull()
    {
      this[this.tableCostCenterData.ExpenseColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNewcostcenterIDNull()
    {
      return this.IsNull(this.tableCostCenterData.NewcostcenterIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNewcostcenterIDNull()
    {
      this[this.tableCostCenterData.NewcostcenterIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class SearchInvoiceDataRowChangeEvent : EventArgs
  {
    private dsChangeCostCenter.SearchInvoiceDataRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public SearchInvoiceDataRowChangeEvent(
      dsChangeCostCenter.SearchInvoiceDataRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsChangeCostCenter.SearchInvoiceDataRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class CostCenterDataRowChangeEvent : EventArgs
  {
    private dsChangeCostCenter.CostCenterDataRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public CostCenterDataRowChangeEvent(
      dsChangeCostCenter.CostCenterDataRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsChangeCostCenter.CostCenterDataRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
