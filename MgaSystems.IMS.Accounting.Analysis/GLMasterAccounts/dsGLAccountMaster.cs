// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.GLMasterAccounts.dsGLAccountMaster
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

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
namespace MGASystems.IMS.Accounting.Analysis.GLMasterAccounts;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsGLAccountMaster")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsGLAccountMaster : DataSet
{
  private dsGLAccountMaster.MasterAccountsDataTable tableMasterAccounts;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsGLAccountMaster()
  {
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected dsGLAccountMaster(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (MasterAccounts)] != null)
          base.Tables.Add((DataTable) new dsGLAccountMaster.MasterAccountsDataTable(dataSet.Tables[nameof (MasterAccounts)]));
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
  public dsGLAccountMaster.MasterAccountsDataTable MasterAccounts => this.tableMasterAccounts;

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
    dsGLAccountMaster dsGlAccountMaster = (dsGLAccountMaster) base.Clone();
    dsGlAccountMaster.InitVars();
    dsGlAccountMaster.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsGlAccountMaster;
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
      if (dataSet.Tables["MasterAccounts"] != null)
        base.Tables.Add((DataTable) new dsGLAccountMaster.MasterAccountsDataTable(dataSet.Tables["MasterAccounts"]));
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
    this.tableMasterAccounts = (dsGLAccountMaster.MasterAccountsDataTable) base.Tables["MasterAccounts"];
    if (!initTable || this.tableMasterAccounts == null)
      return;
    this.tableMasterAccounts.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsGLAccountMaster);
    this.Prefix = "";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableMasterAccounts = new dsGLAccountMaster.MasterAccountsDataTable();
    base.Tables.Add((DataTable) this.tableMasterAccounts);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeMasterAccounts() => false;

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
    dsGLAccountMaster dsGlAccountMaster = new dsGLAccountMaster();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = dsGlAccountMaster.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = dsGlAccountMaster.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void MasterAccountsRowChangeEventHandler(
    object sender,
    dsGLAccountMaster.MasterAccountsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class MasterAccountsDataTable : TypedTableBase<dsGLAccountMaster.MasterAccountsRow>
  {
    private DataColumn columnGLMasterId;
    private DataColumn columnGLAccountName;
    private DataColumn columnGLAccountShortName;
    private DataColumn columnGLAccountNumber;
    private DataColumn columnGLFinancialAccountNumber;
    private DataColumn columnAcctTypeDescription;
    private DataColumn columnAutomationSettingId;
    private DataColumn columnAutomationSetting;
    private DataColumn columnIsBankAccount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public MasterAccountsDataTable()
    {
      this.TableName = "MasterAccounts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal MasterAccountsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected MasterAccountsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLMasterIdColumn => this.columnGLMasterId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLAccountNameColumn => this.columnGLAccountName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLAccountShortNameColumn => this.columnGLAccountShortName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLAccountNumberColumn => this.columnGLAccountNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLFinancialAccountNumberColumn => this.columnGLFinancialAccountNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AcctTypeDescriptionColumn => this.columnAcctTypeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AutomationSettingIdColumn => this.columnAutomationSettingId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AutomationSettingColumn => this.columnAutomationSetting;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IsBankAccountColumn => this.columnIsBankAccount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccountMaster.MasterAccountsRow this[int index]
    {
      get => (dsGLAccountMaster.MasterAccountsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLAccountMaster.MasterAccountsRowChangeEventHandler MasterAccountsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLAccountMaster.MasterAccountsRowChangeEventHandler MasterAccountsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLAccountMaster.MasterAccountsRowChangeEventHandler MasterAccountsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLAccountMaster.MasterAccountsRowChangeEventHandler MasterAccountsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddMasterAccountsRow(dsGLAccountMaster.MasterAccountsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccountMaster.MasterAccountsRow AddMasterAccountsRow(
      int GLMasterId,
      string GLAccountName,
      string GLAccountShortName,
      string GLAccountNumber,
      int GLFinancialAccountNumber,
      string AcctTypeDescription,
      string AutomationSettingId,
      string AutomationSetting,
      bool IsBankAccount)
    {
      dsGLAccountMaster.MasterAccountsRow row = (dsGLAccountMaster.MasterAccountsRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) GLMasterId,
        (object) GLAccountName,
        (object) GLAccountShortName,
        (object) GLAccountNumber,
        (object) GLFinancialAccountNumber,
        (object) AcctTypeDescription,
        (object) AutomationSettingId,
        (object) AutomationSetting,
        (object) IsBankAccount
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGLAccountMaster.MasterAccountsDataTable accountsDataTable = (dsGLAccountMaster.MasterAccountsDataTable) base.Clone();
      accountsDataTable.InitVars();
      return (DataTable) accountsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLAccountMaster.MasterAccountsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnGLMasterId = this.Columns["GLMasterId"];
      this.columnGLAccountName = this.Columns["GLAccountName"];
      this.columnGLAccountShortName = this.Columns["GLAccountShortName"];
      this.columnGLAccountNumber = this.Columns["GLAccountNumber"];
      this.columnGLFinancialAccountNumber = this.Columns["GLFinancialAccountNumber"];
      this.columnAcctTypeDescription = this.Columns["AcctTypeDescription"];
      this.columnAutomationSettingId = this.Columns["AutomationSettingId"];
      this.columnAutomationSetting = this.Columns["AutomationSetting"];
      this.columnIsBankAccount = this.Columns["IsBankAccount"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnGLMasterId = new DataColumn("GLMasterId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLMasterId);
      this.columnGLAccountName = new DataColumn("GLAccountName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAccountName);
      this.columnGLAccountShortName = new DataColumn("GLAccountShortName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAccountShortName);
      this.columnGLAccountNumber = new DataColumn("GLAccountNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAccountNumber);
      this.columnGLFinancialAccountNumber = new DataColumn("GLFinancialAccountNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLFinancialAccountNumber);
      this.columnAcctTypeDescription = new DataColumn("AcctTypeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAcctTypeDescription);
      this.columnAutomationSettingId = new DataColumn("AutomationSettingId", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationSettingId);
      this.columnAutomationSetting = new DataColumn("AutomationSetting", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationSetting);
      this.columnIsBankAccount = new DataColumn("IsBankAccount", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsBankAccount);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccountMaster.MasterAccountsRow NewMasterAccountsRow()
    {
      return (dsGLAccountMaster.MasterAccountsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLAccountMaster.MasterAccountsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLAccountMaster.MasterAccountsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.MasterAccountsRowChanged == null)
        return;
      this.MasterAccountsRowChanged((object) this, new dsGLAccountMaster.MasterAccountsRowChangeEvent((dsGLAccountMaster.MasterAccountsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.MasterAccountsRowChanging == null)
        return;
      this.MasterAccountsRowChanging((object) this, new dsGLAccountMaster.MasterAccountsRowChangeEvent((dsGLAccountMaster.MasterAccountsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.MasterAccountsRowDeleted == null)
        return;
      this.MasterAccountsRowDeleted((object) this, new dsGLAccountMaster.MasterAccountsRowChangeEvent((dsGLAccountMaster.MasterAccountsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.MasterAccountsRowDeleting == null)
        return;
      this.MasterAccountsRowDeleting((object) this, new dsGLAccountMaster.MasterAccountsRowChangeEvent((dsGLAccountMaster.MasterAccountsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveMasterAccountsRow(dsGLAccountMaster.MasterAccountsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLAccountMaster dsGlAccountMaster = new dsGLAccountMaster();
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
        FixedValue = dsGlAccountMaster.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (MasterAccountsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGlAccountMaster.GetSchemaSerializable();
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

  public class MasterAccountsRow : DataRow
  {
    private dsGLAccountMaster.MasterAccountsDataTable tableMasterAccounts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal MasterAccountsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableMasterAccounts = (dsGLAccountMaster.MasterAccountsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GLMasterId
    {
      get
      {
        try
        {
          return (int) this[this.tableMasterAccounts.GLMasterIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GLMasterId' in table 'MasterAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMasterAccounts.GLMasterIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string GLAccountName
    {
      get
      {
        try
        {
          return (string) this[this.tableMasterAccounts.GLAccountNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GLAccountName' in table 'MasterAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMasterAccounts.GLAccountNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string GLAccountShortName
    {
      get
      {
        try
        {
          return (string) this[this.tableMasterAccounts.GLAccountShortNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GLAccountShortName' in table 'MasterAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMasterAccounts.GLAccountShortNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string GLAccountNumber
    {
      get
      {
        try
        {
          return (string) this[this.tableMasterAccounts.GLAccountNumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GLAccountNumber' in table 'MasterAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMasterAccounts.GLAccountNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GLFinancialAccountNumber
    {
      get
      {
        try
        {
          return (int) this[this.tableMasterAccounts.GLFinancialAccountNumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GLFinancialAccountNumber' in table 'MasterAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMasterAccounts.GLFinancialAccountNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AcctTypeDescription
    {
      get
      {
        try
        {
          return (string) this[this.tableMasterAccounts.AcctTypeDescriptionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AcctTypeDescription' in table 'MasterAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMasterAccounts.AcctTypeDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AutomationSettingId
    {
      get
      {
        try
        {
          return (string) this[this.tableMasterAccounts.AutomationSettingIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AutomationSettingId' in table 'MasterAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMasterAccounts.AutomationSettingIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AutomationSetting
    {
      get
      {
        return this.IsAutomationSettingNull() ? (string) null : (string) this[this.tableMasterAccounts.AutomationSettingColumn];
      }
      set => this[this.tableMasterAccounts.AutomationSettingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBankAccount
    {
      get
      {
        try
        {
          return (bool) this[this.tableMasterAccounts.IsBankAccountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'IsBankAccount' in table 'MasterAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMasterAccounts.IsBankAccountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLMasterIdNull() => this.IsNull(this.tableMasterAccounts.GLMasterIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLMasterIdNull()
    {
      this[this.tableMasterAccounts.GLMasterIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLAccountNameNull() => this.IsNull(this.tableMasterAccounts.GLAccountNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLAccountNameNull()
    {
      this[this.tableMasterAccounts.GLAccountNameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLAccountShortNameNull()
    {
      return this.IsNull(this.tableMasterAccounts.GLAccountShortNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLAccountShortNameNull()
    {
      this[this.tableMasterAccounts.GLAccountShortNameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLAccountNumberNull()
    {
      return this.IsNull(this.tableMasterAccounts.GLAccountNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLAccountNumberNull()
    {
      this[this.tableMasterAccounts.GLAccountNumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLFinancialAccountNumberNull()
    {
      return this.IsNull(this.tableMasterAccounts.GLFinancialAccountNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLFinancialAccountNumberNull()
    {
      this[this.tableMasterAccounts.GLFinancialAccountNumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAcctTypeDescriptionNull()
    {
      return this.IsNull(this.tableMasterAccounts.AcctTypeDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAcctTypeDescriptionNull()
    {
      this[this.tableMasterAccounts.AcctTypeDescriptionColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAutomationSettingIdNull()
    {
      return this.IsNull(this.tableMasterAccounts.AutomationSettingIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAutomationSettingIdNull()
    {
      this[this.tableMasterAccounts.AutomationSettingIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAutomationSettingNull()
    {
      return this.IsNull(this.tableMasterAccounts.AutomationSettingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAutomationSettingNull()
    {
      this[this.tableMasterAccounts.AutomationSettingColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsIsBankAccountNull() => this.IsNull(this.tableMasterAccounts.IsBankAccountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetIsBankAccountNull()
    {
      this[this.tableMasterAccounts.IsBankAccountColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class MasterAccountsRowChangeEvent : EventArgs
  {
    private dsGLAccountMaster.MasterAccountsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public MasterAccountsRowChangeEvent(
      dsGLAccountMaster.MasterAccountsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccountMaster.MasterAccountsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
