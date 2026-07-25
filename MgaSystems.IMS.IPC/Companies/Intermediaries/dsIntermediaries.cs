// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.Intermediaries.dsIntermediaries
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies.Intermediaries;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsIntermediaries")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsIntermediaries : DataSet
{
  private dsIntermediaries.tblIntermediariesDataTable tabletblIntermediaries;
  private dsIntermediaries.tblIntermediaryContactsDataTable tabletblIntermediaryContacts;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsIntermediaries()
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
  protected dsIntermediaries(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblIntermediaries)] != null)
          base.Tables.Add((DataTable) new dsIntermediaries.tblIntermediariesDataTable(dataSet.Tables[nameof (tblIntermediaries)]));
        if (dataSet.Tables[nameof (tblIntermediaryContacts)] != null)
          base.Tables.Add((DataTable) new dsIntermediaries.tblIntermediaryContactsDataTable(dataSet.Tables[nameof (tblIntermediaryContacts)]));
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
  public dsIntermediaries.tblIntermediariesDataTable tblIntermediaries
  {
    get => this.tabletblIntermediaries;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsIntermediaries.tblIntermediaryContactsDataTable tblIntermediaryContacts
  {
    get => this.tabletblIntermediaryContacts;
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
    dsIntermediaries dsIntermediaries = (dsIntermediaries) base.Clone();
    dsIntermediaries.InitVars();
    dsIntermediaries.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsIntermediaries;
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
      if (dataSet.Tables["tblIntermediaries"] != null)
        base.Tables.Add((DataTable) new dsIntermediaries.tblIntermediariesDataTable(dataSet.Tables["tblIntermediaries"]));
      if (dataSet.Tables["tblIntermediaryContacts"] != null)
        base.Tables.Add((DataTable) new dsIntermediaries.tblIntermediaryContactsDataTable(dataSet.Tables["tblIntermediaryContacts"]));
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
    this.tabletblIntermediaries = (dsIntermediaries.tblIntermediariesDataTable) base.Tables["tblIntermediaries"];
    if (initTable && this.tabletblIntermediaries != null)
      this.tabletblIntermediaries.InitVars();
    this.tabletblIntermediaryContacts = (dsIntermediaries.tblIntermediaryContactsDataTable) base.Tables["tblIntermediaryContacts"];
    if (!initTable || this.tabletblIntermediaryContacts == null)
      return;
    this.tabletblIntermediaryContacts.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsIntermediaries);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsIntermediaries.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblIntermediaries = new dsIntermediaries.tblIntermediariesDataTable();
    base.Tables.Add((DataTable) this.tabletblIntermediaries);
    this.tabletblIntermediaryContacts = new dsIntermediaries.tblIntermediaryContactsDataTable();
    base.Tables.Add((DataTable) this.tabletblIntermediaryContacts);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblIntermediaries() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblIntermediaryContacts() => false;

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
    dsIntermediaries dsIntermediaries = new dsIntermediaries();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsIntermediaries.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsIntermediaries.GetSchemaSerializable();
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
  public delegate void tblIntermediariesRowChangeEventHandler(
    object sender,
    dsIntermediaries.tblIntermediariesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblIntermediaryContactsRowChangeEventHandler(
    object sender,
    dsIntermediaries.tblIntermediaryContactsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblIntermediariesDataTable : TypedTableBase<dsIntermediaries.tblIntermediariesRow>
  {
    private DataColumn columnIntermediaryGuid;
    private DataColumn columnIntermediaryName;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnCounty;
    private DataColumn columnState;
    private DataColumn columnZipCode;
    private DataColumn columnZipPlus;
    private DataColumn columnPhone;
    private DataColumn columnFax;
    private DataColumn columnWebSite;
    private DataColumn columnISOCountryCode;
    private DataColumn columnRegion;
    private DataColumn columnIntermediaryID;
    private DataColumn columnEmail;
    private DataColumn columnBillingSameAsPrimary;
    private DataColumn columnBillingAddress1;
    private DataColumn columnBillingAddress2;
    private DataColumn columnBillingCity;
    private DataColumn columnBillingCounty;
    private DataColumn columnBillingState;
    private DataColumn columnBillingZipCode;
    private DataColumn columnBillingZipPlus;
    private DataColumn columnBillingRegion;
    private DataColumn columnBillingISOCountryCode;
    private DataColumn columnNAIC;
    private DataColumn columnCountryCodeforPhone;
    private DataColumn columnCountryCodeforFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblIntermediariesDataTable()
    {
      this.TableName = "tblIntermediaries";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblIntermediariesDataTable(DataTable table)
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
    protected tblIntermediariesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IntermediaryGuidColumn => this.columnIntermediaryGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IntermediaryNameColumn => this.columnIntermediaryName;

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
    public DataColumn CountyColumn => this.columnCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ZipPlusColumn => this.columnZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PhoneColumn => this.columnPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FaxColumn => this.columnFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn WebSiteColumn => this.columnWebSite;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ISOCountryCodeColumn => this.columnISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RegionColumn => this.columnRegion;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IntermediaryIDColumn => this.columnIntermediaryID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BillingSameAsPrimaryColumn => this.columnBillingSameAsPrimary;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BillingAddress1Column => this.columnBillingAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BillingAddress2Column => this.columnBillingAddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BillingCityColumn => this.columnBillingCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BillingCountyColumn => this.columnBillingCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BillingStateColumn => this.columnBillingState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BillingZipCodeColumn => this.columnBillingZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BillingZipPlusColumn => this.columnBillingZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BillingRegionColumn => this.columnBillingRegion;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BillingISOCountryCodeColumn => this.columnBillingISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NAICColumn => this.columnNAIC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CountryCodeforPhoneColumn => this.columnCountryCodeforPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CountryCodeforFaxColumn => this.columnCountryCodeforFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIntermediaries.tblIntermediariesRow this[int index]
    {
      get => (dsIntermediaries.tblIntermediariesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIntermediaries.tblIntermediariesRowChangeEventHandler tblIntermediariesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIntermediaries.tblIntermediariesRowChangeEventHandler tblIntermediariesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIntermediaries.tblIntermediariesRowChangeEventHandler tblIntermediariesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIntermediaries.tblIntermediariesRowChangeEventHandler tblIntermediariesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblIntermediariesRow(dsIntermediaries.tblIntermediariesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIntermediaries.tblIntermediariesRow AddtblIntermediariesRow(
      Guid IntermediaryGuid,
      string IntermediaryName,
      string Address1,
      string Address2,
      string City,
      string County,
      string State,
      string ZipCode,
      string ZipPlus,
      string Phone,
      string Fax,
      string WebSite,
      string ISOCountryCode,
      string _Region,
      string Email,
      bool BillingSameAsPrimary,
      string BillingAddress1,
      string BillingAddress2,
      string BillingCity,
      string BillingCounty,
      string BillingState,
      string BillingZipCode,
      string BillingZipPlus,
      string BillingRegion,
      string BillingISOCountryCode,
      string NAIC,
      string CountryCodeforPhone,
      string CountryCodeforFax)
    {
      dsIntermediaries.tblIntermediariesRow row = (dsIntermediaries.tblIntermediariesRow) this.NewRow();
      object[] objArray = new object[29]
      {
        (object) IntermediaryGuid,
        (object) IntermediaryName,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) County,
        (object) State,
        (object) ZipCode,
        (object) ZipPlus,
        (object) Phone,
        (object) Fax,
        (object) WebSite,
        (object) ISOCountryCode,
        (object) _Region,
        null,
        (object) Email,
        (object) BillingSameAsPrimary,
        (object) BillingAddress1,
        (object) BillingAddress2,
        (object) BillingCity,
        (object) BillingCounty,
        (object) BillingState,
        (object) BillingZipCode,
        (object) BillingZipPlus,
        (object) BillingRegion,
        (object) BillingISOCountryCode,
        (object) NAIC,
        (object) CountryCodeforPhone,
        (object) CountryCodeforFax
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIntermediaries.tblIntermediariesRow FindByIntermediaryGuid(Guid IntermediaryGuid)
    {
      return (dsIntermediaries.tblIntermediariesRow) this.Rows.Find(new object[1]
      {
        (object) IntermediaryGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsIntermediaries.tblIntermediariesDataTable intermediariesDataTable = (dsIntermediaries.tblIntermediariesDataTable) base.Clone();
      intermediariesDataTable.InitVars();
      return (DataTable) intermediariesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsIntermediaries.tblIntermediariesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnIntermediaryGuid = this.Columns["IntermediaryGuid"];
      this.columnIntermediaryName = this.Columns["IntermediaryName"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnCounty = this.Columns["County"];
      this.columnState = this.Columns["State"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnZipPlus = this.Columns["ZipPlus"];
      this.columnPhone = this.Columns["Phone"];
      this.columnFax = this.Columns["Fax"];
      this.columnWebSite = this.Columns["WebSite"];
      this.columnISOCountryCode = this.Columns["ISOCountryCode"];
      this.columnRegion = this.Columns["Region"];
      this.columnIntermediaryID = this.Columns["IntermediaryID"];
      this.columnEmail = this.Columns["Email"];
      this.columnBillingSameAsPrimary = this.Columns["BillingSameAsPrimary"];
      this.columnBillingAddress1 = this.Columns["BillingAddress1"];
      this.columnBillingAddress2 = this.Columns["BillingAddress2"];
      this.columnBillingCity = this.Columns["BillingCity"];
      this.columnBillingCounty = this.Columns["BillingCounty"];
      this.columnBillingState = this.Columns["BillingState"];
      this.columnBillingZipCode = this.Columns["BillingZipCode"];
      this.columnBillingZipPlus = this.Columns["BillingZipPlus"];
      this.columnBillingRegion = this.Columns["BillingRegion"];
      this.columnBillingISOCountryCode = this.Columns["BillingISOCountryCode"];
      this.columnNAIC = this.Columns["NAIC"];
      this.columnCountryCodeforPhone = this.Columns["CountryCodeforPhone"];
      this.columnCountryCodeforFax = this.Columns["CountryCodeforFax"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnIntermediaryGuid = new DataColumn("IntermediaryGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntermediaryGuid);
      this.columnIntermediaryName = new DataColumn("IntermediaryName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntermediaryName);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnAddress2 = new DataColumn("Address2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnCounty = new DataColumn("County", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCounty);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnZipPlus = new DataColumn("ZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipPlus);
      this.columnPhone = new DataColumn("Phone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhone);
      this.columnFax = new DataColumn("Fax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFax);
      this.columnWebSite = new DataColumn("WebSite", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWebSite);
      this.columnISOCountryCode = new DataColumn("ISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnISOCountryCode);
      this.columnRegion = new DataColumn("Region", typeof (string), (string) null, MappingType.Element);
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "RegionColumn");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnRegion");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Region");
      this.Columns.Add(this.columnRegion);
      this.columnIntermediaryID = new DataColumn("IntermediaryID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntermediaryID);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.columnBillingSameAsPrimary = new DataColumn("BillingSameAsPrimary", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingSameAsPrimary);
      this.columnBillingAddress1 = new DataColumn("BillingAddress1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingAddress1);
      this.columnBillingAddress2 = new DataColumn("BillingAddress2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingAddress2);
      this.columnBillingCity = new DataColumn("BillingCity", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingCity);
      this.columnBillingCounty = new DataColumn("BillingCounty", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingCounty);
      this.columnBillingState = new DataColumn("BillingState", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingState);
      this.columnBillingZipCode = new DataColumn("BillingZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingZipCode);
      this.columnBillingZipPlus = new DataColumn("BillingZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingZipPlus);
      this.columnBillingRegion = new DataColumn("BillingRegion", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingRegion);
      this.columnBillingISOCountryCode = new DataColumn("BillingISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingISOCountryCode);
      this.columnNAIC = new DataColumn("NAIC", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNAIC);
      this.columnCountryCodeforPhone = new DataColumn("CountryCodeforPhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCountryCodeforPhone);
      this.columnCountryCodeforFax = new DataColumn("CountryCodeforFax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCountryCodeforFax);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsIntermediariesKey1", new DataColumn[1]
      {
        this.columnIntermediaryGuid
      }, true));
      this.columnIntermediaryGuid.AllowDBNull = false;
      this.columnIntermediaryGuid.Unique = true;
      this.columnIntermediaryName.AllowDBNull = false;
      this.columnAddress1.AllowDBNull = false;
      this.columnCity.AllowDBNull = false;
      this.columnZipCode.AllowDBNull = false;
      this.columnISOCountryCode.AllowDBNull = false;
      this.columnISOCountryCode.DefaultValue = (object) "USA";
      this.columnIntermediaryID.AutoIncrement = true;
      this.columnIntermediaryID.AllowDBNull = false;
      this.columnIntermediaryID.ReadOnly = true;
      this.columnBillingSameAsPrimary.AllowDBNull = false;
      this.columnBillingSameAsPrimary.DefaultValue = (object) true;
      this.columnCountryCodeforPhone.MaxLength = 5;
      this.columnCountryCodeforFax.MaxLength = 5;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIntermediaries.tblIntermediariesRow NewtblIntermediariesRow()
    {
      return (dsIntermediaries.tblIntermediariesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsIntermediaries.tblIntermediariesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsIntermediaries.tblIntermediariesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediariesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaries.tblIntermediariesRowChangeEventHandler intermediariesRowChangedEvent = this.tblIntermediariesRowChangedEvent;
      if (intermediariesRowChangedEvent == null)
        return;
      intermediariesRowChangedEvent((object) this, new dsIntermediaries.tblIntermediariesRowChangeEvent((dsIntermediaries.tblIntermediariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediariesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaries.tblIntermediariesRowChangeEventHandler rowChangingEvent = this.tblIntermediariesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsIntermediaries.tblIntermediariesRowChangeEvent((dsIntermediaries.tblIntermediariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediariesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaries.tblIntermediariesRowChangeEventHandler intermediariesRowDeletedEvent = this.tblIntermediariesRowDeletedEvent;
      if (intermediariesRowDeletedEvent == null)
        return;
      intermediariesRowDeletedEvent((object) this, new dsIntermediaries.tblIntermediariesRowChangeEvent((dsIntermediaries.tblIntermediariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediariesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaries.tblIntermediariesRowChangeEventHandler rowDeletingEvent = this.tblIntermediariesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsIntermediaries.tblIntermediariesRowChangeEvent((dsIntermediaries.tblIntermediariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblIntermediariesRow(dsIntermediaries.tblIntermediariesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsIntermediaries dsIntermediaries = new dsIntermediaries();
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
        FixedValue = dsIntermediaries.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblIntermediariesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsIntermediaries.GetSchemaSerializable();
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
  public class tblIntermediaryContactsDataTable : 
    TypedTableBase<dsIntermediaries.tblIntermediaryContactsRow>
  {
    private DataColumn columnIntermediaryContactGuid;
    private DataColumn columnContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblIntermediaryContactsDataTable()
    {
      this.TableName = "tblIntermediaryContacts";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblIntermediaryContactsDataTable(DataTable table)
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
    protected tblIntermediaryContactsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IntermediaryContactGuidColumn => this.columnIntermediaryContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ContactColumn => this.columnContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIntermediaries.tblIntermediaryContactsRow this[int index]
    {
      get => (dsIntermediaries.tblIntermediaryContactsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIntermediaries.tblIntermediaryContactsRowChangeEventHandler tblIntermediaryContactsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIntermediaries.tblIntermediaryContactsRowChangeEventHandler tblIntermediaryContactsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIntermediaries.tblIntermediaryContactsRowChangeEventHandler tblIntermediaryContactsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIntermediaries.tblIntermediaryContactsRowChangeEventHandler tblIntermediaryContactsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblIntermediaryContactsRow(dsIntermediaries.tblIntermediaryContactsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIntermediaries.tblIntermediaryContactsRow AddtblIntermediaryContactsRow(
      Guid IntermediaryContactGuid,
      string Contact)
    {
      dsIntermediaries.tblIntermediaryContactsRow row = (dsIntermediaries.tblIntermediaryContactsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) IntermediaryContactGuid,
        (object) Contact
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIntermediaries.tblIntermediaryContactsRow FindByIntermediaryContactGuid(
      Guid IntermediaryContactGuid)
    {
      return (dsIntermediaries.tblIntermediaryContactsRow) this.Rows.Find(new object[1]
      {
        (object) IntermediaryContactGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsIntermediaries.tblIntermediaryContactsDataTable contactsDataTable = (dsIntermediaries.tblIntermediaryContactsDataTable) base.Clone();
      contactsDataTable.InitVars();
      return (DataTable) contactsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsIntermediaries.tblIntermediaryContactsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnIntermediaryContactGuid = this.Columns["IntermediaryContactGuid"];
      this.columnContact = this.Columns["Contact"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnIntermediaryContactGuid = new DataColumn("IntermediaryContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIntermediaryContactGuid);
      this.columnContact = new DataColumn("Contact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContact);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnIntermediaryContactGuid
      }, true));
      this.columnIntermediaryContactGuid.AllowDBNull = false;
      this.columnIntermediaryContactGuid.Unique = true;
      this.columnContact.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIntermediaries.tblIntermediaryContactsRow NewtblIntermediaryContactsRow()
    {
      return (dsIntermediaries.tblIntermediaryContactsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsIntermediaries.tblIntermediaryContactsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsIntermediaries.tblIntermediaryContactsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediaryContactsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaries.tblIntermediaryContactsRowChangeEventHandler contactsRowChangedEvent = this.tblIntermediaryContactsRowChangedEvent;
      if (contactsRowChangedEvent == null)
        return;
      contactsRowChangedEvent((object) this, new dsIntermediaries.tblIntermediaryContactsRowChangeEvent((dsIntermediaries.tblIntermediaryContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediaryContactsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaries.tblIntermediaryContactsRowChangeEventHandler rowChangingEvent = this.tblIntermediaryContactsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsIntermediaries.tblIntermediaryContactsRowChangeEvent((dsIntermediaries.tblIntermediaryContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediaryContactsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaries.tblIntermediaryContactsRowChangeEventHandler contactsRowDeletedEvent = this.tblIntermediaryContactsRowDeletedEvent;
      if (contactsRowDeletedEvent == null)
        return;
      contactsRowDeletedEvent((object) this, new dsIntermediaries.tblIntermediaryContactsRowChangeEvent((dsIntermediaries.tblIntermediaryContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblIntermediaryContactsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIntermediaries.tblIntermediaryContactsRowChangeEventHandler rowDeletingEvent = this.tblIntermediaryContactsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsIntermediaries.tblIntermediaryContactsRowChangeEvent((dsIntermediaries.tblIntermediaryContactsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblIntermediaryContactsRow(dsIntermediaries.tblIntermediaryContactsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsIntermediaries dsIntermediaries = new dsIntermediaries();
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
        FixedValue = dsIntermediaries.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblIntermediaryContactsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsIntermediaries.GetSchemaSerializable();
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

  public class tblIntermediariesRow : DataRow
  {
    private dsIntermediaries.tblIntermediariesDataTable tabletblIntermediaries;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblIntermediariesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblIntermediaries = (dsIntermediaries.tblIntermediariesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid IntermediaryGuid
    {
      get
      {
        object obj = this[this.tabletblIntermediaries.IntermediaryGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblIntermediaries.IntermediaryGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string IntermediaryName
    {
      get => Conversions.ToString(this[this.tabletblIntermediaries.IntermediaryNameColumn]);
      set => this[this.tabletblIntermediaries.IntermediaryNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Address1
    {
      get => Conversions.ToString(this[this.tabletblIntermediaries.Address1Column]);
      set => this[this.tabletblIntermediaries.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address2' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string City
    {
      get => Conversions.ToString(this[this.tabletblIntermediaries.CityColumn]);
      set => this[this.tabletblIntermediaries.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string County
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.CountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'County' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.CountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ZipCode
    {
      get => Conversions.ToString(this[this.tabletblIntermediaries.ZipCodeColumn]);
      set => this[this.tabletblIntermediaries.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.ZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipPlus' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.ZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Phone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.PhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Phone' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Fax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.FaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fax' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.FaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string WebSite
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.WebSiteColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WebSite' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.WebSiteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ISOCountryCode
    {
      get => Conversions.ToString(this[this.tabletblIntermediaries.ISOCountryCodeColumn]);
      set => this[this.tabletblIntermediaries.ISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string _Region
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.RegionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Region' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.RegionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int IntermediaryID
    {
      get => Conversions.ToInteger(this[this.tabletblIntermediaries.IntermediaryIDColumn]);
      set => this[this.tabletblIntermediaries.IntermediaryIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.EmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Email' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool BillingSameAsPrimary
    {
      get => Conversions.ToBoolean(this[this.tabletblIntermediaries.BillingSameAsPrimaryColumn]);
      set => this[this.tabletblIntermediaries.BillingSameAsPrimaryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BillingAddress1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.BillingAddress1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillingAddress1' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.BillingAddress1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BillingAddress2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.BillingAddress2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillingAddress2' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.BillingAddress2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BillingCity
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.BillingCityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillingCity' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.BillingCityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BillingCounty
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.BillingCountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillingCounty' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.BillingCountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BillingState
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.BillingStateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillingState' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.BillingStateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BillingZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.BillingZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillingZipCode' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.BillingZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BillingZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.BillingZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillingZipPlus' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.BillingZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BillingRegion
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.BillingRegionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillingRegion' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.BillingRegionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BillingISOCountryCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.BillingISOCountryCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillingISOCountryCode' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.BillingISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string NAIC
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.NAICColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NAIC' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.NAICColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CountryCodeforPhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.CountryCodeforPhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CountryCodeforPhone' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.CountryCodeforPhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CountryCodeforFax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaries.CountryCodeforFaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CountryCodeforFax' in table 'tblIntermediaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaries.CountryCodeforFaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddress2Null() => this.IsNull(this.tabletblIntermediaries.Address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabletblIntermediaries.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCountyNull() => this.IsNull(this.tabletblIntermediaries.CountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCountyNull()
    {
      this[this.tabletblIntermediaries.CountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabletblIntermediaries.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabletblIntermediaries.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsZipPlusNull() => this.IsNull(this.tabletblIntermediaries.ZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetZipPlusNull()
    {
      this[this.tabletblIntermediaries.ZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPhoneNull() => this.IsNull(this.tabletblIntermediaries.PhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPhoneNull()
    {
      this[this.tabletblIntermediaries.PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFaxNull() => this.IsNull(this.tabletblIntermediaries.FaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFaxNull()
    {
      this[this.tabletblIntermediaries.FaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsWebSiteNull() => this.IsNull(this.tabletblIntermediaries.WebSiteColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetWebSiteNull()
    {
      this[this.tabletblIntermediaries.WebSiteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Is_RegionNull() => this.IsNull(this.tabletblIntermediaries.RegionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void Set_RegionNull()
    {
      this[this.tabletblIntermediaries.RegionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tabletblIntermediaries.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEmailNull()
    {
      this[this.tabletblIntermediaries.EmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBillingAddress1Null()
    {
      return this.IsNull(this.tabletblIntermediaries.BillingAddress1Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBillingAddress1Null()
    {
      this[this.tabletblIntermediaries.BillingAddress1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBillingAddress2Null()
    {
      return this.IsNull(this.tabletblIntermediaries.BillingAddress2Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBillingAddress2Null()
    {
      this[this.tabletblIntermediaries.BillingAddress2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBillingCityNull() => this.IsNull(this.tabletblIntermediaries.BillingCityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBillingCityNull()
    {
      this[this.tabletblIntermediaries.BillingCityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBillingCountyNull()
    {
      return this.IsNull(this.tabletblIntermediaries.BillingCountyColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBillingCountyNull()
    {
      this[this.tabletblIntermediaries.BillingCountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBillingStateNull() => this.IsNull(this.tabletblIntermediaries.BillingStateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBillingStateNull()
    {
      this[this.tabletblIntermediaries.BillingStateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBillingZipCodeNull()
    {
      return this.IsNull(this.tabletblIntermediaries.BillingZipCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBillingZipCodeNull()
    {
      this[this.tabletblIntermediaries.BillingZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBillingZipPlusNull()
    {
      return this.IsNull(this.tabletblIntermediaries.BillingZipPlusColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBillingZipPlusNull()
    {
      this[this.tabletblIntermediaries.BillingZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBillingRegionNull()
    {
      return this.IsNull(this.tabletblIntermediaries.BillingRegionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBillingRegionNull()
    {
      this[this.tabletblIntermediaries.BillingRegionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBillingISOCountryCodeNull()
    {
      return this.IsNull(this.tabletblIntermediaries.BillingISOCountryCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBillingISOCountryCodeNull()
    {
      this[this.tabletblIntermediaries.BillingISOCountryCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNAICNull() => this.IsNull(this.tabletblIntermediaries.NAICColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNAICNull()
    {
      this[this.tabletblIntermediaries.NAICColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCountryCodeforPhoneNull()
    {
      return this.IsNull(this.tabletblIntermediaries.CountryCodeforPhoneColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCountryCodeforPhoneNull()
    {
      this[this.tabletblIntermediaries.CountryCodeforPhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCountryCodeforFaxNull()
    {
      return this.IsNull(this.tabletblIntermediaries.CountryCodeforFaxColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCountryCodeforFaxNull()
    {
      this[this.tabletblIntermediaries.CountryCodeforFaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblIntermediaryContactsRow : DataRow
  {
    private dsIntermediaries.tblIntermediaryContactsDataTable tabletblIntermediaryContacts;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblIntermediaryContactsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblIntermediaryContacts = (dsIntermediaries.tblIntermediaryContactsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid IntermediaryContactGuid
    {
      get
      {
        object obj = this[this.tabletblIntermediaryContacts.IntermediaryContactGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblIntermediaryContacts.IntermediaryContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Contact
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblIntermediaryContacts.ContactColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Contact' in table 'tblIntermediaryContacts' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblIntermediaryContacts.ContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsContactNull() => this.IsNull(this.tabletblIntermediaryContacts.ContactColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetContactNull()
    {
      this[this.tabletblIntermediaryContacts.ContactColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblIntermediariesRowChangeEvent : EventArgs
  {
    private dsIntermediaries.tblIntermediariesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblIntermediariesRowChangeEvent(
      dsIntermediaries.tblIntermediariesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIntermediaries.tblIntermediariesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblIntermediaryContactsRowChangeEvent : EventArgs
  {
    private dsIntermediaries.tblIntermediaryContactsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblIntermediaryContactsRowChangeEvent(
      dsIntermediaries.tblIntermediaryContactsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIntermediaries.tblIntermediaryContactsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
