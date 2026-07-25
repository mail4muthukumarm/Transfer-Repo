// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.dsCompanyLineBindingRequirements
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCompanyLineBindingRequirements")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyLineBindingRequirements : DataSet
{
  private dsCompanyLineBindingRequirements.lstBindingRequirementsDataTable tablelstBindingRequirements;
  private dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsDataTable tabletblCompanyLineBindingRequirements;
  private dsCompanyLineBindingRequirements.lstQuoteStatusDataTable tablelstQuoteStatus;
  private DataRelation relationlstBindingRequirementstblCompanyLineBindingRequirements;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsCompanyLineBindingRequirements()
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
  protected dsCompanyLineBindingRequirements(SerializationInfo info, StreamingContext context)
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
          base.Tables.Add((DataTable) new dsCompanyLineBindingRequirements.lstBindingRequirementsDataTable(dataSet.Tables[nameof (lstBindingRequirements)]));
        if (dataSet.Tables[nameof (tblCompanyLineBindingRequirements)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsDataTable(dataSet.Tables[nameof (tblCompanyLineBindingRequirements)]));
        if (dataSet.Tables[nameof (lstQuoteStatus)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineBindingRequirements.lstQuoteStatusDataTable(dataSet.Tables[nameof (lstQuoteStatus)]));
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
  public dsCompanyLineBindingRequirements.lstBindingRequirementsDataTable lstBindingRequirements
  {
    get => this.tablelstBindingRequirements;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsDataTable tblCompanyLineBindingRequirements
  {
    get => this.tabletblCompanyLineBindingRequirements;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyLineBindingRequirements.lstQuoteStatusDataTable lstQuoteStatus
  {
    get => this.tablelstQuoteStatus;
  }

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
    dsCompanyLineBindingRequirements bindingRequirements = (dsCompanyLineBindingRequirements) base.Clone();
    bindingRequirements.InitVars();
    bindingRequirements.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) bindingRequirements;
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
      if (dataSet.Tables["lstBindingRequirements"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineBindingRequirements.lstBindingRequirementsDataTable(dataSet.Tables["lstBindingRequirements"]));
      if (dataSet.Tables["tblCompanyLineBindingRequirements"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsDataTable(dataSet.Tables["tblCompanyLineBindingRequirements"]));
      if (dataSet.Tables["lstQuoteStatus"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineBindingRequirements.lstQuoteStatusDataTable(dataSet.Tables["lstQuoteStatus"]));
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
    this.tablelstBindingRequirements = (dsCompanyLineBindingRequirements.lstBindingRequirementsDataTable) base.Tables["lstBindingRequirements"];
    if (initTable && this.tablelstBindingRequirements != null)
      this.tablelstBindingRequirements.InitVars();
    this.tabletblCompanyLineBindingRequirements = (dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsDataTable) base.Tables["tblCompanyLineBindingRequirements"];
    if (initTable && this.tabletblCompanyLineBindingRequirements != null)
      this.tabletblCompanyLineBindingRequirements.InitVars();
    this.tablelstQuoteStatus = (dsCompanyLineBindingRequirements.lstQuoteStatusDataTable) base.Tables["lstQuoteStatus"];
    if (initTable && this.tablelstQuoteStatus != null)
      this.tablelstQuoteStatus.InitVars();
    this.relationlstBindingRequirementstblCompanyLineBindingRequirements = this.Relations["lstBindingRequirementstblCompanyLineBindingRequirements"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyLineBindingRequirements);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCompanyLineBindingRequirements.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstBindingRequirements = new dsCompanyLineBindingRequirements.lstBindingRequirementsDataTable();
    base.Tables.Add((DataTable) this.tablelstBindingRequirements);
    this.tabletblCompanyLineBindingRequirements = new dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLineBindingRequirements);
    this.tablelstQuoteStatus = new dsCompanyLineBindingRequirements.lstQuoteStatusDataTable();
    base.Tables.Add((DataTable) this.tablelstQuoteStatus);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("lstBindingRequirementstblCompanyLineBindingRequirements", new DataColumn[1]
    {
      this.tablelstBindingRequirements.BindingRequirementIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLineBindingRequirements.BindingRequirementIDColumn
    });
    this.tabletblCompanyLineBindingRequirements.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationlstBindingRequirementstblCompanyLineBindingRequirements = new DataRelation("lstBindingRequirementstblCompanyLineBindingRequirements", new DataColumn[1]
    {
      this.tablelstBindingRequirements.BindingRequirementIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLineBindingRequirements.BindingRequirementIDColumn
    }, false);
    this.Relations.Add(this.relationlstBindingRequirementstblCompanyLineBindingRequirements);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstBindingRequirements() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanyLineBindingRequirements() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstQuoteStatus() => false;

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
    dsCompanyLineBindingRequirements bindingRequirements = new dsCompanyLineBindingRequirements();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = bindingRequirements.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = bindingRequirements.GetSchemaSerializable();
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
  public delegate void lstBindingRequirementsRowChangeEventHandler(
    object sender,
    dsCompanyLineBindingRequirements.lstBindingRequirementsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblCompanyLineBindingRequirementsRowChangeEventHandler(
    object sender,
    dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstQuoteStatusRowChangeEventHandler(
    object sender,
    dsCompanyLineBindingRequirements.lstQuoteStatusRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstBindingRequirementsDataTable : 
    TypedTableBase<dsCompanyLineBindingRequirements.lstBindingRequirementsRow>
  {
    private DataColumn columnBindingRequirementID;
    private DataColumn columnBindingRequirement;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstBindingRequirementsDataTable()
    {
      this.TableName = "lstBindingRequirements";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected lstBindingRequirementsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BindingRequirementIDColumn => this.columnBindingRequirementID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BindingRequirementColumn => this.columnBindingRequirement;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.lstBindingRequirementsRow this[int index]
    {
      get => (dsCompanyLineBindingRequirements.lstBindingRequirementsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLineBindingRequirements.lstBindingRequirementsRowChangeEventHandler lstBindingRequirementsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLineBindingRequirements.lstBindingRequirementsRowChangeEventHandler lstBindingRequirementsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLineBindingRequirements.lstBindingRequirementsRowChangeEventHandler lstBindingRequirementsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLineBindingRequirements.lstBindingRequirementsRowChangeEventHandler lstBindingRequirementsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstBindingRequirementsRow(
      dsCompanyLineBindingRequirements.lstBindingRequirementsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.lstBindingRequirementsRow AddlstBindingRequirementsRow(
      string BindingRequirement)
    {
      dsCompanyLineBindingRequirements.lstBindingRequirementsRow row = (dsCompanyLineBindingRequirements.lstBindingRequirementsRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.lstBindingRequirementsRow FindByBindingRequirementID(
      short BindingRequirementID)
    {
      return (dsCompanyLineBindingRequirements.lstBindingRequirementsRow) this.Rows.Find(new object[1]
      {
        (object) BindingRequirementID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineBindingRequirements.lstBindingRequirementsDataTable requirementsDataTable = (dsCompanyLineBindingRequirements.lstBindingRequirementsDataTable) base.Clone();
      requirementsDataTable.InitVars();
      return (DataTable) requirementsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineBindingRequirements.lstBindingRequirementsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnBindingRequirementID = this.Columns["BindingRequirementID"];
      this.columnBindingRequirement = this.Columns["BindingRequirement"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnBindingRequirementID = new DataColumn("BindingRequirementID", typeof (short), (string) null, MappingType.Element);
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
      this.columnBindingRequirement.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.lstBindingRequirementsRow NewlstBindingRequirementsRow()
    {
      return (dsCompanyLineBindingRequirements.lstBindingRequirementsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineBindingRequirements.lstBindingRequirementsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyLineBindingRequirements.lstBindingRequirementsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBindingRequirementsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineBindingRequirements.lstBindingRequirementsRowChangeEventHandler requirementsRowChangedEvent = this.lstBindingRequirementsRowChangedEvent;
      if (requirementsRowChangedEvent == null)
        return;
      requirementsRowChangedEvent((object) this, new dsCompanyLineBindingRequirements.lstBindingRequirementsRowChangeEvent((dsCompanyLineBindingRequirements.lstBindingRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBindingRequirementsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineBindingRequirements.lstBindingRequirementsRowChangeEventHandler rowChangingEvent = this.lstBindingRequirementsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineBindingRequirements.lstBindingRequirementsRowChangeEvent((dsCompanyLineBindingRequirements.lstBindingRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBindingRequirementsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineBindingRequirements.lstBindingRequirementsRowChangeEventHandler requirementsRowDeletedEvent = this.lstBindingRequirementsRowDeletedEvent;
      if (requirementsRowDeletedEvent == null)
        return;
      requirementsRowDeletedEvent((object) this, new dsCompanyLineBindingRequirements.lstBindingRequirementsRowChangeEvent((dsCompanyLineBindingRequirements.lstBindingRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBindingRequirementsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineBindingRequirements.lstBindingRequirementsRowChangeEventHandler rowDeletingEvent = this.lstBindingRequirementsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineBindingRequirements.lstBindingRequirementsRowChangeEvent((dsCompanyLineBindingRequirements.lstBindingRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstBindingRequirementsRow(
      dsCompanyLineBindingRequirements.lstBindingRequirementsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineBindingRequirements bindingRequirements = new dsCompanyLineBindingRequirements();
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
        FixedValue = bindingRequirements.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstBindingRequirementsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = bindingRequirements.GetSchemaSerializable();
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
  public class tblCompanyLineBindingRequirementsDataTable : 
    TypedTableBase<dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow>
  {
    private DataColumn columnCompanyLineID;
    private DataColumn columnBindingRequirementID;
    private DataColumn columnQuoteStatusID;
    private DataColumn columnHardStop;
    private DataColumn columnSoftStop;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyLineBindingRequirementsDataTable()
    {
      this.TableName = "tblCompanyLineBindingRequirements";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyLineBindingRequirementsDataTable(DataTable table)
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
    protected tblCompanyLineBindingRequirementsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLineIDColumn => this.columnCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BindingRequirementIDColumn => this.columnBindingRequirementID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteStatusIDColumn => this.columnQuoteStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn HardStopColumn => this.columnHardStop;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SoftStopColumn => this.columnSoftStop;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow this[int index]
    {
      get
      {
        return (dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow) this.Rows[index];
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRowChangeEventHandler tblCompanyLineBindingRequirementsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRowChangeEventHandler tblCompanyLineBindingRequirementsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRowChangeEventHandler tblCompanyLineBindingRequirementsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRowChangeEventHandler tblCompanyLineBindingRequirementsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompanyLineBindingRequirementsRow(
      dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow AddtblCompanyLineBindingRequirementsRow(
      int CompanyLineID,
      dsCompanyLineBindingRequirements.lstBindingRequirementsRow parentlstBindingRequirementsRowBylstBindingRequirementstblCompanyLineBindingRequirements,
      int QuoteStatusID,
      bool HardStop,
      bool SoftStop)
    {
      dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow row = (dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) CompanyLineID,
        null,
        (object) QuoteStatusID,
        (object) HardStop,
        (object) SoftStop
      };
      if (parentlstBindingRequirementsRowBylstBindingRequirementstblCompanyLineBindingRequirements != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstBindingRequirementsRowBylstBindingRequirementstblCompanyLineBindingRequirements[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow FindByCompanyLineIDBindingRequirementIDQuoteStatusID(
      int CompanyLineID,
      short BindingRequirementID,
      int QuoteStatusID)
    {
      return (dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow) this.Rows.Find(new object[3]
      {
        (object) CompanyLineID,
        (object) BindingRequirementID,
        (object) QuoteStatusID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsDataTable requirementsDataTable = (dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsDataTable) base.Clone();
      requirementsDataTable.InitVars();
      return (DataTable) requirementsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLineID = this.Columns["CompanyLineID"];
      this.columnBindingRequirementID = this.Columns["BindingRequirementID"];
      this.columnQuoteStatusID = this.Columns["QuoteStatusID"];
      this.columnHardStop = this.Columns["HardStop"];
      this.columnSoftStop = this.Columns["SoftStop"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLineID = new DataColumn("CompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineID);
      this.columnBindingRequirementID = new DataColumn("BindingRequirementID", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBindingRequirementID);
      this.columnQuoteStatusID = new DataColumn("QuoteStatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatusID);
      this.columnHardStop = new DataColumn("HardStop", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHardStop);
      this.columnSoftStop = new DataColumn("SoftStop", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSoftStop);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[3]
      {
        this.columnCompanyLineID,
        this.columnBindingRequirementID,
        this.columnQuoteStatusID
      }, true));
      this.columnCompanyLineID.AllowDBNull = false;
      this.columnBindingRequirementID.AllowDBNull = false;
      this.columnQuoteStatusID.AllowDBNull = false;
      this.columnHardStop.DefaultValue = (object) true;
      this.columnSoftStop.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow NewtblCompanyLineBindingRequirementsRow()
    {
      return (dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineBindingRequirementsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRowChangeEventHandler requirementsRowChangedEvent = this.tblCompanyLineBindingRequirementsRowChangedEvent;
      if (requirementsRowChangedEvent == null)
        return;
      requirementsRowChangedEvent((object) this, new dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRowChangeEvent((dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineBindingRequirementsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRowChangeEventHandler rowChangingEvent = this.tblCompanyLineBindingRequirementsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRowChangeEvent((dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineBindingRequirementsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRowChangeEventHandler requirementsRowDeletedEvent = this.tblCompanyLineBindingRequirementsRowDeletedEvent;
      if (requirementsRowDeletedEvent == null)
        return;
      requirementsRowDeletedEvent((object) this, new dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRowChangeEvent((dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineBindingRequirementsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRowChangeEventHandler rowDeletingEvent = this.tblCompanyLineBindingRequirementsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRowChangeEvent((dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompanyLineBindingRequirementsRow(
      dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineBindingRequirements bindingRequirements = new dsCompanyLineBindingRequirements();
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
        FixedValue = bindingRequirements.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLineBindingRequirementsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = bindingRequirements.GetSchemaSerializable();
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
  public class lstQuoteStatusDataTable : 
    TypedTableBase<dsCompanyLineBindingRequirements.lstQuoteStatusRow>
  {
    private DataColumn columnQuoteStatusID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstQuoteStatusDataTable()
    {
      this.TableName = "lstQuoteStatus";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstQuoteStatusDataTable(DataTable table)
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
    protected lstQuoteStatusDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteStatusIDColumn => this.columnQuoteStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.lstQuoteStatusRow this[int index]
    {
      get => (dsCompanyLineBindingRequirements.lstQuoteStatusRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLineBindingRequirements.lstQuoteStatusRowChangeEventHandler lstQuoteStatusRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLineBindingRequirements.lstQuoteStatusRowChangeEventHandler lstQuoteStatusRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLineBindingRequirements.lstQuoteStatusRowChangeEventHandler lstQuoteStatusRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLineBindingRequirements.lstQuoteStatusRowChangeEventHandler lstQuoteStatusRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstQuoteStatusRow(
      dsCompanyLineBindingRequirements.lstQuoteStatusRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.lstQuoteStatusRow AddlstQuoteStatusRow(
      int QuoteStatusID,
      string Description)
    {
      dsCompanyLineBindingRequirements.lstQuoteStatusRow row = (dsCompanyLineBindingRequirements.lstQuoteStatusRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) QuoteStatusID,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.lstQuoteStatusRow FindByQuoteStatusID(int QuoteStatusID)
    {
      return (dsCompanyLineBindingRequirements.lstQuoteStatusRow) this.Rows.Find(new object[1]
      {
        (object) QuoteStatusID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineBindingRequirements.lstQuoteStatusDataTable quoteStatusDataTable = (dsCompanyLineBindingRequirements.lstQuoteStatusDataTable) base.Clone();
      quoteStatusDataTable.InitVars();
      return (DataTable) quoteStatusDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineBindingRequirements.lstQuoteStatusDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteStatusID = this.Columns["QuoteStatusID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteStatusID = new DataColumn("QuoteStatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatusID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnQuoteStatusID
      }, true));
      this.columnQuoteStatusID.AllowDBNull = false;
      this.columnQuoteStatusID.Unique = true;
      this.columnDescription.AllowDBNull = false;
      this.columnDescription.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.lstQuoteStatusRow NewlstQuoteStatusRow()
    {
      return (dsCompanyLineBindingRequirements.lstQuoteStatusRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineBindingRequirements.lstQuoteStatusRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyLineBindingRequirements.lstQuoteStatusRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineBindingRequirements.lstQuoteStatusRowChangeEventHandler statusRowChangedEvent = this.lstQuoteStatusRowChangedEvent;
      if (statusRowChangedEvent == null)
        return;
      statusRowChangedEvent((object) this, new dsCompanyLineBindingRequirements.lstQuoteStatusRowChangeEvent((dsCompanyLineBindingRequirements.lstQuoteStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineBindingRequirements.lstQuoteStatusRowChangeEventHandler rowChangingEvent = this.lstQuoteStatusRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineBindingRequirements.lstQuoteStatusRowChangeEvent((dsCompanyLineBindingRequirements.lstQuoteStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineBindingRequirements.lstQuoteStatusRowChangeEventHandler statusRowDeletedEvent = this.lstQuoteStatusRowDeletedEvent;
      if (statusRowDeletedEvent == null)
        return;
      statusRowDeletedEvent((object) this, new dsCompanyLineBindingRequirements.lstQuoteStatusRowChangeEvent((dsCompanyLineBindingRequirements.lstQuoteStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstQuoteStatusRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineBindingRequirements.lstQuoteStatusRowChangeEventHandler rowDeletingEvent = this.lstQuoteStatusRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineBindingRequirements.lstQuoteStatusRowChangeEvent((dsCompanyLineBindingRequirements.lstQuoteStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstQuoteStatusRow(
      dsCompanyLineBindingRequirements.lstQuoteStatusRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineBindingRequirements bindingRequirements = new dsCompanyLineBindingRequirements();
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
        FixedValue = bindingRequirements.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstQuoteStatusDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = bindingRequirements.GetSchemaSerializable();
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
    private dsCompanyLineBindingRequirements.lstBindingRequirementsDataTable tablelstBindingRequirements;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstBindingRequirementsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstBindingRequirements = (dsCompanyLineBindingRequirements.lstBindingRequirementsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public short BindingRequirementID
    {
      get => Conversions.ToShort(this[this.tablelstBindingRequirements.BindingRequirementIDColumn]);
      set => this[this.tablelstBindingRequirements.BindingRequirementIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BindingRequirement
    {
      get => Conversions.ToString(this[this.tablelstBindingRequirements.BindingRequirementColumn]);
      set => this[this.tablelstBindingRequirements.BindingRequirementColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow[] GettblCompanyLineBindingRequirementsRows()
    {
      return this.Table.ChildRelations["lstBindingRequirementstblCompanyLineBindingRequirements"] != null ? (dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow[]) this.GetChildRows(this.Table.ChildRelations["lstBindingRequirementstblCompanyLineBindingRequirements"]) : new dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow[0];
    }
  }

  public class tblCompanyLineBindingRequirementsRow : DataRow
  {
    private dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsDataTable tabletblCompanyLineBindingRequirements;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyLineBindingRequirementsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLineBindingRequirements = (dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CompanyLineID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyLineBindingRequirements.CompanyLineIDColumn]);
      }
      set => this[this.tabletblCompanyLineBindingRequirements.CompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public short BindingRequirementID
    {
      get
      {
        return Conversions.ToShort(this[this.tabletblCompanyLineBindingRequirements.BindingRequirementIDColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineBindingRequirements.BindingRequirementIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int QuoteStatusID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyLineBindingRequirements.QuoteStatusIDColumn]);
      }
      set => this[this.tabletblCompanyLineBindingRequirements.QuoteStatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool HardStop
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineBindingRequirements.HardStopColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'HardStop' in table 'tblCompanyLineBindingRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineBindingRequirements.HardStopColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool SoftStop
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineBindingRequirements.SoftStopColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SoftStop' in table 'tblCompanyLineBindingRequirements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineBindingRequirements.SoftStopColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.lstBindingRequirementsRow lstBindingRequirementsRow
    {
      get
      {
        return (dsCompanyLineBindingRequirements.lstBindingRequirementsRow) this.GetParentRow(this.Table.ParentRelations["lstBindingRequirementstblCompanyLineBindingRequirements"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstBindingRequirementstblCompanyLineBindingRequirements"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsHardStopNull()
    {
      return this.IsNull(this.tabletblCompanyLineBindingRequirements.HardStopColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetHardStopNull()
    {
      this[this.tabletblCompanyLineBindingRequirements.HardStopColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSoftStopNull()
    {
      return this.IsNull(this.tabletblCompanyLineBindingRequirements.SoftStopColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSoftStopNull()
    {
      this[this.tabletblCompanyLineBindingRequirements.SoftStopColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstQuoteStatusRow : DataRow
  {
    private dsCompanyLineBindingRequirements.lstQuoteStatusDataTable tablelstQuoteStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstQuoteStatusRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstQuoteStatus = (dsCompanyLineBindingRequirements.lstQuoteStatusDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int QuoteStatusID
    {
      get => Conversions.ToInteger(this[this.tablelstQuoteStatus.QuoteStatusIDColumn]);
      set => this[this.tablelstQuoteStatus.QuoteStatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstQuoteStatus.DescriptionColumn]);
      set => this[this.tablelstQuoteStatus.DescriptionColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstBindingRequirementsRowChangeEvent : EventArgs
  {
    private dsCompanyLineBindingRequirements.lstBindingRequirementsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstBindingRequirementsRowChangeEvent(
      dsCompanyLineBindingRequirements.lstBindingRequirementsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.lstBindingRequirementsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompanyLineBindingRequirementsRowChangeEvent : EventArgs
  {
    private dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyLineBindingRequirementsRowChangeEvent(
      dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.tblCompanyLineBindingRequirementsRow Row
    {
      get => this.eventRow;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstQuoteStatusRowChangeEvent : EventArgs
  {
    private dsCompanyLineBindingRequirements.lstQuoteStatusRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstQuoteStatusRowChangeEvent(
      dsCompanyLineBindingRequirements.lstQuoteStatusRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLineBindingRequirements.lstQuoteStatusRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
