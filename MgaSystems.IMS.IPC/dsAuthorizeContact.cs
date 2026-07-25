// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.dsAuthorizeContact
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
[XmlRoot("dsAuthorizeContact")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsAuthorizeContact : DataSet
{
  private dsAuthorizeContact.tblContactsExternalAuthorizationDataTable tabletblContactsExternalAuthorization;
  private dsAuthorizeContact.lstExternalContactProgramsDataTable tablelstExternalContactPrograms;
  private dsAuthorizeContact.lstExternalContactSecurityPermissionsDataTable tablelstExternalContactSecurityPermissions;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsAuthorizeContact()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected dsAuthorizeContact(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblContactsExternalAuthorization)] != null)
          base.Tables.Add((DataTable) new dsAuthorizeContact.tblContactsExternalAuthorizationDataTable(dataSet.Tables[nameof (tblContactsExternalAuthorization)]));
        if (dataSet.Tables[nameof (lstExternalContactPrograms)] != null)
          base.Tables.Add((DataTable) new dsAuthorizeContact.lstExternalContactProgramsDataTable(dataSet.Tables[nameof (lstExternalContactPrograms)]));
        if (dataSet.Tables[nameof (lstExternalContactSecurityPermissions)] != null)
          base.Tables.Add((DataTable) new dsAuthorizeContact.lstExternalContactSecurityPermissionsDataTable(dataSet.Tables[nameof (lstExternalContactSecurityPermissions)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAuthorizeContact.tblContactsExternalAuthorizationDataTable tblContactsExternalAuthorization
  {
    get => this.tabletblContactsExternalAuthorization;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAuthorizeContact.lstExternalContactProgramsDataTable lstExternalContactPrograms
  {
    get => this.tablelstExternalContactPrograms;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAuthorizeContact.lstExternalContactSecurityPermissionsDataTable lstExternalContactSecurityPermissions
  {
    get => this.tablelstExternalContactSecurityPermissions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public override DataSet Clone()
  {
    dsAuthorizeContact authorizeContact = (dsAuthorizeContact) base.Clone();
    authorizeContact.InitVars();
    authorizeContact.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) authorizeContact;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["tblContactsExternalAuthorization"] != null)
        base.Tables.Add((DataTable) new dsAuthorizeContact.tblContactsExternalAuthorizationDataTable(dataSet.Tables["tblContactsExternalAuthorization"]));
      if (dataSet.Tables["lstExternalContactPrograms"] != null)
        base.Tables.Add((DataTable) new dsAuthorizeContact.lstExternalContactProgramsDataTable(dataSet.Tables["lstExternalContactPrograms"]));
      if (dataSet.Tables["lstExternalContactSecurityPermissions"] != null)
        base.Tables.Add((DataTable) new dsAuthorizeContact.lstExternalContactSecurityPermissionsDataTable(dataSet.Tables["lstExternalContactSecurityPermissions"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tabletblContactsExternalAuthorization = (dsAuthorizeContact.tblContactsExternalAuthorizationDataTable) base.Tables["tblContactsExternalAuthorization"];
    if (initTable && this.tabletblContactsExternalAuthorization != null)
      this.tabletblContactsExternalAuthorization.InitVars();
    this.tablelstExternalContactPrograms = (dsAuthorizeContact.lstExternalContactProgramsDataTable) base.Tables["lstExternalContactPrograms"];
    if (initTable && this.tablelstExternalContactPrograms != null)
      this.tablelstExternalContactPrograms.InitVars();
    this.tablelstExternalContactSecurityPermissions = (dsAuthorizeContact.lstExternalContactSecurityPermissionsDataTable) base.Tables["lstExternalContactSecurityPermissions"];
    if (!initTable || this.tablelstExternalContactSecurityPermissions == null)
      return;
    this.tablelstExternalContactSecurityPermissions.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsAuthorizeContact);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsAuthorizeContact.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblContactsExternalAuthorization = new dsAuthorizeContact.tblContactsExternalAuthorizationDataTable();
    base.Tables.Add((DataTable) this.tabletblContactsExternalAuthorization);
    this.tablelstExternalContactPrograms = new dsAuthorizeContact.lstExternalContactProgramsDataTable();
    base.Tables.Add((DataTable) this.tablelstExternalContactPrograms);
    this.tablelstExternalContactSecurityPermissions = new dsAuthorizeContact.lstExternalContactSecurityPermissionsDataTable();
    base.Tables.Add((DataTable) this.tablelstExternalContactSecurityPermissions);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblContactsExternalAuthorization() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstExternalContactPrograms() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializelstExternalContactSecurityPermissions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsAuthorizeContact authorizeContact = new dsAuthorizeContact();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = authorizeContact.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = authorizeContact.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblContactsExternalAuthorizationRowChangeEventHandler(
    object sender,
    dsAuthorizeContact.tblContactsExternalAuthorizationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstExternalContactProgramsRowChangeEventHandler(
    object sender,
    dsAuthorizeContact.lstExternalContactProgramsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void lstExternalContactSecurityPermissionsRowChangeEventHandler(
    object sender,
    dsAuthorizeContact.lstExternalContactSecurityPermissionsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblContactsExternalAuthorizationDataTable : 
    TypedTableBase<dsAuthorizeContact.tblContactsExternalAuthorizationRow>
  {
    private DataColumn columnProgramCode;
    private DataColumn columnContactGuid;
    private DataColumn columnPassword;
    private DataColumn columnIsAdmin;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblContactsExternalAuthorizationDataTable()
    {
      this.TableName = "tblContactsExternalAuthorization";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblContactsExternalAuthorizationDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblContactsExternalAuthorizationDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProgramCodeColumn => this.columnProgramCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ContactGuidColumn => this.columnContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PasswordColumn => this.columnPassword;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IsAdminColumn => this.columnIsAdmin;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAuthorizeContact.tblContactsExternalAuthorizationRow this[int index]
    {
      get => (dsAuthorizeContact.tblContactsExternalAuthorizationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAuthorizeContact.tblContactsExternalAuthorizationRowChangeEventHandler tblContactsExternalAuthorizationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAuthorizeContact.tblContactsExternalAuthorizationRowChangeEventHandler tblContactsExternalAuthorizationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAuthorizeContact.tblContactsExternalAuthorizationRowChangeEventHandler tblContactsExternalAuthorizationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAuthorizeContact.tblContactsExternalAuthorizationRowChangeEventHandler tblContactsExternalAuthorizationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblContactsExternalAuthorizationRow(
      dsAuthorizeContact.tblContactsExternalAuthorizationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAuthorizeContact.tblContactsExternalAuthorizationRow AddtblContactsExternalAuthorizationRow(
      string ProgramCode,
      Guid ContactGuid,
      string Password,
      bool IsAdmin)
    {
      dsAuthorizeContact.tblContactsExternalAuthorizationRow row = (dsAuthorizeContact.tblContactsExternalAuthorizationRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) ProgramCode,
        (object) ContactGuid,
        (object) Password,
        (object) IsAdmin
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAuthorizeContact.tblContactsExternalAuthorizationDataTable authorizationDataTable = (dsAuthorizeContact.tblContactsExternalAuthorizationDataTable) base.Clone();
      authorizationDataTable.InitVars();
      return (DataTable) authorizationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAuthorizeContact.tblContactsExternalAuthorizationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnProgramCode = this.Columns["ProgramCode"];
      this.columnContactGuid = this.Columns["ContactGuid"];
      this.columnPassword = this.Columns["Password"];
      this.columnIsAdmin = this.Columns["IsAdmin"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnProgramCode = new DataColumn("ProgramCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgramCode);
      this.columnContactGuid = new DataColumn("ContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactGuid);
      this.columnPassword = new DataColumn("Password", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPassword);
      this.columnIsAdmin = new DataColumn("IsAdmin", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsAdmin);
      this.columnContactGuid.AllowDBNull = false;
      this.columnIsAdmin.AllowDBNull = false;
      this.columnIsAdmin.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAuthorizeContact.tblContactsExternalAuthorizationRow NewtblContactsExternalAuthorizationRow()
    {
      return (dsAuthorizeContact.tblContactsExternalAuthorizationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAuthorizeContact.tblContactsExternalAuthorizationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAuthorizeContact.tblContactsExternalAuthorizationRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblContactsExternalAuthorizationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAuthorizeContact.tblContactsExternalAuthorizationRowChangeEventHandler authorizationRowChangedEvent = this.tblContactsExternalAuthorizationRowChangedEvent;
      if (authorizationRowChangedEvent == null)
        return;
      authorizationRowChangedEvent((object) this, new dsAuthorizeContact.tblContactsExternalAuthorizationRowChangeEvent((dsAuthorizeContact.tblContactsExternalAuthorizationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblContactsExternalAuthorizationRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAuthorizeContact.tblContactsExternalAuthorizationRowChangeEventHandler rowChangingEvent = this.tblContactsExternalAuthorizationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAuthorizeContact.tblContactsExternalAuthorizationRowChangeEvent((dsAuthorizeContact.tblContactsExternalAuthorizationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblContactsExternalAuthorizationRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAuthorizeContact.tblContactsExternalAuthorizationRowChangeEventHandler authorizationRowDeletedEvent = this.tblContactsExternalAuthorizationRowDeletedEvent;
      if (authorizationRowDeletedEvent == null)
        return;
      authorizationRowDeletedEvent((object) this, new dsAuthorizeContact.tblContactsExternalAuthorizationRowChangeEvent((dsAuthorizeContact.tblContactsExternalAuthorizationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblContactsExternalAuthorizationRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAuthorizeContact.tblContactsExternalAuthorizationRowChangeEventHandler rowDeletingEvent = this.tblContactsExternalAuthorizationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAuthorizeContact.tblContactsExternalAuthorizationRowChangeEvent((dsAuthorizeContact.tblContactsExternalAuthorizationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblContactsExternalAuthorizationRow(
      dsAuthorizeContact.tblContactsExternalAuthorizationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAuthorizeContact authorizeContact = new dsAuthorizeContact();
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
        FixedValue = authorizeContact.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblContactsExternalAuthorizationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = authorizeContact.GetSchemaSerializable();
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
  public class lstExternalContactProgramsDataTable : 
    TypedTableBase<dsAuthorizeContact.lstExternalContactProgramsRow>
  {
    private DataColumn columnProgramCode;
    private DataColumn columnProgramName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstExternalContactProgramsDataTable()
    {
      this.TableName = "lstExternalContactPrograms";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstExternalContactProgramsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstExternalContactProgramsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProgramCodeColumn => this.columnProgramCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProgramNameColumn => this.columnProgramName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAuthorizeContact.lstExternalContactProgramsRow this[int index]
    {
      get => (dsAuthorizeContact.lstExternalContactProgramsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAuthorizeContact.lstExternalContactProgramsRowChangeEventHandler lstExternalContactProgramsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAuthorizeContact.lstExternalContactProgramsRowChangeEventHandler lstExternalContactProgramsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAuthorizeContact.lstExternalContactProgramsRowChangeEventHandler lstExternalContactProgramsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAuthorizeContact.lstExternalContactProgramsRowChangeEventHandler lstExternalContactProgramsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstExternalContactProgramsRow(
      dsAuthorizeContact.lstExternalContactProgramsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAuthorizeContact.lstExternalContactProgramsRow AddlstExternalContactProgramsRow(
      string ProgramCode,
      string ProgramName)
    {
      dsAuthorizeContact.lstExternalContactProgramsRow row = (dsAuthorizeContact.lstExternalContactProgramsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ProgramCode,
        (object) ProgramName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAuthorizeContact.lstExternalContactProgramsRow FindByProgramCode(string ProgramCode)
    {
      return (dsAuthorizeContact.lstExternalContactProgramsRow) this.Rows.Find(new object[1]
      {
        (object) ProgramCode
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAuthorizeContact.lstExternalContactProgramsDataTable programsDataTable = (dsAuthorizeContact.lstExternalContactProgramsDataTable) base.Clone();
      programsDataTable.InitVars();
      return (DataTable) programsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAuthorizeContact.lstExternalContactProgramsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnProgramCode = this.Columns["ProgramCode"];
      this.columnProgramName = this.Columns["ProgramName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnProgramCode = new DataColumn("ProgramCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgramCode);
      this.columnProgramName = new DataColumn("ProgramName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProgramName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnProgramCode
      }, true));
      this.columnProgramCode.AllowDBNull = false;
      this.columnProgramCode.Unique = true;
      this.columnProgramName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAuthorizeContact.lstExternalContactProgramsRow NewlstExternalContactProgramsRow()
    {
      return (dsAuthorizeContact.lstExternalContactProgramsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAuthorizeContact.lstExternalContactProgramsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAuthorizeContact.lstExternalContactProgramsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstExternalContactProgramsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAuthorizeContact.lstExternalContactProgramsRowChangeEventHandler programsRowChangedEvent = this.lstExternalContactProgramsRowChangedEvent;
      if (programsRowChangedEvent == null)
        return;
      programsRowChangedEvent((object) this, new dsAuthorizeContact.lstExternalContactProgramsRowChangeEvent((dsAuthorizeContact.lstExternalContactProgramsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstExternalContactProgramsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAuthorizeContact.lstExternalContactProgramsRowChangeEventHandler rowChangingEvent = this.lstExternalContactProgramsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAuthorizeContact.lstExternalContactProgramsRowChangeEvent((dsAuthorizeContact.lstExternalContactProgramsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstExternalContactProgramsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAuthorizeContact.lstExternalContactProgramsRowChangeEventHandler programsRowDeletedEvent = this.lstExternalContactProgramsRowDeletedEvent;
      if (programsRowDeletedEvent == null)
        return;
      programsRowDeletedEvent((object) this, new dsAuthorizeContact.lstExternalContactProgramsRowChangeEvent((dsAuthorizeContact.lstExternalContactProgramsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstExternalContactProgramsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAuthorizeContact.lstExternalContactProgramsRowChangeEventHandler rowDeletingEvent = this.lstExternalContactProgramsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAuthorizeContact.lstExternalContactProgramsRowChangeEvent((dsAuthorizeContact.lstExternalContactProgramsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstExternalContactProgramsRow(
      dsAuthorizeContact.lstExternalContactProgramsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAuthorizeContact authorizeContact = new dsAuthorizeContact();
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
        FixedValue = authorizeContact.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstExternalContactProgramsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = authorizeContact.GetSchemaSerializable();
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
  public class lstExternalContactSecurityPermissionsDataTable : 
    TypedTableBase<dsAuthorizeContact.lstExternalContactSecurityPermissionsRow>
  {
    private DataColumn columnSecurityCode;
    private DataColumn columnDescription;
    private DataColumn columnAdd;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstExternalContactSecurityPermissionsDataTable()
    {
      this.TableName = "lstExternalContactSecurityPermissions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstExternalContactSecurityPermissionsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected lstExternalContactSecurityPermissionsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SecurityCodeColumn => this.columnSecurityCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AddColumn => this.columnAdd;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAuthorizeContact.lstExternalContactSecurityPermissionsRow this[int index]
    {
      get => (dsAuthorizeContact.lstExternalContactSecurityPermissionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAuthorizeContact.lstExternalContactSecurityPermissionsRowChangeEventHandler lstExternalContactSecurityPermissionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAuthorizeContact.lstExternalContactSecurityPermissionsRowChangeEventHandler lstExternalContactSecurityPermissionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAuthorizeContact.lstExternalContactSecurityPermissionsRowChangeEventHandler lstExternalContactSecurityPermissionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsAuthorizeContact.lstExternalContactSecurityPermissionsRowChangeEventHandler lstExternalContactSecurityPermissionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddlstExternalContactSecurityPermissionsRow(
      dsAuthorizeContact.lstExternalContactSecurityPermissionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAuthorizeContact.lstExternalContactSecurityPermissionsRow AddlstExternalContactSecurityPermissionsRow(
      string SecurityCode,
      string Description,
      bool Add)
    {
      dsAuthorizeContact.lstExternalContactSecurityPermissionsRow row = (dsAuthorizeContact.lstExternalContactSecurityPermissionsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) SecurityCode,
        (object) Description,
        (object) Add
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsAuthorizeContact.lstExternalContactSecurityPermissionsDataTable permissionsDataTable = (dsAuthorizeContact.lstExternalContactSecurityPermissionsDataTable) base.Clone();
      permissionsDataTable.InitVars();
      return (DataTable) permissionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAuthorizeContact.lstExternalContactSecurityPermissionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnSecurityCode = this.Columns["SecurityCode"];
      this.columnDescription = this.Columns["Description"];
      this.columnAdd = this.Columns["Add"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnSecurityCode = new DataColumn("SecurityCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSecurityCode);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnAdd = new DataColumn("Add", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdd);
      this.columnAdd.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAuthorizeContact.lstExternalContactSecurityPermissionsRow NewlstExternalContactSecurityPermissionsRow()
    {
      return (dsAuthorizeContact.lstExternalContactSecurityPermissionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAuthorizeContact.lstExternalContactSecurityPermissionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAuthorizeContact.lstExternalContactSecurityPermissionsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstExternalContactSecurityPermissionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAuthorizeContact.lstExternalContactSecurityPermissionsRowChangeEventHandler permissionsRowChangedEvent = this.lstExternalContactSecurityPermissionsRowChangedEvent;
      if (permissionsRowChangedEvent == null)
        return;
      permissionsRowChangedEvent((object) this, new dsAuthorizeContact.lstExternalContactSecurityPermissionsRowChangeEvent((dsAuthorizeContact.lstExternalContactSecurityPermissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstExternalContactSecurityPermissionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAuthorizeContact.lstExternalContactSecurityPermissionsRowChangeEventHandler rowChangingEvent = this.lstExternalContactSecurityPermissionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAuthorizeContact.lstExternalContactSecurityPermissionsRowChangeEvent((dsAuthorizeContact.lstExternalContactSecurityPermissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstExternalContactSecurityPermissionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAuthorizeContact.lstExternalContactSecurityPermissionsRowChangeEventHandler permissionsRowDeletedEvent = this.lstExternalContactSecurityPermissionsRowDeletedEvent;
      if (permissionsRowDeletedEvent == null)
        return;
      permissionsRowDeletedEvent((object) this, new dsAuthorizeContact.lstExternalContactSecurityPermissionsRowChangeEvent((dsAuthorizeContact.lstExternalContactSecurityPermissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstExternalContactSecurityPermissionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAuthorizeContact.lstExternalContactSecurityPermissionsRowChangeEventHandler rowDeletingEvent = this.lstExternalContactSecurityPermissionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAuthorizeContact.lstExternalContactSecurityPermissionsRowChangeEvent((dsAuthorizeContact.lstExternalContactSecurityPermissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovelstExternalContactSecurityPermissionsRow(
      dsAuthorizeContact.lstExternalContactSecurityPermissionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAuthorizeContact authorizeContact = new dsAuthorizeContact();
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
        FixedValue = authorizeContact.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstExternalContactSecurityPermissionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = authorizeContact.GetSchemaSerializable();
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

  public class tblContactsExternalAuthorizationRow : DataRow
  {
    private dsAuthorizeContact.tblContactsExternalAuthorizationDataTable tabletblContactsExternalAuthorization;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblContactsExternalAuthorizationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblContactsExternalAuthorization = (dsAuthorizeContact.tblContactsExternalAuthorizationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProgramCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblContactsExternalAuthorization.ProgramCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProgramCode' in table 'tblContactsExternalAuthorization' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblContactsExternalAuthorization.ProgramCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid ContactGuid
    {
      get
      {
        object obj = this[this.tabletblContactsExternalAuthorization.ContactGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblContactsExternalAuthorization.ContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Password
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblContactsExternalAuthorization.PasswordColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Password' in table 'tblContactsExternalAuthorization' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblContactsExternalAuthorization.PasswordColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAdmin
    {
      get => Conversions.ToBoolean(this[this.tabletblContactsExternalAuthorization.IsAdminColumn]);
      set => this[this.tabletblContactsExternalAuthorization.IsAdminColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProgramCodeNull()
    {
      return this.IsNull(this.tabletblContactsExternalAuthorization.ProgramCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProgramCodeNull()
    {
      this[this.tabletblContactsExternalAuthorization.ProgramCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPasswordNull()
    {
      return this.IsNull(this.tabletblContactsExternalAuthorization.PasswordColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPasswordNull()
    {
      this[this.tabletblContactsExternalAuthorization.PasswordColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstExternalContactProgramsRow : DataRow
  {
    private dsAuthorizeContact.lstExternalContactProgramsDataTable tablelstExternalContactPrograms;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstExternalContactProgramsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstExternalContactPrograms = (dsAuthorizeContact.lstExternalContactProgramsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProgramCode
    {
      get => Conversions.ToString(this[this.tablelstExternalContactPrograms.ProgramCodeColumn]);
      set => this[this.tablelstExternalContactPrograms.ProgramCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProgramName
    {
      get => Conversions.ToString(this[this.tablelstExternalContactPrograms.ProgramNameColumn]);
      set => this[this.tablelstExternalContactPrograms.ProgramNameColumn] = (object) value;
    }
  }

  public class lstExternalContactSecurityPermissionsRow : DataRow
  {
    private dsAuthorizeContact.lstExternalContactSecurityPermissionsDataTable tablelstExternalContactSecurityPermissions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal lstExternalContactSecurityPermissionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstExternalContactSecurityPermissions = (dsAuthorizeContact.lstExternalContactSecurityPermissionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string SecurityCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstExternalContactSecurityPermissions.SecurityCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SecurityCode' in table 'lstExternalContactSecurityPermissions' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablelstExternalContactSecurityPermissions.SecurityCodeColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstExternalContactSecurityPermissions.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'lstExternalContactSecurityPermissions' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablelstExternalContactSecurityPermissions.DescriptionColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Add
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstExternalContactSecurityPermissions.AddColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Add' in table 'lstExternalContactSecurityPermissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstExternalContactSecurityPermissions.AddColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSecurityCodeNull()
    {
      return this.IsNull(this.tablelstExternalContactSecurityPermissions.SecurityCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSecurityCodeNull()
    {
      this[this.tablelstExternalContactSecurityPermissions.SecurityCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDescriptionNull()
    {
      return this.IsNull(this.tablelstExternalContactSecurityPermissions.DescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tablelstExternalContactSecurityPermissions.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAddNull()
    {
      return this.IsNull(this.tablelstExternalContactSecurityPermissions.AddColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAddNull()
    {
      this[this.tablelstExternalContactSecurityPermissions.AddColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblContactsExternalAuthorizationRowChangeEvent : EventArgs
  {
    private dsAuthorizeContact.tblContactsExternalAuthorizationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblContactsExternalAuthorizationRowChangeEvent(
      dsAuthorizeContact.tblContactsExternalAuthorizationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAuthorizeContact.tblContactsExternalAuthorizationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstExternalContactProgramsRowChangeEvent : EventArgs
  {
    private dsAuthorizeContact.lstExternalContactProgramsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstExternalContactProgramsRowChangeEvent(
      dsAuthorizeContact.lstExternalContactProgramsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAuthorizeContact.lstExternalContactProgramsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class lstExternalContactSecurityPermissionsRowChangeEvent : EventArgs
  {
    private dsAuthorizeContact.lstExternalContactSecurityPermissionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public lstExternalContactSecurityPermissionsRowChangeEvent(
      dsAuthorizeContact.lstExternalContactSecurityPermissionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsAuthorizeContact.lstExternalContactSecurityPermissionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
