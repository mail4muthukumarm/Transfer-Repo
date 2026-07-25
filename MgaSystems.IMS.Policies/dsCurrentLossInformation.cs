// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsCurrentLossInformation
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
[XmlRoot("dsCurrentLossInformation")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCurrentLossInformation : DataSet
{
  private dsCurrentLossInformation.dtCurrentLossInformationDataTable tabledtCurrentLossInformation;
  private dsCurrentLossInformation.dtCurrentLossInformationSubDataTable tabledtCurrentLossInformationSub;
  private DataRelation relationFK_dtCurrentLossInformation_dtCurrentLossInformationSub;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsCurrentLossInformation()
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
  protected dsCurrentLossInformation(SerializationInfo info, StreamingContext context)
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
          base.Tables.Add((DataTable) new dsCurrentLossInformation.dtCurrentLossInformationDataTable(dataSet.Tables[nameof (dtCurrentLossInformation)]));
        if (dataSet.Tables[nameof (dtCurrentLossInformationSub)] != null)
          base.Tables.Add((DataTable) new dsCurrentLossInformation.dtCurrentLossInformationSubDataTable(dataSet.Tables[nameof (dtCurrentLossInformationSub)]));
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
  public dsCurrentLossInformation.dtCurrentLossInformationDataTable dtCurrentLossInformation
  {
    get => this.tabledtCurrentLossInformation;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCurrentLossInformation.dtCurrentLossInformationSubDataTable dtCurrentLossInformationSub
  {
    get => this.tabledtCurrentLossInformationSub;
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
    dsCurrentLossInformation currentLossInformation = (dsCurrentLossInformation) base.Clone();
    currentLossInformation.InitVars();
    currentLossInformation.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) currentLossInformation;
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
      if (dataSet.Tables["dtCurrentLossInformation"] != null)
        base.Tables.Add((DataTable) new dsCurrentLossInformation.dtCurrentLossInformationDataTable(dataSet.Tables["dtCurrentLossInformation"]));
      if (dataSet.Tables["dtCurrentLossInformationSub"] != null)
        base.Tables.Add((DataTable) new dsCurrentLossInformation.dtCurrentLossInformationSubDataTable(dataSet.Tables["dtCurrentLossInformationSub"]));
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
    this.tabledtCurrentLossInformation = (dsCurrentLossInformation.dtCurrentLossInformationDataTable) base.Tables["dtCurrentLossInformation"];
    if (initTable && this.tabledtCurrentLossInformation != null)
      this.tabledtCurrentLossInformation.InitVars();
    this.tabledtCurrentLossInformationSub = (dsCurrentLossInformation.dtCurrentLossInformationSubDataTable) base.Tables["dtCurrentLossInformationSub"];
    if (initTable && this.tabledtCurrentLossInformationSub != null)
      this.tabledtCurrentLossInformationSub.InitVars();
    this.relationFK_dtCurrentLossInformation_dtCurrentLossInformationSub = this.Relations["FK_dtCurrentLossInformation_dtCurrentLossInformationSub"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCurrentLossInformation);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsCurrentLossInformation.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabledtCurrentLossInformation = new dsCurrentLossInformation.dtCurrentLossInformationDataTable();
    base.Tables.Add((DataTable) this.tabledtCurrentLossInformation);
    this.tabledtCurrentLossInformationSub = new dsCurrentLossInformation.dtCurrentLossInformationSubDataTable();
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializedtCurrentLossInformation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializedtCurrentLossInformationSub() => false;

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
    dsCurrentLossInformation currentLossInformation = new dsCurrentLossInformation();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = currentLossInformation.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = currentLossInformation.GetSchemaSerializable();
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
  public delegate void dtCurrentLossInformationRowChangeEventHandler(
    object sender,
    dsCurrentLossInformation.dtCurrentLossInformationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void dtCurrentLossInformationSubRowChangeEventHandler(
    object sender,
    dsCurrentLossInformation.dtCurrentLossInformationSubRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class dtCurrentLossInformationDataTable : 
    TypedTableBase<dsCurrentLossInformation.dtCurrentLossInformationRow>
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dtCurrentLossInformationDataTable()
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.dtCurrentLossInformationDataTable_ColumnChanging);
      this.TableName = "dtCurrentLossInformation";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal dtCurrentLossInformationDataTable(DataTable table)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.dtCurrentLossInformationDataTable_ColumnChanging);
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
    protected dtCurrentLossInformationDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.dtCurrentLossInformationDataTable_ColumnChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TotalPaidColumn => this.columnTotalPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TotalReservesColumn => this.columnTotalReserves;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TotalRecoveryColumn => this.columnTotalRecovery;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TotalIncurredColumn => this.columnTotalIncurred;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredNameColumn => this.columnInsuredName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LossRatioColumn => this.columnLossRatio;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EarnedPremiumColumn => this.columnEarnedPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EarnedPremiumLossRatioColumn => this.columnEarnedPremiumLossRatio;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCurrentLossInformation.dtCurrentLossInformationRow this[int index]
    {
      get => (dsCurrentLossInformation.dtCurrentLossInformationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCurrentLossInformation.dtCurrentLossInformationRowChangeEventHandler dtCurrentLossInformationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCurrentLossInformation.dtCurrentLossInformationRowChangeEventHandler dtCurrentLossInformationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCurrentLossInformation.dtCurrentLossInformationRowChangeEventHandler dtCurrentLossInformationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCurrentLossInformation.dtCurrentLossInformationRowChangeEventHandler dtCurrentLossInformationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AdddtCurrentLossInformationRow(
      dsCurrentLossInformation.dtCurrentLossInformationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCurrentLossInformation.dtCurrentLossInformationRow AdddtCurrentLossInformationRow(
      int ControlNo,
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
      dsCurrentLossInformation.dtCurrentLossInformationRow row = (dsCurrentLossInformation.dtCurrentLossInformationRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCurrentLossInformation.dtCurrentLossInformationDataTable informationDataTable = (dsCurrentLossInformation.dtCurrentLossInformationDataTable) base.Clone();
      informationDataTable.InitVars();
      return (DataTable) informationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCurrentLossInformation.dtCurrentLossInformationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCurrentLossInformation.dtCurrentLossInformationRow NewdtCurrentLossInformationRow()
    {
      return (dsCurrentLossInformation.dtCurrentLossInformationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCurrentLossInformation.dtCurrentLossInformationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCurrentLossInformation.dtCurrentLossInformationRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation.dtCurrentLossInformationRowChangeEventHandler informationRowChangedEvent = this.dtCurrentLossInformationRowChangedEvent;
      if (informationRowChangedEvent == null)
        return;
      informationRowChangedEvent((object) this, new dsCurrentLossInformation.dtCurrentLossInformationRowChangeEvent((dsCurrentLossInformation.dtCurrentLossInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation.dtCurrentLossInformationRowChangeEventHandler rowChangingEvent = this.dtCurrentLossInformationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCurrentLossInformation.dtCurrentLossInformationRowChangeEvent((dsCurrentLossInformation.dtCurrentLossInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation.dtCurrentLossInformationRowChangeEventHandler informationRowDeletedEvent = this.dtCurrentLossInformationRowDeletedEvent;
      if (informationRowDeletedEvent == null)
        return;
      informationRowDeletedEvent((object) this, new dsCurrentLossInformation.dtCurrentLossInformationRowChangeEvent((dsCurrentLossInformation.dtCurrentLossInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation.dtCurrentLossInformationRowChangeEventHandler rowDeletingEvent = this.dtCurrentLossInformationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCurrentLossInformation.dtCurrentLossInformationRowChangeEvent((dsCurrentLossInformation.dtCurrentLossInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovedtCurrentLossInformationRow(
      dsCurrentLossInformation.dtCurrentLossInformationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCurrentLossInformation currentLossInformation = new dsCurrentLossInformation();
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
        FixedValue = currentLossInformation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtCurrentLossInformationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = currentLossInformation.GetSchemaSerializable();
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

    private void dtCurrentLossInformationDataTable_ColumnChanging(
      object sender,
      DataColumnChangeEventArgs e)
    {
      Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Column.ColumnName, this.ControlNoColumn.ColumnName, false);
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class dtCurrentLossInformationSubDataTable : 
    TypedTableBase<dsCurrentLossInformation.dtCurrentLossInformationSubRow>
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
    private DataColumn columnGrossIndemnityPaid;
    private DataColumn columnGrossIndemnityReserve;
    private DataColumn columnInsuredName;
    private DataColumn columnLegalReserve;
    private DataColumn columnLegalPaid;
    private DataColumn columnTotalRecovery;
    private DataColumn columnTotalReserves;
    private DataColumn columnClaimID;
    private DataColumn columnLAEReserve;
    private DataColumn columnLAEPaid;
    private DataColumn columnDeductibleRecovery;
    private DataColumn columnOtherRecovery;
    private DataColumn columnNetIncurred;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dtCurrentLossInformationSubDataTable()
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.dtCurrentLossInformationSubDataTable_ColumnChanging);
      this.TableName = "dtCurrentLossInformationSub";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal dtCurrentLossInformationSubDataTable(DataTable table)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.dtCurrentLossInformationSubDataTable_ColumnChanging);
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
    protected dtCurrentLossInformationSubDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.dtCurrentLossInformationSubDataTable_ColumnChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LineNameColumn => this.columnLineName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClaimNoColumn => this.columnClaimNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateReportedColumn => this.columnDateReported;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LossDateColumn => this.columnLossDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionInjuryColumn => this.columnDescriptionInjury;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GrossIndemnityPaidColumn => this.columnGrossIndemnityPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GrossIndemnityReserveColumn => this.columnGrossIndemnityReserve;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredNameColumn => this.columnInsuredName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LegalReserveColumn => this.columnLegalReserve;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LegalPaidColumn => this.columnLegalPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TotalRecoveryColumn => this.columnTotalRecovery;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TotalReservesColumn => this.columnTotalReserves;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClaimIDColumn => this.columnClaimID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LAEReserveColumn => this.columnLAEReserve;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LAEPaidColumn => this.columnLAEPaid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DeductibleRecoveryColumn => this.columnDeductibleRecovery;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OtherRecoveryColumn => this.columnOtherRecovery;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NetIncurredColumn => this.columnNetIncurred;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCurrentLossInformation.dtCurrentLossInformationSubRow this[int index]
    {
      get => (dsCurrentLossInformation.dtCurrentLossInformationSubRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCurrentLossInformation.dtCurrentLossInformationSubRowChangeEventHandler dtCurrentLossInformationSubRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCurrentLossInformation.dtCurrentLossInformationSubRowChangeEventHandler dtCurrentLossInformationSubRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCurrentLossInformation.dtCurrentLossInformationSubRowChangeEventHandler dtCurrentLossInformationSubRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCurrentLossInformation.dtCurrentLossInformationSubRowChangeEventHandler dtCurrentLossInformationSubRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AdddtCurrentLossInformationSubRow(
      dsCurrentLossInformation.dtCurrentLossInformationSubRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCurrentLossInformation.dtCurrentLossInformationSubRow AdddtCurrentLossInformationSubRow(
      dsCurrentLossInformation.dtCurrentLossInformationRow parentdtCurrentLossInformationRowByFK_dtCurrentLossInformation_dtCurrentLossInformationSub,
      string PolicyNumber,
      string LineName,
      string EffectiveDate,
      string ExpirationDate,
      string ClaimNo,
      string DateReported,
      string LossDate,
      string Status,
      string DescriptionInjury,
      Decimal GrossIndemnityPaid,
      Decimal GrossIndemnityReserve,
      string InsuredName,
      Decimal LegalReserve,
      Decimal LegalPaid,
      Decimal TotalRecovery,
      Decimal TotalReserves,
      int ClaimID,
      Decimal LAEReserve,
      Decimal LAEPaid,
      Decimal DeductibleRecovery,
      Decimal OtherRecovery,
      Decimal NetIncurred)
    {
      dsCurrentLossInformation.dtCurrentLossInformationSubRow row = (dsCurrentLossInformation.dtCurrentLossInformationSubRow) this.NewRow();
      object[] objArray = new object[23]
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
        (object) GrossIndemnityPaid,
        (object) GrossIndemnityReserve,
        (object) InsuredName,
        (object) LegalReserve,
        (object) LegalPaid,
        (object) TotalRecovery,
        (object) TotalReserves,
        (object) ClaimID,
        (object) LAEReserve,
        (object) LAEPaid,
        (object) DeductibleRecovery,
        (object) OtherRecovery,
        (object) NetIncurred
      };
      if (parentdtCurrentLossInformationRowByFK_dtCurrentLossInformation_dtCurrentLossInformationSub != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parentdtCurrentLossInformationRowByFK_dtCurrentLossInformation_dtCurrentLossInformationSub[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCurrentLossInformation.dtCurrentLossInformationSubDataTable informationSubDataTable = (dsCurrentLossInformation.dtCurrentLossInformationSubDataTable) base.Clone();
      informationSubDataTable.InitVars();
      return (DataTable) informationSubDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCurrentLossInformation.dtCurrentLossInformationSubDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
      this.columnGrossIndemnityPaid = this.Columns["GrossIndemnityPaid"];
      this.columnGrossIndemnityReserve = this.Columns["GrossIndemnityReserve"];
      this.columnInsuredName = this.Columns["InsuredName"];
      this.columnLegalReserve = this.Columns["LegalReserve"];
      this.columnLegalPaid = this.Columns["LegalPaid"];
      this.columnTotalRecovery = this.Columns["TotalRecovery"];
      this.columnTotalReserves = this.Columns["TotalReserves"];
      this.columnClaimID = this.Columns["ClaimID"];
      this.columnLAEReserve = this.Columns["LAEReserve"];
      this.columnLAEPaid = this.Columns["LAEPaid"];
      this.columnDeductibleRecovery = this.Columns["DeductibleRecovery"];
      this.columnOtherRecovery = this.Columns["OtherRecovery"];
      this.columnNetIncurred = this.Columns["NetIncurred"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
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
      this.columnGrossIndemnityPaid = new DataColumn("GrossIndemnityPaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGrossIndemnityPaid);
      this.columnGrossIndemnityReserve = new DataColumn("GrossIndemnityReserve", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGrossIndemnityReserve);
      this.columnInsuredName = new DataColumn("InsuredName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredName);
      this.columnLegalReserve = new DataColumn("LegalReserve", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLegalReserve);
      this.columnLegalPaid = new DataColumn("LegalPaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLegalPaid);
      this.columnTotalRecovery = new DataColumn("TotalRecovery", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalRecovery);
      this.columnTotalReserves = new DataColumn("TotalReserves", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalReserves);
      this.columnClaimID = new DataColumn("ClaimID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimID);
      this.columnLAEReserve = new DataColumn("LAEReserve", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLAEReserve);
      this.columnLAEPaid = new DataColumn("LAEPaid", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLAEPaid);
      this.columnDeductibleRecovery = new DataColumn("DeductibleRecovery", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductibleRecovery);
      this.columnOtherRecovery = new DataColumn("OtherRecovery", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOtherRecovery);
      this.columnNetIncurred = new DataColumn("NetIncurred", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetIncurred);
      this.columnControlNo.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCurrentLossInformation.dtCurrentLossInformationSubRow NewdtCurrentLossInformationSubRow()
    {
      return (dsCurrentLossInformation.dtCurrentLossInformationSubRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCurrentLossInformation.dtCurrentLossInformationSubRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCurrentLossInformation.dtCurrentLossInformationSubRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationSubRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation.dtCurrentLossInformationSubRowChangeEventHandler subRowChangedEvent = this.dtCurrentLossInformationSubRowChangedEvent;
      if (subRowChangedEvent == null)
        return;
      subRowChangedEvent((object) this, new dsCurrentLossInformation.dtCurrentLossInformationSubRowChangeEvent((dsCurrentLossInformation.dtCurrentLossInformationSubRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationSubRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation.dtCurrentLossInformationSubRowChangeEventHandler rowChangingEvent = this.dtCurrentLossInformationSubRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCurrentLossInformation.dtCurrentLossInformationSubRowChangeEvent((dsCurrentLossInformation.dtCurrentLossInformationSubRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationSubRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation.dtCurrentLossInformationSubRowChangeEventHandler subRowDeletedEvent = this.dtCurrentLossInformationSubRowDeletedEvent;
      if (subRowDeletedEvent == null)
        return;
      subRowDeletedEvent((object) this, new dsCurrentLossInformation.dtCurrentLossInformationSubRowChangeEvent((dsCurrentLossInformation.dtCurrentLossInformationSubRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtCurrentLossInformationSubRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCurrentLossInformation.dtCurrentLossInformationSubRowChangeEventHandler rowDeletingEvent = this.dtCurrentLossInformationSubRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCurrentLossInformation.dtCurrentLossInformationSubRowChangeEvent((dsCurrentLossInformation.dtCurrentLossInformationSubRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovedtCurrentLossInformationSubRow(
      dsCurrentLossInformation.dtCurrentLossInformationSubRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCurrentLossInformation currentLossInformation = new dsCurrentLossInformation();
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
        FixedValue = currentLossInformation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtCurrentLossInformationSubDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = currentLossInformation.GetSchemaSerializable();
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

    private void dtCurrentLossInformationSubDataTable_ColumnChanging(
      object sender,
      DataColumnChangeEventArgs e)
    {
      Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Column.ColumnName, this.ControlNoColumn.ColumnName, false);
    }
  }

  public class dtCurrentLossInformationRow : DataRow
  {
    private dsCurrentLossInformation.dtCurrentLossInformationDataTable tabledtCurrentLossInformation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal dtCurrentLossInformationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtCurrentLossInformation = (dsCurrentLossInformation.dtCurrentLossInformationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ControlNo
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledtCurrentLossInformation.ControlNoColumn]);
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsControlNoNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.ControlNoColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetControlNoNull()
    {
      this[this.tabledtCurrentLossInformation.ControlNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyNumberNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.PolicyNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tabledtCurrentLossInformation.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLineNameNull() => this.IsNull(this.tabledtCurrentLossInformation.LineNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLineNameNull()
    {
      this[this.tabledtCurrentLossInformation.LineNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTotalPaidNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.TotalPaidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTotalPaidNull()
    {
      this[this.tabledtCurrentLossInformation.TotalPaidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTotalReservesNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.TotalReservesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTotalReservesNull()
    {
      this[this.tabledtCurrentLossInformation.TotalReservesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTotalRecoveryNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.TotalRecoveryColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTotalRecoveryNull()
    {
      this[this.tabledtCurrentLossInformation.TotalRecoveryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTotalIncurredNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.TotalIncurredColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTotalIncurredNull()
    {
      this[this.tabledtCurrentLossInformation.TotalIncurredColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredNameNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.InsuredNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredNameNull()
    {
      this[this.tabledtCurrentLossInformation.InsuredNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tabledtCurrentLossInformation.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tabledtCurrentLossInformation.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLossRatioNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.LossRatioColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLossRatioNull()
    {
      this[this.tabledtCurrentLossInformation.LossRatioColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEarnedPremiumNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.EarnedPremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEarnedPremiumNull()
    {
      this[this.tabledtCurrentLossInformation.EarnedPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEarnedPremiumLossRatioNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformation.EarnedPremiumLossRatioColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEarnedPremiumLossRatioNull()
    {
      this[this.tabledtCurrentLossInformation.EarnedPremiumLossRatioColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCurrentLossInformation.dtCurrentLossInformationSubRow[] GetdtCurrentLossInformationSubRows()
    {
      return this.Table.ChildRelations["FK_dtCurrentLossInformation_dtCurrentLossInformationSub"] != null ? (dsCurrentLossInformation.dtCurrentLossInformationSubRow[]) this.GetChildRows(this.Table.ChildRelations["FK_dtCurrentLossInformation_dtCurrentLossInformationSub"]) : new dsCurrentLossInformation.dtCurrentLossInformationSubRow[0];
    }
  }

  public class dtCurrentLossInformationSubRow : DataRow
  {
    private dsCurrentLossInformation.dtCurrentLossInformationSubDataTable tabledtCurrentLossInformationSub;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal dtCurrentLossInformationSubRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtCurrentLossInformationSub = (dsCurrentLossInformation.dtCurrentLossInformationSubDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ControlNo
    {
      get => Conversions.ToInteger(this[this.tabledtCurrentLossInformationSub.ControlNoColumn]);
      set => this[this.tabledtCurrentLossInformationSub.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal GrossIndemnityPaid
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.GrossIndemnityPaidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GrossIndemnityPaid' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.GrossIndemnityPaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal GrossIndemnityReserve
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.GrossIndemnityReserveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GrossIndemnityReserve' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabledtCurrentLossInformationSub.GrossIndemnityReserveColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal LegalReserve
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.LegalReserveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LegalReserve' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.LegalReserveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal LegalPaid
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.LegalPaidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LegalPaid' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.LegalPaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal LAEReserve
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.LAEReserveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LAEReserve' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.LAEReserveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal LAEPaid
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.LAEPaidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LAEPaid' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.LAEPaidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal DeductibleRecovery
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.DeductibleRecoveryColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeductibleRecovery' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.DeductibleRecoveryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal OtherRecovery
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.OtherRecoveryColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OtherRecovery' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.OtherRecoveryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal NetIncurred
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtCurrentLossInformationSub.NetIncurredColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NetIncurred' in table 'dtCurrentLossInformationSub' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtCurrentLossInformationSub.NetIncurredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCurrentLossInformation.dtCurrentLossInformationRow dtCurrentLossInformationRow
    {
      get
      {
        return (dsCurrentLossInformation.dtCurrentLossInformationRow) this.GetParentRow(this.Table.ParentRelations["FK_dtCurrentLossInformation_dtCurrentLossInformationSub"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["FK_dtCurrentLossInformation_dtCurrentLossInformationSub"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyNumberNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.PolicyNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tabledtCurrentLossInformationSub.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLineNameNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.LineNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLineNameNull()
    {
      this[this.tabledtCurrentLossInformationSub.LineNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEffectiveDateNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.EffectiveDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tabledtCurrentLossInformationSub.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsExpirationDateNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.ExpirationDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetExpirationDateNull()
    {
      this[this.tabledtCurrentLossInformationSub.ExpirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClaimNoNull() => this.IsNull(this.tabledtCurrentLossInformationSub.ClaimNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClaimNoNull()
    {
      this[this.tabledtCurrentLossInformationSub.ClaimNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateReportedNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.DateReportedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateReportedNull()
    {
      this[this.tabledtCurrentLossInformationSub.DateReportedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLossDateNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.LossDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLossDateNull()
    {
      this[this.tabledtCurrentLossInformationSub.LossDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStatusNull() => this.IsNull(this.tabledtCurrentLossInformationSub.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatusNull()
    {
      this[this.tabledtCurrentLossInformationSub.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDescriptionInjuryNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.DescriptionInjuryColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDescriptionInjuryNull()
    {
      this[this.tabledtCurrentLossInformationSub.DescriptionInjuryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsGrossIndemnityPaidNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.GrossIndemnityPaidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetGrossIndemnityPaidNull()
    {
      this[this.tabledtCurrentLossInformationSub.GrossIndemnityPaidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsGrossIndemnityReserveNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.GrossIndemnityReserveColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetGrossIndemnityReserveNull()
    {
      this[this.tabledtCurrentLossInformationSub.GrossIndemnityReserveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredNameNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.InsuredNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredNameNull()
    {
      this[this.tabledtCurrentLossInformationSub.InsuredNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLegalReserveNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.LegalReserveColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLegalReserveNull()
    {
      this[this.tabledtCurrentLossInformationSub.LegalReserveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLegalPaidNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.LegalPaidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLegalPaidNull()
    {
      this[this.tabledtCurrentLossInformationSub.LegalPaidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTotalRecoveryNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.TotalRecoveryColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTotalRecoveryNull()
    {
      this[this.tabledtCurrentLossInformationSub.TotalRecoveryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTotalReservesNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.TotalReservesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTotalReservesNull()
    {
      this[this.tabledtCurrentLossInformationSub.TotalReservesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClaimIDNull() => this.IsNull(this.tabledtCurrentLossInformationSub.ClaimIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClaimIDNull()
    {
      this[this.tabledtCurrentLossInformationSub.ClaimIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLAEReserveNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.LAEReserveColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLAEReserveNull()
    {
      this[this.tabledtCurrentLossInformationSub.LAEReserveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLAEPaidNull() => this.IsNull(this.tabledtCurrentLossInformationSub.LAEPaidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLAEPaidNull()
    {
      this[this.tabledtCurrentLossInformationSub.LAEPaidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDeductibleRecoveryNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.DeductibleRecoveryColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDeductibleRecoveryNull()
    {
      this[this.tabledtCurrentLossInformationSub.DeductibleRecoveryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOtherRecoveryNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.OtherRecoveryColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOtherRecoveryNull()
    {
      this[this.tabledtCurrentLossInformationSub.OtherRecoveryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNetIncurredNull()
    {
      return this.IsNull(this.tabledtCurrentLossInformationSub.NetIncurredColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNetIncurredNull()
    {
      this[this.tabledtCurrentLossInformationSub.NetIncurredColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class dtCurrentLossInformationRowChangeEvent : EventArgs
  {
    private dsCurrentLossInformation.dtCurrentLossInformationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dtCurrentLossInformationRowChangeEvent(
      dsCurrentLossInformation.dtCurrentLossInformationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCurrentLossInformation.dtCurrentLossInformationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class dtCurrentLossInformationSubRowChangeEvent : EventArgs
  {
    private dsCurrentLossInformation.dtCurrentLossInformationSubRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dtCurrentLossInformationSubRowChangeEvent(
      dsCurrentLossInformation.dtCurrentLossInformationSubRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCurrentLossInformation.dtCurrentLossInformationSubRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
