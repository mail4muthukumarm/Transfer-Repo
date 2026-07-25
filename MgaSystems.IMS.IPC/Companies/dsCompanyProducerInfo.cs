// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.dsCompanyProducerInfo
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
[XmlRoot("dsCompanyProducerInfo")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyProducerInfo : DataSet
{
  private dsCompanyProducerInfo.tblCompanyProducerInfoDataTable tabletblCompanyProducerInfo;
  private dsCompanyProducerInfo.tblProducerLocationsDataTable tabletblProducerLocations;
  private DataRelation relationtblProducerLocationstblCompanyProducerInfo;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsCompanyProducerInfo()
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
  protected dsCompanyProducerInfo(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyProducerInfo)] != null)
          base.Tables.Add((DataTable) new dsCompanyProducerInfo.tblCompanyProducerInfoDataTable(dataSet.Tables[nameof (tblCompanyProducerInfo)]));
        if (dataSet.Tables[nameof (tblProducerLocations)] != null)
          base.Tables.Add((DataTable) new dsCompanyProducerInfo.tblProducerLocationsDataTable(dataSet.Tables[nameof (tblProducerLocations)]));
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
  public dsCompanyProducerInfo.tblCompanyProducerInfoDataTable tblCompanyProducerInfo
  {
    get => this.tabletblCompanyProducerInfo;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyProducerInfo.tblProducerLocationsDataTable tblProducerLocations
  {
    get => this.tabletblProducerLocations;
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
    dsCompanyProducerInfo companyProducerInfo = (dsCompanyProducerInfo) base.Clone();
    companyProducerInfo.InitVars();
    companyProducerInfo.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) companyProducerInfo;
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
      if (dataSet.Tables["tblCompanyProducerInfo"] != null)
        base.Tables.Add((DataTable) new dsCompanyProducerInfo.tblCompanyProducerInfoDataTable(dataSet.Tables["tblCompanyProducerInfo"]));
      if (dataSet.Tables["tblProducerLocations"] != null)
        base.Tables.Add((DataTable) new dsCompanyProducerInfo.tblProducerLocationsDataTable(dataSet.Tables["tblProducerLocations"]));
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
    this.tabletblCompanyProducerInfo = (dsCompanyProducerInfo.tblCompanyProducerInfoDataTable) base.Tables["tblCompanyProducerInfo"];
    if (initTable && this.tabletblCompanyProducerInfo != null)
      this.tabletblCompanyProducerInfo.InitVars();
    this.tabletblProducerLocations = (dsCompanyProducerInfo.tblProducerLocationsDataTable) base.Tables["tblProducerLocations"];
    if (initTable && this.tabletblProducerLocations != null)
      this.tabletblProducerLocations.InitVars();
    this.relationtblProducerLocationstblCompanyProducerInfo = this.Relations["tblProducerLocationstblCompanyProducerInfo"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyProducerInfo);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCompanyProducerInfo.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyProducerInfo = new dsCompanyProducerInfo.tblCompanyProducerInfoDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyProducerInfo);
    this.tabletblProducerLocations = new dsCompanyProducerInfo.tblProducerLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblProducerLocations);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("tblProducerLocationstblCompanyProducerInfo", new DataColumn[1]
    {
      this.tabletblProducerLocations.ProducerLocationIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyProducerInfo.ProducerLocationIDColumn
    });
    this.tabletblCompanyProducerInfo.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationtblProducerLocationstblCompanyProducerInfo = new DataRelation("tblProducerLocationstblCompanyProducerInfo", new DataColumn[1]
    {
      this.tabletblProducerLocations.ProducerLocationIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyProducerInfo.ProducerLocationIDColumn
    }, false);
    this.Relations.Add(this.relationtblProducerLocationstblCompanyProducerInfo);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyProducerInfo() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblProducerLocations() => false;

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
    dsCompanyProducerInfo companyProducerInfo = new dsCompanyProducerInfo();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = companyProducerInfo.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = companyProducerInfo.GetSchemaSerializable();
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
  public delegate void tblCompanyProducerInfoRowChangeEventHandler(
    object sender,
    dsCompanyProducerInfo.tblCompanyProducerInfoRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblProducerLocationsRowChangeEventHandler(
    object sender,
    dsCompanyProducerInfo.tblProducerLocationsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyProducerInfoDataTable : 
    TypedTableBase<dsCompanyProducerInfo.tblCompanyProducerInfoRow>
  {
    private DataColumn columnCompanyID;
    private DataColumn columnProducerLocationID;
    private DataColumn columnBranchCode;
    private DataColumn columnProducerCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyProducerInfoDataTable()
    {
      this.TableName = "tblCompanyProducerInfo";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyProducerInfoDataTable(DataTable table)
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
    protected tblCompanyProducerInfoDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyIDColumn => this.columnCompanyID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerLocationIDColumn => this.columnProducerLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BranchCodeColumn => this.columnBranchCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerCodeColumn => this.columnProducerCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyProducerInfo.tblCompanyProducerInfoRow this[int index]
    {
      get => (dsCompanyProducerInfo.tblCompanyProducerInfoRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyProducerInfo.tblCompanyProducerInfoRowChangeEventHandler tblCompanyProducerInfoRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyProducerInfo.tblCompanyProducerInfoRowChangeEventHandler tblCompanyProducerInfoRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyProducerInfo.tblCompanyProducerInfoRowChangeEventHandler tblCompanyProducerInfoRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyProducerInfo.tblCompanyProducerInfoRowChangeEventHandler tblCompanyProducerInfoRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyProducerInfoRow(
      dsCompanyProducerInfo.tblCompanyProducerInfoRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyProducerInfo.tblCompanyProducerInfoRow AddtblCompanyProducerInfoRow(
      int CompanyID,
      dsCompanyProducerInfo.tblProducerLocationsRow parenttblProducerLocationsRowBytblProducerLocationstblCompanyProducerInfo,
      string BranchCode,
      string ProducerCode)
    {
      dsCompanyProducerInfo.tblCompanyProducerInfoRow row = (dsCompanyProducerInfo.tblCompanyProducerInfoRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) CompanyID,
        null,
        (object) BranchCode,
        (object) ProducerCode
      };
      if (parenttblProducerLocationsRowBytblProducerLocationstblCompanyProducerInfo != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblProducerLocationsRowBytblProducerLocationstblCompanyProducerInfo[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyProducerInfo.tblCompanyProducerInfoRow FindByCompanyIDProducerLocationID(
      int CompanyID,
      int ProducerLocationID)
    {
      return (dsCompanyProducerInfo.tblCompanyProducerInfoRow) this.Rows.Find(new object[2]
      {
        (object) CompanyID,
        (object) ProducerLocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyProducerInfo.tblCompanyProducerInfoDataTable producerInfoDataTable = (dsCompanyProducerInfo.tblCompanyProducerInfoDataTable) base.Clone();
      producerInfoDataTable.InitVars();
      return (DataTable) producerInfoDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyProducerInfo.tblCompanyProducerInfoDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyID = this.Columns["CompanyID"];
      this.columnProducerLocationID = this.Columns["ProducerLocationID"];
      this.columnBranchCode = this.Columns["BranchCode"];
      this.columnProducerCode = this.Columns["ProducerCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyID = new DataColumn("CompanyID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyID);
      this.columnProducerLocationID = new DataColumn("ProducerLocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationID);
      this.columnBranchCode = new DataColumn("BranchCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBranchCode);
      this.columnProducerCode = new DataColumn("ProducerCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerCode);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnCompanyID,
        this.columnProducerLocationID
      }, true));
      this.columnCompanyID.AllowDBNull = false;
      this.columnProducerLocationID.AllowDBNull = false;
      this.columnBranchCode.AllowDBNull = false;
      this.columnProducerCode.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyProducerInfo.tblCompanyProducerInfoRow NewtblCompanyProducerInfoRow()
    {
      return (dsCompanyProducerInfo.tblCompanyProducerInfoRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyProducerInfo.tblCompanyProducerInfoRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyProducerInfo.tblCompanyProducerInfoRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProducerInfoRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyProducerInfo.tblCompanyProducerInfoRowChangeEventHandler infoRowChangedEvent = this.tblCompanyProducerInfoRowChangedEvent;
      if (infoRowChangedEvent == null)
        return;
      infoRowChangedEvent((object) this, new dsCompanyProducerInfo.tblCompanyProducerInfoRowChangeEvent((dsCompanyProducerInfo.tblCompanyProducerInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProducerInfoRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyProducerInfo.tblCompanyProducerInfoRowChangeEventHandler rowChangingEvent = this.tblCompanyProducerInfoRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyProducerInfo.tblCompanyProducerInfoRowChangeEvent((dsCompanyProducerInfo.tblCompanyProducerInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProducerInfoRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyProducerInfo.tblCompanyProducerInfoRowChangeEventHandler infoRowDeletedEvent = this.tblCompanyProducerInfoRowDeletedEvent;
      if (infoRowDeletedEvent == null)
        return;
      infoRowDeletedEvent((object) this, new dsCompanyProducerInfo.tblCompanyProducerInfoRowChangeEvent((dsCompanyProducerInfo.tblCompanyProducerInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyProducerInfoRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyProducerInfo.tblCompanyProducerInfoRowChangeEventHandler rowDeletingEvent = this.tblCompanyProducerInfoRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyProducerInfo.tblCompanyProducerInfoRowChangeEvent((dsCompanyProducerInfo.tblCompanyProducerInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyProducerInfoRow(
      dsCompanyProducerInfo.tblCompanyProducerInfoRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyProducerInfo companyProducerInfo = new dsCompanyProducerInfo();
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
        FixedValue = companyProducerInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyProducerInfoDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyProducerInfo.GetSchemaSerializable();
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
  public class tblProducerLocationsDataTable : 
    TypedTableBase<dsCompanyProducerInfo.tblProducerLocationsRow>
  {
    private DataColumn columnProducerLocationID;
    private DataColumn columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblProducerLocationsDataTable()
    {
      this.TableName = "tblProducerLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblProducerLocationsDataTable(DataTable table)
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
    protected tblProducerLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerLocationIDColumn => this.columnProducerLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyProducerInfo.tblProducerLocationsRow this[int index]
    {
      get => (dsCompanyProducerInfo.tblProducerLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyProducerInfo.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyProducerInfo.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyProducerInfo.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyProducerInfo.tblProducerLocationsRowChangeEventHandler tblProducerLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblProducerLocationsRow(dsCompanyProducerInfo.tblProducerLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyProducerInfo.tblProducerLocationsRow AddtblProducerLocationsRow(
      int ProducerLocationID,
      string Name)
    {
      dsCompanyProducerInfo.tblProducerLocationsRow row = (dsCompanyProducerInfo.tblProducerLocationsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ProducerLocationID,
        (object) Name
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyProducerInfo.tblProducerLocationsRow FindByProducerLocationID(
      int ProducerLocationID)
    {
      return (dsCompanyProducerInfo.tblProducerLocationsRow) this.Rows.Find(new object[1]
      {
        (object) ProducerLocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyProducerInfo.tblProducerLocationsDataTable locationsDataTable = (dsCompanyProducerInfo.tblProducerLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyProducerInfo.tblProducerLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerLocationID = this.Columns["ProducerLocationID"];
      this.columnName = this.Columns["Name"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnProducerLocationID = new DataColumn("ProducerLocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyProducerInfoKey1", new DataColumn[1]
      {
        this.columnProducerLocationID
      }, true));
      this.columnProducerLocationID.AllowDBNull = false;
      this.columnProducerLocationID.Unique = true;
      this.columnName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyProducerInfo.tblProducerLocationsRow NewtblProducerLocationsRow()
    {
      return (dsCompanyProducerInfo.tblProducerLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyProducerInfo.tblProducerLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyProducerInfo.tblProducerLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyProducerInfo.tblProducerLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblProducerLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsCompanyProducerInfo.tblProducerLocationsRowChangeEvent((dsCompanyProducerInfo.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyProducerInfo.tblProducerLocationsRowChangeEventHandler rowChangingEvent = this.tblProducerLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyProducerInfo.tblProducerLocationsRowChangeEvent((dsCompanyProducerInfo.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyProducerInfo.tblProducerLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblProducerLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsCompanyProducerInfo.tblProducerLocationsRowChangeEvent((dsCompanyProducerInfo.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblProducerLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyProducerInfo.tblProducerLocationsRowChangeEventHandler rowDeletingEvent = this.tblProducerLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyProducerInfo.tblProducerLocationsRowChangeEvent((dsCompanyProducerInfo.tblProducerLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblProducerLocationsRow(dsCompanyProducerInfo.tblProducerLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyProducerInfo companyProducerInfo = new dsCompanyProducerInfo();
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
        FixedValue = companyProducerInfo.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblProducerLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyProducerInfo.GetSchemaSerializable();
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

  public class tblCompanyProducerInfoRow : DataRow
  {
    private dsCompanyProducerInfo.tblCompanyProducerInfoDataTable tabletblCompanyProducerInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyProducerInfoRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyProducerInfo = (dsCompanyProducerInfo.tblCompanyProducerInfoDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int CompanyID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyProducerInfo.CompanyIDColumn]);
      set => this[this.tabletblCompanyProducerInfo.CompanyIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ProducerLocationID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyProducerInfo.ProducerLocationIDColumn]);
      set => this[this.tabletblCompanyProducerInfo.ProducerLocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BranchCode
    {
      get => Conversions.ToString(this[this.tabletblCompanyProducerInfo.BranchCodeColumn]);
      set => this[this.tabletblCompanyProducerInfo.BranchCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerCode
    {
      get => Conversions.ToString(this[this.tabletblCompanyProducerInfo.ProducerCodeColumn]);
      set => this[this.tabletblCompanyProducerInfo.ProducerCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyProducerInfo.tblProducerLocationsRow tblProducerLocationsRow
    {
      get
      {
        return (dsCompanyProducerInfo.tblProducerLocationsRow) this.GetParentRow(this.Table.ParentRelations["tblProducerLocationstblCompanyProducerInfo"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblProducerLocationstblCompanyProducerInfo"]);
      }
    }
  }

  public class tblProducerLocationsRow : DataRow
  {
    private dsCompanyProducerInfo.tblProducerLocationsDataTable tabletblProducerLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblProducerLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblProducerLocations = (dsCompanyProducerInfo.tblProducerLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ProducerLocationID
    {
      get => Conversions.ToInteger(this[this.tabletblProducerLocations.ProducerLocationIDColumn]);
      set => this[this.tabletblProducerLocations.ProducerLocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Name
    {
      get => Conversions.ToString(this[this.tabletblProducerLocations.NameColumn]);
      set => this[this.tabletblProducerLocations.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyProducerInfo.tblCompanyProducerInfoRow[] GettblCompanyProducerInfoRows()
    {
      return this.Table.ChildRelations["tblProducerLocationstblCompanyProducerInfo"] != null ? (dsCompanyProducerInfo.tblCompanyProducerInfoRow[]) this.GetChildRows(this.Table.ChildRelations["tblProducerLocationstblCompanyProducerInfo"]) : new dsCompanyProducerInfo.tblCompanyProducerInfoRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyProducerInfoRowChangeEvent : EventArgs
  {
    private dsCompanyProducerInfo.tblCompanyProducerInfoRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyProducerInfoRowChangeEvent(
      dsCompanyProducerInfo.tblCompanyProducerInfoRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyProducerInfo.tblCompanyProducerInfoRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblProducerLocationsRowChangeEvent : EventArgs
  {
    private dsCompanyProducerInfo.tblProducerLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblProducerLocationsRowChangeEvent(
      dsCompanyProducerInfo.tblProducerLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyProducerInfo.tblProducerLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
