// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Commissions.dsPolicyCommissions
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
namespace MGASystems.IMS.Policies.Commissions;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPolicyCommissions")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPolicyCommissions : DataSet
{
  private dsPolicyCommissions.lstEntityTypesDataTable tablelstEntityTypes;
  private dsPolicyCommissions.ChartDataTable tableChart;
  private dsPolicyCommissions.lstCommissionTypesDataTable tablelstCommissionTypes;
  private dsPolicyCommissions.ViewDataTable tableView;
  private dsPolicyCommissions.tblPolicyCommissionsDataTable tabletblPolicyCommissions;
  private dsPolicyCommissions.tblFin_PolicyChargesDataTable tabletblFin_PolicyCharges;
  private DataRelation relationtblFin_PolicyChargestblPolicyCommissions;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsPolicyCommissions()
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
  protected dsPolicyCommissions(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstEntityTypes)] != null)
          base.Tables.Add((DataTable) new dsPolicyCommissions.lstEntityTypesDataTable(dataSet.Tables[nameof (lstEntityTypes)]));
        if (dataSet.Tables[nameof (Chart)] != null)
          base.Tables.Add((DataTable) new dsPolicyCommissions.ChartDataTable(dataSet.Tables[nameof (Chart)]));
        if (dataSet.Tables[nameof (lstCommissionTypes)] != null)
          base.Tables.Add((DataTable) new dsPolicyCommissions.lstCommissionTypesDataTable(dataSet.Tables[nameof (lstCommissionTypes)]));
        if (dataSet.Tables[nameof (View)] != null)
          base.Tables.Add((DataTable) new dsPolicyCommissions.ViewDataTable(dataSet.Tables[nameof (View)]));
        if (dataSet.Tables[nameof (tblPolicyCommissions)] != null)
          base.Tables.Add((DataTable) new dsPolicyCommissions.tblPolicyCommissionsDataTable(dataSet.Tables[nameof (tblPolicyCommissions)]));
        if (dataSet.Tables[nameof (tblFin_PolicyCharges)] != null)
          base.Tables.Add((DataTable) new dsPolicyCommissions.tblFin_PolicyChargesDataTable(dataSet.Tables[nameof (tblFin_PolicyCharges)]));
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
  public dsPolicyCommissions.lstEntityTypesDataTable lstEntityTypes => this.tablelstEntityTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyCommissions.ChartDataTable Chart => this.tableChart;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyCommissions.lstCommissionTypesDataTable lstCommissionTypes
  {
    get => this.tablelstCommissionTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyCommissions.ViewDataTable View => this.tableView;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyCommissions.tblPolicyCommissionsDataTable tblPolicyCommissions
  {
    get => this.tabletblPolicyCommissions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyCommissions.tblFin_PolicyChargesDataTable tblFin_PolicyCharges
  {
    get => this.tabletblFin_PolicyCharges;
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
    dsPolicyCommissions policyCommissions = (dsPolicyCommissions) base.Clone();
    policyCommissions.InitVars();
    policyCommissions.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) policyCommissions;
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
      if (dataSet.Tables["lstEntityTypes"] != null)
        base.Tables.Add((DataTable) new dsPolicyCommissions.lstEntityTypesDataTable(dataSet.Tables["lstEntityTypes"]));
      if (dataSet.Tables["Chart"] != null)
        base.Tables.Add((DataTable) new dsPolicyCommissions.ChartDataTable(dataSet.Tables["Chart"]));
      if (dataSet.Tables["lstCommissionTypes"] != null)
        base.Tables.Add((DataTable) new dsPolicyCommissions.lstCommissionTypesDataTable(dataSet.Tables["lstCommissionTypes"]));
      if (dataSet.Tables["View"] != null)
        base.Tables.Add((DataTable) new dsPolicyCommissions.ViewDataTable(dataSet.Tables["View"]));
      if (dataSet.Tables["tblPolicyCommissions"] != null)
        base.Tables.Add((DataTable) new dsPolicyCommissions.tblPolicyCommissionsDataTable(dataSet.Tables["tblPolicyCommissions"]));
      if (dataSet.Tables["tblFin_PolicyCharges"] != null)
        base.Tables.Add((DataTable) new dsPolicyCommissions.tblFin_PolicyChargesDataTable(dataSet.Tables["tblFin_PolicyCharges"]));
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
    this.tablelstEntityTypes = (dsPolicyCommissions.lstEntityTypesDataTable) base.Tables["lstEntityTypes"];
    if (initTable && this.tablelstEntityTypes != null)
      this.tablelstEntityTypes.InitVars();
    this.tableChart = (dsPolicyCommissions.ChartDataTable) base.Tables["Chart"];
    if (initTable && this.tableChart != null)
      this.tableChart.InitVars();
    this.tablelstCommissionTypes = (dsPolicyCommissions.lstCommissionTypesDataTable) base.Tables["lstCommissionTypes"];
    if (initTable && this.tablelstCommissionTypes != null)
      this.tablelstCommissionTypes.InitVars();
    this.tableView = (dsPolicyCommissions.ViewDataTable) base.Tables["View"];
    if (initTable && this.tableView != null)
      this.tableView.InitVars();
    this.tabletblPolicyCommissions = (dsPolicyCommissions.tblPolicyCommissionsDataTable) base.Tables["tblPolicyCommissions"];
    if (initTable && this.tabletblPolicyCommissions != null)
      this.tabletblPolicyCommissions.InitVars();
    this.tabletblFin_PolicyCharges = (dsPolicyCommissions.tblFin_PolicyChargesDataTable) base.Tables["tblFin_PolicyCharges"];
    if (initTable && this.tabletblFin_PolicyCharges != null)
      this.tabletblFin_PolicyCharges.InitVars();
    this.relationtblFin_PolicyChargestblPolicyCommissions = this.Relations["tblFin_PolicyChargestblPolicyCommissions"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPolicyCommissions);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsPolicyCommissions.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstEntityTypes = new dsPolicyCommissions.lstEntityTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstEntityTypes);
    this.tableChart = new dsPolicyCommissions.ChartDataTable();
    base.Tables.Add((DataTable) this.tableChart);
    this.tablelstCommissionTypes = new dsPolicyCommissions.lstCommissionTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstCommissionTypes);
    this.tableView = new dsPolicyCommissions.ViewDataTable();
    base.Tables.Add((DataTable) this.tableView);
    this.tabletblPolicyCommissions = new dsPolicyCommissions.tblPolicyCommissionsDataTable();
    base.Tables.Add((DataTable) this.tabletblPolicyCommissions);
    this.tabletblFin_PolicyCharges = new dsPolicyCommissions.tblFin_PolicyChargesDataTable();
    base.Tables.Add((DataTable) this.tabletblFin_PolicyCharges);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("tblFin_PolicyChargestblPolicyCommissions", new DataColumn[1]
    {
      this.tabletblFin_PolicyCharges.ChargeCodeColumn
    }, new DataColumn[1]
    {
      this.tabletblPolicyCommissions.ChargeCodeColumn
    });
    this.tabletblPolicyCommissions.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationtblFin_PolicyChargestblPolicyCommissions = new DataRelation("tblFin_PolicyChargestblPolicyCommissions", new DataColumn[1]
    {
      this.tabletblFin_PolicyCharges.ChargeCodeColumn
    }, new DataColumn[1]
    {
      this.tabletblPolicyCommissions.ChargeCodeColumn
    }, false);
    this.Relations.Add(this.relationtblFin_PolicyChargestblPolicyCommissions);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstEntityTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeChart() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstCommissionTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeView() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblPolicyCommissions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblFin_PolicyCharges() => false;

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
    dsPolicyCommissions policyCommissions = new dsPolicyCommissions();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = policyCommissions.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = policyCommissions.GetSchemaSerializable();
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
  public delegate void lstEntityTypesRowChangeEventHandler(
    object sender,
    dsPolicyCommissions.lstEntityTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void ChartRowChangeEventHandler(
    object sender,
    dsPolicyCommissions.ChartRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstCommissionTypesRowChangeEventHandler(
    object sender,
    dsPolicyCommissions.lstCommissionTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void ViewRowChangeEventHandler(
    object sender,
    dsPolicyCommissions.ViewRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblPolicyCommissionsRowChangeEventHandler(
    object sender,
    dsPolicyCommissions.tblPolicyCommissionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblFin_PolicyChargesRowChangeEventHandler(
    object sender,
    dsPolicyCommissions.tblFin_PolicyChargesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstEntityTypesDataTable : TypedTableBase<dsPolicyCommissions.lstEntityTypesRow>
  {
    private DataColumn columnEntityTypeID;
    private DataColumn columnDescription;
    private DataColumn columnEntityTable;
    private DataColumn columnEntityNameField;
    private DataColumn columnEntityGUIDField;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstEntityTypesDataTable()
    {
      this.TableName = "lstEntityTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstEntityTypesDataTable(DataTable table)
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
    protected lstEntityTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityTypeIDColumn => this.columnEntityTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityTableColumn => this.columnEntityTable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityNameFieldColumn => this.columnEntityNameField;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityGUIDFieldColumn => this.columnEntityGUIDField;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.lstEntityTypesRow this[int index]
    {
      get => (dsPolicyCommissions.lstEntityTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.lstEntityTypesRowChangeEventHandler lstEntityTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.lstEntityTypesRowChangeEventHandler lstEntityTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.lstEntityTypesRowChangeEventHandler lstEntityTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.lstEntityTypesRowChangeEventHandler lstEntityTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstEntityTypesRow(dsPolicyCommissions.lstEntityTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.lstEntityTypesRow AddlstEntityTypesRow(
      string EntityTypeID,
      string Description,
      string EntityTable,
      string EntityNameField,
      string EntityGUIDField)
    {
      dsPolicyCommissions.lstEntityTypesRow row = (dsPolicyCommissions.lstEntityTypesRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) EntityTypeID,
        (object) Description,
        (object) EntityTable,
        (object) EntityNameField,
        (object) EntityGUIDField
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.lstEntityTypesRow FindByEntityTypeID(string EntityTypeID)
    {
      return (dsPolicyCommissions.lstEntityTypesRow) this.Rows.Find(new object[1]
      {
        (object) EntityTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyCommissions.lstEntityTypesDataTable entityTypesDataTable = (dsPolicyCommissions.lstEntityTypesDataTable) base.Clone();
      entityTypesDataTable.InitVars();
      return (DataTable) entityTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyCommissions.lstEntityTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntityTypeID = this.Columns["EntityTypeID"];
      this.columnDescription = this.Columns["Description"];
      this.columnEntityTable = this.Columns["EntityTable"];
      this.columnEntityNameField = this.Columns["EntityNameField"];
      this.columnEntityGUIDField = this.Columns["EntityGUIDField"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntityTypeID = new DataColumn("EntityTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityTypeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnEntityTable = new DataColumn("EntityTable", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityTable);
      this.columnEntityNameField = new DataColumn("EntityNameField", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityNameField);
      this.columnEntityGUIDField = new DataColumn("EntityGUIDField", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUIDField);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyCommissionsKey2", new DataColumn[1]
      {
        this.columnEntityTypeID
      }, true));
      this.columnEntityTypeID.AllowDBNull = false;
      this.columnEntityTypeID.Unique = true;
      this.columnDescription.AllowDBNull = false;
      this.columnEntityTable.AllowDBNull = false;
      this.columnEntityNameField.AllowDBNull = false;
      this.columnEntityGUIDField.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.lstEntityTypesRow NewlstEntityTypesRow()
    {
      return (dsPolicyCommissions.lstEntityTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyCommissions.lstEntityTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyCommissions.lstEntityTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEntityTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.lstEntityTypesRowChangeEventHandler typesRowChangedEvent = this.lstEntityTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsPolicyCommissions.lstEntityTypesRowChangeEvent((dsPolicyCommissions.lstEntityTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEntityTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.lstEntityTypesRowChangeEventHandler rowChangingEvent = this.lstEntityTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyCommissions.lstEntityTypesRowChangeEvent((dsPolicyCommissions.lstEntityTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEntityTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.lstEntityTypesRowChangeEventHandler typesRowDeletedEvent = this.lstEntityTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsPolicyCommissions.lstEntityTypesRowChangeEvent((dsPolicyCommissions.lstEntityTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEntityTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.lstEntityTypesRowChangeEventHandler rowDeletingEvent = this.lstEntityTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyCommissions.lstEntityTypesRowChangeEvent((dsPolicyCommissions.lstEntityTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstEntityTypesRow(dsPolicyCommissions.lstEntityTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyCommissions policyCommissions = new dsPolicyCommissions();
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
        FixedValue = policyCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstEntityTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyCommissions.GetSchemaSerializable();
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
  public class ChartDataTable : TypedTableBase<dsPolicyCommissions.ChartRow>
  {
    private DataColumn columnParticipant;
    private DataColumn columnPercentage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ChartDataTable()
    {
      this.TableName = "Chart";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ChartDataTable(DataTable table)
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
    protected ChartDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ParticipantColumn => this.columnParticipant;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PercentageColumn => this.columnPercentage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.ChartRow this[int index]
    {
      get => (dsPolicyCommissions.ChartRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.ChartRowChangeEventHandler ChartRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.ChartRowChangeEventHandler ChartRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.ChartRowChangeEventHandler ChartRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.ChartRowChangeEventHandler ChartRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddChartRow(dsPolicyCommissions.ChartRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.ChartRow AddChartRow(string Participant, Decimal Percentage)
    {
      dsPolicyCommissions.ChartRow row = (dsPolicyCommissions.ChartRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Participant,
        (object) Percentage
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyCommissions.ChartDataTable chartDataTable = (dsPolicyCommissions.ChartDataTable) base.Clone();
      chartDataTable.InitVars();
      return (DataTable) chartDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyCommissions.ChartDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnParticipant = this.Columns["Participant"];
      this.columnPercentage = this.Columns["Percentage"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnParticipant = new DataColumn("Participant", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParticipant);
      this.columnPercentage = new DataColumn("Percentage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentage);
      this.columnParticipant.AllowDBNull = false;
      this.columnPercentage.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.ChartRow NewChartRow()
    {
      return (dsPolicyCommissions.ChartRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyCommissions.ChartRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyCommissions.ChartRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ChartRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.ChartRowChangeEventHandler chartRowChangedEvent = this.ChartRowChangedEvent;
      if (chartRowChangedEvent == null)
        return;
      chartRowChangedEvent((object) this, new dsPolicyCommissions.ChartRowChangeEvent((dsPolicyCommissions.ChartRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ChartRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.ChartRowChangeEventHandler rowChangingEvent = this.ChartRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyCommissions.ChartRowChangeEvent((dsPolicyCommissions.ChartRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ChartRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.ChartRowChangeEventHandler chartRowDeletedEvent = this.ChartRowDeletedEvent;
      if (chartRowDeletedEvent == null)
        return;
      chartRowDeletedEvent((object) this, new dsPolicyCommissions.ChartRowChangeEvent((dsPolicyCommissions.ChartRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ChartRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.ChartRowChangeEventHandler rowDeletingEvent = this.ChartRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyCommissions.ChartRowChangeEvent((dsPolicyCommissions.ChartRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveChartRow(dsPolicyCommissions.ChartRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyCommissions policyCommissions = new dsPolicyCommissions();
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
        FixedValue = policyCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ChartDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyCommissions.GetSchemaSerializable();
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
  public class lstCommissionTypesDataTable : 
    TypedTableBase<dsPolicyCommissions.lstCommissionTypesRow>
  {
    private DataColumn columnCommissionTypeID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstCommissionTypesDataTable()
    {
      this.TableName = "lstCommissionTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstCommissionTypesDataTable(DataTable table)
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
    protected lstCommissionTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CommissionTypeIDColumn => this.columnCommissionTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.lstCommissionTypesRow this[int index]
    {
      get => (dsPolicyCommissions.lstCommissionTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.lstCommissionTypesRowChangeEventHandler lstCommissionTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.lstCommissionTypesRowChangeEventHandler lstCommissionTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.lstCommissionTypesRowChangeEventHandler lstCommissionTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.lstCommissionTypesRowChangeEventHandler lstCommissionTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstCommissionTypesRow(dsPolicyCommissions.lstCommissionTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.lstCommissionTypesRow AddlstCommissionTypesRow(
      string CommissionTypeID,
      string Description)
    {
      dsPolicyCommissions.lstCommissionTypesRow row = (dsPolicyCommissions.lstCommissionTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CommissionTypeID,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.lstCommissionTypesRow FindByCommissionTypeID(string CommissionTypeID)
    {
      return (dsPolicyCommissions.lstCommissionTypesRow) this.Rows.Find(new object[1]
      {
        (object) CommissionTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyCommissions.lstCommissionTypesDataTable commissionTypesDataTable = (dsPolicyCommissions.lstCommissionTypesDataTable) base.Clone();
      commissionTypesDataTable.InitVars();
      return (DataTable) commissionTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyCommissions.lstCommissionTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCommissionTypeID = this.Columns["CommissionTypeID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCommissionTypeID = new DataColumn("CommissionTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionTypeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyCommissionsKey3", new DataColumn[1]
      {
        this.columnCommissionTypeID
      }, true));
      this.columnCommissionTypeID.AllowDBNull = false;
      this.columnCommissionTypeID.Unique = true;
      this.columnDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.lstCommissionTypesRow NewlstCommissionTypesRow()
    {
      return (dsPolicyCommissions.lstCommissionTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyCommissions.lstCommissionTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyCommissions.lstCommissionTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCommissionTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.lstCommissionTypesRowChangeEventHandler typesRowChangedEvent = this.lstCommissionTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsPolicyCommissions.lstCommissionTypesRowChangeEvent((dsPolicyCommissions.lstCommissionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCommissionTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.lstCommissionTypesRowChangeEventHandler rowChangingEvent = this.lstCommissionTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyCommissions.lstCommissionTypesRowChangeEvent((dsPolicyCommissions.lstCommissionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCommissionTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.lstCommissionTypesRowChangeEventHandler typesRowDeletedEvent = this.lstCommissionTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsPolicyCommissions.lstCommissionTypesRowChangeEvent((dsPolicyCommissions.lstCommissionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCommissionTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.lstCommissionTypesRowChangeEventHandler rowDeletingEvent = this.lstCommissionTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyCommissions.lstCommissionTypesRowChangeEvent((dsPolicyCommissions.lstCommissionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstCommissionTypesRow(dsPolicyCommissions.lstCommissionTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyCommissions policyCommissions = new dsPolicyCommissions();
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
        FixedValue = policyCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstCommissionTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyCommissions.GetSchemaSerializable();
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
  public class ViewDataTable : TypedTableBase<dsPolicyCommissions.ViewRow>
  {
    private DataColumn columnEntityGuid;
    private DataColumn columnWaivedByUserGuid;
    private DataColumn columnChargeCode;
    private DataColumn columnParticipant;
    private DataColumn columnPercentage;
    private DataColumn columnDollarAmount;
    private DataColumn columnCommissionFrom;
    private DataColumn columnCommissionTypeID;
    private DataColumn columnEntityType;
    private DataColumn columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ViewDataTable()
    {
      this.TableName = "View";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ViewDataTable(DataTable table)
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
    protected ViewDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityGuidColumn => this.columnEntityGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn WaivedByUserGuidColumn => this.columnWaivedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ParticipantColumn => this.columnParticipant;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PercentageColumn => this.columnPercentage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DollarAmountColumn => this.columnDollarAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CommissionFromColumn => this.columnCommissionFrom;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CommissionTypeIDColumn => this.columnCommissionTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityTypeColumn => this.columnEntityType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.ViewRow this[int index]
    {
      get => (dsPolicyCommissions.ViewRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.ViewRowChangeEventHandler ViewRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.ViewRowChangeEventHandler ViewRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.ViewRowChangeEventHandler ViewRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.ViewRowChangeEventHandler ViewRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddViewRow(dsPolicyCommissions.ViewRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.ViewRow AddViewRow(
      Guid EntityGuid,
      Guid WaivedByUserGuid,
      int ChargeCode,
      string Participant,
      Decimal Percentage,
      Decimal DollarAmount,
      string CommissionFrom,
      string CommissionTypeID,
      string EntityType,
      string Premium)
    {
      dsPolicyCommissions.ViewRow row = (dsPolicyCommissions.ViewRow) this.NewRow();
      object[] objArray = new object[10]
      {
        (object) EntityGuid,
        (object) WaivedByUserGuid,
        (object) ChargeCode,
        (object) Participant,
        (object) Percentage,
        (object) DollarAmount,
        (object) CommissionFrom,
        (object) CommissionTypeID,
        (object) EntityType,
        (object) Premium
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.ViewRow FindByEntityGuidChargeCode(Guid EntityGuid, int ChargeCode)
    {
      return (dsPolicyCommissions.ViewRow) this.Rows.Find(new object[2]
      {
        (object) EntityGuid,
        (object) ChargeCode
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyCommissions.ViewDataTable viewDataTable = (dsPolicyCommissions.ViewDataTable) base.Clone();
      viewDataTable.InitVars();
      return (DataTable) viewDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyCommissions.ViewDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntityGuid = this.Columns["EntityGuid"];
      this.columnWaivedByUserGuid = this.Columns["WaivedByUserGuid"];
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnParticipant = this.Columns["Participant"];
      this.columnPercentage = this.Columns["Percentage"];
      this.columnDollarAmount = this.Columns["DollarAmount"];
      this.columnCommissionFrom = this.Columns["CommissionFrom"];
      this.columnCommissionTypeID = this.Columns["CommissionTypeID"];
      this.columnEntityType = this.Columns["EntityType"];
      this.columnPremium = this.Columns["Premium"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntityGuid = new DataColumn("EntityGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGuid);
      this.columnWaivedByUserGuid = new DataColumn("WaivedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWaivedByUserGuid);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnParticipant = new DataColumn("Participant", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParticipant);
      this.columnPercentage = new DataColumn("Percentage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentage);
      this.columnDollarAmount = new DataColumn("DollarAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDollarAmount);
      this.columnCommissionFrom = new DataColumn("CommissionFrom", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionFrom);
      this.columnCommissionTypeID = new DataColumn("CommissionTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionTypeID);
      this.columnEntityType = new DataColumn("EntityType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityType);
      this.columnPremium = new DataColumn("Premium", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyCommissionsKey4", new DataColumn[2]
      {
        this.columnEntityGuid,
        this.columnChargeCode
      }, true));
      this.columnEntityGuid.AllowDBNull = false;
      this.columnChargeCode.AllowDBNull = false;
      this.columnParticipant.AllowDBNull = false;
      this.columnCommissionFrom.AllowDBNull = false;
      this.columnCommissionTypeID.AllowDBNull = false;
      this.columnEntityType.AllowDBNull = false;
      this.columnPremium.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.ViewRow NewViewRow() => (dsPolicyCommissions.ViewRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyCommissions.ViewRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyCommissions.ViewRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ViewRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.ViewRowChangeEventHandler viewRowChangedEvent = this.ViewRowChangedEvent;
      if (viewRowChangedEvent == null)
        return;
      viewRowChangedEvent((object) this, new dsPolicyCommissions.ViewRowChangeEvent((dsPolicyCommissions.ViewRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ViewRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.ViewRowChangeEventHandler rowChangingEvent = this.ViewRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyCommissions.ViewRowChangeEvent((dsPolicyCommissions.ViewRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ViewRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.ViewRowChangeEventHandler viewRowDeletedEvent = this.ViewRowDeletedEvent;
      if (viewRowDeletedEvent == null)
        return;
      viewRowDeletedEvent((object) this, new dsPolicyCommissions.ViewRowChangeEvent((dsPolicyCommissions.ViewRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ViewRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.ViewRowChangeEventHandler rowDeletingEvent = this.ViewRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyCommissions.ViewRowChangeEvent((dsPolicyCommissions.ViewRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveViewRow(dsPolicyCommissions.ViewRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyCommissions policyCommissions = new dsPolicyCommissions();
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
        FixedValue = policyCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ViewDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyCommissions.GetSchemaSerializable();
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
  public class tblPolicyCommissionsDataTable : 
    TypedTableBase<dsPolicyCommissions.tblPolicyCommissionsRow>
  {
    private DataColumn columnQuoteGuid;
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnEntityGuid;
    private DataColumn columnChargeCode;
    private DataColumn columnEntityTypeID;
    private DataColumn columnCommissionTypeID;
    private DataColumn columnPercentage;
    private DataColumn columnFlatAmount;
    private DataColumn columnOptionFeeID;
    private DataColumn columnPremiumID;
    private DataColumn columnCommissionsFromOperatingAccount;
    private DataColumn columnWaivedByUserGuid;
    private DataColumn columnConvertedToManualUserGuid;
    private DataColumn columnAutoApplied;
    private DataColumn columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblPolicyCommissionsDataTable()
    {
      this.TableName = "tblPolicyCommissions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblPolicyCommissionsDataTable(DataTable table)
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
    protected tblPolicyCommissionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityGuidColumn => this.columnEntityGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityTypeIDColumn => this.columnEntityTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CommissionTypeIDColumn => this.columnCommissionTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PercentageColumn => this.columnPercentage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FlatAmountColumn => this.columnFlatAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OptionFeeIDColumn => this.columnOptionFeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremiumIDColumn => this.columnPremiumID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CommissionsFromOperatingAccountColumn
    {
      get => this.columnCommissionsFromOperatingAccount;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn WaivedByUserGuidColumn => this.columnWaivedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ConvertedToManualUserGuidColumn => this.columnConvertedToManualUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AutoAppliedColumn => this.columnAutoApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.tblPolicyCommissionsRow this[int index]
    {
      get => (dsPolicyCommissions.tblPolicyCommissionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.tblPolicyCommissionsRowChangeEventHandler tblPolicyCommissionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.tblPolicyCommissionsRowChangeEventHandler tblPolicyCommissionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.tblPolicyCommissionsRowChangeEventHandler tblPolicyCommissionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.tblPolicyCommissionsRowChangeEventHandler tblPolicyCommissionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblPolicyCommissionsRow(dsPolicyCommissions.tblPolicyCommissionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.tblPolicyCommissionsRow AddtblPolicyCommissionsRow(
      Guid QuoteGuid,
      Guid CompanyLineGuid,
      Guid EntityGuid,
      dsPolicyCommissions.tblFin_PolicyChargesRow parenttblFin_PolicyChargesRowBytblFin_PolicyChargestblPolicyCommissions,
      string EntityTypeID,
      string CommissionTypeID,
      Decimal Percentage,
      Decimal FlatAmount,
      int OptionFeeID,
      int PremiumID,
      bool CommissionsFromOperatingAccount,
      Guid WaivedByUserGuid,
      Guid ConvertedToManualUserGuid,
      bool AutoApplied)
    {
      dsPolicyCommissions.tblPolicyCommissionsRow row = (dsPolicyCommissions.tblPolicyCommissionsRow) this.NewRow();
      object[] objArray = new object[15]
      {
        (object) QuoteGuid,
        (object) CompanyLineGuid,
        (object) EntityGuid,
        null,
        (object) EntityTypeID,
        (object) CommissionTypeID,
        (object) Percentage,
        (object) FlatAmount,
        (object) OptionFeeID,
        (object) PremiumID,
        (object) CommissionsFromOperatingAccount,
        (object) WaivedByUserGuid,
        (object) ConvertedToManualUserGuid,
        (object) AutoApplied,
        null
      };
      if (parenttblFin_PolicyChargesRowBytblFin_PolicyChargestblPolicyCommissions != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parenttblFin_PolicyChargesRowBytblFin_PolicyChargestblPolicyCommissions[1]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyCommissions.tblPolicyCommissionsDataTable commissionsDataTable = (dsPolicyCommissions.tblPolicyCommissionsDataTable) base.Clone();
      commissionsDataTable.InitVars();
      return (DataTable) commissionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyCommissions.tblPolicyCommissionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnEntityGuid = this.Columns["EntityGuid"];
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnEntityTypeID = this.Columns["EntityTypeID"];
      this.columnCommissionTypeID = this.Columns["CommissionTypeID"];
      this.columnPercentage = this.Columns["Percentage"];
      this.columnFlatAmount = this.Columns["FlatAmount"];
      this.columnOptionFeeID = this.Columns["OptionFeeID"];
      this.columnPremiumID = this.Columns["PremiumID"];
      this.columnCommissionsFromOperatingAccount = this.Columns["CommissionsFromOperatingAccount"];
      this.columnWaivedByUserGuid = this.Columns["WaivedByUserGuid"];
      this.columnConvertedToManualUserGuid = this.Columns["ConvertedToManualUserGuid"];
      this.columnAutoApplied = this.Columns["AutoApplied"];
      this.columnID = this.Columns["ID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnEntityGuid = new DataColumn("EntityGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGuid);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnEntityTypeID = new DataColumn("EntityTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityTypeID);
      this.columnCommissionTypeID = new DataColumn("CommissionTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionTypeID);
      this.columnPercentage = new DataColumn("Percentage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentage);
      this.columnFlatAmount = new DataColumn("FlatAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFlatAmount);
      this.columnOptionFeeID = new DataColumn("OptionFeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptionFeeID);
      this.columnPremiumID = new DataColumn("PremiumID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremiumID);
      this.columnCommissionsFromOperatingAccount = new DataColumn("CommissionsFromOperatingAccount", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionsFromOperatingAccount);
      this.columnWaivedByUserGuid = new DataColumn("WaivedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWaivedByUserGuid);
      this.columnConvertedToManualUserGuid = new DataColumn("ConvertedToManualUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConvertedToManualUserGuid);
      this.columnAutoApplied = new DataColumn("AutoApplied", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoApplied);
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnQuoteGuid.AllowDBNull = false;
      this.columnCompanyLineGuid.AllowDBNull = false;
      this.columnEntityGuid.AllowDBNull = false;
      this.columnEntityTypeID.AllowDBNull = false;
      this.columnCommissionTypeID.AllowDBNull = false;
      this.columnCommissionsFromOperatingAccount.AllowDBNull = false;
      this.columnCommissionsFromOperatingAccount.DefaultValue = (object) false;
      this.columnAutoApplied.AllowDBNull = false;
      this.columnAutoApplied.DefaultValue = (object) false;
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.tblPolicyCommissionsRow NewtblPolicyCommissionsRow()
    {
      return (dsPolicyCommissions.tblPolicyCommissionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyCommissions.tblPolicyCommissionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyCommissions.tblPolicyCommissionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyCommissionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.tblPolicyCommissionsRowChangeEventHandler commissionsRowChangedEvent = this.tblPolicyCommissionsRowChangedEvent;
      if (commissionsRowChangedEvent == null)
        return;
      commissionsRowChangedEvent((object) this, new dsPolicyCommissions.tblPolicyCommissionsRowChangeEvent((dsPolicyCommissions.tblPolicyCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyCommissionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.tblPolicyCommissionsRowChangeEventHandler rowChangingEvent = this.tblPolicyCommissionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyCommissions.tblPolicyCommissionsRowChangeEvent((dsPolicyCommissions.tblPolicyCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyCommissionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.tblPolicyCommissionsRowChangeEventHandler commissionsRowDeletedEvent = this.tblPolicyCommissionsRowDeletedEvent;
      if (commissionsRowDeletedEvent == null)
        return;
      commissionsRowDeletedEvent((object) this, new dsPolicyCommissions.tblPolicyCommissionsRowChangeEvent((dsPolicyCommissions.tblPolicyCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPolicyCommissionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.tblPolicyCommissionsRowChangeEventHandler rowDeletingEvent = this.tblPolicyCommissionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyCommissions.tblPolicyCommissionsRowChangeEvent((dsPolicyCommissions.tblPolicyCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblPolicyCommissionsRow(dsPolicyCommissions.tblPolicyCommissionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyCommissions policyCommissions = new dsPolicyCommissions();
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
        FixedValue = policyCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblPolicyCommissionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyCommissions.GetSchemaSerializable();
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
  public class tblFin_PolicyChargesDataTable : 
    TypedTableBase<dsPolicyCommissions.tblFin_PolicyChargesRow>
  {
    private DataColumn columnChargeName;
    private DataColumn columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblFin_PolicyChargesDataTable()
    {
      this.TableName = "tblFin_PolicyCharges";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblFin_PolicyChargesDataTable(DataTable table)
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
    protected tblFin_PolicyChargesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.tblFin_PolicyChargesRow this[int index]
    {
      get => (dsPolicyCommissions.tblFin_PolicyChargesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyCommissions.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblFin_PolicyChargesRow(dsPolicyCommissions.tblFin_PolicyChargesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.tblFin_PolicyChargesRow AddtblFin_PolicyChargesRow(string ChargeName)
    {
      dsPolicyCommissions.tblFin_PolicyChargesRow row = (dsPolicyCommissions.tblFin_PolicyChargesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ChargeName,
        null
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.tblFin_PolicyChargesRow FindByChargeCode(int ChargeCode)
    {
      return (dsPolicyCommissions.tblFin_PolicyChargesRow) this.Rows.Find(new object[1]
      {
        (object) ChargeCode
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyCommissions.tblFin_PolicyChargesDataTable chargesDataTable = (dsPolicyCommissions.tblFin_PolicyChargesDataTable) base.Clone();
      chargesDataTable.InitVars();
      return (DataTable) chargesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyCommissions.tblFin_PolicyChargesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnChargeCode = this.Columns["ChargeCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyCommissionsKey5", new DataColumn[1]
      {
        this.columnChargeCode
      }, true));
      this.columnChargeName.AllowDBNull = false;
      this.columnChargeCode.AutoIncrement = true;
      this.columnChargeCode.AllowDBNull = false;
      this.columnChargeCode.ReadOnly = true;
      this.columnChargeCode.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.tblFin_PolicyChargesRow NewtblFin_PolicyChargesRow()
    {
      return (dsPolicyCommissions.tblFin_PolicyChargesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyCommissions.tblFin_PolicyChargesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyCommissions.tblFin_PolicyChargesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.tblFin_PolicyChargesRowChangeEventHandler chargesRowChangedEvent = this.tblFin_PolicyChargesRowChangedEvent;
      if (chargesRowChangedEvent == null)
        return;
      chargesRowChangedEvent((object) this, new dsPolicyCommissions.tblFin_PolicyChargesRowChangeEvent((dsPolicyCommissions.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.tblFin_PolicyChargesRowChangeEventHandler rowChangingEvent = this.tblFin_PolicyChargesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyCommissions.tblFin_PolicyChargesRowChangeEvent((dsPolicyCommissions.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.tblFin_PolicyChargesRowChangeEventHandler chargesRowDeletedEvent = this.tblFin_PolicyChargesRowDeletedEvent;
      if (chargesRowDeletedEvent == null)
        return;
      chargesRowDeletedEvent((object) this, new dsPolicyCommissions.tblFin_PolicyChargesRowChangeEvent((dsPolicyCommissions.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyCommissions.tblFin_PolicyChargesRowChangeEventHandler rowDeletingEvent = this.tblFin_PolicyChargesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyCommissions.tblFin_PolicyChargesRowChangeEvent((dsPolicyCommissions.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblFin_PolicyChargesRow(dsPolicyCommissions.tblFin_PolicyChargesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyCommissions policyCommissions = new dsPolicyCommissions();
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
        FixedValue = policyCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblFin_PolicyChargesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyCommissions.GetSchemaSerializable();
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

  public class lstEntityTypesRow : DataRow
  {
    private dsPolicyCommissions.lstEntityTypesDataTable tablelstEntityTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstEntityTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstEntityTypes = (dsPolicyCommissions.lstEntityTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string EntityTypeID
    {
      get => Conversions.ToString(this[this.tablelstEntityTypes.EntityTypeIDColumn]);
      set => this[this.tablelstEntityTypes.EntityTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstEntityTypes.DescriptionColumn]);
      set => this[this.tablelstEntityTypes.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string EntityTable
    {
      get => Conversions.ToString(this[this.tablelstEntityTypes.EntityTableColumn]);
      set => this[this.tablelstEntityTypes.EntityTableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string EntityNameField
    {
      get => Conversions.ToString(this[this.tablelstEntityTypes.EntityNameFieldColumn]);
      set => this[this.tablelstEntityTypes.EntityNameFieldColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string EntityGUIDField
    {
      get => Conversions.ToString(this[this.tablelstEntityTypes.EntityGUIDFieldColumn]);
      set => this[this.tablelstEntityTypes.EntityGUIDFieldColumn] = (object) value;
    }
  }

  public class ChartRow : DataRow
  {
    private dsPolicyCommissions.ChartDataTable tableChart;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ChartRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableChart = (dsPolicyCommissions.ChartDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Participant
    {
      get => Conversions.ToString(this[this.tableChart.ParticipantColumn]);
      set => this[this.tableChart.ParticipantColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Percentage
    {
      get => Conversions.ToDecimal(this[this.tableChart.PercentageColumn]);
      set => this[this.tableChart.PercentageColumn] = (object) value;
    }
  }

  public class lstCommissionTypesRow : DataRow
  {
    private dsPolicyCommissions.lstCommissionTypesDataTable tablelstCommissionTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstCommissionTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstCommissionTypes = (dsPolicyCommissions.lstCommissionTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CommissionTypeID
    {
      get => Conversions.ToString(this[this.tablelstCommissionTypes.CommissionTypeIDColumn]);
      set => this[this.tablelstCommissionTypes.CommissionTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstCommissionTypes.DescriptionColumn]);
      set => this[this.tablelstCommissionTypes.DescriptionColumn] = (object) value;
    }
  }

  public class ViewRow : DataRow
  {
    private dsPolicyCommissions.ViewDataTable tableView;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ViewRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableView = (dsPolicyCommissions.ViewDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntityGuid
    {
      get
      {
        object obj = this[this.tableView.EntityGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableView.EntityGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid WaivedByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tableView.WaivedByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WaivedByUserGuid' in table 'View' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableView.WaivedByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tableView.ChargeCodeColumn]);
      set => this[this.tableView.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Participant
    {
      get => Conversions.ToString(this[this.tableView.ParticipantColumn]);
      set => this[this.tableView.ParticipantColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Percentage
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableView.PercentageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Percentage' in table 'View' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableView.PercentageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal DollarAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableView.DollarAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DollarAmount' in table 'View' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableView.DollarAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CommissionFrom
    {
      get => Conversions.ToString(this[this.tableView.CommissionFromColumn]);
      set => this[this.tableView.CommissionFromColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CommissionTypeID
    {
      get => Conversions.ToString(this[this.tableView.CommissionTypeIDColumn]);
      set => this[this.tableView.CommissionTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string EntityType
    {
      get => Conversions.ToString(this[this.tableView.EntityTypeColumn]);
      set => this[this.tableView.EntityTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Premium
    {
      get => Conversions.ToString(this[this.tableView.PremiumColumn]);
      set => this[this.tableView.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsWaivedByUserGuidNull() => this.IsNull(this.tableView.WaivedByUserGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetWaivedByUserGuidNull()
    {
      this[this.tableView.WaivedByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPercentageNull() => this.IsNull(this.tableView.PercentageColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPercentageNull()
    {
      this[this.tableView.PercentageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDollarAmountNull() => this.IsNull(this.tableView.DollarAmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDollarAmountNull()
    {
      this[this.tableView.DollarAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblPolicyCommissionsRow : DataRow
  {
    private dsPolicyCommissions.tblPolicyCommissionsDataTable tabletblPolicyCommissions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblPolicyCommissionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblPolicyCommissions = (dsPolicyCommissions.tblPolicyCommissionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        object obj = this[this.tabletblPolicyCommissions.QuoteGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblPolicyCommissions.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        object obj = this[this.tabletblPolicyCommissions.CompanyLineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblPolicyCommissions.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntityGuid
    {
      get
      {
        object obj = this[this.tabletblPolicyCommissions.EntityGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblPolicyCommissions.EntityGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ChargeCode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyCommissions.ChargeCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeCode' in table 'tblPolicyCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyCommissions.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string EntityTypeID
    {
      get => Conversions.ToString(this[this.tabletblPolicyCommissions.EntityTypeIDColumn]);
      set => this[this.tabletblPolicyCommissions.EntityTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CommissionTypeID
    {
      get => Conversions.ToString(this[this.tabletblPolicyCommissions.CommissionTypeIDColumn]);
      set => this[this.tabletblPolicyCommissions.CommissionTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Percentage
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblPolicyCommissions.PercentageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Percentage' in table 'tblPolicyCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyCommissions.PercentageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal FlatAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblPolicyCommissions.FlatAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FlatAmount' in table 'tblPolicyCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyCommissions.FlatAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OptionFeeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyCommissions.OptionFeeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OptionFeeID' in table 'tblPolicyCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyCommissions.OptionFeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int PremiumID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPolicyCommissions.PremiumIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PremiumID' in table 'tblPolicyCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyCommissions.PremiumIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool CommissionsFromOperatingAccount
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblPolicyCommissions.CommissionsFromOperatingAccountColumn]);
      }
      set
      {
        this[this.tabletblPolicyCommissions.CommissionsFromOperatingAccountColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid WaivedByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblPolicyCommissions.WaivedByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WaivedByUserGuid' in table 'tblPolicyCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyCommissions.WaivedByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ConvertedToManualUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblPolicyCommissions.ConvertedToManualUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConvertedToManualUserGuid' in table 'tblPolicyCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPolicyCommissions.ConvertedToManualUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool AutoApplied
    {
      get => Conversions.ToBoolean(this[this.tabletblPolicyCommissions.AutoAppliedColumn]);
      set => this[this.tabletblPolicyCommissions.AutoAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblPolicyCommissions.IDColumn]);
      set => this[this.tabletblPolicyCommissions.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.tblFin_PolicyChargesRow tblFin_PolicyChargesRow
    {
      get
      {
        return (dsPolicyCommissions.tblFin_PolicyChargesRow) this.GetParentRow(this.Table.ParentRelations["tblFin_PolicyChargestblPolicyCommissions"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblFin_PolicyChargestblPolicyCommissions"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsChargeCodeNull() => this.IsNull(this.tabletblPolicyCommissions.ChargeCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetChargeCodeNull()
    {
      this[this.tabletblPolicyCommissions.ChargeCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPercentageNull() => this.IsNull(this.tabletblPolicyCommissions.PercentageColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPercentageNull()
    {
      this[this.tabletblPolicyCommissions.PercentageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFlatAmountNull() => this.IsNull(this.tabletblPolicyCommissions.FlatAmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFlatAmountNull()
    {
      this[this.tabletblPolicyCommissions.FlatAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOptionFeeIDNull()
    {
      return this.IsNull(this.tabletblPolicyCommissions.OptionFeeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOptionFeeIDNull()
    {
      this[this.tabletblPolicyCommissions.OptionFeeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPremiumIDNull() => this.IsNull(this.tabletblPolicyCommissions.PremiumIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPremiumIDNull()
    {
      this[this.tabletblPolicyCommissions.PremiumIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsWaivedByUserGuidNull()
    {
      return this.IsNull(this.tabletblPolicyCommissions.WaivedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetWaivedByUserGuidNull()
    {
      this[this.tabletblPolicyCommissions.WaivedByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsConvertedToManualUserGuidNull()
    {
      return this.IsNull(this.tabletblPolicyCommissions.ConvertedToManualUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetConvertedToManualUserGuidNull()
    {
      this[this.tabletblPolicyCommissions.ConvertedToManualUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblFin_PolicyChargesRow : DataRow
  {
    private dsPolicyCommissions.tblFin_PolicyChargesDataTable tabletblFin_PolicyCharges;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblFin_PolicyChargesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblFin_PolicyCharges = (dsPolicyCommissions.tblFin_PolicyChargesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ChargeName
    {
      get => Conversions.ToString(this[this.tabletblFin_PolicyCharges.ChargeNameColumn]);
      set => this[this.tabletblFin_PolicyCharges.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tabletblFin_PolicyCharges.ChargeCodeColumn]);
      set => this[this.tabletblFin_PolicyCharges.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.tblPolicyCommissionsRow[] GettblPolicyCommissionsRows()
    {
      return this.Table.ChildRelations["tblFin_PolicyChargestblPolicyCommissions"] != null ? (dsPolicyCommissions.tblPolicyCommissionsRow[]) this.GetChildRows(this.Table.ChildRelations["tblFin_PolicyChargestblPolicyCommissions"]) : new dsPolicyCommissions.tblPolicyCommissionsRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstEntityTypesRowChangeEvent : EventArgs
  {
    private dsPolicyCommissions.lstEntityTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstEntityTypesRowChangeEvent(
      dsPolicyCommissions.lstEntityTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.lstEntityTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class ChartRowChangeEvent : EventArgs
  {
    private dsPolicyCommissions.ChartRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ChartRowChangeEvent(dsPolicyCommissions.ChartRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.ChartRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstCommissionTypesRowChangeEvent : EventArgs
  {
    private dsPolicyCommissions.lstCommissionTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstCommissionTypesRowChangeEvent(
      dsPolicyCommissions.lstCommissionTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.lstCommissionTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class ViewRowChangeEvent : EventArgs
  {
    private dsPolicyCommissions.ViewRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ViewRowChangeEvent(dsPolicyCommissions.ViewRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.ViewRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblPolicyCommissionsRowChangeEvent : EventArgs
  {
    private dsPolicyCommissions.tblPolicyCommissionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblPolicyCommissionsRowChangeEvent(
      dsPolicyCommissions.tblPolicyCommissionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.tblPolicyCommissionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblFin_PolicyChargesRowChangeEvent : EventArgs
  {
    private dsPolicyCommissions.tblFin_PolicyChargesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblFin_PolicyChargesRowChangeEvent(
      dsPolicyCommissions.tblFin_PolicyChargesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyCommissions.tblFin_PolicyChargesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
