// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.dsExlAddInfo
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

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
namespace MGASystems.IMS.Policies.Inspections;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsExlAddInfo")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsExlAddInfo : DataSet
{
  private dsExlAddInfo.dtReportsDataTable tabledtReports;
  private dsExlAddInfo.dtSupplementsDataTable tabledtSupplements;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public dsExlAddInfo()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected dsExlAddInfo(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (dtReports)] != null)
          base.Tables.Add((DataTable) new dsExlAddInfo.dtReportsDataTable(dataSet.Tables[nameof (dtReports)]));
        if (dataSet.Tables[nameof (dtSupplements)] != null)
          base.Tables.Add((DataTable) new dsExlAddInfo.dtSupplementsDataTable(dataSet.Tables[nameof (dtSupplements)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsExlAddInfo.dtReportsDataTable dtReports => this.tabledtReports;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsExlAddInfo.dtSupplementsDataTable dtSupplements => this.tabledtSupplements;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public override DataSet Clone()
  {
    dsExlAddInfo dsExlAddInfo = (dsExlAddInfo) base.Clone();
    dsExlAddInfo.InitVars();
    dsExlAddInfo.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsExlAddInfo;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["dtReports"] != null)
        base.Tables.Add((DataTable) new dsExlAddInfo.dtReportsDataTable(dataSet.Tables["dtReports"]));
      if (dataSet.Tables["dtSupplements"] != null)
        base.Tables.Add((DataTable) new dsExlAddInfo.dtSupplementsDataTable(dataSet.Tables["dtSupplements"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tabledtReports = (dsExlAddInfo.dtReportsDataTable) base.Tables["dtReports"];
    if (initTable && this.tabledtReports != null)
      this.tabledtReports.InitVars();
    this.tabledtSupplements = (dsExlAddInfo.dtSupplementsDataTable) base.Tables["dtSupplements"];
    if (!initTable || this.tabledtSupplements == null)
      return;
    this.tabledtSupplements.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsExlAddInfo);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsExlAddInfo.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabledtReports = new dsExlAddInfo.dtReportsDataTable();
    base.Tables.Add((DataTable) this.tabledtReports);
    this.tabledtSupplements = new dsExlAddInfo.dtSupplementsDataTable();
    base.Tables.Add((DataTable) this.tabledtSupplements);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializedtReports() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializedtSupplements() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsExlAddInfo dsExlAddInfo = new dsExlAddInfo();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsExlAddInfo.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsExlAddInfo.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void dtReportsRowChangeEventHandler(
    object sender,
    dsExlAddInfo.dtReportsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void dtSupplementsRowChangeEventHandler(
    object sender,
    dsExlAddInfo.dtSupplementsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class dtReportsDataTable : TypedTableBase<dsExlAddInfo.dtReportsRow>
  {
    private DataColumn columnReport;
    private DataColumn columnRowSelection;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dtReportsDataTable()
    {
      this.TableName = "dtReports";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal dtReportsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected dtReportsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ReportColumn => this.columnReport;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn RowSelectionColumn => this.columnRowSelection;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsExlAddInfo.dtReportsRow this[int index]
    {
      get => (dsExlAddInfo.dtReportsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsExlAddInfo.dtReportsRowChangeEventHandler dtReportsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsExlAddInfo.dtReportsRowChangeEventHandler dtReportsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsExlAddInfo.dtReportsRowChangeEventHandler dtReportsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsExlAddInfo.dtReportsRowChangeEventHandler dtReportsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AdddtReportsRow(dsExlAddInfo.dtReportsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsExlAddInfo.dtReportsRow AdddtReportsRow(string Report, bool RowSelection)
    {
      dsExlAddInfo.dtReportsRow row = (dsExlAddInfo.dtReportsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Report,
        (object) RowSelection
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsExlAddInfo.dtReportsDataTable reportsDataTable = (dsExlAddInfo.dtReportsDataTable) base.Clone();
      reportsDataTable.InitVars();
      return (DataTable) reportsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExlAddInfo.dtReportsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnReport = this.Columns["Report"];
      this.columnRowSelection = this.Columns["RowSelection"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnReport = new DataColumn("Report", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReport);
      this.columnRowSelection = new DataColumn("RowSelection", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRowSelection);
      this.columnRowSelection.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsExlAddInfo.dtReportsRow NewdtReportsRow() => (dsExlAddInfo.dtReportsRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExlAddInfo.dtReportsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsExlAddInfo.dtReportsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtReportsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExlAddInfo.dtReportsRowChangeEventHandler reportsRowChangedEvent = this.dtReportsRowChangedEvent;
      if (reportsRowChangedEvent == null)
        return;
      reportsRowChangedEvent((object) this, new dsExlAddInfo.dtReportsRowChangeEvent((dsExlAddInfo.dtReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtReportsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExlAddInfo.dtReportsRowChangeEventHandler rowChangingEvent = this.dtReportsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExlAddInfo.dtReportsRowChangeEvent((dsExlAddInfo.dtReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtReportsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExlAddInfo.dtReportsRowChangeEventHandler reportsRowDeletedEvent = this.dtReportsRowDeletedEvent;
      if (reportsRowDeletedEvent == null)
        return;
      reportsRowDeletedEvent((object) this, new dsExlAddInfo.dtReportsRowChangeEvent((dsExlAddInfo.dtReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtReportsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExlAddInfo.dtReportsRowChangeEventHandler rowDeletingEvent = this.dtReportsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExlAddInfo.dtReportsRowChangeEvent((dsExlAddInfo.dtReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovedtReportsRow(dsExlAddInfo.dtReportsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsExlAddInfo dsExlAddInfo = new dsExlAddInfo();
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
        FixedValue = dsExlAddInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtReportsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsExlAddInfo.GetSchemaSerializable();
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
  public class dtSupplementsDataTable : TypedTableBase<dsExlAddInfo.dtSupplementsRow>
  {
    private DataColumn columnSupplement;
    private DataColumn columnRowSelection;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dtSupplementsDataTable()
    {
      this.TableName = "dtSupplements";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal dtSupplementsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected dtSupplementsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn SupplementColumn => this.columnSupplement;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn RowSelectionColumn => this.columnRowSelection;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsExlAddInfo.dtSupplementsRow this[int index]
    {
      get => (dsExlAddInfo.dtSupplementsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsExlAddInfo.dtSupplementsRowChangeEventHandler dtSupplementsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsExlAddInfo.dtSupplementsRowChangeEventHandler dtSupplementsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsExlAddInfo.dtSupplementsRowChangeEventHandler dtSupplementsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsExlAddInfo.dtSupplementsRowChangeEventHandler dtSupplementsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AdddtSupplementsRow(dsExlAddInfo.dtSupplementsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsExlAddInfo.dtSupplementsRow AdddtSupplementsRow(string Supplement, bool RowSelection)
    {
      dsExlAddInfo.dtSupplementsRow row = (dsExlAddInfo.dtSupplementsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Supplement,
        (object) RowSelection
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsExlAddInfo.dtSupplementsDataTable supplementsDataTable = (dsExlAddInfo.dtSupplementsDataTable) base.Clone();
      supplementsDataTable.InitVars();
      return (DataTable) supplementsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExlAddInfo.dtSupplementsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnSupplement = this.Columns["Supplement"];
      this.columnRowSelection = this.Columns["RowSelection"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnSupplement = new DataColumn("Supplement", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSupplement);
      this.columnRowSelection = new DataColumn("RowSelection", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRowSelection);
      this.columnRowSelection.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsExlAddInfo.dtSupplementsRow NewdtSupplementsRow()
    {
      return (dsExlAddInfo.dtSupplementsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExlAddInfo.dtSupplementsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsExlAddInfo.dtSupplementsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtSupplementsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExlAddInfo.dtSupplementsRowChangeEventHandler supplementsRowChangedEvent = this.dtSupplementsRowChangedEvent;
      if (supplementsRowChangedEvent == null)
        return;
      supplementsRowChangedEvent((object) this, new dsExlAddInfo.dtSupplementsRowChangeEvent((dsExlAddInfo.dtSupplementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtSupplementsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExlAddInfo.dtSupplementsRowChangeEventHandler rowChangingEvent = this.dtSupplementsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExlAddInfo.dtSupplementsRowChangeEvent((dsExlAddInfo.dtSupplementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtSupplementsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExlAddInfo.dtSupplementsRowChangeEventHandler supplementsRowDeletedEvent = this.dtSupplementsRowDeletedEvent;
      if (supplementsRowDeletedEvent == null)
        return;
      supplementsRowDeletedEvent((object) this, new dsExlAddInfo.dtSupplementsRowChangeEvent((dsExlAddInfo.dtSupplementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtSupplementsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExlAddInfo.dtSupplementsRowChangeEventHandler rowDeletingEvent = this.dtSupplementsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExlAddInfo.dtSupplementsRowChangeEvent((dsExlAddInfo.dtSupplementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovedtSupplementsRow(dsExlAddInfo.dtSupplementsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsExlAddInfo dsExlAddInfo = new dsExlAddInfo();
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
        FixedValue = dsExlAddInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtSupplementsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsExlAddInfo.GetSchemaSerializable();
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

  public class dtReportsRow : DataRow
  {
    private dsExlAddInfo.dtReportsDataTable tabledtReports;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal dtReportsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtReports = (dsExlAddInfo.dtReportsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Report
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtReports.ReportColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Report' in table 'dtReports' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReports.ReportColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool RowSelection
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtReports.RowSelectionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RowSelection' in table 'dtReports' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtReports.RowSelectionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsReportNull() => this.IsNull(this.tabledtReports.ReportColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetReportNull()
    {
      this[this.tabledtReports.ReportColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsRowSelectionNull() => this.IsNull(this.tabledtReports.RowSelectionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetRowSelectionNull()
    {
      this[this.tabledtReports.RowSelectionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtSupplementsRow : DataRow
  {
    private dsExlAddInfo.dtSupplementsDataTable tabledtSupplements;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal dtSupplementsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtSupplements = (dsExlAddInfo.dtSupplementsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Supplement
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtSupplements.SupplementColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Supplement' in table 'dtSupplements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtSupplements.SupplementColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool RowSelection
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtSupplements.RowSelectionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RowSelection' in table 'dtSupplements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtSupplements.RowSelectionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsSupplementNull() => this.IsNull(this.tabledtSupplements.SupplementColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetSupplementNull()
    {
      this[this.tabledtSupplements.SupplementColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsRowSelectionNull() => this.IsNull(this.tabledtSupplements.RowSelectionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetRowSelectionNull()
    {
      this[this.tabledtSupplements.RowSelectionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class dtReportsRowChangeEvent : EventArgs
  {
    private dsExlAddInfo.dtReportsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dtReportsRowChangeEvent(dsExlAddInfo.dtReportsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsExlAddInfo.dtReportsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class dtSupplementsRowChangeEvent : EventArgs
  {
    private dsExlAddInfo.dtSupplementsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dtSupplementsRowChangeEvent(dsExlAddInfo.dtSupplementsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsExlAddInfo.dtSupplementsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
