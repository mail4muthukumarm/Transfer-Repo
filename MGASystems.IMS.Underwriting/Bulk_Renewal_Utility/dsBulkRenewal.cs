// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Bulk_Renewal_Utility.dsBulkRenewal
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
namespace MGASystems.IMS.Underwriting.Bulk_Renewal_Utility;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsBulkRenewal")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsBulkRenewal : DataSet
{
  private dsBulkRenewal.spGetBulkRenewalUtilityListDataTable tablespGetBulkRenewalUtilityList;
  private dsBulkRenewal.PolicyRenewalsDataTable tablePolicyRenewals;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public dsBulkRenewal()
  {
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected dsBulkRenewal(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (spGetBulkRenewalUtilityList)] != null)
          base.Tables.Add((DataTable) new dsBulkRenewal.spGetBulkRenewalUtilityListDataTable(dataSet.Tables[nameof (spGetBulkRenewalUtilityList)]));
        if (dataSet.Tables[nameof (PolicyRenewals)] != null)
          base.Tables.Add((DataTable) new dsBulkRenewal.PolicyRenewalsDataTable(dataSet.Tables[nameof (PolicyRenewals)]));
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
  public dsBulkRenewal.spGetBulkRenewalUtilityListDataTable spGetBulkRenewalUtilityList
  {
    get => this.tablespGetBulkRenewalUtilityList;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsBulkRenewal.PolicyRenewalsDataTable PolicyRenewals => this.tablePolicyRenewals;

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
    dsBulkRenewal dsBulkRenewal = (dsBulkRenewal) base.Clone();
    dsBulkRenewal.InitVars();
    dsBulkRenewal.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsBulkRenewal;
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
      if (dataSet.Tables["spGetBulkRenewalUtilityList"] != null)
        base.Tables.Add((DataTable) new dsBulkRenewal.spGetBulkRenewalUtilityListDataTable(dataSet.Tables["spGetBulkRenewalUtilityList"]));
      if (dataSet.Tables["PolicyRenewals"] != null)
        base.Tables.Add((DataTable) new dsBulkRenewal.PolicyRenewalsDataTable(dataSet.Tables["PolicyRenewals"]));
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
    this.tablespGetBulkRenewalUtilityList = (dsBulkRenewal.spGetBulkRenewalUtilityListDataTable) base.Tables["spGetBulkRenewalUtilityList"];
    if (initTable && this.tablespGetBulkRenewalUtilityList != null)
      this.tablespGetBulkRenewalUtilityList.InitVars();
    this.tablePolicyRenewals = (dsBulkRenewal.PolicyRenewalsDataTable) base.Tables["PolicyRenewals"];
    if (!initTable || this.tablePolicyRenewals == null)
      return;
    this.tablePolicyRenewals.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsBulkRenewal);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsBulkRenewal.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablespGetBulkRenewalUtilityList = new dsBulkRenewal.spGetBulkRenewalUtilityListDataTable();
    base.Tables.Add((DataTable) this.tablespGetBulkRenewalUtilityList);
    this.tablePolicyRenewals = new dsBulkRenewal.PolicyRenewalsDataTable();
    base.Tables.Add((DataTable) this.tablePolicyRenewals);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializespGetBulkRenewalUtilityList() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializePolicyRenewals() => false;

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
    dsBulkRenewal dsBulkRenewal = new dsBulkRenewal();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = dsBulkRenewal.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = dsBulkRenewal.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void spGetBulkRenewalUtilityListRowChangeEventHandler(
    object sender,
    dsBulkRenewal.spGetBulkRenewalUtilityListRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void PolicyRenewalsRowChangeEventHandler(
    object sender,
    dsBulkRenewal.PolicyRenewalsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class spGetBulkRenewalUtilityListDataTable : 
    TypedTableBase<dsBulkRenewal.spGetBulkRenewalUtilityListRow>
  {
    private DataColumn columnCompanyGroupGUID;
    private DataColumn columnInsured;
    private DataColumn columnBroker;
    private DataColumn columnProducerLocationName;
    private DataColumn columnExpirationDate;
    private DataColumn columnControlNo;
    private DataColumn columnCompany;
    private DataColumn columnUnd;
    private DataColumn columnUndAssist;
    private DataColumn columnPremium;
    private DataColumn columnLines;
    private DataColumn columnPolicyNumber;
    private DataColumn columnStatus;
    private DataColumn columnTACSR;
    private DataColumn columnState;
    private DataColumn columnClaimCount;
    private DataColumn columnTotalIncurred;
    private DataColumn columnLossRatio;
    private DataColumn columnRenewalControlno;
    private DataColumn columnRenewalStatus;
    private DataColumn columnSelected;
    private DataColumn columnPayType;
    private DataColumn columnTotalPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public spGetBulkRenewalUtilityListDataTable()
    {
      this.TableName = "spGetBulkRenewalUtilityList";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal spGetBulkRenewalUtilityListDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected spGetBulkRenewalUtilityListDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CompanyGroupGUIDColumn => this.columnCompanyGroupGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn InsuredColumn => this.columnInsured;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn BrokerColumn => this.columnBroker;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerLocationNameColumn => this.columnProducerLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CompanyColumn => this.columnCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn UndColumn => this.columnUnd;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn UndAssistColumn => this.columnUndAssist;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn LinesColumn => this.columnLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TACSRColumn => this.columnTACSR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ClaimCountColumn => this.columnClaimCount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TotalIncurredColumn => this.columnTotalIncurred;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn LossRatioColumn => this.columnLossRatio;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn RenewalControlnoColumn => this.columnRenewalControlno;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn RenewalStatusColumn => this.columnRenewalStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn SelectedColumn => this.columnSelected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PayTypeColumn => this.columnPayType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TotalPaidColumn => this.columnTotalPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBulkRenewal.spGetBulkRenewalUtilityListRow this[int index]
    {
      get => (dsBulkRenewal.spGetBulkRenewalUtilityListRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBulkRenewal.spGetBulkRenewalUtilityListRowChangeEventHandler spGetBulkRenewalUtilityListRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBulkRenewal.spGetBulkRenewalUtilityListRowChangeEventHandler spGetBulkRenewalUtilityListRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBulkRenewal.spGetBulkRenewalUtilityListRowChangeEventHandler spGetBulkRenewalUtilityListRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBulkRenewal.spGetBulkRenewalUtilityListRowChangeEventHandler spGetBulkRenewalUtilityListRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddspGetBulkRenewalUtilityListRow(dsBulkRenewal.spGetBulkRenewalUtilityListRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBulkRenewal.spGetBulkRenewalUtilityListRow AddspGetBulkRenewalUtilityListRow(
      Guid CompanyGroupGUID,
      string Insured,
      string Broker,
      string ProducerLocationName,
      DateTime ExpirationDate,
      int ControlNo,
      string Company,
      string Und,
      string UndAssist,
      Decimal Premium,
      string Lines,
      string PolicyNumber,
      string Status,
      string TACSR,
      string State,
      int ClaimCount,
      Decimal TotalIncurred,
      Decimal LossRatio,
      int RenewalControlno,
      string RenewalStatus,
      bool Selected,
      string PayType,
      Decimal TotalPaid)
    {
      dsBulkRenewal.spGetBulkRenewalUtilityListRow row = (dsBulkRenewal.spGetBulkRenewalUtilityListRow) this.NewRow();
      object[] objArray = new object[23]
      {
        (object) CompanyGroupGUID,
        (object) Insured,
        (object) Broker,
        (object) ProducerLocationName,
        (object) ExpirationDate,
        (object) ControlNo,
        (object) Company,
        (object) Und,
        (object) UndAssist,
        (object) Premium,
        (object) Lines,
        (object) PolicyNumber,
        (object) Status,
        (object) TACSR,
        (object) State,
        (object) ClaimCount,
        (object) TotalIncurred,
        (object) LossRatio,
        (object) RenewalControlno,
        (object) RenewalStatus,
        (object) Selected,
        (object) PayType,
        (object) TotalPaid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBulkRenewal.spGetBulkRenewalUtilityListRow FindByControlNo(int ControlNo)
    {
      return (dsBulkRenewal.spGetBulkRenewalUtilityListRow) this.Rows.Find(new object[1]
      {
        (object) ControlNo
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsBulkRenewal.spGetBulkRenewalUtilityListDataTable utilityListDataTable = (dsBulkRenewal.spGetBulkRenewalUtilityListDataTable) base.Clone();
      utilityListDataTable.InitVars();
      return (DataTable) utilityListDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBulkRenewal.spGetBulkRenewalUtilityListDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyGroupGUID = this.Columns["CompanyGroupGUID"];
      this.columnInsured = this.Columns["Insured"];
      this.columnBroker = this.Columns["Broker"];
      this.columnProducerLocationName = this.Columns["ProducerLocationName"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnCompany = this.Columns["Company"];
      this.columnUnd = this.Columns["Und"];
      this.columnUndAssist = this.Columns["UndAssist"];
      this.columnPremium = this.Columns["Premium"];
      this.columnLines = this.Columns["Lines"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnStatus = this.Columns["Status"];
      this.columnTACSR = this.Columns["TACSR"];
      this.columnState = this.Columns["State"];
      this.columnClaimCount = this.Columns["ClaimCount"];
      this.columnTotalIncurred = this.Columns["TotalIncurred"];
      this.columnLossRatio = this.Columns["LossRatio"];
      this.columnRenewalControlno = this.Columns["RenewalControlno"];
      this.columnRenewalStatus = this.Columns["RenewalStatus"];
      this.columnSelected = this.Columns["Selected"];
      this.columnPayType = this.Columns["PayType"];
      this.columnTotalPaid = this.Columns["TotalPaid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyGroupGUID = new DataColumn("CompanyGroupGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGroupGUID);
      this.columnInsured = new DataColumn("Insured", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured);
      this.columnBroker = new DataColumn("Broker", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBroker);
      this.columnProducerLocationName = new DataColumn("ProducerLocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationName);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnCompany = new DataColumn("Company", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany);
      this.columnUnd = new DataColumn("Und", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnd);
      this.columnUndAssist = new DataColumn("UndAssist", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUndAssist);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnLines = new DataColumn("Lines", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLines);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnTACSR = new DataColumn("TACSR", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTACSR);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnClaimCount = new DataColumn("ClaimCount", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimCount);
      this.columnTotalIncurred = new DataColumn("TotalIncurred", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalIncurred);
      this.columnLossRatio = new DataColumn("LossRatio", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLossRatio);
      this.columnRenewalControlno = new DataColumn("RenewalControlno", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRenewalControlno);
      this.columnRenewalStatus = new DataColumn("RenewalStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRenewalStatus);
      this.columnSelected = new DataColumn("Selected", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSelected);
      this.columnPayType = new DataColumn("PayType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayType);
      this.columnTotalPaid = new DataColumn("TotalPaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalPaid);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnControlNo
      }, true));
      this.columnInsured.MaxLength = 1000;
      this.columnBroker.MaxLength = 1000;
      this.columnProducerLocationName.MaxLength = 1000;
      this.columnControlNo.AllowDBNull = false;
      this.columnControlNo.Unique = true;
      this.columnCompany.MaxLength = 1000;
      this.columnUnd.MaxLength = 10;
      this.columnUndAssist.MaxLength = 10;
      this.columnPremium.ReadOnly = true;
      this.columnLines.MaxLength = 1000;
      this.columnPolicyNumber.MaxLength = 500;
      this.columnStatus.MaxLength = 50;
      this.columnTACSR.MaxLength = 250;
      this.columnState.MaxLength = 20;
      this.columnClaimCount.ReadOnly = true;
      this.columnTotalIncurred.ReadOnly = true;
      this.columnLossRatio.ReadOnly = true;
      this.columnRenewalStatus.MaxLength = 50;
      this.columnSelected.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBulkRenewal.spGetBulkRenewalUtilityListRow NewspGetBulkRenewalUtilityListRow()
    {
      return (dsBulkRenewal.spGetBulkRenewalUtilityListRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBulkRenewal.spGetBulkRenewalUtilityListRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsBulkRenewal.spGetBulkRenewalUtilityListRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.spGetBulkRenewalUtilityListRowChanged == null)
        return;
      this.spGetBulkRenewalUtilityListRowChanged((object) this, new dsBulkRenewal.spGetBulkRenewalUtilityListRowChangeEvent((dsBulkRenewal.spGetBulkRenewalUtilityListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.spGetBulkRenewalUtilityListRowChanging == null)
        return;
      this.spGetBulkRenewalUtilityListRowChanging((object) this, new dsBulkRenewal.spGetBulkRenewalUtilityListRowChangeEvent((dsBulkRenewal.spGetBulkRenewalUtilityListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.spGetBulkRenewalUtilityListRowDeleted == null)
        return;
      this.spGetBulkRenewalUtilityListRowDeleted((object) this, new dsBulkRenewal.spGetBulkRenewalUtilityListRowChangeEvent((dsBulkRenewal.spGetBulkRenewalUtilityListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.spGetBulkRenewalUtilityListRowDeleting == null)
        return;
      this.spGetBulkRenewalUtilityListRowDeleting((object) this, new dsBulkRenewal.spGetBulkRenewalUtilityListRowChangeEvent((dsBulkRenewal.spGetBulkRenewalUtilityListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovespGetBulkRenewalUtilityListRow(
      dsBulkRenewal.spGetBulkRenewalUtilityListRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsBulkRenewal dsBulkRenewal = new dsBulkRenewal();
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
        FixedValue = dsBulkRenewal.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (spGetBulkRenewalUtilityListDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsBulkRenewal.GetSchemaSerializable();
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
  public class PolicyRenewalsDataTable : TypedTableBase<dsBulkRenewal.PolicyRenewalsRow>
  {
    private DataColumn columnControlNo;
    private DataColumn columnPolicyNumber;
    private DataColumn columnInsured;
    private DataColumn columnRenewalControlNo;
    private DataColumn columnStatus;
    private DataColumn columnRenewalGuid;
    private DataColumn columnSelected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PolicyRenewalsDataTable()
    {
      this.TableName = "PolicyRenewals";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PolicyRenewalsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected PolicyRenewalsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn InsuredColumn => this.columnInsured;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn RenewalControlNoColumn => this.columnRenewalControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn RenewalGuidColumn => this.columnRenewalGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn SelectedColumn => this.columnSelected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBulkRenewal.PolicyRenewalsRow this[int index]
    {
      get => (dsBulkRenewal.PolicyRenewalsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBulkRenewal.PolicyRenewalsRowChangeEventHandler PolicyRenewalsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBulkRenewal.PolicyRenewalsRowChangeEventHandler PolicyRenewalsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBulkRenewal.PolicyRenewalsRowChangeEventHandler PolicyRenewalsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsBulkRenewal.PolicyRenewalsRowChangeEventHandler PolicyRenewalsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddPolicyRenewalsRow(dsBulkRenewal.PolicyRenewalsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBulkRenewal.PolicyRenewalsRow AddPolicyRenewalsRow(
      int ControlNo,
      string PolicyNumber,
      string Insured,
      int RenewalControlNo,
      string Status,
      Guid RenewalGuid,
      bool Selected)
    {
      dsBulkRenewal.PolicyRenewalsRow row = (dsBulkRenewal.PolicyRenewalsRow) this.NewRow();
      object[] objArray = new object[7]
      {
        (object) ControlNo,
        (object) PolicyNumber,
        (object) Insured,
        (object) RenewalControlNo,
        (object) Status,
        (object) RenewalGuid,
        (object) Selected
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBulkRenewal.PolicyRenewalsRow FindByControlNo(int ControlNo)
    {
      return (dsBulkRenewal.PolicyRenewalsRow) this.Rows.Find(new object[1]
      {
        (object) ControlNo
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsBulkRenewal.PolicyRenewalsDataTable renewalsDataTable = (dsBulkRenewal.PolicyRenewalsDataTable) base.Clone();
      renewalsDataTable.InitVars();
      return (DataTable) renewalsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBulkRenewal.PolicyRenewalsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInsured = this.Columns["Insured"];
      this.columnRenewalControlNo = this.Columns["RenewalControlNo"];
      this.columnStatus = this.Columns["Status"];
      this.columnRenewalGuid = this.Columns["RenewalGuid"];
      this.columnSelected = this.Columns["Selected"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsured = new DataColumn("Insured", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured);
      this.columnRenewalControlNo = new DataColumn("RenewalControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRenewalControlNo);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnRenewalGuid = new DataColumn("RenewalGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRenewalGuid);
      this.columnSelected = new DataColumn("Selected", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSelected);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnControlNo
      }, true));
      this.columnControlNo.AllowDBNull = false;
      this.columnControlNo.Unique = true;
      this.columnSelected.AllowDBNull = false;
      this.columnSelected.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBulkRenewal.PolicyRenewalsRow NewPolicyRenewalsRow()
    {
      return (dsBulkRenewal.PolicyRenewalsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBulkRenewal.PolicyRenewalsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsBulkRenewal.PolicyRenewalsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.PolicyRenewalsRowChanged == null)
        return;
      this.PolicyRenewalsRowChanged((object) this, new dsBulkRenewal.PolicyRenewalsRowChangeEvent((dsBulkRenewal.PolicyRenewalsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.PolicyRenewalsRowChanging == null)
        return;
      this.PolicyRenewalsRowChanging((object) this, new dsBulkRenewal.PolicyRenewalsRowChangeEvent((dsBulkRenewal.PolicyRenewalsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.PolicyRenewalsRowDeleted == null)
        return;
      this.PolicyRenewalsRowDeleted((object) this, new dsBulkRenewal.PolicyRenewalsRowChangeEvent((dsBulkRenewal.PolicyRenewalsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.PolicyRenewalsRowDeleting == null)
        return;
      this.PolicyRenewalsRowDeleting((object) this, new dsBulkRenewal.PolicyRenewalsRowChangeEvent((dsBulkRenewal.PolicyRenewalsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovePolicyRenewalsRow(dsBulkRenewal.PolicyRenewalsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsBulkRenewal dsBulkRenewal = new dsBulkRenewal();
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
        FixedValue = dsBulkRenewal.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PolicyRenewalsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsBulkRenewal.GetSchemaSerializable();
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

  public class spGetBulkRenewalUtilityListRow : DataRow
  {
    private dsBulkRenewal.spGetBulkRenewalUtilityListDataTable tablespGetBulkRenewalUtilityList;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal spGetBulkRenewalUtilityListRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespGetBulkRenewalUtilityList = (dsBulkRenewal.spGetBulkRenewalUtilityListDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid CompanyGroupGUID
    {
      get
      {
        try
        {
          return (Guid) this[this.tablespGetBulkRenewalUtilityList.CompanyGroupGUIDColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CompanyGroupGUID' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.CompanyGroupGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Insured
    {
      get
      {
        try
        {
          return (string) this[this.tablespGetBulkRenewalUtilityList.InsuredColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Insured' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.InsuredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Broker
    {
      get
      {
        try
        {
          return (string) this[this.tablespGetBulkRenewalUtilityList.BrokerColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Broker' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.BrokerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ProducerLocationName
    {
      get
      {
        try
        {
          return (string) this[this.tablespGetBulkRenewalUtilityList.ProducerLocationNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ProducerLocationName' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablespGetBulkRenewalUtilityList.ProducerLocationNameColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime ExpirationDate
    {
      get
      {
        try
        {
          return (DateTime) this[this.tablespGetBulkRenewalUtilityList.ExpirationDateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ExpirationDate' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ControlNo
    {
      get => (int) this[this.tablespGetBulkRenewalUtilityList.ControlNoColumn];
      set => this[this.tablespGetBulkRenewalUtilityList.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Company
    {
      get
      {
        try
        {
          return (string) this[this.tablespGetBulkRenewalUtilityList.CompanyColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Company' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.CompanyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Und
    {
      get
      {
        try
        {
          return (string) this[this.tablespGetBulkRenewalUtilityList.UndColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Und' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.UndColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string UndAssist
    {
      get
      {
        try
        {
          return (string) this[this.tablespGetBulkRenewalUtilityList.UndAssistColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'UndAssist' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.UndAssistColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Premium
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablespGetBulkRenewalUtilityList.PremiumColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Premium' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Lines
    {
      get
      {
        try
        {
          return (string) this[this.tablespGetBulkRenewalUtilityList.LinesColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Lines' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.LinesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return (string) this[this.tablespGetBulkRenewalUtilityList.PolicyNumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Status
    {
      get
      {
        try
        {
          return (string) this[this.tablespGetBulkRenewalUtilityList.StatusColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Status' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.StatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string TACSR
    {
      get
      {
        try
        {
          return (string) this[this.tablespGetBulkRenewalUtilityList.TACSRColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'TACSR' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.TACSRColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return (string) this[this.tablespGetBulkRenewalUtilityList.StateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'State' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ClaimCount
    {
      get
      {
        try
        {
          return (int) this[this.tablespGetBulkRenewalUtilityList.ClaimCountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ClaimCount' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.ClaimCountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal TotalIncurred
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablespGetBulkRenewalUtilityList.TotalIncurredColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'TotalIncurred' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.TotalIncurredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal LossRatio
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablespGetBulkRenewalUtilityList.LossRatioColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'LossRatio' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.LossRatioColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int RenewalControlno
    {
      get
      {
        try
        {
          return (int) this[this.tablespGetBulkRenewalUtilityList.RenewalControlnoColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'RenewalControlno' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.RenewalControlnoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string RenewalStatus
    {
      get
      {
        try
        {
          return (string) this[this.tablespGetBulkRenewalUtilityList.RenewalStatusColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'RenewalStatus' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.RenewalStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Selected
    {
      get
      {
        try
        {
          return (bool) this[this.tablespGetBulkRenewalUtilityList.SelectedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Selected' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.SelectedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PayType
    {
      get
      {
        try
        {
          return (string) this[this.tablespGetBulkRenewalUtilityList.PayTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PayType' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.PayTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal TotalPaid
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablespGetBulkRenewalUtilityList.TotalPaidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'TotalPaid' in table 'spGetBulkRenewalUtilityList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetBulkRenewalUtilityList.TotalPaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCompanyGroupGUIDNull()
    {
      return this.IsNull(this.tablespGetBulkRenewalUtilityList.CompanyGroupGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCompanyGroupGUIDNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.CompanyGroupGUIDColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsInsuredNull() => this.IsNull(this.tablespGetBulkRenewalUtilityList.InsuredColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetInsuredNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.InsuredColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsBrokerNull() => this.IsNull(this.tablespGetBulkRenewalUtilityList.BrokerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetBrokerNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.BrokerColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsProducerLocationNameNull()
    {
      return this.IsNull(this.tablespGetBulkRenewalUtilityList.ProducerLocationNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetProducerLocationNameNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.ProducerLocationNameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsExpirationDateNull()
    {
      return this.IsNull(this.tablespGetBulkRenewalUtilityList.ExpirationDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetExpirationDateNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.ExpirationDateColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCompanyNull() => this.IsNull(this.tablespGetBulkRenewalUtilityList.CompanyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCompanyNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.CompanyColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsUndNull() => this.IsNull(this.tablespGetBulkRenewalUtilityList.UndColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetUndNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.UndColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsUndAssistNull()
    {
      return this.IsNull(this.tablespGetBulkRenewalUtilityList.UndAssistColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetUndAssistNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.UndAssistColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tablespGetBulkRenewalUtilityList.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.PremiumColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsLinesNull() => this.IsNull(this.tablespGetBulkRenewalUtilityList.LinesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetLinesNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.LinesColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPolicyNumberNull()
    {
      return this.IsNull(this.tablespGetBulkRenewalUtilityList.PolicyNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.PolicyNumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsStatusNull() => this.IsNull(this.tablespGetBulkRenewalUtilityList.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetStatusNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.StatusColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsTACSRNull() => this.IsNull(this.tablespGetBulkRenewalUtilityList.TACSRColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetTACSRNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.TACSRColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tablespGetBulkRenewalUtilityList.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetStateNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.StateColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsClaimCountNull()
    {
      return this.IsNull(this.tablespGetBulkRenewalUtilityList.ClaimCountColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetClaimCountNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.ClaimCountColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsTotalIncurredNull()
    {
      return this.IsNull(this.tablespGetBulkRenewalUtilityList.TotalIncurredColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetTotalIncurredNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.TotalIncurredColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsLossRatioNull()
    {
      return this.IsNull(this.tablespGetBulkRenewalUtilityList.LossRatioColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetLossRatioNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.LossRatioColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsRenewalControlnoNull()
    {
      return this.IsNull(this.tablespGetBulkRenewalUtilityList.RenewalControlnoColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetRenewalControlnoNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.RenewalControlnoColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsRenewalStatusNull()
    {
      return this.IsNull(this.tablespGetBulkRenewalUtilityList.RenewalStatusColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetRenewalStatusNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.RenewalStatusColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsSelectedNull()
    {
      return this.IsNull(this.tablespGetBulkRenewalUtilityList.SelectedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetSelectedNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.SelectedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPayTypeNull() => this.IsNull(this.tablespGetBulkRenewalUtilityList.PayTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPayTypeNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.PayTypeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsTotalPaidNull()
    {
      return this.IsNull(this.tablespGetBulkRenewalUtilityList.TotalPaidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetTotalPaidNull()
    {
      this[this.tablespGetBulkRenewalUtilityList.TotalPaidColumn] = Convert.DBNull;
    }
  }

  public class PolicyRenewalsRow : DataRow
  {
    private dsBulkRenewal.PolicyRenewalsDataTable tablePolicyRenewals;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PolicyRenewalsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePolicyRenewals = (dsBulkRenewal.PolicyRenewalsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ControlNo
    {
      get => (int) this[this.tablePolicyRenewals.ControlNoColumn];
      set => this[this.tablePolicyRenewals.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyRenewals.PolicyNumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'PolicyRenewals' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyRenewals.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Insured
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyRenewals.InsuredColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Insured' in table 'PolicyRenewals' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyRenewals.InsuredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int RenewalControlNo
    {
      get
      {
        try
        {
          return (int) this[this.tablePolicyRenewals.RenewalControlNoColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'RenewalControlNo' in table 'PolicyRenewals' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyRenewals.RenewalControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Status
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyRenewals.StatusColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Status' in table 'PolicyRenewals' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyRenewals.StatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid RenewalGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tablePolicyRenewals.RenewalGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'RenewalGuid' in table 'PolicyRenewals' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyRenewals.RenewalGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Selected
    {
      get => (bool) this[this.tablePolicyRenewals.SelectedColumn];
      set => this[this.tablePolicyRenewals.SelectedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tablePolicyRenewals.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tablePolicyRenewals.PolicyNumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsInsuredNull() => this.IsNull(this.tablePolicyRenewals.InsuredColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetInsuredNull() => this[this.tablePolicyRenewals.InsuredColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsRenewalControlNoNull()
    {
      return this.IsNull(this.tablePolicyRenewals.RenewalControlNoColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetRenewalControlNoNull()
    {
      this[this.tablePolicyRenewals.RenewalControlNoColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsStatusNull() => this.IsNull(this.tablePolicyRenewals.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetStatusNull() => this[this.tablePolicyRenewals.StatusColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsRenewalGuidNull() => this.IsNull(this.tablePolicyRenewals.RenewalGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetRenewalGuidNull()
    {
      this[this.tablePolicyRenewals.RenewalGuidColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class spGetBulkRenewalUtilityListRowChangeEvent : EventArgs
  {
    private dsBulkRenewal.spGetBulkRenewalUtilityListRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public spGetBulkRenewalUtilityListRowChangeEvent(
      dsBulkRenewal.spGetBulkRenewalUtilityListRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBulkRenewal.spGetBulkRenewalUtilityListRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class PolicyRenewalsRowChangeEvent : EventArgs
  {
    private dsBulkRenewal.PolicyRenewalsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PolicyRenewalsRowChangeEvent(dsBulkRenewal.PolicyRenewalsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsBulkRenewal.PolicyRenewalsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
