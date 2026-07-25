// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.dsCurrentLossInformation_Insureds
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
[XmlRoot("dsCurrentLossInformation_Insureds")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCurrentLossInformation_Insureds : DataSet
{
  private dsCurrentLossInformation_Insureds.dtCurrentLossInformationDataTable tabledtCurrentLossInformation;
  private dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubDataTable tabledtCurrentLossInformationSub;
  private DataRelation relationFK_dtCurrentLossInformation_dtCurrentLossInformationSub;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public dsCurrentLossInformation_Insureds()
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
  protected dsCurrentLossInformation_Insureds(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (dtCurrentLossInformation)] != null)
          base.Tables.Add((DataTable) new dsCurrentLossInformation_Insureds.dtCurrentLossInformationDataTable(dataSet.Tables[nameof (dtCurrentLossInformation)]));
        if (dataSet.Tables[nameof (dtCurrentLossInformationSub)] != null)
          base.Tables.Add((DataTable) new dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubDataTable(dataSet.Tables[nameof (dtCurrentLossInformationSub)]));
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
  public dsCurrentLossInformation_Insureds.dtCurrentLossInformationDataTable dtCurrentLossInformation
  {
    get => this.tabledtCurrentLossInformation;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubDataTable dtCurrentLossInformationSub
  {
    get => this.tabledtCurrentLossInformationSub;
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
    dsCurrentLossInformation_Insureds informationInsureds = (dsCurrentLossInformation_Insureds) base.Clone();
    informationInsureds.InitVars();
    informationInsureds.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) informationInsureds;
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
      if (dataSet.Tables["dtCurrentLossInformation"] != null)
        base.Tables.Add((DataTable) new dsCurrentLossInformation_Insureds.dtCurrentLossInformationDataTable(dataSet.Tables["dtCurrentLossInformation"]));
      if (dataSet.Tables["dtCurrentLossInformationSub"] != null)
        base.Tables.Add((DataTable) new dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubDataTable(dataSet.Tables["dtCurrentLossInformationSub"]));
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
    this.tabledtCurrentLossInformation = (dsCurrentLossInformation_Insureds.dtCurrentLossInformationDataTable) base.Tables["dtCurrentLossInformation"];
    if (initTable && this.tabledtCurrentLossInformation != null)
      this.tabledtCurrentLossInformation.InitVars();
    this.tabledtCurrentLossInformationSub = (dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubDataTable) base.Tables["dtCurrentLossInformationSub"];
    if (initTable && this.tabledtCurrentLossInformationSub != null)
      this.tabledtCurrentLossInformationSub.InitVars();
    this.relationFK_dtCurrentLossInformation_dtCurrentLossInformationSub = this.Relations["FK_dtCurrentLossInformation_dtCurrentLossInformationSub"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCurrentLossInformation_Insureds);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsCurrentLossInformation_Insureds.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabledtCurrentLossInformation = new dsCurrentLossInformation_Insureds.dtCurrentLossInformationDataTable();
    base.Tables.Add((DataTable) this.tabledtCurrentLossInformation);
    this.tabledtCurrentLossInformationSub = new dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubDataTable();
    base.Tables.Add((DataTable) this.tabledtCurrentLossInformationSub);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("FK_dtCurrentLossInformation_dtCurrentLossInformationSub", new DataColumn[1]
    {
      this.tabledtCurrentLossInformation.ControlNoColumn
    }, new DataColumn[1]
    {
      this.tabledtCurrentLossInformationSub.ControlNoColumn
    });
    this.tabledtCurrentLossInformationSub.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.None;
    foreignKeyConstraint.UpdateRule = Rule.None;
    this.relationFK_dtCurrentLossInformation_dtCurrentLossInformationSub = new DataRelation("FK_dtCurrentLossInformation_dtCurrentLossInformationSub", new DataColumn[1]
    {
      this.tabledtCurrentLossInformation.ControlNoColumn
    }, new DataColumn[1]
    {
      this.tabledtCurrentLossInformationSub.ControlNoColumn
    }, false);
    this.Relations.Add(this.relationFK_dtCurrentLossInformation_dtCurrentLossInformationSub);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializedtCurrentLossInformation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializedtCurrentLossInformationSub() => false;

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
    dsCurrentLossInformation_Insureds informationInsureds = new dsCurrentLossInformation_Insureds();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = informationInsureds.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = informationInsureds.GetSchemaSerializable();
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
  public delegate void dtCurrentLossInformationRowChangeEventHandler(
    object sender,
    dsCurrentLossInformation_Insureds.dtCurrentLossInformationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void dtCurrentLossInformationSubRowChangeEventHandler(
    object sender,
    dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class dtCurrentLossInformationDataTable : 
    TypedTableBase<dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow>
  {
    private DataColumn columnControlNo;
    private DataColumn columnPolicyNumber;
    private DataColumn columnLineName;
    private DataColumn columnTotalPaid;
    private DataColumn columnTotalReserves;
    private DataColumn columnTotalRecovery;
    private DataColumn columnTotalIncurred;
    private DataColumn columnInsuredName;
    private DataColumn columnPremium;
    private DataColumn columnLossRatio;
    private DataColumn columnEarnedPremium;
    private DataColumn columnEarnedPremiumLossRatio;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dtCurrentLossInformationDataTable()
    {
      this.TableName = "dtCurrentLossInformation";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal dtCurrentLossInformationDataTable(DataTable table)
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
    protected dtCurrentLossInformationDataTable(SerializationInfo info, StreamingContext context)
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
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TotalPaidColumn => this.columnTotalPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TotalReservesColumn => this.columnTotalReserves;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TotalRecoveryColumn => this.columnTotalRecovery;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TotalIncurredColumn => this.columnTotalIncurred;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn InsuredNameColumn => this.columnInsuredName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn LossRatioColumn => this.columnLossRatio;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EarnedPremiumColumn => this.columnEarnedPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EarnedPremiumLossRatioColumn => this.columnEarnedPremiumLossRatio;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow this[int index]
    {
      get => (dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCurrentLossInformation_Insureds.dtCurrentLossInformationRowChangeEventHandler dtCurrentLossInformationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCurrentLossInformation_Insureds.dtCurrentLossInformationRowChangeEventHandler dtCurrentLossInformationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCurrentLossInformation_Insureds.dtCurrentLossInformationRowChangeEventHandler dtCurrentLossInformationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCurrentLossInformation_Insureds.dtCurrentLossInformationRowChangeEventHandler dtCurrentLossInformationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AdddtCurrentLossInformationRow(
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow AdddtCurrentLossInformationRow(
      string ControlNo,
      string PolicyNumber,
      string LineName,
      Decimal TotalPaid,
      Decimal TotalReserves,
      Decimal TotalRecovery,
      Decimal TotalIncurred,
      string InsuredName,
      Decimal Premium,
      Decimal LossRatio,
      Decimal EarnedPremium,
      Decimal EarnedPremiumLossRatio)
    {
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow row = (dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow) this.NewRow();
      object[] objArray = new object[12]
      {
        (object) ControlNo,
        (object) PolicyNumber,
        (object) LineName,
        (object) TotalPaid,
        (object) TotalReserves,
        (object) TotalRecovery,
        (object) TotalIncurred,
        (object) InsuredName,
        (object) Premium,
        (object) LossRatio,
        (object) EarnedPremium,
        (object) EarnedPremiumLossRatio
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationDataTable informationDataTable = (dsCurrentLossInformation_Insureds.dtCurrentLossInformationDataTable) base.Clone();
      informationDataTable.InitVars();
      return (DataTable) informationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCurrentLossInformation_Insureds.dtCurrentLossInformationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnLineName = this.Columns["LineName"];
      this.columnTotalPaid = this.Columns["TotalPaid"];
      this.columnTotalReserves = this.Columns["TotalReserves"];
      this.columnTotalRecovery = this.Columns["TotalRecovery"];
      this.columnTotalIncurred = this.Columns["TotalIncurred"];
      this.columnInsuredName = this.Columns["InsuredName"];
      this.columnPremium = this.Columns["Premium"];
      this.columnLossRatio = this.Columns["LossRatio"];
      this.columnEarnedPremium = this.Columns["EarnedPremium"];
      this.columnEarnedPremiumLossRatio = this.Columns["EarnedPremiumLossRatio"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnControlNo = new DataColumn("ControlNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnLineName = new DataColumn("LineName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineName);
      this.columnTotalPaid = new DataColumn("TotalPaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalPaid);
      this.columnTotalReserves = new DataColumn("TotalReserves", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalReserves);
      this.columnTotalRecovery = new DataColumn("TotalRecovery", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalRecovery);
      this.columnTotalIncurred = new DataColumn("TotalIncurred", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalIncurred);
      this.columnInsuredName = new DataColumn("InsuredName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredName);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnLossRatio = new DataColumn("LossRatio", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLossRatio);
      this.columnEarnedPremium = new DataColumn("EarnedPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEarnedPremium);
      this.columnEarnedPremiumLossRatio = new DataColumn("EarnedPremiumLossRatio", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEarnedPremiumLossRatio);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnControlNo
      }, false));
      this.columnControlNo.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow NewdtCurrentLossInformationRow()
    {
      return (dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationRowChangeEventHandler informationRowChangedEvent = this.dtCurrentLossInformationRowChangedEvent;
      if (informationRowChangedEvent == null)
        return;
      informationRowChangedEvent((object) this, new dsCurrentLossInformation_Insureds.dtCurrentLossInformationRowChangeEvent((dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationRowChangeEventHandler rowChangingEvent = this.dtCurrentLossInformationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCurrentLossInformation_Insureds.dtCurrentLossInformationRowChangeEvent((dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationRowChangeEventHandler informationRowDeletedEvent = this.dtCurrentLossInformationRowDeletedEvent;
      if (informationRowDeletedEvent == null)
        return;
      informationRowDeletedEvent((object) this, new dsCurrentLossInformation_Insureds.dtCurrentLossInformationRowChangeEvent((dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationRowChangeEventHandler rowDeletingEvent = this.dtCurrentLossInformationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCurrentLossInformation_Insureds.dtCurrentLossInformationRowChangeEvent((dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovedtCurrentLossInformationRow(
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCurrentLossInformation_Insureds informationInsureds = new dsCurrentLossInformation_Insureds();
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
        FixedValue = informationInsureds.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtCurrentLossInformationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = informationInsureds.GetSchemaSerializable();
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
  public class dtCurrentLossInformationSubDataTable : 
    TypedTableBase<dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow>
  {
    private DataColumn columnControlNo;
    private DataColumn columnPolicyNumber;
    private DataColumn columnLineName;
    private DataColumn columnEffectiveDate;
    private DataColumn columnExpirationDate;
    private DataColumn columnClaimNo;
    private DataColumn columnDateReported;
    private DataColumn columnLossDate;
    private DataColumn columnStatus;
    private DataColumn columnDescriptionInjury;
    private DataColumn columnIndemnityPTD;
    private DataColumn columnOutIndRes;
    private DataColumn columnLossIncurred;
    private DataColumn columnInsuredName;
    private DataColumn columnLAEPTD;
    private DataColumn columnOutLAERes;
    private DataColumn columnTotalRecovery;
    private DataColumn columnTotalReserves;
    private DataColumn columnClaimID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dtCurrentLossInformationSubDataTable()
    {
      this.TableName = "dtCurrentLossInformationSub";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal dtCurrentLossInformationSubDataTable(DataTable table)
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
    protected dtCurrentLossInformationSubDataTable(SerializationInfo info, StreamingContext context)
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
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ClaimNoColumn => this.columnClaimNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DateReportedColumn => this.columnDateReported;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn LossDateColumn => this.columnLossDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DescriptionInjuryColumn => this.columnDescriptionInjury;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn IndemnityPTDColumn => this.columnIndemnityPTD;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn OutIndResColumn => this.columnOutIndRes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn LossIncurredColumn => this.columnLossIncurred;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn InsuredNameColumn => this.columnInsuredName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn LAEPTDColumn => this.columnLAEPTD;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn OutLAEResColumn => this.columnOutLAERes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TotalRecoveryColumn => this.columnTotalRecovery;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TotalReservesColumn => this.columnTotalReserves;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ClaimIDColumn => this.columnClaimID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow this[int index]
    {
      get => (dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRowChangeEventHandler dtCurrentLossInformationSubRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRowChangeEventHandler dtCurrentLossInformationSubRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRowChangeEventHandler dtCurrentLossInformationSubRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRowChangeEventHandler dtCurrentLossInformationSubRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AdddtCurrentLossInformationSubRow(
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow AdddtCurrentLossInformationSubRow(
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow parentdtCurrentLossInformationRowByFK_dtCurrentLossInformation_dtCurrentLossInformationSub,
      string PolicyNumber,
      string LineName,
      string EffectiveDate,
      string ExpirationDate,
      string ClaimNo,
      string DateReported,
      string LossDate,
      string Status,
      string DescriptionInjury,
      Decimal IndemnityPTD,
      Decimal OutIndRes,
      Decimal LossIncurred,
      string InsuredName,
      Decimal LAEPTD,
      Decimal OutLAERes,
      Decimal TotalRecovery,
      Decimal TotalReserves,
      int ClaimID)
    {
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow row = (dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow) this.NewRow();
      object[] objArray = new object[19]
      {
        null,
        (object) PolicyNumber,
        (object) LineName,
        (object) EffectiveDate,
        (object) ExpirationDate,
        (object) ClaimNo,
        (object) DateReported,
        (object) LossDate,
        (object) Status,
        (object) DescriptionInjury,
        (object) IndemnityPTD,
        (object) OutIndRes,
        (object) LossIncurred,
        (object) InsuredName,
        (object) LAEPTD,
        (object) OutLAERes,
        (object) TotalRecovery,
        (object) TotalReserves,
        (object) ClaimID
      };
      if (parentdtCurrentLossInformationRowByFK_dtCurrentLossInformation_dtCurrentLossInformationSub != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parentdtCurrentLossInformationRowByFK_dtCurrentLossInformation_dtCurrentLossInformationSub[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubDataTable informationSubDataTable = (dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubDataTable) base.Clone();
      informationSubDataTable.InitVars();
      return (DataTable) informationSubDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnLineName = this.Columns["LineName"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnClaimNo = this.Columns["ClaimNo"];
      this.columnDateReported = this.Columns["DateReported"];
      this.columnLossDate = this.Columns["LossDate"];
      this.columnStatus = this.Columns["Status"];
      this.columnDescriptionInjury = this.Columns["DescriptionInjury"];
      this.columnIndemnityPTD = this.Columns["IndemnityPTD"];
      this.columnOutIndRes = this.Columns["OutIndRes"];
      this.columnLossIncurred = this.Columns["LossIncurred"];
      this.columnInsuredName = this.Columns["InsuredName"];
      this.columnLAEPTD = this.Columns["LAEPTD"];
      this.columnOutLAERes = this.Columns["OutLAERes"];
      this.columnTotalRecovery = this.Columns["TotalRecovery"];
      this.columnTotalReserves = this.Columns["TotalReserves"];
      this.columnClaimID = this.Columns["ClaimID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnControlNo = new DataColumn("ControlNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnLineName = new DataColumn("LineName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineName);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnClaimNo = new DataColumn("ClaimNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimNo);
      this.columnDateReported = new DataColumn("DateReported", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateReported);
      this.columnLossDate = new DataColumn("LossDate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLossDate);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnDescriptionInjury = new DataColumn("DescriptionInjury", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescriptionInjury);
      this.columnIndemnityPTD = new DataColumn("IndemnityPTD", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIndemnityPTD);
      this.columnOutIndRes = new DataColumn("OutIndRes", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOutIndRes);
      this.columnLossIncurred = new DataColumn("LossIncurred", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLossIncurred);
      this.columnInsuredName = new DataColumn("InsuredName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredName);
      this.columnLAEPTD = new DataColumn("LAEPTD", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLAEPTD);
      this.columnOutLAERes = new DataColumn("OutLAERes", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOutLAERes);
      this.columnTotalRecovery = new DataColumn("TotalRecovery", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalRecovery);
      this.columnTotalReserves = new DataColumn("TotalReserves", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalReserves);
      this.columnClaimID = new DataColumn("ClaimID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimID);
      this.columnControlNo.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow NewdtCurrentLossInformationSubRow()
    {
      return (dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationSubRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRowChangeEventHandler subRowChangedEvent = this.dtCurrentLossInformationSubRowChangedEvent;
      if (subRowChangedEvent == null)
        return;
      subRowChangedEvent((object) this, new dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRowChangeEvent((dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationSubRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRowChangeEventHandler rowChangingEvent = this.dtCurrentLossInformationSubRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRowChangeEvent((dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationSubRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRowChangeEventHandler subRowDeletedEvent = this.dtCurrentLossInformationSubRowDeletedEvent;
      if (subRowDeletedEvent == null)
        return;
      subRowDeletedEvent((object) this, new dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRowChangeEvent((dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationSubRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRowChangeEventHandler rowDeletingEvent = this.dtCurrentLossInformationSubRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRowChangeEvent((dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovedtCurrentLossInformationSubRow(
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCurrentLossInformation_Insureds informationInsureds = new dsCurrentLossInformation_Insureds();
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
        FixedValue = informationInsureds.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtCurrentLossInformationSubDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = informationInsureds.GetSchemaSerializable();
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

  public class dtCurrentLossInformationRow : DataRow
  {
    private dsCurrentLossInformation_Insureds.dtCurrentLossInformationDataTable tabledtCurrentLossInformation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal dtCurrentLossInformationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtCurrentLossInformation = (dsCurrentLossInformation_Insureds.dtCurrentLossInformationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ControlNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCurrentLossInformation.ControlNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ControlNo' in table 'dtCurrentLossInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformation.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCurrentLossInformation.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'dtCurrentLossInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformation.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string LineName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCurrentLossInformation.LineNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LineName' in table 'dtCurrentLossInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformation.LineNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal TotalPaid
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformation.TotalPaidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TotalPaid' in table 'dtCurrentLossInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformation.TotalPaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal TotalReserves
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformation.TotalReservesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TotalReserves' in table 'dtCurrentLossInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformation.TotalReservesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal TotalRecovery
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformation.TotalRecoveryColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TotalRecovery' in table 'dtCurrentLossInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformation.TotalRecoveryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal TotalIncurred
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformation.TotalIncurredColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TotalIncurred' in table 'dtCurrentLossInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformation.TotalIncurredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string InsuredName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCurrentLossInformation.InsuredNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredName' in table 'dtCurrentLossInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformation.InsuredNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformation.PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Premium' in table 'dtCurrentLossInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformation.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal LossRatio
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformation.LossRatioColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LossRatio' in table 'dtCurrentLossInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformation.LossRatioColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal EarnedPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformation.EarnedPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EarnedPremium' in table 'dtCurrentLossInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformation.EarnedPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal EarnedPremiumLossRatio
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformation.EarnedPremiumLossRatioColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EarnedPremiumLossRatio' in table 'dtCurrentLossInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformation.EarnedPremiumLossRatioColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsControlNoNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.ControlNoColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetControlNoNull()
    {
      this[this.tabledtCurrentLossInformation.ControlNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPolicyNumberNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.PolicyNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tabledtCurrentLossInformation.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsLineNameNull() => this.IsNull(this.tabledtCurrentLossInformation.LineNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetLineNameNull()
    {
      this[this.tabledtCurrentLossInformation.LineNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsTotalPaidNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.TotalPaidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetTotalPaidNull()
    {
      this[this.tabledtCurrentLossInformation.TotalPaidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsTotalReservesNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.TotalReservesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetTotalReservesNull()
    {
      this[this.tabledtCurrentLossInformation.TotalReservesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsTotalRecoveryNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.TotalRecoveryColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetTotalRecoveryNull()
    {
      this[this.tabledtCurrentLossInformation.TotalRecoveryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsTotalIncurredNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.TotalIncurredColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetTotalIncurredNull()
    {
      this[this.tabledtCurrentLossInformation.TotalIncurredColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsInsuredNameNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.InsuredNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetInsuredNameNull()
    {
      this[this.tabledtCurrentLossInformation.InsuredNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tabledtCurrentLossInformation.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tabledtCurrentLossInformation.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsLossRatioNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.LossRatioColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetLossRatioNull()
    {
      this[this.tabledtCurrentLossInformation.LossRatioColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEarnedPremiumNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.EarnedPremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEarnedPremiumNull()
    {
      this[this.tabledtCurrentLossInformation.EarnedPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEarnedPremiumLossRatioNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.EarnedPremiumLossRatioColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEarnedPremiumLossRatioNull()
    {
      this[this.tabledtCurrentLossInformation.EarnedPremiumLossRatioColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow[] GetdtCurrentLossInformationSubRows()
    {
      return this.Table.ChildRelations["FK_dtCurrentLossInformation_dtCurrentLossInformationSub"] != null ? (dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow[]) this.GetChildRows(this.Table.ChildRelations["FK_dtCurrentLossInformation_dtCurrentLossInformationSub"]) : new dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow[0];
    }
  }

  public class dtCurrentLossInformationSubRow : DataRow
  {
    private dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubDataTable tabledtCurrentLossInformationSub;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal dtCurrentLossInformationSubRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtCurrentLossInformationSub = (dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ControlNo
    {
      get => Conversions.ToString(this[this.tabledtCurrentLossInformationSub.ControlNoColumn]);
      set => this[this.tabledtCurrentLossInformationSub.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCurrentLossInformationSub.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string LineName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCurrentLossInformationSub.LineNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LineName' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.LineNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCurrentLossInformationSub.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ExpirationDate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCurrentLossInformationSub.ExpirationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpirationDate' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ClaimNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCurrentLossInformationSub.ClaimNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClaimNo' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.ClaimNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string DateReported
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCurrentLossInformationSub.DateReportedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateReported' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.DateReportedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string LossDate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCurrentLossInformationSub.LossDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LossDate' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.LossDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Status
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCurrentLossInformationSub.StatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Status' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.StatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string DescriptionInjury
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCurrentLossInformationSub.DescriptionInjuryColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DescriptionInjury' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.DescriptionInjuryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal IndemnityPTD
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.IndemnityPTDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IndemnityPTD' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.IndemnityPTDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal OutIndRes
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.OutIndResColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OutIndRes' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.OutIndResColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal LossIncurred
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.LossIncurredColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LossIncurred' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.LossIncurredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string InsuredName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtCurrentLossInformationSub.InsuredNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredName' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.InsuredNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal LAEPTD
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.LAEPTDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LAEPTD' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.LAEPTDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal OutLAERes
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.OutLAEResColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OutLAERes' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.OutLAEResColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal TotalRecovery
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.TotalRecoveryColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TotalRecovery' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.TotalRecoveryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal TotalReserves
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.TotalReservesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TotalReserves' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.TotalReservesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ClaimID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledtCurrentLossInformationSub.ClaimIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClaimID' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.ClaimIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow dtCurrentLossInformationRow
    {
      get
      {
        return (dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow) this.GetParentRow(this.Table.ParentRelations["FK_dtCurrentLossInformation_dtCurrentLossInformationSub"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["FK_dtCurrentLossInformation_dtCurrentLossInformationSub"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPolicyNumberNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.PolicyNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tabledtCurrentLossInformationSub.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsLineNameNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.LineNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetLineNameNull()
    {
      this[this.tabledtCurrentLossInformationSub.LineNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEffectiveDateNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.EffectiveDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tabledtCurrentLossInformationSub.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsExpirationDateNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.ExpirationDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetExpirationDateNull()
    {
      this[this.tabledtCurrentLossInformationSub.ExpirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsClaimNoNull() => this.IsNull(this.tabledtCurrentLossInformationSub.ClaimNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetClaimNoNull()
    {
      this[this.tabledtCurrentLossInformationSub.ClaimNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDateReportedNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.DateReportedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDateReportedNull()
    {
      this[this.tabledtCurrentLossInformationSub.DateReportedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsLossDateNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.LossDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetLossDateNull()
    {
      this[this.tabledtCurrentLossInformationSub.LossDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsStatusNull() => this.IsNull(this.tabledtCurrentLossInformationSub.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetStatusNull()
    {
      this[this.tabledtCurrentLossInformationSub.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDescriptionInjuryNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.DescriptionInjuryColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDescriptionInjuryNull()
    {
      this[this.tabledtCurrentLossInformationSub.DescriptionInjuryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsIndemnityPTDNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.IndemnityPTDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetIndemnityPTDNull()
    {
      this[this.tabledtCurrentLossInformationSub.IndemnityPTDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsOutIndResNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.OutIndResColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetOutIndResNull()
    {
      this[this.tabledtCurrentLossInformationSub.OutIndResColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsLossIncurredNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.LossIncurredColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetLossIncurredNull()
    {
      this[this.tabledtCurrentLossInformationSub.LossIncurredColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsInsuredNameNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.InsuredNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetInsuredNameNull()
    {
      this[this.tabledtCurrentLossInformationSub.InsuredNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsLAEPTDNull() => this.IsNull(this.tabledtCurrentLossInformationSub.LAEPTDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetLAEPTDNull()
    {
      this[this.tabledtCurrentLossInformationSub.LAEPTDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsOutLAEResNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.OutLAEResColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetOutLAEResNull()
    {
      this[this.tabledtCurrentLossInformationSub.OutLAEResColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsTotalRecoveryNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.TotalRecoveryColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetTotalRecoveryNull()
    {
      this[this.tabledtCurrentLossInformationSub.TotalRecoveryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsTotalReservesNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.TotalReservesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetTotalReservesNull()
    {
      this[this.tabledtCurrentLossInformationSub.TotalReservesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsClaimIDNull() => this.IsNull(this.tabledtCurrentLossInformationSub.ClaimIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetClaimIDNull()
    {
      this[this.tabledtCurrentLossInformationSub.ClaimIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class dtCurrentLossInformationRowChangeEvent : EventArgs
  {
    private dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dtCurrentLossInformationRowChangeEvent(
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCurrentLossInformation_Insureds.dtCurrentLossInformationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class dtCurrentLossInformationSubRowChangeEvent : EventArgs
  {
    private dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dtCurrentLossInformationSubRowChangeEvent(
      dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCurrentLossInformation_Insureds.dtCurrentLossInformationSubRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
