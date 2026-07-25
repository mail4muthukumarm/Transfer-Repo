// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.dsPremiumOverride
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

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
namespace MGASystems.IMS.Policies.Rating;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPremiumOverride")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPremiumOverride : DataSet
{
  private dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideDataTable tablespGetQuoteOptionsForPremiumOverride;
  private dsPremiumOverride.tblFin_PolicyChargesDataTable tabletblFin_PolicyCharges;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsPremiumOverride()
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
  protected dsPremiumOverride(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (spGetQuoteOptionsForPremiumOverride)] != null)
          base.Tables.Add((DataTable) new dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideDataTable(dataSet.Tables[nameof (spGetQuoteOptionsForPremiumOverride)]));
        if (dataSet.Tables[nameof (tblFin_PolicyCharges)] != null)
          base.Tables.Add((DataTable) new dsPremiumOverride.tblFin_PolicyChargesDataTable(dataSet.Tables[nameof (tblFin_PolicyCharges)]));
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
  public dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideDataTable spGetQuoteOptionsForPremiumOverride
  {
    get => this.tablespGetQuoteOptionsForPremiumOverride;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPremiumOverride.tblFin_PolicyChargesDataTable tblFin_PolicyCharges
  {
    get => this.tabletblFin_PolicyCharges;
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
    dsPremiumOverride dsPremiumOverride = (dsPremiumOverride) base.Clone();
    dsPremiumOverride.InitVars();
    dsPremiumOverride.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsPremiumOverride;
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
      if (dataSet.Tables["spGetQuoteOptionsForPremiumOverride"] != null)
        base.Tables.Add((DataTable) new dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideDataTable(dataSet.Tables["spGetQuoteOptionsForPremiumOverride"]));
      if (dataSet.Tables["tblFin_PolicyCharges"] != null)
        base.Tables.Add((DataTable) new dsPremiumOverride.tblFin_PolicyChargesDataTable(dataSet.Tables["tblFin_PolicyCharges"]));
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
    this.tablespGetQuoteOptionsForPremiumOverride = (dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideDataTable) base.Tables["spGetQuoteOptionsForPremiumOverride"];
    if (initTable && this.tablespGetQuoteOptionsForPremiumOverride != null)
      this.tablespGetQuoteOptionsForPremiumOverride.InitVars();
    this.tabletblFin_PolicyCharges = (dsPremiumOverride.tblFin_PolicyChargesDataTable) base.Tables["tblFin_PolicyCharges"];
    if (!initTable || this.tabletblFin_PolicyCharges == null)
      return;
    this.tabletblFin_PolicyCharges.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPremiumOverride);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPremiumOverride.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablespGetQuoteOptionsForPremiumOverride = new dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideDataTable();
    base.Tables.Add((DataTable) this.tablespGetQuoteOptionsForPremiumOverride);
    this.tabletblFin_PolicyCharges = new dsPremiumOverride.tblFin_PolicyChargesDataTable();
    base.Tables.Add((DataTable) this.tabletblFin_PolicyCharges);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializespGetQuoteOptionsForPremiumOverride() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblFin_PolicyCharges() => false;

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
    dsPremiumOverride dsPremiumOverride = new dsPremiumOverride();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsPremiumOverride.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsPremiumOverride.GetSchemaSerializable();
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
  public delegate void spGetQuoteOptionsForPremiumOverrideRowChangeEventHandler(
    object sender,
    dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblFin_PolicyChargesRowChangeEventHandler(
    object sender,
    dsPremiumOverride.tblFin_PolicyChargesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class spGetQuoteOptionsForPremiumOverrideDataTable : 
    TypedTableBase<dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow>
  {
    private DataColumn columnDisplay;
    private DataColumn columnQuoteOptionGuid;
    private DataColumn columnOveriddenPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public spGetQuoteOptionsForPremiumOverrideDataTable()
    {
      this.TableName = "spGetQuoteOptionsForPremiumOverride";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal spGetQuoteOptionsForPremiumOverrideDataTable(DataTable table)
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
    protected spGetQuoteOptionsForPremiumOverrideDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DisplayColumn => this.columnDisplay;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteOptionGuidColumn => this.columnQuoteOptionGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OveriddenPremiumColumn => this.columnOveriddenPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow this[int index]
    {
      get => (dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRowChangeEventHandler spGetQuoteOptionsForPremiumOverrideRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRowChangeEventHandler spGetQuoteOptionsForPremiumOverrideRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRowChangeEventHandler spGetQuoteOptionsForPremiumOverrideRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRowChangeEventHandler spGetQuoteOptionsForPremiumOverrideRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddspGetQuoteOptionsForPremiumOverrideRow(
      dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow AddspGetQuoteOptionsForPremiumOverrideRow(
      string Display,
      Guid QuoteOptionGuid,
      Decimal OveriddenPremium)
    {
      dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow row = (dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) Display,
        (object) QuoteOptionGuid,
        (object) OveriddenPremium
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow FindByQuoteOptionGuid(
      Guid QuoteOptionGuid)
    {
      return (dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow) this.Rows.Find(new object[1]
      {
        (object) QuoteOptionGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideDataTable overrideDataTable = (dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideDataTable) base.Clone();
      overrideDataTable.InitVars();
      return (DataTable) overrideDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnDisplay = this.Columns["Display"];
      this.columnQuoteOptionGuid = this.Columns["QuoteOptionGuid"];
      this.columnOveriddenPremium = this.Columns["OveriddenPremium"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnDisplay = new DataColumn("Display", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisplay);
      this.columnQuoteOptionGuid = new DataColumn("QuoteOptionGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionGuid);
      this.columnOveriddenPremium = new DataColumn("OveriddenPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOveriddenPremium);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPremiumOverrideKey1", new DataColumn[1]
      {
        this.columnQuoteOptionGuid
      }, true));
      this.columnDisplay.ReadOnly = true;
      this.columnQuoteOptionGuid.AllowDBNull = false;
      this.columnQuoteOptionGuid.Unique = true;
      this.columnOveriddenPremium.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow NewspGetQuoteOptionsForPremiumOverrideRow()
    {
      return (dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spGetQuoteOptionsForPremiumOverrideRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRowChangeEventHandler overrideRowChangedEvent = this.spGetQuoteOptionsForPremiumOverrideRowChangedEvent;
      if (overrideRowChangedEvent == null)
        return;
      overrideRowChangedEvent((object) this, new dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRowChangeEvent((dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spGetQuoteOptionsForPremiumOverrideRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRowChangeEventHandler rowChangingEvent = this.spGetQuoteOptionsForPremiumOverrideRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRowChangeEvent((dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spGetQuoteOptionsForPremiumOverrideRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRowChangeEventHandler overrideRowDeletedEvent = this.spGetQuoteOptionsForPremiumOverrideRowDeletedEvent;
      if (overrideRowDeletedEvent == null)
        return;
      overrideRowDeletedEvent((object) this, new dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRowChangeEvent((dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spGetQuoteOptionsForPremiumOverrideRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRowChangeEventHandler rowDeletingEvent = this.spGetQuoteOptionsForPremiumOverrideRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRowChangeEvent((dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovespGetQuoteOptionsForPremiumOverrideRow(
      dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPremiumOverride dsPremiumOverride = new dsPremiumOverride();
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
        FixedValue = dsPremiumOverride.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (spGetQuoteOptionsForPremiumOverrideDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPremiumOverride.GetSchemaSerializable();
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
  public class tblFin_PolicyChargesDataTable : 
    TypedTableBase<dsPremiumOverride.tblFin_PolicyChargesRow>
  {
    private DataColumn columnChargeCode;
    private DataColumn columnChargeName;
    private DataColumn columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblFin_PolicyChargesDataTable()
    {
      this.TableName = "tblFin_PolicyCharges";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblFin_PolicyChargesDataTable(DataTable table)
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
    protected tblFin_PolicyChargesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumOverride.tblFin_PolicyChargesRow this[int index]
    {
      get => (dsPremiumOverride.tblFin_PolicyChargesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumOverride.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumOverride.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumOverride.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPremiumOverride.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblFin_PolicyChargesRow(dsPremiumOverride.tblFin_PolicyChargesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumOverride.tblFin_PolicyChargesRow AddtblFin_PolicyChargesRow(
      string ChargeName,
      string StateID)
    {
      dsPremiumOverride.tblFin_PolicyChargesRow row = (dsPremiumOverride.tblFin_PolicyChargesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) ChargeName,
        (object) StateID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumOverride.tblFin_PolicyChargesRow FindByChargeCode(int ChargeCode)
    {
      return (dsPremiumOverride.tblFin_PolicyChargesRow) this.Rows.Find(new object[1]
      {
        (object) ChargeCode
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPremiumOverride.tblFin_PolicyChargesDataTable chargesDataTable = (dsPremiumOverride.tblFin_PolicyChargesDataTable) base.Clone();
      chargesDataTable.InitVars();
      return (DataTable) chargesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPremiumOverride.tblFin_PolicyChargesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnStateID = this.Columns["StateID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsRaterGenericKey2", new DataColumn[1]
      {
        this.columnChargeCode
      }, true));
      this.columnChargeCode.AutoIncrement = true;
      this.columnChargeCode.AllowDBNull = false;
      this.columnChargeCode.ReadOnly = true;
      this.columnChargeCode.Unique = true;
      this.columnChargeName.AllowDBNull = false;
      this.columnStateID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumOverride.tblFin_PolicyChargesRow NewtblFin_PolicyChargesRow()
    {
      return (dsPremiumOverride.tblFin_PolicyChargesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPremiumOverride.tblFin_PolicyChargesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPremiumOverride.tblFin_PolicyChargesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumOverride.tblFin_PolicyChargesRowChangeEventHandler chargesRowChangedEvent = this.tblFin_PolicyChargesRowChangedEvent;
      if (chargesRowChangedEvent == null)
        return;
      chargesRowChangedEvent((object) this, new dsPremiumOverride.tblFin_PolicyChargesRowChangeEvent((dsPremiumOverride.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumOverride.tblFin_PolicyChargesRowChangeEventHandler rowChangingEvent = this.tblFin_PolicyChargesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPremiumOverride.tblFin_PolicyChargesRowChangeEvent((dsPremiumOverride.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumOverride.tblFin_PolicyChargesRowChangeEventHandler chargesRowDeletedEvent = this.tblFin_PolicyChargesRowDeletedEvent;
      if (chargesRowDeletedEvent == null)
        return;
      chargesRowDeletedEvent((object) this, new dsPremiumOverride.tblFin_PolicyChargesRowChangeEvent((dsPremiumOverride.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPremiumOverride.tblFin_PolicyChargesRowChangeEventHandler rowDeletingEvent = this.tblFin_PolicyChargesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPremiumOverride.tblFin_PolicyChargesRowChangeEvent((dsPremiumOverride.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblFin_PolicyChargesRow(dsPremiumOverride.tblFin_PolicyChargesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPremiumOverride dsPremiumOverride = new dsPremiumOverride();
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
        FixedValue = dsPremiumOverride.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblFin_PolicyChargesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPremiumOverride.GetSchemaSerializable();
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

  public class spGetQuoteOptionsForPremiumOverrideRow : DataRow
  {
    private dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideDataTable tablespGetQuoteOptionsForPremiumOverride;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal spGetQuoteOptionsForPremiumOverrideRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespGetQuoteOptionsForPremiumOverride = (dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Display
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespGetQuoteOptionsForPremiumOverride.DisplayColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Display' in table 'spGetQuoteOptionsForPremiumOverride' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespGetQuoteOptionsForPremiumOverride.DisplayColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuoteOptionGuid
    {
      get
      {
        object obj = this[this.tablespGetQuoteOptionsForPremiumOverride.QuoteOptionGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set
      {
        this[this.tablespGetQuoteOptionsForPremiumOverride.QuoteOptionGuidColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal OveriddenPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespGetQuoteOptionsForPremiumOverride.OveriddenPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OveriddenPremium' in table 'spGetQuoteOptionsForPremiumOverride' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablespGetQuoteOptionsForPremiumOverride.OveriddenPremiumColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDisplayNull()
    {
      return this.IsNull(this.tablespGetQuoteOptionsForPremiumOverride.DisplayColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDisplayNull()
    {
      this[this.tablespGetQuoteOptionsForPremiumOverride.DisplayColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOveriddenPremiumNull()
    {
      return this.IsNull(this.tablespGetQuoteOptionsForPremiumOverride.OveriddenPremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOveriddenPremiumNull()
    {
      this[this.tablespGetQuoteOptionsForPremiumOverride.OveriddenPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblFin_PolicyChargesRow : DataRow
  {
    private dsPremiumOverride.tblFin_PolicyChargesDataTable tabletblFin_PolicyCharges;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblFin_PolicyChargesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblFin_PolicyCharges = (dsPremiumOverride.tblFin_PolicyChargesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tabletblFin_PolicyCharges.ChargeCodeColumn]);
      set => this[this.tabletblFin_PolicyCharges.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ChargeName
    {
      get => Conversions.ToString(this[this.tabletblFin_PolicyCharges.ChargeNameColumn]);
      set => this[this.tabletblFin_PolicyCharges.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tabletblFin_PolicyCharges.StateIDColumn]);
      set => this[this.tabletblFin_PolicyCharges.StateIDColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class spGetQuoteOptionsForPremiumOverrideRowChangeEvent : EventArgs
  {
    private dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public spGetQuoteOptionsForPremiumOverrideRowChangeEvent(
      dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumOverride.spGetQuoteOptionsForPremiumOverrideRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblFin_PolicyChargesRowChangeEvent : EventArgs
  {
    private dsPremiumOverride.tblFin_PolicyChargesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblFin_PolicyChargesRowChangeEvent(
      dsPremiumOverride.tblFin_PolicyChargesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPremiumOverride.tblFin_PolicyChargesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
