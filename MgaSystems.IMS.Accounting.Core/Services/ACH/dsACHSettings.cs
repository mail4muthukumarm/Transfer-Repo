// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.ACH.dsACHSettings
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

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
namespace MGASystems.IMS.Accounting.Services.ACH;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsACHSettings")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsACHSettings : DataSet
{
  private dsACHSettings.ACHSettingsDataTable tableACHSettings;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsACHSettings()
  {
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected dsACHSettings(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (ACHSettings)] != null)
          base.Tables.Add((DataTable) new dsACHSettings.ACHSettingsDataTable(dataSet.Tables[nameof (ACHSettings)]));
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
  public dsACHSettings.ACHSettingsDataTable ACHSettings => this.tableACHSettings;

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
    dsACHSettings dsAchSettings = (dsACHSettings) base.Clone();
    dsAchSettings.InitVars();
    dsAchSettings.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsAchSettings;
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
      if (dataSet.Tables["ACHSettings"] != null)
        base.Tables.Add((DataTable) new dsACHSettings.ACHSettingsDataTable(dataSet.Tables["ACHSettings"]));
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
    this.tableACHSettings = (dsACHSettings.ACHSettingsDataTable) base.Tables["ACHSettings"];
    if (!initTable || this.tableACHSettings == null)
      return;
    this.tableACHSettings.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsACHSettings);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsACHSettings.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableACHSettings = new dsACHSettings.ACHSettingsDataTable();
    base.Tables.Add((DataTable) this.tableACHSettings);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeACHSettings() => false;

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
    dsACHSettings dsAchSettings = new dsACHSettings();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = dsAchSettings.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = dsAchSettings.GetSchemaSerializable();
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
          current.Write((Stream) memoryStream2);
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void ACHSettingsRowChangeEventHandler(
    object sender,
    dsACHSettings.ACHSettingsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class ACHSettingsDataTable : TypedTableBase<dsACHSettings.ACHSettingsRow>
  {
    private DataColumn columnEntityGuid;
    private DataColumn columnAccountName;
    private DataColumn columnAccountNumber;
    private DataColumn columnRoutingNumber;
    private DataColumn columnAccountType;
    private DataColumn columnBankName;
    private DataColumn columnEnteredBy;
    private DataColumn columnIBAN;
    private DataColumn columnSWIFTCode;
    private DataColumn columnBankISOCountryCode;
    private DataColumn columnBankAddress1;
    private DataColumn columnBankAddress2;
    private DataColumn columnBankCity;
    private DataColumn columnBankState;
    private DataColumn columnBankZipCode;
    private DataColumn columnCHIPNumber;
    private DataColumn columnDateEntered;
    private DataColumn columnEnteredByUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public ACHSettingsDataTable()
    {
      this.TableName = "ACHSettings";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal ACHSettingsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected ACHSettingsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EntityGuidColumn => this.columnEntityGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AccountNameColumn => this.columnAccountName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AccountNumberColumn => this.columnAccountNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RoutingNumberColumn => this.columnRoutingNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AccountTypeColumn => this.columnAccountType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BankNameColumn => this.columnBankName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EnteredByColumn => this.columnEnteredBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IBANColumn => this.columnIBAN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SWIFTCodeColumn => this.columnSWIFTCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BankISOCountryCodeColumn => this.columnBankISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BankAddress1Column => this.columnBankAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BankAddress2Column => this.columnBankAddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BankCityColumn => this.columnBankCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BankStateColumn => this.columnBankState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BankZipCodeColumn => this.columnBankZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CHIPNumberColumn => this.columnCHIPNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateEnteredColumn => this.columnDateEntered;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EnteredByUserNameColumn => this.columnEnteredByUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsACHSettings.ACHSettingsRow this[int index]
    {
      get => (dsACHSettings.ACHSettingsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsACHSettings.ACHSettingsRowChangeEventHandler ACHSettingsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsACHSettings.ACHSettingsRowChangeEventHandler ACHSettingsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsACHSettings.ACHSettingsRowChangeEventHandler ACHSettingsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsACHSettings.ACHSettingsRowChangeEventHandler ACHSettingsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddACHSettingsRow(dsACHSettings.ACHSettingsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsACHSettings.ACHSettingsRow AddACHSettingsRow(
      Guid EntityGuid,
      string AccountName,
      string AccountNumber,
      string RoutingNumber,
      string AccountType,
      string BankName,
      Guid EnteredBy,
      string IBAN,
      string SWIFTCode,
      string BankISOCountryCode,
      string BankAddress1,
      string BankAddress2,
      string BankCity,
      string BankState,
      string BankZipCode,
      string CHIPNumber,
      DateTime DateEntered,
      string EnteredByUserName)
    {
      dsACHSettings.ACHSettingsRow row = (dsACHSettings.ACHSettingsRow) this.NewRow();
      object[] objArray = new object[18]
      {
        (object) EntityGuid,
        (object) AccountName,
        (object) AccountNumber,
        (object) RoutingNumber,
        (object) AccountType,
        (object) BankName,
        (object) EnteredBy,
        (object) IBAN,
        (object) SWIFTCode,
        (object) BankISOCountryCode,
        (object) BankAddress1,
        (object) BankAddress2,
        (object) BankCity,
        (object) BankState,
        (object) BankZipCode,
        (object) CHIPNumber,
        (object) DateEntered,
        (object) EnteredByUserName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsACHSettings.ACHSettingsDataTable settingsDataTable = (dsACHSettings.ACHSettingsDataTable) base.Clone();
      settingsDataTable.InitVars();
      return (DataTable) settingsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsACHSettings.ACHSettingsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnEntityGuid = this.Columns["EntityGuid"];
      this.columnAccountName = this.Columns["AccountName"];
      this.columnAccountNumber = this.Columns["AccountNumber"];
      this.columnRoutingNumber = this.Columns["RoutingNumber"];
      this.columnAccountType = this.Columns["AccountType"];
      this.columnBankName = this.Columns["BankName"];
      this.columnEnteredBy = this.Columns["EnteredBy"];
      this.columnIBAN = this.Columns["IBAN"];
      this.columnSWIFTCode = this.Columns["SWIFTCode"];
      this.columnBankISOCountryCode = this.Columns["BankISOCountryCode"];
      this.columnBankAddress1 = this.Columns["BankAddress1"];
      this.columnBankAddress2 = this.Columns["BankAddress2"];
      this.columnBankCity = this.Columns["BankCity"];
      this.columnBankState = this.Columns["BankState"];
      this.columnBankZipCode = this.Columns["BankZipCode"];
      this.columnCHIPNumber = this.Columns["CHIPNumber"];
      this.columnDateEntered = this.Columns["DateEntered"];
      this.columnEnteredByUserName = this.Columns["EnteredByUserName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnEntityGuid = new DataColumn("EntityGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGuid);
      this.columnAccountName = new DataColumn("AccountName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccountName);
      this.columnAccountNumber = new DataColumn("AccountNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccountNumber);
      this.columnRoutingNumber = new DataColumn("RoutingNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoutingNumber);
      this.columnAccountType = new DataColumn("AccountType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccountType);
      this.columnBankName = new DataColumn("BankName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankName);
      this.columnEnteredBy = new DataColumn("EnteredBy", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEnteredBy);
      this.columnIBAN = new DataColumn("IBAN", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIBAN);
      this.columnSWIFTCode = new DataColumn("SWIFTCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSWIFTCode);
      this.columnBankISOCountryCode = new DataColumn("BankISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankISOCountryCode);
      this.columnBankAddress1 = new DataColumn("BankAddress1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankAddress1);
      this.columnBankAddress2 = new DataColumn("BankAddress2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankAddress2);
      this.columnBankCity = new DataColumn("BankCity", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankCity);
      this.columnBankState = new DataColumn("BankState", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankState);
      this.columnBankZipCode = new DataColumn("BankZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankZipCode);
      this.columnCHIPNumber = new DataColumn("CHIPNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCHIPNumber);
      this.columnDateEntered = new DataColumn("DateEntered", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateEntered);
      this.columnEnteredByUserName = new DataColumn("EnteredByUserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEnteredByUserName);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsACHSettings.ACHSettingsRow NewACHSettingsRow()
    {
      return (dsACHSettings.ACHSettingsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsACHSettings.ACHSettingsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsACHSettings.ACHSettingsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.ACHSettingsRowChanged == null)
        return;
      this.ACHSettingsRowChanged((object) this, new dsACHSettings.ACHSettingsRowChangeEvent((dsACHSettings.ACHSettingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.ACHSettingsRowChanging == null)
        return;
      this.ACHSettingsRowChanging((object) this, new dsACHSettings.ACHSettingsRowChangeEvent((dsACHSettings.ACHSettingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.ACHSettingsRowDeleted == null)
        return;
      this.ACHSettingsRowDeleted((object) this, new dsACHSettings.ACHSettingsRowChangeEvent((dsACHSettings.ACHSettingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.ACHSettingsRowDeleting == null)
        return;
      this.ACHSettingsRowDeleting((object) this, new dsACHSettings.ACHSettingsRowChangeEvent((dsACHSettings.ACHSettingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveACHSettingsRow(dsACHSettings.ACHSettingsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsACHSettings dsAchSettings = new dsACHSettings();
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
        FixedValue = dsAchSettings.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ACHSettingsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAchSettings.GetSchemaSerializable();
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
            current.Write((Stream) memoryStream2);
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

  public class ACHSettingsRow : DataRow
  {
    private dsACHSettings.ACHSettingsDataTable tableACHSettings;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal ACHSettingsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableACHSettings = (dsACHSettings.ACHSettingsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid EntityGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tableACHSettings.EntityGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EntityGuid' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.EntityGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AccountName
    {
      get
      {
        try
        {
          return (string) this[this.tableACHSettings.AccountNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AccountName' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.AccountNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AccountNumber
    {
      get
      {
        try
        {
          return (string) this[this.tableACHSettings.AccountNumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AccountNumber' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.AccountNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string RoutingNumber
    {
      get
      {
        try
        {
          return (string) this[this.tableACHSettings.RoutingNumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'RoutingNumber' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.RoutingNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AccountType
    {
      get
      {
        try
        {
          return (string) this[this.tableACHSettings.AccountTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AccountType' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.AccountTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BankName
    {
      get
      {
        try
        {
          return (string) this[this.tableACHSettings.BankNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'BankName' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.BankNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid EnteredBy
    {
      get
      {
        try
        {
          return (Guid) this[this.tableACHSettings.EnteredByColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EnteredBy' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.EnteredByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string IBAN
    {
      get
      {
        try
        {
          return (string) this[this.tableACHSettings.IBANColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'IBAN' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.IBANColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string SWIFTCode
    {
      get
      {
        try
        {
          return (string) this[this.tableACHSettings.SWIFTCodeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'SWIFTCode' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.SWIFTCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BankISOCountryCode
    {
      get
      {
        try
        {
          return (string) this[this.tableACHSettings.BankISOCountryCodeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'BankISOCountryCode' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.BankISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BankAddress1
    {
      get
      {
        try
        {
          return (string) this[this.tableACHSettings.BankAddress1Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'BankAddress1' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.BankAddress1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BankAddress2
    {
      get
      {
        try
        {
          return (string) this[this.tableACHSettings.BankAddress2Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'BankAddress2' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.BankAddress2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BankCity
    {
      get
      {
        try
        {
          return (string) this[this.tableACHSettings.BankCityColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'BankCity' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.BankCityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BankState
    {
      get
      {
        try
        {
          return (string) this[this.tableACHSettings.BankStateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'BankState' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.BankStateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BankZipCode
    {
      get
      {
        try
        {
          return (string) this[this.tableACHSettings.BankZipCodeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'BankZipCode' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.BankZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CHIPNumber
    {
      get
      {
        try
        {
          return (string) this[this.tableACHSettings.CHIPNumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CHIPNumber' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.CHIPNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateEntered
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableACHSettings.DateEnteredColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'DateEntered' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.DateEnteredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EnteredByUserName
    {
      get
      {
        try
        {
          return (string) this[this.tableACHSettings.EnteredByUserNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EnteredByUserName' in table 'ACHSettings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableACHSettings.EnteredByUserNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEntityGuidNull() => this.IsNull(this.tableACHSettings.EntityGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEntityGuidNull()
    {
      this[this.tableACHSettings.EntityGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAccountNameNull() => this.IsNull(this.tableACHSettings.AccountNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAccountNameNull()
    {
      this[this.tableACHSettings.AccountNameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAccountNumberNull() => this.IsNull(this.tableACHSettings.AccountNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAccountNumberNull()
    {
      this[this.tableACHSettings.AccountNumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRoutingNumberNull() => this.IsNull(this.tableACHSettings.RoutingNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRoutingNumberNull()
    {
      this[this.tableACHSettings.RoutingNumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAccountTypeNull() => this.IsNull(this.tableACHSettings.AccountTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAccountTypeNull()
    {
      this[this.tableACHSettings.AccountTypeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBankNameNull() => this.IsNull(this.tableACHSettings.BankNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBankNameNull() => this[this.tableACHSettings.BankNameColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEnteredByNull() => this.IsNull(this.tableACHSettings.EnteredByColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEnteredByNull() => this[this.tableACHSettings.EnteredByColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIBANNull() => this.IsNull(this.tableACHSettings.IBANColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIBANNull() => this[this.tableACHSettings.IBANColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSWIFTCodeNull() => this.IsNull(this.tableACHSettings.SWIFTCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSWIFTCodeNull() => this[this.tableACHSettings.SWIFTCodeColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBankISOCountryCodeNull()
    {
      return this.IsNull(this.tableACHSettings.BankISOCountryCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBankISOCountryCodeNull()
    {
      this[this.tableACHSettings.BankISOCountryCodeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBankAddress1Null() => this.IsNull(this.tableACHSettings.BankAddress1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBankAddress1Null()
    {
      this[this.tableACHSettings.BankAddress1Column] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBankAddress2Null() => this.IsNull(this.tableACHSettings.BankAddress2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBankAddress2Null()
    {
      this[this.tableACHSettings.BankAddress2Column] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBankCityNull() => this.IsNull(this.tableACHSettings.BankCityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBankCityNull() => this[this.tableACHSettings.BankCityColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBankStateNull() => this.IsNull(this.tableACHSettings.BankStateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBankStateNull() => this[this.tableACHSettings.BankStateColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBankZipCodeNull() => this.IsNull(this.tableACHSettings.BankZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBankZipCodeNull()
    {
      this[this.tableACHSettings.BankZipCodeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCHIPNumberNull() => this.IsNull(this.tableACHSettings.CHIPNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCHIPNumberNull()
    {
      this[this.tableACHSettings.CHIPNumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateEnteredNull() => this.IsNull(this.tableACHSettings.DateEnteredColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateEnteredNull()
    {
      this[this.tableACHSettings.DateEnteredColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEnteredByUserNameNull()
    {
      return this.IsNull(this.tableACHSettings.EnteredByUserNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEnteredByUserNameNull()
    {
      this[this.tableACHSettings.EnteredByUserNameColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class ACHSettingsRowChangeEvent : EventArgs
  {
    private dsACHSettings.ACHSettingsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public ACHSettingsRowChangeEvent(dsACHSettings.ACHSettingsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsACHSettings.ACHSettingsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
