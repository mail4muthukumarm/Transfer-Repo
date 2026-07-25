// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.dsCompanyRaters
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
[XmlRoot("dsCompanyRaters")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyRaters : DataSet
{
  private dsCompanyRaters.lstRatingTypesDataTable tablelstRatingTypes;
  private dsCompanyRaters.tblCompanyRatersDataTable tabletblCompanyRaters;
  private DataRelation relationlstRatingTypestblCompanyRaters;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsCompanyRaters()
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
  protected dsCompanyRaters(SerializationInfo info, StreamingContext context)
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
          base.Tables.Add((DataTable) new dsCompanyRaters.lstRatingTypesDataTable(dataSet.Tables[nameof (lstRatingTypes)]));
        if (dataSet.Tables[nameof (tblCompanyRaters)] != null)
          base.Tables.Add((DataTable) new dsCompanyRaters.tblCompanyRatersDataTable(dataSet.Tables[nameof (tblCompanyRaters)]));
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
  public dsCompanyRaters.lstRatingTypesDataTable lstRatingTypes => this.tablelstRatingTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyRaters.tblCompanyRatersDataTable tblCompanyRaters => this.tabletblCompanyRaters;

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
    dsCompanyRaters dsCompanyRaters = (dsCompanyRaters) base.Clone();
    dsCompanyRaters.InitVars();
    dsCompanyRaters.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsCompanyRaters;
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
        base.Tables.Add((DataTable) new dsCompanyRaters.lstRatingTypesDataTable(dataSet.Tables["lstRatingTypes"]));
      if (dataSet.Tables["tblCompanyRaters"] != null)
        base.Tables.Add((DataTable) new dsCompanyRaters.tblCompanyRatersDataTable(dataSet.Tables["tblCompanyRaters"]));
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
    this.tablelstRatingTypes = (dsCompanyRaters.lstRatingTypesDataTable) base.Tables["lstRatingTypes"];
    if (initTable && this.tablelstRatingTypes != null)
      this.tablelstRatingTypes.InitVars();
    this.tabletblCompanyRaters = (dsCompanyRaters.tblCompanyRatersDataTable) base.Tables["tblCompanyRaters"];
    if (initTable && this.tabletblCompanyRaters != null)
      this.tabletblCompanyRaters.InitVars();
    this.relationlstRatingTypestblCompanyRaters = this.Relations["lstRatingTypestblCompanyRaters"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyRaters);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCompanyRaters.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstRatingTypes = new dsCompanyRaters.lstRatingTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstRatingTypes);
    this.tabletblCompanyRaters = new dsCompanyRaters.tblCompanyRatersDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyRaters);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("lstRatingTypestblCompanyRaters", new DataColumn[1]
    {
      this.tablelstRatingTypes.RatingTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyRaters.RatingTypeIDColumn
    });
    this.tabletblCompanyRaters.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationlstRatingTypestblCompanyRaters = new DataRelation("lstRatingTypestblCompanyRaters", new DataColumn[1]
    {
      this.tablelstRatingTypes.RatingTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyRaters.RatingTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstRatingTypestblCompanyRaters);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstRatingTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyRaters() => false;

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
    dsCompanyRaters dsCompanyRaters = new dsCompanyRaters();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsCompanyRaters.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsCompanyRaters.GetSchemaSerializable();
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
    dsCompanyRaters.lstRatingTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblCompanyRatersRowChangeEventHandler(
    object sender,
    dsCompanyRaters.tblCompanyRatersRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstRatingTypesDataTable : TypedTableBase<dsCompanyRaters.lstRatingTypesRow>
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
    public dsCompanyRaters.lstRatingTypesRow this[int index]
    {
      get => (dsCompanyRaters.lstRatingTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyRaters.lstRatingTypesRowChangeEventHandler lstRatingTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyRaters.lstRatingTypesRowChangeEventHandler lstRatingTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyRaters.lstRatingTypesRowChangeEventHandler lstRatingTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyRaters.lstRatingTypesRowChangeEventHandler lstRatingTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstRatingTypesRow(dsCompanyRaters.lstRatingTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyRaters.lstRatingTypesRow AddlstRatingTypesRow(
      int RatingTypeID,
      string RatingType)
    {
      dsCompanyRaters.lstRatingTypesRow row = (dsCompanyRaters.lstRatingTypesRow) this.NewRow();
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
    public dsCompanyRaters.lstRatingTypesRow FindByRatingTypeID(int RatingTypeID)
    {
      return (dsCompanyRaters.lstRatingTypesRow) this.Rows.Find(new object[1]
      {
        (object) RatingTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyRaters.lstRatingTypesDataTable ratingTypesDataTable = (dsCompanyRaters.lstRatingTypesDataTable) base.Clone();
      ratingTypesDataTable.InitVars();
      return (DataTable) ratingTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyRaters.lstRatingTypesDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnRatingTypeID
      }, true));
      this.columnRatingTypeID.AllowDBNull = false;
      this.columnRatingTypeID.Unique = true;
      this.columnRatingType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyRaters.lstRatingTypesRow NewlstRatingTypesRow()
    {
      return (dsCompanyRaters.lstRatingTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyRaters.lstRatingTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyRaters.lstRatingTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstRatingTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyRaters.lstRatingTypesRowChangeEventHandler typesRowChangedEvent = this.lstRatingTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompanyRaters.lstRatingTypesRowChangeEvent((dsCompanyRaters.lstRatingTypesRow) e.Row, e.Action));
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
      dsCompanyRaters.lstRatingTypesRowChangeEventHandler rowChangingEvent = this.lstRatingTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyRaters.lstRatingTypesRowChangeEvent((dsCompanyRaters.lstRatingTypesRow) e.Row, e.Action));
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
      dsCompanyRaters.lstRatingTypesRowChangeEventHandler typesRowDeletedEvent = this.lstRatingTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompanyRaters.lstRatingTypesRowChangeEvent((dsCompanyRaters.lstRatingTypesRow) e.Row, e.Action));
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
      dsCompanyRaters.lstRatingTypesRowChangeEventHandler rowDeletingEvent = this.lstRatingTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyRaters.lstRatingTypesRowChangeEvent((dsCompanyRaters.lstRatingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstRatingTypesRow(dsCompanyRaters.lstRatingTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyRaters dsCompanyRaters = new dsCompanyRaters();
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
        FixedValue = dsCompanyRaters.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstRatingTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanyRaters.GetSchemaSerializable();
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
  public class tblCompanyRatersDataTable : TypedTableBase<dsCompanyRaters.tblCompanyRatersRow>
  {
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnRatingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyRatersDataTable()
    {
      this.TableName = "tblCompanyRaters";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyRatersDataTable(DataTable table)
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
    protected tblCompanyRatersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RatingTypeIDColumn => this.columnRatingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyRaters.tblCompanyRatersRow this[int index]
    {
      get => (dsCompanyRaters.tblCompanyRatersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyRaters.tblCompanyRatersRowChangeEventHandler tblCompanyRatersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyRaters.tblCompanyRatersRowChangeEventHandler tblCompanyRatersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyRaters.tblCompanyRatersRowChangeEventHandler tblCompanyRatersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyRaters.tblCompanyRatersRowChangeEventHandler tblCompanyRatersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyRatersRow(dsCompanyRaters.tblCompanyRatersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyRaters.tblCompanyRatersRow AddtblCompanyRatersRow(
      Guid CompanyLineGuid,
      dsCompanyRaters.lstRatingTypesRow parentlstRatingTypesRowBylstRatingTypestblCompanyRaters)
    {
      dsCompanyRaters.tblCompanyRatersRow row = (dsCompanyRaters.tblCompanyRatersRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) CompanyLineGuid,
        null
      };
      if (parentlstRatingTypesRowBylstRatingTypestblCompanyRaters != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstRatingTypesRowBylstRatingTypestblCompanyRaters[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyRaters.tblCompanyRatersRow FindByCompanyLineGuidRatingTypeID(
      Guid CompanyLineGuid,
      int RatingTypeID)
    {
      return (dsCompanyRaters.tblCompanyRatersRow) this.Rows.Find(new object[2]
      {
        (object) CompanyLineGuid,
        (object) RatingTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyRaters.tblCompanyRatersDataTable companyRatersDataTable = (dsCompanyRaters.tblCompanyRatersDataTable) base.Clone();
      companyRatersDataTable.InitVars();
      return (DataTable) companyRatersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyRaters.tblCompanyRatersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnRatingTypeID = this.Columns["RatingTypeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnRatingTypeID = new DataColumn("RatingTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRatingTypeID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnCompanyLineGuid,
        this.columnRatingTypeID
      }, true));
      this.columnCompanyLineGuid.AllowDBNull = false;
      this.columnRatingTypeID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyRaters.tblCompanyRatersRow NewtblCompanyRatersRow()
    {
      return (dsCompanyRaters.tblCompanyRatersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyRaters.tblCompanyRatersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyRaters.tblCompanyRatersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyRatersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyRaters.tblCompanyRatersRowChangeEventHandler ratersRowChangedEvent = this.tblCompanyRatersRowChangedEvent;
      if (ratersRowChangedEvent == null)
        return;
      ratersRowChangedEvent((object) this, new dsCompanyRaters.tblCompanyRatersRowChangeEvent((dsCompanyRaters.tblCompanyRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyRatersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyRaters.tblCompanyRatersRowChangeEventHandler rowChangingEvent = this.tblCompanyRatersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyRaters.tblCompanyRatersRowChangeEvent((dsCompanyRaters.tblCompanyRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyRatersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyRaters.tblCompanyRatersRowChangeEventHandler ratersRowDeletedEvent = this.tblCompanyRatersRowDeletedEvent;
      if (ratersRowDeletedEvent == null)
        return;
      ratersRowDeletedEvent((object) this, new dsCompanyRaters.tblCompanyRatersRowChangeEvent((dsCompanyRaters.tblCompanyRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyRatersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyRaters.tblCompanyRatersRowChangeEventHandler rowDeletingEvent = this.tblCompanyRatersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyRaters.tblCompanyRatersRowChangeEvent((dsCompanyRaters.tblCompanyRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyRatersRow(dsCompanyRaters.tblCompanyRatersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyRaters dsCompanyRaters = new dsCompanyRaters();
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
        FixedValue = dsCompanyRaters.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyRatersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanyRaters.GetSchemaSerializable();
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
    private dsCompanyRaters.lstRatingTypesDataTable tablelstRatingTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstRatingTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstRatingTypes = (dsCompanyRaters.lstRatingTypesDataTable) this.Table;
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
    public dsCompanyRaters.tblCompanyRatersRow[] GettblCompanyRatersRows()
    {
      return this.Table.ChildRelations["lstRatingTypestblCompanyRaters"] != null ? (dsCompanyRaters.tblCompanyRatersRow[]) this.GetChildRows(this.Table.ChildRelations["lstRatingTypestblCompanyRaters"]) : new dsCompanyRaters.tblCompanyRatersRow[0];
    }
  }

  public class tblCompanyRatersRow : DataRow
  {
    private dsCompanyRaters.tblCompanyRatersDataTable tabletblCompanyRaters;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyRatersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyRaters = (dsCompanyRaters.tblCompanyRatersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        object obj = this[this.tabletblCompanyRaters.CompanyLineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyRaters.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int RatingTypeID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyRaters.RatingTypeIDColumn]);
      set => this[this.tabletblCompanyRaters.RatingTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyRaters.lstRatingTypesRow lstRatingTypesRow
    {
      get
      {
        return (dsCompanyRaters.lstRatingTypesRow) this.GetParentRow(this.Table.ParentRelations["lstRatingTypestblCompanyRaters"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstRatingTypestblCompanyRaters"]);
      }
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstRatingTypesRowChangeEvent : EventArgs
  {
    private dsCompanyRaters.lstRatingTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstRatingTypesRowChangeEvent(dsCompanyRaters.lstRatingTypesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyRaters.lstRatingTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyRatersRowChangeEvent : EventArgs
  {
    private dsCompanyRaters.tblCompanyRatersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyRatersRowChangeEvent(
      dsCompanyRaters.tblCompanyRatersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyRaters.tblCompanyRatersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
