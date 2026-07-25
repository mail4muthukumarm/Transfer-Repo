// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.dsProducerMarketing
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
[XmlRoot("dsProducerMarketing")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsProducerMarketing : DataSet
{
  private dsProducerMarketing.tblCompaniesDataTable tabletblCompanies;
  private dsProducerMarketing.tblProducerMarketingDataTable tabletblProducerMarketing;
  private DataRelation relationtblCompaniestblProducerMarketing;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsProducerMarketing()
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
  protected dsProducerMarketing(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanies)] != null)
          base.Tables.Add((DataTable) new dsProducerMarketing.tblCompaniesDataTable(dataSet.Tables[nameof (tblCompanies)]));
        if (dataSet.Tables[nameof (tblProducerMarketing)] != null)
          base.Tables.Add((DataTable) new dsProducerMarketing.tblProducerMarketingDataTable(dataSet.Tables[nameof (tblProducerMarketing)]));
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
  public dsProducerMarketing.tblCompaniesDataTable tblCompanies => this.tabletblCompanies;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducerMarketing.tblProducerMarketingDataTable tblProducerMarketing
  {
    get => this.tabletblProducerMarketing;
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
    dsProducerMarketing producerMarketing = (dsProducerMarketing) base.Clone();
    producerMarketing.InitVars();
    producerMarketing.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) producerMarketing;
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
      if (dataSet.Tables["tblCompanies"] != null)
        base.Tables.Add((DataTable) new dsProducerMarketing.tblCompaniesDataTable(dataSet.Tables["tblCompanies"]));
      if (dataSet.Tables["tblProducerMarketing"] != null)
        base.Tables.Add((DataTable) new dsProducerMarketing.tblProducerMarketingDataTable(dataSet.Tables["tblProducerMarketing"]));
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
    this.tabletblCompanies = (dsProducerMarketing.tblCompaniesDataTable) base.Tables["tblCompanies"];
    if (initTable && this.tabletblCompanies != null)
      this.tabletblCompanies.InitVars();
    this.tabletblProducerMarketing = (dsProducerMarketing.tblProducerMarketingDataTable) base.Tables["tblProducerMarketing"];
    if (initTable && this.tabletblProducerMarketing != null)
      this.tabletblProducerMarketing.InitVars();
    this.relationtblCompaniestblProducerMarketing = this.Relations["tblCompaniestblProducerMarketing"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsProducerMarketing);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsProducerMarketing.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanies = new dsProducerMarketing.tblCompaniesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanies);
    this.tabletblProducerMarketing = new dsProducerMarketing.tblProducerMarketingDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerMarketing);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("tblCompaniestblProducerMarketing", new DataColumn[1]
    {
      this.tabletblCompanies.CompanyGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerMarketing.CompanyGuidColumn
    });
    this.tabletblProducerMarketing.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationtblCompaniestblProducerMarketing = new DataRelation("tblCompaniestblProducerMarketing", new DataColumn[1]
    {
      this.tabletblCompanies.CompanyGUIDColumn
    }, new DataColumn[1]
    {
      this.tabletblProducerMarketing.CompanyGuidColumn
    }, false);
    this.Relations.Add(this.relationtblCompaniestblProducerMarketing);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanies() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblProducerMarketing() => false;

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
    dsProducerMarketing producerMarketing = new dsProducerMarketing();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = producerMarketing.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = producerMarketing.GetSchemaSerializable();
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
  public delegate void tblCompaniesRowChangeEventHandler(
    object sender,
    dsProducerMarketing.tblCompaniesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblProducerMarketingRowChangeEventHandler(
    object sender,
    dsProducerMarketing.tblProducerMarketingRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompaniesDataTable : TypedTableBase<dsProducerMarketing.tblCompaniesRow>
  {
    private DataColumn columnCompanyGUID;
    private DataColumn columnCompanyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompaniesDataTable()
    {
      this.TableName = "tblCompanies";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompaniesDataTable(DataTable table)
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
    protected tblCompaniesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyGUIDColumn => this.columnCompanyGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyNameColumn => this.columnCompanyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerMarketing.tblCompaniesRow this[int index]
    {
      get => (dsProducerMarketing.tblCompaniesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerMarketing.tblCompaniesRowChangeEventHandler tblCompaniesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerMarketing.tblCompaniesRowChangeEventHandler tblCompaniesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerMarketing.tblCompaniesRowChangeEventHandler tblCompaniesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerMarketing.tblCompaniesRowChangeEventHandler tblCompaniesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompaniesRow(dsProducerMarketing.tblCompaniesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerMarketing.tblCompaniesRow AddtblCompaniesRow(
      Guid CompanyGUID,
      string CompanyName)
    {
      dsProducerMarketing.tblCompaniesRow row = (dsProducerMarketing.tblCompaniesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyGUID,
        (object) CompanyName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerMarketing.tblCompaniesRow FindByCompanyGUID(Guid CompanyGUID)
    {
      return (dsProducerMarketing.tblCompaniesRow) this.Rows.Find(new object[1]
      {
        (object) CompanyGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerMarketing.tblCompaniesDataTable companiesDataTable = (dsProducerMarketing.tblCompaniesDataTable) base.Clone();
      companiesDataTable.InitVars();
      return (DataTable) companiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerMarketing.tblCompaniesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyGUID = this.Columns["CompanyGUID"];
      this.columnCompanyName = this.Columns["CompanyName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyGUID = new DataColumn("CompanyGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGUID);
      this.columnCompanyName = new DataColumn("CompanyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducerMarketingKey1", new DataColumn[1]
      {
        this.columnCompanyGUID
      }, true));
      this.columnCompanyGUID.AllowDBNull = false;
      this.columnCompanyGUID.Unique = true;
      this.columnCompanyName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerMarketing.tblCompaniesRow NewtblCompaniesRow()
    {
      return (dsProducerMarketing.tblCompaniesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerMarketing.tblCompaniesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducerMarketing.tblCompaniesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerMarketing.tblCompaniesRowChangeEventHandler companiesRowChangedEvent = this.tblCompaniesRowChangedEvent;
      if (companiesRowChangedEvent == null)
        return;
      companiesRowChangedEvent((object) this, new dsProducerMarketing.tblCompaniesRowChangeEvent((dsProducerMarketing.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerMarketing.tblCompaniesRowChangeEventHandler rowChangingEvent = this.tblCompaniesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerMarketing.tblCompaniesRowChangeEvent((dsProducerMarketing.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerMarketing.tblCompaniesRowChangeEventHandler companiesRowDeletedEvent = this.tblCompaniesRowDeletedEvent;
      if (companiesRowDeletedEvent == null)
        return;
      companiesRowDeletedEvent((object) this, new dsProducerMarketing.tblCompaniesRowChangeEvent((dsProducerMarketing.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompaniesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerMarketing.tblCompaniesRowChangeEventHandler rowDeletingEvent = this.tblCompaniesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerMarketing.tblCompaniesRowChangeEvent((dsProducerMarketing.tblCompaniesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompaniesRow(dsProducerMarketing.tblCompaniesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerMarketing producerMarketing = new dsProducerMarketing();
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
        FixedValue = producerMarketing.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompaniesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerMarketing.GetSchemaSerializable();
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
  public class tblProducerMarketingDataTable : 
    TypedTableBase<dsProducerMarketing.tblProducerMarketingRow>
  {
    private DataColumn columnProducerGuid;
    private DataColumn columnCompanyGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblProducerMarketingDataTable()
    {
      this.TableName = "tblProducerMarketing";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblProducerMarketingDataTable(DataTable table)
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
    protected tblProducerMarketingDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerGuidColumn => this.columnProducerGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyGuidColumn => this.columnCompanyGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerMarketing.tblProducerMarketingRow this[int index]
    {
      get => (dsProducerMarketing.tblProducerMarketingRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerMarketing.tblProducerMarketingRowChangeEventHandler tblProducerMarketingRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerMarketing.tblProducerMarketingRowChangeEventHandler tblProducerMarketingRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerMarketing.tblProducerMarketingRowChangeEventHandler tblProducerMarketingRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerMarketing.tblProducerMarketingRowChangeEventHandler tblProducerMarketingRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblProducerMarketingRow(dsProducerMarketing.tblProducerMarketingRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerMarketing.tblProducerMarketingRow AddtblProducerMarketingRow(
      Guid ProducerGuid,
      dsProducerMarketing.tblCompaniesRow parenttblCompaniesRowBytblCompaniestblProducerMarketing)
    {
      dsProducerMarketing.tblProducerMarketingRow row = (dsProducerMarketing.tblProducerMarketingRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ProducerGuid,
        null
      };
      if (parenttblCompaniesRowBytblCompaniestblProducerMarketing != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblCompaniesRowBytblCompaniestblProducerMarketing[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerMarketing.tblProducerMarketingRow FindByProducerGuidCompanyGuid(
      Guid ProducerGuid,
      Guid CompanyGuid)
    {
      return (dsProducerMarketing.tblProducerMarketingRow) this.Rows.Find(new object[2]
      {
        (object) ProducerGuid,
        (object) CompanyGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerMarketing.tblProducerMarketingDataTable marketingDataTable = (dsProducerMarketing.tblProducerMarketingDataTable) base.Clone();
      marketingDataTable.InitVars();
      return (DataTable) marketingDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerMarketing.tblProducerMarketingDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerGuid = this.Columns["ProducerGuid"];
      this.columnCompanyGuid = this.Columns["CompanyGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnProducerGuid = new DataColumn("ProducerGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerGuid);
      this.columnCompanyGuid = new DataColumn("CompanyGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsProducerMarketingKey2", new DataColumn[2]
      {
        this.columnProducerGuid,
        this.columnCompanyGuid
      }, true));
      this.columnProducerGuid.AllowDBNull = false;
      this.columnCompanyGuid.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerMarketing.tblProducerMarketingRow NewtblProducerMarketingRow()
    {
      return (dsProducerMarketing.tblProducerMarketingRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerMarketing.tblProducerMarketingRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducerMarketing.tblProducerMarketingRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerMarketingRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerMarketing.tblProducerMarketingRowChangeEventHandler marketingRowChangedEvent = this.tblProducerMarketingRowChangedEvent;
      if (marketingRowChangedEvent == null)
        return;
      marketingRowChangedEvent((object) this, new dsProducerMarketing.tblProducerMarketingRowChangeEvent((dsProducerMarketing.tblProducerMarketingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerMarketingRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerMarketing.tblProducerMarketingRowChangeEventHandler rowChangingEvent = this.tblProducerMarketingRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerMarketing.tblProducerMarketingRowChangeEvent((dsProducerMarketing.tblProducerMarketingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerMarketingRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerMarketing.tblProducerMarketingRowChangeEventHandler marketingRowDeletedEvent = this.tblProducerMarketingRowDeletedEvent;
      if (marketingRowDeletedEvent == null)
        return;
      marketingRowDeletedEvent((object) this, new dsProducerMarketing.tblProducerMarketingRowChangeEvent((dsProducerMarketing.tblProducerMarketingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerMarketingRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerMarketing.tblProducerMarketingRowChangeEventHandler rowDeletingEvent = this.tblProducerMarketingRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerMarketing.tblProducerMarketingRowChangeEvent((dsProducerMarketing.tblProducerMarketingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblProducerMarketingRow(dsProducerMarketing.tblProducerMarketingRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerMarketing producerMarketing = new dsProducerMarketing();
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
        FixedValue = producerMarketing.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerMarketingDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerMarketing.GetSchemaSerializable();
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

  public class tblCompaniesRow : DataRow
  {
    private dsProducerMarketing.tblCompaniesDataTable tabletblCompanies;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompaniesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanies = (dsProducerMarketing.tblCompaniesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyGUID
    {
      get
      {
        object obj = this[this.tabletblCompanies.CompanyGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanies.CompanyGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CompanyName
    {
      get => Conversions.ToString(this[this.tabletblCompanies.CompanyNameColumn]);
      set => this[this.tabletblCompanies.CompanyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerMarketing.tblProducerMarketingRow[] GettblProducerMarketingRows()
    {
      return this.Table.ChildRelations["tblCompaniestblProducerMarketing"] != null ? (dsProducerMarketing.tblProducerMarketingRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompaniestblProducerMarketing"]) : new dsProducerMarketing.tblProducerMarketingRow[0];
    }
  }

  public class tblProducerMarketingRow : DataRow
  {
    private dsProducerMarketing.tblProducerMarketingDataTable tabletblProducerMarketing;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblProducerMarketingRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerMarketing = (dsProducerMarketing.tblProducerMarketingDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ProducerGuid
    {
      get
      {
        object obj = this[this.tabletblProducerMarketing.ProducerGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducerMarketing.ProducerGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyGuid
    {
      get
      {
        object obj = this[this.tabletblProducerMarketing.CompanyGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblProducerMarketing.CompanyGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerMarketing.tblCompaniesRow tblCompaniesRow
    {
      get
      {
        return (dsProducerMarketing.tblCompaniesRow) this.GetParentRow(this.Table.ParentRelations["tblCompaniestblProducerMarketing"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompaniestblProducerMarketing"]);
      }
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompaniesRowChangeEvent : EventArgs
  {
    private dsProducerMarketing.tblCompaniesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompaniesRowChangeEvent(dsProducerMarketing.tblCompaniesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerMarketing.tblCompaniesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblProducerMarketingRowChangeEvent : EventArgs
  {
    private dsProducerMarketing.tblProducerMarketingRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblProducerMarketingRowChangeEvent(
      dsProducerMarketing.tblProducerMarketingRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerMarketing.tblProducerMarketingRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
