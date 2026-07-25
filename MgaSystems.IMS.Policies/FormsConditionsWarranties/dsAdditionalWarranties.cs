// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormsConditionsWarranties.dsAdditionalWarranties
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
namespace MGASystems.IMS.Policies.FormsConditionsWarranties;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsAdditionalWarranties")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsAdditionalWarranties : DataSet
{
  private dsAdditionalWarranties.ItemTypesDataTable tableItemTypes;
  private dsAdditionalWarranties.tblAdditionalWarrantiesDataTable tabletblAdditionalWarranties;
  private dsAdditionalWarranties.lstAdditionalWarrantyStatusDataTable tablelstAdditionalWarrantyStatus;
  private DataRelation relationItemTypestblAdditionalWarranties1;
  private DataRelation relationlstAdditionalWarrantyStatus_tblAdditionalWarranties;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsAdditionalWarranties()
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
  protected dsAdditionalWarranties(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (ItemTypes)] != null)
          base.Tables.Add((DataTable) new dsAdditionalWarranties.ItemTypesDataTable(dataSet.Tables[nameof (ItemTypes)]));
        if (dataSet.Tables[nameof (tblAdditionalWarranties)] != null)
          base.Tables.Add((DataTable) new dsAdditionalWarranties.tblAdditionalWarrantiesDataTable(dataSet.Tables[nameof (tblAdditionalWarranties)]));
        if (dataSet.Tables[nameof (lstAdditionalWarrantyStatus)] != null)
          base.Tables.Add((DataTable) new dsAdditionalWarranties.lstAdditionalWarrantyStatusDataTable(dataSet.Tables[nameof (lstAdditionalWarrantyStatus)]));
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
  public dsAdditionalWarranties.ItemTypesDataTable ItemTypes => this.tableItemTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdditionalWarranties.tblAdditionalWarrantiesDataTable tblAdditionalWarranties
  {
    get => this.tabletblAdditionalWarranties;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdditionalWarranties.lstAdditionalWarrantyStatusDataTable lstAdditionalWarrantyStatus
  {
    get => this.tablelstAdditionalWarrantyStatus;
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
    dsAdditionalWarranties additionalWarranties = (dsAdditionalWarranties) base.Clone();
    additionalWarranties.InitVars();
    additionalWarranties.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) additionalWarranties;
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
      if (dataSet.Tables["ItemTypes"] != null)
        base.Tables.Add((DataTable) new dsAdditionalWarranties.ItemTypesDataTable(dataSet.Tables["ItemTypes"]));
      if (dataSet.Tables["tblAdditionalWarranties"] != null)
        base.Tables.Add((DataTable) new dsAdditionalWarranties.tblAdditionalWarrantiesDataTable(dataSet.Tables["tblAdditionalWarranties"]));
      if (dataSet.Tables["lstAdditionalWarrantyStatus"] != null)
        base.Tables.Add((DataTable) new dsAdditionalWarranties.lstAdditionalWarrantyStatusDataTable(dataSet.Tables["lstAdditionalWarrantyStatus"]));
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
    this.tableItemTypes = (dsAdditionalWarranties.ItemTypesDataTable) base.Tables["ItemTypes"];
    if (initTable && this.tableItemTypes != null)
      this.tableItemTypes.InitVars();
    this.tabletblAdditionalWarranties = (dsAdditionalWarranties.tblAdditionalWarrantiesDataTable) base.Tables["tblAdditionalWarranties"];
    if (initTable && this.tabletblAdditionalWarranties != null)
      this.tabletblAdditionalWarranties.InitVars();
    this.tablelstAdditionalWarrantyStatus = (dsAdditionalWarranties.lstAdditionalWarrantyStatusDataTable) base.Tables["lstAdditionalWarrantyStatus"];
    if (initTable && this.tablelstAdditionalWarrantyStatus != null)
      this.tablelstAdditionalWarrantyStatus.InitVars();
    this.relationItemTypestblAdditionalWarranties1 = this.Relations["ItemTypestblAdditionalWarranties1"];
    this.relationlstAdditionalWarrantyStatus_tblAdditionalWarranties = this.Relations["lstAdditionalWarrantyStatus_tblAdditionalWarranties"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsAdditionalWarranties);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsAdditionalWarranties.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableItemTypes = new dsAdditionalWarranties.ItemTypesDataTable();
    base.Tables.Add((DataTable) this.tableItemTypes);
    this.tabletblAdditionalWarranties = new dsAdditionalWarranties.tblAdditionalWarrantiesDataTable();
    base.Tables.Add((DataTable) this.tabletblAdditionalWarranties);
    this.tablelstAdditionalWarrantyStatus = new dsAdditionalWarranties.lstAdditionalWarrantyStatusDataTable();
    base.Tables.Add((DataTable) this.tablelstAdditionalWarrantyStatus);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("ItemTypestblAdditionalWarranties1", new DataColumn[1]
    {
      this.tableItemTypes.ItemTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdditionalWarranties.ItemTypeColumn
    });
    this.tabletblAdditionalWarranties.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationItemTypestblAdditionalWarranties1 = new DataRelation("ItemTypestblAdditionalWarranties1", new DataColumn[1]
    {
      this.tableItemTypes.ItemTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdditionalWarranties.ItemTypeColumn
    }, false);
    this.Relations.Add(this.relationItemTypestblAdditionalWarranties1);
    this.relationlstAdditionalWarrantyStatus_tblAdditionalWarranties = new DataRelation("lstAdditionalWarrantyStatus_tblAdditionalWarranties", new DataColumn[1]
    {
      this.tablelstAdditionalWarrantyStatus.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblAdditionalWarranties.StatusIDColumn
    }, false);
    this.Relations.Add(this.relationlstAdditionalWarrantyStatus_tblAdditionalWarranties);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeItemTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblAdditionalWarranties() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstAdditionalWarrantyStatus() => false;

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
    dsAdditionalWarranties additionalWarranties = new dsAdditionalWarranties();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = additionalWarranties.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = additionalWarranties.GetSchemaSerializable();
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
  public delegate void ItemTypesRowChangeEventHandler(
    object sender,
    dsAdditionalWarranties.ItemTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblAdditionalWarrantiesRowChangeEventHandler(
    object sender,
    dsAdditionalWarranties.tblAdditionalWarrantiesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstAdditionalWarrantyStatusRowChangeEventHandler(
    object sender,
    dsAdditionalWarranties.lstAdditionalWarrantyStatusRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class ItemTypesDataTable : TypedTableBase<dsAdditionalWarranties.ItemTypesRow>
  {
    private DataColumn columnItemTypeID;
    private DataColumn columnItemType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public ItemTypesDataTable()
    {
      this.TableName = "ItemTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal ItemTypesDataTable(DataTable table)
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
    protected ItemTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ItemTypeIDColumn => this.columnItemTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ItemTypeColumn => this.columnItemType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.ItemTypesRow this[int index]
    {
      get => (dsAdditionalWarranties.ItemTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdditionalWarranties.ItemTypesRowChangeEventHandler ItemTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdditionalWarranties.ItemTypesRowChangeEventHandler ItemTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdditionalWarranties.ItemTypesRowChangeEventHandler ItemTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdditionalWarranties.ItemTypesRowChangeEventHandler ItemTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddItemTypesRow(dsAdditionalWarranties.ItemTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.ItemTypesRow AddItemTypesRow(string ItemTypeID, string ItemType)
    {
      dsAdditionalWarranties.ItemTypesRow row = (dsAdditionalWarranties.ItemTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ItemTypeID,
        (object) ItemType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.ItemTypesRow FindByItemTypeID(string ItemTypeID)
    {
      return (dsAdditionalWarranties.ItemTypesRow) this.Rows.Find(new object[1]
      {
        (object) ItemTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalWarranties.ItemTypesDataTable itemTypesDataTable = (dsAdditionalWarranties.ItemTypesDataTable) base.Clone();
      itemTypesDataTable.InitVars();
      return (DataTable) itemTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalWarranties.ItemTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnItemTypeID = this.Columns["ItemTypeID"];
      this.columnItemType = this.Columns["ItemType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnItemTypeID = new DataColumn("ItemTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnItemTypeID);
      this.columnItemType = new DataColumn("ItemType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnItemType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdditionalWarrantiesKey1", new DataColumn[1]
      {
        this.columnItemTypeID
      }, true));
      this.columnItemTypeID.AllowDBNull = false;
      this.columnItemTypeID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.ItemTypesRow NewItemTypesRow()
    {
      return (dsAdditionalWarranties.ItemTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalWarranties.ItemTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdditionalWarranties.ItemTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ItemTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalWarranties.ItemTypesRowChangeEventHandler typesRowChangedEvent = this.ItemTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsAdditionalWarranties.ItemTypesRowChangeEvent((dsAdditionalWarranties.ItemTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ItemTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalWarranties.ItemTypesRowChangeEventHandler rowChangingEvent = this.ItemTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalWarranties.ItemTypesRowChangeEvent((dsAdditionalWarranties.ItemTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ItemTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalWarranties.ItemTypesRowChangeEventHandler typesRowDeletedEvent = this.ItemTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsAdditionalWarranties.ItemTypesRowChangeEvent((dsAdditionalWarranties.ItemTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ItemTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalWarranties.ItemTypesRowChangeEventHandler rowDeletingEvent = this.ItemTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalWarranties.ItemTypesRowChangeEvent((dsAdditionalWarranties.ItemTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveItemTypesRow(dsAdditionalWarranties.ItemTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalWarranties additionalWarranties = new dsAdditionalWarranties();
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
        FixedValue = additionalWarranties.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ItemTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalWarranties.GetSchemaSerializable();
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
  public class tblAdditionalWarrantiesDataTable : 
    TypedTableBase<dsAdditionalWarranties.tblAdditionalWarrantiesRow>
  {
    private DataColumn columnAdditionalWarrantyID;
    private DataColumn columnQuoteID;
    private DataColumn columnConditionWarranty;
    private DataColumn columnItemType;
    private DataColumn columnDateAdded;
    private DataColumn columnAddedByUserGuid;
    private DataColumn columnModifiedByUserGuid;
    private DataColumn columnDateModified;
    private DataColumn columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblAdditionalWarrantiesDataTable()
    {
      this.TableName = "tblAdditionalWarranties";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblAdditionalWarrantiesDataTable(DataTable table)
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
    protected tblAdditionalWarrantiesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AdditionalWarrantyIDColumn => this.columnAdditionalWarrantyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ConditionWarrantyColumn => this.columnConditionWarranty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ItemTypeColumn => this.columnItemType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateAddedColumn => this.columnDateAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AddedByUserGuidColumn => this.columnAddedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ModifiedByUserGuidColumn => this.columnModifiedByUserGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateModifiedColumn => this.columnDateModified;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.tblAdditionalWarrantiesRow this[int index]
    {
      get => (dsAdditionalWarranties.tblAdditionalWarrantiesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdditionalWarranties.tblAdditionalWarrantiesRowChangeEventHandler tblAdditionalWarrantiesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdditionalWarranties.tblAdditionalWarrantiesRowChangeEventHandler tblAdditionalWarrantiesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdditionalWarranties.tblAdditionalWarrantiesRowChangeEventHandler tblAdditionalWarrantiesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdditionalWarranties.tblAdditionalWarrantiesRowChangeEventHandler tblAdditionalWarrantiesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblAdditionalWarrantiesRow(
      dsAdditionalWarranties.tblAdditionalWarrantiesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.tblAdditionalWarrantiesRow AddtblAdditionalWarrantiesRow(
      int QuoteID,
      string ConditionWarranty,
      dsAdditionalWarranties.ItemTypesRow parentItemTypesRowByItemTypestblAdditionalWarranties1,
      DateTime DateAdded,
      Guid AddedByUserGuid,
      Guid ModifiedByUserGuid,
      DateTime DateModified,
      dsAdditionalWarranties.lstAdditionalWarrantyStatusRow parentlstAdditionalWarrantyStatusRowBylstAdditionalWarrantyStatus_tblAdditionalWarranties)
    {
      dsAdditionalWarranties.tblAdditionalWarrantiesRow row = (dsAdditionalWarranties.tblAdditionalWarrantiesRow) this.NewRow();
      object[] objArray = new object[9]
      {
        null,
        (object) QuoteID,
        (object) ConditionWarranty,
        null,
        (object) DateAdded,
        (object) AddedByUserGuid,
        (object) ModifiedByUserGuid,
        (object) DateModified,
        null
      };
      if (parentItemTypesRowByItemTypestblAdditionalWarranties1 != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parentItemTypesRowByItemTypestblAdditionalWarranties1[0]);
      if (parentlstAdditionalWarrantyStatusRowBylstAdditionalWarrantyStatus_tblAdditionalWarranties != null)
        objArray[8] = RuntimeHelpers.GetObjectValue(parentlstAdditionalWarrantyStatusRowBylstAdditionalWarrantyStatus_tblAdditionalWarranties[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.tblAdditionalWarrantiesRow FindByAdditionalWarrantyID(
      int AdditionalWarrantyID)
    {
      return (dsAdditionalWarranties.tblAdditionalWarrantiesRow) this.Rows.Find(new object[1]
      {
        (object) AdditionalWarrantyID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalWarranties.tblAdditionalWarrantiesDataTable warrantiesDataTable = (dsAdditionalWarranties.tblAdditionalWarrantiesDataTable) base.Clone();
      warrantiesDataTable.InitVars();
      return (DataTable) warrantiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalWarranties.tblAdditionalWarrantiesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnAdditionalWarrantyID = this.Columns["AdditionalWarrantyID"];
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnConditionWarranty = this.Columns["ConditionWarranty"];
      this.columnItemType = this.Columns["ItemType"];
      this.columnDateAdded = this.Columns["DateAdded"];
      this.columnAddedByUserGuid = this.Columns["AddedByUserGuid"];
      this.columnModifiedByUserGuid = this.Columns["ModifiedByUserGuid"];
      this.columnDateModified = this.Columns["DateModified"];
      this.columnStatusID = this.Columns["StatusID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnAdditionalWarrantyID = new DataColumn("AdditionalWarrantyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalWarrantyID);
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnConditionWarranty = new DataColumn("ConditionWarranty", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConditionWarranty);
      this.columnItemType = new DataColumn("ItemType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnItemType);
      this.columnDateAdded = new DataColumn("DateAdded", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateAdded);
      this.columnAddedByUserGuid = new DataColumn("AddedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddedByUserGuid);
      this.columnModifiedByUserGuid = new DataColumn("ModifiedByUserGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModifiedByUserGuid);
      this.columnDateModified = new DataColumn("DateModified", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateModified);
      this.columnStatusID = new DataColumn("StatusID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdditionalWarrantiesKey2", new DataColumn[1]
      {
        this.columnAdditionalWarrantyID
      }, true));
      this.columnAdditionalWarrantyID.AutoIncrement = true;
      this.columnAdditionalWarrantyID.AutoIncrementSeed = -1L;
      this.columnAdditionalWarrantyID.AutoIncrementStep = -1L;
      this.columnAdditionalWarrantyID.AllowDBNull = false;
      this.columnAdditionalWarrantyID.ReadOnly = true;
      this.columnAdditionalWarrantyID.Unique = true;
      this.columnQuoteID.AllowDBNull = false;
      this.columnConditionWarranty.AllowDBNull = false;
      this.columnItemType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.tblAdditionalWarrantiesRow NewtblAdditionalWarrantiesRow()
    {
      return (dsAdditionalWarranties.tblAdditionalWarrantiesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalWarranties.tblAdditionalWarrantiesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAdditionalWarranties.tblAdditionalWarrantiesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdditionalWarrantiesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalWarranties.tblAdditionalWarrantiesRowChangeEventHandler warrantiesRowChangedEvent = this.tblAdditionalWarrantiesRowChangedEvent;
      if (warrantiesRowChangedEvent == null)
        return;
      warrantiesRowChangedEvent((object) this, new dsAdditionalWarranties.tblAdditionalWarrantiesRowChangeEvent((dsAdditionalWarranties.tblAdditionalWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdditionalWarrantiesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalWarranties.tblAdditionalWarrantiesRowChangeEventHandler rowChangingEvent = this.tblAdditionalWarrantiesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalWarranties.tblAdditionalWarrantiesRowChangeEvent((dsAdditionalWarranties.tblAdditionalWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdditionalWarrantiesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalWarranties.tblAdditionalWarrantiesRowChangeEventHandler warrantiesRowDeletedEvent = this.tblAdditionalWarrantiesRowDeletedEvent;
      if (warrantiesRowDeletedEvent == null)
        return;
      warrantiesRowDeletedEvent((object) this, new dsAdditionalWarranties.tblAdditionalWarrantiesRowChangeEvent((dsAdditionalWarranties.tblAdditionalWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblAdditionalWarrantiesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalWarranties.tblAdditionalWarrantiesRowChangeEventHandler rowDeletingEvent = this.tblAdditionalWarrantiesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalWarranties.tblAdditionalWarrantiesRowChangeEvent((dsAdditionalWarranties.tblAdditionalWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblAdditionalWarrantiesRow(
      dsAdditionalWarranties.tblAdditionalWarrantiesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalWarranties additionalWarranties = new dsAdditionalWarranties();
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
        FixedValue = additionalWarranties.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblAdditionalWarrantiesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalWarranties.GetSchemaSerializable();
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
  public class lstAdditionalWarrantyStatusDataTable : 
    TypedTableBase<dsAdditionalWarranties.lstAdditionalWarrantyStatusRow>
  {
    private DataColumn columnID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstAdditionalWarrantyStatusDataTable()
    {
      this.TableName = "lstAdditionalWarrantyStatus";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstAdditionalWarrantyStatusDataTable(DataTable table)
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
    protected lstAdditionalWarrantyStatusDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.lstAdditionalWarrantyStatusRow this[int index]
    {
      get => (dsAdditionalWarranties.lstAdditionalWarrantyStatusRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdditionalWarranties.lstAdditionalWarrantyStatusRowChangeEventHandler lstAdditionalWarrantyStatusRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdditionalWarranties.lstAdditionalWarrantyStatusRowChangeEventHandler lstAdditionalWarrantyStatusRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdditionalWarranties.lstAdditionalWarrantyStatusRowChangeEventHandler lstAdditionalWarrantyStatusRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdditionalWarranties.lstAdditionalWarrantyStatusRowChangeEventHandler lstAdditionalWarrantyStatusRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstAdditionalWarrantyStatusRow(
      dsAdditionalWarranties.lstAdditionalWarrantyStatusRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.lstAdditionalWarrantyStatusRow AddlstAdditionalWarrantyStatusRow(
      int ID,
      string Description)
    {
      dsAdditionalWarranties.lstAdditionalWarrantyStatusRow row = (dsAdditionalWarranties.lstAdditionalWarrantyStatusRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.lstAdditionalWarrantyStatusRow FindByID(int ID)
    {
      return (dsAdditionalWarranties.lstAdditionalWarrantyStatusRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalWarranties.lstAdditionalWarrantyStatusDataTable warrantyStatusDataTable = (dsAdditionalWarranties.lstAdditionalWarrantyStatusDataTable) base.Clone();
      warrantyStatusDataTable.InitVars();
      return (DataTable) warrantyStatusDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalWarranties.lstAdditionalWarrantyStatusDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAdditionalWarrantiesKey1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.lstAdditionalWarrantyStatusRow NewlstAdditionalWarrantyStatusRow()
    {
      return (dsAdditionalWarranties.lstAdditionalWarrantyStatusRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalWarranties.lstAdditionalWarrantyStatusRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAdditionalWarranties.lstAdditionalWarrantyStatusRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdditionalWarrantyStatusRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalWarranties.lstAdditionalWarrantyStatusRowChangeEventHandler statusRowChangedEvent = this.lstAdditionalWarrantyStatusRowChangedEvent;
      if (statusRowChangedEvent == null)
        return;
      statusRowChangedEvent((object) this, new dsAdditionalWarranties.lstAdditionalWarrantyStatusRowChangeEvent((dsAdditionalWarranties.lstAdditionalWarrantyStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdditionalWarrantyStatusRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalWarranties.lstAdditionalWarrantyStatusRowChangeEventHandler rowChangingEvent = this.lstAdditionalWarrantyStatusRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdditionalWarranties.lstAdditionalWarrantyStatusRowChangeEvent((dsAdditionalWarranties.lstAdditionalWarrantyStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdditionalWarrantyStatusRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalWarranties.lstAdditionalWarrantyStatusRowChangeEventHandler statusRowDeletedEvent = this.lstAdditionalWarrantyStatusRowDeletedEvent;
      if (statusRowDeletedEvent == null)
        return;
      statusRowDeletedEvent((object) this, new dsAdditionalWarranties.lstAdditionalWarrantyStatusRowChangeEvent((dsAdditionalWarranties.lstAdditionalWarrantyStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstAdditionalWarrantyStatusRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdditionalWarranties.lstAdditionalWarrantyStatusRowChangeEventHandler rowDeletingEvent = this.lstAdditionalWarrantyStatusRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdditionalWarranties.lstAdditionalWarrantyStatusRowChangeEvent((dsAdditionalWarranties.lstAdditionalWarrantyStatusRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstAdditionalWarrantyStatusRow(
      dsAdditionalWarranties.lstAdditionalWarrantyStatusRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalWarranties additionalWarranties = new dsAdditionalWarranties();
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
        FixedValue = additionalWarranties.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstAdditionalWarrantyStatusDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalWarranties.GetSchemaSerializable();
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

  public class ItemTypesRow : DataRow
  {
    private dsAdditionalWarranties.ItemTypesDataTable tableItemTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal ItemTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableItemTypes = (dsAdditionalWarranties.ItemTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ItemTypeID
    {
      get => Conversions.ToString(this[this.tableItemTypes.ItemTypeIDColumn]);
      set => this[this.tableItemTypes.ItemTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ItemType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableItemTypes.ItemTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ItemType' in table 'ItemTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableItemTypes.ItemTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsItemTypeNull() => this.IsNull(this.tableItemTypes.ItemTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetItemTypeNull()
    {
      this[this.tableItemTypes.ItemTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.tblAdditionalWarrantiesRow[] GettblAdditionalWarrantiesRows()
    {
      return this.Table.ChildRelations["ItemTypestblAdditionalWarranties1"] != null ? (dsAdditionalWarranties.tblAdditionalWarrantiesRow[]) this.GetChildRows(this.Table.ChildRelations["ItemTypestblAdditionalWarranties1"]) : new dsAdditionalWarranties.tblAdditionalWarrantiesRow[0];
    }
  }

  public class tblAdditionalWarrantiesRow : DataRow
  {
    private dsAdditionalWarranties.tblAdditionalWarrantiesDataTable tabletblAdditionalWarranties;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblAdditionalWarrantiesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblAdditionalWarranties = (dsAdditionalWarranties.tblAdditionalWarrantiesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int AdditionalWarrantyID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblAdditionalWarranties.AdditionalWarrantyIDColumn]);
      }
      set => this[this.tabletblAdditionalWarranties.AdditionalWarrantyIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tabletblAdditionalWarranties.QuoteIDColumn]);
      set => this[this.tabletblAdditionalWarranties.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ConditionWarranty
    {
      get => Conversions.ToString(this[this.tabletblAdditionalWarranties.ConditionWarrantyColumn]);
      set => this[this.tabletblAdditionalWarranties.ConditionWarrantyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ItemType
    {
      get => Conversions.ToString(this[this.tabletblAdditionalWarranties.ItemTypeColumn]);
      set => this[this.tabletblAdditionalWarranties.ItemTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateAdded
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdditionalWarranties.DateAddedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateAdded' in table 'tblAdditionalWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalWarranties.DateAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid AddedByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblAdditionalWarranties.AddedByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddedByUserGuid' in table 'tblAdditionalWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalWarranties.AddedByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid ModifiedByUserGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblAdditionalWarranties.ModifiedByUserGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ModifiedByUserGuid' in table 'tblAdditionalWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalWarranties.ModifiedByUserGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DateModified
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblAdditionalWarranties.DateModifiedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateModified' in table 'tblAdditionalWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalWarranties.DateModifiedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int StatusID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblAdditionalWarranties.StatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusID' in table 'tblAdditionalWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalWarranties.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.ItemTypesRow ItemTypesRow
    {
      get
      {
        return (dsAdditionalWarranties.ItemTypesRow) this.GetParentRow(this.Table.ParentRelations["ItemTypestblAdditionalWarranties1"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["ItemTypestblAdditionalWarranties1"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.lstAdditionalWarrantyStatusRow lstAdditionalWarrantyStatusRow
    {
      get
      {
        return (dsAdditionalWarranties.lstAdditionalWarrantyStatusRow) this.GetParentRow(this.Table.ParentRelations["lstAdditionalWarrantyStatus_tblAdditionalWarranties"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstAdditionalWarrantyStatus_tblAdditionalWarranties"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateAddedNull() => this.IsNull(this.tabletblAdditionalWarranties.DateAddedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateAddedNull()
    {
      this[this.tabletblAdditionalWarranties.DateAddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddedByUserGuidNull()
    {
      return this.IsNull(this.tabletblAdditionalWarranties.AddedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddedByUserGuidNull()
    {
      this[this.tabletblAdditionalWarranties.AddedByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsModifiedByUserGuidNull()
    {
      return this.IsNull(this.tabletblAdditionalWarranties.ModifiedByUserGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetModifiedByUserGuidNull()
    {
      this[this.tabletblAdditionalWarranties.ModifiedByUserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDateModifiedNull()
    {
      return this.IsNull(this.tabletblAdditionalWarranties.DateModifiedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDateModifiedNull()
    {
      this[this.tabletblAdditionalWarranties.DateModifiedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStatusIDNull() => this.IsNull(this.tabletblAdditionalWarranties.StatusIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatusIDNull()
    {
      this[this.tabletblAdditionalWarranties.StatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstAdditionalWarrantyStatusRow : DataRow
  {
    private dsAdditionalWarranties.lstAdditionalWarrantyStatusDataTable tablelstAdditionalWarrantyStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstAdditionalWarrantyStatusRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstAdditionalWarrantyStatus = (dsAdditionalWarranties.lstAdditionalWarrantyStatusDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstAdditionalWarrantyStatus.IDColumn]);
      set => this[this.tablelstAdditionalWarrantyStatus.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstAdditionalWarrantyStatus.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'lstAdditionalWarrantyStatus' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstAdditionalWarrantyStatus.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDescriptionNull()
    {
      return this.IsNull(this.tablelstAdditionalWarrantyStatus.DescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tablelstAdditionalWarrantyStatus.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.tblAdditionalWarrantiesRow[] GettblAdditionalWarrantiesRows()
    {
      return this.Table.ChildRelations["lstAdditionalWarrantyStatus_tblAdditionalWarranties"] != null ? (dsAdditionalWarranties.tblAdditionalWarrantiesRow[]) this.GetChildRows(this.Table.ChildRelations["lstAdditionalWarrantyStatus_tblAdditionalWarranties"]) : new dsAdditionalWarranties.tblAdditionalWarrantiesRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class ItemTypesRowChangeEvent : EventArgs
  {
    private dsAdditionalWarranties.ItemTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public ItemTypesRowChangeEvent(dsAdditionalWarranties.ItemTypesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.ItemTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblAdditionalWarrantiesRowChangeEvent : EventArgs
  {
    private dsAdditionalWarranties.tblAdditionalWarrantiesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblAdditionalWarrantiesRowChangeEvent(
      dsAdditionalWarranties.tblAdditionalWarrantiesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.tblAdditionalWarrantiesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstAdditionalWarrantyStatusRowChangeEvent : EventArgs
  {
    private dsAdditionalWarranties.lstAdditionalWarrantyStatusRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstAdditionalWarrantyStatusRowChangeEvent(
      dsAdditionalWarranties.lstAdditionalWarrantyStatusRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdditionalWarranties.lstAdditionalWarrantyStatusRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
