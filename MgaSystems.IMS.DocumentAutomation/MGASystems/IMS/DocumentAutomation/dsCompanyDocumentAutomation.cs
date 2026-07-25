// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.dsCompanyDocumentAutomation
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
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
namespace MGASystems.IMS.DocumentAutomation;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCompanyDocumentAutomation")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyDocumentAutomation : DataSet
{
  private dsCompanyDocumentAutomation.EventDocumentsDataTable tableEventDocuments;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsCompanyDocumentAutomation()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected dsCompanyDocumentAutomation(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (EventDocuments)] != null)
          base.Tables.Add((DataTable) new dsCompanyDocumentAutomation.EventDocumentsDataTable(dataSet.Tables[nameof (EventDocuments)]));
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
  public dsCompanyDocumentAutomation.EventDocumentsDataTable EventDocuments
  {
    get => this.tableEventDocuments;
  }

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
    dsCompanyDocumentAutomation documentAutomation = (dsCompanyDocumentAutomation) base.Clone();
    documentAutomation.InitVars();
    documentAutomation.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) documentAutomation;
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
      if (dataSet.Tables["EventDocuments"] != null)
        base.Tables.Add((DataTable) new dsCompanyDocumentAutomation.EventDocumentsDataTable(dataSet.Tables["EventDocuments"]));
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
    this.tableEventDocuments = (dsCompanyDocumentAutomation.EventDocumentsDataTable) base.Tables["EventDocuments"];
    if (!initTable || this.tableEventDocuments == null)
      return;
    this.tableEventDocuments.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyDocumentAutomation);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsCompanyDocumentAutomation.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableEventDocuments = new dsCompanyDocumentAutomation.EventDocumentsDataTable();
    base.Tables.Add((DataTable) this.tableEventDocuments);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeEventDocuments() => false;

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
    dsCompanyDocumentAutomation documentAutomation = new dsCompanyDocumentAutomation();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = documentAutomation.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = documentAutomation.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void EventDocumentsRowChangeEventHandler(
    object sender,
    dsCompanyDocumentAutomation.EventDocumentsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class EventDocumentsDataTable : 
    TypedTableBase<dsCompanyDocumentAutomation.EventDocumentsRow>
  {
    private DataColumn columnTemplateID;
    private DataColumn columnAutomationReportGuid;
    private DataColumn columnDocumentOrder;
    private DataColumn columnPDF;
    private DataColumn columnIncludeWithQuotation;
    private DataColumn columnID;
    private DataColumn columnOncePer;
    private DataColumn columnEndorsementNum;
    private DataColumn columnCompanyLineID;
    private DataColumn columnPolicyFormID;
    internal Lazy<bool> UseEventOncePer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public EventDocumentsDataTable()
    {
      Func<bool> valueFactory;
      // ISSUE: reference to a compiler-generated field
      if (dsCompanyDocumentAutomation.EventDocumentsDataTable._Closure\u0024__.\u0024I10\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        valueFactory = dsCompanyDocumentAutomation.EventDocumentsDataTable._Closure\u0024__.\u0024I10\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        dsCompanyDocumentAutomation.EventDocumentsDataTable._Closure\u0024__.\u0024I10\u002D0 = valueFactory = (Func<bool>) ([SpecialName] () => SystemSettings.GetSetting<bool>("DocumentAutomation.EventOncePer", false));
      }
      this.UseEventOncePer = new Lazy<bool>(valueFactory);
      this.TableName = "EventDocuments";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal EventDocumentsDataTable(DataTable table)
    {
      Func<bool> valueFactory;
      // ISSUE: reference to a compiler-generated field
      if (dsCompanyDocumentAutomation.EventDocumentsDataTable._Closure\u0024__.\u0024I11\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        valueFactory = dsCompanyDocumentAutomation.EventDocumentsDataTable._Closure\u0024__.\u0024I11\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        dsCompanyDocumentAutomation.EventDocumentsDataTable._Closure\u0024__.\u0024I11\u002D0 = valueFactory = (Func<bool>) ([SpecialName] () => SystemSettings.GetSetting<bool>("DocumentAutomation.EventOncePer", false));
      }
      this.UseEventOncePer = new Lazy<bool>(valueFactory);
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected EventDocumentsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      Func<bool> valueFactory;
      // ISSUE: reference to a compiler-generated field
      if (dsCompanyDocumentAutomation.EventDocumentsDataTable._Closure\u0024__.\u0024I12\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        valueFactory = dsCompanyDocumentAutomation.EventDocumentsDataTable._Closure\u0024__.\u0024I12\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        dsCompanyDocumentAutomation.EventDocumentsDataTable._Closure\u0024__.\u0024I12\u002D0 = valueFactory = (Func<bool>) ([SpecialName] () => SystemSettings.GetSetting<bool>("DocumentAutomation.EventOncePer", false));
      }
      this.UseEventOncePer = new Lazy<bool>(valueFactory);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TemplateIDColumn => this.columnTemplateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AutomationReportGuidColumn => this.columnAutomationReportGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DocumentOrderColumn => this.columnDocumentOrder;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PDFColumn => this.columnPDF;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IncludeWithQuotationColumn => this.columnIncludeWithQuotation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OncePerColumn => this.columnOncePer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EndorsementNumColumn => this.columnEndorsementNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineIDColumn => this.columnCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyFormIDColumn => this.columnPolicyFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyDocumentAutomation.EventDocumentsRow this[int index]
    {
      get => (dsCompanyDocumentAutomation.EventDocumentsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyDocumentAutomation.EventDocumentsRowChangeEventHandler EventDocumentsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyDocumentAutomation.EventDocumentsRowChangeEventHandler EventDocumentsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyDocumentAutomation.EventDocumentsRowChangeEventHandler EventDocumentsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyDocumentAutomation.EventDocumentsRowChangeEventHandler EventDocumentsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddEventDocumentsRow(dsCompanyDocumentAutomation.EventDocumentsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyDocumentAutomation.EventDocumentsRow AddEventDocumentsRow(
      int TemplateID,
      Guid AutomationReportGuid,
      int DocumentOrder,
      byte[] PDF,
      bool IncludeWithQuotation,
      int ID,
      string OncePer,
      int EndorsementNum,
      int CompanyLineID,
      int PolicyFormID)
    {
      dsCompanyDocumentAutomation.EventDocumentsRow row = (dsCompanyDocumentAutomation.EventDocumentsRow) this.NewRow();
      object[] objArray = new object[10]
      {
        (object) TemplateID,
        (object) AutomationReportGuid,
        (object) DocumentOrder,
        (object) PDF,
        (object) IncludeWithQuotation,
        (object) ID,
        (object) OncePer,
        (object) EndorsementNum,
        (object) CompanyLineID,
        (object) PolicyFormID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyDocumentAutomation.EventDocumentsDataTable documentsDataTable = (dsCompanyDocumentAutomation.EventDocumentsDataTable) base.Clone();
      documentsDataTable.InitVars();
      return (DataTable) documentsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyDocumentAutomation.EventDocumentsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnTemplateID = this.Columns["TemplateID"];
      this.columnAutomationReportGuid = this.Columns["AutomationReportGuid"];
      this.columnDocumentOrder = this.Columns["DocumentOrder"];
      this.columnPDF = this.Columns["PDF"];
      this.columnIncludeWithQuotation = this.Columns["IncludeWithQuotation"];
      this.columnID = this.Columns["ID"];
      this.columnOncePer = this.Columns["OncePer"];
      this.columnEndorsementNum = this.Columns["EndorsementNum"];
      this.columnCompanyLineID = this.Columns["CompanyLineID"];
      this.columnPolicyFormID = this.Columns["PolicyFormID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnTemplateID = new DataColumn("TemplateID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateID);
      this.columnAutomationReportGuid = new DataColumn("AutomationReportGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationReportGuid);
      this.columnDocumentOrder = new DataColumn("DocumentOrder", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDocumentOrder);
      this.columnPDF = new DataColumn("PDF", typeof (byte[]), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPDF);
      this.columnIncludeWithQuotation = new DataColumn("IncludeWithQuotation", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIncludeWithQuotation);
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnOncePer = new DataColumn("OncePer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOncePer);
      this.columnEndorsementNum = new DataColumn("EndorsementNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementNum);
      this.columnCompanyLineID = new DataColumn("CompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineID);
      this.columnPolicyFormID = new DataColumn("PolicyFormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyFormID);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyDocumentAutomation.EventDocumentsRow NewEventDocumentsRow()
    {
      return (dsCompanyDocumentAutomation.EventDocumentsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyDocumentAutomation.EventDocumentsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyDocumentAutomation.EventDocumentsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EventDocumentsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyDocumentAutomation.EventDocumentsRowChangeEventHandler documentsRowChangedEvent = this.EventDocumentsRowChangedEvent;
      if (documentsRowChangedEvent == null)
        return;
      documentsRowChangedEvent((object) this, new dsCompanyDocumentAutomation.EventDocumentsRowChangeEvent((dsCompanyDocumentAutomation.EventDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EventDocumentsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyDocumentAutomation.EventDocumentsRowChangeEventHandler rowChangingEvent = this.EventDocumentsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyDocumentAutomation.EventDocumentsRowChangeEvent((dsCompanyDocumentAutomation.EventDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EventDocumentsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyDocumentAutomation.EventDocumentsRowChangeEventHandler documentsRowDeletedEvent = this.EventDocumentsRowDeletedEvent;
      if (documentsRowDeletedEvent == null)
        return;
      documentsRowDeletedEvent((object) this, new dsCompanyDocumentAutomation.EventDocumentsRowChangeEvent((dsCompanyDocumentAutomation.EventDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EventDocumentsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyDocumentAutomation.EventDocumentsRowChangeEventHandler rowDeletingEvent = this.EventDocumentsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyDocumentAutomation.EventDocumentsRowChangeEvent((dsCompanyDocumentAutomation.EventDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveEventDocumentsRow(dsCompanyDocumentAutomation.EventDocumentsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyDocumentAutomation documentAutomation = new dsCompanyDocumentAutomation();
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
        FixedValue = documentAutomation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (EventDocumentsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = documentAutomation.GetSchemaSerializable();
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

  public class EventDocumentsRow : DataRow
  {
    private dsCompanyDocumentAutomation.EventDocumentsDataTable tableEventDocuments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal EventDocumentsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableEventDocuments = (dsCompanyDocumentAutomation.EventDocumentsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int TemplateID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableEventDocuments.TemplateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TemplateID' in table 'EventDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEventDocuments.TemplateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid AutomationReportGuid
    {
      get
      {
        try
        {
          object obj = this[this.tableEventDocuments.AutomationReportGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AutomationReportGuid' in table 'EventDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEventDocuments.AutomationReportGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DocumentOrder
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableEventDocuments.DocumentOrderColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DocumentOrder' in table 'EventDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEventDocuments.DocumentOrderColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public byte[] PDF
    {
      get
      {
        try
        {
          return (byte[]) this[this.tableEventDocuments.PDFColumn];
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PDF' in table 'EventDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEventDocuments.PDFColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IncludeWithQuotation
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableEventDocuments.IncludeWithQuotationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IncludeWithQuotation' in table 'EventDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEventDocuments.IncludeWithQuotationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableEventDocuments.IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ID' in table 'EventDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEventDocuments.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string OncePer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableEventDocuments.OncePerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OncePer' in table 'EventDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEventDocuments.OncePerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int EndorsementNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableEventDocuments.EndorsementNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementNum' in table 'EventDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEventDocuments.EndorsementNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CompanyLineID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableEventDocuments.CompanyLineIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLineID' in table 'EventDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEventDocuments.CompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyFormID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableEventDocuments.PolicyFormIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyFormID' in table 'EventDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEventDocuments.PolicyFormIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTemplateIDNull() => this.IsNull(this.tableEventDocuments.TemplateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTemplateIDNull()
    {
      this[this.tableEventDocuments.TemplateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAutomationReportGuidNull()
    {
      return this.IsNull(this.tableEventDocuments.AutomationReportGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAutomationReportGuidNull()
    {
      this[this.tableEventDocuments.AutomationReportGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDocumentOrderNull() => this.IsNull(this.tableEventDocuments.DocumentOrderColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDocumentOrderNull()
    {
      this[this.tableEventDocuments.DocumentOrderColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPDFNull() => this.IsNull(this.tableEventDocuments.PDFColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPDFNull()
    {
      this[this.tableEventDocuments.PDFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsIncludeWithQuotationNull()
    {
      return this.IsNull(this.tableEventDocuments.IncludeWithQuotationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetIncludeWithQuotationNull()
    {
      this[this.tableEventDocuments.IncludeWithQuotationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsIDNull() => this.IsNull(this.tableEventDocuments.IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetIDNull()
    {
      this[this.tableEventDocuments.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOncePerNull() => this.IsNull(this.tableEventDocuments.OncePerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOncePerNull()
    {
      this[this.tableEventDocuments.OncePerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEndorsementNumNull()
    {
      return this.IsNull(this.tableEventDocuments.EndorsementNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEndorsementNumNull()
    {
      this[this.tableEventDocuments.EndorsementNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyLineIDNull() => this.IsNull(this.tableEventDocuments.CompanyLineIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyLineIDNull()
    {
      this[this.tableEventDocuments.CompanyLineIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyFormIDNull() => this.IsNull(this.tableEventDocuments.PolicyFormIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyFormIDNull()
    {
      this[this.tableEventDocuments.PolicyFormIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public object AutomationDocumentID
    {
      get
      {
        return this.IsTemplateIDNull() || !this.IsPDFNull() ? (this.IsAutomationReportGuidNull() ? (object) new MemoryStream(this.PDF) : (object) this.AutomationReportGuid) : (object) this.TemplateID;
      }
    }

    public bool HasConditionalID => ExtensionsMethods.FieldIsNull<int>((DataRow) this, "ID", 0) > 0;

    public string SafeOncePer
    {
      get
      {
        return !this.tableEventDocuments.UseEventOncePer.Value ? string.Empty : ExtensionsMethods.FieldIsNull<string>((DataRow) this, "OncePer", string.Empty);
      }
    }

    public int SafeEndorsementNum
    {
      get => ExtensionsMethods.FieldIsNull<int>((DataRow) this, "EndorsementNum", -1);
    }

    public int SafeCompanyLineID
    {
      get => ExtensionsMethods.FieldIsNull<int>((DataRow) this, "CompanyLineID", -1);
    }

    public int SafePolicyFormID
    {
      get => ExtensionsMethods.FieldIsNull<int>((DataRow) this, "PolicyFormID", -1);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class EventDocumentsRowChangeEvent : EventArgs
  {
    private dsCompanyDocumentAutomation.EventDocumentsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public EventDocumentsRowChangeEvent(
      dsCompanyDocumentAutomation.EventDocumentsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyDocumentAutomation.EventDocumentsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
