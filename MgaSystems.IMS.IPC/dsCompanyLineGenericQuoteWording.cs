// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.dsCompanyLineGenericQuoteWording
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
[XmlRoot("dsCompanyLineGenericQuoteWording")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyLineGenericQuoteWording : DataSet
{
  private dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingDataTable tabletblCompanyLineGenericQuoteWording;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsCompanyLineGenericQuoteWording()
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
  protected dsCompanyLineGenericQuoteWording(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyLineGenericQuoteWording)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingDataTable(dataSet.Tables[nameof (tblCompanyLineGenericQuoteWording)]));
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
  public dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingDataTable tblCompanyLineGenericQuoteWording
  {
    get => this.tabletblCompanyLineGenericQuoteWording;
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
    dsCompanyLineGenericQuoteWording genericQuoteWording = (dsCompanyLineGenericQuoteWording) base.Clone();
    genericQuoteWording.InitVars();
    genericQuoteWording.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) genericQuoteWording;
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
      if (dataSet.Tables["tblCompanyLineGenericQuoteWording"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingDataTable(dataSet.Tables["tblCompanyLineGenericQuoteWording"]));
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
    this.tabletblCompanyLineGenericQuoteWording = (dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingDataTable) base.Tables["tblCompanyLineGenericQuoteWording"];
    if (!initTable || this.tabletblCompanyLineGenericQuoteWording == null)
      return;
    this.tabletblCompanyLineGenericQuoteWording.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyLineGenericQuoteWording);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsCompanyLineGenericQuoteWording.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyLineGenericQuoteWording = new dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLineGenericQuoteWording);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyLineGenericQuoteWording() => false;

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
    dsCompanyLineGenericQuoteWording genericQuoteWording = new dsCompanyLineGenericQuoteWording();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = genericQuoteWording.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = genericQuoteWording.GetSchemaSerializable();
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
  public delegate void tblCompanyLineGenericQuoteWordingRowChangeEventHandler(
    object sender,
    dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyLineGenericQuoteWordingDataTable : 
    TypedTableBase<dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow>
  {
    private DataColumn columnQuoteWordingID;
    private DataColumn columnCompanyLineID;
    private DataColumn columnPerils;
    private DataColumn columnCovering;
    private DataColumn columnValuation;
    private DataColumn columnExcluding;
    private DataColumn columnComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLineGenericQuoteWordingDataTable()
    {
      this.TableName = "tblCompanyLineGenericQuoteWording";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLineGenericQuoteWordingDataTable(DataTable table)
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
    protected tblCompanyLineGenericQuoteWordingDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteWordingIDColumn => this.columnQuoteWordingID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineIDColumn => this.columnCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PerilsColumn => this.columnPerils;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CoveringColumn => this.columnCovering;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ValuationColumn => this.columnValuation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExcludingColumn => this.columnExcluding;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CommentsColumn => this.columnComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow this[int index]
    {
      get
      {
        return (dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow) this.Rows[index];
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRowChangeEventHandler tblCompanyLineGenericQuoteWordingRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRowChangeEventHandler tblCompanyLineGenericQuoteWordingRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRowChangeEventHandler tblCompanyLineGenericQuoteWordingRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRowChangeEventHandler tblCompanyLineGenericQuoteWordingRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyLineGenericQuoteWordingRow(
      dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow AddtblCompanyLineGenericQuoteWordingRow(
      int CompanyLineID,
      string Perils,
      string Covering,
      string Valuation,
      string Excluding,
      string Comments)
    {
      dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow row = (dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        (object) CompanyLineID,
        (object) Perils,
        (object) Covering,
        (object) Valuation,
        (object) Excluding,
        (object) Comments
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow FindByQuoteWordingID(
      int QuoteWordingID)
    {
      return (dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow) this.Rows.Find(new object[1]
      {
        (object) QuoteWordingID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingDataTable wordingDataTable = (dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingDataTable) base.Clone();
      wordingDataTable.InitVars();
      return (DataTable) wordingDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteWordingID = this.Columns["QuoteWordingID"];
      this.columnCompanyLineID = this.Columns["CompanyLineID"];
      this.columnPerils = this.Columns["Perils"];
      this.columnCovering = this.Columns["Covering"];
      this.columnValuation = this.Columns["Valuation"];
      this.columnExcluding = this.Columns["Excluding"];
      this.columnComments = this.Columns["Comments"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteWordingID = new DataColumn("QuoteWordingID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteWordingID);
      this.columnCompanyLineID = new DataColumn("CompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineID);
      this.columnPerils = new DataColumn("Perils", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPerils);
      this.columnCovering = new DataColumn("Covering", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCovering);
      this.columnValuation = new DataColumn("Valuation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnValuation);
      this.columnExcluding = new DataColumn("Excluding", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExcluding);
      this.columnComments = new DataColumn("Comments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComments);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyLineGenericQuoteWordingKey1", new DataColumn[1]
      {
        this.columnQuoteWordingID
      }, true));
      this.columnQuoteWordingID.AutoIncrement = true;
      this.columnQuoteWordingID.AllowDBNull = false;
      this.columnQuoteWordingID.ReadOnly = true;
      this.columnQuoteWordingID.Unique = true;
      this.columnCompanyLineID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow NewtblCompanyLineGenericQuoteWordingRow()
    {
      return (dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineGenericQuoteWordingRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRowChangeEventHandler wordingRowChangedEvent = this.tblCompanyLineGenericQuoteWordingRowChangedEvent;
      if (wordingRowChangedEvent == null)
        return;
      wordingRowChangedEvent((object) this, new dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRowChangeEvent((dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineGenericQuoteWordingRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRowChangeEventHandler rowChangingEvent = this.tblCompanyLineGenericQuoteWordingRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRowChangeEvent((dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineGenericQuoteWordingRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRowChangeEventHandler wordingRowDeletedEvent = this.tblCompanyLineGenericQuoteWordingRowDeletedEvent;
      if (wordingRowDeletedEvent == null)
        return;
      wordingRowDeletedEvent((object) this, new dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRowChangeEvent((dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineGenericQuoteWordingRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRowChangeEventHandler rowDeletingEvent = this.tblCompanyLineGenericQuoteWordingRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRowChangeEvent((dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyLineGenericQuoteWordingRow(
      dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineGenericQuoteWording genericQuoteWording = new dsCompanyLineGenericQuoteWording();
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
        FixedValue = genericQuoteWording.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLineGenericQuoteWordingDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = genericQuoteWording.GetSchemaSerializable();
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

  public class tblCompanyLineGenericQuoteWordingRow : DataRow
  {
    private dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingDataTable tabletblCompanyLineGenericQuoteWording;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLineGenericQuoteWordingRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLineGenericQuoteWording = (dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteWordingID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyLineGenericQuoteWording.QuoteWordingIDColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineGenericQuoteWording.QuoteWordingIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int CompanyLineID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyLineGenericQuoteWording.CompanyLineIDColumn]);
      }
      set => this[this.tabletblCompanyLineGenericQuoteWording.CompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Perils
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLineGenericQuoteWording.PerilsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Perils' in table 'tblCompanyLineGenericQuoteWording' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineGenericQuoteWording.PerilsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Covering
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLineGenericQuoteWording.CoveringColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Covering' in table 'tblCompanyLineGenericQuoteWording' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineGenericQuoteWording.CoveringColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Valuation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLineGenericQuoteWording.ValuationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Valuation' in table 'tblCompanyLineGenericQuoteWording' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineGenericQuoteWording.ValuationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Excluding
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLineGenericQuoteWording.ExcludingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Excluding' in table 'tblCompanyLineGenericQuoteWording' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineGenericQuoteWording.ExcludingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Comments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLineGenericQuoteWording.CommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Comments' in table 'tblCompanyLineGenericQuoteWording' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineGenericQuoteWording.CommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPerilsNull()
    {
      return this.IsNull(this.tabletblCompanyLineGenericQuoteWording.PerilsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPerilsNull()
    {
      this[this.tabletblCompanyLineGenericQuoteWording.PerilsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCoveringNull()
    {
      return this.IsNull(this.tabletblCompanyLineGenericQuoteWording.CoveringColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCoveringNull()
    {
      this[this.tabletblCompanyLineGenericQuoteWording.CoveringColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsValuationNull()
    {
      return this.IsNull(this.tabletblCompanyLineGenericQuoteWording.ValuationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetValuationNull()
    {
      this[this.tabletblCompanyLineGenericQuoteWording.ValuationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExcludingNull()
    {
      return this.IsNull(this.tabletblCompanyLineGenericQuoteWording.ExcludingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExcludingNull()
    {
      this[this.tabletblCompanyLineGenericQuoteWording.ExcludingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCommentsNull()
    {
      return this.IsNull(this.tabletblCompanyLineGenericQuoteWording.CommentsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCommentsNull()
    {
      this[this.tabletblCompanyLineGenericQuoteWording.CommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyLineGenericQuoteWordingRowChangeEvent : EventArgs
  {
    private dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLineGenericQuoteWordingRowChangeEvent(
      dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineGenericQuoteWording.tblCompanyLineGenericQuoteWordingRow Row
    {
      get => this.eventRow;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
