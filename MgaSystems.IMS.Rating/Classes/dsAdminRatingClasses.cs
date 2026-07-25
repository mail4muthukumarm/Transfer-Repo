// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.Classes.dsAdminRatingClasses
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
namespace MGASystems.IMS.Policies.Rating.Classes;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsAdminRatingClasses")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsAdminRatingClasses : DataSet
{
  private dsAdminRatingClasses.lstSIC_CodesDataTable tablelstSIC_Codes;
  private dsAdminRatingClasses.lstClassCodesDataTable tablelstClassCodes;
  private DataRelation relationlstSIC_CodeslstClassCodes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsAdminRatingClasses()
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
  protected dsAdminRatingClasses(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstSIC_Codes)] != null)
          base.Tables.Add((DataTable) new dsAdminRatingClasses.lstSIC_CodesDataTable(dataSet.Tables[nameof (lstSIC_Codes)]));
        if (dataSet.Tables[nameof (lstClassCodes)] != null)
          base.Tables.Add((DataTable) new dsAdminRatingClasses.lstClassCodesDataTable(dataSet.Tables[nameof (lstClassCodes)]));
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
  public dsAdminRatingClasses.lstSIC_CodesDataTable lstSIC_Codes => this.tablelstSIC_Codes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminRatingClasses.lstClassCodesDataTable lstClassCodes => this.tablelstClassCodes;

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
    dsAdminRatingClasses adminRatingClasses = (dsAdminRatingClasses) base.Clone();
    adminRatingClasses.InitVars();
    adminRatingClasses.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) adminRatingClasses;
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
      if (dataSet.Tables["lstSIC_Codes"] != null)
        base.Tables.Add((DataTable) new dsAdminRatingClasses.lstSIC_CodesDataTable(dataSet.Tables["lstSIC_Codes"]));
      if (dataSet.Tables["lstClassCodes"] != null)
        base.Tables.Add((DataTable) new dsAdminRatingClasses.lstClassCodesDataTable(dataSet.Tables["lstClassCodes"]));
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
    this.tablelstSIC_Codes = (dsAdminRatingClasses.lstSIC_CodesDataTable) base.Tables["lstSIC_Codes"];
    if (initTable && this.tablelstSIC_Codes != null)
      this.tablelstSIC_Codes.InitVars();
    this.tablelstClassCodes = (dsAdminRatingClasses.lstClassCodesDataTable) base.Tables["lstClassCodes"];
    if (initTable && this.tablelstClassCodes != null)
      this.tablelstClassCodes.InitVars();
    this.relationlstSIC_CodeslstClassCodes = this.Relations["lstSIC_CodeslstClassCodes"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsAdminRatingClasses);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsAdminRatingClasses.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstSIC_Codes = new dsAdminRatingClasses.lstSIC_CodesDataTable();
    base.Tables.Add((DataTable) this.tablelstSIC_Codes);
    this.tablelstClassCodes = new dsAdminRatingClasses.lstClassCodesDataTable();
    base.Tables.Add((DataTable) this.tablelstClassCodes);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("lstSIC_CodeslstClassCodes", new DataColumn[1]
    {
      this.tablelstSIC_Codes.SIC_CodeColumn
    }, new DataColumn[1]
    {
      this.tablelstClassCodes.SIC_CodeColumn
    });
    this.tablelstClassCodes.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationlstSIC_CodeslstClassCodes = new DataRelation("lstSIC_CodeslstClassCodes", new DataColumn[1]
    {
      this.tablelstSIC_Codes.SIC_CodeColumn
    }, new DataColumn[1]
    {
      this.tablelstClassCodes.SIC_CodeColumn
    }, false);
    this.Relations.Add(this.relationlstSIC_CodeslstClassCodes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstSIC_Codes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstClassCodes() => false;

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
    dsAdminRatingClasses adminRatingClasses = new dsAdminRatingClasses();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = adminRatingClasses.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = adminRatingClasses.GetSchemaSerializable();
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
  public delegate void lstSIC_CodesRowChangeEventHandler(
    object sender,
    dsAdminRatingClasses.lstSIC_CodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstClassCodesRowChangeEventHandler(
    object sender,
    dsAdminRatingClasses.lstClassCodesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstSIC_CodesDataTable : TypedTableBase<dsAdminRatingClasses.lstSIC_CodesRow>
  {
    private DataColumn columnSIC_Code;
    private DataColumn columnSIC_Description;
    private DataColumn columnSIC_Family_Description;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstSIC_CodesDataTable()
    {
      this.TableName = "lstSIC_Codes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstSIC_CodesDataTable(DataTable table)
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
    protected lstSIC_CodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SIC_CodeColumn => this.columnSIC_Code;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SIC_DescriptionColumn => this.columnSIC_Description;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SIC_Family_DescriptionColumn => this.columnSIC_Family_Description;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminRatingClasses.lstSIC_CodesRow this[int index]
    {
      get => (dsAdminRatingClasses.lstSIC_CodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminRatingClasses.lstSIC_CodesRowChangeEventHandler lstSIC_CodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminRatingClasses.lstSIC_CodesRowChangeEventHandler lstSIC_CodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminRatingClasses.lstSIC_CodesRowChangeEventHandler lstSIC_CodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminRatingClasses.lstSIC_CodesRowChangeEventHandler lstSIC_CodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstSIC_CodesRow(dsAdminRatingClasses.lstSIC_CodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminRatingClasses.lstSIC_CodesRow AddlstSIC_CodesRow(
      string SIC_Code,
      string SIC_Description,
      string SIC_Family_Description)
    {
      dsAdminRatingClasses.lstSIC_CodesRow row = (dsAdminRatingClasses.lstSIC_CodesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) SIC_Code,
        (object) SIC_Description,
        (object) SIC_Family_Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminRatingClasses.lstSIC_CodesRow FindBySIC_Code(string SIC_Code)
    {
      return (dsAdminRatingClasses.lstSIC_CodesRow) this.Rows.Find(new object[1]
      {
        (object) SIC_Code
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminRatingClasses.lstSIC_CodesDataTable sicCodesDataTable = (dsAdminRatingClasses.lstSIC_CodesDataTable) base.Clone();
      sicCodesDataTable.InitVars();
      return (DataTable) sicCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminRatingClasses.lstSIC_CodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnSIC_Code = this.Columns["SIC_Code"];
      this.columnSIC_Description = this.Columns["SIC_Description"];
      this.columnSIC_Family_Description = this.Columns["SIC_Family_Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnSIC_Code = new DataColumn("SIC_Code", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIC_Code);
      this.columnSIC_Description = new DataColumn("SIC_Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIC_Description);
      this.columnSIC_Family_Description = new DataColumn("SIC_Family_Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIC_Family_Description);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdminRatingClassesKey2", new DataColumn[1]
      {
        this.columnSIC_Code
      }, true));
      this.columnSIC_Code.AllowDBNull = false;
      this.columnSIC_Code.Unique = true;
      this.columnSIC_Description.AllowDBNull = false;
      this.columnSIC_Family_Description.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminRatingClasses.lstSIC_CodesRow NewlstSIC_CodesRow()
    {
      return (dsAdminRatingClasses.lstSIC_CodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminRatingClasses.lstSIC_CodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminRatingClasses.lstSIC_CodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSIC_CodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRatingClasses.lstSIC_CodesRowChangeEventHandler codesRowChangedEvent = this.lstSIC_CodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsAdminRatingClasses.lstSIC_CodesRowChangeEvent((dsAdminRatingClasses.lstSIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSIC_CodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRatingClasses.lstSIC_CodesRowChangeEventHandler rowChangingEvent = this.lstSIC_CodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminRatingClasses.lstSIC_CodesRowChangeEvent((dsAdminRatingClasses.lstSIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSIC_CodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRatingClasses.lstSIC_CodesRowChangeEventHandler codesRowDeletedEvent = this.lstSIC_CodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsAdminRatingClasses.lstSIC_CodesRowChangeEvent((dsAdminRatingClasses.lstSIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSIC_CodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRatingClasses.lstSIC_CodesRowChangeEventHandler rowDeletingEvent = this.lstSIC_CodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminRatingClasses.lstSIC_CodesRowChangeEvent((dsAdminRatingClasses.lstSIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstSIC_CodesRow(dsAdminRatingClasses.lstSIC_CodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminRatingClasses adminRatingClasses = new dsAdminRatingClasses();
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
        FixedValue = adminRatingClasses.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstSIC_CodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = adminRatingClasses.GetSchemaSerializable();
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
  public class lstClassCodesDataTable : TypedTableBase<dsAdminRatingClasses.lstClassCodesRow>
  {
    private DataColumn columnClassCodeID;
    private DataColumn columnClassCode;
    private DataColumn columnClassCodeDescription;
    private DataColumn columnSIC_Code;
    private DataColumn columnWCClassCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstClassCodesDataTable()
    {
      this.TableName = "lstClassCodes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstClassCodesDataTable(DataTable table)
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
    protected lstClassCodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClassCodeIDColumn => this.columnClassCodeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClassCodeColumn => this.columnClassCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClassCodeDescriptionColumn => this.columnClassCodeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SIC_CodeColumn => this.columnSIC_Code;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WCClassCodeColumn => this.columnWCClassCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminRatingClasses.lstClassCodesRow this[int index]
    {
      get => (dsAdminRatingClasses.lstClassCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminRatingClasses.lstClassCodesRowChangeEventHandler lstClassCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminRatingClasses.lstClassCodesRowChangeEventHandler lstClassCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminRatingClasses.lstClassCodesRowChangeEventHandler lstClassCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminRatingClasses.lstClassCodesRowChangeEventHandler lstClassCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstClassCodesRow(dsAdminRatingClasses.lstClassCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminRatingClasses.lstClassCodesRow AddlstClassCodesRow(
      string ClassCode,
      string ClassCodeDescription,
      dsAdminRatingClasses.lstSIC_CodesRow parentlstSIC_CodesRowBylstSIC_CodeslstClassCodes,
      bool WCClassCode)
    {
      dsAdminRatingClasses.lstClassCodesRow row = (dsAdminRatingClasses.lstClassCodesRow) this.NewRow();
      object[] objArray = new object[5]
      {
        null,
        (object) ClassCode,
        (object) ClassCodeDescription,
        null,
        (object) WCClassCode
      };
      if (parentlstSIC_CodesRowBylstSIC_CodeslstClassCodes != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parentlstSIC_CodesRowBylstSIC_CodeslstClassCodes[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminRatingClasses.lstClassCodesRow FindByClassCodeID(short ClassCodeID)
    {
      return (dsAdminRatingClasses.lstClassCodesRow) this.Rows.Find(new object[1]
      {
        (object) ClassCodeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminRatingClasses.lstClassCodesDataTable classCodesDataTable = (dsAdminRatingClasses.lstClassCodesDataTable) base.Clone();
      classCodesDataTable.InitVars();
      return (DataTable) classCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminRatingClasses.lstClassCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnClassCodeID = this.Columns["ClassCodeID"];
      this.columnClassCode = this.Columns["ClassCode"];
      this.columnClassCodeDescription = this.Columns["ClassCodeDescription"];
      this.columnSIC_Code = this.Columns["SIC_Code"];
      this.columnWCClassCode = this.Columns["WCClassCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnClassCodeID = new DataColumn("ClassCodeID", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeID);
      this.columnClassCode = new DataColumn("ClassCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCode);
      this.columnClassCodeDescription = new DataColumn("ClassCodeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeDescription);
      this.columnSIC_Code = new DataColumn("SIC_Code", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIC_Code);
      this.columnWCClassCode = new DataColumn("WCClassCode", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWCClassCode);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdminRatingClassesKey3", new DataColumn[1]
      {
        this.columnClassCodeID
      }, true));
      this.columnClassCodeID.AutoIncrement = true;
      this.columnClassCodeID.AllowDBNull = false;
      this.columnClassCodeID.ReadOnly = true;
      this.columnClassCodeID.Unique = true;
      this.columnWCClassCode.AllowDBNull = false;
      this.columnWCClassCode.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminRatingClasses.lstClassCodesRow NewlstClassCodesRow()
    {
      return (dsAdminRatingClasses.lstClassCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminRatingClasses.lstClassCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminRatingClasses.lstClassCodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRatingClasses.lstClassCodesRowChangeEventHandler codesRowChangedEvent = this.lstClassCodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsAdminRatingClasses.lstClassCodesRowChangeEvent((dsAdminRatingClasses.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRatingClasses.lstClassCodesRowChangeEventHandler rowChangingEvent = this.lstClassCodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminRatingClasses.lstClassCodesRowChangeEvent((dsAdminRatingClasses.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRatingClasses.lstClassCodesRowChangeEventHandler codesRowDeletedEvent = this.lstClassCodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsAdminRatingClasses.lstClassCodesRowChangeEvent((dsAdminRatingClasses.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminRatingClasses.lstClassCodesRowChangeEventHandler rowDeletingEvent = this.lstClassCodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminRatingClasses.lstClassCodesRowChangeEvent((dsAdminRatingClasses.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstClassCodesRow(dsAdminRatingClasses.lstClassCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminRatingClasses adminRatingClasses = new dsAdminRatingClasses();
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
        FixedValue = adminRatingClasses.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstClassCodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = adminRatingClasses.GetSchemaSerializable();
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

  public class lstSIC_CodesRow : DataRow
  {
    private dsAdminRatingClasses.lstSIC_CodesDataTable tablelstSIC_Codes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstSIC_CodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstSIC_Codes = (dsAdminRatingClasses.lstSIC_CodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string SIC_Code
    {
      get => Conversions.ToString(this[this.tablelstSIC_Codes.SIC_CodeColumn]);
      set => this[this.tablelstSIC_Codes.SIC_CodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string SIC_Description
    {
      get => Conversions.ToString(this[this.tablelstSIC_Codes.SIC_DescriptionColumn]);
      set => this[this.tablelstSIC_Codes.SIC_DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string SIC_Family_Description
    {
      get => Conversions.ToString(this[this.tablelstSIC_Codes.SIC_Family_DescriptionColumn]);
      set => this[this.tablelstSIC_Codes.SIC_Family_DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminRatingClasses.lstClassCodesRow[] GetlstClassCodesRows()
    {
      return this.Table.ChildRelations["lstSIC_CodeslstClassCodes"] != null ? (dsAdminRatingClasses.lstClassCodesRow[]) this.GetChildRows(this.Table.ChildRelations["lstSIC_CodeslstClassCodes"]) : new dsAdminRatingClasses.lstClassCodesRow[0];
    }
  }

  public class lstClassCodesRow : DataRow
  {
    private dsAdminRatingClasses.lstClassCodesDataTable tablelstClassCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstClassCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstClassCodes = (dsAdminRatingClasses.lstClassCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public short ClassCodeID
    {
      get => Conversions.ToShort(this[this.tablelstClassCodes.ClassCodeIDColumn]);
      set => this[this.tablelstClassCodes.ClassCodeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ClassCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstClassCodes.ClassCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClassCode' in table 'lstClassCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstClassCodes.ClassCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ClassCodeDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstClassCodes.ClassCodeDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClassCodeDescription' in table 'lstClassCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstClassCodes.ClassCodeDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string SIC_Code
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstClassCodes.SIC_CodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SIC_Code' in table 'lstClassCodes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstClassCodes.SIC_CodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool WCClassCode
    {
      get => Conversions.ToBoolean(this[this.tablelstClassCodes.WCClassCodeColumn]);
      set => this[this.tablelstClassCodes.WCClassCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminRatingClasses.lstSIC_CodesRow lstSIC_CodesRow
    {
      get
      {
        return (dsAdminRatingClasses.lstSIC_CodesRow) this.GetParentRow(this.Table.ParentRelations["lstSIC_CodeslstClassCodes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstSIC_CodeslstClassCodes"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClassCodeNull() => this.IsNull(this.tablelstClassCodes.ClassCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClassCodeNull()
    {
      this[this.tablelstClassCodes.ClassCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClassCodeDescriptionNull()
    {
      return this.IsNull(this.tablelstClassCodes.ClassCodeDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClassCodeDescriptionNull()
    {
      this[this.tablelstClassCodes.ClassCodeDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSIC_CodeNull() => this.IsNull(this.tablelstClassCodes.SIC_CodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSIC_CodeNull()
    {
      this[this.tablelstClassCodes.SIC_CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstSIC_CodesRowChangeEvent : EventArgs
  {
    private dsAdminRatingClasses.lstSIC_CodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstSIC_CodesRowChangeEvent(
      dsAdminRatingClasses.lstSIC_CodesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminRatingClasses.lstSIC_CodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstClassCodesRowChangeEvent : EventArgs
  {
    private dsAdminRatingClasses.lstClassCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstClassCodesRowChangeEvent(
      dsAdminRatingClasses.lstClassCodesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminRatingClasses.lstClassCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
