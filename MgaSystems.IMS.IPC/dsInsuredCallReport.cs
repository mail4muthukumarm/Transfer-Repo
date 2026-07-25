// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.dsInsuredCallReport
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
[XmlRoot("dsInsuredCallReport")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsInsuredCallReport : DataSet
{
  private dsInsuredCallReport.lstInsuredCallReportTypeDataTable tablelstInsuredCallReportType;
  private dsInsuredCallReport.tblUsersDataTable tabletblUsers;
  private dsInsuredCallReport.tblInsuredCallReportDataTable tabletblInsuredCallReport;
  private dsInsuredCallReport.tblInsuredCallReportContactsDataTable tabletblInsuredCallReportContacts;
  private dsInsuredCallReport.tblInsuredCallReportUsersDataTable tabletblInsuredCallReportUsers;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public dsInsuredCallReport()
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
  protected dsInsuredCallReport(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstInsuredCallReportType)] != null)
          base.Tables.Add((DataTable) new dsInsuredCallReport.lstInsuredCallReportTypeDataTable(dataSet.Tables[nameof (lstInsuredCallReportType)]));
        if (dataSet.Tables[nameof (tblUsers)] != null)
          base.Tables.Add((DataTable) new dsInsuredCallReport.tblUsersDataTable(dataSet.Tables[nameof (tblUsers)]));
        if (dataSet.Tables[nameof (tblInsuredCallReport)] != null)
          base.Tables.Add((DataTable) new dsInsuredCallReport.tblInsuredCallReportDataTable(dataSet.Tables[nameof (tblInsuredCallReport)]));
        if (dataSet.Tables[nameof (tblInsuredCallReportContacts)] != null)
          base.Tables.Add((DataTable) new dsInsuredCallReport.tblInsuredCallReportContactsDataTable(dataSet.Tables[nameof (tblInsuredCallReportContacts)]));
        if (dataSet.Tables[nameof (tblInsuredCallReportUsers)] != null)
          base.Tables.Add((DataTable) new dsInsuredCallReport.tblInsuredCallReportUsersDataTable(dataSet.Tables[nameof (tblInsuredCallReportUsers)]));
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
  public dsInsuredCallReport.lstInsuredCallReportTypeDataTable lstInsuredCallReportType
  {
    get => this.tablelstInsuredCallReportType;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsuredCallReport.tblUsersDataTable tblUsers => this.tabletblUsers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsuredCallReport.tblInsuredCallReportDataTable tblInsuredCallReport
  {
    get => this.tabletblInsuredCallReport;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsuredCallReport.tblInsuredCallReportContactsDataTable tblInsuredCallReportContacts
  {
    get => this.tabletblInsuredCallReportContacts;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInsuredCallReport.tblInsuredCallReportUsersDataTable tblInsuredCallReportUsers
  {
    get => this.tabletblInsuredCallReportUsers;
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
    dsInsuredCallReport insuredCallReport = (dsInsuredCallReport) base.Clone();
    insuredCallReport.InitVars();
    insuredCallReport.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) insuredCallReport;
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
      if (dataSet.Tables["lstInsuredCallReportType"] != null)
        base.Tables.Add((DataTable) new dsInsuredCallReport.lstInsuredCallReportTypeDataTable(dataSet.Tables["lstInsuredCallReportType"]));
      if (dataSet.Tables["tblUsers"] != null)
        base.Tables.Add((DataTable) new dsInsuredCallReport.tblUsersDataTable(dataSet.Tables["tblUsers"]));
      if (dataSet.Tables["tblInsuredCallReport"] != null)
        base.Tables.Add((DataTable) new dsInsuredCallReport.tblInsuredCallReportDataTable(dataSet.Tables["tblInsuredCallReport"]));
      if (dataSet.Tables["tblInsuredCallReportContacts"] != null)
        base.Tables.Add((DataTable) new dsInsuredCallReport.tblInsuredCallReportContactsDataTable(dataSet.Tables["tblInsuredCallReportContacts"]));
      if (dataSet.Tables["tblInsuredCallReportUsers"] != null)
        base.Tables.Add((DataTable) new dsInsuredCallReport.tblInsuredCallReportUsersDataTable(dataSet.Tables["tblInsuredCallReportUsers"]));
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
    this.tablelstInsuredCallReportType = (dsInsuredCallReport.lstInsuredCallReportTypeDataTable) base.Tables["lstInsuredCallReportType"];
    if (initTable && this.tablelstInsuredCallReportType != null)
      this.tablelstInsuredCallReportType.InitVars();
    this.tabletblUsers = (dsInsuredCallReport.tblUsersDataTable) base.Tables["tblUsers"];
    if (initTable && this.tabletblUsers != null)
      this.tabletblUsers.InitVars();
    this.tabletblInsuredCallReport = (dsInsuredCallReport.tblInsuredCallReportDataTable) base.Tables["tblInsuredCallReport"];
    if (initTable && this.tabletblInsuredCallReport != null)
      this.tabletblInsuredCallReport.InitVars();
    this.tabletblInsuredCallReportContacts = (dsInsuredCallReport.tblInsuredCallReportContactsDataTable) base.Tables["tblInsuredCallReportContacts"];
    if (initTable && this.tabletblInsuredCallReportContacts != null)
      this.tabletblInsuredCallReportContacts.InitVars();
    this.tabletblInsuredCallReportUsers = (dsInsuredCallReport.tblInsuredCallReportUsersDataTable) base.Tables["tblInsuredCallReportUsers"];
    if (!initTable || this.tabletblInsuredCallReportUsers == null)
      return;
    this.tabletblInsuredCallReportUsers.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsInsuredCallReport);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsInsuredCallReport.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstInsuredCallReportType = new dsInsuredCallReport.lstInsuredCallReportTypeDataTable();
    base.Tables.Add((DataTable) this.tablelstInsuredCallReportType);
    this.tabletblUsers = new dsInsuredCallReport.tblUsersDataTable();
    base.Tables.Add((DataTable) this.tabletblUsers);
    this.tabletblInsuredCallReport = new dsInsuredCallReport.tblInsuredCallReportDataTable();
    base.Tables.Add((DataTable) this.tabletblInsuredCallReport);
    this.tabletblInsuredCallReportContacts = new dsInsuredCallReport.tblInsuredCallReportContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblInsuredCallReportContacts);
    this.tabletblInsuredCallReportUsers = new dsInsuredCallReport.tblInsuredCallReportUsersDataTable();
    base.Tables.Add((DataTable) this.tabletblInsuredCallReportUsers);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializelstInsuredCallReportType() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblUsers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblInsuredCallReport() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblInsuredCallReportContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblInsuredCallReportUsers() => false;

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
    dsInsuredCallReport insuredCallReport = new dsInsuredCallReport();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = insuredCallReport.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = insuredCallReport.GetSchemaSerializable();
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
  public delegate void lstInsuredCallReportTypeRowChangeEventHandler(
    object sender,
    dsInsuredCallReport.lstInsuredCallReportTypeRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblUsersRowChangeEventHandler(
    object sender,
    dsInsuredCallReport.tblUsersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblInsuredCallReportRowChangeEventHandler(
    object sender,
    dsInsuredCallReport.tblInsuredCallReportRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblInsuredCallReportContactsRowChangeEventHandler(
    object sender,
    dsInsuredCallReport.tblInsuredCallReportContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblInsuredCallReportUsersRowChangeEventHandler(
    object sender,
    dsInsuredCallReport.tblInsuredCallReportUsersRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstInsuredCallReportTypeDataTable : 
    TypedTableBase<dsInsuredCallReport.lstInsuredCallReportTypeRow>
  {
    private DataColumn columnID;
    private DataColumn columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public lstInsuredCallReportTypeDataTable()
    {
      this.TableName = "lstInsuredCallReportType";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal lstInsuredCallReportTypeDataTable(DataTable table)
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
    protected lstInsuredCallReportTypeDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.lstInsuredCallReportTypeRow this[int index]
    {
      get => (dsInsuredCallReport.lstInsuredCallReportTypeRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.lstInsuredCallReportTypeRowChangeEventHandler lstInsuredCallReportTypeRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.lstInsuredCallReportTypeRowChangeEventHandler lstInsuredCallReportTypeRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.lstInsuredCallReportTypeRowChangeEventHandler lstInsuredCallReportTypeRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.lstInsuredCallReportTypeRowChangeEventHandler lstInsuredCallReportTypeRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddlstInsuredCallReportTypeRow(
      dsInsuredCallReport.lstInsuredCallReportTypeRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.lstInsuredCallReportTypeRow AddlstInsuredCallReportTypeRow(
      string Type)
    {
      dsInsuredCallReport.lstInsuredCallReportTypeRow row = (dsInsuredCallReport.lstInsuredCallReportTypeRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) Type
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.lstInsuredCallReportTypeRow FindByID(int ID)
    {
      return (dsInsuredCallReport.lstInsuredCallReportTypeRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsInsuredCallReport.lstInsuredCallReportTypeDataTable reportTypeDataTable = (dsInsuredCallReport.lstInsuredCallReportTypeDataTable) base.Clone();
      reportTypeDataTable.InitVars();
      return (DataTable) reportTypeDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsuredCallReport.lstInsuredCallReportTypeDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnType = this.Columns["Type"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnType = new DataColumn("Type", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AutoIncrementSeed = -1L;
      this.columnID.AutoIncrementStep = -1L;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnType.AllowDBNull = false;
      this.columnType.MaxLength = 100;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.lstInsuredCallReportTypeRow NewlstInsuredCallReportTypeRow()
    {
      return (dsInsuredCallReport.lstInsuredCallReportTypeRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsuredCallReport.lstInsuredCallReportTypeRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsInsuredCallReport.lstInsuredCallReportTypeRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredCallReportTypeRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.lstInsuredCallReportTypeRowChangeEventHandler typeRowChangedEvent = this.lstInsuredCallReportTypeRowChangedEvent;
      if (typeRowChangedEvent == null)
        return;
      typeRowChangedEvent((object) this, new dsInsuredCallReport.lstInsuredCallReportTypeRowChangeEvent((dsInsuredCallReport.lstInsuredCallReportTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredCallReportTypeRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.lstInsuredCallReportTypeRowChangeEventHandler rowChangingEvent = this.lstInsuredCallReportTypeRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsuredCallReport.lstInsuredCallReportTypeRowChangeEvent((dsInsuredCallReport.lstInsuredCallReportTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredCallReportTypeRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.lstInsuredCallReportTypeRowChangeEventHandler typeRowDeletedEvent = this.lstInsuredCallReportTypeRowDeletedEvent;
      if (typeRowDeletedEvent == null)
        return;
      typeRowDeletedEvent((object) this, new dsInsuredCallReport.lstInsuredCallReportTypeRowChangeEvent((dsInsuredCallReport.lstInsuredCallReportTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstInsuredCallReportTypeRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.lstInsuredCallReportTypeRowChangeEventHandler rowDeletingEvent = this.lstInsuredCallReportTypeRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsuredCallReport.lstInsuredCallReportTypeRowChangeEvent((dsInsuredCallReport.lstInsuredCallReportTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovelstInsuredCallReportTypeRow(
      dsInsuredCallReport.lstInsuredCallReportTypeRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsuredCallReport insuredCallReport = new dsInsuredCallReport();
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
        FixedValue = insuredCallReport.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstInsuredCallReportTypeDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = insuredCallReport.GetSchemaSerializable();
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
  public class tblUsersDataTable : TypedTableBase<dsInsuredCallReport.tblUsersRow>
  {
    private DataColumn columnUserID;
    private DataColumn columnName_LastFirst;
    private DataColumn columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblUsersDataTable()
    {
      this.TableName = "tblUsers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblUsersDataTable(DataTable table)
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
    protected tblUsersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn UserIDColumn => this.columnUserID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Name_LastFirstColumn => this.columnName_LastFirst;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblUsersRow this[int index]
    {
      get => (dsInsuredCallReport.tblUsersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblUsersRowChangeEventHandler tblUsersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblUsersRowChangeEventHandler tblUsersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblUsersRowChangeEventHandler tblUsersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblUsersRowChangeEventHandler tblUsersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblUsersRow(dsInsuredCallReport.tblUsersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblUsersRow AddtblUsersRow(string Name_LastFirst, int StatusID)
    {
      dsInsuredCallReport.tblUsersRow row = (dsInsuredCallReport.tblUsersRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) Name_LastFirst,
        (object) StatusID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsInsuredCallReport.tblUsersDataTable tblUsersDataTable = (dsInsuredCallReport.tblUsersDataTable) base.Clone();
      tblUsersDataTable.InitVars();
      return (DataTable) tblUsersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsuredCallReport.tblUsersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnUserID = this.Columns["UserID"];
      this.columnName_LastFirst = this.Columns["Name_LastFirst"];
      this.columnStatusID = this.Columns["StatusID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnUserID = new DataColumn("UserID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserID);
      this.columnName_LastFirst = new DataColumn("Name_LastFirst", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName_LastFirst);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnUserID.AutoIncrement = true;
      this.columnUserID.AutoIncrementSeed = -1L;
      this.columnUserID.AutoIncrementStep = -1L;
      this.columnUserID.AllowDBNull = false;
      this.columnUserID.ReadOnly = true;
      this.columnName_LastFirst.ReadOnly = true;
      this.columnName_LastFirst.MaxLength = 102;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblUsersRow NewtblUsersRow()
    {
      return (dsInsuredCallReport.tblUsersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsuredCallReport.tblUsersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsuredCallReport.tblUsersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblUsersRowChangeEventHandler usersRowChangedEvent = this.tblUsersRowChangedEvent;
      if (usersRowChangedEvent == null)
        return;
      usersRowChangedEvent((object) this, new dsInsuredCallReport.tblUsersRowChangeEvent((dsInsuredCallReport.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblUsersRowChangeEventHandler rowChangingEvent = this.tblUsersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsuredCallReport.tblUsersRowChangeEvent((dsInsuredCallReport.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblUsersRowChangeEventHandler usersRowDeletedEvent = this.tblUsersRowDeletedEvent;
      if (usersRowDeletedEvent == null)
        return;
      usersRowDeletedEvent((object) this, new dsInsuredCallReport.tblUsersRowChangeEvent((dsInsuredCallReport.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblUsersRowChangeEventHandler rowDeletingEvent = this.tblUsersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsuredCallReport.tblUsersRowChangeEvent((dsInsuredCallReport.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblUsersRow(dsInsuredCallReport.tblUsersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsuredCallReport insuredCallReport = new dsInsuredCallReport();
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
        FixedValue = insuredCallReport.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUsersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = insuredCallReport.GetSchemaSerializable();
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
  public class tblInsuredCallReportDataTable : 
    TypedTableBase<dsInsuredCallReport.tblInsuredCallReportRow>
  {
    private DataColumn columnCallReportID;
    private DataColumn columnDateOfVisit;
    private DataColumn columnCallType;
    private DataColumn columnLeadContactID;
    private DataColumn columnMeetingNotes;
    private DataColumn columnInsuredLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblInsuredCallReportDataTable()
    {
      this.TableName = "tblInsuredCallReport";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblInsuredCallReportDataTable(DataTable table)
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
    protected tblInsuredCallReportDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CallReportIDColumn => this.columnCallReportID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DateOfVisitColumn => this.columnDateOfVisit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CallTypeColumn => this.columnCallType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn LeadContactIDColumn => this.columnLeadContactID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn MeetingNotesColumn => this.columnMeetingNotes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn InsuredLocationGuidColumn => this.columnInsuredLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblInsuredCallReportRow this[int index]
    {
      get => (dsInsuredCallReport.tblInsuredCallReportRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblInsuredCallReportRowChangeEventHandler tblInsuredCallReportRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblInsuredCallReportRowChangeEventHandler tblInsuredCallReportRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblInsuredCallReportRowChangeEventHandler tblInsuredCallReportRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblInsuredCallReportRowChangeEventHandler tblInsuredCallReportRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblInsuredCallReportRow(dsInsuredCallReport.tblInsuredCallReportRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblInsuredCallReportRow AddtblInsuredCallReportRow(
      DateTime DateOfVisit,
      short CallType,
      int LeadContactID,
      string MeetingNotes,
      Guid InsuredLocationGuid)
    {
      dsInsuredCallReport.tblInsuredCallReportRow row = (dsInsuredCallReport.tblInsuredCallReportRow) this.NewRow();
      object[] objArray = new object[6]
      {
        null,
        (object) DateOfVisit,
        (object) CallType,
        (object) LeadContactID,
        (object) MeetingNotes,
        (object) InsuredLocationGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblInsuredCallReportRow FindByCallReportID(int CallReportID)
    {
      return (dsInsuredCallReport.tblInsuredCallReportRow) this.Rows.Find(new object[1]
      {
        (object) CallReportID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsInsuredCallReport.tblInsuredCallReportDataTable callReportDataTable = (dsInsuredCallReport.tblInsuredCallReportDataTable) base.Clone();
      callReportDataTable.InitVars();
      return (DataTable) callReportDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsuredCallReport.tblInsuredCallReportDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnCallReportID = this.Columns["CallReportID"];
      this.columnDateOfVisit = this.Columns["DateOfVisit"];
      this.columnCallType = this.Columns["CallType"];
      this.columnLeadContactID = this.Columns["LeadContactID"];
      this.columnMeetingNotes = this.Columns["MeetingNotes"];
      this.columnInsuredLocationGuid = this.Columns["InsuredLocationGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnCallReportID = new DataColumn("CallReportID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCallReportID);
      this.columnDateOfVisit = new DataColumn("DateOfVisit", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateOfVisit);
      this.columnCallType = new DataColumn("CallType", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCallType);
      this.columnLeadContactID = new DataColumn("LeadContactID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLeadContactID);
      this.columnMeetingNotes = new DataColumn("MeetingNotes", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMeetingNotes);
      this.columnInsuredLocationGuid = new DataColumn("InsuredLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredLocationGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCallReportID
      }, true));
      this.columnCallReportID.AutoIncrement = true;
      this.columnCallReportID.AutoIncrementSeed = -1L;
      this.columnCallReportID.AutoIncrementStep = -1L;
      this.columnCallReportID.AllowDBNull = false;
      this.columnCallReportID.ReadOnly = true;
      this.columnCallReportID.Unique = true;
      this.columnMeetingNotes.MaxLength = int.MaxValue;
      this.columnInsuredLocationGuid.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblInsuredCallReportRow NewtblInsuredCallReportRow()
    {
      return (dsInsuredCallReport.tblInsuredCallReportRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsuredCallReport.tblInsuredCallReportRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsuredCallReport.tblInsuredCallReportRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblInsuredCallReportRowChangeEventHandler reportRowChangedEvent = this.tblInsuredCallReportRowChangedEvent;
      if (reportRowChangedEvent == null)
        return;
      reportRowChangedEvent((object) this, new dsInsuredCallReport.tblInsuredCallReportRowChangeEvent((dsInsuredCallReport.tblInsuredCallReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblInsuredCallReportRowChangeEventHandler rowChangingEvent = this.tblInsuredCallReportRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsuredCallReport.tblInsuredCallReportRowChangeEvent((dsInsuredCallReport.tblInsuredCallReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblInsuredCallReportRowChangeEventHandler reportRowDeletedEvent = this.tblInsuredCallReportRowDeletedEvent;
      if (reportRowDeletedEvent == null)
        return;
      reportRowDeletedEvent((object) this, new dsInsuredCallReport.tblInsuredCallReportRowChangeEvent((dsInsuredCallReport.tblInsuredCallReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblInsuredCallReportRowChangeEventHandler rowDeletingEvent = this.tblInsuredCallReportRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsuredCallReport.tblInsuredCallReportRowChangeEvent((dsInsuredCallReport.tblInsuredCallReportRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblInsuredCallReportRow(dsInsuredCallReport.tblInsuredCallReportRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsuredCallReport insuredCallReport = new dsInsuredCallReport();
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
        FixedValue = insuredCallReport.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblInsuredCallReportDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = insuredCallReport.GetSchemaSerializable();
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
  public class tblInsuredCallReportContactsDataTable : 
    TypedTableBase<dsInsuredCallReport.tblInsuredCallReportContactsRow>
  {
    private DataColumn columnCallReportID;
    private DataColumn columnInsuredContactGUID;
    private DataColumn columnContactName;
    private DataColumn columnID;
    private DataColumn columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblInsuredCallReportContactsDataTable()
    {
      this.TableName = "tblInsuredCallReportContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblInsuredCallReportContactsDataTable(DataTable table)
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
    protected tblInsuredCallReportContactsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CallReportIDColumn => this.columnCallReportID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn InsuredContactGUIDColumn => this.columnInsuredContactGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ContactNameColumn => this.columnContactName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblInsuredCallReportContactsRow this[int index]
    {
      get => (dsInsuredCallReport.tblInsuredCallReportContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblInsuredCallReportContactsRowChangeEventHandler tblInsuredCallReportContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblInsuredCallReportContactsRowChangeEventHandler tblInsuredCallReportContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblInsuredCallReportContactsRowChangeEventHandler tblInsuredCallReportContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblInsuredCallReportContactsRowChangeEventHandler tblInsuredCallReportContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblInsuredCallReportContactsRow(
      dsInsuredCallReport.tblInsuredCallReportContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblInsuredCallReportContactsRow AddtblInsuredCallReportContactsRow(
      int CallReportID,
      Guid InsuredContactGUID,
      string ContactName,
      int StatusID)
    {
      dsInsuredCallReport.tblInsuredCallReportContactsRow row = (dsInsuredCallReport.tblInsuredCallReportContactsRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) CallReportID,
        (object) InsuredContactGUID,
        (object) ContactName,
        null,
        (object) StatusID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblInsuredCallReportContactsRow FindByID(int ID)
    {
      return (dsInsuredCallReport.tblInsuredCallReportContactsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsInsuredCallReport.tblInsuredCallReportContactsDataTable contactsDataTable = (dsInsuredCallReport.tblInsuredCallReportContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsuredCallReport.tblInsuredCallReportContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnCallReportID = this.Columns["CallReportID"];
      this.columnInsuredContactGUID = this.Columns["InsuredContactGUID"];
      this.columnContactName = this.Columns["ContactName"];
      this.columnID = this.Columns["ID"];
      this.columnStatusID = this.Columns["StatusID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnCallReportID = new DataColumn("CallReportID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCallReportID);
      this.columnInsuredContactGUID = new DataColumn("InsuredContactGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredContactGUID);
      this.columnContactName = new DataColumn("ContactName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactName);
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AutoIncrementSeed = -1L;
      this.columnID.AutoIncrementStep = -1L;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblInsuredCallReportContactsRow NewtblInsuredCallReportContactsRow()
    {
      return (dsInsuredCallReport.tblInsuredCallReportContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsuredCallReport.tblInsuredCallReportContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsInsuredCallReport.tblInsuredCallReportContactsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblInsuredCallReportContactsRowChangeEventHandler contactsRowChangedEvent = this.tblInsuredCallReportContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsInsuredCallReport.tblInsuredCallReportContactsRowChangeEvent((dsInsuredCallReport.tblInsuredCallReportContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblInsuredCallReportContactsRowChangeEventHandler rowChangingEvent = this.tblInsuredCallReportContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsuredCallReport.tblInsuredCallReportContactsRowChangeEvent((dsInsuredCallReport.tblInsuredCallReportContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblInsuredCallReportContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblInsuredCallReportContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsInsuredCallReport.tblInsuredCallReportContactsRowChangeEvent((dsInsuredCallReport.tblInsuredCallReportContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblInsuredCallReportContactsRowChangeEventHandler rowDeletingEvent = this.tblInsuredCallReportContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsuredCallReport.tblInsuredCallReportContactsRowChangeEvent((dsInsuredCallReport.tblInsuredCallReportContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblInsuredCallReportContactsRow(
      dsInsuredCallReport.tblInsuredCallReportContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsuredCallReport insuredCallReport = new dsInsuredCallReport();
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
        FixedValue = insuredCallReport.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblInsuredCallReportContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = insuredCallReport.GetSchemaSerializable();
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
  public class tblInsuredCallReportUsersDataTable : 
    TypedTableBase<dsInsuredCallReport.tblInsuredCallReportUsersRow>
  {
    private DataColumn columnCallReportID;
    private DataColumn columnUserID;
    private DataColumn columnName_LastFirst;
    private DataColumn columnID;
    private DataColumn columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblInsuredCallReportUsersDataTable()
    {
      this.TableName = "tblInsuredCallReportUsers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblInsuredCallReportUsersDataTable(DataTable table)
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
    protected tblInsuredCallReportUsersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CallReportIDColumn => this.columnCallReportID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn UserIDColumn => this.columnUserID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Name_LastFirstColumn => this.columnName_LastFirst;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblInsuredCallReportUsersRow this[int index]
    {
      get => (dsInsuredCallReport.tblInsuredCallReportUsersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblInsuredCallReportUsersRowChangeEventHandler tblInsuredCallReportUsersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblInsuredCallReportUsersRowChangeEventHandler tblInsuredCallReportUsersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblInsuredCallReportUsersRowChangeEventHandler tblInsuredCallReportUsersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInsuredCallReport.tblInsuredCallReportUsersRowChangeEventHandler tblInsuredCallReportUsersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblInsuredCallReportUsersRow(
      dsInsuredCallReport.tblInsuredCallReportUsersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblInsuredCallReportUsersRow AddtblInsuredCallReportUsersRow(
      int CallReportID,
      int UserID,
      string Name_LastFirst,
      int StatusID)
    {
      dsInsuredCallReport.tblInsuredCallReportUsersRow row = (dsInsuredCallReport.tblInsuredCallReportUsersRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) CallReportID,
        (object) UserID,
        (object) Name_LastFirst,
        null,
        (object) StatusID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblInsuredCallReportUsersRow FindByID(int ID)
    {
      return (dsInsuredCallReport.tblInsuredCallReportUsersRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsInsuredCallReport.tblInsuredCallReportUsersDataTable reportUsersDataTable = (dsInsuredCallReport.tblInsuredCallReportUsersDataTable) base.Clone();
      reportUsersDataTable.InitVars();
      return (DataTable) reportUsersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsuredCallReport.tblInsuredCallReportUsersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnCallReportID = this.Columns["CallReportID"];
      this.columnUserID = this.Columns["UserID"];
      this.columnName_LastFirst = this.Columns["Name_LastFirst"];
      this.columnID = this.Columns["ID"];
      this.columnStatusID = this.Columns["StatusID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnCallReportID = new DataColumn("CallReportID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCallReportID);
      this.columnUserID = new DataColumn("UserID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserID);
      this.columnName_LastFirst = new DataColumn("Name_LastFirst", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName_LastFirst);
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AutoIncrementSeed = -1L;
      this.columnID.AutoIncrementStep = -1L;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblInsuredCallReportUsersRow NewtblInsuredCallReportUsersRow()
    {
      return (dsInsuredCallReport.tblInsuredCallReportUsersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsuredCallReport.tblInsuredCallReportUsersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsInsuredCallReport.tblInsuredCallReportUsersRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportUsersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblInsuredCallReportUsersRowChangeEventHandler usersRowChangedEvent = this.tblInsuredCallReportUsersRowChangedEvent;
      if (usersRowChangedEvent == null)
        return;
      usersRowChangedEvent((object) this, new dsInsuredCallReport.tblInsuredCallReportUsersRowChangeEvent((dsInsuredCallReport.tblInsuredCallReportUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportUsersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblInsuredCallReportUsersRowChangeEventHandler rowChangingEvent = this.tblInsuredCallReportUsersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsuredCallReport.tblInsuredCallReportUsersRowChangeEvent((dsInsuredCallReport.tblInsuredCallReportUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportUsersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblInsuredCallReportUsersRowChangeEventHandler usersRowDeletedEvent = this.tblInsuredCallReportUsersRowDeletedEvent;
      if (usersRowDeletedEvent == null)
        return;
      usersRowDeletedEvent((object) this, new dsInsuredCallReport.tblInsuredCallReportUsersRowChangeEvent((dsInsuredCallReport.tblInsuredCallReportUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInsuredCallReportUsersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredCallReport.tblInsuredCallReportUsersRowChangeEventHandler rowDeletingEvent = this.tblInsuredCallReportUsersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsuredCallReport.tblInsuredCallReportUsersRowChangeEvent((dsInsuredCallReport.tblInsuredCallReportUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblInsuredCallReportUsersRow(
      dsInsuredCallReport.tblInsuredCallReportUsersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsuredCallReport insuredCallReport = new dsInsuredCallReport();
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
        FixedValue = insuredCallReport.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblInsuredCallReportUsersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = insuredCallReport.GetSchemaSerializable();
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

  public class lstInsuredCallReportTypeRow : DataRow
  {
    private dsInsuredCallReport.lstInsuredCallReportTypeDataTable tablelstInsuredCallReportType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal lstInsuredCallReportTypeRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstInsuredCallReportType = (dsInsuredCallReport.lstInsuredCallReportTypeDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstInsuredCallReportType.IDColumn]);
      set => this[this.tablelstInsuredCallReportType.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Type
    {
      get => Conversions.ToString(this[this.tablelstInsuredCallReportType.TypeColumn]);
      set => this[this.tablelstInsuredCallReportType.TypeColumn] = (object) value;
    }
  }

  public class tblUsersRow : DataRow
  {
    private dsInsuredCallReport.tblUsersDataTable tabletblUsers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblUsersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUsers = (dsInsuredCallReport.tblUsersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int UserID
    {
      get => Conversions.ToInteger(this[this.tabletblUsers.UserIDColumn]);
      set => this[this.tabletblUsers.UserIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Name_LastFirst
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUsers.Name_LastFirstColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name_LastFirst' in table 'tblUsers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUsers.Name_LastFirstColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int StatusID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUsers.StatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusID' in table 'tblUsers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUsers.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsName_LastFirstNull() => this.IsNull(this.tabletblUsers.Name_LastFirstColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetName_LastFirstNull()
    {
      this[this.tabletblUsers.Name_LastFirstColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsStatusIDNull() => this.IsNull(this.tabletblUsers.StatusIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetStatusIDNull()
    {
      this[this.tabletblUsers.StatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblInsuredCallReportRow : DataRow
  {
    private dsInsuredCallReport.tblInsuredCallReportDataTable tabletblInsuredCallReport;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblInsuredCallReportRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblInsuredCallReport = (dsInsuredCallReport.tblInsuredCallReportDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int CallReportID
    {
      get => Conversions.ToInteger(this[this.tabletblInsuredCallReport.CallReportIDColumn]);
      set => this[this.tabletblInsuredCallReport.CallReportIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime DateOfVisit
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblInsuredCallReport.DateOfVisitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateOfVisit' in table 'tblInsuredCallReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReport.DateOfVisitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public short CallType
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblInsuredCallReport.CallTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CallType' in table 'tblInsuredCallReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReport.CallTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int LeadContactID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsuredCallReport.LeadContactIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LeadContactID' in table 'tblInsuredCallReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReport.LeadContactIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string MeetingNotes
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredCallReport.MeetingNotesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MeetingNotes' in table 'tblInsuredCallReport' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReport.MeetingNotesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid InsuredLocationGuid
    {
      get
      {
        object obj = this[this.tabletblInsuredCallReport.InsuredLocationGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblInsuredCallReport.InsuredLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDateOfVisitNull()
    {
      return this.IsNull(this.tabletblInsuredCallReport.DateOfVisitColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDateOfVisitNull()
    {
      this[this.tabletblInsuredCallReport.DateOfVisitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCallTypeNull() => this.IsNull(this.tabletblInsuredCallReport.CallTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCallTypeNull()
    {
      this[this.tabletblInsuredCallReport.CallTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsLeadContactIDNull()
    {
      return this.IsNull(this.tabletblInsuredCallReport.LeadContactIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetLeadContactIDNull()
    {
      this[this.tabletblInsuredCallReport.LeadContactIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsMeetingNotesNull()
    {
      return this.IsNull(this.tabletblInsuredCallReport.MeetingNotesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetMeetingNotesNull()
    {
      this[this.tabletblInsuredCallReport.MeetingNotesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblInsuredCallReportContactsRow : DataRow
  {
    private dsInsuredCallReport.tblInsuredCallReportContactsDataTable tabletblInsuredCallReportContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblInsuredCallReportContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblInsuredCallReportContacts = (dsInsuredCallReport.tblInsuredCallReportContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int CallReportID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsuredCallReportContacts.CallReportIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CallReportID' in table 'tblInsuredCallReportContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReportContacts.CallReportIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid InsuredContactGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblInsuredCallReportContacts.InsuredContactGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredContactGUID' in table 'tblInsuredCallReportContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReportContacts.InsuredContactGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string ContactName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredCallReportContacts.ContactNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ContactName' in table 'tblInsuredCallReportContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReportContacts.ContactNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblInsuredCallReportContacts.IDColumn]);
      set => this[this.tabletblInsuredCallReportContacts.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int StatusID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsuredCallReportContacts.StatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusID' in table 'tblInsuredCallReportContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReportContacts.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCallReportIDNull()
    {
      return this.IsNull(this.tabletblInsuredCallReportContacts.CallReportIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCallReportIDNull()
    {
      this[this.tabletblInsuredCallReportContacts.CallReportIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsInsuredContactGUIDNull()
    {
      return this.IsNull(this.tabletblInsuredCallReportContacts.InsuredContactGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetInsuredContactGUIDNull()
    {
      this[this.tabletblInsuredCallReportContacts.InsuredContactGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsContactNameNull()
    {
      return this.IsNull(this.tabletblInsuredCallReportContacts.ContactNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetContactNameNull()
    {
      this[this.tabletblInsuredCallReportContacts.ContactNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsStatusIDNull()
    {
      return this.IsNull(this.tabletblInsuredCallReportContacts.StatusIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetStatusIDNull()
    {
      this[this.tabletblInsuredCallReportContacts.StatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblInsuredCallReportUsersRow : DataRow
  {
    private dsInsuredCallReport.tblInsuredCallReportUsersDataTable tabletblInsuredCallReportUsers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblInsuredCallReportUsersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblInsuredCallReportUsers = (dsInsuredCallReport.tblInsuredCallReportUsersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int CallReportID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsuredCallReportUsers.CallReportIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CallReportID' in table 'tblInsuredCallReportUsers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReportUsers.CallReportIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int UserID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsuredCallReportUsers.UserIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserID' in table 'tblInsuredCallReportUsers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReportUsers.UserIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Name_LastFirst
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInsuredCallReportUsers.Name_LastFirstColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name_LastFirst' in table 'tblInsuredCallReportUsers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReportUsers.Name_LastFirstColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblInsuredCallReportUsers.IDColumn]);
      set => this[this.tabletblInsuredCallReportUsers.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int StatusID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInsuredCallReportUsers.StatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusID' in table 'tblInsuredCallReportUsers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInsuredCallReportUsers.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCallReportIDNull()
    {
      return this.IsNull(this.tabletblInsuredCallReportUsers.CallReportIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCallReportIDNull()
    {
      this[this.tabletblInsuredCallReportUsers.CallReportIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsUserIDNull() => this.IsNull(this.tabletblInsuredCallReportUsers.UserIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetUserIDNull()
    {
      this[this.tabletblInsuredCallReportUsers.UserIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsName_LastFirstNull()
    {
      return this.IsNull(this.tabletblInsuredCallReportUsers.Name_LastFirstColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetName_LastFirstNull()
    {
      this[this.tabletblInsuredCallReportUsers.Name_LastFirstColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsStatusIDNull() => this.IsNull(this.tabletblInsuredCallReportUsers.StatusIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetStatusIDNull()
    {
      this[this.tabletblInsuredCallReportUsers.StatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class lstInsuredCallReportTypeRowChangeEvent : EventArgs
  {
    private dsInsuredCallReport.lstInsuredCallReportTypeRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public lstInsuredCallReportTypeRowChangeEvent(
      dsInsuredCallReport.lstInsuredCallReportTypeRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.lstInsuredCallReportTypeRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblUsersRowChangeEvent : EventArgs
  {
    private dsInsuredCallReport.tblUsersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblUsersRowChangeEvent(dsInsuredCallReport.tblUsersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblUsersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblInsuredCallReportRowChangeEvent : EventArgs
  {
    private dsInsuredCallReport.tblInsuredCallReportRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblInsuredCallReportRowChangeEvent(
      dsInsuredCallReport.tblInsuredCallReportRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblInsuredCallReportRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblInsuredCallReportContactsRowChangeEvent : EventArgs
  {
    private dsInsuredCallReport.tblInsuredCallReportContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblInsuredCallReportContactsRowChangeEvent(
      dsInsuredCallReport.tblInsuredCallReportContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblInsuredCallReportContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblInsuredCallReportUsersRowChangeEvent : EventArgs
  {
    private dsInsuredCallReport.tblInsuredCallReportUsersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblInsuredCallReportUsersRowChangeEvent(
      dsInsuredCallReport.tblInsuredCallReportUsersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInsuredCallReport.tblInsuredCallReportUsersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
