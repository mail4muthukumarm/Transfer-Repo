// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.dsReservesPayments
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
[XmlRoot("dsReservesPayments")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsReservesPayments : DataSet
{
  private dsReservesPayments.ReservesPaymentsDataTable tableReservesPayments;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsReservesPayments()
  {
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected dsReservesPayments(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (ReservesPayments)] != null)
          base.Tables.Add((DataTable) new dsReservesPayments.ReservesPaymentsDataTable(dataSet.Tables[nameof (ReservesPayments)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsReservesPayments.ReservesPaymentsDataTable ReservesPayments
  {
    get => this.tableReservesPayments;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public override DataSet Clone()
  {
    dsReservesPayments reservesPayments = (dsReservesPayments) base.Clone();
    reservesPayments.InitVars();
    reservesPayments.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) reservesPayments;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["ReservesPayments"] != null)
        base.Tables.Add((DataTable) new dsReservesPayments.ReservesPaymentsDataTable(dataSet.Tables["ReservesPayments"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tableReservesPayments = (dsReservesPayments.ReservesPaymentsDataTable) base.Tables["ReservesPayments"];
    if (!initTable || this.tableReservesPayments == null)
      return;
    this.tableReservesPayments.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsReservesPayments);
    this.Prefix = "";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableReservesPayments = new dsReservesPayments.ReservesPaymentsDataTable();
    base.Tables.Add((DataTable) this.tableReservesPayments);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeReservesPayments() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsReservesPayments reservesPayments = new dsReservesPayments();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = reservesPayments.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = reservesPayments.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void ReservesPaymentsRowChangeEventHandler(
    object sender,
    dsReservesPayments.ReservesPaymentsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class ReservesPaymentsDataTable : TypedTableBase<dsReservesPayments.ReservesPaymentsRow>
  {
    private DataColumn columnResPayId;
    private DataColumn columnEntryTypeId;
    private DataColumn columnEntryType;
    private DataColumn columnCoverageTypeId;
    private DataColumn columnCoverageType;
    private DataColumn columnCoverageTypeDescriptionId;
    private DataColumn columnCoverageTypeDescription;
    private DataColumn columnResPayTypeId;
    private DataColumn columnResPayType;
    private DataColumn columnResPaySubTypeId;
    private DataColumn columnResPaySubType;
    private DataColumn columnResPayAmount;
    private DataColumn columnDateCreated;
    private DataColumn columnCreatedByGuid;
    private DataColumn columnCreatedBy;
    private DataColumn columnComments;
    private DataColumn columnPayeeGuid;
    private DataColumn columnPayee;
    private DataColumn columnIsVoid;
    private DataColumn columnIsPaymentReduction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public ReservesPaymentsDataTable()
    {
      this.TableName = "ReservesPayments";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal ReservesPaymentsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected ReservesPaymentsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ResPayIdColumn => this.columnResPayId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EntryTypeIdColumn => this.columnEntryTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EntryTypeColumn => this.columnEntryType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoverageTypeIdColumn => this.columnCoverageTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoverageTypeColumn => this.columnCoverageType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoverageTypeDescriptionIdColumn => this.columnCoverageTypeDescriptionId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoverageTypeDescriptionColumn => this.columnCoverageTypeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ResPayTypeIdColumn => this.columnResPayTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ResPayTypeColumn => this.columnResPayType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ResPaySubTypeIdColumn => this.columnResPaySubTypeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ResPaySubTypeColumn => this.columnResPaySubType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ResPayAmountColumn => this.columnResPayAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateCreatedColumn => this.columnDateCreated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CreatedByGuidColumn => this.columnCreatedByGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CreatedByColumn => this.columnCreatedBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CommentsColumn => this.columnComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayeeGuidColumn => this.columnPayeeGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayeeColumn => this.columnPayee;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IsVoidColumn => this.columnIsVoid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IsPaymentReductionColumn => this.columnIsPaymentReduction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsReservesPayments.ReservesPaymentsRow this[int index]
    {
      get => (dsReservesPayments.ReservesPaymentsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsReservesPayments.ReservesPaymentsRowChangeEventHandler ReservesPaymentsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsReservesPayments.ReservesPaymentsRowChangeEventHandler ReservesPaymentsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsReservesPayments.ReservesPaymentsRowChangeEventHandler ReservesPaymentsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsReservesPayments.ReservesPaymentsRowChangeEventHandler ReservesPaymentsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddReservesPaymentsRow(dsReservesPayments.ReservesPaymentsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsReservesPayments.ReservesPaymentsRow AddReservesPaymentsRow(
      string EntryTypeId,
      string EntryType,
      int CoverageTypeId,
      string CoverageType,
      int CoverageTypeDescriptionId,
      string CoverageTypeDescription,
      int ResPayTypeId,
      string ResPayType,
      int ResPaySubTypeId,
      string ResPaySubType,
      Decimal ResPayAmount,
      DateTime DateCreated,
      Guid CreatedByGuid,
      string CreatedBy,
      string Comments,
      Guid PayeeGuid,
      string Payee,
      bool IsVoid,
      bool IsPaymentReduction)
    {
      dsReservesPayments.ReservesPaymentsRow row = (dsReservesPayments.ReservesPaymentsRow) this.NewRow();
      object[] objArray = new object[20]
      {
        null,
        (object) EntryTypeId,
        (object) EntryType,
        (object) CoverageTypeId,
        (object) CoverageType,
        (object) CoverageTypeDescriptionId,
        (object) CoverageTypeDescription,
        (object) ResPayTypeId,
        (object) ResPayType,
        (object) ResPaySubTypeId,
        (object) ResPaySubType,
        (object) ResPayAmount,
        (object) DateCreated,
        (object) CreatedByGuid,
        (object) CreatedBy,
        (object) Comments,
        (object) PayeeGuid,
        (object) Payee,
        (object) IsVoid,
        (object) IsPaymentReduction
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsReservesPayments.ReservesPaymentsRow FindByResPayId(int ResPayId)
    {
      return (dsReservesPayments.ReservesPaymentsRow) this.Rows.Find(new object[1]
      {
        (object) ResPayId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsReservesPayments.ReservesPaymentsDataTable paymentsDataTable = (dsReservesPayments.ReservesPaymentsDataTable) base.Clone();
      paymentsDataTable.InitVars();
      return (DataTable) paymentsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsReservesPayments.ReservesPaymentsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnResPayId = this.Columns["ResPayId"];
      this.columnEntryTypeId = this.Columns["EntryTypeId"];
      this.columnEntryType = this.Columns["EntryType"];
      this.columnCoverageTypeId = this.Columns["CoverageTypeId"];
      this.columnCoverageType = this.Columns["CoverageType"];
      this.columnCoverageTypeDescriptionId = this.Columns["CoverageTypeDescriptionId"];
      this.columnCoverageTypeDescription = this.Columns["CoverageTypeDescription"];
      this.columnResPayTypeId = this.Columns["ResPayTypeId"];
      this.columnResPayType = this.Columns["ResPayType"];
      this.columnResPaySubTypeId = this.Columns["ResPaySubTypeId"];
      this.columnResPaySubType = this.Columns["ResPaySubType"];
      this.columnResPayAmount = this.Columns["ResPayAmount"];
      this.columnDateCreated = this.Columns["DateCreated"];
      this.columnCreatedByGuid = this.Columns["CreatedByGuid"];
      this.columnCreatedBy = this.Columns["CreatedBy"];
      this.columnComments = this.Columns["Comments"];
      this.columnPayeeGuid = this.Columns["PayeeGuid"];
      this.columnPayee = this.Columns["Payee"];
      this.columnIsVoid = this.Columns["IsVoid"];
      this.columnIsPaymentReduction = this.Columns["IsPaymentReduction"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnResPayId = new DataColumn("ResPayId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResPayId);
      this.columnEntryTypeId = new DataColumn("EntryTypeId", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntryTypeId);
      this.columnEntryType = new DataColumn("EntryType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntryType);
      this.columnCoverageTypeId = new DataColumn("CoverageTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageTypeId);
      this.columnCoverageType = new DataColumn("CoverageType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageType);
      this.columnCoverageTypeDescriptionId = new DataColumn("CoverageTypeDescriptionId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageTypeDescriptionId);
      this.columnCoverageTypeDescription = new DataColumn("CoverageTypeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageTypeDescription);
      this.columnResPayTypeId = new DataColumn("ResPayTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResPayTypeId);
      this.columnResPayType = new DataColumn("ResPayType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResPayType);
      this.columnResPaySubTypeId = new DataColumn("ResPaySubTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResPaySubTypeId);
      this.columnResPaySubType = new DataColumn("ResPaySubType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResPaySubType);
      this.columnResPayAmount = new DataColumn("ResPayAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResPayAmount);
      this.columnDateCreated = new DataColumn("DateCreated", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateCreated);
      this.columnCreatedByGuid = new DataColumn("CreatedByGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCreatedByGuid);
      this.columnCreatedBy = new DataColumn("CreatedBy", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCreatedBy);
      this.columnComments = new DataColumn("Comments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComments);
      this.columnPayeeGuid = new DataColumn("PayeeGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeGuid);
      this.columnPayee = new DataColumn("Payee", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayee);
      this.columnIsVoid = new DataColumn("IsVoid", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsVoid);
      this.columnIsPaymentReduction = new DataColumn("IsPaymentReduction", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsPaymentReduction);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnResPayId
      }, true));
      this.columnResPayId.AutoIncrement = true;
      this.columnResPayId.AutoIncrementSeed = -1L;
      this.columnResPayId.AutoIncrementStep = -1L;
      this.columnResPayId.AllowDBNull = false;
      this.columnResPayId.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsReservesPayments.ReservesPaymentsRow NewReservesPaymentsRow()
    {
      return (dsReservesPayments.ReservesPaymentsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsReservesPayments.ReservesPaymentsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsReservesPayments.ReservesPaymentsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.ReservesPaymentsRowChanged == null)
        return;
      this.ReservesPaymentsRowChanged((object) this, new dsReservesPayments.ReservesPaymentsRowChangeEvent((dsReservesPayments.ReservesPaymentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.ReservesPaymentsRowChanging == null)
        return;
      this.ReservesPaymentsRowChanging((object) this, new dsReservesPayments.ReservesPaymentsRowChangeEvent((dsReservesPayments.ReservesPaymentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.ReservesPaymentsRowDeleted == null)
        return;
      this.ReservesPaymentsRowDeleted((object) this, new dsReservesPayments.ReservesPaymentsRowChangeEvent((dsReservesPayments.ReservesPaymentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.ReservesPaymentsRowDeleting == null)
        return;
      this.ReservesPaymentsRowDeleting((object) this, new dsReservesPayments.ReservesPaymentsRowChangeEvent((dsReservesPayments.ReservesPaymentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveReservesPaymentsRow(dsReservesPayments.ReservesPaymentsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsReservesPayments reservesPayments = new dsReservesPayments();
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
        FixedValue = reservesPayments.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ReservesPaymentsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = reservesPayments.GetSchemaSerializable();
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

  public class ReservesPaymentsRow : DataRow
  {
    private dsReservesPayments.ReservesPaymentsDataTable tableReservesPayments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal ReservesPaymentsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableReservesPayments = (dsReservesPayments.ReservesPaymentsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ResPayId
    {
      get => (int) this[this.tableReservesPayments.ResPayIdColumn];
      set => this[this.tableReservesPayments.ResPayIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EntryTypeId
    {
      get
      {
        try
        {
          return (string) this[this.tableReservesPayments.EntryTypeIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EntryTypeId' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.EntryTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EntryType
    {
      get
      {
        try
        {
          return (string) this[this.tableReservesPayments.EntryTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EntryType' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.EntryTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CoverageTypeId
    {
      get
      {
        try
        {
          return (int) this[this.tableReservesPayments.CoverageTypeIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CoverageTypeId' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.CoverageTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CoverageType
    {
      get
      {
        try
        {
          return (string) this[this.tableReservesPayments.CoverageTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CoverageType' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.CoverageTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CoverageTypeDescriptionId
    {
      get
      {
        try
        {
          return (int) this[this.tableReservesPayments.CoverageTypeDescriptionIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CoverageTypeDescriptionId' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.CoverageTypeDescriptionIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CoverageTypeDescription
    {
      get
      {
        try
        {
          return (string) this[this.tableReservesPayments.CoverageTypeDescriptionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CoverageTypeDescription' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.CoverageTypeDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ResPayTypeId
    {
      get
      {
        try
        {
          return (int) this[this.tableReservesPayments.ResPayTypeIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ResPayTypeId' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.ResPayTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ResPayType
    {
      get
      {
        try
        {
          return (string) this[this.tableReservesPayments.ResPayTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ResPayType' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.ResPayTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ResPaySubTypeId
    {
      get
      {
        try
        {
          return (int) this[this.tableReservesPayments.ResPaySubTypeIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ResPaySubTypeId' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.ResPaySubTypeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ResPaySubType
    {
      get
      {
        try
        {
          return (string) this[this.tableReservesPayments.ResPaySubTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ResPaySubType' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.ResPaySubTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal ResPayAmount
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableReservesPayments.ResPayAmountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ResPayAmount' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.ResPayAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateCreated
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableReservesPayments.DateCreatedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'DateCreated' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.DateCreatedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CreatedByGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tableReservesPayments.CreatedByGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CreatedByGuid' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.CreatedByGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CreatedBy
    {
      get
      {
        try
        {
          return (string) this[this.tableReservesPayments.CreatedByColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CreatedBy' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.CreatedByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Comments
    {
      get
      {
        try
        {
          return (string) this[this.tableReservesPayments.CommentsColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Comments' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.CommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid PayeeGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tableReservesPayments.PayeeGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PayeeGuid' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.PayeeGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Payee
    {
      get
      {
        try
        {
          return (string) this[this.tableReservesPayments.PayeeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Payee' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.PayeeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsVoid
    {
      get
      {
        try
        {
          return (bool) this[this.tableReservesPayments.IsVoidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'IsVoid' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.IsVoidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPaymentReduction
    {
      get
      {
        try
        {
          return (bool) this[this.tableReservesPayments.IsPaymentReductionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'IsPaymentReduction' in table 'ReservesPayments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReservesPayments.IsPaymentReductionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEntryTypeIdNull() => this.IsNull(this.tableReservesPayments.EntryTypeIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEntryTypeIdNull()
    {
      this[this.tableReservesPayments.EntryTypeIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEntryTypeNull() => this.IsNull(this.tableReservesPayments.EntryTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEntryTypeNull()
    {
      this[this.tableReservesPayments.EntryTypeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCoverageTypeIdNull()
    {
      return this.IsNull(this.tableReservesPayments.CoverageTypeIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCoverageTypeIdNull()
    {
      this[this.tableReservesPayments.CoverageTypeIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCoverageTypeNull() => this.IsNull(this.tableReservesPayments.CoverageTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCoverageTypeNull()
    {
      this[this.tableReservesPayments.CoverageTypeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCoverageTypeDescriptionIdNull()
    {
      return this.IsNull(this.tableReservesPayments.CoverageTypeDescriptionIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCoverageTypeDescriptionIdNull()
    {
      this[this.tableReservesPayments.CoverageTypeDescriptionIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCoverageTypeDescriptionNull()
    {
      return this.IsNull(this.tableReservesPayments.CoverageTypeDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCoverageTypeDescriptionNull()
    {
      this[this.tableReservesPayments.CoverageTypeDescriptionColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsResPayTypeIdNull() => this.IsNull(this.tableReservesPayments.ResPayTypeIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetResPayTypeIdNull()
    {
      this[this.tableReservesPayments.ResPayTypeIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsResPayTypeNull() => this.IsNull(this.tableReservesPayments.ResPayTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetResPayTypeNull()
    {
      this[this.tableReservesPayments.ResPayTypeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsResPaySubTypeIdNull()
    {
      return this.IsNull(this.tableReservesPayments.ResPaySubTypeIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetResPaySubTypeIdNull()
    {
      this[this.tableReservesPayments.ResPaySubTypeIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsResPaySubTypeNull()
    {
      return this.IsNull(this.tableReservesPayments.ResPaySubTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetResPaySubTypeNull()
    {
      this[this.tableReservesPayments.ResPaySubTypeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsResPayAmountNull() => this.IsNull(this.tableReservesPayments.ResPayAmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetResPayAmountNull()
    {
      this[this.tableReservesPayments.ResPayAmountColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateCreatedNull() => this.IsNull(this.tableReservesPayments.DateCreatedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateCreatedNull()
    {
      this[this.tableReservesPayments.DateCreatedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCreatedByGuidNull()
    {
      return this.IsNull(this.tableReservesPayments.CreatedByGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCreatedByGuidNull()
    {
      this[this.tableReservesPayments.CreatedByGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCreatedByNull() => this.IsNull(this.tableReservesPayments.CreatedByColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCreatedByNull()
    {
      this[this.tableReservesPayments.CreatedByColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCommentsNull() => this.IsNull(this.tableReservesPayments.CommentsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCommentsNull()
    {
      this[this.tableReservesPayments.CommentsColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPayeeGuidNull() => this.IsNull(this.tableReservesPayments.PayeeGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPayeeGuidNull()
    {
      this[this.tableReservesPayments.PayeeGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPayeeNull() => this.IsNull(this.tableReservesPayments.PayeeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPayeeNull() => this[this.tableReservesPayments.PayeeColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIsVoidNull() => this.IsNull(this.tableReservesPayments.IsVoidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIsVoidNull() => this[this.tableReservesPayments.IsVoidColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIsPaymentReductionNull()
    {
      return this.IsNull(this.tableReservesPayments.IsPaymentReductionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIsPaymentReductionNull()
    {
      this[this.tableReservesPayments.IsPaymentReductionColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class ReservesPaymentsRowChangeEvent : EventArgs
  {
    private dsReservesPayments.ReservesPaymentsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public ReservesPaymentsRowChangeEvent(
      dsReservesPayments.ReservesPaymentsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsReservesPayments.ReservesPaymentsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
