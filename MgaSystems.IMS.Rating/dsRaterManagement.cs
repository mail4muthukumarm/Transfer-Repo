// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.dsRaterManagement
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

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
namespace MGASystems.IMS.Policies.Rating;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsRaterManagement")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsRaterManagement : DataSet
{
  private dsRaterManagement.tblFactorSetsFilterableDataTable tabletblFactorSetsFilterable;
  private dsRaterManagement.lstRatingTypesDataTable tablelstRatingTypes;
  private dsRaterManagement.tblCompaniesDataTable tabletblCompanies;
  private dsRaterManagement.tblCompanyLinesDataTable tabletblCompanyLines;
  private dsRaterManagement.tblCompanyLocationsDataTable tabletblCompanyLocations;
  private dsRaterManagement.tblFactorSetsDataTable tabletblFactorSets;
  private DataRelation relationtblCompanyLineslstRatingTypes;
  private DataRelation relationtblCompanyLocationstblCompanyLines;
  private DataRelation relationtblCompaniestblCompanyLocations;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsRaterManagement()
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
  protected dsRaterManagement(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblFactorSetsFilterable)] != null)
          base.Tables.Add((DataTable) new dsRaterManagement.tblFactorSetsFilterableDataTable(dataSet.Tables[nameof (tblFactorSetsFilterable)]));
        if (dataSet.Tables[nameof (lstRatingTypes)] != null)
          base.Tables.Add((DataTable) new dsRaterManagement.lstRatingTypesDataTable(dataSet.Tables[nameof (lstRatingTypes)]));
        if (dataSet.Tables[nameof (tblCompanies)] != null)
          base.Tables.Add((DataTable) new dsRaterManagement.tblCompaniesDataTable(dataSet.Tables[nameof (tblCompanies)]));
        if (dataSet.Tables[nameof (tblCompanyLines)] != null)
          base.Tables.Add((DataTable) new dsRaterManagement.tblCompanyLinesDataTable(dataSet.Tables[nameof (tblCompanyLines)]));
        if (dataSet.Tables[nameof (tblCompanyLocations)] != null)
          base.Tables.Add((DataTable) new dsRaterManagement.tblCompanyLocationsDataTable(dataSet.Tables[nameof (tblCompanyLocations)]));
        if (dataSet.Tables[nameof (tblFactorSets)] != null)
          base.Tables.Add((DataTable) new dsRaterManagement.tblFactorSetsDataTable(dataSet.Tables[nameof (tblFactorSets)]));
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
  public dsRaterManagement.tblFactorSetsFilterableDataTable tblFactorSetsFilterable
  {
    get => this.tabletblFactorSetsFilterable;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRaterManagement.lstRatingTypesDataTable lstRatingTypes => this.tablelstRatingTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRaterManagement.tblCompaniesDataTable tblCompanies => this.tabletblCompanies;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRaterManagement.tblCompanyLinesDataTable tblCompanyLines => this.tabletblCompanyLines;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRaterManagement.tblCompanyLocationsDataTable tblCompanyLocations
  {
    get => this.tabletblCompanyLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRaterManagement.tblFactorSetsDataTable tblFactorSets => this.tabletblFactorSets;

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
    dsRaterManagement dsRaterManagement = (dsRaterManagement) base.Clone();
    dsRaterManagement.InitVars();
    dsRaterManagement.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsRaterManagement;
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
      if (dataSet.Tables["tblFactorSetsFilterable"] != null)
        base.Tables.Add((DataTable) new dsRaterManagement.tblFactorSetsFilterableDataTable(dataSet.Tables["tblFactorSetsFilterable"]));
      if (dataSet.Tables["lstRatingTypes"] != null)
        base.Tables.Add((DataTable) new dsRaterManagement.lstRatingTypesDataTable(dataSet.Tables["lstRatingTypes"]));
      if (dataSet.Tables["tblCompanies"] != null)
        base.Tables.Add((DataTable) new dsRaterManagement.tblCompaniesDataTable(dataSet.Tables["tblCompanies"]));
      if (dataSet.Tables["tblCompanyLines"] != null)
        base.Tables.Add((DataTable) new dsRaterManagement.tblCompanyLinesDataTable(dataSet.Tables["tblCompanyLines"]));
      if (dataSet.Tables["tblCompanyLocations"] != null)
        base.Tables.Add((DataTable) new dsRaterManagement.tblCompanyLocationsDataTable(dataSet.Tables["tblCompanyLocations"]));
      if (dataSet.Tables["tblFactorSets"] != null)
        base.Tables.Add((DataTable) new dsRaterManagement.tblFactorSetsDataTable(dataSet.Tables["tblFactorSets"]));
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
    this.tabletblFactorSetsFilterable = (dsRaterManagement.tblFactorSetsFilterableDataTable) base.Tables["tblFactorSetsFilterable"];
    if (initTable && this.tabletblFactorSetsFilterable != null)
      this.tabletblFactorSetsFilterable.InitVars();
    this.tablelstRatingTypes = (dsRaterManagement.lstRatingTypesDataTable) base.Tables["lstRatingTypes"];
    if (initTable && this.tablelstRatingTypes != null)
      this.tablelstRatingTypes.InitVars();
    this.tabletblCompanies = (dsRaterManagement.tblCompaniesDataTable) base.Tables["tblCompanies"];
    if (initTable && this.tabletblCompanies != null)
      this.tabletblCompanies.InitVars();
    this.tabletblCompanyLines = (dsRaterManagement.tblCompanyLinesDataTable) base.Tables["tblCompanyLines"];
    if (initTable && this.tabletblCompanyLines != null)
      this.tabletblCompanyLines.InitVars();
    this.tabletblCompanyLocations = (dsRaterManagement.tblCompanyLocationsDataTable) base.Tables["tblCompanyLocations"];
    if (initTable && this.tabletblCompanyLocations != null)
      this.tabletblCompanyLocations.InitVars();
    this.tabletblFactorSets = (dsRaterManagement.tblFactorSetsDataTable) base.Tables["tblFactorSets"];
    if (initTable && this.tabletblFactorSets != null)
      this.tabletblFactorSets.InitVars();
    this.relationtblCompanyLineslstRatingTypes = this.Relations["tblCompanyLineslstRatingTypes"];
    this.relationtblCompanyLocationstblCompanyLines = this.Relations["tblCompanyLocationstblCompanyLines"];
    this.relationtblCompaniestblCompanyLocations = this.Relations["tblCompaniestblCompanyLocations"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsRaterManagement);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsRaterManagement.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblFactorSetsFilterable = new dsRaterManagement.tblFactorSetsFilterableDataTable();
    base.Tables.Add((DataTable) this.tabletblFactorSetsFilterable);
    this.tablelstRatingTypes = new dsRaterManagement.lstRatingTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstRatingTypes);
    this.tabletblCompanies = new dsRaterManagement.tblCompaniesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanies);
    this.tabletblCompanyLines = new dsRaterManagement.tblCompanyLinesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLines);
    this.tabletblCompanyLocations = new dsRaterManagement.tblCompanyLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLocations);
    this.tabletblFactorSets = new dsRaterManagement.tblFactorSetsDataTable();
    base.Tables.Add((DataTable) this.tabletblFactorSets);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("tblCompanyLineslstRatingTypes", new DataColumn[1]
    {
      this.tabletblCompanyLines.CompanyLineGUIDColumn
    }, new DataColumn[1]
    {
      this.tablelstRatingTypes.CompanyLineGuidColumn
    });
    this.tablelstRatingTypes.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("tblCompanyLocationstblCompanyLines", new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyLocationGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLines.CompanyLocationGUIDColumn
    });
    this.tabletblCompanyLines.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("tblCompaniestblCompanyLocations", new DataColumn[1]
    {
      this.tabletblCompanies.CompanyGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyGUIDColumn
    });
    this.tabletblCompanyLocations.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    this.relationtblCompanyLineslstRatingTypes = new DataRelation("tblCompanyLineslstRatingTypes", new DataColumn[1]
    {
      this.tabletblCompanyLines.CompanyLineGUIDColumn
    }, new DataColumn[1]
    {
      this.tablelstRatingTypes.CompanyLineGuidColumn
    }, false);
    this.Relations.Add(this.relationtblCompanyLineslstRatingTypes);
    this.relationtblCompanyLocationstblCompanyLines = new DataRelation("tblCompanyLocationstblCompanyLines", new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyLocationGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLines.CompanyLocationGUIDColumn
    }, false);
    this.Relations.Add(this.relationtblCompanyLocationstblCompanyLines);
    this.relationtblCompaniestblCompanyLocations = new DataRelation("tblCompaniestblCompanyLocations", new DataColumn[1]
    {
      this.tabletblCompanies.CompanyGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLocations.CompanyGUIDColumn
    }, false);
    this.Relations.Add(this.relationtblCompaniestblCompanyLocations);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblFactorSetsFilterable() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstRatingTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanies() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyLines() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblFactorSets() => false;

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
    dsRaterManagement dsRaterManagement = new dsRaterManagement();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsRaterManagement.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsRaterManagement.GetSchemaSerializable();
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
  public delegate void tblFactorSetsFilterableRowChangeEventHandler(
    object sender,
    dsRaterManagement.tblFactorSetsFilterableRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstRatingTypesRowChangeEventHandler(
    object sender,
    dsRaterManagement.lstRatingTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblCompaniesRowChangeEventHandler(
    object sender,
    dsRaterManagement.tblCompaniesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblCompanyLinesRowChangeEventHandler(
    object sender,
    dsRaterManagement.tblCompanyLinesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblCompanyLocationsRowChangeEventHandler(
    object sender,
    dsRaterManagement.tblCompanyLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblFactorSetsRowChangeEventHandler(
    object sender,
    dsRaterManagement.tblFactorSetsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblFactorSetsFilterableDataTable : 
    TypedTableBase<dsRaterManagement.tblFactorSetsFilterableRow>
  {
    private DataColumn columnFactorSetGUID;
    private DataColumn columnEffectiveDate;
    private DataColumn columnHidden;
    private DataColumn columnTitle;
    private DataColumn columnMemo;
    private DataColumn columnRaterID;
    private DataColumn columnCompanyLineGUID;
    private DataColumn columnCompanyGUID;
    private DataColumn columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblFactorSetsFilterableDataTable()
    {
      this.TableName = "tblFactorSetsFilterable";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblFactorSetsFilterableDataTable(DataTable table)
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
    protected tblFactorSetsFilterableDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FactorSetGUIDColumn => this.columnFactorSetGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TitleColumn => this.columnTitle;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemoColumn => this.columnMemo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RaterIDColumn => this.columnRaterID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineGUIDColumn => this.columnCompanyLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyGUIDColumn => this.columnCompanyGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLocationGUIDColumn => this.columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblFactorSetsFilterableRow this[int index]
    {
      get => (dsRaterManagement.tblFactorSetsFilterableRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblFactorSetsFilterableRowChangeEventHandler tblFactorSetsFilterableRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblFactorSetsFilterableRowChangeEventHandler tblFactorSetsFilterableRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblFactorSetsFilterableRowChangeEventHandler tblFactorSetsFilterableRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblFactorSetsFilterableRowChangeEventHandler tblFactorSetsFilterableRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblFactorSetsFilterableRow(dsRaterManagement.tblFactorSetsFilterableRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblFactorSetsFilterableRow AddtblFactorSetsFilterableRow(
      Guid FactorSetGUID,
      DateTime EffectiveDate,
      bool Hidden,
      string Title,
      string Memo,
      int RaterID,
      Guid CompanyLineGUID,
      Guid CompanyGUID,
      Guid CompanyLocationGUID)
    {
      dsRaterManagement.tblFactorSetsFilterableRow row = (dsRaterManagement.tblFactorSetsFilterableRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) FactorSetGUID,
        (object) EffectiveDate,
        (object) Hidden,
        (object) Title,
        (object) Memo,
        (object) RaterID,
        (object) CompanyLineGUID,
        (object) CompanyGUID,
        (object) CompanyLocationGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRaterManagement.tblFactorSetsFilterableDataTable filterableDataTable = (dsRaterManagement.tblFactorSetsFilterableDataTable) base.Clone();
      filterableDataTable.InitVars();
      return (DataTable) filterableDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRaterManagement.tblFactorSetsFilterableDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnFactorSetGUID = this.Columns["FactorSetGUID"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnHidden = this.Columns["Hidden"];
      this.columnTitle = this.Columns["Title"];
      this.columnMemo = this.Columns["Memo"];
      this.columnRaterID = this.Columns["RaterID"];
      this.columnCompanyLineGUID = this.Columns["CompanyLineGUID"];
      this.columnCompanyGUID = this.Columns["CompanyGUID"];
      this.columnCompanyLocationGUID = this.Columns["CompanyLocationGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnFactorSetGUID = new DataColumn("FactorSetGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFactorSetGUID);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.columnTitle = new DataColumn("Title", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTitle);
      this.columnMemo = new DataColumn("Memo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemo);
      this.columnRaterID = new DataColumn("RaterID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRaterID);
      this.columnCompanyLineGUID = new DataColumn("CompanyLineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGUID);
      this.columnCompanyGUID = new DataColumn("CompanyGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGUID);
      this.columnCompanyLocationGUID = new DataColumn("CompanyLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGUID);
      this.columnFactorSetGUID.AllowDBNull = false;
      this.columnEffectiveDate.AllowDBNull = false;
      this.columnHidden.AllowDBNull = false;
      this.columnTitle.AllowDBNull = false;
      this.columnMemo.AllowDBNull = false;
      this.columnRaterID.AllowDBNull = false;
      this.columnCompanyLineGUID.AllowDBNull = false;
      this.columnCompanyGUID.AllowDBNull = false;
      this.columnCompanyLocationGUID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblFactorSetsFilterableRow NewtblFactorSetsFilterableRow()
    {
      return (dsRaterManagement.tblFactorSetsFilterableRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRaterManagement.tblFactorSetsFilterableRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRaterManagement.tblFactorSetsFilterableRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsFilterableRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblFactorSetsFilterableRowChangeEventHandler filterableRowChangedEvent = this.tblFactorSetsFilterableRowChangedEvent;
      if (filterableRowChangedEvent == null)
        return;
      filterableRowChangedEvent((object) this, new dsRaterManagement.tblFactorSetsFilterableRowChangeEvent((dsRaterManagement.tblFactorSetsFilterableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsFilterableRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblFactorSetsFilterableRowChangeEventHandler rowChangingEvent = this.tblFactorSetsFilterableRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRaterManagement.tblFactorSetsFilterableRowChangeEvent((dsRaterManagement.tblFactorSetsFilterableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsFilterableRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblFactorSetsFilterableRowChangeEventHandler filterableRowDeletedEvent = this.tblFactorSetsFilterableRowDeletedEvent;
      if (filterableRowDeletedEvent == null)
        return;
      filterableRowDeletedEvent((object) this, new dsRaterManagement.tblFactorSetsFilterableRowChangeEvent((dsRaterManagement.tblFactorSetsFilterableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsFilterableRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblFactorSetsFilterableRowChangeEventHandler rowDeletingEvent = this.tblFactorSetsFilterableRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRaterManagement.tblFactorSetsFilterableRowChangeEvent((dsRaterManagement.tblFactorSetsFilterableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblFactorSetsFilterableRow(dsRaterManagement.tblFactorSetsFilterableRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRaterManagement dsRaterManagement = new dsRaterManagement();
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
        FixedValue = dsRaterManagement.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblFactorSetsFilterableDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRaterManagement.GetSchemaSerializable();
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
  public class lstRatingTypesDataTable : TypedTableBase<dsRaterManagement.lstRatingTypesRow>
  {
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnRatingTypeID;
    private DataColumn columnRatingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstRatingTypesDataTable()
    {
      this.TableName = "lstRatingTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstRatingTypesDataTable(DataTable table)
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
    protected lstRatingTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RatingTypeIDColumn => this.columnRatingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RatingTypeColumn => this.columnRatingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.lstRatingTypesRow this[int index]
    {
      get => (dsRaterManagement.lstRatingTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.lstRatingTypesRowChangeEventHandler lstRatingTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.lstRatingTypesRowChangeEventHandler lstRatingTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.lstRatingTypesRowChangeEventHandler lstRatingTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.lstRatingTypesRowChangeEventHandler lstRatingTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstRatingTypesRow(dsRaterManagement.lstRatingTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.lstRatingTypesRow AddlstRatingTypesRow(
      dsRaterManagement.tblCompanyLinesRow parenttblCompanyLinesRowBytblCompanyLineslstRatingTypes,
      int RatingTypeID,
      string RatingType)
    {
      dsRaterManagement.lstRatingTypesRow row = (dsRaterManagement.lstRatingTypesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) RatingTypeID,
        (object) RatingType
      };
      if (parenttblCompanyLinesRowBytblCompanyLineslstRatingTypes != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblCompanyLinesRowBytblCompanyLineslstRatingTypes[2]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRaterManagement.lstRatingTypesDataTable ratingTypesDataTable = (dsRaterManagement.lstRatingTypesDataTable) base.Clone();
      ratingTypesDataTable.InitVars();
      return (DataTable) ratingTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRaterManagement.lstRatingTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnRatingTypeID = this.Columns["RatingTypeID"];
      this.columnRatingType = this.Columns["RatingType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnRatingTypeID = new DataColumn("RatingTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRatingTypeID);
      this.columnRatingType = new DataColumn("RatingType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRatingType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnCompanyLineGuid,
        this.columnRatingTypeID
      }, false));
      this.columnCompanyLineGuid.AllowDBNull = false;
      this.columnRatingTypeID.AllowDBNull = false;
      this.columnRatingType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.lstRatingTypesRow NewlstRatingTypesRow()
    {
      return (dsRaterManagement.lstRatingTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRaterManagement.lstRatingTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRaterManagement.lstRatingTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstRatingTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.lstRatingTypesRowChangeEventHandler typesRowChangedEvent = this.lstRatingTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsRaterManagement.lstRatingTypesRowChangeEvent((dsRaterManagement.lstRatingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstRatingTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.lstRatingTypesRowChangeEventHandler rowChangingEvent = this.lstRatingTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRaterManagement.lstRatingTypesRowChangeEvent((dsRaterManagement.lstRatingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstRatingTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.lstRatingTypesRowChangeEventHandler typesRowDeletedEvent = this.lstRatingTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsRaterManagement.lstRatingTypesRowChangeEvent((dsRaterManagement.lstRatingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstRatingTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.lstRatingTypesRowChangeEventHandler rowDeletingEvent = this.lstRatingTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRaterManagement.lstRatingTypesRowChangeEvent((dsRaterManagement.lstRatingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstRatingTypesRow(dsRaterManagement.lstRatingTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRaterManagement dsRaterManagement = new dsRaterManagement();
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
        FixedValue = dsRaterManagement.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstRatingTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRaterManagement.GetSchemaSerializable();
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
  public class tblCompaniesDataTable : TypedTableBase<dsRaterManagement.tblCompaniesRow>
  {
    private DataColumn columnCompanyGUID;
    private DataColumn columnCompanyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompaniesDataTable()
    {
      this.TableName = "tblCompanies";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompaniesDataTable(DataTable table)
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
    protected tblCompaniesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyGUIDColumn => this.columnCompanyGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyNameColumn => this.columnCompanyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompaniesRow this[int index]
    {
      get => (dsRaterManagement.tblCompaniesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblCompaniesRowChangeEventHandler tblCompaniesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblCompaniesRowChangeEventHandler tblCompaniesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblCompaniesRowChangeEventHandler tblCompaniesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblCompaniesRowChangeEventHandler tblCompaniesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompaniesRow(dsRaterManagement.tblCompaniesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompaniesRow AddtblCompaniesRow(
      Guid CompanyGUID,
      string CompanyName)
    {
      dsRaterManagement.tblCompaniesRow row = (dsRaterManagement.tblCompaniesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyGUID,
        (object) CompanyName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRaterManagement.tblCompaniesDataTable companiesDataTable = (dsRaterManagement.tblCompaniesDataTable) base.Clone();
      companiesDataTable.InitVars();
      return (DataTable) companiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRaterManagement.tblCompaniesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyGUID = this.Columns["CompanyGUID"];
      this.columnCompanyName = this.Columns["CompanyName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyGUID = new DataColumn("CompanyGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGUID);
      this.columnCompanyName = new DataColumn("CompanyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCompanyGUID
      }, false));
      this.columnCompanyGUID.AllowDBNull = false;
      this.columnCompanyGUID.Unique = true;
      this.columnCompanyName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompaniesRow NewtblCompaniesRow()
    {
      return (dsRaterManagement.tblCompaniesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRaterManagement.tblCompaniesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRaterManagement.tblCompaniesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblCompaniesRowChangeEventHandler companiesRowChangedEvent = this.tblCompaniesRowChangedEvent;
      if (companiesRowChangedEvent == null)
        return;
      companiesRowChangedEvent((object) this, new dsRaterManagement.tblCompaniesRowChangeEvent((dsRaterManagement.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblCompaniesRowChangeEventHandler rowChangingEvent = this.tblCompaniesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRaterManagement.tblCompaniesRowChangeEvent((dsRaterManagement.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblCompaniesRowChangeEventHandler companiesRowDeletedEvent = this.tblCompaniesRowDeletedEvent;
      if (companiesRowDeletedEvent == null)
        return;
      companiesRowDeletedEvent((object) this, new dsRaterManagement.tblCompaniesRowChangeEvent((dsRaterManagement.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblCompaniesRowChangeEventHandler rowDeletingEvent = this.tblCompaniesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRaterManagement.tblCompaniesRowChangeEvent((dsRaterManagement.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompaniesRow(dsRaterManagement.tblCompaniesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRaterManagement dsRaterManagement = new dsRaterManagement();
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
        FixedValue = dsRaterManagement.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompaniesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRaterManagement.GetSchemaSerializable();
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
  public class tblCompanyLinesDataTable : TypedTableBase<dsRaterManagement.tblCompanyLinesRow>
  {
    private DataColumn columnFullLine;
    private DataColumn columnCompanyLocationGUID;
    private DataColumn columnCompanyLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLinesDataTable()
    {
      this.TableName = "tblCompanyLines";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLinesDataTable(DataTable table)
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
    protected tblCompanyLinesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FullLineColumn => this.columnFullLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLocationGUIDColumn => this.columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineGUIDColumn => this.columnCompanyLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompanyLinesRow this[int index]
    {
      get => (dsRaterManagement.tblCompanyLinesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyLinesRow(dsRaterManagement.tblCompanyLinesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompanyLinesRow AddtblCompanyLinesRow(
      string FullLine,
      dsRaterManagement.tblCompanyLocationsRow parenttblCompanyLocationsRowBytblCompanyLocationstblCompanyLines,
      Guid CompanyLineGUID)
    {
      dsRaterManagement.tblCompanyLinesRow row = (dsRaterManagement.tblCompanyLinesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) FullLine,
        null,
        (object) CompanyLineGUID
      };
      if (parenttblCompanyLocationsRowBytblCompanyLocationstblCompanyLines != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblCompanyLocationsRowBytblCompanyLocationstblCompanyLines[1]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRaterManagement.tblCompanyLinesDataTable companyLinesDataTable = (dsRaterManagement.tblCompanyLinesDataTable) base.Clone();
      companyLinesDataTable.InitVars();
      return (DataTable) companyLinesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRaterManagement.tblCompanyLinesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnFullLine = this.Columns["FullLine"];
      this.columnCompanyLocationGUID = this.Columns["CompanyLocationGUID"];
      this.columnCompanyLineGUID = this.Columns["CompanyLineGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnFullLine = new DataColumn("FullLine", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullLine);
      this.columnCompanyLocationGUID = new DataColumn("CompanyLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGUID);
      this.columnCompanyLineGUID = new DataColumn("CompanyLineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCompanyLineGUID
      }, false));
      this.columnFullLine.ReadOnly = true;
      this.columnCompanyLocationGUID.AllowDBNull = false;
      this.columnCompanyLineGUID.AllowDBNull = false;
      this.columnCompanyLineGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompanyLinesRow NewtblCompanyLinesRow()
    {
      return (dsRaterManagement.tblCompanyLinesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRaterManagement.tblCompanyLinesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRaterManagement.tblCompanyLinesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblCompanyLinesRowChangeEventHandler linesRowChangedEvent = this.tblCompanyLinesRowChangedEvent;
      if (linesRowChangedEvent == null)
        return;
      linesRowChangedEvent((object) this, new dsRaterManagement.tblCompanyLinesRowChangeEvent((dsRaterManagement.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblCompanyLinesRowChangeEventHandler rowChangingEvent = this.tblCompanyLinesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRaterManagement.tblCompanyLinesRowChangeEvent((dsRaterManagement.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblCompanyLinesRowChangeEventHandler linesRowDeletedEvent = this.tblCompanyLinesRowDeletedEvent;
      if (linesRowDeletedEvent == null)
        return;
      linesRowDeletedEvent((object) this, new dsRaterManagement.tblCompanyLinesRowChangeEvent((dsRaterManagement.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblCompanyLinesRowChangeEventHandler rowDeletingEvent = this.tblCompanyLinesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRaterManagement.tblCompanyLinesRowChangeEvent((dsRaterManagement.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyLinesRow(dsRaterManagement.tblCompanyLinesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRaterManagement dsRaterManagement = new dsRaterManagement();
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
        FixedValue = dsRaterManagement.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLinesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRaterManagement.GetSchemaSerializable();
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
  public class tblCompanyLocationsDataTable : 
    TypedTableBase<dsRaterManagement.tblCompanyLocationsRow>
  {
    private DataColumn columnCompanyGUID;
    private DataColumn columnCompanyLocationGUID;
    private DataColumn columnFullName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLocationsDataTable()
    {
      this.TableName = "tblCompanyLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLocationsDataTable(DataTable table)
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
    protected tblCompanyLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyGUIDColumn => this.columnCompanyGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLocationGUIDColumn => this.columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FullNameColumn => this.columnFullName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompanyLocationsRow this[int index]
    {
      get => (dsRaterManagement.tblCompanyLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyLocationsRow(dsRaterManagement.tblCompanyLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompanyLocationsRow AddtblCompanyLocationsRow(
      dsRaterManagement.tblCompaniesRow parenttblCompaniesRowBytblCompaniestblCompanyLocations,
      Guid CompanyLocationGUID,
      string FullName)
    {
      dsRaterManagement.tblCompanyLocationsRow row = (dsRaterManagement.tblCompanyLocationsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) CompanyLocationGUID,
        (object) FullName
      };
      if (parenttblCompaniesRowBytblCompaniestblCompanyLocations != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblCompaniesRowBytblCompaniestblCompanyLocations[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRaterManagement.tblCompanyLocationsDataTable locationsDataTable = (dsRaterManagement.tblCompanyLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRaterManagement.tblCompanyLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyGUID = this.Columns["CompanyGUID"];
      this.columnCompanyLocationGUID = this.Columns["CompanyLocationGUID"];
      this.columnFullName = this.Columns["FullName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyGUID = new DataColumn("CompanyGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGUID);
      this.columnCompanyLocationGUID = new DataColumn("CompanyLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGUID);
      this.columnFullName = new DataColumn("FullName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCompanyLocationGUID
      }, false));
      this.columnCompanyGUID.AllowDBNull = false;
      this.columnCompanyLocationGUID.AllowDBNull = false;
      this.columnCompanyLocationGUID.Unique = true;
      this.columnFullName.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompanyLocationsRow NewtblCompanyLocationsRow()
    {
      return (dsRaterManagement.tblCompanyLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRaterManagement.tblCompanyLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRaterManagement.tblCompanyLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblCompanyLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblCompanyLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsRaterManagement.tblCompanyLocationsRowChangeEvent((dsRaterManagement.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblCompanyLocationsRowChangeEventHandler rowChangingEvent = this.tblCompanyLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRaterManagement.tblCompanyLocationsRowChangeEvent((dsRaterManagement.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblCompanyLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblCompanyLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsRaterManagement.tblCompanyLocationsRowChangeEvent((dsRaterManagement.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblCompanyLocationsRowChangeEventHandler rowDeletingEvent = this.tblCompanyLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRaterManagement.tblCompanyLocationsRowChangeEvent((dsRaterManagement.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyLocationsRow(dsRaterManagement.tblCompanyLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRaterManagement dsRaterManagement = new dsRaterManagement();
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
        FixedValue = dsRaterManagement.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRaterManagement.GetSchemaSerializable();
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
  public class tblFactorSetsDataTable : TypedTableBase<dsRaterManagement.tblFactorSetsRow>
  {
    private DataColumn columnFactorSetGUID;
    private DataColumn columnEffectiveDate;
    private DataColumn columnHidden;
    private DataColumn columnTitle;
    private DataColumn columnMemo;
    private DataColumn columnRaterID;
    private DataColumn columnCompanyLineGUID;
    private DataColumn columnBound;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblFactorSetsDataTable()
    {
      this.TableName = "tblFactorSets";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblFactorSetsDataTable(DataTable table)
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
    protected tblFactorSetsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FactorSetGUIDColumn => this.columnFactorSetGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TitleColumn => this.columnTitle;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MemoColumn => this.columnMemo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RaterIDColumn => this.columnRaterID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineGUIDColumn => this.columnCompanyLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BoundColumn => this.columnBound;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblFactorSetsRow this[int index]
    {
      get => (dsRaterManagement.tblFactorSetsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblFactorSetsRowChangeEventHandler tblFactorSetsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblFactorSetsRowChangeEventHandler tblFactorSetsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblFactorSetsRowChangeEventHandler tblFactorSetsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRaterManagement.tblFactorSetsRowChangeEventHandler tblFactorSetsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblFactorSetsRow(dsRaterManagement.tblFactorSetsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblFactorSetsRow AddtblFactorSetsRow(
      Guid FactorSetGUID,
      DateTime EffectiveDate,
      bool Hidden,
      string Title,
      string Memo,
      int RaterID,
      Guid CompanyLineGUID,
      bool Bound)
    {
      dsRaterManagement.tblFactorSetsRow row = (dsRaterManagement.tblFactorSetsRow) this.NewRow();
      object[] objArray = new object[8]
      {
        (object) FactorSetGUID,
        (object) EffectiveDate,
        (object) Hidden,
        (object) Title,
        (object) Memo,
        (object) RaterID,
        (object) CompanyLineGUID,
        (object) Bound
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRaterManagement.tblFactorSetsDataTable factorSetsDataTable = (dsRaterManagement.tblFactorSetsDataTable) base.Clone();
      factorSetsDataTable.InitVars();
      return (DataTable) factorSetsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRaterManagement.tblFactorSetsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnFactorSetGUID = this.Columns["FactorSetGUID"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnHidden = this.Columns["Hidden"];
      this.columnTitle = this.Columns["Title"];
      this.columnMemo = this.Columns["Memo"];
      this.columnRaterID = this.Columns["RaterID"];
      this.columnCompanyLineGUID = this.Columns["CompanyLineGUID"];
      this.columnBound = this.Columns["Bound"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnFactorSetGUID = new DataColumn("FactorSetGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFactorSetGUID);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.columnTitle = new DataColumn("Title", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTitle);
      this.columnMemo = new DataColumn("Memo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMemo);
      this.columnRaterID = new DataColumn("RaterID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRaterID);
      this.columnCompanyLineGUID = new DataColumn("CompanyLineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGUID);
      this.columnBound = new DataColumn("Bound", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBound);
      this.columnFactorSetGUID.AllowDBNull = false;
      this.columnEffectiveDate.AllowDBNull = false;
      this.columnHidden.AllowDBNull = false;
      this.columnTitle.AllowDBNull = false;
      this.columnMemo.AllowDBNull = false;
      this.columnRaterID.AllowDBNull = false;
      this.columnCompanyLineGUID.AllowDBNull = false;
      this.columnBound.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblFactorSetsRow NewtblFactorSetsRow()
    {
      return (dsRaterManagement.tblFactorSetsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRaterManagement.tblFactorSetsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRaterManagement.tblFactorSetsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblFactorSetsRowChangeEventHandler setsRowChangedEvent = this.tblFactorSetsRowChangedEvent;
      if (setsRowChangedEvent == null)
        return;
      setsRowChangedEvent((object) this, new dsRaterManagement.tblFactorSetsRowChangeEvent((dsRaterManagement.tblFactorSetsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblFactorSetsRowChangeEventHandler rowChangingEvent = this.tblFactorSetsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRaterManagement.tblFactorSetsRowChangeEvent((dsRaterManagement.tblFactorSetsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblFactorSetsRowChangeEventHandler setsRowDeletedEvent = this.tblFactorSetsRowDeletedEvent;
      if (setsRowDeletedEvent == null)
        return;
      setsRowDeletedEvent((object) this, new dsRaterManagement.tblFactorSetsRowChangeEvent((dsRaterManagement.tblFactorSetsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRaterManagement.tblFactorSetsRowChangeEventHandler rowDeletingEvent = this.tblFactorSetsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRaterManagement.tblFactorSetsRowChangeEvent((dsRaterManagement.tblFactorSetsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblFactorSetsRow(dsRaterManagement.tblFactorSetsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRaterManagement dsRaterManagement = new dsRaterManagement();
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
        FixedValue = dsRaterManagement.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblFactorSetsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRaterManagement.GetSchemaSerializable();
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

  public class tblFactorSetsFilterableRow : DataRow
  {
    private dsRaterManagement.tblFactorSetsFilterableDataTable tabletblFactorSetsFilterable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblFactorSetsFilterableRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblFactorSetsFilterable = (dsRaterManagement.tblFactorSetsFilterableDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid FactorSetGUID
    {
      get
      {
        object obj = this[this.tabletblFactorSetsFilterable.FactorSetGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblFactorSetsFilterable.FactorSetGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime EffectiveDate
    {
      get => Conversions.ToDate(this[this.tabletblFactorSetsFilterable.EffectiveDateColumn]);
      set => this[this.tabletblFactorSetsFilterable.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Hidden
    {
      get => Conversions.ToBoolean(this[this.tabletblFactorSetsFilterable.HiddenColumn]);
      set => this[this.tabletblFactorSetsFilterable.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Title
    {
      get => Conversions.ToString(this[this.tabletblFactorSetsFilterable.TitleColumn]);
      set => this[this.tabletblFactorSetsFilterable.TitleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Memo
    {
      get => Conversions.ToString(this[this.tabletblFactorSetsFilterable.MemoColumn]);
      set => this[this.tabletblFactorSetsFilterable.MemoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int RaterID
    {
      get => Conversions.ToInteger(this[this.tabletblFactorSetsFilterable.RaterIDColumn]);
      set => this[this.tabletblFactorSetsFilterable.RaterIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLineGUID
    {
      get
      {
        object obj = this[this.tabletblFactorSetsFilterable.CompanyLineGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblFactorSetsFilterable.CompanyLineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyGUID
    {
      get
      {
        object obj = this[this.tabletblFactorSetsFilterable.CompanyGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblFactorSetsFilterable.CompanyGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLocationGUID
    {
      get
      {
        object obj = this[this.tabletblFactorSetsFilterable.CompanyLocationGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblFactorSetsFilterable.CompanyLocationGUIDColumn] = (object) value;
    }
  }

  public class lstRatingTypesRow : DataRow
  {
    private dsRaterManagement.lstRatingTypesDataTable tablelstRatingTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstRatingTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstRatingTypes = (dsRaterManagement.lstRatingTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        object obj = this[this.tablelstRatingTypes.CompanyLineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tablelstRatingTypes.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int RatingTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstRatingTypes.RatingTypeIDColumn]);
      set => this[this.tablelstRatingTypes.RatingTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RatingType
    {
      get => Conversions.ToString(this[this.tablelstRatingTypes.RatingTypeColumn]);
      set => this[this.tablelstRatingTypes.RatingTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompanyLinesRow tblCompanyLinesRow
    {
      get
      {
        return (dsRaterManagement.tblCompanyLinesRow) this.GetParentRow(this.Table.ParentRelations["tblCompanyLineslstRatingTypes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompanyLineslstRatingTypes"]);
      }
    }
  }

  public class tblCompaniesRow : DataRow
  {
    private dsRaterManagement.tblCompaniesDataTable tabletblCompanies;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompaniesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanies = (dsRaterManagement.tblCompaniesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyGUID
    {
      get
      {
        object obj = this[this.tabletblCompanies.CompanyGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanies.CompanyGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CompanyName
    {
      get => Conversions.ToString(this[this.tabletblCompanies.CompanyNameColumn]);
      set => this[this.tabletblCompanies.CompanyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompanyLocationsRow[] GettblCompanyLocationsRows()
    {
      return this.Table.ChildRelations["tblCompaniestblCompanyLocations"] != null ? (dsRaterManagement.tblCompanyLocationsRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompaniestblCompanyLocations"]) : new dsRaterManagement.tblCompanyLocationsRow[0];
    }
  }

  public class tblCompanyLinesRow : DataRow
  {
    private dsRaterManagement.tblCompanyLinesDataTable tabletblCompanyLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLines = (dsRaterManagement.tblCompanyLinesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FullLine
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLines.FullLineColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FullLine' in table 'tblCompanyLines' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLines.FullLineColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLocationGUID
    {
      get
      {
        object obj = this[this.tabletblCompanyLines.CompanyLocationGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyLines.CompanyLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLineGUID
    {
      get
      {
        object obj = this[this.tabletblCompanyLines.CompanyLineGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyLines.CompanyLineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompanyLocationsRow tblCompanyLocationsRow
    {
      get
      {
        return (dsRaterManagement.tblCompanyLocationsRow) this.GetParentRow(this.Table.ParentRelations["tblCompanyLocationstblCompanyLines"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompanyLocationstblCompanyLines"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFullLineNull() => this.IsNull(this.tabletblCompanyLines.FullLineColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFullLineNull()
    {
      this[this.tabletblCompanyLines.FullLineColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.lstRatingTypesRow[] GetlstRatingTypesRows()
    {
      return this.Table.ChildRelations["tblCompanyLineslstRatingTypes"] != null ? (dsRaterManagement.lstRatingTypesRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompanyLineslstRatingTypes"]) : new dsRaterManagement.lstRatingTypesRow[0];
    }
  }

  public class tblCompanyLocationsRow : DataRow
  {
    private dsRaterManagement.tblCompanyLocationsDataTable tabletblCompanyLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLocations = (dsRaterManagement.tblCompanyLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyGUID
    {
      get
      {
        object obj = this[this.tabletblCompanyLocations.CompanyGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyLocations.CompanyGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLocationGUID
    {
      get
      {
        object obj = this[this.tabletblCompanyLocations.CompanyLocationGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyLocations.CompanyLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FullName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.FullNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FullName' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.FullNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompaniesRow tblCompaniesRow
    {
      get
      {
        return (dsRaterManagement.tblCompaniesRow) this.GetParentRow(this.Table.ParentRelations["tblCompaniestblCompanyLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompaniestblCompanyLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFullNameNull() => this.IsNull(this.tabletblCompanyLocations.FullNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFullNameNull()
    {
      this[this.tabletblCompanyLocations.FullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompanyLinesRow[] GettblCompanyLinesRows()
    {
      return this.Table.ChildRelations["tblCompanyLocationstblCompanyLines"] != null ? (dsRaterManagement.tblCompanyLinesRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompanyLocationstblCompanyLines"]) : new dsRaterManagement.tblCompanyLinesRow[0];
    }
  }

  public class tblFactorSetsRow : DataRow
  {
    private dsRaterManagement.tblFactorSetsDataTable tabletblFactorSets;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblFactorSetsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblFactorSets = (dsRaterManagement.tblFactorSetsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid FactorSetGUID
    {
      get
      {
        object obj = this[this.tabletblFactorSets.FactorSetGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblFactorSets.FactorSetGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime EffectiveDate
    {
      get => Conversions.ToDate(this[this.tabletblFactorSets.EffectiveDateColumn]);
      set => this[this.tabletblFactorSets.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Hidden
    {
      get => Conversions.ToBoolean(this[this.tabletblFactorSets.HiddenColumn]);
      set => this[this.tabletblFactorSets.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Title
    {
      get => Conversions.ToString(this[this.tabletblFactorSets.TitleColumn]);
      set => this[this.tabletblFactorSets.TitleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Memo
    {
      get => Conversions.ToString(this[this.tabletblFactorSets.MemoColumn]);
      set => this[this.tabletblFactorSets.MemoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int RaterID
    {
      get => Conversions.ToInteger(this[this.tabletblFactorSets.RaterIDColumn]);
      set => this[this.tabletblFactorSets.RaterIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLineGUID
    {
      get
      {
        object obj = this[this.tabletblFactorSets.CompanyLineGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblFactorSets.CompanyLineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Bound
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblFactorSets.BoundColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Bound' in table 'tblFactorSets' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFactorSets.BoundColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBoundNull() => this.IsNull(this.tabletblFactorSets.BoundColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBoundNull()
    {
      this[this.tabletblFactorSets.BoundColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblFactorSetsFilterableRowChangeEvent : EventArgs
  {
    private dsRaterManagement.tblFactorSetsFilterableRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblFactorSetsFilterableRowChangeEvent(
      dsRaterManagement.tblFactorSetsFilterableRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblFactorSetsFilterableRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstRatingTypesRowChangeEvent : EventArgs
  {
    private dsRaterManagement.lstRatingTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstRatingTypesRowChangeEvent(
      dsRaterManagement.lstRatingTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.lstRatingTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompaniesRowChangeEvent : EventArgs
  {
    private dsRaterManagement.tblCompaniesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompaniesRowChangeEvent(dsRaterManagement.tblCompaniesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompaniesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyLinesRowChangeEvent : EventArgs
  {
    private dsRaterManagement.tblCompanyLinesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLinesRowChangeEvent(
      dsRaterManagement.tblCompanyLinesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompanyLinesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyLocationsRowChangeEvent : EventArgs
  {
    private dsRaterManagement.tblCompanyLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLocationsRowChangeEvent(
      dsRaterManagement.tblCompanyLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblCompanyLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblFactorSetsRowChangeEvent : EventArgs
  {
    private dsRaterManagement.tblFactorSetsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblFactorSetsRowChangeEvent(dsRaterManagement.tblFactorSetsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRaterManagement.tblFactorSetsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
