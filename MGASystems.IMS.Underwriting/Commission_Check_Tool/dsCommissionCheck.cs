// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Commission_Check_Tool.dsCommissionCheck
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

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
namespace MGASystems.IMS.Underwriting.Commission_Check_Tool;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCommissionCheck")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCommissionCheck : DataSet
{
  private dsCommissionCheck.tblProducerLocationsDataTable tabletblProducerLocations;
  private dsCommissionCheck.lstStatesDataTable tablelstStates;
  private dsCommissionCheck.tblClientOfficesDataTable tabletblClientOffices;
  private dsCommissionCheck.tblCompanyLinesDataTable tabletblCompanyLines;
  private dsCommissionCheck.tblCompanyLineTermsOfPaymentDataTable tabletblCompanyLineTermsOfPayment;
  private dsCommissionCheck.tblCompanyProgramCodesDataTable tabletblCompanyProgramCodes;
  private dsCommissionCheck.lstPolicyTypesDataTable tablelstPolicyTypes;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsCommissionCheck()
  {
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected dsCommissionCheck(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblProducerLocations)] != null)
          base.Tables.Add((DataTable) new dsCommissionCheck.tblProducerLocationsDataTable(dataSet.Tables[nameof (tblProducerLocations)]));
        if (dataSet.Tables[nameof (lstStates)] != null)
          base.Tables.Add((DataTable) new dsCommissionCheck.lstStatesDataTable(dataSet.Tables[nameof (lstStates)]));
        if (dataSet.Tables[nameof (tblClientOffices)] != null)
          base.Tables.Add((DataTable) new dsCommissionCheck.tblClientOfficesDataTable(dataSet.Tables[nameof (tblClientOffices)]));
        if (dataSet.Tables[nameof (tblCompanyLines)] != null)
          base.Tables.Add((DataTable) new dsCommissionCheck.tblCompanyLinesDataTable(dataSet.Tables[nameof (tblCompanyLines)]));
        if (dataSet.Tables[nameof (tblCompanyLineTermsOfPayment)] != null)
          base.Tables.Add((DataTable) new dsCommissionCheck.tblCompanyLineTermsOfPaymentDataTable(dataSet.Tables[nameof (tblCompanyLineTermsOfPayment)]));
        if (dataSet.Tables[nameof (tblCompanyProgramCodes)] != null)
          base.Tables.Add((DataTable) new dsCommissionCheck.tblCompanyProgramCodesDataTable(dataSet.Tables[nameof (tblCompanyProgramCodes)]));
        if (dataSet.Tables[nameof (lstPolicyTypes)] != null)
          base.Tables.Add((DataTable) new dsCommissionCheck.lstPolicyTypesDataTable(dataSet.Tables[nameof (lstPolicyTypes)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCommissionCheck.tblProducerLocationsDataTable tblProducerLocations
  {
    get => this.tabletblProducerLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCommissionCheck.lstStatesDataTable lstStates => this.tablelstStates;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCommissionCheck.tblClientOfficesDataTable tblClientOffices => this.tabletblClientOffices;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCommissionCheck.tblCompanyLinesDataTable tblCompanyLines => this.tabletblCompanyLines;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCommissionCheck.tblCompanyLineTermsOfPaymentDataTable tblCompanyLineTermsOfPayment
  {
    get => this.tabletblCompanyLineTermsOfPayment;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCommissionCheck.tblCompanyProgramCodesDataTable tblCompanyProgramCodes
  {
    get => this.tabletblCompanyProgramCodes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCommissionCheck.lstPolicyTypesDataTable lstPolicyTypes => this.tablelstPolicyTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public override DataSet Clone()
  {
    dsCommissionCheck dsCommissionCheck = (dsCommissionCheck) base.Clone();
    dsCommissionCheck.InitVars();
    dsCommissionCheck.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsCommissionCheck;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["tblProducerLocations"] != null)
        base.Tables.Add((DataTable) new dsCommissionCheck.tblProducerLocationsDataTable(dataSet.Tables["tblProducerLocations"]));
      if (dataSet.Tables["lstStates"] != null)
        base.Tables.Add((DataTable) new dsCommissionCheck.lstStatesDataTable(dataSet.Tables["lstStates"]));
      if (dataSet.Tables["tblClientOffices"] != null)
        base.Tables.Add((DataTable) new dsCommissionCheck.tblClientOfficesDataTable(dataSet.Tables["tblClientOffices"]));
      if (dataSet.Tables["tblCompanyLines"] != null)
        base.Tables.Add((DataTable) new dsCommissionCheck.tblCompanyLinesDataTable(dataSet.Tables["tblCompanyLines"]));
      if (dataSet.Tables["tblCompanyLineTermsOfPayment"] != null)
        base.Tables.Add((DataTable) new dsCommissionCheck.tblCompanyLineTermsOfPaymentDataTable(dataSet.Tables["tblCompanyLineTermsOfPayment"]));
      if (dataSet.Tables["tblCompanyProgramCodes"] != null)
        base.Tables.Add((DataTable) new dsCommissionCheck.tblCompanyProgramCodesDataTable(dataSet.Tables["tblCompanyProgramCodes"]));
      if (dataSet.Tables["lstPolicyTypes"] != null)
        base.Tables.Add((DataTable) new dsCommissionCheck.lstPolicyTypesDataTable(dataSet.Tables["lstPolicyTypes"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tabletblProducerLocations = (dsCommissionCheck.tblProducerLocationsDataTable) base.Tables["tblProducerLocations"];
    if (initTable && this.tabletblProducerLocations != null)
      this.tabletblProducerLocations.InitVars();
    this.tablelstStates = (dsCommissionCheck.lstStatesDataTable) base.Tables["lstStates"];
    if (initTable && this.tablelstStates != null)
      this.tablelstStates.InitVars();
    this.tabletblClientOffices = (dsCommissionCheck.tblClientOfficesDataTable) base.Tables["tblClientOffices"];
    if (initTable && this.tabletblClientOffices != null)
      this.tabletblClientOffices.InitVars();
    this.tabletblCompanyLines = (dsCommissionCheck.tblCompanyLinesDataTable) base.Tables["tblCompanyLines"];
    if (initTable && this.tabletblCompanyLines != null)
      this.tabletblCompanyLines.InitVars();
    this.tabletblCompanyLineTermsOfPayment = (dsCommissionCheck.tblCompanyLineTermsOfPaymentDataTable) base.Tables["tblCompanyLineTermsOfPayment"];
    if (initTable && this.tabletblCompanyLineTermsOfPayment != null)
      this.tabletblCompanyLineTermsOfPayment.InitVars();
    this.tabletblCompanyProgramCodes = (dsCommissionCheck.tblCompanyProgramCodesDataTable) base.Tables["tblCompanyProgramCodes"];
    if (initTable && this.tabletblCompanyProgramCodes != null)
      this.tabletblCompanyProgramCodes.InitVars();
    this.tablelstPolicyTypes = (dsCommissionCheck.lstPolicyTypesDataTable) base.Tables["lstPolicyTypes"];
    if (!initTable || this.tablelstPolicyTypes == null)
      return;
    this.tablelstPolicyTypes.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCommissionCheck);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsCommissionCheck.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblProducerLocations = new dsCommissionCheck.tblProducerLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerLocations);
    this.tablelstStates = new dsCommissionCheck.lstStatesDataTable();
    base.Tables.Add((DataTable) this.tablelstStates);
    this.tabletblClientOffices = new dsCommissionCheck.tblClientOfficesDataTable();
    base.Tables.Add((DataTable) this.tabletblClientOffices);
    this.tabletblCompanyLines = new dsCommissionCheck.tblCompanyLinesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLines);
    this.tabletblCompanyLineTermsOfPayment = new dsCommissionCheck.tblCompanyLineTermsOfPaymentDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLineTermsOfPayment);
    this.tabletblCompanyProgramCodes = new dsCommissionCheck.tblCompanyProgramCodesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyProgramCodes);
    this.tablelstPolicyTypes = new dsCommissionCheck.lstPolicyTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstPolicyTypes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblProducerLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstStates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblClientOffices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyLines() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyLineTermsOfPayment() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyProgramCodes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstPolicyTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsCommissionCheck dsCommissionCheck = new dsCommissionCheck();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = dsCommissionCheck.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = dsCommissionCheck.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblProducerLocationsRowChangeEventHandler(
    object sender,
    dsCommissionCheck.tblProducerLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstStatesRowChangeEventHandler(
    object sender,
    dsCommissionCheck.lstStatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblClientOfficesRowChangeEventHandler(
    object sender,
    dsCommissionCheck.tblClientOfficesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyLinesRowChangeEventHandler(
    object sender,
    dsCommissionCheck.tblCompanyLinesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyLineTermsOfPaymentRowChangeEventHandler(
    object sender,
    dsCommissionCheck.tblCompanyLineTermsOfPaymentRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyProgramCodesRowChangeEventHandler(
    object sender,
    dsCommissionCheck.tblCompanyProgramCodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstPolicyTypesRowChangeEventHandler(
    object sender,
    dsCommissionCheck.lstPolicyTypesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblProducerLocationsDataTable : 
    TypedTableBase<dsCommissionCheck.tblProducerLocationsRow>
  {
    private DataColumn columnProducerLocationGUID;
    private DataColumn columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblProducerLocationsDataTable()
    {
      this.TableName = "tblProducerLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblProducerLocationsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblProducerLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerLocationGUIDColumn => this.columnProducerLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblProducerLocationsRow this[int index]
    {
      get => (dsCommissionCheck.tblProducerLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblProducerLocationsRow(dsCommissionCheck.tblProducerLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblProducerLocationsRow AddtblProducerLocationsRow(
      Guid ProducerLocationGUID,
      string Location)
    {
      dsCommissionCheck.tblProducerLocationsRow row = (dsCommissionCheck.tblProducerLocationsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ProducerLocationGUID,
        (object) Location
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblProducerLocationsRow FindByProducerLocationGUID(
      Guid ProducerLocationGUID)
    {
      return (dsCommissionCheck.tblProducerLocationsRow) this.Rows.Find(new object[1]
      {
        (object) ProducerLocationGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCommissionCheck.tblProducerLocationsDataTable locationsDataTable = (dsCommissionCheck.tblProducerLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCommissionCheck.tblProducerLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerLocationGUID = this.Columns["ProducerLocationGUID"];
      this.columnLocation = this.Columns["Location"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnProducerLocationGUID = new DataColumn("ProducerLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGUID);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnProducerLocationGUID
      }, true));
      this.columnProducerLocationGUID.AllowDBNull = false;
      this.columnProducerLocationGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblProducerLocationsRow NewtblProducerLocationsRow()
    {
      return (dsCommissionCheck.tblProducerLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCommissionCheck.tblProducerLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCommissionCheck.tblProducerLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.tblProducerLocationsRowChanged == null)
        return;
      this.tblProducerLocationsRowChanged((object) this, new dsCommissionCheck.tblProducerLocationsRowChangeEvent((dsCommissionCheck.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.tblProducerLocationsRowChanging == null)
        return;
      this.tblProducerLocationsRowChanging((object) this, new dsCommissionCheck.tblProducerLocationsRowChangeEvent((dsCommissionCheck.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.tblProducerLocationsRowDeleted == null)
        return;
      this.tblProducerLocationsRowDeleted((object) this, new dsCommissionCheck.tblProducerLocationsRowChangeEvent((dsCommissionCheck.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.tblProducerLocationsRowDeleting == null)
        return;
      this.tblProducerLocationsRowDeleting((object) this, new dsCommissionCheck.tblProducerLocationsRowChangeEvent((dsCommissionCheck.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblProducerLocationsRow(dsCommissionCheck.tblProducerLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCommissionCheck dsCommissionCheck = new dsCommissionCheck();
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
        FixedValue = dsCommissionCheck.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerLocationsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCommissionCheck.GetSchemaSerializable();
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
  public class lstStatesDataTable : TypedTableBase<dsCommissionCheck.lstStatesRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstStatesDataTable()
    {
      this.TableName = "lstStates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstStatesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstStatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.lstStatesRow this[int index]
    {
      get => (dsCommissionCheck.lstStatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.lstStatesRowChangeEventHandler lstStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.lstStatesRowChangeEventHandler lstStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.lstStatesRowChangeEventHandler lstStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.lstStatesRowChangeEventHandler lstStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstStatesRow(dsCommissionCheck.lstStatesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.lstStatesRow AddlstStatesRow(string StateID, string State)
    {
      dsCommissionCheck.lstStatesRow row = (dsCommissionCheck.lstStatesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) StateID,
        (object) State
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.lstStatesRow FindByStateID(string StateID)
    {
      return (dsCommissionCheck.lstStatesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCommissionCheck.lstStatesDataTable lstStatesDataTable = (dsCommissionCheck.lstStatesDataTable) base.Clone();
      lstStatesDataTable.InitVars();
      return (DataTable) lstStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCommissionCheck.lstStatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnState = this.Columns["State"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnStateID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.Unique = true;
      this.columnStateID.MaxLength = 2;
      this.columnState.AllowDBNull = false;
      this.columnState.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.lstStatesRow NewlstStatesRow()
    {
      return (dsCommissionCheck.lstStatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCommissionCheck.lstStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCommissionCheck.lstStatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.lstStatesRowChanged == null)
        return;
      this.lstStatesRowChanged((object) this, new dsCommissionCheck.lstStatesRowChangeEvent((dsCommissionCheck.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.lstStatesRowChanging == null)
        return;
      this.lstStatesRowChanging((object) this, new dsCommissionCheck.lstStatesRowChangeEvent((dsCommissionCheck.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.lstStatesRowDeleted == null)
        return;
      this.lstStatesRowDeleted((object) this, new dsCommissionCheck.lstStatesRowChangeEvent((dsCommissionCheck.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.lstStatesRowDeleting == null)
        return;
      this.lstStatesRowDeleting((object) this, new dsCommissionCheck.lstStatesRowChangeEvent((dsCommissionCheck.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstStatesRow(dsCommissionCheck.lstStatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCommissionCheck dsCommissionCheck = new dsCommissionCheck();
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
        FixedValue = dsCommissionCheck.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCommissionCheck.GetSchemaSerializable();
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
  public class tblClientOfficesDataTable : TypedTableBase<dsCommissionCheck.tblClientOfficesRow>
  {
    private DataColumn columnOfficeGUID;
    private DataColumn columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblClientOfficesDataTable()
    {
      this.TableName = "tblClientOffices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblClientOfficesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblClientOfficesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OfficeGUIDColumn => this.columnOfficeGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblClientOfficesRow this[int index]
    {
      get => (dsCommissionCheck.tblClientOfficesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblClientOfficesRow(dsCommissionCheck.tblClientOfficesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblClientOfficesRow AddtblClientOfficesRow(
      Guid OfficeGUID,
      string Location)
    {
      dsCommissionCheck.tblClientOfficesRow row = (dsCommissionCheck.tblClientOfficesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) OfficeGUID,
        (object) Location
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblClientOfficesRow FindByOfficeGUID(Guid OfficeGUID)
    {
      return (dsCommissionCheck.tblClientOfficesRow) this.Rows.Find(new object[1]
      {
        (object) OfficeGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCommissionCheck.tblClientOfficesDataTable officesDataTable = (dsCommissionCheck.tblClientOfficesDataTable) base.Clone();
      officesDataTable.InitVars();
      return (DataTable) officesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCommissionCheck.tblClientOfficesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnOfficeGUID = this.Columns["OfficeGUID"];
      this.columnLocation = this.Columns["Location"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnOfficeGUID = new DataColumn("OfficeGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeGUID);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnOfficeGUID
      }, true));
      this.columnOfficeGUID.AllowDBNull = false;
      this.columnOfficeGUID.Unique = true;
      this.columnLocation.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblClientOfficesRow NewtblClientOfficesRow()
    {
      return (dsCommissionCheck.tblClientOfficesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCommissionCheck.tblClientOfficesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCommissionCheck.tblClientOfficesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.tblClientOfficesRowChanged == null)
        return;
      this.tblClientOfficesRowChanged((object) this, new dsCommissionCheck.tblClientOfficesRowChangeEvent((dsCommissionCheck.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.tblClientOfficesRowChanging == null)
        return;
      this.tblClientOfficesRowChanging((object) this, new dsCommissionCheck.tblClientOfficesRowChangeEvent((dsCommissionCheck.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.tblClientOfficesRowDeleted == null)
        return;
      this.tblClientOfficesRowDeleted((object) this, new dsCommissionCheck.tblClientOfficesRowChangeEvent((dsCommissionCheck.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.tblClientOfficesRowDeleting == null)
        return;
      this.tblClientOfficesRowDeleting((object) this, new dsCommissionCheck.tblClientOfficesRowChangeEvent((dsCommissionCheck.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblClientOfficesRow(dsCommissionCheck.tblClientOfficesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCommissionCheck dsCommissionCheck = new dsCommissionCheck();
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
        FixedValue = dsCommissionCheck.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClientOfficesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCommissionCheck.GetSchemaSerializable();
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
  public class tblCompanyLinesDataTable : TypedTableBase<dsCommissionCheck.tblCompanyLinesRow>
  {
    private DataColumn columnCompanyLineGUID;
    private DataColumn columnCompanyLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyLinesDataTable()
    {
      this.TableName = "tblCompanyLines";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyLinesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblCompanyLinesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineGUIDColumn => this.columnCompanyLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineColumn => this.columnCompanyLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblCompanyLinesRow this[int index]
    {
      get => (dsCommissionCheck.tblCompanyLinesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyLinesRow(dsCommissionCheck.tblCompanyLinesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblCompanyLinesRow AddtblCompanyLinesRow(
      Guid CompanyLineGUID,
      string CompanyLine)
    {
      dsCommissionCheck.tblCompanyLinesRow row = (dsCommissionCheck.tblCompanyLinesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyLineGUID,
        (object) CompanyLine
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCommissionCheck.tblCompanyLinesDataTable companyLinesDataTable = (dsCommissionCheck.tblCompanyLinesDataTable) base.Clone();
      companyLinesDataTable.InitVars();
      return (DataTable) companyLinesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCommissionCheck.tblCompanyLinesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLineGUID = this.Columns["CompanyLineGUID"];
      this.columnCompanyLine = this.Columns["CompanyLine"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLineGUID = new DataColumn("CompanyLineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGUID);
      this.columnCompanyLine = new DataColumn("CompanyLine", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLine);
      this.columnCompanyLineGUID.AllowDBNull = false;
      this.columnCompanyLine.ReadOnly = true;
      this.columnCompanyLine.MaxLength = 500;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblCompanyLinesRow NewtblCompanyLinesRow()
    {
      return (dsCommissionCheck.tblCompanyLinesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCommissionCheck.tblCompanyLinesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCommissionCheck.tblCompanyLinesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.tblCompanyLinesRowChanged == null)
        return;
      this.tblCompanyLinesRowChanged((object) this, new dsCommissionCheck.tblCompanyLinesRowChangeEvent((dsCommissionCheck.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.tblCompanyLinesRowChanging == null)
        return;
      this.tblCompanyLinesRowChanging((object) this, new dsCommissionCheck.tblCompanyLinesRowChangeEvent((dsCommissionCheck.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.tblCompanyLinesRowDeleted == null)
        return;
      this.tblCompanyLinesRowDeleted((object) this, new dsCommissionCheck.tblCompanyLinesRowChangeEvent((dsCommissionCheck.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.tblCompanyLinesRowDeleting == null)
        return;
      this.tblCompanyLinesRowDeleting((object) this, new dsCommissionCheck.tblCompanyLinesRowChangeEvent((dsCommissionCheck.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyLinesRow(dsCommissionCheck.tblCompanyLinesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCommissionCheck dsCommissionCheck = new dsCommissionCheck();
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
        FixedValue = dsCommissionCheck.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLinesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCommissionCheck.GetSchemaSerializable();
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
  public class tblCompanyLineTermsOfPaymentDataTable : 
    TypedTableBase<dsCommissionCheck.tblCompanyLineTermsOfPaymentRow>
  {
    private DataColumn columnCompanyLineID;
    private DataColumn columnTermsOfPayment;
    private DataColumn columnPaymentMethod;
    private DataColumn columnProducerPaymentMeasuredFrom;
    private DataColumn columnProducerPaymentDayOfMonth;
    private DataColumn columnDefaultProducerTermsOfPayment;
    private DataColumn columnCreditsTakenImmediatly;
    private DataColumn columnAcctCurrent;
    private DataColumn columnProducerPaymentMeasuredFrom_Endorsement;
    private DataColumn columnProducerPaymentDayOfMonth_Endorsement;
    private DataColumn columnDefaultProducerTermsOfPayment_Endorsement;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyLineTermsOfPaymentDataTable()
    {
      this.TableName = "tblCompanyLineTermsOfPayment";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyLineTermsOfPaymentDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblCompanyLineTermsOfPaymentDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineIDColumn => this.columnCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TermsOfPaymentColumn => this.columnTermsOfPayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PaymentMethodColumn => this.columnPaymentMethod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerPaymentMeasuredFromColumn => this.columnProducerPaymentMeasuredFrom;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerPaymentDayOfMonthColumn => this.columnProducerPaymentDayOfMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DefaultProducerTermsOfPaymentColumn
    {
      get => this.columnDefaultProducerTermsOfPayment;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CreditsTakenImmediatlyColumn => this.columnCreditsTakenImmediatly;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AcctCurrentColumn => this.columnAcctCurrent;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerPaymentMeasuredFrom_EndorsementColumn
    {
      get => this.columnProducerPaymentMeasuredFrom_Endorsement;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerPaymentDayOfMonth_EndorsementColumn
    {
      get => this.columnProducerPaymentDayOfMonth_Endorsement;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DefaultProducerTermsOfPayment_EndorsementColumn
    {
      get => this.columnDefaultProducerTermsOfPayment_Endorsement;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblCompanyLineTermsOfPaymentRow this[int index]
    {
      get => (dsCommissionCheck.tblCompanyLineTermsOfPaymentRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblCompanyLineTermsOfPaymentRowChangeEventHandler tblCompanyLineTermsOfPaymentRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblCompanyLineTermsOfPaymentRowChangeEventHandler tblCompanyLineTermsOfPaymentRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblCompanyLineTermsOfPaymentRowChangeEventHandler tblCompanyLineTermsOfPaymentRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblCompanyLineTermsOfPaymentRowChangeEventHandler tblCompanyLineTermsOfPaymentRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyLineTermsOfPaymentRow(
      dsCommissionCheck.tblCompanyLineTermsOfPaymentRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblCompanyLineTermsOfPaymentRow AddtblCompanyLineTermsOfPaymentRow(
      int CompanyLineID,
      short TermsOfPayment,
      string PaymentMethod,
      string ProducerPaymentMeasuredFrom,
      byte ProducerPaymentDayOfMonth,
      short DefaultProducerTermsOfPayment,
      bool CreditsTakenImmediatly,
      bool AcctCurrent,
      string ProducerPaymentMeasuredFrom_Endorsement,
      byte ProducerPaymentDayOfMonth_Endorsement,
      short DefaultProducerTermsOfPayment_Endorsement)
    {
      dsCommissionCheck.tblCompanyLineTermsOfPaymentRow row = (dsCommissionCheck.tblCompanyLineTermsOfPaymentRow) this.NewRow();
      object[] objArray = new object[11]
      {
        (object) CompanyLineID,
        (object) TermsOfPayment,
        (object) PaymentMethod,
        (object) ProducerPaymentMeasuredFrom,
        (object) ProducerPaymentDayOfMonth,
        (object) DefaultProducerTermsOfPayment,
        (object) CreditsTakenImmediatly,
        (object) AcctCurrent,
        (object) ProducerPaymentMeasuredFrom_Endorsement,
        (object) ProducerPaymentDayOfMonth_Endorsement,
        (object) DefaultProducerTermsOfPayment_Endorsement
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCommissionCheck.tblCompanyLineTermsOfPaymentDataTable paymentDataTable = (dsCommissionCheck.tblCompanyLineTermsOfPaymentDataTable) base.Clone();
      paymentDataTable.InitVars();
      return (DataTable) paymentDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCommissionCheck.tblCompanyLineTermsOfPaymentDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLineID = this.Columns["CompanyLineID"];
      this.columnTermsOfPayment = this.Columns["TermsOfPayment"];
      this.columnPaymentMethod = this.Columns["PaymentMethod"];
      this.columnProducerPaymentMeasuredFrom = this.Columns["ProducerPaymentMeasuredFrom"];
      this.columnProducerPaymentDayOfMonth = this.Columns["ProducerPaymentDayOfMonth"];
      this.columnDefaultProducerTermsOfPayment = this.Columns["DefaultProducerTermsOfPayment"];
      this.columnCreditsTakenImmediatly = this.Columns["CreditsTakenImmediatly"];
      this.columnAcctCurrent = this.Columns["AcctCurrent"];
      this.columnProducerPaymentMeasuredFrom_Endorsement = this.Columns["ProducerPaymentMeasuredFrom_Endorsement"];
      this.columnProducerPaymentDayOfMonth_Endorsement = this.Columns["ProducerPaymentDayOfMonth_Endorsement"];
      this.columnDefaultProducerTermsOfPayment_Endorsement = this.Columns["DefaultProducerTermsOfPayment_Endorsement"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLineID = new DataColumn("CompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineID);
      this.columnTermsOfPayment = new DataColumn("TermsOfPayment", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTermsOfPayment);
      this.columnPaymentMethod = new DataColumn("PaymentMethod", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPaymentMethod);
      this.columnProducerPaymentMeasuredFrom = new DataColumn("ProducerPaymentMeasuredFrom", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerPaymentMeasuredFrom);
      this.columnProducerPaymentDayOfMonth = new DataColumn("ProducerPaymentDayOfMonth", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerPaymentDayOfMonth);
      this.columnDefaultProducerTermsOfPayment = new DataColumn("DefaultProducerTermsOfPayment", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultProducerTermsOfPayment);
      this.columnCreditsTakenImmediatly = new DataColumn("CreditsTakenImmediatly", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCreditsTakenImmediatly);
      this.columnAcctCurrent = new DataColumn("AcctCurrent", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAcctCurrent);
      this.columnProducerPaymentMeasuredFrom_Endorsement = new DataColumn("ProducerPaymentMeasuredFrom_Endorsement", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerPaymentMeasuredFrom_Endorsement);
      this.columnProducerPaymentDayOfMonth_Endorsement = new DataColumn("ProducerPaymentDayOfMonth_Endorsement", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerPaymentDayOfMonth_Endorsement);
      this.columnDefaultProducerTermsOfPayment_Endorsement = new DataColumn("DefaultProducerTermsOfPayment_Endorsement", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultProducerTermsOfPayment_Endorsement);
      this.columnCompanyLineID.AllowDBNull = false;
      this.columnTermsOfPayment.AllowDBNull = false;
      this.columnProducerPaymentMeasuredFrom.MaxLength = 1;
      this.columnProducerPaymentMeasuredFrom_Endorsement.MaxLength = 1;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblCompanyLineTermsOfPaymentRow NewtblCompanyLineTermsOfPaymentRow()
    {
      return (dsCommissionCheck.tblCompanyLineTermsOfPaymentRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCommissionCheck.tblCompanyLineTermsOfPaymentRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCommissionCheck.tblCompanyLineTermsOfPaymentRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.tblCompanyLineTermsOfPaymentRowChanged == null)
        return;
      this.tblCompanyLineTermsOfPaymentRowChanged((object) this, new dsCommissionCheck.tblCompanyLineTermsOfPaymentRowChangeEvent((dsCommissionCheck.tblCompanyLineTermsOfPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.tblCompanyLineTermsOfPaymentRowChanging == null)
        return;
      this.tblCompanyLineTermsOfPaymentRowChanging((object) this, new dsCommissionCheck.tblCompanyLineTermsOfPaymentRowChangeEvent((dsCommissionCheck.tblCompanyLineTermsOfPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.tblCompanyLineTermsOfPaymentRowDeleted == null)
        return;
      this.tblCompanyLineTermsOfPaymentRowDeleted((object) this, new dsCommissionCheck.tblCompanyLineTermsOfPaymentRowChangeEvent((dsCommissionCheck.tblCompanyLineTermsOfPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.tblCompanyLineTermsOfPaymentRowDeleting == null)
        return;
      this.tblCompanyLineTermsOfPaymentRowDeleting((object) this, new dsCommissionCheck.tblCompanyLineTermsOfPaymentRowChangeEvent((dsCommissionCheck.tblCompanyLineTermsOfPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyLineTermsOfPaymentRow(
      dsCommissionCheck.tblCompanyLineTermsOfPaymentRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCommissionCheck dsCommissionCheck = new dsCommissionCheck();
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
        FixedValue = dsCommissionCheck.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLineTermsOfPaymentDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCommissionCheck.GetSchemaSerializable();
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
  public class tblCompanyProgramCodesDataTable : 
    TypedTableBase<dsCommissionCheck.tblCompanyProgramCodesRow>
  {
    private DataColumn columnProgramID;
    private DataColumn columnProgCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyProgramCodesDataTable()
    {
      this.TableName = "tblCompanyProgramCodes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyProgramCodesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblCompanyProgramCodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProgramIDColumn => this.columnProgramID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProgCodeColumn => this.columnProgCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblCompanyProgramCodesRow this[int index]
    {
      get => (dsCommissionCheck.tblCompanyProgramCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyProgramCodesRow(dsCommissionCheck.tblCompanyProgramCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblCompanyProgramCodesRow AddtblCompanyProgramCodesRow(
      int ProgramID,
      string ProgCode)
    {
      dsCommissionCheck.tblCompanyProgramCodesRow row = (dsCommissionCheck.tblCompanyProgramCodesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ProgramID,
        (object) ProgCode
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblCompanyProgramCodesRow FindByProgramID(int ProgramID)
    {
      return (dsCommissionCheck.tblCompanyProgramCodesRow) this.Rows.Find(new object[1]
      {
        (object) ProgramID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCommissionCheck.tblCompanyProgramCodesDataTable programCodesDataTable = (dsCommissionCheck.tblCompanyProgramCodesDataTable) base.Clone();
      programCodesDataTable.InitVars();
      return (DataTable) programCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCommissionCheck.tblCompanyProgramCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnProgramID = this.Columns["ProgramID"];
      this.columnProgCode = this.Columns["ProgCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnProgramID = new DataColumn("ProgramID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgramID);
      this.columnProgCode = new DataColumn("ProgCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgCode);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnProgramID
      }, true));
      this.columnProgramID.AllowDBNull = false;
      this.columnProgramID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblCompanyProgramCodesRow NewtblCompanyProgramCodesRow()
    {
      return (dsCommissionCheck.tblCompanyProgramCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCommissionCheck.tblCompanyProgramCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCommissionCheck.tblCompanyProgramCodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.tblCompanyProgramCodesRowChanged == null)
        return;
      this.tblCompanyProgramCodesRowChanged((object) this, new dsCommissionCheck.tblCompanyProgramCodesRowChangeEvent((dsCommissionCheck.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.tblCompanyProgramCodesRowChanging == null)
        return;
      this.tblCompanyProgramCodesRowChanging((object) this, new dsCommissionCheck.tblCompanyProgramCodesRowChangeEvent((dsCommissionCheck.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.tblCompanyProgramCodesRowDeleted == null)
        return;
      this.tblCompanyProgramCodesRowDeleted((object) this, new dsCommissionCheck.tblCompanyProgramCodesRowChangeEvent((dsCommissionCheck.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.tblCompanyProgramCodesRowDeleting == null)
        return;
      this.tblCompanyProgramCodesRowDeleting((object) this, new dsCommissionCheck.tblCompanyProgramCodesRowChangeEvent((dsCommissionCheck.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyProgramCodesRow(dsCommissionCheck.tblCompanyProgramCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCommissionCheck dsCommissionCheck = new dsCommissionCheck();
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
        FixedValue = dsCommissionCheck.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyProgramCodesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCommissionCheck.GetSchemaSerializable();
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
  public class lstPolicyTypesDataTable : TypedTableBase<dsCommissionCheck.lstPolicyTypesRow>
  {
    private DataColumn columnPolicyTypeID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstPolicyTypesDataTable()
    {
      this.TableName = "lstPolicyTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstPolicyTypesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstPolicyTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyTypeIDColumn => this.columnPolicyTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.lstPolicyTypesRow this[int index]
    {
      get => (dsCommissionCheck.lstPolicyTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCommissionCheck.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstPolicyTypesRow(dsCommissionCheck.lstPolicyTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.lstPolicyTypesRow AddlstPolicyTypesRow(
      int PolicyTypeID,
      string Description)
    {
      dsCommissionCheck.lstPolicyTypesRow row = (dsCommissionCheck.lstPolicyTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) PolicyTypeID,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCommissionCheck.lstPolicyTypesDataTable policyTypesDataTable = (dsCommissionCheck.lstPolicyTypesDataTable) base.Clone();
      policyTypesDataTable.InitVars();
      return (DataTable) policyTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCommissionCheck.lstPolicyTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnPolicyTypeID = this.Columns["PolicyTypeID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnPolicyTypeID = new DataColumn("PolicyTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyTypeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.lstPolicyTypesRow NewlstPolicyTypesRow()
    {
      return (dsCommissionCheck.lstPolicyTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCommissionCheck.lstPolicyTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCommissionCheck.lstPolicyTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.lstPolicyTypesRowChanged == null)
        return;
      this.lstPolicyTypesRowChanged((object) this, new dsCommissionCheck.lstPolicyTypesRowChangeEvent((dsCommissionCheck.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.lstPolicyTypesRowChanging == null)
        return;
      this.lstPolicyTypesRowChanging((object) this, new dsCommissionCheck.lstPolicyTypesRowChangeEvent((dsCommissionCheck.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.lstPolicyTypesRowDeleted == null)
        return;
      this.lstPolicyTypesRowDeleted((object) this, new dsCommissionCheck.lstPolicyTypesRowChangeEvent((dsCommissionCheck.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.lstPolicyTypesRowDeleting == null)
        return;
      this.lstPolicyTypesRowDeleting((object) this, new dsCommissionCheck.lstPolicyTypesRowChangeEvent((dsCommissionCheck.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstPolicyTypesRow(dsCommissionCheck.lstPolicyTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCommissionCheck dsCommissionCheck = new dsCommissionCheck();
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
        FixedValue = dsCommissionCheck.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPolicyTypesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCommissionCheck.GetSchemaSerializable();
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

  public class tblProducerLocationsRow : DataRow
  {
    private dsCommissionCheck.tblProducerLocationsDataTable tabletblProducerLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblProducerLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerLocations = (dsCommissionCheck.tblProducerLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ProducerLocationGUID
    {
      get => (Guid) this[this.tabletblProducerLocations.ProducerLocationGUIDColumn];
      set => this[this.tabletblProducerLocations.ProducerLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Location
    {
      get
      {
        try
        {
          return (string) this[this.tabletblProducerLocations.LocationColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Location' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.LocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationNull() => this.IsNull(this.tabletblProducerLocations.LocationColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationNull()
    {
      this[this.tabletblProducerLocations.LocationColumn] = Convert.DBNull;
    }
  }

  public class lstStatesRow : DataRow
  {
    private dsCommissionCheck.lstStatesDataTable tablelstStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStates = (dsCommissionCheck.lstStatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get => (string) this[this.tablelstStates.StateIDColumn];
      set => this[this.tablelstStates.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string State
    {
      get => (string) this[this.tablelstStates.StateColumn];
      set => this[this.tablelstStates.StateColumn] = (object) value;
    }
  }

  public class tblClientOfficesRow : DataRow
  {
    private dsCommissionCheck.tblClientOfficesDataTable tabletblClientOffices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblClientOfficesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClientOffices = (dsCommissionCheck.tblClientOfficesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid OfficeGUID
    {
      get => (Guid) this[this.tabletblClientOffices.OfficeGUIDColumn];
      set => this[this.tabletblClientOffices.OfficeGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Location
    {
      get => (string) this[this.tabletblClientOffices.LocationColumn];
      set => this[this.tabletblClientOffices.LocationColumn] = (object) value;
    }
  }

  public class tblCompanyLinesRow : DataRow
  {
    private dsCommissionCheck.tblCompanyLinesDataTable tabletblCompanyLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLines = (dsCommissionCheck.tblCompanyLinesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLineGUID
    {
      get => (Guid) this[this.tabletblCompanyLines.CompanyLineGUIDColumn];
      set => this[this.tabletblCompanyLines.CompanyLineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CompanyLine
    {
      get
      {
        try
        {
          return (string) this[this.tabletblCompanyLines.CompanyLineColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CompanyLine' in table 'tblCompanyLines' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLines.CompanyLineColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyLineNull() => this.IsNull(this.tabletblCompanyLines.CompanyLineColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyLineNull()
    {
      this[this.tabletblCompanyLines.CompanyLineColumn] = Convert.DBNull;
    }
  }

  public class tblCompanyLineTermsOfPaymentRow : DataRow
  {
    private dsCommissionCheck.tblCompanyLineTermsOfPaymentDataTable tabletblCompanyLineTermsOfPayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyLineTermsOfPaymentRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLineTermsOfPayment = (dsCommissionCheck.tblCompanyLineTermsOfPaymentDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CompanyLineID
    {
      get => (int) this[this.tabletblCompanyLineTermsOfPayment.CompanyLineIDColumn];
      set => this[this.tabletblCompanyLineTermsOfPayment.CompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public short TermsOfPayment
    {
      get => (short) this[this.tabletblCompanyLineTermsOfPayment.TermsOfPaymentColumn];
      set => this[this.tabletblCompanyLineTermsOfPayment.TermsOfPaymentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PaymentMethod
    {
      get
      {
        try
        {
          return (string) this[this.tabletblCompanyLineTermsOfPayment.PaymentMethodColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PaymentMethod' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineTermsOfPayment.PaymentMethodColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProducerPaymentMeasuredFrom
    {
      get
      {
        try
        {
          return (string) this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentMeasuredFromColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ProducerPaymentMeasuredFrom' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentMeasuredFromColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public byte ProducerPaymentDayOfMonth
    {
      get
      {
        try
        {
          return (byte) this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonthColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ProducerPaymentDayOfMonth' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonthColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public short DefaultProducerTermsOfPayment
    {
      get
      {
        try
        {
          return (short) this[this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPaymentColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'DefaultProducerTermsOfPayment' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPaymentColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool CreditsTakenImmediatly
    {
      get
      {
        try
        {
          return (bool) this[this.tabletblCompanyLineTermsOfPayment.CreditsTakenImmediatlyColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CreditsTakenImmediatly' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineTermsOfPayment.CreditsTakenImmediatlyColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool AcctCurrent
    {
      get
      {
        try
        {
          return (bool) this[this.tabletblCompanyLineTermsOfPayment.AcctCurrentColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AcctCurrent' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineTermsOfPayment.AcctCurrentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProducerPaymentMeasuredFrom_Endorsement
    {
      get
      {
        try
        {
          return (string) this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentMeasuredFrom_EndorsementColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ProducerPaymentMeasuredFrom_Endorsement' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentMeasuredFrom_EndorsementColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public byte ProducerPaymentDayOfMonth_Endorsement
    {
      get
      {
        try
        {
          return (byte) this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonth_EndorsementColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ProducerPaymentDayOfMonth_Endorsement' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonth_EndorsementColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public short DefaultProducerTermsOfPayment_Endorsement
    {
      get
      {
        try
        {
          return (short) this[this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPayment_EndorsementColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'DefaultProducerTermsOfPayment_Endorsement' in table 'tblCompanyLineTermsOfPayment' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPayment_EndorsementColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPaymentMethodNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.PaymentMethodColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPaymentMethodNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.PaymentMethodColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerPaymentMeasuredFromNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.ProducerPaymentMeasuredFromColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerPaymentMeasuredFromNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentMeasuredFromColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerPaymentDayOfMonthNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonthColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerPaymentDayOfMonthNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonthColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDefaultProducerTermsOfPaymentNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPaymentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDefaultProducerTermsOfPaymentNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPaymentColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCreditsTakenImmediatlyNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.CreditsTakenImmediatlyColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCreditsTakenImmediatlyNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.CreditsTakenImmediatlyColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAcctCurrentNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.AcctCurrentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAcctCurrentNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.AcctCurrentColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerPaymentMeasuredFrom_EndorsementNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.ProducerPaymentMeasuredFrom_EndorsementColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerPaymentMeasuredFrom_EndorsementNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentMeasuredFrom_EndorsementColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerPaymentDayOfMonth_EndorsementNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonth_EndorsementColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerPaymentDayOfMonth_EndorsementNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.ProducerPaymentDayOfMonth_EndorsementColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDefaultProducerTermsOfPayment_EndorsementNull()
    {
      return this.IsNull(this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPayment_EndorsementColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDefaultProducerTermsOfPayment_EndorsementNull()
    {
      this[this.tabletblCompanyLineTermsOfPayment.DefaultProducerTermsOfPayment_EndorsementColumn] = Convert.DBNull;
    }
  }

  public class tblCompanyProgramCodesRow : DataRow
  {
    private dsCommissionCheck.tblCompanyProgramCodesDataTable tabletblCompanyProgramCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyProgramCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyProgramCodes = (dsCommissionCheck.tblCompanyProgramCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ProgramID
    {
      get => (int) this[this.tabletblCompanyProgramCodes.ProgramIDColumn];
      set => this[this.tabletblCompanyProgramCodes.ProgramIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProgCode
    {
      get
      {
        try
        {
          return (string) this[this.tabletblCompanyProgramCodes.ProgCodeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ProgCode' in table 'tblCompanyProgramCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyProgramCodes.ProgCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProgCodeNull() => this.IsNull(this.tabletblCompanyProgramCodes.ProgCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProgCodeNull()
    {
      this[this.tabletblCompanyProgramCodes.ProgCodeColumn] = Convert.DBNull;
    }
  }

  public class lstPolicyTypesRow : DataRow
  {
    private dsCommissionCheck.lstPolicyTypesDataTable tablelstPolicyTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstPolicyTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPolicyTypes = (dsCommissionCheck.lstPolicyTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyTypeID
    {
      get
      {
        try
        {
          return (int) this[this.tablelstPolicyTypes.PolicyTypeIDColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PolicyTypeID' in table 'lstPolicyTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstPolicyTypes.PolicyTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return (string) this[this.tablelstPolicyTypes.DescriptionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Description' in table 'lstPolicyTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstPolicyTypes.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyTypeIDNull() => this.IsNull(this.tablelstPolicyTypes.PolicyTypeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyTypeIDNull()
    {
      this[this.tablelstPolicyTypes.PolicyTypeIDColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tablelstPolicyTypes.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tablelstPolicyTypes.DescriptionColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblProducerLocationsRowChangeEvent : EventArgs
  {
    private dsCommissionCheck.tblProducerLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblProducerLocationsRowChangeEvent(
      dsCommissionCheck.tblProducerLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblProducerLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstStatesRowChangeEvent : EventArgs
  {
    private dsCommissionCheck.lstStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstStatesRowChangeEvent(dsCommissionCheck.lstStatesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.lstStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblClientOfficesRowChangeEvent : EventArgs
  {
    private dsCommissionCheck.tblClientOfficesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblClientOfficesRowChangeEvent(
      dsCommissionCheck.tblClientOfficesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblClientOfficesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyLinesRowChangeEvent : EventArgs
  {
    private dsCommissionCheck.tblCompanyLinesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyLinesRowChangeEvent(
      dsCommissionCheck.tblCompanyLinesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblCompanyLinesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyLineTermsOfPaymentRowChangeEvent : EventArgs
  {
    private dsCommissionCheck.tblCompanyLineTermsOfPaymentRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyLineTermsOfPaymentRowChangeEvent(
      dsCommissionCheck.tblCompanyLineTermsOfPaymentRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblCompanyLineTermsOfPaymentRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyProgramCodesRowChangeEvent : EventArgs
  {
    private dsCommissionCheck.tblCompanyProgramCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyProgramCodesRowChangeEvent(
      dsCommissionCheck.tblCompanyProgramCodesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.tblCompanyProgramCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstPolicyTypesRowChangeEvent : EventArgs
  {
    private dsCommissionCheck.lstPolicyTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstPolicyTypesRowChangeEvent(
      dsCommissionCheck.lstPolicyTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCommissionCheck.lstPolicyTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
