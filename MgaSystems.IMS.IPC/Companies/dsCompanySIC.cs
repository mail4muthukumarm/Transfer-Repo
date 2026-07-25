// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.dsCompanySIC
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCompanySIC")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanySIC : DataSet
{
  private dsCompanySIC.lstAccessDataTable tablelstAccess;
  private dsCompanySIC.lstSIC_CodesDataTable tablelstSIC_Codes;
  private dsCompanySIC.tblCompany_SICDataTable tabletblCompany_SIC;
  private DataRelation relationlstSIC_CodestblCompany_SIC;
  private DataRelation relationlstAccesstblCompany_SIC;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsCompanySIC()
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
  protected dsCompanySIC(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstAccess)] != null)
          base.Tables.Add((DataTable) new dsCompanySIC.lstAccessDataTable(dataSet.Tables[nameof (lstAccess)]));
        if (dataSet.Tables[nameof (lstSIC_Codes)] != null)
          base.Tables.Add((DataTable) new dsCompanySIC.lstSIC_CodesDataTable(dataSet.Tables[nameof (lstSIC_Codes)]));
        if (dataSet.Tables[nameof (tblCompany_SIC)] != null)
          base.Tables.Add((DataTable) new dsCompanySIC.tblCompany_SICDataTable(dataSet.Tables[nameof (tblCompany_SIC)]));
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
  public dsCompanySIC.lstAccessDataTable lstAccess => this.tablelstAccess;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanySIC.lstSIC_CodesDataTable lstSIC_Codes => this.tablelstSIC_Codes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanySIC.tblCompany_SICDataTable tblCompany_SIC => this.tabletblCompany_SIC;

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
    dsCompanySIC dsCompanySic = (dsCompanySIC) base.Clone();
    dsCompanySic.InitVars();
    dsCompanySic.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsCompanySic;
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
      if (dataSet.Tables["lstAccess"] != null)
        base.Tables.Add((DataTable) new dsCompanySIC.lstAccessDataTable(dataSet.Tables["lstAccess"]));
      if (dataSet.Tables["lstSIC_Codes"] != null)
        base.Tables.Add((DataTable) new dsCompanySIC.lstSIC_CodesDataTable(dataSet.Tables["lstSIC_Codes"]));
      if (dataSet.Tables["tblCompany_SIC"] != null)
        base.Tables.Add((DataTable) new dsCompanySIC.tblCompany_SICDataTable(dataSet.Tables["tblCompany_SIC"]));
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
    this.tablelstAccess = (dsCompanySIC.lstAccessDataTable) base.Tables["lstAccess"];
    if (initTable && this.tablelstAccess != null)
      this.tablelstAccess.InitVars();
    this.tablelstSIC_Codes = (dsCompanySIC.lstSIC_CodesDataTable) base.Tables["lstSIC_Codes"];
    if (initTable && this.tablelstSIC_Codes != null)
      this.tablelstSIC_Codes.InitVars();
    this.tabletblCompany_SIC = (dsCompanySIC.tblCompany_SICDataTable) base.Tables["tblCompany_SIC"];
    if (initTable && this.tabletblCompany_SIC != null)
      this.tabletblCompany_SIC.InitVars();
    this.relationlstSIC_CodestblCompany_SIC = this.Relations["lstSIC_CodestblCompany_SIC"];
    this.relationlstAccesstblCompany_SIC = this.Relations["lstAccesstblCompany_SIC"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanySIC);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCompanySIC.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstAccess = new dsCompanySIC.lstAccessDataTable();
    base.Tables.Add((DataTable) this.tablelstAccess);
    this.tablelstSIC_Codes = new dsCompanySIC.lstSIC_CodesDataTable();
    base.Tables.Add((DataTable) this.tablelstSIC_Codes);
    this.tabletblCompany_SIC = new dsCompanySIC.tblCompany_SICDataTable();
    base.Tables.Add((DataTable) this.tabletblCompany_SIC);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("lstSIC_CodestblCompany_SIC", new DataColumn[1]
    {
      this.tablelstSIC_Codes.SIC_CodeColumn
    }, new DataColumn[1]
    {
      this.tabletblCompany_SIC.SIC_CodeColumn
    });
    this.tabletblCompany_SIC.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstAccesstblCompany_SIC", new DataColumn[1]
    {
      this.tablelstAccess.AccessColumn
    }, new DataColumn[1]
    {
      this.tabletblCompany_SIC.AccessColumn
    });
    this.tabletblCompany_SIC.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    this.relationlstSIC_CodestblCompany_SIC = new DataRelation("lstSIC_CodestblCompany_SIC", new DataColumn[1]
    {
      this.tablelstSIC_Codes.SIC_CodeColumn
    }, new DataColumn[1]
    {
      this.tabletblCompany_SIC.SIC_CodeColumn
    }, false);
    this.Relations.Add(this.relationlstSIC_CodestblCompany_SIC);
    this.relationlstAccesstblCompany_SIC = new DataRelation("lstAccesstblCompany_SIC", new DataColumn[1]
    {
      this.tablelstAccess.AccessColumn
    }, new DataColumn[1]
    {
      this.tabletblCompany_SIC.AccessColumn
    }, false);
    this.Relations.Add(this.relationlstAccesstblCompany_SIC);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstAccess() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstSIC_Codes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompany_SIC() => false;

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
    dsCompanySIC dsCompanySic = new dsCompanySIC();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsCompanySic.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsCompanySic.GetSchemaSerializable();
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
  public delegate void lstAccessRowChangeEventHandler(
    object sender,
    dsCompanySIC.lstAccessRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstSIC_CodesRowChangeEventHandler(
    object sender,
    dsCompanySIC.lstSIC_CodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblCompany_SICRowChangeEventHandler(
    object sender,
    dsCompanySIC.tblCompany_SICRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstAccessDataTable : TypedTableBase<dsCompanySIC.lstAccessRow>
  {
    private DataColumn columnAccess;
    private DataColumn columnAccessDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstAccessDataTable()
    {
      this.TableName = "lstAccess";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstAccessDataTable(DataTable table)
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
    protected lstAccessDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AccessColumn => this.columnAccess;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AccessDescriptionColumn => this.columnAccessDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.lstAccessRow this[int index]
    {
      get => (dsCompanySIC.lstAccessRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanySIC.lstAccessRowChangeEventHandler lstAccessRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanySIC.lstAccessRowChangeEventHandler lstAccessRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanySIC.lstAccessRowChangeEventHandler lstAccessRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanySIC.lstAccessRowChangeEventHandler lstAccessRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstAccessRow(dsCompanySIC.lstAccessRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.lstAccessRow AddlstAccessRow(string Access, string AccessDescription)
    {
      dsCompanySIC.lstAccessRow row = (dsCompanySIC.lstAccessRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Access,
        (object) AccessDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.lstAccessRow FindByAccess(string Access)
    {
      return (dsCompanySIC.lstAccessRow) this.Rows.Find(new object[1]
      {
        (object) Access
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanySIC.lstAccessDataTable lstAccessDataTable = (dsCompanySIC.lstAccessDataTable) base.Clone();
      lstAccessDataTable.InitVars();
      return (DataTable) lstAccessDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanySIC.lstAccessDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnAccess = this.Columns["Access"];
      this.columnAccessDescription = this.Columns["AccessDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnAccess = new DataColumn("Access", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccess);
      this.columnAccessDescription = new DataColumn("AccessDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccessDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnAccess
      }, true));
      this.columnAccess.AllowDBNull = false;
      this.columnAccess.Unique = true;
      this.columnAccessDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.lstAccessRow NewlstAccessRow() => (dsCompanySIC.lstAccessRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanySIC.lstAccessRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanySIC.lstAccessRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAccessRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanySIC.lstAccessRowChangeEventHandler accessRowChangedEvent = this.lstAccessRowChangedEvent;
      if (accessRowChangedEvent == null)
        return;
      accessRowChangedEvent((object) this, new dsCompanySIC.lstAccessRowChangeEvent((dsCompanySIC.lstAccessRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAccessRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanySIC.lstAccessRowChangeEventHandler rowChangingEvent = this.lstAccessRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanySIC.lstAccessRowChangeEvent((dsCompanySIC.lstAccessRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAccessRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanySIC.lstAccessRowChangeEventHandler accessRowDeletedEvent = this.lstAccessRowDeletedEvent;
      if (accessRowDeletedEvent == null)
        return;
      accessRowDeletedEvent((object) this, new dsCompanySIC.lstAccessRowChangeEvent((dsCompanySIC.lstAccessRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAccessRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanySIC.lstAccessRowChangeEventHandler rowDeletingEvent = this.lstAccessRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanySIC.lstAccessRowChangeEvent((dsCompanySIC.lstAccessRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstAccessRow(dsCompanySIC.lstAccessRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanySIC dsCompanySic = new dsCompanySIC();
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
        FixedValue = dsCompanySic.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstAccessDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanySic.GetSchemaSerializable();
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
  public class lstSIC_CodesDataTable : TypedTableBase<dsCompanySIC.lstSIC_CodesRow>
  {
    private DataColumn columnSIC_Code;
    private DataColumn columnSIC_Family_Description;
    private DataColumn columnSIC_Description;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstSIC_CodesDataTable()
    {
      this.TableName = "lstSIC_Codes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected lstSIC_CodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SIC_CodeColumn => this.columnSIC_Code;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SIC_Family_DescriptionColumn => this.columnSIC_Family_Description;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SIC_DescriptionColumn => this.columnSIC_Description;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.lstSIC_CodesRow this[int index]
    {
      get => (dsCompanySIC.lstSIC_CodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanySIC.lstSIC_CodesRowChangeEventHandler lstSIC_CodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanySIC.lstSIC_CodesRowChangeEventHandler lstSIC_CodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanySIC.lstSIC_CodesRowChangeEventHandler lstSIC_CodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanySIC.lstSIC_CodesRowChangeEventHandler lstSIC_CodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstSIC_CodesRow(dsCompanySIC.lstSIC_CodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.lstSIC_CodesRow AddlstSIC_CodesRow(
      string SIC_Code,
      string SIC_Family_Description,
      string SIC_Description)
    {
      dsCompanySIC.lstSIC_CodesRow row = (dsCompanySIC.lstSIC_CodesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) SIC_Code,
        (object) SIC_Family_Description,
        (object) SIC_Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.lstSIC_CodesRow FindBySIC_Code(string SIC_Code)
    {
      return (dsCompanySIC.lstSIC_CodesRow) this.Rows.Find(new object[1]
      {
        (object) SIC_Code
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanySIC.lstSIC_CodesDataTable sicCodesDataTable = (dsCompanySIC.lstSIC_CodesDataTable) base.Clone();
      sicCodesDataTable.InitVars();
      return (DataTable) sicCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanySIC.lstSIC_CodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnSIC_Code = this.Columns["SIC_Code"];
      this.columnSIC_Family_Description = this.Columns["SIC_Family_Description"];
      this.columnSIC_Description = this.Columns["SIC_Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnSIC_Code = new DataColumn("SIC_Code", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIC_Code);
      this.columnSIC_Family_Description = new DataColumn("SIC_Family_Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIC_Family_Description);
      this.columnSIC_Description = new DataColumn("SIC_Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIC_Description);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanySICKey1", new DataColumn[1]
      {
        this.columnSIC_Code
      }, true));
      this.columnSIC_Code.AllowDBNull = false;
      this.columnSIC_Code.Unique = true;
      this.columnSIC_Family_Description.AllowDBNull = false;
      this.columnSIC_Description.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.lstSIC_CodesRow NewlstSIC_CodesRow()
    {
      return (dsCompanySIC.lstSIC_CodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanySIC.lstSIC_CodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanySIC.lstSIC_CodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSIC_CodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanySIC.lstSIC_CodesRowChangeEventHandler codesRowChangedEvent = this.lstSIC_CodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsCompanySIC.lstSIC_CodesRowChangeEvent((dsCompanySIC.lstSIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSIC_CodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanySIC.lstSIC_CodesRowChangeEventHandler rowChangingEvent = this.lstSIC_CodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanySIC.lstSIC_CodesRowChangeEvent((dsCompanySIC.lstSIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSIC_CodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanySIC.lstSIC_CodesRowChangeEventHandler codesRowDeletedEvent = this.lstSIC_CodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsCompanySIC.lstSIC_CodesRowChangeEvent((dsCompanySIC.lstSIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSIC_CodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanySIC.lstSIC_CodesRowChangeEventHandler rowDeletingEvent = this.lstSIC_CodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanySIC.lstSIC_CodesRowChangeEvent((dsCompanySIC.lstSIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstSIC_CodesRow(dsCompanySIC.lstSIC_CodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanySIC dsCompanySic = new dsCompanySIC();
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
        FixedValue = dsCompanySic.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstSIC_CodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanySic.GetSchemaSerializable();
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
  public class tblCompany_SICDataTable : TypedTableBase<dsCompanySIC.tblCompany_SICRow>
  {
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnSIC_Code;
    private DataColumn columnAccess;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompany_SICDataTable()
    {
      this.TableName = "tblCompany_SIC";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompany_SICDataTable(DataTable table)
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
    protected tblCompany_SICDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SIC_CodeColumn => this.columnSIC_Code;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AccessColumn => this.columnAccess;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.tblCompany_SICRow this[int index]
    {
      get => (dsCompanySIC.tblCompany_SICRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanySIC.tblCompany_SICRowChangeEventHandler tblCompany_SICRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanySIC.tblCompany_SICRowChangeEventHandler tblCompany_SICRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanySIC.tblCompany_SICRowChangeEventHandler tblCompany_SICRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanySIC.tblCompany_SICRowChangeEventHandler tblCompany_SICRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompany_SICRow(dsCompanySIC.tblCompany_SICRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.tblCompany_SICRow AddtblCompany_SICRow(
      Guid CompanyLineGuid,
      dsCompanySIC.lstSIC_CodesRow parentlstSIC_CodesRowBylstSIC_CodestblCompany_SIC,
      dsCompanySIC.lstAccessRow parentlstAccessRowBylstAccesstblCompany_SIC)
    {
      dsCompanySIC.tblCompany_SICRow row = (dsCompanySIC.tblCompany_SICRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) CompanyLineGuid,
        null,
        null
      };
      if (parentlstSIC_CodesRowBylstSIC_CodestblCompany_SIC != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstSIC_CodesRowBylstSIC_CodestblCompany_SIC[0]);
      if (parentlstAccessRowBylstAccesstblCompany_SIC != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parentlstAccessRowBylstAccesstblCompany_SIC[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.tblCompany_SICRow FindByCompanyLineGuidSIC_Code(
      Guid CompanyLineGuid,
      string SIC_Code)
    {
      return (dsCompanySIC.tblCompany_SICRow) this.Rows.Find(new object[2]
      {
        (object) CompanyLineGuid,
        (object) SIC_Code
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanySIC.tblCompany_SICDataTable companySicDataTable = (dsCompanySIC.tblCompany_SICDataTable) base.Clone();
      companySicDataTable.InitVars();
      return (DataTable) companySicDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanySIC.tblCompany_SICDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnSIC_Code = this.Columns["SIC_Code"];
      this.columnAccess = this.Columns["Access"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnSIC_Code = new DataColumn("SIC_Code", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIC_Code);
      this.columnAccess = new DataColumn("Access", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccess);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanySICKey2", new DataColumn[2]
      {
        this.columnCompanyLineGuid,
        this.columnSIC_Code
      }, true));
      this.columnCompanyLineGuid.AllowDBNull = false;
      this.columnSIC_Code.AllowDBNull = false;
      this.columnAccess.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.tblCompany_SICRow NewtblCompany_SICRow()
    {
      return (dsCompanySIC.tblCompany_SICRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanySIC.tblCompany_SICRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanySIC.tblCompany_SICRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompany_SICRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanySIC.tblCompany_SICRowChangeEventHandler sicRowChangedEvent = this.tblCompany_SICRowChangedEvent;
      if (sicRowChangedEvent == null)
        return;
      sicRowChangedEvent((object) this, new dsCompanySIC.tblCompany_SICRowChangeEvent((dsCompanySIC.tblCompany_SICRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompany_SICRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanySIC.tblCompany_SICRowChangeEventHandler rowChangingEvent = this.tblCompany_SICRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanySIC.tblCompany_SICRowChangeEvent((dsCompanySIC.tblCompany_SICRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompany_SICRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanySIC.tblCompany_SICRowChangeEventHandler sicRowDeletedEvent = this.tblCompany_SICRowDeletedEvent;
      if (sicRowDeletedEvent == null)
        return;
      sicRowDeletedEvent((object) this, new dsCompanySIC.tblCompany_SICRowChangeEvent((dsCompanySIC.tblCompany_SICRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompany_SICRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanySIC.tblCompany_SICRowChangeEventHandler rowDeletingEvent = this.tblCompany_SICRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanySIC.tblCompany_SICRowChangeEvent((dsCompanySIC.tblCompany_SICRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompany_SICRow(dsCompanySIC.tblCompany_SICRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanySIC dsCompanySic = new dsCompanySIC();
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
        FixedValue = dsCompanySic.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompany_SICDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompanySic.GetSchemaSerializable();
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

  public class lstAccessRow : DataRow
  {
    private dsCompanySIC.lstAccessDataTable tablelstAccess;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstAccessRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstAccess = (dsCompanySIC.lstAccessDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Access
    {
      get => Conversions.ToString(this[this.tablelstAccess.AccessColumn]);
      set => this[this.tablelstAccess.AccessColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AccessDescription
    {
      get => Conversions.ToString(this[this.tablelstAccess.AccessDescriptionColumn]);
      set => this[this.tablelstAccess.AccessDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.tblCompany_SICRow[] GettblCompany_SICRows()
    {
      return this.Table.ChildRelations["lstAccesstblCompany_SIC"] != null ? (dsCompanySIC.tblCompany_SICRow[]) this.GetChildRows(this.Table.ChildRelations["lstAccesstblCompany_SIC"]) : new dsCompanySIC.tblCompany_SICRow[0];
    }
  }

  public class lstSIC_CodesRow : DataRow
  {
    private dsCompanySIC.lstSIC_CodesDataTable tablelstSIC_Codes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstSIC_CodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstSIC_Codes = (dsCompanySIC.lstSIC_CodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SIC_Code
    {
      get => Conversions.ToString(this[this.tablelstSIC_Codes.SIC_CodeColumn]);
      set => this[this.tablelstSIC_Codes.SIC_CodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SIC_Family_Description
    {
      get => Conversions.ToString(this[this.tablelstSIC_Codes.SIC_Family_DescriptionColumn]);
      set => this[this.tablelstSIC_Codes.SIC_Family_DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SIC_Description
    {
      get => Conversions.ToString(this[this.tablelstSIC_Codes.SIC_DescriptionColumn]);
      set => this[this.tablelstSIC_Codes.SIC_DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.tblCompany_SICRow[] GettblCompany_SICRows()
    {
      return this.Table.ChildRelations["lstSIC_CodestblCompany_SIC"] != null ? (dsCompanySIC.tblCompany_SICRow[]) this.GetChildRows(this.Table.ChildRelations["lstSIC_CodestblCompany_SIC"]) : new dsCompanySIC.tblCompany_SICRow[0];
    }
  }

  public class tblCompany_SICRow : DataRow
  {
    private dsCompanySIC.tblCompany_SICDataTable tabletblCompany_SIC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompany_SICRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompany_SIC = (dsCompanySIC.tblCompany_SICDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        object obj = this[this.tabletblCompany_SIC.CompanyLineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompany_SIC.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SIC_Code
    {
      get => Conversions.ToString(this[this.tabletblCompany_SIC.SIC_CodeColumn]);
      set => this[this.tabletblCompany_SIC.SIC_CodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Access
    {
      get => Conversions.ToString(this[this.tabletblCompany_SIC.AccessColumn]);
      set => this[this.tabletblCompany_SIC.AccessColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.lstSIC_CodesRow lstSIC_CodesRow
    {
      get
      {
        return (dsCompanySIC.lstSIC_CodesRow) this.GetParentRow(this.Table.ParentRelations["lstSIC_CodestblCompany_SIC"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstSIC_CodestblCompany_SIC"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.lstAccessRow lstAccessRow
    {
      get
      {
        return (dsCompanySIC.lstAccessRow) this.GetParentRow(this.Table.ParentRelations["lstAccesstblCompany_SIC"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstAccesstblCompany_SIC"]);
      }
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstAccessRowChangeEvent : EventArgs
  {
    private dsCompanySIC.lstAccessRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstAccessRowChangeEvent(dsCompanySIC.lstAccessRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.lstAccessRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstSIC_CodesRowChangeEvent : EventArgs
  {
    private dsCompanySIC.lstSIC_CodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstSIC_CodesRowChangeEvent(dsCompanySIC.lstSIC_CodesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.lstSIC_CodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompany_SICRowChangeEvent : EventArgs
  {
    private dsCompanySIC.tblCompany_SICRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompany_SICRowChangeEvent(dsCompanySIC.tblCompany_SICRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanySIC.tblCompany_SICRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
