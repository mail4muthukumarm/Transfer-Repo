// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.RRIRequest
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("RRIRequest")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class RRIRequest : DataSet
{
  private RRIRequest.RequestDataTable tableRequest;
  private RRIRequest.LocationDataTable tableLocation;
  private RRIRequest.SIC_CodesDataTable tableSIC_Codes;
  private RRIRequest.ReportsDataTable tableReports;
  private DataRelation relationRequest_Location;
  private DataRelation relationLocation_SIC_Codes;
  private DataRelation relationLocation_Reports;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public RRIRequest()
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
  protected RRIRequest(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (Request)] != null)
          base.Tables.Add((DataTable) new RRIRequest.RequestDataTable(dataSet.Tables[nameof (Request)]));
        if (dataSet.Tables[nameof (Location)] != null)
          base.Tables.Add((DataTable) new RRIRequest.LocationDataTable(dataSet.Tables[nameof (Location)]));
        if (dataSet.Tables[nameof (SIC_Codes)] != null)
          base.Tables.Add((DataTable) new RRIRequest.SIC_CodesDataTable(dataSet.Tables[nameof (SIC_Codes)]));
        if (dataSet.Tables[nameof (Reports)] != null)
          base.Tables.Add((DataTable) new RRIRequest.ReportsDataTable(dataSet.Tables[nameof (Reports)]));
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
  public RRIRequest.RequestDataTable Request => this.tableRequest;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public RRIRequest.LocationDataTable Location => this.tableLocation;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public RRIRequest.SIC_CodesDataTable SIC_Codes => this.tableSIC_Codes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public RRIRequest.ReportsDataTable Reports => this.tableReports;

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
    RRIRequest rriRequest = (RRIRequest) base.Clone();
    rriRequest.InitVars();
    rriRequest.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) rriRequest;
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
      if (dataSet.Tables["Request"] != null)
        base.Tables.Add((DataTable) new RRIRequest.RequestDataTable(dataSet.Tables["Request"]));
      if (dataSet.Tables["Location"] != null)
        base.Tables.Add((DataTable) new RRIRequest.LocationDataTable(dataSet.Tables["Location"]));
      if (dataSet.Tables["SIC_Codes"] != null)
        base.Tables.Add((DataTable) new RRIRequest.SIC_CodesDataTable(dataSet.Tables["SIC_Codes"]));
      if (dataSet.Tables["Reports"] != null)
        base.Tables.Add((DataTable) new RRIRequest.ReportsDataTable(dataSet.Tables["Reports"]));
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
    this.tableRequest = (RRIRequest.RequestDataTable) base.Tables["Request"];
    if (initTable && this.tableRequest != null)
      this.tableRequest.InitVars();
    this.tableLocation = (RRIRequest.LocationDataTable) base.Tables["Location"];
    if (initTable && this.tableLocation != null)
      this.tableLocation.InitVars();
    this.tableSIC_Codes = (RRIRequest.SIC_CodesDataTable) base.Tables["SIC_Codes"];
    if (initTable && this.tableSIC_Codes != null)
      this.tableSIC_Codes.InitVars();
    this.tableReports = (RRIRequest.ReportsDataTable) base.Tables["Reports"];
    if (initTable && this.tableReports != null)
      this.tableReports.InitVars();
    this.relationRequest_Location = this.Relations["Request_Location"];
    this.relationLocation_SIC_Codes = this.Relations["Location_SIC_Codes"];
    this.relationLocation_Reports = this.Relations["Location_Reports"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (RRIRequest);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/RRIRequest.xsd";
    this.Locale = new CultureInfo("");
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableRequest = new RRIRequest.RequestDataTable();
    base.Tables.Add((DataTable) this.tableRequest);
    this.tableLocation = new RRIRequest.LocationDataTable();
    base.Tables.Add((DataTable) this.tableLocation);
    this.tableSIC_Codes = new RRIRequest.SIC_CodesDataTable();
    base.Tables.Add((DataTable) this.tableSIC_Codes);
    this.tableReports = new RRIRequest.ReportsDataTable();
    base.Tables.Add((DataTable) this.tableReports);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("Request_Location", new DataColumn[1]
    {
      this.tableRequest.Request_IdColumn
    }, new DataColumn[1]
    {
      this.tableLocation.Request_IdColumn
    });
    this.tableLocation.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("Location_SIC_Codes", new DataColumn[1]
    {
      this.tableLocation.Location_IdColumn
    }, new DataColumn[1]
    {
      this.tableSIC_Codes.Location_IdColumn
    });
    this.tableSIC_Codes.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("Location_Reports", new DataColumn[1]
    {
      this.tableLocation.Location_IdColumn
    }, new DataColumn[1]
    {
      this.tableReports.Location_IdColumn
    });
    this.tableReports.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    this.relationRequest_Location = new DataRelation("Request_Location", new DataColumn[1]
    {
      this.tableRequest.Request_IdColumn
    }, new DataColumn[1]
    {
      this.tableLocation.Request_IdColumn
    }, false);
    this.relationRequest_Location.Nested = true;
    this.Relations.Add(this.relationRequest_Location);
    this.relationLocation_SIC_Codes = new DataRelation("Location_SIC_Codes", new DataColumn[1]
    {
      this.tableLocation.Location_IdColumn
    }, new DataColumn[1]
    {
      this.tableSIC_Codes.Location_IdColumn
    }, false);
    this.relationLocation_SIC_Codes.Nested = true;
    this.Relations.Add(this.relationLocation_SIC_Codes);
    this.relationLocation_Reports = new DataRelation("Location_Reports", new DataColumn[1]
    {
      this.tableLocation.Location_IdColumn
    }, new DataColumn[1]
    {
      this.tableReports.Location_IdColumn
    }, false);
    this.relationLocation_Reports.Nested = true;
    this.Relations.Add(this.relationLocation_Reports);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeRequest() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeLocation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeSIC_Codes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeReports() => false;

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
    RRIRequest rriRequest = new RRIRequest();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = rriRequest.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = rriRequest.GetSchemaSerializable();
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
  public delegate void RequestRowChangeEventHandler(
    object sender,
    RRIRequest.RequestRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void LocationRowChangeEventHandler(
    object sender,
    RRIRequest.LocationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void SIC_CodesRowChangeEventHandler(
    object sender,
    RRIRequest.SIC_CodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void ReportsRowChangeEventHandler(
    object sender,
    RRIRequest.ReportsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class RequestDataTable : TypedTableBase<RRIRequest.RequestRow>
  {
    private DataColumn columnClient_Code;
    private DataColumn columnLine_of_Business;
    private DataColumn columnPolicy_Number;
    private DataColumn columnRequest_Date;
    private DataColumn columnRequestor_Name;
    private DataColumn columnInsured_Name1;
    private DataColumn columnInsured_Name2;
    private DataColumn columnInsured_Address_1;
    private DataColumn columnInsured_Address_2;
    private DataColumn columnInsured_City;
    private DataColumn columnInsured_State;
    private DataColumn columnInsured_Zipcode;
    private DataColumn columnAgent_Name;
    private DataColumn columnCarrier_Name;
    private DataColumn columnInsured_Contact_Name;
    private DataColumn columnInsured_Contact_Phone;
    private DataColumn columnRequested_For;
    private DataColumn columnRequested_For_Phone;
    private DataColumn columnAgent_Contact;
    private DataColumn columnAgent_Contact_Phone;
    private DataColumn columnRequest_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RequestDataTable()
    {
      this.TableName = "Request";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal RequestDataTable(DataTable table)
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
    protected RequestDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Client_CodeColumn => this.columnClient_Code;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Line_of_BusinessColumn => this.columnLine_of_Business;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Policy_NumberColumn => this.columnPolicy_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Request_DateColumn => this.columnRequest_Date;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Requestor_NameColumn => this.columnRequestor_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Insured_Name1Column => this.columnInsured_Name1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Insured_Name2Column => this.columnInsured_Name2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Insured_Address_1Column => this.columnInsured_Address_1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Insured_Address_2Column => this.columnInsured_Address_2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Insured_CityColumn => this.columnInsured_City;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Insured_StateColumn => this.columnInsured_State;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Insured_ZipcodeColumn => this.columnInsured_Zipcode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Agent_NameColumn => this.columnAgent_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Carrier_NameColumn => this.columnCarrier_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Insured_Contact_NameColumn => this.columnInsured_Contact_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Insured_Contact_PhoneColumn => this.columnInsured_Contact_Phone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Requested_ForColumn => this.columnRequested_For;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Requested_For_PhoneColumn => this.columnRequested_For_Phone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Agent_ContactColumn => this.columnAgent_Contact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Agent_Contact_PhoneColumn => this.columnAgent_Contact_Phone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Request_IdColumn => this.columnRequest_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.RequestRow this[int index] => (RRIRequest.RequestRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.RequestRowChangeEventHandler RequestRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.RequestRowChangeEventHandler RequestRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.RequestRowChangeEventHandler RequestRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.RequestRowChangeEventHandler RequestRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddRequestRow(RRIRequest.RequestRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.RequestRow AddRequestRow(
      string Client_Code,
      string Line_of_Business,
      string Policy_Number,
      string Request_Date,
      string Requestor_Name,
      string Insured_Name1,
      string Insured_Name2,
      string Insured_Address_1,
      string Insured_Address_2,
      string Insured_City,
      string Insured_State,
      string Insured_Zipcode,
      string Agent_Name,
      string Carrier_Name,
      string Insured_Contact_Name,
      string Insured_Contact_Phone,
      string Requested_For,
      string Requested_For_Phone,
      string Agent_Contact,
      string Agent_Contact_Phone)
    {
      RRIRequest.RequestRow row = (RRIRequest.RequestRow) this.NewRow();
      object[] objArray = new object[21]
      {
        (object) Client_Code,
        (object) Line_of_Business,
        (object) Policy_Number,
        (object) Request_Date,
        (object) Requestor_Name,
        (object) Insured_Name1,
        (object) Insured_Name2,
        (object) Insured_Address_1,
        (object) Insured_Address_2,
        (object) Insured_City,
        (object) Insured_State,
        (object) Insured_Zipcode,
        (object) Agent_Name,
        (object) Carrier_Name,
        (object) Insured_Contact_Name,
        (object) Insured_Contact_Phone,
        (object) Requested_For,
        (object) Requested_For_Phone,
        (object) Agent_Contact,
        (object) Agent_Contact_Phone,
        null
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      RRIRequest.RequestDataTable requestDataTable = (RRIRequest.RequestDataTable) base.Clone();
      requestDataTable.InitVars();
      return (DataTable) requestDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new RRIRequest.RequestDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnClient_Code = this.Columns["Client_Code"];
      this.columnLine_of_Business = this.Columns["Line_of_Business"];
      this.columnPolicy_Number = this.Columns["Policy_Number"];
      this.columnRequest_Date = this.Columns["Request_Date"];
      this.columnRequestor_Name = this.Columns["Requestor_Name"];
      this.columnInsured_Name1 = this.Columns["Insured_Name1"];
      this.columnInsured_Name2 = this.Columns["Insured_Name2"];
      this.columnInsured_Address_1 = this.Columns["Insured_Address_1"];
      this.columnInsured_Address_2 = this.Columns["Insured_Address_2"];
      this.columnInsured_City = this.Columns["Insured_City"];
      this.columnInsured_State = this.Columns["Insured_State"];
      this.columnInsured_Zipcode = this.Columns["Insured_Zipcode"];
      this.columnAgent_Name = this.Columns["Agent_Name"];
      this.columnCarrier_Name = this.Columns["Carrier_Name"];
      this.columnInsured_Contact_Name = this.Columns["Insured_Contact_Name"];
      this.columnInsured_Contact_Phone = this.Columns["Insured_Contact_Phone"];
      this.columnRequested_For = this.Columns["Requested_For"];
      this.columnRequested_For_Phone = this.Columns["Requested_For_Phone"];
      this.columnAgent_Contact = this.Columns["Agent_Contact"];
      this.columnAgent_Contact_Phone = this.Columns["Agent_Contact_Phone"];
      this.columnRequest_Id = this.Columns["Request_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnClient_Code = new DataColumn("Client_Code", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClient_Code);
      this.columnLine_of_Business = new DataColumn("Line_of_Business", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLine_of_Business);
      this.columnPolicy_Number = new DataColumn("Policy_Number", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicy_Number);
      this.columnRequest_Date = new DataColumn("Request_Date", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequest_Date);
      this.columnRequestor_Name = new DataColumn("Requestor_Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequestor_Name);
      this.columnInsured_Name1 = new DataColumn("Insured_Name1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured_Name1);
      this.columnInsured_Name2 = new DataColumn("Insured_Name2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured_Name2);
      this.columnInsured_Address_1 = new DataColumn("Insured_Address_1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured_Address_1);
      this.columnInsured_Address_2 = new DataColumn("Insured_Address_2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured_Address_2);
      this.columnInsured_City = new DataColumn("Insured_City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured_City);
      this.columnInsured_State = new DataColumn("Insured_State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured_State);
      this.columnInsured_Zipcode = new DataColumn("Insured_Zipcode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured_Zipcode);
      this.columnAgent_Name = new DataColumn("Agent_Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAgent_Name);
      this.columnCarrier_Name = new DataColumn("Carrier_Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCarrier_Name);
      this.columnInsured_Contact_Name = new DataColumn("Insured_Contact_Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured_Contact_Name);
      this.columnInsured_Contact_Phone = new DataColumn("Insured_Contact_Phone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured_Contact_Phone);
      this.columnRequested_For = new DataColumn("Requested_For", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequested_For);
      this.columnRequested_For_Phone = new DataColumn("Requested_For_Phone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequested_For_Phone);
      this.columnAgent_Contact = new DataColumn("Agent_Contact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAgent_Contact);
      this.columnAgent_Contact_Phone = new DataColumn("Agent_Contact_Phone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAgent_Contact_Phone);
      this.columnRequest_Id = new DataColumn("Request_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnRequest_Id);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnRequest_Id
      }, true));
      this.columnClient_Code.AllowDBNull = false;
      this.columnLine_of_Business.AllowDBNull = false;
      this.columnPolicy_Number.AllowDBNull = false;
      this.columnRequest_Date.AllowDBNull = false;
      this.columnInsured_Name1.AllowDBNull = false;
      this.columnAgent_Name.AllowDBNull = false;
      this.columnCarrier_Name.AllowDBNull = false;
      this.columnInsured_Contact_Name.AllowDBNull = false;
      this.columnInsured_Contact_Phone.AllowDBNull = false;
      this.columnRequest_Id.AutoIncrement = true;
      this.columnRequest_Id.AllowDBNull = false;
      this.columnRequest_Id.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.RequestRow NewRequestRow() => (RRIRequest.RequestRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new RRIRequest.RequestRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (RRIRequest.RequestRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.RequestRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.RequestRowChangeEventHandler requestRowChangedEvent = this.RequestRowChangedEvent;
      if (requestRowChangedEvent == null)
        return;
      requestRowChangedEvent((object) this, new RRIRequest.RequestRowChangeEvent((RRIRequest.RequestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.RequestRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.RequestRowChangeEventHandler rowChangingEvent = this.RequestRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new RRIRequest.RequestRowChangeEvent((RRIRequest.RequestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.RequestRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.RequestRowChangeEventHandler requestRowDeletedEvent = this.RequestRowDeletedEvent;
      if (requestRowDeletedEvent == null)
        return;
      requestRowDeletedEvent((object) this, new RRIRequest.RequestRowChangeEvent((RRIRequest.RequestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.RequestRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.RequestRowChangeEventHandler rowDeletingEvent = this.RequestRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new RRIRequest.RequestRowChangeEvent((RRIRequest.RequestRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveRequestRow(RRIRequest.RequestRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      RRIRequest rriRequest = new RRIRequest();
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
        FixedValue = rriRequest.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (RequestDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = rriRequest.GetSchemaSerializable();
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
  public class LocationDataTable : TypedTableBase<RRIRequest.LocationRow>
  {
    private DataColumn columnLocation_Address1;
    private DataColumn columnLocation_Address2;
    private DataColumn columnLocation_City;
    private DataColumn columnLocation_State;
    private DataColumn columnLocation_Zipcode;
    private DataColumn columnLocation_Description;
    private DataColumn columnLocation_Contact_Name;
    private DataColumn columnLocation_Contact_Phone;
    private DataColumn columnRush;
    private DataColumn columnDue_Date;
    private DataColumn columnCustomer_Reference_ID;
    private DataColumn columnSpecial_Instructions;
    private DataColumn columnLocation_Id;
    private DataColumn columnRequest_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public LocationDataTable()
    {
      this.TableName = "Location";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal LocationDataTable(DataTable table)
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
    protected LocationDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Location_Address1Column => this.columnLocation_Address1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Location_Address2Column => this.columnLocation_Address2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Location_CityColumn => this.columnLocation_City;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Location_StateColumn => this.columnLocation_State;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Location_ZipcodeColumn => this.columnLocation_Zipcode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Location_DescriptionColumn => this.columnLocation_Description;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Location_Contact_NameColumn => this.columnLocation_Contact_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Location_Contact_PhoneColumn => this.columnLocation_Contact_Phone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RushColumn => this.columnRush;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Due_DateColumn => this.columnDue_Date;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Customer_Reference_IDColumn => this.columnCustomer_Reference_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Special_InstructionsColumn => this.columnSpecial_Instructions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Location_IdColumn => this.columnLocation_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Request_IdColumn => this.columnRequest_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.LocationRow this[int index] => (RRIRequest.LocationRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.LocationRowChangeEventHandler LocationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.LocationRowChangeEventHandler LocationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.LocationRowChangeEventHandler LocationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.LocationRowChangeEventHandler LocationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddLocationRow(RRIRequest.LocationRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.LocationRow AddLocationRow(
      string Location_Address1,
      string Location_Address2,
      string Location_City,
      string Location_State,
      string Location_Zipcode,
      string Location_Description,
      string Location_Contact_Name,
      string Location_Contact_Phone,
      bool Rush,
      string Due_Date,
      string Customer_Reference_ID,
      string Special_Instructions,
      RRIRequest.RequestRow parentRequestRowByRequest_Location)
    {
      RRIRequest.LocationRow row = (RRIRequest.LocationRow) this.NewRow();
      object[] objArray = new object[14]
      {
        (object) Location_Address1,
        (object) Location_Address2,
        (object) Location_City,
        (object) Location_State,
        (object) Location_Zipcode,
        (object) Location_Description,
        (object) Location_Contact_Name,
        (object) Location_Contact_Phone,
        (object) Rush,
        (object) Due_Date,
        (object) Customer_Reference_ID,
        (object) Special_Instructions,
        null,
        null
      };
      if (parentRequestRowByRequest_Location != null)
        objArray[13] = RuntimeHelpers.GetObjectValue(parentRequestRowByRequest_Location[20]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      RRIRequest.LocationDataTable locationDataTable = (RRIRequest.LocationDataTable) base.Clone();
      locationDataTable.InitVars();
      return (DataTable) locationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new RRIRequest.LocationDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnLocation_Address1 = this.Columns["Location_Address1"];
      this.columnLocation_Address2 = this.Columns["Location_Address2"];
      this.columnLocation_City = this.Columns["Location_City"];
      this.columnLocation_State = this.Columns["Location_State"];
      this.columnLocation_Zipcode = this.Columns["Location_Zipcode"];
      this.columnLocation_Description = this.Columns["Location_Description"];
      this.columnLocation_Contact_Name = this.Columns["Location_Contact_Name"];
      this.columnLocation_Contact_Phone = this.Columns["Location_Contact_Phone"];
      this.columnRush = this.Columns["Rush"];
      this.columnDue_Date = this.Columns["Due_Date"];
      this.columnCustomer_Reference_ID = this.Columns["Customer_Reference_ID"];
      this.columnSpecial_Instructions = this.Columns["Special_Instructions"];
      this.columnLocation_Id = this.Columns["Location_Id"];
      this.columnRequest_Id = this.Columns["Request_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnLocation_Address1 = new DataColumn("Location_Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation_Address1);
      this.columnLocation_Address2 = new DataColumn("Location_Address2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation_Address2);
      this.columnLocation_City = new DataColumn("Location_City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation_City);
      this.columnLocation_State = new DataColumn("Location_State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation_State);
      this.columnLocation_Zipcode = new DataColumn("Location_Zipcode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation_Zipcode);
      this.columnLocation_Description = new DataColumn("Location_Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation_Description);
      this.columnLocation_Contact_Name = new DataColumn("Location_Contact_Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation_Contact_Name);
      this.columnLocation_Contact_Phone = new DataColumn("Location_Contact_Phone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation_Contact_Phone);
      this.columnRush = new DataColumn("Rush", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRush);
      this.columnDue_Date = new DataColumn("Due_Date", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDue_Date);
      this.columnCustomer_Reference_ID = new DataColumn("Customer_Reference_ID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCustomer_Reference_ID);
      this.columnSpecial_Instructions = new DataColumn("Special_Instructions", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecial_Instructions);
      this.columnLocation_Id = new DataColumn("Location_Id", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation_Id);
      this.columnRequest_Id = new DataColumn("Request_Id", typeof (int), (string) null, MappingType.Hidden);
      this.Columns.Add(this.columnRequest_Id);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnLocation_Id
      }, true));
      this.columnLocation_Address1.AllowDBNull = false;
      this.columnLocation_City.AllowDBNull = false;
      this.columnLocation_State.AllowDBNull = false;
      this.columnLocation_Description.AllowDBNull = false;
      this.columnLocation_Contact_Name.AllowDBNull = false;
      this.columnLocation_Contact_Phone.AllowDBNull = false;
      this.columnRush.AllowDBNull = false;
      this.columnDue_Date.AllowDBNull = false;
      this.columnLocation_Id.AutoIncrement = true;
      this.columnLocation_Id.AllowDBNull = false;
      this.columnLocation_Id.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.LocationRow NewLocationRow() => (RRIRequest.LocationRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new RRIRequest.LocationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (RRIRequest.LocationRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LocationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.LocationRowChangeEventHandler locationRowChangedEvent = this.LocationRowChangedEvent;
      if (locationRowChangedEvent == null)
        return;
      locationRowChangedEvent((object) this, new RRIRequest.LocationRowChangeEvent((RRIRequest.LocationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LocationRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.LocationRowChangeEventHandler rowChangingEvent = this.LocationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new RRIRequest.LocationRowChangeEvent((RRIRequest.LocationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LocationRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.LocationRowChangeEventHandler locationRowDeletedEvent = this.LocationRowDeletedEvent;
      if (locationRowDeletedEvent == null)
        return;
      locationRowDeletedEvent((object) this, new RRIRequest.LocationRowChangeEvent((RRIRequest.LocationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LocationRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.LocationRowChangeEventHandler rowDeletingEvent = this.LocationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new RRIRequest.LocationRowChangeEvent((RRIRequest.LocationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveLocationRow(RRIRequest.LocationRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      RRIRequest rriRequest = new RRIRequest();
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
        FixedValue = rriRequest.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (LocationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = rriRequest.GetSchemaSerializable();
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
  public class SIC_CodesDataTable : TypedTableBase<RRIRequest.SIC_CodesRow>
  {
    private DataColumn columnSIC_Code;
    private DataColumn columnLocation_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public SIC_CodesDataTable()
    {
      this.TableName = "SIC_Codes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal SIC_CodesDataTable(DataTable table)
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
    protected SIC_CodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SIC_CodeColumn => this.columnSIC_Code;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Location_IdColumn => this.columnLocation_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.SIC_CodesRow this[int index] => (RRIRequest.SIC_CodesRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.SIC_CodesRowChangeEventHandler SIC_CodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.SIC_CodesRowChangeEventHandler SIC_CodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.SIC_CodesRowChangeEventHandler SIC_CodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.SIC_CodesRowChangeEventHandler SIC_CodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddSIC_CodesRow(RRIRequest.SIC_CodesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.SIC_CodesRow AddSIC_CodesRow(
      string SIC_Code,
      RRIRequest.LocationRow parentLocationRowByLocation_SIC_Codes)
    {
      RRIRequest.SIC_CodesRow row = (RRIRequest.SIC_CodesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) SIC_Code,
        null
      };
      if (parentLocationRowByLocation_SIC_Codes != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentLocationRowByLocation_SIC_Codes[12]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      RRIRequest.SIC_CodesDataTable sicCodesDataTable = (RRIRequest.SIC_CodesDataTable) base.Clone();
      sicCodesDataTable.InitVars();
      return (DataTable) sicCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new RRIRequest.SIC_CodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnSIC_Code = this.Columns["SIC_Code"];
      this.columnLocation_Id = this.Columns["Location_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnSIC_Code = new DataColumn("SIC_Code", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSIC_Code);
      this.columnLocation_Id = new DataColumn("Location_Id", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation_Id);
      this.columnSIC_Code.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.SIC_CodesRow NewSIC_CodesRow() => (RRIRequest.SIC_CodesRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new RRIRequest.SIC_CodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (RRIRequest.SIC_CodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SIC_CodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.SIC_CodesRowChangeEventHandler codesRowChangedEvent = this.SIC_CodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new RRIRequest.SIC_CodesRowChangeEvent((RRIRequest.SIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SIC_CodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.SIC_CodesRowChangeEventHandler rowChangingEvent = this.SIC_CodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new RRIRequest.SIC_CodesRowChangeEvent((RRIRequest.SIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SIC_CodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.SIC_CodesRowChangeEventHandler codesRowDeletedEvent = this.SIC_CodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new RRIRequest.SIC_CodesRowChangeEvent((RRIRequest.SIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SIC_CodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.SIC_CodesRowChangeEventHandler rowDeletingEvent = this.SIC_CodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new RRIRequest.SIC_CodesRowChangeEvent((RRIRequest.SIC_CodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveSIC_CodesRow(RRIRequest.SIC_CodesRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      RRIRequest rriRequest = new RRIRequest();
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
        FixedValue = rriRequest.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (SIC_CodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = rriRequest.GetSchemaSerializable();
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
  public class ReportsDataTable : TypedTableBase<RRIRequest.ReportsRow>
  {
    private DataColumn columnItem_Name;
    private DataColumn columnValue;
    private DataColumn columnLocation_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ReportsDataTable()
    {
      this.TableName = "Reports";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ReportsDataTable(DataTable table)
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
    protected ReportsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Item_NameColumn => this.columnItem_Name;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ValueColumn => this.columnValue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Location_IdColumn => this.columnLocation_Id;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.ReportsRow this[int index] => (RRIRequest.ReportsRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.ReportsRowChangeEventHandler ReportsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.ReportsRowChangeEventHandler ReportsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.ReportsRowChangeEventHandler ReportsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event RRIRequest.ReportsRowChangeEventHandler ReportsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddReportsRow(RRIRequest.ReportsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.ReportsRow AddReportsRow(
      string Item_Name,
      string Value,
      RRIRequest.LocationRow parentLocationRowByLocation_Reports)
    {
      RRIRequest.ReportsRow row = (RRIRequest.ReportsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) Item_Name,
        (object) Value,
        null
      };
      if (parentLocationRowByLocation_Reports != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parentLocationRowByLocation_Reports[12]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      RRIRequest.ReportsDataTable reportsDataTable = (RRIRequest.ReportsDataTable) base.Clone();
      reportsDataTable.InitVars();
      return (DataTable) reportsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new RRIRequest.ReportsDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnItem_Name = this.Columns["Item_Name"];
      this.columnValue = this.Columns["Value"];
      this.columnLocation_Id = this.Columns["Location_Id"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnItem_Name = new DataColumn("Item_Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnItem_Name);
      this.columnValue = new DataColumn("Value", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnValue);
      this.columnLocation_Id = new DataColumn("Location_Id", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation_Id);
      this.columnItem_Name.AllowDBNull = false;
      this.columnValue.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.ReportsRow NewReportsRow() => (RRIRequest.ReportsRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new RRIRequest.ReportsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (RRIRequest.ReportsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReportsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.ReportsRowChangeEventHandler reportsRowChangedEvent = this.ReportsRowChangedEvent;
      if (reportsRowChangedEvent == null)
        return;
      reportsRowChangedEvent((object) this, new RRIRequest.ReportsRowChangeEvent((RRIRequest.ReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReportsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.ReportsRowChangeEventHandler rowChangingEvent = this.ReportsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new RRIRequest.ReportsRowChangeEvent((RRIRequest.ReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReportsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.ReportsRowChangeEventHandler reportsRowDeletedEvent = this.ReportsRowDeletedEvent;
      if (reportsRowDeletedEvent == null)
        return;
      reportsRowDeletedEvent((object) this, new RRIRequest.ReportsRowChangeEvent((RRIRequest.ReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReportsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      RRIRequest.ReportsRowChangeEventHandler rowDeletingEvent = this.ReportsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new RRIRequest.ReportsRowChangeEvent((RRIRequest.ReportsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveReportsRow(RRIRequest.ReportsRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      RRIRequest rriRequest = new RRIRequest();
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
        FixedValue = rriRequest.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ReportsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = rriRequest.GetSchemaSerializable();
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

  public class RequestRow : DataRow
  {
    private RRIRequest.RequestDataTable tableRequest;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal RequestRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableRequest = (RRIRequest.RequestDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Client_Code
    {
      get => Conversions.ToString(this[this.tableRequest.Client_CodeColumn]);
      set => this[this.tableRequest.Client_CodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Line_of_Business
    {
      get => Conversions.ToString(this[this.tableRequest.Line_of_BusinessColumn]);
      set => this[this.tableRequest.Line_of_BusinessColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Policy_Number
    {
      get => Conversions.ToString(this[this.tableRequest.Policy_NumberColumn]);
      set => this[this.tableRequest.Policy_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Request_Date
    {
      get => Conversions.ToString(this[this.tableRequest.Request_DateColumn]);
      set => this[this.tableRequest.Request_DateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Requestor_Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRequest.Requestor_NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Requestor_Name' in table 'Request' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRequest.Requestor_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured_Name1
    {
      get => Conversions.ToString(this[this.tableRequest.Insured_Name1Column]);
      set => this[this.tableRequest.Insured_Name1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured_Name2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRequest.Insured_Name2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Insured_Name2' in table 'Request' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRequest.Insured_Name2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured_Address_1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRequest.Insured_Address_1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Insured_Address_1' in table 'Request' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRequest.Insured_Address_1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured_Address_2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRequest.Insured_Address_2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Insured_Address_2' in table 'Request' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRequest.Insured_Address_2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured_City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRequest.Insured_CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Insured_City' in table 'Request' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRequest.Insured_CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured_State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRequest.Insured_StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Insured_State' in table 'Request' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRequest.Insured_StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured_Zipcode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRequest.Insured_ZipcodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Insured_Zipcode' in table 'Request' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRequest.Insured_ZipcodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Agent_Name
    {
      get => Conversions.ToString(this[this.tableRequest.Agent_NameColumn]);
      set => this[this.tableRequest.Agent_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Carrier_Name
    {
      get => Conversions.ToString(this[this.tableRequest.Carrier_NameColumn]);
      set => this[this.tableRequest.Carrier_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured_Contact_Name
    {
      get => Conversions.ToString(this[this.tableRequest.Insured_Contact_NameColumn]);
      set => this[this.tableRequest.Insured_Contact_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured_Contact_Phone
    {
      get => Conversions.ToString(this[this.tableRequest.Insured_Contact_PhoneColumn]);
      set => this[this.tableRequest.Insured_Contact_PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Requested_For
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRequest.Requested_ForColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Requested_For' in table 'Request' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRequest.Requested_ForColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Requested_For_Phone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRequest.Requested_For_PhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Requested_For_Phone' in table 'Request' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRequest.Requested_For_PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Agent_Contact
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRequest.Agent_ContactColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Agent_Contact' in table 'Request' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRequest.Agent_ContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Agent_Contact_Phone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableRequest.Agent_Contact_PhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Agent_Contact_Phone' in table 'Request' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableRequest.Agent_Contact_PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Request_Id
    {
      get => Conversions.ToInteger(this[this.tableRequest.Request_IdColumn]);
      set => this[this.tableRequest.Request_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRequestor_NameNull() => this.IsNull(this.tableRequest.Requestor_NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRequestor_NameNull()
    {
      this[this.tableRequest.Requestor_NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsured_Name2Null() => this.IsNull(this.tableRequest.Insured_Name2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsured_Name2Null()
    {
      this[this.tableRequest.Insured_Name2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsured_Address_1Null() => this.IsNull(this.tableRequest.Insured_Address_1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsured_Address_1Null()
    {
      this[this.tableRequest.Insured_Address_1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsured_Address_2Null() => this.IsNull(this.tableRequest.Insured_Address_2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsured_Address_2Null()
    {
      this[this.tableRequest.Insured_Address_2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsured_CityNull() => this.IsNull(this.tableRequest.Insured_CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsured_CityNull()
    {
      this[this.tableRequest.Insured_CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsured_StateNull() => this.IsNull(this.tableRequest.Insured_StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsured_StateNull()
    {
      this[this.tableRequest.Insured_StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsured_ZipcodeNull() => this.IsNull(this.tableRequest.Insured_ZipcodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsured_ZipcodeNull()
    {
      this[this.tableRequest.Insured_ZipcodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRequested_ForNull() => this.IsNull(this.tableRequest.Requested_ForColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRequested_ForNull()
    {
      this[this.tableRequest.Requested_ForColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRequested_For_PhoneNull()
    {
      return this.IsNull(this.tableRequest.Requested_For_PhoneColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRequested_For_PhoneNull()
    {
      this[this.tableRequest.Requested_For_PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAgent_ContactNull() => this.IsNull(this.tableRequest.Agent_ContactColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAgent_ContactNull()
    {
      this[this.tableRequest.Agent_ContactColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAgent_Contact_PhoneNull()
    {
      return this.IsNull(this.tableRequest.Agent_Contact_PhoneColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAgent_Contact_PhoneNull()
    {
      this[this.tableRequest.Agent_Contact_PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.LocationRow[] GetLocationRows()
    {
      return this.Table.ChildRelations["Request_Location"] != null ? (RRIRequest.LocationRow[]) this.GetChildRows(this.Table.ChildRelations["Request_Location"]) : new RRIRequest.LocationRow[0];
    }
  }

  public class LocationRow : DataRow
  {
    private RRIRequest.LocationDataTable tableLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal LocationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableLocation = (RRIRequest.LocationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Location_Address1
    {
      get => Conversions.ToString(this[this.tableLocation.Location_Address1Column]);
      set => this[this.tableLocation.Location_Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Location_Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableLocation.Location_Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Location_Address2' in table 'Location' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLocation.Location_Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Location_City
    {
      get => Conversions.ToString(this[this.tableLocation.Location_CityColumn]);
      set => this[this.tableLocation.Location_CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Location_State
    {
      get => Conversions.ToString(this[this.tableLocation.Location_StateColumn]);
      set => this[this.tableLocation.Location_StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Location_Zipcode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableLocation.Location_ZipcodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Location_Zipcode' in table 'Location' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLocation.Location_ZipcodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Location_Description
    {
      get => Conversions.ToString(this[this.tableLocation.Location_DescriptionColumn]);
      set => this[this.tableLocation.Location_DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Location_Contact_Name
    {
      get => Conversions.ToString(this[this.tableLocation.Location_Contact_NameColumn]);
      set => this[this.tableLocation.Location_Contact_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Location_Contact_Phone
    {
      get => Conversions.ToString(this[this.tableLocation.Location_Contact_PhoneColumn]);
      set => this[this.tableLocation.Location_Contact_PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Rush
    {
      get => Conversions.ToBoolean(this[this.tableLocation.RushColumn]);
      set => this[this.tableLocation.RushColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Due_Date
    {
      get => Conversions.ToString(this[this.tableLocation.Due_DateColumn]);
      set => this[this.tableLocation.Due_DateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Customer_Reference_ID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableLocation.Customer_Reference_IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Customer_Reference_ID' in table 'Location' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLocation.Customer_Reference_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Special_Instructions
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableLocation.Special_InstructionsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Special_Instructions' in table 'Location' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLocation.Special_InstructionsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Location_Id
    {
      get => Conversions.ToInteger(this[this.tableLocation.Location_IdColumn]);
      set => this[this.tableLocation.Location_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Request_Id
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableLocation.Request_IdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Request_Id' in table 'Location' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLocation.Request_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.RequestRow RequestRow
    {
      get
      {
        return (RRIRequest.RequestRow) this.GetParentRow(this.Table.ParentRelations["Request_Location"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["Request_Location"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocation_Address2Null()
    {
      return this.IsNull(this.tableLocation.Location_Address2Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocation_Address2Null()
    {
      this[this.tableLocation.Location_Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocation_ZipcodeNull() => this.IsNull(this.tableLocation.Location_ZipcodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocation_ZipcodeNull()
    {
      this[this.tableLocation.Location_ZipcodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCustomer_Reference_IDNull()
    {
      return this.IsNull(this.tableLocation.Customer_Reference_IDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCustomer_Reference_IDNull()
    {
      this[this.tableLocation.Customer_Reference_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSpecial_InstructionsNull()
    {
      return this.IsNull(this.tableLocation.Special_InstructionsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSpecial_InstructionsNull()
    {
      this[this.tableLocation.Special_InstructionsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRequest_IdNull() => this.IsNull(this.tableLocation.Request_IdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRequest_IdNull()
    {
      this[this.tableLocation.Request_IdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.SIC_CodesRow[] GetSIC_CodesRows()
    {
      return this.Table.ChildRelations["Location_SIC_Codes"] != null ? (RRIRequest.SIC_CodesRow[]) this.GetChildRows(this.Table.ChildRelations["Location_SIC_Codes"]) : new RRIRequest.SIC_CodesRow[0];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.ReportsRow[] GetReportsRows()
    {
      return this.Table.ChildRelations["Location_Reports"] != null ? (RRIRequest.ReportsRow[]) this.GetChildRows(this.Table.ChildRelations["Location_Reports"]) : new RRIRequest.ReportsRow[0];
    }
  }

  public class SIC_CodesRow : DataRow
  {
    private RRIRequest.SIC_CodesDataTable tableSIC_Codes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal SIC_CodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableSIC_Codes = (RRIRequest.SIC_CodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SIC_Code
    {
      get => Conversions.ToString(this[this.tableSIC_Codes.SIC_CodeColumn]);
      set => this[this.tableSIC_Codes.SIC_CodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Location_Id
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableSIC_Codes.Location_IdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Location_Id' in table 'SIC_Codes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSIC_Codes.Location_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.LocationRow LocationRow
    {
      get
      {
        return (RRIRequest.LocationRow) this.GetParentRow(this.Table.ParentRelations["Location_SIC_Codes"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["Location_SIC_Codes"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocation_IdNull() => this.IsNull(this.tableSIC_Codes.Location_IdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocation_IdNull()
    {
      this[this.tableSIC_Codes.Location_IdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class ReportsRow : DataRow
  {
    private RRIRequest.ReportsDataTable tableReports;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ReportsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableReports = (RRIRequest.ReportsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Item_Name
    {
      get => Conversions.ToString(this[this.tableReports.Item_NameColumn]);
      set => this[this.tableReports.Item_NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Value
    {
      get => Conversions.ToString(this[this.tableReports.ValueColumn]);
      set => this[this.tableReports.ValueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Location_Id
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableReports.Location_IdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Location_Id' in table 'Reports' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReports.Location_IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.LocationRow LocationRow
    {
      get
      {
        return (RRIRequest.LocationRow) this.GetParentRow(this.Table.ParentRelations["Location_Reports"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["Location_Reports"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocation_IdNull() => this.IsNull(this.tableReports.Location_IdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocation_IdNull()
    {
      this[this.tableReports.Location_IdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class RequestRowChangeEvent : EventArgs
  {
    private RRIRequest.RequestRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RequestRowChangeEvent(RRIRequest.RequestRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.RequestRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class LocationRowChangeEvent : EventArgs
  {
    private RRIRequest.LocationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public LocationRowChangeEvent(RRIRequest.LocationRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.LocationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class SIC_CodesRowChangeEvent : EventArgs
  {
    private RRIRequest.SIC_CodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public SIC_CodesRowChangeEvent(RRIRequest.SIC_CodesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.SIC_CodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class ReportsRowChangeEvent : EventArgs
  {
    private RRIRequest.ReportsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ReportsRowChangeEvent(RRIRequest.ReportsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public RRIRequest.ReportsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
