// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyDetail.dsPolicyHistory
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
namespace MGASystems.IMS.Policies.PolicyDetail;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPolicyHistory")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPolicyHistory : DataSet
{
  private dsPolicyHistory.viewPolicyHistoryDataTable tableviewPolicyHistory;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsPolicyHistory()
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
  protected dsPolicyHistory(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (viewPolicyHistory)] != null)
          base.Tables.Add((DataTable) new dsPolicyHistory.viewPolicyHistoryDataTable(dataSet.Tables[nameof (viewPolicyHistory)]));
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
  public dsPolicyHistory.viewPolicyHistoryDataTable viewPolicyHistory
  {
    get => this.tableviewPolicyHistory;
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
    dsPolicyHistory dsPolicyHistory = (dsPolicyHistory) base.Clone();
    dsPolicyHistory.InitVars();
    dsPolicyHistory.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsPolicyHistory;
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
      if (dataSet.Tables["viewPolicyHistory"] != null)
        base.Tables.Add((DataTable) new dsPolicyHistory.viewPolicyHistoryDataTable(dataSet.Tables["viewPolicyHistory"]));
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
    this.tableviewPolicyHistory = (dsPolicyHistory.viewPolicyHistoryDataTable) base.Tables["viewPolicyHistory"];
    if (!initTable || this.tableviewPolicyHistory == null)
      return;
    this.tableviewPolicyHistory.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPolicyHistory);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPolicyHistory.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableviewPolicyHistory = new dsPolicyHistory.viewPolicyHistoryDataTable();
    base.Tables.Add((DataTable) this.tableviewPolicyHistory);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeviewPolicyHistory() => false;

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
    dsPolicyHistory dsPolicyHistory = new dsPolicyHistory();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsPolicyHistory.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsPolicyHistory.GetSchemaSerializable();
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
  public delegate void viewPolicyHistoryRowChangeEventHandler(
    object sender,
    dsPolicyHistory.viewPolicyHistoryRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class viewPolicyHistoryDataTable : TypedTableBase<dsPolicyHistory.viewPolicyHistoryRow>
  {
    private DataColumn columnQuoteGUID;
    private DataColumn columnBound;
    private DataColumn columnStatus;
    private DataColumn columnTransactionType;
    private DataColumn columnEffective;
    private DataColumn columnExpiration;
    private DataColumn columnPolicyType;
    private DataColumn columnCreated;
    private DataColumn columnView;
    private DataColumn columnReason;
    private DataColumn columnEndorsementComment;
    private DataColumn columnQuoteStatusComment;
    private DataColumn columnDetail;
    private DataColumn columnEndorsementNum;
    private DataColumn columnQuoteID;
    private DataColumn columnAmount;
    private DataColumn columnEndorsementCalcType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public viewPolicyHistoryDataTable()
    {
      this.TableName = "viewPolicyHistory";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal viewPolicyHistoryDataTable(DataTable table)
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
    protected viewPolicyHistoryDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteGUIDColumn => this.columnQuoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BoundColumn => this.columnBound;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TransactionTypeColumn => this.columnTransactionType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EffectiveColumn => this.columnEffective;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExpirationColumn => this.columnExpiration;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyTypeColumn => this.columnPolicyType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CreatedColumn => this.columnCreated;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ViewColumn => this.columnView;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ReasonColumn => this.columnReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EndorsementCommentColumn => this.columnEndorsementComment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteStatusCommentColumn => this.columnQuoteStatusComment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DetailColumn => this.columnDetail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EndorsementNumColumn => this.columnEndorsementNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AmountColumn => this.columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EndorsementCalcTypeColumn => this.columnEndorsementCalcType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyHistory.viewPolicyHistoryRow this[int index]
    {
      get => (dsPolicyHistory.viewPolicyHistoryRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyHistory.viewPolicyHistoryRowChangeEventHandler viewPolicyHistoryRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyHistory.viewPolicyHistoryRowChangeEventHandler viewPolicyHistoryRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyHistory.viewPolicyHistoryRowChangeEventHandler viewPolicyHistoryRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyHistory.viewPolicyHistoryRowChangeEventHandler viewPolicyHistoryRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddviewPolicyHistoryRow(dsPolicyHistory.viewPolicyHistoryRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyHistory.viewPolicyHistoryRow AddviewPolicyHistoryRow(
      Guid QuoteGUID,
      string Bound,
      string Status,
      string TransactionType,
      DateTime Effective,
      DateTime Expiration,
      string PolicyType,
      DateTime Created,
      string View,
      string Reason,
      string EndorsementComment,
      string QuoteStatusComment,
      string Detail,
      int EndorsementNum,
      int QuoteID,
      double Amount,
      string EndorsementCalcType)
    {
      dsPolicyHistory.viewPolicyHistoryRow row = (dsPolicyHistory.viewPolicyHistoryRow) this.NewRow();
      object[] objArray = new object[17]
      {
        (object) QuoteGUID,
        (object) Bound,
        (object) Status,
        (object) TransactionType,
        (object) Effective,
        (object) Expiration,
        (object) PolicyType,
        (object) Created,
        (object) View,
        (object) Reason,
        (object) EndorsementComment,
        (object) QuoteStatusComment,
        (object) Detail,
        (object) EndorsementNum,
        (object) QuoteID,
        (object) Amount,
        (object) EndorsementCalcType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyHistory.viewPolicyHistoryRow FindByQuoteGUID(Guid QuoteGUID)
    {
      return (dsPolicyHistory.viewPolicyHistoryRow) this.Rows.Find(new object[1]
      {
        (object) QuoteGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyHistory.viewPolicyHistoryDataTable historyDataTable = (dsPolicyHistory.viewPolicyHistoryDataTable) base.Clone();
      historyDataTable.InitVars();
      return (DataTable) historyDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyHistory.viewPolicyHistoryDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteGUID = this.Columns["QuoteGUID"];
      this.columnBound = this.Columns["Bound"];
      this.columnStatus = this.Columns["Status"];
      this.columnTransactionType = this.Columns["TransactionType"];
      this.columnEffective = this.Columns["Effective"];
      this.columnExpiration = this.Columns["Expiration"];
      this.columnPolicyType = this.Columns["PolicyType"];
      this.columnCreated = this.Columns["Created"];
      this.columnView = this.Columns["View"];
      this.columnReason = this.Columns["Reason"];
      this.columnEndorsementComment = this.Columns["EndorsementComment"];
      this.columnQuoteStatusComment = this.Columns["QuoteStatusComment"];
      this.columnDetail = this.Columns["Detail"];
      this.columnEndorsementNum = this.Columns["EndorsementNum"];
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnAmount = this.Columns["Amount"];
      this.columnEndorsementCalcType = this.Columns["EndorsementCalcType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteGUID = new DataColumn("QuoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGUID);
      this.columnBound = new DataColumn("Bound", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBound);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnTransactionType = new DataColumn("TransactionType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransactionType);
      this.columnEffective = new DataColumn("Effective", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffective);
      this.columnExpiration = new DataColumn("Expiration", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpiration);
      this.columnPolicyType = new DataColumn("PolicyType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyType);
      this.columnCreated = new DataColumn("Created", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCreated);
      this.columnView = new DataColumn("View", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnView);
      this.columnReason = new DataColumn("Reason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReason);
      this.columnEndorsementComment = new DataColumn("EndorsementComment", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementComment);
      this.columnQuoteStatusComment = new DataColumn("QuoteStatusComment", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatusComment);
      this.columnDetail = new DataColumn("Detail", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDetail);
      this.columnEndorsementNum = new DataColumn("EndorsementNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementNum);
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnAmount = new DataColumn("Amount", typeof (double), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnEndorsementCalcType = new DataColumn("EndorsementCalcType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementCalcType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyHistoryKey1", new DataColumn[1]
      {
        this.columnQuoteGUID
      }, true));
      this.columnQuoteGUID.AllowDBNull = false;
      this.columnQuoteGUID.Unique = true;
      this.columnBound.AllowDBNull = false;
      this.columnStatus.AllowDBNull = false;
      this.columnEffective.AllowDBNull = false;
      this.columnExpiration.AllowDBNull = false;
      this.columnPolicyType.AllowDBNull = false;
      this.columnView.AllowDBNull = false;
      this.columnView.DefaultValue = (object) "View";
      this.columnDetail.AllowDBNull = false;
      this.columnDetail.DefaultValue = (object) "Detail";
      this.columnAmount.DefaultValue = (object) 0.0;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyHistory.viewPolicyHistoryRow NewviewPolicyHistoryRow()
    {
      return (dsPolicyHistory.viewPolicyHistoryRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyHistory.viewPolicyHistoryRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyHistory.viewPolicyHistoryRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.viewPolicyHistoryRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyHistory.viewPolicyHistoryRowChangeEventHandler historyRowChangedEvent = this.viewPolicyHistoryRowChangedEvent;
      if (historyRowChangedEvent == null)
        return;
      historyRowChangedEvent((object) this, new dsPolicyHistory.viewPolicyHistoryRowChangeEvent((dsPolicyHistory.viewPolicyHistoryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.viewPolicyHistoryRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyHistory.viewPolicyHistoryRowChangeEventHandler rowChangingEvent = this.viewPolicyHistoryRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyHistory.viewPolicyHistoryRowChangeEvent((dsPolicyHistory.viewPolicyHistoryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.viewPolicyHistoryRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyHistory.viewPolicyHistoryRowChangeEventHandler historyRowDeletedEvent = this.viewPolicyHistoryRowDeletedEvent;
      if (historyRowDeletedEvent == null)
        return;
      historyRowDeletedEvent((object) this, new dsPolicyHistory.viewPolicyHistoryRowChangeEvent((dsPolicyHistory.viewPolicyHistoryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.viewPolicyHistoryRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyHistory.viewPolicyHistoryRowChangeEventHandler rowDeletingEvent = this.viewPolicyHistoryRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyHistory.viewPolicyHistoryRowChangeEvent((dsPolicyHistory.viewPolicyHistoryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveviewPolicyHistoryRow(dsPolicyHistory.viewPolicyHistoryRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyHistory dsPolicyHistory = new dsPolicyHistory();
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
        FixedValue = dsPolicyHistory.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (viewPolicyHistoryDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyHistory.GetSchemaSerializable();
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

  public class viewPolicyHistoryRow : DataRow
  {
    private dsPolicyHistory.viewPolicyHistoryDataTable tableviewPolicyHistory;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal viewPolicyHistoryRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableviewPolicyHistory = (dsPolicyHistory.viewPolicyHistoryDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid QuoteGUID
    {
      get
      {
        object obj = this[this.tableviewPolicyHistory.QuoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableviewPolicyHistory.QuoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Bound
    {
      get => Conversions.ToString(this[this.tableviewPolicyHistory.BoundColumn]);
      set => this[this.tableviewPolicyHistory.BoundColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Status
    {
      get => Conversions.ToString(this[this.tableviewPolicyHistory.StatusColumn]);
      set => this[this.tableviewPolicyHistory.StatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string TransactionType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableviewPolicyHistory.TransactionTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TransactionType' in table 'viewPolicyHistory' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewPolicyHistory.TransactionTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime Effective
    {
      get => Conversions.ToDate(this[this.tableviewPolicyHistory.EffectiveColumn]);
      set => this[this.tableviewPolicyHistory.EffectiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime Expiration
    {
      get => Conversions.ToDate(this[this.tableviewPolicyHistory.ExpirationColumn]);
      set => this[this.tableviewPolicyHistory.ExpirationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyType
    {
      get => Conversions.ToString(this[this.tableviewPolicyHistory.PolicyTypeColumn]);
      set => this[this.tableviewPolicyHistory.PolicyTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime Created
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableviewPolicyHistory.CreatedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Created' in table 'viewPolicyHistory' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewPolicyHistory.CreatedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string View
    {
      get => Conversions.ToString(this[this.tableviewPolicyHistory.ViewColumn]);
      set => this[this.tableviewPolicyHistory.ViewColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Reason
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableviewPolicyHistory.ReasonColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Reason' in table 'viewPolicyHistory' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewPolicyHistory.ReasonColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EndorsementComment
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableviewPolicyHistory.EndorsementCommentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementComment' in table 'viewPolicyHistory' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewPolicyHistory.EndorsementCommentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string QuoteStatusComment
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableviewPolicyHistory.QuoteStatusCommentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteStatusComment' in table 'viewPolicyHistory' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewPolicyHistory.QuoteStatusCommentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Detail
    {
      get => Conversions.ToString(this[this.tableviewPolicyHistory.DetailColumn]);
      set => this[this.tableviewPolicyHistory.DetailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int EndorsementNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableviewPolicyHistory.EndorsementNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementNum' in table 'viewPolicyHistory' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewPolicyHistory.EndorsementNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int QuoteID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableviewPolicyHistory.QuoteIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteID' in table 'viewPolicyHistory' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewPolicyHistory.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public double Amount
    {
      get
      {
        try
        {
          return Conversions.ToDouble(this[this.tableviewPolicyHistory.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Amount' in table 'viewPolicyHistory' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewPolicyHistory.AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EndorsementCalcType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableviewPolicyHistory.EndorsementCalcTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementCalcType' in table 'viewPolicyHistory' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableviewPolicyHistory.EndorsementCalcTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTransactionTypeNull()
    {
      return this.IsNull(this.tableviewPolicyHistory.TransactionTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTransactionTypeNull()
    {
      this[this.tableviewPolicyHistory.TransactionTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCreatedNull() => this.IsNull(this.tableviewPolicyHistory.CreatedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCreatedNull()
    {
      this[this.tableviewPolicyHistory.CreatedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsReasonNull() => this.IsNull(this.tableviewPolicyHistory.ReasonColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetReasonNull()
    {
      this[this.tableviewPolicyHistory.ReasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEndorsementCommentNull()
    {
      return this.IsNull(this.tableviewPolicyHistory.EndorsementCommentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEndorsementCommentNull()
    {
      this[this.tableviewPolicyHistory.EndorsementCommentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsQuoteStatusCommentNull()
    {
      return this.IsNull(this.tableviewPolicyHistory.QuoteStatusCommentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetQuoteStatusCommentNull()
    {
      this[this.tableviewPolicyHistory.QuoteStatusCommentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEndorsementNumNull()
    {
      return this.IsNull(this.tableviewPolicyHistory.EndorsementNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEndorsementNumNull()
    {
      this[this.tableviewPolicyHistory.EndorsementNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsQuoteIDNull() => this.IsNull(this.tableviewPolicyHistory.QuoteIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetQuoteIDNull()
    {
      this[this.tableviewPolicyHistory.QuoteIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAmountNull() => this.IsNull(this.tableviewPolicyHistory.AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAmountNull()
    {
      this[this.tableviewPolicyHistory.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEndorsementCalcTypeNull()
    {
      return this.IsNull(this.tableviewPolicyHistory.EndorsementCalcTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEndorsementCalcTypeNull()
    {
      this[this.tableviewPolicyHistory.EndorsementCalcTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class viewPolicyHistoryRowChangeEvent : EventArgs
  {
    private dsPolicyHistory.viewPolicyHistoryRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public viewPolicyHistoryRowChangeEvent(
      dsPolicyHistory.viewPolicyHistoryRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyHistory.viewPolicyHistoryRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
