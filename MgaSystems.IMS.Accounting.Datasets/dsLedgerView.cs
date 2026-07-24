// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsLedgerView
// Assembly: MgaSystems.IMS.Accounting.Datasets, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8706ECE1-02EE-4588-9B9D-A81462107C6A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Datasets.dll

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
namespace MGASystems.IMS.Accounting.AccountingDatasets;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsLedgerView")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsLedgerView : DataSet
{
  private dsLedgerView.TABLE1DataTable tableTABLE1;
  private dsLedgerView.TABLE2DataTable tableTABLE2;
  private DataRelation relationGLACCTID_LINK;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsLedgerView()
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
  protected dsLedgerView(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (TABLE1)] != null)
          base.Tables.Add((DataTable) new dsLedgerView.TABLE1DataTable(dataSet.Tables[nameof (TABLE1)]));
        if (dataSet.Tables[nameof (TABLE2)] != null)
          base.Tables.Add((DataTable) new dsLedgerView.TABLE2DataTable(dataSet.Tables[nameof (TABLE2)]));
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
  public dsLedgerView.TABLE1DataTable TABLE1 => this.tableTABLE1;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsLedgerView.TABLE2DataTable TABLE2 => this.tableTABLE2;

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
    dsLedgerView dsLedgerView = (dsLedgerView) base.Clone();
    dsLedgerView.InitVars();
    dsLedgerView.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsLedgerView;
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
      if (dataSet.Tables["TABLE1"] != null)
        base.Tables.Add((DataTable) new dsLedgerView.TABLE1DataTable(dataSet.Tables["TABLE1"]));
      if (dataSet.Tables["TABLE2"] != null)
        base.Tables.Add((DataTable) new dsLedgerView.TABLE2DataTable(dataSet.Tables["TABLE2"]));
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
    this.tableTABLE1 = (dsLedgerView.TABLE1DataTable) base.Tables["TABLE1"];
    if (initTable && this.tableTABLE1 != null)
      this.tableTABLE1.InitVars();
    this.tableTABLE2 = (dsLedgerView.TABLE2DataTable) base.Tables["TABLE2"];
    if (initTable && this.tableTABLE2 != null)
      this.tableTABLE2.InitVars();
    this.relationGLACCTID_LINK = this.Relations["GLACCTID LINK"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsLedgerView);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsLedgerView.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableTABLE1 = new dsLedgerView.TABLE1DataTable();
    base.Tables.Add((DataTable) this.tableTABLE1);
    this.tableTABLE2 = new dsLedgerView.TABLE2DataTable();
    base.Tables.Add((DataTable) this.tableTABLE2);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("GLACCTID LINK", new DataColumn[1]
    {
      this.tableTABLE1.GLACCTIDColumn
    }, new DataColumn[1]{ this.tableTABLE2.GLACCTIDColumn });
    this.tableTABLE2.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationGLACCTID_LINK = new DataRelation("GLACCTID LINK", new DataColumn[1]
    {
      this.tableTABLE1.GLACCTIDColumn
    }, new DataColumn[1]{ this.tableTABLE2.GLACCTIDColumn }, false);
    this.Relations.Add(this.relationGLACCTID_LINK);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeTABLE1() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeTABLE2() => false;

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
    dsLedgerView dsLedgerView = new dsLedgerView();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsLedgerView.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsLedgerView.GetSchemaSerializable();
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
  public delegate void TABLE1RowChangeEventHandler(
    object sender,
    dsLedgerView.TABLE1RowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void TABLE2RowChangeEventHandler(
    object sender,
    dsLedgerView.TABLE2RowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class TABLE1DataTable : TypedTableBase<dsLedgerView.TABLE1Row>
  {
    private DataColumn columnGLACCTID;
    private DataColumn columnFULLNAME;
    private DataColumn columnACCOUNTNUMBER;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public TABLE1DataTable()
    {
      this.TableName = "TABLE1";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal TABLE1DataTable(DataTable table)
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
    protected TABLE1DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLACCTIDColumn => this.columnGLACCTID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FULLNAMEColumn => this.columnFULLNAME;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ACCOUNTNUMBERColumn => this.columnACCOUNTNUMBER;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLedgerView.TABLE1Row this[int index] => (dsLedgerView.TABLE1Row) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsLedgerView.TABLE1RowChangeEventHandler TABLE1RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsLedgerView.TABLE1RowChangeEventHandler TABLE1RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsLedgerView.TABLE1RowChangeEventHandler TABLE1RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsLedgerView.TABLE1RowChangeEventHandler TABLE1RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddTABLE1Row(dsLedgerView.TABLE1Row row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLedgerView.TABLE1Row AddTABLE1Row(int GLACCTID, string FULLNAME, string ACCOUNTNUMBER)
    {
      dsLedgerView.TABLE1Row row = (dsLedgerView.TABLE1Row) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) GLACCTID,
        (object) FULLNAME,
        (object) ACCOUNTNUMBER
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLedgerView.TABLE1Row FindByGLACCTID(int GLACCTID)
    {
      return (dsLedgerView.TABLE1Row) this.Rows.Find(new object[1]
      {
        (object) GLACCTID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsLedgerView.TABLE1DataTable tablE1DataTable = (dsLedgerView.TABLE1DataTable) base.Clone();
      tablE1DataTable.InitVars();
      return (DataTable) tablE1DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsLedgerView.TABLE1DataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnGLACCTID = this.Columns["GLACCTID"];
      this.columnFULLNAME = this.Columns["FULLNAME"];
      this.columnACCOUNTNUMBER = this.Columns["ACCOUNTNUMBER"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnGLACCTID = new DataColumn("GLACCTID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLACCTID);
      this.columnFULLNAME = new DataColumn("FULLNAME", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFULLNAME);
      this.columnACCOUNTNUMBER = new DataColumn("ACCOUNTNUMBER", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnACCOUNTNUMBER);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsLedgerViewKey2", new DataColumn[1]
      {
        this.columnGLACCTID
      }, true));
      this.columnGLACCTID.AllowDBNull = false;
      this.columnGLACCTID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLedgerView.TABLE1Row NewTABLE1Row() => (dsLedgerView.TABLE1Row) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsLedgerView.TABLE1Row(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsLedgerView.TABLE1Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TABLE1RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsLedgerView.TABLE1RowChangeEventHandler e1RowChangedEvent = this.TABLE1RowChangedEvent;
      if (e1RowChangedEvent == null)
        return;
      e1RowChangedEvent((object) this, new dsLedgerView.TABLE1RowChangeEvent((dsLedgerView.TABLE1Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TABLE1RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsLedgerView.TABLE1RowChangeEventHandler rowChangingEvent = this.TABLE1RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsLedgerView.TABLE1RowChangeEvent((dsLedgerView.TABLE1Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TABLE1RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsLedgerView.TABLE1RowChangeEventHandler e1RowDeletedEvent = this.TABLE1RowDeletedEvent;
      if (e1RowDeletedEvent == null)
        return;
      e1RowDeletedEvent((object) this, new dsLedgerView.TABLE1RowChangeEvent((dsLedgerView.TABLE1Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TABLE1RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsLedgerView.TABLE1RowChangeEventHandler rowDeletingEvent = this.TABLE1RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsLedgerView.TABLE1RowChangeEvent((dsLedgerView.TABLE1Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveTABLE1Row(dsLedgerView.TABLE1Row row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsLedgerView dsLedgerView = new dsLedgerView();
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
        FixedValue = dsLedgerView.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (TABLE1DataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsLedgerView.GetSchemaSerializable();
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
  public class TABLE2DataTable : TypedTableBase<dsLedgerView.TABLE2Row>
  {
    private DataColumn columnGLACCTID;
    private DataColumn column_TRANSACTION__;
    private DataColumn columnTRANSACTION_DATE;
    private DataColumn columnDATE_STUB;
    private DataColumn columnDAY_STUB;
    private DataColumn columnDEBIT;
    private DataColumn columnCREDIT;
    private DataColumn columnVOID_;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public TABLE2DataTable()
    {
      this.TableName = "TABLE2";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal TABLE2DataTable(DataTable table)
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
    protected TABLE2DataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLACCTIDColumn => this.columnGLACCTID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn _TRANSACTION__Column => this.column_TRANSACTION__;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TRANSACTION_DATEColumn => this.columnTRANSACTION_DATE;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DATE_STUBColumn => this.columnDATE_STUB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DAY_STUBColumn => this.columnDAY_STUB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DEBITColumn => this.columnDEBIT;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CREDITColumn => this.columnCREDIT;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn VOID_Column => this.columnVOID_;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLedgerView.TABLE2Row this[int index] => (dsLedgerView.TABLE2Row) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsLedgerView.TABLE2RowChangeEventHandler TABLE2RowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsLedgerView.TABLE2RowChangeEventHandler TABLE2RowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsLedgerView.TABLE2RowChangeEventHandler TABLE2RowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsLedgerView.TABLE2RowChangeEventHandler TABLE2RowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddTABLE2Row(dsLedgerView.TABLE2Row row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLedgerView.TABLE2Row AddTABLE2Row(
      dsLedgerView.TABLE1Row parentTABLE1RowByGLACCTID_LINK,
      int _TRANSACTION__,
      DateTime TRANSACTION_DATE,
      string DATE_STUB,
      string DAY_STUB,
      Decimal DEBIT,
      Decimal CREDIT,
      bool VOID_)
    {
      dsLedgerView.TABLE2Row row = (dsLedgerView.TABLE2Row) this.NewRow();
      object[] objArray = new object[8]
      {
        null,
        (object) _TRANSACTION__,
        (object) TRANSACTION_DATE,
        (object) DATE_STUB,
        (object) DAY_STUB,
        (object) DEBIT,
        (object) CREDIT,
        (object) VOID_
      };
      if (parentTABLE1RowByGLACCTID_LINK != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parentTABLE1RowByGLACCTID_LINK[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLedgerView.TABLE2Row FindByGLACCTID(int GLACCTID)
    {
      return (dsLedgerView.TABLE2Row) this.Rows.Find(new object[1]
      {
        (object) GLACCTID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsLedgerView.TABLE2DataTable tablE2DataTable = (dsLedgerView.TABLE2DataTable) base.Clone();
      tablE2DataTable.InitVars();
      return (DataTable) tablE2DataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsLedgerView.TABLE2DataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnGLACCTID = this.Columns["GLACCTID"];
      this.column_TRANSACTION__ = this.Columns["TRANSACTION #"];
      this.columnTRANSACTION_DATE = this.Columns["TRANSACTION DATE"];
      this.columnDATE_STUB = this.Columns["DATE STUB"];
      this.columnDAY_STUB = this.Columns["DAY STUB"];
      this.columnDEBIT = this.Columns["DEBIT"];
      this.columnCREDIT = this.Columns["CREDIT"];
      this.columnVOID_ = this.Columns["VOID "];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnGLACCTID = new DataColumn("GLACCTID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLACCTID);
      this.column_TRANSACTION__ = new DataColumn("TRANSACTION #", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.column_TRANSACTION__);
      this.columnTRANSACTION_DATE = new DataColumn("TRANSACTION DATE", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTRANSACTION_DATE);
      this.columnDATE_STUB = new DataColumn("DATE STUB", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDATE_STUB);
      this.columnDAY_STUB = new DataColumn("DAY STUB", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDAY_STUB);
      this.columnDEBIT = new DataColumn("DEBIT", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDEBIT);
      this.columnCREDIT = new DataColumn("CREDIT", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCREDIT);
      this.columnVOID_ = new DataColumn("VOID ", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVOID_);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsLedgerViewKey1", new DataColumn[1]
      {
        this.columnGLACCTID
      }, true));
      this.columnGLACCTID.AllowDBNull = false;
      this.columnGLACCTID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLedgerView.TABLE2Row NewTABLE2Row() => (dsLedgerView.TABLE2Row) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsLedgerView.TABLE2Row(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsLedgerView.TABLE2Row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TABLE2RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsLedgerView.TABLE2RowChangeEventHandler e2RowChangedEvent = this.TABLE2RowChangedEvent;
      if (e2RowChangedEvent == null)
        return;
      e2RowChangedEvent((object) this, new dsLedgerView.TABLE2RowChangeEvent((dsLedgerView.TABLE2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TABLE2RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsLedgerView.TABLE2RowChangeEventHandler rowChangingEvent = this.TABLE2RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsLedgerView.TABLE2RowChangeEvent((dsLedgerView.TABLE2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TABLE2RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsLedgerView.TABLE2RowChangeEventHandler e2RowDeletedEvent = this.TABLE2RowDeletedEvent;
      if (e2RowDeletedEvent == null)
        return;
      e2RowDeletedEvent((object) this, new dsLedgerView.TABLE2RowChangeEvent((dsLedgerView.TABLE2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TABLE2RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsLedgerView.TABLE2RowChangeEventHandler rowDeletingEvent = this.TABLE2RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsLedgerView.TABLE2RowChangeEvent((dsLedgerView.TABLE2Row) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveTABLE2Row(dsLedgerView.TABLE2Row row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsLedgerView dsLedgerView = new dsLedgerView();
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
        FixedValue = dsLedgerView.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (TABLE2DataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsLedgerView.GetSchemaSerializable();
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

  public class TABLE1Row : DataRow
  {
    private dsLedgerView.TABLE1DataTable tableTABLE1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal TABLE1Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTABLE1 = (dsLedgerView.TABLE1DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GLACCTID
    {
      get => Conversions.ToInteger(this[this.tableTABLE1.GLACCTIDColumn]);
      set => this[this.tableTABLE1.GLACCTIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FULLNAME
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTABLE1.FULLNAMEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FULLNAME' in table 'TABLE1' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTABLE1.FULLNAMEColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ACCOUNTNUMBER
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTABLE1.ACCOUNTNUMBERColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ACCOUNTNUMBER' in table 'TABLE1' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTABLE1.ACCOUNTNUMBERColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFULLNAMENull() => this.IsNull(this.tableTABLE1.FULLNAMEColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFULLNAMENull()
    {
      this[this.tableTABLE1.FULLNAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsACCOUNTNUMBERNull() => this.IsNull(this.tableTABLE1.ACCOUNTNUMBERColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetACCOUNTNUMBERNull()
    {
      this[this.tableTABLE1.ACCOUNTNUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLedgerView.TABLE2Row[] GetTABLE2Rows()
    {
      return this.Table.ChildRelations["GLACCTID LINK"] != null ? (dsLedgerView.TABLE2Row[]) this.GetChildRows(this.Table.ChildRelations["GLACCTID LINK"]) : new dsLedgerView.TABLE2Row[0];
    }
  }

  public class TABLE2Row : DataRow
  {
    private dsLedgerView.TABLE2DataTable tableTABLE2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal TABLE2Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTABLE2 = (dsLedgerView.TABLE2DataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GLACCTID
    {
      get => Conversions.ToInteger(this[this.tableTABLE2.GLACCTIDColumn]);
      set => this[this.tableTABLE2.GLACCTIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int _TRANSACTION__
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableTABLE2._TRANSACTION__Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TRANSACTION #' in table 'TABLE2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTABLE2._TRANSACTION__Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime TRANSACTION_DATE
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableTABLE2.TRANSACTION_DATEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TRANSACTION DATE' in table 'TABLE2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTABLE2.TRANSACTION_DATEColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DATE_STUB
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTABLE2.DATE_STUBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DATE STUB' in table 'TABLE2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTABLE2.DATE_STUBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DAY_STUB
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTABLE2.DAY_STUBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DAY STUB' in table 'TABLE2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTABLE2.DAY_STUBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal DEBIT
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableTABLE2.DEBITColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DEBIT' in table 'TABLE2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTABLE2.DEBITColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal CREDIT
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableTABLE2.CREDITColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CREDIT' in table 'TABLE2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTABLE2.CREDITColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool VOID_
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableTABLE2.VOID_Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'VOID ' in table 'TABLE2' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTABLE2.VOID_Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLedgerView.TABLE1Row TABLE1Row
    {
      get
      {
        return (dsLedgerView.TABLE1Row) this.GetParentRow(this.Table.ParentRelations["GLACCTID LINK"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["GLACCTID LINK"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Is_TRANSACTION__Null() => this.IsNull(this.tableTABLE2._TRANSACTION__Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Set_TRANSACTION__Null()
    {
      this[this.tableTABLE2._TRANSACTION__Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTRANSACTION_DATENull() => this.IsNull(this.tableTABLE2.TRANSACTION_DATEColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTRANSACTION_DATENull()
    {
      this[this.tableTABLE2.TRANSACTION_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDATE_STUBNull() => this.IsNull(this.tableTABLE2.DATE_STUBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDATE_STUBNull()
    {
      this[this.tableTABLE2.DATE_STUBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDAY_STUBNull() => this.IsNull(this.tableTABLE2.DAY_STUBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDAY_STUBNull()
    {
      this[this.tableTABLE2.DAY_STUBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDEBITNull() => this.IsNull(this.tableTABLE2.DEBITColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDEBITNull()
    {
      this[this.tableTABLE2.DEBITColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCREDITNull() => this.IsNull(this.tableTABLE2.CREDITColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCREDITNull()
    {
      this[this.tableTABLE2.CREDITColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsVOID_Null() => this.IsNull(this.tableTABLE2.VOID_Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetVOID_Null()
    {
      this[this.tableTABLE2.VOID_Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class TABLE1RowChangeEvent : EventArgs
  {
    private dsLedgerView.TABLE1Row eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public TABLE1RowChangeEvent(dsLedgerView.TABLE1Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLedgerView.TABLE1Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class TABLE2RowChangeEvent : EventArgs
  {
    private dsLedgerView.TABLE2Row eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public TABLE2RowChangeEvent(dsLedgerView.TABLE2Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLedgerView.TABLE2Row Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
