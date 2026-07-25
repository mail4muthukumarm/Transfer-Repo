// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.dsDocumentAutomation
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

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
[XmlRoot("dsDocumentAutomation")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsDocumentAutomation : DataSet
{
  private dsDocumentAutomation.tblCompanyAutomationDocumentsDataTable tabletblCompanyAutomationDocuments;
  private dsDocumentAutomation.tblDocumentTemplatesDataTable tabletblDocumentTemplates;
  private dsDocumentAutomation.AvailableDocumentsDataTable tableAvailableDocuments;
  private dsDocumentAutomation.lstAutomationDocumentEventsDataTable tablelstAutomationDocumentEvents;
  private dsDocumentAutomation.lstDocumentAutomationGroupsDataTable tablelstDocumentAutomationGroups;
  private dsDocumentAutomation.AutomationReportsDataTable tableAutomationReports;
  private dsDocumentAutomation.tblDocumentFoldersDataTable tabletblDocumentFolders;
  private dsDocumentAutomation.lstQuoteStatusReasonsDataTable tablelstQuoteStatusReasons;
  private DataRelation relationtblDocumentFolderstblCompanyAutomationDocuments;
  private DataRelation relationlstAutomationDocumentEventstblCompanyAutomationDocuments;
  private DataRelation relationlstDocumentAutomationGroupstblDocumentTemplates;
  private DataRelation relationlstDocumentAutomationGroupslstAutomationDocumentEvents;
  private DataRelation relationlstDocumentAutomationGroupsAutomationReports;
  private DataRelation relationStatusReasons_tblCompanyAutomationDocuments;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsDocumentAutomation()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected dsDocumentAutomation(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyAutomationDocuments)] != null)
          base.Tables.Add((DataTable) new dsDocumentAutomation.tblCompanyAutomationDocumentsDataTable(dataSet.Tables[nameof (tblCompanyAutomationDocuments)]));
        if (dataSet.Tables[nameof (tblDocumentTemplates)] != null)
          base.Tables.Add((DataTable) new dsDocumentAutomation.tblDocumentTemplatesDataTable(dataSet.Tables[nameof (tblDocumentTemplates)]));
        if (dataSet.Tables[nameof (AvailableDocuments)] != null)
          base.Tables.Add((DataTable) new dsDocumentAutomation.AvailableDocumentsDataTable(dataSet.Tables[nameof (AvailableDocuments)]));
        if (dataSet.Tables[nameof (lstAutomationDocumentEvents)] != null)
          base.Tables.Add((DataTable) new dsDocumentAutomation.lstAutomationDocumentEventsDataTable(dataSet.Tables[nameof (lstAutomationDocumentEvents)]));
        if (dataSet.Tables[nameof (lstDocumentAutomationGroups)] != null)
          base.Tables.Add((DataTable) new dsDocumentAutomation.lstDocumentAutomationGroupsDataTable(dataSet.Tables[nameof (lstDocumentAutomationGroups)]));
        if (dataSet.Tables[nameof (AutomationReports)] != null)
          base.Tables.Add((DataTable) new dsDocumentAutomation.AutomationReportsDataTable(dataSet.Tables[nameof (AutomationReports)]));
        if (dataSet.Tables[nameof (tblDocumentFolders)] != null)
          base.Tables.Add((DataTable) new dsDocumentAutomation.tblDocumentFoldersDataTable(dataSet.Tables[nameof (tblDocumentFolders)]));
        if (dataSet.Tables[nameof (lstQuoteStatusReasons)] != null)
          base.Tables.Add((DataTable) new dsDocumentAutomation.lstQuoteStatusReasonsDataTable(dataSet.Tables[nameof (lstQuoteStatusReasons)]));
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
  public dsDocumentAutomation.tblCompanyAutomationDocumentsDataTable tblCompanyAutomationDocuments
  {
    get => this.tabletblCompanyAutomationDocuments;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDocumentAutomation.tblDocumentTemplatesDataTable tblDocumentTemplates
  {
    get => this.tabletblDocumentTemplates;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDocumentAutomation.AvailableDocumentsDataTable AvailableDocuments
  {
    get => this.tableAvailableDocuments;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDocumentAutomation.lstAutomationDocumentEventsDataTable lstAutomationDocumentEvents
  {
    get => this.tablelstAutomationDocumentEvents;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDocumentAutomation.lstDocumentAutomationGroupsDataTable lstDocumentAutomationGroups
  {
    get => this.tablelstDocumentAutomationGroups;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDocumentAutomation.AutomationReportsDataTable AutomationReports
  {
    get => this.tableAutomationReports;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDocumentAutomation.tblDocumentFoldersDataTable tblDocumentFolders
  {
    get => this.tabletblDocumentFolders;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDocumentAutomation.lstQuoteStatusReasonsDataTable lstQuoteStatusReasons
  {
    get => this.tablelstQuoteStatusReasons;
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
    dsDocumentAutomation documentAutomation = (dsDocumentAutomation) base.Clone();
    documentAutomation.InitVars();
    documentAutomation.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) documentAutomation;
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
      if (dataSet.Tables["tblCompanyAutomationDocuments"] != null)
        base.Tables.Add((DataTable) new dsDocumentAutomation.tblCompanyAutomationDocumentsDataTable(dataSet.Tables["tblCompanyAutomationDocuments"]));
      if (dataSet.Tables["tblDocumentTemplates"] != null)
        base.Tables.Add((DataTable) new dsDocumentAutomation.tblDocumentTemplatesDataTable(dataSet.Tables["tblDocumentTemplates"]));
      if (dataSet.Tables["AvailableDocuments"] != null)
        base.Tables.Add((DataTable) new dsDocumentAutomation.AvailableDocumentsDataTable(dataSet.Tables["AvailableDocuments"]));
      if (dataSet.Tables["lstAutomationDocumentEvents"] != null)
        base.Tables.Add((DataTable) new dsDocumentAutomation.lstAutomationDocumentEventsDataTable(dataSet.Tables["lstAutomationDocumentEvents"]));
      if (dataSet.Tables["lstDocumentAutomationGroups"] != null)
        base.Tables.Add((DataTable) new dsDocumentAutomation.lstDocumentAutomationGroupsDataTable(dataSet.Tables["lstDocumentAutomationGroups"]));
      if (dataSet.Tables["AutomationReports"] != null)
        base.Tables.Add((DataTable) new dsDocumentAutomation.AutomationReportsDataTable(dataSet.Tables["AutomationReports"]));
      if (dataSet.Tables["tblDocumentFolders"] != null)
        base.Tables.Add((DataTable) new dsDocumentAutomation.tblDocumentFoldersDataTable(dataSet.Tables["tblDocumentFolders"]));
      if (dataSet.Tables["lstQuoteStatusReasons"] != null)
        base.Tables.Add((DataTable) new dsDocumentAutomation.lstQuoteStatusReasonsDataTable(dataSet.Tables["lstQuoteStatusReasons"]));
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
    this.tabletblCompanyAutomationDocuments = (dsDocumentAutomation.tblCompanyAutomationDocumentsDataTable) base.Tables["tblCompanyAutomationDocuments"];
    if (initTable && this.tabletblCompanyAutomationDocuments != null)
      this.tabletblCompanyAutomationDocuments.InitVars();
    this.tabletblDocumentTemplates = (dsDocumentAutomation.tblDocumentTemplatesDataTable) base.Tables["tblDocumentTemplates"];
    if (initTable && this.tabletblDocumentTemplates != null)
      this.tabletblDocumentTemplates.InitVars();
    this.tableAvailableDocuments = (dsDocumentAutomation.AvailableDocumentsDataTable) base.Tables["AvailableDocuments"];
    if (initTable && this.tableAvailableDocuments != null)
      this.tableAvailableDocuments.InitVars();
    this.tablelstAutomationDocumentEvents = (dsDocumentAutomation.lstAutomationDocumentEventsDataTable) base.Tables["lstAutomationDocumentEvents"];
    if (initTable && this.tablelstAutomationDocumentEvents != null)
      this.tablelstAutomationDocumentEvents.InitVars();
    this.tablelstDocumentAutomationGroups = (dsDocumentAutomation.lstDocumentAutomationGroupsDataTable) base.Tables["lstDocumentAutomationGroups"];
    if (initTable && this.tablelstDocumentAutomationGroups != null)
      this.tablelstDocumentAutomationGroups.InitVars();
    this.tableAutomationReports = (dsDocumentAutomation.AutomationReportsDataTable) base.Tables["AutomationReports"];
    if (initTable && this.tableAutomationReports != null)
      this.tableAutomationReports.InitVars();
    this.tabletblDocumentFolders = (dsDocumentAutomation.tblDocumentFoldersDataTable) base.Tables["tblDocumentFolders"];
    if (initTable && this.tabletblDocumentFolders != null)
      this.tabletblDocumentFolders.InitVars();
    this.tablelstQuoteStatusReasons = (dsDocumentAutomation.lstQuoteStatusReasonsDataTable) base.Tables["lstQuoteStatusReasons"];
    if (initTable && this.tablelstQuoteStatusReasons != null)
      this.tablelstQuoteStatusReasons.InitVars();
    this.relationtblDocumentFolderstblCompanyAutomationDocuments = this.Relations["tblDocumentFolderstblCompanyAutomationDocuments"];
    this.relationlstAutomationDocumentEventstblCompanyAutomationDocuments = this.Relations["lstAutomationDocumentEventstblCompanyAutomationDocuments"];
    this.relationlstDocumentAutomationGroupstblDocumentTemplates = this.Relations["lstDocumentAutomationGroupstblDocumentTemplates"];
    this.relationlstDocumentAutomationGroupslstAutomationDocumentEvents = this.Relations["lstDocumentAutomationGroupslstAutomationDocumentEvents"];
    this.relationlstDocumentAutomationGroupsAutomationReports = this.Relations["lstDocumentAutomationGroupsAutomationReports"];
    this.relationStatusReasons_tblCompanyAutomationDocuments = this.Relations["StatusReasons_tblCompanyAutomationDocuments"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsDocumentAutomation);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsDocumentAutomation.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyAutomationDocuments = new dsDocumentAutomation.tblCompanyAutomationDocumentsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyAutomationDocuments);
    this.tabletblDocumentTemplates = new dsDocumentAutomation.tblDocumentTemplatesDataTable();
    base.Tables.Add((DataTable) this.tabletblDocumentTemplates);
    this.tableAvailableDocuments = new dsDocumentAutomation.AvailableDocumentsDataTable();
    base.Tables.Add((DataTable) this.tableAvailableDocuments);
    this.tablelstAutomationDocumentEvents = new dsDocumentAutomation.lstAutomationDocumentEventsDataTable();
    base.Tables.Add((DataTable) this.tablelstAutomationDocumentEvents);
    this.tablelstDocumentAutomationGroups = new dsDocumentAutomation.lstDocumentAutomationGroupsDataTable();
    base.Tables.Add((DataTable) this.tablelstDocumentAutomationGroups);
    this.tableAutomationReports = new dsDocumentAutomation.AutomationReportsDataTable();
    base.Tables.Add((DataTable) this.tableAutomationReports);
    this.tabletblDocumentFolders = new dsDocumentAutomation.tblDocumentFoldersDataTable();
    base.Tables.Add((DataTable) this.tabletblDocumentFolders);
    this.tablelstQuoteStatusReasons = new dsDocumentAutomation.lstQuoteStatusReasonsDataTable();
    base.Tables.Add((DataTable) this.tablelstQuoteStatusReasons);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("tblDocumentFolderstblCompanyAutomationDocuments", new DataColumn[1]
    {
      this.tabletblDocumentFolders.FolderIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyAutomationDocuments.FolderIDColumn
    });
    this.tabletblCompanyAutomationDocuments.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstAutomationDocumentEventstblCompanyAutomationDocuments", new DataColumn[1]
    {
      this.tablelstAutomationDocumentEvents.EventGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyAutomationDocuments.AutomationEventGuidColumn
    });
    this.tabletblCompanyAutomationDocuments.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("lstDocumentAutomationGroupstblDocumentTemplates", new DataColumn[1]
    {
      this.tablelstDocumentAutomationGroups.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblDocumentTemplates.AutomationGroupIDColumn
    });
    this.tabletblDocumentTemplates.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint4 = new ForeignKeyConstraint("lstDocumentAutomationGroupslstAutomationDocumentEvents", new DataColumn[1]
    {
      this.tablelstDocumentAutomationGroups.IDColumn
    }, new DataColumn[1]
    {
      this.tablelstAutomationDocumentEvents.DocumentAutomationGroupIDColumn
    });
    this.tablelstAutomationDocumentEvents.Constraints.Add((Constraint) foreignKeyConstraint4);
    foreignKeyConstraint4.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint4.DeleteRule = Rule.Cascade;
    foreignKeyConstraint4.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint5 = new ForeignKeyConstraint("lstDocumentAutomationGroupsAutomationReports", new DataColumn[1]
    {
      this.tablelstDocumentAutomationGroups.IDColumn
    }, new DataColumn[1]
    {
      this.tableAutomationReports.TemplateGroupIDColumn
    });
    this.tableAutomationReports.Constraints.Add((Constraint) foreignKeyConstraint5);
    foreignKeyConstraint5.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint5.DeleteRule = Rule.Cascade;
    foreignKeyConstraint5.UpdateRule = Rule.Cascade;
    this.relationtblDocumentFolderstblCompanyAutomationDocuments = new DataRelation("tblDocumentFolderstblCompanyAutomationDocuments", new DataColumn[1]
    {
      this.tabletblDocumentFolders.FolderIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyAutomationDocuments.FolderIDColumn
    }, false);
    this.Relations.Add(this.relationtblDocumentFolderstblCompanyAutomationDocuments);
    this.relationlstAutomationDocumentEventstblCompanyAutomationDocuments = new DataRelation("lstAutomationDocumentEventstblCompanyAutomationDocuments", new DataColumn[1]
    {
      this.tablelstAutomationDocumentEvents.EventGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyAutomationDocuments.AutomationEventGuidColumn
    }, false);
    this.Relations.Add(this.relationlstAutomationDocumentEventstblCompanyAutomationDocuments);
    this.relationlstDocumentAutomationGroupstblDocumentTemplates = new DataRelation("lstDocumentAutomationGroupstblDocumentTemplates", new DataColumn[1]
    {
      this.tablelstDocumentAutomationGroups.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblDocumentTemplates.AutomationGroupIDColumn
    }, false);
    this.Relations.Add(this.relationlstDocumentAutomationGroupstblDocumentTemplates);
    this.relationlstDocumentAutomationGroupslstAutomationDocumentEvents = new DataRelation("lstDocumentAutomationGroupslstAutomationDocumentEvents", new DataColumn[1]
    {
      this.tablelstDocumentAutomationGroups.IDColumn
    }, new DataColumn[1]
    {
      this.tablelstAutomationDocumentEvents.DocumentAutomationGroupIDColumn
    }, false);
    this.Relations.Add(this.relationlstDocumentAutomationGroupslstAutomationDocumentEvents);
    this.relationlstDocumentAutomationGroupsAutomationReports = new DataRelation("lstDocumentAutomationGroupsAutomationReports", new DataColumn[1]
    {
      this.tablelstDocumentAutomationGroups.IDColumn
    }, new DataColumn[1]
    {
      this.tableAutomationReports.TemplateGroupIDColumn
    }, false);
    this.Relations.Add(this.relationlstDocumentAutomationGroupsAutomationReports);
    this.relationStatusReasons_tblCompanyAutomationDocuments = new DataRelation("StatusReasons_tblCompanyAutomationDocuments", new DataColumn[1]
    {
      this.tablelstQuoteStatusReasons.QuoteStatusReasonIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyAutomationDocuments.QuoteStatusReasonIDColumn
    }, false);
    this.Relations.Add(this.relationStatusReasons_tblCompanyAutomationDocuments);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanyAutomationDocuments() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblDocumentTemplates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeAvailableDocuments() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstAutomationDocumentEvents() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstDocumentAutomationGroups() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeAutomationReports() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblDocumentFolders() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstQuoteStatusReasons() => false;

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
    dsDocumentAutomation documentAutomation = new dsDocumentAutomation();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblCompanyAutomationDocumentsRowChangeEventHandler(
    object sender,
    dsDocumentAutomation.tblCompanyAutomationDocumentsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblDocumentTemplatesRowChangeEventHandler(
    object sender,
    dsDocumentAutomation.tblDocumentTemplatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void AvailableDocumentsRowChangeEventHandler(
    object sender,
    dsDocumentAutomation.AvailableDocumentsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstAutomationDocumentEventsRowChangeEventHandler(
    object sender,
    dsDocumentAutomation.lstAutomationDocumentEventsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstDocumentAutomationGroupsRowChangeEventHandler(
    object sender,
    dsDocumentAutomation.lstDocumentAutomationGroupsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void AutomationReportsRowChangeEventHandler(
    object sender,
    dsDocumentAutomation.AutomationReportsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblDocumentFoldersRowChangeEventHandler(
    object sender,
    dsDocumentAutomation.tblDocumentFoldersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstQuoteStatusReasonsRowChangeEventHandler(
    object sender,
    dsDocumentAutomation.lstQuoteStatusReasonsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyAutomationDocumentsDataTable : 
    TypedTableBase<dsDocumentAutomation.tblCompanyAutomationDocumentsRow>
  {
    private DataColumn columnID;
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnAutomationReportGuid;
    private DataColumn columnTemplateID;
    private DataColumn columnDocumentOrder;
    private DataColumn columnAutomationEventGuid;
    private DataColumn columnDocumentName;
    private DataColumn columnDocumentType;
    private DataColumn columnFolderID;
    private DataColumn columnChangeFolder;
    private DataColumn columnQuoteStatusReasonID;
    private DataColumn columnConditional;
    private DataColumn columnDocumentDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyAutomationDocumentsDataTable()
    {
      this.TableName = "tblCompanyAutomationDocuments";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyAutomationDocumentsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected tblCompanyAutomationDocumentsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutomationReportGuidColumn => this.columnAutomationReportGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TemplateIDColumn => this.columnTemplateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DocumentOrderColumn => this.columnDocumentOrder;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutomationEventGuidColumn => this.columnAutomationEventGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DocumentNameColumn => this.columnDocumentName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DocumentTypeColumn => this.columnDocumentType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FolderIDColumn => this.columnFolderID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChangeFolderColumn => this.columnChangeFolder;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteStatusReasonIDColumn => this.columnQuoteStatusReasonID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ConditionalColumn => this.columnConditional;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DocumentDescriptionColumn => this.columnDocumentDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblCompanyAutomationDocumentsRow this[int index]
    {
      get => (dsDocumentAutomation.tblCompanyAutomationDocumentsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.tblCompanyAutomationDocumentsRowChangeEventHandler tblCompanyAutomationDocumentsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.tblCompanyAutomationDocumentsRowChangeEventHandler tblCompanyAutomationDocumentsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.tblCompanyAutomationDocumentsRowChangeEventHandler tblCompanyAutomationDocumentsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.tblCompanyAutomationDocumentsRowChangeEventHandler tblCompanyAutomationDocumentsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompanyAutomationDocumentsRow(
      dsDocumentAutomation.tblCompanyAutomationDocumentsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblCompanyAutomationDocumentsRow AddtblCompanyAutomationDocumentsRow(
      Guid CompanyLineGuid,
      Guid AutomationReportGuid,
      int TemplateID,
      int DocumentOrder,
      dsDocumentAutomation.lstAutomationDocumentEventsRow parentlstAutomationDocumentEventsRowBylstAutomationDocumentEventstblCompanyAutomationDocuments,
      string DocumentName,
      string DocumentType,
      dsDocumentAutomation.tblDocumentFoldersRow parenttblDocumentFoldersRowBytblDocumentFolderstblCompanyAutomationDocuments,
      string ChangeFolder,
      dsDocumentAutomation.lstQuoteStatusReasonsRow parentlstQuoteStatusReasonsRowByStatusReasons_tblCompanyAutomationDocuments,
      string Conditional,
      string DocumentDescription)
    {
      dsDocumentAutomation.tblCompanyAutomationDocumentsRow row = (dsDocumentAutomation.tblCompanyAutomationDocumentsRow) this.NewRow();
      object[] objArray = new object[13]
      {
        null,
        (object) CompanyLineGuid,
        (object) AutomationReportGuid,
        (object) TemplateID,
        (object) DocumentOrder,
        null,
        (object) DocumentName,
        (object) DocumentType,
        null,
        (object) ChangeFolder,
        null,
        (object) Conditional,
        (object) DocumentDescription
      };
      if (parentlstAutomationDocumentEventsRowBylstAutomationDocumentEventstblCompanyAutomationDocuments != null)
        objArray[5] = RuntimeHelpers.GetObjectValue(parentlstAutomationDocumentEventsRowBylstAutomationDocumentEventstblCompanyAutomationDocuments[0]);
      if (parenttblDocumentFoldersRowBytblDocumentFolderstblCompanyAutomationDocuments != null)
        objArray[8] = RuntimeHelpers.GetObjectValue(parenttblDocumentFoldersRowBytblDocumentFolderstblCompanyAutomationDocuments[0]);
      if (parentlstQuoteStatusReasonsRowByStatusReasons_tblCompanyAutomationDocuments != null)
        objArray[10] = RuntimeHelpers.GetObjectValue(parentlstQuoteStatusReasonsRowByStatusReasons_tblCompanyAutomationDocuments[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblCompanyAutomationDocumentsRow FindByID(int ID)
    {
      return (dsDocumentAutomation.tblCompanyAutomationDocumentsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsDocumentAutomation.tblCompanyAutomationDocumentsDataTable documentsDataTable = (dsDocumentAutomation.tblCompanyAutomationDocumentsDataTable) base.Clone();
      documentsDataTable.InitVars();
      return (DataTable) documentsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDocumentAutomation.tblCompanyAutomationDocumentsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnAutomationReportGuid = this.Columns["AutomationReportGuid"];
      this.columnTemplateID = this.Columns["TemplateID"];
      this.columnDocumentOrder = this.Columns["DocumentOrder"];
      this.columnAutomationEventGuid = this.Columns["AutomationEventGuid"];
      this.columnDocumentName = this.Columns["DocumentName"];
      this.columnDocumentType = this.Columns["DocumentType"];
      this.columnFolderID = this.Columns["FolderID"];
      this.columnChangeFolder = this.Columns["ChangeFolder"];
      this.columnQuoteStatusReasonID = this.Columns["QuoteStatusReasonID"];
      this.columnConditional = this.Columns["Conditional"];
      this.columnDocumentDescription = this.Columns["DocumentDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnAutomationReportGuid = new DataColumn("AutomationReportGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationReportGuid);
      this.columnTemplateID = new DataColumn("TemplateID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateID);
      this.columnDocumentOrder = new DataColumn("DocumentOrder", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDocumentOrder);
      this.columnAutomationEventGuid = new DataColumn("AutomationEventGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationEventGuid);
      this.columnDocumentName = new DataColumn("DocumentName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDocumentName);
      this.columnDocumentType = new DataColumn("DocumentType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDocumentType);
      this.columnFolderID = new DataColumn("FolderID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFolderID);
      this.columnChangeFolder = new DataColumn("ChangeFolder", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChangeFolder);
      this.columnQuoteStatusReasonID = new DataColumn("QuoteStatusReasonID", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatusReasonID);
      this.columnConditional = new DataColumn("Conditional", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConditional);
      this.columnDocumentDescription = new DataColumn("DocumentDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDocumentDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("tblCompanyAutomationDocumentsKey1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnCompanyLineGuid.AllowDBNull = false;
      this.columnDocumentOrder.AllowDBNull = false;
      this.columnAutomationEventGuid.AllowDBNull = false;
      this.columnDocumentType.AllowDBNull = false;
      this.columnChangeFolder.AllowDBNull = false;
      this.columnChangeFolder.DefaultValue = (object) "Change Folder";
      this.columnConditional.AllowDBNull = false;
      this.columnConditional.DefaultValue = (object) "";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblCompanyAutomationDocumentsRow NewtblCompanyAutomationDocumentsRow()
    {
      return (dsDocumentAutomation.tblCompanyAutomationDocumentsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDocumentAutomation.tblCompanyAutomationDocumentsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsDocumentAutomation.tblCompanyAutomationDocumentsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyAutomationDocumentsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.tblCompanyAutomationDocumentsRowChangeEventHandler documentsRowChangedEvent = this.tblCompanyAutomationDocumentsRowChangedEvent;
      if (documentsRowChangedEvent == null)
        return;
      documentsRowChangedEvent((object) this, new dsDocumentAutomation.tblCompanyAutomationDocumentsRowChangeEvent((dsDocumentAutomation.tblCompanyAutomationDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyAutomationDocumentsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.tblCompanyAutomationDocumentsRowChangeEventHandler rowChangingEvent = this.tblCompanyAutomationDocumentsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDocumentAutomation.tblCompanyAutomationDocumentsRowChangeEvent((dsDocumentAutomation.tblCompanyAutomationDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyAutomationDocumentsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.tblCompanyAutomationDocumentsRowChangeEventHandler documentsRowDeletedEvent = this.tblCompanyAutomationDocumentsRowDeletedEvent;
      if (documentsRowDeletedEvent == null)
        return;
      documentsRowDeletedEvent((object) this, new dsDocumentAutomation.tblCompanyAutomationDocumentsRowChangeEvent((dsDocumentAutomation.tblCompanyAutomationDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyAutomationDocumentsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.tblCompanyAutomationDocumentsRowChangeEventHandler rowDeletingEvent = this.tblCompanyAutomationDocumentsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDocumentAutomation.tblCompanyAutomationDocumentsRowChangeEvent((dsDocumentAutomation.tblCompanyAutomationDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompanyAutomationDocumentsRow(
      dsDocumentAutomation.tblCompanyAutomationDocumentsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDocumentAutomation documentAutomation = new dsDocumentAutomation();
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
        FixedValue = nameof (tblCompanyAutomationDocumentsDataTable)
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

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblDocumentTemplatesDataTable : 
    TypedTableBase<dsDocumentAutomation.tblDocumentTemplatesRow>
  {
    private DataColumn columnTemplateID;
    private DataColumn columnTemplateName;
    private DataColumn columnDescription;
    private DataColumn columnAutomationGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblDocumentTemplatesDataTable()
    {
      this.TableName = "tblDocumentTemplates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblDocumentTemplatesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected tblDocumentTemplatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TemplateIDColumn => this.columnTemplateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TemplateNameColumn => this.columnTemplateName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutomationGroupIDColumn => this.columnAutomationGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblDocumentTemplatesRow this[int index]
    {
      get => (dsDocumentAutomation.tblDocumentTemplatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblDocumentTemplatesRow(dsDocumentAutomation.tblDocumentTemplatesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblDocumentTemplatesRow AddtblDocumentTemplatesRow(
      string TemplateName,
      string Description,
      dsDocumentAutomation.lstDocumentAutomationGroupsRow parentlstDocumentAutomationGroupsRowBylstDocumentAutomationGroupstblDocumentTemplates)
    {
      dsDocumentAutomation.tblDocumentTemplatesRow row = (dsDocumentAutomation.tblDocumentTemplatesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        null,
        (object) TemplateName,
        (object) Description,
        null
      };
      if (parentlstDocumentAutomationGroupsRowBylstDocumentAutomationGroupstblDocumentTemplates != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parentlstDocumentAutomationGroupsRowBylstDocumentAutomationGroupstblDocumentTemplates[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblDocumentTemplatesRow FindByTemplateID(int TemplateID)
    {
      return (dsDocumentAutomation.tblDocumentTemplatesRow) this.Rows.Find(new object[1]
      {
        (object) TemplateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsDocumentAutomation.tblDocumentTemplatesDataTable templatesDataTable = (dsDocumentAutomation.tblDocumentTemplatesDataTable) base.Clone();
      templatesDataTable.InitVars();
      return (DataTable) templatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDocumentAutomation.tblDocumentTemplatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnTemplateID = this.Columns["TemplateID"];
      this.columnTemplateName = this.Columns["TemplateName"];
      this.columnDescription = this.Columns["Description"];
      this.columnAutomationGroupID = this.Columns["AutomationGroupID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnTemplateID = new DataColumn("TemplateID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateID);
      this.columnTemplateName = new DataColumn("TemplateName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateName);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnAutomationGroupID = new DataColumn("AutomationGroupID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationGroupID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsDocumentAutomationKey1", new DataColumn[1]
      {
        this.columnTemplateID
      }, true));
      this.columnTemplateID.AutoIncrement = true;
      this.columnTemplateID.AllowDBNull = false;
      this.columnTemplateID.ReadOnly = true;
      this.columnTemplateID.Unique = true;
      this.columnTemplateName.AllowDBNull = false;
      this.columnDescription.AllowDBNull = false;
      this.columnAutomationGroupID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblDocumentTemplatesRow NewtblDocumentTemplatesRow()
    {
      return (dsDocumentAutomation.tblDocumentTemplatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDocumentAutomation.tblDocumentTemplatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsDocumentAutomation.tblDocumentTemplatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.tblDocumentTemplatesRowChangeEventHandler templatesRowChangedEvent = this.tblDocumentTemplatesRowChangedEvent;
      if (templatesRowChangedEvent == null)
        return;
      templatesRowChangedEvent((object) this, new dsDocumentAutomation.tblDocumentTemplatesRowChangeEvent((dsDocumentAutomation.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.tblDocumentTemplatesRowChangeEventHandler rowChangingEvent = this.tblDocumentTemplatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDocumentAutomation.tblDocumentTemplatesRowChangeEvent((dsDocumentAutomation.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.tblDocumentTemplatesRowChangeEventHandler templatesRowDeletedEvent = this.tblDocumentTemplatesRowDeletedEvent;
      if (templatesRowDeletedEvent == null)
        return;
      templatesRowDeletedEvent((object) this, new dsDocumentAutomation.tblDocumentTemplatesRowChangeEvent((dsDocumentAutomation.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.tblDocumentTemplatesRowChangeEventHandler rowDeletingEvent = this.tblDocumentTemplatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDocumentAutomation.tblDocumentTemplatesRowChangeEvent((dsDocumentAutomation.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblDocumentTemplatesRow(dsDocumentAutomation.tblDocumentTemplatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDocumentAutomation documentAutomation = new dsDocumentAutomation();
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
        FixedValue = nameof (tblDocumentTemplatesDataTable)
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

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class AvailableDocumentsDataTable : 
    TypedTableBase<dsDocumentAutomation.AvailableDocumentsRow>
  {
    private DataColumn columnAutomationReportGuid;
    private DataColumn columnTemplateID;
    private DataColumn columnDocumentName;
    private DataColumn columnDocumentDescription;
    private DataColumn columnDocumentType;
    private DataColumn columnAdd;
    private DataColumn columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public AvailableDocumentsDataTable()
    {
      this.TableName = "AvailableDocuments";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal AvailableDocumentsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected AvailableDocumentsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutomationReportGuidColumn => this.columnAutomationReportGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TemplateIDColumn => this.columnTemplateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DocumentNameColumn => this.columnDocumentName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DocumentDescriptionColumn => this.columnDocumentDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DocumentTypeColumn => this.columnDocumentType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AddColumn => this.columnAdd;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.AvailableDocumentsRow this[int index]
    {
      get => (dsDocumentAutomation.AvailableDocumentsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.AvailableDocumentsRowChangeEventHandler AvailableDocumentsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.AvailableDocumentsRowChangeEventHandler AvailableDocumentsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.AvailableDocumentsRowChangeEventHandler AvailableDocumentsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.AvailableDocumentsRowChangeEventHandler AvailableDocumentsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddAvailableDocumentsRow(dsDocumentAutomation.AvailableDocumentsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.AvailableDocumentsRow AddAvailableDocumentsRow(
      Guid AutomationReportGuid,
      int TemplateID,
      string DocumentName,
      string DocumentDescription,
      string DocumentType,
      string Add)
    {
      dsDocumentAutomation.AvailableDocumentsRow row = (dsDocumentAutomation.AvailableDocumentsRow) this.NewRow();
      object[] objArray = new object[7]
      {
        (object) AutomationReportGuid,
        (object) TemplateID,
        (object) DocumentName,
        (object) DocumentDescription,
        (object) DocumentType,
        (object) Add,
        null
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.AvailableDocumentsRow FindByID(int ID)
    {
      return (dsDocumentAutomation.AvailableDocumentsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsDocumentAutomation.AvailableDocumentsDataTable documentsDataTable = (dsDocumentAutomation.AvailableDocumentsDataTable) base.Clone();
      documentsDataTable.InitVars();
      return (DataTable) documentsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDocumentAutomation.AvailableDocumentsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnAutomationReportGuid = this.Columns["AutomationReportGuid"];
      this.columnTemplateID = this.Columns["TemplateID"];
      this.columnDocumentName = this.Columns["DocumentName"];
      this.columnDocumentDescription = this.Columns["DocumentDescription"];
      this.columnDocumentType = this.Columns["DocumentType"];
      this.columnAdd = this.Columns["Add"];
      this.columnID = this.Columns["ID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnAutomationReportGuid = new DataColumn("AutomationReportGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationReportGuid);
      this.columnTemplateID = new DataColumn("TemplateID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateID);
      this.columnDocumentName = new DataColumn("DocumentName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDocumentName);
      this.columnDocumentDescription = new DataColumn("DocumentDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDocumentDescription);
      this.columnDocumentType = new DataColumn("DocumentType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDocumentType);
      this.columnAdd = new DataColumn("Add", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdd);
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsDocumentAutomationKey5", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnDocumentName.AllowDBNull = false;
      this.columnDocumentDescription.AllowDBNull = false;
      this.columnDocumentType.AllowDBNull = false;
      this.columnAdd.AllowDBNull = false;
      this.columnAdd.DefaultValue = (object) "Add";
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.AvailableDocumentsRow NewAvailableDocumentsRow()
    {
      return (dsDocumentAutomation.AvailableDocumentsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDocumentAutomation.AvailableDocumentsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsDocumentAutomation.AvailableDocumentsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AvailableDocumentsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.AvailableDocumentsRowChangeEventHandler documentsRowChangedEvent = this.AvailableDocumentsRowChangedEvent;
      if (documentsRowChangedEvent == null)
        return;
      documentsRowChangedEvent((object) this, new dsDocumentAutomation.AvailableDocumentsRowChangeEvent((dsDocumentAutomation.AvailableDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AvailableDocumentsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.AvailableDocumentsRowChangeEventHandler rowChangingEvent = this.AvailableDocumentsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDocumentAutomation.AvailableDocumentsRowChangeEvent((dsDocumentAutomation.AvailableDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AvailableDocumentsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.AvailableDocumentsRowChangeEventHandler documentsRowDeletedEvent = this.AvailableDocumentsRowDeletedEvent;
      if (documentsRowDeletedEvent == null)
        return;
      documentsRowDeletedEvent((object) this, new dsDocumentAutomation.AvailableDocumentsRowChangeEvent((dsDocumentAutomation.AvailableDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AvailableDocumentsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.AvailableDocumentsRowChangeEventHandler rowDeletingEvent = this.AvailableDocumentsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDocumentAutomation.AvailableDocumentsRowChangeEvent((dsDocumentAutomation.AvailableDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveAvailableDocumentsRow(dsDocumentAutomation.AvailableDocumentsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDocumentAutomation documentAutomation = new dsDocumentAutomation();
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
        FixedValue = nameof (AvailableDocumentsDataTable)
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

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstAutomationDocumentEventsDataTable : 
    TypedTableBase<dsDocumentAutomation.lstAutomationDocumentEventsRow>
  {
    private DataColumn columnEventGuid;
    private DataColumn columnEventName;
    private DataColumn columnDocumentAutomationGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstAutomationDocumentEventsDataTable()
    {
      this.TableName = "lstAutomationDocumentEvents";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected lstAutomationDocumentEventsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EventGuidColumn => this.columnEventGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EventNameColumn => this.columnEventName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DocumentAutomationGroupIDColumn => this.columnDocumentAutomationGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstAutomationDocumentEventsRow this[int index]
    {
      get => (dsDocumentAutomation.lstAutomationDocumentEventsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.lstAutomationDocumentEventsRowChangeEventHandler lstAutomationDocumentEventsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.lstAutomationDocumentEventsRowChangeEventHandler lstAutomationDocumentEventsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.lstAutomationDocumentEventsRowChangeEventHandler lstAutomationDocumentEventsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.lstAutomationDocumentEventsRowChangeEventHandler lstAutomationDocumentEventsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstAutomationDocumentEventsRow(
      dsDocumentAutomation.lstAutomationDocumentEventsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstAutomationDocumentEventsRow AddlstAutomationDocumentEventsRow(
      Guid EventGuid,
      string EventName,
      dsDocumentAutomation.lstDocumentAutomationGroupsRow parentlstDocumentAutomationGroupsRowBylstDocumentAutomationGroupslstAutomationDocumentEvents)
    {
      dsDocumentAutomation.lstAutomationDocumentEventsRow row = (dsDocumentAutomation.lstAutomationDocumentEventsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) EventGuid,
        (object) EventName,
        null
      };
      if (parentlstDocumentAutomationGroupsRowBylstDocumentAutomationGroupslstAutomationDocumentEvents != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parentlstDocumentAutomationGroupsRowBylstDocumentAutomationGroupslstAutomationDocumentEvents[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstAutomationDocumentEventsRow FindByEventGuid(Guid EventGuid)
    {
      return (dsDocumentAutomation.lstAutomationDocumentEventsRow) this.Rows.Find(new object[1]
      {
        (object) EventGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsDocumentAutomation.lstAutomationDocumentEventsDataTable documentEventsDataTable = (dsDocumentAutomation.lstAutomationDocumentEventsDataTable) base.Clone();
      documentEventsDataTable.InitVars();
      return (DataTable) documentEventsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDocumentAutomation.lstAutomationDocumentEventsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnEventGuid = this.Columns["EventGuid"];
      this.columnEventName = this.Columns["EventName"];
      this.columnDocumentAutomationGroupID = this.Columns["DocumentAutomationGroupID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnEventGuid = new DataColumn("EventGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEventGuid);
      this.columnEventName = new DataColumn("EventName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEventName);
      this.columnDocumentAutomationGroupID = new DataColumn("DocumentAutomationGroupID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDocumentAutomationGroupID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsDocumentAutomationKey2", new DataColumn[1]
      {
        this.columnEventGuid
      }, true));
      this.columnEventGuid.AllowDBNull = false;
      this.columnEventGuid.Unique = true;
      this.columnEventName.AllowDBNull = false;
      this.columnDocumentAutomationGroupID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstAutomationDocumentEventsRow NewlstAutomationDocumentEventsRow()
    {
      return (dsDocumentAutomation.lstAutomationDocumentEventsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDocumentAutomation.lstAutomationDocumentEventsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsDocumentAutomation.lstAutomationDocumentEventsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAutomationDocumentEventsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.lstAutomationDocumentEventsRowChangeEventHandler eventsRowChangedEvent = this.lstAutomationDocumentEventsRowChangedEvent;
      if (eventsRowChangedEvent == null)
        return;
      eventsRowChangedEvent((object) this, new dsDocumentAutomation.lstAutomationDocumentEventsRowChangeEvent((dsDocumentAutomation.lstAutomationDocumentEventsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAutomationDocumentEventsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.lstAutomationDocumentEventsRowChangeEventHandler rowChangingEvent = this.lstAutomationDocumentEventsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDocumentAutomation.lstAutomationDocumentEventsRowChangeEvent((dsDocumentAutomation.lstAutomationDocumentEventsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAutomationDocumentEventsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.lstAutomationDocumentEventsRowChangeEventHandler eventsRowDeletedEvent = this.lstAutomationDocumentEventsRowDeletedEvent;
      if (eventsRowDeletedEvent == null)
        return;
      eventsRowDeletedEvent((object) this, new dsDocumentAutomation.lstAutomationDocumentEventsRowChangeEvent((dsDocumentAutomation.lstAutomationDocumentEventsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAutomationDocumentEventsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.lstAutomationDocumentEventsRowChangeEventHandler rowDeletingEvent = this.lstAutomationDocumentEventsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDocumentAutomation.lstAutomationDocumentEventsRowChangeEvent((dsDocumentAutomation.lstAutomationDocumentEventsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstAutomationDocumentEventsRow(
      dsDocumentAutomation.lstAutomationDocumentEventsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDocumentAutomation documentAutomation = new dsDocumentAutomation();
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
        FixedValue = nameof (lstAutomationDocumentEventsDataTable)
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

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstDocumentAutomationGroupsDataTable : 
    TypedTableBase<dsDocumentAutomation.lstDocumentAutomationGroupsRow>
  {
    private DataColumn columnID;
    private DataColumn columnTemplateGroup;
    private DataColumn columnHierarchyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstDocumentAutomationGroupsDataTable()
    {
      this.TableName = "lstDocumentAutomationGroups";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstDocumentAutomationGroupsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected lstDocumentAutomationGroupsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TemplateGroupColumn => this.columnTemplateGroup;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn HierarchyNumberColumn => this.columnHierarchyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstDocumentAutomationGroupsRow this[int index]
    {
      get => (dsDocumentAutomation.lstDocumentAutomationGroupsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.lstDocumentAutomationGroupsRowChangeEventHandler lstDocumentAutomationGroupsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.lstDocumentAutomationGroupsRowChangeEventHandler lstDocumentAutomationGroupsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.lstDocumentAutomationGroupsRowChangeEventHandler lstDocumentAutomationGroupsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.lstDocumentAutomationGroupsRowChangeEventHandler lstDocumentAutomationGroupsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstDocumentAutomationGroupsRow(
      dsDocumentAutomation.lstDocumentAutomationGroupsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstDocumentAutomationGroupsRow AddlstDocumentAutomationGroupsRow(
      int ID,
      string TemplateGroup,
      int HierarchyNumber)
    {
      dsDocumentAutomation.lstDocumentAutomationGroupsRow row = (dsDocumentAutomation.lstDocumentAutomationGroupsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) ID,
        (object) TemplateGroup,
        (object) HierarchyNumber
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstDocumentAutomationGroupsRow FindByID(int ID)
    {
      return (dsDocumentAutomation.lstDocumentAutomationGroupsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsDocumentAutomation.lstDocumentAutomationGroupsDataTable automationGroupsDataTable = (dsDocumentAutomation.lstDocumentAutomationGroupsDataTable) base.Clone();
      automationGroupsDataTable.InitVars();
      return (DataTable) automationGroupsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDocumentAutomation.lstDocumentAutomationGroupsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnTemplateGroup = this.Columns["TemplateGroup"];
      this.columnHierarchyNumber = this.Columns["HierarchyNumber"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnTemplateGroup = new DataColumn("TemplateGroup", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateGroup);
      this.columnHierarchyNumber = new DataColumn("HierarchyNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHierarchyNumber);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsDocumentAutomationKey3", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.Unique = true;
      this.columnTemplateGroup.AllowDBNull = false;
      this.columnHierarchyNumber.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstDocumentAutomationGroupsRow NewlstDocumentAutomationGroupsRow()
    {
      return (dsDocumentAutomation.lstDocumentAutomationGroupsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDocumentAutomation.lstDocumentAutomationGroupsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsDocumentAutomation.lstDocumentAutomationGroupsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDocumentAutomationGroupsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.lstDocumentAutomationGroupsRowChangeEventHandler groupsRowChangedEvent = this.lstDocumentAutomationGroupsRowChangedEvent;
      if (groupsRowChangedEvent == null)
        return;
      groupsRowChangedEvent((object) this, new dsDocumentAutomation.lstDocumentAutomationGroupsRowChangeEvent((dsDocumentAutomation.lstDocumentAutomationGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDocumentAutomationGroupsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.lstDocumentAutomationGroupsRowChangeEventHandler rowChangingEvent = this.lstDocumentAutomationGroupsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDocumentAutomation.lstDocumentAutomationGroupsRowChangeEvent((dsDocumentAutomation.lstDocumentAutomationGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDocumentAutomationGroupsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.lstDocumentAutomationGroupsRowChangeEventHandler groupsRowDeletedEvent = this.lstDocumentAutomationGroupsRowDeletedEvent;
      if (groupsRowDeletedEvent == null)
        return;
      groupsRowDeletedEvent((object) this, new dsDocumentAutomation.lstDocumentAutomationGroupsRowChangeEvent((dsDocumentAutomation.lstDocumentAutomationGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDocumentAutomationGroupsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.lstDocumentAutomationGroupsRowChangeEventHandler rowDeletingEvent = this.lstDocumentAutomationGroupsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDocumentAutomation.lstDocumentAutomationGroupsRowChangeEvent((dsDocumentAutomation.lstDocumentAutomationGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstDocumentAutomationGroupsRow(
      dsDocumentAutomation.lstDocumentAutomationGroupsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDocumentAutomation documentAutomation = new dsDocumentAutomation();
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
        FixedValue = nameof (lstDocumentAutomationGroupsDataTable)
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

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class AutomationReportsDataTable : TypedTableBase<dsDocumentAutomation.AutomationReportsRow>
  {
    private DataColumn columnAutomationReportGuid;
    private DataColumn columnDescription;
    private DataColumn columnTitle;
    private DataColumn columnTemplateGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public AutomationReportsDataTable()
    {
      this.TableName = "AutomationReports";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal AutomationReportsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected AutomationReportsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutomationReportGuidColumn => this.columnAutomationReportGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TitleColumn => this.columnTitle;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TemplateGroupIDColumn => this.columnTemplateGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.AutomationReportsRow this[int index]
    {
      get => (dsDocumentAutomation.AutomationReportsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.AutomationReportsRowChangeEventHandler AutomationReportsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.AutomationReportsRowChangeEventHandler AutomationReportsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.AutomationReportsRowChangeEventHandler AutomationReportsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.AutomationReportsRowChangeEventHandler AutomationReportsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddAutomationReportsRow(dsDocumentAutomation.AutomationReportsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.AutomationReportsRow AddAutomationReportsRow(
      Guid AutomationReportGuid,
      string Description,
      string Title,
      dsDocumentAutomation.lstDocumentAutomationGroupsRow parentlstDocumentAutomationGroupsRowBylstDocumentAutomationGroupsAutomationReports)
    {
      dsDocumentAutomation.AutomationReportsRow row = (dsDocumentAutomation.AutomationReportsRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) AutomationReportGuid,
        (object) Description,
        (object) Title,
        null
      };
      if (parentlstDocumentAutomationGroupsRowBylstDocumentAutomationGroupsAutomationReports != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parentlstDocumentAutomationGroupsRowBylstDocumentAutomationGroupsAutomationReports[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.AutomationReportsRow FindByAutomationReportGuid(
      Guid AutomationReportGuid)
    {
      return (dsDocumentAutomation.AutomationReportsRow) this.Rows.Find(new object[1]
      {
        (object) AutomationReportGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsDocumentAutomation.AutomationReportsDataTable reportsDataTable = (dsDocumentAutomation.AutomationReportsDataTable) base.Clone();
      reportsDataTable.InitVars();
      return (DataTable) reportsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDocumentAutomation.AutomationReportsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnAutomationReportGuid = this.Columns["AutomationReportGuid"];
      this.columnDescription = this.Columns["Description"];
      this.columnTitle = this.Columns["Title"];
      this.columnTemplateGroupID = this.Columns["TemplateGroupID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnAutomationReportGuid = new DataColumn("AutomationReportGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationReportGuid);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnTitle = new DataColumn("Title", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTitle);
      this.columnTemplateGroupID = new DataColumn("TemplateGroupID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateGroupID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsDocumentAutomationKey4", new DataColumn[1]
      {
        this.columnAutomationReportGuid
      }, true));
      this.columnAutomationReportGuid.AllowDBNull = false;
      this.columnAutomationReportGuid.Unique = true;
      this.columnDescription.AllowDBNull = false;
      this.columnTitle.AllowDBNull = false;
      this.columnTemplateGroupID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.AutomationReportsRow NewAutomationReportsRow()
    {
      return (dsDocumentAutomation.AutomationReportsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDocumentAutomation.AutomationReportsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsDocumentAutomation.AutomationReportsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AutomationReportsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.AutomationReportsRowChangeEventHandler reportsRowChangedEvent = this.AutomationReportsRowChangedEvent;
      if (reportsRowChangedEvent == null)
        return;
      reportsRowChangedEvent((object) this, new dsDocumentAutomation.AutomationReportsRowChangeEvent((dsDocumentAutomation.AutomationReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AutomationReportsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.AutomationReportsRowChangeEventHandler rowChangingEvent = this.AutomationReportsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDocumentAutomation.AutomationReportsRowChangeEvent((dsDocumentAutomation.AutomationReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AutomationReportsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.AutomationReportsRowChangeEventHandler reportsRowDeletedEvent = this.AutomationReportsRowDeletedEvent;
      if (reportsRowDeletedEvent == null)
        return;
      reportsRowDeletedEvent((object) this, new dsDocumentAutomation.AutomationReportsRowChangeEvent((dsDocumentAutomation.AutomationReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AutomationReportsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.AutomationReportsRowChangeEventHandler rowDeletingEvent = this.AutomationReportsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDocumentAutomation.AutomationReportsRowChangeEvent((dsDocumentAutomation.AutomationReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveAutomationReportsRow(dsDocumentAutomation.AutomationReportsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDocumentAutomation documentAutomation = new dsDocumentAutomation();
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
        FixedValue = nameof (AutomationReportsDataTable)
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

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblDocumentFoldersDataTable : 
    TypedTableBase<dsDocumentAutomation.tblDocumentFoldersRow>
  {
    private DataColumn columnFolderID;
    private DataColumn columnParentFolderID;
    private DataColumn columnFolderName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblDocumentFoldersDataTable()
    {
      this.TableName = "tblDocumentFolders";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblDocumentFoldersDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected tblDocumentFoldersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FolderIDColumn => this.columnFolderID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ParentFolderIDColumn => this.columnParentFolderID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FolderNameColumn => this.columnFolderName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblDocumentFoldersRow this[int index]
    {
      get => (dsDocumentAutomation.tblDocumentFoldersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.tblDocumentFoldersRowChangeEventHandler tblDocumentFoldersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.tblDocumentFoldersRowChangeEventHandler tblDocumentFoldersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.tblDocumentFoldersRowChangeEventHandler tblDocumentFoldersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.tblDocumentFoldersRowChangeEventHandler tblDocumentFoldersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblDocumentFoldersRow(dsDocumentAutomation.tblDocumentFoldersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblDocumentFoldersRow AddtblDocumentFoldersRow(
      int ParentFolderID,
      string FolderName)
    {
      dsDocumentAutomation.tblDocumentFoldersRow row = (dsDocumentAutomation.tblDocumentFoldersRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) ParentFolderID,
        (object) FolderName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblDocumentFoldersRow FindByFolderID(int FolderID)
    {
      return (dsDocumentAutomation.tblDocumentFoldersRow) this.Rows.Find(new object[1]
      {
        (object) FolderID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsDocumentAutomation.tblDocumentFoldersDataTable foldersDataTable = (dsDocumentAutomation.tblDocumentFoldersDataTable) base.Clone();
      foldersDataTable.InitVars();
      return (DataTable) foldersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDocumentAutomation.tblDocumentFoldersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnFolderID = this.Columns["FolderID"];
      this.columnParentFolderID = this.Columns["ParentFolderID"];
      this.columnFolderName = this.Columns["FolderName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnFolderID = new DataColumn("FolderID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFolderID);
      this.columnParentFolderID = new DataColumn("ParentFolderID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParentFolderID);
      this.columnFolderName = new DataColumn("FolderName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFolderName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsDocumentAutomationKey6", new DataColumn[1]
      {
        this.columnFolderID
      }, true));
      this.columnFolderID.AutoIncrement = true;
      this.columnFolderID.AllowDBNull = false;
      this.columnFolderID.ReadOnly = true;
      this.columnFolderID.Unique = true;
      this.columnFolderName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblDocumentFoldersRow NewtblDocumentFoldersRow()
    {
      return (dsDocumentAutomation.tblDocumentFoldersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDocumentAutomation.tblDocumentFoldersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsDocumentAutomation.tblDocumentFoldersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentFoldersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.tblDocumentFoldersRowChangeEventHandler foldersRowChangedEvent = this.tblDocumentFoldersRowChangedEvent;
      if (foldersRowChangedEvent == null)
        return;
      foldersRowChangedEvent((object) this, new dsDocumentAutomation.tblDocumentFoldersRowChangeEvent((dsDocumentAutomation.tblDocumentFoldersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentFoldersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.tblDocumentFoldersRowChangeEventHandler rowChangingEvent = this.tblDocumentFoldersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDocumentAutomation.tblDocumentFoldersRowChangeEvent((dsDocumentAutomation.tblDocumentFoldersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentFoldersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.tblDocumentFoldersRowChangeEventHandler foldersRowDeletedEvent = this.tblDocumentFoldersRowDeletedEvent;
      if (foldersRowDeletedEvent == null)
        return;
      foldersRowDeletedEvent((object) this, new dsDocumentAutomation.tblDocumentFoldersRowChangeEvent((dsDocumentAutomation.tblDocumentFoldersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentFoldersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.tblDocumentFoldersRowChangeEventHandler rowDeletingEvent = this.tblDocumentFoldersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDocumentAutomation.tblDocumentFoldersRowChangeEvent((dsDocumentAutomation.tblDocumentFoldersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblDocumentFoldersRow(dsDocumentAutomation.tblDocumentFoldersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDocumentAutomation documentAutomation = new dsDocumentAutomation();
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
        FixedValue = nameof (tblDocumentFoldersDataTable)
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

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstQuoteStatusReasonsDataTable : 
    TypedTableBase<dsDocumentAutomation.lstQuoteStatusReasonsRow>
  {
    private DataColumn columnQuoteStatusReasonID;
    private DataColumn columnQuoteStatusReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstQuoteStatusReasonsDataTable()
    {
      this.TableName = "lstQuoteStatusReasons";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected lstQuoteStatusReasonsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteStatusReasonIDColumn => this.columnQuoteStatusReasonID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteStatusReasonColumn => this.columnQuoteStatusReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstQuoteStatusReasonsRow this[int index]
    {
      get => (dsDocumentAutomation.lstQuoteStatusReasonsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.lstQuoteStatusReasonsRowChangeEventHandler lstQuoteStatusReasonsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.lstQuoteStatusReasonsRowChangeEventHandler lstQuoteStatusReasonsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.lstQuoteStatusReasonsRowChangeEventHandler lstQuoteStatusReasonsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsDocumentAutomation.lstQuoteStatusReasonsRowChangeEventHandler lstQuoteStatusReasonsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstQuoteStatusReasonsRow(dsDocumentAutomation.lstQuoteStatusReasonsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstQuoteStatusReasonsRow AddlstQuoteStatusReasonsRow(
      short QuoteStatusReasonID,
      string QuoteStatusReason)
    {
      dsDocumentAutomation.lstQuoteStatusReasonsRow row = (dsDocumentAutomation.lstQuoteStatusReasonsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) QuoteStatusReasonID,
        (object) QuoteStatusReason
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstQuoteStatusReasonsRow FindByQuoteStatusReasonID(
      short QuoteStatusReasonID)
    {
      return (dsDocumentAutomation.lstQuoteStatusReasonsRow) this.Rows.Find(new object[1]
      {
        (object) QuoteStatusReasonID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsDocumentAutomation.lstQuoteStatusReasonsDataTable reasonsDataTable = (dsDocumentAutomation.lstQuoteStatusReasonsDataTable) base.Clone();
      reasonsDataTable.InitVars();
      return (DataTable) reasonsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDocumentAutomation.lstQuoteStatusReasonsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteStatusReasonID = this.Columns["QuoteStatusReasonID"];
      this.columnQuoteStatusReason = this.Columns["QuoteStatusReason"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteStatusReasonID = new DataColumn("QuoteStatusReasonID", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatusReasonID);
      this.columnQuoteStatusReason = new DataColumn("QuoteStatusReason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatusReason);
      this.Constraints.Add((Constraint) new UniqueConstraint("lstStatusReasonsKey1", new DataColumn[1]
      {
        this.columnQuoteStatusReasonID
      }, true));
      this.columnQuoteStatusReasonID.AllowDBNull = false;
      this.columnQuoteStatusReasonID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstQuoteStatusReasonsRow NewlstQuoteStatusReasonsRow()
    {
      return (dsDocumentAutomation.lstQuoteStatusReasonsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDocumentAutomation.lstQuoteStatusReasonsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsDocumentAutomation.lstQuoteStatusReasonsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusReasonsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.lstQuoteStatusReasonsRowChangeEventHandler reasonsRowChangedEvent = this.lstQuoteStatusReasonsRowChangedEvent;
      if (reasonsRowChangedEvent == null)
        return;
      reasonsRowChangedEvent((object) this, new dsDocumentAutomation.lstQuoteStatusReasonsRowChangeEvent((dsDocumentAutomation.lstQuoteStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusReasonsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.lstQuoteStatusReasonsRowChangeEventHandler rowChangingEvent = this.lstQuoteStatusReasonsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDocumentAutomation.lstQuoteStatusReasonsRowChangeEvent((dsDocumentAutomation.lstQuoteStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusReasonsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.lstQuoteStatusReasonsRowChangeEventHandler reasonsRowDeletedEvent = this.lstQuoteStatusReasonsRowDeletedEvent;
      if (reasonsRowDeletedEvent == null)
        return;
      reasonsRowDeletedEvent((object) this, new dsDocumentAutomation.lstQuoteStatusReasonsRowChangeEvent((dsDocumentAutomation.lstQuoteStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusReasonsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentAutomation.lstQuoteStatusReasonsRowChangeEventHandler rowDeletingEvent = this.lstQuoteStatusReasonsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDocumentAutomation.lstQuoteStatusReasonsRowChangeEvent((dsDocumentAutomation.lstQuoteStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstQuoteStatusReasonsRow(dsDocumentAutomation.lstQuoteStatusReasonsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDocumentAutomation documentAutomation = new dsDocumentAutomation();
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
        FixedValue = nameof (lstQuoteStatusReasonsDataTable)
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

  public class tblCompanyAutomationDocumentsRow : DataRow
  {
    private dsDocumentAutomation.tblCompanyAutomationDocumentsDataTable tabletblCompanyAutomationDocuments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyAutomationDocumentsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyAutomationDocuments = (dsDocumentAutomation.tblCompanyAutomationDocumentsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyAutomationDocuments.IDColumn]);
      set => this[this.tabletblCompanyAutomationDocuments.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        object obj = this[this.tabletblCompanyAutomationDocuments.CompanyLineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyAutomationDocuments.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid AutomationReportGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyAutomationDocuments.AutomationReportGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AutomationReportGuid' in table 'tblCompanyAutomationDocuments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyAutomationDocuments.AutomationReportGuidColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int TemplateID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyAutomationDocuments.TemplateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TemplateID' in table 'tblCompanyAutomationDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyAutomationDocuments.TemplateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DocumentOrder
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyAutomationDocuments.DocumentOrderColumn]);
      }
      set => this[this.tabletblCompanyAutomationDocuments.DocumentOrderColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid AutomationEventGuid
    {
      get
      {
        object obj = this[this.tabletblCompanyAutomationDocuments.AutomationEventGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set
      {
        this[this.tabletblCompanyAutomationDocuments.AutomationEventGuidColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DocumentName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyAutomationDocuments.DocumentNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DocumentName' in table 'tblCompanyAutomationDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyAutomationDocuments.DocumentNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DocumentType
    {
      get => Conversions.ToString(this[this.tabletblCompanyAutomationDocuments.DocumentTypeColumn]);
      set => this[this.tabletblCompanyAutomationDocuments.DocumentTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int FolderID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyAutomationDocuments.FolderIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FolderID' in table 'tblCompanyAutomationDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyAutomationDocuments.FolderIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ChangeFolder
    {
      get => Conversions.ToString(this[this.tabletblCompanyAutomationDocuments.ChangeFolderColumn]);
      set => this[this.tabletblCompanyAutomationDocuments.ChangeFolderColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public short QuoteStatusReasonID
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblCompanyAutomationDocuments.QuoteStatusReasonIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteStatusReasonID' in table 'tblCompanyAutomationDocuments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyAutomationDocuments.QuoteStatusReasonIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Conditional
    {
      get => Conversions.ToString(this[this.tabletblCompanyAutomationDocuments.ConditionalColumn]);
      set => this[this.tabletblCompanyAutomationDocuments.ConditionalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DocumentDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyAutomationDocuments.DocumentDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DocumentDescription' in table 'tblCompanyAutomationDocuments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyAutomationDocuments.DocumentDescriptionColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblDocumentFoldersRow tblDocumentFoldersRow
    {
      get
      {
        return (dsDocumentAutomation.tblDocumentFoldersRow) this.GetParentRow(this.Table.ParentRelations["tblDocumentFolderstblCompanyAutomationDocuments"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblDocumentFolderstblCompanyAutomationDocuments"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstAutomationDocumentEventsRow lstAutomationDocumentEventsRow
    {
      get
      {
        return (dsDocumentAutomation.lstAutomationDocumentEventsRow) this.GetParentRow(this.Table.ParentRelations["lstAutomationDocumentEventstblCompanyAutomationDocuments"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstAutomationDocumentEventstblCompanyAutomationDocuments"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstQuoteStatusReasonsRow lstQuoteStatusReasonsRow
    {
      get
      {
        return (dsDocumentAutomation.lstQuoteStatusReasonsRow) this.GetParentRow(this.Table.ParentRelations["StatusReasons_tblCompanyAutomationDocuments"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["StatusReasons_tblCompanyAutomationDocuments"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAutomationReportGuidNull()
    {
      return this.IsNull(this.tabletblCompanyAutomationDocuments.AutomationReportGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAutomationReportGuidNull()
    {
      this[this.tabletblCompanyAutomationDocuments.AutomationReportGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTemplateIDNull()
    {
      return this.IsNull(this.tabletblCompanyAutomationDocuments.TemplateIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTemplateIDNull()
    {
      this[this.tabletblCompanyAutomationDocuments.TemplateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDocumentNameNull()
    {
      return this.IsNull(this.tabletblCompanyAutomationDocuments.DocumentNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDocumentNameNull()
    {
      this[this.tabletblCompanyAutomationDocuments.DocumentNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFolderIDNull()
    {
      return this.IsNull(this.tabletblCompanyAutomationDocuments.FolderIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFolderIDNull()
    {
      this[this.tabletblCompanyAutomationDocuments.FolderIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsQuoteStatusReasonIDNull()
    {
      return this.IsNull(this.tabletblCompanyAutomationDocuments.QuoteStatusReasonIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetQuoteStatusReasonIDNull()
    {
      this[this.tabletblCompanyAutomationDocuments.QuoteStatusReasonIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDocumentDescriptionNull()
    {
      return this.IsNull(this.tabletblCompanyAutomationDocuments.DocumentDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDocumentDescriptionNull()
    {
      this[this.tabletblCompanyAutomationDocuments.DocumentDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblDocumentTemplatesRow : DataRow
  {
    private dsDocumentAutomation.tblDocumentTemplatesDataTable tabletblDocumentTemplates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblDocumentTemplatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDocumentTemplates = (dsDocumentAutomation.tblDocumentTemplatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int TemplateID
    {
      get => Conversions.ToInteger(this[this.tabletblDocumentTemplates.TemplateIDColumn]);
      set => this[this.tabletblDocumentTemplates.TemplateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string TemplateName
    {
      get => Conversions.ToString(this[this.tabletblDocumentTemplates.TemplateNameColumn]);
      set => this[this.tabletblDocumentTemplates.TemplateNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tabletblDocumentTemplates.DescriptionColumn]);
      set => this[this.tabletblDocumentTemplates.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int AutomationGroupID
    {
      get => Conversions.ToInteger(this[this.tabletblDocumentTemplates.AutomationGroupIDColumn]);
      set => this[this.tabletblDocumentTemplates.AutomationGroupIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstDocumentAutomationGroupsRow lstDocumentAutomationGroupsRow
    {
      get
      {
        return (dsDocumentAutomation.lstDocumentAutomationGroupsRow) this.GetParentRow(this.Table.ParentRelations["lstDocumentAutomationGroupstblDocumentTemplates"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstDocumentAutomationGroupstblDocumentTemplates"]);
      }
    }
  }

  public class AvailableDocumentsRow : DataRow
  {
    private dsDocumentAutomation.AvailableDocumentsDataTable tableAvailableDocuments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal AvailableDocumentsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAvailableDocuments = (dsDocumentAutomation.AvailableDocumentsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid AutomationReportGuid
    {
      get
      {
        try
        {
          object obj = this[this.tableAvailableDocuments.AutomationReportGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AutomationReportGuid' in table 'AvailableDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAvailableDocuments.AutomationReportGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int TemplateID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAvailableDocuments.TemplateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TemplateID' in table 'AvailableDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAvailableDocuments.TemplateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DocumentName
    {
      get => Conversions.ToString(this[this.tableAvailableDocuments.DocumentNameColumn]);
      set => this[this.tableAvailableDocuments.DocumentNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DocumentDescription
    {
      get => Conversions.ToString(this[this.tableAvailableDocuments.DocumentDescriptionColumn]);
      set => this[this.tableAvailableDocuments.DocumentDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DocumentType
    {
      get => Conversions.ToString(this[this.tableAvailableDocuments.DocumentTypeColumn]);
      set => this[this.tableAvailableDocuments.DocumentTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Add
    {
      get => Conversions.ToString(this[this.tableAvailableDocuments.AddColumn]);
      set => this[this.tableAvailableDocuments.AddColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tableAvailableDocuments.IDColumn]);
      set => this[this.tableAvailableDocuments.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAutomationReportGuidNull()
    {
      return this.IsNull(this.tableAvailableDocuments.AutomationReportGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAutomationReportGuidNull()
    {
      this[this.tableAvailableDocuments.AutomationReportGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTemplateIDNull() => this.IsNull(this.tableAvailableDocuments.TemplateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTemplateIDNull()
    {
      this[this.tableAvailableDocuments.TemplateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstAutomationDocumentEventsRow : DataRow
  {
    private dsDocumentAutomation.lstAutomationDocumentEventsDataTable tablelstAutomationDocumentEvents;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstAutomationDocumentEventsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstAutomationDocumentEvents = (dsDocumentAutomation.lstAutomationDocumentEventsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EventName
    {
      get => Conversions.ToString(this[this.tablelstAutomationDocumentEvents.EventNameColumn]);
      set => this[this.tablelstAutomationDocumentEvents.EventNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DocumentAutomationGroupID
    {
      get
      {
        return Conversions.ToInteger(this[this.tablelstAutomationDocumentEvents.DocumentAutomationGroupIDColumn]);
      }
      set
      {
        this[this.tablelstAutomationDocumentEvents.DocumentAutomationGroupIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstDocumentAutomationGroupsRow lstDocumentAutomationGroupsRow
    {
      get
      {
        return (dsDocumentAutomation.lstDocumentAutomationGroupsRow) this.GetParentRow(this.Table.ParentRelations["lstDocumentAutomationGroupslstAutomationDocumentEvents"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstDocumentAutomationGroupslstAutomationDocumentEvents"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblCompanyAutomationDocumentsRow[] GettblCompanyAutomationDocumentsRows()
    {
      return this.Table.ChildRelations["lstAutomationDocumentEventstblCompanyAutomationDocuments"] != null ? (dsDocumentAutomation.tblCompanyAutomationDocumentsRow[]) this.GetChildRows(this.Table.ChildRelations["lstAutomationDocumentEventstblCompanyAutomationDocuments"]) : new dsDocumentAutomation.tblCompanyAutomationDocumentsRow[0];
    }
  }

  public class lstDocumentAutomationGroupsRow : DataRow
  {
    private dsDocumentAutomation.lstDocumentAutomationGroupsDataTable tablelstDocumentAutomationGroups;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstDocumentAutomationGroupsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstDocumentAutomationGroups = (dsDocumentAutomation.lstDocumentAutomationGroupsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstDocumentAutomationGroups.IDColumn]);
      set => this[this.tablelstDocumentAutomationGroups.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string TemplateGroup
    {
      get => Conversions.ToString(this[this.tablelstDocumentAutomationGroups.TemplateGroupColumn]);
      set => this[this.tablelstDocumentAutomationGroups.TemplateGroupColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int HierarchyNumber
    {
      get
      {
        return Conversions.ToInteger(this[this.tablelstDocumentAutomationGroups.HierarchyNumberColumn]);
      }
      set => this[this.tablelstDocumentAutomationGroups.HierarchyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.AutomationReportsRow[] GetAutomationReportsRows()
    {
      return this.Table.ChildRelations["lstDocumentAutomationGroupsAutomationReports"] != null ? (dsDocumentAutomation.AutomationReportsRow[]) this.GetChildRows(this.Table.ChildRelations["lstDocumentAutomationGroupsAutomationReports"]) : new dsDocumentAutomation.AutomationReportsRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstAutomationDocumentEventsRow[] GetlstAutomationDocumentEventsRows()
    {
      return this.Table.ChildRelations["lstDocumentAutomationGroupslstAutomationDocumentEvents"] != null ? (dsDocumentAutomation.lstAutomationDocumentEventsRow[]) this.GetChildRows(this.Table.ChildRelations["lstDocumentAutomationGroupslstAutomationDocumentEvents"]) : new dsDocumentAutomation.lstAutomationDocumentEventsRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblDocumentTemplatesRow[] GettblDocumentTemplatesRows()
    {
      return this.Table.ChildRelations["lstDocumentAutomationGroupstblDocumentTemplates"] != null ? (dsDocumentAutomation.tblDocumentTemplatesRow[]) this.GetChildRows(this.Table.ChildRelations["lstDocumentAutomationGroupstblDocumentTemplates"]) : new dsDocumentAutomation.tblDocumentTemplatesRow[0];
    }
  }

  public class AutomationReportsRow : DataRow
  {
    private dsDocumentAutomation.AutomationReportsDataTable tableAutomationReports;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal AutomationReportsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAutomationReports = (dsDocumentAutomation.AutomationReportsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid AutomationReportGuid
    {
      get
      {
        object obj = this[this.tableAutomationReports.AutomationReportGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableAutomationReports.AutomationReportGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tableAutomationReports.DescriptionColumn]);
      set => this[this.tableAutomationReports.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Title
    {
      get => Conversions.ToString(this[this.tableAutomationReports.TitleColumn]);
      set => this[this.tableAutomationReports.TitleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int TemplateGroupID
    {
      get => Conversions.ToInteger(this[this.tableAutomationReports.TemplateGroupIDColumn]);
      set => this[this.tableAutomationReports.TemplateGroupIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstDocumentAutomationGroupsRow lstDocumentAutomationGroupsRow
    {
      get
      {
        return (dsDocumentAutomation.lstDocumentAutomationGroupsRow) this.GetParentRow(this.Table.ParentRelations["lstDocumentAutomationGroupsAutomationReports"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstDocumentAutomationGroupsAutomationReports"]);
      }
    }
  }

  public class tblDocumentFoldersRow : DataRow
  {
    private dsDocumentAutomation.tblDocumentFoldersDataTable tabletblDocumentFolders;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblDocumentFoldersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDocumentFolders = (dsDocumentAutomation.tblDocumentFoldersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int FolderID
    {
      get => Conversions.ToInteger(this[this.tabletblDocumentFolders.FolderIDColumn]);
      set => this[this.tabletblDocumentFolders.FolderIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ParentFolderID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblDocumentFolders.ParentFolderIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ParentFolderID' in table 'tblDocumentFolders' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentFolders.ParentFolderIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string FolderName
    {
      get => Conversions.ToString(this[this.tabletblDocumentFolders.FolderNameColumn]);
      set => this[this.tabletblDocumentFolders.FolderNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsParentFolderIDNull()
    {
      return this.IsNull(this.tabletblDocumentFolders.ParentFolderIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetParentFolderIDNull()
    {
      this[this.tabletblDocumentFolders.ParentFolderIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblCompanyAutomationDocumentsRow[] GettblCompanyAutomationDocumentsRows()
    {
      return this.Table.ChildRelations["tblDocumentFolderstblCompanyAutomationDocuments"] != null ? (dsDocumentAutomation.tblCompanyAutomationDocumentsRow[]) this.GetChildRows(this.Table.ChildRelations["tblDocumentFolderstblCompanyAutomationDocuments"]) : new dsDocumentAutomation.tblCompanyAutomationDocumentsRow[0];
    }
  }

  public class lstQuoteStatusReasonsRow : DataRow
  {
    private dsDocumentAutomation.lstQuoteStatusReasonsDataTable tablelstQuoteStatusReasons;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstQuoteStatusReasonsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstQuoteStatusReasons = (dsDocumentAutomation.lstQuoteStatusReasonsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public short QuoteStatusReasonID
    {
      get => Conversions.ToShort(this[this.tablelstQuoteStatusReasons.QuoteStatusReasonIDColumn]);
      set => this[this.tablelstQuoteStatusReasons.QuoteStatusReasonIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string QuoteStatusReason
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstQuoteStatusReasons.QuoteStatusReasonColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteStatusReason' in table 'lstQuoteStatusReasons' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstQuoteStatusReasons.QuoteStatusReasonColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsQuoteStatusReasonNull()
    {
      return this.IsNull(this.tablelstQuoteStatusReasons.QuoteStatusReasonColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetQuoteStatusReasonNull()
    {
      this[this.tablelstQuoteStatusReasons.QuoteStatusReasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblCompanyAutomationDocumentsRow[] GettblCompanyAutomationDocumentsRows()
    {
      return this.Table.ChildRelations["StatusReasons_tblCompanyAutomationDocuments"] != null ? (dsDocumentAutomation.tblCompanyAutomationDocumentsRow[]) this.GetChildRows(this.Table.ChildRelations["StatusReasons_tblCompanyAutomationDocuments"]) : new dsDocumentAutomation.tblCompanyAutomationDocumentsRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompanyAutomationDocumentsRowChangeEvent : EventArgs
  {
    private dsDocumentAutomation.tblCompanyAutomationDocumentsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyAutomationDocumentsRowChangeEvent(
      dsDocumentAutomation.tblCompanyAutomationDocumentsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblCompanyAutomationDocumentsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblDocumentTemplatesRowChangeEvent : EventArgs
  {
    private dsDocumentAutomation.tblDocumentTemplatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblDocumentTemplatesRowChangeEvent(
      dsDocumentAutomation.tblDocumentTemplatesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblDocumentTemplatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class AvailableDocumentsRowChangeEvent : EventArgs
  {
    private dsDocumentAutomation.AvailableDocumentsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public AvailableDocumentsRowChangeEvent(
      dsDocumentAutomation.AvailableDocumentsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.AvailableDocumentsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstAutomationDocumentEventsRowChangeEvent : EventArgs
  {
    private dsDocumentAutomation.lstAutomationDocumentEventsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstAutomationDocumentEventsRowChangeEvent(
      dsDocumentAutomation.lstAutomationDocumentEventsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstAutomationDocumentEventsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstDocumentAutomationGroupsRowChangeEvent : EventArgs
  {
    private dsDocumentAutomation.lstDocumentAutomationGroupsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstDocumentAutomationGroupsRowChangeEvent(
      dsDocumentAutomation.lstDocumentAutomationGroupsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstDocumentAutomationGroupsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class AutomationReportsRowChangeEvent : EventArgs
  {
    private dsDocumentAutomation.AutomationReportsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public AutomationReportsRowChangeEvent(
      dsDocumentAutomation.AutomationReportsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.AutomationReportsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblDocumentFoldersRowChangeEvent : EventArgs
  {
    private dsDocumentAutomation.tblDocumentFoldersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblDocumentFoldersRowChangeEvent(
      dsDocumentAutomation.tblDocumentFoldersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.tblDocumentFoldersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstQuoteStatusReasonsRowChangeEvent : EventArgs
  {
    private dsDocumentAutomation.lstQuoteStatusReasonsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstQuoteStatusReasonsRowChangeEvent(
      dsDocumentAutomation.lstQuoteStatusReasonsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsDocumentAutomation.lstQuoteStatusReasonsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
