// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.AffidavitNumbering.dsAdminAffidavitNumbers
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
namespace MGASystems.IMS.Policies.AffidavitNumbering;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsAdminAffidavitNumbers")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsAdminAffidavitNumbers : DataSet
{
  private dsAdminAffidavitNumbers.tblAdminAffidavitNumbersDataTable tabletblAdminAffidavitNumbers;
  private dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersDataTable tabletblQuoteAffidavitNumbers;
  private dsAdminAffidavitNumbers.tblClientOfficesDataTable tabletblClientOffices;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsAdminAffidavitNumbers()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected dsAdminAffidavitNumbers(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblAdminAffidavitNumbers)] != null)
          base.Tables.Add((DataTable) new dsAdminAffidavitNumbers.tblAdminAffidavitNumbersDataTable(dataSet.Tables[nameof (tblAdminAffidavitNumbers)]));
        if (dataSet.Tables[nameof (tblQuoteAffidavitNumbers)] != null)
          base.Tables.Add((DataTable) new dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersDataTable(dataSet.Tables[nameof (tblQuoteAffidavitNumbers)]));
        if (dataSet.Tables[nameof (tblClientOffices)] != null)
          base.Tables.Add((DataTable) new dsAdminAffidavitNumbers.tblClientOfficesDataTable(dataSet.Tables[nameof (tblClientOffices)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminAffidavitNumbers.tblAdminAffidavitNumbersDataTable tblAdminAffidavitNumbers
  {
    get => this.tabletblAdminAffidavitNumbers;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersDataTable tblQuoteAffidavitNumbers
  {
    get => this.tabletblQuoteAffidavitNumbers;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminAffidavitNumbers.tblClientOfficesDataTable tblClientOffices
  {
    get => this.tabletblClientOffices;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public override DataSet Clone()
  {
    dsAdminAffidavitNumbers affidavitNumbers = (dsAdminAffidavitNumbers) base.Clone();
    affidavitNumbers.InitVars();
    affidavitNumbers.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) affidavitNumbers;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["tblAdminAffidavitNumbers"] != null)
        base.Tables.Add((DataTable) new dsAdminAffidavitNumbers.tblAdminAffidavitNumbersDataTable(dataSet.Tables["tblAdminAffidavitNumbers"]));
      if (dataSet.Tables["tblQuoteAffidavitNumbers"] != null)
        base.Tables.Add((DataTable) new dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersDataTable(dataSet.Tables["tblQuoteAffidavitNumbers"]));
      if (dataSet.Tables["tblClientOffices"] != null)
        base.Tables.Add((DataTable) new dsAdminAffidavitNumbers.tblClientOfficesDataTable(dataSet.Tables["tblClientOffices"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tabletblAdminAffidavitNumbers = (dsAdminAffidavitNumbers.tblAdminAffidavitNumbersDataTable) base.Tables["tblAdminAffidavitNumbers"];
    if (initTable && this.tabletblAdminAffidavitNumbers != null)
      this.tabletblAdminAffidavitNumbers.InitVars();
    this.tabletblQuoteAffidavitNumbers = (dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersDataTable) base.Tables["tblQuoteAffidavitNumbers"];
    if (initTable && this.tabletblQuoteAffidavitNumbers != null)
      this.tabletblQuoteAffidavitNumbers.InitVars();
    this.tabletblClientOffices = (dsAdminAffidavitNumbers.tblClientOfficesDataTable) base.Tables["tblClientOffices"];
    if (!initTable || this.tabletblClientOffices == null)
      return;
    this.tabletblClientOffices.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsAdminAffidavitNumbers);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsAdminAffidavitNumbers.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblAdminAffidavitNumbers = new dsAdminAffidavitNumbers.tblAdminAffidavitNumbersDataTable();
    base.Tables.Add((DataTable) this.tabletblAdminAffidavitNumbers);
    this.tabletblQuoteAffidavitNumbers = new dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteAffidavitNumbers);
    this.tabletblClientOffices = new dsAdminAffidavitNumbers.tblClientOfficesDataTable();
    base.Tables.Add((DataTable) this.tabletblClientOffices);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblAdminAffidavitNumbers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblQuoteAffidavitNumbers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblClientOffices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsAdminAffidavitNumbers affidavitNumbers = new dsAdminAffidavitNumbers();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = affidavitNumbers.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = affidavitNumbers.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblAdminAffidavitNumbersRowChangeEventHandler(
    object sender,
    dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblQuoteAffidavitNumbersRowChangeEventHandler(
    object sender,
    dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblClientOfficesRowChangeEventHandler(
    object sender,
    dsAdminAffidavitNumbers.tblClientOfficesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblAdminAffidavitNumbersDataTable : 
    TypedTableBase<dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnStartNum;
    private DataColumn columnEndNum;
    private DataColumn columnMinDigits;
    private DataColumn columnPrefix;
    private DataColumn columnSeparateSuffixWithDash;
    private DataColumn columnCustomSuffix;
    private DataColumn columnTwoDigitYear;
    private DataColumn columnFourDigitYear;
    private DataColumn columnBasedOn;
    private DataColumn columnResetEachYear;
    private DataColumn columnResetOn;
    private DataColumn columnManualEntry;
    private DataColumn columnRequiredForBinding;
    private DataColumn columnExportable;
    private DataColumn columnTaxExempt;
    private DataColumn columnShareNos;
    private DataColumn columnQuotingOfficeGUID;
    private DataColumn columnSwapSuffixAndAffNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblAdminAffidavitNumbersDataTable()
    {
      this.TableName = "tblAdminAffidavitNumbers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblAdminAffidavitNumbersDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblAdminAffidavitNumbersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StartNumColumn => this.columnStartNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EndNumColumn => this.columnEndNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MinDigitsColumn => this.columnMinDigits;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PrefixColumn => this.columnPrefix;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SeparateSuffixWithDashColumn => this.columnSeparateSuffixWithDash;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CustomSuffixColumn => this.columnCustomSuffix;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TwoDigitYearColumn => this.columnTwoDigitYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FourDigitYearColumn => this.columnFourDigitYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BasedOnColumn => this.columnBasedOn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ResetEachYearColumn => this.columnResetEachYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ResetOnColumn => this.columnResetOn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ManualEntryColumn => this.columnManualEntry;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RequiredForBindingColumn => this.columnRequiredForBinding;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExportableColumn => this.columnExportable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TaxExemptColumn => this.columnTaxExempt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ShareNosColumn => this.columnShareNos;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuotingOfficeGUIDColumn => this.columnQuotingOfficeGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SwapSuffixAndAffNumColumn => this.columnSwapSuffixAndAffNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow this[int index]
    {
      get => (dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRowChangeEventHandler tblAdminAffidavitNumbersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRowChangeEventHandler tblAdminAffidavitNumbersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRowChangeEventHandler tblAdminAffidavitNumbersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRowChangeEventHandler tblAdminAffidavitNumbersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblAdminAffidavitNumbersRow(
      dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow AddtblAdminAffidavitNumbersRow(
      string StateID,
      int StartNum,
      int EndNum,
      int MinDigits,
      string Prefix,
      bool SeparateSuffixWithDash,
      string CustomSuffix,
      bool TwoDigitYear,
      bool FourDigitYear,
      string BasedOn,
      bool ResetEachYear,
      DateTime ResetOn,
      bool ManualEntry,
      bool RequiredForBinding,
      bool Exportable,
      bool TaxExempt,
      bool ShareNos,
      Guid QuotingOfficeGUID,
      bool SwapSuffixAndAffNum)
    {
      dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow row = (dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow) this.NewRow();
      object[] objArray = new object[19]
      {
        (object) StateID,
        (object) StartNum,
        (object) EndNum,
        (object) MinDigits,
        (object) Prefix,
        (object) SeparateSuffixWithDash,
        (object) CustomSuffix,
        (object) TwoDigitYear,
        (object) FourDigitYear,
        (object) BasedOn,
        (object) ResetEachYear,
        (object) ResetOn,
        (object) ManualEntry,
        (object) RequiredForBinding,
        (object) Exportable,
        (object) TaxExempt,
        (object) ShareNos,
        (object) QuotingOfficeGUID,
        (object) SwapSuffixAndAffNum
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow FindByQuotingOfficeGUIDStateID(
      Guid QuotingOfficeGUID,
      string StateID)
    {
      return (dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow) this.Rows.Find(new object[2]
      {
        (object) QuotingOfficeGUID,
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminAffidavitNumbers.tblAdminAffidavitNumbersDataTable numbersDataTable = (dsAdminAffidavitNumbers.tblAdminAffidavitNumbersDataTable) base.Clone();
      numbersDataTable.InitVars();
      return (DataTable) numbersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminAffidavitNumbers.tblAdminAffidavitNumbersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnStartNum = this.Columns["StartNum"];
      this.columnEndNum = this.Columns["EndNum"];
      this.columnMinDigits = this.Columns["MinDigits"];
      this.columnPrefix = this.Columns["Prefix"];
      this.columnSeparateSuffixWithDash = this.Columns["SeparateSuffixWithDash"];
      this.columnCustomSuffix = this.Columns["CustomSuffix"];
      this.columnTwoDigitYear = this.Columns["TwoDigitYear"];
      this.columnFourDigitYear = this.Columns["FourDigitYear"];
      this.columnBasedOn = this.Columns["BasedOn"];
      this.columnResetEachYear = this.Columns["ResetEachYear"];
      this.columnResetOn = this.Columns["ResetOn"];
      this.columnManualEntry = this.Columns["ManualEntry"];
      this.columnRequiredForBinding = this.Columns["RequiredForBinding"];
      this.columnExportable = this.Columns["Exportable"];
      this.columnTaxExempt = this.Columns["TaxExempt"];
      this.columnShareNos = this.Columns["ShareNos"];
      this.columnQuotingOfficeGUID = this.Columns["QuotingOfficeGUID"];
      this.columnSwapSuffixAndAffNum = this.Columns["SwapSuffixAndAffNum"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnStartNum = new DataColumn("StartNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStartNum);
      this.columnEndNum = new DataColumn("EndNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndNum);
      this.columnMinDigits = new DataColumn("MinDigits", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMinDigits);
      this.columnPrefix = new DataColumn("Prefix", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPrefix);
      this.columnSeparateSuffixWithDash = new DataColumn("SeparateSuffixWithDash", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSeparateSuffixWithDash);
      this.columnCustomSuffix = new DataColumn("CustomSuffix", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCustomSuffix);
      this.columnTwoDigitYear = new DataColumn("TwoDigitYear", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTwoDigitYear);
      this.columnFourDigitYear = new DataColumn("FourDigitYear", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFourDigitYear);
      this.columnBasedOn = new DataColumn("BasedOn", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBasedOn);
      this.columnResetEachYear = new DataColumn("ResetEachYear", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResetEachYear);
      this.columnResetOn = new DataColumn("ResetOn", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnResetOn);
      this.columnManualEntry = new DataColumn("ManualEntry", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnManualEntry);
      this.columnRequiredForBinding = new DataColumn("RequiredForBinding", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiredForBinding);
      this.columnExportable = new DataColumn("Exportable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExportable);
      this.columnTaxExempt = new DataColumn("TaxExempt", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxExempt);
      this.columnShareNos = new DataColumn("ShareNos", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnShareNos);
      this.columnQuotingOfficeGUID = new DataColumn("QuotingOfficeGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuotingOfficeGUID);
      this.columnSwapSuffixAndAffNum = new DataColumn("SwapSuffixAndAffNum", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSwapSuffixAndAffNum);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnQuotingOfficeGUID,
        this.columnStateID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnStartNum.AllowDBNull = false;
      this.columnEndNum.AllowDBNull = false;
      this.columnMinDigits.AllowDBNull = false;
      this.columnSeparateSuffixWithDash.AllowDBNull = false;
      this.columnResetEachYear.AllowDBNull = false;
      this.columnManualEntry.AllowDBNull = false;
      this.columnManualEntry.DefaultValue = (object) false;
      this.columnRequiredForBinding.AllowDBNull = false;
      this.columnRequiredForBinding.DefaultValue = (object) false;
      this.columnQuotingOfficeGUID.AllowDBNull = false;
      this.columnSwapSuffixAndAffNum.AllowDBNull = false;
      this.columnSwapSuffixAndAffNum.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow NewtblAdminAffidavitNumbersRow()
    {
      return (dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdminAffidavitNumbersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRowChangeEventHandler numbersRowChangedEvent = this.tblAdminAffidavitNumbersRowChangedEvent;
      if (numbersRowChangedEvent == null)
        return;
      numbersRowChangedEvent((object) this, new dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRowChangeEvent((dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdminAffidavitNumbersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRowChangeEventHandler rowChangingEvent = this.tblAdminAffidavitNumbersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRowChangeEvent((dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdminAffidavitNumbersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRowChangeEventHandler numbersRowDeletedEvent = this.tblAdminAffidavitNumbersRowDeletedEvent;
      if (numbersRowDeletedEvent == null)
        return;
      numbersRowDeletedEvent((object) this, new dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRowChangeEvent((dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdminAffidavitNumbersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRowChangeEventHandler rowDeletingEvent = this.tblAdminAffidavitNumbersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRowChangeEvent((dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblAdminAffidavitNumbersRow(
      dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminAffidavitNumbers affidavitNumbers = new dsAdminAffidavitNumbers();
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
        FixedValue = affidavitNumbers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblAdminAffidavitNumbersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = affidavitNumbers.GetSchemaSerializable();
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
  public class tblQuoteAffidavitNumbersDataTable : 
    TypedTableBase<dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow>
  {
    private DataColumn columnQuoteID;
    private DataColumn columnStateID;
    private DataColumn columnAffidavitNumber;
    private DataColumn columnAffidavitNumberIndex;
    private DataColumn columnExportable;
    private DataColumn columnTaxExempt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteAffidavitNumbersDataTable()
    {
      this.TableName = "tblQuoteAffidavitNumbers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteAffidavitNumbersDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblQuoteAffidavitNumbersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AffidavitNumberColumn => this.columnAffidavitNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AffidavitNumberIndexColumn => this.columnAffidavitNumberIndex;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExportableColumn => this.columnExportable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TaxExemptColumn => this.columnTaxExempt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow this[int index]
    {
      get => (dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler tblQuoteAffidavitNumbersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler tblQuoteAffidavitNumbersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler tblQuoteAffidavitNumbersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler tblQuoteAffidavitNumbersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteAffidavitNumbersRow(
      dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow AddtblQuoteAffidavitNumbersRow(
      int QuoteID,
      string StateID,
      string AffidavitNumber,
      int AffidavitNumberIndex,
      bool Exportable,
      bool TaxExempt)
    {
      dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow row = (dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) QuoteID,
        (object) StateID,
        (object) AffidavitNumber,
        (object) AffidavitNumberIndex,
        (object) Exportable,
        (object) TaxExempt
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow FindByQuoteIDStateID(
      int QuoteID,
      string StateID)
    {
      return (dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow) this.Rows.Find(new object[2]
      {
        (object) QuoteID,
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersDataTable numbersDataTable = (dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersDataTable) base.Clone();
      numbersDataTable.InitVars();
      return (DataTable) numbersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnStateID = this.Columns["StateID"];
      this.columnAffidavitNumber = this.Columns["AffidavitNumber"];
      this.columnAffidavitNumberIndex = this.Columns["AffidavitNumberIndex"];
      this.columnExportable = this.Columns["Exportable"];
      this.columnTaxExempt = this.Columns["TaxExempt"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnAffidavitNumber = new DataColumn("AffidavitNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAffidavitNumber);
      this.columnAffidavitNumberIndex = new DataColumn("AffidavitNumberIndex", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAffidavitNumberIndex);
      this.columnExportable = new DataColumn("Exportable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExportable);
      this.columnTaxExempt = new DataColumn("TaxExempt", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxExempt);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdminAffidavitNumbersKey1", new DataColumn[2]
      {
        this.columnQuoteID,
        this.columnStateID
      }, true));
      this.columnQuoteID.AllowDBNull = false;
      this.columnStateID.AllowDBNull = false;
      this.columnAffidavitNumber.AllowDBNull = false;
      this.columnAffidavitNumberIndex.AllowDBNull = false;
      this.columnExportable.AllowDBNull = false;
      this.columnExportable.DefaultValue = (object) false;
      this.columnTaxExempt.AllowDBNull = false;
      this.columnTaxExempt.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow NewtblQuoteAffidavitNumbersRow()
    {
      return (dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAffidavitNumbersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler numbersRowChangedEvent = this.tblQuoteAffidavitNumbersRowChangedEvent;
      if (numbersRowChangedEvent == null)
        return;
      numbersRowChangedEvent((object) this, new dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEvent((dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAffidavitNumbersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler rowChangingEvent = this.tblQuoteAffidavitNumbersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEvent((dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAffidavitNumbersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler numbersRowDeletedEvent = this.tblQuoteAffidavitNumbersRowDeletedEvent;
      if (numbersRowDeletedEvent == null)
        return;
      numbersRowDeletedEvent((object) this, new dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEvent((dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAffidavitNumbersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler rowDeletingEvent = this.tblQuoteAffidavitNumbersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEvent((dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteAffidavitNumbersRow(
      dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminAffidavitNumbers affidavitNumbers = new dsAdminAffidavitNumbers();
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
        FixedValue = affidavitNumbers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteAffidavitNumbersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = affidavitNumbers.GetSchemaSerializable();
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
  public class tblClientOfficesDataTable : 
    TypedTableBase<dsAdminAffidavitNumbers.tblClientOfficesRow>
  {
    private DataColumn columnOfficeGUID;
    private DataColumn columnLocation;
    private DataColumn columnAddress1;
    private DataColumn columnCity;
    private DataColumn columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblClientOfficesDataTable()
    {
      this.TableName = "tblClientOffices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblClientOfficesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblClientOfficesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OfficeGUIDColumn => this.columnOfficeGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Address1Column => this.columnAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdminAffidavitNumbers.tblClientOfficesRow this[int index]
    {
      get => (dsAdminAffidavitNumbers.tblClientOfficesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdminAffidavitNumbers.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdminAffidavitNumbers.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdminAffidavitNumbers.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdminAffidavitNumbers.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblClientOfficesRow(dsAdminAffidavitNumbers.tblClientOfficesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdminAffidavitNumbers.tblClientOfficesRow AddtblClientOfficesRow(
      Guid OfficeGUID,
      string Location,
      string Address1,
      string City,
      string State)
    {
      dsAdminAffidavitNumbers.tblClientOfficesRow row = (dsAdminAffidavitNumbers.tblClientOfficesRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) OfficeGUID,
        (object) Location,
        (object) Address1,
        (object) City,
        (object) State
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdminAffidavitNumbers.tblClientOfficesRow FindByOfficeGUID(Guid OfficeGUID)
    {
      return (dsAdminAffidavitNumbers.tblClientOfficesRow) this.Rows.Find(new object[1]
      {
        (object) OfficeGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminAffidavitNumbers.tblClientOfficesDataTable officesDataTable = (dsAdminAffidavitNumbers.tblClientOfficesDataTable) base.Clone();
      officesDataTable.InitVars();
      return (DataTable) officesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminAffidavitNumbers.tblClientOfficesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnOfficeGUID = this.Columns["OfficeGUID"];
      this.columnLocation = this.Columns["Location"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnOfficeGUID = new DataColumn("OfficeGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeGUID);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnOfficeGUID
      }, true));
      this.columnOfficeGUID.AllowDBNull = false;
      this.columnOfficeGUID.Unique = true;
      this.columnLocation.AllowDBNull = false;
      this.columnLocation.MaxLength = 50;
      this.columnAddress1.AllowDBNull = false;
      this.columnAddress1.MaxLength = 50;
      this.columnCity.AllowDBNull = false;
      this.columnCity.MaxLength = 50;
      this.columnState.AllowDBNull = false;
      this.columnState.MaxLength = 2;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdminAffidavitNumbers.tblClientOfficesRow NewtblClientOfficesRow()
    {
      return (dsAdminAffidavitNumbers.tblClientOfficesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminAffidavitNumbers.tblClientOfficesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminAffidavitNumbers.tblClientOfficesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminAffidavitNumbers.tblClientOfficesRowChangeEventHandler officesRowChangedEvent = this.tblClientOfficesRowChangedEvent;
      if (officesRowChangedEvent == null)
        return;
      officesRowChangedEvent((object) this, new dsAdminAffidavitNumbers.tblClientOfficesRowChangeEvent((dsAdminAffidavitNumbers.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminAffidavitNumbers.tblClientOfficesRowChangeEventHandler rowChangingEvent = this.tblClientOfficesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminAffidavitNumbers.tblClientOfficesRowChangeEvent((dsAdminAffidavitNumbers.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminAffidavitNumbers.tblClientOfficesRowChangeEventHandler officesRowDeletedEvent = this.tblClientOfficesRowDeletedEvent;
      if (officesRowDeletedEvent == null)
        return;
      officesRowDeletedEvent((object) this, new dsAdminAffidavitNumbers.tblClientOfficesRowChangeEvent((dsAdminAffidavitNumbers.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminAffidavitNumbers.tblClientOfficesRowChangeEventHandler rowDeletingEvent = this.tblClientOfficesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminAffidavitNumbers.tblClientOfficesRowChangeEvent((dsAdminAffidavitNumbers.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblClientOfficesRow(dsAdminAffidavitNumbers.tblClientOfficesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminAffidavitNumbers affidavitNumbers = new dsAdminAffidavitNumbers();
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
        FixedValue = affidavitNumbers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClientOfficesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = affidavitNumbers.GetSchemaSerializable();
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

  public class tblAdminAffidavitNumbersRow : DataRow
  {
    private dsAdminAffidavitNumbers.tblAdminAffidavitNumbersDataTable tabletblAdminAffidavitNumbers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblAdminAffidavitNumbersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblAdminAffidavitNumbers = (dsAdminAffidavitNumbers.tblAdminAffidavitNumbersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tabletblAdminAffidavitNumbers.StateIDColumn]);
      set => this[this.tabletblAdminAffidavitNumbers.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int StartNum
    {
      get => Conversions.ToInteger(this[this.tabletblAdminAffidavitNumbers.StartNumColumn]);
      set => this[this.tabletblAdminAffidavitNumbers.StartNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int EndNum
    {
      get => Conversions.ToInteger(this[this.tabletblAdminAffidavitNumbers.EndNumColumn]);
      set => this[this.tabletblAdminAffidavitNumbers.EndNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int MinDigits
    {
      get => Conversions.ToInteger(this[this.tabletblAdminAffidavitNumbers.MinDigitsColumn]);
      set => this[this.tabletblAdminAffidavitNumbers.MinDigitsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Prefix
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminAffidavitNumbers.PrefixColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Prefix' in table 'tblAdminAffidavitNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminAffidavitNumbers.PrefixColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool SeparateSuffixWithDash
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblAdminAffidavitNumbers.SeparateSuffixWithDashColumn]);
      }
      set => this[this.tabletblAdminAffidavitNumbers.SeparateSuffixWithDashColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CustomSuffix
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminAffidavitNumbers.CustomSuffixColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CustomSuffix' in table 'tblAdminAffidavitNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminAffidavitNumbers.CustomSuffixColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool TwoDigitYear
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblAdminAffidavitNumbers.TwoDigitYearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TwoDigitYear' in table 'tblAdminAffidavitNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminAffidavitNumbers.TwoDigitYearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool FourDigitYear
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblAdminAffidavitNumbers.FourDigitYearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FourDigitYear' in table 'tblAdminAffidavitNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminAffidavitNumbers.FourDigitYearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BasedOn
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblAdminAffidavitNumbers.BasedOnColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BasedOn' in table 'tblAdminAffidavitNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminAffidavitNumbers.BasedOnColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool ResetEachYear
    {
      get => Conversions.ToBoolean(this[this.tabletblAdminAffidavitNumbers.ResetEachYearColumn]);
      set => this[this.tabletblAdminAffidavitNumbers.ResetEachYearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime ResetOn
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdminAffidavitNumbers.ResetOnColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ResetOn' in table 'tblAdminAffidavitNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminAffidavitNumbers.ResetOnColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool ManualEntry
    {
      get => Conversions.ToBoolean(this[this.tabletblAdminAffidavitNumbers.ManualEntryColumn]);
      set => this[this.tabletblAdminAffidavitNumbers.ManualEntryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool RequiredForBinding
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblAdminAffidavitNumbers.RequiredForBindingColumn]);
      }
      set => this[this.tabletblAdminAffidavitNumbers.RequiredForBindingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Exportable
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblAdminAffidavitNumbers.ExportableColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Exportable' in table 'tblAdminAffidavitNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminAffidavitNumbers.ExportableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool TaxExempt
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblAdminAffidavitNumbers.TaxExemptColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TaxExempt' in table 'tblAdminAffidavitNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminAffidavitNumbers.TaxExemptColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool ShareNos
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblAdminAffidavitNumbers.ShareNosColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ShareNos' in table 'tblAdminAffidavitNumbers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdminAffidavitNumbers.ShareNosColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuotingOfficeGUID
    {
      get
      {
        object obj = this[this.tabletblAdminAffidavitNumbers.QuotingOfficeGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblAdminAffidavitNumbers.QuotingOfficeGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool SwapSuffixAndAffNum
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblAdminAffidavitNumbers.SwapSuffixAndAffNumColumn]);
      }
      set => this[this.tabletblAdminAffidavitNumbers.SwapSuffixAndAffNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPrefixNull() => this.IsNull(this.tabletblAdminAffidavitNumbers.PrefixColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPrefixNull()
    {
      this[this.tabletblAdminAffidavitNumbers.PrefixColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCustomSuffixNull()
    {
      return this.IsNull(this.tabletblAdminAffidavitNumbers.CustomSuffixColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCustomSuffixNull()
    {
      this[this.tabletblAdminAffidavitNumbers.CustomSuffixColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTwoDigitYearNull()
    {
      return this.IsNull(this.tabletblAdminAffidavitNumbers.TwoDigitYearColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTwoDigitYearNull()
    {
      this[this.tabletblAdminAffidavitNumbers.TwoDigitYearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFourDigitYearNull()
    {
      return this.IsNull(this.tabletblAdminAffidavitNumbers.FourDigitYearColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFourDigitYearNull()
    {
      this[this.tabletblAdminAffidavitNumbers.FourDigitYearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBasedOnNull() => this.IsNull(this.tabletblAdminAffidavitNumbers.BasedOnColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBasedOnNull()
    {
      this[this.tabletblAdminAffidavitNumbers.BasedOnColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsResetOnNull() => this.IsNull(this.tabletblAdminAffidavitNumbers.ResetOnColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetResetOnNull()
    {
      this[this.tabletblAdminAffidavitNumbers.ResetOnColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExportableNull()
    {
      return this.IsNull(this.tabletblAdminAffidavitNumbers.ExportableColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExportableNull()
    {
      this[this.tabletblAdminAffidavitNumbers.ExportableColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTaxExemptNull()
    {
      return this.IsNull(this.tabletblAdminAffidavitNumbers.TaxExemptColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTaxExemptNull()
    {
      this[this.tabletblAdminAffidavitNumbers.TaxExemptColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsShareNosNull() => this.IsNull(this.tabletblAdminAffidavitNumbers.ShareNosColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetShareNosNull()
    {
      this[this.tabletblAdminAffidavitNumbers.ShareNosColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblQuoteAffidavitNumbersRow : DataRow
  {
    private dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersDataTable tabletblQuoteAffidavitNumbers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteAffidavitNumbersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteAffidavitNumbers = (dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteAffidavitNumbers.QuoteIDColumn]);
      set => this[this.tabletblQuoteAffidavitNumbers.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tabletblQuoteAffidavitNumbers.StateIDColumn]);
      set => this[this.tabletblQuoteAffidavitNumbers.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AffidavitNumber
    {
      get => Conversions.ToString(this[this.tabletblQuoteAffidavitNumbers.AffidavitNumberColumn]);
      set => this[this.tabletblQuoteAffidavitNumbers.AffidavitNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int AffidavitNumberIndex
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteAffidavitNumbers.AffidavitNumberIndexColumn]);
      }
      set => this[this.tabletblQuoteAffidavitNumbers.AffidavitNumberIndexColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Exportable
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteAffidavitNumbers.ExportableColumn]);
      set => this[this.tabletblQuoteAffidavitNumbers.ExportableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool TaxExempt
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteAffidavitNumbers.TaxExemptColumn]);
      set => this[this.tabletblQuoteAffidavitNumbers.TaxExemptColumn] = (object) value;
    }
  }

  public class tblClientOfficesRow : DataRow
  {
    private dsAdminAffidavitNumbers.tblClientOfficesDataTable tabletblClientOffices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblClientOfficesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClientOffices = (dsAdminAffidavitNumbers.tblClientOfficesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid OfficeGUID
    {
      get
      {
        object obj = this[this.tabletblClientOffices.OfficeGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblClientOffices.OfficeGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Location
    {
      get => Conversions.ToString(this[this.tabletblClientOffices.LocationColumn]);
      set => this[this.tabletblClientOffices.LocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Address1
    {
      get => Conversions.ToString(this[this.tabletblClientOffices.Address1Column]);
      set => this[this.tabletblClientOffices.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get => Conversions.ToString(this[this.tabletblClientOffices.CityColumn]);
      set => this[this.tabletblClientOffices.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tabletblClientOffices.StateColumn]);
      set => this[this.tabletblClientOffices.StateColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblAdminAffidavitNumbersRowChangeEvent : EventArgs
  {
    private dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblAdminAffidavitNumbersRowChangeEvent(
      dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdminAffidavitNumbers.tblAdminAffidavitNumbersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteAffidavitNumbersRowChangeEvent : EventArgs
  {
    private dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteAffidavitNumbersRowChangeEvent(
      dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdminAffidavitNumbers.tblQuoteAffidavitNumbersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblClientOfficesRowChangeEvent : EventArgs
  {
    private dsAdminAffidavitNumbers.tblClientOfficesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblClientOfficesRowChangeEvent(
      dsAdminAffidavitNumbers.tblClientOfficesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdminAffidavitNumbers.tblClientOfficesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
