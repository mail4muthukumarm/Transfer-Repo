// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.dsDocumentTemplates
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
[XmlRoot("dsDocumentTemplates")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsDocumentTemplates : DataSet
{
  private dsDocumentTemplates.tblDocumentTemplatesDataTable tabletblDocumentTemplates;
  private dsDocumentTemplates.lstDocumentAutomationGroupsDataTable tablelstDocumentAutomationGroups;
  private dsDocumentTemplates.tblDocumentTemplatesListDataTable tabletblDocumentTemplatesList;
  private dsDocumentTemplates.lstTemplateDocumentGroupsDataTable tablelstTemplateDocumentGroups;
  private DataRelation relationlstTemplateDocumentGroupstblDocumentTemplates;
  private DataRelation relationlstDocumentAutomationGroupstblDocumentTemplatesList;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public dsDocumentTemplates()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected dsDocumentTemplates(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblDocumentTemplates)] != null)
          base.Tables.Add((DataTable) new dsDocumentTemplates.tblDocumentTemplatesDataTable(dataSet.Tables[nameof (tblDocumentTemplates)]));
        if (dataSet.Tables[nameof (lstDocumentAutomationGroups)] != null)
          base.Tables.Add((DataTable) new dsDocumentTemplates.lstDocumentAutomationGroupsDataTable(dataSet.Tables[nameof (lstDocumentAutomationGroups)]));
        if (dataSet.Tables[nameof (tblDocumentTemplatesList)] != null)
          base.Tables.Add((DataTable) new dsDocumentTemplates.tblDocumentTemplatesListDataTable(dataSet.Tables[nameof (tblDocumentTemplatesList)]));
        if (dataSet.Tables[nameof (lstTemplateDocumentGroups)] != null)
          base.Tables.Add((DataTable) new dsDocumentTemplates.lstTemplateDocumentGroupsDataTable(dataSet.Tables[nameof (lstTemplateDocumentGroups)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDocumentTemplates.tblDocumentTemplatesDataTable tblDocumentTemplates
  {
    get => this.tabletblDocumentTemplates;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDocumentTemplates.lstDocumentAutomationGroupsDataTable lstDocumentAutomationGroups
  {
    get => this.tablelstDocumentAutomationGroups;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDocumentTemplates.tblDocumentTemplatesListDataTable tblDocumentTemplatesList
  {
    get => this.tabletblDocumentTemplatesList;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDocumentTemplates.lstTemplateDocumentGroupsDataTable lstTemplateDocumentGroups
  {
    get => this.tablelstTemplateDocumentGroups;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public override DataSet Clone()
  {
    dsDocumentTemplates documentTemplates = (dsDocumentTemplates) base.Clone();
    documentTemplates.InitVars();
    documentTemplates.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) documentTemplates;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["tblDocumentTemplates"] != null)
        base.Tables.Add((DataTable) new dsDocumentTemplates.tblDocumentTemplatesDataTable(dataSet.Tables["tblDocumentTemplates"]));
      if (dataSet.Tables["lstDocumentAutomationGroups"] != null)
        base.Tables.Add((DataTable) new dsDocumentTemplates.lstDocumentAutomationGroupsDataTable(dataSet.Tables["lstDocumentAutomationGroups"]));
      if (dataSet.Tables["tblDocumentTemplatesList"] != null)
        base.Tables.Add((DataTable) new dsDocumentTemplates.tblDocumentTemplatesListDataTable(dataSet.Tables["tblDocumentTemplatesList"]));
      if (dataSet.Tables["lstTemplateDocumentGroups"] != null)
        base.Tables.Add((DataTable) new dsDocumentTemplates.lstTemplateDocumentGroupsDataTable(dataSet.Tables["lstTemplateDocumentGroups"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tabletblDocumentTemplates = (dsDocumentTemplates.tblDocumentTemplatesDataTable) base.Tables["tblDocumentTemplates"];
    if (initTable && this.tabletblDocumentTemplates != null)
      this.tabletblDocumentTemplates.InitVars();
    this.tablelstDocumentAutomationGroups = (dsDocumentTemplates.lstDocumentAutomationGroupsDataTable) base.Tables["lstDocumentAutomationGroups"];
    if (initTable && this.tablelstDocumentAutomationGroups != null)
      this.tablelstDocumentAutomationGroups.InitVars();
    this.tabletblDocumentTemplatesList = (dsDocumentTemplates.tblDocumentTemplatesListDataTable) base.Tables["tblDocumentTemplatesList"];
    if (initTable && this.tabletblDocumentTemplatesList != null)
      this.tabletblDocumentTemplatesList.InitVars();
    this.tablelstTemplateDocumentGroups = (dsDocumentTemplates.lstTemplateDocumentGroupsDataTable) base.Tables["lstTemplateDocumentGroups"];
    if (initTable && this.tablelstTemplateDocumentGroups != null)
      this.tablelstTemplateDocumentGroups.InitVars();
    this.relationlstTemplateDocumentGroupstblDocumentTemplates = this.Relations["lstTemplateDocumentGroupstblDocumentTemplates"];
    this.relationlstDocumentAutomationGroupstblDocumentTemplatesList = this.Relations["lstDocumentAutomationGroupstblDocumentTemplatesList"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsDocumentTemplates);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsDocumentTemplates.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblDocumentTemplates = new dsDocumentTemplates.tblDocumentTemplatesDataTable();
    base.Tables.Add((DataTable) this.tabletblDocumentTemplates);
    this.tablelstDocumentAutomationGroups = new dsDocumentTemplates.lstDocumentAutomationGroupsDataTable();
    base.Tables.Add((DataTable) this.tablelstDocumentAutomationGroups);
    this.tabletblDocumentTemplatesList = new dsDocumentTemplates.tblDocumentTemplatesListDataTable();
    base.Tables.Add((DataTable) this.tabletblDocumentTemplatesList);
    this.tablelstTemplateDocumentGroups = new dsDocumentTemplates.lstTemplateDocumentGroupsDataTable();
    base.Tables.Add((DataTable) this.tablelstTemplateDocumentGroups);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("lstTemplateDocumentGroupstblDocumentTemplates", new DataColumn[1]
    {
      this.tablelstTemplateDocumentGroups.GroupIDColumn
    }, new DataColumn[1]
    {
      this.tabletblDocumentTemplates.TemplateGroupIDColumn
    });
    this.tabletblDocumentTemplates.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstDocumentAutomationGroupstblDocumentTemplatesList", new DataColumn[1]
    {
      this.tablelstDocumentAutomationGroups.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblDocumentTemplatesList.AutomationGroupIDColumn
    });
    this.tabletblDocumentTemplatesList.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    this.relationlstTemplateDocumentGroupstblDocumentTemplates = new DataRelation("lstTemplateDocumentGroupstblDocumentTemplates", new DataColumn[1]
    {
      this.tablelstTemplateDocumentGroups.GroupIDColumn
    }, new DataColumn[1]
    {
      this.tabletblDocumentTemplates.TemplateGroupIDColumn
    }, false);
    this.Relations.Add(this.relationlstTemplateDocumentGroupstblDocumentTemplates);
    this.relationlstDocumentAutomationGroupstblDocumentTemplatesList = new DataRelation("lstDocumentAutomationGroupstblDocumentTemplatesList", new DataColumn[1]
    {
      this.tablelstDocumentAutomationGroups.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblDocumentTemplatesList.AutomationGroupIDColumn
    }, false);
    this.Relations.Add(this.relationlstDocumentAutomationGroupstblDocumentTemplatesList);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblDocumentTemplates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializelstDocumentAutomationGroups() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblDocumentTemplatesList() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializelstTemplateDocumentGroups() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsDocumentTemplates documentTemplates = new dsDocumentTemplates();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = documentTemplates.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = documentTemplates.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblDocumentTemplatesRowChangeEventHandler(
    object sender,
    dsDocumentTemplates.tblDocumentTemplatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void lstDocumentAutomationGroupsRowChangeEventHandler(
    object sender,
    dsDocumentTemplates.lstDocumentAutomationGroupsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblDocumentTemplatesListRowChangeEventHandler(
    object sender,
    dsDocumentTemplates.tblDocumentTemplatesListRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void lstTemplateDocumentGroupsRowChangeEventHandler(
    object sender,
    dsDocumentTemplates.lstTemplateDocumentGroupsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblDocumentTemplatesDataTable : 
    TypedTableBase<dsDocumentTemplates.tblDocumentTemplatesRow>
  {
    private DataColumn columnTemplate;
    private DataColumn columnTemplateType;
    private DataColumn columnAutomationGroupID;
    private DataColumn columnTemplateName;
    private DataColumn columnDescription;
    private DataColumn columnTemplateID;
    private DataColumn columnFolderID;
    private DataColumn columnTemplateGroupID;
    private DataColumn columnIsPolicyForm;
    private DataColumn columnIsEditable;
    private DataColumn columnSaveAsType;
    private DataColumn columnFileOnly;
    private DataColumn columnSeparateDoc;
    private DataColumn columnRemovable;
    private DataColumn columnHideWaterMark;
    private DataColumn columnIsEmail;
    private DataColumn columnFileOnlyName;
    private DataColumn columnSeparateDocName;
    private DataColumn columnRequiresEdit;
    private DataColumn columnCopyForwardOnRenewal;
    private DataColumn columnHidden;
    private DataColumn columnOnDemand;
    private DataColumn columnOriginalFileName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblDocumentTemplatesDataTable()
    {
      this.TableName = "tblDocumentTemplates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected tblDocumentTemplatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TemplateColumn => this.columnTemplate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TemplateTypeColumn => this.columnTemplateType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AutomationGroupIDColumn => this.columnAutomationGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TemplateNameColumn => this.columnTemplateName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TemplateIDColumn => this.columnTemplateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FolderIDColumn => this.columnFolderID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TemplateGroupIDColumn => this.columnTemplateGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn IsPolicyFormColumn => this.columnIsPolicyForm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn IsEditableColumn => this.columnIsEditable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn SaveAsTypeColumn => this.columnSaveAsType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FileOnlyColumn => this.columnFileOnly;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn SeparateDocColumn => this.columnSeparateDoc;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn RemovableColumn => this.columnRemovable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn HideWaterMarkColumn => this.columnHideWaterMark;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn IsEmailColumn => this.columnIsEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FileOnlyNameColumn => this.columnFileOnlyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn SeparateDocNameColumn => this.columnSeparateDocName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn RequiresEditColumn => this.columnRequiresEdit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CopyForwardOnRenewalColumn => this.columnCopyForwardOnRenewal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn OnDemandColumn => this.columnOnDemand;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn OriginalFileNameColumn => this.columnOriginalFileName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.tblDocumentTemplatesRow this[int index]
    {
      get => (dsDocumentTemplates.tblDocumentTemplatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblDocumentTemplatesRow(dsDocumentTemplates.tblDocumentTemplatesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.tblDocumentTemplatesRow AddtblDocumentTemplatesRow(
      byte[] Template,
      string TemplateType,
      int AutomationGroupID,
      string TemplateName,
      string Description,
      int FolderID,
      dsDocumentTemplates.lstTemplateDocumentGroupsRow parentlstTemplateDocumentGroupsRowBylstTemplateDocumentGroupstblDocumentTemplates,
      bool IsPolicyForm,
      bool IsEditable,
      string SaveAsType,
      bool FileOnly,
      bool SeparateDoc,
      bool Removable,
      bool HideWaterMark,
      bool IsEmail,
      string FileOnlyName,
      string SeparateDocName,
      bool RequiresEdit,
      bool CopyForwardOnRenewal,
      bool Hidden,
      bool OnDemand,
      string OriginalFileName)
    {
      dsDocumentTemplates.tblDocumentTemplatesRow row = (dsDocumentTemplates.tblDocumentTemplatesRow) this.NewRow();
      object[] objArray = new object[23]
      {
        (object) Template,
        (object) TemplateType,
        (object) AutomationGroupID,
        (object) TemplateName,
        (object) Description,
        null,
        (object) FolderID,
        null,
        (object) IsPolicyForm,
        (object) IsEditable,
        (object) SaveAsType,
        (object) FileOnly,
        (object) SeparateDoc,
        (object) Removable,
        (object) HideWaterMark,
        (object) IsEmail,
        (object) FileOnlyName,
        (object) SeparateDocName,
        (object) RequiresEdit,
        (object) CopyForwardOnRenewal,
        (object) Hidden,
        (object) OnDemand,
        (object) OriginalFileName
      };
      if (parentlstTemplateDocumentGroupsRowBylstTemplateDocumentGroupstblDocumentTemplates != null)
        objArray[7] = RuntimeHelpers.GetObjectValue(parentlstTemplateDocumentGroupsRowBylstTemplateDocumentGroupstblDocumentTemplates[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.tblDocumentTemplatesRow FindByTemplateID(int TemplateID)
    {
      return (dsDocumentTemplates.tblDocumentTemplatesRow) this.Rows.Find(new object[1]
      {
        (object) TemplateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsDocumentTemplates.tblDocumentTemplatesDataTable templatesDataTable = (dsDocumentTemplates.tblDocumentTemplatesDataTable) base.Clone();
      templatesDataTable.InitVars();
      return (DataTable) templatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDocumentTemplates.tblDocumentTemplatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnTemplate = this.Columns["Template"];
      this.columnTemplateType = this.Columns["TemplateType"];
      this.columnAutomationGroupID = this.Columns["AutomationGroupID"];
      this.columnTemplateName = this.Columns["TemplateName"];
      this.columnDescription = this.Columns["Description"];
      this.columnTemplateID = this.Columns["TemplateID"];
      this.columnFolderID = this.Columns["FolderID"];
      this.columnTemplateGroupID = this.Columns["TemplateGroupID"];
      this.columnIsPolicyForm = this.Columns["IsPolicyForm"];
      this.columnIsEditable = this.Columns["IsEditable"];
      this.columnSaveAsType = this.Columns["SaveAsType"];
      this.columnFileOnly = this.Columns["FileOnly"];
      this.columnSeparateDoc = this.Columns["SeparateDoc"];
      this.columnRemovable = this.Columns["Removable"];
      this.columnHideWaterMark = this.Columns["HideWaterMark"];
      this.columnIsEmail = this.Columns["IsEmail"];
      this.columnFileOnlyName = this.Columns["FileOnlyName"];
      this.columnSeparateDocName = this.Columns["SeparateDocName"];
      this.columnRequiresEdit = this.Columns["RequiresEdit"];
      this.columnCopyForwardOnRenewal = this.Columns["CopyForwardOnRenewal"];
      this.columnHidden = this.Columns["Hidden"];
      this.columnOnDemand = this.Columns["OnDemand"];
      this.columnOriginalFileName = this.Columns["OriginalFileName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnTemplate = new DataColumn("Template", typeof (byte[]), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplate);
      this.columnTemplateType = new DataColumn("TemplateType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateType);
      this.columnAutomationGroupID = new DataColumn("AutomationGroupID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationGroupID);
      this.columnTemplateName = new DataColumn("TemplateName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateName);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnTemplateID = new DataColumn("TemplateID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateID);
      this.columnFolderID = new DataColumn("FolderID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFolderID);
      this.columnTemplateGroupID = new DataColumn("TemplateGroupID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateGroupID);
      this.columnIsPolicyForm = new DataColumn("IsPolicyForm", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsPolicyForm);
      this.columnIsEditable = new DataColumn("IsEditable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsEditable);
      this.columnSaveAsType = new DataColumn("SaveAsType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSaveAsType);
      this.columnFileOnly = new DataColumn("FileOnly", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFileOnly);
      this.columnSeparateDoc = new DataColumn("SeparateDoc", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSeparateDoc);
      this.columnRemovable = new DataColumn("Removable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemovable);
      this.columnHideWaterMark = new DataColumn("HideWaterMark", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHideWaterMark);
      this.columnIsEmail = new DataColumn("IsEmail", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsEmail);
      this.columnFileOnlyName = new DataColumn("FileOnlyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFileOnlyName);
      this.columnSeparateDocName = new DataColumn("SeparateDocName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSeparateDocName);
      this.columnRequiresEdit = new DataColumn("RequiresEdit", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiresEdit);
      this.columnCopyForwardOnRenewal = new DataColumn("CopyForwardOnRenewal", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCopyForwardOnRenewal);
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.columnOnDemand = new DataColumn("OnDemand", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOnDemand);
      this.columnOriginalFileName = new DataColumn("OriginalFileName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOriginalFileName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnTemplateID
      }, true));
      this.columnTemplate.AllowDBNull = false;
      this.columnTemplateType.AllowDBNull = false;
      this.columnAutomationGroupID.AllowDBNull = false;
      this.columnTemplateName.AllowDBNull = false;
      this.columnDescription.AllowDBNull = false;
      this.columnTemplateID.AutoIncrement = true;
      this.columnTemplateID.AllowDBNull = false;
      this.columnTemplateID.ReadOnly = true;
      this.columnTemplateID.Unique = true;
      this.columnIsPolicyForm.AllowDBNull = false;
      this.columnIsPolicyForm.DefaultValue = (object) true;
      this.columnIsEditable.AllowDBNull = false;
      this.columnIsEditable.DefaultValue = (object) true;
      this.columnFileOnly.AllowDBNull = false;
      this.columnFileOnly.DefaultValue = (object) false;
      this.columnSeparateDoc.AllowDBNull = false;
      this.columnSeparateDoc.DefaultValue = (object) false;
      this.columnRemovable.AllowDBNull = false;
      this.columnRemovable.DefaultValue = (object) false;
      this.columnHideWaterMark.DefaultValue = (object) false;
      this.columnIsEmail.AllowDBNull = false;
      this.columnIsEmail.DefaultValue = (object) false;
      this.columnRequiresEdit.AllowDBNull = false;
      this.columnRequiresEdit.DefaultValue = (object) false;
      this.columnCopyForwardOnRenewal.DefaultValue = (object) true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.tblDocumentTemplatesRow NewtblDocumentTemplatesRow()
    {
      return (dsDocumentTemplates.tblDocumentTemplatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDocumentTemplates.tblDocumentTemplatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsDocumentTemplates.tblDocumentTemplatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.tblDocumentTemplatesRowChangeEventHandler templatesRowChangedEvent = this.tblDocumentTemplatesRowChangedEvent;
      if (templatesRowChangedEvent == null)
        return;
      templatesRowChangedEvent((object) this, new dsDocumentTemplates.tblDocumentTemplatesRowChangeEvent((dsDocumentTemplates.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.tblDocumentTemplatesRowChangeEventHandler rowChangingEvent = this.tblDocumentTemplatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDocumentTemplates.tblDocumentTemplatesRowChangeEvent((dsDocumentTemplates.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.tblDocumentTemplatesRowChangeEventHandler templatesRowDeletedEvent = this.tblDocumentTemplatesRowDeletedEvent;
      if (templatesRowDeletedEvent == null)
        return;
      templatesRowDeletedEvent((object) this, new dsDocumentTemplates.tblDocumentTemplatesRowChangeEvent((dsDocumentTemplates.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.tblDocumentTemplatesRowChangeEventHandler rowDeletingEvent = this.tblDocumentTemplatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDocumentTemplates.tblDocumentTemplatesRowChangeEvent((dsDocumentTemplates.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblDocumentTemplatesRow(dsDocumentTemplates.tblDocumentTemplatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDocumentTemplates documentTemplates = new dsDocumentTemplates();
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
        FixedValue = documentTemplates.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblDocumentTemplatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = documentTemplates.GetSchemaSerializable();
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
    TypedTableBase<dsDocumentTemplates.lstDocumentAutomationGroupsRow>
  {
    private DataColumn columnID;
    private DataColumn columnTemplateGroup;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public lstDocumentAutomationGroupsDataTable()
    {
      this.TableName = "lstDocumentAutomationGroups";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected lstDocumentAutomationGroupsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TemplateGroupColumn => this.columnTemplateGroup;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.lstDocumentAutomationGroupsRow this[int index]
    {
      get => (dsDocumentTemplates.lstDocumentAutomationGroupsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.lstDocumentAutomationGroupsRowChangeEventHandler lstDocumentAutomationGroupsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.lstDocumentAutomationGroupsRowChangeEventHandler lstDocumentAutomationGroupsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.lstDocumentAutomationGroupsRowChangeEventHandler lstDocumentAutomationGroupsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.lstDocumentAutomationGroupsRowChangeEventHandler lstDocumentAutomationGroupsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddlstDocumentAutomationGroupsRow(
      dsDocumentTemplates.lstDocumentAutomationGroupsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.lstDocumentAutomationGroupsRow AddlstDocumentAutomationGroupsRow(
      int ID,
      string TemplateGroup)
    {
      dsDocumentTemplates.lstDocumentAutomationGroupsRow row = (dsDocumentTemplates.lstDocumentAutomationGroupsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) TemplateGroup
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.lstDocumentAutomationGroupsRow FindByID(int ID)
    {
      return (dsDocumentTemplates.lstDocumentAutomationGroupsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsDocumentTemplates.lstDocumentAutomationGroupsDataTable automationGroupsDataTable = (dsDocumentTemplates.lstDocumentAutomationGroupsDataTable) base.Clone();
      automationGroupsDataTable.InitVars();
      return (DataTable) automationGroupsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDocumentTemplates.lstDocumentAutomationGroupsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnTemplateGroup = this.Columns["TemplateGroup"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnTemplateGroup = new DataColumn("TemplateGroup", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateGroup);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsDocumentTemplatesKey1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.Unique = true;
      this.columnTemplateGroup.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.lstDocumentAutomationGroupsRow NewlstDocumentAutomationGroupsRow()
    {
      return (dsDocumentTemplates.lstDocumentAutomationGroupsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDocumentTemplates.lstDocumentAutomationGroupsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsDocumentTemplates.lstDocumentAutomationGroupsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDocumentAutomationGroupsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.lstDocumentAutomationGroupsRowChangeEventHandler groupsRowChangedEvent = this.lstDocumentAutomationGroupsRowChangedEvent;
      if (groupsRowChangedEvent == null)
        return;
      groupsRowChangedEvent((object) this, new dsDocumentTemplates.lstDocumentAutomationGroupsRowChangeEvent((dsDocumentTemplates.lstDocumentAutomationGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDocumentAutomationGroupsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.lstDocumentAutomationGroupsRowChangeEventHandler rowChangingEvent = this.lstDocumentAutomationGroupsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDocumentTemplates.lstDocumentAutomationGroupsRowChangeEvent((dsDocumentTemplates.lstDocumentAutomationGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDocumentAutomationGroupsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.lstDocumentAutomationGroupsRowChangeEventHandler groupsRowDeletedEvent = this.lstDocumentAutomationGroupsRowDeletedEvent;
      if (groupsRowDeletedEvent == null)
        return;
      groupsRowDeletedEvent((object) this, new dsDocumentTemplates.lstDocumentAutomationGroupsRowChangeEvent((dsDocumentTemplates.lstDocumentAutomationGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDocumentAutomationGroupsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.lstDocumentAutomationGroupsRowChangeEventHandler rowDeletingEvent = this.lstDocumentAutomationGroupsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDocumentTemplates.lstDocumentAutomationGroupsRowChangeEvent((dsDocumentTemplates.lstDocumentAutomationGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovelstDocumentAutomationGroupsRow(
      dsDocumentTemplates.lstDocumentAutomationGroupsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDocumentTemplates documentTemplates = new dsDocumentTemplates();
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
        FixedValue = documentTemplates.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstDocumentAutomationGroupsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = documentTemplates.GetSchemaSerializable();
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
  public class tblDocumentTemplatesListDataTable : 
    TypedTableBase<dsDocumentTemplates.tblDocumentTemplatesListRow>
  {
    private DataColumn columnTemplateID;
    private DataColumn columnAutomationGroupID;
    private DataColumn columnTemplateName;
    private DataColumn columnDescription;
    private DataColumn columnTemplateGroupID;
    private DataColumn columnTemplateType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblDocumentTemplatesListDataTable()
    {
      this.TableName = "tblDocumentTemplatesList";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblDocumentTemplatesListDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected tblDocumentTemplatesListDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TemplateIDColumn => this.columnTemplateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AutomationGroupIDColumn => this.columnAutomationGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TemplateNameColumn => this.columnTemplateName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TemplateGroupIDColumn => this.columnTemplateGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TemplateTypeColumn => this.columnTemplateType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.tblDocumentTemplatesListRow this[int index]
    {
      get => (dsDocumentTemplates.tblDocumentTemplatesListRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.tblDocumentTemplatesListRowChangeEventHandler tblDocumentTemplatesListRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.tblDocumentTemplatesListRowChangeEventHandler tblDocumentTemplatesListRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.tblDocumentTemplatesListRowChangeEventHandler tblDocumentTemplatesListRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.tblDocumentTemplatesListRowChangeEventHandler tblDocumentTemplatesListRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblDocumentTemplatesListRow(
      dsDocumentTemplates.tblDocumentTemplatesListRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.tblDocumentTemplatesListRow AddtblDocumentTemplatesListRow(
      dsDocumentTemplates.lstDocumentAutomationGroupsRow parentlstDocumentAutomationGroupsRowBylstDocumentAutomationGroupstblDocumentTemplatesList,
      string TemplateName,
      string Description,
      int TemplateGroupID,
      string TemplateType)
    {
      dsDocumentTemplates.tblDocumentTemplatesListRow row = (dsDocumentTemplates.tblDocumentTemplatesListRow) this.NewRow();
      object[] objArray = new object[6]
      {
        null,
        null,
        (object) TemplateName,
        (object) Description,
        (object) TemplateGroupID,
        (object) TemplateType
      };
      if (parentlstDocumentAutomationGroupsRowBylstDocumentAutomationGroupstblDocumentTemplatesList != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstDocumentAutomationGroupsRowBylstDocumentAutomationGroupstblDocumentTemplatesList[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.tblDocumentTemplatesListRow FindByTemplateID(int TemplateID)
    {
      return (dsDocumentTemplates.tblDocumentTemplatesListRow) this.Rows.Find(new object[1]
      {
        (object) TemplateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsDocumentTemplates.tblDocumentTemplatesListDataTable templatesListDataTable = (dsDocumentTemplates.tblDocumentTemplatesListDataTable) base.Clone();
      templatesListDataTable.InitVars();
      return (DataTable) templatesListDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDocumentTemplates.tblDocumentTemplatesListDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnTemplateID = this.Columns["TemplateID"];
      this.columnAutomationGroupID = this.Columns["AutomationGroupID"];
      this.columnTemplateName = this.Columns["TemplateName"];
      this.columnDescription = this.Columns["Description"];
      this.columnTemplateGroupID = this.Columns["TemplateGroupID"];
      this.columnTemplateType = this.Columns["TemplateType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnTemplateID = new DataColumn("TemplateID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateID);
      this.columnAutomationGroupID = new DataColumn("AutomationGroupID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationGroupID);
      this.columnTemplateName = new DataColumn("TemplateName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateName);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnTemplateGroupID = new DataColumn("TemplateGroupID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateGroupID);
      this.columnTemplateType = new DataColumn("TemplateType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsDocumentTemplatesKey2", new DataColumn[1]
      {
        this.columnTemplateID
      }, true));
      this.columnTemplateID.AutoIncrement = true;
      this.columnTemplateID.AllowDBNull = false;
      this.columnTemplateID.ReadOnly = true;
      this.columnTemplateID.Unique = true;
      this.columnAutomationGroupID.AllowDBNull = false;
      this.columnTemplateName.AllowDBNull = false;
      this.columnDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.tblDocumentTemplatesListRow NewtblDocumentTemplatesListRow()
    {
      return (dsDocumentTemplates.tblDocumentTemplatesListRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDocumentTemplates.tblDocumentTemplatesListRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsDocumentTemplates.tblDocumentTemplatesListRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesListRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.tblDocumentTemplatesListRowChangeEventHandler listRowChangedEvent = this.tblDocumentTemplatesListRowChangedEvent;
      if (listRowChangedEvent == null)
        return;
      listRowChangedEvent((object) this, new dsDocumentTemplates.tblDocumentTemplatesListRowChangeEvent((dsDocumentTemplates.tblDocumentTemplatesListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesListRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.tblDocumentTemplatesListRowChangeEventHandler rowChangingEvent = this.tblDocumentTemplatesListRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDocumentTemplates.tblDocumentTemplatesListRowChangeEvent((dsDocumentTemplates.tblDocumentTemplatesListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesListRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.tblDocumentTemplatesListRowChangeEventHandler listRowDeletedEvent = this.tblDocumentTemplatesListRowDeletedEvent;
      if (listRowDeletedEvent == null)
        return;
      listRowDeletedEvent((object) this, new dsDocumentTemplates.tblDocumentTemplatesListRowChangeEvent((dsDocumentTemplates.tblDocumentTemplatesListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesListRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.tblDocumentTemplatesListRowChangeEventHandler rowDeletingEvent = this.tblDocumentTemplatesListRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDocumentTemplates.tblDocumentTemplatesListRowChangeEvent((dsDocumentTemplates.tblDocumentTemplatesListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblDocumentTemplatesListRow(
      dsDocumentTemplates.tblDocumentTemplatesListRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDocumentTemplates documentTemplates = new dsDocumentTemplates();
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
        FixedValue = documentTemplates.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblDocumentTemplatesListDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = documentTemplates.GetSchemaSerializable();
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
  public class lstTemplateDocumentGroupsDataTable : 
    TypedTableBase<dsDocumentTemplates.lstTemplateDocumentGroupsRow>
  {
    private DataColumn columnGroupID;
    private DataColumn columnTemplateGroup;
    private DataColumn columnAutomationGroupID;
    private DataColumn columnParentTemplateGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public lstTemplateDocumentGroupsDataTable()
    {
      this.TableName = "lstTemplateDocumentGroups";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal lstTemplateDocumentGroupsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected lstTemplateDocumentGroupsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn GroupIDColumn => this.columnGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TemplateGroupColumn => this.columnTemplateGroup;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AutomationGroupIDColumn => this.columnAutomationGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ParentTemplateGroupIDColumn => this.columnParentTemplateGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.lstTemplateDocumentGroupsRow this[int index]
    {
      get => (dsDocumentTemplates.lstTemplateDocumentGroupsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.lstTemplateDocumentGroupsRowChangeEventHandler lstTemplateDocumentGroupsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.lstTemplateDocumentGroupsRowChangeEventHandler lstTemplateDocumentGroupsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.lstTemplateDocumentGroupsRowChangeEventHandler lstTemplateDocumentGroupsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsDocumentTemplates.lstTemplateDocumentGroupsRowChangeEventHandler lstTemplateDocumentGroupsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddlstTemplateDocumentGroupsRow(
      dsDocumentTemplates.lstTemplateDocumentGroupsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.lstTemplateDocumentGroupsRow AddlstTemplateDocumentGroupsRow(
      string TemplateGroup,
      int AutomationGroupID,
      int ParentTemplateGroupID)
    {
      dsDocumentTemplates.lstTemplateDocumentGroupsRow row = (dsDocumentTemplates.lstTemplateDocumentGroupsRow) this.NewRow();
      object[] objArray = new object[4]
      {
        null,
        (object) TemplateGroup,
        (object) AutomationGroupID,
        (object) ParentTemplateGroupID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.lstTemplateDocumentGroupsRow FindByGroupID(int GroupID)
    {
      return (dsDocumentTemplates.lstTemplateDocumentGroupsRow) this.Rows.Find(new object[1]
      {
        (object) GroupID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsDocumentTemplates.lstTemplateDocumentGroupsDataTable documentGroupsDataTable = (dsDocumentTemplates.lstTemplateDocumentGroupsDataTable) base.Clone();
      documentGroupsDataTable.InitVars();
      return (DataTable) documentGroupsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDocumentTemplates.lstTemplateDocumentGroupsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnGroupID = this.Columns["GroupID"];
      this.columnTemplateGroup = this.Columns["TemplateGroup"];
      this.columnAutomationGroupID = this.Columns["AutomationGroupID"];
      this.columnParentTemplateGroupID = this.Columns["ParentTemplateGroupID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnGroupID = new DataColumn("GroupID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGroupID);
      this.columnTemplateGroup = new DataColumn("TemplateGroup", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateGroup);
      this.columnAutomationGroupID = new DataColumn("AutomationGroupID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationGroupID);
      this.columnParentTemplateGroupID = new DataColumn("ParentTemplateGroupID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParentTemplateGroupID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsDocumentTemplatesKey3", new DataColumn[1]
      {
        this.columnGroupID
      }, true));
      this.columnGroupID.AutoIncrement = true;
      this.columnGroupID.AllowDBNull = false;
      this.columnGroupID.ReadOnly = true;
      this.columnGroupID.Unique = true;
      this.columnTemplateGroup.AllowDBNull = false;
      this.columnAutomationGroupID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.lstTemplateDocumentGroupsRow NewlstTemplateDocumentGroupsRow()
    {
      return (dsDocumentTemplates.lstTemplateDocumentGroupsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDocumentTemplates.lstTemplateDocumentGroupsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsDocumentTemplates.lstTemplateDocumentGroupsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstTemplateDocumentGroupsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.lstTemplateDocumentGroupsRowChangeEventHandler groupsRowChangedEvent = this.lstTemplateDocumentGroupsRowChangedEvent;
      if (groupsRowChangedEvent == null)
        return;
      groupsRowChangedEvent((object) this, new dsDocumentTemplates.lstTemplateDocumentGroupsRowChangeEvent((dsDocumentTemplates.lstTemplateDocumentGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstTemplateDocumentGroupsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.lstTemplateDocumentGroupsRowChangeEventHandler rowChangingEvent = this.lstTemplateDocumentGroupsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDocumentTemplates.lstTemplateDocumentGroupsRowChangeEvent((dsDocumentTemplates.lstTemplateDocumentGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstTemplateDocumentGroupsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.lstTemplateDocumentGroupsRowChangeEventHandler groupsRowDeletedEvent = this.lstTemplateDocumentGroupsRowDeletedEvent;
      if (groupsRowDeletedEvent == null)
        return;
      groupsRowDeletedEvent((object) this, new dsDocumentTemplates.lstTemplateDocumentGroupsRowChangeEvent((dsDocumentTemplates.lstTemplateDocumentGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstTemplateDocumentGroupsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocumentTemplates.lstTemplateDocumentGroupsRowChangeEventHandler rowDeletingEvent = this.lstTemplateDocumentGroupsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDocumentTemplates.lstTemplateDocumentGroupsRowChangeEvent((dsDocumentTemplates.lstTemplateDocumentGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovelstTemplateDocumentGroupsRow(
      dsDocumentTemplates.lstTemplateDocumentGroupsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDocumentTemplates documentTemplates = new dsDocumentTemplates();
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
        FixedValue = documentTemplates.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstTemplateDocumentGroupsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = documentTemplates.GetSchemaSerializable();
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

  public class tblDocumentTemplatesRow : DataRow
  {
    private dsDocumentTemplates.tblDocumentTemplatesDataTable tabletblDocumentTemplates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblDocumentTemplatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDocumentTemplates = (dsDocumentTemplates.tblDocumentTemplatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public byte[] Template
    {
      get => (byte[]) this[this.tabletblDocumentTemplates.TemplateColumn];
      set => this[this.tabletblDocumentTemplates.TemplateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string TemplateType
    {
      get => Conversions.ToString(this[this.tabletblDocumentTemplates.TemplateTypeColumn]);
      set => this[this.tabletblDocumentTemplates.TemplateTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int AutomationGroupID
    {
      get => Conversions.ToInteger(this[this.tabletblDocumentTemplates.AutomationGroupIDColumn]);
      set => this[this.tabletblDocumentTemplates.AutomationGroupIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string TemplateName
    {
      get => Conversions.ToString(this[this.tabletblDocumentTemplates.TemplateNameColumn]);
      set => this[this.tabletblDocumentTemplates.TemplateNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tabletblDocumentTemplates.DescriptionColumn]);
      set => this[this.tabletblDocumentTemplates.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int TemplateID
    {
      get => Conversions.ToInteger(this[this.tabletblDocumentTemplates.TemplateIDColumn]);
      set => this[this.tabletblDocumentTemplates.TemplateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int FolderID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblDocumentTemplates.FolderIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FolderID' in table 'tblDocumentTemplates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplates.FolderIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int TemplateGroupID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblDocumentTemplates.TemplateGroupIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TemplateGroupID' in table 'tblDocumentTemplates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplates.TemplateGroupIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPolicyForm
    {
      get => Conversions.ToBoolean(this[this.tabletblDocumentTemplates.IsPolicyFormColumn]);
      set => this[this.tabletblDocumentTemplates.IsPolicyFormColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEditable
    {
      get => Conversions.ToBoolean(this[this.tabletblDocumentTemplates.IsEditableColumn]);
      set => this[this.tabletblDocumentTemplates.IsEditableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string SaveAsType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDocumentTemplates.SaveAsTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SaveAsType' in table 'tblDocumentTemplates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplates.SaveAsTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool FileOnly
    {
      get => Conversions.ToBoolean(this[this.tabletblDocumentTemplates.FileOnlyColumn]);
      set => this[this.tabletblDocumentTemplates.FileOnlyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool SeparateDoc
    {
      get => Conversions.ToBoolean(this[this.tabletblDocumentTemplates.SeparateDocColumn]);
      set => this[this.tabletblDocumentTemplates.SeparateDocColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Removable
    {
      get => Conversions.ToBoolean(this[this.tabletblDocumentTemplates.RemovableColumn]);
      set => this[this.tabletblDocumentTemplates.RemovableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool HideWaterMark
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblDocumentTemplates.HideWaterMarkColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'HideWaterMark' in table 'tblDocumentTemplates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplates.HideWaterMarkColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEmail
    {
      get => Conversions.ToBoolean(this[this.tabletblDocumentTemplates.IsEmailColumn]);
      set => this[this.tabletblDocumentTemplates.IsEmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string FileOnlyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDocumentTemplates.FileOnlyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FileOnlyName' in table 'tblDocumentTemplates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplates.FileOnlyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string SeparateDocName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDocumentTemplates.SeparateDocNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SeparateDocName' in table 'tblDocumentTemplates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplates.SeparateDocNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool RequiresEdit
    {
      get => Conversions.ToBoolean(this[this.tabletblDocumentTemplates.RequiresEditColumn]);
      set => this[this.tabletblDocumentTemplates.RequiresEditColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool CopyForwardOnRenewal
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblDocumentTemplates.CopyForwardOnRenewalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CopyForwardOnRenewal' in table 'tblDocumentTemplates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplates.CopyForwardOnRenewalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Hidden
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblDocumentTemplates.HiddenColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Hidden' in table 'tblDocumentTemplates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplates.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool OnDemand
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblDocumentTemplates.OnDemandColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OnDemand' in table 'tblDocumentTemplates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplates.OnDemandColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string OriginalFileName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDocumentTemplates.OriginalFileNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OriginalFileName' in table 'tblDocumentTemplates' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplates.OriginalFileNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.lstTemplateDocumentGroupsRow lstTemplateDocumentGroupsRow
    {
      get
      {
        return (dsDocumentTemplates.lstTemplateDocumentGroupsRow) this.GetParentRow(this.Table.ParentRelations["lstTemplateDocumentGroupstblDocumentTemplates"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstTemplateDocumentGroupstblDocumentTemplates"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFolderIDNull() => this.IsNull(this.tabletblDocumentTemplates.FolderIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFolderIDNull()
    {
      this[this.tabletblDocumentTemplates.FolderIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsTemplateGroupIDNull()
    {
      return this.IsNull(this.tabletblDocumentTemplates.TemplateGroupIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetTemplateGroupIDNull()
    {
      this[this.tabletblDocumentTemplates.TemplateGroupIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsSaveAsTypeNull() => this.IsNull(this.tabletblDocumentTemplates.SaveAsTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetSaveAsTypeNull()
    {
      this[this.tabletblDocumentTemplates.SaveAsTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsHideWaterMarkNull()
    {
      return this.IsNull(this.tabletblDocumentTemplates.HideWaterMarkColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetHideWaterMarkNull()
    {
      this[this.tabletblDocumentTemplates.HideWaterMarkColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFileOnlyNameNull()
    {
      return this.IsNull(this.tabletblDocumentTemplates.FileOnlyNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFileOnlyNameNull()
    {
      this[this.tabletblDocumentTemplates.FileOnlyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsSeparateDocNameNull()
    {
      return this.IsNull(this.tabletblDocumentTemplates.SeparateDocNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetSeparateDocNameNull()
    {
      this[this.tabletblDocumentTemplates.SeparateDocNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCopyForwardOnRenewalNull()
    {
      return this.IsNull(this.tabletblDocumentTemplates.CopyForwardOnRenewalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCopyForwardOnRenewalNull()
    {
      this[this.tabletblDocumentTemplates.CopyForwardOnRenewalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsHiddenNull() => this.IsNull(this.tabletblDocumentTemplates.HiddenColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetHiddenNull()
    {
      this[this.tabletblDocumentTemplates.HiddenColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsOnDemandNull() => this.IsNull(this.tabletblDocumentTemplates.OnDemandColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetOnDemandNull()
    {
      this[this.tabletblDocumentTemplates.OnDemandColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsOriginalFileNameNull()
    {
      return this.IsNull(this.tabletblDocumentTemplates.OriginalFileNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetOriginalFileNameNull()
    {
      this[this.tabletblDocumentTemplates.OriginalFileNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstDocumentAutomationGroupsRow : DataRow
  {
    private dsDocumentTemplates.lstDocumentAutomationGroupsDataTable tablelstDocumentAutomationGroups;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal lstDocumentAutomationGroupsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstDocumentAutomationGroups = (dsDocumentTemplates.lstDocumentAutomationGroupsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstDocumentAutomationGroups.IDColumn]);
      set => this[this.tablelstDocumentAutomationGroups.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string TemplateGroup
    {
      get => Conversions.ToString(this[this.tablelstDocumentAutomationGroups.TemplateGroupColumn]);
      set => this[this.tablelstDocumentAutomationGroups.TemplateGroupColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.tblDocumentTemplatesListRow[] GettblDocumentTemplatesListRows()
    {
      return this.Table.ChildRelations["lstDocumentAutomationGroupstblDocumentTemplatesList"] != null ? (dsDocumentTemplates.tblDocumentTemplatesListRow[]) this.GetChildRows(this.Table.ChildRelations["lstDocumentAutomationGroupstblDocumentTemplatesList"]) : new dsDocumentTemplates.tblDocumentTemplatesListRow[0];
    }
  }

  public class tblDocumentTemplatesListRow : DataRow
  {
    private dsDocumentTemplates.tblDocumentTemplatesListDataTable tabletblDocumentTemplatesList;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblDocumentTemplatesListRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDocumentTemplatesList = (dsDocumentTemplates.tblDocumentTemplatesListDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int TemplateID
    {
      get => Conversions.ToInteger(this[this.tabletblDocumentTemplatesList.TemplateIDColumn]);
      set => this[this.tabletblDocumentTemplatesList.TemplateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int AutomationGroupID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblDocumentTemplatesList.AutomationGroupIDColumn]);
      }
      set => this[this.tabletblDocumentTemplatesList.AutomationGroupIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string TemplateName
    {
      get => Conversions.ToString(this[this.tabletblDocumentTemplatesList.TemplateNameColumn]);
      set => this[this.tabletblDocumentTemplatesList.TemplateNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tabletblDocumentTemplatesList.DescriptionColumn]);
      set => this[this.tabletblDocumentTemplatesList.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int TemplateGroupID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblDocumentTemplatesList.TemplateGroupIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TemplateGroupID' in table 'tblDocumentTemplatesList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplatesList.TemplateGroupIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string TemplateType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDocumentTemplatesList.TemplateTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TemplateType' in table 'tblDocumentTemplatesList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentTemplatesList.TemplateTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.lstDocumentAutomationGroupsRow lstDocumentAutomationGroupsRow
    {
      get
      {
        return (dsDocumentTemplates.lstDocumentAutomationGroupsRow) this.GetParentRow(this.Table.ParentRelations["lstDocumentAutomationGroupstblDocumentTemplatesList"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstDocumentAutomationGroupstblDocumentTemplatesList"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsTemplateGroupIDNull()
    {
      return this.IsNull(this.tabletblDocumentTemplatesList.TemplateGroupIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetTemplateGroupIDNull()
    {
      this[this.tabletblDocumentTemplatesList.TemplateGroupIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsTemplateTypeNull()
    {
      return this.IsNull(this.tabletblDocumentTemplatesList.TemplateTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetTemplateTypeNull()
    {
      this[this.tabletblDocumentTemplatesList.TemplateTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstTemplateDocumentGroupsRow : DataRow
  {
    private dsDocumentTemplates.lstTemplateDocumentGroupsDataTable tablelstTemplateDocumentGroups;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal lstTemplateDocumentGroupsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstTemplateDocumentGroups = (dsDocumentTemplates.lstTemplateDocumentGroupsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int GroupID
    {
      get => Conversions.ToInteger(this[this.tablelstTemplateDocumentGroups.GroupIDColumn]);
      set => this[this.tablelstTemplateDocumentGroups.GroupIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string TemplateGroup
    {
      get => Conversions.ToString(this[this.tablelstTemplateDocumentGroups.TemplateGroupColumn]);
      set => this[this.tablelstTemplateDocumentGroups.TemplateGroupColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int AutomationGroupID
    {
      get
      {
        return Conversions.ToInteger(this[this.tablelstTemplateDocumentGroups.AutomationGroupIDColumn]);
      }
      set => this[this.tablelstTemplateDocumentGroups.AutomationGroupIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ParentTemplateGroupID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablelstTemplateDocumentGroups.ParentTemplateGroupIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ParentTemplateGroupID' in table 'lstTemplateDocumentGroups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstTemplateDocumentGroups.ParentTemplateGroupIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsParentTemplateGroupIDNull()
    {
      return this.IsNull(this.tablelstTemplateDocumentGroups.ParentTemplateGroupIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetParentTemplateGroupIDNull()
    {
      this[this.tablelstTemplateDocumentGroups.ParentTemplateGroupIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.tblDocumentTemplatesRow[] GettblDocumentTemplatesRows()
    {
      return this.Table.ChildRelations["lstTemplateDocumentGroupstblDocumentTemplates"] != null ? (dsDocumentTemplates.tblDocumentTemplatesRow[]) this.GetChildRows(this.Table.ChildRelations["lstTemplateDocumentGroupstblDocumentTemplates"]) : new dsDocumentTemplates.tblDocumentTemplatesRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblDocumentTemplatesRowChangeEvent : EventArgs
  {
    private dsDocumentTemplates.tblDocumentTemplatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblDocumentTemplatesRowChangeEvent(
      dsDocumentTemplates.tblDocumentTemplatesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.tblDocumentTemplatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class lstDocumentAutomationGroupsRowChangeEvent : EventArgs
  {
    private dsDocumentTemplates.lstDocumentAutomationGroupsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public lstDocumentAutomationGroupsRowChangeEvent(
      dsDocumentTemplates.lstDocumentAutomationGroupsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.lstDocumentAutomationGroupsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblDocumentTemplatesListRowChangeEvent : EventArgs
  {
    private dsDocumentTemplates.tblDocumentTemplatesListRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblDocumentTemplatesListRowChangeEvent(
      dsDocumentTemplates.tblDocumentTemplatesListRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.tblDocumentTemplatesListRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class lstTemplateDocumentGroupsRowChangeEvent : EventArgs
  {
    private dsDocumentTemplates.lstTemplateDocumentGroupsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public lstTemplateDocumentGroupsRowChangeEvent(
      dsDocumentTemplates.lstTemplateDocumentGroupsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsDocumentTemplates.lstTemplateDocumentGroupsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
