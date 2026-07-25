// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsProgCodeExt
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
[XmlRoot("dsProgCodeExt")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsProgCodeExt : DataSet
{
  private dsProgCodeExt.tblCompanyProgramCodesExt_BaseDataTable tabletblCompanyProgramCodesExt_Base;
  private dsProgCodeExt.tblCompanyProgramParticpation_BaseDataTable tabletblCompanyProgramParticpation_Base;
  private dsProgCodeExt.tblCompanyLocationsDataTable tabletblCompanyLocations;
  private dsProgCodeExt.tblCompaniesDataTable tabletblCompanies;
  private dsProgCodeExt.WKFC_tblCompanyProgramCodesExtDataTable tableWKFC_tblCompanyProgramCodesExt;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsProgCodeExt()
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
  protected dsProgCodeExt(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyProgramCodesExt_Base)] != null)
          base.Tables.Add((DataTable) new dsProgCodeExt.tblCompanyProgramCodesExt_BaseDataTable(dataSet.Tables[nameof (tblCompanyProgramCodesExt_Base)]));
        if (dataSet.Tables[nameof (tblCompanyProgramParticpation_Base)] != null)
          base.Tables.Add((DataTable) new dsProgCodeExt.tblCompanyProgramParticpation_BaseDataTable(dataSet.Tables[nameof (tblCompanyProgramParticpation_Base)]));
        if (dataSet.Tables[nameof (tblCompanyLocations)] != null)
          base.Tables.Add((DataTable) new dsProgCodeExt.tblCompanyLocationsDataTable(dataSet.Tables[nameof (tblCompanyLocations)]));
        if (dataSet.Tables[nameof (tblCompanies)] != null)
          base.Tables.Add((DataTable) new dsProgCodeExt.tblCompaniesDataTable(dataSet.Tables[nameof (tblCompanies)]));
        if (dataSet.Tables[nameof (WKFC_tblCompanyProgramCodesExt)] != null)
          base.Tables.Add((DataTable) new dsProgCodeExt.WKFC_tblCompanyProgramCodesExtDataTable(dataSet.Tables[nameof (WKFC_tblCompanyProgramCodesExt)]));
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
  public dsProgCodeExt.tblCompanyProgramCodesExt_BaseDataTable tblCompanyProgramCodesExt_Base
  {
    get => this.tabletblCompanyProgramCodesExt_Base;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProgCodeExt.tblCompanyProgramParticpation_BaseDataTable tblCompanyProgramParticpation_Base
  {
    get => this.tabletblCompanyProgramParticpation_Base;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProgCodeExt.tblCompanyLocationsDataTable tblCompanyLocations
  {
    get => this.tabletblCompanyLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProgCodeExt.tblCompaniesDataTable tblCompanies => this.tabletblCompanies;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProgCodeExt.WKFC_tblCompanyProgramCodesExtDataTable WKFC_tblCompanyProgramCodesExt
  {
    get => this.tableWKFC_tblCompanyProgramCodesExt;
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
    dsProgCodeExt dsProgCodeExt = (dsProgCodeExt) base.Clone();
    dsProgCodeExt.InitVars();
    dsProgCodeExt.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsProgCodeExt;
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
      if (dataSet.Tables["tblCompanyProgramCodesExt_Base"] != null)
        base.Tables.Add((DataTable) new dsProgCodeExt.tblCompanyProgramCodesExt_BaseDataTable(dataSet.Tables["tblCompanyProgramCodesExt_Base"]));
      if (dataSet.Tables["tblCompanyProgramParticpation_Base"] != null)
        base.Tables.Add((DataTable) new dsProgCodeExt.tblCompanyProgramParticpation_BaseDataTable(dataSet.Tables["tblCompanyProgramParticpation_Base"]));
      if (dataSet.Tables["tblCompanyLocations"] != null)
        base.Tables.Add((DataTable) new dsProgCodeExt.tblCompanyLocationsDataTable(dataSet.Tables["tblCompanyLocations"]));
      if (dataSet.Tables["tblCompanies"] != null)
        base.Tables.Add((DataTable) new dsProgCodeExt.tblCompaniesDataTable(dataSet.Tables["tblCompanies"]));
      if (dataSet.Tables["WKFC_tblCompanyProgramCodesExt"] != null)
        base.Tables.Add((DataTable) new dsProgCodeExt.WKFC_tblCompanyProgramCodesExtDataTable(dataSet.Tables["WKFC_tblCompanyProgramCodesExt"]));
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
    this.tabletblCompanyProgramCodesExt_Base = (dsProgCodeExt.tblCompanyProgramCodesExt_BaseDataTable) base.Tables["tblCompanyProgramCodesExt_Base"];
    if (initTable && this.tabletblCompanyProgramCodesExt_Base != null)
      this.tabletblCompanyProgramCodesExt_Base.InitVars();
    this.tabletblCompanyProgramParticpation_Base = (dsProgCodeExt.tblCompanyProgramParticpation_BaseDataTable) base.Tables["tblCompanyProgramParticpation_Base"];
    if (initTable && this.tabletblCompanyProgramParticpation_Base != null)
      this.tabletblCompanyProgramParticpation_Base.InitVars();
    this.tabletblCompanyLocations = (dsProgCodeExt.tblCompanyLocationsDataTable) base.Tables["tblCompanyLocations"];
    if (initTable && this.tabletblCompanyLocations != null)
      this.tabletblCompanyLocations.InitVars();
    this.tabletblCompanies = (dsProgCodeExt.tblCompaniesDataTable) base.Tables["tblCompanies"];
    if (initTable && this.tabletblCompanies != null)
      this.tabletblCompanies.InitVars();
    this.tableWKFC_tblCompanyProgramCodesExt = (dsProgCodeExt.WKFC_tblCompanyProgramCodesExtDataTable) base.Tables["WKFC_tblCompanyProgramCodesExt"];
    if (!initTable || this.tableWKFC_tblCompanyProgramCodesExt == null)
      return;
    this.tableWKFC_tblCompanyProgramCodesExt.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsProgCodeExt);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsProgCodeExt.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyProgramCodesExt_Base = new dsProgCodeExt.tblCompanyProgramCodesExt_BaseDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyProgramCodesExt_Base);
    this.tabletblCompanyProgramParticpation_Base = new dsProgCodeExt.tblCompanyProgramParticpation_BaseDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyProgramParticpation_Base);
    this.tabletblCompanyLocations = new dsProgCodeExt.tblCompanyLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLocations);
    this.tabletblCompanies = new dsProgCodeExt.tblCompaniesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanies);
    this.tableWKFC_tblCompanyProgramCodesExt = new dsProgCodeExt.WKFC_tblCompanyProgramCodesExtDataTable();
    base.Tables.Add((DataTable) this.tableWKFC_tblCompanyProgramCodesExt);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyProgramCodesExt_Base() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyProgramParticpation_Base() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanies() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeWKFC_tblCompanyProgramCodesExt() => false;

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
    dsProgCodeExt dsProgCodeExt = new dsProgCodeExt();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsProgCodeExt.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsProgCodeExt.GetSchemaSerializable();
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
  public delegate void tblCompanyProgramCodesExt_BaseRowChangeEventHandler(
    object sender,
    dsProgCodeExt.tblCompanyProgramCodesExt_BaseRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyProgramParticpation_BaseRowChangeEventHandler(
    object sender,
    dsProgCodeExt.tblCompanyProgramParticpation_BaseRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyLocationsRowChangeEventHandler(
    object sender,
    dsProgCodeExt.tblCompanyLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompaniesRowChangeEventHandler(
    object sender,
    dsProgCodeExt.tblCompaniesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void WKFC_tblCompanyProgramCodesExtRowChangeEventHandler(
    object sender,
    dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyProgramCodesExt_BaseDataTable : 
    TypedTableBase<dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow>
  {
    private DataColumn columnProgramID;
    private DataColumn columnCedingCommission;
    private DataColumn columnIssuingCarrierFrontFee;
    private DataColumn columnIssuingCarrierPart;
    private DataColumn columnRIBroker;
    private DataColumn columnRIBrokerGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyProgramCodesExt_BaseDataTable()
    {
      this.TableName = "tblCompanyProgramCodesExt_Base";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyProgramCodesExt_BaseDataTable(DataTable table)
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
    protected tblCompanyProgramCodesExt_BaseDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProgramIDColumn => this.columnProgramID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CedingCommissionColumn => this.columnCedingCommission;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IssuingCarrierFrontFeeColumn => this.columnIssuingCarrierFrontFee;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IssuingCarrierPartColumn => this.columnIssuingCarrierPart;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RIBrokerColumn => this.columnRIBroker;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RIBrokerGUIDColumn => this.columnRIBrokerGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow this[int index]
    {
      get => (dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompanyProgramCodesExt_BaseRowChangeEventHandler tblCompanyProgramCodesExt_BaseRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompanyProgramCodesExt_BaseRowChangeEventHandler tblCompanyProgramCodesExt_BaseRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompanyProgramCodesExt_BaseRowChangeEventHandler tblCompanyProgramCodesExt_BaseRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompanyProgramCodesExt_BaseRowChangeEventHandler tblCompanyProgramCodesExt_BaseRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyProgramCodesExt_BaseRow(
      dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow AddtblCompanyProgramCodesExt_BaseRow(
      int ProgramID,
      Decimal CedingCommission,
      Decimal IssuingCarrierFrontFee,
      Decimal IssuingCarrierPart,
      Decimal RIBroker,
      Guid RIBrokerGUID)
    {
      dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow row = (dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) ProgramID,
        (object) CedingCommission,
        (object) IssuingCarrierFrontFee,
        (object) IssuingCarrierPart,
        (object) RIBroker,
        (object) RIBrokerGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow FindByProgramID(int ProgramID)
    {
      return (dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow) this.Rows.Find(new object[1]
      {
        (object) ProgramID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProgCodeExt.tblCompanyProgramCodesExt_BaseDataTable extBaseDataTable = (dsProgCodeExt.tblCompanyProgramCodesExt_BaseDataTable) base.Clone();
      extBaseDataTable.InitVars();
      return (DataTable) extBaseDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProgCodeExt.tblCompanyProgramCodesExt_BaseDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnProgramID = this.Columns["ProgramID"];
      this.columnCedingCommission = this.Columns["CedingCommission"];
      this.columnIssuingCarrierFrontFee = this.Columns["IssuingCarrierFrontFee"];
      this.columnIssuingCarrierPart = this.Columns["IssuingCarrierPart"];
      this.columnRIBroker = this.Columns["RIBroker"];
      this.columnRIBrokerGUID = this.Columns["RIBrokerGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnProgramID = new DataColumn("ProgramID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgramID);
      this.columnCedingCommission = new DataColumn("CedingCommission", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCedingCommission);
      this.columnIssuingCarrierFrontFee = new DataColumn("IssuingCarrierFrontFee", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIssuingCarrierFrontFee);
      this.columnIssuingCarrierPart = new DataColumn("IssuingCarrierPart", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIssuingCarrierPart);
      this.columnRIBroker = new DataColumn("RIBroker", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRIBroker);
      this.columnRIBrokerGUID = new DataColumn("RIBrokerGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRIBrokerGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnProgramID
      }, true));
      this.columnProgramID.AllowDBNull = false;
      this.columnProgramID.Unique = true;
      this.columnCedingCommission.AllowDBNull = false;
      this.columnIssuingCarrierFrontFee.AllowDBNull = false;
      this.columnIssuingCarrierPart.AllowDBNull = false;
      this.columnRIBroker.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow NewtblCompanyProgramCodesExt_BaseRow()
    {
      return (dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesExt_BaseRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompanyProgramCodesExt_BaseRowChangeEventHandler baseRowChangedEvent = this.tblCompanyProgramCodesExt_BaseRowChangedEvent;
      if (baseRowChangedEvent == null)
        return;
      baseRowChangedEvent((object) this, new dsProgCodeExt.tblCompanyProgramCodesExt_BaseRowChangeEvent((dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesExt_BaseRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompanyProgramCodesExt_BaseRowChangeEventHandler rowChangingEvent = this.tblCompanyProgramCodesExt_BaseRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProgCodeExt.tblCompanyProgramCodesExt_BaseRowChangeEvent((dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesExt_BaseRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompanyProgramCodesExt_BaseRowChangeEventHandler baseRowDeletedEvent = this.tblCompanyProgramCodesExt_BaseRowDeletedEvent;
      if (baseRowDeletedEvent == null)
        return;
      baseRowDeletedEvent((object) this, new dsProgCodeExt.tblCompanyProgramCodesExt_BaseRowChangeEvent((dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesExt_BaseRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompanyProgramCodesExt_BaseRowChangeEventHandler rowDeletingEvent = this.tblCompanyProgramCodesExt_BaseRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProgCodeExt.tblCompanyProgramCodesExt_BaseRowChangeEvent((dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyProgramCodesExt_BaseRow(
      dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProgCodeExt dsProgCodeExt = new dsProgCodeExt();
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
        FixedValue = dsProgCodeExt.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyProgramCodesExt_BaseDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProgCodeExt.GetSchemaSerializable();
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
  public class tblCompanyProgramParticpation_BaseDataTable : 
    TypedTableBase<dsProgCodeExt.tblCompanyProgramParticpation_BaseRow>
  {
    private DataColumn columnID;
    private DataColumn columnProgramID;
    private DataColumn columnCompanyLocationID;
    private DataColumn columnShare;
    private DataColumn columnStartDate;
    private DataColumn columnEndDate;
    private DataColumn columnCommission;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyProgramParticpation_BaseDataTable()
    {
      this.TableName = "tblCompanyProgramParticpation_Base";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyProgramParticpation_BaseDataTable(DataTable table)
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
    protected tblCompanyProgramParticpation_BaseDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProgramIDColumn => this.columnProgramID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLocationIDColumn => this.columnCompanyLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ShareColumn => this.columnShare;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StartDateColumn => this.columnStartDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EndDateColumn => this.columnEndDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CommissionColumn => this.columnCommission;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompanyProgramParticpation_BaseRow this[int index]
    {
      get => (dsProgCodeExt.tblCompanyProgramParticpation_BaseRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompanyProgramParticpation_BaseRowChangeEventHandler tblCompanyProgramParticpation_BaseRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompanyProgramParticpation_BaseRowChangeEventHandler tblCompanyProgramParticpation_BaseRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompanyProgramParticpation_BaseRowChangeEventHandler tblCompanyProgramParticpation_BaseRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompanyProgramParticpation_BaseRowChangeEventHandler tblCompanyProgramParticpation_BaseRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyProgramParticpation_BaseRow(
      dsProgCodeExt.tblCompanyProgramParticpation_BaseRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompanyProgramParticpation_BaseRow AddtblCompanyProgramParticpation_BaseRow(
      int ProgramID,
      int CompanyLocationID,
      Decimal Share,
      DateTime StartDate,
      DateTime EndDate,
      Decimal Commission)
    {
      dsProgCodeExt.tblCompanyProgramParticpation_BaseRow row = (dsProgCodeExt.tblCompanyProgramParticpation_BaseRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        (object) ProgramID,
        (object) CompanyLocationID,
        (object) Share,
        (object) StartDate,
        (object) EndDate,
        (object) Commission
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompanyProgramParticpation_BaseRow FindByProgramIDCompanyLocationIDStartDate(
      int ProgramID,
      int CompanyLocationID,
      DateTime StartDate)
    {
      return (dsProgCodeExt.tblCompanyProgramParticpation_BaseRow) this.Rows.Find(new object[3]
      {
        (object) ProgramID,
        (object) CompanyLocationID,
        (object) StartDate
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProgCodeExt.tblCompanyProgramParticpation_BaseDataTable particpationBaseDataTable = (dsProgCodeExt.tblCompanyProgramParticpation_BaseDataTable) base.Clone();
      particpationBaseDataTable.InitVars();
      return (DataTable) particpationBaseDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProgCodeExt.tblCompanyProgramParticpation_BaseDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnProgramID = this.Columns["ProgramID"];
      this.columnCompanyLocationID = this.Columns["CompanyLocationID"];
      this.columnShare = this.Columns["Share"];
      this.columnStartDate = this.Columns["StartDate"];
      this.columnEndDate = this.Columns["EndDate"];
      this.columnCommission = this.Columns["Commission"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnProgramID = new DataColumn("ProgramID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgramID);
      this.columnCompanyLocationID = new DataColumn("CompanyLocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationID);
      this.columnShare = new DataColumn("Share", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnShare);
      this.columnStartDate = new DataColumn("StartDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStartDate);
      this.columnEndDate = new DataColumn("EndDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndDate);
      this.columnCommission = new DataColumn("Commission", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommission);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[3]
      {
        this.columnProgramID,
        this.columnCompanyLocationID,
        this.columnStartDate
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AutoIncrementSeed = -1L;
      this.columnID.AutoIncrementStep = -1L;
      this.columnID.AllowDBNull = false;
      this.columnProgramID.AllowDBNull = false;
      this.columnCompanyLocationID.AllowDBNull = false;
      this.columnStartDate.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompanyProgramParticpation_BaseRow NewtblCompanyProgramParticpation_BaseRow()
    {
      return (dsProgCodeExt.tblCompanyProgramParticpation_BaseRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProgCodeExt.tblCompanyProgramParticpation_BaseRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsProgCodeExt.tblCompanyProgramParticpation_BaseRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramParticpation_BaseRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompanyProgramParticpation_BaseRowChangeEventHandler baseRowChangedEvent = this.tblCompanyProgramParticpation_BaseRowChangedEvent;
      if (baseRowChangedEvent == null)
        return;
      baseRowChangedEvent((object) this, new dsProgCodeExt.tblCompanyProgramParticpation_BaseRowChangeEvent((dsProgCodeExt.tblCompanyProgramParticpation_BaseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramParticpation_BaseRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompanyProgramParticpation_BaseRowChangeEventHandler rowChangingEvent = this.tblCompanyProgramParticpation_BaseRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProgCodeExt.tblCompanyProgramParticpation_BaseRowChangeEvent((dsProgCodeExt.tblCompanyProgramParticpation_BaseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramParticpation_BaseRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompanyProgramParticpation_BaseRowChangeEventHandler baseRowDeletedEvent = this.tblCompanyProgramParticpation_BaseRowDeletedEvent;
      if (baseRowDeletedEvent == null)
        return;
      baseRowDeletedEvent((object) this, new dsProgCodeExt.tblCompanyProgramParticpation_BaseRowChangeEvent((dsProgCodeExt.tblCompanyProgramParticpation_BaseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramParticpation_BaseRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompanyProgramParticpation_BaseRowChangeEventHandler rowDeletingEvent = this.tblCompanyProgramParticpation_BaseRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProgCodeExt.tblCompanyProgramParticpation_BaseRowChangeEvent((dsProgCodeExt.tblCompanyProgramParticpation_BaseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyProgramParticpation_BaseRow(
      dsProgCodeExt.tblCompanyProgramParticpation_BaseRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProgCodeExt dsProgCodeExt = new dsProgCodeExt();
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
        FixedValue = dsProgCodeExt.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyProgramParticpation_BaseDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProgCodeExt.GetSchemaSerializable();
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
  public class tblCompanyLocationsDataTable : TypedTableBase<dsProgCodeExt.tblCompanyLocationsRow>
  {
    private DataColumn columnCompanyLocationID;
    private DataColumn columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyLocationsDataTable()
    {
      this.TableName = "tblCompanyLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblCompanyLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLocationIDColumn => this.columnCompanyLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationNameColumn => this.columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompanyLocationsRow this[int index]
    {
      get => (dsProgCodeExt.tblCompanyLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyLocationsRow(dsProgCodeExt.tblCompanyLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompanyLocationsRow AddtblCompanyLocationsRow(
      int CompanyLocationID,
      string LocationName)
    {
      dsProgCodeExt.tblCompanyLocationsRow row = (dsProgCodeExt.tblCompanyLocationsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyLocationID,
        (object) LocationName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompanyLocationsRow FindByCompanyLocationID(int CompanyLocationID)
    {
      return (dsProgCodeExt.tblCompanyLocationsRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProgCodeExt.tblCompanyLocationsDataTable locationsDataTable = (dsProgCodeExt.tblCompanyLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProgCodeExt.tblCompanyLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLocationID = this.Columns["CompanyLocationID"];
      this.columnLocationName = this.Columns["LocationName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLocationID = new DataColumn("CompanyLocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationID);
      this.columnLocationName = new DataColumn("LocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCompanyLocationID
      }, true));
      this.columnCompanyLocationID.AllowDBNull = false;
      this.columnCompanyLocationID.Unique = true;
      this.columnLocationName.AllowDBNull = false;
      this.columnLocationName.MaxLength = 100;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompanyLocationsRow NewtblCompanyLocationsRow()
    {
      return (dsProgCodeExt.tblCompanyLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProgCodeExt.tblCompanyLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProgCodeExt.tblCompanyLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompanyLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblCompanyLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsProgCodeExt.tblCompanyLocationsRowChangeEvent((dsProgCodeExt.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompanyLocationsRowChangeEventHandler rowChangingEvent = this.tblCompanyLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProgCodeExt.tblCompanyLocationsRowChangeEvent((dsProgCodeExt.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompanyLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblCompanyLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsProgCodeExt.tblCompanyLocationsRowChangeEvent((dsProgCodeExt.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompanyLocationsRowChangeEventHandler rowDeletingEvent = this.tblCompanyLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProgCodeExt.tblCompanyLocationsRowChangeEvent((dsProgCodeExt.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyLocationsRow(dsProgCodeExt.tblCompanyLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProgCodeExt dsProgCodeExt = new dsProgCodeExt();
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
        FixedValue = dsProgCodeExt.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProgCodeExt.GetSchemaSerializable();
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
  public class tblCompaniesDataTable : TypedTableBase<dsProgCodeExt.tblCompaniesRow>
  {
    private DataColumn columnCompanyGUID;
    private DataColumn columnCompanyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompaniesDataTable()
    {
      this.TableName = "tblCompanies";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblCompaniesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyGUIDColumn => this.columnCompanyGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyNameColumn => this.columnCompanyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompaniesRow this[int index]
    {
      get => (dsProgCodeExt.tblCompaniesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompaniesRowChangeEventHandler tblCompaniesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompaniesRowChangeEventHandler tblCompaniesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompaniesRowChangeEventHandler tblCompaniesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.tblCompaniesRowChangeEventHandler tblCompaniesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompaniesRow(dsProgCodeExt.tblCompaniesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompaniesRow AddtblCompaniesRow(Guid CompanyGUID, string CompanyName)
    {
      dsProgCodeExt.tblCompaniesRow row = (dsProgCodeExt.tblCompaniesRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompaniesRow FindByCompanyGUID(Guid CompanyGUID)
    {
      return (dsProgCodeExt.tblCompaniesRow) this.Rows.Find(new object[1]
      {
        (object) CompanyGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProgCodeExt.tblCompaniesDataTable companiesDataTable = (dsProgCodeExt.tblCompaniesDataTable) base.Clone();
      companiesDataTable.InitVars();
      return (DataTable) companiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProgCodeExt.tblCompaniesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyGUID = this.Columns["CompanyGUID"];
      this.columnCompanyName = this.Columns["CompanyName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyGUID = new DataColumn("CompanyGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGUID);
      this.columnCompanyName = new DataColumn("CompanyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCompanyGUID
      }, true));
      this.columnCompanyGUID.AllowDBNull = false;
      this.columnCompanyGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompaniesRow NewtblCompaniesRow()
    {
      return (dsProgCodeExt.tblCompaniesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProgCodeExt.tblCompaniesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsProgCodeExt.tblCompaniesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompaniesRowChangeEventHandler companiesRowChangedEvent = this.tblCompaniesRowChangedEvent;
      if (companiesRowChangedEvent == null)
        return;
      companiesRowChangedEvent((object) this, new dsProgCodeExt.tblCompaniesRowChangeEvent((dsProgCodeExt.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompaniesRowChangeEventHandler rowChangingEvent = this.tblCompaniesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProgCodeExt.tblCompaniesRowChangeEvent((dsProgCodeExt.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompaniesRowChangeEventHandler companiesRowDeletedEvent = this.tblCompaniesRowDeletedEvent;
      if (companiesRowDeletedEvent == null)
        return;
      companiesRowDeletedEvent((object) this, new dsProgCodeExt.tblCompaniesRowChangeEvent((dsProgCodeExt.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.tblCompaniesRowChangeEventHandler rowDeletingEvent = this.tblCompaniesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProgCodeExt.tblCompaniesRowChangeEvent((dsProgCodeExt.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompaniesRow(dsProgCodeExt.tblCompaniesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProgCodeExt dsProgCodeExt = new dsProgCodeExt();
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
        FixedValue = dsProgCodeExt.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompaniesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProgCodeExt.GetSchemaSerializable();
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
  public class WKFC_tblCompanyProgramCodesExtDataTable : 
    TypedTableBase<dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow>
  {
    private DataColumn columnProgramID;
    private DataColumn columnSectionNum;
    private DataColumn columnBinderNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public WKFC_tblCompanyProgramCodesExtDataTable()
    {
      this.TableName = "WKFC_tblCompanyProgramCodesExt";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal WKFC_tblCompanyProgramCodesExtDataTable(DataTable table)
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
    protected WKFC_tblCompanyProgramCodesExtDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProgramIDColumn => this.columnProgramID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SectionNumColumn => this.columnSectionNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BinderNumColumn => this.columnBinderNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow this[int index]
    {
      get => (dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRowChangeEventHandler WKFC_tblCompanyProgramCodesExtRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRowChangeEventHandler WKFC_tblCompanyProgramCodesExtRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRowChangeEventHandler WKFC_tblCompanyProgramCodesExtRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRowChangeEventHandler WKFC_tblCompanyProgramCodesExtRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddWKFC_tblCompanyProgramCodesExtRow(
      dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow AddWKFC_tblCompanyProgramCodesExtRow(
      int ProgramID,
      string SectionNum,
      string BinderNum)
    {
      dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow row = (dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) ProgramID,
        (object) SectionNum,
        (object) BinderNum
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow FindByProgramID(int ProgramID)
    {
      return (dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow) this.Rows.Find(new object[1]
      {
        (object) ProgramID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsProgCodeExt.WKFC_tblCompanyProgramCodesExtDataTable codesExtDataTable = (dsProgCodeExt.WKFC_tblCompanyProgramCodesExtDataTable) base.Clone();
      codesExtDataTable.InitVars();
      return (DataTable) codesExtDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProgCodeExt.WKFC_tblCompanyProgramCodesExtDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnProgramID = this.Columns["ProgramID"];
      this.columnSectionNum = this.Columns["SectionNum"];
      this.columnBinderNum = this.Columns["BinderNum"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnProgramID = new DataColumn("ProgramID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgramID);
      this.columnSectionNum = new DataColumn("SectionNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSectionNum);
      this.columnBinderNum = new DataColumn("BinderNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBinderNum);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnProgramID
      }, true));
      this.columnProgramID.AllowDBNull = false;
      this.columnProgramID.Unique = true;
      this.columnSectionNum.Caption = "ProgramName";
      this.columnBinderNum.Caption = "Section";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow NewWKFC_tblCompanyProgramCodesExtRow()
    {
      return (dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.WKFC_tblCompanyProgramCodesExtRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRowChangeEventHandler extRowChangedEvent = this.WKFC_tblCompanyProgramCodesExtRowChangedEvent;
      if (extRowChangedEvent == null)
        return;
      extRowChangedEvent((object) this, new dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRowChangeEvent((dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.WKFC_tblCompanyProgramCodesExtRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRowChangeEventHandler rowChangingEvent = this.WKFC_tblCompanyProgramCodesExtRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRowChangeEvent((dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.WKFC_tblCompanyProgramCodesExtRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRowChangeEventHandler extRowDeletedEvent = this.WKFC_tblCompanyProgramCodesExtRowDeletedEvent;
      if (extRowDeletedEvent == null)
        return;
      extRowDeletedEvent((object) this, new dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRowChangeEvent((dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.WKFC_tblCompanyProgramCodesExtRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRowChangeEventHandler rowDeletingEvent = this.WKFC_tblCompanyProgramCodesExtRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRowChangeEvent((dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveWKFC_tblCompanyProgramCodesExtRow(
      dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProgCodeExt dsProgCodeExt = new dsProgCodeExt();
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
        FixedValue = dsProgCodeExt.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (WKFC_tblCompanyProgramCodesExtDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsProgCodeExt.GetSchemaSerializable();
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

  public class tblCompanyProgramCodesExt_BaseRow : DataRow
  {
    private dsProgCodeExt.tblCompanyProgramCodesExt_BaseDataTable tabletblCompanyProgramCodesExt_Base;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyProgramCodesExt_BaseRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyProgramCodesExt_Base = (dsProgCodeExt.tblCompanyProgramCodesExt_BaseDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ProgramID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyProgramCodesExt_Base.ProgramIDColumn]);
      set => this[this.tabletblCompanyProgramCodesExt_Base.ProgramIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal CedingCommission
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblCompanyProgramCodesExt_Base.CedingCommissionColumn]);
      }
      set => this[this.tabletblCompanyProgramCodesExt_Base.CedingCommissionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal IssuingCarrierFrontFee
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblCompanyProgramCodesExt_Base.IssuingCarrierFrontFeeColumn]);
      }
      set
      {
        this[this.tabletblCompanyProgramCodesExt_Base.IssuingCarrierFrontFeeColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal IssuingCarrierPart
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblCompanyProgramCodesExt_Base.IssuingCarrierPartColumn]);
      }
      set
      {
        this[this.tabletblCompanyProgramCodesExt_Base.IssuingCarrierPartColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal RIBroker
    {
      get => Conversions.ToDecimal(this[this.tabletblCompanyProgramCodesExt_Base.RIBrokerColumn]);
      set => this[this.tabletblCompanyProgramCodesExt_Base.RIBrokerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid RIBrokerGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyProgramCodesExt_Base.RIBrokerGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RIBrokerGUID' in table 'tblCompanyProgramCodesExt_Base' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyProgramCodesExt_Base.RIBrokerGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRIBrokerGUIDNull()
    {
      return this.IsNull(this.tabletblCompanyProgramCodesExt_Base.RIBrokerGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRIBrokerGUIDNull()
    {
      this[this.tabletblCompanyProgramCodesExt_Base.RIBrokerGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblCompanyProgramParticpation_BaseRow : DataRow
  {
    private dsProgCodeExt.tblCompanyProgramParticpation_BaseDataTable tabletblCompanyProgramParticpation_Base;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyProgramParticpation_BaseRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyProgramParticpation_Base = (dsProgCodeExt.tblCompanyProgramParticpation_BaseDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyProgramParticpation_Base.IDColumn]);
      set => this[this.tabletblCompanyProgramParticpation_Base.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ProgramID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyProgramParticpation_Base.ProgramIDColumn]);
      }
      set => this[this.tabletblCompanyProgramParticpation_Base.ProgramIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CompanyLocationID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyProgramParticpation_Base.CompanyLocationIDColumn]);
      }
      set
      {
        this[this.tabletblCompanyProgramParticpation_Base.CompanyLocationIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Share
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyProgramParticpation_Base.ShareColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Share' in table 'tblCompanyProgramParticpation_Base' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyProgramParticpation_Base.ShareColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime StartDate
    {
      get => Conversions.ToDate(this[this.tabletblCompanyProgramParticpation_Base.StartDateColumn]);
      set => this[this.tabletblCompanyProgramParticpation_Base.StartDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime EndDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblCompanyProgramParticpation_Base.EndDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndDate' in table 'tblCompanyProgramParticpation_Base' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyProgramParticpation_Base.EndDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Commission
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyProgramParticpation_Base.CommissionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Commission' in table 'tblCompanyProgramParticpation_Base' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyProgramParticpation_Base.CommissionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsShareNull()
    {
      return this.IsNull(this.tabletblCompanyProgramParticpation_Base.ShareColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetShareNull()
    {
      this[this.tabletblCompanyProgramParticpation_Base.ShareColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEndDateNull()
    {
      return this.IsNull(this.tabletblCompanyProgramParticpation_Base.EndDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEndDateNull()
    {
      this[this.tabletblCompanyProgramParticpation_Base.EndDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCommissionNull()
    {
      return this.IsNull(this.tabletblCompanyProgramParticpation_Base.CommissionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCommissionNull()
    {
      this[this.tabletblCompanyProgramParticpation_Base.CommissionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblCompanyLocationsRow : DataRow
  {
    private dsProgCodeExt.tblCompanyLocationsDataTable tabletblCompanyLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLocations = (dsProgCodeExt.tblCompanyLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CompanyLocationID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyLocations.CompanyLocationIDColumn]);
      set => this[this.tabletblCompanyLocations.CompanyLocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LocationName
    {
      get => Conversions.ToString(this[this.tabletblCompanyLocations.LocationNameColumn]);
      set => this[this.tabletblCompanyLocations.LocationNameColumn] = (object) value;
    }
  }

  public class tblCompaniesRow : DataRow
  {
    private dsProgCodeExt.tblCompaniesDataTable tabletblCompanies;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompaniesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanies = (dsProgCodeExt.tblCompaniesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CompanyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanies.CompanyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyName' in table 'tblCompanies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanies.CompanyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyNameNull() => this.IsNull(this.tabletblCompanies.CompanyNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyNameNull()
    {
      this[this.tabletblCompanies.CompanyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class WKFC_tblCompanyProgramCodesExtRow : DataRow
  {
    private dsProgCodeExt.WKFC_tblCompanyProgramCodesExtDataTable tableWKFC_tblCompanyProgramCodesExt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal WKFC_tblCompanyProgramCodesExtRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableWKFC_tblCompanyProgramCodesExt = (dsProgCodeExt.WKFC_tblCompanyProgramCodesExtDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ProgramID
    {
      get => Conversions.ToInteger(this[this.tableWKFC_tblCompanyProgramCodesExt.ProgramIDColumn]);
      set => this[this.tableWKFC_tblCompanyProgramCodesExt.ProgramIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SectionNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableWKFC_tblCompanyProgramCodesExt.SectionNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SectionNum' in table 'WKFC_tblCompanyProgramCodesExt' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableWKFC_tblCompanyProgramCodesExt.SectionNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string BinderNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableWKFC_tblCompanyProgramCodesExt.BinderNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BinderNum' in table 'WKFC_tblCompanyProgramCodesExt' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableWKFC_tblCompanyProgramCodesExt.BinderNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSectionNumNull()
    {
      return this.IsNull(this.tableWKFC_tblCompanyProgramCodesExt.SectionNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSectionNumNull()
    {
      this[this.tableWKFC_tblCompanyProgramCodesExt.SectionNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBinderNumNull()
    {
      return this.IsNull(this.tableWKFC_tblCompanyProgramCodesExt.BinderNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBinderNumNull()
    {
      this[this.tableWKFC_tblCompanyProgramCodesExt.BinderNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyProgramCodesExt_BaseRowChangeEvent : EventArgs
  {
    private dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyProgramCodesExt_BaseRowChangeEvent(
      dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompanyProgramCodesExt_BaseRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyProgramParticpation_BaseRowChangeEvent : EventArgs
  {
    private dsProgCodeExt.tblCompanyProgramParticpation_BaseRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyProgramParticpation_BaseRowChangeEvent(
      dsProgCodeExt.tblCompanyProgramParticpation_BaseRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompanyProgramParticpation_BaseRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyLocationsRowChangeEvent : EventArgs
  {
    private dsProgCodeExt.tblCompanyLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyLocationsRowChangeEvent(
      dsProgCodeExt.tblCompanyLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompanyLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompaniesRowChangeEvent : EventArgs
  {
    private dsProgCodeExt.tblCompaniesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompaniesRowChangeEvent(dsProgCodeExt.tblCompaniesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.tblCompaniesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class WKFC_tblCompanyProgramCodesExtRowChangeEvent : EventArgs
  {
    private dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public WKFC_tblCompanyProgramCodesExtRowChangeEvent(
      dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsProgCodeExt.WKFC_tblCompanyProgramCodesExtRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
