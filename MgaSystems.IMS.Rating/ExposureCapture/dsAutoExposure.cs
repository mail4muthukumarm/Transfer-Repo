// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.ExposureCapture.dsAutoExposure
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
namespace MGASystems.IMS.Policies.Rating.ExposureCapture;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsAutoExposure")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsAutoExposure : DataSet
{
  private dsAutoExposure.lstStatesDataTable tablelstStates;
  private dsAutoExposure.tblGenericAutoExposuresDataTable tabletblGenericAutoExposures;
  private DataRelation relationlstStatestblGenericAutoExposures;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public dsAutoExposure()
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
  protected dsAutoExposure(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstStates)] != null)
          base.Tables.Add((DataTable) new dsAutoExposure.lstStatesDataTable(dataSet.Tables[nameof (lstStates)]));
        if (dataSet.Tables[nameof (tblGenericAutoExposures)] != null)
          base.Tables.Add((DataTable) new dsAutoExposure.tblGenericAutoExposuresDataTable(dataSet.Tables[nameof (tblGenericAutoExposures)]));
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
  public dsAutoExposure.lstStatesDataTable lstStates => this.tablelstStates;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAutoExposure.tblGenericAutoExposuresDataTable tblGenericAutoExposures
  {
    get => this.tabletblGenericAutoExposures;
  }

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
    dsAutoExposure dsAutoExposure = (dsAutoExposure) base.Clone();
    dsAutoExposure.InitVars();
    dsAutoExposure.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsAutoExposure;
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
      if (dataSet.Tables["lstStates"] != null)
        base.Tables.Add((DataTable) new dsAutoExposure.lstStatesDataTable(dataSet.Tables["lstStates"]));
      if (dataSet.Tables["tblGenericAutoExposures"] != null)
        base.Tables.Add((DataTable) new dsAutoExposure.tblGenericAutoExposuresDataTable(dataSet.Tables["tblGenericAutoExposures"]));
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
    this.tablelstStates = (dsAutoExposure.lstStatesDataTable) base.Tables["lstStates"];
    if (initTable && this.tablelstStates != null)
      this.tablelstStates.InitVars();
    this.tabletblGenericAutoExposures = (dsAutoExposure.tblGenericAutoExposuresDataTable) base.Tables["tblGenericAutoExposures"];
    if (initTable && this.tabletblGenericAutoExposures != null)
      this.tabletblGenericAutoExposures.InitVars();
    this.relationlstStatestblGenericAutoExposures = this.Relations["lstStatestblGenericAutoExposures"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsAutoExposure);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsAutoExposure.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstStates = new dsAutoExposure.lstStatesDataTable();
    base.Tables.Add((DataTable) this.tablelstStates);
    this.tabletblGenericAutoExposures = new dsAutoExposure.tblGenericAutoExposuresDataTable();
    base.Tables.Add((DataTable) this.tabletblGenericAutoExposures);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("lstStatestblGenericAutoExposures", new DataColumn[1]
    {
      this.tablelstStates.StateIDColumn
    }, new DataColumn[1]
    {
      this.tabletblGenericAutoExposures.StateIDColumn
    });
    this.tabletblGenericAutoExposures.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationlstStatestblGenericAutoExposures = new DataRelation("lstStatestblGenericAutoExposures", new DataColumn[1]
    {
      this.tablelstStates.StateIDColumn
    }, new DataColumn[1]
    {
      this.tabletblGenericAutoExposures.StateIDColumn
    }, false);
    this.Relations.Add(this.relationlstStatestblGenericAutoExposures);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializelstStates() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializetblGenericAutoExposures() => false;

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
    dsAutoExposure dsAutoExposure = new dsAutoExposure();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsAutoExposure.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsAutoExposure.GetSchemaSerializable();
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
  public delegate void lstStatesRowChangeEventHandler(
    object sender,
    dsAutoExposure.lstStatesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void tblGenericAutoExposuresRowChangeEventHandler(
    object sender,
    dsAutoExposure.tblGenericAutoExposuresRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstStatesDataTable : TypedTableBase<dsAutoExposure.lstStatesRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public lstStatesDataTable()
    {
      this.TableName = "lstStates";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal lstStatesDataTable(DataTable table)
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
    protected lstStatesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsAutoExposure.lstStatesRow this[int index]
    {
      get => (dsAutoExposure.lstStatesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsAutoExposure.lstStatesRowChangeEventHandler lstStatesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsAutoExposure.lstStatesRowChangeEventHandler lstStatesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsAutoExposure.lstStatesRowChangeEventHandler lstStatesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsAutoExposure.lstStatesRowChangeEventHandler lstStatesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddlstStatesRow(dsAutoExposure.lstStatesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsAutoExposure.lstStatesRow AddlstStatesRow(string StateID, string State)
    {
      dsAutoExposure.lstStatesRow row = (dsAutoExposure.lstStatesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) StateID,
        (object) State
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsAutoExposure.lstStatesRow FindByStateID(string StateID)
    {
      return (dsAutoExposure.lstStatesRow) this.Rows.Find(new object[1]
      {
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsAutoExposure.lstStatesDataTable lstStatesDataTable = (dsAutoExposure.lstStatesDataTable) base.Clone();
      lstStatesDataTable.InitVars();
      return (DataTable) lstStatesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAutoExposure.lstStatesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnState = this.Columns["State"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnStateID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnStateID.Unique = true;
      this.columnState.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsAutoExposure.lstStatesRow NewlstStatesRow()
    {
      return (dsAutoExposure.lstStatesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAutoExposure.lstStatesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsAutoExposure.lstStatesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAutoExposure.lstStatesRowChangeEventHandler statesRowChangedEvent = this.lstStatesRowChangedEvent;
      if (statesRowChangedEvent == null)
        return;
      statesRowChangedEvent((object) this, new dsAutoExposure.lstStatesRowChangeEvent((dsAutoExposure.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAutoExposure.lstStatesRowChangeEventHandler rowChangingEvent = this.lstStatesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAutoExposure.lstStatesRowChangeEvent((dsAutoExposure.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAutoExposure.lstStatesRowChangeEventHandler statesRowDeletedEvent = this.lstStatesRowDeletedEvent;
      if (statesRowDeletedEvent == null)
        return;
      statesRowDeletedEvent((object) this, new dsAutoExposure.lstStatesRowChangeEvent((dsAutoExposure.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstStatesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAutoExposure.lstStatesRowChangeEventHandler rowDeletingEvent = this.lstStatesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAutoExposure.lstStatesRowChangeEvent((dsAutoExposure.lstStatesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovelstStatesRow(dsAutoExposure.lstStatesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAutoExposure dsAutoExposure = new dsAutoExposure();
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
        FixedValue = dsAutoExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstStatesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAutoExposure.GetSchemaSerializable();
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
  public class tblGenericAutoExposuresDataTable : 
    TypedTableBase<dsAutoExposure.tblGenericAutoExposuresRow>
  {
    private DataColumn columnAutoID;
    private DataColumn columnQuoteID;
    private DataColumn columnStateID;
    private DataColumn columnYear;
    private DataColumn columnMake;
    private DataColumn columnModel;
    private DataColumn columnVIN;
    private DataColumn columnAutoClassID;
    private DataColumn columnGVW;
    private DataColumn columnGarageTerr;
    private DataColumn columnStatedValue;
    private DataColumn columnUsage;
    private DataColumn columnRadius;
    private DataColumn columnCostNew;
    private DataColumn columnVehicleNumber;
    private DataColumn columnVehicleSeatingCapacity;
    private DataColumn columnAgeGroup;
    private DataColumn columnPrimaryRatingFactor;
    private DataColumn columnSecondaryRatingFactor;
    private DataColumn columnDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblGenericAutoExposuresDataTable()
    {
      this.TableName = "tblGenericAutoExposures";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblGenericAutoExposuresDataTable(DataTable table)
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
    protected tblGenericAutoExposuresDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AutoIDColumn => this.columnAutoID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn YearColumn => this.columnYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn MakeColumn => this.columnMake;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ModelColumn => this.columnModel;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn VINColumn => this.columnVIN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AutoClassIDColumn => this.columnAutoClassID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn GVWColumn => this.columnGVW;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn GarageTerrColumn => this.columnGarageTerr;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn StatedValueColumn => this.columnStatedValue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn UsageColumn => this.columnUsage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn RadiusColumn => this.columnRadius;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CostNewColumn => this.columnCostNew;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn VehicleNumberColumn => this.columnVehicleNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn VehicleSeatingCapacityColumn => this.columnVehicleSeatingCapacity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AgeGroupColumn => this.columnAgeGroup;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PrimaryRatingFactorColumn => this.columnPrimaryRatingFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn SecondaryRatingFactorColumn => this.columnSecondaryRatingFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DeletedColumn => this.columnDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsAutoExposure.tblGenericAutoExposuresRow this[int index]
    {
      get => (dsAutoExposure.tblGenericAutoExposuresRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsAutoExposure.tblGenericAutoExposuresRowChangeEventHandler tblGenericAutoExposuresRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsAutoExposure.tblGenericAutoExposuresRowChangeEventHandler tblGenericAutoExposuresRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsAutoExposure.tblGenericAutoExposuresRowChangeEventHandler tblGenericAutoExposuresRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsAutoExposure.tblGenericAutoExposuresRowChangeEventHandler tblGenericAutoExposuresRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddtblGenericAutoExposuresRow(dsAutoExposure.tblGenericAutoExposuresRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsAutoExposure.tblGenericAutoExposuresRow AddtblGenericAutoExposuresRow(
      int QuoteID,
      dsAutoExposure.lstStatesRow parentlstStatesRowBylstStatestblGenericAutoExposures,
      short Year,
      string Make,
      string Model,
      string VIN,
      string AutoClassID,
      string GVW,
      string GarageTerr,
      string StatedValue,
      string Usage,
      string Radius,
      string CostNew,
      string VehicleNumber,
      short VehicleSeatingCapacity,
      string AgeGroup,
      string PrimaryRatingFactor,
      string SecondaryRatingFactor,
      bool Deleted)
    {
      dsAutoExposure.tblGenericAutoExposuresRow row = (dsAutoExposure.tblGenericAutoExposuresRow) this.NewRow();
      object[] objArray = new object[20]
      {
        null,
        (object) QuoteID,
        null,
        (object) Year,
        (object) Make,
        (object) Model,
        (object) VIN,
        (object) AutoClassID,
        (object) GVW,
        (object) GarageTerr,
        (object) StatedValue,
        (object) Usage,
        (object) Radius,
        (object) CostNew,
        (object) VehicleNumber,
        (object) VehicleSeatingCapacity,
        (object) AgeGroup,
        (object) PrimaryRatingFactor,
        (object) SecondaryRatingFactor,
        (object) Deleted
      };
      if (parentlstStatesRowBylstStatestblGenericAutoExposures != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parentlstStatesRowBylstStatestblGenericAutoExposures[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsAutoExposure.tblGenericAutoExposuresRow FindByAutoID(int AutoID)
    {
      return (dsAutoExposure.tblGenericAutoExposuresRow) this.Rows.Find(new object[1]
      {
        (object) AutoID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsAutoExposure.tblGenericAutoExposuresDataTable exposuresDataTable = (dsAutoExposure.tblGenericAutoExposuresDataTable) base.Clone();
      exposuresDataTable.InitVars();
      return (DataTable) exposuresDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAutoExposure.tblGenericAutoExposuresDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnAutoID = this.Columns["AutoID"];
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnStateID = this.Columns["StateID"];
      this.columnYear = this.Columns["Year"];
      this.columnMake = this.Columns["Make"];
      this.columnModel = this.Columns["Model"];
      this.columnVIN = this.Columns["VIN"];
      this.columnAutoClassID = this.Columns["AutoClassID"];
      this.columnGVW = this.Columns["GVW"];
      this.columnGarageTerr = this.Columns["GarageTerr"];
      this.columnStatedValue = this.Columns["StatedValue"];
      this.columnUsage = this.Columns["Usage"];
      this.columnRadius = this.Columns["Radius"];
      this.columnCostNew = this.Columns["CostNew"];
      this.columnVehicleNumber = this.Columns["VehicleNumber"];
      this.columnVehicleSeatingCapacity = this.Columns["VehicleSeatingCapacity"];
      this.columnAgeGroup = this.Columns["AgeGroup"];
      this.columnPrimaryRatingFactor = this.Columns["PrimaryRatingFactor"];
      this.columnSecondaryRatingFactor = this.Columns["SecondaryRatingFactor"];
      this.columnDeleted = this.Columns["Deleted"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnAutoID = new DataColumn("AutoID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoID);
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnYear = new DataColumn("Year", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYear);
      this.columnMake = new DataColumn("Make", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMake);
      this.columnModel = new DataColumn("Model", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModel);
      this.columnVIN = new DataColumn("VIN", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVIN);
      this.columnAutoClassID = new DataColumn("AutoClassID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutoClassID);
      this.columnGVW = new DataColumn("GVW", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGVW);
      this.columnGarageTerr = new DataColumn("GarageTerr", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGarageTerr);
      this.columnStatedValue = new DataColumn("StatedValue", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatedValue);
      this.columnUsage = new DataColumn("Usage", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUsage);
      this.columnRadius = new DataColumn("Radius", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRadius);
      this.columnCostNew = new DataColumn("CostNew", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostNew);
      this.columnVehicleNumber = new DataColumn("VehicleNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVehicleNumber);
      this.columnVehicleSeatingCapacity = new DataColumn("VehicleSeatingCapacity", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVehicleSeatingCapacity);
      this.columnAgeGroup = new DataColumn("AgeGroup", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAgeGroup);
      this.columnPrimaryRatingFactor = new DataColumn("PrimaryRatingFactor", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPrimaryRatingFactor);
      this.columnSecondaryRatingFactor = new DataColumn("SecondaryRatingFactor", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSecondaryRatingFactor);
      this.columnDeleted = new DataColumn("Deleted", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeleted);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnAutoID
      }, true));
      this.columnAutoID.AutoIncrement = true;
      this.columnAutoID.AllowDBNull = false;
      this.columnAutoID.ReadOnly = true;
      this.columnAutoID.Unique = true;
      this.columnQuoteID.AllowDBNull = false;
      this.columnDeleted.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsAutoExposure.tblGenericAutoExposuresRow NewtblGenericAutoExposuresRow()
    {
      return (dsAutoExposure.tblGenericAutoExposuresRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAutoExposure.tblGenericAutoExposuresRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsAutoExposure.tblGenericAutoExposuresRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericAutoExposuresRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAutoExposure.tblGenericAutoExposuresRowChangeEventHandler exposuresRowChangedEvent = this.tblGenericAutoExposuresRowChangedEvent;
      if (exposuresRowChangedEvent == null)
        return;
      exposuresRowChangedEvent((object) this, new dsAutoExposure.tblGenericAutoExposuresRowChangeEvent((dsAutoExposure.tblGenericAutoExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericAutoExposuresRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAutoExposure.tblGenericAutoExposuresRowChangeEventHandler rowChangingEvent = this.tblGenericAutoExposuresRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAutoExposure.tblGenericAutoExposuresRowChangeEvent((dsAutoExposure.tblGenericAutoExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericAutoExposuresRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAutoExposure.tblGenericAutoExposuresRowChangeEventHandler exposuresRowDeletedEvent = this.tblGenericAutoExposuresRowDeletedEvent;
      if (exposuresRowDeletedEvent == null)
        return;
      exposuresRowDeletedEvent((object) this, new dsAutoExposure.tblGenericAutoExposuresRowChangeEvent((dsAutoExposure.tblGenericAutoExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericAutoExposuresRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAutoExposure.tblGenericAutoExposuresRowChangeEventHandler rowDeletingEvent = this.tblGenericAutoExposuresRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAutoExposure.tblGenericAutoExposuresRowChangeEvent((dsAutoExposure.tblGenericAutoExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovetblGenericAutoExposuresRow(dsAutoExposure.tblGenericAutoExposuresRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAutoExposure dsAutoExposure = new dsAutoExposure();
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
        FixedValue = dsAutoExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblGenericAutoExposuresDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsAutoExposure.GetSchemaSerializable();
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

  public class lstStatesRow : DataRow
  {
    private dsAutoExposure.lstStatesDataTable tablelstStates;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal lstStatesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstStates = (dsAutoExposure.lstStatesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tablelstStates.StateIDColumn]);
      set => this[this.tablelstStates.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tablelstStates.StateColumn]);
      set => this[this.tablelstStates.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsAutoExposure.tblGenericAutoExposuresRow[] GettblGenericAutoExposuresRows()
    {
      return this.Table.ChildRelations["lstStatestblGenericAutoExposures"] != null ? (dsAutoExposure.tblGenericAutoExposuresRow[]) this.GetChildRows(this.Table.ChildRelations["lstStatestblGenericAutoExposures"]) : new dsAutoExposure.tblGenericAutoExposuresRow[0];
    }
  }

  public class tblGenericAutoExposuresRow : DataRow
  {
    private dsAutoExposure.tblGenericAutoExposuresDataTable tabletblGenericAutoExposures;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal tblGenericAutoExposuresRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblGenericAutoExposures = (dsAutoExposure.tblGenericAutoExposuresDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int AutoID
    {
      get => Conversions.ToInteger(this[this.tabletblGenericAutoExposures.AutoIDColumn]);
      set => this[this.tabletblGenericAutoExposures.AutoIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tabletblGenericAutoExposures.QuoteIDColumn]);
      set => this[this.tabletblGenericAutoExposures.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericAutoExposures.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public short Year
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblGenericAutoExposures.YearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Year' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.YearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Make
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericAutoExposures.MakeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Make' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.MakeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Model
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericAutoExposures.ModelColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Model' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.ModelColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string VIN
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericAutoExposures.VINColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'VIN' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.VINColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string AutoClassID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericAutoExposures.AutoClassIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AutoClassID' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.AutoClassIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string GVW
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericAutoExposures.GVWColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GVW' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.GVWColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string GarageTerr
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericAutoExposures.GarageTerrColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GarageTerr' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.GarageTerrColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string StatedValue
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericAutoExposures.StatedValueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatedValue' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.StatedValueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Usage
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericAutoExposures.UsageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Usage' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.UsageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Radius
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericAutoExposures.RadiusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Radius' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.RadiusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string CostNew
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericAutoExposures.CostNewColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CostNew' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.CostNewColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string VehicleNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericAutoExposures.VehicleNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'VehicleNumber' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.VehicleNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public short VehicleSeatingCapacity
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblGenericAutoExposures.VehicleSeatingCapacityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'VehicleSeatingCapacity' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.VehicleSeatingCapacityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string AgeGroup
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericAutoExposures.AgeGroupColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AgeGroup' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.AgeGroupColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PrimaryRatingFactor
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericAutoExposures.PrimaryRatingFactorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PrimaryRatingFactor' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.PrimaryRatingFactorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string SecondaryRatingFactor
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericAutoExposures.SecondaryRatingFactorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SecondaryRatingFactor' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.SecondaryRatingFactorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Deleted
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblGenericAutoExposures.DeletedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Deleted' in table 'tblGenericAutoExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericAutoExposures.DeletedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsAutoExposure.lstStatesRow lstStatesRow
    {
      get
      {
        return (dsAutoExposure.lstStatesRow) this.GetParentRow(this.Table.ParentRelations["lstStatestblGenericAutoExposures"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstStatestblGenericAutoExposures"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabletblGenericAutoExposures.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblGenericAutoExposures.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsYearNull() => this.IsNull(this.tabletblGenericAutoExposures.YearColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetYearNull()
    {
      this[this.tabletblGenericAutoExposures.YearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsMakeNull() => this.IsNull(this.tabletblGenericAutoExposures.MakeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetMakeNull()
    {
      this[this.tabletblGenericAutoExposures.MakeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsModelNull() => this.IsNull(this.tabletblGenericAutoExposures.ModelColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetModelNull()
    {
      this[this.tabletblGenericAutoExposures.ModelColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsVINNull() => this.IsNull(this.tabletblGenericAutoExposures.VINColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetVINNull()
    {
      this[this.tabletblGenericAutoExposures.VINColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAutoClassIDNull()
    {
      return this.IsNull(this.tabletblGenericAutoExposures.AutoClassIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAutoClassIDNull()
    {
      this[this.tabletblGenericAutoExposures.AutoClassIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsGVWNull() => this.IsNull(this.tabletblGenericAutoExposures.GVWColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetGVWNull()
    {
      this[this.tabletblGenericAutoExposures.GVWColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsGarageTerrNull()
    {
      return this.IsNull(this.tabletblGenericAutoExposures.GarageTerrColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetGarageTerrNull()
    {
      this[this.tabletblGenericAutoExposures.GarageTerrColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsStatedValueNull()
    {
      return this.IsNull(this.tabletblGenericAutoExposures.StatedValueColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetStatedValueNull()
    {
      this[this.tabletblGenericAutoExposures.StatedValueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsUsageNull() => this.IsNull(this.tabletblGenericAutoExposures.UsageColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetUsageNull()
    {
      this[this.tabletblGenericAutoExposures.UsageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsRadiusNull() => this.IsNull(this.tabletblGenericAutoExposures.RadiusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetRadiusNull()
    {
      this[this.tabletblGenericAutoExposures.RadiusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCostNewNull() => this.IsNull(this.tabletblGenericAutoExposures.CostNewColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCostNewNull()
    {
      this[this.tabletblGenericAutoExposures.CostNewColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsVehicleNumberNull()
    {
      return this.IsNull(this.tabletblGenericAutoExposures.VehicleNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetVehicleNumberNull()
    {
      this[this.tabletblGenericAutoExposures.VehicleNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsVehicleSeatingCapacityNull()
    {
      return this.IsNull(this.tabletblGenericAutoExposures.VehicleSeatingCapacityColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetVehicleSeatingCapacityNull()
    {
      this[this.tabletblGenericAutoExposures.VehicleSeatingCapacityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAgeGroupNull() => this.IsNull(this.tabletblGenericAutoExposures.AgeGroupColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAgeGroupNull()
    {
      this[this.tabletblGenericAutoExposures.AgeGroupColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPrimaryRatingFactorNull()
    {
      return this.IsNull(this.tabletblGenericAutoExposures.PrimaryRatingFactorColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPrimaryRatingFactorNull()
    {
      this[this.tabletblGenericAutoExposures.PrimaryRatingFactorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsSecondaryRatingFactorNull()
    {
      return this.IsNull(this.tabletblGenericAutoExposures.SecondaryRatingFactorColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetSecondaryRatingFactorNull()
    {
      this[this.tabletblGenericAutoExposures.SecondaryRatingFactorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDeletedNull() => this.IsNull(this.tabletblGenericAutoExposures.DeletedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDeletedNull()
    {
      this[this.tabletblGenericAutoExposures.DeletedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class lstStatesRowChangeEvent : EventArgs
  {
    private dsAutoExposure.lstStatesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public lstStatesRowChangeEvent(dsAutoExposure.lstStatesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsAutoExposure.lstStatesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class tblGenericAutoExposuresRowChangeEvent : EventArgs
  {
    private dsAutoExposure.tblGenericAutoExposuresRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public tblGenericAutoExposuresRowChangeEvent(
      dsAutoExposure.tblGenericAutoExposuresRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsAutoExposure.tblGenericAutoExposuresRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
