// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.dsModifyTemplateDocs
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
[XmlRoot("dsModifyTemplateDocs")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsModifyTemplateDocs : DataSet
{
  private dsModifyTemplateDocs.TemplateDocDataTable tableTemplateDoc;
  private dsModifyTemplateDocs.dtTemplateDataTable tabledtTemplate;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsModifyTemplateDocs()
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
  protected dsModifyTemplateDocs(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (TemplateDoc)] != null)
          base.Tables.Add((DataTable) new dsModifyTemplateDocs.TemplateDocDataTable(dataSet.Tables[nameof (TemplateDoc)]));
        if (dataSet.Tables[nameof (dtTemplate)] != null)
          base.Tables.Add((DataTable) new dsModifyTemplateDocs.dtTemplateDataTable(dataSet.Tables[nameof (dtTemplate)]));
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
  public dsModifyTemplateDocs.TemplateDocDataTable TemplateDoc => this.tableTemplateDoc;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsModifyTemplateDocs.dtTemplateDataTable dtTemplate => this.tabledtTemplate;

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
    dsModifyTemplateDocs modifyTemplateDocs = (dsModifyTemplateDocs) base.Clone();
    modifyTemplateDocs.InitVars();
    modifyTemplateDocs.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) modifyTemplateDocs;
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
      if (dataSet.Tables["TemplateDoc"] != null)
        base.Tables.Add((DataTable) new dsModifyTemplateDocs.TemplateDocDataTable(dataSet.Tables["TemplateDoc"]));
      if (dataSet.Tables["dtTemplate"] != null)
        base.Tables.Add((DataTable) new dsModifyTemplateDocs.dtTemplateDataTable(dataSet.Tables["dtTemplate"]));
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
    this.tableTemplateDoc = (dsModifyTemplateDocs.TemplateDocDataTable) base.Tables["TemplateDoc"];
    if (initTable && this.tableTemplateDoc != null)
      this.tableTemplateDoc.InitVars();
    this.tabledtTemplate = (dsModifyTemplateDocs.dtTemplateDataTable) base.Tables["dtTemplate"];
    if (!initTable || this.tabledtTemplate == null)
      return;
    this.tabledtTemplate.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsModifyTemplateDocs);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsModifyTemplateDocs.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableTemplateDoc = new dsModifyTemplateDocs.TemplateDocDataTable();
    base.Tables.Add((DataTable) this.tableTemplateDoc);
    this.tabledtTemplate = new dsModifyTemplateDocs.dtTemplateDataTable();
    base.Tables.Add((DataTable) this.tabledtTemplate);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeTemplateDoc() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializedtTemplate() => false;

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
    dsModifyTemplateDocs modifyTemplateDocs = new dsModifyTemplateDocs();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = modifyTemplateDocs.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = modifyTemplateDocs.GetSchemaSerializable();
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
  public delegate void TemplateDocRowChangeEventHandler(
    object sender,
    dsModifyTemplateDocs.TemplateDocRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void dtTemplateRowChangeEventHandler(
    object sender,
    dsModifyTemplateDocs.dtTemplateRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class TemplateDocDataTable : TypedTableBase<dsModifyTemplateDocs.TemplateDocRow>
  {
    private DataColumn columnTemplateID;
    private DataColumn columnTemplateName;
    private DataColumn columnDescription;
    private DataColumn columnEditLink;
    private DataColumn columnPreviewLink;
    private DataColumn columnTempFilename;
    private DataColumn columnRemoveLink;
    private DataColumn columnClear;
    private DataColumn columnChecked;
    private DataColumn columnIsEditable;
    private DataColumn columnRequiresEdit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TemplateDocDataTable()
    {
      this.TableName = "TemplateDoc";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal TemplateDocDataTable(DataTable table)
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
    protected TemplateDocDataTable(SerializationInfo info, StreamingContext context)
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
    public DataColumn EditLinkColumn => this.columnEditLink;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PreviewLinkColumn => this.columnPreviewLink;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TempFilenameColumn => this.columnTempFilename;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RemoveLinkColumn => this.columnRemoveLink;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClearColumn => this.columnClear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CheckedColumn => this.columnChecked;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IsEditableColumn => this.columnIsEditable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RequiresEditColumn => this.columnRequiresEdit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsModifyTemplateDocs.TemplateDocRow this[int index]
    {
      get => (dsModifyTemplateDocs.TemplateDocRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsModifyTemplateDocs.TemplateDocRowChangeEventHandler TemplateDocRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsModifyTemplateDocs.TemplateDocRowChangeEventHandler TemplateDocRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsModifyTemplateDocs.TemplateDocRowChangeEventHandler TemplateDocRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsModifyTemplateDocs.TemplateDocRowChangeEventHandler TemplateDocRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddTemplateDocRow(dsModifyTemplateDocs.TemplateDocRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsModifyTemplateDocs.TemplateDocRow AddTemplateDocRow(
      int TemplateID,
      string TemplateName,
      string Description,
      string EditLink,
      string PreviewLink,
      string TempFilename,
      string RemoveLink,
      string Clear,
      bool Checked,
      bool IsEditable,
      bool RequiresEdit)
    {
      dsModifyTemplateDocs.TemplateDocRow row = (dsModifyTemplateDocs.TemplateDocRow) this.NewRow();
      object[] objArray = new object[11]
      {
        (object) TemplateID,
        (object) TemplateName,
        (object) Description,
        (object) EditLink,
        (object) PreviewLink,
        (object) TempFilename,
        (object) RemoveLink,
        (object) Clear,
        (object) Checked,
        (object) IsEditable,
        (object) RequiresEdit
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsModifyTemplateDocs.TemplateDocRow FindByTemplateID(int TemplateID)
    {
      return (dsModifyTemplateDocs.TemplateDocRow) this.Rows.Find(new object[1]
      {
        (object) TemplateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsModifyTemplateDocs.TemplateDocDataTable templateDocDataTable = (dsModifyTemplateDocs.TemplateDocDataTable) base.Clone();
      templateDocDataTable.InitVars();
      return (DataTable) templateDocDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsModifyTemplateDocs.TemplateDocDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnTemplateID = this.Columns["TemplateID"];
      this.columnTemplateName = this.Columns["TemplateName"];
      this.columnDescription = this.Columns["Description"];
      this.columnEditLink = this.Columns["EditLink"];
      this.columnPreviewLink = this.Columns["PreviewLink"];
      this.columnTempFilename = this.Columns["TempFilename"];
      this.columnRemoveLink = this.Columns["RemoveLink"];
      this.columnClear = this.Columns["Clear"];
      this.columnChecked = this.Columns["Checked"];
      this.columnIsEditable = this.Columns["IsEditable"];
      this.columnRequiresEdit = this.Columns["RequiresEdit"];
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
      this.columnEditLink = new DataColumn("EditLink", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEditLink);
      this.columnPreviewLink = new DataColumn("PreviewLink", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPreviewLink);
      this.columnTempFilename = new DataColumn("TempFilename", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTempFilename);
      this.columnRemoveLink = new DataColumn("RemoveLink", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemoveLink);
      this.columnClear = new DataColumn("Clear", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClear);
      this.columnChecked = new DataColumn("Checked", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChecked);
      this.columnIsEditable = new DataColumn("IsEditable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsEditable);
      this.columnRequiresEdit = new DataColumn("RequiresEdit", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiresEdit);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsModifyTemplateDocsKey1", new DataColumn[1]
      {
        this.columnTemplateID
      }, true));
      this.columnTemplateID.AllowDBNull = false;
      this.columnTemplateID.Unique = true;
      this.columnTemplateName.AllowDBNull = false;
      this.columnDescription.AllowDBNull = false;
      this.columnEditLink.AllowDBNull = false;
      this.columnEditLink.DefaultValue = (object) "Edit";
      this.columnPreviewLink.AllowDBNull = false;
      this.columnPreviewLink.DefaultValue = (object) "Preview";
      this.columnTempFilename.AllowDBNull = false;
      this.columnTempFilename.DefaultValue = (object) "Remove";
      this.columnRemoveLink.AllowDBNull = false;
      this.columnRemoveLink.DefaultValue = (object) "Remove";
      this.columnChecked.DefaultValue = (object) false;
      this.columnIsEditable.AllowDBNull = false;
      this.columnIsEditable.DefaultValue = (object) true;
      this.columnRequiresEdit.AllowDBNull = false;
      this.columnRequiresEdit.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsModifyTemplateDocs.TemplateDocRow NewTemplateDocRow()
    {
      return (dsModifyTemplateDocs.TemplateDocRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsModifyTemplateDocs.TemplateDocRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsModifyTemplateDocs.TemplateDocRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TemplateDocRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsModifyTemplateDocs.TemplateDocRowChangeEventHandler docRowChangedEvent = this.TemplateDocRowChangedEvent;
      if (docRowChangedEvent == null)
        return;
      docRowChangedEvent((object) this, new dsModifyTemplateDocs.TemplateDocRowChangeEvent((dsModifyTemplateDocs.TemplateDocRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TemplateDocRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsModifyTemplateDocs.TemplateDocRowChangeEventHandler rowChangingEvent = this.TemplateDocRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsModifyTemplateDocs.TemplateDocRowChangeEvent((dsModifyTemplateDocs.TemplateDocRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TemplateDocRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsModifyTemplateDocs.TemplateDocRowChangeEventHandler docRowDeletedEvent = this.TemplateDocRowDeletedEvent;
      if (docRowDeletedEvent == null)
        return;
      docRowDeletedEvent((object) this, new dsModifyTemplateDocs.TemplateDocRowChangeEvent((dsModifyTemplateDocs.TemplateDocRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TemplateDocRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsModifyTemplateDocs.TemplateDocRowChangeEventHandler rowDeletingEvent = this.TemplateDocRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsModifyTemplateDocs.TemplateDocRowChangeEvent((dsModifyTemplateDocs.TemplateDocRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveTemplateDocRow(dsModifyTemplateDocs.TemplateDocRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsModifyTemplateDocs modifyTemplateDocs = new dsModifyTemplateDocs();
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
        FixedValue = modifyTemplateDocs.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (TemplateDocDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = modifyTemplateDocs.GetSchemaSerializable();
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
  public class dtTemplateDataTable : TypedTableBase<dsModifyTemplateDocs.dtTemplateRow>
  {
    private DataColumn columnTemplateID;
    private DataColumn columnIsWordDocument;
    private DataColumn columnDescription;
    private DataColumn columnIsEditable;
    private DataColumn columnRemovable;
    private DataColumn columnClearCompleted;
    private DataColumn columnIsEmail;
    private DataColumn columnRequiresEdit;
    private DataColumn columnTemplateType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dtTemplateDataTable()
    {
      this.TableName = "dtTemplate";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal dtTemplateDataTable(DataTable table)
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
    protected dtTemplateDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TemplateIDColumn => this.columnTemplateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IsWordDocumentColumn => this.columnIsWordDocument;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IsEditableColumn => this.columnIsEditable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RemovableColumn => this.columnRemovable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClearCompletedColumn => this.columnClearCompleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IsEmailColumn => this.columnIsEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RequiresEditColumn => this.columnRequiresEdit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TemplateTypeColumn => this.columnTemplateType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsModifyTemplateDocs.dtTemplateRow this[int index]
    {
      get => (dsModifyTemplateDocs.dtTemplateRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsModifyTemplateDocs.dtTemplateRowChangeEventHandler dtTemplateRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsModifyTemplateDocs.dtTemplateRowChangeEventHandler dtTemplateRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsModifyTemplateDocs.dtTemplateRowChangeEventHandler dtTemplateRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsModifyTemplateDocs.dtTemplateRowChangeEventHandler dtTemplateRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AdddtTemplateRow(dsModifyTemplateDocs.dtTemplateRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsModifyTemplateDocs.dtTemplateRow AdddtTemplateRow(
      int TemplateID,
      bool IsWordDocument,
      string Description,
      bool IsEditable,
      bool Removable,
      bool ClearCompleted,
      bool IsEmail,
      bool RequiresEdit,
      string TemplateType)
    {
      dsModifyTemplateDocs.dtTemplateRow row = (dsModifyTemplateDocs.dtTemplateRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) TemplateID,
        (object) IsWordDocument,
        (object) Description,
        (object) IsEditable,
        (object) Removable,
        (object) ClearCompleted,
        (object) IsEmail,
        (object) RequiresEdit,
        (object) TemplateType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsModifyTemplateDocs.dtTemplateRow FindByTemplateID(int TemplateID)
    {
      return (dsModifyTemplateDocs.dtTemplateRow) this.Rows.Find(new object[1]
      {
        (object) TemplateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsModifyTemplateDocs.dtTemplateDataTable templateDataTable = (dsModifyTemplateDocs.dtTemplateDataTable) base.Clone();
      templateDataTable.InitVars();
      return (DataTable) templateDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsModifyTemplateDocs.dtTemplateDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnTemplateID = this.Columns["TemplateID"];
      this.columnIsWordDocument = this.Columns["IsWordDocument"];
      this.columnDescription = this.Columns["Description"];
      this.columnIsEditable = this.Columns["IsEditable"];
      this.columnRemovable = this.Columns["Removable"];
      this.columnClearCompleted = this.Columns["ClearCompleted"];
      this.columnIsEmail = this.Columns["IsEmail"];
      this.columnRequiresEdit = this.Columns["RequiresEdit"];
      this.columnTemplateType = this.Columns["TemplateType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnTemplateID = new DataColumn("TemplateID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateID);
      this.columnIsWordDocument = new DataColumn("IsWordDocument", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsWordDocument);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnIsEditable = new DataColumn("IsEditable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsEditable);
      this.columnRemovable = new DataColumn("Removable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemovable);
      this.columnClearCompleted = new DataColumn("ClearCompleted", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClearCompleted);
      this.columnIsEmail = new DataColumn("IsEmail", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsEmail);
      this.columnRequiresEdit = new DataColumn("RequiresEdit", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiresEdit);
      this.columnTemplateType = new DataColumn("TemplateType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTemplateType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnTemplateID
      }, true));
      this.columnTemplateID.AllowDBNull = false;
      this.columnTemplateID.Unique = true;
      this.columnRequiresEdit.AllowDBNull = false;
      this.columnRequiresEdit.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsModifyTemplateDocs.dtTemplateRow NewdtTemplateRow()
    {
      return (dsModifyTemplateDocs.dtTemplateRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsModifyTemplateDocs.dtTemplateRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsModifyTemplateDocs.dtTemplateRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtTemplateRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsModifyTemplateDocs.dtTemplateRowChangeEventHandler templateRowChangedEvent = this.dtTemplateRowChangedEvent;
      if (templateRowChangedEvent == null)
        return;
      templateRowChangedEvent((object) this, new dsModifyTemplateDocs.dtTemplateRowChangeEvent((dsModifyTemplateDocs.dtTemplateRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtTemplateRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsModifyTemplateDocs.dtTemplateRowChangeEventHandler rowChangingEvent = this.dtTemplateRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsModifyTemplateDocs.dtTemplateRowChangeEvent((dsModifyTemplateDocs.dtTemplateRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtTemplateRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsModifyTemplateDocs.dtTemplateRowChangeEventHandler templateRowDeletedEvent = this.dtTemplateRowDeletedEvent;
      if (templateRowDeletedEvent == null)
        return;
      templateRowDeletedEvent((object) this, new dsModifyTemplateDocs.dtTemplateRowChangeEvent((dsModifyTemplateDocs.dtTemplateRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtTemplateRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsModifyTemplateDocs.dtTemplateRowChangeEventHandler rowDeletingEvent = this.dtTemplateRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsModifyTemplateDocs.dtTemplateRowChangeEvent((dsModifyTemplateDocs.dtTemplateRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovedtTemplateRow(dsModifyTemplateDocs.dtTemplateRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsModifyTemplateDocs modifyTemplateDocs = new dsModifyTemplateDocs();
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
        FixedValue = modifyTemplateDocs.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtTemplateDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = modifyTemplateDocs.GetSchemaSerializable();
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

  public class TemplateDocRow : DataRow
  {
    private dsModifyTemplateDocs.TemplateDocDataTable tableTemplateDoc;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal TemplateDocRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTemplateDoc = (dsModifyTemplateDocs.TemplateDocDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int TemplateID
    {
      get => Conversions.ToInteger(this[this.tableTemplateDoc.TemplateIDColumn]);
      set => this[this.tableTemplateDoc.TemplateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string TemplateName
    {
      get => Conversions.ToString(this[this.tableTemplateDoc.TemplateNameColumn]);
      set => this[this.tableTemplateDoc.TemplateNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tableTemplateDoc.DescriptionColumn]);
      set => this[this.tableTemplateDoc.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EditLink
    {
      get => Conversions.ToString(this[this.tableTemplateDoc.EditLinkColumn]);
      set => this[this.tableTemplateDoc.EditLinkColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PreviewLink
    {
      get => Conversions.ToString(this[this.tableTemplateDoc.PreviewLinkColumn]);
      set => this[this.tableTemplateDoc.PreviewLinkColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string TempFilename
    {
      get => Conversions.ToString(this[this.tableTemplateDoc.TempFilenameColumn]);
      set => this[this.tableTemplateDoc.TempFilenameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string RemoveLink
    {
      get => Conversions.ToString(this[this.tableTemplateDoc.RemoveLinkColumn]);
      set => this[this.tableTemplateDoc.RemoveLinkColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Clear
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTemplateDoc.ClearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Clear' in table 'TemplateDoc' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTemplateDoc.ClearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Checked
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableTemplateDoc.CheckedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Checked' in table 'TemplateDoc' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTemplateDoc.CheckedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEditable
    {
      get => Conversions.ToBoolean(this[this.tableTemplateDoc.IsEditableColumn]);
      set => this[this.tableTemplateDoc.IsEditableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool RequiresEdit
    {
      get => Conversions.ToBoolean(this[this.tableTemplateDoc.RequiresEditColumn]);
      set => this[this.tableTemplateDoc.RequiresEditColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClearNull() => this.IsNull(this.tableTemplateDoc.ClearColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClearNull()
    {
      this[this.tableTemplateDoc.ClearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCheckedNull() => this.IsNull(this.tableTemplateDoc.CheckedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCheckedNull()
    {
      this[this.tableTemplateDoc.CheckedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtTemplateRow : DataRow
  {
    private dsModifyTemplateDocs.dtTemplateDataTable tabledtTemplate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal dtTemplateRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtTemplate = (dsModifyTemplateDocs.dtTemplateDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int TemplateID
    {
      get => Conversions.ToInteger(this[this.tabledtTemplate.TemplateIDColumn]);
      set => this[this.tabledtTemplate.TemplateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsWordDocument
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtTemplate.IsWordDocumentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IsWordDocument' in table 'dtTemplate' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTemplate.IsWordDocumentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtTemplate.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'dtTemplate' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTemplate.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEditable
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtTemplate.IsEditableColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IsEditable' in table 'dtTemplate' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTemplate.IsEditableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Removable
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtTemplate.RemovableColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Removable' in table 'dtTemplate' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTemplate.RemovableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool ClearCompleted
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtTemplate.ClearCompletedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClearCompleted' in table 'dtTemplate' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTemplate.ClearCompletedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEmail
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtTemplate.IsEmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IsEmail' in table 'dtTemplate' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTemplate.IsEmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool RequiresEdit
    {
      get => Conversions.ToBoolean(this[this.tabledtTemplate.RequiresEditColumn]);
      set => this[this.tabledtTemplate.RequiresEditColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string TemplateType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtTemplate.TemplateTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TemplateType' in table 'dtTemplate' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtTemplate.TemplateTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIsWordDocumentNull() => this.IsNull(this.tabledtTemplate.IsWordDocumentColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIsWordDocumentNull()
    {
      this[this.tabledtTemplate.IsWordDocumentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tabledtTemplate.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tabledtTemplate.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIsEditableNull() => this.IsNull(this.tabledtTemplate.IsEditableColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIsEditableNull()
    {
      this[this.tabledtTemplate.IsEditableColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRemovableNull() => this.IsNull(this.tabledtTemplate.RemovableColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRemovableNull()
    {
      this[this.tabledtTemplate.RemovableColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClearCompletedNull() => this.IsNull(this.tabledtTemplate.ClearCompletedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClearCompletedNull()
    {
      this[this.tabledtTemplate.ClearCompletedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIsEmailNull() => this.IsNull(this.tabledtTemplate.IsEmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIsEmailNull()
    {
      this[this.tabledtTemplate.IsEmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTemplateTypeNull() => this.IsNull(this.tabledtTemplate.TemplateTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTemplateTypeNull()
    {
      this[this.tabledtTemplate.TemplateTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class TemplateDocRowChangeEvent : EventArgs
  {
    private dsModifyTemplateDocs.TemplateDocRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TemplateDocRowChangeEvent(dsModifyTemplateDocs.TemplateDocRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsModifyTemplateDocs.TemplateDocRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class dtTemplateRowChangeEvent : EventArgs
  {
    private dsModifyTemplateDocs.dtTemplateRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dtTemplateRowChangeEvent(dsModifyTemplateDocs.dtTemplateRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsModifyTemplateDocs.dtTemplateRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
