// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Claims.dsClaims
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
namespace MGASystems.IMS.Policies.Claims;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsClaims")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsClaims : DataSet
{
  private dsClaims.tblClaimInformationDataTable tabletblClaimInformation;
  private dsClaims.tblClaimResPaymentActivityDataTable tabletblClaimResPaymentActivity;
  private dsClaims.lstStatesDataTable tablelstStates;
  private DataRelation relationtblClaimInformationtblClaimResPaymentActivity;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsClaims()
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
  protected dsClaims(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblClaimInformation)] != null)
          base.Tables.Add((DataTable) new dsClaims.tblClaimInformationDataTable(dataSet.Tables[nameof (tblClaimInformation)]));
        if (dataSet.Tables[nameof (tblClaimResPaymentActivity)] != null)
          base.Tables.Add((DataTable) new dsClaims.tblClaimResPaymentActivityDataTable(dataSet.Tables[nameof (tblClaimResPaymentActivity)]));
        if (dataSet.Tables[nameof (lstStates)] != null)
          base.Tables.Add((DataTable) new dsClaims.lstStatesDataTable(dataSet.Tables[nameof (lstStates)]));
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
  public dsClaims.tblClaimInformationDataTable tblClaimInformation => this.tabletblClaimInformation;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaims.tblClaimResPaymentActivityDataTable tblClaimResPaymentActivity
  {
    get => this.tabletblClaimResPaymentActivity;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaims.lstStatesDataTable lstStates => this.tablelstStates;

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
    dsClaims dsClaims = (dsClaims) base.Clone();
    dsClaims.InitVars();
    dsClaims.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsClaims;
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
      if (dataSet.Tables["tblClaimInformation"] != null)
        base.Tables.Add((DataTable) new dsClaims.tblClaimInformationDataTable(dataSet.Tables["tblClaimInformation"]));
      if (dataSet.Tables["tblClaimResPaymentActivity"] != null)
        base.Tables.Add((DataTable) new dsClaims.tblClaimResPaymentActivityDataTable(dataSet.Tables["tblClaimResPaymentActivity"]));
      if (dataSet.Tables["lstStates"] != null)
        base.Tables.Add((DataTable) new dsClaims.lstStatesDataTable(dataSet.Tables["lstStates"]));
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
    this.tabletblClaimInformation = (dsClaims.tblClaimInformationDataTable) base.Tables["tblClaimInformation"];
    if (initTable && this.tabletblClaimInformation != null)
      this.tabletblClaimInformation.InitVars();
    this.tabletblClaimResPaymentActivity = (dsClaims.tblClaimResPaymentActivityDataTable) base.Tables["tblClaimResPaymentActivity"];
    if (initTable && this.tabletblClaimResPaymentActivity != null)
      this.tabletblClaimResPaymentActivity.InitVars();
    this.tablelstStates = (dsClaims.lstStatesDataTable) base.Tables["lstStates"];
    if (initTable && this.tablelstStates != null)
      this.tablelstStates.InitVars();
    this.relationtblClaimInformationtblClaimResPaymentActivity = this.Relations["tblClaimInformationtblClaimResPaymentActivity"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsClaims);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsClaims.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblClaimInformation = new dsClaims.tblClaimInformationDataTable();
    base.Tables.Add((DataTable) this.tabletblClaimInformation);
    this.tabletblClaimResPaymentActivity = new dsClaims.tblClaimResPaymentActivityDataTable();
    base.Tables.Add((DataTable) this.tabletblClaimResPaymentActivity);
    this.tablelstStates = new dsClaims.lstStatesDataTable();
    base.Tables.Add((DataTable) this.tablelstStates);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("tblClaimInformationtblClaimResPaymentActivity", new DataColumn[1]
    {
      this.tabletblClaimInformation.ClaimIDColumn
    }, new DataColumn[1]
    {
      this.tabletblClaimResPaymentActivity.ClaimIDColumn
    });
    this.tabletblClaimResPaymentActivity.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationtblClaimInformationtblClaimResPaymentActivity = new DataRelation("tblClaimInformationtblClaimResPaymentActivity", new DataColumn[1]
    {
      this.tabletblClaimInformation.ClaimIDColumn
    }, new DataColumn[1]
    {
      this.tabletblClaimResPaymentActivity.ClaimIDColumn
    }, false);
    this.Relations.Add(this.relationtblClaimInformationtblClaimResPaymentActivity);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblClaimInformation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblClaimResPaymentActivity() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstStates() => false;

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
    dsClaims dsClaims = new dsClaims();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsClaims.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsClaims.GetSchemaSerializable();
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
  public delegate void tblClaimInformationRowChangeEventHandler(
    object sender,
    dsClaims.tblClaimInformationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblClaimResPaymentActivityRowChangeEventHandler(
    object sender,
    dsClaims.tblClaimResPaymentActivityRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstStatesRowChangeEventHandler(
    object sender,
    dsClaims.lstStatesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblClaimInformationDataTable : TypedTableBase<dsClaims.tblClaimInformationRow>
  {
    private DataColumn columnClaimID;
    private DataColumn columnControlNo;
    private DataColumn columnClaimNo;
    private DataColumn columnDateReported;
    private DataColumn columnLossDate;
    private DataColumn columnLossType;
    private DataColumn columnStatus;
    private DataColumn columnDateClosed;
    private DataColumn columnInLitigation;
    private DataColumn columnDescriptionInjury;
    private DataColumn columnCATNo;
    private DataColumn columnReadOnly;
    private DataColumn columnDateReceived;
    private DataColumn columnLocationID;
    private DataColumn columnClaimant;
    private DataColumn columnDeductible;
    private DataColumn columnCoverageDescription;
    private DataColumn columnCompany;
    private DataColumn columnCorresBranchName;
    private DataColumn columnOccurence;
    private DataColumn columnLOB;
    private DataColumn columnCounty;
    private DataColumn columnLien;
    private DataColumn columnSubroPotential;
    private DataColumn columnFirstThirdParty;
    private DataColumn columnFatality;
    private DataColumn columnNCCICode;
    private DataColumn columnDateReopened;
    private DataColumn columnInitialContact;
    private DataColumn columnFirstInsp;
    private DataColumn columnFirstReport;
    private DataColumn columnReportToCarrier;
    private DataColumn columnAdjusterName;
    private DataColumn columnAdjusterTitle;
    private DataColumn columnAdjusterCategory;
    private DataColumn columnIndepAdjuster;
    private DataColumn columnDefFirm;
    private DataColumn columnClaimantCounsel;
    private DataColumn columnGender;
    private DataColumn columnAge;
    private DataColumn columnCarrierClaimNo;
    private DataColumn columnDriver;
    private DataColumn columnDatePaid;
    private DataColumn columnOriginalLoanDate;
    private DataColumn columnRejectedDate;
    private DataColumn columnRejectedAmount;
    private DataColumn columnComments;
    private DataColumn columnLastClaimUpdated;
    private DataColumn columnBodyPart;
    private DataColumn columnAdjCaseReserves;
    private DataColumn columnCAT_Name_Details;
    private DataColumn columnTotalPaid;
    private DataColumn columnLimit;
    private DataColumn columnWatchList;

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
    public DataColumn ReadOnlyColumn => this.columnReadOnly;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateReceivedColumn => this.columnDateReceived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClaimantColumn => this.columnClaimant;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DeductibleColumn => this.columnDeductible;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CoverageDescriptionColumn => this.columnCoverageDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyColumn => this.columnCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CorresBranchNameColumn => this.columnCorresBranchName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OccurenceColumn => this.columnOccurence;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LOBColumn => this.columnLOB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CountyColumn => this.columnCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LienColumn => this.columnLien;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SubroPotentialColumn => this.columnSubroPotential;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FirstThirdPartyColumn => this.columnFirstThirdParty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FatalityColumn => this.columnFatality;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NCCICodeColumn => this.columnNCCICode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateReopenedColumn => this.columnDateReopened;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InitialContactColumn => this.columnInitialContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FirstInspColumn => this.columnFirstInsp;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FirstReportColumn => this.columnFirstReport;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ReportToCarrierColumn => this.columnReportToCarrier;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AdjusterNameColumn => this.columnAdjusterName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AdjusterTitleColumn => this.columnAdjusterTitle;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AdjusterCategoryColumn => this.columnAdjusterCategory;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IndepAdjusterColumn => this.columnIndepAdjuster;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DefFirmColumn => this.columnDefFirm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClaimantCounselColumn => this.columnClaimantCounsel;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GenderColumn => this.columnGender;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AgeColumn => this.columnAge;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CarrierClaimNoColumn => this.columnCarrierClaimNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DriverColumn => this.columnDriver;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DatePaidColumn => this.columnDatePaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OriginalLoanDateColumn => this.columnOriginalLoanDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RejectedDateColumn => this.columnRejectedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RejectedAmountColumn => this.columnRejectedAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CommentsColumn => this.columnComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LastClaimUpdatedColumn => this.columnLastClaimUpdated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BodyPartColumn => this.columnBodyPart;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AdjCaseReservesColumn => this.columnAdjCaseReserves;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CAT_Name_DetailsColumn => this.columnCAT_Name_Details;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TotalPaidColumn => this.columnTotalPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LimitColumn => this.columnLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn WatchListColumn => this.columnWatchList;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.tblClaimInformationRow this[int index]
    {
      get => (dsClaims.tblClaimInformationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClaims.tblClaimInformationRowChangeEventHandler tblClaimInformationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClaims.tblClaimInformationRowChangeEventHandler tblClaimInformationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClaims.tblClaimInformationRowChangeEventHandler tblClaimInformationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClaims.tblClaimInformationRowChangeEventHandler tblClaimInformationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblClaimInformationRow(dsClaims.tblClaimInformationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.tblClaimInformationRow AddtblClaimInformationRow(
      int ControlNo,
      string ClaimNo,
      DateTime DateReported,
      DateTime LossDate,
      string LossType,
      string Status,
      DateTime DateClosed,
      bool InLitigation,
      string DescriptionInjury,
      string CATNo,
      bool _ReadOnly,
      DateTime DateReceived,
      Decimal LocationID,
      string Claimant,
      string Deductible,
      string CoverageDescription,
      string Company,
      string CorresBranchName,
      string Occurence,
      string LOB,
      string County,
      string Lien,
      string SubroPotential,
      string FirstThirdParty,
      string Fatality,
      string NCCICode,
      DateTime DateReopened,
      string InitialContact,
      DateTime FirstInsp,
      DateTime FirstReport,
      DateTime ReportToCarrier,
      string AdjusterName,
      string AdjusterTitle,
      string AdjusterCategory,
      string IndepAdjuster,
      string DefFirm,
      string ClaimantCounsel,
      string Gender,
      int Age,
      string CarrierClaimNo,
      string Driver,
      DateTime DatePaid,
      DateTime OriginalLoanDate,
      DateTime RejectedDate,
      Decimal RejectedAmount,
      string Comments,
      DateTime LastClaimUpdated,
      string BodyPart,
      Decimal AdjCaseReserves,
      string CAT_Name_Details,
      Decimal TotalPaid,
      Decimal Limit,
      string WatchList)
    {
      dsClaims.tblClaimInformationRow row = (dsClaims.tblClaimInformationRow) this.NewRow();
      object[] objArray = new object[54]
      {
        null,
        (object) ControlNo,
        (object) ClaimNo,
        (object) DateReported,
        (object) LossDate,
        (object) LossType,
        (object) Status,
        (object) DateClosed,
        (object) InLitigation,
        (object) DescriptionInjury,
        (object) CATNo,
        (object) _ReadOnly,
        (object) DateReceived,
        (object) LocationID,
        (object) Claimant,
        (object) Deductible,
        (object) CoverageDescription,
        (object) Company,
        (object) CorresBranchName,
        (object) Occurence,
        (object) LOB,
        (object) County,
        (object) Lien,
        (object) SubroPotential,
        (object) FirstThirdParty,
        (object) Fatality,
        (object) NCCICode,
        (object) DateReopened,
        (object) InitialContact,
        (object) FirstInsp,
        (object) FirstReport,
        (object) ReportToCarrier,
        (object) AdjusterName,
        (object) AdjusterTitle,
        (object) AdjusterCategory,
        (object) IndepAdjuster,
        (object) DefFirm,
        (object) ClaimantCounsel,
        (object) Gender,
        (object) Age,
        (object) CarrierClaimNo,
        (object) Driver,
        (object) DatePaid,
        (object) OriginalLoanDate,
        (object) RejectedDate,
        (object) RejectedAmount,
        (object) Comments,
        (object) LastClaimUpdated,
        (object) BodyPart,
        (object) AdjCaseReserves,
        (object) CAT_Name_Details,
        (object) TotalPaid,
        (object) Limit,
        (object) WatchList
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.tblClaimInformationRow FindByClaimID(int ClaimID)
    {
      return (dsClaims.tblClaimInformationRow) this.Rows.Find(new object[1]
      {
        (object) ClaimID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsClaims.tblClaimInformationDataTable informationDataTable = (dsClaims.tblClaimInformationDataTable) base.Clone();
      informationDataTable.InitVars();
      return (DataTable) informationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaims.tblClaimInformationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnClaimID = this.Columns["ClaimID"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnClaimNo = this.Columns["ClaimNo"];
      this.columnDateReported = this.Columns["DateReported"];
      this.columnLossDate = this.Columns["LossDate"];
      this.columnLossType = this.Columns["LossType"];
      this.columnStatus = this.Columns["Status"];
      this.columnDateClosed = this.Columns["DateClosed"];
      this.columnInLitigation = this.Columns["InLitigation"];
      this.columnDescriptionInjury = this.Columns["DescriptionInjury"];
      this.columnCATNo = this.Columns["CATNo"];
      this.columnReadOnly = this.Columns["ReadOnly"];
      this.columnDateReceived = this.Columns["DateReceived"];
      this.columnLocationID = this.Columns["LocationID"];
      this.columnClaimant = this.Columns["Claimant"];
      this.columnDeductible = this.Columns["Deductible"];
      this.columnCoverageDescription = this.Columns["CoverageDescription"];
      this.columnCompany = this.Columns["Company"];
      this.columnCorresBranchName = this.Columns["CorresBranchName"];
      this.columnOccurence = this.Columns["Occurence"];
      this.columnLOB = this.Columns["LOB"];
      this.columnCounty = this.Columns["County"];
      this.columnLien = this.Columns["Lien"];
      this.columnSubroPotential = this.Columns["SubroPotential"];
      this.columnFirstThirdParty = this.Columns["FirstThirdParty"];
      this.columnFatality = this.Columns["Fatality"];
      this.columnNCCICode = this.Columns["NCCICode"];
      this.columnDateReopened = this.Columns["DateReopened"];
      this.columnInitialContact = this.Columns["InitialContact"];
      this.columnFirstInsp = this.Columns["FirstInsp"];
      this.columnFirstReport = this.Columns["FirstReport"];
      this.columnReportToCarrier = this.Columns["ReportToCarrier"];
      this.columnAdjusterName = this.Columns["AdjusterName"];
      this.columnAdjusterTitle = this.Columns["AdjusterTitle"];
      this.columnAdjusterCategory = this.Columns["AdjusterCategory"];
      this.columnIndepAdjuster = this.Columns["IndepAdjuster"];
      this.columnDefFirm = this.Columns["DefFirm"];
      this.columnClaimantCounsel = this.Columns["ClaimantCounsel"];
      this.columnGender = this.Columns["Gender"];
      this.columnAge = this.Columns["Age"];
      this.columnCarrierClaimNo = this.Columns["CarrierClaimNo"];
      this.columnDriver = this.Columns["Driver"];
      this.columnDatePaid = this.Columns["DatePaid"];
      this.columnOriginalLoanDate = this.Columns["OriginalLoanDate"];
      this.columnRejectedDate = this.Columns["RejectedDate"];
      this.columnRejectedAmount = this.Columns["RejectedAmount"];
      this.columnComments = this.Columns["Comments"];
      this.columnLastClaimUpdated = this.Columns["LastClaimUpdated"];
      this.columnBodyPart = this.Columns["BodyPart"];
      this.columnAdjCaseReserves = this.Columns["AdjCaseReserves"];
      this.columnCAT_Name_Details = this.Columns["CAT_Name_Details"];
      this.columnTotalPaid = this.Columns["TotalPaid"];
      this.columnLimit = this.Columns["Limit"];
      this.columnWatchList = this.Columns["WatchList"];
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
      this.columnReadOnly = new DataColumn("ReadOnly", typeof (bool), (string) null, MappingType.Element);
      this.columnReadOnly.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "ReadOnlyColumn");
      this.columnReadOnly.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnReadOnly");
      this.columnReadOnly.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "ReadOnly");
      this.Columns.Add(this.columnReadOnly);
      this.columnDateReceived = new DataColumn("DateReceived", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateReceived);
      this.columnLocationID = new DataColumn("LocationID", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnClaimant = new DataColumn("Claimant", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimant);
      this.columnDeductible = new DataColumn("Deductible", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductible);
      this.columnCoverageDescription = new DataColumn("CoverageDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageDescription);
      this.columnCompany = new DataColumn("Company", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany);
      this.columnCorresBranchName = new DataColumn("CorresBranchName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCorresBranchName);
      this.columnOccurence = new DataColumn("Occurence", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOccurence);
      this.columnLOB = new DataColumn("LOB", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLOB);
      this.columnCounty = new DataColumn("County", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCounty);
      this.columnLien = new DataColumn("Lien", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLien);
      this.columnSubroPotential = new DataColumn("SubroPotential", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubroPotential);
      this.columnFirstThirdParty = new DataColumn("FirstThirdParty", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirstThirdParty);
      this.columnFatality = new DataColumn("Fatality", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFatality);
      this.columnNCCICode = new DataColumn("NCCICode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNCCICode);
      this.columnDateReopened = new DataColumn("DateReopened", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateReopened);
      this.columnInitialContact = new DataColumn("InitialContact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInitialContact);
      this.columnFirstInsp = new DataColumn("FirstInsp", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirstInsp);
      this.columnFirstReport = new DataColumn("FirstReport", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirstReport);
      this.columnReportToCarrier = new DataColumn("ReportToCarrier", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReportToCarrier);
      this.columnAdjusterName = new DataColumn("AdjusterName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdjusterName);
      this.columnAdjusterTitle = new DataColumn("AdjusterTitle", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdjusterTitle);
      this.columnAdjusterCategory = new DataColumn("AdjusterCategory", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdjusterCategory);
      this.columnIndepAdjuster = new DataColumn("IndepAdjuster", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIndepAdjuster);
      this.columnDefFirm = new DataColumn("DefFirm", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefFirm);
      this.columnClaimantCounsel = new DataColumn("ClaimantCounsel", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimantCounsel);
      this.columnGender = new DataColumn("Gender", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGender);
      this.columnAge = new DataColumn("Age", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAge);
      this.columnCarrierClaimNo = new DataColumn("CarrierClaimNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCarrierClaimNo);
      this.columnDriver = new DataColumn("Driver", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDriver);
      this.columnDatePaid = new DataColumn("DatePaid", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDatePaid);
      this.columnOriginalLoanDate = new DataColumn("OriginalLoanDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOriginalLoanDate);
      this.columnRejectedDate = new DataColumn("RejectedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRejectedDate);
      this.columnRejectedAmount = new DataColumn("RejectedAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRejectedAmount);
      this.columnComments = new DataColumn("Comments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComments);
      this.columnLastClaimUpdated = new DataColumn("LastClaimUpdated", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLastClaimUpdated);
      this.columnBodyPart = new DataColumn("BodyPart", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBodyPart);
      this.columnAdjCaseReserves = new DataColumn("AdjCaseReserves", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdjCaseReserves);
      this.columnCAT_Name_Details = new DataColumn("CAT_Name_Details", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCAT_Name_Details);
      this.columnTotalPaid = new DataColumn("TotalPaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalPaid);
      this.columnLimit = new DataColumn("Limit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLimit);
      this.columnWatchList = new DataColumn("WatchList", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWatchList);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnClaimID
      }, true));
      this.columnClaimID.AutoIncrement = true;
      this.columnClaimID.AutoIncrementSeed = -1L;
      this.columnClaimID.AutoIncrementStep = -1L;
      this.columnClaimID.AllowDBNull = false;
      this.columnClaimID.ReadOnly = true;
      this.columnClaimID.Unique = true;
      this.columnControlNo.AllowDBNull = false;
      this.columnInLitigation.AllowDBNull = false;
      this.columnInLitigation.DefaultValue = (object) false;
      this.columnReadOnly.AllowDBNull = false;
      this.columnReadOnly.DefaultValue = (object) false;
      this.columnOccurence.DefaultValue = (object) "False";
      this.columnComments.MaxLength = 500;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.tblClaimInformationRow NewtblClaimInformationRow()
    {
      return (dsClaims.tblClaimInformationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaims.tblClaimInformationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsClaims.tblClaimInformationRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClaimInformationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsClaims.tblClaimInformationRowChangeEventHandler informationRowChangedEvent = this.tblClaimInformationRowChangedEvent;
      if (informationRowChangedEvent == null)
        return;
      informationRowChangedEvent((object) this, new dsClaims.tblClaimInformationRowChangeEvent((dsClaims.tblClaimInformationRow) e.Row, e.Action));
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
      dsClaims.tblClaimInformationRowChangeEventHandler rowChangingEvent = this.tblClaimInformationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsClaims.tblClaimInformationRowChangeEvent((dsClaims.tblClaimInformationRow) e.Row, e.Action));
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
      dsClaims.tblClaimInformationRowChangeEventHandler informationRowDeletedEvent = this.tblClaimInformationRowDeletedEvent;
      if (informationRowDeletedEvent == null)
        return;
      informationRowDeletedEvent((object) this, new dsClaims.tblClaimInformationRowChangeEvent((dsClaims.tblClaimInformationRow) e.Row, e.Action));
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
      dsClaims.tblClaimInformationRowChangeEventHandler rowDeletingEvent = this.tblClaimInformationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsClaims.tblClaimInformationRowChangeEvent((dsClaims.tblClaimInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblClaimInformationRow(dsClaims.tblClaimInformationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaims dsClaims = new dsClaims();
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
        FixedValue = dsClaims.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClaimInformationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsClaims.GetSchemaSerializable();
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
    TypedTableBase<dsClaims.tblClaimResPaymentActivityRow>
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
    private DataColumn columnCheckIssued;
    private DataColumn columnRecType;
    private DataColumn columnOutMedRes;
    private DataColumn columnMedicalPTD;
    private DataColumn columnValueDate;
    private DataColumn columnTotalReserve;
    private DataColumn columnRespayTotalPaid;
    private DataColumn columnTotalRecovery;
    private DataColumn columnTPAReserve;
    private DataColumn columnBIPaid;
    private DataColumn columnBIReserve;
    private DataColumn columnPDPaid;
    private DataColumn columnPDReserve;
    private DataColumn columnGrossLoss;
    private DataColumn columnExpensePaid;
    private DataColumn columnExpenseReserved;
    private DataColumn columnDetailDescription;
    private DataColumn columnLossStreet;
    private DataColumn columnLossCity;
    private DataColumn columnLossState;
    private DataColumn columnLossZip;
    private DataColumn columnLongitude;
    private DataColumn columnLatitude;
    private DataColumn columnIso_Code;
    private DataColumn columnAtc_Code;
    private DataColumn columnHail_Code;
    private DataColumn columnPc_Code;
    private DataColumn columnOccupancy;
    private DataColumn columnSubsidized;
    private DataColumn columnStudent_Senior;
    private DataColumn columnTotal_SqFt;
    private DataColumn columnPrice_Per_Sqft;
    private DataColumn columnTotal_BV;
    private DataColumn columnTotal_BBP;
    private DataColumn columnTotal_BI;
    private DataColumn columnTotal_TIV;
    private DataColumn columnProgram_Deductible_Applied;
    private DataColumn columnProgram_AOP;
    private DataColumn columnProgram_WindHail;
    private DataColumn columnProgram_NS;
    private DataColumn columnProgram_Notes;
    private DataColumn columnDateCreated;
    private DataColumn columnBusIntReserve;
    private DataColumn columnContingentBIReserve;
    private DataColumn columnBusIntPaid;
    private DataColumn columnContingentBIPaid;

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
    public DataColumn CheckIssuedColumn => this.columnCheckIssued;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RecTypeColumn => this.columnRecType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OutMedResColumn => this.columnOutMedRes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MedicalPTDColumn => this.columnMedicalPTD;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ValueDateColumn => this.columnValueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TotalReserveColumn => this.columnTotalReserve;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn RespayTotalPaidColumn => this.columnRespayTotalPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TotalRecoveryColumn => this.columnTotalRecovery;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn TPAReserveColumn => this.columnTPAReserve;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BIPaidColumn => this.columnBIPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BIReserveColumn => this.columnBIReserve;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PDPaidColumn => this.columnPDPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PDReserveColumn => this.columnPDReserve;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn GrossLossColumn => this.columnGrossLoss;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExpensePaidColumn => this.columnExpensePaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExpenseReservedColumn => this.columnExpenseReserved;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DetailDescriptionColumn => this.columnDetailDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LossStreetColumn => this.columnLossStreet;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LossCityColumn => this.columnLossCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LossStateColumn => this.columnLossState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LossZipColumn => this.columnLossZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LongitudeColumn => this.columnLongitude;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LatitudeColumn => this.columnLatitude;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Iso_CodeColumn => this.columnIso_Code;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Atc_CodeColumn => this.columnAtc_Code;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Hail_CodeColumn => this.columnHail_Code;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Pc_CodeColumn => this.columnPc_Code;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OccupancyColumn => this.columnOccupancy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SubsidizedColumn => this.columnSubsidized;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Student_SeniorColumn => this.columnStudent_Senior;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Total_SqFtColumn => this.columnTotal_SqFt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Price_Per_SqftColumn => this.columnPrice_Per_Sqft;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Total_BVColumn => this.columnTotal_BV;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Total_BBPColumn => this.columnTotal_BBP;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Total_BIColumn => this.columnTotal_BI;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Total_TIVColumn => this.columnTotal_TIV;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Program_Deductible_AppliedColumn => this.columnProgram_Deductible_Applied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Program_AOPColumn => this.columnProgram_AOP;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Program_WindHailColumn => this.columnProgram_WindHail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Program_NSColumn => this.columnProgram_NS;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Program_NotesColumn => this.columnProgram_Notes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateCreatedColumn => this.columnDateCreated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BusIntReserveColumn => this.columnBusIntReserve;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ContingentBIReserveColumn => this.columnContingentBIReserve;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BusIntPaidColumn => this.columnBusIntPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ContingentBIPaidColumn => this.columnContingentBIPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.tblClaimResPaymentActivityRow this[int index]
    {
      get => (dsClaims.tblClaimResPaymentActivityRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClaims.tblClaimResPaymentActivityRowChangeEventHandler tblClaimResPaymentActivityRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClaims.tblClaimResPaymentActivityRowChangeEventHandler tblClaimResPaymentActivityRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClaims.tblClaimResPaymentActivityRowChangeEventHandler tblClaimResPaymentActivityRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClaims.tblClaimResPaymentActivityRowChangeEventHandler tblClaimResPaymentActivityRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblClaimResPaymentActivityRow(dsClaims.tblClaimResPaymentActivityRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.tblClaimResPaymentActivityRow AddtblClaimResPaymentActivityRow(
      dsClaims.tblClaimInformationRow parenttblClaimInformationRowBytblClaimInformationtblClaimResPaymentActivity,
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
      DateTime CheckIssued,
      string RecType,
      Decimal OutMedRes,
      Decimal MedicalPTD,
      DateTime ValueDate,
      Decimal TotalReserve,
      Decimal RespayTotalPaid,
      Decimal TotalRecovery,
      Decimal TPAReserve,
      Decimal BIPaid,
      Decimal BIReserve,
      Decimal PDPaid,
      Decimal PDReserve,
      Decimal GrossLoss,
      Decimal ExpensePaid,
      Decimal ExpenseReserved,
      string DetailDescription,
      string LossStreet,
      string LossCity,
      string LossState,
      string LossZip,
      string Longitude,
      string Latitude,
      int Iso_Code,
      int Atc_Code,
      int Hail_Code,
      int Pc_Code,
      Decimal Occupancy,
      Decimal Subsidized,
      Decimal Student_Senior,
      int Total_SqFt,
      Decimal Price_Per_Sqft,
      Decimal Total_BV,
      Decimal Total_BBP,
      Decimal Total_BI,
      Decimal Total_TIV,
      Decimal Program_Deductible_Applied,
      Decimal Program_AOP,
      Decimal Program_WindHail,
      Decimal Program_NS,
      string Program_Notes,
      DateTime DateCreated,
      Decimal BusIntReserve,
      Decimal ContingentBIReserve,
      Decimal BusIntPaid,
      Decimal ContingentBIPaid)
    {
      dsClaims.tblClaimResPaymentActivityRow row = (dsClaims.tblClaimResPaymentActivityRow) this.NewRow();
      object[] objArray = new object[64 /*0x40*/]
      {
        null,
        null,
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
        (object) CheckIssued,
        (object) RecType,
        (object) OutMedRes,
        (object) MedicalPTD,
        (object) ValueDate,
        (object) TotalReserve,
        (object) RespayTotalPaid,
        (object) TotalRecovery,
        (object) TPAReserve,
        (object) BIPaid,
        (object) BIReserve,
        (object) PDPaid,
        (object) PDReserve,
        (object) GrossLoss,
        (object) ExpensePaid,
        (object) ExpenseReserved,
        (object) DetailDescription,
        (object) LossStreet,
        (object) LossCity,
        (object) LossState,
        (object) LossZip,
        (object) Longitude,
        (object) Latitude,
        (object) Iso_Code,
        (object) Atc_Code,
        (object) Hail_Code,
        (object) Pc_Code,
        (object) Occupancy,
        (object) Subsidized,
        (object) Student_Senior,
        (object) Total_SqFt,
        (object) Price_Per_Sqft,
        (object) Total_BV,
        (object) Total_BBP,
        (object) Total_BI,
        (object) Total_TIV,
        (object) Program_Deductible_Applied,
        (object) Program_AOP,
        (object) Program_WindHail,
        (object) Program_NS,
        (object) Program_Notes,
        (object) DateCreated,
        (object) BusIntReserve,
        (object) ContingentBIReserve,
        (object) BusIntPaid,
        (object) ContingentBIPaid
      };
      if (parenttblClaimInformationRowBytblClaimInformationtblClaimResPaymentActivity != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblClaimInformationRowBytblClaimInformationtblClaimResPaymentActivity[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.tblClaimResPaymentActivityRow FindByPaymentID(int PaymentID)
    {
      return (dsClaims.tblClaimResPaymentActivityRow) this.Rows.Find(new object[1]
      {
        (object) PaymentID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsClaims.tblClaimResPaymentActivityDataTable activityDataTable = (dsClaims.tblClaimResPaymentActivityDataTable) base.Clone();
      activityDataTable.InitVars();
      return (DataTable) activityDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaims.tblClaimResPaymentActivityDataTable();
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
      this.columnCheckIssued = this.Columns["CheckIssued"];
      this.columnRecType = this.Columns["RecType"];
      this.columnOutMedRes = this.Columns["OutMedRes"];
      this.columnMedicalPTD = this.Columns["MedicalPTD"];
      this.columnValueDate = this.Columns["ValueDate"];
      this.columnTotalReserve = this.Columns["TotalReserve"];
      this.columnRespayTotalPaid = this.Columns["RespayTotalPaid"];
      this.columnTotalRecovery = this.Columns["TotalRecovery"];
      this.columnTPAReserve = this.Columns["TPAReserve"];
      this.columnBIPaid = this.Columns["BIPaid"];
      this.columnBIReserve = this.Columns["BIReserve"];
      this.columnPDPaid = this.Columns["PDPaid"];
      this.columnPDReserve = this.Columns["PDReserve"];
      this.columnGrossLoss = this.Columns["GrossLoss"];
      this.columnExpensePaid = this.Columns["ExpensePaid"];
      this.columnExpenseReserved = this.Columns["ExpenseReserved"];
      this.columnDetailDescription = this.Columns["DetailDescription"];
      this.columnLossStreet = this.Columns["LossStreet"];
      this.columnLossCity = this.Columns["LossCity"];
      this.columnLossState = this.Columns["LossState"];
      this.columnLossZip = this.Columns["LossZip"];
      this.columnLongitude = this.Columns["Longitude"];
      this.columnLatitude = this.Columns["Latitude"];
      this.columnIso_Code = this.Columns["Iso_Code"];
      this.columnAtc_Code = this.Columns["Atc_Code"];
      this.columnHail_Code = this.Columns["Hail_Code"];
      this.columnPc_Code = this.Columns["Pc_Code"];
      this.columnOccupancy = this.Columns["Occupancy"];
      this.columnSubsidized = this.Columns["Subsidized"];
      this.columnStudent_Senior = this.Columns["Student_Senior"];
      this.columnTotal_SqFt = this.Columns["Total_SqFt"];
      this.columnPrice_Per_Sqft = this.Columns["Price_Per_Sqft"];
      this.columnTotal_BV = this.Columns["Total_BV"];
      this.columnTotal_BBP = this.Columns["Total_BBP"];
      this.columnTotal_BI = this.Columns["Total_BI"];
      this.columnTotal_TIV = this.Columns["Total_TIV"];
      this.columnProgram_Deductible_Applied = this.Columns["Program_Deductible_Applied"];
      this.columnProgram_AOP = this.Columns["Program_AOP"];
      this.columnProgram_WindHail = this.Columns["Program_WindHail"];
      this.columnProgram_NS = this.Columns["Program_NS"];
      this.columnProgram_Notes = this.Columns["Program_Notes"];
      this.columnDateCreated = this.Columns["DateCreated"];
      this.columnBusIntReserve = this.Columns["BusIntReserve"];
      this.columnContingentBIReserve = this.Columns["ContingentBIReserve"];
      this.columnBusIntPaid = this.Columns["BusIntPaid"];
      this.columnContingentBIPaid = this.Columns["ContingentBIPaid"];
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
      this.columnCheckIssued = new DataColumn("CheckIssued", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheckIssued);
      this.columnRecType = new DataColumn("RecType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecType);
      this.columnOutMedRes = new DataColumn("OutMedRes", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOutMedRes);
      this.columnMedicalPTD = new DataColumn("MedicalPTD", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMedicalPTD);
      this.columnValueDate = new DataColumn("ValueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnValueDate);
      this.columnTotalReserve = new DataColumn("TotalReserve", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalReserve);
      this.columnRespayTotalPaid = new DataColumn("RespayTotalPaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRespayTotalPaid);
      this.columnTotalRecovery = new DataColumn("TotalRecovery", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalRecovery);
      this.columnTPAReserve = new DataColumn("TPAReserve", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTPAReserve);
      this.columnBIPaid = new DataColumn("BIPaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBIPaid);
      this.columnBIReserve = new DataColumn("BIReserve", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBIReserve);
      this.columnPDPaid = new DataColumn("PDPaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPDPaid);
      this.columnPDReserve = new DataColumn("PDReserve", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPDReserve);
      this.columnGrossLoss = new DataColumn("GrossLoss", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGrossLoss);
      this.columnExpensePaid = new DataColumn("ExpensePaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpensePaid);
      this.columnExpenseReserved = new DataColumn("ExpenseReserved", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpenseReserved);
      this.columnDetailDescription = new DataColumn("DetailDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDetailDescription);
      this.columnLossStreet = new DataColumn("LossStreet", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLossStreet);
      this.columnLossCity = new DataColumn("LossCity", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLossCity);
      this.columnLossState = new DataColumn("LossState", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLossState);
      this.columnLossZip = new DataColumn("LossZip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLossZip);
      this.columnLongitude = new DataColumn("Longitude", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLongitude);
      this.columnLatitude = new DataColumn("Latitude", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLatitude);
      this.columnIso_Code = new DataColumn("Iso_Code", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIso_Code);
      this.columnAtc_Code = new DataColumn("Atc_Code", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAtc_Code);
      this.columnHail_Code = new DataColumn("Hail_Code", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHail_Code);
      this.columnPc_Code = new DataColumn("Pc_Code", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPc_Code);
      this.columnOccupancy = new DataColumn("Occupancy", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOccupancy);
      this.columnSubsidized = new DataColumn("Subsidized", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubsidized);
      this.columnStudent_Senior = new DataColumn("Student_Senior", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStudent_Senior);
      this.columnTotal_SqFt = new DataColumn("Total_SqFt", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotal_SqFt);
      this.columnPrice_Per_Sqft = new DataColumn("Price_Per_Sqft", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPrice_Per_Sqft);
      this.columnTotal_BV = new DataColumn("Total_BV", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotal_BV);
      this.columnTotal_BBP = new DataColumn("Total_BBP", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotal_BBP);
      this.columnTotal_BI = new DataColumn("Total_BI", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotal_BI);
      this.columnTotal_TIV = new DataColumn("Total_TIV", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotal_TIV);
      this.columnProgram_Deductible_Applied = new DataColumn("Program_Deductible_Applied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgram_Deductible_Applied);
      this.columnProgram_AOP = new DataColumn("Program_AOP", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgram_AOP);
      this.columnProgram_WindHail = new DataColumn("Program_WindHail", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgram_WindHail);
      this.columnProgram_NS = new DataColumn("Program_NS", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgram_NS);
      this.columnProgram_Notes = new DataColumn("Program_Notes", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgram_Notes);
      this.columnDateCreated = new DataColumn("DateCreated", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateCreated);
      this.columnBusIntReserve = new DataColumn("BusIntReserve", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBusIntReserve);
      this.columnContingentBIReserve = new DataColumn("ContingentBIReserve", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContingentBIReserve);
      this.columnBusIntPaid = new DataColumn("BusIntPaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBusIntPaid);
      this.columnContingentBIPaid = new DataColumn("ContingentBIPaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContingentBIPaid);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsClaimsKey1", new DataColumn[1]
      {
        this.columnPaymentID
      }, true));
      this.columnPaymentID.AutoIncrement = true;
      this.columnPaymentID.AllowDBNull = false;
      this.columnPaymentID.ReadOnly = true;
      this.columnPaymentID.Unique = true;
      this.columnClaimID.AllowDBNull = false;
      this.columnOutIndRes.AllowDBNull = false;
      this.columnOutIndRes.DefaultValue = (object) 0M;
      this.columnOutLAERes.AllowDBNull = false;
      this.columnOutLAERes.DefaultValue = (object) 0M;
      this.columnOutLegalRes.AllowDBNull = false;
      this.columnOutLegalRes.DefaultValue = (object) 0M;
      this.columnDedRecovery.AllowDBNull = false;
      this.columnDedRecovery.DefaultValue = (object) 0M;
      this.columnSubrogation.AllowDBNull = false;
      this.columnSubrogation.DefaultValue = (object) 0M;
      this.columnSalvage.AllowDBNull = false;
      this.columnSalvage.DefaultValue = (object) 0M;
      this.columnOtherRecovery.AllowDBNull = false;
      this.columnOtherRecovery.DefaultValue = (object) 0M;
      this.columnMTDIndemnityPaid.AllowDBNull = false;
      this.columnMTDIndemnityPaid.DefaultValue = (object) 0M;
      this.columnIndemnityPTD.AllowDBNull = false;
      this.columnIndemnityPTD.DefaultValue = (object) 0M;
      this.columnMTDLAEPaid.AllowDBNull = false;
      this.columnMTDLAEPaid.DefaultValue = (object) 0M;
      this.columnLAEPTD.AllowDBNull = false;
      this.columnLAEPTD.DefaultValue = (object) 0M;
      this.columnMTDLegalPaid.AllowDBNull = false;
      this.columnMTDLegalPaid.DefaultValue = (object) 0M;
      this.columnLegalPTD.AllowDBNull = false;
      this.columnLegalPTD.DefaultValue = (object) 0M;
      this.columnMTDTPAExpPaid.AllowDBNull = false;
      this.columnMTDTPAExpPaid.DefaultValue = (object) 0M;
      this.columnTPAExpPTD.AllowDBNull = false;
      this.columnTPAExpPTD.DefaultValue = (object) 0M;
      this.columnTotalIncurred.AllowDBNull = false;
      this.columnTotalIncurred.DefaultValue = (object) 0M;
      this.columnOutMedRes.DefaultValue = (object) 0M;
      this.columnMedicalPTD.DefaultValue = (object) 0M;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.tblClaimResPaymentActivityRow NewtblClaimResPaymentActivityRow()
    {
      return (dsClaims.tblClaimResPaymentActivityRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaims.tblClaimResPaymentActivityRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsClaims.tblClaimResPaymentActivityRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClaimResPaymentActivityRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsClaims.tblClaimResPaymentActivityRowChangeEventHandler activityRowChangedEvent = this.tblClaimResPaymentActivityRowChangedEvent;
      if (activityRowChangedEvent == null)
        return;
      activityRowChangedEvent((object) this, new dsClaims.tblClaimResPaymentActivityRowChangeEvent((dsClaims.tblClaimResPaymentActivityRow) e.Row, e.Action));
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
      dsClaims.tblClaimResPaymentActivityRowChangeEventHandler rowChangingEvent = this.tblClaimResPaymentActivityRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsClaims.tblClaimResPaymentActivityRowChangeEvent((dsClaims.tblClaimResPaymentActivityRow) e.Row, e.Action));
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
      dsClaims.tblClaimResPaymentActivityRowChangeEventHandler activityRowDeletedEvent = this.tblClaimResPaymentActivityRowDeletedEvent;
      if (activityRowDeletedEvent == null)
        return;
      activityRowDeletedEvent((object) this, new dsClaims.tblClaimResPaymentActivityRowChangeEvent((dsClaims.tblClaimResPaymentActivityRow) e.Row, e.Action));
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
      dsClaims.tblClaimResPaymentActivityRowChangeEventHandler rowDeletingEvent = this.tblClaimResPaymentActivityRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsClaims.tblClaimResPaymentActivityRowChangeEvent((dsClaims.tblClaimResPaymentActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblClaimResPaymentActivityRow(dsClaims.tblClaimResPaymentActivityRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaims dsClaims = new dsClaims();
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
        FixedValue = dsClaims.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClaimResPaymentActivityDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsClaims.GetSchemaSerializable();
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
  public class lstStatesDataTable : TypedTableBase<dsClaims.lstStatesRow>
  {
    private DataColumn columnState;
    private DataColumn columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstStatesDataTable()
    {
      this.TableName = "lstStates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstStatesDataTable(DataTable table)
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
    protected lstStatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.lstStatesRow this[int index] => (dsClaims.lstStatesRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClaims.lstStatesRowChangeEventHandler lstStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClaims.lstStatesRowChangeEventHandler lstStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClaims.lstStatesRowChangeEventHandler lstStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsClaims.lstStatesRowChangeEventHandler lstStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstStatesRow(dsClaims.lstStatesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.lstStatesRow AddlstStatesRow(string State, string StateID)
    {
      dsClaims.lstStatesRow row = (dsClaims.lstStatesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) State,
        (object) StateID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.lstStatesRow FindByStateID(string StateID)
    {
      return (dsClaims.lstStatesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsClaims.lstStatesDataTable lstStatesDataTable = (dsClaims.lstStatesDataTable) base.Clone();
      lstStatesDataTable.InitVars();
      return (DataTable) lstStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsClaims.lstStatesDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnState = this.Columns["State"];
      this.columnStateID = this.Columns["StateID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteEditKey8", new DataColumn[1]
      {
        this.columnStateID
      }, true));
      this.columnState.AllowDBNull = false;
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.lstStatesRow NewlstStatesRow() => (dsClaims.lstStatesRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaims.lstStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsClaims.lstStatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsClaims.lstStatesRowChangeEventHandler statesRowChangedEvent = this.lstStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsClaims.lstStatesRowChangeEvent((dsClaims.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsClaims.lstStatesRowChangeEventHandler rowChangingEvent = this.lstStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsClaims.lstStatesRowChangeEvent((dsClaims.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsClaims.lstStatesRowChangeEventHandler statesRowDeletedEvent = this.lstStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsClaims.lstStatesRowChangeEvent((dsClaims.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsClaims.lstStatesRowChangeEventHandler rowDeletingEvent = this.lstStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsClaims.lstStatesRowChangeEvent((dsClaims.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstStatesRow(dsClaims.lstStatesRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaims dsClaims = new dsClaims();
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
        FixedValue = dsClaims.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsClaims.GetSchemaSerializable();
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

  public class tblClaimInformationRow : DataRow
  {
    private dsClaims.tblClaimInformationDataTable tabletblClaimInformation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblClaimInformationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClaimInformation = (dsClaims.tblClaimInformationDataTable) this.Table;
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
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.ClaimNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClaimNo' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.ClaimNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateReported
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimInformation.DateReportedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateReported' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.DateReportedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime LossDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimInformation.LossDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LossDate' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.LossDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LossType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.LossTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LossType' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.LossTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Status
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.StatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Status' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
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
    public bool _ReadOnly
    {
      get => Conversions.ToBoolean(this[this.tabletblClaimInformation.ReadOnlyColumn]);
      set => this[this.tabletblClaimInformation.ReadOnlyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateReceived
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimInformation.DateReceivedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateReceived' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.DateReceivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal LocationID
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimInformation.LocationIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationID' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Claimant
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.ClaimantColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Claimant' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.ClaimantColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Deductible
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.DeductibleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Deductible' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.DeductibleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CoverageDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.CoverageDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CoverageDescription' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.CoverageDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Company
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.CompanyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Company' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.CompanyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CorresBranchName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.CorresBranchNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CorresBranchName' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.CorresBranchNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Occurence
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.OccurenceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Occurence' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.OccurenceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LOB
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.LOBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LOB' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.LOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string County
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.CountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'County' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.CountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Lien
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.LienColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Lien' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.LienColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SubroPotential
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.SubroPotentialColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SubroPotential' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.SubroPotentialColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FirstThirdParty
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.FirstThirdPartyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FirstThirdParty' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.FirstThirdPartyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Fatality
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.FatalityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fatality' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.FatalityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NCCICode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.NCCICodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NCCICode' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.NCCICodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateReopened
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimInformation.DateReopenedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateReopened' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.DateReopenedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InitialContact
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.InitialContactColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InitialContact' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.InitialContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime FirstInsp
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimInformation.FirstInspColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FirstInsp' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.FirstInspColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime FirstReport
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimInformation.FirstReportColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FirstReport' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.FirstReportColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime ReportToCarrier
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimInformation.ReportToCarrierColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ReportToCarrier' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.ReportToCarrierColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AdjusterName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.AdjusterNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdjusterName' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.AdjusterNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AdjusterTitle
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.AdjusterTitleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdjusterTitle' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.AdjusterTitleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AdjusterCategory
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.AdjusterCategoryColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdjusterCategory' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.AdjusterCategoryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string IndepAdjuster
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.IndepAdjusterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IndepAdjuster' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.IndepAdjusterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string DefFirm
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.DefFirmColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DefFirm' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.DefFirmColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ClaimantCounsel
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.ClaimantCounselColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClaimantCounsel' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.ClaimantCounselColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Gender
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.GenderColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Gender' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.GenderColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Age
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblClaimInformation.AgeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Age' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.AgeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CarrierClaimNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.CarrierClaimNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CarrierClaimNo' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.CarrierClaimNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Driver
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.DriverColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Driver' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.DriverColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DatePaid
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimInformation.DatePaidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DatePaid' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.DatePaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime OriginalLoanDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimInformation.OriginalLoanDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OriginalLoanDate' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.OriginalLoanDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime RejectedDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimInformation.RejectedDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RejectedDate' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.RejectedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal RejectedAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimInformation.RejectedAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RejectedAmount' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.RejectedAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Comments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.CommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Comments' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.CommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime LastClaimUpdated
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimInformation.LastClaimUpdatedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LastClaimUpdated' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.LastClaimUpdatedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string BodyPart
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.BodyPartColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BodyPart' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.BodyPartColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal AdjCaseReserves
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimInformation.AdjCaseReservesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdjCaseReserves' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.AdjCaseReservesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string CAT_Name_Details
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.CAT_Name_DetailsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CAT_Name_Details' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.CAT_Name_DetailsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal TotalPaid
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimInformation.TotalPaidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TotalPaid' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.TotalPaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Limit
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimInformation.LimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Limit' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.LimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string WatchList
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimInformation.WatchListColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WatchList' in table 'tblClaimInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimInformation.WatchListColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClaimNoNull() => this.IsNull(this.tabletblClaimInformation.ClaimNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClaimNoNull()
    {
      this[this.tabletblClaimInformation.ClaimNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDateReportedNull()
    {
      return this.IsNull(this.tabletblClaimInformation.DateReportedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDateReportedNull()
    {
      this[this.tabletblClaimInformation.DateReportedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLossDateNull() => this.IsNull(this.tabletblClaimInformation.LossDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLossDateNull()
    {
      this[this.tabletblClaimInformation.LossDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLossTypeNull() => this.IsNull(this.tabletblClaimInformation.LossTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLossTypeNull()
    {
      this[this.tabletblClaimInformation.LossTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStatusNull() => this.IsNull(this.tabletblClaimInformation.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStatusNull()
    {
      this[this.tabletblClaimInformation.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
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
    public bool IsDateReceivedNull()
    {
      return this.IsNull(this.tabletblClaimInformation.DateReceivedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDateReceivedNull()
    {
      this[this.tabletblClaimInformation.DateReceivedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLocationIDNull() => this.IsNull(this.tabletblClaimInformation.LocationIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLocationIDNull()
    {
      this[this.tabletblClaimInformation.LocationIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClaimantNull() => this.IsNull(this.tabletblClaimInformation.ClaimantColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClaimantNull()
    {
      this[this.tabletblClaimInformation.ClaimantColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDeductibleNull() => this.IsNull(this.tabletblClaimInformation.DeductibleColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDeductibleNull()
    {
      this[this.tabletblClaimInformation.DeductibleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCoverageDescriptionNull()
    {
      return this.IsNull(this.tabletblClaimInformation.CoverageDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCoverageDescriptionNull()
    {
      this[this.tabletblClaimInformation.CoverageDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompanyNull() => this.IsNull(this.tabletblClaimInformation.CompanyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompanyNull()
    {
      this[this.tabletblClaimInformation.CompanyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCorresBranchNameNull()
    {
      return this.IsNull(this.tabletblClaimInformation.CorresBranchNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCorresBranchNameNull()
    {
      this[this.tabletblClaimInformation.CorresBranchNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOccurenceNull() => this.IsNull(this.tabletblClaimInformation.OccurenceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOccurenceNull()
    {
      this[this.tabletblClaimInformation.OccurenceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLOBNull() => this.IsNull(this.tabletblClaimInformation.LOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLOBNull()
    {
      this[this.tabletblClaimInformation.LOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCountyNull() => this.IsNull(this.tabletblClaimInformation.CountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCountyNull()
    {
      this[this.tabletblClaimInformation.CountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLienNull() => this.IsNull(this.tabletblClaimInformation.LienColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLienNull()
    {
      this[this.tabletblClaimInformation.LienColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSubroPotentialNull()
    {
      return this.IsNull(this.tabletblClaimInformation.SubroPotentialColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSubroPotentialNull()
    {
      this[this.tabletblClaimInformation.SubroPotentialColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFirstThirdPartyNull()
    {
      return this.IsNull(this.tabletblClaimInformation.FirstThirdPartyColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFirstThirdPartyNull()
    {
      this[this.tabletblClaimInformation.FirstThirdPartyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFatalityNull() => this.IsNull(this.tabletblClaimInformation.FatalityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFatalityNull()
    {
      this[this.tabletblClaimInformation.FatalityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNCCICodeNull() => this.IsNull(this.tabletblClaimInformation.NCCICodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNCCICodeNull()
    {
      this[this.tabletblClaimInformation.NCCICodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDateReopenedNull()
    {
      return this.IsNull(this.tabletblClaimInformation.DateReopenedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDateReopenedNull()
    {
      this[this.tabletblClaimInformation.DateReopenedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInitialContactNull()
    {
      return this.IsNull(this.tabletblClaimInformation.InitialContactColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInitialContactNull()
    {
      this[this.tabletblClaimInformation.InitialContactColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFirstInspNull() => this.IsNull(this.tabletblClaimInformation.FirstInspColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFirstInspNull()
    {
      this[this.tabletblClaimInformation.FirstInspColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFirstReportNull() => this.IsNull(this.tabletblClaimInformation.FirstReportColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFirstReportNull()
    {
      this[this.tabletblClaimInformation.FirstReportColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsReportToCarrierNull()
    {
      return this.IsNull(this.tabletblClaimInformation.ReportToCarrierColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetReportToCarrierNull()
    {
      this[this.tabletblClaimInformation.ReportToCarrierColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAdjusterNameNull()
    {
      return this.IsNull(this.tabletblClaimInformation.AdjusterNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAdjusterNameNull()
    {
      this[this.tabletblClaimInformation.AdjusterNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAdjusterTitleNull()
    {
      return this.IsNull(this.tabletblClaimInformation.AdjusterTitleColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAdjusterTitleNull()
    {
      this[this.tabletblClaimInformation.AdjusterTitleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAdjusterCategoryNull()
    {
      return this.IsNull(this.tabletblClaimInformation.AdjusterCategoryColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAdjusterCategoryNull()
    {
      this[this.tabletblClaimInformation.AdjusterCategoryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsIndepAdjusterNull()
    {
      return this.IsNull(this.tabletblClaimInformation.IndepAdjusterColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetIndepAdjusterNull()
    {
      this[this.tabletblClaimInformation.IndepAdjusterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDefFirmNull() => this.IsNull(this.tabletblClaimInformation.DefFirmColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDefFirmNull()
    {
      this[this.tabletblClaimInformation.DefFirmColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClaimantCounselNull()
    {
      return this.IsNull(this.tabletblClaimInformation.ClaimantCounselColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClaimantCounselNull()
    {
      this[this.tabletblClaimInformation.ClaimantCounselColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGenderNull() => this.IsNull(this.tabletblClaimInformation.GenderColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGenderNull()
    {
      this[this.tabletblClaimInformation.GenderColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAgeNull() => this.IsNull(this.tabletblClaimInformation.AgeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAgeNull()
    {
      this[this.tabletblClaimInformation.AgeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCarrierClaimNoNull()
    {
      return this.IsNull(this.tabletblClaimInformation.CarrierClaimNoColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCarrierClaimNoNull()
    {
      this[this.tabletblClaimInformation.CarrierClaimNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDriverNull() => this.IsNull(this.tabletblClaimInformation.DriverColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDriverNull()
    {
      this[this.tabletblClaimInformation.DriverColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDatePaidNull() => this.IsNull(this.tabletblClaimInformation.DatePaidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDatePaidNull()
    {
      this[this.tabletblClaimInformation.DatePaidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOriginalLoanDateNull()
    {
      return this.IsNull(this.tabletblClaimInformation.OriginalLoanDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOriginalLoanDateNull()
    {
      this[this.tabletblClaimInformation.OriginalLoanDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRejectedDateNull()
    {
      return this.IsNull(this.tabletblClaimInformation.RejectedDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRejectedDateNull()
    {
      this[this.tabletblClaimInformation.RejectedDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRejectedAmountNull()
    {
      return this.IsNull(this.tabletblClaimInformation.RejectedAmountColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRejectedAmountNull()
    {
      this[this.tabletblClaimInformation.RejectedAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCommentsNull() => this.IsNull(this.tabletblClaimInformation.CommentsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCommentsNull()
    {
      this[this.tabletblClaimInformation.CommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLastClaimUpdatedNull()
    {
      return this.IsNull(this.tabletblClaimInformation.LastClaimUpdatedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLastClaimUpdatedNull()
    {
      this[this.tabletblClaimInformation.LastClaimUpdatedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBodyPartNull() => this.IsNull(this.tabletblClaimInformation.BodyPartColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBodyPartNull()
    {
      this[this.tabletblClaimInformation.BodyPartColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAdjCaseReservesNull()
    {
      return this.IsNull(this.tabletblClaimInformation.AdjCaseReservesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAdjCaseReservesNull()
    {
      this[this.tabletblClaimInformation.AdjCaseReservesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCAT_Name_DetailsNull()
    {
      return this.IsNull(this.tabletblClaimInformation.CAT_Name_DetailsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCAT_Name_DetailsNull()
    {
      this[this.tabletblClaimInformation.CAT_Name_DetailsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTotalPaidNull() => this.IsNull(this.tabletblClaimInformation.TotalPaidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTotalPaidNull()
    {
      this[this.tabletblClaimInformation.TotalPaidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLimitNull() => this.IsNull(this.tabletblClaimInformation.LimitColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLimitNull()
    {
      this[this.tabletblClaimInformation.LimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsWatchListNull() => this.IsNull(this.tabletblClaimInformation.WatchListColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetWatchListNull()
    {
      this[this.tabletblClaimInformation.WatchListColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.tblClaimResPaymentActivityRow[] GettblClaimResPaymentActivityRows()
    {
      return this.Table.ChildRelations["tblClaimInformationtblClaimResPaymentActivity"] != null ? (dsClaims.tblClaimResPaymentActivityRow[]) this.GetChildRows(this.Table.ChildRelations["tblClaimInformationtblClaimResPaymentActivity"]) : new dsClaims.tblClaimResPaymentActivityRow[0];
    }
  }

  public class tblClaimResPaymentActivityRow : DataRow
  {
    private dsClaims.tblClaimResPaymentActivityDataTable tabletblClaimResPaymentActivity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblClaimResPaymentActivityRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClaimResPaymentActivity = (dsClaims.tblClaimResPaymentActivityDataTable) this.Table;
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
    public string RecType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimResPaymentActivity.RecTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RecType' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.RecTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal OutMedRes
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.OutMedResColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OutMedRes' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.OutMedResColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal MedicalPTD
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.MedicalPTDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MedicalPTD' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.MedicalPTDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime ValueDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimResPaymentActivity.ValueDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ValueDate' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.ValueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal TotalReserve
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.TotalReserveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TotalReserve' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.TotalReserveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal RespayTotalPaid
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.RespayTotalPaidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RespayTotalPaid' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.RespayTotalPaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal TotalRecovery
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.TotalRecoveryColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TotalRecovery' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.TotalRecoveryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal TPAReserve
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.TPAReserveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TPAReserve' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.TPAReserveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal BIPaid
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.BIPaidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BIPaid' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.BIPaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal BIReserve
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.BIReserveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BIReserve' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.BIReserveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal PDPaid
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.PDPaidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PDPaid' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.PDPaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal PDReserve
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.PDReserveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PDReserve' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.PDReserveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal GrossLoss
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.GrossLossColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GrossLoss' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.GrossLossColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal ExpensePaid
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.ExpensePaidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpensePaid' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.ExpensePaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal ExpenseReserved
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.ExpenseReservedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpenseReserved' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.ExpenseReservedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string DetailDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimResPaymentActivity.DetailDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DetailDescription' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.DetailDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LossStreet
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimResPaymentActivity.LossStreetColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LossStreet' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.LossStreetColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LossCity
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimResPaymentActivity.LossCityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LossCity' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.LossCityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LossState
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimResPaymentActivity.LossStateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LossState' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.LossStateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LossZip
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimResPaymentActivity.LossZipColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LossZip' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.LossZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Longitude
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimResPaymentActivity.LongitudeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Longitude' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.LongitudeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Latitude
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimResPaymentActivity.LatitudeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Latitude' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.LatitudeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Iso_Code
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblClaimResPaymentActivity.Iso_CodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Iso_Code' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.Iso_CodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Atc_Code
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblClaimResPaymentActivity.Atc_CodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Atc_Code' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.Atc_CodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Hail_Code
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblClaimResPaymentActivity.Hail_CodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Hail_Code' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.Hail_CodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Pc_Code
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblClaimResPaymentActivity.Pc_CodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Pc_Code' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.Pc_CodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Occupancy
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.OccupancyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Occupancy' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.OccupancyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Subsidized
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.SubsidizedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Subsidized' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.SubsidizedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Student_Senior
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.Student_SeniorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Student_Senior' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.Student_SeniorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Total_SqFt
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblClaimResPaymentActivity.Total_SqFtColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Total_SqFt' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.Total_SqFtColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Price_Per_Sqft
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.Price_Per_SqftColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Price_Per_Sqft' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.Price_Per_SqftColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Total_BV
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.Total_BVColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Total_BV' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.Total_BVColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Total_BBP
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.Total_BBPColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Total_BBP' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.Total_BBPColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Total_BI
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.Total_BIColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Total_BI' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.Total_BIColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Total_TIV
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.Total_TIVColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Total_TIV' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.Total_TIVColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Program_Deductible_Applied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.Program_Deductible_AppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Program_Deductible_Applied' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblClaimResPaymentActivity.Program_Deductible_AppliedColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Program_AOP
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.Program_AOPColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Program_AOP' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.Program_AOPColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Program_WindHail
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.Program_WindHailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Program_WindHail' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.Program_WindHailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Program_NS
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.Program_NSColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Program_NS' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.Program_NSColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Program_Notes
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblClaimResPaymentActivity.Program_NotesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Program_Notes' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.Program_NotesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DateCreated
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblClaimResPaymentActivity.DateCreatedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateCreated' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.DateCreatedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal BusIntReserve
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.BusIntReserveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BusIntReserve' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.BusIntReserveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal ContingentBIReserve
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.ContingentBIReserveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ContingentBIReserve' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.ContingentBIReserveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal BusIntPaid
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.BusIntPaidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BusIntPaid' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.BusIntPaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal ContingentBIPaid
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblClaimResPaymentActivity.ContingentBIPaidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ContingentBIPaid' in table 'tblClaimResPaymentActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblClaimResPaymentActivity.ContingentBIPaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.tblClaimInformationRow tblClaimInformationRow
    {
      get
      {
        return (dsClaims.tblClaimInformationRow) this.GetParentRow(this.Table.ParentRelations["tblClaimInformationtblClaimResPaymentActivity"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblClaimInformationtblClaimResPaymentActivity"]);
      }
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRecTypeNull() => this.IsNull(this.tabletblClaimResPaymentActivity.RecTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRecTypeNull()
    {
      this[this.tabletblClaimResPaymentActivity.RecTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOutMedResNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.OutMedResColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOutMedResNull()
    {
      this[this.tabletblClaimResPaymentActivity.OutMedResColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMedicalPTDNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.MedicalPTDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMedicalPTDNull()
    {
      this[this.tabletblClaimResPaymentActivity.MedicalPTDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsValueDateNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.ValueDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetValueDateNull()
    {
      this[this.tabletblClaimResPaymentActivity.ValueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTotalReserveNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.TotalReserveColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTotalReserveNull()
    {
      this[this.tabletblClaimResPaymentActivity.TotalReserveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRespayTotalPaidNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.RespayTotalPaidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetRespayTotalPaidNull()
    {
      this[this.tabletblClaimResPaymentActivity.RespayTotalPaidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTotalRecoveryNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.TotalRecoveryColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTotalRecoveryNull()
    {
      this[this.tabletblClaimResPaymentActivity.TotalRecoveryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTPAReserveNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.TPAReserveColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTPAReserveNull()
    {
      this[this.tabletblClaimResPaymentActivity.TPAReserveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBIPaidNull() => this.IsNull(this.tabletblClaimResPaymentActivity.BIPaidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBIPaidNull()
    {
      this[this.tabletblClaimResPaymentActivity.BIPaidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBIReserveNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.BIReserveColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBIReserveNull()
    {
      this[this.tabletblClaimResPaymentActivity.BIReserveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPDPaidNull() => this.IsNull(this.tabletblClaimResPaymentActivity.PDPaidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPDPaidNull()
    {
      this[this.tabletblClaimResPaymentActivity.PDPaidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPDReserveNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.PDReserveColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPDReserveNull()
    {
      this[this.tabletblClaimResPaymentActivity.PDReserveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsGrossLossNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.GrossLossColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetGrossLossNull()
    {
      this[this.tabletblClaimResPaymentActivity.GrossLossColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsExpensePaidNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.ExpensePaidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetExpensePaidNull()
    {
      this[this.tabletblClaimResPaymentActivity.ExpensePaidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsExpenseReservedNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.ExpenseReservedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetExpenseReservedNull()
    {
      this[this.tabletblClaimResPaymentActivity.ExpenseReservedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDetailDescriptionNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.DetailDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDetailDescriptionNull()
    {
      this[this.tabletblClaimResPaymentActivity.DetailDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLossStreetNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.LossStreetColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLossStreetNull()
    {
      this[this.tabletblClaimResPaymentActivity.LossStreetColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLossCityNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.LossCityColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLossCityNull()
    {
      this[this.tabletblClaimResPaymentActivity.LossCityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLossStateNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.LossStateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLossStateNull()
    {
      this[this.tabletblClaimResPaymentActivity.LossStateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLossZipNull() => this.IsNull(this.tabletblClaimResPaymentActivity.LossZipColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLossZipNull()
    {
      this[this.tabletblClaimResPaymentActivity.LossZipColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLongitudeNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.LongitudeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLongitudeNull()
    {
      this[this.tabletblClaimResPaymentActivity.LongitudeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLatitudeNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.LatitudeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLatitudeNull()
    {
      this[this.tabletblClaimResPaymentActivity.LatitudeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsIso_CodeNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.Iso_CodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetIso_CodeNull()
    {
      this[this.tabletblClaimResPaymentActivity.Iso_CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAtc_CodeNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.Atc_CodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAtc_CodeNull()
    {
      this[this.tabletblClaimResPaymentActivity.Atc_CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsHail_CodeNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.Hail_CodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetHail_CodeNull()
    {
      this[this.tabletblClaimResPaymentActivity.Hail_CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPc_CodeNull() => this.IsNull(this.tabletblClaimResPaymentActivity.Pc_CodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPc_CodeNull()
    {
      this[this.tabletblClaimResPaymentActivity.Pc_CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOccupancyNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.OccupancyColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOccupancyNull()
    {
      this[this.tabletblClaimResPaymentActivity.OccupancyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSubsidizedNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.SubsidizedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSubsidizedNull()
    {
      this[this.tabletblClaimResPaymentActivity.SubsidizedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStudent_SeniorNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.Student_SeniorColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStudent_SeniorNull()
    {
      this[this.tabletblClaimResPaymentActivity.Student_SeniorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTotal_SqFtNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.Total_SqFtColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTotal_SqFtNull()
    {
      this[this.tabletblClaimResPaymentActivity.Total_SqFtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPrice_Per_SqftNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.Price_Per_SqftColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPrice_Per_SqftNull()
    {
      this[this.tabletblClaimResPaymentActivity.Price_Per_SqftColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTotal_BVNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.Total_BVColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTotal_BVNull()
    {
      this[this.tabletblClaimResPaymentActivity.Total_BVColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTotal_BBPNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.Total_BBPColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTotal_BBPNull()
    {
      this[this.tabletblClaimResPaymentActivity.Total_BBPColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTotal_BINull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.Total_BIColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTotal_BINull()
    {
      this[this.tabletblClaimResPaymentActivity.Total_BIColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsTotal_TIVNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.Total_TIVColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetTotal_TIVNull()
    {
      this[this.tabletblClaimResPaymentActivity.Total_TIVColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProgram_Deductible_AppliedNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.Program_Deductible_AppliedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProgram_Deductible_AppliedNull()
    {
      this[this.tabletblClaimResPaymentActivity.Program_Deductible_AppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProgram_AOPNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.Program_AOPColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProgram_AOPNull()
    {
      this[this.tabletblClaimResPaymentActivity.Program_AOPColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProgram_WindHailNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.Program_WindHailColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProgram_WindHailNull()
    {
      this[this.tabletblClaimResPaymentActivity.Program_WindHailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProgram_NSNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.Program_NSColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProgram_NSNull()
    {
      this[this.tabletblClaimResPaymentActivity.Program_NSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProgram_NotesNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.Program_NotesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProgram_NotesNull()
    {
      this[this.tabletblClaimResPaymentActivity.Program_NotesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDateCreatedNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.DateCreatedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDateCreatedNull()
    {
      this[this.tabletblClaimResPaymentActivity.DateCreatedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBusIntReserveNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.BusIntReserveColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBusIntReserveNull()
    {
      this[this.tabletblClaimResPaymentActivity.BusIntReserveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsContingentBIReserveNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.ContingentBIReserveColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetContingentBIReserveNull()
    {
      this[this.tabletblClaimResPaymentActivity.ContingentBIReserveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBusIntPaidNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.BusIntPaidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBusIntPaidNull()
    {
      this[this.tabletblClaimResPaymentActivity.BusIntPaidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsContingentBIPaidNull()
    {
      return this.IsNull(this.tabletblClaimResPaymentActivity.ContingentBIPaidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetContingentBIPaidNull()
    {
      this[this.tabletblClaimResPaymentActivity.ContingentBIPaidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstStatesRow : DataRow
  {
    private dsClaims.lstStatesDataTable tablelstStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStates = (dsClaims.lstStatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tablelstStates.StateColumn]);
      set => this[this.tablelstStates.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tablelstStates.StateIDColumn]);
      set => this[this.tablelstStates.StateIDColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblClaimInformationRowChangeEvent : EventArgs
  {
    private dsClaims.tblClaimInformationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblClaimInformationRowChangeEvent(
      dsClaims.tblClaimInformationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.tblClaimInformationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblClaimResPaymentActivityRowChangeEvent : EventArgs
  {
    private dsClaims.tblClaimResPaymentActivityRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblClaimResPaymentActivityRowChangeEvent(
      dsClaims.tblClaimResPaymentActivityRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.tblClaimResPaymentActivityRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstStatesRowChangeEvent : EventArgs
  {
    private dsClaims.lstStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstStatesRowChangeEvent(dsClaims.lstStatesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsClaims.lstStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
