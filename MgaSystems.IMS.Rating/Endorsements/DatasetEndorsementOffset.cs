// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.Endorsements.DatasetEndorsementOffset
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

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
namespace MGASystems.IMS.Policies.Rating.Endorsements;

[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("DatasetEndorsementOffset")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class DatasetEndorsementOffset : DataSet
{
  private DatasetEndorsementOffset.PremiumsDataTable tablePremiums;
  private DatasetEndorsementOffset.FeesDataTable tableFees;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  public DatasetEndorsementOffset()
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
  protected DatasetEndorsementOffset(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (Premiums)] != null)
          base.Tables.Add((DataTable) new DatasetEndorsementOffset.PremiumsDataTable(dataSet.Tables[nameof (Premiums)]));
        if (dataSet.Tables[nameof (Fees)] != null)
          base.Tables.Add((DataTable) new DatasetEndorsementOffset.FeesDataTable(dataSet.Tables[nameof (Fees)]));
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
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public DatasetEndorsementOffset.PremiumsDataTable Premiums => this.tablePremiums;

  [DebuggerNonUserCode]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public DatasetEndorsementOffset.FeesDataTable Fees => this.tableFees;

  [DebuggerNonUserCode]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  public override DataSet Clone()
  {
    DatasetEndorsementOffset endorsementOffset = (DatasetEndorsementOffset) base.Clone();
    endorsementOffset.InitVars();
    endorsementOffset.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) endorsementOffset;
  }

  [DebuggerNonUserCode]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["Premiums"] != null)
        base.Tables.Add((DataTable) new DatasetEndorsementOffset.PremiumsDataTable(dataSet.Tables["Premiums"]));
      if (dataSet.Tables["Fees"] != null)
        base.Tables.Add((DataTable) new DatasetEndorsementOffset.FeesDataTable(dataSet.Tables["Fees"]));
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
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  internal void InitVars(bool initTable)
  {
    this.tablePremiums = (DatasetEndorsementOffset.PremiumsDataTable) base.Tables["Premiums"];
    if (initTable && this.tablePremiums != null)
      this.tablePremiums.InitVars();
    this.tableFees = (DatasetEndorsementOffset.FeesDataTable) base.Tables["Fees"];
    if (!initTable || this.tableFees == null)
      return;
    this.tableFees.InitVars();
  }

  [DebuggerNonUserCode]
  private void InitClass()
  {
    this.DataSetName = nameof (DatasetEndorsementOffset);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/DatasetEndorsementOffset.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablePremiums = new DatasetEndorsementOffset.PremiumsDataTable();
    base.Tables.Add((DataTable) this.tablePremiums);
    this.tableFees = new DatasetEndorsementOffset.FeesDataTable();
    base.Tables.Add((DataTable) this.tableFees);
  }

  [DebuggerNonUserCode]
  private bool ShouldSerializePremiums() => false;

  [DebuggerNonUserCode]
  private bool ShouldSerializeFees() => false;

  [DebuggerNonUserCode]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    DatasetEndorsementOffset endorsementOffset = new DatasetEndorsementOffset();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = endorsementOffset.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = endorsementOffset.GetSchemaSerializable();
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

  public delegate void PremiumsRowChangeEventHandler(
    object sender,
    DatasetEndorsementOffset.PremiumsRowChangeEvent e);

  public delegate void FeesRowChangeEventHandler(
    object sender,
    DatasetEndorsementOffset.FeesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class PremiumsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnChargeCode;
    private DataColumn columnOfficeID;
    private DataColumn columnPremium;
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnNewAmount;
    private DataColumn columnChargeName;

    [DebuggerNonUserCode]
    public PremiumsDataTable()
    {
      this.TableName = "Premiums";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    internal PremiumsDataTable(DataTable table)
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
    protected PremiumsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    public DataColumn NewAmountColumn => this.columnNewAmount;

    [DebuggerNonUserCode]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    public DatasetEndorsementOffset.PremiumsRow this[int index]
    {
      get => (DatasetEndorsementOffset.PremiumsRow) this.Rows[index];
    }

    public event DatasetEndorsementOffset.PremiumsRowChangeEventHandler PremiumsRowChanging;

    public event DatasetEndorsementOffset.PremiumsRowChangeEventHandler PremiumsRowChanged;

    public event DatasetEndorsementOffset.PremiumsRowChangeEventHandler PremiumsRowDeleting;

    public event DatasetEndorsementOffset.PremiumsRowChangeEventHandler PremiumsRowDeleted;

    [DebuggerNonUserCode]
    public void AddPremiumsRow(DatasetEndorsementOffset.PremiumsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    public DatasetEndorsementOffset.PremiumsRow AddPremiumsRow(
      int ChargeCode,
      int OfficeID,
      Decimal Premium,
      Guid CompanyLineGuid,
      Decimal NewAmount,
      string ChargeName)
    {
      DatasetEndorsementOffset.PremiumsRow row = (DatasetEndorsementOffset.PremiumsRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) ChargeCode,
        (object) OfficeID,
        (object) Premium,
        (object) CompanyLineGuid,
        (object) NewAmount,
        (object) ChargeName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    [DebuggerNonUserCode]
    public override DataTable Clone()
    {
      DatasetEndorsementOffset.PremiumsDataTable premiumsDataTable = (DatasetEndorsementOffset.PremiumsDataTable) base.Clone();
      premiumsDataTable.InitVars();
      return (DataTable) premiumsDataTable;
    }

    [DebuggerNonUserCode]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new DatasetEndorsementOffset.PremiumsDataTable();
    }

    [DebuggerNonUserCode]
    internal void InitVars()
    {
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnPremium = this.Columns["Premium"];
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnNewAmount = this.Columns["NewAmount"];
      this.columnChargeName = this.Columns["ChargeName"];
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnNewAmount = new DataColumn("NewAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNewAmount);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnChargeCode.AllowDBNull = false;
      this.columnOfficeID.AllowDBNull = false;
      this.columnPremium.ReadOnly = true;
      this.columnCompanyLineGuid.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    public DatasetEndorsementOffset.PremiumsRow NewPremiumsRow()
    {
      return (DatasetEndorsementOffset.PremiumsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new DatasetEndorsementOffset.PremiumsRow(builder);
    }

    [DebuggerNonUserCode]
    protected override Type GetRowType() => typeof (DatasetEndorsementOffset.PremiumsRow);

    [DebuggerNonUserCode]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PremiumsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      DatasetEndorsementOffset.PremiumsRowChangeEventHandler premiumsRowChangedEvent = this.PremiumsRowChangedEvent;
      if (premiumsRowChangedEvent == null)
        return;
      premiumsRowChangedEvent((object) this, new DatasetEndorsementOffset.PremiumsRowChangeEvent((DatasetEndorsementOffset.PremiumsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PremiumsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      DatasetEndorsementOffset.PremiumsRowChangeEventHandler rowChangingEvent = this.PremiumsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new DatasetEndorsementOffset.PremiumsRowChangeEvent((DatasetEndorsementOffset.PremiumsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PremiumsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      DatasetEndorsementOffset.PremiumsRowChangeEventHandler premiumsRowDeletedEvent = this.PremiumsRowDeletedEvent;
      if (premiumsRowDeletedEvent == null)
        return;
      premiumsRowDeletedEvent((object) this, new DatasetEndorsementOffset.PremiumsRowChangeEvent((DatasetEndorsementOffset.PremiumsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PremiumsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      DatasetEndorsementOffset.PremiumsRowChangeEventHandler rowDeletingEvent = this.PremiumsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new DatasetEndorsementOffset.PremiumsRowChangeEvent((DatasetEndorsementOffset.PremiumsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    public void RemovePremiumsRow(DatasetEndorsementOffset.PremiumsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      DatasetEndorsementOffset endorsementOffset = new DatasetEndorsementOffset();
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
        FixedValue = endorsementOffset.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PremiumsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = endorsementOffset.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class FeesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnCompanyFeeID;
    private DataColumn columnChargeCode;
    private DataColumn columnOfficeID;
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnFeeTypeID;
    private DataColumn columnPayable;
    private DataColumn columnPercentOfChargeCode;
    private DataColumn columnOriginalQuoteOptionGuid;
    private DataColumn columnFeeAmount;
    private DataColumn columnAppliesToPaymentID;
    private DataColumn columnTaxable;
    private DataColumn columnRoundToDollar;
    private DataColumn columnConvertedToManualUserGuid;
    private DataColumn columnDateFilingDue;
    private DataColumn columnDateAmountDue;
    private DataColumn columnFullyEarned;
    private DataColumn columnNewAmount;
    private DataColumn columnChargeName;

    [DebuggerNonUserCode]
    public FeesDataTable()
    {
      this.TableName = "Fees";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    internal FeesDataTable(DataTable table)
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
    protected FeesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    public DataColumn CompanyFeeIDColumn => this.columnCompanyFeeID;

    [DebuggerNonUserCode]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    public DataColumn FeeTypeIDColumn => this.columnFeeTypeID;

    [DebuggerNonUserCode]
    public DataColumn PayableColumn => this.columnPayable;

    [DebuggerNonUserCode]
    public DataColumn PercentOfChargeCodeColumn => this.columnPercentOfChargeCode;

    [DebuggerNonUserCode]
    public DataColumn OriginalQuoteOptionGuidColumn => this.columnOriginalQuoteOptionGuid;

    [DebuggerNonUserCode]
    public DataColumn FeeAmountColumn => this.columnFeeAmount;

    [DebuggerNonUserCode]
    public DataColumn AppliesToPaymentIDColumn => this.columnAppliesToPaymentID;

    [DebuggerNonUserCode]
    public DataColumn TaxableColumn => this.columnTaxable;

    [DebuggerNonUserCode]
    public DataColumn RoundToDollarColumn => this.columnRoundToDollar;

    [DebuggerNonUserCode]
    public DataColumn ConvertedToManualUserGuidColumn => this.columnConvertedToManualUserGuid;

    [DebuggerNonUserCode]
    public DataColumn DateFilingDueColumn => this.columnDateFilingDue;

    [DebuggerNonUserCode]
    public DataColumn DateAmountDueColumn => this.columnDateAmountDue;

    [DebuggerNonUserCode]
    public DataColumn FullyEarnedColumn => this.columnFullyEarned;

    [DebuggerNonUserCode]
    public DataColumn NewAmountColumn => this.columnNewAmount;

    [DebuggerNonUserCode]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    public DatasetEndorsementOffset.FeesRow this[int index]
    {
      get => (DatasetEndorsementOffset.FeesRow) this.Rows[index];
    }

    public event DatasetEndorsementOffset.FeesRowChangeEventHandler FeesRowChanging;

    public event DatasetEndorsementOffset.FeesRowChangeEventHandler FeesRowChanged;

    public event DatasetEndorsementOffset.FeesRowChangeEventHandler FeesRowDeleting;

    public event DatasetEndorsementOffset.FeesRowChangeEventHandler FeesRowDeleted;

    [DebuggerNonUserCode]
    public void AddFeesRow(DatasetEndorsementOffset.FeesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    public DatasetEndorsementOffset.FeesRow AddFeesRow(
      int CompanyFeeID,
      int ChargeCode,
      int OfficeID,
      Guid CompanyLineGuid,
      byte FeeTypeID,
      bool Payable,
      int PercentOfChargeCode,
      Guid OriginalQuoteOptionGuid,
      Decimal FeeAmount,
      string AppliesToPaymentID,
      bool Taxable,
      bool RoundToDollar,
      Guid ConvertedToManualUserGuid,
      DateTime DateFilingDue,
      DateTime DateAmountDue,
      bool FullyEarned,
      Decimal NewAmount,
      string ChargeName)
    {
      DatasetEndorsementOffset.FeesRow row = (DatasetEndorsementOffset.FeesRow) this.NewRow();
      object[] objArray = new object[18]
      {
        (object) CompanyFeeID,
        (object) ChargeCode,
        (object) OfficeID,
        (object) CompanyLineGuid,
        (object) FeeTypeID,
        (object) Payable,
        (object) PercentOfChargeCode,
        (object) OriginalQuoteOptionGuid,
        (object) FeeAmount,
        (object) AppliesToPaymentID,
        (object) Taxable,
        (object) RoundToDollar,
        (object) ConvertedToManualUserGuid,
        (object) DateFilingDue,
        (object) DateAmountDue,
        (object) FullyEarned,
        (object) NewAmount,
        (object) ChargeName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    public virtual IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    [DebuggerNonUserCode]
    public override DataTable Clone()
    {
      DatasetEndorsementOffset.FeesDataTable feesDataTable = (DatasetEndorsementOffset.FeesDataTable) base.Clone();
      feesDataTable.InitVars();
      return (DataTable) feesDataTable;
    }

    [DebuggerNonUserCode]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new DatasetEndorsementOffset.FeesDataTable();
    }

    [DebuggerNonUserCode]
    internal void InitVars()
    {
      this.columnCompanyFeeID = this.Columns["CompanyFeeID"];
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnFeeTypeID = this.Columns["FeeTypeID"];
      this.columnPayable = this.Columns["Payable"];
      this.columnPercentOfChargeCode = this.Columns["PercentOfChargeCode"];
      this.columnOriginalQuoteOptionGuid = this.Columns["OriginalQuoteOptionGuid"];
      this.columnFeeAmount = this.Columns["FeeAmount"];
      this.columnAppliesToPaymentID = this.Columns["AppliesToPaymentID"];
      this.columnTaxable = this.Columns["Taxable"];
      this.columnRoundToDollar = this.Columns["RoundToDollar"];
      this.columnConvertedToManualUserGuid = this.Columns["ConvertedToManualUserGuid"];
      this.columnDateFilingDue = this.Columns["DateFilingDue"];
      this.columnDateAmountDue = this.Columns["DateAmountDue"];
      this.columnFullyEarned = this.Columns["FullyEarned"];
      this.columnNewAmount = this.Columns["NewAmount"];
      this.columnChargeName = this.Columns["ChargeName"];
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.columnCompanyFeeID = new DataColumn("CompanyFeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyFeeID);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnFeeTypeID = new DataColumn("FeeTypeID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFeeTypeID);
      this.columnPayable = new DataColumn("Payable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayable);
      this.columnPercentOfChargeCode = new DataColumn("PercentOfChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentOfChargeCode);
      this.columnOriginalQuoteOptionGuid = new DataColumn("OriginalQuoteOptionGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOriginalQuoteOptionGuid);
      this.columnFeeAmount = new DataColumn("FeeAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFeeAmount);
      this.columnAppliesToPaymentID = new DataColumn("AppliesToPaymentID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAppliesToPaymentID);
      this.columnTaxable = new DataColumn("Taxable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxable);
      this.columnRoundToDollar = new DataColumn("RoundToDollar", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoundToDollar);
      this.columnConvertedToManualUserGuid = new DataColumn("ConvertedToManualUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConvertedToManualUserGuid);
      this.columnDateFilingDue = new DataColumn("DateFilingDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateFilingDue);
      this.columnDateAmountDue = new DataColumn("DateAmountDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateAmountDue);
      this.columnFullyEarned = new DataColumn("FullyEarned", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullyEarned);
      this.columnNewAmount = new DataColumn("NewAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNewAmount);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnCompanyFeeID.AllowDBNull = false;
      this.columnChargeCode.AllowDBNull = false;
      this.columnOfficeID.AllowDBNull = false;
      this.columnCompanyLineGuid.AllowDBNull = false;
      this.columnFeeTypeID.AllowDBNull = false;
      this.columnPayable.AllowDBNull = false;
      this.columnFeeAmount.ReadOnly = true;
      this.columnAppliesToPaymentID.AllowDBNull = false;
      this.columnAppliesToPaymentID.MaxLength = 1;
      this.columnTaxable.AllowDBNull = false;
      this.columnRoundToDollar.AllowDBNull = false;
      this.columnFullyEarned.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    public DatasetEndorsementOffset.FeesRow NewFeesRow()
    {
      return (DatasetEndorsementOffset.FeesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new DatasetEndorsementOffset.FeesRow(builder);
    }

    [DebuggerNonUserCode]
    protected override Type GetRowType() => typeof (DatasetEndorsementOffset.FeesRow);

    [DebuggerNonUserCode]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      DatasetEndorsementOffset.FeesRowChangeEventHandler feesRowChangedEvent = this.FeesRowChangedEvent;
      if (feesRowChangedEvent == null)
        return;
      feesRowChangedEvent((object) this, new DatasetEndorsementOffset.FeesRowChangeEvent((DatasetEndorsementOffset.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      DatasetEndorsementOffset.FeesRowChangeEventHandler rowChangingEvent = this.FeesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new DatasetEndorsementOffset.FeesRowChangeEvent((DatasetEndorsementOffset.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      DatasetEndorsementOffset.FeesRowChangeEventHandler feesRowDeletedEvent = this.FeesRowDeletedEvent;
      if (feesRowDeletedEvent == null)
        return;
      feesRowDeletedEvent((object) this, new DatasetEndorsementOffset.FeesRowChangeEvent((DatasetEndorsementOffset.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      DatasetEndorsementOffset.FeesRowChangeEventHandler rowDeletingEvent = this.FeesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new DatasetEndorsementOffset.FeesRowChangeEvent((DatasetEndorsementOffset.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    public void RemoveFeesRow(DatasetEndorsementOffset.FeesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      DatasetEndorsementOffset endorsementOffset = new DatasetEndorsementOffset();
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
        FixedValue = endorsementOffset.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (FeesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = endorsementOffset.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  public class PremiumsRow : DataRow
  {
    private DatasetEndorsementOffset.PremiumsDataTable tablePremiums;

    [DebuggerNonUserCode]
    internal PremiumsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePremiums = (DatasetEndorsementOffset.PremiumsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tablePremiums.ChargeCodeColumn]);
      set => this[this.tablePremiums.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public int OfficeID
    {
      get => Conversions.ToInteger(this[this.tablePremiums.OfficeIDColumn]);
      set => this[this.tablePremiums.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public Decimal Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePremiums.PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Premium' in table 'Premiums' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePremiums.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public Guid CompanyLineGuid
    {
      get
      {
        try
        {
          object obj = this[this.tablePremiums.CompanyLineGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLineGuid' in table 'Premiums' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePremiums.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public Decimal NewAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePremiums.NewAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NewAmount' in table 'Premiums' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePremiums.NewAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public string ChargeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePremiums.ChargeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeName' in table 'Premiums' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePremiums.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public bool IsPremiumNull() => this.IsNull(this.tablePremiums.PremiumColumn);

    [DebuggerNonUserCode]
    public void SetPremiumNull()
    {
      this[this.tablePremiums.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    public bool IsCompanyLineGuidNull() => this.IsNull(this.tablePremiums.CompanyLineGuidColumn);

    [DebuggerNonUserCode]
    public void SetCompanyLineGuidNull()
    {
      this[this.tablePremiums.CompanyLineGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    public bool IsNewAmountNull() => this.IsNull(this.tablePremiums.NewAmountColumn);

    [DebuggerNonUserCode]
    public void SetNewAmountNull()
    {
      this[this.tablePremiums.NewAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    public bool IsChargeNameNull() => this.IsNull(this.tablePremiums.ChargeNameColumn);

    [DebuggerNonUserCode]
    public void SetChargeNameNull()
    {
      this[this.tablePremiums.ChargeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  public class FeesRow : DataRow
  {
    private DatasetEndorsementOffset.FeesDataTable tableFees;

    [DebuggerNonUserCode]
    internal FeesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableFees = (DatasetEndorsementOffset.FeesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    public int CompanyFeeID
    {
      get => Conversions.ToInteger(this[this.tableFees.CompanyFeeIDColumn]);
      set => this[this.tableFees.CompanyFeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tableFees.ChargeCodeColumn]);
      set => this[this.tableFees.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public int OfficeID
    {
      get => Conversions.ToInteger(this[this.tableFees.OfficeIDColumn]);
      set => this[this.tableFees.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public Guid CompanyLineGuid
    {
      get
      {
        object obj = this[this.tableFees.CompanyLineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableFees.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public byte FeeTypeID
    {
      get => Conversions.ToByte(this[this.tableFees.FeeTypeIDColumn]);
      set => this[this.tableFees.FeeTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public bool Payable
    {
      get => Conversions.ToBoolean(this[this.tableFees.PayableColumn]);
      set => this[this.tableFees.PayableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public int PercentOfChargeCode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableFees.PercentOfChargeCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PercentOfChargeCode' in table 'Fees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFees.PercentOfChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public Guid OriginalQuoteOptionGuid
    {
      get
      {
        try
        {
          object obj = this[this.tableFees.OriginalQuoteOptionGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OriginalQuoteOptionGuid' in table 'Fees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFees.OriginalQuoteOptionGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public Decimal FeeAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableFees.FeeAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FeeAmount' in table 'Fees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFees.FeeAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public string AppliesToPaymentID
    {
      get => Conversions.ToString(this[this.tableFees.AppliesToPaymentIDColumn]);
      set => this[this.tableFees.AppliesToPaymentIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public bool Taxable
    {
      get => Conversions.ToBoolean(this[this.tableFees.TaxableColumn]);
      set => this[this.tableFees.TaxableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public bool RoundToDollar
    {
      get => Conversions.ToBoolean(this[this.tableFees.RoundToDollarColumn]);
      set => this[this.tableFees.RoundToDollarColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public Guid ConvertedToManualUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tableFees.ConvertedToManualUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConvertedToManualUserGuid' in table 'Fees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFees.ConvertedToManualUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public DateTime DateFilingDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableFees.DateFilingDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateFilingDue' in table 'Fees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFees.DateFilingDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public DateTime DateAmountDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableFees.DateAmountDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateAmountDue' in table 'Fees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFees.DateAmountDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public bool FullyEarned
    {
      get => Conversions.ToBoolean(this[this.tableFees.FullyEarnedColumn]);
      set => this[this.tableFees.FullyEarnedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public Decimal NewAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableFees.NewAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NewAmount' in table 'Fees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFees.NewAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public string ChargeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableFees.ChargeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeName' in table 'Fees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFees.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    public bool IsPercentOfChargeCodeNull()
    {
      return this.IsNull(this.tableFees.PercentOfChargeCodeColumn);
    }

    [DebuggerNonUserCode]
    public void SetPercentOfChargeCodeNull()
    {
      this[this.tableFees.PercentOfChargeCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    public bool IsOriginalQuoteOptionGuidNull()
    {
      return this.IsNull(this.tableFees.OriginalQuoteOptionGuidColumn);
    }

    [DebuggerNonUserCode]
    public void SetOriginalQuoteOptionGuidNull()
    {
      this[this.tableFees.OriginalQuoteOptionGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    public bool IsFeeAmountNull() => this.IsNull(this.tableFees.FeeAmountColumn);

    [DebuggerNonUserCode]
    public void SetFeeAmountNull()
    {
      this[this.tableFees.FeeAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    public bool IsConvertedToManualUserGuidNull()
    {
      return this.IsNull(this.tableFees.ConvertedToManualUserGuidColumn);
    }

    [DebuggerNonUserCode]
    public void SetConvertedToManualUserGuidNull()
    {
      this[this.tableFees.ConvertedToManualUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    public bool IsDateFilingDueNull() => this.IsNull(this.tableFees.DateFilingDueColumn);

    [DebuggerNonUserCode]
    public void SetDateFilingDueNull()
    {
      this[this.tableFees.DateFilingDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    public bool IsDateAmountDueNull() => this.IsNull(this.tableFees.DateAmountDueColumn);

    [DebuggerNonUserCode]
    public void SetDateAmountDueNull()
    {
      this[this.tableFees.DateAmountDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    public bool IsNewAmountNull() => this.IsNull(this.tableFees.NewAmountColumn);

    [DebuggerNonUserCode]
    public void SetNewAmountNull()
    {
      this[this.tableFees.NewAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    public bool IsChargeNameNull() => this.IsNull(this.tableFees.ChargeNameColumn);

    [DebuggerNonUserCode]
    public void SetChargeNameNull()
    {
      this[this.tableFees.ChargeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  public class PremiumsRowChangeEvent : EventArgs
  {
    private DatasetEndorsementOffset.PremiumsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    public PremiumsRowChangeEvent(DatasetEndorsementOffset.PremiumsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    public DatasetEndorsementOffset.PremiumsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  public class FeesRowChangeEvent : EventArgs
  {
    private DatasetEndorsementOffset.FeesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    public FeesRowChangeEvent(DatasetEndorsementOffset.FeesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    public DatasetEndorsementOffset.FeesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    public DataRowAction Action => this.eventAction;
  }
}
