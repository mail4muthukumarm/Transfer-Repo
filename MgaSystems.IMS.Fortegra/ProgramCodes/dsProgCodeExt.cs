// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.ProgramCodes.dsProgCodeExt
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

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
namespace MgaSystems.Ims.Fortegra.ProgramCodes;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsProgCodeExt")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsProgCodeExt : DataSet
{
  private dsProgCodeExt.Fortegra_tblCompanyProgramCodesDataTable tableFortegra_tblCompanyProgramCodes;
  private dsProgCodeExt.Fortegra_tblCompanyProgramParticpationDataTable tableFortegra_tblCompanyProgramParticpation;
  private dsProgCodeExt.tblCompanyLocationsDataTable tabletblCompanyLocations;
  private dsProgCodeExt.tblCompaniesDataTable tabletblCompanies;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsProgCodeExt()
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
  protected dsProgCodeExt(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (Fortegra_tblCompanyProgramCodes)] != null)
          base.Tables.Add((DataTable) new dsProgCodeExt.Fortegra_tblCompanyProgramCodesDataTable(dataSet.Tables[nameof (Fortegra_tblCompanyProgramCodes)]));
        if (dataSet.Tables[nameof (Fortegra_tblCompanyProgramParticpation)] != null)
          base.Tables.Add((DataTable) new dsProgCodeExt.Fortegra_tblCompanyProgramParticpationDataTable(dataSet.Tables[nameof (Fortegra_tblCompanyProgramParticpation)]));
        if (dataSet.Tables[nameof (tblCompanyLocations)] != null)
          base.Tables.Add((DataTable) new dsProgCodeExt.tblCompanyLocationsDataTable(dataSet.Tables[nameof (tblCompanyLocations)]));
        if (dataSet.Tables[nameof (tblCompanies)] != null)
          base.Tables.Add((DataTable) new dsProgCodeExt.tblCompaniesDataTable(dataSet.Tables[nameof (tblCompanies)]));
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
  public dsProgCodeExt.Fortegra_tblCompanyProgramCodesDataTable Fortegra_tblCompanyProgramCodes
  {
    get => this.tableFortegra_tblCompanyProgramCodes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProgCodeExt.Fortegra_tblCompanyProgramParticpationDataTable Fortegra_tblCompanyProgramParticpation
  {
    get => this.tableFortegra_tblCompanyProgramParticpation;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProgCodeExt.tblCompanyLocationsDataTable tblCompanyLocations
  {
    get => this.tabletblCompanyLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProgCodeExt.tblCompaniesDataTable tblCompanies => this.tabletblCompanies;

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
    dsProgCodeExt dsProgCodeExt = (dsProgCodeExt) base.Clone();
    dsProgCodeExt.InitVars();
    dsProgCodeExt.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsProgCodeExt;
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
      if (dataSet.Tables["Fortegra_tblCompanyProgramCodes"] != null)
        base.Tables.Add((DataTable) new dsProgCodeExt.Fortegra_tblCompanyProgramCodesDataTable(dataSet.Tables["Fortegra_tblCompanyProgramCodes"]));
      if (dataSet.Tables["Fortegra_tblCompanyProgramParticpation"] != null)
        base.Tables.Add((DataTable) new dsProgCodeExt.Fortegra_tblCompanyProgramParticpationDataTable(dataSet.Tables["Fortegra_tblCompanyProgramParticpation"]));
      if (dataSet.Tables["tblCompanyLocations"] != null)
        base.Tables.Add((DataTable) new dsProgCodeExt.tblCompanyLocationsDataTable(dataSet.Tables["tblCompanyLocations"]));
      if (dataSet.Tables["tblCompanies"] != null)
        base.Tables.Add((DataTable) new dsProgCodeExt.tblCompaniesDataTable(dataSet.Tables["tblCompanies"]));
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
    this.tableFortegra_tblCompanyProgramCodes = (dsProgCodeExt.Fortegra_tblCompanyProgramCodesDataTable) base.Tables["Fortegra_tblCompanyProgramCodes"];
    if (initTable && this.tableFortegra_tblCompanyProgramCodes != null)
      this.tableFortegra_tblCompanyProgramCodes.InitVars();
    this.tableFortegra_tblCompanyProgramParticpation = (dsProgCodeExt.Fortegra_tblCompanyProgramParticpationDataTable) base.Tables["Fortegra_tblCompanyProgramParticpation"];
    if (initTable && this.tableFortegra_tblCompanyProgramParticpation != null)
      this.tableFortegra_tblCompanyProgramParticpation.InitVars();
    this.tabletblCompanyLocations = (dsProgCodeExt.tblCompanyLocationsDataTable) base.Tables["tblCompanyLocations"];
    if (initTable && this.tabletblCompanyLocations != null)
      this.tabletblCompanyLocations.InitVars();
    this.tabletblCompanies = (dsProgCodeExt.tblCompaniesDataTable) base.Tables["tblCompanies"];
    if (!initTable || this.tabletblCompanies == null)
      return;
    this.tabletblCompanies.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsProgCodeExt);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsProgCodeExt.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableFortegra_tblCompanyProgramCodes = new dsProgCodeExt.Fortegra_tblCompanyProgramCodesDataTable();
    base.Tables.Add((DataTable) this.tableFortegra_tblCompanyProgramCodes);
    this.tableFortegra_tblCompanyProgramParticpation = new dsProgCodeExt.Fortegra_tblCompanyProgramParticpationDataTable();
    base.Tables.Add((DataTable) this.tableFortegra_tblCompanyProgramParticpation);
    this.tabletblCompanyLocations = new dsProgCodeExt.tblCompanyLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLocations);
    this.tabletblCompanies = new dsProgCodeExt.tblCompaniesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanies);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeFortegra_tblCompanyProgramCodes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeFortegra_tblCompanyProgramParticpation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanyLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanies() => false;

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
    dsProgCodeExt dsProgCodeExt = new dsProgCodeExt();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = dsProgCodeExt.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = dsProgCodeExt.GetSchemaSerializable();
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
  public delegate void Fortegra_tblCompanyProgramCodesRowChangeEventHandler(
    object sender,
    dsProgCodeExt.Fortegra_tblCompanyProgramCodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void Fortegra_tblCompanyProgramParticpationRowChangeEventHandler(
    object sender,
    dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblCompanyLocationsRowChangeEventHandler(
    object sender,
    dsProgCodeExt.tblCompanyLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblCompaniesRowChangeEventHandler(
    object sender,
    dsProgCodeExt.tblCompaniesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class Fortegra_tblCompanyProgramCodesDataTable : 
    TypedTableBase<dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow>
  {
    private DataColumn columnProgramID;
    private DataColumn columnCedingCommission;
    private DataColumn columnIssuingCarrierFrontFee;
    private DataColumn columnIssuingCarrierPart;
    private DataColumn columnRIBroker;
    private DataColumn columnRIBrokerGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Fortegra_tblCompanyProgramCodesDataTable()
    {
      this.TableName = "Fortegra_tblCompanyProgramCodes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal Fortegra_tblCompanyProgramCodesDataTable(DataTable table)
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
    protected Fortegra_tblCompanyProgramCodesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProgramIDColumn => this.columnProgramID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CedingCommissionColumn => this.columnCedingCommission;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IssuingCarrierFrontFeeColumn => this.columnIssuingCarrierFrontFee;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IssuingCarrierPartColumn => this.columnIssuingCarrierPart;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RIBrokerColumn => this.columnRIBroker;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RIBrokerGUIDColumn => this.columnRIBrokerGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow this[int index]
    {
      get => (dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.Fortegra_tblCompanyProgramCodesRowChangeEventHandler Fortegra_tblCompanyProgramCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.Fortegra_tblCompanyProgramCodesRowChangeEventHandler Fortegra_tblCompanyProgramCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.Fortegra_tblCompanyProgramCodesRowChangeEventHandler Fortegra_tblCompanyProgramCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.Fortegra_tblCompanyProgramCodesRowChangeEventHandler Fortegra_tblCompanyProgramCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddFortegra_tblCompanyProgramCodesRow(
      dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow AddFortegra_tblCompanyProgramCodesRow(
      int ProgramID,
      Decimal CedingCommission,
      Decimal IssuingCarrierFrontFee,
      Decimal IssuingCarrierPart,
      Decimal RIBroker,
      Guid RIBrokerGUID)
    {
      dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow row = (dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) ProgramID,
        (object) CedingCommission,
        (object) IssuingCarrierFrontFee,
        (object) IssuingCarrierPart,
        (object) RIBroker,
        (object) RIBrokerGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow FindByProgramID(int ProgramID)
    {
      return (dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow) this.Rows.Find(new object[1]
      {
        (object) ProgramID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsProgCodeExt.Fortegra_tblCompanyProgramCodesDataTable programCodesDataTable = (dsProgCodeExt.Fortegra_tblCompanyProgramCodesDataTable) base.Clone();
      programCodesDataTable.InitVars();
      return (DataTable) programCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProgCodeExt.Fortegra_tblCompanyProgramCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnProgramID = this.Columns["ProgramID"];
      this.columnCedingCommission = this.Columns["CedingCommission"];
      this.columnIssuingCarrierFrontFee = this.Columns["IssuingCarrierFrontFee"];
      this.columnIssuingCarrierPart = this.Columns["IssuingCarrierPart"];
      this.columnRIBroker = this.Columns["RIBroker"];
      this.columnRIBrokerGUID = this.Columns["RIBrokerGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnProgramID = new DataColumn("ProgramID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgramID);
      this.columnCedingCommission = new DataColumn("CedingCommission", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCedingCommission);
      this.columnIssuingCarrierFrontFee = new DataColumn("IssuingCarrierFrontFee", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIssuingCarrierFrontFee);
      this.columnIssuingCarrierPart = new DataColumn("IssuingCarrierPart", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIssuingCarrierPart);
      this.columnRIBroker = new DataColumn("RIBroker", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRIBroker);
      this.columnRIBrokerGUID = new DataColumn("RIBrokerGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRIBrokerGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnProgramID
      }, true));
      this.columnProgramID.AllowDBNull = false;
      this.columnProgramID.Unique = true;
      this.columnCedingCommission.AllowDBNull = false;
      this.columnIssuingCarrierFrontFee.AllowDBNull = false;
      this.columnIssuingCarrierPart.AllowDBNull = false;
      this.columnRIBroker.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow NewFortegra_tblCompanyProgramCodesRow()
    {
      return (dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.Fortegra_tblCompanyProgramCodesRowChanged == null)
        return;
      this.Fortegra_tblCompanyProgramCodesRowChanged((object) this, new dsProgCodeExt.Fortegra_tblCompanyProgramCodesRowChangeEvent((dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.Fortegra_tblCompanyProgramCodesRowChanging == null)
        return;
      this.Fortegra_tblCompanyProgramCodesRowChanging((object) this, new dsProgCodeExt.Fortegra_tblCompanyProgramCodesRowChangeEvent((dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.Fortegra_tblCompanyProgramCodesRowDeleted == null)
        return;
      this.Fortegra_tblCompanyProgramCodesRowDeleted((object) this, new dsProgCodeExt.Fortegra_tblCompanyProgramCodesRowChangeEvent((dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.Fortegra_tblCompanyProgramCodesRowDeleting == null)
        return;
      this.Fortegra_tblCompanyProgramCodesRowDeleting((object) this, new dsProgCodeExt.Fortegra_tblCompanyProgramCodesRowChangeEvent((dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveFortegra_tblCompanyProgramCodesRow(
      dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProgCodeExt dsProgCodeExt = new dsProgCodeExt();
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
        FixedValue = dsProgCodeExt.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (Fortegra_tblCompanyProgramCodesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProgCodeExt.GetSchemaSerializable();
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
  public class Fortegra_tblCompanyProgramParticpationDataTable : 
    TypedTableBase<dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow>
  {
    private DataColumn columnProgramID;
    private DataColumn columnCompanyLocationID;
    private DataColumn columnShare;
    private DataColumn columnStartDate;
    private DataColumn columnEndDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Fortegra_tblCompanyProgramParticpationDataTable()
    {
      this.TableName = "Fortegra_tblCompanyProgramParticpation";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal Fortegra_tblCompanyProgramParticpationDataTable(DataTable table)
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
    protected Fortegra_tblCompanyProgramParticpationDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProgramIDColumn => this.columnProgramID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLocationIDColumn => this.columnCompanyLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ShareColumn => this.columnShare;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StartDateColumn => this.columnStartDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EndDateColumn => this.columnEndDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow this[int index]
    {
      get => (dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRowChangeEventHandler Fortegra_tblCompanyProgramParticpationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRowChangeEventHandler Fortegra_tblCompanyProgramParticpationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRowChangeEventHandler Fortegra_tblCompanyProgramParticpationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRowChangeEventHandler Fortegra_tblCompanyProgramParticpationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddFortegra_tblCompanyProgramParticpationRow(
      dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow AddFortegra_tblCompanyProgramParticpationRow(
      int ProgramID,
      int CompanyLocationID,
      Decimal Share,
      DateTime StartDate,
      DateTime EndDate)
    {
      dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow row = (dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) ProgramID,
        (object) CompanyLocationID,
        (object) Share,
        (object) StartDate,
        (object) EndDate
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow FindByProgramIDCompanyLocationIDStartDate(
      int ProgramID,
      int CompanyLocationID,
      DateTime StartDate)
    {
      return (dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow) this.Rows.Find(new object[3]
      {
        (object) ProgramID,
        (object) CompanyLocationID,
        (object) StartDate
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsProgCodeExt.Fortegra_tblCompanyProgramParticpationDataTable particpationDataTable = (dsProgCodeExt.Fortegra_tblCompanyProgramParticpationDataTable) base.Clone();
      particpationDataTable.InitVars();
      return (DataTable) particpationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProgCodeExt.Fortegra_tblCompanyProgramParticpationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnProgramID = this.Columns["ProgramID"];
      this.columnCompanyLocationID = this.Columns["CompanyLocationID"];
      this.columnShare = this.Columns["Share"];
      this.columnStartDate = this.Columns["StartDate"];
      this.columnEndDate = this.Columns["EndDate"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnProgramID = new DataColumn("ProgramID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgramID);
      this.columnCompanyLocationID = new DataColumn("CompanyLocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationID);
      this.columnShare = new DataColumn("Share", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnShare);
      this.columnStartDate = new DataColumn("StartDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStartDate);
      this.columnEndDate = new DataColumn("EndDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndDate);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[3]
      {
        this.columnProgramID,
        this.columnCompanyLocationID,
        this.columnStartDate
      }, true));
      this.columnProgramID.AllowDBNull = false;
      this.columnCompanyLocationID.AllowDBNull = false;
      this.columnStartDate.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow NewFortegra_tblCompanyProgramParticpationRow()
    {
      return (dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.Fortegra_tblCompanyProgramParticpationRowChanged == null)
        return;
      this.Fortegra_tblCompanyProgramParticpationRowChanged((object) this, new dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRowChangeEvent((dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.Fortegra_tblCompanyProgramParticpationRowChanging == null)
        return;
      this.Fortegra_tblCompanyProgramParticpationRowChanging((object) this, new dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRowChangeEvent((dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.Fortegra_tblCompanyProgramParticpationRowDeleted == null)
        return;
      this.Fortegra_tblCompanyProgramParticpationRowDeleted((object) this, new dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRowChangeEvent((dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.Fortegra_tblCompanyProgramParticpationRowDeleting == null)
        return;
      this.Fortegra_tblCompanyProgramParticpationRowDeleting((object) this, new dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRowChangeEvent((dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveFortegra_tblCompanyProgramParticpationRow(
      dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProgCodeExt dsProgCodeExt = new dsProgCodeExt();
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
        FixedValue = dsProgCodeExt.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (Fortegra_tblCompanyProgramParticpationDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProgCodeExt.GetSchemaSerializable();
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
  public class tblCompanyLocationsDataTable : TypedTableBase<dsProgCodeExt.tblCompanyLocationsRow>
  {
    private DataColumn columnCompanyLocationID;
    private DataColumn columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyLocationsDataTable()
    {
      this.TableName = "tblCompanyLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyLocationsDataTable(DataTable table)
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
    protected tblCompanyLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLocationIDColumn => this.columnCompanyLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationNameColumn => this.columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.tblCompanyLocationsRow this[int index]
    {
      get => (dsProgCodeExt.tblCompanyLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompanyLocationsRow(dsProgCodeExt.tblCompanyLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.tblCompanyLocationsRow AddtblCompanyLocationsRow(
      int CompanyLocationID,
      string LocationName)
    {
      dsProgCodeExt.tblCompanyLocationsRow row = (dsProgCodeExt.tblCompanyLocationsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyLocationID,
        (object) LocationName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.tblCompanyLocationsRow FindByCompanyLocationID(int CompanyLocationID)
    {
      return (dsProgCodeExt.tblCompanyLocationsRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsProgCodeExt.tblCompanyLocationsDataTable locationsDataTable = (dsProgCodeExt.tblCompanyLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProgCodeExt.tblCompanyLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLocationID = this.Columns["CompanyLocationID"];
      this.columnLocationName = this.Columns["LocationName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLocationID = new DataColumn("CompanyLocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationID);
      this.columnLocationName = new DataColumn("LocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCompanyLocationID
      }, true));
      this.columnCompanyLocationID.AllowDBNull = false;
      this.columnCompanyLocationID.Unique = true;
      this.columnLocationName.AllowDBNull = false;
      this.columnLocationName.MaxLength = 100;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.tblCompanyLocationsRow NewtblCompanyLocationsRow()
    {
      return (dsProgCodeExt.tblCompanyLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProgCodeExt.tblCompanyLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsProgCodeExt.tblCompanyLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.tblCompanyLocationsRowChanged == null)
        return;
      this.tblCompanyLocationsRowChanged((object) this, new dsProgCodeExt.tblCompanyLocationsRowChangeEvent((dsProgCodeExt.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.tblCompanyLocationsRowChanging == null)
        return;
      this.tblCompanyLocationsRowChanging((object) this, new dsProgCodeExt.tblCompanyLocationsRowChangeEvent((dsProgCodeExt.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.tblCompanyLocationsRowDeleted == null)
        return;
      this.tblCompanyLocationsRowDeleted((object) this, new dsProgCodeExt.tblCompanyLocationsRowChangeEvent((dsProgCodeExt.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.tblCompanyLocationsRowDeleting == null)
        return;
      this.tblCompanyLocationsRowDeleting((object) this, new dsProgCodeExt.tblCompanyLocationsRowChangeEvent((dsProgCodeExt.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompanyLocationsRow(dsProgCodeExt.tblCompanyLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProgCodeExt dsProgCodeExt = new dsProgCodeExt();
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
        FixedValue = dsProgCodeExt.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLocationsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProgCodeExt.GetSchemaSerializable();
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
  public class tblCompaniesDataTable : TypedTableBase<dsProgCodeExt.tblCompaniesRow>
  {
    private DataColumn columnCompanyGUID;
    private DataColumn columnCompanyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompaniesDataTable()
    {
      this.TableName = "tblCompanies";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompaniesDataTable(DataTable table)
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
    protected tblCompaniesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyGUIDColumn => this.columnCompanyGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyNameColumn => this.columnCompanyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.tblCompaniesRow this[int index]
    {
      get => (dsProgCodeExt.tblCompaniesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.tblCompaniesRowChangeEventHandler tblCompaniesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.tblCompaniesRowChangeEventHandler tblCompaniesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.tblCompaniesRowChangeEventHandler tblCompaniesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsProgCodeExt.tblCompaniesRowChangeEventHandler tblCompaniesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompaniesRow(dsProgCodeExt.tblCompaniesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.tblCompaniesRow AddtblCompaniesRow(Guid CompanyGUID, string CompanyName)
    {
      dsProgCodeExt.tblCompaniesRow row = (dsProgCodeExt.tblCompaniesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyGUID,
        (object) CompanyName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.tblCompaniesRow FindByCompanyGUID(Guid CompanyGUID)
    {
      return (dsProgCodeExt.tblCompaniesRow) this.Rows.Find(new object[1]
      {
        (object) CompanyGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsProgCodeExt.tblCompaniesDataTable companiesDataTable = (dsProgCodeExt.tblCompaniesDataTable) base.Clone();
      companiesDataTable.InitVars();
      return (DataTable) companiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProgCodeExt.tblCompaniesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyGUID = this.Columns["CompanyGUID"];
      this.columnCompanyName = this.Columns["CompanyName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyGUID = new DataColumn("CompanyGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGUID);
      this.columnCompanyName = new DataColumn("CompanyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCompanyGUID
      }, true));
      this.columnCompanyGUID.AllowDBNull = false;
      this.columnCompanyGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.tblCompaniesRow NewtblCompaniesRow()
    {
      return (dsProgCodeExt.tblCompaniesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProgCodeExt.tblCompaniesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsProgCodeExt.tblCompaniesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.tblCompaniesRowChanged == null)
        return;
      this.tblCompaniesRowChanged((object) this, new dsProgCodeExt.tblCompaniesRowChangeEvent((dsProgCodeExt.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.tblCompaniesRowChanging == null)
        return;
      this.tblCompaniesRowChanging((object) this, new dsProgCodeExt.tblCompaniesRowChangeEvent((dsProgCodeExt.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.tblCompaniesRowDeleted == null)
        return;
      this.tblCompaniesRowDeleted((object) this, new dsProgCodeExt.tblCompaniesRowChangeEvent((dsProgCodeExt.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.tblCompaniesRowDeleting == null)
        return;
      this.tblCompaniesRowDeleting((object) this, new dsProgCodeExt.tblCompaniesRowChangeEvent((dsProgCodeExt.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompaniesRow(dsProgCodeExt.tblCompaniesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProgCodeExt dsProgCodeExt = new dsProgCodeExt();
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
        FixedValue = dsProgCodeExt.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompaniesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProgCodeExt.GetSchemaSerializable();
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

  public class Fortegra_tblCompanyProgramCodesRow : DataRow
  {
    private dsProgCodeExt.Fortegra_tblCompanyProgramCodesDataTable tableFortegra_tblCompanyProgramCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal Fortegra_tblCompanyProgramCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableFortegra_tblCompanyProgramCodes = (dsProgCodeExt.Fortegra_tblCompanyProgramCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ProgramID
    {
      get => (int) this[this.tableFortegra_tblCompanyProgramCodes.ProgramIDColumn];
      set => this[this.tableFortegra_tblCompanyProgramCodes.ProgramIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal CedingCommission
    {
      get => (Decimal) this[this.tableFortegra_tblCompanyProgramCodes.CedingCommissionColumn];
      set
      {
        this[this.tableFortegra_tblCompanyProgramCodes.CedingCommissionColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal IssuingCarrierFrontFee
    {
      get => (Decimal) this[this.tableFortegra_tblCompanyProgramCodes.IssuingCarrierFrontFeeColumn];
      set
      {
        this[this.tableFortegra_tblCompanyProgramCodes.IssuingCarrierFrontFeeColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal IssuingCarrierPart
    {
      get => (Decimal) this[this.tableFortegra_tblCompanyProgramCodes.IssuingCarrierPartColumn];
      set
      {
        this[this.tableFortegra_tblCompanyProgramCodes.IssuingCarrierPartColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal RIBroker
    {
      get => (Decimal) this[this.tableFortegra_tblCompanyProgramCodes.RIBrokerColumn];
      set => this[this.tableFortegra_tblCompanyProgramCodes.RIBrokerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid RIBrokerGUID
    {
      get
      {
        try
        {
          return (Guid) this[this.tableFortegra_tblCompanyProgramCodes.RIBrokerGUIDColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'RIBrokerGUID' in table 'Fortegra_tblCompanyProgramCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFortegra_tblCompanyProgramCodes.RIBrokerGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRIBrokerGUIDNull()
    {
      return this.IsNull(this.tableFortegra_tblCompanyProgramCodes.RIBrokerGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRIBrokerGUIDNull()
    {
      this[this.tableFortegra_tblCompanyProgramCodes.RIBrokerGUIDColumn] = Convert.DBNull;
    }
  }

  public class Fortegra_tblCompanyProgramParticpationRow : DataRow
  {
    private dsProgCodeExt.Fortegra_tblCompanyProgramParticpationDataTable tableFortegra_tblCompanyProgramParticpation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal Fortegra_tblCompanyProgramParticpationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableFortegra_tblCompanyProgramParticpation = (dsProgCodeExt.Fortegra_tblCompanyProgramParticpationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ProgramID
    {
      get => (int) this[this.tableFortegra_tblCompanyProgramParticpation.ProgramIDColumn];
      set
      {
        this[this.tableFortegra_tblCompanyProgramParticpation.ProgramIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CompanyLocationID
    {
      get => (int) this[this.tableFortegra_tblCompanyProgramParticpation.CompanyLocationIDColumn];
      set
      {
        this[this.tableFortegra_tblCompanyProgramParticpation.CompanyLocationIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Share
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableFortegra_tblCompanyProgramParticpation.ShareColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Share' in table 'Fortegra_tblCompanyProgramParticpation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFortegra_tblCompanyProgramParticpation.ShareColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime StartDate
    {
      get => (DateTime) this[this.tableFortegra_tblCompanyProgramParticpation.StartDateColumn];
      set
      {
        this[this.tableFortegra_tblCompanyProgramParticpation.StartDateColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime EndDate
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableFortegra_tblCompanyProgramParticpation.EndDateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EndDate' in table 'Fortegra_tblCompanyProgramParticpation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFortegra_tblCompanyProgramParticpation.EndDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsShareNull()
    {
      return this.IsNull(this.tableFortegra_tblCompanyProgramParticpation.ShareColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetShareNull()
    {
      this[this.tableFortegra_tblCompanyProgramParticpation.ShareColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEndDateNull()
    {
      return this.IsNull(this.tableFortegra_tblCompanyProgramParticpation.EndDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEndDateNull()
    {
      this[this.tableFortegra_tblCompanyProgramParticpation.EndDateColumn] = Convert.DBNull;
    }
  }

  public class tblCompanyLocationsRow : DataRow
  {
    private dsProgCodeExt.tblCompanyLocationsDataTable tabletblCompanyLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLocations = (dsProgCodeExt.tblCompanyLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CompanyLocationID
    {
      get => (int) this[this.tabletblCompanyLocations.CompanyLocationIDColumn];
      set => this[this.tabletblCompanyLocations.CompanyLocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LocationName
    {
      get => (string) this[this.tabletblCompanyLocations.LocationNameColumn];
      set => this[this.tabletblCompanyLocations.LocationNameColumn] = (object) value;
    }
  }

  public class tblCompaniesRow : DataRow
  {
    private dsProgCodeExt.tblCompaniesDataTable tabletblCompanies;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompaniesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanies = (dsProgCodeExt.tblCompaniesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyGUID
    {
      get => (Guid) this[this.tabletblCompanies.CompanyGUIDColumn];
      set => this[this.tabletblCompanies.CompanyGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CompanyName
    {
      get
      {
        try
        {
          return (string) this[this.tabletblCompanies.CompanyNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CompanyName' in table 'tblCompanies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanies.CompanyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyNameNull() => this.IsNull(this.tabletblCompanies.CompanyNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyNameNull()
    {
      this[this.tabletblCompanies.CompanyNameColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class Fortegra_tblCompanyProgramCodesRowChangeEvent : EventArgs
  {
    private dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Fortegra_tblCompanyProgramCodesRowChangeEvent(
      dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.Fortegra_tblCompanyProgramCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class Fortegra_tblCompanyProgramParticpationRowChangeEvent : EventArgs
  {
    private dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Fortegra_tblCompanyProgramParticpationRowChangeEvent(
      dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompanyLocationsRowChangeEvent : EventArgs
  {
    private dsProgCodeExt.tblCompanyLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyLocationsRowChangeEvent(
      dsProgCodeExt.tblCompanyLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.tblCompanyLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompaniesRowChangeEvent : EventArgs
  {
    private dsProgCodeExt.tblCompaniesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompaniesRowChangeEvent(dsProgCodeExt.tblCompaniesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsProgCodeExt.tblCompaniesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
