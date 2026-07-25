// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Invoices.dsInvoice
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
namespace MGASystems.IMS.Policies.Invoices;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsInvoice")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsInvoice : DataSet
{
  private dsInvoice.InvoiceHeaderDataTable tableInvoiceHeader;
  private dsInvoice.InvoiceDetailsDataTable tableInvoiceDetails;
  private dsInvoice.InvoicePayeesDataTable tableInvoicePayees;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsInvoice()
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
  protected dsInvoice(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (InvoiceHeader)] != null)
          base.Tables.Add((DataTable) new dsInvoice.InvoiceHeaderDataTable(dataSet.Tables[nameof (InvoiceHeader)]));
        if (dataSet.Tables[nameof (InvoiceDetails)] != null)
          base.Tables.Add((DataTable) new dsInvoice.InvoiceDetailsDataTable(dataSet.Tables[nameof (InvoiceDetails)]));
        if (dataSet.Tables[nameof (InvoicePayees)] != null)
          base.Tables.Add((DataTable) new dsInvoice.InvoicePayeesDataTable(dataSet.Tables[nameof (InvoicePayees)]));
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
  public dsInvoice.InvoiceHeaderDataTable InvoiceHeader => this.tableInvoiceHeader;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInvoice.InvoiceDetailsDataTable InvoiceDetails => this.tableInvoiceDetails;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInvoice.InvoicePayeesDataTable InvoicePayees => this.tableInvoicePayees;

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
    dsInvoice dsInvoice = (dsInvoice) base.Clone();
    dsInvoice.InitVars();
    dsInvoice.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsInvoice;
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
      if (dataSet.Tables["InvoiceHeader"] != null)
        base.Tables.Add((DataTable) new dsInvoice.InvoiceHeaderDataTable(dataSet.Tables["InvoiceHeader"]));
      if (dataSet.Tables["InvoiceDetails"] != null)
        base.Tables.Add((DataTable) new dsInvoice.InvoiceDetailsDataTable(dataSet.Tables["InvoiceDetails"]));
      if (dataSet.Tables["InvoicePayees"] != null)
        base.Tables.Add((DataTable) new dsInvoice.InvoicePayeesDataTable(dataSet.Tables["InvoicePayees"]));
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
    this.tableInvoiceHeader = (dsInvoice.InvoiceHeaderDataTable) base.Tables["InvoiceHeader"];
    if (initTable && this.tableInvoiceHeader != null)
      this.tableInvoiceHeader.InitVars();
    this.tableInvoiceDetails = (dsInvoice.InvoiceDetailsDataTable) base.Tables["InvoiceDetails"];
    if (initTable && this.tableInvoiceDetails != null)
      this.tableInvoiceDetails.InitVars();
    this.tableInvoicePayees = (dsInvoice.InvoicePayeesDataTable) base.Tables["InvoicePayees"];
    if (!initTable || this.tableInvoicePayees == null)
      return;
    this.tableInvoicePayees.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsInvoice);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsInvoice.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableInvoiceHeader = new dsInvoice.InvoiceHeaderDataTable();
    base.Tables.Add((DataTable) this.tableInvoiceHeader);
    this.tableInvoiceDetails = new dsInvoice.InvoiceDetailsDataTable();
    base.Tables.Add((DataTable) this.tableInvoiceDetails);
    this.tableInvoicePayees = new dsInvoice.InvoicePayeesDataTable();
    base.Tables.Add((DataTable) this.tableInvoicePayees);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeInvoiceHeader() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeInvoiceDetails() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeInvoicePayees() => false;

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
    dsInvoice dsInvoice = new dsInvoice();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsInvoice.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsInvoice.GetSchemaSerializable();
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
  public delegate void InvoiceHeaderRowChangeEventHandler(
    object sender,
    dsInvoice.InvoiceHeaderRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void InvoiceDetailsRowChangeEventHandler(
    object sender,
    dsInvoice.InvoiceDetailsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void InvoicePayeesRowChangeEventHandler(
    object sender,
    dsInvoice.InvoicePayeesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class InvoiceHeaderDataTable : TypedTableBase<dsInvoice.InvoiceHeaderRow>
  {
    private DataColumn columnGLCOMPANYID;
    private DataColumn columnInvoice_Number;
    private DataColumn columnUnderwriter;
    private DataColumn columnEFFECTIVEDATE;
    private DataColumn columnEXPIRATIONDATE;
    private DataColumn columnCompanyAddress;
    private DataColumn columnRemitterName;
    private DataColumn columnRemitterAddress;
    private DataColumn columnReferenceName;
    private DataColumn columnCompanyName;
    private DataColumn columninvoicedate;
    private DataColumn columnpolicyNumber;
    private DataColumn columnDUEDATE;
    private DataColumn columnClientOfficePhone;
    private DataColumn columnClientOfficeName;
    private DataColumn columnClientOfficeLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public InvoiceHeaderDataTable()
    {
      this.TableName = "InvoiceHeader";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal InvoiceHeaderDataTable(DataTable table)
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
    protected InvoiceHeaderDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GLCOMPANYIDColumn => this.columnGLCOMPANYID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn Invoice_NumberColumn => this.columnInvoice_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UnderwriterColumn => this.columnUnderwriter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EFFECTIVEDATEColumn => this.columnEFFECTIVEDATE;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EXPIRATIONDATEColumn => this.columnEXPIRATIONDATE;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyAddressColumn => this.columnCompanyAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RemitterNameColumn => this.columnRemitterName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RemitterAddressColumn => this.columnRemitterAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ReferenceNameColumn => this.columnReferenceName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyNameColumn => this.columnCompanyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn invoicedateColumn => this.columninvoicedate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn policyNumberColumn => this.columnpolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DUEDATEColumn => this.columnDUEDATE;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClientOfficePhoneColumn => this.columnClientOfficePhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClientOfficeNameColumn => this.columnClientOfficeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClientOfficeLocationColumn => this.columnClientOfficeLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoice.InvoiceHeaderRow this[int index]
    {
      get => (dsInvoice.InvoiceHeaderRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoice.InvoiceHeaderRowChangeEventHandler InvoiceHeaderRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoice.InvoiceHeaderRowChangeEventHandler InvoiceHeaderRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoice.InvoiceHeaderRowChangeEventHandler InvoiceHeaderRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoice.InvoiceHeaderRowChangeEventHandler InvoiceHeaderRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddInvoiceHeaderRow(dsInvoice.InvoiceHeaderRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoice.InvoiceHeaderRow AddInvoiceHeaderRow(
      int GLCOMPANYID,
      int Invoice_Number,
      string Underwriter,
      DateTime EFFECTIVEDATE,
      DateTime EXPIRATIONDATE,
      string CompanyAddress,
      string RemitterName,
      string RemitterAddress,
      string ReferenceName,
      string CompanyName,
      DateTime invoicedate,
      int policyNumber,
      DateTime DUEDATE,
      string ClientOfficePhone,
      string ClientOfficeName,
      string ClientOfficeLocation)
    {
      dsInvoice.InvoiceHeaderRow row = (dsInvoice.InvoiceHeaderRow) this.NewRow();
      object[] objArray = new object[16 /*0x10*/]
      {
        (object) GLCOMPANYID,
        (object) Invoice_Number,
        (object) Underwriter,
        (object) EFFECTIVEDATE,
        (object) EXPIRATIONDATE,
        (object) CompanyAddress,
        (object) RemitterName,
        (object) RemitterAddress,
        (object) ReferenceName,
        (object) CompanyName,
        (object) invoicedate,
        (object) policyNumber,
        (object) DUEDATE,
        (object) ClientOfficePhone,
        (object) ClientOfficeName,
        (object) ClientOfficeLocation
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInvoice.InvoiceHeaderDataTable invoiceHeaderDataTable = (dsInvoice.InvoiceHeaderDataTable) base.Clone();
      invoiceHeaderDataTable.InitVars();
      return (DataTable) invoiceHeaderDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInvoice.InvoiceHeaderDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnGLCOMPANYID = this.Columns["GLCOMPANYID"];
      this.columnInvoice_Number = this.Columns["Invoice Number"];
      this.columnUnderwriter = this.Columns["Underwriter"];
      this.columnEFFECTIVEDATE = this.Columns["EFFECTIVEDATE"];
      this.columnEXPIRATIONDATE = this.Columns["EXPIRATIONDATE"];
      this.columnCompanyAddress = this.Columns["CompanyAddress"];
      this.columnRemitterName = this.Columns["RemitterName"];
      this.columnRemitterAddress = this.Columns["RemitterAddress"];
      this.columnReferenceName = this.Columns["ReferenceName"];
      this.columnCompanyName = this.Columns["CompanyName"];
      this.columninvoicedate = this.Columns["invoicedate"];
      this.columnpolicyNumber = this.Columns["policyNumber"];
      this.columnDUEDATE = this.Columns["DUEDATE"];
      this.columnClientOfficePhone = this.Columns["ClientOfficePhone"];
      this.columnClientOfficeName = this.Columns["ClientOfficeName"];
      this.columnClientOfficeLocation = this.Columns["ClientOfficeLocation"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnGLCOMPANYID = new DataColumn("GLCOMPANYID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLCOMPANYID);
      this.columnInvoice_Number = new DataColumn("Invoice Number", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoice_Number);
      this.columnUnderwriter = new DataColumn("Underwriter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriter);
      this.columnEFFECTIVEDATE = new DataColumn("EFFECTIVEDATE", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEFFECTIVEDATE);
      this.columnEXPIRATIONDATE = new DataColumn("EXPIRATIONDATE", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEXPIRATIONDATE);
      this.columnCompanyAddress = new DataColumn("CompanyAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyAddress);
      this.columnRemitterName = new DataColumn("RemitterName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitterName);
      this.columnRemitterAddress = new DataColumn("RemitterAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitterAddress);
      this.columnReferenceName = new DataColumn("ReferenceName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReferenceName);
      this.columnCompanyName = new DataColumn("CompanyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyName);
      this.columninvoicedate = new DataColumn("invoicedate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columninvoicedate);
      this.columnpolicyNumber = new DataColumn("policyNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpolicyNumber);
      this.columnDUEDATE = new DataColumn("DUEDATE", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDUEDATE);
      this.columnClientOfficePhone = new DataColumn("ClientOfficePhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClientOfficePhone);
      this.columnClientOfficeName = new DataColumn("ClientOfficeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClientOfficeName);
      this.columnClientOfficeLocation = new DataColumn("ClientOfficeLocation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClientOfficeLocation);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoice.InvoiceHeaderRow NewInvoiceHeaderRow()
    {
      return (dsInvoice.InvoiceHeaderRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInvoice.InvoiceHeaderRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInvoice.InvoiceHeaderRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceHeaderRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoice.InvoiceHeaderRowChangeEventHandler headerRowChangedEvent = this.InvoiceHeaderRowChangedEvent;
      if (headerRowChangedEvent == null)
        return;
      headerRowChangedEvent((object) this, new dsInvoice.InvoiceHeaderRowChangeEvent((dsInvoice.InvoiceHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceHeaderRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoice.InvoiceHeaderRowChangeEventHandler rowChangingEvent = this.InvoiceHeaderRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInvoice.InvoiceHeaderRowChangeEvent((dsInvoice.InvoiceHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceHeaderRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoice.InvoiceHeaderRowChangeEventHandler headerRowDeletedEvent = this.InvoiceHeaderRowDeletedEvent;
      if (headerRowDeletedEvent == null)
        return;
      headerRowDeletedEvent((object) this, new dsInvoice.InvoiceHeaderRowChangeEvent((dsInvoice.InvoiceHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceHeaderRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoice.InvoiceHeaderRowChangeEventHandler rowDeletingEvent = this.InvoiceHeaderRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInvoice.InvoiceHeaderRowChangeEvent((dsInvoice.InvoiceHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveInvoiceHeaderRow(dsInvoice.InvoiceHeaderRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInvoice dsInvoice = new dsInvoice();
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
        FixedValue = dsInvoice.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvoiceHeaderDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInvoice.GetSchemaSerializable();
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
  public class InvoiceDetailsDataTable : TypedTableBase<dsInvoice.InvoiceDetailsRow>
  {
    private DataColumn columnDescription;
    private DataColumn columnREMITTERPERCENTRATE;
    private DataColumn columnAMTBILLED;
    private DataColumn columnNetDue;
    private DataColumn columnREMITTERAMT;
    private DataColumn columnMGAAMT;
    private DataColumn columnChargeType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public InvoiceDetailsDataTable()
    {
      this.TableName = "InvoiceDetails";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal InvoiceDetailsDataTable(DataTable table)
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
    protected InvoiceDetailsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn REMITTERPERCENTRATEColumn => this.columnREMITTERPERCENTRATE;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AMTBILLEDColumn => this.columnAMTBILLED;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NetDueColumn => this.columnNetDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn REMITTERAMTColumn => this.columnREMITTERAMT;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MGAAMTColumn => this.columnMGAAMT;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeTypeColumn => this.columnChargeType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoice.InvoiceDetailsRow this[int index]
    {
      get => (dsInvoice.InvoiceDetailsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoice.InvoiceDetailsRowChangeEventHandler InvoiceDetailsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoice.InvoiceDetailsRowChangeEventHandler InvoiceDetailsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoice.InvoiceDetailsRowChangeEventHandler InvoiceDetailsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoice.InvoiceDetailsRowChangeEventHandler InvoiceDetailsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddInvoiceDetailsRow(dsInvoice.InvoiceDetailsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoice.InvoiceDetailsRow AddInvoiceDetailsRow(
      string Description,
      Decimal REMITTERPERCENTRATE,
      Decimal AMTBILLED,
      Decimal NetDue,
      Decimal REMITTERAMT,
      Decimal MGAAMT,
      string ChargeType)
    {
      dsInvoice.InvoiceDetailsRow row = (dsInvoice.InvoiceDetailsRow) this.NewRow();
      object[] objArray = new object[7]
      {
        (object) Description,
        (object) REMITTERPERCENTRATE,
        (object) AMTBILLED,
        (object) NetDue,
        (object) REMITTERAMT,
        (object) MGAAMT,
        (object) ChargeType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInvoice.InvoiceDetailsDataTable detailsDataTable = (dsInvoice.InvoiceDetailsDataTable) base.Clone();
      detailsDataTable.InitVars();
      return (DataTable) detailsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInvoice.InvoiceDetailsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnDescription = this.Columns["Description"];
      this.columnREMITTERPERCENTRATE = this.Columns["REMITTERPERCENTRATE"];
      this.columnAMTBILLED = this.Columns["AMTBILLED"];
      this.columnNetDue = this.Columns["NetDue"];
      this.columnREMITTERAMT = this.Columns["REMITTERAMT"];
      this.columnMGAAMT = this.Columns["MGAAMT"];
      this.columnChargeType = this.Columns["ChargeType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnREMITTERPERCENTRATE = new DataColumn("REMITTERPERCENTRATE", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnREMITTERPERCENTRATE);
      this.columnAMTBILLED = new DataColumn("AMTBILLED", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAMTBILLED);
      this.columnNetDue = new DataColumn("NetDue", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetDue);
      this.columnREMITTERAMT = new DataColumn("REMITTERAMT", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnREMITTERAMT);
      this.columnMGAAMT = new DataColumn("MGAAMT", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMGAAMT);
      this.columnChargeType = new DataColumn("ChargeType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeType);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoice.InvoiceDetailsRow NewInvoiceDetailsRow()
    {
      return (dsInvoice.InvoiceDetailsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInvoice.InvoiceDetailsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInvoice.InvoiceDetailsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceDetailsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoice.InvoiceDetailsRowChangeEventHandler detailsRowChangedEvent = this.InvoiceDetailsRowChangedEvent;
      if (detailsRowChangedEvent == null)
        return;
      detailsRowChangedEvent((object) this, new dsInvoice.InvoiceDetailsRowChangeEvent((dsInvoice.InvoiceDetailsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceDetailsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoice.InvoiceDetailsRowChangeEventHandler rowChangingEvent = this.InvoiceDetailsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInvoice.InvoiceDetailsRowChangeEvent((dsInvoice.InvoiceDetailsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceDetailsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoice.InvoiceDetailsRowChangeEventHandler detailsRowDeletedEvent = this.InvoiceDetailsRowDeletedEvent;
      if (detailsRowDeletedEvent == null)
        return;
      detailsRowDeletedEvent((object) this, new dsInvoice.InvoiceDetailsRowChangeEvent((dsInvoice.InvoiceDetailsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceDetailsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoice.InvoiceDetailsRowChangeEventHandler rowDeletingEvent = this.InvoiceDetailsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInvoice.InvoiceDetailsRowChangeEvent((dsInvoice.InvoiceDetailsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveInvoiceDetailsRow(dsInvoice.InvoiceDetailsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInvoice dsInvoice = new dsInvoice();
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
        FixedValue = dsInvoice.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvoiceDetailsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInvoice.GetSchemaSerializable();
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
  public class InvoicePayeesDataTable : TypedTableBase<dsInvoice.InvoicePayeesRow>
  {
    private DataColumn columnCompanyLineDesc;
    private DataColumn columnDisplayName;
    private DataColumn columnPAYEEPERCENTRATE;
    private DataColumn columnPAYEEAMT;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public InvoicePayeesDataTable()
    {
      this.TableName = "InvoicePayees";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal InvoicePayeesDataTable(DataTable table)
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
    protected InvoicePayeesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLineDescColumn => this.columnCompanyLineDesc;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisplayNameColumn => this.columnDisplayName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PAYEEPERCENTRATEColumn => this.columnPAYEEPERCENTRATE;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PAYEEAMTColumn => this.columnPAYEEAMT;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoice.InvoicePayeesRow this[int index]
    {
      get => (dsInvoice.InvoicePayeesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoice.InvoicePayeesRowChangeEventHandler InvoicePayeesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoice.InvoicePayeesRowChangeEventHandler InvoicePayeesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoice.InvoicePayeesRowChangeEventHandler InvoicePayeesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoice.InvoicePayeesRowChangeEventHandler InvoicePayeesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddInvoicePayeesRow(dsInvoice.InvoicePayeesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoice.InvoicePayeesRow AddInvoicePayeesRow(
      string CompanyLineDesc,
      string DisplayName,
      Decimal PAYEEPERCENTRATE,
      Decimal PAYEEAMT)
    {
      dsInvoice.InvoicePayeesRow row = (dsInvoice.InvoicePayeesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) CompanyLineDesc,
        (object) DisplayName,
        (object) PAYEEPERCENTRATE,
        (object) PAYEEAMT
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInvoice.InvoicePayeesDataTable invoicePayeesDataTable = (dsInvoice.InvoicePayeesDataTable) base.Clone();
      invoicePayeesDataTable.InitVars();
      return (DataTable) invoicePayeesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInvoice.InvoicePayeesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLineDesc = this.Columns["CompanyLineDesc"];
      this.columnDisplayName = this.Columns["DisplayName"];
      this.columnPAYEEPERCENTRATE = this.Columns["PAYEEPERCENTRATE"];
      this.columnPAYEEAMT = this.Columns["PAYEEAMT"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLineDesc = new DataColumn("CompanyLineDesc", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineDesc);
      this.columnDisplayName = new DataColumn("DisplayName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisplayName);
      this.columnPAYEEPERCENTRATE = new DataColumn("PAYEEPERCENTRATE", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPAYEEPERCENTRATE);
      this.columnPAYEEAMT = new DataColumn("PAYEEAMT", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPAYEEAMT);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoice.InvoicePayeesRow NewInvoicePayeesRow()
    {
      return (dsInvoice.InvoicePayeesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInvoice.InvoicePayeesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInvoice.InvoicePayeesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicePayeesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoice.InvoicePayeesRowChangeEventHandler payeesRowChangedEvent = this.InvoicePayeesRowChangedEvent;
      if (payeesRowChangedEvent == null)
        return;
      payeesRowChangedEvent((object) this, new dsInvoice.InvoicePayeesRowChangeEvent((dsInvoice.InvoicePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicePayeesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoice.InvoicePayeesRowChangeEventHandler rowChangingEvent = this.InvoicePayeesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInvoice.InvoicePayeesRowChangeEvent((dsInvoice.InvoicePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicePayeesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoice.InvoicePayeesRowChangeEventHandler payeesRowDeletedEvent = this.InvoicePayeesRowDeletedEvent;
      if (payeesRowDeletedEvent == null)
        return;
      payeesRowDeletedEvent((object) this, new dsInvoice.InvoicePayeesRowChangeEvent((dsInvoice.InvoicePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicePayeesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoice.InvoicePayeesRowChangeEventHandler rowDeletingEvent = this.InvoicePayeesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInvoice.InvoicePayeesRowChangeEvent((dsInvoice.InvoicePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveInvoicePayeesRow(dsInvoice.InvoicePayeesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInvoice dsInvoice = new dsInvoice();
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
        FixedValue = dsInvoice.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvoicePayeesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInvoice.GetSchemaSerializable();
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

  public class InvoiceHeaderRow : DataRow
  {
    private dsInvoice.InvoiceHeaderDataTable tableInvoiceHeader;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal InvoiceHeaderRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoiceHeader = (dsInvoice.InvoiceHeaderDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int GLCOMPANYID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInvoiceHeader.GLCOMPANYIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GLCOMPANYID' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.GLCOMPANYIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int Invoice_Number
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInvoiceHeader.Invoice_NumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Invoice Number' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.Invoice_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Underwriter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceHeader.UnderwriterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Underwriter' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.UnderwriterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime EFFECTIVEDATE
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoiceHeader.EFFECTIVEDATEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EFFECTIVEDATE' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.EFFECTIVEDATEColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime EXPIRATIONDATE
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoiceHeader.EXPIRATIONDATEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EXPIRATIONDATE' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.EXPIRATIONDATEColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CompanyAddress
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceHeader.CompanyAddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyAddress' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.CompanyAddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string RemitterName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceHeader.RemitterNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RemitterName' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.RemitterNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string RemitterAddress
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceHeader.RemitterAddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RemitterAddress' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.RemitterAddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ReferenceName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceHeader.ReferenceNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ReferenceName' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.ReferenceNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CompanyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceHeader.CompanyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyName' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.CompanyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime invoicedate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoiceHeader.invoicedateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'invoicedate' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.invoicedateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int policyNumber
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInvoiceHeader.policyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'policyNumber' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.policyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DUEDATE
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoiceHeader.DUEDATEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DUEDATE' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.DUEDATEColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ClientOfficePhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceHeader.ClientOfficePhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClientOfficePhone' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.ClientOfficePhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ClientOfficeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceHeader.ClientOfficeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClientOfficeName' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.ClientOfficeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ClientOfficeLocation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceHeader.ClientOfficeLocationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClientOfficeLocation' in table 'InvoiceHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceHeader.ClientOfficeLocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsGLCOMPANYIDNull() => this.IsNull(this.tableInvoiceHeader.GLCOMPANYIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetGLCOMPANYIDNull()
    {
      this[this.tableInvoiceHeader.GLCOMPANYIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInvoice_NumberNull() => this.IsNull(this.tableInvoiceHeader.Invoice_NumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInvoice_NumberNull()
    {
      this[this.tableInvoiceHeader.Invoice_NumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUnderwriterNull() => this.IsNull(this.tableInvoiceHeader.UnderwriterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUnderwriterNull()
    {
      this[this.tableInvoiceHeader.UnderwriterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEFFECTIVEDATENull() => this.IsNull(this.tableInvoiceHeader.EFFECTIVEDATEColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEFFECTIVEDATENull()
    {
      this[this.tableInvoiceHeader.EFFECTIVEDATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEXPIRATIONDATENull() => this.IsNull(this.tableInvoiceHeader.EXPIRATIONDATEColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEXPIRATIONDATENull()
    {
      this[this.tableInvoiceHeader.EXPIRATIONDATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyAddressNull() => this.IsNull(this.tableInvoiceHeader.CompanyAddressColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyAddressNull()
    {
      this[this.tableInvoiceHeader.CompanyAddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRemitterNameNull() => this.IsNull(this.tableInvoiceHeader.RemitterNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRemitterNameNull()
    {
      this[this.tableInvoiceHeader.RemitterNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRemitterAddressNull()
    {
      return this.IsNull(this.tableInvoiceHeader.RemitterAddressColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRemitterAddressNull()
    {
      this[this.tableInvoiceHeader.RemitterAddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsReferenceNameNull() => this.IsNull(this.tableInvoiceHeader.ReferenceNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetReferenceNameNull()
    {
      this[this.tableInvoiceHeader.ReferenceNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyNameNull() => this.IsNull(this.tableInvoiceHeader.CompanyNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyNameNull()
    {
      this[this.tableInvoiceHeader.CompanyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsinvoicedateNull() => this.IsNull(this.tableInvoiceHeader.invoicedateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetinvoicedateNull()
    {
      this[this.tableInvoiceHeader.invoicedateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IspolicyNumberNull() => this.IsNull(this.tableInvoiceHeader.policyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetpolicyNumberNull()
    {
      this[this.tableInvoiceHeader.policyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDUEDATENull() => this.IsNull(this.tableInvoiceHeader.DUEDATEColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDUEDATENull()
    {
      this[this.tableInvoiceHeader.DUEDATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClientOfficePhoneNull()
    {
      return this.IsNull(this.tableInvoiceHeader.ClientOfficePhoneColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClientOfficePhoneNull()
    {
      this[this.tableInvoiceHeader.ClientOfficePhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClientOfficeNameNull()
    {
      return this.IsNull(this.tableInvoiceHeader.ClientOfficeNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClientOfficeNameNull()
    {
      this[this.tableInvoiceHeader.ClientOfficeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClientOfficeLocationNull()
    {
      return this.IsNull(this.tableInvoiceHeader.ClientOfficeLocationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClientOfficeLocationNull()
    {
      this[this.tableInvoiceHeader.ClientOfficeLocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class InvoiceDetailsRow : DataRow
  {
    private dsInvoice.InvoiceDetailsDataTable tableInvoiceDetails;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal InvoiceDetailsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoiceDetails = (dsInvoice.InvoiceDetailsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceDetails.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'InvoiceDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceDetails.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal REMITTERPERCENTRATE
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceDetails.REMITTERPERCENTRATEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'REMITTERPERCENTRATE' in table 'InvoiceDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceDetails.REMITTERPERCENTRATEColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal AMTBILLED
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceDetails.AMTBILLEDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AMTBILLED' in table 'InvoiceDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceDetails.AMTBILLEDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal NetDue
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceDetails.NetDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NetDue' in table 'InvoiceDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceDetails.NetDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal REMITTERAMT
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceDetails.REMITTERAMTColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'REMITTERAMT' in table 'InvoiceDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceDetails.REMITTERAMTColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal MGAAMT
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceDetails.MGAAMTColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MGAAMT' in table 'InvoiceDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceDetails.MGAAMTColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ChargeType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceDetails.ChargeTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeType' in table 'InvoiceDetails' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceDetails.ChargeTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tableInvoiceDetails.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tableInvoiceDetails.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsREMITTERPERCENTRATENull()
    {
      return this.IsNull(this.tableInvoiceDetails.REMITTERPERCENTRATEColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetREMITTERPERCENTRATENull()
    {
      this[this.tableInvoiceDetails.REMITTERPERCENTRATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAMTBILLEDNull() => this.IsNull(this.tableInvoiceDetails.AMTBILLEDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAMTBILLEDNull()
    {
      this[this.tableInvoiceDetails.AMTBILLEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNetDueNull() => this.IsNull(this.tableInvoiceDetails.NetDueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNetDueNull()
    {
      this[this.tableInvoiceDetails.NetDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsREMITTERAMTNull() => this.IsNull(this.tableInvoiceDetails.REMITTERAMTColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetREMITTERAMTNull()
    {
      this[this.tableInvoiceDetails.REMITTERAMTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMGAAMTNull() => this.IsNull(this.tableInvoiceDetails.MGAAMTColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMGAAMTNull()
    {
      this[this.tableInvoiceDetails.MGAAMTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsChargeTypeNull() => this.IsNull(this.tableInvoiceDetails.ChargeTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetChargeTypeNull()
    {
      this[this.tableInvoiceDetails.ChargeTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class InvoicePayeesRow : DataRow
  {
    private dsInvoice.InvoicePayeesDataTable tableInvoicePayees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal InvoicePayeesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoicePayees = (dsInvoice.InvoicePayeesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CompanyLineDesc
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoicePayees.CompanyLineDescColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLineDesc' in table 'InvoicePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoicePayees.CompanyLineDescColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DisplayName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoicePayees.DisplayNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DisplayName' in table 'InvoicePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoicePayees.DisplayNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal PAYEEPERCENTRATE
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoicePayees.PAYEEPERCENTRATEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PAYEEPERCENTRATE' in table 'InvoicePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoicePayees.PAYEEPERCENTRATEColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal PAYEEAMT
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoicePayees.PAYEEAMTColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PAYEEAMT' in table 'InvoicePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoicePayees.PAYEEAMTColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyLineDescNull()
    {
      return this.IsNull(this.tableInvoicePayees.CompanyLineDescColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyLineDescNull()
    {
      this[this.tableInvoicePayees.CompanyLineDescColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDisplayNameNull() => this.IsNull(this.tableInvoicePayees.DisplayNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDisplayNameNull()
    {
      this[this.tableInvoicePayees.DisplayNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPAYEEPERCENTRATENull()
    {
      return this.IsNull(this.tableInvoicePayees.PAYEEPERCENTRATEColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPAYEEPERCENTRATENull()
    {
      this[this.tableInvoicePayees.PAYEEPERCENTRATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPAYEEAMTNull() => this.IsNull(this.tableInvoicePayees.PAYEEAMTColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPAYEEAMTNull()
    {
      this[this.tableInvoicePayees.PAYEEAMTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class InvoiceHeaderRowChangeEvent : EventArgs
  {
    private dsInvoice.InvoiceHeaderRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public InvoiceHeaderRowChangeEvent(dsInvoice.InvoiceHeaderRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoice.InvoiceHeaderRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class InvoiceDetailsRowChangeEvent : EventArgs
  {
    private dsInvoice.InvoiceDetailsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public InvoiceDetailsRowChangeEvent(dsInvoice.InvoiceDetailsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoice.InvoiceDetailsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class InvoicePayeesRowChangeEvent : EventArgs
  {
    private dsInvoice.InvoicePayeesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public InvoicePayeesRowChangeEvent(dsInvoice.InvoicePayeesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoice.InvoicePayeesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
