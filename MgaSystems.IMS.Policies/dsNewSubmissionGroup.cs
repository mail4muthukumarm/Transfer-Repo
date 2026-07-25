// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsNewSubmissionGroup
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
[XmlRoot("dsNewSubmissionGroup")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsNewSubmissionGroup : DataSet
{
  private dsNewSubmissionGroup.UnderwritersDataTable tableUnderwriters;
  private dsNewSubmissionGroup.tblUsersDataTable tabletblUsers;
  private dsNewSubmissionGroup.tblSubmissionGroupDataTable tabletblSubmissionGroup;
  private dsNewSubmissionGroup.tblProducerLocationsDataTable tabletblProducerLocations;
  private dsNewSubmissionGroup.InhouseProducersDataTable tableInhouseProducers;
  private dsNewSubmissionGroup.TACSRDataTable tableTACSR;
  private dsNewSubmissionGroup.tblProducerInhouseDataTable tabletblProducerInhouse;
  private dsNewSubmissionGroup.dtContactsDataTable tabledtContacts;
  private dsNewSubmissionGroup.lstStatusDataTable tablelstStatus;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsNewSubmissionGroup()
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
  protected dsNewSubmissionGroup(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (Underwriters)] != null)
          base.Tables.Add((DataTable) new dsNewSubmissionGroup.UnderwritersDataTable(dataSet.Tables[nameof (Underwriters)]));
        if (dataSet.Tables[nameof (tblUsers)] != null)
          base.Tables.Add((DataTable) new dsNewSubmissionGroup.tblUsersDataTable(dataSet.Tables[nameof (tblUsers)]));
        if (dataSet.Tables[nameof (tblSubmissionGroup)] != null)
          base.Tables.Add((DataTable) new dsNewSubmissionGroup.tblSubmissionGroupDataTable(dataSet.Tables[nameof (tblSubmissionGroup)]));
        if (dataSet.Tables[nameof (tblProducerLocations)] != null)
          base.Tables.Add((DataTable) new dsNewSubmissionGroup.tblProducerLocationsDataTable(dataSet.Tables[nameof (tblProducerLocations)]));
        if (dataSet.Tables[nameof (InhouseProducers)] != null)
          base.Tables.Add((DataTable) new dsNewSubmissionGroup.InhouseProducersDataTable(dataSet.Tables[nameof (InhouseProducers)]));
        if (dataSet.Tables[nameof (TACSR)] != null)
          base.Tables.Add((DataTable) new dsNewSubmissionGroup.TACSRDataTable(dataSet.Tables[nameof (TACSR)]));
        if (dataSet.Tables[nameof (tblProducerInhouse)] != null)
          base.Tables.Add((DataTable) new dsNewSubmissionGroup.tblProducerInhouseDataTable(dataSet.Tables[nameof (tblProducerInhouse)]));
        if (dataSet.Tables[nameof (dtContacts)] != null)
          base.Tables.Add((DataTable) new dsNewSubmissionGroup.dtContactsDataTable(dataSet.Tables[nameof (dtContacts)]));
        if (dataSet.Tables[nameof (lstStatus)] != null)
          base.Tables.Add((DataTable) new dsNewSubmissionGroup.lstStatusDataTable(dataSet.Tables[nameof (lstStatus)]));
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
  public dsNewSubmissionGroup.UnderwritersDataTable Underwriters => this.tableUnderwriters;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsNewSubmissionGroup.tblUsersDataTable tblUsers => this.tabletblUsers;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsNewSubmissionGroup.tblSubmissionGroupDataTable tblSubmissionGroup
  {
    get => this.tabletblSubmissionGroup;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsNewSubmissionGroup.tblProducerLocationsDataTable tblProducerLocations
  {
    get => this.tabletblProducerLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsNewSubmissionGroup.InhouseProducersDataTable InhouseProducers
  {
    get => this.tableInhouseProducers;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsNewSubmissionGroup.TACSRDataTable TACSR => this.tableTACSR;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsNewSubmissionGroup.tblProducerInhouseDataTable tblProducerInhouse
  {
    get => this.tabletblProducerInhouse;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsNewSubmissionGroup.dtContactsDataTable dtContacts => this.tabledtContacts;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsNewSubmissionGroup.lstStatusDataTable lstStatus => this.tablelstStatus;

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
    dsNewSubmissionGroup newSubmissionGroup = (dsNewSubmissionGroup) base.Clone();
    newSubmissionGroup.InitVars();
    newSubmissionGroup.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) newSubmissionGroup;
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
      if (dataSet.Tables["Underwriters"] != null)
        base.Tables.Add((DataTable) new dsNewSubmissionGroup.UnderwritersDataTable(dataSet.Tables["Underwriters"]));
      if (dataSet.Tables["tblUsers"] != null)
        base.Tables.Add((DataTable) new dsNewSubmissionGroup.tblUsersDataTable(dataSet.Tables["tblUsers"]));
      if (dataSet.Tables["tblSubmissionGroup"] != null)
        base.Tables.Add((DataTable) new dsNewSubmissionGroup.tblSubmissionGroupDataTable(dataSet.Tables["tblSubmissionGroup"]));
      if (dataSet.Tables["tblProducerLocations"] != null)
        base.Tables.Add((DataTable) new dsNewSubmissionGroup.tblProducerLocationsDataTable(dataSet.Tables["tblProducerLocations"]));
      if (dataSet.Tables["InhouseProducers"] != null)
        base.Tables.Add((DataTable) new dsNewSubmissionGroup.InhouseProducersDataTable(dataSet.Tables["InhouseProducers"]));
      if (dataSet.Tables["TACSR"] != null)
        base.Tables.Add((DataTable) new dsNewSubmissionGroup.TACSRDataTable(dataSet.Tables["TACSR"]));
      if (dataSet.Tables["tblProducerInhouse"] != null)
        base.Tables.Add((DataTable) new dsNewSubmissionGroup.tblProducerInhouseDataTable(dataSet.Tables["tblProducerInhouse"]));
      if (dataSet.Tables["dtContacts"] != null)
        base.Tables.Add((DataTable) new dsNewSubmissionGroup.dtContactsDataTable(dataSet.Tables["dtContacts"]));
      if (dataSet.Tables["lstStatus"] != null)
        base.Tables.Add((DataTable) new dsNewSubmissionGroup.lstStatusDataTable(dataSet.Tables["lstStatus"]));
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
    this.tableUnderwriters = (dsNewSubmissionGroup.UnderwritersDataTable) base.Tables["Underwriters"];
    if (initTable && this.tableUnderwriters != null)
      this.tableUnderwriters.InitVars();
    this.tabletblUsers = (dsNewSubmissionGroup.tblUsersDataTable) base.Tables["tblUsers"];
    if (initTable && this.tabletblUsers != null)
      this.tabletblUsers.InitVars();
    this.tabletblSubmissionGroup = (dsNewSubmissionGroup.tblSubmissionGroupDataTable) base.Tables["tblSubmissionGroup"];
    if (initTable && this.tabletblSubmissionGroup != null)
      this.tabletblSubmissionGroup.InitVars();
    this.tabletblProducerLocations = (dsNewSubmissionGroup.tblProducerLocationsDataTable) base.Tables["tblProducerLocations"];
    if (initTable && this.tabletblProducerLocations != null)
      this.tabletblProducerLocations.InitVars();
    this.tableInhouseProducers = (dsNewSubmissionGroup.InhouseProducersDataTable) base.Tables["InhouseProducers"];
    if (initTable && this.tableInhouseProducers != null)
      this.tableInhouseProducers.InitVars();
    this.tableTACSR = (dsNewSubmissionGroup.TACSRDataTable) base.Tables["TACSR"];
    if (initTable && this.tableTACSR != null)
      this.tableTACSR.InitVars();
    this.tabletblProducerInhouse = (dsNewSubmissionGroup.tblProducerInhouseDataTable) base.Tables["tblProducerInhouse"];
    if (initTable && this.tabletblProducerInhouse != null)
      this.tabletblProducerInhouse.InitVars();
    this.tabledtContacts = (dsNewSubmissionGroup.dtContactsDataTable) base.Tables["dtContacts"];
    if (initTable && this.tabledtContacts != null)
      this.tabledtContacts.InitVars();
    this.tablelstStatus = (dsNewSubmissionGroup.lstStatusDataTable) base.Tables["lstStatus"];
    if (!initTable || this.tablelstStatus == null)
      return;
    this.tablelstStatus.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsNewSubmissionGroup);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsNewSubmissionGroup.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableUnderwriters = new dsNewSubmissionGroup.UnderwritersDataTable();
    base.Tables.Add((DataTable) this.tableUnderwriters);
    this.tabletblUsers = new dsNewSubmissionGroup.tblUsersDataTable();
    base.Tables.Add((DataTable) this.tabletblUsers);
    this.tabletblSubmissionGroup = new dsNewSubmissionGroup.tblSubmissionGroupDataTable();
    base.Tables.Add((DataTable) this.tabletblSubmissionGroup);
    this.tabletblProducerLocations = new dsNewSubmissionGroup.tblProducerLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerLocations);
    this.tableInhouseProducers = new dsNewSubmissionGroup.InhouseProducersDataTable();
    base.Tables.Add((DataTable) this.tableInhouseProducers);
    this.tableTACSR = new dsNewSubmissionGroup.TACSRDataTable();
    base.Tables.Add((DataTable) this.tableTACSR);
    this.tabletblProducerInhouse = new dsNewSubmissionGroup.tblProducerInhouseDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerInhouse);
    this.tabledtContacts = new dsNewSubmissionGroup.dtContactsDataTable();
    base.Tables.Add((DataTable) this.tabledtContacts);
    this.tablelstStatus = new dsNewSubmissionGroup.lstStatusDataTable();
    base.Tables.Add((DataTable) this.tablelstStatus);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeUnderwriters() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblUsers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblSubmissionGroup() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblProducerLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeInhouseProducers() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeTACSR() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblProducerInhouse() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializedtContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstStatus() => false;

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
    dsNewSubmissionGroup newSubmissionGroup = new dsNewSubmissionGroup();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = newSubmissionGroup.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = newSubmissionGroup.GetSchemaSerializable();
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
  public delegate void UnderwritersRowChangeEventHandler(
    object sender,
    dsNewSubmissionGroup.UnderwritersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblUsersRowChangeEventHandler(
    object sender,
    dsNewSubmissionGroup.tblUsersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblSubmissionGroupRowChangeEventHandler(
    object sender,
    dsNewSubmissionGroup.tblSubmissionGroupRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblProducerLocationsRowChangeEventHandler(
    object sender,
    dsNewSubmissionGroup.tblProducerLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void InhouseProducersRowChangeEventHandler(
    object sender,
    dsNewSubmissionGroup.InhouseProducersRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void TACSRRowChangeEventHandler(
    object sender,
    dsNewSubmissionGroup.TACSRRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblProducerInhouseRowChangeEventHandler(
    object sender,
    dsNewSubmissionGroup.tblProducerInhouseRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void dtContactsRowChangeEventHandler(
    object sender,
    dsNewSubmissionGroup.dtContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstStatusRowChangeEventHandler(
    object sender,
    dsNewSubmissionGroup.lstStatusRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class UnderwritersDataTable : TypedTableBase<dsNewSubmissionGroup.UnderwritersRow>
  {
    private DataColumn columnUserGUID;
    private DataColumn columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public UnderwritersDataTable()
    {
      this.TableName = "Underwriters";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal UnderwritersDataTable(DataTable table)
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
    protected UnderwritersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UserGUIDColumn => this.columnUserGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.UnderwritersRow this[int index]
    {
      get => (dsNewSubmissionGroup.UnderwritersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.UnderwritersRowChangeEventHandler UnderwritersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.UnderwritersRowChangeEventHandler UnderwritersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.UnderwritersRowChangeEventHandler UnderwritersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.UnderwritersRowChangeEventHandler UnderwritersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddUnderwritersRow(dsNewSubmissionGroup.UnderwritersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.UnderwritersRow AddUnderwritersRow(Guid UserGUID, string Name)
    {
      dsNewSubmissionGroup.UnderwritersRow row = (dsNewSubmissionGroup.UnderwritersRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) UserGUID,
        (object) Name
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.UnderwritersRow FindByUserGUID(Guid UserGUID)
    {
      return (dsNewSubmissionGroup.UnderwritersRow) this.Rows.Find(new object[1]
      {
        (object) UserGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNewSubmissionGroup.UnderwritersDataTable underwritersDataTable = (dsNewSubmissionGroup.UnderwritersDataTable) base.Clone();
      underwritersDataTable.InitVars();
      return (DataTable) underwritersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNewSubmissionGroup.UnderwritersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnUserGUID = this.Columns["UserGUID"];
      this.columnName = this.Columns["Name"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnUserGUID = new DataColumn("UserGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsNewSubmissionGroupKey2", new DataColumn[1]
      {
        this.columnUserGUID
      }, true));
      this.columnUserGUID.AllowDBNull = false;
      this.columnUserGUID.Unique = true;
      this.columnName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.UnderwritersRow NewUnderwritersRow()
    {
      return (dsNewSubmissionGroup.UnderwritersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNewSubmissionGroup.UnderwritersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsNewSubmissionGroup.UnderwritersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UnderwritersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.UnderwritersRowChangeEventHandler underwritersRowChangedEvent = this.UnderwritersRowChangedEvent;
      if (underwritersRowChangedEvent == null)
        return;
      underwritersRowChangedEvent((object) this, new dsNewSubmissionGroup.UnderwritersRowChangeEvent((dsNewSubmissionGroup.UnderwritersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UnderwritersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.UnderwritersRowChangeEventHandler rowChangingEvent = this.UnderwritersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsNewSubmissionGroup.UnderwritersRowChangeEvent((dsNewSubmissionGroup.UnderwritersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UnderwritersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.UnderwritersRowChangeEventHandler underwritersRowDeletedEvent = this.UnderwritersRowDeletedEvent;
      if (underwritersRowDeletedEvent == null)
        return;
      underwritersRowDeletedEvent((object) this, new dsNewSubmissionGroup.UnderwritersRowChangeEvent((dsNewSubmissionGroup.UnderwritersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UnderwritersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.UnderwritersRowChangeEventHandler rowDeletingEvent = this.UnderwritersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsNewSubmissionGroup.UnderwritersRowChangeEvent((dsNewSubmissionGroup.UnderwritersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveUnderwritersRow(dsNewSubmissionGroup.UnderwritersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNewSubmissionGroup newSubmissionGroup = new dsNewSubmissionGroup();
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
        FixedValue = newSubmissionGroup.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (UnderwritersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newSubmissionGroup.GetSchemaSerializable();
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
  public class tblUsersDataTable : TypedTableBase<dsNewSubmissionGroup.tblUsersRow>
  {
    private DataColumn columnUserGUID;
    private DataColumn columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblUsersDataTable()
    {
      this.TableName = "tblUsers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected tblUsersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UserGUIDColumn => this.columnUserGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblUsersRow this[int index]
    {
      get => (dsNewSubmissionGroup.tblUsersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblUsersRowChangeEventHandler tblUsersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblUsersRowChangeEventHandler tblUsersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblUsersRowChangeEventHandler tblUsersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblUsersRowChangeEventHandler tblUsersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblUsersRow(dsNewSubmissionGroup.tblUsersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblUsersRow AddtblUsersRow(Guid UserGUID, string Name)
    {
      dsNewSubmissionGroup.tblUsersRow row = (dsNewSubmissionGroup.tblUsersRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) UserGUID,
        (object) Name
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblUsersRow FindByUserGUID(Guid UserGUID)
    {
      return (dsNewSubmissionGroup.tblUsersRow) this.Rows.Find(new object[1]
      {
        (object) UserGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNewSubmissionGroup.tblUsersDataTable tblUsersDataTable = (dsNewSubmissionGroup.tblUsersDataTable) base.Clone();
      tblUsersDataTable.InitVars();
      return (DataTable) tblUsersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNewSubmissionGroup.tblUsersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnUserGUID = this.Columns["UserGUID"];
      this.columnName = this.Columns["Name"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnUserGUID = new DataColumn("UserGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsNewSubmissionGroupKey3", new DataColumn[1]
      {
        this.columnUserGUID
      }, true));
      this.columnUserGUID.AllowDBNull = false;
      this.columnUserGUID.Unique = true;
      this.columnName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblUsersRow NewtblUsersRow()
    {
      return (dsNewSubmissionGroup.tblUsersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNewSubmissionGroup.tblUsersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsNewSubmissionGroup.tblUsersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblUsersRowChangeEventHandler usersRowChangedEvent = this.tblUsersRowChangedEvent;
      if (usersRowChangedEvent == null)
        return;
      usersRowChangedEvent((object) this, new dsNewSubmissionGroup.tblUsersRowChangeEvent((dsNewSubmissionGroup.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblUsersRowChangeEventHandler rowChangingEvent = this.tblUsersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsNewSubmissionGroup.tblUsersRowChangeEvent((dsNewSubmissionGroup.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblUsersRowChangeEventHandler usersRowDeletedEvent = this.tblUsersRowDeletedEvent;
      if (usersRowDeletedEvent == null)
        return;
      usersRowDeletedEvent((object) this, new dsNewSubmissionGroup.tblUsersRowChangeEvent((dsNewSubmissionGroup.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblUsersRowChangeEventHandler rowDeletingEvent = this.tblUsersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsNewSubmissionGroup.tblUsersRowChangeEvent((dsNewSubmissionGroup.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblUsersRow(dsNewSubmissionGroup.tblUsersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNewSubmissionGroup newSubmissionGroup = new dsNewSubmissionGroup();
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
        FixedValue = newSubmissionGroup.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUsersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newSubmissionGroup.GetSchemaSerializable();
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
  public class tblSubmissionGroupDataTable : 
    TypedTableBase<dsNewSubmissionGroup.tblSubmissionGroupRow>
  {
    private DataColumn columnSubmissionGroupGUID;
    private DataColumn columnInsuredGUID;
    private DataColumn columnProducerLocationGUID;
    private DataColumn columnUnderwriterUserGUID;
    private DataColumn columnTACSRUserGuid;
    private DataColumn columnDateSubmitted;
    private DataColumn columnInHouseProducerUserGuid;
    private DataColumn columnAddedByUserGuid;
    private DataColumn columnProducerContactID;
    private DataColumn columnSecProducerContactID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblSubmissionGroupDataTable()
    {
      this.TableName = "tblSubmissionGroup";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblSubmissionGroupDataTable(DataTable table)
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
    protected tblSubmissionGroupDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SubmissionGroupGUIDColumn => this.columnSubmissionGroupGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredGUIDColumn => this.columnInsuredGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerLocationGUIDColumn => this.columnProducerLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UnderwriterUserGUIDColumn => this.columnUnderwriterUserGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TACSRUserGuidColumn => this.columnTACSRUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateSubmittedColumn => this.columnDateSubmitted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InHouseProducerUserGuidColumn => this.columnInHouseProducerUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AddedByUserGuidColumn => this.columnAddedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerContactIDColumn => this.columnProducerContactID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SecProducerContactIDColumn => this.columnSecProducerContactID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblSubmissionGroupRow this[int index]
    {
      get => (dsNewSubmissionGroup.tblSubmissionGroupRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblSubmissionGroupRowChangeEventHandler tblSubmissionGroupRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblSubmissionGroupRowChangeEventHandler tblSubmissionGroupRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblSubmissionGroupRowChangeEventHandler tblSubmissionGroupRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblSubmissionGroupRowChangeEventHandler tblSubmissionGroupRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblSubmissionGroupRow(dsNewSubmissionGroup.tblSubmissionGroupRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblSubmissionGroupRow AddtblSubmissionGroupRow(
      Guid SubmissionGroupGUID,
      Guid InsuredGUID,
      Guid ProducerLocationGUID,
      Guid UnderwriterUserGUID,
      Guid TACSRUserGuid,
      DateTime DateSubmitted,
      Guid InHouseProducerUserGuid,
      Guid AddedByUserGuid,
      int ProducerContactID,
      int SecProducerContactID)
    {
      dsNewSubmissionGroup.tblSubmissionGroupRow row = (dsNewSubmissionGroup.tblSubmissionGroupRow) this.NewRow();
      object[] objArray = new object[10]
      {
        (object) SubmissionGroupGUID,
        (object) InsuredGUID,
        (object) ProducerLocationGUID,
        (object) UnderwriterUserGUID,
        (object) TACSRUserGuid,
        (object) DateSubmitted,
        (object) InHouseProducerUserGuid,
        (object) AddedByUserGuid,
        (object) ProducerContactID,
        (object) SecProducerContactID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblSubmissionGroupRow FindBySubmissionGroupGUID(
      Guid SubmissionGroupGUID)
    {
      return (dsNewSubmissionGroup.tblSubmissionGroupRow) this.Rows.Find(new object[1]
      {
        (object) SubmissionGroupGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNewSubmissionGroup.tblSubmissionGroupDataTable submissionGroupDataTable = (dsNewSubmissionGroup.tblSubmissionGroupDataTable) base.Clone();
      submissionGroupDataTable.InitVars();
      return (DataTable) submissionGroupDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNewSubmissionGroup.tblSubmissionGroupDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnSubmissionGroupGUID = this.Columns["SubmissionGroupGUID"];
      this.columnInsuredGUID = this.Columns["InsuredGUID"];
      this.columnProducerLocationGUID = this.Columns["ProducerLocationGUID"];
      this.columnUnderwriterUserGUID = this.Columns["UnderwriterUserGUID"];
      this.columnTACSRUserGuid = this.Columns["TACSRUserGuid"];
      this.columnDateSubmitted = this.Columns["DateSubmitted"];
      this.columnInHouseProducerUserGuid = this.Columns["InHouseProducerUserGuid"];
      this.columnAddedByUserGuid = this.Columns["AddedByUserGuid"];
      this.columnProducerContactID = this.Columns["ProducerContactID"];
      this.columnSecProducerContactID = this.Columns["SecProducerContactID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnSubmissionGroupGUID = new DataColumn("SubmissionGroupGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubmissionGroupGUID);
      this.columnInsuredGUID = new DataColumn("InsuredGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredGUID);
      this.columnProducerLocationGUID = new DataColumn("ProducerLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGUID);
      this.columnUnderwriterUserGUID = new DataColumn("UnderwriterUserGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriterUserGUID);
      this.columnTACSRUserGuid = new DataColumn("TACSRUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTACSRUserGuid);
      this.columnDateSubmitted = new DataColumn("DateSubmitted", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateSubmitted);
      this.columnInHouseProducerUserGuid = new DataColumn("InHouseProducerUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInHouseProducerUserGuid);
      this.columnAddedByUserGuid = new DataColumn("AddedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddedByUserGuid);
      this.columnProducerContactID = new DataColumn("ProducerContactID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContactID);
      this.columnSecProducerContactID = new DataColumn("SecProducerContactID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSecProducerContactID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsNewSubmissionGroupKey4", new DataColumn[1]
      {
        this.columnSubmissionGroupGUID
      }, true));
      this.columnSubmissionGroupGUID.AllowDBNull = false;
      this.columnSubmissionGroupGUID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblSubmissionGroupRow NewtblSubmissionGroupRow()
    {
      return (dsNewSubmissionGroup.tblSubmissionGroupRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNewSubmissionGroup.tblSubmissionGroupRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsNewSubmissionGroup.tblSubmissionGroupRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblSubmissionGroupRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblSubmissionGroupRowChangeEventHandler groupRowChangedEvent = this.tblSubmissionGroupRowChangedEvent;
      if (groupRowChangedEvent == null)
        return;
      groupRowChangedEvent((object) this, new dsNewSubmissionGroup.tblSubmissionGroupRowChangeEvent((dsNewSubmissionGroup.tblSubmissionGroupRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblSubmissionGroupRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblSubmissionGroupRowChangeEventHandler rowChangingEvent = this.tblSubmissionGroupRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsNewSubmissionGroup.tblSubmissionGroupRowChangeEvent((dsNewSubmissionGroup.tblSubmissionGroupRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblSubmissionGroupRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblSubmissionGroupRowChangeEventHandler groupRowDeletedEvent = this.tblSubmissionGroupRowDeletedEvent;
      if (groupRowDeletedEvent == null)
        return;
      groupRowDeletedEvent((object) this, new dsNewSubmissionGroup.tblSubmissionGroupRowChangeEvent((dsNewSubmissionGroup.tblSubmissionGroupRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblSubmissionGroupRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblSubmissionGroupRowChangeEventHandler rowDeletingEvent = this.tblSubmissionGroupRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsNewSubmissionGroup.tblSubmissionGroupRowChangeEvent((dsNewSubmissionGroup.tblSubmissionGroupRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblSubmissionGroupRow(dsNewSubmissionGroup.tblSubmissionGroupRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNewSubmissionGroup newSubmissionGroup = new dsNewSubmissionGroup();
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
        FixedValue = newSubmissionGroup.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblSubmissionGroupDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newSubmissionGroup.GetSchemaSerializable();
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
  public class tblProducerLocationsDataTable : 
    TypedTableBase<dsNewSubmissionGroup.tblProducerLocationsRow>
  {
    private DataColumn columnProducerLocationGUID;
    private DataColumn columnName;
    private DataColumn columnStatusID;
    private DataColumn columnProducerContact;
    private DataColumn columnProducerContactID;
    private DataColumn columnContactAndProducer;
    private DataColumn columnContactStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerLocationsDataTable()
    {
      this.TableName = "tblProducerLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducerLocationsDataTable(DataTable table)
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
    protected tblProducerLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerLocationGUIDColumn => this.columnProducerLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerContactColumn => this.columnProducerContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerContactIDColumn => this.columnProducerContactID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ContactAndProducerColumn => this.columnContactAndProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ContactStatusIDColumn => this.columnContactStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblProducerLocationsRow this[int index]
    {
      get => (dsNewSubmissionGroup.tblProducerLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblProducerLocationsRow(dsNewSubmissionGroup.tblProducerLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblProducerLocationsRow AddtblProducerLocationsRow(
      Guid ProducerLocationGUID,
      string Name,
      int StatusID,
      string ProducerContact,
      int ProducerContactID,
      string ContactAndProducer,
      int ContactStatusID)
    {
      dsNewSubmissionGroup.tblProducerLocationsRow row = (dsNewSubmissionGroup.tblProducerLocationsRow) this.NewRow();
      object[] objArray = new object[7]
      {
        (object) ProducerLocationGUID,
        (object) Name,
        (object) StatusID,
        (object) ProducerContact,
        (object) ProducerContactID,
        (object) ContactAndProducer,
        (object) ContactStatusID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblProducerLocationsRow FindByProducerContactID(
      int ProducerContactID)
    {
      return (dsNewSubmissionGroup.tblProducerLocationsRow) this.Rows.Find(new object[1]
      {
        (object) ProducerContactID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNewSubmissionGroup.tblProducerLocationsDataTable locationsDataTable = (dsNewSubmissionGroup.tblProducerLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNewSubmissionGroup.tblProducerLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerLocationGUID = this.Columns["ProducerLocationGUID"];
      this.columnName = this.Columns["Name"];
      this.columnStatusID = this.Columns["StatusID"];
      this.columnProducerContact = this.Columns["ProducerContact"];
      this.columnProducerContactID = this.Columns["ProducerContactID"];
      this.columnContactAndProducer = this.Columns["ContactAndProducer"];
      this.columnContactStatusID = this.Columns["ContactStatusID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnProducerLocationGUID = new DataColumn("ProducerLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGUID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnProducerContact = new DataColumn("ProducerContact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContact);
      this.columnProducerContactID = new DataColumn("ProducerContactID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContactID);
      this.columnContactAndProducer = new DataColumn("ContactAndProducer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactAndProducer);
      this.columnContactStatusID = new DataColumn("ContactStatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactStatusID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsNewSubmissionGroupKey1", new DataColumn[1]
      {
        this.columnProducerContactID
      }, true));
      this.columnProducerLocationGUID.AllowDBNull = false;
      this.columnName.AllowDBNull = false;
      this.columnStatusID.AllowDBNull = false;
      this.columnProducerContact.AllowDBNull = false;
      this.columnProducerContactID.AllowDBNull = false;
      this.columnProducerContactID.Unique = true;
      this.columnContactStatusID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblProducerLocationsRow NewtblProducerLocationsRow()
    {
      return (dsNewSubmissionGroup.tblProducerLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNewSubmissionGroup.tblProducerLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsNewSubmissionGroup.tblProducerLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblProducerLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblProducerLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsNewSubmissionGroup.tblProducerLocationsRowChangeEvent((dsNewSubmissionGroup.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblProducerLocationsRowChangeEventHandler rowChangingEvent = this.tblProducerLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsNewSubmissionGroup.tblProducerLocationsRowChangeEvent((dsNewSubmissionGroup.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblProducerLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblProducerLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsNewSubmissionGroup.tblProducerLocationsRowChangeEvent((dsNewSubmissionGroup.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblProducerLocationsRowChangeEventHandler rowDeletingEvent = this.tblProducerLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsNewSubmissionGroup.tblProducerLocationsRowChangeEvent((dsNewSubmissionGroup.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblProducerLocationsRow(dsNewSubmissionGroup.tblProducerLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNewSubmissionGroup newSubmissionGroup = new dsNewSubmissionGroup();
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
        FixedValue = newSubmissionGroup.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newSubmissionGroup.GetSchemaSerializable();
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
  public class InhouseProducersDataTable : TypedTableBase<dsNewSubmissionGroup.InhouseProducersRow>
  {
    private DataColumn columnUserGUID;
    private DataColumn columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public InhouseProducersDataTable()
    {
      this.TableName = "InhouseProducers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal InhouseProducersDataTable(DataTable table)
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
    protected InhouseProducersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UserGUIDColumn => this.columnUserGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.InhouseProducersRow this[int index]
    {
      get => (dsNewSubmissionGroup.InhouseProducersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.InhouseProducersRowChangeEventHandler InhouseProducersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.InhouseProducersRowChangeEventHandler InhouseProducersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.InhouseProducersRowChangeEventHandler InhouseProducersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.InhouseProducersRowChangeEventHandler InhouseProducersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddInhouseProducersRow(dsNewSubmissionGroup.InhouseProducersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.InhouseProducersRow AddInhouseProducersRow(
      Guid UserGUID,
      string Name)
    {
      dsNewSubmissionGroup.InhouseProducersRow row = (dsNewSubmissionGroup.InhouseProducersRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) UserGUID,
        (object) Name
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNewSubmissionGroup.InhouseProducersDataTable producersDataTable = (dsNewSubmissionGroup.InhouseProducersDataTable) base.Clone();
      producersDataTable.InitVars();
      return (DataTable) producersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNewSubmissionGroup.InhouseProducersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnUserGUID = this.Columns["UserGUID"];
      this.columnName = this.Columns["Name"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnUserGUID = new DataColumn("UserGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnUserGUID.AllowDBNull = false;
      this.columnName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.InhouseProducersRow NewInhouseProducersRow()
    {
      return (dsNewSubmissionGroup.InhouseProducersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNewSubmissionGroup.InhouseProducersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsNewSubmissionGroup.InhouseProducersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InhouseProducersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.InhouseProducersRowChangeEventHandler producersRowChangedEvent = this.InhouseProducersRowChangedEvent;
      if (producersRowChangedEvent == null)
        return;
      producersRowChangedEvent((object) this, new dsNewSubmissionGroup.InhouseProducersRowChangeEvent((dsNewSubmissionGroup.InhouseProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InhouseProducersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.InhouseProducersRowChangeEventHandler rowChangingEvent = this.InhouseProducersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsNewSubmissionGroup.InhouseProducersRowChangeEvent((dsNewSubmissionGroup.InhouseProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InhouseProducersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.InhouseProducersRowChangeEventHandler producersRowDeletedEvent = this.InhouseProducersRowDeletedEvent;
      if (producersRowDeletedEvent == null)
        return;
      producersRowDeletedEvent((object) this, new dsNewSubmissionGroup.InhouseProducersRowChangeEvent((dsNewSubmissionGroup.InhouseProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InhouseProducersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.InhouseProducersRowChangeEventHandler rowDeletingEvent = this.InhouseProducersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsNewSubmissionGroup.InhouseProducersRowChangeEvent((dsNewSubmissionGroup.InhouseProducersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveInhouseProducersRow(dsNewSubmissionGroup.InhouseProducersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNewSubmissionGroup newSubmissionGroup = new dsNewSubmissionGroup();
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
        FixedValue = newSubmissionGroup.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InhouseProducersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newSubmissionGroup.GetSchemaSerializable();
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
  public class TACSRDataTable : TypedTableBase<dsNewSubmissionGroup.TACSRRow>
  {
    private DataColumn columnUserGUID;
    private DataColumn columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TACSRDataTable()
    {
      this.TableName = "TACSR";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal TACSRDataTable(DataTable table)
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
    protected TACSRDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UserGUIDColumn => this.columnUserGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.TACSRRow this[int index]
    {
      get => (dsNewSubmissionGroup.TACSRRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.TACSRRowChangeEventHandler TACSRRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.TACSRRowChangeEventHandler TACSRRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.TACSRRowChangeEventHandler TACSRRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.TACSRRowChangeEventHandler TACSRRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddTACSRRow(dsNewSubmissionGroup.TACSRRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.TACSRRow AddTACSRRow(Guid UserGUID, string Name)
    {
      dsNewSubmissionGroup.TACSRRow row = (dsNewSubmissionGroup.TACSRRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) UserGUID,
        (object) Name
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.TACSRRow FindByUserGUID(Guid UserGUID)
    {
      return (dsNewSubmissionGroup.TACSRRow) this.Rows.Find(new object[1]
      {
        (object) UserGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNewSubmissionGroup.TACSRDataTable tacsrDataTable = (dsNewSubmissionGroup.TACSRDataTable) base.Clone();
      tacsrDataTable.InitVars();
      return (DataTable) tacsrDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNewSubmissionGroup.TACSRDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnUserGUID = this.Columns["UserGUID"];
      this.columnName = this.Columns["Name"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnUserGUID = new DataColumn("UserGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnUserGUID
      }, true));
      this.columnUserGUID.AllowDBNull = false;
      this.columnUserGUID.Unique = true;
      this.columnName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.TACSRRow NewTACSRRow()
    {
      return (dsNewSubmissionGroup.TACSRRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNewSubmissionGroup.TACSRRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsNewSubmissionGroup.TACSRRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TACSRRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.TACSRRowChangeEventHandler tacsrRowChangedEvent = this.TACSRRowChangedEvent;
      if (tacsrRowChangedEvent == null)
        return;
      tacsrRowChangedEvent((object) this, new dsNewSubmissionGroup.TACSRRowChangeEvent((dsNewSubmissionGroup.TACSRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TACSRRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.TACSRRowChangeEventHandler rowChangingEvent = this.TACSRRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsNewSubmissionGroup.TACSRRowChangeEvent((dsNewSubmissionGroup.TACSRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TACSRRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.TACSRRowChangeEventHandler tacsrRowDeletedEvent = this.TACSRRowDeletedEvent;
      if (tacsrRowDeletedEvent == null)
        return;
      tacsrRowDeletedEvent((object) this, new dsNewSubmissionGroup.TACSRRowChangeEvent((dsNewSubmissionGroup.TACSRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TACSRRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.TACSRRowChangeEventHandler rowDeletingEvent = this.TACSRRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsNewSubmissionGroup.TACSRRowChangeEvent((dsNewSubmissionGroup.TACSRRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveTACSRRow(dsNewSubmissionGroup.TACSRRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNewSubmissionGroup newSubmissionGroup = new dsNewSubmissionGroup();
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
        FixedValue = newSubmissionGroup.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (TACSRDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newSubmissionGroup.GetSchemaSerializable();
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
  public class tblProducerInhouseDataTable : 
    TypedTableBase<dsNewSubmissionGroup.tblProducerInhouseRow>
  {
    private DataColumn columnProducerLocationGuid;
    private DataColumn columnProducerGuid;
    private DataColumn columnInhouseProducerGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerInhouseDataTable()
    {
      this.TableName = "tblProducerInhouse";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducerInhouseDataTable(DataTable table)
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
    protected tblProducerInhouseDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerLocationGuidColumn => this.columnProducerLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerGuidColumn => this.columnProducerGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InhouseProducerGuidColumn => this.columnInhouseProducerGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblProducerInhouseRow this[int index]
    {
      get => (dsNewSubmissionGroup.tblProducerInhouseRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblProducerInhouseRowChangeEventHandler tblProducerInhouseRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblProducerInhouseRowChangeEventHandler tblProducerInhouseRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblProducerInhouseRowChangeEventHandler tblProducerInhouseRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.tblProducerInhouseRowChangeEventHandler tblProducerInhouseRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblProducerInhouseRow(dsNewSubmissionGroup.tblProducerInhouseRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblProducerInhouseRow AddtblProducerInhouseRow(
      Guid ProducerLocationGuid,
      Guid ProducerGuid,
      Guid InhouseProducerGuid)
    {
      dsNewSubmissionGroup.tblProducerInhouseRow row = (dsNewSubmissionGroup.tblProducerInhouseRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) ProducerLocationGuid,
        (object) ProducerGuid,
        (object) InhouseProducerGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNewSubmissionGroup.tblProducerInhouseDataTable inhouseDataTable = (dsNewSubmissionGroup.tblProducerInhouseDataTable) base.Clone();
      inhouseDataTable.InitVars();
      return (DataTable) inhouseDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNewSubmissionGroup.tblProducerInhouseDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerLocationGuid = this.Columns["ProducerLocationGuid"];
      this.columnProducerGuid = this.Columns["ProducerGuid"];
      this.columnInhouseProducerGuid = this.Columns["InhouseProducerGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnProducerLocationGuid = new DataColumn("ProducerLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGuid);
      this.columnProducerGuid = new DataColumn("ProducerGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerGuid);
      this.columnInhouseProducerGuid = new DataColumn("InhouseProducerGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInhouseProducerGuid);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblProducerInhouseRow NewtblProducerInhouseRow()
    {
      return (dsNewSubmissionGroup.tblProducerInhouseRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNewSubmissionGroup.tblProducerInhouseRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsNewSubmissionGroup.tblProducerInhouseRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerInhouseRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblProducerInhouseRowChangeEventHandler inhouseRowChangedEvent = this.tblProducerInhouseRowChangedEvent;
      if (inhouseRowChangedEvent == null)
        return;
      inhouseRowChangedEvent((object) this, new dsNewSubmissionGroup.tblProducerInhouseRowChangeEvent((dsNewSubmissionGroup.tblProducerInhouseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerInhouseRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblProducerInhouseRowChangeEventHandler rowChangingEvent = this.tblProducerInhouseRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsNewSubmissionGroup.tblProducerInhouseRowChangeEvent((dsNewSubmissionGroup.tblProducerInhouseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerInhouseRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblProducerInhouseRowChangeEventHandler inhouseRowDeletedEvent = this.tblProducerInhouseRowDeletedEvent;
      if (inhouseRowDeletedEvent == null)
        return;
      inhouseRowDeletedEvent((object) this, new dsNewSubmissionGroup.tblProducerInhouseRowChangeEvent((dsNewSubmissionGroup.tblProducerInhouseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerInhouseRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.tblProducerInhouseRowChangeEventHandler rowDeletingEvent = this.tblProducerInhouseRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsNewSubmissionGroup.tblProducerInhouseRowChangeEvent((dsNewSubmissionGroup.tblProducerInhouseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblProducerInhouseRow(dsNewSubmissionGroup.tblProducerInhouseRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNewSubmissionGroup newSubmissionGroup = new dsNewSubmissionGroup();
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
        FixedValue = newSubmissionGroup.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerInhouseDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newSubmissionGroup.GetSchemaSerializable();
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
  public class dtContactsDataTable : TypedTableBase<dsNewSubmissionGroup.dtContactsRow>
  {
    private DataColumn columnProducerContact;
    private DataColumn columnProducerContactID;
    private DataColumn columnContactStatusID;
    private DataColumn columnSelected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dtContactsDataTable()
    {
      this.TableName = "dtContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal dtContactsDataTable(DataTable table)
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
    protected dtContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerContactColumn => this.columnProducerContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerContactIDColumn => this.columnProducerContactID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ContactStatusIDColumn => this.columnContactStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SelectedColumn => this.columnSelected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.dtContactsRow this[int index]
    {
      get => (dsNewSubmissionGroup.dtContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.dtContactsRowChangeEventHandler dtContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.dtContactsRowChangeEventHandler dtContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.dtContactsRowChangeEventHandler dtContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.dtContactsRowChangeEventHandler dtContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AdddtContactsRow(dsNewSubmissionGroup.dtContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.dtContactsRow AdddtContactsRow(
      string ProducerContact,
      int ProducerContactID,
      int ContactStatusID,
      bool Selected)
    {
      dsNewSubmissionGroup.dtContactsRow row = (dsNewSubmissionGroup.dtContactsRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) ProducerContact,
        (object) ProducerContactID,
        (object) ContactStatusID,
        (object) Selected
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.dtContactsRow FindByProducerContactID(int ProducerContactID)
    {
      return (dsNewSubmissionGroup.dtContactsRow) this.Rows.Find(new object[1]
      {
        (object) ProducerContactID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNewSubmissionGroup.dtContactsDataTable contactsDataTable = (dsNewSubmissionGroup.dtContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNewSubmissionGroup.dtContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerContact = this.Columns["ProducerContact"];
      this.columnProducerContactID = this.Columns["ProducerContactID"];
      this.columnContactStatusID = this.Columns["ContactStatusID"];
      this.columnSelected = this.Columns["Selected"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnProducerContact = new DataColumn("ProducerContact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContact);
      this.columnProducerContactID = new DataColumn("ProducerContactID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContactID);
      this.columnContactStatusID = new DataColumn("ContactStatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactStatusID);
      this.columnSelected = new DataColumn("Selected", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSelected);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsNewSubmissionGroupKey1", new DataColumn[1]
      {
        this.columnProducerContactID
      }, true));
      this.columnProducerContact.AllowDBNull = false;
      this.columnProducerContactID.AllowDBNull = false;
      this.columnProducerContactID.Unique = true;
      this.columnContactStatusID.AllowDBNull = false;
      this.columnSelected.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.dtContactsRow NewdtContactsRow()
    {
      return (dsNewSubmissionGroup.dtContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNewSubmissionGroup.dtContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsNewSubmissionGroup.dtContactsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.dtContactsRowChangeEventHandler contactsRowChangedEvent = this.dtContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsNewSubmissionGroup.dtContactsRowChangeEvent((dsNewSubmissionGroup.dtContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.dtContactsRowChangeEventHandler rowChangingEvent = this.dtContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsNewSubmissionGroup.dtContactsRowChangeEvent((dsNewSubmissionGroup.dtContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.dtContactsRowChangeEventHandler contactsRowDeletedEvent = this.dtContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsNewSubmissionGroup.dtContactsRowChangeEvent((dsNewSubmissionGroup.dtContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.dtContactsRowChangeEventHandler rowDeletingEvent = this.dtContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsNewSubmissionGroup.dtContactsRowChangeEvent((dsNewSubmissionGroup.dtContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovedtContactsRow(dsNewSubmissionGroup.dtContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNewSubmissionGroup newSubmissionGroup = new dsNewSubmissionGroup();
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
        FixedValue = newSubmissionGroup.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newSubmissionGroup.GetSchemaSerializable();
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
  public class lstStatusDataTable : TypedTableBase<dsNewSubmissionGroup.lstStatusRow>
  {
    private DataColumn columnStatusID;
    private DataColumn columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstStatusDataTable()
    {
      this.TableName = "lstStatus";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstStatusDataTable(DataTable table)
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
    protected lstStatusDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.lstStatusRow this[int index]
    {
      get => (dsNewSubmissionGroup.lstStatusRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.lstStatusRowChangeEventHandler lstStatusRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.lstStatusRowChangeEventHandler lstStatusRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.lstStatusRowChangeEventHandler lstStatusRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNewSubmissionGroup.lstStatusRowChangeEventHandler lstStatusRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstStatusRow(dsNewSubmissionGroup.lstStatusRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.lstStatusRow AddlstStatusRow(int StatusID, string Status)
    {
      dsNewSubmissionGroup.lstStatusRow row = (dsNewSubmissionGroup.lstStatusRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) StatusID,
        (object) Status
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.lstStatusRow FindByStatusID(int StatusID)
    {
      return (dsNewSubmissionGroup.lstStatusRow) this.Rows.Find(new object[1]
      {
        (object) StatusID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNewSubmissionGroup.lstStatusDataTable lstStatusDataTable = (dsNewSubmissionGroup.lstStatusDataTable) base.Clone();
      lstStatusDataTable.InitVars();
      return (DataTable) lstStatusDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNewSubmissionGroup.lstStatusDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnStatusID = this.Columns["StatusID"];
      this.columnStatus = this.Columns["Status"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnStatusID
      }, true));
      this.columnStatusID.AllowDBNull = false;
      this.columnStatusID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.lstStatusRow NewlstStatusRow()
    {
      return (dsNewSubmissionGroup.lstStatusRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNewSubmissionGroup.lstStatusRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsNewSubmissionGroup.lstStatusRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.lstStatusRowChangeEventHandler statusRowChangedEvent = this.lstStatusRowChangedEvent;
      if (statusRowChangedEvent == null)
        return;
      statusRowChangedEvent((object) this, new dsNewSubmissionGroup.lstStatusRowChangeEvent((dsNewSubmissionGroup.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.lstStatusRowChangeEventHandler rowChangingEvent = this.lstStatusRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsNewSubmissionGroup.lstStatusRowChangeEvent((dsNewSubmissionGroup.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.lstStatusRowChangeEventHandler statusRowDeletedEvent = this.lstStatusRowDeletedEvent;
      if (statusRowDeletedEvent == null)
        return;
      statusRowDeletedEvent((object) this, new dsNewSubmissionGroup.lstStatusRowChangeEvent((dsNewSubmissionGroup.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatusRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNewSubmissionGroup.lstStatusRowChangeEventHandler rowDeletingEvent = this.lstStatusRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsNewSubmissionGroup.lstStatusRowChangeEvent((dsNewSubmissionGroup.lstStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstStatusRow(dsNewSubmissionGroup.lstStatusRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNewSubmissionGroup newSubmissionGroup = new dsNewSubmissionGroup();
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
        FixedValue = newSubmissionGroup.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatusDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = newSubmissionGroup.GetSchemaSerializable();
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

  public class UnderwritersRow : DataRow
  {
    private dsNewSubmissionGroup.UnderwritersDataTable tableUnderwriters;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal UnderwritersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableUnderwriters = (dsNewSubmissionGroup.UnderwritersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid UserGUID
    {
      get
      {
        object obj = this[this.tableUnderwriters.UserGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableUnderwriters.UserGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Name
    {
      get => Conversions.ToString(this[this.tableUnderwriters.NameColumn]);
      set => this[this.tableUnderwriters.NameColumn] = (object) value;
    }
  }

  public class tblUsersRow : DataRow
  {
    private dsNewSubmissionGroup.tblUsersDataTable tabletblUsers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblUsersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUsers = (dsNewSubmissionGroup.tblUsersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid UserGUID
    {
      get
      {
        object obj = this[this.tabletblUsers.UserGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblUsers.UserGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Name
    {
      get => Conversions.ToString(this[this.tabletblUsers.NameColumn]);
      set => this[this.tabletblUsers.NameColumn] = (object) value;
    }
  }

  public class tblSubmissionGroupRow : DataRow
  {
    private dsNewSubmissionGroup.tblSubmissionGroupDataTable tabletblSubmissionGroup;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblSubmissionGroupRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblSubmissionGroup = (dsNewSubmissionGroup.tblSubmissionGroupDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid SubmissionGroupGUID
    {
      get
      {
        object obj = this[this.tabletblSubmissionGroup.SubmissionGroupGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblSubmissionGroup.SubmissionGroupGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid InsuredGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblSubmissionGroup.InsuredGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredGUID' in table 'tblSubmissionGroup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblSubmissionGroup.InsuredGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ProducerLocationGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblSubmissionGroup.ProducerLocationGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationGUID' in table 'tblSubmissionGroup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblSubmissionGroup.ProducerLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid UnderwriterUserGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblSubmissionGroup.UnderwriterUserGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnderwriterUserGUID' in table 'tblSubmissionGroup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblSubmissionGroup.UnderwriterUserGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid TACSRUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblSubmissionGroup.TACSRUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TACSRUserGuid' in table 'tblSubmissionGroup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblSubmissionGroup.TACSRUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateSubmitted
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblSubmissionGroup.DateSubmittedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateSubmitted' in table 'tblSubmissionGroup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblSubmissionGroup.DateSubmittedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid InHouseProducerUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblSubmissionGroup.InHouseProducerUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InHouseProducerUserGuid' in table 'tblSubmissionGroup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblSubmissionGroup.InHouseProducerUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid AddedByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblSubmissionGroup.AddedByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddedByUserGuid' in table 'tblSubmissionGroup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblSubmissionGroup.AddedByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ProducerContactID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblSubmissionGroup.ProducerContactIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerContactID' in table 'tblSubmissionGroup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblSubmissionGroup.ProducerContactIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int SecProducerContactID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblSubmissionGroup.SecProducerContactIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SecProducerContactID' in table 'tblSubmissionGroup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblSubmissionGroup.SecProducerContactIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredGUIDNull() => this.IsNull(this.tabletblSubmissionGroup.InsuredGUIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredGUIDNull()
    {
      this[this.tabletblSubmissionGroup.InsuredGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerLocationGUIDNull()
    {
      return this.IsNull(this.tabletblSubmissionGroup.ProducerLocationGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerLocationGUIDNull()
    {
      this[this.tabletblSubmissionGroup.ProducerLocationGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUnderwriterUserGUIDNull()
    {
      return this.IsNull(this.tabletblSubmissionGroup.UnderwriterUserGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUnderwriterUserGUIDNull()
    {
      this[this.tabletblSubmissionGroup.UnderwriterUserGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTACSRUserGuidNull()
    {
      return this.IsNull(this.tabletblSubmissionGroup.TACSRUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTACSRUserGuidNull()
    {
      this[this.tabletblSubmissionGroup.TACSRUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateSubmittedNull()
    {
      return this.IsNull(this.tabletblSubmissionGroup.DateSubmittedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateSubmittedNull()
    {
      this[this.tabletblSubmissionGroup.DateSubmittedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInHouseProducerUserGuidNull()
    {
      return this.IsNull(this.tabletblSubmissionGroup.InHouseProducerUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInHouseProducerUserGuidNull()
    {
      this[this.tabletblSubmissionGroup.InHouseProducerUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddedByUserGuidNull()
    {
      return this.IsNull(this.tabletblSubmissionGroup.AddedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddedByUserGuidNull()
    {
      this[this.tabletblSubmissionGroup.AddedByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerContactIDNull()
    {
      return this.IsNull(this.tabletblSubmissionGroup.ProducerContactIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerContactIDNull()
    {
      this[this.tabletblSubmissionGroup.ProducerContactIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSecProducerContactIDNull()
    {
      return this.IsNull(this.tabletblSubmissionGroup.SecProducerContactIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSecProducerContactIDNull()
    {
      this[this.tabletblSubmissionGroup.SecProducerContactIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblProducerLocationsRow : DataRow
  {
    private dsNewSubmissionGroup.tblProducerLocationsDataTable tabletblProducerLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducerLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerLocations = (dsNewSubmissionGroup.tblProducerLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ProducerLocationGUID
    {
      get
      {
        object obj = this[this.tabletblProducerLocations.ProducerLocationGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducerLocations.ProducerLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Name
    {
      get => Conversions.ToString(this[this.tabletblProducerLocations.NameColumn]);
      set => this[this.tabletblProducerLocations.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int StatusID
    {
      get => Conversions.ToInteger(this[this.tabletblProducerLocations.StatusIDColumn]);
      set => this[this.tabletblProducerLocations.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerContact
    {
      get => Conversions.ToString(this[this.tabletblProducerLocations.ProducerContactColumn]);
      set => this[this.tabletblProducerLocations.ProducerContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ProducerContactID
    {
      get => Conversions.ToInteger(this[this.tabletblProducerLocations.ProducerContactIDColumn]);
      set => this[this.tabletblProducerLocations.ProducerContactIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ContactAndProducer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerLocations.ContactAndProducerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ContactAndProducer' in table 'tblProducerLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerLocations.ContactAndProducerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ContactStatusID
    {
      get => Conversions.ToInteger(this[this.tabletblProducerLocations.ContactStatusIDColumn]);
      set => this[this.tabletblProducerLocations.ContactStatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsContactAndProducerNull()
    {
      return this.IsNull(this.tabletblProducerLocations.ContactAndProducerColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetContactAndProducerNull()
    {
      this[this.tabletblProducerLocations.ContactAndProducerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class InhouseProducersRow : DataRow
  {
    private dsNewSubmissionGroup.InhouseProducersDataTable tableInhouseProducers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal InhouseProducersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInhouseProducers = (dsNewSubmissionGroup.InhouseProducersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid UserGUID
    {
      get
      {
        object obj = this[this.tableInhouseProducers.UserGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableInhouseProducers.UserGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Name
    {
      get => Conversions.ToString(this[this.tableInhouseProducers.NameColumn]);
      set => this[this.tableInhouseProducers.NameColumn] = (object) value;
    }
  }

  public class TACSRRow : DataRow
  {
    private dsNewSubmissionGroup.TACSRDataTable tableTACSR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal TACSRRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTACSR = (dsNewSubmissionGroup.TACSRDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid UserGUID
    {
      get
      {
        object obj = this[this.tableTACSR.UserGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTACSR.UserGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Name
    {
      get => Conversions.ToString(this[this.tableTACSR.NameColumn]);
      set => this[this.tableTACSR.NameColumn] = (object) value;
    }
  }

  public class tblProducerInhouseRow : DataRow
  {
    private dsNewSubmissionGroup.tblProducerInhouseDataTable tabletblProducerInhouse;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblProducerInhouseRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerInhouse = (dsNewSubmissionGroup.tblProducerInhouseDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ProducerLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducerInhouse.ProducerLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationGuid' in table 'tblProducerInhouse' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerInhouse.ProducerLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ProducerGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducerInhouse.ProducerGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerGuid' in table 'tblProducerInhouse' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerInhouse.ProducerGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid InhouseProducerGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducerInhouse.InhouseProducerGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InhouseProducerGuid' in table 'tblProducerInhouse' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerInhouse.InhouseProducerGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerLocationGuidNull()
    {
      return this.IsNull(this.tabletblProducerInhouse.ProducerLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerLocationGuidNull()
    {
      this[this.tabletblProducerInhouse.ProducerLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerGuidNull()
    {
      return this.IsNull(this.tabletblProducerInhouse.ProducerGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerGuidNull()
    {
      this[this.tabletblProducerInhouse.ProducerGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInhouseProducerGuidNull()
    {
      return this.IsNull(this.tabletblProducerInhouse.InhouseProducerGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInhouseProducerGuidNull()
    {
      this[this.tabletblProducerInhouse.InhouseProducerGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtContactsRow : DataRow
  {
    private dsNewSubmissionGroup.dtContactsDataTable tabledtContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal dtContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtContacts = (dsNewSubmissionGroup.dtContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerContact
    {
      get => Conversions.ToString(this[this.tabledtContacts.ProducerContactColumn]);
      set => this[this.tabledtContacts.ProducerContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ProducerContactID
    {
      get => Conversions.ToInteger(this[this.tabledtContacts.ProducerContactIDColumn]);
      set => this[this.tabledtContacts.ProducerContactIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ContactStatusID
    {
      get => Conversions.ToInteger(this[this.tabledtContacts.ContactStatusIDColumn]);
      set => this[this.tabledtContacts.ContactStatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Selected
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtContacts.SelectedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Selected' in table 'dtContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtContacts.SelectedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSelectedNull() => this.IsNull(this.tabledtContacts.SelectedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSelectedNull()
    {
      this[this.tabledtContacts.SelectedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstStatusRow : DataRow
  {
    private dsNewSubmissionGroup.lstStatusDataTable tablelstStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstStatusRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStatus = (dsNewSubmissionGroup.lstStatusDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int StatusID
    {
      get => Conversions.ToInteger(this[this.tablelstStatus.StatusIDColumn]);
      set => this[this.tablelstStatus.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Status
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstStatus.StatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Status' in table 'lstStatus' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstStatus.StatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStatusNull() => this.IsNull(this.tablelstStatus.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatusNull()
    {
      this[this.tablelstStatus.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class UnderwritersRowChangeEvent : EventArgs
  {
    private dsNewSubmissionGroup.UnderwritersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public UnderwritersRowChangeEvent(
      dsNewSubmissionGroup.UnderwritersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.UnderwritersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblUsersRowChangeEvent : EventArgs
  {
    private dsNewSubmissionGroup.tblUsersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblUsersRowChangeEvent(dsNewSubmissionGroup.tblUsersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblUsersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblSubmissionGroupRowChangeEvent : EventArgs
  {
    private dsNewSubmissionGroup.tblSubmissionGroupRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblSubmissionGroupRowChangeEvent(
      dsNewSubmissionGroup.tblSubmissionGroupRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblSubmissionGroupRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblProducerLocationsRowChangeEvent : EventArgs
  {
    private dsNewSubmissionGroup.tblProducerLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerLocationsRowChangeEvent(
      dsNewSubmissionGroup.tblProducerLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblProducerLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class InhouseProducersRowChangeEvent : EventArgs
  {
    private dsNewSubmissionGroup.InhouseProducersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public InhouseProducersRowChangeEvent(
      dsNewSubmissionGroup.InhouseProducersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.InhouseProducersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class TACSRRowChangeEvent : EventArgs
  {
    private dsNewSubmissionGroup.TACSRRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TACSRRowChangeEvent(dsNewSubmissionGroup.TACSRRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.TACSRRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblProducerInhouseRowChangeEvent : EventArgs
  {
    private dsNewSubmissionGroup.tblProducerInhouseRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblProducerInhouseRowChangeEvent(
      dsNewSubmissionGroup.tblProducerInhouseRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.tblProducerInhouseRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class dtContactsRowChangeEvent : EventArgs
  {
    private dsNewSubmissionGroup.dtContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dtContactsRowChangeEvent(dsNewSubmissionGroup.dtContactsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.dtContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstStatusRowChangeEvent : EventArgs
  {
    private dsNewSubmissionGroup.lstStatusRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstStatusRowChangeEvent(dsNewSubmissionGroup.lstStatusRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNewSubmissionGroup.lstStatusRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
