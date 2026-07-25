// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.dsProductionGoal
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

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
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsProductionGoal")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsProductionGoal : DataSet
{
  private dsProductionGoal.dtMonthDataTable tabledtMonth;
  private dsProductionGoal.dtYearDataTable tabledtYear;
  private dsProductionGoal.tblProductionGoalDataTable tabletblProductionGoal;
  private dsProductionGoal.tblProducerLocationsDataTable tabletblProducerLocations;
  private dsProductionGoal.tblProducersDataTable tabletblProducers;
  private dsProductionGoal.lstPolicyTypesDataTable tablelstPolicyTypes;
  private dsProductionGoal.lstLinesDataTable tablelstLines;
  private dsProductionGoal.tblCompanyGroupsDataTable tabletblCompanyGroups;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsProductionGoal()
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
  protected dsProductionGoal(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (dtMonth)] != null)
          base.Tables.Add((DataTable) new dsProductionGoal.dtMonthDataTable(dataSet.Tables[nameof (dtMonth)]));
        if (dataSet.Tables[nameof (dtYear)] != null)
          base.Tables.Add((DataTable) new dsProductionGoal.dtYearDataTable(dataSet.Tables[nameof (dtYear)]));
        if (dataSet.Tables[nameof (tblProductionGoal)] != null)
          base.Tables.Add((DataTable) new dsProductionGoal.tblProductionGoalDataTable(dataSet.Tables[nameof (tblProductionGoal)]));
        if (dataSet.Tables[nameof (tblProducerLocations)] != null)
          base.Tables.Add((DataTable) new dsProductionGoal.tblProducerLocationsDataTable(dataSet.Tables[nameof (tblProducerLocations)]));
        if (dataSet.Tables[nameof (tblProducers)] != null)
          base.Tables.Add((DataTable) new dsProductionGoal.tblProducersDataTable(dataSet.Tables[nameof (tblProducers)]));
        if (dataSet.Tables[nameof (lstPolicyTypes)] != null)
          base.Tables.Add((DataTable) new dsProductionGoal.lstPolicyTypesDataTable(dataSet.Tables[nameof (lstPolicyTypes)]));
        if (dataSet.Tables[nameof (lstLines)] != null)
          base.Tables.Add((DataTable) new dsProductionGoal.lstLinesDataTable(dataSet.Tables[nameof (lstLines)]));
        if (dataSet.Tables[nameof (tblCompanyGroups)] != null)
          base.Tables.Add((DataTable) new dsProductionGoal.tblCompanyGroupsDataTable(dataSet.Tables[nameof (tblCompanyGroups)]));
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
  public dsProductionGoal.dtMonthDataTable dtMonth => this.tabledtMonth;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProductionGoal.dtYearDataTable dtYear => this.tabledtYear;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProductionGoal.tblProductionGoalDataTable tblProductionGoal
  {
    get => this.tabletblProductionGoal;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProductionGoal.tblProducerLocationsDataTable tblProducerLocations
  {
    get => this.tabletblProducerLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProductionGoal.tblProducersDataTable tblProducers => this.tabletblProducers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProductionGoal.lstPolicyTypesDataTable lstPolicyTypes => this.tablelstPolicyTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProductionGoal.lstLinesDataTable lstLines => this.tablelstLines;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProductionGoal.tblCompanyGroupsDataTable tblCompanyGroups => this.tabletblCompanyGroups;

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
    dsProductionGoal dsProductionGoal = (dsProductionGoal) base.Clone();
    dsProductionGoal.InitVars();
    dsProductionGoal.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsProductionGoal;
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
      if (dataSet.Tables["dtMonth"] != null)
        base.Tables.Add((DataTable) new dsProductionGoal.dtMonthDataTable(dataSet.Tables["dtMonth"]));
      if (dataSet.Tables["dtYear"] != null)
        base.Tables.Add((DataTable) new dsProductionGoal.dtYearDataTable(dataSet.Tables["dtYear"]));
      if (dataSet.Tables["tblProductionGoal"] != null)
        base.Tables.Add((DataTable) new dsProductionGoal.tblProductionGoalDataTable(dataSet.Tables["tblProductionGoal"]));
      if (dataSet.Tables["tblProducerLocations"] != null)
        base.Tables.Add((DataTable) new dsProductionGoal.tblProducerLocationsDataTable(dataSet.Tables["tblProducerLocations"]));
      if (dataSet.Tables["tblProducers"] != null)
        base.Tables.Add((DataTable) new dsProductionGoal.tblProducersDataTable(dataSet.Tables["tblProducers"]));
      if (dataSet.Tables["lstPolicyTypes"] != null)
        base.Tables.Add((DataTable) new dsProductionGoal.lstPolicyTypesDataTable(dataSet.Tables["lstPolicyTypes"]));
      if (dataSet.Tables["lstLines"] != null)
        base.Tables.Add((DataTable) new dsProductionGoal.lstLinesDataTable(dataSet.Tables["lstLines"]));
      if (dataSet.Tables["tblCompanyGroups"] != null)
        base.Tables.Add((DataTable) new dsProductionGoal.tblCompanyGroupsDataTable(dataSet.Tables["tblCompanyGroups"]));
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
    this.tabledtMonth = (dsProductionGoal.dtMonthDataTable) base.Tables["dtMonth"];
    if (initTable && this.tabledtMonth != null)
      this.tabledtMonth.InitVars();
    this.tabledtYear = (dsProductionGoal.dtYearDataTable) base.Tables["dtYear"];
    if (initTable && this.tabledtYear != null)
      this.tabledtYear.InitVars();
    this.tabletblProductionGoal = (dsProductionGoal.tblProductionGoalDataTable) base.Tables["tblProductionGoal"];
    if (initTable && this.tabletblProductionGoal != null)
      this.tabletblProductionGoal.InitVars();
    this.tabletblProducerLocations = (dsProductionGoal.tblProducerLocationsDataTable) base.Tables["tblProducerLocations"];
    if (initTable && this.tabletblProducerLocations != null)
      this.tabletblProducerLocations.InitVars();
    this.tabletblProducers = (dsProductionGoal.tblProducersDataTable) base.Tables["tblProducers"];
    if (initTable && this.tabletblProducers != null)
      this.tabletblProducers.InitVars();
    this.tablelstPolicyTypes = (dsProductionGoal.lstPolicyTypesDataTable) base.Tables["lstPolicyTypes"];
    if (initTable && this.tablelstPolicyTypes != null)
      this.tablelstPolicyTypes.InitVars();
    this.tablelstLines = (dsProductionGoal.lstLinesDataTable) base.Tables["lstLines"];
    if (initTable && this.tablelstLines != null)
      this.tablelstLines.InitVars();
    this.tabletblCompanyGroups = (dsProductionGoal.tblCompanyGroupsDataTable) base.Tables["tblCompanyGroups"];
    if (!initTable || this.tabletblCompanyGroups == null)
      return;
    this.tabletblCompanyGroups.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsProductionGoal);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsProductionGoal.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabledtMonth = new dsProductionGoal.dtMonthDataTable();
    base.Tables.Add((DataTable) this.tabledtMonth);
    this.tabledtYear = new dsProductionGoal.dtYearDataTable();
    base.Tables.Add((DataTable) this.tabledtYear);
    this.tabletblProductionGoal = new dsProductionGoal.tblProductionGoalDataTable();
    base.Tables.Add((DataTable) this.tabletblProductionGoal);
    this.tabletblProducerLocations = new dsProductionGoal.tblProducerLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerLocations);
    this.tabletblProducers = new dsProductionGoal.tblProducersDataTable();
    base.Tables.Add((DataTable) this.tabletblProducers);
    this.tablelstPolicyTypes = new dsProductionGoal.lstPolicyTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstPolicyTypes);
    this.tablelstLines = new dsProductionGoal.lstLinesDataTable();
    base.Tables.Add((DataTable) this.tablelstLines);
    this.tabletblCompanyGroups = new dsProductionGoal.tblCompanyGroupsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyGroups);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializedtMonth() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializedtYear() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblProductionGoal() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblProducerLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblProducers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstPolicyTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstLines() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyGroups() => false;

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
    dsProductionGoal dsProductionGoal = new dsProductionGoal();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsProductionGoal.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsProductionGoal.GetSchemaSerializable();
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
  public delegate void dtMonthRowChangeEventHandler(
    object sender,
    dsProductionGoal.dtMonthRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void dtYearRowChangeEventHandler(
    object sender,
    dsProductionGoal.dtYearRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblProductionGoalRowChangeEventHandler(
    object sender,
    dsProductionGoal.tblProductionGoalRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblProducerLocationsRowChangeEventHandler(
    object sender,
    dsProductionGoal.tblProducerLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblProducersRowChangeEventHandler(
    object sender,
    dsProductionGoal.tblProducersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstPolicyTypesRowChangeEventHandler(
    object sender,
    dsProductionGoal.lstPolicyTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstLinesRowChangeEventHandler(
    object sender,
    dsProductionGoal.lstLinesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblCompanyGroupsRowChangeEventHandler(
    object sender,
    dsProductionGoal.tblCompanyGroupsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class dtMonthDataTable : TypedTableBase<dsProductionGoal.dtMonthRow>
  {
    private DataColumn columnMonth;
    private DataColumn columnMonthName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtMonthDataTable()
    {
      this.TableName = "dtMonth";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtMonthDataTable(DataTable table)
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
    protected dtMonthDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MonthColumn => this.columnMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MonthNameColumn => this.columnMonthName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.dtMonthRow this[int index]
    {
      get => (dsProductionGoal.dtMonthRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.dtMonthRowChangeEventHandler dtMonthRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.dtMonthRowChangeEventHandler dtMonthRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.dtMonthRowChangeEventHandler dtMonthRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.dtMonthRowChangeEventHandler dtMonthRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AdddtMonthRow(dsProductionGoal.dtMonthRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.dtMonthRow AdddtMonthRow(byte Month, string MonthName)
    {
      dsProductionGoal.dtMonthRow row = (dsProductionGoal.dtMonthRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Month,
        (object) MonthName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsProductionGoal.dtMonthDataTable dtMonthDataTable = (dsProductionGoal.dtMonthDataTable) base.Clone();
      dtMonthDataTable.InitVars();
      return (DataTable) dtMonthDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProductionGoal.dtMonthDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnMonth = this.Columns["Month"];
      this.columnMonthName = this.Columns["MonthName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnMonth = new DataColumn("Month", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMonth);
      this.columnMonthName = new DataColumn("MonthName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMonthName);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.dtMonthRow NewdtMonthRow()
    {
      return (dsProductionGoal.dtMonthRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProductionGoal.dtMonthRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsProductionGoal.dtMonthRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtMonthRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.dtMonthRowChangeEventHandler monthRowChangedEvent = this.dtMonthRowChangedEvent;
      if (monthRowChangedEvent == null)
        return;
      monthRowChangedEvent((object) this, new dsProductionGoal.dtMonthRowChangeEvent((dsProductionGoal.dtMonthRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtMonthRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.dtMonthRowChangeEventHandler rowChangingEvent = this.dtMonthRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProductionGoal.dtMonthRowChangeEvent((dsProductionGoal.dtMonthRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtMonthRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.dtMonthRowChangeEventHandler monthRowDeletedEvent = this.dtMonthRowDeletedEvent;
      if (monthRowDeletedEvent == null)
        return;
      monthRowDeletedEvent((object) this, new dsProductionGoal.dtMonthRowChangeEvent((dsProductionGoal.dtMonthRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtMonthRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.dtMonthRowChangeEventHandler rowDeletingEvent = this.dtMonthRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProductionGoal.dtMonthRowChangeEvent((dsProductionGoal.dtMonthRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovedtMonthRow(dsProductionGoal.dtMonthRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProductionGoal dsProductionGoal = new dsProductionGoal();
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
        FixedValue = dsProductionGoal.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtMonthDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProductionGoal.GetSchemaSerializable();
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
  public class dtYearDataTable : TypedTableBase<dsProductionGoal.dtYearRow>
  {
    private DataColumn columnYear;
    private DataColumn columnYearName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtYearDataTable()
    {
      this.TableName = "dtYear";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtYearDataTable(DataTable table)
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
    protected dtYearDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn YearColumn => this.columnYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn YearNameColumn => this.columnYearName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.dtYearRow this[int index]
    {
      get => (dsProductionGoal.dtYearRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.dtYearRowChangeEventHandler dtYearRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.dtYearRowChangeEventHandler dtYearRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.dtYearRowChangeEventHandler dtYearRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.dtYearRowChangeEventHandler dtYearRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AdddtYearRow(dsProductionGoal.dtYearRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.dtYearRow AdddtYearRow(int Year, string YearName)
    {
      dsProductionGoal.dtYearRow row = (dsProductionGoal.dtYearRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Year,
        (object) YearName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsProductionGoal.dtYearDataTable dtYearDataTable = (dsProductionGoal.dtYearDataTable) base.Clone();
      dtYearDataTable.InitVars();
      return (DataTable) dtYearDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProductionGoal.dtYearDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnYear = this.Columns["Year"];
      this.columnYearName = this.Columns["YearName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnYear = new DataColumn("Year", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYear);
      this.columnYearName = new DataColumn("YearName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYearName);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.dtYearRow NewdtYearRow() => (dsProductionGoal.dtYearRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProductionGoal.dtYearRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsProductionGoal.dtYearRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtYearRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.dtYearRowChangeEventHandler yearRowChangedEvent = this.dtYearRowChangedEvent;
      if (yearRowChangedEvent == null)
        return;
      yearRowChangedEvent((object) this, new dsProductionGoal.dtYearRowChangeEvent((dsProductionGoal.dtYearRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtYearRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.dtYearRowChangeEventHandler rowChangingEvent = this.dtYearRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProductionGoal.dtYearRowChangeEvent((dsProductionGoal.dtYearRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtYearRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.dtYearRowChangeEventHandler yearRowDeletedEvent = this.dtYearRowDeletedEvent;
      if (yearRowDeletedEvent == null)
        return;
      yearRowDeletedEvent((object) this, new dsProductionGoal.dtYearRowChangeEvent((dsProductionGoal.dtYearRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtYearRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.dtYearRowChangeEventHandler rowDeletingEvent = this.dtYearRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProductionGoal.dtYearRowChangeEvent((dsProductionGoal.dtYearRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovedtYearRow(dsProductionGoal.dtYearRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProductionGoal dsProductionGoal = new dsProductionGoal();
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
        FixedValue = dsProductionGoal.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtYearDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProductionGoal.GetSchemaSerializable();
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
  public class tblProductionGoalDataTable : TypedTableBase<dsProductionGoal.tblProductionGoalRow>
  {
    private DataColumn columnID;
    private DataColumn columnPremiumGoal;
    private DataColumn columnProducerLocationGUID;
    private DataColumn columnProducerGUID;
    private DataColumn columnGoalMonth;
    private DataColumn columnGoalYear;
    private DataColumn columnProducerLevel;
    private DataColumn columnPolicyTypeID;
    private DataColumn columnLineGUID;
    private DataColumn columnCompanyGroupGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblProductionGoalDataTable()
    {
      this.TableName = "tblProductionGoal";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblProductionGoalDataTable(DataTable table)
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
    protected tblProductionGoalDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremiumGoalColumn => this.columnPremiumGoal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerLocationGUIDColumn => this.columnProducerLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerGUIDColumn => this.columnProducerGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GoalMonthColumn => this.columnGoalMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GoalYearColumn => this.columnGoalYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerLevelColumn => this.columnProducerLevel;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PolicyTypeIDColumn => this.columnPolicyTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LineGUIDColumn => this.columnLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyGroupGuidColumn => this.columnCompanyGroupGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblProductionGoalRow this[int index]
    {
      get => (dsProductionGoal.tblProductionGoalRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblProductionGoalRowChangeEventHandler tblProductionGoalRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblProductionGoalRowChangeEventHandler tblProductionGoalRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblProductionGoalRowChangeEventHandler tblProductionGoalRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblProductionGoalRowChangeEventHandler tblProductionGoalRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblProductionGoalRow(dsProductionGoal.tblProductionGoalRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblProductionGoalRow AddtblProductionGoalRow(
      Decimal PremiumGoal,
      Guid ProducerLocationGUID,
      Guid ProducerGUID,
      byte GoalMonth,
      int GoalYear,
      string ProducerLevel,
      byte PolicyTypeID,
      Guid LineGUID,
      Guid CompanyGroupGuid)
    {
      dsProductionGoal.tblProductionGoalRow row = (dsProductionGoal.tblProductionGoalRow) this.NewRow();
      object[] objArray = new object[10]
      {
        null,
        (object) PremiumGoal,
        (object) ProducerLocationGUID,
        (object) ProducerGUID,
        (object) GoalMonth,
        (object) GoalYear,
        (object) ProducerLevel,
        (object) PolicyTypeID,
        (object) LineGUID,
        (object) CompanyGroupGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblProductionGoalRow FindByID(int ID)
    {
      return (dsProductionGoal.tblProductionGoalRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsProductionGoal.tblProductionGoalDataTable productionGoalDataTable = (dsProductionGoal.tblProductionGoalDataTable) base.Clone();
      productionGoalDataTable.InitVars();
      return (DataTable) productionGoalDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProductionGoal.tblProductionGoalDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnPremiumGoal = this.Columns["PremiumGoal"];
      this.columnProducerLocationGUID = this.Columns["ProducerLocationGUID"];
      this.columnProducerGUID = this.Columns["ProducerGUID"];
      this.columnGoalMonth = this.Columns["GoalMonth"];
      this.columnGoalYear = this.Columns["GoalYear"];
      this.columnProducerLevel = this.Columns["ProducerLevel"];
      this.columnPolicyTypeID = this.Columns["PolicyTypeID"];
      this.columnLineGUID = this.Columns["LineGUID"];
      this.columnCompanyGroupGuid = this.Columns["CompanyGroupGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnPremiumGoal = new DataColumn("PremiumGoal", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremiumGoal);
      this.columnProducerLocationGUID = new DataColumn("ProducerLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGUID);
      this.columnProducerGUID = new DataColumn("ProducerGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerGUID);
      this.columnGoalMonth = new DataColumn("GoalMonth", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGoalMonth);
      this.columnGoalYear = new DataColumn("GoalYear", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGoalYear);
      this.columnProducerLevel = new DataColumn("ProducerLevel", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLevel);
      this.columnPolicyTypeID = new DataColumn("PolicyTypeID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyTypeID);
      this.columnLineGUID = new DataColumn("LineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGUID);
      this.columnCompanyGroupGuid = new DataColumn("CompanyGroupGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGroupGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnPremiumGoal.AllowDBNull = false;
      this.columnProducerLevel.AllowDBNull = false;
      this.columnProducerLevel.MaxLength = 1;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblProductionGoalRow NewtblProductionGoalRow()
    {
      return (dsProductionGoal.tblProductionGoalRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProductionGoal.tblProductionGoalRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsProductionGoal.tblProductionGoalRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProductionGoalRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblProductionGoalRowChangeEventHandler goalRowChangedEvent = this.tblProductionGoalRowChangedEvent;
      if (goalRowChangedEvent == null)
        return;
      goalRowChangedEvent((object) this, new dsProductionGoal.tblProductionGoalRowChangeEvent((dsProductionGoal.tblProductionGoalRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProductionGoalRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblProductionGoalRowChangeEventHandler rowChangingEvent = this.tblProductionGoalRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProductionGoal.tblProductionGoalRowChangeEvent((dsProductionGoal.tblProductionGoalRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProductionGoalRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblProductionGoalRowChangeEventHandler goalRowDeletedEvent = this.tblProductionGoalRowDeletedEvent;
      if (goalRowDeletedEvent == null)
        return;
      goalRowDeletedEvent((object) this, new dsProductionGoal.tblProductionGoalRowChangeEvent((dsProductionGoal.tblProductionGoalRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProductionGoalRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblProductionGoalRowChangeEventHandler rowDeletingEvent = this.tblProductionGoalRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProductionGoal.tblProductionGoalRowChangeEvent((dsProductionGoal.tblProductionGoalRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblProductionGoalRow(dsProductionGoal.tblProductionGoalRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProductionGoal dsProductionGoal = new dsProductionGoal();
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
        FixedValue = dsProductionGoal.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProductionGoalDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProductionGoal.GetSchemaSerializable();
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
  public class tblProducerLocationsDataTable : 
    TypedTableBase<dsProductionGoal.tblProducerLocationsRow>
  {
    private DataColumn columnProducerLocationGUID;
    private DataColumn columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblProducerLocationsDataTable()
    {
      this.TableName = "tblProducerLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblProducerLocationsDataTable(DataTable table)
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
    protected tblProducerLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerLocationGUIDColumn => this.columnProducerLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblProducerLocationsRow this[int index]
    {
      get => (dsProductionGoal.tblProducerLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblProducerLocationsRow(dsProductionGoal.tblProducerLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblProducerLocationsRow AddtblProducerLocationsRow(
      Guid ProducerLocationGUID,
      string Name)
    {
      dsProductionGoal.tblProducerLocationsRow row = (dsProductionGoal.tblProducerLocationsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ProducerLocationGUID,
        (object) Name
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblProducerLocationsRow FindByProducerLocationGUID(
      Guid ProducerLocationGUID)
    {
      return (dsProductionGoal.tblProducerLocationsRow) this.Rows.Find(new object[1]
      {
        (object) ProducerLocationGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsProductionGoal.tblProducerLocationsDataTable locationsDataTable = (dsProductionGoal.tblProducerLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProductionGoal.tblProducerLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerLocationGUID = this.Columns["ProducerLocationGUID"];
      this.columnName = this.Columns["Name"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnProducerLocationGUID = new DataColumn("ProducerLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGUID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnProducerLocationGUID
      }, true));
      this.columnProducerLocationGUID.AllowDBNull = false;
      this.columnProducerLocationGUID.Unique = true;
      this.columnName.AllowDBNull = false;
      this.columnName.MaxLength = 250;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblProducerLocationsRow NewtblProducerLocationsRow()
    {
      return (dsProductionGoal.tblProducerLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProductionGoal.tblProducerLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsProductionGoal.tblProducerLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblProducerLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblProducerLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsProductionGoal.tblProducerLocationsRowChangeEvent((dsProductionGoal.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblProducerLocationsRowChangeEventHandler rowChangingEvent = this.tblProducerLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProductionGoal.tblProducerLocationsRowChangeEvent((dsProductionGoal.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblProducerLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblProducerLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsProductionGoal.tblProducerLocationsRowChangeEvent((dsProductionGoal.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblProducerLocationsRowChangeEventHandler rowDeletingEvent = this.tblProducerLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProductionGoal.tblProducerLocationsRowChangeEvent((dsProductionGoal.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblProducerLocationsRow(dsProductionGoal.tblProducerLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProductionGoal dsProductionGoal = new dsProductionGoal();
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
        FixedValue = dsProductionGoal.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProductionGoal.GetSchemaSerializable();
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
  public class tblProducersDataTable : TypedTableBase<dsProductionGoal.tblProducersRow>
  {
    private DataColumn columnProducerGUID;
    private DataColumn columnProducerName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblProducersDataTable()
    {
      this.TableName = "tblProducers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblProducersDataTable(DataTable table)
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
    protected tblProducersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerGUIDColumn => this.columnProducerGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerNameColumn => this.columnProducerName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblProducersRow this[int index]
    {
      get => (dsProductionGoal.tblProducersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblProducersRowChangeEventHandler tblProducersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblProducersRowChangeEventHandler tblProducersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblProducersRowChangeEventHandler tblProducersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblProducersRowChangeEventHandler tblProducersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblProducersRow(dsProductionGoal.tblProducersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblProducersRow AddtblProducersRow(
      Guid ProducerGUID,
      string ProducerName)
    {
      dsProductionGoal.tblProducersRow row = (dsProductionGoal.tblProducersRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ProducerGUID,
        (object) ProducerName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblProducersRow FindByProducerGUID(Guid ProducerGUID)
    {
      return (dsProductionGoal.tblProducersRow) this.Rows.Find(new object[1]
      {
        (object) ProducerGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsProductionGoal.tblProducersDataTable producersDataTable = (dsProductionGoal.tblProducersDataTable) base.Clone();
      producersDataTable.InitVars();
      return (DataTable) producersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProductionGoal.tblProducersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerGUID = this.Columns["ProducerGUID"];
      this.columnProducerName = this.Columns["ProducerName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnProducerGUID = new DataColumn("ProducerGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerGUID);
      this.columnProducerName = new DataColumn("ProducerName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnProducerGUID
      }, true));
      this.columnProducerGUID.AllowDBNull = false;
      this.columnProducerGUID.Unique = true;
      this.columnProducerName.AllowDBNull = false;
      this.columnProducerName.MaxLength = 100;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblProducersRow NewtblProducersRow()
    {
      return (dsProductionGoal.tblProducersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProductionGoal.tblProducersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsProductionGoal.tblProducersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblProducersRowChangeEventHandler producersRowChangedEvent = this.tblProducersRowChangedEvent;
      if (producersRowChangedEvent == null)
        return;
      producersRowChangedEvent((object) this, new dsProductionGoal.tblProducersRowChangeEvent((dsProductionGoal.tblProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblProducersRowChangeEventHandler rowChangingEvent = this.tblProducersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProductionGoal.tblProducersRowChangeEvent((dsProductionGoal.tblProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblProducersRowChangeEventHandler producersRowDeletedEvent = this.tblProducersRowDeletedEvent;
      if (producersRowDeletedEvent == null)
        return;
      producersRowDeletedEvent((object) this, new dsProductionGoal.tblProducersRowChangeEvent((dsProductionGoal.tblProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblProducersRowChangeEventHandler rowDeletingEvent = this.tblProducersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProductionGoal.tblProducersRowChangeEvent((dsProductionGoal.tblProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblProducersRow(dsProductionGoal.tblProducersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProductionGoal dsProductionGoal = new dsProductionGoal();
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
        FixedValue = dsProductionGoal.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProductionGoal.GetSchemaSerializable();
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
  public class lstPolicyTypesDataTable : TypedTableBase<dsProductionGoal.lstPolicyTypesRow>
  {
    private DataColumn columnPolicyTypeID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstPolicyTypesDataTable()
    {
      this.TableName = "lstPolicyTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstPolicyTypesDataTable(DataTable table)
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
    protected lstPolicyTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PolicyTypeIDColumn => this.columnPolicyTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.lstPolicyTypesRow this[int index]
    {
      get => (dsProductionGoal.lstPolicyTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstPolicyTypesRow(dsProductionGoal.lstPolicyTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.lstPolicyTypesRow AddlstPolicyTypesRow(
      byte PolicyTypeID,
      string Description)
    {
      dsProductionGoal.lstPolicyTypesRow row = (dsProductionGoal.lstPolicyTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) PolicyTypeID,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsProductionGoal.lstPolicyTypesDataTable policyTypesDataTable = (dsProductionGoal.lstPolicyTypesDataTable) base.Clone();
      policyTypesDataTable.InitVars();
      return (DataTable) policyTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProductionGoal.lstPolicyTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnPolicyTypeID = this.Columns["PolicyTypeID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnPolicyTypeID = new DataColumn("PolicyTypeID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyTypeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnDescription.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.lstPolicyTypesRow NewlstPolicyTypesRow()
    {
      return (dsProductionGoal.lstPolicyTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProductionGoal.lstPolicyTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsProductionGoal.lstPolicyTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.lstPolicyTypesRowChangeEventHandler typesRowChangedEvent = this.lstPolicyTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsProductionGoal.lstPolicyTypesRowChangeEvent((dsProductionGoal.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.lstPolicyTypesRowChangeEventHandler rowChangingEvent = this.lstPolicyTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProductionGoal.lstPolicyTypesRowChangeEvent((dsProductionGoal.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.lstPolicyTypesRowChangeEventHandler typesRowDeletedEvent = this.lstPolicyTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsProductionGoal.lstPolicyTypesRowChangeEvent((dsProductionGoal.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.lstPolicyTypesRowChangeEventHandler rowDeletingEvent = this.lstPolicyTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProductionGoal.lstPolicyTypesRowChangeEvent((dsProductionGoal.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstPolicyTypesRow(dsProductionGoal.lstPolicyTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProductionGoal dsProductionGoal = new dsProductionGoal();
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
        FixedValue = dsProductionGoal.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPolicyTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProductionGoal.GetSchemaSerializable();
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
  public class lstLinesDataTable : TypedTableBase<dsProductionGoal.lstLinesRow>
  {
    private DataColumn columnLineGUID;
    private DataColumn columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstLinesDataTable()
    {
      this.TableName = "lstLines";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstLinesDataTable(DataTable table)
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
    protected lstLinesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LineGUIDColumn => this.columnLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.lstLinesRow this[int index]
    {
      get => (dsProductionGoal.lstLinesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.lstLinesRowChangeEventHandler lstLinesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.lstLinesRowChangeEventHandler lstLinesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.lstLinesRowChangeEventHandler lstLinesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.lstLinesRowChangeEventHandler lstLinesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstLinesRow(dsProductionGoal.lstLinesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.lstLinesRow AddlstLinesRow(Guid LineGUID, string LineName)
    {
      dsProductionGoal.lstLinesRow row = (dsProductionGoal.lstLinesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) LineGUID,
        (object) LineName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.lstLinesRow FindByLineGUID(Guid LineGUID)
    {
      return (dsProductionGoal.lstLinesRow) this.Rows.Find(new object[1]
      {
        (object) LineGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsProductionGoal.lstLinesDataTable lstLinesDataTable = (dsProductionGoal.lstLinesDataTable) base.Clone();
      lstLinesDataTable.InitVars();
      return (DataTable) lstLinesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProductionGoal.lstLinesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnLineGUID = this.Columns["LineGUID"];
      this.columnLineName = this.Columns["LineName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnLineGUID = new DataColumn("LineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGUID);
      this.columnLineName = new DataColumn("LineName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnLineGUID
      }, true));
      this.columnLineGUID.AllowDBNull = false;
      this.columnLineGUID.Unique = true;
      this.columnLineName.AllowDBNull = false;
      this.columnLineName.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.lstLinesRow NewlstLinesRow()
    {
      return (dsProductionGoal.lstLinesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProductionGoal.lstLinesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsProductionGoal.lstLinesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.lstLinesRowChangeEventHandler linesRowChangedEvent = this.lstLinesRowChangedEvent;
      if (linesRowChangedEvent == null)
        return;
      linesRowChangedEvent((object) this, new dsProductionGoal.lstLinesRowChangeEvent((dsProductionGoal.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.lstLinesRowChangeEventHandler rowChangingEvent = this.lstLinesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProductionGoal.lstLinesRowChangeEvent((dsProductionGoal.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.lstLinesRowChangeEventHandler linesRowDeletedEvent = this.lstLinesRowDeletedEvent;
      if (linesRowDeletedEvent == null)
        return;
      linesRowDeletedEvent((object) this, new dsProductionGoal.lstLinesRowChangeEvent((dsProductionGoal.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstLinesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.lstLinesRowChangeEventHandler rowDeletingEvent = this.lstLinesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProductionGoal.lstLinesRowChangeEvent((dsProductionGoal.lstLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstLinesRow(dsProductionGoal.lstLinesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProductionGoal dsProductionGoal = new dsProductionGoal();
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
        FixedValue = dsProductionGoal.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstLinesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProductionGoal.GetSchemaSerializable();
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
  public class tblCompanyGroupsDataTable : TypedTableBase<dsProductionGoal.tblCompanyGroupsRow>
  {
    private DataColumn columnCompanyGroupGuid;
    private DataColumn columnCompanyGroupName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyGroupsDataTable()
    {
      this.TableName = "tblCompanyGroups";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyGroupsDataTable(DataTable table)
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
    protected tblCompanyGroupsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyGroupGuidColumn => this.columnCompanyGroupGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyGroupNameColumn => this.columnCompanyGroupName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblCompanyGroupsRow this[int index]
    {
      get => (dsProductionGoal.tblCompanyGroupsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblCompanyGroupsRowChangeEventHandler tblCompanyGroupsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblCompanyGroupsRowChangeEventHandler tblCompanyGroupsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblCompanyGroupsRowChangeEventHandler tblCompanyGroupsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProductionGoal.tblCompanyGroupsRowChangeEventHandler tblCompanyGroupsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyGroupsRow(dsProductionGoal.tblCompanyGroupsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblCompanyGroupsRow AddtblCompanyGroupsRow(
      Guid CompanyGroupGuid,
      string CompanyGroupName)
    {
      dsProductionGoal.tblCompanyGroupsRow row = (dsProductionGoal.tblCompanyGroupsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyGroupGuid,
        (object) CompanyGroupName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblCompanyGroupsRow FindByCompanyGroupGuid(Guid CompanyGroupGuid)
    {
      return (dsProductionGoal.tblCompanyGroupsRow) this.Rows.Find(new object[1]
      {
        (object) CompanyGroupGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsProductionGoal.tblCompanyGroupsDataTable companyGroupsDataTable = (dsProductionGoal.tblCompanyGroupsDataTable) base.Clone();
      companyGroupsDataTable.InitVars();
      return (DataTable) companyGroupsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProductionGoal.tblCompanyGroupsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyGroupGuid = this.Columns["CompanyGroupGuid"];
      this.columnCompanyGroupName = this.Columns["CompanyGroupName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyGroupGuid = new DataColumn("CompanyGroupGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGroupGuid);
      this.columnCompanyGroupName = new DataColumn("CompanyGroupName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGroupName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompaniesKey9", new DataColumn[1]
      {
        this.columnCompanyGroupGuid
      }, true));
      this.columnCompanyGroupGuid.AllowDBNull = false;
      this.columnCompanyGroupGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblCompanyGroupsRow NewtblCompanyGroupsRow()
    {
      return (dsProductionGoal.tblCompanyGroupsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProductionGoal.tblCompanyGroupsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsProductionGoal.tblCompanyGroupsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyGroupsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblCompanyGroupsRowChangeEventHandler groupsRowChangedEvent = this.tblCompanyGroupsRowChangedEvent;
      if (groupsRowChangedEvent == null)
        return;
      groupsRowChangedEvent((object) this, new dsProductionGoal.tblCompanyGroupsRowChangeEvent((dsProductionGoal.tblCompanyGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyGroupsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblCompanyGroupsRowChangeEventHandler rowChangingEvent = this.tblCompanyGroupsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProductionGoal.tblCompanyGroupsRowChangeEvent((dsProductionGoal.tblCompanyGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyGroupsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblCompanyGroupsRowChangeEventHandler groupsRowDeletedEvent = this.tblCompanyGroupsRowDeletedEvent;
      if (groupsRowDeletedEvent == null)
        return;
      groupsRowDeletedEvent((object) this, new dsProductionGoal.tblCompanyGroupsRowChangeEvent((dsProductionGoal.tblCompanyGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyGroupsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProductionGoal.tblCompanyGroupsRowChangeEventHandler rowDeletingEvent = this.tblCompanyGroupsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProductionGoal.tblCompanyGroupsRowChangeEvent((dsProductionGoal.tblCompanyGroupsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyGroupsRow(dsProductionGoal.tblCompanyGroupsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProductionGoal dsProductionGoal = new dsProductionGoal();
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
        FixedValue = dsProductionGoal.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyGroupsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProductionGoal.GetSchemaSerializable();
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

  public class dtMonthRow : DataRow
  {
    private dsProductionGoal.dtMonthDataTable tabledtMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtMonthRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtMonth = (dsProductionGoal.dtMonthDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte Month
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabledtMonth.MonthColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Month' in table 'dtMonth' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtMonth.MonthColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MonthName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtMonth.MonthNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MonthName' in table 'dtMonth' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtMonth.MonthNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMonthNull() => this.IsNull(this.tabledtMonth.MonthColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMonthNull()
    {
      this[this.tabledtMonth.MonthColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMonthNameNull() => this.IsNull(this.tabledtMonth.MonthNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMonthNameNull()
    {
      this[this.tabledtMonth.MonthNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtYearRow : DataRow
  {
    private dsProductionGoal.dtYearDataTable tabledtYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtYearRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtYear = (dsProductionGoal.dtYearDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Year
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledtYear.YearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Year' in table 'dtYear' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtYear.YearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string YearName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtYear.YearNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'YearName' in table 'dtYear' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtYear.YearNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsYearNull() => this.IsNull(this.tabledtYear.YearColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetYearNull()
    {
      this[this.tabledtYear.YearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsYearNameNull() => this.IsNull(this.tabledtYear.YearNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetYearNameNull()
    {
      this[this.tabledtYear.YearNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblProductionGoalRow : DataRow
  {
    private dsProductionGoal.tblProductionGoalDataTable tabletblProductionGoal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblProductionGoalRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProductionGoal = (dsProductionGoal.tblProductionGoalDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblProductionGoal.IDColumn]);
      set => this[this.tabletblProductionGoal.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal PremiumGoal
    {
      get => Conversions.ToDecimal(this[this.tabletblProductionGoal.PremiumGoalColumn]);
      set => this[this.tabletblProductionGoal.PremiumGoalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ProducerLocationGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProductionGoal.ProducerLocationGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationGUID' in table 'tblProductionGoal' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProductionGoal.ProducerLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ProducerGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProductionGoal.ProducerGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerGUID' in table 'tblProductionGoal' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProductionGoal.ProducerGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte GoalMonth
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabletblProductionGoal.GoalMonthColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GoalMonth' in table 'tblProductionGoal' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProductionGoal.GoalMonthColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GoalYear
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProductionGoal.GoalYearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GoalYear' in table 'tblProductionGoal' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProductionGoal.GoalYearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerLevel
    {
      get => Conversions.ToString(this[this.tabletblProductionGoal.ProducerLevelColumn]);
      set => this[this.tabletblProductionGoal.ProducerLevelColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte PolicyTypeID
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabletblProductionGoal.PolicyTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyTypeID' in table 'tblProductionGoal' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProductionGoal.PolicyTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid LineGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProductionGoal.LineGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LineGUID' in table 'tblProductionGoal' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProductionGoal.LineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyGroupGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProductionGoal.CompanyGroupGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyGroupGuid' in table 'tblProductionGoal' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProductionGoal.CompanyGroupGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerLocationGUIDNull()
    {
      return this.IsNull(this.tabletblProductionGoal.ProducerLocationGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerLocationGUIDNull()
    {
      this[this.tabletblProductionGoal.ProducerLocationGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerGUIDNull() => this.IsNull(this.tabletblProductionGoal.ProducerGUIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerGUIDNull()
    {
      this[this.tabletblProductionGoal.ProducerGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGoalMonthNull() => this.IsNull(this.tabletblProductionGoal.GoalMonthColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGoalMonthNull()
    {
      this[this.tabletblProductionGoal.GoalMonthColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGoalYearNull() => this.IsNull(this.tabletblProductionGoal.GoalYearColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGoalYearNull()
    {
      this[this.tabletblProductionGoal.GoalYearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicyTypeIDNull() => this.IsNull(this.tabletblProductionGoal.PolicyTypeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicyTypeIDNull()
    {
      this[this.tabletblProductionGoal.PolicyTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLineGUIDNull() => this.IsNull(this.tabletblProductionGoal.LineGUIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLineGUIDNull()
    {
      this[this.tabletblProductionGoal.LineGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompanyGroupGuidNull()
    {
      return this.IsNull(this.tabletblProductionGoal.CompanyGroupGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompanyGroupGuidNull()
    {
      this[this.tabletblProductionGoal.CompanyGroupGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblProducerLocationsRow : DataRow
  {
    private dsProductionGoal.tblProducerLocationsDataTable tabletblProducerLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblProducerLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerLocations = (dsProductionGoal.tblProducerLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ProducerLocationGUID
    {
      get
      {
        object obj = this[this.tabletblProducerLocations.ProducerLocationGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducerLocations.ProducerLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Name
    {
      get => Conversions.ToString(this[this.tabletblProducerLocations.NameColumn]);
      set => this[this.tabletblProducerLocations.NameColumn] = (object) value;
    }
  }

  public class tblProducersRow : DataRow
  {
    private dsProductionGoal.tblProducersDataTable tabletblProducers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblProducersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducers = (dsProductionGoal.tblProducersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ProducerGUID
    {
      get
      {
        object obj = this[this.tabletblProducers.ProducerGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducers.ProducerGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerName
    {
      get => Conversions.ToString(this[this.tabletblProducers.ProducerNameColumn]);
      set => this[this.tabletblProducers.ProducerNameColumn] = (object) value;
    }
  }

  public class lstPolicyTypesRow : DataRow
  {
    private dsProductionGoal.lstPolicyTypesDataTable tablelstPolicyTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstPolicyTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPolicyTypes = (dsProductionGoal.lstPolicyTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte PolicyTypeID
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tablelstPolicyTypes.PolicyTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyTypeID' in table 'lstPolicyTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstPolicyTypes.PolicyTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstPolicyTypes.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'lstPolicyTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstPolicyTypes.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicyTypeIDNull() => this.IsNull(this.tablelstPolicyTypes.PolicyTypeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicyTypeIDNull()
    {
      this[this.tablelstPolicyTypes.PolicyTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tablelstPolicyTypes.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tablelstPolicyTypes.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstLinesRow : DataRow
  {
    private dsProductionGoal.lstLinesDataTable tablelstLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstLines = (dsProductionGoal.lstLinesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid LineGUID
    {
      get
      {
        object obj = this[this.tablelstLines.LineGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tablelstLines.LineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LineName
    {
      get => Conversions.ToString(this[this.tablelstLines.LineNameColumn]);
      set => this[this.tablelstLines.LineNameColumn] = (object) value;
    }
  }

  public class tblCompanyGroupsRow : DataRow
  {
    private dsProductionGoal.tblCompanyGroupsDataTable tabletblCompanyGroups;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyGroupsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyGroups = (dsProductionGoal.tblCompanyGroupsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyGroupGuid
    {
      get
      {
        object obj = this[this.tabletblCompanyGroups.CompanyGroupGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyGroups.CompanyGroupGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CompanyGroupName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyGroups.CompanyGroupNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyGroupName' in table 'tblCompanyGroups' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyGroups.CompanyGroupNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompanyGroupNameNull()
    {
      return this.IsNull(this.tabletblCompanyGroups.CompanyGroupNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompanyGroupNameNull()
    {
      this[this.tabletblCompanyGroups.CompanyGroupNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class dtMonthRowChangeEvent : EventArgs
  {
    private dsProductionGoal.dtMonthRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtMonthRowChangeEvent(dsProductionGoal.dtMonthRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.dtMonthRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class dtYearRowChangeEvent : EventArgs
  {
    private dsProductionGoal.dtYearRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtYearRowChangeEvent(dsProductionGoal.dtYearRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.dtYearRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblProductionGoalRowChangeEvent : EventArgs
  {
    private dsProductionGoal.tblProductionGoalRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblProductionGoalRowChangeEvent(
      dsProductionGoal.tblProductionGoalRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblProductionGoalRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblProducerLocationsRowChangeEvent : EventArgs
  {
    private dsProductionGoal.tblProducerLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblProducerLocationsRowChangeEvent(
      dsProductionGoal.tblProducerLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblProducerLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblProducersRowChangeEvent : EventArgs
  {
    private dsProductionGoal.tblProducersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblProducersRowChangeEvent(dsProductionGoal.tblProducersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblProducersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstPolicyTypesRowChangeEvent : EventArgs
  {
    private dsProductionGoal.lstPolicyTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstPolicyTypesRowChangeEvent(
      dsProductionGoal.lstPolicyTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.lstPolicyTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstLinesRowChangeEvent : EventArgs
  {
    private dsProductionGoal.lstLinesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstLinesRowChangeEvent(dsProductionGoal.lstLinesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.lstLinesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyGroupsRowChangeEvent : EventArgs
  {
    private dsProductionGoal.tblCompanyGroupsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyGroupsRowChangeEvent(
      dsProductionGoal.tblCompanyGroupsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProductionGoal.tblCompanyGroupsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
