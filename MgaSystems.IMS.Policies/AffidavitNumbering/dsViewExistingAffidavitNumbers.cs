// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.AffidavitNumbering.dsViewExistingAffidavitNumbers
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
namespace MGASystems.IMS.Policies.AffidavitNumbering;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsViewExistingAffidavitNumbers")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsViewExistingAffidavitNumbers : DataSet
{
  private dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersDataTable tabletblQuoteAffidavitNumbers;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsViewExistingAffidavitNumbers()
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
  protected dsViewExistingAffidavitNumbers(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblQuoteAffidavitNumbers)] != null)
          base.Tables.Add((DataTable) new dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersDataTable(dataSet.Tables[nameof (tblQuoteAffidavitNumbers)]));
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
  public dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersDataTable tblQuoteAffidavitNumbers
  {
    get => this.tabletblQuoteAffidavitNumbers;
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
    dsViewExistingAffidavitNumbers affidavitNumbers = (dsViewExistingAffidavitNumbers) base.Clone();
    affidavitNumbers.InitVars();
    affidavitNumbers.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) affidavitNumbers;
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
      if (dataSet.Tables["tblQuoteAffidavitNumbers"] != null)
        base.Tables.Add((DataTable) new dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersDataTable(dataSet.Tables["tblQuoteAffidavitNumbers"]));
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
    this.tabletblQuoteAffidavitNumbers = (dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersDataTable) base.Tables["tblQuoteAffidavitNumbers"];
    if (!initTable || this.tabletblQuoteAffidavitNumbers == null)
      return;
    this.tabletblQuoteAffidavitNumbers.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsViewExistingAffidavitNumbers);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsViewExistingAffidavitNumbers.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblQuoteAffidavitNumbers = new dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteAffidavitNumbers);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblQuoteAffidavitNumbers() => false;

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
    dsViewExistingAffidavitNumbers affidavitNumbers = new dsViewExistingAffidavitNumbers();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = affidavitNumbers.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = affidavitNumbers.GetSchemaSerializable();
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
  public delegate void tblQuoteAffidavitNumbersRowChangeEventHandler(
    object sender,
    dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblQuoteAffidavitNumbersDataTable : 
    TypedTableBase<dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow>
  {
    private DataColumn columnStateID;
    private DataColumn columnAffidavitNumber;
    private DataColumn columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteAffidavitNumbersDataTable()
    {
      this.TableName = "tblQuoteAffidavitNumbers";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteAffidavitNumbersDataTable(DataTable table)
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
    protected tblQuoteAffidavitNumbersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AffidavitNumberColumn => this.columnAffidavitNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow this[int index]
    {
      get => (dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler tblQuoteAffidavitNumbersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler tblQuoteAffidavitNumbersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler tblQuoteAffidavitNumbersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler tblQuoteAffidavitNumbersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteAffidavitNumbersRow(
      dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow AddtblQuoteAffidavitNumbersRow(
      string StateID,
      string AffidavitNumber,
      int QuoteID)
    {
      dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow row = (dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) StateID,
        (object) AffidavitNumber,
        (object) QuoteID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow FindByStateIDQuoteID(
      string StateID,
      int QuoteID)
    {
      return (dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow) this.Rows.Find(new object[2]
      {
        (object) StateID,
        (object) QuoteID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersDataTable numbersDataTable = (dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersDataTable) base.Clone();
      numbersDataTable.InitVars();
      return (DataTable) numbersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnStateID = this.Columns["StateID"];
      this.columnAffidavitNumber = this.Columns["AffidavitNumber"];
      this.columnQuoteID = this.Columns["QuoteID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnAffidavitNumber = new DataColumn("AffidavitNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAffidavitNumber);
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsViewExistingAffidavitNumbersKey1", new DataColumn[2]
      {
        this.columnStateID,
        this.columnQuoteID
      }, true));
      this.columnStateID.AllowDBNull = false;
      this.columnAffidavitNumber.AllowDBNull = false;
      this.columnQuoteID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow NewtblQuoteAffidavitNumbersRow()
    {
      return (dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAffidavitNumbersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler numbersRowChangedEvent = this.tblQuoteAffidavitNumbersRowChangedEvent;
      if (numbersRowChangedEvent == null)
        return;
      numbersRowChangedEvent((object) this, new dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEvent((dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAffidavitNumbersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler rowChangingEvent = this.tblQuoteAffidavitNumbersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEvent((dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAffidavitNumbersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler numbersRowDeletedEvent = this.tblQuoteAffidavitNumbersRowDeletedEvent;
      if (numbersRowDeletedEvent == null)
        return;
      numbersRowDeletedEvent((object) this, new dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEvent((dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAffidavitNumbersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler rowDeletingEvent = this.tblQuoteAffidavitNumbersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEvent((dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteAffidavitNumbersRow(
      dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsViewExistingAffidavitNumbers affidavitNumbers = new dsViewExistingAffidavitNumbers();
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
        FixedValue = affidavitNumbers.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteAffidavitNumbersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = affidavitNumbers.GetSchemaSerializable();
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

  public class tblQuoteAffidavitNumbersRow : DataRow
  {
    private dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersDataTable tabletblQuoteAffidavitNumbers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteAffidavitNumbersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteAffidavitNumbers = (dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tabletblQuoteAffidavitNumbers.StateIDColumn]);
      set => this[this.tabletblQuoteAffidavitNumbers.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AffidavitNumber
    {
      get => Conversions.ToString(this[this.tabletblQuoteAffidavitNumbers.AffidavitNumberColumn]);
      set => this[this.tabletblQuoteAffidavitNumbers.AffidavitNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteAffidavitNumbers.QuoteIDColumn]);
      set => this[this.tabletblQuoteAffidavitNumbers.QuoteIDColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteAffidavitNumbersRowChangeEvent : EventArgs
  {
    private dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteAffidavitNumbersRowChangeEvent(
      dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
