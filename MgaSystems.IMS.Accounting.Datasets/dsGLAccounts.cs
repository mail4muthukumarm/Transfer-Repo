// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsGLAccounts
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
[XmlRoot("dsGLAccounts")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsGLAccounts : DataSet
{
  private dsGLAccounts.AccountClassificationsDataTable tableAccountClassifications;
  private dsGLAccounts.GLAccountsDataTable tableGLAccounts;
  private DataRelation relationAccountClassifications_GLAccounts;
  private DataRelation relationGLAccounts_GLAccounts;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsGLAccounts()
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
  protected dsGLAccounts(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (AccountClassifications)] != null)
          base.Tables.Add((DataTable) new dsGLAccounts.AccountClassificationsDataTable(dataSet.Tables[nameof (AccountClassifications)]));
        if (dataSet.Tables[nameof (GLAccounts)] != null)
          base.Tables.Add((DataTable) new dsGLAccounts.GLAccountsDataTable(dataSet.Tables[nameof (GLAccounts)]));
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
  public dsGLAccounts.AccountClassificationsDataTable AccountClassifications
  {
    get => this.tableAccountClassifications;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGLAccounts.GLAccountsDataTable GLAccounts => this.tableGLAccounts;

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
    dsGLAccounts dsGlAccounts = (dsGLAccounts) base.Clone();
    dsGlAccounts.InitVars();
    dsGlAccounts.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsGlAccounts;
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
      if (dataSet.Tables["AccountClassifications"] != null)
        base.Tables.Add((DataTable) new dsGLAccounts.AccountClassificationsDataTable(dataSet.Tables["AccountClassifications"]));
      if (dataSet.Tables["GLAccounts"] != null)
        base.Tables.Add((DataTable) new dsGLAccounts.GLAccountsDataTable(dataSet.Tables["GLAccounts"]));
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
    this.tableAccountClassifications = (dsGLAccounts.AccountClassificationsDataTable) base.Tables["AccountClassifications"];
    if (initTable && this.tableAccountClassifications != null)
      this.tableAccountClassifications.InitVars();
    this.tableGLAccounts = (dsGLAccounts.GLAccountsDataTable) base.Tables["GLAccounts"];
    if (initTable && this.tableGLAccounts != null)
      this.tableGLAccounts.InitVars();
    this.relationAccountClassifications_GLAccounts = this.Relations["AccountClassifications_GLAccounts"];
    this.relationGLAccounts_GLAccounts = this.Relations["GLAccounts_GLAccounts"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsGLAccounts);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsGLAccounts.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableAccountClassifications = new dsGLAccounts.AccountClassificationsDataTable();
    base.Tables.Add((DataTable) this.tableAccountClassifications);
    this.tableGLAccounts = new dsGLAccounts.GLAccountsDataTable();
    base.Tables.Add((DataTable) this.tableGLAccounts);
    this.relationAccountClassifications_GLAccounts = new DataRelation("AccountClassifications_GLAccounts", new DataColumn[1]
    {
      this.tableAccountClassifications.GLCompanyClassIDColumn
    }, new DataColumn[1]
    {
      this.tableGLAccounts.GLCompanyClassIDColumn
    }, false);
    this.Relations.Add(this.relationAccountClassifications_GLAccounts);
    this.relationGLAccounts_GLAccounts = new DataRelation("GLAccounts_GLAccounts", new DataColumn[1]
    {
      this.tableGLAccounts.GLAcctIDColumn
    }, new DataColumn[1]
    {
      this.tableGLAccounts.RollUpToColumn
    }, false);
    this.Relations.Add(this.relationGLAccounts_GLAccounts);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeAccountClassifications() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeGLAccounts() => false;

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
    dsGLAccounts dsGlAccounts = new dsGLAccounts();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsGlAccounts.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsGlAccounts.GetSchemaSerializable();
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
  public delegate void AccountClassificationsRowChangeEventHandler(
    object sender,
    dsGLAccounts.AccountClassificationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void GLAccountsRowChangeEventHandler(
    object sender,
    dsGLAccounts.GLAccountsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class AccountClassificationsDataTable : 
    TypedTableBase<dsGLAccounts.AccountClassificationsRow>
  {
    private DataColumn columnGLCompanyClassID;
    private DataColumn columnClassFullName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountClassificationsDataTable()
    {
      this.TableName = "AccountClassifications";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AccountClassificationsDataTable(DataTable table)
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
    protected AccountClassificationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLCompanyClassIDColumn => this.columnGLCompanyClassID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassFullNameColumn => this.columnClassFullName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccounts.AccountClassificationsRow this[int index]
    {
      get => (dsGLAccounts.AccountClassificationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLAccounts.AccountClassificationsRowChangeEventHandler AccountClassificationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLAccounts.AccountClassificationsRowChangeEventHandler AccountClassificationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLAccounts.AccountClassificationsRowChangeEventHandler AccountClassificationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLAccounts.AccountClassificationsRowChangeEventHandler AccountClassificationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddAccountClassificationsRow(dsGLAccounts.AccountClassificationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccounts.AccountClassificationsRow AddAccountClassificationsRow(
      int GLCompanyClassID,
      string ClassFullName)
    {
      dsGLAccounts.AccountClassificationsRow row = (dsGLAccounts.AccountClassificationsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) GLCompanyClassID,
        (object) ClassFullName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGLAccounts.AccountClassificationsDataTable classificationsDataTable = (dsGLAccounts.AccountClassificationsDataTable) base.Clone();
      classificationsDataTable.InitVars();
      return (DataTable) classificationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLAccounts.AccountClassificationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnGLCompanyClassID = this.Columns["GLCompanyClassID"];
      this.columnClassFullName = this.Columns["ClassFullName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnGLCompanyClassID = new DataColumn("GLCompanyClassID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLCompanyClassID);
      this.columnClassFullName = new DataColumn("ClassFullName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassFullName);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccounts.AccountClassificationsRow NewAccountClassificationsRow()
    {
      return (dsGLAccounts.AccountClassificationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLAccounts.AccountClassificationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLAccounts.AccountClassificationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountClassificationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccounts.AccountClassificationsRowChangeEventHandler classificationsRowChangedEvent = this.AccountClassificationsRowChangedEvent;
      if (classificationsRowChangedEvent == null)
        return;
      classificationsRowChangedEvent((object) this, new dsGLAccounts.AccountClassificationsRowChangeEvent((dsGLAccounts.AccountClassificationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountClassificationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccounts.AccountClassificationsRowChangeEventHandler rowChangingEvent = this.AccountClassificationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGLAccounts.AccountClassificationsRowChangeEvent((dsGLAccounts.AccountClassificationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountClassificationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccounts.AccountClassificationsRowChangeEventHandler classificationsRowDeletedEvent = this.AccountClassificationsRowDeletedEvent;
      if (classificationsRowDeletedEvent == null)
        return;
      classificationsRowDeletedEvent((object) this, new dsGLAccounts.AccountClassificationsRowChangeEvent((dsGLAccounts.AccountClassificationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountClassificationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccounts.AccountClassificationsRowChangeEventHandler rowDeletingEvent = this.AccountClassificationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGLAccounts.AccountClassificationsRowChangeEvent((dsGLAccounts.AccountClassificationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveAccountClassificationsRow(dsGLAccounts.AccountClassificationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLAccounts dsGlAccounts = new dsGLAccounts();
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
        FixedValue = dsGlAccounts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (AccountClassificationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGlAccounts.GetSchemaSerializable();
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
  public class GLAccountsDataTable : TypedTableBase<dsGLAccounts.GLAccountsRow>
  {
    private DataColumn columnGLCompanyClassID;
    private DataColumn columnGLAcctID;
    private DataColumn columnFullName;
    private DataColumn columnRollUpTo;
    private DataColumn columnControlAcct;
    private DataColumn columnSystemDefined;
    private DataColumn columnShortName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public GLAccountsDataTable()
    {
      this.TableName = "GLAccounts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal GLAccountsDataTable(DataTable table)
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
    protected GLAccountsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLCompanyClassIDColumn => this.columnGLCompanyClassID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLAcctIDColumn => this.columnGLAcctID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FullNameColumn => this.columnFullName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RollUpToColumn => this.columnRollUpTo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ControlAcctColumn => this.columnControlAcct;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SystemDefinedColumn => this.columnSystemDefined;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ShortNameColumn => this.columnShortName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccounts.GLAccountsRow this[int index]
    {
      get => (dsGLAccounts.GLAccountsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLAccounts.GLAccountsRowChangeEventHandler GLAccountsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLAccounts.GLAccountsRowChangeEventHandler GLAccountsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLAccounts.GLAccountsRowChangeEventHandler GLAccountsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLAccounts.GLAccountsRowChangeEventHandler GLAccountsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddGLAccountsRow(dsGLAccounts.GLAccountsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccounts.GLAccountsRow AddGLAccountsRow(
      dsGLAccounts.AccountClassificationsRow parentAccountClassificationsRowByAccountClassifications_GLAccounts,
      int GLAcctID,
      string FullName,
      dsGLAccounts.GLAccountsRow parentGLAccountsRowByGLAccounts_GLAccounts,
      bool ControlAcct,
      bool SystemDefined,
      string ShortName)
    {
      dsGLAccounts.GLAccountsRow row = (dsGLAccounts.GLAccountsRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        (object) GLAcctID,
        (object) FullName,
        null,
        (object) ControlAcct,
        (object) SystemDefined,
        (object) ShortName
      };
      if (parentAccountClassificationsRowByAccountClassifications_GLAccounts != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parentAccountClassificationsRowByAccountClassifications_GLAccounts[0]);
      if (parentGLAccountsRowByGLAccounts_GLAccounts != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parentGLAccountsRowByGLAccounts_GLAccounts[1]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGLAccounts.GLAccountsDataTable accountsDataTable = (dsGLAccounts.GLAccountsDataTable) base.Clone();
      accountsDataTable.InitVars();
      return (DataTable) accountsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLAccounts.GLAccountsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnGLCompanyClassID = this.Columns["GLCompanyClassID"];
      this.columnGLAcctID = this.Columns["GLAcctID"];
      this.columnFullName = this.Columns["FullName"];
      this.columnRollUpTo = this.Columns["RollUpTo"];
      this.columnControlAcct = this.Columns["ControlAcct"];
      this.columnSystemDefined = this.Columns["SystemDefined"];
      this.columnShortName = this.Columns["ShortName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnGLCompanyClassID = new DataColumn("GLCompanyClassID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLCompanyClassID);
      this.columnGLAcctID = new DataColumn("GLAcctID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAcctID);
      this.columnFullName = new DataColumn("FullName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullName);
      this.columnRollUpTo = new DataColumn("RollUpTo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRollUpTo);
      this.columnControlAcct = new DataColumn("ControlAcct", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlAcct);
      this.columnSystemDefined = new DataColumn("SystemDefined", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSystemDefined);
      this.columnShortName = new DataColumn("ShortName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnShortName);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccounts.GLAccountsRow NewGLAccountsRow()
    {
      return (dsGLAccounts.GLAccountsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLAccounts.GLAccountsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLAccounts.GLAccountsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.GLAccountsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccounts.GLAccountsRowChangeEventHandler accountsRowChangedEvent = this.GLAccountsRowChangedEvent;
      if (accountsRowChangedEvent == null)
        return;
      accountsRowChangedEvent((object) this, new dsGLAccounts.GLAccountsRowChangeEvent((dsGLAccounts.GLAccountsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.GLAccountsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccounts.GLAccountsRowChangeEventHandler rowChangingEvent = this.GLAccountsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGLAccounts.GLAccountsRowChangeEvent((dsGLAccounts.GLAccountsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.GLAccountsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccounts.GLAccountsRowChangeEventHandler accountsRowDeletedEvent = this.GLAccountsRowDeletedEvent;
      if (accountsRowDeletedEvent == null)
        return;
      accountsRowDeletedEvent((object) this, new dsGLAccounts.GLAccountsRowChangeEvent((dsGLAccounts.GLAccountsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.GLAccountsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccounts.GLAccountsRowChangeEventHandler rowDeletingEvent = this.GLAccountsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGLAccounts.GLAccountsRowChangeEvent((dsGLAccounts.GLAccountsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveGLAccountsRow(dsGLAccounts.GLAccountsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLAccounts dsGlAccounts = new dsGLAccounts();
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
        FixedValue = dsGlAccounts.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (GLAccountsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGlAccounts.GetSchemaSerializable();
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

  public class AccountClassificationsRow : DataRow
  {
    private dsGLAccounts.AccountClassificationsDataTable tableAccountClassifications;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AccountClassificationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAccountClassifications = (dsGLAccounts.AccountClassificationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GLCompanyClassID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAccountClassifications.GLCompanyClassIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GLCompanyClassID' in table 'AccountClassifications' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountClassifications.GLCompanyClassIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ClassFullName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAccountClassifications.ClassFullNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClassFullName' in table 'AccountClassifications' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountClassifications.ClassFullNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLCompanyClassIDNull()
    {
      return this.IsNull(this.tableAccountClassifications.GLCompanyClassIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLCompanyClassIDNull()
    {
      this[this.tableAccountClassifications.GLCompanyClassIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsClassFullNameNull()
    {
      return this.IsNull(this.tableAccountClassifications.ClassFullNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetClassFullNameNull()
    {
      this[this.tableAccountClassifications.ClassFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccounts.GLAccountsRow[] GetGLAccountsRows()
    {
      return this.Table.ChildRelations["AccountClassifications_GLAccounts"] != null ? (dsGLAccounts.GLAccountsRow[]) this.GetChildRows(this.Table.ChildRelations["AccountClassifications_GLAccounts"]) : new dsGLAccounts.GLAccountsRow[0];
    }
  }

  public class GLAccountsRow : DataRow
  {
    private dsGLAccounts.GLAccountsDataTable tableGLAccounts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal GLAccountsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableGLAccounts = (dsGLAccounts.GLAccountsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GLCompanyClassID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableGLAccounts.GLCompanyClassIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GLCompanyClassID' in table 'GLAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableGLAccounts.GLCompanyClassIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GLAcctID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableGLAccounts.GLAcctIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GLAcctID' in table 'GLAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableGLAccounts.GLAcctIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FullName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableGLAccounts.FullNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FullName' in table 'GLAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableGLAccounts.FullNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int RollUpTo
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableGLAccounts.RollUpToColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RollUpTo' in table 'GLAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableGLAccounts.RollUpToColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool ControlAcct
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableGLAccounts.ControlAcctColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ControlAcct' in table 'GLAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableGLAccounts.ControlAcctColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool SystemDefined
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableGLAccounts.SystemDefinedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SystemDefined' in table 'GLAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableGLAccounts.SystemDefinedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ShortName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableGLAccounts.ShortNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ShortName' in table 'GLAccounts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableGLAccounts.ShortNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccounts.AccountClassificationsRow AccountClassificationsRow
    {
      get
      {
        return (dsGLAccounts.AccountClassificationsRow) this.GetParentRow(this.Table.ParentRelations["AccountClassifications_GLAccounts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["AccountClassifications_GLAccounts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccounts.GLAccountsRow GLAccountsRowParent
    {
      get
      {
        return (dsGLAccounts.GLAccountsRow) this.GetParentRow(this.Table.ParentRelations["GLAccounts_GLAccounts"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["GLAccounts_GLAccounts"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLCompanyClassIDNull()
    {
      return this.IsNull(this.tableGLAccounts.GLCompanyClassIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLCompanyClassIDNull()
    {
      this[this.tableGLAccounts.GLCompanyClassIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLAcctIDNull() => this.IsNull(this.tableGLAccounts.GLAcctIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLAcctIDNull()
    {
      this[this.tableGLAccounts.GLAcctIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFullNameNull() => this.IsNull(this.tableGLAccounts.FullNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFullNameNull()
    {
      this[this.tableGLAccounts.FullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRollUpToNull() => this.IsNull(this.tableGLAccounts.RollUpToColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRollUpToNull()
    {
      this[this.tableGLAccounts.RollUpToColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsControlAcctNull() => this.IsNull(this.tableGLAccounts.ControlAcctColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetControlAcctNull()
    {
      this[this.tableGLAccounts.ControlAcctColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSystemDefinedNull() => this.IsNull(this.tableGLAccounts.SystemDefinedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSystemDefinedNull()
    {
      this[this.tableGLAccounts.SystemDefinedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsShortNameNull() => this.IsNull(this.tableGLAccounts.ShortNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetShortNameNull()
    {
      this[this.tableGLAccounts.ShortNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccounts.GLAccountsRow[] GetGLAccountsRows()
    {
      return this.Table.ChildRelations["GLAccounts_GLAccounts"] != null ? (dsGLAccounts.GLAccountsRow[]) this.GetChildRows(this.Table.ChildRelations["GLAccounts_GLAccounts"]) : new dsGLAccounts.GLAccountsRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class AccountClassificationsRowChangeEvent : EventArgs
  {
    private dsGLAccounts.AccountClassificationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountClassificationsRowChangeEvent(
      dsGLAccounts.AccountClassificationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccounts.AccountClassificationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class GLAccountsRowChangeEvent : EventArgs
  {
    private dsGLAccounts.GLAccountsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public GLAccountsRowChangeEvent(dsGLAccounts.GLAccountsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLAccounts.GLAccountsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
