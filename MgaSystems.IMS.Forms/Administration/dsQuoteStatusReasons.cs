// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Administration.dsQuoteStatusReasons
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

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
namespace MGASystems.IMS.Forms.Administration;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsQuoteStatusReasons")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsQuoteStatusReasons : DataSet
{
  private dsQuoteStatusReasons.lstQuoteStatusReasonsDataTable tablelstQuoteStatusReasons;
  private dsQuoteStatusReasons.lstQuoteStatusDataTable tablelstQuoteStatus;
  private dsQuoteStatusReasons.lstLinesDataTable tablelstLines;
  private dsQuoteStatusReasons.lstLineGroupsDataTable tablelstLineGroups;
  private dsQuoteStatusReasons.lstAutomationDocumentEventsDataTable tablelstAutomationDocumentEvents;
  private DataRelation relationlstQuoteStatuslstQuoteStatusReasons;
  private DataRelation relationlstLines_lstQuoteStatusReasons;
  private DataRelation relationlstLineGroups_lstQuoteStatusReasons;
  private DataRelation relationlstAutomationDocumentEvents_lstQuoteStatusReasons;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsQuoteStatusReasons()
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
  protected dsQuoteStatusReasons(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstQuoteStatusReasons)] != null)
          base.Tables.Add((DataTable) new dsQuoteStatusReasons.lstQuoteStatusReasonsDataTable(dataSet.Tables[nameof (lstQuoteStatusReasons)]));
        if (dataSet.Tables[nameof (lstQuoteStatus)] != null)
          base.Tables.Add((DataTable) new dsQuoteStatusReasons.lstQuoteStatusDataTable(dataSet.Tables[nameof (lstQuoteStatus)]));
        if (dataSet.Tables[nameof (lstLines)] != null)
          base.Tables.Add((DataTable) new dsQuoteStatusReasons.lstLinesDataTable(dataSet.Tables[nameof (lstLines)]));
        if (dataSet.Tables[nameof (lstLineGroups)] != null)
          base.Tables.Add((DataTable) new dsQuoteStatusReasons.lstLineGroupsDataTable(dataSet.Tables[nameof (lstLineGroups)]));
        if (dataSet.Tables[nameof (lstAutomationDocumentEvents)] != null)
          base.Tables.Add((DataTable) new dsQuoteStatusReasons.lstAutomationDocumentEventsDataTable(dataSet.Tables[nameof (lstAutomationDocumentEvents)]));
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
  public dsQuoteStatusReasons.lstQuoteStatusReasonsDataTable lstQuoteStatusReasons
  {
    get => this.tablelstQuoteStatusReasons;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteStatusReasons.lstQuoteStatusDataTable lstQuoteStatus => this.tablelstQuoteStatus;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteStatusReasons.lstLinesDataTable lstLines => this.tablelstLines;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteStatusReasons.lstLineGroupsDataTable lstLineGroups => this.tablelstLineGroups;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteStatusReasons.lstAutomationDocumentEventsDataTable lstAutomationDocumentEvents
  {
    get => this.tablelstAutomationDocumentEvents;
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
    dsQuoteStatusReasons quoteStatusReasons = (dsQuoteStatusReasons) base.Clone();
    quoteStatusReasons.InitVars();
    quoteStatusReasons.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) quoteStatusReasons;
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
      if (dataSet.Tables["lstQuoteStatusReasons"] != null)
        base.Tables.Add((DataTable) new dsQuoteStatusReasons.lstQuoteStatusReasonsDataTable(dataSet.Tables["lstQuoteStatusReasons"]));
      if (dataSet.Tables["lstQuoteStatus"] != null)
        base.Tables.Add((DataTable) new dsQuoteStatusReasons.lstQuoteStatusDataTable(dataSet.Tables["lstQuoteStatus"]));
      if (dataSet.Tables["lstLines"] != null)
        base.Tables.Add((DataTable) new dsQuoteStatusReasons.lstLinesDataTable(dataSet.Tables["lstLines"]));
      if (dataSet.Tables["lstLineGroups"] != null)
        base.Tables.Add((DataTable) new dsQuoteStatusReasons.lstLineGroupsDataTable(dataSet.Tables["lstLineGroups"]));
      if (dataSet.Tables["lstAutomationDocumentEvents"] != null)
        base.Tables.Add((DataTable) new dsQuoteStatusReasons.lstAutomationDocumentEventsDataTable(dataSet.Tables["lstAutomationDocumentEvents"]));
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
    this.tablelstQuoteStatusReasons = (dsQuoteStatusReasons.lstQuoteStatusReasonsDataTable) base.Tables["lstQuoteStatusReasons"];
    if (initTable && this.tablelstQuoteStatusReasons != null)
      this.tablelstQuoteStatusReasons.InitVars();
    this.tablelstQuoteStatus = (dsQuoteStatusReasons.lstQuoteStatusDataTable) base.Tables["lstQuoteStatus"];
    if (initTable && this.tablelstQuoteStatus != null)
      this.tablelstQuoteStatus.InitVars();
    this.tablelstLines = (dsQuoteStatusReasons.lstLinesDataTable) base.Tables["lstLines"];
    if (initTable && this.tablelstLines != null)
      this.tablelstLines.InitVars();
    this.tablelstLineGroups = (dsQuoteStatusReasons.lstLineGroupsDataTable) base.Tables["lstLineGroups"];
    if (initTable && this.tablelstLineGroups != null)
      this.tablelstLineGroups.InitVars();
    this.tablelstAutomationDocumentEvents = (dsQuoteStatusReasons.lstAutomationDocumentEventsDataTable) base.Tables["lstAutomationDocumentEvents"];
    if (initTable && this.tablelstAutomationDocumentEvents != null)
      this.tablelstAutomationDocumentEvents.InitVars();
    this.relationlstQuoteStatuslstQuoteStatusReasons = this.Relations["lstQuoteStatuslstQuoteStatusReasons"];
    this.relationlstLines_lstQuoteStatusReasons = this.Relations["lstLines_lstQuoteStatusReasons"];
    this.relationlstLineGroups_lstQuoteStatusReasons = this.Relations["lstLineGroups_lstQuoteStatusReasons"];
    this.relationlstAutomationDocumentEvents_lstQuoteStatusReasons = this.Relations["lstAutomationDocumentEvents_lstQuoteStatusReasons"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsQuoteStatusReasons);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsQuoteStatusReasons.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstQuoteStatusReasons = new dsQuoteStatusReasons.lstQuoteStatusReasonsDataTable();
    base.Tables.Add((DataTable) this.tablelstQuoteStatusReasons);
    this.tablelstQuoteStatus = new dsQuoteStatusReasons.lstQuoteStatusDataTable();
    base.Tables.Add((DataTable) this.tablelstQuoteStatus);
    this.tablelstLines = new dsQuoteStatusReasons.lstLinesDataTable();
    base.Tables.Add((DataTable) this.tablelstLines);
    this.tablelstLineGroups = new dsQuoteStatusReasons.lstLineGroupsDataTable();
    base.Tables.Add((DataTable) this.tablelstLineGroups);
    this.tablelstAutomationDocumentEvents = new dsQuoteStatusReasons.lstAutomationDocumentEventsDataTable();
    base.Tables.Add((DataTable) this.tablelstAutomationDocumentEvents);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("lstQuoteStatuslstQuoteStatusReasons", new DataColumn[1]
    {
      this.tablelstQuoteStatus.QuoteStatusIDColumn
    }, new DataColumn[1]
    {
      this.tablelstQuoteStatusReasons.QuoteStatusIDColumn
    });
    this.tablelstQuoteStatusReasons.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationlstQuoteStatuslstQuoteStatusReasons = new DataRelation("lstQuoteStatuslstQuoteStatusReasons", new DataColumn[1]
    {
      this.tablelstQuoteStatus.QuoteStatusIDColumn
    }, new DataColumn[1]
    {
      this.tablelstQuoteStatusReasons.QuoteStatusIDColumn
    }, false);
    this.Relations.Add(this.relationlstQuoteStatuslstQuoteStatusReasons);
    this.relationlstLines_lstQuoteStatusReasons = new DataRelation("lstLines_lstQuoteStatusReasons", new DataColumn[1]
    {
      this.tablelstLines.LineGUIDColumn
    }, new DataColumn[1]
    {
      this.tablelstQuoteStatusReasons.LineGuidColumn
    }, false);
    this.Relations.Add(this.relationlstLines_lstQuoteStatusReasons);
    this.relationlstLineGroups_lstQuoteStatusReasons = new DataRelation("lstLineGroups_lstQuoteStatusReasons", new DataColumn[1]
    {
      this.tablelstLineGroups.GroupCodeColumn
    }, new DataColumn[1]
    {
      this.tablelstQuoteStatusReasons.GroupCodeColumn
    }, false);
    this.Relations.Add(this.relationlstLineGroups_lstQuoteStatusReasons);
    this.relationlstAutomationDocumentEvents_lstQuoteStatusReasons = new DataRelation("lstAutomationDocumentEvents_lstQuoteStatusReasons", new DataColumn[1]
    {
      this.tablelstAutomationDocumentEvents.EventGuidColumn
    }, new DataColumn[1]
    {
      this.tablelstQuoteStatusReasons.EventGuidColumn
    }, false);
    this.Relations.Add(this.relationlstAutomationDocumentEvents_lstQuoteStatusReasons);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstQuoteStatusReasons() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstQuoteStatus() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstLines() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstLineGroups() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstAutomationDocumentEvents() => false;

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
    dsQuoteStatusReasons quoteStatusReasons = new dsQuoteStatusReasons();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = quoteStatusReasons.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = quoteStatusReasons.GetSchemaSerializable();
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
  public delegate void lstQuoteStatusReasonsRowChangeEventHandler(
    object sender,
    dsQuoteStatusReasons.lstQuoteStatusReasonsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstQuoteStatusRowChangeEventHandler(
    object sender,
    dsQuoteStatusReasons.lstQuoteStatusRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstLinesRowChangeEventHandler(
    object sender,
    dsQuoteStatusReasons.lstLinesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstLineGroupsRowChangeEventHandler(
    object sender,
    dsQuoteStatusReasons.lstLineGroupsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstAutomationDocumentEventsRowChangeEventHandler(
    object sender,
    dsQuoteStatusReasons.lstAutomationDocumentEventsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstQuoteStatusReasonsDataTable : 
    TypedTableBase<dsQuoteStatusReasons.lstQuoteStatusReasonsRow>
  {
    private DataColumn columnID;
    private DataColumn columnQuoteStatusID;
    private DataColumn columnReason;
    private DataColumn columnAutomationID;
    private DataColumn columnLineGuid;
    private DataColumn columnDisplayColor;
    private DataColumn columnEventGuid;
    private DataColumn columnGroupCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstQuoteStatusReasonsDataTable()
    {
      this.TableName = "lstQuoteStatusReasons";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstQuoteStatusReasonsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstQuoteStatusReasonsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteStatusIDColumn => this.columnQuoteStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ReasonColumn => this.columnReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AutomationIDColumn => this.columnAutomationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineGuidColumn => this.columnLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DisplayColorColumn => this.columnDisplayColor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EventGuidColumn => this.columnEventGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GroupCodeColumn => this.columnGroupCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstQuoteStatusReasonsRow this[int index]
    {
      get => (dsQuoteStatusReasons.lstQuoteStatusReasonsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstQuoteStatusReasonsRowChangeEventHandler lstQuoteStatusReasonsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstQuoteStatusReasonsRowChangeEventHandler lstQuoteStatusReasonsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstQuoteStatusReasonsRowChangeEventHandler lstQuoteStatusReasonsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstQuoteStatusReasonsRowChangeEventHandler lstQuoteStatusReasonsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstQuoteStatusReasonsRow(dsQuoteStatusReasons.lstQuoteStatusReasonsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstQuoteStatusReasonsRow AddlstQuoteStatusReasonsRow(
      dsQuoteStatusReasons.lstQuoteStatusRow parentlstQuoteStatusRowBylstQuoteStatuslstQuoteStatusReasons,
      string Reason,
      string AutomationID,
      dsQuoteStatusReasons.lstLinesRow parentlstLinesRowBylstLines_lstQuoteStatusReasons,
      int DisplayColor,
      dsQuoteStatusReasons.lstAutomationDocumentEventsRow parentlstAutomationDocumentEventsRowBylstAutomationDocumentEvents_lstQuoteStatusReasons,
      dsQuoteStatusReasons.lstLineGroupsRow parentlstLineGroupsRowBylstLineGroups_lstQuoteStatusReasons)
    {
      dsQuoteStatusReasons.lstQuoteStatusReasonsRow row = (dsQuoteStatusReasons.lstQuoteStatusReasonsRow) this.NewRow();
      object[] objArray1 = new object[8];
      objArray1[2] = (object) Reason;
      objArray1[3] = (object) AutomationID;
      objArray1[5] = (object) DisplayColor;
      object[] objArray2 = objArray1;
      if (parentlstQuoteStatusRowBylstQuoteStatuslstQuoteStatusReasons != null)
        objArray2[1] = RuntimeHelpers.GetObjectValue(parentlstQuoteStatusRowBylstQuoteStatuslstQuoteStatusReasons[0]);
      if (parentlstLinesRowBylstLines_lstQuoteStatusReasons != null)
        objArray2[4] = RuntimeHelpers.GetObjectValue(parentlstLinesRowBylstLines_lstQuoteStatusReasons[0]);
      if (parentlstAutomationDocumentEventsRowBylstAutomationDocumentEvents_lstQuoteStatusReasons != null)
        objArray2[6] = RuntimeHelpers.GetObjectValue(parentlstAutomationDocumentEventsRowBylstAutomationDocumentEvents_lstQuoteStatusReasons[0]);
      if (parentlstLineGroupsRowBylstLineGroups_lstQuoteStatusReasons != null)
        objArray2[7] = RuntimeHelpers.GetObjectValue(parentlstLineGroupsRowBylstLineGroups_lstQuoteStatusReasons[0]);
      row.ItemArray = objArray2;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstQuoteStatusReasonsRow FindByID(int ID)
    {
      return (dsQuoteStatusReasons.lstQuoteStatusReasonsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteStatusReasons.lstQuoteStatusReasonsDataTable reasonsDataTable = (dsQuoteStatusReasons.lstQuoteStatusReasonsDataTable) base.Clone();
      reasonsDataTable.InitVars();
      return (DataTable) reasonsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteStatusReasons.lstQuoteStatusReasonsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnQuoteStatusID = this.Columns["QuoteStatusID"];
      this.columnReason = this.Columns["Reason"];
      this.columnAutomationID = this.Columns["AutomationID"];
      this.columnLineGuid = this.Columns["LineGuid"];
      this.columnDisplayColor = this.Columns["DisplayColor"];
      this.columnEventGuid = this.Columns["EventGuid"];
      this.columnGroupCode = this.Columns["GroupCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnQuoteStatusID = new DataColumn("QuoteStatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatusID);
      this.columnReason = new DataColumn("Reason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReason);
      this.columnAutomationID = new DataColumn("AutomationID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationID);
      this.columnLineGuid = new DataColumn("LineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGuid);
      this.columnDisplayColor = new DataColumn("DisplayColor", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisplayColor);
      this.columnEventGuid = new DataColumn("EventGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEventGuid);
      this.columnGroupCode = new DataColumn("GroupCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGroupCode);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnQuoteStatusID.AllowDBNull = false;
      this.columnReason.AllowDBNull = false;
      this.columnReason.MaxLength = 250;
      this.columnDisplayColor.DefaultValue = (object) -16777216 /*0xFF000000*/;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstQuoteStatusReasonsRow NewlstQuoteStatusReasonsRow()
    {
      return (dsQuoteStatusReasons.lstQuoteStatusReasonsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteStatusReasons.lstQuoteStatusReasonsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteStatusReasons.lstQuoteStatusReasonsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusReasonsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstQuoteStatusReasonsRowChangeEventHandler reasonsRowChangedEvent = this.lstQuoteStatusReasonsRowChangedEvent;
      if (reasonsRowChangedEvent == null)
        return;
      reasonsRowChangedEvent((object) this, new dsQuoteStatusReasons.lstQuoteStatusReasonsRowChangeEvent((dsQuoteStatusReasons.lstQuoteStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusReasonsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstQuoteStatusReasonsRowChangeEventHandler rowChangingEvent = this.lstQuoteStatusReasonsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteStatusReasons.lstQuoteStatusReasonsRowChangeEvent((dsQuoteStatusReasons.lstQuoteStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusReasonsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstQuoteStatusReasonsRowChangeEventHandler reasonsRowDeletedEvent = this.lstQuoteStatusReasonsRowDeletedEvent;
      if (reasonsRowDeletedEvent == null)
        return;
      reasonsRowDeletedEvent((object) this, new dsQuoteStatusReasons.lstQuoteStatusReasonsRowChangeEvent((dsQuoteStatusReasons.lstQuoteStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusReasonsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstQuoteStatusReasonsRowChangeEventHandler rowDeletingEvent = this.lstQuoteStatusReasonsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteStatusReasons.lstQuoteStatusReasonsRowChangeEvent((dsQuoteStatusReasons.lstQuoteStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstQuoteStatusReasonsRow(dsQuoteStatusReasons.lstQuoteStatusReasonsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteStatusReasons quoteStatusReasons = new dsQuoteStatusReasons();
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
        FixedValue = quoteStatusReasons.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstQuoteStatusReasonsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = quoteStatusReasons.GetSchemaSerializable();
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
  public class lstQuoteStatusDataTable : TypedTableBase<dsQuoteStatusReasons.lstQuoteStatusRow>
  {
    private DataColumn columnQuoteStatusID;
    private DataColumn columnDescription;
    private DataColumn columnEventGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstQuoteStatusDataTable()
    {
      this.TableName = "lstQuoteStatus";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstQuoteStatusDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstQuoteStatusDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteStatusIDColumn => this.columnQuoteStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EventGuidColumn => this.columnEventGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstQuoteStatusRow this[int index]
    {
      get => (dsQuoteStatusReasons.lstQuoteStatusRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstQuoteStatusRowChangeEventHandler lstQuoteStatusRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstQuoteStatusRowChangeEventHandler lstQuoteStatusRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstQuoteStatusRowChangeEventHandler lstQuoteStatusRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstQuoteStatusRowChangeEventHandler lstQuoteStatusRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstQuoteStatusRow(dsQuoteStatusReasons.lstQuoteStatusRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstQuoteStatusRow AddlstQuoteStatusRow(
      int QuoteStatusID,
      string Description,
      Guid EventGuid)
    {
      dsQuoteStatusReasons.lstQuoteStatusRow row = (dsQuoteStatusReasons.lstQuoteStatusRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) QuoteStatusID,
        (object) Description,
        (object) EventGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstQuoteStatusRow FindByQuoteStatusID(int QuoteStatusID)
    {
      return (dsQuoteStatusReasons.lstQuoteStatusRow) this.Rows.Find(new object[1]
      {
        (object) QuoteStatusID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteStatusReasons.lstQuoteStatusDataTable quoteStatusDataTable = (dsQuoteStatusReasons.lstQuoteStatusDataTable) base.Clone();
      quoteStatusDataTable.InitVars();
      return (DataTable) quoteStatusDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteStatusReasons.lstQuoteStatusDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteStatusID = this.Columns["QuoteStatusID"];
      this.columnDescription = this.Columns["Description"];
      this.columnEventGuid = this.Columns["EventGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteStatusID = new DataColumn("QuoteStatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatusID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnEventGuid = new DataColumn("EventGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEventGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteStatusReasonsKey1", new DataColumn[1]
      {
        this.columnQuoteStatusID
      }, true));
      this.columnQuoteStatusID.AllowDBNull = false;
      this.columnQuoteStatusID.Unique = true;
      this.columnDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstQuoteStatusRow NewlstQuoteStatusRow()
    {
      return (dsQuoteStatusReasons.lstQuoteStatusRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteStatusReasons.lstQuoteStatusRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteStatusReasons.lstQuoteStatusRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstQuoteStatusRowChangeEventHandler statusRowChangedEvent = this.lstQuoteStatusRowChangedEvent;
      if (statusRowChangedEvent == null)
        return;
      statusRowChangedEvent((object) this, new dsQuoteStatusReasons.lstQuoteStatusRowChangeEvent((dsQuoteStatusReasons.lstQuoteStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstQuoteStatusRowChangeEventHandler rowChangingEvent = this.lstQuoteStatusRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteStatusReasons.lstQuoteStatusRowChangeEvent((dsQuoteStatusReasons.lstQuoteStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstQuoteStatusRowChangeEventHandler statusRowDeletedEvent = this.lstQuoteStatusRowDeletedEvent;
      if (statusRowDeletedEvent == null)
        return;
      statusRowDeletedEvent((object) this, new dsQuoteStatusReasons.lstQuoteStatusRowChangeEvent((dsQuoteStatusReasons.lstQuoteStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstQuoteStatusRowChangeEventHandler rowDeletingEvent = this.lstQuoteStatusRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteStatusReasons.lstQuoteStatusRowChangeEvent((dsQuoteStatusReasons.lstQuoteStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstQuoteStatusRow(dsQuoteStatusReasons.lstQuoteStatusRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteStatusReasons quoteStatusReasons = new dsQuoteStatusReasons();
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
        FixedValue = quoteStatusReasons.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstQuoteStatusDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = quoteStatusReasons.GetSchemaSerializable();
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
  public class lstLinesDataTable : TypedTableBase<dsQuoteStatusReasons.lstLinesRow>
  {
    private DataColumn columnLineGUID;
    private DataColumn columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstLinesDataTable()
    {
      this.TableName = "lstLines";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstLinesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstLinesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineGUIDColumn => this.columnLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstLinesRow this[int index]
    {
      get => (dsQuoteStatusReasons.lstLinesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstLinesRowChangeEventHandler lstLinesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstLinesRowChangeEventHandler lstLinesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstLinesRowChangeEventHandler lstLinesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstLinesRowChangeEventHandler lstLinesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstLinesRow(dsQuoteStatusReasons.lstLinesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstLinesRow AddlstLinesRow(Guid LineGUID, string LineName)
    {
      dsQuoteStatusReasons.lstLinesRow row = (dsQuoteStatusReasons.lstLinesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) LineGUID,
        (object) LineName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstLinesRow FindByLineGUID(Guid LineGUID)
    {
      return (dsQuoteStatusReasons.lstLinesRow) this.Rows.Find(new object[1]
      {
        (object) LineGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteStatusReasons.lstLinesDataTable lstLinesDataTable = (dsQuoteStatusReasons.lstLinesDataTable) base.Clone();
      lstLinesDataTable.InitVars();
      return (DataTable) lstLinesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteStatusReasons.lstLinesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnLineGUID = this.Columns["LineGUID"];
      this.columnLineName = this.Columns["LineName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnLineGUID = new DataColumn("LineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGUID);
      this.columnLineName = new DataColumn("LineName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnLineGUID
      }, true));
      this.columnLineGUID.AllowDBNull = false;
      this.columnLineGUID.Unique = true;
      this.columnLineName.AllowDBNull = false;
      this.columnLineName.MaxLength = 250;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstLinesRow NewlstLinesRow()
    {
      return (dsQuoteStatusReasons.lstLinesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteStatusReasons.lstLinesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteStatusReasons.lstLinesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstLinesRowChangeEventHandler linesRowChangedEvent = this.lstLinesRowChangedEvent;
      if (linesRowChangedEvent == null)
        return;
      linesRowChangedEvent((object) this, new dsQuoteStatusReasons.lstLinesRowChangeEvent((dsQuoteStatusReasons.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstLinesRowChangeEventHandler rowChangingEvent = this.lstLinesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteStatusReasons.lstLinesRowChangeEvent((dsQuoteStatusReasons.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstLinesRowChangeEventHandler linesRowDeletedEvent = this.lstLinesRowDeletedEvent;
      if (linesRowDeletedEvent == null)
        return;
      linesRowDeletedEvent((object) this, new dsQuoteStatusReasons.lstLinesRowChangeEvent((dsQuoteStatusReasons.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstLinesRowChangeEventHandler rowDeletingEvent = this.lstLinesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteStatusReasons.lstLinesRowChangeEvent((dsQuoteStatusReasons.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstLinesRow(dsQuoteStatusReasons.lstLinesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteStatusReasons quoteStatusReasons = new dsQuoteStatusReasons();
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
        FixedValue = quoteStatusReasons.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstLinesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = quoteStatusReasons.GetSchemaSerializable();
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
  public class lstLineGroupsDataTable : TypedTableBase<dsQuoteStatusReasons.lstLineGroupsRow>
  {
    private DataColumn columnGroupCode;
    private DataColumn columnGroupName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstLineGroupsDataTable()
    {
      this.TableName = "lstLineGroups";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstLineGroupsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstLineGroupsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GroupCodeColumn => this.columnGroupCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GroupNameColumn => this.columnGroupName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstLineGroupsRow this[int index]
    {
      get => (dsQuoteStatusReasons.lstLineGroupsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstLineGroupsRowChangeEventHandler lstLineGroupsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstLineGroupsRowChangeEventHandler lstLineGroupsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstLineGroupsRowChangeEventHandler lstLineGroupsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstLineGroupsRowChangeEventHandler lstLineGroupsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstLineGroupsRow(dsQuoteStatusReasons.lstLineGroupsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstLineGroupsRow AddlstLineGroupsRow(
      string GroupCode,
      string GroupName)
    {
      dsQuoteStatusReasons.lstLineGroupsRow row = (dsQuoteStatusReasons.lstLineGroupsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) GroupCode,
        (object) GroupName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteStatusReasons.lstLineGroupsDataTable lineGroupsDataTable = (dsQuoteStatusReasons.lstLineGroupsDataTable) base.Clone();
      lineGroupsDataTable.InitVars();
      return (DataTable) lineGroupsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteStatusReasons.lstLineGroupsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnGroupCode = this.Columns["GroupCode"];
      this.columnGroupName = this.Columns["GroupName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnGroupCode = new DataColumn("GroupCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGroupCode);
      this.columnGroupName = new DataColumn("GroupName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGroupName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnGroupCode
      }, false));
      this.columnGroupCode.AllowDBNull = false;
      this.columnGroupCode.Unique = true;
      this.columnGroupName.MaxLength = 100;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstLineGroupsRow NewlstLineGroupsRow()
    {
      return (dsQuoteStatusReasons.lstLineGroupsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteStatusReasons.lstLineGroupsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteStatusReasons.lstLineGroupsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLineGroupsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstLineGroupsRowChangeEventHandler groupsRowChangedEvent = this.lstLineGroupsRowChangedEvent;
      if (groupsRowChangedEvent == null)
        return;
      groupsRowChangedEvent((object) this, new dsQuoteStatusReasons.lstLineGroupsRowChangeEvent((dsQuoteStatusReasons.lstLineGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLineGroupsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstLineGroupsRowChangeEventHandler rowChangingEvent = this.lstLineGroupsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteStatusReasons.lstLineGroupsRowChangeEvent((dsQuoteStatusReasons.lstLineGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLineGroupsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstLineGroupsRowChangeEventHandler groupsRowDeletedEvent = this.lstLineGroupsRowDeletedEvent;
      if (groupsRowDeletedEvent == null)
        return;
      groupsRowDeletedEvent((object) this, new dsQuoteStatusReasons.lstLineGroupsRowChangeEvent((dsQuoteStatusReasons.lstLineGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLineGroupsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstLineGroupsRowChangeEventHandler rowDeletingEvent = this.lstLineGroupsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteStatusReasons.lstLineGroupsRowChangeEvent((dsQuoteStatusReasons.lstLineGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstLineGroupsRow(dsQuoteStatusReasons.lstLineGroupsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteStatusReasons quoteStatusReasons = new dsQuoteStatusReasons();
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
        FixedValue = quoteStatusReasons.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstLineGroupsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = quoteStatusReasons.GetSchemaSerializable();
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
  public class lstAutomationDocumentEventsDataTable : 
    TypedTableBase<dsQuoteStatusReasons.lstAutomationDocumentEventsRow>
  {
    private DataColumn columnEventGuid;
    private DataColumn columnEventName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstAutomationDocumentEventsDataTable()
    {
      this.TableName = "lstAutomationDocumentEvents";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstAutomationDocumentEventsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstAutomationDocumentEventsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EventGuidColumn => this.columnEventGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EventNameColumn => this.columnEventName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstAutomationDocumentEventsRow this[int index]
    {
      get => (dsQuoteStatusReasons.lstAutomationDocumentEventsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstAutomationDocumentEventsRowChangeEventHandler lstAutomationDocumentEventsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstAutomationDocumentEventsRowChangeEventHandler lstAutomationDocumentEventsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstAutomationDocumentEventsRowChangeEventHandler lstAutomationDocumentEventsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsQuoteStatusReasons.lstAutomationDocumentEventsRowChangeEventHandler lstAutomationDocumentEventsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstAutomationDocumentEventsRow(
      dsQuoteStatusReasons.lstAutomationDocumentEventsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstAutomationDocumentEventsRow AddlstAutomationDocumentEventsRow(
      Guid EventGuid,
      string EventName)
    {
      dsQuoteStatusReasons.lstAutomationDocumentEventsRow row = (dsQuoteStatusReasons.lstAutomationDocumentEventsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) EventGuid,
        (object) EventName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstAutomationDocumentEventsRow FindByEventGuid(Guid EventGuid)
    {
      return (dsQuoteStatusReasons.lstAutomationDocumentEventsRow) this.Rows.Find(new object[1]
      {
        (object) EventGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteStatusReasons.lstAutomationDocumentEventsDataTable documentEventsDataTable = (dsQuoteStatusReasons.lstAutomationDocumentEventsDataTable) base.Clone();
      documentEventsDataTable.InitVars();
      return (DataTable) documentEventsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteStatusReasons.lstAutomationDocumentEventsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnEventGuid = this.Columns["EventGuid"];
      this.columnEventName = this.Columns["EventName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnEventGuid = new DataColumn("EventGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEventGuid);
      this.columnEventName = new DataColumn("EventName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEventName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnEventGuid
      }, true));
      this.columnEventGuid.AllowDBNull = false;
      this.columnEventGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstAutomationDocumentEventsRow NewlstAutomationDocumentEventsRow()
    {
      return (dsQuoteStatusReasons.lstAutomationDocumentEventsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteStatusReasons.lstAutomationDocumentEventsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsQuoteStatusReasons.lstAutomationDocumentEventsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAutomationDocumentEventsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstAutomationDocumentEventsRowChangeEventHandler eventsRowChangedEvent = this.lstAutomationDocumentEventsRowChangedEvent;
      if (eventsRowChangedEvent == null)
        return;
      eventsRowChangedEvent((object) this, new dsQuoteStatusReasons.lstAutomationDocumentEventsRowChangeEvent((dsQuoteStatusReasons.lstAutomationDocumentEventsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAutomationDocumentEventsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstAutomationDocumentEventsRowChangeEventHandler rowChangingEvent = this.lstAutomationDocumentEventsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteStatusReasons.lstAutomationDocumentEventsRowChangeEvent((dsQuoteStatusReasons.lstAutomationDocumentEventsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAutomationDocumentEventsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstAutomationDocumentEventsRowChangeEventHandler eventsRowDeletedEvent = this.lstAutomationDocumentEventsRowDeletedEvent;
      if (eventsRowDeletedEvent == null)
        return;
      eventsRowDeletedEvent((object) this, new dsQuoteStatusReasons.lstAutomationDocumentEventsRowChangeEvent((dsQuoteStatusReasons.lstAutomationDocumentEventsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAutomationDocumentEventsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.lstAutomationDocumentEventsRowChangeEventHandler rowDeletingEvent = this.lstAutomationDocumentEventsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteStatusReasons.lstAutomationDocumentEventsRowChangeEvent((dsQuoteStatusReasons.lstAutomationDocumentEventsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstAutomationDocumentEventsRow(
      dsQuoteStatusReasons.lstAutomationDocumentEventsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteStatusReasons quoteStatusReasons = new dsQuoteStatusReasons();
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
        FixedValue = quoteStatusReasons.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstAutomationDocumentEventsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = quoteStatusReasons.GetSchemaSerializable();
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

  public class lstQuoteStatusReasonsRow : DataRow
  {
    private dsQuoteStatusReasons.lstQuoteStatusReasonsDataTable tablelstQuoteStatusReasons;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstQuoteStatusReasonsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstQuoteStatusReasons = (dsQuoteStatusReasons.lstQuoteStatusReasonsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstQuoteStatusReasons.IDColumn]);
      set => this[this.tablelstQuoteStatusReasons.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int QuoteStatusID
    {
      get => Conversions.ToInteger(this[this.tablelstQuoteStatusReasons.QuoteStatusIDColumn]);
      set => this[this.tablelstQuoteStatusReasons.QuoteStatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Reason
    {
      get => Conversions.ToString(this[this.tablelstQuoteStatusReasons.ReasonColumn]);
      set => this[this.tablelstQuoteStatusReasons.ReasonColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AutomationID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstQuoteStatusReasons.AutomationIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AutomationID' in table 'lstQuoteStatusReasons' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstQuoteStatusReasons.AutomationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid LineGuid
    {
      get
      {
        try
        {
          object obj = this[this.tablelstQuoteStatusReasons.LineGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LineGuid' in table 'lstQuoteStatusReasons' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstQuoteStatusReasons.LineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DisplayColor
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablelstQuoteStatusReasons.DisplayColorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DisplayColor' in table 'lstQuoteStatusReasons' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstQuoteStatusReasons.DisplayColorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid EventGuid
    {
      get
      {
        try
        {
          object obj = this[this.tablelstQuoteStatusReasons.EventGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EventGuid' in table 'lstQuoteStatusReasons' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstQuoteStatusReasons.EventGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string GroupCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstQuoteStatusReasons.GroupCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GroupCode' in table 'lstQuoteStatusReasons' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstQuoteStatusReasons.GroupCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstQuoteStatusRow lstQuoteStatusRow
    {
      get
      {
        return (dsQuoteStatusReasons.lstQuoteStatusRow) this.GetParentRow(this.Table.ParentRelations["lstQuoteStatuslstQuoteStatusReasons"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstQuoteStatuslstQuoteStatusReasons"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstLinesRow lstLinesRow
    {
      get
      {
        return (dsQuoteStatusReasons.lstLinesRow) this.GetParentRow(this.Table.ParentRelations["lstLines_lstQuoteStatusReasons"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstLines_lstQuoteStatusReasons"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstLineGroupsRow lstLineGroupsRow
    {
      get
      {
        return (dsQuoteStatusReasons.lstLineGroupsRow) this.GetParentRow(this.Table.ParentRelations["lstLineGroups_lstQuoteStatusReasons"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstLineGroups_lstQuoteStatusReasons"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstAutomationDocumentEventsRow lstAutomationDocumentEventsRow
    {
      get
      {
        return (dsQuoteStatusReasons.lstAutomationDocumentEventsRow) this.GetParentRow(this.Table.ParentRelations["lstAutomationDocumentEvents_lstQuoteStatusReasons"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstAutomationDocumentEvents_lstQuoteStatusReasons"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAutomationIDNull()
    {
      return this.IsNull(this.tablelstQuoteStatusReasons.AutomationIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAutomationIDNull()
    {
      this[this.tablelstQuoteStatusReasons.AutomationIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLineGuidNull() => this.IsNull(this.tablelstQuoteStatusReasons.LineGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLineGuidNull()
    {
      this[this.tablelstQuoteStatusReasons.LineGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDisplayColorNull()
    {
      return this.IsNull(this.tablelstQuoteStatusReasons.DisplayColorColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDisplayColorNull()
    {
      this[this.tablelstQuoteStatusReasons.DisplayColorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEventGuidNull() => this.IsNull(this.tablelstQuoteStatusReasons.EventGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEventGuidNull()
    {
      this[this.tablelstQuoteStatusReasons.EventGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGroupCodeNull() => this.IsNull(this.tablelstQuoteStatusReasons.GroupCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGroupCodeNull()
    {
      this[this.tablelstQuoteStatusReasons.GroupCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstQuoteStatusRow : DataRow
  {
    private dsQuoteStatusReasons.lstQuoteStatusDataTable tablelstQuoteStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstQuoteStatusRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstQuoteStatus = (dsQuoteStatusReasons.lstQuoteStatusDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int QuoteStatusID
    {
      get => Conversions.ToInteger(this[this.tablelstQuoteStatus.QuoteStatusIDColumn]);
      set => this[this.tablelstQuoteStatus.QuoteStatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstQuoteStatus.DescriptionColumn]);
      set => this[this.tablelstQuoteStatus.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid EventGuid
    {
      get
      {
        try
        {
          object obj = this[this.tablelstQuoteStatus.EventGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EventGuid' in table 'lstQuoteStatus' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstQuoteStatus.EventGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEventGuidNull() => this.IsNull(this.tablelstQuoteStatus.EventGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEventGuidNull()
    {
      this[this.tablelstQuoteStatus.EventGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstQuoteStatusReasonsRow[] GetlstQuoteStatusReasonsRows()
    {
      return this.Table.ChildRelations["lstQuoteStatuslstQuoteStatusReasons"] != null ? (dsQuoteStatusReasons.lstQuoteStatusReasonsRow[]) this.GetChildRows(this.Table.ChildRelations["lstQuoteStatuslstQuoteStatusReasons"]) : new dsQuoteStatusReasons.lstQuoteStatusReasonsRow[0];
    }
  }

  public class lstLinesRow : DataRow
  {
    private dsQuoteStatusReasons.lstLinesDataTable tablelstLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstLines = (dsQuoteStatusReasons.lstLinesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid LineGUID
    {
      get
      {
        object obj = this[this.tablelstLines.LineGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tablelstLines.LineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LineName
    {
      get => Conversions.ToString(this[this.tablelstLines.LineNameColumn]);
      set => this[this.tablelstLines.LineNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstQuoteStatusReasonsRow[] GetlstQuoteStatusReasonsRows()
    {
      return this.Table.ChildRelations["lstLines_lstQuoteStatusReasons"] != null ? (dsQuoteStatusReasons.lstQuoteStatusReasonsRow[]) this.GetChildRows(this.Table.ChildRelations["lstLines_lstQuoteStatusReasons"]) : new dsQuoteStatusReasons.lstQuoteStatusReasonsRow[0];
    }
  }

  public class lstLineGroupsRow : DataRow
  {
    private dsQuoteStatusReasons.lstLineGroupsDataTable tablelstLineGroups;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstLineGroupsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstLineGroups = (dsQuoteStatusReasons.lstLineGroupsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string GroupCode
    {
      get => Conversions.ToString(this[this.tablelstLineGroups.GroupCodeColumn]);
      set => this[this.tablelstLineGroups.GroupCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string GroupName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstLineGroups.GroupNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GroupName' in table 'lstLineGroups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstLineGroups.GroupNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGroupNameNull() => this.IsNull(this.tablelstLineGroups.GroupNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGroupNameNull()
    {
      this[this.tablelstLineGroups.GroupNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstQuoteStatusReasonsRow[] GetlstQuoteStatusReasonsRows()
    {
      return this.Table.ChildRelations["lstLineGroups_lstQuoteStatusReasons"] != null ? (dsQuoteStatusReasons.lstQuoteStatusReasonsRow[]) this.GetChildRows(this.Table.ChildRelations["lstLineGroups_lstQuoteStatusReasons"]) : new dsQuoteStatusReasons.lstQuoteStatusReasonsRow[0];
    }
  }

  public class lstAutomationDocumentEventsRow : DataRow
  {
    private dsQuoteStatusReasons.lstAutomationDocumentEventsDataTable tablelstAutomationDocumentEvents;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstAutomationDocumentEventsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstAutomationDocumentEvents = (dsQuoteStatusReasons.lstAutomationDocumentEventsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid EventGuid
    {
      get
      {
        object obj = this[this.tablelstAutomationDocumentEvents.EventGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tablelstAutomationDocumentEvents.EventGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EventName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstAutomationDocumentEvents.EventNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EventName' in table 'lstAutomationDocumentEvents' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstAutomationDocumentEvents.EventNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEventNameNull()
    {
      return this.IsNull(this.tablelstAutomationDocumentEvents.EventNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEventNameNull()
    {
      this[this.tablelstAutomationDocumentEvents.EventNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstQuoteStatusReasonsRow[] GetlstQuoteStatusReasonsRows()
    {
      return this.Table.ChildRelations["lstAutomationDocumentEvents_lstQuoteStatusReasons"] != null ? (dsQuoteStatusReasons.lstQuoteStatusReasonsRow[]) this.GetChildRows(this.Table.ChildRelations["lstAutomationDocumentEvents_lstQuoteStatusReasons"]) : new dsQuoteStatusReasons.lstQuoteStatusReasonsRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstQuoteStatusReasonsRowChangeEvent : EventArgs
  {
    private dsQuoteStatusReasons.lstQuoteStatusReasonsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstQuoteStatusReasonsRowChangeEvent(
      dsQuoteStatusReasons.lstQuoteStatusReasonsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstQuoteStatusReasonsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstQuoteStatusRowChangeEvent : EventArgs
  {
    private dsQuoteStatusReasons.lstQuoteStatusRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstQuoteStatusRowChangeEvent(
      dsQuoteStatusReasons.lstQuoteStatusRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstQuoteStatusRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstLinesRowChangeEvent : EventArgs
  {
    private dsQuoteStatusReasons.lstLinesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstLinesRowChangeEvent(dsQuoteStatusReasons.lstLinesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstLinesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstLineGroupsRowChangeEvent : EventArgs
  {
    private dsQuoteStatusReasons.lstLineGroupsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstLineGroupsRowChangeEvent(
      dsQuoteStatusReasons.lstLineGroupsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstLineGroupsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstAutomationDocumentEventsRowChangeEvent : EventArgs
  {
    private dsQuoteStatusReasons.lstAutomationDocumentEventsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstAutomationDocumentEventsRowChangeEvent(
      dsQuoteStatusReasons.lstAutomationDocumentEventsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsQuoteStatusReasons.lstAutomationDocumentEventsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
