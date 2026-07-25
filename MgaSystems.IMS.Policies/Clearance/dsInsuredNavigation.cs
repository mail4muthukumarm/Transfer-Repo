// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Clearance.dsInsuredNavigation
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
namespace MGASystems.IMS.Policies.Clearance;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsInsuredNavigation")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsInsuredNavigation : DataSet
{
  private dsInsuredNavigation.tblInsuredsDataTable tabletblInsureds;
  private dsInsuredNavigation.tblProducerSubmissionsDataTable tabletblProducerSubmissions;
  private dsInsuredNavigation.tblLinesToCompanyDataTable tabletblLinesToCompany;
  private DataRelation relationtblInsuredstblProducerSubmissions;
  private DataRelation relationtblProducerstblLinesToCompany;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsInsuredNavigation()
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
  protected dsInsuredNavigation(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblInsureds)] != null)
          base.Tables.Add((DataTable) new dsInsuredNavigation.tblInsuredsDataTable(dataSet.Tables[nameof (tblInsureds)]));
        if (dataSet.Tables[nameof (tblProducerSubmissions)] != null)
          base.Tables.Add((DataTable) new dsInsuredNavigation.tblProducerSubmissionsDataTable(dataSet.Tables[nameof (tblProducerSubmissions)]));
        if (dataSet.Tables[nameof (tblLinesToCompany)] != null)
          base.Tables.Add((DataTable) new dsInsuredNavigation.tblLinesToCompanyDataTable(dataSet.Tables[nameof (tblLinesToCompany)]));
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
  public dsInsuredNavigation.tblInsuredsDataTable tblInsureds => this.tabletblInsureds;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsuredNavigation.tblProducerSubmissionsDataTable tblProducerSubmissions
  {
    get => this.tabletblProducerSubmissions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsuredNavigation.tblLinesToCompanyDataTable tblLinesToCompany
  {
    get => this.tabletblLinesToCompany;
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
    dsInsuredNavigation insuredNavigation = (dsInsuredNavigation) base.Clone();
    insuredNavigation.InitVars();
    insuredNavigation.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) insuredNavigation;
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
      if (dataSet.Tables["tblInsureds"] != null)
        base.Tables.Add((DataTable) new dsInsuredNavigation.tblInsuredsDataTable(dataSet.Tables["tblInsureds"]));
      if (dataSet.Tables["tblProducerSubmissions"] != null)
        base.Tables.Add((DataTable) new dsInsuredNavigation.tblProducerSubmissionsDataTable(dataSet.Tables["tblProducerSubmissions"]));
      if (dataSet.Tables["tblLinesToCompany"] != null)
        base.Tables.Add((DataTable) new dsInsuredNavigation.tblLinesToCompanyDataTable(dataSet.Tables["tblLinesToCompany"]));
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
    this.tabletblInsureds = (dsInsuredNavigation.tblInsuredsDataTable) base.Tables["tblInsureds"];
    if (initTable && this.tabletblInsureds != null)
      this.tabletblInsureds.InitVars();
    this.tabletblProducerSubmissions = (dsInsuredNavigation.tblProducerSubmissionsDataTable) base.Tables["tblProducerSubmissions"];
    if (initTable && this.tabletblProducerSubmissions != null)
      this.tabletblProducerSubmissions.InitVars();
    this.tabletblLinesToCompany = (dsInsuredNavigation.tblLinesToCompanyDataTable) base.Tables["tblLinesToCompany"];
    if (initTable && this.tabletblLinesToCompany != null)
      this.tabletblLinesToCompany.InitVars();
    this.relationtblInsuredstblProducerSubmissions = this.Relations["tblInsuredstblProducerSubmissions"];
    this.relationtblProducerstblLinesToCompany = this.Relations["tblProducerstblLinesToCompany"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsInsuredNavigation);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsInsuredNavigation.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblInsureds = new dsInsuredNavigation.tblInsuredsDataTable();
    base.Tables.Add((DataTable) this.tabletblInsureds);
    this.tabletblProducerSubmissions = new dsInsuredNavigation.tblProducerSubmissionsDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerSubmissions);
    this.tabletblLinesToCompany = new dsInsuredNavigation.tblLinesToCompanyDataTable();
    base.Tables.Add((DataTable) this.tabletblLinesToCompany);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("tblInsuredstblProducerSubmissions", new DataColumn[1]
    {
      this.tabletblInsureds.InsuredGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerSubmissions.InsuredGuidColumn
    });
    this.tabletblProducerSubmissions.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("tblProducerstblLinesToCompany", new DataColumn[1]
    {
      this.tabletblProducerSubmissions.SubmissionGroupGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblLinesToCompany.SubmissionGroupGuidColumn
    });
    this.tabletblLinesToCompany.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    this.relationtblInsuredstblProducerSubmissions = new DataRelation("tblInsuredstblProducerSubmissions", new DataColumn[1]
    {
      this.tabletblInsureds.InsuredGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerSubmissions.InsuredGuidColumn
    }, false);
    this.Relations.Add(this.relationtblInsuredstblProducerSubmissions);
    this.relationtblProducerstblLinesToCompany = new DataRelation("tblProducerstblLinesToCompany", new DataColumn[1]
    {
      this.tabletblProducerSubmissions.SubmissionGroupGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblLinesToCompany.SubmissionGroupGuidColumn
    }, false);
    this.Relations.Add(this.relationtblProducerstblLinesToCompany);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblInsureds() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblProducerSubmissions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblLinesToCompany() => false;

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
    dsInsuredNavigation insuredNavigation = new dsInsuredNavigation();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = insuredNavigation.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = insuredNavigation.GetSchemaSerializable();
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
  public delegate void tblInsuredsRowChangeEventHandler(
    object sender,
    dsInsuredNavigation.tblInsuredsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblProducerSubmissionsRowChangeEventHandler(
    object sender,
    dsInsuredNavigation.tblProducerSubmissionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblLinesToCompanyRowChangeEventHandler(
    object sender,
    dsInsuredNavigation.tblLinesToCompanyRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblInsuredsDataTable : TypedTableBase<dsInsuredNavigation.tblInsuredsRow>
  {
    private DataColumn columnInsuredGuid;
    private DataColumn columnName;
    private DataColumn columnInsuredID;
    private DataColumn columnSubmissionCount;
    private DataColumn columnViewSubmissions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblInsuredsDataTable()
    {
      this.TableName = "tblInsureds";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblInsuredsDataTable(DataTable table)
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
    protected tblInsuredsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InsuredGuidColumn => this.columnInsuredGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InsuredIDColumn => this.columnInsuredID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubmissionCountColumn => this.columnSubmissionCount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ViewSubmissionsColumn => this.columnViewSubmissions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblInsuredsRow this[int index]
    {
      get => (dsInsuredNavigation.tblInsuredsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredNavigation.tblInsuredsRowChangeEventHandler tblInsuredsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredNavigation.tblInsuredsRowChangeEventHandler tblInsuredsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredNavigation.tblInsuredsRowChangeEventHandler tblInsuredsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredNavigation.tblInsuredsRowChangeEventHandler tblInsuredsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblInsuredsRow(dsInsuredNavigation.tblInsuredsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblInsuredsRow AddtblInsuredsRow(
      Guid InsuredGuid,
      string Name,
      int InsuredID,
      int SubmissionCount,
      string ViewSubmissions)
    {
      dsInsuredNavigation.tblInsuredsRow row = (dsInsuredNavigation.tblInsuredsRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) InsuredGuid,
        (object) Name,
        (object) InsuredID,
        (object) SubmissionCount,
        (object) ViewSubmissions
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblInsuredsRow FindByInsuredGuid(Guid InsuredGuid)
    {
      return (dsInsuredNavigation.tblInsuredsRow) this.Rows.Find(new object[1]
      {
        (object) InsuredGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsInsuredNavigation.tblInsuredsDataTable insuredsDataTable = (dsInsuredNavigation.tblInsuredsDataTable) base.Clone();
      insuredsDataTable.InitVars();
      return (DataTable) insuredsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsuredNavigation.tblInsuredsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnInsuredGuid = this.Columns["InsuredGuid"];
      this.columnName = this.Columns["Name"];
      this.columnInsuredID = this.Columns["InsuredID"];
      this.columnSubmissionCount = this.Columns["SubmissionCount"];
      this.columnViewSubmissions = this.Columns["ViewSubmissions"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnInsuredGuid = new DataColumn("InsuredGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredGuid);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnInsuredID = new DataColumn("InsuredID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredID);
      this.columnSubmissionCount = new DataColumn("SubmissionCount", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubmissionCount);
      this.columnViewSubmissions = new DataColumn("ViewSubmissions", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnViewSubmissions);
      this.Constraints.Add((Constraint) new UniqueConstraint("key1", new DataColumn[1]
      {
        this.columnInsuredGuid
      }, true));
      this.columnInsuredGuid.AllowDBNull = false;
      this.columnInsuredGuid.Unique = true;
      this.columnName.AllowDBNull = false;
      this.columnInsuredID.AllowDBNull = false;
      this.columnSubmissionCount.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblInsuredsRow NewtblInsuredsRow()
    {
      return (dsInsuredNavigation.tblInsuredsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsuredNavigation.tblInsuredsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsuredNavigation.tblInsuredsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredNavigation.tblInsuredsRowChangeEventHandler insuredsRowChangedEvent = this.tblInsuredsRowChangedEvent;
      if (insuredsRowChangedEvent == null)
        return;
      insuredsRowChangedEvent((object) this, new dsInsuredNavigation.tblInsuredsRowChangeEvent((dsInsuredNavigation.tblInsuredsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredNavigation.tblInsuredsRowChangeEventHandler rowChangingEvent = this.tblInsuredsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsuredNavigation.tblInsuredsRowChangeEvent((dsInsuredNavigation.tblInsuredsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredNavigation.tblInsuredsRowChangeEventHandler insuredsRowDeletedEvent = this.tblInsuredsRowDeletedEvent;
      if (insuredsRowDeletedEvent == null)
        return;
      insuredsRowDeletedEvent((object) this, new dsInsuredNavigation.tblInsuredsRowChangeEvent((dsInsuredNavigation.tblInsuredsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredNavigation.tblInsuredsRowChangeEventHandler rowDeletingEvent = this.tblInsuredsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsuredNavigation.tblInsuredsRowChangeEvent((dsInsuredNavigation.tblInsuredsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblInsuredsRow(dsInsuredNavigation.tblInsuredsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsuredNavigation insuredNavigation = new dsInsuredNavigation();
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
        FixedValue = insuredNavigation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblInsuredsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = insuredNavigation.GetSchemaSerializable();
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
  public class tblProducerSubmissionsDataTable : 
    TypedTableBase<dsInsuredNavigation.tblProducerSubmissionsRow>
  {
    private DataColumn columnInsuredGuid;
    private DataColumn columnName;
    private DataColumn columnProducerLocationGuid;
    private DataColumn columnProducerGuid;
    private DataColumn columnDateSubmitted;
    private DataColumn columnSubmissionGroupGuid;
    private DataColumn columnViewQuotes;
    private DataColumn columnUnderwriter;
    private DataColumn columnProducerType;
    private DataColumn columnSubmissionGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblProducerSubmissionsDataTable()
    {
      this.TableName = "tblProducerSubmissions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblProducerSubmissionsDataTable(DataTable table)
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
    protected tblProducerSubmissionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InsuredGuidColumn => this.columnInsuredGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerLocationGuidColumn => this.columnProducerLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerGuidColumn => this.columnProducerGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateSubmittedColumn => this.columnDateSubmitted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubmissionGroupGuidColumn => this.columnSubmissionGroupGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ViewQuotesColumn => this.columnViewQuotes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UnderwriterColumn => this.columnUnderwriter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerTypeColumn => this.columnProducerType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubmissionGroupIDColumn => this.columnSubmissionGroupID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblProducerSubmissionsRow this[int index]
    {
      get => (dsInsuredNavigation.tblProducerSubmissionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredNavigation.tblProducerSubmissionsRowChangeEventHandler tblProducerSubmissionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredNavigation.tblProducerSubmissionsRowChangeEventHandler tblProducerSubmissionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredNavigation.tblProducerSubmissionsRowChangeEventHandler tblProducerSubmissionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredNavigation.tblProducerSubmissionsRowChangeEventHandler tblProducerSubmissionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblProducerSubmissionsRow(dsInsuredNavigation.tblProducerSubmissionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblProducerSubmissionsRow AddtblProducerSubmissionsRow(
      dsInsuredNavigation.tblInsuredsRow parenttblInsuredsRowBytblInsuredstblProducerSubmissions,
      string Name,
      Guid ProducerLocationGuid,
      Guid ProducerGuid,
      DateTime DateSubmitted,
      Guid SubmissionGroupGuid,
      string ViewQuotes,
      string Underwriter,
      string ProducerType,
      int SubmissionGroupID)
    {
      dsInsuredNavigation.tblProducerSubmissionsRow row = (dsInsuredNavigation.tblProducerSubmissionsRow) this.NewRow();
      object[] objArray = new object[10]
      {
        null,
        (object) Name,
        (object) ProducerLocationGuid,
        (object) ProducerGuid,
        (object) DateSubmitted,
        (object) SubmissionGroupGuid,
        (object) ViewQuotes,
        (object) Underwriter,
        (object) ProducerType,
        (object) SubmissionGroupID
      };
      if (parenttblInsuredsRowBytblInsuredstblProducerSubmissions != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblInsuredsRowBytblInsuredstblProducerSubmissions[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblProducerSubmissionsRow FindBySubmissionGroupGuid(
      Guid SubmissionGroupGuid)
    {
      return (dsInsuredNavigation.tblProducerSubmissionsRow) this.Rows.Find(new object[1]
      {
        (object) SubmissionGroupGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsInsuredNavigation.tblProducerSubmissionsDataTable submissionsDataTable = (dsInsuredNavigation.tblProducerSubmissionsDataTable) base.Clone();
      submissionsDataTable.InitVars();
      return (DataTable) submissionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsuredNavigation.tblProducerSubmissionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnInsuredGuid = this.Columns["InsuredGuid"];
      this.columnName = this.Columns["Name"];
      this.columnProducerLocationGuid = this.Columns["ProducerLocationGuid"];
      this.columnProducerGuid = this.Columns["ProducerGuid"];
      this.columnDateSubmitted = this.Columns["DateSubmitted"];
      this.columnSubmissionGroupGuid = this.Columns["SubmissionGroupGuid"];
      this.columnViewQuotes = this.Columns["ViewQuotes"];
      this.columnUnderwriter = this.Columns["Underwriter"];
      this.columnProducerType = this.Columns["ProducerType"];
      this.columnSubmissionGroupID = this.Columns["SubmissionGroupID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnInsuredGuid = new DataColumn("InsuredGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredGuid);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnProducerLocationGuid = new DataColumn("ProducerLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGuid);
      this.columnProducerGuid = new DataColumn("ProducerGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerGuid);
      this.columnDateSubmitted = new DataColumn("DateSubmitted", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateSubmitted);
      this.columnSubmissionGroupGuid = new DataColumn("SubmissionGroupGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubmissionGroupGuid);
      this.columnViewQuotes = new DataColumn("ViewQuotes", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnViewQuotes);
      this.columnUnderwriter = new DataColumn("Underwriter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriter);
      this.columnProducerType = new DataColumn("ProducerType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerType);
      this.columnSubmissionGroupID = new DataColumn("SubmissionGroupID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubmissionGroupID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInsuredNavigationKey1", new DataColumn[1]
      {
        this.columnSubmissionGroupGuid
      }, true));
      this.columnInsuredGuid.AllowDBNull = false;
      this.columnName.AllowDBNull = false;
      this.columnProducerLocationGuid.AllowDBNull = false;
      this.columnProducerGuid.AllowDBNull = false;
      this.columnDateSubmitted.AllowDBNull = false;
      this.columnSubmissionGroupGuid.AllowDBNull = false;
      this.columnSubmissionGroupGuid.Unique = true;
      this.columnSubmissionGroupID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblProducerSubmissionsRow NewtblProducerSubmissionsRow()
    {
      return (dsInsuredNavigation.tblProducerSubmissionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsuredNavigation.tblProducerSubmissionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsuredNavigation.tblProducerSubmissionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerSubmissionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredNavigation.tblProducerSubmissionsRowChangeEventHandler submissionsRowChangedEvent = this.tblProducerSubmissionsRowChangedEvent;
      if (submissionsRowChangedEvent == null)
        return;
      submissionsRowChangedEvent((object) this, new dsInsuredNavigation.tblProducerSubmissionsRowChangeEvent((dsInsuredNavigation.tblProducerSubmissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerSubmissionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredNavigation.tblProducerSubmissionsRowChangeEventHandler rowChangingEvent = this.tblProducerSubmissionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsuredNavigation.tblProducerSubmissionsRowChangeEvent((dsInsuredNavigation.tblProducerSubmissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerSubmissionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredNavigation.tblProducerSubmissionsRowChangeEventHandler submissionsRowDeletedEvent = this.tblProducerSubmissionsRowDeletedEvent;
      if (submissionsRowDeletedEvent == null)
        return;
      submissionsRowDeletedEvent((object) this, new dsInsuredNavigation.tblProducerSubmissionsRowChangeEvent((dsInsuredNavigation.tblProducerSubmissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerSubmissionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredNavigation.tblProducerSubmissionsRowChangeEventHandler rowDeletingEvent = this.tblProducerSubmissionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsuredNavigation.tblProducerSubmissionsRowChangeEvent((dsInsuredNavigation.tblProducerSubmissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblProducerSubmissionsRow(dsInsuredNavigation.tblProducerSubmissionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsuredNavigation insuredNavigation = new dsInsuredNavigation();
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
        FixedValue = insuredNavigation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerSubmissionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = insuredNavigation.GetSchemaSerializable();
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
  public class tblLinesToCompanyDataTable : TypedTableBase<dsInsuredNavigation.tblLinesToCompanyRow>
  {
    private DataColumn columnInsuredPolicyName;
    private DataColumn columnInsuredDBA;
    private DataColumn columnProducerContact;
    private DataColumn columnEffectiveDate;
    private DataColumn columnExpirationDate;
    private DataColumn columnQuoteGuid;
    private DataColumn columnSubmissionGroupGuid;
    private DataColumn columnControlGuid;
    private DataColumn columnPolicyNumber;
    private DataColumn columnLineName;
    private DataColumn columnName;
    private DataColumn columnCompanyLocationGuid;
    private DataColumn columnControlNo;
    private DataColumn columnState;
    private DataColumn columnQuickQuote;
    private DataColumn columnUnderwriter;
    private DataColumn columnPremium;
    private DataColumn columnReason;
    private DataColumn columnRiskDescription;
    private DataColumn columnPolicyDescription;
    private DataColumn columnTACSR;
    private DataColumn columnUnderwriterAssitant;
    private DataColumn columnQuoteStatus;
    private DataColumn columnQuoteStatusID;
    private DataColumn columnHasPopupNotes;
    private DataColumn columnQuotingOffice;
    private DataColumn columnReasonColor;
    private DataColumn columnNeededByDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblLinesToCompanyDataTable()
    {
      this.TableName = "tblLinesToCompany";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblLinesToCompanyDataTable(DataTable table)
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
    protected tblLinesToCompanyDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InsuredPolicyNameColumn => this.columnInsuredPolicyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InsuredDBAColumn => this.columnInsuredDBA;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerContactColumn => this.columnProducerContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubmissionGroupGuidColumn => this.columnSubmissionGroupGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ControlGuidColumn => this.columnControlGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuickQuoteColumn => this.columnQuickQuote;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UnderwriterColumn => this.columnUnderwriter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ReasonColumn => this.columnReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RiskDescriptionColumn => this.columnRiskDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PolicyDescriptionColumn => this.columnPolicyDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TACSRColumn => this.columnTACSR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UnderwriterAssitantColumn => this.columnUnderwriterAssitant;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteStatusColumn => this.columnQuoteStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteStatusIDColumn => this.columnQuoteStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn HasPopupNotesColumn => this.columnHasPopupNotes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuotingOfficeColumn => this.columnQuotingOffice;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ReasonColorColumn => this.columnReasonColor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NeededByDateColumn => this.columnNeededByDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblLinesToCompanyRow this[int index]
    {
      get => (dsInsuredNavigation.tblLinesToCompanyRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredNavigation.tblLinesToCompanyRowChangeEventHandler tblLinesToCompanyRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredNavigation.tblLinesToCompanyRowChangeEventHandler tblLinesToCompanyRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredNavigation.tblLinesToCompanyRowChangeEventHandler tblLinesToCompanyRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredNavigation.tblLinesToCompanyRowChangeEventHandler tblLinesToCompanyRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblLinesToCompanyRow(dsInsuredNavigation.tblLinesToCompanyRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblLinesToCompanyRow AddtblLinesToCompanyRow(
      string InsuredPolicyName,
      string InsuredDBA,
      string ProducerContact,
      DateTime EffectiveDate,
      DateTime ExpirationDate,
      Guid QuoteGuid,
      dsInsuredNavigation.tblProducerSubmissionsRow parenttblProducerSubmissionsRowBytblProducerstblLinesToCompany,
      Guid ControlGuid,
      string PolicyNumber,
      string LineName,
      string Name,
      Guid CompanyLocationGuid,
      int ControlNo,
      string State,
      bool QuickQuote,
      string Underwriter,
      double Premium,
      string Reason,
      string RiskDescription,
      string PolicyDescription,
      string TACSR,
      string UnderwriterAssitant,
      string QuoteStatus,
      int QuoteStatusID,
      bool HasPopupNotes,
      string QuotingOffice,
      int ReasonColor,
      DateTime NeededByDate)
    {
      dsInsuredNavigation.tblLinesToCompanyRow row = (dsInsuredNavigation.tblLinesToCompanyRow) this.NewRow();
      object[] objArray = new object[28]
      {
        (object) InsuredPolicyName,
        (object) InsuredDBA,
        (object) ProducerContact,
        (object) EffectiveDate,
        (object) ExpirationDate,
        (object) QuoteGuid,
        null,
        (object) ControlGuid,
        (object) PolicyNumber,
        (object) LineName,
        (object) Name,
        (object) CompanyLocationGuid,
        (object) ControlNo,
        (object) State,
        (object) QuickQuote,
        (object) Underwriter,
        (object) Premium,
        (object) Reason,
        (object) RiskDescription,
        (object) PolicyDescription,
        (object) TACSR,
        (object) UnderwriterAssitant,
        (object) QuoteStatus,
        (object) QuoteStatusID,
        (object) HasPopupNotes,
        (object) QuotingOffice,
        (object) ReasonColor,
        (object) NeededByDate
      };
      if (parenttblProducerSubmissionsRowBytblProducerstblLinesToCompany != null)
        objArray[6] = RuntimeHelpers.GetObjectValue(parenttblProducerSubmissionsRowBytblProducerstblLinesToCompany[5]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblLinesToCompanyRow FindByQuoteGuid(Guid QuoteGuid)
    {
      return (dsInsuredNavigation.tblLinesToCompanyRow) this.Rows.Find(new object[1]
      {
        (object) QuoteGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsInsuredNavigation.tblLinesToCompanyDataTable companyDataTable = (dsInsuredNavigation.tblLinesToCompanyDataTable) base.Clone();
      companyDataTable.InitVars();
      return (DataTable) companyDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsuredNavigation.tblLinesToCompanyDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnInsuredPolicyName = this.Columns["InsuredPolicyName"];
      this.columnInsuredDBA = this.Columns["InsuredDBA"];
      this.columnProducerContact = this.Columns["ProducerContact"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnSubmissionGroupGuid = this.Columns["SubmissionGroupGuid"];
      this.columnControlGuid = this.Columns["ControlGuid"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnLineName = this.Columns["LineName"];
      this.columnName = this.Columns["Name"];
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnState = this.Columns["State"];
      this.columnQuickQuote = this.Columns["QuickQuote"];
      this.columnUnderwriter = this.Columns["Underwriter"];
      this.columnPremium = this.Columns["Premium"];
      this.columnReason = this.Columns["Reason"];
      this.columnRiskDescription = this.Columns["RiskDescription"];
      this.columnPolicyDescription = this.Columns["PolicyDescription"];
      this.columnTACSR = this.Columns["TACSR"];
      this.columnUnderwriterAssitant = this.Columns["UnderwriterAssitant"];
      this.columnQuoteStatus = this.Columns["QuoteStatus"];
      this.columnQuoteStatusID = this.Columns["QuoteStatusID"];
      this.columnHasPopupNotes = this.Columns["HasPopupNotes"];
      this.columnQuotingOffice = this.Columns["QuotingOffice"];
      this.columnReasonColor = this.Columns["ReasonColor"];
      this.columnNeededByDate = this.Columns["NeededByDate"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnInsuredPolicyName = new DataColumn("InsuredPolicyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredPolicyName);
      this.columnInsuredDBA = new DataColumn("InsuredDBA", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredDBA);
      this.columnProducerContact = new DataColumn("ProducerContact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContact);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnSubmissionGroupGuid = new DataColumn("SubmissionGroupGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubmissionGroupGuid);
      this.columnControlGuid = new DataColumn("ControlGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlGuid);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnLineName = new DataColumn("LineName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineName);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnQuickQuote = new DataColumn("QuickQuote", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuickQuote);
      this.columnUnderwriter = new DataColumn("Underwriter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriter);
      this.columnPremium = new DataColumn("Premium", typeof (double), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnReason = new DataColumn("Reason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReason);
      this.columnRiskDescription = new DataColumn("RiskDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRiskDescription);
      this.columnPolicyDescription = new DataColumn("PolicyDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyDescription);
      this.columnTACSR = new DataColumn("TACSR", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTACSR);
      this.columnUnderwriterAssitant = new DataColumn("UnderwriterAssitant", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriterAssitant);
      this.columnQuoteStatus = new DataColumn("QuoteStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatus);
      this.columnQuoteStatusID = new DataColumn("QuoteStatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatusID);
      this.columnHasPopupNotes = new DataColumn("HasPopupNotes", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHasPopupNotes);
      this.columnQuotingOffice = new DataColumn("QuotingOffice", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuotingOffice);
      this.columnReasonColor = new DataColumn("ReasonColor", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReasonColor);
      this.columnNeededByDate = new DataColumn("NeededByDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNeededByDate);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInsuredNavigationKey4", new DataColumn[1]
      {
        this.columnQuoteGuid
      }, true));
      this.columnInsuredPolicyName.AllowDBNull = false;
      this.columnProducerContact.AllowDBNull = false;
      this.columnEffectiveDate.AllowDBNull = false;
      this.columnExpirationDate.AllowDBNull = false;
      this.columnQuoteGuid.AllowDBNull = false;
      this.columnQuoteGuid.Unique = true;
      this.columnSubmissionGroupGuid.AllowDBNull = false;
      this.columnControlGuid.AllowDBNull = false;
      this.columnLineName.AllowDBNull = false;
      this.columnControlNo.AllowDBNull = false;
      this.columnQuickQuote.AllowDBNull = false;
      this.columnQuoteStatus.AllowDBNull = false;
      this.columnQuoteStatusID.AllowDBNull = false;
      this.columnHasPopupNotes.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblLinesToCompanyRow NewtblLinesToCompanyRow()
    {
      return (dsInsuredNavigation.tblLinesToCompanyRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsuredNavigation.tblLinesToCompanyRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsuredNavigation.tblLinesToCompanyRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblLinesToCompanyRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredNavigation.tblLinesToCompanyRowChangeEventHandler companyRowChangedEvent = this.tblLinesToCompanyRowChangedEvent;
      if (companyRowChangedEvent == null)
        return;
      companyRowChangedEvent((object) this, new dsInsuredNavigation.tblLinesToCompanyRowChangeEvent((dsInsuredNavigation.tblLinesToCompanyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblLinesToCompanyRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredNavigation.tblLinesToCompanyRowChangeEventHandler rowChangingEvent = this.tblLinesToCompanyRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsuredNavigation.tblLinesToCompanyRowChangeEvent((dsInsuredNavigation.tblLinesToCompanyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblLinesToCompanyRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredNavigation.tblLinesToCompanyRowChangeEventHandler companyRowDeletedEvent = this.tblLinesToCompanyRowDeletedEvent;
      if (companyRowDeletedEvent == null)
        return;
      companyRowDeletedEvent((object) this, new dsInsuredNavigation.tblLinesToCompanyRowChangeEvent((dsInsuredNavigation.tblLinesToCompanyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblLinesToCompanyRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredNavigation.tblLinesToCompanyRowChangeEventHandler rowDeletingEvent = this.tblLinesToCompanyRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsuredNavigation.tblLinesToCompanyRowChangeEvent((dsInsuredNavigation.tblLinesToCompanyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblLinesToCompanyRow(dsInsuredNavigation.tblLinesToCompanyRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsuredNavigation insuredNavigation = new dsInsuredNavigation();
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
        FixedValue = insuredNavigation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblLinesToCompanyDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = insuredNavigation.GetSchemaSerializable();
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

  public class tblInsuredsRow : DataRow
  {
    private dsInsuredNavigation.tblInsuredsDataTable tabletblInsureds;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblInsuredsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblInsureds = (dsInsuredNavigation.tblInsuredsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid InsuredGuid
    {
      get
      {
        object obj = this[this.tabletblInsureds.InsuredGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblInsureds.InsuredGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Name
    {
      get => Conversions.ToString(this[this.tabletblInsureds.NameColumn]);
      set => this[this.tabletblInsureds.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int InsuredID
    {
      get => Conversions.ToInteger(this[this.tabletblInsureds.InsuredIDColumn]);
      set => this[this.tabletblInsureds.InsuredIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int SubmissionCount
    {
      get => Conversions.ToInteger(this[this.tabletblInsureds.SubmissionCountColumn]);
      set => this[this.tabletblInsureds.SubmissionCountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ViewSubmissions
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsureds.ViewSubmissionsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ViewSubmissions' in table 'tblInsureds' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsureds.ViewSubmissionsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsViewSubmissionsNull() => this.IsNull(this.tabletblInsureds.ViewSubmissionsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetViewSubmissionsNull()
    {
      this[this.tabletblInsureds.ViewSubmissionsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblProducerSubmissionsRow[] GettblProducerSubmissionsRows()
    {
      return this.Table.ChildRelations["tblInsuredstblProducerSubmissions"] != null ? (dsInsuredNavigation.tblProducerSubmissionsRow[]) this.GetChildRows(this.Table.ChildRelations["tblInsuredstblProducerSubmissions"]) : new dsInsuredNavigation.tblProducerSubmissionsRow[0];
    }
  }

  public class tblProducerSubmissionsRow : DataRow
  {
    private dsInsuredNavigation.tblProducerSubmissionsDataTable tabletblProducerSubmissions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblProducerSubmissionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerSubmissions = (dsInsuredNavigation.tblProducerSubmissionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid InsuredGuid
    {
      get
      {
        object obj = this[this.tabletblProducerSubmissions.InsuredGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducerSubmissions.InsuredGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Name
    {
      get => Conversions.ToString(this[this.tabletblProducerSubmissions.NameColumn]);
      set => this[this.tabletblProducerSubmissions.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ProducerLocationGuid
    {
      get
      {
        object obj = this[this.tabletblProducerSubmissions.ProducerLocationGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducerSubmissions.ProducerLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ProducerGuid
    {
      get
      {
        object obj = this[this.tabletblProducerSubmissions.ProducerGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducerSubmissions.ProducerGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateSubmitted
    {
      get => Conversions.ToDate(this[this.tabletblProducerSubmissions.DateSubmittedColumn]);
      set => this[this.tabletblProducerSubmissions.DateSubmittedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid SubmissionGroupGuid
    {
      get
      {
        object obj = this[this.tabletblProducerSubmissions.SubmissionGroupGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducerSubmissions.SubmissionGroupGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ViewQuotes
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerSubmissions.ViewQuotesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ViewQuotes' in table 'tblProducerSubmissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerSubmissions.ViewQuotesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Underwriter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerSubmissions.UnderwriterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Underwriter' in table 'tblProducerSubmissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerSubmissions.UnderwriterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerSubmissions.ProducerTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerType' in table 'tblProducerSubmissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerSubmissions.ProducerTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int SubmissionGroupID
    {
      get => Conversions.ToInteger(this[this.tabletblProducerSubmissions.SubmissionGroupIDColumn]);
      set => this[this.tabletblProducerSubmissions.SubmissionGroupIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblInsuredsRow tblInsuredsRow
    {
      get
      {
        return (dsInsuredNavigation.tblInsuredsRow) this.GetParentRow(this.Table.ParentRelations["tblInsuredstblProducerSubmissions"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblInsuredstblProducerSubmissions"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsViewQuotesNull()
    {
      return this.IsNull(this.tabletblProducerSubmissions.ViewQuotesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetViewQuotesNull()
    {
      this[this.tabletblProducerSubmissions.ViewQuotesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnderwriterNull()
    {
      return this.IsNull(this.tabletblProducerSubmissions.UnderwriterColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnderwriterNull()
    {
      this[this.tabletblProducerSubmissions.UnderwriterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerTypeNull()
    {
      return this.IsNull(this.tabletblProducerSubmissions.ProducerTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerTypeNull()
    {
      this[this.tabletblProducerSubmissions.ProducerTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblLinesToCompanyRow[] GettblLinesToCompanyRows()
    {
      return this.Table.ChildRelations["tblProducerstblLinesToCompany"] != null ? (dsInsuredNavigation.tblLinesToCompanyRow[]) this.GetChildRows(this.Table.ChildRelations["tblProducerstblLinesToCompany"]) : new dsInsuredNavigation.tblLinesToCompanyRow[0];
    }
  }

  public class tblLinesToCompanyRow : DataRow
  {
    private dsInsuredNavigation.tblLinesToCompanyDataTable tabletblLinesToCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblLinesToCompanyRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblLinesToCompany = (dsInsuredNavigation.tblLinesToCompanyDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string InsuredPolicyName
    {
      get => Conversions.ToString(this[this.tabletblLinesToCompany.InsuredPolicyNameColumn]);
      set => this[this.tabletblLinesToCompany.InsuredPolicyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string InsuredDBA
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblLinesToCompany.InsuredDBAColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredDBA' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.InsuredDBAColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerContact
    {
      get => Conversions.ToString(this[this.tabletblLinesToCompany.ProducerContactColumn]);
      set => this[this.tabletblLinesToCompany.ProducerContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime EffectiveDate
    {
      get => Conversions.ToDate(this[this.tabletblLinesToCompany.EffectiveDateColumn]);
      set => this[this.tabletblLinesToCompany.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime ExpirationDate
    {
      get => Conversions.ToDate(this[this.tabletblLinesToCompany.ExpirationDateColumn]);
      set => this[this.tabletblLinesToCompany.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        object obj = this[this.tabletblLinesToCompany.QuoteGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblLinesToCompany.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid SubmissionGroupGuid
    {
      get
      {
        object obj = this[this.tabletblLinesToCompany.SubmissionGroupGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblLinesToCompany.SubmissionGroupGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ControlGuid
    {
      get
      {
        object obj = this[this.tabletblLinesToCompany.ControlGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblLinesToCompany.ControlGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblLinesToCompany.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LineName
    {
      get => Conversions.ToString(this[this.tabletblLinesToCompany.LineNameColumn]);
      set => this[this.tabletblLinesToCompany.LineNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblLinesToCompany.NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblLinesToCompany.CompanyLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLocationGuid' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.CompanyLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ControlNo
    {
      get => Conversions.ToInteger(this[this.tabletblLinesToCompany.ControlNoColumn]);
      set => this[this.tabletblLinesToCompany.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblLinesToCompany.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool QuickQuote
    {
      get => Conversions.ToBoolean(this[this.tabletblLinesToCompany.QuickQuoteColumn]);
      set => this[this.tabletblLinesToCompany.QuickQuoteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Underwriter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblLinesToCompany.UnderwriterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Underwriter' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.UnderwriterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public double Premium
    {
      get
      {
        try
        {
          return Conversions.ToDouble(this[this.tabletblLinesToCompany.PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Premium' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Reason
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblLinesToCompany.ReasonColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Reason' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.ReasonColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RiskDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblLinesToCompany.RiskDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RiskDescription' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.RiskDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PolicyDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblLinesToCompany.PolicyDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyDescription' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.PolicyDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string TACSR
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblLinesToCompany.TACSRColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TACSR' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.TACSRColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string UnderwriterAssitant
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblLinesToCompany.UnderwriterAssitantColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnderwriterAssitant' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.UnderwriterAssitantColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string QuoteStatus
    {
      get => Conversions.ToString(this[this.tabletblLinesToCompany.QuoteStatusColumn]);
      set => this[this.tabletblLinesToCompany.QuoteStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteStatusID
    {
      get => Conversions.ToInteger(this[this.tabletblLinesToCompany.QuoteStatusIDColumn]);
      set => this[this.tabletblLinesToCompany.QuoteStatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool HasPopupNotes
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblLinesToCompany.HasPopupNotesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'HasPopupNotes' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.HasPopupNotesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string QuotingOffice
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblLinesToCompany.QuotingOfficeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuotingOffice' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.QuotingOfficeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ReasonColor
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblLinesToCompany.ReasonColorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ReasonColor' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.ReasonColorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime NeededByDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblLinesToCompany.NeededByDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NeededByDate' in table 'tblLinesToCompany' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblLinesToCompany.NeededByDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblProducerSubmissionsRow tblProducerSubmissionsRow
    {
      get
      {
        return (dsInsuredNavigation.tblProducerSubmissionsRow) this.GetParentRow(this.Table.ParentRelations["tblProducerstblLinesToCompany"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblProducerstblLinesToCompany"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsuredDBANull() => this.IsNull(this.tabletblLinesToCompany.InsuredDBAColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsuredDBANull()
    {
      this[this.tabletblLinesToCompany.InsuredDBAColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tabletblLinesToCompany.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tabletblLinesToCompany.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabletblLinesToCompany.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabletblLinesToCompany.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompanyLocationGuidNull()
    {
      return this.IsNull(this.tabletblLinesToCompany.CompanyLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompanyLocationGuidNull()
    {
      this[this.tabletblLinesToCompany.CompanyLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabletblLinesToCompany.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabletblLinesToCompany.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnderwriterNull() => this.IsNull(this.tabletblLinesToCompany.UnderwriterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnderwriterNull()
    {
      this[this.tabletblLinesToCompany.UnderwriterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tabletblLinesToCompany.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tabletblLinesToCompany.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsReasonNull() => this.IsNull(this.tabletblLinesToCompany.ReasonColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetReasonNull()
    {
      this[this.tabletblLinesToCompany.ReasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRiskDescriptionNull()
    {
      return this.IsNull(this.tabletblLinesToCompany.RiskDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRiskDescriptionNull()
    {
      this[this.tabletblLinesToCompany.RiskDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicyDescriptionNull()
    {
      return this.IsNull(this.tabletblLinesToCompany.PolicyDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicyDescriptionNull()
    {
      this[this.tabletblLinesToCompany.PolicyDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTACSRNull() => this.IsNull(this.tabletblLinesToCompany.TACSRColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTACSRNull()
    {
      this[this.tabletblLinesToCompany.TACSRColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnderwriterAssitantNull()
    {
      return this.IsNull(this.tabletblLinesToCompany.UnderwriterAssitantColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnderwriterAssitantNull()
    {
      this[this.tabletblLinesToCompany.UnderwriterAssitantColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsHasPopupNotesNull()
    {
      return this.IsNull(this.tabletblLinesToCompany.HasPopupNotesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetHasPopupNotesNull()
    {
      this[this.tabletblLinesToCompany.HasPopupNotesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsQuotingOfficeNull()
    {
      return this.IsNull(this.tabletblLinesToCompany.QuotingOfficeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetQuotingOfficeNull()
    {
      this[this.tabletblLinesToCompany.QuotingOfficeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsReasonColorNull() => this.IsNull(this.tabletblLinesToCompany.ReasonColorColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetReasonColorNull()
    {
      this[this.tabletblLinesToCompany.ReasonColorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNeededByDateNull() => this.IsNull(this.tabletblLinesToCompany.NeededByDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNeededByDateNull()
    {
      this[this.tabletblLinesToCompany.NeededByDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblInsuredsRowChangeEvent : EventArgs
  {
    private dsInsuredNavigation.tblInsuredsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblInsuredsRowChangeEvent(dsInsuredNavigation.tblInsuredsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblInsuredsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblProducerSubmissionsRowChangeEvent : EventArgs
  {
    private dsInsuredNavigation.tblProducerSubmissionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblProducerSubmissionsRowChangeEvent(
      dsInsuredNavigation.tblProducerSubmissionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblProducerSubmissionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblLinesToCompanyRowChangeEvent : EventArgs
  {
    private dsInsuredNavigation.tblLinesToCompanyRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblLinesToCompanyRowChangeEvent(
      dsInsuredNavigation.tblLinesToCompanyRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredNavigation.tblLinesToCompanyRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
