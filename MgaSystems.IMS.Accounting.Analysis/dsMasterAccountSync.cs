// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.dsMasterAccountSync
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
namespace MGASystems.IMS.Accounting.Analysis;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsMasterAccountSync")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsMasterAccountSync : DataSet
{
  private dsMasterAccountSync.OfficeLocationsDataTable tableOfficeLocations;
  private dsMasterAccountSync.MasterAccountsDataTable tableMasterAccounts;
  private DataRelation relationOfficeLocations_MasterAccounts;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsMasterAccountSync()
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
  protected dsMasterAccountSync(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (OfficeLocations)] != null)
          base.Tables.Add((DataTable) new dsMasterAccountSync.OfficeLocationsDataTable(dataSet.Tables[nameof (OfficeLocations)]));
        if (dataSet.Tables[nameof (MasterAccounts)] != null)
          base.Tables.Add((DataTable) new dsMasterAccountSync.MasterAccountsDataTable(dataSet.Tables[nameof (MasterAccounts)]));
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
  public dsMasterAccountSync.OfficeLocationsDataTable OfficeLocations => this.tableOfficeLocations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsMasterAccountSync.MasterAccountsDataTable MasterAccounts => this.tableMasterAccounts;

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
    dsMasterAccountSync masterAccountSync = (dsMasterAccountSync) base.Clone();
    masterAccountSync.InitVars();
    masterAccountSync.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) masterAccountSync;
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
      if (dataSet.Tables["OfficeLocations"] != null)
        base.Tables.Add((DataTable) new dsMasterAccountSync.OfficeLocationsDataTable(dataSet.Tables["OfficeLocations"]));
      if (dataSet.Tables["MasterAccounts"] != null)
        base.Tables.Add((DataTable) new dsMasterAccountSync.MasterAccountsDataTable(dataSet.Tables["MasterAccounts"]));
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
    this.tableOfficeLocations = (dsMasterAccountSync.OfficeLocationsDataTable) base.Tables["OfficeLocations"];
    if (initTable && this.tableOfficeLocations != null)
      this.tableOfficeLocations.InitVars();
    this.tableMasterAccounts = (dsMasterAccountSync.MasterAccountsDataTable) base.Tables["MasterAccounts"];
    if (initTable && this.tableMasterAccounts != null)
      this.tableMasterAccounts.InitVars();
    this.relationOfficeLocations_MasterAccounts = this.Relations["OfficeLocations_MasterAccounts"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsMasterAccountSync);
    this.Prefix = "";
    this.Namespace = "MGASystems.IMS.Accounting.Analysis.GLMasterAccounts";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableOfficeLocations = new dsMasterAccountSync.OfficeLocationsDataTable();
    base.Tables.Add((DataTable) this.tableOfficeLocations);
    this.tableMasterAccounts = new dsMasterAccountSync.MasterAccountsDataTable();
    base.Tables.Add((DataTable) this.tableMasterAccounts);
    this.relationOfficeLocations_MasterAccounts = new DataRelation("OfficeLocations_MasterAccounts", new DataColumn[1]
    {
      this.tableOfficeLocations.OfficeIdColumn
    }, new DataColumn[1]
    {
      this.tableMasterAccounts.GLCompanyIdColumn
    }, false);
    this.Relations.Add(this.relationOfficeLocations_MasterAccounts);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeOfficeLocations() => false;

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
    dsMasterAccountSync masterAccountSync = new dsMasterAccountSync();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = masterAccountSync.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = masterAccountSync.GetSchemaSerializable();
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
  public delegate void OfficeLocationsRowChangeEventHandler(
    object sender,
    dsMasterAccountSync.OfficeLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void MasterAccountsRowChangeEventHandler(
    object sender,
    dsMasterAccountSync.MasterAccountsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class OfficeLocationsDataTable : TypedTableBase<dsMasterAccountSync.OfficeLocationsRow>
  {
    private DataColumn columnOfficeId;
    private DataColumn columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public OfficeLocationsDataTable()
    {
      this.TableName = "OfficeLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal OfficeLocationsDataTable(DataTable table)
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
    protected OfficeLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OfficeIdColumn => this.columnOfficeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMasterAccountSync.OfficeLocationsRow this[int index]
    {
      get => (dsMasterAccountSync.OfficeLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMasterAccountSync.OfficeLocationsRowChangeEventHandler OfficeLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMasterAccountSync.OfficeLocationsRowChangeEventHandler OfficeLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMasterAccountSync.OfficeLocationsRowChangeEventHandler OfficeLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMasterAccountSync.OfficeLocationsRowChangeEventHandler OfficeLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddOfficeLocationsRow(dsMasterAccountSync.OfficeLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMasterAccountSync.OfficeLocationsRow AddOfficeLocationsRow(
      int OfficeId,
      string Location)
    {
      dsMasterAccountSync.OfficeLocationsRow row = (dsMasterAccountSync.OfficeLocationsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) OfficeId,
        (object) Location
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMasterAccountSync.OfficeLocationsRow FindByOfficeId(int OfficeId)
    {
      return (dsMasterAccountSync.OfficeLocationsRow) this.Rows.Find(new object[1]
      {
        (object) OfficeId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsMasterAccountSync.OfficeLocationsDataTable locationsDataTable = (dsMasterAccountSync.OfficeLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsMasterAccountSync.OfficeLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnOfficeId = this.Columns["OfficeId"];
      this.columnLocation = this.Columns["Location"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnOfficeId = new DataColumn("OfficeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeId);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnOfficeId
      }, true));
      this.columnOfficeId.AllowDBNull = false;
      this.columnOfficeId.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMasterAccountSync.OfficeLocationsRow NewOfficeLocationsRow()
    {
      return (dsMasterAccountSync.OfficeLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsMasterAccountSync.OfficeLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsMasterAccountSync.OfficeLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.OfficeLocationsRowChanged == null)
        return;
      this.OfficeLocationsRowChanged((object) this, new dsMasterAccountSync.OfficeLocationsRowChangeEvent((dsMasterAccountSync.OfficeLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.OfficeLocationsRowChanging == null)
        return;
      this.OfficeLocationsRowChanging((object) this, new dsMasterAccountSync.OfficeLocationsRowChangeEvent((dsMasterAccountSync.OfficeLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.OfficeLocationsRowDeleted == null)
        return;
      this.OfficeLocationsRowDeleted((object) this, new dsMasterAccountSync.OfficeLocationsRowChangeEvent((dsMasterAccountSync.OfficeLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.OfficeLocationsRowDeleting == null)
        return;
      this.OfficeLocationsRowDeleting((object) this, new dsMasterAccountSync.OfficeLocationsRowChangeEvent((dsMasterAccountSync.OfficeLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveOfficeLocationsRow(dsMasterAccountSync.OfficeLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsMasterAccountSync masterAccountSync = new dsMasterAccountSync();
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
        FixedValue = masterAccountSync.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (OfficeLocationsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = masterAccountSync.GetSchemaSerializable();
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

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class MasterAccountsDataTable : TypedTableBase<dsMasterAccountSync.MasterAccountsRow>
  {
    private DataColumn columnGLCompanyId;
    private DataColumn columnGLMasterId;
    private DataColumn columnGLAccountName;
    private DataColumn columnGLAccountShortName;
    private DataColumn columnGLAccountNumber;
    private DataColumn columnGLFinancialAccountNumber;
    private DataColumn columnAccountType;

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
    public DataColumn GLCompanyIdColumn => this.columnGLCompanyId;

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
    public DataColumn AccountTypeColumn => this.columnAccountType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMasterAccountSync.MasterAccountsRow this[int index]
    {
      get => (dsMasterAccountSync.MasterAccountsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMasterAccountSync.MasterAccountsRowChangeEventHandler MasterAccountsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMasterAccountSync.MasterAccountsRowChangeEventHandler MasterAccountsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMasterAccountSync.MasterAccountsRowChangeEventHandler MasterAccountsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsMasterAccountSync.MasterAccountsRowChangeEventHandler MasterAccountsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddMasterAccountsRow(dsMasterAccountSync.MasterAccountsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMasterAccountSync.MasterAccountsRow AddMasterAccountsRow(
      dsMasterAccountSync.OfficeLocationsRow parentOfficeLocationsRowByOfficeLocations_MasterAccounts,
      int GLMasterId,
      string GLAccountName,
      string GLAccountShortName,
      string GLAccountNumber,
      int GLFinancialAccountNumber,
      string AccountType)
    {
      dsMasterAccountSync.MasterAccountsRow row = (dsMasterAccountSync.MasterAccountsRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        (object) GLMasterId,
        (object) GLAccountName,
        (object) GLAccountShortName,
        (object) GLAccountNumber,
        (object) GLFinancialAccountNumber,
        (object) AccountType
      };
      if (parentOfficeLocationsRowByOfficeLocations_MasterAccounts != null)
        objArray[0] = parentOfficeLocationsRowByOfficeLocations_MasterAccounts[0];
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsMasterAccountSync.MasterAccountsDataTable accountsDataTable = (dsMasterAccountSync.MasterAccountsDataTable) base.Clone();
      accountsDataTable.InitVars();
      return (DataTable) accountsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsMasterAccountSync.MasterAccountsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnGLCompanyId = this.Columns["GLCompanyId"];
      this.columnGLMasterId = this.Columns["GLMasterId"];
      this.columnGLAccountName = this.Columns["GLAccountName"];
      this.columnGLAccountShortName = this.Columns["GLAccountShortName"];
      this.columnGLAccountNumber = this.Columns["GLAccountNumber"];
      this.columnGLFinancialAccountNumber = this.Columns["GLFinancialAccountNumber"];
      this.columnAccountType = this.Columns["AccountType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnGLCompanyId = new DataColumn("GLCompanyId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLCompanyId);
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
      this.columnAccountType = new DataColumn("AccountType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccountType);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMasterAccountSync.MasterAccountsRow NewMasterAccountsRow()
    {
      return (dsMasterAccountSync.MasterAccountsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsMasterAccountSync.MasterAccountsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsMasterAccountSync.MasterAccountsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.MasterAccountsRowChanged == null)
        return;
      this.MasterAccountsRowChanged((object) this, new dsMasterAccountSync.MasterAccountsRowChangeEvent((dsMasterAccountSync.MasterAccountsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.MasterAccountsRowChanging == null)
        return;
      this.MasterAccountsRowChanging((object) this, new dsMasterAccountSync.MasterAccountsRowChangeEvent((dsMasterAccountSync.MasterAccountsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.MasterAccountsRowDeleted == null)
        return;
      this.MasterAccountsRowDeleted((object) this, new dsMasterAccountSync.MasterAccountsRowChangeEvent((dsMasterAccountSync.MasterAccountsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.MasterAccountsRowDeleting == null)
        return;
      this.MasterAccountsRowDeleting((object) this, new dsMasterAccountSync.MasterAccountsRowChangeEvent((dsMasterAccountSync.MasterAccountsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveMasterAccountsRow(dsMasterAccountSync.MasterAccountsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsMasterAccountSync masterAccountSync = new dsMasterAccountSync();
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
        FixedValue = masterAccountSync.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (MasterAccountsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = masterAccountSync.GetSchemaSerializable();
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

  public class OfficeLocationsRow : DataRow
  {
    private dsMasterAccountSync.OfficeLocationsDataTable tableOfficeLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal OfficeLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOfficeLocations = (dsMasterAccountSync.OfficeLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OfficeId
    {
      get => (int) this[this.tableOfficeLocations.OfficeIdColumn];
      set => this[this.tableOfficeLocations.OfficeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Location
    {
      get
      {
        try
        {
          return (string) this[this.tableOfficeLocations.LocationColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Location' in table 'OfficeLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfficeLocations.LocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocationNull() => this.IsNull(this.tableOfficeLocations.LocationColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocationNull()
    {
      this[this.tableOfficeLocations.LocationColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMasterAccountSync.MasterAccountsRow[] GetMasterAccountsRows()
    {
      return this.Table.ChildRelations["OfficeLocations_MasterAccounts"] == null ? new dsMasterAccountSync.MasterAccountsRow[0] : (dsMasterAccountSync.MasterAccountsRow[]) this.GetChildRows(this.Table.ChildRelations["OfficeLocations_MasterAccounts"]);
    }
  }

  public class MasterAccountsRow : DataRow
  {
    private dsMasterAccountSync.MasterAccountsDataTable tableMasterAccounts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal MasterAccountsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableMasterAccounts = (dsMasterAccountSync.MasterAccountsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GLCompanyId
    {
      get
      {
        try
        {
          return (int) this[this.tableMasterAccounts.GLCompanyIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GLCompanyId' in table 'MasterAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMasterAccounts.GLCompanyIdColumn] = (object) value;
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
    public string AccountType
    {
      get
      {
        try
        {
          return (string) this[this.tableMasterAccounts.AccountTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AccountType' in table 'MasterAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableMasterAccounts.AccountTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMasterAccountSync.OfficeLocationsRow OfficeLocationsRow
    {
      get
      {
        return (dsMasterAccountSync.OfficeLocationsRow) this.GetParentRow(this.Table.ParentRelations["OfficeLocations_MasterAccounts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["OfficeLocations_MasterAccounts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLCompanyIdNull() => this.IsNull(this.tableMasterAccounts.GLCompanyIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLCompanyIdNull()
    {
      this[this.tableMasterAccounts.GLCompanyIdColumn] = Convert.DBNull;
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
    public bool IsAccountTypeNull() => this.IsNull(this.tableMasterAccounts.AccountTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAccountTypeNull()
    {
      this[this.tableMasterAccounts.AccountTypeColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class OfficeLocationsRowChangeEvent : EventArgs
  {
    private dsMasterAccountSync.OfficeLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public OfficeLocationsRowChangeEvent(
      dsMasterAccountSync.OfficeLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMasterAccountSync.OfficeLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class MasterAccountsRowChangeEvent : EventArgs
  {
    private dsMasterAccountSync.MasterAccountsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public MasterAccountsRowChangeEvent(
      dsMasterAccountSync.MasterAccountsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsMasterAccountSync.MasterAccountsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
