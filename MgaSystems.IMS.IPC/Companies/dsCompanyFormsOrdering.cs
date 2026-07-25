// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.dsCompanyFormsOrdering
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
[XmlRoot("dsCompanyFormsOrdering")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyFormsOrdering : DataSet
{
  private dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesDataTable tabletblCompanyFormsConditionsWarranties;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsCompanyFormsOrdering()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected dsCompanyFormsOrdering(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyFormsConditionsWarranties)] != null)
          base.Tables.Add((DataTable) new dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesDataTable(dataSet.Tables[nameof (tblCompanyFormsConditionsWarranties)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesDataTable tblCompanyFormsConditionsWarranties
  {
    get => this.tabletblCompanyFormsConditionsWarranties;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public override DataSet Clone()
  {
    dsCompanyFormsOrdering companyFormsOrdering = (dsCompanyFormsOrdering) base.Clone();
    companyFormsOrdering.InitVars();
    companyFormsOrdering.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) companyFormsOrdering;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["tblCompanyFormsConditionsWarranties"] != null)
        base.Tables.Add((DataTable) new dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesDataTable(dataSet.Tables["tblCompanyFormsConditionsWarranties"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tabletblCompanyFormsConditionsWarranties = (dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesDataTable) base.Tables["tblCompanyFormsConditionsWarranties"];
    if (!initTable || this.tabletblCompanyFormsConditionsWarranties == null)
      return;
    this.tabletblCompanyFormsConditionsWarranties.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyFormsOrdering);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCompanyFormsOrdering.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyFormsConditionsWarranties = new dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyFormsConditionsWarranties);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyFormsConditionsWarranties() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsCompanyFormsOrdering companyFormsOrdering = new dsCompanyFormsOrdering();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = companyFormsOrdering.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = companyFormsOrdering.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyFormsConditionsWarrantiesRowChangeEventHandler(
    object sender,
    dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyFormsConditionsWarrantiesDataTable : 
    TypedTableBase<dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow>
  {
    private DataColumn columnPolicyFormID;
    private DataColumn columnFormOrder;
    private DataColumn columnCompany_FCW_ID;
    private DataColumn columnFormName;
    private DataColumn columnFormNumber;
    private DataColumn columnDisabled;
    private DataColumn columnConditionOrder;
    private DataColumn columnCondition;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyFormsConditionsWarrantiesDataTable()
    {
      this.TableName = "tblCompanyFormsConditionsWarranties";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyFormsConditionsWarrantiesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblCompanyFormsConditionsWarrantiesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyFormIDColumn => this.columnPolicyFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormOrderColumn => this.columnFormOrder;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Company_FCW_IDColumn => this.columnCompany_FCW_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormNameColumn => this.columnFormName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FormNumberColumn => this.columnFormNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DisabledColumn => this.columnDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ConditionOrderColumn => this.columnConditionOrder;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ConditionColumn => this.columnCondition;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow this[int index]
    {
      get => (dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler tblCompanyFormsConditionsWarrantiesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler tblCompanyFormsConditionsWarrantiesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler tblCompanyFormsConditionsWarrantiesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler tblCompanyFormsConditionsWarrantiesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyFormsConditionsWarrantiesRow(
      dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow AddtblCompanyFormsConditionsWarrantiesRow(
      int PolicyFormID,
      int FormOrder,
      string FormName,
      string FormNumber,
      DateTime Disabled,
      int ConditionOrder,
      string Condition)
    {
      dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow row = (dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow) this.NewRow();
      object[] objArray = new object[8]
      {
        (object) PolicyFormID,
        (object) FormOrder,
        null,
        (object) FormName,
        (object) FormNumber,
        (object) Disabled,
        (object) ConditionOrder,
        (object) Condition
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow FindByCompany_FCW_ID(
      int Company_FCW_ID)
    {
      return (dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow) this.Rows.Find(new object[1]
      {
        (object) Company_FCW_ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesDataTable warrantiesDataTable = (dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesDataTable) base.Clone();
      warrantiesDataTable.InitVars();
      return (DataTable) warrantiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnPolicyFormID = this.Columns["PolicyFormID"];
      this.columnFormOrder = this.Columns["FormOrder"];
      this.columnCompany_FCW_ID = this.Columns["Company_FCW_ID"];
      this.columnFormName = this.Columns["FormName"];
      this.columnFormNumber = this.Columns["FormNumber"];
      this.columnDisabled = this.Columns["Disabled"];
      this.columnConditionOrder = this.Columns["ConditionOrder"];
      this.columnCondition = this.Columns["Condition"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnPolicyFormID = new DataColumn("PolicyFormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyFormID);
      this.columnFormOrder = new DataColumn("FormOrder", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormOrder);
      this.columnCompany_FCW_ID = new DataColumn("Company_FCW_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany_FCW_ID);
      this.columnFormName = new DataColumn("FormName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormName);
      this.columnFormNumber = new DataColumn("FormNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFormNumber);
      this.columnDisabled = new DataColumn("Disabled", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisabled);
      this.columnConditionOrder = new DataColumn("ConditionOrder", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConditionOrder);
      this.columnCondition = new DataColumn("Condition", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCondition);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyFormsOrderingKey1", new DataColumn[1]
      {
        this.columnCompany_FCW_ID
      }, true));
      this.columnCompany_FCW_ID.AutoIncrement = true;
      this.columnCompany_FCW_ID.AllowDBNull = false;
      this.columnCompany_FCW_ID.ReadOnly = true;
      this.columnCompany_FCW_ID.Unique = true;
      this.columnFormName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow NewtblCompanyFormsConditionsWarrantiesRow()
    {
      return (dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyFormsConditionsWarrantiesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler warrantiesRowChangedEvent = this.tblCompanyFormsConditionsWarrantiesRowChangedEvent;
      if (warrantiesRowChangedEvent == null)
        return;
      warrantiesRowChangedEvent((object) this, new dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRowChangeEvent((dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyFormsConditionsWarrantiesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler rowChangingEvent = this.tblCompanyFormsConditionsWarrantiesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRowChangeEvent((dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyFormsConditionsWarrantiesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler warrantiesRowDeletedEvent = this.tblCompanyFormsConditionsWarrantiesRowDeletedEvent;
      if (warrantiesRowDeletedEvent == null)
        return;
      warrantiesRowDeletedEvent((object) this, new dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRowChangeEvent((dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyFormsConditionsWarrantiesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRowChangeEventHandler rowDeletingEvent = this.tblCompanyFormsConditionsWarrantiesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRowChangeEvent((dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyFormsConditionsWarrantiesRow(
      dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyFormsOrdering companyFormsOrdering = new dsCompanyFormsOrdering();
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
        FixedValue = companyFormsOrdering.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyFormsConditionsWarrantiesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyFormsOrdering.GetSchemaSerializable();
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

  public class tblCompanyFormsConditionsWarrantiesRow : DataRow
  {
    private dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesDataTable tabletblCompanyFormsConditionsWarranties;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyFormsConditionsWarrantiesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyFormsConditionsWarranties = (dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyFormID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyFormsConditionsWarranties.PolicyFormIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyFormID' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.PolicyFormIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int FormOrder
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyFormsConditionsWarranties.FormOrderColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FormOrder' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.FormOrderColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Company_FCW_ID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyFormsConditionsWarranties.Company_FCW_IDColumn]);
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.Company_FCW_IDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FormName
    {
      get
      {
        return Conversions.ToString(this[this.tabletblCompanyFormsConditionsWarranties.FormNameColumn]);
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.FormNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string FormNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyFormsConditionsWarranties.FormNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FormNumber' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.FormNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime Disabled
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblCompanyFormsConditionsWarranties.DisabledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Disabled' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.DisabledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ConditionOrder
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyFormsConditionsWarranties.ConditionOrderColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConditionOrder' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyFormsConditionsWarranties.ConditionOrderColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Condition
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyFormsConditionsWarranties.ConditionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Condition' in table 'tblCompanyFormsConditionsWarranties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyFormsConditionsWarranties.ConditionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyFormIDNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.PolicyFormIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyFormIDNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.PolicyFormIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFormOrderNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.FormOrderColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFormOrderNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.FormOrderColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFormNumberNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.FormNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFormNumberNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.FormNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDisabledNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.DisabledColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDisabledNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.DisabledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsConditionOrderNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.ConditionOrderColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsConditionNull()
    {
      return this.IsNull(this.tabletblCompanyFormsConditionsWarranties.ConditionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetConditionOrderNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.ConditionOrderColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetConditionNull()
    {
      this[this.tabletblCompanyFormsConditionsWarranties.ConditionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyFormsConditionsWarrantiesRowChangeEvent : EventArgs
  {
    private dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyFormsConditionsWarrantiesRowChangeEvent(
      dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
