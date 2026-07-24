// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.dsRequirements
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

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
namespace MGASystems.IMS.Forms;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsRequirements")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsRequirements : DataSet
{
  private dsRequirements.lstBindingRequirementsDataTable tablelstBindingRequirements;
  private dsRequirements.tblCompanyLineRequirementsAdminDataTable tabletblCompanyLineRequirementsAdmin;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsRequirements()
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
  protected dsRequirements(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstBindingRequirements)] != null)
          base.Tables.Add((DataTable) new dsRequirements.lstBindingRequirementsDataTable(dataSet.Tables[nameof (lstBindingRequirements)]));
        if (dataSet.Tables[nameof (tblCompanyLineRequirementsAdmin)] != null)
          base.Tables.Add((DataTable) new dsRequirements.tblCompanyLineRequirementsAdminDataTable(dataSet.Tables[nameof (tblCompanyLineRequirementsAdmin)]));
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
  public dsRequirements.lstBindingRequirementsDataTable lstBindingRequirements
  {
    get => this.tablelstBindingRequirements;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRequirements.tblCompanyLineRequirementsAdminDataTable tblCompanyLineRequirementsAdmin
  {
    get => this.tabletblCompanyLineRequirementsAdmin;
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
    dsRequirements dsRequirements = (dsRequirements) base.Clone();
    dsRequirements.InitVars();
    dsRequirements.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsRequirements;
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
      if (dataSet.Tables["lstBindingRequirements"] != null)
        base.Tables.Add((DataTable) new dsRequirements.lstBindingRequirementsDataTable(dataSet.Tables["lstBindingRequirements"]));
      if (dataSet.Tables["tblCompanyLineRequirementsAdmin"] != null)
        base.Tables.Add((DataTable) new dsRequirements.tblCompanyLineRequirementsAdminDataTable(dataSet.Tables["tblCompanyLineRequirementsAdmin"]));
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
    this.tablelstBindingRequirements = (dsRequirements.lstBindingRequirementsDataTable) base.Tables["lstBindingRequirements"];
    if (initTable && this.tablelstBindingRequirements != null)
      this.tablelstBindingRequirements.InitVars();
    this.tabletblCompanyLineRequirementsAdmin = (dsRequirements.tblCompanyLineRequirementsAdminDataTable) base.Tables["tblCompanyLineRequirementsAdmin"];
    if (!initTable || this.tabletblCompanyLineRequirementsAdmin == null)
      return;
    this.tabletblCompanyLineRequirementsAdmin.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsRequirements);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsRequirements.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstBindingRequirements = new dsRequirements.lstBindingRequirementsDataTable();
    base.Tables.Add((DataTable) this.tablelstBindingRequirements);
    this.tabletblCompanyLineRequirementsAdmin = new dsRequirements.tblCompanyLineRequirementsAdminDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLineRequirementsAdmin);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstBindingRequirements() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyLineRequirementsAdmin() => false;

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
    dsRequirements dsRequirements = new dsRequirements();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsRequirements.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsRequirements.GetSchemaSerializable();
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

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyLineRequirementsAdminDataTable : 
    TypedTableBase<dsRequirements.tblCompanyLineRequirementsAdminRow>
  {
    private DataColumn columnBindingRequirementID;
    private DataColumn columnStoredProcName;
    private DataColumn columnID;

    private void tblCompanyLineRequirementsAdminDataTable_tblCompanyLineRequirementsAdminRowChanging(
      object sender,
      dsRequirements.tblCompanyLineRequirementsAdminRowChangeEvent e)
    {
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLineRequirementsAdminDataTable()
    {
      this.tblCompanyLineRequirementsAdminRowChanging += new dsRequirements.tblCompanyLineRequirementsAdminRowChangeEventHandler(this.tblCompanyLineRequirementsAdminDataTable_tblCompanyLineRequirementsAdminRowChanging);
      this.TableName = "tblCompanyLineRequirementsAdmin";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLineRequirementsAdminDataTable(DataTable table)
    {
      this.tblCompanyLineRequirementsAdminRowChanging += new dsRequirements.tblCompanyLineRequirementsAdminRowChangeEventHandler(this.tblCompanyLineRequirementsAdminDataTable_tblCompanyLineRequirementsAdminRowChanging);
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
    protected tblCompanyLineRequirementsAdminDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.tblCompanyLineRequirementsAdminRowChanging += new dsRequirements.tblCompanyLineRequirementsAdminRowChangeEventHandler(this.tblCompanyLineRequirementsAdminDataTable_tblCompanyLineRequirementsAdminRowChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BindingRequirementIDColumn => this.columnBindingRequirementID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StoredProcNameColumn => this.columnStoredProcName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequirements.tblCompanyLineRequirementsAdminRow this[int index]
    {
      get => (dsRequirements.tblCompanyLineRequirementsAdminRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequirements.tblCompanyLineRequirementsAdminRowChangeEventHandler tblCompanyLineRequirementsAdminRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequirements.tblCompanyLineRequirementsAdminRowChangeEventHandler tblCompanyLineRequirementsAdminRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequirements.tblCompanyLineRequirementsAdminRowChangeEventHandler tblCompanyLineRequirementsAdminRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequirements.tblCompanyLineRequirementsAdminRowChangeEventHandler tblCompanyLineRequirementsAdminRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyLineRequirementsAdminRow(
      dsRequirements.tblCompanyLineRequirementsAdminRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequirements.tblCompanyLineRequirementsAdminRow AddtblCompanyLineRequirementsAdminRow(
      int BindingRequirementID,
      string StoredProcName)
    {
      dsRequirements.tblCompanyLineRequirementsAdminRow row = (dsRequirements.tblCompanyLineRequirementsAdminRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) BindingRequirementID,
        (object) StoredProcName,
        null
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequirements.tblCompanyLineRequirementsAdminRow FindByID(int ID)
    {
      return (dsRequirements.tblCompanyLineRequirementsAdminRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRequirements.tblCompanyLineRequirementsAdminDataTable requirementsAdminDataTable = (dsRequirements.tblCompanyLineRequirementsAdminDataTable) base.Clone();
      requirementsAdminDataTable.InitVars();
      return (DataTable) requirementsAdminDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRequirements.tblCompanyLineRequirementsAdminDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnBindingRequirementID = this.Columns["BindingRequirementID"];
      this.columnStoredProcName = this.Columns["StoredProcName"];
      this.columnID = this.Columns["ID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnBindingRequirementID = new DataColumn("BindingRequirementID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBindingRequirementID);
      this.columnStoredProcName = new DataColumn("StoredProcName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStoredProcName);
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnStoredProcName.MaxLength = 100;
      this.columnID.AutoIncrement = true;
      this.columnID.AutoIncrementSeed = -1L;
      this.columnID.AutoIncrementStep = -1L;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequirements.tblCompanyLineRequirementsAdminRow NewtblCompanyLineRequirementsAdminRow()
    {
      return (dsRequirements.tblCompanyLineRequirementsAdminRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRequirements.tblCompanyLineRequirementsAdminRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsRequirements.tblCompanyLineRequirementsAdminRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineRequirementsAdminRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRequirements.tblCompanyLineRequirementsAdminRowChangeEventHandler adminRowChangedEvent = this.tblCompanyLineRequirementsAdminRowChangedEvent;
      if (adminRowChangedEvent == null)
        return;
      adminRowChangedEvent((object) this, new dsRequirements.tblCompanyLineRequirementsAdminRowChangeEvent((dsRequirements.tblCompanyLineRequirementsAdminRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineRequirementsAdminRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRequirements.tblCompanyLineRequirementsAdminRowChangeEventHandler rowChangingEvent = this.tblCompanyLineRequirementsAdminRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRequirements.tblCompanyLineRequirementsAdminRowChangeEvent((dsRequirements.tblCompanyLineRequirementsAdminRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineRequirementsAdminRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRequirements.tblCompanyLineRequirementsAdminRowChangeEventHandler adminRowDeletedEvent = this.tblCompanyLineRequirementsAdminRowDeletedEvent;
      if (adminRowDeletedEvent == null)
        return;
      adminRowDeletedEvent((object) this, new dsRequirements.tblCompanyLineRequirementsAdminRowChangeEvent((dsRequirements.tblCompanyLineRequirementsAdminRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineRequirementsAdminRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRequirements.tblCompanyLineRequirementsAdminRowChangeEventHandler rowDeletingEvent = this.tblCompanyLineRequirementsAdminRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRequirements.tblCompanyLineRequirementsAdminRowChangeEvent((dsRequirements.tblCompanyLineRequirementsAdminRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyLineRequirementsAdminRow(
      dsRequirements.tblCompanyLineRequirementsAdminRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRequirements dsRequirements = new dsRequirements();
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
        FixedValue = dsRequirements.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLineRequirementsAdminDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRequirements.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstBindingRequirementsRowChangeEventHandler(
    object sender,
    dsRequirements.lstBindingRequirementsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblCompanyLineRequirementsAdminRowChangeEventHandler(
    object sender,
    dsRequirements.tblCompanyLineRequirementsAdminRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstBindingRequirementsDataTable : 
    TypedTableBase<dsRequirements.lstBindingRequirementsRow>
  {
    private DataColumn columnBindingRequirementID;
    private DataColumn columnBindingRequirement;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstBindingRequirementsDataTable()
    {
      this.TableName = "lstBindingRequirements";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstBindingRequirementsDataTable(DataTable table)
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
    protected lstBindingRequirementsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BindingRequirementIDColumn => this.columnBindingRequirementID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BindingRequirementColumn => this.columnBindingRequirement;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequirements.lstBindingRequirementsRow this[int index]
    {
      get => (dsRequirements.lstBindingRequirementsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequirements.lstBindingRequirementsRowChangeEventHandler lstBindingRequirementsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequirements.lstBindingRequirementsRowChangeEventHandler lstBindingRequirementsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequirements.lstBindingRequirementsRowChangeEventHandler lstBindingRequirementsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsRequirements.lstBindingRequirementsRowChangeEventHandler lstBindingRequirementsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstBindingRequirementsRow(dsRequirements.lstBindingRequirementsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequirements.lstBindingRequirementsRow AddlstBindingRequirementsRow(
      string BindingRequirement)
    {
      dsRequirements.lstBindingRequirementsRow row = (dsRequirements.lstBindingRequirementsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) BindingRequirement
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequirements.lstBindingRequirementsRow FindByBindingRequirementID(
      int BindingRequirementID)
    {
      return (dsRequirements.lstBindingRequirementsRow) this.Rows.Find(new object[1]
      {
        (object) BindingRequirementID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsRequirements.lstBindingRequirementsDataTable requirementsDataTable = (dsRequirements.lstBindingRequirementsDataTable) base.Clone();
      requirementsDataTable.InitVars();
      return (DataTable) requirementsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRequirements.lstBindingRequirementsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnBindingRequirementID = this.Columns["BindingRequirementID"];
      this.columnBindingRequirement = this.Columns["BindingRequirement"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnBindingRequirementID = new DataColumn("BindingRequirementID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBindingRequirementID);
      this.columnBindingRequirement = new DataColumn("BindingRequirement", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBindingRequirement);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnBindingRequirementID
      }, true));
      this.columnBindingRequirementID.AutoIncrement = true;
      this.columnBindingRequirementID.AllowDBNull = false;
      this.columnBindingRequirementID.ReadOnly = true;
      this.columnBindingRequirementID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequirements.lstBindingRequirementsRow NewlstBindingRequirementsRow()
    {
      return (dsRequirements.lstBindingRequirementsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRequirements.lstBindingRequirementsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsRequirements.lstBindingRequirementsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBindingRequirementsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRequirements.lstBindingRequirementsRowChangeEventHandler requirementsRowChangedEvent = this.lstBindingRequirementsRowChangedEvent;
      if (requirementsRowChangedEvent == null)
        return;
      requirementsRowChangedEvent((object) this, new dsRequirements.lstBindingRequirementsRowChangeEvent((dsRequirements.lstBindingRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBindingRequirementsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRequirements.lstBindingRequirementsRowChangeEventHandler rowChangingEvent = this.lstBindingRequirementsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRequirements.lstBindingRequirementsRowChangeEvent((dsRequirements.lstBindingRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBindingRequirementsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRequirements.lstBindingRequirementsRowChangeEventHandler requirementsRowDeletedEvent = this.lstBindingRequirementsRowDeletedEvent;
      if (requirementsRowDeletedEvent == null)
        return;
      requirementsRowDeletedEvent((object) this, new dsRequirements.lstBindingRequirementsRowChangeEvent((dsRequirements.lstBindingRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBindingRequirementsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRequirements.lstBindingRequirementsRowChangeEventHandler rowDeletingEvent = this.lstBindingRequirementsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRequirements.lstBindingRequirementsRowChangeEvent((dsRequirements.lstBindingRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstBindingRequirementsRow(dsRequirements.lstBindingRequirementsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsRequirements dsRequirements = new dsRequirements();
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
        FixedValue = dsRequirements.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstBindingRequirementsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsRequirements.GetSchemaSerializable();
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

  public class lstBindingRequirementsRow : DataRow
  {
    private dsRequirements.lstBindingRequirementsDataTable tablelstBindingRequirements;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstBindingRequirementsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstBindingRequirements = (dsRequirements.lstBindingRequirementsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int BindingRequirementID
    {
      get
      {
        return Conversions.ToInteger(this[this.tablelstBindingRequirements.BindingRequirementIDColumn]);
      }
      set => this[this.tablelstBindingRequirements.BindingRequirementIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BindingRequirement
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstBindingRequirements.BindingRequirementColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BindingRequirement' in table 'lstBindingRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstBindingRequirements.BindingRequirementColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBindingRequirementNull()
    {
      return this.IsNull(this.tablelstBindingRequirements.BindingRequirementColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBindingRequirementNull()
    {
      this[this.tablelstBindingRequirements.BindingRequirementColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblCompanyLineRequirementsAdminRow : DataRow
  {
    private dsRequirements.tblCompanyLineRequirementsAdminDataTable tabletblCompanyLineRequirementsAdmin;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLineRequirementsAdminRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLineRequirementsAdmin = (dsRequirements.tblCompanyLineRequirementsAdminDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int BindingRequirementID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineRequirementsAdmin.BindingRequirementIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BindingRequirementID' in table 'tblCompanyLineRequirementsAdmin' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineRequirementsAdmin.BindingRequirementIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StoredProcName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLineRequirementsAdmin.StoredProcNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StoredProcName' in table 'tblCompanyLineRequirementsAdmin' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineRequirementsAdmin.StoredProcNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyLineRequirementsAdmin.IDColumn]);
      set => this[this.tabletblCompanyLineRequirementsAdmin.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBindingRequirementIDNull()
    {
      return this.IsNull(this.tabletblCompanyLineRequirementsAdmin.BindingRequirementIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBindingRequirementIDNull()
    {
      this[this.tabletblCompanyLineRequirementsAdmin.BindingRequirementIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStoredProcNameNull()
    {
      return this.IsNull(this.tabletblCompanyLineRequirementsAdmin.StoredProcNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStoredProcNameNull()
    {
      this[this.tabletblCompanyLineRequirementsAdmin.StoredProcNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstBindingRequirementsRowChangeEvent : EventArgs
  {
    private dsRequirements.lstBindingRequirementsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstBindingRequirementsRowChangeEvent(
      dsRequirements.lstBindingRequirementsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequirements.lstBindingRequirementsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyLineRequirementsAdminRowChangeEvent : EventArgs
  {
    private dsRequirements.tblCompanyLineRequirementsAdminRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLineRequirementsAdminRowChangeEvent(
      dsRequirements.tblCompanyLineRequirementsAdminRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsRequirements.tblCompanyLineRequirementsAdminRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
