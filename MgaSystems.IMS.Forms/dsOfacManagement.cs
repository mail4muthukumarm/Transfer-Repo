// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.dsOfacManagement
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
namespace MGASystems.IMS.Forms;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsOfacManagement")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsOfacManagement : DataSet
{
  private dsOfacManagement.OfacAdminDataTable tableOfacAdmin;
  private dsOfacManagement.UsersDataTable tableUsers;
  private dsOfacManagement.ReasonsDataTable tableReasons;
  private dsOfacManagement.OfacSettingsDataTable tableOfacSettings;
  private dsOfacManagement.SettingConfigsDataTable tableSettingConfigs;
  private dsOfacManagement.HitLogDataTable tableHitLog;
  private dsOfacManagement.SearchLogDataTable tableSearchLog;
  private DataRelation relationUsers_OfacAdmin;
  private DataRelation relationOfacSettings_SettingConfigs;
  private DataRelation relationOfacAdmin_HitLog;
  private DataRelation relationOfacAdmin_SearchLog;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsOfacManagement()
  {
    this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
    this.InitExpressions();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected dsOfacManagement(SerializationInfo info, StreamingContext context)
    : base(info, context, false)
  {
    this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    if (this.IsBinarySerialized(info, context))
    {
      this.InitVars(false);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      this.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
      if (this.DetermineSchemaSerializationMode(info, context) != SchemaSerializationMode.ExcludeSchema)
        return;
      this.InitExpressions();
    }
    else
    {
      string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
      if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
      {
        DataSet dataSet = new DataSet();
        dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        if (dataSet.Tables[nameof (OfacAdmin)] != null)
          base.Tables.Add((DataTable) new dsOfacManagement.OfacAdminDataTable(dataSet.Tables[nameof (OfacAdmin)]));
        if (dataSet.Tables[nameof (Users)] != null)
          base.Tables.Add((DataTable) new dsOfacManagement.UsersDataTable(dataSet.Tables[nameof (Users)]));
        if (dataSet.Tables[nameof (Reasons)] != null)
          base.Tables.Add((DataTable) new dsOfacManagement.ReasonsDataTable(dataSet.Tables[nameof (Reasons)]));
        if (dataSet.Tables[nameof (OfacSettings)] != null)
          base.Tables.Add((DataTable) new dsOfacManagement.OfacSettingsDataTable(dataSet.Tables[nameof (OfacSettings)]));
        if (dataSet.Tables[nameof (SettingConfigs)] != null)
          base.Tables.Add((DataTable) new dsOfacManagement.SettingConfigsDataTable(dataSet.Tables[nameof (SettingConfigs)]));
        if (dataSet.Tables[nameof (HitLog)] != null)
          base.Tables.Add((DataTable) new dsOfacManagement.HitLogDataTable(dataSet.Tables[nameof (HitLog)]));
        if (dataSet.Tables[nameof (SearchLog)] != null)
          base.Tables.Add((DataTable) new dsOfacManagement.SearchLogDataTable(dataSet.Tables[nameof (SearchLog)]));
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
        this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        this.InitExpressions();
      }
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
  public dsOfacManagement.OfacAdminDataTable OfacAdmin => this.tableOfacAdmin;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsOfacManagement.UsersDataTable Users => this.tableUsers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsOfacManagement.ReasonsDataTable Reasons => this.tableReasons;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsOfacManagement.OfacSettingsDataTable OfacSettings => this.tableOfacSettings;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsOfacManagement.SettingConfigsDataTable SettingConfigs => this.tableSettingConfigs;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsOfacManagement.HitLogDataTable HitLog => this.tableHitLog;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsOfacManagement.SearchLogDataTable SearchLog => this.tableSearchLog;

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
    dsOfacManagement dsOfacManagement = (dsOfacManagement) base.Clone();
    dsOfacManagement.InitVars();
    dsOfacManagement.InitExpressions();
    dsOfacManagement.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsOfacManagement;
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
      if (dataSet.Tables["OfacAdmin"] != null)
        base.Tables.Add((DataTable) new dsOfacManagement.OfacAdminDataTable(dataSet.Tables["OfacAdmin"]));
      if (dataSet.Tables["Users"] != null)
        base.Tables.Add((DataTable) new dsOfacManagement.UsersDataTable(dataSet.Tables["Users"]));
      if (dataSet.Tables["Reasons"] != null)
        base.Tables.Add((DataTable) new dsOfacManagement.ReasonsDataTable(dataSet.Tables["Reasons"]));
      if (dataSet.Tables["OfacSettings"] != null)
        base.Tables.Add((DataTable) new dsOfacManagement.OfacSettingsDataTable(dataSet.Tables["OfacSettings"]));
      if (dataSet.Tables["SettingConfigs"] != null)
        base.Tables.Add((DataTable) new dsOfacManagement.SettingConfigsDataTable(dataSet.Tables["SettingConfigs"]));
      if (dataSet.Tables["HitLog"] != null)
        base.Tables.Add((DataTable) new dsOfacManagement.HitLogDataTable(dataSet.Tables["HitLog"]));
      if (dataSet.Tables["SearchLog"] != null)
        base.Tables.Add((DataTable) new dsOfacManagement.SearchLogDataTable(dataSet.Tables["SearchLog"]));
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
    this.tableOfacAdmin = (dsOfacManagement.OfacAdminDataTable) base.Tables["OfacAdmin"];
    if (initTable && this.tableOfacAdmin != null)
      this.tableOfacAdmin.InitVars();
    this.tableUsers = (dsOfacManagement.UsersDataTable) base.Tables["Users"];
    if (initTable && this.tableUsers != null)
      this.tableUsers.InitVars();
    this.tableReasons = (dsOfacManagement.ReasonsDataTable) base.Tables["Reasons"];
    if (initTable && this.tableReasons != null)
      this.tableReasons.InitVars();
    this.tableOfacSettings = (dsOfacManagement.OfacSettingsDataTable) base.Tables["OfacSettings"];
    if (initTable && this.tableOfacSettings != null)
      this.tableOfacSettings.InitVars();
    this.tableSettingConfigs = (dsOfacManagement.SettingConfigsDataTable) base.Tables["SettingConfigs"];
    if (initTable && this.tableSettingConfigs != null)
      this.tableSettingConfigs.InitVars();
    this.tableHitLog = (dsOfacManagement.HitLogDataTable) base.Tables["HitLog"];
    if (initTable && this.tableHitLog != null)
      this.tableHitLog.InitVars();
    this.tableSearchLog = (dsOfacManagement.SearchLogDataTable) base.Tables["SearchLog"];
    if (initTable && this.tableSearchLog != null)
      this.tableSearchLog.InitVars();
    this.relationUsers_OfacAdmin = this.Relations["Users_OfacAdmin"];
    this.relationOfacSettings_SettingConfigs = this.Relations["OfacSettings_SettingConfigs"];
    this.relationOfacAdmin_HitLog = this.Relations["OfacAdmin_HitLog"];
    this.relationOfacAdmin_SearchLog = this.Relations["OfacAdmin_SearchLog"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsOfacManagement);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsOfacManagement.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableOfacAdmin = new dsOfacManagement.OfacAdminDataTable(false);
    base.Tables.Add((DataTable) this.tableOfacAdmin);
    this.tableUsers = new dsOfacManagement.UsersDataTable();
    base.Tables.Add((DataTable) this.tableUsers);
    this.tableReasons = new dsOfacManagement.ReasonsDataTable();
    base.Tables.Add((DataTable) this.tableReasons);
    this.tableOfacSettings = new dsOfacManagement.OfacSettingsDataTable();
    base.Tables.Add((DataTable) this.tableOfacSettings);
    this.tableSettingConfigs = new dsOfacManagement.SettingConfigsDataTable();
    base.Tables.Add((DataTable) this.tableSettingConfigs);
    this.tableHitLog = new dsOfacManagement.HitLogDataTable();
    base.Tables.Add((DataTable) this.tableHitLog);
    this.tableSearchLog = new dsOfacManagement.SearchLogDataTable();
    base.Tables.Add((DataTable) this.tableSearchLog);
    this.relationUsers_OfacAdmin = new DataRelation("Users_OfacAdmin", new DataColumn[1]
    {
      this.tableUsers.UserGUIDColumn
    }, new DataColumn[1]
    {
      this.tableOfacAdmin.ClearByUserGuidColumn
    }, false);
    this.Relations.Add(this.relationUsers_OfacAdmin);
    this.relationOfacSettings_SettingConfigs = new DataRelation("OfacSettings_SettingConfigs", new DataColumn[1]
    {
      this.tableOfacSettings.OfacTypeIDColumn
    }, new DataColumn[1]
    {
      this.tableSettingConfigs.OfacTypeIDColumn
    }, false);
    this.Relations.Add(this.relationOfacSettings_SettingConfigs);
    this.relationOfacAdmin_HitLog = new DataRelation("OfacAdmin_HitLog", new DataColumn[2]
    {
      this.tableOfacAdmin.EntityGUIDColumn,
      this.tableOfacAdmin.ParentEntityGUIDColumn
    }, new DataColumn[2]
    {
      this.tableHitLog.EntityGUIDColumn,
      this.tableHitLog.ParentEntityGUIDColumn
    }, false);
    this.Relations.Add(this.relationOfacAdmin_HitLog);
    this.relationOfacAdmin_SearchLog = new DataRelation("OfacAdmin_SearchLog", new DataColumn[2]
    {
      this.tableOfacAdmin.EntityGUIDColumn,
      this.tableOfacAdmin.ParentEntityGUIDColumn
    }, new DataColumn[2]
    {
      this.tableSearchLog.EntityGUIDColumn,
      this.tableSearchLog.ParentEntityGUIDColumn
    }, false);
    this.Relations.Add(this.relationOfacAdmin_SearchLog);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeOfacAdmin() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeUsers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeReasons() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeOfacSettings() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeSettingConfigs() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeHitLog() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeSearchLog() => false;

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
    dsOfacManagement dsOfacManagement = new dsOfacManagement();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsOfacManagement.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsOfacManagement.GetSchemaSerializable();
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

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitExpressions()
  {
    this.OfacAdmin.ClearByUserNameColumn.Expression = "Parent(Users_OfacAdmin).UserName";
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void OfacAdminRowChangeEventHandler(
    object sender,
    dsOfacManagement.OfacAdminRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void UsersRowChangeEventHandler(
    object sender,
    dsOfacManagement.UsersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void ReasonsRowChangeEventHandler(
    object sender,
    dsOfacManagement.ReasonsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void OfacSettingsRowChangeEventHandler(
    object sender,
    dsOfacManagement.OfacSettingsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void SettingConfigsRowChangeEventHandler(
    object sender,
    dsOfacManagement.SettingConfigsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void HitLogRowChangeEventHandler(
    object sender,
    dsOfacManagement.HitLogRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void SearchLogRowChangeEventHandler(
    object sender,
    dsOfacManagement.SearchLogRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class OfacAdminDataTable : TypedTableBase<dsOfacManagement.OfacAdminRow>
  {
    private DataColumn columnEntityGUID;
    private DataColumn columnParentEntityGUID;
    private DataColumn columnOfacTypeID;
    private DataColumn columnEntityName;
    private DataColumn columnEntityType;
    private DataColumn columnRecreateTypeName;
    private DataColumn columnLogDate;
    private DataColumn columnSearchCriteria;
    private DataColumn columnOfacXml;
    private DataColumn columnReturnCode;
    private DataColumn columnHitDate;
    private DataColumn columnHitScore;
    private DataColumn columnClearDate;
    private DataColumn columnClearByUserGuid;
    private DataColumn columnClearReason;
    private DataColumn columnOFACCleared;
    private DataColumn columnNotes;
    private DataColumn columnClearByUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public OfacAdminDataTable()
      : this(false)
    {
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public OfacAdminDataTable(bool initExpressions)
    {
      this.TableName = "OfacAdmin";
      this.BeginInit();
      this.InitClass();
      if (initExpressions)
        this.InitExpressions();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal OfacAdminDataTable(DataTable table)
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
    protected OfacAdminDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EntityGUIDColumn => this.columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ParentEntityGUIDColumn => this.columnParentEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OfacTypeIDColumn => this.columnOfacTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EntityNameColumn => this.columnEntityName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EntityTypeColumn => this.columnEntityType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RecreateTypeNameColumn => this.columnRecreateTypeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LogDateColumn => this.columnLogDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SearchCriteriaColumn => this.columnSearchCriteria;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OfacXmlColumn => this.columnOfacXml;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ReturnCodeColumn => this.columnReturnCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn HitDateColumn => this.columnHitDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn HitScoreColumn => this.columnHitScore;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClearDateColumn => this.columnClearDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClearByUserGuidColumn => this.columnClearByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClearReasonColumn => this.columnClearReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OFACClearedColumn => this.columnOFACCleared;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NotesColumn => this.columnNotes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClearByUserNameColumn => this.columnClearByUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.OfacAdminRow this[int index]
    {
      get => (dsOfacManagement.OfacAdminRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.OfacAdminRowChangeEventHandler OfacAdminRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.OfacAdminRowChangeEventHandler OfacAdminRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.OfacAdminRowChangeEventHandler OfacAdminRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.OfacAdminRowChangeEventHandler OfacAdminRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddOfacAdminRow(dsOfacManagement.OfacAdminRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.OfacAdminRow AddOfacAdminRow(
      Guid EntityGUID,
      Guid ParentEntityGUID,
      int OfacTypeID,
      string EntityName,
      string EntityType,
      string RecreateTypeName,
      DateTime LogDate,
      string SearchCriteria,
      string OfacXml,
      string ReturnCode,
      DateTime HitDate,
      int HitScore,
      DateTime ClearDate,
      dsOfacManagement.UsersRow parentUsersRowByUsers_OfacAdmin,
      string ClearReason,
      bool OFACCleared,
      string Notes,
      string ClearByUserName)
    {
      dsOfacManagement.OfacAdminRow row = (dsOfacManagement.OfacAdminRow) this.NewRow();
      object[] objArray = new object[18]
      {
        (object) EntityGUID,
        (object) ParentEntityGUID,
        (object) OfacTypeID,
        (object) EntityName,
        (object) EntityType,
        (object) RecreateTypeName,
        (object) LogDate,
        (object) SearchCriteria,
        (object) OfacXml,
        (object) ReturnCode,
        (object) HitDate,
        (object) HitScore,
        (object) ClearDate,
        null,
        (object) ClearReason,
        (object) OFACCleared,
        (object) Notes,
        (object) ClearByUserName
      };
      if (parentUsersRowByUsers_OfacAdmin != null)
        objArray[13] = RuntimeHelpers.GetObjectValue(parentUsersRowByUsers_OfacAdmin[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.OfacAdminRow AddOfacAdminRow(
      Guid EntityGUID,
      Guid ParentEntityGUID,
      int OfacTypeID,
      string EntityName,
      string EntityType,
      string RecreateTypeName,
      DateTime LogDate,
      string SearchCriteria,
      string OfacXml,
      string ReturnCode,
      DateTime HitDate,
      int HitScore,
      DateTime ClearDate,
      dsOfacManagement.UsersRow parentUsersRowByUsers_OfacAdmin,
      string ClearReason,
      bool OFACCleared,
      string Notes)
    {
      dsOfacManagement.OfacAdminRow row = (dsOfacManagement.OfacAdminRow) this.NewRow();
      object[] objArray = new object[18]
      {
        (object) EntityGUID,
        (object) ParentEntityGUID,
        (object) OfacTypeID,
        (object) EntityName,
        (object) EntityType,
        (object) RecreateTypeName,
        (object) LogDate,
        (object) SearchCriteria,
        (object) OfacXml,
        (object) ReturnCode,
        (object) HitDate,
        (object) HitScore,
        (object) ClearDate,
        null,
        (object) ClearReason,
        (object) OFACCleared,
        (object) Notes,
        null
      };
      if (parentUsersRowByUsers_OfacAdmin != null)
        objArray[13] = RuntimeHelpers.GetObjectValue(parentUsersRowByUsers_OfacAdmin[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.OfacAdminRow FindByEntityGUIDParentEntityGUID(
      Guid EntityGUID,
      Guid ParentEntityGUID)
    {
      return (dsOfacManagement.OfacAdminRow) this.Rows.Find(new object[2]
      {
        (object) EntityGUID,
        (object) ParentEntityGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsOfacManagement.OfacAdminDataTable ofacAdminDataTable = (dsOfacManagement.OfacAdminDataTable) base.Clone();
      ofacAdminDataTable.InitVars();
      return (DataTable) ofacAdminDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOfacManagement.OfacAdminDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnEntityGUID = this.Columns["EntityGUID"];
      this.columnParentEntityGUID = this.Columns["ParentEntityGUID"];
      this.columnOfacTypeID = this.Columns["OfacTypeID"];
      this.columnEntityName = this.Columns["EntityName"];
      this.columnEntityType = this.Columns["EntityType"];
      this.columnRecreateTypeName = this.Columns["RecreateTypeName"];
      this.columnLogDate = this.Columns["LogDate"];
      this.columnSearchCriteria = this.Columns["SearchCriteria"];
      this.columnOfacXml = this.Columns["OfacXml"];
      this.columnReturnCode = this.Columns["ReturnCode"];
      this.columnHitDate = this.Columns["HitDate"];
      this.columnHitScore = this.Columns["HitScore"];
      this.columnClearDate = this.Columns["ClearDate"];
      this.columnClearByUserGuid = this.Columns["ClearByUserGuid"];
      this.columnClearReason = this.Columns["ClearReason"];
      this.columnOFACCleared = this.Columns["OFACCleared"];
      this.columnNotes = this.Columns["Notes"];
      this.columnClearByUserName = this.Columns["ClearByUserName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.columnParentEntityGUID = new DataColumn("ParentEntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParentEntityGUID);
      this.columnOfacTypeID = new DataColumn("OfacTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfacTypeID);
      this.columnEntityName = new DataColumn("EntityName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityName);
      this.columnEntityType = new DataColumn("EntityType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityType);
      this.columnRecreateTypeName = new DataColumn("RecreateTypeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecreateTypeName);
      this.columnLogDate = new DataColumn("LogDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLogDate);
      this.columnSearchCriteria = new DataColumn("SearchCriteria", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSearchCriteria);
      this.columnOfacXml = new DataColumn("OfacXml", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfacXml);
      this.columnReturnCode = new DataColumn("ReturnCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReturnCode);
      this.columnHitDate = new DataColumn("HitDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHitDate);
      this.columnHitScore = new DataColumn("HitScore", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHitScore);
      this.columnClearDate = new DataColumn("ClearDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClearDate);
      this.columnClearByUserGuid = new DataColumn("ClearByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClearByUserGuid);
      this.columnClearReason = new DataColumn("ClearReason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClearReason);
      this.columnOFACCleared = new DataColumn("OFACCleared", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOFACCleared);
      this.columnNotes = new DataColumn("Notes", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNotes);
      this.columnClearByUserName = new DataColumn("ClearByUserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClearByUserName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnEntityGUID,
        this.columnParentEntityGUID
      }, true));
      this.columnEntityGUID.AllowDBNull = false;
      this.columnParentEntityGUID.AllowDBNull = false;
      this.columnOfacTypeID.AllowDBNull = false;
      this.columnClearByUserName.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.OfacAdminRow NewOfacAdminRow()
    {
      return (dsOfacManagement.OfacAdminRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOfacManagement.OfacAdminRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsOfacManagement.OfacAdminRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitExpressions()
    {
      this.ClearByUserNameColumn.Expression = "Parent(Users_OfacAdmin).UserName";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OfacAdminRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.OfacAdminRowChangeEventHandler adminRowChangedEvent = this.OfacAdminRowChangedEvent;
      if (adminRowChangedEvent == null)
        return;
      adminRowChangedEvent((object) this, new dsOfacManagement.OfacAdminRowChangeEvent((dsOfacManagement.OfacAdminRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OfacAdminRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.OfacAdminRowChangeEventHandler rowChangingEvent = this.OfacAdminRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOfacManagement.OfacAdminRowChangeEvent((dsOfacManagement.OfacAdminRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OfacAdminRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.OfacAdminRowChangeEventHandler adminRowDeletedEvent = this.OfacAdminRowDeletedEvent;
      if (adminRowDeletedEvent == null)
        return;
      adminRowDeletedEvent((object) this, new dsOfacManagement.OfacAdminRowChangeEvent((dsOfacManagement.OfacAdminRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OfacAdminRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.OfacAdminRowChangeEventHandler rowDeletingEvent = this.OfacAdminRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOfacManagement.OfacAdminRowChangeEvent((dsOfacManagement.OfacAdminRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveOfacAdminRow(dsOfacManagement.OfacAdminRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsOfacManagement dsOfacManagement = new dsOfacManagement();
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
        FixedValue = dsOfacManagement.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (OfacAdminDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsOfacManagement.GetSchemaSerializable();
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

    public dsOfacManagement.OfacAdminRow FindByEntityGUIDNullableParentEntityGUID(
      Guid EntityGUID,
      Guid? ParentEntityGUID)
    {
      return (dsOfacManagement.OfacAdminRow) this.Rows.Find(new object[2]
      {
        (object) EntityGUID,
        (object) ParentEntityGUID ?? (object) DBNull.Value
      });
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class UsersDataTable : TypedTableBase<dsOfacManagement.UsersRow>
  {
    private DataColumn columnUserGUID;
    private DataColumn columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public UsersDataTable()
    {
      this.TableName = "Users";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal UsersDataTable(DataTable table)
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
    protected UsersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UserGUIDColumn => this.columnUserGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.UsersRow this[int index]
    {
      get => (dsOfacManagement.UsersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.UsersRowChangeEventHandler UsersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.UsersRowChangeEventHandler UsersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.UsersRowChangeEventHandler UsersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.UsersRowChangeEventHandler UsersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddUsersRow(dsOfacManagement.UsersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.UsersRow AddUsersRow(Guid UserGUID, string UserName)
    {
      dsOfacManagement.UsersRow row = (dsOfacManagement.UsersRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) UserGUID,
        (object) UserName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.UsersRow FindByUserGUID(Guid UserGUID)
    {
      return (dsOfacManagement.UsersRow) this.Rows.Find(new object[1]
      {
        (object) UserGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsOfacManagement.UsersDataTable usersDataTable = (dsOfacManagement.UsersDataTable) base.Clone();
      usersDataTable.InitVars();
      return (DataTable) usersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOfacManagement.UsersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnUserGUID = this.Columns["UserGUID"];
      this.columnUserName = this.Columns["UserName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnUserGUID = new DataColumn("UserGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUID);
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnUserGUID
      }, true));
      this.columnUserGUID.AllowDBNull = false;
      this.columnUserGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.UsersRow NewUsersRow() => (dsOfacManagement.UsersRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOfacManagement.UsersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsOfacManagement.UsersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UsersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.UsersRowChangeEventHandler usersRowChangedEvent = this.UsersRowChangedEvent;
      if (usersRowChangedEvent == null)
        return;
      usersRowChangedEvent((object) this, new dsOfacManagement.UsersRowChangeEvent((dsOfacManagement.UsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UsersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.UsersRowChangeEventHandler rowChangingEvent = this.UsersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOfacManagement.UsersRowChangeEvent((dsOfacManagement.UsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UsersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.UsersRowChangeEventHandler usersRowDeletedEvent = this.UsersRowDeletedEvent;
      if (usersRowDeletedEvent == null)
        return;
      usersRowDeletedEvent((object) this, new dsOfacManagement.UsersRowChangeEvent((dsOfacManagement.UsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UsersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.UsersRowChangeEventHandler rowDeletingEvent = this.UsersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOfacManagement.UsersRowChangeEvent((dsOfacManagement.UsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveUsersRow(dsOfacManagement.UsersRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsOfacManagement dsOfacManagement = new dsOfacManagement();
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
        FixedValue = dsOfacManagement.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (UsersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsOfacManagement.GetSchemaSerializable();
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
  public class ReasonsDataTable : TypedTableBase<dsOfacManagement.ReasonsRow>
  {
    private DataColumn columnClearReasonID;
    private DataColumn columnClearReason;
    private DataColumn columnSoftClear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public ReasonsDataTable()
    {
      this.TableName = "Reasons";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal ReasonsDataTable(DataTable table)
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
    protected ReasonsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClearReasonIDColumn => this.columnClearReasonID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClearReasonColumn => this.columnClearReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SoftClearColumn => this.columnSoftClear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.ReasonsRow this[int index]
    {
      get => (dsOfacManagement.ReasonsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.ReasonsRowChangeEventHandler ReasonsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.ReasonsRowChangeEventHandler ReasonsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.ReasonsRowChangeEventHandler ReasonsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.ReasonsRowChangeEventHandler ReasonsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddReasonsRow(dsOfacManagement.ReasonsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.ReasonsRow AddReasonsRow(
      int ClearReasonID,
      string ClearReason,
      bool SoftClear)
    {
      dsOfacManagement.ReasonsRow row = (dsOfacManagement.ReasonsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) ClearReasonID,
        (object) ClearReason,
        (object) SoftClear
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.ReasonsRow FindByClearReasonID(int ClearReasonID)
    {
      return (dsOfacManagement.ReasonsRow) this.Rows.Find(new object[1]
      {
        (object) ClearReasonID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsOfacManagement.ReasonsDataTable reasonsDataTable = (dsOfacManagement.ReasonsDataTable) base.Clone();
      reasonsDataTable.InitVars();
      return (DataTable) reasonsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOfacManagement.ReasonsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnClearReasonID = this.Columns["ClearReasonID"];
      this.columnClearReason = this.Columns["ClearReason"];
      this.columnSoftClear = this.Columns["SoftClear"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnClearReasonID = new DataColumn("ClearReasonID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClearReasonID);
      this.columnClearReason = new DataColumn("ClearReason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClearReason);
      this.columnSoftClear = new DataColumn("SoftClear", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSoftClear);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnClearReasonID
      }, true));
      this.columnClearReasonID.AllowDBNull = false;
      this.columnClearReasonID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.ReasonsRow NewReasonsRow()
    {
      return (dsOfacManagement.ReasonsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOfacManagement.ReasonsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsOfacManagement.ReasonsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReasonsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.ReasonsRowChangeEventHandler reasonsRowChangedEvent = this.ReasonsRowChangedEvent;
      if (reasonsRowChangedEvent == null)
        return;
      reasonsRowChangedEvent((object) this, new dsOfacManagement.ReasonsRowChangeEvent((dsOfacManagement.ReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReasonsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.ReasonsRowChangeEventHandler rowChangingEvent = this.ReasonsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOfacManagement.ReasonsRowChangeEvent((dsOfacManagement.ReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReasonsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.ReasonsRowChangeEventHandler reasonsRowDeletedEvent = this.ReasonsRowDeletedEvent;
      if (reasonsRowDeletedEvent == null)
        return;
      reasonsRowDeletedEvent((object) this, new dsOfacManagement.ReasonsRowChangeEvent((dsOfacManagement.ReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReasonsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.ReasonsRowChangeEventHandler rowDeletingEvent = this.ReasonsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOfacManagement.ReasonsRowChangeEvent((dsOfacManagement.ReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveReasonsRow(dsOfacManagement.ReasonsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsOfacManagement dsOfacManagement = new dsOfacManagement();
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
        FixedValue = dsOfacManagement.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ReasonsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsOfacManagement.GetSchemaSerializable();
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
  public class OfacSettingsDataTable : TypedTableBase<dsOfacManagement.OfacSettingsRow>
  {
    private DataColumn columnOfacTypeID;
    private DataColumn columnOfacName;
    private DataColumn columnSortOrder;
    private DataColumn columnServiceURL;
    private DataColumn columnServiceUsername;
    private DataColumn columnServicePassword;
    private DataColumn columnServiceConfiguration;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public OfacSettingsDataTable()
    {
      this.TableName = "OfacSettings";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal OfacSettingsDataTable(DataTable table)
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
    protected OfacSettingsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OfacTypeIDColumn => this.columnOfacTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OfacNameColumn => this.columnOfacName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SortOrderColumn => this.columnSortOrder;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ServiceURLColumn => this.columnServiceURL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ServiceUsernameColumn => this.columnServiceUsername;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ServicePasswordColumn => this.columnServicePassword;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ServiceConfigurationColumn => this.columnServiceConfiguration;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.OfacSettingsRow this[int index]
    {
      get => (dsOfacManagement.OfacSettingsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.OfacSettingsRowChangeEventHandler OfacSettingsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.OfacSettingsRowChangeEventHandler OfacSettingsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.OfacSettingsRowChangeEventHandler OfacSettingsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.OfacSettingsRowChangeEventHandler OfacSettingsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddOfacSettingsRow(dsOfacManagement.OfacSettingsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.OfacSettingsRow AddOfacSettingsRow(
      int OfacTypeID,
      string OfacName,
      int SortOrder,
      string ServiceURL,
      string ServiceUsername,
      string ServicePassword,
      string ServiceConfiguration)
    {
      dsOfacManagement.OfacSettingsRow row = (dsOfacManagement.OfacSettingsRow) this.NewRow();
      object[] objArray = new object[7]
      {
        (object) OfacTypeID,
        (object) OfacName,
        (object) SortOrder,
        (object) ServiceURL,
        (object) ServiceUsername,
        (object) ServicePassword,
        (object) ServiceConfiguration
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.OfacSettingsRow FindByOfacTypeID(int OfacTypeID)
    {
      return (dsOfacManagement.OfacSettingsRow) this.Rows.Find(new object[1]
      {
        (object) OfacTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsOfacManagement.OfacSettingsDataTable settingsDataTable = (dsOfacManagement.OfacSettingsDataTable) base.Clone();
      settingsDataTable.InitVars();
      return (DataTable) settingsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOfacManagement.OfacSettingsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnOfacTypeID = this.Columns["OfacTypeID"];
      this.columnOfacName = this.Columns["OfacName"];
      this.columnSortOrder = this.Columns["SortOrder"];
      this.columnServiceURL = this.Columns["ServiceURL"];
      this.columnServiceUsername = this.Columns["ServiceUsername"];
      this.columnServicePassword = this.Columns["ServicePassword"];
      this.columnServiceConfiguration = this.Columns["ServiceConfiguration"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnOfacTypeID = new DataColumn("OfacTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfacTypeID);
      this.columnOfacName = new DataColumn("OfacName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfacName);
      this.columnSortOrder = new DataColumn("SortOrder", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSortOrder);
      this.columnServiceURL = new DataColumn("ServiceURL", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnServiceURL);
      this.columnServiceUsername = new DataColumn("ServiceUsername", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnServiceUsername);
      this.columnServicePassword = new DataColumn("ServicePassword", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnServicePassword);
      this.columnServiceConfiguration = new DataColumn("ServiceConfiguration", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnServiceConfiguration);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnOfacTypeID
      }, true));
      this.columnOfacTypeID.AllowDBNull = false;
      this.columnOfacTypeID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.OfacSettingsRow NewOfacSettingsRow()
    {
      return (dsOfacManagement.OfacSettingsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOfacManagement.OfacSettingsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsOfacManagement.OfacSettingsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OfacSettingsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.OfacSettingsRowChangeEventHandler settingsRowChangedEvent = this.OfacSettingsRowChangedEvent;
      if (settingsRowChangedEvent == null)
        return;
      settingsRowChangedEvent((object) this, new dsOfacManagement.OfacSettingsRowChangeEvent((dsOfacManagement.OfacSettingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OfacSettingsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.OfacSettingsRowChangeEventHandler rowChangingEvent = this.OfacSettingsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOfacManagement.OfacSettingsRowChangeEvent((dsOfacManagement.OfacSettingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OfacSettingsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.OfacSettingsRowChangeEventHandler settingsRowDeletedEvent = this.OfacSettingsRowDeletedEvent;
      if (settingsRowDeletedEvent == null)
        return;
      settingsRowDeletedEvent((object) this, new dsOfacManagement.OfacSettingsRowChangeEvent((dsOfacManagement.OfacSettingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OfacSettingsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.OfacSettingsRowChangeEventHandler rowDeletingEvent = this.OfacSettingsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOfacManagement.OfacSettingsRowChangeEvent((dsOfacManagement.OfacSettingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveOfacSettingsRow(dsOfacManagement.OfacSettingsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsOfacManagement dsOfacManagement = new dsOfacManagement();
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
        FixedValue = dsOfacManagement.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (OfacSettingsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsOfacManagement.GetSchemaSerializable();
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
  public class SettingConfigsDataTable : TypedTableBase<dsOfacManagement.SettingConfigsRow>
  {
    private DataColumn columnOfacTypeID;
    private DataColumn columnKey;
    private DataColumn columnValue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public SettingConfigsDataTable()
    {
      this.TableName = "SettingConfigs";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal SettingConfigsDataTable(DataTable table)
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
    protected SettingConfigsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OfacTypeIDColumn => this.columnOfacTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn KeyColumn => this.columnKey;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ValueColumn => this.columnValue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.SettingConfigsRow this[int index]
    {
      get => (dsOfacManagement.SettingConfigsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.SettingConfigsRowChangeEventHandler SettingConfigsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.SettingConfigsRowChangeEventHandler SettingConfigsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.SettingConfigsRowChangeEventHandler SettingConfigsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.SettingConfigsRowChangeEventHandler SettingConfigsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddSettingConfigsRow(dsOfacManagement.SettingConfigsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.SettingConfigsRow AddSettingConfigsRow(
      dsOfacManagement.OfacSettingsRow parentOfacSettingsRowByOfacSettings_SettingConfigs,
      string Key,
      string Value)
    {
      dsOfacManagement.SettingConfigsRow row = (dsOfacManagement.SettingConfigsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) Key,
        (object) Value
      };
      if (parentOfacSettingsRowByOfacSettings_SettingConfigs != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parentOfacSettingsRowByOfacSettings_SettingConfigs[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsOfacManagement.SettingConfigsDataTable configsDataTable = (dsOfacManagement.SettingConfigsDataTable) base.Clone();
      configsDataTable.InitVars();
      return (DataTable) configsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOfacManagement.SettingConfigsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnOfacTypeID = this.Columns["OfacTypeID"];
      this.columnKey = this.Columns["Key"];
      this.columnValue = this.Columns["Value"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnOfacTypeID = new DataColumn("OfacTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfacTypeID);
      this.columnKey = new DataColumn("Key", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnKey);
      this.columnValue = new DataColumn("Value", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnValue);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.SettingConfigsRow NewSettingConfigsRow()
    {
      return (dsOfacManagement.SettingConfigsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOfacManagement.SettingConfigsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsOfacManagement.SettingConfigsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SettingConfigsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.SettingConfigsRowChangeEventHandler configsRowChangedEvent = this.SettingConfigsRowChangedEvent;
      if (configsRowChangedEvent == null)
        return;
      configsRowChangedEvent((object) this, new dsOfacManagement.SettingConfigsRowChangeEvent((dsOfacManagement.SettingConfigsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SettingConfigsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.SettingConfigsRowChangeEventHandler rowChangingEvent = this.SettingConfigsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOfacManagement.SettingConfigsRowChangeEvent((dsOfacManagement.SettingConfigsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SettingConfigsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.SettingConfigsRowChangeEventHandler configsRowDeletedEvent = this.SettingConfigsRowDeletedEvent;
      if (configsRowDeletedEvent == null)
        return;
      configsRowDeletedEvent((object) this, new dsOfacManagement.SettingConfigsRowChangeEvent((dsOfacManagement.SettingConfigsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SettingConfigsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.SettingConfigsRowChangeEventHandler rowDeletingEvent = this.SettingConfigsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOfacManagement.SettingConfigsRowChangeEvent((dsOfacManagement.SettingConfigsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveSettingConfigsRow(dsOfacManagement.SettingConfigsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsOfacManagement dsOfacManagement = new dsOfacManagement();
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
        FixedValue = dsOfacManagement.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (SettingConfigsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsOfacManagement.GetSchemaSerializable();
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
  public class HitLogDataTable : TypedTableBase<dsOfacManagement.HitLogRow>
  {
    private DataColumn columnClearLogID;
    private DataColumn columnEntityGUID;
    private DataColumn columnParentEntityGUID;
    private DataColumn columnLogDate;
    private DataColumn columnUserName;
    private DataColumn columnOFACScore;
    private DataColumn columnClearDate;
    private DataColumn columnClearReason;
    private DataColumn columnAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public HitLogDataTable()
    {
      this.TableName = "HitLog";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal HitLogDataTable(DataTable table)
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
    protected HitLogDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClearLogIDColumn => this.columnClearLogID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EntityGUIDColumn => this.columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ParentEntityGUIDColumn => this.columnParentEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LogDateColumn => this.columnLogDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OFACScoreColumn => this.columnOFACScore;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClearDateColumn => this.columnClearDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClearReasonColumn => this.columnClearReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ActionColumn => this.columnAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.HitLogRow this[int index]
    {
      get => (dsOfacManagement.HitLogRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.HitLogRowChangeEventHandler HitLogRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.HitLogRowChangeEventHandler HitLogRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.HitLogRowChangeEventHandler HitLogRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.HitLogRowChangeEventHandler HitLogRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddHitLogRow(dsOfacManagement.HitLogRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.HitLogRow AddHitLogRow(
      int ClearLogID,
      Guid EntityGUID,
      Guid ParentEntityGUID,
      DateTime LogDate,
      string UserName,
      int OFACScore,
      DateTime ClearDate,
      string ClearReason,
      string Action)
    {
      dsOfacManagement.HitLogRow row = (dsOfacManagement.HitLogRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) ClearLogID,
        (object) EntityGUID,
        (object) ParentEntityGUID,
        (object) LogDate,
        (object) UserName,
        (object) OFACScore,
        (object) ClearDate,
        (object) ClearReason,
        (object) Action
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.HitLogRow FindByClearLogID(int ClearLogID)
    {
      return (dsOfacManagement.HitLogRow) this.Rows.Find(new object[1]
      {
        (object) ClearLogID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsOfacManagement.HitLogDataTable hitLogDataTable = (dsOfacManagement.HitLogDataTable) base.Clone();
      hitLogDataTable.InitVars();
      return (DataTable) hitLogDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOfacManagement.HitLogDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnClearLogID = this.Columns["ClearLogID"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
      this.columnParentEntityGUID = this.Columns["ParentEntityGUID"];
      this.columnLogDate = this.Columns["LogDate"];
      this.columnUserName = this.Columns["UserName"];
      this.columnOFACScore = this.Columns["OFACScore"];
      this.columnClearDate = this.Columns["ClearDate"];
      this.columnClearReason = this.Columns["ClearReason"];
      this.columnAction = this.Columns["Action"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnClearLogID = new DataColumn("ClearLogID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClearLogID);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.columnParentEntityGUID = new DataColumn("ParentEntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParentEntityGUID);
      this.columnLogDate = new DataColumn("LogDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLogDate);
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.columnOFACScore = new DataColumn("OFACScore", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOFACScore);
      this.columnClearDate = new DataColumn("ClearDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClearDate);
      this.columnClearReason = new DataColumn("ClearReason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClearReason);
      this.columnAction = new DataColumn("Action", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAction);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnClearLogID
      }, true));
      this.columnClearLogID.AllowDBNull = false;
      this.columnClearLogID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.HitLogRow NewHitLogRow() => (dsOfacManagement.HitLogRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOfacManagement.HitLogRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsOfacManagement.HitLogRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.HitLogRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.HitLogRowChangeEventHandler logRowChangedEvent = this.HitLogRowChangedEvent;
      if (logRowChangedEvent == null)
        return;
      logRowChangedEvent((object) this, new dsOfacManagement.HitLogRowChangeEvent((dsOfacManagement.HitLogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.HitLogRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.HitLogRowChangeEventHandler rowChangingEvent = this.HitLogRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOfacManagement.HitLogRowChangeEvent((dsOfacManagement.HitLogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.HitLogRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.HitLogRowChangeEventHandler logRowDeletedEvent = this.HitLogRowDeletedEvent;
      if (logRowDeletedEvent == null)
        return;
      logRowDeletedEvent((object) this, new dsOfacManagement.HitLogRowChangeEvent((dsOfacManagement.HitLogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.HitLogRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.HitLogRowChangeEventHandler rowDeletingEvent = this.HitLogRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOfacManagement.HitLogRowChangeEvent((dsOfacManagement.HitLogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveHitLogRow(dsOfacManagement.HitLogRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsOfacManagement dsOfacManagement = new dsOfacManagement();
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
        FixedValue = dsOfacManagement.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (HitLogDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsOfacManagement.GetSchemaSerializable();
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
  public class SearchLogDataTable : TypedTableBase<dsOfacManagement.SearchLogRow>
  {
    private DataColumn columnOfacLogID;
    private DataColumn columnEntityGUID;
    private DataColumn columnParentEntityGUID;
    private DataColumn columnLogDate;
    private DataColumn columnEntityName;
    private DataColumn columnReturnScore;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public SearchLogDataTable()
    {
      this.TableName = "SearchLog";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal SearchLogDataTable(DataTable table)
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
    protected SearchLogDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OfacLogIDColumn => this.columnOfacLogID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EntityGUIDColumn => this.columnEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ParentEntityGUIDColumn => this.columnParentEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LogDateColumn => this.columnLogDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EntityNameColumn => this.columnEntityName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ReturnScoreColumn => this.columnReturnScore;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.SearchLogRow this[int index]
    {
      get => (dsOfacManagement.SearchLogRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.SearchLogRowChangeEventHandler SearchLogRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.SearchLogRowChangeEventHandler SearchLogRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.SearchLogRowChangeEventHandler SearchLogRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfacManagement.SearchLogRowChangeEventHandler SearchLogRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddSearchLogRow(dsOfacManagement.SearchLogRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.SearchLogRow AddSearchLogRow(
      int OfacLogID,
      Guid EntityGUID,
      Guid ParentEntityGUID,
      DateTime LogDate,
      string EntityName,
      string ReturnScore)
    {
      dsOfacManagement.SearchLogRow row = (dsOfacManagement.SearchLogRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) OfacLogID,
        (object) EntityGUID,
        (object) ParentEntityGUID,
        (object) LogDate,
        (object) EntityName,
        (object) ReturnScore
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.SearchLogRow FindByOfacLogID(int OfacLogID)
    {
      return (dsOfacManagement.SearchLogRow) this.Rows.Find(new object[1]
      {
        (object) OfacLogID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsOfacManagement.SearchLogDataTable searchLogDataTable = (dsOfacManagement.SearchLogDataTable) base.Clone();
      searchLogDataTable.InitVars();
      return (DataTable) searchLogDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOfacManagement.SearchLogDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnOfacLogID = this.Columns["OfacLogID"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
      this.columnParentEntityGUID = this.Columns["ParentEntityGUID"];
      this.columnLogDate = this.Columns["LogDate"];
      this.columnEntityName = this.Columns["EntityName"];
      this.columnReturnScore = this.Columns["ReturnScore"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnOfacLogID = new DataColumn("OfacLogID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfacLogID);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.columnParentEntityGUID = new DataColumn("ParentEntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParentEntityGUID);
      this.columnLogDate = new DataColumn("LogDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLogDate);
      this.columnEntityName = new DataColumn("EntityName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityName);
      this.columnReturnScore = new DataColumn("ReturnScore", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReturnScore);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnOfacLogID
      }, true));
      this.columnOfacLogID.AllowDBNull = false;
      this.columnOfacLogID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.SearchLogRow NewSearchLogRow()
    {
      return (dsOfacManagement.SearchLogRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOfacManagement.SearchLogRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsOfacManagement.SearchLogRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SearchLogRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.SearchLogRowChangeEventHandler logRowChangedEvent = this.SearchLogRowChangedEvent;
      if (logRowChangedEvent == null)
        return;
      logRowChangedEvent((object) this, new dsOfacManagement.SearchLogRowChangeEvent((dsOfacManagement.SearchLogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SearchLogRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.SearchLogRowChangeEventHandler rowChangingEvent = this.SearchLogRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOfacManagement.SearchLogRowChangeEvent((dsOfacManagement.SearchLogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SearchLogRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.SearchLogRowChangeEventHandler logRowDeletedEvent = this.SearchLogRowDeletedEvent;
      if (logRowDeletedEvent == null)
        return;
      logRowDeletedEvent((object) this, new dsOfacManagement.SearchLogRowChangeEvent((dsOfacManagement.SearchLogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SearchLogRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacManagement.SearchLogRowChangeEventHandler rowDeletingEvent = this.SearchLogRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOfacManagement.SearchLogRowChangeEvent((dsOfacManagement.SearchLogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveSearchLogRow(dsOfacManagement.SearchLogRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsOfacManagement dsOfacManagement = new dsOfacManagement();
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
        FixedValue = dsOfacManagement.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (SearchLogDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsOfacManagement.GetSchemaSerializable();
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

  public class OfacAdminRow : DataRow
  {
    private dsOfacManagement.OfacAdminDataTable tableOfacAdmin;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal OfacAdminRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOfacAdmin = (dsOfacManagement.OfacAdminDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableOfacAdmin.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableOfacAdmin.EntityGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ParentEntityGUID
    {
      get
      {
        object obj = this[this.tableOfacAdmin.ParentEntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableOfacAdmin.ParentEntityGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int OfacTypeID
    {
      get => Conversions.ToInteger(this[this.tableOfacAdmin.OfacTypeIDColumn]);
      set => this[this.tableOfacAdmin.OfacTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EntityName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOfacAdmin.EntityNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EntityName' in table 'OfacAdmin' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacAdmin.EntityNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EntityType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOfacAdmin.EntityTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EntityType' in table 'OfacAdmin' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacAdmin.EntityTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string RecreateTypeName
    {
      get
      {
        return !this.IsRecreateTypeNameNull() ? Conversions.ToString(this[this.tableOfacAdmin.RecreateTypeNameColumn]) : (string) null;
      }
      set => this[this.tableOfacAdmin.RecreateTypeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime LogDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOfacAdmin.LogDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LogDate' in table 'OfacAdmin' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacAdmin.LogDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SearchCriteria
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOfacAdmin.SearchCriteriaColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SearchCriteria' in table 'OfacAdmin' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacAdmin.SearchCriteriaColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string OfacXml
    {
      get
      {
        return !this.IsOfacXmlNull() ? Conversions.ToString(this[this.tableOfacAdmin.OfacXmlColumn]) : (string) null;
      }
      set => this[this.tableOfacAdmin.OfacXmlColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ReturnCode
    {
      get
      {
        return !this.IsReturnCodeNull() ? Conversions.ToString(this[this.tableOfacAdmin.ReturnCodeColumn]) : (string) null;
      }
      set => this[this.tableOfacAdmin.ReturnCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime HitDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOfacAdmin.HitDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'HitDate' in table 'OfacAdmin' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacAdmin.HitDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int HitScore
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOfacAdmin.HitScoreColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'HitScore' in table 'OfacAdmin' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacAdmin.HitScoreColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime ClearDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOfacAdmin.ClearDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClearDate' in table 'OfacAdmin' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacAdmin.ClearDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ClearByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tableOfacAdmin.ClearByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClearByUserGuid' in table 'OfacAdmin' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacAdmin.ClearByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ClearReason
    {
      get
      {
        return !this.IsClearReasonNull() ? Conversions.ToString(this[this.tableOfacAdmin.ClearReasonColumn]) : (string) null;
      }
      set => this[this.tableOfacAdmin.ClearReasonColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool OFACCleared
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableOfacAdmin.OFACClearedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OFACCleared' in table 'OfacAdmin' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacAdmin.OFACClearedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Notes
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOfacAdmin.NotesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Notes' in table 'OfacAdmin' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacAdmin.NotesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ClearByUserName
    {
      get
      {
        return !this.IsClearByUserNameNull() ? Conversions.ToString(this[this.tableOfacAdmin.ClearByUserNameColumn]) : (string) null;
      }
      set => this[this.tableOfacAdmin.ClearByUserNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.UsersRow UsersRow
    {
      get
      {
        return (dsOfacManagement.UsersRow) this.GetParentRow(this.Table.ParentRelations["Users_OfacAdmin"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["Users_OfacAdmin"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEntityNameNull() => this.IsNull(this.tableOfacAdmin.EntityNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEntityNameNull()
    {
      this[this.tableOfacAdmin.EntityNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEntityTypeNull() => this.IsNull(this.tableOfacAdmin.EntityTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEntityTypeNull()
    {
      this[this.tableOfacAdmin.EntityTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRecreateTypeNameNull() => this.IsNull(this.tableOfacAdmin.RecreateTypeNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRecreateTypeNameNull()
    {
      this[this.tableOfacAdmin.RecreateTypeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLogDateNull() => this.IsNull(this.tableOfacAdmin.LogDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLogDateNull()
    {
      this[this.tableOfacAdmin.LogDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSearchCriteriaNull() => this.IsNull(this.tableOfacAdmin.SearchCriteriaColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSearchCriteriaNull()
    {
      this[this.tableOfacAdmin.SearchCriteriaColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOfacXmlNull() => this.IsNull(this.tableOfacAdmin.OfacXmlColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOfacXmlNull()
    {
      this[this.tableOfacAdmin.OfacXmlColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsReturnCodeNull() => this.IsNull(this.tableOfacAdmin.ReturnCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetReturnCodeNull()
    {
      this[this.tableOfacAdmin.ReturnCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsHitDateNull() => this.IsNull(this.tableOfacAdmin.HitDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetHitDateNull()
    {
      this[this.tableOfacAdmin.HitDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsHitScoreNull() => this.IsNull(this.tableOfacAdmin.HitScoreColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetHitScoreNull()
    {
      this[this.tableOfacAdmin.HitScoreColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClearDateNull() => this.IsNull(this.tableOfacAdmin.ClearDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClearDateNull()
    {
      this[this.tableOfacAdmin.ClearDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClearByUserGuidNull() => this.IsNull(this.tableOfacAdmin.ClearByUserGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClearByUserGuidNull()
    {
      this[this.tableOfacAdmin.ClearByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClearReasonNull() => this.IsNull(this.tableOfacAdmin.ClearReasonColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClearReasonNull()
    {
      this[this.tableOfacAdmin.ClearReasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOFACClearedNull() => this.IsNull(this.tableOfacAdmin.OFACClearedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOFACClearedNull()
    {
      this[this.tableOfacAdmin.OFACClearedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNotesNull() => this.IsNull(this.tableOfacAdmin.NotesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNotesNull()
    {
      this[this.tableOfacAdmin.NotesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClearByUserNameNull() => this.IsNull(this.tableOfacAdmin.ClearByUserNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClearByUserNameNull()
    {
      this[this.tableOfacAdmin.ClearByUserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.HitLogRow[] GetHitLogRows()
    {
      return this.Table.ChildRelations["OfacAdmin_HitLog"] != null ? (dsOfacManagement.HitLogRow[]) this.GetChildRows(this.Table.ChildRelations["OfacAdmin_HitLog"]) : new dsOfacManagement.HitLogRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.SearchLogRow[] GetSearchLogRows()
    {
      return this.Table.ChildRelations["OfacAdmin_SearchLog"] != null ? (dsOfacManagement.SearchLogRow[]) this.GetChildRows(this.Table.ChildRelations["OfacAdmin_SearchLog"]) : new dsOfacManagement.SearchLogRow[0];
    }

    public Guid? NullableParentEntityGuid
    {
      get => this.Field<Guid?>(this.tableOfacAdmin.ParentEntityGUIDColumn);
    }

    public override bool Equals(object obj)
    {
      bool flag;
      if (!(obj is dsOfacManagement.OfacAdminRow))
      {
        flag = false;
      }
      else
      {
        dsOfacManagement.OfacAdminRow ofacAdminRow = (dsOfacManagement.OfacAdminRow) obj;
        flag = ofacAdminRow.EntityGUID.Equals(this.EntityGUID) && ofacAdminRow.NullableParentEntityGuid.Equals((object) this.NullableParentEntityGuid);
      }
      return flag;
    }
  }

  public class UsersRow : DataRow
  {
    private dsOfacManagement.UsersDataTable tableUsers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal UsersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableUsers = (dsOfacManagement.UsersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid UserGUID
    {
      get
      {
        object obj = this[this.tableUsers.UserGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableUsers.UserGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string UserName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUsers.UserNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserName' in table 'Users' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUsers.UserNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUserNameNull() => this.IsNull(this.tableUsers.UserNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUserNameNull()
    {
      this[this.tableUsers.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.OfacAdminRow[] GetOfacAdminRows()
    {
      return this.Table.ChildRelations["Users_OfacAdmin"] != null ? (dsOfacManagement.OfacAdminRow[]) this.GetChildRows(this.Table.ChildRelations["Users_OfacAdmin"]) : new dsOfacManagement.OfacAdminRow[0];
    }
  }

  public class ReasonsRow : DataRow
  {
    private dsOfacManagement.ReasonsDataTable tableReasons;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal ReasonsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableReasons = (dsOfacManagement.ReasonsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ClearReasonID
    {
      get => Conversions.ToInteger(this[this.tableReasons.ClearReasonIDColumn]);
      set => this[this.tableReasons.ClearReasonIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ClearReason
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableReasons.ClearReasonColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClearReason' in table 'Reasons' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReasons.ClearReasonColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool SoftClear
    {
      get
      {
        return !this.IsSoftClearNull() && Conversions.ToBoolean(this[this.tableReasons.SoftClearColumn]);
      }
      set => this[this.tableReasons.SoftClearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClearReasonNull() => this.IsNull(this.tableReasons.ClearReasonColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClearReasonNull()
    {
      this[this.tableReasons.ClearReasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSoftClearNull() => this.IsNull(this.tableReasons.SoftClearColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSoftClearNull()
    {
      this[this.tableReasons.SoftClearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class OfacSettingsRow : DataRow
  {
    private dsOfacManagement.OfacSettingsDataTable tableOfacSettings;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal OfacSettingsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOfacSettings = (dsOfacManagement.OfacSettingsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int OfacTypeID
    {
      get => Conversions.ToInteger(this[this.tableOfacSettings.OfacTypeIDColumn]);
      set => this[this.tableOfacSettings.OfacTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string OfacName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOfacSettings.OfacNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfacName' in table 'OfacSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacSettings.OfacNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int SortOrder
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOfacSettings.SortOrderColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SortOrder' in table 'OfacSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacSettings.SortOrderColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ServiceURL
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOfacSettings.ServiceURLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ServiceURL' in table 'OfacSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacSettings.ServiceURLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ServiceUsername
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOfacSettings.ServiceUsernameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ServiceUsername' in table 'OfacSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacSettings.ServiceUsernameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ServicePassword
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOfacSettings.ServicePasswordColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ServicePassword' in table 'OfacSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacSettings.ServicePasswordColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ServiceConfiguration
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOfacSettings.ServiceConfigurationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ServiceConfiguration' in table 'OfacSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfacSettings.ServiceConfigurationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOfacNameNull() => this.IsNull(this.tableOfacSettings.OfacNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOfacNameNull()
    {
      this[this.tableOfacSettings.OfacNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSortOrderNull() => this.IsNull(this.tableOfacSettings.SortOrderColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSortOrderNull()
    {
      this[this.tableOfacSettings.SortOrderColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsServiceURLNull() => this.IsNull(this.tableOfacSettings.ServiceURLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetServiceURLNull()
    {
      this[this.tableOfacSettings.ServiceURLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsServiceUsernameNull()
    {
      return this.IsNull(this.tableOfacSettings.ServiceUsernameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetServiceUsernameNull()
    {
      this[this.tableOfacSettings.ServiceUsernameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsServicePasswordNull()
    {
      return this.IsNull(this.tableOfacSettings.ServicePasswordColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetServicePasswordNull()
    {
      this[this.tableOfacSettings.ServicePasswordColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsServiceConfigurationNull()
    {
      return this.IsNull(this.tableOfacSettings.ServiceConfigurationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetServiceConfigurationNull()
    {
      this[this.tableOfacSettings.ServiceConfigurationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.SettingConfigsRow[] GetSettingConfigsRows()
    {
      return this.Table.ChildRelations["OfacSettings_SettingConfigs"] != null ? (dsOfacManagement.SettingConfigsRow[]) this.GetChildRows(this.Table.ChildRelations["OfacSettings_SettingConfigs"]) : new dsOfacManagement.SettingConfigsRow[0];
    }
  }

  public class SettingConfigsRow : DataRow
  {
    private dsOfacManagement.SettingConfigsDataTable tableSettingConfigs;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal SettingConfigsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableSettingConfigs = (dsOfacManagement.SettingConfigsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int OfacTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableSettingConfigs.OfacTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfacTypeID' in table 'SettingConfigs' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettingConfigs.OfacTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Key
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSettingConfigs.KeyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Key' in table 'SettingConfigs' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettingConfigs.KeyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Value
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSettingConfigs.ValueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Value' in table 'SettingConfigs' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettingConfigs.ValueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.OfacSettingsRow OfacSettingsRow
    {
      get
      {
        return (dsOfacManagement.OfacSettingsRow) this.GetParentRow(this.Table.ParentRelations["OfacSettings_SettingConfigs"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["OfacSettings_SettingConfigs"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOfacTypeIDNull() => this.IsNull(this.tableSettingConfigs.OfacTypeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOfacTypeIDNull()
    {
      this[this.tableSettingConfigs.OfacTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsKeyNull() => this.IsNull(this.tableSettingConfigs.KeyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetKeyNull()
    {
      this[this.tableSettingConfigs.KeyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsValueNull() => this.IsNull(this.tableSettingConfigs.ValueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetValueNull()
    {
      this[this.tableSettingConfigs.ValueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class HitLogRow : DataRow
  {
    private dsOfacManagement.HitLogDataTable tableHitLog;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal HitLogRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableHitLog = (dsOfacManagement.HitLogDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ClearLogID
    {
      get => Conversions.ToInteger(this[this.tableHitLog.ClearLogIDColumn]);
      set => this[this.tableHitLog.ClearLogIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid EntityGUID
    {
      get
      {
        try
        {
          object obj = this[this.tableHitLog.EntityGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EntityGUID' in table 'HitLog' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableHitLog.EntityGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ParentEntityGUID
    {
      get
      {
        try
        {
          object obj = this[this.tableHitLog.ParentEntityGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ParentEntityGUID' in table 'HitLog' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableHitLog.ParentEntityGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime LogDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableHitLog.LogDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LogDate' in table 'HitLog' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableHitLog.LogDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string UserName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableHitLog.UserNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserName' in table 'HitLog' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableHitLog.UserNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int OFACScore
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableHitLog.OFACScoreColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OFACScore' in table 'HitLog' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableHitLog.OFACScoreColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime ClearDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableHitLog.ClearDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClearDate' in table 'HitLog' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableHitLog.ClearDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ClearReason
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableHitLog.ClearReasonColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClearReason' in table 'HitLog' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableHitLog.ClearReasonColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Action
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableHitLog.ActionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Action' in table 'HitLog' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableHitLog.ActionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.OfacAdminRow OfacAdminRowParent
    {
      get
      {
        return (dsOfacManagement.OfacAdminRow) this.GetParentRow(this.Table.ParentRelations["OfacAdmin_HitLog"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["OfacAdmin_HitLog"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEntityGUIDNull() => this.IsNull(this.tableHitLog.EntityGUIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEntityGUIDNull()
    {
      this[this.tableHitLog.EntityGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsParentEntityGUIDNull() => this.IsNull(this.tableHitLog.ParentEntityGUIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetParentEntityGUIDNull()
    {
      this[this.tableHitLog.ParentEntityGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLogDateNull() => this.IsNull(this.tableHitLog.LogDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLogDateNull()
    {
      this[this.tableHitLog.LogDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUserNameNull() => this.IsNull(this.tableHitLog.UserNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUserNameNull()
    {
      this[this.tableHitLog.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOFACScoreNull() => this.IsNull(this.tableHitLog.OFACScoreColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOFACScoreNull()
    {
      this[this.tableHitLog.OFACScoreColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClearDateNull() => this.IsNull(this.tableHitLog.ClearDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClearDateNull()
    {
      this[this.tableHitLog.ClearDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClearReasonNull() => this.IsNull(this.tableHitLog.ClearReasonColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClearReasonNull()
    {
      this[this.tableHitLog.ClearReasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsActionNull() => this.IsNull(this.tableHitLog.ActionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetActionNull()
    {
      this[this.tableHitLog.ActionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class SearchLogRow : DataRow
  {
    private dsOfacManagement.SearchLogDataTable tableSearchLog;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal SearchLogRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableSearchLog = (dsOfacManagement.SearchLogDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int OfacLogID
    {
      get => Conversions.ToInteger(this[this.tableSearchLog.OfacLogIDColumn]);
      set => this[this.tableSearchLog.OfacLogIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid EntityGUID
    {
      get
      {
        try
        {
          object obj = this[this.tableSearchLog.EntityGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EntityGUID' in table 'SearchLog' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSearchLog.EntityGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ParentEntityGUID
    {
      get
      {
        try
        {
          object obj = this[this.tableSearchLog.ParentEntityGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ParentEntityGUID' in table 'SearchLog' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSearchLog.ParentEntityGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime LogDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableSearchLog.LogDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LogDate' in table 'SearchLog' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSearchLog.LogDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EntityName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSearchLog.EntityNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EntityName' in table 'SearchLog' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSearchLog.EntityNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ReturnScore
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSearchLog.ReturnScoreColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ReturnScore' in table 'SearchLog' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSearchLog.ReturnScoreColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.OfacAdminRow OfacAdminRowParent
    {
      get
      {
        return (dsOfacManagement.OfacAdminRow) this.GetParentRow(this.Table.ParentRelations["OfacAdmin_SearchLog"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["OfacAdmin_SearchLog"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEntityGUIDNull() => this.IsNull(this.tableSearchLog.EntityGUIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEntityGUIDNull()
    {
      this[this.tableSearchLog.EntityGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsParentEntityGUIDNull() => this.IsNull(this.tableSearchLog.ParentEntityGUIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetParentEntityGUIDNull()
    {
      this[this.tableSearchLog.ParentEntityGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLogDateNull() => this.IsNull(this.tableSearchLog.LogDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLogDateNull()
    {
      this[this.tableSearchLog.LogDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEntityNameNull() => this.IsNull(this.tableSearchLog.EntityNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEntityNameNull()
    {
      this[this.tableSearchLog.EntityNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsReturnScoreNull() => this.IsNull(this.tableSearchLog.ReturnScoreColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetReturnScoreNull()
    {
      this[this.tableSearchLog.ReturnScoreColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class OfacAdminRowChangeEvent : EventArgs
  {
    private dsOfacManagement.OfacAdminRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public OfacAdminRowChangeEvent(dsOfacManagement.OfacAdminRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.OfacAdminRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class UsersRowChangeEvent : EventArgs
  {
    private dsOfacManagement.UsersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public UsersRowChangeEvent(dsOfacManagement.UsersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.UsersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class ReasonsRowChangeEvent : EventArgs
  {
    private dsOfacManagement.ReasonsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public ReasonsRowChangeEvent(dsOfacManagement.ReasonsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.ReasonsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class OfacSettingsRowChangeEvent : EventArgs
  {
    private dsOfacManagement.OfacSettingsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public OfacSettingsRowChangeEvent(dsOfacManagement.OfacSettingsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.OfacSettingsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class SettingConfigsRowChangeEvent : EventArgs
  {
    private dsOfacManagement.SettingConfigsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public SettingConfigsRowChangeEvent(
      dsOfacManagement.SettingConfigsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.SettingConfigsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class HitLogRowChangeEvent : EventArgs
  {
    private dsOfacManagement.HitLogRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public HitLogRowChangeEvent(dsOfacManagement.HitLogRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.HitLogRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class SearchLogRowChangeEvent : EventArgs
  {
    private dsOfacManagement.SearchLogRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public SearchLogRowChangeEvent(dsOfacManagement.SearchLogRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfacManagement.SearchLogRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
