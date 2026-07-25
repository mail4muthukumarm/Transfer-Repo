// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Endorsements.dsEndorsementInfo
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
namespace MGASystems.IMS.Policies.Endorsements;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsEndorsementInfo")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsEndorsementInfo : DataSet
{
  private dsEndorsementInfo.tblEndorsementInfoDataTable tabletblEndorsementInfo;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsEndorsementInfo()
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
  protected dsEndorsementInfo(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblEndorsementInfo)] != null)
          base.Tables.Add((DataTable) new dsEndorsementInfo.tblEndorsementInfoDataTable(dataSet.Tables[nameof (tblEndorsementInfo)]));
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
  public dsEndorsementInfo.tblEndorsementInfoDataTable tblEndorsementInfo
  {
    get => this.tabletblEndorsementInfo;
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
    dsEndorsementInfo dsEndorsementInfo = (dsEndorsementInfo) base.Clone();
    dsEndorsementInfo.InitVars();
    dsEndorsementInfo.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsEndorsementInfo;
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
      if (dataSet.Tables["tblEndorsementInfo"] != null)
        base.Tables.Add((DataTable) new dsEndorsementInfo.tblEndorsementInfoDataTable(dataSet.Tables["tblEndorsementInfo"]));
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
    this.tabletblEndorsementInfo = (dsEndorsementInfo.tblEndorsementInfoDataTable) base.Tables["tblEndorsementInfo"];
    if (!initTable || this.tabletblEndorsementInfo == null)
      return;
    this.tabletblEndorsementInfo.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsEndorsementInfo);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsEndorsementInfo.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblEndorsementInfo = new dsEndorsementInfo.tblEndorsementInfoDataTable();
    base.Tables.Add((DataTable) this.tabletblEndorsementInfo);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblEndorsementInfo() => false;

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
    dsEndorsementInfo dsEndorsementInfo = new dsEndorsementInfo();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsEndorsementInfo.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsEndorsementInfo.GetSchemaSerializable();
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
  public delegate void tblEndorsementInfoRowChangeEventHandler(
    object sender,
    dsEndorsementInfo.tblEndorsementInfoRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblEndorsementInfoDataTable : TypedTableBase<dsEndorsementInfo.tblEndorsementInfoRow>
  {
    private DataColumn columnQuoteID;
    private DataColumn columnPolicyIs;
    private DataColumn columnPolicyIsText;
    private DataColumn columnPolicySchedule;
    private DataColumn columnPolicyScheduleText;
    private DataColumn columnNamedInsuredAmended;
    private DataColumn columnPolicyTermAmended;
    private DataColumn columnEndorsementVoid;
    private DataColumn columnEndorsementVoidNum;
    private DataColumn columnDescriptionOfItems;
    private DataColumn columnLimitsChanged;
    private DataColumn columnOther;
    private DataColumn columnEndorsementText;
    private DataColumn columnInsuredMailingAddress;
    private DataColumn columnPolicyReinstated;
    private DataColumn columnInsuredName;
    private DataColumn columnInsuredLegalStatus;
    private DataColumn columnAdditionalInterestedParties;
    private DataColumn columnCoverageFormsAndEndorsements;
    private DataColumn columnLimitsExposures;
    private DataColumn columnDeductibles;
    private DataColumn columnCoveredPropertyLocationDesc;
    private DataColumn columnCoveragePartsAffected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblEndorsementInfoDataTable()
    {
      this.TableName = "tblEndorsementInfo";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblEndorsementInfoDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected tblEndorsementInfoDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyIsColumn => this.columnPolicyIs;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyIsTextColumn => this.columnPolicyIsText;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyScheduleColumn => this.columnPolicySchedule;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyScheduleTextColumn => this.columnPolicyScheduleText;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NamedInsuredAmendedColumn => this.columnNamedInsuredAmended;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyTermAmendedColumn => this.columnPolicyTermAmended;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EndorsementVoidColumn => this.columnEndorsementVoid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EndorsementVoidNumColumn => this.columnEndorsementVoidNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionOfItemsColumn => this.columnDescriptionOfItems;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LimitsChangedColumn => this.columnLimitsChanged;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OtherColumn => this.columnOther;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EndorsementTextColumn => this.columnEndorsementText;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredMailingAddressColumn => this.columnInsuredMailingAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyReinstatedColumn => this.columnPolicyReinstated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredNameColumn => this.columnInsuredName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredLegalStatusColumn => this.columnInsuredLegalStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AdditionalInterestedPartiesColumn => this.columnAdditionalInterestedParties;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoverageFormsAndEndorsementsColumn => this.columnCoverageFormsAndEndorsements;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LimitsExposuresColumn => this.columnLimitsExposures;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DeductiblesColumn => this.columnDeductibles;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoveredPropertyLocationDescColumn => this.columnCoveredPropertyLocationDesc;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoveragePartsAffectedColumn => this.columnCoveragePartsAffected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsEndorsementInfo.tblEndorsementInfoRow this[int index]
    {
      get => (dsEndorsementInfo.tblEndorsementInfoRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsEndorsementInfo.tblEndorsementInfoRowChangeEventHandler tblEndorsementInfoRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsEndorsementInfo.tblEndorsementInfoRowChangeEventHandler tblEndorsementInfoRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsEndorsementInfo.tblEndorsementInfoRowChangeEventHandler tblEndorsementInfoRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsEndorsementInfo.tblEndorsementInfoRowChangeEventHandler tblEndorsementInfoRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblEndorsementInfoRow(dsEndorsementInfo.tblEndorsementInfoRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsEndorsementInfo.tblEndorsementInfoRow AddtblEndorsementInfoRow(
      int QuoteID,
      bool PolicyIs,
      string PolicyIsText,
      bool PolicySchedule,
      string PolicyScheduleText,
      bool NamedInsuredAmended,
      bool PolicyTermAmended,
      bool EndorsementVoid,
      string EndorsementVoidNum,
      bool DescriptionOfItems,
      bool LimitsChanged,
      bool Other,
      string EndorsementText,
      bool InsuredMailingAddress,
      bool PolicyReinstated,
      bool InsuredName,
      bool InsuredLegalStatus,
      bool AdditionalInterestedParties,
      bool CoverageFormsAndEndorsements,
      bool LimitsExposures,
      bool Deductibles,
      bool CoveredPropertyLocationDesc,
      string CoveragePartsAffected)
    {
      dsEndorsementInfo.tblEndorsementInfoRow row = (dsEndorsementInfo.tblEndorsementInfoRow) this.NewRow();
      object[] objArray = new object[23]
      {
        (object) QuoteID,
        (object) PolicyIs,
        (object) PolicyIsText,
        (object) PolicySchedule,
        (object) PolicyScheduleText,
        (object) NamedInsuredAmended,
        (object) PolicyTermAmended,
        (object) EndorsementVoid,
        (object) EndorsementVoidNum,
        (object) DescriptionOfItems,
        (object) LimitsChanged,
        (object) Other,
        (object) EndorsementText,
        (object) InsuredMailingAddress,
        (object) PolicyReinstated,
        (object) InsuredName,
        (object) InsuredLegalStatus,
        (object) AdditionalInterestedParties,
        (object) CoverageFormsAndEndorsements,
        (object) LimitsExposures,
        (object) Deductibles,
        (object) CoveredPropertyLocationDesc,
        (object) CoveragePartsAffected
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsEndorsementInfo.tblEndorsementInfoRow FindByQuoteID(int QuoteID)
    {
      return (dsEndorsementInfo.tblEndorsementInfoRow) this.Rows.Find(new object[1]
      {
        (object) QuoteID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsEndorsementInfo.tblEndorsementInfoDataTable endorsementInfoDataTable = (dsEndorsementInfo.tblEndorsementInfoDataTable) base.Clone();
      endorsementInfoDataTable.InitVars();
      return (DataTable) endorsementInfoDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsEndorsementInfo.tblEndorsementInfoDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnPolicyIs = this.Columns["PolicyIs"];
      this.columnPolicyIsText = this.Columns["PolicyIsText"];
      this.columnPolicySchedule = this.Columns["PolicySchedule"];
      this.columnPolicyScheduleText = this.Columns["PolicyScheduleText"];
      this.columnNamedInsuredAmended = this.Columns["NamedInsuredAmended"];
      this.columnPolicyTermAmended = this.Columns["PolicyTermAmended"];
      this.columnEndorsementVoid = this.Columns["EndorsementVoid"];
      this.columnEndorsementVoidNum = this.Columns["EndorsementVoidNum"];
      this.columnDescriptionOfItems = this.Columns["DescriptionOfItems"];
      this.columnLimitsChanged = this.Columns["LimitsChanged"];
      this.columnOther = this.Columns["Other"];
      this.columnEndorsementText = this.Columns["EndorsementText"];
      this.columnInsuredMailingAddress = this.Columns["InsuredMailingAddress"];
      this.columnPolicyReinstated = this.Columns["PolicyReinstated"];
      this.columnInsuredName = this.Columns["InsuredName"];
      this.columnInsuredLegalStatus = this.Columns["InsuredLegalStatus"];
      this.columnAdditionalInterestedParties = this.Columns["AdditionalInterestedParties"];
      this.columnCoverageFormsAndEndorsements = this.Columns["CoverageFormsAndEndorsements"];
      this.columnLimitsExposures = this.Columns["LimitsExposures"];
      this.columnDeductibles = this.Columns["Deductibles"];
      this.columnCoveredPropertyLocationDesc = this.Columns["CoveredPropertyLocationDesc"];
      this.columnCoveragePartsAffected = this.Columns["CoveragePartsAffected"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnPolicyIs = new DataColumn("PolicyIs", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyIs);
      this.columnPolicyIsText = new DataColumn("PolicyIsText", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyIsText);
      this.columnPolicySchedule = new DataColumn("PolicySchedule", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicySchedule);
      this.columnPolicyScheduleText = new DataColumn("PolicyScheduleText", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyScheduleText);
      this.columnNamedInsuredAmended = new DataColumn("NamedInsuredAmended", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNamedInsuredAmended);
      this.columnPolicyTermAmended = new DataColumn("PolicyTermAmended", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyTermAmended);
      this.columnEndorsementVoid = new DataColumn("EndorsementVoid", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementVoid);
      this.columnEndorsementVoidNum = new DataColumn("EndorsementVoidNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementVoidNum);
      this.columnDescriptionOfItems = new DataColumn("DescriptionOfItems", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescriptionOfItems);
      this.columnLimitsChanged = new DataColumn("LimitsChanged", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLimitsChanged);
      this.columnOther = new DataColumn("Other", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOther);
      this.columnEndorsementText = new DataColumn("EndorsementText", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementText);
      this.columnInsuredMailingAddress = new DataColumn("InsuredMailingAddress", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredMailingAddress);
      this.columnPolicyReinstated = new DataColumn("PolicyReinstated", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyReinstated);
      this.columnInsuredName = new DataColumn("InsuredName", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredName);
      this.columnInsuredLegalStatus = new DataColumn("InsuredLegalStatus", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredLegalStatus);
      this.columnAdditionalInterestedParties = new DataColumn("AdditionalInterestedParties", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalInterestedParties);
      this.columnCoverageFormsAndEndorsements = new DataColumn("CoverageFormsAndEndorsements", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageFormsAndEndorsements);
      this.columnLimitsExposures = new DataColumn("LimitsExposures", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLimitsExposures);
      this.columnDeductibles = new DataColumn("Deductibles", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductibles);
      this.columnCoveredPropertyLocationDesc = new DataColumn("CoveredPropertyLocationDesc", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoveredPropertyLocationDesc);
      this.columnCoveragePartsAffected = new DataColumn("CoveragePartsAffected", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoveragePartsAffected);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnQuoteID
      }, true));
      this.columnQuoteID.AllowDBNull = false;
      this.columnQuoteID.Unique = true;
      this.columnPolicyIs.AllowDBNull = false;
      this.columnPolicyIs.DefaultValue = (object) false;
      this.columnPolicyIsText.MaxLength = 50;
      this.columnPolicySchedule.AllowDBNull = false;
      this.columnPolicySchedule.DefaultValue = (object) false;
      this.columnPolicyScheduleText.MaxLength = 50;
      this.columnNamedInsuredAmended.AllowDBNull = false;
      this.columnNamedInsuredAmended.DefaultValue = (object) false;
      this.columnPolicyTermAmended.AllowDBNull = false;
      this.columnPolicyTermAmended.DefaultValue = (object) false;
      this.columnEndorsementVoid.AllowDBNull = false;
      this.columnEndorsementVoid.DefaultValue = (object) false;
      this.columnDescriptionOfItems.AllowDBNull = false;
      this.columnDescriptionOfItems.DefaultValue = (object) false;
      this.columnLimitsChanged.AllowDBNull = false;
      this.columnLimitsChanged.DefaultValue = (object) false;
      this.columnOther.AllowDBNull = false;
      this.columnOther.DefaultValue = (object) false;
      this.columnInsuredMailingAddress.AllowDBNull = false;
      this.columnInsuredMailingAddress.DefaultValue = (object) false;
      this.columnPolicyReinstated.AllowDBNull = false;
      this.columnPolicyReinstated.DefaultValue = (object) false;
      this.columnInsuredName.AllowDBNull = false;
      this.columnInsuredName.DefaultValue = (object) false;
      this.columnInsuredLegalStatus.AllowDBNull = false;
      this.columnInsuredLegalStatus.DefaultValue = (object) false;
      this.columnAdditionalInterestedParties.AllowDBNull = false;
      this.columnAdditionalInterestedParties.DefaultValue = (object) false;
      this.columnCoverageFormsAndEndorsements.AllowDBNull = false;
      this.columnCoverageFormsAndEndorsements.DefaultValue = (object) false;
      this.columnLimitsExposures.AllowDBNull = false;
      this.columnLimitsExposures.DefaultValue = (object) false;
      this.columnDeductibles.AllowDBNull = false;
      this.columnDeductibles.DefaultValue = (object) false;
      this.columnCoveredPropertyLocationDesc.AllowDBNull = false;
      this.columnCoveredPropertyLocationDesc.DefaultValue = (object) false;
      this.columnCoveragePartsAffected.MaxLength = 300;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsEndorsementInfo.tblEndorsementInfoRow NewtblEndorsementInfoRow()
    {
      return (dsEndorsementInfo.tblEndorsementInfoRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsEndorsementInfo.tblEndorsementInfoRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsEndorsementInfo.tblEndorsementInfoRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEndorsementInfoRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsEndorsementInfo.tblEndorsementInfoRowChangeEventHandler infoRowChangedEvent = this.tblEndorsementInfoRowChangedEvent;
      if (infoRowChangedEvent == null)
        return;
      infoRowChangedEvent((object) this, new dsEndorsementInfo.tblEndorsementInfoRowChangeEvent((dsEndorsementInfo.tblEndorsementInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEndorsementInfoRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsEndorsementInfo.tblEndorsementInfoRowChangeEventHandler rowChangingEvent = this.tblEndorsementInfoRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsEndorsementInfo.tblEndorsementInfoRowChangeEvent((dsEndorsementInfo.tblEndorsementInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEndorsementInfoRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsEndorsementInfo.tblEndorsementInfoRowChangeEventHandler infoRowDeletedEvent = this.tblEndorsementInfoRowDeletedEvent;
      if (infoRowDeletedEvent == null)
        return;
      infoRowDeletedEvent((object) this, new dsEndorsementInfo.tblEndorsementInfoRowChangeEvent((dsEndorsementInfo.tblEndorsementInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEndorsementInfoRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsEndorsementInfo.tblEndorsementInfoRowChangeEventHandler rowDeletingEvent = this.tblEndorsementInfoRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsEndorsementInfo.tblEndorsementInfoRowChangeEvent((dsEndorsementInfo.tblEndorsementInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblEndorsementInfoRow(dsEndorsementInfo.tblEndorsementInfoRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsEndorsementInfo dsEndorsementInfo = new dsEndorsementInfo();
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
        FixedValue = dsEndorsementInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblEndorsementInfoDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsEndorsementInfo.GetSchemaSerializable();
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

  public class tblEndorsementInfoRow : DataRow
  {
    private dsEndorsementInfo.tblEndorsementInfoDataTable tabletblEndorsementInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblEndorsementInfoRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblEndorsementInfo = (dsEndorsementInfo.tblEndorsementInfoDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tabletblEndorsementInfo.QuoteIDColumn]);
      set => this[this.tabletblEndorsementInfo.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool PolicyIs
    {
      get => Conversions.ToBoolean(this[this.tabletblEndorsementInfo.PolicyIsColumn]);
      set => this[this.tabletblEndorsementInfo.PolicyIsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyIsText
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblEndorsementInfo.PolicyIsTextColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyIsText' in table 'tblEndorsementInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEndorsementInfo.PolicyIsTextColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool PolicySchedule
    {
      get => Conversions.ToBoolean(this[this.tabletblEndorsementInfo.PolicyScheduleColumn]);
      set => this[this.tabletblEndorsementInfo.PolicyScheduleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyScheduleText
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblEndorsementInfo.PolicyScheduleTextColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyScheduleText' in table 'tblEndorsementInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEndorsementInfo.PolicyScheduleTextColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool NamedInsuredAmended
    {
      get => Conversions.ToBoolean(this[this.tabletblEndorsementInfo.NamedInsuredAmendedColumn]);
      set => this[this.tabletblEndorsementInfo.NamedInsuredAmendedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool PolicyTermAmended
    {
      get => Conversions.ToBoolean(this[this.tabletblEndorsementInfo.PolicyTermAmendedColumn]);
      set => this[this.tabletblEndorsementInfo.PolicyTermAmendedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool EndorsementVoid
    {
      get => Conversions.ToBoolean(this[this.tabletblEndorsementInfo.EndorsementVoidColumn]);
      set => this[this.tabletblEndorsementInfo.EndorsementVoidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EndorsementVoidNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblEndorsementInfo.EndorsementVoidNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementVoidNum' in table 'tblEndorsementInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEndorsementInfo.EndorsementVoidNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool DescriptionOfItems
    {
      get => Conversions.ToBoolean(this[this.tabletblEndorsementInfo.DescriptionOfItemsColumn]);
      set => this[this.tabletblEndorsementInfo.DescriptionOfItemsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool LimitsChanged
    {
      get => Conversions.ToBoolean(this[this.tabletblEndorsementInfo.LimitsChangedColumn]);
      set => this[this.tabletblEndorsementInfo.LimitsChangedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Other
    {
      get => Conversions.ToBoolean(this[this.tabletblEndorsementInfo.OtherColumn]);
      set => this[this.tabletblEndorsementInfo.OtherColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EndorsementText
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblEndorsementInfo.EndorsementTextColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementText' in table 'tblEndorsementInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEndorsementInfo.EndorsementTextColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool InsuredMailingAddress
    {
      get => Conversions.ToBoolean(this[this.tabletblEndorsementInfo.InsuredMailingAddressColumn]);
      set => this[this.tabletblEndorsementInfo.InsuredMailingAddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool PolicyReinstated
    {
      get => Conversions.ToBoolean(this[this.tabletblEndorsementInfo.PolicyReinstatedColumn]);
      set => this[this.tabletblEndorsementInfo.PolicyReinstatedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool InsuredName
    {
      get => Conversions.ToBoolean(this[this.tabletblEndorsementInfo.InsuredNameColumn]);
      set => this[this.tabletblEndorsementInfo.InsuredNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool InsuredLegalStatus
    {
      get => Conversions.ToBoolean(this[this.tabletblEndorsementInfo.InsuredLegalStatusColumn]);
      set => this[this.tabletblEndorsementInfo.InsuredLegalStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AdditionalInterestedParties
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblEndorsementInfo.AdditionalInterestedPartiesColumn]);
      }
      set => this[this.tabletblEndorsementInfo.AdditionalInterestedPartiesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool CoverageFormsAndEndorsements
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblEndorsementInfo.CoverageFormsAndEndorsementsColumn]);
      }
      set => this[this.tabletblEndorsementInfo.CoverageFormsAndEndorsementsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool LimitsExposures
    {
      get => Conversions.ToBoolean(this[this.tabletblEndorsementInfo.LimitsExposuresColumn]);
      set => this[this.tabletblEndorsementInfo.LimitsExposuresColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Deductibles
    {
      get => Conversions.ToBoolean(this[this.tabletblEndorsementInfo.DeductiblesColumn]);
      set => this[this.tabletblEndorsementInfo.DeductiblesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool CoveredPropertyLocationDesc
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblEndorsementInfo.CoveredPropertyLocationDescColumn]);
      }
      set => this[this.tabletblEndorsementInfo.CoveredPropertyLocationDescColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CoveragePartsAffected
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblEndorsementInfo.CoveragePartsAffectedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CoveragePartsAffected' in table 'tblEndorsementInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEndorsementInfo.CoveragePartsAffectedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyIsTextNull()
    {
      return this.IsNull(this.tabletblEndorsementInfo.PolicyIsTextColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyIsTextNull()
    {
      this[this.tabletblEndorsementInfo.PolicyIsTextColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyScheduleTextNull()
    {
      return this.IsNull(this.tabletblEndorsementInfo.PolicyScheduleTextColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyScheduleTextNull()
    {
      this[this.tabletblEndorsementInfo.PolicyScheduleTextColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEndorsementVoidNumNull()
    {
      return this.IsNull(this.tabletblEndorsementInfo.EndorsementVoidNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEndorsementVoidNumNull()
    {
      this[this.tabletblEndorsementInfo.EndorsementVoidNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEndorsementTextNull()
    {
      return this.IsNull(this.tabletblEndorsementInfo.EndorsementTextColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEndorsementTextNull()
    {
      this[this.tabletblEndorsementInfo.EndorsementTextColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCoveragePartsAffectedNull()
    {
      return this.IsNull(this.tabletblEndorsementInfo.CoveragePartsAffectedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCoveragePartsAffectedNull()
    {
      this[this.tabletblEndorsementInfo.CoveragePartsAffectedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblEndorsementInfoRowChangeEvent : EventArgs
  {
    private dsEndorsementInfo.tblEndorsementInfoRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblEndorsementInfoRowChangeEvent(
      dsEndorsementInfo.tblEndorsementInfoRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsEndorsementInfo.tblEndorsementInfoRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
