// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsEditAffidavitNumbers
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
namespace MGASystems.IMS.Policies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsEditAffidavitNumbers")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsEditAffidavitNumbers : DataSet
{
  private dsEditAffidavitNumbers.tblQuoteAffidavitNumbersDataTable tabletblQuoteAffidavitNumbers;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsEditAffidavitNumbers()
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
  protected dsEditAffidavitNumbers(SerializationInfo info, StreamingContext context)
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
          base.Tables.Add((DataTable) new dsEditAffidavitNumbers.tblQuoteAffidavitNumbersDataTable(dataSet.Tables[nameof (tblQuoteAffidavitNumbers)]));
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
  public dsEditAffidavitNumbers.tblQuoteAffidavitNumbersDataTable tblQuoteAffidavitNumbers
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
    dsEditAffidavitNumbers affidavitNumbers = (dsEditAffidavitNumbers) base.Clone();
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
        base.Tables.Add((DataTable) new dsEditAffidavitNumbers.tblQuoteAffidavitNumbersDataTable(dataSet.Tables["tblQuoteAffidavitNumbers"]));
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
    this.tabletblQuoteAffidavitNumbers = (dsEditAffidavitNumbers.tblQuoteAffidavitNumbersDataTable) base.Tables["tblQuoteAffidavitNumbers"];
    if (!initTable || this.tabletblQuoteAffidavitNumbers == null)
      return;
    this.tabletblQuoteAffidavitNumbers.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsEditAffidavitNumbers);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsEditAffidavitNumbers.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblQuoteAffidavitNumbers = new dsEditAffidavitNumbers.tblQuoteAffidavitNumbersDataTable();
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
    dsEditAffidavitNumbers affidavitNumbers = new dsEditAffidavitNumbers();
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
    dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblQuoteAffidavitNumbersDataTable : 
    TypedTableBase<dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow>
  {
    private DataColumn columnQuoteID;
    private DataColumn columnStateID;
    private DataColumn columnAffidavitNumber;
    private DataColumn columnAffidavitNumberIndex;
    private DataColumn columnExportable;
    private DataColumn columnTaxExempt;

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
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AffidavitNumberColumn => this.columnAffidavitNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AffidavitNumberIndexColumn => this.columnAffidavitNumberIndex;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExportableColumn => this.columnExportable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TaxExemptColumn => this.columnTaxExempt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow this[int index]
    {
      get => (dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler tblQuoteAffidavitNumbersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler tblQuoteAffidavitNumbersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler tblQuoteAffidavitNumbersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler tblQuoteAffidavitNumbersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteAffidavitNumbersRow(
      dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow AddtblQuoteAffidavitNumbersRow(
      int QuoteID,
      string StateID,
      string AffidavitNumber,
      int AffidavitNumberIndex,
      bool Exportable,
      bool TaxExempt)
    {
      dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow row = (dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) QuoteID,
        (object) StateID,
        (object) AffidavitNumber,
        (object) AffidavitNumberIndex,
        (object) Exportable,
        (object) TaxExempt
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow FindByQuoteIDStateID(
      int QuoteID,
      string StateID)
    {
      return (dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow) this.Rows.Find(new object[2]
      {
        (object) QuoteID,
        (object) StateID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsEditAffidavitNumbers.tblQuoteAffidavitNumbersDataTable numbersDataTable = (dsEditAffidavitNumbers.tblQuoteAffidavitNumbersDataTable) base.Clone();
      numbersDataTable.InitVars();
      return (DataTable) numbersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsEditAffidavitNumbers.tblQuoteAffidavitNumbersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnStateID = this.Columns["StateID"];
      this.columnAffidavitNumber = this.Columns["AffidavitNumber"];
      this.columnAffidavitNumberIndex = this.Columns["AffidavitNumberIndex"];
      this.columnExportable = this.Columns["Exportable"];
      this.columnTaxExempt = this.Columns["TaxExempt"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnAffidavitNumber = new DataColumn("AffidavitNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAffidavitNumber);
      this.columnAffidavitNumberIndex = new DataColumn("AffidavitNumberIndex", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAffidavitNumberIndex);
      this.columnExportable = new DataColumn("Exportable", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExportable);
      this.columnTaxExempt = new DataColumn("TaxExempt", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxExempt);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsEditAffidavitNumbersKey1", new DataColumn[2]
      {
        this.columnQuoteID,
        this.columnStateID
      }, true));
      this.columnQuoteID.AllowDBNull = false;
      this.columnStateID.AllowDBNull = false;
      this.columnAffidavitNumber.AllowDBNull = false;
      this.columnAffidavitNumberIndex.AllowDBNull = false;
      this.columnExportable.AllowDBNull = false;
      this.columnTaxExempt.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow NewtblQuoteAffidavitNumbersRow()
    {
      return (dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow);
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
      dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler numbersRowChangedEvent = this.tblQuoteAffidavitNumbersRowChangedEvent;
      if (numbersRowChangedEvent == null)
        return;
      numbersRowChangedEvent((object) this, new dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEvent((dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow) e.Row, e.Action));
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
      dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler rowChangingEvent = this.tblQuoteAffidavitNumbersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEvent((dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow) e.Row, e.Action));
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
      dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler numbersRowDeletedEvent = this.tblQuoteAffidavitNumbersRowDeletedEvent;
      if (numbersRowDeletedEvent == null)
        return;
      numbersRowDeletedEvent((object) this, new dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEvent((dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow) e.Row, e.Action));
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
      dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEventHandler rowDeletingEvent = this.tblQuoteAffidavitNumbersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRowChangeEvent((dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteAffidavitNumbersRow(
      dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsEditAffidavitNumbers affidavitNumbers = new dsEditAffidavitNumbers();
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
    private dsEditAffidavitNumbers.tblQuoteAffidavitNumbersDataTable tabletblQuoteAffidavitNumbers;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteAffidavitNumbersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteAffidavitNumbers = (dsEditAffidavitNumbers.tblQuoteAffidavitNumbersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteAffidavitNumbers.QuoteIDColumn]);
      set => this[this.tabletblQuoteAffidavitNumbers.QuoteIDColumn] = (object) value;
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
    public int AffidavitNumberIndex
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteAffidavitNumbers.AffidavitNumberIndexColumn]);
      }
      set => this[this.tabletblQuoteAffidavitNumbers.AffidavitNumberIndexColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Exportable
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteAffidavitNumbers.ExportableColumn]);
      set => this[this.tabletblQuoteAffidavitNumbers.ExportableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool TaxExempt
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteAffidavitNumbers.TaxExemptColumn]);
      set => this[this.tabletblQuoteAffidavitNumbers.TaxExemptColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteAffidavitNumbersRowChangeEvent : EventArgs
  {
    private dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteAffidavitNumbersRowChangeEvent(
      dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
