// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.BindPolicy.dsBindQuote
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
namespace MGASystems.IMS.Policies.BindPolicy;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsBindQuote")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsBindQuote : DataSet
{
  private dsBindQuote.tblQuoteOptionsDataTable tabletblQuoteOptions;
  private dsBindQuote.tblQuoteDetailsDataTable tabletblQuoteDetails;
  private dsBindQuote.FeesDataTable tableFees;
  private dsBindQuote.TransferFeesDataTable tableTransferFees;
  private dsBindQuote.tblPolicyCommissionsDataTable tabletblPolicyCommissions;
  private dsBindQuote.PreBindShowCompanyProducerCommissionsDataTable tablePreBindShowCompanyProducerCommissions;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public dsBindQuote()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected dsBindQuote(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblQuoteOptions)] != null)
          base.Tables.Add((DataTable) new dsBindQuote.tblQuoteOptionsDataTable(dataSet.Tables[nameof (tblQuoteOptions)]));
        if (dataSet.Tables[nameof (tblQuoteDetails)] != null)
          base.Tables.Add((DataTable) new dsBindQuote.tblQuoteDetailsDataTable(dataSet.Tables[nameof (tblQuoteDetails)]));
        if (dataSet.Tables[nameof (Fees)] != null)
          base.Tables.Add((DataTable) new dsBindQuote.FeesDataTable(dataSet.Tables[nameof (Fees)]));
        if (dataSet.Tables[nameof (TransferFees)] != null)
          base.Tables.Add((DataTable) new dsBindQuote.TransferFeesDataTable(dataSet.Tables[nameof (TransferFees)]));
        if (dataSet.Tables[nameof (tblPolicyCommissions)] != null)
          base.Tables.Add((DataTable) new dsBindQuote.tblPolicyCommissionsDataTable(dataSet.Tables[nameof (tblPolicyCommissions)]));
        if (dataSet.Tables[nameof (PreBindShowCompanyProducerCommissions)] != null)
          base.Tables.Add((DataTable) new dsBindQuote.PreBindShowCompanyProducerCommissionsDataTable(dataSet.Tables[nameof (PreBindShowCompanyProducerCommissions)]));
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
  public dsBindQuote.tblQuoteOptionsDataTable tblQuoteOptions => this.tabletblQuoteOptions;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsBindQuote.tblQuoteDetailsDataTable tblQuoteDetails => this.tabletblQuoteDetails;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsBindQuote.FeesDataTable Fees => this.tableFees;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsBindQuote.TransferFeesDataTable TransferFees => this.tableTransferFees;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsBindQuote.tblPolicyCommissionsDataTable tblPolicyCommissions
  {
    get => this.tabletblPolicyCommissions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsBindQuote.PreBindShowCompanyProducerCommissionsDataTable PreBindShowCompanyProducerCommissions
  {
    get => this.tablePreBindShowCompanyProducerCommissions;
  }

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
    dsBindQuote dsBindQuote = (dsBindQuote) base.Clone();
    dsBindQuote.InitVars();
    dsBindQuote.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsBindQuote;
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
      if (dataSet.Tables["tblQuoteOptions"] != null)
        base.Tables.Add((DataTable) new dsBindQuote.tblQuoteOptionsDataTable(dataSet.Tables["tblQuoteOptions"]));
      if (dataSet.Tables["tblQuoteDetails"] != null)
        base.Tables.Add((DataTable) new dsBindQuote.tblQuoteDetailsDataTable(dataSet.Tables["tblQuoteDetails"]));
      if (dataSet.Tables["Fees"] != null)
        base.Tables.Add((DataTable) new dsBindQuote.FeesDataTable(dataSet.Tables["Fees"]));
      if (dataSet.Tables["TransferFees"] != null)
        base.Tables.Add((DataTable) new dsBindQuote.TransferFeesDataTable(dataSet.Tables["TransferFees"]));
      if (dataSet.Tables["tblPolicyCommissions"] != null)
        base.Tables.Add((DataTable) new dsBindQuote.tblPolicyCommissionsDataTable(dataSet.Tables["tblPolicyCommissions"]));
      if (dataSet.Tables["PreBindShowCompanyProducerCommissions"] != null)
        base.Tables.Add((DataTable) new dsBindQuote.PreBindShowCompanyProducerCommissionsDataTable(dataSet.Tables["PreBindShowCompanyProducerCommissions"]));
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
    this.tabletblQuoteOptions = (dsBindQuote.tblQuoteOptionsDataTable) base.Tables["tblQuoteOptions"];
    if (initTable && this.tabletblQuoteOptions != null)
      this.tabletblQuoteOptions.InitVars();
    this.tabletblQuoteDetails = (dsBindQuote.tblQuoteDetailsDataTable) base.Tables["tblQuoteDetails"];
    if (initTable && this.tabletblQuoteDetails != null)
      this.tabletblQuoteDetails.InitVars();
    this.tableFees = (dsBindQuote.FeesDataTable) base.Tables["Fees"];
    if (initTable && this.tableFees != null)
      this.tableFees.InitVars();
    this.tableTransferFees = (dsBindQuote.TransferFeesDataTable) base.Tables["TransferFees"];
    if (initTable && this.tableTransferFees != null)
      this.tableTransferFees.InitVars();
    this.tabletblPolicyCommissions = (dsBindQuote.tblPolicyCommissionsDataTable) base.Tables["tblPolicyCommissions"];
    if (initTable && this.tabletblPolicyCommissions != null)
      this.tabletblPolicyCommissions.InitVars();
    this.tablePreBindShowCompanyProducerCommissions = (dsBindQuote.PreBindShowCompanyProducerCommissionsDataTable) base.Tables["PreBindShowCompanyProducerCommissions"];
    if (!initTable || this.tablePreBindShowCompanyProducerCommissions == null)
      return;
    this.tablePreBindShowCompanyProducerCommissions.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsBindQuote);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsBindQuote.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblQuoteOptions = new dsBindQuote.tblQuoteOptionsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptions);
    this.tabletblQuoteDetails = new dsBindQuote.tblQuoteDetailsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteDetails);
    this.tableFees = new dsBindQuote.FeesDataTable();
    base.Tables.Add((DataTable) this.tableFees);
    this.tableTransferFees = new dsBindQuote.TransferFeesDataTable();
    base.Tables.Add((DataTable) this.tableTransferFees);
    this.tabletblPolicyCommissions = new dsBindQuote.tblPolicyCommissionsDataTable();
    base.Tables.Add((DataTable) this.tabletblPolicyCommissions);
    this.tablePreBindShowCompanyProducerCommissions = new dsBindQuote.PreBindShowCompanyProducerCommissionsDataTable();
    base.Tables.Add((DataTable) this.tablePreBindShowCompanyProducerCommissions);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblQuoteOptions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblQuoteDetails() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeFees() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeTransferFees() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblPolicyCommissions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializePreBindShowCompanyProducerCommissions() => false;

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
    dsBindQuote dsBindQuote = new dsBindQuote();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsBindQuote.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsBindQuote.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblQuoteOptionsRowChangeEventHandler(
    object sender,
    dsBindQuote.tblQuoteOptionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblQuoteDetailsRowChangeEventHandler(
    object sender,
    dsBindQuote.tblQuoteDetailsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void FeesRowChangeEventHandler(object sender, dsBindQuote.FeesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void TransferFeesRowChangeEventHandler(
    object sender,
    dsBindQuote.TransferFeesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblPolicyCommissionsRowChangeEventHandler(
    object sender,
    dsBindQuote.tblPolicyCommissionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void PreBindShowCompanyProducerCommissionsRowChangeEventHandler(
    object sender,
    dsBindQuote.PreBindShowCompanyProducerCommissionsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblQuoteOptionsDataTable : TypedTableBase<dsBindQuote.tblQuoteOptionsRow>
  {
    private DataColumn columnLineName;
    private DataColumn columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblQuoteOptionsDataTable()
    {
      this.TableName = "tblQuoteOptions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblQuoteOptionsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected tblQuoteOptionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.tblQuoteOptionsRow this[int index]
    {
      get => (dsBindQuote.tblQuoteOptionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblQuoteOptionsRow(dsBindQuote.tblQuoteOptionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.tblQuoteOptionsRow AddtblQuoteOptionsRow(string LineName, Decimal Premium)
    {
      dsBindQuote.tblQuoteOptionsRow row = (dsBindQuote.tblQuoteOptionsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) LineName,
        (object) Premium
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsBindQuote.tblQuoteOptionsDataTable optionsDataTable = (dsBindQuote.tblQuoteOptionsDataTable) base.Clone();
      optionsDataTable.InitVars();
      return (DataTable) optionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBindQuote.tblQuoteOptionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnLineName = this.Columns["LineName"];
      this.columnPremium = this.Columns["Premium"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnLineName = new DataColumn("LineName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineName);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnLineName.AllowDBNull = false;
      this.columnPremium.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.tblQuoteOptionsRow NewtblQuoteOptionsRow()
    {
      return (dsBindQuote.tblQuoteOptionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBindQuote.tblQuoteOptionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsBindQuote.tblQuoteOptionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.tblQuoteOptionsRowChangeEventHandler optionsRowChangedEvent = this.tblQuoteOptionsRowChangedEvent;
      if (optionsRowChangedEvent == null)
        return;
      optionsRowChangedEvent((object) this, new dsBindQuote.tblQuoteOptionsRowChangeEvent((dsBindQuote.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.tblQuoteOptionsRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBindQuote.tblQuoteOptionsRowChangeEvent((dsBindQuote.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.tblQuoteOptionsRowChangeEventHandler optionsRowDeletedEvent = this.tblQuoteOptionsRowDeletedEvent;
      if (optionsRowDeletedEvent == null)
        return;
      optionsRowDeletedEvent((object) this, new dsBindQuote.tblQuoteOptionsRowChangeEvent((dsBindQuote.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.tblQuoteOptionsRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBindQuote.tblQuoteOptionsRowChangeEvent((dsBindQuote.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblQuoteOptionsRow(dsBindQuote.tblQuoteOptionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsBindQuote dsBindQuote = new dsBindQuote();
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
        FixedValue = dsBindQuote.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsBindQuote.GetSchemaSerializable();
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
  public class tblQuoteDetailsDataTable : TypedTableBase<dsBindQuote.tblQuoteDetailsRow>
  {
    private DataColumn columnQuoteGuid;
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnPolicyNumber;
    private DataColumn columnPolicyNumberIndex;
    private DataColumn columnPolicyNumberRuleID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblQuoteDetailsDataTable()
    {
      this.TableName = "tblQuoteDetails";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblQuoteDetailsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected tblQuoteDetailsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PolicyNumberIndexColumn => this.columnPolicyNumberIndex;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PolicyNumberRuleIDColumn => this.columnPolicyNumberRuleID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.tblQuoteDetailsRow this[int index]
    {
      get => (dsBindQuote.tblQuoteDetailsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.tblQuoteDetailsRowChangeEventHandler tblQuoteDetailsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.tblQuoteDetailsRowChangeEventHandler tblQuoteDetailsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.tblQuoteDetailsRowChangeEventHandler tblQuoteDetailsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.tblQuoteDetailsRowChangeEventHandler tblQuoteDetailsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblQuoteDetailsRow(dsBindQuote.tblQuoteDetailsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.tblQuoteDetailsRow AddtblQuoteDetailsRow(
      Guid QuoteGuid,
      Guid CompanyLineGuid,
      string PolicyNumber,
      int PolicyNumberIndex,
      int PolicyNumberRuleID)
    {
      dsBindQuote.tblQuoteDetailsRow row = (dsBindQuote.tblQuoteDetailsRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) QuoteGuid,
        (object) CompanyLineGuid,
        (object) PolicyNumber,
        (object) PolicyNumberIndex,
        (object) PolicyNumberRuleID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.tblQuoteDetailsRow FindByQuoteGuidCompanyLineGuid(
      Guid QuoteGuid,
      Guid CompanyLineGuid)
    {
      return (dsBindQuote.tblQuoteDetailsRow) this.Rows.Find(new object[2]
      {
        (object) QuoteGuid,
        (object) CompanyLineGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsBindQuote.tblQuoteDetailsDataTable detailsDataTable = (dsBindQuote.tblQuoteDetailsDataTable) base.Clone();
      detailsDataTable.InitVars();
      return (DataTable) detailsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBindQuote.tblQuoteDetailsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnPolicyNumberIndex = this.Columns["PolicyNumberIndex"];
      this.columnPolicyNumberRuleID = this.Columns["PolicyNumberRuleID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnPolicyNumberIndex = new DataColumn("PolicyNumberIndex", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumberIndex);
      this.columnPolicyNumberRuleID = new DataColumn("PolicyNumberRuleID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumberRuleID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnQuoteGuid,
        this.columnCompanyLineGuid
      }, true));
      this.columnQuoteGuid.AllowDBNull = false;
      this.columnCompanyLineGuid.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.tblQuoteDetailsRow NewtblQuoteDetailsRow()
    {
      return (dsBindQuote.tblQuoteDetailsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBindQuote.tblQuoteDetailsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsBindQuote.tblQuoteDetailsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteDetailsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.tblQuoteDetailsRowChangeEventHandler detailsRowChangedEvent = this.tblQuoteDetailsRowChangedEvent;
      if (detailsRowChangedEvent == null)
        return;
      detailsRowChangedEvent((object) this, new dsBindQuote.tblQuoteDetailsRowChangeEvent((dsBindQuote.tblQuoteDetailsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteDetailsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.tblQuoteDetailsRowChangeEventHandler rowChangingEvent = this.tblQuoteDetailsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBindQuote.tblQuoteDetailsRowChangeEvent((dsBindQuote.tblQuoteDetailsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteDetailsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.tblQuoteDetailsRowChangeEventHandler detailsRowDeletedEvent = this.tblQuoteDetailsRowDeletedEvent;
      if (detailsRowDeletedEvent == null)
        return;
      detailsRowDeletedEvent((object) this, new dsBindQuote.tblQuoteDetailsRowChangeEvent((dsBindQuote.tblQuoteDetailsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteDetailsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.tblQuoteDetailsRowChangeEventHandler rowDeletingEvent = this.tblQuoteDetailsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBindQuote.tblQuoteDetailsRowChangeEvent((dsBindQuote.tblQuoteDetailsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblQuoteDetailsRow(dsBindQuote.tblQuoteDetailsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsBindQuote dsBindQuote = new dsBindQuote();
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
        FixedValue = dsBindQuote.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteDetailsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsBindQuote.GetSchemaSerializable();
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
  public class FeesDataTable : TypedTableBase<dsBindQuote.FeesRow>
  {
    private DataColumn columnChargeName;
    private DataColumn columnAmount;
    private DataColumn columnPayableEntity;
    private DataColumn columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public FeesDataTable()
    {
      this.TableName = "Fees";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal FeesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected FeesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AmountColumn => this.columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PayableEntityColumn => this.columnPayableEntity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.FeesRow this[int index] => (dsBindQuote.FeesRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.FeesRowChangeEventHandler FeesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.FeesRowChangeEventHandler FeesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.FeesRowChangeEventHandler FeesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.FeesRowChangeEventHandler FeesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddFeesRow(dsBindQuote.FeesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.FeesRow AddFeesRow(
      string ChargeName,
      Decimal Amount,
      string PayableEntity,
      int ChargeCode)
    {
      dsBindQuote.FeesRow row = (dsBindQuote.FeesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) ChargeName,
        (object) Amount,
        (object) PayableEntity,
        (object) ChargeCode
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsBindQuote.FeesDataTable feesDataTable = (dsBindQuote.FeesDataTable) base.Clone();
      feesDataTable.InitVars();
      return (DataTable) feesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsBindQuote.FeesDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnAmount = this.Columns["Amount"];
      this.columnPayableEntity = this.Columns["PayableEntity"];
      this.columnChargeCode = this.Columns["ChargeCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnPayableEntity = new DataColumn("PayableEntity", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayableEntity);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnChargeName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.FeesRow NewFeesRow() => (dsBindQuote.FeesRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBindQuote.FeesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsBindQuote.FeesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.FeesRowChangeEventHandler feesRowChangedEvent = this.FeesRowChangedEvent;
      if (feesRowChangedEvent == null)
        return;
      feesRowChangedEvent((object) this, new dsBindQuote.FeesRowChangeEvent((dsBindQuote.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.FeesRowChangeEventHandler rowChangingEvent = this.FeesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBindQuote.FeesRowChangeEvent((dsBindQuote.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.FeesRowChangeEventHandler feesRowDeletedEvent = this.FeesRowDeletedEvent;
      if (feesRowDeletedEvent == null)
        return;
      feesRowDeletedEvent((object) this, new dsBindQuote.FeesRowChangeEvent((dsBindQuote.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.FeesRowChangeEventHandler rowDeletingEvent = this.FeesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBindQuote.FeesRowChangeEvent((dsBindQuote.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveFeesRow(dsBindQuote.FeesRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsBindQuote dsBindQuote = new dsBindQuote();
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
        FixedValue = dsBindQuote.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (FeesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsBindQuote.GetSchemaSerializable();
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
  public class TransferFeesDataTable : TypedTableBase<dsBindQuote.TransferFeesRow>
  {
    private DataColumn columnAmount;
    private DataColumn columnOptionFeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public TransferFeesDataTable()
    {
      this.TableName = "TransferFees";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal TransferFeesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected TransferFeesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AmountColumn => this.columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn OptionFeeIDColumn => this.columnOptionFeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.TransferFeesRow this[int index]
    {
      get => (dsBindQuote.TransferFeesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.TransferFeesRowChangeEventHandler TransferFeesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.TransferFeesRowChangeEventHandler TransferFeesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.TransferFeesRowChangeEventHandler TransferFeesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.TransferFeesRowChangeEventHandler TransferFeesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddTransferFeesRow(dsBindQuote.TransferFeesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.TransferFeesRow AddTransferFeesRow(Decimal Amount, int OptionFeeID)
    {
      dsBindQuote.TransferFeesRow row = (dsBindQuote.TransferFeesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Amount,
        (object) OptionFeeID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.TransferFeesRow FindByOptionFeeID(int OptionFeeID)
    {
      return (dsBindQuote.TransferFeesRow) this.Rows.Find(new object[1]
      {
        (object) OptionFeeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsBindQuote.TransferFeesDataTable transferFeesDataTable = (dsBindQuote.TransferFeesDataTable) base.Clone();
      transferFeesDataTable.InitVars();
      return (DataTable) transferFeesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBindQuote.TransferFeesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnAmount = this.Columns["Amount"];
      this.columnOptionFeeID = this.Columns["OptionFeeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnOptionFeeID = new DataColumn("OptionFeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptionFeeID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsBindQuoteKey1", new DataColumn[1]
      {
        this.columnOptionFeeID
      }, true));
      this.columnAmount.ReadOnly = true;
      this.columnOptionFeeID.AllowDBNull = false;
      this.columnOptionFeeID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.TransferFeesRow NewTransferFeesRow()
    {
      return (dsBindQuote.TransferFeesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBindQuote.TransferFeesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsBindQuote.TransferFeesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransferFeesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.TransferFeesRowChangeEventHandler feesRowChangedEvent = this.TransferFeesRowChangedEvent;
      if (feesRowChangedEvent == null)
        return;
      feesRowChangedEvent((object) this, new dsBindQuote.TransferFeesRowChangeEvent((dsBindQuote.TransferFeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransferFeesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.TransferFeesRowChangeEventHandler rowChangingEvent = this.TransferFeesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBindQuote.TransferFeesRowChangeEvent((dsBindQuote.TransferFeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransferFeesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.TransferFeesRowChangeEventHandler feesRowDeletedEvent = this.TransferFeesRowDeletedEvent;
      if (feesRowDeletedEvent == null)
        return;
      feesRowDeletedEvent((object) this, new dsBindQuote.TransferFeesRowChangeEvent((dsBindQuote.TransferFeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransferFeesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.TransferFeesRowChangeEventHandler rowDeletingEvent = this.TransferFeesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBindQuote.TransferFeesRowChangeEvent((dsBindQuote.TransferFeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveTransferFeesRow(dsBindQuote.TransferFeesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsBindQuote dsBindQuote = new dsBindQuote();
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
        FixedValue = dsBindQuote.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (TransferFeesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsBindQuote.GetSchemaSerializable();
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
  public class tblPolicyCommissionsDataTable : TypedTableBase<dsBindQuote.tblPolicyCommissionsRow>
  {
    private DataColumn columnEntity;
    private DataColumn columnChargeName;
    private DataColumn columnEntityType;
    private DataColumn columnDescription;
    private DataColumn columnPercentage;
    private DataColumn columnFlatAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblPolicyCommissionsDataTable()
    {
      this.TableName = "tblPolicyCommissions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblPolicyCommissionsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected tblPolicyCommissionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EntityColumn => this.columnEntity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EntityTypeColumn => this.columnEntityType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PercentageColumn => this.columnPercentage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FlatAmountColumn => this.columnFlatAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.tblPolicyCommissionsRow this[int index]
    {
      get => (dsBindQuote.tblPolicyCommissionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.tblPolicyCommissionsRowChangeEventHandler tblPolicyCommissionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.tblPolicyCommissionsRowChangeEventHandler tblPolicyCommissionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.tblPolicyCommissionsRowChangeEventHandler tblPolicyCommissionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.tblPolicyCommissionsRowChangeEventHandler tblPolicyCommissionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblPolicyCommissionsRow(dsBindQuote.tblPolicyCommissionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.tblPolicyCommissionsRow AddtblPolicyCommissionsRow(
      string Entity,
      string ChargeName,
      string EntityType,
      string Description,
      Decimal Percentage,
      Decimal FlatAmount)
    {
      dsBindQuote.tblPolicyCommissionsRow row = (dsBindQuote.tblPolicyCommissionsRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) Entity,
        (object) ChargeName,
        (object) EntityType,
        (object) Description,
        (object) Percentage,
        (object) FlatAmount
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsBindQuote.tblPolicyCommissionsDataTable commissionsDataTable = (dsBindQuote.tblPolicyCommissionsDataTable) base.Clone();
      commissionsDataTable.InitVars();
      return (DataTable) commissionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBindQuote.tblPolicyCommissionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnEntity = this.Columns["Entity"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnEntityType = this.Columns["EntityType"];
      this.columnDescription = this.Columns["Description"];
      this.columnPercentage = this.Columns["Percentage"];
      this.columnFlatAmount = this.Columns["FlatAmount"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnEntity = new DataColumn("Entity", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnEntityType = new DataColumn("EntityType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityType);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnPercentage = new DataColumn("Percentage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentage);
      this.columnFlatAmount = new DataColumn("FlatAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFlatAmount);
      this.columnEntity.AllowDBNull = false;
      this.columnEntity.ReadOnly = true;
      this.columnChargeName.ReadOnly = true;
      this.columnDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.tblPolicyCommissionsRow NewtblPolicyCommissionsRow()
    {
      return (dsBindQuote.tblPolicyCommissionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBindQuote.tblPolicyCommissionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsBindQuote.tblPolicyCommissionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyCommissionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.tblPolicyCommissionsRowChangeEventHandler commissionsRowChangedEvent = this.tblPolicyCommissionsRowChangedEvent;
      if (commissionsRowChangedEvent == null)
        return;
      commissionsRowChangedEvent((object) this, new dsBindQuote.tblPolicyCommissionsRowChangeEvent((dsBindQuote.tblPolicyCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyCommissionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.tblPolicyCommissionsRowChangeEventHandler rowChangingEvent = this.tblPolicyCommissionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBindQuote.tblPolicyCommissionsRowChangeEvent((dsBindQuote.tblPolicyCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyCommissionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.tblPolicyCommissionsRowChangeEventHandler commissionsRowDeletedEvent = this.tblPolicyCommissionsRowDeletedEvent;
      if (commissionsRowDeletedEvent == null)
        return;
      commissionsRowDeletedEvent((object) this, new dsBindQuote.tblPolicyCommissionsRowChangeEvent((dsBindQuote.tblPolicyCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyCommissionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.tblPolicyCommissionsRowChangeEventHandler rowDeletingEvent = this.tblPolicyCommissionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBindQuote.tblPolicyCommissionsRowChangeEvent((dsBindQuote.tblPolicyCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblPolicyCommissionsRow(dsBindQuote.tblPolicyCommissionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsBindQuote dsBindQuote = new dsBindQuote();
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
        FixedValue = dsBindQuote.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblPolicyCommissionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsBindQuote.GetSchemaSerializable();
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
  public class PreBindShowCompanyProducerCommissionsDataTable : 
    TypedTableBase<dsBindQuote.PreBindShowCompanyProducerCommissionsRow>
  {
    private DataColumn columnCompanyCommission;
    private DataColumn columnProducerCommission;
    private DataColumn columnCompany;
    private DataColumn columnProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PreBindShowCompanyProducerCommissionsDataTable()
    {
      this.TableName = "PreBindShowCompanyProducerCommissions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PreBindShowCompanyProducerCommissionsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected PreBindShowCompanyProducerCommissionsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CompanyCommissionColumn => this.columnCompanyCommission;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerCommissionColumn => this.columnProducerCommission;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CompanyColumn => this.columnCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerColumn => this.columnProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.PreBindShowCompanyProducerCommissionsRow this[int index]
    {
      get => (dsBindQuote.PreBindShowCompanyProducerCommissionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.PreBindShowCompanyProducerCommissionsRowChangeEventHandler PreBindShowCompanyProducerCommissionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.PreBindShowCompanyProducerCommissionsRowChangeEventHandler PreBindShowCompanyProducerCommissionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.PreBindShowCompanyProducerCommissionsRowChangeEventHandler PreBindShowCompanyProducerCommissionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBindQuote.PreBindShowCompanyProducerCommissionsRowChangeEventHandler PreBindShowCompanyProducerCommissionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddPreBindShowCompanyProducerCommissionsRow(
      dsBindQuote.PreBindShowCompanyProducerCommissionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.PreBindShowCompanyProducerCommissionsRow AddPreBindShowCompanyProducerCommissionsRow(
      Decimal CompanyCommission,
      Decimal ProducerCommission,
      string Company,
      string Producer)
    {
      dsBindQuote.PreBindShowCompanyProducerCommissionsRow row = (dsBindQuote.PreBindShowCompanyProducerCommissionsRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) CompanyCommission,
        (object) ProducerCommission,
        (object) Company,
        (object) Producer
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsBindQuote.PreBindShowCompanyProducerCommissionsDataTable commissionsDataTable = (dsBindQuote.PreBindShowCompanyProducerCommissionsDataTable) base.Clone();
      commissionsDataTable.InitVars();
      return (DataTable) commissionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBindQuote.PreBindShowCompanyProducerCommissionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyCommission = this.Columns["CompanyCommission"];
      this.columnProducerCommission = this.Columns["ProducerCommission"];
      this.columnCompany = this.Columns["Company"];
      this.columnProducer = this.Columns["Producer"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyCommission = new DataColumn("CompanyCommission", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyCommission);
      this.columnProducerCommission = new DataColumn("ProducerCommission", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerCommission);
      this.columnCompany = new DataColumn("Company", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany);
      this.columnProducer = new DataColumn("Producer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducer);
      this.columnCompanyCommission.AllowDBNull = false;
      this.columnProducerCommission.AllowDBNull = false;
      this.columnCompany.AllowDBNull = false;
      this.columnProducer.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.PreBindShowCompanyProducerCommissionsRow NewPreBindShowCompanyProducerCommissionsRow()
    {
      return (dsBindQuote.PreBindShowCompanyProducerCommissionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBindQuote.PreBindShowCompanyProducerCommissionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsBindQuote.PreBindShowCompanyProducerCommissionsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PreBindShowCompanyProducerCommissionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.PreBindShowCompanyProducerCommissionsRowChangeEventHandler commissionsRowChangedEvent = this.PreBindShowCompanyProducerCommissionsRowChangedEvent;
      if (commissionsRowChangedEvent == null)
        return;
      commissionsRowChangedEvent((object) this, new dsBindQuote.PreBindShowCompanyProducerCommissionsRowChangeEvent((dsBindQuote.PreBindShowCompanyProducerCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PreBindShowCompanyProducerCommissionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.PreBindShowCompanyProducerCommissionsRowChangeEventHandler rowChangingEvent = this.PreBindShowCompanyProducerCommissionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBindQuote.PreBindShowCompanyProducerCommissionsRowChangeEvent((dsBindQuote.PreBindShowCompanyProducerCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PreBindShowCompanyProducerCommissionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.PreBindShowCompanyProducerCommissionsRowChangeEventHandler commissionsRowDeletedEvent = this.PreBindShowCompanyProducerCommissionsRowDeletedEvent;
      if (commissionsRowDeletedEvent == null)
        return;
      commissionsRowDeletedEvent((object) this, new dsBindQuote.PreBindShowCompanyProducerCommissionsRowChangeEvent((dsBindQuote.PreBindShowCompanyProducerCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PreBindShowCompanyProducerCommissionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBindQuote.PreBindShowCompanyProducerCommissionsRowChangeEventHandler rowDeletingEvent = this.PreBindShowCompanyProducerCommissionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBindQuote.PreBindShowCompanyProducerCommissionsRowChangeEvent((dsBindQuote.PreBindShowCompanyProducerCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovePreBindShowCompanyProducerCommissionsRow(
      dsBindQuote.PreBindShowCompanyProducerCommissionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsBindQuote dsBindQuote = new dsBindQuote();
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
        FixedValue = dsBindQuote.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PreBindShowCompanyProducerCommissionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsBindQuote.GetSchemaSerializable();
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

  public class tblQuoteOptionsRow : DataRow
  {
    private dsBindQuote.tblQuoteOptionsDataTable tabletblQuoteOptions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblQuoteOptionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptions = (dsBindQuote.tblQuoteOptionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string LineName
    {
      get => Conversions.ToString(this[this.tabletblQuoteOptions.LineNameColumn]);
      set => this[this.tabletblQuoteOptions.LineNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Premium
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptions.PremiumColumn]);
      set => this[this.tabletblQuoteOptions.PremiumColumn] = (object) value;
    }
  }

  public class tblQuoteDetailsRow : DataRow
  {
    private dsBindQuote.tblQuoteDetailsDataTable tabletblQuoteDetails;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblQuoteDetailsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteDetails = (dsBindQuote.tblQuoteDetailsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        object obj = this[this.tabletblQuoteDetails.QuoteGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteDetails.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        object obj = this[this.tabletblQuoteDetails.CompanyLineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteDetails.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteDetails.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'tblQuoteDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteDetails.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int PolicyNumberIndex
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteDetails.PolicyNumberIndexColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumberIndex' in table 'tblQuoteDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteDetails.PolicyNumberIndexColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int PolicyNumberRuleID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteDetails.PolicyNumberRuleIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumberRuleID' in table 'tblQuoteDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteDetails.PolicyNumberRuleIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tabletblQuoteDetails.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tabletblQuoteDetails.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPolicyNumberIndexNull()
    {
      return this.IsNull(this.tabletblQuoteDetails.PolicyNumberIndexColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPolicyNumberIndexNull()
    {
      this[this.tabletblQuoteDetails.PolicyNumberIndexColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPolicyNumberRuleIDNull()
    {
      return this.IsNull(this.tabletblQuoteDetails.PolicyNumberRuleIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPolicyNumberRuleIDNull()
    {
      this[this.tabletblQuoteDetails.PolicyNumberRuleIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class FeesRow : DataRow
  {
    private dsBindQuote.FeesDataTable tableFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal FeesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableFees = (dsBindQuote.FeesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ChargeName
    {
      get => Conversions.ToString(this[this.tableFees.ChargeNameColumn]);
      set => this[this.tableFees.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableFees.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Amount' in table 'Fees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFees.AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PayableEntity
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableFees.PayableEntityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PayableEntity' in table 'Fees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFees.PayableEntityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ChargeCode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableFees.ChargeCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeCode' in table 'Fees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFees.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAmountNull() => this.IsNull(this.tableFees.AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAmountNull()
    {
      this[this.tableFees.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPayableEntityNull() => this.IsNull(this.tableFees.PayableEntityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPayableEntityNull()
    {
      this[this.tableFees.PayableEntityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsChargeCodeNull() => this.IsNull(this.tableFees.ChargeCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetChargeCodeNull()
    {
      this[this.tableFees.ChargeCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class TransferFeesRow : DataRow
  {
    private dsBindQuote.TransferFeesDataTable tableTransferFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal TransferFeesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTransferFees = (dsBindQuote.TransferFeesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableTransferFees.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Amount' in table 'TransferFees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransferFees.AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int OptionFeeID
    {
      get => Conversions.ToInteger(this[this.tableTransferFees.OptionFeeIDColumn]);
      set => this[this.tableTransferFees.OptionFeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAmountNull() => this.IsNull(this.tableTransferFees.AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAmountNull()
    {
      this[this.tableTransferFees.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblPolicyCommissionsRow : DataRow
  {
    private dsBindQuote.tblPolicyCommissionsDataTable tabletblPolicyCommissions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblPolicyCommissionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblPolicyCommissions = (dsBindQuote.tblPolicyCommissionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Entity
    {
      get => Conversions.ToString(this[this.tabletblPolicyCommissions.EntityColumn]);
      set => this[this.tabletblPolicyCommissions.EntityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ChargeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyCommissions.ChargeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeName' in table 'tblPolicyCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyCommissions.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string EntityType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyCommissions.EntityTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EntityType' in table 'tblPolicyCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyCommissions.EntityTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tabletblPolicyCommissions.DescriptionColumn]);
      set => this[this.tabletblPolicyCommissions.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Percentage
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblPolicyCommissions.PercentageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Percentage' in table 'tblPolicyCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyCommissions.PercentageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal FlatAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblPolicyCommissions.FlatAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FlatAmount' in table 'tblPolicyCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyCommissions.FlatAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsChargeNameNull() => this.IsNull(this.tabletblPolicyCommissions.ChargeNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetChargeNameNull()
    {
      this[this.tabletblPolicyCommissions.ChargeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEntityTypeNull() => this.IsNull(this.tabletblPolicyCommissions.EntityTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEntityTypeNull()
    {
      this[this.tabletblPolicyCommissions.EntityTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPercentageNull() => this.IsNull(this.tabletblPolicyCommissions.PercentageColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPercentageNull()
    {
      this[this.tabletblPolicyCommissions.PercentageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFlatAmountNull() => this.IsNull(this.tabletblPolicyCommissions.FlatAmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFlatAmountNull()
    {
      this[this.tabletblPolicyCommissions.FlatAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class PreBindShowCompanyProducerCommissionsRow : DataRow
  {
    private dsBindQuote.PreBindShowCompanyProducerCommissionsDataTable tablePreBindShowCompanyProducerCommissions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PreBindShowCompanyProducerCommissionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePreBindShowCompanyProducerCommissions = (dsBindQuote.PreBindShowCompanyProducerCommissionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal CompanyCommission
    {
      get
      {
        return Conversions.ToDecimal(this[this.tablePreBindShowCompanyProducerCommissions.CompanyCommissionColumn]);
      }
      set
      {
        this[this.tablePreBindShowCompanyProducerCommissions.CompanyCommissionColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal ProducerCommission
    {
      get
      {
        return Conversions.ToDecimal(this[this.tablePreBindShowCompanyProducerCommissions.ProducerCommissionColumn]);
      }
      set
      {
        this[this.tablePreBindShowCompanyProducerCommissions.ProducerCommissionColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Company
    {
      get
      {
        return Conversions.ToString(this[this.tablePreBindShowCompanyProducerCommissions.CompanyColumn]);
      }
      set => this[this.tablePreBindShowCompanyProducerCommissions.CompanyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Producer
    {
      get
      {
        return Conversions.ToString(this[this.tablePreBindShowCompanyProducerCommissions.ProducerColumn]);
      }
      set => this[this.tablePreBindShowCompanyProducerCommissions.ProducerColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblQuoteOptionsRowChangeEvent : EventArgs
  {
    private dsBindQuote.tblQuoteOptionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblQuoteOptionsRowChangeEvent(dsBindQuote.tblQuoteOptionsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.tblQuoteOptionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblQuoteDetailsRowChangeEvent : EventArgs
  {
    private dsBindQuote.tblQuoteDetailsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblQuoteDetailsRowChangeEvent(dsBindQuote.tblQuoteDetailsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.tblQuoteDetailsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class FeesRowChangeEvent : EventArgs
  {
    private dsBindQuote.FeesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public FeesRowChangeEvent(dsBindQuote.FeesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.FeesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class TransferFeesRowChangeEvent : EventArgs
  {
    private dsBindQuote.TransferFeesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public TransferFeesRowChangeEvent(dsBindQuote.TransferFeesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.TransferFeesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblPolicyCommissionsRowChangeEvent : EventArgs
  {
    private dsBindQuote.tblPolicyCommissionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblPolicyCommissionsRowChangeEvent(
      dsBindQuote.tblPolicyCommissionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.tblPolicyCommissionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class PreBindShowCompanyProducerCommissionsRowChangeEvent : EventArgs
  {
    private dsBindQuote.PreBindShowCompanyProducerCommissionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PreBindShowCompanyProducerCommissionsRowChangeEvent(
      dsBindQuote.PreBindShowCompanyProducerCommissionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBindQuote.PreBindShowCompanyProducerCommissionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
