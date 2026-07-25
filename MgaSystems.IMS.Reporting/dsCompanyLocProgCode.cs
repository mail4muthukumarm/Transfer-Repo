// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.dsCompanyLocProgCode
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

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
namespace MGASystems.IMS.Reporting;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCompanyLocProgCode")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyLocProgCode : DataSet
{
  private dsCompanyLocProgCode.tblCompanyLocationsDataTable tabletblCompanyLocations;
  private dsCompanyLocProgCode.tblCompanyProgramCodesDataTable tabletblCompanyProgramCodes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsCompanyLocProgCode()
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
  protected dsCompanyLocProgCode(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyLocations)] != null)
          base.Tables.Add((DataTable) new dsCompanyLocProgCode.tblCompanyLocationsDataTable(dataSet.Tables[nameof (tblCompanyLocations)]));
        if (dataSet.Tables[nameof (tblCompanyProgramCodes)] != null)
          base.Tables.Add((DataTable) new dsCompanyLocProgCode.tblCompanyProgramCodesDataTable(dataSet.Tables[nameof (tblCompanyProgramCodes)]));
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
  public dsCompanyLocProgCode.tblCompanyLocationsDataTable tblCompanyLocations
  {
    get => this.tabletblCompanyLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyLocProgCode.tblCompanyProgramCodesDataTable tblCompanyProgramCodes
  {
    get => this.tabletblCompanyProgramCodes;
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
    dsCompanyLocProgCode companyLocProgCode = (dsCompanyLocProgCode) base.Clone();
    companyLocProgCode.InitVars();
    companyLocProgCode.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) companyLocProgCode;
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
      if (dataSet.Tables["tblCompanyLocations"] != null)
        base.Tables.Add((DataTable) new dsCompanyLocProgCode.tblCompanyLocationsDataTable(dataSet.Tables["tblCompanyLocations"]));
      if (dataSet.Tables["tblCompanyProgramCodes"] != null)
        base.Tables.Add((DataTable) new dsCompanyLocProgCode.tblCompanyProgramCodesDataTable(dataSet.Tables["tblCompanyProgramCodes"]));
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
    this.tabletblCompanyLocations = (dsCompanyLocProgCode.tblCompanyLocationsDataTable) base.Tables["tblCompanyLocations"];
    if (initTable && this.tabletblCompanyLocations != null)
      this.tabletblCompanyLocations.InitVars();
    this.tabletblCompanyProgramCodes = (dsCompanyLocProgCode.tblCompanyProgramCodesDataTable) base.Tables["tblCompanyProgramCodes"];
    if (!initTable || this.tabletblCompanyProgramCodes == null)
      return;
    this.tabletblCompanyProgramCodes.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyLocProgCode);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsCompanyLocProgCode.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyLocations = new dsCompanyLocProgCode.tblCompanyLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLocations);
    this.tabletblCompanyProgramCodes = new dsCompanyLocProgCode.tblCompanyProgramCodesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyProgramCodes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanyLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanyProgramCodes() => false;

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
    dsCompanyLocProgCode companyLocProgCode = new dsCompanyLocProgCode();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = companyLocProgCode.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = companyLocProgCode.GetSchemaSerializable();
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
  public delegate void tblCompanyLocationsRowChangeEventHandler(
    object sender,
    dsCompanyLocProgCode.tblCompanyLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblCompanyProgramCodesRowChangeEventHandler(
    object sender,
    dsCompanyLocProgCode.tblCompanyProgramCodesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyLocationsDataTable : 
    TypedTableBase<dsCompanyLocProgCode.tblCompanyLocationsRow>
  {
    private DataColumn columnIsSelected;
    private DataColumn columnDisplay;
    private DataColumn columnValue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyLocationsDataTable()
    {
      this.TableName = "tblCompanyLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyLocationsDataTable(DataTable table)
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
    protected tblCompanyLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IsSelectedColumn => this.columnIsSelected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisplayColumn => this.columnDisplay;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ValueColumn => this.columnValue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLocProgCode.tblCompanyLocationsRow this[int index]
    {
      get => (dsCompanyLocProgCode.tblCompanyLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLocProgCode.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLocProgCode.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLocProgCode.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLocProgCode.tblCompanyLocationsRowChangeEventHandler tblCompanyLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompanyLocationsRow(dsCompanyLocProgCode.tblCompanyLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLocProgCode.tblCompanyLocationsRow AddtblCompanyLocationsRow(
      bool IsSelected,
      string Display,
      Guid Value)
    {
      dsCompanyLocProgCode.tblCompanyLocationsRow row = (dsCompanyLocProgCode.tblCompanyLocationsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) IsSelected,
        (object) Display,
        (object) Value
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLocProgCode.tblCompanyLocationsDataTable locationsDataTable = (dsCompanyLocProgCode.tblCompanyLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLocProgCode.tblCompanyLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnIsSelected = this.Columns["IsSelected"];
      this.columnDisplay = this.Columns["Display"];
      this.columnValue = this.Columns["Value"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnIsSelected = new DataColumn("IsSelected", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsSelected);
      this.columnDisplay = new DataColumn("Display", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisplay);
      this.columnValue = new DataColumn("Value", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnValue);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLocProgCode.tblCompanyLocationsRow NewtblCompanyLocationsRow()
    {
      return (dsCompanyLocProgCode.tblCompanyLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLocProgCode.tblCompanyLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyLocProgCode.tblCompanyLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLocProgCode.tblCompanyLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblCompanyLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsCompanyLocProgCode.tblCompanyLocationsRowChangeEvent((dsCompanyLocProgCode.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLocProgCode.tblCompanyLocationsRowChangeEventHandler rowChangingEvent = this.tblCompanyLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLocProgCode.tblCompanyLocationsRowChangeEvent((dsCompanyLocProgCode.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLocProgCode.tblCompanyLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblCompanyLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsCompanyLocProgCode.tblCompanyLocationsRowChangeEvent((dsCompanyLocProgCode.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLocProgCode.tblCompanyLocationsRowChangeEventHandler rowDeletingEvent = this.tblCompanyLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLocProgCode.tblCompanyLocationsRowChangeEvent((dsCompanyLocProgCode.tblCompanyLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompanyLocationsRow(dsCompanyLocProgCode.tblCompanyLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLocProgCode companyLocProgCode = new dsCompanyLocProgCode();
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
        FixedValue = companyLocProgCode.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyLocProgCode.GetSchemaSerializable();
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
  public class tblCompanyProgramCodesDataTable : 
    TypedTableBase<dsCompanyLocProgCode.tblCompanyProgramCodesRow>
  {
    private DataColumn columnIsSelected;
    private DataColumn columnDisplay;
    private DataColumn columnValue;
    private DataColumn columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyProgramCodesDataTable()
    {
      this.TableName = "tblCompanyProgramCodes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyProgramCodesDataTable(DataTable table)
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
    protected tblCompanyProgramCodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IsSelectedColumn => this.columnIsSelected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisplayColumn => this.columnDisplay;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ValueColumn => this.columnValue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLocProgCode.tblCompanyProgramCodesRow this[int index]
    {
      get => (dsCompanyLocProgCode.tblCompanyProgramCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLocProgCode.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLocProgCode.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLocProgCode.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsCompanyLocProgCode.tblCompanyProgramCodesRowChangeEventHandler tblCompanyProgramCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompanyProgramCodesRow(dsCompanyLocProgCode.tblCompanyProgramCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLocProgCode.tblCompanyProgramCodesRow AddtblCompanyProgramCodesRow(
      bool IsSelected,
      string Display,
      string Value,
      Guid CompanyLocationGuid)
    {
      dsCompanyLocProgCode.tblCompanyProgramCodesRow row = (dsCompanyLocProgCode.tblCompanyProgramCodesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) IsSelected,
        (object) Display,
        (object) Value,
        (object) CompanyLocationGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLocProgCode.tblCompanyProgramCodesDataTable programCodesDataTable = (dsCompanyLocProgCode.tblCompanyProgramCodesDataTable) base.Clone();
      programCodesDataTable.InitVars();
      return (DataTable) programCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLocProgCode.tblCompanyProgramCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnIsSelected = this.Columns["IsSelected"];
      this.columnDisplay = this.Columns["Display"];
      this.columnValue = this.Columns["Value"];
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnIsSelected = new DataColumn("IsSelected", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsSelected);
      this.columnDisplay = new DataColumn("Display", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisplay);
      this.columnValue = new DataColumn("Value", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnValue);
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLocProgCode.tblCompanyProgramCodesRow NewtblCompanyProgramCodesRow()
    {
      return (dsCompanyLocProgCode.tblCompanyProgramCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLocProgCode.tblCompanyProgramCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyLocProgCode.tblCompanyProgramCodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLocProgCode.tblCompanyProgramCodesRowChangeEventHandler codesRowChangedEvent = this.tblCompanyProgramCodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsCompanyLocProgCode.tblCompanyProgramCodesRowChangeEvent((dsCompanyLocProgCode.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLocProgCode.tblCompanyProgramCodesRowChangeEventHandler rowChangingEvent = this.tblCompanyProgramCodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLocProgCode.tblCompanyProgramCodesRowChangeEvent((dsCompanyLocProgCode.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLocProgCode.tblCompanyProgramCodesRowChangeEventHandler codesRowDeletedEvent = this.tblCompanyProgramCodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsCompanyLocProgCode.tblCompanyProgramCodesRowChangeEvent((dsCompanyLocProgCode.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProgramCodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLocProgCode.tblCompanyProgramCodesRowChangeEventHandler rowDeletingEvent = this.tblCompanyProgramCodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLocProgCode.tblCompanyProgramCodesRowChangeEvent((dsCompanyLocProgCode.tblCompanyProgramCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompanyProgramCodesRow(dsCompanyLocProgCode.tblCompanyProgramCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLocProgCode companyLocProgCode = new dsCompanyLocProgCode();
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
        FixedValue = companyLocProgCode.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyProgramCodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyLocProgCode.GetSchemaSerializable();
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

  public class tblCompanyLocationsRow : DataRow
  {
    private dsCompanyLocProgCode.tblCompanyLocationsDataTable tabletblCompanyLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLocations = (dsCompanyLocProgCode.tblCompanyLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSelected
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLocations.IsSelectedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IsSelected' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.IsSelectedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Display
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLocations.DisplayColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Display' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.DisplayColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid Value
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyLocations.ValueColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Value' in table 'tblCompanyLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLocations.ValueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIsSelectedNull() => this.IsNull(this.tabletblCompanyLocations.IsSelectedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIsSelectedNull()
    {
      this[this.tabletblCompanyLocations.IsSelectedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDisplayNull() => this.IsNull(this.tabletblCompanyLocations.DisplayColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDisplayNull()
    {
      this[this.tabletblCompanyLocations.DisplayColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsValueNull() => this.IsNull(this.tabletblCompanyLocations.ValueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetValueNull()
    {
      this[this.tabletblCompanyLocations.ValueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblCompanyProgramCodesRow : DataRow
  {
    private dsCompanyLocProgCode.tblCompanyProgramCodesDataTable tabletblCompanyProgramCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyProgramCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyProgramCodes = (dsCompanyLocProgCode.tblCompanyProgramCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSelected
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyProgramCodes.IsSelectedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IsSelected' in table 'tblCompanyProgramCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyProgramCodes.IsSelectedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Display
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyProgramCodes.DisplayColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Display' in table 'tblCompanyProgramCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyProgramCodes.DisplayColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Value
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyProgramCodes.ValueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Value' in table 'tblCompanyProgramCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyProgramCodes.ValueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyLocationGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblCompanyProgramCodes.CompanyLocationGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLocationGuid' in table 'tblCompanyProgramCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyProgramCodes.CompanyLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIsSelectedNull()
    {
      return this.IsNull(this.tabletblCompanyProgramCodes.IsSelectedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIsSelectedNull()
    {
      this[this.tabletblCompanyProgramCodes.IsSelectedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDisplayNull() => this.IsNull(this.tabletblCompanyProgramCodes.DisplayColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDisplayNull()
    {
      this[this.tabletblCompanyProgramCodes.DisplayColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsValueNull() => this.IsNull(this.tabletblCompanyProgramCodes.ValueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetValueNull()
    {
      this[this.tabletblCompanyProgramCodes.ValueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyLocationGuidNull()
    {
      return this.IsNull(this.tabletblCompanyProgramCodes.CompanyLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyLocationGuidNull()
    {
      this[this.tabletblCompanyProgramCodes.CompanyLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompanyLocationsRowChangeEvent : EventArgs
  {
    private dsCompanyLocProgCode.tblCompanyLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyLocationsRowChangeEvent(
      dsCompanyLocProgCode.tblCompanyLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLocProgCode.tblCompanyLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompanyProgramCodesRowChangeEvent : EventArgs
  {
    private dsCompanyLocProgCode.tblCompanyProgramCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyProgramCodesRowChangeEvent(
      dsCompanyLocProgCode.tblCompanyProgramCodesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsCompanyLocProgCode.tblCompanyProgramCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
