// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.dsProducerRequirements
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Producers;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsProducerRequirements")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsProducerRequirements : DataSet
{
  private dsProducerRequirements.lstProducerRequirementsDataTable tablelstProducerRequirements;
  private dsProducerRequirements.tblProducerRequirementsDataTable tabletblProducerRequirements;
  private dsProducerRequirements.tblProducerContactsDataTable tabletblProducerContacts;
  private dsProducerRequirements.tblUsersDataTable tabletblUsers;
  private DataRelation relationlstProducerRequirementstblProducerRequirements;
  private DataRelation relationtblUserstblProducerRequirements;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public dsProducerRequirements()
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
  protected dsProducerRequirements(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstProducerRequirements)] != null)
          base.Tables.Add((DataTable) new dsProducerRequirements.lstProducerRequirementsDataTable(dataSet.Tables[nameof (lstProducerRequirements)]));
        if (dataSet.Tables[nameof (tblProducerRequirements)] != null)
          base.Tables.Add((DataTable) new dsProducerRequirements.tblProducerRequirementsDataTable(dataSet.Tables[nameof (tblProducerRequirements)]));
        if (dataSet.Tables[nameof (tblProducerContacts)] != null)
          base.Tables.Add((DataTable) new dsProducerRequirements.tblProducerContactsDataTable(dataSet.Tables[nameof (tblProducerContacts)]));
        if (dataSet.Tables[nameof (tblUsers)] != null)
          base.Tables.Add((DataTable) new dsProducerRequirements.tblUsersDataTable(dataSet.Tables[nameof (tblUsers)]));
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
  public dsProducerRequirements.lstProducerRequirementsDataTable lstProducerRequirements
  {
    get => this.tablelstProducerRequirements;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducerRequirements.tblProducerRequirementsDataTable tblProducerRequirements
  {
    get => this.tabletblProducerRequirements;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducerRequirements.tblProducerContactsDataTable tblProducerContacts
  {
    get => this.tabletblProducerContacts;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducerRequirements.tblUsersDataTable tblUsers => this.tabletblUsers;

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
    dsProducerRequirements producerRequirements = (dsProducerRequirements) base.Clone();
    producerRequirements.InitVars();
    producerRequirements.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) producerRequirements;
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
      if (dataSet.Tables["lstProducerRequirements"] != null)
        base.Tables.Add((DataTable) new dsProducerRequirements.lstProducerRequirementsDataTable(dataSet.Tables["lstProducerRequirements"]));
      if (dataSet.Tables["tblProducerRequirements"] != null)
        base.Tables.Add((DataTable) new dsProducerRequirements.tblProducerRequirementsDataTable(dataSet.Tables["tblProducerRequirements"]));
      if (dataSet.Tables["tblProducerContacts"] != null)
        base.Tables.Add((DataTable) new dsProducerRequirements.tblProducerContactsDataTable(dataSet.Tables["tblProducerContacts"]));
      if (dataSet.Tables["tblUsers"] != null)
        base.Tables.Add((DataTable) new dsProducerRequirements.tblUsersDataTable(dataSet.Tables["tblUsers"]));
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
    this.tablelstProducerRequirements = (dsProducerRequirements.lstProducerRequirementsDataTable) base.Tables["lstProducerRequirements"];
    if (initTable && this.tablelstProducerRequirements != null)
      this.tablelstProducerRequirements.InitVars();
    this.tabletblProducerRequirements = (dsProducerRequirements.tblProducerRequirementsDataTable) base.Tables["tblProducerRequirements"];
    if (initTable && this.tabletblProducerRequirements != null)
      this.tabletblProducerRequirements.InitVars();
    this.tabletblProducerContacts = (dsProducerRequirements.tblProducerContactsDataTable) base.Tables["tblProducerContacts"];
    if (initTable && this.tabletblProducerContacts != null)
      this.tabletblProducerContacts.InitVars();
    this.tabletblUsers = (dsProducerRequirements.tblUsersDataTable) base.Tables["tblUsers"];
    if (initTable && this.tabletblUsers != null)
      this.tabletblUsers.InitVars();
    this.relationlstProducerRequirementstblProducerRequirements = this.Relations["lstProducerRequirementstblProducerRequirements"];
    this.relationtblUserstblProducerRequirements = this.Relations["tblUserstblProducerRequirements"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsProducerRequirements);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsProducerRequirements.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstProducerRequirements = new dsProducerRequirements.lstProducerRequirementsDataTable();
    base.Tables.Add((DataTable) this.tablelstProducerRequirements);
    this.tabletblProducerRequirements = new dsProducerRequirements.tblProducerRequirementsDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerRequirements);
    this.tabletblProducerContacts = new dsProducerRequirements.tblProducerContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerContacts);
    this.tabletblUsers = new dsProducerRequirements.tblUsersDataTable();
    base.Tables.Add((DataTable) this.tabletblUsers);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("lstProducerRequirementstblProducerRequirements", new DataColumn[1]
    {
      this.tablelstProducerRequirements.ProducerRequirementListIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerRequirements.ProducerRequirementListIDColumn
    });
    this.tabletblProducerRequirements.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("tblUserstblProducerRequirements", new DataColumn[1]
    {
      this.tabletblUsers.UserGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerRequirements.DiaryUserColumn
    });
    this.tabletblProducerRequirements.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    this.relationlstProducerRequirementstblProducerRequirements = new DataRelation("lstProducerRequirementstblProducerRequirements", new DataColumn[1]
    {
      this.tablelstProducerRequirements.ProducerRequirementListIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerRequirements.ProducerRequirementListIDColumn
    }, false);
    this.Relations.Add(this.relationlstProducerRequirementstblProducerRequirements);
    this.relationtblUserstblProducerRequirements = new DataRelation("tblUserstblProducerRequirements", new DataColumn[1]
    {
      this.tabletblUsers.UserGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerRequirements.DiaryUserColumn
    }, false);
    this.Relations.Add(this.relationtblUserstblProducerRequirements);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializelstProducerRequirements() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblProducerRequirements() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblProducerContacts() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblUsers() => false;

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
    dsProducerRequirements producerRequirements = new dsProducerRequirements();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = producerRequirements.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = producerRequirements.GetSchemaSerializable();
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
  public delegate void lstProducerRequirementsRowChangeEventHandler(
    object sender,
    dsProducerRequirements.lstProducerRequirementsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblProducerRequirementsRowChangeEventHandler(
    object sender,
    dsProducerRequirements.tblProducerRequirementsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblProducerContactsRowChangeEventHandler(
    object sender,
    dsProducerRequirements.tblProducerContactsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblUsersRowChangeEventHandler(
    object sender,
    dsProducerRequirements.tblUsersRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstProducerRequirementsDataTable : 
    TypedTableBase<dsProducerRequirements.lstProducerRequirementsRow>
  {
    private DataColumn columnProducerRequirementListID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public lstProducerRequirementsDataTable()
    {
      this.TableName = "lstProducerRequirements";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal lstProducerRequirementsDataTable(DataTable table)
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
    protected lstProducerRequirementsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerRequirementListIDColumn => this.columnProducerRequirementListID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.lstProducerRequirementsRow this[int index]
    {
      get => (dsProducerRequirements.lstProducerRequirementsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.lstProducerRequirementsRowChangeEventHandler lstProducerRequirementsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.lstProducerRequirementsRowChangeEventHandler lstProducerRequirementsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.lstProducerRequirementsRowChangeEventHandler lstProducerRequirementsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.lstProducerRequirementsRowChangeEventHandler lstProducerRequirementsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddlstProducerRequirementsRow(
      dsProducerRequirements.lstProducerRequirementsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.lstProducerRequirementsRow AddlstProducerRequirementsRow(
      string Description)
    {
      dsProducerRequirements.lstProducerRequirementsRow row = (dsProducerRequirements.lstProducerRequirementsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.lstProducerRequirementsRow FindByProducerRequirementListID(
      int ProducerRequirementListID)
    {
      return (dsProducerRequirements.lstProducerRequirementsRow) this.Rows.Find(new object[1]
      {
        (object) ProducerRequirementListID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerRequirements.lstProducerRequirementsDataTable requirementsDataTable = (dsProducerRequirements.lstProducerRequirementsDataTable) base.Clone();
      requirementsDataTable.InitVars();
      return (DataTable) requirementsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerRequirements.lstProducerRequirementsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerRequirementListID = this.Columns["ProducerRequirementListID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnProducerRequirementListID = new DataColumn("ProducerRequirementListID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerRequirementListID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducerRequirementsKey1", new DataColumn[1]
      {
        this.columnProducerRequirementListID
      }, true));
      this.columnProducerRequirementListID.AutoIncrement = true;
      this.columnProducerRequirementListID.AllowDBNull = false;
      this.columnProducerRequirementListID.ReadOnly = true;
      this.columnProducerRequirementListID.Unique = true;
      this.columnDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.lstProducerRequirementsRow NewlstProducerRequirementsRow()
    {
      return (dsProducerRequirements.lstProducerRequirementsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerRequirements.lstProducerRequirementsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsProducerRequirements.lstProducerRequirementsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerRequirementsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerRequirements.lstProducerRequirementsRowChangeEventHandler requirementsRowChangedEvent = this.lstProducerRequirementsRowChangedEvent;
      if (requirementsRowChangedEvent == null)
        return;
      requirementsRowChangedEvent((object) this, new dsProducerRequirements.lstProducerRequirementsRowChangeEvent((dsProducerRequirements.lstProducerRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerRequirementsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerRequirements.lstProducerRequirementsRowChangeEventHandler rowChangingEvent = this.lstProducerRequirementsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerRequirements.lstProducerRequirementsRowChangeEvent((dsProducerRequirements.lstProducerRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerRequirementsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerRequirements.lstProducerRequirementsRowChangeEventHandler requirementsRowDeletedEvent = this.lstProducerRequirementsRowDeletedEvent;
      if (requirementsRowDeletedEvent == null)
        return;
      requirementsRowDeletedEvent((object) this, new dsProducerRequirements.lstProducerRequirementsRowChangeEvent((dsProducerRequirements.lstProducerRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstProducerRequirementsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerRequirements.lstProducerRequirementsRowChangeEventHandler rowDeletingEvent = this.lstProducerRequirementsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerRequirements.lstProducerRequirementsRowChangeEvent((dsProducerRequirements.lstProducerRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovelstProducerRequirementsRow(
      dsProducerRequirements.lstProducerRequirementsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerRequirements producerRequirements = new dsProducerRequirements();
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
        FixedValue = producerRequirements.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstProducerRequirementsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerRequirements.GetSchemaSerializable();
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
  public class tblProducerRequirementsDataTable : 
    TypedTableBase<dsProducerRequirements.tblProducerRequirementsRow>
  {
    private DataColumn columnProducerRequirementsID;
    private DataColumn columnProducerLocationGUID;
    private DataColumn columnProducerContactGUID;
    private DataColumn columnProducerRequirementListID;
    private DataColumn columnValidThrough;
    private DataColumn columnCarrier;
    private DataColumn columnPolicyNo;
    private DataColumn columnPolicyLimit;
    private DataColumn columnOnFile;
    private DataColumn columnDiaryUser;
    private DataColumn columnSignedAsOf;
    private DataColumn columnProducerGUID;
    private DataColumn columnName1099;
    private DataColumn columnNum1099;
    private DataColumn columnNeededToBind;
    private DataColumn columnNeededToClear;
    private DataColumn columnNeededToQuote;
    private DataColumn columnNeededToIssue;
    private DataColumn columnEOPremium;
    private DataColumn columnNumDays;
    private DataColumn columnAggregateLimit;
    private DataColumn columnDeductible;
    private DataColumn columnDocumentRequestedOn;
    private DataColumn columnRightSignatureRefNum;
    private DataColumn columnPromptOnQuote;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblProducerRequirementsDataTable()
    {
      this.TableName = "tblProducerRequirements";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblProducerRequirementsDataTable(DataTable table)
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
    protected tblProducerRequirementsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerRequirementsIDColumn => this.columnProducerRequirementsID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerLocationGUIDColumn => this.columnProducerLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerContactGUIDColumn => this.columnProducerContactGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerRequirementListIDColumn => this.columnProducerRequirementListID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ValidThroughColumn => this.columnValidThrough;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CarrierColumn => this.columnCarrier;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PolicyNoColumn => this.columnPolicyNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PolicyLimitColumn => this.columnPolicyLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn OnFileColumn => this.columnOnFile;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DiaryUserColumn => this.columnDiaryUser;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn SignedAsOfColumn => this.columnSignedAsOf;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerGUIDColumn => this.columnProducerGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Name1099Column => this.columnName1099;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn Num1099Column => this.columnNum1099;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn NeededToBindColumn => this.columnNeededToBind;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn NeededToClearColumn => this.columnNeededToClear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn NeededToQuoteColumn => this.columnNeededToQuote;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn NeededToIssueColumn => this.columnNeededToIssue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn EOPremiumColumn => this.columnEOPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn NumDaysColumn => this.columnNumDays;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AggregateLimitColumn => this.columnAggregateLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DeductibleColumn => this.columnDeductible;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DocumentRequestedOnColumn => this.columnDocumentRequestedOn;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn RightSignatureRefNumColumn => this.columnRightSignatureRefNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PromptOnQuoteColumn => this.columnPromptOnQuote;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblProducerRequirementsRow this[int index]
    {
      get => (dsProducerRequirements.tblProducerRequirementsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.tblProducerRequirementsRowChangeEventHandler tblProducerRequirementsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.tblProducerRequirementsRowChangeEventHandler tblProducerRequirementsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.tblProducerRequirementsRowChangeEventHandler tblProducerRequirementsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.tblProducerRequirementsRowChangeEventHandler tblProducerRequirementsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblProducerRequirementsRow(
      dsProducerRequirements.tblProducerRequirementsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblProducerRequirementsRow AddtblProducerRequirementsRow(
      Guid ProducerLocationGUID,
      Guid ProducerContactGUID,
      dsProducerRequirements.lstProducerRequirementsRow parentlstProducerRequirementsRowBylstProducerRequirementstblProducerRequirements,
      DateTime ValidThrough,
      string Carrier,
      string PolicyNo,
      int PolicyLimit,
      bool OnFile,
      dsProducerRequirements.tblUsersRow parenttblUsersRowBytblUserstblProducerRequirements,
      DateTime SignedAsOf,
      Guid ProducerGUID,
      string Name1099,
      string Num1099,
      bool NeededToBind,
      bool NeededToClear,
      bool NeededToQuote,
      bool NeededToIssue,
      Decimal EOPremium,
      short NumDays,
      Decimal AggregateLimit,
      Decimal Deductible,
      DateTime DocumentRequestedOn,
      string RightSignatureRefNum,
      bool PromptOnQuote)
    {
      dsProducerRequirements.tblProducerRequirementsRow row = (dsProducerRequirements.tblProducerRequirementsRow) this.NewRow();
      object[] objArray = new object[25]
      {
        null,
        (object) ProducerLocationGUID,
        (object) ProducerContactGUID,
        null,
        (object) ValidThrough,
        (object) Carrier,
        (object) PolicyNo,
        (object) PolicyLimit,
        (object) OnFile,
        null,
        (object) SignedAsOf,
        (object) ProducerGUID,
        (object) Name1099,
        (object) Num1099,
        (object) NeededToBind,
        (object) NeededToClear,
        (object) NeededToQuote,
        (object) NeededToIssue,
        (object) EOPremium,
        (object) NumDays,
        (object) AggregateLimit,
        (object) Deductible,
        (object) DocumentRequestedOn,
        (object) RightSignatureRefNum,
        (object) PromptOnQuote
      };
      if (parentlstProducerRequirementsRowBylstProducerRequirementstblProducerRequirements != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parentlstProducerRequirementsRowBylstProducerRequirementstblProducerRequirements[0]);
      if (parenttblUsersRowBytblUserstblProducerRequirements != null)
        objArray[9] = RuntimeHelpers.GetObjectValue(parenttblUsersRowBytblUserstblProducerRequirements[1]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblProducerRequirementsRow FindByProducerRequirementsID(
      int ProducerRequirementsID)
    {
      return (dsProducerRequirements.tblProducerRequirementsRow) this.Rows.Find(new object[1]
      {
        (object) ProducerRequirementsID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerRequirements.tblProducerRequirementsDataTable requirementsDataTable = (dsProducerRequirements.tblProducerRequirementsDataTable) base.Clone();
      requirementsDataTable.InitVars();
      return (DataTable) requirementsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerRequirements.tblProducerRequirementsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerRequirementsID = this.Columns["ProducerRequirementsID"];
      this.columnProducerLocationGUID = this.Columns["ProducerLocationGUID"];
      this.columnProducerContactGUID = this.Columns["ProducerContactGUID"];
      this.columnProducerRequirementListID = this.Columns["ProducerRequirementListID"];
      this.columnValidThrough = this.Columns["ValidThrough"];
      this.columnCarrier = this.Columns["Carrier"];
      this.columnPolicyNo = this.Columns["PolicyNo"];
      this.columnPolicyLimit = this.Columns["PolicyLimit"];
      this.columnOnFile = this.Columns["OnFile"];
      this.columnDiaryUser = this.Columns["DiaryUser"];
      this.columnSignedAsOf = this.Columns["SignedAsOf"];
      this.columnProducerGUID = this.Columns["ProducerGUID"];
      this.columnName1099 = this.Columns["Name1099"];
      this.columnNum1099 = this.Columns["Num1099"];
      this.columnNeededToBind = this.Columns["NeededToBind"];
      this.columnNeededToClear = this.Columns["NeededToClear"];
      this.columnNeededToQuote = this.Columns["NeededToQuote"];
      this.columnNeededToIssue = this.Columns["NeededToIssue"];
      this.columnEOPremium = this.Columns["EOPremium"];
      this.columnNumDays = this.Columns["NumDays"];
      this.columnAggregateLimit = this.Columns["AggregateLimit"];
      this.columnDeductible = this.Columns["Deductible"];
      this.columnDocumentRequestedOn = this.Columns["DocumentRequestedOn"];
      this.columnRightSignatureRefNum = this.Columns["RightSignatureRefNum"];
      this.columnPromptOnQuote = this.Columns["PromptOnQuote"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnProducerRequirementsID = new DataColumn("ProducerRequirementsID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerRequirementsID);
      this.columnProducerLocationGUID = new DataColumn("ProducerLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGUID);
      this.columnProducerContactGUID = new DataColumn("ProducerContactGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContactGUID);
      this.columnProducerRequirementListID = new DataColumn("ProducerRequirementListID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerRequirementListID);
      this.columnValidThrough = new DataColumn("ValidThrough", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnValidThrough);
      this.columnCarrier = new DataColumn("Carrier", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCarrier);
      this.columnPolicyNo = new DataColumn("PolicyNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNo);
      this.columnPolicyLimit = new DataColumn("PolicyLimit", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyLimit);
      this.columnOnFile = new DataColumn("OnFile", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOnFile);
      this.columnDiaryUser = new DataColumn("DiaryUser", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDiaryUser);
      this.columnSignedAsOf = new DataColumn("SignedAsOf", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSignedAsOf);
      this.columnProducerGUID = new DataColumn("ProducerGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerGUID);
      this.columnName1099 = new DataColumn("Name1099", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName1099);
      this.columnNum1099 = new DataColumn("Num1099", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNum1099);
      this.columnNeededToBind = new DataColumn("NeededToBind", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNeededToBind);
      this.columnNeededToClear = new DataColumn("NeededToClear", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNeededToClear);
      this.columnNeededToQuote = new DataColumn("NeededToQuote", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNeededToQuote);
      this.columnNeededToIssue = new DataColumn("NeededToIssue", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNeededToIssue);
      this.columnEOPremium = new DataColumn("EOPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEOPremium);
      this.columnNumDays = new DataColumn("NumDays", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumDays);
      this.columnAggregateLimit = new DataColumn("AggregateLimit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAggregateLimit);
      this.columnDeductible = new DataColumn("Deductible", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductible);
      this.columnDocumentRequestedOn = new DataColumn("DocumentRequestedOn", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDocumentRequestedOn);
      this.columnRightSignatureRefNum = new DataColumn("RightSignatureRefNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRightSignatureRefNum);
      this.columnPromptOnQuote = new DataColumn("PromptOnQuote", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPromptOnQuote);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducerRequirementsKey2", new DataColumn[1]
      {
        this.columnProducerRequirementsID
      }, true));
      this.columnProducerRequirementsID.AutoIncrement = true;
      this.columnProducerRequirementsID.AllowDBNull = false;
      this.columnProducerRequirementsID.ReadOnly = true;
      this.columnProducerRequirementsID.Unique = true;
      this.columnOnFile.AllowDBNull = false;
      this.columnOnFile.DefaultValue = (object) false;
      this.columnNeededToBind.AllowDBNull = false;
      this.columnNeededToBind.DefaultValue = (object) false;
      this.columnNeededToClear.AllowDBNull = false;
      this.columnNeededToClear.DefaultValue = (object) false;
      this.columnNeededToQuote.AllowDBNull = false;
      this.columnNeededToQuote.DefaultValue = (object) false;
      this.columnNeededToIssue.AllowDBNull = false;
      this.columnNeededToIssue.DefaultValue = (object) false;
      this.columnPromptOnQuote.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblProducerRequirementsRow NewtblProducerRequirementsRow()
    {
      return (dsProducerRequirements.tblProducerRequirementsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerRequirements.tblProducerRequirementsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsProducerRequirements.tblProducerRequirementsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerRequirementsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerRequirements.tblProducerRequirementsRowChangeEventHandler requirementsRowChangedEvent = this.tblProducerRequirementsRowChangedEvent;
      if (requirementsRowChangedEvent == null)
        return;
      requirementsRowChangedEvent((object) this, new dsProducerRequirements.tblProducerRequirementsRowChangeEvent((dsProducerRequirements.tblProducerRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerRequirementsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerRequirements.tblProducerRequirementsRowChangeEventHandler rowChangingEvent = this.tblProducerRequirementsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerRequirements.tblProducerRequirementsRowChangeEvent((dsProducerRequirements.tblProducerRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerRequirementsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerRequirements.tblProducerRequirementsRowChangeEventHandler requirementsRowDeletedEvent = this.tblProducerRequirementsRowDeletedEvent;
      if (requirementsRowDeletedEvent == null)
        return;
      requirementsRowDeletedEvent((object) this, new dsProducerRequirements.tblProducerRequirementsRowChangeEvent((dsProducerRequirements.tblProducerRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerRequirementsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerRequirements.tblProducerRequirementsRowChangeEventHandler rowDeletingEvent = this.tblProducerRequirementsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerRequirements.tblProducerRequirementsRowChangeEvent((dsProducerRequirements.tblProducerRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblProducerRequirementsRow(
      dsProducerRequirements.tblProducerRequirementsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerRequirements producerRequirements = new dsProducerRequirements();
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
        FixedValue = producerRequirements.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerRequirementsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerRequirements.GetSchemaSerializable();
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
  public class tblProducerContactsDataTable : 
    TypedTableBase<dsProducerRequirements.tblProducerContactsRow>
  {
    private DataColumn columnProducerContactGUID;
    private DataColumn columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblProducerContactsDataTable()
    {
      this.TableName = "tblProducerContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblProducerContactsDataTable(DataTable table)
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
    protected tblProducerContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerContactGUIDColumn => this.columnProducerContactGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblProducerContactsRow this[int index]
    {
      get => (dsProducerRequirements.tblProducerContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.tblProducerContactsRowChangeEventHandler tblProducerContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.tblProducerContactsRowChangeEventHandler tblProducerContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.tblProducerContactsRowChangeEventHandler tblProducerContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.tblProducerContactsRowChangeEventHandler tblProducerContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblProducerContactsRow(dsProducerRequirements.tblProducerContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblProducerContactsRow AddtblProducerContactsRow(
      Guid ProducerContactGUID,
      string Name)
    {
      dsProducerRequirements.tblProducerContactsRow row = (dsProducerRequirements.tblProducerContactsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ProducerContactGUID,
        (object) Name
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerRequirements.tblProducerContactsDataTable contactsDataTable = (dsProducerRequirements.tblProducerContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerRequirements.tblProducerContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerContactGUID = this.Columns["ProducerContactGUID"];
      this.columnName = this.Columns["Name"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnProducerContactGUID = new DataColumn("ProducerContactGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContactGUID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblProducerContactsRow NewtblProducerContactsRow()
    {
      return (dsProducerRequirements.tblProducerContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerRequirements.tblProducerContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducerRequirements.tblProducerContactsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerRequirements.tblProducerContactsRowChangeEventHandler contactsRowChangedEvent = this.tblProducerContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsProducerRequirements.tblProducerContactsRowChangeEvent((dsProducerRequirements.tblProducerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerRequirements.tblProducerContactsRowChangeEventHandler rowChangingEvent = this.tblProducerContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerRequirements.tblProducerContactsRowChangeEvent((dsProducerRequirements.tblProducerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerRequirements.tblProducerContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblProducerContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsProducerRequirements.tblProducerContactsRowChangeEvent((dsProducerRequirements.tblProducerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerRequirements.tblProducerContactsRowChangeEventHandler rowDeletingEvent = this.tblProducerContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerRequirements.tblProducerContactsRowChangeEvent((dsProducerRequirements.tblProducerContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblProducerContactsRow(dsProducerRequirements.tblProducerContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerRequirements producerRequirements = new dsProducerRequirements();
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
        FixedValue = producerRequirements.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerRequirements.GetSchemaSerializable();
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
  public class tblUsersDataTable : TypedTableBase<dsProducerRequirements.tblUsersRow>
  {
    private DataColumn columnUserName;
    private DataColumn columnUserGuid;

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
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn UserGuidColumn => this.columnUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblUsersRow this[int index]
    {
      get => (dsProducerRequirements.tblUsersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.tblUsersRowChangeEventHandler tblUsersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.tblUsersRowChangeEventHandler tblUsersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.tblUsersRowChangeEventHandler tblUsersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsProducerRequirements.tblUsersRowChangeEventHandler tblUsersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblUsersRow(dsProducerRequirements.tblUsersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblUsersRow AddtblUsersRow(string UserName, Guid UserGuid)
    {
      dsProducerRequirements.tblUsersRow row = (dsProducerRequirements.tblUsersRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) UserName,
        (object) UserGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerRequirements.tblUsersDataTable tblUsersDataTable = (dsProducerRequirements.tblUsersDataTable) base.Clone();
      tblUsersDataTable.InitVars();
      return (DataTable) tblUsersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerRequirements.tblUsersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnUserName = this.Columns["UserName"];
      this.columnUserGuid = this.Columns["UserGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.columnUserGuid = new DataColumn("UserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducerRequirementsKey3", new DataColumn[1]
      {
        this.columnUserGuid
      }, false));
      this.columnUserGuid.AllowDBNull = false;
      this.columnUserGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblUsersRow NewtblUsersRow()
    {
      return (dsProducerRequirements.tblUsersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerRequirements.tblUsersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducerRequirements.tblUsersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUsersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerRequirements.tblUsersRowChangeEventHandler usersRowChangedEvent = this.tblUsersRowChangedEvent;
      if (usersRowChangedEvent == null)
        return;
      usersRowChangedEvent((object) this, new dsProducerRequirements.tblUsersRowChangeEvent((dsProducerRequirements.tblUsersRow) e.Row, e.Action));
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
      dsProducerRequirements.tblUsersRowChangeEventHandler rowChangingEvent = this.tblUsersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerRequirements.tblUsersRowChangeEvent((dsProducerRequirements.tblUsersRow) e.Row, e.Action));
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
      dsProducerRequirements.tblUsersRowChangeEventHandler usersRowDeletedEvent = this.tblUsersRowDeletedEvent;
      if (usersRowDeletedEvent == null)
        return;
      usersRowDeletedEvent((object) this, new dsProducerRequirements.tblUsersRowChangeEvent((dsProducerRequirements.tblUsersRow) e.Row, e.Action));
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
      dsProducerRequirements.tblUsersRowChangeEventHandler rowDeletingEvent = this.tblUsersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerRequirements.tblUsersRowChangeEvent((dsProducerRequirements.tblUsersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblUsersRow(dsProducerRequirements.tblUsersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerRequirements producerRequirements = new dsProducerRequirements();
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
        FixedValue = producerRequirements.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUsersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerRequirements.GetSchemaSerializable();
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

  public class lstProducerRequirementsRow : DataRow
  {
    private dsProducerRequirements.lstProducerRequirementsDataTable tablelstProducerRequirements;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal lstProducerRequirementsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstProducerRequirements = (dsProducerRequirements.lstProducerRequirementsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ProducerRequirementListID
    {
      get
      {
        return Conversions.ToInteger(this[this.tablelstProducerRequirements.ProducerRequirementListIDColumn]);
      }
      set
      {
        this[this.tablelstProducerRequirements.ProducerRequirementListIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstProducerRequirements.DescriptionColumn]);
      set => this[this.tablelstProducerRequirements.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblProducerRequirementsRow[] GettblProducerRequirementsRows()
    {
      return this.Table.ChildRelations["lstProducerRequirementstblProducerRequirements"] != null ? (dsProducerRequirements.tblProducerRequirementsRow[]) this.GetChildRows(this.Table.ChildRelations["lstProducerRequirementstblProducerRequirements"]) : new dsProducerRequirements.tblProducerRequirementsRow[0];
    }
  }

  public class tblProducerRequirementsRow : DataRow
  {
    private dsProducerRequirements.tblProducerRequirementsDataTable tabletblProducerRequirements;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblProducerRequirementsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerRequirements = (dsProducerRequirements.tblProducerRequirementsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ProducerRequirementsID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblProducerRequirements.ProducerRequirementsIDColumn]);
      }
      set => this[this.tabletblProducerRequirements.ProducerRequirementsIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid ProducerLocationGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducerRequirements.ProducerLocationGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationGUID' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.ProducerLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid ProducerContactGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducerRequirements.ProducerContactGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerContactGUID' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.ProducerContactGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int ProducerRequirementListID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerRequirements.ProducerRequirementListIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerRequirementListID' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblProducerRequirements.ProducerRequirementListIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime ValidThrough
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblProducerRequirements.ValidThroughColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ValidThrough' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.ValidThroughColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Carrier
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerRequirements.CarrierColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Carrier' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.CarrierColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PolicyNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerRequirements.PolicyNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNo' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.PolicyNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int PolicyLimit
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblProducerRequirements.PolicyLimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyLimit' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.PolicyLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool OnFile
    {
      get => Conversions.ToBoolean(this[this.tabletblProducerRequirements.OnFileColumn]);
      set => this[this.tabletblProducerRequirements.OnFileColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid DiaryUser
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducerRequirements.DiaryUserColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DiaryUser' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.DiaryUserColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime SignedAsOf
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblProducerRequirements.SignedAsOfColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SignedAsOf' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.SignedAsOfColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid ProducerGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducerRequirements.ProducerGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerGUID' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.ProducerGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Name1099
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerRequirements.Name1099Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name1099' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.Name1099Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Num1099
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerRequirements.Num1099Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Num1099' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.Num1099Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool NeededToBind
    {
      get => Conversions.ToBoolean(this[this.tabletblProducerRequirements.NeededToBindColumn]);
      set => this[this.tabletblProducerRequirements.NeededToBindColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool NeededToClear
    {
      get => Conversions.ToBoolean(this[this.tabletblProducerRequirements.NeededToClearColumn]);
      set => this[this.tabletblProducerRequirements.NeededToClearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool NeededToQuote
    {
      get => Conversions.ToBoolean(this[this.tabletblProducerRequirements.NeededToQuoteColumn]);
      set => this[this.tabletblProducerRequirements.NeededToQuoteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool NeededToIssue
    {
      get => Conversions.ToBoolean(this[this.tabletblProducerRequirements.NeededToIssueColumn]);
      set => this[this.tabletblProducerRequirements.NeededToIssueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal EOPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblProducerRequirements.EOPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EOPremium' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.EOPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public short NumDays
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblProducerRequirements.NumDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumDays' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.NumDaysColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal AggregateLimit
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblProducerRequirements.AggregateLimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AggregateLimit' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.AggregateLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal Deductible
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblProducerRequirements.DeductibleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Deductible' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.DeductibleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime DocumentRequestedOn
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblProducerRequirements.DocumentRequestedOnColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DocumentRequestedOn' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.DocumentRequestedOnColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string RightSignatureRefNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblProducerRequirements.RightSignatureRefNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RightSignatureRefNum' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.RightSignatureRefNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool PromptOnQuote
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblProducerRequirements.PromptOnQuoteColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PromptOnQuote' in table 'tblProducerRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerRequirements.PromptOnQuoteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.lstProducerRequirementsRow lstProducerRequirementsRow
    {
      get
      {
        return (dsProducerRequirements.lstProducerRequirementsRow) this.GetParentRow(this.Table.ParentRelations["lstProducerRequirementstblProducerRequirements"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstProducerRequirementstblProducerRequirements"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblUsersRow tblUsersRow
    {
      get
      {
        return (dsProducerRequirements.tblUsersRow) this.GetParentRow(this.Table.ParentRelations["tblUserstblProducerRequirements"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblUserstblProducerRequirements"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsProducerLocationGUIDNull()
    {
      return this.IsNull(this.tabletblProducerRequirements.ProducerLocationGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetProducerLocationGUIDNull()
    {
      this[this.tabletblProducerRequirements.ProducerLocationGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsProducerContactGUIDNull()
    {
      return this.IsNull(this.tabletblProducerRequirements.ProducerContactGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetProducerContactGUIDNull()
    {
      this[this.tabletblProducerRequirements.ProducerContactGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsProducerRequirementListIDNull()
    {
      return this.IsNull(this.tabletblProducerRequirements.ProducerRequirementListIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetProducerRequirementListIDNull()
    {
      this[this.tabletblProducerRequirements.ProducerRequirementListIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsValidThroughNull()
    {
      return this.IsNull(this.tabletblProducerRequirements.ValidThroughColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetValidThroughNull()
    {
      this[this.tabletblProducerRequirements.ValidThroughColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCarrierNull() => this.IsNull(this.tabletblProducerRequirements.CarrierColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCarrierNull()
    {
      this[this.tabletblProducerRequirements.CarrierColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPolicyNoNull() => this.IsNull(this.tabletblProducerRequirements.PolicyNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPolicyNoNull()
    {
      this[this.tabletblProducerRequirements.PolicyNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPolicyLimitNull()
    {
      return this.IsNull(this.tabletblProducerRequirements.PolicyLimitColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPolicyLimitNull()
    {
      this[this.tabletblProducerRequirements.PolicyLimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDiaryUserNull() => this.IsNull(this.tabletblProducerRequirements.DiaryUserColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDiaryUserNull()
    {
      this[this.tabletblProducerRequirements.DiaryUserColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsSignedAsOfNull()
    {
      return this.IsNull(this.tabletblProducerRequirements.SignedAsOfColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetSignedAsOfNull()
    {
      this[this.tabletblProducerRequirements.SignedAsOfColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsProducerGUIDNull()
    {
      return this.IsNull(this.tabletblProducerRequirements.ProducerGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetProducerGUIDNull()
    {
      this[this.tabletblProducerRequirements.ProducerGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsName1099Null() => this.IsNull(this.tabletblProducerRequirements.Name1099Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetName1099Null()
    {
      this[this.tabletblProducerRequirements.Name1099Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsNum1099Null() => this.IsNull(this.tabletblProducerRequirements.Num1099Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetNum1099Null()
    {
      this[this.tabletblProducerRequirements.Num1099Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsEOPremiumNull() => this.IsNull(this.tabletblProducerRequirements.EOPremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetEOPremiumNull()
    {
      this[this.tabletblProducerRequirements.EOPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsNumDaysNull() => this.IsNull(this.tabletblProducerRequirements.NumDaysColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetNumDaysNull()
    {
      this[this.tabletblProducerRequirements.NumDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAggregateLimitNull()
    {
      return this.IsNull(this.tabletblProducerRequirements.AggregateLimitColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAggregateLimitNull()
    {
      this[this.tabletblProducerRequirements.AggregateLimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDeductibleNull()
    {
      return this.IsNull(this.tabletblProducerRequirements.DeductibleColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDeductibleNull()
    {
      this[this.tabletblProducerRequirements.DeductibleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDocumentRequestedOnNull()
    {
      return this.IsNull(this.tabletblProducerRequirements.DocumentRequestedOnColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDocumentRequestedOnNull()
    {
      this[this.tabletblProducerRequirements.DocumentRequestedOnColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsRightSignatureRefNumNull()
    {
      return this.IsNull(this.tabletblProducerRequirements.RightSignatureRefNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetRightSignatureRefNumNull()
    {
      this[this.tabletblProducerRequirements.RightSignatureRefNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPromptOnQuoteNull()
    {
      return this.IsNull(this.tabletblProducerRequirements.PromptOnQuoteColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPromptOnQuoteNull()
    {
      this[this.tabletblProducerRequirements.PromptOnQuoteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblProducerContactsRow : DataRow
  {
    private dsProducerRequirements.tblProducerContactsDataTable tabletblProducerContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblProducerContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerContacts = (dsProducerRequirements.tblProducerContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid ProducerContactGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblProducerContacts.ProducerContactGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerContactGUID' in table 'tblProducerContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblProducerContacts.ProducerContactGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Name
    {
      get => Conversions.ToString(this[this.tabletblProducerContacts.NameColumn]);
      set => this[this.tabletblProducerContacts.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsProducerContactGUIDNull()
    {
      return this.IsNull(this.tabletblProducerContacts.ProducerContactGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetProducerContactGUIDNull()
    {
      this[this.tabletblProducerContacts.ProducerContactGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblUsersRow : DataRow
  {
    private dsProducerRequirements.tblUsersDataTable tabletblUsers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblUsersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUsers = (dsProducerRequirements.tblUsersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string UserName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUsers.UserNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserName' in table 'tblUsers' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUsers.UserNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Guid UserGuid
    {
      get
      {
        object obj = this[this.tabletblUsers.UserGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblUsers.UserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsUserNameNull() => this.IsNull(this.tabletblUsers.UserNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetUserNameNull()
    {
      this[this.tabletblUsers.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblProducerRequirementsRow[] GettblProducerRequirementsRows()
    {
      return this.Table.ChildRelations["tblUserstblProducerRequirements"] != null ? (dsProducerRequirements.tblProducerRequirementsRow[]) this.GetChildRows(this.Table.ChildRelations["tblUserstblProducerRequirements"]) : new dsProducerRequirements.tblProducerRequirementsRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class lstProducerRequirementsRowChangeEvent : EventArgs
  {
    private dsProducerRequirements.lstProducerRequirementsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public lstProducerRequirementsRowChangeEvent(
      dsProducerRequirements.lstProducerRequirementsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.lstProducerRequirementsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblProducerRequirementsRowChangeEvent : EventArgs
  {
    private dsProducerRequirements.tblProducerRequirementsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblProducerRequirementsRowChangeEvent(
      dsProducerRequirements.tblProducerRequirementsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblProducerRequirementsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblProducerContactsRowChangeEvent : EventArgs
  {
    private dsProducerRequirements.tblProducerContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblProducerContactsRowChangeEvent(
      dsProducerRequirements.tblProducerContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblProducerContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblUsersRowChangeEvent : EventArgs
  {
    private dsProducerRequirements.tblUsersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblUsersRowChangeEvent(dsProducerRequirements.tblUsersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsProducerRequirements.tblUsersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
