// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.dsNetRateInspect
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

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
namespace MGASystems.IMS.Policies.Inspections;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsNetRateInspect")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsNetRateInspect : DataSet
{
  private dsNetRateInspect.tblNetRateInspectionInfoDataTable tabletblNetRateInspectionInfo;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsNetRateInspect()
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
  protected dsNetRateInspect(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblNetRateInspectionInfo)] != null)
          base.Tables.Add((DataTable) new dsNetRateInspect.tblNetRateInspectionInfoDataTable(dataSet.Tables[nameof (tblNetRateInspectionInfo)]));
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
  public dsNetRateInspect.tblNetRateInspectionInfoDataTable tblNetRateInspectionInfo
  {
    get => this.tabletblNetRateInspectionInfo;
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
    dsNetRateInspect dsNetRateInspect = (dsNetRateInspect) base.Clone();
    dsNetRateInspect.InitVars();
    dsNetRateInspect.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsNetRateInspect;
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
      if (dataSet.Tables["tblNetRateInspectionInfo"] != null)
        base.Tables.Add((DataTable) new dsNetRateInspect.tblNetRateInspectionInfoDataTable(dataSet.Tables["tblNetRateInspectionInfo"]));
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
    this.tabletblNetRateInspectionInfo = (dsNetRateInspect.tblNetRateInspectionInfoDataTable) base.Tables["tblNetRateInspectionInfo"];
    if (!initTable || this.tabletblNetRateInspectionInfo == null)
      return;
    this.tabletblNetRateInspectionInfo.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsNetRateInspect);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsNetRateInspect.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblNetRateInspectionInfo = new dsNetRateInspect.tblNetRateInspectionInfoDataTable();
    base.Tables.Add((DataTable) this.tabletblNetRateInspectionInfo);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblNetRateInspectionInfo() => false;

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
    dsNetRateInspect dsNetRateInspect = new dsNetRateInspect();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsNetRateInspect.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsNetRateInspect.GetSchemaSerializable();
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
  public delegate void tblNetRateInspectionInfoRowChangeEventHandler(
    object sender,
    dsNetRateInspect.tblNetRateInspectionInfoRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblNetRateInspectionInfoDataTable : 
    TypedTableBase<dsNetRateInspect.tblNetRateInspectionInfoRow>
  {
    private DataColumn columnControlNo;
    private DataColumn columnLocationID;
    private DataColumn columnPremesisID;
    private DataColumn columnExposureID;
    private DataColumn columnCostEstimation;
    private DataColumn columnPhoto;
    private DataColumn columnDiagram;
    private DataColumn columnLocationContact;
    private DataColumn columnContactPhone;
    private DataColumn columnSpecialInstructions;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;
    private DataColumn columnSIC;
    private DataColumn columnInspectionCompanyID;
    private DataColumn columnDateInspected;
    private DataColumn columnQuoteID;
    private DataColumn columnInspectionMethod;
    private DataColumn columnWorkersCompID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblNetRateInspectionInfoDataTable()
    {
      this.TableName = "tblNetRateInspectionInfo";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblNetRateInspectionInfoDataTable(DataTable table)
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
    protected tblNetRateInspectionInfoDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremesisIDColumn => this.columnPremesisID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExposureIDColumn => this.columnExposureID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CostEstimationColumn => this.columnCostEstimation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PhotoColumn => this.columnPhoto;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DiagramColumn => this.columnDiagram;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationContactColumn => this.columnLocationContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContactPhoneColumn => this.columnContactPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SpecialInstructionsColumn => this.columnSpecialInstructions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Address1Column => this.columnAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Address2Column => this.columnAddress2;

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
    public DataColumn SICColumn => this.columnSIC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InspectionCompanyIDColumn => this.columnInspectionCompanyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateInspectedColumn => this.columnDateInspected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InspectionMethodColumn => this.columnInspectionMethod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn WorkersCompIDColumn => this.columnWorkersCompID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsNetRateInspect.tblNetRateInspectionInfoRow this[int index]
    {
      get => (dsNetRateInspect.tblNetRateInspectionInfoRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsNetRateInspect.tblNetRateInspectionInfoRowChangeEventHandler tblNetRateInspectionInfoRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsNetRateInspect.tblNetRateInspectionInfoRowChangeEventHandler tblNetRateInspectionInfoRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsNetRateInspect.tblNetRateInspectionInfoRowChangeEventHandler tblNetRateInspectionInfoRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsNetRateInspect.tblNetRateInspectionInfoRowChangeEventHandler tblNetRateInspectionInfoRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblNetRateInspectionInfoRow(dsNetRateInspect.tblNetRateInspectionInfoRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsNetRateInspect.tblNetRateInspectionInfoRow AddtblNetRateInspectionInfoRow(
      int ControlNo,
      int LocationID,
      int PremesisID,
      int ExposureID,
      bool CostEstimation,
      bool Photo,
      bool Diagram,
      string LocationContact,
      string ContactPhone,
      string SpecialInstructions,
      string Address1,
      string Address2,
      string City,
      string State,
      string Zip,
      string SIC,
      int InspectionCompanyID,
      DateTime DateInspected,
      int QuoteID,
      byte InspectionMethod,
      int WorkersCompID)
    {
      dsNetRateInspect.tblNetRateInspectionInfoRow row = (dsNetRateInspect.tblNetRateInspectionInfoRow) this.NewRow();
      object[] objArray = new object[21]
      {
        (object) ControlNo,
        (object) LocationID,
        (object) PremesisID,
        (object) ExposureID,
        (object) CostEstimation,
        (object) Photo,
        (object) Diagram,
        (object) LocationContact,
        (object) ContactPhone,
        (object) SpecialInstructions,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) State,
        (object) Zip,
        (object) SIC,
        (object) InspectionCompanyID,
        (object) DateInspected,
        (object) QuoteID,
        (object) InspectionMethod,
        (object) WorkersCompID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsNetRateInspect.tblNetRateInspectionInfoDataTable inspectionInfoDataTable = (dsNetRateInspect.tblNetRateInspectionInfoDataTable) base.Clone();
      inspectionInfoDataTable.InitVars();
      return (DataTable) inspectionInfoDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNetRateInspect.tblNetRateInspectionInfoDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnLocationID = this.Columns["LocationID"];
      this.columnPremesisID = this.Columns["PremesisID"];
      this.columnExposureID = this.Columns["ExposureID"];
      this.columnCostEstimation = this.Columns["CostEstimation"];
      this.columnPhoto = this.Columns["Photo"];
      this.columnDiagram = this.Columns["Diagram"];
      this.columnLocationContact = this.Columns["LocationContact"];
      this.columnContactPhone = this.Columns["ContactPhone"];
      this.columnSpecialInstructions = this.Columns["SpecialInstructions"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
      this.columnSIC = this.Columns["SIC"];
      this.columnInspectionCompanyID = this.Columns["InspectionCompanyID"];
      this.columnDateInspected = this.Columns["DateInspected"];
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnInspectionMethod = this.Columns["InspectionMethod"];
      this.columnWorkersCompID = this.Columns["WorkersCompID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnPremesisID = new DataColumn("PremesisID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremesisID);
      this.columnExposureID = new DataColumn("ExposureID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExposureID);
      this.columnCostEstimation = new DataColumn("CostEstimation", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostEstimation);
      this.columnPhoto = new DataColumn("Photo", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhoto);
      this.columnDiagram = new DataColumn("Diagram", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDiagram);
      this.columnLocationContact = new DataColumn("LocationContact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationContact);
      this.columnContactPhone = new DataColumn("ContactPhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactPhone);
      this.columnSpecialInstructions = new DataColumn("SpecialInstructions", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecialInstructions);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnAddress2 = new DataColumn("Address2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.columnSIC = new DataColumn("SIC", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIC);
      this.columnInspectionCompanyID = new DataColumn("InspectionCompanyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionCompanyID);
      this.columnDateInspected = new DataColumn("DateInspected", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateInspected);
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnInspectionMethod = new DataColumn("InspectionMethod", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInspectionMethod);
      this.columnWorkersCompID = new DataColumn("WorkersCompID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWorkersCompID);
      this.columnControlNo.AllowDBNull = false;
      this.columnLocationID.AllowDBNull = false;
      this.columnCostEstimation.AllowDBNull = false;
      this.columnPhoto.AllowDBNull = false;
      this.columnDiagram.AllowDBNull = false;
      this.columnSpecialInstructions.MaxLength = 2000;
      this.columnInspectionCompanyID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsNetRateInspect.tblNetRateInspectionInfoRow NewtblNetRateInspectionInfoRow()
    {
      return (dsNetRateInspect.tblNetRateInspectionInfoRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNetRateInspect.tblNetRateInspectionInfoRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsNetRateInspect.tblNetRateInspectionInfoRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateInspectionInfoRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNetRateInspect.tblNetRateInspectionInfoRowChangeEventHandler infoRowChangedEvent = this.tblNetRateInspectionInfoRowChangedEvent;
      if (infoRowChangedEvent == null)
        return;
      infoRowChangedEvent((object) this, new dsNetRateInspect.tblNetRateInspectionInfoRowChangeEvent((dsNetRateInspect.tblNetRateInspectionInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateInspectionInfoRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNetRateInspect.tblNetRateInspectionInfoRowChangeEventHandler rowChangingEvent = this.tblNetRateInspectionInfoRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsNetRateInspect.tblNetRateInspectionInfoRowChangeEvent((dsNetRateInspect.tblNetRateInspectionInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateInspectionInfoRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNetRateInspect.tblNetRateInspectionInfoRowChangeEventHandler infoRowDeletedEvent = this.tblNetRateInspectionInfoRowDeletedEvent;
      if (infoRowDeletedEvent == null)
        return;
      infoRowDeletedEvent((object) this, new dsNetRateInspect.tblNetRateInspectionInfoRowChangeEvent((dsNetRateInspect.tblNetRateInspectionInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateInspectionInfoRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNetRateInspect.tblNetRateInspectionInfoRowChangeEventHandler rowDeletingEvent = this.tblNetRateInspectionInfoRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsNetRateInspect.tblNetRateInspectionInfoRowChangeEvent((dsNetRateInspect.tblNetRateInspectionInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblNetRateInspectionInfoRow(dsNetRateInspect.tblNetRateInspectionInfoRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNetRateInspect dsNetRateInspect = new dsNetRateInspect();
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
        FixedValue = dsNetRateInspect.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblNetRateInspectionInfoDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsNetRateInspect.GetSchemaSerializable();
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

  public class tblNetRateInspectionInfoRow : DataRow
  {
    private dsNetRateInspect.tblNetRateInspectionInfoDataTable tabletblNetRateInspectionInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblNetRateInspectionInfoRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblNetRateInspectionInfo = (dsNetRateInspect.tblNetRateInspectionInfoDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ControlNo
    {
      get => Conversions.ToInteger(this[this.tabletblNetRateInspectionInfo.ControlNoColumn]);
      set => this[this.tabletblNetRateInspectionInfo.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabletblNetRateInspectionInfo.LocationIDColumn]);
      set => this[this.tabletblNetRateInspectionInfo.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int PremesisID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNetRateInspectionInfo.PremesisIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PremesisID' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.PremesisIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ExposureID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNetRateInspectionInfo.ExposureIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExposureID' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.ExposureIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool CostEstimation
    {
      get => Conversions.ToBoolean(this[this.tabletblNetRateInspectionInfo.CostEstimationColumn]);
      set => this[this.tabletblNetRateInspectionInfo.CostEstimationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Photo
    {
      get => Conversions.ToBoolean(this[this.tabletblNetRateInspectionInfo.PhotoColumn]);
      set => this[this.tabletblNetRateInspectionInfo.PhotoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Diagram
    {
      get => Conversions.ToBoolean(this[this.tabletblNetRateInspectionInfo.DiagramColumn]);
      set => this[this.tabletblNetRateInspectionInfo.DiagramColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LocationContact
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateInspectionInfo.LocationContactColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationContact' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.LocationContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ContactPhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateInspectionInfo.ContactPhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ContactPhone' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.ContactPhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SpecialInstructions
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateInspectionInfo.SpecialInstructionsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SpecialInstructions' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.SpecialInstructionsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateInspectionInfo.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address1' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateInspectionInfo.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address2' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateInspectionInfo.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateInspectionInfo.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Zip
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateInspectionInfo.ZipColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Zip' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SIC
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateInspectionInfo.SICColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SIC' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.SICColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int InspectionCompanyID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblNetRateInspectionInfo.InspectionCompanyIDColumn]);
      }
      set => this[this.tabletblNetRateInspectionInfo.InspectionCompanyIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateInspected
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblNetRateInspectionInfo.DateInspectedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateInspected' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.DateInspectedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNetRateInspectionInfo.QuoteIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteID' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte InspectionMethod
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabletblNetRateInspectionInfo.InspectionMethodColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InspectionMethod' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.InspectionMethodColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int WorkersCompID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNetRateInspectionInfo.WorkersCompIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WorkersCompID' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.WorkersCompIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPremesisIDNull()
    {
      return this.IsNull(this.tabletblNetRateInspectionInfo.PremesisIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPremesisIDNull()
    {
      this[this.tabletblNetRateInspectionInfo.PremesisIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExposureIDNull()
    {
      return this.IsNull(this.tabletblNetRateInspectionInfo.ExposureIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExposureIDNull()
    {
      this[this.tabletblNetRateInspectionInfo.ExposureIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocationContactNull()
    {
      return this.IsNull(this.tabletblNetRateInspectionInfo.LocationContactColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocationContactNull()
    {
      this[this.tabletblNetRateInspectionInfo.LocationContactColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsContactPhoneNull()
    {
      return this.IsNull(this.tabletblNetRateInspectionInfo.ContactPhoneColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetContactPhoneNull()
    {
      this[this.tabletblNetRateInspectionInfo.ContactPhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSpecialInstructionsNull()
    {
      return this.IsNull(this.tabletblNetRateInspectionInfo.SpecialInstructionsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSpecialInstructionsNull()
    {
      this[this.tabletblNetRateInspectionInfo.SpecialInstructionsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAddress1Null() => this.IsNull(this.tabletblNetRateInspectionInfo.Address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabletblNetRateInspectionInfo.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAddress2Null() => this.IsNull(this.tabletblNetRateInspectionInfo.Address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabletblNetRateInspectionInfo.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabletblNetRateInspectionInfo.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabletblNetRateInspectionInfo.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabletblNetRateInspectionInfo.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabletblNetRateInspectionInfo.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsZipNull() => this.IsNull(this.tabletblNetRateInspectionInfo.ZipColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetZipNull()
    {
      this[this.tabletblNetRateInspectionInfo.ZipColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSICNull() => this.IsNull(this.tabletblNetRateInspectionInfo.SICColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSICNull()
    {
      this[this.tabletblNetRateInspectionInfo.SICColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDateInspectedNull()
    {
      return this.IsNull(this.tabletblNetRateInspectionInfo.DateInspectedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDateInspectedNull()
    {
      this[this.tabletblNetRateInspectionInfo.DateInspectedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsQuoteIDNull() => this.IsNull(this.tabletblNetRateInspectionInfo.QuoteIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetQuoteIDNull()
    {
      this[this.tabletblNetRateInspectionInfo.QuoteIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInspectionMethodNull()
    {
      return this.IsNull(this.tabletblNetRateInspectionInfo.InspectionMethodColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInspectionMethodNull()
    {
      this[this.tabletblNetRateInspectionInfo.InspectionMethodColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsWorkersCompIDNull()
    {
      return this.IsNull(this.tabletblNetRateInspectionInfo.WorkersCompIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetWorkersCompIDNull()
    {
      this[this.tabletblNetRateInspectionInfo.WorkersCompIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblNetRateInspectionInfoRowChangeEvent : EventArgs
  {
    private dsNetRateInspect.tblNetRateInspectionInfoRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblNetRateInspectionInfoRowChangeEvent(
      dsNetRateInspect.tblNetRateInspectionInfoRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsNetRateInspect.tblNetRateInspectionInfoRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
