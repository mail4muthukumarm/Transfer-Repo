// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.Commissions.dsCompanyLineCommissions
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies.Commissions;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCompanyLineCommissions")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyLineCommissions : DataSet
{
  private dsCompanyLineCommissions.tblCompanyLineCommissionsDataTable tabletblCompanyLineCommissions;
  private dsCompanyLineCommissions.lstPolicyTypesDataTable tablelstPolicyTypes;
  private dsCompanyLineCommissions.tblCompanyLocationsDataTable tabletblCompanyLocations;
  private dsCompanyLineCommissions.tblCompanyProgramCodesDataTable tabletblCompanyProgramCodes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public dsCompanyLineCommissions()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected dsCompanyLineCommissions(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyLineCommissions)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineCommissions.tblCompanyLineCommissionsDataTable(dataSet.Tables[nameof (tblCompanyLineCommissions)]));
        if (dataSet.Tables[nameof (lstPolicyTypes)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineCommissions.lstPolicyTypesDataTable(dataSet.Tables[nameof (lstPolicyTypes)]));
        if (dataSet.Tables[nameof (tblCompanyLocations)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineCommissions.tblCompanyLocationsDataTable(dataSet.Tables[nameof (tblCompanyLocations)]));
        if (dataSet.Tables[nameof (tblCompanyProgramCodes)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineCommissions.tblCompanyProgramCodesDataTable(dataSet.Tables[nameof (tblCompanyProgramCodes)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyLineCommissions.tblCompanyLineCommissionsDataTable tblCompanyLineCommissions
  {
    get => this.tabletblCompanyLineCommissions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyLineCommissions.lstPolicyTypesDataTable lstPolicyTypes
  {
    get => this.tablelstPolicyTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyLineCommissions.tblCompanyLocationsDataTable tblCompanyLocations
  {
    get => this.tabletblCompanyLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyLineCommissions.tblCompanyProgramCodesDataTable tblCompanyProgramCodes
  {
    get => this.tabletblCompanyProgramCodes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public override DataSet Clone()
  {
    dsCompanyLineCommissions companyLineCommissions = (dsCompanyLineCommissions) base.Clone();
    companyLineCommissions.InitVars();
    companyLineCommissions.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) companyLineCommissions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["tblCompanyLineCommissions"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineCommissions.tblCompanyLineCommissionsDataTable(dataSet.Tables["tblCompanyLineCommissions"]));
      if (dataSet.Tables["lstPolicyTypes"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineCommissions.lstPolicyTypesDataTable(dataSet.Tables["lstPolicyTypes"]));
      if (dataSet.Tables["tblCompanyLocations"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineCommissions.tblCompanyLocationsDataTable(dataSet.Tables["tblCompanyLocations"]));
      if (dataSet.Tables["tblCompanyProgramCodes"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineCommissions.tblCompanyProgramCodesDataTable(dataSet.Tables["tblCompanyProgramCodes"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tabletblCompanyLineCommissions = (dsCompanyLineCommissions.tblCompanyLineCommissionsDataTable) base.Tables["tblCompanyLineCommissions"];
    if (initTable && this.tabletblCompanyLineCommissions != null)
      this.tabletblCompanyLineCommissions.InitVars();
    this.tablelstPolicyTypes = (dsCompanyLineCommissions.lstPolicyTypesDataTable) base.Tables["lstPolicyTypes"];
    if (initTable && this.tablelstPolicyTypes != null)
      this.tablelstPolicyTypes.InitVars();
    this.tabletblCompanyLocations = (dsCompanyLineCommissions.tblCompanyLocationsDataTable) base.Tables["tblCompanyLocations"];
    if (initTable && this.tabletblCompanyLocations != null)
      this.tabletblCompanyLocations.InitVars();
    this.tabletblCompanyProgramCodes = (dsCompanyLineCommissions.tblCompanyProgramCodesDataTable) base.Tables["tblCompanyProgramCodes"];
    if (!initTable || this.tabletblCompanyProgramCodes == null)
      return;
    this.tabletblCompanyProgramCodes.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyLineCommissions);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCompanyLineCommissions.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyLineCommissions = new dsCompanyLineCommissions.tblCompanyLineCommissionsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLineCommissions);
    this.tablelstPolicyTypes = new dsCompanyLineCommissions.lstPolicyTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstPolicyTypes);
    this.tabletblCompanyLocations = new dsCompanyLineCommissions.tblCompanyLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLocations);
    this.tabletblCompanyProgramCodes = new dsCompanyLineCommissions.tblCompanyProgramCodesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyProgramCodes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblCompanyLineCommissions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializelstPolicyTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblCompanyLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblCompanyProgramCodes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsCompanyLineCommissions companyLineCommissions = new dsCompanyLineCommissions();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = companyLineCommissions.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = companyLineCommissions.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblCompanyLineCommissionsRowChangeEventHandler(
    object sender,
    dsCompanyLineCommissions.tblCompanyLineCommissionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void lstPolicyTypesRowChangeEventHandler(
    object sender,
    dsCompanyLineCommissions.lstPolicyTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblCompanyLocationsRowChangeEventHandler(
    object sender,
    dsCompanyLineCommissions.tblCompanyLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblCompanyProgramCodesRowChangeEventHandler(
    object sender,
    dsCompanyLineCommissions.tblCompanyProgramCodesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyLineCommissionsDataTable : 
    TypedTableBase<dsCompanyLineCommissions.tblCompanyLineCommissionsRow>
  {
    private DataColumn columnCommissionID;
    private DataColumn columnEffective;
    private DataColumn columnCompanyCommNew;
    private DataColumn columnCompanyCommRenewal;
    private DataColumn columnProducerCommNew;
    private DataColumn columnProducerCommRenewal;
    private DataColumn columnProducerCommNewMax;
    private DataColumn columnProducerCommRenewalMax;
    private DataColumn columnUsingAdditiveCommission;
    private DataColumn columnAdditiveMinimum;
    private DataColumn columnAdditiveMaximum;
    private DataColumn columnAdditiveSpread;
    private DataColumn columnLockedCommissions;
    private DataColumn columnCompanyLineID;
    private DataColumn columnPolicyTypeID;
    private DataColumn columnExpiringCompanyLocationGuid;
    private DataColumn columnProgramID;
    private DataColumn columnKeepExpiringCommissionsOnRenewal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblCompanyLineCommissionsDataTable()
    {
      this.TableName = "tblCompanyLineCommissions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblCompanyLineCommissionsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected tblCompanyLineCommissionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CommissionIDColumn => this.columnCommissionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EffectiveColumn => this.columnEffective;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CompanyCommNewColumn => this.columnCompanyCommNew;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CompanyCommRenewalColumn => this.columnCompanyCommRenewal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerCommNewColumn => this.columnProducerCommNew;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerCommRenewalColumn => this.columnProducerCommRenewal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerCommNewMaxColumn => this.columnProducerCommNewMax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerCommRenewalMaxColumn => this.columnProducerCommRenewalMax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn UsingAdditiveCommissionColumn => this.columnUsingAdditiveCommission;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AdditiveMinimumColumn => this.columnAdditiveMinimum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AdditiveMaximumColumn => this.columnAdditiveMaximum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AdditiveSpreadColumn => this.columnAdditiveSpread;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn LockedCommissionsColumn => this.columnLockedCommissions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CompanyLineIDColumn => this.columnCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PolicyTypeIDColumn => this.columnPolicyTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ExpiringCompanyLocationGuidColumn => this.columnExpiringCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProgramIDColumn => this.columnProgramID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn KeepExpiringCommissionsOnRenewalColumn
    {
      get => this.columnKeepExpiringCommissionsOnRenewal;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.tblCompanyLineCommissionsRow this[int index]
    {
      get => (dsCompanyLineCommissions.tblCompanyLineCommissionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.tblCompanyLineCommissionsRowChangeEventHandler tblCompanyLineCommissionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.tblCompanyLineCommissionsRowChangeEventHandler tblCompanyLineCommissionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.tblCompanyLineCommissionsRowChangeEventHandler tblCompanyLineCommissionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.tblCompanyLineCommissionsRowChangeEventHandler tblCompanyLineCommissionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblCompanyLineCommissionsRow(
      dsCompanyLineCommissions.tblCompanyLineCommissionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.tblCompanyLineCommissionsRow AddtblCompanyLineCommissionsRow(
      DateTime Effective,
      Decimal CompanyCommNew,
      Decimal CompanyCommRenewal,
      Decimal ProducerCommNew,
      Decimal ProducerCommRenewal,
      Decimal ProducerCommNewMax,
      Decimal ProducerCommRenewalMax,
      bool UsingAdditiveCommission,
      Decimal AdditiveMinimum,
      Decimal AdditiveMaximum,
      Decimal AdditiveSpread,
      bool LockedCommissions,
      int CompanyLineID,
      int PolicyTypeID,
      Guid ExpiringCompanyLocationGuid,
      int ProgramID,
      bool KeepExpiringCommissionsOnRenewal)
    {
      dsCompanyLineCommissions.tblCompanyLineCommissionsRow row = (dsCompanyLineCommissions.tblCompanyLineCommissionsRow) this.NewRow();
      object[] objArray = new object[18]
      {
        null,
        (object) Effective,
        (object) CompanyCommNew,
        (object) CompanyCommRenewal,
        (object) ProducerCommNew,
        (object) ProducerCommRenewal,
        (object) ProducerCommNewMax,
        (object) ProducerCommRenewalMax,
        (object) UsingAdditiveCommission,
        (object) AdditiveMinimum,
        (object) AdditiveMaximum,
        (object) AdditiveSpread,
        (object) LockedCommissions,
        (object) CompanyLineID,
        (object) PolicyTypeID,
        (object) ExpiringCompanyLocationGuid,
        (object) ProgramID,
        (object) KeepExpiringCommissionsOnRenewal
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.tblCompanyLineCommissionsRow FindByCommissionID(int CommissionID)
    {
      return (dsCompanyLineCommissions.tblCompanyLineCommissionsRow) this.Rows.Find(new object[1]
      {
        (object) CommissionID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineCommissions.tblCompanyLineCommissionsDataTable commissionsDataTable = (dsCompanyLineCommissions.tblCompanyLineCommissionsDataTable) base.Clone();
      commissionsDataTable.InitVars();
      return (DataTable) commissionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineCommissions.tblCompanyLineCommissionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnCommissionID = this.Columns["CommissionID"];
      this.columnEffective = this.Columns["Effective"];
      this.columnCompanyCommNew = this.Columns["CompanyCommNew"];
      this.columnCompanyCommRenewal = this.Columns["CompanyCommRenewal"];
      this.columnProducerCommNew = this.Columns["ProducerCommNew"];
      this.columnProducerCommRenewal = this.Columns["ProducerCommRenewal"];
      this.columnProducerCommNewMax = this.Columns["ProducerCommNewMax"];
      this.columnProducerCommRenewalMax = this.Columns["ProducerCommRenewalMax"];
      this.columnUsingAdditiveCommission = this.Columns["UsingAdditiveCommission"];
      this.columnAdditiveMinimum = this.Columns["AdditiveMinimum"];
      this.columnAdditiveMaximum = this.Columns["AdditiveMaximum"];
      this.columnAdditiveSpread = this.Columns["AdditiveSpread"];
      this.columnLockedCommissions = this.Columns["LockedCommissions"];
      this.columnCompanyLineID = this.Columns["CompanyLineID"];
      this.columnPolicyTypeID = this.Columns["PolicyTypeID"];
      this.columnExpiringCompanyLocationGuid = this.Columns["ExpiringCompanyLocationGuid"];
      this.columnProgramID = this.Columns["ProgramID"];
      this.columnKeepExpiringCommissionsOnRenewal = this.Columns["KeepExpiringCommissionsOnRenewal"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnCommissionID = new DataColumn("CommissionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCommissionID);
      this.columnEffective = new DataColumn("Effective", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffective);
      this.columnCompanyCommNew = new DataColumn("CompanyCommNew", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyCommNew);
      this.columnCompanyCommRenewal = new DataColumn("CompanyCommRenewal", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyCommRenewal);
      this.columnProducerCommNew = new DataColumn("ProducerCommNew", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerCommNew);
      this.columnProducerCommRenewal = new DataColumn("ProducerCommRenewal", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerCommRenewal);
      this.columnProducerCommNewMax = new DataColumn("ProducerCommNewMax", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerCommNewMax);
      this.columnProducerCommRenewalMax = new DataColumn("ProducerCommRenewalMax", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerCommRenewalMax);
      this.columnUsingAdditiveCommission = new DataColumn("UsingAdditiveCommission", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUsingAdditiveCommission);
      this.columnAdditiveMinimum = new DataColumn("AdditiveMinimum", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditiveMinimum);
      this.columnAdditiveMaximum = new DataColumn("AdditiveMaximum", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditiveMaximum);
      this.columnAdditiveSpread = new DataColumn("AdditiveSpread", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditiveSpread);
      this.columnLockedCommissions = new DataColumn("LockedCommissions", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLockedCommissions);
      this.columnCompanyLineID = new DataColumn("CompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineID);
      this.columnPolicyTypeID = new DataColumn("PolicyTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyTypeID);
      this.columnExpiringCompanyLocationGuid = new DataColumn("ExpiringCompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpiringCompanyLocationGuid);
      this.columnProgramID = new DataColumn("ProgramID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgramID);
      this.columnKeepExpiringCommissionsOnRenewal = new DataColumn("KeepExpiringCommissionsOnRenewal", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnKeepExpiringCommissionsOnRenewal);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCommissionID
      }, true));
      this.columnCommissionID.AutoIncrement = true;
      this.columnCommissionID.AllowDBNull = false;
      this.columnCommissionID.Unique = true;
      this.columnEffective.AllowDBNull = false;
      this.columnProducerCommNew.DefaultValue = (object) 0M;
      this.columnProducerCommRenewal.DefaultValue = (object) 0M;
      this.columnUsingAdditiveCommission.AllowDBNull = false;
      this.columnUsingAdditiveCommission.DefaultValue = (object) false;
      this.columnLockedCommissions.AllowDBNull = false;
      this.columnLockedCommissions.DefaultValue = (object) false;
      this.columnCompanyLineID.AllowDBNull = false;
      this.columnKeepExpiringCommissionsOnRenewal.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.tblCompanyLineCommissionsRow NewtblCompanyLineCommissionsRow()
    {
      return (dsCompanyLineCommissions.tblCompanyLineCommissionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineCommissions.tblCompanyLineCommissionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyLineCommissions.tblCompanyLineCommissionsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineCommissionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.tblCompanyLineCommissionsRowChangeEventHandler commissionsRowChangedEvent = this.tblCompanyLineCommissionsRowChangedEvent;
      if (commissionsRowChangedEvent == null)
        return;
      commissionsRowChangedEvent((object) this, new dsCompanyLineCommissions.tblCompanyLineCommissionsRowChangeEvent((dsCompanyLineCommissions.tblCompanyLineCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineCommissionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.tblCompanyLineCommissionsRowChangeEventHandler rowChangingEvent = this.tblCompanyLineCommissionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineCommissions.tblCompanyLineCommissionsRowChangeEvent((dsCompanyLineCommissions.tblCompanyLineCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineCommissionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.tblCompanyLineCommissionsRowChangeEventHandler commissionsRowDeletedEvent = this.tblCompanyLineCommissionsRowDeletedEvent;
      if (commissionsRowDeletedEvent == null)
        return;
      commissionsRowDeletedEvent((object) this, new dsCompanyLineCommissions.tblCompanyLineCommissionsRowChangeEvent((dsCompanyLineCommissions.tblCompanyLineCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineCommissionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.tblCompanyLineCommissionsRowChangeEventHandler rowDeletingEvent = this.tblCompanyLineCommissionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineCommissions.tblCompanyLineCommissionsRowChangeEvent((dsCompanyLineCommissions.tblCompanyLineCommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblCompanyLineCommissionsRow(
      dsCompanyLineCommissions.tblCompanyLineCommissionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineCommissions companyLineCommissions = new dsCompanyLineCommissions();
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
        FixedValue = companyLineCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLineCommissionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyLineCommissions.GetSchemaSerializable();
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
  public class lstPolicyTypesDataTable : TypedTableBase<dsCompanyLineCommissions.lstPolicyTypesRow>
  {
    private DataColumn columnPolicyTypeID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public lstPolicyTypesDataTable()
    {
      this.TableName = "lstPolicyTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected lstPolicyTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PolicyTypeIDColumn => this.columnPolicyTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.lstPolicyTypesRow this[int index]
    {
      get => (dsCompanyLineCommissions.lstPolicyTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.lstPolicyTypesRowChangeEventHandler lstPolicyTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddlstPolicyTypesRow(dsCompanyLineCommissions.lstPolicyTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.lstPolicyTypesRow AddlstPolicyTypesRow(
      byte PolicyTypeID,
      string Description)
    {
      dsCompanyLineCommissions.lstPolicyTypesRow row = (dsCompanyLineCommissions.lstPolicyTypesRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.lstPolicyTypesRow FindByPolicyTypeID(byte PolicyTypeID)
    {
      return (dsCompanyLineCommissions.lstPolicyTypesRow) this.Rows.Find(new object[1]
      {
        (object) PolicyTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineCommissions.lstPolicyTypesDataTable policyTypesDataTable = (dsCompanyLineCommissions.lstPolicyTypesDataTable) base.Clone();
      policyTypesDataTable.InitVars();
      return (DataTable) policyTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineCommissions.lstPolicyTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnPolicyTypeID = this.Columns["PolicyTypeID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnPolicyTypeID = new DataColumn("PolicyTypeID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyTypeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnPolicyTypeID
      }, true));
      this.columnPolicyTypeID.AllowDBNull = false;
      this.columnPolicyTypeID.Unique = true;
      this.columnDescription.AllowDBNull = false;
      this.columnDescription.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.lstPolicyTypesRow NewlstPolicyTypesRow()
    {
      return (dsCompanyLineCommissions.lstPolicyTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineCommissions.lstPolicyTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyLineCommissions.lstPolicyTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.lstPolicyTypesRowChangeEventHandler typesRowChangedEvent = this.lstPolicyTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompanyLineCommissions.lstPolicyTypesRowChangeEvent((dsCompanyLineCommissions.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.lstPolicyTypesRowChangeEventHandler rowChangingEvent = this.lstPolicyTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineCommissions.lstPolicyTypesRowChangeEvent((dsCompanyLineCommissions.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.lstPolicyTypesRowChangeEventHandler typesRowDeletedEvent = this.lstPolicyTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompanyLineCommissions.lstPolicyTypesRowChangeEvent((dsCompanyLineCommissions.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.lstPolicyTypesRowChangeEventHandler rowDeletingEvent = this.lstPolicyTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineCommissions.lstPolicyTypesRowChangeEvent((dsCompanyLineCommissions.lstPolicyTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovelstPolicyTypesRow(dsCompanyLineCommissions.lstPolicyTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineCommissions companyLineCommissions = new dsCompanyLineCommissions();
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
        FixedValue = companyLineCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPolicyTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyLineCommissions.GetSchemaSerializable();
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
    TypedTableBase<dsCompanyLineCommissions.tblCompanyLocationsRow>
  {
    private DataColumn columnCompanyLocationGUID;
    private DataColumn columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblCompanyLocationsDataTable()
    {
      this.TableName = "tblCompanyLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected tblCompanyLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CompanyLocationGUIDColumn => this.columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn LocationNameColumn => this.columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.tblCompanyLocationsRow this[int index]
    {
      get => (dsCompanyLineCommissions.tblCompanyLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblCompanyLocationsRow(
      dsCompanyLineCommissions.tblCompanyLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.tblCompanyLocationsRow AddtblCompanyLocationsRow(
      Guid CompanyLocationGUID,
      string LocationName)
    {
      dsCompanyLineCommissions.tblCompanyLocationsRow row = (dsCompanyLineCommissions.tblCompanyLocationsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyLocationGUID,
        (object) LocationName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.tblCompanyLocationsRow FindByCompanyLocationGUID(
      Guid CompanyLocationGUID)
    {
      return (dsCompanyLineCommissions.tblCompanyLocationsRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLocationGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineCommissions.tblCompanyLocationsDataTable locationsDataTable = (dsCompanyLineCommissions.tblCompanyLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineCommissions.tblCompanyLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLocationGUID = this.Columns["CompanyLocationGUID"];
      this.columnLocationName = this.Columns["LocationName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLocationGUID = new DataColumn("CompanyLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGUID);
      this.columnLocationName = new DataColumn("LocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCompanyLocationGUID
      }, true));
      this.columnCompanyLocationGUID.AllowDBNull = false;
      this.columnCompanyLocationGUID.Unique = true;
      this.columnLocationName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.tblCompanyLocationsRow NewtblCompanyLocationsRow()
    {
      return (dsCompanyLineCommissions.tblCompanyLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineCommissions.tblCompanyLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyLineCommissions.tblCompanyLocationsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.tblCompanyLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblCompanyLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsCompanyLineCommissions.tblCompanyLocationsRowChangeEvent((dsCompanyLineCommissions.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.tblCompanyLocationsRowChangeEventHandler rowChangingEvent = this.tblCompanyLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineCommissions.tblCompanyLocationsRowChangeEvent((dsCompanyLineCommissions.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.tblCompanyLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblCompanyLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsCompanyLineCommissions.tblCompanyLocationsRowChangeEvent((dsCompanyLineCommissions.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.tblCompanyLocationsRowChangeEventHandler rowDeletingEvent = this.tblCompanyLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineCommissions.tblCompanyLocationsRowChangeEvent((dsCompanyLineCommissions.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblCompanyLocationsRow(
      dsCompanyLineCommissions.tblCompanyLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineCommissions companyLineCommissions = new dsCompanyLineCommissions();
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
        FixedValue = companyLineCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyLineCommissions.GetSchemaSerializable();
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
  public class tblCompanyProgramCodesDataTable : 
    TypedTableBase<dsCompanyLineCommissions.tblCompanyProgramCodesRow>
  {
    private DataColumn columnProgramID;
    private DataColumn columnProgCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblCompanyProgramCodesDataTable()
    {
      this.TableName = "tblCompanyProgramCodes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblCompanyProgramCodesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected tblCompanyProgramCodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProgramIDColumn => this.columnProgramID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProgCodeColumn => this.columnProgCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.tblCompanyProgramCodesRow this[int index]
    {
      get => (dsCompanyLineCommissions.tblCompanyProgramCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCompanyLineCommissions.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblCompanyProgramCodesRow(
      dsCompanyLineCommissions.tblCompanyProgramCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.tblCompanyProgramCodesRow AddtblCompanyProgramCodesRow(
      int ProgramID,
      string ProgCode)
    {
      dsCompanyLineCommissions.tblCompanyProgramCodesRow row = (dsCompanyLineCommissions.tblCompanyProgramCodesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ProgramID,
        (object) ProgCode
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineCommissions.tblCompanyProgramCodesDataTable programCodesDataTable = (dsCompanyLineCommissions.tblCompanyProgramCodesDataTable) base.Clone();
      programCodesDataTable.InitVars();
      return (DataTable) programCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineCommissions.tblCompanyProgramCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnProgramID = this.Columns["ProgramID"];
      this.columnProgCode = this.Columns["ProgCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnProgramID = new DataColumn("ProgramID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgramID);
      this.columnProgCode = new DataColumn("ProgCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgCode);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.tblCompanyProgramCodesRow NewtblCompanyProgramCodesRow()
    {
      return (dsCompanyLineCommissions.tblCompanyProgramCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineCommissions.tblCompanyProgramCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyLineCommissions.tblCompanyProgramCodesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.tblCompanyProgramCodesRowChangeEventHandler codesRowChangedEvent = this.tblCompanyProgramCodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsCompanyLineCommissions.tblCompanyProgramCodesRowChangeEvent((dsCompanyLineCommissions.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.tblCompanyProgramCodesRowChangeEventHandler rowChangingEvent = this.tblCompanyProgramCodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineCommissions.tblCompanyProgramCodesRowChangeEvent((dsCompanyLineCommissions.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.tblCompanyProgramCodesRowChangeEventHandler codesRowDeletedEvent = this.tblCompanyProgramCodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsCompanyLineCommissions.tblCompanyProgramCodesRowChangeEvent((dsCompanyLineCommissions.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineCommissions.tblCompanyProgramCodesRowChangeEventHandler rowDeletingEvent = this.tblCompanyProgramCodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineCommissions.tblCompanyProgramCodesRowChangeEvent((dsCompanyLineCommissions.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblCompanyProgramCodesRow(
      dsCompanyLineCommissions.tblCompanyProgramCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineCommissions companyLineCommissions = new dsCompanyLineCommissions();
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
        FixedValue = companyLineCommissions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyProgramCodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyLineCommissions.GetSchemaSerializable();
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

  public class tblCompanyLineCommissionsRow : DataRow
  {
    private dsCompanyLineCommissions.tblCompanyLineCommissionsDataTable tabletblCompanyLineCommissions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblCompanyLineCommissionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLineCommissions = (dsCompanyLineCommissions.tblCompanyLineCommissionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int CommissionID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyLineCommissions.CommissionIDColumn]);
      set => this[this.tabletblCompanyLineCommissions.CommissionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime Effective
    {
      get => Conversions.ToDate(this[this.tabletblCompanyLineCommissions.EffectiveColumn]);
      set => this[this.tabletblCompanyLineCommissions.EffectiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal CompanyCommNew
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyLineCommissions.CompanyCommNewColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyCommNew' in table 'tblCompanyLineCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineCommissions.CompanyCommNewColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal CompanyCommRenewal
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyLineCommissions.CompanyCommRenewalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyCommRenewal' in table 'tblCompanyLineCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineCommissions.CompanyCommRenewalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal ProducerCommNew
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyLineCommissions.ProducerCommNewColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerCommNew' in table 'tblCompanyLineCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineCommissions.ProducerCommNewColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal ProducerCommRenewal
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyLineCommissions.ProducerCommRenewalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerCommRenewal' in table 'tblCompanyLineCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineCommissions.ProducerCommRenewalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal ProducerCommNewMax
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyLineCommissions.ProducerCommNewMaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerCommNewMax' in table 'tblCompanyLineCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineCommissions.ProducerCommNewMaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal ProducerCommRenewalMax
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyLineCommissions.ProducerCommRenewalMaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerCommRenewalMax' in table 'tblCompanyLineCommissions' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineCommissions.ProducerCommRenewalMaxColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool UsingAdditiveCommission
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineCommissions.UsingAdditiveCommissionColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineCommissions.UsingAdditiveCommissionColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal AdditiveMinimum
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyLineCommissions.AdditiveMinimumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdditiveMinimum' in table 'tblCompanyLineCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineCommissions.AdditiveMinimumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal AdditiveMaximum
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyLineCommissions.AdditiveMaximumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdditiveMaximum' in table 'tblCompanyLineCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineCommissions.AdditiveMaximumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal AdditiveSpread
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyLineCommissions.AdditiveSpreadColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdditiveSpread' in table 'tblCompanyLineCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineCommissions.AdditiveSpreadColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool LockedCommissions
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineCommissions.LockedCommissionsColumn]);
      }
      set => this[this.tabletblCompanyLineCommissions.LockedCommissionsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int CompanyLineID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyLineCommissions.CompanyLineIDColumn]);
      set => this[this.tabletblCompanyLineCommissions.CompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int PolicyTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineCommissions.PolicyTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyTypeID' in table 'tblCompanyLineCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineCommissions.PolicyTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid ExpiringCompanyLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyLineCommissions.ExpiringCompanyLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpiringCompanyLocationGuid' in table 'tblCompanyLineCommissions' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineCommissions.ExpiringCompanyLocationGuidColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ProgramID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineCommissions.ProgramIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProgramID' in table 'tblCompanyLineCommissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineCommissions.ProgramIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool KeepExpiringCommissionsOnRenewal
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineCommissions.KeepExpiringCommissionsOnRenewalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'KeepExpiringCommissionsOnRenewal' in table 'tblCompanyLineCommissions' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineCommissions.KeepExpiringCommissionsOnRenewalColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCompanyCommNewNull()
    {
      return this.IsNull(this.tabletblCompanyLineCommissions.CompanyCommNewColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCompanyCommNewNull()
    {
      this[this.tabletblCompanyLineCommissions.CompanyCommNewColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCompanyCommRenewalNull()
    {
      return this.IsNull(this.tabletblCompanyLineCommissions.CompanyCommRenewalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCompanyCommRenewalNull()
    {
      this[this.tabletblCompanyLineCommissions.CompanyCommRenewalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsProducerCommNewNull()
    {
      return this.IsNull(this.tabletblCompanyLineCommissions.ProducerCommNewColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetProducerCommNewNull()
    {
      this[this.tabletblCompanyLineCommissions.ProducerCommNewColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsProducerCommRenewalNull()
    {
      return this.IsNull(this.tabletblCompanyLineCommissions.ProducerCommRenewalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetProducerCommRenewalNull()
    {
      this[this.tabletblCompanyLineCommissions.ProducerCommRenewalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsProducerCommNewMaxNull()
    {
      return this.IsNull(this.tabletblCompanyLineCommissions.ProducerCommNewMaxColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetProducerCommNewMaxNull()
    {
      this[this.tabletblCompanyLineCommissions.ProducerCommNewMaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsProducerCommRenewalMaxNull()
    {
      return this.IsNull(this.tabletblCompanyLineCommissions.ProducerCommRenewalMaxColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetProducerCommRenewalMaxNull()
    {
      this[this.tabletblCompanyLineCommissions.ProducerCommRenewalMaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAdditiveMinimumNull()
    {
      return this.IsNull(this.tabletblCompanyLineCommissions.AdditiveMinimumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAdditiveMinimumNull()
    {
      this[this.tabletblCompanyLineCommissions.AdditiveMinimumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAdditiveMaximumNull()
    {
      return this.IsNull(this.tabletblCompanyLineCommissions.AdditiveMaximumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAdditiveMaximumNull()
    {
      this[this.tabletblCompanyLineCommissions.AdditiveMaximumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAdditiveSpreadNull()
    {
      return this.IsNull(this.tabletblCompanyLineCommissions.AdditiveSpreadColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAdditiveSpreadNull()
    {
      this[this.tabletblCompanyLineCommissions.AdditiveSpreadColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPolicyTypeIDNull()
    {
      return this.IsNull(this.tabletblCompanyLineCommissions.PolicyTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPolicyTypeIDNull()
    {
      this[this.tabletblCompanyLineCommissions.PolicyTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsExpiringCompanyLocationGuidNull()
    {
      return this.IsNull(this.tabletblCompanyLineCommissions.ExpiringCompanyLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetExpiringCompanyLocationGuidNull()
    {
      this[this.tabletblCompanyLineCommissions.ExpiringCompanyLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsProgramIDNull()
    {
      return this.IsNull(this.tabletblCompanyLineCommissions.ProgramIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetProgramIDNull()
    {
      this[this.tabletblCompanyLineCommissions.ProgramIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsKeepExpiringCommissionsOnRenewalNull()
    {
      return this.IsNull(this.tabletblCompanyLineCommissions.KeepExpiringCommissionsOnRenewalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetKeepExpiringCommissionsOnRenewalNull()
    {
      this[this.tabletblCompanyLineCommissions.KeepExpiringCommissionsOnRenewalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstPolicyTypesRow : DataRow
  {
    private dsCompanyLineCommissions.lstPolicyTypesDataTable tablelstPolicyTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal lstPolicyTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPolicyTypes = (dsCompanyLineCommissions.lstPolicyTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public byte PolicyTypeID
    {
      get => Conversions.ToByte(this[this.tablelstPolicyTypes.PolicyTypeIDColumn]);
      set => this[this.tablelstPolicyTypes.PolicyTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstPolicyTypes.DescriptionColumn]);
      set => this[this.tablelstPolicyTypes.DescriptionColumn] = (object) value;
    }
  }

  public class tblCompanyLocationsRow : DataRow
  {
    private dsCompanyLineCommissions.tblCompanyLocationsDataTable tabletblCompanyLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblCompanyLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLocations = (dsCompanyLineCommissions.tblCompanyLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string LocationName
    {
      get => Conversions.ToString(this[this.tabletblCompanyLocations.LocationNameColumn]);
      set => this[this.tabletblCompanyLocations.LocationNameColumn] = (object) value;
    }
  }

  public class tblCompanyProgramCodesRow : DataRow
  {
    private dsCompanyLineCommissions.tblCompanyProgramCodesDataTable tabletblCompanyProgramCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblCompanyProgramCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyProgramCodes = (dsCompanyLineCommissions.tblCompanyProgramCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ProgramID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyProgramCodes.ProgramIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProgramID' in table 'tblCompanyProgramCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyProgramCodes.ProgramIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ProgCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyProgramCodes.ProgCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProgCode' in table 'tblCompanyProgramCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyProgramCodes.ProgCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsProgramIDNull() => this.IsNull(this.tabletblCompanyProgramCodes.ProgramIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetProgramIDNull()
    {
      this[this.tabletblCompanyProgramCodes.ProgramIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsProgCodeNull() => this.IsNull(this.tabletblCompanyProgramCodes.ProgCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetProgCodeNull()
    {
      this[this.tabletblCompanyProgramCodes.ProgCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblCompanyLineCommissionsRowChangeEvent : EventArgs
  {
    private dsCompanyLineCommissions.tblCompanyLineCommissionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblCompanyLineCommissionsRowChangeEvent(
      dsCompanyLineCommissions.tblCompanyLineCommissionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.tblCompanyLineCommissionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class lstPolicyTypesRowChangeEvent : EventArgs
  {
    private dsCompanyLineCommissions.lstPolicyTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public lstPolicyTypesRowChangeEvent(
      dsCompanyLineCommissions.lstPolicyTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.lstPolicyTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblCompanyLocationsRowChangeEvent : EventArgs
  {
    private dsCompanyLineCommissions.tblCompanyLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblCompanyLocationsRowChangeEvent(
      dsCompanyLineCommissions.tblCompanyLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.tblCompanyLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblCompanyProgramCodesRowChangeEvent : EventArgs
  {
    private dsCompanyLineCommissions.tblCompanyProgramCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblCompanyProgramCodesRowChangeEvent(
      dsCompanyLineCommissions.tblCompanyProgramCodesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCompanyLineCommissions.tblCompanyProgramCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
