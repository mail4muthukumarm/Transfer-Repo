// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Additional_Interests_Admin.dsAdditionalInterest
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Underwriting.Additional_Interests_Admin;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsAdditionalInterest")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsAdditionalInterest : DataSet
{
  private dsAdditionalInterest.tblAdditionalInterestsDataTable tabletblAdditionalInterests;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsAdditionalInterest()
  {
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected dsAdditionalInterest(SerializationInfo info, StreamingContext context)
    : base(info, context, false)
  {
    if (this.IsBinarySerialized(info, context))
    {
      this.InitVars(false);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      this.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }
    else
    {
      string s = (string) info.GetValue("XmlSchema", typeof (string));
      if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
      {
        DataSet dataSet = new DataSet();
        dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        if (dataSet.Tables[nameof (tblAdditionalInterests)] != null)
          base.Tables.Add((DataTable) new dsAdditionalInterest.tblAdditionalInterestsDataTable(dataSet.Tables[nameof (tblAdditionalInterests)]));
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
  public dsAdditionalInterest.tblAdditionalInterestsDataTable tblAdditionalInterests
  {
    get => this.tabletblAdditionalInterests;
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
    dsAdditionalInterest additionalInterest = (dsAdditionalInterest) base.Clone();
    additionalInterest.InitVars();
    additionalInterest.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) additionalInterest;
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
      if (dataSet.Tables["tblAdditionalInterests"] != null)
        base.Tables.Add((DataTable) new dsAdditionalInterest.tblAdditionalInterestsDataTable(dataSet.Tables["tblAdditionalInterests"]));
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
    this.tabletblAdditionalInterests = (dsAdditionalInterest.tblAdditionalInterestsDataTable) base.Tables["tblAdditionalInterests"];
    if (!initTable || this.tabletblAdditionalInterests == null)
      return;
    this.tabletblAdditionalInterests.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsAdditionalInterest);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsAdditionalInterest.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblAdditionalInterests = new dsAdditionalInterest.tblAdditionalInterestsDataTable();
    base.Tables.Add((DataTable) this.tabletblAdditionalInterests);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblAdditionalInterests() => false;

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
    dsAdditionalInterest additionalInterest = new dsAdditionalInterest();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = additionalInterest.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = additionalInterest.GetSchemaSerializable();
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
              return typedDataSetSchema;
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
    return typedDataSetSchema;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblAdditionalInterestsRowChangeEventHandler(
    object sender,
    dsAdditionalInterest.tblAdditionalInterestsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblAdditionalInterestsDataTable : 
    TypedTableBase<dsAdditionalInterest.tblAdditionalInterestsRow>
  {
    private DataColumn columnInterestID;
    private DataColumn columnInterest;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnCounty;
    private DataColumn columnStateID;
    private DataColumn columnRegion;
    private DataColumn columnISOCountryCode;
    private DataColumn columnZipCode;
    private DataColumn columnZipPlus;
    private DataColumn columnMobile;
    private DataColumn columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblAdditionalInterestsDataTable()
    {
      this.TableName = "tblAdditionalInterests";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblAdditionalInterestsDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblAdditionalInterestsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InterestIDColumn => this.columnInterestID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InterestColumn => this.columnInterest;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Address1Column => this.columnAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Address2Column => this.columnAddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CountyColumn => this.columnCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RegionColumn => this.columnRegion;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ISOCountryCodeColumn => this.columnISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ZipPlusColumn => this.columnZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MobileColumn => this.columnMobile;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdditionalInterest.tblAdditionalInterestsRow this[int index]
    {
      get => (dsAdditionalInterest.tblAdditionalInterestsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdditionalInterest.tblAdditionalInterestsRowChangeEventHandler tblAdditionalInterestsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdditionalInterest.tblAdditionalInterestsRowChangeEventHandler tblAdditionalInterestsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdditionalInterest.tblAdditionalInterestsRowChangeEventHandler tblAdditionalInterestsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsAdditionalInterest.tblAdditionalInterestsRowChangeEventHandler tblAdditionalInterestsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblAdditionalInterestsRow(dsAdditionalInterest.tblAdditionalInterestsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdditionalInterest.tblAdditionalInterestsRow AddtblAdditionalInterestsRow(
      string Interest,
      string Address1,
      string Address2,
      string City,
      string County,
      string StateID,
      string Region,
      string ISOCountryCode,
      string ZipCode,
      string ZipPlus,
      string Mobile,
      string Email)
    {
      dsAdditionalInterest.tblAdditionalInterestsRow row = (dsAdditionalInterest.tblAdditionalInterestsRow) this.NewRow();
      object[] objArray = new object[13]
      {
        null,
        (object) Interest,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) County,
        (object) StateID,
        (object) Region,
        (object) ISOCountryCode,
        (object) ZipCode,
        (object) ZipPlus,
        (object) Mobile,
        (object) Email
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdditionalInterest.tblAdditionalInterestsRow FindByInterestID(int InterestID)
    {
      return (dsAdditionalInterest.tblAdditionalInterestsRow) this.Rows.Find(new object[1]
      {
        (object) InterestID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsAdditionalInterest.tblAdditionalInterestsDataTable interestsDataTable = (dsAdditionalInterest.tblAdditionalInterestsDataTable) base.Clone();
      interestsDataTable.InitVars();
      return (DataTable) interestsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAdditionalInterest.tblAdditionalInterestsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnInterestID = this.Columns["InterestID"];
      this.columnInterest = this.Columns["Interest"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnCounty = this.Columns["County"];
      this.columnStateID = this.Columns["StateID"];
      this.columnRegion = this.Columns["Region"];
      this.columnISOCountryCode = this.Columns["ISOCountryCode"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnZipPlus = this.Columns["ZipPlus"];
      this.columnMobile = this.Columns["Mobile"];
      this.columnEmail = this.Columns["Email"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnInterestID = new DataColumn("InterestID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInterestID);
      this.columnInterest = new DataColumn("Interest", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInterest);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnAddress2 = new DataColumn("Address2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnCounty = new DataColumn("County", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCounty);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnRegion = new DataColumn("Region", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRegion);
      this.columnISOCountryCode = new DataColumn("ISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnISOCountryCode);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnZipPlus = new DataColumn("ZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipPlus);
      this.columnMobile = new DataColumn("Mobile", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMobile);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnInterestID
      }, true));
      this.columnInterestID.AutoIncrement = true;
      this.columnInterestID.AutoIncrementSeed = -1L;
      this.columnInterestID.AutoIncrementStep = -1L;
      this.columnInterestID.AllowDBNull = false;
      this.columnInterestID.ReadOnly = true;
      this.columnInterestID.Unique = true;
      this.columnInterest.MaxLength = 500;
      this.columnAddress1.MaxLength = 100;
      this.columnAddress2.MaxLength = 100;
      this.columnCity.MaxLength = 50;
      this.columnCounty.MaxLength = 50;
      this.columnStateID.MaxLength = 2;
      this.columnRegion.MaxLength = 50;
      this.columnISOCountryCode.MaxLength = 3;
      this.columnZipCode.MaxLength = 10;
      this.columnZipPlus.MaxLength = 10;
      this.columnMobile.MaxLength = 15;
      this.columnEmail.MaxLength = 75;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdditionalInterest.tblAdditionalInterestsRow NewtblAdditionalInterestsRow()
    {
      return (dsAdditionalInterest.tblAdditionalInterestsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAdditionalInterest.tblAdditionalInterestsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsAdditionalInterest.tblAdditionalInterestsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.tblAdditionalInterestsRowChanged == null)
        return;
      this.tblAdditionalInterestsRowChanged((object) this, new dsAdditionalInterest.tblAdditionalInterestsRowChangeEvent((dsAdditionalInterest.tblAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.tblAdditionalInterestsRowChanging == null)
        return;
      this.tblAdditionalInterestsRowChanging((object) this, new dsAdditionalInterest.tblAdditionalInterestsRowChangeEvent((dsAdditionalInterest.tblAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.tblAdditionalInterestsRowDeleted == null)
        return;
      this.tblAdditionalInterestsRowDeleted((object) this, new dsAdditionalInterest.tblAdditionalInterestsRowChangeEvent((dsAdditionalInterest.tblAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.tblAdditionalInterestsRowDeleting == null)
        return;
      this.tblAdditionalInterestsRowDeleting((object) this, new dsAdditionalInterest.tblAdditionalInterestsRowChangeEvent((dsAdditionalInterest.tblAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblAdditionalInterestsRow(dsAdditionalInterest.tblAdditionalInterestsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsAdditionalInterest additionalInterest = new dsAdditionalInterest();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = additionalInterest.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblAdditionalInterestsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = additionalInterest.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  public class tblAdditionalInterestsRow : DataRow
  {
    private dsAdditionalInterest.tblAdditionalInterestsDataTable tabletblAdditionalInterests;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblAdditionalInterestsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblAdditionalInterests = (dsAdditionalInterest.tblAdditionalInterestsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int InterestID
    {
      get => (int) this[this.tabletblAdditionalInterests.InterestIDColumn];
      set => this[this.tabletblAdditionalInterests.InterestIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Interest
    {
      get
      {
        try
        {
          return (string) this[this.tabletblAdditionalInterests.InterestColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Interest' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.InterestColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return (string) this[this.tabletblAdditionalInterests.Address1Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Address1' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return (string) this[this.tabletblAdditionalInterests.Address2Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Address2' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return (string) this[this.tabletblAdditionalInterests.CityColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'City' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string County
    {
      get
      {
        try
        {
          return (string) this[this.tabletblAdditionalInterests.CountyColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'County' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.CountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return (string) this[this.tabletblAdditionalInterests.StateIDColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'StateID' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Region
    {
      get
      {
        try
        {
          return (string) this[this.tabletblAdditionalInterests.RegionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Region' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.RegionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ISOCountryCode
    {
      get
      {
        try
        {
          return (string) this[this.tabletblAdditionalInterests.ISOCountryCodeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ISOCountryCode' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.ISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return (string) this[this.tabletblAdditionalInterests.ZipCodeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ZipCode' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ZipPlus
    {
      get
      {
        try
        {
          return (string) this[this.tabletblAdditionalInterests.ZipPlusColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ZipPlus' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.ZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Mobile
    {
      get
      {
        try
        {
          return (string) this[this.tabletblAdditionalInterests.MobileColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Mobile' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.MobileColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return (string) this[this.tabletblAdditionalInterests.EmailColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Email' in table 'tblAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblAdditionalInterests.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInterestNull() => this.IsNull(this.tabletblAdditionalInterests.InterestColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInterestNull()
    {
      this[this.tabletblAdditionalInterests.InterestColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAddress1Null() => this.IsNull(this.tabletblAdditionalInterests.Address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabletblAdditionalInterests.Address1Column] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAddress2Null() => this.IsNull(this.tabletblAdditionalInterests.Address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabletblAdditionalInterests.Address2Column] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabletblAdditionalInterests.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCityNull() => this[this.tabletblAdditionalInterests.CityColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCountyNull() => this.IsNull(this.tabletblAdditionalInterests.CountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCountyNull()
    {
      this[this.tabletblAdditionalInterests.CountyColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabletblAdditionalInterests.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblAdditionalInterests.StateIDColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRegionNull() => this.IsNull(this.tabletblAdditionalInterests.RegionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRegionNull()
    {
      this[this.tabletblAdditionalInterests.RegionColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsISOCountryCodeNull()
    {
      return this.IsNull(this.tabletblAdditionalInterests.ISOCountryCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetISOCountryCodeNull()
    {
      this[this.tabletblAdditionalInterests.ISOCountryCodeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tabletblAdditionalInterests.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tabletblAdditionalInterests.ZipCodeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsZipPlusNull() => this.IsNull(this.tabletblAdditionalInterests.ZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetZipPlusNull()
    {
      this[this.tabletblAdditionalInterests.ZipPlusColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMobileNull() => this.IsNull(this.tabletblAdditionalInterests.MobileColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMobileNull()
    {
      this[this.tabletblAdditionalInterests.MobileColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tabletblAdditionalInterests.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEmailNull()
    {
      this[this.tabletblAdditionalInterests.EmailColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblAdditionalInterestsRowChangeEvent : EventArgs
  {
    private dsAdditionalInterest.tblAdditionalInterestsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblAdditionalInterestsRowChangeEvent(
      dsAdditionalInterest.tblAdditionalInterestsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsAdditionalInterest.tblAdditionalInterestsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
