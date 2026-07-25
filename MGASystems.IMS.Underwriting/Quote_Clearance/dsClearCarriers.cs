// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Quote_Clearance.dsClearCarriers
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Underwriting.Quote_Clearance;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsClearCarriers")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsClearCarriers : DataSet
{
  private dsClearCarriers.CompanyAndContactInfoDataTable tableCompanyAndContactInfo;
  private dsClearCarriers.CompanyAndContactSelectedDataTable tableCompanyAndContactSelected;
  private dsClearCarriers.EmailCCDataTable tableEmailCC;
  private dsClearCarriers.lstQuoteStatusDataTable tablelstQuoteStatus;
  private dsClearCarriers.CurrentCarrierAndContactInfoDataTable tableCurrentCarrierAndContactInfo;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsClearCarriers()
  {
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected dsClearCarriers(SerializationInfo info, StreamingContext context)
    : base(info, context, false)
  {
    if (this.IsBinarySerialized(info, context))
    {
      this.InitVars(false);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      this.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }
    else
    {
      string s = (string) info.GetValue("XmlSchema", typeof (string));
      if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
      {
        DataSet dataSet = new DataSet();
        dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        if (dataSet.Tables[nameof (CompanyAndContactInfo)] != null)
          base.Tables.Add((DataTable) new dsClearCarriers.CompanyAndContactInfoDataTable(dataSet.Tables[nameof (CompanyAndContactInfo)]));
        if (dataSet.Tables[nameof (CompanyAndContactSelected)] != null)
          base.Tables.Add((DataTable) new dsClearCarriers.CompanyAndContactSelectedDataTable(dataSet.Tables[nameof (CompanyAndContactSelected)]));
        if (dataSet.Tables[nameof (EmailCC)] != null)
          base.Tables.Add((DataTable) new dsClearCarriers.EmailCCDataTable(dataSet.Tables[nameof (EmailCC)]));
        if (dataSet.Tables[nameof (lstQuoteStatus)] != null)
          base.Tables.Add((DataTable) new dsClearCarriers.lstQuoteStatusDataTable(dataSet.Tables[nameof (lstQuoteStatus)]));
        if (dataSet.Tables[nameof (CurrentCarrierAndContactInfo)] != null)
          base.Tables.Add((DataTable) new dsClearCarriers.CurrentCarrierAndContactInfoDataTable(dataSet.Tables[nameof (CurrentCarrierAndContactInfo)]));
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
  public dsClearCarriers.CompanyAndContactInfoDataTable CompanyAndContactInfo
  {
    get => this.tableCompanyAndContactInfo;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClearCarriers.CompanyAndContactSelectedDataTable CompanyAndContactSelected
  {
    get => this.tableCompanyAndContactSelected;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClearCarriers.EmailCCDataTable EmailCC => this.tableEmailCC;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClearCarriers.lstQuoteStatusDataTable lstQuoteStatus => this.tablelstQuoteStatus;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClearCarriers.CurrentCarrierAndContactInfoDataTable CurrentCarrierAndContactInfo
  {
    get => this.tableCurrentCarrierAndContactInfo;
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
    dsClearCarriers dsClearCarriers = (dsClearCarriers) base.Clone();
    dsClearCarriers.InitVars();
    dsClearCarriers.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsClearCarriers;
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
      if (dataSet.Tables["CompanyAndContactInfo"] != null)
        base.Tables.Add((DataTable) new dsClearCarriers.CompanyAndContactInfoDataTable(dataSet.Tables["CompanyAndContactInfo"]));
      if (dataSet.Tables["CompanyAndContactSelected"] != null)
        base.Tables.Add((DataTable) new dsClearCarriers.CompanyAndContactSelectedDataTable(dataSet.Tables["CompanyAndContactSelected"]));
      if (dataSet.Tables["EmailCC"] != null)
        base.Tables.Add((DataTable) new dsClearCarriers.EmailCCDataTable(dataSet.Tables["EmailCC"]));
      if (dataSet.Tables["lstQuoteStatus"] != null)
        base.Tables.Add((DataTable) new dsClearCarriers.lstQuoteStatusDataTable(dataSet.Tables["lstQuoteStatus"]));
      if (dataSet.Tables["CurrentCarrierAndContactInfo"] != null)
        base.Tables.Add((DataTable) new dsClearCarriers.CurrentCarrierAndContactInfoDataTable(dataSet.Tables["CurrentCarrierAndContactInfo"]));
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
    this.tableCompanyAndContactInfo = (dsClearCarriers.CompanyAndContactInfoDataTable) base.Tables["CompanyAndContactInfo"];
    if (initTable && this.tableCompanyAndContactInfo != null)
      this.tableCompanyAndContactInfo.InitVars();
    this.tableCompanyAndContactSelected = (dsClearCarriers.CompanyAndContactSelectedDataTable) base.Tables["CompanyAndContactSelected"];
    if (initTable && this.tableCompanyAndContactSelected != null)
      this.tableCompanyAndContactSelected.InitVars();
    this.tableEmailCC = (dsClearCarriers.EmailCCDataTable) base.Tables["EmailCC"];
    if (initTable && this.tableEmailCC != null)
      this.tableEmailCC.InitVars();
    this.tablelstQuoteStatus = (dsClearCarriers.lstQuoteStatusDataTable) base.Tables["lstQuoteStatus"];
    if (initTable && this.tablelstQuoteStatus != null)
      this.tablelstQuoteStatus.InitVars();
    this.tableCurrentCarrierAndContactInfo = (dsClearCarriers.CurrentCarrierAndContactInfoDataTable) base.Tables["CurrentCarrierAndContactInfo"];
    if (!initTable || this.tableCurrentCarrierAndContactInfo == null)
      return;
    this.tableCurrentCarrierAndContactInfo.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsClearCarriers);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsClearCarriers.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableCompanyAndContactInfo = new dsClearCarriers.CompanyAndContactInfoDataTable();
    base.Tables.Add((DataTable) this.tableCompanyAndContactInfo);
    this.tableCompanyAndContactSelected = new dsClearCarriers.CompanyAndContactSelectedDataTable();
    base.Tables.Add((DataTable) this.tableCompanyAndContactSelected);
    this.tableEmailCC = new dsClearCarriers.EmailCCDataTable();
    base.Tables.Add((DataTable) this.tableEmailCC);
    this.tablelstQuoteStatus = new dsClearCarriers.lstQuoteStatusDataTable();
    base.Tables.Add((DataTable) this.tablelstQuoteStatus);
    this.tableCurrentCarrierAndContactInfo = new dsClearCarriers.CurrentCarrierAndContactInfoDataTable();
    base.Tables.Add((DataTable) this.tableCurrentCarrierAndContactInfo);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeCompanyAndContactInfo() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeCompanyAndContactSelected() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeEmailCC() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstQuoteStatus() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeCurrentCarrierAndContactInfo() => false;

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
    dsClearCarriers dsClearCarriers = new dsClearCarriers();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = dsClearCarriers.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = dsClearCarriers.GetSchemaSerializable();
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
              return typedDataSetSchema;
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
    return typedDataSetSchema;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void CompanyAndContactInfoRowChangeEventHandler(
    object sender,
    dsClearCarriers.CompanyAndContactInfoRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void CompanyAndContactSelectedRowChangeEventHandler(
    object sender,
    dsClearCarriers.CompanyAndContactSelectedRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void EmailCCRowChangeEventHandler(
    object sender,
    dsClearCarriers.EmailCCRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstQuoteStatusRowChangeEventHandler(
    object sender,
    dsClearCarriers.lstQuoteStatusRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void CurrentCarrierAndContactInfoRowChangeEventHandler(
    object sender,
    dsClearCarriers.CurrentCarrierAndContactInfoRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class CompanyAndContactInfoDataTable : 
    TypedTableBase<dsClearCarriers.CompanyAndContactInfoRow>
  {
    private DataColumn columnCompanyContactGUID;
    private DataColumn columnCompanyLocationGUID;
    private DataColumn columnContactName;
    private DataColumn columnCompanyGroup;
    private DataColumn columnLocationName;
    private DataColumn columnEmail;
    private DataColumn columnAdd;
    private DataColumn columnCity;
    private DataColumn columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public CompanyAndContactInfoDataTable()
    {
      this.TableName = "CompanyAndContactInfo";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal CompanyAndContactInfoDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected CompanyAndContactInfoDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyContactGUIDColumn => this.columnCompanyContactGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLocationGUIDColumn => this.columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ContactNameColumn => this.columnContactName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyGroupColumn => this.columnCompanyGroup;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationNameColumn => this.columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AddColumn => this.columnAdd;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.CompanyAndContactInfoRow this[int index]
    {
      get => (dsClearCarriers.CompanyAndContactInfoRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.CompanyAndContactInfoRowChangeEventHandler CompanyAndContactInfoRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.CompanyAndContactInfoRowChangeEventHandler CompanyAndContactInfoRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.CompanyAndContactInfoRowChangeEventHandler CompanyAndContactInfoRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.CompanyAndContactInfoRowChangeEventHandler CompanyAndContactInfoRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddCompanyAndContactInfoRow(dsClearCarriers.CompanyAndContactInfoRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.CompanyAndContactInfoRow AddCompanyAndContactInfoRow(
      Guid CompanyContactGUID,
      Guid CompanyLocationGUID,
      string ContactName,
      string CompanyGroup,
      string LocationName,
      string Email,
      string Add,
      string City,
      string State)
    {
      dsClearCarriers.CompanyAndContactInfoRow row = (dsClearCarriers.CompanyAndContactInfoRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) CompanyContactGUID,
        (object) CompanyLocationGUID,
        (object) ContactName,
        (object) CompanyGroup,
        (object) LocationName,
        (object) Email,
        (object) Add,
        (object) City,
        (object) State
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.CompanyAndContactInfoRow FindByCompanyContactGUIDCompanyLocationGUID(
      Guid CompanyContactGUID,
      Guid CompanyLocationGUID)
    {
      return (dsClearCarriers.CompanyAndContactInfoRow) this.Rows.Find(new object[2]
      {
        (object) CompanyContactGUID,
        (object) CompanyLocationGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsClearCarriers.CompanyAndContactInfoDataTable contactInfoDataTable = (dsClearCarriers.CompanyAndContactInfoDataTable) base.Clone();
      contactInfoDataTable.InitVars();
      return (DataTable) contactInfoDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClearCarriers.CompanyAndContactInfoDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyContactGUID = this.Columns["CompanyContactGUID"];
      this.columnCompanyLocationGUID = this.Columns["CompanyLocationGUID"];
      this.columnContactName = this.Columns["ContactName"];
      this.columnCompanyGroup = this.Columns["CompanyGroup"];
      this.columnLocationName = this.Columns["LocationName"];
      this.columnEmail = this.Columns["Email"];
      this.columnAdd = this.Columns["Add"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyContactGUID = new DataColumn("CompanyContactGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyContactGUID);
      this.columnCompanyLocationGUID = new DataColumn("CompanyLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGUID);
      this.columnContactName = new DataColumn("ContactName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactName);
      this.columnCompanyGroup = new DataColumn("CompanyGroup", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGroup);
      this.columnLocationName = new DataColumn("LocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationName);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.columnAdd = new DataColumn("Add", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdd);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnCompanyContactGUID,
        this.columnCompanyLocationGUID
      }, true));
      this.columnCompanyContactGUID.AllowDBNull = false;
      this.columnCompanyLocationGUID.AllowDBNull = false;
      this.columnContactName.AllowDBNull = false;
      this.columnContactName.MaxLength = 50;
      this.columnAdd.DefaultValue = (object) "Add";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.CompanyAndContactInfoRow NewCompanyAndContactInfoRow()
    {
      return (dsClearCarriers.CompanyAndContactInfoRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClearCarriers.CompanyAndContactInfoRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsClearCarriers.CompanyAndContactInfoRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.CompanyAndContactInfoRowChanged == null)
        return;
      this.CompanyAndContactInfoRowChanged((object) this, new dsClearCarriers.CompanyAndContactInfoRowChangeEvent((dsClearCarriers.CompanyAndContactInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.CompanyAndContactInfoRowChanging == null)
        return;
      this.CompanyAndContactInfoRowChanging((object) this, new dsClearCarriers.CompanyAndContactInfoRowChangeEvent((dsClearCarriers.CompanyAndContactInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.CompanyAndContactInfoRowDeleted == null)
        return;
      this.CompanyAndContactInfoRowDeleted((object) this, new dsClearCarriers.CompanyAndContactInfoRowChangeEvent((dsClearCarriers.CompanyAndContactInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.CompanyAndContactInfoRowDeleting == null)
        return;
      this.CompanyAndContactInfoRowDeleting((object) this, new dsClearCarriers.CompanyAndContactInfoRowChangeEvent((dsClearCarriers.CompanyAndContactInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveCompanyAndContactInfoRow(dsClearCarriers.CompanyAndContactInfoRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClearCarriers dsClearCarriers = new dsClearCarriers();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dsClearCarriers.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CompanyAndContactInfoDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsClearCarriers.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class CompanyAndContactSelectedDataTable : 
    TypedTableBase<dsClearCarriers.CompanyAndContactSelectedRow>
  {
    private DataColumn columnCompanyContactGUID;
    private DataColumn columnCompanyLocationGUID;
    private DataColumn columnContactName;
    private DataColumn columnCompanyGroup;
    private DataColumn columnLocationName;
    private DataColumn columnEmail;
    private DataColumn columnEmailCC;
    private DataColumn columnRemove;
    private DataColumn columnCity;
    private DataColumn columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public CompanyAndContactSelectedDataTable()
    {
      this.TableName = "CompanyAndContactSelected";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal CompanyAndContactSelectedDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected CompanyAndContactSelectedDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyContactGUIDColumn => this.columnCompanyContactGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLocationGUIDColumn => this.columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ContactNameColumn => this.columnContactName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyGroupColumn => this.columnCompanyGroup;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationNameColumn => this.columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EmailCCColumn => this.columnEmailCC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RemoveColumn => this.columnRemove;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.CompanyAndContactSelectedRow this[int index]
    {
      get => (dsClearCarriers.CompanyAndContactSelectedRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.CompanyAndContactSelectedRowChangeEventHandler CompanyAndContactSelectedRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.CompanyAndContactSelectedRowChangeEventHandler CompanyAndContactSelectedRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.CompanyAndContactSelectedRowChangeEventHandler CompanyAndContactSelectedRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.CompanyAndContactSelectedRowChangeEventHandler CompanyAndContactSelectedRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddCompanyAndContactSelectedRow(dsClearCarriers.CompanyAndContactSelectedRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.CompanyAndContactSelectedRow AddCompanyAndContactSelectedRow(
      Guid CompanyContactGUID,
      Guid CompanyLocationGUID,
      string ContactName,
      string CompanyGroup,
      string LocationName,
      string Email,
      string EmailCC,
      string Remove,
      string City,
      string State)
    {
      dsClearCarriers.CompanyAndContactSelectedRow row = (dsClearCarriers.CompanyAndContactSelectedRow) this.NewRow();
      object[] objArray = new object[10]
      {
        (object) CompanyContactGUID,
        (object) CompanyLocationGUID,
        (object) ContactName,
        (object) CompanyGroup,
        (object) LocationName,
        (object) Email,
        (object) EmailCC,
        (object) Remove,
        (object) City,
        (object) State
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.CompanyAndContactSelectedRow FindByCompanyLocationGUIDCompanyContactGUID(
      Guid CompanyLocationGUID,
      Guid CompanyContactGUID)
    {
      return (dsClearCarriers.CompanyAndContactSelectedRow) this.Rows.Find(new object[2]
      {
        (object) CompanyLocationGUID,
        (object) CompanyContactGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsClearCarriers.CompanyAndContactSelectedDataTable selectedDataTable = (dsClearCarriers.CompanyAndContactSelectedDataTable) base.Clone();
      selectedDataTable.InitVars();
      return (DataTable) selectedDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClearCarriers.CompanyAndContactSelectedDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyContactGUID = this.Columns["CompanyContactGUID"];
      this.columnCompanyLocationGUID = this.Columns["CompanyLocationGUID"];
      this.columnContactName = this.Columns["ContactName"];
      this.columnCompanyGroup = this.Columns["CompanyGroup"];
      this.columnLocationName = this.Columns["LocationName"];
      this.columnEmail = this.Columns["Email"];
      this.columnEmailCC = this.Columns["EmailCC"];
      this.columnRemove = this.Columns["Remove"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyContactGUID = new DataColumn("CompanyContactGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyContactGUID);
      this.columnCompanyLocationGUID = new DataColumn("CompanyLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGUID);
      this.columnContactName = new DataColumn("ContactName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactName);
      this.columnCompanyGroup = new DataColumn("CompanyGroup", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGroup);
      this.columnLocationName = new DataColumn("LocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationName);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.columnEmailCC = new DataColumn("EmailCC", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmailCC);
      this.columnRemove = new DataColumn("Remove", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemove);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnCompanyLocationGUID,
        this.columnCompanyContactGUID
      }, true));
      this.columnCompanyContactGUID.AllowDBNull = false;
      this.columnCompanyLocationGUID.AllowDBNull = false;
      this.columnContactName.AllowDBNull = false;
      this.columnContactName.MaxLength = 50;
      this.columnRemove.DefaultValue = (object) "Remove";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.CompanyAndContactSelectedRow NewCompanyAndContactSelectedRow()
    {
      return (dsClearCarriers.CompanyAndContactSelectedRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClearCarriers.CompanyAndContactSelectedRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsClearCarriers.CompanyAndContactSelectedRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.CompanyAndContactSelectedRowChanged == null)
        return;
      this.CompanyAndContactSelectedRowChanged((object) this, new dsClearCarriers.CompanyAndContactSelectedRowChangeEvent((dsClearCarriers.CompanyAndContactSelectedRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.CompanyAndContactSelectedRowChanging == null)
        return;
      this.CompanyAndContactSelectedRowChanging((object) this, new dsClearCarriers.CompanyAndContactSelectedRowChangeEvent((dsClearCarriers.CompanyAndContactSelectedRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.CompanyAndContactSelectedRowDeleted == null)
        return;
      this.CompanyAndContactSelectedRowDeleted((object) this, new dsClearCarriers.CompanyAndContactSelectedRowChangeEvent((dsClearCarriers.CompanyAndContactSelectedRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.CompanyAndContactSelectedRowDeleting == null)
        return;
      this.CompanyAndContactSelectedRowDeleting((object) this, new dsClearCarriers.CompanyAndContactSelectedRowChangeEvent((dsClearCarriers.CompanyAndContactSelectedRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveCompanyAndContactSelectedRow(dsClearCarriers.CompanyAndContactSelectedRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClearCarriers dsClearCarriers = new dsClearCarriers();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dsClearCarriers.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CompanyAndContactSelectedDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsClearCarriers.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class EmailCCDataTable : TypedTableBase<dsClearCarriers.EmailCCRow>
  {
    private DataColumn columnEmail;
    private DataColumn columnContact;
    private DataColumn columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public EmailCCDataTable()
    {
      this.TableName = "EmailCC";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal EmailCCDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected EmailCCDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ContactColumn => this.columnContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLocationGUIDColumn => this.columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.EmailCCRow this[int index]
    {
      get => (dsClearCarriers.EmailCCRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.EmailCCRowChangeEventHandler EmailCCRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.EmailCCRowChangeEventHandler EmailCCRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.EmailCCRowChangeEventHandler EmailCCRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.EmailCCRowChangeEventHandler EmailCCRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddEmailCCRow(dsClearCarriers.EmailCCRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.EmailCCRow AddEmailCCRow(
      string Email,
      string Contact,
      Guid CompanyLocationGUID)
    {
      dsClearCarriers.EmailCCRow row = (dsClearCarriers.EmailCCRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) Email,
        (object) Contact,
        (object) CompanyLocationGUID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsClearCarriers.EmailCCDataTable emailCcDataTable = (dsClearCarriers.EmailCCDataTable) base.Clone();
      emailCcDataTable.InitVars();
      return (DataTable) emailCcDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClearCarriers.EmailCCDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnEmail = this.Columns["Email"];
      this.columnContact = this.Columns["Contact"];
      this.columnCompanyLocationGUID = this.Columns["CompanyLocationGUID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.columnContact = new DataColumn("Contact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContact);
      this.columnCompanyLocationGUID = new DataColumn("CompanyLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGUID);
      this.columnEmail.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.EmailCCRow NewEmailCCRow() => (dsClearCarriers.EmailCCRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClearCarriers.EmailCCRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsClearCarriers.EmailCCRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.EmailCCRowChanged == null)
        return;
      this.EmailCCRowChanged((object) this, new dsClearCarriers.EmailCCRowChangeEvent((dsClearCarriers.EmailCCRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.EmailCCRowChanging == null)
        return;
      this.EmailCCRowChanging((object) this, new dsClearCarriers.EmailCCRowChangeEvent((dsClearCarriers.EmailCCRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.EmailCCRowDeleted == null)
        return;
      this.EmailCCRowDeleted((object) this, new dsClearCarriers.EmailCCRowChangeEvent((dsClearCarriers.EmailCCRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.EmailCCRowDeleting == null)
        return;
      this.EmailCCRowDeleting((object) this, new dsClearCarriers.EmailCCRowChangeEvent((dsClearCarriers.EmailCCRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveEmailCCRow(dsClearCarriers.EmailCCRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClearCarriers dsClearCarriers = new dsClearCarriers();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dsClearCarriers.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (EmailCCDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsClearCarriers.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstQuoteStatusDataTable : TypedTableBase<dsClearCarriers.lstQuoteStatusRow>
  {
    private DataColumn columnQuoteStatusID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstQuoteStatusDataTable()
    {
      this.TableName = "lstQuoteStatus";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstQuoteStatusDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstQuoteStatusDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteStatusIDColumn => this.columnQuoteStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.lstQuoteStatusRow this[int index]
    {
      get => (dsClearCarriers.lstQuoteStatusRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.lstQuoteStatusRowChangeEventHandler lstQuoteStatusRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.lstQuoteStatusRowChangeEventHandler lstQuoteStatusRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.lstQuoteStatusRowChangeEventHandler lstQuoteStatusRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.lstQuoteStatusRowChangeEventHandler lstQuoteStatusRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstQuoteStatusRow(dsClearCarriers.lstQuoteStatusRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.lstQuoteStatusRow AddlstQuoteStatusRow(
      byte QuoteStatusID,
      string Description)
    {
      dsClearCarriers.lstQuoteStatusRow row = (dsClearCarriers.lstQuoteStatusRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) QuoteStatusID,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.lstQuoteStatusRow FindByQuoteStatusID(byte QuoteStatusID)
    {
      return (dsClearCarriers.lstQuoteStatusRow) this.Rows.Find(new object[1]
      {
        (object) QuoteStatusID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsClearCarriers.lstQuoteStatusDataTable quoteStatusDataTable = (dsClearCarriers.lstQuoteStatusDataTable) base.Clone();
      quoteStatusDataTable.InitVars();
      return (DataTable) quoteStatusDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClearCarriers.lstQuoteStatusDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteStatusID = this.Columns["QuoteStatusID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteStatusID = new DataColumn("QuoteStatusID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatusID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnQuoteStatusID
      }, true));
      this.columnQuoteStatusID.AllowDBNull = false;
      this.columnQuoteStatusID.Unique = true;
      this.columnDescription.AllowDBNull = false;
      this.columnDescription.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.lstQuoteStatusRow NewlstQuoteStatusRow()
    {
      return (dsClearCarriers.lstQuoteStatusRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClearCarriers.lstQuoteStatusRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsClearCarriers.lstQuoteStatusRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.lstQuoteStatusRowChanged == null)
        return;
      this.lstQuoteStatusRowChanged((object) this, new dsClearCarriers.lstQuoteStatusRowChangeEvent((dsClearCarriers.lstQuoteStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.lstQuoteStatusRowChanging == null)
        return;
      this.lstQuoteStatusRowChanging((object) this, new dsClearCarriers.lstQuoteStatusRowChangeEvent((dsClearCarriers.lstQuoteStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.lstQuoteStatusRowDeleted == null)
        return;
      this.lstQuoteStatusRowDeleted((object) this, new dsClearCarriers.lstQuoteStatusRowChangeEvent((dsClearCarriers.lstQuoteStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.lstQuoteStatusRowDeleting == null)
        return;
      this.lstQuoteStatusRowDeleting((object) this, new dsClearCarriers.lstQuoteStatusRowChangeEvent((dsClearCarriers.lstQuoteStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstQuoteStatusRow(dsClearCarriers.lstQuoteStatusRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClearCarriers dsClearCarriers = new dsClearCarriers();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dsClearCarriers.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstQuoteStatusDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsClearCarriers.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class CurrentCarrierAndContactInfoDataTable : 
    TypedTableBase<dsClearCarriers.CurrentCarrierAndContactInfoRow>
  {
    private DataColumn columnCompanyContactGUID;
    private DataColumn columnCompanyLocationGUID;
    private DataColumn columnContactName;
    private DataColumn columnCompanyGroup;
    private DataColumn columnLocationName;
    private DataColumn columnEmail;
    private DataColumn columnAdd;
    private DataColumn columnCity;
    private DataColumn columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public CurrentCarrierAndContactInfoDataTable()
    {
      this.TableName = "CurrentCarrierAndContactInfo";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal CurrentCarrierAndContactInfoDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected CurrentCarrierAndContactInfoDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyContactGUIDColumn => this.columnCompanyContactGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLocationGUIDColumn => this.columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ContactNameColumn => this.columnContactName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyGroupColumn => this.columnCompanyGroup;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationNameColumn => this.columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AddColumn => this.columnAdd;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.CurrentCarrierAndContactInfoRow this[int index]
    {
      get => (dsClearCarriers.CurrentCarrierAndContactInfoRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.CurrentCarrierAndContactInfoRowChangeEventHandler CurrentCarrierAndContactInfoRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.CurrentCarrierAndContactInfoRowChangeEventHandler CurrentCarrierAndContactInfoRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.CurrentCarrierAndContactInfoRowChangeEventHandler CurrentCarrierAndContactInfoRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClearCarriers.CurrentCarrierAndContactInfoRowChangeEventHandler CurrentCarrierAndContactInfoRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddCurrentCarrierAndContactInfoRow(
      dsClearCarriers.CurrentCarrierAndContactInfoRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.CurrentCarrierAndContactInfoRow AddCurrentCarrierAndContactInfoRow(
      Guid CompanyContactGUID,
      Guid CompanyLocationGUID,
      string ContactName,
      string CompanyGroup,
      string LocationName,
      string Email,
      string Add,
      string City,
      string State)
    {
      dsClearCarriers.CurrentCarrierAndContactInfoRow row = (dsClearCarriers.CurrentCarrierAndContactInfoRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) CompanyContactGUID,
        (object) CompanyLocationGUID,
        (object) ContactName,
        (object) CompanyGroup,
        (object) LocationName,
        (object) Email,
        (object) Add,
        (object) City,
        (object) State
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.CurrentCarrierAndContactInfoRow FindByCompanyContactGUIDCompanyLocationGUID(
      Guid CompanyContactGUID,
      Guid CompanyLocationGUID)
    {
      return (dsClearCarriers.CurrentCarrierAndContactInfoRow) this.Rows.Find(new object[2]
      {
        (object) CompanyContactGUID,
        (object) CompanyLocationGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsClearCarriers.CurrentCarrierAndContactInfoDataTable contactInfoDataTable = (dsClearCarriers.CurrentCarrierAndContactInfoDataTable) base.Clone();
      contactInfoDataTable.InitVars();
      return (DataTable) contactInfoDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClearCarriers.CurrentCarrierAndContactInfoDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyContactGUID = this.Columns["CompanyContactGUID"];
      this.columnCompanyLocationGUID = this.Columns["CompanyLocationGUID"];
      this.columnContactName = this.Columns["ContactName"];
      this.columnCompanyGroup = this.Columns["CompanyGroup"];
      this.columnLocationName = this.Columns["LocationName"];
      this.columnEmail = this.Columns["Email"];
      this.columnAdd = this.Columns["Add"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyContactGUID = new DataColumn("CompanyContactGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyContactGUID);
      this.columnCompanyLocationGUID = new DataColumn("CompanyLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGUID);
      this.columnContactName = new DataColumn("ContactName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactName);
      this.columnCompanyGroup = new DataColumn("CompanyGroup", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGroup);
      this.columnLocationName = new DataColumn("LocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationName);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.columnAdd = new DataColumn("Add", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdd);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnCompanyContactGUID,
        this.columnCompanyLocationGUID
      }, true));
      this.columnCompanyContactGUID.AllowDBNull = false;
      this.columnCompanyLocationGUID.AllowDBNull = false;
      this.columnContactName.AllowDBNull = false;
      this.columnContactName.MaxLength = 50;
      this.columnAdd.DefaultValue = (object) "Add";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.CurrentCarrierAndContactInfoRow NewCurrentCarrierAndContactInfoRow()
    {
      return (dsClearCarriers.CurrentCarrierAndContactInfoRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClearCarriers.CurrentCarrierAndContactInfoRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsClearCarriers.CurrentCarrierAndContactInfoRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.CurrentCarrierAndContactInfoRowChanged == null)
        return;
      this.CurrentCarrierAndContactInfoRowChanged((object) this, new dsClearCarriers.CurrentCarrierAndContactInfoRowChangeEvent((dsClearCarriers.CurrentCarrierAndContactInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.CurrentCarrierAndContactInfoRowChanging == null)
        return;
      this.CurrentCarrierAndContactInfoRowChanging((object) this, new dsClearCarriers.CurrentCarrierAndContactInfoRowChangeEvent((dsClearCarriers.CurrentCarrierAndContactInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.CurrentCarrierAndContactInfoRowDeleted == null)
        return;
      this.CurrentCarrierAndContactInfoRowDeleted((object) this, new dsClearCarriers.CurrentCarrierAndContactInfoRowChangeEvent((dsClearCarriers.CurrentCarrierAndContactInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.CurrentCarrierAndContactInfoRowDeleting == null)
        return;
      this.CurrentCarrierAndContactInfoRowDeleting((object) this, new dsClearCarriers.CurrentCarrierAndContactInfoRowChangeEvent((dsClearCarriers.CurrentCarrierAndContactInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveCurrentCarrierAndContactInfoRow(
      dsClearCarriers.CurrentCarrierAndContactInfoRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClearCarriers dsClearCarriers = new dsClearCarriers();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dsClearCarriers.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CurrentCarrierAndContactInfoDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsClearCarriers.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  public class CompanyAndContactInfoRow : DataRow
  {
    private dsClearCarriers.CompanyAndContactInfoDataTable tableCompanyAndContactInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal CompanyAndContactInfoRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCompanyAndContactInfo = (dsClearCarriers.CompanyAndContactInfoDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyContactGUID
    {
      get => (Guid) this[this.tableCompanyAndContactInfo.CompanyContactGUIDColumn];
      set => this[this.tableCompanyAndContactInfo.CompanyContactGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLocationGUID
    {
      get => (Guid) this[this.tableCompanyAndContactInfo.CompanyLocationGUIDColumn];
      set => this[this.tableCompanyAndContactInfo.CompanyLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ContactName
    {
      get => (string) this[this.tableCompanyAndContactInfo.ContactNameColumn];
      set => this[this.tableCompanyAndContactInfo.ContactNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CompanyGroup
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyAndContactInfo.CompanyGroupColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CompanyGroup' in table 'CompanyAndContactInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyAndContactInfo.CompanyGroupColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LocationName
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyAndContactInfo.LocationNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'LocationName' in table 'CompanyAndContactInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyAndContactInfo.LocationNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyAndContactInfo.EmailColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Email' in table 'CompanyAndContactInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyAndContactInfo.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Add
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyAndContactInfo.AddColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Add' in table 'CompanyAndContactInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyAndContactInfo.AddColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyAndContactInfo.CityColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'City' in table 'CompanyAndContactInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyAndContactInfo.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyAndContactInfo.StateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'State' in table 'CompanyAndContactInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyAndContactInfo.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyGroupNull()
    {
      return this.IsNull(this.tableCompanyAndContactInfo.CompanyGroupColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyGroupNull()
    {
      this[this.tableCompanyAndContactInfo.CompanyGroupColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationNameNull()
    {
      return this.IsNull(this.tableCompanyAndContactInfo.LocationNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationNameNull()
    {
      this[this.tableCompanyAndContactInfo.LocationNameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tableCompanyAndContactInfo.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEmailNull()
    {
      this[this.tableCompanyAndContactInfo.EmailColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddNull() => this.IsNull(this.tableCompanyAndContactInfo.AddColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddNull() => this[this.tableCompanyAndContactInfo.AddColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tableCompanyAndContactInfo.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCityNull() => this[this.tableCompanyAndContactInfo.CityColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tableCompanyAndContactInfo.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateNull()
    {
      this[this.tableCompanyAndContactInfo.StateColumn] = Convert.DBNull;
    }
  }

  public class CompanyAndContactSelectedRow : DataRow
  {
    private dsClearCarriers.CompanyAndContactSelectedDataTable tableCompanyAndContactSelected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal CompanyAndContactSelectedRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCompanyAndContactSelected = (dsClearCarriers.CompanyAndContactSelectedDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyContactGUID
    {
      get => (Guid) this[this.tableCompanyAndContactSelected.CompanyContactGUIDColumn];
      set => this[this.tableCompanyAndContactSelected.CompanyContactGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLocationGUID
    {
      get => (Guid) this[this.tableCompanyAndContactSelected.CompanyLocationGUIDColumn];
      set => this[this.tableCompanyAndContactSelected.CompanyLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ContactName
    {
      get => (string) this[this.tableCompanyAndContactSelected.ContactNameColumn];
      set => this[this.tableCompanyAndContactSelected.ContactNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CompanyGroup
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyAndContactSelected.CompanyGroupColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CompanyGroup' in table 'CompanyAndContactSelected' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyAndContactSelected.CompanyGroupColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LocationName
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyAndContactSelected.LocationNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'LocationName' in table 'CompanyAndContactSelected' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyAndContactSelected.LocationNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyAndContactSelected.EmailColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Email' in table 'CompanyAndContactSelected' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyAndContactSelected.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string EmailCC
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyAndContactSelected.EmailCCColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EmailCC' in table 'CompanyAndContactSelected' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyAndContactSelected.EmailCCColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Remove
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyAndContactSelected.RemoveColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Remove' in table 'CompanyAndContactSelected' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyAndContactSelected.RemoveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyAndContactSelected.CityColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'City' in table 'CompanyAndContactSelected' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyAndContactSelected.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyAndContactSelected.StateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'State' in table 'CompanyAndContactSelected' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyAndContactSelected.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyGroupNull()
    {
      return this.IsNull(this.tableCompanyAndContactSelected.CompanyGroupColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyGroupNull()
    {
      this[this.tableCompanyAndContactSelected.CompanyGroupColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationNameNull()
    {
      return this.IsNull(this.tableCompanyAndContactSelected.LocationNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationNameNull()
    {
      this[this.tableCompanyAndContactSelected.LocationNameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tableCompanyAndContactSelected.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEmailNull()
    {
      this[this.tableCompanyAndContactSelected.EmailColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEmailCCNull() => this.IsNull(this.tableCompanyAndContactSelected.EmailCCColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEmailCCNull()
    {
      this[this.tableCompanyAndContactSelected.EmailCCColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRemoveNull() => this.IsNull(this.tableCompanyAndContactSelected.RemoveColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRemoveNull()
    {
      this[this.tableCompanyAndContactSelected.RemoveColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tableCompanyAndContactSelected.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCityNull()
    {
      this[this.tableCompanyAndContactSelected.CityColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tableCompanyAndContactSelected.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateNull()
    {
      this[this.tableCompanyAndContactSelected.StateColumn] = Convert.DBNull;
    }
  }

  public class EmailCCRow : DataRow
  {
    private dsClearCarriers.EmailCCDataTable tableEmailCC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal EmailCCRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableEmailCC = (dsClearCarriers.EmailCCDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return (string) this[this.tableEmailCC.EmailColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Email' in table 'EmailCC' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEmailCC.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Contact
    {
      get
      {
        try
        {
          return (string) this[this.tableEmailCC.ContactColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Contact' in table 'EmailCC' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEmailCC.ContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLocationGUID
    {
      get
      {
        try
        {
          return (Guid) this[this.tableEmailCC.CompanyLocationGUIDColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CompanyLocationGUID' in table 'EmailCC' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEmailCC.CompanyLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tableEmailCC.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEmailNull() => this[this.tableEmailCC.EmailColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsContactNull() => this.IsNull(this.tableEmailCC.ContactColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetContactNull() => this[this.tableEmailCC.ContactColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyLocationGUIDNull()
    {
      return this.IsNull(this.tableEmailCC.CompanyLocationGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyLocationGUIDNull()
    {
      this[this.tableEmailCC.CompanyLocationGUIDColumn] = Convert.DBNull;
    }
  }

  public class lstQuoteStatusRow : DataRow
  {
    private dsClearCarriers.lstQuoteStatusDataTable tablelstQuoteStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstQuoteStatusRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstQuoteStatus = (dsClearCarriers.lstQuoteStatusDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public byte QuoteStatusID
    {
      get => (byte) this[this.tablelstQuoteStatus.QuoteStatusIDColumn];
      set => this[this.tablelstQuoteStatus.QuoteStatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get => (string) this[this.tablelstQuoteStatus.DescriptionColumn];
      set => this[this.tablelstQuoteStatus.DescriptionColumn] = (object) value;
    }
  }

  public class CurrentCarrierAndContactInfoRow : DataRow
  {
    private dsClearCarriers.CurrentCarrierAndContactInfoDataTable tableCurrentCarrierAndContactInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal CurrentCarrierAndContactInfoRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCurrentCarrierAndContactInfo = (dsClearCarriers.CurrentCarrierAndContactInfoDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyContactGUID
    {
      get => (Guid) this[this.tableCurrentCarrierAndContactInfo.CompanyContactGUIDColumn];
      set => this[this.tableCurrentCarrierAndContactInfo.CompanyContactGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid CompanyLocationGUID
    {
      get => (Guid) this[this.tableCurrentCarrierAndContactInfo.CompanyLocationGUIDColumn];
      set
      {
        this[this.tableCurrentCarrierAndContactInfo.CompanyLocationGUIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ContactName
    {
      get => (string) this[this.tableCurrentCarrierAndContactInfo.ContactNameColumn];
      set => this[this.tableCurrentCarrierAndContactInfo.ContactNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CompanyGroup
    {
      get
      {
        try
        {
          return (string) this[this.tableCurrentCarrierAndContactInfo.CompanyGroupColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CompanyGroup' in table 'CurrentCarrierAndContactInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentCarrierAndContactInfo.CompanyGroupColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LocationName
    {
      get
      {
        try
        {
          return (string) this[this.tableCurrentCarrierAndContactInfo.LocationNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'LocationName' in table 'CurrentCarrierAndContactInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentCarrierAndContactInfo.LocationNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return (string) this[this.tableCurrentCarrierAndContactInfo.EmailColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Email' in table 'CurrentCarrierAndContactInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentCarrierAndContactInfo.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Add
    {
      get
      {
        try
        {
          return (string) this[this.tableCurrentCarrierAndContactInfo.AddColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Add' in table 'CurrentCarrierAndContactInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentCarrierAndContactInfo.AddColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return (string) this[this.tableCurrentCarrierAndContactInfo.CityColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'City' in table 'CurrentCarrierAndContactInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentCarrierAndContactInfo.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return (string) this[this.tableCurrentCarrierAndContactInfo.StateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'State' in table 'CurrentCarrierAndContactInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentCarrierAndContactInfo.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyGroupNull()
    {
      return this.IsNull(this.tableCurrentCarrierAndContactInfo.CompanyGroupColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyGroupNull()
    {
      this[this.tableCurrentCarrierAndContactInfo.CompanyGroupColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationNameNull()
    {
      return this.IsNull(this.tableCurrentCarrierAndContactInfo.LocationNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationNameNull()
    {
      this[this.tableCurrentCarrierAndContactInfo.LocationNameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tableCurrentCarrierAndContactInfo.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEmailNull()
    {
      this[this.tableCurrentCarrierAndContactInfo.EmailColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddNull() => this.IsNull(this.tableCurrentCarrierAndContactInfo.AddColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddNull()
    {
      this[this.tableCurrentCarrierAndContactInfo.AddColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tableCurrentCarrierAndContactInfo.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCityNull()
    {
      this[this.tableCurrentCarrierAndContactInfo.CityColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tableCurrentCarrierAndContactInfo.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateNull()
    {
      this[this.tableCurrentCarrierAndContactInfo.StateColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class CompanyAndContactInfoRowChangeEvent : EventArgs
  {
    private dsClearCarriers.CompanyAndContactInfoRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public CompanyAndContactInfoRowChangeEvent(
      dsClearCarriers.CompanyAndContactInfoRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.CompanyAndContactInfoRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class CompanyAndContactSelectedRowChangeEvent : EventArgs
  {
    private dsClearCarriers.CompanyAndContactSelectedRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public CompanyAndContactSelectedRowChangeEvent(
      dsClearCarriers.CompanyAndContactSelectedRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.CompanyAndContactSelectedRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class EmailCCRowChangeEvent : EventArgs
  {
    private dsClearCarriers.EmailCCRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public EmailCCRowChangeEvent(dsClearCarriers.EmailCCRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.EmailCCRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstQuoteStatusRowChangeEvent : EventArgs
  {
    private dsClearCarriers.lstQuoteStatusRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstQuoteStatusRowChangeEvent(dsClearCarriers.lstQuoteStatusRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.lstQuoteStatusRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class CurrentCarrierAndContactInfoRowChangeEvent : EventArgs
  {
    private dsClearCarriers.CurrentCarrierAndContactInfoRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public CurrentCarrierAndContactInfoRowChangeEvent(
      dsClearCarriers.CurrentCarrierAndContactInfoRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClearCarriers.CurrentCarrierAndContactInfoRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
