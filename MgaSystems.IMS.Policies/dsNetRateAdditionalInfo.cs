// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsNetRateAdditionalInfo
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
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsNetRateAdditionalInfo")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsNetRateAdditionalInfo : DataSet
{
  private dsNetRateAdditionalInfo.lstGLCoverageTypeDataTable tablelstGLCoverageType;
  private dsNetRateAdditionalInfo.tblNetRateAdditionalDataDataTable tabletblNetRateAdditionalData;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsNetRateAdditionalInfo()
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
  protected dsNetRateAdditionalInfo(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstGLCoverageType)] != null)
          base.Tables.Add((DataTable) new dsNetRateAdditionalInfo.lstGLCoverageTypeDataTable(dataSet.Tables[nameof (lstGLCoverageType)]));
        if (dataSet.Tables[nameof (tblNetRateAdditionalData)] != null)
          base.Tables.Add((DataTable) new dsNetRateAdditionalInfo.tblNetRateAdditionalDataDataTable(dataSet.Tables[nameof (tblNetRateAdditionalData)]));
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
  public dsNetRateAdditionalInfo.lstGLCoverageTypeDataTable lstGLCoverageType
  {
    get => this.tablelstGLCoverageType;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsNetRateAdditionalInfo.tblNetRateAdditionalDataDataTable tblNetRateAdditionalData
  {
    get => this.tabletblNetRateAdditionalData;
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
    dsNetRateAdditionalInfo rateAdditionalInfo = (dsNetRateAdditionalInfo) base.Clone();
    rateAdditionalInfo.InitVars();
    rateAdditionalInfo.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) rateAdditionalInfo;
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
      if (dataSet.Tables["lstGLCoverageType"] != null)
        base.Tables.Add((DataTable) new dsNetRateAdditionalInfo.lstGLCoverageTypeDataTable(dataSet.Tables["lstGLCoverageType"]));
      if (dataSet.Tables["tblNetRateAdditionalData"] != null)
        base.Tables.Add((DataTable) new dsNetRateAdditionalInfo.tblNetRateAdditionalDataDataTable(dataSet.Tables["tblNetRateAdditionalData"]));
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
    this.tablelstGLCoverageType = (dsNetRateAdditionalInfo.lstGLCoverageTypeDataTable) base.Tables["lstGLCoverageType"];
    if (initTable && this.tablelstGLCoverageType != null)
      this.tablelstGLCoverageType.InitVars();
    this.tabletblNetRateAdditionalData = (dsNetRateAdditionalInfo.tblNetRateAdditionalDataDataTable) base.Tables["tblNetRateAdditionalData"];
    if (!initTable || this.tabletblNetRateAdditionalData == null)
      return;
    this.tabletblNetRateAdditionalData.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsNetRateAdditionalInfo);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsNetRateAdditionalInfo.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstGLCoverageType = new dsNetRateAdditionalInfo.lstGLCoverageTypeDataTable();
    base.Tables.Add((DataTable) this.tablelstGLCoverageType);
    this.tabletblNetRateAdditionalData = new dsNetRateAdditionalInfo.tblNetRateAdditionalDataDataTable();
    base.Tables.Add((DataTable) this.tabletblNetRateAdditionalData);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstGLCoverageType() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblNetRateAdditionalData() => false;

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
    dsNetRateAdditionalInfo rateAdditionalInfo = new dsNetRateAdditionalInfo();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = rateAdditionalInfo.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = rateAdditionalInfo.GetSchemaSerializable();
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
  public delegate void lstGLCoverageTypeRowChangeEventHandler(
    object sender,
    dsNetRateAdditionalInfo.lstGLCoverageTypeRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblNetRateAdditionalDataRowChangeEventHandler(
    object sender,
    dsNetRateAdditionalInfo.tblNetRateAdditionalDataRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstGLCoverageTypeDataTable : 
    TypedTableBase<dsNetRateAdditionalInfo.lstGLCoverageTypeRow>
  {
    private DataColumn columnID;
    private DataColumn columnCoverageType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstGLCoverageTypeDataTable()
    {
      this.TableName = "lstGLCoverageType";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstGLCoverageTypeDataTable(DataTable table)
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
    protected lstGLCoverageTypeDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoverageTypeColumn => this.columnCoverageType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNetRateAdditionalInfo.lstGLCoverageTypeRow this[int index]
    {
      get => (dsNetRateAdditionalInfo.lstGLCoverageTypeRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNetRateAdditionalInfo.lstGLCoverageTypeRowChangeEventHandler lstGLCoverageTypeRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNetRateAdditionalInfo.lstGLCoverageTypeRowChangeEventHandler lstGLCoverageTypeRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNetRateAdditionalInfo.lstGLCoverageTypeRowChangeEventHandler lstGLCoverageTypeRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNetRateAdditionalInfo.lstGLCoverageTypeRowChangeEventHandler lstGLCoverageTypeRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstGLCoverageTypeRow(dsNetRateAdditionalInfo.lstGLCoverageTypeRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNetRateAdditionalInfo.lstGLCoverageTypeRow AddlstGLCoverageTypeRow(string CoverageType)
    {
      dsNetRateAdditionalInfo.lstGLCoverageTypeRow row = (dsNetRateAdditionalInfo.lstGLCoverageTypeRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) CoverageType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNetRateAdditionalInfo.lstGLCoverageTypeRow FindByID(int ID)
    {
      return (dsNetRateAdditionalInfo.lstGLCoverageTypeRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNetRateAdditionalInfo.lstGLCoverageTypeDataTable coverageTypeDataTable = (dsNetRateAdditionalInfo.lstGLCoverageTypeDataTable) base.Clone();
      coverageTypeDataTable.InitVars();
      return (DataTable) coverageTypeDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNetRateAdditionalInfo.lstGLCoverageTypeDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnCoverageType = this.Columns["CoverageType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnCoverageType = new DataColumn("CoverageType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AutoIncrementSeed = -1L;
      this.columnID.AutoIncrementStep = -1L;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnCoverageType.AllowDBNull = false;
      this.columnCoverageType.MaxLength = 100;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNetRateAdditionalInfo.lstGLCoverageTypeRow NewlstGLCoverageTypeRow()
    {
      return (dsNetRateAdditionalInfo.lstGLCoverageTypeRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNetRateAdditionalInfo.lstGLCoverageTypeRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsNetRateAdditionalInfo.lstGLCoverageTypeRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstGLCoverageTypeRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNetRateAdditionalInfo.lstGLCoverageTypeRowChangeEventHandler typeRowChangedEvent = this.lstGLCoverageTypeRowChangedEvent;
      if (typeRowChangedEvent == null)
        return;
      typeRowChangedEvent((object) this, new dsNetRateAdditionalInfo.lstGLCoverageTypeRowChangeEvent((dsNetRateAdditionalInfo.lstGLCoverageTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstGLCoverageTypeRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNetRateAdditionalInfo.lstGLCoverageTypeRowChangeEventHandler rowChangingEvent = this.lstGLCoverageTypeRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsNetRateAdditionalInfo.lstGLCoverageTypeRowChangeEvent((dsNetRateAdditionalInfo.lstGLCoverageTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstGLCoverageTypeRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNetRateAdditionalInfo.lstGLCoverageTypeRowChangeEventHandler typeRowDeletedEvent = this.lstGLCoverageTypeRowDeletedEvent;
      if (typeRowDeletedEvent == null)
        return;
      typeRowDeletedEvent((object) this, new dsNetRateAdditionalInfo.lstGLCoverageTypeRowChangeEvent((dsNetRateAdditionalInfo.lstGLCoverageTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstGLCoverageTypeRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNetRateAdditionalInfo.lstGLCoverageTypeRowChangeEventHandler rowDeletingEvent = this.lstGLCoverageTypeRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsNetRateAdditionalInfo.lstGLCoverageTypeRowChangeEvent((dsNetRateAdditionalInfo.lstGLCoverageTypeRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstGLCoverageTypeRow(dsNetRateAdditionalInfo.lstGLCoverageTypeRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNetRateAdditionalInfo rateAdditionalInfo = new dsNetRateAdditionalInfo();
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
        FixedValue = rateAdditionalInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstGLCoverageTypeDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = rateAdditionalInfo.GetSchemaSerializable();
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
  public class tblNetRateAdditionalDataDataTable : 
    TypedTableBase<dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow>
  {
    private DataColumn columnID;
    private DataColumn columnQuoteGuid;
    private DataColumn columnAdditionalComments;
    private DataColumn columnAutoliabSymbol;
    private DataColumn columnPIPSymbol;
    private DataColumn columnAddnPIPSymbol;
    private DataColumn columnPropProtectionSymbol;
    private DataColumn columnMedPaySymbol;
    private DataColumn columnUnInsSymbol;
    private DataColumn columnUnderInsSymbol;
    private DataColumn columnRejectedTerrorism;
    private DataColumn columnTerrorism;
    private DataColumn columnCoverageTypeID;
    private DataColumn columnAutoReportingBasis;
    private DataColumn columnAutoNonReportingBasis;
    private DataColumn columnAutoQuarterlyBasis;
    private DataColumn columnAutoMonthlyBasis;
    private DataColumn columnAutoNewComprehensive;
    private DataColumn columnAutoNewSpecCauseLoss;
    private DataColumn columnAutoNewCollision;
    private DataColumn columnAutoUsedComprehensive;
    private DataColumn columnAutoUsedSpecCauseLoss;
    private DataColumn columnAutoUsedCollision;
    private DataColumn columnAutoIntComprehensive;
    private DataColumn columnAutoIntSpecCauseLoss;
    private DataColumn columnAutoIntCollision;
    private DataColumn columnAutoFinanceComprehensive;
    private DataColumn columnAutoFinanceSpecCauseLoss;
    private DataColumn columnAutoFinanceCollision;
    private DataColumn columnAutoLossPayeeComprehensive;
    private DataColumn columnAutoLossPayeeSpecCauseLoss;
    private DataColumn columnAutoLossPayeeCollision;
    private DataColumn columnAutoConsignComprehensive;
    private DataColumn columnAutoConsignSpecCauseLoss;
    private DataColumn columnAutoConsignCollision;
    private DataColumn columnAutoComments;
    private DataColumn columnGaragekeepersSymbol;
    private DataColumn columnPhysDamCompSymbol;
    private DataColumn columnPhysDamCOLSymbol;
    private DataColumn columnPhysDamCollSymbol;
    private DataColumn columnRetroDate;
    private DataColumn columnBodilyInjEachAcc;
    private DataColumn columnBodilyInjDiseaseAggLimit;
    private DataColumn columnBodilyInjDiseaseEachEmpl;
    private DataColumn columnTowingSymbol;
    private DataColumn columnTrailerSymbol;
    private DataColumn columnHiredAutoLimit;
    private DataColumn columnNonownedLiabilitySymbol;
    private DataColumn columnHiredAutoSymbol;
    private DataColumn columnEndorseName;
    private DataColumn columnEndorseSymbol;
    private DataColumn columnEndorseLimit;
    private DataColumn columnEndorseDeductible;
    private DataColumn columnReceipts;
    private DataColumn columnNO_of_Empl;
    private DataColumn columnGL_Rate;
    private DataColumn columnGL_Est_Premium;
    private DataColumn columnGL_Min_Premium;
    private DataColumn columnCompositeRated;
    private DataColumn columnNumPoweredUnits;
    private DataColumn columnStateUnEmployment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblNetRateAdditionalDataDataTable()
    {
      this.TableName = "tblNetRateAdditionalData";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblNetRateAdditionalDataDataTable(DataTable table)
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
    protected tblNetRateAdditionalDataDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AdditionalCommentsColumn => this.columnAdditionalComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoliabSymbolColumn => this.columnAutoliabSymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PIPSymbolColumn => this.columnPIPSymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AddnPIPSymbolColumn => this.columnAddnPIPSymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PropProtectionSymbolColumn => this.columnPropProtectionSymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MedPaySymbolColumn => this.columnMedPaySymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UnInsSymbolColumn => this.columnUnInsSymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UnderInsSymbolColumn => this.columnUnderInsSymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RejectedTerrorismColumn => this.columnRejectedTerrorism;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TerrorismColumn => this.columnTerrorism;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoverageTypeIDColumn => this.columnCoverageTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoReportingBasisColumn => this.columnAutoReportingBasis;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoNonReportingBasisColumn => this.columnAutoNonReportingBasis;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoQuarterlyBasisColumn => this.columnAutoQuarterlyBasis;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoMonthlyBasisColumn => this.columnAutoMonthlyBasis;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoNewComprehensiveColumn => this.columnAutoNewComprehensive;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoNewSpecCauseLossColumn => this.columnAutoNewSpecCauseLoss;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoNewCollisionColumn => this.columnAutoNewCollision;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoUsedComprehensiveColumn => this.columnAutoUsedComprehensive;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoUsedSpecCauseLossColumn => this.columnAutoUsedSpecCauseLoss;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoUsedCollisionColumn => this.columnAutoUsedCollision;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoIntComprehensiveColumn => this.columnAutoIntComprehensive;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoIntSpecCauseLossColumn => this.columnAutoIntSpecCauseLoss;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoIntCollisionColumn => this.columnAutoIntCollision;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoFinanceComprehensiveColumn => this.columnAutoFinanceComprehensive;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoFinanceSpecCauseLossColumn => this.columnAutoFinanceSpecCauseLoss;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoFinanceCollisionColumn => this.columnAutoFinanceCollision;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoLossPayeeComprehensiveColumn => this.columnAutoLossPayeeComprehensive;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoLossPayeeSpecCauseLossColumn => this.columnAutoLossPayeeSpecCauseLoss;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoLossPayeeCollisionColumn => this.columnAutoLossPayeeCollision;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoConsignComprehensiveColumn => this.columnAutoConsignComprehensive;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoConsignSpecCauseLossColumn => this.columnAutoConsignSpecCauseLoss;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoConsignCollisionColumn => this.columnAutoConsignCollision;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutoCommentsColumn => this.columnAutoComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GaragekeepersSymbolColumn => this.columnGaragekeepersSymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PhysDamCompSymbolColumn => this.columnPhysDamCompSymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PhysDamCOLSymbolColumn => this.columnPhysDamCOLSymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PhysDamCollSymbolColumn => this.columnPhysDamCollSymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RetroDateColumn => this.columnRetroDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BodilyInjEachAccColumn => this.columnBodilyInjEachAcc;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BodilyInjDiseaseAggLimitColumn => this.columnBodilyInjDiseaseAggLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BodilyInjDiseaseEachEmplColumn => this.columnBodilyInjDiseaseEachEmpl;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TowingSymbolColumn => this.columnTowingSymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TrailerSymbolColumn => this.columnTrailerSymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn HiredAutoLimitColumn => this.columnHiredAutoLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NonownedLiabilitySymbolColumn => this.columnNonownedLiabilitySymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn HiredAutoSymbolColumn => this.columnHiredAutoSymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EndorseNameColumn => this.columnEndorseName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EndorseSymbolColumn => this.columnEndorseSymbol;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EndorseLimitColumn => this.columnEndorseLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EndorseDeductibleColumn => this.columnEndorseDeductible;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ReceiptsColumn => this.columnReceipts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NO_of_EmplColumn => this.columnNO_of_Empl;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GL_RateColumn => this.columnGL_Rate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GL_Est_PremiumColumn => this.columnGL_Est_Premium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GL_Min_PremiumColumn => this.columnGL_Min_Premium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompositeRatedColumn => this.columnCompositeRated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NumPoweredUnitsColumn => this.columnNumPoweredUnits;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateUnEmploymentColumn => this.columnStateUnEmployment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow this[int index]
    {
      get => (dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNetRateAdditionalInfo.tblNetRateAdditionalDataRowChangeEventHandler tblNetRateAdditionalDataRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNetRateAdditionalInfo.tblNetRateAdditionalDataRowChangeEventHandler tblNetRateAdditionalDataRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNetRateAdditionalInfo.tblNetRateAdditionalDataRowChangeEventHandler tblNetRateAdditionalDataRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNetRateAdditionalInfo.tblNetRateAdditionalDataRowChangeEventHandler tblNetRateAdditionalDataRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblNetRateAdditionalDataRow(
      dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow AddtblNetRateAdditionalDataRow(
      Guid QuoteGuid,
      string AdditionalComments,
      string AutoliabSymbol,
      string PIPSymbol,
      string AddnPIPSymbol,
      string PropProtectionSymbol,
      string MedPaySymbol,
      string UnInsSymbol,
      string UnderInsSymbol,
      Decimal RejectedTerrorism,
      Decimal Terrorism,
      int CoverageTypeID,
      bool AutoReportingBasis,
      bool AutoNonReportingBasis,
      bool AutoQuarterlyBasis,
      bool AutoMonthlyBasis,
      bool AutoNewComprehensive,
      bool AutoNewSpecCauseLoss,
      bool AutoNewCollision,
      bool AutoUsedComprehensive,
      bool AutoUsedSpecCauseLoss,
      bool AutoUsedCollision,
      bool AutoIntComprehensive,
      bool AutoIntSpecCauseLoss,
      bool AutoIntCollision,
      bool AutoFinanceComprehensive,
      bool AutoFinanceSpecCauseLoss,
      bool AutoFinanceCollision,
      bool AutoLossPayeeComprehensive,
      bool AutoLossPayeeSpecCauseLoss,
      bool AutoLossPayeeCollision,
      bool AutoConsignComprehensive,
      bool AutoConsignSpecCauseLoss,
      bool AutoConsignCollision,
      string AutoComments,
      string GaragekeepersSymbol,
      string PhysDamCompSymbol,
      string PhysDamCOLSymbol,
      string PhysDamCollSymbol,
      string RetroDate,
      string BodilyInjEachAcc,
      string BodilyInjDiseaseAggLimit,
      string BodilyInjDiseaseEachEmpl,
      string TowingSymbol,
      string TrailerSymbol,
      Decimal HiredAutoLimit,
      string NonownedLiabilitySymbol,
      string HiredAutoSymbol,
      string EndorseName,
      string EndorseSymbol,
      Decimal EndorseLimit,
      Decimal EndorseDeductible,
      Decimal Receipts,
      short NO_of_Empl,
      Decimal GL_Rate,
      double GL_Est_Premium,
      double GL_Min_Premium,
      bool CompositeRated,
      int NumPoweredUnits,
      string StateUnEmployment)
    {
      dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow row = (dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow) this.NewRow();
      object[] objArray = new object[61]
      {
        null,
        (object) QuoteGuid,
        (object) AdditionalComments,
        (object) AutoliabSymbol,
        (object) PIPSymbol,
        (object) AddnPIPSymbol,
        (object) PropProtectionSymbol,
        (object) MedPaySymbol,
        (object) UnInsSymbol,
        (object) UnderInsSymbol,
        (object) RejectedTerrorism,
        (object) Terrorism,
        (object) CoverageTypeID,
        (object) AutoReportingBasis,
        (object) AutoNonReportingBasis,
        (object) AutoQuarterlyBasis,
        (object) AutoMonthlyBasis,
        (object) AutoNewComprehensive,
        (object) AutoNewSpecCauseLoss,
        (object) AutoNewCollision,
        (object) AutoUsedComprehensive,
        (object) AutoUsedSpecCauseLoss,
        (object) AutoUsedCollision,
        (object) AutoIntComprehensive,
        (object) AutoIntSpecCauseLoss,
        (object) AutoIntCollision,
        (object) AutoFinanceComprehensive,
        (object) AutoFinanceSpecCauseLoss,
        (object) AutoFinanceCollision,
        (object) AutoLossPayeeComprehensive,
        (object) AutoLossPayeeSpecCauseLoss,
        (object) AutoLossPayeeCollision,
        (object) AutoConsignComprehensive,
        (object) AutoConsignSpecCauseLoss,
        (object) AutoConsignCollision,
        (object) AutoComments,
        (object) GaragekeepersSymbol,
        (object) PhysDamCompSymbol,
        (object) PhysDamCOLSymbol,
        (object) PhysDamCollSymbol,
        (object) RetroDate,
        (object) BodilyInjEachAcc,
        (object) BodilyInjDiseaseAggLimit,
        (object) BodilyInjDiseaseEachEmpl,
        (object) TowingSymbol,
        (object) TrailerSymbol,
        (object) HiredAutoLimit,
        (object) NonownedLiabilitySymbol,
        (object) HiredAutoSymbol,
        (object) EndorseName,
        (object) EndorseSymbol,
        (object) EndorseLimit,
        (object) EndorseDeductible,
        (object) Receipts,
        (object) NO_of_Empl,
        (object) GL_Rate,
        (object) GL_Est_Premium,
        (object) GL_Min_Premium,
        (object) CompositeRated,
        (object) NumPoweredUnits,
        (object) StateUnEmployment
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow FindByID(int ID)
    {
      return (dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNetRateAdditionalInfo.tblNetRateAdditionalDataDataTable additionalDataDataTable = (dsNetRateAdditionalInfo.tblNetRateAdditionalDataDataTable) base.Clone();
      additionalDataDataTable.InitVars();
      return (DataTable) additionalDataDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNetRateAdditionalInfo.tblNetRateAdditionalDataDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnAdditionalComments = this.Columns["AdditionalComments"];
      this.columnAutoliabSymbol = this.Columns["AutoliabSymbol"];
      this.columnPIPSymbol = this.Columns["PIPSymbol"];
      this.columnAddnPIPSymbol = this.Columns["AddnPIPSymbol"];
      this.columnPropProtectionSymbol = this.Columns["PropProtectionSymbol"];
      this.columnMedPaySymbol = this.Columns["MedPaySymbol"];
      this.columnUnInsSymbol = this.Columns["UnInsSymbol"];
      this.columnUnderInsSymbol = this.Columns["UnderInsSymbol"];
      this.columnRejectedTerrorism = this.Columns["RejectedTerrorism"];
      this.columnTerrorism = this.Columns["Terrorism"];
      this.columnCoverageTypeID = this.Columns["CoverageTypeID"];
      this.columnAutoReportingBasis = this.Columns["AutoReportingBasis"];
      this.columnAutoNonReportingBasis = this.Columns["AutoNonReportingBasis"];
      this.columnAutoQuarterlyBasis = this.Columns["AutoQuarterlyBasis"];
      this.columnAutoMonthlyBasis = this.Columns["AutoMonthlyBasis"];
      this.columnAutoNewComprehensive = this.Columns["AutoNewComprehensive"];
      this.columnAutoNewSpecCauseLoss = this.Columns["AutoNewSpecCauseLoss"];
      this.columnAutoNewCollision = this.Columns["AutoNewCollision"];
      this.columnAutoUsedComprehensive = this.Columns["AutoUsedComprehensive"];
      this.columnAutoUsedSpecCauseLoss = this.Columns["AutoUsedSpecCauseLoss"];
      this.columnAutoUsedCollision = this.Columns["AutoUsedCollision"];
      this.columnAutoIntComprehensive = this.Columns["AutoIntComprehensive"];
      this.columnAutoIntSpecCauseLoss = this.Columns["AutoIntSpecCauseLoss"];
      this.columnAutoIntCollision = this.Columns["AutoIntCollision"];
      this.columnAutoFinanceComprehensive = this.Columns["AutoFinanceComprehensive"];
      this.columnAutoFinanceSpecCauseLoss = this.Columns["AutoFinanceSpecCauseLoss"];
      this.columnAutoFinanceCollision = this.Columns["AutoFinanceCollision"];
      this.columnAutoLossPayeeComprehensive = this.Columns["AutoLossPayeeComprehensive"];
      this.columnAutoLossPayeeSpecCauseLoss = this.Columns["AutoLossPayeeSpecCauseLoss"];
      this.columnAutoLossPayeeCollision = this.Columns["AutoLossPayeeCollision"];
      this.columnAutoConsignComprehensive = this.Columns["AutoConsignComprehensive"];
      this.columnAutoConsignSpecCauseLoss = this.Columns["AutoConsignSpecCauseLoss"];
      this.columnAutoConsignCollision = this.Columns["AutoConsignCollision"];
      this.columnAutoComments = this.Columns["AutoComments"];
      this.columnGaragekeepersSymbol = this.Columns["GaragekeepersSymbol"];
      this.columnPhysDamCompSymbol = this.Columns["PhysDamCompSymbol"];
      this.columnPhysDamCOLSymbol = this.Columns["PhysDamCOLSymbol"];
      this.columnPhysDamCollSymbol = this.Columns["PhysDamCollSymbol"];
      this.columnRetroDate = this.Columns["RetroDate"];
      this.columnBodilyInjEachAcc = this.Columns["BodilyInjEachAcc"];
      this.columnBodilyInjDiseaseAggLimit = this.Columns["BodilyInjDiseaseAggLimit"];
      this.columnBodilyInjDiseaseEachEmpl = this.Columns["BodilyInjDiseaseEachEmpl"];
      this.columnTowingSymbol = this.Columns["TowingSymbol"];
      this.columnTrailerSymbol = this.Columns["TrailerSymbol"];
      this.columnHiredAutoLimit = this.Columns["HiredAutoLimit"];
      this.columnNonownedLiabilitySymbol = this.Columns["NonownedLiabilitySymbol"];
      this.columnHiredAutoSymbol = this.Columns["HiredAutoSymbol"];
      this.columnEndorseName = this.Columns["EndorseName"];
      this.columnEndorseSymbol = this.Columns["EndorseSymbol"];
      this.columnEndorseLimit = this.Columns["EndorseLimit"];
      this.columnEndorseDeductible = this.Columns["EndorseDeductible"];
      this.columnReceipts = this.Columns["Receipts"];
      this.columnNO_of_Empl = this.Columns["NO_of_Empl"];
      this.columnGL_Rate = this.Columns["GL_Rate"];
      this.columnGL_Est_Premium = this.Columns["GL_Est_Premium"];
      this.columnGL_Min_Premium = this.Columns["GL_Min_Premium"];
      this.columnCompositeRated = this.Columns["CompositeRated"];
      this.columnNumPoweredUnits = this.Columns["NumPoweredUnits"];
      this.columnStateUnEmployment = this.Columns["StateUnEmployment"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnAdditionalComments = new DataColumn("AdditionalComments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalComments);
      this.columnAutoliabSymbol = new DataColumn("AutoliabSymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoliabSymbol);
      this.columnPIPSymbol = new DataColumn("PIPSymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPIPSymbol);
      this.columnAddnPIPSymbol = new DataColumn("AddnPIPSymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddnPIPSymbol);
      this.columnPropProtectionSymbol = new DataColumn("PropProtectionSymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPropProtectionSymbol);
      this.columnMedPaySymbol = new DataColumn("MedPaySymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMedPaySymbol);
      this.columnUnInsSymbol = new DataColumn("UnInsSymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnInsSymbol);
      this.columnUnderInsSymbol = new DataColumn("UnderInsSymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderInsSymbol);
      this.columnRejectedTerrorism = new DataColumn("RejectedTerrorism", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRejectedTerrorism);
      this.columnTerrorism = new DataColumn("Terrorism", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrorism);
      this.columnCoverageTypeID = new DataColumn("CoverageTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageTypeID);
      this.columnAutoReportingBasis = new DataColumn("AutoReportingBasis", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoReportingBasis);
      this.columnAutoNonReportingBasis = new DataColumn("AutoNonReportingBasis", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoNonReportingBasis);
      this.columnAutoQuarterlyBasis = new DataColumn("AutoQuarterlyBasis", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoQuarterlyBasis);
      this.columnAutoMonthlyBasis = new DataColumn("AutoMonthlyBasis", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoMonthlyBasis);
      this.columnAutoNewComprehensive = new DataColumn("AutoNewComprehensive", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoNewComprehensive);
      this.columnAutoNewSpecCauseLoss = new DataColumn("AutoNewSpecCauseLoss", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoNewSpecCauseLoss);
      this.columnAutoNewCollision = new DataColumn("AutoNewCollision", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoNewCollision);
      this.columnAutoUsedComprehensive = new DataColumn("AutoUsedComprehensive", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoUsedComprehensive);
      this.columnAutoUsedSpecCauseLoss = new DataColumn("AutoUsedSpecCauseLoss", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoUsedSpecCauseLoss);
      this.columnAutoUsedCollision = new DataColumn("AutoUsedCollision", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoUsedCollision);
      this.columnAutoIntComprehensive = new DataColumn("AutoIntComprehensive", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoIntComprehensive);
      this.columnAutoIntSpecCauseLoss = new DataColumn("AutoIntSpecCauseLoss", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoIntSpecCauseLoss);
      this.columnAutoIntCollision = new DataColumn("AutoIntCollision", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoIntCollision);
      this.columnAutoFinanceComprehensive = new DataColumn("AutoFinanceComprehensive", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoFinanceComprehensive);
      this.columnAutoFinanceSpecCauseLoss = new DataColumn("AutoFinanceSpecCauseLoss", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoFinanceSpecCauseLoss);
      this.columnAutoFinanceCollision = new DataColumn("AutoFinanceCollision", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoFinanceCollision);
      this.columnAutoLossPayeeComprehensive = new DataColumn("AutoLossPayeeComprehensive", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoLossPayeeComprehensive);
      this.columnAutoLossPayeeSpecCauseLoss = new DataColumn("AutoLossPayeeSpecCauseLoss", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoLossPayeeSpecCauseLoss);
      this.columnAutoLossPayeeCollision = new DataColumn("AutoLossPayeeCollision", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoLossPayeeCollision);
      this.columnAutoConsignComprehensive = new DataColumn("AutoConsignComprehensive", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoConsignComprehensive);
      this.columnAutoConsignSpecCauseLoss = new DataColumn("AutoConsignSpecCauseLoss", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoConsignSpecCauseLoss);
      this.columnAutoConsignCollision = new DataColumn("AutoConsignCollision", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoConsignCollision);
      this.columnAutoComments = new DataColumn("AutoComments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoComments);
      this.columnGaragekeepersSymbol = new DataColumn("GaragekeepersSymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGaragekeepersSymbol);
      this.columnPhysDamCompSymbol = new DataColumn("PhysDamCompSymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhysDamCompSymbol);
      this.columnPhysDamCOLSymbol = new DataColumn("PhysDamCOLSymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhysDamCOLSymbol);
      this.columnPhysDamCollSymbol = new DataColumn("PhysDamCollSymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhysDamCollSymbol);
      this.columnRetroDate = new DataColumn("RetroDate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRetroDate);
      this.columnBodilyInjEachAcc = new DataColumn("BodilyInjEachAcc", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBodilyInjEachAcc);
      this.columnBodilyInjDiseaseAggLimit = new DataColumn("BodilyInjDiseaseAggLimit", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBodilyInjDiseaseAggLimit);
      this.columnBodilyInjDiseaseEachEmpl = new DataColumn("BodilyInjDiseaseEachEmpl", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBodilyInjDiseaseEachEmpl);
      this.columnTowingSymbol = new DataColumn("TowingSymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTowingSymbol);
      this.columnTrailerSymbol = new DataColumn("TrailerSymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTrailerSymbol);
      this.columnHiredAutoLimit = new DataColumn("HiredAutoLimit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHiredAutoLimit);
      this.columnNonownedLiabilitySymbol = new DataColumn("NonownedLiabilitySymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNonownedLiabilitySymbol);
      this.columnHiredAutoSymbol = new DataColumn("HiredAutoSymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHiredAutoSymbol);
      this.columnEndorseName = new DataColumn("EndorseName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorseName);
      this.columnEndorseSymbol = new DataColumn("EndorseSymbol", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorseSymbol);
      this.columnEndorseLimit = new DataColumn("EndorseLimit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorseLimit);
      this.columnEndorseDeductible = new DataColumn("EndorseDeductible", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorseDeductible);
      this.columnReceipts = new DataColumn("Receipts", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReceipts);
      this.columnNO_of_Empl = new DataColumn("NO_of_Empl", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNO_of_Empl);
      this.columnGL_Rate = new DataColumn("GL_Rate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGL_Rate);
      this.columnGL_Est_Premium = new DataColumn("GL_Est_Premium", typeof (double), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGL_Est_Premium);
      this.columnGL_Min_Premium = new DataColumn("GL_Min_Premium", typeof (double), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGL_Min_Premium);
      this.columnCompositeRated = new DataColumn("CompositeRated", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompositeRated);
      this.columnNumPoweredUnits = new DataColumn("NumPoweredUnits", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumPoweredUnits);
      this.columnStateUnEmployment = new DataColumn("StateUnEmployment", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateUnEmployment);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AutoIncrementSeed = -1L;
      this.columnID.AutoIncrementStep = -1L;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnQuoteGuid.AllowDBNull = false;
      this.columnAdditionalComments.MaxLength = 4000;
      this.columnAutoliabSymbol.MaxLength = 20;
      this.columnPIPSymbol.MaxLength = 10;
      this.columnAddnPIPSymbol.MaxLength = 10;
      this.columnPropProtectionSymbol.MaxLength = 10;
      this.columnMedPaySymbol.MaxLength = 10;
      this.columnUnInsSymbol.MaxLength = 10;
      this.columnUnderInsSymbol.MaxLength = 10;
      this.columnAutoReportingBasis.AllowDBNull = false;
      this.columnAutoReportingBasis.DefaultValue = (object) false;
      this.columnAutoNonReportingBasis.AllowDBNull = false;
      this.columnAutoNonReportingBasis.DefaultValue = (object) false;
      this.columnAutoQuarterlyBasis.AllowDBNull = false;
      this.columnAutoQuarterlyBasis.DefaultValue = (object) false;
      this.columnAutoMonthlyBasis.AllowDBNull = false;
      this.columnAutoMonthlyBasis.DefaultValue = (object) false;
      this.columnAutoNewComprehensive.AllowDBNull = false;
      this.columnAutoNewComprehensive.DefaultValue = (object) false;
      this.columnAutoNewSpecCauseLoss.AllowDBNull = false;
      this.columnAutoNewSpecCauseLoss.DefaultValue = (object) false;
      this.columnAutoNewCollision.AllowDBNull = false;
      this.columnAutoNewCollision.DefaultValue = (object) false;
      this.columnAutoUsedComprehensive.AllowDBNull = false;
      this.columnAutoUsedComprehensive.DefaultValue = (object) false;
      this.columnAutoUsedSpecCauseLoss.AllowDBNull = false;
      this.columnAutoUsedSpecCauseLoss.DefaultValue = (object) false;
      this.columnAutoUsedCollision.AllowDBNull = false;
      this.columnAutoUsedCollision.DefaultValue = (object) false;
      this.columnAutoIntComprehensive.AllowDBNull = false;
      this.columnAutoIntComprehensive.DefaultValue = (object) false;
      this.columnAutoIntSpecCauseLoss.AllowDBNull = false;
      this.columnAutoIntSpecCauseLoss.DefaultValue = (object) false;
      this.columnAutoIntCollision.AllowDBNull = false;
      this.columnAutoIntCollision.DefaultValue = (object) false;
      this.columnAutoFinanceComprehensive.AllowDBNull = false;
      this.columnAutoFinanceComprehensive.DefaultValue = (object) false;
      this.columnAutoFinanceSpecCauseLoss.AllowDBNull = false;
      this.columnAutoFinanceSpecCauseLoss.DefaultValue = (object) false;
      this.columnAutoFinanceCollision.AllowDBNull = false;
      this.columnAutoFinanceCollision.DefaultValue = (object) false;
      this.columnAutoLossPayeeComprehensive.AllowDBNull = false;
      this.columnAutoLossPayeeComprehensive.DefaultValue = (object) false;
      this.columnAutoLossPayeeSpecCauseLoss.AllowDBNull = false;
      this.columnAutoLossPayeeSpecCauseLoss.DefaultValue = (object) false;
      this.columnAutoLossPayeeCollision.AllowDBNull = false;
      this.columnAutoLossPayeeCollision.DefaultValue = (object) false;
      this.columnAutoConsignComprehensive.AllowDBNull = false;
      this.columnAutoConsignComprehensive.DefaultValue = (object) false;
      this.columnAutoConsignSpecCauseLoss.AllowDBNull = false;
      this.columnAutoConsignSpecCauseLoss.DefaultValue = (object) false;
      this.columnAutoConsignCollision.AllowDBNull = false;
      this.columnAutoConsignCollision.DefaultValue = (object) false;
      this.columnAutoComments.MaxLength = 500;
      this.columnCompositeRated.DefaultValue = (object) false;
      this.columnStateUnEmployment.MaxLength = 30;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow NewtblNetRateAdditionalDataRow()
    {
      return (dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateAdditionalDataRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNetRateAdditionalInfo.tblNetRateAdditionalDataRowChangeEventHandler dataRowChangedEvent = this.tblNetRateAdditionalDataRowChangedEvent;
      if (dataRowChangedEvent == null)
        return;
      dataRowChangedEvent((object) this, new dsNetRateAdditionalInfo.tblNetRateAdditionalDataRowChangeEvent((dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateAdditionalDataRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNetRateAdditionalInfo.tblNetRateAdditionalDataRowChangeEventHandler rowChangingEvent = this.tblNetRateAdditionalDataRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsNetRateAdditionalInfo.tblNetRateAdditionalDataRowChangeEvent((dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateAdditionalDataRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNetRateAdditionalInfo.tblNetRateAdditionalDataRowChangeEventHandler dataRowDeletedEvent = this.tblNetRateAdditionalDataRowDeletedEvent;
      if (dataRowDeletedEvent == null)
        return;
      dataRowDeletedEvent((object) this, new dsNetRateAdditionalInfo.tblNetRateAdditionalDataRowChangeEvent((dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateAdditionalDataRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNetRateAdditionalInfo.tblNetRateAdditionalDataRowChangeEventHandler rowDeletingEvent = this.tblNetRateAdditionalDataRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsNetRateAdditionalInfo.tblNetRateAdditionalDataRowChangeEvent((dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblNetRateAdditionalDataRow(
      dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNetRateAdditionalInfo rateAdditionalInfo = new dsNetRateAdditionalInfo();
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
        FixedValue = rateAdditionalInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblNetRateAdditionalDataDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = rateAdditionalInfo.GetSchemaSerializable();
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

  public class lstGLCoverageTypeRow : DataRow
  {
    private dsNetRateAdditionalInfo.lstGLCoverageTypeDataTable tablelstGLCoverageType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstGLCoverageTypeRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstGLCoverageType = (dsNetRateAdditionalInfo.lstGLCoverageTypeDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstGLCoverageType.IDColumn]);
      set => this[this.tablelstGLCoverageType.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CoverageType
    {
      get => Conversions.ToString(this[this.tablelstGLCoverageType.CoverageTypeColumn]);
      set => this[this.tablelstGLCoverageType.CoverageTypeColumn] = (object) value;
    }
  }

  public class tblNetRateAdditionalDataRow : DataRow
  {
    private dsNetRateAdditionalInfo.tblNetRateAdditionalDataDataTable tabletblNetRateAdditionalData;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblNetRateAdditionalDataRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblNetRateAdditionalData = (dsNetRateAdditionalInfo.tblNetRateAdditionalDataDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblNetRateAdditionalData.IDColumn]);
      set => this[this.tabletblNetRateAdditionalData.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        object obj = this[this.tabletblNetRateAdditionalData.QuoteGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblNetRateAdditionalData.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AdditionalComments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.AdditionalCommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdditionalComments' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.AdditionalCommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AutoliabSymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.AutoliabSymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AutoliabSymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.AutoliabSymbolColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PIPSymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.PIPSymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PIPSymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.PIPSymbolColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AddnPIPSymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.AddnPIPSymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddnPIPSymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.AddnPIPSymbolColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PropProtectionSymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.PropProtectionSymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PropProtectionSymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.PropProtectionSymbolColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string MedPaySymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.MedPaySymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MedPaySymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.MedPaySymbolColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string UnInsSymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.UnInsSymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnInsSymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.UnInsSymbolColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string UnderInsSymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.UnderInsSymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnderInsSymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.UnderInsSymbolColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal RejectedTerrorism
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblNetRateAdditionalData.RejectedTerrorismColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RejectedTerrorism' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.RejectedTerrorismColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Terrorism
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblNetRateAdditionalData.TerrorismColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Terrorism' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.TerrorismColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CoverageTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNetRateAdditionalData.CoverageTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CoverageTypeID' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.CoverageTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoReportingBasis
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoReportingBasisColumn]);
      }
      set => this[this.tabletblNetRateAdditionalData.AutoReportingBasisColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoNonReportingBasis
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoNonReportingBasisColumn]);
      }
      set => this[this.tabletblNetRateAdditionalData.AutoNonReportingBasisColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoQuarterlyBasis
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoQuarterlyBasisColumn]);
      }
      set => this[this.tabletblNetRateAdditionalData.AutoQuarterlyBasisColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoMonthlyBasis
    {
      get => Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoMonthlyBasisColumn]);
      set => this[this.tabletblNetRateAdditionalData.AutoMonthlyBasisColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoNewComprehensive
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoNewComprehensiveColumn]);
      }
      set => this[this.tabletblNetRateAdditionalData.AutoNewComprehensiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoNewSpecCauseLoss
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoNewSpecCauseLossColumn]);
      }
      set => this[this.tabletblNetRateAdditionalData.AutoNewSpecCauseLossColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoNewCollision
    {
      get => Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoNewCollisionColumn]);
      set => this[this.tabletblNetRateAdditionalData.AutoNewCollisionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoUsedComprehensive
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoUsedComprehensiveColumn]);
      }
      set => this[this.tabletblNetRateAdditionalData.AutoUsedComprehensiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoUsedSpecCauseLoss
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoUsedSpecCauseLossColumn]);
      }
      set => this[this.tabletblNetRateAdditionalData.AutoUsedSpecCauseLossColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoUsedCollision
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoUsedCollisionColumn]);
      }
      set => this[this.tabletblNetRateAdditionalData.AutoUsedCollisionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoIntComprehensive
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoIntComprehensiveColumn]);
      }
      set => this[this.tabletblNetRateAdditionalData.AutoIntComprehensiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoIntSpecCauseLoss
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoIntSpecCauseLossColumn]);
      }
      set => this[this.tabletblNetRateAdditionalData.AutoIntSpecCauseLossColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoIntCollision
    {
      get => Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoIntCollisionColumn]);
      set => this[this.tabletblNetRateAdditionalData.AutoIntCollisionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoFinanceComprehensive
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoFinanceComprehensiveColumn]);
      }
      set
      {
        this[this.tabletblNetRateAdditionalData.AutoFinanceComprehensiveColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoFinanceSpecCauseLoss
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoFinanceSpecCauseLossColumn]);
      }
      set
      {
        this[this.tabletblNetRateAdditionalData.AutoFinanceSpecCauseLossColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoFinanceCollision
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoFinanceCollisionColumn]);
      }
      set => this[this.tabletblNetRateAdditionalData.AutoFinanceCollisionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoLossPayeeComprehensive
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoLossPayeeComprehensiveColumn]);
      }
      set
      {
        this[this.tabletblNetRateAdditionalData.AutoLossPayeeComprehensiveColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoLossPayeeSpecCauseLoss
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoLossPayeeSpecCauseLossColumn]);
      }
      set
      {
        this[this.tabletblNetRateAdditionalData.AutoLossPayeeSpecCauseLossColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoLossPayeeCollision
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoLossPayeeCollisionColumn]);
      }
      set => this[this.tabletblNetRateAdditionalData.AutoLossPayeeCollisionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoConsignComprehensive
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoConsignComprehensiveColumn]);
      }
      set
      {
        this[this.tabletblNetRateAdditionalData.AutoConsignComprehensiveColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoConsignSpecCauseLoss
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoConsignSpecCauseLossColumn]);
      }
      set
      {
        this[this.tabletblNetRateAdditionalData.AutoConsignSpecCauseLossColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AutoConsignCollision
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.AutoConsignCollisionColumn]);
      }
      set => this[this.tabletblNetRateAdditionalData.AutoConsignCollisionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AutoComments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.AutoCommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AutoComments' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.AutoCommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string GaragekeepersSymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.GaragekeepersSymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GaragekeepersSymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.GaragekeepersSymbolColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PhysDamCompSymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.PhysDamCompSymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PhysDamCompSymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.PhysDamCompSymbolColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PhysDamCOLSymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.PhysDamCOLSymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PhysDamCOLSymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.PhysDamCOLSymbolColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PhysDamCollSymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.PhysDamCollSymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PhysDamCollSymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.PhysDamCollSymbolColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string RetroDate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.RetroDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RetroDate' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.RetroDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BodilyInjEachAcc
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.BodilyInjEachAccColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BodilyInjEachAcc' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.BodilyInjEachAccColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BodilyInjDiseaseAggLimit
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.BodilyInjDiseaseAggLimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BodilyInjDiseaseAggLimit' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblNetRateAdditionalData.BodilyInjDiseaseAggLimitColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BodilyInjDiseaseEachEmpl
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.BodilyInjDiseaseEachEmplColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BodilyInjDiseaseEachEmpl' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblNetRateAdditionalData.BodilyInjDiseaseEachEmplColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string TowingSymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.TowingSymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TowingSymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.TowingSymbolColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string TrailerSymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.TrailerSymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TrailerSymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.TrailerSymbolColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal HiredAutoLimit
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblNetRateAdditionalData.HiredAutoLimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'HiredAutoLimit' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.HiredAutoLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string NonownedLiabilitySymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.NonownedLiabilitySymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NonownedLiabilitySymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblNetRateAdditionalData.NonownedLiabilitySymbolColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string HiredAutoSymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.HiredAutoSymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'HiredAutoSymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.HiredAutoSymbolColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EndorseName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.EndorseNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorseName' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.EndorseNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EndorseSymbol
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.EndorseSymbolColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorseSymbol' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.EndorseSymbolColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal EndorseLimit
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblNetRateAdditionalData.EndorseLimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorseLimit' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.EndorseLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal EndorseDeductible
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblNetRateAdditionalData.EndorseDeductibleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorseDeductible' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.EndorseDeductibleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Receipts
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblNetRateAdditionalData.ReceiptsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Receipts' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.ReceiptsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public short NO_of_Empl
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblNetRateAdditionalData.NO_of_EmplColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NO_of_Empl' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.NO_of_EmplColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal GL_Rate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblNetRateAdditionalData.GL_RateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GL_Rate' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.GL_RateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public double GL_Est_Premium
    {
      get
      {
        try
        {
          return Conversions.ToDouble(this[this.tabletblNetRateAdditionalData.GL_Est_PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GL_Est_Premium' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.GL_Est_PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public double GL_Min_Premium
    {
      get
      {
        try
        {
          return Conversions.ToDouble(this[this.tabletblNetRateAdditionalData.GL_Min_PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GL_Min_Premium' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.GL_Min_PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool CompositeRated
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblNetRateAdditionalData.CompositeRatedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompositeRated' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.CompositeRatedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int NumPoweredUnits
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNetRateAdditionalData.NumPoweredUnitsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumPoweredUnits' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.NumPoweredUnitsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StateUnEmployment
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNetRateAdditionalData.StateUnEmploymentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateUnEmployment' in table 'tblNetRateAdditionalData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateAdditionalData.StateUnEmploymentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAdditionalCommentsNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.AdditionalCommentsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAdditionalCommentsNull()
    {
      this[this.tabletblNetRateAdditionalData.AdditionalCommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAutoliabSymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.AutoliabSymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAutoliabSymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.AutoliabSymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPIPSymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.PIPSymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPIPSymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.PIPSymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddnPIPSymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.AddnPIPSymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddnPIPSymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.AddnPIPSymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPropProtectionSymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.PropProtectionSymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPropProtectionSymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.PropProtectionSymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMedPaySymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.MedPaySymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMedPaySymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.MedPaySymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUnInsSymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.UnInsSymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUnInsSymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.UnInsSymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUnderInsSymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.UnderInsSymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUnderInsSymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.UnderInsSymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRejectedTerrorismNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.RejectedTerrorismColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRejectedTerrorismNull()
    {
      this[this.tabletblNetRateAdditionalData.RejectedTerrorismColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTerrorismNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.TerrorismColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTerrorismNull()
    {
      this[this.tabletblNetRateAdditionalData.TerrorismColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCoverageTypeIDNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.CoverageTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCoverageTypeIDNull()
    {
      this[this.tabletblNetRateAdditionalData.CoverageTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAutoCommentsNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.AutoCommentsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAutoCommentsNull()
    {
      this[this.tabletblNetRateAdditionalData.AutoCommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsGaragekeepersSymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.GaragekeepersSymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetGaragekeepersSymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.GaragekeepersSymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPhysDamCompSymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.PhysDamCompSymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPhysDamCompSymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.PhysDamCompSymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPhysDamCOLSymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.PhysDamCOLSymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPhysDamCOLSymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.PhysDamCOLSymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPhysDamCollSymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.PhysDamCollSymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPhysDamCollSymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.PhysDamCollSymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRetroDateNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.RetroDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRetroDateNull()
    {
      this[this.tabletblNetRateAdditionalData.RetroDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBodilyInjEachAccNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.BodilyInjEachAccColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBodilyInjEachAccNull()
    {
      this[this.tabletblNetRateAdditionalData.BodilyInjEachAccColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBodilyInjDiseaseAggLimitNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.BodilyInjDiseaseAggLimitColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBodilyInjDiseaseAggLimitNull()
    {
      this[this.tabletblNetRateAdditionalData.BodilyInjDiseaseAggLimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBodilyInjDiseaseEachEmplNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.BodilyInjDiseaseEachEmplColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBodilyInjDiseaseEachEmplNull()
    {
      this[this.tabletblNetRateAdditionalData.BodilyInjDiseaseEachEmplColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTowingSymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.TowingSymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTowingSymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.TowingSymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTrailerSymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.TrailerSymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTrailerSymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.TrailerSymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsHiredAutoLimitNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.HiredAutoLimitColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetHiredAutoLimitNull()
    {
      this[this.tabletblNetRateAdditionalData.HiredAutoLimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNonownedLiabilitySymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.NonownedLiabilitySymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNonownedLiabilitySymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.NonownedLiabilitySymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsHiredAutoSymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.HiredAutoSymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetHiredAutoSymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.HiredAutoSymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEndorseNameNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.EndorseNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEndorseNameNull()
    {
      this[this.tabletblNetRateAdditionalData.EndorseNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEndorseSymbolNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.EndorseSymbolColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEndorseSymbolNull()
    {
      this[this.tabletblNetRateAdditionalData.EndorseSymbolColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEndorseLimitNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.EndorseLimitColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEndorseLimitNull()
    {
      this[this.tabletblNetRateAdditionalData.EndorseLimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEndorseDeductibleNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.EndorseDeductibleColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEndorseDeductibleNull()
    {
      this[this.tabletblNetRateAdditionalData.EndorseDeductibleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsReceiptsNull() => this.IsNull(this.tabletblNetRateAdditionalData.ReceiptsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetReceiptsNull()
    {
      this[this.tabletblNetRateAdditionalData.ReceiptsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNO_of_EmplNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.NO_of_EmplColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNO_of_EmplNull()
    {
      this[this.tabletblNetRateAdditionalData.NO_of_EmplColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsGL_RateNull() => this.IsNull(this.tabletblNetRateAdditionalData.GL_RateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetGL_RateNull()
    {
      this[this.tabletblNetRateAdditionalData.GL_RateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsGL_Est_PremiumNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.GL_Est_PremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetGL_Est_PremiumNull()
    {
      this[this.tabletblNetRateAdditionalData.GL_Est_PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsGL_Min_PremiumNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.GL_Min_PremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetGL_Min_PremiumNull()
    {
      this[this.tabletblNetRateAdditionalData.GL_Min_PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompositeRatedNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.CompositeRatedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompositeRatedNull()
    {
      this[this.tabletblNetRateAdditionalData.CompositeRatedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNumPoweredUnitsNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.NumPoweredUnitsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNumPoweredUnitsNull()
    {
      this[this.tabletblNetRateAdditionalData.NumPoweredUnitsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateUnEmploymentNull()
    {
      return this.IsNull(this.tabletblNetRateAdditionalData.StateUnEmploymentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateUnEmploymentNull()
    {
      this[this.tabletblNetRateAdditionalData.StateUnEmploymentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstGLCoverageTypeRowChangeEvent : EventArgs
  {
    private dsNetRateAdditionalInfo.lstGLCoverageTypeRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstGLCoverageTypeRowChangeEvent(
      dsNetRateAdditionalInfo.lstGLCoverageTypeRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNetRateAdditionalInfo.lstGLCoverageTypeRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblNetRateAdditionalDataRowChangeEvent : EventArgs
  {
    private dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblNetRateAdditionalDataRowChangeEvent(
      dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNetRateAdditionalInfo.tblNetRateAdditionalDataRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
