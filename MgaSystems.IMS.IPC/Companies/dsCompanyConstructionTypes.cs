// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.dsCompanyConstructionTypes
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
[XmlRoot("dsCompanyConstructionTypes")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyConstructionTypes : DataSet
{
  private dsCompanyConstructionTypes.lstConstructionTypesDataTable tablelstConstructionTypes;
  private dsCompanyConstructionTypes.tblCompanyLineConstructionTypesDataTable tabletblCompanyLineConstructionTypes;
  private DataRelation relationlstConstructionTypestblCompanyLineConstructionTypes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsCompanyConstructionTypes()
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
  protected dsCompanyConstructionTypes(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstConstructionTypes)] != null)
          base.Tables.Add((DataTable) new dsCompanyConstructionTypes.lstConstructionTypesDataTable(dataSet.Tables[nameof (lstConstructionTypes)]));
        if (dataSet.Tables[nameof (tblCompanyLineConstructionTypes)] != null)
          base.Tables.Add((DataTable) new dsCompanyConstructionTypes.tblCompanyLineConstructionTypesDataTable(dataSet.Tables[nameof (tblCompanyLineConstructionTypes)]));
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
  public dsCompanyConstructionTypes.lstConstructionTypesDataTable lstConstructionTypes
  {
    get => this.tablelstConstructionTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyConstructionTypes.tblCompanyLineConstructionTypesDataTable tblCompanyLineConstructionTypes
  {
    get => this.tabletblCompanyLineConstructionTypes;
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
    dsCompanyConstructionTypes constructionTypes = (dsCompanyConstructionTypes) base.Clone();
    constructionTypes.InitVars();
    constructionTypes.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) constructionTypes;
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
      if (dataSet.Tables["lstConstructionTypes"] != null)
        base.Tables.Add((DataTable) new dsCompanyConstructionTypes.lstConstructionTypesDataTable(dataSet.Tables["lstConstructionTypes"]));
      if (dataSet.Tables["tblCompanyLineConstructionTypes"] != null)
        base.Tables.Add((DataTable) new dsCompanyConstructionTypes.tblCompanyLineConstructionTypesDataTable(dataSet.Tables["tblCompanyLineConstructionTypes"]));
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
    this.tablelstConstructionTypes = (dsCompanyConstructionTypes.lstConstructionTypesDataTable) base.Tables["lstConstructionTypes"];
    if (initTable && this.tablelstConstructionTypes != null)
      this.tablelstConstructionTypes.InitVars();
    this.tabletblCompanyLineConstructionTypes = (dsCompanyConstructionTypes.tblCompanyLineConstructionTypesDataTable) base.Tables["tblCompanyLineConstructionTypes"];
    if (initTable && this.tabletblCompanyLineConstructionTypes != null)
      this.tabletblCompanyLineConstructionTypes.InitVars();
    this.relationlstConstructionTypestblCompanyLineConstructionTypes = this.Relations["lstConstructionTypestblCompanyLineConstructionTypes"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyConstructionTypes);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCompanyConstructionTypes.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstConstructionTypes = new dsCompanyConstructionTypes.lstConstructionTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstConstructionTypes);
    this.tabletblCompanyLineConstructionTypes = new dsCompanyConstructionTypes.tblCompanyLineConstructionTypesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLineConstructionTypes);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("lstConstructionTypestblCompanyLineConstructionTypes", new DataColumn[1]
    {
      this.tablelstConstructionTypes.ConstructionTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLineConstructionTypes.ConstructionTypeIDColumn
    });
    this.tabletblCompanyLineConstructionTypes.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationlstConstructionTypestblCompanyLineConstructionTypes = new DataRelation("lstConstructionTypestblCompanyLineConstructionTypes", new DataColumn[1]
    {
      this.tablelstConstructionTypes.ConstructionTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLineConstructionTypes.ConstructionTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstConstructionTypestblCompanyLineConstructionTypes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstConstructionTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyLineConstructionTypes() => false;

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
    dsCompanyConstructionTypes constructionTypes = new dsCompanyConstructionTypes();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = constructionTypes.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = constructionTypes.GetSchemaSerializable();
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
  public delegate void lstConstructionTypesRowChangeEventHandler(
    object sender,
    dsCompanyConstructionTypes.lstConstructionTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblCompanyLineConstructionTypesRowChangeEventHandler(
    object sender,
    dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstConstructionTypesDataTable : 
    TypedTableBase<dsCompanyConstructionTypes.lstConstructionTypesRow>
  {
    private DataColumn columnConstructionTypeID;
    private DataColumn columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstConstructionTypesDataTable()
    {
      this.TableName = "lstConstructionTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstConstructionTypesDataTable(DataTable table)
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
    protected lstConstructionTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ConstructionTypeIDColumn => this.columnConstructionTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyConstructionTypes.lstConstructionTypesRow this[int index]
    {
      get => (dsCompanyConstructionTypes.lstConstructionTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyConstructionTypes.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyConstructionTypes.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyConstructionTypes.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyConstructionTypes.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstConstructionTypesRow(
      dsCompanyConstructionTypes.lstConstructionTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyConstructionTypes.lstConstructionTypesRow AddlstConstructionTypesRow(
      int ConstructionTypeID,
      string Type)
    {
      dsCompanyConstructionTypes.lstConstructionTypesRow row = (dsCompanyConstructionTypes.lstConstructionTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ConstructionTypeID,
        (object) Type
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyConstructionTypes.lstConstructionTypesRow FindByConstructionTypeID(
      int ConstructionTypeID)
    {
      return (dsCompanyConstructionTypes.lstConstructionTypesRow) this.Rows.Find(new object[1]
      {
        (object) ConstructionTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyConstructionTypes.lstConstructionTypesDataTable constructionTypesDataTable = (dsCompanyConstructionTypes.lstConstructionTypesDataTable) base.Clone();
      constructionTypesDataTable.InitVars();
      return (DataTable) constructionTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyConstructionTypes.lstConstructionTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnConstructionTypeID = this.Columns["ConstructionTypeID"];
      this.columnType = this.Columns["Type"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnConstructionTypeID = new DataColumn("ConstructionTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConstructionTypeID);
      this.columnType = new DataColumn("Type", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnConstructionTypeID
      }, true));
      this.columnConstructionTypeID.AllowDBNull = false;
      this.columnConstructionTypeID.Unique = true;
      this.columnType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyConstructionTypes.lstConstructionTypesRow NewlstConstructionTypesRow()
    {
      return (dsCompanyConstructionTypes.lstConstructionTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyConstructionTypes.lstConstructionTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyConstructionTypes.lstConstructionTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyConstructionTypes.lstConstructionTypesRowChangeEventHandler typesRowChangedEvent = this.lstConstructionTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompanyConstructionTypes.lstConstructionTypesRowChangeEvent((dsCompanyConstructionTypes.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyConstructionTypes.lstConstructionTypesRowChangeEventHandler rowChangingEvent = this.lstConstructionTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyConstructionTypes.lstConstructionTypesRowChangeEvent((dsCompanyConstructionTypes.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyConstructionTypes.lstConstructionTypesRowChangeEventHandler typesRowDeletedEvent = this.lstConstructionTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompanyConstructionTypes.lstConstructionTypesRowChangeEvent((dsCompanyConstructionTypes.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyConstructionTypes.lstConstructionTypesRowChangeEventHandler rowDeletingEvent = this.lstConstructionTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyConstructionTypes.lstConstructionTypesRowChangeEvent((dsCompanyConstructionTypes.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstConstructionTypesRow(
      dsCompanyConstructionTypes.lstConstructionTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyConstructionTypes constructionTypes = new dsCompanyConstructionTypes();
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
        FixedValue = constructionTypes.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstConstructionTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = constructionTypes.GetSchemaSerializable();
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
  public class tblCompanyLineConstructionTypesDataTable : 
    TypedTableBase<dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow>
  {
    private DataColumn columnConstructionTypeID;
    private DataColumn columnCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLineConstructionTypesDataTable()
    {
      this.TableName = "tblCompanyLineConstructionTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLineConstructionTypesDataTable(DataTable table)
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
    protected tblCompanyLineConstructionTypesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ConstructionTypeIDColumn => this.columnConstructionTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineIDColumn => this.columnCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow this[int index]
    {
      get => (dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRowChangeEventHandler tblCompanyLineConstructionTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRowChangeEventHandler tblCompanyLineConstructionTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRowChangeEventHandler tblCompanyLineConstructionTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRowChangeEventHandler tblCompanyLineConstructionTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyLineConstructionTypesRow(
      dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow AddtblCompanyLineConstructionTypesRow(
      dsCompanyConstructionTypes.lstConstructionTypesRow parentlstConstructionTypesRowBylstConstructionTypestblCompanyLineConstructionTypes,
      int CompanyLineID)
    {
      dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow row = (dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) CompanyLineID
      };
      if (parentlstConstructionTypesRowBylstConstructionTypestblCompanyLineConstructionTypes != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parentlstConstructionTypesRowBylstConstructionTypestblCompanyLineConstructionTypes[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow FindByConstructionTypeIDCompanyLineID(
      int ConstructionTypeID,
      int CompanyLineID)
    {
      return (dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow) this.Rows.Find(new object[2]
      {
        (object) ConstructionTypeID,
        (object) CompanyLineID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyConstructionTypes.tblCompanyLineConstructionTypesDataTable constructionTypesDataTable = (dsCompanyConstructionTypes.tblCompanyLineConstructionTypesDataTable) base.Clone();
      constructionTypesDataTable.InitVars();
      return (DataTable) constructionTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyConstructionTypes.tblCompanyLineConstructionTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnConstructionTypeID = this.Columns["ConstructionTypeID"];
      this.columnCompanyLineID = this.Columns["CompanyLineID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnConstructionTypeID = new DataColumn("ConstructionTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConstructionTypeID);
      this.columnCompanyLineID = new DataColumn("CompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnConstructionTypeID,
        this.columnCompanyLineID
      }, true));
      this.columnConstructionTypeID.AllowDBNull = false;
      this.columnCompanyLineID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow NewtblCompanyLineConstructionTypesRow()
    {
      return (dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineConstructionTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRowChangeEventHandler typesRowChangedEvent = this.tblCompanyLineConstructionTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRowChangeEvent((dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineConstructionTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRowChangeEventHandler rowChangingEvent = this.tblCompanyLineConstructionTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRowChangeEvent((dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineConstructionTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRowChangeEventHandler typesRowDeletedEvent = this.tblCompanyLineConstructionTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRowChangeEvent((dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineConstructionTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRowChangeEventHandler rowDeletingEvent = this.tblCompanyLineConstructionTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRowChangeEvent((dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyLineConstructionTypesRow(
      dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyConstructionTypes constructionTypes = new dsCompanyConstructionTypes();
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
        FixedValue = constructionTypes.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLineConstructionTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = constructionTypes.GetSchemaSerializable();
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

  public class lstConstructionTypesRow : DataRow
  {
    private dsCompanyConstructionTypes.lstConstructionTypesDataTable tablelstConstructionTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstConstructionTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstConstructionTypes = (dsCompanyConstructionTypes.lstConstructionTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ConstructionTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstConstructionTypes.ConstructionTypeIDColumn]);
      set => this[this.tablelstConstructionTypes.ConstructionTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Type
    {
      get => Conversions.ToString(this[this.tablelstConstructionTypes.TypeColumn]);
      set => this[this.tablelstConstructionTypes.TypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow[] GettblCompanyLineConstructionTypesRows()
    {
      return this.Table.ChildRelations["lstConstructionTypestblCompanyLineConstructionTypes"] != null ? (dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow[]) this.GetChildRows(this.Table.ChildRelations["lstConstructionTypestblCompanyLineConstructionTypes"]) : new dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow[0];
    }
  }

  public class tblCompanyLineConstructionTypesRow : DataRow
  {
    private dsCompanyConstructionTypes.tblCompanyLineConstructionTypesDataTable tabletblCompanyLineConstructionTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLineConstructionTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLineConstructionTypes = (dsCompanyConstructionTypes.tblCompanyLineConstructionTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ConstructionTypeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyLineConstructionTypes.ConstructionTypeIDColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineConstructionTypes.ConstructionTypeIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int CompanyLineID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyLineConstructionTypes.CompanyLineIDColumn]);
      }
      set => this[this.tabletblCompanyLineConstructionTypes.CompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyConstructionTypes.lstConstructionTypesRow lstConstructionTypesRow
    {
      get
      {
        return (dsCompanyConstructionTypes.lstConstructionTypesRow) this.GetParentRow(this.Table.ParentRelations["lstConstructionTypestblCompanyLineConstructionTypes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstConstructionTypestblCompanyLineConstructionTypes"]);
      }
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstConstructionTypesRowChangeEvent : EventArgs
  {
    private dsCompanyConstructionTypes.lstConstructionTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstConstructionTypesRowChangeEvent(
      dsCompanyConstructionTypes.lstConstructionTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyConstructionTypes.lstConstructionTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyLineConstructionTypesRowChangeEvent : EventArgs
  {
    private dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLineConstructionTypesRowChangeEvent(
      dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyConstructionTypes.tblCompanyLineConstructionTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
