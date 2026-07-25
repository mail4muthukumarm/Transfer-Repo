// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Cancellations.Notices.dsNoticeOfCancellation
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

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
namespace MGASystems.IMS.Policies.Cancellations.Notices;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsNoticeOfCancellation")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsNoticeOfCancellation : DataSet
{
  private dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesDataTable tablelstPolicyCancellationNoticeTypes;
  private dsNoticeOfCancellation.lstPolicyCancellationReasonsDataTable tablelstPolicyCancellationReasons;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsNoticeOfCancellation()
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
  protected dsNoticeOfCancellation(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstPolicyCancellationNoticeTypes)] != null)
          base.Tables.Add((DataTable) new dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesDataTable(dataSet.Tables[nameof (lstPolicyCancellationNoticeTypes)]));
        if (dataSet.Tables[nameof (lstPolicyCancellationReasons)] != null)
          base.Tables.Add((DataTable) new dsNoticeOfCancellation.lstPolicyCancellationReasonsDataTable(dataSet.Tables[nameof (lstPolicyCancellationReasons)]));
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
  public dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesDataTable lstPolicyCancellationNoticeTypes
  {
    get => this.tablelstPolicyCancellationNoticeTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsNoticeOfCancellation.lstPolicyCancellationReasonsDataTable lstPolicyCancellationReasons
  {
    get => this.tablelstPolicyCancellationReasons;
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
    dsNoticeOfCancellation noticeOfCancellation = (dsNoticeOfCancellation) base.Clone();
    noticeOfCancellation.InitVars();
    noticeOfCancellation.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) noticeOfCancellation;
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
      if (dataSet.Tables["lstPolicyCancellationNoticeTypes"] != null)
        base.Tables.Add((DataTable) new dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesDataTable(dataSet.Tables["lstPolicyCancellationNoticeTypes"]));
      if (dataSet.Tables["lstPolicyCancellationReasons"] != null)
        base.Tables.Add((DataTable) new dsNoticeOfCancellation.lstPolicyCancellationReasonsDataTable(dataSet.Tables["lstPolicyCancellationReasons"]));
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
    this.tablelstPolicyCancellationNoticeTypes = (dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesDataTable) base.Tables["lstPolicyCancellationNoticeTypes"];
    if (initTable && this.tablelstPolicyCancellationNoticeTypes != null)
      this.tablelstPolicyCancellationNoticeTypes.InitVars();
    this.tablelstPolicyCancellationReasons = (dsNoticeOfCancellation.lstPolicyCancellationReasonsDataTable) base.Tables["lstPolicyCancellationReasons"];
    if (!initTable || this.tablelstPolicyCancellationReasons == null)
      return;
    this.tablelstPolicyCancellationReasons.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsNoticeOfCancellation);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsNoticeOfCancellation.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstPolicyCancellationNoticeTypes = new dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstPolicyCancellationNoticeTypes);
    this.tablelstPolicyCancellationReasons = new dsNoticeOfCancellation.lstPolicyCancellationReasonsDataTable();
    base.Tables.Add((DataTable) this.tablelstPolicyCancellationReasons);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstPolicyCancellationNoticeTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstPolicyCancellationReasons() => false;

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
    dsNoticeOfCancellation noticeOfCancellation = new dsNoticeOfCancellation();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = noticeOfCancellation.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = noticeOfCancellation.GetSchemaSerializable();
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
  public delegate void lstPolicyCancellationNoticeTypesRowChangeEventHandler(
    object sender,
    dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstPolicyCancellationReasonsRowChangeEventHandler(
    object sender,
    dsNoticeOfCancellation.lstPolicyCancellationReasonsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstPolicyCancellationNoticeTypesDataTable : 
    TypedTableBase<dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow>
  {
    private DataColumn columnNoticeTypeID;
    private DataColumn columnNoticeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPolicyCancellationNoticeTypesDataTable()
    {
      this.TableName = "lstPolicyCancellationNoticeTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPolicyCancellationNoticeTypesDataTable(DataTable table)
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
    protected lstPolicyCancellationNoticeTypesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NoticeTypeIDColumn => this.columnNoticeTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NoticeDescriptionColumn => this.columnNoticeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow this[int index]
    {
      get => (dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRowChangeEventHandler lstPolicyCancellationNoticeTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRowChangeEventHandler lstPolicyCancellationNoticeTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRowChangeEventHandler lstPolicyCancellationNoticeTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRowChangeEventHandler lstPolicyCancellationNoticeTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstPolicyCancellationNoticeTypesRow(
      dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow AddlstPolicyCancellationNoticeTypesRow(
      string NoticeDescription)
    {
      dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow row = (dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) NoticeDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow FindByNoticeTypeID(
      int NoticeTypeID)
    {
      return (dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow) this.Rows.Find(new object[1]
      {
        (object) NoticeTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesDataTable noticeTypesDataTable = (dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesDataTable) base.Clone();
      noticeTypesDataTable.InitVars();
      return (DataTable) noticeTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnNoticeTypeID = this.Columns["NoticeTypeID"];
      this.columnNoticeDescription = this.Columns["NoticeDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnNoticeTypeID = new DataColumn("NoticeTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoticeTypeID);
      this.columnNoticeDescription = new DataColumn("NoticeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoticeDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnNoticeTypeID
      }, true));
      this.columnNoticeTypeID.AutoIncrement = true;
      this.columnNoticeTypeID.AllowDBNull = false;
      this.columnNoticeTypeID.ReadOnly = true;
      this.columnNoticeTypeID.Unique = true;
      this.columnNoticeDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow NewlstPolicyCancellationNoticeTypesRow()
    {
      return (dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyCancellationNoticeTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRowChangeEventHandler typesRowChangedEvent = this.lstPolicyCancellationNoticeTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRowChangeEvent((dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyCancellationNoticeTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRowChangeEventHandler rowChangingEvent = this.lstPolicyCancellationNoticeTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRowChangeEvent((dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyCancellationNoticeTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRowChangeEventHandler typesRowDeletedEvent = this.lstPolicyCancellationNoticeTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRowChangeEvent((dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyCancellationNoticeTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRowChangeEventHandler rowDeletingEvent = this.lstPolicyCancellationNoticeTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRowChangeEvent((dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstPolicyCancellationNoticeTypesRow(
      dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNoticeOfCancellation noticeOfCancellation = new dsNoticeOfCancellation();
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
        FixedValue = noticeOfCancellation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPolicyCancellationNoticeTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = noticeOfCancellation.GetSchemaSerializable();
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
  public class lstPolicyCancellationReasonsDataTable : 
    TypedTableBase<dsNoticeOfCancellation.lstPolicyCancellationReasonsRow>
  {
    private DataColumn columnReasonID;
    private DataColumn columnReasonDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPolicyCancellationReasonsDataTable()
    {
      this.TableName = "lstPolicyCancellationReasons";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPolicyCancellationReasonsDataTable(DataTable table)
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
    protected lstPolicyCancellationReasonsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ReasonIDColumn => this.columnReasonID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ReasonDescriptionColumn => this.columnReasonDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNoticeOfCancellation.lstPolicyCancellationReasonsRow this[int index]
    {
      get => (dsNoticeOfCancellation.lstPolicyCancellationReasonsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNoticeOfCancellation.lstPolicyCancellationReasonsRowChangeEventHandler lstPolicyCancellationReasonsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNoticeOfCancellation.lstPolicyCancellationReasonsRowChangeEventHandler lstPolicyCancellationReasonsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNoticeOfCancellation.lstPolicyCancellationReasonsRowChangeEventHandler lstPolicyCancellationReasonsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNoticeOfCancellation.lstPolicyCancellationReasonsRowChangeEventHandler lstPolicyCancellationReasonsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstPolicyCancellationReasonsRow(
      dsNoticeOfCancellation.lstPolicyCancellationReasonsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNoticeOfCancellation.lstPolicyCancellationReasonsRow AddlstPolicyCancellationReasonsRow(
      string ReasonDescription)
    {
      dsNoticeOfCancellation.lstPolicyCancellationReasonsRow row = (dsNoticeOfCancellation.lstPolicyCancellationReasonsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) ReasonDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNoticeOfCancellation.lstPolicyCancellationReasonsRow FindByReasonID(int ReasonID)
    {
      return (dsNoticeOfCancellation.lstPolicyCancellationReasonsRow) this.Rows.Find(new object[1]
      {
        (object) ReasonID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNoticeOfCancellation.lstPolicyCancellationReasonsDataTable reasonsDataTable = (dsNoticeOfCancellation.lstPolicyCancellationReasonsDataTable) base.Clone();
      reasonsDataTable.InitVars();
      return (DataTable) reasonsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNoticeOfCancellation.lstPolicyCancellationReasonsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnReasonID = this.Columns["ReasonID"];
      this.columnReasonDescription = this.Columns["ReasonDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnReasonID = new DataColumn("ReasonID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReasonID);
      this.columnReasonDescription = new DataColumn("ReasonDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReasonDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnReasonID
      }, true));
      this.columnReasonID.AutoIncrement = true;
      this.columnReasonID.AllowDBNull = false;
      this.columnReasonID.ReadOnly = true;
      this.columnReasonID.Unique = true;
      this.columnReasonDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNoticeOfCancellation.lstPolicyCancellationReasonsRow NewlstPolicyCancellationReasonsRow()
    {
      return (dsNoticeOfCancellation.lstPolicyCancellationReasonsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNoticeOfCancellation.lstPolicyCancellationReasonsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsNoticeOfCancellation.lstPolicyCancellationReasonsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyCancellationReasonsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNoticeOfCancellation.lstPolicyCancellationReasonsRowChangeEventHandler reasonsRowChangedEvent = this.lstPolicyCancellationReasonsRowChangedEvent;
      if (reasonsRowChangedEvent == null)
        return;
      reasonsRowChangedEvent((object) this, new dsNoticeOfCancellation.lstPolicyCancellationReasonsRowChangeEvent((dsNoticeOfCancellation.lstPolicyCancellationReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyCancellationReasonsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNoticeOfCancellation.lstPolicyCancellationReasonsRowChangeEventHandler rowChangingEvent = this.lstPolicyCancellationReasonsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsNoticeOfCancellation.lstPolicyCancellationReasonsRowChangeEvent((dsNoticeOfCancellation.lstPolicyCancellationReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyCancellationReasonsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNoticeOfCancellation.lstPolicyCancellationReasonsRowChangeEventHandler reasonsRowDeletedEvent = this.lstPolicyCancellationReasonsRowDeletedEvent;
      if (reasonsRowDeletedEvent == null)
        return;
      reasonsRowDeletedEvent((object) this, new dsNoticeOfCancellation.lstPolicyCancellationReasonsRowChangeEvent((dsNoticeOfCancellation.lstPolicyCancellationReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyCancellationReasonsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNoticeOfCancellation.lstPolicyCancellationReasonsRowChangeEventHandler rowDeletingEvent = this.lstPolicyCancellationReasonsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsNoticeOfCancellation.lstPolicyCancellationReasonsRowChangeEvent((dsNoticeOfCancellation.lstPolicyCancellationReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstPolicyCancellationReasonsRow(
      dsNoticeOfCancellation.lstPolicyCancellationReasonsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNoticeOfCancellation noticeOfCancellation = new dsNoticeOfCancellation();
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
        FixedValue = noticeOfCancellation.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPolicyCancellationReasonsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = noticeOfCancellation.GetSchemaSerializable();
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

  public class lstPolicyCancellationNoticeTypesRow : DataRow
  {
    private dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesDataTable tablelstPolicyCancellationNoticeTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPolicyCancellationNoticeTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPolicyCancellationNoticeTypes = (dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int NoticeTypeID
    {
      get
      {
        return Conversions.ToInteger(this[this.tablelstPolicyCancellationNoticeTypes.NoticeTypeIDColumn]);
      }
      set => this[this.tablelstPolicyCancellationNoticeTypes.NoticeTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string NoticeDescription
    {
      get
      {
        return Conversions.ToString(this[this.tablelstPolicyCancellationNoticeTypes.NoticeDescriptionColumn]);
      }
      set
      {
        this[this.tablelstPolicyCancellationNoticeTypes.NoticeDescriptionColumn] = (object) value;
      }
    }
  }

  public class lstPolicyCancellationReasonsRow : DataRow
  {
    private dsNoticeOfCancellation.lstPolicyCancellationReasonsDataTable tablelstPolicyCancellationReasons;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPolicyCancellationReasonsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPolicyCancellationReasons = (dsNoticeOfCancellation.lstPolicyCancellationReasonsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ReasonID
    {
      get => Conversions.ToInteger(this[this.tablelstPolicyCancellationReasons.ReasonIDColumn]);
      set => this[this.tablelstPolicyCancellationReasons.ReasonIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ReasonDescription
    {
      get
      {
        return Conversions.ToString(this[this.tablelstPolicyCancellationReasons.ReasonDescriptionColumn]);
      }
      set => this[this.tablelstPolicyCancellationReasons.ReasonDescriptionColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstPolicyCancellationNoticeTypesRowChangeEvent : EventArgs
  {
    private dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPolicyCancellationNoticeTypesRowChangeEvent(
      dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNoticeOfCancellation.lstPolicyCancellationNoticeTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstPolicyCancellationReasonsRowChangeEvent : EventArgs
  {
    private dsNoticeOfCancellation.lstPolicyCancellationReasonsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPolicyCancellationReasonsRowChangeEvent(
      dsNoticeOfCancellation.lstPolicyCancellationReasonsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNoticeOfCancellation.lstPolicyCancellationReasonsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
