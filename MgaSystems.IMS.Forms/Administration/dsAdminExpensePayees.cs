// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Administration.dsAdminExpensePayees
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

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
namespace MGASystems.IMS.Forms.Administration;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsAdminExpensePayees")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsAdminExpensePayees : DataSet
{
  private dsAdminExpensePayees.tblFin_ExpensePayeesDataTable tabletblFin_ExpensePayees;
  private dsAdminExpensePayees.FinanceAgreementsDataTable tableFinanceAgreements;
  private DataRelation relationFinanceAgreements_tblFin_ExpensePayees;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsAdminExpensePayees()
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
  protected dsAdminExpensePayees(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblFin_ExpensePayees)] != null)
          base.Tables.Add((DataTable) new dsAdminExpensePayees.tblFin_ExpensePayeesDataTable(dataSet.Tables[nameof (tblFin_ExpensePayees)]));
        if (dataSet.Tables[nameof (FinanceAgreements)] != null)
          base.Tables.Add((DataTable) new dsAdminExpensePayees.FinanceAgreementsDataTable(dataSet.Tables[nameof (FinanceAgreements)]));
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
  public dsAdminExpensePayees.tblFin_ExpensePayeesDataTable tblFin_ExpensePayees
  {
    get => this.tabletblFin_ExpensePayees;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsAdminExpensePayees.FinanceAgreementsDataTable FinanceAgreements
  {
    get => this.tableFinanceAgreements;
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
    dsAdminExpensePayees adminExpensePayees = (dsAdminExpensePayees) base.Clone();
    adminExpensePayees.InitVars();
    adminExpensePayees.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) adminExpensePayees;
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
      if (dataSet.Tables["tblFin_ExpensePayees"] != null)
        base.Tables.Add((DataTable) new dsAdminExpensePayees.tblFin_ExpensePayeesDataTable(dataSet.Tables["tblFin_ExpensePayees"]));
      if (dataSet.Tables["FinanceAgreements"] != null)
        base.Tables.Add((DataTable) new dsAdminExpensePayees.FinanceAgreementsDataTable(dataSet.Tables["FinanceAgreements"]));
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
    this.tabletblFin_ExpensePayees = (dsAdminExpensePayees.tblFin_ExpensePayeesDataTable) base.Tables["tblFin_ExpensePayees"];
    if (initTable && this.tabletblFin_ExpensePayees != null)
      this.tabletblFin_ExpensePayees.InitVars();
    this.tableFinanceAgreements = (dsAdminExpensePayees.FinanceAgreementsDataTable) base.Tables["FinanceAgreements"];
    if (initTable && this.tableFinanceAgreements != null)
      this.tableFinanceAgreements.InitVars();
    this.relationFinanceAgreements_tblFin_ExpensePayees = this.Relations["FinanceAgreements_tblFin_ExpensePayees"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsAdminExpensePayees);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsAdminExpensePayees.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblFin_ExpensePayees = new dsAdminExpensePayees.tblFin_ExpensePayeesDataTable();
    base.Tables.Add((DataTable) this.tabletblFin_ExpensePayees);
    this.tableFinanceAgreements = new dsAdminExpensePayees.FinanceAgreementsDataTable();
    base.Tables.Add((DataTable) this.tableFinanceAgreements);
    this.relationFinanceAgreements_tblFin_ExpensePayees = new DataRelation("FinanceAgreements_tblFin_ExpensePayees", new DataColumn[1]
    {
      this.tableFinanceAgreements.AutomationReportGuidColumn
    }, new DataColumn[1]
    {
      this.tabletblFin_ExpensePayees.AutomationReportColumn
    }, false);
    this.Relations.Add(this.relationFinanceAgreements_tblFin_ExpensePayees);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblFin_ExpensePayees() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeFinanceAgreements() => false;

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
    dsAdminExpensePayees adminExpensePayees = new dsAdminExpensePayees();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = adminExpensePayees.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = adminExpensePayees.GetSchemaSerializable();
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
  public delegate void tblFin_ExpensePayeesRowChangeEventHandler(
    object sender,
    dsAdminExpensePayees.tblFin_ExpensePayeesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void FinanceAgreementsRowChangeEventHandler(
    object sender,
    dsAdminExpensePayees.FinanceAgreementsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblFin_ExpensePayeesDataTable : 
    TypedTableBase<dsAdminExpensePayees.tblFin_ExpensePayeesRow>
  {
    private DataColumn columnPayeeGuid;
    private DataColumn columnPayeeName;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;
    private DataColumn columnZipPlus;
    private DataColumn columnPhone1;
    private DataColumn columnPhone2;
    private DataColumn columnFax;
    private DataColumn columnEmail;
    private DataColumn columnPayeeType;
    private DataColumn columnPayFromOperating;
    private DataColumn columnHidden;
    private DataColumn columnSSN;
    private DataColumn columnTaxIdNumber;
    private DataColumn columnPayeeAcctNum;
    private DataColumn columnIs1099;
    private DataColumn columnISOCountryCode;
    private DataColumn columnAutomationReport;
    private DataColumn columnRoofInspection;
    private DataColumn columnMedicalProvider;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblFin_ExpensePayeesDataTable()
    {
      this.TableName = "tblFin_ExpensePayees";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblFin_ExpensePayeesDataTable(DataTable table)
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
    protected tblFin_ExpensePayeesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayeeGuidColumn => this.columnPayeeGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayeeNameColumn => this.columnPayeeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Address1Column => this.columnAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Address2Column => this.columnAddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ZipColumn => this.columnZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ZipPlusColumn => this.columnZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Phone1Column => this.columnPhone1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Phone2Column => this.columnPhone2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FaxColumn => this.columnFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayeeTypeColumn => this.columnPayeeType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayFromOperatingColumn => this.columnPayFromOperating;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SSNColumn => this.columnSSN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TaxIdNumberColumn => this.columnTaxIdNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayeeAcctNumColumn => this.columnPayeeAcctNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Is1099Column => this.columnIs1099;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ISOCountryCodeColumn => this.columnISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutomationReportColumn => this.columnAutomationReport;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RoofInspectionColumn => this.columnRoofInspection;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MedicalProviderColumn => this.columnMedicalProvider;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminExpensePayees.tblFin_ExpensePayeesRow this[int index]
    {
      get => (dsAdminExpensePayees.tblFin_ExpensePayeesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminExpensePayees.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminExpensePayees.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminExpensePayees.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminExpensePayees.tblFin_ExpensePayeesRowChangeEventHandler tblFin_ExpensePayeesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblFin_ExpensePayeesRow(dsAdminExpensePayees.tblFin_ExpensePayeesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminExpensePayees.tblFin_ExpensePayeesRow AddtblFin_ExpensePayeesRow(
      Guid PayeeGuid,
      string PayeeName,
      string Address1,
      string Address2,
      string City,
      string State,
      string Zip,
      string ZipPlus,
      string Phone1,
      string Phone2,
      string Fax,
      string Email,
      string PayeeType,
      bool PayFromOperating,
      bool Hidden,
      string SSN,
      string TaxIdNumber,
      string PayeeAcctNum,
      bool Is1099,
      string ISOCountryCode,
      dsAdminExpensePayees.FinanceAgreementsRow parentFinanceAgreementsRowByFinanceAgreements_tblFin_ExpensePayees,
      bool RoofInspection,
      bool MedicalProvider)
    {
      dsAdminExpensePayees.tblFin_ExpensePayeesRow row = (dsAdminExpensePayees.tblFin_ExpensePayeesRow) this.NewRow();
      object[] objArray = new object[23]
      {
        (object) PayeeGuid,
        (object) PayeeName,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) State,
        (object) Zip,
        (object) ZipPlus,
        (object) Phone1,
        (object) Phone2,
        (object) Fax,
        (object) Email,
        (object) PayeeType,
        (object) PayFromOperating,
        (object) Hidden,
        (object) SSN,
        (object) TaxIdNumber,
        (object) PayeeAcctNum,
        (object) Is1099,
        (object) ISOCountryCode,
        null,
        (object) RoofInspection,
        (object) MedicalProvider
      };
      if (parentFinanceAgreementsRowByFinanceAgreements_tblFin_ExpensePayees != null)
        objArray[20] = RuntimeHelpers.GetObjectValue(parentFinanceAgreementsRowByFinanceAgreements_tblFin_ExpensePayees[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminExpensePayees.tblFin_ExpensePayeesRow FindByPayeeGuid(Guid PayeeGuid)
    {
      return (dsAdminExpensePayees.tblFin_ExpensePayeesRow) this.Rows.Find(new object[1]
      {
        (object) PayeeGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminExpensePayees.tblFin_ExpensePayeesDataTable expensePayeesDataTable = (dsAdminExpensePayees.tblFin_ExpensePayeesDataTable) base.Clone();
      expensePayeesDataTable.InitVars();
      return (DataTable) expensePayeesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminExpensePayees.tblFin_ExpensePayeesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnPayeeGuid = this.Columns["PayeeGuid"];
      this.columnPayeeName = this.Columns["PayeeName"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
      this.columnZipPlus = this.Columns["ZipPlus"];
      this.columnPhone1 = this.Columns["Phone1"];
      this.columnPhone2 = this.Columns["Phone2"];
      this.columnFax = this.Columns["Fax"];
      this.columnEmail = this.Columns["Email"];
      this.columnPayeeType = this.Columns["PayeeType"];
      this.columnPayFromOperating = this.Columns["PayFromOperating"];
      this.columnHidden = this.Columns["Hidden"];
      this.columnSSN = this.Columns["SSN"];
      this.columnTaxIdNumber = this.Columns["TaxIdNumber"];
      this.columnPayeeAcctNum = this.Columns["PayeeAcctNum"];
      this.columnIs1099 = this.Columns["Is1099"];
      this.columnISOCountryCode = this.Columns["ISOCountryCode"];
      this.columnAutomationReport = this.Columns["AutomationReport"];
      this.columnRoofInspection = this.Columns["RoofInspection"];
      this.columnMedicalProvider = this.Columns["MedicalProvider"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnPayeeGuid = new DataColumn("PayeeGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeGuid);
      this.columnPayeeName = new DataColumn("PayeeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeName);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnAddress2 = new DataColumn("Address2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.columnZipPlus = new DataColumn("ZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipPlus);
      this.columnPhone1 = new DataColumn("Phone1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhone1);
      this.columnPhone2 = new DataColumn("Phone2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhone2);
      this.columnFax = new DataColumn("Fax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFax);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.columnPayeeType = new DataColumn("PayeeType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeType);
      this.columnPayFromOperating = new DataColumn("PayFromOperating", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayFromOperating);
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.columnSSN = new DataColumn("SSN", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSSN);
      this.columnTaxIdNumber = new DataColumn("TaxIdNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTaxIdNumber);
      this.columnPayeeAcctNum = new DataColumn("PayeeAcctNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeAcctNum);
      this.columnIs1099 = new DataColumn("Is1099", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIs1099);
      this.columnISOCountryCode = new DataColumn("ISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnISOCountryCode);
      this.columnAutomationReport = new DataColumn("AutomationReport", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationReport);
      this.columnRoofInspection = new DataColumn("RoofInspection", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoofInspection);
      this.columnMedicalProvider = new DataColumn("MedicalProvider", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMedicalProvider);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnPayeeGuid
      }, true));
      this.columnPayeeGuid.AllowDBNull = false;
      this.columnPayeeGuid.Unique = true;
      this.columnPayeeType.AllowDBNull = false;
      this.columnPayFromOperating.AllowDBNull = false;
      this.columnPayFromOperating.DefaultValue = (object) false;
      this.columnHidden.AllowDBNull = false;
      this.columnHidden.DefaultValue = (object) false;
      this.columnSSN.MaxLength = 25;
      this.columnTaxIdNumber.MaxLength = 25;
      this.columnIs1099.AllowDBNull = false;
      this.columnIs1099.DefaultValue = (object) false;
      this.columnRoofInspection.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminExpensePayees.tblFin_ExpensePayeesRow NewtblFin_ExpensePayeesRow()
    {
      return (dsAdminExpensePayees.tblFin_ExpensePayeesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminExpensePayees.tblFin_ExpensePayeesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminExpensePayees.tblFin_ExpensePayeesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminExpensePayees.tblFin_ExpensePayeesRowChangeEventHandler payeesRowChangedEvent = this.tblFin_ExpensePayeesRowChangedEvent;
      if (payeesRowChangedEvent == null)
        return;
      payeesRowChangedEvent((object) this, new dsAdminExpensePayees.tblFin_ExpensePayeesRowChangeEvent((dsAdminExpensePayees.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminExpensePayees.tblFin_ExpensePayeesRowChangeEventHandler rowChangingEvent = this.tblFin_ExpensePayeesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminExpensePayees.tblFin_ExpensePayeesRowChangeEvent((dsAdminExpensePayees.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminExpensePayees.tblFin_ExpensePayeesRowChangeEventHandler payeesRowDeletedEvent = this.tblFin_ExpensePayeesRowDeletedEvent;
      if (payeesRowDeletedEvent == null)
        return;
      payeesRowDeletedEvent((object) this, new dsAdminExpensePayees.tblFin_ExpensePayeesRowChangeEvent((dsAdminExpensePayees.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_ExpensePayeesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminExpensePayees.tblFin_ExpensePayeesRowChangeEventHandler rowDeletingEvent = this.tblFin_ExpensePayeesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminExpensePayees.tblFin_ExpensePayeesRowChangeEvent((dsAdminExpensePayees.tblFin_ExpensePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblFin_ExpensePayeesRow(dsAdminExpensePayees.tblFin_ExpensePayeesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminExpensePayees adminExpensePayees = new dsAdminExpensePayees();
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
        FixedValue = adminExpensePayees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblFin_ExpensePayeesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = adminExpensePayees.GetSchemaSerializable();
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
  public class FinanceAgreementsDataTable : TypedTableBase<dsAdminExpensePayees.FinanceAgreementsRow>
  {
    private DataColumn columnAutomationReportGuid;
    private DataColumn columnReportName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public FinanceAgreementsDataTable()
    {
      this.TableName = "FinanceAgreements";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal FinanceAgreementsDataTable(DataTable table)
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
    protected FinanceAgreementsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutomationReportGuidColumn => this.columnAutomationReportGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ReportNameColumn => this.columnReportName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminExpensePayees.FinanceAgreementsRow this[int index]
    {
      get => (dsAdminExpensePayees.FinanceAgreementsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminExpensePayees.FinanceAgreementsRowChangeEventHandler FinanceAgreementsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminExpensePayees.FinanceAgreementsRowChangeEventHandler FinanceAgreementsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminExpensePayees.FinanceAgreementsRowChangeEventHandler FinanceAgreementsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsAdminExpensePayees.FinanceAgreementsRowChangeEventHandler FinanceAgreementsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddFinanceAgreementsRow(dsAdminExpensePayees.FinanceAgreementsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminExpensePayees.FinanceAgreementsRow AddFinanceAgreementsRow(
      Guid AutomationReportGuid,
      string ReportName)
    {
      dsAdminExpensePayees.FinanceAgreementsRow row = (dsAdminExpensePayees.FinanceAgreementsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) AutomationReportGuid,
        (object) ReportName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminExpensePayees.FinanceAgreementsRow FindByAutomationReportGuid(
      Guid AutomationReportGuid)
    {
      return (dsAdminExpensePayees.FinanceAgreementsRow) this.Rows.Find(new object[1]
      {
        (object) AutomationReportGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsAdminExpensePayees.FinanceAgreementsDataTable agreementsDataTable = (dsAdminExpensePayees.FinanceAgreementsDataTable) base.Clone();
      agreementsDataTable.InitVars();
      return (DataTable) agreementsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdminExpensePayees.FinanceAgreementsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnAutomationReportGuid = this.Columns["AutomationReportGuid"];
      this.columnReportName = this.Columns["ReportName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnAutomationReportGuid = new DataColumn("AutomationReportGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationReportGuid);
      this.columnReportName = new DataColumn("ReportName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReportName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnAutomationReportGuid
      }, true));
      this.columnAutomationReportGuid.AllowDBNull = false;
      this.columnAutomationReportGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminExpensePayees.FinanceAgreementsRow NewFinanceAgreementsRow()
    {
      return (dsAdminExpensePayees.FinanceAgreementsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdminExpensePayees.FinanceAgreementsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdminExpensePayees.FinanceAgreementsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FinanceAgreementsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminExpensePayees.FinanceAgreementsRowChangeEventHandler agreementsRowChangedEvent = this.FinanceAgreementsRowChangedEvent;
      if (agreementsRowChangedEvent == null)
        return;
      agreementsRowChangedEvent((object) this, new dsAdminExpensePayees.FinanceAgreementsRowChangeEvent((dsAdminExpensePayees.FinanceAgreementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FinanceAgreementsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminExpensePayees.FinanceAgreementsRowChangeEventHandler rowChangingEvent = this.FinanceAgreementsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAdminExpensePayees.FinanceAgreementsRowChangeEvent((dsAdminExpensePayees.FinanceAgreementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FinanceAgreementsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminExpensePayees.FinanceAgreementsRowChangeEventHandler agreementsRowDeletedEvent = this.FinanceAgreementsRowDeletedEvent;
      if (agreementsRowDeletedEvent == null)
        return;
      agreementsRowDeletedEvent((object) this, new dsAdminExpensePayees.FinanceAgreementsRowChangeEvent((dsAdminExpensePayees.FinanceAgreementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FinanceAgreementsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAdminExpensePayees.FinanceAgreementsRowChangeEventHandler rowDeletingEvent = this.FinanceAgreementsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAdminExpensePayees.FinanceAgreementsRowChangeEvent((dsAdminExpensePayees.FinanceAgreementsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveFinanceAgreementsRow(dsAdminExpensePayees.FinanceAgreementsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdminExpensePayees adminExpensePayees = new dsAdminExpensePayees();
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
        FixedValue = adminExpensePayees.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (FinanceAgreementsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = adminExpensePayees.GetSchemaSerializable();
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

  public class tblFin_ExpensePayeesRow : DataRow
  {
    private dsAdminExpensePayees.tblFin_ExpensePayeesDataTable tabletblFin_ExpensePayees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblFin_ExpensePayeesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblFin_ExpensePayees = (dsAdminExpensePayees.tblFin_ExpensePayeesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid PayeeGuid
    {
      get
      {
        object obj = this[this.tabletblFin_ExpensePayees.PayeeGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblFin_ExpensePayees.PayeeGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PayeeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_ExpensePayees.PayeeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PayeeName' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.PayeeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_ExpensePayees.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address1' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_ExpensePayees.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address2' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_ExpensePayees.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_ExpensePayees.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Zip
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_ExpensePayees.ZipColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Zip' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_ExpensePayees.ZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipPlus' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.ZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Phone1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_ExpensePayees.Phone1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Phone1' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.Phone1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Phone2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_ExpensePayees.Phone2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Phone2' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.Phone2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Fax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_ExpensePayees.FaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fax' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.FaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_ExpensePayees.EmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Email' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PayeeType
    {
      get => Conversions.ToString(this[this.tabletblFin_ExpensePayees.PayeeTypeColumn]);
      set => this[this.tabletblFin_ExpensePayees.PayeeTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool PayFromOperating
    {
      get => Conversions.ToBoolean(this[this.tabletblFin_ExpensePayees.PayFromOperatingColumn]);
      set => this[this.tabletblFin_ExpensePayees.PayFromOperatingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Hidden
    {
      get => Conversions.ToBoolean(this[this.tabletblFin_ExpensePayees.HiddenColumn]);
      set => this[this.tabletblFin_ExpensePayees.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string SSN
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_ExpensePayees.SSNColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SSN' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.SSNColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string TaxIdNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_ExpensePayees.TaxIdNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TaxIdNumber' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.TaxIdNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PayeeAcctNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_ExpensePayees.PayeeAcctNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PayeeAcctNum' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.PayeeAcctNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Is1099
    {
      get => Conversions.ToBoolean(this[this.tabletblFin_ExpensePayees.Is1099Column]);
      set => this[this.tabletblFin_ExpensePayees.Is1099Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ISOCountryCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_ExpensePayees.ISOCountryCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ISOCountryCode' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.ISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid AutomationReport
    {
      get
      {
        try
        {
          object obj = this[this.tabletblFin_ExpensePayees.AutomationReportColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AutomationReport' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.AutomationReportColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool RoofInspection
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblFin_ExpensePayees.RoofInspectionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RoofInspection' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.RoofInspectionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool MedicalProvider
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblFin_ExpensePayees.MedicalProviderColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MedicalProvider' in table 'tblFin_ExpensePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_ExpensePayees.MedicalProviderColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminExpensePayees.FinanceAgreementsRow FinanceAgreementsRow
    {
      get
      {
        return (dsAdminExpensePayees.FinanceAgreementsRow) this.GetParentRow(this.Table.ParentRelations["FinanceAgreements_tblFin_ExpensePayees"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["FinanceAgreements_tblFin_ExpensePayees"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPayeeNameNull() => this.IsNull(this.tabletblFin_ExpensePayees.PayeeNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPayeeNameNull()
    {
      this[this.tabletblFin_ExpensePayees.PayeeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddress1Null() => this.IsNull(this.tabletblFin_ExpensePayees.Address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabletblFin_ExpensePayees.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddress2Null() => this.IsNull(this.tabletblFin_ExpensePayees.Address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabletblFin_ExpensePayees.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabletblFin_ExpensePayees.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabletblFin_ExpensePayees.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabletblFin_ExpensePayees.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabletblFin_ExpensePayees.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsZipNull() => this.IsNull(this.tabletblFin_ExpensePayees.ZipColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetZipNull()
    {
      this[this.tabletblFin_ExpensePayees.ZipColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsZipPlusNull() => this.IsNull(this.tabletblFin_ExpensePayees.ZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetZipPlusNull()
    {
      this[this.tabletblFin_ExpensePayees.ZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPhone1Null() => this.IsNull(this.tabletblFin_ExpensePayees.Phone1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPhone1Null()
    {
      this[this.tabletblFin_ExpensePayees.Phone1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPhone2Null() => this.IsNull(this.tabletblFin_ExpensePayees.Phone2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPhone2Null()
    {
      this[this.tabletblFin_ExpensePayees.Phone2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFaxNull() => this.IsNull(this.tabletblFin_ExpensePayees.FaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFaxNull()
    {
      this[this.tabletblFin_ExpensePayees.FaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tabletblFin_ExpensePayees.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEmailNull()
    {
      this[this.tabletblFin_ExpensePayees.EmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSSNNull() => this.IsNull(this.tabletblFin_ExpensePayees.SSNColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSSNNull()
    {
      this[this.tabletblFin_ExpensePayees.SSNColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTaxIdNumberNull()
    {
      return this.IsNull(this.tabletblFin_ExpensePayees.TaxIdNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTaxIdNumberNull()
    {
      this[this.tabletblFin_ExpensePayees.TaxIdNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPayeeAcctNumNull()
    {
      return this.IsNull(this.tabletblFin_ExpensePayees.PayeeAcctNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPayeeAcctNumNull()
    {
      this[this.tabletblFin_ExpensePayees.PayeeAcctNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsISOCountryCodeNull()
    {
      return this.IsNull(this.tabletblFin_ExpensePayees.ISOCountryCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetISOCountryCodeNull()
    {
      this[this.tabletblFin_ExpensePayees.ISOCountryCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAutomationReportNull()
    {
      return this.IsNull(this.tabletblFin_ExpensePayees.AutomationReportColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAutomationReportNull()
    {
      this[this.tabletblFin_ExpensePayees.AutomationReportColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRoofInspectionNull()
    {
      return this.IsNull(this.tabletblFin_ExpensePayees.RoofInspectionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRoofInspectionNull()
    {
      this[this.tabletblFin_ExpensePayees.RoofInspectionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMedicalProviderNull()
    {
      return this.IsNull(this.tabletblFin_ExpensePayees.MedicalProviderColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMedicalProviderNull()
    {
      this[this.tabletblFin_ExpensePayees.MedicalProviderColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class FinanceAgreementsRow : DataRow
  {
    private dsAdminExpensePayees.FinanceAgreementsDataTable tableFinanceAgreements;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal FinanceAgreementsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableFinanceAgreements = (dsAdminExpensePayees.FinanceAgreementsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid AutomationReportGuid
    {
      get
      {
        object obj = this[this.tableFinanceAgreements.AutomationReportGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableFinanceAgreements.AutomationReportGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ReportName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableFinanceAgreements.ReportNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ReportName' in table 'FinanceAgreements' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFinanceAgreements.ReportNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsReportNameNull() => this.IsNull(this.tableFinanceAgreements.ReportNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetReportNameNull()
    {
      this[this.tableFinanceAgreements.ReportNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminExpensePayees.tblFin_ExpensePayeesRow[] GettblFin_ExpensePayeesRows()
    {
      return this.Table.ChildRelations["FinanceAgreements_tblFin_ExpensePayees"] != null ? (dsAdminExpensePayees.tblFin_ExpensePayeesRow[]) this.GetChildRows(this.Table.ChildRelations["FinanceAgreements_tblFin_ExpensePayees"]) : new dsAdminExpensePayees.tblFin_ExpensePayeesRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblFin_ExpensePayeesRowChangeEvent : EventArgs
  {
    private dsAdminExpensePayees.tblFin_ExpensePayeesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblFin_ExpensePayeesRowChangeEvent(
      dsAdminExpensePayees.tblFin_ExpensePayeesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminExpensePayees.tblFin_ExpensePayeesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class FinanceAgreementsRowChangeEvent : EventArgs
  {
    private dsAdminExpensePayees.FinanceAgreementsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public FinanceAgreementsRowChangeEvent(
      dsAdminExpensePayees.FinanceAgreementsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsAdminExpensePayees.FinanceAgreementsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
