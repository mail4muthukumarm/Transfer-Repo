// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.dsCompanyLineSignatures
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

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
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCompanyLineSignatures")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyLineSignatures : DataSet
{
  private dsCompanyLineSignatures.tblCompanyLineSignaturesDataTable tabletblCompanyLineSignatures;
  private dsCompanyLineSignatures.lstCompanyLineSignatureTypesDataTable tablelstCompanyLineSignatureTypes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsCompanyLineSignatures()
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
  protected dsCompanyLineSignatures(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyLineSignatures)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineSignatures.tblCompanyLineSignaturesDataTable(dataSet.Tables[nameof (tblCompanyLineSignatures)]));
        if (dataSet.Tables[nameof (lstCompanyLineSignatureTypes)] != null)
          base.Tables.Add((DataTable) new dsCompanyLineSignatures.lstCompanyLineSignatureTypesDataTable(dataSet.Tables[nameof (lstCompanyLineSignatureTypes)]));
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
  public dsCompanyLineSignatures.tblCompanyLineSignaturesDataTable tblCompanyLineSignatures
  {
    get => this.tabletblCompanyLineSignatures;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyLineSignatures.lstCompanyLineSignatureTypesDataTable lstCompanyLineSignatureTypes
  {
    get => this.tablelstCompanyLineSignatureTypes;
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
    dsCompanyLineSignatures companyLineSignatures = (dsCompanyLineSignatures) base.Clone();
    companyLineSignatures.InitVars();
    companyLineSignatures.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) companyLineSignatures;
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
      if (dataSet.Tables["tblCompanyLineSignatures"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineSignatures.tblCompanyLineSignaturesDataTable(dataSet.Tables["tblCompanyLineSignatures"]));
      if (dataSet.Tables["lstCompanyLineSignatureTypes"] != null)
        base.Tables.Add((DataTable) new dsCompanyLineSignatures.lstCompanyLineSignatureTypesDataTable(dataSet.Tables["lstCompanyLineSignatureTypes"]));
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
    this.tabletblCompanyLineSignatures = (dsCompanyLineSignatures.tblCompanyLineSignaturesDataTable) base.Tables["tblCompanyLineSignatures"];
    if (initTable && this.tabletblCompanyLineSignatures != null)
      this.tabletblCompanyLineSignatures.InitVars();
    this.tablelstCompanyLineSignatureTypes = (dsCompanyLineSignatures.lstCompanyLineSignatureTypesDataTable) base.Tables["lstCompanyLineSignatureTypes"];
    if (!initTable || this.tablelstCompanyLineSignatureTypes == null)
      return;
    this.tablelstCompanyLineSignatureTypes.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyLineSignatures);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCompanyLineSignatures.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyLineSignatures = new dsCompanyLineSignatures.tblCompanyLineSignaturesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLineSignatures);
    this.tablelstCompanyLineSignatureTypes = new dsCompanyLineSignatures.lstCompanyLineSignatureTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstCompanyLineSignatureTypes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyLineSignatures() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstCompanyLineSignatureTypes() => false;

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
    dsCompanyLineSignatures companyLineSignatures = new dsCompanyLineSignatures();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = companyLineSignatures.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = companyLineSignatures.GetSchemaSerializable();
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
  public delegate void tblCompanyLineSignaturesRowChangeEventHandler(
    object sender,
    dsCompanyLineSignatures.tblCompanyLineSignaturesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstCompanyLineSignatureTypesRowChangeEventHandler(
    object sender,
    dsCompanyLineSignatures.lstCompanyLineSignatureTypesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyLineSignaturesDataTable : 
    TypedTableBase<dsCompanyLineSignatures.tblCompanyLineSignaturesRow>
  {
    private DataColumn columnSignatureID;
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnFirstName;
    private DataColumn columnLastName;
    private DataColumn columnSignatureTypeID;
    private DataColumn columnSignature;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLineSignaturesDataTable()
    {
      this.TableName = "tblCompanyLineSignatures";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLineSignaturesDataTable(DataTable table)
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
    protected tblCompanyLineSignaturesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SignatureIDColumn => this.columnSignatureID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FirstNameColumn => this.columnFirstName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LastNameColumn => this.columnLastName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SignatureTypeIDColumn => this.columnSignatureTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SignatureColumn => this.columnSignature;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineSignatures.tblCompanyLineSignaturesRow this[int index]
    {
      get => (dsCompanyLineSignatures.tblCompanyLineSignaturesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineSignatures.tblCompanyLineSignaturesRowChangeEventHandler tblCompanyLineSignaturesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineSignatures.tblCompanyLineSignaturesRowChangeEventHandler tblCompanyLineSignaturesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineSignatures.tblCompanyLineSignaturesRowChangeEventHandler tblCompanyLineSignaturesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineSignatures.tblCompanyLineSignaturesRowChangeEventHandler tblCompanyLineSignaturesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyLineSignaturesRow(
      dsCompanyLineSignatures.tblCompanyLineSignaturesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineSignatures.tblCompanyLineSignaturesRow AddtblCompanyLineSignaturesRow(
      Guid CompanyLineGuid,
      string FirstName,
      string LastName,
      short SignatureTypeID,
      byte[] Signature)
    {
      dsCompanyLineSignatures.tblCompanyLineSignaturesRow row = (dsCompanyLineSignatures.tblCompanyLineSignaturesRow) this.NewRow();
      object[] objArray = new object[6]
      {
        null,
        (object) CompanyLineGuid,
        (object) FirstName,
        (object) LastName,
        (object) SignatureTypeID,
        (object) Signature
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineSignatures.tblCompanyLineSignaturesRow FindBySignatureID(int SignatureID)
    {
      return (dsCompanyLineSignatures.tblCompanyLineSignaturesRow) this.Rows.Find(new object[1]
      {
        (object) SignatureID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineSignatures.tblCompanyLineSignaturesDataTable signaturesDataTable = (dsCompanyLineSignatures.tblCompanyLineSignaturesDataTable) base.Clone();
      signaturesDataTable.InitVars();
      return (DataTable) signaturesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineSignatures.tblCompanyLineSignaturesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnSignatureID = this.Columns["SignatureID"];
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnFirstName = this.Columns["FirstName"];
      this.columnLastName = this.Columns["LastName"];
      this.columnSignatureTypeID = this.Columns["SignatureTypeID"];
      this.columnSignature = this.Columns["Signature"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnSignatureID = new DataColumn("SignatureID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSignatureID);
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnFirstName = new DataColumn("FirstName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFirstName);
      this.columnLastName = new DataColumn("LastName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLastName);
      this.columnSignatureTypeID = new DataColumn("SignatureTypeID", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSignatureTypeID);
      this.columnSignature = new DataColumn("Signature", typeof (byte[]), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSignature);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnSignatureID
      }, true));
      this.columnSignatureID.AutoIncrement = true;
      this.columnSignatureID.AllowDBNull = false;
      this.columnSignatureID.ReadOnly = true;
      this.columnSignatureID.Unique = true;
      this.columnCompanyLineGuid.AllowDBNull = false;
      this.columnSignatureTypeID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineSignatures.tblCompanyLineSignaturesRow NewtblCompanyLineSignaturesRow()
    {
      return (dsCompanyLineSignatures.tblCompanyLineSignaturesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineSignatures.tblCompanyLineSignaturesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyLineSignatures.tblCompanyLineSignaturesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineSignaturesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineSignatures.tblCompanyLineSignaturesRowChangeEventHandler signaturesRowChangedEvent = this.tblCompanyLineSignaturesRowChangedEvent;
      if (signaturesRowChangedEvent == null)
        return;
      signaturesRowChangedEvent((object) this, new dsCompanyLineSignatures.tblCompanyLineSignaturesRowChangeEvent((dsCompanyLineSignatures.tblCompanyLineSignaturesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineSignaturesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineSignatures.tblCompanyLineSignaturesRowChangeEventHandler rowChangingEvent = this.tblCompanyLineSignaturesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineSignatures.tblCompanyLineSignaturesRowChangeEvent((dsCompanyLineSignatures.tblCompanyLineSignaturesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineSignaturesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineSignatures.tblCompanyLineSignaturesRowChangeEventHandler signaturesRowDeletedEvent = this.tblCompanyLineSignaturesRowDeletedEvent;
      if (signaturesRowDeletedEvent == null)
        return;
      signaturesRowDeletedEvent((object) this, new dsCompanyLineSignatures.tblCompanyLineSignaturesRowChangeEvent((dsCompanyLineSignatures.tblCompanyLineSignaturesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineSignaturesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineSignatures.tblCompanyLineSignaturesRowChangeEventHandler rowDeletingEvent = this.tblCompanyLineSignaturesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineSignatures.tblCompanyLineSignaturesRowChangeEvent((dsCompanyLineSignatures.tblCompanyLineSignaturesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyLineSignaturesRow(
      dsCompanyLineSignatures.tblCompanyLineSignaturesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineSignatures companyLineSignatures = new dsCompanyLineSignatures();
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
        FixedValue = companyLineSignatures.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLineSignaturesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyLineSignatures.GetSchemaSerializable();
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
  public class lstCompanyLineSignatureTypesDataTable : 
    TypedTableBase<dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow>
  {
    private DataColumn columnSignatureTypeID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstCompanyLineSignatureTypesDataTable()
    {
      this.TableName = "lstCompanyLineSignatureTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstCompanyLineSignatureTypesDataTable(DataTable table)
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
    protected lstCompanyLineSignatureTypesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SignatureTypeIDColumn => this.columnSignatureTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow this[int index]
    {
      get => (dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineSignatures.lstCompanyLineSignatureTypesRowChangeEventHandler lstCompanyLineSignatureTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineSignatures.lstCompanyLineSignatureTypesRowChangeEventHandler lstCompanyLineSignatureTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineSignatures.lstCompanyLineSignatureTypesRowChangeEventHandler lstCompanyLineSignatureTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyLineSignatures.lstCompanyLineSignatureTypesRowChangeEventHandler lstCompanyLineSignatureTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstCompanyLineSignatureTypesRow(
      dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow AddlstCompanyLineSignatureTypesRow(
      string Description)
    {
      dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow row = (dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow FindBySignatureTypeID(
      short SignatureTypeID)
    {
      return (dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow) this.Rows.Find(new object[1]
      {
        (object) SignatureTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyLineSignatures.lstCompanyLineSignatureTypesDataTable signatureTypesDataTable = (dsCompanyLineSignatures.lstCompanyLineSignatureTypesDataTable) base.Clone();
      signatureTypesDataTable.InitVars();
      return (DataTable) signatureTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyLineSignatures.lstCompanyLineSignatureTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnSignatureTypeID = this.Columns["SignatureTypeID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnSignatureTypeID = new DataColumn("SignatureTypeID", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSignatureTypeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyLineSignaturesKey1", new DataColumn[1]
      {
        this.columnSignatureTypeID
      }, true));
      this.columnSignatureTypeID.AutoIncrement = true;
      this.columnSignatureTypeID.AllowDBNull = false;
      this.columnSignatureTypeID.ReadOnly = true;
      this.columnSignatureTypeID.Unique = true;
      this.columnDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow NewlstCompanyLineSignatureTypesRow()
    {
      return (dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCompanyLineSignatureTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineSignatures.lstCompanyLineSignatureTypesRowChangeEventHandler typesRowChangedEvent = this.lstCompanyLineSignatureTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompanyLineSignatures.lstCompanyLineSignatureTypesRowChangeEvent((dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCompanyLineSignatureTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineSignatures.lstCompanyLineSignatureTypesRowChangeEventHandler rowChangingEvent = this.lstCompanyLineSignatureTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyLineSignatures.lstCompanyLineSignatureTypesRowChangeEvent((dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCompanyLineSignatureTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineSignatures.lstCompanyLineSignatureTypesRowChangeEventHandler typesRowDeletedEvent = this.lstCompanyLineSignatureTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompanyLineSignatures.lstCompanyLineSignatureTypesRowChangeEvent((dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstCompanyLineSignatureTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyLineSignatures.lstCompanyLineSignatureTypesRowChangeEventHandler rowDeletingEvent = this.lstCompanyLineSignatureTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyLineSignatures.lstCompanyLineSignatureTypesRowChangeEvent((dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstCompanyLineSignatureTypesRow(
      dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyLineSignatures companyLineSignatures = new dsCompanyLineSignatures();
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
        FixedValue = companyLineSignatures.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstCompanyLineSignatureTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyLineSignatures.GetSchemaSerializable();
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

  public class tblCompanyLineSignaturesRow : DataRow
  {
    private dsCompanyLineSignatures.tblCompanyLineSignaturesDataTable tabletblCompanyLineSignatures;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLineSignaturesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLineSignatures = (dsCompanyLineSignatures.tblCompanyLineSignaturesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int SignatureID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyLineSignatures.SignatureIDColumn]);
      set => this[this.tabletblCompanyLineSignatures.SignatureIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        object obj = this[this.tabletblCompanyLineSignatures.CompanyLineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyLineSignatures.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FirstName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLineSignatures.FirstNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FirstName' in table 'tblCompanyLineSignatures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineSignatures.FirstNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LastName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLineSignatures.LastNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LastName' in table 'tblCompanyLineSignatures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineSignatures.LastNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public short SignatureTypeID
    {
      get => Conversions.ToShort(this[this.tabletblCompanyLineSignatures.SignatureTypeIDColumn]);
      set => this[this.tabletblCompanyLineSignatures.SignatureTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte[] Signature
    {
      get
      {
        try
        {
          return (byte[]) this[this.tabletblCompanyLineSignatures.SignatureColumn];
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Signature' in table 'tblCompanyLineSignatures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineSignatures.SignatureColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFirstNameNull()
    {
      return this.IsNull(this.tabletblCompanyLineSignatures.FirstNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFirstNameNull()
    {
      this[this.tabletblCompanyLineSignatures.FirstNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLastNameNull() => this.IsNull(this.tabletblCompanyLineSignatures.LastNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLastNameNull()
    {
      this[this.tabletblCompanyLineSignatures.LastNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSignatureNull()
    {
      return this.IsNull(this.tabletblCompanyLineSignatures.SignatureColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSignatureNull()
    {
      this[this.tabletblCompanyLineSignatures.SignatureColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstCompanyLineSignatureTypesRow : DataRow
  {
    private dsCompanyLineSignatures.lstCompanyLineSignatureTypesDataTable tablelstCompanyLineSignatureTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstCompanyLineSignatureTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstCompanyLineSignatureTypes = (dsCompanyLineSignatures.lstCompanyLineSignatureTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public short SignatureTypeID
    {
      get
      {
        return Conversions.ToShort(this[this.tablelstCompanyLineSignatureTypes.SignatureTypeIDColumn]);
      }
      set => this[this.tablelstCompanyLineSignatureTypes.SignatureTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstCompanyLineSignatureTypes.DescriptionColumn]);
      set => this[this.tablelstCompanyLineSignatureTypes.DescriptionColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyLineSignaturesRowChangeEvent : EventArgs
  {
    private dsCompanyLineSignatures.tblCompanyLineSignaturesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLineSignaturesRowChangeEvent(
      dsCompanyLineSignatures.tblCompanyLineSignaturesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineSignatures.tblCompanyLineSignaturesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstCompanyLineSignatureTypesRowChangeEvent : EventArgs
  {
    private dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstCompanyLineSignatureTypesRowChangeEvent(
      dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyLineSignatures.lstCompanyLineSignatureTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
