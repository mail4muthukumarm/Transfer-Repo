// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.dsQuoteDetailRaters
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
[XmlRoot("dsQuoteDetailRaters")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsQuoteDetailRaters : DataSet
{
  private dsQuoteDetailRaters.lstRatingTypesDataTable tablelstRatingTypes;
  private dsQuoteDetailRaters.tblFactorSetsDataTable tabletblFactorSets;
  private DataRelation relationlstRatingTypestblFactorSets;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsQuoteDetailRaters()
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
  protected dsQuoteDetailRaters(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstRatingTypes)] != null)
          base.Tables.Add((DataTable) new dsQuoteDetailRaters.lstRatingTypesDataTable(dataSet.Tables[nameof (lstRatingTypes)]));
        if (dataSet.Tables[nameof (tblFactorSets)] != null)
          base.Tables.Add((DataTable) new dsQuoteDetailRaters.tblFactorSetsDataTable(dataSet.Tables[nameof (tblFactorSets)]));
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
  public dsQuoteDetailRaters.lstRatingTypesDataTable lstRatingTypes => this.tablelstRatingTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuoteDetailRaters.tblFactorSetsDataTable tblFactorSets => this.tabletblFactorSets;

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
    dsQuoteDetailRaters quoteDetailRaters = (dsQuoteDetailRaters) base.Clone();
    quoteDetailRaters.InitVars();
    quoteDetailRaters.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) quoteDetailRaters;
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
      if (dataSet.Tables["lstRatingTypes"] != null)
        base.Tables.Add((DataTable) new dsQuoteDetailRaters.lstRatingTypesDataTable(dataSet.Tables["lstRatingTypes"]));
      if (dataSet.Tables["tblFactorSets"] != null)
        base.Tables.Add((DataTable) new dsQuoteDetailRaters.tblFactorSetsDataTable(dataSet.Tables["tblFactorSets"]));
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
    this.tablelstRatingTypes = (dsQuoteDetailRaters.lstRatingTypesDataTable) base.Tables["lstRatingTypes"];
    if (initTable && this.tablelstRatingTypes != null)
      this.tablelstRatingTypes.InitVars();
    this.tabletblFactorSets = (dsQuoteDetailRaters.tblFactorSetsDataTable) base.Tables["tblFactorSets"];
    if (initTable && this.tabletblFactorSets != null)
      this.tabletblFactorSets.InitVars();
    this.relationlstRatingTypestblFactorSets = this.Relations["lstRatingTypestblFactorSets"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsQuoteDetailRaters);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsQuoteDetailRaters.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstRatingTypes = new dsQuoteDetailRaters.lstRatingTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstRatingTypes);
    this.tabletblFactorSets = new dsQuoteDetailRaters.tblFactorSetsDataTable();
    base.Tables.Add((DataTable) this.tabletblFactorSets);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("lstRatingTypestblFactorSets", new DataColumn[1]
    {
      this.tablelstRatingTypes.RatingTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblFactorSets.RaterIDColumn
    });
    this.tabletblFactorSets.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationlstRatingTypestblFactorSets = new DataRelation("lstRatingTypestblFactorSets", new DataColumn[1]
    {
      this.tablelstRatingTypes.RatingTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblFactorSets.RaterIDColumn
    }, false);
    this.Relations.Add(this.relationlstRatingTypestblFactorSets);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstRatingTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblFactorSets() => false;

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
    dsQuoteDetailRaters quoteDetailRaters = new dsQuoteDetailRaters();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = quoteDetailRaters.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = quoteDetailRaters.GetSchemaSerializable();
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
  public delegate void lstRatingTypesRowChangeEventHandler(
    object sender,
    dsQuoteDetailRaters.lstRatingTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblFactorSetsRowChangeEventHandler(
    object sender,
    dsQuoteDetailRaters.tblFactorSetsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstRatingTypesDataTable : TypedTableBase<dsQuoteDetailRaters.lstRatingTypesRow>
  {
    private DataColumn columnRatingTypeID;
    private DataColumn columnRatingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstRatingTypesDataTable()
    {
      this.TableName = "lstRatingTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstRatingTypesDataTable(DataTable table)
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
    protected lstRatingTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RatingTypeIDColumn => this.columnRatingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RatingTypeColumn => this.columnRatingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuoteDetailRaters.lstRatingTypesRow this[int index]
    {
      get => (dsQuoteDetailRaters.lstRatingTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuoteDetailRaters.lstRatingTypesRowChangeEventHandler lstRatingTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuoteDetailRaters.lstRatingTypesRowChangeEventHandler lstRatingTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuoteDetailRaters.lstRatingTypesRowChangeEventHandler lstRatingTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuoteDetailRaters.lstRatingTypesRowChangeEventHandler lstRatingTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstRatingTypesRow(dsQuoteDetailRaters.lstRatingTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuoteDetailRaters.lstRatingTypesRow AddlstRatingTypesRow(
      int RatingTypeID,
      string RatingType)
    {
      dsQuoteDetailRaters.lstRatingTypesRow row = (dsQuoteDetailRaters.lstRatingTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) RatingTypeID,
        (object) RatingType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuoteDetailRaters.lstRatingTypesRow FindByRatingTypeID(int RatingTypeID)
    {
      return (dsQuoteDetailRaters.lstRatingTypesRow) this.Rows.Find(new object[1]
      {
        (object) RatingTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteDetailRaters.lstRatingTypesDataTable ratingTypesDataTable = (dsQuoteDetailRaters.lstRatingTypesDataTable) base.Clone();
      ratingTypesDataTable.InitVars();
      return (DataTable) ratingTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteDetailRaters.lstRatingTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnRatingTypeID = this.Columns["RatingTypeID"];
      this.columnRatingType = this.Columns["RatingType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnRatingTypeID = new DataColumn("RatingTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRatingTypeID);
      this.columnRatingType = new DataColumn("RatingType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRatingType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteDetailRatersKey1", new DataColumn[1]
      {
        this.columnRatingTypeID
      }, true));
      this.columnRatingTypeID.AllowDBNull = false;
      this.columnRatingTypeID.Unique = true;
      this.columnRatingType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuoteDetailRaters.lstRatingTypesRow NewlstRatingTypesRow()
    {
      return (dsQuoteDetailRaters.lstRatingTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteDetailRaters.lstRatingTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteDetailRaters.lstRatingTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstRatingTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteDetailRaters.lstRatingTypesRowChangeEventHandler typesRowChangedEvent = this.lstRatingTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsQuoteDetailRaters.lstRatingTypesRowChangeEvent((dsQuoteDetailRaters.lstRatingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstRatingTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteDetailRaters.lstRatingTypesRowChangeEventHandler rowChangingEvent = this.lstRatingTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteDetailRaters.lstRatingTypesRowChangeEvent((dsQuoteDetailRaters.lstRatingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstRatingTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteDetailRaters.lstRatingTypesRowChangeEventHandler typesRowDeletedEvent = this.lstRatingTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsQuoteDetailRaters.lstRatingTypesRowChangeEvent((dsQuoteDetailRaters.lstRatingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstRatingTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteDetailRaters.lstRatingTypesRowChangeEventHandler rowDeletingEvent = this.lstRatingTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteDetailRaters.lstRatingTypesRowChangeEvent((dsQuoteDetailRaters.lstRatingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstRatingTypesRow(dsQuoteDetailRaters.lstRatingTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteDetailRaters quoteDetailRaters = new dsQuoteDetailRaters();
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
        FixedValue = quoteDetailRaters.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstRatingTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = quoteDetailRaters.GetSchemaSerializable();
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
  public class tblFactorSetsDataTable : TypedTableBase<dsQuoteDetailRaters.tblFactorSetsRow>
  {
    private DataColumn columnFactorSetGUID;
    private DataColumn columnRaterID;
    private DataColumn columnTitle;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblFactorSetsDataTable()
    {
      this.TableName = "tblFactorSets";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblFactorSetsDataTable(DataTable table)
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
    protected tblFactorSetsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FactorSetGUIDColumn => this.columnFactorSetGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RaterIDColumn => this.columnRaterID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TitleColumn => this.columnTitle;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuoteDetailRaters.tblFactorSetsRow this[int index]
    {
      get => (dsQuoteDetailRaters.tblFactorSetsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuoteDetailRaters.tblFactorSetsRowChangeEventHandler tblFactorSetsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuoteDetailRaters.tblFactorSetsRowChangeEventHandler tblFactorSetsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuoteDetailRaters.tblFactorSetsRowChangeEventHandler tblFactorSetsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuoteDetailRaters.tblFactorSetsRowChangeEventHandler tblFactorSetsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblFactorSetsRow(dsQuoteDetailRaters.tblFactorSetsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuoteDetailRaters.tblFactorSetsRow AddtblFactorSetsRow(
      Guid FactorSetGUID,
      dsQuoteDetailRaters.lstRatingTypesRow parentlstRatingTypesRowBylstRatingTypestblFactorSets,
      string Title)
    {
      dsQuoteDetailRaters.tblFactorSetsRow row = (dsQuoteDetailRaters.tblFactorSetsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) FactorSetGUID,
        null,
        (object) Title
      };
      if (parentlstRatingTypesRowBylstRatingTypestblFactorSets != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstRatingTypesRowBylstRatingTypestblFactorSets[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuoteDetailRaters.tblFactorSetsRow FindByFactorSetGUID(Guid FactorSetGUID)
    {
      return (dsQuoteDetailRaters.tblFactorSetsRow) this.Rows.Find(new object[1]
      {
        (object) FactorSetGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsQuoteDetailRaters.tblFactorSetsDataTable factorSetsDataTable = (dsQuoteDetailRaters.tblFactorSetsDataTable) base.Clone();
      factorSetsDataTable.InitVars();
      return (DataTable) factorSetsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteDetailRaters.tblFactorSetsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnFactorSetGUID = this.Columns["FactorSetGUID"];
      this.columnRaterID = this.Columns["RaterID"];
      this.columnTitle = this.Columns["Title"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnFactorSetGUID = new DataColumn("FactorSetGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFactorSetGUID);
      this.columnRaterID = new DataColumn("RaterID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRaterID);
      this.columnTitle = new DataColumn("Title", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTitle);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsQuoteDetailRatersKey2", new DataColumn[1]
      {
        this.columnFactorSetGUID
      }, true));
      this.columnFactorSetGUID.AllowDBNull = false;
      this.columnFactorSetGUID.Unique = true;
      this.columnRaterID.AllowDBNull = false;
      this.columnTitle.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuoteDetailRaters.tblFactorSetsRow NewtblFactorSetsRow()
    {
      return (dsQuoteDetailRaters.tblFactorSetsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteDetailRaters.tblFactorSetsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsQuoteDetailRaters.tblFactorSetsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteDetailRaters.tblFactorSetsRowChangeEventHandler setsRowChangedEvent = this.tblFactorSetsRowChangedEvent;
      if (setsRowChangedEvent == null)
        return;
      setsRowChangedEvent((object) this, new dsQuoteDetailRaters.tblFactorSetsRowChangeEvent((dsQuoteDetailRaters.tblFactorSetsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteDetailRaters.tblFactorSetsRowChangeEventHandler rowChangingEvent = this.tblFactorSetsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteDetailRaters.tblFactorSetsRowChangeEvent((dsQuoteDetailRaters.tblFactorSetsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteDetailRaters.tblFactorSetsRowChangeEventHandler setsRowDeletedEvent = this.tblFactorSetsRowDeletedEvent;
      if (setsRowDeletedEvent == null)
        return;
      setsRowDeletedEvent((object) this, new dsQuoteDetailRaters.tblFactorSetsRowChangeEvent((dsQuoteDetailRaters.tblFactorSetsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFactorSetsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteDetailRaters.tblFactorSetsRowChangeEventHandler rowDeletingEvent = this.tblFactorSetsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteDetailRaters.tblFactorSetsRowChangeEvent((dsQuoteDetailRaters.tblFactorSetsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblFactorSetsRow(dsQuoteDetailRaters.tblFactorSetsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuoteDetailRaters quoteDetailRaters = new dsQuoteDetailRaters();
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
        FixedValue = quoteDetailRaters.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblFactorSetsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = quoteDetailRaters.GetSchemaSerializable();
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

  public class lstRatingTypesRow : DataRow
  {
    private dsQuoteDetailRaters.lstRatingTypesDataTable tablelstRatingTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstRatingTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstRatingTypes = (dsQuoteDetailRaters.lstRatingTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int RatingTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstRatingTypes.RatingTypeIDColumn]);
      set => this[this.tablelstRatingTypes.RatingTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RatingType
    {
      get => Conversions.ToString(this[this.tablelstRatingTypes.RatingTypeColumn]);
      set => this[this.tablelstRatingTypes.RatingTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuoteDetailRaters.tblFactorSetsRow[] GettblFactorSetsRows()
    {
      return this.Table.ChildRelations["lstRatingTypestblFactorSets"] != null ? (dsQuoteDetailRaters.tblFactorSetsRow[]) this.GetChildRows(this.Table.ChildRelations["lstRatingTypestblFactorSets"]) : new dsQuoteDetailRaters.tblFactorSetsRow[0];
    }
  }

  public class tblFactorSetsRow : DataRow
  {
    private dsQuoteDetailRaters.tblFactorSetsDataTable tabletblFactorSets;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblFactorSetsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblFactorSets = (dsQuoteDetailRaters.tblFactorSetsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid FactorSetGUID
    {
      get
      {
        object obj = this[this.tabletblFactorSets.FactorSetGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblFactorSets.FactorSetGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int RaterID
    {
      get => Conversions.ToInteger(this[this.tabletblFactorSets.RaterIDColumn]);
      set => this[this.tabletblFactorSets.RaterIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Title
    {
      get => Conversions.ToString(this[this.tabletblFactorSets.TitleColumn]);
      set => this[this.tabletblFactorSets.TitleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuoteDetailRaters.lstRatingTypesRow lstRatingTypesRow
    {
      get
      {
        return (dsQuoteDetailRaters.lstRatingTypesRow) this.GetParentRow(this.Table.ParentRelations["lstRatingTypestblFactorSets"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstRatingTypestblFactorSets"]);
      }
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstRatingTypesRowChangeEvent : EventArgs
  {
    private dsQuoteDetailRaters.lstRatingTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstRatingTypesRowChangeEvent(
      dsQuoteDetailRaters.lstRatingTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuoteDetailRaters.lstRatingTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblFactorSetsRowChangeEvent : EventArgs
  {
    private dsQuoteDetailRaters.tblFactorSetsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblFactorSetsRowChangeEvent(
      dsQuoteDetailRaters.tblFactorSetsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuoteDetailRaters.tblFactorSetsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
