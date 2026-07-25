// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyDetail.dsPolicyDetail_Premiums
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
namespace MGASystems.IMS.Policies.PolicyDetail;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPolicyDetail_Premiums")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPolicyDetail_Premiums : DataSet
{
  private dsPolicyDetail_Premiums.LinesOptionsDataTable tableLinesOptions;
  private dsPolicyDetail_Premiums.tblQuoteOptionsDataTable tabletblQuoteOptions;
  private dsPolicyDetail_Premiums.AllLinesOptionsDataTable tableAllLinesOptions;
  private dsPolicyDetail_Premiums.BoundOptionsDataTable tableBoundOptions;
  private dsPolicyDetail_Premiums.viewOptionPremiumsDataTable tableviewOptionPremiums;
  private DataRelation relationLinesOptionstblQuoteOptions;
  private DataRelation relationAllLinesOptionsBoundOptions;
  private DataRelation relationtblQuoteOptionsviewOptionPremiums1;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsPolicyDetail_Premiums()
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
  protected dsPolicyDetail_Premiums(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (LinesOptions)] != null)
          base.Tables.Add((DataTable) new dsPolicyDetail_Premiums.LinesOptionsDataTable(dataSet.Tables[nameof (LinesOptions)]));
        if (dataSet.Tables[nameof (tblQuoteOptions)] != null)
          base.Tables.Add((DataTable) new dsPolicyDetail_Premiums.tblQuoteOptionsDataTable(dataSet.Tables[nameof (tblQuoteOptions)]));
        if (dataSet.Tables[nameof (AllLinesOptions)] != null)
          base.Tables.Add((DataTable) new dsPolicyDetail_Premiums.AllLinesOptionsDataTable(dataSet.Tables[nameof (AllLinesOptions)]));
        if (dataSet.Tables[nameof (BoundOptions)] != null)
          base.Tables.Add((DataTable) new dsPolicyDetail_Premiums.BoundOptionsDataTable(dataSet.Tables[nameof (BoundOptions)]));
        if (dataSet.Tables[nameof (viewOptionPremiums)] != null)
          base.Tables.Add((DataTable) new dsPolicyDetail_Premiums.viewOptionPremiumsDataTable(dataSet.Tables[nameof (viewOptionPremiums)]));
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
  public dsPolicyDetail_Premiums.LinesOptionsDataTable LinesOptions => this.tableLinesOptions;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyDetail_Premiums.tblQuoteOptionsDataTable tblQuoteOptions
  {
    get => this.tabletblQuoteOptions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyDetail_Premiums.AllLinesOptionsDataTable AllLinesOptions
  {
    get => this.tableAllLinesOptions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyDetail_Premiums.BoundOptionsDataTable BoundOptions => this.tableBoundOptions;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyDetail_Premiums.viewOptionPremiumsDataTable viewOptionPremiums
  {
    get => this.tableviewOptionPremiums;
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
    dsPolicyDetail_Premiums policyDetailPremiums = (dsPolicyDetail_Premiums) base.Clone();
    policyDetailPremiums.InitVars();
    policyDetailPremiums.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) policyDetailPremiums;
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
      if (dataSet.Tables["LinesOptions"] != null)
        base.Tables.Add((DataTable) new dsPolicyDetail_Premiums.LinesOptionsDataTable(dataSet.Tables["LinesOptions"]));
      if (dataSet.Tables["tblQuoteOptions"] != null)
        base.Tables.Add((DataTable) new dsPolicyDetail_Premiums.tblQuoteOptionsDataTable(dataSet.Tables["tblQuoteOptions"]));
      if (dataSet.Tables["AllLinesOptions"] != null)
        base.Tables.Add((DataTable) new dsPolicyDetail_Premiums.AllLinesOptionsDataTable(dataSet.Tables["AllLinesOptions"]));
      if (dataSet.Tables["BoundOptions"] != null)
        base.Tables.Add((DataTable) new dsPolicyDetail_Premiums.BoundOptionsDataTable(dataSet.Tables["BoundOptions"]));
      if (dataSet.Tables["viewOptionPremiums"] != null)
        base.Tables.Add((DataTable) new dsPolicyDetail_Premiums.viewOptionPremiumsDataTable(dataSet.Tables["viewOptionPremiums"]));
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
    this.tableLinesOptions = (dsPolicyDetail_Premiums.LinesOptionsDataTable) base.Tables["LinesOptions"];
    if (initTable && this.tableLinesOptions != null)
      this.tableLinesOptions.InitVars();
    this.tabletblQuoteOptions = (dsPolicyDetail_Premiums.tblQuoteOptionsDataTable) base.Tables["tblQuoteOptions"];
    if (initTable && this.tabletblQuoteOptions != null)
      this.tabletblQuoteOptions.InitVars();
    this.tableAllLinesOptions = (dsPolicyDetail_Premiums.AllLinesOptionsDataTable) base.Tables["AllLinesOptions"];
    if (initTable && this.tableAllLinesOptions != null)
      this.tableAllLinesOptions.InitVars();
    this.tableBoundOptions = (dsPolicyDetail_Premiums.BoundOptionsDataTable) base.Tables["BoundOptions"];
    if (initTable && this.tableBoundOptions != null)
      this.tableBoundOptions.InitVars();
    this.tableviewOptionPremiums = (dsPolicyDetail_Premiums.viewOptionPremiumsDataTable) base.Tables["viewOptionPremiums"];
    if (initTable && this.tableviewOptionPremiums != null)
      this.tableviewOptionPremiums.InitVars();
    this.relationLinesOptionstblQuoteOptions = this.Relations["LinesOptionstblQuoteOptions"];
    this.relationAllLinesOptionsBoundOptions = this.Relations["AllLinesOptionsBoundOptions"];
    this.relationtblQuoteOptionsviewOptionPremiums1 = this.Relations["tblQuoteOptionsviewOptionPremiums1"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPolicyDetail_Premiums);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPolicyDetail_Premiums.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableLinesOptions = new dsPolicyDetail_Premiums.LinesOptionsDataTable();
    base.Tables.Add((DataTable) this.tableLinesOptions);
    this.tabletblQuoteOptions = new dsPolicyDetail_Premiums.tblQuoteOptionsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptions);
    this.tableAllLinesOptions = new dsPolicyDetail_Premiums.AllLinesOptionsDataTable();
    base.Tables.Add((DataTable) this.tableAllLinesOptions);
    this.tableBoundOptions = new dsPolicyDetail_Premiums.BoundOptionsDataTable();
    base.Tables.Add((DataTable) this.tableBoundOptions);
    this.tableviewOptionPremiums = new dsPolicyDetail_Premiums.viewOptionPremiumsDataTable();
    base.Tables.Add((DataTable) this.tableviewOptionPremiums);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("LinesOptionstblQuoteOptions", new DataColumn[2]
    {
      this.tableLinesOptions.LineGuidColumn,
      this.tableLinesOptions.CompanyLocationIDColumn
    }, new DataColumn[2]
    {
      this.tabletblQuoteOptions.LineGuidColumn,
      this.tabletblQuoteOptions.CompanyLocationIDColumn
    });
    this.tabletblQuoteOptions.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("AllLinesOptionsBoundOptions", new DataColumn[1]
    {
      this.tableAllLinesOptions.LineGuidColumn
    }, new DataColumn[1]
    {
      this.tableBoundOptions.LineGuidColumn
    });
    this.tableBoundOptions.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("tblQuoteOptionsviewOptionPremiums1", new DataColumn[1]
    {
      this.tabletblQuoteOptions.QuoteOptionGuidColumn
    }, new DataColumn[1]
    {
      this.tableviewOptionPremiums.QuoteOptionGuidColumn
    });
    this.tableviewOptionPremiums.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    this.relationLinesOptionstblQuoteOptions = new DataRelation("LinesOptionstblQuoteOptions", new DataColumn[2]
    {
      this.tableLinesOptions.LineGuidColumn,
      this.tableLinesOptions.CompanyLocationIDColumn
    }, new DataColumn[2]
    {
      this.tabletblQuoteOptions.LineGuidColumn,
      this.tabletblQuoteOptions.CompanyLocationIDColumn
    }, false);
    this.Relations.Add(this.relationLinesOptionstblQuoteOptions);
    this.relationAllLinesOptionsBoundOptions = new DataRelation("AllLinesOptionsBoundOptions", new DataColumn[1]
    {
      this.tableAllLinesOptions.LineGuidColumn
    }, new DataColumn[1]
    {
      this.tableBoundOptions.LineGuidColumn
    }, false);
    this.Relations.Add(this.relationAllLinesOptionsBoundOptions);
    this.relationtblQuoteOptionsviewOptionPremiums1 = new DataRelation("tblQuoteOptionsviewOptionPremiums1", new DataColumn[1]
    {
      this.tabletblQuoteOptions.QuoteOptionGuidColumn
    }, new DataColumn[1]
    {
      this.tableviewOptionPremiums.QuoteOptionGuidColumn
    }, false);
    this.Relations.Add(this.relationtblQuoteOptionsviewOptionPremiums1);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeLinesOptions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblQuoteOptions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeAllLinesOptions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeBoundOptions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeviewOptionPremiums() => false;

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
    dsPolicyDetail_Premiums policyDetailPremiums = new dsPolicyDetail_Premiums();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = policyDetailPremiums.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = policyDetailPremiums.GetSchemaSerializable();
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
  public delegate void LinesOptionsRowChangeEventHandler(
    object sender,
    dsPolicyDetail_Premiums.LinesOptionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblQuoteOptionsRowChangeEventHandler(
    object sender,
    dsPolicyDetail_Premiums.tblQuoteOptionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void AllLinesOptionsRowChangeEventHandler(
    object sender,
    dsPolicyDetail_Premiums.AllLinesOptionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void BoundOptionsRowChangeEventHandler(
    object sender,
    dsPolicyDetail_Premiums.BoundOptionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void viewOptionPremiumsRowChangeEventHandler(
    object sender,
    dsPolicyDetail_Premiums.viewOptionPremiumsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class LinesOptionsDataTable : TypedTableBase<dsPolicyDetail_Premiums.LinesOptionsRow>
  {
    private DataColumn columnLineGuid;
    private DataColumn columnCompanyLocationID;
    private DataColumn columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public LinesOptionsDataTable()
    {
      this.TableName = "LinesOptions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal LinesOptionsDataTable(DataTable table)
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
    protected LinesOptionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LineGuidColumn => this.columnLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLocationIDColumn => this.columnCompanyLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.LinesOptionsRow this[int index]
    {
      get => (dsPolicyDetail_Premiums.LinesOptionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.LinesOptionsRowChangeEventHandler LinesOptionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.LinesOptionsRowChangeEventHandler LinesOptionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.LinesOptionsRowChangeEventHandler LinesOptionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.LinesOptionsRowChangeEventHandler LinesOptionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddLinesOptionsRow(dsPolicyDetail_Premiums.LinesOptionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.LinesOptionsRow AddLinesOptionsRow(
      Guid LineGuid,
      int CompanyLocationID,
      string LineName)
    {
      dsPolicyDetail_Premiums.LinesOptionsRow row = (dsPolicyDetail_Premiums.LinesOptionsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) LineGuid,
        (object) CompanyLocationID,
        (object) LineName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.LinesOptionsRow FindByLineGuidCompanyLocationID(
      Guid LineGuid,
      int CompanyLocationID)
    {
      return (dsPolicyDetail_Premiums.LinesOptionsRow) this.Rows.Find(new object[2]
      {
        (object) LineGuid,
        (object) CompanyLocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyDetail_Premiums.LinesOptionsDataTable optionsDataTable = (dsPolicyDetail_Premiums.LinesOptionsDataTable) base.Clone();
      optionsDataTable.InitVars();
      return (DataTable) optionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyDetail_Premiums.LinesOptionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnLineGuid = this.Columns["LineGuid"];
      this.columnCompanyLocationID = this.Columns["CompanyLocationID"];
      this.columnLineName = this.Columns["LineName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnLineGuid = new DataColumn("LineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGuid);
      this.columnCompanyLocationID = new DataColumn("CompanyLocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationID);
      this.columnLineName = new DataColumn("LineName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyDetail_PremiumsKey1", new DataColumn[2]
      {
        this.columnLineGuid,
        this.columnCompanyLocationID
      }, true));
      this.columnLineGuid.AllowDBNull = false;
      this.columnCompanyLocationID.AllowDBNull = false;
      this.columnLineName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.LinesOptionsRow NewLinesOptionsRow()
    {
      return (dsPolicyDetail_Premiums.LinesOptionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyDetail_Premiums.LinesOptionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyDetail_Premiums.LinesOptionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LinesOptionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.LinesOptionsRowChangeEventHandler optionsRowChangedEvent = this.LinesOptionsRowChangedEvent;
      if (optionsRowChangedEvent == null)
        return;
      optionsRowChangedEvent((object) this, new dsPolicyDetail_Premiums.LinesOptionsRowChangeEvent((dsPolicyDetail_Premiums.LinesOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LinesOptionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.LinesOptionsRowChangeEventHandler rowChangingEvent = this.LinesOptionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyDetail_Premiums.LinesOptionsRowChangeEvent((dsPolicyDetail_Premiums.LinesOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LinesOptionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.LinesOptionsRowChangeEventHandler optionsRowDeletedEvent = this.LinesOptionsRowDeletedEvent;
      if (optionsRowDeletedEvent == null)
        return;
      optionsRowDeletedEvent((object) this, new dsPolicyDetail_Premiums.LinesOptionsRowChangeEvent((dsPolicyDetail_Premiums.LinesOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LinesOptionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.LinesOptionsRowChangeEventHandler rowDeletingEvent = this.LinesOptionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyDetail_Premiums.LinesOptionsRowChangeEvent((dsPolicyDetail_Premiums.LinesOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveLinesOptionsRow(dsPolicyDetail_Premiums.LinesOptionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyDetail_Premiums policyDetailPremiums = new dsPolicyDetail_Premiums();
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
        FixedValue = policyDetailPremiums.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (LinesOptionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyDetailPremiums.GetSchemaSerializable();
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
  public class tblQuoteOptionsDataTable : TypedTableBase<dsPolicyDetail_Premiums.tblQuoteOptionsRow>
  {
    private DataColumn columnQuoteOptionGuid;
    private DataColumn columnLineGuid;
    private DataColumn columnCompanyLocationID;
    private DataColumn columnPremium;
    private DataColumn columnDateCreated;
    private DataColumn columnBound;
    private DataColumn columnQuote;
    private DataColumn columnFees;
    private DataColumn columnbtnOptionDetail;
    private DataColumn columnInstallmentSetup;
    private DataColumn columnCurrencyCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuoteOptionsDataTable()
    {
      this.TableName = "tblQuoteOptions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuoteOptionsDataTable(DataTable table)
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
    protected tblQuoteOptionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteOptionGuidColumn => this.columnQuoteOptionGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LineGuidColumn => this.columnLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLocationIDColumn => this.columnCompanyLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateCreatedColumn => this.columnDateCreated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BoundColumn => this.columnBound;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteColumn => this.columnQuote;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FeesColumn => this.columnFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn btnOptionDetailColumn => this.columnbtnOptionDetail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InstallmentSetupColumn => this.columnInstallmentSetup;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CurrencyCodeColumn => this.columnCurrencyCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.tblQuoteOptionsRow this[int index]
    {
      get => (dsPolicyDetail_Premiums.tblQuoteOptionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblQuoteOptionsRow(dsPolicyDetail_Premiums.tblQuoteOptionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.tblQuoteOptionsRow AddtblQuoteOptionsRow(
      Guid QuoteOptionGuid,
      Guid LineGuid,
      int CompanyLocationID,
      Decimal Premium,
      DateTime DateCreated,
      bool Bound,
      bool Quote,
      Decimal Fees,
      string btnOptionDetail,
      string InstallmentSetup,
      string CurrencyCode)
    {
      dsPolicyDetail_Premiums.tblQuoteOptionsRow row = (dsPolicyDetail_Premiums.tblQuoteOptionsRow) this.NewRow();
      object[] objArray = new object[11]
      {
        (object) QuoteOptionGuid,
        (object) LineGuid,
        (object) CompanyLocationID,
        (object) Premium,
        (object) DateCreated,
        (object) Bound,
        (object) Quote,
        (object) Fees,
        (object) btnOptionDetail,
        (object) InstallmentSetup,
        (object) CurrencyCode
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.tblQuoteOptionsRow FindByQuoteOptionGuid(Guid QuoteOptionGuid)
    {
      return (dsPolicyDetail_Premiums.tblQuoteOptionsRow) this.Rows.Find(new object[1]
      {
        (object) QuoteOptionGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyDetail_Premiums.tblQuoteOptionsDataTable optionsDataTable = (dsPolicyDetail_Premiums.tblQuoteOptionsDataTable) base.Clone();
      optionsDataTable.InitVars();
      return (DataTable) optionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyDetail_Premiums.tblQuoteOptionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteOptionGuid = this.Columns["QuoteOptionGuid"];
      this.columnLineGuid = this.Columns["LineGuid"];
      this.columnCompanyLocationID = this.Columns["CompanyLocationID"];
      this.columnPremium = this.Columns["Premium"];
      this.columnDateCreated = this.Columns["DateCreated"];
      this.columnBound = this.Columns["Bound"];
      this.columnQuote = this.Columns["Quote"];
      this.columnFees = this.Columns["Fees"];
      this.columnbtnOptionDetail = this.Columns["btnOptionDetail"];
      this.columnInstallmentSetup = this.Columns["InstallmentSetup"];
      this.columnCurrencyCode = this.Columns["CurrencyCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteOptionGuid = new DataColumn("QuoteOptionGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionGuid);
      this.columnLineGuid = new DataColumn("LineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGuid);
      this.columnCompanyLocationID = new DataColumn("CompanyLocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationID);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnDateCreated = new DataColumn("DateCreated", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateCreated);
      this.columnBound = new DataColumn("Bound", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBound);
      this.columnQuote = new DataColumn("Quote", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuote);
      this.columnFees = new DataColumn("Fees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFees);
      this.columnbtnOptionDetail = new DataColumn("btnOptionDetail", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnbtnOptionDetail);
      this.columnInstallmentSetup = new DataColumn("InstallmentSetup", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInstallmentSetup);
      this.columnCurrencyCode = new DataColumn("CurrencyCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCurrencyCode);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyDetail_PremiumsKey2", new DataColumn[1]
      {
        this.columnQuoteOptionGuid
      }, true));
      this.columnQuoteOptionGuid.AllowDBNull = false;
      this.columnQuoteOptionGuid.Unique = true;
      this.columnLineGuid.AllowDBNull = false;
      this.columnPremium.AllowDBNull = false;
      this.columnDateCreated.AllowDBNull = false;
      this.columnBound.AllowDBNull = false;
      this.columnQuote.AllowDBNull = false;
      this.columnFees.AllowDBNull = false;
      this.columnbtnOptionDetail.AllowDBNull = false;
      this.columnbtnOptionDetail.DefaultValue = (object) "Detail";
      this.columnInstallmentSetup.AllowDBNull = false;
      this.columnInstallmentSetup.DefaultValue = (object) "Installment Billing";
      this.columnCurrencyCode.DefaultValue = (object) "USD";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.tblQuoteOptionsRow NewtblQuoteOptionsRow()
    {
      return (dsPolicyDetail_Premiums.tblQuoteOptionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyDetail_Premiums.tblQuoteOptionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyDetail_Premiums.tblQuoteOptionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.tblQuoteOptionsRowChangeEventHandler optionsRowChangedEvent = this.tblQuoteOptionsRowChangedEvent;
      if (optionsRowChangedEvent == null)
        return;
      optionsRowChangedEvent((object) this, new dsPolicyDetail_Premiums.tblQuoteOptionsRowChangeEvent((dsPolicyDetail_Premiums.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.tblQuoteOptionsRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyDetail_Premiums.tblQuoteOptionsRowChangeEvent((dsPolicyDetail_Premiums.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.tblQuoteOptionsRowChangeEventHandler optionsRowDeletedEvent = this.tblQuoteOptionsRowDeletedEvent;
      if (optionsRowDeletedEvent == null)
        return;
      optionsRowDeletedEvent((object) this, new dsPolicyDetail_Premiums.tblQuoteOptionsRowChangeEvent((dsPolicyDetail_Premiums.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.tblQuoteOptionsRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyDetail_Premiums.tblQuoteOptionsRowChangeEvent((dsPolicyDetail_Premiums.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblQuoteOptionsRow(dsPolicyDetail_Premiums.tblQuoteOptionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyDetail_Premiums policyDetailPremiums = new dsPolicyDetail_Premiums();
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
        FixedValue = policyDetailPremiums.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyDetailPremiums.GetSchemaSerializable();
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
  public class AllLinesOptionsDataTable : TypedTableBase<dsPolicyDetail_Premiums.AllLinesOptionsRow>
  {
    private DataColumn columnLineGuid;
    private DataColumn columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public AllLinesOptionsDataTable()
    {
      this.TableName = "AllLinesOptions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal AllLinesOptionsDataTable(DataTable table)
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
    protected AllLinesOptionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LineGuidColumn => this.columnLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.AllLinesOptionsRow this[int index]
    {
      get => (dsPolicyDetail_Premiums.AllLinesOptionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.AllLinesOptionsRowChangeEventHandler AllLinesOptionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.AllLinesOptionsRowChangeEventHandler AllLinesOptionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.AllLinesOptionsRowChangeEventHandler AllLinesOptionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.AllLinesOptionsRowChangeEventHandler AllLinesOptionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddAllLinesOptionsRow(dsPolicyDetail_Premiums.AllLinesOptionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.AllLinesOptionsRow AddAllLinesOptionsRow(
      Guid LineGuid,
      string LineName)
    {
      dsPolicyDetail_Premiums.AllLinesOptionsRow row = (dsPolicyDetail_Premiums.AllLinesOptionsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) LineGuid,
        (object) LineName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.AllLinesOptionsRow FindByLineGuid(Guid LineGuid)
    {
      return (dsPolicyDetail_Premiums.AllLinesOptionsRow) this.Rows.Find(new object[1]
      {
        (object) LineGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyDetail_Premiums.AllLinesOptionsDataTable optionsDataTable = (dsPolicyDetail_Premiums.AllLinesOptionsDataTable) base.Clone();
      optionsDataTable.InitVars();
      return (DataTable) optionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyDetail_Premiums.AllLinesOptionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnLineGuid = this.Columns["LineGuid"];
      this.columnLineName = this.Columns["LineName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnLineGuid = new DataColumn("LineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGuid);
      this.columnLineName = new DataColumn("LineName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyDetail_PremiumsKey3", new DataColumn[1]
      {
        this.columnLineGuid
      }, true));
      this.columnLineGuid.AllowDBNull = false;
      this.columnLineGuid.Unique = true;
      this.columnLineName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.AllLinesOptionsRow NewAllLinesOptionsRow()
    {
      return (dsPolicyDetail_Premiums.AllLinesOptionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyDetail_Premiums.AllLinesOptionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyDetail_Premiums.AllLinesOptionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AllLinesOptionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.AllLinesOptionsRowChangeEventHandler optionsRowChangedEvent = this.AllLinesOptionsRowChangedEvent;
      if (optionsRowChangedEvent == null)
        return;
      optionsRowChangedEvent((object) this, new dsPolicyDetail_Premiums.AllLinesOptionsRowChangeEvent((dsPolicyDetail_Premiums.AllLinesOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AllLinesOptionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.AllLinesOptionsRowChangeEventHandler rowChangingEvent = this.AllLinesOptionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyDetail_Premiums.AllLinesOptionsRowChangeEvent((dsPolicyDetail_Premiums.AllLinesOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AllLinesOptionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.AllLinesOptionsRowChangeEventHandler optionsRowDeletedEvent = this.AllLinesOptionsRowDeletedEvent;
      if (optionsRowDeletedEvent == null)
        return;
      optionsRowDeletedEvent((object) this, new dsPolicyDetail_Premiums.AllLinesOptionsRowChangeEvent((dsPolicyDetail_Premiums.AllLinesOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AllLinesOptionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.AllLinesOptionsRowChangeEventHandler rowDeletingEvent = this.AllLinesOptionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyDetail_Premiums.AllLinesOptionsRowChangeEvent((dsPolicyDetail_Premiums.AllLinesOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveAllLinesOptionsRow(dsPolicyDetail_Premiums.AllLinesOptionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyDetail_Premiums policyDetailPremiums = new dsPolicyDetail_Premiums();
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
        FixedValue = policyDetailPremiums.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (AllLinesOptionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyDetailPremiums.GetSchemaSerializable();
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
  public class BoundOptionsDataTable : TypedTableBase<dsPolicyDetail_Premiums.BoundOptionsRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnChargeName;
    private DataColumn columnPremium;
    private DataColumn columnLocation;
    private DataColumn columnLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public BoundOptionsDataTable()
    {
      this.TableName = "BoundOptions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal BoundOptionsDataTable(DataTable table)
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
    protected BoundOptionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LineGuidColumn => this.columnLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.BoundOptionsRow this[int index]
    {
      get => (dsPolicyDetail_Premiums.BoundOptionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.BoundOptionsRowChangeEventHandler BoundOptionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.BoundOptionsRowChangeEventHandler BoundOptionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.BoundOptionsRowChangeEventHandler BoundOptionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.BoundOptionsRowChangeEventHandler BoundOptionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddBoundOptionsRow(dsPolicyDetail_Premiums.BoundOptionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.BoundOptionsRow AddBoundOptionsRow(
      string StateID,
      string ChargeName,
      Decimal Premium,
      string Location,
      dsPolicyDetail_Premiums.AllLinesOptionsRow parentAllLinesOptionsRowByAllLinesOptionsBoundOptions)
    {
      dsPolicyDetail_Premiums.BoundOptionsRow row = (dsPolicyDetail_Premiums.BoundOptionsRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) StateID,
        (object) ChargeName,
        (object) Premium,
        (object) Location,
        null
      };
      if (parentAllLinesOptionsRowByAllLinesOptionsBoundOptions != null)
        objArray[4] = RuntimeHelpers.GetObjectValue(parentAllLinesOptionsRowByAllLinesOptionsBoundOptions[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyDetail_Premiums.BoundOptionsDataTable optionsDataTable = (dsPolicyDetail_Premiums.BoundOptionsDataTable) base.Clone();
      optionsDataTable.InitVars();
      return (DataTable) optionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyDetail_Premiums.BoundOptionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnPremium = this.Columns["Premium"];
      this.columnLocation = this.Columns["Location"];
      this.columnLineGuid = this.Columns["LineGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.columnLineGuid = new DataColumn("LineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGuid);
      this.columnChargeName.AllowDBNull = false;
      this.columnPremium.AllowDBNull = false;
      this.columnLocation.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.BoundOptionsRow NewBoundOptionsRow()
    {
      return (dsPolicyDetail_Premiums.BoundOptionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyDetail_Premiums.BoundOptionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyDetail_Premiums.BoundOptionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BoundOptionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.BoundOptionsRowChangeEventHandler optionsRowChangedEvent = this.BoundOptionsRowChangedEvent;
      if (optionsRowChangedEvent == null)
        return;
      optionsRowChangedEvent((object) this, new dsPolicyDetail_Premiums.BoundOptionsRowChangeEvent((dsPolicyDetail_Premiums.BoundOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BoundOptionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.BoundOptionsRowChangeEventHandler rowChangingEvent = this.BoundOptionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyDetail_Premiums.BoundOptionsRowChangeEvent((dsPolicyDetail_Premiums.BoundOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BoundOptionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.BoundOptionsRowChangeEventHandler optionsRowDeletedEvent = this.BoundOptionsRowDeletedEvent;
      if (optionsRowDeletedEvent == null)
        return;
      optionsRowDeletedEvent((object) this, new dsPolicyDetail_Premiums.BoundOptionsRowChangeEvent((dsPolicyDetail_Premiums.BoundOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BoundOptionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.BoundOptionsRowChangeEventHandler rowDeletingEvent = this.BoundOptionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyDetail_Premiums.BoundOptionsRowChangeEvent((dsPolicyDetail_Premiums.BoundOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveBoundOptionsRow(dsPolicyDetail_Premiums.BoundOptionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyDetail_Premiums policyDetailPremiums = new dsPolicyDetail_Premiums();
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
        FixedValue = policyDetailPremiums.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (BoundOptionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyDetailPremiums.GetSchemaSerializable();
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
  public class viewOptionPremiumsDataTable : 
    TypedTableBase<dsPolicyDetail_Premiums.viewOptionPremiumsRow>
  {
    private DataColumn columnQuoteOptionGuid;
    private DataColumn columnStateID;
    private DataColumn columnChargeName;
    private DataColumn columnPremium;
    private DataColumn columnLocation;
    private DataColumn columnCurrencyCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public viewOptionPremiumsDataTable()
    {
      this.TableName = "viewOptionPremiums";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal viewOptionPremiumsDataTable(DataTable table)
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
    protected viewOptionPremiumsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteOptionGuidColumn => this.columnQuoteOptionGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CurrencyCodeColumn => this.columnCurrencyCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.viewOptionPremiumsRow this[int index]
    {
      get => (dsPolicyDetail_Premiums.viewOptionPremiumsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.viewOptionPremiumsRowChangeEventHandler viewOptionPremiumsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.viewOptionPremiumsRowChangeEventHandler viewOptionPremiumsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.viewOptionPremiumsRowChangeEventHandler viewOptionPremiumsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_Premiums.viewOptionPremiumsRowChangeEventHandler viewOptionPremiumsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddviewOptionPremiumsRow(dsPolicyDetail_Premiums.viewOptionPremiumsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.viewOptionPremiumsRow AddviewOptionPremiumsRow(
      dsPolicyDetail_Premiums.tblQuoteOptionsRow parenttblQuoteOptionsRowBytblQuoteOptionsviewOptionPremiums1,
      string StateID,
      string ChargeName,
      Decimal Premium,
      string Location,
      string CurrencyCode)
    {
      dsPolicyDetail_Premiums.viewOptionPremiumsRow row = (dsPolicyDetail_Premiums.viewOptionPremiumsRow) this.NewRow();
      object[] objArray = new object[6]
      {
        null,
        (object) StateID,
        (object) ChargeName,
        (object) Premium,
        (object) Location,
        (object) CurrencyCode
      };
      if (parenttblQuoteOptionsRowBytblQuoteOptionsviewOptionPremiums1 != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblQuoteOptionsRowBytblQuoteOptionsviewOptionPremiums1[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyDetail_Premiums.viewOptionPremiumsDataTable premiumsDataTable = (dsPolicyDetail_Premiums.viewOptionPremiumsDataTable) base.Clone();
      premiumsDataTable.InitVars();
      return (DataTable) premiumsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyDetail_Premiums.viewOptionPremiumsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteOptionGuid = this.Columns["QuoteOptionGuid"];
      this.columnStateID = this.Columns["StateID"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnPremium = this.Columns["Premium"];
      this.columnLocation = this.Columns["Location"];
      this.columnCurrencyCode = this.Columns["CurrencyCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteOptionGuid = new DataColumn("QuoteOptionGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionGuid);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.columnCurrencyCode = new DataColumn("CurrencyCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCurrencyCode);
      this.columnQuoteOptionGuid.AllowDBNull = false;
      this.columnChargeName.AllowDBNull = false;
      this.columnPremium.AllowDBNull = false;
      this.columnLocation.AllowDBNull = false;
      this.columnCurrencyCode.DefaultValue = (object) "USD";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.viewOptionPremiumsRow NewviewOptionPremiumsRow()
    {
      return (dsPolicyDetail_Premiums.viewOptionPremiumsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyDetail_Premiums.viewOptionPremiumsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyDetail_Premiums.viewOptionPremiumsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.viewOptionPremiumsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.viewOptionPremiumsRowChangeEventHandler premiumsRowChangedEvent = this.viewOptionPremiumsRowChangedEvent;
      if (premiumsRowChangedEvent == null)
        return;
      premiumsRowChangedEvent((object) this, new dsPolicyDetail_Premiums.viewOptionPremiumsRowChangeEvent((dsPolicyDetail_Premiums.viewOptionPremiumsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.viewOptionPremiumsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.viewOptionPremiumsRowChangeEventHandler rowChangingEvent = this.viewOptionPremiumsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyDetail_Premiums.viewOptionPremiumsRowChangeEvent((dsPolicyDetail_Premiums.viewOptionPremiumsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.viewOptionPremiumsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.viewOptionPremiumsRowChangeEventHandler premiumsRowDeletedEvent = this.viewOptionPremiumsRowDeletedEvent;
      if (premiumsRowDeletedEvent == null)
        return;
      premiumsRowDeletedEvent((object) this, new dsPolicyDetail_Premiums.viewOptionPremiumsRowChangeEvent((dsPolicyDetail_Premiums.viewOptionPremiumsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.viewOptionPremiumsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_Premiums.viewOptionPremiumsRowChangeEventHandler rowDeletingEvent = this.viewOptionPremiumsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyDetail_Premiums.viewOptionPremiumsRowChangeEvent((dsPolicyDetail_Premiums.viewOptionPremiumsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveviewOptionPremiumsRow(dsPolicyDetail_Premiums.viewOptionPremiumsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyDetail_Premiums policyDetailPremiums = new dsPolicyDetail_Premiums();
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
        FixedValue = policyDetailPremiums.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (viewOptionPremiumsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = policyDetailPremiums.GetSchemaSerializable();
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

  public class LinesOptionsRow : DataRow
  {
    private dsPolicyDetail_Premiums.LinesOptionsDataTable tableLinesOptions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal LinesOptionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableLinesOptions = (dsPolicyDetail_Premiums.LinesOptionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid LineGuid
    {
      get
      {
        object obj = this[this.tableLinesOptions.LineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableLinesOptions.LineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CompanyLocationID
    {
      get => Conversions.ToInteger(this[this.tableLinesOptions.CompanyLocationIDColumn]);
      set => this[this.tableLinesOptions.CompanyLocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LineName
    {
      get => Conversions.ToString(this[this.tableLinesOptions.LineNameColumn]);
      set => this[this.tableLinesOptions.LineNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.tblQuoteOptionsRow[] GettblQuoteOptionsRows()
    {
      return this.Table.ChildRelations["LinesOptionstblQuoteOptions"] != null ? (dsPolicyDetail_Premiums.tblQuoteOptionsRow[]) this.GetChildRows(this.Table.ChildRelations["LinesOptionstblQuoteOptions"]) : new dsPolicyDetail_Premiums.tblQuoteOptionsRow[0];
    }
  }

  public class tblQuoteOptionsRow : DataRow
  {
    private dsPolicyDetail_Premiums.tblQuoteOptionsDataTable tabletblQuoteOptions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuoteOptionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptions = (dsPolicyDetail_Premiums.tblQuoteOptionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid QuoteOptionGuid
    {
      get
      {
        object obj = this[this.tabletblQuoteOptions.QuoteOptionGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptions.QuoteOptionGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid LineGuid
    {
      get
      {
        object obj = this[this.tabletblQuoteOptions.LineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptions.LineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CompanyLocationID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptions.CompanyLocationIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLocationID' in table 'tblQuoteOptions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptions.CompanyLocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Premium
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptions.PremiumColumn]);
      set => this[this.tabletblQuoteOptions.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateCreated
    {
      get => Conversions.ToDate(this[this.tabletblQuoteOptions.DateCreatedColumn]);
      set => this[this.tabletblQuoteOptions.DateCreatedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Bound
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptions.BoundColumn]);
      set => this[this.tabletblQuoteOptions.BoundColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Quote
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptions.QuoteColumn]);
      set => this[this.tabletblQuoteOptions.QuoteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Fees
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptions.FeesColumn]);
      set => this[this.tabletblQuoteOptions.FeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string btnOptionDetail
    {
      get => Conversions.ToString(this[this.tabletblQuoteOptions.btnOptionDetailColumn]);
      set => this[this.tabletblQuoteOptions.btnOptionDetailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InstallmentSetup
    {
      get => Conversions.ToString(this[this.tabletblQuoteOptions.InstallmentSetupColumn]);
      set => this[this.tabletblQuoteOptions.InstallmentSetupColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CurrencyCode
    {
      get
      {
        return !this.IsCurrencyCodeNull() ? Conversions.ToString(this[this.tabletblQuoteOptions.CurrencyCodeColumn]) : "USD";
      }
      set => this[this.tabletblQuoteOptions.CurrencyCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.LinesOptionsRow LinesOptionsRowParent
    {
      get
      {
        return (dsPolicyDetail_Premiums.LinesOptionsRow) this.GetParentRow(this.Table.ParentRelations["LinesOptionstblQuoteOptions"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["LinesOptionstblQuoteOptions"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyLocationIDNull()
    {
      return this.IsNull(this.tabletblQuoteOptions.CompanyLocationIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyLocationIDNull()
    {
      this[this.tabletblQuoteOptions.CompanyLocationIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCurrencyCodeNull() => this.IsNull(this.tabletblQuoteOptions.CurrencyCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCurrencyCodeNull()
    {
      this[this.tabletblQuoteOptions.CurrencyCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.viewOptionPremiumsRow[] GetviewOptionPremiumsRows()
    {
      return this.Table.ChildRelations["tblQuoteOptionsviewOptionPremiums1"] != null ? (dsPolicyDetail_Premiums.viewOptionPremiumsRow[]) this.GetChildRows(this.Table.ChildRelations["tblQuoteOptionsviewOptionPremiums1"]) : new dsPolicyDetail_Premiums.viewOptionPremiumsRow[0];
    }
  }

  public class AllLinesOptionsRow : DataRow
  {
    private dsPolicyDetail_Premiums.AllLinesOptionsDataTable tableAllLinesOptions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal AllLinesOptionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAllLinesOptions = (dsPolicyDetail_Premiums.AllLinesOptionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid LineGuid
    {
      get
      {
        object obj = this[this.tableAllLinesOptions.LineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableAllLinesOptions.LineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LineName
    {
      get => Conversions.ToString(this[this.tableAllLinesOptions.LineNameColumn]);
      set => this[this.tableAllLinesOptions.LineNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.BoundOptionsRow[] GetBoundOptionsRows()
    {
      return this.Table.ChildRelations["AllLinesOptionsBoundOptions"] != null ? (dsPolicyDetail_Premiums.BoundOptionsRow[]) this.GetChildRows(this.Table.ChildRelations["AllLinesOptionsBoundOptions"]) : new dsPolicyDetail_Premiums.BoundOptionsRow[0];
    }
  }

  public class BoundOptionsRow : DataRow
  {
    private dsPolicyDetail_Premiums.BoundOptionsDataTable tableBoundOptions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal BoundOptionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableBoundOptions = (dsPolicyDetail_Premiums.BoundOptionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBoundOptions.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'BoundOptions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBoundOptions.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ChargeName
    {
      get => Conversions.ToString(this[this.tableBoundOptions.ChargeNameColumn]);
      set => this[this.tableBoundOptions.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Premium
    {
      get => Conversions.ToDecimal(this[this.tableBoundOptions.PremiumColumn]);
      set => this[this.tableBoundOptions.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Location
    {
      get => Conversions.ToString(this[this.tableBoundOptions.LocationColumn]);
      set => this[this.tableBoundOptions.LocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid LineGuid
    {
      get
      {
        try
        {
          object obj = this[this.tableBoundOptions.LineGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LineGuid' in table 'BoundOptions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBoundOptions.LineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.AllLinesOptionsRow AllLinesOptionsRow
    {
      get
      {
        return (dsPolicyDetail_Premiums.AllLinesOptionsRow) this.GetParentRow(this.Table.ParentRelations["AllLinesOptionsBoundOptions"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["AllLinesOptionsBoundOptions"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tableBoundOptions.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tableBoundOptions.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLineGuidNull() => this.IsNull(this.tableBoundOptions.LineGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLineGuidNull()
    {
      this[this.tableBoundOptions.LineGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class viewOptionPremiumsRow : DataRow
  {
    private dsPolicyDetail_Premiums.viewOptionPremiumsDataTable tableviewOptionPremiums;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal viewOptionPremiumsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableviewOptionPremiums = (dsPolicyDetail_Premiums.viewOptionPremiumsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid QuoteOptionGuid
    {
      get
      {
        object obj = this[this.tableviewOptionPremiums.QuoteOptionGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableviewOptionPremiums.QuoteOptionGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableviewOptionPremiums.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'viewOptionPremiums' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewOptionPremiums.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ChargeName
    {
      get => Conversions.ToString(this[this.tableviewOptionPremiums.ChargeNameColumn]);
      set => this[this.tableviewOptionPremiums.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Premium
    {
      get => Conversions.ToDecimal(this[this.tableviewOptionPremiums.PremiumColumn]);
      set => this[this.tableviewOptionPremiums.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Location
    {
      get => Conversions.ToString(this[this.tableviewOptionPremiums.LocationColumn]);
      set => this[this.tableviewOptionPremiums.LocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CurrencyCode
    {
      get
      {
        return !this.IsCurrencyCodeNull() ? Conversions.ToString(this[this.tableviewOptionPremiums.CurrencyCodeColumn]) : "USD";
      }
      set => this[this.tableviewOptionPremiums.CurrencyCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.tblQuoteOptionsRow tblQuoteOptionsRow
    {
      get
      {
        return (dsPolicyDetail_Premiums.tblQuoteOptionsRow) this.GetParentRow(this.Table.ParentRelations["tblQuoteOptionsviewOptionPremiums1"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblQuoteOptionsviewOptionPremiums1"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tableviewOptionPremiums.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tableviewOptionPremiums.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCurrencyCodeNull()
    {
      return this.IsNull(this.tableviewOptionPremiums.CurrencyCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCurrencyCodeNull()
    {
      this[this.tableviewOptionPremiums.CurrencyCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class LinesOptionsRowChangeEvent : EventArgs
  {
    private dsPolicyDetail_Premiums.LinesOptionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public LinesOptionsRowChangeEvent(
      dsPolicyDetail_Premiums.LinesOptionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.LinesOptionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblQuoteOptionsRowChangeEvent : EventArgs
  {
    private dsPolicyDetail_Premiums.tblQuoteOptionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuoteOptionsRowChangeEvent(
      dsPolicyDetail_Premiums.tblQuoteOptionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.tblQuoteOptionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class AllLinesOptionsRowChangeEvent : EventArgs
  {
    private dsPolicyDetail_Premiums.AllLinesOptionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public AllLinesOptionsRowChangeEvent(
      dsPolicyDetail_Premiums.AllLinesOptionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.AllLinesOptionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class BoundOptionsRowChangeEvent : EventArgs
  {
    private dsPolicyDetail_Premiums.BoundOptionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public BoundOptionsRowChangeEvent(
      dsPolicyDetail_Premiums.BoundOptionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.BoundOptionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class viewOptionPremiumsRowChangeEvent : EventArgs
  {
    private dsPolicyDetail_Premiums.viewOptionPremiumsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public viewOptionPremiumsRowChangeEvent(
      dsPolicyDetail_Premiums.viewOptionPremiumsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_Premiums.viewOptionPremiumsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
