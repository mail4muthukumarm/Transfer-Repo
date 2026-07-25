// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.dsPersonalUmbrella
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
[XmlRoot("dsPersonalUmbrella")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPersonalUmbrella : DataSet
{
  private dsPersonalUmbrella.tblQuoteOptionsDataTable tabletblQuoteOptions;
  private dsPersonalUmbrella.tblPersonalUmbrellaDataTable tabletblPersonalUmbrella;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsPersonalUmbrella()
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
  protected dsPersonalUmbrella(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblQuoteOptions)] != null)
          base.Tables.Add((DataTable) new dsPersonalUmbrella.tblQuoteOptionsDataTable(dataSet.Tables[nameof (tblQuoteOptions)]));
        if (dataSet.Tables[nameof (tblPersonalUmbrella)] != null)
          base.Tables.Add((DataTable) new dsPersonalUmbrella.tblPersonalUmbrellaDataTable(dataSet.Tables[nameof (tblPersonalUmbrella)]));
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
  public dsPersonalUmbrella.tblQuoteOptionsDataTable tblQuoteOptions => this.tabletblQuoteOptions;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPersonalUmbrella.tblPersonalUmbrellaDataTable tblPersonalUmbrella
  {
    get => this.tabletblPersonalUmbrella;
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
    dsPersonalUmbrella personalUmbrella = (dsPersonalUmbrella) base.Clone();
    personalUmbrella.InitVars();
    personalUmbrella.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) personalUmbrella;
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
      if (dataSet.Tables["tblQuoteOptions"] != null)
        base.Tables.Add((DataTable) new dsPersonalUmbrella.tblQuoteOptionsDataTable(dataSet.Tables["tblQuoteOptions"]));
      if (dataSet.Tables["tblPersonalUmbrella"] != null)
        base.Tables.Add((DataTable) new dsPersonalUmbrella.tblPersonalUmbrellaDataTable(dataSet.Tables["tblPersonalUmbrella"]));
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
    this.tabletblQuoteOptions = (dsPersonalUmbrella.tblQuoteOptionsDataTable) base.Tables["tblQuoteOptions"];
    if (initTable && this.tabletblQuoteOptions != null)
      this.tabletblQuoteOptions.InitVars();
    this.tabletblPersonalUmbrella = (dsPersonalUmbrella.tblPersonalUmbrellaDataTable) base.Tables["tblPersonalUmbrella"];
    if (!initTable || this.tabletblPersonalUmbrella == null)
      return;
    this.tabletblPersonalUmbrella.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPersonalUmbrella);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPersonalUmbrella.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblQuoteOptions = new dsPersonalUmbrella.tblQuoteOptionsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptions);
    this.tabletblPersonalUmbrella = new dsPersonalUmbrella.tblPersonalUmbrellaDataTable();
    base.Tables.Add((DataTable) this.tabletblPersonalUmbrella);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblQuoteOptions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblPersonalUmbrella() => false;

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
    dsPersonalUmbrella personalUmbrella = new dsPersonalUmbrella();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = personalUmbrella.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = personalUmbrella.GetSchemaSerializable();
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
  public delegate void tblQuoteOptionsRowChangeEventHandler(
    object sender,
    dsPersonalUmbrella.tblQuoteOptionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblPersonalUmbrellaRowChangeEventHandler(
    object sender,
    dsPersonalUmbrella.tblPersonalUmbrellaRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblQuoteOptionsDataTable : TypedTableBase<dsPersonalUmbrella.tblQuoteOptionsRow>
  {
    private DataColumn columnQuoteOptionID;
    private DataColumn columnQuoteOptionGUID;
    private DataColumn columnQuoteGUID;
    private DataColumn columnLineGUID;
    private DataColumn columnDateCreated;
    private DataColumn columnAdditionalComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionsDataTable()
    {
      this.TableName = "tblQuoteOptions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionsDataTable(DataTable table)
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
    protected tblQuoteOptionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteOptionIDColumn => this.columnQuoteOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteOptionGUIDColumn => this.columnQuoteOptionGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteGUIDColumn => this.columnQuoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LineGUIDColumn => this.columnLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateCreatedColumn => this.columnDateCreated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AdditionalCommentsColumn => this.columnAdditionalComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPersonalUmbrella.tblQuoteOptionsRow this[int index]
    {
      get => (dsPersonalUmbrella.tblQuoteOptionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPersonalUmbrella.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPersonalUmbrella.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPersonalUmbrella.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPersonalUmbrella.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteOptionsRow(dsPersonalUmbrella.tblQuoteOptionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPersonalUmbrella.tblQuoteOptionsRow AddtblQuoteOptionsRow(
      Guid QuoteOptionGUID,
      Guid QuoteGUID,
      Guid LineGUID,
      DateTime DateCreated,
      string AdditionalComments)
    {
      dsPersonalUmbrella.tblQuoteOptionsRow row = (dsPersonalUmbrella.tblQuoteOptionsRow) this.NewRow();
      object[] objArray = new object[6]
      {
        null,
        (object) QuoteOptionGUID,
        (object) QuoteGUID,
        (object) LineGUID,
        (object) DateCreated,
        (object) AdditionalComments
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPersonalUmbrella.tblQuoteOptionsRow FindByQuoteOptionID(int QuoteOptionID)
    {
      return (dsPersonalUmbrella.tblQuoteOptionsRow) this.Rows.Find(new object[1]
      {
        (object) QuoteOptionID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPersonalUmbrella.tblQuoteOptionsDataTable optionsDataTable = (dsPersonalUmbrella.tblQuoteOptionsDataTable) base.Clone();
      optionsDataTable.InitVars();
      return (DataTable) optionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPersonalUmbrella.tblQuoteOptionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteOptionID = this.Columns["QuoteOptionID"];
      this.columnQuoteOptionGUID = this.Columns["QuoteOptionGUID"];
      this.columnQuoteGUID = this.Columns["QuoteGUID"];
      this.columnLineGUID = this.Columns["LineGUID"];
      this.columnDateCreated = this.Columns["DateCreated"];
      this.columnAdditionalComments = this.Columns["AdditionalComments"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteOptionID = new DataColumn("QuoteOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionID);
      this.columnQuoteOptionGUID = new DataColumn("QuoteOptionGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionGUID);
      this.columnQuoteGUID = new DataColumn("QuoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGUID);
      this.columnLineGUID = new DataColumn("LineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGUID);
      this.columnDateCreated = new DataColumn("DateCreated", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateCreated);
      this.columnAdditionalComments = new DataColumn("AdditionalComments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalComments);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnQuoteOptionID
      }, true));
      this.columnQuoteOptionID.AutoIncrement = true;
      this.columnQuoteOptionID.AllowDBNull = false;
      this.columnQuoteOptionID.ReadOnly = true;
      this.columnQuoteOptionID.Unique = true;
      this.columnQuoteOptionGUID.AllowDBNull = false;
      this.columnQuoteGUID.AllowDBNull = false;
      this.columnLineGUID.AllowDBNull = false;
      this.columnDateCreated.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPersonalUmbrella.tblQuoteOptionsRow NewtblQuoteOptionsRow()
    {
      return (dsPersonalUmbrella.tblQuoteOptionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPersonalUmbrella.tblQuoteOptionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPersonalUmbrella.tblQuoteOptionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPersonalUmbrella.tblQuoteOptionsRowChangeEventHandler optionsRowChangedEvent = this.tblQuoteOptionsRowChangedEvent;
      if (optionsRowChangedEvent == null)
        return;
      optionsRowChangedEvent((object) this, new dsPersonalUmbrella.tblQuoteOptionsRowChangeEvent((dsPersonalUmbrella.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPersonalUmbrella.tblQuoteOptionsRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPersonalUmbrella.tblQuoteOptionsRowChangeEvent((dsPersonalUmbrella.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPersonalUmbrella.tblQuoteOptionsRowChangeEventHandler optionsRowDeletedEvent = this.tblQuoteOptionsRowDeletedEvent;
      if (optionsRowDeletedEvent == null)
        return;
      optionsRowDeletedEvent((object) this, new dsPersonalUmbrella.tblQuoteOptionsRowChangeEvent((dsPersonalUmbrella.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPersonalUmbrella.tblQuoteOptionsRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPersonalUmbrella.tblQuoteOptionsRowChangeEvent((dsPersonalUmbrella.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteOptionsRow(dsPersonalUmbrella.tblQuoteOptionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPersonalUmbrella personalUmbrella = new dsPersonalUmbrella();
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
        FixedValue = personalUmbrella.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = personalUmbrella.GetSchemaSerializable();
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
  public class tblPersonalUmbrellaDataTable : 
    TypedTableBase<dsPersonalUmbrella.tblPersonalUmbrellaRow>
  {
    private DataColumn columnPersUmID;
    private DataColumn columnQuoteOptionID;
    private DataColumn columnOccLimit;
    private DataColumn columnAggLimit;
    private DataColumn columnSIR;
    private DataColumn columnPremium;
    private DataColumn columnTerrorism;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblPersonalUmbrellaDataTable()
    {
      this.TableName = "tblPersonalUmbrella";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblPersonalUmbrellaDataTable(DataTable table)
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
    protected tblPersonalUmbrellaDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PersUmIDColumn => this.columnPersUmID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteOptionIDColumn => this.columnQuoteOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OccLimitColumn => this.columnOccLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AggLimitColumn => this.columnAggLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SIRColumn => this.columnSIR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TerrorismColumn => this.columnTerrorism;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPersonalUmbrella.tblPersonalUmbrellaRow this[int index]
    {
      get => (dsPersonalUmbrella.tblPersonalUmbrellaRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPersonalUmbrella.tblPersonalUmbrellaRowChangeEventHandler tblPersonalUmbrellaRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPersonalUmbrella.tblPersonalUmbrellaRowChangeEventHandler tblPersonalUmbrellaRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPersonalUmbrella.tblPersonalUmbrellaRowChangeEventHandler tblPersonalUmbrellaRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPersonalUmbrella.tblPersonalUmbrellaRowChangeEventHandler tblPersonalUmbrellaRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblPersonalUmbrellaRow(dsPersonalUmbrella.tblPersonalUmbrellaRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPersonalUmbrella.tblPersonalUmbrellaRow AddtblPersonalUmbrellaRow(
      int QuoteOptionID,
      int OccLimit,
      int AggLimit,
      int SIR,
      int Premium,
      int Terrorism)
    {
      dsPersonalUmbrella.tblPersonalUmbrellaRow row = (dsPersonalUmbrella.tblPersonalUmbrellaRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        (object) QuoteOptionID,
        (object) OccLimit,
        (object) AggLimit,
        (object) SIR,
        (object) Premium,
        (object) Terrorism
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPersonalUmbrella.tblPersonalUmbrellaRow FindByPersUmID(int PersUmID)
    {
      return (dsPersonalUmbrella.tblPersonalUmbrellaRow) this.Rows.Find(new object[1]
      {
        (object) PersUmID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPersonalUmbrella.tblPersonalUmbrellaDataTable umbrellaDataTable = (dsPersonalUmbrella.tblPersonalUmbrellaDataTable) base.Clone();
      umbrellaDataTable.InitVars();
      return (DataTable) umbrellaDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPersonalUmbrella.tblPersonalUmbrellaDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnPersUmID = this.Columns["PersUmID"];
      this.columnQuoteOptionID = this.Columns["QuoteOptionID"];
      this.columnOccLimit = this.Columns["OccLimit"];
      this.columnAggLimit = this.Columns["AggLimit"];
      this.columnSIR = this.Columns["SIR"];
      this.columnPremium = this.Columns["Premium"];
      this.columnTerrorism = this.Columns["Terrorism"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnPersUmID = new DataColumn("PersUmID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPersUmID);
      this.columnQuoteOptionID = new DataColumn("QuoteOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionID);
      this.columnOccLimit = new DataColumn("OccLimit", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOccLimit);
      this.columnAggLimit = new DataColumn("AggLimit", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAggLimit);
      this.columnSIR = new DataColumn("SIR", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIR);
      this.columnPremium = new DataColumn("Premium", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnTerrorism = new DataColumn("Terrorism", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrorism);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnPersUmID
      }, true));
      this.columnPersUmID.AutoIncrement = true;
      this.columnPersUmID.AllowDBNull = false;
      this.columnPersUmID.ReadOnly = true;
      this.columnPersUmID.Unique = true;
      this.columnQuoteOptionID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPersonalUmbrella.tblPersonalUmbrellaRow NewtblPersonalUmbrellaRow()
    {
      return (dsPersonalUmbrella.tblPersonalUmbrellaRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPersonalUmbrella.tblPersonalUmbrellaRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPersonalUmbrella.tblPersonalUmbrellaRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPersonalUmbrellaRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPersonalUmbrella.tblPersonalUmbrellaRowChangeEventHandler umbrellaRowChangedEvent = this.tblPersonalUmbrellaRowChangedEvent;
      if (umbrellaRowChangedEvent == null)
        return;
      umbrellaRowChangedEvent((object) this, new dsPersonalUmbrella.tblPersonalUmbrellaRowChangeEvent((dsPersonalUmbrella.tblPersonalUmbrellaRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPersonalUmbrellaRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPersonalUmbrella.tblPersonalUmbrellaRowChangeEventHandler rowChangingEvent = this.tblPersonalUmbrellaRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPersonalUmbrella.tblPersonalUmbrellaRowChangeEvent((dsPersonalUmbrella.tblPersonalUmbrellaRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPersonalUmbrellaRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPersonalUmbrella.tblPersonalUmbrellaRowChangeEventHandler umbrellaRowDeletedEvent = this.tblPersonalUmbrellaRowDeletedEvent;
      if (umbrellaRowDeletedEvent == null)
        return;
      umbrellaRowDeletedEvent((object) this, new dsPersonalUmbrella.tblPersonalUmbrellaRowChangeEvent((dsPersonalUmbrella.tblPersonalUmbrellaRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPersonalUmbrellaRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPersonalUmbrella.tblPersonalUmbrellaRowChangeEventHandler rowDeletingEvent = this.tblPersonalUmbrellaRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPersonalUmbrella.tblPersonalUmbrellaRowChangeEvent((dsPersonalUmbrella.tblPersonalUmbrellaRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblPersonalUmbrellaRow(dsPersonalUmbrella.tblPersonalUmbrellaRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPersonalUmbrella personalUmbrella = new dsPersonalUmbrella();
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
        FixedValue = personalUmbrella.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblPersonalUmbrellaDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = personalUmbrella.GetSchemaSerializable();
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

  public class tblQuoteOptionsRow : DataRow
  {
    private dsPersonalUmbrella.tblQuoteOptionsDataTable tabletblQuoteOptions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptions = (dsPersonalUmbrella.tblQuoteOptionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteOptionID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptions.QuoteOptionIDColumn]);
      set => this[this.tabletblQuoteOptions.QuoteOptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuoteOptionGUID
    {
      get
      {
        object obj = this[this.tabletblQuoteOptions.QuoteOptionGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptions.QuoteOptionGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuoteGUID
    {
      get
      {
        object obj = this[this.tabletblQuoteOptions.QuoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptions.QuoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid LineGUID
    {
      get
      {
        object obj = this[this.tabletblQuoteOptions.LineGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptions.LineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateCreated
    {
      get => Conversions.ToDate(this[this.tabletblQuoteOptions.DateCreatedColumn]);
      set => this[this.tabletblQuoteOptions.DateCreatedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AdditionalComments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptions.AdditionalCommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdditionalComments' in table 'tblQuoteOptions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptions.AdditionalCommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAdditionalCommentsNull()
    {
      return this.IsNull(this.tabletblQuoteOptions.AdditionalCommentsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAdditionalCommentsNull()
    {
      this[this.tabletblQuoteOptions.AdditionalCommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblPersonalUmbrellaRow : DataRow
  {
    private dsPersonalUmbrella.tblPersonalUmbrellaDataTable tabletblPersonalUmbrella;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblPersonalUmbrellaRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblPersonalUmbrella = (dsPersonalUmbrella.tblPersonalUmbrellaDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int PersUmID
    {
      get => Conversions.ToInteger(this[this.tabletblPersonalUmbrella.PersUmIDColumn]);
      set => this[this.tabletblPersonalUmbrella.PersUmIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteOptionID
    {
      get => Conversions.ToInteger(this[this.tabletblPersonalUmbrella.QuoteOptionIDColumn]);
      set => this[this.tabletblPersonalUmbrella.QuoteOptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OccLimit
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPersonalUmbrella.OccLimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OccLimit' in table 'tblPersonalUmbrella' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPersonalUmbrella.OccLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int AggLimit
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPersonalUmbrella.AggLimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AggLimit' in table 'tblPersonalUmbrella' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPersonalUmbrella.AggLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int SIR
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPersonalUmbrella.SIRColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SIR' in table 'tblPersonalUmbrella' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPersonalUmbrella.SIRColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Premium
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPersonalUmbrella.PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Premium' in table 'tblPersonalUmbrella' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPersonalUmbrella.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Terrorism
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPersonalUmbrella.TerrorismColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Terrorism' in table 'tblPersonalUmbrella' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPersonalUmbrella.TerrorismColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOccLimitNull() => this.IsNull(this.tabletblPersonalUmbrella.OccLimitColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOccLimitNull()
    {
      this[this.tabletblPersonalUmbrella.OccLimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAggLimitNull() => this.IsNull(this.tabletblPersonalUmbrella.AggLimitColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAggLimitNull()
    {
      this[this.tabletblPersonalUmbrella.AggLimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSIRNull() => this.IsNull(this.tabletblPersonalUmbrella.SIRColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSIRNull()
    {
      this[this.tabletblPersonalUmbrella.SIRColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tabletblPersonalUmbrella.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tabletblPersonalUmbrella.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTerrorismNull() => this.IsNull(this.tabletblPersonalUmbrella.TerrorismColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTerrorismNull()
    {
      this[this.tabletblPersonalUmbrella.TerrorismColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteOptionsRowChangeEvent : EventArgs
  {
    private dsPersonalUmbrella.tblQuoteOptionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionsRowChangeEvent(
      dsPersonalUmbrella.tblQuoteOptionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPersonalUmbrella.tblQuoteOptionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblPersonalUmbrellaRowChangeEvent : EventArgs
  {
    private dsPersonalUmbrella.tblPersonalUmbrellaRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblPersonalUmbrellaRowChangeEvent(
      dsPersonalUmbrella.tblPersonalUmbrellaRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPersonalUmbrella.tblPersonalUmbrellaRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
