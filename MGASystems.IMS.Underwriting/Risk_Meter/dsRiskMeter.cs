// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Risk_Meter.dsRiskMeter
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
namespace MGASystems.IMS.Underwriting.Risk_Meter;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsRiskMeter")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsRiskMeter : DataSet
{
  private dsRiskMeter.lstRiskMeterRatingTypesDataTable tablelstRiskMeterRatingTypes;
  private dsRiskMeter.tblRiskMeterLoggingDataTable tabletblRiskMeterLogging;
  private dsRiskMeter.dtLocationsDataTable tabledtLocations;
  private dsRiskMeter.dtPreviousDataTable tabledtPrevious;
  private dsRiskMeter.tblQuoteRiskMeterResultsDataTable tabletblQuoteRiskMeterResults;
  private dsRiskMeter.lstRiskMeterTagNamesDataTable tablelstRiskMeterTagNames;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsRiskMeter()
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
  protected dsRiskMeter(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstRiskMeterRatingTypes)] != null)
          base.Tables.Add((DataTable) new dsRiskMeter.lstRiskMeterRatingTypesDataTable(dataSet.Tables[nameof (lstRiskMeterRatingTypes)]));
        if (dataSet.Tables[nameof (tblRiskMeterLogging)] != null)
          base.Tables.Add((DataTable) new dsRiskMeter.tblRiskMeterLoggingDataTable(dataSet.Tables[nameof (tblRiskMeterLogging)]));
        if (dataSet.Tables[nameof (dtLocations)] != null)
          base.Tables.Add((DataTable) new dsRiskMeter.dtLocationsDataTable(dataSet.Tables[nameof (dtLocations)]));
        if (dataSet.Tables[nameof (dtPrevious)] != null)
          base.Tables.Add((DataTable) new dsRiskMeter.dtPreviousDataTable(dataSet.Tables[nameof (dtPrevious)]));
        if (dataSet.Tables[nameof (tblQuoteRiskMeterResults)] != null)
          base.Tables.Add((DataTable) new dsRiskMeter.tblQuoteRiskMeterResultsDataTable(dataSet.Tables[nameof (tblQuoteRiskMeterResults)]));
        if (dataSet.Tables[nameof (lstRiskMeterTagNames)] != null)
          base.Tables.Add((DataTable) new dsRiskMeter.lstRiskMeterTagNamesDataTable(dataSet.Tables[nameof (lstRiskMeterTagNames)]));
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
  public dsRiskMeter.lstRiskMeterRatingTypesDataTable lstRiskMeterRatingTypes
  {
    get => this.tablelstRiskMeterRatingTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRiskMeter.tblRiskMeterLoggingDataTable tblRiskMeterLogging
  {
    get => this.tabletblRiskMeterLogging;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRiskMeter.dtLocationsDataTable dtLocations => this.tabledtLocations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRiskMeter.dtPreviousDataTable dtPrevious => this.tabledtPrevious;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRiskMeter.tblQuoteRiskMeterResultsDataTable tblQuoteRiskMeterResults
  {
    get => this.tabletblQuoteRiskMeterResults;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRiskMeter.lstRiskMeterTagNamesDataTable lstRiskMeterTagNames
  {
    get => this.tablelstRiskMeterTagNames;
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
    dsRiskMeter dsRiskMeter = (dsRiskMeter) base.Clone();
    dsRiskMeter.InitVars();
    dsRiskMeter.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsRiskMeter;
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
      if (dataSet.Tables["lstRiskMeterRatingTypes"] != null)
        base.Tables.Add((DataTable) new dsRiskMeter.lstRiskMeterRatingTypesDataTable(dataSet.Tables["lstRiskMeterRatingTypes"]));
      if (dataSet.Tables["tblRiskMeterLogging"] != null)
        base.Tables.Add((DataTable) new dsRiskMeter.tblRiskMeterLoggingDataTable(dataSet.Tables["tblRiskMeterLogging"]));
      if (dataSet.Tables["dtLocations"] != null)
        base.Tables.Add((DataTable) new dsRiskMeter.dtLocationsDataTable(dataSet.Tables["dtLocations"]));
      if (dataSet.Tables["dtPrevious"] != null)
        base.Tables.Add((DataTable) new dsRiskMeter.dtPreviousDataTable(dataSet.Tables["dtPrevious"]));
      if (dataSet.Tables["tblQuoteRiskMeterResults"] != null)
        base.Tables.Add((DataTable) new dsRiskMeter.tblQuoteRiskMeterResultsDataTable(dataSet.Tables["tblQuoteRiskMeterResults"]));
      if (dataSet.Tables["lstRiskMeterTagNames"] != null)
        base.Tables.Add((DataTable) new dsRiskMeter.lstRiskMeterTagNamesDataTable(dataSet.Tables["lstRiskMeterTagNames"]));
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
    this.tablelstRiskMeterRatingTypes = (dsRiskMeter.lstRiskMeterRatingTypesDataTable) base.Tables["lstRiskMeterRatingTypes"];
    if (initTable && this.tablelstRiskMeterRatingTypes != null)
      this.tablelstRiskMeterRatingTypes.InitVars();
    this.tabletblRiskMeterLogging = (dsRiskMeter.tblRiskMeterLoggingDataTable) base.Tables["tblRiskMeterLogging"];
    if (initTable && this.tabletblRiskMeterLogging != null)
      this.tabletblRiskMeterLogging.InitVars();
    this.tabledtLocations = (dsRiskMeter.dtLocationsDataTable) base.Tables["dtLocations"];
    if (initTable && this.tabledtLocations != null)
      this.tabledtLocations.InitVars();
    this.tabledtPrevious = (dsRiskMeter.dtPreviousDataTable) base.Tables["dtPrevious"];
    if (initTable && this.tabledtPrevious != null)
      this.tabledtPrevious.InitVars();
    this.tabletblQuoteRiskMeterResults = (dsRiskMeter.tblQuoteRiskMeterResultsDataTable) base.Tables["tblQuoteRiskMeterResults"];
    if (initTable && this.tabletblQuoteRiskMeterResults != null)
      this.tabletblQuoteRiskMeterResults.InitVars();
    this.tablelstRiskMeterTagNames = (dsRiskMeter.lstRiskMeterTagNamesDataTable) base.Tables["lstRiskMeterTagNames"];
    if (!initTable || this.tablelstRiskMeterTagNames == null)
      return;
    this.tablelstRiskMeterTagNames.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsRiskMeter);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsRiskMeter.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstRiskMeterRatingTypes = new dsRiskMeter.lstRiskMeterRatingTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstRiskMeterRatingTypes);
    this.tabletblRiskMeterLogging = new dsRiskMeter.tblRiskMeterLoggingDataTable();
    base.Tables.Add((DataTable) this.tabletblRiskMeterLogging);
    this.tabledtLocations = new dsRiskMeter.dtLocationsDataTable();
    base.Tables.Add((DataTable) this.tabledtLocations);
    this.tabledtPrevious = new dsRiskMeter.dtPreviousDataTable();
    base.Tables.Add((DataTable) this.tabledtPrevious);
    this.tabletblQuoteRiskMeterResults = new dsRiskMeter.tblQuoteRiskMeterResultsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteRiskMeterResults);
    this.tablelstRiskMeterTagNames = new dsRiskMeter.lstRiskMeterTagNamesDataTable();
    base.Tables.Add((DataTable) this.tablelstRiskMeterTagNames);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstRiskMeterRatingTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblRiskMeterLogging() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializedtLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializedtPrevious() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblQuoteRiskMeterResults() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstRiskMeterTagNames() => false;

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
    dsRiskMeter dsRiskMeter = new dsRiskMeter();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = dsRiskMeter.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = dsRiskMeter.GetSchemaSerializable();
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
  public delegate void lstRiskMeterRatingTypesRowChangeEventHandler(
    object sender,
    dsRiskMeter.lstRiskMeterRatingTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblRiskMeterLoggingRowChangeEventHandler(
    object sender,
    dsRiskMeter.tblRiskMeterLoggingRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void dtLocationsRowChangeEventHandler(
    object sender,
    dsRiskMeter.dtLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void dtPreviousRowChangeEventHandler(
    object sender,
    dsRiskMeter.dtPreviousRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblQuoteRiskMeterResultsRowChangeEventHandler(
    object sender,
    dsRiskMeter.tblQuoteRiskMeterResultsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstRiskMeterTagNamesRowChangeEventHandler(
    object sender,
    dsRiskMeter.lstRiskMeterTagNamesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstRiskMeterRatingTypesDataTable : 
    TypedTableBase<dsRiskMeter.lstRiskMeterRatingTypesRow>
  {
    private DataColumn columnRiskRatingID;
    private DataColumn columnRiskRatingType;
    private DataColumn columnRatingParameter;
    private DataColumn columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstRiskMeterRatingTypesDataTable()
    {
      this.TableName = "lstRiskMeterRatingTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstRiskMeterRatingTypesDataTable(DataTable table)
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
    protected lstRiskMeterRatingTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RiskRatingIDColumn => this.columnRiskRatingID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RiskRatingTypeColumn => this.columnRiskRatingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RatingParameterColumn => this.columnRatingParameter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.lstRiskMeterRatingTypesRow this[int index]
    {
      get => (dsRiskMeter.lstRiskMeterRatingTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.lstRiskMeterRatingTypesRowChangeEventHandler lstRiskMeterRatingTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.lstRiskMeterRatingTypesRowChangeEventHandler lstRiskMeterRatingTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.lstRiskMeterRatingTypesRowChangeEventHandler lstRiskMeterRatingTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.lstRiskMeterRatingTypesRowChangeEventHandler lstRiskMeterRatingTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstRiskMeterRatingTypesRow(dsRiskMeter.lstRiskMeterRatingTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.lstRiskMeterRatingTypesRow AddlstRiskMeterRatingTypesRow(
      string RiskRatingType,
      string RatingParameter,
      string State)
    {
      dsRiskMeter.lstRiskMeterRatingTypesRow row = (dsRiskMeter.lstRiskMeterRatingTypesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        null,
        (object) RiskRatingType,
        (object) RatingParameter,
        (object) State
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.lstRiskMeterRatingTypesRow FindByRiskRatingID(int RiskRatingID)
    {
      return (dsRiskMeter.lstRiskMeterRatingTypesRow) this.Rows.Find(new object[1]
      {
        (object) RiskRatingID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRiskMeter.lstRiskMeterRatingTypesDataTable ratingTypesDataTable = (dsRiskMeter.lstRiskMeterRatingTypesDataTable) base.Clone();
      ratingTypesDataTable.InitVars();
      return (DataTable) ratingTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRiskMeter.lstRiskMeterRatingTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnRiskRatingID = this.Columns["RiskRatingID"];
      this.columnRiskRatingType = this.Columns["RiskRatingType"];
      this.columnRatingParameter = this.Columns["RatingParameter"];
      this.columnState = this.Columns["State"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnRiskRatingID = new DataColumn("RiskRatingID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRiskRatingID);
      this.columnRiskRatingType = new DataColumn("RiskRatingType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRiskRatingType);
      this.columnRatingParameter = new DataColumn("RatingParameter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRatingParameter);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnRiskRatingID
      }, true));
      this.columnRiskRatingID.AutoIncrement = true;
      this.columnRiskRatingID.AutoIncrementSeed = -1L;
      this.columnRiskRatingID.AutoIncrementStep = -1L;
      this.columnRiskRatingID.AllowDBNull = false;
      this.columnRiskRatingID.ReadOnly = true;
      this.columnRiskRatingID.Unique = true;
      this.columnRiskRatingType.AllowDBNull = false;
      this.columnRiskRatingType.MaxLength = 200;
      this.columnRatingParameter.MaxLength = 200;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.lstRiskMeterRatingTypesRow NewlstRiskMeterRatingTypesRow()
    {
      return (dsRiskMeter.lstRiskMeterRatingTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRiskMeter.lstRiskMeterRatingTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRiskMeter.lstRiskMeterRatingTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.lstRiskMeterRatingTypesRowChanged == null)
        return;
      this.lstRiskMeterRatingTypesRowChanged((object) this, new dsRiskMeter.lstRiskMeterRatingTypesRowChangeEvent((dsRiskMeter.lstRiskMeterRatingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.lstRiskMeterRatingTypesRowChanging == null)
        return;
      this.lstRiskMeterRatingTypesRowChanging((object) this, new dsRiskMeter.lstRiskMeterRatingTypesRowChangeEvent((dsRiskMeter.lstRiskMeterRatingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.lstRiskMeterRatingTypesRowDeleted == null)
        return;
      this.lstRiskMeterRatingTypesRowDeleted((object) this, new dsRiskMeter.lstRiskMeterRatingTypesRowChangeEvent((dsRiskMeter.lstRiskMeterRatingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.lstRiskMeterRatingTypesRowDeleting == null)
        return;
      this.lstRiskMeterRatingTypesRowDeleting((object) this, new dsRiskMeter.lstRiskMeterRatingTypesRowChangeEvent((dsRiskMeter.lstRiskMeterRatingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstRiskMeterRatingTypesRow(dsRiskMeter.lstRiskMeterRatingTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRiskMeter dsRiskMeter = new dsRiskMeter();
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
        FixedValue = dsRiskMeter.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstRiskMeterRatingTypesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRiskMeter.GetSchemaSerializable();
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
  public class tblRiskMeterLoggingDataTable : TypedTableBase<dsRiskMeter.tblRiskMeterLoggingRow>
  {
    private DataColumn columnID;
    private DataColumn columnQuoteGuid;
    private DataColumn columnResults;
    private DataColumn columnLocation;
    private DataColumn columnUserGuid;
    private DataColumn columnTests;
    private DataColumn columnDateRan;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblRiskMeterLoggingDataTable()
    {
      this.TableName = "tblRiskMeterLogging";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblRiskMeterLoggingDataTable(DataTable table)
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
    protected tblRiskMeterLoggingDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ResultsColumn => this.columnResults;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserGuidColumn => this.columnUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TestsColumn => this.columnTests;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateRanColumn => this.columnDateRan;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.tblRiskMeterLoggingRow this[int index]
    {
      get => (dsRiskMeter.tblRiskMeterLoggingRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.tblRiskMeterLoggingRowChangeEventHandler tblRiskMeterLoggingRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.tblRiskMeterLoggingRowChangeEventHandler tblRiskMeterLoggingRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.tblRiskMeterLoggingRowChangeEventHandler tblRiskMeterLoggingRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.tblRiskMeterLoggingRowChangeEventHandler tblRiskMeterLoggingRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblRiskMeterLoggingRow(dsRiskMeter.tblRiskMeterLoggingRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.tblRiskMeterLoggingRow AddtblRiskMeterLoggingRow(
      Guid QuoteGuid,
      string Results,
      string Location,
      Guid UserGuid,
      string Tests,
      DateTime DateRan)
    {
      dsRiskMeter.tblRiskMeterLoggingRow row = (dsRiskMeter.tblRiskMeterLoggingRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        (object) QuoteGuid,
        (object) Results,
        (object) Location,
        (object) UserGuid,
        (object) Tests,
        (object) DateRan
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.tblRiskMeterLoggingRow FindByID(int ID)
    {
      return (dsRiskMeter.tblRiskMeterLoggingRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRiskMeter.tblRiskMeterLoggingDataTable loggingDataTable = (dsRiskMeter.tblRiskMeterLoggingDataTable) base.Clone();
      loggingDataTable.InitVars();
      return (DataTable) loggingDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRiskMeter.tblRiskMeterLoggingDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnResults = this.Columns["Results"];
      this.columnLocation = this.Columns["Location"];
      this.columnUserGuid = this.Columns["UserGuid"];
      this.columnTests = this.Columns["Tests"];
      this.columnDateRan = this.Columns["DateRan"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnResults = new DataColumn("Results", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResults);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.columnUserGuid = new DataColumn("UserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGuid);
      this.columnTests = new DataColumn("Tests", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTests);
      this.columnDateRan = new DataColumn("DateRan", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateRan);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AutoIncrementSeed = -1L;
      this.columnID.AutoIncrementStep = -1L;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnResults.MaxLength = 8000;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.tblRiskMeterLoggingRow NewtblRiskMeterLoggingRow()
    {
      return (dsRiskMeter.tblRiskMeterLoggingRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRiskMeter.tblRiskMeterLoggingRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRiskMeter.tblRiskMeterLoggingRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.tblRiskMeterLoggingRowChanged == null)
        return;
      this.tblRiskMeterLoggingRowChanged((object) this, new dsRiskMeter.tblRiskMeterLoggingRowChangeEvent((dsRiskMeter.tblRiskMeterLoggingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.tblRiskMeterLoggingRowChanging == null)
        return;
      this.tblRiskMeterLoggingRowChanging((object) this, new dsRiskMeter.tblRiskMeterLoggingRowChangeEvent((dsRiskMeter.tblRiskMeterLoggingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.tblRiskMeterLoggingRowDeleted == null)
        return;
      this.tblRiskMeterLoggingRowDeleted((object) this, new dsRiskMeter.tblRiskMeterLoggingRowChangeEvent((dsRiskMeter.tblRiskMeterLoggingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.tblRiskMeterLoggingRowDeleting == null)
        return;
      this.tblRiskMeterLoggingRowDeleting((object) this, new dsRiskMeter.tblRiskMeterLoggingRowChangeEvent((dsRiskMeter.tblRiskMeterLoggingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblRiskMeterLoggingRow(dsRiskMeter.tblRiskMeterLoggingRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRiskMeter dsRiskMeter = new dsRiskMeter();
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
        FixedValue = dsRiskMeter.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblRiskMeterLoggingDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRiskMeter.GetSchemaSerializable();
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
  public class dtLocationsDataTable : TypedTableBase<dsRiskMeter.dtLocationsRow>
  {
    private DataColumn columnStreet;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;
    private DataColumn columnZipPlus;
    private DataColumn columnLocationID;
    private DataColumn columnLocStatus;
    private DataColumn columnLocationNo;
    private DataColumn columnType;
    private DataColumn columnBuildingNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtLocationsDataTable()
    {
      this.TableName = "dtLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtLocationsDataTable(DataTable table)
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
    protected dtLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StreetColumn => this.columnStreet;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ZipColumn => this.columnZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ZipPlusColumn => this.columnZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocStatusColumn => this.columnLocStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationNoColumn => this.columnLocationNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BuildingNoColumn => this.columnBuildingNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.dtLocationsRow this[int index]
    {
      get => (dsRiskMeter.dtLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.dtLocationsRowChangeEventHandler dtLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.dtLocationsRowChangeEventHandler dtLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.dtLocationsRowChangeEventHandler dtLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.dtLocationsRowChangeEventHandler dtLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AdddtLocationsRow(dsRiskMeter.dtLocationsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.dtLocationsRow AdddtLocationsRow(
      string Street,
      string City,
      string State,
      string Zip,
      string ZipPlus,
      int LocationID,
      string LocStatus,
      string LocationNo,
      string Type,
      string BuildingNo)
    {
      dsRiskMeter.dtLocationsRow row = (dsRiskMeter.dtLocationsRow) this.NewRow();
      object[] objArray = new object[10]
      {
        (object) Street,
        (object) City,
        (object) State,
        (object) Zip,
        (object) ZipPlus,
        (object) LocationID,
        (object) LocStatus,
        (object) LocationNo,
        (object) Type,
        (object) BuildingNo
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.dtLocationsRow FindByLocationID(int LocationID)
    {
      return (dsRiskMeter.dtLocationsRow) this.Rows.Find(new object[1]
      {
        (object) LocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRiskMeter.dtLocationsDataTable locationsDataTable = (dsRiskMeter.dtLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRiskMeter.dtLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnStreet = this.Columns["Street"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
      this.columnZipPlus = this.Columns["ZipPlus"];
      this.columnLocationID = this.Columns["LocationID"];
      this.columnLocStatus = this.Columns["LocStatus"];
      this.columnLocationNo = this.Columns["LocationNo"];
      this.columnType = this.Columns["Type"];
      this.columnBuildingNo = this.Columns["BuildingNo"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnStreet = new DataColumn("Street", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStreet);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.columnZipPlus = new DataColumn("ZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipPlus);
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnLocStatus = new DataColumn("LocStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocStatus);
      this.columnLocationNo = new DataColumn("LocationNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationNo);
      this.columnType = new DataColumn("Type", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnType);
      this.columnBuildingNo = new DataColumn("BuildingNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBuildingNo);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnLocationID
      }, true));
      this.columnLocationID.AllowDBNull = false;
      this.columnLocationID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.dtLocationsRow NewdtLocationsRow()
    {
      return (dsRiskMeter.dtLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRiskMeter.dtLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRiskMeter.dtLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.dtLocationsRowChanged == null)
        return;
      this.dtLocationsRowChanged((object) this, new dsRiskMeter.dtLocationsRowChangeEvent((dsRiskMeter.dtLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.dtLocationsRowChanging == null)
        return;
      this.dtLocationsRowChanging((object) this, new dsRiskMeter.dtLocationsRowChangeEvent((dsRiskMeter.dtLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.dtLocationsRowDeleted == null)
        return;
      this.dtLocationsRowDeleted((object) this, new dsRiskMeter.dtLocationsRowChangeEvent((dsRiskMeter.dtLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.dtLocationsRowDeleting == null)
        return;
      this.dtLocationsRowDeleting((object) this, new dsRiskMeter.dtLocationsRowChangeEvent((dsRiskMeter.dtLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovedtLocationsRow(dsRiskMeter.dtLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRiskMeter dsRiskMeter = new dsRiskMeter();
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
        FixedValue = dsRiskMeter.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtLocationsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRiskMeter.GetSchemaSerializable();
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
  public class dtPreviousDataTable : TypedTableBase<dsRiskMeter.dtPreviousRow>
  {
    private DataColumn columnRanBy;
    private DataColumn columnItem;
    private DataColumn columnItemResults;
    private DataColumn columnAdded;
    private DataColumn columnItemDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtPreviousDataTable()
    {
      this.TableName = "dtPrevious";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtPreviousDataTable(DataTable table)
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
    protected dtPreviousDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RanByColumn => this.columnRanBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ItemColumn => this.columnItem;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ItemResultsColumn => this.columnItemResults;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AddedColumn => this.columnAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ItemDescriptionColumn => this.columnItemDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.dtPreviousRow this[int index]
    {
      get => (dsRiskMeter.dtPreviousRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.dtPreviousRowChangeEventHandler dtPreviousRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.dtPreviousRowChangeEventHandler dtPreviousRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.dtPreviousRowChangeEventHandler dtPreviousRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.dtPreviousRowChangeEventHandler dtPreviousRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AdddtPreviousRow(dsRiskMeter.dtPreviousRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.dtPreviousRow AdddtPreviousRow(
      string RanBy,
      string Item,
      string ItemResults,
      DateTime Added,
      string ItemDescription)
    {
      dsRiskMeter.dtPreviousRow row = (dsRiskMeter.dtPreviousRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) RanBy,
        (object) Item,
        (object) ItemResults,
        (object) Added,
        (object) ItemDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRiskMeter.dtPreviousDataTable previousDataTable = (dsRiskMeter.dtPreviousDataTable) base.Clone();
      previousDataTable.InitVars();
      return (DataTable) previousDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRiskMeter.dtPreviousDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnRanBy = this.Columns["RanBy"];
      this.columnItem = this.Columns["Item"];
      this.columnItemResults = this.Columns["ItemResults"];
      this.columnAdded = this.Columns["Added"];
      this.columnItemDescription = this.Columns["ItemDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnRanBy = new DataColumn("RanBy", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRanBy);
      this.columnItem = new DataColumn("Item", typeof (string), (string) null, MappingType.Element);
      this.columnItem.ExtendedProperties.Add((object) "Generator_ColumnPropNameInRow", (object) "Item");
      this.columnItem.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "ItemColumn");
      this.columnItem.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnItem");
      this.columnItem.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Item");
      this.Columns.Add(this.columnItem);
      this.columnItemResults = new DataColumn("ItemResults", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnItemResults);
      this.columnAdded = new DataColumn("Added", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdded);
      this.columnItemDescription = new DataColumn("ItemDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnItemDescription);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.dtPreviousRow NewdtPreviousRow()
    {
      return (dsRiskMeter.dtPreviousRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRiskMeter.dtPreviousRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRiskMeter.dtPreviousRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.dtPreviousRowChanged == null)
        return;
      this.dtPreviousRowChanged((object) this, new dsRiskMeter.dtPreviousRowChangeEvent((dsRiskMeter.dtPreviousRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.dtPreviousRowChanging == null)
        return;
      this.dtPreviousRowChanging((object) this, new dsRiskMeter.dtPreviousRowChangeEvent((dsRiskMeter.dtPreviousRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.dtPreviousRowDeleted == null)
        return;
      this.dtPreviousRowDeleted((object) this, new dsRiskMeter.dtPreviousRowChangeEvent((dsRiskMeter.dtPreviousRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.dtPreviousRowDeleting == null)
        return;
      this.dtPreviousRowDeleting((object) this, new dsRiskMeter.dtPreviousRowChangeEvent((dsRiskMeter.dtPreviousRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovedtPreviousRow(dsRiskMeter.dtPreviousRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRiskMeter dsRiskMeter = new dsRiskMeter();
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
        FixedValue = dsRiskMeter.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtPreviousDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRiskMeter.GetSchemaSerializable();
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
  public class tblQuoteRiskMeterResultsDataTable : 
    TypedTableBase<dsRiskMeter.tblQuoteRiskMeterResultsRow>
  {
    private DataColumn columnID;
    private DataColumn columnQuoteID;
    private DataColumn columnItem;
    private DataColumn columnItemResults;
    private DataColumn columnResultsDate;
    private DataColumn columnUserGuid;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteRiskMeterResultsDataTable()
    {
      this.TableName = "tblQuoteRiskMeterResults";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteRiskMeterResultsDataTable(DataTable table)
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
    protected tblQuoteRiskMeterResultsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ItemColumn => this.columnItem;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ItemResultsColumn => this.columnItemResults;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ResultsDateColumn => this.columnResultsDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserGuidColumn => this.columnUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.tblQuoteRiskMeterResultsRow this[int index]
    {
      get => (dsRiskMeter.tblQuoteRiskMeterResultsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.tblQuoteRiskMeterResultsRowChangeEventHandler tblQuoteRiskMeterResultsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.tblQuoteRiskMeterResultsRowChangeEventHandler tblQuoteRiskMeterResultsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.tblQuoteRiskMeterResultsRowChangeEventHandler tblQuoteRiskMeterResultsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.tblQuoteRiskMeterResultsRowChangeEventHandler tblQuoteRiskMeterResultsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteRiskMeterResultsRow(dsRiskMeter.tblQuoteRiskMeterResultsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.tblQuoteRiskMeterResultsRow AddtblQuoteRiskMeterResultsRow(
      int QuoteID,
      string Item,
      string ItemResults,
      DateTime ResultsDate,
      Guid UserGuid,
      string Description)
    {
      dsRiskMeter.tblQuoteRiskMeterResultsRow row = (dsRiskMeter.tblQuoteRiskMeterResultsRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        (object) QuoteID,
        (object) Item,
        (object) ItemResults,
        (object) ResultsDate,
        (object) UserGuid,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.tblQuoteRiskMeterResultsRow FindByID(int ID)
    {
      return (dsRiskMeter.tblQuoteRiskMeterResultsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRiskMeter.tblQuoteRiskMeterResultsDataTable resultsDataTable = (dsRiskMeter.tblQuoteRiskMeterResultsDataTable) base.Clone();
      resultsDataTable.InitVars();
      return (DataTable) resultsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRiskMeter.tblQuoteRiskMeterResultsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnItem = this.Columns["Item"];
      this.columnItemResults = this.Columns["ItemResults"];
      this.columnResultsDate = this.Columns["ResultsDate"];
      this.columnUserGuid = this.Columns["UserGuid"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnItem = new DataColumn("Item", typeof (string), (string) null, MappingType.Element);
      this.columnItem.ExtendedProperties.Add((object) "Generator_ColumnPropNameInRow", (object) "Item");
      this.columnItem.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "ItemColumn");
      this.columnItem.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnItem");
      this.columnItem.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Item");
      this.Columns.Add(this.columnItem);
      this.columnItemResults = new DataColumn("ItemResults", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnItemResults);
      this.columnResultsDate = new DataColumn("ResultsDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResultsDate);
      this.columnUserGuid = new DataColumn("UserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGuid);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AutoIncrementSeed = -1L;
      this.columnID.AutoIncrementStep = -1L;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnQuoteID.AllowDBNull = false;
      this.columnItem.AllowDBNull = false;
      this.columnItem.MaxLength = 200;
      this.columnItemResults.AllowDBNull = false;
      this.columnItemResults.MaxLength = 8000;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.tblQuoteRiskMeterResultsRow NewtblQuoteRiskMeterResultsRow()
    {
      return (dsRiskMeter.tblQuoteRiskMeterResultsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRiskMeter.tblQuoteRiskMeterResultsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRiskMeter.tblQuoteRiskMeterResultsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.tblQuoteRiskMeterResultsRowChanged == null)
        return;
      this.tblQuoteRiskMeterResultsRowChanged((object) this, new dsRiskMeter.tblQuoteRiskMeterResultsRowChangeEvent((dsRiskMeter.tblQuoteRiskMeterResultsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.tblQuoteRiskMeterResultsRowChanging == null)
        return;
      this.tblQuoteRiskMeterResultsRowChanging((object) this, new dsRiskMeter.tblQuoteRiskMeterResultsRowChangeEvent((dsRiskMeter.tblQuoteRiskMeterResultsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.tblQuoteRiskMeterResultsRowDeleted == null)
        return;
      this.tblQuoteRiskMeterResultsRowDeleted((object) this, new dsRiskMeter.tblQuoteRiskMeterResultsRowChangeEvent((dsRiskMeter.tblQuoteRiskMeterResultsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.tblQuoteRiskMeterResultsRowDeleting == null)
        return;
      this.tblQuoteRiskMeterResultsRowDeleting((object) this, new dsRiskMeter.tblQuoteRiskMeterResultsRowChangeEvent((dsRiskMeter.tblQuoteRiskMeterResultsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteRiskMeterResultsRow(dsRiskMeter.tblQuoteRiskMeterResultsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRiskMeter dsRiskMeter = new dsRiskMeter();
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
        FixedValue = dsRiskMeter.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteRiskMeterResultsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRiskMeter.GetSchemaSerializable();
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
  public class lstRiskMeterTagNamesDataTable : TypedTableBase<dsRiskMeter.lstRiskMeterTagNamesRow>
  {
    private DataColumn columnTag;
    private DataColumn columnTagName;
    private DataColumn columnTestName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstRiskMeterTagNamesDataTable()
    {
      this.TableName = "lstRiskMeterTagNames";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstRiskMeterTagNamesDataTable(DataTable table)
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
    protected lstRiskMeterTagNamesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TagColumn => this.columnTag;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TagNameColumn => this.columnTagName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TestNameColumn => this.columnTestName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.lstRiskMeterTagNamesRow this[int index]
    {
      get => (dsRiskMeter.lstRiskMeterTagNamesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.lstRiskMeterTagNamesRowChangeEventHandler lstRiskMeterTagNamesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.lstRiskMeterTagNamesRowChangeEventHandler lstRiskMeterTagNamesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.lstRiskMeterTagNamesRowChangeEventHandler lstRiskMeterTagNamesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRiskMeter.lstRiskMeterTagNamesRowChangeEventHandler lstRiskMeterTagNamesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstRiskMeterTagNamesRow(dsRiskMeter.lstRiskMeterTagNamesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.lstRiskMeterTagNamesRow AddlstRiskMeterTagNamesRow(
      string Tag,
      string TagName,
      string TestName)
    {
      dsRiskMeter.lstRiskMeterTagNamesRow row = (dsRiskMeter.lstRiskMeterTagNamesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) Tag,
        (object) TagName,
        (object) TestName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRiskMeter.lstRiskMeterTagNamesDataTable tagNamesDataTable = (dsRiskMeter.lstRiskMeterTagNamesDataTable) base.Clone();
      tagNamesDataTable.InitVars();
      return (DataTable) tagNamesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRiskMeter.lstRiskMeterTagNamesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnTag = this.Columns["Tag"];
      this.columnTagName = this.Columns["TagName"];
      this.columnTestName = this.Columns["TestName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnTag = new DataColumn("Tag", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTag);
      this.columnTagName = new DataColumn("TagName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTagName);
      this.columnTestName = new DataColumn("TestName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTestName);
      this.columnTag.AllowDBNull = false;
      this.columnTag.MaxLength = 75;
      this.columnTagName.AllowDBNull = false;
      this.columnTagName.MaxLength = 500;
      this.columnTestName.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.lstRiskMeterTagNamesRow NewlstRiskMeterTagNamesRow()
    {
      return (dsRiskMeter.lstRiskMeterTagNamesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRiskMeter.lstRiskMeterTagNamesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRiskMeter.lstRiskMeterTagNamesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.lstRiskMeterTagNamesRowChanged == null)
        return;
      this.lstRiskMeterTagNamesRowChanged((object) this, new dsRiskMeter.lstRiskMeterTagNamesRowChangeEvent((dsRiskMeter.lstRiskMeterTagNamesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.lstRiskMeterTagNamesRowChanging == null)
        return;
      this.lstRiskMeterTagNamesRowChanging((object) this, new dsRiskMeter.lstRiskMeterTagNamesRowChangeEvent((dsRiskMeter.lstRiskMeterTagNamesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.lstRiskMeterTagNamesRowDeleted == null)
        return;
      this.lstRiskMeterTagNamesRowDeleted((object) this, new dsRiskMeter.lstRiskMeterTagNamesRowChangeEvent((dsRiskMeter.lstRiskMeterTagNamesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.lstRiskMeterTagNamesRowDeleting == null)
        return;
      this.lstRiskMeterTagNamesRowDeleting((object) this, new dsRiskMeter.lstRiskMeterTagNamesRowChangeEvent((dsRiskMeter.lstRiskMeterTagNamesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstRiskMeterTagNamesRow(dsRiskMeter.lstRiskMeterTagNamesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRiskMeter dsRiskMeter = new dsRiskMeter();
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
        FixedValue = dsRiskMeter.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstRiskMeterTagNamesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRiskMeter.GetSchemaSerializable();
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

  public class lstRiskMeterRatingTypesRow : DataRow
  {
    private dsRiskMeter.lstRiskMeterRatingTypesDataTable tablelstRiskMeterRatingTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstRiskMeterRatingTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstRiskMeterRatingTypes = (dsRiskMeter.lstRiskMeterRatingTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int RiskRatingID
    {
      get => (int) this[this.tablelstRiskMeterRatingTypes.RiskRatingIDColumn];
      set => this[this.tablelstRiskMeterRatingTypes.RiskRatingIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RiskRatingType
    {
      get => (string) this[this.tablelstRiskMeterRatingTypes.RiskRatingTypeColumn];
      set => this[this.tablelstRiskMeterRatingTypes.RiskRatingTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RatingParameter
    {
      get
      {
        try
        {
          return (string) this[this.tablelstRiskMeterRatingTypes.RatingParameterColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'RatingParameter' in table 'lstRiskMeterRatingTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstRiskMeterRatingTypes.RatingParameterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return (string) this[this.tablelstRiskMeterRatingTypes.StateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'State' in table 'lstRiskMeterRatingTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstRiskMeterRatingTypes.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRatingParameterNull()
    {
      return this.IsNull(this.tablelstRiskMeterRatingTypes.RatingParameterColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRatingParameterNull()
    {
      this[this.tablelstRiskMeterRatingTypes.RatingParameterColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tablelstRiskMeterRatingTypes.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateNull()
    {
      this[this.tablelstRiskMeterRatingTypes.StateColumn] = Convert.DBNull;
    }
  }

  public class tblRiskMeterLoggingRow : DataRow
  {
    private dsRiskMeter.tblRiskMeterLoggingDataTable tabletblRiskMeterLogging;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblRiskMeterLoggingRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblRiskMeterLogging = (dsRiskMeter.tblRiskMeterLoggingDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get => (int) this[this.tabletblRiskMeterLogging.IDColumn];
      set => this[this.tabletblRiskMeterLogging.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tabletblRiskMeterLogging.QuoteGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'QuoteGuid' in table 'tblRiskMeterLogging' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRiskMeterLogging.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Results
    {
      get
      {
        try
        {
          return (string) this[this.tabletblRiskMeterLogging.ResultsColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Results' in table 'tblRiskMeterLogging' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRiskMeterLogging.ResultsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Location
    {
      get
      {
        try
        {
          return (string) this[this.tabletblRiskMeterLogging.LocationColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Location' in table 'tblRiskMeterLogging' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRiskMeterLogging.LocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid UserGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tabletblRiskMeterLogging.UserGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'UserGuid' in table 'tblRiskMeterLogging' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRiskMeterLogging.UserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Tests
    {
      get
      {
        try
        {
          return (string) this[this.tabletblRiskMeterLogging.TestsColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Tests' in table 'tblRiskMeterLogging' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRiskMeterLogging.TestsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateRan
    {
      get
      {
        try
        {
          return (DateTime) this[this.tabletblRiskMeterLogging.DateRanColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'DateRan' in table 'tblRiskMeterLogging' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblRiskMeterLogging.DateRanColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsQuoteGuidNull() => this.IsNull(this.tabletblRiskMeterLogging.QuoteGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetQuoteGuidNull()
    {
      this[this.tabletblRiskMeterLogging.QuoteGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsResultsNull() => this.IsNull(this.tabletblRiskMeterLogging.ResultsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetResultsNull()
    {
      this[this.tabletblRiskMeterLogging.ResultsColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocationNull() => this.IsNull(this.tabletblRiskMeterLogging.LocationColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocationNull()
    {
      this[this.tabletblRiskMeterLogging.LocationColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUserGuidNull() => this.IsNull(this.tabletblRiskMeterLogging.UserGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUserGuidNull()
    {
      this[this.tabletblRiskMeterLogging.UserGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTestsNull() => this.IsNull(this.tabletblRiskMeterLogging.TestsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTestsNull() => this[this.tabletblRiskMeterLogging.TestsColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDateRanNull() => this.IsNull(this.tabletblRiskMeterLogging.DateRanColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDateRanNull()
    {
      this[this.tabletblRiskMeterLogging.DateRanColumn] = Convert.DBNull;
    }
  }

  public class dtLocationsRow : DataRow
  {
    private dsRiskMeter.dtLocationsDataTable tabledtLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtLocations = (dsRiskMeter.dtLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Street
    {
      get
      {
        try
        {
          return (string) this[this.tabledtLocations.StreetColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Street' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.StreetColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return (string) this[this.tabledtLocations.CityColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'City' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return (string) this[this.tabledtLocations.StateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'State' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Zip
    {
      get
      {
        try
        {
          return (string) this[this.tabledtLocations.ZipColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Zip' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ZipPlus
    {
      get
      {
        try
        {
          return (string) this[this.tabledtLocations.ZipPlusColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ZipPlus' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.ZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int LocationID
    {
      get => (int) this[this.tabledtLocations.LocationIDColumn];
      set => this[this.tabledtLocations.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LocStatus
    {
      get
      {
        try
        {
          return (string) this[this.tabledtLocations.LocStatusColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'LocStatus' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.LocStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LocationNo
    {
      get
      {
        try
        {
          return (string) this[this.tabledtLocations.LocationNoColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'LocationNo' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.LocationNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Type
    {
      get
      {
        try
        {
          return (string) this[this.tabledtLocations.TypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Type' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.TypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BuildingNo
    {
      get
      {
        try
        {
          return (string) this[this.tabledtLocations.BuildingNoColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'BuildingNo' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.BuildingNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStreetNull() => this.IsNull(this.tabledtLocations.StreetColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStreetNull() => this[this.tabledtLocations.StreetColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabledtLocations.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCityNull() => this[this.tabledtLocations.CityColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabledtLocations.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateNull() => this[this.tabledtLocations.StateColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsZipNull() => this.IsNull(this.tabledtLocations.ZipColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetZipNull() => this[this.tabledtLocations.ZipColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsZipPlusNull() => this.IsNull(this.tabledtLocations.ZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetZipPlusNull() => this[this.tabledtLocations.ZipPlusColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocStatusNull() => this.IsNull(this.tabledtLocations.LocStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocStatusNull() => this[this.tabledtLocations.LocStatusColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocationNoNull() => this.IsNull(this.tabledtLocations.LocationNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocationNoNull()
    {
      this[this.tabledtLocations.LocationNoColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTypeNull() => this.IsNull(this.tabledtLocations.TypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTypeNull() => this[this.tabledtLocations.TypeColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBuildingNoNull() => this.IsNull(this.tabledtLocations.BuildingNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBuildingNoNull()
    {
      this[this.tabledtLocations.BuildingNoColumn] = Convert.DBNull;
    }
  }

  public class dtPreviousRow : DataRow
  {
    private dsRiskMeter.dtPreviousDataTable tabledtPrevious;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtPreviousRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtPrevious = (dsRiskMeter.dtPreviousDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RanBy
    {
      get
      {
        try
        {
          return (string) this[this.tabledtPrevious.RanByColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'RanBy' in table 'dtPrevious' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtPrevious.RanByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Item
    {
      get
      {
        try
        {
          return (string) this[this.tabledtPrevious.ItemColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Item' in table 'dtPrevious' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtPrevious.ItemColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ItemResults
    {
      get
      {
        try
        {
          return (string) this[this.tabledtPrevious.ItemResultsColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ItemResults' in table 'dtPrevious' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtPrevious.ItemResultsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime Added
    {
      get
      {
        try
        {
          return (DateTime) this[this.tabledtPrevious.AddedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Added' in table 'dtPrevious' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtPrevious.AddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ItemDescription
    {
      get
      {
        try
        {
          return (string) this[this.tabledtPrevious.ItemDescriptionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ItemDescription' in table 'dtPrevious' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtPrevious.ItemDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRanByNull() => this.IsNull(this.tabledtPrevious.RanByColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRanByNull() => this[this.tabledtPrevious.RanByColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsItemNull() => this.IsNull(this.tabledtPrevious.ItemColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetItemNull() => this[this.tabledtPrevious.ItemColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsItemResultsNull() => this.IsNull(this.tabledtPrevious.ItemResultsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetItemResultsNull()
    {
      this[this.tabledtPrevious.ItemResultsColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAddedNull() => this.IsNull(this.tabledtPrevious.AddedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAddedNull() => this[this.tabledtPrevious.AddedColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsItemDescriptionNull() => this.IsNull(this.tabledtPrevious.ItemDescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetItemDescriptionNull()
    {
      this[this.tabledtPrevious.ItemDescriptionColumn] = Convert.DBNull;
    }
  }

  public class tblQuoteRiskMeterResultsRow : DataRow
  {
    private dsRiskMeter.tblQuoteRiskMeterResultsDataTable tabletblQuoteRiskMeterResults;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteRiskMeterResultsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteRiskMeterResults = (dsRiskMeter.tblQuoteRiskMeterResultsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get => (int) this[this.tabletblQuoteRiskMeterResults.IDColumn];
      set => this[this.tabletblQuoteRiskMeterResults.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteID
    {
      get => (int) this[this.tabletblQuoteRiskMeterResults.QuoteIDColumn];
      set => this[this.tabletblQuoteRiskMeterResults.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Item
    {
      get => (string) this[this.tabletblQuoteRiskMeterResults.ItemColumn];
      set => this[this.tabletblQuoteRiskMeterResults.ItemColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ItemResults
    {
      get => (string) this[this.tabletblQuoteRiskMeterResults.ItemResultsColumn];
      set => this[this.tabletblQuoteRiskMeterResults.ItemResultsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime ResultsDate
    {
      get
      {
        try
        {
          return (DateTime) this[this.tabletblQuoteRiskMeterResults.ResultsDateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ResultsDate' in table 'tblQuoteRiskMeterResults' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteRiskMeterResults.ResultsDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid UserGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tabletblQuoteRiskMeterResults.UserGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'UserGuid' in table 'tblQuoteRiskMeterResults' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteRiskMeterResults.UserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return (string) this[this.tabletblQuoteRiskMeterResults.DescriptionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Description' in table 'tblQuoteRiskMeterResults' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteRiskMeterResults.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsResultsDateNull()
    {
      return this.IsNull(this.tabletblQuoteRiskMeterResults.ResultsDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetResultsDateNull()
    {
      this[this.tabletblQuoteRiskMeterResults.ResultsDateColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUserGuidNull() => this.IsNull(this.tabletblQuoteRiskMeterResults.UserGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUserGuidNull()
    {
      this[this.tabletblQuoteRiskMeterResults.UserGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDescriptionNull()
    {
      return this.IsNull(this.tabletblQuoteRiskMeterResults.DescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tabletblQuoteRiskMeterResults.DescriptionColumn] = Convert.DBNull;
    }
  }

  public class lstRiskMeterTagNamesRow : DataRow
  {
    private dsRiskMeter.lstRiskMeterTagNamesDataTable tablelstRiskMeterTagNames;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstRiskMeterTagNamesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstRiskMeterTagNames = (dsRiskMeter.lstRiskMeterTagNamesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Tag
    {
      get => (string) this[this.tablelstRiskMeterTagNames.TagColumn];
      set => this[this.tablelstRiskMeterTagNames.TagColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string TagName
    {
      get => (string) this[this.tablelstRiskMeterTagNames.TagNameColumn];
      set => this[this.tablelstRiskMeterTagNames.TagNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string TestName
    {
      get
      {
        try
        {
          return (string) this[this.tablelstRiskMeterTagNames.TestNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'TestName' in table 'lstRiskMeterTagNames' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstRiskMeterTagNames.TestNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTestNameNull() => this.IsNull(this.tablelstRiskMeterTagNames.TestNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTestNameNull()
    {
      this[this.tablelstRiskMeterTagNames.TestNameColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstRiskMeterRatingTypesRowChangeEvent : EventArgs
  {
    private dsRiskMeter.lstRiskMeterRatingTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstRiskMeterRatingTypesRowChangeEvent(
      dsRiskMeter.lstRiskMeterRatingTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.lstRiskMeterRatingTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblRiskMeterLoggingRowChangeEvent : EventArgs
  {
    private dsRiskMeter.tblRiskMeterLoggingRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblRiskMeterLoggingRowChangeEvent(
      dsRiskMeter.tblRiskMeterLoggingRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.tblRiskMeterLoggingRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class dtLocationsRowChangeEvent : EventArgs
  {
    private dsRiskMeter.dtLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtLocationsRowChangeEvent(dsRiskMeter.dtLocationsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.dtLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class dtPreviousRowChangeEvent : EventArgs
  {
    private dsRiskMeter.dtPreviousRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtPreviousRowChangeEvent(dsRiskMeter.dtPreviousRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.dtPreviousRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteRiskMeterResultsRowChangeEvent : EventArgs
  {
    private dsRiskMeter.tblQuoteRiskMeterResultsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteRiskMeterResultsRowChangeEvent(
      dsRiskMeter.tblQuoteRiskMeterResultsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.tblQuoteRiskMeterResultsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstRiskMeterTagNamesRowChangeEvent : EventArgs
  {
    private dsRiskMeter.lstRiskMeterTagNamesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstRiskMeterTagNamesRowChangeEvent(
      dsRiskMeter.lstRiskMeterTagNamesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRiskMeter.lstRiskMeterTagNamesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
