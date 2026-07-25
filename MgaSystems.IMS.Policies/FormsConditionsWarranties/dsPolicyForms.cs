// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormsConditionsWarranties.dsPolicyForms
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
namespace MGASystems.IMS.Policies.FormsConditionsWarranties;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPolicyForms")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPolicyForms : DataSet
{
  private dsPolicyForms.tblPolicyFormsDataTable tabletblPolicyForms;
  private dsPolicyForms.AutomationReportsDataTable tableAutomationReports;
  private dsPolicyForms.lstFormTypesDataTable tablelstFormTypes;
  private dsPolicyForms.tblDocumentTemplatesDataTable tabletblDocumentTemplates;
  private DataRelation relationFK_lstFormTypes_tblPolicyForms;
  private DataRelation relationAutomationReportstblPolicyForms;
  private DataRelation relationtblDocumentTemplates_tblPolicyForms;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsPolicyForms()
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
  protected dsPolicyForms(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblPolicyForms)] != null)
          base.Tables.Add((DataTable) new dsPolicyForms.tblPolicyFormsDataTable(dataSet.Tables[nameof (tblPolicyForms)]));
        if (dataSet.Tables[nameof (AutomationReports)] != null)
          base.Tables.Add((DataTable) new dsPolicyForms.AutomationReportsDataTable(dataSet.Tables[nameof (AutomationReports)]));
        if (dataSet.Tables[nameof (lstFormTypes)] != null)
          base.Tables.Add((DataTable) new dsPolicyForms.lstFormTypesDataTable(dataSet.Tables[nameof (lstFormTypes)]));
        if (dataSet.Tables[nameof (tblDocumentTemplates)] != null)
          base.Tables.Add((DataTable) new dsPolicyForms.tblDocumentTemplatesDataTable(dataSet.Tables[nameof (tblDocumentTemplates)]));
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
  public dsPolicyForms.tblPolicyFormsDataTable tblPolicyForms => this.tabletblPolicyForms;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyForms.AutomationReportsDataTable AutomationReports => this.tableAutomationReports;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyForms.lstFormTypesDataTable lstFormTypes => this.tablelstFormTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyForms.tblDocumentTemplatesDataTable tblDocumentTemplates
  {
    get => this.tabletblDocumentTemplates;
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
    dsPolicyForms dsPolicyForms = (dsPolicyForms) base.Clone();
    dsPolicyForms.InitVars();
    dsPolicyForms.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsPolicyForms;
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
      if (dataSet.Tables["tblPolicyForms"] != null)
        base.Tables.Add((DataTable) new dsPolicyForms.tblPolicyFormsDataTable(dataSet.Tables["tblPolicyForms"]));
      if (dataSet.Tables["AutomationReports"] != null)
        base.Tables.Add((DataTable) new dsPolicyForms.AutomationReportsDataTable(dataSet.Tables["AutomationReports"]));
      if (dataSet.Tables["lstFormTypes"] != null)
        base.Tables.Add((DataTable) new dsPolicyForms.lstFormTypesDataTable(dataSet.Tables["lstFormTypes"]));
      if (dataSet.Tables["tblDocumentTemplates"] != null)
        base.Tables.Add((DataTable) new dsPolicyForms.tblDocumentTemplatesDataTable(dataSet.Tables["tblDocumentTemplates"]));
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
    this.tabletblPolicyForms = (dsPolicyForms.tblPolicyFormsDataTable) base.Tables["tblPolicyForms"];
    if (initTable && this.tabletblPolicyForms != null)
      this.tabletblPolicyForms.InitVars();
    this.tableAutomationReports = (dsPolicyForms.AutomationReportsDataTable) base.Tables["AutomationReports"];
    if (initTable && this.tableAutomationReports != null)
      this.tableAutomationReports.InitVars();
    this.tablelstFormTypes = (dsPolicyForms.lstFormTypesDataTable) base.Tables["lstFormTypes"];
    if (initTable && this.tablelstFormTypes != null)
      this.tablelstFormTypes.InitVars();
    this.tabletblDocumentTemplates = (dsPolicyForms.tblDocumentTemplatesDataTable) base.Tables["tblDocumentTemplates"];
    if (initTable && this.tabletblDocumentTemplates != null)
      this.tabletblDocumentTemplates.InitVars();
    this.relationFK_lstFormTypes_tblPolicyForms = this.Relations["FK_lstFormTypes_tblPolicyForms"];
    this.relationAutomationReportstblPolicyForms = this.Relations["AutomationReportstblPolicyForms"];
    this.relationtblDocumentTemplates_tblPolicyForms = this.Relations["tblDocumentTemplates_tblPolicyForms"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPolicyForms);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsPolicyForms.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblPolicyForms = new dsPolicyForms.tblPolicyFormsDataTable();
    base.Tables.Add((DataTable) this.tabletblPolicyForms);
    this.tableAutomationReports = new dsPolicyForms.AutomationReportsDataTable();
    base.Tables.Add((DataTable) this.tableAutomationReports);
    this.tablelstFormTypes = new dsPolicyForms.lstFormTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstFormTypes);
    this.tabletblDocumentTemplates = new dsPolicyForms.tblDocumentTemplatesDataTable();
    base.Tables.Add((DataTable) this.tabletblDocumentTemplates);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("FK_lstFormTypes_tblPolicyForms", new DataColumn[1]
    {
      this.tablelstFormTypes.FormTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblPolicyForms.FormTypeIDColumn
    });
    this.tabletblPolicyForms.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("AutomationReportstblPolicyForms", new DataColumn[1]
    {
      this.tableAutomationReports.AutomationReportGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblPolicyForms.AutomationReportGuidColumn
    });
    this.tabletblPolicyForms.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    this.relationFK_lstFormTypes_tblPolicyForms = new DataRelation("FK_lstFormTypes_tblPolicyForms", new DataColumn[1]
    {
      this.tablelstFormTypes.FormTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblPolicyForms.FormTypeIDColumn
    }, false);
    this.Relations.Add(this.relationFK_lstFormTypes_tblPolicyForms);
    this.relationAutomationReportstblPolicyForms = new DataRelation("AutomationReportstblPolicyForms", new DataColumn[1]
    {
      this.tableAutomationReports.AutomationReportGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblPolicyForms.AutomationReportGuidColumn
    }, false);
    this.Relations.Add(this.relationAutomationReportstblPolicyForms);
    this.relationtblDocumentTemplates_tblPolicyForms = new DataRelation("tblDocumentTemplates_tblPolicyForms", new DataColumn[1]
    {
      this.tabletblDocumentTemplates.TemplateIDColumn
    }, new DataColumn[1]
    {
      this.tabletblPolicyForms.TemplateIDColumn
    }, false);
    this.Relations.Add(this.relationtblDocumentTemplates_tblPolicyForms);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblPolicyForms() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeAutomationReports() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstFormTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblDocumentTemplates() => false;

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
    dsPolicyForms dsPolicyForms = new dsPolicyForms();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsPolicyForms.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsPolicyForms.GetSchemaSerializable();
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
  public delegate void tblPolicyFormsRowChangeEventHandler(
    object sender,
    dsPolicyForms.tblPolicyFormsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void AutomationReportsRowChangeEventHandler(
    object sender,
    dsPolicyForms.AutomationReportsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstFormTypesRowChangeEventHandler(
    object sender,
    dsPolicyForms.lstFormTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblDocumentTemplatesRowChangeEventHandler(
    object sender,
    dsPolicyForms.tblDocumentTemplatesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblPolicyFormsDataTable : TypedTableBase<dsPolicyForms.tblPolicyFormsRow>
  {
    private DataColumn columnFormID;
    private DataColumn columnFormName;
    private DataColumn columnDescription;
    private DataColumn columnTemplateID;
    private DataColumn columnFormNumber;
    private DataColumn columnRequiresEndorsementNumber;
    private DataColumn columnAutomationReportGuid;
    private DataColumn columnPDF;
    private DataColumn columnPDF_Filename;
    private DataColumn columnParentFormID;
    private DataColumn columnEditionDate;
    private DataColumn columnFormTypeID;
    private DataColumn columnComments;
    private DataColumn columnURL;
    private DataColumn columnRequiresEdit;
    private DataColumn columnFilterCharacter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblPolicyFormsDataTable()
    {
      this.TableName = "tblPolicyForms";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblPolicyFormsDataTable(DataTable table)
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
    protected tblPolicyFormsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormIDColumn => this.columnFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormNameColumn => this.columnFormName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TemplateIDColumn => this.columnTemplateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormNumberColumn => this.columnFormNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RequiresEndorsementNumberColumn => this.columnRequiresEndorsementNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AutomationReportGuidColumn => this.columnAutomationReportGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PDFColumn => this.columnPDF;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PDF_FilenameColumn => this.columnPDF_Filename;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ParentFormIDColumn => this.columnParentFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EditionDateColumn => this.columnEditionDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormTypeIDColumn => this.columnFormTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CommentsColumn => this.columnComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn URLColumn => this.columnURL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RequiresEditColumn => this.columnRequiresEdit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FilterCharacterColumn => this.columnFilterCharacter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.tblPolicyFormsRow this[int index]
    {
      get => (dsPolicyForms.tblPolicyFormsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.tblPolicyFormsRowChangeEventHandler tblPolicyFormsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblPolicyFormsRow(dsPolicyForms.tblPolicyFormsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.tblPolicyFormsRow AddtblPolicyFormsRow(
      string FormName,
      string Description,
      dsPolicyForms.tblDocumentTemplatesRow parenttblDocumentTemplatesRowBytblDocumentTemplates_tblPolicyForms,
      string FormNumber,
      bool RequiresEndorsementNumber,
      dsPolicyForms.AutomationReportsRow parentAutomationReportsRowByAutomationReportstblPolicyForms,
      byte[] PDF,
      string PDF_Filename,
      int ParentFormID,
      string EditionDate,
      dsPolicyForms.lstFormTypesRow parentlstFormTypesRowByFK_lstFormTypes_tblPolicyForms,
      string Comments,
      string URL,
      bool RequiresEdit,
      string FilterCharacter)
    {
      dsPolicyForms.tblPolicyFormsRow row = (dsPolicyForms.tblPolicyFormsRow) this.NewRow();
      object[] objArray = new object[16 /*0x10*/]
      {
        null,
        (object) FormName,
        (object) Description,
        null,
        (object) FormNumber,
        (object) RequiresEndorsementNumber,
        null,
        (object) PDF,
        (object) PDF_Filename,
        (object) ParentFormID,
        (object) EditionDate,
        null,
        (object) Comments,
        (object) URL,
        (object) RequiresEdit,
        (object) FilterCharacter
      };
      if (parenttblDocumentTemplatesRowBytblDocumentTemplates_tblPolicyForms != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parenttblDocumentTemplatesRowBytblDocumentTemplates_tblPolicyForms[0]);
      if (parentAutomationReportsRowByAutomationReportstblPolicyForms != null)
        objArray[6] = RuntimeHelpers.GetObjectValue(parentAutomationReportsRowByAutomationReportstblPolicyForms[0]);
      if (parentlstFormTypesRowByFK_lstFormTypes_tblPolicyForms != null)
        objArray[11] = RuntimeHelpers.GetObjectValue(parentlstFormTypesRowByFK_lstFormTypes_tblPolicyForms[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.tblPolicyFormsRow FindByFormID(int FormID)
    {
      return (dsPolicyForms.tblPolicyFormsRow) this.Rows.Find(new object[1]
      {
        (object) FormID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyForms.tblPolicyFormsDataTable policyFormsDataTable = (dsPolicyForms.tblPolicyFormsDataTable) base.Clone();
      policyFormsDataTable.InitVars();
      return (DataTable) policyFormsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyForms.tblPolicyFormsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnFormID = this.Columns["FormID"];
      this.columnFormName = this.Columns["FormName"];
      this.columnDescription = this.Columns["Description"];
      this.columnTemplateID = this.Columns["TemplateID"];
      this.columnFormNumber = this.Columns["FormNumber"];
      this.columnRequiresEndorsementNumber = this.Columns["RequiresEndorsementNumber"];
      this.columnAutomationReportGuid = this.Columns["AutomationReportGuid"];
      this.columnPDF = this.Columns["PDF"];
      this.columnPDF_Filename = this.Columns["PDF_Filename"];
      this.columnParentFormID = this.Columns["ParentFormID"];
      this.columnEditionDate = this.Columns["EditionDate"];
      this.columnFormTypeID = this.Columns["FormTypeID"];
      this.columnComments = this.Columns["Comments"];
      this.columnURL = this.Columns["URL"];
      this.columnRequiresEdit = this.Columns["RequiresEdit"];
      this.columnFilterCharacter = this.Columns["FilterCharacter"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnFormID = new DataColumn("FormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormID);
      this.columnFormName = new DataColumn("FormName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormName);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnTemplateID = new DataColumn("TemplateID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateID);
      this.columnFormNumber = new DataColumn("FormNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormNumber);
      this.columnRequiresEndorsementNumber = new DataColumn("RequiresEndorsementNumber", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiresEndorsementNumber);
      this.columnAutomationReportGuid = new DataColumn("AutomationReportGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationReportGuid);
      this.columnPDF = new DataColumn("PDF", typeof (byte[]), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPDF);
      this.columnPDF_Filename = new DataColumn("PDF_Filename", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPDF_Filename);
      this.columnParentFormID = new DataColumn("ParentFormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParentFormID);
      this.columnEditionDate = new DataColumn("EditionDate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEditionDate);
      this.columnFormTypeID = new DataColumn("FormTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormTypeID);
      this.columnComments = new DataColumn("Comments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComments);
      this.columnURL = new DataColumn("URL", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnURL);
      this.columnRequiresEdit = new DataColumn("RequiresEdit", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiresEdit);
      this.columnFilterCharacter = new DataColumn("FilterCharacter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFilterCharacter);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnFormID
      }, true));
      this.columnFormID.AutoIncrement = true;
      this.columnFormID.AllowDBNull = false;
      this.columnFormID.ReadOnly = true;
      this.columnFormID.Unique = true;
      this.columnRequiresEndorsementNumber.AllowDBNull = false;
      this.columnRequiresEndorsementNumber.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.tblPolicyFormsRow NewtblPolicyFormsRow()
    {
      return (dsPolicyForms.tblPolicyFormsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyForms.tblPolicyFormsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyForms.tblPolicyFormsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFormsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.tblPolicyFormsRowChangeEventHandler formsRowChangedEvent = this.tblPolicyFormsRowChangedEvent;
      if (formsRowChangedEvent == null)
        return;
      formsRowChangedEvent((object) this, new dsPolicyForms.tblPolicyFormsRowChangeEvent((dsPolicyForms.tblPolicyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFormsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.tblPolicyFormsRowChangeEventHandler rowChangingEvent = this.tblPolicyFormsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyForms.tblPolicyFormsRowChangeEvent((dsPolicyForms.tblPolicyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFormsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.tblPolicyFormsRowChangeEventHandler formsRowDeletedEvent = this.tblPolicyFormsRowDeletedEvent;
      if (formsRowDeletedEvent == null)
        return;
      formsRowDeletedEvent((object) this, new dsPolicyForms.tblPolicyFormsRowChangeEvent((dsPolicyForms.tblPolicyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyFormsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.tblPolicyFormsRowChangeEventHandler rowDeletingEvent = this.tblPolicyFormsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyForms.tblPolicyFormsRowChangeEvent((dsPolicyForms.tblPolicyFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblPolicyFormsRow(dsPolicyForms.tblPolicyFormsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyForms dsPolicyForms = new dsPolicyForms();
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
        FixedValue = dsPolicyForms.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblPolicyFormsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyForms.GetSchemaSerializable();
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
  public class AutomationReportsDataTable : TypedTableBase<dsPolicyForms.AutomationReportsRow>
  {
    private DataColumn columnAutomationReportGuid;
    private DataColumn columnTitle;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public AutomationReportsDataTable()
    {
      this.TableName = "AutomationReports";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected AutomationReportsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AutomationReportGuidColumn => this.columnAutomationReportGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TitleColumn => this.columnTitle;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.AutomationReportsRow this[int index]
    {
      get => (dsPolicyForms.AutomationReportsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.AutomationReportsRowChangeEventHandler AutomationReportsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.AutomationReportsRowChangeEventHandler AutomationReportsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.AutomationReportsRowChangeEventHandler AutomationReportsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.AutomationReportsRowChangeEventHandler AutomationReportsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddAutomationReportsRow(dsPolicyForms.AutomationReportsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.AutomationReportsRow AddAutomationReportsRow(
      Guid AutomationReportGuid,
      string Title)
    {
      dsPolicyForms.AutomationReportsRow row = (dsPolicyForms.AutomationReportsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) AutomationReportGuid,
        (object) Title
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.AutomationReportsRow FindByAutomationReportGuid(Guid AutomationReportGuid)
    {
      return (dsPolicyForms.AutomationReportsRow) this.Rows.Find(new object[1]
      {
        (object) AutomationReportGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyForms.AutomationReportsDataTable reportsDataTable = (dsPolicyForms.AutomationReportsDataTable) base.Clone();
      reportsDataTable.InitVars();
      return (DataTable) reportsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyForms.AutomationReportsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnAutomationReportGuid = this.Columns["AutomationReportGuid"];
      this.columnTitle = this.Columns["Title"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnAutomationReportGuid = new DataColumn("AutomationReportGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationReportGuid);
      this.columnTitle = new DataColumn("Title", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTitle);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyFormsKey1", new DataColumn[1]
      {
        this.columnAutomationReportGuid
      }, true));
      this.columnAutomationReportGuid.AllowDBNull = false;
      this.columnAutomationReportGuid.Unique = true;
      this.columnTitle.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.AutomationReportsRow NewAutomationReportsRow()
    {
      return (dsPolicyForms.AutomationReportsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyForms.AutomationReportsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyForms.AutomationReportsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AutomationReportsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.AutomationReportsRowChangeEventHandler reportsRowChangedEvent = this.AutomationReportsRowChangedEvent;
      if (reportsRowChangedEvent == null)
        return;
      reportsRowChangedEvent((object) this, new dsPolicyForms.AutomationReportsRowChangeEvent((dsPolicyForms.AutomationReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AutomationReportsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.AutomationReportsRowChangeEventHandler rowChangingEvent = this.AutomationReportsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyForms.AutomationReportsRowChangeEvent((dsPolicyForms.AutomationReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AutomationReportsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.AutomationReportsRowChangeEventHandler reportsRowDeletedEvent = this.AutomationReportsRowDeletedEvent;
      if (reportsRowDeletedEvent == null)
        return;
      reportsRowDeletedEvent((object) this, new dsPolicyForms.AutomationReportsRowChangeEvent((dsPolicyForms.AutomationReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AutomationReportsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.AutomationReportsRowChangeEventHandler rowDeletingEvent = this.AutomationReportsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyForms.AutomationReportsRowChangeEvent((dsPolicyForms.AutomationReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveAutomationReportsRow(dsPolicyForms.AutomationReportsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyForms dsPolicyForms = new dsPolicyForms();
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
        FixedValue = dsPolicyForms.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (AutomationReportsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyForms.GetSchemaSerializable();
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
  public class lstFormTypesDataTable : TypedTableBase<dsPolicyForms.lstFormTypesRow>
  {
    private DataColumn columnFormTypeID;
    private DataColumn columnFormType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstFormTypesDataTable()
    {
      this.TableName = "lstFormTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstFormTypesDataTable(DataTable table)
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
    protected lstFormTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormTypeIDColumn => this.columnFormTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormTypeColumn => this.columnFormType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.lstFormTypesRow this[int index]
    {
      get => (dsPolicyForms.lstFormTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.lstFormTypesRowChangeEventHandler lstFormTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.lstFormTypesRowChangeEventHandler lstFormTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.lstFormTypesRowChangeEventHandler lstFormTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.lstFormTypesRowChangeEventHandler lstFormTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstFormTypesRow(dsPolicyForms.lstFormTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.lstFormTypesRow AddlstFormTypesRow(int FormTypeID, string FormType)
    {
      dsPolicyForms.lstFormTypesRow row = (dsPolicyForms.lstFormTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) FormTypeID,
        (object) FormType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyForms.lstFormTypesDataTable formTypesDataTable = (dsPolicyForms.lstFormTypesDataTable) base.Clone();
      formTypesDataTable.InitVars();
      return (DataTable) formTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyForms.lstFormTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnFormTypeID = this.Columns["FormTypeID"];
      this.columnFormType = this.Columns["FormType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnFormTypeID = new DataColumn("FormTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormTypeID);
      this.columnFormType = new DataColumn("FormType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnFormTypeID
      }, false));
      this.columnFormTypeID.Unique = true;
      this.columnFormType.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.lstFormTypesRow NewlstFormTypesRow()
    {
      return (dsPolicyForms.lstFormTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyForms.lstFormTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyForms.lstFormTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFormTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.lstFormTypesRowChangeEventHandler typesRowChangedEvent = this.lstFormTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsPolicyForms.lstFormTypesRowChangeEvent((dsPolicyForms.lstFormTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFormTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.lstFormTypesRowChangeEventHandler rowChangingEvent = this.lstFormTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyForms.lstFormTypesRowChangeEvent((dsPolicyForms.lstFormTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFormTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.lstFormTypesRowChangeEventHandler typesRowDeletedEvent = this.lstFormTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsPolicyForms.lstFormTypesRowChangeEvent((dsPolicyForms.lstFormTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFormTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.lstFormTypesRowChangeEventHandler rowDeletingEvent = this.lstFormTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyForms.lstFormTypesRowChangeEvent((dsPolicyForms.lstFormTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstFormTypesRow(dsPolicyForms.lstFormTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyForms dsPolicyForms = new dsPolicyForms();
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
        FixedValue = dsPolicyForms.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstFormTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyForms.GetSchemaSerializable();
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
  public class tblDocumentTemplatesDataTable : TypedTableBase<dsPolicyForms.tblDocumentTemplatesRow>
  {
    private DataColumn columnTemplateID;
    private DataColumn columnTemplateName;
    private DataColumn columnDescription;
    private DataColumn columnRequiresEdit;
    private DataColumn columnTemplateDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblDocumentTemplatesDataTable()
    {
      this.TableName = "tblDocumentTemplates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblDocumentTemplatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TemplateIDColumn => this.columnTemplateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TemplateNameColumn => this.columnTemplateName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RequiresEditColumn => this.columnRequiresEdit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TemplateDescriptionColumn => this.columnTemplateDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.tblDocumentTemplatesRow this[int index]
    {
      get => (dsPolicyForms.tblDocumentTemplatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsPolicyForms.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblDocumentTemplatesRow(dsPolicyForms.tblDocumentTemplatesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.tblDocumentTemplatesRow AddtblDocumentTemplatesRow(
      int TemplateID,
      string TemplateName,
      string Description,
      bool RequiresEdit,
      string TemplateDescription)
    {
      dsPolicyForms.tblDocumentTemplatesRow row = (dsPolicyForms.tblDocumentTemplatesRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) TemplateID,
        (object) TemplateName,
        (object) Description,
        (object) RequiresEdit,
        (object) TemplateDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.tblDocumentTemplatesRow FindByTemplateID(int TemplateID)
    {
      return (dsPolicyForms.tblDocumentTemplatesRow) this.Rows.Find(new object[1]
      {
        (object) TemplateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyForms.tblDocumentTemplatesDataTable templatesDataTable = (dsPolicyForms.tblDocumentTemplatesDataTable) base.Clone();
      templatesDataTable.InitVars();
      return (DataTable) templatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyForms.tblDocumentTemplatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnTemplateID = this.Columns["TemplateID"];
      this.columnTemplateName = this.Columns["TemplateName"];
      this.columnDescription = this.Columns["Description"];
      this.columnRequiresEdit = this.Columns["RequiresEdit"];
      this.columnTemplateDescription = this.Columns["TemplateDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnTemplateID = new DataColumn("TemplateID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateID);
      this.columnTemplateName = new DataColumn("TemplateName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateName);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnRequiresEdit = new DataColumn("RequiresEdit", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiresEdit);
      this.columnTemplateDescription = new DataColumn("TemplateDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnTemplateID
      }, true));
      this.columnTemplateID.AllowDBNull = false;
      this.columnTemplateID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.tblDocumentTemplatesRow NewtblDocumentTemplatesRow()
    {
      return (dsPolicyForms.tblDocumentTemplatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyForms.tblDocumentTemplatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyForms.tblDocumentTemplatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.tblDocumentTemplatesRowChangeEventHandler templatesRowChangedEvent = this.tblDocumentTemplatesRowChangedEvent;
      if (templatesRowChangedEvent == null)
        return;
      templatesRowChangedEvent((object) this, new dsPolicyForms.tblDocumentTemplatesRowChangeEvent((dsPolicyForms.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.tblDocumentTemplatesRowChangeEventHandler rowChangingEvent = this.tblDocumentTemplatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyForms.tblDocumentTemplatesRowChangeEvent((dsPolicyForms.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.tblDocumentTemplatesRowChangeEventHandler templatesRowDeletedEvent = this.tblDocumentTemplatesRowDeletedEvent;
      if (templatesRowDeletedEvent == null)
        return;
      templatesRowDeletedEvent((object) this, new dsPolicyForms.tblDocumentTemplatesRowChangeEvent((dsPolicyForms.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyForms.tblDocumentTemplatesRowChangeEventHandler rowDeletingEvent = this.tblDocumentTemplatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyForms.tblDocumentTemplatesRowChangeEvent((dsPolicyForms.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblDocumentTemplatesRow(dsPolicyForms.tblDocumentTemplatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyForms dsPolicyForms = new dsPolicyForms();
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
        FixedValue = dsPolicyForms.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblDocumentTemplatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyForms.GetSchemaSerializable();
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

  public class tblPolicyFormsRow : DataRow
  {
    private dsPolicyForms.tblPolicyFormsDataTable tabletblPolicyForms;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblPolicyFormsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblPolicyForms = (dsPolicyForms.tblPolicyFormsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int FormID
    {
      get => Conversions.ToInteger(this[this.tabletblPolicyForms.FormIDColumn]);
      set => this[this.tabletblPolicyForms.FormIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FormName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.FormNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FormName' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.FormNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int TemplateID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyForms.TemplateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TemplateID' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.TemplateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FormNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.FormNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FormNumber' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.FormNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool RequiresEndorsementNumber
    {
      get => Conversions.ToBoolean(this[this.tabletblPolicyForms.RequiresEndorsementNumberColumn]);
      set => this[this.tabletblPolicyForms.RequiresEndorsementNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid AutomationReportGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblPolicyForms.AutomationReportGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AutomationReportGuid' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.AutomationReportGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public byte[] PDF
    {
      get
      {
        try
        {
          return (byte[]) this[this.tabletblPolicyForms.PDFColumn];
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PDF' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.PDFColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PDF_Filename
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.PDF_FilenameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PDF_Filename' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.PDF_FilenameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ParentFormID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyForms.ParentFormIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ParentFormID' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.ParentFormIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EditionDate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.EditionDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EditionDate' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.EditionDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int FormTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyForms.FormTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FormTypeID' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.FormTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Comments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.CommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Comments' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.CommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string URL
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.URLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'URL' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.URLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool RequiresEdit
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPolicyForms.RequiresEditColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RequiresEdit' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.RequiresEditColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FilterCharacter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPolicyForms.FilterCharacterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FilterCharacter' in table 'tblPolicyForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyForms.FilterCharacterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.lstFormTypesRow lstFormTypesRow
    {
      get
      {
        return (dsPolicyForms.lstFormTypesRow) this.GetParentRow(this.Table.ParentRelations["FK_lstFormTypes_tblPolicyForms"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["FK_lstFormTypes_tblPolicyForms"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.AutomationReportsRow AutomationReportsRow
    {
      get
      {
        return (dsPolicyForms.AutomationReportsRow) this.GetParentRow(this.Table.ParentRelations["AutomationReportstblPolicyForms"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["AutomationReportstblPolicyForms"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.tblDocumentTemplatesRow tblDocumentTemplatesRow
    {
      get
      {
        return (dsPolicyForms.tblDocumentTemplatesRow) this.GetParentRow(this.Table.ParentRelations["tblDocumentTemplates_tblPolicyForms"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblDocumentTemplates_tblPolicyForms"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFormNameNull() => this.IsNull(this.tabletblPolicyForms.FormNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFormNameNull()
    {
      this[this.tabletblPolicyForms.FormNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tabletblPolicyForms.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tabletblPolicyForms.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTemplateIDNull() => this.IsNull(this.tabletblPolicyForms.TemplateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTemplateIDNull()
    {
      this[this.tabletblPolicyForms.TemplateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFormNumberNull() => this.IsNull(this.tabletblPolicyForms.FormNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFormNumberNull()
    {
      this[this.tabletblPolicyForms.FormNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAutomationReportGuidNull()
    {
      return this.IsNull(this.tabletblPolicyForms.AutomationReportGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAutomationReportGuidNull()
    {
      this[this.tabletblPolicyForms.AutomationReportGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPDFNull() => this.IsNull(this.tabletblPolicyForms.PDFColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPDFNull()
    {
      this[this.tabletblPolicyForms.PDFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPDF_FilenameNull() => this.IsNull(this.tabletblPolicyForms.PDF_FilenameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPDF_FilenameNull()
    {
      this[this.tabletblPolicyForms.PDF_FilenameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsParentFormIDNull() => this.IsNull(this.tabletblPolicyForms.ParentFormIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetParentFormIDNull()
    {
      this[this.tabletblPolicyForms.ParentFormIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEditionDateNull() => this.IsNull(this.tabletblPolicyForms.EditionDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEditionDateNull()
    {
      this[this.tabletblPolicyForms.EditionDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFormTypeIDNull() => this.IsNull(this.tabletblPolicyForms.FormTypeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFormTypeIDNull()
    {
      this[this.tabletblPolicyForms.FormTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCommentsNull() => this.IsNull(this.tabletblPolicyForms.CommentsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCommentsNull()
    {
      this[this.tabletblPolicyForms.CommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsURLNull() => this.IsNull(this.tabletblPolicyForms.URLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetURLNull()
    {
      this[this.tabletblPolicyForms.URLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRequiresEditNull() => this.IsNull(this.tabletblPolicyForms.RequiresEditColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRequiresEditNull()
    {
      this[this.tabletblPolicyForms.RequiresEditColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFilterCharacterNull()
    {
      return this.IsNull(this.tabletblPolicyForms.FilterCharacterColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFilterCharacterNull()
    {
      this[this.tabletblPolicyForms.FilterCharacterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class AutomationReportsRow : DataRow
  {
    private dsPolicyForms.AutomationReportsDataTable tableAutomationReports;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal AutomationReportsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAutomationReports = (dsPolicyForms.AutomationReportsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Title
    {
      get => Conversions.ToString(this[this.tableAutomationReports.TitleColumn]);
      set => this[this.tableAutomationReports.TitleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.tblPolicyFormsRow[] GettblPolicyFormsRows()
    {
      return this.Table.ChildRelations["AutomationReportstblPolicyForms"] != null ? (dsPolicyForms.tblPolicyFormsRow[]) this.GetChildRows(this.Table.ChildRelations["AutomationReportstblPolicyForms"]) : new dsPolicyForms.tblPolicyFormsRow[0];
    }
  }

  public class lstFormTypesRow : DataRow
  {
    private dsPolicyForms.lstFormTypesDataTable tablelstFormTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstFormTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstFormTypes = (dsPolicyForms.lstFormTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int FormTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablelstFormTypes.FormTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FormTypeID' in table 'lstFormTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstFormTypes.FormTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FormType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstFormTypes.FormTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FormType' in table 'lstFormTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstFormTypes.FormTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFormTypeIDNull() => this.IsNull(this.tablelstFormTypes.FormTypeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFormTypeIDNull()
    {
      this[this.tablelstFormTypes.FormTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFormTypeNull() => this.IsNull(this.tablelstFormTypes.FormTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFormTypeNull()
    {
      this[this.tablelstFormTypes.FormTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.tblPolicyFormsRow[] GettblPolicyFormsRows()
    {
      return this.Table.ChildRelations["FK_lstFormTypes_tblPolicyForms"] != null ? (dsPolicyForms.tblPolicyFormsRow[]) this.GetChildRows(this.Table.ChildRelations["FK_lstFormTypes_tblPolicyForms"]) : new dsPolicyForms.tblPolicyFormsRow[0];
    }
  }

  public class tblDocumentTemplatesRow : DataRow
  {
    private dsPolicyForms.tblDocumentTemplatesDataTable tabletblDocumentTemplates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblDocumentTemplatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDocumentTemplates = (dsPolicyForms.tblDocumentTemplatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int TemplateID
    {
      get => Conversions.ToInteger(this[this.tabletblDocumentTemplates.TemplateIDColumn]);
      set => this[this.tabletblDocumentTemplates.TemplateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string TemplateName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDocumentTemplates.TemplateNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TemplateName' in table 'tblDocumentTemplates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplates.TemplateNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDocumentTemplates.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'tblDocumentTemplates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplates.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool RequiresEdit
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblDocumentTemplates.RequiresEditColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RequiresEdit' in table 'tblDocumentTemplates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplates.RequiresEditColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string TemplateDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDocumentTemplates.TemplateDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TemplateDescription' in table 'tblDocumentTemplates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplates.TemplateDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTemplateNameNull()
    {
      return this.IsNull(this.tabletblDocumentTemplates.TemplateNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTemplateNameNull()
    {
      this[this.tabletblDocumentTemplates.TemplateNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDescriptionNull()
    {
      return this.IsNull(this.tabletblDocumentTemplates.DescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tabletblDocumentTemplates.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRequiresEditNull()
    {
      return this.IsNull(this.tabletblDocumentTemplates.RequiresEditColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRequiresEditNull()
    {
      this[this.tabletblDocumentTemplates.RequiresEditColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTemplateDescriptionNull()
    {
      return this.IsNull(this.tabletblDocumentTemplates.TemplateDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTemplateDescriptionNull()
    {
      this[this.tabletblDocumentTemplates.TemplateDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.tblPolicyFormsRow[] GettblPolicyFormsRows()
    {
      return this.Table.ChildRelations["tblDocumentTemplates_tblPolicyForms"] != null ? (dsPolicyForms.tblPolicyFormsRow[]) this.GetChildRows(this.Table.ChildRelations["tblDocumentTemplates_tblPolicyForms"]) : new dsPolicyForms.tblPolicyFormsRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblPolicyFormsRowChangeEvent : EventArgs
  {
    private dsPolicyForms.tblPolicyFormsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblPolicyFormsRowChangeEvent(dsPolicyForms.tblPolicyFormsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.tblPolicyFormsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class AutomationReportsRowChangeEvent : EventArgs
  {
    private dsPolicyForms.AutomationReportsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public AutomationReportsRowChangeEvent(
      dsPolicyForms.AutomationReportsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.AutomationReportsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstFormTypesRowChangeEvent : EventArgs
  {
    private dsPolicyForms.lstFormTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstFormTypesRowChangeEvent(dsPolicyForms.lstFormTypesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.lstFormTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblDocumentTemplatesRowChangeEvent : EventArgs
  {
    private dsPolicyForms.tblDocumentTemplatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblDocumentTemplatesRowChangeEvent(
      dsPolicyForms.tblDocumentTemplatesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsPolicyForms.tblDocumentTemplatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
