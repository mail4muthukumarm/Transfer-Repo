// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.dsReservePaymentBreakout
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
[XmlRoot("dsReservePaymentBreakout")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsReservePaymentBreakout : DataSet
{
  private dsReservePaymentBreakout.ReservePaymentBreakoutDataTable tableReservePaymentBreakout;
  private dsReservePaymentBreakout.ClaimantsDataTable tableClaimants;
  private DataRelation relationClaimants_ReservePaymentBreakout;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsReservePaymentBreakout()
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
  protected dsReservePaymentBreakout(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (ReservePaymentBreakout)] != null)
          base.Tables.Add((DataTable) new dsReservePaymentBreakout.ReservePaymentBreakoutDataTable(dataSet.Tables[nameof (ReservePaymentBreakout)]));
        if (dataSet.Tables[nameof (Claimants)] != null)
          base.Tables.Add((DataTable) new dsReservePaymentBreakout.ClaimantsDataTable(dataSet.Tables[nameof (Claimants)]));
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
  public dsReservePaymentBreakout.ReservePaymentBreakoutDataTable ReservePaymentBreakout
  {
    get => this.tableReservePaymentBreakout;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsReservePaymentBreakout.ClaimantsDataTable Claimants => this.tableClaimants;

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
    dsReservePaymentBreakout reservePaymentBreakout = (dsReservePaymentBreakout) base.Clone();
    reservePaymentBreakout.InitVars();
    reservePaymentBreakout.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) reservePaymentBreakout;
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
      if (dataSet.Tables["ReservePaymentBreakout"] != null)
        base.Tables.Add((DataTable) new dsReservePaymentBreakout.ReservePaymentBreakoutDataTable(dataSet.Tables["ReservePaymentBreakout"]));
      if (dataSet.Tables["Claimants"] != null)
        base.Tables.Add((DataTable) new dsReservePaymentBreakout.ClaimantsDataTable(dataSet.Tables["Claimants"]));
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
    this.tableReservePaymentBreakout = (dsReservePaymentBreakout.ReservePaymentBreakoutDataTable) base.Tables["ReservePaymentBreakout"];
    if (initTable && this.tableReservePaymentBreakout != null)
      this.tableReservePaymentBreakout.InitVars();
    this.tableClaimants = (dsReservePaymentBreakout.ClaimantsDataTable) base.Tables["Claimants"];
    if (initTable && this.tableClaimants != null)
      this.tableClaimants.InitVars();
    this.relationClaimants_ReservePaymentBreakout = this.Relations["Claimants_ReservePaymentBreakout"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsReservePaymentBreakout);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsReservePaymentBreakout.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableReservePaymentBreakout = new dsReservePaymentBreakout.ReservePaymentBreakoutDataTable();
    base.Tables.Add((DataTable) this.tableReservePaymentBreakout);
    this.tableClaimants = new dsReservePaymentBreakout.ClaimantsDataTable();
    base.Tables.Add((DataTable) this.tableClaimants);
    this.relationClaimants_ReservePaymentBreakout = new DataRelation("Claimants_ReservePaymentBreakout", new DataColumn[1]
    {
      this.tableClaimants.ClaimantGuidColumn
    }, new DataColumn[1]
    {
      this.tableReservePaymentBreakout.ClaimantGuidColumn
    }, false);
    this.Relations.Add(this.relationClaimants_ReservePaymentBreakout);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeReservePaymentBreakout() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeClaimants() => false;

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
    dsReservePaymentBreakout reservePaymentBreakout = new dsReservePaymentBreakout();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = reservePaymentBreakout.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = reservePaymentBreakout.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void ReservePaymentBreakoutRowChangeEventHandler(
    object sender,
    dsReservePaymentBreakout.ReservePaymentBreakoutRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void ClaimantsRowChangeEventHandler(
    object sender,
    dsReservePaymentBreakout.ClaimantsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class ReservePaymentBreakoutDataTable : 
    TypedTableBase<dsReservePaymentBreakout.ReservePaymentBreakoutRow>
  {
    private DataColumn columnClaimantGuid;
    private DataColumn columnClaimantName;
    private DataColumn columnResPayTypeId;
    private DataColumn columnResPayTypeDescription;
    private DataColumn columnResPaySubTypeId;
    private DataColumn columnResPaySubTypeDescription;
    private DataColumn columnCoverageTypeId;
    private DataColumn columnCoverageType;
    private DataColumn columnCoverageTypeDescriptionId;
    private DataColumn columnCoverageTypeDescription;
    private DataColumn columnTotalReserve;
    private DataColumn columnTotalPayments;
    private DataColumn columnRemainingReserves;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ReservePaymentBreakoutDataTable()
    {
      this.TableName = "ReservePaymentBreakout";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ReservePaymentBreakoutDataTable(DataTable table)
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
    protected ReservePaymentBreakoutDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClaimantGuidColumn => this.columnClaimantGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClaimantNameColumn => this.columnClaimantName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ResPayTypeIdColumn => this.columnResPayTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ResPayTypeDescriptionColumn => this.columnResPayTypeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ResPaySubTypeIdColumn => this.columnResPaySubTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ResPaySubTypeDescriptionColumn => this.columnResPaySubTypeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CoverageTypeIdColumn => this.columnCoverageTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CoverageTypeColumn => this.columnCoverageType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CoverageTypeDescriptionIdColumn => this.columnCoverageTypeDescriptionId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CoverageTypeDescriptionColumn => this.columnCoverageTypeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TotalReserveColumn => this.columnTotalReserve;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TotalPaymentsColumn => this.columnTotalPayments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RemainingReservesColumn => this.columnRemainingReserves;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsReservePaymentBreakout.ReservePaymentBreakoutRow this[int index]
    {
      get => (dsReservePaymentBreakout.ReservePaymentBreakoutRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsReservePaymentBreakout.ReservePaymentBreakoutRowChangeEventHandler ReservePaymentBreakoutRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsReservePaymentBreakout.ReservePaymentBreakoutRowChangeEventHandler ReservePaymentBreakoutRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsReservePaymentBreakout.ReservePaymentBreakoutRowChangeEventHandler ReservePaymentBreakoutRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsReservePaymentBreakout.ReservePaymentBreakoutRowChangeEventHandler ReservePaymentBreakoutRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddReservePaymentBreakoutRow(
      dsReservePaymentBreakout.ReservePaymentBreakoutRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsReservePaymentBreakout.ReservePaymentBreakoutRow AddReservePaymentBreakoutRow(
      dsReservePaymentBreakout.ClaimantsRow parentClaimantsRowByClaimants_ReservePaymentBreakout,
      string ClaimantName,
      int ResPayTypeId,
      string ResPayTypeDescription,
      int ResPaySubTypeId,
      string ResPaySubTypeDescription,
      int CoverageTypeId,
      string CoverageType,
      int CoverageTypeDescriptionId,
      string CoverageTypeDescription,
      Decimal TotalReserve,
      Decimal TotalPayments,
      Decimal RemainingReserves)
    {
      dsReservePaymentBreakout.ReservePaymentBreakoutRow row = (dsReservePaymentBreakout.ReservePaymentBreakoutRow) this.NewRow();
      object[] objArray = new object[13]
      {
        null,
        (object) ClaimantName,
        (object) ResPayTypeId,
        (object) ResPayTypeDescription,
        (object) ResPaySubTypeId,
        (object) ResPaySubTypeDescription,
        (object) CoverageTypeId,
        (object) CoverageType,
        (object) CoverageTypeDescriptionId,
        (object) CoverageTypeDescription,
        (object) TotalReserve,
        (object) TotalPayments,
        (object) RemainingReserves
      };
      if (parentClaimantsRowByClaimants_ReservePaymentBreakout != null)
        objArray[0] = parentClaimantsRowByClaimants_ReservePaymentBreakout[0];
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsReservePaymentBreakout.ReservePaymentBreakoutDataTable breakoutDataTable = (dsReservePaymentBreakout.ReservePaymentBreakoutDataTable) base.Clone();
      breakoutDataTable.InitVars();
      return (DataTable) breakoutDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsReservePaymentBreakout.ReservePaymentBreakoutDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnClaimantGuid = this.Columns["ClaimantGuid"];
      this.columnClaimantName = this.Columns["ClaimantName"];
      this.columnResPayTypeId = this.Columns["ResPayTypeId"];
      this.columnResPayTypeDescription = this.Columns["ResPayTypeDescription"];
      this.columnResPaySubTypeId = this.Columns["ResPaySubTypeId"];
      this.columnResPaySubTypeDescription = this.Columns["ResPaySubTypeDescription"];
      this.columnCoverageTypeId = this.Columns["CoverageTypeId"];
      this.columnCoverageType = this.Columns["CoverageType"];
      this.columnCoverageTypeDescriptionId = this.Columns["CoverageTypeDescriptionId"];
      this.columnCoverageTypeDescription = this.Columns["CoverageTypeDescription"];
      this.columnTotalReserve = this.Columns["TotalReserve"];
      this.columnTotalPayments = this.Columns["TotalPayments"];
      this.columnRemainingReserves = this.Columns["RemainingReserves"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnClaimantGuid = new DataColumn("ClaimantGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimantGuid);
      this.columnClaimantName = new DataColumn("ClaimantName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimantName);
      this.columnResPayTypeId = new DataColumn("ResPayTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResPayTypeId);
      this.columnResPayTypeDescription = new DataColumn("ResPayTypeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResPayTypeDescription);
      this.columnResPaySubTypeId = new DataColumn("ResPaySubTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResPaySubTypeId);
      this.columnResPaySubTypeDescription = new DataColumn("ResPaySubTypeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResPaySubTypeDescription);
      this.columnCoverageTypeId = new DataColumn("CoverageTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageTypeId);
      this.columnCoverageType = new DataColumn("CoverageType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageType);
      this.columnCoverageTypeDescriptionId = new DataColumn("CoverageTypeDescriptionId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageTypeDescriptionId);
      this.columnCoverageTypeDescription = new DataColumn("CoverageTypeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageTypeDescription);
      this.columnTotalReserve = new DataColumn("TotalReserve", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalReserve);
      this.columnTotalPayments = new DataColumn("TotalPayments", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalPayments);
      this.columnRemainingReserves = new DataColumn("RemainingReserves", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemainingReserves);
      this.columnClaimantGuid.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsReservePaymentBreakout.ReservePaymentBreakoutRow NewReservePaymentBreakoutRow()
    {
      return (dsReservePaymentBreakout.ReservePaymentBreakoutRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsReservePaymentBreakout.ReservePaymentBreakoutRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsReservePaymentBreakout.ReservePaymentBreakoutRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.ReservePaymentBreakoutRowChanged == null)
        return;
      this.ReservePaymentBreakoutRowChanged((object) this, new dsReservePaymentBreakout.ReservePaymentBreakoutRowChangeEvent((dsReservePaymentBreakout.ReservePaymentBreakoutRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.ReservePaymentBreakoutRowChanging == null)
        return;
      this.ReservePaymentBreakoutRowChanging((object) this, new dsReservePaymentBreakout.ReservePaymentBreakoutRowChangeEvent((dsReservePaymentBreakout.ReservePaymentBreakoutRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.ReservePaymentBreakoutRowDeleted == null)
        return;
      this.ReservePaymentBreakoutRowDeleted((object) this, new dsReservePaymentBreakout.ReservePaymentBreakoutRowChangeEvent((dsReservePaymentBreakout.ReservePaymentBreakoutRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.ReservePaymentBreakoutRowDeleting == null)
        return;
      this.ReservePaymentBreakoutRowDeleting((object) this, new dsReservePaymentBreakout.ReservePaymentBreakoutRowChangeEvent((dsReservePaymentBreakout.ReservePaymentBreakoutRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveReservePaymentBreakoutRow(
      dsReservePaymentBreakout.ReservePaymentBreakoutRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsReservePaymentBreakout reservePaymentBreakout = new dsReservePaymentBreakout();
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
        FixedValue = reservePaymentBreakout.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ReservePaymentBreakoutDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = reservePaymentBreakout.GetSchemaSerializable();
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
  public class ClaimantsDataTable : TypedTableBase<dsReservePaymentBreakout.ClaimantsRow>
  {
    private DataColumn columnClaimantGuid;
    private DataColumn columnClaimantName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ClaimantsDataTable()
    {
      this.TableName = "Claimants";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ClaimantsDataTable(DataTable table)
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
    protected ClaimantsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClaimantGuidColumn => this.columnClaimantGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClaimantNameColumn => this.columnClaimantName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsReservePaymentBreakout.ClaimantsRow this[int index]
    {
      get => (dsReservePaymentBreakout.ClaimantsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsReservePaymentBreakout.ClaimantsRowChangeEventHandler ClaimantsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsReservePaymentBreakout.ClaimantsRowChangeEventHandler ClaimantsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsReservePaymentBreakout.ClaimantsRowChangeEventHandler ClaimantsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsReservePaymentBreakout.ClaimantsRowChangeEventHandler ClaimantsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddClaimantsRow(dsReservePaymentBreakout.ClaimantsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsReservePaymentBreakout.ClaimantsRow AddClaimantsRow(
      Guid ClaimantGuid,
      string ClaimantName)
    {
      dsReservePaymentBreakout.ClaimantsRow row = (dsReservePaymentBreakout.ClaimantsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ClaimantGuid,
        (object) ClaimantName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsReservePaymentBreakout.ClaimantsRow FindByClaimantGuid(Guid ClaimantGuid)
    {
      return (dsReservePaymentBreakout.ClaimantsRow) this.Rows.Find(new object[1]
      {
        (object) ClaimantGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsReservePaymentBreakout.ClaimantsDataTable claimantsDataTable = (dsReservePaymentBreakout.ClaimantsDataTable) base.Clone();
      claimantsDataTable.InitVars();
      return (DataTable) claimantsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsReservePaymentBreakout.ClaimantsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnClaimantGuid = this.Columns["ClaimantGuid"];
      this.columnClaimantName = this.Columns["ClaimantName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnClaimantGuid = new DataColumn("ClaimantGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimantGuid);
      this.columnClaimantName = new DataColumn("ClaimantName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimantName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnClaimantGuid
      }, true));
      this.columnClaimantGuid.AllowDBNull = false;
      this.columnClaimantGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsReservePaymentBreakout.ClaimantsRow NewClaimantsRow()
    {
      return (dsReservePaymentBreakout.ClaimantsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsReservePaymentBreakout.ClaimantsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsReservePaymentBreakout.ClaimantsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.ClaimantsRowChanged == null)
        return;
      this.ClaimantsRowChanged((object) this, new dsReservePaymentBreakout.ClaimantsRowChangeEvent((dsReservePaymentBreakout.ClaimantsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.ClaimantsRowChanging == null)
        return;
      this.ClaimantsRowChanging((object) this, new dsReservePaymentBreakout.ClaimantsRowChangeEvent((dsReservePaymentBreakout.ClaimantsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.ClaimantsRowDeleted == null)
        return;
      this.ClaimantsRowDeleted((object) this, new dsReservePaymentBreakout.ClaimantsRowChangeEvent((dsReservePaymentBreakout.ClaimantsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.ClaimantsRowDeleting == null)
        return;
      this.ClaimantsRowDeleting((object) this, new dsReservePaymentBreakout.ClaimantsRowChangeEvent((dsReservePaymentBreakout.ClaimantsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveClaimantsRow(dsReservePaymentBreakout.ClaimantsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsReservePaymentBreakout reservePaymentBreakout = new dsReservePaymentBreakout();
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
        FixedValue = reservePaymentBreakout.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ClaimantsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = reservePaymentBreakout.GetSchemaSerializable();
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

  public class ReservePaymentBreakoutRow : DataRow
  {
    private dsReservePaymentBreakout.ReservePaymentBreakoutDataTable tableReservePaymentBreakout;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ReservePaymentBreakoutRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableReservePaymentBreakout = (dsReservePaymentBreakout.ReservePaymentBreakoutDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ClaimantGuid
    {
      get => (Guid) this[this.tableReservePaymentBreakout.ClaimantGuidColumn];
      set => this[this.tableReservePaymentBreakout.ClaimantGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ClaimantName
    {
      get
      {
        try
        {
          return (string) this[this.tableReservePaymentBreakout.ClaimantNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ClaimantName' in table 'ReservePaymentBreakout' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservePaymentBreakout.ClaimantNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ResPayTypeId
    {
      get
      {
        try
        {
          return (int) this[this.tableReservePaymentBreakout.ResPayTypeIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ResPayTypeId' in table 'ReservePaymentBreakout' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservePaymentBreakout.ResPayTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ResPayTypeDescription
    {
      get
      {
        try
        {
          return (string) this[this.tableReservePaymentBreakout.ResPayTypeDescriptionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ResPayTypeDescription' in table 'ReservePaymentBreakout' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservePaymentBreakout.ResPayTypeDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ResPaySubTypeId
    {
      get
      {
        try
        {
          return (int) this[this.tableReservePaymentBreakout.ResPaySubTypeIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ResPaySubTypeId' in table 'ReservePaymentBreakout' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservePaymentBreakout.ResPaySubTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ResPaySubTypeDescription
    {
      get
      {
        try
        {
          return (string) this[this.tableReservePaymentBreakout.ResPaySubTypeDescriptionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ResPaySubTypeDescription' in table 'ReservePaymentBreakout' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservePaymentBreakout.ResPaySubTypeDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int CoverageTypeId
    {
      get
      {
        try
        {
          return (int) this[this.tableReservePaymentBreakout.CoverageTypeIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CoverageTypeId' in table 'ReservePaymentBreakout' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservePaymentBreakout.CoverageTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CoverageType
    {
      get
      {
        try
        {
          return (string) this[this.tableReservePaymentBreakout.CoverageTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CoverageType' in table 'ReservePaymentBreakout' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservePaymentBreakout.CoverageTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int CoverageTypeDescriptionId
    {
      get
      {
        try
        {
          return (int) this[this.tableReservePaymentBreakout.CoverageTypeDescriptionIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CoverageTypeDescriptionId' in table 'ReservePaymentBreakout' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tableReservePaymentBreakout.CoverageTypeDescriptionIdColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CoverageTypeDescription
    {
      get
      {
        try
        {
          return (string) this[this.tableReservePaymentBreakout.CoverageTypeDescriptionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CoverageTypeDescription' in table 'ReservePaymentBreakout' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservePaymentBreakout.CoverageTypeDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TotalReserve
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableReservePaymentBreakout.TotalReserveColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'TotalReserve' in table 'ReservePaymentBreakout' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservePaymentBreakout.TotalReserveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TotalPayments
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableReservePaymentBreakout.TotalPaymentsColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'TotalPayments' in table 'ReservePaymentBreakout' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservePaymentBreakout.TotalPaymentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal RemainingReserves
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableReservePaymentBreakout.RemainingReservesColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'RemainingReserves' in table 'ReservePaymentBreakout' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservePaymentBreakout.RemainingReservesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsReservePaymentBreakout.ClaimantsRow ClaimantsRow
    {
      get
      {
        return (dsReservePaymentBreakout.ClaimantsRow) this.GetParentRow(this.Table.ParentRelations["Claimants_ReservePaymentBreakout"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["Claimants_ReservePaymentBreakout"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsClaimantNameNull()
    {
      return this.IsNull(this.tableReservePaymentBreakout.ClaimantNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetClaimantNameNull()
    {
      this[this.tableReservePaymentBreakout.ClaimantNameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsResPayTypeIdNull()
    {
      return this.IsNull(this.tableReservePaymentBreakout.ResPayTypeIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetResPayTypeIdNull()
    {
      this[this.tableReservePaymentBreakout.ResPayTypeIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsResPayTypeDescriptionNull()
    {
      return this.IsNull(this.tableReservePaymentBreakout.ResPayTypeDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetResPayTypeDescriptionNull()
    {
      this[this.tableReservePaymentBreakout.ResPayTypeDescriptionColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsResPaySubTypeIdNull()
    {
      return this.IsNull(this.tableReservePaymentBreakout.ResPaySubTypeIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetResPaySubTypeIdNull()
    {
      this[this.tableReservePaymentBreakout.ResPaySubTypeIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsResPaySubTypeDescriptionNull()
    {
      return this.IsNull(this.tableReservePaymentBreakout.ResPaySubTypeDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetResPaySubTypeDescriptionNull()
    {
      this[this.tableReservePaymentBreakout.ResPaySubTypeDescriptionColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCoverageTypeIdNull()
    {
      return this.IsNull(this.tableReservePaymentBreakout.CoverageTypeIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCoverageTypeIdNull()
    {
      this[this.tableReservePaymentBreakout.CoverageTypeIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCoverageTypeNull()
    {
      return this.IsNull(this.tableReservePaymentBreakout.CoverageTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCoverageTypeNull()
    {
      this[this.tableReservePaymentBreakout.CoverageTypeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCoverageTypeDescriptionIdNull()
    {
      return this.IsNull(this.tableReservePaymentBreakout.CoverageTypeDescriptionIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCoverageTypeDescriptionIdNull()
    {
      this[this.tableReservePaymentBreakout.CoverageTypeDescriptionIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCoverageTypeDescriptionNull()
    {
      return this.IsNull(this.tableReservePaymentBreakout.CoverageTypeDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCoverageTypeDescriptionNull()
    {
      this[this.tableReservePaymentBreakout.CoverageTypeDescriptionColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTotalReserveNull()
    {
      return this.IsNull(this.tableReservePaymentBreakout.TotalReserveColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTotalReserveNull()
    {
      this[this.tableReservePaymentBreakout.TotalReserveColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTotalPaymentsNull()
    {
      return this.IsNull(this.tableReservePaymentBreakout.TotalPaymentsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTotalPaymentsNull()
    {
      this[this.tableReservePaymentBreakout.TotalPaymentsColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRemainingReservesNull()
    {
      return this.IsNull(this.tableReservePaymentBreakout.RemainingReservesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRemainingReservesNull()
    {
      this[this.tableReservePaymentBreakout.RemainingReservesColumn] = Convert.DBNull;
    }
  }

  public class ClaimantsRow : DataRow
  {
    private dsReservePaymentBreakout.ClaimantsDataTable tableClaimants;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ClaimantsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableClaimants = (dsReservePaymentBreakout.ClaimantsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ClaimantGuid
    {
      get => (Guid) this[this.tableClaimants.ClaimantGuidColumn];
      set => this[this.tableClaimants.ClaimantGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ClaimantName
    {
      get
      {
        try
        {
          return (string) this[this.tableClaimants.ClaimantNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ClaimantName' in table 'Claimants' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableClaimants.ClaimantNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsClaimantNameNull() => this.IsNull(this.tableClaimants.ClaimantNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetClaimantNameNull()
    {
      this[this.tableClaimants.ClaimantNameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsReservePaymentBreakout.ReservePaymentBreakoutRow[] GetReservePaymentBreakoutRows()
    {
      return this.Table.ChildRelations["Claimants_ReservePaymentBreakout"] == null ? new dsReservePaymentBreakout.ReservePaymentBreakoutRow[0] : (dsReservePaymentBreakout.ReservePaymentBreakoutRow[]) this.GetChildRows(this.Table.ChildRelations["Claimants_ReservePaymentBreakout"]);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class ReservePaymentBreakoutRowChangeEvent : EventArgs
  {
    private dsReservePaymentBreakout.ReservePaymentBreakoutRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ReservePaymentBreakoutRowChangeEvent(
      dsReservePaymentBreakout.ReservePaymentBreakoutRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsReservePaymentBreakout.ReservePaymentBreakoutRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class ClaimantsRowChangeEvent : EventArgs
  {
    private dsReservePaymentBreakout.ClaimantsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ClaimantsRowChangeEvent(dsReservePaymentBreakout.ClaimantsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsReservePaymentBreakout.ClaimantsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
