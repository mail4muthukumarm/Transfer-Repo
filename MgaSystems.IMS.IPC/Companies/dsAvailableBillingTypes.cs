// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.dsAvailableBillingTypes
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
[XmlRoot("dsAvailableBillingTypes")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsAvailableBillingTypes : DataSet
{
  private dsAvailableBillingTypes.tblCompanyBillingTypesDataTable tabletblCompanyBillingTypes;
  private dsAvailableBillingTypes.lstBillingTypesDataTable tablelstBillingTypes;
  private DataRelation relationlstBillingTypestblCompanyBillingTypes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsAvailableBillingTypes()
  {
    this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
    this.InitExpressions();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected dsAvailableBillingTypes(SerializationInfo info, StreamingContext context)
    : base(info, context, false)
  {
    this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    if (this.IsBinarySerialized(info, context))
    {
      this.InitVars(false);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      this.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
      if (this.DetermineSchemaSerializationMode(info, context) != SchemaSerializationMode.ExcludeSchema)
        return;
      this.InitExpressions();
    }
    else
    {
      string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
      if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
      {
        DataSet dataSet = new DataSet();
        dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        if (dataSet.Tables[nameof (tblCompanyBillingTypes)] != null)
          base.Tables.Add((DataTable) new dsAvailableBillingTypes.tblCompanyBillingTypesDataTable(dataSet.Tables[nameof (tblCompanyBillingTypes)]));
        if (dataSet.Tables[nameof (lstBillingTypes)] != null)
          base.Tables.Add((DataTable) new dsAvailableBillingTypes.lstBillingTypesDataTable(dataSet.Tables[nameof (lstBillingTypes)]));
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
        this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        this.InitExpressions();
      }
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
  public dsAvailableBillingTypes.tblCompanyBillingTypesDataTable tblCompanyBillingTypes
  {
    get => this.tabletblCompanyBillingTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAvailableBillingTypes.lstBillingTypesDataTable lstBillingTypes
  {
    get => this.tablelstBillingTypes;
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
    dsAvailableBillingTypes availableBillingTypes = (dsAvailableBillingTypes) base.Clone();
    availableBillingTypes.InitVars();
    availableBillingTypes.InitExpressions();
    availableBillingTypes.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) availableBillingTypes;
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
      if (dataSet.Tables["tblCompanyBillingTypes"] != null)
        base.Tables.Add((DataTable) new dsAvailableBillingTypes.tblCompanyBillingTypesDataTable(dataSet.Tables["tblCompanyBillingTypes"]));
      if (dataSet.Tables["lstBillingTypes"] != null)
        base.Tables.Add((DataTable) new dsAvailableBillingTypes.lstBillingTypesDataTable(dataSet.Tables["lstBillingTypes"]));
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
    this.tabletblCompanyBillingTypes = (dsAvailableBillingTypes.tblCompanyBillingTypesDataTable) base.Tables["tblCompanyBillingTypes"];
    if (initTable && this.tabletblCompanyBillingTypes != null)
      this.tabletblCompanyBillingTypes.InitVars();
    this.tablelstBillingTypes = (dsAvailableBillingTypes.lstBillingTypesDataTable) base.Tables["lstBillingTypes"];
    if (initTable && this.tablelstBillingTypes != null)
      this.tablelstBillingTypes.InitVars();
    this.relationlstBillingTypestblCompanyBillingTypes = this.Relations["lstBillingTypestblCompanyBillingTypes"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsAvailableBillingTypes);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsAvailableBillingTypes.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyBillingTypes = new dsAvailableBillingTypes.tblCompanyBillingTypesDataTable(false);
    base.Tables.Add((DataTable) this.tabletblCompanyBillingTypes);
    this.tablelstBillingTypes = new dsAvailableBillingTypes.lstBillingTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstBillingTypes);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("lstBillingTypestblCompanyBillingTypes", new DataColumn[1]
    {
      this.tablelstBillingTypes.BillingTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyBillingTypes.BillingTypeIDColumn
    });
    this.tabletblCompanyBillingTypes.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationlstBillingTypestblCompanyBillingTypes = new DataRelation("lstBillingTypestblCompanyBillingTypes", new DataColumn[1]
    {
      this.tablelstBillingTypes.BillingTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyBillingTypes.BillingTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstBillingTypestblCompanyBillingTypes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyBillingTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstBillingTypes() => false;

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
    dsAvailableBillingTypes availableBillingTypes = new dsAvailableBillingTypes();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = availableBillingTypes.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = availableBillingTypes.GetSchemaSerializable();
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

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitExpressions()
  {
    this.tblCompanyBillingTypes.BillingTypeColumn.Expression = "Parent.BillingType";
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblCompanyBillingTypesRowChangeEventHandler(
    object sender,
    dsAvailableBillingTypes.tblCompanyBillingTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstBillingTypesRowChangeEventHandler(
    object sender,
    dsAvailableBillingTypes.lstBillingTypesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyBillingTypesDataTable : 
    TypedTableBase<dsAvailableBillingTypes.tblCompanyBillingTypesRow>
  {
    private DataColumn columnID;
    private DataColumn columnBillingTypeID;
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnDownpayment;
    private DataColumn columnSelected;
    private DataColumn columnCheckedInUse;
    private DataColumn columnBillingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyBillingTypesDataTable()
      : this(false)
    {
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyBillingTypesDataTable(bool initExpressions)
    {
      this.TableName = "tblCompanyBillingTypes";
      this.BeginInit();
      this.InitClass();
      if (initExpressions)
        this.InitExpressions();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyBillingTypesDataTable(DataTable table)
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
    protected tblCompanyBillingTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BillingTypeIDColumn => this.columnBillingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DownpaymentColumn => this.columnDownpayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SelectedColumn => this.columnSelected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CheckedInUseColumn => this.columnCheckedInUse;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BillingTypeColumn => this.columnBillingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAvailableBillingTypes.tblCompanyBillingTypesRow this[int index]
    {
      get => (dsAvailableBillingTypes.tblCompanyBillingTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAvailableBillingTypes.tblCompanyBillingTypesRowChangeEventHandler tblCompanyBillingTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAvailableBillingTypes.tblCompanyBillingTypesRowChangeEventHandler tblCompanyBillingTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAvailableBillingTypes.tblCompanyBillingTypesRowChangeEventHandler tblCompanyBillingTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAvailableBillingTypes.tblCompanyBillingTypesRowChangeEventHandler tblCompanyBillingTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyBillingTypesRow(
      dsAvailableBillingTypes.tblCompanyBillingTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAvailableBillingTypes.tblCompanyBillingTypesRow AddtblCompanyBillingTypesRow(
      dsAvailableBillingTypes.lstBillingTypesRow parentlstBillingTypesRowBylstBillingTypestblCompanyBillingTypes,
      Guid CompanyLineGuid,
      bool Downpayment,
      bool Selected,
      bool CheckedInUse,
      string BillingType)
    {
      dsAvailableBillingTypes.tblCompanyBillingTypesRow row = (dsAvailableBillingTypes.tblCompanyBillingTypesRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        null,
        (object) CompanyLineGuid,
        (object) Downpayment,
        (object) Selected,
        (object) CheckedInUse,
        (object) BillingType
      };
      if (parentlstBillingTypesRowBylstBillingTypestblCompanyBillingTypes != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstBillingTypesRowBylstBillingTypestblCompanyBillingTypes[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAvailableBillingTypes.tblCompanyBillingTypesRow AddtblCompanyBillingTypesRow(
      dsAvailableBillingTypes.lstBillingTypesRow parentlstBillingTypesRowBylstBillingTypestblCompanyBillingTypes,
      Guid CompanyLineGuid,
      bool Downpayment,
      bool Selected,
      bool CheckedInUse)
    {
      dsAvailableBillingTypes.tblCompanyBillingTypesRow row = (dsAvailableBillingTypes.tblCompanyBillingTypesRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        null,
        (object) CompanyLineGuid,
        (object) Downpayment,
        (object) Selected,
        (object) CheckedInUse,
        null
      };
      if (parentlstBillingTypesRowBylstBillingTypestblCompanyBillingTypes != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstBillingTypesRowBylstBillingTypestblCompanyBillingTypes[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsAvailableBillingTypes.tblCompanyBillingTypesDataTable billingTypesDataTable = (dsAvailableBillingTypes.tblCompanyBillingTypesDataTable) base.Clone();
      billingTypesDataTable.InitVars();
      return (DataTable) billingTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAvailableBillingTypes.tblCompanyBillingTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnBillingTypeID = this.Columns["BillingTypeID"];
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnDownpayment = this.Columns["Downpayment"];
      this.columnSelected = this.Columns["Selected"];
      this.columnCheckedInUse = this.Columns["CheckedInUse"];
      this.columnBillingType = this.Columns["BillingType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnBillingTypeID = new DataColumn("BillingTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingTypeID);
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnDownpayment = new DataColumn("Downpayment", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownpayment);
      this.columnSelected = new DataColumn("Selected", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSelected);
      this.columnCheckedInUse = new DataColumn("CheckedInUse", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheckedInUse);
      this.columnBillingType = new DataColumn("BillingType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingType);
      this.columnID.AutoIncrement = true;
      this.columnID.ReadOnly = true;
      this.columnBillingTypeID.AllowDBNull = false;
      this.columnCompanyLineGuid.AllowDBNull = false;
      this.columnDownpayment.AllowDBNull = false;
      this.columnSelected.DefaultValue = (object) false;
      this.columnCheckedInUse.DefaultValue = (object) false;
      this.columnBillingType.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAvailableBillingTypes.tblCompanyBillingTypesRow NewtblCompanyBillingTypesRow()
    {
      return (dsAvailableBillingTypes.tblCompanyBillingTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAvailableBillingTypes.tblCompanyBillingTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsAvailableBillingTypes.tblCompanyBillingTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitExpressions() => this.BillingTypeColumn.Expression = "Parent.BillingType";

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyBillingTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAvailableBillingTypes.tblCompanyBillingTypesRowChangeEventHandler typesRowChangedEvent = this.tblCompanyBillingTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsAvailableBillingTypes.tblCompanyBillingTypesRowChangeEvent((dsAvailableBillingTypes.tblCompanyBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyBillingTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAvailableBillingTypes.tblCompanyBillingTypesRowChangeEventHandler rowChangingEvent = this.tblCompanyBillingTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAvailableBillingTypes.tblCompanyBillingTypesRowChangeEvent((dsAvailableBillingTypes.tblCompanyBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyBillingTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAvailableBillingTypes.tblCompanyBillingTypesRowChangeEventHandler typesRowDeletedEvent = this.tblCompanyBillingTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsAvailableBillingTypes.tblCompanyBillingTypesRowChangeEvent((dsAvailableBillingTypes.tblCompanyBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyBillingTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAvailableBillingTypes.tblCompanyBillingTypesRowChangeEventHandler rowDeletingEvent = this.tblCompanyBillingTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAvailableBillingTypes.tblCompanyBillingTypesRowChangeEvent((dsAvailableBillingTypes.tblCompanyBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyBillingTypesRow(
      dsAvailableBillingTypes.tblCompanyBillingTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAvailableBillingTypes availableBillingTypes = new dsAvailableBillingTypes();
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
        FixedValue = availableBillingTypes.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyBillingTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = availableBillingTypes.GetSchemaSerializable();
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
  public class lstBillingTypesDataTable : TypedTableBase<dsAvailableBillingTypes.lstBillingTypesRow>
  {
    private DataColumn columnBillingTypeID;
    private DataColumn columnBillingType;
    private DataColumn columnDownpaymentOnly;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstBillingTypesDataTable()
    {
      this.TableName = "lstBillingTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstBillingTypesDataTable(DataTable table)
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
    protected lstBillingTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BillingTypeIDColumn => this.columnBillingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BillingTypeColumn => this.columnBillingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DownpaymentOnlyColumn => this.columnDownpaymentOnly;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAvailableBillingTypes.lstBillingTypesRow this[int index]
    {
      get => (dsAvailableBillingTypes.lstBillingTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAvailableBillingTypes.lstBillingTypesRowChangeEventHandler lstBillingTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAvailableBillingTypes.lstBillingTypesRowChangeEventHandler lstBillingTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAvailableBillingTypes.lstBillingTypesRowChangeEventHandler lstBillingTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAvailableBillingTypes.lstBillingTypesRowChangeEventHandler lstBillingTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstBillingTypesRow(dsAvailableBillingTypes.lstBillingTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAvailableBillingTypes.lstBillingTypesRow AddlstBillingTypesRow(
      int BillingTypeID,
      string BillingType,
      bool DownpaymentOnly)
    {
      dsAvailableBillingTypes.lstBillingTypesRow row = (dsAvailableBillingTypes.lstBillingTypesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) BillingTypeID,
        (object) BillingType,
        (object) DownpaymentOnly
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAvailableBillingTypes.lstBillingTypesRow FindByBillingTypeID(int BillingTypeID)
    {
      return (dsAvailableBillingTypes.lstBillingTypesRow) this.Rows.Find(new object[1]
      {
        (object) BillingTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsAvailableBillingTypes.lstBillingTypesDataTable billingTypesDataTable = (dsAvailableBillingTypes.lstBillingTypesDataTable) base.Clone();
      billingTypesDataTable.InitVars();
      return (DataTable) billingTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAvailableBillingTypes.lstBillingTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnBillingTypeID = this.Columns["BillingTypeID"];
      this.columnBillingType = this.Columns["BillingType"];
      this.columnDownpaymentOnly = this.Columns["DownpaymentOnly"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnBillingTypeID = new DataColumn("BillingTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingTypeID);
      this.columnBillingType = new DataColumn("BillingType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingType);
      this.columnDownpaymentOnly = new DataColumn("DownpaymentOnly", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownpaymentOnly);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsAvailableBillingTypesKey2", new DataColumn[1]
      {
        this.columnBillingTypeID
      }, true));
      this.columnBillingTypeID.AllowDBNull = false;
      this.columnBillingTypeID.Unique = true;
      this.columnBillingType.AllowDBNull = false;
      this.columnDownpaymentOnly.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAvailableBillingTypes.lstBillingTypesRow NewlstBillingTypesRow()
    {
      return (dsAvailableBillingTypes.lstBillingTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAvailableBillingTypes.lstBillingTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsAvailableBillingTypes.lstBillingTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBillingTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAvailableBillingTypes.lstBillingTypesRowChangeEventHandler typesRowChangedEvent = this.lstBillingTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsAvailableBillingTypes.lstBillingTypesRowChangeEvent((dsAvailableBillingTypes.lstBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBillingTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAvailableBillingTypes.lstBillingTypesRowChangeEventHandler rowChangingEvent = this.lstBillingTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAvailableBillingTypes.lstBillingTypesRowChangeEvent((dsAvailableBillingTypes.lstBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBillingTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAvailableBillingTypes.lstBillingTypesRowChangeEventHandler typesRowDeletedEvent = this.lstBillingTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsAvailableBillingTypes.lstBillingTypesRowChangeEvent((dsAvailableBillingTypes.lstBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBillingTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAvailableBillingTypes.lstBillingTypesRowChangeEventHandler rowDeletingEvent = this.lstBillingTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAvailableBillingTypes.lstBillingTypesRowChangeEvent((dsAvailableBillingTypes.lstBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstBillingTypesRow(dsAvailableBillingTypes.lstBillingTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAvailableBillingTypes availableBillingTypes = new dsAvailableBillingTypes();
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
        FixedValue = availableBillingTypes.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstBillingTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = availableBillingTypes.GetSchemaSerializable();
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

  public class tblCompanyBillingTypesRow : DataRow
  {
    private dsAvailableBillingTypes.tblCompanyBillingTypesDataTable tabletblCompanyBillingTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyBillingTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyBillingTypes = (dsAvailableBillingTypes.tblCompanyBillingTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyBillingTypes.IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ID' in table 'tblCompanyBillingTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyBillingTypes.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int BillingTypeID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyBillingTypes.BillingTypeIDColumn]);
      set => this[this.tabletblCompanyBillingTypes.BillingTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        object obj = this[this.tabletblCompanyBillingTypes.CompanyLineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyBillingTypes.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Downpayment
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyBillingTypes.DownpaymentColumn]);
      set => this[this.tabletblCompanyBillingTypes.DownpaymentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Selected
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyBillingTypes.SelectedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Selected' in table 'tblCompanyBillingTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyBillingTypes.SelectedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool CheckedInUse
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyBillingTypes.CheckedInUseColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CheckedInUse' in table 'tblCompanyBillingTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyBillingTypes.CheckedInUseColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BillingType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyBillingTypes.BillingTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillingType' in table 'tblCompanyBillingTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyBillingTypes.BillingTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAvailableBillingTypes.lstBillingTypesRow lstBillingTypesRow
    {
      get
      {
        return (dsAvailableBillingTypes.lstBillingTypesRow) this.GetParentRow(this.Table.ParentRelations["lstBillingTypestblCompanyBillingTypes"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstBillingTypestblCompanyBillingTypes"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsIDNull() => this.IsNull(this.tabletblCompanyBillingTypes.IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetIDNull()
    {
      this[this.tabletblCompanyBillingTypes.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSelectedNull() => this.IsNull(this.tabletblCompanyBillingTypes.SelectedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSelectedNull()
    {
      this[this.tabletblCompanyBillingTypes.SelectedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCheckedInUseNull()
    {
      return this.IsNull(this.tabletblCompanyBillingTypes.CheckedInUseColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCheckedInUseNull()
    {
      this[this.tabletblCompanyBillingTypes.CheckedInUseColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBillingTypeNull()
    {
      return this.IsNull(this.tabletblCompanyBillingTypes.BillingTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBillingTypeNull()
    {
      this[this.tabletblCompanyBillingTypes.BillingTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstBillingTypesRow : DataRow
  {
    private dsAvailableBillingTypes.lstBillingTypesDataTable tablelstBillingTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstBillingTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstBillingTypes = (dsAvailableBillingTypes.lstBillingTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int BillingTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstBillingTypes.BillingTypeIDColumn]);
      set => this[this.tablelstBillingTypes.BillingTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BillingType
    {
      get => Conversions.ToString(this[this.tablelstBillingTypes.BillingTypeColumn]);
      set => this[this.tablelstBillingTypes.BillingTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool DownpaymentOnly
    {
      get => Conversions.ToBoolean(this[this.tablelstBillingTypes.DownpaymentOnlyColumn]);
      set => this[this.tablelstBillingTypes.DownpaymentOnlyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAvailableBillingTypes.tblCompanyBillingTypesRow[] GettblCompanyBillingTypesRows()
    {
      return this.Table.ChildRelations["lstBillingTypestblCompanyBillingTypes"] != null ? (dsAvailableBillingTypes.tblCompanyBillingTypesRow[]) this.GetChildRows(this.Table.ChildRelations["lstBillingTypestblCompanyBillingTypes"]) : new dsAvailableBillingTypes.tblCompanyBillingTypesRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyBillingTypesRowChangeEvent : EventArgs
  {
    private dsAvailableBillingTypes.tblCompanyBillingTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyBillingTypesRowChangeEvent(
      dsAvailableBillingTypes.tblCompanyBillingTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAvailableBillingTypes.tblCompanyBillingTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstBillingTypesRowChangeEvent : EventArgs
  {
    private dsAvailableBillingTypes.lstBillingTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstBillingTypesRowChangeEvent(
      dsAvailableBillingTypes.lstBillingTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAvailableBillingTypes.lstBillingTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
