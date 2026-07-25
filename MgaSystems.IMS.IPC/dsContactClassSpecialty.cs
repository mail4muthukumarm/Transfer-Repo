// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.dsContactClassSpecialty
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
[XmlRoot("dsContactClassSpecialty")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsContactClassSpecialty : DataSet
{
  private dsContactClassSpecialty.lstContactClassSpecialtyDataTable tablelstContactClassSpecialty;
  private dsContactClassSpecialty.tblContactClassSpecialtyDataTable tabletblContactClassSpecialty;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsContactClassSpecialty()
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
  protected dsContactClassSpecialty(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstContactClassSpecialty)] != null)
          base.Tables.Add((DataTable) new dsContactClassSpecialty.lstContactClassSpecialtyDataTable(dataSet.Tables[nameof (lstContactClassSpecialty)]));
        if (dataSet.Tables[nameof (tblContactClassSpecialty)] != null)
          base.Tables.Add((DataTable) new dsContactClassSpecialty.tblContactClassSpecialtyDataTable(dataSet.Tables[nameof (tblContactClassSpecialty)]));
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
  public dsContactClassSpecialty.lstContactClassSpecialtyDataTable lstContactClassSpecialty
  {
    get => this.tablelstContactClassSpecialty;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsContactClassSpecialty.tblContactClassSpecialtyDataTable tblContactClassSpecialty
  {
    get => this.tabletblContactClassSpecialty;
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
    dsContactClassSpecialty contactClassSpecialty = (dsContactClassSpecialty) base.Clone();
    contactClassSpecialty.InitVars();
    contactClassSpecialty.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) contactClassSpecialty;
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
      if (dataSet.Tables["lstContactClassSpecialty"] != null)
        base.Tables.Add((DataTable) new dsContactClassSpecialty.lstContactClassSpecialtyDataTable(dataSet.Tables["lstContactClassSpecialty"]));
      if (dataSet.Tables["tblContactClassSpecialty"] != null)
        base.Tables.Add((DataTable) new dsContactClassSpecialty.tblContactClassSpecialtyDataTable(dataSet.Tables["tblContactClassSpecialty"]));
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
    this.tablelstContactClassSpecialty = (dsContactClassSpecialty.lstContactClassSpecialtyDataTable) base.Tables["lstContactClassSpecialty"];
    if (initTable && this.tablelstContactClassSpecialty != null)
      this.tablelstContactClassSpecialty.InitVars();
    this.tabletblContactClassSpecialty = (dsContactClassSpecialty.tblContactClassSpecialtyDataTable) base.Tables["tblContactClassSpecialty"];
    if (!initTable || this.tabletblContactClassSpecialty == null)
      return;
    this.tabletblContactClassSpecialty.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsContactClassSpecialty);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsContactClassSpecialty.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstContactClassSpecialty = new dsContactClassSpecialty.lstContactClassSpecialtyDataTable();
    base.Tables.Add((DataTable) this.tablelstContactClassSpecialty);
    this.tabletblContactClassSpecialty = new dsContactClassSpecialty.tblContactClassSpecialtyDataTable();
    base.Tables.Add((DataTable) this.tabletblContactClassSpecialty);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstContactClassSpecialty() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblContactClassSpecialty() => false;

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
    dsContactClassSpecialty contactClassSpecialty = new dsContactClassSpecialty();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = contactClassSpecialty.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = contactClassSpecialty.GetSchemaSerializable();
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
  public delegate void lstContactClassSpecialtyRowChangeEventHandler(
    object sender,
    dsContactClassSpecialty.lstContactClassSpecialtyRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblContactClassSpecialtyRowChangeEventHandler(
    object sender,
    dsContactClassSpecialty.tblContactClassSpecialtyRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstContactClassSpecialtyDataTable : 
    TypedTableBase<dsContactClassSpecialty.lstContactClassSpecialtyRow>
  {
    private DataColumn columnClassSpecialtyID;
    private DataColumn columnSpecialty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstContactClassSpecialtyDataTable()
    {
      this.TableName = "lstContactClassSpecialty";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstContactClassSpecialtyDataTable(DataTable table)
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
    protected lstContactClassSpecialtyDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassSpecialtyIDColumn => this.columnClassSpecialtyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SpecialtyColumn => this.columnSpecialty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsContactClassSpecialty.lstContactClassSpecialtyRow this[int index]
    {
      get => (dsContactClassSpecialty.lstContactClassSpecialtyRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsContactClassSpecialty.lstContactClassSpecialtyRowChangeEventHandler lstContactClassSpecialtyRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsContactClassSpecialty.lstContactClassSpecialtyRowChangeEventHandler lstContactClassSpecialtyRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsContactClassSpecialty.lstContactClassSpecialtyRowChangeEventHandler lstContactClassSpecialtyRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsContactClassSpecialty.lstContactClassSpecialtyRowChangeEventHandler lstContactClassSpecialtyRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstContactClassSpecialtyRow(
      dsContactClassSpecialty.lstContactClassSpecialtyRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsContactClassSpecialty.lstContactClassSpecialtyRow AddlstContactClassSpecialtyRow(
      string Specialty)
    {
      dsContactClassSpecialty.lstContactClassSpecialtyRow row = (dsContactClassSpecialty.lstContactClassSpecialtyRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) Specialty
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsContactClassSpecialty.lstContactClassSpecialtyRow FindByClassSpecialtyID(
      int ClassSpecialtyID)
    {
      return (dsContactClassSpecialty.lstContactClassSpecialtyRow) this.Rows.Find(new object[1]
      {
        (object) ClassSpecialtyID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsContactClassSpecialty.lstContactClassSpecialtyDataTable specialtyDataTable = (dsContactClassSpecialty.lstContactClassSpecialtyDataTable) base.Clone();
      specialtyDataTable.InitVars();
      return (DataTable) specialtyDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsContactClassSpecialty.lstContactClassSpecialtyDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnClassSpecialtyID = this.Columns["ClassSpecialtyID"];
      this.columnSpecialty = this.Columns["Specialty"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnClassSpecialtyID = new DataColumn("ClassSpecialtyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassSpecialtyID);
      this.columnSpecialty = new DataColumn("Specialty", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecialty);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnClassSpecialtyID
      }, true));
      this.columnClassSpecialtyID.AutoIncrement = true;
      this.columnClassSpecialtyID.AutoIncrementSeed = -1L;
      this.columnClassSpecialtyID.AutoIncrementStep = -1L;
      this.columnClassSpecialtyID.AllowDBNull = false;
      this.columnClassSpecialtyID.ReadOnly = true;
      this.columnClassSpecialtyID.Unique = true;
      this.columnSpecialty.AllowDBNull = false;
      this.columnSpecialty.MaxLength = 150;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsContactClassSpecialty.lstContactClassSpecialtyRow NewlstContactClassSpecialtyRow()
    {
      return (dsContactClassSpecialty.lstContactClassSpecialtyRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsContactClassSpecialty.lstContactClassSpecialtyRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsContactClassSpecialty.lstContactClassSpecialtyRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstContactClassSpecialtyRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsContactClassSpecialty.lstContactClassSpecialtyRowChangeEventHandler specialtyRowChangedEvent = this.lstContactClassSpecialtyRowChangedEvent;
      if (specialtyRowChangedEvent == null)
        return;
      specialtyRowChangedEvent((object) this, new dsContactClassSpecialty.lstContactClassSpecialtyRowChangeEvent((dsContactClassSpecialty.lstContactClassSpecialtyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstContactClassSpecialtyRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsContactClassSpecialty.lstContactClassSpecialtyRowChangeEventHandler rowChangingEvent = this.lstContactClassSpecialtyRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsContactClassSpecialty.lstContactClassSpecialtyRowChangeEvent((dsContactClassSpecialty.lstContactClassSpecialtyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstContactClassSpecialtyRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsContactClassSpecialty.lstContactClassSpecialtyRowChangeEventHandler specialtyRowDeletedEvent = this.lstContactClassSpecialtyRowDeletedEvent;
      if (specialtyRowDeletedEvent == null)
        return;
      specialtyRowDeletedEvent((object) this, new dsContactClassSpecialty.lstContactClassSpecialtyRowChangeEvent((dsContactClassSpecialty.lstContactClassSpecialtyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstContactClassSpecialtyRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsContactClassSpecialty.lstContactClassSpecialtyRowChangeEventHandler rowDeletingEvent = this.lstContactClassSpecialtyRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsContactClassSpecialty.lstContactClassSpecialtyRowChangeEvent((dsContactClassSpecialty.lstContactClassSpecialtyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstContactClassSpecialtyRow(
      dsContactClassSpecialty.lstContactClassSpecialtyRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsContactClassSpecialty contactClassSpecialty = new dsContactClassSpecialty();
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
        FixedValue = contactClassSpecialty.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstContactClassSpecialtyDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = contactClassSpecialty.GetSchemaSerializable();
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
  public class tblContactClassSpecialtyDataTable : 
    TypedTableBase<dsContactClassSpecialty.tblContactClassSpecialtyRow>
  {
    private DataColumn columnClassSpecialtyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblContactClassSpecialtyDataTable()
    {
      this.TableName = "tblContactClassSpecialty";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblContactClassSpecialtyDataTable(DataTable table)
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
    protected tblContactClassSpecialtyDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassSpecialtyIDColumn => this.columnClassSpecialtyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsContactClassSpecialty.tblContactClassSpecialtyRow this[int index]
    {
      get => (dsContactClassSpecialty.tblContactClassSpecialtyRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsContactClassSpecialty.tblContactClassSpecialtyRowChangeEventHandler tblContactClassSpecialtyRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsContactClassSpecialty.tblContactClassSpecialtyRowChangeEventHandler tblContactClassSpecialtyRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsContactClassSpecialty.tblContactClassSpecialtyRowChangeEventHandler tblContactClassSpecialtyRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsContactClassSpecialty.tblContactClassSpecialtyRowChangeEventHandler tblContactClassSpecialtyRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblContactClassSpecialtyRow(
      dsContactClassSpecialty.tblContactClassSpecialtyRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsContactClassSpecialty.tblContactClassSpecialtyRow AddtblContactClassSpecialtyRow(
      int ClassSpecialtyID)
    {
      dsContactClassSpecialty.tblContactClassSpecialtyRow row = (dsContactClassSpecialty.tblContactClassSpecialtyRow) this.NewRow();
      object[] objArray = new object[1]
      {
        (object) ClassSpecialtyID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsContactClassSpecialty.tblContactClassSpecialtyRow FindByClassSpecialtyID(
      int ClassSpecialtyID)
    {
      return (dsContactClassSpecialty.tblContactClassSpecialtyRow) this.Rows.Find(new object[1]
      {
        (object) ClassSpecialtyID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsContactClassSpecialty.tblContactClassSpecialtyDataTable specialtyDataTable = (dsContactClassSpecialty.tblContactClassSpecialtyDataTable) base.Clone();
      specialtyDataTable.InitVars();
      return (DataTable) specialtyDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsContactClassSpecialty.tblContactClassSpecialtyDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars() => this.columnClassSpecialtyID = this.Columns["ClassSpecialtyID"];

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnClassSpecialtyID = new DataColumn("ClassSpecialtyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassSpecialtyID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnClassSpecialtyID
      }, true));
      this.columnClassSpecialtyID.AllowDBNull = false;
      this.columnClassSpecialtyID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsContactClassSpecialty.tblContactClassSpecialtyRow NewtblContactClassSpecialtyRow()
    {
      return (dsContactClassSpecialty.tblContactClassSpecialtyRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsContactClassSpecialty.tblContactClassSpecialtyRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsContactClassSpecialty.tblContactClassSpecialtyRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblContactClassSpecialtyRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsContactClassSpecialty.tblContactClassSpecialtyRowChangeEventHandler specialtyRowChangedEvent = this.tblContactClassSpecialtyRowChangedEvent;
      if (specialtyRowChangedEvent == null)
        return;
      specialtyRowChangedEvent((object) this, new dsContactClassSpecialty.tblContactClassSpecialtyRowChangeEvent((dsContactClassSpecialty.tblContactClassSpecialtyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblContactClassSpecialtyRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsContactClassSpecialty.tblContactClassSpecialtyRowChangeEventHandler rowChangingEvent = this.tblContactClassSpecialtyRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsContactClassSpecialty.tblContactClassSpecialtyRowChangeEvent((dsContactClassSpecialty.tblContactClassSpecialtyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblContactClassSpecialtyRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsContactClassSpecialty.tblContactClassSpecialtyRowChangeEventHandler specialtyRowDeletedEvent = this.tblContactClassSpecialtyRowDeletedEvent;
      if (specialtyRowDeletedEvent == null)
        return;
      specialtyRowDeletedEvent((object) this, new dsContactClassSpecialty.tblContactClassSpecialtyRowChangeEvent((dsContactClassSpecialty.tblContactClassSpecialtyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblContactClassSpecialtyRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsContactClassSpecialty.tblContactClassSpecialtyRowChangeEventHandler rowDeletingEvent = this.tblContactClassSpecialtyRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsContactClassSpecialty.tblContactClassSpecialtyRowChangeEvent((dsContactClassSpecialty.tblContactClassSpecialtyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblContactClassSpecialtyRow(
      dsContactClassSpecialty.tblContactClassSpecialtyRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsContactClassSpecialty contactClassSpecialty = new dsContactClassSpecialty();
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
        FixedValue = contactClassSpecialty.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblContactClassSpecialtyDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = contactClassSpecialty.GetSchemaSerializable();
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

  public class lstContactClassSpecialtyRow : DataRow
  {
    private dsContactClassSpecialty.lstContactClassSpecialtyDataTable tablelstContactClassSpecialty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstContactClassSpecialtyRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstContactClassSpecialty = (dsContactClassSpecialty.lstContactClassSpecialtyDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ClassSpecialtyID
    {
      get => Conversions.ToInteger(this[this.tablelstContactClassSpecialty.ClassSpecialtyIDColumn]);
      set => this[this.tablelstContactClassSpecialty.ClassSpecialtyIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Specialty
    {
      get => Conversions.ToString(this[this.tablelstContactClassSpecialty.SpecialtyColumn]);
      set => this[this.tablelstContactClassSpecialty.SpecialtyColumn] = (object) value;
    }
  }

  public class tblContactClassSpecialtyRow : DataRow
  {
    private dsContactClassSpecialty.tblContactClassSpecialtyDataTable tabletblContactClassSpecialty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblContactClassSpecialtyRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblContactClassSpecialty = (dsContactClassSpecialty.tblContactClassSpecialtyDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ClassSpecialtyID
    {
      get => Conversions.ToInteger(this[this.tabletblContactClassSpecialty.ClassSpecialtyIDColumn]);
      set => this[this.tabletblContactClassSpecialty.ClassSpecialtyIDColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstContactClassSpecialtyRowChangeEvent : EventArgs
  {
    private dsContactClassSpecialty.lstContactClassSpecialtyRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstContactClassSpecialtyRowChangeEvent(
      dsContactClassSpecialty.lstContactClassSpecialtyRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsContactClassSpecialty.lstContactClassSpecialtyRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblContactClassSpecialtyRowChangeEvent : EventArgs
  {
    private dsContactClassSpecialty.tblContactClassSpecialtyRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblContactClassSpecialtyRowChangeEvent(
      dsContactClassSpecialty.tblContactClassSpecialtyRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsContactClassSpecialty.tblContactClassSpecialtyRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
