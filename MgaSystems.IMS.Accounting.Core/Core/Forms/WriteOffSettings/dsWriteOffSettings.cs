// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.WriteOffSettings.dsWriteOffSettings
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
namespace MGASystems.IMS.Accounting.Core.Forms.WriteOffSettings;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsWriteOffSettings")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsWriteOffSettings : DataSet
{
  private dsWriteOffSettings.SettingsDataTable tableSettings;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsWriteOffSettings()
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
  protected dsWriteOffSettings(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (Settings)] != null)
          base.Tables.Add((DataTable) new dsWriteOffSettings.SettingsDataTable(dataSet.Tables[nameof (Settings)]));
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
  public dsWriteOffSettings.SettingsDataTable Settings => this.tableSettings;

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
    dsWriteOffSettings writeOffSettings = (dsWriteOffSettings) base.Clone();
    writeOffSettings.InitVars();
    writeOffSettings.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) writeOffSettings;
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
      if (dataSet.Tables["Settings"] != null)
        base.Tables.Add((DataTable) new dsWriteOffSettings.SettingsDataTable(dataSet.Tables["Settings"]));
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
    this.tableSettings = (dsWriteOffSettings.SettingsDataTable) base.Tables["Settings"];
    if (!initTable || this.tableSettings == null)
      return;
    this.tableSettings.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsWriteOffSettings);
    this.Prefix = "";
    this.Namespace = "MGASystems.IMS.Accounting.Core.Forms.WriteOffSettings";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableSettings = new dsWriteOffSettings.SettingsDataTable();
    base.Tables.Add((DataTable) this.tableSettings);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeSettings() => false;

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
    dsWriteOffSettings writeOffSettings = new dsWriteOffSettings();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = writeOffSettings.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = writeOffSettings.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void SettingsRowChangeEventHandler(
    object sender,
    dsWriteOffSettings.SettingsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class SettingsDataTable : TypedTableBase<dsWriteOffSettings.SettingsRow>
  {
    private DataColumn columnGlCompanyId;
    private DataColumn columnOfficeLocation;
    private DataColumn columnGLAcctId_AR;
    private DataColumn columnARAccount;
    private DataColumn columnGLAcctId_AP;
    private DataColumn columnAPAccount;
    private DataColumn columnGLAcctId_EX;
    private DataColumn columnEXAccount;
    private DataColumn columnGLAcctId_UA;
    private DataColumn columnUAAccount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public SettingsDataTable()
    {
      this.TableName = "Settings";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal SettingsDataTable(DataTable table)
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
    protected SettingsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GlCompanyIdColumn => this.columnGlCompanyId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OfficeLocationColumn => this.columnOfficeLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLAcctId_ARColumn => this.columnGLAcctId_AR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ARAccountColumn => this.columnARAccount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLAcctId_APColumn => this.columnGLAcctId_AP;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn APAccountColumn => this.columnAPAccount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLAcctId_EXColumn => this.columnGLAcctId_EX;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EXAccountColumn => this.columnEXAccount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLAcctId_UAColumn => this.columnGLAcctId_UA;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UAAccountColumn => this.columnUAAccount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsWriteOffSettings.SettingsRow this[int index]
    {
      get => (dsWriteOffSettings.SettingsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsWriteOffSettings.SettingsRowChangeEventHandler SettingsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsWriteOffSettings.SettingsRowChangeEventHandler SettingsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsWriteOffSettings.SettingsRowChangeEventHandler SettingsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsWriteOffSettings.SettingsRowChangeEventHandler SettingsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddSettingsRow(dsWriteOffSettings.SettingsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsWriteOffSettings.SettingsRow AddSettingsRow(
      int GlCompanyId,
      string OfficeLocation,
      int GLAcctId_AR,
      string ARAccount,
      int GLAcctId_AP,
      string APAccount,
      int GLAcctId_EX,
      string EXAccount,
      int GLAcctId_UA,
      string UAAccount)
    {
      dsWriteOffSettings.SettingsRow row = (dsWriteOffSettings.SettingsRow) this.NewRow();
      object[] objArray = new object[10]
      {
        (object) GlCompanyId,
        (object) OfficeLocation,
        (object) GLAcctId_AR,
        (object) ARAccount,
        (object) GLAcctId_AP,
        (object) APAccount,
        (object) GLAcctId_EX,
        (object) EXAccount,
        (object) GLAcctId_UA,
        (object) UAAccount
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsWriteOffSettings.SettingsDataTable settingsDataTable = (dsWriteOffSettings.SettingsDataTable) base.Clone();
      settingsDataTable.InitVars();
      return (DataTable) settingsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsWriteOffSettings.SettingsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnGlCompanyId = this.Columns["GlCompanyId"];
      this.columnOfficeLocation = this.Columns["OfficeLocation"];
      this.columnGLAcctId_AR = this.Columns["GLAcctId_AR"];
      this.columnARAccount = this.Columns["ARAccount"];
      this.columnGLAcctId_AP = this.Columns["GLAcctId_AP"];
      this.columnAPAccount = this.Columns["APAccount"];
      this.columnGLAcctId_EX = this.Columns["GLAcctId_EX"];
      this.columnEXAccount = this.Columns["EXAccount"];
      this.columnGLAcctId_UA = this.Columns["GLAcctId_UA"];
      this.columnUAAccount = this.Columns["UAAccount"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnGlCompanyId = new DataColumn("GlCompanyId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGlCompanyId);
      this.columnOfficeLocation = new DataColumn("OfficeLocation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeLocation);
      this.columnGLAcctId_AR = new DataColumn("GLAcctId_AR", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAcctId_AR);
      this.columnARAccount = new DataColumn("ARAccount", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnARAccount);
      this.columnGLAcctId_AP = new DataColumn("GLAcctId_AP", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAcctId_AP);
      this.columnAPAccount = new DataColumn("APAccount", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAPAccount);
      this.columnGLAcctId_EX = new DataColumn("GLAcctId_EX", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAcctId_EX);
      this.columnEXAccount = new DataColumn("EXAccount", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEXAccount);
      this.columnGLAcctId_UA = new DataColumn("GLAcctId_UA", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAcctId_UA);
      this.columnUAAccount = new DataColumn("UAAccount", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUAAccount);
      this.columnGLAcctId_AR.DefaultValue = (object) -1;
      this.columnGLAcctId_AP.DefaultValue = (object) -1;
      this.columnGLAcctId_EX.DefaultValue = (object) -1;
      this.columnGLAcctId_UA.DefaultValue = (object) -1;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsWriteOffSettings.SettingsRow NewSettingsRow()
    {
      return (dsWriteOffSettings.SettingsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsWriteOffSettings.SettingsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsWriteOffSettings.SettingsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.SettingsRowChanged == null)
        return;
      this.SettingsRowChanged((object) this, new dsWriteOffSettings.SettingsRowChangeEvent((dsWriteOffSettings.SettingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.SettingsRowChanging == null)
        return;
      this.SettingsRowChanging((object) this, new dsWriteOffSettings.SettingsRowChangeEvent((dsWriteOffSettings.SettingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.SettingsRowDeleted == null)
        return;
      this.SettingsRowDeleted((object) this, new dsWriteOffSettings.SettingsRowChangeEvent((dsWriteOffSettings.SettingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.SettingsRowDeleting == null)
        return;
      this.SettingsRowDeleting((object) this, new dsWriteOffSettings.SettingsRowChangeEvent((dsWriteOffSettings.SettingsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveSettingsRow(dsWriteOffSettings.SettingsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsWriteOffSettings writeOffSettings = new dsWriteOffSettings();
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
        FixedValue = writeOffSettings.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (SettingsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = writeOffSettings.GetSchemaSerializable();
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

  public class SettingsRow : DataRow
  {
    private dsWriteOffSettings.SettingsDataTable tableSettings;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal SettingsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableSettings = (dsWriteOffSettings.SettingsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GlCompanyId
    {
      get
      {
        try
        {
          return (int) this[this.tableSettings.GlCompanyIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GlCompanyId' in table 'Settings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettings.GlCompanyIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string OfficeLocation
    {
      get
      {
        try
        {
          return (string) this[this.tableSettings.OfficeLocationColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'OfficeLocation' in table 'Settings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettings.OfficeLocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GLAcctId_AR
    {
      get
      {
        try
        {
          return (int) this[this.tableSettings.GLAcctId_ARColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GLAcctId_AR' in table 'Settings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettings.GLAcctId_ARColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ARAccount
    {
      get
      {
        try
        {
          return (string) this[this.tableSettings.ARAccountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ARAccount' in table 'Settings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettings.ARAccountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GLAcctId_AP
    {
      get
      {
        try
        {
          return (int) this[this.tableSettings.GLAcctId_APColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GLAcctId_AP' in table 'Settings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettings.GLAcctId_APColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string APAccount
    {
      get
      {
        try
        {
          return (string) this[this.tableSettings.APAccountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'APAccount' in table 'Settings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettings.APAccountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GLAcctId_EX
    {
      get
      {
        try
        {
          return (int) this[this.tableSettings.GLAcctId_EXColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GLAcctId_EX' in table 'Settings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettings.GLAcctId_EXColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string EXAccount
    {
      get
      {
        try
        {
          return (string) this[this.tableSettings.EXAccountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EXAccount' in table 'Settings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettings.EXAccountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GLAcctId_UA
    {
      get
      {
        try
        {
          return (int) this[this.tableSettings.GLAcctId_UAColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GLAcctId_UA' in table 'Settings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettings.GLAcctId_UAColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string UAAccount
    {
      get
      {
        try
        {
          return (string) this[this.tableSettings.UAAccountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'UAAccount' in table 'Settings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettings.UAAccountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGlCompanyIdNull() => this.IsNull(this.tableSettings.GlCompanyIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGlCompanyIdNull() => this[this.tableSettings.GlCompanyIdColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOfficeLocationNull() => this.IsNull(this.tableSettings.OfficeLocationColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOfficeLocationNull()
    {
      this[this.tableSettings.OfficeLocationColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLAcctId_ARNull() => this.IsNull(this.tableSettings.GLAcctId_ARColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLAcctId_ARNull() => this[this.tableSettings.GLAcctId_ARColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsARAccountNull() => this.IsNull(this.tableSettings.ARAccountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetARAccountNull() => this[this.tableSettings.ARAccountColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLAcctId_APNull() => this.IsNull(this.tableSettings.GLAcctId_APColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLAcctId_APNull() => this[this.tableSettings.GLAcctId_APColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAPAccountNull() => this.IsNull(this.tableSettings.APAccountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAPAccountNull() => this[this.tableSettings.APAccountColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLAcctId_EXNull() => this.IsNull(this.tableSettings.GLAcctId_EXColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLAcctId_EXNull() => this[this.tableSettings.GLAcctId_EXColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEXAccountNull() => this.IsNull(this.tableSettings.EXAccountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEXAccountNull() => this[this.tableSettings.EXAccountColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLAcctId_UANull() => this.IsNull(this.tableSettings.GLAcctId_UAColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLAcctId_UANull() => this[this.tableSettings.GLAcctId_UAColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUAAccountNull() => this.IsNull(this.tableSettings.UAAccountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUAAccountNull() => this[this.tableSettings.UAAccountColumn] = Convert.DBNull;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class SettingsRowChangeEvent : EventArgs
  {
    private dsWriteOffSettings.SettingsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public SettingsRowChangeEvent(dsWriteOffSettings.SettingsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsWriteOffSettings.SettingsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
