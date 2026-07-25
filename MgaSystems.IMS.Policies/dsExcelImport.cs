// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsExcelImport
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
[XmlRoot("dsExcelImport")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsExcelImport : DataSet
{
  private dsExcelImport.ImportMappingsDataTable tableImportMappings;
  private dsExcelImport.SpreadsheetColumnsDataTable tableSpreadsheetColumns;
  private dsExcelImport.IMSColumnsDataTable tableIMSColumns;
  private dsExcelImport.tblClaimInformationDataTable tabletblClaimInformation;
  private dsExcelImport.tblClaimResPaymentActivityDataTable tabletblClaimResPaymentActivity;
  private dsExcelImport.SpreadsheetDateColumnsDataTable tableSpreadsheetDateColumns;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsExcelImport()
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
  protected dsExcelImport(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (ImportMappings)] != null)
          base.Tables.Add((DataTable) new dsExcelImport.ImportMappingsDataTable(dataSet.Tables[nameof (ImportMappings)]));
        if (dataSet.Tables[nameof (SpreadsheetColumns)] != null)
          base.Tables.Add((DataTable) new dsExcelImport.SpreadsheetColumnsDataTable(dataSet.Tables[nameof (SpreadsheetColumns)]));
        if (dataSet.Tables[nameof (IMSColumns)] != null)
          base.Tables.Add((DataTable) new dsExcelImport.IMSColumnsDataTable(dataSet.Tables[nameof (IMSColumns)]));
        if (dataSet.Tables[nameof (tblClaimInformation)] != null)
          base.Tables.Add((DataTable) new dsExcelImport.tblClaimInformationDataTable(dataSet.Tables[nameof (tblClaimInformation)]));
        if (dataSet.Tables[nameof (tblClaimResPaymentActivity)] != null)
          base.Tables.Add((DataTable) new dsExcelImport.tblClaimResPaymentActivityDataTable(dataSet.Tables[nameof (tblClaimResPaymentActivity)]));
        if (dataSet.Tables[nameof (SpreadsheetDateColumns)] != null)
          base.Tables.Add((DataTable) new dsExcelImport.SpreadsheetDateColumnsDataTable(dataSet.Tables[nameof (SpreadsheetDateColumns)]));
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
  public dsExcelImport.ImportMappingsDataTable ImportMappings => this.tableImportMappings;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsExcelImport.SpreadsheetColumnsDataTable SpreadsheetColumns
  {
    get => this.tableSpreadsheetColumns;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsExcelImport.IMSColumnsDataTable IMSColumns => this.tableIMSColumns;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsExcelImport.tblClaimInformationDataTable tblClaimInformation
  {
    get => this.tabletblClaimInformation;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsExcelImport.tblClaimResPaymentActivityDataTable tblClaimResPaymentActivity
  {
    get => this.tabletblClaimResPaymentActivity;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsExcelImport.SpreadsheetDateColumnsDataTable SpreadsheetDateColumns
  {
    get => this.tableSpreadsheetDateColumns;
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
    dsExcelImport dsExcelImport = (dsExcelImport) base.Clone();
    dsExcelImport.InitVars();
    dsExcelImport.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsExcelImport;
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
      if (dataSet.Tables["ImportMappings"] != null)
        base.Tables.Add((DataTable) new dsExcelImport.ImportMappingsDataTable(dataSet.Tables["ImportMappings"]));
      if (dataSet.Tables["SpreadsheetColumns"] != null)
        base.Tables.Add((DataTable) new dsExcelImport.SpreadsheetColumnsDataTable(dataSet.Tables["SpreadsheetColumns"]));
      if (dataSet.Tables["IMSColumns"] != null)
        base.Tables.Add((DataTable) new dsExcelImport.IMSColumnsDataTable(dataSet.Tables["IMSColumns"]));
      if (dataSet.Tables["tblClaimInformation"] != null)
        base.Tables.Add((DataTable) new dsExcelImport.tblClaimInformationDataTable(dataSet.Tables["tblClaimInformation"]));
      if (dataSet.Tables["tblClaimResPaymentActivity"] != null)
        base.Tables.Add((DataTable) new dsExcelImport.tblClaimResPaymentActivityDataTable(dataSet.Tables["tblClaimResPaymentActivity"]));
      if (dataSet.Tables["SpreadsheetDateColumns"] != null)
        base.Tables.Add((DataTable) new dsExcelImport.SpreadsheetDateColumnsDataTable(dataSet.Tables["SpreadsheetDateColumns"]));
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
    this.tableImportMappings = (dsExcelImport.ImportMappingsDataTable) base.Tables["ImportMappings"];
    if (initTable && this.tableImportMappings != null)
      this.tableImportMappings.InitVars();
    this.tableSpreadsheetColumns = (dsExcelImport.SpreadsheetColumnsDataTable) base.Tables["SpreadsheetColumns"];
    if (initTable && this.tableSpreadsheetColumns != null)
      this.tableSpreadsheetColumns.InitVars();
    this.tableIMSColumns = (dsExcelImport.IMSColumnsDataTable) base.Tables["IMSColumns"];
    if (initTable && this.tableIMSColumns != null)
      this.tableIMSColumns.InitVars();
    this.tabletblClaimInformation = (dsExcelImport.tblClaimInformationDataTable) base.Tables["tblClaimInformation"];
    if (initTable && this.tabletblClaimInformation != null)
      this.tabletblClaimInformation.InitVars();
    this.tabletblClaimResPaymentActivity = (dsExcelImport.tblClaimResPaymentActivityDataTable) base.Tables["tblClaimResPaymentActivity"];
    if (initTable && this.tabletblClaimResPaymentActivity != null)
      this.tabletblClaimResPaymentActivity.InitVars();
    this.tableSpreadsheetDateColumns = (dsExcelImport.SpreadsheetDateColumnsDataTable) base.Tables["SpreadsheetDateColumns"];
    if (!initTable || this.tableSpreadsheetDateColumns == null)
      return;
    this.tableSpreadsheetDateColumns.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsExcelImport);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsExcelImport.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableImportMappings = new dsExcelImport.ImportMappingsDataTable();
    base.Tables.Add((DataTable) this.tableImportMappings);
    this.tableSpreadsheetColumns = new dsExcelImport.SpreadsheetColumnsDataTable();
    base.Tables.Add((DataTable) this.tableSpreadsheetColumns);
    this.tableIMSColumns = new dsExcelImport.IMSColumnsDataTable();
    base.Tables.Add((DataTable) this.tableIMSColumns);
    this.tabletblClaimInformation = new dsExcelImport.tblClaimInformationDataTable();
    base.Tables.Add((DataTable) this.tabletblClaimInformation);
    this.tabletblClaimResPaymentActivity = new dsExcelImport.tblClaimResPaymentActivityDataTable();
    base.Tables.Add((DataTable) this.tabletblClaimResPaymentActivity);
    this.tableSpreadsheetDateColumns = new dsExcelImport.SpreadsheetDateColumnsDataTable();
    base.Tables.Add((DataTable) this.tableSpreadsheetDateColumns);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeImportMappings() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeSpreadsheetColumns() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeIMSColumns() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblClaimInformation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblClaimResPaymentActivity() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeSpreadsheetDateColumns() => false;

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
    dsExcelImport dsExcelImport = new dsExcelImport();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsExcelImport.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsExcelImport.GetSchemaSerializable();
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
  public delegate void ImportMappingsRowChangeEventHandler(
    object sender,
    dsExcelImport.ImportMappingsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void SpreadsheetColumnsRowChangeEventHandler(
    object sender,
    dsExcelImport.SpreadsheetColumnsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void IMSColumnsRowChangeEventHandler(
    object sender,
    dsExcelImport.IMSColumnsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblClaimInformationRowChangeEventHandler(
    object sender,
    dsExcelImport.tblClaimInformationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblClaimResPaymentActivityRowChangeEventHandler(
    object sender,
    dsExcelImport.tblClaimResPaymentActivityRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void SpreadsheetDateColumnsRowChangeEventHandler(
    object sender,
    dsExcelImport.SpreadsheetDateColumnsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class ImportMappingsDataTable : TypedTableBase<dsExcelImport.ImportMappingsRow>
  {
    private DataColumn columnIMSColumn;
    private DataColumn columnSpreadsheetColumn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public ImportMappingsDataTable()
    {
      this.TableName = "ImportMappings";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal ImportMappingsDataTable(DataTable table)
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
    protected ImportMappingsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IMSColumnColumn => this.columnIMSColumn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SpreadsheetColumnColumn => this.columnSpreadsheetColumn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.ImportMappingsRow this[int index]
    {
      get => (dsExcelImport.ImportMappingsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.ImportMappingsRowChangeEventHandler ImportMappingsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.ImportMappingsRowChangeEventHandler ImportMappingsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.ImportMappingsRowChangeEventHandler ImportMappingsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.ImportMappingsRowChangeEventHandler ImportMappingsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddImportMappingsRow(dsExcelImport.ImportMappingsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.ImportMappingsRow AddImportMappingsRow(
      string IMSColumn,
      string SpreadsheetColumn)
    {
      dsExcelImport.ImportMappingsRow row = (dsExcelImport.ImportMappingsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) IMSColumn,
        (object) SpreadsheetColumn
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.ImportMappingsRow FindByIMSColumn(string IMSColumn)
    {
      return (dsExcelImport.ImportMappingsRow) this.Rows.Find(new object[1]
      {
        (object) IMSColumn
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsExcelImport.ImportMappingsDataTable mappingsDataTable = (dsExcelImport.ImportMappingsDataTable) base.Clone();
      mappingsDataTable.InitVars();
      return (DataTable) mappingsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExcelImport.ImportMappingsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnIMSColumn = this.Columns["IMSColumn"];
      this.columnSpreadsheetColumn = this.Columns["SpreadsheetColumn"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnIMSColumn = new DataColumn("IMSColumn", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIMSColumn);
      this.columnSpreadsheetColumn = new DataColumn("SpreadsheetColumn", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpreadsheetColumn);
      this.Constraints.Add((Constraint) new UniqueConstraint("ImportMappingsKey1", new DataColumn[1]
      {
        this.columnIMSColumn
      }, true));
      this.columnIMSColumn.AllowDBNull = false;
      this.columnIMSColumn.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.ImportMappingsRow NewImportMappingsRow()
    {
      return (dsExcelImport.ImportMappingsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExcelImport.ImportMappingsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsExcelImport.ImportMappingsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ImportMappingsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.ImportMappingsRowChangeEventHandler mappingsRowChangedEvent = this.ImportMappingsRowChangedEvent;
      if (mappingsRowChangedEvent == null)
        return;
      mappingsRowChangedEvent((object) this, new dsExcelImport.ImportMappingsRowChangeEvent((dsExcelImport.ImportMappingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ImportMappingsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.ImportMappingsRowChangeEventHandler rowChangingEvent = this.ImportMappingsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExcelImport.ImportMappingsRowChangeEvent((dsExcelImport.ImportMappingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ImportMappingsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.ImportMappingsRowChangeEventHandler mappingsRowDeletedEvent = this.ImportMappingsRowDeletedEvent;
      if (mappingsRowDeletedEvent == null)
        return;
      mappingsRowDeletedEvent((object) this, new dsExcelImport.ImportMappingsRowChangeEvent((dsExcelImport.ImportMappingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ImportMappingsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.ImportMappingsRowChangeEventHandler rowDeletingEvent = this.ImportMappingsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExcelImport.ImportMappingsRowChangeEvent((dsExcelImport.ImportMappingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveImportMappingsRow(dsExcelImport.ImportMappingsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsExcelImport dsExcelImport = new dsExcelImport();
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
        FixedValue = dsExcelImport.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ImportMappingsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsExcelImport.GetSchemaSerializable();
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
  public class SpreadsheetColumnsDataTable : TypedTableBase<dsExcelImport.SpreadsheetColumnsRow>
  {
    private DataColumn columnSpreadsheetColumn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public SpreadsheetColumnsDataTable()
    {
      this.TableName = "SpreadsheetColumns";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal SpreadsheetColumnsDataTable(DataTable table)
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
    protected SpreadsheetColumnsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SpreadsheetColumnColumn => this.columnSpreadsheetColumn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.SpreadsheetColumnsRow this[int index]
    {
      get => (dsExcelImport.SpreadsheetColumnsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.SpreadsheetColumnsRowChangeEventHandler SpreadsheetColumnsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.SpreadsheetColumnsRowChangeEventHandler SpreadsheetColumnsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.SpreadsheetColumnsRowChangeEventHandler SpreadsheetColumnsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.SpreadsheetColumnsRowChangeEventHandler SpreadsheetColumnsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddSpreadsheetColumnsRow(dsExcelImport.SpreadsheetColumnsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.SpreadsheetColumnsRow AddSpreadsheetColumnsRow(string SpreadsheetColumn)
    {
      dsExcelImport.SpreadsheetColumnsRow row = (dsExcelImport.SpreadsheetColumnsRow) this.NewRow();
      object[] objArray = new object[1]
      {
        (object) SpreadsheetColumn
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsExcelImport.SpreadsheetColumnsDataTable columnsDataTable = (dsExcelImport.SpreadsheetColumnsDataTable) base.Clone();
      columnsDataTable.InitVars();
      return (DataTable) columnsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExcelImport.SpreadsheetColumnsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars() => this.columnSpreadsheetColumn = this.Columns["SpreadsheetColumn"];

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnSpreadsheetColumn = new DataColumn("SpreadsheetColumn", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpreadsheetColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.SpreadsheetColumnsRow NewSpreadsheetColumnsRow()
    {
      return (dsExcelImport.SpreadsheetColumnsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExcelImport.SpreadsheetColumnsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsExcelImport.SpreadsheetColumnsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SpreadsheetColumnsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.SpreadsheetColumnsRowChangeEventHandler columnsRowChangedEvent = this.SpreadsheetColumnsRowChangedEvent;
      if (columnsRowChangedEvent == null)
        return;
      columnsRowChangedEvent((object) this, new dsExcelImport.SpreadsheetColumnsRowChangeEvent((dsExcelImport.SpreadsheetColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SpreadsheetColumnsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.SpreadsheetColumnsRowChangeEventHandler rowChangingEvent = this.SpreadsheetColumnsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExcelImport.SpreadsheetColumnsRowChangeEvent((dsExcelImport.SpreadsheetColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SpreadsheetColumnsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.SpreadsheetColumnsRowChangeEventHandler columnsRowDeletedEvent = this.SpreadsheetColumnsRowDeletedEvent;
      if (columnsRowDeletedEvent == null)
        return;
      columnsRowDeletedEvent((object) this, new dsExcelImport.SpreadsheetColumnsRowChangeEvent((dsExcelImport.SpreadsheetColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SpreadsheetColumnsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.SpreadsheetColumnsRowChangeEventHandler rowDeletingEvent = this.SpreadsheetColumnsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExcelImport.SpreadsheetColumnsRowChangeEvent((dsExcelImport.SpreadsheetColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveSpreadsheetColumnsRow(dsExcelImport.SpreadsheetColumnsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsExcelImport dsExcelImport = new dsExcelImport();
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
        FixedValue = dsExcelImport.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (SpreadsheetColumnsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsExcelImport.GetSchemaSerializable();
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
  public class IMSColumnsDataTable : TypedTableBase<dsExcelImport.IMSColumnsRow>
  {
    private DataColumn columnIMSColumn;
    private DataColumn columnIMSTable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public IMSColumnsDataTable()
    {
      this.TableName = "IMSColumns";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal IMSColumnsDataTable(DataTable table)
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
    protected IMSColumnsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IMSColumnColumn => this.columnIMSColumn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IMSTableColumn => this.columnIMSTable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.IMSColumnsRow this[int index]
    {
      get => (dsExcelImport.IMSColumnsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.IMSColumnsRowChangeEventHandler IMSColumnsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.IMSColumnsRowChangeEventHandler IMSColumnsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.IMSColumnsRowChangeEventHandler IMSColumnsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.IMSColumnsRowChangeEventHandler IMSColumnsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddIMSColumnsRow(dsExcelImport.IMSColumnsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.IMSColumnsRow AddIMSColumnsRow(string IMSColumn, string IMSTable)
    {
      dsExcelImport.IMSColumnsRow row = (dsExcelImport.IMSColumnsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) IMSColumn,
        (object) IMSTable
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.IMSColumnsRow FindByIMSColumn(string IMSColumn)
    {
      return (dsExcelImport.IMSColumnsRow) this.Rows.Find(new object[1]
      {
        (object) IMSColumn
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsExcelImport.IMSColumnsDataTable columnsDataTable = (dsExcelImport.IMSColumnsDataTable) base.Clone();
      columnsDataTable.InitVars();
      return (DataTable) columnsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExcelImport.IMSColumnsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnIMSColumn = this.Columns["IMSColumn"];
      this.columnIMSTable = this.Columns["IMSTable"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnIMSColumn = new DataColumn("IMSColumn", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIMSColumn);
      this.columnIMSTable = new DataColumn("IMSTable", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIMSTable);
      this.Constraints.Add((Constraint) new UniqueConstraint("IMSColumnsKey1", new DataColumn[1]
      {
        this.columnIMSColumn
      }, true));
      this.columnIMSColumn.AllowDBNull = false;
      this.columnIMSColumn.Unique = true;
      this.columnIMSTable.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.IMSColumnsRow NewIMSColumnsRow()
    {
      return (dsExcelImport.IMSColumnsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExcelImport.IMSColumnsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsExcelImport.IMSColumnsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.IMSColumnsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.IMSColumnsRowChangeEventHandler columnsRowChangedEvent = this.IMSColumnsRowChangedEvent;
      if (columnsRowChangedEvent == null)
        return;
      columnsRowChangedEvent((object) this, new dsExcelImport.IMSColumnsRowChangeEvent((dsExcelImport.IMSColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.IMSColumnsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.IMSColumnsRowChangeEventHandler rowChangingEvent = this.IMSColumnsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExcelImport.IMSColumnsRowChangeEvent((dsExcelImport.IMSColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.IMSColumnsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.IMSColumnsRowChangeEventHandler columnsRowDeletedEvent = this.IMSColumnsRowDeletedEvent;
      if (columnsRowDeletedEvent == null)
        return;
      columnsRowDeletedEvent((object) this, new dsExcelImport.IMSColumnsRowChangeEvent((dsExcelImport.IMSColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.IMSColumnsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.IMSColumnsRowChangeEventHandler rowDeletingEvent = this.IMSColumnsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExcelImport.IMSColumnsRowChangeEvent((dsExcelImport.IMSColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveIMSColumnsRow(dsExcelImport.IMSColumnsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsExcelImport dsExcelImport = new dsExcelImport();
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
        FixedValue = dsExcelImport.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (IMSColumnsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsExcelImport.GetSchemaSerializable();
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
  public class tblClaimInformationDataTable : TypedTableBase<dsExcelImport.tblClaimInformationRow>
  {
    private DataColumn columnClaimID;
    private DataColumn columnControlNo;
    private DataColumn columnClaimNo;
    private DataColumn columnDateReceived;
    private DataColumn columnDateReported;
    private DataColumn columnLossDate;
    private DataColumn columnLossType;
    private DataColumn columnStatus;
    private DataColumn columnDateClosed;
    private DataColumn columnInLitigation;
    private DataColumn columnDescriptionInjury;
    private DataColumn columnCATNo;
    private DataColumn columnImportedID;
    private DataColumn columnReadOnly;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblClaimInformationDataTable()
    {
      this.TableName = "tblClaimInformation";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblClaimInformationDataTable(DataTable table)
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
    protected tblClaimInformationDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClaimIDColumn => this.columnClaimID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClaimNoColumn => this.columnClaimNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateReceivedColumn => this.columnDateReceived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateReportedColumn => this.columnDateReported;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LossDateColumn => this.columnLossDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LossTypeColumn => this.columnLossType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateClosedColumn => this.columnDateClosed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InLitigationColumn => this.columnInLitigation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionInjuryColumn => this.columnDescriptionInjury;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CATNoColumn => this.columnCATNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ImportedIDColumn => this.columnImportedID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ReadOnlyColumn => this.columnReadOnly;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.tblClaimInformationRow this[int index]
    {
      get => (dsExcelImport.tblClaimInformationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.tblClaimInformationRowChangeEventHandler tblClaimInformationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.tblClaimInformationRowChangeEventHandler tblClaimInformationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.tblClaimInformationRowChangeEventHandler tblClaimInformationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.tblClaimInformationRowChangeEventHandler tblClaimInformationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblClaimInformationRow(dsExcelImport.tblClaimInformationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.tblClaimInformationRow AddtblClaimInformationRow(
      int ControlNo,
      string ClaimNo,
      DateTime DateReceived,
      DateTime DateReported,
      DateTime LossDate,
      string LossType,
      string Status,
      DateTime DateClosed,
      bool InLitigation,
      string DescriptionInjury,
      string CATNo,
      int ImportedID,
      bool _ReadOnly)
    {
      dsExcelImport.tblClaimInformationRow row = (dsExcelImport.tblClaimInformationRow) this.NewRow();
      object[] objArray = new object[14]
      {
        null,
        (object) ControlNo,
        (object) ClaimNo,
        (object) DateReceived,
        (object) DateReported,
        (object) LossDate,
        (object) LossType,
        (object) Status,
        (object) DateClosed,
        (object) InLitigation,
        (object) DescriptionInjury,
        (object) CATNo,
        (object) ImportedID,
        (object) _ReadOnly
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.tblClaimInformationRow FindByClaimID(int ClaimID)
    {
      return (dsExcelImport.tblClaimInformationRow) this.Rows.Find(new object[1]
      {
        (object) ClaimID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsExcelImport.tblClaimInformationDataTable informationDataTable = (dsExcelImport.tblClaimInformationDataTable) base.Clone();
      informationDataTable.InitVars();
      return (DataTable) informationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExcelImport.tblClaimInformationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnClaimID = this.Columns["ClaimID"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnClaimNo = this.Columns["ClaimNo"];
      this.columnDateReceived = this.Columns["DateReceived"];
      this.columnDateReported = this.Columns["DateReported"];
      this.columnLossDate = this.Columns["LossDate"];
      this.columnLossType = this.Columns["LossType"];
      this.columnStatus = this.Columns["Status"];
      this.columnDateClosed = this.Columns["DateClosed"];
      this.columnInLitigation = this.Columns["InLitigation"];
      this.columnDescriptionInjury = this.Columns["DescriptionInjury"];
      this.columnCATNo = this.Columns["CATNo"];
      this.columnImportedID = this.Columns["ImportedID"];
      this.columnReadOnly = this.Columns["ReadOnly"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnClaimID = new DataColumn("ClaimID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimID);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnClaimNo = new DataColumn("ClaimNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimNo);
      this.columnDateReceived = new DataColumn("DateReceived", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateReceived);
      this.columnDateReported = new DataColumn("DateReported", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateReported);
      this.columnLossDate = new DataColumn("LossDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLossDate);
      this.columnLossType = new DataColumn("LossType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLossType);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnDateClosed = new DataColumn("DateClosed", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateClosed);
      this.columnInLitigation = new DataColumn("InLitigation", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInLitigation);
      this.columnDescriptionInjury = new DataColumn("DescriptionInjury", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescriptionInjury);
      this.columnCATNo = new DataColumn("CATNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCATNo);
      this.columnImportedID = new DataColumn("ImportedID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnImportedID);
      this.columnReadOnly = new DataColumn("ReadOnly", typeof (bool), (string) null, MappingType.Element);
      this.columnReadOnly.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "ReadOnlyColumn");
      this.columnReadOnly.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnReadOnly");
      this.columnReadOnly.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "ReadOnly");
      this.Columns.Add(this.columnReadOnly);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnClaimID
      }, true));
      this.columnClaimID.AutoIncrement = true;
      this.columnClaimID.AllowDBNull = false;
      this.columnClaimID.ReadOnly = true;
      this.columnClaimID.Unique = true;
      this.columnControlNo.AllowDBNull = false;
      this.columnClaimNo.AllowDBNull = false;
      this.columnClaimNo.MaxLength = 50;
      this.columnDateReceived.AllowDBNull = false;
      this.columnDateReported.AllowDBNull = false;
      this.columnLossDate.AllowDBNull = false;
      this.columnLossType.AllowDBNull = false;
      this.columnLossType.MaxLength = 50;
      this.columnStatus.AllowDBNull = false;
      this.columnStatus.MaxLength = 50;
      this.columnInLitigation.AllowDBNull = false;
      this.columnDescriptionInjury.MaxLength = 500;
      this.columnCATNo.MaxLength = 10;
      this.columnReadOnly.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.tblClaimInformationRow NewtblClaimInformationRow()
    {
      return (dsExcelImport.tblClaimInformationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExcelImport.tblClaimInformationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsExcelImport.tblClaimInformationRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClaimInformationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.tblClaimInformationRowChangeEventHandler informationRowChangedEvent = this.tblClaimInformationRowChangedEvent;
      if (informationRowChangedEvent == null)
        return;
      informationRowChangedEvent((object) this, new dsExcelImport.tblClaimInformationRowChangeEvent((dsExcelImport.tblClaimInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClaimInformationRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.tblClaimInformationRowChangeEventHandler rowChangingEvent = this.tblClaimInformationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExcelImport.tblClaimInformationRowChangeEvent((dsExcelImport.tblClaimInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClaimInformationRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.tblClaimInformationRowChangeEventHandler informationRowDeletedEvent = this.tblClaimInformationRowDeletedEvent;
      if (informationRowDeletedEvent == null)
        return;
      informationRowDeletedEvent((object) this, new dsExcelImport.tblClaimInformationRowChangeEvent((dsExcelImport.tblClaimInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClaimInformationRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.tblClaimInformationRowChangeEventHandler rowDeletingEvent = this.tblClaimInformationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExcelImport.tblClaimInformationRowChangeEvent((dsExcelImport.tblClaimInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblClaimInformationRow(dsExcelImport.tblClaimInformationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsExcelImport dsExcelImport = new dsExcelImport();
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
        FixedValue = dsExcelImport.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClaimInformationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsExcelImport.GetSchemaSerializable();
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
  public class tblClaimResPaymentActivityDataTable : 
    TypedTableBase<dsExcelImport.tblClaimResPaymentActivityRow>
  {
    private DataColumn columnPaymentID;
    private DataColumn columnClaimID;
    private DataColumn columnOutIndRes;
    private DataColumn columnOutLAERes;
    private DataColumn columnOutLegalRes;
    private DataColumn columnDedRecovery;
    private DataColumn columnSubrogation;
    private DataColumn columnSalvage;
    private DataColumn columnOtherRecovery;
    private DataColumn columnMTDIndemnityPaid;
    private DataColumn columnIndemnityPTD;
    private DataColumn columnMTDLAEPaid;
    private DataColumn columnLAEPTD;
    private DataColumn columnMTDLegalPaid;
    private DataColumn columnLegalPTD;
    private DataColumn columnMTDTPAExpPaid;
    private DataColumn columnTPAExpPTD;
    private DataColumn columnTotalIncurred;
    private DataColumn columnDateReported;
    private DataColumn columnCheckIssued;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblClaimResPaymentActivityDataTable()
    {
      this.TableName = "tblClaimResPaymentActivity";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblClaimResPaymentActivityDataTable(DataTable table)
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
    protected tblClaimResPaymentActivityDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PaymentIDColumn => this.columnPaymentID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClaimIDColumn => this.columnClaimID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OutIndResColumn => this.columnOutIndRes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OutLAEResColumn => this.columnOutLAERes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OutLegalResColumn => this.columnOutLegalRes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DedRecoveryColumn => this.columnDedRecovery;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SubrogationColumn => this.columnSubrogation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SalvageColumn => this.columnSalvage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OtherRecoveryColumn => this.columnOtherRecovery;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MTDIndemnityPaidColumn => this.columnMTDIndemnityPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IndemnityPTDColumn => this.columnIndemnityPTD;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MTDLAEPaidColumn => this.columnMTDLAEPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LAEPTDColumn => this.columnLAEPTD;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MTDLegalPaidColumn => this.columnMTDLegalPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LegalPTDColumn => this.columnLegalPTD;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MTDTPAExpPaidColumn => this.columnMTDTPAExpPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TPAExpPTDColumn => this.columnTPAExpPTD;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TotalIncurredColumn => this.columnTotalIncurred;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateReportedColumn => this.columnDateReported;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CheckIssuedColumn => this.columnCheckIssued;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.tblClaimResPaymentActivityRow this[int index]
    {
      get => (dsExcelImport.tblClaimResPaymentActivityRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.tblClaimResPaymentActivityRowChangeEventHandler tblClaimResPaymentActivityRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.tblClaimResPaymentActivityRowChangeEventHandler tblClaimResPaymentActivityRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.tblClaimResPaymentActivityRowChangeEventHandler tblClaimResPaymentActivityRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.tblClaimResPaymentActivityRowChangeEventHandler tblClaimResPaymentActivityRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblClaimResPaymentActivityRow(dsExcelImport.tblClaimResPaymentActivityRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.tblClaimResPaymentActivityRow AddtblClaimResPaymentActivityRow(
      int ClaimID,
      Decimal OutIndRes,
      Decimal OutLAERes,
      Decimal OutLegalRes,
      Decimal DedRecovery,
      Decimal Subrogation,
      Decimal Salvage,
      Decimal OtherRecovery,
      Decimal MTDIndemnityPaid,
      Decimal IndemnityPTD,
      Decimal MTDLAEPaid,
      Decimal LAEPTD,
      Decimal MTDLegalPaid,
      Decimal LegalPTD,
      Decimal MTDTPAExpPaid,
      Decimal TPAExpPTD,
      Decimal TotalIncurred,
      DateTime DateReported,
      DateTime CheckIssued)
    {
      dsExcelImport.tblClaimResPaymentActivityRow row = (dsExcelImport.tblClaimResPaymentActivityRow) this.NewRow();
      object[] objArray = new object[20]
      {
        null,
        (object) ClaimID,
        (object) OutIndRes,
        (object) OutLAERes,
        (object) OutLegalRes,
        (object) DedRecovery,
        (object) Subrogation,
        (object) Salvage,
        (object) OtherRecovery,
        (object) MTDIndemnityPaid,
        (object) IndemnityPTD,
        (object) MTDLAEPaid,
        (object) LAEPTD,
        (object) MTDLegalPaid,
        (object) LegalPTD,
        (object) MTDTPAExpPaid,
        (object) TPAExpPTD,
        (object) TotalIncurred,
        (object) DateReported,
        (object) CheckIssued
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.tblClaimResPaymentActivityRow FindByPaymentID(int PaymentID)
    {
      return (dsExcelImport.tblClaimResPaymentActivityRow) this.Rows.Find(new object[1]
      {
        (object) PaymentID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsExcelImport.tblClaimResPaymentActivityDataTable activityDataTable = (dsExcelImport.tblClaimResPaymentActivityDataTable) base.Clone();
      activityDataTable.InitVars();
      return (DataTable) activityDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExcelImport.tblClaimResPaymentActivityDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnPaymentID = this.Columns["PaymentID"];
      this.columnClaimID = this.Columns["ClaimID"];
      this.columnOutIndRes = this.Columns["OutIndRes"];
      this.columnOutLAERes = this.Columns["OutLAERes"];
      this.columnOutLegalRes = this.Columns["OutLegalRes"];
      this.columnDedRecovery = this.Columns["DedRecovery"];
      this.columnSubrogation = this.Columns["Subrogation"];
      this.columnSalvage = this.Columns["Salvage"];
      this.columnOtherRecovery = this.Columns["OtherRecovery"];
      this.columnMTDIndemnityPaid = this.Columns["MTDIndemnityPaid"];
      this.columnIndemnityPTD = this.Columns["IndemnityPTD"];
      this.columnMTDLAEPaid = this.Columns["MTDLAEPaid"];
      this.columnLAEPTD = this.Columns["LAEPTD"];
      this.columnMTDLegalPaid = this.Columns["MTDLegalPaid"];
      this.columnLegalPTD = this.Columns["LegalPTD"];
      this.columnMTDTPAExpPaid = this.Columns["MTDTPAExpPaid"];
      this.columnTPAExpPTD = this.Columns["TPAExpPTD"];
      this.columnTotalIncurred = this.Columns["TotalIncurred"];
      this.columnDateReported = this.Columns["DateReported"];
      this.columnCheckIssued = this.Columns["CheckIssued"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnPaymentID = new DataColumn("PaymentID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPaymentID);
      this.columnClaimID = new DataColumn("ClaimID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimID);
      this.columnOutIndRes = new DataColumn("OutIndRes", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOutIndRes);
      this.columnOutLAERes = new DataColumn("OutLAERes", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOutLAERes);
      this.columnOutLegalRes = new DataColumn("OutLegalRes", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOutLegalRes);
      this.columnDedRecovery = new DataColumn("DedRecovery", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDedRecovery);
      this.columnSubrogation = new DataColumn("Subrogation", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubrogation);
      this.columnSalvage = new DataColumn("Salvage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSalvage);
      this.columnOtherRecovery = new DataColumn("OtherRecovery", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOtherRecovery);
      this.columnMTDIndemnityPaid = new DataColumn("MTDIndemnityPaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMTDIndemnityPaid);
      this.columnIndemnityPTD = new DataColumn("IndemnityPTD", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIndemnityPTD);
      this.columnMTDLAEPaid = new DataColumn("MTDLAEPaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMTDLAEPaid);
      this.columnLAEPTD = new DataColumn("LAEPTD", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLAEPTD);
      this.columnMTDLegalPaid = new DataColumn("MTDLegalPaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMTDLegalPaid);
      this.columnLegalPTD = new DataColumn("LegalPTD", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLegalPTD);
      this.columnMTDTPAExpPaid = new DataColumn("MTDTPAExpPaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMTDTPAExpPaid);
      this.columnTPAExpPTD = new DataColumn("TPAExpPTD", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTPAExpPTD);
      this.columnTotalIncurred = new DataColumn("TotalIncurred", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalIncurred);
      this.columnDateReported = new DataColumn("DateReported", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateReported);
      this.columnCheckIssued = new DataColumn("CheckIssued", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheckIssued);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnPaymentID
      }, true));
      this.columnPaymentID.AutoIncrement = true;
      this.columnPaymentID.AllowDBNull = false;
      this.columnPaymentID.ReadOnly = true;
      this.columnPaymentID.Unique = true;
      this.columnClaimID.AllowDBNull = false;
      this.columnOutIndRes.AllowDBNull = false;
      this.columnOutLAERes.AllowDBNull = false;
      this.columnOutLegalRes.AllowDBNull = false;
      this.columnDedRecovery.AllowDBNull = false;
      this.columnSubrogation.AllowDBNull = false;
      this.columnSalvage.AllowDBNull = false;
      this.columnOtherRecovery.AllowDBNull = false;
      this.columnMTDIndemnityPaid.AllowDBNull = false;
      this.columnIndemnityPTD.AllowDBNull = false;
      this.columnMTDLAEPaid.AllowDBNull = false;
      this.columnLAEPTD.AllowDBNull = false;
      this.columnMTDLegalPaid.AllowDBNull = false;
      this.columnLegalPTD.AllowDBNull = false;
      this.columnMTDTPAExpPaid.AllowDBNull = false;
      this.columnTPAExpPTD.AllowDBNull = false;
      this.columnTotalIncurred.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.tblClaimResPaymentActivityRow NewtblClaimResPaymentActivityRow()
    {
      return (dsExcelImport.tblClaimResPaymentActivityRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExcelImport.tblClaimResPaymentActivityRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsExcelImport.tblClaimResPaymentActivityRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClaimResPaymentActivityRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.tblClaimResPaymentActivityRowChangeEventHandler activityRowChangedEvent = this.tblClaimResPaymentActivityRowChangedEvent;
      if (activityRowChangedEvent == null)
        return;
      activityRowChangedEvent((object) this, new dsExcelImport.tblClaimResPaymentActivityRowChangeEvent((dsExcelImport.tblClaimResPaymentActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClaimResPaymentActivityRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.tblClaimResPaymentActivityRowChangeEventHandler rowChangingEvent = this.tblClaimResPaymentActivityRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExcelImport.tblClaimResPaymentActivityRowChangeEvent((dsExcelImport.tblClaimResPaymentActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClaimResPaymentActivityRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.tblClaimResPaymentActivityRowChangeEventHandler activityRowDeletedEvent = this.tblClaimResPaymentActivityRowDeletedEvent;
      if (activityRowDeletedEvent == null)
        return;
      activityRowDeletedEvent((object) this, new dsExcelImport.tblClaimResPaymentActivityRowChangeEvent((dsExcelImport.tblClaimResPaymentActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClaimResPaymentActivityRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.tblClaimResPaymentActivityRowChangeEventHandler rowDeletingEvent = this.tblClaimResPaymentActivityRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExcelImport.tblClaimResPaymentActivityRowChangeEvent((dsExcelImport.tblClaimResPaymentActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblClaimResPaymentActivityRow(dsExcelImport.tblClaimResPaymentActivityRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsExcelImport dsExcelImport = new dsExcelImport();
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
        FixedValue = dsExcelImport.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClaimResPaymentActivityDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsExcelImport.GetSchemaSerializable();
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
  public class SpreadsheetDateColumnsDataTable : 
    TypedTableBase<dsExcelImport.SpreadsheetDateColumnsRow>
  {
    private DataColumn columnSpreadsheetColumn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public SpreadsheetDateColumnsDataTable()
    {
      this.TableName = "SpreadsheetDateColumns";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal SpreadsheetDateColumnsDataTable(DataTable table)
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
    protected SpreadsheetDateColumnsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SpreadsheetColumnColumn => this.columnSpreadsheetColumn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.SpreadsheetDateColumnsRow this[int index]
    {
      get => (dsExcelImport.SpreadsheetDateColumnsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.SpreadsheetDateColumnsRowChangeEventHandler SpreadsheetDateColumnsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.SpreadsheetDateColumnsRowChangeEventHandler SpreadsheetDateColumnsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.SpreadsheetDateColumnsRowChangeEventHandler SpreadsheetDateColumnsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsExcelImport.SpreadsheetDateColumnsRowChangeEventHandler SpreadsheetDateColumnsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddSpreadsheetDateColumnsRow(dsExcelImport.SpreadsheetDateColumnsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.SpreadsheetDateColumnsRow AddSpreadsheetDateColumnsRow(
      string SpreadsheetColumn)
    {
      dsExcelImport.SpreadsheetDateColumnsRow row = (dsExcelImport.SpreadsheetDateColumnsRow) this.NewRow();
      object[] objArray = new object[1]
      {
        (object) SpreadsheetColumn
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsExcelImport.SpreadsheetDateColumnsDataTable columnsDataTable = (dsExcelImport.SpreadsheetDateColumnsDataTable) base.Clone();
      columnsDataTable.InitVars();
      return (DataTable) columnsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExcelImport.SpreadsheetDateColumnsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars() => this.columnSpreadsheetColumn = this.Columns["SpreadsheetColumn"];

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnSpreadsheetColumn = new DataColumn("SpreadsheetColumn", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpreadsheetColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.SpreadsheetDateColumnsRow NewSpreadsheetDateColumnsRow()
    {
      return (dsExcelImport.SpreadsheetDateColumnsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExcelImport.SpreadsheetDateColumnsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsExcelImport.SpreadsheetDateColumnsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SpreadsheetDateColumnsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.SpreadsheetDateColumnsRowChangeEventHandler columnsRowChangedEvent = this.SpreadsheetDateColumnsRowChangedEvent;
      if (columnsRowChangedEvent == null)
        return;
      columnsRowChangedEvent((object) this, new dsExcelImport.SpreadsheetDateColumnsRowChangeEvent((dsExcelImport.SpreadsheetDateColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SpreadsheetDateColumnsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.SpreadsheetDateColumnsRowChangeEventHandler rowChangingEvent = this.SpreadsheetDateColumnsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExcelImport.SpreadsheetDateColumnsRowChangeEvent((dsExcelImport.SpreadsheetDateColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SpreadsheetDateColumnsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.SpreadsheetDateColumnsRowChangeEventHandler columnsRowDeletedEvent = this.SpreadsheetDateColumnsRowDeletedEvent;
      if (columnsRowDeletedEvent == null)
        return;
      columnsRowDeletedEvent((object) this, new dsExcelImport.SpreadsheetDateColumnsRowChangeEvent((dsExcelImport.SpreadsheetDateColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SpreadsheetDateColumnsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImport.SpreadsheetDateColumnsRowChangeEventHandler rowDeletingEvent = this.SpreadsheetDateColumnsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExcelImport.SpreadsheetDateColumnsRowChangeEvent((dsExcelImport.SpreadsheetDateColumnsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveSpreadsheetDateColumnsRow(dsExcelImport.SpreadsheetDateColumnsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsExcelImport dsExcelImport = new dsExcelImport();
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
        FixedValue = dsExcelImport.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (SpreadsheetDateColumnsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsExcelImport.GetSchemaSerializable();
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

  public class ImportMappingsRow : DataRow
  {
    private dsExcelImport.ImportMappingsDataTable tableImportMappings;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal ImportMappingsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableImportMappings = (dsExcelImport.ImportMappingsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string IMSColumn
    {
      get => Conversions.ToString(this[this.tableImportMappings.IMSColumnColumn]);
      set => this[this.tableImportMappings.IMSColumnColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SpreadsheetColumn
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableImportMappings.SpreadsheetColumnColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SpreadsheetColumn' in table 'ImportMappings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableImportMappings.SpreadsheetColumnColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSpreadsheetColumnNull()
    {
      return this.IsNull(this.tableImportMappings.SpreadsheetColumnColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSpreadsheetColumnNull()
    {
      this[this.tableImportMappings.SpreadsheetColumnColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class SpreadsheetColumnsRow : DataRow
  {
    private dsExcelImport.SpreadsheetColumnsDataTable tableSpreadsheetColumns;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal SpreadsheetColumnsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableSpreadsheetColumns = (dsExcelImport.SpreadsheetColumnsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SpreadsheetColumn
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSpreadsheetColumns.SpreadsheetColumnColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SpreadsheetColumn' in table 'SpreadsheetColumns' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSpreadsheetColumns.SpreadsheetColumnColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSpreadsheetColumnNull()
    {
      return this.IsNull(this.tableSpreadsheetColumns.SpreadsheetColumnColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSpreadsheetColumnNull()
    {
      this[this.tableSpreadsheetColumns.SpreadsheetColumnColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class IMSColumnsRow : DataRow
  {
    private dsExcelImport.IMSColumnsDataTable tableIMSColumns;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal IMSColumnsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableIMSColumns = (dsExcelImport.IMSColumnsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string IMSColumn
    {
      get => Conversions.ToString(this[this.tableIMSColumns.IMSColumnColumn]);
      set => this[this.tableIMSColumns.IMSColumnColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string IMSTable
    {
      get => Conversions.ToString(this[this.tableIMSColumns.IMSTableColumn]);
      set => this[this.tableIMSColumns.IMSTableColumn] = (object) value;
    }
  }

  public class tblClaimInformationRow : DataRow
  {
    private dsExcelImport.tblClaimInformationDataTable tabletblClaimInformation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblClaimInformationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClaimInformation = (dsExcelImport.tblClaimInformationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ClaimID
    {
      get => Conversions.ToInteger(this[this.tabletblClaimInformation.ClaimIDColumn]);
      set => this[this.tabletblClaimInformation.ClaimIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ControlNo
    {
      get => Conversions.ToInteger(this[this.tabletblClaimInformation.ControlNoColumn]);
      set => this[this.tabletblClaimInformation.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ClaimNo
    {
      get => Conversions.ToString(this[this.tabletblClaimInformation.ClaimNoColumn]);
      set => this[this.tabletblClaimInformation.ClaimNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateReceived
    {
      get => Conversions.ToDate(this[this.tabletblClaimInformation.DateReceivedColumn]);
      set => this[this.tabletblClaimInformation.DateReceivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateReported
    {
      get => Conversions.ToDate(this[this.tabletblClaimInformation.DateReportedColumn]);
      set => this[this.tabletblClaimInformation.DateReportedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime LossDate
    {
      get => Conversions.ToDate(this[this.tabletblClaimInformation.LossDateColumn]);
      set => this[this.tabletblClaimInformation.LossDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LossType
    {
      get => Conversions.ToString(this[this.tabletblClaimInformation.LossTypeColumn]);
      set => this[this.tabletblClaimInformation.LossTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Status
    {
      get => Conversions.ToString(this[this.tabletblClaimInformation.StatusColumn]);
      set => this[this.tabletblClaimInformation.StatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateClosed
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimInformation.DateClosedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateClosed' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.DateClosedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool InLitigation
    {
      get => Conversions.ToBoolean(this[this.tabletblClaimInformation.InLitigationColumn]);
      set => this[this.tabletblClaimInformation.InLitigationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string DescriptionInjury
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.DescriptionInjuryColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DescriptionInjury' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.DescriptionInjuryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CATNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.CATNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CATNo' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.CATNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ImportedID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblClaimInformation.ImportedIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ImportedID' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.ImportedIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool _ReadOnly
    {
      get => Conversions.ToBoolean(this[this.tabletblClaimInformation.ReadOnlyColumn]);
      set => this[this.tabletblClaimInformation.ReadOnlyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDateClosedNull() => this.IsNull(this.tabletblClaimInformation.DateClosedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDateClosedNull()
    {
      this[this.tabletblClaimInformation.DateClosedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDescriptionInjuryNull()
    {
      return this.IsNull(this.tabletblClaimInformation.DescriptionInjuryColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDescriptionInjuryNull()
    {
      this[this.tabletblClaimInformation.DescriptionInjuryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCATNoNull() => this.IsNull(this.tabletblClaimInformation.CATNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCATNoNull()
    {
      this[this.tabletblClaimInformation.CATNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsImportedIDNull() => this.IsNull(this.tabletblClaimInformation.ImportedIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetImportedIDNull()
    {
      this[this.tabletblClaimInformation.ImportedIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblClaimResPaymentActivityRow : DataRow
  {
    private dsExcelImport.tblClaimResPaymentActivityDataTable tabletblClaimResPaymentActivity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblClaimResPaymentActivityRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClaimResPaymentActivity = (dsExcelImport.tblClaimResPaymentActivityDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PaymentID
    {
      get => Conversions.ToInteger(this[this.tabletblClaimResPaymentActivity.PaymentIDColumn]);
      set => this[this.tabletblClaimResPaymentActivity.PaymentIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ClaimID
    {
      get => Conversions.ToInteger(this[this.tabletblClaimResPaymentActivity.ClaimIDColumn]);
      set => this[this.tabletblClaimResPaymentActivity.ClaimIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal OutIndRes
    {
      get => Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.OutIndResColumn]);
      set => this[this.tabletblClaimResPaymentActivity.OutIndResColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal OutLAERes
    {
      get => Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.OutLAEResColumn]);
      set => this[this.tabletblClaimResPaymentActivity.OutLAEResColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal OutLegalRes
    {
      get => Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.OutLegalResColumn]);
      set => this[this.tabletblClaimResPaymentActivity.OutLegalResColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal DedRecovery
    {
      get => Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.DedRecoveryColumn]);
      set => this[this.tabletblClaimResPaymentActivity.DedRecoveryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Subrogation
    {
      get => Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.SubrogationColumn]);
      set => this[this.tabletblClaimResPaymentActivity.SubrogationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Salvage
    {
      get => Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.SalvageColumn]);
      set => this[this.tabletblClaimResPaymentActivity.SalvageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal OtherRecovery
    {
      get => Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.OtherRecoveryColumn]);
      set => this[this.tabletblClaimResPaymentActivity.OtherRecoveryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal MTDIndemnityPaid
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.MTDIndemnityPaidColumn]);
      }
      set => this[this.tabletblClaimResPaymentActivity.MTDIndemnityPaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal IndemnityPTD
    {
      get => Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.IndemnityPTDColumn]);
      set => this[this.tabletblClaimResPaymentActivity.IndemnityPTDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal MTDLAEPaid
    {
      get => Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.MTDLAEPaidColumn]);
      set => this[this.tabletblClaimResPaymentActivity.MTDLAEPaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal LAEPTD
    {
      get => Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.LAEPTDColumn]);
      set => this[this.tabletblClaimResPaymentActivity.LAEPTDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal MTDLegalPaid
    {
      get => Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.MTDLegalPaidColumn]);
      set => this[this.tabletblClaimResPaymentActivity.MTDLegalPaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal LegalPTD
    {
      get => Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.LegalPTDColumn]);
      set => this[this.tabletblClaimResPaymentActivity.LegalPTDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal MTDTPAExpPaid
    {
      get => Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.MTDTPAExpPaidColumn]);
      set => this[this.tabletblClaimResPaymentActivity.MTDTPAExpPaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal TPAExpPTD
    {
      get => Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.TPAExpPTDColumn]);
      set => this[this.tabletblClaimResPaymentActivity.TPAExpPTDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal TotalIncurred
    {
      get => Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.TotalIncurredColumn]);
      set => this[this.tabletblClaimResPaymentActivity.TotalIncurredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateReported
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimResPaymentActivity.DateReportedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateReported' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.DateReportedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime CheckIssued
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimResPaymentActivity.CheckIssuedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CheckIssued' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.CheckIssuedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDateReportedNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.DateReportedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDateReportedNull()
    {
      this[this.tabletblClaimResPaymentActivity.DateReportedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCheckIssuedNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.CheckIssuedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCheckIssuedNull()
    {
      this[this.tabletblClaimResPaymentActivity.CheckIssuedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class SpreadsheetDateColumnsRow : DataRow
  {
    private dsExcelImport.SpreadsheetDateColumnsDataTable tableSpreadsheetDateColumns;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal SpreadsheetDateColumnsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableSpreadsheetDateColumns = (dsExcelImport.SpreadsheetDateColumnsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SpreadsheetColumn
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSpreadsheetDateColumns.SpreadsheetColumnColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SpreadsheetColumn' in table 'SpreadsheetDateColumns' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSpreadsheetDateColumns.SpreadsheetColumnColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSpreadsheetColumnNull()
    {
      return this.IsNull(this.tableSpreadsheetDateColumns.SpreadsheetColumnColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSpreadsheetColumnNull()
    {
      this[this.tableSpreadsheetDateColumns.SpreadsheetColumnColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class ImportMappingsRowChangeEvent : EventArgs
  {
    private dsExcelImport.ImportMappingsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public ImportMappingsRowChangeEvent(dsExcelImport.ImportMappingsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.ImportMappingsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class SpreadsheetColumnsRowChangeEvent : EventArgs
  {
    private dsExcelImport.SpreadsheetColumnsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public SpreadsheetColumnsRowChangeEvent(
      dsExcelImport.SpreadsheetColumnsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.SpreadsheetColumnsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class IMSColumnsRowChangeEvent : EventArgs
  {
    private dsExcelImport.IMSColumnsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public IMSColumnsRowChangeEvent(dsExcelImport.IMSColumnsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.IMSColumnsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblClaimInformationRowChangeEvent : EventArgs
  {
    private dsExcelImport.tblClaimInformationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblClaimInformationRowChangeEvent(
      dsExcelImport.tblClaimInformationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.tblClaimInformationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblClaimResPaymentActivityRowChangeEvent : EventArgs
  {
    private dsExcelImport.tblClaimResPaymentActivityRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblClaimResPaymentActivityRowChangeEvent(
      dsExcelImport.tblClaimResPaymentActivityRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.tblClaimResPaymentActivityRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class SpreadsheetDateColumnsRowChangeEvent : EventArgs
  {
    private dsExcelImport.SpreadsheetDateColumnsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public SpreadsheetDateColumnsRowChangeEvent(
      dsExcelImport.SpreadsheetDateColumnsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsExcelImport.SpreadsheetDateColumnsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
