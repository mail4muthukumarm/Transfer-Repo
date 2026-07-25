// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsStateSLRules
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
namespace MGASystems.IMS.Policies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsStateSLRules")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsStateSLRules : DataSet
{
  private dsStateSLRules.lstStatesDataTable tablelstStates;
  private dsStateSLRules.lstStateSLRequiredDataDataTable tablelstStateSLRequiredData;
  private dsStateSLRules.tblSLStateRulesFormsDataTable tabletblSLStateRulesForms;
  private dsStateSLRules.tblStateSLRulesDataTable tabletblStateSLRules;
  private dsStateSLRules.tblDocumentTemplatesDataTable tabletblDocumentTemplates;
  private dsStateSLRules.tblStatesSLRequiredDataDataTable tabletblStatesSLRequiredData;
  private dsStateSLRules.tblDocumentFoldersDataTable tabletblDocumentFolders;
  private DataRelation relationtblDocumentTemplates_tblSLStateRulesForms;
  private DataRelation relationlstStates_tblSLStateRulesForms;
  private DataRelation relationlstStates_tblStateSLRules;
  private DataRelation relationlstStateSLRequiredData_tblStatesSLRequiredData1;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsStateSLRules()
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
  protected dsStateSLRules(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstStates)] != null)
          base.Tables.Add((DataTable) new dsStateSLRules.lstStatesDataTable(dataSet.Tables[nameof (lstStates)]));
        if (dataSet.Tables[nameof (lstStateSLRequiredData)] != null)
          base.Tables.Add((DataTable) new dsStateSLRules.lstStateSLRequiredDataDataTable(dataSet.Tables[nameof (lstStateSLRequiredData)]));
        if (dataSet.Tables[nameof (tblSLStateRulesForms)] != null)
          base.Tables.Add((DataTable) new dsStateSLRules.tblSLStateRulesFormsDataTable(dataSet.Tables[nameof (tblSLStateRulesForms)]));
        if (dataSet.Tables[nameof (tblStateSLRules)] != null)
          base.Tables.Add((DataTable) new dsStateSLRules.tblStateSLRulesDataTable(dataSet.Tables[nameof (tblStateSLRules)]));
        if (dataSet.Tables[nameof (tblDocumentTemplates)] != null)
          base.Tables.Add((DataTable) new dsStateSLRules.tblDocumentTemplatesDataTable(dataSet.Tables[nameof (tblDocumentTemplates)]));
        if (dataSet.Tables[nameof (tblStatesSLRequiredData)] != null)
          base.Tables.Add((DataTable) new dsStateSLRules.tblStatesSLRequiredDataDataTable(dataSet.Tables[nameof (tblStatesSLRequiredData)]));
        if (dataSet.Tables[nameof (tblDocumentFolders)] != null)
          base.Tables.Add((DataTable) new dsStateSLRules.tblDocumentFoldersDataTable(dataSet.Tables[nameof (tblDocumentFolders)]));
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
  public dsStateSLRules.lstStatesDataTable lstStates => this.tablelstStates;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsStateSLRules.lstStateSLRequiredDataDataTable lstStateSLRequiredData
  {
    get => this.tablelstStateSLRequiredData;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsStateSLRules.tblSLStateRulesFormsDataTable tblSLStateRulesForms
  {
    get => this.tabletblSLStateRulesForms;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsStateSLRules.tblStateSLRulesDataTable tblStateSLRules => this.tabletblStateSLRules;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsStateSLRules.tblDocumentTemplatesDataTable tblDocumentTemplates
  {
    get => this.tabletblDocumentTemplates;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsStateSLRules.tblStatesSLRequiredDataDataTable tblStatesSLRequiredData
  {
    get => this.tabletblStatesSLRequiredData;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsStateSLRules.tblDocumentFoldersDataTable tblDocumentFolders
  {
    get => this.tabletblDocumentFolders;
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
    dsStateSLRules dsStateSlRules = (dsStateSLRules) base.Clone();
    dsStateSlRules.InitVars();
    dsStateSlRules.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsStateSlRules;
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
      if (dataSet.Tables["lstStates"] != null)
        base.Tables.Add((DataTable) new dsStateSLRules.lstStatesDataTable(dataSet.Tables["lstStates"]));
      if (dataSet.Tables["lstStateSLRequiredData"] != null)
        base.Tables.Add((DataTable) new dsStateSLRules.lstStateSLRequiredDataDataTable(dataSet.Tables["lstStateSLRequiredData"]));
      if (dataSet.Tables["tblSLStateRulesForms"] != null)
        base.Tables.Add((DataTable) new dsStateSLRules.tblSLStateRulesFormsDataTable(dataSet.Tables["tblSLStateRulesForms"]));
      if (dataSet.Tables["tblStateSLRules"] != null)
        base.Tables.Add((DataTable) new dsStateSLRules.tblStateSLRulesDataTable(dataSet.Tables["tblStateSLRules"]));
      if (dataSet.Tables["tblDocumentTemplates"] != null)
        base.Tables.Add((DataTable) new dsStateSLRules.tblDocumentTemplatesDataTable(dataSet.Tables["tblDocumentTemplates"]));
      if (dataSet.Tables["tblStatesSLRequiredData"] != null)
        base.Tables.Add((DataTable) new dsStateSLRules.tblStatesSLRequiredDataDataTable(dataSet.Tables["tblStatesSLRequiredData"]));
      if (dataSet.Tables["tblDocumentFolders"] != null)
        base.Tables.Add((DataTable) new dsStateSLRules.tblDocumentFoldersDataTable(dataSet.Tables["tblDocumentFolders"]));
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
    this.tablelstStates = (dsStateSLRules.lstStatesDataTable) base.Tables["lstStates"];
    if (initTable && this.tablelstStates != null)
      this.tablelstStates.InitVars();
    this.tablelstStateSLRequiredData = (dsStateSLRules.lstStateSLRequiredDataDataTable) base.Tables["lstStateSLRequiredData"];
    if (initTable && this.tablelstStateSLRequiredData != null)
      this.tablelstStateSLRequiredData.InitVars();
    this.tabletblSLStateRulesForms = (dsStateSLRules.tblSLStateRulesFormsDataTable) base.Tables["tblSLStateRulesForms"];
    if (initTable && this.tabletblSLStateRulesForms != null)
      this.tabletblSLStateRulesForms.InitVars();
    this.tabletblStateSLRules = (dsStateSLRules.tblStateSLRulesDataTable) base.Tables["tblStateSLRules"];
    if (initTable && this.tabletblStateSLRules != null)
      this.tabletblStateSLRules.InitVars();
    this.tabletblDocumentTemplates = (dsStateSLRules.tblDocumentTemplatesDataTable) base.Tables["tblDocumentTemplates"];
    if (initTable && this.tabletblDocumentTemplates != null)
      this.tabletblDocumentTemplates.InitVars();
    this.tabletblStatesSLRequiredData = (dsStateSLRules.tblStatesSLRequiredDataDataTable) base.Tables["tblStatesSLRequiredData"];
    if (initTable && this.tabletblStatesSLRequiredData != null)
      this.tabletblStatesSLRequiredData.InitVars();
    this.tabletblDocumentFolders = (dsStateSLRules.tblDocumentFoldersDataTable) base.Tables["tblDocumentFolders"];
    if (initTable && this.tabletblDocumentFolders != null)
      this.tabletblDocumentFolders.InitVars();
    this.relationtblDocumentTemplates_tblSLStateRulesForms = this.Relations["tblDocumentTemplates_tblSLStateRulesForms"];
    this.relationlstStates_tblSLStateRulesForms = this.Relations["lstStates_tblSLStateRulesForms"];
    this.relationlstStates_tblStateSLRules = this.Relations["lstStates_tblStateSLRules"];
    this.relationlstStateSLRequiredData_tblStatesSLRequiredData1 = this.Relations["lstStateSLRequiredData_tblStatesSLRequiredData1"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsStateSLRules);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsStateSLRules.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstStates = new dsStateSLRules.lstStatesDataTable();
    base.Tables.Add((DataTable) this.tablelstStates);
    this.tablelstStateSLRequiredData = new dsStateSLRules.lstStateSLRequiredDataDataTable();
    base.Tables.Add((DataTable) this.tablelstStateSLRequiredData);
    this.tabletblSLStateRulesForms = new dsStateSLRules.tblSLStateRulesFormsDataTable();
    base.Tables.Add((DataTable) this.tabletblSLStateRulesForms);
    this.tabletblStateSLRules = new dsStateSLRules.tblStateSLRulesDataTable();
    base.Tables.Add((DataTable) this.tabletblStateSLRules);
    this.tabletblDocumentTemplates = new dsStateSLRules.tblDocumentTemplatesDataTable();
    base.Tables.Add((DataTable) this.tabletblDocumentTemplates);
    this.tabletblStatesSLRequiredData = new dsStateSLRules.tblStatesSLRequiredDataDataTable();
    base.Tables.Add((DataTable) this.tabletblStatesSLRequiredData);
    this.tabletblDocumentFolders = new dsStateSLRules.tblDocumentFoldersDataTable();
    base.Tables.Add((DataTable) this.tabletblDocumentFolders);
    this.relationtblDocumentTemplates_tblSLStateRulesForms = new DataRelation("tblDocumentTemplates_tblSLStateRulesForms", new DataColumn[1]
    {
      this.tabletblDocumentTemplates.TemplateIDColumn
    }, new DataColumn[1]
    {
      this.tabletblSLStateRulesForms.TemplateIDColumn
    }, false);
    this.Relations.Add(this.relationtblDocumentTemplates_tblSLStateRulesForms);
    this.relationlstStates_tblSLStateRulesForms = new DataRelation("lstStates_tblSLStateRulesForms", new DataColumn[1]
    {
      this.tablelstStates.StateIDColumn
    }, new DataColumn[1]
    {
      this.tabletblSLStateRulesForms.StateIDColumn
    }, false);
    this.Relations.Add(this.relationlstStates_tblSLStateRulesForms);
    this.relationlstStates_tblStateSLRules = new DataRelation("lstStates_tblStateSLRules", new DataColumn[1]
    {
      this.tablelstStates.StateIDColumn
    }, new DataColumn[1]
    {
      this.tabletblStateSLRules.StateIDColumn
    }, false);
    this.Relations.Add(this.relationlstStates_tblStateSLRules);
    this.relationlstStateSLRequiredData_tblStatesSLRequiredData1 = new DataRelation("lstStateSLRequiredData_tblStatesSLRequiredData1", new DataColumn[1]
    {
      this.tablelstStateSLRequiredData.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblStatesSLRequiredData.RequiredDataIDColumn
    }, false);
    this.Relations.Add(this.relationlstStateSLRequiredData_tblStatesSLRequiredData1);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstStates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstStateSLRequiredData() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblSLStateRulesForms() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblStateSLRules() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblDocumentTemplates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblStatesSLRequiredData() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblDocumentFolders() => false;

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
    dsStateSLRules dsStateSlRules = new dsStateSLRules();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsStateSlRules.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsStateSlRules.GetSchemaSerializable();
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
  public delegate void lstStatesRowChangeEventHandler(
    object sender,
    dsStateSLRules.lstStatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstStateSLRequiredDataRowChangeEventHandler(
    object sender,
    dsStateSLRules.lstStateSLRequiredDataRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblSLStateRulesFormsRowChangeEventHandler(
    object sender,
    dsStateSLRules.tblSLStateRulesFormsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblStateSLRulesRowChangeEventHandler(
    object sender,
    dsStateSLRules.tblStateSLRulesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblDocumentTemplatesRowChangeEventHandler(
    object sender,
    dsStateSLRules.tblDocumentTemplatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblStatesSLRequiredDataRowChangeEventHandler(
    object sender,
    dsStateSLRules.tblStatesSLRequiredDataRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblDocumentFoldersRowChangeEventHandler(
    object sender,
    dsStateSLRules.tblDocumentFoldersRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstStatesDataTable : TypedTableBase<dsStateSLRules.lstStatesRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstStatesDataTable()
    {
      this.TableName = "lstStates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstStatesDataTable(DataTable table)
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
    protected lstStatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.lstStatesRow this[int index]
    {
      get => (dsStateSLRules.lstStatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.lstStatesRowChangeEventHandler lstStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.lstStatesRowChangeEventHandler lstStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.lstStatesRowChangeEventHandler lstStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.lstStatesRowChangeEventHandler lstStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstStatesRow(dsStateSLRules.lstStatesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.lstStatesRow AddlstStatesRow(string StateID, string State)
    {
      dsStateSLRules.lstStatesRow row = (dsStateSLRules.lstStatesRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.lstStatesRow FindByStateID(string StateID)
    {
      return (dsStateSLRules.lstStatesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsStateSLRules.lstStatesDataTable lstStatesDataTable = (dsStateSLRules.lstStatesDataTable) base.Clone();
      lstStatesDataTable.InitVars();
      return (DataTable) lstStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsStateSLRules.lstStatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnState = this.Columns["State"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.lstStatesRow NewlstStatesRow()
    {
      return (dsStateSLRules.lstStatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsStateSLRules.lstStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsStateSLRules.lstStatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.lstStatesRowChangeEventHandler statesRowChangedEvent = this.lstStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsStateSLRules.lstStatesRowChangeEvent((dsStateSLRules.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.lstStatesRowChangeEventHandler rowChangingEvent = this.lstStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsStateSLRules.lstStatesRowChangeEvent((dsStateSLRules.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.lstStatesRowChangeEventHandler statesRowDeletedEvent = this.lstStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsStateSLRules.lstStatesRowChangeEvent((dsStateSLRules.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.lstStatesRowChangeEventHandler rowDeletingEvent = this.lstStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsStateSLRules.lstStatesRowChangeEvent((dsStateSLRules.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstStatesRow(dsStateSLRules.lstStatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsStateSLRules dsStateSlRules = new dsStateSLRules();
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
        FixedValue = dsStateSlRules.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsStateSlRules.GetSchemaSerializable();
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
  public class lstStateSLRequiredDataDataTable : 
    TypedTableBase<dsStateSLRules.lstStateSLRequiredDataRow>
  {
    private DataColumn columnID;
    private DataColumn columnRequiredData;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstStateSLRequiredDataDataTable()
    {
      this.TableName = "lstStateSLRequiredData";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstStateSLRequiredDataDataTable(DataTable table)
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
    protected lstStateSLRequiredDataDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RequiredDataColumn => this.columnRequiredData;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.lstStateSLRequiredDataRow this[int index]
    {
      get => (dsStateSLRules.lstStateSLRequiredDataRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.lstStateSLRequiredDataRowChangeEventHandler lstStateSLRequiredDataRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.lstStateSLRequiredDataRowChangeEventHandler lstStateSLRequiredDataRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.lstStateSLRequiredDataRowChangeEventHandler lstStateSLRequiredDataRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.lstStateSLRequiredDataRowChangeEventHandler lstStateSLRequiredDataRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstStateSLRequiredDataRow(dsStateSLRules.lstStateSLRequiredDataRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.lstStateSLRequiredDataRow AddlstStateSLRequiredDataRow(string RequiredData)
    {
      dsStateSLRules.lstStateSLRequiredDataRow row = (dsStateSLRules.lstStateSLRequiredDataRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) RequiredData
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.lstStateSLRequiredDataRow FindByID(int ID)
    {
      return (dsStateSLRules.lstStateSLRequiredDataRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsStateSLRules.lstStateSLRequiredDataDataTable requiredDataDataTable = (dsStateSLRules.lstStateSLRequiredDataDataTable) base.Clone();
      requiredDataDataTable.InitVars();
      return (DataTable) requiredDataDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsStateSLRules.lstStateSLRequiredDataDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnRequiredData = this.Columns["RequiredData"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnRequiredData = new DataColumn("RequiredData", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiredData);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnRequiredData.AllowDBNull = false;
      this.columnRequiredData.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.lstStateSLRequiredDataRow NewlstStateSLRequiredDataRow()
    {
      return (dsStateSLRules.lstStateSLRequiredDataRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsStateSLRules.lstStateSLRequiredDataRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsStateSLRules.lstStateSLRequiredDataRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStateSLRequiredDataRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.lstStateSLRequiredDataRowChangeEventHandler dataRowChangedEvent = this.lstStateSLRequiredDataRowChangedEvent;
      if (dataRowChangedEvent == null)
        return;
      dataRowChangedEvent((object) this, new dsStateSLRules.lstStateSLRequiredDataRowChangeEvent((dsStateSLRules.lstStateSLRequiredDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStateSLRequiredDataRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.lstStateSLRequiredDataRowChangeEventHandler rowChangingEvent = this.lstStateSLRequiredDataRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsStateSLRules.lstStateSLRequiredDataRowChangeEvent((dsStateSLRules.lstStateSLRequiredDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStateSLRequiredDataRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.lstStateSLRequiredDataRowChangeEventHandler dataRowDeletedEvent = this.lstStateSLRequiredDataRowDeletedEvent;
      if (dataRowDeletedEvent == null)
        return;
      dataRowDeletedEvent((object) this, new dsStateSLRules.lstStateSLRequiredDataRowChangeEvent((dsStateSLRules.lstStateSLRequiredDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStateSLRequiredDataRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.lstStateSLRequiredDataRowChangeEventHandler rowDeletingEvent = this.lstStateSLRequiredDataRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsStateSLRules.lstStateSLRequiredDataRowChangeEvent((dsStateSLRules.lstStateSLRequiredDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstStateSLRequiredDataRow(dsStateSLRules.lstStateSLRequiredDataRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsStateSLRules dsStateSlRules = new dsStateSLRules();
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
        FixedValue = dsStateSlRules.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStateSLRequiredDataDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsStateSlRules.GetSchemaSerializable();
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
  public class tblSLStateRulesFormsDataTable : TypedTableBase<dsStateSLRules.tblSLStateRulesFormsRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnTemplateID;
    private DataColumn columnUseOnBinder;
    private DataColumn columnUserOnQuote;
    private DataColumn columnInsuredSigns;
    private DataColumn columnProducerSigns;
    private DataColumn columnUseOnIssuance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblSLStateRulesFormsDataTable()
    {
      this.TableName = "tblSLStateRulesForms";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblSLStateRulesFormsDataTable(DataTable table)
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
    protected tblSLStateRulesFormsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TemplateIDColumn => this.columnTemplateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UseOnBinderColumn => this.columnUseOnBinder;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserOnQuoteColumn => this.columnUserOnQuote;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InsuredSignsColumn => this.columnInsuredSigns;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerSignsColumn => this.columnProducerSigns;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UseOnIssuanceColumn => this.columnUseOnIssuance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblSLStateRulesFormsRow this[int index]
    {
      get => (dsStateSLRules.tblSLStateRulesFormsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblSLStateRulesFormsRowChangeEventHandler tblSLStateRulesFormsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblSLStateRulesFormsRowChangeEventHandler tblSLStateRulesFormsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblSLStateRulesFormsRowChangeEventHandler tblSLStateRulesFormsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblSLStateRulesFormsRowChangeEventHandler tblSLStateRulesFormsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblSLStateRulesFormsRow(dsStateSLRules.tblSLStateRulesFormsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblSLStateRulesFormsRow AddtblSLStateRulesFormsRow(
      dsStateSLRules.lstStatesRow parentlstStatesRowBylstStates_tblSLStateRulesForms,
      dsStateSLRules.tblDocumentTemplatesRow parenttblDocumentTemplatesRowBytblDocumentTemplates_tblSLStateRulesForms,
      bool UseOnBinder,
      bool UserOnQuote,
      bool InsuredSigns,
      bool ProducerSigns,
      bool UseOnIssuance)
    {
      dsStateSLRules.tblSLStateRulesFormsRow row = (dsStateSLRules.tblSLStateRulesFormsRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        null,
        (object) UseOnBinder,
        (object) UserOnQuote,
        (object) InsuredSigns,
        (object) ProducerSigns,
        (object) UseOnIssuance
      };
      if (parentlstStatesRowBylstStates_tblSLStateRulesForms != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parentlstStatesRowBylstStates_tblSLStateRulesForms[0]);
      if (parenttblDocumentTemplatesRowBytblDocumentTemplates_tblSLStateRulesForms != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblDocumentTemplatesRowBytblDocumentTemplates_tblSLStateRulesForms[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblSLStateRulesFormsRow FindByStateIDTemplateID(
      string StateID,
      int TemplateID)
    {
      return (dsStateSLRules.tblSLStateRulesFormsRow) this.Rows.Find(new object[2]
      {
        (object) StateID,
        (object) TemplateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsStateSLRules.tblSLStateRulesFormsDataTable rulesFormsDataTable = (dsStateSLRules.tblSLStateRulesFormsDataTable) base.Clone();
      rulesFormsDataTable.InitVars();
      return (DataTable) rulesFormsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsStateSLRules.tblSLStateRulesFormsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnTemplateID = this.Columns["TemplateID"];
      this.columnUseOnBinder = this.Columns["UseOnBinder"];
      this.columnUserOnQuote = this.Columns["UserOnQuote"];
      this.columnInsuredSigns = this.Columns["InsuredSigns"];
      this.columnProducerSigns = this.Columns["ProducerSigns"];
      this.columnUseOnIssuance = this.Columns["UseOnIssuance"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnTemplateID = new DataColumn("TemplateID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateID);
      this.columnUseOnBinder = new DataColumn("UseOnBinder", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUseOnBinder);
      this.columnUserOnQuote = new DataColumn("UserOnQuote", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserOnQuote);
      this.columnInsuredSigns = new DataColumn("InsuredSigns", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredSigns);
      this.columnProducerSigns = new DataColumn("ProducerSigns", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerSigns);
      this.columnUseOnIssuance = new DataColumn("UseOnIssuance", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUseOnIssuance);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnStateID,
        this.columnTemplateID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.MaxLength = 2;
      this.columnTemplateID.AllowDBNull = false;
      this.columnUseOnBinder.AllowDBNull = false;
      this.columnUseOnBinder.DefaultValue = (object) false;
      this.columnUserOnQuote.AllowDBNull = false;
      this.columnUserOnQuote.DefaultValue = (object) false;
      this.columnInsuredSigns.AllowDBNull = false;
      this.columnInsuredSigns.DefaultValue = (object) false;
      this.columnProducerSigns.AllowDBNull = false;
      this.columnProducerSigns.DefaultValue = (object) false;
      this.columnUseOnIssuance.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblSLStateRulesFormsRow NewtblSLStateRulesFormsRow()
    {
      return (dsStateSLRules.tblSLStateRulesFormsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsStateSLRules.tblSLStateRulesFormsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsStateSLRules.tblSLStateRulesFormsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblSLStateRulesFormsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblSLStateRulesFormsRowChangeEventHandler formsRowChangedEvent = this.tblSLStateRulesFormsRowChangedEvent;
      if (formsRowChangedEvent == null)
        return;
      formsRowChangedEvent((object) this, new dsStateSLRules.tblSLStateRulesFormsRowChangeEvent((dsStateSLRules.tblSLStateRulesFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblSLStateRulesFormsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblSLStateRulesFormsRowChangeEventHandler rowChangingEvent = this.tblSLStateRulesFormsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsStateSLRules.tblSLStateRulesFormsRowChangeEvent((dsStateSLRules.tblSLStateRulesFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblSLStateRulesFormsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblSLStateRulesFormsRowChangeEventHandler formsRowDeletedEvent = this.tblSLStateRulesFormsRowDeletedEvent;
      if (formsRowDeletedEvent == null)
        return;
      formsRowDeletedEvent((object) this, new dsStateSLRules.tblSLStateRulesFormsRowChangeEvent((dsStateSLRules.tblSLStateRulesFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblSLStateRulesFormsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblSLStateRulesFormsRowChangeEventHandler rowDeletingEvent = this.tblSLStateRulesFormsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsStateSLRules.tblSLStateRulesFormsRowChangeEvent((dsStateSLRules.tblSLStateRulesFormsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblSLStateRulesFormsRow(dsStateSLRules.tblSLStateRulesFormsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsStateSLRules dsStateSlRules = new dsStateSLRules();
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
        FixedValue = dsStateSlRules.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblSLStateRulesFormsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsStateSlRules.GetSchemaSerializable();
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
  public class tblStateSLRulesDataTable : TypedTableBase<dsStateSLRules.tblStateSLRulesRow>
  {
    private DataColumn columnID;
    private DataColumn columnStateID;
    private DataColumn columnOtherInfo;
    private DataColumn columnNoAllowPremiumAllocation;
    private DataColumn columnFilingRequiredForZeroPremium;
    private DataColumn columnUseCorporateLic;
    private DataColumn columnDescription;
    private DataColumn columnMail;
    private DataColumn columnOnline;
    private DataColumn columnRetain;
    private DataColumn columnComments;
    private DataColumn columnFolderID;
    private DataColumn columnSLImageData;
    private DataColumn columnStatePubWhiteList;
    private DataColumn columnStatePubExportList;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblStateSLRulesDataTable()
    {
      this.TableName = "tblStateSLRules";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblStateSLRulesDataTable(DataTable table)
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
    protected tblStateSLRulesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OtherInfoColumn => this.columnOtherInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NoAllowPremiumAllocationColumn => this.columnNoAllowPremiumAllocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FilingRequiredForZeroPremiumColumn => this.columnFilingRequiredForZeroPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UseCorporateLicColumn => this.columnUseCorporateLic;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MailColumn => this.columnMail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OnlineColumn => this.columnOnline;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RetainColumn => this.columnRetain;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CommentsColumn => this.columnComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FolderIDColumn => this.columnFolderID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SLImageDataColumn => this.columnSLImageData;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StatePubWhiteListColumn => this.columnStatePubWhiteList;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StatePubExportListColumn => this.columnStatePubExportList;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblStateSLRulesRow this[int index]
    {
      get => (dsStateSLRules.tblStateSLRulesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblStateSLRulesRowChangeEventHandler tblStateSLRulesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblStateSLRulesRowChangeEventHandler tblStateSLRulesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblStateSLRulesRowChangeEventHandler tblStateSLRulesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblStateSLRulesRowChangeEventHandler tblStateSLRulesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblStateSLRulesRow(dsStateSLRules.tblStateSLRulesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblStateSLRulesRow AddtblStateSLRulesRow(
      dsStateSLRules.lstStatesRow parentlstStatesRowBylstStates_tblStateSLRules,
      string OtherInfo,
      bool NoAllowPremiumAllocation,
      bool FilingRequiredForZeroPremium,
      bool UseCorporateLic,
      string Description,
      bool Mail,
      bool Online,
      bool Retain,
      string Comments,
      int FolderID,
      byte[] SLImageData,
      bool StatePubWhiteList,
      bool StatePubExportList)
    {
      dsStateSLRules.tblStateSLRulesRow row = (dsStateSLRules.tblStateSLRulesRow) this.NewRow();
      object[] objArray = new object[15]
      {
        null,
        null,
        (object) OtherInfo,
        (object) NoAllowPremiumAllocation,
        (object) FilingRequiredForZeroPremium,
        (object) UseCorporateLic,
        (object) Description,
        (object) Mail,
        (object) Online,
        (object) Retain,
        (object) Comments,
        (object) FolderID,
        (object) SLImageData,
        (object) StatePubWhiteList,
        (object) StatePubExportList
      };
      if (parentlstStatesRowBylstStates_tblStateSLRules != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstStatesRowBylstStates_tblStateSLRules[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblStateSLRulesRow FindByID(int ID)
    {
      return (dsStateSLRules.tblStateSLRulesRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsStateSLRules.tblStateSLRulesDataTable slRulesDataTable = (dsStateSLRules.tblStateSLRulesDataTable) base.Clone();
      slRulesDataTable.InitVars();
      return (DataTable) slRulesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsStateSLRules.tblStateSLRulesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnStateID = this.Columns["StateID"];
      this.columnOtherInfo = this.Columns["OtherInfo"];
      this.columnNoAllowPremiumAllocation = this.Columns["NoAllowPremiumAllocation"];
      this.columnFilingRequiredForZeroPremium = this.Columns["FilingRequiredForZeroPremium"];
      this.columnUseCorporateLic = this.Columns["UseCorporateLic"];
      this.columnDescription = this.Columns["Description"];
      this.columnMail = this.Columns["Mail"];
      this.columnOnline = this.Columns["Online"];
      this.columnRetain = this.Columns["Retain"];
      this.columnComments = this.Columns["Comments"];
      this.columnFolderID = this.Columns["FolderID"];
      this.columnSLImageData = this.Columns["SLImageData"];
      this.columnStatePubWhiteList = this.Columns["StatePubWhiteList"];
      this.columnStatePubExportList = this.Columns["StatePubExportList"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnOtherInfo = new DataColumn("OtherInfo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOtherInfo);
      this.columnNoAllowPremiumAllocation = new DataColumn("NoAllowPremiumAllocation", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoAllowPremiumAllocation);
      this.columnFilingRequiredForZeroPremium = new DataColumn("FilingRequiredForZeroPremium", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFilingRequiredForZeroPremium);
      this.columnUseCorporateLic = new DataColumn("UseCorporateLic", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUseCorporateLic);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnMail = new DataColumn("Mail", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMail);
      this.columnOnline = new DataColumn("Online", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOnline);
      this.columnRetain = new DataColumn("Retain", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRetain);
      this.columnComments = new DataColumn("Comments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComments);
      this.columnFolderID = new DataColumn("FolderID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFolderID);
      this.columnSLImageData = new DataColumn("SLImageData", typeof (byte[]), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSLImageData);
      this.columnStatePubWhiteList = new DataColumn("StatePubWhiteList", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatePubWhiteList);
      this.columnStatePubExportList = new DataColumn("StatePubExportList", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatePubExportList);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.MaxLength = 2;
      this.columnOtherInfo.MaxLength = 6000;
      this.columnDescription.MaxLength = 6000;
      this.columnComments.MaxLength = int.MaxValue;
      this.columnStatePubWhiteList.AllowDBNull = false;
      this.columnStatePubWhiteList.DefaultValue = (object) false;
      this.columnStatePubExportList.AllowDBNull = false;
      this.columnStatePubExportList.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblStateSLRulesRow NewtblStateSLRulesRow()
    {
      return (dsStateSLRules.tblStateSLRulesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsStateSLRules.tblStateSLRulesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsStateSLRules.tblStateSLRulesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStateSLRulesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblStateSLRulesRowChangeEventHandler rulesRowChangedEvent = this.tblStateSLRulesRowChangedEvent;
      if (rulesRowChangedEvent == null)
        return;
      rulesRowChangedEvent((object) this, new dsStateSLRules.tblStateSLRulesRowChangeEvent((dsStateSLRules.tblStateSLRulesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStateSLRulesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblStateSLRulesRowChangeEventHandler rowChangingEvent = this.tblStateSLRulesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsStateSLRules.tblStateSLRulesRowChangeEvent((dsStateSLRules.tblStateSLRulesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStateSLRulesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblStateSLRulesRowChangeEventHandler rulesRowDeletedEvent = this.tblStateSLRulesRowDeletedEvent;
      if (rulesRowDeletedEvent == null)
        return;
      rulesRowDeletedEvent((object) this, new dsStateSLRules.tblStateSLRulesRowChangeEvent((dsStateSLRules.tblStateSLRulesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStateSLRulesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblStateSLRulesRowChangeEventHandler rowDeletingEvent = this.tblStateSLRulesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsStateSLRules.tblStateSLRulesRowChangeEvent((dsStateSLRules.tblStateSLRulesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblStateSLRulesRow(dsStateSLRules.tblStateSLRulesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsStateSLRules dsStateSlRules = new dsStateSLRules();
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
        FixedValue = dsStateSlRules.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblStateSLRulesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsStateSlRules.GetSchemaSerializable();
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
  public class tblDocumentTemplatesDataTable : TypedTableBase<dsStateSLRules.tblDocumentTemplatesRow>
  {
    private DataColumn columnTemplateID;
    private DataColumn columnTemplateName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblDocumentTemplatesDataTable()
    {
      this.TableName = "tblDocumentTemplates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblDocumentTemplatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TemplateIDColumn => this.columnTemplateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TemplateNameColumn => this.columnTemplateName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblDocumentTemplatesRow this[int index]
    {
      get => (dsStateSLRules.tblDocumentTemplatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblDocumentTemplatesRowChangeEventHandler tblDocumentTemplatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblDocumentTemplatesRow(dsStateSLRules.tblDocumentTemplatesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblDocumentTemplatesRow AddtblDocumentTemplatesRow(string TemplateName)
    {
      dsStateSLRules.tblDocumentTemplatesRow row = (dsStateSLRules.tblDocumentTemplatesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) TemplateName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblDocumentTemplatesRow FindByTemplateID(int TemplateID)
    {
      return (dsStateSLRules.tblDocumentTemplatesRow) this.Rows.Find(new object[1]
      {
        (object) TemplateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsStateSLRules.tblDocumentTemplatesDataTable templatesDataTable = (dsStateSLRules.tblDocumentTemplatesDataTable) base.Clone();
      templatesDataTable.InitVars();
      return (DataTable) templatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsStateSLRules.tblDocumentTemplatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnTemplateID = this.Columns["TemplateID"];
      this.columnTemplateName = this.Columns["TemplateName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnTemplateID = new DataColumn("TemplateID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateID);
      this.columnTemplateName = new DataColumn("TemplateName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnTemplateID
      }, true));
      this.columnTemplateID.AutoIncrement = true;
      this.columnTemplateID.AllowDBNull = false;
      this.columnTemplateID.ReadOnly = true;
      this.columnTemplateID.Unique = true;
      this.columnTemplateName.AllowDBNull = false;
      this.columnTemplateName.MaxLength = 70;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblDocumentTemplatesRow NewtblDocumentTemplatesRow()
    {
      return (dsStateSLRules.tblDocumentTemplatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsStateSLRules.tblDocumentTemplatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsStateSLRules.tblDocumentTemplatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblDocumentTemplatesRowChangeEventHandler templatesRowChangedEvent = this.tblDocumentTemplatesRowChangedEvent;
      if (templatesRowChangedEvent == null)
        return;
      templatesRowChangedEvent((object) this, new dsStateSLRules.tblDocumentTemplatesRowChangeEvent((dsStateSLRules.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblDocumentTemplatesRowChangeEventHandler rowChangingEvent = this.tblDocumentTemplatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsStateSLRules.tblDocumentTemplatesRowChangeEvent((dsStateSLRules.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblDocumentTemplatesRowChangeEventHandler templatesRowDeletedEvent = this.tblDocumentTemplatesRowDeletedEvent;
      if (templatesRowDeletedEvent == null)
        return;
      templatesRowDeletedEvent((object) this, new dsStateSLRules.tblDocumentTemplatesRowChangeEvent((dsStateSLRules.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentTemplatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblDocumentTemplatesRowChangeEventHandler rowDeletingEvent = this.tblDocumentTemplatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsStateSLRules.tblDocumentTemplatesRowChangeEvent((dsStateSLRules.tblDocumentTemplatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblDocumentTemplatesRow(dsStateSLRules.tblDocumentTemplatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsStateSLRules dsStateSlRules = new dsStateSLRules();
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
        FixedValue = dsStateSlRules.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblDocumentTemplatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsStateSlRules.GetSchemaSerializable();
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
  public class tblStatesSLRequiredDataDataTable : 
    TypedTableBase<dsStateSLRules.tblStatesSLRequiredDataRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnRequiredDataID;
    private DataColumn columnUseForFiling;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblStatesSLRequiredDataDataTable()
    {
      this.tblStatesSLRequiredDataRowChanging += new dsStateSLRules.tblStatesSLRequiredDataRowChangeEventHandler(this.tblStatesSLRequiredDataDataTable_tblStatesSLRequiredDataRowChanging);
      this.TableName = "tblStatesSLRequiredData";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblStatesSLRequiredDataDataTable(DataTable table)
    {
      this.tblStatesSLRequiredDataRowChanging += new dsStateSLRules.tblStatesSLRequiredDataRowChangeEventHandler(this.tblStatesSLRequiredDataDataTable_tblStatesSLRequiredDataRowChanging);
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
    protected tblStatesSLRequiredDataDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.tblStatesSLRequiredDataRowChanging += new dsStateSLRules.tblStatesSLRequiredDataRowChangeEventHandler(this.tblStatesSLRequiredDataDataTable_tblStatesSLRequiredDataRowChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RequiredDataIDColumn => this.columnRequiredDataID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UseForFilingColumn => this.columnUseForFiling;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblStatesSLRequiredDataRow this[int index]
    {
      get => (dsStateSLRules.tblStatesSLRequiredDataRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblStatesSLRequiredDataRowChangeEventHandler tblStatesSLRequiredDataRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblStatesSLRequiredDataRowChangeEventHandler tblStatesSLRequiredDataRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblStatesSLRequiredDataRowChangeEventHandler tblStatesSLRequiredDataRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblStatesSLRequiredDataRowChangeEventHandler tblStatesSLRequiredDataRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblStatesSLRequiredDataRow(dsStateSLRules.tblStatesSLRequiredDataRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblStatesSLRequiredDataRow AddtblStatesSLRequiredDataRow(
      string StateID,
      dsStateSLRules.lstStateSLRequiredDataRow parentlstStateSLRequiredDataRowBylstStateSLRequiredData_tblStatesSLRequiredData1,
      bool UseForFiling)
    {
      dsStateSLRules.tblStatesSLRequiredDataRow row = (dsStateSLRules.tblStatesSLRequiredDataRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) StateID,
        null,
        (object) UseForFiling
      };
      if (parentlstStateSLRequiredDataRowBylstStateSLRequiredData_tblStatesSLRequiredData1 != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstStateSLRequiredDataRowBylstStateSLRequiredData_tblStatesSLRequiredData1[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblStatesSLRequiredDataRow FindByStateIDRequiredDataID(
      string StateID,
      int RequiredDataID)
    {
      return (dsStateSLRules.tblStatesSLRequiredDataRow) this.Rows.Find(new object[2]
      {
        (object) StateID,
        (object) RequiredDataID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsStateSLRules.tblStatesSLRequiredDataDataTable requiredDataDataTable = (dsStateSLRules.tblStatesSLRequiredDataDataTable) base.Clone();
      requiredDataDataTable.InitVars();
      return (DataTable) requiredDataDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsStateSLRules.tblStatesSLRequiredDataDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnRequiredDataID = this.Columns["RequiredDataID"];
      this.columnUseForFiling = this.Columns["UseForFiling"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnRequiredDataID = new DataColumn("RequiredDataID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiredDataID);
      this.columnUseForFiling = new DataColumn("UseForFiling", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUseForFiling);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnStateID,
        this.columnRequiredDataID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.MaxLength = 2;
      this.columnRequiredDataID.AllowDBNull = false;
      this.columnUseForFiling.AllowDBNull = false;
      this.columnUseForFiling.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblStatesSLRequiredDataRow NewtblStatesSLRequiredDataRow()
    {
      return (dsStateSLRules.tblStatesSLRequiredDataRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsStateSLRules.tblStatesSLRequiredDataRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsStateSLRules.tblStatesSLRequiredDataRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStatesSLRequiredDataRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblStatesSLRequiredDataRowChangeEventHandler dataRowChangedEvent = this.tblStatesSLRequiredDataRowChangedEvent;
      if (dataRowChangedEvent == null)
        return;
      dataRowChangedEvent((object) this, new dsStateSLRules.tblStatesSLRequiredDataRowChangeEvent((dsStateSLRules.tblStatesSLRequiredDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStatesSLRequiredDataRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblStatesSLRequiredDataRowChangeEventHandler rowChangingEvent = this.tblStatesSLRequiredDataRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsStateSLRules.tblStatesSLRequiredDataRowChangeEvent((dsStateSLRules.tblStatesSLRequiredDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStatesSLRequiredDataRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblStatesSLRequiredDataRowChangeEventHandler dataRowDeletedEvent = this.tblStatesSLRequiredDataRowDeletedEvent;
      if (dataRowDeletedEvent == null)
        return;
      dataRowDeletedEvent((object) this, new dsStateSLRules.tblStatesSLRequiredDataRowChangeEvent((dsStateSLRules.tblStatesSLRequiredDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblStatesSLRequiredDataRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblStatesSLRequiredDataRowChangeEventHandler rowDeletingEvent = this.tblStatesSLRequiredDataRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsStateSLRules.tblStatesSLRequiredDataRowChangeEvent((dsStateSLRules.tblStatesSLRequiredDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblStatesSLRequiredDataRow(dsStateSLRules.tblStatesSLRequiredDataRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsStateSLRules dsStateSlRules = new dsStateSLRules();
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
        FixedValue = dsStateSlRules.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblStatesSLRequiredDataDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsStateSlRules.GetSchemaSerializable();
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

    private void tblStatesSLRequiredDataDataTable_tblStatesSLRequiredDataRowChanging(
      object sender,
      dsStateSLRules.tblStatesSLRequiredDataRowChangeEvent e)
    {
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblDocumentFoldersDataTable : TypedTableBase<dsStateSLRules.tblDocumentFoldersRow>
  {
    private DataColumn columnFolderID;
    private DataColumn columnFolderName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblDocumentFoldersDataTable()
    {
      this.TableName = "tblDocumentFolders";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblDocumentFoldersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FolderIDColumn => this.columnFolderID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FolderNameColumn => this.columnFolderName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblDocumentFoldersRow this[int index]
    {
      get => (dsStateSLRules.tblDocumentFoldersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblDocumentFoldersRowChangeEventHandler tblDocumentFoldersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblDocumentFoldersRowChangeEventHandler tblDocumentFoldersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblDocumentFoldersRowChangeEventHandler tblDocumentFoldersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsStateSLRules.tblDocumentFoldersRowChangeEventHandler tblDocumentFoldersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblDocumentFoldersRow(dsStateSLRules.tblDocumentFoldersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblDocumentFoldersRow AddtblDocumentFoldersRow(string FolderName)
    {
      dsStateSLRules.tblDocumentFoldersRow row = (dsStateSLRules.tblDocumentFoldersRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) FolderName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblDocumentFoldersRow FindByFolderID(int FolderID)
    {
      return (dsStateSLRules.tblDocumentFoldersRow) this.Rows.Find(new object[1]
      {
        (object) FolderID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsStateSLRules.tblDocumentFoldersDataTable foldersDataTable = (dsStateSLRules.tblDocumentFoldersDataTable) base.Clone();
      foldersDataTable.InitVars();
      return (DataTable) foldersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsStateSLRules.tblDocumentFoldersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnFolderID = this.Columns["FolderID"];
      this.columnFolderName = this.Columns["FolderName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnFolderID = new DataColumn("FolderID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFolderID);
      this.columnFolderName = new DataColumn("FolderName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFolderName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnFolderID
      }, true));
      this.columnFolderID.AutoIncrement = true;
      this.columnFolderID.AllowDBNull = false;
      this.columnFolderID.ReadOnly = true;
      this.columnFolderID.Unique = true;
      this.columnFolderName.AllowDBNull = false;
      this.columnFolderName.MaxLength = (int) byte.MaxValue;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblDocumentFoldersRow NewtblDocumentFoldersRow()
    {
      return (dsStateSLRules.tblDocumentFoldersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsStateSLRules.tblDocumentFoldersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsStateSLRules.tblDocumentFoldersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentFoldersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblDocumentFoldersRowChangeEventHandler foldersRowChangedEvent = this.tblDocumentFoldersRowChangedEvent;
      if (foldersRowChangedEvent == null)
        return;
      foldersRowChangedEvent((object) this, new dsStateSLRules.tblDocumentFoldersRowChangeEvent((dsStateSLRules.tblDocumentFoldersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentFoldersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblDocumentFoldersRowChangeEventHandler rowChangingEvent = this.tblDocumentFoldersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsStateSLRules.tblDocumentFoldersRowChangeEvent((dsStateSLRules.tblDocumentFoldersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentFoldersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblDocumentFoldersRowChangeEventHandler foldersRowDeletedEvent = this.tblDocumentFoldersRowDeletedEvent;
      if (foldersRowDeletedEvent == null)
        return;
      foldersRowDeletedEvent((object) this, new dsStateSLRules.tblDocumentFoldersRowChangeEvent((dsStateSLRules.tblDocumentFoldersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentFoldersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsStateSLRules.tblDocumentFoldersRowChangeEventHandler rowDeletingEvent = this.tblDocumentFoldersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsStateSLRules.tblDocumentFoldersRowChangeEvent((dsStateSLRules.tblDocumentFoldersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblDocumentFoldersRow(dsStateSLRules.tblDocumentFoldersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsStateSLRules dsStateSlRules = new dsStateSLRules();
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
        FixedValue = dsStateSlRules.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblDocumentFoldersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsStateSlRules.GetSchemaSerializable();
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

  public class lstStatesRow : DataRow
  {
    private dsStateSLRules.lstStatesDataTable tablelstStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStates = (dsStateSLRules.lstStatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tablelstStates.StateIDColumn]);
      set => this[this.tablelstStates.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tablelstStates.StateColumn]);
      set => this[this.tablelstStates.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblSLStateRulesFormsRow[] GettblSLStateRulesFormsRows()
    {
      return this.Table.ChildRelations["lstStates_tblSLStateRulesForms"] != null ? (dsStateSLRules.tblSLStateRulesFormsRow[]) this.GetChildRows(this.Table.ChildRelations["lstStates_tblSLStateRulesForms"]) : new dsStateSLRules.tblSLStateRulesFormsRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblStateSLRulesRow[] GettblStateSLRulesRows()
    {
      return this.Table.ChildRelations["lstStates_tblStateSLRules"] != null ? (dsStateSLRules.tblStateSLRulesRow[]) this.GetChildRows(this.Table.ChildRelations["lstStates_tblStateSLRules"]) : new dsStateSLRules.tblStateSLRulesRow[0];
    }
  }

  public class lstStateSLRequiredDataRow : DataRow
  {
    private dsStateSLRules.lstStateSLRequiredDataDataTable tablelstStateSLRequiredData;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstStateSLRequiredDataRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStateSLRequiredData = (dsStateSLRules.lstStateSLRequiredDataDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstStateSLRequiredData.IDColumn]);
      set => this[this.tablelstStateSLRequiredData.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RequiredData
    {
      get => Conversions.ToString(this[this.tablelstStateSLRequiredData.RequiredDataColumn]);
      set => this[this.tablelstStateSLRequiredData.RequiredDataColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblStatesSLRequiredDataRow[] GettblStatesSLRequiredDataRows()
    {
      return this.Table.ChildRelations["lstStateSLRequiredData_tblStatesSLRequiredData1"] != null ? (dsStateSLRules.tblStatesSLRequiredDataRow[]) this.GetChildRows(this.Table.ChildRelations["lstStateSLRequiredData_tblStatesSLRequiredData1"]) : new dsStateSLRules.tblStatesSLRequiredDataRow[0];
    }
  }

  public class tblSLStateRulesFormsRow : DataRow
  {
    private dsStateSLRules.tblSLStateRulesFormsDataTable tabletblSLStateRulesForms;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblSLStateRulesFormsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblSLStateRulesForms = (dsStateSLRules.tblSLStateRulesFormsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tabletblSLStateRulesForms.StateIDColumn]);
      set => this[this.tabletblSLStateRulesForms.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int TemplateID
    {
      get => Conversions.ToInteger(this[this.tabletblSLStateRulesForms.TemplateIDColumn]);
      set => this[this.tabletblSLStateRulesForms.TemplateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool UseOnBinder
    {
      get => Conversions.ToBoolean(this[this.tabletblSLStateRulesForms.UseOnBinderColumn]);
      set => this[this.tabletblSLStateRulesForms.UseOnBinderColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool UserOnQuote
    {
      get => Conversions.ToBoolean(this[this.tabletblSLStateRulesForms.UserOnQuoteColumn]);
      set => this[this.tabletblSLStateRulesForms.UserOnQuoteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool InsuredSigns
    {
      get => Conversions.ToBoolean(this[this.tabletblSLStateRulesForms.InsuredSignsColumn]);
      set => this[this.tabletblSLStateRulesForms.InsuredSignsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool ProducerSigns
    {
      get => Conversions.ToBoolean(this[this.tabletblSLStateRulesForms.ProducerSignsColumn]);
      set => this[this.tabletblSLStateRulesForms.ProducerSignsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool UseOnIssuance
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblSLStateRulesForms.UseOnIssuanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UseOnIssuance' in table 'tblSLStateRulesForms' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblSLStateRulesForms.UseOnIssuanceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblDocumentTemplatesRow tblDocumentTemplatesRow
    {
      get
      {
        return (dsStateSLRules.tblDocumentTemplatesRow) this.GetParentRow(this.Table.ParentRelations["tblDocumentTemplates_tblSLStateRulesForms"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblDocumentTemplates_tblSLStateRulesForms"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.lstStatesRow lstStatesRow
    {
      get
      {
        return (dsStateSLRules.lstStatesRow) this.GetParentRow(this.Table.ParentRelations["lstStates_tblSLStateRulesForms"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstStates_tblSLStateRulesForms"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUseOnIssuanceNull()
    {
      return this.IsNull(this.tabletblSLStateRulesForms.UseOnIssuanceColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUseOnIssuanceNull()
    {
      this[this.tabletblSLStateRulesForms.UseOnIssuanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblStateSLRulesRow : DataRow
  {
    private dsStateSLRules.tblStateSLRulesDataTable tabletblStateSLRules;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblStateSLRulesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblStateSLRules = (dsStateSLRules.tblStateSLRulesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblStateSLRules.IDColumn]);
      set => this[this.tabletblStateSLRules.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tabletblStateSLRules.StateIDColumn]);
      set => this[this.tabletblStateSLRules.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string OtherInfo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblStateSLRules.OtherInfoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OtherInfo' in table 'tblStateSLRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblStateSLRules.OtherInfoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool NoAllowPremiumAllocation
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblStateSLRules.NoAllowPremiumAllocationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoAllowPremiumAllocation' in table 'tblStateSLRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblStateSLRules.NoAllowPremiumAllocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool FilingRequiredForZeroPremium
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblStateSLRules.FilingRequiredForZeroPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FilingRequiredForZeroPremium' in table 'tblStateSLRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblStateSLRules.FilingRequiredForZeroPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool UseCorporateLic
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblStateSLRules.UseCorporateLicColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UseCorporateLic' in table 'tblStateSLRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblStateSLRules.UseCorporateLicColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblStateSLRules.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'tblStateSLRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblStateSLRules.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Mail
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblStateSLRules.MailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Mail' in table 'tblStateSLRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblStateSLRules.MailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Online
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblStateSLRules.OnlineColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Online' in table 'tblStateSLRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblStateSLRules.OnlineColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Retain
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblStateSLRules.RetainColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Retain' in table 'tblStateSLRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblStateSLRules.RetainColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Comments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblStateSLRules.CommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Comments' in table 'tblStateSLRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblStateSLRules.CommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int FolderID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblStateSLRules.FolderIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FolderID' in table 'tblStateSLRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblStateSLRules.FolderIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte[] SLImageData
    {
      get
      {
        try
        {
          return (byte[]) this[this.tabletblStateSLRules.SLImageDataColumn];
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SLImageData' in table 'tblStateSLRules' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblStateSLRules.SLImageDataColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool StatePubWhiteList
    {
      get => Conversions.ToBoolean(this[this.tabletblStateSLRules.StatePubWhiteListColumn]);
      set => this[this.tabletblStateSLRules.StatePubWhiteListColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool StatePubExportList
    {
      get => Conversions.ToBoolean(this[this.tabletblStateSLRules.StatePubExportListColumn]);
      set => this[this.tabletblStateSLRules.StatePubExportListColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.lstStatesRow lstStatesRow
    {
      get
      {
        return (dsStateSLRules.lstStatesRow) this.GetParentRow(this.Table.ParentRelations["lstStates_tblStateSLRules"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstStates_tblStateSLRules"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOtherInfoNull() => this.IsNull(this.tabletblStateSLRules.OtherInfoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOtherInfoNull()
    {
      this[this.tabletblStateSLRules.OtherInfoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNoAllowPremiumAllocationNull()
    {
      return this.IsNull(this.tabletblStateSLRules.NoAllowPremiumAllocationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNoAllowPremiumAllocationNull()
    {
      this[this.tabletblStateSLRules.NoAllowPremiumAllocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFilingRequiredForZeroPremiumNull()
    {
      return this.IsNull(this.tabletblStateSLRules.FilingRequiredForZeroPremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFilingRequiredForZeroPremiumNull()
    {
      this[this.tabletblStateSLRules.FilingRequiredForZeroPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUseCorporateLicNull()
    {
      return this.IsNull(this.tabletblStateSLRules.UseCorporateLicColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUseCorporateLicNull()
    {
      this[this.tabletblStateSLRules.UseCorporateLicColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tabletblStateSLRules.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tabletblStateSLRules.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMailNull() => this.IsNull(this.tabletblStateSLRules.MailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMailNull()
    {
      this[this.tabletblStateSLRules.MailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOnlineNull() => this.IsNull(this.tabletblStateSLRules.OnlineColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOnlineNull()
    {
      this[this.tabletblStateSLRules.OnlineColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRetainNull() => this.IsNull(this.tabletblStateSLRules.RetainColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRetainNull()
    {
      this[this.tabletblStateSLRules.RetainColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCommentsNull() => this.IsNull(this.tabletblStateSLRules.CommentsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCommentsNull()
    {
      this[this.tabletblStateSLRules.CommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFolderIDNull() => this.IsNull(this.tabletblStateSLRules.FolderIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFolderIDNull()
    {
      this[this.tabletblStateSLRules.FolderIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSLImageDataNull() => this.IsNull(this.tabletblStateSLRules.SLImageDataColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSLImageDataNull()
    {
      this[this.tabletblStateSLRules.SLImageDataColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblDocumentTemplatesRow : DataRow
  {
    private dsStateSLRules.tblDocumentTemplatesDataTable tabletblDocumentTemplates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblDocumentTemplatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDocumentTemplates = (dsStateSLRules.tblDocumentTemplatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int TemplateID
    {
      get => Conversions.ToInteger(this[this.tabletblDocumentTemplates.TemplateIDColumn]);
      set => this[this.tabletblDocumentTemplates.TemplateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string TemplateName
    {
      get => Conversions.ToString(this[this.tabletblDocumentTemplates.TemplateNameColumn]);
      set => this[this.tabletblDocumentTemplates.TemplateNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblSLStateRulesFormsRow[] GettblSLStateRulesFormsRows()
    {
      return this.Table.ChildRelations["tblDocumentTemplates_tblSLStateRulesForms"] != null ? (dsStateSLRules.tblSLStateRulesFormsRow[]) this.GetChildRows(this.Table.ChildRelations["tblDocumentTemplates_tblSLStateRulesForms"]) : new dsStateSLRules.tblSLStateRulesFormsRow[0];
    }
  }

  public class tblStatesSLRequiredDataRow : DataRow
  {
    private dsStateSLRules.tblStatesSLRequiredDataDataTable tabletblStatesSLRequiredData;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblStatesSLRequiredDataRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblStatesSLRequiredData = (dsStateSLRules.tblStatesSLRequiredDataDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tabletblStatesSLRequiredData.StateIDColumn]);
      set => this[this.tabletblStatesSLRequiredData.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int RequiredDataID
    {
      get => Conversions.ToInteger(this[this.tabletblStatesSLRequiredData.RequiredDataIDColumn]);
      set => this[this.tabletblStatesSLRequiredData.RequiredDataIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool UseForFiling
    {
      get => Conversions.ToBoolean(this[this.tabletblStatesSLRequiredData.UseForFilingColumn]);
      set => this[this.tabletblStatesSLRequiredData.UseForFilingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.lstStateSLRequiredDataRow lstStateSLRequiredDataRow
    {
      get
      {
        return (dsStateSLRules.lstStateSLRequiredDataRow) this.GetParentRow(this.Table.ParentRelations["lstStateSLRequiredData_tblStatesSLRequiredData1"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstStateSLRequiredData_tblStatesSLRequiredData1"]);
      }
    }
  }

  public class tblDocumentFoldersRow : DataRow
  {
    private dsStateSLRules.tblDocumentFoldersDataTable tabletblDocumentFolders;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblDocumentFoldersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDocumentFolders = (dsStateSLRules.tblDocumentFoldersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int FolderID
    {
      get => Conversions.ToInteger(this[this.tabletblDocumentFolders.FolderIDColumn]);
      set => this[this.tabletblDocumentFolders.FolderIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FolderName
    {
      get => Conversions.ToString(this[this.tabletblDocumentFolders.FolderNameColumn]);
      set => this[this.tabletblDocumentFolders.FolderNameColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstStatesRowChangeEvent : EventArgs
  {
    private dsStateSLRules.lstStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstStatesRowChangeEvent(dsStateSLRules.lstStatesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.lstStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstStateSLRequiredDataRowChangeEvent : EventArgs
  {
    private dsStateSLRules.lstStateSLRequiredDataRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstStateSLRequiredDataRowChangeEvent(
      dsStateSLRules.lstStateSLRequiredDataRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.lstStateSLRequiredDataRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblSLStateRulesFormsRowChangeEvent : EventArgs
  {
    private dsStateSLRules.tblSLStateRulesFormsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblSLStateRulesFormsRowChangeEvent(
      dsStateSLRules.tblSLStateRulesFormsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblSLStateRulesFormsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblStateSLRulesRowChangeEvent : EventArgs
  {
    private dsStateSLRules.tblStateSLRulesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblStateSLRulesRowChangeEvent(
      dsStateSLRules.tblStateSLRulesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblStateSLRulesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblDocumentTemplatesRowChangeEvent : EventArgs
  {
    private dsStateSLRules.tblDocumentTemplatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblDocumentTemplatesRowChangeEvent(
      dsStateSLRules.tblDocumentTemplatesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblDocumentTemplatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblStatesSLRequiredDataRowChangeEvent : EventArgs
  {
    private dsStateSLRules.tblStatesSLRequiredDataRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblStatesSLRequiredDataRowChangeEvent(
      dsStateSLRules.tblStatesSLRequiredDataRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblStatesSLRequiredDataRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblDocumentFoldersRowChangeEvent : EventArgs
  {
    private dsStateSLRules.tblDocumentFoldersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblDocumentFoldersRowChangeEvent(
      dsStateSLRules.tblDocumentFoldersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsStateSLRules.tblDocumentFoldersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
